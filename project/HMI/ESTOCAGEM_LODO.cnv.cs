/*
 * Hidryco - tela ESTOCAGEM_LODO (fase solida - serie 900)
 */

using System;
using NxtControl.GuiFramework;


namespace HMI.Main.Canvases
{
	/// <summary>
	/// Description of ESTOCAGEM_LODO.
	/// </summary>
	public partial class ESTOCAGEM_LODO : NxtControl.GuiFramework.HMICanvas
	{
		public ESTOCAGEM_LODO()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			Hidryco.HidrycoLib.SupportClasses.ReplicaSensor.Gravado += ReplicaTanques;
		}

		// Reset geral: falhas e alarmes de todos os equipamentos desta tela (o mesmo reset do faceplate de cada um)
		void BtnResetGeralClick(object sender, EventArgs e)
		{
			HMI.Main.ResetGeral.Executar(this);
		}

		// ---- Replicacao dos ajustes do LIT-900-01/02 (Lodo) no SludgeHoldingTank1/2 (Nereda) ----
		// O faceplate do LIT avisa quando o operador grava; aqui os mesmos valores vao para o AnalogInput do tanque da Nereda:
		// faixa (PvMin/PvMax = valor em 4/20 mA) e os quatro LimitAlarm (habilitacao e limite; nivel em % vira metro pela altura maxima).
		void ReplicaTanques(Hidryco.HidrycoLib.SupportClasses.AjustesSensor a)
		{
			if (a == null || a.Tag == null) return;
			int t = a.Tag.EndsWith("LIT_900_01") ? 0 : (a.Tag.EndsWith("LIT_900_02") ? 1 : -1);
			if (t < 0) return;
			SE.Nereda.Symbols.AnalogInputBase.sInstanceName ai = t == 0 ? repAI1 : repAI2;
			SE.App2Base.Symbols.LimitAlarm.sIndicator[] la = t == 0
				? new SE.App2Base.Symbols.LimitAlarm.sIndicator[] { repHH1, repH1, repL1, repLL1 }
				: new SE.App2Base.Symbols.LimitAlarm.sIndicator[] { repHH2, repH2, repL2, repLL2 };
			try
			{
				ai.FireEvent_CFG(0F, true, 0F, true, a.RangeMin, false, a.RangeMax, false, false, true, false, true, 0F, true, 0F, true,
					0, true, 0, true, (short)0, true, 0F, true, (byte)0, true, 0, true, 0F, true, (byte)0, true);
				if (a.Nivel && a.Altura <= 0F) return;          // sem altura maxima nao da para converter % em metro
				for (int i = 0; i < 4; i++)
				{
					float sp = a.Nivel ? a.Sp[i] * a.Altura / 100F : a.Sp[i];
					la[i].FireEvent_CFG(a.Hab[i], false, false, true, sp, false, 0F, true, 0, true, 0, true, (byte)0, true);
				}
			}
			catch (Exception ex)
			{
				NxtControl.Services.LoggingService.ErrorFormatted("Replicacao LIT -> SludgeHoldingTank: {0}", ex.Message);
			}
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing) Hidryco.HidrycoLib.SupportClasses.ReplicaSensor.Gravado -= ReplicaTanques;
			base.Dispose(disposing);
		}
	}
}
