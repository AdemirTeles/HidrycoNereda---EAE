/*
 * Created by EcoStruxure Automation Expert.
 * User: SESA583220
 * Date: 8/31/2022
 * Time: 11:36 AM
 * 
 */

using System;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.AnalogInput_Status
{
	/// <summary>
	/// Description of sDefault.
	/// </summary>
	public partial class sDefault : NxtControl.GuiFramework.HMISymbol
	{
		public sDefault()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			this.REQ_Fired += REQ_Fired_EventHandler;
		}

		void REQ_Fired_EventHandler(object sender, REQEventArgs e)
		{
			// TODO: Implement REQ_Fired_EventHandler
			StatusRec.BrushColor = new NxtControl.Drawing.Color(114, 114, 114);
			StatusRec.PenColor = new NxtControl.Drawing.Color(0, 0, 0);
			if(e.ChFailAlarm == true){
				StatusRec.BrushColor = new NxtControl.Drawing.BlinkColor("SE.Nereda.Orangwhite");
			}
			else if(e.OverrideStatus == true){
				StatusRec.PenColor = new NxtControl.Drawing.BlinkColor("SE.Nereda.Orangwhite");
			}
			else{
				StatusRec.BrushColor = new NxtControl.Drawing.Color(114, 114, 114);
				StatusRec.PenColor = new NxtControl.Drawing.Color(0, 0, 0);
			}
		}
	}
}
