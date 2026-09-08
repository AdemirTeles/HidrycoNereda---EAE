using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using NxtControl.GuiFramework;

namespace SE.Nereda.Faceplates.AnalogInputBase
{
	/// <summary>
	/// Summary description for fpDefault.
	/// </summary>
	partial class fpDefault
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary2 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary1 = new NxtControl.GuiFramework.PropertyDictionary();
			this.execPv = new System.HMI.Symbols.Base.Execute<float>();
			this.execPvMin = new System.HMI.Symbols.Base.Execute<float>();
			this.execPvMax = new System.HMI.Symbols.Base.Execute<float>();
			this.execCurrentMode = new System.HMI.Symbols.Base.Execute<ushort>();
			this.Scale = new System.HMI.Symbols.Base.Execute<bool>();
			this.line1 = new NxtControl.GuiFramework.Line();
			this.lblPv = new System.HMI.Symbols.Base.Label<float>();
			this.lblPvMin = new NxtControl.GuiFramework.Label();
			this.lblPvMax = new NxtControl.GuiFramework.Label();
			this.SMeters1 = new SE.App2Base.Graphics.SMeters();
			this.labelS1 = new SE.App2Base.Graphics.LabelS();
			this.fpNavigationPane = new SE.App2Base.Graphics.FpNavigationPane();
			this.Over = new System.HMI.Symbols.Base.Execute<bool>();
			this.HiButton = new SE.App2Base.Graphics.LimitAlarm();
			this.HiHiButton = new SE.App2Base.Graphics.LimitAlarm();
			this.LoButton = new SE.App2Base.Graphics.LimitAlarm();
			this.LoLoButton = new SE.App2Base.Graphics.LimitAlarm();
			this.HiIndicator = new SE.App2Base.Graphics.LimitAlarm();
			this.HiHiIndicator = new SE.App2Base.Graphics.LimitAlarm();
			this.LoIndicator = new SE.App2Base.Graphics.LimitAlarm();
			this.LoLoIndicator = new SE.App2Base.Graphics.LimitAlarm();
			this.RocButton = new SE.App2Base.Graphics.LimitAlarm();
			this.DevButton = new SE.App2Base.Graphics.LimitAlarm();
			this.RocIndicator = new SE.App2Base.Graphics.LimitAlarm();
			this.DevIndicator = new SE.App2Base.Graphics.LimitAlarm();
			// 
			// execPv
			// 
			this.execPv.BeginInit();
			this.execPv.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.execPv.IsOnlyInput = true;
			this.execPv.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.execPv.Name = "execPv";
			this.execPv.SecurityLevel = 0;
			this.execPv.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.execPv.TagName = "Pv";
			this.execPv.Value = 0F;
			this.execPv.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.ExecPvValueChanged);
			this.execPv.EndInit();
			// 
			// execPvMin
			// 
			this.execPvMin.BeginInit();
			this.execPvMin.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.execPvMin.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.execPvMin.Name = "execPvMin";
			this.execPvMin.SecurityLevel = 0;
			this.execPvMin.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.execPvMin.TagName = "PvMin";
			this.execPvMin.Value = 0F;
			this.execPvMin.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.ExecPvMinValueChanged);
			this.execPvMin.EndInit();
			// 
			// execPvMax
			// 
			this.execPvMax.BeginInit();
			this.execPvMax.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.execPvMax.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.execPvMax.Name = "execPvMax";
			this.execPvMax.SecurityLevel = 0;
			this.execPvMax.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.execPvMax.TagName = "PvMax";
			this.execPvMax.Value = 0F;
			this.execPvMax.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.ExecPvMaxValueChanged);
			this.execPvMax.EndInit();
			// 
			// execCurrentMode
			// 
			this.execCurrentMode.BeginInit();
			this.execCurrentMode.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.execCurrentMode.IsOnlyInput = true;
			this.execCurrentMode.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.execCurrentMode.Name = "execCurrentMode";
			this.execCurrentMode.SecurityLevel = 0;
			this.execCurrentMode.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.execCurrentMode.TagName = "";
			this.execCurrentMode.Value = ((ushort)(0));
			this.execCurrentMode.EndInit();
			// 
			// Scale
			// 
			this.Scale.BeginInit();
			this.Scale.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.Scale.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.Scale.Name = "Scale";
			this.Scale.SecurityLevel = 0;
			this.Scale.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.Scale.TagName = "";
			this.Scale.Value = false;
			this.Scale.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.ScaleValueChanged);
			this.Scale.EndInit();
			// 
			// line1
			// 
			this.line1.EndPoint = new NxtControl.Drawing.PointF(270D, 93D);
			this.line1.Name = "line1";
			this.line1.Pen = new NxtControl.Drawing.Pen("FpLinePen");
			this.line1.StartPoint = new NxtControl.Drawing.PointF(0D, 93D);
			// 
			// lblPv
			// 
			this.lblPv.BeginInit();
			this.lblPv.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lblPv.DecimalPlacesCount = ((uint)(2u));
			this.lblPv.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.66666666666666663D, 0D, 0D, 0.76190476190476186D, 120D, 42D);
			this.lblPv.Font = new NxtControl.Drawing.Font("SE.App2Base.Pv");
			this.lblPv.FontScale = false;
			this.lblPv.IsOnlyInput = true;
			this.lblPv.IsPrefixSuffixOutside = false;
			this.lblPv.LeadingZeros = ((uint)(0u));
			this.lblPv.Name = "lblPv";
			this.lblPv.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.lblPv.Ranges.Clear();
			this.lblPv.Ranges.Add(new NxtControl.GuiFramework.Range<float>(null, true, null, true, propertyDictionary2));
			propertyDictionary1.Add("Text", "${Value}");
			propertyDictionary1.Add("TextColor", new NxtControl.Drawing.Color("SE.App2Base.aaLibFpPv"));
			propertyDictionary1.Add("Brush", new NxtControl.Drawing.Brush());
			propertyDictionary1.Add("Pen", new NxtControl.Drawing.Pen("LabelPen"));
			this.lblPv.Ranges.DefaultPropertyValues = propertyDictionary1;
			this.lblPv.TagName = "Pv";
			this.lblPv.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.lblPv.EndInit();
			// 
			// lblPvMin
			// 
			this.lblPvMin.AngleIgnore = true;
			this.lblPvMin.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lblPvMin.Bounds = new NxtControl.Drawing.RectF(((float)(47D)), ((float)(310D)), ((float)(50D)), ((float)(15D)));
			this.lblPvMin.Brush = new NxtControl.Drawing.Brush();
			this.lblPvMin.Font = new NxtControl.Drawing.Font("SE.App2Base.Pv");
			this.lblPvMin.Name = "lblPvMin";
			this.lblPvMin.Pen = new NxtControl.Drawing.Pen("Black");
			this.lblPvMin.Text = "0.0";
			this.lblPvMin.TextAlignment = NxtControl.Drawing.ContentAlignment.TopRight;
			this.lblPvMin.TextColor = new NxtControl.Drawing.Color("SE.App2Base.aaLibFpPv");
			// 
			// lblPvMax
			// 
			this.lblPvMax.AngleIgnore = true;
			this.lblPvMax.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lblPvMax.Bounds = new NxtControl.Drawing.RectF(((float)(47D)), ((float)(120D)), ((float)(50D)), ((float)(15D)));
			this.lblPvMax.Brush = new NxtControl.Drawing.Brush();
			this.lblPvMax.Font = new NxtControl.Drawing.Font("SE.App2Base.Pv");
			this.lblPvMax.Name = "lblPvMax";
			this.lblPvMax.Pen = new NxtControl.Drawing.Pen("Black");
			this.lblPvMax.Text = "0.0";
			this.lblPvMax.TextAlignment = NxtControl.Drawing.ContentAlignment.TopRight;
			this.lblPvMax.TextColor = new NxtControl.Drawing.Color("SE.App2Base.aaLibFpPv");
			// 
			// SMeters1
			// 
			this.SMeters1.BeginInit();
			this.SMeters1.AbnormalXOffset = 0D;
			this.SMeters1.AbnormalYOffset = 0D;
			this.SMeters1.BarGraphSize = 160D;
			this.SMeters1.DecimalPlacesCount = ((uint)(2u));
			this.SMeters1.DecimalPlacesCountOut = ((uint)(2u));
			this.SMeters1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1.4285714285714286D, 0D, 0D, 1D, 77.285714285714292D, 200D);
			this.SMeters1.display = SE.App2Base.Graphics.SMeters.Display.BarGraph;
			this.SMeters1.FrameColor = new NxtControl.Drawing.Color("SymStaticIconColor");
			this.SMeters1.LeftOffset = ((uint)(60u));
			this.SMeters1.Name = "SMeters1";
			this.SMeters1.NumericalVisible = SE.App2Base.Graphics.SMeters.NumericalDisplaySel.None;
			this.SMeters1.OpColor = new NxtControl.Drawing.Color("SE.App2Base.aaLibFpOp");
			this.SMeters1.PvColor = new NxtControl.Drawing.Color("SE.App2Base.aaLibFpPv");
			this.SMeters1.RangeVisible = SE.App2Base.SupportClasses.BoolType.False;
			this.SMeters1.Rotation = SE.App2Base.SupportClasses.Rotation.Vertical;
			this.SMeters1.SpColor = new NxtControl.Drawing.Color("SE.App2Base.aaLibFpSp");
			this.SMeters1.SpIndicator = SE.App2Base.Graphics.SMeters.Indicator.None;
			this.SMeters1.TextAlignmentPvSpOp = SE.App2Base.Graphics.SMeters.TextAlignment.Right;
			this.SMeters1.TextLocationPvSpOp = SE.App2Base.Graphics.SMeters.TextLocation.Left;
			this.SMeters1.Unit = "";
			this.SMeters1.ValuePct = 0D;
			this.SMeters1.EndInit();
			// 
			// labelS1
			// 
			this.labelS1.BeginInit();
			this.labelS1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 5D, 38D);
			this.labelS1.Font = new NxtControl.Drawing.Font("SE.App2Base.LabelFont");
			this.labelS1.Name = "labelS1";
			this.labelS1.NameSpace = "SE.App2CommonProcess";
			this.labelS1.SeperatorVisiblity = true;
			this.labelS1.Text = "Process Value";
			this.labelS1.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.labelS1.TextColor = new NxtControl.Drawing.Color("FpLabelText");
			this.labelS1.TextKey = "LabelProcessValue";
			this.labelS1.EndInit();
			// 
			// fpNavigationPane
			// 
			this.fpNavigationPane.BeginInit();
			this.fpNavigationPane.Backwash.AliasName = "";
			this.fpNavigationPane.Backwash.Availablity = SE.App2Base.SupportClasses.FpIconSymbolAllocation.NotAvailable;
			this.fpNavigationPane.Backwash.InstanceName = null;
			this.fpNavigationPane.Backwash.ParentTitle = "Title";
			this.fpNavigationPane.Backwash.SymbolType = "SE.AppWWW.Symbols.Backwash.sDefault";
			this.fpNavigationPane.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 211D, 0D);
			this.fpNavigationPane.Failure.AliasName = "";
			this.fpNavigationPane.Failure.Availablity = SE.App2Base.SupportClasses.FpIconSymbolAllocation.NotAvailable;
			this.fpNavigationPane.Failure.InstanceName = null;
			this.fpNavigationPane.Failure.ParentTitle = "Title";
			this.fpNavigationPane.Failure.SymbolType = "SE.AppCommonProcess.Symbols.CondSum.sFailure";
			this.fpNavigationPane.Filtration.AliasName = "";
			this.fpNavigationPane.Filtration.Availablity = SE.App2Base.SupportClasses.FpIconSymbolAllocation.NotAvailable;
			this.fpNavigationPane.Filtration.InstanceName = null;
			this.fpNavigationPane.Filtration.ParentTitle = "Title";
			this.fpNavigationPane.Filtration.SymbolType = "SE.AppWWW.Symbols.Filtration.sDefault";
			this.fpNavigationPane.GeneralPropertySubscription.AddRange(new string[] {
			"System.ShowTagNames"});
			this.fpNavigationPane.HideSlider = false;
			this.fpNavigationPane.InputParameters.Availablity = SE.App2Base.SupportClasses.FpIconSymbolAllocation.NotAvailable;
			this.fpNavigationPane.Interlock.AliasName = "";
			this.fpNavigationPane.Interlock.Availablity = SE.App2Base.SupportClasses.FpIconSymbolAllocation.NotAvailable;
			this.fpNavigationPane.Interlock.InstanceName = null;
			this.fpNavigationPane.Interlock.ParentTitle = "Title";
			this.fpNavigationPane.Interlock.SymbolType = "SE.AppCommonProcess.Symbols.IlckCondSum.sInterlock";
			this.fpNavigationPane.IsBasic = false;
			this.fpNavigationPane.LocalPanel.AliasName = "";
			this.fpNavigationPane.LocalPanel.Availablity = SE.App2Base.SupportClasses.FpIconSymbolAllocation.NotAvailable;
			this.fpNavigationPane.LocalPanel.InstanceName = null;
			this.fpNavigationPane.LocalPanel.ParentTitle = "Title";
			this.fpNavigationPane.LocalPanel.SymbolType = "SE.AppCommonProcess.Symbols.DevLp.sDefault";
			this.fpNavigationPane.Maintenance.AliasName = "";
			this.fpNavigationPane.Maintenance.Availablity = SE.App2Base.SupportClasses.FpIconSymbolAllocation.NotAvailable;
			this.fpNavigationPane.Maintenance.InstanceName = null;
			this.fpNavigationPane.Maintenance.ParentTitle = "Title";
			this.fpNavigationPane.Maintenance.SymbolType = "SE.AppCommonProcess.Symbols.DevMnt.sDefault";
			this.fpNavigationPane.Measures.Availablity = SE.App2Base.SupportClasses.FpIconSymbolAllocation.NotAvailable;
			this.fpNavigationPane.Name = "fpNavigationPane";
			this.fpNavigationPane.OutputParameters.Availablity = SE.App2Base.SupportClasses.FpIconSymbolAllocation.NotAvailable;
			this.fpNavigationPane.Owner.AliasName = "";
			this.fpNavigationPane.Owner.Availablity = SE.App2Base.SupportClasses.FpIconSymbolAllocation.NotAvailable;
			this.fpNavigationPane.Owner.InstanceName = null;
			this.fpNavigationPane.Owner.ParentTitle = "Title";
			this.fpNavigationPane.Owner.SymbolType = "SE.App2Base.Symbols.Owner.sOwnerConfig";
			this.fpNavigationPane.Parameter.Availablity = SE.App2Base.SupportClasses.FpIconSymbolAllocation.Slot1R;
			this.fpNavigationPane.ParentTitle = "";
			this.fpNavigationPane.Permissive.AliasName = "";
			this.fpNavigationPane.Permissive.Availablity = SE.App2Base.SupportClasses.FpIconSymbolAllocation.NotAvailable;
			this.fpNavigationPane.Permissive.InstanceName = null;
			this.fpNavigationPane.Permissive.ParentTitle = "Title";
			this.fpNavigationPane.Permissive.SymbolType = "SE.AppCommonProcess.Symbols.PermCondSum.sPermissive";
			this.fpNavigationPane.SecMode = 6;
			this.fpNavigationPane.SecOwner = 3;
			this.fpNavigationPane.SecParameter = 12;
			this.fpNavigationPane.SecSetpoint = 3;
			this.fpNavigationPane.ShortFlush.AliasName = "";
			this.fpNavigationPane.ShortFlush.Availablity = SE.App2Base.SupportClasses.FpIconSymbolAllocation.NotAvailable;
			this.fpNavigationPane.ShortFlush.InstanceName = null;
			this.fpNavigationPane.ShortFlush.ParentTitle = "Title";
			this.fpNavigationPane.ShortFlush.SymbolType = "SE.AppWWW.Symbols.ShortFlush.sDefault";
			this.fpNavigationPane.Trend.Availablity = SE.App2Base.SupportClasses.FpIconSymbolAllocation.Slot2R;
			this.fpNavigationPane.OnParameterClick += new SE.App2Base.Graphics.FpNavigationPane.ParameterClicked(this.FpNavigationPaneOnParameterClick);
			this.fpNavigationPane.OnTrendClick += new SE.App2Base.Graphics.FpNavigationPane.TrendClicked(this.FpNavigationPaneOnTrendClick);
			this.fpNavigationPane.EndInit();
			// 
			// Over
			// 
			this.Over.BeginInit();
			this.Over.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.Over.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.Over.Name = "Over";
			this.Over.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.Over.TagName = "PvOverride";
			this.Over.Value = false;
			this.Over.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.OverValueChanged);
			this.Over.EndInit();
			// 
			// HiButton
			// 
			this.HiButton.BeginInit();
			this.HiButton.AlarmName = "TxtHi";
			this.HiButton.BasicParameters.DecimalPlacesCount = ((uint)(2u));
			this.HiButton.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 181D, 141D);
			this.HiButton.DevIndicatorParameters.MaxLimitValue = 100F;
			this.HiButton.DevIndicatorParameters.MinLimitValue = 0F;
			this.HiButton.IndicatorParameters.IndicatorBrush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(234)), ((byte)(22)), ((byte)(30))), new NxtControl.Drawing.GradientFill(NxtControl.Drawing.GradientFillOrientation.HorizontalRight, NxtControl.Drawing.GradientFillBrightness.Light));
			this.HiButton.IndicatorParameters.MaxLimitValue = 100F;
			this.HiButton.IndicatorParameters.MinLimitValue = 0F;
			this.HiButton.InstanceName = "";
			this.HiButton.Name = "HiButton";
			this.HiButton.NameSpace = "SE.App2CommonProcess";
			this.HiButton.ROCAlarmParameters.DecimalPlacesCount = ((uint)(2u));
			this.HiButton.ROCAlarmParameters.MaxLimitValue = 100F;
			this.HiButton.ROCAlarmParameters.MinLimitValue = 0F;
			this.HiButton.ROCIndicatorParameters.DecimalPlacesCount = ((uint)(2u));
			this.HiButton.ROCIndicatorParameters.MaxLimitValue = 100F;
			this.HiButton.ROCIndicatorParameters.MinLimitValue = 0F;
			this.HiButton.SymbolType = "";
			this.HiButton.Tooltip = "High";
			this.HiButton.OnServiceStateChanged += new SE.App2Base.SupportClasses.ServiceStateChanged(this.HiButtonAvailableChanged);
			this.HiButton.EndInit();
			// 
			// HiHiButton
			// 
			this.HiHiButton.BeginInit();
			this.HiHiButton.AlarmName = "TxtHiHi";
			this.HiHiButton.BasicParameters.DecimalPlacesCount = ((uint)(2u));
			this.HiHiButton.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 181D, 141D);
			this.HiHiButton.DevIndicatorParameters.MaxLimitValue = 100F;
			this.HiHiButton.DevIndicatorParameters.MinLimitValue = 0F;
			this.HiHiButton.IndicatorParameters.IndicatorBrush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(234)), ((byte)(22)), ((byte)(30))), new NxtControl.Drawing.GradientFill(NxtControl.Drawing.GradientFillOrientation.HorizontalRight, NxtControl.Drawing.GradientFillBrightness.Light));
			this.HiHiButton.IndicatorParameters.MaxLimitValue = 100F;
			this.HiHiButton.IndicatorParameters.MinLimitValue = 0F;
			this.HiHiButton.InstanceName = "";
			this.HiHiButton.Name = "HiHiButton";
			this.HiHiButton.NameSpace = "SE.App2CommonProcess";
			this.HiHiButton.ROCAlarmParameters.DecimalPlacesCount = ((uint)(2u));
			this.HiHiButton.ROCAlarmParameters.MaxLimitValue = 100F;
			this.HiHiButton.ROCAlarmParameters.MinLimitValue = 0F;
			this.HiHiButton.ROCIndicatorParameters.DecimalPlacesCount = ((uint)(2u));
			this.HiHiButton.ROCIndicatorParameters.MaxLimitValue = 100F;
			this.HiHiButton.ROCIndicatorParameters.MinLimitValue = 0F;
			this.HiHiButton.SymbolType = "";
			this.HiHiButton.Tooltip = "High High";
			this.HiHiButton.OnServiceStateChanged += new SE.App2Base.SupportClasses.ServiceStateChanged(this.HiHiButtonAvailableChanged);
			this.HiHiButton.EndInit();
			// 
			// LoButton
			// 
			this.LoButton.BeginInit();
			this.LoButton.AlarmName = "TxtLo";
			this.LoButton.BasicParameters.DecimalPlacesCount = ((uint)(2u));
			this.LoButton.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 181D, 141D);
			this.LoButton.DevIndicatorParameters.MaxLimitValue = 100F;
			this.LoButton.DevIndicatorParameters.MinLimitValue = 0F;
			this.LoButton.IndicatorParameters.IndicatorBrush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(234)), ((byte)(22)), ((byte)(30))), new NxtControl.Drawing.GradientFill(NxtControl.Drawing.GradientFillOrientation.HorizontalRight, NxtControl.Drawing.GradientFillBrightness.Light));
			this.LoButton.IndicatorParameters.MaxLimitValue = 100F;
			this.LoButton.IndicatorParameters.MinLimitValue = 0F;
			this.LoButton.InstanceName = "";
			this.LoButton.Name = "LoButton";
			this.LoButton.NameSpace = "SE.App2CommonProcess";
			this.LoButton.ROCAlarmParameters.DecimalPlacesCount = ((uint)(2u));
			this.LoButton.ROCAlarmParameters.MaxLimitValue = 100F;
			this.LoButton.ROCAlarmParameters.MinLimitValue = 0F;
			this.LoButton.ROCIndicatorParameters.DecimalPlacesCount = ((uint)(2u));
			this.LoButton.ROCIndicatorParameters.MaxLimitValue = 100F;
			this.LoButton.ROCIndicatorParameters.MinLimitValue = 0F;
			this.LoButton.SymbolType = "";
			this.LoButton.Tooltip = "Low";
			this.LoButton.OnServiceStateChanged += new SE.App2Base.SupportClasses.ServiceStateChanged(this.LoButtonAvailableChanged);
			this.LoButton.EndInit();
			// 
			// LoLoButton
			// 
			this.LoLoButton.BeginInit();
			this.LoLoButton.AlarmName = "TxtLoLo";
			this.LoLoButton.BasicParameters.DecimalPlacesCount = ((uint)(2u));
			this.LoLoButton.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 181D, 141D);
			this.LoLoButton.DevIndicatorParameters.MaxLimitValue = 100F;
			this.LoLoButton.DevIndicatorParameters.MinLimitValue = 0F;
			this.LoLoButton.IndicatorParameters.IndicatorBrush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(234)), ((byte)(22)), ((byte)(30))), new NxtControl.Drawing.GradientFill(NxtControl.Drawing.GradientFillOrientation.HorizontalRight, NxtControl.Drawing.GradientFillBrightness.Light));
			this.LoLoButton.IndicatorParameters.MaxLimitValue = 100F;
			this.LoLoButton.IndicatorParameters.MinLimitValue = 0F;
			this.LoLoButton.InstanceName = "";
			this.LoLoButton.Name = "LoLoButton";
			this.LoLoButton.NameSpace = "SE.App2CommonProcess";
			this.LoLoButton.ROCAlarmParameters.DecimalPlacesCount = ((uint)(2u));
			this.LoLoButton.ROCAlarmParameters.MaxLimitValue = 100F;
			this.LoLoButton.ROCAlarmParameters.MinLimitValue = 0F;
			this.LoLoButton.ROCIndicatorParameters.DecimalPlacesCount = ((uint)(2u));
			this.LoLoButton.ROCIndicatorParameters.MaxLimitValue = 100F;
			this.LoLoButton.ROCIndicatorParameters.MinLimitValue = 0F;
			this.LoLoButton.SymbolType = "";
			this.LoLoButton.Tooltip = "Low Low";
			this.LoLoButton.OnServiceStateChanged += new SE.App2Base.SupportClasses.ServiceStateChanged(this.LoLoButtonAvailableChanged);
			this.LoLoButton.EndInit();
			// 
			// HiIndicator
			// 
			this.HiIndicator.BeginInit();
			this.HiIndicator.BasicParameters.DecimalPlacesCount = ((uint)(2u));
			this.HiIndicator.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 102D, 135D);
			this.HiIndicator.DevIndicatorParameters.MaxLimitValue = 100F;
			this.HiIndicator.DevIndicatorParameters.MinLimitValue = 0F;
			this.HiIndicator.IndicatorParameters.IndicatorBrush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(234)), ((byte)(22)), ((byte)(30))), new NxtControl.Drawing.GradientFill(NxtControl.Drawing.GradientFillOrientation.HorizontalRight, NxtControl.Drawing.GradientFillBrightness.Light));
			this.HiIndicator.IndicatorParameters.MaxLimitValue = 100F;
			this.HiIndicator.IndicatorParameters.MinLimitValue = 0F;
			this.HiIndicator.InstanceName = "";
			this.HiIndicator.Name = "HiIndicator";
			this.HiIndicator.NameSpace = "SE.App2Base";
			this.HiIndicator.ROCAlarmParameters.DecimalPlacesCount = ((uint)(2u));
			this.HiIndicator.ROCAlarmParameters.MaxLimitValue = 100F;
			this.HiIndicator.ROCAlarmParameters.MinLimitValue = 0F;
			this.HiIndicator.ROCIndicatorParameters.DecimalPlacesCount = ((uint)(2u));
			this.HiIndicator.ROCIndicatorParameters.MaxLimitValue = 100F;
			this.HiIndicator.ROCIndicatorParameters.MinLimitValue = 0F;
			this.HiIndicator.SymbolType = "";
			this.HiIndicator.Tooltip = "High";
			this.HiIndicator.EndInit();
			// 
			// HiHiIndicator
			// 
			this.HiHiIndicator.BeginInit();
			this.HiHiIndicator.BasicParameters.DecimalPlacesCount = ((uint)(2u));
			this.HiHiIndicator.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 102D, 135D);
			this.HiHiIndicator.DevIndicatorParameters.MaxLimitValue = 100F;
			this.HiHiIndicator.DevIndicatorParameters.MinLimitValue = 0F;
			this.HiHiIndicator.IndicatorParameters.IndicatorBrush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(234)), ((byte)(22)), ((byte)(30))), new NxtControl.Drawing.GradientFill(NxtControl.Drawing.GradientFillOrientation.HorizontalRight, NxtControl.Drawing.GradientFillBrightness.Light));
			this.HiHiIndicator.IndicatorParameters.MaxLimitValue = 100F;
			this.HiHiIndicator.IndicatorParameters.MinLimitValue = 0F;
			this.HiHiIndicator.InstanceName = "";
			this.HiHiIndicator.Name = "HiHiIndicator";
			this.HiHiIndicator.NameSpace = "SE.App2Base";
			this.HiHiIndicator.ROCAlarmParameters.DecimalPlacesCount = ((uint)(2u));
			this.HiHiIndicator.ROCAlarmParameters.MaxLimitValue = 100F;
			this.HiHiIndicator.ROCAlarmParameters.MinLimitValue = 0F;
			this.HiHiIndicator.ROCIndicatorParameters.DecimalPlacesCount = ((uint)(2u));
			this.HiHiIndicator.ROCIndicatorParameters.MaxLimitValue = 100F;
			this.HiHiIndicator.ROCIndicatorParameters.MinLimitValue = 0F;
			this.HiHiIndicator.SymbolType = "";
			this.HiHiIndicator.Tooltip = "High High";
			this.HiHiIndicator.EndInit();
			// 
			// LoIndicator
			// 
			this.LoIndicator.BeginInit();
			this.LoIndicator.BasicParameters.DecimalPlacesCount = ((uint)(2u));
			this.LoIndicator.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 102D, 135D);
			this.LoIndicator.DevIndicatorParameters.MaxLimitValue = 100F;
			this.LoIndicator.DevIndicatorParameters.MinLimitValue = 0F;
			this.LoIndicator.IndicatorParameters.IndicatorBrush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(234)), ((byte)(22)), ((byte)(30))), new NxtControl.Drawing.GradientFill(NxtControl.Drawing.GradientFillOrientation.HorizontalRight, NxtControl.Drawing.GradientFillBrightness.Light));
			this.LoIndicator.IndicatorParameters.MaxLimitValue = 100F;
			this.LoIndicator.IndicatorParameters.MinLimitValue = 0F;
			this.LoIndicator.InstanceName = "";
			this.LoIndicator.Name = "LoIndicator";
			this.LoIndicator.NameSpace = "SE.App2Base";
			this.LoIndicator.ROCAlarmParameters.DecimalPlacesCount = ((uint)(2u));
			this.LoIndicator.ROCAlarmParameters.MaxLimitValue = 100F;
			this.LoIndicator.ROCAlarmParameters.MinLimitValue = 0F;
			this.LoIndicator.ROCIndicatorParameters.DecimalPlacesCount = ((uint)(2u));
			this.LoIndicator.ROCIndicatorParameters.MaxLimitValue = 100F;
			this.LoIndicator.ROCIndicatorParameters.MinLimitValue = 0F;
			this.LoIndicator.SymbolType = "";
			this.LoIndicator.Tooltip = "Low";
			this.LoIndicator.EndInit();
			// 
			// LoLoIndicator
			// 
			this.LoLoIndicator.BeginInit();
			this.LoLoIndicator.BasicParameters.DecimalPlacesCount = ((uint)(2u));
			this.LoLoIndicator.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 102D, 135D);
			this.LoLoIndicator.DevIndicatorParameters.MaxLimitValue = 100F;
			this.LoLoIndicator.DevIndicatorParameters.MinLimitValue = 0F;
			this.LoLoIndicator.IndicatorParameters.IndicatorBrush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(234)), ((byte)(22)), ((byte)(30))), new NxtControl.Drawing.GradientFill(NxtControl.Drawing.GradientFillOrientation.HorizontalRight, NxtControl.Drawing.GradientFillBrightness.Light));
			this.LoLoIndicator.IndicatorParameters.MaxLimitValue = 100F;
			this.LoLoIndicator.IndicatorParameters.MinLimitValue = 0F;
			this.LoLoIndicator.InstanceName = "";
			this.LoLoIndicator.Name = "LoLoIndicator";
			this.LoLoIndicator.NameSpace = "SE.App2Base";
			this.LoLoIndicator.ROCAlarmParameters.DecimalPlacesCount = ((uint)(2u));
			this.LoLoIndicator.ROCAlarmParameters.MaxLimitValue = 100F;
			this.LoLoIndicator.ROCAlarmParameters.MinLimitValue = 0F;
			this.LoLoIndicator.ROCIndicatorParameters.DecimalPlacesCount = ((uint)(2u));
			this.LoLoIndicator.ROCIndicatorParameters.MaxLimitValue = 100F;
			this.LoLoIndicator.ROCIndicatorParameters.MinLimitValue = 0F;
			this.LoLoIndicator.SymbolType = "";
			this.LoLoIndicator.Tooltip = "Low Low";
			this.LoLoIndicator.EndInit();
			// 
			// RocButton
			// 
			this.RocButton.BeginInit();
			this.RocButton.AlarmName = "TxtRoc";
			this.RocButton.BasicParameters.DecimalPlacesCount = ((uint)(2u));
			this.RocButton.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 181D, 141D);
			this.RocButton.DevIndicatorParameters.MaxLimitValue = 100F;
			this.RocButton.DevIndicatorParameters.MinLimitValue = 0F;
			this.RocButton.IndicatorParameters.IndicatorBrush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(234)), ((byte)(22)), ((byte)(30))), new NxtControl.Drawing.GradientFill(NxtControl.Drawing.GradientFillOrientation.HorizontalRight, NxtControl.Drawing.GradientFillBrightness.Light));
			this.RocButton.IndicatorParameters.MaxLimitValue = 100F;
			this.RocButton.IndicatorParameters.MinLimitValue = 0F;
			this.RocButton.InstanceName = "";
			this.RocButton.Name = "RocButton";
			this.RocButton.NameSpace = "SE.App2CommonProcess";
			this.RocButton.ROCAlarmParameters.DecimalPlacesCount = ((uint)(2u));
			this.RocButton.ROCAlarmParameters.MaxLimitValue = 100F;
			this.RocButton.ROCAlarmParameters.MinLimitValue = 0F;
			this.RocButton.ROCIndicatorParameters.DecimalPlacesCount = ((uint)(2u));
			this.RocButton.ROCIndicatorParameters.MaxLimitValue = 100F;
			this.RocButton.ROCIndicatorParameters.MinLimitValue = 0F;
			this.RocButton.SymbolType = "";
			this.RocButton.Tooltip = "Rate of Change";
			this.RocButton.OnServiceStateChanged += new SE.App2Base.SupportClasses.ServiceStateChanged(this.RocButtonAvailableChanged);
			this.RocButton.EndInit();
			// 
			// DevButton
			// 
			this.DevButton.BeginInit();
			this.DevButton.AlarmName = "TxtDev";
			this.DevButton.BasicParameters.DecimalPlacesCount = ((uint)(2u));
			this.DevButton.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 181D, 141D);
			this.DevButton.DevIndicatorParameters.MaxLimitValue = 100F;
			this.DevButton.DevIndicatorParameters.MinLimitValue = 0F;
			this.DevButton.IndicatorParameters.IndicatorBrush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(234)), ((byte)(22)), ((byte)(30))), new NxtControl.Drawing.GradientFill(NxtControl.Drawing.GradientFillOrientation.HorizontalRight, NxtControl.Drawing.GradientFillBrightness.Light));
			this.DevButton.IndicatorParameters.MaxLimitValue = 100F;
			this.DevButton.IndicatorParameters.MinLimitValue = 0F;
			this.DevButton.InstanceName = "";
			this.DevButton.Name = "DevButton";
			this.DevButton.NameSpace = "SE.App2CommonProcess";
			this.DevButton.ROCAlarmParameters.DecimalPlacesCount = ((uint)(2u));
			this.DevButton.ROCAlarmParameters.MaxLimitValue = 100F;
			this.DevButton.ROCAlarmParameters.MinLimitValue = 0F;
			this.DevButton.ROCIndicatorParameters.DecimalPlacesCount = ((uint)(2u));
			this.DevButton.ROCIndicatorParameters.MaxLimitValue = 100F;
			this.DevButton.ROCIndicatorParameters.MinLimitValue = 0F;
			this.DevButton.SymbolType = "";
			this.DevButton.Tooltip = "Deviation";
			this.DevButton.OnServiceStateChanged += new SE.App2Base.SupportClasses.ServiceStateChanged(this.DevButtonAvailableChanged);
			this.DevButton.EndInit();
			// 
			// RocIndicator
			// 
			this.RocIndicator.BeginInit();
			this.RocIndicator.BasicParameters.DecimalPlacesCount = ((uint)(2u));
			this.RocIndicator.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 19D, 345D);
			this.RocIndicator.DevIndicatorParameters.MaxLimitValue = 100F;
			this.RocIndicator.DevIndicatorParameters.MinLimitValue = 0F;
			this.RocIndicator.IndicatorParameters.IndicatorBrush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(234)), ((byte)(22)), ((byte)(30))), new NxtControl.Drawing.GradientFill(NxtControl.Drawing.GradientFillOrientation.HorizontalRight, NxtControl.Drawing.GradientFillBrightness.Light));
			this.RocIndicator.IndicatorParameters.MaxLimitValue = 100F;
			this.RocIndicator.IndicatorParameters.MinLimitValue = 0F;
			this.RocIndicator.InstanceName = "";
			this.RocIndicator.Name = "RocIndicator";
			this.RocIndicator.NameSpace = "SE.App2Base";
			this.RocIndicator.ROCAlarmParameters.DecimalPlacesCount = ((uint)(2u));
			this.RocIndicator.ROCAlarmParameters.MaxLimitValue = 100F;
			this.RocIndicator.ROCAlarmParameters.MinLimitValue = 0F;
			this.RocIndicator.ROCIndicatorParameters.DecimalPlacesCount = ((uint)(2u));
			this.RocIndicator.ROCIndicatorParameters.MaxLimitValue = 100F;
			this.RocIndicator.ROCIndicatorParameters.MinLimitValue = 0F;
			this.RocIndicator.SymbolType = "";
			this.RocIndicator.Tooltip = "Rate of Change";
			this.RocIndicator.EndInit();
			// 
			// DevIndicator
			// 
			this.DevIndicator.BeginInit();
			this.DevIndicator.BasicParameters.DecimalPlacesCount = ((uint)(2u));
			this.DevIndicator.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 64D, 135D);
			this.DevIndicator.DevIndicatorParameters.MaxLimitValue = 100F;
			this.DevIndicator.DevIndicatorParameters.MinLimitValue = 0F;
			this.DevIndicator.IndicatorParameters.IndicatorBrush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(234)), ((byte)(22)), ((byte)(30))), new NxtControl.Drawing.GradientFill(NxtControl.Drawing.GradientFillOrientation.HorizontalRight, NxtControl.Drawing.GradientFillBrightness.Light));
			this.DevIndicator.IndicatorParameters.MaxLimitValue = 100F;
			this.DevIndicator.IndicatorParameters.MinLimitValue = 0F;
			this.DevIndicator.InstanceName = "";
			this.DevIndicator.Name = "DevIndicator";
			this.DevIndicator.NameSpace = "SE.App2Base";
			this.DevIndicator.ROCAlarmParameters.DecimalPlacesCount = ((uint)(2u));
			this.DevIndicator.ROCAlarmParameters.MaxLimitValue = 100F;
			this.DevIndicator.ROCAlarmParameters.MinLimitValue = 0F;
			this.DevIndicator.ROCIndicatorParameters.DecimalPlacesCount = ((uint)(2u));
			this.DevIndicator.ROCIndicatorParameters.MaxLimitValue = 100F;
			this.DevIndicator.ROCIndicatorParameters.MinLimitValue = 0F;
			this.DevIndicator.SymbolType = "";
			this.DevIndicator.Tooltip = "Deviation";
			this.DevIndicator.EndInit();
			// 
			// fpDefault
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(270D)), ((float)(392D)));
			this.Brush = new NxtControl.Drawing.Brush("FpBackgroundBrush");
			this.FormBorderStyle = NxtControl.GuiFramework.FormBorderStyle.FixedSingle;
			this.SecurityToken = ((uint)(4294967175u));
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.execPv,
			this.execPvMin,
			this.execPvMax,
			this.execCurrentMode,
			this.Scale,
			this.line1,
			this.lblPv,
			this.lblPvMin,
			this.lblPvMax,
			this.SMeters1,
			this.labelS1,
			this.fpNavigationPane,
			this.Over,
			this.HiButton,
			this.HiHiButton,
			this.LoButton,
			this.LoLoButton,
			this.HiIndicator,
			this.HiHiIndicator,
			this.LoIndicator,
			this.LoLoIndicator,
			this.RocButton,
			this.DevButton,
			this.RocIndicator,
			this.DevIndicator});
			this.Size = new System.Drawing.Size(270, 392);
			this.UpdateOptionalService += new SE.App2Base.Faceplates.SEAppLibHMIFaceplate.OnUpdateOptionalService(this.FpDefaultUpdateOptionalService);

		}
		private System.HMI.Symbols.Base.Execute<float> execPv;
		private System.HMI.Symbols.Base.Execute<float> execPvMin;
		private System.HMI.Symbols.Base.Execute<float> execPvMax;
		private System.HMI.Symbols.Base.Execute<ushort> execCurrentMode;
		private System.HMI.Symbols.Base.Execute<bool> Scale;
		private NxtControl.GuiFramework.Line line1;
		private NxtControl.GuiFramework.Label lblPvMin;
		private NxtControl.GuiFramework.Label lblPvMax;
		private System.HMI.Symbols.Base.Label<float> lblPv;
		private SE.App2Base.Graphics.SMeters SMeters1;
		private SE.App2Base.Graphics.LabelS labelS1;
		private SE.App2Base.Graphics.FpNavigationPane fpNavigationPane;
		private System.HMI.Symbols.Base.Execute<bool> Over;
		private SE.App2Base.Graphics.LimitAlarm LoLoButton;
		private SE.App2Base.Graphics.LimitAlarm LoButton;
		private SE.App2Base.Graphics.LimitAlarm HiHiButton;
		private SE.App2Base.Graphics.LimitAlarm HiButton;
		private SE.App2Base.Graphics.LimitAlarm DevIndicator;
		private SE.App2Base.Graphics.LimitAlarm RocButton;
		private SE.App2Base.Graphics.LimitAlarm DevButton;
		private SE.App2Base.Graphics.LimitAlarm HiIndicator;
		private SE.App2Base.Graphics.LimitAlarm HiHiIndicator;
		private SE.App2Base.Graphics.LimitAlarm LoIndicator;
		private SE.App2Base.Graphics.LimitAlarm LoLoIndicator;
		private SE.App2Base.Graphics.LimitAlarm RocIndicator;
		#endregion
	}
}



