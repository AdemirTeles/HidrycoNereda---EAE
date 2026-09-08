/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 6/18/2026
 * Time: 10:54 AM
 * 
 */

using System;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.FeedInfluentLogic
{
	/// <summary>
	/// Description of sGrafcet.
	/// </summary>
	public partial class sGrafcet : NxtControl.GuiFramework.HMISymbol
	{
		public sGrafcet()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			this.GRAPH_Fired += GRAPH_Fired_EventHandler;
			this.RESET_BTNS_Fired += RESET_BTNS_Fired_EventHandler;
			State1.BrushColor = new NxtControl.Drawing.Color(154, 154, 154);
			State2.BrushColor = new NxtControl.Drawing.Color(154, 154, 154);
			State3.BrushColor = new NxtControl.Drawing.Color(154, 154, 154);
			State4.BrushColor = new NxtControl.Drawing.Color(154, 154, 154);
			State9.BrushColor = new NxtControl.Drawing.Color(154, 154, 154);
			State10.BrushColor = new NxtControl.Drawing.Color(154, 154, 154);
			State11.BrushColor = new NxtControl.Drawing.Color(154, 154, 154);
			State12.BrushColor = new NxtControl.Drawing.Color(154, 154, 154);
			State13.BrushColor = new NxtControl.Drawing.Color(154, 154, 154);
		}

		void GRAPH_Fired_EventHandler(object sender, GRAPHEventArgs e)
		{
			// TODO: Implement GRAPH_Fired_EventHandler
			State1.BrushColor = new NxtControl.Drawing.Color(154, 154, 154);
			State2.BrushColor = new NxtControl.Drawing.Color(154, 154, 154);
			State3.BrushColor = new NxtControl.Drawing.Color(154, 154, 154);
			State4.BrushColor = new NxtControl.Drawing.Color(154, 154, 154);
			State9.BrushColor = new NxtControl.Drawing.Color(154, 154, 154);
			State10.BrushColor = new NxtControl.Drawing.Color(154, 154, 154);
			State11.BrushColor = new NxtControl.Drawing.Color(154, 154, 154);
			State12.BrushColor = new NxtControl.Drawing.Color(154, 154, 154);
			State13.BrushColor = new NxtControl.Drawing.Color(154, 154, 154);
			
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
				case 13:
					State13.BrushColor = new NxtControl.Drawing.Color(0,255,0);
					break;
			}
		}

		void ResetLogicClick(object sender, EventArgs e)
		{
			// TODO: Implement ResetLogicClick
			FireEvent_CNF_RESET(true);
		}

		void RESET_BTNS_Fired_EventHandler(object sender, RESET_BTNSEventArgs e)
		{
			// TODO: Implement RESET_BTNS_Fired_EventHandler
			FireEvent_CNF_RESET(false);
		}
	}
}
