/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 7/5/2026
 * Time: 1:58 AM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using NxtControl.GuiFramework;

namespace SE.Nereda.Faceplates.EmergencyReactor_2
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
			this.polygon1 = new NxtControl.GuiFramework.Polygon();
			this.rectangle1 = new NxtControl.GuiFramework.Rectangle();
			this.freeText1 = new NxtControl.GuiFramework.FreeText();
			this.freeText2 = new NxtControl.GuiFramework.FreeText();
			this.freeText3 = new NxtControl.GuiFramework.FreeText();
			this.freeText4 = new NxtControl.GuiFramework.FreeText();
			this.S1_FeedTime = new System.HMI.Symbols.Base.TimeTextBox();
			this.S2_VentSludge = new System.HMI.Symbols.Base.TimeTextBox();
			this.S3_SludgeDischargeTime = new System.HMI.Symbols.Base.TimeTextBox();
			this.S4_LowerLevelTime = new System.HMI.Symbols.Base.TimeTextBox();
			this.S6_VentAerateTime = new System.HMI.Symbols.Base.TimeTextBox();
			this.S7_WaitTime = new System.HMI.Symbols.Base.TimeTextBox();
			this.S8_VentSludgeTime = new System.HMI.Symbols.Base.TimeTextBox();
			this.freeText5 = new NxtControl.GuiFramework.FreeText();
			this.freeText6 = new NxtControl.GuiFramework.FreeText();
			this.freeText7 = new NxtControl.GuiFramework.FreeText();
			this.S5_AerateTime = new System.HMI.Symbols.Base.TimeTextBox();
			this.freeText8 = new NxtControl.GuiFramework.FreeText();
			this.FeedCapacity = new System.HMI.Symbols.Base.TextBox<float>();
			this.freeText9 = new NxtControl.GuiFramework.FreeText();
			this.freeText12 = new NxtControl.GuiFramework.FreeText();
			this.AerationCapacity = new System.HMI.Symbols.Base.TextBox<float>();
			this.AirVentGrid = new System.HMI.Symbols.Base.SwitchButton();
			this.AirLockTime = new System.HMI.Symbols.Base.TimeTextBox();
			this.freeText13 = new NxtControl.GuiFramework.FreeText();
			this.freeText15 = new NxtControl.GuiFramework.FreeText();
			this.rectangle2 = new NxtControl.GuiFramework.Rectangle();
			this.rectangle3 = new NxtControl.GuiFramework.Rectangle();
			this.S9_SludgeDischargeTime = new System.HMI.Symbols.Base.TimeTextBox();
			this.freeText16 = new NxtControl.GuiFramework.FreeText();
			this.timeTextBox1 = new System.HMI.Symbols.Base.TimeTextBox();
			this.freeText10 = new NxtControl.GuiFramework.FreeText();
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
			// rectangle1
			// 
			this.rectangle1.Bounds = new NxtControl.Drawing.RectF(((float)(-144D)), ((float)(-72D)), ((float)(528D)), ((float)(664D)));
			this.rectangle1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(250)), ((byte)(250)), ((byte)(250))));
			this.rectangle1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle1.Name = "rectangle1";
			// 
			// freeText1
			// 
			this.freeText1.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText1.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.freeText1.Location = new NxtControl.Drawing.PointF(16D, 36D);
			this.freeText1.Name = "freeText1";
			this.freeText1.Text = "Step 1 - Feed Time :";
			// 
			// freeText2
			// 
			this.freeText2.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText2.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.freeText2.Location = new NxtControl.Drawing.PointF(16D, 68D);
			this.freeText2.Name = "freeText2";
			this.freeText2.Text = "Step 2 - Vent Sludge Time:";
			// 
			// freeText3
			// 
			this.freeText3.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText3.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.freeText3.Location = new NxtControl.Drawing.PointF(16D, 100D);
			this.freeText3.Name = "freeText3";
			this.freeText3.Text = "Step 3 - Sludge Discharge Time :";
			// 
			// freeText4
			// 
			this.freeText4.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText4.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.freeText4.Location = new NxtControl.Drawing.PointF(16D, 132D);
			this.freeText4.Name = "freeText4";
			this.freeText4.Text = "Step 4 - Lower Level Time :";
			// 
			// S1_FeedTime
			// 
			this.S1_FeedTime.BeginInit();
			this.S1_FeedTime.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.64D, 0D, 0D, 1.0384615384615385D, 248D, 32D);
			this.S1_FeedTime.MaximumTag = null;
			this.S1_FeedTime.MinimumTag = null;
			this.S1_FeedTime.Name = "S1_FeedTime";
			this.S1_FeedTime.TagName = "S1_FeedTime";
			this.S1_FeedTime.TextColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.S1_FeedTime.UseInputPad = true;
			this.S1_FeedTime.Value = new NxtControl.GuiFramework.Time(((long)(0)));
			this.S1_FeedTime.EndInit();
			// 
			// S2_VentSludge
			// 
			this.S2_VentSludge.BeginInit();
			this.S2_VentSludge.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.64D, 0D, 0D, 1D, 248D, 64D);
			this.S2_VentSludge.MaximumTag = null;
			this.S2_VentSludge.MinimumTag = null;
			this.S2_VentSludge.Name = "S2_VentSludge";
			this.S2_VentSludge.TagName = "S2_VentSludge";
			this.S2_VentSludge.TextColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.S2_VentSludge.UseInputPad = true;
			this.S2_VentSludge.Value = new NxtControl.GuiFramework.Time(((long)(0)));
			this.S2_VentSludge.EndInit();
			// 
			// S3_SludgeDischargeTime
			// 
			this.S3_SludgeDischargeTime.BeginInit();
			this.S3_SludgeDischargeTime.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.64D, 0D, 0D, 1D, 248D, 96D);
			this.S3_SludgeDischargeTime.MaximumTag = null;
			this.S3_SludgeDischargeTime.MinimumTag = null;
			this.S3_SludgeDischargeTime.Name = "S3_SludgeDischargeTime";
			this.S3_SludgeDischargeTime.TagName = "S3_SludgeDischargeTime";
			this.S3_SludgeDischargeTime.TextColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.S3_SludgeDischargeTime.UseInputPad = true;
			this.S3_SludgeDischargeTime.Value = new NxtControl.GuiFramework.Time(((long)(0)));
			this.S3_SludgeDischargeTime.EndInit();
			// 
			// S4_LowerLevelTime
			// 
			this.S4_LowerLevelTime.BeginInit();
			this.S4_LowerLevelTime.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.64D, 0D, 0D, 1D, 248D, 128D);
			this.S4_LowerLevelTime.MaximumTag = null;
			this.S4_LowerLevelTime.MinimumTag = null;
			this.S4_LowerLevelTime.Name = "S4_LowerLevelTime";
			this.S4_LowerLevelTime.TagName = "S4_LowerLevelTime";
			this.S4_LowerLevelTime.TextColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.S4_LowerLevelTime.UseInputPad = true;
			this.S4_LowerLevelTime.Value = new NxtControl.GuiFramework.Time(((long)(0)));
			this.S4_LowerLevelTime.EndInit();
			// 
			// S6_VentAerateTime
			// 
			this.S6_VentAerateTime.BeginInit();
			this.S6_VentAerateTime.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.64D, 0D, 0D, 1D, 248D, 192D);
			this.S6_VentAerateTime.MaximumTag = null;
			this.S6_VentAerateTime.MinimumTag = null;
			this.S6_VentAerateTime.Name = "S6_VentAerateTime";
			this.S6_VentAerateTime.TagName = "S6_VentAerateTime";
			this.S6_VentAerateTime.TextColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.S6_VentAerateTime.UseInputPad = true;
			this.S6_VentAerateTime.Value = new NxtControl.GuiFramework.Time(((long)(0)));
			this.S6_VentAerateTime.EndInit();
			// 
			// S7_WaitTime
			// 
			this.S7_WaitTime.BeginInit();
			this.S7_WaitTime.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.64D, 0D, 0D, 1D, 248D, 224D);
			this.S7_WaitTime.MaximumTag = null;
			this.S7_WaitTime.MinimumTag = null;
			this.S7_WaitTime.Name = "S7_WaitTime";
			this.S7_WaitTime.TagName = "S7_WaitTime";
			this.S7_WaitTime.TextColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.S7_WaitTime.UseInputPad = true;
			this.S7_WaitTime.Value = new NxtControl.GuiFramework.Time(((long)(0)));
			this.S7_WaitTime.EndInit();
			// 
			// S8_VentSludgeTime
			// 
			this.S8_VentSludgeTime.BeginInit();
			this.S8_VentSludgeTime.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.64D, 0D, 0D, 1D, 248D, 256D);
			this.S8_VentSludgeTime.MaximumTag = null;
			this.S8_VentSludgeTime.MinimumTag = null;
			this.S8_VentSludgeTime.Name = "S8_VentSludgeTime";
			this.S8_VentSludgeTime.TagName = "S8_VentSludgeTime";
			this.S8_VentSludgeTime.TextColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.S8_VentSludgeTime.UseInputPad = true;
			this.S8_VentSludgeTime.Value = new NxtControl.GuiFramework.Time(((long)(0)));
			this.S8_VentSludgeTime.EndInit();
			// 
			// freeText5
			// 
			this.freeText5.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText5.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.freeText5.Location = new NxtControl.Drawing.PointF(16D, 196D);
			this.freeText5.Name = "freeText5";
			this.freeText5.Text = "Step 6 - Vent Aerate Time :";
			// 
			// freeText6
			// 
			this.freeText6.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText6.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.freeText6.Location = new NxtControl.Drawing.PointF(16D, 228D);
			this.freeText6.Name = "freeText6";
			this.freeText6.Text = "Step 7 - Wait Time :";
			// 
			// freeText7
			// 
			this.freeText7.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText7.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.freeText7.Location = new NxtControl.Drawing.PointF(16D, 260D);
			this.freeText7.Name = "freeText7";
			this.freeText7.Text = "Step 8 - Vent Sludge Time :";
			// 
			// S5_AerateTime
			// 
			this.S5_AerateTime.BeginInit();
			this.S5_AerateTime.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.64D, 0D, 0D, 1D, 248D, 160D);
			this.S5_AerateTime.IsOnlyInput = true;
			this.S5_AerateTime.MaximumTag = null;
			this.S5_AerateTime.MinimumTag = null;
			this.S5_AerateTime.Name = "S5_AerateTime";
			this.S5_AerateTime.TagName = "S5_AerateTime";
			this.S5_AerateTime.TextColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.S5_AerateTime.UseInputPad = true;
			this.S5_AerateTime.Value = new NxtControl.GuiFramework.Time(((long)(0)));
			this.S5_AerateTime.EndInit();
			// 
			// freeText8
			// 
			this.freeText8.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText8.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.freeText8.Location = new NxtControl.Drawing.PointF(16D, 164D);
			this.freeText8.Name = "freeText8";
			this.freeText8.Text = "Step 5 - Aerate Time :";
			// 
			// FeedCapacity
			// 
			this.FeedCapacity.BeginInit();
			this.FeedCapacity.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.64D, 0D, 0D, 1D, 248D, 384D);
			this.FeedCapacity.MaximumTag = null;
			this.FeedCapacity.MinimumTag = null;
			this.FeedCapacity.Name = "FeedCapacity";
			this.FeedCapacity.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.FeedCapacity.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Black"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.FeedCapacity.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.FeedCapacity.Suffix = "m³/h";
			this.FeedCapacity.TagName = "FeedCapacity";
			this.FeedCapacity.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			this.FeedCapacity.TextColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.FeedCapacity.UseInputPad = true;
			this.FeedCapacity.Value = 0F;
			this.FeedCapacity.EndInit();
			// 
			// freeText9
			// 
			this.freeText9.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText9.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.freeText9.Location = new NxtControl.Drawing.PointF(16D, 424D);
			this.freeText9.Name = "freeText9";
			this.freeText9.Text = "Aeration Capacity :";
			// 
			// freeText12
			// 
			this.freeText12.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText12.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.freeText12.Location = new NxtControl.Drawing.PointF(16D, 392D);
			this.freeText12.Name = "freeText12";
			this.freeText12.Text = "Feed Capacity :";
			// 
			// AerationCapacity
			// 
			this.AerationCapacity.BeginInit();
			this.AerationCapacity.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.64D, 0D, 0D, 1D, 248D, 416D);
			this.AerationCapacity.MaximumTag = null;
			this.AerationCapacity.MinimumTag = null;
			this.AerationCapacity.Name = "AerationCapacity";
			this.AerationCapacity.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.AerationCapacity.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Black"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.AerationCapacity.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.AerationCapacity.Suffix = "%";
			this.AerationCapacity.TagName = "AerationCapacity";
			this.AerationCapacity.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			this.AerationCapacity.TextColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.AerationCapacity.UseInputPad = true;
			this.AerationCapacity.Value = 0F;
			this.AerationCapacity.EndInit();
			// 
			// AirVentGrid
			// 
			this.AirVentGrid.BeginInit();
			this.AirVentGrid.DesignMatrix = new NxtControl.Drawing.Matrix2D(1.1999999999999995D, 0D, 0D, 0.8666666666666667D, 248D, 448D);
			this.AirVentGrid.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.AirVentGrid.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.AirVentGrid.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.AirVentGrid.Name = "AirVentGrid";
			this.AirVentGrid.TagName = "AirVentGrid";
			this.AirVentGrid.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.AirVentGrid.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.AirVentGrid.Value = false;
			this.AirVentGrid.EndInit();
			// 
			// AirLockTime
			// 
			this.AirLockTime.BeginInit();
			this.AirLockTime.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.64D, 0D, 0D, 1D, 248D, 512D);
			this.AirLockTime.MaximumTag = null;
			this.AirLockTime.MinimumTag = null;
			this.AirLockTime.Name = "AirLockTime";
			this.AirLockTime.TagName = "AirLockTime";
			this.AirLockTime.Value = new NxtControl.GuiFramework.Time(((long)(0)));
			this.AirLockTime.EndInit();
			// 
			// freeText13
			// 
			this.freeText13.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText13.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.freeText13.Location = new NxtControl.Drawing.PointF(16D, 452D);
			this.freeText13.Name = "freeText13";
			this.freeText13.Text = "Vent Phase - Vent Air Grid :";
			// 
			// freeText15
			// 
			this.freeText15.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText15.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.freeText15.Location = new NxtControl.Drawing.PointF(16D, 516D);
			this.freeText15.Name = "freeText15";
			this.freeText15.Text = "Air Lock Time :";
			// 
			// rectangle2
			// 
			this.rectangle2.Bounds = new NxtControl.Drawing.RectF(((float)(9D)), ((float)(160D)), ((float)(374D)), ((float)(26D)));
			this.rectangle2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(210)), ((byte)(210)), ((byte)(210))));
			this.rectangle2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle2.Name = "rectangle2";
			this.rectangle2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// rectangle3
			// 
			this.rectangle3.Bounds = new NxtControl.Drawing.RectF(((float)(248D)), ((float)(160D)), ((float)(96D)), ((float)(26D)));
			this.rectangle3.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("transparent"));
			this.rectangle3.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle3.Name = "rectangle3";
			// 
			// S9_SludgeDischargeTime
			// 
			this.S9_SludgeDischargeTime.BeginInit();
			this.S9_SludgeDischargeTime.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.64D, 0D, 0D, 1D, 248D, 288D);
			this.S9_SludgeDischargeTime.MaximumTag = null;
			this.S9_SludgeDischargeTime.MinimumTag = null;
			this.S9_SludgeDischargeTime.Name = "S9_SludgeDischargeTime";
			this.S9_SludgeDischargeTime.TagName = "S9_SludgeDischargeTime";
			this.S9_SludgeDischargeTime.TextColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.S9_SludgeDischargeTime.UseInputPad = true;
			this.S9_SludgeDischargeTime.Value = new NxtControl.GuiFramework.Time(((long)(0)));
			this.S9_SludgeDischargeTime.EndInit();
			// 
			// freeText16
			// 
			this.freeText16.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText16.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.freeText16.Location = new NxtControl.Drawing.PointF(16D, 292D);
			this.freeText16.Name = "freeText16";
			this.freeText16.Text = "Step 9 - Sludge Discharge Time :";
			// 
			// timeTextBox1
			// 
			this.timeTextBox1.BeginInit();
			this.timeTextBox1.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.64D, 0D, 0D, 1D, 248D, 320D);
			this.timeTextBox1.MaximumTag = null;
			this.timeTextBox1.MinimumTag = null;
			this.timeTextBox1.Name = "timeTextBox1";
			this.timeTextBox1.TagName = "S10_WaitTime";
			this.timeTextBox1.TextColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.timeTextBox1.UseInputPad = true;
			this.timeTextBox1.Value = new NxtControl.GuiFramework.Time(((long)(0)));
			this.timeTextBox1.EndInit();
			// 
			// freeText10
			// 
			this.freeText10.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText10.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.freeText10.Location = new NxtControl.Drawing.PointF(16D, 324D);
			this.freeText10.Name = "freeText10";
			this.freeText10.Text = "Step10 - Wait Time :";
			// 
			// fpSettings
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(392D)), ((float)(600D)));
			this.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(154)), ((byte)(154)), ((byte)(154))));
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.polygon1,
			this.rectangle1,
			this.rectangle2,
			this.freeText1,
			this.freeText2,
			this.freeText3,
			this.freeText4,
			this.S1_FeedTime,
			this.S2_VentSludge,
			this.S3_SludgeDischargeTime,
			this.S4_LowerLevelTime,
			this.S6_VentAerateTime,
			this.S7_WaitTime,
			this.S8_VentSludgeTime,
			this.freeText5,
			this.freeText6,
			this.freeText7,
			this.S5_AerateTime,
			this.freeText8,
			this.FeedCapacity,
			this.freeText9,
			this.freeText12,
			this.AerationCapacity,
			this.AirVentGrid,
			this.AirLockTime,
			this.freeText13,
			this.freeText15,
			this.rectangle3,
			this.S9_SludgeDischargeTime,
			this.freeText16,
			this.timeTextBox1,
			this.freeText10});
			this.Size = new System.Drawing.Size(392, 600);
			this.Title = "EMERGENCY RECIPE  -  SETTINGS";

		}
		private NxtControl.GuiFramework.Polygon polygon1;
		private NxtControl.GuiFramework.Rectangle rectangle1;
		private NxtControl.GuiFramework.FreeText freeText1;
		private NxtControl.GuiFramework.FreeText freeText2;
		private NxtControl.GuiFramework.FreeText freeText3;
		private NxtControl.GuiFramework.FreeText freeText4;
		private System.HMI.Symbols.Base.TimeTextBox S1_FeedTime;
		private System.HMI.Symbols.Base.TimeTextBox S2_VentSludge;
		private System.HMI.Symbols.Base.TimeTextBox S3_SludgeDischargeTime;
		private System.HMI.Symbols.Base.TimeTextBox S4_LowerLevelTime;
		private System.HMI.Symbols.Base.TimeTextBox S6_VentAerateTime;
		private System.HMI.Symbols.Base.TimeTextBox S7_WaitTime;
		private System.HMI.Symbols.Base.TimeTextBox S8_VentSludgeTime;
		private NxtControl.GuiFramework.FreeText freeText5;
		private NxtControl.GuiFramework.FreeText freeText6;
		private NxtControl.GuiFramework.FreeText freeText7;
		private System.HMI.Symbols.Base.TimeTextBox S5_AerateTime;
		private NxtControl.GuiFramework.FreeText freeText8;
		private System.HMI.Symbols.Base.TextBox<float> FeedCapacity;
		private NxtControl.GuiFramework.FreeText freeText9;
		private NxtControl.GuiFramework.FreeText freeText12;
		private System.HMI.Symbols.Base.TextBox<float> AerationCapacity;
		private System.HMI.Symbols.Base.SwitchButton AirVentGrid;
		private System.HMI.Symbols.Base.TimeTextBox AirLockTime;
		private NxtControl.GuiFramework.FreeText freeText13;
		private NxtControl.GuiFramework.FreeText freeText15;
		private NxtControl.GuiFramework.Rectangle rectangle2;
		private NxtControl.GuiFramework.Rectangle rectangle3;
		private System.HMI.Symbols.Base.TimeTextBox S9_SludgeDischargeTime;
		private NxtControl.GuiFramework.FreeText freeText16;
		private System.HMI.Symbols.Base.TimeTextBox timeTextBox1;
		private NxtControl.GuiFramework.FreeText freeText10;
		#endregion
	}
}
