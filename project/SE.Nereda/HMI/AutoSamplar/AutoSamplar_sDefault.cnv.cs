/*
 * Created by EcoStruxure Automation Expert.
 * User: SESA713705
 * Date: 9/26/2024
 * Time: 11:08 AM
 * 
 */

using System;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.AutoSamplar
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
			this.REQ_STATE_Fired += REQ_STATE_Fired_EventHandler;
		}

		void REQ_STATE_Fired_EventHandler(object sender, REQ_STATEEventArgs e)
		{
			// TODO: Implement REQ_STATE_Fired_EventHandler
			if(e.State == 0){
				StateText.Text = "Not Running";
			}
			if(e.State == 1){
				StateText.Text = "Flow still below Flow Sp";
			}
			if(e.State == 2){
				StateText.Text = "Wait for the delay";
			}
			if(e.State == 3){
				StateText.Text = "Running";
			}
		}
	}
}
