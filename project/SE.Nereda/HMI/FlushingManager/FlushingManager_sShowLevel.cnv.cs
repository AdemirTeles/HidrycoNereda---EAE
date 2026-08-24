/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 6/25/2026
 * Time: 4:19 PM
 * 
 */

using System;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.FlushingManager
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
			this.LEVEL_PV_Fired += LEVEL_PV_Fired_EventHandler;
		}

		void LEVEL_PV_Fired_EventHandler(object sender, LEVEL_PVEventArgs e)
		{
			// TODO: Implement LEVEL_PV_Fired_EventHandler
			ShowLevel.FillPercent = (((float)e.LevelPv - (float)e.LevelPvMin) / ((float)e.LevelPvMax - (float)e.LevelPvMin)) * 100;
		}
	}
}
