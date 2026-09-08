/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 6/11/2026
 * Time: 3:07 PM
 * 
 */

using System;
using NxtControl.GuiFramework;

namespace SE.Nereda.Faceplates.DAerationLogic
{
	/// <summary>
	/// Description of fpAerMonitoring.
	/// </summary>
	public partial class fpAerSettings : NxtControl.GuiFramework.HMIFaceplate
	{
		int TimeM1;
		int TimeH1;

		int TimeM2;
		int TimeH2;
		
		float InC_Max;
		float InC_IN;
		float yCOut;
		float cOut;
		
		int InCapConfig;
		public fpAerSettings()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			this.BLS_OPD_Fired += BLS_OPD_Fired_EventHandler;
			this.CAP_IN_Fired += CAP_IN_Fired_EventHandler;
			this.PARAMETER_Fired += PARAMETER_Fired_EventHandler;
			this.CAP_OUT_Fired += CAP_OUT_Fired_EventHandler;
			this.GRAPH_Fired += GRAPH_Fired_EventHandler;
			this.IN_CAP_CNFG_Fired += IN_CAP_CNFG_Fired_EventHandler;
		}

		void BLS_OPD_Fired_EventHandler(object sender, SE.Nereda.Symbols.DAerationLogic.BLS_OPDEventArgs e)
		{
			// TODO: Implement BLS_OPD_Fired_EventHandler
			TimeH1 = (int) e.BL1TotOpDur / 60;
			TimeM1 = (int) e.BL1TotOpDur % 60;
			
			TotRunDurBl1Txt.Text = TimeH1.ToString() + "h " + ": " + TimeM1.ToString() + "min ";
			
			TimeH2 = (int) e.BL2TotOpDur / 60;
			TimeM2 = (int) e.BL2TotOpDur % 60;
			
			TotRunDurBl2Txt.Text = TimeH2.ToString() + "h " + ": " + TimeM2.ToString() + "min ";
		}

		void CAP_IN_Fired_EventHandler(object sender, SE.Nereda.Symbols.DAerationLogic.CAP_INEventArgs e)
		{
			// TODO: Implement CAP_IN_Fired_EventHandler
			InC_IN = (float) e.iC_IN;
			
			X_C_IN.StartPoint = new NxtControl.Drawing.PointF(60 + (InC_IN * (452 - 60) / 100), 56);
			X_C_IN.EndPoint = new NxtControl.Drawing.PointF(60 + (InC_IN * (452 - 60) / 100), 268);
			C_IN_Txt.Location = new NxtControl.Drawing.PointF(40 + (InC_IN * (452 - 60) / 100), 40);
		}

		void PARAMETER_Fired_EventHandler(object sender, SE.Nereda.Symbols.DAerationLogic.PARAMETEREventArgs e)
		{
			// TODO: Implement PARAMETER_Fired_EventHandler
			InC_Max = (float) e.iC_MAX;
			
			Y_C2_IN.StartPoint = new NxtControl.Drawing.PointF(56, 264 - ((float)e.iC2_IN * (264 - 64) / 100));
			Y_C2_IN.EndPoint = new NxtControl.Drawing.PointF(464, 264 - ((float)e.iC2_IN * (264 - 64) / 100));
			
			Y_C3_IN.StartPoint = new NxtControl.Drawing.PointF(56, 264 - ((float)e.iC3_IN * (264 - 64) / 100));
			Y_C3_IN.EndPoint = new NxtControl.Drawing.PointF(464, 264 - ((float)e.iC3_IN * (264 - 64) / 100));
			
			X_C_MAX.StartPoint = new NxtControl.Drawing.PointF(60 + ((float)e.iC_MAX * (452 - 60) / 100), 56);
			X_C_MAX.EndPoint = new NxtControl.Drawing.PointF(60 + ((float)e.iC_MAX * (452 - 60) / 100), 268);
			
			C_MAX_Txt.Location = new NxtControl.Drawing.PointF(40 + ((float)e.iC_MAX * (452 - 60) / 100), 40);
			C2_Txt.Location = new NxtControl.Drawing.PointF(472, 256 - ((float)e.iC2_IN * (264 - 64) / 100));
			C3_Txt.Location = new NxtControl.Drawing.PointF(472, 256 - ((float)e.iC3_IN * (264 - 64) / 100));
			
			L1Blowers.EndPoint = new NxtControl.Drawing.PointF(60 + ((float)e.iC_MAX * (452 - 60) / 100), 64);
			
			if(InCapConfig == 2){
				L2Blowers.StartPoint = new NxtControl.Drawing.PointF(60 + ((float)e.iC_MAX * (452 - 60) / 100), 164);
			}
			else if(InCapConfig == 1){
				L2Blowers.StartPoint = new NxtControl.Drawing.PointF(60 + ((float)e.iC_MAX * (452 - 60) / 100), 264);
			}
		}

		void CAP_OUT_Fired_EventHandler(object sender, SE.Nereda.Symbols.DAerationLogic.CAP_OUTEventArgs e)
		{
			// TODO: Implement CAP_OUT_Fired_EventHandler
			if(InC_IN <= InC_Max){
				yCOut = 264 - ((float)e.iC_OUT * (264 - 64) / 100);
			    Y_C_OUT.StartPoint = new NxtControl.Drawing.PointF(56, yCOut);
			    Y_C_OUT.EndPoint   = new NxtControl.Drawing.PointF(464, yCOut);
			}
			
			else if (InC_IN > InC_Max)
			{
			    cOut = (float)e.iC_OUT;
			
			    // Limit C_OUT depending on the capacity configuration
			    if (InCapConfig == 1)
			    {
			        // Config 1: C_OUT range = 0% to 86%
			        if (cOut < 0)
			            cOut = 0;
			
			        if (cOut > 86)
			            cOut = 86;
			    }
			    else if (InCapConfig == 2)
			    {
			        // Config 2: C_OUT range = 50% to 86%
			        if (cOut < 50)
			            cOut = 50;
			
			        if (cOut > 86)
			            cOut = 86;
			    }
			
			    // Scaling:
			    // 0%  => Y = 264
			    // 50% => Y = 164
			    // 86% => Y = 92
			    yCOut = 264 - (cOut * 2);
			
			    // Apply the calculated Y position
			    Y_C_OUT.StartPoint = new NxtControl.Drawing.PointF(56, yCOut);
			    Y_C_OUT.EndPoint = new NxtControl.Drawing.PointF(464, yCOut);
			}
			C_OUT_Txt.Location = new NxtControl.Drawing.PointF(472, yCOut - 8);
		}

		void GRAPH_Fired_EventHandler(object sender, SE.Nereda.Symbols.DAerationLogic.GRAPHEventArgs e)
		{
			// TODO: Implement GRAPH_Fired_EventHandler
			switch (e.Grafcet)
			{
			    case 1:
			        Status.Text = "Idle";
			        break;
			
			    case 2:
			        Status.Text = "Starting Single Blower";
			        break;
			
			    case 3:
			        Status.Text = "Single Blower Running";
			        break;
			
			    case 4:
			        Status.Text = "Starting Two Blowers";
			        break;
			
			    case 5:
			        Status.Text = "Two Blowers Running";
			        break;
			
			    case 6:
			        Status.Text = "Stopping Blowers";
			        break;
			
			    case 7:
			        Status.Text = "Blowers Stopped";
			        break;
			
			    case 8:
			        Status.Text = "Switching to Single Blower";
			        break;
			
			    default:
			        Status.Text = "Unknown Status";
			        break;
			}
			
		}

		void IN_CAP_CNFG_Fired_EventHandler(object sender, SE.Nereda.Symbols.DAerationLogic.IN_CAP_CNFGEventArgs e)
		{
			// TODO: Implement IN_CAP_CNFG_Fired_EventHandler
			InCapConfig = (int)e.iCapacityConfig;
			if(InCapConfig == 2){
				L2Blowers.StartPoint = new NxtControl.Drawing.PointF(60 + (InC_Max * (452 - 60) / 100), 164);
			}
			else if(InCapConfig == 1){
				L2Blowers.StartPoint = new NxtControl.Drawing.PointF(60 + (InC_Max * (452 - 60) / 100), 264);
			}
		}
	}
}
