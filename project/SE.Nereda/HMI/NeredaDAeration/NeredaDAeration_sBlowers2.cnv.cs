/*
 * Created by EcoStruxure Automation Expert.
 * User: Schneider
 * Date: 5/7/2024
 * Time: 1:03 PM
 * 
 */

using System;
using NxtControl.GuiFramework;
using System.ComponentModel;

namespace SE.Nereda.Symbols.NeredaDAeration
{
	/// <summary>
	/// Description of sBlowers.
	/// </summary>
	public partial class sBlowers2 : NxtControl.GuiFramework.HMISymbol
	{
		private string _BL001 = "NVPP 001 BL001";
		private string _BL002 = "NVPP 001 BL002";
		private string _PI001 = "NVPP 001 PI001";
		private string _PI002 = "NVPP 001 PI002";

		public sBlowers2()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
		}
		
		[RefreshProperties(RefreshProperties.Repaint)]
		[Category("Tagnames")]
		[DisplayName("BL001 Code")]
		
		public string _iBL001
		{
			get{
				return _BL001;
			}
			set{
				_BL001 = value;
				BL001.Text = value.ToString();
			}
		}

		[RefreshProperties(RefreshProperties.Repaint)]
		[Category("Tagnames")]
		[DisplayName("BL002 Code")]
		
		public string _iBL002
		{
			get{
				return _BL002;
			}
			set{
				_BL002 = value;
				BL002.Text = value.ToString();
			}
		}
	
		[RefreshProperties(RefreshProperties.Repaint)]
		[Category("Tagnames")]
		[DisplayName("PI001 Code")]
		
		public string _iPI001
		{
			get{
				return _PI001;
			}
			set{
				_PI001 = value;
				PI001.Text = value.ToString();
			}
		}
	
		[RefreshProperties(RefreshProperties.Repaint)]
		[Category("Tagnames")]
		[DisplayName("PI002 Code")]
		
		public string _iPI002
		{
			get{
				return _PI002;
			}
			set{
				_PI002 = value;
				PI002.Text = value.ToString();
			}
		}


	}
}
