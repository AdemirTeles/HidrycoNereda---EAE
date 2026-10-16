/*
 * Hidryco - UCT_PreTratamento - sDefault
 * ISA-101: UCT - disponibilidade, modo dos subsistemas, bomba de gordura e indicador de alarme.
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Symbols.UCT_PreTratamento
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
			this.textoModos = new NxtControl.GuiFramework.FreeText();
			this.rotNivel = new NxtControl.GuiFramework.FreeText();
			this.vNivel = new System.HMI.Symbols.Base.Label<System.Single>();
			this.textoGordura = new NxtControl.GuiFramework.FreeText();
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
			// fundo
			// 
			this.fundo.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(250D)), ((float)(96D)));
			this.fundo.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(232)), ((byte)(232)), ((byte)(232))));
			this.fundo.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.fundo.Name = "fundo";
			this.fundo.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// InstanceName
			// 
			this.InstanceName.AngleIgnore = true;
			this.InstanceName.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.InstanceName.Bounds = new NxtControl.Drawing.RectF(((float)(6D)), ((float)(2D)), ((float)(130D)), ((float)(18D)));
			this.InstanceName.Brush = new NxtControl.Drawing.Brush(true);
			this.InstanceName.CustomInstanceName = null;
			this.InstanceName.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.InstanceName.FontScale = false;
			this.InstanceName.Name = "InstanceName";
			this.InstanceName.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.InstanceName.Text = "Label";
			this.InstanceName.TextColor = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			// 
			// alP1
			// 
			this.alP1.Bounds = new NxtControl.Drawing.RectF(((float)(160D)), ((float)(4D)), ((float)(16D)), ((float)(16D)));
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
			this.alP1n.Location = new NxtControl.Drawing.PointF(164D, 5D);
			this.alP1n.Name = "alP1n";
			this.alP1n.Text = "1";
			this.alP1n.Visible = false;
			// 
			// alP2
			// 
			this.alP2.Bounds = new NxtControl.Drawing.RectF(((float)(160D)), ((float)(4D)), ((float)(16D)), ((float)(16D)));
			this.alP2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(205)), ((byte)(0))));
			this.alP2.Closed = true;
			this.alP2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.alP2.Name = "alP2";
			this.alP2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.alP2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(160D, 20D),
			new NxtControl.Drawing.PointF(168D, 4D),
			new NxtControl.Drawing.PointF(176D, 20D)});
			this.alP2.Visible = false;
			// 
			// alP2n
			// 
			this.alP2n.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.alP2n.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
			this.alP2n.Location = new NxtControl.Drawing.PointF(165D, 8D);
			this.alP2n.Name = "alP2n";
			this.alP2n.Text = "2";
			this.alP2n.Visible = false;
			// 
			// alTxt
			// 
			this.alTxt.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.alTxt.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.alTxt.Location = new NxtControl.Drawing.PointF(180D, 4D);
			this.alTxt.Name = "alTxt";
			this.alTxt.Text = "";
			this.alTxt.Visible = false;
			// 
			// textoEstado
			// 
			this.textoEstado.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.textoEstado.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.textoEstado.Location = new NxtControl.Drawing.PointF(8D, 24D);
			this.textoEstado.Name = "textoEstado";
			this.textoEstado.Text = "DISPONÍVEL";
			// 
			// textoModos
			// 
			this.textoModos.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.textoModos.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.textoModos.Location = new NxtControl.Drawing.PointF(8D, 44D);
			this.textoModos.Name = "textoModos";
			this.textoModos.Text = "Peneira A · Roscas A · Rasp./comp. A";
			// 
			// rotNivel
			// 
			this.rotNivel.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.rotNivel.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.rotNivel.Location = new NxtControl.Drawing.PointF(8D, 60D);
			this.rotNivel.Name = "rotNivel";
			this.rotNivel.Text = "Nível peneira";
			// 
			// vNivel
			// 
			this.vNivel.BeginInit();
			this.vNivel.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.vNivel.DecimalPlacesCount = ((uint)(0u));
			this.vNivel.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.45D, 0D, 0D, 1D, 86D, 56D);
			this.vNivel.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.vNivel.FontScale = false;
			this.vNivel.IsOnlyInput = true;
			this.vNivel.IsPrefixSuffixOutside = false;
			this.vNivel.LeadingZeros = ((uint)(0u));
			this.vNivel.Name = "vNivel";
			this.vNivel.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			propertyDictionary1.Add("Text", "${Value}");
			propertyDictionary1.Add("TextColor", new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			propertyDictionary1.Add("Brush", new NxtControl.Drawing.Brush(true));
			propertyDictionary1.Add("Pen", new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid));
			this.vNivel.Ranges.DefaultPropertyValues = propertyDictionary1;
			this.vNivel.Suffix = " %";
			this.vNivel.TagName = "STS_NIVEL_PENEIRA";
			this.vNivel.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.vNivel.EndInit();
			// 
			// textoGordura
			// 
			this.textoGordura.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.textoGordura.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.textoGordura.Location = new NxtControl.Drawing.PointF(8D, 76D);
			this.textoGordura.Name = "textoGordura";
			this.textoGordura.Text = "Gordura: parada";
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
			this.abrir.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(250D)), ((float)(96D)));
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
			this.textoModos,
			this.rotNivel,
			this.vNivel,
			this.textoGordura,
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
			this.SymbolSize = new System.Drawing.Size(250, 96);

		}
		private NxtControl.GuiFramework.Rectangle fundo;
		private NxtControl.GuiFramework.AliasDisplayLabel InstanceName;
		private NxtControl.GuiFramework.Rectangle alP1;
		private NxtControl.GuiFramework.FreeText alP1n;
		private NxtControl.GuiFramework.Polygon alP2;
		private NxtControl.GuiFramework.FreeText alP2n;
		private NxtControl.GuiFramework.FreeText alTxt;
		private NxtControl.GuiFramework.FreeText textoEstado;
		private NxtControl.GuiFramework.FreeText textoModos;
		private NxtControl.GuiFramework.FreeText rotNivel;
		private System.HMI.Symbols.Base.Label<System.Single> vNivel;
		private NxtControl.GuiFramework.FreeText textoGordura;
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
