/*
 * Criado pelo EcoStruxure Automation Expert.
 * Usuário:  
 * Data: 26/05/2026
 * Tempo: 13:50
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
	/// Summary description for Soprador.
	/// </summary>
	partial class Soprador
	{
		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.bmb_3 = new NxtControl.GuiFramework.Polygon();
			this.bmb_1 = new NxtControl.GuiFramework.Rectangle();
			this.bmb_2 = new NxtControl.GuiFramework.Ellipse();
			// 
			// bmb_3
			// 
			this.bmb_3.Bounds = new NxtControl.Drawing.RectF(((float)(88.000001525878929D)), ((float)(67.329412078857445D)), ((float)(42.6666667938232D)), ((float)(10.870587921142544D)));
			this.bmb_3.Closed = true;
			this.bmb_3.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.bmb_3.Name = "bmb_3";
			this.bmb_3.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(98.666668224334671D, 68.688235569000256D),
			new NxtControl.Drawing.PointF(88.000001525878929D, 78.199999999999989D),
			new NxtControl.Drawing.PointF(130.66666831970213D, 78.199999999999989D),
			new NxtControl.Drawing.PointF(120.00000162124627D, 67.329412078857445D)});
			// 
			// bmb_1
			// 
			this.bmb_1.Bounds = new NxtControl.Drawing.RectF(((float)(89D)), ((float)(25D)), ((float)(10.870588302612305D)), ((float)(32D)));
			this.bmb_1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.bmb_1.Name = "bmb_1";
			// 
			// bmb_2
			// 
			this.bmb_2.Bounds = new NxtControl.Drawing.RectF(((float)(88D)), ((float)(32D)), ((float)(42.666667938232422D)), ((float)(43.482353210449219D)));
			this.bmb_2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.bmb_2.Name = "bmb_2";
			// 
			// Soprador
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.bmb_3,
			this.bmb_1,
			this.bmb_2});
			this.SymbolSize = new System.Drawing.Size(197, 127);

		}
		private NxtControl.GuiFramework.Polygon bmb_3;
		private NxtControl.GuiFramework.Rectangle bmb_1;
		private NxtControl.GuiFramework.Ellipse bmb_2;
		#endregion
	}
}
