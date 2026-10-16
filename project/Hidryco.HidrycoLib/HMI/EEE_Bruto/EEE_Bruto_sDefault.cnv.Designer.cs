/*
 * Hidryco - EEE_Bruto - sDefault
 * ISA-101: elevatoria - estado em texto, bombas pedidas/ligadas, principal, nivel e indicador de alarme.
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Symbols.EEE_Bruto
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
			this.alP1 = new NxtControl.GuiFramework.Rectangle();
			this.alP1n = new NxtControl.GuiFramework.FreeText();
			this.alP2 = new NxtControl.GuiFramework.Polygon();
			this.alP2n = new NxtControl.GuiFramework.FreeText();
			this.alTxt = new NxtControl.GuiFramework.FreeText();
			this.textoEstado = new NxtControl.GuiFramework.FreeText();
			this.textoBombas = new NxtControl.GuiFramework.FreeText();
			this.tituloNivel = new NxtControl.GuiFramework.FreeText();
			this.nivel = new System.HMI.Symbols.Base.Label<System.Single>();
			this.textoPrincipal = new NxtControl.GuiFramework.FreeText();
			this.xEstado = new System.HMI.Symbols.Base.Execute<short>();
			this.xNec = new System.HMI.Symbols.Base.Execute<ushort>();
			this.xLigadas = new System.HMI.Symbols.Base.Execute<ushort>();
			this.xPrincipal = new System.HMI.Symbols.Base.Execute<ushort>();
			this.xSegunda = new System.HMI.Symbols.Base.Execute<ushort>();
			this.xRh = new System.HMI.Symbols.Base.Execute<ushort>();
			this.xRm = new System.HMI.Symbols.Base.Execute<ushort>();
			this.xRs = new System.HMI.Symbols.Base.Execute<ushort>();
			this.xRecalque = new System.HMI.Symbols.Base.Execute<bool>();
			this.xBoiaH = new System.HMI.Symbols.Base.Execute<bool>();
			this.xBoiaL = new System.HMI.Symbols.Base.Execute<bool>();
			this.xFalhaBoia = new System.HMI.Symbols.Base.Execute<bool>();
			this.xNivelBaixo = new System.HMI.Symbols.Base.Execute<bool>();
			this.xBuffer = new System.HMI.Symbols.Base.Execute<bool>();
			this.xERecalque = new System.HMI.Symbols.Base.Execute<byte>();
			this.xENivelAlto = new System.HMI.Symbols.Base.Execute<byte>();
			this.xEFalhaBoia = new System.HMI.Symbols.Base.Execute<byte>();
			this.abrir = new NxtControl.GuiFramework.DrawnButton();
			// 
			// fundo
			// 
			this.fundo.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(250D)), ((float)(86D)));
			this.fundo.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(232)), ((byte)(232)), ((byte)(232))));
			this.fundo.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.fundo.Name = "fundo";
			this.fundo.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// InstanceName
			// 
			this.InstanceName.AngleIgnore = true;
			this.InstanceName.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.InstanceName.Bounds = new NxtControl.Drawing.RectF(((float)(6D)), ((float)(2D)), ((float)(140D)), ((float)(16D)));
			this.InstanceName.Brush = new NxtControl.Drawing.Brush(true);
			this.InstanceName.CustomInstanceName = null;
			this.InstanceName.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.InstanceName.FontScale = false;
			this.InstanceName.Name = "InstanceName";
			this.InstanceName.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.InstanceName.Text = "Label";
			this.InstanceName.TextColor = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			// 
			// alP1
			// 
			this.alP1.Bounds = new NxtControl.Drawing.RectF(((float)(150D)), ((float)(3D)), ((float)(16D)), ((float)(16D)));
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
			this.alP1n.Location = new NxtControl.Drawing.PointF(154D, 4D);
			this.alP1n.Name = "alP1n";
			this.alP1n.Text = "1";
			this.alP1n.Visible = false;
			// 
			// alP2
			// 
			this.alP2.Bounds = new NxtControl.Drawing.RectF(((float)(150D)), ((float)(3D)), ((float)(16D)), ((float)(16D)));
			this.alP2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(205)), ((byte)(0))));
			this.alP2.Closed = true;
			this.alP2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.alP2.Name = "alP2";
			this.alP2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.alP2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(150D, 19D),
			new NxtControl.Drawing.PointF(158D, 3D),
			new NxtControl.Drawing.PointF(166D, 19D)});
			this.alP2.Visible = false;
			// 
			// alP2n
			// 
			this.alP2n.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.alP2n.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
			this.alP2n.Location = new NxtControl.Drawing.PointF(155D, 7D);
			this.alP2n.Name = "alP2n";
			this.alP2n.Text = "2";
			this.alP2n.Visible = false;
			// 
			// alTxt
			// 
			this.alTxt.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.alTxt.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.alTxt.Location = new NxtControl.Drawing.PointF(170D, 3D);
			this.alTxt.Name = "alTxt";
			this.alTxt.Text = "";
			this.alTxt.Visible = false;
			// 
			// textoEstado
			// 
			this.textoEstado.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.textoEstado.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.textoEstado.Location = new NxtControl.Drawing.PointF(8D, 22D);
			this.textoEstado.Name = "textoEstado";
			this.textoEstado.Text = "Parada";
			// 
			// textoBombas
			// 
			this.textoBombas.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.textoBombas.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.textoBombas.Location = new NxtControl.Drawing.PointF(8D, 42D);
			this.textoBombas.Name = "textoBombas";
			this.textoBombas.Text = "Bombas: 0 ligada(s) / 0 pedida(s)";
			// 
			// tituloNivel
			// 
			this.tituloNivel.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.tituloNivel.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.tituloNivel.Location = new NxtControl.Drawing.PointF(8D, 62D);
			this.tituloNivel.Name = "tituloNivel";
			this.tituloNivel.Text = "Nível";
			// 
			// nivel
			// 
			this.nivel.BeginInit();
			this.nivel.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.nivel.DecimalPlacesCount = ((uint)(2u));
			this.nivel.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.55D, 0D, 0D, 1D, 46D, 58D);
			this.nivel.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.nivel.FontScale = false;
			this.nivel.IsOnlyInput = true;
			this.nivel.IsPrefixSuffixOutside = false;
			this.nivel.LeadingZeros = ((uint)(0u));
			this.nivel.Name = "nivel";
			this.nivel.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			propertyDictionary1.Add("Text", "${Value}");
			propertyDictionary1.Add("TextColor", new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			propertyDictionary1.Add("Brush", new NxtControl.Drawing.Brush(true));
			propertyDictionary1.Add("Pen", new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid));
			this.nivel.Ranges.DefaultPropertyValues = propertyDictionary1;
			this.nivel.Suffix = "";
			this.nivel.TagName = "STS_NIVEL";
			this.nivel.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.nivel.EndInit();
			// 
			// textoPrincipal
			// 
			this.textoPrincipal.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.textoPrincipal.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.textoPrincipal.Location = new NxtControl.Drawing.PointF(150D, 62D);
			this.textoPrincipal.Name = "textoPrincipal";
			this.textoPrincipal.Text = "Principal BS-01";
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
			// xNec
			// 
			this.xNec.BeginInit();
			this.xNec.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xNec.IsOnlyInput = true;
			this.xNec.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xNec.Name = "xNec";
			this.xNec.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xNec.TagName = "STS_NECESSIDADE_EQUIPAMENTO";
			this.xNec.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.NecessidadeValueChanged);
			this.xNec.EndInit();
			// 
			// xLigadas
			// 
			this.xLigadas.BeginInit();
			this.xLigadas.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xLigadas.IsOnlyInput = true;
			this.xLigadas.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xLigadas.Name = "xLigadas";
			this.xLigadas.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xLigadas.TagName = "STS_BOMBAS_LIGADAS";
			this.xLigadas.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.LigadasValueChanged);
			this.xLigadas.EndInit();
			// 
			// xPrincipal
			// 
			this.xPrincipal.BeginInit();
			this.xPrincipal.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xPrincipal.IsOnlyInput = true;
			this.xPrincipal.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xPrincipal.Name = "xPrincipal";
			this.xPrincipal.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xPrincipal.TagName = "STS_PRINCIPAL";
			this.xPrincipal.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.PrincipalValueChanged);
			this.xPrincipal.EndInit();
			// 
			// xSegunda
			// 
			this.xSegunda.BeginInit();
			this.xSegunda.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xSegunda.IsOnlyInput = true;
			this.xSegunda.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xSegunda.Name = "xSegunda";
			this.xSegunda.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xSegunda.TagName = "STS_SEGUNDA";
			this.xSegunda.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.SegundaValueChanged);
			this.xSegunda.EndInit();
			// 
			// xRh
			// 
			this.xRh.BeginInit();
			this.xRh.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xRh.IsOnlyInput = true;
			this.xRh.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xRh.Name = "xRh";
			this.xRh.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xRh.TagName = "STS_RESTANTE_HOR";
			this.xRh.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.RhValueChanged);
			this.xRh.EndInit();
			// 
			// xRm
			// 
			this.xRm.BeginInit();
			this.xRm.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xRm.IsOnlyInput = true;
			this.xRm.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xRm.Name = "xRm";
			this.xRm.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xRm.TagName = "STS_RESTANTE_MIN";
			this.xRm.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.RmValueChanged);
			this.xRm.EndInit();
			// 
			// xRs
			// 
			this.xRs.BeginInit();
			this.xRs.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xRs.IsOnlyInput = true;
			this.xRs.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xRs.Name = "xRs";
			this.xRs.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xRs.TagName = "STS_RESTANTE_SEG";
			this.xRs.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.RsValueChanged);
			this.xRs.EndInit();
			// 
			// xRecalque
			// 
			this.xRecalque.BeginInit();
			this.xRecalque.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xRecalque.IsOnlyInput = true;
			this.xRecalque.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xRecalque.Name = "xRecalque";
			this.xRecalque.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xRecalque.TagName = "STS_FALHA_RECALQUE";
			this.xRecalque.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.RecalqueValueChanged);
			this.xRecalque.EndInit();
			// 
			// xBoiaH
			// 
			this.xBoiaH.BeginInit();
			this.xBoiaH.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xBoiaH.IsOnlyInput = true;
			this.xBoiaH.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xBoiaH.Name = "xBoiaH";
			this.xBoiaH.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xBoiaH.TagName = "STS_BOIA_H";
			this.xBoiaH.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.BoiaHValueChanged);
			this.xBoiaH.EndInit();
			// 
			// xBoiaL
			// 
			this.xBoiaL.BeginInit();
			this.xBoiaL.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xBoiaL.IsOnlyInput = true;
			this.xBoiaL.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xBoiaL.Name = "xBoiaL";
			this.xBoiaL.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xBoiaL.TagName = "STS_BOIA_L";
			this.xBoiaL.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.BoiaLValueChanged);
			this.xBoiaL.EndInit();
			// 
			// xFalhaBoia
			// 
			this.xFalhaBoia.BeginInit();
			this.xFalhaBoia.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xFalhaBoia.IsOnlyInput = true;
			this.xFalhaBoia.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xFalhaBoia.Name = "xFalhaBoia";
			this.xFalhaBoia.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xFalhaBoia.TagName = "STS_FALHA_BOIA_L";
			this.xFalhaBoia.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.FalhaBoiaValueChanged);
			this.xFalhaBoia.EndInit();
			// 
			// xNivelBaixo
			// 
			this.xNivelBaixo.BeginInit();
			this.xNivelBaixo.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xNivelBaixo.IsOnlyInput = true;
			this.xNivelBaixo.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xNivelBaixo.Name = "xNivelBaixo";
			this.xNivelBaixo.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xNivelBaixo.TagName = "STS_NIVEL_BAIXO";
			this.xNivelBaixo.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.NivelBaixoValueChanged);
			this.xNivelBaixo.EndInit();
			// 
			// xBuffer
			// 
			this.xBuffer.BeginInit();
			this.xBuffer.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xBuffer.IsOnlyInput = true;
			this.xBuffer.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xBuffer.Name = "xBuffer";
			this.xBuffer.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xBuffer.TagName = "STS_BUFFER_HH";
			this.xBuffer.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.BufferValueChanged);
			this.xBuffer.EndInit();
			// 
			// xERecalque
			// 
			this.xERecalque.BeginInit();
			this.xERecalque.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xERecalque.IsOnlyInput = true;
			this.xERecalque.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xERecalque.Name = "xERecalque";
			this.xERecalque.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xERecalque.TagName = "STS_ALM_RECALQUE_EST";
			this.xERecalque.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.ERecalqueValueChanged);
			this.xERecalque.EndInit();
			// 
			// xENivelAlto
			// 
			this.xENivelAlto.BeginInit();
			this.xENivelAlto.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xENivelAlto.IsOnlyInput = true;
			this.xENivelAlto.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xENivelAlto.Name = "xENivelAlto";
			this.xENivelAlto.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xENivelAlto.TagName = "STS_ALM_NIVEL_ALTO_EST";
			this.xENivelAlto.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.ENivelAltoValueChanged);
			this.xENivelAlto.EndInit();
			// 
			// xEFalhaBoia
			// 
			this.xEFalhaBoia.BeginInit();
			this.xEFalhaBoia.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xEFalhaBoia.IsOnlyInput = true;
			this.xEFalhaBoia.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xEFalhaBoia.Name = "xEFalhaBoia";
			this.xEFalhaBoia.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xEFalhaBoia.TagName = "STS_ALM_FALHA_BOIA_EST";
			this.xEFalhaBoia.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.EFalhaBoiaValueChanged);
			this.xEFalhaBoia.EndInit();
			// 
			// abrir
			// 
			this.abrir.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(250D)), ((float)(86D)));
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
			this.alP1,
			this.alP1n,
			this.alP2,
			this.alP2n,
			this.alTxt,
			this.textoEstado,
			this.textoBombas,
			this.tituloNivel,
			this.nivel,
			this.textoPrincipal,
			this.xEstado,
			this.xNec,
			this.xLigadas,
			this.xPrincipal,
			this.xSegunda,
			this.xRh,
			this.xRm,
			this.xRs,
			this.xRecalque,
			this.xBoiaH,
			this.xBoiaL,
			this.xFalhaBoia,
			this.xNivelBaixo,
			this.xBuffer,
			this.xERecalque,
			this.xENivelAlto,
			this.xEFalhaBoia,
			this.abrir});

		}
		private NxtControl.GuiFramework.Rectangle fundo;
		private NxtControl.GuiFramework.AliasDisplayLabel InstanceName;
		private NxtControl.GuiFramework.Rectangle alP1;
		private NxtControl.GuiFramework.FreeText alP1n;
		private NxtControl.GuiFramework.Polygon alP2;
		private NxtControl.GuiFramework.FreeText alP2n;
		private NxtControl.GuiFramework.FreeText alTxt;
		private NxtControl.GuiFramework.FreeText textoEstado;
		private NxtControl.GuiFramework.FreeText textoBombas;
		private NxtControl.GuiFramework.FreeText tituloNivel;
		private System.HMI.Symbols.Base.Label<System.Single> nivel;
		private NxtControl.GuiFramework.FreeText textoPrincipal;
		private System.HMI.Symbols.Base.Execute<short> xEstado;
		private System.HMI.Symbols.Base.Execute<ushort> xNec;
		private System.HMI.Symbols.Base.Execute<ushort> xLigadas;
		private System.HMI.Symbols.Base.Execute<ushort> xPrincipal;
		private System.HMI.Symbols.Base.Execute<ushort> xSegunda;
		private System.HMI.Symbols.Base.Execute<ushort> xRh;
		private System.HMI.Symbols.Base.Execute<ushort> xRm;
		private System.HMI.Symbols.Base.Execute<ushort> xRs;
		private System.HMI.Symbols.Base.Execute<bool> xRecalque;
		private System.HMI.Symbols.Base.Execute<bool> xBoiaH;
		private System.HMI.Symbols.Base.Execute<bool> xBoiaL;
		private System.HMI.Symbols.Base.Execute<bool> xFalhaBoia;
		private System.HMI.Symbols.Base.Execute<bool> xNivelBaixo;
		private System.HMI.Symbols.Base.Execute<bool> xBuffer;
		private System.HMI.Symbols.Base.Execute<byte> xERecalque;
		private System.HMI.Symbols.Base.Execute<byte> xENivelAlto;
		private System.HMI.Symbols.Base.Execute<byte> xEFalhaBoia;
		private NxtControl.GuiFramework.DrawnButton abrir;
		#endregion
	}
}
