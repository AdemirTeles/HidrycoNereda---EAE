/*
 * Hidryco - Sensor_Generico - fpParameter
 * ISA-101: ajustes do sensor (habilitacao, escala, altura maxima) e diagnostico do sinal.
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Faceplates.Sensor_Generico
{
	/// <summary>
	/// Summary description for fpParameter.
	/// </summary>
	partial class fpParameter
	{

		#region Component Designer generated code
		private void InitializeComponent()
		{
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary1 = new NxtControl.GuiFramework.PropertyDictionary();
			this.titulo = new NxtControl.GuiFramework.FreeText();
			this.origem = new NxtControl.GuiFramework.FreeText();
			this.lblHabilita = new NxtControl.GuiFramework.FreeText();
			this.habilita = new System.HMI.Symbols.Base.CheckButton();
			this.lblMin = new NxtControl.GuiFramework.FreeText();
			this.rangeMin = new System.HMI.Symbols.Base.TextBox<float>();
			this.lblMax = new NxtControl.GuiFramework.FreeText();
			this.rangeMax = new System.HMI.Symbols.Base.TextBox<float>();
			this.lblAltura = new NxtControl.GuiFramework.FreeText();
			this.altura = new System.HMI.Symbols.Base.TextBox<float>();
			this.sep = new NxtControl.GuiFramework.Rectangle();
			this.lblBruto = new NxtControl.GuiFramework.FreeText();
			this.bruto = new System.HMI.Symbols.Base.Label<System.Single>();
			this.lblFalhaAtiva = new NxtControl.GuiFramework.FreeText();
			this.sinalBom = new NxtControl.GuiFramework.FreeText();
			this.sinalP1 = new NxtControl.GuiFramework.Rectangle();
			this.sinalP1n = new NxtControl.GuiFramework.FreeText();
			this.sinalP2 = new NxtControl.GuiFramework.Polygon();
			this.sinalP2n = new NxtControl.GuiFramework.FreeText();
			this.sinalTxt = new NxtControl.GuiFramework.FreeText();
			this.xComunicacao = new System.HMI.Symbols.Base.Execute<bool>();
			this.xNivel = new System.HMI.Symbols.Base.Execute<bool>();
			this.xUnidade = new System.HMI.Symbols.Base.Execute<string>();
			this.xFalhaAtiva = new System.HMI.Symbols.Base.Execute<bool>();
			this.rHabHH = new System.HMI.Symbols.Base.CheckButton();
			this.rHabH = new System.HMI.Symbols.Base.CheckButton();
			this.rHabL = new System.HMI.Symbols.Base.CheckButton();
			this.rHabLL = new System.HMI.Symbols.Base.CheckButton();
			this.rSpHH = new System.HMI.Symbols.Base.TextBox<float>();
			this.rSpH = new System.HMI.Symbols.Base.TextBox<float>();
			this.rSpL = new System.HMI.Symbols.Base.TextBox<float>();
			this.rSpLL = new System.HMI.Symbols.Base.TextBox<float>();
			this.rTempoHH = new System.HMI.Symbols.Base.TextBox<ushort>();
			this.rTempoH = new System.HMI.Symbols.Base.TextBox<ushort>();
			this.rTempoL = new System.HMI.Symbols.Base.TextBox<ushort>();
			this.rTempoLL = new System.HMI.Symbols.Base.TextBox<ushort>();
			// 
			// titulo
			// 
			this.titulo.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.titulo.Font = new NxtControl.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
			this.titulo.Location = new NxtControl.Drawing.PointF(20D, 12D);
			this.titulo.Name = "titulo";
			this.titulo.Text = "Ajustes do sensor";
			// 
			// origem
			// 
			this.origem.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.origem.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.origem.Location = new NxtControl.Drawing.PointF(20D, 36D);
			this.origem.Name = "origem";
			this.origem.Text = "Origem: entrada 4-20 mA";
			// 
			// lblHabilita
			// 
			this.lblHabilita.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.lblHabilita.Font = new NxtControl.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular);
			this.lblHabilita.Location = new NxtControl.Drawing.PointF(20D, 70D);
			this.lblHabilita.Name = "lblHabilita";
			this.lblHabilita.Text = "Sensor";
			// 
			// habilita
			// 
			this.habilita.BeginInit();
			this.habilita.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 220D, 64D);
			this.habilita.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.habilita.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.habilita.FalseText = "Desabilitado";
			this.habilita.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.habilita.FontScale = false;
			this.habilita.Name = "habilita";
			this.habilita.TagName = "CMD_HABILITA_SENSOR";
			this.habilita.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.habilita.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.habilita.TrueText = "Habilitado";
			this.habilita.Value = false;
			this.habilita.EndInit();
			// 
			// lblMin
			// 
			this.lblMin.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.lblMin.Font = new NxtControl.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular);
			this.lblMin.Location = new NxtControl.Drawing.PointF(20D, 116D);
			this.lblMin.Name = "lblMin";
			this.lblMin.Text = "Valor em 4 mA";
			// 
			// rangeMin
			// 
			this.rangeMin.BeginInit();
			this.rangeMin.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.7D, 0D, 0D, 1D, 220D, 112D);
			this.rangeMin.MaximumTag = null;
			this.rangeMin.MinimumTag = null;
			this.rangeMin.Name = "rangeMin";
			this.rangeMin.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.rangeMin.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.rangeMin.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.rangeMin.TagName = "STP_RANGE_MINIMO";
			this.rangeMin.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.rangeMin.UseInputPad = true;
			this.rangeMin.Value = 0F;
			this.rangeMin.EndInit();
			// 
			// lblMax
			// 
			this.lblMax.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.lblMax.Font = new NxtControl.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular);
			this.lblMax.Location = new NxtControl.Drawing.PointF(20D, 156D);
			this.lblMax.Name = "lblMax";
			this.lblMax.Text = "Valor em 20 mA";
			// 
			// rangeMax
			// 
			this.rangeMax.BeginInit();
			this.rangeMax.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.7D, 0D, 0D, 1D, 220D, 152D);
			this.rangeMax.MaximumTag = null;
			this.rangeMax.MinimumTag = null;
			this.rangeMax.Name = "rangeMax";
			this.rangeMax.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.rangeMax.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.rangeMax.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.rangeMax.TagName = "STP_RANGE_MAXIMO";
			this.rangeMax.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.rangeMax.UseInputPad = true;
			this.rangeMax.Value = 0F;
			this.rangeMax.EndInit();
			// 
			// lblAltura
			// 
			this.lblAltura.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.lblAltura.Font = new NxtControl.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular);
			this.lblAltura.Location = new NxtControl.Drawing.PointF(20D, 196D);
			this.lblAltura.Name = "lblAltura";
			this.lblAltura.Text = "Altura máxima (100 %)";
			this.lblAltura.Visible = false;
			// 
			// altura
			// 
			this.altura.BeginInit();
			this.altura.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.7D, 0D, 0D, 1D, 220D, 192D);
			this.altura.MaximumTag = null;
			this.altura.MinimumTag = null;
			this.altura.Name = "altura";
			this.altura.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.altura.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.altura.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.altura.TagName = "STP_ALTURA_MAXIMA";
			this.altura.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.altura.UseInputPad = true;
			this.altura.Value = 0F;
			this.altura.Visible = false;
			this.altura.EndInit();
			// 
			// sep
			// 
			this.sep.Bounds = new NxtControl.Drawing.RectF(((float)(20D)), ((float)(236D)), ((float)(340D)), ((float)(1D)));
			this.sep.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))));
			this.sep.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.sep.Name = "sep";
			this.sep.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// lblBruto
			// 
			this.lblBruto.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.lblBruto.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.lblBruto.Location = new NxtControl.Drawing.PointF(20D, 250D);
			this.lblBruto.Name = "lblBruto";
			this.lblBruto.Text = "Valor bruto recebido";
			// 
			// bruto
			// 
			this.bruto.BeginInit();
			this.bruto.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.bruto.DecimalPlacesCount = ((uint)(1u));
			this.bruto.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.7D, 0D, 0D, 1D, 220D, 246D);
			this.bruto.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.bruto.FontScale = false;
			this.bruto.IsOnlyInput = true;
			this.bruto.IsPrefixSuffixOutside = false;
			this.bruto.LeadingZeros = ((uint)(0u));
			this.bruto.Name = "bruto";
			this.bruto.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			propertyDictionary1.Add("Text", "${Value}");
			propertyDictionary1.Add("TextColor", new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64))));
			propertyDictionary1.Add("Brush", new NxtControl.Drawing.Brush(true));
			propertyDictionary1.Add("Pen", new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid));
			this.bruto.Ranges.DefaultPropertyValues = propertyDictionary1;
			this.bruto.Suffix = "";
			this.bruto.TagName = "STS_BRUTO";
			this.bruto.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.bruto.EndInit();
			// 
			// lblFalhaAtiva
			// 
			this.lblFalhaAtiva.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.lblFalhaAtiva.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.lblFalhaAtiva.Location = new NxtControl.Drawing.PointF(20D, 282D);
			this.lblFalhaAtiva.Name = "lblFalhaAtiva";
			this.lblFalhaAtiva.Text = "Sinal agora";
			// 
			// sinalBom
			// 
			this.sinalBom.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.sinalBom.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.sinalBom.Location = new NxtControl.Drawing.PointF(224D, 282D);
			this.sinalBom.Name = "sinalBom";
			this.sinalBom.Text = "bom";
			// 
			// sinalP1
			// 
			this.sinalP1.Bounds = new NxtControl.Drawing.RectF(((float)(220D)), ((float)(280D)), ((float)(16D)), ((float)(16D)));
			this.sinalP1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(230)), ((byte)(0)), ((byte)(0))));
			this.sinalP1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.sinalP1.Name = "sinalP1";
			this.sinalP1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.sinalP1.Visible = false;
			// 
			// sinalP1n
			// 
			this.sinalP1n.Color = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.sinalP1n.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.sinalP1n.Location = new NxtControl.Drawing.PointF(224D, 281D);
			this.sinalP1n.Name = "sinalP1n";
			this.sinalP1n.Text = "1";
			this.sinalP1n.Visible = false;
			// 
			// sinalP2
			// 
			this.sinalP2.Bounds = new NxtControl.Drawing.RectF(((float)(220D)), ((float)(280D)), ((float)(16D)), ((float)(16D)));
			this.sinalP2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(205)), ((byte)(0))));
			this.sinalP2.Closed = true;
			this.sinalP2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.sinalP2.Name = "sinalP2";
			this.sinalP2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.sinalP2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(220D, 296D),
			new NxtControl.Drawing.PointF(228D, 280D),
			new NxtControl.Drawing.PointF(236D, 296D)});
			this.sinalP2.Visible = false;
			// 
			// sinalP2n
			// 
			this.sinalP2n.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.sinalP2n.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
			this.sinalP2n.Location = new NxtControl.Drawing.PointF(225D, 284D);
			this.sinalP2n.Name = "sinalP2n";
			this.sinalP2n.Text = "2";
			this.sinalP2n.Visible = false;
			// 
			// sinalTxt
			// 
			this.sinalTxt.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.sinalTxt.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.sinalTxt.Location = new NxtControl.Drawing.PointF(240D, 280D);
			this.sinalTxt.Name = "sinalTxt";
			this.sinalTxt.Text = "";
			this.sinalTxt.Visible = false;
			// 
			// xComunicacao
			// 
			this.xComunicacao.BeginInit();
			this.xComunicacao.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xComunicacao.IsOnlyInput = true;
			this.xComunicacao.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xComunicacao.Name = "xComunicacao";
			this.xComunicacao.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xComunicacao.TagName = "CFG_COMUNICACAO";
			this.xComunicacao.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.ComunicacaoValueChanged);
			this.xComunicacao.EndInit();
			// 
			// xNivel
			// 
			this.xNivel.BeginInit();
			this.xNivel.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xNivel.IsOnlyInput = true;
			this.xNivel.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xNivel.Name = "xNivel";
			this.xNivel.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xNivel.TagName = "CFG_NIVEL";
			this.xNivel.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.NivelValueChanged);
			this.xNivel.EndInit();
			// 
			// xUnidade
			// 
			this.xUnidade.BeginInit();
			this.xUnidade.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xUnidade.IsOnlyInput = true;
			this.xUnidade.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xUnidade.Name = "xUnidade";
			this.xUnidade.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xUnidade.TagName = "CFG_UNIDADE";
			this.xUnidade.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.UnidadeValueChanged);
			this.xUnidade.EndInit();
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
			// rHabHH
			// 
			this.rHabHH.BeginInit();
			this.rHabHH.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 70D, 84D);
			this.rHabHH.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.rHabHH.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.rHabHH.FalseText = "Não";
			this.rHabHH.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.rHabHH.FontScale = false;
			this.rHabHH.Name = "rHabHH";
			this.rHabHH.TagName = "CMD_HABILITA_ALARME_HH";
			this.rHabHH.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.rHabHH.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.rHabHH.TrueText = "Sim";
			this.rHabHH.Value = false;
			this.rHabHH.Visible = false;
			this.rHabHH.EndInit();
			// 
			// rHabH
			// 
			this.rHabH.BeginInit();
			this.rHabH.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 70D, 124D);
			this.rHabH.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.rHabH.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.rHabH.FalseText = "Não";
			this.rHabH.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.rHabH.FontScale = false;
			this.rHabH.Name = "rHabH";
			this.rHabH.TagName = "CMD_HABILITA_ALARME_H";
			this.rHabH.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.rHabH.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.rHabH.TrueText = "Sim";
			this.rHabH.Value = false;
			this.rHabH.Visible = false;
			this.rHabH.EndInit();
			// 
			// rHabL
			// 
			this.rHabL.BeginInit();
			this.rHabL.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 70D, 164D);
			this.rHabL.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.rHabL.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.rHabL.FalseText = "Não";
			this.rHabL.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.rHabL.FontScale = false;
			this.rHabL.Name = "rHabL";
			this.rHabL.TagName = "CMD_HABILITA_ALARME_L";
			this.rHabL.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.rHabL.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.rHabL.TrueText = "Sim";
			this.rHabL.Value = false;
			this.rHabL.Visible = false;
			this.rHabL.EndInit();
			// 
			// rHabLL
			// 
			this.rHabLL.BeginInit();
			this.rHabLL.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 70D, 204D);
			this.rHabLL.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.rHabLL.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.rHabLL.FalseText = "Não";
			this.rHabLL.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.rHabLL.FontScale = false;
			this.rHabLL.Name = "rHabLL";
			this.rHabLL.TagName = "CMD_HABILITA_ALARME_LL";
			this.rHabLL.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.rHabLL.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.rHabLL.TrueText = "Sim";
			this.rHabLL.Value = false;
			this.rHabLL.Visible = false;
			this.rHabLL.EndInit();
			// 
			// rSpHH
			// 
			this.rSpHH.BeginInit();
			this.rSpHH.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.62D, 0D, 0D, 1D, 196D, 86D);
			this.rSpHH.MaximumTag = null;
			this.rSpHH.MinimumTag = null;
			this.rSpHH.Name = "rSpHH";
			this.rSpHH.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.rSpHH.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.rSpHH.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.rSpHH.TagName = "STP_ALARME_HH";
			this.rSpHH.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.rSpHH.UseInputPad = true;
			this.rSpHH.Value = 0F;
			this.rSpHH.Visible = false;
			this.rSpHH.EndInit();
			// 
			// rSpH
			// 
			this.rSpH.BeginInit();
			this.rSpH.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.62D, 0D, 0D, 1D, 196D, 126D);
			this.rSpH.MaximumTag = null;
			this.rSpH.MinimumTag = null;
			this.rSpH.Name = "rSpH";
			this.rSpH.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.rSpH.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.rSpH.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.rSpH.TagName = "STP_ALARME_H";
			this.rSpH.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.rSpH.UseInputPad = true;
			this.rSpH.Value = 0F;
			this.rSpH.Visible = false;
			this.rSpH.EndInit();
			// 
			// rSpL
			// 
			this.rSpL.BeginInit();
			this.rSpL.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.62D, 0D, 0D, 1D, 196D, 166D);
			this.rSpL.MaximumTag = null;
			this.rSpL.MinimumTag = null;
			this.rSpL.Name = "rSpL";
			this.rSpL.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.rSpL.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.rSpL.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.rSpL.TagName = "STP_ALARME_L";
			this.rSpL.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.rSpL.UseInputPad = true;
			this.rSpL.Value = 0F;
			this.rSpL.Visible = false;
			this.rSpL.EndInit();
			// 
			// rSpLL
			// 
			this.rSpLL.BeginInit();
			this.rSpLL.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.62D, 0D, 0D, 1D, 196D, 206D);
			this.rSpLL.MaximumTag = null;
			this.rSpLL.MinimumTag = null;
			this.rSpLL.Name = "rSpLL";
			this.rSpLL.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.rSpLL.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.rSpLL.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.rSpLL.TagName = "STP_ALARME_LL";
			this.rSpLL.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.rSpLL.UseInputPad = true;
			this.rSpLL.Value = 0F;
			this.rSpLL.Visible = false;
			this.rSpLL.EndInit();
			// 
			// rTempoHH
			// 
			this.rTempoHH.BeginInit();
			this.rTempoHH.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.42D, 0D, 0D, 1D, 300D, 86D);
			this.rTempoHH.MaximumTag = null;
			this.rTempoHH.MinimumTag = null;
			this.rTempoHH.Name = "rTempoHH";
			this.rTempoHH.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.rTempoHH.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.rTempoHH.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.rTempoHH.TagName = "STP_TEMPO_ALARME_HH";
			this.rTempoHH.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.rTempoHH.UseInputPad = true;
			this.rTempoHH.Value = ((ushort)(0));
			this.rTempoHH.Visible = false;
			this.rTempoHH.EndInit();
			// 
			// rTempoH
			// 
			this.rTempoH.BeginInit();
			this.rTempoH.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.42D, 0D, 0D, 1D, 300D, 126D);
			this.rTempoH.MaximumTag = null;
			this.rTempoH.MinimumTag = null;
			this.rTempoH.Name = "rTempoH";
			this.rTempoH.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.rTempoH.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.rTempoH.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.rTempoH.TagName = "STP_TEMPO_ALARME_H";
			this.rTempoH.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.rTempoH.UseInputPad = true;
			this.rTempoH.Value = ((ushort)(0));
			this.rTempoH.Visible = false;
			this.rTempoH.EndInit();
			// 
			// rTempoL
			// 
			this.rTempoL.BeginInit();
			this.rTempoL.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.42D, 0D, 0D, 1D, 300D, 166D);
			this.rTempoL.MaximumTag = null;
			this.rTempoL.MinimumTag = null;
			this.rTempoL.Name = "rTempoL";
			this.rTempoL.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.rTempoL.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.rTempoL.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.rTempoL.TagName = "STP_TEMPO_ALARME_L";
			this.rTempoL.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.rTempoL.UseInputPad = true;
			this.rTempoL.Value = ((ushort)(0));
			this.rTempoL.Visible = false;
			this.rTempoL.EndInit();
			// 
			// rTempoLL
			// 
			this.rTempoLL.BeginInit();
			this.rTempoLL.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.42D, 0D, 0D, 1D, 300D, 206D);
			this.rTempoLL.MaximumTag = null;
			this.rTempoLL.MinimumTag = null;
			this.rTempoLL.Name = "rTempoLL";
			this.rTempoLL.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.rTempoLL.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.rTempoLL.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.rTempoLL.TagName = "STP_TEMPO_ALARME_LL";
			this.rTempoLL.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.rTempoLL.UseInputPad = true;
			this.rTempoLL.Value = ((ushort)(0));
			this.rTempoLL.Visible = false;
			this.rTempoLL.EndInit();
			// 
			// fpParameter
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(380D)), ((float)(330D)));
			this.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(224)), ((byte)(224)), ((byte)(224))));
			this.Name = "fpParameter";
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.titulo,
			this.origem,
			this.lblHabilita,
			this.habilita,
			this.lblMin,
			this.rangeMin,
			this.lblMax,
			this.rangeMax,
			this.lblAltura,
			this.altura,
			this.sep,
			this.lblBruto,
			this.bruto,
			this.lblFalhaAtiva,
			this.sinalBom,
			this.sinalP1,
			this.sinalP1n,
			this.sinalP2,
			this.sinalP2n,
			this.sinalTxt,
			this.xComunicacao,
			this.xNivel,
			this.xUnidade,
			this.xFalhaAtiva,
			this.rHabHH,
			this.rHabH,
			this.rHabL,
			this.rHabLL,
			this.rSpHH,
			this.rSpH,
			this.rSpL,
			this.rSpLL,
			this.rTempoHH,
			this.rTempoH,
			this.rTempoL,
			this.rTempoLL});
			this.Size = new System.Drawing.Size(380, 330);

		}
		private NxtControl.GuiFramework.FreeText titulo;
		private NxtControl.GuiFramework.FreeText origem;
		private NxtControl.GuiFramework.FreeText lblHabilita;
		private System.HMI.Symbols.Base.CheckButton habilita;
		private NxtControl.GuiFramework.FreeText lblMin;
		private System.HMI.Symbols.Base.TextBox<float> rangeMin;
		private NxtControl.GuiFramework.FreeText lblMax;
		private System.HMI.Symbols.Base.TextBox<float> rangeMax;
		private NxtControl.GuiFramework.FreeText lblAltura;
		private System.HMI.Symbols.Base.TextBox<float> altura;
		private NxtControl.GuiFramework.Rectangle sep;
		private NxtControl.GuiFramework.FreeText lblBruto;
		private System.HMI.Symbols.Base.Label<System.Single> bruto;
		private NxtControl.GuiFramework.FreeText lblFalhaAtiva;
		private NxtControl.GuiFramework.FreeText sinalBom;
		private NxtControl.GuiFramework.Rectangle sinalP1;
		private NxtControl.GuiFramework.FreeText sinalP1n;
		private NxtControl.GuiFramework.Polygon sinalP2;
		private NxtControl.GuiFramework.FreeText sinalP2n;
		private NxtControl.GuiFramework.FreeText sinalTxt;
		private System.HMI.Symbols.Base.Execute<bool> xComunicacao;
		private System.HMI.Symbols.Base.Execute<bool> xNivel;
		private System.HMI.Symbols.Base.Execute<string> xUnidade;
		private System.HMI.Symbols.Base.Execute<bool> xFalhaAtiva;
		private System.HMI.Symbols.Base.CheckButton rHabHH;
		private System.HMI.Symbols.Base.CheckButton rHabH;
		private System.HMI.Symbols.Base.CheckButton rHabL;
		private System.HMI.Symbols.Base.CheckButton rHabLL;
		private System.HMI.Symbols.Base.TextBox<float> rSpHH;
		private System.HMI.Symbols.Base.TextBox<float> rSpH;
		private System.HMI.Symbols.Base.TextBox<float> rSpL;
		private System.HMI.Symbols.Base.TextBox<float> rSpLL;
		private System.HMI.Symbols.Base.TextBox<ushort> rTempoHH;
		private System.HMI.Symbols.Base.TextBox<ushort> rTempoH;
		private System.HMI.Symbols.Base.TextBox<ushort> rTempoL;
		private System.HMI.Symbols.Base.TextBox<ushort> rTempoLL;
		#endregion
	}
}
