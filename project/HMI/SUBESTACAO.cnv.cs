/*
 * Hidryco - tela SUBESTACAO (unifilar QGBT 440 V e geradores)
 */

using System;
using NxtControl.GuiFramework;


namespace HMI.Main.Canvases
{
	/// <summary>
	/// Description of SUBESTACAO.
	/// </summary>
	public partial class SUBESTACAO : NxtControl.GuiFramework.HMICanvas
	{
		public SUBESTACAO()
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
