/*
 * Created by EcoStruxure Automation Expert.
 * User: Schneider
 * Date: 4/25/2024
 * Time: 12:53 PM
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
	/// Summary description for ContrlValveHorTop.
	/// </summary>
	partial class ContrlValveHorTop
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
			this.line1 = new NxtControl.GuiFramework.Line();
			this.group1 = new NxtControl.GuiFramework.Group();
			// 
			// polygon1
			// 
			this.polygon1.Bounds = new NxtControl.Drawing.RectF(((float)(12D)), ((float)(40D)), ((float)(20D)), ((float)(16D)));
			this.polygon1.Brush = new NxtControl.Drawing.Brush();
			this.polygon1.Closed = true;
			this.polygon1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.polygon1.Name = "polygon1";
			this.polygon1.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(12D, 40D),
			new NxtControl.Drawing.PointF(12D, 56D),
			new NxtControl.Drawing.PointF(32D, 48D)});
			// 
			// polygon2
			// 
			this.polygon2.Bounds = new NxtControl.Drawing.RectF(((float)(32D)), ((float)(40D)), ((float)(20D)), ((float)(16D)));
			this.polygon2.Brush = new NxtControl.Drawing.Brush();
			this.polygon2.Closed = true;
			this.polygon2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.polygon2.Name = "polygon2";
			this.polygon2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(52D, 40D),
			new NxtControl.Drawing.PointF(52D, 56D),
			new NxtControl.Drawing.PointF(32D, 48D)});
			// 
			// line5
			// 
			this.line5.EndPoint = new NxtControl.Drawing.PointF(32D, 48D);
			this.line5.Name = "line5";
			this.line5.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line5.StartPoint = new NxtControl.Drawing.PointF(32D, 20D);
			// 
			// rectangle1
			// 
			this.rectangle1.Bounds = new NxtControl.Drawing.RectF(((float)(24D)), ((float)(12D)), ((float)(16D)), ((float)(16D)));
			this.rectangle1.Brush = new NxtControl.Drawing.Brush();
			this.rectangle1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle1.Name = "rectangle1";
			// 
			// line1
			// 
			this.line1.EndPoint = new NxtControl.Drawing.PointF(40D, 20D);
			this.line1.Name = "line1";
			this.line1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line1.StartPoint = new NxtControl.Drawing.PointF(24D, 20D);
			// 
			// group1
			// 
			this.group1.BeginInit();
			this.group1.Name = "group1";
			this.group1.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.polygon1,
			this.polygon2,
			this.line5,
			this.rectangle1,
			this.line1});
			this.group1.EndInit();
			// 
			// ContrlValveHorTop
			// 
			this.Name = "ContrlValveHorTop";
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.group1});
			this.SymbolSize = new System.Drawing.Size(80, 80);

		}
		private NxtControl.GuiFramework.Polygon polygon1;
		private NxtControl.GuiFramework.Polygon polygon2;
		private NxtControl.GuiFramework.Line line5;
		private NxtControl.GuiFramework.Rectangle rectangle1;
		private NxtControl.GuiFramework.Line line1;
		private NxtControl.GuiFramework.Group group1;
		#endregion
	}
}
