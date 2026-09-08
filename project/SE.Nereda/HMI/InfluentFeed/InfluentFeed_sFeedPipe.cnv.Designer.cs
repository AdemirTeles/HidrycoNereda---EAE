/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 6/17/2026
 * Time: 10:04 AM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.InfluentFeed
{
	/// <summary>
	/// Summary description for sFeedPipe.
	/// </summary>
	partial class sFeedPipe
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.polyline1 = new NxtControl.GuiFramework.Polyline();
			this.line1 = new NxtControl.GuiFramework.Line();
			this.pipe14 = new NxtControl.GuiFramework.Pipe();
			this.sPump1 = new SE.Nereda.Symbols.Motor_VS.sPump();
			this.PUMP001 = new NxtControl.GuiFramework.FreeText();
			this.XV005 = new NxtControl.GuiFramework.FreeText();
			this.XV006 = new NxtControl.GuiFramework.FreeText();
			this.group2 = new NxtControl.GuiFramework.Group();
			this.pipe15 = new NxtControl.GuiFramework.Pipe();
			this.XV063 = new NxtControl.GuiFramework.FreeText();
			this.ellipse1 = new NxtControl.GuiFramework.Ellipse();
			this.sDisplayPv41 = new SE.Nereda.Symbols.AnalogInput.sDisplayPv4();
			this.FT001 = new NxtControl.GuiFramework.FreeText();
			this.line9 = new NxtControl.GuiFramework.Line();
			this.line10 = new NxtControl.GuiFramework.Line();
			this.line13 = new NxtControl.GuiFramework.Line();
			this.polygon4 = new NxtControl.GuiFramework.Polygon();
			this.pipe1 = new NxtControl.GuiFramework.Pipe();
			this.sPID1 = new SE.Nereda.Symbols.FeedReactorLogic.sPID();
			this.polygon13 = new NxtControl.GuiFramework.Polygon();
			this.polygon14 = new NxtControl.GuiFramework.Polygon();
			this.line22 = new NxtControl.GuiFramework.Line();
			this.line23 = new NxtControl.GuiFramework.Line();
			this.group13 = new NxtControl.GuiFramework.Group();
			this.polygon1 = new NxtControl.GuiFramework.Polygon();
			this.line2 = new NxtControl.GuiFramework.Line();
			this.line3 = new NxtControl.GuiFramework.Line();
			this.group1 = new NxtControl.GuiFramework.Group();
			// 
			// polyline1
			// 
			this.polyline1.Bounds = new NxtControl.Drawing.RectF(((float)(388D)), ((float)(132D)), ((float)(24D)), ((float)(8D)));
			this.polyline1.Closed = false;
			this.polyline1.Name = "polyline1";
			this.polyline1.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(388D, 132D),
			new NxtControl.Drawing.PointF(388D, 140D),
			new NxtControl.Drawing.PointF(412D, 140D),
			new NxtControl.Drawing.PointF(412D, 132D)});
			// 
			// line1
			// 
			this.line1.EndPoint = new NxtControl.Drawing.PointF(472D, 168D);
			this.line1.Name = "line1";
			this.line1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Dash);
			this.line1.StartPoint = new NxtControl.Drawing.PointF(472D, 96D);
			// 
			// pipe14
			// 
			this.pipe14.Bounds = new NxtControl.Drawing.RectF(((float)(200D)), ((float)(83D)), ((float)(280D)), ((float)(0D)));
			this.pipe14.InnerColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.pipe14.Name = "pipe14";
			this.pipe14.OuterColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.pipe14.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(200D, 83D),
			new NxtControl.Drawing.PointF(480D, 83D)});
			this.pipe14.Width = 10;
			// 
			// sPump1
			// 
			this.sPump1.BeginInit();
			this.sPump1._iMotName = "Motor";
			this.sPump1._iUnit = "%";
			this.sPump1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 140D, 45D);
			this.sPump1.Name = "sPump1";
			this.sPump1.SecurityToken = ((uint)(4294967295u));
			this.sPump1.SymbolNameDisplay = SE.Nereda.Symbols.Motor_VS.sPump.SymbolNameDisplayOption.Hide;
			this.sPump1.TagName = "Actuators.FeedReactorPump01";
			this.sPump1.EndInit();
			// 
			// PUMP001
			// 
			this.PUMP001.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.PUMP001.Font = new NxtControl.Drawing.Font("LabelFont");
			this.PUMP001.Location = new NxtControl.Drawing.PointF(144D, 48D);
			this.PUMP001.Name = "PUMP001";
			this.PUMP001.Text = "NVPP 001 a-- 003";
			// 
			// XV005
			// 
			this.XV005.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.XV005.Font = new NxtControl.Drawing.Font("LabelFont");
			this.XV005.Location = new NxtControl.Drawing.PointF(48D, 120D);
			this.XV005.Name = "XV005";
			this.XV005.Text = "NVPP 001 a-- 005";
			// 
			// XV006
			// 
			this.XV006.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.XV006.Font = new NxtControl.Drawing.Font("LabelFont");
			this.XV006.Location = new NxtControl.Drawing.PointF(282D, 92D);
			this.XV006.Name = "XV006";
			this.XV006.Text = "NVPP 001 a-- 006";
			// 
			// group2
			// 
			this.group2.BeginInit();
			this.group2.Name = "group2";
			this.group2.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.polyline1});
			this.group2.EndInit();
			// 
			// pipe15
			// 
			this.pipe15.Bounds = new NxtControl.Drawing.RectF(((float)(400D)), ((float)(80D)), ((float)(0D)), ((float)(16D)));
			this.pipe15.InnerColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.pipe15.Name = "pipe15";
			this.pipe15.OuterColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.pipe15.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(400D, 96D),
			new NxtControl.Drawing.PointF(400D, 80D)});
			this.pipe15.Width = 10;
			// 
			// XV063
			// 
			this.XV063.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.XV063.Font = new NxtControl.Drawing.Font("LabelFont");
			this.XV063.Location = new NxtControl.Drawing.PointF(352D, 144D);
			this.XV063.Name = "XV063";
			this.XV063.Text = "NVPP 001 a-- 063";
			// 
			// ellipse1
			// 
			this.ellipse1.Bounds = new NxtControl.Drawing.RectF(((float)(395D)), ((float)(78D)), ((float)(10D)), ((float)(10D)));
			this.ellipse1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			this.ellipse1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.ellipse1.Name = "ellipse1";
			// 
			// sDisplayPv41
			// 
			this.sDisplayPv41.BeginInit();
			this.sDisplayPv41._iUnit = "m³/h";
			this.sDisplayPv41.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 424D, 67D);
			this.sDisplayPv41.Name = "sDisplayPv41";
			this.sDisplayPv41.SecurityToken = ((uint)(4294967295u));
			this.sDisplayPv41.TagName = "Sensors.FeedReactorFlowPv";
			this.sDisplayPv41.EndInit();
			// 
			// FT001
			// 
			this.FT001.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.FT001.Font = new NxtControl.Drawing.Font("LabelFont");
			this.FT001.Location = new NxtControl.Drawing.PointF(424D, 48D);
			this.FT001.Name = "FT001";
			this.FT001.Text = "NVPP 001 a-- 006";
			// 
			// line9
			// 
			this.line9.EndPoint = new NxtControl.Drawing.PointF(264D, 120D);
			this.line9.Name = "line9";
			this.line9.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Dash);
			this.line9.StartPoint = new NxtControl.Drawing.PointF(248D, 120D);
			// 
			// line10
			// 
			this.line10.EndPoint = new NxtControl.Drawing.PointF(264D, 168D);
			this.line10.Name = "line10";
			this.line10.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Dash);
			this.line10.StartPoint = new NxtControl.Drawing.PointF(264D, 120D);
			// 
			// line13
			// 
			this.line13.EndPoint = new NxtControl.Drawing.PointF(264D, 168D);
			this.line13.Name = "line13";
			this.line13.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Dash);
			this.line13.StartPoint = new NxtControl.Drawing.PointF(472D, 168D);
			// 
			// polygon4
			// 
			this.polygon4.Bounds = new NxtControl.Drawing.RectF(((float)(248D)), ((float)(118D)), ((float)(8D)), ((float)(4D)));
			this.polygon4.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			this.polygon4.Closed = true;
			this.polygon4.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.polygon4.Name = "polygon4";
			this.polygon4.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(248D, 120D),
			new NxtControl.Drawing.PointF(256D, 118D),
			new NxtControl.Drawing.PointF(256D, 122D)});
			// 
			// pipe1
			// 
			this.pipe1.Bounds = new NxtControl.Drawing.RectF(((float)(32D)), ((float)(104D)), ((float)(136D)), ((float)(0D)));
			this.pipe1.InnerColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.pipe1.Name = "pipe1";
			this.pipe1.OuterColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.pipe1.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(168D, 104D),
			new NxtControl.Drawing.PointF(32D, 104D)});
			this.pipe1.Width = 10;
			// 
			// sPID1
			// 
			this.sPID1.BeginInit();
			this.sPID1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 288D, 152D);
			this.sPID1.Name = "sPID1";
			this.sPID1.SecurityToken = ((uint)(4294967295u));
			this.sPID1.TagName = "InfluentFeedLogic.Drain_InfluentFeed";
			this.sPID1.EndInit();
			// 
			// polygon13
			// 
			this.polygon13.Bounds = new NxtControl.Drawing.RectF(((float)(392D)), ((float)(96D)), ((float)(16D)), ((float)(20D)));
			this.polygon13.Brush = new NxtControl.Drawing.Brush(true);
			this.polygon13.Closed = true;
			this.polygon13.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.polygon13.Name = "polygon13";
			this.polygon13.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(408D, 96D),
			new NxtControl.Drawing.PointF(392D, 96D),
			new NxtControl.Drawing.PointF(400D, 116D)});
			// 
			// polygon14
			// 
			this.polygon14.Bounds = new NxtControl.Drawing.RectF(((float)(392D)), ((float)(116D)), ((float)(16D)), ((float)(20D)));
			this.polygon14.Brush = new NxtControl.Drawing.Brush(true);
			this.polygon14.Closed = true;
			this.polygon14.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.polygon14.Name = "polygon14";
			this.polygon14.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(408D, 136D),
			new NxtControl.Drawing.PointF(392D, 136D),
			new NxtControl.Drawing.PointF(400D, 116D)});
			// 
			// line22
			// 
			this.line22.EndPoint = new NxtControl.Drawing.PointF(420D, 108D);
			this.line22.Name = "line22";
			this.line22.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 3F, NxtControl.Drawing.DashStyle.Solid);
			this.line22.StartPoint = new NxtControl.Drawing.PointF(420D, 124D);
			// 
			// line23
			// 
			this.line23.EndPoint = new NxtControl.Drawing.PointF(400D, 116D);
			this.line23.Name = "line23";
			this.line23.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line23.StartPoint = new NxtControl.Drawing.PointF(420D, 116D);
			// 
			// group13
			// 
			this.group13.BeginInit();
			this.group13.Name = "group13";
			this.group13.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.polygon13,
			this.polygon14,
			this.line22,
			this.line23});
			this.group13.EndInit();
			// 
			// polygon1
			// 
			this.polygon1.Bounds = new NxtControl.Drawing.RectF(((float)(72D)), ((float)(96D)), ((float)(48D)), ((float)(16D)));
			this.polygon1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("transparent"));
			this.polygon1.Closed = true;
			this.polygon1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.polygon1.Name = "polygon1";
			this.polygon1.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(72D, 96D),
			new NxtControl.Drawing.PointF(72D, 112D),
			new NxtControl.Drawing.PointF(120D, 96D),
			new NxtControl.Drawing.PointF(120D, 112D)});
			// 
			// line2
			// 
			this.line2.EndPoint = new NxtControl.Drawing.PointF(96D, 80D);
			this.line2.Name = "line2";
			this.line2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line2.StartPoint = new NxtControl.Drawing.PointF(96D, 104D);
			// 
			// line3
			// 
			this.line3.EndPoint = new NxtControl.Drawing.PointF(104D, 80D);
			this.line3.Name = "line3";
			this.line3.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 4F, NxtControl.Drawing.DashStyle.Solid);
			this.line3.StartPoint = new NxtControl.Drawing.PointF(88D, 80D);
			// 
			// group1
			// 
			this.group1.BeginInit();
			this.group1.Name = "group1";
			this.group1.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.group13,
			this.pipe1,
			this.line1,
			this.pipe14,
			this.sPump1,
			this.PUMP001,
			this.XV005,
			this.XV006,
			this.group2,
			this.pipe15,
			this.XV063,
			this.ellipse1,
			this.sDisplayPv41,
			this.FT001,
			this.line9,
			this.line10,
			this.line13,
			this.polygon4,
			this.sPID1,
			this.polygon1,
			this.line2,
			this.line3});
			this.group1.EndInit();
			// 
			// sFeedPipe
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.group1});
			this.SymbolSize = new System.Drawing.Size(608, 216);

		}
		private NxtControl.GuiFramework.Polyline polyline1;
		private NxtControl.GuiFramework.Line line1;
		private NxtControl.GuiFramework.Pipe pipe14;
		private SE.Nereda.Symbols.Motor_VS.sPump sPump1;
		private NxtControl.GuiFramework.FreeText PUMP001;
		private NxtControl.GuiFramework.FreeText XV005;
		private NxtControl.GuiFramework.FreeText XV006;
		private NxtControl.GuiFramework.Group group2;
		private NxtControl.GuiFramework.Pipe pipe15;
		private NxtControl.GuiFramework.FreeText XV063;
		private NxtControl.GuiFramework.Ellipse ellipse1;
		private SE.Nereda.Symbols.AnalogInput.sDisplayPv4 sDisplayPv41;
		private NxtControl.GuiFramework.FreeText FT001;
		private NxtControl.GuiFramework.Line line9;
		private NxtControl.GuiFramework.Line line10;
		private NxtControl.GuiFramework.Line line13;
		private NxtControl.GuiFramework.Polygon polygon4;
		private NxtControl.GuiFramework.Pipe pipe1;
		private SE.Nereda.Symbols.FeedReactorLogic.sPID sPID1;
		private NxtControl.GuiFramework.Polygon polygon13;
		private NxtControl.GuiFramework.Polygon polygon14;
		private NxtControl.GuiFramework.Line line22;
		private NxtControl.GuiFramework.Line line23;
		private NxtControl.GuiFramework.Group group13;
		private NxtControl.GuiFramework.Polygon polygon1;
		private NxtControl.GuiFramework.Line line2;
		private NxtControl.GuiFramework.Line line3;
		private NxtControl.GuiFramework.Group group1;
		#endregion
	}
}
