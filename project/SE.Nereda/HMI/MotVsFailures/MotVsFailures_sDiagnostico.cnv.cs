/*
 * Criado pelo gerador fp_diag (padrao Hidryco).
 */
using System;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.MotVsFailures
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
		void rxF1Changed(object s, ValueChangedEventArgs e) { if (B(e)) Mostra(v_F1, "ATIVA", Grave); else Mostra(v_F1, "\u2014", Cinza); }
		void rxC1Changed(object s, ValueChangedEventArgs e) { c_F1.Text = e.Value == null ? "0" : Convert.ToString(e.Value); }
		void rxF2Changed(object s, ValueChangedEventArgs e) { if (B(e)) Mostra(v_F2, "ATIVA", Grave); else Mostra(v_F2, "\u2014", Cinza); }
		void rxC2Changed(object s, ValueChangedEventArgs e) { c_F2.Text = e.Value == null ? "0" : Convert.ToString(e.Value); }
		void rxF3Changed(object s, ValueChangedEventArgs e) { if (B(e)) Mostra(v_F3, "ATIVA", Grave); else Mostra(v_F3, "\u2014", Cinza); }
		void rxC3Changed(object s, ValueChangedEventArgs e) { c_F3.Text = e.Value == null ? "0" : Convert.ToString(e.Value); }
		void rxF4Changed(object s, ValueChangedEventArgs e) { if (B(e)) Mostra(v_F4, "ATIVA", Grave); else Mostra(v_F4, "\u2014", Cinza); }
		void rxC4Changed(object s, ValueChangedEventArgs e) { c_F4.Text = e.Value == null ? "0" : Convert.ToString(e.Value); }
		void rxF5Changed(object s, ValueChangedEventArgs e) { if (B(e)) Mostra(v_F5, "ATIVA", Grave); else Mostra(v_F5, "\u2014", Cinza); }
		void rxC5Changed(object s, ValueChangedEventArgs e) { c_F5.Text = e.Value == null ? "0" : Convert.ToString(e.Value); }
		void rxF6Changed(object s, ValueChangedEventArgs e) { if (B(e)) Mostra(v_F6, "ATIVA", Grave); else Mostra(v_F6, "\u2014", Cinza); }
		void rxC6Changed(object s, ValueChangedEventArgs e) { c_F6.Text = e.Value == null ? "0" : Convert.ToString(e.Value); }
	}
}
