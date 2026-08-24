/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 6/13/2026
 * Time: 5:41 PM
 * 
 */

using System;
using NxtControl.GuiFramework;
using System.ComponentModel;

namespace SE.Nereda.Symbols.InfluentFeed
{
	/// <summary>
	/// Description of sDefault.
	/// </summary>
	public partial class sInfluent : NxtControl.GuiFramework.HMISymbol
	{
		private string _XV001 = "NVPP 001 a-- 001";
		private string _XV002 = "NVPP 001 a-- 003";
		private string _XV003 = "NVPP 001 a-- 004";
		private string _MNG001 = "NVPP 001 Mixer001";
		private string _NDS001 = "NVPP 001 RGI 001";
		private string _DSC001 = "NVPP 001 dsc 001";
		private string _FAN001 = "NVPP 001 ven 004";
		private string _XS001 = "NVPP 001 nds 001";
		
		private string _XV005 = "NVPP 001 a-- 005";
		private string _XV006 = "NVPP 001 a-- 006";
		private string _XV063 = "NVPP 001 a-- 063";
		private string _PUMP001 = "NVPP 001 ctp 001";
		private string _PI001 = "NVPP 001 pi 002";
		private string _FT001 = "NVPP 001 ft 001";
		public sInfluent()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
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
		[DisplayName("Mixer001 code")]
		public string _iMNG001
		{
			get{
				return _MNG001;
			}
			set{
				_MNG001 = value;
				MNG001.Text = value.ToString();
			}
		}
 
		[RefreshProperties(RefreshProperties.Repaint)]
		[Category("Tagnames")]
		[DisplayName("NDS001 code")]
		public string _iNDS001
		{
			get{
				return _NDS001;
			}
			set{
				_NDS001 = value;
				NDS001.Text = value.ToString();
			}
		}
 
		[RefreshProperties(RefreshProperties.Repaint)]
		[Category("Tagnames")]
		[DisplayName("DSC001 code")]
		public string _iDSC001
		{
			get{
				return _DSC001;
			}
			set{
				_DSC001 = value;
				DSC001.Text = value.ToString();
			}
		}
 
		[RefreshProperties(RefreshProperties.Repaint)]
		[Category("Tagnames")]
		[DisplayName("FAN001 code")]
		public string _iFAN001
		{
			get{
				return _FAN001;
			}
			set{
				_FAN001 = value;
				FAN001.Text = value.ToString();
			}
		}
 
		[RefreshProperties(RefreshProperties.Repaint)]
		[Category("Tagnames")]
		[DisplayName("XS001 code")]
		public string _iXS001
		{
			get{
				return _XS001;
			}
			set{
				_XS001 = value;
				XS001.Text = value.ToString();
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
