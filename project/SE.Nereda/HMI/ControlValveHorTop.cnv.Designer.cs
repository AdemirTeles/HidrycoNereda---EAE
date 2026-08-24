/*
 * Created by EcoStruxure Automation Expert.
 * User: Schneider
 * Date: 4/25/2024
 * Time: 4:56 PM
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
	/// Summary description for ControlValveHorTop.
	/// </summary>
	partial class ControlValveHorTop
	{
		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.polygon1 = new NxtControl.GuiFramework.Polygon();
			this.polygon2 = new NxtControl.GuiFramework.Polygon();
			this.line5 = new NxtControl.GuiFramework.Line();
			this.rectangle1 = new NxtControl.GuiFramework.Rectangle();
			this.group1 = new NxtControl.GuiFramework.Group();
			// 
			// polygon1
			// 
			this.polygon1.Bounds = new NxtControl.Drawing.RectF(((float)(8D)), ((float)(28D)), ((float)(16D)), ((float)(16D)));
			this.polygon1.Brush = new NxtControl.Drawing.Brush();
			this.polygon1.Closed = true;
			this.polygon1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.polygon1.Name = "polygon1";
			this.polygon1.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(8D, 28D),
			new NxtControl.Drawing.PointF(8D, 44D),
			new NxtControl.Drawing.PointF(24D, 36D)});
			// 
			// polygon2
			// 
			this.polygon2.Bounds = new NxtControl.Drawing.RectF(((float)(24D)), ((float)(28D)), ((float)(16D)), ((float)(16D)));
			this.polygon2.Brush = new NxtControl.Drawing.Brush();
			this.polygon2.Closed = true;
			this.polygon2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.polygon2.Name = "polygon2";
			this.polygon2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(40D, 28D),
			new NxtControl.Drawing.PointF(40D, 44D),
			new NxtControl.Drawing.PointF(24D, 36D)});
			// 
			// line5
			// 
			this.line5.EndPoint = new NxtControl.Drawing.PointF(24D, 36D);
			this.line5.Name = "line5";
			this.line5.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line5.StartPoint = new NxtControl.Drawing.PointF(24D, 19D);
			// 
			// rectangle1
			// 
			this.rectangle1.Bounds = new NxtControl.Drawing.RectF(((float)(12D)), ((float)(7D)), ((float)(24D)), ((float)(12D)));
			this.rectangle1.Brush = new NxtControl.Drawing.Brush();
			this.rectangle1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle1.Name = "rectangle1";
			// 
			// group1
			// 
			this.group1.BeginInit();
			this.group1.Name = "group1";
			this.group1.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.polygon1,
			this.polygon2,
			this.line5,
			this.rectangle1});
			this.group1.EndInit();
			// 
			// ControlValveHorTop
			// 
			this.Name = "ControlValveHorTop";
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.group1});
			this.SymbolSize = new System.Drawing.Size(200, 200);

		}
		private NxtControl.GuiFramework.Polygon polygon1;
		private NxtControl.GuiFramework.Polygon polygon2;
		private NxtControl.GuiFramework.Line line5;
		private NxtControl.GuiFramework.Rectangle rectangle1;
		private NxtControl.GuiFramework.Group group1;
		#endregion
	}
}
