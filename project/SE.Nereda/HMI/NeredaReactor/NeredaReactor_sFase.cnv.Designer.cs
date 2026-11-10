/*
 * Hidryco - sFase (Designer)
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.NeredaReactor
{
	partial class sFase
	{
		#region Component Designer generated code
		private void InitializeComponent()
		{
			this.txtNome = new NxtControl.GuiFramework.Rectangle();
			this.faixa = new NxtControl.GuiFramework.Rectangle();
			//
			// txtNome
			//
			this.txtNome.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(180D)), ((float)(18D)));
			this.txtNome.Brush = new NxtControl.Drawing.Brush(true);
			this.txtNome.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.txtNome.Name = "txtNome";
			this.txtNome.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.txtNome.Text = "Reator";
			this.txtNome.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.txtNome.TextColor = new NxtControl.Drawing.Color(((byte)(40)), ((byte)(40)), ((byte)(40)));
			//
			// faixa
			//
			this.faixa.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(20D)), ((float)(180D)), ((float)(26D)));
			this.faixa.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(175)), ((byte)(175)), ((byte)(175))));
			this.faixa.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.faixa.Name = "faixa";
			this.faixa.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.faixa.Text = "Sem fase";
			this.faixa.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			this.faixa.TextColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			//
			// sFase
			//
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.txtNome,
			this.faixa});
			this.SymbolSize = new System.Drawing.Size(180, 46);

		}
		#endregion

		private NxtControl.GuiFramework.Rectangle txtNome;
		private NxtControl.GuiFramework.Rectangle faixa;
	}
}
