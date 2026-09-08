/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 6/29/2026
 * Time: 11:00 AM
 * 
 */

using System;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.Calamity
{
	/// <summary>
	/// Description of sHiHiLevelCalamity.
	/// </summary>
	public partial class sHiHiLevelCalamity : NxtControl.GuiFramework.HMISymbol
	{
		public sHiHiLevelCalamity()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			this.LEVEL_STATUS_Fired += LEVEL_STATUS_Fired_EventHandler;
		}

		void LEVEL_STATUS_Fired_EventHandler(object sender, LEVEL_STATUSEventArgs e)
		{
			// TODO: Implement LEVEL_STATUS_Fired_EventHandler
			if(e.HiHiLevel == true || e.LevelSwitch == true){
				CalamityLevelStatus.PenColor = CalamityLevelStatus.TextColor = new NxtControl.Drawing.BlinkColor("SE.Nereda.DevLEDRedFlash");
			}
			else{
				CalamityLevelStatus.PenColor = new NxtControl.Drawing.Color(0,0,0);
				CalamityLevelStatus.TextColor = new NxtControl.Drawing.Color(114, 114, 114);
			}
		}
	}
}
