using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using NxtControl.GuiFramework;

namespace HMI.Main.Faceplates.MotorVsBase
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
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary4 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary3 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary6 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary5 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary8 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary7 = new NxtControl.GuiFramework.PropertyDictionary();
			this.lblFbStatus = new NxtControl.GuiFramework.Label();
			this.lblReqOp = new NxtControl.GuiFramework.Label();
			this.btnManualReverse = new NxtControl.GuiFramework.DrawnButton();
			this.btnManualForward = new NxtControl.GuiFramework.DrawnButton();
			this.btnReset = new NxtControl.GuiFramework.DrawnButton();
			this.lblCurrSp = new NxtControl.GuiFramework.Label();
			this.btnManualOff = new NxtControl.GuiFramework.DrawnButton();
			this.PassiveRemainTime = new System.HMI.Symbols.Base.Label<float>();
			this.line2 = new NxtControl.GuiFramework.Line();
			this.line3 = new NxtControl.GuiFramework.Line();
			this.group2 = new NxtControl.GuiFramework.Group();
			this.txtSp = new System.HMI.Symbols.Base.TextBox<float>();
			this.SpeedSpValue = new System.HMI.Symbols.Base.Label<float>();
			this.SpeedOpValue = new System.HMI.Symbols.Base.Label<float>();
			this.SMeters1 = new SE.App2Base.Graphics.SMeters();
			this.SMeters2 = new SE.App2Base.Graphics.SMeters();
			this.line1 = new NxtControl.GuiFramework.Line();
			this.labelS1 = new SE.App2Base.Graphics.LabelS();
			this.labelS2 = new SE.App2Base.Graphics.LabelS();
			this.labelS3 = new SE.App2Base.Graphics.LabelS();
			this.labelS4 = new SE.App2Base.Graphics.LabelS();
			this.labelS5 = new SE.App2Base.Graphics.LabelS();
			this.labelS6 = new SE.App2Base.Graphics.LabelS();
			this.labelS7 = new SE.App2Base.Graphics.LabelS();
			this.LabelSpeedOwner = new SE.App2Base.Graphics.LabelS();
			this.lblSpeedSp = new SE.App2Base.Graphics.LabelS();
			this.fpNavigationPane = new SE.App2Base.Graphics.FpNavigationPane();
			this.ownerSwitch = new SE.App2Base.Graphics.OwnerSwitchBasic();
			this.labelS8 = new SE.App2Base.Graphics.LabelS();
			this.lblCurrSpeedOwner = new NxtControl.GuiFramework.Label();
			this.ownerStatus = new SE.App2Base.Graphics.OwnerStatusBasic();
			this.FbStatus = new System.HMI.Symbols.Base.Execute<short>();
			this.TransFbStatus = new System.HMI.Symbols.Base.Execute<short>();
			this.SpeedFbStatus = new System.HMI.Symbols.Base.Execute<float>();
			this.CurrentSp = new System.HMI.Symbols.Base.Execute<short>();
			this.CurrentSpeedSp = new System.HMI.Symbols.Base.Execute<float>();
			this.CurrentSpeedOp = new System.HMI.Symbols.Base.Execute<float>();
			this.CurrentOwner = new System.HMI.Symbols.Base.Execute<ushort>();
			this.CurrentSpeedOwner = new System.HMI.Symbols.Base.Execute<ushort>();
			this.NeedReset = new System.HMI.Symbols.Base.Execute<bool>();
			this.StdOwnerConnected = new System.HMI.Symbols.Base.Execute<bool>();
			this.Maintenance = new System.HMI.Symbols.Base.Execute<bool>();
			this.OutOfService = new System.HMI.Symbols.Base.Execute<bool>();
			this.FbOverride = new System.HMI.Symbols.Base.Execute<bool>();
			this.Simulation = new System.HMI.Symbols.Base.Execute<bool>();
			this.SpeedSp = new System.HMI.Symbols.Base.Execute<float>();
			this.CurrentSpeedSpMin = new System.HMI.Symbols.Base.Execute<float>();
			this.CurrentSpeedSpMax = new System.HMI.Symbols.Base.Execute<float>();
			this.DisReverse = new System.HMI.Symbols.Base.Execute<bool>();
			this.SpeedPvValue = new System.HMI.Symbols.Base.Label<float>();
			this.EnSpeedOwner = new System.HMI.Symbols.Base.Execute<bool>();
			this.CurrentOp = new System.HMI.Symbols.Base.Execute<short>();
			this.ExternalControlled = new System.HMI.Symbols.Base.Execute<bool>();
			this.btnSpeedOwner = new NxtControl.GuiFramework.TwoStateButton();
			this.SpeedOutMin = new System.HMI.Symbols.Base.Execute<float>();
			this.SpeedOutMax = new System.HMI.Symbols.Base.Execute<float>();
			// 
			// lblFbStatus
			// 
			this.lblFbStatus.AngleIgnore = true;
			this.lblFbStatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lblFbStatus.Bounds = new NxtControl.Drawing.RectF(((float)(120D)), ((float)(8D)), ((float)(100D)), ((float)(25D)));
			this.lblFbStatus.Brush = new NxtControl.Drawing.Brush(true);
			this.lblFbStatus.Font = new NxtControl.Drawing.Font("SE.App2Base.Pv");
			this.lblFbStatus.Name = "lblFbStatus";
			this.lblFbStatus.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.lblFbStatus.Text = "$key:SE.App2CommonProcess.LabelUnknown";
			this.lblFbStatus.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.lblFbStatus.TextColor = new NxtControl.Drawing.Color("SE.App2Base.aaLibFpData");
			// 
			// lblReqOp
			// 
			this.lblReqOp.AngleIgnore = true;
			this.lblReqOp.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lblReqOp.Bounds = new NxtControl.Drawing.RectF(((float)(120D)), ((float)(96D)), ((float)(100D)), ((float)(25D)));
			this.lblReqOp.Brush = new NxtControl.Drawing.Brush(true);
			this.lblReqOp.Font = new NxtControl.Drawing.Font("SE.App2Base.Pv");
			this.lblReqOp.IsPrefixSuffixOutside = false;
			this.lblReqOp.Name = "lblReqOp";
			this.lblReqOp.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.lblReqOp.SuffixPadding = 1;
			this.lblReqOp.Text = "$key:SE.App2CommonProcess.LabelUnknown";
			this.lblReqOp.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.lblReqOp.TextColor = new NxtControl.Drawing.Color("SE.App2Base.aaLibFpOp");
			// 
			// btnManualReverse
			// 
			this.btnManualReverse.Bounds = new NxtControl.Drawing.RectF(((float)(7D)), ((float)(450D)), ((float)(80D)), ((float)(30D)));
			this.btnManualReverse.Brush = new NxtControl.Drawing.Brush("ButtonBrush");
			this.btnManualReverse.ButtonPushedBrush = new NxtControl.Drawing.Brush(true);
			this.btnManualReverse.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.btnManualReverse.InnerBorderColor = new NxtControl.Drawing.Color("ButtonInnerBorderColor");
			this.btnManualReverse.Name = "btnManualReverse";
			this.btnManualReverse.Pen = new NxtControl.Drawing.Pen("ButtonPen");
			this.btnManualReverse.Radius = 4D;
			this.btnManualReverse.Text = "$key:SE.App2CommonProcess.BtnManReverse";
			this.btnManualReverse.TextColor = new NxtControl.Drawing.Color("ButtonTextColor");
			this.btnManualReverse.TextColorMouseDown = new NxtControl.Drawing.Color("ButtonTextColorMouseDown");
			this.btnManualReverse.Use3DEffect = false;
			this.btnManualReverse.Click += new System.EventHandler(this.BtnManualReverseClick);
			// 
			// btnManualForward
			// 
			this.btnManualForward.Bounds = new NxtControl.Drawing.RectF(((float)(183D)), ((float)(450D)), ((float)(81D)), ((float)(30D)));
			this.btnManualForward.Brush = new NxtControl.Drawing.Brush("ButtonBrush");
			this.btnManualForward.ButtonPushedBrush = new NxtControl.Drawing.Brush(true);
			this.btnManualForward.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.btnManualForward.InnerBorderColor = new NxtControl.Drawing.Color("ButtonInnerBorderColor");
			this.btnManualForward.Name = "btnManualForward";
			this.btnManualForward.Pen = new NxtControl.Drawing.Pen("ButtonPen");
			this.btnManualForward.Radius = 4D;
			this.btnManualForward.Text = "$key:SE.App2CommonProcess.BtnManForward";
			this.btnManualForward.TextColor = new NxtControl.Drawing.Color("ButtonTextColor");
			this.btnManualForward.TextColorMouseDown = new NxtControl.Drawing.Color("ButtonTextColorMouseDown");
			this.btnManualForward.Use3DEffect = false;
			this.btnManualForward.Click += new System.EventHandler(this.BtnManualForwardClick);
			// 
			// btnReset
			// 
			this.btnReset.Bounds = new NxtControl.Drawing.RectF(((float)(95D)), ((float)(500D)), ((float)(80D)), ((float)(30D)));
			this.btnReset.Brush = new NxtControl.Drawing.Brush("ButtonBrush");
			this.btnReset.ButtonPushedBrush = new NxtControl.Drawing.Brush(true);
			this.btnReset.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.btnReset.InnerBorderColor = new NxtControl.Drawing.Color("ButtonInnerBorderColor");
			this.btnReset.Name = "btnReset";
			this.btnReset.Pen = new NxtControl.Drawing.Pen("ButtonPen");
			this.btnReset.Radius = 4D;
			this.btnReset.Text = "$key:SE.App2CommonProcess.LabelRearm";
			this.btnReset.TextColor = new NxtControl.Drawing.Color("ButtonTextColor");
			this.btnReset.TextColorMouseDown = new NxtControl.Drawing.Color("ButtonTextColorMouseDown");
			this.btnReset.Use3DEffect = false;
			this.btnReset.Click += new System.EventHandler(this.BtnResetClick);
			// 
			// lblCurrSp
			// 
			this.lblCurrSp.AngleIgnore = true;
			this.lblCurrSp.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lblCurrSp.Bounds = new NxtControl.Drawing.RectF(((float)(120D)), ((float)(52D)), ((float)(100D)), ((float)(25D)));
			this.lblCurrSp.Brush = new NxtControl.Drawing.Brush(true);
			this.lblCurrSp.Font = new NxtControl.Drawing.Font("SE.App2Base.Pv");
			this.lblCurrSp.Name = "lblCurrSp";
			this.lblCurrSp.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.lblCurrSp.Text = "$key:SE.App2CommonProcess.LabelUnknown";
			this.lblCurrSp.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.lblCurrSp.TextColor = new NxtControl.Drawing.Color("SE.App2Base.aaLibFpSp");
			// 
			// btnManualOff
			// 
			this.btnManualOff.Bounds = new NxtControl.Drawing.RectF(((float)(95D)), ((float)(450D)), ((float)(80D)), ((float)(30D)));
			this.btnManualOff.Brush = new NxtControl.Drawing.Brush("ButtonBrush");
			this.btnManualOff.ButtonPushedBrush = new NxtControl.Drawing.Brush(true);
			this.btnManualOff.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.btnManualOff.InnerBorderColor = new NxtControl.Drawing.Color("ButtonInnerBorderColor");
			this.btnManualOff.Name = "btnManualOff";
			this.btnManualOff.Pen = new NxtControl.Drawing.Pen("ButtonPen");
			this.btnManualOff.Radius = 4D;
			this.btnManualOff.Text = "$key:SE.App2CommonProcess.BtnManPassive";
			this.btnManualOff.TextColor = new NxtControl.Drawing.Color("ButtonTextColor");
			this.btnManualOff.TextColorMouseDown = new NxtControl.Drawing.Color("ButtonTextColorMouseDown");
			this.btnManualOff.Use3DEffect = false;
			this.btnManualOff.Click += new System.EventHandler(this.BtnManualOffClick);
			// 
			// PassiveRemainTime
			// 
			this.PassiveRemainTime.BeginInit();
			this.PassiveRemainTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.PassiveRemainTime.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.66666666666666663D, 0D, 0D, 1.1904761904761905D, 120D, 184D);
			this.PassiveRemainTime.Font = new NxtControl.Drawing.Font("SE.App2Base.Pv");
			this.PassiveRemainTime.FontScale = false;
			this.PassiveRemainTime.IsOnlyInput = true;
			this.PassiveRemainTime.IsPrefixSuffixOutside = false;
			this.PassiveRemainTime.LeadingZeros = ((uint)(0u));
			this.PassiveRemainTime.Name = "PassiveRemainTime";
			this.PassiveRemainTime.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.PassiveRemainTime.Ranges.Clear();
			this.PassiveRemainTime.Ranges.Add(new NxtControl.GuiFramework.Range<float>(null, true, null, true, propertyDictionary2));
			propertyDictionary1.Add("Text", "${Value}");
			propertyDictionary1.Add("TextColor", new NxtControl.Drawing.Color("SE.App2Base.aaLibFpData"));
			propertyDictionary1.Add("Brush", new NxtControl.Drawing.Brush(true));
			propertyDictionary1.Add("Pen", new NxtControl.Drawing.Pen("LabelPen"));
			this.PassiveRemainTime.Ranges.DefaultPropertyValues = propertyDictionary1;
			this.PassiveRemainTime.Suffix = "s";
			this.PassiveRemainTime.TagName = "PassiveRemainTime";
			this.PassiveRemainTime.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.PassiveRemainTime.EndInit();
			// 
			// line2
			// 
			this.line2.EndPoint = new NxtControl.Drawing.PointF(269D, 335D);
			this.line2.Name = "line2";
			this.line2.Pen = new NxtControl.Drawing.Pen("FpLinePen");
			this.line2.StartPoint = new NxtControl.Drawing.PointF(0D, 335D);
			// 
			// line3
			// 
			this.line3.EndPoint = new NxtControl.Drawing.PointF(269D, 335D);
			this.line3.Name = "line3";
			this.line3.Pen = new NxtControl.Drawing.Pen("FpLinePen");
			this.line3.StartPoint = new NxtControl.Drawing.PointF(0D, 335D);
			// 
			// group2
			// 
			this.group2.BeginInit();
			this.group2.Name = "group2";
			this.group2.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.line2,
			this.line3});
			this.group2.EndInit();
			// 
			// txtSp
			// 
			this.txtSp.BeginInit();
			this.txtSp.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.63333333333333341D, 0D, 0D, 1D, 120D, 412D);
			this.txtSp.Font = new NxtControl.Drawing.Font("SE.App2Base.Sp");
			this.txtSp.MaximumTag = null;
			this.txtSp.MinimumTag = null;
			this.txtSp.Name = "txtSp";
			this.txtSp.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.txtSp.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.txtSp.SecurityLevel = 0;
			this.txtSp.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.txtSp.TagName = "SpeedSp";
			this.txtSp.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.txtSp.UseInputPad = true;
			this.txtSp.UseRange = true;
			this.txtSp.Value = 0F;
			this.txtSp.EndInit();
			// 
			// SpeedSpValue
			// 
			this.SpeedSpValue.BeginInit();
			this.SpeedSpValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.SpeedSpValue.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.66666666666666663D, 0D, 0D, 1.1904761904761905D, 120D, 74D);
			this.SpeedSpValue.Font = new NxtControl.Drawing.Font("SE.App2Base.Pv");
			this.SpeedSpValue.FontScale = false;
			this.SpeedSpValue.IsOnlyInput = true;
			this.SpeedSpValue.IsPrefixSuffixOutside = false;
			this.SpeedSpValue.LeadingZeros = ((uint)(0u));
			this.SpeedSpValue.Name = "SpeedSpValue";
			this.SpeedSpValue.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.SpeedSpValue.Ranges.Clear();
			this.SpeedSpValue.Ranges.Add(new NxtControl.GuiFramework.Range<float>(null, true, null, true, propertyDictionary4));
			propertyDictionary3.Add("Text", "${Value}");
			propertyDictionary3.Add("TextColor", new NxtControl.Drawing.Color("SE.App2Base.aaLibFpSp"));
			propertyDictionary3.Add("Brush", new NxtControl.Drawing.Brush(true));
			propertyDictionary3.Add("Pen", new NxtControl.Drawing.Pen("LabelPen"));
			this.SpeedSpValue.Ranges.DefaultPropertyValues = propertyDictionary3;
			this.SpeedSpValue.TagName = "CurrentSpeedSp";
			this.SpeedSpValue.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.SpeedSpValue.EndInit();
			// 
			// SpeedOpValue
			// 
			this.SpeedOpValue.BeginInit();
			this.SpeedOpValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.SpeedOpValue.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.66666666666666663D, 0D, 0D, 1.1904761904761905D, 120D, 118D);
			this.SpeedOpValue.Font = new NxtControl.Drawing.Font("SE.App2Base.Pv");
			this.SpeedOpValue.FontScale = false;
			this.SpeedOpValue.IsOnlyInput = true;
			this.SpeedOpValue.IsPrefixSuffixOutside = false;
			this.SpeedOpValue.LeadingZeros = ((uint)(0u));
			this.SpeedOpValue.Name = "SpeedOpValue";
			this.SpeedOpValue.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.SpeedOpValue.Ranges.Clear();
			this.SpeedOpValue.Ranges.Add(new NxtControl.GuiFramework.Range<float>(null, true, null, true, propertyDictionary6));
			propertyDictionary5.Add("Text", "${Value}");
			propertyDictionary5.Add("TextColor", new NxtControl.Drawing.Color("SE.App2Base.aaLibFpOp"));
			propertyDictionary5.Add("Brush", new NxtControl.Drawing.Brush(true));
			propertyDictionary5.Add("Pen", new NxtControl.Drawing.Pen("LabelPen"));
			this.SpeedOpValue.Ranges.DefaultPropertyValues = propertyDictionary5;
			this.SpeedOpValue.TagName = "CurrentSpeedOp";
			this.SpeedOpValue.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.SpeedOpValue.EndInit();
			// 
			// SMeters1
			// 
			this.SMeters1.BeginInit();
			this.SMeters1.AbnormalXOffset = 0D;
			this.SMeters1.AbnormalYOffset = 0D;
			this.SMeters1.BarGraphSize = 215D;
			this.SMeters1.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.96832579185520384D, 0D, 0D, 1D, 1.950226244343888D, 155D);
			this.SMeters1.FrameColor = new NxtControl.Drawing.Color("SymStaticIconColor");
			this.SMeters1.LeftOffset = ((uint)(60u));
			this.SMeters1.Name = "SMeters1";
			this.SMeters1.NumericalVisible = SE.App2Base.Graphics.SMeters.NumericalDisplaySel.None;
			this.SMeters1.OpColor = new NxtControl.Drawing.Color("SE.App2Base.aaLibFpOp");
			this.SMeters1.PvColor = new NxtControl.Drawing.Color("SE.App2Base.aaLibFpPv");
			this.SMeters1.RangeVisible = SE.App2Base.SupportClasses.BoolType.True;
			this.SMeters1.Rotation = SE.App2Base.SupportClasses.Rotation.Horizontal;
			this.SMeters1.SpColor = new NxtControl.Drawing.Color("SE.App2Base.aaLibFpSp");
			this.SMeters1.SpIndicator = SE.App2Base.Graphics.SMeters.Indicator.PvBarSpTriangle;
			this.SMeters1.TextAlignmentPvSpOp = SE.App2Base.Graphics.SMeters.TextAlignment.Right;
			this.SMeters1.TextLocationPvSpOp = SE.App2Base.Graphics.SMeters.TextLocation.Left;
			this.SMeters1.Unit = "";
			this.SMeters1.UnitColor = new NxtControl.Drawing.Color("SE.App2Base.aaLibSymUnit");
			this.SMeters1.ValuePct = 0D;
			this.SMeters1.EndInit();
			// 
			// SMeters2
			// 
			this.SMeters2.BeginInit();
			this.SMeters2.AbnormalXOffset = 0D;
			this.SMeters2.AbnormalYOffset = 0D;
			this.SMeters2.BarGraphSize = 210D;
			this.SMeters2.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.99069767441860446D, 0D, 0D, 1D, -0.711627906976739D, 208D);
			this.SMeters2.FrameColor = new NxtControl.Drawing.Color("SymStaticIconColor");
			this.SMeters2.LeftOffset = ((uint)(60u));
			this.SMeters2.Name = "SMeters2";
			this.SMeters2.NumericalVisible = SE.App2Base.Graphics.SMeters.NumericalDisplaySel.None;
			this.SMeters2.OpColor = new NxtControl.Drawing.Color("SE.App2Base.aaLibFpOp");
			this.SMeters2.PvColor = new NxtControl.Drawing.Color("SE.App2Base.aaLibFpPv");
			this.SMeters2.RangeVisible = SE.App2Base.SupportClasses.BoolType.True;
			this.SMeters2.Rotation = SE.App2Base.SupportClasses.Rotation.Horizontal;
			this.SMeters2.SpColor = new NxtControl.Drawing.Color("SE.App2Base.aaLibFpSp");
			this.SMeters2.SpIndicator = SE.App2Base.Graphics.SMeters.Indicator.OpLine;
			this.SMeters2.TextAlignmentPvSpOp = SE.App2Base.Graphics.SMeters.TextAlignment.Right;
			this.SMeters2.TextLocationPvSpOp = SE.App2Base.Graphics.SMeters.TextLocation.Left;
			this.SMeters2.Unit = "";
			this.SMeters2.UnitColor = new NxtControl.Drawing.Color("SE.App2Base.aaLibSymUnit");
			this.SMeters2.ValuePct = 0D;
			this.SMeters2.EndInit();
			// 
			// line1
			// 
			this.line1.EndPoint = new NxtControl.Drawing.PointF(239D, 200D);
			this.line1.Name = "line1";
			this.line1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line1.StartPoint = new NxtControl.Drawing.PointF(209D, 210D);
			// 
			// labelS1
			// 
			this.labelS1.BeginInit();
			this.labelS1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 5D, 8D);
			this.labelS1.Font = new NxtControl.Drawing.Font("SE.App2Base.LabelFont");
			this.labelS1.Name = "labelS1";
			this.labelS1.NameSpace = "SE.App2CommonProcess";
			this.labelS1.SeperatorVisiblity = true;
			this.labelS1.Text = "Status";
			this.labelS1.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.labelS1.TextColor = new NxtControl.Drawing.Color("FpLabelText");
			this.labelS1.TextKey = "LabelRunState";
			this.labelS1.EndInit();
			// 
			// labelS2
			// 
			this.labelS2.BeginInit();
			this.labelS2.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 5D, 52D);
			this.labelS2.Font = new NxtControl.Drawing.Font("SE.App2Base.LabelFont");
			this.labelS2.Name = "labelS2";
			this.labelS2.NameSpace = "SE.App2CommonProcess";
			this.labelS2.SeperatorVisiblity = true;
			this.labelS2.Text = "Current Setpoint";
			this.labelS2.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.labelS2.TextColor = new NxtControl.Drawing.Color("FpLabelText");
			this.labelS2.TextKey = "LabelCurrentSetpoint";
			this.labelS2.EndInit();
			// 
			// labelS3
			// 
			this.labelS3.BeginInit();
			this.labelS3.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 5D, 96D);
			this.labelS3.Font = new NxtControl.Drawing.Font("SE.App2Base.LabelFont");
			this.labelS3.Name = "labelS3";
			this.labelS3.NameSpace = "SE.App2CommonProcess";
			this.labelS3.SeperatorVisiblity = true;
			this.labelS3.Text = "Current Output";
			this.labelS3.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.labelS3.TextColor = new NxtControl.Drawing.Color("FpLabelText");
			this.labelS3.TextKey = "LabelCurrentOutput";
			this.labelS3.EndInit();
			// 
			// labelS4
			// 
			this.labelS4.BeginInit();
			this.labelS4.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 5D, 184D);
			this.labelS4.Font = new NxtControl.Drawing.Font("SE.App2Base.LabelFont");
			this.labelS4.Name = "labelS4";
			this.labelS4.NameSpace = "SE.App2CommonProcess";
			this.labelS4.SeperatorVisiblity = true;
			this.labelS4.Text = "Passive Time";
			this.labelS4.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.labelS4.TextColor = new NxtControl.Drawing.Color("FpLabelText");
			this.labelS4.TextKey = "LabelPassiveTime";
			this.labelS4.EndInit();
			// 
			// labelS5
			// 
			this.labelS5.BeginInit();
			this.labelS5.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 5D, 30D);
			this.labelS5.Font = new NxtControl.Drawing.Font("SE.App2Base.LabelFont");
			this.labelS5.Name = "labelS5";
			this.labelS5.NameSpace = "SE.App2CommonProcess";
			this.labelS5.SeperatorVisiblity = true;
			this.labelS5.Text = "Speed Status";
			this.labelS5.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.labelS5.TextColor = new NxtControl.Drawing.Color("FpLabelText");
			this.labelS5.TextKey = "LabelSpeedStatus";
			this.labelS5.EndInit();
			// 
			// labelS6
			// 
			this.labelS6.BeginInit();
			this.labelS6.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 5D, 74D);
			this.labelS6.Font = new NxtControl.Drawing.Font("SE.App2Base.LabelFont");
			this.labelS6.Name = "labelS6";
			this.labelS6.NameSpace = "SE.App2CommonProcess";
			this.labelS6.SeperatorVisiblity = true;
			this.labelS6.Text = "Current Speed Setpoint";
			this.labelS6.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.labelS6.TextColor = new NxtControl.Drawing.Color("FpLabelText");
			this.labelS6.TextKey = "LabelCurrentSpeedSetpoint";
			this.labelS6.EndInit();
			// 
			// labelS7
			// 
			this.labelS7.BeginInit();
			this.labelS7.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 5D, 118D);
			this.labelS7.Font = new NxtControl.Drawing.Font("SE.App2Base.LabelFont");
			this.labelS7.Name = "labelS7";
			this.labelS7.NameSpace = "SE.App2CommonProcess";
			this.labelS7.SeperatorVisiblity = true;
			this.labelS7.Text = "Current Speed Output";
			this.labelS7.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.labelS7.TextColor = new NxtControl.Drawing.Color("FpLabelText");
			this.labelS7.TextKey = "LabelCurrentSpeedOut";
			this.labelS7.EndInit();
			// 
			// LabelSpeedOwner
			// 
			this.LabelSpeedOwner.BeginInit();
			this.LabelSpeedOwner.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 5D, 381D);
			this.LabelSpeedOwner.Font = new NxtControl.Drawing.Font("SE.App2Base.LabelFont");
			this.LabelSpeedOwner.Name = "LabelSpeedOwner";
			this.LabelSpeedOwner.NameSpace = "SE.App2CommonProcess";
			this.LabelSpeedOwner.SeperatorVisiblity = true;
			this.LabelSpeedOwner.Text = "Speed Owner";
			this.LabelSpeedOwner.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.LabelSpeedOwner.TextColor = new NxtControl.Drawing.Color("FpLabelText");
			this.LabelSpeedOwner.TextKey = "LabelSpeedOwner";
			this.LabelSpeedOwner.EndInit();
			// 
			// lblSpeedSp
			// 
			this.lblSpeedSp.BeginInit();
			this.lblSpeedSp.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 5D, 412D);
			this.lblSpeedSp.Font = new NxtControl.Drawing.Font("SE.App2Base.LabelFont");
			this.lblSpeedSp.Name = "lblSpeedSp";
			this.lblSpeedSp.NameSpace = "SE.App2CommonProcess";
			this.lblSpeedSp.SeperatorVisiblity = true;
			this.lblSpeedSp.Text = "Speed Setpoint";
			this.lblSpeedSp.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.lblSpeedSp.TextColor = new NxtControl.Drawing.Color("FpLabelText");
			this.lblSpeedSp.TextKey = "LabelSpeedSp";
			this.lblSpeedSp.EndInit();
			// 
			// fpNavigationPane
			// 
			this.fpNavigationPane.BeginInit();
			this.fpNavigationPane.Backwash.AliasName = "";
			this.fpNavigationPane.Backwash.Availablity = SE.App2Base.SupportClasses.FpIconSymbolAllocation.NotAvailable;
			this.fpNavigationPane.Backwash.InstanceName = null;
			this.fpNavigationPane.Backwash.ParentTitle = "Title";
			this.fpNavigationPane.Backwash.SymbolType = "SE.AppWWW.Symbols.Backwash.sDefault";
			this.fpNavigationPane.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 210D, 0D);
			this.fpNavigationPane.ExtendedMeasures.Availablity = SE.App2Base.SupportClasses.FpIconSymbolAllocation.NotAvailable;
			this.fpNavigationPane.Failure.AliasName = "";
			this.fpNavigationPane.Failure.ApplicableConditions = SE.App2Base.SupportClasses.ApplicableInputConditions.PassiveActive1Active2;
			this.fpNavigationPane.Failure.Availablity = SE.App2Base.SupportClasses.FpIconSymbolAllocation.Slot3L;
			this.fpNavigationPane.Failure.InstanceName = null;
			this.fpNavigationPane.Failure.ParentTitle = "Title";
			this.fpNavigationPane.Failure.SymbolType = "SE.App2CommonProcess.Symbols.CondSum.sFailure";
			this.fpNavigationPane.Filtration.AliasName = "";
			this.fpNavigationPane.Filtration.Availablity = SE.App2Base.SupportClasses.FpIconSymbolAllocation.NotAvailable;
			this.fpNavigationPane.Filtration.InstanceName = null;
			this.fpNavigationPane.Filtration.ParentTitle = "Title";
			this.fpNavigationPane.Filtration.SymbolType = "SE.AppWWW.Symbols.Filtration.sDefault";
			this.fpNavigationPane.GeneralPropertySubscription.AddRange(new string[] {
			"System.ShowTagNames"});
			this.fpNavigationPane.HideSlider = false;
			this.fpNavigationPane.Info.Availablity = SE.App2Base.SupportClasses.FpIconSymbolAllocation.NotAvailable;
			this.fpNavigationPane.InputParameters.Availablity = SE.App2Base.SupportClasses.FpIconSymbolAllocation.NotAvailable;
			this.fpNavigationPane.Interlock.AliasName = "";
			this.fpNavigationPane.Interlock.ApplicableConditions = SE.App2Base.SupportClasses.ApplicableInputConditions.PassiveActive1Active2;
			this.fpNavigationPane.Interlock.Availablity = SE.App2Base.SupportClasses.FpIconSymbolAllocation.Slot2L;
			this.fpNavigationPane.Interlock.InstanceName = null;
			this.fpNavigationPane.Interlock.LabelActive1 = SE.App2Base.SupportClasses.CondActive1LabelText.Forward;
			this.fpNavigationPane.Interlock.LabelActive2 = SE.App2Base.SupportClasses.CondActive2LabelText.Reverse;
			this.fpNavigationPane.Interlock.LabelPassive = SE.App2Base.SupportClasses.CondPassiveLabelText.Stop;
			this.fpNavigationPane.Interlock.ParentTitle = "Title";
			this.fpNavigationPane.Interlock.SymbolType = "SE.App2CommonProcess.Symbols.IlckCondSum.sInterlock";
			this.fpNavigationPane.IsBasic = false;
			this.fpNavigationPane.LocalPanel.AliasName = "";
			this.fpNavigationPane.LocalPanel.ApplicableConditions = SE.App2Base.SupportClasses.ApplicableInputConditions.PassiveActive1Active2;
			this.fpNavigationPane.LocalPanel.Availablity = SE.App2Base.SupportClasses.FpIconSymbolAllocation.Slot4R;
			this.fpNavigationPane.LocalPanel.InstanceName = null;
			this.fpNavigationPane.LocalPanel.LabelActive1 = SE.App2Base.SupportClasses.CondActive1LabelText.Forward;
			this.fpNavigationPane.LocalPanel.LabelActive2 = SE.App2Base.SupportClasses.CondActive2LabelText.Reverse;
			this.fpNavigationPane.LocalPanel.LabelPassive = SE.App2Base.SupportClasses.CondPassiveLabelText.Stop;
			this.fpNavigationPane.LocalPanel.ParentTitle = "Title";
			this.fpNavigationPane.LocalPanel.SymbolType = "SE.App2CommonProcess.Symbols.DevLp.sDefault";
			this.fpNavigationPane.Maintenance.AliasName = "";
			this.fpNavigationPane.Maintenance.Availablity = SE.App2Base.SupportClasses.FpIconSymbolAllocation.Slot1L;
			this.fpNavigationPane.Maintenance.InstanceName = null;
			this.fpNavigationPane.Maintenance.ParentTitle = "Title";
			this.fpNavigationPane.Maintenance.SymbolType = "SE.App2CommonProcess.Symbols.DevMnt.sDefault";
			this.fpNavigationPane.Measures.Availablity = SE.App2Base.SupportClasses.FpIconSymbolAllocation.NotAvailable;
			this.fpNavigationPane.Name = "fpNavigationPane";
			this.fpNavigationPane.OutputParameters.Availablity = SE.App2Base.SupportClasses.FpIconSymbolAllocation.NotAvailable;
			this.fpNavigationPane.Owner.AliasName = "";
			this.fpNavigationPane.Owner.Availablity = SE.App2Base.SupportClasses.FpIconSymbolAllocation.Slot1R;
			this.fpNavigationPane.Owner.InstanceName = null;
			this.fpNavigationPane.Owner.ParentTitle = "Title";
			this.fpNavigationPane.Owner.SymbolType = "SE.App2Base.Symbols.Owner.sOwnerConfig";
			this.fpNavigationPane.Parameter.Availablity = SE.App2Base.SupportClasses.FpIconSymbolAllocation.Slot2R;
			this.fpNavigationPane.ParentTitle = "";
			this.fpNavigationPane.Permissive.AliasName = "";
			this.fpNavigationPane.Permissive.ApplicableConditions = SE.App2Base.SupportClasses.ApplicableInputConditions.PassiveActive1Active2;
			this.fpNavigationPane.Permissive.Availablity = SE.App2Base.SupportClasses.FpIconSymbolAllocation.Slot4L;
			this.fpNavigationPane.Permissive.InstanceName = null;
			this.fpNavigationPane.Permissive.LabelActive1 = SE.App2Base.SupportClasses.CondActive1LabelText.Forward;
			this.fpNavigationPane.Permissive.LabelActive2 = SE.App2Base.SupportClasses.CondActive2LabelText.Reverse;
			this.fpNavigationPane.Permissive.LabelPassive = SE.App2Base.SupportClasses.CondPassiveLabelText.Stop;
			this.fpNavigationPane.Permissive.ParentTitle = "Title";
			this.fpNavigationPane.Permissive.SymbolType = "SE.App2CommonProcess.Symbols.PermCondSum.sPermissive";
			this.fpNavigationPane.SecMode = 6;
			this.fpNavigationPane.SecOwner = 3;
			this.fpNavigationPane.SecParameter = 12;
			this.fpNavigationPane.SecSetpoint = 3;
			this.fpNavigationPane.ShortFlush.AliasName = "";
			this.fpNavigationPane.ShortFlush.Availablity = SE.App2Base.SupportClasses.FpIconSymbolAllocation.NotAvailable;
			this.fpNavigationPane.ShortFlush.InstanceName = null;
			this.fpNavigationPane.ShortFlush.ParentTitle = "Title";
			this.fpNavigationPane.ShortFlush.SymbolType = "SE.AppWWW.Symbols.ShortFlush.sDefault";
			this.fpNavigationPane.SSC.AliasName = "";
			this.fpNavigationPane.SSC.Availablity = SE.App2Base.SupportClasses.FpIconSymbolAllocation.NotAvailable;
			this.fpNavigationPane.SSC.ParentTitle = "Title";
			this.fpNavigationPane.SSC.SymbolType = "SE.App2CommonProcess.Symbols.PIDSSCSeqData.sDefault";
			this.fpNavigationPane.Trend.Availablity = SE.App2Base.SupportClasses.FpIconSymbolAllocation.Slot3R;
			this.fpNavigationPane.UserDefined1.AliasName = "";
			this.fpNavigationPane.UserDefined1.Availablity = SE.App2Base.SupportClasses.FpIconSymbolAllocation.NotAvailable;
			this.fpNavigationPane.UserDefined1.ParentTitle = "Title";
			this.fpNavigationPane.UserDefined2.AliasName = "";
			this.fpNavigationPane.UserDefined2.Availablity = SE.App2Base.SupportClasses.FpIconSymbolAllocation.NotAvailable;
			this.fpNavigationPane.UserDefined2.ParentTitle = "Title";
			this.fpNavigationPane.UserDefined3.AliasName = "";
			this.fpNavigationPane.UserDefined3.Availablity = SE.App2Base.SupportClasses.FpIconSymbolAllocation.NotAvailable;
			this.fpNavigationPane.UserDefined3.ParentTitle = "Title";
			this.fpNavigationPane.EndInit();
			// 
			// ownerSwitch
			// 
			this.ownerSwitch.BeginInit();
			this.ownerSwitch.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 5D, 351D);
			this.ownerSwitch.ExternalAvailable = false;
			this.ownerSwitch.InstanceName = "";
			this.ownerSwitch.Name = "ownerSwitch";
			this.ownerSwitch.SecOwner = 0;
			this.ownerSwitch.OnBasicOwnerChanged += new SE.App2Base.Graphics.OwnerSwitchBasic.BasicOwnerChanged(this.OwnerSwitchOnBasicOwnerChanged);
			this.ownerSwitch.EndInit();
			// 
			// labelS8
			// 
			this.labelS8.BeginInit();
			this.labelS8.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1.0000000000000002D, 5D, 162D);
			this.labelS8.Font = new NxtControl.Drawing.Font("SE.App2Base.LabelFont");
			this.labelS8.Name = "labelS8";
			this.labelS8.NameSpace = "SE.App2CommonProcess";
			this.labelS8.SeperatorVisiblity = true;
			this.labelS8.Text = "Current Speed Owner";
			this.labelS8.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.labelS8.TextColor = new NxtControl.Drawing.Color("FpLabelText");
			this.labelS8.TextKey = "LabelCurrentSpeedOwner";
			this.labelS8.EndInit();
			// 
			// lblCurrSpeedOwner
			// 
			this.lblCurrSpeedOwner.AngleIgnore = true;
			this.lblCurrSpeedOwner.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lblCurrSpeedOwner.Bounds = new NxtControl.Drawing.RectF(((float)(120D)), ((float)(162D)), ((float)(120D)), ((float)(25D)));
			this.lblCurrSpeedOwner.Brush = new NxtControl.Drawing.Brush(true);
			this.lblCurrSpeedOwner.Font = new NxtControl.Drawing.Font("SE.App2Base.Pv");
			this.lblCurrSpeedOwner.Name = "lblCurrSpeedOwner";
			this.lblCurrSpeedOwner.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.lblCurrSpeedOwner.Text = "$key:SE.App2CommonProcess.LabelUnknown";
			this.lblCurrSpeedOwner.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.lblCurrSpeedOwner.TextColor = new NxtControl.Drawing.Color("SE.App2Base.aaLibFpData");
			// 
			// ownerStatus
			// 
			this.ownerStatus.BeginInit();
			this.ownerStatus.CurrentBasicOwner = false;
			this.ownerStatus.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 5D, 140D);
			this.ownerStatus.ExternalAvailable = false;
			this.ownerStatus.InstanceName = "";
			this.ownerStatus.Name = "ownerStatus";
			this.ownerStatus.EndInit();
			// 
			// FbStatus
			// 
			this.FbStatus.BeginInit();
			this.FbStatus.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.FbStatus.IsOnlyInput = true;
			this.FbStatus.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.FbStatus.Name = "FbStatus";
			this.FbStatus.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.FbStatus.TagName = "FbStatus";
			this.FbStatus.Value = ((short)(0));
			this.FbStatus.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.FbStatusValueChanged);
			this.FbStatus.EndInit();
			// 
			// TransFbStatus
			// 
			this.TransFbStatus.BeginInit();
			this.TransFbStatus.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.TransFbStatus.IsOnlyInput = true;
			this.TransFbStatus.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.TransFbStatus.Name = "TransFbStatus";
			this.TransFbStatus.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.TransFbStatus.TagName = "TransFbStatus";
			this.TransFbStatus.Value = ((short)(0));
			this.TransFbStatus.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.TransFbStatusValueChanged);
			this.TransFbStatus.EndInit();
			// 
			// SpeedFbStatus
			// 
			this.SpeedFbStatus.BeginInit();
			this.SpeedFbStatus.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.SpeedFbStatus.IsOnlyInput = true;
			this.SpeedFbStatus.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.SpeedFbStatus.Name = "SpeedFbStatus";
			this.SpeedFbStatus.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.SpeedFbStatus.TagName = "SpeedFbStatus";
			this.SpeedFbStatus.Value = 0F;
			this.SpeedFbStatus.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.SpeedFbStatusValueChanged);
			this.SpeedFbStatus.EndInit();
			// 
			// CurrentSp
			// 
			this.CurrentSp.BeginInit();
			this.CurrentSp.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.CurrentSp.IsOnlyInput = true;
			this.CurrentSp.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.CurrentSp.Name = "CurrentSp";
			this.CurrentSp.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.CurrentSp.TagName = "CurrentSp";
			this.CurrentSp.Value = ((short)(0));
			this.CurrentSp.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.CurrentSpValueChanged);
			this.CurrentSp.EndInit();
			// 
			// CurrentSpeedSp
			// 
			this.CurrentSpeedSp.BeginInit();
			this.CurrentSpeedSp.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.CurrentSpeedSp.IsOnlyInput = true;
			this.CurrentSpeedSp.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.CurrentSpeedSp.Name = "CurrentSpeedSp";
			this.CurrentSpeedSp.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.CurrentSpeedSp.TagName = "CurrentSpeedSp";
			this.CurrentSpeedSp.Value = 0F;
			this.CurrentSpeedSp.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.CurrentSpeedSpValueChanged);
			this.CurrentSpeedSp.EndInit();
			// 
			// CurrentSpeedOp
			// 
			this.CurrentSpeedOp.BeginInit();
			this.CurrentSpeedOp.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.CurrentSpeedOp.IsOnlyInput = true;
			this.CurrentSpeedOp.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.CurrentSpeedOp.Name = "CurrentSpeedOp";
			this.CurrentSpeedOp.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.CurrentSpeedOp.TagName = "CurrentSpeedOp";
			this.CurrentSpeedOp.Value = 0F;
			this.CurrentSpeedOp.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.CurrentSpeedOpValueChanged);
			this.CurrentSpeedOp.EndInit();
			// 
			// CurrentOwner
			// 
			this.CurrentOwner.BeginInit();
			this.CurrentOwner.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.CurrentOwner.IsOnlyInput = true;
			this.CurrentOwner.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.CurrentOwner.Name = "CurrentOwner";
			this.CurrentOwner.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.CurrentOwner.TagName = "CurrentOwner";
			this.CurrentOwner.Value = ((ushort)(0));
			this.CurrentOwner.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.CurrentOwnerValueChanged);
			this.CurrentOwner.EndInit();
			// 
			// CurrentSpeedOwner
			// 
			this.CurrentSpeedOwner.BeginInit();
			this.CurrentSpeedOwner.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.CurrentSpeedOwner.IsOnlyInput = true;
			this.CurrentSpeedOwner.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.CurrentSpeedOwner.Name = "CurrentSpeedOwner";
			this.CurrentSpeedOwner.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.CurrentSpeedOwner.TagName = "CurrentSpeedOwner";
			this.CurrentSpeedOwner.Value = ((ushort)(0));
			this.CurrentSpeedOwner.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.CurrentSpeedOwnerValueChanged);
			this.CurrentSpeedOwner.EndInit();
			// 
			// NeedReset
			// 
			this.NeedReset.BeginInit();
			this.NeedReset.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.NeedReset.IsOnlyInput = true;
			this.NeedReset.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.NeedReset.Name = "NeedReset";
			this.NeedReset.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.NeedReset.TagName = "NeedReset";
			this.NeedReset.Value = false;
			this.NeedReset.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.NeedResetValueChanged);
			this.NeedReset.EndInit();
			// 
			// StdOwnerConnected
			// 
			this.StdOwnerConnected.BeginInit();
			this.StdOwnerConnected.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.StdOwnerConnected.IsOnlyInput = true;
			this.StdOwnerConnected.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.StdOwnerConnected.Name = "StdOwnerConnected";
			this.StdOwnerConnected.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.StdOwnerConnected.TagName = "StdOwnerConnected";
			this.StdOwnerConnected.Value = false;
			this.StdOwnerConnected.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.StdOwnerConnectedValueChanged);
			this.StdOwnerConnected.EndInit();
			// 
			// Maintenance
			// 
			this.Maintenance.BeginInit();
			this.Maintenance.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.Maintenance.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.Maintenance.Name = "Maintenance";
			this.Maintenance.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.Maintenance.TagName = "Maintenance";
			this.Maintenance.Value = false;
			this.Maintenance.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.MaintenanceValueChanged);
			this.Maintenance.EndInit();
			// 
			// OutOfService
			// 
			this.OutOfService.BeginInit();
			this.OutOfService.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.OutOfService.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.OutOfService.Name = "OutOfService";
			this.OutOfService.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.OutOfService.TagName = "OutOfService";
			this.OutOfService.Value = false;
			this.OutOfService.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.OutOfServiceValueChanged);
			this.OutOfService.EndInit();
			// 
			// FbOverride
			// 
			this.FbOverride.BeginInit();
			this.FbOverride.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.FbOverride.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.FbOverride.Name = "FbOverride";
			this.FbOverride.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.FbOverride.TagName = "FbOverride";
			this.FbOverride.Value = false;
			this.FbOverride.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.FbOverrideValueChanged);
			this.FbOverride.EndInit();
			// 
			// Simulation
			// 
			this.Simulation.BeginInit();
			this.Simulation.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.Simulation.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.Simulation.Name = "Simulation";
			this.Simulation.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.Simulation.TagName = "Simulation";
			this.Simulation.Value = false;
			this.Simulation.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.SimulationValueChanged);
			this.Simulation.EndInit();
			// 
			// SpeedSp
			// 
			this.SpeedSp.BeginInit();
			this.SpeedSp.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.SpeedSp.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.SpeedSp.Name = "SpeedSp";
			this.SpeedSp.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.SpeedSp.TagName = "SpeedSp";
			this.SpeedSp.Value = 0F;
			this.SpeedSp.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.SpeedSpValueChanged);
			this.SpeedSp.EndInit();
			// 
			// CurrentSpeedSpMin
			// 
			this.CurrentSpeedSpMin.BeginInit();
			this.CurrentSpeedSpMin.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.CurrentSpeedSpMin.IsOnlyInput = true;
			this.CurrentSpeedSpMin.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.CurrentSpeedSpMin.Name = "CurrentSpeedSpMin";
			this.CurrentSpeedSpMin.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.CurrentSpeedSpMin.TagName = "CurrentSpeedSpMin";
			this.CurrentSpeedSpMin.Value = 0F;
			this.CurrentSpeedSpMin.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.SpeedSpMinValueChanged);
			this.CurrentSpeedSpMin.EndInit();
			// 
			// CurrentSpeedSpMax
			// 
			this.CurrentSpeedSpMax.BeginInit();
			this.CurrentSpeedSpMax.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.CurrentSpeedSpMax.IsOnlyInput = true;
			this.CurrentSpeedSpMax.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.CurrentSpeedSpMax.Name = "CurrentSpeedSpMax";
			this.CurrentSpeedSpMax.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.CurrentSpeedSpMax.TagName = "CurrentSpeedSpMax";
			this.CurrentSpeedSpMax.Value = 0F;
			this.CurrentSpeedSpMax.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.SpeedSpMaxValueChanged);
			this.CurrentSpeedSpMax.EndInit();
			// 
			// DisReverse
			// 
			this.DisReverse.BeginInit();
			this.DisReverse.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.DisReverse.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.DisReverse.Name = "DisReverse";
			this.DisReverse.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.DisReverse.TagName = "DisReverse";
			this.DisReverse.Value = false;
			this.DisReverse.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.DisReverseValueChanged);
			this.DisReverse.EndInit();
			// 
			// SpeedPvValue
			// 
			this.SpeedPvValue.BeginInit();
			this.SpeedPvValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.SpeedPvValue.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.66666666666666663D, 0D, 0D, 1.1904761904761905D, 120D, 30D);
			this.SpeedPvValue.Font = new NxtControl.Drawing.Font("SE.App2Base.Pv");
			this.SpeedPvValue.FontScale = false;
			this.SpeedPvValue.IsOnlyInput = true;
			this.SpeedPvValue.IsPrefixSuffixOutside = false;
			this.SpeedPvValue.LeadingZeros = ((uint)(0u));
			this.SpeedPvValue.Name = "SpeedPvValue";
			this.SpeedPvValue.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.SpeedPvValue.Ranges.Clear();
			this.SpeedPvValue.Ranges.Add(new NxtControl.GuiFramework.Range<float>(null, true, null, true, propertyDictionary8));
			propertyDictionary7.Add("Text", "${Value}");
			propertyDictionary7.Add("TextColor", new NxtControl.Drawing.Color("SE.App2Base.aaLibFpData"));
			propertyDictionary7.Add("Brush", new NxtControl.Drawing.Brush(true));
			propertyDictionary7.Add("Pen", new NxtControl.Drawing.Pen("LabelPen"));
			this.SpeedPvValue.Ranges.DefaultPropertyValues = propertyDictionary7;
			this.SpeedPvValue.TagName = "SpeedFbStatus";
			this.SpeedPvValue.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.SpeedPvValue.EndInit();
			// 
			// EnSpeedOwner
			// 
			this.EnSpeedOwner.BeginInit();
			this.EnSpeedOwner.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.EnSpeedOwner.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.EnSpeedOwner.Name = "EnSpeedOwner";
			this.EnSpeedOwner.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.EnSpeedOwner.TagName = "EnSpeedOwner";
			this.EnSpeedOwner.Value = false;
			this.EnSpeedOwner.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.EnSpeedOwnerValueChanged);
			this.EnSpeedOwner.EndInit();
			// 
			// CurrentOp
			// 
			this.CurrentOp.BeginInit();
			this.CurrentOp.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.CurrentOp.IsOnlyInput = true;
			this.CurrentOp.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.CurrentOp.Name = "CurrentOp";
			this.CurrentOp.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.CurrentOp.TagName = "CurrentOp";
			this.CurrentOp.Value = ((short)(0));
			this.CurrentOp.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.CurrentOpValueChanged);
			this.CurrentOp.EndInit();
			// 
			// ExternalControlled
			// 
			this.ExternalControlled.BeginInit();
			this.ExternalControlled.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.ExternalControlled.IsOnlyInput = true;
			this.ExternalControlled.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.ExternalControlled.Name = "ExternalControlled";
			this.ExternalControlled.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.ExternalControlled.TagName = "ExternalControlled";
			this.ExternalControlled.Value = false;
			this.ExternalControlled.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.ExternalControlledValueChanged);
			this.ExternalControlled.EndInit();
			// 
			// btnSpeedOwner
			// 
			this.btnSpeedOwner.Bounds = new NxtControl.Drawing.RectF(((float)(120D)), ((float)(381D)), ((float)(118D)), ((float)(25D)));
			this.btnSpeedOwner.ButtonPushedBrush = new NxtControl.Drawing.Brush(true);
			this.btnSpeedOwner.DrawStyle = NxtControl.GuiFramework.TwoStateButton.ButtonDrawStyle.Switch;
			this.btnSpeedOwner.FalseBrush = new NxtControl.Drawing.Brush("ButtonFalseBrush");
			this.btnSpeedOwner.FalseText = "$key:SE.App2CommonProcess.LabelProgram";
			this.btnSpeedOwner.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.btnSpeedOwner.InnerBorderColor = new NxtControl.Drawing.Color("ButtonInnerBorderColor");
			this.btnSpeedOwner.Name = "btnSpeedOwner";
			this.btnSpeedOwner.Pen = new NxtControl.Drawing.Pen("ButtonPen");
			this.btnSpeedOwner.Radius = 8D;
			this.btnSpeedOwner.TextColorFalse = new NxtControl.Drawing.Color("ButtonTextColorFalse");
			this.btnSpeedOwner.TextColorTrue = new NxtControl.Drawing.Color("ButtonTextColorTrue");
			this.btnSpeedOwner.TrueBrush = new NxtControl.Drawing.Brush("ButtonBrush");
			this.btnSpeedOwner.TrueText = "$key:SE.App2CommonProcess.LabelOperator";
			this.btnSpeedOwner.Use3DEffect = false;
			this.btnSpeedOwner.CheckedChanged += new System.EventHandler(this.BtnSpeedOwnerCheckedChanged);
			// 
			// SpeedOutMin
			// 
			this.SpeedOutMin.BeginInit();
			this.SpeedOutMin.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.SpeedOutMin.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.SpeedOutMin.Name = "SpeedOutMin";
			this.SpeedOutMin.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.SpeedOutMin.TagName = "SpeedOutMin";
			this.SpeedOutMin.Value = 0F;
			this.SpeedOutMin.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.SpeedOutMinValueChanged);
			this.SpeedOutMin.EndInit();
			// 
			// SpeedOutMax
			// 
			this.SpeedOutMax.BeginInit();
			this.SpeedOutMax.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 396D, 1044D);
			this.SpeedOutMax.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.SpeedOutMax.Name = "SpeedOutMax";
			this.SpeedOutMax.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.SpeedOutMax.TagName = "SpeedOutMax";
			this.SpeedOutMax.Value = 0F;
			this.SpeedOutMax.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.SpeedOutMaxValueChanged);
			this.SpeedOutMax.EndInit();
			// 
			// fpDefault
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(270D)), ((float)(547D)));
			this.Brush = new NxtControl.Drawing.Brush("FpBackgroundBrush");
			this.FormBorderStyle = NxtControl.GuiFramework.FormBorderStyle.FixedSingle;
			this.SecurityToken = ((uint)(4294967199u));
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.PassiveRemainTime,
			this.lblFbStatus,
			this.lblCurrSp,
			this.lblReqOp,
			this.labelS1,
			this.labelS2,
			this.labelS3,
			this.labelS4,
			this.labelS8,
			this.lblCurrSpeedOwner,
			this.fpNavigationPane,
			this.ownerStatus,
			this.SpeedSpValue,
			this.SpeedPvValue,
			this.SpeedOpValue,
			this.labelS5,
			this.labelS6,
			this.labelS7,
			this.FbStatus,
			this.TransFbStatus,
			this.SpeedFbStatus,
			this.CurrentSp,
			this.CurrentSpeedSp,
			this.CurrentSpeedOp,
			this.CurrentOwner,
			this.CurrentSpeedOwner,
			this.NeedReset,
			this.StdOwnerConnected,
			this.Maintenance,
			this.OutOfService,
			this.FbOverride,
			this.Simulation,
			this.SpeedSp,
			this.CurrentSpeedSpMin,
			this.CurrentSpeedSpMax,
			this.DisReverse,
			this.EnSpeedOwner,
			this.CurrentOp,
			this.ExternalControlled,
			this.group2,
			this.SMeters1,
			this.SMeters2,
			this.line1,
			this.LabelSpeedOwner,
			this.ownerSwitch,
			this.btnManualReverse,
			this.btnManualForward,
			this.btnReset,
			this.btnManualOff,
			this.txtSp,
			this.lblSpeedSp,
			this.btnSpeedOwner,
			this.SpeedOutMin,
			this.SpeedOutMax});
			this.Size = new System.Drawing.Size(270, 547);
			this.SecurityOwnerChanged += new SE.App2Base.Faceplates.SEAppLibHMIFaceplate.OnSecurityOwnerChanged(this.FpDefaultSecurityOwnerChanged);
			this.SecurityParameterChanged += new SE.App2Base.Faceplates.SEAppLibHMIFaceplate.OnSecurityParameterChanged(this.FpDefaultSecurityParameterChanged);
			this.SecuritySetpointChanged += new SE.App2Base.Faceplates.SEAppLibHMIFaceplate.OnSecuritySetpointChanged(this.FpDefaultSecuritySetpointChanged);
			this.UpdateOptionalService += new SE.App2Base.Faceplates.SEAppLibHMIFaceplate.OnUpdateOptionalService(this.FpDefaultUpdateOptionalService);

		}
		private NxtControl.GuiFramework.Label lblFbStatus;
		private NxtControl.GuiFramework.Label lblReqOp;
		private NxtControl.GuiFramework.DrawnButton btnManualReverse;
		private NxtControl.GuiFramework.DrawnButton btnManualForward;
		private NxtControl.GuiFramework.DrawnButton btnReset;
		private NxtControl.GuiFramework.Label lblCurrSp;
		private NxtControl.GuiFramework.DrawnButton btnManualOff;
		private System.HMI.Symbols.Base.Label<float> PassiveRemainTime;
		private SE.App2Base.Graphics.LabelS LabelSpeedOwner;
		private NxtControl.GuiFramework.Group group2;
		private NxtControl.GuiFramework.Line line2;
		private NxtControl.GuiFramework.Line line3;
		//private NxtControl.GuiFramework.DrawnComboBox SelectPresetSpeed;
		private System.HMI.Symbols.Base.TextBox<float> txtSp;
		private System.HMI.Symbols.Base.Label<float> SpeedSpValue;
		private System.HMI.Symbols.Base.Label<float> SpeedOpValue;
		private SE.App2Base.Graphics.SMeters SMeters1;
		private SE.App2Base.Graphics.SMeters SMeters2;
		private NxtControl.GuiFramework.Line line1;
		private SE.App2Base.Graphics.LabelS labelS1;
		private SE.App2Base.Graphics.LabelS labelS2;
		private SE.App2Base.Graphics.LabelS labelS3;
		private SE.App2Base.Graphics.LabelS labelS4;
		private SE.App2Base.Graphics.LabelS labelS5;
		private SE.App2Base.Graphics.LabelS labelS6;
		private SE.App2Base.Graphics.LabelS labelS7;
		private SE.App2Base.Graphics.LabelS lblSpeedSp;
		private SE.App2Base.Graphics.FpNavigationPane fpNavigationPane;
		private SE.App2Base.Graphics.OwnerSwitchBasic ownerSwitch;
		private SE.App2Base.Graphics.LabelS labelS8;
		private NxtControl.GuiFramework.Label lblCurrSpeedOwner;
		private SE.App2Base.Graphics.OwnerStatusBasic ownerStatus;
		private System.HMI.Symbols.Base.Execute<short> FbStatus;
		private System.HMI.Symbols.Base.Execute<short> TransFbStatus;
		private System.HMI.Symbols.Base.Execute<float> SpeedFbStatus;
		private System.HMI.Symbols.Base.Execute<short> CurrentSp;
		private System.HMI.Symbols.Base.Execute<float> CurrentSpeedSp;
		private System.HMI.Symbols.Base.Execute<float> CurrentSpeedOp;
		private System.HMI.Symbols.Base.Execute<ushort> CurrentOwner;
		private System.HMI.Symbols.Base.Execute<ushort> CurrentSpeedOwner;
		private System.HMI.Symbols.Base.Execute<bool> NeedReset;
		private System.HMI.Symbols.Base.Execute<bool> StdOwnerConnected;
		private System.HMI.Symbols.Base.Execute<bool> Maintenance;
		private System.HMI.Symbols.Base.Execute<bool> OutOfService;
		private System.HMI.Symbols.Base.Execute<bool> FbOverride;
		private System.HMI.Symbols.Base.Execute<bool> Simulation;
		private System.HMI.Symbols.Base.Execute<float> SpeedSp;
		private System.HMI.Symbols.Base.Execute<float> CurrentSpeedSpMin;
		private System.HMI.Symbols.Base.Execute<float> CurrentSpeedSpMax;
		private System.HMI.Symbols.Base.Execute<bool> DisReverse;
		private System.HMI.Symbols.Base.Label<float> SpeedPvValue;
		private System.HMI.Symbols.Base.Execute<bool> EnSpeedOwner;
		private System.HMI.Symbols.Base.Execute<short> CurrentOp;
		private System.HMI.Symbols.Base.Execute<bool> ExternalControlled;
		private NxtControl.GuiFramework.TwoStateButton btnSpeedOwner;
		private System.HMI.Symbols.Base.Execute<float> SpeedOutMin;
		private System.HMI.Symbols.Base.Execute<float> SpeedOutMax;

		#endregion
		
	}
}



