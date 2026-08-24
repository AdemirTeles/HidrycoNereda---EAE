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

namespace SE.Nereda.Symbols.NeredaEffluent
{
	/// <summary>
	/// Description of sDefault.
	/// </summary>
	public partial class sEffluent : NxtControl.GuiFramework.HMISymbol
	{
		private string _XV001 = "NVPP 001 a-- 021";
		private string _XV002 = "NVPP 001 a-- 010";
		private string _XV003 = "NVPP 001 a-- 032";
		private string _XV004 = "NVPP 001 a-- 012";
		private string _XV005 = "NVPP 001 a-- 064";
		private string _CV001 = "NVPP 001 a-- 011";
		private string _CV002 = "NVPP 001 a-- 002";
		private string _CV003 = "NVPP 001 a-- 018";
		private string _CV012 = "NVPP 001 a-- 012";
		private string _CV014 = "NVPP 001 a-- 014";
		private string _PUMP001 = "NVPP 001 ctp 002";
		private string _PUMP002 = "NVPP 001 ctp 003";
		private string _FT001 = "NVPP 001 ft 002";
		private string _FT002 = "NVPP 001 ft 003";
		private string _TANKNAME = "Effluent +/- 37m²";
		
		public sEffluent()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
		}
		
		[RefreshProperties(RefreshProperties.Repaint)]
		[Category("Tagnames")]
		[DisplayName("Tankname")]
		
		public string _iTANKNAME
		{
			get{
				return _TANKNAME;
			}
			set{
				_TANKNAME = value;
				TANKNAME.Text = value.ToString();
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
				Xv001.Text = value.ToString();
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
				CV014.Text = value.ToString();
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
		[DisplayName("CV012 Code")]
		
		public string _iCV012
		{
			get{
				return _CV012;
			}
			set{
				_CV012 = value;
				CV012.Text = value.ToString();
			}
		}
		
		[RefreshProperties(RefreshProperties.Repaint)]
		[Category("Tagnames")]
		[DisplayName("CV014 Code")]
		
		public string _iCV014
		{
			get{
				return _CV014;
			}
			set{
				_CV014 = value;
				CV014.Text = value.ToString();
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
		[DisplayName("Pump002 code")]
		
		public string _iPUMP002
		{
			get{
				return _PUMP002;
			}
			set{
				_PUMP002 = value;
				PUMP002.Text = value.ToString();
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

		[RefreshProperties(RefreshProperties.Repaint)]
		[Category("Tagnames")]
		[DisplayName("FT002 code")]
		
		public string _iFT002
		{
			get{
				return _FT002;
			}
			set{
				_FT002 = value;
				FT002.Text = value.ToString();
			}
		}		
	}
}
