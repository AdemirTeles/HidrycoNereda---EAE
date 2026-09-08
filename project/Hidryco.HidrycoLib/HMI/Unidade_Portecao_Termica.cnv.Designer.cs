/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 2/10/2026
 * Time: 9:14 AM
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
	/// Summary description for Unidade_Portecao_Termica.
	/// </summary>
	partial class Unidade_Portecao_Termica
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
			this.arc1 = new NxtControl.GuiFramework.Arc();
			this.arc2 = new NxtControl.GuiFramework.Arc();
			this.ellipse1 = new NxtControl.GuiFramework.Ellipse();
			this.line3 = new NxtControl.GuiFramework.Line();
			this.graphicSymbol1 = new NxtControl.GuiFramework.GraphicSymbol();
			this.line5 = new NxtControl.GuiFramework.Line();
			this.line6 = new NxtControl.GuiFramework.Line();
			this.line4 = new NxtControl.GuiFramework.Line();
			this.line7 = new NxtControl.GuiFramework.Line();
			this.line8 = new NxtControl.GuiFramework.Line();
			this.line9 = new NxtControl.GuiFramework.Line();
			// 
			// line1
			// 
			this.line1.EndPoint = new NxtControl.Drawing.PointF(116D, 95D);
			this.line1.Name = "line1";
			this.line1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line1.StartPoint = new NxtControl.Drawing.PointF(116D, 63D);
			// 
			// line2
			// 
			this.line2.EndPoint = new NxtControl.Drawing.PointF(126D, 95D);
			this.line2.Name = "line2";
			this.line2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line2.StartPoint = new NxtControl.Drawing.PointF(126D, 63D);
			// 
			// arc1
			// 
			this.arc1.Bounds = new NxtControl.Drawing.RectF(((float)(114D)), ((float)(92D)), ((float)(14D)), ((float)(14D)));
			this.arc1.Center = new NxtControl.Drawing.PointF(121D, 99D);
			this.arc1.Name = "arc1";
			this.arc1.RadiusX = 7D;
			this.arc1.RadiusY = 7D;
			this.arc1.StartAngle = -45D;
			this.arc1.SweepAngle = 270D;
			// 
			// arc2
			// 
			this.arc2.Bounds = new NxtControl.Drawing.RectF(((float)(116.18629150101523D)), ((float)(58.186291501015234D)), ((float)(10D)), ((float)(13D)));
			this.arc2.Center = new NxtControl.Drawing.PointF(121.18629150101523D, 64.686291501015234D);
			this.arc2.Name = "arc2";
			this.arc2.RadiusX = 5D;
			this.arc2.RadiusY = 6.5D;
			this.arc2.StartAngle = 190D;
			this.arc2.SweepAngle = 160D;
			// 
			// ellipse1
			// 
			this.ellipse1.Bounds = new NxtControl.Drawing.RectF(((float)(117D)), ((float)(95D)), ((float)(8D)), ((float)(8D)));
			this.ellipse1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(234)), ((byte)(22)), ((byte)(30))));
			this.ellipse1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.ellipse1.Name = "ellipse1";
			this.ellipse1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(234)), ((byte)(22)), ((byte)(30))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// line3
			// 
			this.line3.EndPoint = new NxtControl.Drawing.PointF(121D, 97D);
			this.line3.Name = "line3";
			this.line3.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(234)), ((byte)(22)), ((byte)(30))), 3F, NxtControl.Drawing.DashStyle.Custom, NxtControl.Drawing.LineCap.Round, NxtControl.Drawing.LineCap.Round, ((uint)(2u)), ((uint)(2u)), System.Drawing.Drawing2D.LineJoin.Miter, null);
			this.line3.StartPoint = new NxtControl.Drawing.PointF(121D, 65D);
			// 
			// graphicSymbol1
			// 
			this.graphicSymbol1.BeginInit();
			this.graphicSymbol1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 12D, 11.627416997969533D);
			this.graphicSymbol1.Name = "graphicSymbol1";
			this.graphicSymbol1.EndInit();
			// 
			// line5
			// 
			this.line5.EndPoint = new NxtControl.Drawing.PointF(114D, 69D);
			this.line5.Name = "line5";
			this.line5.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(234)), ((byte)(22)), ((byte)(30))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line5.StartPoint = new NxtControl.Drawing.PointF(108D, 69D);
			// 
			// line6
			// 
			this.line6.EndPoint = new NxtControl.Drawing.PointF(114D, 73D);
			this.line6.Name = "line6";
			this.line6.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(234)), ((byte)(22)), ((byte)(30))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line6.StartPoint = new NxtControl.Drawing.PointF(108D, 73D);
			// 
			// line4
			// 
			this.line4.EndPoint = new NxtControl.Drawing.PointF(114D, 77D);
			this.line4.Name = "line4";
			this.line4.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(234)), ((byte)(22)), ((byte)(30))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line4.StartPoint = new NxtControl.Drawing.PointF(108D, 77D);
			// 
			// line7
			// 
			this.line7.EndPoint = new NxtControl.Drawing.PointF(114D, 81D);
			this.line7.Name = "line7";
			this.line7.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(234)), ((byte)(22)), ((byte)(30))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line7.StartPoint = new NxtControl.Drawing.PointF(108D, 81D);
			// 
			// line8
			// 
			this.line8.EndPoint = new NxtControl.Drawing.PointF(114D, 85D);
			this.line8.Name = "line8";
			this.line8.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(234)), ((byte)(22)), ((byte)(30))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line8.StartPoint = new NxtControl.Drawing.PointF(108D, 85D);
			// 
			// line9
			// 
			this.line9.EndPoint = new NxtControl.Drawing.PointF(114D, 89D);
			this.line9.Name = "line9";
			this.line9.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(234)), ((byte)(22)), ((byte)(30))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line9.StartPoint = new NxtControl.Drawing.PointF(108D, 89D);
			// 
			// Unidade_Portecao_Termica
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.ellipse1,
			this.line3,
			this.arc1,
			this.line1,
			this.line2,
			this.arc2,
			this.graphicSymbol1,
			this.line5,
			this.line6,
			this.line4,
			this.line7,
			this.line8,
			this.line9});
			this.SymbolSize = new System.Drawing.Size(300, 200);

		}
		private NxtControl.GuiFramework.Line line1;
		private NxtControl.GuiFramework.Line line2;
		private NxtControl.GuiFramework.Arc arc1;
		private NxtControl.GuiFramework.Arc arc2;
		private NxtControl.GuiFramework.Ellipse ellipse1;
		private NxtControl.GuiFramework.Line line3;
		private NxtControl.GuiFramework.Line line4;
		private NxtControl.GuiFramework.GraphicSymbol graphicSymbol1;
		private NxtControl.GuiFramework.Line line5;
		private NxtControl.GuiFramework.Line line6;
		private NxtControl.GuiFramework.Line line7;
		private NxtControl.GuiFramework.Line line8;
		private NxtControl.GuiFramework.Line line9;
		#endregion
	}
}
