/*
 * Hidryco - Sensor_Generico - sLiquido (Designer)
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Symbols.Sensor_Generico
{
	partial class sLiquido
	{
		#region Component Designer generated code
		private void InitializeComponent()
		{
			this.liquido = new NxtControl.GuiFramework.Rectangle();
			this.xPct = new System.HMI.Symbols.Base.Execute<float>();
			this.xEstado = new System.HMI.Symbols.Base.Execute<short>();
			this.xFalhaAtiva = new System.HMI.Symbols.Base.Execute<bool>();
			//
			// liquido
			//
			this.liquido.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(100D)), ((float)(100D)));
			this.liquido.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(120)), ((byte)(180)), ((byte)(230))));
			this.liquido.FillDirection = NxtControl.Drawing.FillDirection.DownToTop;
			this.liquido.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.liquido.Name = "liquido";
			this.liquido.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// xPct
			// 
			this.xPct.BeginInit();
			this.xPct.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xPct.IsOnlyInput = true;
			this.xPct.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xPct.Name = "xPct";
			this.xPct.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xPct.TagName = "STS_PORCENTAGEM";
			this.xPct.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.PctValueChanged);
			this.xPct.EndInit();
			// 
			// xEstado
			// 
			this.xEstado.BeginInit();
			this.xEstado.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xEstado.IsOnlyInput = true;
			this.xEstado.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xEstado.Name = "xEstado";
			this.xEstado.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xEstado.TagName = "STS_ESTADO";
			this.xEstado.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.EstadoValueChanged);
			this.xEstado.EndInit();
			// 
			// xFalhaAtiva
			// 
			this.xFalhaAtiva.BeginInit();
			this.xFalhaAtiva.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xFalhaAtiva.IsOnlyInput = true;
			this.xFalhaAtiva.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xFalhaAtiva.Name = "xFalhaAtiva";
			this.xFalhaAtiva.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xFalhaAtiva.TagName = "STS_FALHA_ATIVA";
			this.xFalhaAtiva.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.FalhaAtivaValueChanged);
			this.xFalhaAtiva.EndInit();
			//
			// sLiquido
			//
			this.Name = "sLiquido";
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.liquido,
			this.xPct,
			this.xEstado,
			this.xFalhaAtiva});
			this.SymbolSize = new System.Drawing.Size(100, 100);

		}
		private NxtControl.GuiFramework.Rectangle liquido;
		private System.HMI.Symbols.Base.Execute<float> xPct;
		private System.HMI.Symbols.Base.Execute<short> xEstado;
		private System.HMI.Symbols.Base.Execute<bool> xFalhaAtiva;
		#endregion
	}
}
