/*
 * Hidryco - Gerador_Generico - sDefault
 * ISA-101: grupo gerador - estado, modo, potencia, frequencia e indicador de alarme.
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Symbols.Gerador_Generico
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
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary2 = new NxtControl.GuiFramework.PropertyDictionary();
			this.fundo = new NxtControl.GuiFramework.Rectangle();
			this.InstanceName = new NxtControl.GuiFramework.AliasDisplayLabel();
			this.alP1 = new NxtControl.GuiFramework.Rectangle();
			this.alP1n = new NxtControl.GuiFramework.FreeText();
			this.alP2 = new NxtControl.GuiFramework.Polygon();
			this.alP2n = new NxtControl.GuiFramework.FreeText();
			this.alTxt = new NxtControl.GuiFramework.FreeText();
			this.textoEstado = new NxtControl.GuiFramework.FreeText();
			this.textoModo = new NxtControl.GuiFramework.FreeText();
			this.rP = new NxtControl.GuiFramework.FreeText();
			this.vP = new System.HMI.Symbols.Base.Label<System.Single>();
			this.rF = new NxtControl.GuiFramework.FreeText();
			this.vF = new System.HMI.Symbols.Base.Label<System.Single>();
			this.textoAlarme = new NxtControl.GuiFramework.FreeText();
			this.xACom = new System.HMI.Symbols.Base.Execute<bool>();
			this.xAAGC = new System.HMI.Symbols.Base.Execute<bool>();
			this.xAPartida = new System.HMI.Symbols.Base.Execute<bool>();
			this.xAMotor = new System.HMI.Symbols.Base.Execute<bool>();
			this.xAEmergencia = new System.HMI.Symbols.Base.Execute<bool>();
			this.xADisjuntor = new System.HMI.Symbols.Base.Execute<bool>();
			this.xAFaltaRede = new System.HMI.Symbols.Base.Execute<bool>();
			this.xAForaAuto = new System.HMI.Symbols.Base.Execute<bool>();
			this.xECom = new System.HMI.Symbols.Base.Execute<byte>();
			this.xEAGC = new System.HMI.Symbols.Base.Execute<byte>();
			this.xEPartida = new System.HMI.Symbols.Base.Execute<byte>();
			this.xEMotor = new System.HMI.Symbols.Base.Execute<byte>();
			this.xEEmergencia = new System.HMI.Symbols.Base.Execute<byte>();
			this.xEDisjuntor = new System.HMI.Symbols.Base.Execute<byte>();
			this.xEFaltaRede = new System.HMI.Symbols.Base.Execute<byte>();
			this.xEForaAuto = new System.HMI.Symbols.Base.Execute<byte>();
			this.xSGB = new System.HMI.Symbols.Base.Execute<short>();
			this.xSMB = new System.HMI.Symbols.Base.Execute<short>();
			this.xSModo = new System.HMI.Symbols.Base.Execute<short>();
			this.xSFonte = new System.HMI.Symbols.Base.Execute<short>();
			this.xOperando = new System.HMI.Symbols.Base.Execute<bool>();
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
			this.textoEstado.Text = "Parado";
			// 
			// textoModo
			// 
			this.textoModo.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.textoModo.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.textoModo.Location = new NxtControl.Drawing.PointF(134D, 24D);
			this.textoModo.Name = "textoModo";
			this.textoModo.Text = "Automático";
			// 
			// rP
			// 
			this.rP.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.rP.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.rP.Location = new NxtControl.Drawing.PointF(8D, 44D);
			this.rP.Name = "rP";
			this.rP.Text = "P";
			// 
			// vP
			// 
			this.vP.BeginInit();
			this.vP.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.vP.DecimalPlacesCount = ((uint)(0u));
			this.vP.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.66D, 0D, 0D, 1D, 22D, 40D);
			this.vP.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.vP.FontScale = false;
			this.vP.IsOnlyInput = true;
			this.vP.IsPrefixSuffixOutside = false;
			this.vP.LeadingZeros = ((uint)(0u));
			this.vP.Name = "vP";
			this.vP.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			propertyDictionary1.Add("Text", "${Value}");
			propertyDictionary1.Add("TextColor", new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			propertyDictionary1.Add("Brush", new NxtControl.Drawing.Brush(true));
			propertyDictionary1.Add("Pen", new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid));
			this.vP.Ranges.DefaultPropertyValues = propertyDictionary1;
			this.vP.Suffix = " kW";
			this.vP.TagName = "POTENCIA_ATIVA";
			this.vP.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.vP.EndInit();
			// 
			// rF
			// 
			this.rF.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.rF.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.rF.Location = new NxtControl.Drawing.PointF(134D, 44D);
			this.rF.Name = "rF";
			this.rF.Text = "f";
			// 
			// vF
			// 
			this.vF.BeginInit();
			this.vF.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.vF.DecimalPlacesCount = ((uint)(1u));
			this.vF.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.58D, 0D, 0D, 1D, 156D, 40D);
			this.vF.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.vF.FontScale = false;
			this.vF.IsOnlyInput = true;
			this.vF.IsPrefixSuffixOutside = false;
			this.vF.LeadingZeros = ((uint)(0u));
			this.vF.Name = "vF";
			this.vF.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			propertyDictionary2.Add("Text", "${Value}");
			propertyDictionary2.Add("TextColor", new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			propertyDictionary2.Add("Brush", new NxtControl.Drawing.Brush(true));
			propertyDictionary2.Add("Pen", new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid));
			this.vF.Ranges.DefaultPropertyValues = propertyDictionary2;
			this.vF.Suffix = " Hz";
			this.vF.TagName = "FREQUENCIA";
			this.vF.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.vF.EndInit();
			// 
			// textoAlarme
			// 
			this.textoAlarme.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.textoAlarme.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.textoAlarme.Location = new NxtControl.Drawing.PointF(8D, 64D);
			this.textoAlarme.Name = "textoAlarme";
			this.textoAlarme.Text = "";
			// 
			// xACom
			// 
			this.xACom.BeginInit();
			this.xACom.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xACom.IsOnlyInput = true;
			this.xACom.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xACom.Name = "xACom";
			this.xACom.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xACom.TagName = "STS_FALHA_COMUNICACAO";
			this.xACom.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.AComValueChanged);
			this.xACom.EndInit();
			// 
			// xAAGC
			// 
			this.xAAGC.BeginInit();
			this.xAAGC.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xAAGC.IsOnlyInput = true;
			this.xAAGC.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xAAGC.Name = "xAAGC";
			this.xAAGC.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xAAGC.TagName = "STS_ALARME_AGC";
			this.xAAGC.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.AAGCValueChanged);
			this.xAAGC.EndInit();
			// 
			// xAPartida
			// 
			this.xAPartida.BeginInit();
			this.xAPartida.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xAPartida.IsOnlyInput = true;
			this.xAPartida.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xAPartida.Name = "xAPartida";
			this.xAPartida.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xAPartida.TagName = "STS_ALARME_PARTIDA";
			this.xAPartida.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.APartidaValueChanged);
			this.xAPartida.EndInit();
			// 
			// xAMotor
			// 
			this.xAMotor.BeginInit();
			this.xAMotor.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xAMotor.IsOnlyInput = true;
			this.xAMotor.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xAMotor.Name = "xAMotor";
			this.xAMotor.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xAMotor.TagName = "STS_ALARME_MOTOR";
			this.xAMotor.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.AMotorValueChanged);
			this.xAMotor.EndInit();
			// 
			// xAEmergencia
			// 
			this.xAEmergencia.BeginInit();
			this.xAEmergencia.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xAEmergencia.IsOnlyInput = true;
			this.xAEmergencia.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xAEmergencia.Name = "xAEmergencia";
			this.xAEmergencia.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xAEmergencia.TagName = "STS_ALARME_EMERGENCIA";
			this.xAEmergencia.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.AEmergenciaValueChanged);
			this.xAEmergencia.EndInit();
			// 
			// xADisjuntor
			// 
			this.xADisjuntor.BeginInit();
			this.xADisjuntor.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xADisjuntor.IsOnlyInput = true;
			this.xADisjuntor.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xADisjuntor.Name = "xADisjuntor";
			this.xADisjuntor.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xADisjuntor.TagName = "STS_ALARME_DISJUNTOR";
			this.xADisjuntor.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.ADisjuntorValueChanged);
			this.xADisjuntor.EndInit();
			// 
			// xAFaltaRede
			// 
			this.xAFaltaRede.BeginInit();
			this.xAFaltaRede.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xAFaltaRede.IsOnlyInput = true;
			this.xAFaltaRede.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xAFaltaRede.Name = "xAFaltaRede";
			this.xAFaltaRede.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xAFaltaRede.TagName = "STS_ALARME_FALTA_REDE";
			this.xAFaltaRede.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.AFaltaRedeValueChanged);
			this.xAFaltaRede.EndInit();
			// 
			// xAForaAuto
			// 
			this.xAForaAuto.BeginInit();
			this.xAForaAuto.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xAForaAuto.IsOnlyInput = true;
			this.xAForaAuto.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xAForaAuto.Name = "xAForaAuto";
			this.xAForaAuto.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xAForaAuto.TagName = "STS_ALARME_FORA_AUTOMATICO";
			this.xAForaAuto.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.AForaAutoValueChanged);
			this.xAForaAuto.EndInit();
			// 
			// xECom
			// 
			this.xECom.BeginInit();
			this.xECom.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xECom.IsOnlyInput = true;
			this.xECom.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xECom.Name = "xECom";
			this.xECom.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xECom.TagName = "STS_ALM_COMUNICACAO_EST";
			this.xECom.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.EComValueChanged);
			this.xECom.EndInit();
			// 
			// xEAGC
			// 
			this.xEAGC.BeginInit();
			this.xEAGC.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xEAGC.IsOnlyInput = true;
			this.xEAGC.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xEAGC.Name = "xEAGC";
			this.xEAGC.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xEAGC.TagName = "STS_ALM_AGC_EST";
			this.xEAGC.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.EAGCValueChanged);
			this.xEAGC.EndInit();
			// 
			// xEPartida
			// 
			this.xEPartida.BeginInit();
			this.xEPartida.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xEPartida.IsOnlyInput = true;
			this.xEPartida.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xEPartida.Name = "xEPartida";
			this.xEPartida.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xEPartida.TagName = "STS_ALM_PARTIDA_EST";
			this.xEPartida.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.EPartidaValueChanged);
			this.xEPartida.EndInit();
			// 
			// xEMotor
			// 
			this.xEMotor.BeginInit();
			this.xEMotor.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xEMotor.IsOnlyInput = true;
			this.xEMotor.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xEMotor.Name = "xEMotor";
			this.xEMotor.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xEMotor.TagName = "STS_ALM_MOTOR_EST";
			this.xEMotor.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.EMotorValueChanged);
			this.xEMotor.EndInit();
			// 
			// xEEmergencia
			// 
			this.xEEmergencia.BeginInit();
			this.xEEmergencia.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xEEmergencia.IsOnlyInput = true;
			this.xEEmergencia.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xEEmergencia.Name = "xEEmergencia";
			this.xEEmergencia.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xEEmergencia.TagName = "STS_ALM_EMERGENCIA_EST";
			this.xEEmergencia.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.EEmergenciaValueChanged);
			this.xEEmergencia.EndInit();
			// 
			// xEDisjuntor
			// 
			this.xEDisjuntor.BeginInit();
			this.xEDisjuntor.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xEDisjuntor.IsOnlyInput = true;
			this.xEDisjuntor.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xEDisjuntor.Name = "xEDisjuntor";
			this.xEDisjuntor.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xEDisjuntor.TagName = "STS_ALM_DISJUNTOR_EST";
			this.xEDisjuntor.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.EDisjuntorValueChanged);
			this.xEDisjuntor.EndInit();
			// 
			// xEFaltaRede
			// 
			this.xEFaltaRede.BeginInit();
			this.xEFaltaRede.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xEFaltaRede.IsOnlyInput = true;
			this.xEFaltaRede.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xEFaltaRede.Name = "xEFaltaRede";
			this.xEFaltaRede.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xEFaltaRede.TagName = "STS_ALM_FALTA_REDE_EST";
			this.xEFaltaRede.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.EFaltaRedeValueChanged);
			this.xEFaltaRede.EndInit();
			// 
			// xEForaAuto
			// 
			this.xEForaAuto.BeginInit();
			this.xEForaAuto.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xEForaAuto.IsOnlyInput = true;
			this.xEForaAuto.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xEForaAuto.Name = "xEForaAuto";
			this.xEForaAuto.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xEForaAuto.TagName = "STS_ALM_FORA_AUTOMATICO_EST";
			this.xEForaAuto.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.EForaAutoValueChanged);
			this.xEForaAuto.EndInit();
			// 
			// xSGB
			// 
			this.xSGB.BeginInit();
			this.xSGB.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xSGB.IsOnlyInput = true;
			this.xSGB.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xSGB.Name = "xSGB";
			this.xSGB.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xSGB.TagName = "STS_DISJUNTOR_GERADOR";
			this.xSGB.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.SGBValueChanged);
			this.xSGB.EndInit();
			// 
			// xSMB
			// 
			this.xSMB.BeginInit();
			this.xSMB.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xSMB.IsOnlyInput = true;
			this.xSMB.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xSMB.Name = "xSMB";
			this.xSMB.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xSMB.TagName = "STS_DISJUNTOR_REDE";
			this.xSMB.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.SMBValueChanged);
			this.xSMB.EndInit();
			// 
			// xSModo
			// 
			this.xSModo.BeginInit();
			this.xSModo.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xSModo.IsOnlyInput = true;
			this.xSModo.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xSModo.Name = "xSModo";
			this.xSModo.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xSModo.TagName = "STS_MODO";
			this.xSModo.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.SModoValueChanged);
			this.xSModo.EndInit();
			// 
			// xSFonte
			// 
			this.xSFonte.BeginInit();
			this.xSFonte.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xSFonte.IsOnlyInput = true;
			this.xSFonte.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xSFonte.Name = "xSFonte";
			this.xSFonte.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xSFonte.TagName = "STS_FONTE";
			this.xSFonte.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.SFonteValueChanged);
			this.xSFonte.EndInit();
			// 
			// xOperando
			// 
			this.xOperando.BeginInit();
			this.xOperando.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xOperando.IsOnlyInput = true;
			this.xOperando.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xOperando.Name = "xOperando";
			this.xOperando.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xOperando.TagName = "STS_MOTOR_OPERANDO";
			this.xOperando.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.OperandoValueChanged);
			this.xOperando.EndInit();
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
			this.textoModo,
			this.rP,
			this.vP,
			this.rF,
			this.vF,
			this.textoAlarme,
			this.xACom,
			this.xAAGC,
			this.xAPartida,
			this.xAMotor,
			this.xAEmergencia,
			this.xADisjuntor,
			this.xAFaltaRede,
			this.xAForaAuto,
			this.xECom,
			this.xEAGC,
			this.xEPartida,
			this.xEMotor,
			this.xEEmergencia,
			this.xEDisjuntor,
			this.xEFaltaRede,
			this.xEForaAuto,
			this.xSGB,
			this.xSMB,
			this.xSModo,
			this.xSFonte,
			this.xOperando,
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
		private NxtControl.GuiFramework.FreeText textoModo;
		private NxtControl.GuiFramework.FreeText rP;
		private System.HMI.Symbols.Base.Label<System.Single> vP;
		private NxtControl.GuiFramework.FreeText rF;
		private System.HMI.Symbols.Base.Label<System.Single> vF;
		private NxtControl.GuiFramework.FreeText textoAlarme;
		private System.HMI.Symbols.Base.Execute<bool> xACom;
		private System.HMI.Symbols.Base.Execute<bool> xAAGC;
		private System.HMI.Symbols.Base.Execute<bool> xAPartida;
		private System.HMI.Symbols.Base.Execute<bool> xAMotor;
		private System.HMI.Symbols.Base.Execute<bool> xAEmergencia;
		private System.HMI.Symbols.Base.Execute<bool> xADisjuntor;
		private System.HMI.Symbols.Base.Execute<bool> xAFaltaRede;
		private System.HMI.Symbols.Base.Execute<bool> xAForaAuto;
		private System.HMI.Symbols.Base.Execute<byte> xECom;
		private System.HMI.Symbols.Base.Execute<byte> xEAGC;
		private System.HMI.Symbols.Base.Execute<byte> xEPartida;
		private System.HMI.Symbols.Base.Execute<byte> xEMotor;
		private System.HMI.Symbols.Base.Execute<byte> xEEmergencia;
		private System.HMI.Symbols.Base.Execute<byte> xEDisjuntor;
		private System.HMI.Symbols.Base.Execute<byte> xEFaltaRede;
		private System.HMI.Symbols.Base.Execute<byte> xEForaAuto;
		private System.HMI.Symbols.Base.Execute<short> xSGB;
		private System.HMI.Symbols.Base.Execute<short> xSMB;
		private System.HMI.Symbols.Base.Execute<short> xSModo;
		private System.HMI.Symbols.Base.Execute<short> xSFonte;
		private System.HMI.Symbols.Base.Execute<bool> xOperando;
		private NxtControl.GuiFramework.DrawnButton abrir;
		#endregion
	}
}
