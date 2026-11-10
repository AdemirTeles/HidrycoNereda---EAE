/*
 * Hidryco - AnalogInput sPorcentagem (Designer)
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.AnalogInput
{
	partial class sPorcentagem
	{
		#region Component Designer generated code
		private void InitializeComponent()
		{
			this.valor = new NxtControl.GuiFramework.Rectangle();
			//
			// valor
			//
			this.valor.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(56D)), ((float)(18D)));
			this.valor.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255))));
			this.valor.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.valor.Name = "valor";
			this.valor.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(150)), ((byte)(150)), ((byte)(150))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.valor.Text = "--- %";
			this.valor.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.valor.TextColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			//
			// sPorcentagem
			//
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.valor});
			this.SymbolSize = new System.Drawing.Size(56, 18);

		}
		#endregion

		private NxtControl.GuiFramework.Rectangle valor;
	}
}
