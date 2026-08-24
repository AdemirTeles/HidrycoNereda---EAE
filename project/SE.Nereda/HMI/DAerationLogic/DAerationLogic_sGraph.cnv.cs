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
	public partial class sGraph : NxtControl.GuiFramework.HMISymbol
	{
		float InC_Max;
		float InC_IN;
		float yCOut;
		int InCapConfig;
		float cOut;
		public sGraph()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			this.CAP_IN_Fired += CAP_IN_Fired_EventHandler;
			this.PARAMETER_Fired += PARAMETER_Fired_EventHandler;
			this.CAP_OUT_Fired += CAP_OUT_Fired_EventHandler;
			this.IN_CAP_CNFG_Fired += IN_CAP_CNFG_Fired_EventHandler;
		}

		void CAP_IN_Fired_EventHandler(object sender, CAP_INEventArgs e)
		{
			// TODO: Implement CAP_IN_Fired_EventHandler
			InC_IN = (float) e.iC_IN;
			
			X_C_IN.StartPoint = new NxtControl.Drawing.PointF(60 + (InC_IN * (452 - 60) / 100), 56);
			X_C_IN.EndPoint = new NxtControl.Drawing.PointF(60 + (InC_IN * (452 - 60) / 100), 268);
			C_IN_Txt.Location = new NxtControl.Drawing.PointF(40 + (InC_IN * (452 - 60) / 100), 40);
		}

		void PARAMETER_Fired_EventHandler(object sender, PARAMETEREventArgs e)
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

		void CAP_OUT_Fired_EventHandler(object sender, CAP_OUTEventArgs e)
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

		void IN_CAP_CNFG_Fired_EventHandler(object sender, IN_CAP_CNFGEventArgs e)
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
