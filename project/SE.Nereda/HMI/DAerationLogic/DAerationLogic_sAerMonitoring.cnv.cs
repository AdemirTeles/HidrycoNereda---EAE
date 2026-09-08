/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 6/11/2026
 * Time: 11:35 AM
 * 
 */

using System;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.DAerationLogic
{
	/// <summary>
	/// Description of sAerMonitoring.
	/// </summary>
	public partial class sAerMonitoring : NxtControl.GuiFramework.HMISymbol
	{
		int TimeS1;
		int TimeM1;
		int TimeH1;
		
		int TimeS2;
		int TimeM2;
		int TimeH2;
		
		public sAerMonitoring()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			this.CAP_IN_Fired += CAP_IN_Fired_EventHandler;
			this.PARAMETER_Fired += PARAMETER_Fired_EventHandler;
			this.CAP_OUT_Fired += CAP_OUT_Fired_EventHandler;
			this.BLS_OPD_Fired += BLS_OPD_Fired_EventHandler;
		}

		void CAP_IN_Fired_EventHandler(object sender, CAP_INEventArgs e)
		{
			// TODO: Implement CAP_IN_Fired_EventHandler
			Y_C_IN.StartPoint = new NxtControl.Drawing.PointF(56, 264 - ((float)e.iC_IN * (264 - 64) / 100));
			Y_C_IN.EndPoint = new NxtControl.Drawing.PointF(464, 264 - ((float)e.iC_IN * (264 - 64) / 100));
			
			C_IN_Txt.Location = new NxtControl.Drawing.PointF(472, 256 - ((float)e.iC_IN * (264 - 64) / 100));
		}

		void PARAMETER_Fired_EventHandler(object sender, PARAMETEREventArgs e)
		{
			// TODO: Implement PARAMETER_Fired_EventHandler
			Y_C2_IN.StartPoint = new NxtControl.Drawing.PointF(56, 264 - ((float)e.iC2_IN * (264 - 64) / 100));
			Y_C2_IN.EndPoint = new NxtControl.Drawing.PointF(464, 264 - ((float)e.iC2_IN * (264 - 64) / 100));
			
			Y_C3_IN.StartPoint = new NxtControl.Drawing.PointF(56, 264 - ((float)e.iC3_IN * (264 - 64) / 100));
			Y_C3_IN.EndPoint = new NxtControl.Drawing.PointF(464, 264 - ((float)e.iC3_IN * (264 - 64) / 100));
			
			X_C_MAX.StartPoint = new NxtControl.Drawing.PointF(60 + ((float)e.iC_MAX * (452 - 60) / 100), 56);
			X_C_MAX.EndPoint = new NxtControl.Drawing.PointF(60 + ((float)e.iC_MAX * (452 - 60) / 100), 268);
			
			C_MAX_Txt.Location = new NxtControl.Drawing.PointF(40 + ((float)e.iC_MAX * (452 - 60) / 100), 40);
			C2_Txt.Location = new NxtControl.Drawing.PointF(472, 256 - ((float)e.iC2_IN * (264 - 64) / 100));
			C3_Txt.Location = new NxtControl.Drawing.PointF(472, 256 - ((float)e.iC3_IN * (264 - 64) / 100));
		}

		void CAP_OUT_Fired_EventHandler(object sender, CAP_OUTEventArgs e)
		{
			// TODO: Implement CAP_OUT_Fired_EventHandler
			X_C_OUT.StartPoint = new NxtControl.Drawing.PointF(60 + ((float)e.iC_OUT * (452 - 60) / 100), 56);
			X_C_OUT.EndPoint = new NxtControl.Drawing.PointF(60 + ((float)e.iC_OUT * (452 - 60) / 100), 268);
			
			C_OUT_Txt.Location = new NxtControl.Drawing.PointF(40 + ((float)e.iC_OUT * (452 - 60) / 100), 40);
		}

		void BLS_OPD_Fired_EventHandler(object sender, BLS_OPDEventArgs e)
		{
			// TODO: Implement BLS_OPD_Fired_EventHandler
			TimeH1 = (int) e.BL1TotOpDur / 3600;
			TimeM1 = (int) (e.BL1TotOpDur % 3600) / 60;
			TimeS1 = (int) e.BL1TotOpDur % 60;
			
			TotRunDurBl1Txt.Text = TimeH1.ToString() + "h " + ": " + TimeM1.ToString() + "min " + ": " + TimeS1.ToString() + "s";
			
			TimeH2 = (int) e.BL2TotOpDur / 3600;
			TimeM2 = (int) (e.BL2TotOpDur % 3600) / 60;
			TimeS2 = (int) e.BL2TotOpDur % 60;
			
			TotRunDurBl2Txt.Text = TimeH2.ToString() + "h " + ": " + TimeM2.ToString() + "min " + ": " + TimeS2.ToString() + "s";
		}
	}
}
