/*
 * Created by EcoStruxure Automation Expert.
 * User: SESA404904
 * Date: 10/05/2021
 * Time: 10:58 am
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using NxtControl.GuiFramework;

namespace SE.Nereda.Faceplates.MotorVsBaseNer
{
	/// <summary>
	/// Summary description for fpDefault.
	/// </summary>
	partial class fpDefault
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary2 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary1 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary4 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary3 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary6 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary5 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary8 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary7 = new NxtControl.GuiFramework.PropertyDictionary();
			this.cabecalho = new NxtControl.GuiFramework.Rectangle();
			this.caixaEstado = new NxtControl.GuiFramework.Rectangle();
			this.textoEstado = new NxtControl.GuiFramework.FreeText();
			this.textoComando = new NxtControl.GuiFramework.FreeText();
			this.textoSaida = new NxtControl.GuiFramework.FreeText();
			this.lPassivo = new NxtControl.GuiFramework.FreeText();
			this.PassiveRemainTime = new System.HMI.Symbols.Base.Label<float>();
			this.lVelReal = new NxtControl.GuiFramework.FreeText();
			this.SpeedPvValue = new System.HMI.Symbols.Base.Label<float>();
			this.lVelRef = new NxtControl.GuiFramework.FreeText();
			this.SpeedSpValue = new System.HMI.Symbols.Base.Label<float>();
			this.lVelSaida = new NxtControl.GuiFramework.FreeText();
			this.SpeedOpValue = new System.HMI.Symbols.Base.Label<float>();
			this.barFundo = new NxtControl.GuiFramework.Rectangle();
			this.barVal = new NxtControl.GuiFramework.Rectangle();
			this.barRef = new NxtControl.GuiFramework.Rectangle();
			this.textoSituacao = new NxtControl.GuiFramework.FreeText();
			this.tituloModo = new NxtControl.GuiFramework.FreeText();
			this.btnManual = new NxtControl.GuiFramework.DrawnButton();
			this.btnAutomatico = new NxtControl.GuiFramework.DrawnButton();
			this.tituloComando = new NxtControl.GuiFramework.FreeText();
			this.btnManualOff = new NxtControl.GuiFramework.DrawnButton();
			this.btnManualForward = new NxtControl.GuiFramework.DrawnButton();
			this.btnManualReverse = new NxtControl.GuiFramework.DrawnButton();
			this.tituloVel = new NxtControl.GuiFramework.FreeText();
			this.lRefManual = new NxtControl.GuiFramework.FreeText();
			this.txtSp = new System.HMI.Symbols.Base.TextBox<float>();
			this.lDonoVel = new NxtControl.GuiFramework.FreeText();
			this.btnSpeedOwner = new NxtControl.GuiFramework.TwoStateButton();
			this.btnReset = new NxtControl.GuiFramework.DrawnButton();
			this.sep = new NxtControl.GuiFramework.Rectangle();
			this.btnAjustes = new NxtControl.GuiFramework.DrawnButton();
			this.btnGrafico = new NxtControl.GuiFramework.DrawnButton();
			this.btnDiagnostico = new NxtControl.GuiFramework.DrawnButton();
			this.fpNavigationPane = new SE.App2Base.Graphics.FpNavigationPane();
			this.ownerSwitch = new SE.App2Base.Graphics.OwnerSwitchBasic();
			this.FbStatus = new System.HMI.Symbols.Base.Execute<short>();
			this.TransFbStatus = new System.HMI.Symbols.Base.Execute<short>();
			this.SpeedFbStatus = new System.HMI.Symbols.Base.Execute<float>();
			this.CurrentSp = new System.HMI.Symbols.Base.Execute<short>();
			this.CurrentSpeedSp = new System.HMI.Symbols.Base.Execute<float>();
			this.CurrentSpeedOp = new System.HMI.Symbols.Base.Execute<float>();
			this.CurrentOwner = new System.HMI.Symbols.Base.Execute<ushort>();
			this.CurrentSpeedOwner = new System.HMI.Symbols.Base.Execute<ushort>();
			this.NeedReset = new System.HMI.Symbols.Base.Execute<bool>();
			this.StdOwnerConnected = new System.HMI.Symbols.Base.Execute<bool>();
			this.Maintenance = new System.HMI.Symbols.Base.Execute<bool>();
			this.OutOfService = new System.HMI.Symbols.Base.Execute<bool>();
			this.FbOverride = new System.HMI.Symbols.Base.Execute<bool>();
			this.Simulation = new System.HMI.Symbols.Base.Execute<bool>();
			this.SpeedSp = new System.HMI.Symbols.Base.Execute<float>();
			this.CurrentSpeedSpMin = new System.HMI.Symbols.Base.Execute<float>();
			this.CurrentSpeedSpMax = new System.HMI.Symbols.Base.Execute<float>();
			this.DisReverse = new System.HMI.Symbols.Base.Execute<bool>();
			this.EnSpeedOwner = new System.HMI.Symbols.Base.Execute<bool>();
			this.CurrentOp = new System.HMI.Symbols.Base.Execute<short>();
			this.ExternalControlled = new System.HMI.Symbols.Base.Execute<bool>();
			this.SpeedOutMin = new System.HMI.Symbols.Base.Execute<float>();
			this.SpeedOutMax = new System.HMI.Symbols.Base.Execute<float>();
			// 
			// cabecalho
			// 
			this.cabecalho.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(360D)), ((float)(210D)));
			this.cabecalho.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(235)), ((byte)(235)), ((byte)(235))));
			this.cabecalho.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.cabecalho.Name = "cabecalho";
			this.cabecalho.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// caixaEstado
			// 
			this.caixaEstado.Bounds = new NxtControl.Drawing.RectF(((float)(20D)), ((float)(14D)), ((float)(22D)), ((float)(22D)));
			this.caixaEstado.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255))));
			this.caixaEstado.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.caixaEstado.Name = "caixaEstado";
			this.caixaEstado.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 2F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// textoEstado
			// 
			this.textoEstado.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.textoEstado.Font = new NxtControl.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
			this.textoEstado.Location = new NxtControl.Drawing.PointF(50D, 14D);
			this.textoEstado.Name = "textoEstado";
			this.textoEstado.Text = "DESLIGADO";
			// 
			// textoComando
			// 
			this.textoComando.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.textoComando.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.textoComando.Location = new NxtControl.Drawing.PointF(20D, 48D);
			this.textoComando.Name = "textoComando";
			this.textoComando.Text = "Comando atual: -";
			// 
			// textoSaida
			// 
			this.textoSaida.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.textoSaida.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.textoSaida.Location = new NxtControl.Drawing.PointF(20D, 68D);
			this.textoSaida.Name = "textoSaida";
			this.textoSaida.Text = "Sa\u00edda atual: -";
			// 
			// lPassivo
			// 
			this.lPassivo.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.lPassivo.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.lPassivo.Location = new NxtControl.Drawing.PointF(200D, 48D);
			this.lPassivo.Name = "lPassivo";
			this.lPassivo.Text = "Passivo:";
			// 
			// PassiveRemainTime
			// 
			this.PassiveRemainTime.BeginInit();
			this.PassiveRemainTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.PassiveRemainTime.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.53D, 0D, 0D, 1.1904761904761905D, 262D, 44D);
			this.PassiveRemainTime.Font = new NxtControl.Drawing.Font("SE.App2Base.Pv");
			this.PassiveRemainTime.FontScale = false;
			this.PassiveRemainTime.IsOnlyInput = true;
			this.PassiveRemainTime.IsPrefixSuffixOutside = false;
			this.PassiveRemainTime.LeadingZeros = ((uint)(0u));
			this.PassiveRemainTime.Name = "PassiveRemainTime";
			this.PassiveRemainTime.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.PassiveRemainTime.Ranges.Clear();
			this.PassiveRemainTime.Ranges.Add(new NxtControl.GuiFramework.Range<float>(null, true, null, true, propertyDictionary2));
			propertyDictionary1.Add("Text", "${Value}");
			propertyDictionary1.Add("TextColor", new NxtControl.Drawing.Color("SE.App2Base.aaLibFpData"));
			propertyDictionary1.Add("Brush", new NxtControl.Drawing.Brush(true));
			propertyDictionary1.Add("Pen", new NxtControl.Drawing.Pen("LabelPen"));
			this.PassiveRemainTime.Ranges.DefaultPropertyValues = propertyDictionary1;
			this.PassiveRemainTime.Suffix = "s";
			this.PassiveRemainTime.TagName = "PassiveRemainTime";
			this.PassiveRemainTime.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.PassiveRemainTime.EndInit();
			// 
			// lVelReal
			// 
			this.lVelReal.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.lVelReal.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.lVelReal.Location = new NxtControl.Drawing.PointF(20D, 94D);
			this.lVelReal.Name = "lVelReal";
			this.lVelReal.Text = "Velocidade real";
			// 
			// SpeedPvValue
			// 
			this.SpeedPvValue.BeginInit();
			this.SpeedPvValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.SpeedPvValue.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.66666666666666663D, 0D, 0D, 1.1904761904761905D, 220D, 90D);
			this.SpeedPvValue.Font = new NxtControl.Drawing.Font("SE.App2Base.Pv");
			this.SpeedPvValue.FontScale = false;
			this.SpeedPvValue.IsOnlyInput = true;
			this.SpeedPvValue.IsPrefixSuffixOutside = false;
			this.SpeedPvValue.LeadingZeros = ((uint)(0u));
			this.SpeedPvValue.Name = "SpeedPvValue";
			this.SpeedPvValue.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.SpeedPvValue.Ranges.Clear();
			this.SpeedPvValue.Ranges.Add(new NxtControl.GuiFramework.Range<float>(null, true, null, true, propertyDictionary8));
			propertyDictionary7.Add("Text", "${Value}");
			propertyDictionary7.Add("TextColor", new NxtControl.Drawing.Color("SE.App2Base.aaLibFpData"));
			propertyDictionary7.Add("Brush", new NxtControl.Drawing.Brush(true));
			propertyDictionary7.Add("Pen", new NxtControl.Drawing.Pen("LabelPen"));
			this.SpeedPvValue.Ranges.DefaultPropertyValues = propertyDictionary7;
			this.SpeedPvValue.TagName = "SpeedFbStatus";
			this.SpeedPvValue.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.SpeedPvValue.EndInit();
			// 
			// lVelRef
			// 
			this.lVelRef.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.lVelRef.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.lVelRef.Location = new NxtControl.Drawing.PointF(20D, 118D);
			this.lVelRef.Name = "lVelRef";
			this.lVelRef.Text = "Refer\u00eancia atual";
			// 
			// SpeedSpValue
			// 
			this.SpeedSpValue.BeginInit();
			this.SpeedSpValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.SpeedSpValue.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.66666666666666663D, 0D, 0D, 1.1904761904761905D, 220D, 114D);
			this.SpeedSpValue.Font = new NxtControl.Drawing.Font("SE.App2Base.Pv");
			this.SpeedSpValue.FontScale = false;
			this.SpeedSpValue.IsOnlyInput = true;
			this.SpeedSpValue.IsPrefixSuffixOutside = false;
			this.SpeedSpValue.LeadingZeros = ((uint)(0u));
			this.SpeedSpValue.Name = "SpeedSpValue";
			this.SpeedSpValue.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.SpeedSpValue.Ranges.Clear();
			this.SpeedSpValue.Ranges.Add(new NxtControl.GuiFramework.Range<float>(null, true, null, true, propertyDictionary4));
			propertyDictionary3.Add("Text", "${Value}");
			propertyDictionary3.Add("TextColor", new NxtControl.Drawing.Color("SE.App2Base.aaLibFpSp"));
			propertyDictionary3.Add("Brush", new NxtControl.Drawing.Brush(true));
			propertyDictionary3.Add("Pen", new NxtControl.Drawing.Pen("LabelPen"));
			this.SpeedSpValue.Ranges.DefaultPropertyValues = propertyDictionary3;
			this.SpeedSpValue.TagName = "CurrentSpeedSp";
			this.SpeedSpValue.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.SpeedSpValue.EndInit();
			// 
			// lVelSaida
			// 
			this.lVelSaida.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.lVelSaida.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.lVelSaida.Location = new NxtControl.Drawing.PointF(20D, 142D);
			this.lVelSaida.Name = "lVelSaida";
			this.lVelSaida.Text = "Sa\u00edda para o inversor";
			// 
			// SpeedOpValue
			// 
			this.SpeedOpValue.BeginInit();
			this.SpeedOpValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.SpeedOpValue.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.66666666666666663D, 0D, 0D, 1.1904761904761905D, 220D, 138D);
			this.SpeedOpValue.Font = new NxtControl.Drawing.Font("SE.App2Base.Pv");
			this.SpeedOpValue.FontScale = false;
			this.SpeedOpValue.IsOnlyInput = true;
			this.SpeedOpValue.IsPrefixSuffixOutside = false;
			this.SpeedOpValue.LeadingZeros = ((uint)(0u));
			this.SpeedOpValue.Name = "SpeedOpValue";
			this.SpeedOpValue.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.SpeedOpValue.Ranges.Clear();
			this.SpeedOpValue.Ranges.Add(new NxtControl.GuiFramework.Range<float>(null, true, null, true, propertyDictionary6));
			propertyDictionary5.Add("Text", "${Value}");
			propertyDictionary5.Add("TextColor", new NxtControl.Drawing.Color("SE.App2Base.aaLibFpOp"));
			propertyDictionary5.Add("Brush", new NxtControl.Drawing.Brush(true));
			propertyDictionary5.Add("Pen", new NxtControl.Drawing.Pen("LabelPen"));
			this.SpeedOpValue.Ranges.DefaultPropertyValues = propertyDictionary5;
			this.SpeedOpValue.TagName = "CurrentSpeedOp";
			this.SpeedOpValue.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.SpeedOpValue.EndInit();
			// 
			// barFundo
			// 
			this.barFundo.Bounds = new NxtControl.Drawing.RectF(((float)(20D)), ((float)(168D)), ((float)(320D)), ((float)(8D)));
			this.barFundo.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255))));
			this.barFundo.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.barFundo.Name = "barFundo";
			this.barFundo.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// barVal
			// 
			this.barVal.Bounds = new NxtControl.Drawing.RectF(((float)(20D)), ((float)(168D)), ((float)(0D)), ((float)(8D)));
			this.barVal.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64))));
			this.barVal.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.barVal.Name = "barVal";
			this.barVal.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// barRef
			// 
			this.barRef.Bounds = new NxtControl.Drawing.RectF(((float)(20D)), ((float)(164D)), ((float)(3D)), ((float)(16D)));
			this.barRef.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			this.barRef.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.barRef.Name = "barRef";
			this.barRef.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// textoSituacao
			// 
			this.textoSituacao.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.textoSituacao.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.textoSituacao.Location = new NxtControl.Drawing.PointF(20D, 186D);
			this.textoSituacao.Name = "textoSituacao";
			this.textoSituacao.Text = "";
			// 
			// tituloModo
			// 
			this.tituloModo.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.tituloModo.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.tituloModo.Location = new NxtControl.Drawing.PointF(20D, 222D);
			this.tituloModo.Name = "tituloModo";
			this.tituloModo.Text = "Modo de opera\u00e7\u00e3o";
			// 
			// btnManual
			// 
			this.btnManual.Bounds = new NxtControl.Drawing.RectF(((float)(20D)), ((float)(244D)), ((float)(150D)), ((float)(34D)));
			this.btnManual.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208))));
			this.btnManual.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.btnManual.InnerBorderColor = new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208)));
			this.btnManual.Name = "btnManual";
			this.btnManual.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.btnManual.Radius = 2D;
			this.btnManual.Text = "Manual";
			this.btnManual.TextColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.btnManual.TextColorMouseDown = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.btnManual.Use3DEffect = false;
			this.btnManual.Click += new System.EventHandler(this.BtnManualClick);
			// 
			// btnAutomatico
			// 
			this.btnAutomatico.Bounds = new NxtControl.Drawing.RectF(((float)(190D)), ((float)(244D)), ((float)(150D)), ((float)(34D)));
			this.btnAutomatico.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208))));
			this.btnAutomatico.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.btnAutomatico.InnerBorderColor = new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208)));
			this.btnAutomatico.Name = "btnAutomatico";
			this.btnAutomatico.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.btnAutomatico.Radius = 2D;
			this.btnAutomatico.Text = "Autom\u00e1tico";
			this.btnAutomatico.TextColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.btnAutomatico.TextColorMouseDown = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.btnAutomatico.Use3DEffect = false;
			this.btnAutomatico.Click += new System.EventHandler(this.BtnAutomaticoClick);
			// 
			// tituloComando
			// 
			this.tituloComando.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.tituloComando.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.tituloComando.Location = new NxtControl.Drawing.PointF(20D, 292D);
			this.tituloComando.Name = "tituloComando";
			this.tituloComando.Text = "Comando manual";
			// 
			// btnManualOff
			// 
			this.btnManualOff.Bounds = new NxtControl.Drawing.RectF(((float)(20D)), ((float)(314D)), ((float)(150D)), ((float)(34D)));
			this.btnManualOff.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208))));
			this.btnManualOff.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.btnManualOff.InnerBorderColor = new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208)));
			this.btnManualOff.Name = "btnManualOff";
			this.btnManualOff.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.btnManualOff.Radius = 2D;
			this.btnManualOff.Text = "Desligar";
			this.btnManualOff.TextColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.btnManualOff.TextColorMouseDown = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.btnManualOff.Use3DEffect = false;
			this.btnManualOff.Click += new System.EventHandler(this.BtnManualOffClick);
			// 
			// btnManualForward
			// 
			this.btnManualForward.Bounds = new NxtControl.Drawing.RectF(((float)(190D)), ((float)(314D)), ((float)(150D)), ((float)(34D)));
			this.btnManualForward.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208))));
			this.btnManualForward.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.btnManualForward.InnerBorderColor = new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208)));
			this.btnManualForward.Name = "btnManualForward";
			this.btnManualForward.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.btnManualForward.Radius = 2D;
			this.btnManualForward.Text = "Ligar";
			this.btnManualForward.TextColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.btnManualForward.TextColorMouseDown = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.btnManualForward.Use3DEffect = false;
			this.btnManualForward.Click += new System.EventHandler(this.BtnManualForwardClick);
			// 
			// btnManualReverse
			// 
			this.btnManualReverse.Bounds = new NxtControl.Drawing.RectF(((float)(240D)), ((float)(314D)), ((float)(100D)), ((float)(34D)));
			this.btnManualReverse.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208))));
			this.btnManualReverse.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.btnManualReverse.InnerBorderColor = new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208)));
			this.btnManualReverse.Name = "btnManualReverse";
			this.btnManualReverse.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.btnManualReverse.Radius = 2D;
			this.btnManualReverse.Text = "Reverso";
			this.btnManualReverse.TextColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.btnManualReverse.TextColorMouseDown = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.btnManualReverse.Use3DEffect = false;
			this.btnManualReverse.Click += new System.EventHandler(this.BtnManualReverseClick);
			// 
			// tituloVel
			// 
			this.tituloVel.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.tituloVel.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.tituloVel.Location = new NxtControl.Drawing.PointF(20D, 362D);
			this.tituloVel.Name = "tituloVel";
			this.tituloVel.Text = "Velocidade em manual";
			// 
			// lRefManual
			// 
			this.lRefManual.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.lRefManual.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.lRefManual.Location = new NxtControl.Drawing.PointF(20D, 389D);
			this.lRefManual.Name = "lRefManual";
			this.lRefManual.Text = "Refer\u00eancia";
			// 
			// txtSp
			// 
			this.txtSp.BeginInit();
			this.txtSp.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.8D, 0D, 0D, 1D, 220D, 384D);
			this.txtSp.Font = new NxtControl.Drawing.Font("SE.App2Base.Sp");
			this.txtSp.MaximumTag = null;
			this.txtSp.MinimumTag = null;
			this.txtSp.Name = "txtSp";
			this.txtSp.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.txtSp.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.txtSp.SecurityLevel = 0;
			this.txtSp.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.txtSp.TagName = "SpeedSp";
			this.txtSp.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.txtSp.UseInputPad = true;
			this.txtSp.UseRange = true;
			this.txtSp.Value = 0F;
			this.txtSp.EndInit();
			// 
			// lDonoVel
			// 
			this.lDonoVel.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.lDonoVel.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.lDonoVel.Location = new NxtControl.Drawing.PointF(20D, 425D);
			this.lDonoVel.Name = "lDonoVel";
			this.lDonoVel.Text = "Dono da velocidade";
			// 
			// btnSpeedOwner
			// 
			this.btnSpeedOwner.Bounds = new NxtControl.Drawing.RectF(((float)(220D)), ((float)(420D)), ((float)(120D)), ((float)(26D)));
			this.btnSpeedOwner.ButtonPushedBrush = new NxtControl.Drawing.Brush(true);
			this.btnSpeedOwner.DrawStyle = NxtControl.GuiFramework.TwoStateButton.ButtonDrawStyle.Switch;
			this.btnSpeedOwner.FalseBrush = new NxtControl.Drawing.Brush("ButtonFalseBrush");
			this.btnSpeedOwner.FalseText = "Programa";
			this.btnSpeedOwner.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.btnSpeedOwner.InnerBorderColor = new NxtControl.Drawing.Color("ButtonInnerBorderColor");
			this.btnSpeedOwner.Name = "btnSpeedOwner";
			this.btnSpeedOwner.Pen = new NxtControl.Drawing.Pen("ButtonPen");
			this.btnSpeedOwner.Radius = 8D;
			this.btnSpeedOwner.TextColorFalse = new NxtControl.Drawing.Color("ButtonTextColorFalse");
			this.btnSpeedOwner.TextColorTrue = new NxtControl.Drawing.Color("ButtonTextColorTrue");
			this.btnSpeedOwner.TrueBrush = new NxtControl.Drawing.Brush("ButtonBrush");
			this.btnSpeedOwner.TrueText = "Operador";
			this.btnSpeedOwner.Use3DEffect = false;
			this.btnSpeedOwner.CheckedChanged += new System.EventHandler(this.BtnSpeedOwnerCheckedChanged);
			// 
			// btnReset
			// 
			this.btnReset.Bounds = new NxtControl.Drawing.RectF(((float)(20D)), ((float)(460D)), ((float)(150D)), ((float)(34D)));
			this.btnReset.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208))));
			this.btnReset.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.btnReset.InnerBorderColor = new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208)));
			this.btnReset.Name = "btnReset";
			this.btnReset.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.btnReset.Radius = 2D;
			this.btnReset.Text = "Reconhecer / Reset";
			this.btnReset.TextColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.btnReset.TextColorMouseDown = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.btnReset.Use3DEffect = false;
			this.btnReset.Click += new System.EventHandler(this.BtnResetClick);
			// 
			// sep
			// 
			this.sep.Bounds = new NxtControl.Drawing.RectF(((float)(20D)), ((float)(510D)), ((float)(320D)), ((float)(1D)));
			this.sep.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))));
			this.sep.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.sep.Name = "sep";
			this.sep.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// btnAjustes
			// 
			this.btnAjustes.Bounds = new NxtControl.Drawing.RectF(((float)(20D)), ((float)(522D)), ((float)(100D)), ((float)(32D)));
			this.btnAjustes.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208))));
			this.btnAjustes.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.btnAjustes.InnerBorderColor = new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208)));
			this.btnAjustes.Name = "btnAjustes";
			this.btnAjustes.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.btnAjustes.Radius = 2D;
			this.btnAjustes.Text = "Ajustes";
			this.btnAjustes.TextColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.btnAjustes.TextColorMouseDown = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.btnAjustes.Use3DEffect = false;
			this.btnAjustes.Click += new System.EventHandler(this.BtnAjustesClick);
			// 
			// btnGrafico
			// 
			this.btnGrafico.Bounds = new NxtControl.Drawing.RectF(((float)(130D)), ((float)(522D)), ((float)(100D)), ((float)(32D)));
			this.btnGrafico.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208))));
			this.btnGrafico.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.btnGrafico.InnerBorderColor = new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208)));
			this.btnGrafico.Name = "btnGrafico";
			this.btnGrafico.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.btnGrafico.Radius = 2D;
			this.btnGrafico.Text = "Gr\u00e1fico";
			this.btnGrafico.TextColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.btnGrafico.TextColorMouseDown = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.btnGrafico.Use3DEffect = false;
			this.btnGrafico.Click += new System.EventHandler(this.BtnGraficoClick);
			// 
			// btnDiagnostico
			// 
			this.btnDiagnostico.Bounds = new NxtControl.Drawing.RectF(((float)(240D)), ((float)(522D)), ((float)(100D)), ((float)(32D)));
			this.btnDiagnostico.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208))));
			this.btnDiagnostico.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.btnDiagnostico.InnerBorderColor = new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208)));
			this.btnDiagnostico.Name = "btnDiagnostico";
			this.btnDiagnostico.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.btnDiagnostico.Radius = 2D;
			this.btnDiagnostico.Text = "Diagn\u00f3stico";
			this.btnDiagnostico.TextColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.btnDiagnostico.TextColorMouseDown = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.btnDiagnostico.Use3DEffect = false;
			this.btnDiagnostico.Click += new System.EventHandler(this.BtnDiagnosticoClick);
			// 
			// fpNavigationPane
			// 
			this.fpNavigationPane.BeginInit();
			this.fpNavigationPane.Backwash.AliasName = "";
			this.fpNavigationPane.Backwash.Availablity = SE.App2Base.SupportClasses.FpIconSymbolAllocation.NotAvailable;
			this.fpNavigationPane.Backwash.InstanceName = null;
			this.fpNavigationPane.Backwash.ParentTitle = "Title";
			this.fpNavigationPane.Backwash.SymbolType = "SE.AppWWW.Symbols.Backwash.sDefault";
			this.fpNavigationPane.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 360D, 0D);
			this.fpNavigationPane.ExtendedMeasures.Availablity = SE.App2Base.SupportClasses.FpIconSymbolAllocation.NotAvailable;
			this.fpNavigationPane.Failure.AliasName = "";
			this.fpNavigationPane.Failure.ApplicableConditions = SE.App2Base.SupportClasses.ApplicableInputConditions.PassiveActive1Active2;
			this.fpNavigationPane.Failure.Availablity = SE.App2Base.SupportClasses.FpIconSymbolAllocation.Slot3L;
			this.fpNavigationPane.Failure.InstanceName = null;
			this.fpNavigationPane.Failure.ParentTitle = "Title";
			this.fpNavigationPane.Failure.SymbolType = "SE.App2CommonProcess.Symbols.CondSum.sFailure";
			this.fpNavigationPane.Filtration.AliasName = "";
			this.fpNavigationPane.Filtration.Availablity = SE.App2Base.SupportClasses.FpIconSymbolAllocation.NotAvailable;
			this.fpNavigationPane.Filtration.InstanceName = null;
			this.fpNavigationPane.Filtration.ParentTitle = "Title";
			this.fpNavigationPane.Filtration.SymbolType = "SE.AppWWW.Symbols.Filtration.sDefault";
			this.fpNavigationPane.GeneralPropertySubscription.AddRange(new string[] {
			"System.ShowTagNames"});
			this.fpNavigationPane.HideSlider = false;
			this.fpNavigationPane.Info.Availablity = SE.App2Base.SupportClasses.FpIconSymbolAllocation.NotAvailable;
			this.fpNavigationPane.InputParameters.Availablity = SE.App2Base.SupportClasses.FpIconSymbolAllocation.NotAvailable;
			this.fpNavigationPane.Interlock.AliasName = "";
			this.fpNavigationPane.Interlock.ApplicableConditions = SE.App2Base.SupportClasses.ApplicableInputConditions.PassiveActive1Active2;
			this.fpNavigationPane.Interlock.Availablity = SE.App2Base.SupportClasses.FpIconSymbolAllocation.Slot2L;
			this.fpNavigationPane.Interlock.InstanceName = null;
			this.fpNavigationPane.Interlock.LabelActive1 = SE.App2Base.SupportClasses.CondActive1LabelText.Forward;
			this.fpNavigationPane.Interlock.LabelActive2 = SE.App2Base.SupportClasses.CondActive2LabelText.Reverse;
			this.fpNavigationPane.Interlock.LabelPassive = SE.App2Base.SupportClasses.CondPassiveLabelText.Stop;
			this.fpNavigationPane.Interlock.ParentTitle = "Title";
			this.fpNavigationPane.Interlock.SymbolType = "SE.App2CommonProcess.Symbols.IlckCondSum.sInterlock";
			this.fpNavigationPane.IsBasic = false;
			this.fpNavigationPane.LocalPanel.AliasName = "";
			this.fpNavigationPane.LocalPanel.ApplicableConditions = SE.App2Base.SupportClasses.ApplicableInputConditions.PassiveActive1Active2;
			this.fpNavigationPane.LocalPanel.Availablity = SE.App2Base.SupportClasses.FpIconSymbolAllocation.Slot4R;
			this.fpNavigationPane.LocalPanel.InstanceName = null;
			this.fpNavigationPane.LocalPanel.LabelActive1 = SE.App2Base.SupportClasses.CondActive1LabelText.Forward;
			this.fpNavigationPane.LocalPanel.LabelActive2 = SE.App2Base.SupportClasses.CondActive2LabelText.Reverse;
			this.fpNavigationPane.LocalPanel.LabelPassive = SE.App2Base.SupportClasses.CondPassiveLabelText.Stop;
			this.fpNavigationPane.LocalPanel.ParentTitle = "Title";
			this.fpNavigationPane.LocalPanel.SymbolType = "SE.App2CommonProcess.Symbols.DevLp.sDefault";
			this.fpNavigationPane.Maintenance.AliasName = "";
			this.fpNavigationPane.Maintenance.Availablity = SE.App2Base.SupportClasses.FpIconSymbolAllocation.Slot1L;
			this.fpNavigationPane.Maintenance.InstanceName = null;
			this.fpNavigationPane.Maintenance.ParentTitle = "Title";
			this.fpNavigationPane.Maintenance.SymbolType = "SE.App2CommonProcess.Symbols.DevMnt.sDefault";
			this.fpNavigationPane.Measures.Availablity = SE.App2Base.SupportClasses.FpIconSymbolAllocation.NotAvailable;
			this.fpNavigationPane.Name = "fpNavigationPane";
			this.fpNavigationPane.OutputParameters.Availablity = SE.App2Base.SupportClasses.FpIconSymbolAllocation.NotAvailable;
			this.fpNavigationPane.Owner.AliasName = "";
			this.fpNavigationPane.Owner.Availablity = SE.App2Base.SupportClasses.FpIconSymbolAllocation.Slot1R;
			this.fpNavigationPane.Owner.InstanceName = null;
			this.fpNavigationPane.Owner.ParentTitle = "Title";
			this.fpNavigationPane.Owner.SymbolType = "SE.App2Base.Symbols.Owner.sOwnerConfig";
			this.fpNavigationPane.Parameter.Availablity = SE.App2Base.SupportClasses.FpIconSymbolAllocation.NotAvailable;
			this.fpNavigationPane.ParentTitle = "";
			this.fpNavigationPane.Permissive.AliasName = "";
			this.fpNavigationPane.Permissive.ApplicableConditions = SE.App2Base.SupportClasses.ApplicableInputConditions.PassiveActive1Active2;
			this.fpNavigationPane.Permissive.Availablity = SE.App2Base.SupportClasses.FpIconSymbolAllocation.Slot4L;
			this.fpNavigationPane.Permissive.InstanceName = null;
			this.fpNavigationPane.Permissive.LabelActive1 = SE.App2Base.SupportClasses.CondActive1LabelText.Forward;
			this.fpNavigationPane.Permissive.LabelActive2 = SE.App2Base.SupportClasses.CondActive2LabelText.Reverse;
			this.fpNavigationPane.Permissive.LabelPassive = SE.App2Base.SupportClasses.CondPassiveLabelText.Stop;
			this.fpNavigationPane.Permissive.ParentTitle = "Title";
			this.fpNavigationPane.Permissive.SymbolType = "SE.App2CommonProcess.Symbols.PermCondSum.sPermissive";
			this.fpNavigationPane.SecMode = 6;
			this.fpNavigationPane.SecOwner = 3;
			this.fpNavigationPane.SecParameter = 12;
			this.fpNavigationPane.SecSetpoint = 3;
			this.fpNavigationPane.ShortFlush.AliasName = "";
			this.fpNavigationPane.ShortFlush.Availablity = SE.App2Base.SupportClasses.FpIconSymbolAllocation.NotAvailable;
			this.fpNavigationPane.ShortFlush.InstanceName = null;
			this.fpNavigationPane.ShortFlush.ParentTitle = "Title";
			this.fpNavigationPane.ShortFlush.SymbolType = "SE.AppWWW.Symbols.ShortFlush.sDefault";
			this.fpNavigationPane.SSC.AliasName = "";
			this.fpNavigationPane.SSC.Availablity = SE.App2Base.SupportClasses.FpIconSymbolAllocation.NotAvailable;
			this.fpNavigationPane.SSC.ParentTitle = "Title";
			this.fpNavigationPane.SSC.SymbolType = "SE.App2CommonProcess.Symbols.PIDSSCSeqData.sDefault";
			this.fpNavigationPane.Trend.Availablity = SE.App2Base.SupportClasses.FpIconSymbolAllocation.NotAvailable;
			this.fpNavigationPane.UserDefined1.AliasName = "";
			this.fpNavigationPane.UserDefined1.Availablity = SE.App2Base.SupportClasses.FpIconSymbolAllocation.NotAvailable;
			this.fpNavigationPane.UserDefined1.ParentTitle = "Title";
			this.fpNavigationPane.UserDefined2.AliasName = "";
			this.fpNavigationPane.UserDefined2.Availablity = SE.App2Base.SupportClasses.FpIconSymbolAllocation.NotAvailable;
			this.fpNavigationPane.UserDefined2.ParentTitle = "Title";
			this.fpNavigationPane.UserDefined3.AliasName = "";
			this.fpNavigationPane.UserDefined3.Availablity = SE.App2Base.SupportClasses.FpIconSymbolAllocation.NotAvailable;
			this.fpNavigationPane.UserDefined3.ParentTitle = "Title";
			this.fpNavigationPane.EndInit();
			// 
			// ownerSwitch
			// 
			this.ownerSwitch.BeginInit();
			this.ownerSwitch.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.05D, 0D, 0D, 0.05D, -60D, -60D);
			this.ownerSwitch.ExternalAvailable = false;
			this.ownerSwitch.InstanceName = "";
			this.ownerSwitch.Name = "ownerSwitch";
			this.ownerSwitch.SecOwner = 0;
			this.ownerSwitch.EndInit();
			// 
			// FbStatus
			// 
			this.FbStatus.BeginInit();
			this.FbStatus.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.FbStatus.IsOnlyInput = true;
			this.FbStatus.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.FbStatus.Name = "FbStatus";
			this.FbStatus.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.FbStatus.TagName = "FbStatus";
			this.FbStatus.Value = ((short)(0));
			this.FbStatus.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.FbStatusValueChanged);
			this.FbStatus.EndInit();
			// 
			// TransFbStatus
			// 
			this.TransFbStatus.BeginInit();
			this.TransFbStatus.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.TransFbStatus.IsOnlyInput = true;
			this.TransFbStatus.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.TransFbStatus.Name = "TransFbStatus";
			this.TransFbStatus.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.TransFbStatus.TagName = "TransFbStatus";
			this.TransFbStatus.Value = ((short)(0));
			this.TransFbStatus.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.TransFbStatusValueChanged);
			this.TransFbStatus.EndInit();
			// 
			// SpeedFbStatus
			// 
			this.SpeedFbStatus.BeginInit();
			this.SpeedFbStatus.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.SpeedFbStatus.IsOnlyInput = true;
			this.SpeedFbStatus.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.SpeedFbStatus.Name = "SpeedFbStatus";
			this.SpeedFbStatus.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.SpeedFbStatus.TagName = "SpeedFbStatus";
			this.SpeedFbStatus.Value = 0F;
			this.SpeedFbStatus.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.SpeedFbStatusValueChanged);
			this.SpeedFbStatus.EndInit();
			// 
			// CurrentSp
			// 
			this.CurrentSp.BeginInit();
			this.CurrentSp.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.CurrentSp.IsOnlyInput = true;
			this.CurrentSp.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.CurrentSp.Name = "CurrentSp";
			this.CurrentSp.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.CurrentSp.TagName = "CurrentSp";
			this.CurrentSp.Value = ((short)(0));
			this.CurrentSp.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.CurrentSpValueChanged);
			this.CurrentSp.EndInit();
			// 
			// CurrentSpeedSp
			// 
			this.CurrentSpeedSp.BeginInit();
			this.CurrentSpeedSp.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.CurrentSpeedSp.IsOnlyInput = true;
			this.CurrentSpeedSp.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.CurrentSpeedSp.Name = "CurrentSpeedSp";
			this.CurrentSpeedSp.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.CurrentSpeedSp.TagName = "CurrentSpeedSp";
			this.CurrentSpeedSp.Value = 0F;
			this.CurrentSpeedSp.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.CurrentSpeedSpValueChanged);
			this.CurrentSpeedSp.EndInit();
			// 
			// CurrentSpeedOp
			// 
			this.CurrentSpeedOp.BeginInit();
			this.CurrentSpeedOp.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.CurrentSpeedOp.IsOnlyInput = true;
			this.CurrentSpeedOp.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.CurrentSpeedOp.Name = "CurrentSpeedOp";
			this.CurrentSpeedOp.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.CurrentSpeedOp.TagName = "CurrentSpeedOp";
			this.CurrentSpeedOp.Value = 0F;
			this.CurrentSpeedOp.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.CurrentSpeedOpValueChanged);
			this.CurrentSpeedOp.EndInit();
			// 
			// CurrentOwner
			// 
			this.CurrentOwner.BeginInit();
			this.CurrentOwner.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.CurrentOwner.IsOnlyInput = true;
			this.CurrentOwner.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.CurrentOwner.Name = "CurrentOwner";
			this.CurrentOwner.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.CurrentOwner.TagName = "CurrentOwner";
			this.CurrentOwner.Value = ((ushort)(0));
			this.CurrentOwner.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.CurrentOwnerValueChanged);
			this.CurrentOwner.EndInit();
			// 
			// CurrentSpeedOwner
			// 
			this.CurrentSpeedOwner.BeginInit();
			this.CurrentSpeedOwner.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.CurrentSpeedOwner.IsOnlyInput = true;
			this.CurrentSpeedOwner.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.CurrentSpeedOwner.Name = "CurrentSpeedOwner";
			this.CurrentSpeedOwner.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.CurrentSpeedOwner.TagName = "CurrentSpeedOwner";
			this.CurrentSpeedOwner.Value = ((ushort)(0));
			this.CurrentSpeedOwner.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.CurrentSpeedOwnerValueChanged);
			this.CurrentSpeedOwner.EndInit();
			// 
			// NeedReset
			// 
			this.NeedReset.BeginInit();
			this.NeedReset.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.NeedReset.IsOnlyInput = true;
			this.NeedReset.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.NeedReset.Name = "NeedReset";
			this.NeedReset.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.NeedReset.TagName = "NeedReset";
			this.NeedReset.Value = false;
			this.NeedReset.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.NeedResetValueChanged);
			this.NeedReset.EndInit();
			// 
			// StdOwnerConnected
			// 
			this.StdOwnerConnected.BeginInit();
			this.StdOwnerConnected.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.StdOwnerConnected.IsOnlyInput = true;
			this.StdOwnerConnected.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.StdOwnerConnected.Name = "StdOwnerConnected";
			this.StdOwnerConnected.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.StdOwnerConnected.TagName = "StdOwnerConnected";
			this.StdOwnerConnected.Value = false;
			this.StdOwnerConnected.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.StdOwnerConnectedValueChanged);
			this.StdOwnerConnected.EndInit();
			// 
			// Maintenance
			// 
			this.Maintenance.BeginInit();
			this.Maintenance.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.Maintenance.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.Maintenance.Name = "Maintenance";
			this.Maintenance.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.Maintenance.TagName = "Maintenance";
			this.Maintenance.Value = false;
			this.Maintenance.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.MaintenanceValueChanged);
			this.Maintenance.EndInit();
			// 
			// OutOfService
			// 
			this.OutOfService.BeginInit();
			this.OutOfService.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.OutOfService.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.OutOfService.Name = "OutOfService";
			this.OutOfService.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.OutOfService.TagName = "OutOfService";
			this.OutOfService.Value = false;
			this.OutOfService.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.OutOfServiceValueChanged);
			this.OutOfService.EndInit();
			// 
			// FbOverride
			// 
			this.FbOverride.BeginInit();
			this.FbOverride.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.FbOverride.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.FbOverride.Name = "FbOverride";
			this.FbOverride.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.FbOverride.TagName = "FbOverride";
			this.FbOverride.Value = false;
			this.FbOverride.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.FbOverrideValueChanged);
			this.FbOverride.EndInit();
			// 
			// Simulation
			// 
			this.Simulation.BeginInit();
			this.Simulation.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.Simulation.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.Simulation.Name = "Simulation";
			this.Simulation.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.Simulation.TagName = "Simulation";
			this.Simulation.Value = false;
			this.Simulation.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.SimulationValueChanged);
			this.Simulation.EndInit();
			// 
			// SpeedSp
			// 
			this.SpeedSp.BeginInit();
			this.SpeedSp.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.SpeedSp.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.SpeedSp.Name = "SpeedSp";
			this.SpeedSp.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.SpeedSp.TagName = "SpeedSp";
			this.SpeedSp.Value = 0F;
			this.SpeedSp.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.SpeedSpValueChanged);
			this.SpeedSp.EndInit();
			// 
			// CurrentSpeedSpMin
			// 
			this.CurrentSpeedSpMin.BeginInit();
			this.CurrentSpeedSpMin.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.CurrentSpeedSpMin.IsOnlyInput = true;
			this.CurrentSpeedSpMin.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.CurrentSpeedSpMin.Name = "CurrentSpeedSpMin";
			this.CurrentSpeedSpMin.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.CurrentSpeedSpMin.TagName = "CurrentSpeedSpMin";
			this.CurrentSpeedSpMin.Value = 0F;
			this.CurrentSpeedSpMin.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.SpeedSpMinValueChanged);
			this.CurrentSpeedSpMin.EndInit();
			// 
			// CurrentSpeedSpMax
			// 
			this.CurrentSpeedSpMax.BeginInit();
			this.CurrentSpeedSpMax.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.CurrentSpeedSpMax.IsOnlyInput = true;
			this.CurrentSpeedSpMax.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.CurrentSpeedSpMax.Name = "CurrentSpeedSpMax";
			this.CurrentSpeedSpMax.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.CurrentSpeedSpMax.TagName = "CurrentSpeedSpMax";
			this.CurrentSpeedSpMax.Value = 0F;
			this.CurrentSpeedSpMax.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.SpeedSpMaxValueChanged);
			this.CurrentSpeedSpMax.EndInit();
			// 
			// DisReverse
			// 
			this.DisReverse.BeginInit();
			this.DisReverse.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.DisReverse.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.DisReverse.Name = "DisReverse";
			this.DisReverse.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.DisReverse.TagName = "DisReverse";
			this.DisReverse.Value = false;
			this.DisReverse.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.DisReverseValueChanged);
			this.DisReverse.EndInit();
			// 
			// EnSpeedOwner
			// 
			this.EnSpeedOwner.BeginInit();
			this.EnSpeedOwner.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.EnSpeedOwner.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.EnSpeedOwner.Name = "EnSpeedOwner";
			this.EnSpeedOwner.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.EnSpeedOwner.TagName = "EnSpeedOwner";
			this.EnSpeedOwner.Value = false;
			this.EnSpeedOwner.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.EnSpeedOwnerValueChanged);
			this.EnSpeedOwner.EndInit();
			// 
			// CurrentOp
			// 
			this.CurrentOp.BeginInit();
			this.CurrentOp.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.CurrentOp.IsOnlyInput = true;
			this.CurrentOp.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.CurrentOp.Name = "CurrentOp";
			this.CurrentOp.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.CurrentOp.TagName = "CurrentOp";
			this.CurrentOp.Value = ((short)(0));
			this.CurrentOp.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.CurrentOpValueChanged);
			this.CurrentOp.EndInit();
			// 
			// ExternalControlled
			// 
			this.ExternalControlled.BeginInit();
			this.ExternalControlled.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.ExternalControlled.IsOnlyInput = true;
			this.ExternalControlled.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.ExternalControlled.Name = "ExternalControlled";
			this.ExternalControlled.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.ExternalControlled.TagName = "ExternalControlled";
			this.ExternalControlled.Value = false;
			this.ExternalControlled.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.ExternalControlledValueChanged);
			this.ExternalControlled.EndInit();
			// 
			// SpeedOutMin
			// 
			this.SpeedOutMin.BeginInit();
			this.SpeedOutMin.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.SpeedOutMin.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.SpeedOutMin.Name = "SpeedOutMin";
			this.SpeedOutMin.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.SpeedOutMin.TagName = "SpeedOutMin";
			this.SpeedOutMin.Value = 0F;
			this.SpeedOutMin.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.SpeedOutMinValueChanged);
			this.SpeedOutMin.EndInit();
			// 
			// SpeedOutMax
			// 
			this.SpeedOutMax.BeginInit();
			this.SpeedOutMax.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 396D, 1044D);
			this.SpeedOutMax.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.SpeedOutMax.Name = "SpeedOutMax";
			this.SpeedOutMax.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.SpeedOutMax.TagName = "SpeedOutMax";
			this.SpeedOutMax.Value = 0F;
			this.SpeedOutMax.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.SpeedOutMaxValueChanged);
			this.SpeedOutMax.EndInit();
			// 
			// fpDefault
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(420D)), ((float)(566D)));
			this.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(224)), ((byte)(224)), ((byte)(224))));
			this.FormBorderStyle = NxtControl.GuiFramework.FormBorderStyle.FixedSingle;
			this.SecurityToken = ((uint)(4294967175u));
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.cabecalho,
			this.caixaEstado,
			this.textoEstado,
			this.textoComando,
			this.textoSaida,
			this.lPassivo,
			this.PassiveRemainTime,
			this.lVelReal,
			this.SpeedPvValue,
			this.lVelRef,
			this.SpeedSpValue,
			this.lVelSaida,
			this.SpeedOpValue,
			this.barFundo,
			this.barVal,
			this.barRef,
			this.textoSituacao,
			this.tituloModo,
			this.btnManual,
			this.btnAutomatico,
			this.tituloComando,
			this.btnManualOff,
			this.btnManualForward,
			this.btnManualReverse,
			this.tituloVel,
			this.lRefManual,
			this.txtSp,
			this.lDonoVel,
			this.btnSpeedOwner,
			this.btnReset,
			this.sep,
			this.btnAjustes,
			this.btnGrafico,
			this.btnDiagnostico,
			this.fpNavigationPane,
			this.ownerSwitch,
			this.FbStatus,
			this.TransFbStatus,
			this.SpeedFbStatus,
			this.CurrentSp,
			this.CurrentSpeedSp,
			this.CurrentSpeedOp,
			this.CurrentOwner,
			this.CurrentSpeedOwner,
			this.NeedReset,
			this.StdOwnerConnected,
			this.Maintenance,
			this.OutOfService,
			this.FbOverride,
			this.Simulation,
			this.SpeedSp,
			this.CurrentSpeedSpMin,
			this.CurrentSpeedSpMax,
			this.DisReverse,
			this.EnSpeedOwner,
			this.CurrentOp,
			this.ExternalControlled,
			this.SpeedOutMin,
			this.SpeedOutMax});
			this.Size = new System.Drawing.Size(420, 566);
			this.SecurityOwnerChanged += new SE.App2Base.Faceplates.SEAppLibHMIFaceplate.OnSecurityOwnerChanged(this.FpDefaultSecurityOwnerChanged);
			this.SecurityParameterChanged += new SE.App2Base.Faceplates.SEAppLibHMIFaceplate.OnSecurityParameterChanged(this.FpDefaultSecurityParameterChanged);
			this.SecuritySetpointChanged += new SE.App2Base.Faceplates.SEAppLibHMIFaceplate.OnSecuritySetpointChanged(this.FpDefaultSecuritySetpointChanged);
			this.UpdateOptionalService += new SE.App2Base.Faceplates.SEAppLibHMIFaceplate.OnUpdateOptionalService(this.FpDefaultUpdateOptionalService);

		}
		private NxtControl.GuiFramework.Rectangle cabecalho;
		private NxtControl.GuiFramework.Rectangle caixaEstado;
		private NxtControl.GuiFramework.FreeText textoEstado;
		private NxtControl.GuiFramework.FreeText textoComando;
		private NxtControl.GuiFramework.FreeText textoSaida;
		private NxtControl.GuiFramework.FreeText lPassivo;
		private System.HMI.Symbols.Base.Label<float> PassiveRemainTime;
		private NxtControl.GuiFramework.FreeText lVelReal;
		private System.HMI.Symbols.Base.Label<float> SpeedPvValue;
		private NxtControl.GuiFramework.FreeText lVelRef;
		private System.HMI.Symbols.Base.Label<float> SpeedSpValue;
		private NxtControl.GuiFramework.FreeText lVelSaida;
		private System.HMI.Symbols.Base.Label<float> SpeedOpValue;
		private NxtControl.GuiFramework.Rectangle barFundo;
		private NxtControl.GuiFramework.Rectangle barVal;
		private NxtControl.GuiFramework.Rectangle barRef;
		private NxtControl.GuiFramework.FreeText textoSituacao;
		private NxtControl.GuiFramework.FreeText tituloModo;
		private NxtControl.GuiFramework.DrawnButton btnManual;
		private NxtControl.GuiFramework.DrawnButton btnAutomatico;
		private NxtControl.GuiFramework.FreeText tituloComando;
		private NxtControl.GuiFramework.DrawnButton btnManualOff;
		private NxtControl.GuiFramework.DrawnButton btnManualForward;
		private NxtControl.GuiFramework.DrawnButton btnManualReverse;
		private NxtControl.GuiFramework.FreeText tituloVel;
		private NxtControl.GuiFramework.FreeText lRefManual;
		private System.HMI.Symbols.Base.TextBox<float> txtSp;
		private NxtControl.GuiFramework.FreeText lDonoVel;
		private NxtControl.GuiFramework.TwoStateButton btnSpeedOwner;
		private NxtControl.GuiFramework.DrawnButton btnReset;
		private NxtControl.GuiFramework.Rectangle sep;
		private NxtControl.GuiFramework.DrawnButton btnAjustes;
		private NxtControl.GuiFramework.DrawnButton btnGrafico;
		private NxtControl.GuiFramework.DrawnButton btnDiagnostico;
		private SE.App2Base.Graphics.FpNavigationPane fpNavigationPane;
		private SE.App2Base.Graphics.OwnerSwitchBasic ownerSwitch;
		private System.HMI.Symbols.Base.Execute<short> FbStatus;
		private System.HMI.Symbols.Base.Execute<short> TransFbStatus;
		private System.HMI.Symbols.Base.Execute<float> SpeedFbStatus;
		private System.HMI.Symbols.Base.Execute<short> CurrentSp;
		private System.HMI.Symbols.Base.Execute<float> CurrentSpeedSp;
		private System.HMI.Symbols.Base.Execute<float> CurrentSpeedOp;
		private System.HMI.Symbols.Base.Execute<ushort> CurrentOwner;
		private System.HMI.Symbols.Base.Execute<ushort> CurrentSpeedOwner;
		private System.HMI.Symbols.Base.Execute<bool> NeedReset;
		private System.HMI.Symbols.Base.Execute<bool> StdOwnerConnected;
		private System.HMI.Symbols.Base.Execute<bool> Maintenance;
		private System.HMI.Symbols.Base.Execute<bool> OutOfService;
		private System.HMI.Symbols.Base.Execute<bool> FbOverride;
		private System.HMI.Symbols.Base.Execute<bool> Simulation;
		private System.HMI.Symbols.Base.Execute<float> SpeedSp;
		private System.HMI.Symbols.Base.Execute<float> CurrentSpeedSpMin;
		private System.HMI.Symbols.Base.Execute<float> CurrentSpeedSpMax;
		private System.HMI.Symbols.Base.Execute<bool> DisReverse;
		private System.HMI.Symbols.Base.Execute<bool> EnSpeedOwner;
		private System.HMI.Symbols.Base.Execute<short> CurrentOp;
		private System.HMI.Symbols.Base.Execute<bool> ExternalControlled;
		private System.HMI.Symbols.Base.Execute<float> SpeedOutMin;
		private System.HMI.Symbols.Base.Execute<float> SpeedOutMax;

		#endregion
	}
}
