/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 10/7/2026
 * Time: 4:59 PM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using NxtControl.GuiFramework;

namespace SE.Nereda.Faceplates.EmergencySludgeBuffer
{
	/// <summary>
	/// Summary description for fpSettings.
	/// </summary>
	partial class fpSettings
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.rectangle1 = new NxtControl.GuiFramework.Rectangle();
			this.polygon1 = new NxtControl.GuiFramework.Polygon();
			this.freeText1 = new NxtControl.GuiFramework.FreeText();
			this.freeText2 = new NxtControl.GuiFramework.FreeText();
			this.freeText3 = new NxtControl.GuiFramework.FreeText();
			this.freeText4 = new NxtControl.GuiFramework.FreeText();
			this.freeText9 = new NxtControl.GuiFramework.FreeText();
			this.freeText12 = new NxtControl.GuiFramework.FreeText();
			this.S1_FeedTime = new System.HMI.Symbols.Base.TimeTextBox();
			this.S2_WaitSludge = new System.HMI.Symbols.Base.TimeTextBox();
			this.S3_SludgeDischargeTime = new System.HMI.Symbols.Base.TimeTextBox();
			this.S4_SupernantDischargeTime = new System.HMI.Symbols.Base.TimeTextBox();
			this.SludgeDischargeCapacity = new System.HMI.Symbols.Base.TextBox<float>();
			this.SupernantDischargeCapacity = new System.HMI.Symbols.Base.TextBox<float>();
			this.Restartlvl = new System.HMI.Symbols.Base.TextBox<short>();
			this.freeText5 = new NxtControl.GuiFramework.FreeText();
			this.FB_SBL1 = new System.HMI.Symbols.Base.TextBox<float>();
			this.FB_SBL2 = new System.HMI.Symbols.Base.TextBox<float>();
			this.freeText6 = new NxtControl.GuiFramework.FreeText();
			this.freeText7 = new NxtControl.GuiFramework.FreeText();
			// 
			// rectangle1
			// 
			this.rectangle1.Bounds = new NxtControl.Drawing.RectF(((float)(8D)), ((float)(24D)), ((float)(376D)), ((float)(496D)));
			this.rectangle1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(250)), ((byte)(250)), ((byte)(250))));
			this.rectangle1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle1.Name = "rectangle1";
			// 
			// polygon1
			// 
			this.polygon1.Bounds = new NxtControl.Drawing.RectF(((float)(8D)), ((float)(8D)), ((float)(288D)), ((float)(24D)));
			this.polygon1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(78)), ((byte)(78)), ((byte)(78))));
			this.polygon1.Closed = true;
			this.polygon1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular);
			this.polygon1.Name = "polygon1";
			this.polygon1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(78)), ((byte)(78)), ((byte)(78))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.polygon1.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(8D, 32D),
			new NxtControl.Drawing.PointF(8D, 8D),
			new NxtControl.Drawing.PointF(264D, 8D),
			new NxtControl.Drawing.PointF(296D, 32D)});
			this.polygon1.Text = "EMERGENCY RECIPE  -  SETTINGS";
			this.polygon1.TextColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(0)));
			// 
			// freeText1
			// 
			this.freeText1.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText1.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.freeText1.Location = new NxtControl.Drawing.PointF(16D, 44D);
			this.freeText1.Name = "freeText1";
			this.freeText1.Text = "Step 1 - Feed Time :";
			// 
			// freeText2
			// 
			this.freeText2.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText2.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.freeText2.Location = new NxtControl.Drawing.PointF(16D, 76D);
			this.freeText2.Name = "freeText2";
			this.freeText2.Text = "Step 2 - Wait Time :";
			// 
			// freeText3
			// 
			this.freeText3.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText3.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.freeText3.Location = new NxtControl.Drawing.PointF(16D, 116D);
			this.freeText3.Name = "freeText3";
			this.freeText3.Text = "Step 3 - Sludge Discharge Time :";
			// 
			// freeText4
			// 
			this.freeText4.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText4.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.freeText4.Location = new NxtControl.Drawing.PointF(16D, 156D);
			this.freeText4.Name = "freeText4";
			this.freeText4.Text = "Step 4 - Supernant Discharge Time :";
			// 
			// freeText9
			// 
			this.freeText9.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText9.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.freeText9.Location = new NxtControl.Drawing.PointF(16D, 240D);
			this.freeText9.Name = "freeText9";
			this.freeText9.Text = "Supernant Discharge Flow Setpoint :";
			// 
			// freeText12
			// 
			this.freeText12.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText12.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.freeText12.Location = new NxtControl.Drawing.PointF(16D, 200D);
			this.freeText12.Name = "freeText12";
			this.freeText12.Text = "Sludge Discharge Flow Setpoint :";
			// 
			// S1_FeedTime
			// 
			this.S1_FeedTime.BeginInit();
			this.S1_FeedTime.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.58666666666666656D, 0D, 0D, 0.92307692307692313D, 256D, 40D);
			this.S1_FeedTime.Maximum = new NxtControl.GuiFramework.Time(((long)(1800000)));
			this.S1_FeedTime.MaximumTag = null;
			this.S1_FeedTime.MinimumTag = null;
			this.S1_FeedTime.Name = "S1_FeedTime";
			this.S1_FeedTime.TagName = "S1_FeedTime";
			this.S1_FeedTime.UseRange = true;
			this.S1_FeedTime.Value = new NxtControl.GuiFramework.Time(((long)(0)));
			this.S1_FeedTime.EndInit();
			// 
			// S2_WaitSludge
			// 
			this.S2_WaitSludge.BeginInit();
			this.S2_WaitSludge.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.58666666666666667D, 0D, 0D, 0.92307692307692313D, 257D, 76D);
			this.S2_WaitSludge.Maximum = new NxtControl.GuiFramework.Time(((long)(1800000)));
			this.S2_WaitSludge.MaximumTag = null;
			this.S2_WaitSludge.MinimumTag = null;
			this.S2_WaitSludge.Name = "S2_WaitSludge";
			this.S2_WaitSludge.TagName = "S2_WaitSludge";
			this.S2_WaitSludge.UseRange = true;
			this.S2_WaitSludge.Value = new NxtControl.GuiFramework.Time(((long)(0)));
			this.S2_WaitSludge.EndInit();
			// 
			// S3_SludgeDischargeTime
			// 
			this.S3_SludgeDischargeTime.BeginInit();
			this.S3_SludgeDischargeTime.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.58666666666666667D, 0D, 0D, 0.92307692307692313D, 256D, 112D);
			this.S3_SludgeDischargeTime.Maximum = new NxtControl.GuiFramework.Time(((long)(1800000)));
			this.S3_SludgeDischargeTime.MaximumTag = null;
			this.S3_SludgeDischargeTime.MinimumTag = null;
			this.S3_SludgeDischargeTime.Name = "S3_SludgeDischargeTime";
			this.S3_SludgeDischargeTime.TagName = "S3_SludgeDischargeTime";
			this.S3_SludgeDischargeTime.UseRange = true;
			this.S3_SludgeDischargeTime.Value = new NxtControl.GuiFramework.Time(((long)(0)));
			this.S3_SludgeDischargeTime.EndInit();
			// 
			// S4_SupernantDischargeTime
			// 
			this.S4_SupernantDischargeTime.BeginInit();
			this.S4_SupernantDischargeTime.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.58666666666666667D, 0D, 0D, 0.92307692307692313D, 256D, 152D);
			this.S4_SupernantDischargeTime.Maximum = new NxtControl.GuiFramework.Time(((long)(1800000)));
			this.S4_SupernantDischargeTime.MaximumTag = null;
			this.S4_SupernantDischargeTime.MinimumTag = null;
			this.S4_SupernantDischargeTime.Name = "S4_SupernantDischargeTime";
			this.S4_SupernantDischargeTime.TagName = "S4_SupernantDischargeTime";
			this.S4_SupernantDischargeTime.UseRange = true;
			this.S4_SupernantDischargeTime.Value = new NxtControl.GuiFramework.Time(((long)(0)));
			this.S4_SupernantDischargeTime.EndInit();
			// 
			// SludgeDischargeCapacity
			// 
			this.SludgeDischargeCapacity.BeginInit();
			this.SludgeDischargeCapacity.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.58666666666666667D, 0D, 0D, 0.92307692307692313D, 256D, 192D);
			this.SludgeDischargeCapacity.MaximumTag = null;
			this.SludgeDischargeCapacity.MinimumTag = null;
			this.SludgeDischargeCapacity.Name = "SludgeDischargeCapacity";
			this.SludgeDischargeCapacity.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.SludgeDischargeCapacity.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.SludgeDischargeCapacity.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.SludgeDischargeCapacity.Suffix = "m³/h";
			this.SludgeDischargeCapacity.TagName = "SludgeDischargeCapacity";
			this.SludgeDischargeCapacity.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.SludgeDischargeCapacity.Value = 0F;
			this.SludgeDischargeCapacity.EndInit();
			// 
			// SupernantDischargeCapacity
			// 
			this.SupernantDischargeCapacity.BeginInit();
			this.SupernantDischargeCapacity.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.58666666666666667D, 0D, 0D, 0.92307692307692313D, 256D, 232D);
			this.SupernantDischargeCapacity.MaximumTag = null;
			this.SupernantDischargeCapacity.MinimumTag = null;
			this.SupernantDischargeCapacity.Name = "SupernantDischargeCapacity";
			this.SupernantDischargeCapacity.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.SupernantDischargeCapacity.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.SupernantDischargeCapacity.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.SupernantDischargeCapacity.Suffix = "m³/h";
			this.SupernantDischargeCapacity.TagName = "SupernantDischargeCapacity";
			this.SupernantDischargeCapacity.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.SupernantDischargeCapacity.Value = 0F;
			this.SupernantDischargeCapacity.EndInit();
			// 
			// Restartlvl
			// 
			this.Restartlvl.BeginInit();
			this.Restartlvl.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.58666666666666667D, 0D, 0D, 1D, 256D, 272D);
			this.Restartlvl.MaximumTag = null;
			this.Restartlvl.MinimumTag = null;
			this.Restartlvl.Name = "Restartlvl";
			this.Restartlvl.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.Restartlvl.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.Restartlvl.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.Restartlvl.TagName = "Restartlvl";
			this.Restartlvl.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.Restartlvl.Value = ((short)(0));
			this.Restartlvl.EndInit();
			// 
			// freeText5
			// 
			this.freeText5.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText5.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.freeText5.Location = new NxtControl.Drawing.PointF(16D, 280D);
			this.freeText5.Name = "freeText5";
			this.freeText5.Text = "Restart Level :";
			// 
			// FB_SBL1
			// 
			this.FB_SBL1.BeginInit();
			this.FB_SBL1.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.58666666666666667D, 0D, 0D, 1D, 256D, 318D);
			this.FB_SBL1.MaximumTag = null;
			this.FB_SBL1.MinimumTag = null;
			this.FB_SBL1.Name = "FB_SBL1";
			this.FB_SBL1.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.FB_SBL1.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.FB_SBL1.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.FB_SBL1.TagName = "FB_SBL1";
			this.FB_SBL1.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.FB_SBL1.Value = 0F;
			this.FB_SBL1.EndInit();
			// 
			// FB_SBL2
			// 
			this.FB_SBL2.BeginInit();
			this.FB_SBL2.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.58666666666666667D, 0D, 0D, 1D, 256D, 361D);
			this.FB_SBL2.MaximumTag = null;
			this.FB_SBL2.MinimumTag = null;
			this.FB_SBL2.Name = "FB_SBL2";
			this.FB_SBL2.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.FB_SBL2.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.FB_SBL2.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.FB_SBL2.TagName = "FB_SBL2";
			this.FB_SBL2.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.FB_SBL2.Value = 0F;
			this.FB_SBL2.EndInit();
			// 
			// freeText6
			// 
			this.freeText6.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText6.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.freeText6.Location = new NxtControl.Drawing.PointF(16D, 320D);
			this.freeText6.Name = "freeText6";
			this.freeText6.Text = "FB SBL1 :";
			// 
			// freeText7
			// 
			this.freeText7.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText7.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.freeText7.Location = new NxtControl.Drawing.PointF(16D, 360D);
			this.freeText7.Name = "freeText7";
			this.freeText7.Text = "FB SBL2 :";
			// 
			// fpSettings
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(392D)), ((float)(528D)));
			this.Brush = new NxtControl.Drawing.Brush("FaceplateBrush");
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.rectangle1,
			this.polygon1,
			this.freeText1,
			this.freeText2,
			this.freeText3,
			this.freeText4,
			this.freeText9,
			this.freeText12,
			this.S1_FeedTime,
			this.S2_WaitSludge,
			this.S3_SludgeDischargeTime,
			this.S4_SupernantDischargeTime,
			this.SludgeDischargeCapacity,
			this.SupernantDischargeCapacity,
			this.Restartlvl,
			this.freeText5,
			this.FB_SBL1,
			this.FB_SBL2,
			this.freeText6,
			this.freeText7});
			this.Size = new System.Drawing.Size(392, 528);

		}
		private NxtControl.GuiFramework.Rectangle rectangle1;
		private NxtControl.GuiFramework.Polygon polygon1;
		private NxtControl.GuiFramework.FreeText freeText1;
		private NxtControl.GuiFramework.FreeText freeText2;
		private NxtControl.GuiFramework.FreeText freeText3;
		private NxtControl.GuiFramework.FreeText freeText4;
		private NxtControl.GuiFramework.FreeText freeText9;
		private NxtControl.GuiFramework.FreeText freeText12;
		private System.HMI.Symbols.Base.TimeTextBox S1_FeedTime;
		private System.HMI.Symbols.Base.TimeTextBox S2_WaitSludge;
		private System.HMI.Symbols.Base.TimeTextBox S3_SludgeDischargeTime;
		private System.HMI.Symbols.Base.TimeTextBox S4_SupernantDischargeTime;
		private System.HMI.Symbols.Base.TextBox<float> SludgeDischargeCapacity;
		private System.HMI.Symbols.Base.TextBox<float> SupernantDischargeCapacity;
		private System.HMI.Symbols.Base.TextBox<short> Restartlvl;
		private NxtControl.GuiFramework.FreeText freeText5;
		private System.HMI.Symbols.Base.TextBox<float> FB_SBL1;
		private System.HMI.Symbols.Base.TextBox<float> FB_SBL2;
		private NxtControl.GuiFramework.FreeText freeText6;
		private NxtControl.GuiFramework.FreeText freeText7;
		#endregion
	}
}
