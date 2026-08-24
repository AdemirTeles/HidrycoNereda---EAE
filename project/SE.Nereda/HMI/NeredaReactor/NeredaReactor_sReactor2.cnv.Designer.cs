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
	partial class sReactor2
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sReactor2));
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
			this.CV001 = new NxtControl.GuiFramework.FreeText();
			this.CV002 = new NxtControl.GuiFramework.FreeText();
			this.CV003 = new NxtControl.GuiFramework.FreeText();
			this.CV004 = new NxtControl.GuiFramework.FreeText();
			this.CV005 = new NxtControl.GuiFramework.FreeText();
			this.REACTOR = new NxtControl.GuiFramework.FreeText();
			this.pipe17 = new NxtControl.GuiFramework.Pipe();
			this.AirBubbles1 = new NxtControl.GuiFramework.Rectangle();
			this.AirBubbles2 = new NxtControl.GuiFramework.Rectangle();
			this.sPvBarVer1 = new SE.Nereda.Symbols.AnalogInput.sPvBarVer();
			this.FeedRun = new System.HMI.Symbols.Base.Led<bool>();
			this.freeText1 = new NxtControl.GuiFramework.FreeText();
			this.freeText2 = new NxtControl.GuiFramework.FreeText();
			this.AerateRun = new System.HMI.Symbols.Base.Led<bool>();
			this.SDRun = new System.HMI.Symbols.Base.Led<bool>();
			this.VentRun = new System.HMI.Symbols.Base.Led<bool>();
			this.WaitRun = new System.HMI.Symbols.Base.Led<bool>();
			this.freeText3 = new NxtControl.GuiFramework.FreeText();
			this.freeText4 = new NxtControl.GuiFramework.FreeText();
			this.freeText5 = new NxtControl.GuiFramework.FreeText();
			this.roundedRectangle3 = new NxtControl.GuiFramework.RoundedRectangle();
			this.ReactorState = new NxtControl.GuiFramework.RoundedRectangle();
			this.pipe22 = new NxtControl.GuiFramework.Pipe();
			this.s3DValve1 = new SE.Nereda.Symbols.ValveS.s3DValve();
			this.s3DValve2 = new SE.Nereda.Symbols.ValveS.s3DValve();
			this.s3DValve3 = new SE.Nereda.Symbols.ValveS.s3DValve();
			this.s3DValve4 = new SE.Nereda.Symbols.ValveS.s3DValve();
			this.pipe18 = new NxtControl.GuiFramework.Pipe();
			this.pipe20 = new NxtControl.GuiFramework.Pipe();
			this.pipe23 = new NxtControl.GuiFramework.Pipe();
			this.pipe24 = new NxtControl.GuiFramework.Pipe();
			this.pipe26 = new NxtControl.GuiFramework.Pipe();
			this.pipe27 = new NxtControl.GuiFramework.Pipe();
			this.pipe25 = new NxtControl.GuiFramework.Pipe();
			this.ellipse2 = new NxtControl.GuiFramework.Ellipse();
			this.ellipse11 = new NxtControl.GuiFramework.Ellipse();
			this.ellipse12 = new NxtControl.GuiFramework.Ellipse();
			this.s3DValve5 = new SE.Nereda.Symbols.ValveS.s3DValve();
			this.pipe28 = new NxtControl.GuiFramework.Pipe();
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
			this.rectangle1 = new NxtControl.GuiFramework.Rectangle();
			this.rectangle4 = new NxtControl.GuiFramework.Rectangle();
			this.rectangle5 = new NxtControl.GuiFramework.Rectangle();
			this.polygon1 = new NxtControl.GuiFramework.Polygon();
			this.polygon2 = new NxtControl.GuiFramework.Polygon();
			this.polygon3 = new NxtControl.GuiFramework.Polygon();
			this.group2 = new NxtControl.GuiFramework.Group();
			// 
			// CV001
			// 
			this.CV001.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.CV001.Font = new NxtControl.Drawing.Font("LabelFont");
			this.CV001.Location = new NxtControl.Drawing.PointF(286D, 84D);
			this.CV001.Name = "CV001";
			this.CV001.Text = "NVPP 001 a-- 038";
			// 
			// CV002
			// 
			this.CV002.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.CV002.Font = new NxtControl.Drawing.Font("LabelFont");
			this.CV002.Location = new NxtControl.Drawing.PointF(464D, 117D);
			this.CV002.Name = "CV002";
			this.CV002.Text = "NVPP 001 a-- 067";
			// 
			// CV003
			// 
			this.CV003.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.CV003.Font = new NxtControl.Drawing.Font("LabelFont");
			this.CV003.Location = new NxtControl.Drawing.PointF(286D, 196D);
			this.CV003.Name = "CV003";
			this.CV003.Text = "NVPP 001 a-- 036";
			// 
			// CV004
			// 
			this.CV004.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.CV004.Font = new NxtControl.Drawing.Font("LabelFont");
			this.CV004.Location = new NxtControl.Drawing.PointF(32D, 412D);
			this.CV004.Name = "CV004";
			this.CV004.Text = "NVPP 001 a-- 023";
			// 
			// CV005
			// 
			this.CV005.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.CV005.Font = new NxtControl.Drawing.Font("LabelFont");
			this.CV005.Location = new NxtControl.Drawing.PointF(432D, 604D);
			this.CV005.Name = "CV005";
			this.CV005.Text = "NVPP 001 a-- 007";
			// 
			// REACTOR
			// 
			this.REACTOR.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.REACTOR.Font = new NxtControl.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
			this.REACTOR.Location = new NxtControl.Drawing.PointF(236D, 332D);
			this.REACTOR.Name = "REACTOR";
			this.REACTOR.Text = "Reactor 1";
			// 
			// pipe17
			// 
			this.pipe17.Bounds = new NxtControl.Drawing.RectF(((float)(208D)), ((float)(168D)), ((float)(8D)), ((float)(24D)));
			this.pipe17.InnerColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.pipe17.Name = "pipe17";
			this.pipe17.OuterColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.pipe17.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(208D, 168D),
			new NxtControl.Drawing.PointF(208D, 172D),
			new NxtControl.Drawing.PointF(216D, 176D),
			new NxtControl.Drawing.PointF(216D, 184D),
			new NxtControl.Drawing.PointF(208D, 188D),
			new NxtControl.Drawing.PointF(208D, 192D)});
			this.pipe17.Width = 10;
			// 
			// AirBubbles1
			// 
			this.AirBubbles1.Bounds = new NxtControl.Drawing.RectF(((float)(176D)), ((float)(512D)), ((float)(200D)), ((float)(96D)));
			this.AirBubbles1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("transparent"));
			this.AirBubbles1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.AirBubbles1.ImageBytes = resources.GetString("AirBubbles1.ImageBytes");
			this.AirBubbles1.Name = "AirBubbles1";
			this.AirBubbles1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// AirBubbles2
			// 
			this.AirBubbles2.Bounds = new NxtControl.Drawing.RectF(((float)(152D)), ((float)(376D)), ((float)(248D)), ((float)(136D)));
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
			this.sPvBarVer1._iUnit = "%";
			this.sPvBarVer1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1.5D, 0D, 0D, 1.5D, 160D, 410D);
			this.sPvBarVer1.Name = "sPvBarVer1";
			this.sPvBarVer1.SecurityToken = ((uint)(4294967295u));
			this.sPvBarVer1.TagName = "Sensors.LevelMeasurementReactor";
			this.sPvBarVer1.EndInit();
			// 
			// FeedRun
			// 
			this.FeedRun.BeginInit();
			this.FeedRun.ColorFrame = new NxtControl.Drawing.Color("LedFrameColor");
			this.FeedRun.DesignMatrix = new NxtControl.Drawing.Matrix2D(1.6666666666666665D, 0D, 0D, 1.6666666666666665D, 444D, 348D);
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
			this.freeText1.Font = new NxtControl.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
			this.freeText1.Location = new NxtControl.Drawing.PointF(470D, 336D);
			this.freeText1.Name = "freeText1";
			this.freeText1.Text = "Phase Feed";
			// 
			// freeText2
			// 
			this.freeText2.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText2.Font = new NxtControl.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
			this.freeText2.Location = new NxtControl.Drawing.PointF(470D, 368D);
			this.freeText2.Name = "freeText2";
			this.freeText2.Text = "Phase Aerate";
			// 
			// AerateRun
			// 
			this.AerateRun.BeginInit();
			this.AerateRun.ColorFrame = new NxtControl.Drawing.Color("LedFrameColor");
			this.AerateRun.DesignMatrix = new NxtControl.Drawing.Matrix2D(1.6666666666666665D, 0D, 0D, 1.6666666666666665D, 444D, 380D);
			this.AerateRun.FrameSize = 33F;
			this.AerateRun.IsOnlyInput = true;
			this.AerateRun.Name = "AerateRun";
			propertyDictionary5.Add("Color", new NxtControl.Drawing.Color("LedFalseColor"));
			propertyDictionary6.Add("Color", new NxtControl.Drawing.Color("DevAnalogOut"));
			this.AerateRun.Ranges.Clear();
			this.AerateRun.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(false, propertyDictionary5));
			this.AerateRun.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(true, propertyDictionary6));
			propertyDictionary4.Add("Color", new NxtControl.Drawing.Color("LedFalseColor"));
			this.AerateRun.Ranges.DefaultPropertyValues = propertyDictionary4;
			this.AerateRun.TagName = "AerateRun";
			this.AerateRun.EndInit();
			// 
			// SDRun
			// 
			this.SDRun.BeginInit();
			this.SDRun.ColorFrame = new NxtControl.Drawing.Color("LedFrameColor");
			this.SDRun.DesignMatrix = new NxtControl.Drawing.Matrix2D(1.6666666666666665D, 0D, 0D, 1.6666666666666665D, 444D, 412D);
			this.SDRun.FrameSize = 33F;
			this.SDRun.IsOnlyInput = true;
			this.SDRun.Name = "SDRun";
			propertyDictionary8.Add("Color", new NxtControl.Drawing.Color("LedFalseColor"));
			propertyDictionary9.Add("Color", new NxtControl.Drawing.Color("DevAnalogOut"));
			this.SDRun.Ranges.Clear();
			this.SDRun.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(false, propertyDictionary8));
			this.SDRun.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(true, propertyDictionary9));
			propertyDictionary7.Add("Color", new NxtControl.Drawing.Color("LedFalseColor"));
			this.SDRun.Ranges.DefaultPropertyValues = propertyDictionary7;
			this.SDRun.TagName = "SludgeDischargeRun";
			this.SDRun.EndInit();
			// 
			// VentRun
			// 
			this.VentRun.BeginInit();
			this.VentRun.ColorFrame = new NxtControl.Drawing.Color("LedFrameColor");
			this.VentRun.DesignMatrix = new NxtControl.Drawing.Matrix2D(1.6666666666666665D, 0D, 0D, 1.6666666666666665D, 444D, 444D);
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
			this.VentRun.TagName = "VentRun";
			this.VentRun.EndInit();
			// 
			// WaitRun
			// 
			this.WaitRun.BeginInit();
			this.WaitRun.ColorFrame = new NxtControl.Drawing.Color("LedFrameColor");
			this.WaitRun.DesignMatrix = new NxtControl.Drawing.Matrix2D(1.6666666666666665D, 0D, 0D, 1.6666666666666665D, 444D, 476D);
			this.WaitRun.FrameSize = 33F;
			this.WaitRun.IsOnlyInput = true;
			this.WaitRun.Name = "WaitRun";
			propertyDictionary14.Add("Color", new NxtControl.Drawing.Color("LedFalseColor"));
			propertyDictionary15.Add("Color", new NxtControl.Drawing.Color("DevAnalogOut"));
			this.WaitRun.Ranges.Clear();
			this.WaitRun.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(false, propertyDictionary14));
			this.WaitRun.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(true, propertyDictionary15));
			propertyDictionary13.Add("Color", new NxtControl.Drawing.Color("LedFalseColor"));
			this.WaitRun.Ranges.DefaultPropertyValues = propertyDictionary13;
			this.WaitRun.TagName = "WaitRun";
			this.WaitRun.EndInit();
			// 
			// freeText3
			// 
			this.freeText3.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText3.Font = new NxtControl.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
			this.freeText3.Location = new NxtControl.Drawing.PointF(470D, 400D);
			this.freeText3.Name = "freeText3";
			this.freeText3.Text = "Phase Discharge";
			// 
			// freeText4
			// 
			this.freeText4.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText4.Font = new NxtControl.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
			this.freeText4.Location = new NxtControl.Drawing.PointF(470D, 432D);
			this.freeText4.Name = "freeText4";
			this.freeText4.Text = "Phase Vent";
			// 
			// freeText5
			// 
			this.freeText5.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText5.Font = new NxtControl.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
			this.freeText5.Location = new NxtControl.Drawing.PointF(470D, 464D);
			this.freeText5.Name = "freeText5";
			this.freeText5.Text = "Phase Wait";
			// 
			// roundedRectangle3
			// 
			this.roundedRectangle3.Bounds = new NxtControl.Drawing.RectF(((float)(424D)), ((float)(324D)), ((float)(40D)), ((float)(176D)));
			this.roundedRectangle3.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255))), new NxtControl.Drawing.GradientFill(NxtControl.Drawing.GradientFillOrientation.DiagonalLeftTop));
			this.roundedRectangle3.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.roundedRectangle3.Name = "roundedRectangle3";
			this.roundedRectangle3.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(114)), ((byte)(114)), ((byte)(114))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// ReactorState
			// 
			this.ReactorState.Bounds = new NxtControl.Drawing.RectF(((float)(424D)), ((float)(276D)), ((float)(200D)), ((float)(40D)));
			this.ReactorState.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(78)), ((byte)(78)), ((byte)(78))));
			this.ReactorState.Font = new NxtControl.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
			this.ReactorState.Name = "ReactorState";
			this.ReactorState.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(78)), ((byte)(78)), ((byte)(78))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.ReactorState.Text = "State";
			this.ReactorState.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			this.ReactorState.TextColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(0)));
			// 
			// pipe22
			// 
			this.pipe22.Bounds = new NxtControl.Drawing.RectF(((float)(416D)), ((float)(588D)), ((float)(140D)), ((float)(0D)));
			this.pipe22.InnerColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.pipe22.Name = "pipe22";
			this.pipe22.OuterColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.pipe22.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(416D, 588D),
			new NxtControl.Drawing.PointF(556D, 588D)});
			this.pipe22.Width = 10;
			// 
			// s3DValve1
			// 
			this.s3DValve1.BeginInit();
			this.s3DValve1._iMotName = "Valve";
			this.s3DValve1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 422D, 538D);
			this.s3DValve1.Name = "s3DValve1";
			this.s3DValve1.SecurityToken = ((uint)(4294967295u));
			this.s3DValve1.StateTextPosition = SE.Nereda.Symbols.ValveS.s3DValve.StateTextPositionOption.Horizontal;
			this.s3DValve1.SymbolNameDisplay = SE.Nereda.Symbols.ValveS.s3DValve.SymbolNameDisplayOption.Hide;
			this.s3DValve1.TagName = "Actuators.FeedingValve";
			this.s3DValve1.EndInit();
			// 
			// s3DValve2
			// 
			this.s3DValve2.BeginInit();
			this.s3DValve2._iMotName = "Valve";
			this.s3DValve2.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 278D, 18D);
			this.s3DValve2.Name = "s3DValve2";
			this.s3DValve2.SecurityToken = ((uint)(4294967295u));
			this.s3DValve2.StateTextPosition = SE.Nereda.Symbols.ValveS.s3DValve.StateTextPositionOption.Horizontal;
			this.s3DValve2.SymbolNameDisplay = SE.Nereda.Symbols.ValveS.s3DValve.SymbolNameDisplayOption.Hide;
			this.s3DValve2.TagName = "Actuators.VentValve";
			this.s3DValve2.EndInit();
			// 
			// s3DValve3
			// 
			this.s3DValve3.BeginInit();
			this.s3DValve3._iMotName = "Valve";
			this.s3DValve3.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 278D, 130D);
			this.s3DValve3.Name = "s3DValve3";
			this.s3DValve3.SecurityToken = ((uint)(4294967295u));
			this.s3DValve3.StateTextPosition = SE.Nereda.Symbols.ValveS.s3DValve.StateTextPositionOption.Horizontal;
			this.s3DValve3.SymbolNameDisplay = SE.Nereda.Symbols.ValveS.s3DValve.SymbolNameDisplayOption.Hide;
			this.s3DValve3.TagName = "Actuators.AirValveAerationGrid";
			this.s3DValve3.EndInit();
			// 
			// s3DValve4
			// 
			this.s3DValve4.BeginInit();
			this.s3DValve4._iMotName = "Valve";
			this.s3DValve4.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 394D, 76D);
			this.s3DValve4.Name = "s3DValve4";
			this.s3DValve4.SecurityToken = ((uint)(4294967295u));
			this.s3DValve4.StateTextPosition = SE.Nereda.Symbols.ValveS.s3DValve.StateTextPositionOption.Vertical;
			this.s3DValve4.SymbolNameDisplay = SE.Nereda.Symbols.ValveS.s3DValve.SymbolNameDisplayOption.Hide;
			this.s3DValve4.TagName = "Actuators.AirValveInfluentGrid";
			this.s3DValve4.EndInit();
			// 
			// pipe18
			// 
			this.pipe18.Bounds = new NxtControl.Drawing.RectF(((float)(208D)), ((float)(68D)), ((float)(432D)), ((float)(176D)));
			this.pipe18.InnerColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.pipe18.Name = "pipe18";
			this.pipe18.OuterColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.pipe18.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(640D, 244D),
			new NxtControl.Drawing.PointF(640D, 68D),
			new NxtControl.Drawing.PointF(208D, 68D),
			new NxtControl.Drawing.PointF(208D, 172D)});
			this.pipe18.Width = 10;
			// 
			// pipe20
			// 
			this.pipe20.Bounds = new NxtControl.Drawing.RectF(((float)(168D)), ((float)(180D)), ((float)(472D)), ((float)(80D)));
			this.pipe20.InnerColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.pipe20.Name = "pipe20";
			this.pipe20.OuterColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.pipe20.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(168D, 260D),
			new NxtControl.Drawing.PointF(168D, 180D),
			new NxtControl.Drawing.PointF(640D, 180D)});
			this.pipe20.Width = 10;
			// 
			// pipe23
			// 
			this.pipe23.Bounds = new NxtControl.Drawing.RectF(((float)(448D)), ((float)(168D)), ((float)(8D)), ((float)(24D)));
			this.pipe23.InnerColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.pipe23.Name = "pipe23";
			this.pipe23.OuterColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.pipe23.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(448D, 168D),
			new NxtControl.Drawing.PointF(448D, 172D),
			new NxtControl.Drawing.PointF(456D, 176D),
			new NxtControl.Drawing.PointF(456D, 184D),
			new NxtControl.Drawing.PointF(448D, 188D),
			new NxtControl.Drawing.PointF(448D, 192D)});
			this.pipe23.Width = 10;
			// 
			// pipe24
			// 
			this.pipe24.Bounds = new NxtControl.Drawing.RectF(((float)(208D)), ((float)(188D)), ((float)(0D)), ((float)(68D)));
			this.pipe24.InnerColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.pipe24.Name = "pipe24";
			this.pipe24.OuterColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.pipe24.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(208D, 188D),
			new NxtControl.Drawing.PointF(208D, 256D)});
			this.pipe24.Width = 10;
			// 
			// pipe26
			// 
			this.pipe26.Bounds = new NxtControl.Drawing.RectF(((float)(448D)), ((float)(76D)), ((float)(0D)), ((float)(96D)));
			this.pipe26.InnerColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.pipe26.Name = "pipe26";
			this.pipe26.OuterColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.pipe26.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(448D, 76D),
			new NxtControl.Drawing.PointF(448D, 172D)});
			this.pipe26.Width = 10;
			// 
			// pipe27
			// 
			this.pipe27.Bounds = new NxtControl.Drawing.RectF(((float)(248D)), ((float)(180D)), ((float)(0D)), ((float)(72D)));
			this.pipe27.InnerColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.pipe27.Name = "pipe27";
			this.pipe27.OuterColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.pipe27.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(248D, 180D),
			new NxtControl.Drawing.PointF(248D, 252D)});
			this.pipe27.Width = 10;
			// 
			// pipe25
			// 
			this.pipe25.Bounds = new NxtControl.Drawing.RectF(((float)(384D)), ((float)(188D)), ((float)(64D)), ((float)(72D)));
			this.pipe25.InnerColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.pipe25.Name = "pipe25";
			this.pipe25.OuterColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.pipe25.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(384D, 260D),
			new NxtControl.Drawing.PointF(384D, 228D),
			new NxtControl.Drawing.PointF(448D, 228D),
			new NxtControl.Drawing.PointF(448D, 188D)});
			this.pipe25.Width = 10;
			// 
			// ellipse2
			// 
			this.ellipse2.Bounds = new NxtControl.Drawing.RectF(((float)(442D)), ((float)(70D)), ((float)(12D)), ((float)(12D)));
			this.ellipse2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(114)), ((byte)(114)), ((byte)(114))), new NxtControl.Drawing.GradientFill(NxtControl.Drawing.GradientFillOrientation.Center, NxtControl.Drawing.GradientFillBrightness.Dark));
			this.ellipse2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.ellipse2.Name = "ellipse2";
			// 
			// ellipse11
			// 
			this.ellipse11.Bounds = new NxtControl.Drawing.RectF(((float)(634D)), ((float)(174D)), ((float)(12D)), ((float)(12D)));
			this.ellipse11.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(114)), ((byte)(114)), ((byte)(114))), new NxtControl.Drawing.GradientFill(NxtControl.Drawing.GradientFillOrientation.Center, NxtControl.Drawing.GradientFillBrightness.Dark));
			this.ellipse11.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.ellipse11.Name = "ellipse11";
			// 
			// ellipse12
			// 
			this.ellipse12.Bounds = new NxtControl.Drawing.RectF(((float)(242D)), ((float)(174D)), ((float)(12D)), ((float)(12D)));
			this.ellipse12.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(114)), ((byte)(114)), ((byte)(114))), new NxtControl.Drawing.GradientFill(NxtControl.Drawing.GradientFillOrientation.Center, NxtControl.Drawing.GradientFillBrightness.Dark));
			this.ellipse12.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.ellipse12.Name = "ellipse12";
			// 
			// s3DValve5
			// 
			this.s3DValve5.BeginInit();
			this.s3DValve5._iMotName = "Valve";
			this.s3DValve5.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 22D, 346D);
			this.s3DValve5.Name = "s3DValve5";
			this.s3DValve5.SecurityToken = ((uint)(4294967295u));
			this.s3DValve5.StateTextPosition = SE.Nereda.Symbols.ValveS.s3DValve.StateTextPositionOption.Horizontal;
			this.s3DValve5.SymbolNameDisplay = SE.Nereda.Symbols.ValveS.s3DValve.SymbolNameDisplayOption.Hide;
			this.s3DValve5.TagName = "Actuators.DischargeValve";
			this.s3DValve5.EndInit();
			// 
			// pipe28
			// 
			this.pipe28.Bounds = new NxtControl.Drawing.RectF(((float)(24D)), ((float)(396D)), ((float)(120D)), ((float)(88D)));
			this.pipe28.InnerColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.pipe28.Name = "pipe28";
			this.pipe28.OuterColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.pipe28.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(144D, 396D),
			new NxtControl.Drawing.PointF(24D, 396D),
			new NxtControl.Drawing.PointF(24D, 484D)});
			this.pipe28.Width = 10;
			// 
			// ellipse1
			// 
			this.ellipse1.Bounds = new NxtControl.Drawing.RectF(((float)(240D)), ((float)(248D)), ((float)(72D)), ((float)(32D)));
			this.ellipse1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255))), new NxtControl.Drawing.GradientFill(NxtControl.Drawing.GradientFillOrientation.HorizontalCenter));
			this.ellipse1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.ellipse1.Name = "ellipse1";
			this.ellipse1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(78)), ((byte)(78)), ((byte)(78))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// WaterLevel
			// 
			this.WaterLevel.Bounds = new NxtControl.Drawing.RectF(((float)(152D)), ((float)(368D)), ((float)(248D)), ((float)(216D)));
			this.WaterLevel.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(165)), ((byte)(213)), ((byte)(226))));
			this.WaterLevel.FillDirection = NxtControl.Drawing.FillDirection.DownToTop;
			this.WaterLevel.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.WaterLevel.Name = "WaterLevel";
			this.WaterLevel.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// ellipse3
			// 
			this.ellipse3.Bounds = new NxtControl.Drawing.RectF(((float)(152D)), ((float)(536D)), ((float)(248D)), ((float)(88D)));
			this.ellipse3.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(154)), ((byte)(154)), ((byte)(154))), new NxtControl.Drawing.GradientFill(NxtControl.Drawing.GradientFillOrientation.HorizontalCenter, NxtControl.Drawing.GradientFillBrightness.Dark));
			this.ellipse3.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.ellipse3.Name = "ellipse3";
			this.ellipse3.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(78)), ((byte)(78)), ((byte)(78))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// line1
			// 
			this.line1.EndPoint = new NxtControl.Drawing.PointF(360D, 248D);
			this.line1.Name = "line1";
			this.line1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line1.StartPoint = new NxtControl.Drawing.PointF(312D, 256D);
			// 
			// line2
			// 
			this.line2.EndPoint = new NxtControl.Drawing.PointF(240D, 256D);
			this.line2.Name = "line2";
			this.line2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line2.StartPoint = new NxtControl.Drawing.PointF(192D, 248D);
			// 
			// line3
			// 
			this.line3.EndPoint = new NxtControl.Drawing.PointF(416D, 280D);
			this.line3.Name = "line3";
			this.line3.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line3.StartPoint = new NxtControl.Drawing.PointF(312D, 264D);
			// 
			// line4
			// 
			this.line4.EndPoint = new NxtControl.Drawing.PointF(304D, 272D);
			this.line4.Name = "line4";
			this.line4.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line4.StartPoint = new NxtControl.Drawing.PointF(384D, 312D);
			// 
			// line5
			// 
			this.line5.EndPoint = new NxtControl.Drawing.PointF(288D, 280D);
			this.line5.Name = "line5";
			this.line5.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line5.StartPoint = new NxtControl.Drawing.PointF(312D, 328D);
			// 
			// ellipse4
			// 
			this.ellipse4.Bounds = new NxtControl.Drawing.RectF(((float)(240D)), ((float)(240D)), ((float)(72D)), ((float)(32D)));
			this.ellipse4.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(114)), ((byte)(114)), ((byte)(114))));
			this.ellipse4.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.ellipse4.Name = "ellipse4";
			this.ellipse4.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(78)), ((byte)(78)), ((byte)(78))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// WaterTop
			// 
			this.WaterTop.Bounds = new NxtControl.Drawing.RectF(((float)(152D)), ((float)(328D)), ((float)(248D)), ((float)(88D)));
			this.WaterTop.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(165)), ((byte)(213)), ((byte)(226))));
			this.WaterTop.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.WaterTop.Name = "WaterTop";
			this.WaterTop.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(120)), ((byte)(192)), ((byte)(212))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// line6
			// 
			this.line6.EndPoint = new NxtControl.Drawing.PointF(264D, 280D);
			this.line6.Name = "line6";
			this.line6.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line6.StartPoint = new NxtControl.Drawing.PointF(240D, 328D);
			// 
			// line7
			// 
			this.line7.EndPoint = new NxtControl.Drawing.PointF(248D, 272D);
			this.line7.Name = "line7";
			this.line7.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line7.StartPoint = new NxtControl.Drawing.PointF(168D, 312D);
			// 
			// line12
			// 
			this.line12.EndPoint = new NxtControl.Drawing.PointF(240D, 264D);
			this.line12.Name = "line12";
			this.line12.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line12.StartPoint = new NxtControl.Drawing.PointF(136D, 280D);
			// 
			// ellipse14
			// 
			this.ellipse14.Bounds = new NxtControl.Drawing.RectF(((float)(136D)), ((float)(240D)), ((float)(280D)), ((float)(88D)));
			this.ellipse14.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255))), new NxtControl.Drawing.GradientFill(NxtControl.Drawing.GradientFillOrientation.DiagonalRightTop));
			this.ellipse14.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.ellipse14.Name = "ellipse14";
			this.ellipse14.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(78)), ((byte)(78)), ((byte)(78))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// ellipse15
			// 
			this.ellipse15.Bounds = new NxtControl.Drawing.RectF(((float)(136D)), ((float)(272D)), ((float)(280D)), ((float)(88D)));
			this.ellipse15.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255))), new NxtControl.Drawing.GradientFill(NxtControl.Drawing.GradientFillOrientation.HorizontalCenter, NxtControl.Drawing.GradientFillBrightness.Dark));
			this.ellipse15.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.ellipse15.Name = "ellipse15";
			this.ellipse15.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(135)), ((byte)(135)), ((byte)(135))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// rectangle2
			// 
			this.rectangle2.Bounds = new NxtControl.Drawing.RectF(((float)(152D)), ((float)(328D)), ((float)(248D)), ((float)(256D)));
			this.rectangle2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(154)), ((byte)(154)), ((byte)(154))), new NxtControl.Drawing.GradientFill(NxtControl.Drawing.GradientFillOrientation.HorizontalCenter, NxtControl.Drawing.GradientFillBrightness.Dark));
			this.rectangle2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle2.Name = "rectangle2";
			this.rectangle2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// rectangle3
			// 
			this.rectangle3.Bounds = new NxtControl.Drawing.RectF(((float)(136D)), ((float)(280D)), ((float)(280D)), ((float)(328D)));
			this.rectangle3.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255))), new NxtControl.Drawing.GradientFill(NxtControl.Drawing.GradientFillOrientation.HorizontalCenter, NxtControl.Drawing.GradientFillBrightness.Dark));
			this.rectangle3.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle3.Name = "rectangle3";
			this.rectangle3.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// ellipse16
			// 
			this.ellipse16.Bounds = new NxtControl.Drawing.RectF(((float)(136D)), ((float)(560D)), ((float)(280D)), ((float)(88D)));
			this.ellipse16.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255))), new NxtControl.Drawing.GradientFill(NxtControl.Drawing.GradientFillOrientation.HorizontalCenter, NxtControl.Drawing.GradientFillBrightness.Dark));
			this.ellipse16.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.ellipse16.Name = "ellipse16";
			this.ellipse16.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(78)), ((byte)(78)), ((byte)(78))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// WaterBase
			// 
			this.WaterBase.Bounds = new NxtControl.Drawing.RectF(((float)(152D)), ((float)(536D)), ((float)(248D)), ((float)(88D)));
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
			// rectangle1
			// 
			this.rectangle1.Bounds = new NxtControl.Drawing.RectF(((float)(560D)), ((float)(216D)), ((float)(136D)), ((float)(40D)));
			this.rectangle1.Font = new NxtControl.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
			this.rectangle1.Name = "rectangle1";
			this.rectangle1.Text = "Aeration";
			this.rectangle1.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			// 
			// rectangle4
			// 
			this.rectangle4.Bounds = new NxtControl.Drawing.RectF(((float)(8D)), ((float)(480D)), ((float)(112D)), ((float)(64D)));
			this.rectangle4.Font = new NxtControl.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
			this.rectangle4.Name = "rectangle4";
			this.rectangle4.Text = "Sludge Buffer";
			this.rectangle4.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			// 
			// rectangle5
			// 
			this.rectangle5.Bounds = new NxtControl.Drawing.RectF(((float)(544D)), ((float)(556D)), ((float)(152D)), ((float)(64D)));
			this.rectangle5.Font = new NxtControl.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
			this.rectangle5.Name = "rectangle5";
			this.rectangle5.Text = "Influent Feed";
			this.rectangle5.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			// 
			// polygon1
			// 
			this.polygon1.Bounds = new NxtControl.Drawing.RectF(((float)(520D)), ((float)(580D)), ((float)(16D)), ((float)(16D)));
			this.polygon1.Closed = true;
			this.polygon1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.polygon1.Name = "polygon1";
			this.polygon1.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(520D, 588D),
			new NxtControl.Drawing.PointF(536D, 580D),
			new NxtControl.Drawing.PointF(536D, 596D)});
			// 
			// polygon2
			// 
			this.polygon2.Bounds = new NxtControl.Drawing.RectF(((float)(16D)), ((float)(456D)), ((float)(16D)), ((float)(16D)));
			this.polygon2.Closed = true;
			this.polygon2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.polygon2.Name = "polygon2";
			this.polygon2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(24D, 472D),
			new NxtControl.Drawing.PointF(32D, 456D),
			new NxtControl.Drawing.PointF(16D, 456D)});
			// 
			// polygon3
			// 
			this.polygon3.Bounds = new NxtControl.Drawing.RectF(((float)(632D)), ((float)(192D)), ((float)(16D)), ((float)(16D)));
			this.polygon3.Closed = true;
			this.polygon3.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.polygon3.Name = "polygon3";
			this.polygon3.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(640D, 192D),
			new NxtControl.Drawing.PointF(648D, 208D),
			new NxtControl.Drawing.PointF(632D, 208D)});
			// 
			// group2
			// 
			this.group2.BeginInit();
			this.group2.Name = "group2";
			this.group2.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.ReactorState,
			this.roundedRectangle3,
			this.freeText1,
			this.freeText2,
			this.freeText3,
			this.freeText4,
			this.freeText5,
			this.FeedRun,
			this.AerateRun,
			this.SDRun,
			this.VentRun,
			this.WaitRun});
			this.group2.EndInit();
			// 
			// sReactor2
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.pipe28,
			this.pipe25,
			this.pipe27,
			this.pipe24,
			this.pipe20,
			this.pipe18,
			this.CV001,
			this.CV002,
			this.CV003,
			this.CV004,
			this.pipe17,
			this.CV005,
			this.pipe22,
			this.s3DValve1,
			this.pipe26,
			this.s3DValve2,
			this.s3DValve3,
			this.s3DValve4,
			this.pipe23,
			this.ellipse2,
			this.ellipse11,
			this.ellipse12,
			this.s3DValve5,
			this.group1,
			this.AirBubbles2,
			this.AirBubbles1,
			this.REACTOR,
			this.sPvBarVer1,
			this.rectangle1,
			this.rectangle4,
			this.rectangle5,
			this.polygon1,
			this.polygon2,
			this.polygon3,
			this.group2});
			this.SymbolSize = new System.Drawing.Size(840, 696);

		}
		private NxtControl.GuiFramework.FreeText CV001;
		private NxtControl.GuiFramework.FreeText CV002;
		private NxtControl.GuiFramework.FreeText CV003;
		private NxtControl.GuiFramework.FreeText CV004;
		private NxtControl.GuiFramework.FreeText CV005;
		private NxtControl.GuiFramework.FreeText REACTOR;
		private NxtControl.GuiFramework.Pipe pipe17;
		private NxtControl.GuiFramework.Rectangle AirBubbles1;
		private NxtControl.GuiFramework.Rectangle AirBubbles2;
		private SE.Nereda.Symbols.AnalogInput.sPvBarVer sPvBarVer1;
		private System.HMI.Symbols.Base.Led<bool> FeedRun;
		private NxtControl.GuiFramework.FreeText freeText1;
		private NxtControl.GuiFramework.FreeText freeText2;
		private System.HMI.Symbols.Base.Led<bool> AerateRun;
		private System.HMI.Symbols.Base.Led<bool> SDRun;
		private System.HMI.Symbols.Base.Led<bool> VentRun;
		private System.HMI.Symbols.Base.Led<bool> WaitRun;
		private NxtControl.GuiFramework.FreeText freeText3;
		private NxtControl.GuiFramework.FreeText freeText4;
		private NxtControl.GuiFramework.FreeText freeText5;
		private NxtControl.GuiFramework.RoundedRectangle roundedRectangle3;
		private NxtControl.GuiFramework.RoundedRectangle ReactorState;
		private NxtControl.GuiFramework.Pipe pipe22;
		private SE.Nereda.Symbols.ValveS.s3DValve s3DValve1;
		private SE.Nereda.Symbols.ValveS.s3DValve s3DValve2;
		private SE.Nereda.Symbols.ValveS.s3DValve s3DValve3;
		private SE.Nereda.Symbols.ValveS.s3DValve s3DValve4;
		private NxtControl.GuiFramework.Pipe pipe18;
		private NxtControl.GuiFramework.Pipe pipe20;
		private NxtControl.GuiFramework.Pipe pipe23;
		private NxtControl.GuiFramework.Pipe pipe24;
		private NxtControl.GuiFramework.Pipe pipe26;
		private NxtControl.GuiFramework.Pipe pipe27;
		private NxtControl.GuiFramework.Pipe pipe25;
		private NxtControl.GuiFramework.Ellipse ellipse2;
		private NxtControl.GuiFramework.Ellipse ellipse11;
		private NxtControl.GuiFramework.Ellipse ellipse12;
		private SE.Nereda.Symbols.ValveS.s3DValve s3DValve5;
		private NxtControl.GuiFramework.Pipe pipe28;
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
		private NxtControl.GuiFramework.Group group2;
		private NxtControl.GuiFramework.Rectangle rectangle1;
		private NxtControl.GuiFramework.Rectangle rectangle4;
		private NxtControl.GuiFramework.Rectangle rectangle5;
		private NxtControl.GuiFramework.Polygon polygon1;
		private NxtControl.GuiFramework.Polygon polygon2;
		private NxtControl.GuiFramework.Polygon polygon3;
		#endregion
	}
}
