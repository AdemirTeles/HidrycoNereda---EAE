/*
 * Hidryco - Sensor_Generico - fpDefault
 * ISA-101: valor, estado em texto, indicador de alarme, indicador analogico com limites, tabela de alarmes, reset e navegacao.
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Faceplates.Sensor_Generico
{
	/// <summary>
	/// Summary description for fpDefault.
	/// </summary>
	partial class fpDefault
	{

		#region Component Designer generated code
		private void InitializeComponent()
		{
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary1 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary2 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary3 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary4 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary5 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary7 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary8 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary6 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary9 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary11 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary12 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary10 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary13 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary15 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary16 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary14 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary17 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary19 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary20 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary18 = new NxtControl.GuiFramework.PropertyDictionary();
			this.cabecalho = new NxtControl.GuiFramework.Rectangle();
			this.tituloValor = new NxtControl.GuiFramework.FreeText();
			this.valor = new System.HMI.Symbols.Base.Label<float>();
			this.invalido = new NxtControl.GuiFramework.FreeText();
			this.textoEstado = new NxtControl.GuiFramework.FreeText();
			this.alP1 = new NxtControl.GuiFramework.Rectangle();
			this.alP1n = new NxtControl.GuiFramework.FreeText();
			this.alP2 = new NxtControl.GuiFramework.Polygon();
			this.alP2n = new NxtControl.GuiFramework.FreeText();
			this.alTxt = new NxtControl.GuiFramework.FreeText();
			this.tituloNivel = new NxtControl.GuiFramework.FreeText();
			this.porcentagem = new System.HMI.Symbols.Base.Label<float>();
			this.maiLL = new NxtControl.GuiFramework.Rectangle();
			this.maiL = new NxtControl.GuiFramework.Rectangle();
			this.maiN = new NxtControl.GuiFramework.Rectangle();
			this.maiH = new NxtControl.GuiFramework.Rectangle();
			this.maiHH = new NxtControl.GuiFramework.Rectangle();
			this.maiPonteiro = new NxtControl.GuiFramework.Polygon();
			this.escalaMin = new System.HMI.Symbols.Base.Label<float>();
			this.escalaMax = new System.HMI.Symbols.Base.Label<float>();
			this.tituloAlarmes = new NxtControl.GuiFramework.FreeText();
			this.colSetpoint = new NxtControl.GuiFramework.FreeText();
			this.colHab = new NxtControl.GuiFramework.FreeText();
			this.colEstado = new NxtControl.GuiFramework.FreeText();
			this.linhaHH = new NxtControl.GuiFramework.Rectangle();
			this.nomeHH = new NxtControl.GuiFramework.FreeText();
			this.spHH = new System.HMI.Symbols.Base.Label<float>();
			this.habHH = new System.HMI.Symbols.Base.FreeText<bool>();
			this.normalHH = new NxtControl.GuiFramework.FreeText();
			this.estHHP1 = new NxtControl.GuiFramework.Rectangle();
			this.estHHP1n = new NxtControl.GuiFramework.FreeText();
			this.estHHP2 = new NxtControl.GuiFramework.Polygon();
			this.estHHP2n = new NxtControl.GuiFramework.FreeText();
			this.estHHTxt = new NxtControl.GuiFramework.FreeText();
			this.linhaH = new NxtControl.GuiFramework.Rectangle();
			this.nomeH = new NxtControl.GuiFramework.FreeText();
			this.spH = new System.HMI.Symbols.Base.Label<float>();
			this.habH = new System.HMI.Symbols.Base.FreeText<bool>();
			this.normalH = new NxtControl.GuiFramework.FreeText();
			this.estHP1 = new NxtControl.GuiFramework.Rectangle();
			this.estHP1n = new NxtControl.GuiFramework.FreeText();
			this.estHP2 = new NxtControl.GuiFramework.Polygon();
			this.estHP2n = new NxtControl.GuiFramework.FreeText();
			this.estHTxt = new NxtControl.GuiFramework.FreeText();
			this.linhaL = new NxtControl.GuiFramework.Rectangle();
			this.nomeL = new NxtControl.GuiFramework.FreeText();
			this.spL = new System.HMI.Symbols.Base.Label<float>();
			this.habL = new System.HMI.Symbols.Base.FreeText<bool>();
			this.normalL = new NxtControl.GuiFramework.FreeText();
			this.estLP1 = new NxtControl.GuiFramework.Rectangle();
			this.estLP1n = new NxtControl.GuiFramework.FreeText();
			this.estLP2 = new NxtControl.GuiFramework.Polygon();
			this.estLP2n = new NxtControl.GuiFramework.FreeText();
			this.estLTxt = new NxtControl.GuiFramework.FreeText();
			this.linhaLL = new NxtControl.GuiFramework.Rectangle();
			this.nomeLL = new NxtControl.GuiFramework.FreeText();
			this.spLL = new System.HMI.Symbols.Base.Label<float>();
			this.habLL = new System.HMI.Symbols.Base.FreeText<bool>();
			this.normalLL = new NxtControl.GuiFramework.FreeText();
			this.estLLP1 = new NxtControl.GuiFramework.Rectangle();
			this.estLLP1n = new NxtControl.GuiFramework.FreeText();
			this.estLLP2 = new NxtControl.GuiFramework.Polygon();
			this.estLLP2n = new NxtControl.GuiFramework.FreeText();
			this.estLLTxt = new NxtControl.GuiFramework.FreeText();
			this.linhaFalha = new NxtControl.GuiFramework.Rectangle();
			this.nomeFalha = new NxtControl.GuiFramework.FreeText();
			this.normalFalha = new NxtControl.GuiFramework.FreeText();
			this.estFalhaP1 = new NxtControl.GuiFramework.Rectangle();
			this.estFalhaP1n = new NxtControl.GuiFramework.FreeText();
			this.estFalhaP2 = new NxtControl.GuiFramework.Polygon();
			this.estFalhaP2n = new NxtControl.GuiFramework.FreeText();
			this.estFalhaTxt = new NxtControl.GuiFramework.FreeText();
			this.btnReset = new NxtControl.GuiFramework.DrawnButton();
			this.btnParametros = new NxtControl.GuiFramework.DrawnButton();
			this.btnAlarmes = new NxtControl.GuiFramework.DrawnButton();
			this.btnGrafico = new NxtControl.GuiFramework.DrawnButton();
			this.xEstado = new System.HMI.Symbols.Base.Execute<short>();
			this.xFalha = new System.HMI.Symbols.Base.Execute<bool>();
			this.xFalhaAtiva = new System.HMI.Symbols.Base.Execute<bool>();
			this.xValor = new System.HMI.Symbols.Base.Execute<float>();
			this.xUnidade = new System.HMI.Symbols.Base.Execute<string>();
			this.xCasas = new System.HMI.Symbols.Base.Execute<ushort>();
			this.xAlHH = new System.HMI.Symbols.Base.Execute<bool>();
			this.xAlH = new System.HMI.Symbols.Base.Execute<bool>();
			this.xAlL = new System.HMI.Symbols.Base.Execute<bool>();
			this.xAlLL = new System.HMI.Symbols.Base.Execute<bool>();
			this.xEHH = new System.HMI.Symbols.Base.Execute<byte>();
			this.xEH = new System.HMI.Symbols.Base.Execute<byte>();
			this.xEL = new System.HMI.Symbols.Base.Execute<byte>();
			this.xELL = new System.HMI.Symbols.Base.Execute<byte>();
			this.xEFalha = new System.HMI.Symbols.Base.Execute<byte>();
			this.xHabHH = new System.HMI.Symbols.Base.Execute<bool>();
			this.xSpHH = new System.HMI.Symbols.Base.Execute<float>();
			this.xHabH = new System.HMI.Symbols.Base.Execute<bool>();
			this.xSpH = new System.HMI.Symbols.Base.Execute<float>();
			this.xHabL = new System.HMI.Symbols.Base.Execute<bool>();
			this.xSpL = new System.HMI.Symbols.Base.Execute<float>();
			this.xHabLL = new System.HMI.Symbols.Base.Execute<bool>();
			this.xSpLL = new System.HMI.Symbols.Base.Execute<float>();
			this.xRMin = new System.HMI.Symbols.Base.Execute<float>();
			this.xRMax = new System.HMI.Symbols.Base.Execute<float>();
			this.xNivel = new System.HMI.Symbols.Base.Execute<bool>();
			// 
			// cabecalho
			// 
			this.cabecalho.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(380D)), ((float)(142D)));
			this.cabecalho.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(235)), ((byte)(235)), ((byte)(235))));
			this.cabecalho.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.cabecalho.Name = "cabecalho";
			this.cabecalho.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// tituloValor
			// 
			this.tituloValor.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.tituloValor.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.tituloValor.Location = new NxtControl.Drawing.PointF(20D, 8D);
			this.tituloValor.Name = "tituloValor";
			this.tituloValor.Text = "Valor";
			// 
			// valor
			// 
			this.valor.BeginInit();
			this.valor.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.valor.DesignMatrix = new NxtControl.Drawing.Matrix2D(1.3815D, 0D, 0D, 1.5D, -30D, 22D);
			this.valor.Font = new NxtControl.Drawing.Font("Arial", 22F, System.Drawing.FontStyle.Bold);
			this.valor.FontScale = false;
			this.valor.IsOnlyInput = true;
			this.valor.IsPrefixSuffixOutside = false;
			this.valor.LeadingZeros = ((uint)(0u));
			this.valor.Name = "valor";
			this.valor.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			propertyDictionary1.Add("Text", "${Value}");
			propertyDictionary1.Add("TextColor", new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			propertyDictionary1.Add("Brush", new NxtControl.Drawing.Brush(true));
			propertyDictionary1.Add("Pen", new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid));
			this.valor.Ranges.DefaultPropertyValues = propertyDictionary1;
			this.valor.TagName = "STS_VALOR";
			this.valor.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.valor.EndInit();
			// 
			// invalido
			// 
			this.invalido.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.invalido.Font = new NxtControl.Drawing.Font("Arial", 22F, System.Drawing.FontStyle.Bold);
			this.invalido.Location = new NxtControl.Drawing.PointF(24D, 30D);
			this.invalido.Name = "invalido";
			this.invalido.Text = "DESAB.";
			this.invalido.Visible = false;
			// 
			// textoEstado
			// 
			this.textoEstado.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.textoEstado.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.textoEstado.Location = new NxtControl.Drawing.PointF(20D, 70D);
			this.textoEstado.Name = "textoEstado";
			this.textoEstado.Text = "Normal";
			// 
			// alP1
			// 
			this.alP1.Bounds = new NxtControl.Drawing.RectF(((float)(236D)), ((float)(12D)), ((float)(16D)), ((float)(16D)));
			this.alP1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(230)), ((byte)(0)), ((byte)(0))));
			this.alP1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.alP1.Name = "alP1";
			this.alP1.Visible = false;
			// 
			// alP1n
			// 
			this.alP1n.Color = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.alP1n.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.alP1n.Location = new NxtControl.Drawing.PointF(240D, 13D);
			this.alP1n.Name = "alP1n";
			this.alP1n.Text = "1";
			this.alP1n.Visible = false;
			// 
			// alP2
			// 
			this.alP2.Bounds = new NxtControl.Drawing.RectF(((float)(236D)), ((float)(12D)), ((float)(16D)), ((float)(16D)));
			this.alP2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(205)), ((byte)(0))));
			this.alP2.Closed = true;
			this.alP2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.alP2.Name = "alP2";
			this.alP2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(236D, 28D),
			new NxtControl.Drawing.PointF(244D, 12D),
			new NxtControl.Drawing.PointF(252D, 28D)});
			this.alP2.Visible = false;
			// 
			// alP2n
			// 
			this.alP2n.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.alP2n.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
			this.alP2n.Location = new NxtControl.Drawing.PointF(241D, 16D);
			this.alP2n.Name = "alP2n";
			this.alP2n.Text = "2";
			this.alP2n.Visible = false;
			// 
			// alTxt
			// 
			this.alTxt.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.alTxt.Font = new NxtControl.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
			this.alTxt.Location = new NxtControl.Drawing.PointF(256D, 12D);
			this.alTxt.Name = "alTxt";
			this.alTxt.Visible = false;
			// 
			// tituloNivel
			// 
			this.tituloNivel.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.tituloNivel.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.tituloNivel.Location = new NxtControl.Drawing.PointF(236D, 46D);
			this.tituloNivel.Name = "tituloNivel";
			this.tituloNivel.Text = "Nível";
			this.tituloNivel.Visible = false;
			// 
			// porcentagem
			// 
			this.porcentagem.BeginInit();
			this.porcentagem.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.porcentagem.DecimalPlacesCount = ((uint)(1u));
			this.porcentagem.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.4974D, 0D, 0D, 1D, 274D, 44D);
			this.porcentagem.Font = new NxtControl.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
			this.porcentagem.FontScale = false;
			this.porcentagem.IsOnlyInput = true;
			this.porcentagem.IsPrefixSuffixOutside = false;
			this.porcentagem.LeadingZeros = ((uint)(0u));
			this.porcentagem.Name = "porcentagem";
			this.porcentagem.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			propertyDictionary2.Add("Text", "${Value}");
			propertyDictionary2.Add("TextColor", new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			propertyDictionary2.Add("Brush", new NxtControl.Drawing.Brush(true));
			propertyDictionary2.Add("Pen", new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid));
			this.porcentagem.Ranges.DefaultPropertyValues = propertyDictionary2;
			this.porcentagem.Suffix = " %";
			this.porcentagem.TagName = "STS_PORCENTAGEM";
			this.porcentagem.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.porcentagem.Visible = false;
			this.porcentagem.EndInit();
			// 
			// maiLL
			// 
			this.maiLL.Bounds = new NxtControl.Drawing.RectF(((float)(20D)), ((float)(98D)), ((float)(0.0099999997764825821D)), ((float)(14D)));
			this.maiLL.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(165)), ((byte)(165)), ((byte)(165))));
			this.maiLL.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.maiLL.Name = "maiLL";
			this.maiLL.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// maiL
			// 
			this.maiL.Bounds = new NxtControl.Drawing.RectF(((float)(20D)), ((float)(98D)), ((float)(0.0099999997764825821D)), ((float)(14D)));
			this.maiL.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(200)), ((byte)(200)), ((byte)(200))));
			this.maiL.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.maiL.Name = "maiL";
			this.maiL.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// maiN
			// 
			this.maiN.Bounds = new NxtControl.Drawing.RectF(((float)(20D)), ((float)(98D)), ((float)(340D)), ((float)(14D)));
			this.maiN.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(245)), ((byte)(245)), ((byte)(245))));
			this.maiN.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.maiN.Name = "maiN";
			this.maiN.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// maiH
			// 
			this.maiH.Bounds = new NxtControl.Drawing.RectF(((float)(20D)), ((float)(98D)), ((float)(0.0099999997764825821D)), ((float)(14D)));
			this.maiH.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(200)), ((byte)(200)), ((byte)(200))));
			this.maiH.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.maiH.Name = "maiH";
			this.maiH.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// maiHH
			// 
			this.maiHH.Bounds = new NxtControl.Drawing.RectF(((float)(20D)), ((float)(98D)), ((float)(0.0099999997764825821D)), ((float)(14D)));
			this.maiHH.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(165)), ((byte)(165)), ((byte)(165))));
			this.maiHH.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.maiHH.Name = "maiHH";
			this.maiHH.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// maiPonteiro
			// 
			this.maiPonteiro.Bounds = new NxtControl.Drawing.RectF(((float)(185D)), ((float)(112D)), ((float)(10D)), ((float)(7D)));
			this.maiPonteiro.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			this.maiPonteiro.Closed = true;
			this.maiPonteiro.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.maiPonteiro.Name = "maiPonteiro";
			this.maiPonteiro.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			this.maiPonteiro.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(185D, 119D),
			new NxtControl.Drawing.PointF(190D, 112D),
			new NxtControl.Drawing.PointF(195D, 119D)});
			this.maiPonteiro.Visible = false;
			// 
			// escalaMin
			// 
			this.escalaMin.BeginInit();
			this.escalaMin.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.escalaMin.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.5D, 0D, 0D, 0.8D, 16D, 120D);
			this.escalaMin.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.escalaMin.FontScale = false;
			this.escalaMin.IsPrefixSuffixOutside = false;
			this.escalaMin.LeadingZeros = ((uint)(0u));
			this.escalaMin.Name = "escalaMin";
			this.escalaMin.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			propertyDictionary3.Add("Text", "${Value}");
			propertyDictionary3.Add("TextColor", new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64))));
			propertyDictionary3.Add("Brush", new NxtControl.Drawing.Brush(true));
			propertyDictionary3.Add("Pen", new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid));
			this.escalaMin.Ranges.DefaultPropertyValues = propertyDictionary3;
			this.escalaMin.TagName = "STP_RANGE_MINIMO";
			this.escalaMin.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.escalaMin.EndInit();
			// 
			// escalaMax
			// 
			this.escalaMax.BeginInit();
			this.escalaMax.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.escalaMax.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.5D, 0D, 0D, 0.8D, 284D, 120D);
			this.escalaMax.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.escalaMax.FontScale = false;
			this.escalaMax.IsPrefixSuffixOutside = false;
			this.escalaMax.LeadingZeros = ((uint)(0u));
			this.escalaMax.Name = "escalaMax";
			this.escalaMax.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			propertyDictionary4.Add("Text", "${Value}");
			propertyDictionary4.Add("TextColor", new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64))));
			propertyDictionary4.Add("Brush", new NxtControl.Drawing.Brush(true));
			propertyDictionary4.Add("Pen", new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid));
			this.escalaMax.Ranges.DefaultPropertyValues = propertyDictionary4;
			this.escalaMax.TagName = "STP_RANGE_MAXIMO";
			this.escalaMax.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.escalaMax.EndInit();
			// 
			// tituloAlarmes
			// 
			this.tituloAlarmes.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.tituloAlarmes.Font = new NxtControl.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
			this.tituloAlarmes.Location = new NxtControl.Drawing.PointF(20D, 154D);
			this.tituloAlarmes.Name = "tituloAlarmes";
			this.tituloAlarmes.Text = "Alarmes";
			// 
			// colSetpoint
			// 
			this.colSetpoint.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.colSetpoint.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.colSetpoint.Location = new NxtControl.Drawing.PointF(110D, 156D);
			this.colSetpoint.Name = "colSetpoint";
			this.colSetpoint.Text = "Setpoint";
			// 
			// colHab
			// 
			this.colHab.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.colHab.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.colHab.Location = new NxtControl.Drawing.PointF(214D, 156D);
			this.colHab.Name = "colHab";
			this.colHab.Text = "Monitorado";
			// 
			// colEstado
			// 
			this.colEstado.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.colEstado.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.colEstado.Location = new NxtControl.Drawing.PointF(300D, 156D);
			this.colEstado.Name = "colEstado";
			this.colEstado.Text = "Estado";
			// 
			// linhaHH
			// 
			this.linhaHH.Bounds = new NxtControl.Drawing.RectF(((float)(12D)), ((float)(176D)), ((float)(356D)), ((float)(28D)));
			this.linhaHH.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(235)), ((byte)(235)), ((byte)(235))));
			this.linhaHH.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.linhaHH.Name = "linhaHH";
			this.linhaHH.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// nomeHH
			// 
			this.nomeHH.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.nomeHH.Font = new NxtControl.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
			this.nomeHH.Location = new NxtControl.Drawing.PointF(24D, 181D);
			this.nomeHH.Name = "nomeHH";
			this.nomeHH.Text = "HH";
			// 
			// spHH
			// 
			this.spHH.BeginInit();
			this.spHH.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.spHH.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.651D, 0D, 0D, 1D, 106D, 179D);
			this.spHH.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.spHH.FontScale = false;
			this.spHH.IsPrefixSuffixOutside = false;
			this.spHH.LeadingZeros = ((uint)(0u));
			this.spHH.Name = "spHH";
			this.spHH.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			propertyDictionary5.Add("Text", "${Value}");
			propertyDictionary5.Add("TextColor", new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			propertyDictionary5.Add("Brush", new NxtControl.Drawing.Brush(true));
			propertyDictionary5.Add("Pen", new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid));
			this.spHH.Ranges.DefaultPropertyValues = propertyDictionary5;
			this.spHH.TagName = "STP_ALARME_HH";
			this.spHH.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.spHH.EndInit();
			// 
			// habHH
			// 
			this.habHH.BeginInit();
			this.habHH.DecimalPlacesCount = ((uint)(2u));
			this.habHH.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 222D, 182D);
			this.habHH.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.habHH.Name = "habHH";
			propertyDictionary7.Add("Text", "não");
			propertyDictionary7.Add("TextColor", new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110))));
			propertyDictionary8.Add("Text", "sim");
			propertyDictionary8.Add("TextColor", new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			this.habHH.Ranges.Clear();
			this.habHH.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(false, propertyDictionary7));
			this.habHH.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(true, propertyDictionary8));
			propertyDictionary6.Add("Text", "-");
			propertyDictionary6.Add("TextColor", new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110))));
			this.habHH.Ranges.DefaultPropertyValues = propertyDictionary6;
			this.habHH.TagName = "CMD_HABILITA_ALARME_HH";
			this.habHH.TextAngle = 0F;
			this.habHH.EndInit();
			// 
			// normalHH
			// 
			this.normalHH.Color = new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110)));
			this.normalHH.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.normalHH.Location = new NxtControl.Drawing.PointF(304D, 182D);
			this.normalHH.Name = "normalHH";
			this.normalHH.Text = "—";
			// 
			// estHHP1
			// 
			this.estHHP1.Bounds = new NxtControl.Drawing.RectF(((float)(300D)), ((float)(181D)), ((float)(16D)), ((float)(16D)));
			this.estHHP1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(230)), ((byte)(0)), ((byte)(0))));
			this.estHHP1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.estHHP1.Name = "estHHP1";
			this.estHHP1.Visible = false;
			// 
			// estHHP1n
			// 
			this.estHHP1n.Color = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.estHHP1n.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.estHHP1n.Location = new NxtControl.Drawing.PointF(304D, 182D);
			this.estHHP1n.Name = "estHHP1n";
			this.estHHP1n.Text = "1";
			this.estHHP1n.Visible = false;
			// 
			// estHHP2
			// 
			this.estHHP2.Bounds = new NxtControl.Drawing.RectF(((float)(300D)), ((float)(181D)), ((float)(16D)), ((float)(16D)));
			this.estHHP2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(205)), ((byte)(0))));
			this.estHHP2.Closed = true;
			this.estHHP2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.estHHP2.Name = "estHHP2";
			this.estHHP2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(300D, 197D),
			new NxtControl.Drawing.PointF(308D, 181D),
			new NxtControl.Drawing.PointF(316D, 197D)});
			this.estHHP2.Visible = false;
			// 
			// estHHP2n
			// 
			this.estHHP2n.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.estHHP2n.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
			this.estHHP2n.Location = new NxtControl.Drawing.PointF(305D, 185D);
			this.estHHP2n.Name = "estHHP2n";
			this.estHHP2n.Text = "2";
			this.estHHP2n.Visible = false;
			// 
			// estHHTxt
			// 
			this.estHHTxt.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.estHHTxt.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.estHHTxt.Location = new NxtControl.Drawing.PointF(320D, 181D);
			this.estHHTxt.Name = "estHHTxt";
			this.estHHTxt.Visible = false;
			// 
			// linhaH
			// 
			this.linhaH.Bounds = new NxtControl.Drawing.RectF(((float)(12D)), ((float)(208D)), ((float)(356D)), ((float)(28D)));
			this.linhaH.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(235)), ((byte)(235)), ((byte)(235))));
			this.linhaH.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.linhaH.Name = "linhaH";
			this.linhaH.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// nomeH
			// 
			this.nomeH.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.nomeH.Font = new NxtControl.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
			this.nomeH.Location = new NxtControl.Drawing.PointF(24D, 213D);
			this.nomeH.Name = "nomeH";
			this.nomeH.Text = "H";
			// 
			// spH
			// 
			this.spH.BeginInit();
			this.spH.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.spH.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.651D, 0D, 0D, 1D, 106D, 211D);
			this.spH.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.spH.FontScale = false;
			this.spH.IsPrefixSuffixOutside = false;
			this.spH.LeadingZeros = ((uint)(0u));
			this.spH.Name = "spH";
			this.spH.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			propertyDictionary9.Add("Text", "${Value}");
			propertyDictionary9.Add("TextColor", new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			propertyDictionary9.Add("Brush", new NxtControl.Drawing.Brush(true));
			propertyDictionary9.Add("Pen", new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid));
			this.spH.Ranges.DefaultPropertyValues = propertyDictionary9;
			this.spH.TagName = "STP_ALARME_H";
			this.spH.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.spH.EndInit();
			// 
			// habH
			// 
			this.habH.BeginInit();
			this.habH.DecimalPlacesCount = ((uint)(2u));
			this.habH.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 222D, 214D);
			this.habH.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.habH.Name = "habH";
			propertyDictionary11.Add("Text", "não");
			propertyDictionary11.Add("TextColor", new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110))));
			propertyDictionary12.Add("Text", "sim");
			propertyDictionary12.Add("TextColor", new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			this.habH.Ranges.Clear();
			this.habH.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(false, propertyDictionary11));
			this.habH.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(true, propertyDictionary12));
			propertyDictionary10.Add("Text", "-");
			propertyDictionary10.Add("TextColor", new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110))));
			this.habH.Ranges.DefaultPropertyValues = propertyDictionary10;
			this.habH.TagName = "CMD_HABILITA_ALARME_H";
			this.habH.TextAngle = 0F;
			this.habH.EndInit();
			// 
			// normalH
			// 
			this.normalH.Color = new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110)));
			this.normalH.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.normalH.Location = new NxtControl.Drawing.PointF(304D, 214D);
			this.normalH.Name = "normalH";
			this.normalH.Text = "—";
			// 
			// estHP1
			// 
			this.estHP1.Bounds = new NxtControl.Drawing.RectF(((float)(300D)), ((float)(213D)), ((float)(16D)), ((float)(16D)));
			this.estHP1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(230)), ((byte)(0)), ((byte)(0))));
			this.estHP1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.estHP1.Name = "estHP1";
			this.estHP1.Visible = false;
			// 
			// estHP1n
			// 
			this.estHP1n.Color = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.estHP1n.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.estHP1n.Location = new NxtControl.Drawing.PointF(304D, 214D);
			this.estHP1n.Name = "estHP1n";
			this.estHP1n.Text = "1";
			this.estHP1n.Visible = false;
			// 
			// estHP2
			// 
			this.estHP2.Bounds = new NxtControl.Drawing.RectF(((float)(300D)), ((float)(213D)), ((float)(16D)), ((float)(16D)));
			this.estHP2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(205)), ((byte)(0))));
			this.estHP2.Closed = true;
			this.estHP2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.estHP2.Name = "estHP2";
			this.estHP2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(300D, 229D),
			new NxtControl.Drawing.PointF(308D, 213D),
			new NxtControl.Drawing.PointF(316D, 229D)});
			this.estHP2.Visible = false;
			// 
			// estHP2n
			// 
			this.estHP2n.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.estHP2n.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
			this.estHP2n.Location = new NxtControl.Drawing.PointF(305D, 217D);
			this.estHP2n.Name = "estHP2n";
			this.estHP2n.Text = "2";
			this.estHP2n.Visible = false;
			// 
			// estHTxt
			// 
			this.estHTxt.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.estHTxt.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.estHTxt.Location = new NxtControl.Drawing.PointF(320D, 213D);
			this.estHTxt.Name = "estHTxt";
			this.estHTxt.Visible = false;
			// 
			// linhaL
			// 
			this.linhaL.Bounds = new NxtControl.Drawing.RectF(((float)(12D)), ((float)(240D)), ((float)(356D)), ((float)(28D)));
			this.linhaL.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(235)), ((byte)(235)), ((byte)(235))));
			this.linhaL.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.linhaL.Name = "linhaL";
			this.linhaL.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// nomeL
			// 
			this.nomeL.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.nomeL.Font = new NxtControl.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
			this.nomeL.Location = new NxtControl.Drawing.PointF(24D, 245D);
			this.nomeL.Name = "nomeL";
			this.nomeL.Text = "L";
			// 
			// spL
			// 
			this.spL.BeginInit();
			this.spL.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.spL.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.651D, 0D, 0D, 1D, 106D, 243D);
			this.spL.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.spL.FontScale = false;
			this.spL.IsPrefixSuffixOutside = false;
			this.spL.LeadingZeros = ((uint)(0u));
			this.spL.Name = "spL";
			this.spL.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			propertyDictionary13.Add("Text", "${Value}");
			propertyDictionary13.Add("TextColor", new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			propertyDictionary13.Add("Brush", new NxtControl.Drawing.Brush(true));
			propertyDictionary13.Add("Pen", new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid));
			this.spL.Ranges.DefaultPropertyValues = propertyDictionary13;
			this.spL.TagName = "STP_ALARME_L";
			this.spL.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.spL.EndInit();
			// 
			// habL
			// 
			this.habL.BeginInit();
			this.habL.DecimalPlacesCount = ((uint)(2u));
			this.habL.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 222D, 246D);
			this.habL.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.habL.Name = "habL";
			propertyDictionary15.Add("Text", "não");
			propertyDictionary15.Add("TextColor", new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110))));
			propertyDictionary16.Add("Text", "sim");
			propertyDictionary16.Add("TextColor", new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			this.habL.Ranges.Clear();
			this.habL.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(false, propertyDictionary15));
			this.habL.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(true, propertyDictionary16));
			propertyDictionary14.Add("Text", "-");
			propertyDictionary14.Add("TextColor", new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110))));
			this.habL.Ranges.DefaultPropertyValues = propertyDictionary14;
			this.habL.TagName = "CMD_HABILITA_ALARME_L";
			this.habL.TextAngle = 0F;
			this.habL.EndInit();
			// 
			// normalL
			// 
			this.normalL.Color = new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110)));
			this.normalL.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.normalL.Location = new NxtControl.Drawing.PointF(304D, 246D);
			this.normalL.Name = "normalL";
			this.normalL.Text = "—";
			// 
			// estLP1
			// 
			this.estLP1.Bounds = new NxtControl.Drawing.RectF(((float)(300D)), ((float)(245D)), ((float)(16D)), ((float)(16D)));
			this.estLP1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(230)), ((byte)(0)), ((byte)(0))));
			this.estLP1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.estLP1.Name = "estLP1";
			this.estLP1.Visible = false;
			// 
			// estLP1n
			// 
			this.estLP1n.Color = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.estLP1n.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.estLP1n.Location = new NxtControl.Drawing.PointF(304D, 246D);
			this.estLP1n.Name = "estLP1n";
			this.estLP1n.Text = "1";
			this.estLP1n.Visible = false;
			// 
			// estLP2
			// 
			this.estLP2.Bounds = new NxtControl.Drawing.RectF(((float)(300D)), ((float)(245D)), ((float)(16D)), ((float)(16D)));
			this.estLP2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(205)), ((byte)(0))));
			this.estLP2.Closed = true;
			this.estLP2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.estLP2.Name = "estLP2";
			this.estLP2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(300D, 261D),
			new NxtControl.Drawing.PointF(308D, 245D),
			new NxtControl.Drawing.PointF(316D, 261D)});
			this.estLP2.Visible = false;
			// 
			// estLP2n
			// 
			this.estLP2n.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.estLP2n.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
			this.estLP2n.Location = new NxtControl.Drawing.PointF(305D, 249D);
			this.estLP2n.Name = "estLP2n";
			this.estLP2n.Text = "2";
			this.estLP2n.Visible = false;
			// 
			// estLTxt
			// 
			this.estLTxt.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.estLTxt.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.estLTxt.Location = new NxtControl.Drawing.PointF(320D, 245D);
			this.estLTxt.Name = "estLTxt";
			this.estLTxt.Visible = false;
			// 
			// linhaLL
			// 
			this.linhaLL.Bounds = new NxtControl.Drawing.RectF(((float)(12D)), ((float)(272D)), ((float)(356D)), ((float)(28D)));
			this.linhaLL.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(235)), ((byte)(235)), ((byte)(235))));
			this.linhaLL.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.linhaLL.Name = "linhaLL";
			this.linhaLL.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// nomeLL
			// 
			this.nomeLL.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.nomeLL.Font = new NxtControl.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
			this.nomeLL.Location = new NxtControl.Drawing.PointF(24D, 277D);
			this.nomeLL.Name = "nomeLL";
			this.nomeLL.Text = "LL";
			// 
			// spLL
			// 
			this.spLL.BeginInit();
			this.spLL.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.spLL.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.651D, 0D, 0D, 1D, 106D, 275D);
			this.spLL.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.spLL.FontScale = false;
			this.spLL.IsPrefixSuffixOutside = false;
			this.spLL.LeadingZeros = ((uint)(0u));
			this.spLL.Name = "spLL";
			this.spLL.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			propertyDictionary17.Add("Text", "${Value}");
			propertyDictionary17.Add("TextColor", new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			propertyDictionary17.Add("Brush", new NxtControl.Drawing.Brush(true));
			propertyDictionary17.Add("Pen", new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid));
			this.spLL.Ranges.DefaultPropertyValues = propertyDictionary17;
			this.spLL.TagName = "STP_ALARME_LL";
			this.spLL.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.spLL.EndInit();
			// 
			// habLL
			// 
			this.habLL.BeginInit();
			this.habLL.DecimalPlacesCount = ((uint)(2u));
			this.habLL.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 222D, 278D);
			this.habLL.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.habLL.Name = "habLL";
			propertyDictionary19.Add("Text", "não");
			propertyDictionary19.Add("TextColor", new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110))));
			propertyDictionary20.Add("Text", "sim");
			propertyDictionary20.Add("TextColor", new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			this.habLL.Ranges.Clear();
			this.habLL.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(false, propertyDictionary19));
			this.habLL.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(true, propertyDictionary20));
			propertyDictionary18.Add("Text", "-");
			propertyDictionary18.Add("TextColor", new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110))));
			this.habLL.Ranges.DefaultPropertyValues = propertyDictionary18;
			this.habLL.TagName = "CMD_HABILITA_ALARME_LL";
			this.habLL.TextAngle = 0F;
			this.habLL.EndInit();
			// 
			// normalLL
			// 
			this.normalLL.Color = new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110)));
			this.normalLL.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.normalLL.Location = new NxtControl.Drawing.PointF(304D, 278D);
			this.normalLL.Name = "normalLL";
			this.normalLL.Text = "—";
			// 
			// estLLP1
			// 
			this.estLLP1.Bounds = new NxtControl.Drawing.RectF(((float)(300D)), ((float)(277D)), ((float)(16D)), ((float)(16D)));
			this.estLLP1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(230)), ((byte)(0)), ((byte)(0))));
			this.estLLP1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.estLLP1.Name = "estLLP1";
			this.estLLP1.Visible = false;
			// 
			// estLLP1n
			// 
			this.estLLP1n.Color = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.estLLP1n.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.estLLP1n.Location = new NxtControl.Drawing.PointF(304D, 278D);
			this.estLLP1n.Name = "estLLP1n";
			this.estLLP1n.Text = "1";
			this.estLLP1n.Visible = false;
			// 
			// estLLP2
			// 
			this.estLLP2.Bounds = new NxtControl.Drawing.RectF(((float)(300D)), ((float)(277D)), ((float)(16D)), ((float)(16D)));
			this.estLLP2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(205)), ((byte)(0))));
			this.estLLP2.Closed = true;
			this.estLLP2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.estLLP2.Name = "estLLP2";
			this.estLLP2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(300D, 293D),
			new NxtControl.Drawing.PointF(308D, 277D),
			new NxtControl.Drawing.PointF(316D, 293D)});
			this.estLLP2.Visible = false;
			// 
			// estLLP2n
			// 
			this.estLLP2n.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.estLLP2n.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
			this.estLLP2n.Location = new NxtControl.Drawing.PointF(305D, 281D);
			this.estLLP2n.Name = "estLLP2n";
			this.estLLP2n.Text = "2";
			this.estLLP2n.Visible = false;
			// 
			// estLLTxt
			// 
			this.estLLTxt.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.estLLTxt.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.estLLTxt.Location = new NxtControl.Drawing.PointF(320D, 277D);
			this.estLLTxt.Name = "estLLTxt";
			this.estLLTxt.Visible = false;
			// 
			// linhaFalha
			// 
			this.linhaFalha.Bounds = new NxtControl.Drawing.RectF(((float)(12D)), ((float)(304D)), ((float)(356D)), ((float)(28D)));
			this.linhaFalha.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(235)), ((byte)(235)), ((byte)(235))));
			this.linhaFalha.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.linhaFalha.Name = "linhaFalha";
			this.linhaFalha.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// nomeFalha
			// 
			this.nomeFalha.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.nomeFalha.Font = new NxtControl.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
			this.nomeFalha.Location = new NxtControl.Drawing.PointF(24D, 309D);
			this.nomeFalha.Name = "nomeFalha";
			this.nomeFalha.Text = "Falha do sensor";
			// 
			// normalFalha
			// 
			this.normalFalha.Color = new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110)));
			this.normalFalha.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.normalFalha.Location = new NxtControl.Drawing.PointF(304D, 310D);
			this.normalFalha.Name = "normalFalha";
			this.normalFalha.Text = "—";
			// 
			// estFalhaP1
			// 
			this.estFalhaP1.Bounds = new NxtControl.Drawing.RectF(((float)(300D)), ((float)(309D)), ((float)(16D)), ((float)(16D)));
			this.estFalhaP1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(230)), ((byte)(0)), ((byte)(0))));
			this.estFalhaP1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.estFalhaP1.Name = "estFalhaP1";
			this.estFalhaP1.Visible = false;
			// 
			// estFalhaP1n
			// 
			this.estFalhaP1n.Color = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.estFalhaP1n.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.estFalhaP1n.Location = new NxtControl.Drawing.PointF(304D, 310D);
			this.estFalhaP1n.Name = "estFalhaP1n";
			this.estFalhaP1n.Text = "1";
			this.estFalhaP1n.Visible = false;
			// 
			// estFalhaP2
			// 
			this.estFalhaP2.Bounds = new NxtControl.Drawing.RectF(((float)(300D)), ((float)(309D)), ((float)(16D)), ((float)(16D)));
			this.estFalhaP2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(205)), ((byte)(0))));
			this.estFalhaP2.Closed = true;
			this.estFalhaP2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.estFalhaP2.Name = "estFalhaP2";
			this.estFalhaP2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(300D, 325D),
			new NxtControl.Drawing.PointF(308D, 309D),
			new NxtControl.Drawing.PointF(316D, 325D)});
			this.estFalhaP2.Visible = false;
			// 
			// estFalhaP2n
			// 
			this.estFalhaP2n.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.estFalhaP2n.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
			this.estFalhaP2n.Location = new NxtControl.Drawing.PointF(305D, 313D);
			this.estFalhaP2n.Name = "estFalhaP2n";
			this.estFalhaP2n.Text = "2";
			this.estFalhaP2n.Visible = false;
			// 
			// estFalhaTxt
			// 
			this.estFalhaTxt.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.estFalhaTxt.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.estFalhaTxt.Location = new NxtControl.Drawing.PointF(320D, 309D);
			this.estFalhaTxt.Name = "estFalhaTxt";
			this.estFalhaTxt.Visible = false;
			// 
			// btnReset
			// 
			this.btnReset.Bounds = new NxtControl.Drawing.RectF(((float)(20D)), ((float)(350D)), ((float)(100D)), ((float)(32D)));
			this.btnReset.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208))));
			this.btnReset.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.btnReset.InnerBorderColor = new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208)));
			this.btnReset.Name = "btnReset";
			this.btnReset.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.btnReset.Radius = 2D;
			this.btnReset.Text = "Reconhecer / Reset";
			this.btnReset.Use3DEffect = false;
			this.btnReset.Click += new System.EventHandler(this.BtnResetClick);
			// 
			// btnParametros
			// 
			this.btnParametros.Bounds = new NxtControl.Drawing.RectF(((float)(130D)), ((float)(350D)), ((float)(70D)), ((float)(32D)));
			this.btnParametros.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208))));
			this.btnParametros.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.btnParametros.InnerBorderColor = new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208)));
			this.btnParametros.Name = "btnParametros";
			this.btnParametros.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("fpParameter", NxtControl.GuiFramework.MouseButtonType.Click));
			this.btnParametros.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.btnParametros.Radius = 2D;
			this.btnParametros.Text = "Ajustes";
			this.btnParametros.Use3DEffect = false;
			// 
			// btnAlarmes
			// 
			this.btnAlarmes.Bounds = new NxtControl.Drawing.RectF(((float)(210D)), ((float)(350D)), ((float)(70D)), ((float)(32D)));
			this.btnAlarmes.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208))));
			this.btnAlarmes.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.btnAlarmes.InnerBorderColor = new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208)));
			this.btnAlarmes.Name = "btnAlarmes";
			this.btnAlarmes.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("fpAlarm", NxtControl.GuiFramework.MouseButtonType.Click));
			this.btnAlarmes.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.btnAlarmes.Radius = 2D;
			this.btnAlarmes.Text = "Alarmes";
			this.btnAlarmes.Use3DEffect = false;
			// 
			// btnGrafico
			// 
			this.btnGrafico.Bounds = new NxtControl.Drawing.RectF(((float)(290D)), ((float)(350D)), ((float)(70D)), ((float)(32D)));
			this.btnGrafico.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208))));
			this.btnGrafico.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.btnGrafico.InnerBorderColor = new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208)));
			this.btnGrafico.Name = "btnGrafico";
			this.btnGrafico.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("fpTrend", NxtControl.GuiFramework.MouseButtonType.Click));
			this.btnGrafico.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.btnGrafico.Radius = 2D;
			this.btnGrafico.Text = "Gráfico";
			this.btnGrafico.Use3DEffect = false;
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
			this.xEstado.Value = ((short)(0));
			this.xEstado.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.EstadoValueChanged);
			this.xEstado.EndInit();
			// 
			// xFalha
			// 
			this.xFalha.BeginInit();
			this.xFalha.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xFalha.IsOnlyInput = true;
			this.xFalha.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xFalha.Name = "xFalha";
			this.xFalha.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xFalha.TagName = "STS_FALHA_SENSOR";
			this.xFalha.Value = false;
			this.xFalha.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.FalhaValueChanged);
			this.xFalha.EndInit();
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
			this.xFalhaAtiva.Value = false;
			this.xFalhaAtiva.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.FalhaAtivaValueChanged);
			this.xFalhaAtiva.EndInit();
			// 
			// xValor
			// 
			this.xValor.BeginInit();
			this.xValor.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xValor.IsOnlyInput = true;
			this.xValor.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xValor.Name = "xValor";
			this.xValor.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xValor.TagName = "STS_VALOR";
			this.xValor.Value = 0F;
			this.xValor.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.ValorValueChanged);
			this.xValor.EndInit();
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
			this.xUnidade.Value = null;
			this.xUnidade.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.UnidadeValueChanged);
			this.xUnidade.EndInit();
			// 
			// xCasas
			// 
			this.xCasas.BeginInit();
			this.xCasas.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xCasas.IsOnlyInput = true;
			this.xCasas.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xCasas.Name = "xCasas";
			this.xCasas.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xCasas.TagName = "CFG_CASAS_DECIMAIS";
			this.xCasas.Value = ((ushort)(0));
			this.xCasas.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.CasasValueChanged);
			this.xCasas.EndInit();
			// 
			// xAlHH
			// 
			this.xAlHH.BeginInit();
			this.xAlHH.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xAlHH.IsOnlyInput = true;
			this.xAlHH.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xAlHH.Name = "xAlHH";
			this.xAlHH.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xAlHH.TagName = "STS_ALARME_HH";
			this.xAlHH.Value = false;
			this.xAlHH.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.AlHHValueChanged);
			this.xAlHH.EndInit();
			// 
			// xAlH
			// 
			this.xAlH.BeginInit();
			this.xAlH.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xAlH.IsOnlyInput = true;
			this.xAlH.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xAlH.Name = "xAlH";
			this.xAlH.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xAlH.TagName = "STS_ALARME_H";
			this.xAlH.Value = false;
			this.xAlH.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.AlHValueChanged);
			this.xAlH.EndInit();
			// 
			// xAlL
			// 
			this.xAlL.BeginInit();
			this.xAlL.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xAlL.IsOnlyInput = true;
			this.xAlL.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xAlL.Name = "xAlL";
			this.xAlL.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xAlL.TagName = "STS_ALARME_L";
			this.xAlL.Value = false;
			this.xAlL.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.AlLValueChanged);
			this.xAlL.EndInit();
			// 
			// xAlLL
			// 
			this.xAlLL.BeginInit();
			this.xAlLL.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xAlLL.IsOnlyInput = true;
			this.xAlLL.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xAlLL.Name = "xAlLL";
			this.xAlLL.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xAlLL.TagName = "STS_ALARME_LL";
			this.xAlLL.Value = false;
			this.xAlLL.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.AlLLValueChanged);
			this.xAlLL.EndInit();
			// 
			// xEHH
			// 
			this.xEHH.BeginInit();
			this.xEHH.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xEHH.IsOnlyInput = true;
			this.xEHH.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xEHH.Name = "xEHH";
			this.xEHH.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xEHH.TagName = "STS_ALM_HH_EST";
			this.xEHH.Value = ((byte)(0));
			this.xEHH.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.EHHValueChanged);
			this.xEHH.EndInit();
			// 
			// xEH
			// 
			this.xEH.BeginInit();
			this.xEH.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xEH.IsOnlyInput = true;
			this.xEH.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xEH.Name = "xEH";
			this.xEH.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xEH.TagName = "STS_ALM_H_EST";
			this.xEH.Value = ((byte)(0));
			this.xEH.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.EHValueChanged);
			this.xEH.EndInit();
			// 
			// xEL
			// 
			this.xEL.BeginInit();
			this.xEL.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xEL.IsOnlyInput = true;
			this.xEL.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xEL.Name = "xEL";
			this.xEL.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xEL.TagName = "STS_ALM_L_EST";
			this.xEL.Value = ((byte)(0));
			this.xEL.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.ELValueChanged);
			this.xEL.EndInit();
			// 
			// xELL
			// 
			this.xELL.BeginInit();
			this.xELL.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xELL.IsOnlyInput = true;
			this.xELL.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xELL.Name = "xELL";
			this.xELL.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xELL.TagName = "STS_ALM_LL_EST";
			this.xELL.Value = ((byte)(0));
			this.xELL.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.ELLValueChanged);
			this.xELL.EndInit();
			// 
			// xEFalha
			// 
			this.xEFalha.BeginInit();
			this.xEFalha.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xEFalha.IsOnlyInput = true;
			this.xEFalha.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xEFalha.Name = "xEFalha";
			this.xEFalha.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xEFalha.TagName = "STS_ALM_FALHA_EST";
			this.xEFalha.Value = ((byte)(0));
			this.xEFalha.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.EFalhaValueChanged);
			this.xEFalha.EndInit();
			// 
			// xHabHH
			// 
			this.xHabHH.BeginInit();
			this.xHabHH.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xHabHH.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xHabHH.Name = "xHabHH";
			this.xHabHH.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xHabHH.TagName = "CMD_HABILITA_ALARME_HH";
			this.xHabHH.Value = false;
			this.xHabHH.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.HabHHValueChanged);
			this.xHabHH.EndInit();
			// 
			// xSpHH
			// 
			this.xSpHH.BeginInit();
			this.xSpHH.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xSpHH.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xSpHH.Name = "xSpHH";
			this.xSpHH.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xSpHH.TagName = "STP_ALARME_HH";
			this.xSpHH.Value = 0F;
			this.xSpHH.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.SpHHValueChanged);
			this.xSpHH.EndInit();
			// 
			// xHabH
			// 
			this.xHabH.BeginInit();
			this.xHabH.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xHabH.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xHabH.Name = "xHabH";
			this.xHabH.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xHabH.TagName = "CMD_HABILITA_ALARME_H";
			this.xHabH.Value = false;
			this.xHabH.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.HabHValueChanged);
			this.xHabH.EndInit();
			// 
			// xSpH
			// 
			this.xSpH.BeginInit();
			this.xSpH.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xSpH.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xSpH.Name = "xSpH";
			this.xSpH.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xSpH.TagName = "STP_ALARME_H";
			this.xSpH.Value = 0F;
			this.xSpH.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.SpHValueChanged);
			this.xSpH.EndInit();
			// 
			// xHabL
			// 
			this.xHabL.BeginInit();
			this.xHabL.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xHabL.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xHabL.Name = "xHabL";
			this.xHabL.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xHabL.TagName = "CMD_HABILITA_ALARME_L";
			this.xHabL.Value = false;
			this.xHabL.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.HabLValueChanged);
			this.xHabL.EndInit();
			// 
			// xSpL
			// 
			this.xSpL.BeginInit();
			this.xSpL.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xSpL.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xSpL.Name = "xSpL";
			this.xSpL.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xSpL.TagName = "STP_ALARME_L";
			this.xSpL.Value = 0F;
			this.xSpL.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.SpLValueChanged);
			this.xSpL.EndInit();
			// 
			// xHabLL
			// 
			this.xHabLL.BeginInit();
			this.xHabLL.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xHabLL.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xHabLL.Name = "xHabLL";
			this.xHabLL.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xHabLL.TagName = "CMD_HABILITA_ALARME_LL";
			this.xHabLL.Value = false;
			this.xHabLL.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.HabLLValueChanged);
			this.xHabLL.EndInit();
			// 
			// xSpLL
			// 
			this.xSpLL.BeginInit();
			this.xSpLL.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xSpLL.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xSpLL.Name = "xSpLL";
			this.xSpLL.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xSpLL.TagName = "STP_ALARME_LL";
			this.xSpLL.Value = 0F;
			this.xSpLL.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.SpLLValueChanged);
			this.xSpLL.EndInit();
			// 
			// xRMin
			// 
			this.xRMin.BeginInit();
			this.xRMin.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xRMin.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xRMin.Name = "xRMin";
			this.xRMin.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xRMin.TagName = "STP_RANGE_MINIMO";
			this.xRMin.Value = 0F;
			this.xRMin.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.RMinValueChanged);
			this.xRMin.EndInit();
			// 
			// xRMax
			// 
			this.xRMax.BeginInit();
			this.xRMax.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xRMax.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xRMax.Name = "xRMax";
			this.xRMax.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xRMax.TagName = "STP_RANGE_MAXIMO";
			this.xRMax.Value = 0F;
			this.xRMax.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.RMaxValueChanged);
			this.xRMax.EndInit();
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
			this.xNivel.Value = false;
			this.xNivel.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.NivelValueChanged);
			this.xNivel.EndInit();
			// 
			// fpDefault
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(380D)), ((float)(398D)));
			this.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(224)), ((byte)(224)), ((byte)(224))));
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.cabecalho,
			this.tituloValor,
			this.valor,
			this.invalido,
			this.textoEstado,
			this.alP1,
			this.alP1n,
			this.alP2,
			this.alP2n,
			this.alTxt,
			this.tituloNivel,
			this.porcentagem,
			this.maiLL,
			this.maiL,
			this.maiN,
			this.maiH,
			this.maiHH,
			this.maiPonteiro,
			this.escalaMin,
			this.escalaMax,
			this.tituloAlarmes,
			this.colSetpoint,
			this.colHab,
			this.colEstado,
			this.linhaHH,
			this.nomeHH,
			this.spHH,
			this.habHH,
			this.normalHH,
			this.estHHP1,
			this.estHHP1n,
			this.estHHP2,
			this.estHHP2n,
			this.estHHTxt,
			this.linhaH,
			this.nomeH,
			this.spH,
			this.habH,
			this.normalH,
			this.estHP1,
			this.estHP1n,
			this.estHP2,
			this.estHP2n,
			this.estHTxt,
			this.linhaL,
			this.nomeL,
			this.spL,
			this.habL,
			this.normalL,
			this.estLP1,
			this.estLP1n,
			this.estLP2,
			this.estLP2n,
			this.estLTxt,
			this.linhaLL,
			this.nomeLL,
			this.spLL,
			this.habLL,
			this.normalLL,
			this.estLLP1,
			this.estLLP1n,
			this.estLLP2,
			this.estLLP2n,
			this.estLLTxt,
			this.linhaFalha,
			this.nomeFalha,
			this.normalFalha,
			this.estFalhaP1,
			this.estFalhaP1n,
			this.estFalhaP2,
			this.estFalhaP2n,
			this.estFalhaTxt,
			this.btnReset,
			this.btnParametros,
			this.btnAlarmes,
			this.btnGrafico,
			this.xEstado,
			this.xFalha,
			this.xFalhaAtiva,
			this.xValor,
			this.xUnidade,
			this.xCasas,
			this.xAlHH,
			this.xAlH,
			this.xAlL,
			this.xAlLL,
			this.xEHH,
			this.xEH,
			this.xEL,
			this.xELL,
			this.xEFalha,
			this.xHabHH,
			this.xSpHH,
			this.xHabH,
			this.xSpH,
			this.xHabL,
			this.xSpL,
			this.xHabLL,
			this.xSpLL,
			this.xRMin,
			this.xRMax,
			this.xNivel});
			this.Size = new System.Drawing.Size(380, 398);

		}
		private NxtControl.GuiFramework.Rectangle cabecalho;
		private NxtControl.GuiFramework.FreeText tituloValor;
		private System.HMI.Symbols.Base.Label<System.Single> valor;
		private NxtControl.GuiFramework.FreeText invalido;
		private NxtControl.GuiFramework.FreeText textoEstado;
		private NxtControl.GuiFramework.Rectangle alP1;
		private NxtControl.GuiFramework.FreeText alP1n;
		private NxtControl.GuiFramework.Polygon alP2;
		private NxtControl.GuiFramework.FreeText alP2n;
		private NxtControl.GuiFramework.FreeText alTxt;
		private NxtControl.GuiFramework.FreeText tituloNivel;
		private System.HMI.Symbols.Base.Label<System.Single> porcentagem;
		private NxtControl.GuiFramework.Rectangle maiLL;
		private NxtControl.GuiFramework.Rectangle maiL;
		private NxtControl.GuiFramework.Rectangle maiN;
		private NxtControl.GuiFramework.Rectangle maiH;
		private NxtControl.GuiFramework.Rectangle maiHH;
		private NxtControl.GuiFramework.Polygon maiPonteiro;
		private System.HMI.Symbols.Base.Label<System.Single> escalaMin;
		private System.HMI.Symbols.Base.Label<System.Single> escalaMax;
		private NxtControl.GuiFramework.FreeText tituloAlarmes;
		private NxtControl.GuiFramework.FreeText colSetpoint;
		private NxtControl.GuiFramework.FreeText colHab;
		private NxtControl.GuiFramework.FreeText colEstado;
		private NxtControl.GuiFramework.Rectangle linhaHH;
		private NxtControl.GuiFramework.FreeText nomeHH;
		private System.HMI.Symbols.Base.Label<System.Single> spHH;
		private System.HMI.Symbols.Base.FreeText<bool> habHH;
		private NxtControl.GuiFramework.FreeText normalHH;
		private NxtControl.GuiFramework.Rectangle estHHP1;
		private NxtControl.GuiFramework.FreeText estHHP1n;
		private NxtControl.GuiFramework.Polygon estHHP2;
		private NxtControl.GuiFramework.FreeText estHHP2n;
		private NxtControl.GuiFramework.FreeText estHHTxt;
		private NxtControl.GuiFramework.Rectangle linhaH;
		private NxtControl.GuiFramework.FreeText nomeH;
		private System.HMI.Symbols.Base.Label<System.Single> spH;
		private System.HMI.Symbols.Base.FreeText<bool> habH;
		private NxtControl.GuiFramework.FreeText normalH;
		private NxtControl.GuiFramework.Rectangle estHP1;
		private NxtControl.GuiFramework.FreeText estHP1n;
		private NxtControl.GuiFramework.Polygon estHP2;
		private NxtControl.GuiFramework.FreeText estHP2n;
		private NxtControl.GuiFramework.FreeText estHTxt;
		private NxtControl.GuiFramework.Rectangle linhaL;
		private NxtControl.GuiFramework.FreeText nomeL;
		private System.HMI.Symbols.Base.Label<System.Single> spL;
		private System.HMI.Symbols.Base.FreeText<bool> habL;
		private NxtControl.GuiFramework.FreeText normalL;
		private NxtControl.GuiFramework.Rectangle estLP1;
		private NxtControl.GuiFramework.FreeText estLP1n;
		private NxtControl.GuiFramework.Polygon estLP2;
		private NxtControl.GuiFramework.FreeText estLP2n;
		private NxtControl.GuiFramework.FreeText estLTxt;
		private NxtControl.GuiFramework.Rectangle linhaLL;
		private NxtControl.GuiFramework.FreeText nomeLL;
		private System.HMI.Symbols.Base.Label<System.Single> spLL;
		private System.HMI.Symbols.Base.FreeText<bool> habLL;
		private NxtControl.GuiFramework.FreeText normalLL;
		private NxtControl.GuiFramework.Rectangle estLLP1;
		private NxtControl.GuiFramework.FreeText estLLP1n;
		private NxtControl.GuiFramework.Polygon estLLP2;
		private NxtControl.GuiFramework.FreeText estLLP2n;
		private NxtControl.GuiFramework.FreeText estLLTxt;
		private NxtControl.GuiFramework.Rectangle linhaFalha;
		private NxtControl.GuiFramework.FreeText nomeFalha;
		private NxtControl.GuiFramework.FreeText normalFalha;
		private NxtControl.GuiFramework.Rectangle estFalhaP1;
		private NxtControl.GuiFramework.FreeText estFalhaP1n;
		private NxtControl.GuiFramework.Polygon estFalhaP2;
		private NxtControl.GuiFramework.FreeText estFalhaP2n;
		private NxtControl.GuiFramework.FreeText estFalhaTxt;
		private NxtControl.GuiFramework.DrawnButton btnReset;
		private NxtControl.GuiFramework.DrawnButton btnParametros;
		private NxtControl.GuiFramework.DrawnButton btnAlarmes;
		private NxtControl.GuiFramework.DrawnButton btnGrafico;
		private System.HMI.Symbols.Base.Execute<short> xEstado;
		private System.HMI.Symbols.Base.Execute<bool> xFalha;
		private System.HMI.Symbols.Base.Execute<bool> xFalhaAtiva;
		private System.HMI.Symbols.Base.Execute<float> xValor;
		private System.HMI.Symbols.Base.Execute<string> xUnidade;
		private System.HMI.Symbols.Base.Execute<ushort> xCasas;
		private System.HMI.Symbols.Base.Execute<bool> xAlHH;
		private System.HMI.Symbols.Base.Execute<bool> xAlH;
		private System.HMI.Symbols.Base.Execute<bool> xAlL;
		private System.HMI.Symbols.Base.Execute<bool> xAlLL;
		private System.HMI.Symbols.Base.Execute<byte> xEHH;
		private System.HMI.Symbols.Base.Execute<byte> xEH;
		private System.HMI.Symbols.Base.Execute<byte> xEL;
		private System.HMI.Symbols.Base.Execute<byte> xELL;
		private System.HMI.Symbols.Base.Execute<byte> xEFalha;
		private System.HMI.Symbols.Base.Execute<bool> xHabHH;
		private System.HMI.Symbols.Base.Execute<float> xSpHH;
		private System.HMI.Symbols.Base.Execute<bool> xHabH;
		private System.HMI.Symbols.Base.Execute<float> xSpH;
		private System.HMI.Symbols.Base.Execute<bool> xHabL;
		private System.HMI.Symbols.Base.Execute<float> xSpL;
		private System.HMI.Symbols.Base.Execute<bool> xHabLL;
		private System.HMI.Symbols.Base.Execute<float> xSpLL;
		private System.HMI.Symbols.Base.Execute<float> xRMin;
		private System.HMI.Symbols.Base.Execute<float> xRMax;
		private System.HMI.Symbols.Base.Execute<bool> xNivel;
		#endregion
	}
}
