/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 6/13/2026
 * Time: 7:00 PM
 * 
 */

using System;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.FeedInfluentLogic
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
			this.GRAPH_Fired += GRAPH_Fired_EventHandler;
		}

		void GRAPH_Fired_EventHandler(object sender, GRAPHEventArgs e)
		{
			// TODO: Implement GRAPH_Fired_EventHandler
			switch(e.Grafcet){
				case 1:
					Status.Text = "Normal Operation";
					Status.TextColor = new NxtControl.Drawing.Color(26, 170, 66);
					break;
					
				case 2:
					Status.Text = "Starting Pump";
					break;
					
				case 3:
					Status.Text = "Pump Running";
					break;
					
				case 4:
					Status.Text = "Stopping Pump";
					break;
				
				case 5:
					Status.Text = "Opening Valve";
					break;
					
				case 6:
					Status.Text = "Valve Opened";
					break;
					
				case 7:
					Status.Text = "Closing Valve";
					break;
					
				case 8:
					Status.Text = "Valve Closed";
					break;
					
				case 9:
					Status.Text = "Pump Stopped";
					break;
					
				case 10:
					Status.Text = "Freeze Mode Active";
					Status.TextColor = new NxtControl.Drawing.Color(0, 114, 188);
					break;
					
				case 11:
					Status.Text = "Starting Pump";
					break;
					
				case 12:
					Status.Text = "Pump Running";
					break;
					
				case 13:
					Status.Text = "Stopping Pump";
					break;
			}
		}
	}
}
