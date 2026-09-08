/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 6/16/2026
 * Time: 10:36 PM
 * 
 */

using System;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.FeedInfluentLogic
{
	/// <summary>
	/// Description of sHiHiAlarms.
	/// </summary>
	public partial class sHiHiAlarms : NxtControl.GuiFramework.HMISymbol
	{
		public sHiHiAlarms()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			this.HI_HI_Fired += HI_HI_Fired_EventHandler;
		}

		void HI_HI_Fired_EventHandler(object sender, HI_HIEventArgs e)
		{
			// TODO: Implement HI_HI_Fired_EventHandler
			group1.Visible = (bool)e.HiHiCalamity || (bool)e.HiHiSB || (bool)e.SwitchLevelCalamity;
		}
	}
}
