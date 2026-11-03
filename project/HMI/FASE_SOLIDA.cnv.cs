/*
 * Hidryco - tela FASE_SOLIDA (fase solida - serie 900)
 */

using System;
using NxtControl.GuiFramework;


namespace HMI.Main.Canvases
{
	/// <summary>
	/// Description of FASE_SOLIDA.
	/// </summary>
	public partial class FASE_SOLIDA : NxtControl.GuiFramework.HMICanvas
	{
		public FASE_SOLIDA()
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
