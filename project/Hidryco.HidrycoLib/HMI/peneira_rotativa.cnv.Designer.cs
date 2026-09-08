/*
 * Criado pelo EcoStruxure Automation Expert.
 * Usuário:  
 * Data: 05/03/2026
 * Tempo: 16:21
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
	/// Summary description for peneira_rotativa.
	/// </summary>
	partial class peneira_rotativa
	{
		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.line1 = new NxtControl.GuiFramework.Line();
			this.line2 = new NxtControl.GuiFramework.Line();
			this.line3 = new NxtControl.GuiFramework.Line();
			this.line4 = new NxtControl.GuiFramework.Line();
			this.line5 = new NxtControl.GuiFramework.Line();
			this.line6 = new NxtControl.GuiFramework.Line();
			this.polygon1 = new NxtControl.GuiFramework.Polygon();
			// 
			// line1
			// 
			this.line1.EndPoint = new NxtControl.Drawing.PointF(72D, 88D);
			this.line1.Name = "line1";
			this.line1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(154)), ((byte)(154)), ((byte)(154))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line1.StartPoint = new NxtControl.Drawing.PointF(88D, 72D);
			// 
			// line2
			// 
			this.line2.EndPoint = new NxtControl.Drawing.PointF(96D, 112D);
			this.line2.Name = "line2";
			this.line2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(154)), ((byte)(154)), ((byte)(154))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line2.StartPoint = new NxtControl.Drawing.PointF(112D, 96D);
			// 
			// line3
			// 
			this.line3.EndPoint = new NxtControl.Drawing.PointF(112D, 96D);
			this.line3.Name = "line3";
			this.line3.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(154)), ((byte)(154)), ((byte)(154))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line3.StartPoint = new NxtControl.Drawing.PointF(88D, 72D);
			// 
			// line4
			// 
			this.line4.EndPoint = new NxtControl.Drawing.PointF(96D, 112D);
			this.line4.Name = "line4";
			this.line4.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(154)), ((byte)(154)), ((byte)(154))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line4.StartPoint = new NxtControl.Drawing.PointF(72D, 88D);
			// 
			// line5
			// 
			this.line5.EndPoint = new NxtControl.Drawing.PointF(137D, 41D);
			this.line5.Name = "line5";
			this.line5.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(154)), ((byte)(154)), ((byte)(154))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line5.StartPoint = new NxtControl.Drawing.PointF(97D, 81D);
			// 
			// line6
			// 
			this.line6.EndPoint = new NxtControl.Drawing.PointF(143D, 47D);
			this.line6.Name = "line6";
			this.line6.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(154)), ((byte)(154)), ((byte)(154))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line6.StartPoint = new NxtControl.Drawing.PointF(103D, 87D);
			// 
			// polygon1
			// 
			this.polygon1.Bounds = new NxtControl.Drawing.RectF(((float)(137D)), ((float)(41D)), ((float)(6D)), ((float)(6D)));
			this.polygon1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("Transparent"));
			this.polygon1.Closed = true;
			this.polygon1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.polygon1.Name = "polygon1";
			this.polygon1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(154)), ((byte)(154)), ((byte)(154))), 1F, NxtControl.Drawing.DashStyle.Solid, System.Drawing.Drawing2D.LineJoin.Round);
			this.polygon1.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(137D, 41D),
			new NxtControl.Drawing.PointF(143D, 47D),
			new NxtControl.Drawing.PointF(143D, 41D)});
			// 
			// peneira_rotativa
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.line1,
			this.line2,
			this.line3,
			this.line4,
			this.line5,
			this.line6,
			this.polygon1});
			this.SymbolSize = new System.Drawing.Size(236, 184);

		}
		private NxtControl.GuiFramework.Line line6;
		private NxtControl.GuiFramework.Line line5;
		private NxtControl.GuiFramework.Line line1;
		private NxtControl.GuiFramework.Line line2;
		private NxtControl.GuiFramework.Line line3;
		private NxtControl.GuiFramework.Line line4;
		private NxtControl.GuiFramework.Polygon polygon1;
		#endregion
	}
}
