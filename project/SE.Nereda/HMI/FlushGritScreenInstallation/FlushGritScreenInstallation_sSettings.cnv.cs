/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 6/19/2026
 * Time: 11:38 PM
 * 
 */

using System;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.FlushGritScreenInstallation
{
	/// <summary>
	/// Description of sSettings.
	/// </summary>
	public partial class sSettings : NxtControl.GuiFramework.HMISymbol
	{
		bool Active;
		bool NotActive;
		public sSettings()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			this.RESET_BTNs_Fired += RESET_BTNs_Fired_EventHandler;
		}

		void CmdFlushClick(object sender, EventArgs e)
		{
			// TODO: Implement CmdFlushClick
			FireEvent_START_FLUSH(true, false);
		}

		void RESET_BTNs_Fired_EventHandler(object sender, RESET_BTNsEventArgs e)
		{
			// TODO: Implement RESET_BTNs_Fired_EventHandler
			FireEvent_START_FLUSH(false, true);
		}
	}
}
