/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 6/18/2026
 * Time: 5:19 PM
 * 
 */

using System;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.GritScreenLogic
{
	/// <summary>
	/// Description of sResetSafetyStopNotif.
	/// </summary>
	public partial class sResetSafetyStopNotif : NxtControl.GuiFramework.HMISymbol
	{
		public sResetSafetyStopNotif()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			this.NEED_RESET_S_Fired += NEED_RESET_S_Fired_EventHandler;
			NeedReset.Visible = false;
		}

		void NEED_RESET_S_Fired_EventHandler(object sender, NEED_RESET_SEventArgs e)
		{
			// TODO: Implement NEED_RESET_S_Fired_EventHandler
			NeedReset.Visible = (bool) e.NeedResetSafety;
		}
	}
}
