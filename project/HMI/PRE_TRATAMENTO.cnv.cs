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
		}

		// Reset geral: falhas e alarmes de todos os equipamentos desta tela (o mesmo reset do faceplate de cada um)
		void BtnResetGeralClick(object sender, EventArgs e)
		{
			HMI.Main.ResetGeral.Executar(this);
		}
	}
}
