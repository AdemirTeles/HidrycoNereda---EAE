/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 6/16/2026
 * Time: 2:42 PM
 * 
 */

using System;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.GritScreenLogic
{
	/// <summary>
	/// Description of sGritScreen.
	/// </summary>
	public partial class sGritScreen : NxtControl.GuiFramework.HMISymbol
	{
		public sGritScreen()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			this.FB_GS_STATE_Fired += FB_GS_STATE_Fired_EventHandler;
			GSRunning.Visible = false;
			GSStopped.Visible = true;
		}

		void FB_GS_STATE_Fired_EventHandler(object sender, FB_GS_STATEEventArgs e)
		{
			// TODO: Implement FB_GS_STATE_Fired_EventHandler
			GSRunning.Visible = (bool) e.FbGritScreenRun;
			GSStopped.Visible = (bool) !e.FbGritScreenRun;
		}
	}
}
