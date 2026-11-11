/*
 * Criado pelo gerador fp_diag (padrao Hidryco).
 */
using System;
using NxtControl.GuiFramework;

namespace SE.Nereda.Faceplates.MotorS
{
	public partial class fpDiagnostico : NxtControl.GuiFramework.HMIFaceplate
	{
		public fpDiagnostico()
		{
			InitializeComponent();
		}

		static readonly NxtControl.Drawing.Color Cinza = new NxtControl.Drawing.Color(64, 64, 64);
		static readonly NxtControl.Drawing.Color Aviso = new NxtControl.Drawing.Color(200, 120, 0);
		static readonly NxtControl.Drawing.Color Grave = new NxtControl.Drawing.Color(210, 0, 0);
		static readonly NxtControl.Drawing.Color Ok = new NxtControl.Drawing.Color(40, 150, 60);
		static void Mostra(FreeText f, string texto, NxtControl.Drawing.Color c) { f.Text = texto; f.Color = c; }
		static bool B(ValueChangedEventArgs e) { return e.Value != null && Convert.ToBoolean(e.Value); }

		void rxProntoChanged(object s, ValueChangedEventArgs e) { if (B(e)) Mostra(v_Pronto, "N\u00c3O", Grave); else Mostra(v_Pronto, "sim", Ok); }
		void rxCircChanged(object s, ValueChangedEventArgs e) { if (B(e)) Mostra(v_Circ, "FALHA", Grave); else Mostra(v_Circ, "ok", Ok); }
		void rxRealimChanged(object s, ValueChangedEventArgs e) { if (B(e)) Mostra(v_Realim, "ATIVA", Grave); else Mostra(v_Realim, "n\u00e3o", Cinza); }
	}
}
