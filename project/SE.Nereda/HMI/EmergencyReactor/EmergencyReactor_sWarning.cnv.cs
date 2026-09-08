/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 7/15/2026
 * Time: 5:35 PM
 * 
 */

using System;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.EmergencyReactor
{
	/// <summary>
	/// Description of sWarning.
	/// </summary>
	public partial class sWarning : NxtControl.GuiFramework.HMISymbol
	{
		public sWarning()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			this.WARNING_Fired += WARNING_Fired_EventHandler;
			group1.Visible = false;
		}

		void WARNING_Fired_EventHandler(object sender, WARNINGEventArgs e)
		{
			// TODO: Implement WARNING_Fired_EventHandler
			group1.Visible = (bool) e.WarningSteps;
		}
	}
}
