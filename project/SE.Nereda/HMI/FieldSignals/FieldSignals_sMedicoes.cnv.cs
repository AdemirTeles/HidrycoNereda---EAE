/*
 * Hidryco - FieldSignals - sMedicoes
 * Medicoes do inversor (ATV600 por Modbus generico ou Sulzer HST) para o faceplate fpMedicoes do Motor_VS.
 */
using System;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.FieldSignals
{
	public partial class sMedicoes : NxtControl.GuiFramework.HMISymbol
	{
		public sMedicoes()
		{
			InitializeComponent();
			this.REQ_NAME_Fired += REQ_NAME_Fired_EventHandler;
			this.REQ_SULZER_Fired += REQ_SULZER_Fired_EventHandler;
		}

		string nome = "";
		int codigo;
		bool temCodigo;
		bool Sulzer { get { return nome.Contains("V460"); } }

		void REQ_NAME_Fired_EventHandler(object sender, REQ_NAMEEventArgs e)
		{
			nome = e.Name ?? "";
			// Sulzer: potencia em kW (o soprador nao informa a % do ATV)
			vPot.Visible = !Sulzer; vPotKw.Visible = Sulzer;
			MostraCodigo();
		}

		void REQ_SULZER_Fired_EventHandler(object sender, REQ_SULZEREventArgs e)
		{
			codigo = e.SULZER_FALHA.HasValue ? e.SULZER_FALHA.Value : 0;
			temCodigo = true;
			MostraCodigo();
		}

		// quebra o texto em ate 2 linhas de ~44 caracteres
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

		// codigo da ultima falha: LFT 7121 do ATV600 (mnemonico do display) ou evento do Sulzer
		void MostraCodigo()
		{
			if (!temCodigo) return;
			string curto, texto;
			sPanel.DescreveFalha(codigo, Sulzer, out curto, out texto);
			vFalha.Text = curto;
			vFalha.Color = codigo != 0 ? new NxtControl.Drawing.Color(192, 0, 0) : new NxtControl.Drawing.Color(0, 0, 0);
			Quebra(texto, 44, vFalhaTxt, vFalhaTxt2);
		}
	}
}
