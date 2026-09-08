/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 6/15/2026
 * Time: 3:56 PM
 * 
 */

using System;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.GritScreenLogic
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
			this.NEED_RESET_S_Fired += NEED_RESET_S_Fired_EventHandler;
		}

		void NEED_RESET_S_Fired_EventHandler(object sender, NEED_RESET_SEventArgs e)
		{
			// TODO: Implement NEED_RESET_S_Fired_EventHandler
			if(e.NeedResetSafety == true){
				ResetSafetyStop.Enabled = true;
			}
			else{
				ResetSafetyStop.Enabled = false;
				ResetSafetyStop.Checked = false;
				FireEvent_RESET_SAFETY(false);
			}
		}
	}
}
