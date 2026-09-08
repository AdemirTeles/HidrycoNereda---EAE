/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 6/21/2026
 * Time: 3:45 PM
 * 
 */

using System;
using NxtControl.GuiFramework;

namespace SE.Nereda.Faceplates.ToFinalTreatment
{
	/// <summary>
	/// Description of fpGrafcet.
	/// </summary>
	public partial class fpGrafcet : NxtControl.GuiFramework.HMIFaceplate
	{
		public fpGrafcet()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			this.GRAPH_Fired += GRAPH_Fired_EventHandler;
		}

		void GRAPH_Fired_EventHandler(object sender, SE.Nereda.Symbols.ToFinalTreatment.GRAPHEventArgs e)
		{
			// TODO: Implement GRAPH_Fired_EventHandler
			State1.BrushColor = new NxtControl.Drawing.Color(154, 154, 154);
			State2.BrushColor = new NxtControl.Drawing.Color(154, 154, 154);
			State3.BrushColor = new NxtControl.Drawing.Color(154, 154, 154);
			State4.BrushColor = new NxtControl.Drawing.Color(154, 154, 154);
			State5.BrushColor = new NxtControl.Drawing.Color(154, 154, 154);
			State6.BrushColor = new NxtControl.Drawing.Color(154, 154, 154);
			
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
			}
		}
	}
}
