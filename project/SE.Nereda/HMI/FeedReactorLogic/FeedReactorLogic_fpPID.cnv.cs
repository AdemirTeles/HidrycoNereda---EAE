/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 6/17/2026
 * Time: 10:13 AM
 * 
 */

using System;
using NxtControl.GuiFramework;

namespace SE.Nereda.Faceplates.FeedReactorLogic
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
			this.RESET_BTN_Fired += RESET_BTN_Fired_EventHandler;
		}

		void DrawnButton1Click(object sender, EventArgs e)
		{
			// TODO: Implement DrawnButton1Click
			FireEvent_RESET_LO_LO_F(true);
		}

		void RESET_BTN_Fired_EventHandler(object sender, SE.Nereda.Symbols.FeedReactorLogic.RESET_BTNEventArgs e)
		{
			// TODO: Implement RESET_BTN_Fired_EventHandler
			FireEvent_RESET_LO_LO_F(false);
		}
	}
}
