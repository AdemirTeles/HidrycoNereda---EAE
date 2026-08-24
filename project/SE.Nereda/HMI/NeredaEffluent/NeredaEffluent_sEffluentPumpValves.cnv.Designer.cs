/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 6/26/2026
 * Time: 11:27 AM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.NeredaEffluent
{
	/// <summary>
	/// Summary description for sEffluentValves.
	/// </summary>
	partial class sEffluentPumpValves
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.sStatus1 = new SE.Nereda.Symbols.ValveS.sStatus();
			this.freeText1 = new NxtControl.GuiFramework.FreeText();
			this.sStatus2 = new SE.Nereda.Symbols.ValveS.sStatus();
			this.freeText2 = new NxtControl.GuiFramework.FreeText();
			this.sStatus3 = new SE.Nereda.Symbols.ValveS.sStatus();
			this.freeText3 = new NxtControl.GuiFramework.FreeText();
			this.sStatus4 = new SE.Nereda.Symbols.ValveS.sStatus();
			this.freeText4 = new NxtControl.GuiFramework.FreeText();
			this.sStatus5 = new SE.Nereda.Symbols.ValveS.sStatus();
			this.freeText5 = new NxtControl.GuiFramework.FreeText();
			this.sStatus6 = new SE.Nereda.Symbols.ValveS.sStatus();
			this.freeText6 = new NxtControl.GuiFramework.FreeText();
			this.rectangle1 = new NxtControl.GuiFramework.Rectangle();
			this.rectangle2 = new NxtControl.GuiFramework.Rectangle();
			this.freeText7 = new NxtControl.GuiFramework.FreeText();
			this.sStatus7 = new SE.Nereda.Symbols.Motor_VS.sStatus();
			this.line1 = new NxtControl.GuiFramework.Line();
			this.rectangle3 = new NxtControl.GuiFramework.Rectangle();
			this.sFlushFlowSp1 = new SE.Nereda.Symbols.FlushingManager.sFlushFlowSp();
			// 
			// sStatus1
			// 
			this.sStatus1.BeginInit();
			this.sStatus1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 120D, 64D);
			this.sStatus1.Name = "sStatus1";
			this.sStatus1.SecurityToken = ((uint)(4294967295u));
			this.sStatus1.TagName = "Actuators.NVPP_001_a_011";
			this.sStatus1.EndInit();
			// 
			// freeText1
			// 
			this.freeText1.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText1.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText1.Location = new NxtControl.Drawing.PointF(16D, 64D);
			this.freeText1.Name = "freeText1";
			this.freeText1.Text = "NVPP 001 a-- 011";
			// 
			// sStatus2
			// 
			this.sStatus2.BeginInit();
			this.sStatus2.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 120D, 80D);
			this.sStatus2.Name = "sStatus2";
			this.sStatus2.SecurityToken = ((uint)(4294967295u));
			this.sStatus2.TagName = "Actuators.NVPP_001_a_014";
			this.sStatus2.EndInit();
			// 
			// freeText2
			// 
			this.freeText2.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText2.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText2.Location = new NxtControl.Drawing.PointF(16D, 80D);
			this.freeText2.Name = "freeText2";
			this.freeText2.Text = "NVPP 001 a-- 014";
			// 
			// sStatus3
			// 
			this.sStatus3.BeginInit();
			this.sStatus3.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 120D, 96D);
			this.sStatus3.Name = "sStatus3";
			this.sStatus3.SecurityToken = ((uint)(4294967295u));
			this.sStatus3.TagName = "Actuators.NVPP_001_a_012";
			this.sStatus3.EndInit();
			// 
			// freeText3
			// 
			this.freeText3.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText3.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText3.Location = new NxtControl.Drawing.PointF(16D, 96D);
			this.freeText3.Name = "freeText3";
			this.freeText3.Text = "NVPP 001 a-- 012";
			// 
			// sStatus4
			// 
			this.sStatus4.BeginInit();
			this.sStatus4.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 120D, 144D);
			this.sStatus4.Name = "sStatus4";
			this.sStatus4.SecurityToken = ((uint)(4294967295u));
			this.sStatus4.TagName = "Actuators.NVPP_001_a_017";
			this.sStatus4.EndInit();
			// 
			// freeText4
			// 
			this.freeText4.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText4.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText4.Location = new NxtControl.Drawing.PointF(16D, 144D);
			this.freeText4.Name = "freeText4";
			this.freeText4.Text = "NVPP 001 a-- 017";
			// 
			// sStatus5
			// 
			this.sStatus5.BeginInit();
			this.sStatus5.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 120D, 112D);
			this.sStatus5.Name = "sStatus5";
			this.sStatus5.SecurityToken = ((uint)(4294967295u));
			this.sStatus5.TagName = "Actuators.NVPP_001_a_002";
			this.sStatus5.EndInit();
			// 
			// freeText5
			// 
			this.freeText5.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText5.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText5.Location = new NxtControl.Drawing.PointF(16D, 112D);
			this.freeText5.Name = "freeText5";
			this.freeText5.Text = "NVPP 001 a-- 002";
			// 
			// sStatus6
			// 
			this.sStatus6.BeginInit();
			this.sStatus6.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 120D, 128D);
			this.sStatus6.Name = "sStatus6";
			this.sStatus6.SecurityToken = ((uint)(4294967295u));
			this.sStatus6.TagName = "Actuators.NVPP_001_a_016";
			this.sStatus6.EndInit();
			// 
			// freeText6
			// 
			this.freeText6.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText6.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText6.Location = new NxtControl.Drawing.PointF(16D, 128D);
			this.freeText6.Name = "freeText6";
			this.freeText6.Text = "NVPP 001 a-- 016";
			// 
			// rectangle1
			// 
			this.rectangle1.Bounds = new NxtControl.Drawing.RectF(((float)(8D)), ((float)(32D)), ((float)(112D)), ((float)(128D)));
			this.rectangle1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("transparent"));
			this.rectangle1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle1.Name = "rectangle1";
			// 
			// rectangle2
			// 
			this.rectangle2.Bounds = new NxtControl.Drawing.RectF(((float)(8D)), ((float)(16D)), ((float)(240D)), ((float)(16D)));
			this.rectangle2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("transparent"));
			this.rectangle2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle2.Name = "rectangle2";
			this.rectangle2.Text = "Effluent Pump & Valves";
			this.rectangle2.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			// 
			// freeText7
			// 
			this.freeText7.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText7.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText7.Location = new NxtControl.Drawing.PointF(16D, 40D);
			this.freeText7.Name = "freeText7";
			this.freeText7.Text = "NVPP 001 ctp 002";
			// 
			// sStatus7
			// 
			this.sStatus7.BeginInit();
			this.sStatus7.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 120D, 32D);
			this.sStatus7.Name = "sStatus7";
			this.sStatus7.SecurityToken = ((uint)(4294967295u));
			this.sStatus7.TagName = "Actuators.NVPP_001_ctp_002";
			this.sStatus7.EndInit();
			// 
			// line1
			// 
			this.line1.EndPoint = new NxtControl.Drawing.PointF(8D, 64D);
			this.line1.Name = "line1";
			this.line1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line1.StartPoint = new NxtControl.Drawing.PointF(120D, 64D);
			// 
			// rectangle3
			// 
			this.rectangle3.Bounds = new NxtControl.Drawing.RectF(((float)(8D)), ((float)(160D)), ((float)(240D)), ((float)(16D)));
			this.rectangle3.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("transparent"));
			this.rectangle3.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle3.Name = "rectangle3";
			this.rectangle3.Text = "Flushing Flow Setpoint :";
			this.rectangle3.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			// 
			// sFlushFlowSp1
			// 
			this.sFlushFlowSp1.BeginInit();
			this.sFlushFlowSp1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 136D, 160D);
			this.sFlushFlowSp1.Name = "sFlushFlowSp1";
			this.sFlushFlowSp1.SecurityToken = ((uint)(4294967295u));
			this.sFlushFlowSp1.TagName = "EffluentLogic.FlushingManager";
			this.sFlushFlowSp1.EndInit();
			// 
			// sEffluentPumpValves
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.rectangle1,
			this.sStatus1,
			this.freeText1,
			this.sStatus2,
			this.freeText2,
			this.sStatus3,
			this.freeText3,
			this.sStatus4,
			this.freeText4,
			this.sStatus5,
			this.freeText5,
			this.sStatus6,
			this.freeText6,
			this.rectangle2,
			this.freeText7,
			this.sStatus7,
			this.line1,
			this.rectangle3,
			this.sFlushFlowSp1});
			this.SymbolSize = new System.Drawing.Size(384, 320);

		}
		private SE.Nereda.Symbols.ValveS.sStatus sStatus1;
		private NxtControl.GuiFramework.FreeText freeText1;
		private SE.Nereda.Symbols.ValveS.sStatus sStatus2;
		private NxtControl.GuiFramework.FreeText freeText2;
		private SE.Nereda.Symbols.ValveS.sStatus sStatus3;
		private NxtControl.GuiFramework.FreeText freeText3;
		private SE.Nereda.Symbols.ValveS.sStatus sStatus4;
		private NxtControl.GuiFramework.FreeText freeText4;
		private SE.Nereda.Symbols.ValveS.sStatus sStatus5;
		private NxtControl.GuiFramework.FreeText freeText5;
		private SE.Nereda.Symbols.ValveS.sStatus sStatus6;
		private NxtControl.GuiFramework.FreeText freeText6;
		private NxtControl.GuiFramework.Rectangle rectangle1;
		private NxtControl.GuiFramework.Rectangle rectangle2;
		private NxtControl.GuiFramework.FreeText freeText7;
		private SE.Nereda.Symbols.Motor_VS.sStatus sStatus7;
		private NxtControl.GuiFramework.Line line1;
		private NxtControl.GuiFramework.Rectangle rectangle3;
		private SE.Nereda.Symbols.FlushingManager.sFlushFlowSp sFlushFlowSp1;
		#endregion
	}
}
