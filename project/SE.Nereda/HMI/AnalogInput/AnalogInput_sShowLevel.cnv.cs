/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 6/16/2026
 * Time: 3:59 PM
 * 
 */

using System;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.AnalogInput
{
	/// <summary>
	/// Description of sShowLevel.
	/// </summary>
	public partial class sShowLevel : NxtControl.GuiFramework.HMISymbol
	{
		public sShowLevel()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			this.REQ_PV_Fired += REQ_PV_Fired_EventHandler;
			//ShowLevel.FillPercent = 0;
		}

		void REQ_PV_Fired_EventHandler(object sender, REQ_PVEventArgs e)
		{
			// TODO: Implement REQ_PV_Fired_EventHandler
			ShowLevel.FillPercent = (((float)e.Pv - (float)e.PvMin) / ((float)e.PvMax - (float)e.PvMin)) * 100;
		}
	}
}
