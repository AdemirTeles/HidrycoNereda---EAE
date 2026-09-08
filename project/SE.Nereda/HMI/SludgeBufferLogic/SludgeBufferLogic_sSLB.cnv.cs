/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 6/29/2026
 * Time: 5:38 PM
 * 
 */

using System;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.SludgeBufferLogic
{
	/// <summary>
	/// Description of sShowLevel.
	/// </summary>
	public partial class sSLB : NxtControl.GuiFramework.HMISymbol
	{
		public sSLB()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			this.LEVEL_PV_Fired += LEVEL_PV_Fired_EventHandler;
			this.HI_HI_L_Fired += HI_HI_L_Fired_EventHandler;
			HiHiLevel.Visible = HiHiTxt.Visible = false;
		}

		void LEVEL_PV_Fired_EventHandler(object sender, LEVEL_PVEventArgs e)
		{
			// TODO: Implement LEVEL_PV_Fired_EventHandler
			ShowLevel.FillPercent = (((float)e.LevelPv - (float)e.LevelPvMin) / ((float)e.LevelPvMax - (float)e.LevelPvMin)) * 100;
		}

		void HI_HI_L_Fired_EventHandler(object sender, HI_HI_LEventArgs e)
		{
			// TODO: Implement HI_HI_L_Fired_EventHandler
			HiHiLevel.Visible = HiHiTxt.Visible = (bool) e.HiHiLevel;
		}
	}
}
