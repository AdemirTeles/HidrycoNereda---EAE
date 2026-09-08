/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 6/11/2026
 * Time: 3:14 PM
 * 
 */

using System;
using NxtControl.GuiFramework;

namespace SE.Nereda.Faceplates.DAerationLogic
{
	/// <summary>
	/// Description of fpSettings.
	/// </summary>
	public partial class fpSettingsS : NxtControl.GuiFramework.HMIFaceplate
	{
		public fpSettingsS()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			this.IN_CAP_CNFG_Fired += IN_CAP_CNFG_Fired_EventHandler;
		}

		void IN_CAP_CNFG_Fired_EventHandler(object sender, SE.Nereda.Symbols.DAerationLogic.IN_CAP_CNFGEventArgs e)
		{
			// TODO: Implement IN_CAP_CNFG_Fired_EventHandler
			switch (e.iCapacityConfig)
			{
			    case 1:
			        Config1.Visible = true;
			        Config2.Visible = false;
			        break;
			
			    case 2:
			        Config1.Visible = false;
			        Config2.Visible = true;
			        break;
			}
		}
	}
}
