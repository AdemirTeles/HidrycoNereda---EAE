/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 6/9/2026
 * Time: 7:02 PM
 * 
 */

using System;
using NxtControl.GuiFramework;
using System.ComponentModel;

namespace SE.Nereda.Symbols.NeredaReactor
{
	/// <summary>
	/// Description of sReactor1.
	/// </summary>
	public partial class sReactor3 : NxtControl.GuiFramework.HMISymbol
	{
		private string _REACTOR = "Reactor 1";
		float Percent;
		public sReactor3()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			this.PHASE_Fired += PHASE_Fired_EventHandler;
			this.LEVEL_Fired += LEVEL_Fired_EventHandler;
			AirBubbles1.Visible = AirBubbles2.Visible = false;
			WaterLevel.FillPercent = 0;
			WaterBase.Visible = false;
			WaterTop.Visible = false;
		}

		[RefreshProperties(RefreshProperties.Repaint)]
		[Category("Tagnames")]
		[DisplayName("Reactor Code")]
		
		public string _iREACTOR
		{
			get{
				return _REACTOR;
			}
			set{
				_REACTOR = value;
				REACTOR.Text = value.ToString();
			}
		}

		void PHASE_Fired_EventHandler(object sender, PHASEEventArgs e)
		{
			// TODO: Implement PHASE_Fired_EventHandler
			if(Percent < 50){
				AirBubbles1.Visible = (bool)e.AerateRun;
				AirBubbles2.Visible = false;
			}
			else if(Percent >= 50){
				AirBubbles1.Visible = AirBubbles2.Visible = (bool)e.AerateRun;
			}
			
			if(e.FeedRun == false && e.AerateRun == false && e.SludgeDischargeRun == false && e.VentRun == false && e.WaitRun == false){
				ReactorState.Text = e.ReactorStatus;
			}
			else if(e.FeedRun == true && e.AerateRun == false && e.SludgeDischargeRun == false && e.VentRun == false && e.WaitRun == false){
				ReactorState.Text = e.ReactorStatus + " : FEED";
			}
			else if(e.FeedRun == false && e.AerateRun == true && e.SludgeDischargeRun == false && e.VentRun == false && e.WaitRun == false){
				ReactorState.Text = e.ReactorStatus + " : AERATE";
			}
			else if(e.FeedRun == false && e.AerateRun == false && e.SludgeDischargeRun == true && e.VentRun == false && e.WaitRun == false){
				ReactorState.Text = e.ReactorStatus + " : SD";
			}
			else if(e.FeedRun == false && e.AerateRun == false && e.SludgeDischargeRun == false && e.VentRun == true && e.WaitRun == false){
				ReactorState.Text = e.ReactorStatus + " : VENT";
			}
			else if(e.FeedRun == false && e.AerateRun == false && e.SludgeDischargeRun == false && e.VentRun == false && e.WaitRun == true){
				ReactorState.Text = e.ReactorStatus + " : WAIT";
			}
		}

		void LEVEL_Fired_EventHandler(object sender, LEVELEventArgs e)
		{
			// TODO: Implement LEVEL_Fired_EventHandler
			Percent = (float) (e.LevelPv / e.LevelPvMax) *100;
			if(Percent > 0){
				WaterBase.Visible = WaterTop.Visible = true;
			}
			else if(Percent == 0){
				WaterBase.Visible = false;
				WaterTop.Visible = false;
			}
			
			WaterLevel.FillPercent = Percent;
			WaterTop.Location = new NxtControl.Drawing.PointF(48, 320 + (Percent * (112 - 320) / 100));
		}
	}
}
