/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 6/26/2026
 * Time: 8:57 AM
 * 
 */

using System;
using NxtControl.GuiFramework;

namespace SE.Nereda.Faceplates.ToFinalTreatment
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
			this.RESET_BTNs_Fired += RESET_BTNs_Fired_EventHandler;
		}

		void DrawnButton1Click(object sender, EventArgs e)
		{
			// TODO: Implement DrawnButton1Click
			FireEvent_RESET_LO_LO_F(true);
		}

		void RESET_BTNs_Fired_EventHandler(object sender, SE.Nereda.Symbols.ToFinalTreatment.RESET_BTNsEventArgs e)
		{
			// TODO: Implement RESET_BTNs_Fired_EventHandler
			FireEvent_RESET_LO_LO_F(false);
		}
	}
}
