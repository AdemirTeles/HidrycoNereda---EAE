/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 6/18/2026
 * Time: 10:54 AM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.FeedInfluentLogic
{
	/// <summary>
	/// Summary description for sGrafcet.
	/// </summary>
	partial class sGrafcet
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.State1 = new NxtControl.GuiFramework.Rectangle();
			this.State2 = new NxtControl.GuiFramework.Rectangle();
			this.State3 = new NxtControl.GuiFramework.Rectangle();
			this.State4 = new NxtControl.GuiFramework.Rectangle();
			this.line1 = new NxtControl.GuiFramework.Line();
			this.line2 = new NxtControl.GuiFramework.Line();
			this.line3 = new NxtControl.GuiFramework.Line();
			this.line4 = new NxtControl.GuiFramework.Line();
			this.line5 = new NxtControl.GuiFramework.Line();
			this.line9 = new NxtControl.GuiFramework.Line();
			this.freeText1 = new NxtControl.GuiFramework.FreeText();
			this.freeText2 = new NxtControl.GuiFramework.FreeText();
			this.freeText3 = new NxtControl.GuiFramework.FreeText();
			this.freeText4 = new NxtControl.GuiFramework.FreeText();
			this.State10 = new NxtControl.GuiFramework.Rectangle();
			this.State11 = new NxtControl.GuiFramework.Rectangle();
			this.State12 = new NxtControl.GuiFramework.Rectangle();
			this.State13 = new NxtControl.GuiFramework.Rectangle();
			this.State9 = new NxtControl.GuiFramework.Rectangle();
			this.line10 = new NxtControl.GuiFramework.Line();
			this.line11 = new NxtControl.GuiFramework.Line();
			this.line12 = new NxtControl.GuiFramework.Line();
			this.line13 = new NxtControl.GuiFramework.Line();
			this.line15 = new NxtControl.GuiFramework.Line();
			this.freeText8 = new NxtControl.GuiFramework.FreeText();
			this.freeText9 = new NxtControl.GuiFramework.FreeText();
			this.freeText10 = new NxtControl.GuiFramework.FreeText();
			this.freeText11 = new NxtControl.GuiFramework.FreeText();
			this.line17 = new NxtControl.GuiFramework.Line();
			this.line19 = new NxtControl.GuiFramework.Line();
			this.line20 = new NxtControl.GuiFramework.Line();
			this.line21 = new NxtControl.GuiFramework.Line();
			this.line22 = new NxtControl.GuiFramework.Line();
			this.line23 = new NxtControl.GuiFramework.Line();
			this.line24 = new NxtControl.GuiFramework.Line();
			this.line25 = new NxtControl.GuiFramework.Line();
			this.freeText13 = new NxtControl.GuiFramework.FreeText();
			this.freeText14 = new NxtControl.GuiFramework.FreeText();
			this.freeText15 = new NxtControl.GuiFramework.FreeText();
			this.freeText16 = new NxtControl.GuiFramework.FreeText();
			this.freeText17 = new NxtControl.GuiFramework.FreeText();
			this.freeText18 = new NxtControl.GuiFramework.FreeText();
			this.freeText23 = new NxtControl.GuiFramework.FreeText();
			this.freeText24 = new NxtControl.GuiFramework.FreeText();
			this.freeText25 = new NxtControl.GuiFramework.FreeText();
			this.freeText26 = new NxtControl.GuiFramework.FreeText();
			this.freeText27 = new NxtControl.GuiFramework.FreeText();
			this.polygon1 = new NxtControl.GuiFramework.Polygon();
			this.polygon3 = new NxtControl.GuiFramework.Polygon();
			this.ResetLogic = new NxtControl.GuiFramework.DrawnButton();
			// 
			// State1
			// 
			this.State1.Bounds = new NxtControl.Drawing.RectF(((float)(64D)), ((float)(48D)), ((float)(32D)), ((float)(32D)));
			this.State1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(154)), ((byte)(154)), ((byte)(154))));
			this.State1.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.State1.Name = "State1";
			this.State1.Text = "1";
			this.State1.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			// 
			// State2
			// 
			this.State2.Bounds = new NxtControl.Drawing.RectF(((float)(64D)), ((float)(112D)), ((float)(32D)), ((float)(32D)));
			this.State2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(154)), ((byte)(154)), ((byte)(154))));
			this.State2.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.State2.Name = "State2";
			this.State2.Text = "2";
			this.State2.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			// 
			// State3
			// 
			this.State3.Bounds = new NxtControl.Drawing.RectF(((float)(64D)), ((float)(176D)), ((float)(32D)), ((float)(32D)));
			this.State3.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(154)), ((byte)(154)), ((byte)(154))));
			this.State3.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.State3.Name = "State3";
			this.State3.Text = "3";
			this.State3.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			// 
			// State4
			// 
			this.State4.Bounds = new NxtControl.Drawing.RectF(((float)(64D)), ((float)(240D)), ((float)(32D)), ((float)(32D)));
			this.State4.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(154)), ((byte)(154)), ((byte)(154))));
			this.State4.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.State4.Name = "State4";
			this.State4.Text = "4";
			this.State4.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			// 
			// line1
			// 
			this.line1.EndPoint = new NxtControl.Drawing.PointF(80D, 400D);
			this.line1.Name = "line1";
			this.line1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.line1.StartPoint = new NxtControl.Drawing.PointF(80D, 32D);
			// 
			// line2
			// 
			this.line2.EndPoint = new NxtControl.Drawing.PointF(88D, 96D);
			this.line2.Name = "line2";
			this.line2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.line2.StartPoint = new NxtControl.Drawing.PointF(72D, 96D);
			// 
			// line3
			// 
			this.line3.EndPoint = new NxtControl.Drawing.PointF(88D, 160D);
			this.line3.Name = "line3";
			this.line3.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.line3.StartPoint = new NxtControl.Drawing.PointF(72D, 160D);
			// 
			// line4
			// 
			this.line4.EndPoint = new NxtControl.Drawing.PointF(88D, 224D);
			this.line4.Name = "line4";
			this.line4.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.line4.StartPoint = new NxtControl.Drawing.PointF(72D, 224D);
			// 
			// line5
			// 
			this.line5.EndPoint = new NxtControl.Drawing.PointF(88D, 288D);
			this.line5.Name = "line5";
			this.line5.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.line5.StartPoint = new NxtControl.Drawing.PointF(72D, 288D);
			// 
			// line9
			// 
			this.line9.EndPoint = new NxtControl.Drawing.PointF(416D, 368D);
			this.line9.Name = "line9";
			this.line9.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.line9.StartPoint = new NxtControl.Drawing.PointF(80D, 368D);
			// 
			// freeText1
			// 
			this.freeText1.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(114)), ((byte)(188)));
			this.freeText1.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText1.Location = new NxtControl.Drawing.PointF(96D, 88D);
			this.freeText1.Name = "freeText1";
			this.freeText1.Text = "LevelPv <= StartPv";
			// 
			// freeText2
			// 
			this.freeText2.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(114)), ((byte)(188)));
			this.freeText2.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText2.Location = new NxtControl.Drawing.PointF(96D, 152D);
			this.freeText2.Name = "freeText2";
			this.freeText2.Text = "FbRunning";
			// 
			// freeText3
			// 
			this.freeText3.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(114)), ((byte)(188)));
			this.freeText3.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText3.Location = new NxtControl.Drawing.PointF(96D, 216D);
			this.freeText3.Name = "freeText3";
			this.freeText3.Text = "LevelPv >= StopPv";
			// 
			// freeText4
			// 
			this.freeText4.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(114)), ((byte)(188)));
			this.freeText4.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText4.Location = new NxtControl.Drawing.PointF(96D, 280D);
			this.freeText4.Name = "freeText4";
			this.freeText4.Text = "FbStopped";
			// 
			// State10
			// 
			this.State10.Bounds = new NxtControl.Drawing.RectF(((float)(272D)), ((float)(48D)), ((float)(32D)), ((float)(32D)));
			this.State10.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(154)), ((byte)(154)), ((byte)(154))));
			this.State10.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.State10.Name = "State10";
			this.State10.Text = "10";
			this.State10.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			// 
			// State11
			// 
			this.State11.Bounds = new NxtControl.Drawing.RectF(((float)(272D)), ((float)(112D)), ((float)(32D)), ((float)(32D)));
			this.State11.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(154)), ((byte)(154)), ((byte)(154))));
			this.State11.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.State11.Name = "State11";
			this.State11.Text = "11";
			this.State11.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			// 
			// State12
			// 
			this.State12.Bounds = new NxtControl.Drawing.RectF(((float)(272D)), ((float)(176D)), ((float)(32D)), ((float)(32D)));
			this.State12.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(154)), ((byte)(154)), ((byte)(154))));
			this.State12.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.State12.Name = "State12";
			this.State12.Text = "12";
			this.State12.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			// 
			// State13
			// 
			this.State13.Bounds = new NxtControl.Drawing.RectF(((float)(272D)), ((float)(240D)), ((float)(32D)), ((float)(32D)));
			this.State13.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(154)), ((byte)(154)), ((byte)(154))));
			this.State13.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.State13.Name = "State13";
			this.State13.Text = "13";
			this.State13.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			// 
			// State9
			// 
			this.State9.Bounds = new NxtControl.Drawing.RectF(((float)(64D)), ((float)(320D)), ((float)(32D)), ((float)(32D)));
			this.State9.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(154)), ((byte)(154)), ((byte)(154))));
			this.State9.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.State9.Name = "State9";
			this.State9.Text = "9";
			this.State9.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			// 
			// line10
			// 
			this.line10.EndPoint = new NxtControl.Drawing.PointF(296D, 96D);
			this.line10.Name = "line10";
			this.line10.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.line10.StartPoint = new NxtControl.Drawing.PointF(280D, 96D);
			// 
			// line11
			// 
			this.line11.EndPoint = new NxtControl.Drawing.PointF(296D, 160D);
			this.line11.Name = "line11";
			this.line11.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.line11.StartPoint = new NxtControl.Drawing.PointF(280D, 160D);
			// 
			// line12
			// 
			this.line12.EndPoint = new NxtControl.Drawing.PointF(296D, 224D);
			this.line12.Name = "line12";
			this.line12.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.line12.StartPoint = new NxtControl.Drawing.PointF(280D, 224D);
			// 
			// line13
			// 
			this.line13.EndPoint = new NxtControl.Drawing.PointF(296D, 288D);
			this.line13.Name = "line13";
			this.line13.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.line13.StartPoint = new NxtControl.Drawing.PointF(280D, 288D);
			// 
			// line15
			// 
			this.line15.EndPoint = new NxtControl.Drawing.PointF(288D, 304D);
			this.line15.Name = "line15";
			this.line15.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.line15.StartPoint = new NxtControl.Drawing.PointF(288D, 32D);
			// 
			// freeText8
			// 
			this.freeText8.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(114)), ((byte)(188)));
			this.freeText8.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText8.Location = new NxtControl.Drawing.PointF(304D, 88D);
			this.freeText8.Name = "freeText8";
			this.freeText8.Text = "1";
			// 
			// freeText9
			// 
			this.freeText9.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(114)), ((byte)(188)));
			this.freeText9.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText9.Location = new NxtControl.Drawing.PointF(304D, 152D);
			this.freeText9.Name = "freeText9";
			this.freeText9.Text = "FbRunning";
			// 
			// freeText10
			// 
			this.freeText10.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(114)), ((byte)(188)));
			this.freeText10.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText10.Location = new NxtControl.Drawing.PointF(304D, 216D);
			this.freeText10.Name = "freeText10";
			this.freeText10.Text = "Run Delay Done";
			// 
			// freeText11
			// 
			this.freeText11.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(114)), ((byte)(188)));
			this.freeText11.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText11.Location = new NxtControl.Drawing.PointF(304D, 280D);
			this.freeText11.Name = "freeText11";
			this.freeText11.Text = "FbStopped";
			// 
			// line17
			// 
			this.line17.EndPoint = new NxtControl.Drawing.PointF(80D, 304D);
			this.line17.Name = "line17";
			this.line17.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.line17.StartPoint = new NxtControl.Drawing.PointF(288D, 304D);
			// 
			// line19
			// 
			this.line19.EndPoint = new NxtControl.Drawing.PointF(88D, 384D);
			this.line19.Name = "line19";
			this.line19.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.line19.StartPoint = new NxtControl.Drawing.PointF(72D, 384D);
			// 
			// line20
			// 
			this.line20.EndPoint = new NxtControl.Drawing.PointF(80D, 400D);
			this.line20.Name = "line20";
			this.line20.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.line20.StartPoint = new NxtControl.Drawing.PointF(24D, 400D);
			// 
			// line21
			// 
			this.line21.EndPoint = new NxtControl.Drawing.PointF(24D, 400D);
			this.line21.Name = "line21";
			this.line21.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.line21.StartPoint = new NxtControl.Drawing.PointF(24D, 32D);
			// 
			// line22
			// 
			this.line22.EndPoint = new NxtControl.Drawing.PointF(80D, 32D);
			this.line22.Name = "line22";
			this.line22.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.line22.StartPoint = new NxtControl.Drawing.PointF(24D, 32D);
			// 
			// line23
			// 
			this.line23.EndPoint = new NxtControl.Drawing.PointF(416D, 368D);
			this.line23.Name = "line23";
			this.line23.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.line23.StartPoint = new NxtControl.Drawing.PointF(416D, 32D);
			// 
			// line24
			// 
			this.line24.EndPoint = new NxtControl.Drawing.PointF(416D, 32D);
			this.line24.Name = "line24";
			this.line24.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.line24.StartPoint = new NxtControl.Drawing.PointF(288D, 32D);
			// 
			// line25
			// 
			this.line25.EndPoint = new NxtControl.Drawing.PointF(248D, 360D);
			this.line25.Name = "line25";
			this.line25.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.line25.StartPoint = new NxtControl.Drawing.PointF(248D, 376D);
			// 
			// freeText13
			// 
			this.freeText13.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(114)), ((byte)(188)));
			this.freeText13.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText13.Location = new NxtControl.Drawing.PointF(208D, 344D);
			this.freeText13.Name = "freeText13";
			this.freeText13.Text = "Freeze Mode";
			// 
			// freeText14
			// 
			this.freeText14.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(114)), ((byte)(188)));
			this.freeText14.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText14.Location = new NxtControl.Drawing.PointF(96D, 376D);
			this.freeText14.Name = "freeText14";
			this.freeText14.Text = "Not Freeze Mode";
			// 
			// freeText15
			// 
			this.freeText15.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText15.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText15.Location = new NxtControl.Drawing.PointF(104D, 48D);
			this.freeText15.Name = "freeText15";
			this.freeText15.Text = "Normal Operation";
			// 
			// freeText16
			// 
			this.freeText16.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText16.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText16.Location = new NxtControl.Drawing.PointF(104D, 112D);
			this.freeText16.Name = "freeText16";
			this.freeText16.Text = "Start Pump";
			// 
			// freeText17
			// 
			this.freeText17.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText17.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText17.Location = new NxtControl.Drawing.PointF(104D, 176D);
			this.freeText17.Name = "freeText17";
			this.freeText17.Text = "Pump Running";
			// 
			// freeText18
			// 
			this.freeText18.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText18.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText18.Location = new NxtControl.Drawing.PointF(104D, 240D);
			this.freeText18.Name = "freeText18";
			this.freeText18.Text = "Stop Pump";
			// 
			// freeText23
			// 
			this.freeText23.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText23.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText23.Location = new NxtControl.Drawing.PointF(312D, 48D);
			this.freeText23.Name = "freeText23";
			this.freeText23.Text = "Freeze Operation";
			// 
			// freeText24
			// 
			this.freeText24.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText24.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText24.Location = new NxtControl.Drawing.PointF(312D, 112D);
			this.freeText24.Name = "freeText24";
			this.freeText24.Text = "Start Pump";
			// 
			// freeText25
			// 
			this.freeText25.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText25.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText25.Location = new NxtControl.Drawing.PointF(312D, 176D);
			this.freeText25.Name = "freeText25";
			this.freeText25.Text = "Pump Running";
			// 
			// freeText26
			// 
			this.freeText26.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText26.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText26.Location = new NxtControl.Drawing.PointF(312D, 240D);
			this.freeText26.Name = "freeText26";
			this.freeText26.Text = "Stop Pump";
			// 
			// freeText27
			// 
			this.freeText27.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText27.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText27.Location = new NxtControl.Drawing.PointF(104D, 320D);
			this.freeText27.Name = "freeText27";
			this.freeText27.Text = "Pump Stopped";
			// 
			// polygon1
			// 
			this.polygon1.Bounds = new NxtControl.Drawing.RectF(((float)(19D)), ((float)(292D)), ((float)(10D)), ((float)(24D)));
			this.polygon1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			this.polygon1.Closed = true;
			this.polygon1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.polygon1.Name = "polygon1";
			this.polygon1.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(24D, 292D),
			new NxtControl.Drawing.PointF(19D, 316D),
			new NxtControl.Drawing.PointF(29D, 316D)});
			// 
			// polygon3
			// 
			this.polygon3.Bounds = new NxtControl.Drawing.RectF(((float)(411D)), ((float)(276D)), ((float)(10D)), ((float)(24D)));
			this.polygon3.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			this.polygon3.Closed = true;
			this.polygon3.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.polygon3.Name = "polygon3";
			this.polygon3.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(416D, 276D),
			new NxtControl.Drawing.PointF(411D, 300D),
			new NxtControl.Drawing.PointF(421D, 300D)});
			// 
			// ResetLogic
			// 
			this.ResetLogic.Bounds = new NxtControl.Drawing.RectF(((float)(288D)), ((float)(384D)), ((float)(128D)), ((float)(32D)));
			this.ResetLogic.Brush = new NxtControl.Drawing.Brush("ButtonBrush");
			this.ResetLogic.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.ResetLogic.InnerBorderColor = new NxtControl.Drawing.Color("ButtonInnerBorderColor");
			this.ResetLogic.Name = "ResetLogic";
			this.ResetLogic.Pen = new NxtControl.Drawing.Pen("ButtonPen");
			this.ResetLogic.Radius = 4D;
			this.ResetLogic.Text = "RESET LOGIC";
			this.ResetLogic.TextColor = new NxtControl.Drawing.Color("ButtonTextColor");
			this.ResetLogic.TextColorMouseDown = new NxtControl.Drawing.Color("ButtonTextColorMouseDown");
			this.ResetLogic.Use3DEffect = false;
			this.ResetLogic.Click += new System.EventHandler(this.ResetLogicClick);
			// 
			// sGrafcet
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.line15,
			this.line1,
			this.State1,
			this.State2,
			this.State3,
			this.State4,
			this.line2,
			this.line3,
			this.line4,
			this.line5,
			this.line9,
			this.freeText1,
			this.freeText2,
			this.freeText3,
			this.freeText4,
			this.State10,
			this.State11,
			this.State12,
			this.State13,
			this.State9,
			this.line10,
			this.line11,
			this.line12,
			this.line13,
			this.freeText8,
			this.freeText9,
			this.freeText10,
			this.freeText11,
			this.line17,
			this.line19,
			this.line20,
			this.line21,
			this.line22,
			this.line23,
			this.line24,
			this.line25,
			this.freeText13,
			this.freeText14,
			this.freeText15,
			this.freeText16,
			this.freeText17,
			this.freeText18,
			this.freeText23,
			this.freeText24,
			this.freeText25,
			this.freeText26,
			this.freeText27,
			this.polygon1,
			this.polygon3,
			this.ResetLogic});
			this.SymbolSize = new System.Drawing.Size(440, 432);

		}
		private NxtControl.GuiFramework.Rectangle State1;
		private NxtControl.GuiFramework.Rectangle State2;
		private NxtControl.GuiFramework.Rectangle State3;
		private NxtControl.GuiFramework.Rectangle State4;
		private NxtControl.GuiFramework.Line line1;
		private NxtControl.GuiFramework.Line line2;
		private NxtControl.GuiFramework.Line line3;
		private NxtControl.GuiFramework.Line line4;
		private NxtControl.GuiFramework.Line line5;
		private NxtControl.GuiFramework.Line line9;
		private NxtControl.GuiFramework.FreeText freeText1;
		private NxtControl.GuiFramework.FreeText freeText2;
		private NxtControl.GuiFramework.FreeText freeText3;
		private NxtControl.GuiFramework.FreeText freeText4;
		private NxtControl.GuiFramework.Rectangle State10;
		private NxtControl.GuiFramework.Rectangle State11;
		private NxtControl.GuiFramework.Rectangle State12;
		private NxtControl.GuiFramework.Rectangle State13;
		private NxtControl.GuiFramework.Rectangle State9;
		private NxtControl.GuiFramework.Line line10;
		private NxtControl.GuiFramework.Line line11;
		private NxtControl.GuiFramework.Line line12;
		private NxtControl.GuiFramework.Line line13;
		private NxtControl.GuiFramework.Line line15;
		private NxtControl.GuiFramework.FreeText freeText8;
		private NxtControl.GuiFramework.FreeText freeText9;
		private NxtControl.GuiFramework.FreeText freeText10;
		private NxtControl.GuiFramework.FreeText freeText11;
		private NxtControl.GuiFramework.Line line17;
		private NxtControl.GuiFramework.Line line19;
		private NxtControl.GuiFramework.Line line20;
		private NxtControl.GuiFramework.Line line21;
		private NxtControl.GuiFramework.Line line22;
		private NxtControl.GuiFramework.Line line23;
		private NxtControl.GuiFramework.Line line24;
		private NxtControl.GuiFramework.Line line25;
		private NxtControl.GuiFramework.FreeText freeText13;
		private NxtControl.GuiFramework.FreeText freeText14;
		private NxtControl.GuiFramework.FreeText freeText15;
		private NxtControl.GuiFramework.FreeText freeText16;
		private NxtControl.GuiFramework.FreeText freeText17;
		private NxtControl.GuiFramework.FreeText freeText18;
		private NxtControl.GuiFramework.FreeText freeText23;
		private NxtControl.GuiFramework.FreeText freeText24;
		private NxtControl.GuiFramework.FreeText freeText25;
		private NxtControl.GuiFramework.FreeText freeText26;
		private NxtControl.GuiFramework.FreeText freeText27;
		private NxtControl.GuiFramework.Polygon polygon1;
		private NxtControl.GuiFramework.Polygon polygon3;
		private NxtControl.GuiFramework.DrawnButton ResetLogic;
		#endregion
	}
}
