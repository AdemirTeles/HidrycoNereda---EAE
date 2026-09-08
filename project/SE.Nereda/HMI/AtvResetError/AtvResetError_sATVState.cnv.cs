/*
 * Created by EcoStruxure Automation Expert.
 * User: SESA713705
 * Date: 8/27/2024
 * Time: 7:41 PM
 * 
 */

using System;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.AtvResetError
{
	/// <summary>
	/// Description of sATVState.
	/// </summary>
	public partial class sATVState : NxtControl.GuiFramework.HMISymbol
	{
		public sATVState()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			this.REQ_NEED_RESET_Fired += REQ_NEED_RESET_Fired_EventHandler;
		}

		void REQ_NEED_RESET_Fired_EventHandler(object sender, REQ_NEED_RESETEventArgs e)
		{
			// TODO: Implement REQ_NEED_RESET_Fired_EventHandler
			if(e.NeedReset == true){
				DriverState.Visible = true;
			}
			else{
				DriverState.Visible = false;
			}
		}
	}
}
