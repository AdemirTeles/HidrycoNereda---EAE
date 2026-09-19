using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using NxtControl.GuiFramework;

namespace HMI.Main.Faceplates.MotorVsBase
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
			this.ConfResetReq = new System.HMI.Symbols.Base.SwitchButton();
			this.Maint = new System.HMI.Symbols.Base.SwitchButton();
			this.Over = new System.HMI.Symbols.Base.SwitchButton();
			this.Sim = new System.HMI.Symbols.Base.SwitchButton();
			this.FailResetReq = new System.HMI.Symbols.Base.SwitchButton();
			this.PassiveTime = new System.HMI.Symbols.Base.TextBox<int>();
			this.txtMinSp = new System.HMI.Symbols.Base.TextBox<float>();
			this.txtMaxSp = new System.HMI.Symbols.Base.TextBox<float>();
			this.btnEnSpeedOwner = new System.HMI.Symbols.Base.SwitchButton();
			this.txtMonTime = new System.HMI.Symbols.Base.TextBox<int>();
			this.txtTripTime = new System.HMI.Symbols.Base.TextBox<int>();
			this.labelS1 = new SE.App2Base.Graphics.LabelS();
			this.labelS2 = new SE.App2Base.Graphics.LabelS();
			this.labelS3 = new SE.App2Base.Graphics.LabelS();
			this.labelS4 = new SE.App2Base.Graphics.LabelS();
			this.labelS5 = new SE.App2Base.Graphics.LabelS();
			this.labelS6 = new SE.App2Base.Graphics.LabelS();
			this.labelS7 = new SE.App2Base.Graphics.LabelS();
			this.labelS8 = new SE.App2Base.Graphics.LabelS();
			this.labelS9 = new SE.App2Base.Graphics.LabelS();
			this.labelS10 = new SE.App2Base.Graphics.LabelS();
			this.labelS12 = new SE.App2Base.Graphics.LabelS();
			this.DisReverse = new System.HMI.Symbols.Base.Execute<bool>();
			this.txtMinOut = new System.HMI.Symbols.Base.TextBox<float>();
			this.txtMaxOut = new System.HMI.Symbols.Base.TextBox<float>();
			this.labelS16 = new SE.App2Base.Graphics.LabelS();
			this.labelS17 = new SE.App2Base.Graphics.LabelS();
			this.FbStatus = new System.HMI.Symbols.Base.Execute<short>();
			this.Simulation = new System.HMI.Symbols.Base.Execute<bool>();
			this.FbOverride = new System.HMI.Symbols.Base.Execute<bool>();
			this.Maintenance = new System.HMI.Symbols.Base.Execute<bool>();
			this.SpeedOwner = new System.HMI.Symbols.Base.Execute<bool>();
			this.LabelOos = new SE.App2Base.Graphics.LabelS();
			this.btnOutOfService = new System.HMI.Symbols.Base.SwitchButton();
			this.OutOfService = new System.HMI.Symbols.Base.Execute<bool>();
			this.CurrentOwner = new System.HMI.Symbols.Base.Execute<ushort>();
			this.SpeedSpRangeSel = new System.HMI.Symbols.Base.Execute<bool>();
			this.TransFbStatus = new System.HMI.Symbols.Base.Execute<short>();
			this.disReverseAllocGroup = new NxtControl.GuiFramework.Group();
			// 
			// ConfResetReq
			// 
			this.ConfResetReq.BeginInit();
			this.ConfResetReq.DesignMatrix = new NxtControl.Drawing.Matrix2D(1.475D, 0D, 0D, 0.83333333333333348D, 120D, 128D);
			this.ConfResetReq.FalseBrush = new NxtControl.Drawing.Brush("ButtonBrush");
			this.ConfResetReq.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.ConfResetReq.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.ConfResetReq.FalseText = "$key:SE.App2CommonProcess.TxtDisable";
			this.ConfResetReq.FalseTextKey = "SE.App2CommonProcess.TxtDisable";
			this.ConfResetReq.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.ConfResetReq.Name = "ConfResetReq";
			this.ConfResetReq.SecurityLevel = 12;
			this.ConfResetReq.TagName = "ConfResetReq";
			this.ConfResetReq.TrueBrush = new NxtControl.Drawing.Brush("ButtonBrush");
			this.ConfResetReq.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.ConfResetReq.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.ConfResetReq.TrueText = "$key:SE.App2CommonProcess.TxtEnable";
			this.ConfResetReq.TrueTextKey = "SE.App2CommonProcess.TxtEnable";
			this.ConfResetReq.Value = false;
			this.ConfResetReq.EndInit();
			// 
			// Maint
			// 
			this.Maint.BeginInit();
			this.Maint.DesignMatrix = new NxtControl.Drawing.Matrix2D(1.475D, 0D, 0D, 0.83333333333333348D, 120D, 248D);
			this.Maint.FalseBrush = new NxtControl.Drawing.Brush("ButtonBrush");
			this.Maint.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.Maint.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.Maint.FalseText = "$key:SE.App2CommonProcess.TxtDisable";
			this.Maint.FalseTextKey = "SE.App2CommonProcess.TxtDisable";
			this.Maint.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.Maint.Name = "Maint";
			this.Maint.SecurityLevel = 6;
			this.Maint.TagName = "Maintenance";
			this.Maint.TrueBrush = new NxtControl.Drawing.Brush("ButtonBrush");
			this.Maint.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.Maint.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.Maint.TrueText = "$key:SE.App2CommonProcess.TxtEnable";
			this.Maint.TrueTextKey = "SE.App2CommonProcess.TxtEnable";
			this.Maint.Value = false;
			this.Maint.EndInit();
			// 
			// Over
			// 
			this.Over.BeginInit();
			this.Over.DesignMatrix = new NxtControl.Drawing.Matrix2D(1.475D, 0D, 0D, 0.83333333333333348D, 120D, 218D);
			this.Over.FalseBrush = new NxtControl.Drawing.Brush("ButtonBrush");
			this.Over.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.Over.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.Over.FalseText = "$key:SE.App2CommonProcess.TxtDisable";
			this.Over.FalseTextKey = "SE.App2CommonProcess.TxtDisable";
			this.Over.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.Over.Name = "Over";
			this.Over.SecurityLevel = 6;
			this.Over.TagName = "FbOverride";
			this.Over.TrueBrush = new NxtControl.Drawing.Brush("ButtonBrush");
			this.Over.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.Over.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.Over.TrueText = "$key:SE.App2CommonProcess.TxtEnable";
			this.Over.TrueTextKey = "SE.App2CommonProcess.TxtEnable";
			this.Over.Value = false;
			this.Over.EndInit();
			// 
			// Sim
			// 
			this.Sim.BeginInit();
			this.Sim.DesignMatrix = new NxtControl.Drawing.Matrix2D(1.475D, 0D, 0D, 0.83333333333333348D, 120D, 188D);
			this.Sim.FalseBrush = new NxtControl.Drawing.Brush("ButtonBrush");
			this.Sim.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.Sim.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.Sim.FalseText = "$key:SE.App2CommonProcess.TxtDisable";
			this.Sim.FalseTextKey = "SE.App2CommonProcess.TxtDisable";
			this.Sim.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.Sim.Name = "Sim";
			this.Sim.SecurityLevel = 12;
			this.Sim.TagName = "Simulation";
			this.Sim.TrueBrush = new NxtControl.Drawing.Brush("ButtonBrush");
			this.Sim.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.Sim.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.Sim.TrueText = "$key:SE.App2CommonProcess.TxtEnable";
			this.Sim.TrueTextKey = "SE.App2CommonProcess.TxtEnable";
			this.Sim.Value = false;
			this.Sim.EndInit();
			// 
			// FailResetReq
			// 
			this.FailResetReq.BeginInit();
			this.FailResetReq.DesignMatrix = new NxtControl.Drawing.Matrix2D(1.475D, 0D, 0D, 0.83333333333333348D, 120D, 158D);
			this.FailResetReq.FalseBrush = new NxtControl.Drawing.Brush("ButtonBrush");
			this.FailResetReq.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.FailResetReq.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.FailResetReq.FalseText = "$key:SE.App2CommonProcess.TxtDisable";
			this.FailResetReq.FalseTextKey = "SE.App2CommonProcess.TxtDisable";
			this.FailResetReq.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.FailResetReq.Name = "FailResetReq";
			this.FailResetReq.SecurityLevel = 12;
			this.FailResetReq.TagName = "FailResetReq";
			this.FailResetReq.TrueBrush = new NxtControl.Drawing.Brush("ButtonBrush");
			this.FailResetReq.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.FailResetReq.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.FailResetReq.TrueText = "$key:SE.App2CommonProcess.TxtEnable";
			this.FailResetReq.TrueTextKey = "SE.App2CommonProcess.TxtEnable";
			this.FailResetReq.Value = false;
			this.FailResetReq.EndInit();
			// 
			// PassiveTime
			// 
			this.PassiveTime.BeginInit();
			this.PassiveTime.DecimalPlacesCount = ((uint)(0u));
			this.PassiveTime.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.6333333333333333D, 0D, 0D, 1D, 120D, 68D);
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
			// txtMinSp
			// 
			this.txtMinSp.BeginInit();
			this.txtMinSp.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.63333333333333341D, 0D, 0D, 1D, 120D, 308D);
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
			// txtMaxSp
			// 
			this.txtMaxSp.BeginInit();
			this.txtMaxSp.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.63333333333333341D, 0D, 0D, 1D, 120D, 338D);
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
			// btnEnSpeedOwner
			// 
			this.btnEnSpeedOwner.BeginInit();
			this.btnEnSpeedOwner.DesignMatrix = new NxtControl.Drawing.Matrix2D(1.475D, 0D, 0D, 0.83333333333333348D, 120D, 98D);
			this.btnEnSpeedOwner.FalseBrush = new NxtControl.Drawing.Brush("ButtonBrush");
			this.btnEnSpeedOwner.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.btnEnSpeedOwner.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.btnEnSpeedOwner.FalseText = "$key:SE.App2CommonProcess.TxtDisable";
			this.btnEnSpeedOwner.FalseTextKey = "SE.App2CommonProcess.TxtDisable";
			this.btnEnSpeedOwner.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.btnEnSpeedOwner.Name = "btnEnSpeedOwner";
			this.btnEnSpeedOwner.SecurityLevel = 12;
			this.btnEnSpeedOwner.TagName = "EnSpeedOwner";
			this.btnEnSpeedOwner.TrueBrush = new NxtControl.Drawing.Brush("ButtonBrush");
			this.btnEnSpeedOwner.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.btnEnSpeedOwner.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.btnEnSpeedOwner.TrueText = "$key:SE.App2CommonProcess.TxtEnable";
			this.btnEnSpeedOwner.TrueTextKey = "SE.App2CommonProcess.TxtEnable";
			this.btnEnSpeedOwner.Value = false;
			this.btnEnSpeedOwner.OutputValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.BtnEnSpeedOwnerOutputValueChanged);
			this.btnEnSpeedOwner.EndInit();
			// 
			// txtMonTime
			// 
			this.txtMonTime.BeginInit();
			this.txtMonTime.DecimalPlacesCount = ((uint)(0u));
			this.txtMonTime.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.6333333333333333D, 0D, 0D, 1D, 120D, 8D);
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
			// txtTripTime
			// 
			this.txtTripTime.BeginInit();
			this.txtTripTime.DecimalPlacesCount = ((uint)(0u));
			this.txtTripTime.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.6333333333333333D, 0D, 0D, 1D, 120D, 38D);
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
			// labelS1
			// 
			this.labelS1.BeginInit();
			this.labelS1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 5D, 8D);
			this.labelS1.Font = new NxtControl.Drawing.Font("SE.App2Base.LabelFont");
			this.labelS1.Name = "labelS1";
			this.labelS1.NameSpace = "SE.App2CommonProcess";
			this.labelS1.SeperatorVisiblity = true;
			this.labelS1.Text = "Monitoring Time";
			this.labelS1.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.labelS1.TextColor = new NxtControl.Drawing.Color("FpLabelText");
			this.labelS1.TextKey = "LabelMonTime";
			this.labelS1.EndInit();
			// 
			// labelS2
			// 
			this.labelS2.BeginInit();
			this.labelS2.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 4D, 38D);
			this.labelS2.Font = new NxtControl.Drawing.Font("SE.App2Base.LabelFont");
			this.labelS2.Name = "labelS2";
			this.labelS2.NameSpace = "SE.App2CommonProcess";
			this.labelS2.SeperatorVisiblity = true;
			this.labelS2.Text = "Trip Time";
			this.labelS2.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.labelS2.TextColor = new NxtControl.Drawing.Color("FpLabelText");
			this.labelS2.TextKey = "LabelTripTime";
			this.labelS2.EndInit();
			// 
			// labelS3
			// 
			this.labelS3.BeginInit();
			this.labelS3.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 4D, 68D);
			this.labelS3.Font = new NxtControl.Drawing.Font("SE.App2Base.LabelFont");
			this.labelS3.Name = "labelS3";
			this.labelS3.NameSpace = "SE.App2CommonProcess";
			this.labelS3.SeperatorVisiblity = true;
			this.labelS3.Text = "Passive Time";
			this.labelS3.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.labelS3.TextColor = new NxtControl.Drawing.Color("FpLabelText");
			this.labelS3.TextKey = "LabelPassiveTime";
			this.labelS3.EndInit();
			// 
			// labelS4
			// 
			this.labelS4.BeginInit();
			this.labelS4.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 4D, 128D);
			this.labelS4.Font = new NxtControl.Drawing.Font("SE.App2Base.LabelFont");
			this.labelS4.Name = "labelS4";
			this.labelS4.NameSpace = "SE.App2CommonProcess";
			this.labelS4.SeperatorVisiblity = true;
			this.labelS4.Text = "Feedback Reset";
			this.labelS4.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.labelS4.TextColor = new NxtControl.Drawing.Color("FpLabelText");
			this.labelS4.TextKey = "LabelFBReset";
			this.labelS4.EndInit();
			// 
			// labelS5
			// 
			this.labelS5.BeginInit();
			this.labelS5.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 4D, 158D);
			this.labelS5.Font = new NxtControl.Drawing.Font("SE.App2Base.LabelFont");
			this.labelS5.Name = "labelS5";
			this.labelS5.NameSpace = "SE.App2CommonProcess";
			this.labelS5.SeperatorVisiblity = true;
			this.labelS5.Text = "Fail Reset";
			this.labelS5.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.labelS5.TextColor = new NxtControl.Drawing.Color("FpLabelText");
			this.labelS5.TextKey = "LabelFailReset";
			this.labelS5.EndInit();
			// 
			// labelS6
			// 
			this.labelS6.BeginInit();
			this.labelS6.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 4D, 188D);
			this.labelS6.Font = new NxtControl.Drawing.Font("SE.App2Base.LabelFont");
			this.labelS6.Name = "labelS6";
			this.labelS6.NameSpace = "SE.App2CommonProcess";
			this.labelS6.SeperatorVisiblity = true;
			this.labelS6.Text = "Simulation";
			this.labelS6.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.labelS6.TextColor = new NxtControl.Drawing.Color("FpLabelText");
			this.labelS6.TextKey = "LabelSimulation";
			this.labelS6.EndInit();
			// 
			// labelS7
			// 
			this.labelS7.BeginInit();
			this.labelS7.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 4D, 218D);
			this.labelS7.Font = new NxtControl.Drawing.Font("SE.App2Base.LabelFont");
			this.labelS7.Name = "labelS7";
			this.labelS7.NameSpace = "SE.App2CommonProcess";
			this.labelS7.SeperatorVisiblity = true;
			this.labelS7.Text = "Override";
			this.labelS7.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.labelS7.TextColor = new NxtControl.Drawing.Color("FpLabelText");
			this.labelS7.TextKey = "LabelOverride";
			this.labelS7.EndInit();
			// 
			// labelS8
			// 
			this.labelS8.BeginInit();
			this.labelS8.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 4D, 248D);
			this.labelS8.Font = new NxtControl.Drawing.Font("SE.App2Base.LabelFont");
			this.labelS8.Name = "labelS8";
			this.labelS8.NameSpace = "SE.App2CommonProcess";
			this.labelS8.SeperatorVisiblity = true;
			this.labelS8.Text = "Maintenance";
			this.labelS8.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.labelS8.TextColor = new NxtControl.Drawing.Color("FpLabelText");
			this.labelS8.TextKey = "LabelMaint";
			this.labelS8.EndInit();
			// 
			// labelS9
			// 
			this.labelS9.BeginInit();
			this.labelS9.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 4D, 308D);
			this.labelS9.Font = new NxtControl.Drawing.Font("SE.App2Base.LabelFont");
			this.labelS9.Name = "labelS9";
			this.labelS9.NameSpace = "SE.App2CommonProcess";
			this.labelS9.SeperatorVisiblity = true;
			this.labelS9.Text = "Min Sp";
			this.labelS9.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.labelS9.TextColor = new NxtControl.Drawing.Color("FpLabelText");
			this.labelS9.TextKey = "LabelMinSetpoint";
			this.labelS9.EndInit();
			// 
			// labelS10
			// 
			this.labelS10.BeginInit();
			this.labelS10.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 4D, 338D);
			this.labelS10.Font = new NxtControl.Drawing.Font("SE.App2Base.LabelFont");
			this.labelS10.Name = "labelS10";
			this.labelS10.NameSpace = "SE.App2CommonProcess";
			this.labelS10.SeperatorVisiblity = true;
			this.labelS10.Text = "Max Sp";
			this.labelS10.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.labelS10.TextColor = new NxtControl.Drawing.Color("FpLabelText");
			this.labelS10.TextKey = "LabelMaxSetpoint";
			this.labelS10.EndInit();
			// 
			// labelS12
			// 
			this.labelS12.BeginInit();
			this.labelS12.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 4D, 98D);
			this.labelS12.Font = new NxtControl.Drawing.Font("SE.App2Base.LabelFont");
			this.labelS12.Name = "labelS12";
			this.labelS12.NameSpace = "SE.App2CommonProcess";
			this.labelS12.SeperatorVisiblity = true;
			this.labelS12.Text = "Speed Owner";
			this.labelS12.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.labelS12.TextColor = new NxtControl.Drawing.Color("FpLabelText");
			this.labelS12.TextKey = "LabelSpeedOwner";
			this.labelS12.EndInit();
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
			// txtMinOut
			// 
			this.txtMinOut.BeginInit();
			this.txtMinOut.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.63333333333333341D, 0D, 0D, 1D, 120D, 368D);
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
			// txtMaxOut
			// 
			this.txtMaxOut.BeginInit();
			this.txtMaxOut.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.63333333333333341D, 0D, 0D, 1D, 120D, 398D);
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
			// labelS16
			// 
			this.labelS16.BeginInit();
			this.labelS16.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 5D, 368D);
			this.labelS16.Font = new NxtControl.Drawing.Font("SE.App2Base.LabelFont");
			this.labelS16.Name = "labelS16";
			this.labelS16.NameSpace = "SE.App2CommonProcess";
			this.labelS16.SeperatorVisiblity = true;
			this.labelS16.Text = "Min Out";
			this.labelS16.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.labelS16.TextColor = new NxtControl.Drawing.Color("FpLabelText");
			this.labelS16.TextKey = "LabelMinOut";
			this.labelS16.EndInit();
			// 
			// labelS17
			// 
			this.labelS17.BeginInit();
			this.labelS17.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 7D, 398D);
			this.labelS17.Font = new NxtControl.Drawing.Font("SE.App2Base.LabelFont");
			this.labelS17.Name = "labelS17";
			this.labelS17.NameSpace = "SE.App2CommonProcess";
			this.labelS17.SeperatorVisiblity = true;
			this.labelS17.Text = "Max Out";
			this.labelS17.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.labelS17.TextColor = new NxtControl.Drawing.Color("FpLabelText");
			this.labelS17.TextKey = "LabelMaxOut";
			this.labelS17.EndInit();
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
			// LabelOos
			// 
			this.LabelOos.BeginInit();
			this.LabelOos.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 5D, 278D);
			this.LabelOos.Font = new NxtControl.Drawing.Font("SE.App2Base.LabelFont");
			this.LabelOos.Name = "LabelOos";
			this.LabelOos.NameSpace = "SE.App2CommonProcess";
			this.LabelOos.SeperatorVisiblity = true;
			this.LabelOos.Text = "Out of Service";
			this.LabelOos.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.LabelOos.TextColor = new NxtControl.Drawing.Color("FpLabelText");
			this.LabelOos.TextKey = "LabelOOS";
			this.LabelOos.EndInit();
			// 
			// btnOutOfService
			// 
			this.btnOutOfService.BeginInit();
			this.btnOutOfService.DesignMatrix = new NxtControl.Drawing.Matrix2D(1.475D, 0D, 0D, 0.83333333333333348D, 120D, 278D);
			this.btnOutOfService.FalseBrush = new NxtControl.Drawing.Brush("ButtonBrush");
			this.btnOutOfService.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.btnOutOfService.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.btnOutOfService.FalseText = "$key:SE.App2CommonProcess.TxtDisable";
			this.btnOutOfService.FalseTextKey = "SE.App2CommonProcess.TxtDisable";
			this.btnOutOfService.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.btnOutOfService.Name = "btnOutOfService";
			this.btnOutOfService.TagName = "OutOfService";
			this.btnOutOfService.TrueBrush = new NxtControl.Drawing.Brush("ButtonBrush");
			this.btnOutOfService.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.btnOutOfService.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.btnOutOfService.TrueText = "$key:SE.App2CommonProcess.TxtEnable";
			this.btnOutOfService.TrueTextKey = "SE.App2CommonProcess.TxtEnable";
			this.btnOutOfService.Value = false;
			this.btnOutOfService.EndInit();
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
			// disReverseAllocGroup
			// 
			this.disReverseAllocGroup.BeginInit();
			this.disReverseAllocGroup.Name = "disReverseAllocGroup";
			this.disReverseAllocGroup.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.btnOutOfService,
			this.ConfResetReq,
			this.FailResetReq,
			this.Sim,
			this.Over,
			this.Maint,
			this.txtMinSp,
			this.txtMaxSp,
			this.labelS4,
			this.labelS5,
			this.labelS6,
			this.labelS7,
			this.labelS8,
			this.labelS9,
			this.labelS10,
			this.btnEnSpeedOwner,
			this.labelS12,
			this.txtMinOut,
			this.txtMaxOut,
			this.labelS16,
			this.labelS17,
			this.LabelOos});
			this.disReverseAllocGroup.EndInit();
			// 
			// fpParameter
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(275D)), ((float)(446D)));
			this.Brush = new NxtControl.Drawing.Brush("FpBackgroundBrush");
			this.FormBorderStyle = NxtControl.GuiFramework.FormBorderStyle.FixedSingle;
			this.SecurityToken = ((uint)(4294967199u));
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.PassiveTime,
			this.txtMonTime,
			this.txtTripTime,
			this.labelS1,
			this.labelS2,
			this.labelS3,
			this.DisReverse,
			this.FbStatus,
			this.Simulation,
			this.FbOverride,
			this.Maintenance,
			this.SpeedOwner,
			this.disReverseAllocGroup,
			this.OutOfService,
			this.CurrentOwner,
			this.SpeedSpRangeSel,
			this.TransFbStatus});
			this.Size = new System.Drawing.Size(275, 446);
			this.SecurityOwnerChanged += new SE.App2Base.Faceplates.SEAppLibHMIFaceplate.OnSecurityOwnerChanged(this.FpParameterSecurityOwnerChanged);
			this.SecurityParameterChanged += new SE.App2Base.Faceplates.SEAppLibHMIFaceplate.OnSecurityParameterChanged(this.FpParameterSecurityParameterChanged);
			this.SecurityModeChanged += new SE.App2Base.Faceplates.SEAppLibHMIFaceplate.OnSecurityModeChanged(this.FpParameterSecurityModeChanged);

		}
		private System.HMI.Symbols.Base.SwitchButton ConfResetReq;
		private System.HMI.Symbols.Base.SwitchButton Maint;
		private System.HMI.Symbols.Base.SwitchButton Over;
		private System.HMI.Symbols.Base.SwitchButton Sim;
		private System.HMI.Symbols.Base.SwitchButton FailResetReq;
		private System.HMI.Symbols.Base.TextBox<int> PassiveTime;
		private System.HMI.Symbols.Base.TextBox<float> txtMinSp;
		private System.HMI.Symbols.Base.TextBox<float> txtMaxSp;
		private System.HMI.Symbols.Base.SwitchButton btnEnSpeedOwner;
		private System.HMI.Symbols.Base.TextBox<int> txtMonTime;
		private System.HMI.Symbols.Base.TextBox<int> txtTripTime;
		private SE.App2Base.Graphics.LabelS labelS1;
		private SE.App2Base.Graphics.LabelS labelS2;
		private SE.App2Base.Graphics.LabelS labelS3;
		private SE.App2Base.Graphics.LabelS labelS4;
		private SE.App2Base.Graphics.LabelS labelS5;
		private SE.App2Base.Graphics.LabelS labelS6;
		private SE.App2Base.Graphics.LabelS labelS7;
		private SE.App2Base.Graphics.LabelS labelS8;
		private SE.App2Base.Graphics.LabelS labelS9;
		private SE.App2Base.Graphics.LabelS labelS10;
		private SE.App2Base.Graphics.LabelS labelS12;
		private System.HMI.Symbols.Base.Execute<bool> DisReverse;
		private System.HMI.Symbols.Base.TextBox<float> txtMinOut;
		private System.HMI.Symbols.Base.TextBox<float> txtMaxOut;
		private SE.App2Base.Graphics.LabelS labelS16;
		private SE.App2Base.Graphics.LabelS labelS17;
		private System.HMI.Symbols.Base.Execute<short> FbStatus;
		private System.HMI.Symbols.Base.Execute<bool> Simulation;
		private System.HMI.Symbols.Base.Execute<bool> FbOverride;
		private System.HMI.Symbols.Base.Execute<bool> Maintenance;
		private System.HMI.Symbols.Base.Execute<bool> SpeedOwner;
		private SE.App2Base.Graphics.LabelS LabelOos;
		private NxtControl.GuiFramework.Group disReverseAllocGroup;
		private System.HMI.Symbols.Base.SwitchButton btnOutOfService;
		private System.HMI.Symbols.Base.Execute<bool> OutOfService;
		private System.HMI.Symbols.Base.Execute<ushort> CurrentOwner;
		private System.HMI.Symbols.Base.Execute<bool> SpeedSpRangeSel;
		private System.HMI.Symbols.Base.Execute<short> TransFbStatus;
		#endregion
	}
}



