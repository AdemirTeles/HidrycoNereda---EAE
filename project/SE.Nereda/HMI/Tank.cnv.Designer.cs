/*
 * Created by EcoStruxure Automation Expert.
 * User: Schneider
 * Date: 4/26/2024
 * Time: 1:27 PM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using NxtControl.GuiFramework;

namespace SchneiderElectric.NeredaLibrary.Graphics
{
	/// <summary>
	/// Summary description for Tank.
	/// </summary>
	partial class Tank
	{
		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.rectangle10 = new NxtControl.GuiFramework.Rectangle();
			this.rectangle2 = new NxtControl.GuiFramework.Rectangle();
			this.line8 = new NxtControl.GuiFramework.Line();
			this.line9 = new NxtControl.GuiFramework.Line();
			this.line10 = new NxtControl.GuiFramework.Line();
			this.line11 = new NxtControl.GuiFramework.Line();
			this.group5 = new NxtControl.GuiFramework.Group();
			this.group6 = new NxtControl.GuiFramework.Group();
			this.line2 = new NxtControl.GuiFramework.Line();
			this.line3 = new NxtControl.GuiFramework.Line();
			this.line4 = new NxtControl.GuiFramework.Line();
			this.line5 = new NxtControl.GuiFramework.Line();
			this.line6 = new NxtControl.GuiFramework.Line();
			this.line7 = new NxtControl.GuiFramework.Line();
			this.group2 = new NxtControl.GuiFramework.Group();
			this.group3 = new NxtControl.GuiFramework.Group();
			this.group4 = new NxtControl.GuiFramework.Group();
			this.line12 = new NxtControl.GuiFramework.Line();
			this.manualValveVertRight2 = new SchneiderElectric.NeredaLibrary.Graphics.ManualValveVertRight();
			this.polyline7 = new NxtControl.GuiFramework.Polyline();
			this.line1 = new NxtControl.GuiFramework.Line();
			this.manualValveVertRight1 = new SchneiderElectric.NeredaLibrary.Graphics.ManualValveVertRight();
			this.polyline1 = new NxtControl.GuiFramework.Polyline();
			this.line13 = new NxtControl.GuiFramework.Line();
			this.manualValveVertRight3 = new SchneiderElectric.NeredaLibrary.Graphics.ManualValveVertRight();
			this.polyline2 = new NxtControl.GuiFramework.Polyline();
			// 
			// rectangle10
			// 
			this.rectangle10.Bounds = new NxtControl.Drawing.RectF(((float)(180D)), ((float)(40D)), ((float)(200D)), ((float)(300D)));
			this.rectangle10.Brush = new NxtControl.Drawing.Brush();
			this.rectangle10.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle10.Name = "rectangle10";
			// 
			// rectangle2
			// 
			this.rectangle2.Bounds = new NxtControl.Drawing.RectF(((float)(180D)), ((float)(140D)), ((float)(200D)), ((float)(100D)));
			this.rectangle2.Brush = new NxtControl.Drawing.Brush();
			this.rectangle2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle2.Name = "rectangle2";
			this.rectangle2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(114)), ((byte)(114)), ((byte)(114))), 1F, NxtControl.Drawing.DashStyle.Dash);
			this.rectangle2.Text = "$key:Name \r\n+/- 37m³";
			this.rectangle2.TextAlignment = NxtControl.Drawing.ContentAlignment.BottomCenter;
			// 
			// line8
			// 
			this.line8.EndPoint = new NxtControl.Drawing.PointF(400D, 116D);
			this.line8.Name = "line8";
			this.line8.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.line8.StartPoint = new NxtControl.Drawing.PointF(380D, 116D);
			// 
			// line9
			// 
			this.line9.EndPoint = new NxtControl.Drawing.PointF(400D, 124D);
			this.line9.Name = "line9";
			this.line9.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 4F, NxtControl.Drawing.DashStyle.Solid);
			this.line9.StartPoint = new NxtControl.Drawing.PointF(400D, 108D);
			// 
			// line10
			// 
			this.line10.EndPoint = new NxtControl.Drawing.PointF(400D, 64D);
			this.line10.Name = "line10";
			this.line10.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.line10.StartPoint = new NxtControl.Drawing.PointF(380D, 64D);
			// 
			// line11
			// 
			this.line11.EndPoint = new NxtControl.Drawing.PointF(400D, 72D);
			this.line11.Name = "line11";
			this.line11.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 4F, NxtControl.Drawing.DashStyle.Solid);
			this.line11.StartPoint = new NxtControl.Drawing.PointF(400D, 56D);
			// 
			// group5
			// 
			this.group5.BeginInit();
			this.group5.Name = "group5";
			this.group5.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.line8,
			this.line9});
			this.group5.EndInit();
			// 
			// group6
			// 
			this.group6.BeginInit();
			this.group6.Name = "group6";
			this.group6.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.line10,
			this.line11});
			this.group6.EndInit();
			// 
			// line2
			// 
			this.line2.EndPoint = new NxtControl.Drawing.PointF(180D, 320D);
			this.line2.Name = "line2";
			this.line2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.line2.StartPoint = new NxtControl.Drawing.PointF(160D, 320D);
			// 
			// line3
			// 
			this.line3.EndPoint = new NxtControl.Drawing.PointF(160D, 328D);
			this.line3.Name = "line3";
			this.line3.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 4F, NxtControl.Drawing.DashStyle.Solid);
			this.line3.StartPoint = new NxtControl.Drawing.PointF(160D, 312D);
			// 
			// line4
			// 
			this.line4.EndPoint = new NxtControl.Drawing.PointF(180D, 264D);
			this.line4.Name = "line4";
			this.line4.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.line4.StartPoint = new NxtControl.Drawing.PointF(160D, 264D);
			// 
			// line5
			// 
			this.line5.EndPoint = new NxtControl.Drawing.PointF(160D, 272D);
			this.line5.Name = "line5";
			this.line5.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 4F, NxtControl.Drawing.DashStyle.Solid);
			this.line5.StartPoint = new NxtControl.Drawing.PointF(160D, 256D);
			// 
			// line6
			// 
			this.line6.EndPoint = new NxtControl.Drawing.PointF(180D, 116D);
			this.line6.Name = "line6";
			this.line6.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.line6.StartPoint = new NxtControl.Drawing.PointF(160D, 116D);
			// 
			// line7
			// 
			this.line7.EndPoint = new NxtControl.Drawing.PointF(160D, 124D);
			this.line7.Name = "line7";
			this.line7.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 4F, NxtControl.Drawing.DashStyle.Solid);
			this.line7.StartPoint = new NxtControl.Drawing.PointF(160D, 108D);
			// 
			// group2
			// 
			this.group2.BeginInit();
			this.group2.Name = "group2";
			this.group2.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.line2,
			this.line3});
			this.group2.EndInit();
			// 
			// group3
			// 
			this.group3.BeginInit();
			this.group3.Name = "group3";
			this.group3.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.line4,
			this.line5});
			this.group3.EndInit();
			// 
			// group4
			// 
			this.group4.BeginInit();
			this.group4.Name = "group4";
			this.group4.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.line6,
			this.line7});
			this.group4.EndInit();
			// 
			// line12
			// 
			this.line12.EndPoint = new NxtControl.Drawing.PointF(252D, 512D);
			this.line12.Name = "line12";
			this.line12.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line12.StartPoint = new NxtControl.Drawing.PointF(252D, 484D);
			// 
			// manualValveVertRight2
			// 
			this.manualValveVertRight2.BeginInit();
			this.manualValveVertRight2.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 244D, 496D);
			this.manualValveVertRight2.Name = "manualValveVertRight2";
			this.manualValveVertRight2.EndInit();
			// 
			// polyline7
			// 
			this.polyline7.Bounds = new NxtControl.Drawing.RectF(((float)(240D)), ((float)(524D)), ((float)(24D)), ((float)(8D)));
			this.polyline7.Closed = false;
			this.polyline7.Name = "polyline7";
			this.polyline7.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(240D, 524D),
			new NxtControl.Drawing.PointF(240D, 532D),
			new NxtControl.Drawing.PointF(264D, 532D),
			new NxtControl.Drawing.PointF(264D, 524D)});
			// 
			// line1
			// 
			this.line1.EndPoint = new NxtControl.Drawing.PointF(252D, 512D);
			this.line1.Name = "line1";
			this.line1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line1.StartPoint = new NxtControl.Drawing.PointF(252D, 484D);
			// 
			// manualValveVertRight1
			// 
			this.manualValveVertRight1.BeginInit();
			this.manualValveVertRight1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 244D, 496D);
			this.manualValveVertRight1.Name = "manualValveVertRight1";
			this.manualValveVertRight1.EndInit();
			// 
			// polyline1
			// 
			this.polyline1.Bounds = new NxtControl.Drawing.RectF(((float)(240D)), ((float)(524D)), ((float)(24D)), ((float)(8D)));
			this.polyline1.Closed = false;
			this.polyline1.Name = "polyline1";
			this.polyline1.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(240D, 524D),
			new NxtControl.Drawing.PointF(240D, 532D),
			new NxtControl.Drawing.PointF(264D, 532D),
			new NxtControl.Drawing.PointF(264D, 524D)});
			// 
			// line13
			// 
			this.line13.EndPoint = new NxtControl.Drawing.PointF(280D, 368D);
			this.line13.Name = "line13";
			this.line13.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line13.StartPoint = new NxtControl.Drawing.PointF(280D, 340D);
			// 
			// manualValveVertRight3
			// 
			this.manualValveVertRight3.BeginInit();
			this.manualValveVertRight3.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 272D, 352D);
			this.manualValveVertRight3.Name = "manualValveVertRight3";
			this.manualValveVertRight3.EndInit();
			// 
			// polyline2
			// 
			this.polyline2.Bounds = new NxtControl.Drawing.RectF(((float)(268D)), ((float)(380D)), ((float)(24D)), ((float)(8D)));
			this.polyline2.Closed = false;
			this.polyline2.Name = "polyline2";
			this.polyline2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(268D, 380D),
			new NxtControl.Drawing.PointF(268D, 388D),
			new NxtControl.Drawing.PointF(292D, 388D),
			new NxtControl.Drawing.PointF(292D, 380D)});
			// 
			// Tank
			// 
			this.Name = "Tank";
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.rectangle10,
			this.rectangle2,
			this.group5,
			this.group6,
			this.group2,
			this.group3,
			this.group4,
			this.line12,
			this.manualValveVertRight2,
			this.polyline7,
			this.line1,
			this.manualValveVertRight1,
			this.polyline1,
			this.line13,
			this.manualValveVertRight3,
			this.polyline2});
			this.SymbolSize = new System.Drawing.Size(600, 400);

		}
		private NxtControl.GuiFramework.Rectangle rectangle10;
		private NxtControl.GuiFramework.Rectangle rectangle2;
		private NxtControl.GuiFramework.Line line8;
		private NxtControl.GuiFramework.Line line9;
		private NxtControl.GuiFramework.Line line10;
		private NxtControl.GuiFramework.Line line11;
		private NxtControl.GuiFramework.Group group5;
		private NxtControl.GuiFramework.Group group6;
		private NxtControl.GuiFramework.Line line2;
		private NxtControl.GuiFramework.Line line3;
		private NxtControl.GuiFramework.Line line4;
		private NxtControl.GuiFramework.Line line5;
		private NxtControl.GuiFramework.Line line6;
		private NxtControl.GuiFramework.Line line7;
		private NxtControl.GuiFramework.Group group2;
		private NxtControl.GuiFramework.Group group3;
		private NxtControl.GuiFramework.Group group4;
		private NxtControl.GuiFramework.Line line12;
		private SchneiderElectric.NeredaLibrary.Graphics.ManualValveVertRight manualValveVertRight2;
		private NxtControl.GuiFramework.Polyline polyline7;
		private NxtControl.GuiFramework.Line line1;
		private SchneiderElectric.NeredaLibrary.Graphics.ManualValveVertRight manualValveVertRight1;
		private NxtControl.GuiFramework.Polyline polyline1;
		private NxtControl.GuiFramework.Line line13;
		private SchneiderElectric.NeredaLibrary.Graphics.ManualValveVertRight manualValveVertRight3;
		private NxtControl.GuiFramework.Polyline polyline2;
		#endregion
	}
}
