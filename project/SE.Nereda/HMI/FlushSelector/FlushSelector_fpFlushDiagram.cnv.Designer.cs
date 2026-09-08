/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 6/23/2026
 * Time: 3:49 PM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using NxtControl.GuiFramework;

namespace SE.Nereda.Faceplates.FlushSelector
{
	/// <summary>
	/// Summary description for fpFlushDiagram.
	/// </summary>
	partial class fpFlushDiagram
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.line1 = new NxtControl.GuiFramework.Line();
			this.State1 = new NxtControl.GuiFramework.Rectangle();
			this.State2 = new NxtControl.GuiFramework.Rectangle();
			this.State3 = new NxtControl.GuiFramework.Rectangle();
			this.State4 = new NxtControl.GuiFramework.Rectangle();
			this.State9 = new NxtControl.GuiFramework.Rectangle();
			this.line2 = new NxtControl.GuiFramework.Line();
			this.line3 = new NxtControl.GuiFramework.Line();
			this.line4 = new NxtControl.GuiFramework.Line();
			this.line5 = new NxtControl.GuiFramework.Line();
			this.line6 = new NxtControl.GuiFramework.Line();
			this.freeText1 = new NxtControl.GuiFramework.FreeText();
			this.freeText2 = new NxtControl.GuiFramework.FreeText();
			this.freeText3 = new NxtControl.GuiFramework.FreeText();
			this.freeText5 = new NxtControl.GuiFramework.FreeText();
			this.line21 = new NxtControl.GuiFramework.Line();
			this.line22 = new NxtControl.GuiFramework.Line();
			this.freeText15 = new NxtControl.GuiFramework.FreeText();
			this.freeText17 = new NxtControl.GuiFramework.FreeText();
			this.freeText19 = new NxtControl.GuiFramework.FreeText();
			this.polygon1 = new NxtControl.GuiFramework.Polygon();
			this.freeText6 = new NxtControl.GuiFramework.FreeText();
			this.State5 = new NxtControl.GuiFramework.Rectangle();
			this.State6 = new NxtControl.GuiFramework.Rectangle();
			this.line7 = new NxtControl.GuiFramework.Line();
			this.line8 = new NxtControl.GuiFramework.Line();
			this.freeText8 = new NxtControl.GuiFramework.FreeText();
			this.freeText9 = new NxtControl.GuiFramework.FreeText();
			this.freeText11 = new NxtControl.GuiFramework.FreeText();
			this.freeText7 = new NxtControl.GuiFramework.FreeText();
			this.freeText10 = new NxtControl.GuiFramework.FreeText();
			this.State7 = new NxtControl.GuiFramework.Rectangle();
			this.State8 = new NxtControl.GuiFramework.Rectangle();
			this.line9 = new NxtControl.GuiFramework.Line();
			this.line10 = new NxtControl.GuiFramework.Line();
			this.freeText13 = new NxtControl.GuiFramework.FreeText();
			this.freeText14 = new NxtControl.GuiFramework.FreeText();
			this.freeText18 = new NxtControl.GuiFramework.FreeText();
			this.freeText12 = new NxtControl.GuiFramework.FreeText();
			this.freeText20 = new NxtControl.GuiFramework.FreeText();
			this.freeText4 = new NxtControl.GuiFramework.FreeText();
			this.line11 = new NxtControl.GuiFramework.Line();
			this.line12 = new NxtControl.GuiFramework.Line();
			this.freeText16 = new NxtControl.GuiFramework.FreeText();
			this.line13 = new NxtControl.GuiFramework.Line();
			this.line14 = new NxtControl.GuiFramework.Line();
			this.polygon2 = new NxtControl.GuiFramework.Polygon();
			// 
			// line1
			// 
			this.line1.EndPoint = new NxtControl.Drawing.PointF(112D, 608D);
			this.line1.Name = "line1";
			this.line1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.line1.StartPoint = new NxtControl.Drawing.PointF(112D, 16D);
			// 
			// State1
			// 
			this.State1.Bounds = new NxtControl.Drawing.RectF(((float)(96D)), ((float)(96D)), ((float)(32D)), ((float)(32D)));
			this.State1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(154)), ((byte)(154)), ((byte)(154))));
			this.State1.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.State1.Name = "State1";
			this.State1.Text = "1";
			this.State1.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			// 
			// State2
			// 
			this.State2.Bounds = new NxtControl.Drawing.RectF(((float)(96D)), ((float)(176D)), ((float)(32D)), ((float)(32D)));
			this.State2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(154)), ((byte)(154)), ((byte)(154))));
			this.State2.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.State2.Name = "State2";
			this.State2.Text = "2";
			this.State2.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			// 
			// State3
			// 
			this.State3.Bounds = new NxtControl.Drawing.RectF(((float)(96D)), ((float)(240D)), ((float)(32D)), ((float)(32D)));
			this.State3.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(154)), ((byte)(154)), ((byte)(154))));
			this.State3.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.State3.Name = "State3";
			this.State3.Text = "3";
			this.State3.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			// 
			// State4
			// 
			this.State4.Bounds = new NxtControl.Drawing.RectF(((float)(96D)), ((float)(304D)), ((float)(32D)), ((float)(32D)));
			this.State4.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(154)), ((byte)(154)), ((byte)(154))));
			this.State4.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.State4.Name = "State4";
			this.State4.Text = "4";
			this.State4.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			// 
			// State9
			// 
			this.State9.Bounds = new NxtControl.Drawing.RectF(((float)(96D)), ((float)(32D)), ((float)(32D)), ((float)(32D)));
			this.State9.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(154)), ((byte)(154)), ((byte)(154))));
			this.State9.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.State9.Name = "State9";
			this.State9.Text = "0";
			this.State9.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			// 
			// line2
			// 
			this.line2.EndPoint = new NxtControl.Drawing.PointF(120D, 144D);
			this.line2.Name = "line2";
			this.line2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.line2.StartPoint = new NxtControl.Drawing.PointF(104D, 144D);
			// 
			// line3
			// 
			this.line3.EndPoint = new NxtControl.Drawing.PointF(120D, 224D);
			this.line3.Name = "line3";
			this.line3.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.line3.StartPoint = new NxtControl.Drawing.PointF(104D, 224D);
			// 
			// line4
			// 
			this.line4.EndPoint = new NxtControl.Drawing.PointF(120D, 288D);
			this.line4.Name = "line4";
			this.line4.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.line4.StartPoint = new NxtControl.Drawing.PointF(104D, 288D);
			// 
			// line5
			// 
			this.line5.EndPoint = new NxtControl.Drawing.PointF(120D, 352D);
			this.line5.Name = "line5";
			this.line5.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.line5.StartPoint = new NxtControl.Drawing.PointF(104D, 352D);
			// 
			// line6
			// 
			this.line6.EndPoint = new NxtControl.Drawing.PointF(120D, 80D);
			this.line6.Name = "line6";
			this.line6.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.line6.StartPoint = new NxtControl.Drawing.PointF(104D, 80D);
			// 
			// freeText1
			// 
			this.freeText1.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(114)), ((byte)(188)));
			this.freeText1.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText1.Location = new NxtControl.Drawing.PointF(128D, 136D);
			this.freeText1.Name = "freeText1";
			this.freeText1.Text = "Fb Started & Opened";
			// 
			// freeText2
			// 
			this.freeText2.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(114)), ((byte)(188)));
			this.freeText2.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText2.Location = new NxtControl.Drawing.PointF(128D, 280D);
			this.freeText2.Name = "freeText2";
			this.freeText2.Text = "Flushing Started";
			// 
			// freeText3
			// 
			this.freeText3.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(114)), ((byte)(188)));
			this.freeText3.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText3.Location = new NxtControl.Drawing.PointF(128D, 216D);
			this.freeText3.Name = "freeText3";
			this.freeText3.Text = "Fb Speed Reduced";
			// 
			// freeText5
			// 
			this.freeText5.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(114)), ((byte)(188)));
			this.freeText5.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText5.Location = new NxtControl.Drawing.PointF(128D, 72D);
			this.freeText5.Name = "freeText5";
			this.freeText5.Text = "Flush Ready";
			// 
			// line21
			// 
			this.line21.EndPoint = new NxtControl.Drawing.PointF(16D, 608D);
			this.line21.Name = "line21";
			this.line21.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.line21.StartPoint = new NxtControl.Drawing.PointF(16D, 16D);
			// 
			// line22
			// 
			this.line22.EndPoint = new NxtControl.Drawing.PointF(112D, 16D);
			this.line22.Name = "line22";
			this.line22.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.line22.StartPoint = new NxtControl.Drawing.PointF(16D, 16D);
			// 
			// freeText15
			// 
			this.freeText15.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText15.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText15.Location = new NxtControl.Drawing.PointF(136D, 96D);
			this.freeText15.Name = "freeText15";
			this.freeText15.Text = "Start Pump ctp 002";
			// 
			// freeText17
			// 
			this.freeText17.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText17.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText17.Location = new NxtControl.Drawing.PointF(136D, 176D);
			this.freeText17.Name = "freeText17";
			this.freeText17.Text = "Reduce Speed";
			// 
			// freeText19
			// 
			this.freeText19.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText19.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText19.Location = new NxtControl.Drawing.PointF(136D, 32D);
			this.freeText19.Name = "freeText19";
			this.freeText19.Text = "Flushing OFF";
			// 
			// polygon1
			// 
			this.polygon1.Bounds = new NxtControl.Drawing.RectF(((float)(11D)), ((float)(300D)), ((float)(10D)), ((float)(24D)));
			this.polygon1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			this.polygon1.Closed = true;
			this.polygon1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.polygon1.Name = "polygon1";
			this.polygon1.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(16D, 300D),
			new NxtControl.Drawing.PointF(11D, 324D),
			new NxtControl.Drawing.PointF(21D, 324D)});
			// 
			// freeText6
			// 
			this.freeText6.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText6.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText6.Location = new NxtControl.Drawing.PointF(136D, 112D);
			this.freeText6.Name = "freeText6";
			this.freeText6.Text = "Open Valve 011 & 014";
			// 
			// State5
			// 
			this.State5.Bounds = new NxtControl.Drawing.RectF(((float)(96D)), ((float)(368D)), ((float)(32D)), ((float)(32D)));
			this.State5.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(154)), ((byte)(154)), ((byte)(154))));
			this.State5.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.State5.Name = "State5";
			this.State5.Text = "5";
			this.State5.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			// 
			// State6
			// 
			this.State6.Bounds = new NxtControl.Drawing.RectF(((float)(96D)), ((float)(432D)), ((float)(32D)), ((float)(32D)));
			this.State6.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(154)), ((byte)(154)), ((byte)(154))));
			this.State6.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.State6.Name = "State6";
			this.State6.Text = "6";
			this.State6.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			// 
			// line7
			// 
			this.line7.EndPoint = new NxtControl.Drawing.PointF(120D, 416D);
			this.line7.Name = "line7";
			this.line7.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.line7.StartPoint = new NxtControl.Drawing.PointF(104D, 416D);
			// 
			// line8
			// 
			this.line8.EndPoint = new NxtControl.Drawing.PointF(120D, 480D);
			this.line8.Name = "line8";
			this.line8.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.line8.StartPoint = new NxtControl.Drawing.PointF(104D, 480D);
			// 
			// freeText8
			// 
			this.freeText8.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(114)), ((byte)(188)));
			this.freeText8.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText8.Location = new NxtControl.Drawing.PointF(128D, 408D);
			this.freeText8.Name = "freeText8";
			this.freeText8.Text = "Cmd Open Valve 014";
			// 
			// freeText9
			// 
			this.freeText9.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(114)), ((byte)(188)));
			this.freeText9.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText9.Location = new NxtControl.Drawing.PointF(128D, 344D);
			this.freeText9.Name = "freeText9";
			this.freeText9.Text = "Fb Closed";
			// 
			// freeText11
			// 
			this.freeText11.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText11.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText11.Location = new NxtControl.Drawing.PointF(136D, 368D);
			this.freeText11.Name = "freeText11";
			this.freeText11.Text = "Speed Max";
			// 
			// freeText7
			// 
			this.freeText7.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText7.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText7.Location = new NxtControl.Drawing.PointF(136D, 304D);
			this.freeText7.Name = "freeText7";
			this.freeText7.Text = "Close Valve 014";
			// 
			// freeText10
			// 
			this.freeText10.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(114)), ((byte)(188)));
			this.freeText10.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText10.Location = new NxtControl.Drawing.PointF(24D, 584D);
			this.freeText10.Name = "freeText10";
			this.freeText10.Text = "Flush OFF";
			// 
			// State7
			// 
			this.State7.Bounds = new NxtControl.Drawing.RectF(((float)(96D)), ((float)(496D)), ((float)(32D)), ((float)(32D)));
			this.State7.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(154)), ((byte)(154)), ((byte)(154))));
			this.State7.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.State7.Name = "State7";
			this.State7.Text = "7";
			this.State7.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			// 
			// State8
			// 
			this.State8.Bounds = new NxtControl.Drawing.RectF(((float)(96D)), ((float)(560D)), ((float)(32D)), ((float)(32D)));
			this.State8.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(154)), ((byte)(154)), ((byte)(154))));
			this.State8.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.State8.Name = "State8";
			this.State8.Text = "8";
			this.State8.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			// 
			// line9
			// 
			this.line9.EndPoint = new NxtControl.Drawing.PointF(120D, 544D);
			this.line9.Name = "line9";
			this.line9.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.line9.StartPoint = new NxtControl.Drawing.PointF(104D, 544D);
			// 
			// line10
			// 
			this.line10.EndPoint = new NxtControl.Drawing.PointF(48D, 600D);
			this.line10.Name = "line10";
			this.line10.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.line10.StartPoint = new NxtControl.Drawing.PointF(48D, 616D);
			// 
			// freeText13
			// 
			this.freeText13.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(114)), ((byte)(188)));
			this.freeText13.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText13.Location = new NxtControl.Drawing.PointF(128D, 536D);
			this.freeText13.Name = "freeText13";
			this.freeText13.Text = "Fb Opened";
			// 
			// freeText14
			// 
			this.freeText14.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText14.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText14.Location = new NxtControl.Drawing.PointF(136D, 496D);
			this.freeText14.Name = "freeText14";
			this.freeText14.Text = "Open Valve 014";
			// 
			// freeText18
			// 
			this.freeText18.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText18.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText18.Location = new NxtControl.Drawing.PointF(136D, 240D);
			this.freeText18.Name = "freeText18";
			this.freeText18.Text = "Start Flushing";
			// 
			// freeText12
			// 
			this.freeText12.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText12.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText12.Location = new NxtControl.Drawing.PointF(136D, 432D);
			this.freeText12.Name = "freeText12";
			this.freeText12.Text = "Reduce Speed";
			// 
			// freeText20
			// 
			this.freeText20.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(114)), ((byte)(188)));
			this.freeText20.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText20.Location = new NxtControl.Drawing.PointF(128D, 472D);
			this.freeText20.Name = "freeText20";
			this.freeText20.Text = "Fb Speed Reduced";
			// 
			// freeText4
			// 
			this.freeText4.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText4.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText4.Location = new NxtControl.Drawing.PointF(136D, 560D);
			this.freeText4.Name = "freeText4";
			this.freeText4.Text = "Speed Max";
			// 
			// line11
			// 
			this.line11.EndPoint = new NxtControl.Drawing.PointF(288D, 608D);
			this.line11.Name = "line11";
			this.line11.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.line11.StartPoint = new NxtControl.Drawing.PointF(16D, 608D);
			// 
			// line12
			// 
			this.line12.EndPoint = new NxtControl.Drawing.PointF(240D, 616D);
			this.line12.Name = "line12";
			this.line12.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.line12.StartPoint = new NxtControl.Drawing.PointF(240D, 600D);
			// 
			// freeText16
			// 
			this.freeText16.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(114)), ((byte)(188)));
			this.freeText16.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText16.Location = new NxtControl.Drawing.PointF(200D, 584D);
			this.freeText16.Name = "freeText16";
			this.freeText16.Text = "Flush Request";
			// 
			// line13
			// 
			this.line13.EndPoint = new NxtControl.Drawing.PointF(288D, 608D);
			this.line13.Name = "line13";
			this.line13.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.line13.StartPoint = new NxtControl.Drawing.PointF(288D, 160D);
			// 
			// line14
			// 
			this.line14.EndPoint = new NxtControl.Drawing.PointF(288D, 160D);
			this.line14.Name = "line14";
			this.line14.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.line14.StartPoint = new NxtControl.Drawing.PointF(112D, 160D);
			// 
			// polygon2
			// 
			this.polygon2.Bounds = new NxtControl.Drawing.RectF(((float)(283D)), ((float)(372D)), ((float)(10D)), ((float)(24D)));
			this.polygon2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			this.polygon2.Closed = true;
			this.polygon2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.polygon2.Name = "polygon2";
			this.polygon2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(288D, 372D),
			new NxtControl.Drawing.PointF(283D, 396D),
			new NxtControl.Drawing.PointF(293D, 396D)});
			// 
			// fpFlushDiagram
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(304D)), ((float)(624D)));
			this.Brush = new NxtControl.Drawing.Brush("FaceplateBrush");
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.line1,
			this.State1,
			this.State2,
			this.State3,
			this.State4,
			this.State9,
			this.line2,
			this.line3,
			this.line4,
			this.line5,
			this.line6,
			this.freeText1,
			this.freeText2,
			this.freeText3,
			this.freeText5,
			this.line21,
			this.line22,
			this.freeText15,
			this.freeText17,
			this.freeText19,
			this.polygon1,
			this.freeText6,
			this.State5,
			this.State6,
			this.line7,
			this.line8,
			this.freeText8,
			this.freeText9,
			this.freeText11,
			this.freeText7,
			this.freeText10,
			this.State7,
			this.State8,
			this.line9,
			this.line10,
			this.freeText13,
			this.freeText14,
			this.freeText18,
			this.freeText12,
			this.freeText20,
			this.freeText4,
			this.line11,
			this.line12,
			this.freeText16,
			this.line13,
			this.line14,
			this.polygon2});
			this.Size = new System.Drawing.Size(304, 624);
			this.Title = "Flushing Diagram";

		}
		private NxtControl.GuiFramework.Line line1;
		private NxtControl.GuiFramework.Rectangle State1;
		private NxtControl.GuiFramework.Rectangle State2;
		private NxtControl.GuiFramework.Rectangle State3;
		private NxtControl.GuiFramework.Rectangle State4;
		private NxtControl.GuiFramework.Rectangle State9;
		private NxtControl.GuiFramework.Line line2;
		private NxtControl.GuiFramework.Line line3;
		private NxtControl.GuiFramework.Line line4;
		private NxtControl.GuiFramework.Line line5;
		private NxtControl.GuiFramework.Line line6;
		private NxtControl.GuiFramework.FreeText freeText1;
		private NxtControl.GuiFramework.FreeText freeText2;
		private NxtControl.GuiFramework.FreeText freeText3;
		private NxtControl.GuiFramework.FreeText freeText5;
		private NxtControl.GuiFramework.Line line21;
		private NxtControl.GuiFramework.Line line22;
		private NxtControl.GuiFramework.FreeText freeText15;
		private NxtControl.GuiFramework.FreeText freeText17;
		private NxtControl.GuiFramework.FreeText freeText19;
		private NxtControl.GuiFramework.Polygon polygon1;
		private NxtControl.GuiFramework.FreeText freeText6;
		private NxtControl.GuiFramework.Rectangle State5;
		private NxtControl.GuiFramework.Rectangle State6;
		private NxtControl.GuiFramework.Line line7;
		private NxtControl.GuiFramework.Line line8;
		private NxtControl.GuiFramework.FreeText freeText8;
		private NxtControl.GuiFramework.FreeText freeText9;
		private NxtControl.GuiFramework.FreeText freeText11;
		private NxtControl.GuiFramework.FreeText freeText7;
		private NxtControl.GuiFramework.FreeText freeText10;
		private NxtControl.GuiFramework.Rectangle State7;
		private NxtControl.GuiFramework.Rectangle State8;
		private NxtControl.GuiFramework.Line line9;
		private NxtControl.GuiFramework.Line line10;
		private NxtControl.GuiFramework.FreeText freeText13;
		private NxtControl.GuiFramework.FreeText freeText14;
		private NxtControl.GuiFramework.FreeText freeText18;
		private NxtControl.GuiFramework.FreeText freeText12;
		private NxtControl.GuiFramework.FreeText freeText20;
		private NxtControl.GuiFramework.FreeText freeText4;
		private NxtControl.GuiFramework.Line line11;
		private NxtControl.GuiFramework.Line line12;
		private NxtControl.GuiFramework.FreeText freeText16;
		private NxtControl.GuiFramework.Line line13;
		private NxtControl.GuiFramework.Line line14;
		private NxtControl.GuiFramework.Polygon polygon2;
		#endregion
	}
}
