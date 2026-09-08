/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 6/17/2026
 * Time: 10:04 AM
 * 
 */

using System;
using NxtControl.GuiFramework;
using System.ComponentModel;

namespace SE.Nereda.Symbols.InfluentFeed
{
	/// <summary>
	/// Description of sFeedPipe.
	/// </summary>
	public partial class sFeedPipe : NxtControl.GuiFramework.HMISymbol
	{
		private string _XV005 = "NVPP 001 a-- 005";
		private string _XV006 = "NVPP 001 a-- 006";
		private string _XV063 = "NVPP 001 a-- 063";
		private string _PUMP001 = "NVPP 001 ctp 001";
		private string _PI001 = "NVPP 001 pi 002";
		private string _FT001 = "NVPP 001 ft 001";
		public sFeedPipe()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
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
		[DisplayName("XV063 Code")]
		
		public string _iXV063
		{
			get{
				return _XV063;
			}
			set{
				_XV063 = value;
				XV063.Text = value.ToString();
			}
		}
		
		[RefreshProperties(RefreshProperties.Repaint)]
		[Category("Tagnames")]
		[DisplayName("Pump001 code")]
		
		public string _iPUMP001
		{
			get{
				return _PUMP001;
			}
			set{
				_PUMP001 = value;
				PUMP001.Text = value.ToString();
			}
		}

		[RefreshProperties(RefreshProperties.Repaint)]
		[Category("Tagnames")]
		[DisplayName("PI001 code")]
		
		public string _iPI001
		{
			get{
				return _PI001;
			}
			set{
				_PI001 = value;
				//PI001.Text = value.ToString();
			}
		}

		[RefreshProperties(RefreshProperties.Repaint)]
		[Category("Tagnames")]
		[DisplayName("FT001 code")]
		
		public string _iFT001
		{
			get{
				return _FT001;
			}
			set{
				_FT001 = value;
				FT001.Text = value.ToString();
			}
		}
	}
}
