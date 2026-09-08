/*
 * Criado pelo EcoStruxure Automation Expert.
 * Usuário:  
 * Data: 21/05/2026
 * Tempo: 17:15
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
	/// Summary description for Energizado_por_Gerador.
	/// </summary>
	partial class Energizado_por_Gerador
	{
		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.ellipse1 = new NxtControl.GuiFramework.Ellipse();
			this.polygon1 = new NxtControl.GuiFramework.Polygon();
			// 
			// ellipse1
			// 
			this.ellipse1.Bounds = new NxtControl.Drawing.RectF(((float)(146D)), ((float)(111D)), ((float)(24D)), ((float)(24D)));
			this.ellipse1.Brush = new NxtControl.Drawing.Brush(true);
			this.ellipse1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.ellipse1.Name = "ellipse1";
			this.ellipse1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(154)), ((byte)(154)), ((byte)(154))), 2F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// polygon1
			// 
			this.polygon1.Bounds = new NxtControl.Drawing.RectF(((float)(153D)), ((float)(114D)), ((float)(10D)), ((float)(18D)));
			this.polygon1.Brush = new NxtControl.Drawing.Brush(true);
			this.polygon1.Closed = true;
			this.polygon1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.polygon1.Name = "polygon1";
			this.polygon1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(154)), ((byte)(154)), ((byte)(154))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.polygon1.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(159.06060606060606D, 114D),
			new NxtControl.Drawing.PointF(153D, 125.14285714285714D),
			new NxtControl.Drawing.PointF(157.040404040404D, 125.14285714285714D),
			new NxtControl.Drawing.PointF(157.040404040404D, 132D),
			new NxtControl.Drawing.PointF(163D, 121.71428571428572D),
			new NxtControl.Drawing.PointF(159.06060606060606D, 121.71428571428572D)});
			// 
			// Energizado_por_Gerador
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.ellipse1,
			this.polygon1});
			this.SymbolSize = new System.Drawing.Size(600, 400);

		}
		private NxtControl.GuiFramework.Ellipse ellipse1;
		private NxtControl.GuiFramework.Polygon polygon1;
		#endregion
	}
}
