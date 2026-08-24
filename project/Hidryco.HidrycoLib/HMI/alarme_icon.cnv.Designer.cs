/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 2/6/2026
 * Time: 2:06 PM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Graphics
{
	/// <summary>
	/// Summary description for alarme_icon.
	/// </summary>
	partial class alarme_icon
	{
		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.line11 = new NxtControl.GuiFramework.Line();
			this.line12 = new NxtControl.GuiFramework.Line();
			this.line13 = new NxtControl.GuiFramework.Line();
			this.arc1 = new NxtControl.GuiFramework.Arc();
			this.line8 = new NxtControl.GuiFramework.Line();
			this.line10 = new NxtControl.GuiFramework.Line();
			this.arc2 = new NxtControl.GuiFramework.Arc();
			this.ellipse1 = new NxtControl.GuiFramework.Ellipse();
			this.polygon1 = new NxtControl.GuiFramework.Polygon();
			// 
			// line11
			// 
			this.line11.EndPoint = new NxtControl.Drawing.PointF(32D, 67.826086956521721D);
			this.line11.Name = "line11";
			this.line11.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(114)), ((byte)(114)), ((byte)(114))), 2F, NxtControl.Drawing.DashStyle.Solid, NxtControl.Drawing.LineCap.Round, NxtControl.Drawing.LineCap.Round, ((uint)(0u)), ((uint)(0u)), System.Drawing.Drawing2D.LineJoin.Miter, null);
			this.line11.StartPoint = new NxtControl.Drawing.PointF(60D, 67.826086956521721D);
			// 
			// line12
			// 
			this.line12.EndPoint = new NxtControl.Drawing.PointF(60D, 67.826086956521721D);
			this.line12.Name = "line12";
			this.line12.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(114)), ((byte)(114)), ((byte)(114))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.line12.StartPoint = new NxtControl.Drawing.PointF(54.9090909090909D, 60D);
			// 
			// line13
			// 
			this.line13.EndPoint = new NxtControl.Drawing.PointF(32D, 67.826086956521721D);
			this.line13.Name = "line13";
			this.line13.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(114)), ((byte)(114)), ((byte)(114))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.line13.StartPoint = new NxtControl.Drawing.PointF(37D, 60D);
			// 
			// arc1
			// 
			this.arc1.Bounds = new NxtControl.Drawing.RectF(((float)(37D)), ((float)(44D)), ((float)(18D)), ((float)(18D)));
			this.arc1.Center = new NxtControl.Drawing.PointF(46D, 53D);
			this.arc1.Name = "arc1";
			this.arc1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(114)), ((byte)(114)), ((byte)(114))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.arc1.RadiusX = 9D;
			this.arc1.RadiusY = 9D;
			this.arc1.StartAngle = 180D;
			this.arc1.SweepAngle = 180D;
			// 
			// line8
			// 
			this.line8.EndPoint = new NxtControl.Drawing.PointF(37.090909090909179D, 59.695652173913061D);
			this.line8.Name = "line8";
			this.line8.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(114)), ((byte)(114)), ((byte)(114))), 2F, NxtControl.Drawing.DashStyle.Solid, NxtControl.Drawing.LineCap.Round, NxtControl.Drawing.LineCap.Round, ((uint)(0u)), ((uint)(0u)), System.Drawing.Drawing2D.LineJoin.Miter, null);
			this.line8.StartPoint = new NxtControl.Drawing.PointF(37.0909090909092D, 51.5652173913043D);
			// 
			// line10
			// 
			this.line10.EndPoint = new NxtControl.Drawing.PointF(54.909090909090935D, 59.695652173913061D);
			this.line10.Name = "line10";
			this.line10.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(114)), ((byte)(114)), ((byte)(114))), 2F, NxtControl.Drawing.DashStyle.Solid, NxtControl.Drawing.LineCap.Round, NxtControl.Drawing.LineCap.Round, ((uint)(0u)), ((uint)(0u)), System.Drawing.Drawing2D.LineJoin.Miter, null);
			this.line10.StartPoint = new NxtControl.Drawing.PointF(54.909090909090935D, 51.565217391304344D);
			// 
			// arc2
			// 
			this.arc2.Bounds = new NxtControl.Drawing.RectF(((float)(41D)), ((float)(62D)), ((float)(10D)), ((float)(10D)));
			this.arc2.Center = new NxtControl.Drawing.PointF(46D, 67D);
			this.arc2.Name = "arc2";
			this.arc2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(114)), ((byte)(114)), ((byte)(114))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.arc2.RadiusX = 5D;
			this.arc2.RadiusY = 5D;
			this.arc2.StartAngle = 0D;
			this.arc2.SweepAngle = 180D;
			// 
			// ellipse1
			// 
			this.ellipse1.Bounds = new NxtControl.Drawing.RectF(((float)(37D)), ((float)(44D)), ((float)(18D)), ((float)(27D)));
			this.ellipse1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(0))));
			this.ellipse1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.ellipse1.Name = "ellipse1";
			this.ellipse1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// polygon1
			// 
			this.polygon1.Bounds = new NxtControl.Drawing.RectF(((float)(33D)), ((float)(51D)), ((float)(26D)), ((float)(16D)));
			this.polygon1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(0))));
			this.polygon1.Closed = true;
			this.polygon1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.polygon1.Name = "polygon1";
			this.polygon1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.polygon1.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(33D, 67D),
			new NxtControl.Drawing.PointF(59D, 67D),
			new NxtControl.Drawing.PointF(46D, 51D)});
			// 
			// alarme_icon
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.polygon1,
			this.ellipse1,
			this.line8,
			this.line10,
			this.line11,
			this.line12,
			this.line13,
			this.arc1,
			this.arc2});
			this.SymbolSize = new System.Drawing.Size(300, 200);

		}
		private NxtControl.GuiFramework.Line line8;
		private NxtControl.GuiFramework.Line line10;
		private NxtControl.GuiFramework.Line line11;
		private NxtControl.GuiFramework.Line line12;
		private NxtControl.GuiFramework.Line line13;
		private NxtControl.GuiFramework.Arc arc1;
		private NxtControl.GuiFramework.Arc arc2;
		private NxtControl.GuiFramework.Ellipse ellipse1;
		private NxtControl.GuiFramework.Polygon polygon1;
		#endregion
	}
}
