/*
 * Hidryco - Sensor_Generico - sDefault
 * ISA-101: tag, valor com unidade, indicador de alarme (forma+prioridade+texto) e indicador analogico de faixa.
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Symbols.Sensor_Generico
{
	/// <summary>
	/// Summary description for sDefault.
	/// </summary>
	partial class sDefault
	{

		#region Component Designer generated code
		private void InitializeComponent()
		{
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary1 = new NxtControl.GuiFramework.PropertyDictionary();
			this.fundo = new NxtControl.GuiFramework.Rectangle();
			this.InstanceName = new NxtControl.GuiFramework.AliasDisplayLabel();
			this.valor = new System.HMI.Symbols.Base.Label<System.Single>();
			this.invalido = new NxtControl.GuiFramework.FreeText();
			this.alP1 = new NxtControl.GuiFramework.Rectangle();
			this.alP1n = new NxtControl.GuiFramework.FreeText();
			this.alP2 = new NxtControl.GuiFramework.Polygon();
			this.alP2n = new NxtControl.GuiFramework.FreeText();
			this.alTxt = new NxtControl.GuiFramework.FreeText();
			this.maiLL = new NxtControl.GuiFramework.Rectangle();
			this.maiL = new NxtControl.GuiFramework.Rectangle();
			this.maiN = new NxtControl.GuiFramework.Rectangle();
			this.maiH = new NxtControl.GuiFramework.Rectangle();
			this.maiHH = new NxtControl.GuiFramework.Rectangle();
			this.maiPonteiro = new NxtControl.GuiFramework.Polygon();
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
			this.abrir = new NxtControl.GuiFramework.DrawnButton();
			// 
			// fundo
			// 
			this.fundo.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(176D)), ((float)(62D)));
			this.fundo.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(232)), ((byte)(232)), ((byte)(232))));
			this.fundo.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.fundo.Name = "fundo";
			this.fundo.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// InstanceName
			// 
			this.InstanceName.AngleIgnore = true;
			this.InstanceName.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.InstanceName.Bounds = new NxtControl.Drawing.RectF(((float)(6D)), ((float)(2D)), ((float)(110D)), ((float)(16D)));
			this.InstanceName.Brush = new NxtControl.Drawing.Brush(true);
			this.InstanceName.CustomInstanceName = null;
			this.InstanceName.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.InstanceName.FontScale = false;
			this.InstanceName.Name = "InstanceName";
			this.InstanceName.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.InstanceName.Text = "Label";
			this.InstanceName.TextColor = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			// 
			// valor
			// 
			this.valor.BeginInit();
			this.valor.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.valor.DecimalPlacesCount = ((uint)(2u));
			this.valor.DesignMatrix = new NxtControl.Drawing.Matrix2D(1.1506D, 0D, 0D, 1.05D, 6D, 17D);
			this.valor.Font = new NxtControl.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
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
			this.valor.Suffix = "";
			this.valor.TagName = "STS_VALOR";
			this.valor.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.valor.EndInit();
			// 
			// invalido
			// 
			this.invalido.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.invalido.Font = new NxtControl.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
			this.invalido.Location = new NxtControl.Drawing.PointF(10D, 21D);
			this.invalido.Name = "invalido";
			this.invalido.Text = "DESAB.";
			this.invalido.Visible = false;
			// 
			// alP1
			// 
			this.alP1.Bounds = new NxtControl.Drawing.RectF(((float)(120D)), ((float)(3D)), ((float)(16D)), ((float)(16D)));
			this.alP1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(230)), ((byte)(0)), ((byte)(0))));
			this.alP1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.alP1.Name = "alP1";
			this.alP1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.alP1.Visible = false;
			// 
			// alP1n
			// 
			this.alP1n.Color = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.alP1n.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.alP1n.Location = new NxtControl.Drawing.PointF(124D, 4D);
			this.alP1n.Name = "alP1n";
			this.alP1n.Text = "1";
			this.alP1n.Visible = false;
			// 
			// alP2
			// 
			this.alP2.Bounds = new NxtControl.Drawing.RectF(((float)(120D)), ((float)(3D)), ((float)(16D)), ((float)(16D)));
			this.alP2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(205)), ((byte)(0))));
			this.alP2.Closed = true;
			this.alP2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.alP2.Name = "alP2";
			this.alP2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.alP2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(120D, 19D),
			new NxtControl.Drawing.PointF(128D, 3D),
			new NxtControl.Drawing.PointF(136D, 19D)});
			this.alP2.Visible = false;
			// 
			// alP2n
			// 
			this.alP2n.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.alP2n.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
			this.alP2n.Location = new NxtControl.Drawing.PointF(125D, 7D);
			this.alP2n.Name = "alP2n";
			this.alP2n.Text = "2";
			this.alP2n.Visible = false;
			// 
			// alTxt
			// 
			this.alTxt.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.alTxt.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.alTxt.Location = new NxtControl.Drawing.PointF(140D, 3D);
			this.alTxt.Name = "alTxt";
			this.alTxt.Text = "";
			this.alTxt.Visible = false;
			// 
			// maiLL
			// 
			this.maiLL.Bounds = new NxtControl.Drawing.RectF(((float)(8D)), ((float)(44D)), ((float)(0.01D)), ((float)(6D)));
			this.maiLL.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(165)), ((byte)(165)), ((byte)(165))));
			this.maiLL.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.maiLL.Name = "maiLL";
			this.maiLL.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// maiL
			// 
			this.maiL.Bounds = new NxtControl.Drawing.RectF(((float)(8D)), ((float)(44D)), ((float)(0.01D)), ((float)(6D)));
			this.maiL.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(200)), ((byte)(200)), ((byte)(200))));
			this.maiL.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.maiL.Name = "maiL";
			this.maiL.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// maiN
			// 
			this.maiN.Bounds = new NxtControl.Drawing.RectF(((float)(8D)), ((float)(44D)), ((float)(160D)), ((float)(6D)));
			this.maiN.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(245)), ((byte)(245)), ((byte)(245))));
			this.maiN.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.maiN.Name = "maiN";
			this.maiN.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// maiH
			// 
			this.maiH.Bounds = new NxtControl.Drawing.RectF(((float)(8D)), ((float)(44D)), ((float)(0.01D)), ((float)(6D)));
			this.maiH.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(200)), ((byte)(200)), ((byte)(200))));
			this.maiH.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.maiH.Name = "maiH";
			this.maiH.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// maiHH
			// 
			this.maiHH.Bounds = new NxtControl.Drawing.RectF(((float)(8D)), ((float)(44D)), ((float)(0.01D)), ((float)(6D)));
			this.maiHH.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(165)), ((byte)(165)), ((byte)(165))));
			this.maiHH.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.maiHH.Name = "maiHH";
			this.maiHH.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// maiPonteiro
			// 
			this.maiPonteiro.Bounds = new NxtControl.Drawing.RectF(((float)(83D)), ((float)(50D)), ((float)(10D)), ((float)(7D)));
			this.maiPonteiro.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			this.maiPonteiro.Closed = true;
			this.maiPonteiro.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.maiPonteiro.Name = "maiPonteiro";
			this.maiPonteiro.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			this.maiPonteiro.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(83D, 57D),
			new NxtControl.Drawing.PointF(88D, 50D),
			new NxtControl.Drawing.PointF(93D, 57D)});
			this.maiPonteiro.Visible = false;
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
			this.xEFalha.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.EFalhaValueChanged);
			this.xEFalha.EndInit();
			// 
			// xHabHH
			// 
			this.xHabHH.BeginInit();
			this.xHabHH.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xHabHH.IsOnlyInput = true;
			this.xHabHH.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xHabHH.Name = "xHabHH";
			this.xHabHH.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xHabHH.TagName = "CMD_HABILITA_ALARME_HH";
			this.xHabHH.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.HabHHValueChanged);
			this.xHabHH.EndInit();
			// 
			// xSpHH
			// 
			this.xSpHH.BeginInit();
			this.xSpHH.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xSpHH.IsOnlyInput = true;
			this.xSpHH.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xSpHH.Name = "xSpHH";
			this.xSpHH.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xSpHH.TagName = "STP_ALARME_HH";
			this.xSpHH.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.SpHHValueChanged);
			this.xSpHH.EndInit();
			// 
			// xHabH
			// 
			this.xHabH.BeginInit();
			this.xHabH.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xHabH.IsOnlyInput = true;
			this.xHabH.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xHabH.Name = "xHabH";
			this.xHabH.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xHabH.TagName = "CMD_HABILITA_ALARME_H";
			this.xHabH.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.HabHValueChanged);
			this.xHabH.EndInit();
			// 
			// xSpH
			// 
			this.xSpH.BeginInit();
			this.xSpH.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xSpH.IsOnlyInput = true;
			this.xSpH.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xSpH.Name = "xSpH";
			this.xSpH.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xSpH.TagName = "STP_ALARME_H";
			this.xSpH.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.SpHValueChanged);
			this.xSpH.EndInit();
			// 
			// xHabL
			// 
			this.xHabL.BeginInit();
			this.xHabL.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xHabL.IsOnlyInput = true;
			this.xHabL.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xHabL.Name = "xHabL";
			this.xHabL.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xHabL.TagName = "CMD_HABILITA_ALARME_L";
			this.xHabL.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.HabLValueChanged);
			this.xHabL.EndInit();
			// 
			// xSpL
			// 
			this.xSpL.BeginInit();
			this.xSpL.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xSpL.IsOnlyInput = true;
			this.xSpL.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xSpL.Name = "xSpL";
			this.xSpL.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xSpL.TagName = "STP_ALARME_L";
			this.xSpL.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.SpLValueChanged);
			this.xSpL.EndInit();
			// 
			// xHabLL
			// 
			this.xHabLL.BeginInit();
			this.xHabLL.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xHabLL.IsOnlyInput = true;
			this.xHabLL.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xHabLL.Name = "xHabLL";
			this.xHabLL.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xHabLL.TagName = "CMD_HABILITA_ALARME_LL";
			this.xHabLL.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.HabLLValueChanged);
			this.xHabLL.EndInit();
			// 
			// xSpLL
			// 
			this.xSpLL.BeginInit();
			this.xSpLL.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xSpLL.IsOnlyInput = true;
			this.xSpLL.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xSpLL.Name = "xSpLL";
			this.xSpLL.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xSpLL.TagName = "STP_ALARME_LL";
			this.xSpLL.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.SpLLValueChanged);
			this.xSpLL.EndInit();
			// 
			// xRMin
			// 
			this.xRMin.BeginInit();
			this.xRMin.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xRMin.IsOnlyInput = true;
			this.xRMin.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xRMin.Name = "xRMin";
			this.xRMin.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xRMin.TagName = "STP_RANGE_MINIMO";
			this.xRMin.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.RMinValueChanged);
			this.xRMin.EndInit();
			// 
			// xRMax
			// 
			this.xRMax.BeginInit();
			this.xRMax.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xRMax.IsOnlyInput = true;
			this.xRMax.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xRMax.Name = "xRMax";
			this.xRMax.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xRMax.TagName = "STP_RANGE_MAXIMO";
			this.xRMax.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.RMaxValueChanged);
			this.xRMax.EndInit();
			// 
			// abrir
			// 
			this.abrir.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(176D)), ((float)(62D)));
			this.abrir.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("Transparent"));
			this.abrir.ButtonPushedBrush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("Transparent"));
			this.abrir.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.abrir.Name = "abrir";
			this.abrir.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("fpDefault", NxtControl.GuiFramework.MouseButtonType.Click));
			this.abrir.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.abrir.Radius = 2D;
			this.abrir.Text = "";
			this.abrir.TextColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.abrir.TextColorMouseDown = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.abrir.Use3DEffect = false;
			// 
			// sDefault
			// 
			this.Name = "sDefault";
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.fundo,
			this.InstanceName,
			this.valor,
			this.invalido,
			this.alP1,
			this.alP1n,
			this.alP2,
			this.alP2n,
			this.alTxt,
			this.maiLL,
			this.maiL,
			this.maiN,
			this.maiH,
			this.maiHH,
			this.maiPonteiro,
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
			this.abrir});

		}
		private NxtControl.GuiFramework.Rectangle fundo;
		private NxtControl.GuiFramework.AliasDisplayLabel InstanceName;
		private System.HMI.Symbols.Base.Label<System.Single> valor;
		private NxtControl.GuiFramework.FreeText invalido;
		private NxtControl.GuiFramework.Rectangle alP1;
		private NxtControl.GuiFramework.FreeText alP1n;
		private NxtControl.GuiFramework.Polygon alP2;
		private NxtControl.GuiFramework.FreeText alP2n;
		private NxtControl.GuiFramework.FreeText alTxt;
		private NxtControl.GuiFramework.Rectangle maiLL;
		private NxtControl.GuiFramework.Rectangle maiL;
		private NxtControl.GuiFramework.Rectangle maiN;
		private NxtControl.GuiFramework.Rectangle maiH;
		private NxtControl.GuiFramework.Rectangle maiHH;
		private NxtControl.GuiFramework.Polygon maiPonteiro;
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
		private NxtControl.GuiFramework.DrawnButton abrir;
		#endregion
	}
}
