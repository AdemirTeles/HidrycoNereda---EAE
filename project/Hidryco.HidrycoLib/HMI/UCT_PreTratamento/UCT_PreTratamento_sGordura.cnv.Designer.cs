/*
 * Hidryco - UCT_PreTratamento - sGordura
 * Tanque de gordura da UCT com a valvula de lavagem (cores HidrycoColors), nivel alto e etapa da bomba de gordura.
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Symbols.UCT_PreTratamento
{
	/// <summary>
	/// Summary description for sGordura.
	/// </summary>
	partial class sGordura
	{

		#region Component Designer generated code
		private void InitializeComponent()
		{
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary1 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary2 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary3 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary4 = new NxtControl.GuiFramework.PropertyDictionary();
			this.tbEntrada = new NxtControl.GuiFramework.Pipe();
			this.tbAgua = new NxtControl.GuiFramework.Pipe();
			this.tbSuccao = new NxtControl.GuiFramework.Pipe();
			this.tanque = new NxtControl.GuiFramework.Rectangle();
			this.rTanque = new NxtControl.GuiFramework.FreeText();
			this.vNivel = new System.HMI.Symbols.Base.FreeText<bool>();
			this.vRest = new System.HMI.Symbols.Base.Label<System.Int16>();
			this.vl1 = new NxtControl.GuiFramework.Polygon();
			this.vl2 = new NxtControl.GuiFramework.Polygon();
			this.vlHaste = new NxtControl.GuiFramework.Line();
			this.vlAtuador = new NxtControl.GuiFramework.Rectangle();
			this.textoValv = new NxtControl.GuiFramework.FreeText();
			this.rAgua = new NxtControl.GuiFramework.FreeText();
			this.textoEtapa = new NxtControl.GuiFramework.FreeText();
			this.x_aCOM = new System.HMI.Symbols.Base.Execute<bool>();
			this.x_aEMERGENCIA = new System.HMI.Symbols.Base.Execute<bool>();
			this.x_aDEFPEN = new System.HMI.Symbols.Base.Execute<bool>();
			this.x_aDEFB1 = new System.HMI.Symbols.Base.Execute<bool>();
			this.x_aDEFB2 = new System.HMI.Symbols.Base.Execute<bool>();
			this.x_aDEFCMP = new System.HMI.Symbols.Base.Execute<bool>();
			this.x_aDEFRSP = new System.HMI.Symbols.Base.Execute<bool>();
			this.x_aDEFR1 = new System.HMI.Symbols.Base.Execute<bool>();
			this.x_aDEFR2 = new System.HMI.Symbols.Base.Execute<bool>();
			this.x_aNIVELAGUA = new System.HMI.Symbols.Base.Execute<bool>();
			this.x_aNIVELPENEIRA = new System.HMI.Symbols.Base.Execute<bool>();
			this.x_eCOM = new System.HMI.Symbols.Base.Execute<byte>();
			this.x_eEMERGENCIA = new System.HMI.Symbols.Base.Execute<byte>();
			this.x_eDEFPEN = new System.HMI.Symbols.Base.Execute<byte>();
			this.x_eDEFB1 = new System.HMI.Symbols.Base.Execute<byte>();
			this.x_eDEFB2 = new System.HMI.Symbols.Base.Execute<byte>();
			this.x_eDEFCMP = new System.HMI.Symbols.Base.Execute<byte>();
			this.x_eDEFRSP = new System.HMI.Symbols.Base.Execute<byte>();
			this.x_eDEFR1 = new System.HMI.Symbols.Base.Execute<byte>();
			this.x_eDEFR2 = new System.HMI.Symbols.Base.Execute<byte>();
			this.x_eNIVELAGUA = new System.HMI.Symbols.Base.Execute<byte>();
			this.x_eNIVELPENEIRA = new System.HMI.Symbols.Base.Execute<byte>();
			this.x_disp = new System.HMI.Symbols.Base.Execute<bool>();
			this.x_hab = new System.HMI.Symbols.Base.Execute<bool>();
			this.x_bloq = new System.HMI.Symbols.Base.Execute<bool>();
			this.x_autoPen = new System.HMI.Symbols.Base.Execute<bool>();
			this.x_autoRos = new System.HMI.Symbols.Base.Execute<bool>();
			this.x_autoRc = new System.HMI.Symbols.Base.Execute<bool>();
			this.x_ligPen = new System.HMI.Symbols.Base.Execute<bool>();
			this.x_ligRos = new System.HMI.Symbols.Base.Execute<bool>();
			this.x_ligRc = new System.HMI.Symbols.Base.Execute<bool>();
			this.x_selB2 = new System.HMI.Symbols.Base.Execute<bool>();
			this.x_valv = new System.HMI.Symbols.Base.Execute<bool>();
			this.x_etapa = new System.HMI.Symbols.Base.Execute<short>();
			this.x_nAltoG = new System.HMI.Symbols.Base.Execute<bool>();
			this.abrir = new NxtControl.GuiFramework.DrawnButton();
			// 
			// tbEntrada
			// 
			this.tbEntrada.Bounds = new NxtControl.Drawing.RectF(((float)(50D)), ((float)(0D)), ((float)(0D)), ((float)(44D)));
			this.tbEntrada.InnerColor = new NxtControl.Drawing.Color(((byte)(176)), ((byte)(184)), ((byte)(192)));
			this.tbEntrada.Name = "tbEntrada";
			this.tbEntrada.OuterColor = new NxtControl.Drawing.Color(((byte)(84)), ((byte)(88)), ((byte)(92)));
			this.tbEntrada.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(50D, 0D),
			new NxtControl.Drawing.PointF(50D, 44D)});
			this.tbEntrada.Width = 6;
			// 
			// tbAgua
			// 
			this.tbAgua.Bounds = new NxtControl.Drawing.RectF(((float)(110D)), ((float)(20D)), ((float)(190D)), ((float)(24D)));
			this.tbAgua.InnerColor = new NxtControl.Drawing.Color(((byte)(176)), ((byte)(184)), ((byte)(192)));
			this.tbAgua.Name = "tbAgua";
			this.tbAgua.OuterColor = new NxtControl.Drawing.Color(((byte)(84)), ((byte)(88)), ((byte)(92)));
			this.tbAgua.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(300D, 20D),
			new NxtControl.Drawing.PointF(110D, 20D),
			new NxtControl.Drawing.PointF(110D, 44D)});
			this.tbAgua.Width = 4;
			// 
			// tbSuccao
			// 
			this.tbSuccao.Bounds = new NxtControl.Drawing.RectF(((float)(140D)), ((float)(120D)), ((float)(20D)), ((float)(0D)));
			this.tbSuccao.InnerColor = new NxtControl.Drawing.Color(((byte)(176)), ((byte)(184)), ((byte)(192)));
			this.tbSuccao.Name = "tbSuccao";
			this.tbSuccao.OuterColor = new NxtControl.Drawing.Color(((byte)(84)), ((byte)(88)), ((byte)(92)));
			this.tbSuccao.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(140D, 120D),
			new NxtControl.Drawing.PointF(160D, 120D)});
			this.tbSuccao.Width = 6;
			// 
			// tanque
			// 
			this.tanque.Bounds = new NxtControl.Drawing.RectF(((float)(20D)), ((float)(44D)), ((float)(120D)), ((float)(96D)));
			this.tanque.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(226)), ((byte)(228)), ((byte)(230))));
			this.tanque.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.tanque.Name = "tanque";
			this.tanque.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// rTanque
			// 
			this.rTanque.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.rTanque.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.rTanque.Location = new NxtControl.Drawing.PointF(26D, 50D);
			this.rTanque.Name = "rTanque";
			this.rTanque.Text = "Tanque de gordura";
			// 
			// vNivel
			// 
			this.vNivel.BeginInit();
			this.vNivel.DecimalPlacesCount = ((uint)(2u));
			this.vNivel.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 26D, 70D);
			this.vNivel.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.vNivel.IsOnlyInput = true;
			this.vNivel.Name = "vNivel";
			propertyDictionary2.Add("Text", "");
			propertyDictionary2.Add("TextColor", new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110))));
			propertyDictionary3.Add("Text", "NÍVEL ALTO");
			propertyDictionary3.Add("TextColor", new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			this.vNivel.Ranges.Clear();
			this.vNivel.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(false, propertyDictionary2));
			this.vNivel.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(true, propertyDictionary3));
			propertyDictionary1.Add("Text", "-");
			propertyDictionary1.Add("TextColor", new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110))));
			this.vNivel.Ranges.DefaultPropertyValues = propertyDictionary1;
			this.vNivel.TagName = "STS_NIVEL_ALTO_TANQUE_GORDURA";
			this.vNivel.TextAngle = 0F;
			this.vNivel.EndInit();
			// 
			// vRest
			// 
			this.vRest.BeginInit();
			this.vRest.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.vRest.DecimalPlacesCount = ((uint)(0u));
			this.vRest.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.4D, 0D, 0D, 1D, 26D, 110D);
			this.vRest.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.vRest.FontScale = false;
			this.vRest.IsOnlyInput = true;
			this.vRest.IsPrefixSuffixOutside = false;
			this.vRest.LeadingZeros = ((uint)(0u));
			this.vRest.Name = "vRest";
			this.vRest.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			propertyDictionary4.Add("Text", "${Value}");
			propertyDictionary4.Add("TextColor", new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			propertyDictionary4.Add("Brush", new NxtControl.Drawing.Brush(true));
			propertyDictionary4.Add("Pen", new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid));
			this.vRest.Ranges.DefaultPropertyValues = propertyDictionary4;
			this.vRest.Suffix = " s";
			this.vRest.TagName = "STS_TEMPO_RESTANTE";
			this.vRest.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.vRest.EndInit();
			// 
			// vl1
			// 
			this.vl1.Bounds = new NxtControl.Drawing.RectF(((float)(160D)), ((float)(10D)), ((float)(10D)), ((float)(20D)));
			this.vl1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(205)), ((byte)(207)), ((byte)(210))));
			this.vl1.Closed = true;
			this.vl1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.vl1.Name = "vl1";
			this.vl1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.vl1.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(160D, 10D),
			new NxtControl.Drawing.PointF(160D, 30D),
			new NxtControl.Drawing.PointF(170D, 20D)});
			// 
			// vl2
			// 
			this.vl2.Bounds = new NxtControl.Drawing.RectF(((float)(170D)), ((float)(10D)), ((float)(10D)), ((float)(20D)));
			this.vl2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(205)), ((byte)(207)), ((byte)(210))));
			this.vl2.Closed = true;
			this.vl2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.vl2.Name = "vl2";
			this.vl2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.vl2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(180D, 10D),
			new NxtControl.Drawing.PointF(180D, 30D),
			new NxtControl.Drawing.PointF(170D, 20D)});
			// 
			// vlHaste
			// 
			this.vlHaste.EndPoint = new NxtControl.Drawing.PointF(170D, 7D);
			this.vlHaste.Name = "vlHaste";
			this.vlHaste.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60))), 1.5F, NxtControl.Drawing.DashStyle.Solid);
			this.vlHaste.StartPoint = new NxtControl.Drawing.PointF(170D, 20D);
			// 
			// vlAtuador
			// 
			this.vlAtuador.Bounds = new NxtControl.Drawing.RectF(((float)(161D)), ((float)(0D)), ((float)(18D)), ((float)(7D)));
			this.vlAtuador.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(205)), ((byte)(207)), ((byte)(210))));
			this.vlAtuador.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.vlAtuador.Name = "vlAtuador";
			this.vlAtuador.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// textoValv
			// 
			this.textoValv.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.textoValv.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.textoValv.Location = new NxtControl.Drawing.PointF(156D, 32D);
			this.textoValv.Name = "textoValv";
			this.textoValv.Text = "fechada";
			// 
			// rAgua
			// 
			this.rAgua.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.rAgua.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.rAgua.Location = new NxtControl.Drawing.PointF(206D, 28D);
			this.rAgua.Name = "rAgua";
			this.rAgua.Text = "Água de lavagem";
			// 
			// textoEtapa
			// 
			this.textoEtapa.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.textoEtapa.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.textoEtapa.Location = new NxtControl.Drawing.PointF(20D, 148D);
			this.textoEtapa.Name = "textoEtapa";
			this.textoEtapa.Text = "parada";
			// 
			// x_aCOM
			// 
			this.x_aCOM.BeginInit();
			this.x_aCOM.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.x_aCOM.IsOnlyInput = true;
			this.x_aCOM.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.x_aCOM.Name = "x_aCOM";
			this.x_aCOM.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.x_aCOM.TagName = "STS_ALARME_COM";
			this.x_aCOM.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.V_aCOMChanged);
			this.x_aCOM.EndInit();
			// 
			// x_aEMERGENCIA
			// 
			this.x_aEMERGENCIA.BeginInit();
			this.x_aEMERGENCIA.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.x_aEMERGENCIA.IsOnlyInput = true;
			this.x_aEMERGENCIA.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.x_aEMERGENCIA.Name = "x_aEMERGENCIA";
			this.x_aEMERGENCIA.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.x_aEMERGENCIA.TagName = "STS_ALARME_EMERGENCIA";
			this.x_aEMERGENCIA.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.V_aEMERGENCIAChanged);
			this.x_aEMERGENCIA.EndInit();
			// 
			// x_aDEFPEN
			// 
			this.x_aDEFPEN.BeginInit();
			this.x_aDEFPEN.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.x_aDEFPEN.IsOnlyInput = true;
			this.x_aDEFPEN.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.x_aDEFPEN.Name = "x_aDEFPEN";
			this.x_aDEFPEN.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.x_aDEFPEN.TagName = "STS_ALARME_DEFPEN";
			this.x_aDEFPEN.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.V_aDEFPENChanged);
			this.x_aDEFPEN.EndInit();
			// 
			// x_aDEFB1
			// 
			this.x_aDEFB1.BeginInit();
			this.x_aDEFB1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.x_aDEFB1.IsOnlyInput = true;
			this.x_aDEFB1.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.x_aDEFB1.Name = "x_aDEFB1";
			this.x_aDEFB1.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.x_aDEFB1.TagName = "STS_ALARME_DEFB1";
			this.x_aDEFB1.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.V_aDEFB1Changed);
			this.x_aDEFB1.EndInit();
			// 
			// x_aDEFB2
			// 
			this.x_aDEFB2.BeginInit();
			this.x_aDEFB2.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.x_aDEFB2.IsOnlyInput = true;
			this.x_aDEFB2.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.x_aDEFB2.Name = "x_aDEFB2";
			this.x_aDEFB2.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.x_aDEFB2.TagName = "STS_ALARME_DEFB2";
			this.x_aDEFB2.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.V_aDEFB2Changed);
			this.x_aDEFB2.EndInit();
			// 
			// x_aDEFCMP
			// 
			this.x_aDEFCMP.BeginInit();
			this.x_aDEFCMP.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.x_aDEFCMP.IsOnlyInput = true;
			this.x_aDEFCMP.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.x_aDEFCMP.Name = "x_aDEFCMP";
			this.x_aDEFCMP.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.x_aDEFCMP.TagName = "STS_ALARME_DEFCMP";
			this.x_aDEFCMP.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.V_aDEFCMPChanged);
			this.x_aDEFCMP.EndInit();
			// 
			// x_aDEFRSP
			// 
			this.x_aDEFRSP.BeginInit();
			this.x_aDEFRSP.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.x_aDEFRSP.IsOnlyInput = true;
			this.x_aDEFRSP.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.x_aDEFRSP.Name = "x_aDEFRSP";
			this.x_aDEFRSP.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.x_aDEFRSP.TagName = "STS_ALARME_DEFRSP";
			this.x_aDEFRSP.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.V_aDEFRSPChanged);
			this.x_aDEFRSP.EndInit();
			// 
			// x_aDEFR1
			// 
			this.x_aDEFR1.BeginInit();
			this.x_aDEFR1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.x_aDEFR1.IsOnlyInput = true;
			this.x_aDEFR1.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.x_aDEFR1.Name = "x_aDEFR1";
			this.x_aDEFR1.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.x_aDEFR1.TagName = "STS_ALARME_DEFR1";
			this.x_aDEFR1.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.V_aDEFR1Changed);
			this.x_aDEFR1.EndInit();
			// 
			// x_aDEFR2
			// 
			this.x_aDEFR2.BeginInit();
			this.x_aDEFR2.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.x_aDEFR2.IsOnlyInput = true;
			this.x_aDEFR2.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.x_aDEFR2.Name = "x_aDEFR2";
			this.x_aDEFR2.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.x_aDEFR2.TagName = "STS_ALARME_DEFR2";
			this.x_aDEFR2.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.V_aDEFR2Changed);
			this.x_aDEFR2.EndInit();
			// 
			// x_aNIVELAGUA
			// 
			this.x_aNIVELAGUA.BeginInit();
			this.x_aNIVELAGUA.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.x_aNIVELAGUA.IsOnlyInput = true;
			this.x_aNIVELAGUA.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.x_aNIVELAGUA.Name = "x_aNIVELAGUA";
			this.x_aNIVELAGUA.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.x_aNIVELAGUA.TagName = "STS_ALARME_NIVELAGUA";
			this.x_aNIVELAGUA.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.V_aNIVELAGUAChanged);
			this.x_aNIVELAGUA.EndInit();
			// 
			// x_aNIVELPENEIRA
			// 
			this.x_aNIVELPENEIRA.BeginInit();
			this.x_aNIVELPENEIRA.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.x_aNIVELPENEIRA.IsOnlyInput = true;
			this.x_aNIVELPENEIRA.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.x_aNIVELPENEIRA.Name = "x_aNIVELPENEIRA";
			this.x_aNIVELPENEIRA.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.x_aNIVELPENEIRA.TagName = "STS_ALARME_NIVELPENEIRA";
			this.x_aNIVELPENEIRA.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.V_aNIVELPENEIRAChanged);
			this.x_aNIVELPENEIRA.EndInit();
			// 
			// x_eCOM
			// 
			this.x_eCOM.BeginInit();
			this.x_eCOM.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.x_eCOM.IsOnlyInput = true;
			this.x_eCOM.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.x_eCOM.Name = "x_eCOM";
			this.x_eCOM.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.x_eCOM.TagName = "STS_ALM_COM_EST";
			this.x_eCOM.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.V_eCOMChanged);
			this.x_eCOM.EndInit();
			// 
			// x_eEMERGENCIA
			// 
			this.x_eEMERGENCIA.BeginInit();
			this.x_eEMERGENCIA.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.x_eEMERGENCIA.IsOnlyInput = true;
			this.x_eEMERGENCIA.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.x_eEMERGENCIA.Name = "x_eEMERGENCIA";
			this.x_eEMERGENCIA.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.x_eEMERGENCIA.TagName = "STS_ALM_EMERGENCIA_EST";
			this.x_eEMERGENCIA.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.V_eEMERGENCIAChanged);
			this.x_eEMERGENCIA.EndInit();
			// 
			// x_eDEFPEN
			// 
			this.x_eDEFPEN.BeginInit();
			this.x_eDEFPEN.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.x_eDEFPEN.IsOnlyInput = true;
			this.x_eDEFPEN.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.x_eDEFPEN.Name = "x_eDEFPEN";
			this.x_eDEFPEN.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.x_eDEFPEN.TagName = "STS_ALM_DEFPEN_EST";
			this.x_eDEFPEN.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.V_eDEFPENChanged);
			this.x_eDEFPEN.EndInit();
			// 
			// x_eDEFB1
			// 
			this.x_eDEFB1.BeginInit();
			this.x_eDEFB1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.x_eDEFB1.IsOnlyInput = true;
			this.x_eDEFB1.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.x_eDEFB1.Name = "x_eDEFB1";
			this.x_eDEFB1.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.x_eDEFB1.TagName = "STS_ALM_DEFB1_EST";
			this.x_eDEFB1.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.V_eDEFB1Changed);
			this.x_eDEFB1.EndInit();
			// 
			// x_eDEFB2
			// 
			this.x_eDEFB2.BeginInit();
			this.x_eDEFB2.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.x_eDEFB2.IsOnlyInput = true;
			this.x_eDEFB2.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.x_eDEFB2.Name = "x_eDEFB2";
			this.x_eDEFB2.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.x_eDEFB2.TagName = "STS_ALM_DEFB2_EST";
			this.x_eDEFB2.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.V_eDEFB2Changed);
			this.x_eDEFB2.EndInit();
			// 
			// x_eDEFCMP
			// 
			this.x_eDEFCMP.BeginInit();
			this.x_eDEFCMP.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.x_eDEFCMP.IsOnlyInput = true;
			this.x_eDEFCMP.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.x_eDEFCMP.Name = "x_eDEFCMP";
			this.x_eDEFCMP.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.x_eDEFCMP.TagName = "STS_ALM_DEFCMP_EST";
			this.x_eDEFCMP.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.V_eDEFCMPChanged);
			this.x_eDEFCMP.EndInit();
			// 
			// x_eDEFRSP
			// 
			this.x_eDEFRSP.BeginInit();
			this.x_eDEFRSP.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.x_eDEFRSP.IsOnlyInput = true;
			this.x_eDEFRSP.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.x_eDEFRSP.Name = "x_eDEFRSP";
			this.x_eDEFRSP.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.x_eDEFRSP.TagName = "STS_ALM_DEFRSP_EST";
			this.x_eDEFRSP.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.V_eDEFRSPChanged);
			this.x_eDEFRSP.EndInit();
			// 
			// x_eDEFR1
			// 
			this.x_eDEFR1.BeginInit();
			this.x_eDEFR1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.x_eDEFR1.IsOnlyInput = true;
			this.x_eDEFR1.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.x_eDEFR1.Name = "x_eDEFR1";
			this.x_eDEFR1.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.x_eDEFR1.TagName = "STS_ALM_DEFR1_EST";
			this.x_eDEFR1.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.V_eDEFR1Changed);
			this.x_eDEFR1.EndInit();
			// 
			// x_eDEFR2
			// 
			this.x_eDEFR2.BeginInit();
			this.x_eDEFR2.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.x_eDEFR2.IsOnlyInput = true;
			this.x_eDEFR2.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.x_eDEFR2.Name = "x_eDEFR2";
			this.x_eDEFR2.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.x_eDEFR2.TagName = "STS_ALM_DEFR2_EST";
			this.x_eDEFR2.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.V_eDEFR2Changed);
			this.x_eDEFR2.EndInit();
			// 
			// x_eNIVELAGUA
			// 
			this.x_eNIVELAGUA.BeginInit();
			this.x_eNIVELAGUA.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.x_eNIVELAGUA.IsOnlyInput = true;
			this.x_eNIVELAGUA.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.x_eNIVELAGUA.Name = "x_eNIVELAGUA";
			this.x_eNIVELAGUA.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.x_eNIVELAGUA.TagName = "STS_ALM_NIVELAGUA_EST";
			this.x_eNIVELAGUA.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.V_eNIVELAGUAChanged);
			this.x_eNIVELAGUA.EndInit();
			// 
			// x_eNIVELPENEIRA
			// 
			this.x_eNIVELPENEIRA.BeginInit();
			this.x_eNIVELPENEIRA.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.x_eNIVELPENEIRA.IsOnlyInput = true;
			this.x_eNIVELPENEIRA.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.x_eNIVELPENEIRA.Name = "x_eNIVELPENEIRA";
			this.x_eNIVELPENEIRA.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.x_eNIVELPENEIRA.TagName = "STS_ALM_NIVELPENEIRA_EST";
			this.x_eNIVELPENEIRA.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.V_eNIVELPENEIRAChanged);
			this.x_eNIVELPENEIRA.EndInit();
			// 
			// x_disp
			// 
			this.x_disp.BeginInit();
			this.x_disp.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.x_disp.IsOnlyInput = true;
			this.x_disp.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.x_disp.Name = "x_disp";
			this.x_disp.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.x_disp.TagName = "STS_DISPONIVEL";
			this.x_disp.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.V_dispChanged);
			this.x_disp.EndInit();
			// 
			// x_hab
			// 
			this.x_hab.BeginInit();
			this.x_hab.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.x_hab.IsOnlyInput = true;
			this.x_hab.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.x_hab.Name = "x_hab";
			this.x_hab.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.x_hab.TagName = "STS_HABILITADA";
			this.x_hab.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.V_habChanged);
			this.x_hab.EndInit();
			// 
			// x_bloq
			// 
			this.x_bloq.BeginInit();
			this.x_bloq.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.x_bloq.IsOnlyInput = true;
			this.x_bloq.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.x_bloq.Name = "x_bloq";
			this.x_bloq.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.x_bloq.TagName = "STS_BLOQUEIO_EEE";
			this.x_bloq.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.V_bloqChanged);
			this.x_bloq.EndInit();
			// 
			// x_autoPen
			// 
			this.x_autoPen.BeginInit();
			this.x_autoPen.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.x_autoPen.IsOnlyInput = true;
			this.x_autoPen.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.x_autoPen.Name = "x_autoPen";
			this.x_autoPen.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.x_autoPen.TagName = "STS_AUTOMATICO_PENEIRA";
			this.x_autoPen.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.V_autoPenChanged);
			this.x_autoPen.EndInit();
			// 
			// x_autoRos
			// 
			this.x_autoRos.BeginInit();
			this.x_autoRos.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.x_autoRos.IsOnlyInput = true;
			this.x_autoRos.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.x_autoRos.Name = "x_autoRos";
			this.x_autoRos.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.x_autoRos.TagName = "STS_AUTOMATICO_ROSCAS";
			this.x_autoRos.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.V_autoRosChanged);
			this.x_autoRos.EndInit();
			// 
			// x_autoRc
			// 
			this.x_autoRc.BeginInit();
			this.x_autoRc.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.x_autoRc.IsOnlyInput = true;
			this.x_autoRc.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.x_autoRc.Name = "x_autoRc";
			this.x_autoRc.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.x_autoRc.TagName = "STS_AUTOMATICO_RASPCOMP";
			this.x_autoRc.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.V_autoRcChanged);
			this.x_autoRc.EndInit();
			// 
			// x_ligPen
			// 
			this.x_ligPen.BeginInit();
			this.x_ligPen.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.x_ligPen.IsOnlyInput = true;
			this.x_ligPen.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.x_ligPen.Name = "x_ligPen";
			this.x_ligPen.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.x_ligPen.TagName = "STS_LIGA_AUTOMATICO_PENEIRA";
			this.x_ligPen.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.V_ligPenChanged);
			this.x_ligPen.EndInit();
			// 
			// x_ligRos
			// 
			this.x_ligRos.BeginInit();
			this.x_ligRos.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.x_ligRos.IsOnlyInput = true;
			this.x_ligRos.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.x_ligRos.Name = "x_ligRos";
			this.x_ligRos.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.x_ligRos.TagName = "STS_LIGA_AUTOMATICO_ROSCAS";
			this.x_ligRos.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.V_ligRosChanged);
			this.x_ligRos.EndInit();
			// 
			// x_ligRc
			// 
			this.x_ligRc.BeginInit();
			this.x_ligRc.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.x_ligRc.IsOnlyInput = true;
			this.x_ligRc.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.x_ligRc.Name = "x_ligRc";
			this.x_ligRc.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.x_ligRc.TagName = "STS_LIGA_AUTOMATICO_RASPCOMP";
			this.x_ligRc.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.V_ligRcChanged);
			this.x_ligRc.EndInit();
			// 
			// x_selB2
			// 
			this.x_selB2.BeginInit();
			this.x_selB2.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.x_selB2.IsOnlyInput = true;
			this.x_selB2.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.x_selB2.Name = "x_selB2";
			this.x_selB2.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.x_selB2.TagName = "STS_SELECAO_BOMBA";
			this.x_selB2.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.V_selB2Changed);
			this.x_selB2.EndInit();
			// 
			// x_valv
			// 
			this.x_valv.BeginInit();
			this.x_valv.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.x_valv.IsOnlyInput = true;
			this.x_valv.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.x_valv.Name = "x_valv";
			this.x_valv.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.x_valv.TagName = "STS_VALVULA_LAVAGEM";
			this.x_valv.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.V_valvChanged);
			this.x_valv.EndInit();
			// 
			// x_etapa
			// 
			this.x_etapa.BeginInit();
			this.x_etapa.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.x_etapa.IsOnlyInput = true;
			this.x_etapa.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.x_etapa.Name = "x_etapa";
			this.x_etapa.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.x_etapa.TagName = "STS_ETAPA_GORDURA";
			this.x_etapa.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.V_etapaChanged);
			this.x_etapa.EndInit();
			// 
			// x_nAltoG
			// 
			this.x_nAltoG.BeginInit();
			this.x_nAltoG.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.x_nAltoG.IsOnlyInput = true;
			this.x_nAltoG.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.x_nAltoG.Name = "x_nAltoG";
			this.x_nAltoG.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.x_nAltoG.TagName = "STS_NIVEL_ALTO_TANQUE_GORDURA";
			this.x_nAltoG.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.V_nAltoGChanged);
			this.x_nAltoG.EndInit();
			// 
			// abrir
			// 
			this.abrir.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(300D)), ((float)(172D)));
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
			// sGordura
			// 
			this.Name = "sGordura";
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.tbEntrada,
			this.tbAgua,
			this.tbSuccao,
			this.tanque,
			this.rTanque,
			this.vNivel,
			this.vRest,
			this.vl1,
			this.vl2,
			this.vlHaste,
			this.vlAtuador,
			this.textoValv,
			this.rAgua,
			this.textoEtapa,
			this.x_aCOM,
			this.x_aEMERGENCIA,
			this.x_aDEFPEN,
			this.x_aDEFB1,
			this.x_aDEFB2,
			this.x_aDEFCMP,
			this.x_aDEFRSP,
			this.x_aDEFR1,
			this.x_aDEFR2,
			this.x_aNIVELAGUA,
			this.x_aNIVELPENEIRA,
			this.x_eCOM,
			this.x_eEMERGENCIA,
			this.x_eDEFPEN,
			this.x_eDEFB1,
			this.x_eDEFB2,
			this.x_eDEFCMP,
			this.x_eDEFRSP,
			this.x_eDEFR1,
			this.x_eDEFR2,
			this.x_eNIVELAGUA,
			this.x_eNIVELPENEIRA,
			this.x_disp,
			this.x_hab,
			this.x_bloq,
			this.x_autoPen,
			this.x_autoRos,
			this.x_autoRc,
			this.x_ligPen,
			this.x_ligRos,
			this.x_ligRc,
			this.x_selB2,
			this.x_valv,
			this.x_etapa,
			this.x_nAltoG,
			this.abrir});
			this.SymbolSize = new System.Drawing.Size(300, 172);

		}
		private NxtControl.GuiFramework.Pipe tbEntrada;
		private NxtControl.GuiFramework.Pipe tbAgua;
		private NxtControl.GuiFramework.Pipe tbSuccao;
		private NxtControl.GuiFramework.Rectangle tanque;
		private NxtControl.GuiFramework.FreeText rTanque;
		private System.HMI.Symbols.Base.FreeText<bool> vNivel;
		private System.HMI.Symbols.Base.Label<System.Int16> vRest;
		private NxtControl.GuiFramework.Polygon vl1;
		private NxtControl.GuiFramework.Polygon vl2;
		private NxtControl.GuiFramework.Line vlHaste;
		private NxtControl.GuiFramework.Rectangle vlAtuador;
		private NxtControl.GuiFramework.FreeText textoValv;
		private NxtControl.GuiFramework.FreeText rAgua;
		private NxtControl.GuiFramework.FreeText textoEtapa;
		private System.HMI.Symbols.Base.Execute<bool> x_aCOM;
		private System.HMI.Symbols.Base.Execute<bool> x_aEMERGENCIA;
		private System.HMI.Symbols.Base.Execute<bool> x_aDEFPEN;
		private System.HMI.Symbols.Base.Execute<bool> x_aDEFB1;
		private System.HMI.Symbols.Base.Execute<bool> x_aDEFB2;
		private System.HMI.Symbols.Base.Execute<bool> x_aDEFCMP;
		private System.HMI.Symbols.Base.Execute<bool> x_aDEFRSP;
		private System.HMI.Symbols.Base.Execute<bool> x_aDEFR1;
		private System.HMI.Symbols.Base.Execute<bool> x_aDEFR2;
		private System.HMI.Symbols.Base.Execute<bool> x_aNIVELAGUA;
		private System.HMI.Symbols.Base.Execute<bool> x_aNIVELPENEIRA;
		private System.HMI.Symbols.Base.Execute<byte> x_eCOM;
		private System.HMI.Symbols.Base.Execute<byte> x_eEMERGENCIA;
		private System.HMI.Symbols.Base.Execute<byte> x_eDEFPEN;
		private System.HMI.Symbols.Base.Execute<byte> x_eDEFB1;
		private System.HMI.Symbols.Base.Execute<byte> x_eDEFB2;
		private System.HMI.Symbols.Base.Execute<byte> x_eDEFCMP;
		private System.HMI.Symbols.Base.Execute<byte> x_eDEFRSP;
		private System.HMI.Symbols.Base.Execute<byte> x_eDEFR1;
		private System.HMI.Symbols.Base.Execute<byte> x_eDEFR2;
		private System.HMI.Symbols.Base.Execute<byte> x_eNIVELAGUA;
		private System.HMI.Symbols.Base.Execute<byte> x_eNIVELPENEIRA;
		private System.HMI.Symbols.Base.Execute<bool> x_disp;
		private System.HMI.Symbols.Base.Execute<bool> x_hab;
		private System.HMI.Symbols.Base.Execute<bool> x_bloq;
		private System.HMI.Symbols.Base.Execute<bool> x_autoPen;
		private System.HMI.Symbols.Base.Execute<bool> x_autoRos;
		private System.HMI.Symbols.Base.Execute<bool> x_autoRc;
		private System.HMI.Symbols.Base.Execute<bool> x_ligPen;
		private System.HMI.Symbols.Base.Execute<bool> x_ligRos;
		private System.HMI.Symbols.Base.Execute<bool> x_ligRc;
		private System.HMI.Symbols.Base.Execute<bool> x_selB2;
		private System.HMI.Symbols.Base.Execute<bool> x_valv;
		private System.HMI.Symbols.Base.Execute<short> x_etapa;
		private System.HMI.Symbols.Base.Execute<bool> x_nAltoG;
		private NxtControl.GuiFramework.DrawnButton abrir;
		#endregion
	}
}
