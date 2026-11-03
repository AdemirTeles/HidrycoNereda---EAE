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
		}

		// Reset geral: falhas e alarmes de todos os equipamentos desta tela (o mesmo reset do faceplate de cada um)
		void BtnResetGeralClick(object sender, EventArgs e)
		{
			HMI.Main.ResetGeral.Executar(this);
		}
	}
}
