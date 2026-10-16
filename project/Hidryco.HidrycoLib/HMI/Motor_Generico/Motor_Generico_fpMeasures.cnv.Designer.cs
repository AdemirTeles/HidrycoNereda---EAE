/*
 * Hidryco - Motor_Generico - fpMeasures
 * ISA-101: medicoes do inversor (texto preto sobre cinza, unidade em todos os valores).
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Faceplates.Motor_Generico
{
	/// <summary>
	/// Summary description for fpMeasures.
	/// </summary>
	partial class fpMeasures
	{

		#region Component Designer generated code
		private void InitializeComponent()
		{
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary1 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary2 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary3 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary4 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary5 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary6 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary7 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary8 = new NxtControl.GuiFramework.PropertyDictionary();
			this.titulo = new NxtControl.GuiFramework.FreeText();
			this.lSTS_VELOCIDADE = new NxtControl.GuiFramework.Rectangle();
			this.tSTS_VELOCIDADE = new NxtControl.GuiFramework.FreeText();
			this.vSTS_VELOCIDADE = new System.HMI.Symbols.Base.Label<float>();
			this.lSTS_FREQUENCIA = new NxtControl.GuiFramework.Rectangle();
			this.tSTS_FREQUENCIA = new NxtControl.GuiFramework.FreeText();
			this.vSTS_FREQUENCIA = new System.HMI.Symbols.Base.Label<float>();
			this.lSTS_CORRENTE = new NxtControl.GuiFramework.Rectangle();
			this.tSTS_CORRENTE = new NxtControl.GuiFramework.FreeText();
			this.vSTS_CORRENTE = new System.HMI.Symbols.Base.Label<float>();
			this.lSTS_TENSAO = new NxtControl.GuiFramework.Rectangle();
			this.tSTS_TENSAO = new NxtControl.GuiFramework.FreeText();
			this.vSTS_TENSAO = new System.HMI.Symbols.Base.Label<float>();
			this.lSTS_POTENCIA = new NxtControl.GuiFramework.Rectangle();
			this.tSTS_POTENCIA = new NxtControl.GuiFramework.FreeText();
			this.vSTS_POTENCIA = new System.HMI.Symbols.Base.Label<float>();
			this.lSTS_TORQUE = new NxtControl.GuiFramework.Rectangle();
			this.tSTS_TORQUE = new NxtControl.GuiFramework.FreeText();
			this.vSTS_TORQUE = new System.HMI.Symbols.Base.Label<float>();
			this.lSTS_RPM = new NxtControl.GuiFramework.Rectangle();
			this.tSTS_RPM = new NxtControl.GuiFramework.FreeText();
			this.vSTS_RPM = new System.HMI.Symbols.Base.Label<float>();
			this.lSTS_CODIGO_FALHA = new NxtControl.GuiFramework.Rectangle();
			this.tSTS_CODIGO_FALHA = new NxtControl.GuiFramework.FreeText();
			this.vSTS_CODIGO_FALHA = new System.HMI.Symbols.Base.Label<float>();
			// 
			// titulo
			// 
			this.titulo.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.titulo.Font = new NxtControl.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
			this.titulo.Location = new NxtControl.Drawing.PointF(20D, 12D);
			this.titulo.Name = "titulo";
			this.titulo.Text = "Medições do inversor";
			// 
			// lSTS_VELOCIDADE
			// 
			this.lSTS_VELOCIDADE.Bounds = new NxtControl.Drawing.RectF(((float)(12D)), ((float)(46D)), ((float)(296D)), ((float)(30D)));
			this.lSTS_VELOCIDADE.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(235)), ((byte)(235)), ((byte)(235))));
			this.lSTS_VELOCIDADE.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.lSTS_VELOCIDADE.Name = "lSTS_VELOCIDADE";
			this.lSTS_VELOCIDADE.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// tSTS_VELOCIDADE
			// 
			this.tSTS_VELOCIDADE.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.tSTS_VELOCIDADE.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.tSTS_VELOCIDADE.Location = new NxtControl.Drawing.PointF(24D, 52D);
			this.tSTS_VELOCIDADE.Name = "tSTS_VELOCIDADE";
			this.tSTS_VELOCIDADE.Text = "Velocidade";
			// 
			// vSTS_VELOCIDADE
			// 
			this.vSTS_VELOCIDADE.BeginInit();
			this.vSTS_VELOCIDADE.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.vSTS_VELOCIDADE.DecimalPlacesCount = ((uint)(1u));
			this.vSTS_VELOCIDADE.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.625D, 0D, 0D, 1D, 192D, 48D);
			this.vSTS_VELOCIDADE.Font = new NxtControl.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
			this.vSTS_VELOCIDADE.FontScale = false;
			this.vSTS_VELOCIDADE.IsOnlyInput = true;
			this.vSTS_VELOCIDADE.IsPrefixSuffixOutside = false;
			this.vSTS_VELOCIDADE.LeadingZeros = ((uint)(0u));
			this.vSTS_VELOCIDADE.Name = "vSTS_VELOCIDADE";
			this.vSTS_VELOCIDADE.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			propertyDictionary1.Add("Text", "${Value}");
			propertyDictionary1.Add("TextColor", new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			propertyDictionary1.Add("Brush", new NxtControl.Drawing.Brush(true));
			propertyDictionary1.Add("Pen", new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid));
			this.vSTS_VELOCIDADE.Ranges.DefaultPropertyValues = propertyDictionary1;
			this.vSTS_VELOCIDADE.Suffix = " %";
			this.vSTS_VELOCIDADE.TagName = "STS_VELOCIDADE";
			this.vSTS_VELOCIDADE.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.vSTS_VELOCIDADE.EndInit();
			// 
			// lSTS_FREQUENCIA
			// 
			this.lSTS_FREQUENCIA.Bounds = new NxtControl.Drawing.RectF(((float)(12D)), ((float)(80D)), ((float)(296D)), ((float)(30D)));
			this.lSTS_FREQUENCIA.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(235)), ((byte)(235)), ((byte)(235))));
			this.lSTS_FREQUENCIA.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.lSTS_FREQUENCIA.Name = "lSTS_FREQUENCIA";
			this.lSTS_FREQUENCIA.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// tSTS_FREQUENCIA
			// 
			this.tSTS_FREQUENCIA.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.tSTS_FREQUENCIA.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.tSTS_FREQUENCIA.Location = new NxtControl.Drawing.PointF(24D, 86D);
			this.tSTS_FREQUENCIA.Name = "tSTS_FREQUENCIA";
			this.tSTS_FREQUENCIA.Text = "Frequência";
			// 
			// vSTS_FREQUENCIA
			// 
			this.vSTS_FREQUENCIA.BeginInit();
			this.vSTS_FREQUENCIA.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.vSTS_FREQUENCIA.DecimalPlacesCount = ((uint)(1u));
			this.vSTS_FREQUENCIA.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.6667D, 0D, 0D, 1D, 192D, 80D);
			this.vSTS_FREQUENCIA.Font = new NxtControl.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
			this.vSTS_FREQUENCIA.FontScale = false;
			this.vSTS_FREQUENCIA.IsOnlyInput = true;
			this.vSTS_FREQUENCIA.IsPrefixSuffixOutside = false;
			this.vSTS_FREQUENCIA.LeadingZeros = ((uint)(0u));
			this.vSTS_FREQUENCIA.Name = "vSTS_FREQUENCIA";
			this.vSTS_FREQUENCIA.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			propertyDictionary2.Add("Text", "${Value}");
			propertyDictionary2.Add("TextColor", new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			propertyDictionary2.Add("Brush", new NxtControl.Drawing.Brush(true));
			propertyDictionary2.Add("Pen", new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid));
			this.vSTS_FREQUENCIA.Ranges.DefaultPropertyValues = propertyDictionary2;
			this.vSTS_FREQUENCIA.Suffix = " Hz";
			this.vSTS_FREQUENCIA.TagName = "STS_FREQUENCIA";
			this.vSTS_FREQUENCIA.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.vSTS_FREQUENCIA.EndInit();
			// 
			// lSTS_CORRENTE
			// 
			this.lSTS_CORRENTE.Bounds = new NxtControl.Drawing.RectF(((float)(12D)), ((float)(114D)), ((float)(296D)), ((float)(30D)));
			this.lSTS_CORRENTE.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(235)), ((byte)(235)), ((byte)(235))));
			this.lSTS_CORRENTE.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.lSTS_CORRENTE.Name = "lSTS_CORRENTE";
			this.lSTS_CORRENTE.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// tSTS_CORRENTE
			// 
			this.tSTS_CORRENTE.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.tSTS_CORRENTE.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.tSTS_CORRENTE.Location = new NxtControl.Drawing.PointF(24D, 120D);
			this.tSTS_CORRENTE.Name = "tSTS_CORRENTE";
			this.tSTS_CORRENTE.Text = "Corrente";
			// 
			// vSTS_CORRENTE
			// 
			this.vSTS_CORRENTE.BeginInit();
			this.vSTS_CORRENTE.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.vSTS_CORRENTE.DecimalPlacesCount = ((uint)(1u));
			this.vSTS_CORRENTE.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.6022D, 0D, 0D, 1D, 192D, 120D);
			this.vSTS_CORRENTE.Font = new NxtControl.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
			this.vSTS_CORRENTE.FontScale = false;
			this.vSTS_CORRENTE.IsOnlyInput = true;
			this.vSTS_CORRENTE.IsPrefixSuffixOutside = false;
			this.vSTS_CORRENTE.LeadingZeros = ((uint)(0u));
			this.vSTS_CORRENTE.Name = "vSTS_CORRENTE";
			this.vSTS_CORRENTE.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			propertyDictionary3.Add("Text", "${Value}");
			propertyDictionary3.Add("TextColor", new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			propertyDictionary3.Add("Brush", new NxtControl.Drawing.Brush(true));
			propertyDictionary3.Add("Pen", new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid));
			this.vSTS_CORRENTE.Ranges.DefaultPropertyValues = propertyDictionary3;
			this.vSTS_CORRENTE.Suffix = " A";
			this.vSTS_CORRENTE.TagName = "STS_CORRENTE";
			this.vSTS_CORRENTE.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.vSTS_CORRENTE.EndInit();
			// 
			// lSTS_TENSAO
			// 
			this.lSTS_TENSAO.Bounds = new NxtControl.Drawing.RectF(((float)(12D)), ((float)(148D)), ((float)(296D)), ((float)(30D)));
			this.lSTS_TENSAO.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(235)), ((byte)(235)), ((byte)(235))));
			this.lSTS_TENSAO.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.lSTS_TENSAO.Name = "lSTS_TENSAO";
			this.lSTS_TENSAO.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// tSTS_TENSAO
			// 
			this.tSTS_TENSAO.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.tSTS_TENSAO.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.tSTS_TENSAO.Location = new NxtControl.Drawing.PointF(24D, 154D);
			this.tSTS_TENSAO.Name = "tSTS_TENSAO";
			this.tSTS_TENSAO.Text = "Tensão";
			// 
			// vSTS_TENSAO
			// 
			this.vSTS_TENSAO.BeginInit();
			this.vSTS_TENSAO.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.vSTS_TENSAO.DecimalPlacesCount = ((uint)(0u));
			this.vSTS_TENSAO.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.6022D, 0D, 0D, 1D, 192D, 152D);
			this.vSTS_TENSAO.Font = new NxtControl.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
			this.vSTS_TENSAO.FontScale = false;
			this.vSTS_TENSAO.IsOnlyInput = true;
			this.vSTS_TENSAO.IsPrefixSuffixOutside = false;
			this.vSTS_TENSAO.LeadingZeros = ((uint)(0u));
			this.vSTS_TENSAO.Name = "vSTS_TENSAO";
			this.vSTS_TENSAO.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			propertyDictionary4.Add("Text", "${Value}");
			propertyDictionary4.Add("TextColor", new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			propertyDictionary4.Add("Brush", new NxtControl.Drawing.Brush(true));
			propertyDictionary4.Add("Pen", new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid));
			this.vSTS_TENSAO.Ranges.DefaultPropertyValues = propertyDictionary4;
			this.vSTS_TENSAO.Suffix = " V";
			this.vSTS_TENSAO.TagName = "STS_TENSAO";
			this.vSTS_TENSAO.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.vSTS_TENSAO.EndInit();
			// 
			// lSTS_POTENCIA
			// 
			this.lSTS_POTENCIA.Bounds = new NxtControl.Drawing.RectF(((float)(12D)), ((float)(182D)), ((float)(296D)), ((float)(30D)));
			this.lSTS_POTENCIA.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(235)), ((byte)(235)), ((byte)(235))));
			this.lSTS_POTENCIA.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.lSTS_POTENCIA.Name = "lSTS_POTENCIA";
			this.lSTS_POTENCIA.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// tSTS_POTENCIA
			// 
			this.tSTS_POTENCIA.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.tSTS_POTENCIA.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.tSTS_POTENCIA.Location = new NxtControl.Drawing.PointF(24D, 188D);
			this.tSTS_POTENCIA.Name = "tSTS_POTENCIA";
			this.tSTS_POTENCIA.Text = "Potência";
			// 
			// vSTS_POTENCIA
			// 
			this.vSTS_POTENCIA.BeginInit();
			this.vSTS_POTENCIA.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.vSTS_POTENCIA.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.7016D, 0D, 0D, 1D, 192D, 184D);
			this.vSTS_POTENCIA.Font = new NxtControl.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
			this.vSTS_POTENCIA.FontScale = false;
			this.vSTS_POTENCIA.IsOnlyInput = true;
			this.vSTS_POTENCIA.IsPrefixSuffixOutside = false;
			this.vSTS_POTENCIA.LeadingZeros = ((uint)(0u));
			this.vSTS_POTENCIA.Name = "vSTS_POTENCIA";
			this.vSTS_POTENCIA.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			propertyDictionary5.Add("Text", "${Value}");
			propertyDictionary5.Add("TextColor", new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			propertyDictionary5.Add("Brush", new NxtControl.Drawing.Brush(true));
			propertyDictionary5.Add("Pen", new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid));
			this.vSTS_POTENCIA.Ranges.DefaultPropertyValues = propertyDictionary5;
			this.vSTS_POTENCIA.Suffix = " kW";
			this.vSTS_POTENCIA.TagName = "STS_POTENCIA";
			this.vSTS_POTENCIA.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.vSTS_POTENCIA.EndInit();
			// 
			// lSTS_TORQUE
			// 
			this.lSTS_TORQUE.Bounds = new NxtControl.Drawing.RectF(((float)(12D)), ((float)(216D)), ((float)(296D)), ((float)(30D)));
			this.lSTS_TORQUE.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(235)), ((byte)(235)), ((byte)(235))));
			this.lSTS_TORQUE.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.lSTS_TORQUE.Name = "lSTS_TORQUE";
			this.lSTS_TORQUE.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// tSTS_TORQUE
			// 
			this.tSTS_TORQUE.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.tSTS_TORQUE.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.tSTS_TORQUE.Location = new NxtControl.Drawing.PointF(24D, 222D);
			this.tSTS_TORQUE.Name = "tSTS_TORQUE";
			this.tSTS_TORQUE.Text = "Torque";
			// 
			// vSTS_TORQUE
			// 
			this.vSTS_TORQUE.BeginInit();
			this.vSTS_TORQUE.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.vSTS_TORQUE.DecimalPlacesCount = ((uint)(1u));
			this.vSTS_TORQUE.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.625D, 0D, 0D, 1D, 192D, 216D);
			this.vSTS_TORQUE.Font = new NxtControl.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
			this.vSTS_TORQUE.FontScale = false;
			this.vSTS_TORQUE.IsOnlyInput = true;
			this.vSTS_TORQUE.IsPrefixSuffixOutside = false;
			this.vSTS_TORQUE.LeadingZeros = ((uint)(0u));
			this.vSTS_TORQUE.Name = "vSTS_TORQUE";
			this.vSTS_TORQUE.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			propertyDictionary6.Add("Text", "${Value}");
			propertyDictionary6.Add("TextColor", new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			propertyDictionary6.Add("Brush", new NxtControl.Drawing.Brush(true));
			propertyDictionary6.Add("Pen", new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid));
			this.vSTS_TORQUE.Ranges.DefaultPropertyValues = propertyDictionary6;
			this.vSTS_TORQUE.Suffix = " %";
			this.vSTS_TORQUE.TagName = "STS_TORQUE";
			this.vSTS_TORQUE.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.vSTS_TORQUE.EndInit();
			// 
			// lSTS_RPM
			// 
			this.lSTS_RPM.Bounds = new NxtControl.Drawing.RectF(((float)(12D)), ((float)(250D)), ((float)(296D)), ((float)(30D)));
			this.lSTS_RPM.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(235)), ((byte)(235)), ((byte)(235))));
			this.lSTS_RPM.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.lSTS_RPM.Name = "lSTS_RPM";
			this.lSTS_RPM.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// tSTS_RPM
			// 
			this.tSTS_RPM.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.tSTS_RPM.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.tSTS_RPM.Location = new NxtControl.Drawing.PointF(24D, 256D);
			this.tSTS_RPM.Name = "tSTS_RPM";
			this.tSTS_RPM.Text = "Rotação";
			// 
			// vSTS_RPM
			// 
			this.vSTS_RPM.BeginInit();
			this.vSTS_RPM.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.vSTS_RPM.DecimalPlacesCount = ((uint)(0u));
			this.vSTS_RPM.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.7498D, 0D, 0D, 1D, 192D, 256D);
			this.vSTS_RPM.Font = new NxtControl.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
			this.vSTS_RPM.FontScale = false;
			this.vSTS_RPM.IsOnlyInput = true;
			this.vSTS_RPM.IsPrefixSuffixOutside = false;
			this.vSTS_RPM.LeadingZeros = ((uint)(0u));
			this.vSTS_RPM.Name = "vSTS_RPM";
			this.vSTS_RPM.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			propertyDictionary7.Add("Text", "${Value}");
			propertyDictionary7.Add("TextColor", new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			propertyDictionary7.Add("Brush", new NxtControl.Drawing.Brush(true));
			propertyDictionary7.Add("Pen", new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid));
			this.vSTS_RPM.Ranges.DefaultPropertyValues = propertyDictionary7;
			this.vSTS_RPM.Suffix = " rpm";
			this.vSTS_RPM.TagName = "STS_RPM";
			this.vSTS_RPM.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.vSTS_RPM.EndInit();
			// 
			// lSTS_CODIGO_FALHA
			// 
			this.lSTS_CODIGO_FALHA.Bounds = new NxtControl.Drawing.RectF(((float)(12D)), ((float)(284D)), ((float)(296D)), ((float)(30D)));
			this.lSTS_CODIGO_FALHA.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(235)), ((byte)(235)), ((byte)(235))));
			this.lSTS_CODIGO_FALHA.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.lSTS_CODIGO_FALHA.Name = "lSTS_CODIGO_FALHA";
			this.lSTS_CODIGO_FALHA.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// tSTS_CODIGO_FALHA
			// 
			this.tSTS_CODIGO_FALHA.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.tSTS_CODIGO_FALHA.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.tSTS_CODIGO_FALHA.Location = new NxtControl.Drawing.PointF(24D, 290D);
			this.tSTS_CODIGO_FALHA.Name = "tSTS_CODIGO_FALHA";
			this.tSTS_CODIGO_FALHA.Text = "Código de falha";
			// 
			// vSTS_CODIGO_FALHA
			// 
			this.vSTS_CODIGO_FALHA.BeginInit();
			this.vSTS_CODIGO_FALHA.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.vSTS_CODIGO_FALHA.DecimalPlacesCount = ((uint)(0u));
			this.vSTS_CODIGO_FALHA.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.48999999999999994D, 0D, 0D, 1D, 192D, 288D);
			this.vSTS_CODIGO_FALHA.Font = new NxtControl.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
			this.vSTS_CODIGO_FALHA.FontScale = false;
			this.vSTS_CODIGO_FALHA.IsOnlyInput = true;
			this.vSTS_CODIGO_FALHA.IsPrefixSuffixOutside = false;
			this.vSTS_CODIGO_FALHA.LeadingZeros = ((uint)(0u));
			this.vSTS_CODIGO_FALHA.Name = "vSTS_CODIGO_FALHA";
			this.vSTS_CODIGO_FALHA.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			propertyDictionary8.Add("Text", "${Value}");
			propertyDictionary8.Add("TextColor", new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			propertyDictionary8.Add("Brush", new NxtControl.Drawing.Brush(true));
			propertyDictionary8.Add("Pen", new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid));
			this.vSTS_CODIGO_FALHA.Ranges.DefaultPropertyValues = propertyDictionary8;
			this.vSTS_CODIGO_FALHA.TagName = "STS_CODIGO_FALHA";
			this.vSTS_CODIGO_FALHA.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.vSTS_CODIGO_FALHA.EndInit();
			// 
			// fpMeasures
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(320D)), ((float)(332D)));
			this.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(224)), ((byte)(224)), ((byte)(224))));
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.titulo,
			this.lSTS_VELOCIDADE,
			this.tSTS_VELOCIDADE,
			this.vSTS_VELOCIDADE,
			this.lSTS_FREQUENCIA,
			this.tSTS_FREQUENCIA,
			this.vSTS_FREQUENCIA,
			this.lSTS_CORRENTE,
			this.tSTS_CORRENTE,
			this.vSTS_CORRENTE,
			this.lSTS_TENSAO,
			this.tSTS_TENSAO,
			this.vSTS_TENSAO,
			this.lSTS_POTENCIA,
			this.tSTS_POTENCIA,
			this.vSTS_POTENCIA,
			this.lSTS_TORQUE,
			this.tSTS_TORQUE,
			this.vSTS_TORQUE,
			this.lSTS_RPM,
			this.tSTS_RPM,
			this.vSTS_RPM,
			this.lSTS_CODIGO_FALHA,
			this.tSTS_CODIGO_FALHA,
			this.vSTS_CODIGO_FALHA});
			this.Size = new System.Drawing.Size(320, 332);

		}
		private NxtControl.GuiFramework.FreeText titulo;
		private NxtControl.GuiFramework.Rectangle lSTS_VELOCIDADE;
		private NxtControl.GuiFramework.FreeText tSTS_VELOCIDADE;
		private System.HMI.Symbols.Base.Label<System.Single> vSTS_VELOCIDADE;
		private NxtControl.GuiFramework.Rectangle lSTS_FREQUENCIA;
		private NxtControl.GuiFramework.FreeText tSTS_FREQUENCIA;
		private System.HMI.Symbols.Base.Label<System.Single> vSTS_FREQUENCIA;
		private NxtControl.GuiFramework.Rectangle lSTS_CORRENTE;
		private NxtControl.GuiFramework.FreeText tSTS_CORRENTE;
		private System.HMI.Symbols.Base.Label<System.Single> vSTS_CORRENTE;
		private NxtControl.GuiFramework.Rectangle lSTS_TENSAO;
		private NxtControl.GuiFramework.FreeText tSTS_TENSAO;
		private System.HMI.Symbols.Base.Label<System.Single> vSTS_TENSAO;
		private NxtControl.GuiFramework.Rectangle lSTS_POTENCIA;
		private NxtControl.GuiFramework.FreeText tSTS_POTENCIA;
		private System.HMI.Symbols.Base.Label<System.Single> vSTS_POTENCIA;
		private NxtControl.GuiFramework.Rectangle lSTS_TORQUE;
		private NxtControl.GuiFramework.FreeText tSTS_TORQUE;
		private System.HMI.Symbols.Base.Label<System.Single> vSTS_TORQUE;
		private NxtControl.GuiFramework.Rectangle lSTS_RPM;
		private NxtControl.GuiFramework.FreeText tSTS_RPM;
		private System.HMI.Symbols.Base.Label<System.Single> vSTS_RPM;
		private NxtControl.GuiFramework.Rectangle lSTS_CODIGO_FALHA;
		private NxtControl.GuiFramework.FreeText tSTS_CODIGO_FALHA;
		private System.HMI.Symbols.Base.Label<System.Single> vSTS_CODIGO_FALHA;
		#endregion
	}
}
