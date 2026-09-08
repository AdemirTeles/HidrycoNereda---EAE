/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 6/5/2026
 * Time: 4:25 PM
 * 
 */

using System;
using NxtControl.GuiFramework;
using System.ComponentModel;
using SE.App2Base.SupportClasses;

namespace SE.Nereda.Faceplates.AnalogInput
{
	/// <summary>
	/// Description of fpDefault.
	/// </summary>
	public partial class fpDefault : NxtControl.GuiFramework.HMIFaceplate
	{
		float Percent;
		float iPvMin;
		float iPvMax;
		string InUnit;
		bool iLoLoPv;
		bool iLoPv;
		bool iHiPv;
		bool iHiHiPv;
		bool iChFail;
		bool isitFlowSensor;
		public fpDefault()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			this.REQ_PV_Fired += REQ_PV_Fired_EventHandler;
			this.REQ_ALM_LIM_SP_Fired += REQ_ALM_LIM_SP_Fired_EventHandler;
			this.FB_COLOR_Fired += FB_COLOR_Fired_EventHandler;
			this.CH_FAIL_Fired += CH_FAIL_Fired_EventHandler;
		}

		void REQ_PV_Fired_EventHandler(object sender, SE.Nereda.Symbols.AnalogInput.REQ_PVEventArgs e)
		{
			// TODO: Implement REQ_PV_Fired_EventHandler
			Override.Visible = (bool) e.OverrideStatus;
			Percent = (((float)e.Pv - (float)e.PvMin) / ((float)e.PvMax - (float)e.PvMin)) * 100;
			iPvMax = (float) e.PvMax;
			iPvMin = (float) e.PvMin;
			ShowLevel.FillPercent = Percent;
			
			L1v.BrushColor = (bool) e.L1 ? new NxtControl.Drawing.Color(0, 255, 0) : new NxtControl.Drawing.Color(54, 54, 54);
			L2v.BrushColor = (bool) e.L2 ? new NxtControl.Drawing.Color(0, 255, 0) : new NxtControl.Drawing.Color(54, 54, 54);
		}

		void REQ_ALM_LIM_SP_Fired_EventHandler(object sender, SE.Nereda.Symbols.AnalogInput.REQ_ALM_LIM_SPEventArgs e)
		{
			// TODO: Implement REQ_ALM_LIM_SP_Fired_EventHandler
			HighHigh.Location = new NxtControl.Drawing.PointF(104, 304 - (((float) e.HiHiSp - iPvMin) / (iPvMax - iPvMin)) * (304 - 128));
			High.Location = new NxtControl.Drawing.PointF(104, 304 - (((float) e.HiSp - iPvMin) / (iPvMax - iPvMin)) * (304 - 128));
			Low.Location = new NxtControl.Drawing.PointF(104, 312 - (((float)e.LoSp - iPvMin) / (iPvMax - iPvMin)) * (312 - 136));
			LowLow.Location = new NxtControl.Drawing.PointF(104, 312 - (((float)e.LoLoSp - iPvMin) / (iPvMax - iPvMin)) * (312 - 136));
			
			LowLowBar.FillPercent = (((float)e.LoLoSp - iPvMin) / (iPvMax - iPvMin)) * 100;
			LowBar.FillPercent = (((float)e.LoSp - iPvMin) / (iPvMax - iPvMin)) * 100;
			HighBar.FillPercent = 100 - (((float)e.HiSp - iPvMin) / (iPvMax - iPvMin)) * 100;
			HighHighBar.FillPercent = 100 - (((float)e.HiHiSp - iPvMin) / (iPvMax - iPvMin)) * 100;
			
			iLoLoPv = (bool) e.LoLoPv;
			iLoPv = (bool) e.LoPv;
			iHiPv = (bool) e.HiPv;
			iHiHiPv = (bool) e.HiHiPv;
			LevelSensorStatus();
		}
			
		void SettingsClick(object sender, EventArgs e)
		{
			// TODO: Implement SettingsClick
			AnalogInput.Unit.EngineeringValue = InUnit;
		    this.AnalogInput.DoOpenFaceplate("fpParameter");
		}

		void TrendsClick(object sender, EventArgs e)
		{
			// TODO: Implement TrendsClick
			this.AnalogInput.DoOpenFaceplate("fpTrend");
		}

		void FB_COLOR_Fired_EventHandler(object sender, SE.Nereda.Symbols.AnalogInput.FB_COLOREventArgs e)
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

		void CH_FAIL_Fired_EventHandler(object sender, SE.Nereda.Symbols.AnalogInput.CH_FAILEventArgs e)
		{
			// TODO: Implement CH_FAIL_Fired_EventHandler
			iChFail = (bool) e.ChFail;
			LevelSensorStatus();
		}
		
		void LevelSensorStatus(){
			LevelStatus.Text = "";
			
			// Display Level Status
			if(iChFail == true){
				LevelStatus.Text = "I/O Channel Failure";
				LevelStatus.TextColor = new NxtControl.Drawing.BlinkColor("SE.Nereda.Orangwhite");
			}
			else{
				if (iLoLoPv == false && iLoPv == false && iHiPv == false && iHiHiPv == false)
				{
				    LevelStatus.Text = "Normal Level";
				    LevelStatus.Color = new NxtControl.Drawing.Color(61, 205, 88); // Green
				}
				else if (iLoPv == true && iLoLoPv == false)
				{
				    LevelStatus.Text = "Low Level";
				    LevelStatus.Color = new NxtControl.Drawing.Color(254, 186, 10); // Orange
				}
				else if (iHiPv == true && iHiHiPv == false)
				{
				    LevelStatus.Text = "High Level";
				    LevelStatus.Color = new NxtControl.Drawing.Color(254, 186, 10); // Orange
				}
				else if (iLoPv == true && iLoLoPv == true)
				{
				    LevelStatus.Text = "Low Low Level";
				    LevelStatus.Color = new NxtControl.Drawing.Color(255, 0, 0); // Red
				}
				else if (iHiPv == true && iHiHiPv == true)
				{
				    LevelStatus.Text = "High High Level";
				    LevelStatus.Color = new NxtControl.Drawing.Color(255, 0, 0); // Red
				}
			}
		}

		void IUnitValueChanged(object sender, ValueChangedEventArgs e)
		{
			// TODO: Implement IUnitValueChanged
			if(isitFlowSensor == true){
				InUnit = Unit.Text = Unit2.Text = Unit3.Text =  highHighBtn.Unit = highBtn.Unit = lowBtn.Unit = lowLowBtn.Unit =
				rateOfChangeBtn.Unit = deviationBtn.Unit = "m³/h";
			}
			else{
				InUnit = Unit.Text = Unit2.Text = Unit3.Text =  highHighBtn.Unit = highBtn.Unit = lowBtn.Unit = lowLowBtn.Unit =
				rateOfChangeBtn.Unit = deviationBtn.Unit = e.Value.ToString();
			}
		}

		void IFlowSensorValueChanged(object sender, ValueChangedEventArgs e)
		{
			// TODO: Implement IFlowSensorValueChanged
			isitFlowSensor = (bool) e.Value;
		}

		void HiHiDisabledValueChanged(object sender, ValueChangedEventArgs e)
		{
			// TODO: Implement HiHiDisabledValueChanged
			HighHigh.Visible = HighHighBar.Visible = !(bool)e.Value;
		}

		void HiDisabledValueChanged(object sender, ValueChangedEventArgs e)
		{
			// TODO: Implement HiDisabledValueChanged
			High.Visible = HighBar.Visible = !(bool)e.Value;
		}

		void LoDisabledValueChanged(object sender, ValueChangedEventArgs e)
		{
			// TODO: Implement LoDisabledValueChanged
			Low.Visible = LowBar.Visible = !(bool)e.Value;
		}

		void LoLoDisabledValueChanged(object sender, ValueChangedEventArgs e)
		{
			// TODO: Implement LoLoDisabledValueChanged
			LowLow.Visible = LowLowBar.Visible = !(bool)e.Value;
		}
	}
}
