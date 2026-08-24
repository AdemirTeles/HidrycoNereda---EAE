/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 7/4/2026
 * Time: 10:10 PM
 * 
 */

using System;
using NxtControl.GuiFramework;
using System.ComponentModel;

namespace SE.Nereda.Symbols.EmergencyReactor
{
	/// <summary>
	/// Description of sDefault.
	/// </summary>
	public partial class sDefault : NxtControl.GuiFramework.HMISymbol
	{
		private string _ReactorName = "Reactor Name";
		public sDefault()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			ReactorNotAv.Visible = false;
			this.GRAPH_Fired += GRAPH_Fired_EventHandler;
			this.RESET_F_TRS_Fired += RESET_F_TRS_Fired_EventHandler;
			F_S1.Enabled = F_S1.Visible = F_S2.Enabled = F_S2.Visible = F_S3.Enabled = F_S3.Visible = F_S4.Enabled = F_S4.Visible =
			F_S5.Enabled = F_S5.Visible = F_S6.Enabled = F_S6.Visible = F_S7.Enabled = F_S7.Visible = F_S8.Enabled = F_S8.Visible = false;
			Step1.BrushColor = new NxtControl.Drawing.Color(78, 78, 78);
			Step2.BrushColor = new NxtControl.Drawing.Color(78, 78, 78);
			Step3.BrushColor = new NxtControl.Drawing.Color(78, 78, 78);
			Step4.BrushColor = new NxtControl.Drawing.Color(78, 78, 78);
			Step5.BrushColor = new NxtControl.Drawing.Color(78, 78, 78);
			Step6.BrushColor = new NxtControl.Drawing.Color(78, 78, 78);
			Step7.BrushColor = new NxtControl.Drawing.Color(78, 78, 78);
			Step8.BrushColor = new NxtControl.Drawing.Color(78, 78, 78);
			Step1.PenColor = new NxtControl.Drawing.Color(0, 0, 0);
			Step2.PenColor = new NxtControl.Drawing.Color(0, 0, 0);
			Step3.PenColor = new NxtControl.Drawing.Color(0, 0, 0);
			Step4.PenColor = new NxtControl.Drawing.Color(0, 0, 0);
			Step5.PenColor = new NxtControl.Drawing.Color(0, 0, 0);
			Step6.PenColor = new NxtControl.Drawing.Color(0, 0, 0);
			Step7.PenColor = new NxtControl.Drawing.Color(0, 0, 0);
			Step8.PenColor = new NxtControl.Drawing.Color(0, 0, 0);
			this.ENABLE_FORCE_IN_Fired += ENABLE_FORCE_IN_Fired_EventHandler;
			this.FORCE_UNAV_Fired += FORCE_UNAV_Fired_EventHandler;
		}

		void GRAPH_Fired_EventHandler(object sender, GRAPHEventArgs e)
		{
			// TODO: Implement GRAPH_Fired_EventHandler
			Step1.BrushColor = new NxtControl.Drawing.Color(78, 78, 78);
			Step2.BrushColor = new NxtControl.Drawing.Color(78, 78, 78);
			Step3.BrushColor = new NxtControl.Drawing.Color(78, 78, 78);
			Step4.BrushColor = new NxtControl.Drawing.Color(78, 78, 78);
			Step5.BrushColor = new NxtControl.Drawing.Color(78, 78, 78);
			Step6.BrushColor = new NxtControl.Drawing.Color(78, 78, 78);
			Step7.BrushColor = new NxtControl.Drawing.Color(78, 78, 78);
			Step8.BrushColor = new NxtControl.Drawing.Color(78, 78, 78);
			Step1.PenColor = new NxtControl.Drawing.Color(0, 0, 0);
			Step2.PenColor = new NxtControl.Drawing.Color(0, 0, 0);
			Step3.PenColor = new NxtControl.Drawing.Color(0, 0, 0);
			Step4.PenColor = new NxtControl.Drawing.Color(0, 0, 0);
			Step5.PenColor = new NxtControl.Drawing.Color(0, 0, 0);
			Step6.PenColor = new NxtControl.Drawing.Color(0, 0, 0);
			Step7.PenColor = new NxtControl.Drawing.Color(0, 0, 0);
			Step8.PenColor = new NxtControl.Drawing.Color(0, 0, 0);
			
			switch(e.Grafcet){
				case 1:
					Step1.BrushColor = new NxtControl.Drawing.Color(0,255,0);
					Step1.PenColor = new NxtControl.Drawing.BlinkColor("SE.Nereda.Running");
					break;
				case 2:
					Step2.BrushColor = new NxtControl.Drawing.Color(0,255,0);
					Step2.PenColor = new NxtControl.Drawing.BlinkColor("SE.Nereda.Running");
					break;
				case 3:
					Step3.BrushColor = new NxtControl.Drawing.Color(0,255,0);
					Step3.PenColor = new NxtControl.Drawing.BlinkColor("SE.Nereda.Running");
					break;
				case 4:
					Step4.BrushColor = new NxtControl.Drawing.Color(0,255,0);
					Step4.PenColor = new NxtControl.Drawing.BlinkColor("SE.Nereda.Running");
					break;
				case 5:
					Step5.BrushColor = new NxtControl.Drawing.Color(0,255,0);
					Step5.PenColor = new NxtControl.Drawing.BlinkColor("SE.Nereda.Running");
					break;
				case 6:
					Step6.BrushColor = new NxtControl.Drawing.Color(0,255,0);
					Step6.PenColor = new NxtControl.Drawing.BlinkColor("SE.Nereda.Running");
					break;
				case 7:
					Step7.BrushColor = new NxtControl.Drawing.Color(0,255,0);
					Step7.PenColor = new NxtControl.Drawing.BlinkColor("SE.Nereda.Running");
					break;
				case 8:
					Step8.BrushColor = new NxtControl.Drawing.Color(0,255,0);
					Step8.PenColor = new NxtControl.Drawing.BlinkColor("SE.Nereda.Running");
					break;
			}
		}

		void F_S1Click(object sender, EventArgs e)
		{
			// TODO: Implement F_S1Click
			FireEvent_FORCE(1);
		}

		void F_S2Click(object sender, EventArgs e)
		{
			// TODO: Implement F_S2Click
			FireEvent_FORCE(2);
		}

		void F_S3Click(object sender, EventArgs e)
		{
			// TODO: Implement F_S3Click
			FireEvent_FORCE(3);
		}

		void F_S4Click(object sender, EventArgs e)
		{
			// TODO: Implement F_S4Click
			FireEvent_FORCE(4);
		}

		void F_S5Click(object sender, EventArgs e)
		{
			// TODO: Implement F_S5Click
			FireEvent_FORCE(5);
		}

		void F_S6Click(object sender, EventArgs e)
		{
			// TODO: Implement F_S6Click
			FireEvent_FORCE(6);
		}

		void F_S7Click(object sender, EventArgs e)
		{
			// TODO: Implement F_S7Click
			FireEvent_FORCE(7);
		}

		void F_S8Click(object sender, EventArgs e)
		{
			// TODO: Implement F_S8Click
			FireEvent_FORCE(8);
		}

		void RESET_F_TRS_Fired_EventHandler(object sender, RESET_F_TRSEventArgs e)
		{
			// TODO: Implement RESET_F_TRS_Fired_EventHandler
			FireEvent_FORCE(0);
		}
		
		[RefreshProperties(RefreshProperties.Repaint)]
		[Category("Tagnames")]
		[DisplayName("Reactor Name")]
		
		public string _iReactorName
		{
			get{
				return _ReactorName;
			}
			set{
				_ReactorName = value;
				ReactorName.Text = value.ToString();
			}
		}

		void ENABLE_FORCE_IN_Fired_EventHandler(object sender, ENABLE_FORCE_INEventArgs e)
		{
			// TODO: Implement ENABLE_FORCE_IN_Fired_EventHandler
			F_S1.Enabled = F_S1.Visible = F_S2.Enabled = F_S2.Visible = F_S3.Enabled = F_S3.Visible = F_S4.Enabled = F_S4.Visible =
			F_S5.Enabled = F_S5.Visible = F_S6.Enabled = F_S6.Visible = F_S7.Enabled = F_S7.Visible = F_S8.Enabled = F_S8.Visible = (bool) e.iEnableForce;
		}

		void FORCE_UNAV_Fired_EventHandler(object sender, FORCE_UNAVEventArgs e)
		{
			// TODO: Implement FORCE_UNAV_Fired_EventHandler
			ReactorNotAv.Visible = (bool) e.ForceUnavailable;
		}
	}
}
