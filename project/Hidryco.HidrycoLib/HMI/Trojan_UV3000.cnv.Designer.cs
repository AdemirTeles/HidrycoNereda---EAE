/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 2/18/2026
 * Time: 5:05 PM
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
	/// Summary description for Trojan_UV3000.
	/// </summary>
	partial class Trojan_UV3000
	{
		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.rectangle1 = new NxtControl.GuiFramework.Rectangle();
			this.rectangle2 = new NxtControl.GuiFramework.Rectangle();
			this.rectangle3 = new NxtControl.GuiFramework.Rectangle();
			this.polygon1 = new NxtControl.GuiFramework.Polygon();
			this.polygon2 = new NxtControl.GuiFramework.Polygon();
			this.group1 = new NxtControl.GuiFramework.Group();
			this.rectangle4 = new NxtControl.GuiFramework.Rectangle();
			this.rectangle5 = new NxtControl.GuiFramework.Rectangle();
			this.rectangle6 = new NxtControl.GuiFramework.Rectangle();
			this.rectangle7 = new NxtControl.GuiFramework.Rectangle();
			this.rectangle8 = new NxtControl.GuiFramework.Rectangle();
			this.rectangle9 = new NxtControl.GuiFramework.Rectangle();
			// 
			// rectangle1
			// 
			this.rectangle1.Bounds = new NxtControl.Drawing.RectF(((float)(82.666666666666671D)), ((float)(56D)), ((float)(58.666666666666671D)), ((float)(5.3333333333333428D)));
			this.rectangle1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle1.Name = "rectangle1";
			// 
			// rectangle2
			// 
			this.rectangle2.Bounds = new NxtControl.Drawing.RectF(((float)(88D)), ((float)(61.333333333333343D)), ((float)(4D)), ((float)(26.666666666666657D)));
			this.rectangle2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle2.Name = "rectangle2";
			// 
			// rectangle3
			// 
			this.rectangle3.Bounds = new NxtControl.Drawing.RectF(((float)(132D)), ((float)(61.333333333333343D)), ((float)(4D)), ((float)(26.666666666666657D)));
			this.rectangle3.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle3.Name = "rectangle3";
			// 
			// polygon1
			// 
			this.polygon1.Bounds = new NxtControl.Drawing.RectF(((float)(136D)), ((float)(61.333333333333343D)), ((float)(8D)), ((float)(4D)));
			this.polygon1.Closed = true;
			this.polygon1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.polygon1.Name = "polygon1";
			this.polygon1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid, NxtControl.Drawing.LineCap.Round, NxtControl.Drawing.LineCap.Round, ((uint)(0u)), ((uint)(0u)), System.Drawing.Drawing2D.LineJoin.Round, null);
			this.polygon1.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(138.66666666666669D, 61.333333333333343D),
			new NxtControl.Drawing.PointF(144D, 61.333333333333343D),
			new NxtControl.Drawing.PointF(141.33333333333334D, 65.333333333333343D),
			new NxtControl.Drawing.PointF(138.66666666666669D, 65.333333333333343D),
			new NxtControl.Drawing.PointF(136D, 61.333333333333343D)});
			// 
			// polygon2
			// 
			this.polygon2.Bounds = new NxtControl.Drawing.RectF(((float)(80D)), ((float)(61.333333333333343D)), ((float)(8D)), ((float)(4D)));
			this.polygon2.Closed = true;
			this.polygon2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.polygon2.Name = "polygon2";
			this.polygon2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid, NxtControl.Drawing.LineCap.Round, NxtControl.Drawing.LineCap.Round, ((uint)(0u)), ((uint)(0u)), System.Drawing.Drawing2D.LineJoin.Round, null);
			this.polygon2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(82.666666666666671D, 61.333333333333343D),
			new NxtControl.Drawing.PointF(88D, 61.333333333333343D),
			new NxtControl.Drawing.PointF(85.333333333333314D, 65.333333333333343D),
			new NxtControl.Drawing.PointF(82.666666666666671D, 65.333333333333343D),
			new NxtControl.Drawing.PointF(80D, 61.333333333333343D)});
			// 
			// group1
			// 
			this.group1.BeginInit();
			this.group1.Name = "group1";
			this.group1.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.rectangle1,
			this.rectangle2,
			this.rectangle3,
			this.polygon1,
			this.polygon2});
			this.group1.EndInit();
			// 
			// rectangle4
			// 
			this.rectangle4.Bounds = new NxtControl.Drawing.RectF(((float)(92D)), ((float)(63D)), ((float)(40D)), ((float)(2D)));
			this.rectangle4.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle4.Name = "rectangle4";
			this.rectangle4.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// rectangle5
			// 
			this.rectangle5.Bounds = new NxtControl.Drawing.RectF(((float)(92D)), ((float)(66D)), ((float)(40D)), ((float)(2D)));
			this.rectangle5.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle5.Name = "rectangle5";
			this.rectangle5.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// rectangle6
			// 
			this.rectangle6.Bounds = new NxtControl.Drawing.RectF(((float)(92D)), ((float)(69D)), ((float)(40D)), ((float)(2D)));
			this.rectangle6.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle6.Name = "rectangle6";
			this.rectangle6.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// rectangle7
			// 
			this.rectangle7.Bounds = new NxtControl.Drawing.RectF(((float)(92D)), ((float)(72D)), ((float)(40D)), ((float)(2D)));
			this.rectangle7.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle7.Name = "rectangle7";
			this.rectangle7.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// rectangle8
			// 
			this.rectangle8.Bounds = new NxtControl.Drawing.RectF(((float)(92D)), ((float)(75D)), ((float)(40D)), ((float)(2D)));
			this.rectangle8.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle8.Name = "rectangle8";
			this.rectangle8.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// rectangle9
			// 
			this.rectangle9.Bounds = new NxtControl.Drawing.RectF(((float)(92D)), ((float)(78D)), ((float)(40D)), ((float)(2D)));
			this.rectangle9.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle9.Name = "rectangle9";
			this.rectangle9.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// Trojan_UV3000
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.rectangle4,
			this.group1,
			this.rectangle5,
			this.rectangle6,
			this.rectangle7,
			this.rectangle8,
			this.rectangle9});
			this.SymbolSize = new System.Drawing.Size(300, 200);

		}
		private NxtControl.GuiFramework.Rectangle rectangle1;
		private NxtControl.GuiFramework.Rectangle rectangle2;
		private NxtControl.GuiFramework.Rectangle rectangle3;
		private NxtControl.GuiFramework.Polygon polygon1;
		private NxtControl.GuiFramework.Polygon polygon2;
		private NxtControl.GuiFramework.Group group1;
		private NxtControl.GuiFramework.Rectangle rectangle4;
		private NxtControl.GuiFramework.Rectangle rectangle5;
		private NxtControl.GuiFramework.Rectangle rectangle6;
		private NxtControl.GuiFramework.Rectangle rectangle7;
		private NxtControl.GuiFramework.Rectangle rectangle8;
		private NxtControl.GuiFramework.Rectangle rectangle9;
		#endregion
	}
}
