/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 6/19/2026
 * Time: 4:05 PM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using NxtControl.GuiFramework;

namespace SE.Nereda.Faceplates.FlushGritScreens
{
	/// <summary>
	/// Summary description for fpCtrl.
	/// </summary>
	partial class fpCtrl
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.line15 = new NxtControl.GuiFramework.Line();
			this.line1 = new NxtControl.GuiFramework.Line();
			this.State1 = new NxtControl.GuiFramework.Rectangle();
			this.State2 = new NxtControl.GuiFramework.Rectangle();
			this.State3 = new NxtControl.GuiFramework.Rectangle();
			this.State4 = new NxtControl.GuiFramework.Rectangle();
			this.State12 = new NxtControl.GuiFramework.Rectangle();
			this.line2 = new NxtControl.GuiFramework.Line();
			this.line3 = new NxtControl.GuiFramework.Line();
			this.line4 = new NxtControl.GuiFramework.Line();
			this.line5 = new NxtControl.GuiFramework.Line();
			this.line6 = new NxtControl.GuiFramework.Line();
			this.freeText1 = new NxtControl.GuiFramework.FreeText();
			this.freeText2 = new NxtControl.GuiFramework.FreeText();
			this.freeText3 = new NxtControl.GuiFramework.FreeText();
			this.freeText5 = new NxtControl.GuiFramework.FreeText();
			this.line20 = new NxtControl.GuiFramework.Line();
			this.line21 = new NxtControl.GuiFramework.Line();
			this.line22 = new NxtControl.GuiFramework.Line();
			this.freeText17 = new NxtControl.GuiFramework.FreeText();
			this.freeText19 = new NxtControl.GuiFramework.FreeText();
			this.polygon1 = new NxtControl.GuiFramework.Polygon();
			this.DurationTime = new SE.Nereda.Symbols.E_DELAY_V_D.sDefault();
			this.CycleTime = new SE.Nereda.Symbols.E_DELAY_V_D.sDefault();
			this.State5 = new NxtControl.GuiFramework.Rectangle();
			this.State6 = new NxtControl.GuiFramework.Rectangle();
			this.line7 = new NxtControl.GuiFramework.Line();
			this.line8 = new NxtControl.GuiFramework.Line();
			this.freeText9 = new NxtControl.GuiFramework.FreeText();
			this.freeText11 = new NxtControl.GuiFramework.FreeText();
			this.State7 = new NxtControl.GuiFramework.Rectangle();
			this.State8 = new NxtControl.GuiFramework.Rectangle();
			this.line9 = new NxtControl.GuiFramework.Line();
			this.line10 = new NxtControl.GuiFramework.Line();
			this.line11 = new NxtControl.GuiFramework.Line();
			this.State9 = new NxtControl.GuiFramework.Rectangle();
			this.State10 = new NxtControl.GuiFramework.Rectangle();
			this.line12 = new NxtControl.GuiFramework.Line();
			this.line13 = new NxtControl.GuiFramework.Line();
			this.freeText6 = new NxtControl.GuiFramework.FreeText();
			this.freeText15 = new NxtControl.GuiFramework.FreeText();
			this.freeText22 = new NxtControl.GuiFramework.FreeText();
			this.freeText8 = new NxtControl.GuiFramework.FreeText();
			this.freeText23 = new NxtControl.GuiFramework.FreeText();
			this.freeText7 = new NxtControl.GuiFramework.FreeText();
			this.freeText24 = new NxtControl.GuiFramework.FreeText();
			this.freeText4 = new NxtControl.GuiFramework.FreeText();
			this.freeText10 = new NxtControl.GuiFramework.FreeText();
			this.freeText13 = new NxtControl.GuiFramework.FreeText();
			this.freeText14 = new NxtControl.GuiFramework.FreeText();
			this.freeText16 = new NxtControl.GuiFramework.FreeText();
			this.freeText18 = new NxtControl.GuiFramework.FreeText();
			this.State11 = new NxtControl.GuiFramework.Rectangle();
			this.line14 = new NxtControl.GuiFramework.Line();
			this.freeText21 = new NxtControl.GuiFramework.FreeText();
			this.freeText25 = new NxtControl.GuiFramework.FreeText();
			this.line16 = new NxtControl.GuiFramework.Line();
			this.line17 = new NxtControl.GuiFramework.Line();
			this.line18 = new NxtControl.GuiFramework.Line();
			this.polygon2 = new NxtControl.GuiFramework.Polygon();
			// 
			// line15
			// 
			this.line15.EndPoint = new NxtControl.Drawing.PointF(320D, 440D);
			this.line15.Name = "line15";
			this.line15.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.line15.StartPoint = new NxtControl.Drawing.PointF(320D, 16D);
			// 
			// line1
			// 
			this.line1.EndPoint = new NxtControl.Drawing.PointF(72D, 416D);
			this.line1.Name = "line1";
			this.line1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.line1.StartPoint = new NxtControl.Drawing.PointF(72D, 16D);
			// 
			// State1
			// 
			this.State1.Bounds = new NxtControl.Drawing.RectF(((float)(56D)), ((float)(96D)), ((float)(32D)), ((float)(32D)));
			this.State1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(154)), ((byte)(154)), ((byte)(154))));
			this.State1.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.State1.Name = "State1";
			this.State1.Text = "1";
			this.State1.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			// 
			// State2
			// 
			this.State2.Bounds = new NxtControl.Drawing.RectF(((float)(56D)), ((float)(160D)), ((float)(32D)), ((float)(32D)));
			this.State2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(154)), ((byte)(154)), ((byte)(154))));
			this.State2.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.State2.Name = "State2";
			this.State2.Text = "2";
			this.State2.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			// 
			// State3
			// 
			this.State3.Bounds = new NxtControl.Drawing.RectF(((float)(56D)), ((float)(224D)), ((float)(32D)), ((float)(32D)));
			this.State3.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(154)), ((byte)(154)), ((byte)(154))));
			this.State3.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.State3.Name = "State3";
			this.State3.Text = "3";
			this.State3.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			// 
			// State4
			// 
			this.State4.Bounds = new NxtControl.Drawing.RectF(((float)(56D)), ((float)(288D)), ((float)(32D)), ((float)(32D)));
			this.State4.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(154)), ((byte)(154)), ((byte)(154))));
			this.State4.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.State4.Name = "State4";
			this.State4.Text = "4";
			this.State4.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			// 
			// State12
			// 
			this.State12.Bounds = new NxtControl.Drawing.RectF(((float)(56D)), ((float)(32D)), ((float)(32D)), ((float)(32D)));
			this.State12.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(154)), ((byte)(154)), ((byte)(154))));
			this.State12.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.State12.Name = "State12";
			this.State12.Text = "0";
			this.State12.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			// 
			// line2
			// 
			this.line2.EndPoint = new NxtControl.Drawing.PointF(80D, 144D);
			this.line2.Name = "line2";
			this.line2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.line2.StartPoint = new NxtControl.Drawing.PointF(64D, 144D);
			// 
			// line3
			// 
			this.line3.EndPoint = new NxtControl.Drawing.PointF(80D, 208D);
			this.line3.Name = "line3";
			this.line3.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.line3.StartPoint = new NxtControl.Drawing.PointF(64D, 208D);
			// 
			// line4
			// 
			this.line4.EndPoint = new NxtControl.Drawing.PointF(80D, 272D);
			this.line4.Name = "line4";
			this.line4.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.line4.StartPoint = new NxtControl.Drawing.PointF(64D, 272D);
			// 
			// line5
			// 
			this.line5.EndPoint = new NxtControl.Drawing.PointF(80D, 336D);
			this.line5.Name = "line5";
			this.line5.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.line5.StartPoint = new NxtControl.Drawing.PointF(64D, 336D);
			// 
			// line6
			// 
			this.line6.EndPoint = new NxtControl.Drawing.PointF(80D, 80D);
			this.line6.Name = "line6";
			this.line6.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.line6.StartPoint = new NxtControl.Drawing.PointF(64D, 80D);
			// 
			// freeText1
			// 
			this.freeText1.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(114)), ((byte)(188)));
			this.freeText1.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText1.Location = new NxtControl.Drawing.PointF(88D, 136D);
			this.freeText1.Name = "freeText1";
			this.freeText1.Text = "Fb Flushing Pump Running";
			// 
			// freeText2
			// 
			this.freeText2.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(114)), ((byte)(188)));
			this.freeText2.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText2.Location = new NxtControl.Drawing.PointF(336D, 136D);
			this.freeText2.Name = "freeText2";
			this.freeText2.Text = "Duration Done";
			// 
			// freeText3
			// 
			this.freeText3.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(114)), ((byte)(188)));
			this.freeText3.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText3.Location = new NxtControl.Drawing.PointF(88D, 200D);
			this.freeText3.Name = "freeText3";
			this.freeText3.Text = "Fb Opened";
			// 
			// freeText5
			// 
			this.freeText5.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(114)), ((byte)(188)));
			this.freeText5.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText5.Location = new NxtControl.Drawing.PointF(88D, 72D);
			this.freeText5.Name = "freeText5";
			this.freeText5.Text = "Influent Feed Pump Stopped";
			// 
			// line20
			// 
			this.line20.EndPoint = new NxtControl.Drawing.PointF(320D, 440D);
			this.line20.Name = "line20";
			this.line20.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.line20.StartPoint = new NxtControl.Drawing.PointF(16D, 440D);
			// 
			// line21
			// 
			this.line21.EndPoint = new NxtControl.Drawing.PointF(16D, 440D);
			this.line21.Name = "line21";
			this.line21.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.line21.StartPoint = new NxtControl.Drawing.PointF(16D, 16D);
			// 
			// line22
			// 
			this.line22.EndPoint = new NxtControl.Drawing.PointF(72D, 16D);
			this.line22.Name = "line22";
			this.line22.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.line22.StartPoint = new NxtControl.Drawing.PointF(16D, 16D);
			// 
			// freeText17
			// 
			this.freeText17.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText17.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText17.Location = new NxtControl.Drawing.PointF(96D, 160D);
			this.freeText17.Name = "freeText17";
			this.freeText17.Text = "Open Valve 014";
			// 
			// freeText19
			// 
			this.freeText19.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText19.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText19.Location = new NxtControl.Drawing.PointF(96D, 16D);
			this.freeText19.Name = "freeText19";
			this.freeText19.Text = "Flushing OFF";
			// 
			// polygon1
			// 
			this.polygon1.Bounds = new NxtControl.Drawing.RectF(((float)(11D)), ((float)(172D)), ((float)(10D)), ((float)(24D)));
			this.polygon1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			this.polygon1.Closed = true;
			this.polygon1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.polygon1.Name = "polygon1";
			this.polygon1.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(16D, 172D),
			new NxtControl.Drawing.PointF(11D, 196D),
			new NxtControl.Drawing.PointF(21D, 196D)});
			// 
			// DurationTime
			// 
			this.DurationTime.BeginInit();
			this.DurationTime.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 344D, 96D);
			this.DurationTime.Name = "DurationTime";
			this.DurationTime.SecurityToken = ((uint)(4294967295u));
			this.DurationTime.TagName = "DurationTime";
			this.DurationTime.EndInit();
			// 
			// CycleTime
			// 
			this.CycleTime.BeginInit();
			this.CycleTime.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 96D, 32D);
			this.CycleTime.Name = "CycleTime";
			this.CycleTime.SecurityToken = ((uint)(4294967295u));
			this.CycleTime.TagName = "CycleTime";
			this.CycleTime.EndInit();
			// 
			// State5
			// 
			this.State5.Bounds = new NxtControl.Drawing.RectF(((float)(56D)), ((float)(352D)), ((float)(32D)), ((float)(32D)));
			this.State5.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(154)), ((byte)(154)), ((byte)(154))));
			this.State5.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.State5.Name = "State5";
			this.State5.Text = "5";
			this.State5.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			// 
			// State6
			// 
			this.State6.Bounds = new NxtControl.Drawing.RectF(((float)(304D)), ((float)(32D)), ((float)(32D)), ((float)(32D)));
			this.State6.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(154)), ((byte)(154)), ((byte)(154))));
			this.State6.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.State6.Name = "State6";
			this.State6.Text = "6";
			this.State6.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			// 
			// line7
			// 
			this.line7.EndPoint = new NxtControl.Drawing.PointF(80D, 400D);
			this.line7.Name = "line7";
			this.line7.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.line7.StartPoint = new NxtControl.Drawing.PointF(64D, 400D);
			// 
			// line8
			// 
			this.line8.EndPoint = new NxtControl.Drawing.PointF(328D, 80D);
			this.line8.Name = "line8";
			this.line8.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.line8.StartPoint = new NxtControl.Drawing.PointF(312D, 80D);
			// 
			// freeText9
			// 
			this.freeText9.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(114)), ((byte)(188)));
			this.freeText9.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText9.Location = new NxtControl.Drawing.PointF(88D, 328D);
			this.freeText9.Name = "freeText9";
			this.freeText9.Text = "Fb Opened";
			// 
			// freeText11
			// 
			this.freeText11.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText11.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText11.Location = new NxtControl.Drawing.PointF(96D, 288D);
			this.freeText11.Name = "freeText11";
			this.freeText11.Text = "Open Valve 012";
			// 
			// State7
			// 
			this.State7.Bounds = new NxtControl.Drawing.RectF(((float)(304D)), ((float)(96D)), ((float)(32D)), ((float)(32D)));
			this.State7.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(154)), ((byte)(154)), ((byte)(154))));
			this.State7.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.State7.Name = "State7";
			this.State7.Text = "7";
			this.State7.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			// 
			// State8
			// 
			this.State8.Bounds = new NxtControl.Drawing.RectF(((float)(304D)), ((float)(160D)), ((float)(32D)), ((float)(32D)));
			this.State8.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(154)), ((byte)(154)), ((byte)(154))));
			this.State8.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.State8.Name = "State8";
			this.State8.Text = "8";
			this.State8.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			// 
			// line9
			// 
			this.line9.EndPoint = new NxtControl.Drawing.PointF(328D, 80D);
			this.line9.Name = "line9";
			this.line9.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.line9.StartPoint = new NxtControl.Drawing.PointF(312D, 80D);
			// 
			// line10
			// 
			this.line10.EndPoint = new NxtControl.Drawing.PointF(328D, 144D);
			this.line10.Name = "line10";
			this.line10.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.line10.StartPoint = new NxtControl.Drawing.PointF(312D, 144D);
			// 
			// line11
			// 
			this.line11.EndPoint = new NxtControl.Drawing.PointF(328D, 208D);
			this.line11.Name = "line11";
			this.line11.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.line11.StartPoint = new NxtControl.Drawing.PointF(312D, 208D);
			// 
			// State9
			// 
			this.State9.Bounds = new NxtControl.Drawing.RectF(((float)(304D)), ((float)(224D)), ((float)(32D)), ((float)(32D)));
			this.State9.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(154)), ((byte)(154)), ((byte)(154))));
			this.State9.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.State9.Name = "State9";
			this.State9.Text = "9";
			this.State9.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			// 
			// State10
			// 
			this.State10.Bounds = new NxtControl.Drawing.RectF(((float)(304D)), ((float)(288D)), ((float)(32D)), ((float)(32D)));
			this.State10.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(154)), ((byte)(154)), ((byte)(154))));
			this.State10.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.State10.Name = "State10";
			this.State10.Text = "10";
			this.State10.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			// 
			// line12
			// 
			this.line12.EndPoint = new NxtControl.Drawing.PointF(328D, 272D);
			this.line12.Name = "line12";
			this.line12.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.line12.StartPoint = new NxtControl.Drawing.PointF(312D, 272D);
			// 
			// line13
			// 
			this.line13.EndPoint = new NxtControl.Drawing.PointF(328D, 336D);
			this.line13.Name = "line13";
			this.line13.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.line13.StartPoint = new NxtControl.Drawing.PointF(312D, 336D);
			// 
			// freeText6
			// 
			this.freeText6.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText6.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText6.Location = new NxtControl.Drawing.PointF(96D, 96D);
			this.freeText6.Name = "freeText6";
			this.freeText6.Text = "Start Flushing";
			// 
			// freeText15
			// 
			this.freeText15.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText15.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText15.Location = new NxtControl.Drawing.PointF(96D, 224D);
			this.freeText15.Name = "freeText15";
			this.freeText15.Text = "Reduce Speed";
			// 
			// freeText22
			// 
			this.freeText22.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(114)), ((byte)(188)));
			this.freeText22.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText22.Location = new NxtControl.Drawing.PointF(88D, 264D);
			this.freeText22.Name = "freeText22";
			this.freeText22.Text = "Speed Reduced";
			// 
			// freeText8
			// 
			this.freeText8.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(114)), ((byte)(188)));
			this.freeText8.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText8.Location = new NxtControl.Drawing.PointF(88D, 392D);
			this.freeText8.Name = "freeText8";
			this.freeText8.Text = "Fb Closed";
			// 
			// freeText23
			// 
			this.freeText23.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText23.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText23.Location = new NxtControl.Drawing.PointF(96D, 352D);
			this.freeText23.Name = "freeText23";
			this.freeText23.Text = "Close Valve 014";
			// 
			// freeText7
			// 
			this.freeText7.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText7.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText7.Location = new NxtControl.Drawing.PointF(344D, 32D);
			this.freeText7.Name = "freeText7";
			this.freeText7.Text = "Command Speed Max";
			// 
			// freeText24
			// 
			this.freeText24.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(114)), ((byte)(188)));
			this.freeText24.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText24.Location = new NxtControl.Drawing.PointF(336D, 72D);
			this.freeText24.Name = "freeText24";
			this.freeText24.Text = "Speed Max";
			// 
			// freeText4
			// 
			this.freeText4.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText4.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText4.Location = new NxtControl.Drawing.PointF(344D, 160D);
			this.freeText4.Name = "freeText4";
			this.freeText4.Text = "Reduce Speed";
			// 
			// freeText10
			// 
			this.freeText10.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(114)), ((byte)(188)));
			this.freeText10.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText10.Location = new NxtControl.Drawing.PointF(336D, 200D);
			this.freeText10.Name = "freeText10";
			this.freeText10.Text = "Speed Reduced";
			// 
			// freeText13
			// 
			this.freeText13.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(114)), ((byte)(188)));
			this.freeText13.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText13.Location = new NxtControl.Drawing.PointF(336D, 264D);
			this.freeText13.Name = "freeText13";
			this.freeText13.Text = "Fb Opened";
			// 
			// freeText14
			// 
			this.freeText14.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText14.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText14.Location = new NxtControl.Drawing.PointF(344D, 224D);
			this.freeText14.Name = "freeText14";
			this.freeText14.Text = "Open Valve 014";
			// 
			// freeText16
			// 
			this.freeText16.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(114)), ((byte)(188)));
			this.freeText16.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText16.Location = new NxtControl.Drawing.PointF(336D, 328D);
			this.freeText16.Name = "freeText16";
			this.freeText16.Text = "Fb Closed";
			// 
			// freeText18
			// 
			this.freeText18.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText18.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText18.Location = new NxtControl.Drawing.PointF(344D, 288D);
			this.freeText18.Name = "freeText18";
			this.freeText18.Text = "Close Valve 012";
			// 
			// State11
			// 
			this.State11.Bounds = new NxtControl.Drawing.RectF(((float)(304D)), ((float)(352D)), ((float)(32D)), ((float)(32D)));
			this.State11.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(154)), ((byte)(154)), ((byte)(154))));
			this.State11.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.State11.Name = "State11";
			this.State11.Text = "11";
			this.State11.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			// 
			// line14
			// 
			this.line14.EndPoint = new NxtControl.Drawing.PointF(328D, 400D);
			this.line14.Name = "line14";
			this.line14.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.line14.StartPoint = new NxtControl.Drawing.PointF(312D, 400D);
			// 
			// freeText21
			// 
			this.freeText21.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText21.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText21.Location = new NxtControl.Drawing.PointF(344D, 352D);
			this.freeText21.Name = "freeText21";
			this.freeText21.Text = "Command Speed Max";
			// 
			// freeText25
			// 
			this.freeText25.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(114)), ((byte)(188)));
			this.freeText25.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText25.Location = new NxtControl.Drawing.PointF(336D, 392D);
			this.freeText25.Name = "freeText25";
			this.freeText25.Text = "Speed Max";
			// 
			// line16
			// 
			this.line16.EndPoint = new NxtControl.Drawing.PointF(264D, 416D);
			this.line16.Name = "line16";
			this.line16.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.line16.StartPoint = new NxtControl.Drawing.PointF(264D, 16D);
			// 
			// line17
			// 
			this.line17.EndPoint = new NxtControl.Drawing.PointF(264D, 416D);
			this.line17.Name = "line17";
			this.line17.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.line17.StartPoint = new NxtControl.Drawing.PointF(72D, 416D);
			// 
			// line18
			// 
			this.line18.EndPoint = new NxtControl.Drawing.PointF(320D, 16D);
			this.line18.Name = "line18";
			this.line18.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.line18.StartPoint = new NxtControl.Drawing.PointF(264D, 16D);
			// 
			// polygon2
			// 
			this.polygon2.Bounds = new NxtControl.Drawing.RectF(((float)(259D)), ((float)(176D)), ((float)(10D)), ((float)(24D)));
			this.polygon2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			this.polygon2.Closed = true;
			this.polygon2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.polygon2.Name = "polygon2";
			this.polygon2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(264D, 176D),
			new NxtControl.Drawing.PointF(259D, 200D),
			new NxtControl.Drawing.PointF(269D, 200D)});
			// 
			// fpCtrl
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(504D)), ((float)(456D)));
			this.Brush = new NxtControl.Drawing.Brush("FaceplateBrush");
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.line15,
			this.line1,
			this.State1,
			this.State2,
			this.State3,
			this.State4,
			this.State12,
			this.line2,
			this.line3,
			this.line4,
			this.line5,
			this.line6,
			this.freeText1,
			this.freeText2,
			this.freeText3,
			this.freeText5,
			this.line20,
			this.line21,
			this.line22,
			this.freeText17,
			this.freeText19,
			this.polygon1,
			this.DurationTime,
			this.CycleTime,
			this.State5,
			this.State6,
			this.line7,
			this.line8,
			this.freeText9,
			this.freeText11,
			this.State7,
			this.State8,
			this.line9,
			this.line10,
			this.line11,
			this.State9,
			this.State10,
			this.line12,
			this.line13,
			this.freeText6,
			this.freeText15,
			this.freeText22,
			this.freeText8,
			this.freeText23,
			this.freeText7,
			this.freeText24,
			this.freeText4,
			this.freeText10,
			this.freeText13,
			this.freeText14,
			this.freeText16,
			this.freeText18,
			this.State11,
			this.line14,
			this.freeText21,
			this.freeText25,
			this.line16,
			this.line17,
			this.line18,
			this.polygon2});
			this.Size = new System.Drawing.Size(504, 456);
			this.Title = "F Grit Screens";

		}
		private NxtControl.GuiFramework.Line line15;
		private NxtControl.GuiFramework.Line line1;
		private NxtControl.GuiFramework.Rectangle State1;
		private NxtControl.GuiFramework.Rectangle State2;
		private NxtControl.GuiFramework.Rectangle State3;
		private NxtControl.GuiFramework.Rectangle State4;
		private NxtControl.GuiFramework.Rectangle State12;
		private NxtControl.GuiFramework.Line line2;
		private NxtControl.GuiFramework.Line line3;
		private NxtControl.GuiFramework.Line line4;
		private NxtControl.GuiFramework.Line line5;
		private NxtControl.GuiFramework.Line line6;
		private NxtControl.GuiFramework.FreeText freeText1;
		private NxtControl.GuiFramework.FreeText freeText2;
		private NxtControl.GuiFramework.FreeText freeText3;
		private NxtControl.GuiFramework.FreeText freeText5;
		private NxtControl.GuiFramework.Line line20;
		private NxtControl.GuiFramework.Line line21;
		private NxtControl.GuiFramework.Line line22;
		private NxtControl.GuiFramework.FreeText freeText17;
		private NxtControl.GuiFramework.FreeText freeText19;
		private NxtControl.GuiFramework.Polygon polygon1;
		private SE.Nereda.Symbols.E_DELAY_V_D.sDefault DurationTime;
		private SE.Nereda.Symbols.E_DELAY_V_D.sDefault CycleTime;
		private NxtControl.GuiFramework.Rectangle State5;
		private NxtControl.GuiFramework.Rectangle State6;
		private NxtControl.GuiFramework.Line line7;
		private NxtControl.GuiFramework.Line line8;
		private NxtControl.GuiFramework.FreeText freeText9;
		private NxtControl.GuiFramework.FreeText freeText11;
		private NxtControl.GuiFramework.Rectangle State7;
		private NxtControl.GuiFramework.Rectangle State8;
		private NxtControl.GuiFramework.Line line9;
		private NxtControl.GuiFramework.Line line10;
		private NxtControl.GuiFramework.Line line11;
		private NxtControl.GuiFramework.Rectangle State9;
		private NxtControl.GuiFramework.Rectangle State10;
		private NxtControl.GuiFramework.Line line12;
		private NxtControl.GuiFramework.Line line13;
		private NxtControl.GuiFramework.FreeText freeText6;
		private NxtControl.GuiFramework.FreeText freeText15;
		private NxtControl.GuiFramework.FreeText freeText22;
		private NxtControl.GuiFramework.FreeText freeText8;
		private NxtControl.GuiFramework.FreeText freeText23;
		private NxtControl.GuiFramework.FreeText freeText7;
		private NxtControl.GuiFramework.FreeText freeText24;
		private NxtControl.GuiFramework.FreeText freeText4;
		private NxtControl.GuiFramework.FreeText freeText10;
		private NxtControl.GuiFramework.FreeText freeText13;
		private NxtControl.GuiFramework.FreeText freeText14;
		private NxtControl.GuiFramework.FreeText freeText16;
		private NxtControl.GuiFramework.FreeText freeText18;
		private NxtControl.GuiFramework.Rectangle State11;
		private NxtControl.GuiFramework.Line line14;
		private NxtControl.GuiFramework.FreeText freeText21;
		private NxtControl.GuiFramework.FreeText freeText25;
		private NxtControl.GuiFramework.Line line16;
		private NxtControl.GuiFramework.Line line17;
		private NxtControl.GuiFramework.Line line18;
		private NxtControl.GuiFramework.Polygon polygon2;
		#endregion
	}
}
