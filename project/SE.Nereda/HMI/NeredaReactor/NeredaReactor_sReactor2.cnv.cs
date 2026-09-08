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
	public partial class sReactor2 : NxtControl.GuiFramework.HMISymbol
	{
		private string _CV001 = "NVPP 001 a-- 038";
		private string _CV002 = "NVPP 001 a-- 067";
		private string _CV003 = "NVPP 001 a-- 036";
		private string _CV004 = "NVPP 001 a-- 023";
		private string _CV005 = "NVPP 001 a-- 007";
		private string _REACTOR = "Reactor 1";
		float Percent;
		public sReactor2()
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
		[DisplayName("CV001 Code")]
		
		public string _iCV001
		{
			get{
				return _CV001;
			}
			set{
				_CV001 = value;
				CV001.Text = value.ToString();
			}
		}
		
		[RefreshProperties(RefreshProperties.Repaint)]
		[Category("Tagnames")]
		[DisplayName("CV002 Code")]
		
		public string _iCV002
		{
			get{
				return _CV002;
			}
			set{
				_CV002 = value;
				CV002.Text = value.ToString();
			}
		}
		
		[RefreshProperties(RefreshProperties.Repaint)]
		[Category("Tagnames")]
		[DisplayName("CV003 Code")]
		
		public string _iCV003
		{
			get{
				return _CV003;
			}
			set{
				_CV003 = value;
				CV003.Text = value.ToString();
			}
		}
		
		[RefreshProperties(RefreshProperties.Repaint)]
		[Category("Tagnames")]
		[DisplayName("CV004 Code")]
		
		public string _iCV004
		{
			get{
				return _CV004;
			}
			set{
				_CV004 = value;
				CV004.Text = value.ToString();
			}
		}
		
		[RefreshProperties(RefreshProperties.Repaint)]
		[Category("Tagnames")]
		[DisplayName("CV005 Code")]
		
		public string _iCV005
		{
			get{
				return _CV005;
			}
			set{
				_CV005 = value;
				CV005.Text = value.ToString();
			}
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
			ReactorState.Text = e.ReactorStatus;
			if(Percent < 50){
				AirBubbles1.Visible = (bool)e.AerateRun;
				AirBubbles2.Visible = false;
			}
			else if(Percent >= 50){
				AirBubbles1.Visible = AirBubbles2.Visible = (bool)e.AerateRun;
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
			WaterTop.Location = new NxtControl.Drawing.PointF(152,536 + (Percent * (328 - 536) / 100));
		}
	}
}
