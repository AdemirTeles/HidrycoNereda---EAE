/*
 * Hidryco - FieldSignals - sFalha
 * Ultima falha registrada no inversor (LFT 7121 do ATV600 ou evento do Sulzer): codigo, mnemonico e texto em portugues.
 */
using System;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.FieldSignals
{
	public partial class sFalha : NxtControl.GuiFramework.HMISymbol
	{
		public sFalha()
		{
			InitializeComponent();
			this.REQ_NAME_Fired += REQ_NAME_Fired_EventHandler;
			this.REQ_SULZER_Fired += REQ_SULZER_Fired_EventHandler;
		}

		string nome = "";
		int codigo;
		bool temCodigo;

		void REQ_NAME_Fired_EventHandler(object sender, REQ_NAMEEventArgs e) { nome = e.Name ?? ""; Mostra(); }
		void REQ_SULZER_Fired_EventHandler(object sender, REQ_SULZEREventArgs e)
		{
			codigo = e.SULZER_FALHA.HasValue ? e.SULZER_FALHA.Value : 0;
			temCodigo = true;
			Mostra();
		}

		// quebra o texto em ate 2 linhas de ~52 caracteres
		static void Quebra(string t, int max, FreeText a, FreeText b2)
		{
			string l1 = t, l2 = "";
			if (t.Length > max)
			{
				int corte = t.LastIndexOf(' ', max);
				if (corte < 10) corte = max;
				l1 = t.Substring(0, corte); l2 = t.Substring(corte).TrimStart();
				if (l2.Length > max) l2 = l2.Substring(0, max - 1) + "\u2026";
			}
			a.Text = l1; b2.Text = l2;
		}

		void Mostra()
		{
			if (!temCodigo) return;
			string curto, texto;
			sPanel.DescreveFalha(codigo, nome.Contains("V460"), out curto, out texto);
			vCodigo.Text = curto;
			vCodigo.Color = codigo != 0 ? new NxtControl.Drawing.Color(192, 0, 0) : new NxtControl.Drawing.Color(0, 0, 0);
			Quebra(texto, 52, vTexto, vTexto2);
		}
	}
}
