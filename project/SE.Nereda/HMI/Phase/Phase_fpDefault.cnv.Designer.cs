/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 6/5/2026
 * Time: 9:38 AM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using NxtControl.GuiFramework;

namespace SE.Nereda.Faceplates.Phase
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
			this.State0 = new NxtControl.GuiFramework.RoundedRectangle();
			this.State1 = new NxtControl.GuiFramework.RoundedRectangle();
			this.State2 = new NxtControl.GuiFramework.RoundedRectangle();
			this.State3 = new NxtControl.GuiFramework.RoundedRectangle();
			this.line2 = new NxtControl.GuiFramework.Line();
			this.freeText1 = new NxtControl.GuiFramework.FreeText();
			this.line3 = new NxtControl.GuiFramework.Line();
			this.freeText2 = new NxtControl.GuiFramework.FreeText();
			this.line4 = new NxtControl.GuiFramework.Line();
			this.freeText3 = new NxtControl.GuiFramework.FreeText();
			this.line5 = new NxtControl.GuiFramework.Line();
			this.freeText4 = new NxtControl.GuiFramework.FreeText();
			this.Ready2Ilck1 = new NxtControl.GuiFramework.Line();
			this.State4 = new NxtControl.GuiFramework.RoundedRectangle();
			this.State5 = new NxtControl.GuiFramework.RoundedRectangle();
			this.line7 = new NxtControl.GuiFramework.Line();
			this.freeText5 = new NxtControl.GuiFramework.FreeText();
			this.Starting2Abort = new NxtControl.GuiFramework.Line();
			this.State6 = new NxtControl.GuiFramework.RoundedRectangle();
			this.line10 = new NxtControl.GuiFramework.Line();
			this.line11 = new NxtControl.GuiFramework.Line();
			this.freeText6 = new NxtControl.GuiFramework.FreeText();
			this.freeText7 = new NxtControl.GuiFramework.FreeText();
			this.Run2Abort = new NxtControl.GuiFramework.Line();
			this.line13 = new NxtControl.GuiFramework.Line();
			this.freeText8 = new NxtControl.GuiFramework.FreeText();
			this.Stopping2Abort = new NxtControl.GuiFramework.Line();
			this.line15 = new NxtControl.GuiFramework.Line();
			this.freeText9 = new NxtControl.GuiFramework.FreeText();
			this.line16 = new NxtControl.GuiFramework.Line();
			this.freeText10 = new NxtControl.GuiFramework.FreeText();
			this.Aborted2Interlocked1 = new NxtControl.GuiFramework.Line();
			this.line18 = new NxtControl.GuiFramework.Line();
			this.freeText11 = new NxtControl.GuiFramework.FreeText();
			this.Ready2Ilck2 = new NxtControl.GuiFramework.Line();
			this.line20 = new NxtControl.GuiFramework.Line();
			this.freeText12 = new NxtControl.GuiFramework.FreeText();
			this.Interlocked2Ready2 = new NxtControl.GuiFramework.Line();
			this.ToReady1 = new NxtControl.GuiFramework.Line();
			this.ToReady2 = new NxtControl.GuiFramework.Line();
			this.polygon1 = new NxtControl.GuiFramework.Polygon();
			this.polygon2 = new NxtControl.GuiFramework.Polygon();
			this.polygon3 = new NxtControl.GuiFramework.Polygon();
			this.polygon4 = new NxtControl.GuiFramework.Polygon();
			this.polygon5 = new NxtControl.GuiFramework.Polygon();
			this.polygon6 = new NxtControl.GuiFramework.Polygon();
			this.polygon7 = new NxtControl.GuiFramework.Polygon();
			this.polygon8 = new NxtControl.GuiFramework.Polygon();
			this.polygon9 = new NxtControl.GuiFramework.Polygon();
			this.polygon10 = new NxtControl.GuiFramework.Polygon();
			this.PhaseName = new NxtControl.GuiFramework.RoundedRectangle();
			this.roundedRectangle2 = new NxtControl.GuiFramework.RoundedRectangle();
			this.roundedRectangle3 = new NxtControl.GuiFramework.RoundedRectangle();
			this.ManStart = new NxtControl.GuiFramework.DrawnButton();
			this.ManStop = new NxtControl.GuiFramework.DrawnButton();
			this.ManReset = new NxtControl.GuiFramework.DrawnButton();
			this.freeText13 = new NxtControl.GuiFramework.FreeText();
			this.NoActionAllowed = new NxtControl.GuiFramework.FreeText();
			this.FTrs1 = new NxtControl.GuiFramework.DrawnButton();
			this.FTrs2 = new NxtControl.GuiFramework.DrawnButton();
			this.FTrs3 = new NxtControl.GuiFramework.DrawnButton();
			this.FTrs4 = new NxtControl.GuiFramework.DrawnButton();
			this.FTrs5 = new NxtControl.GuiFramework.DrawnButton();
			this.FTrs6 = new NxtControl.GuiFramework.DrawnButton();
			this.FTrs7 = new NxtControl.GuiFramework.DrawnButton();
			this.FTrs8 = new NxtControl.GuiFramework.DrawnButton();
			this.FTrs9 = new NxtControl.GuiFramework.DrawnButton();
			this.FTrs10 = new NxtControl.GuiFramework.DrawnButton();
			this.FTrs11 = new NxtControl.GuiFramework.DrawnButton();
			this.FTrs12 = new NxtControl.GuiFramework.DrawnButton();
			this.ActivateForce = new NxtControl.GuiFramework.TwoStateButton();
			this.roundedRectangle1 = new NxtControl.GuiFramework.RoundedRectangle();
			this.roundedRectangle4 = new NxtControl.GuiFramework.RoundedRectangle();
			this.group1 = new NxtControl.GuiFramework.Group();
			this.ToReady3 = new NxtControl.GuiFramework.Line();
			this.Ready2Starting = new NxtControl.GuiFramework.Line();
			this.Starting2Run = new NxtControl.GuiFramework.Line();
			this.Run2Stopping = new NxtControl.GuiFramework.Line();
			this.Stopping2Ready1 = new NxtControl.GuiFramework.Line();
			this.ToAborting3 = new NxtControl.GuiFramework.Line();
			this.ToAborting1 = new NxtControl.GuiFramework.Line();
			this.Aborted2Ready = new NxtControl.GuiFramework.Line();
			this.Interlocked2Ready1 = new NxtControl.GuiFramework.Line();
			this.IlckAborted2Ready = new NxtControl.GuiFramework.Line();
			this.Stopping2Ready2 = new NxtControl.GuiFramework.Line();
			this.Aborting2Aborted = new NxtControl.GuiFramework.Line();
			this.ReadyAborted2Interlocked2 = new NxtControl.GuiFramework.Line();
			this.FromReady = new NxtControl.GuiFramework.Line();
			this.ToAborting2 = new NxtControl.GuiFramework.Line();
			// 
			// State0
			// 
			this.State0.Bounds = new NxtControl.Drawing.RectF(((float)(56D)), ((float)(40D)), ((float)(96D)), ((float)(32D)));
			this.State0.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(186)), ((byte)(186)), ((byte)(186))));
			this.State0.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.State0.Name = "State0";
			this.State0.Text = "Ready";
			this.State0.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			// 
			// State1
			// 
			this.State1.Bounds = new NxtControl.Drawing.RectF(((float)(56D)), ((float)(128D)), ((float)(96D)), ((float)(32D)));
			this.State1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(186)), ((byte)(186)), ((byte)(186))));
			this.State1.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.State1.Name = "State1";
			this.State1.Text = "Starting";
			this.State1.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			// 
			// State2
			// 
			this.State2.Bounds = new NxtControl.Drawing.RectF(((float)(56D)), ((float)(216D)), ((float)(96D)), ((float)(32D)));
			this.State2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(186)), ((byte)(186)), ((byte)(186))));
			this.State2.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.State2.Name = "State2";
			this.State2.Text = "Running";
			this.State2.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			// 
			// State3
			// 
			this.State3.Bounds = new NxtControl.Drawing.RectF(((float)(56D)), ((float)(304D)), ((float)(96D)), ((float)(32D)));
			this.State3.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(186)), ((byte)(186)), ((byte)(186))));
			this.State3.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.State3.Name = "State3";
			this.State3.Text = "Stopping";
			this.State3.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			// 
			// line2
			// 
			this.line2.EndPoint = new NxtControl.Drawing.PointF(120D, 104D);
			this.line2.Name = "line2";
			this.line2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 5F, NxtControl.Drawing.DashStyle.Solid);
			this.line2.StartPoint = new NxtControl.Drawing.PointF(88D, 104D);
			// 
			// freeText1
			// 
			this.freeText1.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText1.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.freeText1.Location = new NxtControl.Drawing.PointF(40D, 96D);
			this.freeText1.Name = "freeText1";
			this.freeText1.Text = "START";
			// 
			// line3
			// 
			this.line3.EndPoint = new NxtControl.Drawing.PointF(120D, 192D);
			this.line3.Name = "line3";
			this.line3.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 5F, NxtControl.Drawing.DashStyle.Solid);
			this.line3.StartPoint = new NxtControl.Drawing.PointF(88D, 192D);
			// 
			// freeText2
			// 
			this.freeText2.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText2.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.freeText2.Location = new NxtControl.Drawing.PointF(40D, 176D);
			this.freeText2.Name = "freeText2";
			this.freeText2.Text = "Start\r\nReady";
			// 
			// line4
			// 
			this.line4.EndPoint = new NxtControl.Drawing.PointF(120D, 280D);
			this.line4.Name = "line4";
			this.line4.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 5F, NxtControl.Drawing.DashStyle.Solid);
			this.line4.StartPoint = new NxtControl.Drawing.PointF(88D, 280D);
			// 
			// freeText3
			// 
			this.freeText3.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText3.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.freeText3.Location = new NxtControl.Drawing.PointF(40D, 272D);
			this.freeText3.Name = "freeText3";
			this.freeText3.Text = "STOP";
			// 
			// line5
			// 
			this.line5.EndPoint = new NxtControl.Drawing.PointF(120D, 368D);
			this.line5.Name = "line5";
			this.line5.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 5F, NxtControl.Drawing.DashStyle.Solid);
			this.line5.StartPoint = new NxtControl.Drawing.PointF(88D, 368D);
			// 
			// freeText4
			// 
			this.freeText4.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText4.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.freeText4.Location = new NxtControl.Drawing.PointF(40D, 352D);
			this.freeText4.Name = "freeText4";
			this.freeText4.Text = "Stop\r\nReady";
			// 
			// Ready2Ilck1
			// 
			this.Ready2Ilck1.EndPoint = new NxtControl.Drawing.PointF(528D, 88D);
			this.Ready2Ilck1.Name = "Ready2Ilck1";
			this.Ready2Ilck1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 3F, NxtControl.Drawing.DashStyle.Solid);
			this.Ready2Ilck1.StartPoint = new NxtControl.Drawing.PointF(104D, 88D);
			// 
			// State4
			// 
			this.State4.Bounds = new NxtControl.Drawing.RectF(((float)(280D)), ((float)(376D)), ((float)(96D)), ((float)(32D)));
			this.State4.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(186)), ((byte)(186)), ((byte)(186))));
			this.State4.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.State4.Name = "State4";
			this.State4.Text = "Aborting";
			this.State4.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			// 
			// State5
			// 
			this.State5.Bounds = new NxtControl.Drawing.RectF(((float)(280D)), ((float)(456D)), ((float)(96D)), ((float)(32D)));
			this.State5.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(186)), ((byte)(186)), ((byte)(186))));
			this.State5.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.State5.Name = "State5";
			this.State5.Text = "Aborted";
			this.State5.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			// 
			// line7
			// 
			this.line7.EndPoint = new NxtControl.Drawing.PointF(344D, 432D);
			this.line7.Name = "line7";
			this.line7.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 5F, NxtControl.Drawing.DashStyle.Solid);
			this.line7.StartPoint = new NxtControl.Drawing.PointF(312D, 432D);
			// 
			// freeText5
			// 
			this.freeText5.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText5.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.freeText5.Location = new NxtControl.Drawing.PointF(264D, 416D);
			this.freeText5.Name = "freeText5";
			this.freeText5.Text = "Abort\r\nReady";
			// 
			// Starting2Abort
			// 
			this.Starting2Abort.EndPoint = new NxtControl.Drawing.PointF(328D, 176D);
			this.Starting2Abort.Name = "Starting2Abort";
			this.Starting2Abort.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 3F, NxtControl.Drawing.DashStyle.Solid);
			this.Starting2Abort.StartPoint = new NxtControl.Drawing.PointF(104D, 176D);
			// 
			// State6
			// 
			this.State6.Bounds = new NxtControl.Drawing.RectF(((float)(480D)), ((float)(560D)), ((float)(96D)), ((float)(32D)));
			this.State6.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(186)), ((byte)(186)), ((byte)(186))));
			this.State6.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.State6.Name = "State6";
			this.State6.Text = "Interlocked";
			this.State6.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			// 
			// line10
			// 
			this.line10.EndPoint = new NxtControl.Drawing.PointF(232D, 72D);
			this.line10.Name = "line10";
			this.line10.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 5F, NxtControl.Drawing.DashStyle.Solid);
			this.line10.StartPoint = new NxtControl.Drawing.PointF(232D, 104D);
			// 
			// line11
			// 
			this.line11.EndPoint = new NxtControl.Drawing.PointF(232D, 160D);
			this.line11.Name = "line11";
			this.line11.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 5F, NxtControl.Drawing.DashStyle.Solid);
			this.line11.StartPoint = new NxtControl.Drawing.PointF(232D, 192D);
			// 
			// freeText6
			// 
			this.freeText6.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText6.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.freeText6.Location = new NxtControl.Drawing.PointF(168D, 56D);
			this.freeText6.Name = "freeText6";
			this.freeText6.Text = "no operating conditions";
			// 
			// freeText7
			// 
			this.freeText7.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText7.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.freeText7.Location = new NxtControl.Drawing.PointF(168D, 144D);
			this.freeText7.Name = "freeText7";
			this.freeText7.Text = "no operating conditions";
			// 
			// Run2Abort
			// 
			this.Run2Abort.EndPoint = new NxtControl.Drawing.PointF(328D, 264D);
			this.Run2Abort.Name = "Run2Abort";
			this.Run2Abort.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 3F, NxtControl.Drawing.DashStyle.Solid);
			this.Run2Abort.StartPoint = new NxtControl.Drawing.PointF(104D, 264D);
			// 
			// line13
			// 
			this.line13.EndPoint = new NxtControl.Drawing.PointF(232D, 248D);
			this.line13.Name = "line13";
			this.line13.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 5F, NxtControl.Drawing.DashStyle.Solid);
			this.line13.StartPoint = new NxtControl.Drawing.PointF(232D, 280D);
			// 
			// freeText8
			// 
			this.freeText8.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText8.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.freeText8.Location = new NxtControl.Drawing.PointF(168D, 232D);
			this.freeText8.Name = "freeText8";
			this.freeText8.Text = "no operating conditions";
			// 
			// Stopping2Abort
			// 
			this.Stopping2Abort.EndPoint = new NxtControl.Drawing.PointF(328D, 352D);
			this.Stopping2Abort.Name = "Stopping2Abort";
			this.Stopping2Abort.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 3F, NxtControl.Drawing.DashStyle.Solid);
			this.Stopping2Abort.StartPoint = new NxtControl.Drawing.PointF(104D, 352D);
			// 
			// line15
			// 
			this.line15.EndPoint = new NxtControl.Drawing.PointF(232D, 336D);
			this.line15.Name = "line15";
			this.line15.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 5F, NxtControl.Drawing.DashStyle.Solid);
			this.line15.StartPoint = new NxtControl.Drawing.PointF(232D, 368D);
			// 
			// freeText9
			// 
			this.freeText9.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText9.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.freeText9.Location = new NxtControl.Drawing.PointF(168D, 320D);
			this.freeText9.Name = "freeText9";
			this.freeText9.Text = "no operating conditions";
			// 
			// line16
			// 
			this.line16.EndPoint = new NxtControl.Drawing.PointF(344D, 536D);
			this.line16.Name = "line16";
			this.line16.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 5F, NxtControl.Drawing.DashStyle.Solid);
			this.line16.StartPoint = new NxtControl.Drawing.PointF(312D, 536D);
			// 
			// freeText10
			// 
			this.freeText10.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText10.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.freeText10.Location = new NxtControl.Drawing.PointF(248D, 512D);
			this.freeText10.Name = "freeText10";
			this.freeText10.Text = "RESET and\r\noperating\r\nconditions";
			// 
			// Aborted2Interlocked1
			// 
			this.Aborted2Interlocked1.EndPoint = new NxtControl.Drawing.PointF(528D, 504D);
			this.Aborted2Interlocked1.Name = "Aborted2Interlocked1";
			this.Aborted2Interlocked1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 3F, NxtControl.Drawing.DashStyle.Solid);
			this.Aborted2Interlocked1.StartPoint = new NxtControl.Drawing.PointF(328D, 504D);
			// 
			// line18
			// 
			this.line18.EndPoint = new NxtControl.Drawing.PointF(440D, 488D);
			this.line18.Name = "line18";
			this.line18.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 5F, NxtControl.Drawing.DashStyle.Solid);
			this.line18.StartPoint = new NxtControl.Drawing.PointF(440D, 520D);
			// 
			// freeText11
			// 
			this.freeText11.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText11.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.freeText11.Location = new NxtControl.Drawing.PointF(408D, 440D);
			this.freeText11.Name = "freeText11";
			this.freeText11.Text = "RESET and\r\nno operating\r\nconditions";
			// 
			// Ready2Ilck2
			// 
			this.Ready2Ilck2.EndPoint = new NxtControl.Drawing.PointF(528D, 504D);
			this.Ready2Ilck2.Name = "Ready2Ilck2";
			this.Ready2Ilck2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 3F, NxtControl.Drawing.DashStyle.Solid);
			this.Ready2Ilck2.StartPoint = new NxtControl.Drawing.PointF(528D, 88D);
			// 
			// line20
			// 
			this.line20.EndPoint = new NxtControl.Drawing.PointF(544D, 624D);
			this.line20.Name = "line20";
			this.line20.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 5F, NxtControl.Drawing.DashStyle.Solid);
			this.line20.StartPoint = new NxtControl.Drawing.PointF(512D, 624D);
			// 
			// freeText12
			// 
			this.freeText12.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText12.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.freeText12.Location = new NxtControl.Drawing.PointF(440D, 608D);
			this.freeText12.Name = "freeText12";
			this.freeText12.Text = "Operating\r\nconditions";
			// 
			// Interlocked2Ready2
			// 
			this.Interlocked2Ready2.EndPoint = new NxtControl.Drawing.PointF(528D, 664D);
			this.Interlocked2Ready2.Name = "Interlocked2Ready2";
			this.Interlocked2Ready2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 3F, NxtControl.Drawing.DashStyle.Solid);
			this.Interlocked2Ready2.StartPoint = new NxtControl.Drawing.PointF(328D, 664D);
			// 
			// ToReady1
			// 
			this.ToReady1.EndPoint = new NxtControl.Drawing.PointF(16D, 664D);
			this.ToReady1.Name = "ToReady1";
			this.ToReady1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 3F, NxtControl.Drawing.DashStyle.Solid);
			this.ToReady1.StartPoint = new NxtControl.Drawing.PointF(16D, 16D);
			// 
			// ToReady2
			// 
			this.ToReady2.EndPoint = new NxtControl.Drawing.PointF(104D, 16D);
			this.ToReady2.Name = "ToReady2";
			this.ToReady2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 3F, NxtControl.Drawing.DashStyle.Solid);
			this.ToReady2.StartPoint = new NxtControl.Drawing.PointF(16D, 16D);
			// 
			// polygon1
			// 
			this.polygon1.Bounds = new NxtControl.Drawing.RectF(((float)(280D)), ((float)(171D)), ((float)(16D)), ((float)(10D)));
			this.polygon1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			this.polygon1.Closed = true;
			this.polygon1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.polygon1.Name = "polygon1";
			this.polygon1.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(296D, 176D),
			new NxtControl.Drawing.PointF(280D, 171D),
			new NxtControl.Drawing.PointF(280D, 181D)});
			// 
			// polygon2
			// 
			this.polygon2.Bounds = new NxtControl.Drawing.RectF(((float)(280D)), ((float)(259D)), ((float)(16D)), ((float)(10D)));
			this.polygon2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			this.polygon2.Closed = true;
			this.polygon2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.polygon2.Name = "polygon2";
			this.polygon2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(296D, 264D),
			new NxtControl.Drawing.PointF(280D, 259D),
			new NxtControl.Drawing.PointF(280D, 269D)});
			// 
			// polygon3
			// 
			this.polygon3.Bounds = new NxtControl.Drawing.RectF(((float)(280D)), ((float)(347D)), ((float)(16D)), ((float)(10D)));
			this.polygon3.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			this.polygon3.Closed = true;
			this.polygon3.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.polygon3.Name = "polygon3";
			this.polygon3.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(296D, 352D),
			new NxtControl.Drawing.PointF(280D, 347D),
			new NxtControl.Drawing.PointF(280D, 357D)});
			// 
			// polygon4
			// 
			this.polygon4.Bounds = new NxtControl.Drawing.RectF(((float)(280D)), ((float)(83D)), ((float)(16D)), ((float)(10D)));
			this.polygon4.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			this.polygon4.Closed = true;
			this.polygon4.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.polygon4.Name = "polygon4";
			this.polygon4.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(296D, 88D),
			new NxtControl.Drawing.PointF(280D, 83D),
			new NxtControl.Drawing.PointF(280D, 93D)});
			// 
			// polygon5
			// 
			this.polygon5.Bounds = new NxtControl.Drawing.RectF(((float)(480D)), ((float)(499D)), ((float)(16D)), ((float)(10D)));
			this.polygon5.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			this.polygon5.Closed = true;
			this.polygon5.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.polygon5.Name = "polygon5";
			this.polygon5.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(496D, 504D),
			new NxtControl.Drawing.PointF(480D, 499D),
			new NxtControl.Drawing.PointF(480D, 509D)});
			// 
			// polygon6
			// 
			this.polygon6.Bounds = new NxtControl.Drawing.RectF(((float)(99D)), ((float)(608D)), ((float)(10D)), ((float)(16D)));
			this.polygon6.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			this.polygon6.Closed = true;
			this.polygon6.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.polygon6.Name = "polygon6";
			this.polygon6.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(104D, 624D),
			new NxtControl.Drawing.PointF(109D, 608D),
			new NxtControl.Drawing.PointF(99D, 608D)});
			// 
			// polygon7
			// 
			this.polygon7.Bounds = new NxtControl.Drawing.RectF(((float)(323D)), ((float)(608D)), ((float)(10D)), ((float)(16D)));
			this.polygon7.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			this.polygon7.Closed = true;
			this.polygon7.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.polygon7.Name = "polygon7";
			this.polygon7.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(328D, 624D),
			new NxtControl.Drawing.PointF(333D, 608D),
			new NxtControl.Drawing.PointF(323D, 608D)});
			// 
			// polygon8
			// 
			this.polygon8.Bounds = new NxtControl.Drawing.RectF(((float)(99D)), ((float)(24D)), ((float)(10D)), ((float)(16D)));
			this.polygon8.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			this.polygon8.Closed = true;
			this.polygon8.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.polygon8.Name = "polygon8";
			this.polygon8.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(104D, 40D),
			new NxtControl.Drawing.PointF(109D, 24D),
			new NxtControl.Drawing.PointF(99D, 24D)});
			// 
			// polygon9
			// 
			this.polygon9.Bounds = new NxtControl.Drawing.RectF(((float)(136D)), ((float)(659D)), ((float)(16D)), ((float)(10D)));
			this.polygon9.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			this.polygon9.Closed = true;
			this.polygon9.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.polygon9.Name = "polygon9";
			this.polygon9.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(136D, 664D),
			new NxtControl.Drawing.PointF(152D, 659D),
			new NxtControl.Drawing.PointF(152D, 669D)});
			// 
			// polygon10
			// 
			this.polygon10.Bounds = new NxtControl.Drawing.RectF(((float)(368D)), ((float)(659D)), ((float)(16D)), ((float)(10D)));
			this.polygon10.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			this.polygon10.Closed = true;
			this.polygon10.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.polygon10.Name = "polygon10";
			this.polygon10.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(368D, 664D),
			new NxtControl.Drawing.PointF(384D, 659D),
			new NxtControl.Drawing.PointF(384D, 669D)});
			// 
			// PhaseName
			// 
			this.PhaseName.Bounds = new NxtControl.Drawing.RectF(((float)(552D)), ((float)(24D)), ((float)(264D)), ((float)(24D)));
			this.PhaseName.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(240)), ((byte)(240)), ((byte)(240))));
			this.PhaseName.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
			this.PhaseName.Name = "PhaseName";
			this.PhaseName.Text = "Phase";
			this.PhaseName.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			// 
			// roundedRectangle2
			// 
			this.roundedRectangle2.Bounds = new NxtControl.Drawing.RectF(((float)(552D)), ((float)(56D)), ((float)(264D)), ((float)(104D)));
			this.roundedRectangle2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(240)), ((byte)(240)), ((byte)(240))));
			this.roundedRectangle2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.roundedRectangle2.Name = "roundedRectangle2";
			// 
			// roundedRectangle3
			// 
			this.roundedRectangle3.Bounds = new NxtControl.Drawing.RectF(((float)(544D)), ((float)(16D)), ((float)(280D)), ((float)(152D)));
			this.roundedRectangle3.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(210)), ((byte)(210)), ((byte)(210))));
			this.roundedRectangle3.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.roundedRectangle3.Name = "roundedRectangle3";
			// 
			// ManStart
			// 
			this.ManStart.Bounds = new NxtControl.Drawing.RectF(((float)(560D)), ((float)(88D)), ((float)(72D)), ((float)(32D)));
			this.ManStart.Brush = new NxtControl.Drawing.Brush("ButtonBrush");
			this.ManStart.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.ManStart.InnerBorderColor = new NxtControl.Drawing.Color("ButtonInnerBorderColor");
			this.ManStart.Name = "ManStart";
			this.ManStart.Pen = new NxtControl.Drawing.Pen("ButtonPen");
			this.ManStart.Radius = 4D;
			this.ManStart.Text = "START";
			this.ManStart.TextColor = new NxtControl.Drawing.Color("ButtonTextColor");
			this.ManStart.TextColorMouseDown = new NxtControl.Drawing.Color("ButtonTextColorMouseDown");
			this.ManStart.Use3DEffect = false;
			this.ManStart.Click += new System.EventHandler(this.ManStartClick);
			// 
			// ManStop
			// 
			this.ManStop.Bounds = new NxtControl.Drawing.RectF(((float)(648D)), ((float)(88D)), ((float)(72D)), ((float)(32D)));
			this.ManStop.Brush = new NxtControl.Drawing.Brush("ButtonBrush");
			this.ManStop.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.ManStop.InnerBorderColor = new NxtControl.Drawing.Color("ButtonInnerBorderColor");
			this.ManStop.Name = "ManStop";
			this.ManStop.Pen = new NxtControl.Drawing.Pen("ButtonPen");
			this.ManStop.Radius = 4D;
			this.ManStop.Text = "STOP";
			this.ManStop.TextColor = new NxtControl.Drawing.Color("ButtonTextColor");
			this.ManStop.TextColorMouseDown = new NxtControl.Drawing.Color("ButtonTextColorMouseDown");
			this.ManStop.Use3DEffect = false;
			this.ManStop.Click += new System.EventHandler(this.ManStopClick);
			// 
			// ManReset
			// 
			this.ManReset.Bounds = new NxtControl.Drawing.RectF(((float)(736D)), ((float)(88D)), ((float)(72D)), ((float)(32D)));
			this.ManReset.Brush = new NxtControl.Drawing.Brush("ButtonBrush");
			this.ManReset.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.ManReset.InnerBorderColor = new NxtControl.Drawing.Color("ButtonInnerBorderColor");
			this.ManReset.Name = "ManReset";
			this.ManReset.Pen = new NxtControl.Drawing.Pen("ButtonPen");
			this.ManReset.Radius = 4D;
			this.ManReset.Text = "RESET";
			this.ManReset.TextColor = new NxtControl.Drawing.Color("ButtonTextColor");
			this.ManReset.TextColorMouseDown = new NxtControl.Drawing.Color("ButtonTextColorMouseDown");
			this.ManReset.Use3DEffect = false;
			this.ManReset.Click += new System.EventHandler(this.ManResetClick);
			// 
			// freeText13
			// 
			this.freeText13.Color = new NxtControl.Drawing.Color("LabelTextColor");
			this.freeText13.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText13.Location = new NxtControl.Drawing.PointF(560D, 64D);
			this.freeText13.Name = "freeText13";
			this.freeText13.Text = "Manuel Mode :";
			// 
			// NoActionAllowed
			// 
			this.NoActionAllowed.Color = new NxtControl.Drawing.Color("Red");
			this.NoActionAllowed.Font = new NxtControl.Drawing.Font("LabelFont");
			this.NoActionAllowed.Location = new NxtControl.Drawing.PointF(581D, 136D);
			this.NoActionAllowed.Name = "NoActionAllowed";
			this.NoActionAllowed.Text = "######## mode : No action allowed";
			// 
			// FTrs1
			// 
			this.FTrs1.Bounds = new NxtControl.Drawing.RectF(((float)(120D)), ((float)(96D)), ((float)(24D)), ((float)(24D)));
			this.FTrs1.Brush = new NxtControl.Drawing.Brush("ButtonBrush");
			this.FTrs1.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.FTrs1.InnerBorderColor = new NxtControl.Drawing.Color("MedFlueGas");
			this.FTrs1.Name = "FTrs1";
			this.FTrs1.Pen = new NxtControl.Drawing.Pen("ButtonPen");
			this.FTrs1.Radius = 4D;
			this.FTrs1.Text = "F";
			this.FTrs1.TextColor = new NxtControl.Drawing.Color("ButtonTextColor");
			this.FTrs1.TextColorMouseDown = new NxtControl.Drawing.Color("ButtonTextColorMouseDown");
			this.FTrs1.Use3DEffect = false;
			this.FTrs1.Click += new System.EventHandler(this.FTrs1Click);
			// 
			// FTrs2
			// 
			this.FTrs2.Bounds = new NxtControl.Drawing.RectF(((float)(120D)), ((float)(184D)), ((float)(24D)), ((float)(24D)));
			this.FTrs2.Brush = new NxtControl.Drawing.Brush("ButtonBrush");
			this.FTrs2.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.FTrs2.InnerBorderColor = new NxtControl.Drawing.Color("MedFlueGas");
			this.FTrs2.Name = "FTrs2";
			this.FTrs2.Pen = new NxtControl.Drawing.Pen("ButtonPen");
			this.FTrs2.Radius = 4D;
			this.FTrs2.Text = "F";
			this.FTrs2.TextColor = new NxtControl.Drawing.Color("ButtonTextColor");
			this.FTrs2.TextColorMouseDown = new NxtControl.Drawing.Color("ButtonTextColorMouseDown");
			this.FTrs2.Use3DEffect = false;
			this.FTrs2.Click += new System.EventHandler(this.FTrs2Click);
			// 
			// FTrs3
			// 
			this.FTrs3.Bounds = new NxtControl.Drawing.RectF(((float)(120D)), ((float)(272D)), ((float)(24D)), ((float)(24D)));
			this.FTrs3.Brush = new NxtControl.Drawing.Brush("ButtonBrush");
			this.FTrs3.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.FTrs3.InnerBorderColor = new NxtControl.Drawing.Color("MedFlueGas");
			this.FTrs3.Name = "FTrs3";
			this.FTrs3.Pen = new NxtControl.Drawing.Pen("ButtonPen");
			this.FTrs3.Radius = 4D;
			this.FTrs3.Text = "F";
			this.FTrs3.TextColor = new NxtControl.Drawing.Color("ButtonTextColor");
			this.FTrs3.TextColorMouseDown = new NxtControl.Drawing.Color("ButtonTextColorMouseDown");
			this.FTrs3.Use3DEffect = false;
			this.FTrs3.Click += new System.EventHandler(this.FTrs3Click);
			// 
			// FTrs4
			// 
			this.FTrs4.Bounds = new NxtControl.Drawing.RectF(((float)(120D)), ((float)(360D)), ((float)(24D)), ((float)(24D)));
			this.FTrs4.Brush = new NxtControl.Drawing.Brush("ButtonBrush");
			this.FTrs4.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.FTrs4.InnerBorderColor = new NxtControl.Drawing.Color("MedFlueGas");
			this.FTrs4.Name = "FTrs4";
			this.FTrs4.Pen = new NxtControl.Drawing.Pen("ButtonPen");
			this.FTrs4.Radius = 4D;
			this.FTrs4.Text = "F";
			this.FTrs4.TextColor = new NxtControl.Drawing.Color("ButtonTextColor");
			this.FTrs4.TextColorMouseDown = new NxtControl.Drawing.Color("ButtonTextColorMouseDown");
			this.FTrs4.Use3DEffect = false;
			this.FTrs4.Click += new System.EventHandler(this.FTrs4Click);
			// 
			// FTrs5
			// 
			this.FTrs5.Bounds = new NxtControl.Drawing.RectF(((float)(224D)), ((float)(104D)), ((float)(24D)), ((float)(24D)));
			this.FTrs5.Brush = new NxtControl.Drawing.Brush("ButtonBrush");
			this.FTrs5.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.FTrs5.InnerBorderColor = new NxtControl.Drawing.Color("MedFlueGas");
			this.FTrs5.Name = "FTrs5";
			this.FTrs5.Pen = new NxtControl.Drawing.Pen("ButtonPen");
			this.FTrs5.Radius = 4D;
			this.FTrs5.Text = "F";
			this.FTrs5.TextColor = new NxtControl.Drawing.Color("ButtonTextColor");
			this.FTrs5.TextColorMouseDown = new NxtControl.Drawing.Color("ButtonTextColorMouseDown");
			this.FTrs5.Use3DEffect = false;
			this.FTrs5.Click += new System.EventHandler(this.FTrs5Click);
			// 
			// FTrs6
			// 
			this.FTrs6.Bounds = new NxtControl.Drawing.RectF(((float)(224D)), ((float)(192D)), ((float)(24D)), ((float)(24D)));
			this.FTrs6.Brush = new NxtControl.Drawing.Brush("ButtonBrush");
			this.FTrs6.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.FTrs6.InnerBorderColor = new NxtControl.Drawing.Color("MedFlueGas");
			this.FTrs6.Name = "FTrs6";
			this.FTrs6.Pen = new NxtControl.Drawing.Pen("ButtonPen");
			this.FTrs6.Radius = 4D;
			this.FTrs6.Text = "F";
			this.FTrs6.TextColor = new NxtControl.Drawing.Color("ButtonTextColor");
			this.FTrs6.TextColorMouseDown = new NxtControl.Drawing.Color("ButtonTextColorMouseDown");
			this.FTrs6.Use3DEffect = false;
			this.FTrs6.Click += new System.EventHandler(this.FTrs6Click);
			// 
			// FTrs7
			// 
			this.FTrs7.Bounds = new NxtControl.Drawing.RectF(((float)(224D)), ((float)(280D)), ((float)(24D)), ((float)(24D)));
			this.FTrs7.Brush = new NxtControl.Drawing.Brush("ButtonBrush");
			this.FTrs7.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.FTrs7.InnerBorderColor = new NxtControl.Drawing.Color("MedFlueGas");
			this.FTrs7.Name = "FTrs7";
			this.FTrs7.Pen = new NxtControl.Drawing.Pen("ButtonPen");
			this.FTrs7.Radius = 4D;
			this.FTrs7.Text = "F";
			this.FTrs7.TextColor = new NxtControl.Drawing.Color("ButtonTextColor");
			this.FTrs7.TextColorMouseDown = new NxtControl.Drawing.Color("ButtonTextColorMouseDown");
			this.FTrs7.Use3DEffect = false;
			this.FTrs7.Click += new System.EventHandler(this.FTrs7Click);
			// 
			// FTrs8
			// 
			this.FTrs8.Bounds = new NxtControl.Drawing.RectF(((float)(224D)), ((float)(368D)), ((float)(24D)), ((float)(24D)));
			this.FTrs8.Brush = new NxtControl.Drawing.Brush("ButtonBrush");
			this.FTrs8.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.FTrs8.InnerBorderColor = new NxtControl.Drawing.Color("MedFlueGas");
			this.FTrs8.Name = "FTrs8";
			this.FTrs8.Pen = new NxtControl.Drawing.Pen("ButtonPen");
			this.FTrs8.Radius = 4D;
			this.FTrs8.Text = "F";
			this.FTrs8.TextColor = new NxtControl.Drawing.Color("ButtonTextColor");
			this.FTrs8.TextColorMouseDown = new NxtControl.Drawing.Color("ButtonTextColorMouseDown");
			this.FTrs8.Use3DEffect = false;
			this.FTrs8.Click += new System.EventHandler(this.FTrs8Click);
			// 
			// FTrs9
			// 
			this.FTrs9.Bounds = new NxtControl.Drawing.RectF(((float)(344D)), ((float)(424D)), ((float)(24D)), ((float)(24D)));
			this.FTrs9.Brush = new NxtControl.Drawing.Brush("ButtonBrush");
			this.FTrs9.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.FTrs9.InnerBorderColor = new NxtControl.Drawing.Color("MedFlueGas");
			this.FTrs9.Name = "FTrs9";
			this.FTrs9.Pen = new NxtControl.Drawing.Pen("ButtonPen");
			this.FTrs9.Radius = 4D;
			this.FTrs9.Text = "F";
			this.FTrs9.TextColor = new NxtControl.Drawing.Color("ButtonTextColor");
			this.FTrs9.TextColorMouseDown = new NxtControl.Drawing.Color("ButtonTextColorMouseDown");
			this.FTrs9.Use3DEffect = false;
			this.FTrs9.Click += new System.EventHandler(this.FTrs9Click);
			// 
			// FTrs10
			// 
			this.FTrs10.Bounds = new NxtControl.Drawing.RectF(((float)(344D)), ((float)(528D)), ((float)(24D)), ((float)(24D)));
			this.FTrs10.Brush = new NxtControl.Drawing.Brush("ButtonBrush");
			this.FTrs10.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.FTrs10.InnerBorderColor = new NxtControl.Drawing.Color("MedFlueGas");
			this.FTrs10.Name = "FTrs10";
			this.FTrs10.Pen = new NxtControl.Drawing.Pen("ButtonPen");
			this.FTrs10.Radius = 4D;
			this.FTrs10.Text = "F";
			this.FTrs10.TextColor = new NxtControl.Drawing.Color("ButtonTextColor");
			this.FTrs10.TextColorMouseDown = new NxtControl.Drawing.Color("ButtonTextColorMouseDown");
			this.FTrs10.Use3DEffect = false;
			this.FTrs10.Click += new System.EventHandler(this.FTrs10Click);
			// 
			// FTrs11
			// 
			this.FTrs11.Bounds = new NxtControl.Drawing.RectF(((float)(432D)), ((float)(520D)), ((float)(24D)), ((float)(24D)));
			this.FTrs11.Brush = new NxtControl.Drawing.Brush("ButtonBrush");
			this.FTrs11.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.FTrs11.InnerBorderColor = new NxtControl.Drawing.Color("MedFlueGas");
			this.FTrs11.Name = "FTrs11";
			this.FTrs11.Pen = new NxtControl.Drawing.Pen("ButtonPen");
			this.FTrs11.Radius = 4D;
			this.FTrs11.Text = "F";
			this.FTrs11.TextColor = new NxtControl.Drawing.Color("ButtonTextColor");
			this.FTrs11.TextColorMouseDown = new NxtControl.Drawing.Color("ButtonTextColorMouseDown");
			this.FTrs11.Use3DEffect = false;
			this.FTrs11.Click += new System.EventHandler(this.FTrs11Click);
			// 
			// FTrs12
			// 
			this.FTrs12.Bounds = new NxtControl.Drawing.RectF(((float)(544D)), ((float)(616D)), ((float)(24D)), ((float)(24D)));
			this.FTrs12.Brush = new NxtControl.Drawing.Brush("ButtonBrush");
			this.FTrs12.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.FTrs12.InnerBorderColor = new NxtControl.Drawing.Color("MedFlueGas");
			this.FTrs12.Name = "FTrs12";
			this.FTrs12.Pen = new NxtControl.Drawing.Pen("ButtonPen");
			this.FTrs12.Radius = 4D;
			this.FTrs12.Text = "F";
			this.FTrs12.TextColor = new NxtControl.Drawing.Color("ButtonTextColor");
			this.FTrs12.TextColorMouseDown = new NxtControl.Drawing.Color("ButtonTextColorMouseDown");
			this.FTrs12.Use3DEffect = false;
			this.FTrs12.Click += new System.EventHandler(this.FTrs12Click);
			// 
			// ActivateForce
			// 
			this.ActivateForce.Bounds = new NxtControl.Drawing.RectF(((float)(736D)), ((float)(184D)), ((float)(80D)), ((float)(25D)));
			this.ActivateForce.DrawStyle = NxtControl.GuiFramework.TwoStateButton.ButtonDrawStyle.Switch;
			this.ActivateForce.FalseBrush = new NxtControl.Drawing.Brush("ButtonFalseBrush");
			this.ActivateForce.FalseText = "OFF";
			this.ActivateForce.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.ActivateForce.InnerBorderColor = new NxtControl.Drawing.Color("ButtonInnerBorderColor");
			this.ActivateForce.Name = "ActivateForce";
			this.ActivateForce.Pen = new NxtControl.Drawing.Pen("ButtonPen");
			this.ActivateForce.Radius = 8D;
			this.ActivateForce.TextColorFalse = new NxtControl.Drawing.Color("ButtonTextColorFalse");
			this.ActivateForce.TextColorTrue = new NxtControl.Drawing.Color("ButtonTextColorTrue");
			this.ActivateForce.TrueText = "ON";
			this.ActivateForce.Use3DEffect = false;
			this.ActivateForce.CheckedChanged += new System.EventHandler(this.ActivateForceCheckedChanged);
			// 
			// roundedRectangle1
			// 
			this.roundedRectangle1.Bounds = new NxtControl.Drawing.RectF(((float)(544D)), ((float)(176D)), ((float)(280D)), ((float)(40D)));
			this.roundedRectangle1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(210)), ((byte)(210)), ((byte)(210))));
			this.roundedRectangle1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.roundedRectangle1.Name = "roundedRectangle1";
			// 
			// roundedRectangle4
			// 
			this.roundedRectangle4.Bounds = new NxtControl.Drawing.RectF(((float)(552D)), ((float)(184D)), ((float)(176D)), ((float)(24D)));
			this.roundedRectangle4.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(240)), ((byte)(240)), ((byte)(240))));
			this.roundedRectangle4.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
			this.roundedRectangle4.Name = "roundedRectangle4";
			this.roundedRectangle4.Text = "Enable Forced Transitions";
			this.roundedRectangle4.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			// 
			// group1
			// 
			this.group1.BeginInit();
			this.group1.Name = "group1";
			this.group1.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.roundedRectangle1,
			this.roundedRectangle4,
			this.ActivateForce,
			this.roundedRectangle3,
			this.PhaseName,
			this.roundedRectangle2,
			this.ManStart,
			this.ManStop,
			this.ManReset,
			this.freeText13,
			this.NoActionAllowed});
			this.group1.EndInit();
			// 
			// ToReady3
			// 
			this.ToReady3.EndPoint = new NxtControl.Drawing.PointF(104D, 56D);
			this.ToReady3.Name = "ToReady3";
			this.ToReady3.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 3F, NxtControl.Drawing.DashStyle.Solid);
			this.ToReady3.StartPoint = new NxtControl.Drawing.PointF(104D, 16D);
			// 
			// Ready2Starting
			// 
			this.Ready2Starting.EndPoint = new NxtControl.Drawing.PointF(104D, 176D);
			this.Ready2Starting.Name = "Ready2Starting";
			this.Ready2Starting.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 3F, NxtControl.Drawing.DashStyle.Solid);
			this.Ready2Starting.StartPoint = new NxtControl.Drawing.PointF(104D, 88D);
			// 
			// Starting2Run
			// 
			this.Starting2Run.EndPoint = new NxtControl.Drawing.PointF(104D, 264D);
			this.Starting2Run.Name = "Starting2Run";
			this.Starting2Run.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 3F, NxtControl.Drawing.DashStyle.Solid);
			this.Starting2Run.StartPoint = new NxtControl.Drawing.PointF(104D, 176D);
			// 
			// Run2Stopping
			// 
			this.Run2Stopping.EndPoint = new NxtControl.Drawing.PointF(104D, 352D);
			this.Run2Stopping.Name = "Run2Stopping";
			this.Run2Stopping.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 3F, NxtControl.Drawing.DashStyle.Solid);
			this.Run2Stopping.StartPoint = new NxtControl.Drawing.PointF(104D, 264D);
			// 
			// Stopping2Ready1
			// 
			this.Stopping2Ready1.EndPoint = new NxtControl.Drawing.PointF(104D, 664D);
			this.Stopping2Ready1.Name = "Stopping2Ready1";
			this.Stopping2Ready1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 3F, NxtControl.Drawing.DashStyle.Solid);
			this.Stopping2Ready1.StartPoint = new NxtControl.Drawing.PointF(104D, 352D);
			// 
			// ToAborting3
			// 
			this.ToAborting3.EndPoint = new NxtControl.Drawing.PointF(328D, 384D);
			this.ToAborting3.Name = "ToAborting3";
			this.ToAborting3.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 3F, NxtControl.Drawing.DashStyle.Solid);
			this.ToAborting3.StartPoint = new NxtControl.Drawing.PointF(328D, 352D);
			// 
			// ToAborting1
			// 
			this.ToAborting1.EndPoint = new NxtControl.Drawing.PointF(328D, 264D);
			this.ToAborting1.Name = "ToAborting1";
			this.ToAborting1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 3F, NxtControl.Drawing.DashStyle.Solid);
			this.ToAborting1.StartPoint = new NxtControl.Drawing.PointF(328D, 176D);
			// 
			// Aborted2Ready
			// 
			this.Aborted2Ready.EndPoint = new NxtControl.Drawing.PointF(328D, 664D);
			this.Aborted2Ready.Name = "Aborted2Ready";
			this.Aborted2Ready.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 3F, NxtControl.Drawing.DashStyle.Solid);
			this.Aborted2Ready.StartPoint = new NxtControl.Drawing.PointF(328D, 504D);
			// 
			// Interlocked2Ready1
			// 
			this.Interlocked2Ready1.EndPoint = new NxtControl.Drawing.PointF(528D, 664D);
			this.Interlocked2Ready1.Name = "Interlocked2Ready1";
			this.Interlocked2Ready1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 3F, NxtControl.Drawing.DashStyle.Solid);
			this.Interlocked2Ready1.StartPoint = new NxtControl.Drawing.PointF(528D, 576D);
			// 
			// IlckAborted2Ready
			// 
			this.IlckAborted2Ready.EndPoint = new NxtControl.Drawing.PointF(328D, 664D);
			this.IlckAborted2Ready.Name = "IlckAborted2Ready";
			this.IlckAborted2Ready.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 3F, NxtControl.Drawing.DashStyle.Solid);
			this.IlckAborted2Ready.StartPoint = new NxtControl.Drawing.PointF(104D, 664D);
			// 
			// Stopping2Ready2
			// 
			this.Stopping2Ready2.EndPoint = new NxtControl.Drawing.PointF(104D, 664D);
			this.Stopping2Ready2.Name = "Stopping2Ready2";
			this.Stopping2Ready2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 3F, NxtControl.Drawing.DashStyle.Solid);
			this.Stopping2Ready2.StartPoint = new NxtControl.Drawing.PointF(16D, 664D);
			// 
			// Aborting2Aborted
			// 
			this.Aborting2Aborted.EndPoint = new NxtControl.Drawing.PointF(328D, 504D);
			this.Aborting2Aborted.Name = "Aborting2Aborted";
			this.Aborting2Aborted.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 3F, NxtControl.Drawing.DashStyle.Solid);
			this.Aborting2Aborted.StartPoint = new NxtControl.Drawing.PointF(328D, 408D);
			// 
			// ReadyAborted2Interlocked2
			// 
			this.ReadyAborted2Interlocked2.EndPoint = new NxtControl.Drawing.PointF(528D, 568D);
			this.ReadyAborted2Interlocked2.Name = "ReadyAborted2Interlocked2";
			this.ReadyAborted2Interlocked2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 3F, NxtControl.Drawing.DashStyle.Solid);
			this.ReadyAborted2Interlocked2.StartPoint = new NxtControl.Drawing.PointF(528D, 504D);
			// 
			// FromReady
			// 
			this.FromReady.EndPoint = new NxtControl.Drawing.PointF(104D, 88D);
			this.FromReady.Name = "FromReady";
			this.FromReady.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 3F, NxtControl.Drawing.DashStyle.Solid);
			this.FromReady.StartPoint = new NxtControl.Drawing.PointF(104D, 64D);
			// 
			// ToAborting2
			// 
			this.ToAborting2.EndPoint = new NxtControl.Drawing.PointF(328D, 352D);
			this.ToAborting2.Name = "ToAborting2";
			this.ToAborting2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 3F, NxtControl.Drawing.DashStyle.Solid);
			this.ToAborting2.StartPoint = new NxtControl.Drawing.PointF(328D, 264D);
			// 
			// fpDefault
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(832D)), ((float)(680D)));
			this.Brush = new NxtControl.Drawing.Brush("FaceplateBrush");
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.IlckAborted2Ready,
			this.FromReady,
			this.ReadyAborted2Interlocked2,
			this.Aborting2Aborted,
			this.Interlocked2Ready1,
			this.Aborted2Ready,
			this.Stopping2Ready1,
			this.Run2Stopping,
			this.Starting2Run,
			this.Ready2Starting,
			this.ToReady3,
			this.group1,
			this.FTrs1,
			this.FTrs2,
			this.FTrs3,
			this.FTrs4,
			this.FTrs5,
			this.FTrs6,
			this.FTrs7,
			this.FTrs8,
			this.FTrs9,
			this.Ready2Ilck2,
			this.State1,
			this.State2,
			this.State3,
			this.line2,
			this.freeText1,
			this.line3,
			this.freeText2,
			this.line4,
			this.freeText3,
			this.line5,
			this.freeText4,
			this.Ready2Ilck1,
			this.State5,
			this.line7,
			this.freeText5,
			this.Starting2Abort,
			this.State6,
			this.line10,
			this.line11,
			this.freeText6,
			this.freeText7,
			this.Run2Abort,
			this.line13,
			this.freeText8,
			this.Stopping2Abort,
			this.line15,
			this.freeText9,
			this.line16,
			this.freeText10,
			this.Aborted2Interlocked1,
			this.line18,
			this.freeText11,
			this.line20,
			this.freeText12,
			this.Interlocked2Ready2,
			this.ToReady1,
			this.ToReady2,
			this.polygon1,
			this.polygon2,
			this.polygon3,
			this.polygon4,
			this.polygon5,
			this.polygon6,
			this.polygon7,
			this.polygon8,
			this.polygon9,
			this.polygon10,
			this.FTrs10,
			this.FTrs11,
			this.FTrs12,
			this.ToAborting1,
			this.ToAborting3,
			this.State4,
			this.State0,
			this.Stopping2Ready2,
			this.ToAborting2});
			this.Size = new System.Drawing.Size(832, 680);
			this.Title = "Phase Status";

		}
		private NxtControl.GuiFramework.RoundedRectangle State0;
		private NxtControl.GuiFramework.RoundedRectangle State1;
		private NxtControl.GuiFramework.RoundedRectangle State2;
		private NxtControl.GuiFramework.RoundedRectangle State3;
		private NxtControl.GuiFramework.Line ToReady3;
		private NxtControl.GuiFramework.Line line2;
		private NxtControl.GuiFramework.FreeText freeText1;
		private NxtControl.GuiFramework.Line line3;
		private NxtControl.GuiFramework.FreeText freeText2;
		private NxtControl.GuiFramework.Line line4;
		private NxtControl.GuiFramework.FreeText freeText3;
		private NxtControl.GuiFramework.Line line5;
		private NxtControl.GuiFramework.FreeText freeText4;
		private NxtControl.GuiFramework.Line Ready2Ilck1;
		private NxtControl.GuiFramework.RoundedRectangle State4;
		private NxtControl.GuiFramework.RoundedRectangle State5;
		private NxtControl.GuiFramework.Line line7;
		private NxtControl.GuiFramework.FreeText freeText5;
		private NxtControl.GuiFramework.Line Ready2Starting;
		private NxtControl.GuiFramework.Line Starting2Abort;
		private NxtControl.GuiFramework.RoundedRectangle State6;
		private NxtControl.GuiFramework.Line line10;
		private NxtControl.GuiFramework.Line line11;
		private NxtControl.GuiFramework.FreeText freeText6;
		private NxtControl.GuiFramework.FreeText freeText7;
		private NxtControl.GuiFramework.Line Run2Abort;
		private NxtControl.GuiFramework.Line line13;
		private NxtControl.GuiFramework.FreeText freeText8;
		private NxtControl.GuiFramework.Line Stopping2Abort;
		private NxtControl.GuiFramework.Line line15;
		private NxtControl.GuiFramework.FreeText freeText9;
		private NxtControl.GuiFramework.Line line16;
		private NxtControl.GuiFramework.FreeText freeText10;
		private NxtControl.GuiFramework.Line Aborted2Interlocked1;
		private NxtControl.GuiFramework.Line line18;
		private NxtControl.GuiFramework.FreeText freeText11;
		private NxtControl.GuiFramework.Line Ready2Ilck2;
		private NxtControl.GuiFramework.Line line20;
		private NxtControl.GuiFramework.FreeText freeText12;
		private NxtControl.GuiFramework.Line Interlocked2Ready2;
		private NxtControl.GuiFramework.Line ToReady1;
		private NxtControl.GuiFramework.Line ToReady2;
		private NxtControl.GuiFramework.Polygon polygon1;
		private NxtControl.GuiFramework.Polygon polygon2;
		private NxtControl.GuiFramework.Polygon polygon3;
		private NxtControl.GuiFramework.Polygon polygon4;
		private NxtControl.GuiFramework.Polygon polygon5;
		private NxtControl.GuiFramework.Polygon polygon6;
		private NxtControl.GuiFramework.Polygon polygon7;
		private NxtControl.GuiFramework.Polygon polygon8;
		private NxtControl.GuiFramework.Polygon polygon9;
		private NxtControl.GuiFramework.Polygon polygon10;
		private NxtControl.GuiFramework.RoundedRectangle PhaseName;
		private NxtControl.GuiFramework.RoundedRectangle roundedRectangle2;
		private NxtControl.GuiFramework.RoundedRectangle roundedRectangle3;
		private NxtControl.GuiFramework.DrawnButton ManStart;
		private NxtControl.GuiFramework.DrawnButton ManStop;
		private NxtControl.GuiFramework.DrawnButton ManReset;
		private NxtControl.GuiFramework.FreeText freeText13;
		private NxtControl.GuiFramework.FreeText NoActionAllowed;
		private NxtControl.GuiFramework.DrawnButton FTrs1;
		private NxtControl.GuiFramework.DrawnButton FTrs2;
		private NxtControl.GuiFramework.DrawnButton FTrs3;
		private NxtControl.GuiFramework.DrawnButton FTrs4;
		private NxtControl.GuiFramework.DrawnButton FTrs5;
		private NxtControl.GuiFramework.DrawnButton FTrs6;
		private NxtControl.GuiFramework.DrawnButton FTrs7;
		private NxtControl.GuiFramework.DrawnButton FTrs8;
		private NxtControl.GuiFramework.DrawnButton FTrs9;
		private NxtControl.GuiFramework.DrawnButton FTrs10;
		private NxtControl.GuiFramework.DrawnButton FTrs11;
		private NxtControl.GuiFramework.DrawnButton FTrs12;
		private NxtControl.GuiFramework.TwoStateButton ActivateForce;
		private NxtControl.GuiFramework.RoundedRectangle roundedRectangle1;
		private NxtControl.GuiFramework.RoundedRectangle roundedRectangle4;
		private NxtControl.GuiFramework.Group group1;
		private NxtControl.GuiFramework.Line Starting2Run;
		private NxtControl.GuiFramework.Line Run2Stopping;
		private NxtControl.GuiFramework.Line Stopping2Ready1;
		private NxtControl.GuiFramework.Line ToAborting3;
		private NxtControl.GuiFramework.Line ToAborting1;
		private NxtControl.GuiFramework.Line Aborted2Ready;
		private NxtControl.GuiFramework.Line Interlocked2Ready1;
		private NxtControl.GuiFramework.Line IlckAborted2Ready;
		private NxtControl.GuiFramework.Line Stopping2Ready2;
		private NxtControl.GuiFramework.Line Aborting2Aborted;
		private NxtControl.GuiFramework.Line ReadyAborted2Interlocked2;
		private NxtControl.GuiFramework.Line FromReady;
		private NxtControl.GuiFramework.Line ToAborting2;
		#endregion
	}
}
