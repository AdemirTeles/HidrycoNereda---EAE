/*
 * Created by EcoStruxure Automation Expert.
 * User: SESA713705
 * Date: 9/26/2024
 * Time: 11:52 AM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using NxtControl.GuiFramework;

namespace SE.Nereda.Faceplates.AutoSamplar
{
	/// <summary>
	/// Summary description for fpSettings.
	/// </summary>
	partial class fpSettings
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.rectangle1 = new NxtControl.GuiFramework.Rectangle();
			this.freeText3 = new NxtControl.GuiFramework.FreeText();
			this.line1 = new NxtControl.GuiFramework.Line();
			this.line2 = new NxtControl.GuiFramework.Line();
			this.line3 = new NxtControl.GuiFramework.Line();
			this.line4 = new NxtControl.GuiFramework.Line();
			this.line5 = new NxtControl.GuiFramework.Line();
			this.line6 = new NxtControl.GuiFramework.Line();
			this.line7 = new NxtControl.GuiFramework.Line();
			this.line8 = new NxtControl.GuiFramework.Line();
			this.line9 = new NxtControl.GuiFramework.Line();
			this.line10 = new NxtControl.GuiFramework.Line();
			this.line11 = new NxtControl.GuiFramework.Line();
			this.line12 = new NxtControl.GuiFramework.Line();
			this.line13 = new NxtControl.GuiFramework.Line();
			this.line14 = new NxtControl.GuiFramework.Line();
			this.line15 = new NxtControl.GuiFramework.Line();
			this.line16 = new NxtControl.GuiFramework.Line();
			this.line17 = new NxtControl.GuiFramework.Line();
			this.line18 = new NxtControl.GuiFramework.Line();
			this.line19 = new NxtControl.GuiFramework.Line();
			this.line20 = new NxtControl.GuiFramework.Line();
			this.line21 = new NxtControl.GuiFramework.Line();
			this.line22 = new NxtControl.GuiFramework.Line();
			this.line23 = new NxtControl.GuiFramework.Line();
			this.line24 = new NxtControl.GuiFramework.Line();
			this.line25 = new NxtControl.GuiFramework.Line();
			this.line26 = new NxtControl.GuiFramework.Line();
			this.line27 = new NxtControl.GuiFramework.Line();
			this.line28 = new NxtControl.GuiFramework.Line();
			this.polygon1 = new NxtControl.GuiFramework.Polygon();
			this.polygon2 = new NxtControl.GuiFramework.Polygon();
			this.polygon3 = new NxtControl.GuiFramework.Polygon();
			this.polygon4 = new NxtControl.GuiFramework.Polygon();
			this.freeText4 = new NxtControl.GuiFramework.FreeText();
			this.freeText5 = new NxtControl.GuiFramework.FreeText();
			this.polygon5 = new NxtControl.GuiFramework.Polygon();
			this.freeText6 = new NxtControl.GuiFramework.FreeText();
			this.polygon6 = new NxtControl.GuiFramework.Polygon();
			this.freeText7 = new NxtControl.GuiFramework.FreeText();
			this.freeText8 = new NxtControl.GuiFramework.FreeText();
			this.freeText9 = new NxtControl.GuiFramework.FreeText();
			this.freeText10 = new NxtControl.GuiFramework.FreeText();
			this.freeText11 = new NxtControl.GuiFramework.FreeText();
			this.freeText12 = new NxtControl.GuiFramework.FreeText();
			this.freeText13 = new NxtControl.GuiFramework.FreeText();
			this.freeText14 = new NxtControl.GuiFramework.FreeText();
			this.freeText15 = new NxtControl.GuiFramework.FreeText();
			this.group1 = new NxtControl.GuiFramework.Group();
			this.polygon7 = new NxtControl.GuiFramework.Polygon();
			this.rectangle2 = new NxtControl.GuiFramework.Rectangle();
			this.freeText16 = new NxtControl.GuiFramework.FreeText();
			this.freeText17 = new NxtControl.GuiFramework.FreeText();
			this.DelayTime = new System.HMI.Symbols.Base.TimeTextBox();
			this.FlowSetpoint = new System.HMI.Symbols.Base.TextBox<float>();
			this.group2 = new NxtControl.GuiFramework.Group();
			this.Counte_1m_Cube_1 = new SE.Nereda.Symbols.E_DELAY_V_D.sCounter();
			this.freeText1 = new NxtControl.GuiFramework.FreeText();
			this.freeText2 = new NxtControl.GuiFramework.FreeText();
			this.PulseCount = new System.HMI.Symbols.Base.TextBox<short>();
			// 
			// rectangle1
			// 
			this.rectangle1.Bounds = new NxtControl.Drawing.RectF(((float)(8D)), ((float)(176D)), ((float)(360D)), ((float)(168D)));
			this.rectangle1.Brush = new NxtControl.Drawing.Brush(true);
			this.rectangle1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle1.Name = "rectangle1";
			this.rectangle1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// freeText3
			// 
			this.freeText3.Color = new NxtControl.Drawing.Color("LabelTextColor");
			this.freeText3.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Italic);
			this.freeText3.Location = new NxtControl.Drawing.PointF(56D, 184D);
			this.freeText3.Name = "freeText3";
			this.freeText3.Text = "Note : Flow setpoint to activate AutoSamplar";
			// 
			// line1
			// 
			this.line1.EndPoint = new NxtControl.Drawing.PointF(124D, 223D);
			this.line1.Name = "line1";
			this.line1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line1.StartPoint = new NxtControl.Drawing.PointF(124D, 317D);
			// 
			// line2
			// 
			this.line2.EndPoint = new NxtControl.Drawing.PointF(310D, 309D);
			this.line2.Name = "line2";
			this.line2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line2.StartPoint = new NxtControl.Drawing.PointF(116D, 309D);
			// 
			// line3
			// 
			this.line3.EndPoint = new NxtControl.Drawing.PointF(166D, 237D);
			this.line3.Name = "line3";
			this.line3.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(234)), ((byte)(22)), ((byte)(30))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line3.StartPoint = new NxtControl.Drawing.PointF(124D, 309D);
			// 
			// line4
			// 
			this.line4.EndPoint = new NxtControl.Drawing.PointF(214D, 237D);
			this.line4.Name = "line4";
			this.line4.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(234)), ((byte)(22)), ((byte)(30))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line4.StartPoint = new NxtControl.Drawing.PointF(166D, 237D);
			// 
			// line5
			// 
			this.line5.EndPoint = new NxtControl.Drawing.PointF(222D, 245D);
			this.line5.Name = "line5";
			this.line5.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(234)), ((byte)(22)), ((byte)(30))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line5.StartPoint = new NxtControl.Drawing.PointF(214D, 237D);
			// 
			// line6
			// 
			this.line6.EndPoint = new NxtControl.Drawing.PointF(222D, 245D);
			this.line6.Name = "line6";
			this.line6.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(234)), ((byte)(22)), ((byte)(30))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line6.StartPoint = new NxtControl.Drawing.PointF(254D, 245D);
			// 
			// line7
			// 
			this.line7.EndPoint = new NxtControl.Drawing.PointF(254D, 245D);
			this.line7.Name = "line7";
			this.line7.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(234)), ((byte)(22)), ((byte)(30))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line7.StartPoint = new NxtControl.Drawing.PointF(284D, 309D);
			// 
			// line8
			// 
			this.line8.EndPoint = new NxtControl.Drawing.PointF(292D, 283D);
			this.line8.Name = "line8";
			this.line8.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(114)), ((byte)(188))), 1F, NxtControl.Drawing.DashStyle.Dash);
			this.line8.StartPoint = new NxtControl.Drawing.PointF(124D, 283D);
			// 
			// line9
			// 
			this.line9.EndPoint = new NxtControl.Drawing.PointF(182D, 293D);
			this.line9.Name = "line9";
			this.line9.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(26)), ((byte)(170)), ((byte)(66))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line9.StartPoint = new NxtControl.Drawing.PointF(182D, 309D);
			// 
			// line10
			// 
			this.line10.EndPoint = new NxtControl.Drawing.PointF(190D, 293D);
			this.line10.Name = "line10";
			this.line10.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(26)), ((byte)(170)), ((byte)(66))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line10.StartPoint = new NxtControl.Drawing.PointF(190D, 309D);
			// 
			// line11
			// 
			this.line11.EndPoint = new NxtControl.Drawing.PointF(206D, 293D);
			this.line11.Name = "line11";
			this.line11.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(26)), ((byte)(170)), ((byte)(66))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line11.StartPoint = new NxtControl.Drawing.PointF(206D, 309D);
			// 
			// line12
			// 
			this.line12.EndPoint = new NxtControl.Drawing.PointF(214D, 293D);
			this.line12.Name = "line12";
			this.line12.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(26)), ((byte)(170)), ((byte)(66))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line12.StartPoint = new NxtControl.Drawing.PointF(214D, 309D);
			// 
			// line13
			// 
			this.line13.EndPoint = new NxtControl.Drawing.PointF(230D, 293D);
			this.line13.Name = "line13";
			this.line13.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(26)), ((byte)(170)), ((byte)(66))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line13.StartPoint = new NxtControl.Drawing.PointF(230D, 309D);
			// 
			// line14
			// 
			this.line14.EndPoint = new NxtControl.Drawing.PointF(238D, 293D);
			this.line14.Name = "line14";
			this.line14.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(26)), ((byte)(170)), ((byte)(66))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line14.StartPoint = new NxtControl.Drawing.PointF(238D, 309D);
			// 
			// line15
			// 
			this.line15.EndPoint = new NxtControl.Drawing.PointF(254D, 293D);
			this.line15.Name = "line15";
			this.line15.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(26)), ((byte)(170)), ((byte)(66))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line15.StartPoint = new NxtControl.Drawing.PointF(254D, 309D);
			// 
			// line16
			// 
			this.line16.EndPoint = new NxtControl.Drawing.PointF(262D, 293D);
			this.line16.Name = "line16";
			this.line16.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(26)), ((byte)(170)), ((byte)(66))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line16.StartPoint = new NxtControl.Drawing.PointF(262D, 309D);
			// 
			// line17
			// 
			this.line17.EndPoint = new NxtControl.Drawing.PointF(182D, 293D);
			this.line17.Name = "line17";
			this.line17.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(26)), ((byte)(170)), ((byte)(66))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line17.StartPoint = new NxtControl.Drawing.PointF(190D, 293D);
			// 
			// line18
			// 
			this.line18.EndPoint = new NxtControl.Drawing.PointF(206D, 293D);
			this.line18.Name = "line18";
			this.line18.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(26)), ((byte)(170)), ((byte)(66))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line18.StartPoint = new NxtControl.Drawing.PointF(214D, 293D);
			// 
			// line19
			// 
			this.line19.EndPoint = new NxtControl.Drawing.PointF(230D, 293D);
			this.line19.Name = "line19";
			this.line19.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(26)), ((byte)(170)), ((byte)(66))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line19.StartPoint = new NxtControl.Drawing.PointF(238D, 293D);
			// 
			// line20
			// 
			this.line20.EndPoint = new NxtControl.Drawing.PointF(254D, 293D);
			this.line20.Name = "line20";
			this.line20.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(26)), ((byte)(170)), ((byte)(66))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line20.StartPoint = new NxtControl.Drawing.PointF(262D, 293D);
			// 
			// line21
			// 
			this.line21.EndPoint = new NxtControl.Drawing.PointF(142D, 309D);
			this.line21.Name = "line21";
			this.line21.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(26)), ((byte)(170)), ((byte)(66))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line21.StartPoint = new NxtControl.Drawing.PointF(182D, 309D);
			// 
			// line22
			// 
			this.line22.EndPoint = new NxtControl.Drawing.PointF(190D, 309D);
			this.line22.Name = "line22";
			this.line22.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(26)), ((byte)(170)), ((byte)(66))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line22.StartPoint = new NxtControl.Drawing.PointF(206D, 309D);
			// 
			// line23
			// 
			this.line23.EndPoint = new NxtControl.Drawing.PointF(214D, 309D);
			this.line23.Name = "line23";
			this.line23.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(26)), ((byte)(170)), ((byte)(66))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line23.StartPoint = new NxtControl.Drawing.PointF(230D, 309D);
			// 
			// line24
			// 
			this.line24.EndPoint = new NxtControl.Drawing.PointF(238D, 309D);
			this.line24.Name = "line24";
			this.line24.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(26)), ((byte)(170)), ((byte)(66))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line24.StartPoint = new NxtControl.Drawing.PointF(254D, 309D);
			// 
			// line25
			// 
			this.line25.EndPoint = new NxtControl.Drawing.PointF(262D, 309D);
			this.line25.Name = "line25";
			this.line25.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(26)), ((byte)(170)), ((byte)(66))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line25.StartPoint = new NxtControl.Drawing.PointF(278D, 309D);
			// 
			// line26
			// 
			this.line26.EndPoint = new NxtControl.Drawing.PointF(140D, 229D);
			this.line26.Name = "line26";
			this.line26.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(114)), ((byte)(188))), 1F, NxtControl.Drawing.DashStyle.Dash);
			this.line26.StartPoint = new NxtControl.Drawing.PointF(140D, 309D);
			// 
			// line27
			// 
			this.line27.EndPoint = new NxtControl.Drawing.PointF(180D, 315D);
			this.line27.Name = "line27";
			this.line27.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(26)), ((byte)(170)), ((byte)(66))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line27.StartPoint = new NxtControl.Drawing.PointF(140D, 315D);
			// 
			// line28
			// 
			this.line28.EndPoint = new NxtControl.Drawing.PointF(216D, 315D);
			this.line28.Name = "line28";
			this.line28.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(26)), ((byte)(170)), ((byte)(66))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line28.StartPoint = new NxtControl.Drawing.PointF(228D, 315D);
			// 
			// polygon1
			// 
			this.polygon1.Bounds = new NxtControl.Drawing.RectF(((float)(139D)), ((float)(313D)), ((float)(5D)), ((float)(4D)));
			this.polygon1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(26)), ((byte)(170)), ((byte)(66))));
			this.polygon1.Closed = true;
			this.polygon1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.polygon1.Name = "polygon1";
			this.polygon1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.polygon1.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(144D, 313D),
			new NxtControl.Drawing.PointF(144D, 317D),
			new NxtControl.Drawing.PointF(139D, 315D)});
			// 
			// polygon2
			// 
			this.polygon2.Bounds = new NxtControl.Drawing.RectF(((float)(214D)), ((float)(313D)), ((float)(5D)), ((float)(4D)));
			this.polygon2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(26)), ((byte)(170)), ((byte)(66))));
			this.polygon2.Closed = true;
			this.polygon2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.polygon2.Name = "polygon2";
			this.polygon2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.polygon2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(219D, 313D),
			new NxtControl.Drawing.PointF(219D, 317D),
			new NxtControl.Drawing.PointF(214D, 315D)});
			// 
			// polygon3
			// 
			this.polygon3.Bounds = new NxtControl.Drawing.RectF(((float)(177D)), ((float)(313D)), ((float)(5D)), ((float)(4D)));
			this.polygon3.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(26)), ((byte)(170)), ((byte)(66))));
			this.polygon3.Closed = true;
			this.polygon3.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.polygon3.Name = "polygon3";
			this.polygon3.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.polygon3.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(177D, 313D),
			new NxtControl.Drawing.PointF(177D, 317D),
			new NxtControl.Drawing.PointF(182D, 315D)});
			// 
			// polygon4
			// 
			this.polygon4.Bounds = new NxtControl.Drawing.RectF(((float)(225D)), ((float)(313D)), ((float)(5D)), ((float)(4D)));
			this.polygon4.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(26)), ((byte)(170)), ((byte)(66))));
			this.polygon4.Closed = true;
			this.polygon4.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.polygon4.Name = "polygon4";
			this.polygon4.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.polygon4.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(225D, 313D),
			new NxtControl.Drawing.PointF(225D, 317D),
			new NxtControl.Drawing.PointF(230D, 315D)});
			// 
			// freeText4
			// 
			this.freeText4.Color = new NxtControl.Drawing.Color(((byte)(26)), ((byte)(170)), ((byte)(66)));
			this.freeText4.Font = new NxtControl.Drawing.Font("Arial", 6F, System.Drawing.FontStyle.Regular);
			this.freeText4.Location = new NxtControl.Drawing.PointF(148D, 319D);
			this.freeText4.Name = "freeText4";
			this.freeText4.Text = "Delay\r\nTime";
			// 
			// freeText5
			// 
			this.freeText5.Color = new NxtControl.Drawing.Color(((byte)(26)), ((byte)(170)), ((byte)(66)));
			this.freeText5.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Regular);
			this.freeText5.Location = new NxtControl.Drawing.PointF(216D, 319D);
			this.freeText5.Name = "freeText5";
			this.freeText5.Text = "1m³";
			// 
			// polygon5
			// 
			this.polygon5.Bounds = new NxtControl.Drawing.RectF(((float)(306D)), ((float)(307D)), ((float)(5D)), ((float)(4D)));
			this.polygon5.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			this.polygon5.Closed = true;
			this.polygon5.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.polygon5.Name = "polygon5";
			this.polygon5.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.polygon5.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(306D, 307D),
			new NxtControl.Drawing.PointF(306D, 311D),
			new NxtControl.Drawing.PointF(311D, 309D)});
			// 
			// freeText6
			// 
			this.freeText6.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText6.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Regular);
			this.freeText6.Location = new NxtControl.Drawing.PointF(296D, 311D);
			this.freeText6.Name = "freeText6";
			this.freeText6.Text = "Time";
			// 
			// polygon6
			// 
			this.polygon6.Bounds = new NxtControl.Drawing.RectF(((float)(122D)), ((float)(221D)), ((float)(4D)), ((float)(5D)));
			this.polygon6.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			this.polygon6.Closed = true;
			this.polygon6.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.polygon6.Name = "polygon6";
			this.polygon6.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.polygon6.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(126D, 226D),
			new NxtControl.Drawing.PointF(122D, 226D),
			new NxtControl.Drawing.PointF(124D, 221D)});
			// 
			// freeText7
			// 
			this.freeText7.Color = new NxtControl.Drawing.Color(((byte)(234)), ((byte)(22)), ((byte)(30)));
			this.freeText7.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Regular);
			this.freeText7.Location = new NxtControl.Drawing.PointF(102D, 205D);
			this.freeText7.Name = "freeText7";
			this.freeText7.Text = "Flow To Reactors (m³/h)";
			// 
			// freeText8
			// 
			this.freeText8.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(114)), ((byte)(188)));
			this.freeText8.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Regular);
			this.freeText8.Location = new NxtControl.Drawing.PointF(56D, 279D);
			this.freeText8.Name = "freeText8";
			this.freeText8.Text = "Flow Setpoint";
			// 
			// freeText9
			// 
			this.freeText9.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText9.Font = new NxtControl.Drawing.Font("Arial", 6F, System.Drawing.FontStyle.Regular);
			this.freeText9.Location = new NxtControl.Drawing.PointF(184D, 297D);
			this.freeText9.Name = "freeText9";
			this.freeText9.Text = "1";
			// 
			// freeText10
			// 
			this.freeText10.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText10.Font = new NxtControl.Drawing.Font("Arial", 6F, System.Drawing.FontStyle.Regular);
			this.freeText10.Location = new NxtControl.Drawing.PointF(208D, 297D);
			this.freeText10.Name = "freeText10";
			this.freeText10.Text = "1";
			// 
			// freeText11
			// 
			this.freeText11.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText11.Font = new NxtControl.Drawing.Font("Arial", 6F, System.Drawing.FontStyle.Regular);
			this.freeText11.Location = new NxtControl.Drawing.PointF(232D, 297D);
			this.freeText11.Name = "freeText11";
			this.freeText11.Text = "1";
			// 
			// freeText12
			// 
			this.freeText12.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText12.Font = new NxtControl.Drawing.Font("Arial", 6F, System.Drawing.FontStyle.Regular);
			this.freeText12.Location = new NxtControl.Drawing.PointF(256D, 297D);
			this.freeText12.Name = "freeText12";
			this.freeText12.Text = "1";
			// 
			// freeText13
			// 
			this.freeText13.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText13.Font = new NxtControl.Drawing.Font("Arial", 6F, System.Drawing.FontStyle.Regular);
			this.freeText13.Location = new NxtControl.Drawing.PointF(196D, 297D);
			this.freeText13.Name = "freeText13";
			this.freeText13.Text = "0";
			// 
			// freeText14
			// 
			this.freeText14.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText14.Font = new NxtControl.Drawing.Font("Arial", 6F, System.Drawing.FontStyle.Regular);
			this.freeText14.Location = new NxtControl.Drawing.PointF(220D, 297D);
			this.freeText14.Name = "freeText14";
			this.freeText14.Text = "0";
			// 
			// freeText15
			// 
			this.freeText15.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText15.Font = new NxtControl.Drawing.Font("Arial", 6F, System.Drawing.FontStyle.Regular);
			this.freeText15.Location = new NxtControl.Drawing.PointF(244D, 297D);
			this.freeText15.Name = "freeText15";
			this.freeText15.Text = "0";
			// 
			// group1
			// 
			this.group1.BeginInit();
			this.group1.Name = "group1";
			this.group1.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.line1,
			this.line2,
			this.line3,
			this.line4,
			this.line5,
			this.line6,
			this.line7,
			this.line8,
			this.line9,
			this.line10,
			this.line11,
			this.line12,
			this.line13,
			this.line14,
			this.line15,
			this.line16,
			this.line17,
			this.line18,
			this.line19,
			this.line20,
			this.line21,
			this.line22,
			this.line23,
			this.line24,
			this.line25,
			this.line26,
			this.line27,
			this.line28,
			this.polygon1,
			this.polygon2,
			this.polygon3,
			this.polygon4,
			this.freeText4,
			this.freeText5,
			this.polygon5,
			this.freeText6,
			this.polygon6,
			this.freeText7,
			this.freeText8,
			this.freeText9,
			this.freeText10,
			this.freeText11,
			this.freeText12,
			this.freeText13,
			this.freeText14,
			this.freeText15});
			this.group1.EndInit();
			// 
			// polygon7
			// 
			this.polygon7.Bounds = new NxtControl.Drawing.RectF(((float)(8D)), ((float)(8D)), ((float)(288D)), ((float)(24D)));
			this.polygon7.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(78)), ((byte)(78)), ((byte)(78))));
			this.polygon7.Closed = true;
			this.polygon7.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular);
			this.polygon7.Name = "polygon7";
			this.polygon7.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(78)), ((byte)(78)), ((byte)(78))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.polygon7.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(8D, 32D),
			new NxtControl.Drawing.PointF(8D, 8D),
			new NxtControl.Drawing.PointF(264D, 8D),
			new NxtControl.Drawing.PointF(296D, 32D)});
			this.polygon7.Text = "AUTO SAMPLAR  -  SETTINGS";
			this.polygon7.TextColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(0)));
			// 
			// rectangle2
			// 
			this.rectangle2.Bounds = new NxtControl.Drawing.RectF(((float)(8D)), ((float)(24D)), ((float)(360D)), ((float)(320D)));
			this.rectangle2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(250)), ((byte)(250)), ((byte)(250))));
			this.rectangle2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle2.Name = "rectangle2";
			// 
			// freeText16
			// 
			this.freeText16.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText16.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.freeText16.Location = new NxtControl.Drawing.PointF(16D, 37D);
			this.freeText16.Name = "freeText16";
			this.freeText16.Text = "Delay Time :";
			// 
			// freeText17
			// 
			this.freeText17.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText17.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.freeText17.Location = new NxtControl.Drawing.PointF(16D, 77D);
			this.freeText17.Name = "freeText17";
			this.freeText17.Text = "Flow Setpoint :";
			// 
			// DelayTime
			// 
			this.DelayTime.BeginInit();
			this.DelayTime.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.64D, 0D, 0D, 1.0384615384615385D, 232D, 32D);
			this.DelayTime.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.DelayTime.MaximumTag = null;
			this.DelayTime.MinimumTag = null;
			this.DelayTime.Name = "DelayTime";
			this.DelayTime.TagName = "DelayTime";
			this.DelayTime.UseInputPad = true;
			this.DelayTime.Value = new NxtControl.GuiFramework.Time(((long)(0)));
			this.DelayTime.EndInit();
			// 
			// FlowSetpoint
			// 
			this.FlowSetpoint.BeginInit();
			this.FlowSetpoint.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.64D, 0D, 0D, 1D, 232D, 72D);
			this.FlowSetpoint.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.FlowSetpoint.MaximumTag = null;
			this.FlowSetpoint.MinimumTag = null;
			this.FlowSetpoint.Name = "FlowSetpoint";
			this.FlowSetpoint.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.FlowSetpoint.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Black"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.FlowSetpoint.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.FlowSetpoint.Suffix = "m³/h";
			this.FlowSetpoint.TagName = "FlowSetpoint";
			this.FlowSetpoint.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			this.FlowSetpoint.TextColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.FlowSetpoint.UseInputPad = true;
			this.FlowSetpoint.Value = 0F;
			this.FlowSetpoint.EndInit();
			// 
			// group2
			// 
			this.group2.BeginInit();
			this.group2.Name = "group2";
			this.group2.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.freeText3,
			this.group1});
			this.group2.EndInit();
			// 
			// Counte_1m_Cube_1
			// 
			this.Counte_1m_Cube_1.BeginInit();
			this.Counte_1m_Cube_1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 120D, 112D);
			this.Counte_1m_Cube_1.Name = "Counte_1m_Cube_1";
			this.Counte_1m_Cube_1.SecurityToken = ((uint)(4294967295u));
			this.Counte_1m_Cube_1.TagName = "Counte_1m_Cube";
			this.Counte_1m_Cube_1.EndInit();
			// 
			// freeText1
			// 
			this.freeText1.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText1.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.freeText1.Location = new NxtControl.Drawing.PointF(16D, 112D);
			this.freeText1.Name = "freeText1";
			this.freeText1.Text = "Cycle Time :";
			// 
			// freeText2
			// 
			this.freeText2.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText2.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.freeText2.Location = new NxtControl.Drawing.PointF(16D, 144D);
			this.freeText2.Name = "freeText2";
			this.freeText2.Text = "Pulse Counter :";
			// 
			// PulseCount
			// 
			this.PulseCount.BeginInit();
			this.PulseCount.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.64D, 0D, 0D, 1D, 232D, 140D);
			this.PulseCount.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.PulseCount.IsOnlyInput = true;
			this.PulseCount.MaximumTag = null;
			this.PulseCount.MinimumTag = null;
			this.PulseCount.Name = "PulseCount";
			this.PulseCount.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.PulseCount.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Black"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.PulseCount.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.PulseCount.Suffix = "Pulse";
			this.PulseCount.TagName = "PulseCount";
			this.PulseCount.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			this.PulseCount.TextColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.PulseCount.Value = ((short)(0));
			this.PulseCount.EndInit();
			// 
			// fpSettings
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(376D)), ((float)(352D)));
			this.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(154)), ((byte)(154)), ((byte)(154))));
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.polygon7,
			this.rectangle2,
			this.freeText16,
			this.freeText17,
			this.DelayTime,
			this.FlowSetpoint,
			this.group2,
			this.Counte_1m_Cube_1,
			this.freeText1,
			this.freeText2,
			this.PulseCount,
			this.rectangle1});
			this.Size = new System.Drawing.Size(376, 352);
			this.Title = "AutoSamplar Settings";

		}
		private NxtControl.GuiFramework.Rectangle rectangle1;
		private NxtControl.GuiFramework.FreeText freeText3;
		private NxtControl.GuiFramework.Line line1;
		private NxtControl.GuiFramework.Line line2;
		private NxtControl.GuiFramework.Line line3;
		private NxtControl.GuiFramework.Line line4;
		private NxtControl.GuiFramework.Line line5;
		private NxtControl.GuiFramework.Line line6;
		private NxtControl.GuiFramework.Line line7;
		private NxtControl.GuiFramework.Line line8;
		private NxtControl.GuiFramework.Line line9;
		private NxtControl.GuiFramework.Line line10;
		private NxtControl.GuiFramework.Line line11;
		private NxtControl.GuiFramework.Line line12;
		private NxtControl.GuiFramework.Line line13;
		private NxtControl.GuiFramework.Line line14;
		private NxtControl.GuiFramework.Line line15;
		private NxtControl.GuiFramework.Line line16;
		private NxtControl.GuiFramework.Line line17;
		private NxtControl.GuiFramework.Line line18;
		private NxtControl.GuiFramework.Line line19;
		private NxtControl.GuiFramework.Line line20;
		private NxtControl.GuiFramework.Line line21;
		private NxtControl.GuiFramework.Line line22;
		private NxtControl.GuiFramework.Line line23;
		private NxtControl.GuiFramework.Line line24;
		private NxtControl.GuiFramework.Line line25;
		private NxtControl.GuiFramework.Line line26;
		private NxtControl.GuiFramework.Line line27;
		private NxtControl.GuiFramework.Line line28;
		private NxtControl.GuiFramework.Polygon polygon1;
		private NxtControl.GuiFramework.Polygon polygon2;
		private NxtControl.GuiFramework.Polygon polygon3;
		private NxtControl.GuiFramework.Polygon polygon4;
		private NxtControl.GuiFramework.FreeText freeText4;
		private NxtControl.GuiFramework.FreeText freeText5;
		private NxtControl.GuiFramework.Polygon polygon5;
		private NxtControl.GuiFramework.FreeText freeText6;
		private NxtControl.GuiFramework.Polygon polygon6;
		private NxtControl.GuiFramework.FreeText freeText7;
		private NxtControl.GuiFramework.FreeText freeText8;
		private NxtControl.GuiFramework.FreeText freeText9;
		private NxtControl.GuiFramework.FreeText freeText10;
		private NxtControl.GuiFramework.FreeText freeText11;
		private NxtControl.GuiFramework.FreeText freeText12;
		private NxtControl.GuiFramework.FreeText freeText13;
		private NxtControl.GuiFramework.FreeText freeText14;
		private NxtControl.GuiFramework.FreeText freeText15;
		private NxtControl.GuiFramework.Group group1;
		private NxtControl.GuiFramework.Polygon polygon7;
		private NxtControl.GuiFramework.Rectangle rectangle2;
		private NxtControl.GuiFramework.FreeText freeText16;
		private NxtControl.GuiFramework.FreeText freeText17;
		private System.HMI.Symbols.Base.TimeTextBox DelayTime;
		private System.HMI.Symbols.Base.TextBox<float> FlowSetpoint;
		private NxtControl.GuiFramework.Group group2;
		private SE.Nereda.Symbols.E_DELAY_V_D.sCounter Counte_1m_Cube_1;
		private NxtControl.GuiFramework.FreeText freeText1;
		private NxtControl.GuiFramework.FreeText freeText2;
		private System.HMI.Symbols.Base.TextBox<short> PulseCount;
		#endregion
	}
}
