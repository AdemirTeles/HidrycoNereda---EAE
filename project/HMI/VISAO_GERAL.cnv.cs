/*
 * Hidryco - tela VISAO_GERAL: visao geral da ETE em quadros padronizados
 */

using System;
using NxtControl.GuiFramework;


namespace HMI.Main.Canvases
{
	/// <summary>
	/// Description of VISAO_GERAL.
	/// </summary>
	public partial class VISAO_GERAL : NxtControl.GuiFramework.HMICanvas
	{
		public VISAO_GERAL()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
		}

		void BtnResetGeralClick(object sender, EventArgs e)
		{
			HMI.Main.ResetGeral.Executar(this);
		}
	}
}
