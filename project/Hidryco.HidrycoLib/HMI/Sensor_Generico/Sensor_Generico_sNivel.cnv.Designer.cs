/*
 * Hidryco - Sensor_Generico - sNivel
 * ISA-101: tanque em cinza com nivel em %, marcas dos limites de alarme habilitados, valor e indicador de alarme.
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Symbols.Sensor_Generico
{
	/// <summary>
	/// Summary description for sNivel.
	/// </summary>
	partial class sNivel
	{

		#region Component Designer generated code
		private void InitializeComponent()
		{
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary1 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary2 = new NxtControl.GuiFramework.PropertyDictionary();
			this.InstanceName = new NxtControl.GuiFramework.AliasDisplayLabel();
			this.tanque = new NxtControl.GuiFramework.Rectangle();
			this.nivel = new NxtControl.GuiFramework.Rectangle();
			this.marcaHH = new NxtControl.GuiFramework.Rectangle();
			this.marcaTxtHH = new NxtControl.GuiFramework.FreeText();
			this.marcaH = new NxtControl.GuiFramework.Rectangle();
			this.marcaTxtH = new NxtControl.GuiFramework.FreeText();
			this.marcaL = new NxtControl.GuiFramework.Rectangle();
			this.marcaTxtL = new NxtControl.GuiFramework.FreeText();
			this.marcaLL = new NxtControl.GuiFramework.Rectangle();
			this.marcaTxtLL = new NxtControl.GuiFramework.FreeText();
			this.porcentagem = new System.HMI.Symbols.Base.Label<System.Single>();
			this.valor = new System.HMI.Symbols.Base.Label<System.Single>();
			this.invalido = new NxtControl.GuiFramework.FreeText();
			this.alP1 = new NxtControl.GuiFramework.Rectangle();
			this.alP1n = new NxtControl.GuiFramework.FreeText();
			this.alP2 = new NxtControl.GuiFramework.Polygon();
			this.alP2n = new NxtControl.GuiFramework.FreeText();
			this.alTxt = new NxtControl.GuiFramework.FreeText();
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
			this.xAltura = new System.HMI.Symbols.Base.Execute<float>();
			this.xPorcentagem = new System.HMI.Symbols.Base.Execute<float>();
			this.abrir = new NxtControl.GuiFramework.DrawnButton();
			// 
			// InstanceName
			// 
			this.InstanceName.AngleIgnore = true;
			this.InstanceName.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.InstanceName.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(92D)), ((float)(16D)));
			this.InstanceName.Brush = new NxtControl.Drawing.Brush(true);
			this.InstanceName.CustomInstanceName = null;
			this.InstanceName.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.InstanceName.FontScale = false;
			this.InstanceName.Name = "InstanceName";
			this.InstanceName.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.InstanceName.Text = "Label";
			this.InstanceName.TextColor = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			// 
			// tanque
			// 
			this.tanque.Bounds = new NxtControl.Drawing.RectF(((float)(24D)), ((float)(20D)), ((float)(56D)), ((float)(104D)));
			this.tanque.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(245)), ((byte)(245)), ((byte)(245))));
			this.tanque.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.tanque.Name = "tanque";
			this.tanque.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 2F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// nivel
			// 
			this.nivel.Bounds = new NxtControl.Drawing.RectF(((float)(25D)), ((float)(21D)), ((float)(54D)), ((float)(102D)));
			this.nivel.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(150)), ((byte)(150)), ((byte)(150))));
			this.nivel.FillDirection = NxtControl.Drawing.FillDirection.DownToTop;
			this.nivel.FillPercent = 0F;
			this.nivel.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.nivel.Name = "nivel";
			this.nivel.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// marcaHH
			// 
			this.marcaHH.Bounds = new NxtControl.Drawing.RectF(((float)(80D)), ((float)(70D)), ((float)(8D)), ((float)(2D)));
			this.marcaHH.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			this.marcaHH.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.marcaHH.Name = "marcaHH";
			this.marcaHH.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			this.marcaHH.Visible = false;
			// 
			// marcaTxtHH
			// 
			this.marcaTxtHH.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.marcaTxtHH.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Regular);
			this.marcaTxtHH.Location = new NxtControl.Drawing.PointF(90D, 64D);
			this.marcaTxtHH.Name = "marcaTxtHH";
			this.marcaTxtHH.Text = "HH";
			this.marcaTxtHH.Visible = false;
			// 
			// marcaH
			// 
			this.marcaH.Bounds = new NxtControl.Drawing.RectF(((float)(80D)), ((float)(70D)), ((float)(8D)), ((float)(2D)));
			this.marcaH.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			this.marcaH.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.marcaH.Name = "marcaH";
			this.marcaH.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			this.marcaH.Visible = false;
			// 
			// marcaTxtH
			// 
			this.marcaTxtH.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.marcaTxtH.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Regular);
			this.marcaTxtH.Location = new NxtControl.Drawing.PointF(90D, 64D);
			this.marcaTxtH.Name = "marcaTxtH";
			this.marcaTxtH.Text = "H";
			this.marcaTxtH.Visible = false;
			// 
			// marcaL
			// 
			this.marcaL.Bounds = new NxtControl.Drawing.RectF(((float)(80D)), ((float)(70D)), ((float)(8D)), ((float)(2D)));
			this.marcaL.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			this.marcaL.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.marcaL.Name = "marcaL";
			this.marcaL.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			this.marcaL.Visible = false;
			// 
			// marcaTxtL
			// 
			this.marcaTxtL.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.marcaTxtL.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Regular);
			this.marcaTxtL.Location = new NxtControl.Drawing.PointF(90D, 64D);
			this.marcaTxtL.Name = "marcaTxtL";
			this.marcaTxtL.Text = "L";
			this.marcaTxtL.Visible = false;
			// 
			// marcaLL
			// 
			this.marcaLL.Bounds = new NxtControl.Drawing.RectF(((float)(80D)), ((float)(70D)), ((float)(8D)), ((float)(2D)));
			this.marcaLL.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			this.marcaLL.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.marcaLL.Name = "marcaLL";
			this.marcaLL.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			this.marcaLL.Visible = false;
			// 
			// marcaTxtLL
			// 
			this.marcaTxtLL.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.marcaTxtLL.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Regular);
			this.marcaTxtLL.Location = new NxtControl.Drawing.PointF(90D, 64D);
			this.marcaTxtLL.Name = "marcaTxtLL";
			this.marcaTxtLL.Text = "LL";
			this.marcaTxtLL.Visible = false;
			// 
			// porcentagem
			// 
			this.porcentagem.BeginInit();
			this.porcentagem.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.porcentagem.DecimalPlacesCount = ((uint)(0u));
			this.porcentagem.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.7D, 0D, 0D, 1D, 0D, 128D);
			this.porcentagem.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.porcentagem.FontScale = false;
			this.porcentagem.IsOnlyInput = true;
			this.porcentagem.IsPrefixSuffixOutside = false;
			this.porcentagem.LeadingZeros = ((uint)(0u));
			this.porcentagem.Name = "porcentagem";
			this.porcentagem.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			propertyDictionary1.Add("Text", "${Value}");
			propertyDictionary1.Add("TextColor", new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			propertyDictionary1.Add("Brush", new NxtControl.Drawing.Brush(true));
			propertyDictionary1.Add("Pen", new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid));
			this.porcentagem.Ranges.DefaultPropertyValues = propertyDictionary1;
			this.porcentagem.Suffix = " %";
			this.porcentagem.TagName = "STS_PORCENTAGEM";
			this.porcentagem.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			this.porcentagem.EndInit();
			// 
			// valor
			// 
			this.valor.BeginInit();
			this.valor.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.valor.DecimalPlacesCount = ((uint)(2u));
			this.valor.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.7D, 0D, 0D, 1D, 0D, 146D);
			this.valor.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.valor.FontScale = false;
			this.valor.IsOnlyInput = true;
			this.valor.IsPrefixSuffixOutside = false;
			this.valor.LeadingZeros = ((uint)(0u));
			this.valor.Name = "valor";
			this.valor.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			propertyDictionary2.Add("Text", "${Value}");
			propertyDictionary2.Add("TextColor", new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64))));
			propertyDictionary2.Add("Brush", new NxtControl.Drawing.Brush(true));
			propertyDictionary2.Add("Pen", new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid));
			this.valor.Ranges.DefaultPropertyValues = propertyDictionary2;
			this.valor.Suffix = "";
			this.valor.TagName = "STS_VALOR";
			this.valor.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			this.valor.EndInit();
			// 
			// invalido
			// 
			this.invalido.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.invalido.Font = new NxtControl.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
			this.invalido.Location = new NxtControl.Drawing.PointF(36D, 130D);
			this.invalido.Name = "invalido";
			this.invalido.Text = "DESAB.";
			this.invalido.Visible = false;
			// 
			// alP1
			// 
			this.alP1.Bounds = new NxtControl.Drawing.RectF(((float)(94D)), ((float)(0D)), ((float)(16D)), ((float)(16D)));
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
			this.alP1n.Location = new NxtControl.Drawing.PointF(98D, 1D);
			this.alP1n.Name = "alP1n";
			this.alP1n.Text = "1";
			this.alP1n.Visible = false;
			// 
			// alP2
			// 
			this.alP2.Bounds = new NxtControl.Drawing.RectF(((float)(94D)), ((float)(0D)), ((float)(16D)), ((float)(16D)));
			this.alP2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(205)), ((byte)(0))));
			this.alP2.Closed = true;
			this.alP2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.alP2.Name = "alP2";
			this.alP2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.alP2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(94D, 16D),
			new NxtControl.Drawing.PointF(102D, 0D),
			new NxtControl.Drawing.PointF(110D, 16D)});
			this.alP2.Visible = false;
			// 
			// alP2n
			// 
			this.alP2n.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.alP2n.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
			this.alP2n.Location = new NxtControl.Drawing.PointF(99D, 4D);
			this.alP2n.Name = "alP2n";
			this.alP2n.Text = "2";
			this.alP2n.Visible = false;
			// 
			// alTxt
			// 
			this.alTxt.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.alTxt.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.alTxt.Location = new NxtControl.Drawing.PointF(114D, 0D);
			this.alTxt.Name = "alTxt";
			this.alTxt.Text = "";
			this.alTxt.Visible = false;
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
			// xAltura
			// 
			this.xAltura.BeginInit();
			this.xAltura.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xAltura.IsOnlyInput = true;
			this.xAltura.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xAltura.Name = "xAltura";
			this.xAltura.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xAltura.TagName = "STP_ALTURA_MAXIMA";
			this.xAltura.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.AlturaValueChanged);
			this.xAltura.EndInit();
			// 
			// xPorcentagem
			// 
			this.xPorcentagem.BeginInit();
			this.xPorcentagem.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xPorcentagem.IsOnlyInput = true;
			this.xPorcentagem.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xPorcentagem.Name = "xPorcentagem";
			this.xPorcentagem.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xPorcentagem.TagName = "STS_PORCENTAGEM";
			this.xPorcentagem.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.PorcentagemValueChanged);
			this.xPorcentagem.EndInit();
			// 
			// abrir
			// 
			this.abrir.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(130D)), ((float)(166D)));
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
			// sNivel
			// 
			this.Name = "sNivel";
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.InstanceName,
			this.tanque,
			this.nivel,
			this.marcaHH,
			this.marcaTxtHH,
			this.marcaH,
			this.marcaTxtH,
			this.marcaL,
			this.marcaTxtL,
			this.marcaLL,
			this.marcaTxtLL,
			this.porcentagem,
			this.valor,
			this.invalido,
			this.alP1,
			this.alP1n,
			this.alP2,
			this.alP2n,
			this.alTxt,
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
			this.xAltura,
			this.xPorcentagem,
			this.abrir});

		}
		private NxtControl.GuiFramework.AliasDisplayLabel InstanceName;
		private NxtControl.GuiFramework.Rectangle tanque;
		private NxtControl.GuiFramework.Rectangle nivel;
		private NxtControl.GuiFramework.Rectangle marcaHH;
		private NxtControl.GuiFramework.FreeText marcaTxtHH;
		private NxtControl.GuiFramework.Rectangle marcaH;
		private NxtControl.GuiFramework.FreeText marcaTxtH;
		private NxtControl.GuiFramework.Rectangle marcaL;
		private NxtControl.GuiFramework.FreeText marcaTxtL;
		private NxtControl.GuiFramework.Rectangle marcaLL;
		private NxtControl.GuiFramework.FreeText marcaTxtLL;
		private System.HMI.Symbols.Base.Label<System.Single> porcentagem;
		private System.HMI.Symbols.Base.Label<System.Single> valor;
		private NxtControl.GuiFramework.FreeText invalido;
		private NxtControl.GuiFramework.Rectangle alP1;
		private NxtControl.GuiFramework.FreeText alP1n;
		private NxtControl.GuiFramework.Polygon alP2;
		private NxtControl.GuiFramework.FreeText alP2n;
		private NxtControl.GuiFramework.FreeText alTxt;
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
		private System.HMI.Symbols.Base.Execute<float> xAltura;
		private System.HMI.Symbols.Base.Execute<float> xPorcentagem;
		private NxtControl.GuiFramework.DrawnButton abrir;
		#endregion
	}
}
