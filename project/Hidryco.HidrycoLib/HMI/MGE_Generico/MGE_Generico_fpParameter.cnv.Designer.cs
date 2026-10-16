/*
 * Hidryco - MGE_Generico - fpParameter
 * ISA-101: valores de referencia e tempos de retardo dos alarmes do medidor (referencia 0 = alarme desligado).
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Faceplates.MGE_Generico
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
			this.sepFP = new NxtControl.GuiFramework.Rectangle();
			this.gFP = new NxtControl.GuiFramework.FreeText();
			this.ltFP = new NxtControl.GuiFramework.FreeText();
			this.tFP = new System.HMI.Symbols.Base.TextBox<ushort>();
			this.lFPL = new NxtControl.GuiFramework.FreeText();
			this.sFPL = new System.HMI.Symbols.Base.TextBox<float>();
			this.sepTEN = new NxtControl.GuiFramework.Rectangle();
			this.gTEN = new NxtControl.GuiFramework.FreeText();
			this.ltTEN = new NxtControl.GuiFramework.FreeText();
			this.tTEN = new System.HMI.Symbols.Base.TextBox<ushort>();
			this.lVFH = new NxtControl.GuiFramework.FreeText();
			this.sVFH = new System.HMI.Symbols.Base.TextBox<float>();
			this.lVFL = new NxtControl.GuiFramework.FreeText();
			this.sVFL = new System.HMI.Symbols.Base.TextBox<float>();
			this.lVNH = new NxtControl.GuiFramework.FreeText();
			this.sVNH = new System.HMI.Symbols.Base.TextBox<float>();
			this.lVNL = new NxtControl.GuiFramework.FreeText();
			this.sVNL = new System.HMI.Symbols.Base.TextBox<float>();
			this.sepCOR = new NxtControl.GuiFramework.Rectangle();
			this.gCOR = new NxtControl.GuiFramework.FreeText();
			this.ltCOR = new NxtControl.GuiFramework.FreeText();
			this.tCOR = new System.HMI.Symbols.Base.TextBox<ushort>();
			this.lIH = new NxtControl.GuiFramework.FreeText();
			this.sIH = new System.HMI.Symbols.Base.TextBox<float>();
			this.lIL = new NxtControl.GuiFramework.FreeText();
			this.sIL = new System.HMI.Symbols.Base.TextBox<float>();
			this.sepFRE = new NxtControl.GuiFramework.Rectangle();
			this.gFRE = new NxtControl.GuiFramework.FreeText();
			this.ltFRE = new NxtControl.GuiFramework.FreeText();
			this.tFRE = new System.HMI.Symbols.Base.TextBox<ushort>();
			this.lFRH = new NxtControl.GuiFramework.FreeText();
			this.sFRH = new System.HMI.Symbols.Base.TextBox<float>();
			this.lFRL = new NxtControl.GuiFramework.FreeText();
			this.sFRL = new System.HMI.Symbols.Base.TextBox<float>();
			this.ajuda = new NxtControl.GuiFramework.FreeText();
			// 
			// titulo
			// 
			this.titulo.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.titulo.Font = new NxtControl.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
			this.titulo.Location = new NxtControl.Drawing.PointF(20D, 12D);
			this.titulo.Name = "titulo";
			this.titulo.Text = "Ajustes dos alarmes";
			// 
			// sepFP
			// 
			this.sepFP.Bounds = new NxtControl.Drawing.RectF(((float)(20D)), ((float)(46D)), ((float)(520D)), ((float)(1D)));
			this.sepFP.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))));
			this.sepFP.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.sepFP.Name = "sepFP";
			this.sepFP.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// gFP
			// 
			this.gFP.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.gFP.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.gFP.Location = new NxtControl.Drawing.PointF(20D, 56D);
			this.gFP.Name = "gFP";
			this.gFP.Text = "Fator de potência";
			// 
			// ltFP
			// 
			this.ltFP.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.ltFP.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.ltFP.Location = new NxtControl.Drawing.PointF(250D, 56D);
			this.ltFP.Name = "ltFP";
			this.ltFP.Text = "Retardo";
			// 
			// tFP
			// 
			this.tFP.BeginInit();
			this.tFP.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.5D, 0D, 0D, 1D, 410D, 50D);
			this.tFP.MaximumTag = null;
			this.tFP.MinimumTag = null;
			this.tFP.Name = "tFP";
			this.tFP.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.tFP.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.tFP.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.tFP.Suffix = " s";
			this.tFP.TagName = "STP_TEMPO_FP";
			this.tFP.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.tFP.UseInputPad = true;
			this.tFP.Value = ((ushort)(0));
			this.tFP.EndInit();
			// 
			// lFPL
			// 
			this.lFPL.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.lFPL.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.lFPL.Location = new NxtControl.Drawing.PointF(40D, 94D);
			this.lFPL.Name = "lFPL";
			this.lFPL.Text = "Fator de potência baixo (abaixo de)";
			// 
			// sFPL
			// 
			this.sFPL.BeginInit();
			this.sFPL.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.6D, 0D, 0D, 1D, 410D, 88D);
			this.sFPL.MaximumTag = null;
			this.sFPL.MinimumTag = null;
			this.sFPL.Name = "sFPL";
			this.sFPL.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.sFPL.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.sFPL.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.sFPL.Suffix = "";
			this.sFPL.TagName = "STP_FP_BAIXO";
			this.sFPL.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.sFPL.UseInputPad = true;
			this.sFPL.Value = 0F;
			this.sFPL.EndInit();
			// 
			// sepTEN
			// 
			this.sepTEN.Bounds = new NxtControl.Drawing.RectF(((float)(20D)), ((float)(124D)), ((float)(520D)), ((float)(1D)));
			this.sepTEN.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))));
			this.sepTEN.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.sepTEN.Name = "sepTEN";
			this.sepTEN.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// gTEN
			// 
			this.gTEN.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.gTEN.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.gTEN.Location = new NxtControl.Drawing.PointF(20D, 134D);
			this.gTEN.Name = "gTEN";
			this.gTEN.Text = "Tensão";
			// 
			// ltTEN
			// 
			this.ltTEN.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.ltTEN.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.ltTEN.Location = new NxtControl.Drawing.PointF(250D, 134D);
			this.ltTEN.Name = "ltTEN";
			this.ltTEN.Text = "Retardo";
			// 
			// tTEN
			// 
			this.tTEN.BeginInit();
			this.tTEN.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.5D, 0D, 0D, 1D, 410D, 128D);
			this.tTEN.MaximumTag = null;
			this.tTEN.MinimumTag = null;
			this.tTEN.Name = "tTEN";
			this.tTEN.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.tTEN.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.tTEN.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.tTEN.Suffix = " s";
			this.tTEN.TagName = "STP_TEMPO_TENSAO";
			this.tTEN.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.tTEN.UseInputPad = true;
			this.tTEN.Value = ((ushort)(0));
			this.tTEN.EndInit();
			// 
			// lVFH
			// 
			this.lVFH.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.lVFH.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.lVFH.Location = new NxtControl.Drawing.PointF(40D, 172D);
			this.lVFH.Name = "lVFH";
			this.lVFH.Text = "Tensão entre fases alta (acima de)";
			// 
			// sVFH
			// 
			this.sVFH.BeginInit();
			this.sVFH.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.6D, 0D, 0D, 1D, 410D, 166D);
			this.sVFH.MaximumTag = null;
			this.sVFH.MinimumTag = null;
			this.sVFH.Name = "sVFH";
			this.sVFH.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.sVFH.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.sVFH.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.sVFH.Suffix = " V";
			this.sVFH.TagName = "STP_TENSAO_FF_H";
			this.sVFH.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.sVFH.UseInputPad = true;
			this.sVFH.Value = 0F;
			this.sVFH.EndInit();
			// 
			// lVFL
			// 
			this.lVFL.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.lVFL.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.lVFL.Location = new NxtControl.Drawing.PointF(40D, 208D);
			this.lVFL.Name = "lVFL";
			this.lVFL.Text = "Tensão entre fases baixa (abaixo de)";
			// 
			// sVFL
			// 
			this.sVFL.BeginInit();
			this.sVFL.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.6D, 0D, 0D, 1D, 410D, 202D);
			this.sVFL.MaximumTag = null;
			this.sVFL.MinimumTag = null;
			this.sVFL.Name = "sVFL";
			this.sVFL.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.sVFL.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.sVFL.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.sVFL.Suffix = " V";
			this.sVFL.TagName = "STP_TENSAO_FF_L";
			this.sVFL.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.sVFL.UseInputPad = true;
			this.sVFL.Value = 0F;
			this.sVFL.EndInit();
			// 
			// lVNH
			// 
			this.lVNH.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.lVNH.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.lVNH.Location = new NxtControl.Drawing.PointF(40D, 244D);
			this.lVNH.Name = "lVNH";
			this.lVNH.Text = "Tensão fase-neutro alta (acima de)";
			// 
			// sVNH
			// 
			this.sVNH.BeginInit();
			this.sVNH.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.6D, 0D, 0D, 1D, 410D, 238D);
			this.sVNH.MaximumTag = null;
			this.sVNH.MinimumTag = null;
			this.sVNH.Name = "sVNH";
			this.sVNH.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.sVNH.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.sVNH.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.sVNH.Suffix = " V";
			this.sVNH.TagName = "STP_TENSAO_FN_H";
			this.sVNH.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.sVNH.UseInputPad = true;
			this.sVNH.Value = 0F;
			this.sVNH.EndInit();
			// 
			// lVNL
			// 
			this.lVNL.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.lVNL.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.lVNL.Location = new NxtControl.Drawing.PointF(40D, 280D);
			this.lVNL.Name = "lVNL";
			this.lVNL.Text = "Tensão fase-neutro baixa (abaixo de)";
			// 
			// sVNL
			// 
			this.sVNL.BeginInit();
			this.sVNL.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.6D, 0D, 0D, 1D, 410D, 274D);
			this.sVNL.MaximumTag = null;
			this.sVNL.MinimumTag = null;
			this.sVNL.Name = "sVNL";
			this.sVNL.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.sVNL.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.sVNL.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.sVNL.Suffix = " V";
			this.sVNL.TagName = "STP_TENSAO_FN_L";
			this.sVNL.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.sVNL.UseInputPad = true;
			this.sVNL.Value = 0F;
			this.sVNL.EndInit();
			// 
			// sepCOR
			// 
			this.sepCOR.Bounds = new NxtControl.Drawing.RectF(((float)(20D)), ((float)(310D)), ((float)(520D)), ((float)(1D)));
			this.sepCOR.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))));
			this.sepCOR.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.sepCOR.Name = "sepCOR";
			this.sepCOR.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// gCOR
			// 
			this.gCOR.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.gCOR.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.gCOR.Location = new NxtControl.Drawing.PointF(20D, 320D);
			this.gCOR.Name = "gCOR";
			this.gCOR.Text = "Corrente";
			// 
			// ltCOR
			// 
			this.ltCOR.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.ltCOR.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.ltCOR.Location = new NxtControl.Drawing.PointF(250D, 320D);
			this.ltCOR.Name = "ltCOR";
			this.ltCOR.Text = "Retardo";
			// 
			// tCOR
			// 
			this.tCOR.BeginInit();
			this.tCOR.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.5D, 0D, 0D, 1D, 410D, 314D);
			this.tCOR.MaximumTag = null;
			this.tCOR.MinimumTag = null;
			this.tCOR.Name = "tCOR";
			this.tCOR.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.tCOR.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.tCOR.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.tCOR.Suffix = " s";
			this.tCOR.TagName = "STP_TEMPO_CORRENTE";
			this.tCOR.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.tCOR.UseInputPad = true;
			this.tCOR.Value = ((ushort)(0));
			this.tCOR.EndInit();
			// 
			// lIH
			// 
			this.lIH.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.lIH.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.lIH.Location = new NxtControl.Drawing.PointF(40D, 358D);
			this.lIH.Name = "lIH";
			this.lIH.Text = "Corrente alta - fases A, B e C (acima de)";
			// 
			// sIH
			// 
			this.sIH.BeginInit();
			this.sIH.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.6D, 0D, 0D, 1D, 410D, 352D);
			this.sIH.MaximumTag = null;
			this.sIH.MinimumTag = null;
			this.sIH.Name = "sIH";
			this.sIH.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.sIH.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.sIH.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.sIH.Suffix = " A";
			this.sIH.TagName = "STP_CORRENTE_H";
			this.sIH.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.sIH.UseInputPad = true;
			this.sIH.Value = 0F;
			this.sIH.EndInit();
			// 
			// lIL
			// 
			this.lIL.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.lIL.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.lIL.Location = new NxtControl.Drawing.PointF(40D, 394D);
			this.lIL.Name = "lIL";
			this.lIL.Text = "Corrente baixa - fases A, B e C (abaixo de)";
			// 
			// sIL
			// 
			this.sIL.BeginInit();
			this.sIL.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.6D, 0D, 0D, 1D, 410D, 388D);
			this.sIL.MaximumTag = null;
			this.sIL.MinimumTag = null;
			this.sIL.Name = "sIL";
			this.sIL.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.sIL.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.sIL.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.sIL.Suffix = " A";
			this.sIL.TagName = "STP_CORRENTE_L";
			this.sIL.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.sIL.UseInputPad = true;
			this.sIL.Value = 0F;
			this.sIL.EndInit();
			// 
			// sepFRE
			// 
			this.sepFRE.Bounds = new NxtControl.Drawing.RectF(((float)(20D)), ((float)(424D)), ((float)(520D)), ((float)(1D)));
			this.sepFRE.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))));
			this.sepFRE.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.sepFRE.Name = "sepFRE";
			this.sepFRE.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// gFRE
			// 
			this.gFRE.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.gFRE.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.gFRE.Location = new NxtControl.Drawing.PointF(20D, 434D);
			this.gFRE.Name = "gFRE";
			this.gFRE.Text = "Frequência";
			// 
			// ltFRE
			// 
			this.ltFRE.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.ltFRE.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.ltFRE.Location = new NxtControl.Drawing.PointF(250D, 434D);
			this.ltFRE.Name = "ltFRE";
			this.ltFRE.Text = "Retardo";
			// 
			// tFRE
			// 
			this.tFRE.BeginInit();
			this.tFRE.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.5D, 0D, 0D, 1D, 410D, 428D);
			this.tFRE.MaximumTag = null;
			this.tFRE.MinimumTag = null;
			this.tFRE.Name = "tFRE";
			this.tFRE.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.tFRE.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.tFRE.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.tFRE.Suffix = " s";
			this.tFRE.TagName = "STP_TEMPO_FREQUENCIA";
			this.tFRE.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.tFRE.UseInputPad = true;
			this.tFRE.Value = ((ushort)(0));
			this.tFRE.EndInit();
			// 
			// lFRH
			// 
			this.lFRH.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.lFRH.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.lFRH.Location = new NxtControl.Drawing.PointF(40D, 472D);
			this.lFRH.Name = "lFRH";
			this.lFRH.Text = "Frequência alta (acima de)";
			// 
			// sFRH
			// 
			this.sFRH.BeginInit();
			this.sFRH.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.6D, 0D, 0D, 1D, 410D, 466D);
			this.sFRH.MaximumTag = null;
			this.sFRH.MinimumTag = null;
			this.sFRH.Name = "sFRH";
			this.sFRH.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.sFRH.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.sFRH.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.sFRH.Suffix = " Hz";
			this.sFRH.TagName = "STP_FREQUENCIA_H";
			this.sFRH.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.sFRH.UseInputPad = true;
			this.sFRH.Value = 0F;
			this.sFRH.EndInit();
			// 
			// lFRL
			// 
			this.lFRL.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.lFRL.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.lFRL.Location = new NxtControl.Drawing.PointF(40D, 508D);
			this.lFRL.Name = "lFRL";
			this.lFRL.Text = "Frequência baixa (abaixo de)";
			// 
			// sFRL
			// 
			this.sFRL.BeginInit();
			this.sFRL.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.6D, 0D, 0D, 1D, 410D, 502D);
			this.sFRL.MaximumTag = null;
			this.sFRL.MinimumTag = null;
			this.sFRL.Name = "sFRL";
			this.sFRL.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.sFRL.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.sFRL.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.sFRL.Suffix = " Hz";
			this.sFRL.TagName = "STP_FREQUENCIA_L";
			this.sFRL.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.sFRL.UseInputPad = true;
			this.sFRL.Value = 0F;
			this.sFRL.EndInit();
			// 
			// ajuda
			// 
			this.ajuda.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.ajuda.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.ajuda.Location = new NxtControl.Drawing.PointF(20D, 546D);
			this.ajuda.Name = "ajuda";
			this.ajuda.Text = "Valor de referência 0 = alarme desligado.";
			// 
			// fpParameter
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(560D)), ((float)(572D)));
			this.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(224)), ((byte)(224)), ((byte)(224))));
			this.Name = "fpParameter";
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.titulo,
			this.sepFP,
			this.gFP,
			this.ltFP,
			this.tFP,
			this.lFPL,
			this.sFPL,
			this.sepTEN,
			this.gTEN,
			this.ltTEN,
			this.tTEN,
			this.lVFH,
			this.sVFH,
			this.lVFL,
			this.sVFL,
			this.lVNH,
			this.sVNH,
			this.lVNL,
			this.sVNL,
			this.sepCOR,
			this.gCOR,
			this.ltCOR,
			this.tCOR,
			this.lIH,
			this.sIH,
			this.lIL,
			this.sIL,
			this.sepFRE,
			this.gFRE,
			this.ltFRE,
			this.tFRE,
			this.lFRH,
			this.sFRH,
			this.lFRL,
			this.sFRL,
			this.ajuda});
			this.Size = new System.Drawing.Size(560, 572);

		}
		private NxtControl.GuiFramework.FreeText titulo;
		private NxtControl.GuiFramework.Rectangle sepFP;
		private NxtControl.GuiFramework.FreeText gFP;
		private NxtControl.GuiFramework.FreeText ltFP;
		private System.HMI.Symbols.Base.TextBox<ushort> tFP;
		private NxtControl.GuiFramework.FreeText lFPL;
		private System.HMI.Symbols.Base.TextBox<float> sFPL;
		private NxtControl.GuiFramework.Rectangle sepTEN;
		private NxtControl.GuiFramework.FreeText gTEN;
		private NxtControl.GuiFramework.FreeText ltTEN;
		private System.HMI.Symbols.Base.TextBox<ushort> tTEN;
		private NxtControl.GuiFramework.FreeText lVFH;
		private System.HMI.Symbols.Base.TextBox<float> sVFH;
		private NxtControl.GuiFramework.FreeText lVFL;
		private System.HMI.Symbols.Base.TextBox<float> sVFL;
		private NxtControl.GuiFramework.FreeText lVNH;
		private System.HMI.Symbols.Base.TextBox<float> sVNH;
		private NxtControl.GuiFramework.FreeText lVNL;
		private System.HMI.Symbols.Base.TextBox<float> sVNL;
		private NxtControl.GuiFramework.Rectangle sepCOR;
		private NxtControl.GuiFramework.FreeText gCOR;
		private NxtControl.GuiFramework.FreeText ltCOR;
		private System.HMI.Symbols.Base.TextBox<ushort> tCOR;
		private NxtControl.GuiFramework.FreeText lIH;
		private System.HMI.Symbols.Base.TextBox<float> sIH;
		private NxtControl.GuiFramework.FreeText lIL;
		private System.HMI.Symbols.Base.TextBox<float> sIL;
		private NxtControl.GuiFramework.Rectangle sepFRE;
		private NxtControl.GuiFramework.FreeText gFRE;
		private NxtControl.GuiFramework.FreeText ltFRE;
		private System.HMI.Symbols.Base.TextBox<ushort> tFRE;
		private NxtControl.GuiFramework.FreeText lFRH;
		private System.HMI.Symbols.Base.TextBox<float> sFRH;
		private NxtControl.GuiFramework.FreeText lFRL;
		private System.HMI.Symbols.Base.TextBox<float> sFRL;
		private NxtControl.GuiFramework.FreeText ajuda;
		#endregion
	}
}
