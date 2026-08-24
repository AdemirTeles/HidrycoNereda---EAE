/*
 * Created by EcoStruxure Automation Expert.
 * User: SESA583220
 * Date: 8/31/2022
 * Time: 11:51 AM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using NxtControl.GuiFramework;

namespace SE.Nereda.Faceplates.AnalogInput_Status
{
	/// <summary>
	/// Summary description for Status.
	/// </summary>
	partial class fpStatus
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary2 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary3 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary1 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary5 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary6 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary4 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary8 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary9 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary7 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary11 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary12 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary10 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary13 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary14 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary16 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary15 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary17 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary18 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary20 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary21 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary19 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary23 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary24 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary22 = new NxtControl.GuiFramework.PropertyDictionary();
			this.CommonError = new System.HMI.Symbols.Base.Led<bool>();
			this.label1 = new NxtControl.GuiFramework.Label();
			this.led_11 = new System.HMI.Symbols.Base.Led<bool>();
			this.label2 = new NxtControl.GuiFramework.Label();
			this.led_12 = new System.HMI.Symbols.Base.Led<bool>();
			this.label3 = new NxtControl.GuiFramework.Label();
			this.led_13 = new System.HMI.Symbols.Base.Led<bool>();
			this.label4 = new NxtControl.GuiFramework.Label();
			this.Error_Value = new System.HMI.Symbols.Base.FreeText<short>();
			this.freeText1 = new NxtControl.GuiFramework.FreeText();
			this.Status_Value = new System.HMI.Symbols.Base.FreeText<short>();
			this.freeText2 = new NxtControl.GuiFramework.FreeText();
			this.Temp_C = new System.HMI.Symbols.Base.FreeText<float>();
			this.freeText3 = new NxtControl.GuiFramework.FreeText();
			this.DaysToMaintenance = new System.HMI.Symbols.Base.Label<short>();
			this.freeText4 = new NxtControl.GuiFramework.FreeText();
			this.freeText5 = new NxtControl.GuiFramework.FreeText();
			this.Reliability = new System.HMI.Symbols.Base.Label<short>();
			this.roundedRectangle1 = new NxtControl.GuiFramework.RoundedRectangle();
			this.label5 = new NxtControl.GuiFramework.Label();
			this.ChFailAlarm = new System.HMI.Symbols.Base.Led<bool>();
			this.group1 = new NxtControl.GuiFramework.Group();
			this.led_14 = new System.HMI.Symbols.Base.Led<bool>();
			this.label6 = new NxtControl.GuiFramework.Label();
			// 
			// CommonError
			// 
			this.CommonError.BeginInit();
			this.CommonError.ColorFrame = new NxtControl.Drawing.Color("SE.Nereda.LedFrameColor");
			this.CommonError.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 159D, 30D);
			this.CommonError.FrameSize = 33F;
			this.CommonError.IsOnlyInput = true;
			this.CommonError.Name = "CommonError";
			propertyDictionary2.Add("Color", new NxtControl.Drawing.Color(((byte)(106)), ((byte)(106)), ((byte)(106))));
			propertyDictionary3.Add("Color", new NxtControl.Drawing.Color(((byte)(2)), ((byte)(192)), ((byte)(255))));
			this.CommonError.Ranges.Clear();
			this.CommonError.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(false, propertyDictionary2));
			this.CommonError.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(true, propertyDictionary3));
			propertyDictionary1.Add("Color", new NxtControl.Drawing.Color("SE.Nereda.LedFalseColor"));
			this.CommonError.Ranges.DefaultPropertyValues = propertyDictionary1;
			this.CommonError.TagName = "CommonError";
			this.CommonError.EndInit();
			// 
			// label1
			// 
			this.label1.AngleIgnore = true;
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label1.Bounds = new NxtControl.Drawing.RectF(((float)(17D)), ((float)(17D)), ((float)(160D)), ((float)(26D)));
			this.label1.Brush = new NxtControl.Drawing.Brush("LabelBrush");
			this.label1.Font = new NxtControl.Drawing.Font("LabelFont");
			this.label1.FontScale = true;
			this.label1.Name = "label1";
			this.label1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.label1.Text = "Common Error";
			this.label1.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.label1.TextAutoSizeHorizontalOffset = 10;
			this.label1.TextPadding = new NxtControl.Drawing.Padding(2);
			// 
			// led_11
			// 
			this.led_11.BeginInit();
			this.led_11.ColorFrame = new NxtControl.Drawing.Color("SE.Nereda.LedFrameColor");
			this.led_11.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 159D, 61D);
			this.led_11.FrameSize = 33F;
			this.led_11.IsOnlyInput = true;
			this.led_11.Name = "led_11";
			propertyDictionary5.Add("Color", new NxtControl.Drawing.Color(((byte)(106)), ((byte)(106)), ((byte)(106))));
			propertyDictionary6.Add("Color", new NxtControl.Drawing.Color(((byte)(2)), ((byte)(192)), ((byte)(255))));
			this.led_11.Ranges.Clear();
			this.led_11.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(false, propertyDictionary5));
			this.led_11.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(true, propertyDictionary6));
			propertyDictionary4.Add("Color", new NxtControl.Drawing.Color("SE.Nereda.LedFalseColor"));
			this.led_11.Ranges.DefaultPropertyValues = propertyDictionary4;
			this.led_11.TagName = "Calibrating";
			this.led_11.EndInit();
			// 
			// label2
			// 
			this.label2.AngleIgnore = true;
			this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label2.Bounds = new NxtControl.Drawing.RectF(((float)(17D)), ((float)(48D)), ((float)(160D)), ((float)(26D)));
			this.label2.Brush = new NxtControl.Drawing.Brush("LabelBrush");
			this.label2.Font = new NxtControl.Drawing.Font("LabelFont");
			this.label2.FontScale = true;
			this.label2.Name = "label2";
			this.label2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.label2.Text = "Calibrating";
			this.label2.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.label2.TextAutoSizeHorizontalOffset = 10;
			this.label2.TextPadding = new NxtControl.Drawing.Padding(2);
			// 
			// led_12
			// 
			this.led_12.BeginInit();
			this.led_12.ColorFrame = new NxtControl.Drawing.Color("SE.Nereda.LedFrameColor");
			this.led_12.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 159D, 92D);
			this.led_12.FrameSize = 33F;
			this.led_12.IsOnlyInput = true;
			this.led_12.Name = "led_12";
			propertyDictionary8.Add("Color", new NxtControl.Drawing.Color(((byte)(106)), ((byte)(106)), ((byte)(106))));
			propertyDictionary9.Add("Color", new NxtControl.Drawing.Color(((byte)(2)), ((byte)(192)), ((byte)(255))));
			this.led_12.Ranges.Clear();
			this.led_12.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(false, propertyDictionary8));
			this.led_12.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(true, propertyDictionary9));
			propertyDictionary7.Add("Color", new NxtControl.Drawing.Color("SE.Nereda.LedFalseColor"));
			this.led_12.Ranges.DefaultPropertyValues = propertyDictionary7;
			this.led_12.TagName = "_Service";
			this.led_12.EndInit();
			// 
			// label3
			// 
			this.label3.AngleIgnore = true;
			this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label3.Bounds = new NxtControl.Drawing.RectF(((float)(17D)), ((float)(79D)), ((float)(160D)), ((float)(26D)));
			this.label3.Brush = new NxtControl.Drawing.Brush("LabelBrush");
			this.label3.Font = new NxtControl.Drawing.Font("LabelFont");
			this.label3.FontScale = true;
			this.label3.Name = "label3";
			this.label3.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.label3.Text = "Service";
			this.label3.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.label3.TextAutoSizeHorizontalOffset = 10;
			this.label3.TextPadding = new NxtControl.Drawing.Padding(2);
			// 
			// led_13
			// 
			this.led_13.BeginInit();
			this.led_13.ColorFrame = new NxtControl.Drawing.Color("SE.Nereda.LedFrameColor");
			this.led_13.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 159D, 123D);
			this.led_13.FrameSize = 33F;
			this.led_13.IsOnlyInput = true;
			this.led_13.Name = "led_13";
			propertyDictionary11.Add("Color", new NxtControl.Drawing.Color(((byte)(106)), ((byte)(106)), ((byte)(106))));
			propertyDictionary12.Add("Color", new NxtControl.Drawing.Color(((byte)(2)), ((byte)(192)), ((byte)(255))));
			this.led_13.Ranges.Clear();
			this.led_13.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(false, propertyDictionary11));
			this.led_13.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(true, propertyDictionary12));
			propertyDictionary10.Add("Color", new NxtControl.Drawing.Color("SE.Nereda.LedFalseColor"));
			this.led_13.Ranges.DefaultPropertyValues = propertyDictionary10;
			this.led_13.TagName = "Cleaning";
			this.led_13.EndInit();
			// 
			// label4
			// 
			this.label4.AngleIgnore = true;
			this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label4.Bounds = new NxtControl.Drawing.RectF(((float)(17D)), ((float)(110D)), ((float)(160D)), ((float)(26D)));
			this.label4.Brush = new NxtControl.Drawing.Brush("LabelBrush");
			this.label4.Font = new NxtControl.Drawing.Font("LabelFont");
			this.label4.FontScale = true;
			this.label4.Name = "label4";
			this.label4.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.label4.Text = "Cleaning";
			this.label4.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.label4.TextAutoSizeHorizontalOffset = 10;
			this.label4.TextPadding = new NxtControl.Drawing.Padding(2);
			// 
			// Error_Value
			// 
			this.Error_Value.BeginInit();
			this.Error_Value.DecimalPlacesCount = ((uint)(2u));
			this.Error_Value.DesignMatrix = new NxtControl.Drawing.Matrix2D(55.751111111111108D, 0D, 0D, 1D, 100.00000000000006D, 207D);
			this.Error_Value.IsOnlyInput = true;
			this.Error_Value.Name = "Error_Value";
			propertyDictionary13.Add("Text", "${Value}");
			propertyDictionary13.Add("TextColor", new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			this.Error_Value.Ranges.DefaultPropertyValues = propertyDictionary13;
			this.Error_Value.TagName = "Error_Value";
			this.Error_Value.TextAngle = 0F;
			this.Error_Value.EndInit();
			// 
			// freeText1
			// 
			this.freeText1.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText1.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText1.Location = new NxtControl.Drawing.PointF(16D, 207D);
			this.freeText1.Name = "freeText1";
			this.freeText1.Text = "Error Value";
			// 
			// Status_Value
			// 
			this.Status_Value.BeginInit();
			this.Status_Value.DecimalPlacesCount = ((uint)(2u));
			this.Status_Value.DesignMatrix = new NxtControl.Drawing.Matrix2D(5.4666666666666668D, 0D, 0D, 1D, 100.00000000000006D, 234D);
			this.Status_Value.IsOnlyInput = true;
			this.Status_Value.Name = "Status_Value";
			propertyDictionary14.Add("Text", "${Value}");
			propertyDictionary14.Add("TextColor", new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			this.Status_Value.Ranges.DefaultPropertyValues = propertyDictionary14;
			this.Status_Value.TagName = "Status_Value";
			this.Status_Value.TextAngle = 0F;
			this.Status_Value.EndInit();
			// 
			// freeText2
			// 
			this.freeText2.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText2.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText2.Location = new NxtControl.Drawing.PointF(16D, 234D);
			this.freeText2.Name = "freeText2";
			this.freeText2.Text = "Status Value";
			// 
			// Temp_C
			// 
			this.Temp_C.BeginInit();
			this.Temp_C.DecimalPlacesCount = ((uint)(2u));
			this.Temp_C.DesignMatrix = new NxtControl.Drawing.Matrix2D(2.5806451612903225D, 0D, 0D, 1D, 100D, 261D);
			this.Temp_C.IsOnlyInput = true;
			this.Temp_C.Name = "Temp_C";
			this.Temp_C.Ranges.Clear();
			this.Temp_C.Ranges.Add(new NxtControl.GuiFramework.Range<float>(null, true, null, true, propertyDictionary16));
			propertyDictionary15.Add("Text", "${Value}");
			propertyDictionary15.Add("TextColor", new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			this.Temp_C.Ranges.DefaultPropertyValues = propertyDictionary15;
			this.Temp_C.TagName = "Temp_C";
			this.Temp_C.TextAngle = 0F;
			this.Temp_C.EndInit();
			// 
			// freeText3
			// 
			this.freeText3.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText3.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText3.Location = new NxtControl.Drawing.PointF(16D, 261D);
			this.freeText3.Name = "freeText3";
			this.freeText3.Text = "Temp Value";
			// 
			// DaysToMaintenance
			// 
			this.DaysToMaintenance.BeginInit();
			this.DaysToMaintenance.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.DaysToMaintenance.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.55333333333333334D, 0D, 0D, 1D, 100D, 316D);
			this.DaysToMaintenance.FontScale = false;
			this.DaysToMaintenance.IsOnlyInput = true;
			this.DaysToMaintenance.LeadingZeros = ((uint)(0u));
			this.DaysToMaintenance.Name = "DaysToMaintenance";
			this.DaysToMaintenance.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			propertyDictionary17.Add("Text", "${Value}");
			propertyDictionary17.Add("TextColor", new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			propertyDictionary17.Add("Brush", new NxtControl.Drawing.Brush("LabelBrush"));
			propertyDictionary17.Add("Pen", new NxtControl.Drawing.Pen("LabelPen"));
			this.DaysToMaintenance.Ranges.DefaultPropertyValues = propertyDictionary17;
			this.DaysToMaintenance.TagName = "DaysToMaintenance";
			this.DaysToMaintenance.EndInit();
			// 
			// freeText4
			// 
			this.freeText4.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText4.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText4.Location = new NxtControl.Drawing.PointF(16D, 319D);
			this.freeText4.Name = "freeText4";
			this.freeText4.Text = "Days to maint";
			// 
			// freeText5
			// 
			this.freeText5.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText5.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText5.Location = new NxtControl.Drawing.PointF(16D, 291D);
			this.freeText5.Name = "freeText5";
			this.freeText5.Text = "Reliability";
			// 
			// Reliability
			// 
			this.Reliability.BeginInit();
			this.Reliability.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Reliability.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.54D, 0D, 0D, 1D, 101D, 287D);
			this.Reliability.FontScale = false;
			this.Reliability.IsOnlyInput = true;
			this.Reliability.LeadingZeros = ((uint)(0u));
			this.Reliability.Name = "Reliability";
			this.Reliability.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			propertyDictionary18.Add("Text", "${Value}");
			propertyDictionary18.Add("TextColor", new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			propertyDictionary18.Add("Brush", new NxtControl.Drawing.Brush("LabelBrush"));
			propertyDictionary18.Add("Pen", new NxtControl.Drawing.Pen("LabelPen"));
			this.Reliability.Ranges.DefaultPropertyValues = propertyDictionary18;
			this.Reliability.TagName = "Reliability";
			this.Reliability.EndInit();
			// 
			// roundedRectangle1
			// 
			this.roundedRectangle1.Bounds = new NxtControl.Drawing.RectF(((float)(8D)), ((float)(8D)), ((float)(177D)), ((float)(337D)));
			this.roundedRectangle1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(245)), ((byte)(245)), ((byte)(245))));
			this.roundedRectangle1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.roundedRectangle1.Name = "roundedRectangle1";
			this.roundedRectangle1.Radius = 10D;
			// 
			// label5
			// 
			this.label5.AngleIgnore = true;
			this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label5.Bounds = new NxtControl.Drawing.RectF(((float)(17D)), ((float)(141D)), ((float)(160D)), ((float)(26D)));
			this.label5.Brush = new NxtControl.Drawing.Brush("LabelBrush");
			this.label5.Font = new NxtControl.Drawing.Font("LabelFont");
			this.label5.FontScale = true;
			this.label5.Name = "label5";
			this.label5.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.label5.Text = "Channel Failure";
			this.label5.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.label5.TextAutoSizeHorizontalOffset = 10;
			this.label5.TextPadding = new NxtControl.Drawing.Padding(2);
			// 
			// ChFailAlarm
			// 
			this.ChFailAlarm.BeginInit();
			this.ChFailAlarm.ColorFrame = new NxtControl.Drawing.Color("LedFrameColor");
			this.ChFailAlarm.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 159D, 154D);
			this.ChFailAlarm.FrameSize = 33F;
			this.ChFailAlarm.IsOnlyInput = true;
			this.ChFailAlarm.Name = "ChFailAlarm";
			propertyDictionary20.Add("Color", new NxtControl.Drawing.Color(((byte)(106)), ((byte)(106)), ((byte)(106))));
			propertyDictionary21.Add("Color", new NxtControl.Drawing.BlinkColor("SE.HwCommon.DevLEDOrangeRedFlash"));
			this.ChFailAlarm.Ranges.Clear();
			this.ChFailAlarm.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(false, propertyDictionary20));
			this.ChFailAlarm.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(true, propertyDictionary21));
			propertyDictionary19.Add("Color", new NxtControl.Drawing.Color("LedFalseColor"));
			this.ChFailAlarm.Ranges.DefaultPropertyValues = propertyDictionary19;
			this.ChFailAlarm.TagName = "ChFailAlarm";
			this.ChFailAlarm.EndInit();
			// 
			// group1
			// 
			this.group1.BeginInit();
			this.group1.Name = "group1";
			this.group1.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.Error_Value,
			this.freeText1,
			this.Status_Value,
			this.freeText2,
			this.Temp_C,
			this.freeText3,
			this.DaysToMaintenance,
			this.freeText4,
			this.freeText5,
			this.Reliability});
			this.group1.EndInit();
			// 
			// led_14
			// 
			this.led_14.BeginInit();
			this.led_14.ColorFrame = new NxtControl.Drawing.Color("LedFrameColor");
			this.led_14.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 159D, 185D);
			this.led_14.FrameSize = 33F;
			this.led_14.IsOnlyInput = true;
			this.led_14.Name = "led_14";
			propertyDictionary23.Add("Color", new NxtControl.Drawing.Color(((byte)(106)), ((byte)(106)), ((byte)(106))));
			propertyDictionary24.Add("Color", new NxtControl.Drawing.BlinkColor("SE.HwCommon.DevLEDOrangeRedFlash"));
			this.led_14.Ranges.Clear();
			this.led_14.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(false, propertyDictionary23));
			this.led_14.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(true, propertyDictionary24));
			propertyDictionary22.Add("Color", new NxtControl.Drawing.Color("LedFalseColor"));
			this.led_14.Ranges.DefaultPropertyValues = propertyDictionary22;
			this.led_14.TagName = "OverrideStatus";
			this.led_14.EndInit();
			// 
			// label6
			// 
			this.label6.AngleIgnore = true;
			this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label6.Bounds = new NxtControl.Drawing.RectF(((float)(17D)), ((float)(172D)), ((float)(160D)), ((float)(26D)));
			this.label6.Brush = new NxtControl.Drawing.Brush("LabelBrush");
			this.label6.Font = new NxtControl.Drawing.Font("LabelFont");
			this.label6.FontScale = true;
			this.label6.Name = "label6";
			this.label6.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.label6.Text = "Override Status";
			this.label6.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.label6.TextAutoSizeHorizontalOffset = 10;
			this.label6.TextPadding = new NxtControl.Drawing.Padding(2);
			// 
			// fpStatus
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(192D)), ((float)(352D)));
			this.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(154)), ((byte)(154)), ((byte)(154))));
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.roundedRectangle1,
			this.led_14,
			this.label6,
			this.CommonError,
			this.led_11,
			this.led_12,
			this.led_13,
			this.ChFailAlarm,
			this.label1,
			this.label2,
			this.label3,
			this.label4,
			this.label5,
			this.group1});
			this.Size = new System.Drawing.Size(192, 352);

		}
		private System.HMI.Symbols.Base.Led<bool> CommonError;
		private NxtControl.GuiFramework.Label label1;
		private System.HMI.Symbols.Base.Led<bool> led_11;
		private NxtControl.GuiFramework.Label label2;
		private System.HMI.Symbols.Base.Led<bool> led_12;
		private NxtControl.GuiFramework.Label label3;
		private System.HMI.Symbols.Base.Led<bool> led_13;
		private NxtControl.GuiFramework.Label label4;
		private System.HMI.Symbols.Base.FreeText<short> Error_Value;
		private NxtControl.GuiFramework.FreeText freeText1;
		private System.HMI.Symbols.Base.FreeText<short> Status_Value;
		private NxtControl.GuiFramework.FreeText freeText2;
		private System.HMI.Symbols.Base.FreeText<float> Temp_C;
		private NxtControl.GuiFramework.FreeText freeText3;
		private System.HMI.Symbols.Base.Label<short> DaysToMaintenance;
		private NxtControl.GuiFramework.FreeText freeText4;
		private NxtControl.GuiFramework.FreeText freeText5;
		private System.HMI.Symbols.Base.Label<short> Reliability;
		private NxtControl.GuiFramework.RoundedRectangle roundedRectangle1;
		private NxtControl.GuiFramework.Label label5;
		private System.HMI.Symbols.Base.Led<bool> ChFailAlarm;
		private NxtControl.GuiFramework.Group group1;
		private System.HMI.Symbols.Base.Led<bool> led_14;
		private NxtControl.GuiFramework.Label label6;
		#endregion
	}
}
