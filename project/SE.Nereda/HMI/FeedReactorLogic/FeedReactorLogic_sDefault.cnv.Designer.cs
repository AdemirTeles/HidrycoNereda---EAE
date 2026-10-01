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

namespace SE.Nereda.Symbols.FeedReactorLogic
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
			this.rowCmax = new NxtControl.GuiFramework.Rectangle();
			this.txtCmax = new NxtControl.GuiFramework.FreeText();
			this.MaxCapacityOnePump = new System.HMI.Symbols.Base.TextBox<float>();
			this.rowC2 = new NxtControl.GuiFramework.Rectangle();
			this.txtC2 = new NxtControl.GuiFramework.FreeText();
			this.C2Capacity = new System.HMI.Symbols.Base.TextBox<float>();
			this.rowC3 = new NxtControl.GuiFramework.Rectangle();
			this.txtC3 = new NxtControl.GuiFramework.FreeText();
			this.textBox_11 = new System.HMI.Symbols.Base.TextBox<float>();
			this.rowCmin = new NxtControl.GuiFramework.Rectangle();
			this.txtCmin = new NxtControl.GuiFramework.FreeText();
			this.Cmin = new System.HMI.Symbols.Base.TextBox<float>();
			this.rowTC2 = new NxtControl.GuiFramework.Rectangle();
			this.txtTC2 = new NxtControl.GuiFramework.FreeText();
			this.T_C2 = new System.HMI.Symbols.Base.TimeTextBox();
			this.rowTC3 = new NxtControl.GuiFramework.Rectangle();
			this.txtTC3 = new NxtControl.GuiFramework.FreeText();
			this.T_C3 = new System.HMI.Symbols.Base.TimeTextBox();
			this.rowRest = new NxtControl.GuiFramework.Rectangle();
			this.txtRest = new NxtControl.GuiFramework.FreeText();
			this.RestartWaitingTime = new System.HMI.Symbols.Base.TimeTextBox();
			this.rowFLL = new NxtControl.GuiFramework.Rectangle();
			this.txtFLL = new NxtControl.GuiFramework.FreeText();
			this.T_FlowLL = new System.HMI.Symbols.Base.TimeTextBox();
			this.rowCap = new NxtControl.GuiFramework.Rectangle();
			this.txtCap = new NxtControl.GuiFramework.FreeText();
			this.FlowCapTheo = new System.HMI.Symbols.Base.TextBox<float>();
			this.rectBg = new NxtControl.GuiFramework.Rectangle();
			this.polyTitle = new NxtControl.GuiFramework.Polygon();
			this.txtState = new NxtControl.GuiFramework.FreeText();
			this.txtPumps = new NxtControl.GuiFramework.FreeText();
			this.txtSpeed = new NxtControl.GuiFramework.FreeText();
			this.txtMode = new NxtControl.GuiFramework.FreeText();
			this.txtWarn1 = new NxtControl.GuiFramework.FreeText();
			this.txtWarn2 = new NxtControl.GuiFramework.FreeText();
			this.rectBarFrame = new NxtControl.GuiFramework.Rectangle();
			this.rectBarFill = new NxtControl.GuiFramework.Rectangle();
			this.txt100 = new NxtControl.GuiFramework.FreeText();
			this.txt0 = new NxtControl.GuiFramework.FreeText();
			this.mkCmin = new NxtControl.GuiFramework.Polygon();
			this.lbCmin = new NxtControl.GuiFramework.FreeText();
			this.mkC3 = new NxtControl.GuiFramework.Polygon();
			this.lbC3 = new NxtControl.GuiFramework.FreeText();
			this.mkC2 = new NxtControl.GuiFramework.Polygon();
			this.lbC2 = new NxtControl.GuiFramework.FreeText();
			this.mkCmax = new NxtControl.GuiFramework.Polygon();
			this.lbCmax = new NxtControl.GuiFramework.FreeText();
			// 
			// polygon1
			// 
			this.polygon1.Bounds = new NxtControl.Drawing.RectF(((float)(8D)), ((float)(16D)), ((float)(176D)), ((float)(24D)));
			this.polygon1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(78)), ((byte)(78)), ((byte)(78))));
			this.polygon1.Closed = true;
			this.polygon1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular);
			this.polygon1.Name = "polygon1";
			this.polygon1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(78)), ((byte)(78)), ((byte)(78))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.polygon1.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(8D, 40D),
			new NxtControl.Drawing.PointF(8D, 16D),
			new NxtControl.Drawing.PointF(160D, 16D),
			new NxtControl.Drawing.PointF(184D, 40D)});
			this.polygon1.Text = "FEED REACTOR";
			this.polygon1.TextColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(0)));
			// 
			// rowCmax
			// 
			this.rowCmax.Bounds = new NxtControl.Drawing.RectF(((float)(8D)), ((float)(32D)), ((float)(376D)), ((float)(40D)));
			this.rowCmax.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(250)), ((byte)(250)), ((byte)(250))));
			this.rowCmax.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rowCmax.Name = "rowCmax";
			// 
			// txtCmax
			// 
			this.txtCmax.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.txtCmax.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.txtCmax.Location = new NxtControl.Drawing.PointF(16D, 44D);
			this.txtCmax.Name = "txtCmax";
			this.txtCmax.Text = "Max Speed 1 Pump (Cmax) :";
			// 
			// MaxCapacityOnePump
			// 
			this.MaxCapacityOnePump.BeginInit();
			this.MaxCapacityOnePump.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.48D, 0D, 0D, 1D, 272D, 40D);
			this.MaxCapacityOnePump.MaximumTag = null;
			this.MaxCapacityOnePump.MinimumTag = null;
			this.MaxCapacityOnePump.Name = "MaxCapacityOnePump";
			this.MaxCapacityOnePump.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.MaxCapacityOnePump.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Black"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.MaxCapacityOnePump.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.MaxCapacityOnePump.Suffix = "%";
			this.MaxCapacityOnePump.TagName = "MaxCapacityOnePump";
			this.MaxCapacityOnePump.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			this.MaxCapacityOnePump.TextColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.MaxCapacityOnePump.Value = 0F;
			this.MaxCapacityOnePump.EndInit();
			// 
			// rowC2
			// 
			this.rowC2.Bounds = new NxtControl.Drawing.RectF(((float)(8D)), ((float)(72D)), ((float)(376D)), ((float)(40D)));
			this.rowC2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(250)), ((byte)(250)), ((byte)(250))));
			this.rowC2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rowC2.Name = "rowC2";
			// 
			// txtC2
			// 
			this.txtC2.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.txtC2.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.txtC2.Location = new NxtControl.Drawing.PointF(16D, 84D);
			this.txtC2.Name = "txtC2";
			this.txtC2.Text = "2nd Pump Start Speed (C2) :";
			// 
			// C2Capacity
			// 
			this.C2Capacity.BeginInit();
			this.C2Capacity.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.48D, 0D, 0D, 1D, 272D, 80D);
			this.C2Capacity.MaximumTag = null;
			this.C2Capacity.MinimumTag = null;
			this.C2Capacity.Name = "C2Capacity";
			this.C2Capacity.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.C2Capacity.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Black"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.C2Capacity.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.C2Capacity.Suffix = "%";
			this.C2Capacity.TagName = "C2Capacity";
			this.C2Capacity.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			this.C2Capacity.TextColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.C2Capacity.Value = 0F;
			this.C2Capacity.EndInit();
			// 
			// rowC3
			// 
			this.rowC3.Bounds = new NxtControl.Drawing.RectF(((float)(8D)), ((float)(112D)), ((float)(376D)), ((float)(40D)));
			this.rowC3.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(250)), ((byte)(250)), ((byte)(250))));
			this.rowC3.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rowC3.Name = "rowC3";
			// 
			// txtC3
			// 
			this.txtC3.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.txtC3.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.txtC3.Location = new NxtControl.Drawing.PointF(16D, 124D);
			this.txtC3.Name = "txtC3";
			this.txtC3.Text = "2nd Pump Stop Speed (C3) :";
			// 
			// textBox_11
			// 
			this.textBox_11.BeginInit();
			this.textBox_11.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.48D, 0D, 0D, 1D, 272D, 120D);
			this.textBox_11.MaximumTag = null;
			this.textBox_11.MinimumTag = null;
			this.textBox_11.Name = "textBox_11";
			this.textBox_11.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.textBox_11.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Black"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.textBox_11.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.textBox_11.Suffix = "%";
			this.textBox_11.TagName = "C3Capacity";
			this.textBox_11.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			this.textBox_11.TextColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.textBox_11.Value = 0F;
			this.textBox_11.EndInit();
			// 
			// rowCmin
			// 
			this.rowCmin.Bounds = new NxtControl.Drawing.RectF(((float)(8D)), ((float)(152D)), ((float)(376D)), ((float)(40D)));
			this.rowCmin.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(250)), ((byte)(250)), ((byte)(250))));
			this.rowCmin.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rowCmin.Name = "rowCmin";
			// 
			// txtCmin
			// 
			this.txtCmin.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.txtCmin.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.txtCmin.Location = new NxtControl.Drawing.PointF(16D, 164D);
			this.txtCmin.Name = "txtCmin";
			this.txtCmin.Text = "Min. Pump Speed (Cmin) :";
			// 
			// Cmin
			// 
			this.Cmin.BeginInit();
			this.Cmin.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.48D, 0D, 0D, 1D, 272D, 160D);
			this.Cmin.MaximumTag = null;
			this.Cmin.MinimumTag = null;
			this.Cmin.Name = "Cmin";
			this.Cmin.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.Cmin.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Black"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.Cmin.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.Cmin.Suffix = "%";
			this.Cmin.TagName = "Cmin";
			this.Cmin.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			this.Cmin.TextColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.Cmin.Value = 0F;
			this.Cmin.EndInit();
			// 
			// rowTC2
			// 
			this.rowTC2.Bounds = new NxtControl.Drawing.RectF(((float)(8D)), ((float)(192D)), ((float)(376D)), ((float)(40D)));
			this.rowTC2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(250)), ((byte)(250)), ((byte)(250))));
			this.rowTC2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rowTC2.Name = "rowTC2";
			// 
			// txtTC2
			// 
			this.txtTC2.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.txtTC2.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.txtTC2.Location = new NxtControl.Drawing.PointF(16D, 204D);
			this.txtTC2.Name = "txtTC2";
			this.txtTC2.Text = "Time at C2 (T_C2) :";
			// 
			// T_C2
			// 
			this.T_C2.BeginInit();
			this.T_C2.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.48D, 0D, 0D, 1D, 272D, 200D);
			this.T_C2.MaximumTag = null;
			this.T_C2.MinimumTag = null;
			this.T_C2.Name = "T_C2";
			this.T_C2.TagName = "T_C2";
			this.T_C2.Value = new NxtControl.GuiFramework.Time(((long)(0)));
			this.T_C2.EndInit();
			// 
			// rowTC3
			// 
			this.rowTC3.Bounds = new NxtControl.Drawing.RectF(((float)(8D)), ((float)(232D)), ((float)(376D)), ((float)(40D)));
			this.rowTC3.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(250)), ((byte)(250)), ((byte)(250))));
			this.rowTC3.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rowTC3.Name = "rowTC3";
			// 
			// txtTC3
			// 
			this.txtTC3.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.txtTC3.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.txtTC3.Location = new NxtControl.Drawing.PointF(16D, 244D);
			this.txtTC3.Name = "txtTC3";
			this.txtTC3.Text = "Time below C3 (T_C3) :";
			// 
			// T_C3
			// 
			this.T_C3.BeginInit();
			this.T_C3.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.48D, 0D, 0D, 1D, 272D, 240D);
			this.T_C3.MaximumTag = null;
			this.T_C3.MinimumTag = null;
			this.T_C3.Name = "T_C3";
			this.T_C3.TagName = "T_C3";
			this.T_C3.Value = new NxtControl.GuiFramework.Time(((long)(0)));
			this.T_C3.EndInit();
			// 
			// rowRest
			// 
			this.rowRest.Bounds = new NxtControl.Drawing.RectF(((float)(8D)), ((float)(272D)), ((float)(376D)), ((float)(40D)));
			this.rowRest.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(250)), ((byte)(250)), ((byte)(250))));
			this.rowRest.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rowRest.Name = "rowRest";
			// 
			// txtRest
			// 
			this.txtRest.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.txtRest.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.txtRest.Location = new NxtControl.Drawing.PointF(16D, 284D);
			this.txtRest.Name = "txtRest";
			this.txtRest.Text = "Feed Restart Waiting Time :";
			// 
			// RestartWaitingTime
			// 
			this.RestartWaitingTime.BeginInit();
			this.RestartWaitingTime.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.48D, 0D, 0D, 1D, 272D, 280D);
			this.RestartWaitingTime.MaximumTag = null;
			this.RestartWaitingTime.MinimumTag = null;
			this.RestartWaitingTime.Name = "RestartWaitingTime";
			this.RestartWaitingTime.TagName = "RestartWaitingTime";
			this.RestartWaitingTime.Value = new NxtControl.GuiFramework.Time(((long)(0)));
			this.RestartWaitingTime.EndInit();
			// 
			// rowFLL
			// 
			this.rowFLL.Bounds = new NxtControl.Drawing.RectF(((float)(8D)), ((float)(312D)), ((float)(376D)), ((float)(40D)));
			this.rowFLL.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(250)), ((byte)(250)), ((byte)(250))));
			this.rowFLL.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rowFLL.Name = "rowFLL";
			// 
			// txtFLL
			// 
			this.txtFLL.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.txtFLL.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.txtFLL.Location = new NxtControl.Drawing.PointF(16D, 324D);
			this.txtFLL.Name = "txtFLL";
			this.txtFLL.Text = "Flow LowLow Time :";
			// 
			// T_FlowLL
			// 
			this.T_FlowLL.BeginInit();
			this.T_FlowLL.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.48D, 0D, 0D, 1D, 272D, 320D);
			this.T_FlowLL.MaximumTag = null;
			this.T_FlowLL.MinimumTag = null;
			this.T_FlowLL.Name = "T_FlowLL";
			this.T_FlowLL.TagName = "T_FlowLL";
			this.T_FlowLL.Value = new NxtControl.GuiFramework.Time(((long)(0)));
			this.T_FlowLL.EndInit();
			// 
			// rowCap
			// 
			this.rowCap.Bounds = new NxtControl.Drawing.RectF(((float)(8D)), ((float)(352D)), ((float)(376D)), ((float)(40D)));
			this.rowCap.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(250)), ((byte)(250)), ((byte)(250))));
			this.rowCap.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rowCap.Name = "rowCap";
			// 
			// txtCap
			// 
			this.txtCap.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.txtCap.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.txtCap.Location = new NxtControl.Drawing.PointF(16D, 364D);
			this.txtCap.Name = "txtCap";
			this.txtCap.Text = "Theoretical Pump Capacity :";
			// 
			// FlowCapTheo
			// 
			this.FlowCapTheo.BeginInit();
			this.FlowCapTheo.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.48D, 0D, 0D, 1D, 272D, 360D);
			this.FlowCapTheo.MaximumTag = null;
			this.FlowCapTheo.MinimumTag = null;
			this.FlowCapTheo.Name = "FlowCapTheo";
			this.FlowCapTheo.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.FlowCapTheo.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Black"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.FlowCapTheo.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.FlowCapTheo.Suffix = "m³/h";
			this.FlowCapTheo.TagName = "FlowCapTheo";
			this.FlowCapTheo.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			this.FlowCapTheo.TextColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.FlowCapTheo.Value = 0F;
			this.FlowCapTheo.EndInit();
			// 
			// rectBg
			// 
			this.rectBg.Bounds = new NxtControl.Drawing.RectF(((float)(8D)), ((float)(424D)), ((float)(376D)), ((float)(152D)));
			this.rectBg.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(250)), ((byte)(250)), ((byte)(250))));
			this.rectBg.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectBg.Name = "rectBg";
			this.rectBg.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(200)), ((byte)(200)), ((byte)(200))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// polyTitle
			// 
			this.polyTitle.Bounds = new NxtControl.Drawing.RectF(((float)(8D)), ((float)(400D)), ((float)(176D)), ((float)(24D)));
			this.polyTitle.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(78)), ((byte)(78)), ((byte)(78))));
			this.polyTitle.Closed = true;
			this.polyTitle.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular);
			this.polyTitle.Name = "polyTitle";
			this.polyTitle.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(78)), ((byte)(78)), ((byte)(78))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.polyTitle.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(8D, 424D),
			new NxtControl.Drawing.PointF(8D, 400D),
			new NxtControl.Drawing.PointF(160D, 400D),
			new NxtControl.Drawing.PointF(184D, 424D)});
			this.polyTitle.Text = "PUMPS STATUS";
			this.polyTitle.TextColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(0)));
			// 
			// txtState
			// 
			this.txtState.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.txtState.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.txtState.Location = new NxtControl.Drawing.PointF(16D, 432D);
			this.txtState.Name = "txtState";
			this.txtState.Text = "-";
			// 
			// txtPumps
			// 
			this.txtPumps.Color = new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60)));
			this.txtPumps.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.txtPumps.Location = new NxtControl.Drawing.PointF(16D, 456D);
			this.txtPumps.Name = "txtPumps";
			this.txtPumps.Text = "Pumps in service: -";
			// 
			// txtSpeed
			// 
			this.txtSpeed.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.txtSpeed.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.txtSpeed.Location = new NxtControl.Drawing.PointF(16D, 476D);
			this.txtSpeed.Name = "txtSpeed";
			this.txtSpeed.Text = "Speed per pump: - %";
			// 
			// txtMode
			// 
			this.txtMode.Color = new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60)));
			this.txtMode.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.txtMode.Location = new NxtControl.Drawing.PointF(16D, 496D);
			this.txtMode.Name = "txtMode";
			this.txtMode.Text = "";
			// 
			// txtWarn1
			// 
			this.txtWarn1.Color = new NxtControl.Drawing.Color(((byte)(200)), ((byte)(120)), ((byte)(0)));
			this.txtWarn1.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.txtWarn1.Location = new NxtControl.Drawing.PointF(16D, 524D);
			this.txtWarn1.Name = "txtWarn1";
			this.txtWarn1.Text = "";
			// 
			// txtWarn2
			// 
			this.txtWarn2.Color = new NxtControl.Drawing.Color(((byte)(200)), ((byte)(30)), ((byte)(30)));
			this.txtWarn2.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.txtWarn2.Location = new NxtControl.Drawing.PointF(16D, 546D);
			this.txtWarn2.Name = "txtWarn2";
			this.txtWarn2.Text = "";
			// 
			// rectBarFrame
			// 
			this.rectBarFrame.Bounds = new NxtControl.Drawing.RectF(((float)(306D)), ((float)(432D)), ((float)(28D)), ((float)(138D)));
			this.rectBarFrame.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255))));
			this.rectBarFrame.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectBarFrame.Name = "rectBarFrame";
			this.rectBarFrame.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(120)), ((byte)(120)), ((byte)(120))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// rectBarFill
			// 
			this.rectBarFill.Bounds = new NxtControl.Drawing.RectF(((float)(308D)), ((float)(434D)), ((float)(24D)), ((float)(134D)));
			this.rectBarFill.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(61)), ((byte)(205)), ((byte)(88))));
			this.rectBarFill.FillDirection = NxtControl.Drawing.FillDirection.DownToTop;
			this.rectBarFill.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectBarFill.Name = "rectBarFill";
			this.rectBarFill.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// txt100
			// 
			this.txt100.Color = new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90)));
			this.txt100.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.txt100.Location = new NxtControl.Drawing.PointF(274D, 428D);
			this.txt100.Name = "txt100";
			this.txt100.Text = "100%";
			// 
			// txt0
			// 
			this.txt0.Color = new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90)));
			this.txt0.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.txt0.Location = new NxtControl.Drawing.PointF(288D, 560D);
			this.txt0.Name = "txt0";
			this.txt0.Text = "0%";
			// 
			// mkCmin
			// 
			this.mkCmin.Bounds = new NxtControl.Drawing.RectF(((float)(302D)), ((float)(500D)), ((float)(36D)), ((float)(3D)));
			this.mkCmin.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))));
			this.mkCmin.Closed = true;
			this.mkCmin.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.mkCmin.Name = "mkCmin";
			this.mkCmin.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.mkCmin.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(302D, 500D),
			new NxtControl.Drawing.PointF(338D, 500D),
			new NxtControl.Drawing.PointF(338D, 503D),
			new NxtControl.Drawing.PointF(302D, 503D)});
			// 
			// lbCmin
			// 
			this.lbCmin.Color = new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90)));
			this.lbCmin.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.lbCmin.Location = new NxtControl.Drawing.PointF(340D, 494D);
			this.lbCmin.Name = "lbCmin";
			this.lbCmin.Text = "Cmin";
			// 
			// mkC3
			// 
			this.mkC3.Bounds = new NxtControl.Drawing.RectF(((float)(302D)), ((float)(500D)), ((float)(36D)), ((float)(3D)));
			this.mkC3.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(114)), ((byte)(188))));
			this.mkC3.Closed = true;
			this.mkC3.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.mkC3.Name = "mkC3";
			this.mkC3.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(114)), ((byte)(188))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.mkC3.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(302D, 500D),
			new NxtControl.Drawing.PointF(338D, 500D),
			new NxtControl.Drawing.PointF(338D, 503D),
			new NxtControl.Drawing.PointF(302D, 503D)});
			// 
			// lbC3
			// 
			this.lbC3.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(114)), ((byte)(188)));
			this.lbC3.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.lbC3.Location = new NxtControl.Drawing.PointF(340D, 494D);
			this.lbC3.Name = "lbC3";
			this.lbC3.Text = "C3";
			// 
			// mkC2
			// 
			this.mkC2.Bounds = new NxtControl.Drawing.RectF(((float)(302D)), ((float)(500D)), ((float)(36D)), ((float)(3D)));
			this.mkC2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(230)), ((byte)(120)), ((byte)(0))));
			this.mkC2.Closed = true;
			this.mkC2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.mkC2.Name = "mkC2";
			this.mkC2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(230)), ((byte)(120)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.mkC2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(302D, 500D),
			new NxtControl.Drawing.PointF(338D, 500D),
			new NxtControl.Drawing.PointF(338D, 503D),
			new NxtControl.Drawing.PointF(302D, 503D)});
			// 
			// lbC2
			// 
			this.lbC2.Color = new NxtControl.Drawing.Color(((byte)(230)), ((byte)(120)), ((byte)(0)));
			this.lbC2.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.lbC2.Location = new NxtControl.Drawing.PointF(340D, 494D);
			this.lbC2.Name = "lbC2";
			this.lbC2.Text = "C2";
			// 
			// mkCmax
			// 
			this.mkCmax.Bounds = new NxtControl.Drawing.RectF(((float)(302D)), ((float)(500D)), ((float)(36D)), ((float)(3D)));
			this.mkCmax.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(200)), ((byte)(30)), ((byte)(30))));
			this.mkCmax.Closed = true;
			this.mkCmax.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.mkCmax.Name = "mkCmax";
			this.mkCmax.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(200)), ((byte)(30)), ((byte)(30))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.mkCmax.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(302D, 500D),
			new NxtControl.Drawing.PointF(338D, 500D),
			new NxtControl.Drawing.PointF(338D, 503D),
			new NxtControl.Drawing.PointF(302D, 503D)});
			// 
			// lbCmax
			// 
			this.lbCmax.Color = new NxtControl.Drawing.Color(((byte)(200)), ((byte)(30)), ((byte)(30)));
			this.lbCmax.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.lbCmax.Location = new NxtControl.Drawing.PointF(340D, 494D);
			this.lbCmax.Name = "lbCmax";
			this.lbCmax.Text = "Cmax";
			// 
			// sDefault
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.polygon1,
			this.rowCmax,
			this.txtCmax,
			this.MaxCapacityOnePump,
			this.rowC2,
			this.txtC2,
			this.C2Capacity,
			this.rowC3,
			this.txtC3,
			this.textBox_11,
			this.rowCmin,
			this.txtCmin,
			this.Cmin,
			this.rowTC2,
			this.txtTC2,
			this.T_C2,
			this.rowTC3,
			this.txtTC3,
			this.T_C3,
			this.rowRest,
			this.txtRest,
			this.RestartWaitingTime,
			this.rowFLL,
			this.txtFLL,
			this.T_FlowLL,
			this.rowCap,
			this.txtCap,
			this.FlowCapTheo,
			this.rectBg,
			this.polyTitle,
			this.rectBarFrame,
			this.rectBarFill,
			this.mkCmin,
			this.mkC3,
			this.mkC2,
			this.mkCmax,
			this.lbCmin,
			this.lbC3,
			this.lbC2,
			this.lbCmax,
			this.txt100,
			this.txt0,
			this.txtState,
			this.txtPumps,
			this.txtSpeed,
			this.txtMode,
			this.txtWarn1,
			this.txtWarn2});
			this.SymbolSize = new System.Drawing.Size(432, 584);

		}
		private NxtControl.GuiFramework.Polygon polygon1;
		private NxtControl.GuiFramework.Rectangle rowCmax;
		private NxtControl.GuiFramework.FreeText txtCmax;
		private System.HMI.Symbols.Base.TextBox<float> MaxCapacityOnePump;
		private NxtControl.GuiFramework.Rectangle rowC2;
		private NxtControl.GuiFramework.FreeText txtC2;
		private System.HMI.Symbols.Base.TextBox<float> C2Capacity;
		private NxtControl.GuiFramework.Rectangle rowC3;
		private NxtControl.GuiFramework.FreeText txtC3;
		private System.HMI.Symbols.Base.TextBox<float> textBox_11;
		private NxtControl.GuiFramework.Rectangle rowCmin;
		private NxtControl.GuiFramework.FreeText txtCmin;
		private System.HMI.Symbols.Base.TextBox<float> Cmin;
		private NxtControl.GuiFramework.Rectangle rowTC2;
		private NxtControl.GuiFramework.FreeText txtTC2;
		private System.HMI.Symbols.Base.TimeTextBox T_C2;
		private NxtControl.GuiFramework.Rectangle rowTC3;
		private NxtControl.GuiFramework.FreeText txtTC3;
		private System.HMI.Symbols.Base.TimeTextBox T_C3;
		private NxtControl.GuiFramework.Rectangle rowRest;
		private NxtControl.GuiFramework.FreeText txtRest;
		private System.HMI.Symbols.Base.TimeTextBox RestartWaitingTime;
		private NxtControl.GuiFramework.Rectangle rowFLL;
		private NxtControl.GuiFramework.FreeText txtFLL;
		private System.HMI.Symbols.Base.TimeTextBox T_FlowLL;
		private NxtControl.GuiFramework.Rectangle rowCap;
		private NxtControl.GuiFramework.FreeText txtCap;
		private System.HMI.Symbols.Base.TextBox<float> FlowCapTheo;
		private NxtControl.GuiFramework.Rectangle rectBg;
		private NxtControl.GuiFramework.Polygon polyTitle;
		private NxtControl.GuiFramework.FreeText txtState;
		private NxtControl.GuiFramework.FreeText txtPumps;
		private NxtControl.GuiFramework.FreeText txtSpeed;
		private NxtControl.GuiFramework.FreeText txtMode;
		private NxtControl.GuiFramework.FreeText txtWarn1;
		private NxtControl.GuiFramework.FreeText txtWarn2;
		private NxtControl.GuiFramework.Rectangle rectBarFrame;
		private NxtControl.GuiFramework.Rectangle rectBarFill;
		private NxtControl.GuiFramework.FreeText txt100;
		private NxtControl.GuiFramework.FreeText txt0;
		private NxtControl.GuiFramework.Polygon mkCmin;
		private NxtControl.GuiFramework.FreeText lbCmin;
		private NxtControl.GuiFramework.Polygon mkC3;
		private NxtControl.GuiFramework.FreeText lbC3;
		private NxtControl.GuiFramework.Polygon mkC2;
		private NxtControl.GuiFramework.FreeText lbC2;
		private NxtControl.GuiFramework.Polygon mkCmax;
		private NxtControl.GuiFramework.FreeText lbCmax;
		#endregion
	}
}
