/*
 * Criado pelo EcoStruxure Automation Expert.
 * Usuário:  
 * Data: 11/03/2026
 * Tempo: 10:37
 * 
 */

using System;
using Hidryco.HidrycoLib.SupportClasses;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Symbols.PreTratamentoPreliminar
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
