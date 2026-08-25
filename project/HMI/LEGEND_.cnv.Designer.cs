/*
 * Created by EcoStruxure Automation Expert.
 * User: SESA713705
 * Date: 8/8/2024
 * Time: 4:43 PM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;

using NxtControl.GuiFramework;

namespace HMI.Main.Canvases
{
	/// <summary>
	/// Summary description for LEGEND_.
	/// </summary>
	partial class LEGEND_
	{
		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LEGEND_));
			this.rectangle3 = new NxtControl.GuiFramework.Rectangle();
			this.line1 = new NxtControl.GuiFramework.Line();
			this.rectangle2 = new NxtControl.GuiFramework.Rectangle();
			this.rectangle1 = new NxtControl.GuiFramework.Rectangle();
			this.polygon3 = new NxtControl.GuiFramework.Polygon();
			this.line2 = new NxtControl.GuiFramework.Line();
			this.rectangle4 = new NxtControl.GuiFramework.Rectangle();
			this.polygon5 = new NxtControl.GuiFramework.Polygon();
			this.rectangle5 = new NxtControl.GuiFramework.Rectangle();
			this.rectangle6 = new NxtControl.GuiFramework.Rectangle();
			this.line3 = new NxtControl.GuiFramework.Line();
			this.polygon4 = new NxtControl.GuiFramework.Polygon();
			this.Base = new NxtControl.GuiFramework.Polygon();
			this.MotBase = new NxtControl.GuiFramework.Ellipse();
			this.polygon1 = new NxtControl.GuiFramework.Polygon();
			this.ellipse1 = new NxtControl.GuiFramework.Ellipse();
			this.polygon2 = new NxtControl.GuiFramework.Polygon();
			this.ellipse2 = new NxtControl.GuiFramework.Ellipse();
			this.freeText1 = new NxtControl.GuiFramework.FreeText();
			this.freeText2 = new NxtControl.GuiFramework.FreeText();
			this.freeText3 = new NxtControl.GuiFramework.FreeText();
			this.freeText4 = new NxtControl.GuiFramework.FreeText();
			this.freeText5 = new NxtControl.GuiFramework.FreeText();
			this.freeText6 = new NxtControl.GuiFramework.FreeText();
			this.polygon6 = new NxtControl.GuiFramework.Polygon();
			this.ellipse3 = new NxtControl.GuiFramework.Ellipse();
			this.freeText7 = new NxtControl.GuiFramework.FreeText();
			this.rectangle7 = new NxtControl.GuiFramework.Rectangle();
			this.freeText8 = new NxtControl.GuiFramework.FreeText();
			this.Mode = new SE.Nereda.Symbols.Mode.ReactorMode();
			this.sHiHiLevelCalamity1 = new SE.Nereda.Symbols.Calamity.sHiHiLevelCalamity();
			this.HeartBeat = new SE.Nereda.Symbols.HeartBeat.sDefault();
			this.MCCPower = new SE.Nereda.Symbols.MCCPower.sDefault();
			this.changeCanvasButton2 = new NxtControl.GuiFramework.ChangeCanvasButton();
			this.changeCanvasButton4 = new NxtControl.GuiFramework.ChangeCanvasButton();
			this.changeCanvasButton1 = new NxtControl.GuiFramework.ChangeCanvasButton();
			this.changeCanvasButton3 = new NxtControl.GuiFramework.ChangeCanvasButton();
			this.changeCanvasButton5 = new NxtControl.GuiFramework.ChangeCanvasButton();
			this.changeCanvasButton6 = new NxtControl.GuiFramework.ChangeCanvasButton();
			this.changeCanvasButton7 = new NxtControl.GuiFramework.ChangeCanvasButton();
			this.group8 = new NxtControl.GuiFramework.Group();
			this.group5 = new NxtControl.GuiFramework.Group();
			this.group4 = new NxtControl.GuiFramework.Group();
			this.group6 = new NxtControl.GuiFramework.Group();
			this.group7 = new NxtControl.GuiFramework.Group();
			this.group2 = new NxtControl.GuiFramework.Group();
			this.group3 = new NxtControl.GuiFramework.Group();
			this.group1 = new NxtControl.GuiFramework.Group();
			this.freeText9 = new NxtControl.GuiFramework.FreeText();
			this.rectangle8 = new NxtControl.GuiFramework.Rectangle();
			this.rectangle9 = new NxtControl.GuiFramework.Rectangle();
			this.freeText10 = new NxtControl.GuiFramework.FreeText();
			this.freeText11 = new NxtControl.GuiFramework.FreeText();
			this.freeText12 = new NxtControl.GuiFramework.FreeText();
			this.freeText13 = new NxtControl.GuiFramework.FreeText();
			this.freeText14 = new NxtControl.GuiFramework.FreeText();
			this.freeText15 = new NxtControl.GuiFramework.FreeText();
			this.line4 = new NxtControl.GuiFramework.Line();
			this.freeText16 = new NxtControl.GuiFramework.FreeText();
			this.freeText17 = new NxtControl.GuiFramework.FreeText();
			this.freeText18 = new NxtControl.GuiFramework.FreeText();
			this.freeText19 = new NxtControl.GuiFramework.FreeText();
			this.freeText20 = new NxtControl.GuiFramework.FreeText();
			this.freeText21 = new NxtControl.GuiFramework.FreeText();
			this.freeText22 = new NxtControl.GuiFramework.FreeText();
			this.freeText23 = new NxtControl.GuiFramework.FreeText();
			this.freeText24 = new NxtControl.GuiFramework.FreeText();
			this.rectangle10 = new NxtControl.GuiFramework.Rectangle();
			this.freeText25 = new NxtControl.GuiFramework.FreeText();
			// 
			// rectangle3
			// 
			this.rectangle3.Bounds = new NxtControl.Drawing.RectF(((float)(21D)), ((float)(436D)), ((float)(30D)), ((float)(15D)));
			this.rectangle3.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("SE.Nereda.ActiveStatus"));
			this.rectangle3.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle3.Name = "rectangle3";
			// 
			// line1
			// 
			this.line1.EndPoint = new NxtControl.Drawing.PointF(36D, 391D);
			this.line1.Name = "line1";
			this.line1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.line1.StartPoint = new NxtControl.Drawing.PointF(36D, 371D);
			// 
			// rectangle2
			// 
			this.rectangle2.Bounds = new NxtControl.Drawing.RectF(((float)(28.5D)), ((float)(336D)), ((float)(15D)), ((float)(15D)));
			this.rectangle2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("SE.Nereda.PassiveStatus"));
			this.rectangle2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle2.Name = "rectangle2";
			// 
			// rectangle1
			// 
			this.rectangle1.Bounds = new NxtControl.Drawing.RectF(((float)(21D)), ((float)(356D)), ((float)(30D)), ((float)(15D)));
			this.rectangle1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("SE.Nereda.PassiveStatus"));
			this.rectangle1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle1.Name = "rectangle1";
			// 
			// polygon3
			// 
			this.polygon3.Bounds = new NxtControl.Drawing.RectF(((float)(16D)), ((float)(381D)), ((float)(40D)), ((float)(20D)));
			this.polygon3.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("SE.Nereda.PassiveStatus"));
			this.polygon3.Closed = true;
			this.polygon3.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.polygon3.Name = "polygon3";
			this.polygon3.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(56D, 401D),
			new NxtControl.Drawing.PointF(56D, 381D),
			new NxtControl.Drawing.PointF(36D, 391D),
			new NxtControl.Drawing.PointF(16D, 381D),
			new NxtControl.Drawing.PointF(16D, 401D),
			new NxtControl.Drawing.PointF(36D, 391D)});
			// 
			// line2
			// 
			this.line2.EndPoint = new NxtControl.Drawing.PointF(36D, 471D);
			this.line2.Name = "line2";
			this.line2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.line2.StartPoint = new NxtControl.Drawing.PointF(36D, 451D);
			// 
			// rectangle4
			// 
			this.rectangle4.Bounds = new NxtControl.Drawing.RectF(((float)(28.5D)), ((float)(416D)), ((float)(15D)), ((float)(15D)));
			this.rectangle4.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("SE.Nereda.ActiveStatus"));
			this.rectangle4.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle4.Name = "rectangle4";
			// 
			// polygon5
			// 
			this.polygon5.Bounds = new NxtControl.Drawing.RectF(((float)(16D)), ((float)(541D)), ((float)(40D)), ((float)(20D)));
			this.polygon5.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.BlinkColor("SE.Nereda.Orangwhite"));
			this.polygon5.Closed = true;
			this.polygon5.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.polygon5.Name = "polygon5";
			this.polygon5.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(56D, 561D),
			new NxtControl.Drawing.PointF(56D, 541D),
			new NxtControl.Drawing.PointF(36D, 551D),
			new NxtControl.Drawing.PointF(16D, 541D),
			new NxtControl.Drawing.PointF(16D, 561D),
			new NxtControl.Drawing.PointF(36D, 551D)});
			// 
			// rectangle5
			// 
			this.rectangle5.Bounds = new NxtControl.Drawing.RectF(((float)(21D)), ((float)(516D)), ((float)(30D)), ((float)(15D)));
			this.rectangle5.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.BlinkColor("SE.Nereda.Orangwhite"));
			this.rectangle5.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle5.Name = "rectangle5";
			// 
			// rectangle6
			// 
			this.rectangle6.Bounds = new NxtControl.Drawing.RectF(((float)(28.5D)), ((float)(496D)), ((float)(15D)), ((float)(15D)));
			this.rectangle6.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.BlinkColor("SE.Nereda.Orangwhite"));
			this.rectangle6.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle6.Name = "rectangle6";
			// 
			// line3
			// 
			this.line3.EndPoint = new NxtControl.Drawing.PointF(36D, 551D);
			this.line3.Name = "line3";
			this.line3.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.line3.StartPoint = new NxtControl.Drawing.PointF(36D, 531D);
			// 
			// polygon4
			// 
			this.polygon4.Bounds = new NxtControl.Drawing.RectF(((float)(16D)), ((float)(461D)), ((float)(40D)), ((float)(20D)));
			this.polygon4.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("SE.Nereda.ActiveStatus"));
			this.polygon4.Closed = true;
			this.polygon4.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.polygon4.Name = "polygon4";
			this.polygon4.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(56D, 481D),
			new NxtControl.Drawing.PointF(56D, 461D),
			new NxtControl.Drawing.PointF(36D, 471D),
			new NxtControl.Drawing.PointF(16D, 461D),
			new NxtControl.Drawing.PointF(16D, 481D),
			new NxtControl.Drawing.PointF(36D, 471D)});
			// 
			// Base
			// 
			this.Base.Bounds = new NxtControl.Drawing.RectF(((float)(16D)), ((float)(98.666666666666657D)), ((float)(40D)), ((float)(13.333333333333343D)));
			this.Base.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("SE.Nereda.PassiveStatus"));
			this.Base.Closed = true;
			this.Base.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.Base.Name = "Base";
			this.Base.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(16D, 112D),
			new NxtControl.Drawing.PointF(56D, 112D),
			new NxtControl.Drawing.PointF(42.666666666666572D, 98.666666666666657D),
			new NxtControl.Drawing.PointF(29.333333333333286D, 98.666666666666657D)});
			// 
			// MotBase
			// 
			this.MotBase.Bounds = new NxtControl.Drawing.RectF(((float)(17.875D)), ((float)(72D)), ((float)(36.666667938232422D)), ((float)(36.666667938232422D)));
			this.MotBase.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("SE.Nereda.PassiveStatus"));
			this.MotBase.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.MotBase.Name = "MotBase";
			// 
			// polygon1
			// 
			this.polygon1.Bounds = new NxtControl.Drawing.RectF(((float)(16D)), ((float)(162.66666454739004D)), ((float)(40D)), ((float)(13.333335452609958D)));
			this.polygon1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("SE.Nereda.ActiveStatus"));
			this.polygon1.Closed = true;
			this.polygon1.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.polygon1.Name = "polygon1";
			this.polygon1.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(16D, 176D),
			new NxtControl.Drawing.PointF(56D, 176D),
			new NxtControl.Drawing.PointF(42.666666666666572D, 162.66666454739004D),
			new NxtControl.Drawing.PointF(29.333333333333286D, 162.66666454739004D)});
			// 
			// ellipse1
			// 
			this.ellipse1.Bounds = new NxtControl.Drawing.RectF(((float)(17.875D)), ((float)(136D)), ((float)(36.666667938232422D)), ((float)(36.666671752929688D)));
			this.ellipse1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("SE.Nereda.ActiveStatus"));
			this.ellipse1.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.ellipse1.Name = "ellipse1";
			// 
			// polygon2
			// 
			this.polygon2.Bounds = new NxtControl.Drawing.RectF(((float)(16D)), ((float)(226.66667090521781D)), ((float)(40D)), ((float)(13.333329094782187D)));
			this.polygon2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.BlinkColor("SE.Nereda.Orangwhite"));
			this.polygon2.Closed = true;
			this.polygon2.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.polygon2.Name = "polygon2";
			this.polygon2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(16D, 240D),
			new NxtControl.Drawing.PointF(56D, 240D),
			new NxtControl.Drawing.PointF(42.666666666666572D, 226.66667090521781D),
			new NxtControl.Drawing.PointF(29.333333333333286D, 226.66667090521781D)});
			// 
			// ellipse2
			// 
			this.ellipse2.Bounds = new NxtControl.Drawing.RectF(((float)(17.875D)), ((float)(200D)), ((float)(36.666667938232422D)), ((float)(36.666656494140625D)));
			this.ellipse2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.BlinkColor("SE.Nereda.Orangwhite"));
			this.ellipse2.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.ellipse2.Name = "ellipse2";
			// 
			// freeText1
			// 
			this.freeText1.Color = new NxtControl.Drawing.Color("LabelTextColor");
			this.freeText1.Font = new NxtControl.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
			this.freeText1.Location = new NxtControl.Drawing.PointF(72D, 80D);
			this.freeText1.Name = "freeText1";
			this.freeText1.Text = "Motor Or Pump = Stopped";
			// 
			// freeText2
			// 
			this.freeText2.Color = new NxtControl.Drawing.Color("LabelTextColor");
			this.freeText2.Font = new NxtControl.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
			this.freeText2.Location = new NxtControl.Drawing.PointF(72D, 144D);
			this.freeText2.Name = "freeText2";
			this.freeText2.Text = "Motor Or Pump = Running";
			// 
			// freeText3
			// 
			this.freeText3.Color = new NxtControl.Drawing.Color("LabelTextColor");
			this.freeText3.Font = new NxtControl.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
			this.freeText3.Location = new NxtControl.Drawing.PointF(72D, 208D);
			this.freeText3.Name = "freeText3";
			this.freeText3.Text = "Motor Or Pump = Fault";
			// 
			// freeText4
			// 
			this.freeText4.Color = new NxtControl.Drawing.Color("LabelTextColor");
			this.freeText4.Font = new NxtControl.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
			this.freeText4.Location = new NxtControl.Drawing.PointF(72D, 360D);
			this.freeText4.Name = "freeText4";
			this.freeText4.Text = "Valve = Closed";
			// 
			// freeText5
			// 
			this.freeText5.Color = new NxtControl.Drawing.Color("LabelTextColor");
			this.freeText5.Font = new NxtControl.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
			this.freeText5.Location = new NxtControl.Drawing.PointF(72D, 440D);
			this.freeText5.Name = "freeText5";
			this.freeText5.Text = "Valve = Opened";
			// 
			// freeText6
			// 
			this.freeText6.Color = new NxtControl.Drawing.Color("LabelTextColor");
			this.freeText6.Font = new NxtControl.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
			this.freeText6.Location = new NxtControl.Drawing.PointF(72D, 520D);
			this.freeText6.Name = "freeText6";
			this.freeText6.Text = "Valve = Fault";
			// 
			// polygon6
			// 
			this.polygon6.Bounds = new NxtControl.Drawing.RectF(((float)(16D)), ((float)(298.66667090521787D)), ((float)(40D)), ((float)(13.33332909478213D)));
			this.polygon6.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("SE.Nereda.PowerOFF"));
			this.polygon6.Closed = true;
			this.polygon6.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.polygon6.Name = "polygon6";
			this.polygon6.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(16D, 312D),
			new NxtControl.Drawing.PointF(56D, 312D),
			new NxtControl.Drawing.PointF(42.666666666666572D, 298.66667090521787D),
			new NxtControl.Drawing.PointF(29.333333333333286D, 298.66667090521787D)});
			// 
			// ellipse3
			// 
			this.ellipse3.Bounds = new NxtControl.Drawing.RectF(((float)(17.875D)), ((float)(272D)), ((float)(36.666667938232422D)), ((float)(36.666656494140625D)));
			this.ellipse3.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("SE.Nereda.PowerOFF"));
			this.ellipse3.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.ellipse3.Name = "ellipse3";
			// 
			// freeText7
			// 
			this.freeText7.Color = new NxtControl.Drawing.Color("LabelTextColor");
			this.freeText7.Font = new NxtControl.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
			this.freeText7.Location = new NxtControl.Drawing.PointF(72D, 280D);
			this.freeText7.Name = "freeText7";
			this.freeText7.Text = "Motor Or Pump = No power";
			// 
			// rectangle7
			// 
			this.rectangle7.Bounds = new NxtControl.Drawing.RectF(((float)(16D)), ((float)(576D)), ((float)(52D)), ((float)(44.571430206298828D)));
			this.rectangle7.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle7.ImageBytes = resources.GetString("rectangle7.ImageBytes");
			this.rectangle7.Name = "rectangle7";
			// 
			// freeText8
			// 
			this.freeText8.Color = new NxtControl.Drawing.Color("LabelTextColor");
			this.freeText8.Font = new NxtControl.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
			this.freeText8.Location = new NxtControl.Drawing.PointF(72D, 584D);
			this.freeText8.Name = "freeText8";
			this.freeText8.Text = "Interlock symbol";
			// 
			// Mode
			// 
			this.Mode.BeginInit();
			this.Mode.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 424D, 8D);
			this.Mode.Name = "Mode";
			this.Mode.SecurityToken = ((uint)(4294967295u));
			this.Mode.TagName = "7A79C015B9ADE3EB";
			this.Mode.EndInit();
			// 
			// sHiHiLevelCalamity1
			// 
			this.sHiHiLevelCalamity1.BeginInit();
			this.sHiHiLevelCalamity1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 632D, 8D);
			this.sHiHiLevelCalamity1.Name = "sHiHiLevelCalamity1";
			this.sHiHiLevelCalamity1.SecurityToken = ((uint)(4294967295u));
			this.sHiHiLevelCalamity1.TagName = "F2F66466CB372A96.EffluentLogic.Calamity";
			this.sHiHiLevelCalamity1.EndInit();
			// 
			// HeartBeat
			// 
			this.HeartBeat.BeginInit();
			this.HeartBeat.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 8D, 8D);
			this.HeartBeat.Name = "HeartBeat";
			this.HeartBeat.SecurityToken = ((uint)(4294967295u));
			this.HeartBeat.TagName = "32B44D45F962192F";
			this.HeartBeat.EndInit();
			// 
			// MCCPower
			// 
			this.MCCPower.BeginInit();
			this.MCCPower.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 216D, 8D);
			this.MCCPower.Name = "MCCPower";
			this.MCCPower.SecurityToken = ((uint)(4294967295u));
			this.MCCPower.TagName = "E1E3B3442DD19945";
			this.MCCPower.EndInit();
			// 
			// changeCanvasButton2
			// 
			this.changeCanvasButton2.Bounds = new NxtControl.Drawing.RectF(((float)(1152D)), ((float)(648D)), ((float)(168D)), ((float)(32D)));
			this.changeCanvasButton2.CanvasName = "SLUDGE_BUFFER";
			this.changeCanvasButton2.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.changeCanvasButton2.Name = "changeCanvasButton2";
			this.changeCanvasButton2.Text = "SLUDGE BUFFER";
			// 
			// changeCanvasButton4
			// 
			this.changeCanvasButton4.Bounds = new NxtControl.Drawing.RectF(((float)(600D)), ((float)(648D)), ((float)(168D)), ((float)(32D)));
			this.changeCanvasButton4.CanvasName = "INFLUENT_FEED";
			this.changeCanvasButton4.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.changeCanvasButton4.Name = "changeCanvasButton4";
			this.changeCanvasButton4.Text = "INFLUENT FEED";
			// 
			// changeCanvasButton1
			// 
			this.changeCanvasButton1.Bounds = new NxtControl.Drawing.RectF(((float)(416D)), ((float)(648D)), ((float)(168D)), ((float)(32D)));
			this.changeCanvasButton1.CanvasName = "REACTOR3";
			this.changeCanvasButton1.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.changeCanvasButton1.Name = "changeCanvasButton1";
			this.changeCanvasButton1.Text = "REACTOR 3";
			// 
			// changeCanvasButton3
			// 
			this.changeCanvasButton3.Bounds = new NxtControl.Drawing.RectF(((float)(232D)), ((float)(648D)), ((float)(168D)), ((float)(32D)));
			this.changeCanvasButton3.CanvasName = "REACTOR2";
			this.changeCanvasButton3.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.changeCanvasButton3.Name = "changeCanvasButton3";
			this.changeCanvasButton3.Text = "REACTOR 2";
			// 
			// changeCanvasButton5
			// 
			this.changeCanvasButton5.Bounds = new NxtControl.Drawing.RectF(((float)(48D)), ((float)(648D)), ((float)(168D)), ((float)(32D)));
			this.changeCanvasButton5.CanvasName = "REACTOR1";
			this.changeCanvasButton5.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.changeCanvasButton5.Name = "changeCanvasButton5";
			this.changeCanvasButton5.Text = "REACTOR 1";
			// 
			// changeCanvasButton6
			// 
			this.changeCanvasButton6.Bounds = new NxtControl.Drawing.RectF(((float)(784D)), ((float)(648D)), ((float)(168D)), ((float)(32D)));
			this.changeCanvasButton6.CanvasName = "EFFLUENT";
			this.changeCanvasButton6.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.changeCanvasButton6.Name = "changeCanvasButton6";
			this.changeCanvasButton6.Text = "EFFLUENT";
			// 
			// changeCanvasButton7
			// 
			this.changeCanvasButton7.Bounds = new NxtControl.Drawing.RectF(((float)(968D)), ((float)(648D)), ((float)(168D)), ((float)(32D)));
			this.changeCanvasButton7.CanvasName = "CALAMITY";
			this.changeCanvasButton7.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.changeCanvasButton7.Name = "changeCanvasButton7";
			this.changeCanvasButton7.Text = "CALAMITY";
			// 
			// group8
			// 
			this.group8.BeginInit();
			this.group8.Name = "group8";
			this.group8.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.changeCanvasButton2,
			this.changeCanvasButton4,
			this.changeCanvasButton1,
			this.changeCanvasButton3,
			this.changeCanvasButton5,
			this.changeCanvasButton6,
			this.changeCanvasButton7});
			this.group8.EndInit();
			// 
			// group5
			// 
			this.group5.BeginInit();
			this.group5.Name = "group5";
			this.group5.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.polygon1,
			this.ellipse1});
			this.group5.EndInit();
			// 
			// group4
			// 
			this.group4.BeginInit();
			this.group4.Name = "group4";
			this.group4.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.Base,
			this.MotBase});
			this.group4.EndInit();
			// 
			// group6
			// 
			this.group6.BeginInit();
			this.group6.Name = "group6";
			this.group6.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.polygon2,
			this.ellipse2});
			this.group6.EndInit();
			// 
			// group7
			// 
			this.group7.BeginInit();
			this.group7.Name = "group7";
			this.group7.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.polygon6,
			this.ellipse3});
			this.group7.EndInit();
			// 
			// group2
			// 
			this.group2.BeginInit();
			this.group2.Name = "group2";
			this.group2.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.polygon3,
			this.rectangle1,
			this.rectangle2,
			this.line1});
			this.group2.EndInit();
			// 
			// group3
			// 
			this.group3.BeginInit();
			this.group3.Name = "group3";
			this.group3.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.polygon4,
			this.rectangle3,
			this.rectangle4,
			this.line2});
			this.group3.EndInit();
			// 
			// group1
			// 
			this.group1.BeginInit();
			this.group1.Name = "group1";
			this.group1.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.polygon5,
			this.rectangle5,
			this.rectangle6,
			this.line3});
			this.group1.EndInit();
			// 
			// freeText9
			// 
			this.freeText9.Color = new NxtControl.Drawing.Color("LabelTextColor");
			this.freeText9.Font = new NxtControl.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
			this.freeText9.Location = new NxtControl.Drawing.PointF(520D, 128D);
			this.freeText9.Name = "freeText9";
			this.freeText9.Text = "O";
			// 
			// rectangle8
			// 
			this.rectangle8.Bounds = new NxtControl.Drawing.RectF(((float)(504D)), ((float)(72D)), ((float)(504D)), ((float)(40D)));
			this.rectangle8.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("transparent"));
			this.rectangle8.Font = new NxtControl.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
			this.rectangle8.Name = "rectangle8";
			this.rectangle8.Text = "Actuator State Legend";
			this.rectangle8.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			// 
			// rectangle9
			// 
			this.rectangle9.Bounds = new NxtControl.Drawing.RectF(((float)(504D)), ((float)(112D)), ((float)(504D)), ((float)(280D)));
			this.rectangle9.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("transparent"));
			this.rectangle9.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle9.Name = "rectangle9";
			// 
			// freeText10
			// 
			this.freeText10.Color = new NxtControl.Drawing.Color("LabelTextColor");
			this.freeText10.Font = new NxtControl.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
			this.freeText10.Location = new NxtControl.Drawing.PointF(520D, 160D);
			this.freeText10.Name = "freeText10";
			this.freeText10.Text = "P";
			// 
			// freeText11
			// 
			this.freeText11.Color = new NxtControl.Drawing.Color("LabelTextColor");
			this.freeText11.Font = new NxtControl.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
			this.freeText11.Location = new NxtControl.Drawing.PointF(520D, 224D);
			this.freeText11.Name = "freeText11";
			this.freeText11.Text = "Ilck";
			// 
			// freeText12
			// 
			this.freeText12.Color = new NxtControl.Drawing.Color("LabelTextColor");
			this.freeText12.Font = new NxtControl.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
			this.freeText12.Location = new NxtControl.Drawing.PointF(520D, 256D);
			this.freeText12.Name = "freeText12";
			this.freeText12.Text = "OFF";
			// 
			// freeText13
			// 
			this.freeText13.Color = new NxtControl.Drawing.Color("LabelTextColor");
			this.freeText13.Font = new NxtControl.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
			this.freeText13.Location = new NxtControl.Drawing.PointF(520D, 288D);
			this.freeText13.Name = "freeText13";
			this.freeText13.Text = "Need Rearm";
			// 
			// freeText14
			// 
			this.freeText14.Color = new NxtControl.Drawing.Color("LabelTextColor");
			this.freeText14.Font = new NxtControl.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
			this.freeText14.Location = new NxtControl.Drawing.PointF(520D, 320D);
			this.freeText14.Name = "freeText14";
			this.freeText14.Text = "S";
			// 
			// freeText15
			// 
			this.freeText15.Color = new NxtControl.Drawing.Color("LabelTextColor");
			this.freeText15.Font = new NxtControl.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
			this.freeText15.Location = new NxtControl.Drawing.PointF(520D, 352D);
			this.freeText15.Name = "freeText15";
			this.freeText15.Text = "?";
			// 
			// line4
			// 
			this.line4.EndPoint = new NxtControl.Drawing.PointF(664D, 112D);
			this.line4.Name = "line4";
			this.line4.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line4.StartPoint = new NxtControl.Drawing.PointF(664D, 392D);
			// 
			// freeText16
			// 
			this.freeText16.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText16.Font = new NxtControl.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
			this.freeText16.Location = new NxtControl.Drawing.PointF(680D, 128D);
			this.freeText16.Name = "freeText16";
			this.freeText16.Text = "Operator Mode";
			// 
			// freeText17
			// 
			this.freeText17.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText17.Font = new NxtControl.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
			this.freeText17.Location = new NxtControl.Drawing.PointF(680D, 160D);
			this.freeText17.Name = "freeText17";
			this.freeText17.Text = "Program Mode";
			// 
			// freeText18
			// 
			this.freeText18.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText18.Font = new NxtControl.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
			this.freeText18.Location = new NxtControl.Drawing.PointF(680D, 224D);
			this.freeText18.Name = "freeText18";
			this.freeText18.Text = "Interlocked";
			// 
			// freeText19
			// 
			this.freeText19.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText19.Font = new NxtControl.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
			this.freeText19.Location = new NxtControl.Drawing.PointF(680D, 256D);
			this.freeText19.Name = "freeText19";
			this.freeText19.Text = "Power Off";
			// 
			// freeText20
			// 
			this.freeText20.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText20.Font = new NxtControl.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
			this.freeText20.Location = new NxtControl.Drawing.PointF(680D, 288D);
			this.freeText20.Name = "freeText20";
			this.freeText20.Text = "Reset/Rearm Required";
			// 
			// freeText21
			// 
			this.freeText21.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText21.Font = new NxtControl.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
			this.freeText21.Location = new NxtControl.Drawing.PointF(680D, 320D);
			this.freeText21.Name = "freeText21";
			this.freeText21.Text = "Simulation or Override Active";
			// 
			// freeText22
			// 
			this.freeText22.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText22.Font = new NxtControl.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
			this.freeText22.Location = new NxtControl.Drawing.PointF(680D, 352D);
			this.freeText22.Name = "freeText22";
			this.freeText22.Text = "Not Ready / Unknown State";
			// 
			// freeText23
			// 
			this.freeText23.Color = new NxtControl.Drawing.Color("LabelTextColor");
			this.freeText23.Font = new NxtControl.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
			this.freeText23.Location = new NxtControl.Drawing.PointF(520D, 192D);
			this.freeText23.Name = "freeText23";
			this.freeText23.Text = "R";
			// 
			// freeText24
			// 
			this.freeText24.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText24.Font = new NxtControl.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
			this.freeText24.Location = new NxtControl.Drawing.PointF(680D, 192D);
			this.freeText24.Name = "freeText24";
			this.freeText24.Text = "Remote Mode";
			// 
			// rectangle10
			// 
			this.rectangle10.Bounds = new NxtControl.Drawing.RectF(((float)(352D)), ((float)(576D)), ((float)(52D)), ((float)(44.571430206298828D)));
			this.rectangle10.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle10.ImageBytes = resources.GetString("rectangle10.ImageBytes");
			this.rectangle10.Name = "rectangle10";
			// 
			// freeText25
			// 
			this.freeText25.Color = new NxtControl.Drawing.Color("LabelTextColor");
			this.freeText25.Font = new NxtControl.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
			this.freeText25.Location = new NxtControl.Drawing.PointF(408D, 584D);
			this.freeText25.Name = "freeText25";
			this.freeText25.Text = "Failure symbol";
			// 
			// LEGEND_
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(1366D)), ((float)(698D)));
			this.Brush = new NxtControl.Drawing.Brush("CanvasBrush");
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.rectangle9,
			this.rectangle8,
			this.freeText1,
			this.freeText2,
			this.freeText3,
			this.freeText4,
			this.freeText5,
			this.freeText6,
			this.freeText7,
			this.rectangle7,
			this.freeText8,
			this.Mode,
			this.sHiHiLevelCalamity1,
			this.HeartBeat,
			this.MCCPower,
			this.group8,
			this.group5,
			this.group4,
			this.group6,
			this.group7,
			this.group2,
			this.group3,
			this.group1,
			this.freeText9,
			this.freeText10,
			this.freeText11,
			this.freeText12,
			this.freeText13,
			this.freeText14,
			this.freeText15,
			this.line4,
			this.freeText16,
			this.freeText17,
			this.freeText18,
			this.freeText19,
			this.freeText20,
			this.freeText21,
			this.freeText22,
			this.freeText23,
			this.freeText24,
			this.rectangle10,
			this.freeText25});
			this.Size = new System.Drawing.Size(1366, 698);

		}
		private NxtControl.GuiFramework.Rectangle rectangle3;
		private NxtControl.GuiFramework.Line line1;
		private NxtControl.GuiFramework.Rectangle rectangle2;
		private NxtControl.GuiFramework.Rectangle rectangle1;
		private NxtControl.GuiFramework.Polygon polygon3;
		private NxtControl.GuiFramework.Line line2;
		private NxtControl.GuiFramework.Rectangle rectangle4;
		private NxtControl.GuiFramework.Polygon polygon5;
		private NxtControl.GuiFramework.Rectangle rectangle5;
		private NxtControl.GuiFramework.Rectangle rectangle6;
		private NxtControl.GuiFramework.Line line3;
		private NxtControl.GuiFramework.Polygon polygon4;
		private NxtControl.GuiFramework.Polygon Base;
		private NxtControl.GuiFramework.Ellipse MotBase;
		private NxtControl.GuiFramework.Polygon polygon1;
		private NxtControl.GuiFramework.Ellipse ellipse1;
		private NxtControl.GuiFramework.Polygon polygon2;
		private NxtControl.GuiFramework.Ellipse ellipse2;
		private NxtControl.GuiFramework.Group group1;
		private NxtControl.GuiFramework.Group group2;
		private NxtControl.GuiFramework.Group group3;
		private NxtControl.GuiFramework.FreeText freeText1;
		private NxtControl.GuiFramework.FreeText freeText2;
		private NxtControl.GuiFramework.FreeText freeText3;
		private NxtControl.GuiFramework.FreeText freeText4;
		private NxtControl.GuiFramework.FreeText freeText5;
		private NxtControl.GuiFramework.FreeText freeText6;
		private NxtControl.GuiFramework.ChangeCanvasButton changeCanvasButton4;
		private NxtControl.GuiFramework.ChangeCanvasButton changeCanvasButton1;
		private NxtControl.GuiFramework.ChangeCanvasButton changeCanvasButton2;
		private NxtControl.GuiFramework.ChangeCanvasButton changeCanvasButton3;
		private NxtControl.GuiFramework.ChangeCanvasButton changeCanvasButton5;
		private NxtControl.GuiFramework.ChangeCanvasButton changeCanvasButton6;
		private NxtControl.GuiFramework.ChangeCanvasButton changeCanvasButton7;
		private NxtControl.GuiFramework.Polygon polygon6;
		private NxtControl.GuiFramework.Ellipse ellipse3;
		private NxtControl.GuiFramework.FreeText freeText7;
		private NxtControl.GuiFramework.Rectangle rectangle7;
		private NxtControl.GuiFramework.FreeText freeText8;
		private SE.Nereda.Symbols.Mode.ReactorMode Mode;
		private SE.Nereda.Symbols.Calamity.sHiHiLevelCalamity sHiHiLevelCalamity1;
		private NxtControl.GuiFramework.Group group4;
		private NxtControl.GuiFramework.Group group5;
		private NxtControl.GuiFramework.Group group6;
		private NxtControl.GuiFramework.Group group7;
		private SE.Nereda.Symbols.HeartBeat.sDefault HeartBeat;
		private SE.Nereda.Symbols.MCCPower.sDefault MCCPower;
		private NxtControl.GuiFramework.Group group8;
		private NxtControl.GuiFramework.FreeText freeText9;
		private NxtControl.GuiFramework.Rectangle rectangle8;
		private NxtControl.GuiFramework.Rectangle rectangle9;
		private NxtControl.GuiFramework.FreeText freeText10;
		private NxtControl.GuiFramework.FreeText freeText11;
		private NxtControl.GuiFramework.FreeText freeText12;
		private NxtControl.GuiFramework.FreeText freeText13;
		private NxtControl.GuiFramework.FreeText freeText14;
		private NxtControl.GuiFramework.FreeText freeText15;
		private NxtControl.GuiFramework.Line line4;
		private NxtControl.GuiFramework.FreeText freeText16;
		private NxtControl.GuiFramework.FreeText freeText17;
		private NxtControl.GuiFramework.FreeText freeText18;
		private NxtControl.GuiFramework.FreeText freeText19;
		private NxtControl.GuiFramework.FreeText freeText20;
		private NxtControl.GuiFramework.FreeText freeText21;
		private NxtControl.GuiFramework.FreeText freeText22;
		private NxtControl.GuiFramework.FreeText freeText23;
		private NxtControl.GuiFramework.FreeText freeText24;
		private NxtControl.GuiFramework.Rectangle rectangle10;
		private NxtControl.GuiFramework.FreeText freeText25;
		#endregion
	}
}
