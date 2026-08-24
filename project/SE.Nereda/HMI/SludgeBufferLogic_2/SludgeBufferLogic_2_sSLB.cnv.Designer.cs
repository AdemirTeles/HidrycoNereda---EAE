/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 6/29/2026
 * Time: 5:38 PM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.SludgeBufferLogic_2
{
	/// <summary>
	/// Summary description for sShowLevel.
	/// </summary>
	partial class sSLB
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.ShowLevel = new NxtControl.GuiFramework.Rectangle();
			this.pipe2 = new NxtControl.GuiFramework.Pipe();
			this.pipe1 = new NxtControl.GuiFramework.Pipe();
			this.pipe3 = new NxtControl.GuiFramework.Pipe();
			this.pipe4 = new NxtControl.GuiFramework.Pipe();
			this.polygon5 = new NxtControl.GuiFramework.Polygon();
			this.line4 = new NxtControl.GuiFramework.Line();
			this.HiHiLevel = new NxtControl.GuiFramework.Rectangle();
			this.pipe5 = new NxtControl.GuiFramework.Pipe();
			this.pipe6 = new NxtControl.GuiFramework.Pipe();
			this.line6 = new NxtControl.GuiFramework.Line();
			this.polygon1 = new NxtControl.GuiFramework.Polygon();
			this.pipe8 = new NxtControl.GuiFramework.Pipe();
			this.polyline1 = new NxtControl.GuiFramework.Polyline();
			this.CV001 = new NxtControl.GuiFramework.FreeText();
			this.XV001 = new NxtControl.GuiFramework.FreeText();
			this.pipe7 = new NxtControl.GuiFramework.Pipe();
			this.line8 = new NxtControl.GuiFramework.Line();
			this.polygon3 = new NxtControl.GuiFramework.Polygon();
			this.pipe11 = new NxtControl.GuiFramework.Pipe();
			this.line5 = new NxtControl.GuiFramework.Line();
			this.polygon2 = new NxtControl.GuiFramework.Polygon();
			this.pipe10 = new NxtControl.GuiFramework.Pipe();
			this.line10 = new NxtControl.GuiFramework.Line();
			this.polygon4 = new NxtControl.GuiFramework.Polygon();
			this.line7 = new NxtControl.GuiFramework.Line();
			this.line1 = new NxtControl.GuiFramework.Line();
			this.line3 = new NxtControl.GuiFramework.Line();
			this.line2 = new NxtControl.GuiFramework.Line();
			this.pipe9 = new NxtControl.GuiFramework.Pipe();
			this.line9 = new NxtControl.GuiFramework.Line();
			this.HiHiTxt = new NxtControl.GuiFramework.FreeText();
			this.freeText1 = new NxtControl.GuiFramework.FreeText();
			this.group1 = new NxtControl.GuiFramework.Group();
			// 
			// ShowLevel
			// 
			this.ShowLevel.Bounds = new NxtControl.Drawing.RectF(((float)(176D)), ((float)(72D)), ((float)(336D)), ((float)(184D)));
			this.ShowLevel.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(235)), ((byte)(145))));
			this.ShowLevel.FillDirection = NxtControl.Drawing.FillDirection.DownToTop;
			this.ShowLevel.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.ShowLevel.Name = "ShowLevel";
			this.ShowLevel.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// pipe2
			// 
			this.pipe2.Bounds = new NxtControl.Drawing.RectF(((float)(132D)), ((float)(216D)), ((float)(28D)), ((float)(0D)));
			this.pipe2.InnerColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.pipe2.Name = "pipe2";
			this.pipe2.OuterColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.pipe2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(160D, 216D),
			new NxtControl.Drawing.PointF(132D, 216D)});
			this.pipe2.Width = 10;
			// 
			// pipe1
			// 
			this.pipe1.Bounds = new NxtControl.Drawing.RectF(((float)(132D)), ((float)(96D)), ((float)(28D)), ((float)(0D)));
			this.pipe1.InnerColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.pipe1.Name = "pipe1";
			this.pipe1.OuterColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.pipe1.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(160D, 96D),
			new NxtControl.Drawing.PointF(132D, 96D)});
			this.pipe1.Width = 10;
			// 
			// pipe3
			// 
			this.pipe3.Bounds = new NxtControl.Drawing.RectF(((float)(520D)), ((float)(96D)), ((float)(28D)), ((float)(0D)));
			this.pipe3.InnerColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.pipe3.Name = "pipe3";
			this.pipe3.OuterColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.pipe3.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(520D, 96D),
			new NxtControl.Drawing.PointF(548D, 96D)});
			this.pipe3.Width = 10;
			// 
			// pipe4
			// 
			this.pipe4.Bounds = new NxtControl.Drawing.RectF(((float)(520D)), ((float)(240D)), ((float)(28D)), ((float)(0D)));
			this.pipe4.InnerColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.pipe4.Name = "pipe4";
			this.pipe4.OuterColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.pipe4.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(520D, 240D),
			new NxtControl.Drawing.PointF(548D, 240D)});
			this.pipe4.Width = 10;
			// 
			// polygon5
			// 
			this.polygon5.Bounds = new NxtControl.Drawing.RectF(((float)(160D)), ((float)(56D)), ((float)(368D)), ((float)(216D)));
			this.polygon5.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(186)), ((byte)(186)), ((byte)(186))));
			this.polygon5.Closed = true;
			this.polygon5.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.polygon5.Name = "polygon5";
			this.polygon5.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(160D, 216D),
			new NxtControl.Drawing.PointF(160D, 208D),
			new NxtControl.Drawing.PointF(160D, 272D),
			new NxtControl.Drawing.PointF(528D, 272D),
			new NxtControl.Drawing.PointF(528D, 56D),
			new NxtControl.Drawing.PointF(160D, 56D),
			new NxtControl.Drawing.PointF(160D, 216D),
			new NxtControl.Drawing.PointF(176D, 216D),
			new NxtControl.Drawing.PointF(176D, 72D),
			new NxtControl.Drawing.PointF(512D, 72D),
			new NxtControl.Drawing.PointF(512D, 256D),
			new NxtControl.Drawing.PointF(176D, 256D),
			new NxtControl.Drawing.PointF(176D, 216D)});
			// 
			// line4
			// 
			this.line4.EndPoint = new NxtControl.Drawing.PointF(512D, 248D);
			this.line4.Name = "line4";
			this.line4.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line4.StartPoint = new NxtControl.Drawing.PointF(168D, 216D);
			// 
			// HiHiLevel
			// 
			this.HiHiLevel.Bounds = new NxtControl.Drawing.RectF(((float)(175D)), ((float)(72D)), ((float)(338D)), ((float)(184D)));
			this.HiHiLevel.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("transparent"));
			this.HiHiLevel.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.HiHiLevel.Name = "HiHiLevel";
			this.HiHiLevel.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.BlinkColor("SE.Nereda.DevLEDRedFlash"), 4F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// pipe5
			// 
			this.pipe5.Bounds = new NxtControl.Drawing.RectF(((float)(552D)), ((float)(240D)), ((float)(88D)), ((float)(0D)));
			this.pipe5.InnerColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.pipe5.Name = "pipe5";
			this.pipe5.OuterColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.pipe5.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(552D, 240D),
			new NxtControl.Drawing.PointF(640D, 240D)});
			this.pipe5.Width = 10;
			// 
			// pipe6
			// 
			this.pipe6.Bounds = new NxtControl.Drawing.RectF(((float)(552D)), ((float)(96D)), ((float)(248D)), ((float)(0D)));
			this.pipe6.InnerColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.pipe6.Name = "pipe6";
			this.pipe6.OuterColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.pipe6.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(552D, 96D),
			new NxtControl.Drawing.PointF(800D, 96D)});
			this.pipe6.Width = 10;
			// 
			// line6
			// 
			this.line6.EndPoint = new NxtControl.Drawing.PointF(552D, 104D);
			this.line6.Name = "line6";
			this.line6.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 3F, NxtControl.Drawing.DashStyle.Solid);
			this.line6.StartPoint = new NxtControl.Drawing.PointF(552D, 88D);
			// 
			// polygon1
			// 
			this.polygon1.Bounds = new NxtControl.Drawing.RectF(((float)(644D)), ((float)(91D)), ((float)(13D)), ((float)(10D)));
			this.polygon1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			this.polygon1.Closed = true;
			this.polygon1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.polygon1.Name = "polygon1";
			this.polygon1.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(644D, 96D),
			new NxtControl.Drawing.PointF(657D, 91D),
			new NxtControl.Drawing.PointF(657D, 101D)});
			// 
			// 
			// pipe8
			// 
			this.pipe8.Bounds = new NxtControl.Drawing.RectF(((float)(752D)), ((float)(98D)), ((float)(0D)), ((float)(14D)));
			this.pipe8.InnerColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.pipe8.Name = "pipe8";
			this.pipe8.OuterColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.pipe8.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(752D, 98D),
			new NxtControl.Drawing.PointF(752D, 112D)});
			this.pipe8.Width = 10;
			// 
			// polyline1
			// 
			this.polyline1.Bounds = new NxtControl.Drawing.RectF(((float)(740D)), ((float)(152D)), ((float)(24D)), ((float)(8D)));
			this.polyline1.Closed = false;
			this.polyline1.Name = "polyline1";
			this.polyline1.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(740D, 152D),
			new NxtControl.Drawing.PointF(740D, 160D),
			new NxtControl.Drawing.PointF(764D, 160D),
			new NxtControl.Drawing.PointF(764D, 152D)});
			// 
			// CV001
			// 
			this.CV001.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.CV001.Font = new NxtControl.Drawing.Font("LabelFont");
			this.CV001.Location = new NxtControl.Drawing.PointF(600D, 256D);
			this.CV001.Name = "CV001";
			this.CV001.Text = "NVPP 001 a-- 029";
			// 
			// XV001
			// 
			this.XV001.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.XV001.Font = new NxtControl.Drawing.Font("LabelFont");
			this.XV001.Location = new NxtControl.Drawing.PointF(700D, 166D);
			this.XV001.Name = "XV001";
			this.XV001.Text = "NVPP 001 a-- 028";
			// 
			// pipe7
			// 
			this.pipe7.Bounds = new NxtControl.Drawing.RectF(((float)(40D)), ((float)(216D)), ((float)(88D)), ((float)(0D)));
			this.pipe7.InnerColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.pipe7.Name = "pipe7";
			this.pipe7.OuterColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.pipe7.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(40D, 216D),
			new NxtControl.Drawing.PointF(128D, 216D)});
			this.pipe7.Width = 10;
			// 
			// line8
			// 
			this.line8.EndPoint = new NxtControl.Drawing.PointF(128D, 224D);
			this.line8.Name = "line8";
			this.line8.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 3F, NxtControl.Drawing.DashStyle.Solid);
			this.line8.StartPoint = new NxtControl.Drawing.PointF(128D, 208D);
			// 
			// polygon3
			// 
			this.polygon3.Bounds = new NxtControl.Drawing.RectF(((float)(80D)), ((float)(211D)), ((float)(13D)), ((float)(10D)));
			this.polygon3.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			this.polygon3.Closed = true;
			this.polygon3.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.polygon3.Name = "polygon3";
			this.polygon3.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(80D, 211D),
			new NxtControl.Drawing.PointF(80D, 221D),
			new NxtControl.Drawing.PointF(93D, 216D)});
			// 
			// pipe11
			// 
			this.pipe11.Bounds = new NxtControl.Drawing.RectF(((float)(664D)), ((float)(240D)), ((float)(40D)), ((float)(0D)));
			this.pipe11.InnerColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.pipe11.Name = "pipe11";
			this.pipe11.OuterColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.pipe11.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(664D, 240D),
			new NxtControl.Drawing.PointF(704D, 240D)});
			this.pipe11.Width = 10;
			// 
			// line5
			// 
			this.line5.EndPoint = new NxtControl.Drawing.PointF(552D, 248D);
			this.line5.Name = "line5";
			this.line5.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 3F, NxtControl.Drawing.DashStyle.Solid);
			this.line5.StartPoint = new NxtControl.Drawing.PointF(552D, 232D);
			// 
			// polygon2
			// 
			this.polygon2.Bounds = new NxtControl.Drawing.RectF(((float)(580D)), ((float)(235D)), ((float)(13D)), ((float)(10D)));
			this.polygon2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			this.polygon2.Closed = true;
			this.polygon2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.polygon2.Name = "polygon2";
			this.polygon2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(580D, 235D),
			new NxtControl.Drawing.PointF(580D, 245D),
			new NxtControl.Drawing.PointF(593D, 240D)});
			// 
			// pipe10
			// 
			this.pipe10.Bounds = new NxtControl.Drawing.RectF(((float)(40D)), ((float)(96D)), ((float)(88D)), ((float)(0D)));
			this.pipe10.InnerColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.pipe10.Name = "pipe10";
			this.pipe10.OuterColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.pipe10.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(40D, 96D),
			new NxtControl.Drawing.PointF(128D, 96D)});
			this.pipe10.Width = 10;
			// 
			// line10
			// 
			this.line10.EndPoint = new NxtControl.Drawing.PointF(128D, 104D);
			this.line10.Name = "line10";
			this.line10.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 3F, NxtControl.Drawing.DashStyle.Solid);
			this.line10.StartPoint = new NxtControl.Drawing.PointF(128D, 88D);
			// 
			// polygon4
			// 
			this.polygon4.Bounds = new NxtControl.Drawing.RectF(((float)(80D)), ((float)(91D)), ((float)(13D)), ((float)(10D)));
			this.polygon4.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			this.polygon4.Closed = true;
			this.polygon4.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.polygon4.Name = "polygon4";
			this.polygon4.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(80D, 96D),
			new NxtControl.Drawing.PointF(93D, 91D),
			new NxtControl.Drawing.PointF(93D, 101D)});
			// 
			// line7
			// 
			this.line7.EndPoint = new NxtControl.Drawing.PointF(132D, 224D);
			this.line7.Name = "line7";
			this.line7.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 4F, NxtControl.Drawing.DashStyle.Solid);
			this.line7.StartPoint = new NxtControl.Drawing.PointF(132D, 208D);
			// 
			// line1
			// 
			this.line1.EndPoint = new NxtControl.Drawing.PointF(132D, 104D);
			this.line1.Name = "line1";
			this.line1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 4F, NxtControl.Drawing.DashStyle.Solid);
			this.line1.StartPoint = new NxtControl.Drawing.PointF(132D, 88D);
			// 
			// line3
			// 
			this.line3.EndPoint = new NxtControl.Drawing.PointF(548D, 248D);
			this.line3.Name = "line3";
			this.line3.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 4F, NxtControl.Drawing.DashStyle.Solid);
			this.line3.StartPoint = new NxtControl.Drawing.PointF(548D, 232D);
			// 
			// line2
			// 
			this.line2.EndPoint = new NxtControl.Drawing.PointF(548D, 104D);
			this.line2.Name = "line2";
			this.line2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 4F, NxtControl.Drawing.DashStyle.Solid);
			this.line2.StartPoint = new NxtControl.Drawing.PointF(548D, 88D);
			// 
			// pipe9
			// 
			this.pipe9.Bounds = new NxtControl.Drawing.RectF(((float)(344D)), ((float)(40D)), ((float)(0D)), ((float)(16D)));
			this.pipe9.InnerColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.pipe9.Name = "pipe9";
			this.pipe9.OuterColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.pipe9.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(344D, 56D),
			new NxtControl.Drawing.PointF(344D, 40D)});
			this.pipe9.Width = 10;
			// 
			// line9
			// 
			this.line9.EndPoint = new NxtControl.Drawing.PointF(336D, 40D);
			this.line9.Name = "line9";
			this.line9.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 4F, NxtControl.Drawing.DashStyle.Solid);
			this.line9.StartPoint = new NxtControl.Drawing.PointF(352D, 40D);
			// 
			// HiHiTxt
			// 
			this.HiHiTxt.Color = new NxtControl.Drawing.BlinkColor("SE.Nereda.DevLEDRedFlash");
			this.HiHiTxt.Font = new NxtControl.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
			this.HiHiTxt.Location = new NxtControl.Drawing.PointF(192D, 280D);
			this.HiHiTxt.Name = "HiHiTxt";
			this.HiHiTxt.Text = "Sludge Buffer - High High Level";
			// 
			// freeText1
			// 
			this.freeText1.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText1.Font = new NxtControl.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
			this.freeText1.Location = new NxtControl.Drawing.PointF(292D, 154D);
			this.freeText1.Name = "freeText1";
			this.freeText1.Text = "Sludge Buffer";
			// 
			// group1
			// 
			this.group1.BeginInit();
			this.group1.Name = "group1";
			this.group1.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.ShowLevel,
			this.pipe2,
			this.pipe1,
			this.pipe3,
			this.pipe4,
			this.polygon5,
			this.line4,
			this.pipe5,
			this.pipe6,
			this.line6,
			this.polygon1,
			this.pipe8,
			this.polyline1,
			this.CV001,
			this.XV001,
			this.pipe7,
			this.line8,
			this.polygon3,
			this.pipe11,
			this.line5,
			this.polygon2,
			this.pipe10,
			this.line10,
			this.polygon4,
			this.line7,
			this.line1,
			this.line3,
			this.line2,
			this.pipe9,
			this.line9,
			this.HiHiTxt,
			this.freeText1,
			this.HiHiLevel});
			this.group1.EndInit();
			// 
			// sSLB
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.group1});
			this.SymbolSize = new System.Drawing.Size(864, 344);

		}
		private NxtControl.GuiFramework.Rectangle ShowLevel;
		private NxtControl.GuiFramework.Pipe pipe2;
		private NxtControl.GuiFramework.Pipe pipe1;
		private NxtControl.GuiFramework.Pipe pipe3;
		private NxtControl.GuiFramework.Pipe pipe4;
		private NxtControl.GuiFramework.Polygon polygon5;
		private NxtControl.GuiFramework.Line line4;
		private NxtControl.GuiFramework.Rectangle HiHiLevel;
		private NxtControl.GuiFramework.Pipe pipe5;
		private NxtControl.GuiFramework.Pipe pipe6;
		private NxtControl.GuiFramework.Line line6;
		private NxtControl.GuiFramework.Polygon polygon1;
		private NxtControl.GuiFramework.Pipe pipe8;
		private NxtControl.GuiFramework.Polyline polyline1;
		private NxtControl.GuiFramework.FreeText CV001;
		private NxtControl.GuiFramework.FreeText XV001;
		private NxtControl.GuiFramework.Pipe pipe7;
		private NxtControl.GuiFramework.Line line8;
		private NxtControl.GuiFramework.Polygon polygon3;
		private NxtControl.GuiFramework.Pipe pipe11;
		private NxtControl.GuiFramework.Line line5;
		private NxtControl.GuiFramework.Polygon polygon2;
		private NxtControl.GuiFramework.Pipe pipe10;
		private NxtControl.GuiFramework.Line line10;
		private NxtControl.GuiFramework.Polygon polygon4;
		private NxtControl.GuiFramework.Line line7;
		private NxtControl.GuiFramework.Line line1;
		private NxtControl.GuiFramework.Line line3;
		private NxtControl.GuiFramework.Line line2;
		private NxtControl.GuiFramework.Pipe pipe9;
		private NxtControl.GuiFramework.Line line9;
		private NxtControl.GuiFramework.FreeText HiHiTxt;
		private NxtControl.GuiFramework.FreeText freeText1;
		private NxtControl.GuiFramework.Group group1;
		#endregion
	}
}
