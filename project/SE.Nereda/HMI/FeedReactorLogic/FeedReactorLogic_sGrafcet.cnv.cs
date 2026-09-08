/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 6/18/2026
 * Time: 4:03 PM
 * 
 */

using System;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.FeedReactorLogic
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
			this.RESET_BTN_Fired += RESET_BTN_Fired_EventHandler;
		}

		void GRAPH_Fired_EventHandler(object sender, GRAPHEventArgs e)
		{
			// TODO: Implement GRAPH_Fired_EventHandler
			State1.BrushColor = new NxtControl.Drawing.Color(154, 154, 154);
			State2.BrushColor = new NxtControl.Drawing.Color(154, 154, 154);
			State3.BrushColor = new NxtControl.Drawing.Color(154, 154, 154);
			State4.BrushColor = new NxtControl.Drawing.Color(154, 154, 154);
			State5.BrushColor = new NxtControl.Drawing.Color(154, 154, 154);
			State0.BrushColor = new NxtControl.Drawing.Color(154, 154, 154);
			
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
					State0.BrushColor = new NxtControl.Drawing.Color(0,255,0);
					break;
			}
		}

		void ResetLogicClick(object sender, EventArgs e)
		{
			// TODO: Implement ResetLogicClick
			FireEvent_RESET_LOGIC(true);
		}

		void RESET_BTN_Fired_EventHandler(object sender, RESET_BTNEventArgs e)
		{
			// TODO: Implement RESET_BTN_Fired_EventHandler
			FireEvent_RESET_LOGIC(false);
		}
	}
}
