using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using NxtControl.GuiFramework;

namespace SE.Nereda.Faceplates.AnalogInputBase
{
	/// <summary>
	/// Summary description for fpParameter.
	/// </summary>
	partial class fpParameter
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
			this.txtMinPv = new System.HMI.Symbols.Base.TextBox<float>();
			this.txtMaxPv = new System.HMI.Symbols.Base.TextBox<float>();
			this.txtPvOffset = new System.HMI.Symbols.Base.TextBox<float>();
			this.txtFilterTime = new System.HMI.Symbols.Base.TextBox<int>();
			this.EnScaleBtn = new System.HMI.Symbols.Base.SwitchButton();
			this.txtPt1CycleTime = new System.HMI.Symbols.Base.TextBox<int>();
			this.txtPvCutOff = new System.HMI.Symbols.Base.TextBox<float>();
			this.txtoverridevalue = new System.HMI.Symbols.Base.TextBox<float>();
			this.txtMinRaw = new System.HMI.Symbols.Base.TextBox<float>();
			this.txtMaxRaw = new System.HMI.Symbols.Base.TextBox<float>();
			this.Override = new System.HMI.Symbols.Base.SwitchButton();
			this.txtPvBad = new System.HMI.Symbols.Base.TextBox<float>();
			this.SelectBad = new System.HMI.Symbols.Base.DropDown<short>();
			this.lblPvField = new System.HMI.Symbols.Base.Label<float>();
			this.BadPvSel = new System.HMI.Symbols.Base.Execute<short>();
			this.Execover = new System.HMI.Symbols.Base.Execute<bool>();
			this.Pv = new System.HMI.Symbols.Base.Execute<float>();
			this.UseLimitsBtn = new System.HMI.Symbols.Base.SwitchButton();
			this.SmoothType = new NxtControl.GuiFramework.DrawnComboBox();
			this.TimeDiff = new System.HMI.Symbols.Base.TextBox<int>();
			this.ValDiff = new System.HMI.Symbols.Base.TextBox<float>();
			this.execute_11 = new System.HMI.Symbols.Base.Execute<byte>();
			this.labelS1 = new SE.App2Base.Graphics.LabelS();
			this.labelS2 = new SE.App2Base.Graphics.LabelS();
			this.labelS3 = new SE.App2Base.Graphics.LabelS();
			this.labelS4 = new SE.App2Base.Graphics.LabelS();
			this.labelS5 = new SE.App2Base.Graphics.LabelS();
			this.labelS6 = new SE.App2Base.Graphics.LabelS();
			this.labelS7 = new SE.App2Base.Graphics.LabelS();
			this.labelS8 = new SE.App2Base.Graphics.LabelS();
			this.labelS10 = new SE.App2Base.Graphics.LabelS();
			this.labelS11 = new SE.App2Base.Graphics.LabelS();
			this.labelS12 = new SE.App2Base.Graphics.LabelS();
			this.labelS13 = new SE.App2Base.Graphics.LabelS();
			this.labelS14 = new SE.App2Base.Graphics.LabelS();
			this.labelS15 = new SE.App2Base.Graphics.LabelS();
			this.labelS16 = new SE.App2Base.Graphics.LabelS();
			this.labelS17 = new SE.App2Base.Graphics.LabelS();
			this.labelS18 = new SE.App2Base.Graphics.LabelS();
			this.labelS19 = new SE.App2Base.Graphics.LabelS();
			this.PvMin = new System.HMI.Symbols.Base.Execute<float>();
			this.PvMax = new System.HMI.Symbols.Base.Execute<float>();
			// 
			// txtMinPv
			// 
			this.txtMinPv.BeginInit();
			this.txtMinPv.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.63333333333333341D, 0D, 0D, 1D, 120D, 129D);
			this.txtMinPv.MaximumTag = null;
			this.txtMinPv.MinimumTag = null;
			this.txtMinPv.Name = "txtMinPv";
			this.txtMinPv.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.txtMinPv.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.txtMinPv.SecurityLevel = 6;
			this.txtMinPv.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.txtMinPv.TagName = "PvMin";
			this.txtMinPv.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.txtMinPv.UseInputPad = true;
			this.txtMinPv.Value = 0F;
			this.txtMinPv.EndInit();
			// 
			// txtMaxPv
			// 
			this.txtMaxPv.BeginInit();
			this.txtMaxPv.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.63333333333333341D, 0D, 0D, 1D, 120D, 159D);
			this.txtMaxPv.MaximumTag = null;
			this.txtMaxPv.MinimumTag = null;
			this.txtMaxPv.Name = "txtMaxPv";
			this.txtMaxPv.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.txtMaxPv.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.txtMaxPv.SecurityLevel = 6;
			this.txtMaxPv.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.txtMaxPv.TagName = "PvMax";
			this.txtMaxPv.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.txtMaxPv.UseInputPad = true;
			this.txtMaxPv.Value = 0F;
			this.txtMaxPv.EndInit();
			// 
			// txtPvOffset
			// 
			this.txtPvOffset.BeginInit();
			this.txtPvOffset.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.63333333333333341D, 0D, 0D, 1D, 120D, 219D);
			this.txtPvOffset.MaximumTag = null;
			this.txtPvOffset.MinimumTag = null;
			this.txtPvOffset.Name = "txtPvOffset";
			this.txtPvOffset.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.txtPvOffset.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.txtPvOffset.SecurityLevel = 12;
			this.txtPvOffset.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.txtPvOffset.TagName = "PvOffset";
			this.txtPvOffset.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.txtPvOffset.UseInputPad = true;
			this.txtPvOffset.Value = 0F;
			this.txtPvOffset.EndInit();
			// 
			// txtFilterTime
			// 
			this.txtFilterTime.BeginInit();
			this.txtFilterTime.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.63333333333333341D, 0D, 0D, 1D, 120D, 249D);
			this.txtFilterTime.MaximumTag = null;
			this.txtFilterTime.MinimumTag = null;
			this.txtFilterTime.Name = "txtFilterTime";
			this.txtFilterTime.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.txtFilterTime.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.txtFilterTime.SecurityLevel = 12;
			this.txtFilterTime.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.txtFilterTime.Suffix = "s";
			this.txtFilterTime.TagName = "Pt1FTime";
			this.txtFilterTime.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.txtFilterTime.UseInputPad = true;
			this.txtFilterTime.Value = 0;
			this.txtFilterTime.EndInit();
			// 
			// EnScaleBtn
			// 
			this.EnScaleBtn.BeginInit();
			this.EnScaleBtn.DesignMatrix = new NxtControl.Drawing.Matrix2D(1.4750000000000003D, 0D, 0D, 0.83333333333333337D, 120D, 9D);
			this.EnScaleBtn.FalseBrush = new NxtControl.Drawing.Brush("ButtonBrush");
			this.EnScaleBtn.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.EnScaleBtn.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.EnScaleBtn.FalseText = "$key:SE.App2CommonProcess.TxtDisable";
			this.EnScaleBtn.FalseTextKey = "SE.App2CommonProcess.TxtDisable";
			this.EnScaleBtn.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.EnScaleBtn.Name = "EnScaleBtn";
			this.EnScaleBtn.SecurityLevel = 0;
			this.EnScaleBtn.TagName = "EnScale";
			this.EnScaleBtn.TrueBrush = new NxtControl.Drawing.Brush("ButtonBrush");
			this.EnScaleBtn.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.EnScaleBtn.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.EnScaleBtn.TrueText = "$key:SE.App2CommonProcess.TxtEnable";
			this.EnScaleBtn.TrueTextKey = "SE.App2CommonProcess.TxtEnable";
			this.EnScaleBtn.Value = false;
			this.EnScaleBtn.EndInit();
			// 
			// txtPt1CycleTime
			// 
			this.txtPt1CycleTime.BeginInit();
			this.txtPt1CycleTime.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.63333333333333341D, 0D, 0D, 1D, 120D, 279D);
			this.txtPt1CycleTime.MaximumTag = null;
			this.txtPt1CycleTime.MinimumTag = null;
			this.txtPt1CycleTime.Name = "txtPt1CycleTime";
			this.txtPt1CycleTime.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.txtPt1CycleTime.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.txtPt1CycleTime.SecurityLevel = 12;
			this.txtPt1CycleTime.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.txtPt1CycleTime.Suffix = "ms";
			this.txtPt1CycleTime.TagName = "Pt1CycleTime";
			this.txtPt1CycleTime.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.txtPt1CycleTime.UseInputPad = true;
			this.txtPt1CycleTime.Value = 0;
			this.txtPt1CycleTime.EndInit();
			// 
			// txtPvCutOff
			// 
			this.txtPvCutOff.BeginInit();
			this.txtPvCutOff.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.63333333333333341D, 0D, 0D, 1D, 120D, 189D);
			this.txtPvCutOff.MaximumTag = null;
			this.txtPvCutOff.MinimumTag = null;
			this.txtPvCutOff.Name = "txtPvCutOff";
			this.txtPvCutOff.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.txtPvCutOff.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.txtPvCutOff.SecurityLevel = 12;
			this.txtPvCutOff.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.txtPvCutOff.TagName = "PvCutOff";
			this.txtPvCutOff.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.txtPvCutOff.UseInputPad = true;
			this.txtPvCutOff.Value = 0F;
			this.txtPvCutOff.EndInit();
			// 
			// txtoverridevalue
			// 
			this.txtoverridevalue.BeginInit();
			this.txtoverridevalue.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.63333333333333341D, 0D, 0D, 1D, 120D, 489D);
			this.txtoverridevalue.MaximumTag = null;
			this.txtoverridevalue.MinimumTag = null;
			this.txtoverridevalue.Name = "txtoverridevalue";
			this.txtoverridevalue.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.txtoverridevalue.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.txtoverridevalue.SecurityLevel = 0;
			this.txtoverridevalue.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.txtoverridevalue.TagName = "PvOverrideVal";
			this.txtoverridevalue.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.txtoverridevalue.UseInputPad = true;
			this.txtoverridevalue.UseRange = true;
			this.txtoverridevalue.Value = 0F;
			this.txtoverridevalue.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.PvOverrideValValueChanged);
			this.txtoverridevalue.EndInit();
			// 
			// txtMinRaw
			// 
			this.txtMinRaw.BeginInit();
			this.txtMinRaw.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.63333333333333341D, 0D, 0D, 1D, 120D, 69D);
			this.txtMinRaw.MaximumTag = null;
			this.txtMinRaw.MinimumTag = null;
			this.txtMinRaw.Name = "txtMinRaw";
			this.txtMinRaw.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.txtMinRaw.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.txtMinRaw.SecurityLevel = 6;
			this.txtMinRaw.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.txtMinRaw.TagName = "RawPvMin";
			this.txtMinRaw.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.txtMinRaw.UseInputPad = true;
			this.txtMinRaw.Value = 0F;
			this.txtMinRaw.EndInit();
			// 
			// txtMaxRaw
			// 
			this.txtMaxRaw.BeginInit();
			this.txtMaxRaw.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.63333333333333341D, 0D, 0D, 1D, 120D, 99D);
			this.txtMaxRaw.MaximumTag = null;
			this.txtMaxRaw.MinimumTag = null;
			this.txtMaxRaw.Name = "txtMaxRaw";
			this.txtMaxRaw.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.txtMaxRaw.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.txtMaxRaw.SecurityLevel = 6;
			this.txtMaxRaw.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.txtMaxRaw.TagName = "RawPvMax";
			this.txtMaxRaw.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.txtMaxRaw.UseInputPad = true;
			this.txtMaxRaw.Value = 0F;
			this.txtMaxRaw.EndInit();
			// 
			// Override
			// 
			this.Override.BeginInit();
			this.Override.DesignMatrix = new NxtControl.Drawing.Matrix2D(1.4750000000000003D, 0D, 0D, 0.83333333333333337D, 120D, 460D);
			this.Override.FalseBrush = new NxtControl.Drawing.Brush("ButtonBrush");
			this.Override.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.Override.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.Override.FalseText = "$key:SE.App2CommonProcess.TxtDisable";
			this.Override.FalseTextKey = "SE.App2CommonProcess.TxtDisable";
			this.Override.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.Override.Name = "Override";
			this.Override.SecurityLevel = 0;
			this.Override.TagName = "PvOverride";
			this.Override.TrueBrush = new NxtControl.Drawing.Brush("ButtonBrush");
			this.Override.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.Override.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.Override.TrueText = "$key:SE.App2CommonProcess.TxtEnable";
			this.Override.TrueTextKey = "SE.App2CommonProcess.TxtEnable";
			this.Override.Value = false;
			this.Override.EndInit();
			// 
			// txtPvBad
			// 
			this.txtPvBad.BeginInit();
			this.txtPvBad.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.63333333333333341D, 0D, 0D, 1D, 120D, 430D);
			this.txtPvBad.MaximumTag = null;
			this.txtPvBad.MinimumTag = null;
			this.txtPvBad.Name = "txtPvBad";
			this.txtPvBad.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.txtPvBad.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.txtPvBad.SecurityLevel = 12;
			this.txtPvBad.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.txtPvBad.TagName = "BadPv";
			this.txtPvBad.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.txtPvBad.UseInputPad = true;
			this.txtPvBad.Value = 0F;
			this.txtPvBad.EndInit();
			// 
			// SelectBad
			// 
			this.SelectBad.BeginInit();
			this.SelectBad.Brush = new NxtControl.Drawing.Brush("ComboBoxBrush");
			this.SelectBad.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.79751511962070076D, 0D, 0D, 1D, 120D, 400D);
			this.SelectBad.Font = new NxtControl.Drawing.Font("ComboBoxFont");
			this.SelectBad.Name = "SelectBad";
			this.SelectBad.SecurityLevel = 12;
			this.SelectBad.TagName = "BadPvSel";
			this.SelectBad.TextColor = new NxtControl.Drawing.Color("ComboBoxTextColor");
			this.SelectBad.TextPadding = new NxtControl.Drawing.Padding(2);
			this.SelectBad.Value = ((short)(0));
			this.SelectBad.EndInit();
			// 
			// lblPvField
			// 
			this.lblPvField.BeginInit();
			this.lblPvField.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lblPvField.DecimalPlacesCount = ((uint)(2u));
			this.lblPvField.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.78666666666666663D, 0D, 0D, 0.76190476190476186D, 120D, 523D);
			this.lblPvField.Font = new NxtControl.Drawing.Font("SE.App2Base.Pv");
			this.lblPvField.FontScale = false;
			this.lblPvField.IsOnlyInput = true;
			this.lblPvField.IsPrefixSuffixOutside = false;
			this.lblPvField.LeadingZeros = ((uint)(0u));
			this.lblPvField.Name = "lblPvField";
			this.lblPvField.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.lblPvField.Ranges.Clear();
			this.lblPvField.Ranges.Add(new NxtControl.GuiFramework.Range<float>(null, true, null, true, propertyDictionary2));
			propertyDictionary1.Add("Text", "${Value}");
			propertyDictionary1.Add("TextColor", new NxtControl.Drawing.Color("SE.App2Base.aaLibFpData"));
			propertyDictionary1.Add("Brush", new NxtControl.Drawing.Brush(true));
			propertyDictionary1.Add("Pen", new NxtControl.Drawing.Pen("ComboBoxPen"));
			this.lblPvField.Ranges.DefaultPropertyValues = propertyDictionary1;
			this.lblPvField.TagName = "InputValue";
			this.lblPvField.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.lblPvField.EndInit();
			// 
			// BadPvSel
			// 
			this.BadPvSel.BeginInit();
			this.BadPvSel.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.BadPvSel.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.BadPvSel.Name = "BadPvSel";
			this.BadPvSel.SecurityLevel = 0;
			this.BadPvSel.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.BadPvSel.TagName = "BadPvSel";
			this.BadPvSel.Value = ((short)(0));
			this.BadPvSel.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.BadPvSelValueChanged);
			this.BadPvSel.EndInit();
			// 
			// Execover
			// 
			this.Execover.BeginInit();
			this.Execover.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.Execover.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.Execover.Name = "Execover";
			this.Execover.SecurityLevel = 0;
			this.Execover.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.Execover.TagName = "PvOverride";
			this.Execover.Value = false;
			this.Execover.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.ExecOverValueChanged);
			this.Execover.EndInit();
			// 
			// Pv
			// 
			this.Pv.BeginInit();
			this.Pv.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.Pv.IsOnlyInput = true;
			this.Pv.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.Pv.Name = "Pv";
			this.Pv.SecurityLevel = 0;
			this.Pv.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.Pv.TagName = "Pv";
			this.Pv.Value = 0F;
			this.Pv.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.PvValueChanged);
			this.Pv.EndInit();
			// 
			// UseLimitsBtn
			// 
			this.UseLimitsBtn.BeginInit();
			this.UseLimitsBtn.DesignMatrix = new NxtControl.Drawing.Matrix2D(1.4750000000000003D, 0D, 0D, 0.83333333333333337D, 120D, 39D);
			this.UseLimitsBtn.FalseBrush = new NxtControl.Drawing.Brush("ButtonBrush");
			this.UseLimitsBtn.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.UseLimitsBtn.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.UseLimitsBtn.FalseText = "$key:SE.App2CommonProcess.TxtDisable";
			this.UseLimitsBtn.FalseTextKey = "SE.App2CommonProcess.TxtDisable";
			this.UseLimitsBtn.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.UseLimitsBtn.Name = "UseLimitsBtn";
			this.UseLimitsBtn.SecurityLevel = 0;
			this.UseLimitsBtn.TagName = "UseLimits";
			this.UseLimitsBtn.TrueBrush = new NxtControl.Drawing.Brush("ButtonBrush");
			this.UseLimitsBtn.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.UseLimitsBtn.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.UseLimitsBtn.TrueText = "$key:SE.App2CommonProcess.TxtEnable";
			this.UseLimitsBtn.TrueTextKey = "SE.App2CommonProcess.TxtEnable";
			this.UseLimitsBtn.Value = false;
			this.UseLimitsBtn.EndInit();
			// 
			// SmoothType
			// 
			this.SmoothType.Bounds = new NxtControl.Drawing.RectF(((float)(120D)), ((float)(309D)), ((float)(119.62726593017578D)), ((float)(25D)));
			this.SmoothType.Brush = new NxtControl.Drawing.Brush("ComboboxBrush");
			this.SmoothType.Name = "SmoothType";
			this.SmoothType.Pen = new NxtControl.Drawing.Pen("ComboBoxPen");
			this.SmoothType.SelectedIndex = -1;
			this.SmoothType.TextColor = new NxtControl.Drawing.Color("ComboboxTextColor");
			this.SmoothType.TextPadding = new NxtControl.Drawing.Padding(2);
			this.SmoothType.SelectedIndexChanged += new System.EventHandler(this.SmoothTypeSelectedIndexChanged);
			// 
			// TimeDiff
			// 
			this.TimeDiff.BeginInit();
			this.TimeDiff.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.63333333333333341D, 0D, 0D, 1D, 120D, 338D);
			this.TimeDiff.MaximumTag = null;
			this.TimeDiff.MinimumTag = null;
			this.TimeDiff.Name = "TimeDiff";
			this.TimeDiff.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.TimeDiff.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.TimeDiff.SecurityLevel = 12;
			this.TimeDiff.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.TimeDiff.Suffix = "ms";
			this.TimeDiff.TagName = "TimeDiff";
			this.TimeDiff.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.TimeDiff.UseInputPad = true;
			this.TimeDiff.Value = 0;
			this.TimeDiff.EndInit();
			// 
			// ValDiff
			// 
			this.ValDiff.BeginInit();
			this.ValDiff.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.6333333333333333D, 0D, 0D, 1D, 120D, 369D);
			this.ValDiff.MaximumTag = null;
			this.ValDiff.MinimumTag = null;
			this.ValDiff.Name = "ValDiff";
			this.ValDiff.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.ValDiff.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.ValDiff.SecurityLevel = 6;
			this.ValDiff.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.ValDiff.TagName = "ValDiff";
			this.ValDiff.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.ValDiff.UseInputPad = true;
			this.ValDiff.Value = 0F;
			this.ValDiff.EndInit();
			// 
			// execute_11
			// 
			this.execute_11.BeginInit();
			this.execute_11.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.execute_11.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.execute_11.Name = "execute_11";
			this.execute_11.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.execute_11.TagName = "SmoothType";
			this.execute_11.Value = ((byte)(0));
			this.execute_11.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.SmoothValueChanged);
			this.execute_11.EndInit();
			// 
			// labelS1
			// 
			this.labelS1.BeginInit();
			this.labelS1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 5D, 9D);
			this.labelS1.Font = new NxtControl.Drawing.Font("SE.App2Base.LabelFont");
			this.labelS1.Name = "labelS1";
			this.labelS1.NameSpace = "SE.App2CommonProcess";
			this.labelS1.SeperatorVisiblity = true;
			this.labelS1.Text = "Enable Scale";
			this.labelS1.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.labelS1.TextColor = new NxtControl.Drawing.Color("FpLabelText");
			this.labelS1.TextKey = "LabelEnScale";
			this.labelS1.EndInit();
			// 
			// labelS2
			// 
			this.labelS2.BeginInit();
			this.labelS2.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 4D, 39D);
			this.labelS2.Font = new NxtControl.Drawing.Font("SE.App2Base.LabelFont");
			this.labelS2.Name = "labelS2";
			this.labelS2.NameSpace = "SE.App2CommonProcess";
			this.labelS2.SeperatorVisiblity = true;
			this.labelS2.Text = "Use Limits";
			this.labelS2.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.labelS2.TextColor = new NxtControl.Drawing.Color("FpLabelText");
			this.labelS2.TextKey = "LabelUseLimits";
			this.labelS2.EndInit();
			// 
			// labelS3
			// 
			this.labelS3.BeginInit();
			this.labelS3.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 5D, 70D);
			this.labelS3.Font = new NxtControl.Drawing.Font("SE.App2Base.LabelFont");
			this.labelS3.Name = "labelS3";
			this.labelS3.NameSpace = "SE.App2CommonProcess";
			this.labelS3.SeperatorVisiblity = true;
			this.labelS3.Text = "Min Raw";
			this.labelS3.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.labelS3.TextColor = new NxtControl.Drawing.Color("FpLabelText");
			this.labelS3.TextKey = "LabelMinRaw";
			this.labelS3.EndInit();
			// 
			// labelS4
			// 
			this.labelS4.BeginInit();
			this.labelS4.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 5D, 100D);
			this.labelS4.Font = new NxtControl.Drawing.Font("SE.App2Base.LabelFont");
			this.labelS4.Name = "labelS4";
			this.labelS4.NameSpace = "SE.App2CommonProcess";
			this.labelS4.SeperatorVisiblity = true;
			this.labelS4.Text = "Max Raw";
			this.labelS4.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.labelS4.TextColor = new NxtControl.Drawing.Color("FpLabelText");
			this.labelS4.TextKey = "LabelMaxRaw";
			this.labelS4.EndInit();
			// 
			// labelS5
			// 
			this.labelS5.BeginInit();
			this.labelS5.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 5D, 130D);
			this.labelS5.Font = new NxtControl.Drawing.Font("SE.App2Base.LabelFont");
			this.labelS5.Name = "labelS5";
			this.labelS5.NameSpace = "SE.App2CommonProcess";
			this.labelS5.SeperatorVisiblity = true;
			this.labelS5.Text = "Min Pv";
			this.labelS5.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.labelS5.TextColor = new NxtControl.Drawing.Color("FpLabelText");
			this.labelS5.TextKey = "LabelMinPv";
			this.labelS5.EndInit();
			// 
			// labelS6
			// 
			this.labelS6.BeginInit();
			this.labelS6.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 5D, 160D);
			this.labelS6.Font = new NxtControl.Drawing.Font("SE.App2Base.LabelFont");
			this.labelS6.Name = "labelS6";
			this.labelS6.NameSpace = "SE.App2CommonProcess";
			this.labelS6.SeperatorVisiblity = true;
			this.labelS6.Text = "Max Pv";
			this.labelS6.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.labelS6.TextColor = new NxtControl.Drawing.Color("FpLabelText");
			this.labelS6.TextKey = "LabelMaxPv";
			this.labelS6.EndInit();
			// 
			// labelS7
			// 
			this.labelS7.BeginInit();
			this.labelS7.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 5D, 190D);
			this.labelS7.Font = new NxtControl.Drawing.Font("SE.App2Base.LabelFont");
			this.labelS7.Name = "labelS7";
			this.labelS7.NameSpace = "SE.App2CommonProcess";
			this.labelS7.SeperatorVisiblity = true;
			this.labelS7.Text = "Cutoff Pv";
			this.labelS7.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.labelS7.TextColor = new NxtControl.Drawing.Color("FpLabelText");
			this.labelS7.TextKey = "LabelCutoff";
			this.labelS7.EndInit();
			// 
			// labelS8
			// 
			this.labelS8.BeginInit();
			this.labelS8.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 5D, 220D);
			this.labelS8.Font = new NxtControl.Drawing.Font("SE.App2Base.LabelFont");
			this.labelS8.Name = "labelS8";
			this.labelS8.NameSpace = "SE.App2CommonProcess";
			this.labelS8.SeperatorVisiblity = true;
			this.labelS8.Text = "Pv Offset";
			this.labelS8.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.labelS8.TextColor = new NxtControl.Drawing.Color("FpLabelText");
			this.labelS8.TextKey = "LabelOffset";
			this.labelS8.EndInit();
			// 
			// labelS10
			// 
			this.labelS10.BeginInit();
			this.labelS10.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 5D, 250D);
			this.labelS10.Font = new NxtControl.Drawing.Font("SE.App2Base.LabelFont");
			this.labelS10.Name = "labelS10";
			this.labelS10.NameSpace = "SE.App2CommonProcess";
			this.labelS10.SeperatorVisiblity = true;
			this.labelS10.Text = "Filter Time";
			this.labelS10.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.labelS10.TextColor = new NxtControl.Drawing.Color("FpLabelText");
			this.labelS10.TextKey = "LabelFilterTime";
			this.labelS10.EndInit();
			// 
			// labelS11
			// 
			this.labelS11.BeginInit();
			this.labelS11.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 5D, 280D);
			this.labelS11.Font = new NxtControl.Drawing.Font("SE.App2Base.LabelFont");
			this.labelS11.Name = "labelS11";
			this.labelS11.NameSpace = "SE.App2CommonProcess";
			this.labelS11.SeperatorVisiblity = true;
			this.labelS11.Text = "Cycle Time";
			this.labelS11.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.labelS11.TextColor = new NxtControl.Drawing.Color("FpLabelText");
			this.labelS11.TextKey = "LabelCycleTime";
			this.labelS11.EndInit();
			// 
			// labelS12
			// 
			this.labelS12.BeginInit();
			this.labelS12.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 5D, 309D);
			this.labelS12.Font = new NxtControl.Drawing.Font("SE.App2Base.LabelFont");
			this.labelS12.Name = "labelS12";
			this.labelS12.NameSpace = "SE.App2CommonProcess";
			this.labelS12.SeperatorVisiblity = true;
			this.labelS12.Text = "Smooth Type";
			this.labelS12.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.labelS12.TextColor = new NxtControl.Drawing.Color("FpLabelText");
			this.labelS12.TextKey = "LabelSmoothType";
			this.labelS12.EndInit();
			// 
			// labelS13
			// 
			this.labelS13.BeginInit();
			this.labelS13.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 5D, 338D);
			this.labelS13.Font = new NxtControl.Drawing.Font("SE.App2Base.LabelFont");
			this.labelS13.Name = "labelS13";
			this.labelS13.NameSpace = "SE.App2CommonProcess";
			this.labelS13.SeperatorVisiblity = true;
			this.labelS13.Text = "Time Difference";
			this.labelS13.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.labelS13.TextColor = new NxtControl.Drawing.Color("FpLabelText");
			this.labelS13.TextKey = "LabelTimeDifference";
			this.labelS13.EndInit();
			// 
			// labelS14
			// 
			this.labelS14.BeginInit();
			this.labelS14.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 5D, 370D);
			this.labelS14.Font = new NxtControl.Drawing.Font("SE.App2Base.LabelFont");
			this.labelS14.Name = "labelS14";
			this.labelS14.NameSpace = "SE.App2CommonProcess";
			this.labelS14.SeperatorVisiblity = true;
			this.labelS14.Text = "Value Difference";
			this.labelS14.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.labelS14.TextColor = new NxtControl.Drawing.Color("FpLabelText");
			this.labelS14.TextKey = "LabelValueDifference";
			this.labelS14.EndInit();
			// 
			// labelS15
			// 
			this.labelS15.BeginInit();
			this.labelS15.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 5D, 400D);
			this.labelS15.Font = new NxtControl.Drawing.Font("SE.App2Base.LabelFont");
			this.labelS15.Name = "labelS15";
			this.labelS15.NameSpace = "SE.App2CommonProcess";
			this.labelS15.SeperatorVisiblity = true;
			this.labelS15.Text = "Bad Pv Selection";
			this.labelS15.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.labelS15.TextColor = new NxtControl.Drawing.Color("FpLabelText");
			this.labelS15.TextKey = "BadPvSel";
			this.labelS15.EndInit();
			// 
			// labelS16
			// 
			this.labelS16.BeginInit();
			this.labelS16.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 5D, 430D);
			this.labelS16.Font = new NxtControl.Drawing.Font("SE.App2Base.LabelFont");
			this.labelS16.Name = "labelS16";
			this.labelS16.NameSpace = "SE.App2CommonProcess";
			this.labelS16.SeperatorVisiblity = true;
			this.labelS16.Text = "Bad Pv";
			this.labelS16.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.labelS16.TextColor = new NxtControl.Drawing.Color("FpLabelText");
			this.labelS16.TextKey = "BadPv";
			this.labelS16.EndInit();
			// 
			// labelS17
			// 
			this.labelS17.BeginInit();
			this.labelS17.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 5D, 460D);
			this.labelS17.Font = new NxtControl.Drawing.Font("SE.App2Base.LabelFont");
			this.labelS17.Name = "labelS17";
			this.labelS17.NameSpace = "SE.App2CommonProcess";
			this.labelS17.SeperatorVisiblity = true;
			this.labelS17.Text = "Override";
			this.labelS17.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.labelS17.TextColor = new NxtControl.Drawing.Color("FpLabelText");
			this.labelS17.TextKey = "LabelOverride";
			this.labelS17.EndInit();
			// 
			// labelS18
			// 
			this.labelS18.BeginInit();
			this.labelS18.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 5D, 490D);
			this.labelS18.Font = new NxtControl.Drawing.Font("SE.App2Base.LabelFont");
			this.labelS18.Name = "labelS18";
			this.labelS18.NameSpace = "SE.App2CommonProcess";
			this.labelS18.SeperatorVisiblity = true;
			this.labelS18.Text = "Override Value";
			this.labelS18.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.labelS18.TextColor = new NxtControl.Drawing.Color("FpLabelText");
			this.labelS18.TextKey = "LabelOverrideValue";
			this.labelS18.EndInit();
			// 
			// labelS19
			// 
			this.labelS19.BeginInit();
			this.labelS19.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 5D, 519D);
			this.labelS19.Font = new NxtControl.Drawing.Font("SE.App2Base.LabelFont");
			this.labelS19.Name = "labelS19";
			this.labelS19.NameSpace = "SE.App2CommonProcess";
			this.labelS19.SeperatorVisiblity = true;
			this.labelS19.Text = "Input Value";
			this.labelS19.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.labelS19.TextColor = new NxtControl.Drawing.Color("FpLabelText");
			this.labelS19.TextKey = "InputValue";
			this.labelS19.EndInit();
			// 
			// PvMin
			// 
			this.PvMin.BeginInit();
			this.PvMin.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.PvMin.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.PvMin.Name = "PvMin";
			this.PvMin.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.PvMin.TagName = "PvMin";
			this.PvMin.Value = 0F;
			this.PvMin.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.PvMinValueChanged);
			this.PvMin.EndInit();
			// 
			// PvMax
			// 
			this.PvMax.BeginInit();
			this.PvMax.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.PvMax.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.PvMax.Name = "PvMax";
			this.PvMax.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.PvMax.TagName = "PvMax";
			this.PvMax.Value = 0F;
			this.PvMax.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.PvMaxValueChanged);
			this.PvMax.EndInit();
			// 
			// fpParameter
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(267D)), ((float)(551D)));
			this.Brush = new NxtControl.Drawing.Brush("FpBackgroundBrush");
			this.FormBorderStyle = NxtControl.GuiFramework.FormBorderStyle.FixedSingle;
			this.SecurityToken = ((uint)(4294967175u));
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.Override,
			this.txtMinPv,
			this.txtMaxPv,
			this.txtPvOffset,
			this.txtFilterTime,
			this.EnScaleBtn,
			this.txtPt1CycleTime,
			this.txtPvCutOff,
			this.txtoverridevalue,
			this.txtMinRaw,
			this.txtMaxRaw,
			this.txtPvBad,
			this.SelectBad,
			this.lblPvField,
			this.BadPvSel,
			this.Execover,
			this.Pv,
			this.UseLimitsBtn,
			this.SmoothType,
			this.TimeDiff,
			this.ValDiff,
			this.execute_11,
			this.labelS1,
			this.labelS2,
			this.labelS3,
			this.labelS4,
			this.labelS5,
			this.labelS6,
			this.labelS7,
			this.labelS8,
			this.labelS10,
			this.labelS11,
			this.labelS12,
			this.labelS13,
			this.labelS14,
			this.labelS15,
			this.labelS16,
			this.labelS17,
			this.labelS18,
			this.labelS19,
			this.PvMin,
			this.PvMax});
			this.Size = new System.Drawing.Size(267, 551);
			this.SecurityParameterChanged += new SE.App2Base.Faceplates.SEAppLibHMIFaceplate.OnSecurityParameterChanged(this.FpParameterSecurityParameterChanged);
			this.SecurityModeChanged += new SE.App2Base.Faceplates.SEAppLibHMIFaceplate.OnSecurityModeChanged(this.FpParameterSecurityModeChanged);

		}
		private System.HMI.Symbols.Base.TextBox<float> txtMinPv;
		private System.HMI.Symbols.Base.TextBox<float> txtMaxPv;
		private System.HMI.Symbols.Base.TextBox<float> txtPvOffset;
		private System.HMI.Symbols.Base.TextBox<System.Int32> txtFilterTime;
		private System.HMI.Symbols.Base.SwitchButton EnScaleBtn;
		private System.HMI.Symbols.Base.TextBox<float> txtPvCutOff;
		private System.HMI.Symbols.Base.TextBox<float> txtoverridevalue;
		private System.HMI.Symbols.Base.TextBox<float> txtMinRaw;
		private System.HMI.Symbols.Base.TextBox<float> txtMaxRaw;
		private System.HMI.Symbols.Base.SwitchButton Override;
		private System.HMI.Symbols.Base.TextBox<float> txtPvBad;
		private System.HMI.Symbols.Base.DropDown<short> SelectBad;
		private System.HMI.Symbols.Base.Label<float> lblPvField;
		private System.HMI.Symbols.Base.Execute<short> BadPvSel;
		private System.HMI.Symbols.Base.Execute<bool> Execover;
		private System.HMI.Symbols.Base.Execute<float> Pv;
		private System.HMI.Symbols.Base.TextBox<int> txtPt1CycleTime;
		private System.HMI.Symbols.Base.SwitchButton UseLimitsBtn;
		private NxtControl.GuiFramework.DrawnComboBox SmoothType;
		private System.HMI.Symbols.Base.TextBox<System.Int32> TimeDiff;
		private System.HMI.Symbols.Base.TextBox<float> ValDiff;
		private System.HMI.Symbols.Base.Execute<byte> execute_11;
		private SE.App2Base.Graphics.LabelS labelS1;
		private SE.App2Base.Graphics.LabelS labelS2;
		private SE.App2Base.Graphics.LabelS labelS3;
		private SE.App2Base.Graphics.LabelS labelS4;
		private SE.App2Base.Graphics.LabelS labelS5;
		private SE.App2Base.Graphics.LabelS labelS6;
		private SE.App2Base.Graphics.LabelS labelS7;
		private SE.App2Base.Graphics.LabelS labelS8;
		private SE.App2Base.Graphics.LabelS labelS10;
		private SE.App2Base.Graphics.LabelS labelS11;
		private SE.App2Base.Graphics.LabelS labelS12;
		private SE.App2Base.Graphics.LabelS labelS13;
		private SE.App2Base.Graphics.LabelS labelS14;
		private SE.App2Base.Graphics.LabelS labelS15;
		private SE.App2Base.Graphics.LabelS labelS16;
		private SE.App2Base.Graphics.LabelS labelS17;
		private SE.App2Base.Graphics.LabelS labelS18;
		private SE.App2Base.Graphics.LabelS labelS19;
		private System.HMI.Symbols.Base.Execute<float> PvMin;
		private System.HMI.Symbols.Base.Execute<float> PvMax;
		#endregion
	}
}



