/*
 * Criado pelo EcoStruxure Automation Expert.
 * Usuário:  
 * Data: 24/02/2026
 * Tempo: 14:11
 * 
 */

using System;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Symbols.ElevatoriaEsgotoBruto
{
	/// <summary>
	/// Description of sDefault.
	/// </summary>
	public partial class sDefault : NxtControl.GuiFramework.HMISymbol
	{
		public sDefault()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
		}

		void ResetFalhasProcessoMouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			FireEvent_E_RESET_FALHAS_PROCESSO(true);
			
		}

		void ResetFalhasProcessoMouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			FireEvent_E_RESET_FALHAS_PROCESSO(false);
		}
	}
}