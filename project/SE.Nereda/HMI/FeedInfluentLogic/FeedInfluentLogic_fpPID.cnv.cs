/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 6/17/2026
 * Time: 10:09 AM
 * 
 */

using System;
using NxtControl.GuiFramework;

namespace SE.Nereda.Faceplates.FeedInfluentLogic
{
	/// <summary>
	/// Description of fpPID.
	/// </summary>
	public partial class fpPID : NxtControl.GuiFramework.HMIFaceplate
	{
		public fpPID()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			this.RESET_BTNS_Fired += RESET_BTNS_Fired_EventHandler;
		}

		void DrawnButton1Click(object sender, EventArgs e)
		{
			// TODO: Implement DrawnButton1Click
			FireEvent_CNF_RESET_F_ILCK(true);
		}

		void RESET_BTNS_Fired_EventHandler(object sender, SE.Nereda.Symbols.FeedInfluentLogic.RESET_BTNSEventArgs e)
		{
			// TODO: Implement RESET_BTNS_Fired_EventHandler
			FireEvent_CNF_RESET_F_ILCK(false);
		}
	}
}
