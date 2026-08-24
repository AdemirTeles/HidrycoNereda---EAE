/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 6/5/2026
 * Time: 3:20 PM
 * 
 */

using System;
using NxtControl.GuiFramework;
using System.ComponentModel;

namespace SE.Nereda.Symbols.AnalogInput
{
	/// <summary>
	/// Description of sDefault.
	/// </summary>
	public partial class sPvBarHoz : NxtControl.GuiFramework.HMISymbol
	{
		private string _Unit = "%";
		private string _SensorName = "Name";
		string UnitOut;
		public sPvBarHoz()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			this.REQ_PV_Fired += REQ_PV_Fired_EventHandler;
			this.FB_COLOR_Fired += FB_COLOR_Fired_EventHandler;
			this.CH_FAIL_Fired += CH_FAIL_Fired_EventHandler;
			ChFailure.Visible = false;
		}
		
		[RefreshProperties(RefreshProperties.Repaint)]
		[Category("Tagnames")]
		[DisplayName("Unit")]
		
		public string _iUnit
		{
			get{
				return _Unit;
			}
			set{
				_Unit = value;
				UnitOut = Unit.Text = value.ToString();
			}
		}
		
		[RefreshProperties(RefreshProperties.Repaint)]
		[Category("Tagnames")]
		[DisplayName("SensorName")]
		
		public string _iSensorName
		{
			get{
				return _SensorName;
			}
			set{
				_SensorName = value;
				SensorName.Text = value.ToString();
			}
		}

		void REQ_PV_Fired_EventHandler(object sender, REQ_PVEventArgs e)
		{
			// TODO: Implement REQ_PV_Fired_EventHandler
			ShowLevel.FillPercent = (((float)e.Pv - (float)e.PvMin) / ((float)e.PvMax - (float)e.PvMin)) * 100;
		}

		void FB_COLOR_Fired_EventHandler(object sender, FB_COLOREventArgs e)
		{
			// TODO: Implement FB_COLOR_Fired_EventHandler
			switch (e.iColor)
			{
			    case 1:
					ShowLevel.BrushColor = new NxtControl.Drawing.Color(255,255,255);
			        break;
			    case 2:
					ShowLevel.BrushColor = new NxtControl.Drawing.Color(154, 154, 154);
			        break;
			    case 3:
					ShowLevel.BrushColor = new NxtControl.Drawing.Color(178, 14, 18);
			        break;
			    case 4:
					ShowLevel.BrushColor = new NxtControl.Drawing.Color(234, 22, 30);
			        break;
			    case 5:
					ShowLevel.BrushColor = new NxtControl.Drawing.Color(254, 186, 10);
			        break;
			    case 6:
					ShowLevel.BrushColor = new NxtControl.Drawing.Color(255, 255, 0);
			        break;
			    case 7:
					ShowLevel.BrushColor = new NxtControl.Drawing.Color(150, 214, 66);
			        break;
			    case 8:
					ShowLevel.BrushColor = new NxtControl.Drawing.Color(61, 205, 88);
			        break;
			    case 9:
					ShowLevel.BrushColor = new NxtControl.Drawing.Color(2, 178, 238);
			        break;
			    case 10:
					ShowLevel.BrushColor = new NxtControl.Drawing.Color(0, 114, 188);
			        break;
			    case 11:
					ShowLevel.BrushColor = new NxtControl.Drawing.Color(47, 54, 153);
			        break;
			    case 12:
					ShowLevel.BrushColor = new NxtControl.Drawing.Color(111, 49, 152);
			        break;
			}
		}

		void CH_FAIL_Fired_EventHandler(object sender, CH_FAILEventArgs e)
		{
			// TODO: Implement CH_FAIL_Fired_EventHandler
			ChFailure.Visible = (bool) e.ChFail;
		}
	}
}
