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
	public partial class sReactor4 : NxtControl.GuiFramework.HMISymbol
	{
		private string _LT001 = "4xLT1005";
		private string _REACTOR = "Reactor 1";
		private string _AV4x101 = "AV4x101";
		private string _AV4x171 = "AV4x171";
		private string _AV4x172 = "AV4x172";
		private string _AV4x103 = "AV4x103";
		private string _AV4x107 = "AV4x107";
		public sReactor4()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			this.PHASE_Fired += PHASE_Fired_EventHandler;
			this.LEVEL_Fired += LEVEL_Fired_EventHandler;
			AirBubbles1.Visible = AirBubbles2.Visible = AirBubbles3.Visible = false;
			ShowLevel.FillPercent = 0;
		}
		
		[RefreshProperties(RefreshProperties.Repaint)]
		[Category("Tagnames")]
		[DisplayName("LT001 Code")]
		
		public string _iLT001
		{
			get{
				return _LT001;
			}
			set{
				_LT001 = value;
				LT001.Text = value.ToString();
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
		
		[RefreshProperties(RefreshProperties.Repaint)]
		[Category("Tagnames")]
		[DisplayName("AV4x101 Code")]
		
		public string _iAV4x101
		{
			get{
				return _AV4x101;
			}
			set{
				_AV4x101 = value;
				AV4x101.Text = value.ToString();
			}
		}
		
		[RefreshProperties(RefreshProperties.Repaint)]
		[Category("Tagnames")]
		[DisplayName("AV4x171 Code")]
		
		public string _iAV4x171
		{
			get{
				return _AV4x171;
			}
			set{
				_AV4x171 = value;
				AV4x171.Text = value.ToString();
			}
		}
		
		[RefreshProperties(RefreshProperties.Repaint)]
		[Category("Tagnames")]
		[DisplayName("AV4x172 Code")]
		
		public string _iAV4x172
		{
			get{
				return _AV4x172;
			}
			set{
				_AV4x172 = value;
				AV4x172.Text = value.ToString();
			}
		}
		
		[RefreshProperties(RefreshProperties.Repaint)]
		[Category("Tagnames")]
		[DisplayName("AV4x103 Code")]
		
		public string _iAV4x103
		{
			get{
				return _AV4x103;
			}
			set{
				_AV4x103 = value;
				AV4x103.Text = value.ToString();
			}
		}
		
		[RefreshProperties(RefreshProperties.Repaint)]
		[Category("Tagnames")]
		[DisplayName("AV4x107 Code")]
		
		public string _iAV4x107
		{
			get{
				return _AV4x107;
			}
			set{
				_AV4x107 = value;
				AV4x107.Text = value.ToString();
			}
		}

		void PHASE_Fired_EventHandler(object sender, PHASEEventArgs e)
		{
			// TODO: Implement PHASE_Fired_EventHandler
			AirBubbles1.Visible = AirBubbles2.Visible = AirBubbles3.Visible = (bool)e.AerateRun;
		}

		void LEVEL_Fired_EventHandler(object sender, LEVELEventArgs e)
		{
			// TODO: Implement LEVEL_Fired_EventHandler
			ShowLevel.FillPercent = (float) (e.LevelPv / e.LevelPvMax) *100;
		}
	}
}
