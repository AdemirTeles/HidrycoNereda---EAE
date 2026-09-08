/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 7/9/2026
 * Time: 10:25 AM
 * 
 */

using System;
using NxtControl.GuiFramework;
using System.ComponentModel;

namespace SE.Nereda.Symbols.NeredaMetalSaltDosing
{
	/// <summary>
	/// Description of sDefault.
	/// </summary>
	public partial class sDefault : NxtControl.GuiFramework.HMISymbol
	{
		private string _XV001 = "NVPP 001 a-- 056";
		private string _XV002 = "NVPP 001 a-- 057";
		private string _XV003 = "NVPP 001 a-- 058";
		private string _PUMP001 = "NVPP 001 fdp 001";
		public sDefault()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			this.LEVEL_PV_Fired += LEVEL_PV_Fired_EventHandler;
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

		void LEVEL_PV_Fired_EventHandler(object sender, LEVEL_PVEventArgs e)
		{
			// TODO: Implement LEVEL_PV_Fired_EventHandler
			Level.FillPercent = (float) (e.Pv / e.PvMax) * 100;
		}
	}
}
