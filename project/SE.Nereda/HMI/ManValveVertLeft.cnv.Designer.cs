/*
 * Created by EcoStruxure Automation Expert.
 * User: Schneider
 * Date: 4/24/2024
 * Time: 5:37 PM
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
	/// Summary description for ManValveVertLeft.
	/// </summary>
	partial class ManValveVertLeft
	{
		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.line8 = new NxtControl.GuiFramework.Line();
			this.line12 = new NxtControl.GuiFramework.Line();
			this.polygon1 = new NxtControl.GuiFramework.Polygon();
			this.polygon2 = new NxtControl.GuiFramework.Polygon();
			this.group1 = new NxtControl.GuiFramework.Group();
			// 
			// line8
			// 
			this.line8.EndPoint = new NxtControl.Drawing.PointF(16D, 20D);
			this.line8.Name = "line8";
			this.line8.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 3F, NxtControl.Drawing.DashStyle.Solid);
			this.line8.StartPoint = new NxtControl.Drawing.PointF(16D, 36D);
			// 
			// line12
			// 
			this.line12.EndPoint = new NxtControl.Drawing.PointF(16D, 28D);
			this.line12.Name = "line12";
			this.line12.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line12.StartPoint = new NxtControl.Drawing.PointF(36D, 28D);
			// 
			// polygon1
			// 
			this.polygon1.Bounds = new NxtControl.Drawing.RectF(((float)(28D)), ((float)(8D)), ((float)(16D)), ((float)(20D)));
			this.polygon1.Brush = new NxtControl.Drawing.Brush();
			this.polygon1.Closed = true;
			this.polygon1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.polygon1.Name = "polygon1";
			this.polygon1.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(28D, 8D),
			new NxtControl.Drawing.PointF(44D, 8D),
			new NxtControl.Drawing.PointF(36D, 28D)});
			// 
			// polygon2
			// 
			this.polygon2.Bounds = new NxtControl.Drawing.RectF(((float)(28D)), ((float)(28D)), ((float)(16D)), ((float)(20D)));
			this.polygon2.Brush = new NxtControl.Drawing.Brush();
			this.polygon2.Closed = true;
			this.polygon2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.polygon2.Name = "polygon2";
			this.polygon2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(28D, 48D),
			new NxtControl.Drawing.PointF(44D, 48D),
			new NxtControl.Drawing.PointF(36D, 28D)});
			// 
			// group1
			// 
			this.group1.BeginInit();
			this.group1.Name = "group1";
			this.group1.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.polygon1,
			this.polygon2,
			this.line8,
			this.line12});
			this.group1.EndInit();
			// 
			// ManValveVertLeft
			// 
			this.Name = "ManValveVertLeft";
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.group1});
			this.SymbolSize = new System.Drawing.Size(100, 100);

		}
		private NxtControl.GuiFramework.Line line8;
		private NxtControl.GuiFramework.Line line12;
		private NxtControl.GuiFramework.Polygon polygon1;
		private NxtControl.GuiFramework.Polygon polygon2;
		private NxtControl.GuiFramework.Group group1;
		#endregion
	}
}
