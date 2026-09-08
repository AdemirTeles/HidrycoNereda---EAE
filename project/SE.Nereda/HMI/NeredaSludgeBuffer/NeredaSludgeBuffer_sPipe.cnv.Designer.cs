/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 6/29/2026
 * Time: 5:44 PM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.NeredaSludgeBuffer
{
	/// <summary>
	/// Summary description for sPipe.
	/// </summary>
	partial class sPipe
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.pipe8 = new NxtControl.GuiFramework.Pipe();
			this.polyline1 = new NxtControl.GuiFramework.Polyline();
			this.XV001 = new NxtControl.GuiFramework.FreeText();
			this.sPump1 = new SE.Nereda.Symbols.Motor_VS.sPump();
			this.sDefault1 = new SE.Nereda.Symbols.MotorS.sDefault();
			this.pipe1 = new NxtControl.GuiFramework.Pipe();
			this.XV004 = new NxtControl.GuiFramework.FreeText();
			this.polygon2 = new NxtControl.GuiFramework.Polygon();
			this.pipe2 = new NxtControl.GuiFramework.Pipe();
			this.rectangle1 = new NxtControl.GuiFramework.Rectangle();
			this.line1 = new NxtControl.GuiFramework.Line();
			this.line2 = new NxtControl.GuiFramework.Line();
			this.rectangle2 = new NxtControl.GuiFramework.Rectangle();
			this.rectangle3 = new NxtControl.GuiFramework.Rectangle();
			this.group1 = new NxtControl.GuiFramework.Group();
			this.freeText1 = new NxtControl.GuiFramework.FreeText();
			this.freeText2 = new NxtControl.GuiFramework.FreeText();
			this.polygon13 = new NxtControl.GuiFramework.Polygon();
			this.polygon14 = new NxtControl.GuiFramework.Polygon();
			this.line22 = new NxtControl.GuiFramework.Line();
			this.line23 = new NxtControl.GuiFramework.Line();
			this.group13 = new NxtControl.GuiFramework.Group();
			this.polygon1 = new NxtControl.GuiFramework.Polygon();
			this.line3 = new NxtControl.GuiFramework.Line();
			this.line4 = new NxtControl.GuiFramework.Line();
			// 
			// pipe8
			// 
			this.pipe8.Bounds = new NxtControl.Drawing.RectF(((float)(488D)), ((float)(98D)), ((float)(0D)), ((float)(14D)));
			this.pipe8.InnerColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.pipe8.Name = "pipe8";
			this.pipe8.OuterColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.pipe8.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(488D, 98D),
			new NxtControl.Drawing.PointF(488D, 112D)});
			this.pipe8.Width = 10;
			// 
			// polyline1
			// 
			this.polyline1.Bounds = new NxtControl.Drawing.RectF(((float)(476D)), ((float)(152D)), ((float)(24D)), ((float)(8D)));
			this.polyline1.Closed = false;
			this.polyline1.Name = "polyline1";
			this.polyline1.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(476D, 152D),
			new NxtControl.Drawing.PointF(476D, 160D),
			new NxtControl.Drawing.PointF(500D, 160D),
			new NxtControl.Drawing.PointF(500D, 152D)});
			// 
			// XV001
			// 
			this.XV001.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.XV001.Font = new NxtControl.Drawing.Font("LabelFont");
			this.XV001.Location = new NxtControl.Drawing.PointF(436D, 166D);
			this.XV001.Name = "XV001";
			this.XV001.Text = "NVPP 001 a-- 062";
			// 
			// sPump1
			// 
			this.sPump1.BeginInit();
			this.sPump1._iMotName = "Motor";
			this.sPump1._iUnit = "%";
			this.sPump1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 288D, 59D);
			this.sPump1.Name = "sPump1";
			this.sPump1.SecurityToken = ((uint)(4294967295u));
			this.sPump1.SymbolNameDisplay = SE.Nereda.Symbols.Motor_VS.sPump.SymbolNameDisplayOption.Hide;
			this.sPump1.TagName = "Actuators.NVPP_001_sbp_001";
			this.sPump1.EndInit();
			// 
			// sDefault1
			// 
			this.sDefault1.BeginInit();
			this.sDefault1._iMotName = "Motor";
			this.sDefault1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 136D, 48D);
			this.sDefault1.Name = "sDefault1";
			this.sDefault1.SecurityToken = ((uint)(4294967295u));
			this.sDefault1.SymbolNameDisplay = SE.Nereda.Symbols.MotorS.sDefault.SymbolNameDisplayOption.Hide;
			this.sDefault1.TagName = "Actuators.NVPP_001_vsn_001";
			this.sDefault1.EndInit();
			// 
			// pipe1
			// 
			this.pipe1.Bounds = new NxtControl.Drawing.RectF(((float)(336D)), ((float)(96D)), ((float)(352D)), ((float)(0D)));
			this.pipe1.InnerColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.pipe1.Name = "pipe1";
			this.pipe1.OuterColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.pipe1.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(688D, 96D),
			new NxtControl.Drawing.PointF(336D, 96D)});
			this.pipe1.Width = 10;
			// 
			// XV004
			// 
			this.XV004.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.XV004.Font = new NxtControl.Drawing.Font("LabelFont");
			this.XV004.Location = new NxtControl.Drawing.PointF(560D, 108D);
			this.XV004.Name = "XV004";
			this.XV004.Text = "NVPP 001 a-- 031";
			// 
			// polygon2
			// 
			this.polygon2.Bounds = new NxtControl.Drawing.RectF(((float)(400D)), ((float)(88D)), ((float)(32D)), ((float)(16D)));
			this.polygon2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(245)), ((byte)(245)), ((byte)(245))));
			this.polygon2.Closed = true;
			this.polygon2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.polygon2.Name = "polygon2";
			this.polygon2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(400D, 104D),
			new NxtControl.Drawing.PointF(400D, 88D),
			new NxtControl.Drawing.PointF(432D, 96D)});
			// 
			// pipe2
			// 
			this.pipe2.Bounds = new NxtControl.Drawing.RectF(((float)(120D)), ((float)(118D)), ((float)(206D)), ((float)(0D)));
			this.pipe2.InnerColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.pipe2.Name = "pipe2";
			this.pipe2.OuterColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.pipe2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(326D, 118D),
			new NxtControl.Drawing.PointF(120D, 118D)});
			this.pipe2.Width = 10;
			// 
			// rectangle1
			// 
			this.rectangle1.Bounds = new NxtControl.Drawing.RectF(((float)(167D)), ((float)(104D)), ((float)(30D)), ((float)(32D)));
			this.rectangle1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle1.Name = "rectangle1";
			// 
			// line1
			// 
			this.line1.EndPoint = new NxtControl.Drawing.PointF(197D, 136D);
			this.line1.Name = "line1";
			this.line1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line1.StartPoint = new NxtControl.Drawing.PointF(167D, 104D);
			// 
			// line2
			// 
			this.line2.EndPoint = new NxtControl.Drawing.PointF(167D, 136D);
			this.line2.Name = "line2";
			this.line2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line2.StartPoint = new NxtControl.Drawing.PointF(197D, 104D);
			// 
			// rectangle2
			// 
			this.rectangle2.Bounds = new NxtControl.Drawing.RectF(((float)(197D)), ((float)(112D)), ((float)(24D)), ((float)(16D)));
			this.rectangle2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle2.Name = "rectangle2";
			// 
			// rectangle3
			// 
			this.rectangle3.Bounds = new NxtControl.Drawing.RectF(((float)(193D)), ((float)(113D)), ((float)(22D)), ((float)(14D)));
			this.rectangle3.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle3.Name = "rectangle3";
			this.rectangle3.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// group1
			// 
			this.group1.BeginInit();
			this.group1.Name = "group1";
			this.group1.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.rectangle2,
			this.rectangle1,
			this.line1,
			this.line2,
			this.rectangle3,
			this.sDefault1});
			this.group1.EndInit();
			// 
			// freeText1
			// 
			this.freeText1.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText1.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText1.Location = new NxtControl.Drawing.PointF(288D, 56D);
			this.freeText1.Name = "freeText1";
			this.freeText1.Text = "NVPP 001 sbp 001";
			// 
			// freeText2
			// 
			this.freeText2.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText2.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText2.Location = new NxtControl.Drawing.PointF(136D, 140D);
			this.freeText2.Name = "freeText2";
			this.freeText2.Text = "NVPP 001 vsn 001";
			// 
			// polygon13
			// 
			this.polygon13.Bounds = new NxtControl.Drawing.RectF(((float)(480D)), ((float)(112D)), ((float)(16D)), ((float)(20D)));
			this.polygon13.Brush = new NxtControl.Drawing.Brush(true);
			this.polygon13.Closed = true;
			this.polygon13.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.polygon13.Name = "polygon13";
			this.polygon13.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(496D, 112D),
			new NxtControl.Drawing.PointF(480D, 112D),
			new NxtControl.Drawing.PointF(488D, 132D)});
			// 
			// polygon14
			// 
			this.polygon14.Bounds = new NxtControl.Drawing.RectF(((float)(480D)), ((float)(132D)), ((float)(16D)), ((float)(20D)));
			this.polygon14.Brush = new NxtControl.Drawing.Brush(true);
			this.polygon14.Closed = true;
			this.polygon14.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.polygon14.Name = "polygon14";
			this.polygon14.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(496D, 152D),
			new NxtControl.Drawing.PointF(480D, 152D),
			new NxtControl.Drawing.PointF(488D, 132D)});
			// 
			// line22
			// 
			this.line22.EndPoint = new NxtControl.Drawing.PointF(508D, 124D);
			this.line22.Name = "line22";
			this.line22.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 3F, NxtControl.Drawing.DashStyle.Solid);
			this.line22.StartPoint = new NxtControl.Drawing.PointF(508D, 140D);
			// 
			// line23
			// 
			this.line23.EndPoint = new NxtControl.Drawing.PointF(488D, 132D);
			this.line23.Name = "line23";
			this.line23.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line23.StartPoint = new NxtControl.Drawing.PointF(508D, 132D);
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
			this.polygon1.Bounds = new NxtControl.Drawing.RectF(((float)(592D)), ((float)(88D)), ((float)(40D)), ((float)(16D)));
			this.polygon1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("transparent"));
			this.polygon1.Closed = true;
			this.polygon1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.polygon1.Name = "polygon1";
			this.polygon1.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(592D, 88D),
			new NxtControl.Drawing.PointF(592D, 104D),
			new NxtControl.Drawing.PointF(632D, 88D),
			new NxtControl.Drawing.PointF(632D, 104D)});
			// 
			// line3
			// 
			this.line3.EndPoint = new NxtControl.Drawing.PointF(612D, 80D);
			this.line3.Name = "line3";
			this.line3.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line3.StartPoint = new NxtControl.Drawing.PointF(612D, 96D);
			// 
			// line4
			// 
			this.line4.EndPoint = new NxtControl.Drawing.PointF(620D, 80D);
			this.line4.Name = "line4";
			this.line4.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.line4.StartPoint = new NxtControl.Drawing.PointF(604D, 80D);
			// 
			// sPipe
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.pipe2,
			this.pipe1,
			this.pipe8,
			this.polyline1,
			this.XV001,
			this.sPump1,
			this.XV004,
			this.polygon2,
			this.group1,
			this.freeText1,
			this.freeText2,
			this.group13,
			this.polygon1,
			this.line3,
			this.line4});
			this.SymbolSize = new System.Drawing.Size(856, 312);

		}
		private NxtControl.GuiFramework.Pipe pipe8;
		private NxtControl.GuiFramework.Polyline polyline1;
		private NxtControl.GuiFramework.FreeText XV001;
		private SE.Nereda.Symbols.Motor_VS.sPump sPump1;
		private SE.Nereda.Symbols.MotorS.sDefault sDefault1;
		private NxtControl.GuiFramework.Pipe pipe1;
		private NxtControl.GuiFramework.FreeText XV004;
		private NxtControl.GuiFramework.Polygon polygon2;
		private NxtControl.GuiFramework.Pipe pipe2;
		private NxtControl.GuiFramework.Rectangle rectangle1;
		private NxtControl.GuiFramework.Line line1;
		private NxtControl.GuiFramework.Line line2;
		private NxtControl.GuiFramework.Rectangle rectangle2;
		private NxtControl.GuiFramework.Rectangle rectangle3;
		private NxtControl.GuiFramework.Group group1;
		private NxtControl.GuiFramework.FreeText freeText1;
		private NxtControl.GuiFramework.FreeText freeText2;
		private NxtControl.GuiFramework.Polygon polygon13;
		private NxtControl.GuiFramework.Polygon polygon14;
		private NxtControl.GuiFramework.Line line22;
		private NxtControl.GuiFramework.Line line23;
		private NxtControl.GuiFramework.Group group13;
		private NxtControl.GuiFramework.Polygon polygon1;
		private NxtControl.GuiFramework.Line line3;
		private NxtControl.GuiFramework.Line line4;
		#endregion
	}
}
