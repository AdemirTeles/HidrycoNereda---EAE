/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 7/4/2026
 * Time: 4:04 PM
 * 
 */

using System;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.SludgeBufferLogic
{
	/// <summary>
	/// Description of sHiHiLevelSLB.
	/// </summary>
	public partial class sHiHiLevelSLB : NxtControl.GuiFramework.HMISymbol
	{
		public sHiHiLevelSLB()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			this.HI_HI_L_Fired += HI_HI_L_Fired_EventHandler;
		}

		void HI_HI_L_Fired_EventHandler(object sender, HI_HI_LEventArgs e)
		{
			// TODO: Implement HI_HI_L_Fired_EventHandler
			if(e.HiHiLevel == true){
				SLBLevelStatus.PenColor = SLBLevelStatus.TextColor = new NxtControl.Drawing.BlinkColor("SE.Nereda.DevLEDRedFlash");
			}
			else{
				SLBLevelStatus.PenColor = new NxtControl.Drawing.Color(0,0,0);
				SLBLevelStatus.TextColor = new NxtControl.Drawing.Color(114, 114, 114);
			}
		}
	}
}
