/*
 * Created by EcoStruxure Automation Expert.
 * User: SESA404904
 * Date: 10/05/2021
 * Time: 10:59 am
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
	/// Summary description for fpParameter.
	/// </summary>
	partial class fpParameter
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.titulo = new NxtControl.GuiFramework.FreeText();
			this.sec0_Supervis = new NxtControl.GuiFramework.FreeText();
			this.lMon = new NxtControl.GuiFramework.FreeText();
			this.txtMonTime = new System.HMI.Symbols.Base.TextBox<int>();
			this.lTrip = new NxtControl.GuiFramework.FreeText();
			this.txtTripTime = new System.HMI.Symbols.Base.TextBox<int>();
			this.lFbReset = new NxtControl.GuiFramework.FreeText();
			this.ConfResetReq = new System.HMI.Symbols.Base.SwitchButton();
			this.lFailReset = new NxtControl.GuiFramework.FreeText();
			this.FailResetReq = new System.HMI.Symbols.Base.SwitchButton();
			this.lPassivo = new NxtControl.GuiFramework.FreeText();
			this.PassiveTime = new System.HMI.Symbols.Base.TextBox<int>();
			this.sec0_Velocida = new NxtControl.GuiFramework.FreeText();
			this.lMinSp = new NxtControl.GuiFramework.FreeText();
			this.txtMinSp = new System.HMI.Symbols.Base.TextBox<float>();
			this.lMaxSp = new NxtControl.GuiFramework.FreeText();
			this.txtMaxSp = new System.HMI.Symbols.Base.TextBox<float>();
			this.lMinOut = new NxtControl.GuiFramework.FreeText();
			this.txtMinOut = new System.HMI.Symbols.Base.TextBox<float>();
			this.lMaxOut = new NxtControl.GuiFramework.FreeText();
			this.txtMaxOut = new System.HMI.Symbols.Base.TextBox<float>();
			this.lDonoVel = new NxtControl.GuiFramework.FreeText();
			this.btnEnSpeedOwner = new System.HMI.Symbols.Base.SwitchButton();
			this.sec1_Modosesp = new NxtControl.GuiFramework.FreeText();
			this.lSim = new NxtControl.GuiFramework.FreeText();
			this.Sim = new System.HMI.Symbols.Base.SwitchButton();
			this.lOver = new NxtControl.GuiFramework.FreeText();
			this.Over = new System.HMI.Symbols.Base.SwitchButton();
			this.lMaint = new NxtControl.GuiFramework.FreeText();
			this.Maint = new System.HMI.Symbols.Base.SwitchButton();
			this.lOos = new NxtControl.GuiFramework.FreeText();
			this.btnOutOfService = new System.HMI.Symbols.Base.SwitchButton();
			this.DisReverse = new System.HMI.Symbols.Base.Execute<bool>();
			this.FbStatus = new System.HMI.Symbols.Base.Execute<short>();
			this.Simulation = new System.HMI.Symbols.Base.Execute<bool>();
			this.FbOverride = new System.HMI.Symbols.Base.Execute<bool>();
			this.Maintenance = new System.HMI.Symbols.Base.Execute<bool>();
			this.SpeedOwner = new System.HMI.Symbols.Base.Execute<bool>();
			this.OutOfService = new System.HMI.Symbols.Base.Execute<bool>();
			this.CurrentOwner = new System.HMI.Symbols.Base.Execute<ushort>();
			this.SpeedSpRangeSel = new System.HMI.Symbols.Base.Execute<bool>();
			this.TransFbStatus = new System.HMI.Symbols.Base.Execute<short>();
			// 
			// titulo
			// 
			this.titulo.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.titulo.Font = new NxtControl.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
			this.titulo.Location = new NxtControl.Drawing.PointF(20D, 12D);
			this.titulo.Name = "titulo";
			this.titulo.Text = "Ajustes do motor";
			// 
			// sec0_Supervis
			// 
			this.sec0_Supervis.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.sec0_Supervis.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.sec0_Supervis.Location = new NxtControl.Drawing.PointF(20D, 48D);
			this.sec0_Supervis.Name = "sec0_Supervis";
			this.sec0_Supervis.Text = "Supervis\u00e3o";
			// 
			// lMon
			// 
			this.lMon.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.lMon.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.lMon.Location = new NxtControl.Drawing.PointF(20D, 77D);
			this.lMon.Name = "lMon";
			this.lMon.Text = "Tempo de monitoramento";
			// 
			// txtMonTime
			// 
			this.txtMonTime.BeginInit();
			this.txtMonTime.DecimalPlacesCount = ((uint)(0u));
			this.txtMonTime.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.8D, 0D, 0D, 1D, 220D, 72D);
			this.txtMonTime.Font = new NxtControl.Drawing.Font("SE.App2Base.Sp");
			this.txtMonTime.MaximumTag = null;
			this.txtMonTime.MinimumTag = null;
			this.txtMonTime.Name = "txtMonTime";
			this.txtMonTime.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.txtMonTime.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.txtMonTime.SecurityLevel = 6;
			this.txtMonTime.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.txtMonTime.Suffix = "s";
			this.txtMonTime.TagName = "MonTime";
			this.txtMonTime.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.txtMonTime.UseInputPad = true;
			this.txtMonTime.UseRange = true;
			this.txtMonTime.Value = 0;
			this.txtMonTime.EndInit();
			// 
			// lTrip
			// 
			this.lTrip.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.lTrip.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.lTrip.Location = new NxtControl.Drawing.PointF(20D, 111D);
			this.lTrip.Name = "lTrip";
			this.lTrip.Text = "Tempo de disparo";
			// 
			// txtTripTime
			// 
			this.txtTripTime.BeginInit();
			this.txtTripTime.DecimalPlacesCount = ((uint)(0u));
			this.txtTripTime.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.8D, 0D, 0D, 1D, 220D, 106D);
			this.txtTripTime.Font = new NxtControl.Drawing.Font("SE.App2Base.Sp");
			this.txtTripTime.MaximumTag = null;
			this.txtTripTime.MinimumTag = null;
			this.txtTripTime.Name = "txtTripTime";
			this.txtTripTime.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.txtTripTime.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.txtTripTime.SecurityLevel = 6;
			this.txtTripTime.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.txtTripTime.Suffix = "s";
			this.txtTripTime.TagName = "TripTime";
			this.txtTripTime.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.txtTripTime.UseInputPad = true;
			this.txtTripTime.UseRange = true;
			this.txtTripTime.Value = 0;
			this.txtTripTime.EndInit();
			// 
			// lFbReset
			// 
			this.lFbReset.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.lFbReset.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.lFbReset.Location = new NxtControl.Drawing.PointF(20D, 145D);
			this.lFbReset.Name = "lFbReset";
			this.lFbReset.Text = "Exige reset: falha de realim.";
			// 
			// ConfResetReq
			// 
			this.ConfResetReq.BeginInit();
			this.ConfResetReq.DesignMatrix = new NxtControl.Drawing.Matrix2D(1.5D, 0D, 0D, 0.9D, 220D, 140D);
			this.ConfResetReq.FalseBrush = new NxtControl.Drawing.Brush("ButtonBrush");
			this.ConfResetReq.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.ConfResetReq.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.ConfResetReq.FalseText = "N\u00e3o";
			this.ConfResetReq.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.ConfResetReq.Name = "ConfResetReq";
			this.ConfResetReq.SecurityLevel = 12;
			this.ConfResetReq.TagName = "ConfResetReq";
			this.ConfResetReq.TrueBrush = new NxtControl.Drawing.Brush("ButtonBrush");
			this.ConfResetReq.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.ConfResetReq.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.ConfResetReq.TrueText = "Sim";
			this.ConfResetReq.Value = false;
			this.ConfResetReq.EndInit();
			// 
			// lFailReset
			// 
			this.lFailReset.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.lFailReset.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.lFailReset.Location = new NxtControl.Drawing.PointF(20D, 179D);
			this.lFailReset.Name = "lFailReset";
			this.lFailReset.Text = "Exige reset: falha do equip.";
			// 
			// FailResetReq
			// 
			this.FailResetReq.BeginInit();
			this.FailResetReq.DesignMatrix = new NxtControl.Drawing.Matrix2D(1.5D, 0D, 0D, 0.9D, 220D, 174D);
			this.FailResetReq.FalseBrush = new NxtControl.Drawing.Brush("ButtonBrush");
			this.FailResetReq.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.FailResetReq.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.FailResetReq.FalseText = "N\u00e3o";
			this.FailResetReq.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.FailResetReq.Name = "FailResetReq";
			this.FailResetReq.SecurityLevel = 12;
			this.FailResetReq.TagName = "FailResetReq";
			this.FailResetReq.TrueBrush = new NxtControl.Drawing.Brush("ButtonBrush");
			this.FailResetReq.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.FailResetReq.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.FailResetReq.TrueText = "Sim";
			this.FailResetReq.Value = false;
			this.FailResetReq.EndInit();
			// 
			// lPassivo
			// 
			this.lPassivo.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.lPassivo.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.lPassivo.Location = new NxtControl.Drawing.PointF(20D, 213D);
			this.lPassivo.Name = "lPassivo";
			this.lPassivo.Text = "Tempo passivo";
			// 
			// PassiveTime
			// 
			this.PassiveTime.BeginInit();
			this.PassiveTime.DecimalPlacesCount = ((uint)(0u));
			this.PassiveTime.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.8D, 0D, 0D, 1D, 220D, 208D);
			this.PassiveTime.Font = new NxtControl.Drawing.Font("SE.App2Base.Sp");
			this.PassiveTime.MaximumTag = null;
			this.PassiveTime.MinimumTag = null;
			this.PassiveTime.Name = "PassiveTime";
			this.PassiveTime.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.PassiveTime.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.PassiveTime.SecurityLevel = 12;
			this.PassiveTime.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.PassiveTime.Suffix = "s";
			this.PassiveTime.TagName = "PassiveTime";
			this.PassiveTime.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.PassiveTime.UseInputPad = true;
			this.PassiveTime.Value = 0;
			this.PassiveTime.EndInit();
			// 
			// sec0_Velocida
			// 
			this.sec0_Velocida.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.sec0_Velocida.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.sec0_Velocida.Location = new NxtControl.Drawing.PointF(20D, 252D);
			this.sec0_Velocida.Name = "sec0_Velocida";
			this.sec0_Velocida.Text = "Velocidade";
			// 
			// lMinSp
			// 
			this.lMinSp.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.lMinSp.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.lMinSp.Location = new NxtControl.Drawing.PointF(20D, 281D);
			this.lMinSp.Name = "lMinSp";
			this.lMinSp.Text = "Refer\u00eancia m\u00ednima";
			// 
			// txtMinSp
			// 
			this.txtMinSp.BeginInit();
			this.txtMinSp.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.8D, 0D, 0D, 1D, 220D, 276D);
			this.txtMinSp.Font = new NxtControl.Drawing.Font("SE.App2Base.Sp");
			this.txtMinSp.MaximumTag = null;
			this.txtMinSp.MinimumTag = null;
			this.txtMinSp.Name = "txtMinSp";
			this.txtMinSp.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.txtMinSp.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.txtMinSp.SecurityLevel = 6;
			this.txtMinSp.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.txtMinSp.TagName = "SpeedSpMin";
			this.txtMinSp.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.txtMinSp.UseInputPad = true;
			this.txtMinSp.Value = 0F;
			this.txtMinSp.EndInit();
			// 
			// lMaxSp
			// 
			this.lMaxSp.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.lMaxSp.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.lMaxSp.Location = new NxtControl.Drawing.PointF(20D, 315D);
			this.lMaxSp.Name = "lMaxSp";
			this.lMaxSp.Text = "Refer\u00eancia m\u00e1xima";
			// 
			// txtMaxSp
			// 
			this.txtMaxSp.BeginInit();
			this.txtMaxSp.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.8D, 0D, 0D, 1D, 220D, 310D);
			this.txtMaxSp.Font = new NxtControl.Drawing.Font("SE.App2Base.Sp");
			this.txtMaxSp.MaximumTag = null;
			this.txtMaxSp.MinimumTag = null;
			this.txtMaxSp.Name = "txtMaxSp";
			this.txtMaxSp.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.txtMaxSp.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.txtMaxSp.SecurityLevel = 6;
			this.txtMaxSp.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.txtMaxSp.TagName = "SpeedSpMax";
			this.txtMaxSp.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.txtMaxSp.UseInputPad = true;
			this.txtMaxSp.Value = 0F;
			this.txtMaxSp.EndInit();
			// 
			// lMinOut
			// 
			this.lMinOut.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.lMinOut.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.lMinOut.Location = new NxtControl.Drawing.PointF(20D, 349D);
			this.lMinOut.Name = "lMinOut";
			this.lMinOut.Text = "Sa\u00edda m\u00ednima";
			// 
			// txtMinOut
			// 
			this.txtMinOut.BeginInit();
			this.txtMinOut.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.8D, 0D, 0D, 1D, 220D, 344D);
			this.txtMinOut.Font = new NxtControl.Drawing.Font("SE.App2Base.Sp");
			this.txtMinOut.MaximumTag = null;
			this.txtMinOut.MinimumTag = null;
			this.txtMinOut.Name = "txtMinOut";
			this.txtMinOut.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.txtMinOut.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.txtMinOut.SecurityLevel = 0;
			this.txtMinOut.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.txtMinOut.TagName = "SpeedOutMin";
			this.txtMinOut.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.txtMinOut.UseInputPad = true;
			this.txtMinOut.Value = 0F;
			this.txtMinOut.EndInit();
			// 
			// lMaxOut
			// 
			this.lMaxOut.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.lMaxOut.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.lMaxOut.Location = new NxtControl.Drawing.PointF(20D, 383D);
			this.lMaxOut.Name = "lMaxOut";
			this.lMaxOut.Text = "Sa\u00edda m\u00e1xima";
			// 
			// txtMaxOut
			// 
			this.txtMaxOut.BeginInit();
			this.txtMaxOut.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.8D, 0D, 0D, 1D, 220D, 378D);
			this.txtMaxOut.Font = new NxtControl.Drawing.Font("SE.App2Base.Sp");
			this.txtMaxOut.MaximumTag = null;
			this.txtMaxOut.MinimumTag = null;
			this.txtMaxOut.Name = "txtMaxOut";
			this.txtMaxOut.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.txtMaxOut.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.txtMaxOut.SecurityLevel = 0;
			this.txtMaxOut.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.txtMaxOut.TagName = "SpeedOutMax";
			this.txtMaxOut.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.txtMaxOut.UseInputPad = true;
			this.txtMaxOut.Value = 0F;
			this.txtMaxOut.EndInit();
			// 
			// lDonoVel
			// 
			this.lDonoVel.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.lDonoVel.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.lDonoVel.Location = new NxtControl.Drawing.PointF(20D, 417D);
			this.lDonoVel.Name = "lDonoVel";
			this.lDonoVel.Text = "Dono da velocidade separado";
			// 
			// btnEnSpeedOwner
			// 
			this.btnEnSpeedOwner.BeginInit();
			this.btnEnSpeedOwner.DesignMatrix = new NxtControl.Drawing.Matrix2D(1.5D, 0D, 0D, 0.9D, 220D, 412D);
			this.btnEnSpeedOwner.FalseBrush = new NxtControl.Drawing.Brush("ButtonBrush");
			this.btnEnSpeedOwner.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.btnEnSpeedOwner.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.btnEnSpeedOwner.FalseText = "N\u00e3o";
			this.btnEnSpeedOwner.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.btnEnSpeedOwner.Name = "btnEnSpeedOwner";
			this.btnEnSpeedOwner.SecurityLevel = 12;
			this.btnEnSpeedOwner.TagName = "EnSpeedOwner";
			this.btnEnSpeedOwner.TrueBrush = new NxtControl.Drawing.Brush("ButtonBrush");
			this.btnEnSpeedOwner.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.btnEnSpeedOwner.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.btnEnSpeedOwner.TrueText = "Sim";
			this.btnEnSpeedOwner.Value = false;
			this.btnEnSpeedOwner.OutputValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.BtnEnSpeedOwnerOutputValueChanged);
			this.btnEnSpeedOwner.EndInit();
			// 
			// sec1_Modosesp
			// 
			this.sec1_Modosesp.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.sec1_Modosesp.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.sec1_Modosesp.Location = new NxtControl.Drawing.PointF(380D, 48D);
			this.sec1_Modosesp.Name = "sec1_Modosesp";
			this.sec1_Modosesp.Text = "Modos especiais";
			// 
			// lSim
			// 
			this.lSim.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.lSim.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.lSim.Location = new NxtControl.Drawing.PointF(380D, 77D);
			this.lSim.Name = "lSim";
			this.lSim.Text = "Simula\u00e7\u00e3o";
			// 
			// Sim
			// 
			this.Sim.BeginInit();
			this.Sim.DesignMatrix = new NxtControl.Drawing.Matrix2D(1.5D, 0D, 0D, 0.9D, 580D, 72D);
			this.Sim.FalseBrush = new NxtControl.Drawing.Brush("ButtonBrush");
			this.Sim.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.Sim.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.Sim.FalseText = "N\u00e3o";
			this.Sim.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.Sim.Name = "Sim";
			this.Sim.SecurityLevel = 12;
			this.Sim.TagName = "Simulation";
			this.Sim.TrueBrush = new NxtControl.Drawing.Brush("ButtonBrush");
			this.Sim.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.Sim.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.Sim.TrueText = "Sim";
			this.Sim.Value = false;
			this.Sim.EndInit();
			// 
			// lOver
			// 
			this.lOver.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.lOver.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.lOver.Location = new NxtControl.Drawing.PointF(380D, 111D);
			this.lOver.Name = "lOver";
			this.lOver.Text = "Realimenta\u00e7\u00e3o for\u00e7ada";
			// 
			// Over
			// 
			this.Over.BeginInit();
			this.Over.DesignMatrix = new NxtControl.Drawing.Matrix2D(1.5D, 0D, 0D, 0.9D, 580D, 106D);
			this.Over.FalseBrush = new NxtControl.Drawing.Brush("ButtonBrush");
			this.Over.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.Over.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.Over.FalseText = "N\u00e3o";
			this.Over.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.Over.Name = "Over";
			this.Over.SecurityLevel = 6;
			this.Over.TagName = "FbOverride";
			this.Over.TrueBrush = new NxtControl.Drawing.Brush("ButtonBrush");
			this.Over.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.Over.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.Over.TrueText = "Sim";
			this.Over.Value = false;
			this.Over.EndInit();
			// 
			// lMaint
			// 
			this.lMaint.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.lMaint.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.lMaint.Location = new NxtControl.Drawing.PointF(380D, 145D);
			this.lMaint.Name = "lMaint";
			this.lMaint.Text = "Manuten\u00e7\u00e3o";
			// 
			// Maint
			// 
			this.Maint.BeginInit();
			this.Maint.DesignMatrix = new NxtControl.Drawing.Matrix2D(1.5D, 0D, 0D, 0.9D, 580D, 140D);
			this.Maint.FalseBrush = new NxtControl.Drawing.Brush("ButtonBrush");
			this.Maint.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.Maint.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.Maint.FalseText = "N\u00e3o";
			this.Maint.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.Maint.Name = "Maint";
			this.Maint.SecurityLevel = 6;
			this.Maint.TagName = "Maintenance";
			this.Maint.TrueBrush = new NxtControl.Drawing.Brush("ButtonBrush");
			this.Maint.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.Maint.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.Maint.TrueText = "Sim";
			this.Maint.Value = false;
			this.Maint.EndInit();
			// 
			// lOos
			// 
			this.lOos.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.lOos.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.lOos.Location = new NxtControl.Drawing.PointF(380D, 179D);
			this.lOos.Name = "lOos";
			this.lOos.Text = "Fora de servi\u00e7o";
			// 
			// btnOutOfService
			// 
			this.btnOutOfService.BeginInit();
			this.btnOutOfService.DesignMatrix = new NxtControl.Drawing.Matrix2D(1.5D, 0D, 0D, 0.9D, 580D, 174D);
			this.btnOutOfService.FalseBrush = new NxtControl.Drawing.Brush("ButtonBrush");
			this.btnOutOfService.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.btnOutOfService.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.btnOutOfService.FalseText = "N\u00e3o";
			this.btnOutOfService.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.btnOutOfService.Name = "btnOutOfService";
			this.btnOutOfService.TagName = "OutOfService";
			this.btnOutOfService.TrueBrush = new NxtControl.Drawing.Brush("ButtonBrush");
			this.btnOutOfService.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.btnOutOfService.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.btnOutOfService.TrueText = "Sim";
			this.btnOutOfService.Value = false;
			this.btnOutOfService.EndInit();
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
			// SpeedOwner
			// 
			this.SpeedOwner.BeginInit();
			this.SpeedOwner.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.SpeedOwner.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.SpeedOwner.Name = "SpeedOwner";
			this.SpeedOwner.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.SpeedOwner.TagName = "SpeedOwner";
			this.SpeedOwner.Value = false;
			this.SpeedOwner.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.SpeedOwnerValueChanged);
			this.SpeedOwner.EndInit();
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
			// SpeedSpRangeSel
			// 
			this.SpeedSpRangeSel.BeginInit();
			this.SpeedSpRangeSel.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.SpeedSpRangeSel.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.SpeedSpRangeSel.Name = "SpeedSpRangeSel";
			this.SpeedSpRangeSel.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.SpeedSpRangeSel.TagName = "SpeedSpRangeSel";
			this.SpeedSpRangeSel.Value = false;
			this.SpeedSpRangeSel.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.SpeedSpRangeSelValueChanged);
			this.SpeedSpRangeSel.EndInit();
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
			// fpParameter
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(720D)), ((float)(456D)));
			this.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(224)), ((byte)(224)), ((byte)(224))));
			this.FormBorderStyle = NxtControl.GuiFramework.FormBorderStyle.FixedSingle;
			this.SecurityToken = ((uint)(4294967175u));
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.titulo,
			this.sec0_Supervis,
			this.lMon,
			this.txtMonTime,
			this.lTrip,
			this.txtTripTime,
			this.lFbReset,
			this.ConfResetReq,
			this.lFailReset,
			this.FailResetReq,
			this.lPassivo,
			this.PassiveTime,
			this.sec0_Velocida,
			this.lMinSp,
			this.txtMinSp,
			this.lMaxSp,
			this.txtMaxSp,
			this.lMinOut,
			this.txtMinOut,
			this.lMaxOut,
			this.txtMaxOut,
			this.lDonoVel,
			this.btnEnSpeedOwner,
			this.sec1_Modosesp,
			this.lSim,
			this.Sim,
			this.lOver,
			this.Over,
			this.lMaint,
			this.Maint,
			this.lOos,
			this.btnOutOfService,
			this.DisReverse,
			this.FbStatus,
			this.Simulation,
			this.FbOverride,
			this.Maintenance,
			this.SpeedOwner,
			this.OutOfService,
			this.CurrentOwner,
			this.SpeedSpRangeSel,
			this.TransFbStatus});
			this.Size = new System.Drawing.Size(720, 456);
			this.SecurityOwnerChanged += new SE.App2Base.Faceplates.SEAppLibHMIFaceplate.OnSecurityOwnerChanged(this.FpParameterSecurityOwnerChanged);
			this.SecurityParameterChanged += new SE.App2Base.Faceplates.SEAppLibHMIFaceplate.OnSecurityParameterChanged(this.FpParameterSecurityParameterChanged);
			this.SecurityModeChanged += new SE.App2Base.Faceplates.SEAppLibHMIFaceplate.OnSecurityModeChanged(this.FpParameterSecurityModeChanged);

		}
		private NxtControl.GuiFramework.FreeText titulo;
		private NxtControl.GuiFramework.FreeText sec0_Supervis;
		private NxtControl.GuiFramework.FreeText lMon;
		private System.HMI.Symbols.Base.TextBox<int> txtMonTime;
		private NxtControl.GuiFramework.FreeText lTrip;
		private System.HMI.Symbols.Base.TextBox<int> txtTripTime;
		private NxtControl.GuiFramework.FreeText lFbReset;
		private System.HMI.Symbols.Base.SwitchButton ConfResetReq;
		private NxtControl.GuiFramework.FreeText lFailReset;
		private System.HMI.Symbols.Base.SwitchButton FailResetReq;
		private NxtControl.GuiFramework.FreeText lPassivo;
		private System.HMI.Symbols.Base.TextBox<int> PassiveTime;
		private NxtControl.GuiFramework.FreeText sec0_Velocida;
		private NxtControl.GuiFramework.FreeText lMinSp;
		private System.HMI.Symbols.Base.TextBox<float> txtMinSp;
		private NxtControl.GuiFramework.FreeText lMaxSp;
		private System.HMI.Symbols.Base.TextBox<float> txtMaxSp;
		private NxtControl.GuiFramework.FreeText lMinOut;
		private System.HMI.Symbols.Base.TextBox<float> txtMinOut;
		private NxtControl.GuiFramework.FreeText lMaxOut;
		private System.HMI.Symbols.Base.TextBox<float> txtMaxOut;
		private NxtControl.GuiFramework.FreeText lDonoVel;
		private System.HMI.Symbols.Base.SwitchButton btnEnSpeedOwner;
		private NxtControl.GuiFramework.FreeText sec1_Modosesp;
		private NxtControl.GuiFramework.FreeText lSim;
		private System.HMI.Symbols.Base.SwitchButton Sim;
		private NxtControl.GuiFramework.FreeText lOver;
		private System.HMI.Symbols.Base.SwitchButton Over;
		private NxtControl.GuiFramework.FreeText lMaint;
		private System.HMI.Symbols.Base.SwitchButton Maint;
		private NxtControl.GuiFramework.FreeText lOos;
		private System.HMI.Symbols.Base.SwitchButton btnOutOfService;
		private System.HMI.Symbols.Base.Execute<bool> DisReverse;
		private System.HMI.Symbols.Base.Execute<short> FbStatus;
		private System.HMI.Symbols.Base.Execute<bool> Simulation;
		private System.HMI.Symbols.Base.Execute<bool> FbOverride;
		private System.HMI.Symbols.Base.Execute<bool> Maintenance;
		private System.HMI.Symbols.Base.Execute<bool> SpeedOwner;
		private System.HMI.Symbols.Base.Execute<bool> OutOfService;
		private System.HMI.Symbols.Base.Execute<ushort> CurrentOwner;
		private System.HMI.Symbols.Base.Execute<bool> SpeedSpRangeSel;
		private System.HMI.Symbols.Base.Execute<short> TransFbStatus;

		#endregion
	}
}
