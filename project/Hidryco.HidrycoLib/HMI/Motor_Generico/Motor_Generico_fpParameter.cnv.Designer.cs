/*
 * Hidryco - Motor_Generico - fpParameter
 * ISA-101: tempos de supervisao de partida/parada e velocidade manual (so com inversor).
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Faceplates.Motor_Generico
{
	/// <summary>
	/// Summary description for fpParameter.
	/// </summary>
	partial class fpParameter
	{

		#region Component Designer generated code
		private void InitializeComponent()
		{
			this.titulo = new NxtControl.GuiFramework.FreeText();
			this.lblLig = new NxtControl.GuiFramework.FreeText();
			this.tLig = new System.HMI.Symbols.Base.TextBox<ushort>();
			this.lblDes = new NxtControl.GuiFramework.FreeText();
			this.tDes = new System.HMI.Symbols.Base.TextBox<ushort>();
			this.lblZero = new NxtControl.GuiFramework.FreeText();
			this.lblVel = new NxtControl.GuiFramework.FreeText();
			this.vManual = new System.HMI.Symbols.Base.TextBox<float>();
			this.xInversor = new System.HMI.Symbols.Base.Execute<bool>();
			// 
			// titulo
			// 
			this.titulo.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.titulo.Font = new NxtControl.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
			this.titulo.Location = new NxtControl.Drawing.PointF(20D, 12D);
			this.titulo.Name = "titulo";
			this.titulo.Text = "Ajustes do motor";
			// 
			// lblLig
			// 
			this.lblLig.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.lblLig.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.lblLig.Location = new NxtControl.Drawing.PointF(20D, 56D);
			this.lblLig.Name = "lblLig";
			this.lblLig.Text = "Tempo máx. para confirmar partida";
			// 
			// tLig
			// 
			this.tLig.BeginInit();
			this.tLig.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.5D, 0D, 0D, 1D, 260D, 50D);
			this.tLig.MaximumTag = null;
			this.tLig.MinimumTag = null;
			this.tLig.Name = "tLig";
			this.tLig.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.tLig.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.tLig.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.tLig.Suffix = " s";
			this.tLig.TagName = "STP_FALHA_LIGAMENTO";
			this.tLig.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.tLig.UseInputPad = true;
			this.tLig.Value = ((ushort)(0));
			this.tLig.EndInit();
			// 
			// lblDes
			// 
			this.lblDes.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.lblDes.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.lblDes.Location = new NxtControl.Drawing.PointF(20D, 96D);
			this.lblDes.Name = "lblDes";
			this.lblDes.Text = "Tempo máx. para confirmar parada";
			// 
			// tDes
			// 
			this.tDes.BeginInit();
			this.tDes.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.5D, 0D, 0D, 1D, 260D, 90D);
			this.tDes.MaximumTag = null;
			this.tDes.MinimumTag = null;
			this.tDes.Name = "tDes";
			this.tDes.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.tDes.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.tDes.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.tDes.Suffix = " s";
			this.tDes.TagName = "STP_FALHA_DESLIGAMENTO";
			this.tDes.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.tDes.UseInputPad = true;
			this.tDes.Value = ((ushort)(0));
			this.tDes.EndInit();
			// 
			// lblZero
			// 
			this.lblZero.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.lblZero.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.lblZero.Location = new NxtControl.Drawing.PointF(20D, 124D);
			this.lblZero.Name = "lblZero";
			this.lblZero.Text = "0 = supervisão desligada";
			// 
			// lblVel
			// 
			this.lblVel.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.lblVel.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.lblVel.Location = new NxtControl.Drawing.PointF(20D, 160D);
			this.lblVel.Name = "lblVel";
			this.lblVel.Text = "Velocidade em manual";
			this.lblVel.Visible = false;
			// 
			// vManual
			// 
			this.vManual.BeginInit();
			this.vManual.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.5D, 0D, 0D, 1D, 260D, 154D);
			this.vManual.MaximumTag = null;
			this.vManual.MinimumTag = null;
			this.vManual.Name = "vManual";
			this.vManual.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.vManual.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.vManual.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.vManual.Suffix = " %";
			this.vManual.TagName = "STP_SAIDA_MANUAL";
			this.vManual.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.vManual.UseInputPad = true;
			this.vManual.Value = 0F;
			this.vManual.Visible = false;
			this.vManual.EndInit();
			// 
			// xInversor
			// 
			this.xInversor.BeginInit();
			this.xInversor.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xInversor.IsOnlyInput = true;
			this.xInversor.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xInversor.Name = "xInversor";
			this.xInversor.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xInversor.TagName = "STS_INVERSOR";
			this.xInversor.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.InversorValueChanged);
			this.xInversor.EndInit();
			// 
			// fpParameter
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(360D)), ((float)(210D)));
			this.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(224)), ((byte)(224)), ((byte)(224))));
			this.Name = "fpParameter";
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.titulo,
			this.lblLig,
			this.tLig,
			this.lblDes,
			this.tDes,
			this.lblZero,
			this.lblVel,
			this.vManual,
			this.xInversor});
			this.Size = new System.Drawing.Size(360, 210);

		}
		private NxtControl.GuiFramework.FreeText titulo;
		private NxtControl.GuiFramework.FreeText lblLig;
		private System.HMI.Symbols.Base.TextBox<ushort> tLig;
		private NxtControl.GuiFramework.FreeText lblDes;
		private System.HMI.Symbols.Base.TextBox<ushort> tDes;
		private NxtControl.GuiFramework.FreeText lblZero;
		private NxtControl.GuiFramework.FreeText lblVel;
		private System.HMI.Symbols.Base.TextBox<float> vManual;
		private System.HMI.Symbols.Base.Execute<bool> xInversor;
		#endregion
	}
}
