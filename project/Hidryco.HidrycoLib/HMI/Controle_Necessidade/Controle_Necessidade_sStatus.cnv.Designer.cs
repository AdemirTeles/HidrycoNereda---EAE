/*
 * Hidryco - Controle_Necessidade - sStatus
 * Auxiliar invisivel: entrega status e ajustes deste sub-CAT ao codigo do simbolo do processo.
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Symbols.Controle_Necessidade
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
			this.x_STS_NECESSIDADE_EQUIPAMENTO = new System.HMI.Symbols.Base.Execute<ushort>();
			this.x_STS_NIVEL = new System.HMI.Symbols.Base.Execute<float>();
			this.x_CMD_HABILITA = new System.HMI.Symbols.Base.Execute<bool>();
			this.x_STP_LIMITE_FAIXA_1 = new System.HMI.Symbols.Base.Execute<float>();
			this.x_STP_LIMITE_FAIXA_2 = new System.HMI.Symbols.Base.Execute<float>();
			this.x_STP_LIMITE_FAIXA_3 = new System.HMI.Symbols.Base.Execute<float>();
			this.x_STP_LIMITE_FAIXA_4 = new System.HMI.Symbols.Base.Execute<float>();
			// 
			// fundo
			// 
			this.fundo.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(1D)), ((float)(1D)));
			this.fundo.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("Transparent"));
			this.fundo.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.fundo.Name = "fundo";
			this.fundo.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// x_STS_NECESSIDADE_EQUIPAMENTO
			// 
			this.x_STS_NECESSIDADE_EQUIPAMENTO.BeginInit();
			this.x_STS_NECESSIDADE_EQUIPAMENTO.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.x_STS_NECESSIDADE_EQUIPAMENTO.IsOnlyInput = true;
			this.x_STS_NECESSIDADE_EQUIPAMENTO.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.x_STS_NECESSIDADE_EQUIPAMENTO.Name = "x_STS_NECESSIDADE_EQUIPAMENTO";
			this.x_STS_NECESSIDADE_EQUIPAMENTO.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.x_STS_NECESSIDADE_EQUIPAMENTO.TagName = "STS_NECESSIDADE_EQUIPAMENTO";
			this.x_STS_NECESSIDADE_EQUIPAMENTO.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.Valor_STS_NECESSIDADE_EQUIPAMENTO);
			this.x_STS_NECESSIDADE_EQUIPAMENTO.EndInit();
			// 
			// x_STS_NIVEL
			// 
			this.x_STS_NIVEL.BeginInit();
			this.x_STS_NIVEL.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.x_STS_NIVEL.IsOnlyInput = true;
			this.x_STS_NIVEL.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.x_STS_NIVEL.Name = "x_STS_NIVEL";
			this.x_STS_NIVEL.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.x_STS_NIVEL.TagName = "STS_NIVEL";
			this.x_STS_NIVEL.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.Valor_STS_NIVEL);
			this.x_STS_NIVEL.EndInit();
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
			// x_STP_LIMITE_FAIXA_1
			// 
			this.x_STP_LIMITE_FAIXA_1.BeginInit();
			this.x_STP_LIMITE_FAIXA_1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.x_STP_LIMITE_FAIXA_1.IsOnlyInput = true;
			this.x_STP_LIMITE_FAIXA_1.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.x_STP_LIMITE_FAIXA_1.Name = "x_STP_LIMITE_FAIXA_1";
			this.x_STP_LIMITE_FAIXA_1.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.x_STP_LIMITE_FAIXA_1.TagName = "STP_LIMITE_FAIXA_1";
			this.x_STP_LIMITE_FAIXA_1.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.Valor_STP_LIMITE_FAIXA_1);
			this.x_STP_LIMITE_FAIXA_1.EndInit();
			// 
			// x_STP_LIMITE_FAIXA_2
			// 
			this.x_STP_LIMITE_FAIXA_2.BeginInit();
			this.x_STP_LIMITE_FAIXA_2.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.x_STP_LIMITE_FAIXA_2.IsOnlyInput = true;
			this.x_STP_LIMITE_FAIXA_2.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.x_STP_LIMITE_FAIXA_2.Name = "x_STP_LIMITE_FAIXA_2";
			this.x_STP_LIMITE_FAIXA_2.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.x_STP_LIMITE_FAIXA_2.TagName = "STP_LIMITE_FAIXA_2";
			this.x_STP_LIMITE_FAIXA_2.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.Valor_STP_LIMITE_FAIXA_2);
			this.x_STP_LIMITE_FAIXA_2.EndInit();
			// 
			// x_STP_LIMITE_FAIXA_3
			// 
			this.x_STP_LIMITE_FAIXA_3.BeginInit();
			this.x_STP_LIMITE_FAIXA_3.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.x_STP_LIMITE_FAIXA_3.IsOnlyInput = true;
			this.x_STP_LIMITE_FAIXA_3.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.x_STP_LIMITE_FAIXA_3.Name = "x_STP_LIMITE_FAIXA_3";
			this.x_STP_LIMITE_FAIXA_3.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.x_STP_LIMITE_FAIXA_3.TagName = "STP_LIMITE_FAIXA_3";
			this.x_STP_LIMITE_FAIXA_3.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.Valor_STP_LIMITE_FAIXA_3);
			this.x_STP_LIMITE_FAIXA_3.EndInit();
			// 
			// x_STP_LIMITE_FAIXA_4
			// 
			this.x_STP_LIMITE_FAIXA_4.BeginInit();
			this.x_STP_LIMITE_FAIXA_4.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.x_STP_LIMITE_FAIXA_4.IsOnlyInput = true;
			this.x_STP_LIMITE_FAIXA_4.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.x_STP_LIMITE_FAIXA_4.Name = "x_STP_LIMITE_FAIXA_4";
			this.x_STP_LIMITE_FAIXA_4.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.x_STP_LIMITE_FAIXA_4.TagName = "STP_LIMITE_FAIXA_4";
			this.x_STP_LIMITE_FAIXA_4.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.Valor_STP_LIMITE_FAIXA_4);
			this.x_STP_LIMITE_FAIXA_4.EndInit();
			// 
			// sStatus
			// 
			this.Name = "sStatus";
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.fundo,
			this.x_STS_NECESSIDADE_EQUIPAMENTO,
			this.x_STS_NIVEL,
			this.x_CMD_HABILITA,
			this.x_STP_LIMITE_FAIXA_1,
			this.x_STP_LIMITE_FAIXA_2,
			this.x_STP_LIMITE_FAIXA_3,
			this.x_STP_LIMITE_FAIXA_4});
			this.SymbolSize = new System.Drawing.Size(1, 1);

		}
		private NxtControl.GuiFramework.Rectangle fundo;
		private System.HMI.Symbols.Base.Execute<ushort> x_STS_NECESSIDADE_EQUIPAMENTO;
		private System.HMI.Symbols.Base.Execute<float> x_STS_NIVEL;
		private System.HMI.Symbols.Base.Execute<bool> x_CMD_HABILITA;
		private System.HMI.Symbols.Base.Execute<float> x_STP_LIMITE_FAIXA_1;
		private System.HMI.Symbols.Base.Execute<float> x_STP_LIMITE_FAIXA_2;
		private System.HMI.Symbols.Base.Execute<float> x_STP_LIMITE_FAIXA_3;
		private System.HMI.Symbols.Base.Execute<float> x_STP_LIMITE_FAIXA_4;
		#endregion
	}
}
