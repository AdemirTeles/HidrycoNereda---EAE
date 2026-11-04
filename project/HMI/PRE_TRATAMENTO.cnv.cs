/*
 * Hidryco - tela PRE_TRATAMENTO
 * Fluxo do pre-tratamento: UCTs, 40FT02 para o buffer de influente e gordura para a estocagem de lodo
 */

using System;
using NxtControl.GuiFramework;


namespace HMI.Main.Canvases
{
	/// <summary>
	/// Description of PRE_TRATAMENTO.
	/// </summary>
	public partial class PRE_TRATAMENTO : NxtControl.GuiFramework.HMICanvas
	{
		public PRE_TRATAMENTO()
		{
			InitializeComponent();
			Hidryco.HidrycoLib.SupportClasses.ReplicaSensor.Gravado += ReplicaFT02;
		}

		// Reset geral: falhas e alarmes de todos os equipamentos desta tela (o mesmo reset do faceplate de cada um)
		void BtnResetGeralClick(object sender, EventArgs e)
		{
			HMI.Main.ResetGeral.Executar(this);
		}

		// Reconhecer geral: reconhece todos os alarmes pendentes da planta (nao reseta falhas)
		void BtnReconhecerGeralClick(object sender, EventArgs e)
		{
			HMI.Main.ReconhecerGeral.Executar();
		}

		// ---- Replicacao dos ajustes do 40FT02 (FT_40_02, Sensor_Generico) no FeedInfluentFlow da Nereda ----
		// O faceplate do 40FT02 avisa quando o operador grava; aqui os mesmos valores vao para o AnalogInput FeedInfluentFlowPv:
		// faixa (PvMin/PvMax = valor em 4/20 mA, com EnScale e UseLimits ligados) e os quatro LimitAlarm (habilitacao, limite e retardo em s).
		void ReplicaFT02(Hidryco.HidrycoLib.SupportClasses.AjustesSensor a)
		{
			if (a == null || a.Tag == null || !a.Tag.EndsWith("1A8A218FB56FB248")) return;
			SE.App2Base.Symbols.LimitAlarm.sIndicator[] la = { repHHft, repHft, repLft, repLLft };
			try
			{
				repAIft.FireEvent_CFG(0F, true, 0F, true, a.RangeMin, false, a.RangeMax, false, true, false, true, false, 0F, true, 0F, true,
					0, true, 0, true, (short)0, true, 0F, true, (byte)0, true, 0, true, 0F, true, (byte)0, true);
				for (int i = 0; i < 4; i++)
				{
					float sp = (a.Nivel && a.Altura > 0F) ? a.Sp[i] * a.Altura / 100F : a.Sp[i];
					la[i].FireEvent_CFG(a.Hab[i], false, false, true, sp, false, 0F, true, (int)a.Tempo[i], false, 0, true, (byte)0, true);
				}
			}
			catch (Exception ex)
			{
				NxtControl.Services.LoggingService.ErrorFormatted("Replicacao 40FT02 -> FeedInfluentFlow: {0}", ex.Message);
			}
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing) Hidryco.HidrycoLib.SupportClasses.ReplicaSensor.Gravado -= ReplicaFT02;
			base.Dispose(disposing);
		}
	}
}
