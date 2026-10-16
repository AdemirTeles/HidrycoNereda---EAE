/*
 * Hidryco - Sensor_Generico - sCompacto
 * ISA-101: valor com unidade e indicador de alarme, para fluxograma.
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Symbols.Sensor_Generico
{
	/// <summary>
	/// Summary description for sCompacto.
	/// </summary>
	partial class sCompacto
	{

		#region Component Designer generated code
		private void InitializeComponent()
		{
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary1 = new NxtControl.GuiFramework.PropertyDictionary();
			this.fundo = new NxtControl.GuiFramework.Rectangle();
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
			this.abrir = new NxtControl.GuiFramework.DrawnButton();
			// 
			// fundo
			// 
			this.fundo.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(150D)), ((float)(24D)));
			this.fundo.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(232)), ((byte)(232)), ((byte)(232))));
			this.fundo.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.fundo.Name = "fundo";
			this.fundo.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// valor
			// 
			this.valor.BeginInit();
			this.valor.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.valor.DecimalPlacesCount = ((uint)(2u));
			this.valor.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.62D, 0D, 0D, 0.95D, 4D, 0D);
			this.valor.Font = new NxtControl.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
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
			this.valor.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.valor.EndInit();
			// 
			// invalido
			// 
			this.invalido.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.invalido.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.invalido.Location = new NxtControl.Drawing.PointF(40D, 4D);
			this.invalido.Name = "invalido";
			this.invalido.Text = "DESAB.";
			this.invalido.Visible = false;
			// 
			// alP1
			// 
			this.alP1.Bounds = new NxtControl.Drawing.RectF(((float)(100D)), ((float)(4D)), ((float)(16D)), ((float)(16D)));
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
			this.alP1n.Location = new NxtControl.Drawing.PointF(104D, 5D);
			this.alP1n.Name = "alP1n";
			this.alP1n.Text = "1";
			this.alP1n.Visible = false;
			// 
			// alP2
			// 
			this.alP2.Bounds = new NxtControl.Drawing.RectF(((float)(100D)), ((float)(4D)), ((float)(16D)), ((float)(16D)));
			this.alP2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(205)), ((byte)(0))));
			this.alP2.Closed = true;
			this.alP2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.alP2.Name = "alP2";
			this.alP2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.alP2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(100D, 20D),
			new NxtControl.Drawing.PointF(108D, 4D),
			new NxtControl.Drawing.PointF(116D, 20D)});
			this.alP2.Visible = false;
			// 
			// alP2n
			// 
			this.alP2n.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.alP2n.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
			this.alP2n.Location = new NxtControl.Drawing.PointF(105D, 8D);
			this.alP2n.Name = "alP2n";
			this.alP2n.Text = "2";
			this.alP2n.Visible = false;
			// 
			// alTxt
			// 
			this.alTxt.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.alTxt.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.alTxt.Location = new NxtControl.Drawing.PointF(120D, 4D);
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
			// abrir
			// 
			this.abrir.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(150D)), ((float)(24D)));
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
			// sCompacto
			// 
			this.Name = "sCompacto";
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.fundo,
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
			this.abrir});

		}
		private NxtControl.GuiFramework.Rectangle fundo;
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
		private NxtControl.GuiFramework.DrawnButton abrir;
		#endregion
	}
}
