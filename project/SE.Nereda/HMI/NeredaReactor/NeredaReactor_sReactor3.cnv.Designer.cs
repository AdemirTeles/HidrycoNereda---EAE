/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 6/9/2026
 * Time: 7:02 PM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.NeredaReactor
{
	/// <summary>
	/// Summary description for sReactor1.
	/// </summary>
	partial class sReactor3
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sReactor3));
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
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary14 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary15 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary13 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary17 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary18 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary16 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary20 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary21 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary19 = new NxtControl.GuiFramework.PropertyDictionary();
			this.AirBubbles1 = new NxtControl.GuiFramework.Rectangle();
			this.AirBubbles2 = new NxtControl.GuiFramework.Rectangle();
			this.sPvBarVer1 = new SE.Nereda.Symbols.AnalogInput.sPvBarVer();
			this.FeedRun = new System.HMI.Symbols.Base.Led<bool>();
			this.freeText1 = new NxtControl.GuiFramework.FreeText();
			this.freeText2 = new NxtControl.GuiFramework.FreeText();
			this.LowerLevelRun = new System.HMI.Symbols.Base.Led<bool>();
			this.AerateRun = new System.HMI.Symbols.Base.Led<bool>();
			this.VentRun = new System.HMI.Symbols.Base.Led<bool>();
			this.SludgeDischargeRun = new System.HMI.Symbols.Base.Led<bool>();
			this.freeText3 = new NxtControl.GuiFramework.FreeText();
			this.freeText4 = new NxtControl.GuiFramework.FreeText();
			this.freeText5 = new NxtControl.GuiFramework.FreeText();
			this.roundedRectangle3 = new NxtControl.GuiFramework.RoundedRectangle();
			this.ReactorState = new NxtControl.GuiFramework.RoundedRectangle();
			this.ellipse1 = new NxtControl.GuiFramework.Ellipse();
			this.WaterLevel = new NxtControl.GuiFramework.Rectangle();
			this.ellipse3 = new NxtControl.GuiFramework.Ellipse();
			this.line1 = new NxtControl.GuiFramework.Line();
			this.line2 = new NxtControl.GuiFramework.Line();
			this.line3 = new NxtControl.GuiFramework.Line();
			this.line4 = new NxtControl.GuiFramework.Line();
			this.line5 = new NxtControl.GuiFramework.Line();
			this.ellipse4 = new NxtControl.GuiFramework.Ellipse();
			this.WaterTop = new NxtControl.GuiFramework.Ellipse();
			this.line6 = new NxtControl.GuiFramework.Line();
			this.line7 = new NxtControl.GuiFramework.Line();
			this.line12 = new NxtControl.GuiFramework.Line();
			this.ellipse14 = new NxtControl.GuiFramework.Ellipse();
			this.ellipse15 = new NxtControl.GuiFramework.Ellipse();
			this.rectangle2 = new NxtControl.GuiFramework.Rectangle();
			this.rectangle3 = new NxtControl.GuiFramework.Rectangle();
			this.ellipse16 = new NxtControl.GuiFramework.Ellipse();
			this.WaterBase = new NxtControl.GuiFramework.Ellipse();
			this.group1 = new NxtControl.GuiFramework.Group();
			this.REACTOR = new NxtControl.GuiFramework.Rectangle();
			this.VentAerationGridRun = new System.HMI.Symbols.Base.Led<bool>();
			this.VentSludgeGridRun = new System.HMI.Symbols.Base.Led<bool>();
			this.freeText6 = new NxtControl.GuiFramework.FreeText();
			this.freeText7 = new NxtControl.GuiFramework.FreeText();
			this.group2 = new NxtControl.GuiFramework.Group();
			// 
			// AirBubbles1
			// 
			this.AirBubbles1.Bounds = new NxtControl.Drawing.RectF(((float)(72D)), ((float)(296D)), ((float)(200D)), ((float)(96D)));
			this.AirBubbles1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("transparent"));
			this.AirBubbles1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.AirBubbles1.ImageBytes = resources.GetString("AirBubbles1.ImageBytes");
			this.AirBubbles1.Name = "AirBubbles1";
			this.AirBubbles1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// AirBubbles2
			// 
			this.AirBubbles2.Bounds = new NxtControl.Drawing.RectF(((float)(48D)), ((float)(160D)), ((float)(248D)), ((float)(136D)));
			this.AirBubbles2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("transparent"));
			this.AirBubbles2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.AirBubbles2.ImageBytes = resources.GetString("AirBubbles2.ImageBytes");
			this.AirBubbles2.Name = "AirBubbles2";
			this.AirBubbles2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// sPvBarVer1
			// 
			this.sPvBarVer1.BeginInit();
			this.sPvBarVer1._iSensorName = "";
			this.sPvBarVer1._iUnit = "m";
			this.sPvBarVer1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1.5D, 0D, 0D, 1.5D, 48D, 114D);
			this.sPvBarVer1.Name = "sPvBarVer1";
			this.sPvBarVer1.SecurityToken = ((uint)(4294967295u));
			this.sPvBarVer1.TagName = "Sensors.LevelMeasurementReactor";
			this.sPvBarVer1.EndInit();
			// 
			// FeedRun
			// 
			this.FeedRun.BeginInit();
			this.FeedRun.ColorFrame = new NxtControl.Drawing.Color("LedFrameColor");
			this.FeedRun.DesignMatrix = new NxtControl.Drawing.Matrix2D(1.1666666666666665D, 0D, 0D, 1.1666666666666665D, 164D, 215D);
			this.FeedRun.FrameSize = 33F;
			this.FeedRun.IsOnlyInput = true;
			this.FeedRun.Name = "FeedRun";
			propertyDictionary2.Add("Color", new NxtControl.Drawing.Color("LedFalseColor"));
			propertyDictionary3.Add("Color", new NxtControl.Drawing.Color("DevAnalogOut"));
			this.FeedRun.Ranges.Clear();
			this.FeedRun.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(false, propertyDictionary2));
			this.FeedRun.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(true, propertyDictionary3));
			propertyDictionary1.Add("Color", new NxtControl.Drawing.Color("LedFalseColor"));
			this.FeedRun.Ranges.DefaultPropertyValues = propertyDictionary1;
			this.FeedRun.TagName = "FeedRun";
			this.FeedRun.EndInit();
			// 
			// freeText1
			// 
			this.freeText1.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText1.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.freeText1.Location = new NxtControl.Drawing.PointF(176D, 208D);
			this.freeText1.Name = "freeText1";
			this.freeText1.Text = "Phase Feed";
			// 
			// freeText2
			// 
			this.freeText2.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText2.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.freeText2.Location = new NxtControl.Drawing.PointF(176D, 232D);
			this.freeText2.Name = "freeText2";
			this.freeText2.Text = "Phase LowerLevel";
			// 
			// LowerLevelRun
			// 
			this.LowerLevelRun.BeginInit();
			this.LowerLevelRun.ColorFrame = new NxtControl.Drawing.Color("LedFrameColor");
			this.LowerLevelRun.DesignMatrix = new NxtControl.Drawing.Matrix2D(1.1666666666666665D, 0D, 0D, 1.1666666666666665D, 164D, 239D);
			this.LowerLevelRun.FrameSize = 33F;
			this.LowerLevelRun.IsOnlyInput = true;
			this.LowerLevelRun.Name = "LowerLevelRun";
			propertyDictionary5.Add("Color", new NxtControl.Drawing.Color("LedFalseColor"));
			propertyDictionary6.Add("Color", new NxtControl.Drawing.Color("DevAnalogOut"));
			this.LowerLevelRun.Ranges.Clear();
			this.LowerLevelRun.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(false, propertyDictionary5));
			this.LowerLevelRun.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(true, propertyDictionary6));
			propertyDictionary4.Add("Color", new NxtControl.Drawing.Color("LedFalseColor"));
			this.LowerLevelRun.Ranges.DefaultPropertyValues = propertyDictionary4;
			this.LowerLevelRun.TagName = "LowerLevelRun";
			this.LowerLevelRun.EndInit();
			// 
			// AerateRun
			// 
			this.AerateRun.BeginInit();
			this.AerateRun.ColorFrame = new NxtControl.Drawing.Color("LedFrameColor");
			this.AerateRun.DesignMatrix = new NxtControl.Drawing.Matrix2D(1.1666666666666665D, 0D, 0D, 1.1666666666666665D, 164D, 263D);
			this.AerateRun.FrameSize = 33F;
			this.AerateRun.IsOnlyInput = true;
			this.AerateRun.Name = "AerateRun";
			propertyDictionary8.Add("Color", new NxtControl.Drawing.Color("LedFalseColor"));
			propertyDictionary9.Add("Color", new NxtControl.Drawing.Color("DevAnalogOut"));
			this.AerateRun.Ranges.Clear();
			this.AerateRun.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(false, propertyDictionary8));
			this.AerateRun.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(true, propertyDictionary9));
			propertyDictionary7.Add("Color", new NxtControl.Drawing.Color("LedFalseColor"));
			this.AerateRun.Ranges.DefaultPropertyValues = propertyDictionary7;
			this.AerateRun.TagName = "AerateRun";
			this.AerateRun.EndInit();
			// 
			// VentRun
			// 
			this.VentRun.BeginInit();
			this.VentRun.ColorFrame = new NxtControl.Drawing.Color("LedFrameColor");
			this.VentRun.DesignMatrix = new NxtControl.Drawing.Matrix2D(1.1666666666666665D, 0D, 0D, 1.1666666666666665D, 164D, 287D);
			this.VentRun.FrameSize = 33F;
			this.VentRun.IsOnlyInput = true;
			this.VentRun.Name = "VentRun";
			propertyDictionary11.Add("Color", new NxtControl.Drawing.Color("LedFalseColor"));
			propertyDictionary12.Add("Color", new NxtControl.Drawing.Color("DevAnalogOut"));
			this.VentRun.Ranges.Clear();
			this.VentRun.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(false, propertyDictionary11));
			this.VentRun.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(true, propertyDictionary12));
			propertyDictionary10.Add("Color", new NxtControl.Drawing.Color("LedFalseColor"));
			this.VentRun.Ranges.DefaultPropertyValues = propertyDictionary10;
			this.VentRun.TagName = "WaitRun";
			this.VentRun.EndInit();
			// 
			// SludgeDischargeRun
			// 
			this.SludgeDischargeRun.BeginInit();
			this.SludgeDischargeRun.ColorFrame = new NxtControl.Drawing.Color("LedFrameColor");
			this.SludgeDischargeRun.DesignMatrix = new NxtControl.Drawing.Matrix2D(1.1666666666666665D, 0D, 0D, 1.1666666666666665D, 164D, 311D);
			this.SludgeDischargeRun.FrameSize = 33F;
			this.SludgeDischargeRun.IsOnlyInput = true;
			this.SludgeDischargeRun.Name = "SludgeDischargeRun";
			propertyDictionary14.Add("Color", new NxtControl.Drawing.Color("LedFalseColor"));
			propertyDictionary15.Add("Color", new NxtControl.Drawing.Color("DevAnalogOut"));
			this.SludgeDischargeRun.Ranges.Clear();
			this.SludgeDischargeRun.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(false, propertyDictionary14));
			this.SludgeDischargeRun.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(true, propertyDictionary15));
			propertyDictionary13.Add("Color", new NxtControl.Drawing.Color("LedFalseColor"));
			this.SludgeDischargeRun.Ranges.DefaultPropertyValues = propertyDictionary13;
			this.SludgeDischargeRun.TagName = "SludgeDischargeRun";
			this.SludgeDischargeRun.EndInit();
			// 
			// freeText3
			// 
			this.freeText3.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText3.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.freeText3.Location = new NxtControl.Drawing.PointF(176D, 256D);
			this.freeText3.Name = "freeText3";
			this.freeText3.Text = "Phase Aerate";
			// 
			// freeText4
			// 
			this.freeText4.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText4.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.freeText4.Location = new NxtControl.Drawing.PointF(176D, 280D);
			this.freeText4.Name = "freeText4";
			this.freeText4.Text = "Phase Wait";
			// 
			// freeText5
			// 
			this.freeText5.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText5.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.freeText5.Location = new NxtControl.Drawing.PointF(176D, 304D);
			this.freeText5.Name = "freeText5";
			this.freeText5.Text = "Phase SludgeDischarge";
			// 
			// roundedRectangle3
			// 
			this.roundedRectangle3.Bounds = new NxtControl.Drawing.RectF(((float)(152D)), ((float)(200D)), ((float)(184D)), ((float)(176D)));
			this.roundedRectangle3.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255))), new NxtControl.Drawing.GradientFill(NxtControl.Drawing.GradientFillOrientation.DiagonalLeftTop));
			this.roundedRectangle3.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.roundedRectangle3.Name = "roundedRectangle3";
			this.roundedRectangle3.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(114)), ((byte)(114)), ((byte)(114))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// ReactorState
			// 
			this.ReactorState.Bounds = new NxtControl.Drawing.RectF(((float)(88D)), ((float)(60D)), ((float)(232D)), ((float)(32D)));
			this.ReactorState.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(78)), ((byte)(78)), ((byte)(78))));
			this.ReactorState.Font = new NxtControl.Drawing.Font("Arial", 6F, System.Drawing.FontStyle.Bold);
			this.ReactorState.Name = "ReactorState";
			this.ReactorState.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(78)), ((byte)(78)), ((byte)(78))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.ReactorState.Text = "State";
			this.ReactorState.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			this.ReactorState.TextColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(0)));
			// 
			// ellipse1
			// 
			this.ellipse1.Bounds = new NxtControl.Drawing.RectF(((float)(159.77142857142854D)), ((float)(32D)), ((float)(88.457142857142827D)), ((float)(32D)));
			this.ellipse1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255))), new NxtControl.Drawing.GradientFill(NxtControl.Drawing.GradientFillOrientation.HorizontalCenter));
			this.ellipse1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.ellipse1.Name = "ellipse1";
			this.ellipse1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(78)), ((byte)(78)), ((byte)(78))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// WaterLevel
			// 
			this.WaterLevel.Bounds = new NxtControl.Drawing.RectF(((float)(51.657142857142858D)), ((float)(152D)), ((float)(304.68571428571431D)), ((float)(216D)));
			this.WaterLevel.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(165)), ((byte)(213)), ((byte)(226))));
			this.WaterLevel.FillDirection = NxtControl.Drawing.FillDirection.DownToTop;
			this.WaterLevel.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.WaterLevel.Name = "WaterLevel";
			this.WaterLevel.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// ellipse3
			// 
			this.ellipse3.Bounds = new NxtControl.Drawing.RectF(((float)(51.657142857142858D)), ((float)(320D)), ((float)(304.68571428571431D)), ((float)(88D)));
			this.ellipse3.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(154)), ((byte)(154)), ((byte)(154))), new NxtControl.Drawing.GradientFill(NxtControl.Drawing.GradientFillOrientation.HorizontalCenter, NxtControl.Drawing.GradientFillBrightness.Dark));
			this.ellipse3.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.ellipse3.Name = "ellipse3";
			this.ellipse3.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(78)), ((byte)(78)), ((byte)(78))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// line1
			// 
			this.line1.EndPoint = new NxtControl.Drawing.PointF(307.2D, 32D);
			this.line1.Name = "line1";
			this.line1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line1.StartPoint = new NxtControl.Drawing.PointF(248.22857142857137D, 40D);
			// 
			// line2
			// 
			this.line2.EndPoint = new NxtControl.Drawing.PointF(159.77142857142854D, 40D);
			this.line2.Name = "line2";
			this.line2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line2.StartPoint = new NxtControl.Drawing.PointF(100.79999999999998D, 32D);
			// 
			// line3
			// 
			this.line3.EndPoint = new NxtControl.Drawing.PointF(376D, 64D);
			this.line3.Name = "line3";
			this.line3.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line3.StartPoint = new NxtControl.Drawing.PointF(248.22857142857137D, 48D);
			// 
			// line4
			// 
			this.line4.EndPoint = new NxtControl.Drawing.PointF(238.39999999999998D, 56D);
			this.line4.Name = "line4";
			this.line4.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line4.StartPoint = new NxtControl.Drawing.PointF(336.68571428571431D, 96D);
			// 
			// line5
			// 
			this.line5.EndPoint = new NxtControl.Drawing.PointF(218.74285714285713D, 64D);
			this.line5.Name = "line5";
			this.line5.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line5.StartPoint = new NxtControl.Drawing.PointF(248.22857142857137D, 112D);
			// 
			// ellipse4
			// 
			this.ellipse4.Bounds = new NxtControl.Drawing.RectF(((float)(159.77142857142854D)), ((float)(24D)), ((float)(88.457142857142827D)), ((float)(32D)));
			this.ellipse4.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(114)), ((byte)(114)), ((byte)(114))));
			this.ellipse4.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.ellipse4.Name = "ellipse4";
			this.ellipse4.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(78)), ((byte)(78)), ((byte)(78))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// WaterTop
			// 
			this.WaterTop.Bounds = new NxtControl.Drawing.RectF(((float)(51.657142857142858D)), ((float)(112D)), ((float)(304.68571428571431D)), ((float)(88D)));
			this.WaterTop.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(165)), ((byte)(213)), ((byte)(226))));
			this.WaterTop.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.WaterTop.Name = "WaterTop";
			this.WaterTop.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(120)), ((byte)(192)), ((byte)(212))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// line6
			// 
			this.line6.EndPoint = new NxtControl.Drawing.PointF(189.25714285714284D, 64D);
			this.line6.Name = "line6";
			this.line6.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line6.StartPoint = new NxtControl.Drawing.PointF(159.77142857142854D, 112D);
			// 
			// line7
			// 
			this.line7.EndPoint = new NxtControl.Drawing.PointF(169.6D, 56D);
			this.line7.Name = "line7";
			this.line7.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line7.StartPoint = new NxtControl.Drawing.PointF(71.314285714285717D, 96D);
			// 
			// line12
			// 
			this.line12.EndPoint = new NxtControl.Drawing.PointF(159.77142857142854D, 48D);
			this.line12.Name = "line12";
			this.line12.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line12.StartPoint = new NxtControl.Drawing.PointF(32D, 64D);
			// 
			// ellipse14
			// 
			this.ellipse14.Bounds = new NxtControl.Drawing.RectF(((float)(32D)), ((float)(24D)), ((float)(344D)), ((float)(88D)));
			this.ellipse14.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255))), new NxtControl.Drawing.GradientFill(NxtControl.Drawing.GradientFillOrientation.DiagonalRightTop));
			this.ellipse14.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.ellipse14.Name = "ellipse14";
			this.ellipse14.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(78)), ((byte)(78)), ((byte)(78))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// ellipse15
			// 
			this.ellipse15.Bounds = new NxtControl.Drawing.RectF(((float)(32D)), ((float)(56D)), ((float)(344D)), ((float)(88D)));
			this.ellipse15.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255))), new NxtControl.Drawing.GradientFill(NxtControl.Drawing.GradientFillOrientation.HorizontalCenter, NxtControl.Drawing.GradientFillBrightness.Dark));
			this.ellipse15.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.ellipse15.Name = "ellipse15";
			this.ellipse15.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(135)), ((byte)(135)), ((byte)(135))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// rectangle2
			// 
			this.rectangle2.Bounds = new NxtControl.Drawing.RectF(((float)(51.657142857142858D)), ((float)(112D)), ((float)(304.68571428571431D)), ((float)(256D)));
			this.rectangle2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(154)), ((byte)(154)), ((byte)(154))), new NxtControl.Drawing.GradientFill(NxtControl.Drawing.GradientFillOrientation.HorizontalCenter, NxtControl.Drawing.GradientFillBrightness.Dark));
			this.rectangle2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle2.Name = "rectangle2";
			this.rectangle2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// rectangle3
			// 
			this.rectangle3.Bounds = new NxtControl.Drawing.RectF(((float)(32D)), ((float)(64D)), ((float)(344D)), ((float)(328D)));
			this.rectangle3.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255))), new NxtControl.Drawing.GradientFill(NxtControl.Drawing.GradientFillOrientation.HorizontalCenter, NxtControl.Drawing.GradientFillBrightness.Dark));
			this.rectangle3.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle3.Name = "rectangle3";
			this.rectangle3.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// ellipse16
			// 
			this.ellipse16.Bounds = new NxtControl.Drawing.RectF(((float)(32D)), ((float)(344D)), ((float)(344D)), ((float)(88D)));
			this.ellipse16.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255))), new NxtControl.Drawing.GradientFill(NxtControl.Drawing.GradientFillOrientation.HorizontalCenter, NxtControl.Drawing.GradientFillBrightness.Dark));
			this.ellipse16.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.ellipse16.Name = "ellipse16";
			this.ellipse16.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(78)), ((byte)(78)), ((byte)(78))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// WaterBase
			// 
			this.WaterBase.Bounds = new NxtControl.Drawing.RectF(((float)(51.657142857142858D)), ((float)(320D)), ((float)(304.68571428571431D)), ((float)(88D)));
			this.WaterBase.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(165)), ((byte)(213)), ((byte)(226))));
			this.WaterBase.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.WaterBase.Name = "WaterBase";
			this.WaterBase.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// group1
			// 
			this.group1.BeginInit();
			this.group1.Name = "group1";
			this.group1.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.ellipse16,
			this.rectangle3,
			this.ellipse3,
			this.rectangle2,
			this.WaterBase,
			this.WaterLevel,
			this.WaterTop,
			this.ellipse15,
			this.ellipse14,
			this.line12,
			this.line7,
			this.line6,
			this.ellipse1,
			this.ellipse4,
			this.line5,
			this.line4,
			this.line3,
			this.line2,
			this.line1});
			this.group1.EndInit();
			// 
			// REACTOR
			// 
			this.REACTOR.Bounds = new NxtControl.Drawing.RectF(((float)(64D)), ((float)(104D)), ((float)(280D)), ((float)(40D)));
			this.REACTOR.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("transparent"));
			this.REACTOR.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.REACTOR.Name = "REACTOR";
			this.REACTOR.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.REACTOR.Text = "REACTOR 1";
			this.REACTOR.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			// 
			// VentAerationGridRun
			// 
			this.VentAerationGridRun.BeginInit();
			this.VentAerationGridRun.ColorFrame = new NxtControl.Drawing.Color("LedFrameColor");
			this.VentAerationGridRun.DesignMatrix = new NxtControl.Drawing.Matrix2D(1.1666666666666665D, 0D, 0D, 1.1666666666666665D, 164D, 335D);
			this.VentAerationGridRun.FrameSize = 33F;
			this.VentAerationGridRun.IsOnlyInput = true;
			this.VentAerationGridRun.Name = "VentAerationGridRun";
			propertyDictionary17.Add("Color", new NxtControl.Drawing.Color("LedFalseColor"));
			propertyDictionary18.Add("Color", new NxtControl.Drawing.Color("DevAnalogOut"));
			this.VentAerationGridRun.Ranges.Clear();
			this.VentAerationGridRun.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(false, propertyDictionary17));
			this.VentAerationGridRun.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(true, propertyDictionary18));
			propertyDictionary16.Add("Color", new NxtControl.Drawing.Color("LedFalseColor"));
			this.VentAerationGridRun.Ranges.DefaultPropertyValues = propertyDictionary16;
			this.VentAerationGridRun.TagName = "VentAerationGridRun";
			this.VentAerationGridRun.EndInit();
			// 
			// VentSludgeGridRun
			// 
			this.VentSludgeGridRun.BeginInit();
			this.VentSludgeGridRun.ColorFrame = new NxtControl.Drawing.Color("LedFrameColor");
			this.VentSludgeGridRun.DesignMatrix = new NxtControl.Drawing.Matrix2D(1.1666666666666665D, 0D, 0D, 1.1666666666666665D, 164D, 359D);
			this.VentSludgeGridRun.FrameSize = 33F;
			this.VentSludgeGridRun.IsOnlyInput = true;
			this.VentSludgeGridRun.Name = "VentSludgeGridRun";
			propertyDictionary20.Add("Color", new NxtControl.Drawing.Color("LedFalseColor"));
			propertyDictionary21.Add("Color", new NxtControl.Drawing.Color("DevAnalogOut"));
			this.VentSludgeGridRun.Ranges.Clear();
			this.VentSludgeGridRun.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(false, propertyDictionary20));
			this.VentSludgeGridRun.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(true, propertyDictionary21));
			propertyDictionary19.Add("Color", new NxtControl.Drawing.Color("LedFalseColor"));
			this.VentSludgeGridRun.Ranges.DefaultPropertyValues = propertyDictionary19;
			this.VentSludgeGridRun.TagName = "VentSludgeGridRun";
			this.VentSludgeGridRun.EndInit();
			// 
			// freeText6
			// 
			this.freeText6.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText6.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.freeText6.Location = new NxtControl.Drawing.PointF(176D, 328D);
			this.freeText6.Name = "freeText6";
			this.freeText6.Text = "Phase VentAerationGrid";
			// 
			// freeText7
			// 
			this.freeText7.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText7.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.freeText7.Location = new NxtControl.Drawing.PointF(176D, 352D);
			this.freeText7.Name = "freeText7";
			this.freeText7.Text = "Phase VentSludgeGrid";
			// 
			// group2
			// 
			this.group2.BeginInit();
			this.group2.Name = "group2";
			this.group2.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.roundedRectangle3,
			this.freeText1,
			this.freeText2,
			this.freeText3,
			this.freeText4,
			this.freeText5,
			this.FeedRun,
			this.LowerLevelRun,
			this.AerateRun,
			this.VentRun,
			this.SludgeDischargeRun,
			this.VentAerationGridRun,
			this.VentSludgeGridRun,
			this.freeText6,
			this.freeText7});
			this.group2.EndInit();
			// 
			// sReactor3
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.group1,
			this.AirBubbles2,
			this.AirBubbles1,
			this.sPvBarVer1,
			this.ReactorState,
			this.REACTOR,
			this.group2});
			this.SymbolSize = new System.Drawing.Size(616, 608);

		}
		private NxtControl.GuiFramework.Rectangle AirBubbles1;
		private NxtControl.GuiFramework.Rectangle AirBubbles2;
		private SE.Nereda.Symbols.AnalogInput.sPvBarVer sPvBarVer1;
		private System.HMI.Symbols.Base.Led<bool> FeedRun;
		private NxtControl.GuiFramework.FreeText freeText1;
		private NxtControl.GuiFramework.FreeText freeText2;
		private System.HMI.Symbols.Base.Led<bool> LowerLevelRun;
		private System.HMI.Symbols.Base.Led<bool> AerateRun;
		private System.HMI.Symbols.Base.Led<bool> VentRun;
		private System.HMI.Symbols.Base.Led<bool> SludgeDischargeRun;
		private NxtControl.GuiFramework.FreeText freeText3;
		private NxtControl.GuiFramework.FreeText freeText4;
		private NxtControl.GuiFramework.FreeText freeText5;
		private NxtControl.GuiFramework.RoundedRectangle roundedRectangle3;
		private NxtControl.GuiFramework.RoundedRectangle ReactorState;
		private NxtControl.GuiFramework.Group group1;
		private NxtControl.GuiFramework.Ellipse ellipse1;
		private NxtControl.GuiFramework.Rectangle WaterLevel;
		private NxtControl.GuiFramework.Ellipse ellipse3;
		private NxtControl.GuiFramework.Line line1;
		private NxtControl.GuiFramework.Line line2;
		private NxtControl.GuiFramework.Line line3;
		private NxtControl.GuiFramework.Line line4;
		private NxtControl.GuiFramework.Line line5;
		private NxtControl.GuiFramework.Ellipse ellipse4;
		private NxtControl.GuiFramework.Ellipse WaterTop;
		private NxtControl.GuiFramework.Line line6;
		private NxtControl.GuiFramework.Line line7;
		private NxtControl.GuiFramework.Line line12;
		private NxtControl.GuiFramework.Ellipse ellipse14;
		private NxtControl.GuiFramework.Ellipse ellipse15;
		private NxtControl.GuiFramework.Rectangle rectangle2;
		private NxtControl.GuiFramework.Rectangle rectangle3;
		private NxtControl.GuiFramework.Ellipse ellipse16;
		private NxtControl.GuiFramework.Ellipse WaterBase;
		private NxtControl.GuiFramework.Rectangle REACTOR;
		private System.HMI.Symbols.Base.Led<bool> VentAerationGridRun;
		private System.HMI.Symbols.Base.Led<bool> VentSludgeGridRun;
		private NxtControl.GuiFramework.FreeText freeText6;
		private NxtControl.GuiFramework.FreeText freeText7;
		private NxtControl.GuiFramework.Group group2;
		#endregion
	}
}
