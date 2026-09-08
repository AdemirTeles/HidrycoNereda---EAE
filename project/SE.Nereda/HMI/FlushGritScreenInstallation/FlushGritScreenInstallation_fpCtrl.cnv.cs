/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 6/19/2026
 * Time: 4:05 PM
 * 
 */

using System;
using NxtControl.GuiFramework;

namespace SE.Nereda.Faceplates.FlushGritScreenInstallation
{
	/// <summary>
	/// Description of fpCtrl.
	/// </summary>
	public partial class fpCtrl : NxtControl.GuiFramework.HMIFaceplate
	{
		public fpCtrl()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			this.GRAPH_Fired += GRAPH_Fired_EventHandler;
			State1.BrushColor = new NxtControl.Drawing.Color(154, 154, 154);
			State2.BrushColor = new NxtControl.Drawing.Color(154, 154, 154);
			State3.BrushColor = new NxtControl.Drawing.Color(154, 154, 154);
			State4.BrushColor = new NxtControl.Drawing.Color(154, 154, 154);
			State5.BrushColor = new NxtControl.Drawing.Color(154, 154, 154);
			State6.BrushColor = new NxtControl.Drawing.Color(154, 154, 154);
			State7.BrushColor = new NxtControl.Drawing.Color(154, 154, 154);
			State8.BrushColor = new NxtControl.Drawing.Color(154, 154, 154);
			State9.BrushColor = new NxtControl.Drawing.Color(154, 154, 154);
			State10.BrushColor = new NxtControl.Drawing.Color(154, 154, 154);
			State11.BrushColor = new NxtControl.Drawing.Color(154, 154, 154);
			State12.BrushColor = new NxtControl.Drawing.Color(154, 154, 154);
		}

		void GRAPH_Fired_EventHandler(object sender, SE.Nereda.Symbols.FlushGritScreenInstallation.GRAPHEventArgs e)
		{
			// TODO: Implement GRAPH_Fired_EventHandler
			State1.BrushColor = new NxtControl.Drawing.Color(154, 154, 154);
			State2.BrushColor = new NxtControl.Drawing.Color(154, 154, 154);
			State3.BrushColor = new NxtControl.Drawing.Color(154, 154, 154);
			State4.BrushColor = new NxtControl.Drawing.Color(154, 154, 154);
			State5.BrushColor = new NxtControl.Drawing.Color(154, 154, 154);
			State6.BrushColor = new NxtControl.Drawing.Color(154, 154, 154);
			State7.BrushColor = new NxtControl.Drawing.Color(154, 154, 154);
			State8.BrushColor = new NxtControl.Drawing.Color(154, 154, 154);
			State9.BrushColor = new NxtControl.Drawing.Color(154, 154, 154);
			State10.BrushColor = new NxtControl.Drawing.Color(154, 154, 154);
			State11.BrushColor = new NxtControl.Drawing.Color(154, 154, 154);
			State12.BrushColor = new NxtControl.Drawing.Color(154, 154, 154);
			
			switch(e.Grafcet){
				case 1:
					State1.BrushColor = new NxtControl.Drawing.Color(0,255,0);
					break;
				case 2:
					State2.BrushColor = new NxtControl.Drawing.Color(0,255,0);
					break;
				case 3:
					State3.BrushColor = new NxtControl.Drawing.Color(0,255,0);
					break;
				case 4:
					State4.BrushColor = new NxtControl.Drawing.Color(0,255,0);
					break;
				case 5:
					State5.BrushColor = new NxtControl.Drawing.Color(0,255,0);
					break;
				case 6:
					State6.BrushColor = new NxtControl.Drawing.Color(0,255,0);
					break;
				case 7:
					State7.BrushColor = new NxtControl.Drawing.Color(0,255,0);
					break;
				case 8:
					State8.BrushColor = new NxtControl.Drawing.Color(0,255,0);
					break;
				case 9:
					State9.BrushColor = new NxtControl.Drawing.Color(0,255,0);
					break;
				case 10:
					State10.BrushColor = new NxtControl.Drawing.Color(0,255,0);
					break;
				case 11:
					State11.BrushColor = new NxtControl.Drawing.Color(0,255,0);
					break;
				case 12:
					State12.BrushColor = new NxtControl.Drawing.Color(0,255,0);
					break;
			}
		}
	}
}
