/*
 * Hidryco - tela GRADEAMENTO (fase solida - serie 900)
 */

using System;
using NxtControl.GuiFramework;


namespace HMI.Main.Canvases
{
	/// <summary>
	/// Description of GRADEAMENTO.
	/// </summary>
	public partial class GRADEAMENTO : NxtControl.GuiFramework.HMICanvas
	{
		public GRADEAMENTO()
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

		// Reconhecer geral: reconhece todos os alarmes pendentes da planta (nao reseta falhas)
		void BtnReconhecerGeralClick(object sender, EventArgs e)
		{
			HMI.Main.ReconhecerGeral.Executar();
		}
	}
}
