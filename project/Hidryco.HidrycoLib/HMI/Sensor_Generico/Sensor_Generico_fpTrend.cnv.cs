/*
 * Hidryco - Sensor_Generico - fpTrend
 * Grafico do valor do sensor:
 * - escala da esquerda fixa na faixa do sensor (valor em 4 mA ate valor em 20 mA); automatica se a faixa nao estiver ajustada;
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
				if (esc != null)
				{
					bool faixa = max > min;
					esc.AutoScale = !faixa;
					if (faixa) { esc.Minimum = min; esc.Maximum = max; }
				}
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
	}
}
