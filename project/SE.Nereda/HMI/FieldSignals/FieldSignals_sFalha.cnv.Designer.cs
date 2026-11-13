/*
 * Hidryco - FieldSignals - sFalha
 * Ultima falha do inversor (codigo, mnemonico e texto) para o diagnostico do Motor_VS.
 */
using System;
using System.ComponentModel;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.FieldSignals
{
	partial class sFalha
	{
		#region Component Designer generated code
		private void InitializeComponent()
		{
			this.lCodigo = new NxtControl.GuiFramework.FreeText();
			this.vCodigo = new NxtControl.GuiFramework.FreeText();
			this.vTexto = new NxtControl.GuiFramework.FreeText();
			this.vTexto2 = new NxtControl.GuiFramework.FreeText();
			// 
			// lCodigo
			// 
			this.lCodigo.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.lCodigo.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.lCodigo.Location = new NxtControl.Drawing.PointF(0D, 0D);
			this.lCodigo.Name = "lCodigo";
			this.lCodigo.Text = "C\u00f3digo";
			// 
			// vCodigo
			// 
			this.vCodigo.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.vCodigo.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.vCodigo.Location = new NxtControl.Drawing.PointF(160D, 0D);
			this.vCodigo.Name = "vCodigo";
			this.vCodigo.Text = "nenhuma";
			// 
			// vTexto
			// 
			this.vTexto.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.vTexto.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.vTexto.Location = new NxtControl.Drawing.PointF(0D, 22D);
			this.vTexto.Name = "vTexto";
			this.vTexto.Text = "";
			// 
			// vTexto2
			// 
			this.vTexto2.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.vTexto2.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.vTexto2.Location = new NxtControl.Drawing.PointF(0D, 38D);
			this.vTexto2.Name = "vTexto2";
			this.vTexto2.Text = "";
			// 
			// sFalha
			// 
			this.Name = "sFalha";
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.lCodigo,
			this.vCodigo,
			this.vTexto,
			this.vTexto2});
			this.SymbolSize = new System.Drawing.Size(340, 56);

		}
		private NxtControl.GuiFramework.FreeText lCodigo;
		private NxtControl.GuiFramework.FreeText vCodigo;
		private NxtControl.GuiFramework.FreeText vTexto;
		private NxtControl.GuiFramework.FreeText vTexto2;
		#endregion
	}
}
