/*
 * Criado pelo gerador fp_diag (padrao Hidryco).
 */
using System;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.MotorBaseNer
{
	public partial class sDiagnostico : NxtControl.GuiFramework.HMISymbol
	{
		public sDiagnostico()
		{
			InitializeComponent();
		}

		static readonly NxtControl.Drawing.Color Cinza = new NxtControl.Drawing.Color(64, 64, 64);
		static readonly NxtControl.Drawing.Color Aviso = new NxtControl.Drawing.Color(200, 120, 0);
		static readonly NxtControl.Drawing.Color Grave = new NxtControl.Drawing.Color(210, 0, 0);
		static readonly NxtControl.Drawing.Color Ok = new NxtControl.Drawing.Color(40, 150, 60);
		static void Mostra(FreeText f, string texto, NxtControl.Drawing.Color c) { f.Text = texto; f.Color = c; }
		static bool B(ValueChangedEventArgs e) { return e.Value != null && Convert.ToBoolean(e.Value); }

		bool sim, over, maint, oos;
		void rxOwnerChanged(object s, ValueChangedEventArgs e)
		{
			ushort o = e.Value == null ? (ushort)0 : Convert.ToUInt16(e.Value);
			if (o == 0x10 || o == 0x40) Mostra(v_Modo, "Manual (operador)", Cinza);
			else if (o == 0x08 || o == 0x04) Mostra(v_Modo, "Autom\u00e1tico (programa)", Cinza);
			else Mostra(v_Modo, "\u2014", Cinza);
		}
		void rxIlckChanged(object s, ValueChangedEventArgs e) { if (B(e)) Mostra(v_Ilck, "ATIVO", Grave); else Mostra(v_Ilck, "n\u00e3o", Cinza); }
		void rxPermLigChanged(object s, ValueChangedEventArgs e) { if (B(e)) Mostra(v_PermLig, "liberado", Ok); else Mostra(v_PermLig, "BLOQUEADO", Aviso); }
		void rxPermParChanged(object s, ValueChangedEventArgs e) { if (B(e)) Mostra(v_PermPar, "liberado", Ok); else Mostra(v_PermPar, "BLOQUEADO", Aviso); }
		void rxFailChanged(object s, ValueChangedEventArgs e) { if (B(e)) Mostra(v_Fail, "ATIVA", Grave); else Mostra(v_Fail, "n\u00e3o", Cinza); }
		void rxResetChanged(object s, ValueChangedEventArgs e) { if (B(e)) Mostra(v_Reset, "sim", Aviso); else Mostra(v_Reset, "n\u00e3o", Cinza); }
		void rxExtChanged(object s, ValueChangedEventArgs e) { Mostra(v_Ext, B(e) ? "sim" : "n\u00e3o", Cinza); }
		void rxSimChanged(object s, ValueChangedEventArgs e) { sim = B(e); Especiais(); }
		void rxOverChanged(object s, ValueChangedEventArgs e) { over = B(e); Especiais(); }
		void rxMaintChanged(object s, ValueChangedEventArgs e) { maint = B(e); Especiais(); }
		void rxOosChanged(object s, ValueChangedEventArgs e) { oos = B(e); Especiais(); }
		void Especiais()
		{
			string t = "";
			if (oos) t += (t == "" ? "" : ", ") + "fora de servi\u00e7o";
			if (maint) t += (t == "" ? "" : ", ") + "manuten\u00e7\u00e3o";
			if (sim) t += (t == "" ? "" : ", ") + "simula\u00e7\u00e3o";
			if (over) t += (t == "" ? "" : ", ") + "realim. for\u00e7ada";
			if (t == "") Mostra(v_Esp, "nenhum", Cinza); else Mostra(v_Esp, t, Aviso);
		}
	}
}
