/*
 * Created by EcoStruxure Automation Expert.
 * User: Schneider
 * Date: 4/24/2024
 * Time: 5:24 PM
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
	/// Summary description for ManualValveVertLeft.
	/// </summary>
	partial class ManualValveHorTop
	{
		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.line5 = new NxtControl.GuiFramework.Line();
			this.line6 = new NxtControl.GuiFramework.Line();
			this.polygon1 = new NxtControl.GuiFramework.Polygon();
			this.polygon2 = new NxtControl.GuiFramework.Polygon();
			this.group1 = new NxtControl.GuiFramework.Group();
			// 
			// line5
			// 
			this.line5.EndPoint = new NxtControl.Drawing.PointF(40D, 28D);
			this.line5.Name = "line5";
			this.line5.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line5.StartPoint = new NxtControl.Drawing.PointF(40D, 8D);
			// 
			// line6
			// 
			this.line6.EndPoint = new NxtControl.Drawing.PointF(48D, 8D);
			this.line6.Name = "line6";
			this.line6.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 3F, NxtControl.Drawing.DashStyle.Solid);
			this.line6.StartPoint = new NxtControl.Drawing.PointF(32D, 8D);
			// 
			// polygon1
			// 
			this.polygon1.Bounds = new NxtControl.Drawing.RectF(((float)(20D)), ((float)(20D)), ((float)(20D)), ((float)(16D)));
			this.polygon1.Brush = new NxtControl.Drawing.Brush();
			this.polygon1.Closed = true;
			this.polygon1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.polygon1.Name = "polygon1";
			this.polygon1.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(20D, 20D),
			new NxtControl.Drawing.PointF(20D, 36D),
			new NxtControl.Drawing.PointF(40D, 28D)});
			// 
			// polygon2
			// 
			this.polygon2.Bounds = new NxtControl.Drawing.RectF(((float)(40D)), ((float)(20D)), ((float)(20D)), ((float)(16D)));
			this.polygon2.Brush = new NxtControl.Drawing.Brush();
			this.polygon2.Closed = true;
			this.polygon2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.polygon2.Name = "polygon2";
			this.polygon2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(60D, 20D),
			new NxtControl.Drawing.PointF(60D, 36D),
			new NxtControl.Drawing.PointF(40D, 28D)});
			// 
			// group1
			// 
			this.group1.BeginInit();
			this.group1.Name = "group1";
			this.group1.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.polygon1,
			this.polygon2,
			this.line5,
			this.line6});
			this.group1.EndInit();
			// 
			// ManualValveHorTop
			// 
			this.Name = "ManualValveHorTop";
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.group1});
			this.SymbolSize = new System.Drawing.Size(100, 100);

		}
		private NxtControl.GuiFramework.Group group1;
		private NxtControl.GuiFramework.Line line5;
		private NxtControl.GuiFramework.Line line6;
		private NxtControl.GuiFramework.Polygon polygon1;
		private NxtControl.GuiFramework.Polygon polygon2;
		#endregion
	}
}
