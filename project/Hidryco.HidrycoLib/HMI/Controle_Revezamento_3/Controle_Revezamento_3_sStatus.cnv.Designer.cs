/*
 * Hidryco - Controle_Revezamento_3 - sStatus
 * Auxiliar invisivel: entrega status e ajustes deste sub-CAT ao codigo do simbolo do processo.
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Symbols.Controle_Revezamento_3
{
	/// <summary>
	/// Summary description for sStatus.
	/// </summary>
	partial class sStatus
	{

		#region Component Designer generated code
		private void InitializeComponent()
		{
			this.fundo = new NxtControl.GuiFramework.Rectangle();
			this.x_STS_RESTANTE_HOR = new System.HMI.Symbols.Base.Execute<ushort>();
			this.x_STS_RESTANTE_MIN = new System.HMI.Symbols.Base.Execute<ushort>();
			this.x_STS_RESTANTE_SEG = new System.HMI.Symbols.Base.Execute<ushort>();
			this.x_CMD_HABILITA = new System.HMI.Symbols.Base.Execute<bool>();
			this.x_STP_TEMPO_B1 = new System.HMI.Symbols.Base.Execute<ushort>();
			this.x_STP_TEMPO_B2 = new System.HMI.Symbols.Base.Execute<ushort>();
			this.x_STP_TEMPO_B3 = new System.HMI.Symbols.Base.Execute<ushort>();
			this.x_CMD_SELECAO_BOMBA = new System.HMI.Symbols.Base.Execute<short>();
			// 
			// fundo
			// 
			this.fundo.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(1D)), ((float)(1D)));
			this.fundo.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("Transparent"));
			this.fundo.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.fundo.Name = "fundo";
			this.fundo.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// x_STS_RESTANTE_HOR
			// 
			this.x_STS_RESTANTE_HOR.BeginInit();
			this.x_STS_RESTANTE_HOR.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.x_STS_RESTANTE_HOR.IsOnlyInput = true;
			this.x_STS_RESTANTE_HOR.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.x_STS_RESTANTE_HOR.Name = "x_STS_RESTANTE_HOR";
			this.x_STS_RESTANTE_HOR.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.x_STS_RESTANTE_HOR.TagName = "STS_RESTANTE_HOR";
			this.x_STS_RESTANTE_HOR.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.Valor_STS_RESTANTE_HOR);
			this.x_STS_RESTANTE_HOR.EndInit();
			// 
			// x_STS_RESTANTE_MIN
			// 
			this.x_STS_RESTANTE_MIN.BeginInit();
			this.x_STS_RESTANTE_MIN.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.x_STS_RESTANTE_MIN.IsOnlyInput = true;
			this.x_STS_RESTANTE_MIN.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.x_STS_RESTANTE_MIN.Name = "x_STS_RESTANTE_MIN";
			this.x_STS_RESTANTE_MIN.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.x_STS_RESTANTE_MIN.TagName = "STS_RESTANTE_MIN";
			this.x_STS_RESTANTE_MIN.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.Valor_STS_RESTANTE_MIN);
			this.x_STS_RESTANTE_MIN.EndInit();
			// 
			// x_STS_RESTANTE_SEG
			// 
			this.x_STS_RESTANTE_SEG.BeginInit();
			this.x_STS_RESTANTE_SEG.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.x_STS_RESTANTE_SEG.IsOnlyInput = true;
			this.x_STS_RESTANTE_SEG.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.x_STS_RESTANTE_SEG.Name = "x_STS_RESTANTE_SEG";
			this.x_STS_RESTANTE_SEG.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.x_STS_RESTANTE_SEG.TagName = "STS_RESTANTE_SEG";
			this.x_STS_RESTANTE_SEG.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.Valor_STS_RESTANTE_SEG);
			this.x_STS_RESTANTE_SEG.EndInit();
			// 
			// x_CMD_HABILITA
			// 
			this.x_CMD_HABILITA.BeginInit();
			this.x_CMD_HABILITA.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.x_CMD_HABILITA.IsOnlyInput = true;
			this.x_CMD_HABILITA.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.x_CMD_HABILITA.Name = "x_CMD_HABILITA";
			this.x_CMD_HABILITA.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.x_CMD_HABILITA.TagName = "CMD_HABILITA";
			this.x_CMD_HABILITA.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.Valor_CMD_HABILITA);
			this.x_CMD_HABILITA.EndInit();
			// 
			// x_STP_TEMPO_B1
			// 
			this.x_STP_TEMPO_B1.BeginInit();
			this.x_STP_TEMPO_B1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.x_STP_TEMPO_B1.IsOnlyInput = true;
			this.x_STP_TEMPO_B1.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.x_STP_TEMPO_B1.Name = "x_STP_TEMPO_B1";
			this.x_STP_TEMPO_B1.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.x_STP_TEMPO_B1.TagName = "STP_TEMPO_B1";
			this.x_STP_TEMPO_B1.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.Valor_STP_TEMPO_B1);
			this.x_STP_TEMPO_B1.EndInit();
			// 
			// x_STP_TEMPO_B2
			// 
			this.x_STP_TEMPO_B2.BeginInit();
			this.x_STP_TEMPO_B2.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.x_STP_TEMPO_B2.IsOnlyInput = true;
			this.x_STP_TEMPO_B2.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.x_STP_TEMPO_B2.Name = "x_STP_TEMPO_B2";
			this.x_STP_TEMPO_B2.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.x_STP_TEMPO_B2.TagName = "STP_TEMPO_B2";
			this.x_STP_TEMPO_B2.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.Valor_STP_TEMPO_B2);
			this.x_STP_TEMPO_B2.EndInit();
			// 
			// x_STP_TEMPO_B3
			// 
			this.x_STP_TEMPO_B3.BeginInit();
			this.x_STP_TEMPO_B3.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.x_STP_TEMPO_B3.IsOnlyInput = true;
			this.x_STP_TEMPO_B3.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.x_STP_TEMPO_B3.Name = "x_STP_TEMPO_B3";
			this.x_STP_TEMPO_B3.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.x_STP_TEMPO_B3.TagName = "STP_TEMPO_B3";
			this.x_STP_TEMPO_B3.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.Valor_STP_TEMPO_B3);
			this.x_STP_TEMPO_B3.EndInit();
			// 
			// x_CMD_SELECAO_BOMBA
			// 
			this.x_CMD_SELECAO_BOMBA.BeginInit();
			this.x_CMD_SELECAO_BOMBA.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.x_CMD_SELECAO_BOMBA.IsOnlyInput = true;
			this.x_CMD_SELECAO_BOMBA.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.x_CMD_SELECAO_BOMBA.Name = "x_CMD_SELECAO_BOMBA";
			this.x_CMD_SELECAO_BOMBA.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.x_CMD_SELECAO_BOMBA.TagName = "CMD_SELECAO_BOMBA";
			this.x_CMD_SELECAO_BOMBA.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.Valor_CMD_SELECAO_BOMBA);
			this.x_CMD_SELECAO_BOMBA.EndInit();
			// 
			// sStatus
			// 
			this.Name = "sStatus";
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.fundo,
			this.x_STS_RESTANTE_HOR,
			this.x_STS_RESTANTE_MIN,
			this.x_STS_RESTANTE_SEG,
			this.x_CMD_HABILITA,
			this.x_STP_TEMPO_B1,
			this.x_STP_TEMPO_B2,
			this.x_STP_TEMPO_B3,
			this.x_CMD_SELECAO_BOMBA});
			this.SymbolSize = new System.Drawing.Size(1, 1);

		}
		private NxtControl.GuiFramework.Rectangle fundo;
		private System.HMI.Symbols.Base.Execute<ushort> x_STS_RESTANTE_HOR;
		private System.HMI.Symbols.Base.Execute<ushort> x_STS_RESTANTE_MIN;
		private System.HMI.Symbols.Base.Execute<ushort> x_STS_RESTANTE_SEG;
		private System.HMI.Symbols.Base.Execute<bool> x_CMD_HABILITA;
		private System.HMI.Symbols.Base.Execute<ushort> x_STP_TEMPO_B1;
		private System.HMI.Symbols.Base.Execute<ushort> x_STP_TEMPO_B2;
		private System.HMI.Symbols.Base.Execute<ushort> x_STP_TEMPO_B3;
		private System.HMI.Symbols.Base.Execute<short> x_CMD_SELECAO_BOMBA;
		#endregion
	}
}
