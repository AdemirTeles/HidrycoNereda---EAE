/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 6/21/2026
 * Time: 11:02 AM
 * 
 */

using System;
using NxtControl.GuiFramework;
using System.ComponentModel;

namespace SE.Nereda.Symbols.Calamity
{
	/// <summary>
	/// Description of sDefault.
	/// </summary>
	public partial class sDefault : NxtControl.GuiFramework.HMISymbol
	{
		private string _XV001 = "46 2 AP a-- 95 004";
		private string _XV002 = "46 2 AP a-- 95 005";
		private string _CV001 = "46 2 AP lzp 95 008";
		private string _CV002 = "46 2 AP lzp 95 009";
		private string _CV003 = "46 2 AP lzp 95 010";	
		public sDefault()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			this.LEVEL_PV_Fired += LEVEL_PV_Fired_EventHandler;
			this.LEVEL_TOO_H_Fired += LEVEL_TOO_H_Fired_EventHandler;
			HiHiLevel.Visible = HiHiTxt.Visible = false;
			this.LEVEL_STATUS_Fired += LEVEL_STATUS_Fired_EventHandler;
		}

		void LEVEL_PV_Fired_EventHandler(object sender, LEVEL_PVEventArgs e)
		{
			// TODO: Implement LEVEL_PV_Fired_EventHandler
			ShowLevel.FillPercent = (((float)e.LevelPv - (float)e.LevelPvMin) / ((float)e.LevelPvMax - (float)e.LevelPvMin)) * 100;
		}

		void LEVEL_TOO_H_Fired_EventHandler(object sender, LEVEL_TOO_HEventArgs e)
		{
			// TODO: Implement LEVEL_TOO_H_Fired_EventHandler
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

		void LEVEL_STATUS_Fired_EventHandler(object sender, LEVEL_STATUSEventArgs e)
		{
			// TODO: Implement LEVEL_STATUS_Fired_EventHandler
			if(e.HiHiLevel == true || e.LevelSwitch == true){
				HiHiLevel.Visible = HiHiTxt.Visible = true;
			}
			else{
				HiHiLevel.Visible = HiHiTxt.Visible = false;
			}
		}
	}
}
