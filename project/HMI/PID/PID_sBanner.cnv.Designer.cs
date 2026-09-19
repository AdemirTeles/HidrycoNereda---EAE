using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace HMI.Main.Symbols.PID
{
	/// <summary>
	/// Summary description for sBanner.
	/// </summary>
	partial class sBanner
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary16 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary17 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary18 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary15 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary20 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary19 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary22 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary21 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary24 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary25 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary26 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary27 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary28 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary23 = new NxtControl.GuiFramework.PropertyDictionary();
			this.InstanceName = new NxtControl.GuiFramework.Label();
			this.line6 = new NxtControl.GuiFramework.Line();
			this.line4 = new NxtControl.GuiFramework.Line();
			this.line3 = new NxtControl.GuiFramework.Line();
			this.line2 = new NxtControl.GuiFramework.Line();
			this.line1 = new NxtControl.GuiFramework.Line();
			this.rectangle1 = new NxtControl.GuiFramework.Rectangle();
			this.line5 = new NxtControl.GuiFramework.Line();
			this.rectangle2 = new NxtControl.GuiFramework.Rectangle();
			this.lblController = new SE.App2Base.Graphics.LabelS();
			this.Selection_1 = new System.HMI.Symbols.Base.Execute<bool>();
			this.SSC_DDC = new System.HMI.Symbols.Base.Label<short>();
			this.CurrentSpOp = new System.HMI.Symbols.Base.Label<float>();
			this.SpOp = new System.HMI.Symbols.Base.Label<float>();
			this.Selection = new System.HMI.Symbols.Base.SwitchButton();
			this.EnableCmd = new NxtControl.GuiFramework.DrawnButton();
			this.lblStatus = new SE.App2Base.Graphics.LabelS();
			this.lblConfig = new SE.App2Base.Graphics.LabelS();
			this.lblCurrSpOp = new SE.App2Base.Graphics.LabelS();
			this.lblSSCSpOp = new SE.App2Base.Graphics.LabelS();
			this.lblSource = new SE.App2Base.Graphics.LabelS();
			this.lblEnableSSC = new SE.App2Base.Graphics.LabelS();
			this.line7 = new NxtControl.GuiFramework.Line();
			this.line8 = new NxtControl.GuiFramework.Line();
			this.line9 = new NxtControl.GuiFramework.Line();
			this.line10 = new NxtControl.GuiFramework.Line();
			this.line11 = new NxtControl.GuiFramework.Line();
			this.line12 = new NxtControl.GuiFramework.Line();
			this.label_11 = new System.HMI.Symbols.Base.Label<short>();
			this.group1 = new NxtControl.GuiFramework.Group();
			this.group2 = new NxtControl.GuiFramework.Group();
			// 
			// InstanceName
			// 
			this.InstanceName.AngleIgnore = true;
			this.InstanceName.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.InstanceName.Bounds = new NxtControl.Drawing.RectF(((float)(35D)), ((float)(79D)), ((float)(84D)), ((float)(25D)));
			this.InstanceName.Brush = new NxtControl.Drawing.Brush(true);
			this.InstanceName.Font = new NxtControl.Drawing.Font("SE.App2Base.Pv");
			this.InstanceName.Name = "InstanceName";
			this.InstanceName.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.InstanceName.Text = "InstanceName";
			this.InstanceName.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			this.InstanceName.TextColor = new NxtControl.Drawing.Color("SE.App2Base.aaLibFpData");
			// 
			// line6
			// 
			this.line6.EndPoint = new NxtControl.Drawing.PointF(625D, 73D);
			this.line6.Name = "line6";
			this.line6.Pen = new NxtControl.Drawing.Pen("SymLinePen");
			this.line6.StartPoint = new NxtControl.Drawing.PointF(625D, 46D);
			// 
			// line4
			// 
			this.line4.EndPoint = new NxtControl.Drawing.PointF(400D, 73D);
			this.line4.Name = "line4";
			this.line4.Pen = new NxtControl.Drawing.Pen("SymLinePen");
			this.line4.StartPoint = new NxtControl.Drawing.PointF(400D, 46D);
			// 
			// line3
			// 
			this.line3.EndPoint = new NxtControl.Drawing.PointF(285D, 73D);
			this.line3.Name = "line3";
			this.line3.Pen = new NxtControl.Drawing.Pen("SymLinePen");
			this.line3.StartPoint = new NxtControl.Drawing.PointF(285D, 46D);
			// 
			// line2
			// 
			this.line2.EndPoint = new NxtControl.Drawing.PointF(192D, 73D);
			this.line2.Name = "line2";
			this.line2.Pen = new NxtControl.Drawing.Pen("SymLinePen");
			this.line2.StartPoint = new NxtControl.Drawing.PointF(192D, 46D);
			// 
			// line1
			// 
			this.line1.EndPoint = new NxtControl.Drawing.PointF(120D, 73D);
			this.line1.Name = "line1";
			this.line1.Pen = new NxtControl.Drawing.Pen("SymLinePen");
			this.line1.StartPoint = new NxtControl.Drawing.PointF(120D, 46D);
			// 
			// rectangle1
			// 
			this.rectangle1.Bounds = new NxtControl.Drawing.RectF(((float)(30D)), ((float)(46D)), ((float)(685D)), ((float)(27D)));
			this.rectangle1.Brush = new NxtControl.Drawing.Brush("Transparent");
			this.rectangle1.Font = new NxtControl.Drawing.Font("HMI Sans Serif", 9F, System.Drawing.FontStyle.Regular);
			this.rectangle1.Name = "rectangle1";
			this.rectangle1.Pen = new NxtControl.Drawing.Pen("SymLinePen");
			// 
			// line5
			// 
			this.line5.EndPoint = new NxtControl.Drawing.PointF(517D, 73D);
			this.line5.Name = "line5";
			this.line5.Pen = new NxtControl.Drawing.Pen("SymLinePen");
			this.line5.StartPoint = new NxtControl.Drawing.PointF(517D, 46D);
			// 
			// rectangle2
			// 
			this.rectangle2.Bounds = new NxtControl.Drawing.RectF(((float)(30D)), ((float)(73D)), ((float)(685D)), ((float)(38D)));
			this.rectangle2.Brush = new NxtControl.Drawing.Brush("Transparent");
			this.rectangle2.Font = new NxtControl.Drawing.Font("HMI Sans Serif", 9F, System.Drawing.FontStyle.Regular);
			this.rectangle2.Name = "rectangle2";
			this.rectangle2.Pen = new NxtControl.Drawing.Pen("SymLinePen");
			// 
			// lblController
			// 
			this.lblController.BeginInit();
			this.lblController.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.66217527677519361D, 0D, 0D, 1D, 37D, 50D);
			this.lblController.Font = new NxtControl.Drawing.Font("SE.App2Base.LabelFont");
			this.lblController.Name = "lblController";
			this.lblController.NameSpace = "SE.App2CommonProcess";
			this.lblController.SeperatorVisiblity = false;
			this.lblController.SymbolBackgroundClickState = GuiFramework.Shapes.SymbolBackgroundClickState.Unknown;
			this.lblController.Text = "Tag";
			this.lblController.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			this.lblController.TextColor = new NxtControl.Drawing.Color("SymLabelText");
			this.lblController.TextKey = "LabelController";
			this.lblController.EndInit();
			// 
			// Selection_1
			// 
			this.Selection_1.BeginInit();
			this.Selection_1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.Selection_1.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.Selection_1.Name = "Selection_1";
			this.Selection_1.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.Selection_1.SymbolBackgroundClickState = GuiFramework.Shapes.SymbolBackgroundClickState.Unknown;
			this.Selection_1.TagName = "";
			this.Selection_1.Value = false;
			this.Selection_1.EndInit();
			// 
			// SSC_DDC
			// 
			this.SSC_DDC.BeginInit();
			this.SSC_DDC.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.SSC_DDC.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.42666666666666664D, 0D, 0D, 1D, 205D, 83D);
			this.SSC_DDC.FontScale = false;
			this.SSC_DDC.LeadingZeros = ((uint)(0u));
			this.SSC_DDC.Name = "SSC_DDC";
			this.SSC_DDC.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			propertyDictionary16.Add("Text", "$key:SE.App2CommonProcess.TxtNoConfig");
			propertyDictionary17.Add("Text", "$key:SE.App2CommonProcess.TxtSSC");
			propertyDictionary18.Add("Text", "$key:SE.App2CommonProcess.TxtDDC");
			this.SSC_DDC.Ranges.Clear();
			this.SSC_DDC.Ranges.Add(new NxtControl.GuiFramework.Range<short>(((short)(0)), propertyDictionary16));
			this.SSC_DDC.Ranges.Add(new NxtControl.GuiFramework.Range<short>(((short)(1)), propertyDictionary17));
			this.SSC_DDC.Ranges.Add(new NxtControl.GuiFramework.Range<short>(((short)(2)), propertyDictionary18));
			propertyDictionary15.Add("Text", "${Value}");
			propertyDictionary15.Add("TextColor", new NxtControl.Drawing.Color("SE.App2Base.aaLibSymData"));
			propertyDictionary15.Add("Brush", new NxtControl.Drawing.Brush("LabelBrush"));
			propertyDictionary15.Add("Pen", new NxtControl.Drawing.Pen("LabelPen"));
			this.SSC_DDC.Ranges.DefaultPropertyValues = propertyDictionary15;
			this.SSC_DDC.SymbolBackgroundClickState = GuiFramework.Shapes.SymbolBackgroundClickState.Unknown;
			this.SSC_DDC.TagName = "";
			this.SSC_DDC.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			this.SSC_DDC.EndInit();
			// 
			// CurrentSpOp
			// 
			this.CurrentSpOp.BeginInit();
			this.CurrentSpOp.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.CurrentSpOp.DecimalPlacesCount = ((uint)(1u));
			this.CurrentSpOp.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.7466666666666667D, 0D, 0D, 1D, 286D, 83D);
			this.CurrentSpOp.FontScale = false;
			this.CurrentSpOp.IsOnlyInput = true;
			this.CurrentSpOp.IsPrefixSuffixOutside = false;
			this.CurrentSpOp.LeadingZeros = ((uint)(0u));
			this.CurrentSpOp.Name = "CurrentSpOp";
			this.CurrentSpOp.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.CurrentSpOp.Ranges.Clear();
			this.CurrentSpOp.Ranges.Add(new NxtControl.GuiFramework.Range<float>(null, true, null, true, propertyDictionary20));
			propertyDictionary19.Add("Text", "${Value}");
			propertyDictionary19.Add("TextColor", new NxtControl.Drawing.Color("SE.App2Base.aaLibSymSp"));
			propertyDictionary19.Add("Brush", new NxtControl.Drawing.Brush("LabelBrush"));
			propertyDictionary19.Add("Pen", new NxtControl.Drawing.Pen("LabelPen"));
			this.CurrentSpOp.Ranges.DefaultPropertyValues = propertyDictionary19;
			this.CurrentSpOp.Suffix = "%";
			this.CurrentSpOp.SymbolBackgroundClickState = GuiFramework.Shapes.SymbolBackgroundClickState.Unknown;
			this.CurrentSpOp.TagName = "";
			this.CurrentSpOp.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			this.CurrentSpOp.EndInit();
			// 
			// SpOp
			// 
			this.SpOp.BeginInit();
			this.SpOp.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.SpOp.DecimalPlacesCount = ((uint)(1u));
			this.SpOp.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.74666666666666681D, 0D, 0D, 1D, 402.00000000000006D, 83D);
			this.SpOp.FontScale = false;
			this.SpOp.IsPrefixSuffixOutside = false;
			this.SpOp.LeadingZeros = ((uint)(0u));
			this.SpOp.Name = "SpOp";
			this.SpOp.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.SpOp.Ranges.Clear();
			this.SpOp.Ranges.Add(new NxtControl.GuiFramework.Range<float>(null, true, null, true, propertyDictionary22));
			propertyDictionary21.Add("Text", "${Value}");
			propertyDictionary21.Add("TextColor", new NxtControl.Drawing.Color("SE.App2Base.aaLibSymSp"));
			propertyDictionary21.Add("Brush", new NxtControl.Drawing.Brush("LabelBrush"));
			propertyDictionary21.Add("Pen", new NxtControl.Drawing.Pen("LabelPen"));
			this.SpOp.Ranges.DefaultPropertyValues = propertyDictionary21;
			this.SpOp.Suffix = "%";
			this.SpOp.SymbolBackgroundClickState = GuiFramework.Shapes.SymbolBackgroundClickState.Unknown;
			this.SpOp.TagName = "";
			this.SpOp.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			this.SpOp.EndInit();
			// 
			// Selection
			// 
			this.Selection.BeginInit();
			this.Selection.DesignMatrix = new NxtControl.Drawing.Matrix2D(1.0625D, 0D, 0D, 0.6333333333333333D, 528D, 83D);
			this.Selection.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.Selection.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.Selection.FalseText = "$key:TxtLocal";
			this.Selection.FalseTextKey = "SE.App2CommonProcess.TxtLocal";
			this.Selection.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.Selection.Name = "Selection";
			this.Selection.SymbolBackgroundClickState = GuiFramework.Shapes.SymbolBackgroundClickState.Unknown;
			this.Selection.TagName = "";
			this.Selection.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.Selection.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.Selection.TrueText = "$key:TxtGroup";
			this.Selection.TrueTextKey = "SE.App2CommonProcess.TxtGroup";
			this.Selection.Value = false;
			this.Selection.EndInit();
			// 
			// EnableCmd
			// 
			this.EnableCmd.Bounds = new NxtControl.Drawing.RectF(((float)(635D)), ((float)(83D)), ((float)(65D)), ((float)(21D)));
			this.EnableCmd.Brush = new NxtControl.Drawing.Brush("ButtonBrush");
			this.EnableCmd.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.EnableCmd.InnerBorderColor = new NxtControl.Drawing.Color("ButtonInnerBorderColor");
			this.EnableCmd.Name = "EnableCmd";
			this.EnableCmd.Pen = new NxtControl.Drawing.Pen("ButtonPen");
			this.EnableCmd.Radius = 4D;
			this.EnableCmd.Text = "$key:SE.App2CommonProcess.TxtEnable";
			this.EnableCmd.TextColor = new NxtControl.Drawing.Color("ButtonTextColor");
			this.EnableCmd.TextColorMouseDown = new NxtControl.Drawing.Color("ButtonTextColorMouseDown");
			this.EnableCmd.Use3DEffect = false;
			// 
			// lblStatus
			// 
			this.lblStatus.BeginInit();
			this.lblStatus.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.451166102463267D, 0D, 0D, 1D, 128D, 50D);
			this.lblStatus.Font = new NxtControl.Drawing.Font("SE.App2Base.LabelFont");
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.NameSpace = "SE.App2CommonProcess";
			this.lblStatus.SeperatorVisiblity = false;
			this.lblStatus.SymbolBackgroundClickState = GuiFramework.Shapes.SymbolBackgroundClickState.Unknown;
			this.lblStatus.Text = "Status";
			this.lblStatus.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.lblStatus.TextColor = new NxtControl.Drawing.Color("SymLabelText");
			this.lblStatus.TextKey = "LabelStatus";
			this.lblStatus.EndInit();
			// 
			// lblConfig
			// 
			this.lblConfig.BeginInit();
			this.lblConfig.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.86882837259638823D, 0D, 0D, 1D, 190D, 49D);
			this.lblConfig.Font = new NxtControl.Drawing.Font("SE.App2Base.LabelFont");
			this.lblConfig.Name = "lblConfig";
			this.lblConfig.NameSpace = "SE.App2CommonProcess";
			this.lblConfig.SeperatorVisiblity = false;
			this.lblConfig.SymbolBackgroundClickState = GuiFramework.Shapes.SymbolBackgroundClickState.Unknown;
			this.lblConfig.Text = "Control Mode";
			this.lblConfig.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			this.lblConfig.TextColor = new NxtControl.Drawing.Color("SymLabelText");
			this.lblConfig.TextKey = "LabelConfiguration";
			this.lblConfig.EndInit();
			// 
			// lblCurrSpOp
			// 
			this.lblCurrSpOp.BeginInit();
			this.lblCurrSpOp.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.97216896936301866D, 0D, 0D, 0.84D, 289D, 50D);
			this.lblCurrSpOp.Font = new NxtControl.Drawing.Font("SE.App2Base.LabelFont");
			this.lblCurrSpOp.Name = "lblCurrSpOp";
			this.lblCurrSpOp.NameSpace = "SE.App2CommonProcess";
			this.lblCurrSpOp.SeperatorVisiblity = false;
			this.lblCurrSpOp.SymbolBackgroundClickState = GuiFramework.Shapes.SymbolBackgroundClickState.Unknown;
			this.lblCurrSpOp.Text = "Current Setpoint";
			this.lblCurrSpOp.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			this.lblCurrSpOp.TextColor = new NxtControl.Drawing.Color("SymLabelText");
			this.lblCurrSpOp.TextKey = "LabelCurrentSetpoint";
			this.lblCurrSpOp.EndInit();
			// 
			// lblSSCSpOp
			// 
			this.lblSSCSpOp.BeginInit();
			this.lblSSCSpOp.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.96862529568228717D, 0D, 0D, 0.96D, 403.99999999999994D, 50D);
			this.lblSSCSpOp.Font = new NxtControl.Drawing.Font("SE.App2Base.LabelFont");
			this.lblSSCSpOp.Name = "lblSSCSpOp";
			this.lblSSCSpOp.NameSpace = "SE.App2CommonProcess";
			this.lblSSCSpOp.SeperatorVisiblity = false;
			this.lblSSCSpOp.SymbolBackgroundClickState = GuiFramework.Shapes.SymbolBackgroundClickState.Unknown;
			this.lblSSCSpOp.Text = "APC Setpoint";
			this.lblSSCSpOp.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			this.lblSSCSpOp.TextColor = new NxtControl.Drawing.Color("SymLabelText");
			this.lblSSCSpOp.TextKey = "LabelApcSp";
			this.lblSSCSpOp.EndInit();
			// 
			// lblSource
			// 
			this.lblSource.BeginInit();
			this.lblSource.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.9945374706981347D, 0D, 0D, 1D, 515D, 49D);
			this.lblSource.Font = new NxtControl.Drawing.Font("SE.App2Base.LabelFont");
			this.lblSource.Name = "lblSource";
			this.lblSource.NameSpace = "SE.App2CommonProcess";
			this.lblSource.SeperatorVisiblity = false;
			this.lblSource.SymbolBackgroundClickState = GuiFramework.Shapes.SymbolBackgroundClickState.Unknown;
			this.lblSource.Text = "Source Selection";
			this.lblSource.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			this.lblSource.TextColor = new NxtControl.Drawing.Color("SymLabelText");
			this.lblSource.TextKey = "LabelSource";
			this.lblSource.EndInit();
			// 
			// lblEnableSSC
			// 
			this.lblEnableSSC.BeginInit();
			this.lblEnableSSC.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.76984385432049018D, 0D, 0D, 1D, 635D, 49D);
			this.lblEnableSSC.Font = new NxtControl.Drawing.Font("SE.App2Base.LabelFont");
			this.lblEnableSSC.Name = "lblEnableSSC";
			this.lblEnableSSC.NameSpace = "SE.App2CommonProcess";
			this.lblEnableSSC.SeperatorVisiblity = false;
			this.lblEnableSSC.SymbolBackgroundClickState = GuiFramework.Shapes.SymbolBackgroundClickState.Unknown;
			this.lblEnableSSC.Text = "Enable SSC";
			this.lblEnableSSC.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.lblEnableSSC.TextColor = new NxtControl.Drawing.Color("SymLabelText");
			this.lblEnableSSC.TextKey = "LabelEnSSC";
			this.lblEnableSSC.EndInit();
			// 
			// line7
			// 
			this.line7.EndPoint = new NxtControl.Drawing.PointF(120D, 111D);
			this.line7.Name = "line7";
			this.line7.Pen = new NxtControl.Drawing.Pen("SymLinePen");
			this.line7.StartPoint = new NxtControl.Drawing.PointF(120D, 73D);
			// 
			// line8
			// 
			this.line8.EndPoint = new NxtControl.Drawing.PointF(192D, 111D);
			this.line8.Name = "line8";
			this.line8.Pen = new NxtControl.Drawing.Pen("SymLinePen");
			this.line8.StartPoint = new NxtControl.Drawing.PointF(192D, 73D);
			// 
			// line9
			// 
			this.line9.EndPoint = new NxtControl.Drawing.PointF(285D, 111D);
			this.line9.Name = "line9";
			this.line9.Pen = new NxtControl.Drawing.Pen("SymLinePen");
			this.line9.StartPoint = new NxtControl.Drawing.PointF(285D, 73D);
			// 
			// line10
			// 
			this.line10.EndPoint = new NxtControl.Drawing.PointF(400D, 111D);
			this.line10.Name = "line10";
			this.line10.Pen = new NxtControl.Drawing.Pen("SymLinePen");
			this.line10.StartPoint = new NxtControl.Drawing.PointF(400D, 73D);
			// 
			// line11
			// 
			this.line11.EndPoint = new NxtControl.Drawing.PointF(517D, 111D);
			this.line11.Name = "line11";
			this.line11.Pen = new NxtControl.Drawing.Pen("SymLinePen");
			this.line11.StartPoint = new NxtControl.Drawing.PointF(517D, 73D);
			// 
			// line12
			// 
			this.line12.EndPoint = new NxtControl.Drawing.PointF(625D, 111D);
			this.line12.Name = "line12";
			this.line12.Pen = new NxtControl.Drawing.Pen("SymLinePen");
			this.line12.StartPoint = new NxtControl.Drawing.PointF(625D, 73D);
			// 
			// label_11
			// 
			this.label_11.BeginInit();
			this.label_11.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.label_11.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.42666666666666664D, 0D, 0D, 1D, 123D, 82D);
			this.label_11.FontScale = false;
			this.label_11.LeadingZeros = ((uint)(0u));
			this.label_11.Name = "label_11";
			this.label_11.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			propertyDictionary24.Add("Text", "$key:SE.App2CommonProcess.TxtIdle");
			propertyDictionary25.Add("Text", "$key:SE.App2CommonProcess.LabelDisabled");
			propertyDictionary26.Add("Text", "$key:SE.App2CommonProcess.LabelEnabled");
			propertyDictionary27.Add("Text", "$key:SE.App2CommonProcess.txtConnected");
			propertyDictionary28.Add("Text", "$key:SE.App2CommonProcess.LabelFallback");
			this.label_11.Ranges.Clear();
			this.label_11.Ranges.Add(new NxtControl.GuiFramework.Range<short>(((short)(0)), propertyDictionary24));
			this.label_11.Ranges.Add(new NxtControl.GuiFramework.Range<short>(((short)(1)), propertyDictionary25));
			this.label_11.Ranges.Add(new NxtControl.GuiFramework.Range<short>(((short)(2)), propertyDictionary26));
			this.label_11.Ranges.Add(new NxtControl.GuiFramework.Range<short>(((short)(3)), propertyDictionary27));
			this.label_11.Ranges.Add(new NxtControl.GuiFramework.Range<short>(((short)(4)), propertyDictionary28));
			propertyDictionary23.Add("Text", "${Value}");
			propertyDictionary23.Add("TextColor", new NxtControl.Drawing.Color("SE.App2Base.aaLibSymData"));
			propertyDictionary23.Add("Brush", new NxtControl.Drawing.Brush("LabelBrush"));
			propertyDictionary23.Add("Pen", new NxtControl.Drawing.Pen("LabelPen"));
			this.label_11.Ranges.DefaultPropertyValues = propertyDictionary23;
			this.label_11.SymbolBackgroundClickState = GuiFramework.Shapes.SymbolBackgroundClickState.Unknown;
			this.label_11.TagName = "";
			this.label_11.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			this.label_11.EndInit();
			// 
			// group1
			// 
			this.group1.BeginInit();
			this.group1.Name = "group1";
			this.group1.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.rectangle1,
			this.line1,
			this.line2,
			this.line3,
			this.line4,
			this.line5,
			this.line6});
			this.group1.SymbolBackgroundClickState = GuiFramework.Shapes.SymbolBackgroundClickState.Unknown;
			this.group1.EndInit();
			// 
			// group2
			// 
			this.group2.BeginInit();
			this.group2.Name = "group2";
			this.group2.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.rectangle2,
			this.SSC_DDC,
			this.CurrentSpOp,
			this.SpOp,
			this.Selection,
			this.EnableCmd,
			this.line7,
			this.line8,
			this.line9,
			this.line10,
			this.line11,
			this.line12,
			this.label_11});
			this.group2.SymbolBackgroundClickState = GuiFramework.Shapes.SymbolBackgroundClickState.Unknown;
			this.group2.EndInit();
			// 
			// sBanner
			// 
			this.LockAspectRatio = true;
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.group2,
			this.group1,
			this.Selection_1,
			this.lblController,
			this.lblStatus,
			this.lblConfig,
			this.lblCurrSpOp,
			this.lblSSCSpOp,
			this.lblSource,
			this.lblEnableSSC,
			this.InstanceName});
			this.SymbolSize = new System.Drawing.Size(744, 142);
			this.UpdateOptionalService += new SE.App2Base.Symbols.SEAppLibHMISymbol.OnUpdateOptionalService(this.SBannerUpdateOptionalService);

		}
		private System.HMI.Symbols.Base.Label<short> SSC_DDC;
		private System.HMI.Symbols.Base.Label<float> CurrentSpOp;
		private System.HMI.Symbols.Base.Label<float> SpOp;
		private System.HMI.Symbols.Base.SwitchButton Selection;
		private NxtControl.GuiFramework.DrawnButton EnableCmd;
		private SE.App2Base.Graphics.LabelS lblStatus;
		private SE.App2Base.Graphics.LabelS lblConfig;
		private SE.App2Base.Graphics.LabelS lblCurrSpOp;
		private SE.App2Base.Graphics.LabelS lblSSCSpOp;
		private SE.App2Base.Graphics.LabelS lblSource;
		private SE.App2Base.Graphics.LabelS lblEnableSSC;
		private NxtControl.GuiFramework.Label InstanceName;
		private SE.App2Base.Graphics.LabelS lblController;
		private NxtControl.GuiFramework.Rectangle rectangle1;
		private NxtControl.GuiFramework.Rectangle rectangle2;
		private NxtControl.GuiFramework.Line line1;
		private NxtControl.GuiFramework.Line line2;
		private NxtControl.GuiFramework.Line line3;
		private NxtControl.GuiFramework.Line line4;
		private NxtControl.GuiFramework.Line line5;
		private NxtControl.GuiFramework.Line line6;
		private System.HMI.Symbols.Base.Execute<bool> Selection_1;
		private NxtControl.GuiFramework.Line line7;
		private NxtControl.GuiFramework.Line line8;
		private NxtControl.GuiFramework.Line line9;
		private NxtControl.GuiFramework.Line line10;
		private NxtControl.GuiFramework.Line line11;
		private NxtControl.GuiFramework.Line line12;
		private System.HMI.Symbols.Base.Label<short> label_11;
		private NxtControl.GuiFramework.Group group1;
		private NxtControl.GuiFramework.Group group2;
		#endregion
	}
}
