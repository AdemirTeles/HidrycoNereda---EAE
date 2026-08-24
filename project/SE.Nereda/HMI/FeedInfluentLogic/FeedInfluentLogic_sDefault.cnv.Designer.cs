/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 6/13/2026
 * Time: 7:00 PM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.FeedInfluentLogic
{
	/// <summary>
	/// Summary description for sDefault.
	/// </summary>
	partial class sDefault
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
			this.freeText5 = new NxtControl.GuiFramework.FreeText();
			this.freeText6 = new NxtControl.GuiFramework.FreeText();
			this.freeText7 = new NxtControl.GuiFramework.FreeText();
			this.freeText8 = new NxtControl.GuiFramework.FreeText();
			this.freeText9 = new NxtControl.GuiFramework.FreeText();
			this.freeText10 = new NxtControl.GuiFramework.FreeText();
			this.freeText11 = new NxtControl.GuiFramework.FreeText();
			this.freeText12 = new NxtControl.GuiFramework.FreeText();
			this.freeText13 = new NxtControl.GuiFramework.FreeText();
			this.FreezRunDurSp = new System.HMI.Symbols.Base.TimeTextBox();
			this.FreezStopDurSp = new System.HMI.Symbols.Base.TimeTextBox();
			this.FreezWeatherSp = new System.HMI.Symbols.Base.TextBox<float>();
			this.StartLevelSp = new System.HMI.Symbols.Base.TextBox<float>();
			this.BreakPointSp = new System.HMI.Symbols.Base.TextBox<float>();
			this.StopLevelSp = new System.HMI.Symbols.Base.TextBox<float>();
			this.MaxFlowSp = new System.HMI.Symbols.Base.TextBox<float>();
			this.Status = new NxtControl.GuiFramework.Rectangle();
			this.freeText14 = new NxtControl.GuiFramework.FreeText();
			this.FT95FlowPvWaitTime = new System.HMI.Symbols.Base.TimeTextBox();
			this.ValveControl = new SE.Nereda.Symbols.OpeningValveDurLogic.sDurSetPoint();
			this.freeText15 = new NxtControl.GuiFramework.FreeText();
			this.AutoReset = new SE.Nereda.Symbols.AutoResetCdt.sDefault();
			// 
			// polygon1
			// 
			this.polygon1.Bounds = new NxtControl.Drawing.RectF(((float)(8D)), ((float)(8D)), ((float)(176D)), ((float)(24D)));
			this.polygon1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(78)), ((byte)(78)), ((byte)(78))));
			this.polygon1.Closed = true;
			this.polygon1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular);
			this.polygon1.Name = "polygon1";
			this.polygon1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(78)), ((byte)(78)), ((byte)(78))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.polygon1.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(8D, 32D),
			new NxtControl.Drawing.PointF(8D, 8D),
			new NxtControl.Drawing.PointF(160D, 8D),
			new NxtControl.Drawing.PointF(184D, 32D)});
			this.polygon1.Text = "FEED INFLUENT";
			this.polygon1.TextColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(0)));
			// 
			// rectangle1
			// 
			this.rectangle1.Bounds = new NxtControl.Drawing.RectF(((float)(8D)), ((float)(24D)), ((float)(360D)), ((float)(464D)));
			this.rectangle1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(250)), ((byte)(250)), ((byte)(250))));
			this.rectangle1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle1.Name = "rectangle1";
			// 
			// freeText1
			// 
			this.freeText1.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText1.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.freeText1.Location = new NxtControl.Drawing.PointF(16D, 60D);
			this.freeText1.Name = "freeText1";
			this.freeText1.Text = "Pump Minimum Run Time :";
			// 
			// freeText2
			// 
			this.freeText2.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText2.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.freeText2.Location = new NxtControl.Drawing.PointF(16D, 92D);
			this.freeText2.Name = "freeText2";
			this.freeText2.Text = "Pump Minimum Stop Time :";
			// 
			// freeText3
			// 
			this.freeText3.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText3.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.freeText3.Location = new NxtControl.Drawing.PointF(16D, 124D);
			this.freeText3.Name = "freeText3";
			this.freeText3.Text = "Freeze Protection Temperature :";
			// 
			// freeText4
			// 
			this.freeText4.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(114)), ((byte)(188)));
			this.freeText4.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.freeText4.Location = new NxtControl.Drawing.PointF(16D, 32D);
			this.freeText4.Name = "freeText4";
			this.freeText4.Text = "Freeze Protection Mode : _ _ _ _ _ _ _ _ _ _ _ _ _ _ _";
			// 
			// freeText5
			// 
			this.freeText5.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(114)), ((byte)(188)));
			this.freeText5.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.freeText5.Location = new NxtControl.Drawing.PointF(16D, 152D);
			this.freeText5.Name = "freeText5";
			this.freeText5.Text = "Normal Mode : _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _";
			// 
			// freeText6
			// 
			this.freeText6.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText6.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.freeText6.Location = new NxtControl.Drawing.PointF(16D, 180D);
			this.freeText6.Name = "freeText6";
			this.freeText6.Text = "Start Level Sp :";
			// 
			// freeText7
			// 
			this.freeText7.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText7.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.freeText7.Location = new NxtControl.Drawing.PointF(16D, 240D);
			this.freeText7.Name = "freeText7";
			this.freeText7.Text = "Stop Level Sp :";
			// 
			// freeText8
			// 
			this.freeText8.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText8.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.freeText8.Location = new NxtControl.Drawing.PointF(16D, 214D);
			this.freeText8.Name = "freeText8";
			this.freeText8.Text = "Break Point Level Sp :";
			// 
			// freeText9
			// 
			this.freeText9.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(114)), ((byte)(188)));
			this.freeText9.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.freeText9.Location = new NxtControl.Drawing.PointF(16D, 264D);
			this.freeText9.Name = "freeText9";
			this.freeText9.Text = "_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _";
			// 
			// freeText10
			// 
			this.freeText10.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText10.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.freeText10.Location = new NxtControl.Drawing.PointF(16D, 292D);
			this.freeText10.Name = "freeText10";
			this.freeText10.Text = "Valve 95 003 Opening Time :";
			// 
			// freeText11
			// 
			this.freeText11.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText11.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.freeText11.Location = new NxtControl.Drawing.PointF(16D, 420D);
			this.freeText11.Name = "freeText11";
			this.freeText11.Text = "Control Logic Diagram :";
			// 
			// freeText12
			// 
			this.freeText12.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText12.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.freeText12.Location = new NxtControl.Drawing.PointF(16D, 324D);
			this.freeText12.Name = "freeText12";
			this.freeText12.Text = "Maximum Flow Rate :";
			// 
			// freeText13
			// 
			this.freeText13.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText13.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.freeText13.Location = new NxtControl.Drawing.PointF(16D, 388D);
			this.freeText13.Name = "freeText13";
			this.freeText13.Text = "Logic Status :";
			// 
			// FreezRunDurSp
			// 
			this.FreezRunDurSp.BeginInit();
			this.FreezRunDurSp.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.64000000000000012D, 0D, 0D, 1D, 240D, 56D);
			this.FreezRunDurSp.MaximumTag = null;
			this.FreezRunDurSp.MinimumTag = null;
			this.FreezRunDurSp.Name = "FreezRunDurSp";
			this.FreezRunDurSp.TagName = "FreezRunDurSp";
			this.FreezRunDurSp.TextColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.FreezRunDurSp.TimeFormat = "%d%h%m%s";
			this.FreezRunDurSp.UseInputPad = true;
			this.FreezRunDurSp.Value = new NxtControl.GuiFramework.Time(((long)(0)));
			this.FreezRunDurSp.EndInit();
			// 
			// FreezStopDurSp
			// 
			this.FreezStopDurSp.BeginInit();
			this.FreezStopDurSp.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.64000000000000012D, 0D, 0D, 1D, 240D, 88D);
			this.FreezStopDurSp.MaximumTag = null;
			this.FreezStopDurSp.MinimumTag = null;
			this.FreezStopDurSp.Name = "FreezStopDurSp";
			this.FreezStopDurSp.TagName = "FreezStopDurSp";
			this.FreezStopDurSp.TextColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.FreezStopDurSp.UseInputPad = true;
			this.FreezStopDurSp.Value = new NxtControl.GuiFramework.Time(((long)(0)));
			this.FreezStopDurSp.EndInit();
			// 
			// FreezWeatherSp
			// 
			this.FreezWeatherSp.BeginInit();
			this.FreezWeatherSp.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.64000000000000012D, 0D, 0D, 1D, 240D, 120D);
			this.FreezWeatherSp.MaximumTag = null;
			this.FreezWeatherSp.MinimumTag = null;
			this.FreezWeatherSp.Name = "FreezWeatherSp";
			this.FreezWeatherSp.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.FreezWeatherSp.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Black"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.FreezWeatherSp.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.FreezWeatherSp.Suffix = "°C";
			this.FreezWeatherSp.TagName = "FreezWeatherSp";
			this.FreezWeatherSp.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			this.FreezWeatherSp.TextColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.FreezWeatherSp.UseInputPad = true;
			this.FreezWeatherSp.Value = 0F;
			this.FreezWeatherSp.EndInit();
			// 
			// StartLevelSp
			// 
			this.StartLevelSp.BeginInit();
			this.StartLevelSp.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.64D, 0D, 0D, 1D, 240D, 176D);
			this.StartLevelSp.MaximumTag = null;
			this.StartLevelSp.MinimumTag = null;
			this.StartLevelSp.Name = "StartLevelSp";
			this.StartLevelSp.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.StartLevelSp.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Black"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.StartLevelSp.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.StartLevelSp.Suffix = "m";
			this.StartLevelSp.TagName = "StartLevelSp";
			this.StartLevelSp.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			this.StartLevelSp.TextColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.StartLevelSp.UseInputPad = true;
			this.StartLevelSp.Value = 0F;
			this.StartLevelSp.EndInit();
			// 
			// BreakPointSp
			// 
			this.BreakPointSp.BeginInit();
			this.BreakPointSp.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.64D, 0D, 0D, 1D, 240D, 208D);
			this.BreakPointSp.MaximumTag = null;
			this.BreakPointSp.MinimumTag = null;
			this.BreakPointSp.Name = "BreakPointSp";
			this.BreakPointSp.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.BreakPointSp.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Black"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.BreakPointSp.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.BreakPointSp.Suffix = "m";
			this.BreakPointSp.TagName = "BreakPointSp";
			this.BreakPointSp.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			this.BreakPointSp.TextColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.BreakPointSp.UseInputPad = true;
			this.BreakPointSp.Value = 0F;
			this.BreakPointSp.EndInit();
			// 
			// StopLevelSp
			// 
			this.StopLevelSp.BeginInit();
			this.StopLevelSp.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.64D, 0D, 0D, 1D, 240D, 240D);
			this.StopLevelSp.MaximumTag = null;
			this.StopLevelSp.MinimumTag = null;
			this.StopLevelSp.Name = "StopLevelSp";
			this.StopLevelSp.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.StopLevelSp.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Black"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.StopLevelSp.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.StopLevelSp.Suffix = "m";
			this.StopLevelSp.TagName = "StopLevelSp";
			this.StopLevelSp.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			this.StopLevelSp.TextColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.StopLevelSp.UseInputPad = true;
			this.StopLevelSp.Value = 0F;
			this.StopLevelSp.EndInit();
			// 
			// MaxFlowSp
			// 
			this.MaxFlowSp.BeginInit();
			this.MaxFlowSp.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.64D, 0D, 0D, 1D, 240D, 320D);
			this.MaxFlowSp.MaximumTag = null;
			this.MaxFlowSp.MinimumTag = null;
			this.MaxFlowSp.Name = "MaxFlowSp";
			this.MaxFlowSp.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.MaxFlowSp.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Black"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.MaxFlowSp.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.MaxFlowSp.Suffix = "m³/h";
			this.MaxFlowSp.TagName = "MaxFlowSp";
			this.MaxFlowSp.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			this.MaxFlowSp.TextColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.MaxFlowSp.UseInputPad = true;
			this.MaxFlowSp.Value = 0F;
			this.MaxFlowSp.EndInit();
			// 
			// Status
			// 
			this.Status.Bounds = new NxtControl.Drawing.RectF(((float)(120D)), ((float)(384D)), ((float)(216D)), ((float)(24D)));
			this.Status.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("transparent"));
			this.Status.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.Status.Name = "Status";
			this.Status.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.Status.Text = "#### Status ####";
			this.Status.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			// 
			// freeText14
			// 
			this.freeText14.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText14.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.freeText14.Location = new NxtControl.Drawing.PointF(16D, 356D);
			this.freeText14.Name = "freeText14";
			this.freeText14.Text = "FT95 Flow PV Waiting Time :";
			// 
			// FT95FlowPvWaitTime
			// 
			this.FT95FlowPvWaitTime.BeginInit();
			this.FT95FlowPvWaitTime.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.64D, 0D, 0D, 1D, 240D, 352D);
			this.FT95FlowPvWaitTime.MaximumTag = null;
			this.FT95FlowPvWaitTime.MinimumTag = null;
			this.FT95FlowPvWaitTime.Name = "FT95FlowPvWaitTime";
			this.FT95FlowPvWaitTime.TagName = "FT95FlowPvWaitTime";
			this.FT95FlowPvWaitTime.TextColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.FT95FlowPvWaitTime.UseInputPad = true;
			this.FT95FlowPvWaitTime.Value = new NxtControl.GuiFramework.Time(((long)(0)));
			this.FT95FlowPvWaitTime.EndInit();
			// 
			// ValveControl
			// 
			this.ValveControl.BeginInit();
			this.ValveControl.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 240D, 288D);
			this.ValveControl.Name = "ValveControl";
			this.ValveControl.SecurityToken = ((uint)(4294967295u));
			this.ValveControl.TagName = "ValveControl";
			this.ValveControl.EndInit();
			// 
			// freeText15
			// 
			this.freeText15.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText15.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.freeText15.Location = new NxtControl.Drawing.PointF(16D, 452D);
			this.freeText15.Name = "freeText15";
			this.freeText15.Text = "Auto Reset Settings :";
			// 
			// AutoReset
			// 
			this.AutoReset.BeginInit();
			this.AutoReset.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 240D, 448D);
			this.AutoReset.Name = "AutoReset";
			this.AutoReset.SecurityToken = ((uint)(4294967295u));
			this.AutoReset.TagName = "AutoReset";
			this.AutoReset.EndInit();
			// 
			// sDefault
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.polygon1,
			this.rectangle1,
			this.freeText1,
			this.freeText2,
			this.freeText3,
			this.freeText4,
			this.freeText5,
			this.freeText6,
			this.freeText7,
			this.freeText8,
			this.freeText9,
			this.freeText10,
			this.freeText11,
			this.freeText12,
			this.freeText13,
			this.FreezRunDurSp,
			this.FreezStopDurSp,
			this.FreezWeatherSp,
			this.StartLevelSp,
			this.BreakPointSp,
			this.StopLevelSp,
			this.MaxFlowSp,
			this.Status,
			this.freeText14,
			this.FT95FlowPvWaitTime,
			this.ValveControl,
			this.freeText15,
			this.AutoReset});
			this.SymbolSize = new System.Drawing.Size(400, 552);

		}
		private NxtControl.GuiFramework.Polygon polygon1;
		private NxtControl.GuiFramework.Rectangle rectangle1;
		private NxtControl.GuiFramework.FreeText freeText1;
		private NxtControl.GuiFramework.FreeText freeText2;
		private NxtControl.GuiFramework.FreeText freeText3;
		private NxtControl.GuiFramework.FreeText freeText4;
		private NxtControl.GuiFramework.FreeText freeText5;
		private NxtControl.GuiFramework.FreeText freeText6;
		private NxtControl.GuiFramework.FreeText freeText7;
		private NxtControl.GuiFramework.FreeText freeText8;
		private NxtControl.GuiFramework.FreeText freeText9;
		private NxtControl.GuiFramework.FreeText freeText10;
		private NxtControl.GuiFramework.FreeText freeText11;
		private NxtControl.GuiFramework.FreeText freeText12;
		private NxtControl.GuiFramework.FreeText freeText13;
		private System.HMI.Symbols.Base.TimeTextBox FreezRunDurSp;
		private System.HMI.Symbols.Base.TimeTextBox FreezStopDurSp;
		private System.HMI.Symbols.Base.TextBox<float> FreezWeatherSp;
		private System.HMI.Symbols.Base.TextBox<float> StartLevelSp;
		private System.HMI.Symbols.Base.TextBox<float> BreakPointSp;
		private System.HMI.Symbols.Base.TextBox<float> StopLevelSp;
		private System.HMI.Symbols.Base.TextBox<float> MaxFlowSp;
		private NxtControl.GuiFramework.Rectangle Status;
		private NxtControl.GuiFramework.FreeText freeText14;
		private System.HMI.Symbols.Base.TimeTextBox FT95FlowPvWaitTime;
		private SE.Nereda.Symbols.OpeningValveDurLogic.sDurSetPoint ValveControl;
		private NxtControl.GuiFramework.FreeText freeText15;
		private SE.Nereda.Symbols.AutoResetCdt.sDefault AutoReset;
		#endregion
	}
}
