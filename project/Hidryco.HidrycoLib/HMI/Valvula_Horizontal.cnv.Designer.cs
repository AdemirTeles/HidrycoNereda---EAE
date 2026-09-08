/*
 * Criado pelo EcoStruxure Automation Expert.
 * Usuário:  
 * Data: 27/05/2026
 * Tempo: 11:23
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
	/// Summary description for Valvula_Horizontal.
	/// </summary>
	partial class Valvula_Horizontal
	{
		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.vlv_1 = new NxtControl.GuiFramework.Polygon();
			this.vlv_2 = new NxtControl.GuiFramework.Polygon();
			this.line1 = new NxtControl.GuiFramework.Line();
			this.vlv_3 = new NxtControl.GuiFramework.Rectangle();
			// 
			// vlv_1
			// 
			this.vlv_1.Bounds = new NxtControl.Drawing.RectF(((float)(90D)), ((float)(63.444444444444422D)), ((float)(15D)), ((float)(15.55555555555555D)));
			this.vlv_1.Closed = true;
			this.vlv_1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.vlv_1.Name = "vlv_1";
			this.vlv_1.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(90D, 63.444444444444422D),
			new NxtControl.Drawing.PointF(90D, 78.999999999999972D),
			new NxtControl.Drawing.PointF(105D, 71.2222222222222D)});
			// 
			// vlv_2
			// 
			this.vlv_2.Bounds = new NxtControl.Drawing.RectF(((float)(105D)), ((float)(63.444444444444422D)), ((float)(15.000000000000028D)), ((float)(15.55555555555555D)));
			this.vlv_2.Closed = true;
			this.vlv_2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.vlv_2.Name = "vlv_2";
			this.vlv_2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(120.00000000000003D, 63.444444444444422D),
			new NxtControl.Drawing.PointF(120.00000000000003D, 78.999999999999972D),
			new NxtControl.Drawing.PointF(105D, 71.2222222222222D)});
			// 
			// line1
			// 
			this.line1.EndPoint = new NxtControl.Drawing.PointF(105D, 71.222222222222229D);
			this.line1.Name = "line1";
			this.line1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line1.StartPoint = new NxtControl.Drawing.PointF(105D, 55.66666666666665D);
			// 
			// vlv_3
			// 
			this.vlv_3.Bounds = new NxtControl.Drawing.RectF(((float)(93.75D)), ((float)(44D)), ((float)(22.500000000000028D)), ((float)(11.666666269302361D)));
			this.vlv_3.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.vlv_3.Name = "vlv_3";
			// 
			// Valvula_Horizontal
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.vlv_1,
			this.vlv_2,
			this.line1,
			this.vlv_3});
			this.SymbolSize = new System.Drawing.Size(240, 144);

		}
		private NxtControl.GuiFramework.Polygon vlv_1;
		private NxtControl.GuiFramework.Polygon vlv_2;
		private NxtControl.GuiFramework.Line line1;
		private NxtControl.GuiFramework.Rectangle vlv_3;
		#endregion
	}
}
