/*
 * Hidryco - Sensor_Generico - fpTrend
 * Grafico do valor do sensor:
 * - escala automatica; abre em 30 min com botoes 5 min / 30 min / 1 h / 8 h; legenda com caixinha para esconder a linha;
 * - limites HH/H/L/LL tracejados (vermelho HH/LL, laranja H/L), ja em unidade de engenharia (conversao no CLP);
 *   limite desabilitado fica invisivel e marcado "(desabilitado)" na legenda;
 * - legenda com a unidade do sensor e o valor com as casas decimais configuradas no sensor (padrao 2).
 */

using System;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Faceplates.Sensor_Generico
{
	public partial class fpTrend : NxtControl.GuiFramework.HMIFaceplate
	{
		public fpTrend()
		{
			InitializeComponent();
			PadraoTrend();
			Atualiza();
		}

		static readonly NxtControl.Drawing.Color VERMELHO = new NxtControl.Drawing.Color(192, 0, 0);
		static readonly NxtControl.Drawing.Color LARANJA = new NxtControl.Drawing.Color(230, 140, 0);
		static readonly NxtControl.Drawing.Color INVISIVEL = new NxtControl.Drawing.Color("Transparent");

		// mascara numerica da legenda (o trend so aceita 0 . , # % e): casas decimais do sensor, padrao 2, maximo 6
		string Formato()
		{
			int n = 2;
			try { if (tCasas.Value != null) n = Convert.ToInt32(tCasas.Value); } catch (Exception) { n = 2; }
			if (n < 0) n = 0;
			if (n > 6) n = 6;
			return n == 0 ? "0" : "0." + new string('0', n);
		}

		void OcultoValueChanged(object sender, ValueChangedEventArgs e)
		{
			Atualiza();
		}

		void Atualiza()
		{
			try
			{
				float min = Convert.ToSingle(tRangeMin.Value), max = Convert.ToSingle(tRangeMax.Value);
				string un = Convert.ToString(tUnidade.Value);
				string sfx = string.IsNullOrEmpty(un) ? "" : " (" + un + ")";
				TrendValueScale esc = trendControl1.ValueScalesLeft;
				if (esc != null) esc.AutoScale = true;          // escala automatica (escolha do usuario 12/11/2026)
				bool[] hab = { Convert.ToBoolean(tHabHH.Value), Convert.ToBoolean(tHabH.Value), Convert.ToBoolean(tHabL.Value), Convert.ToBoolean(tHabLL.Value) };
				string[] nome = { "HH", "H", "L", "LL" };
				NxtControl.Drawing.Color[] cor = { VERMELHO, LARANJA, LARANJA, VERMELHO };
				for (int i = 0; i < trendControl1.Series.Count; i++)
				{
					TrendFastLine s = trendControl1.Series[i] as TrendFastLine;
					if (s == null) continue;
					if (i == 0) { s.LegendName = "Valor" + sfx; s.LegendFormat = Formato(); continue; }
					int k = i - 1;
					if (k > 3) break;
					s.Color = hab[k] ? cor[k] : INVISIVEL;
					s.LegendName = "Limite " + nome[k] + (hab[k] ? sfx : " (desabilitado)");
				}
			}
			catch (Exception ex)
			{
				NxtControl.Services.LoggingService.ErrorFormatted("Sensor_Generico fpTrend: {0}", ex.Message);
			}
		}

		// ---- Padrao dos trends (12/11/2026): escala automatica, 30 min ao abrir, botoes de janela,
		// legenda com nome/valor/caixinha para esconder a linha, barra de ferramentas (zoom, rolar, cursor) visivel.
		void PadraoTrend()
		{
			trendControl1.ToolBarVisible = true;
			trendControl1.LegendVisible = true;
			trendControl1.LegendCheckBoxes = true;
			TrendValueScale esc = trendControl1.ValueScalesLeft;
			if (esc != null) esc.AutoScale = true;
			Janela(btn30m, 30);
		}

		void BtnTempoClick(object sender, EventArgs e)
		{
			if (sender == btn5m) Janela(btn5m, 5);
			else if (sender == btn30m) Janela(btn30m, 30);
			else if (sender == btn1h) Janela(btn1h, 60);
			else if (sender == btn8h) Janela(btn8h, 480);
		}

		void Janela(DrawnButton sel, int minutos)
		{
			trendControl1.TimeSpan = TimeSpan.FromMinutes(minutos);
			foreach (DrawnButton b in new DrawnButton[] { btn5m, btn30m, btn1h, btn8h })
			{
				bool s = b == sel;
				b.BrushColor = s ? new NxtControl.Drawing.Color(60, 60, 60) : new NxtControl.Drawing.Color(215, 215, 215);
				b.TextColor = s ? new NxtControl.Drawing.Color(255, 255, 255) : new NxtControl.Drawing.Color(0, 0, 0);
				b.TextColorMouseDown = b.TextColor;
			}
		}
	}
}
