/*
 * Hidryco - tela EEE_BRUTO (Elevatoria de Esgoto Bruto)
 */

using System;
using NxtControl.GuiFramework;


namespace HMI.Main.Canvases
{
	/// <summary>
	/// Description of EEE_BRUTO.
	/// </summary>
	public partial class EEE_BRUTO : NxtControl.GuiFramework.HMICanvas
	{
		public EEE_BRUTO()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
		}

		// Reset geral: falhas e alarmes de todos os equipamentos desta tela (o mesmo reset do faceplate de cada um)
		void BtnResetGeralClick(object sender, EventArgs e)
		{
			HMI.Main.ResetGeral.Executar(this);
		}
	}
}
