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
	public partial class sReactor1 : NxtControl.GuiFramework.HMISymbol
	{
		private string _XV001 = "NVPP 001 a-- 073";
		private string _XV002 = "NVPP 001 a-- 059";
		private string _XV003 = "NVPP 001 a-- 022";
		private string _XV004 = "NVPP 001 a-- 050";
		private string _XV005 = "NVPP 001 a-- 051";
		private string _XV006 = "NVPP 001 a-- 091";
		private string _XV007 = "NVPP 001 a-- 092";
		private string _XV008 = "NVPP 001 a-- 097";
		private string _CV001 = "NVPP 001 a-- 038";
		private string _CV002 = "NVPP 001 a-- 067";
		private string _CV003 = "NVPP 001 a-- 036";
		private string _CV004 = "NVPP 001 a-- 023";
		private string _CV005 = "NVPP 001 a-- 007";
		private string _LT001 = "NVPP 001 lt 004";
		private string _REACTOR = "Reactor 1";
		public sReactor1()
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
		[DisplayName("XV001 Code")]
		
		public string _iXV001
		{
			get{
				return _XV001;
			}
			set{
				_XV001 = value;
				XV001.Text = value.ToString();
			}
		}

		[RefreshProperties(RefreshProperties.Repaint)]
		[Category("Tagnames")]
		[DisplayName("XV002 Code")]
		
		public string _iXV002
		{
			get{
				return _XV002;
			}
			set{
				_XV002 = value;
				XV002.Text = value.ToString();
			}
		}
		
		[RefreshProperties(RefreshProperties.Repaint)]
		[Category("Tagnames")]
		[DisplayName("XV003 Code")]
		
		public string _iXV003
		{
			get{
				return _XV003;
			}
			set{
				_XV003 = value;
				XV003.Text = value.ToString();
			}
		}
		
		[RefreshProperties(RefreshProperties.Repaint)]
		[Category("Tagnames")]
		[DisplayName("XV004 Code")]
		
		public string _iXV004
		{
			get{
				return _XV004;
			}
			set{
				_XV004 = value;
				XV004.Text = value.ToString();
			}
		}

		[RefreshProperties(RefreshProperties.Repaint)]
		[Category("Tagnames")]
		[DisplayName("XV005 Code")]
		
		public string _iXV005
		{
			get{
				return _XV005;
			}
			set{
				_XV005 = value;
				XV005.Text = value.ToString();
			}
		}
		
		[RefreshProperties(RefreshProperties.Repaint)]
		[Category("Tagnames")]
		[DisplayName("XV006 Code")]
		
		public string _iXV006
		{
			get{
				return _XV006;
			}
			set{
				_XV006 = value;
				XV006.Text = value.ToString();
			}
		}
		
		[RefreshProperties(RefreshProperties.Repaint)]
		[Category("Tagnames")]
		[DisplayName("XV007 Code")]
		
		public string _iXV007
		{
			get{
				return _XV007;
			}
			set{
				_XV007 = value;
				XV007.Text = value.ToString();
			}
		}

		[RefreshProperties(RefreshProperties.Repaint)]
		[Category("Tagnames")]
		[DisplayName("XV008 Code")]
		
		public string _iXV008
		{
			get{
				return _XV008;
			}
			set{
				_XV008 = value;
				XV008.Text = value.ToString();
			}
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
			AirBubbles1.Visible = AirBubbles2.Visible = AirBubbles3.Visible = (bool)e.AerateRun;
		}

		void LEVEL_Fired_EventHandler(object sender, LEVELEventArgs e)
		{
			// TODO: Implement LEVEL_Fired_EventHandler
			ShowLevel.FillPercent = (float) (e.LevelPv / e.LevelPvMax) *100;
		}
	}
}
