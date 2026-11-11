/*
 * Criado pelo gerador fp_diag (padrao Hidryco).
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace SE.Nereda.Faceplates.MotorS
{
	/// <summary>
	/// Summary description for fpDiagnostico.
	/// </summary>
	partial class fpDiagnostico
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.titulo = new NxtControl.GuiFramework.FreeText();
			this.secEstados = new NxtControl.GuiFramework.FreeText();
			this.estados = new SE.Nereda.Symbols.MotorBaseNer.sDiagnostico();
			this.secAcion = new NxtControl.GuiFramework.FreeText();
			this.r_Pronto = new NxtControl.GuiFramework.FreeText();
			this.v_Pronto = new NxtControl.GuiFramework.FreeText();
			this.r_Circ = new NxtControl.GuiFramework.FreeText();
			this.v_Circ = new NxtControl.GuiFramework.FreeText();
			this.r_Realim = new NxtControl.GuiFramework.FreeText();
			this.v_Realim = new NxtControl.GuiFramework.FreeText();
			this.rxPronto = new System.HMI.Symbols.Base.Execute<bool>();
			this.rxCirc = new System.HMI.Symbols.Base.Execute<bool>();
			this.rxRealim = new System.HMI.Symbols.Base.Execute<bool>();
			// 
			// titulo
			// 
			this.titulo.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.titulo.Font = new NxtControl.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
			this.titulo.Location = new NxtControl.Drawing.PointF(20D, 12D);
			this.titulo.Name = "titulo";
			this.titulo.Text = "Diagn\u00f3stico";
			// 
			// secEstados
			// 
			this.secEstados.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.secEstados.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.secEstados.Location = new NxtControl.Drawing.PointF(20D, 44D);
			this.secEstados.Name = "secEstados";
			this.secEstados.Text = "Estados";
			// 
			// estados
			// 
			this.estados.BeginInit();
			this.estados.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 20D, 66D);
			this.estados.Name = "estados";
			this.estados.SecurityToken = ((uint)(4294967295u));
			this.estados.TagName = "Base";
			this.estados.EndInit();
			// 
			// secAcion
			// 
			this.secAcion.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.secAcion.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.secAcion.Location = new NxtControl.Drawing.PointF(20D, 270D);
			this.secAcion.Name = "secAcion";
			this.secAcion.Text = "Acionamento";
			// 
			// r_Pronto
			// 
			this.r_Pronto.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.r_Pronto.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.r_Pronto.Location = new NxtControl.Drawing.PointF(20D, 295D);
			this.r_Pronto.Name = "r_Pronto";
			this.r_Pronto.Text = "Inversor pronto";
			// 
			// v_Pronto
			// 
			this.v_Pronto.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.v_Pronto.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.v_Pronto.Location = new NxtControl.Drawing.PointF(224D, 295D);
			this.v_Pronto.Name = "v_Pronto";
			this.v_Pronto.Text = "\u2014";
			// 
			// r_Circ
			// 
			this.r_Circ.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.r_Circ.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.r_Circ.Location = new NxtControl.Drawing.PointF(20D, 319D);
			this.r_Circ.Name = "r_Circ";
			this.r_Circ.Text = "Circuito el\u00e9trico";
			// 
			// v_Circ
			// 
			this.v_Circ.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.v_Circ.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.v_Circ.Location = new NxtControl.Drawing.PointF(224D, 319D);
			this.v_Circ.Name = "v_Circ";
			this.v_Circ.Text = "\u2014";
			// 
			// r_Realim
			// 
			this.r_Realim.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.r_Realim.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.r_Realim.Location = new NxtControl.Drawing.PointF(20D, 343D);
			this.r_Realim.Name = "r_Realim";
			this.r_Realim.Text = "Falha de realimenta\u00e7\u00e3o";
			// 
			// v_Realim
			// 
			this.v_Realim.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.v_Realim.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.v_Realim.Location = new NxtControl.Drawing.PointF(224D, 343D);
			this.v_Realim.Name = "v_Realim";
			this.v_Realim.Text = "\u2014";
			// 
			// rxPronto
			// 
			this.rxPronto.BeginInit();
			this.rxPronto.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.rxPronto.IsOnlyInput = true;
			this.rxPronto.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.rxPronto.Name = "rxPronto";
			this.rxPronto.SecurityLevel = 0;
			this.rxPronto.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.rxPronto.TagName = "AtvNotReady";
			this.rxPronto.Value = false;
			this.rxPronto.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.rxProntoChanged);
			this.rxPronto.EndInit();
			// 
			// rxCirc
			// 
			this.rxCirc.BeginInit();
			this.rxCirc.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.rxCirc.IsOnlyInput = true;
			this.rxCirc.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.rxCirc.Name = "rxCirc";
			this.rxCirc.SecurityLevel = 0;
			this.rxCirc.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.rxCirc.TagName = "ElectricCircuitFail";
			this.rxCirc.Value = false;
			this.rxCirc.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.rxCircChanged);
			this.rxCirc.EndInit();
			// 
			// rxRealim
			// 
			this.rxRealim.BeginInit();
			this.rxRealim.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.rxRealim.IsOnlyInput = true;
			this.rxRealim.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.rxRealim.Name = "rxRealim";
			this.rxRealim.SecurityLevel = 0;
			this.rxRealim.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.rxRealim.TagName = "FbFailure";
			this.rxRealim.Value = false;
			this.rxRealim.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.rxRealimChanged);
			this.rxRealim.EndInit();
			// 
			// fpDiagnostico
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(380D)), ((float)(376D)));
			this.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(224)), ((byte)(224)), ((byte)(224))));
			this.FormBorderStyle = NxtControl.GuiFramework.FormBorderStyle.FixedSingle;
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.titulo,
			this.secEstados,
			this.estados,
			this.secAcion,
			this.r_Pronto,
			this.v_Pronto,
			this.r_Circ,
			this.v_Circ,
			this.r_Realim,
			this.v_Realim,
			this.rxPronto,
			this.rxCirc,
			this.rxRealim});
			this.Size = new System.Drawing.Size(380, 376);

		}
		private NxtControl.GuiFramework.FreeText titulo;
		private NxtControl.GuiFramework.FreeText secEstados;
		private SE.Nereda.Symbols.MotorBaseNer.sDiagnostico estados;
		private NxtControl.GuiFramework.FreeText secAcion;
		private NxtControl.GuiFramework.FreeText r_Pronto;
		private NxtControl.GuiFramework.FreeText v_Pronto;
		private NxtControl.GuiFramework.FreeText r_Circ;
		private NxtControl.GuiFramework.FreeText v_Circ;
		private NxtControl.GuiFramework.FreeText r_Realim;
		private NxtControl.GuiFramework.FreeText v_Realim;
		private System.HMI.Symbols.Base.Execute<bool> rxPronto;
		private System.HMI.Symbols.Base.Execute<bool> rxCirc;
		private System.HMI.Symbols.Base.Execute<bool> rxRealim;

		#endregion
	}
}
