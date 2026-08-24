/*
 * Created by EcoStruxure Automation Expert.
 * User: Schneider
 * Date: 4/26/2024
 * Time: 2:44 PM
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
	/// Summary description for ControlValveVertLeft.
	/// </summary>
	partial class ControlValveVertLeft
	{
		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.polygon3 = new NxtControl.GuiFramework.Polygon();
			this.polygon4 = new NxtControl.GuiFramework.Polygon();
			this.rectangle2 = new NxtControl.GuiFramework.Rectangle();
			this.line1 = new NxtControl.GuiFramework.Line();
			this.group2 = new NxtControl.GuiFramework.Group();
			// 
			// polygon3
			// 
			this.polygon3.Bounds = new NxtControl.Drawing.RectF(((float)(24D)), ((float)(8D)), ((float)(16D)), ((float)(16D)));
			this.polygon3.Brush = new NxtControl.Drawing.Brush();
			this.polygon3.Closed = true;
			this.polygon3.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.polygon3.Name = "polygon3";
			this.polygon3.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(24D, 8D),
			new NxtControl.Drawing.PointF(40D, 8D),
			new NxtControl.Drawing.PointF(32D, 24D)});
			// 
			// polygon4
			// 
			this.polygon4.Bounds = new NxtControl.Drawing.RectF(((float)(24D)), ((float)(24D)), ((float)(16D)), ((float)(16D)));
			this.polygon4.Brush = new NxtControl.Drawing.Brush();
			this.polygon4.Closed = true;
			this.polygon4.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.polygon4.Name = "polygon4";
			this.polygon4.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(32D, 24D),
			new NxtControl.Drawing.PointF(40D, 40D),
			new NxtControl.Drawing.PointF(24D, 40D)});
			// 
			// rectangle2
			// 
			this.rectangle2.Bounds = new NxtControl.Drawing.RectF(((float)(4D)), ((float)(12D)), ((float)(12D)), ((float)(24D)));
			this.rectangle2.Brush = new NxtControl.Drawing.Brush();
			this.rectangle2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle2.Name = "rectangle2";
			// 
			// line1
			// 
			this.line1.EndPoint = new NxtControl.Drawing.PointF(16D, 24D);
			this.line1.Name = "line1";
			this.line1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line1.StartPoint = new NxtControl.Drawing.PointF(32D, 24D);
			// 
			// group2
			// 
			this.group2.BeginInit();
			this.group2.Name = "group2";
			this.group2.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.polygon3,
			this.polygon4,
			this.rectangle2,
			this.line1});
			this.group2.EndInit();
			// 
			// ControlValveVertLeft
			// 
			this.Name = "ControlValveVertLeft";
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.group2});
			this.SymbolSize = new System.Drawing.Size(100, 100);

		}
		private NxtControl.GuiFramework.Polygon polygon3;
		private NxtControl.GuiFramework.Polygon polygon4;
		private NxtControl.GuiFramework.Rectangle rectangle2;
		private NxtControl.GuiFramework.Line line1;
		private NxtControl.GuiFramework.Group group2;
		#endregion
	}
}
