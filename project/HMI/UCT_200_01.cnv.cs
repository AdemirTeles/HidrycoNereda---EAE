/*
 * Hidryco - tela UCT_200_01
 * Skid da UCT (simbolo UCT_PreTratamento.sSkid)
 */

using System;
using NxtControl.GuiFramework;


namespace HMI.Main.Canvases
{
	/// <summary>
	/// Description of UCT_200_01.
	/// </summary>
	public partial class UCT_200_01 : NxtControl.GuiFramework.HMICanvas
	{
		public UCT_200_01()
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
