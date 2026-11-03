/*
 * Hidryco - Controle_PID - sStatus
 * Auxiliar invisivel: entrega status e ajustes deste sub-CAT ao codigo do simbolo do processo.
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Symbols.Controle_PID
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
			this.x_stsSaidaPID = new System.HMI.Symbols.Base.Execute<float>();
			this.x_CMD_HABILITA = new System.HMI.Symbols.Base.Execute<bool>();
			this.x_STP_DESEJADO = new System.HMI.Symbols.Base.Execute<float>();
			this.x_STP_PARAMETRO_KP = new System.HMI.Symbols.Base.Execute<float>();
			this.x_STP_PARAMETRO_KI = new System.HMI.Symbols.Base.Execute<float>();
			this.x_STP_PARAMETRO_KD = new System.HMI.Symbols.Base.Execute<float>();
			this.x_STP_MINIMO = new System.HMI.Symbols.Base.Execute<float>();
			this.x_STP_MAXIMO = new System.HMI.Symbols.Base.Execute<float>();
			// 
			// fundo
			// 
			this.fundo.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(1D)), ((float)(1D)));
			this.fundo.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("Transparent"));
			this.fundo.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.fundo.Name = "fundo";
			this.fundo.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// x_stsSaidaPID
			// 
			this.x_stsSaidaPID.BeginInit();
			this.x_stsSaidaPID.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.x_stsSaidaPID.IsOnlyInput = true;
			this.x_stsSaidaPID.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.x_stsSaidaPID.Name = "x_stsSaidaPID";
			this.x_stsSaidaPID.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.x_stsSaidaPID.TagName = "stsSaidaPID";
			this.x_stsSaidaPID.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.Valor_stsSaidaPID);
			this.x_stsSaidaPID.EndInit();
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
			// x_STP_DESEJADO
			// 
			this.x_STP_DESEJADO.BeginInit();
			this.x_STP_DESEJADO.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.x_STP_DESEJADO.IsOnlyInput = true;
			this.x_STP_DESEJADO.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.x_STP_DESEJADO.Name = "x_STP_DESEJADO";
			this.x_STP_DESEJADO.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.x_STP_DESEJADO.TagName = "STP_DESEJADO";
			this.x_STP_DESEJADO.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.Valor_STP_DESEJADO);
			this.x_STP_DESEJADO.EndInit();
			// 
			// x_STP_PARAMETRO_KP
			// 
			this.x_STP_PARAMETRO_KP.BeginInit();
			this.x_STP_PARAMETRO_KP.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.x_STP_PARAMETRO_KP.IsOnlyInput = true;
			this.x_STP_PARAMETRO_KP.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.x_STP_PARAMETRO_KP.Name = "x_STP_PARAMETRO_KP";
			this.x_STP_PARAMETRO_KP.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.x_STP_PARAMETRO_KP.TagName = "STP_PARAMETRO_KP";
			this.x_STP_PARAMETRO_KP.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.Valor_STP_PARAMETRO_KP);
			this.x_STP_PARAMETRO_KP.EndInit();
			// 
			// x_STP_PARAMETRO_KI
			// 
			this.x_STP_PARAMETRO_KI.BeginInit();
			this.x_STP_PARAMETRO_KI.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.x_STP_PARAMETRO_KI.IsOnlyInput = true;
			this.x_STP_PARAMETRO_KI.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.x_STP_PARAMETRO_KI.Name = "x_STP_PARAMETRO_KI";
			this.x_STP_PARAMETRO_KI.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.x_STP_PARAMETRO_KI.TagName = "STP_PARAMETRO_KI";
			this.x_STP_PARAMETRO_KI.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.Valor_STP_PARAMETRO_KI);
			this.x_STP_PARAMETRO_KI.EndInit();
			// 
			// x_STP_PARAMETRO_KD
			// 
			this.x_STP_PARAMETRO_KD.BeginInit();
			this.x_STP_PARAMETRO_KD.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.x_STP_PARAMETRO_KD.IsOnlyInput = true;
			this.x_STP_PARAMETRO_KD.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.x_STP_PARAMETRO_KD.Name = "x_STP_PARAMETRO_KD";
			this.x_STP_PARAMETRO_KD.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.x_STP_PARAMETRO_KD.TagName = "STP_PARAMETRO_KD";
			this.x_STP_PARAMETRO_KD.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.Valor_STP_PARAMETRO_KD);
			this.x_STP_PARAMETRO_KD.EndInit();
			// 
			// x_STP_MINIMO
			// 
			this.x_STP_MINIMO.BeginInit();
			this.x_STP_MINIMO.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.x_STP_MINIMO.IsOnlyInput = true;
			this.x_STP_MINIMO.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.x_STP_MINIMO.Name = "x_STP_MINIMO";
			this.x_STP_MINIMO.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.x_STP_MINIMO.TagName = "STP_MINIMO";
			this.x_STP_MINIMO.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.Valor_STP_MINIMO);
			this.x_STP_MINIMO.EndInit();
			// 
			// x_STP_MAXIMO
			// 
			this.x_STP_MAXIMO.BeginInit();
			this.x_STP_MAXIMO.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.x_STP_MAXIMO.IsOnlyInput = true;
			this.x_STP_MAXIMO.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.x_STP_MAXIMO.Name = "x_STP_MAXIMO";
			this.x_STP_MAXIMO.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.x_STP_MAXIMO.TagName = "STP_MAXIMO";
			this.x_STP_MAXIMO.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.Valor_STP_MAXIMO);
			this.x_STP_MAXIMO.EndInit();
			// 
			// sStatus
			// 
			this.Name = "sStatus";
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.fundo,
			this.x_stsSaidaPID,
			this.x_CMD_HABILITA,
			this.x_STP_DESEJADO,
			this.x_STP_PARAMETRO_KP,
			this.x_STP_PARAMETRO_KI,
			this.x_STP_PARAMETRO_KD,
			this.x_STP_MINIMO,
			this.x_STP_MAXIMO});
			this.SymbolSize = new System.Drawing.Size(1, 1);

		}
		private NxtControl.GuiFramework.Rectangle fundo;
		private System.HMI.Symbols.Base.Execute<float> x_stsSaidaPID;
		private System.HMI.Symbols.Base.Execute<bool> x_CMD_HABILITA;
		private System.HMI.Symbols.Base.Execute<float> x_STP_DESEJADO;
		private System.HMI.Symbols.Base.Execute<float> x_STP_PARAMETRO_KP;
		private System.HMI.Symbols.Base.Execute<float> x_STP_PARAMETRO_KI;
		private System.HMI.Symbols.Base.Execute<float> x_STP_PARAMETRO_KD;
		private System.HMI.Symbols.Base.Execute<float> x_STP_MINIMO;
		private System.HMI.Symbols.Base.Execute<float> x_STP_MAXIMO;
		#endregion
	}
}
