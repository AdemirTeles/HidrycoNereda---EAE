/*
 * Hidryco - Controle_Gradeamento - sStatus
 * Auxiliar invisivel: entrega status e ajustes deste sub-CAT ao codigo do simbolo do processo.
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Symbols.Controle_Gradeamento
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
			this.x_STS_DIFERENCIAL_GRADE1 = new System.HMI.Symbols.Base.Execute<float>();
			this.x_STS_DIFERENCIAL_GRADE2 = new System.HMI.Symbols.Base.Execute<float>();
			this.x_CMD_LIGA_CICLO_REMOTO = new System.HMI.Symbols.Base.Execute<bool>();
			this.x_STP_DIFERENCIAL_NIVEL_GRADE1 = new System.HMI.Symbols.Base.Execute<float>();
			this.x_STP_DIFERENCIAL_NIVEL_GRADE2 = new System.HMI.Symbols.Base.Execute<float>();
			// 
			// fundo
			// 
			this.fundo.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(1D)), ((float)(1D)));
			this.fundo.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("Transparent"));
			this.fundo.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.fundo.Name = "fundo";
			this.fundo.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// x_STS_DIFERENCIAL_GRADE1
			// 
			this.x_STS_DIFERENCIAL_GRADE1.BeginInit();
			this.x_STS_DIFERENCIAL_GRADE1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.x_STS_DIFERENCIAL_GRADE1.IsOnlyInput = true;
			this.x_STS_DIFERENCIAL_GRADE1.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.x_STS_DIFERENCIAL_GRADE1.Name = "x_STS_DIFERENCIAL_GRADE1";
			this.x_STS_DIFERENCIAL_GRADE1.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.x_STS_DIFERENCIAL_GRADE1.TagName = "STS_DIFERENCIAL_GRADE1";
			this.x_STS_DIFERENCIAL_GRADE1.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.Valor_STS_DIFERENCIAL_GRADE1);
			this.x_STS_DIFERENCIAL_GRADE1.EndInit();
			// 
			// x_STS_DIFERENCIAL_GRADE2
			// 
			this.x_STS_DIFERENCIAL_GRADE2.BeginInit();
			this.x_STS_DIFERENCIAL_GRADE2.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.x_STS_DIFERENCIAL_GRADE2.IsOnlyInput = true;
			this.x_STS_DIFERENCIAL_GRADE2.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.x_STS_DIFERENCIAL_GRADE2.Name = "x_STS_DIFERENCIAL_GRADE2";
			this.x_STS_DIFERENCIAL_GRADE2.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.x_STS_DIFERENCIAL_GRADE2.TagName = "STS_DIFERENCIAL_GRADE2";
			this.x_STS_DIFERENCIAL_GRADE2.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.Valor_STS_DIFERENCIAL_GRADE2);
			this.x_STS_DIFERENCIAL_GRADE2.EndInit();
			// 
			// x_CMD_LIGA_CICLO_REMOTO
			// 
			this.x_CMD_LIGA_CICLO_REMOTO.BeginInit();
			this.x_CMD_LIGA_CICLO_REMOTO.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.x_CMD_LIGA_CICLO_REMOTO.IsOnlyInput = true;
			this.x_CMD_LIGA_CICLO_REMOTO.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.x_CMD_LIGA_CICLO_REMOTO.Name = "x_CMD_LIGA_CICLO_REMOTO";
			this.x_CMD_LIGA_CICLO_REMOTO.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.x_CMD_LIGA_CICLO_REMOTO.TagName = "CMD_LIGA_CICLO_REMOTO";
			this.x_CMD_LIGA_CICLO_REMOTO.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.Valor_CMD_LIGA_CICLO_REMOTO);
			this.x_CMD_LIGA_CICLO_REMOTO.EndInit();
			// 
			// x_STP_DIFERENCIAL_NIVEL_GRADE1
			// 
			this.x_STP_DIFERENCIAL_NIVEL_GRADE1.BeginInit();
			this.x_STP_DIFERENCIAL_NIVEL_GRADE1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.x_STP_DIFERENCIAL_NIVEL_GRADE1.IsOnlyInput = true;
			this.x_STP_DIFERENCIAL_NIVEL_GRADE1.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.x_STP_DIFERENCIAL_NIVEL_GRADE1.Name = "x_STP_DIFERENCIAL_NIVEL_GRADE1";
			this.x_STP_DIFERENCIAL_NIVEL_GRADE1.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.x_STP_DIFERENCIAL_NIVEL_GRADE1.TagName = "STP_DIFERENCIAL_NIVEL_GRADE1";
			this.x_STP_DIFERENCIAL_NIVEL_GRADE1.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.Valor_STP_DIFERENCIAL_NIVEL_GRADE1);
			this.x_STP_DIFERENCIAL_NIVEL_GRADE1.EndInit();
			// 
			// x_STP_DIFERENCIAL_NIVEL_GRADE2
			// 
			this.x_STP_DIFERENCIAL_NIVEL_GRADE2.BeginInit();
			this.x_STP_DIFERENCIAL_NIVEL_GRADE2.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.x_STP_DIFERENCIAL_NIVEL_GRADE2.IsOnlyInput = true;
			this.x_STP_DIFERENCIAL_NIVEL_GRADE2.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.x_STP_DIFERENCIAL_NIVEL_GRADE2.Name = "x_STP_DIFERENCIAL_NIVEL_GRADE2";
			this.x_STP_DIFERENCIAL_NIVEL_GRADE2.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.x_STP_DIFERENCIAL_NIVEL_GRADE2.TagName = "STP_DIFERENCIAL_NIVEL_GRADE2";
			this.x_STP_DIFERENCIAL_NIVEL_GRADE2.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.Valor_STP_DIFERENCIAL_NIVEL_GRADE2);
			this.x_STP_DIFERENCIAL_NIVEL_GRADE2.EndInit();
			// 
			// sStatus
			// 
			this.Name = "sStatus";
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.fundo,
			this.x_STS_DIFERENCIAL_GRADE1,
			this.x_STS_DIFERENCIAL_GRADE2,
			this.x_CMD_LIGA_CICLO_REMOTO,
			this.x_STP_DIFERENCIAL_NIVEL_GRADE1,
			this.x_STP_DIFERENCIAL_NIVEL_GRADE2});
			this.SymbolSize = new System.Drawing.Size(1, 1);

		}
		private NxtControl.GuiFramework.Rectangle fundo;
		private System.HMI.Symbols.Base.Execute<float> x_STS_DIFERENCIAL_GRADE1;
		private System.HMI.Symbols.Base.Execute<float> x_STS_DIFERENCIAL_GRADE2;
		private System.HMI.Symbols.Base.Execute<bool> x_CMD_LIGA_CICLO_REMOTO;
		private System.HMI.Symbols.Base.Execute<float> x_STP_DIFERENCIAL_NIVEL_GRADE1;
		private System.HMI.Symbols.Base.Execute<float> x_STP_DIFERENCIAL_NIVEL_GRADE2;
		#endregion
	}
}
