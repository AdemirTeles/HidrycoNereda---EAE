/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 2/24/2026
 * Time: 11:57 AM
 * 
 */

using System;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Symbols.Gradeamento
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
