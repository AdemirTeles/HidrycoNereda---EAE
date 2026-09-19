using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using NxtControl.GuiFramework;

namespace HMI.Main.Faceplates.PIDBase
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
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary2 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary1 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary4 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary3 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary6 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary5 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary8 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary7 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary10 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary9 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary12 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary11 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary14 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary13 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary16 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary17 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary15 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary19 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary20 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary18 = new NxtControl.GuiFramework.PropertyDictionary();
			this.txtGain = new System.HMI.Symbols.Base.TextBox<float>();
			this.txtIntegralTime = new System.HMI.Symbols.Base.TextBox<float>();
			this.txtDerivativeTime = new System.HMI.Symbols.Base.TextBox<float>();
			this.txtLagTime = new System.HMI.Symbols.Base.TextBox<float>();
			this.txtDeadband = new System.HMI.Symbols.Base.TextBox<float>();
			this.txtFeedFwdGain = new System.HMI.Symbols.Base.TextBox<float>();
			this.txtSpRateUp = new System.HMI.Symbols.Base.TextBox<float>();
			this.txtSpRateDn = new System.HMI.Symbols.Base.TextBox<float>();
			this.txtOutMin = new System.HMI.Symbols.Base.TextBox<float>();
			this.txtOutMax = new System.HMI.Symbols.Base.TextBox<float>();
			this.btnFeedFwdOn = new System.HMI.Symbols.Base.SwitchButton();
			this.btnDWorkOnError = new System.HMI.Symbols.Base.SwitchButton();
			this.btnTrackSpInMan = new System.HMI.Symbols.Base.SwitchButton();
			this.btnDirection = new System.HMI.Symbols.Base.SwitchButton();
			this.txtCycleTime = new System.HMI.Symbols.Base.TextBox<int>();
			this.CurrentGain = new System.HMI.Symbols.Base.Label<float>();
			this.CurrentDerivativeTime = new System.HMI.Symbols.Base.Label<float>();
			this.CurrentLagTime = new System.HMI.Symbols.Base.Label<float>();
			this.CurrentDeadBand = new System.HMI.Symbols.Base.Label<float>();
			this.CurrentOutMin = new System.HMI.Symbols.Base.Label<float>();
			this.CurrentOutMax = new System.HMI.Symbols.Base.Label<float>();
			this.CurrentIntegralTime = new System.HMI.Symbols.Base.Label<float>();
			this.CurrentDWorkOnError = new System.HMI.Symbols.Base.Label<bool>();
			this.CurrentDirection = new System.HMI.Symbols.Base.Label<bool>();
			this.btnBump = new System.HMI.Symbols.Base.SwitchButton();
			this.txtOutputBias = new System.HMI.Symbols.Base.TextBox<float>();
			this.CurrentMode = new System.HMI.Symbols.Base.Execute<short>();
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
			this.labelS11 = new SE.App2Base.Graphics.LabelS();
			this.labelS12 = new SE.App2Base.Graphics.LabelS();
			this.labelS13 = new SE.App2Base.Graphics.LabelS();
			this.labelS14 = new SE.App2Base.Graphics.LabelS();
			this.labelS15 = new SE.App2Base.Graphics.LabelS();
			this.labelS16 = new SE.App2Base.Graphics.LabelS();
			this.labelS17 = new SE.App2Base.Graphics.LabelS();
			this.ExtParaSel = new System.HMI.Symbols.Base.Execute<bool>();
			this.CurrentOutbias = new System.HMI.Symbols.Base.Execute<float>();
			this.CurrentGain_1 = new System.HMI.Symbols.Base.Execute<float>();
			this.CurrentIntegralTime_1 = new System.HMI.Symbols.Base.Execute<float>();
			this.Gain = new System.HMI.Symbols.Base.Execute<float>();
			this.IntegralTime = new System.HMI.Symbols.Base.Execute<float>();
			this.CurrentDerivativeTime_1 = new System.HMI.Symbols.Base.Execute<float>();
			this.DerivativeTime = new System.HMI.Symbols.Base.Execute<float>();
			this.OutRate = new System.HMI.Symbols.Base.TextBox<float>();
			this.Gain_kp = new System.HMI.Symbols.Base.TextBox<float>();
			this.Ovs_att = new System.HMI.Symbols.Base.TextBox<float>();
			this.labelS18 = new SE.App2Base.Graphics.LabelS();
			this.labelS19 = new SE.App2Base.Graphics.LabelS();
			this.labelS20 = new SE.App2Base.Graphics.LabelS();
			// 
			// txtGain
			// 
			this.txtGain.BeginInit();
			this.txtGain.DecimalPlacesCount = ((uint)(5u));
			this.txtGain.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.6333333333333333D, 0D, 0D, 1D, 139D, 8D);
			this.txtGain.Font = new NxtControl.Drawing.Font("SE.App2Base.Sp");
			this.txtGain.IsPrefixSuffixOutside = false;
			this.txtGain.Maximum = 10000F;
			this.txtGain.MaximumTag = null;
			this.txtGain.MinimumTag = null;
			this.txtGain.Name = "txtGain";
			this.txtGain.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.txtGain.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.txtGain.SecurityLevel = 12;
			this.txtGain.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.txtGain.TagName = "Gain";
			this.txtGain.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.txtGain.UseInputPad = true;
			this.txtGain.UseRange = true;
			this.txtGain.Value = 0F;
			this.txtGain.EndInit();
			// 
			// txtIntegralTime
			// 
			this.txtIntegralTime.BeginInit();
			this.txtIntegralTime.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.6333333333333333D, 0D, 0D, 0.64000000000000012D, 139D, 38D);
			this.txtIntegralTime.Font = new NxtControl.Drawing.Font("SE.App2Base.Sp");
			this.txtIntegralTime.Maximum = 100000F;
			this.txtIntegralTime.MaximumTag = null;
			this.txtIntegralTime.MinimumTag = null;
			this.txtIntegralTime.Name = "txtIntegralTime";
			this.txtIntegralTime.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.txtIntegralTime.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.txtIntegralTime.SecurityLevel = 12;
			this.txtIntegralTime.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.txtIntegralTime.Suffix = "s";
			this.txtIntegralTime.TagName = "IntegralTime";
			this.txtIntegralTime.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.txtIntegralTime.UseInputPad = true;
			this.txtIntegralTime.UseRange = true;
			this.txtIntegralTime.Value = 0F;
			this.txtIntegralTime.EndInit();
			// 
			// txtDerivativeTime
			// 
			this.txtDerivativeTime.BeginInit();
			this.txtDerivativeTime.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.6333333333333333D, 0D, 0D, 0.64000000000000012D, 139D, 68D);
			this.txtDerivativeTime.Font = new NxtControl.Drawing.Font("SE.App2Base.Sp");
			this.txtDerivativeTime.Maximum = 100000F;
			this.txtDerivativeTime.MaximumTag = null;
			this.txtDerivativeTime.MinimumTag = null;
			this.txtDerivativeTime.Name = "txtDerivativeTime";
			this.txtDerivativeTime.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.txtDerivativeTime.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.txtDerivativeTime.SecurityLevel = 12;
			this.txtDerivativeTime.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.txtDerivativeTime.Suffix = "s";
			this.txtDerivativeTime.TagName = "DerivativeTime";
			this.txtDerivativeTime.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.txtDerivativeTime.UseInputPad = true;
			this.txtDerivativeTime.UseRange = true;
			this.txtDerivativeTime.Value = 0F;
			this.txtDerivativeTime.EndInit();
			// 
			// txtLagTime
			// 
			this.txtLagTime.BeginInit();
			this.txtLagTime.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.6333333333333333D, 0D, 0D, 0.64000000000000012D, 139D, 98D);
			this.txtLagTime.Font = new NxtControl.Drawing.Font("SE.App2Base.Sp");
			this.txtLagTime.Maximum = 100000F;
			this.txtLagTime.MaximumTag = null;
			this.txtLagTime.MinimumTag = null;
			this.txtLagTime.Name = "txtLagTime";
			this.txtLagTime.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.txtLagTime.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.txtLagTime.SecurityLevel = 12;
			this.txtLagTime.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.txtLagTime.Suffix = "s";
			this.txtLagTime.TagName = "LagTime";
			this.txtLagTime.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.txtLagTime.UseInputPad = true;
			this.txtLagTime.UseRange = true;
			this.txtLagTime.Value = 0F;
			this.txtLagTime.EndInit();
			// 
			// txtDeadband
			// 
			this.txtDeadband.BeginInit();
			this.txtDeadband.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.6333333333333333D, 0D, 0D, 0.64000000000000012D, 139D, 128D);
			this.txtDeadband.Font = new NxtControl.Drawing.Font("SE.App2Base.Sp");
			this.txtDeadband.Maximum = 100000F;
			this.txtDeadband.MaximumTag = null;
			this.txtDeadband.MinimumTag = null;
			this.txtDeadband.Name = "txtDeadband";
			this.txtDeadband.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.txtDeadband.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.txtDeadband.SecurityLevel = 12;
			this.txtDeadband.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.txtDeadband.TagName = "DeadBand";
			this.txtDeadband.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.txtDeadband.UseInputPad = true;
			this.txtDeadband.UseRange = true;
			this.txtDeadband.Value = 0F;
			this.txtDeadband.EndInit();
			// 
			// txtFeedFwdGain
			// 
			this.txtFeedFwdGain.BeginInit();
			this.txtFeedFwdGain.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.6333333333333333D, 0D, 0D, 0.64000000000000012D, 139D, 248D);
			this.txtFeedFwdGain.Font = new NxtControl.Drawing.Font("SE.App2Base.Sp");
			this.txtFeedFwdGain.IsPrefixSuffixOutside = false;
			this.txtFeedFwdGain.MaximumTag = null;
			this.txtFeedFwdGain.MinimumTag = null;
			this.txtFeedFwdGain.Name = "txtFeedFwdGain";
			this.txtFeedFwdGain.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.txtFeedFwdGain.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.txtFeedFwdGain.SecurityLevel = 12;
			this.txtFeedFwdGain.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.txtFeedFwdGain.TagName = "FeedFwdGain";
			this.txtFeedFwdGain.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.txtFeedFwdGain.UseInputPad = true;
			this.txtFeedFwdGain.Value = 0F;
			this.txtFeedFwdGain.EndInit();
			// 
			// txtSpRateUp
			// 
			this.txtSpRateUp.BeginInit();
			this.txtSpRateUp.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.6333333333333333D, 0D, 0D, 0.64000000000000012D, 139D, 308D);
			this.txtSpRateUp.Font = new NxtControl.Drawing.Font("SE.App2Base.Sp");
			this.txtSpRateUp.IsPrefixSuffixOutside = false;
			this.txtSpRateUp.Maximum = 100000F;
			this.txtSpRateUp.MaximumTag = null;
			this.txtSpRateUp.MinimumTag = null;
			this.txtSpRateUp.Name = "txtSpRateUp";
			this.txtSpRateUp.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.txtSpRateUp.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.txtSpRateUp.SecurityLevel = 12;
			this.txtSpRateUp.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.txtSpRateUp.TagName = "SpRateUp";
			this.txtSpRateUp.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.txtSpRateUp.UseInputPad = true;
			this.txtSpRateUp.UseRange = true;
			this.txtSpRateUp.Value = 0F;
			this.txtSpRateUp.EndInit();
			// 
			// txtSpRateDn
			// 
			this.txtSpRateDn.BeginInit();
			this.txtSpRateDn.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.6333333333333333D, 0D, 0D, 0.64000000000000012D, 139D, 337D);
			this.txtSpRateDn.Font = new NxtControl.Drawing.Font("SE.App2Base.Sp");
			this.txtSpRateDn.IsPrefixSuffixOutside = false;
			this.txtSpRateDn.Maximum = 100000F;
			this.txtSpRateDn.MaximumTag = null;
			this.txtSpRateDn.MinimumTag = null;
			this.txtSpRateDn.Name = "txtSpRateDn";
			this.txtSpRateDn.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.txtSpRateDn.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.txtSpRateDn.SecurityLevel = 12;
			this.txtSpRateDn.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.txtSpRateDn.TagName = "SpRateDown";
			this.txtSpRateDn.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.txtSpRateDn.UseInputPad = true;
			this.txtSpRateDn.UseRange = true;
			this.txtSpRateDn.Value = 0F;
			this.txtSpRateDn.EndInit();
			// 
			// txtOutMin
			// 
			this.txtOutMin.BeginInit();
			this.txtOutMin.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.6333333333333333D, 0D, 0D, 0.64000000000000012D, 139D, 368D);
			this.txtOutMin.Font = new NxtControl.Drawing.Font("SE.App2Base.Sp");
			this.txtOutMin.Maximum = 100000F;
			this.txtOutMin.MaximumTag = null;
			this.txtOutMin.Minimum = -100000F;
			this.txtOutMin.MinimumTag = null;
			this.txtOutMin.Name = "txtOutMin";
			this.txtOutMin.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.txtOutMin.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.txtOutMin.SecurityLevel = 12;
			this.txtOutMin.SendValueOnLostFocus = true;
			this.txtOutMin.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.txtOutMin.TagName = "OutMin";
			this.txtOutMin.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.txtOutMin.UseInputPad = true;
			this.txtOutMin.Value = 0F;
			this.txtOutMin.EndInit();
			// 
			// txtOutMax
			// 
			this.txtOutMax.BeginInit();
			this.txtOutMax.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.6333333333333333D, 0D, 0D, 0.64000000000000012D, 139D, 398D);
			this.txtOutMax.Font = new NxtControl.Drawing.Font("SE.App2Base.Sp");
			this.txtOutMax.Maximum = 100000F;
			this.txtOutMax.MaximumTag = null;
			this.txtOutMax.Minimum = -100000F;
			this.txtOutMax.MinimumTag = null;
			this.txtOutMax.Name = "txtOutMax";
			this.txtOutMax.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.txtOutMax.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.txtOutMax.SecurityLevel = 12;
			this.txtOutMax.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.txtOutMax.TagName = "OutMax";
			this.txtOutMax.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.txtOutMax.UseInputPad = true;
			this.txtOutMax.Value = 0F;
			this.txtOutMax.EndInit();
			// 
			// btnFeedFwdOn
			// 
			this.btnFeedFwdOn.BeginInit();
			this.btnFeedFwdOn.DesignMatrix = new NxtControl.Drawing.Matrix2D(1.475D, 0D, 0D, 0.83333333333333259D, 139D, 218D);
			this.btnFeedFwdOn.FalseBrush = new NxtControl.Drawing.Brush("ButtonBrush");
			this.btnFeedFwdOn.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.btnFeedFwdOn.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.btnFeedFwdOn.FalseText = "$key:SE.App2CommonProcess.TxtDisable";
			this.btnFeedFwdOn.FalseTextKey = "SE.App2CommonProcess.TxtDisable";
			this.btnFeedFwdOn.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.btnFeedFwdOn.Name = "btnFeedFwdOn";
			this.btnFeedFwdOn.SecurityLevel = 12;
			this.btnFeedFwdOn.TagName = "EnFeedFwd";
			this.btnFeedFwdOn.TrueBrush = new NxtControl.Drawing.Brush("ButtonBrush");
			this.btnFeedFwdOn.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.btnFeedFwdOn.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.btnFeedFwdOn.TrueText = "$key:SE.App2CommonProcess.TxtEnable";
			this.btnFeedFwdOn.TrueTextKey = "SE.App2CommonProcess.TxtEnable";
			this.btnFeedFwdOn.Value = false;
			this.btnFeedFwdOn.EndInit();
			// 
			// btnDWorkOnError
			// 
			this.btnDWorkOnError.BeginInit();
			this.btnDWorkOnError.DesignMatrix = new NxtControl.Drawing.Matrix2D(1.475D, 0D, 0D, 0.83333333333333348D, 139D, 158D);
			this.btnDWorkOnError.FalseBrush = new NxtControl.Drawing.Brush("ButtonBrush");
			this.btnDWorkOnError.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.btnDWorkOnError.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.btnDWorkOnError.FalseText = "$key:SE.App2CommonProcess.TxtDisable";
			this.btnDWorkOnError.FalseTextKey = "SE.App2CommonProcess.TxtDisable";
			this.btnDWorkOnError.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.btnDWorkOnError.Name = "btnDWorkOnError";
			this.btnDWorkOnError.SecurityLevel = 12;
			this.btnDWorkOnError.TagName = "DWorkOnError";
			this.btnDWorkOnError.TrueBrush = new NxtControl.Drawing.Brush("ButtonBrush");
			this.btnDWorkOnError.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.btnDWorkOnError.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.btnDWorkOnError.TrueText = "$key:SE.App2CommonProcess.TxtEnable";
			this.btnDWorkOnError.TrueTextKey = "SE.App2CommonProcess.TxtEnable";
			this.btnDWorkOnError.Value = false;
			this.btnDWorkOnError.EndInit();
			// 
			// btnTrackSpInMan
			// 
			this.btnTrackSpInMan.BeginInit();
			this.btnTrackSpInMan.DesignMatrix = new NxtControl.Drawing.Matrix2D(1.475D, 0D, 0D, 0.83333333333333348D, 139D, 428D);
			this.btnTrackSpInMan.FalseBrush = new NxtControl.Drawing.Brush("ButtonBrush");
			this.btnTrackSpInMan.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.btnTrackSpInMan.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.btnTrackSpInMan.FalseText = "$key:SE.App2CommonProcess.TxtDisable";
			this.btnTrackSpInMan.FalseTextKey = "SE.App2CommonProcess.TxtDisable";
			this.btnTrackSpInMan.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.btnTrackSpInMan.Name = "btnTrackSpInMan";
			this.btnTrackSpInMan.SecurityLevel = 12;
			this.btnTrackSpInMan.TagName = "TrackSpInManual";
			this.btnTrackSpInMan.TrueBrush = new NxtControl.Drawing.Brush("ButtonBrush");
			this.btnTrackSpInMan.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.btnTrackSpInMan.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.btnTrackSpInMan.TrueText = "$key:SE.App2CommonProcess.TxtEnable";
			this.btnTrackSpInMan.TrueTextKey = "SE.App2CommonProcess.TxtEnable";
			this.btnTrackSpInMan.Value = false;
			this.btnTrackSpInMan.EndInit();
			// 
			// btnDirection
			// 
			this.btnDirection.BeginInit();
			this.btnDirection.DesignMatrix = new NxtControl.Drawing.Matrix2D(1.475D, 0D, 0D, 0.83333333333333348D, 139D, 188D);
			this.btnDirection.FalseBrush = new NxtControl.Drawing.Brush("ButtonBrush");
			this.btnDirection.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.btnDirection.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.btnDirection.FalseText = "$key:SE.App2CommonProcess.TxtReverse";
			this.btnDirection.FalseTextKey = "SE.App2CommonProcess.TxtReverse";
			this.btnDirection.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.btnDirection.Name = "btnDirection";
			this.btnDirection.SecurityLevel = 12;
			this.btnDirection.TagName = "Direction";
			this.btnDirection.TrueBrush = new NxtControl.Drawing.Brush("ButtonBrush");
			this.btnDirection.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.btnDirection.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.btnDirection.TrueText = "$key:SE.App2CommonProcess.TxtForward";
			this.btnDirection.TrueTextKey = "SE.App2CommonProcess.TxtForward";
			this.btnDirection.Value = false;
			this.btnDirection.EndInit();
			// 
			// txtCycleTime
			// 
			this.txtCycleTime.BeginInit();
			this.txtCycleTime.DecimalPlacesCount = ((uint)(0u));
			this.txtCycleTime.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.6333333333333333D, 0D, 0D, 1D, 139D, 278D);
			this.txtCycleTime.Font = new NxtControl.Drawing.Font("SE.App2Base.Sp");
			this.txtCycleTime.Maximum = 360000;
			this.txtCycleTime.MaximumTag = null;
			this.txtCycleTime.Minimum = 100;
			this.txtCycleTime.MinimumTag = null;
			this.txtCycleTime.Name = "txtCycleTime";
			this.txtCycleTime.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.txtCycleTime.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.txtCycleTime.SecurityLevel = 12;
			this.txtCycleTime.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.txtCycleTime.Suffix = "ms";
			this.txtCycleTime.TagName = "CycleTime";
			this.txtCycleTime.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.txtCycleTime.UseInputPad = true;
			this.txtCycleTime.UseRange = true;
			this.txtCycleTime.Value = 0;
			this.txtCycleTime.EndInit();
			// 
			// CurrentGain
			// 
			this.CurrentGain.BeginInit();
			this.CurrentGain.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.CurrentGain.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.6333333333333333D, 0D, 0D, 1.1904761904761905D, 139D, 10D);
			this.CurrentGain.FontScale = false;
			this.CurrentGain.IsOnlyInput = true;
			this.CurrentGain.LeadingZeros = ((uint)(0u));
			this.CurrentGain.Name = "CurrentGain";
			this.CurrentGain.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.CurrentGain.Ranges.Clear();
			this.CurrentGain.Ranges.Add(new NxtControl.GuiFramework.Range<float>(null, true, null, true, propertyDictionary2));
			propertyDictionary1.Add("Text", "${Value}");
			propertyDictionary1.Add("TextColor", new NxtControl.Drawing.Color("SE.App2Base.aaLibFpData"));
			propertyDictionary1.Add("Brush", new NxtControl.Drawing.Brush(true));
			propertyDictionary1.Add("Pen", new NxtControl.Drawing.Pen("LabelPen"));
			this.CurrentGain.Ranges.DefaultPropertyValues = propertyDictionary1;
			this.CurrentGain.TagName = "CurrentGain";
			this.CurrentGain.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.CurrentGain.EndInit();
			// 
			// CurrentDerivativeTime
			// 
			this.CurrentDerivativeTime.BeginInit();
			this.CurrentDerivativeTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.CurrentDerivativeTime.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.6333333333333333D, 0D, 0D, 1.1904761904761905D, 139D, 70D);
			this.CurrentDerivativeTime.FontScale = false;
			this.CurrentDerivativeTime.IsOnlyInput = true;
			this.CurrentDerivativeTime.LeadingZeros = ((uint)(0u));
			this.CurrentDerivativeTime.Name = "CurrentDerivativeTime";
			this.CurrentDerivativeTime.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.CurrentDerivativeTime.Ranges.Clear();
			this.CurrentDerivativeTime.Ranges.Add(new NxtControl.GuiFramework.Range<float>(null, true, null, true, propertyDictionary4));
			propertyDictionary3.Add("Text", "${Value}");
			propertyDictionary3.Add("TextColor", new NxtControl.Drawing.Color("SE.App2Base.aaLibFpData"));
			propertyDictionary3.Add("Brush", new NxtControl.Drawing.Brush(true));
			propertyDictionary3.Add("Pen", new NxtControl.Drawing.Pen("LabelPen"));
			this.CurrentDerivativeTime.Ranges.DefaultPropertyValues = propertyDictionary3;
			this.CurrentDerivativeTime.Suffix = "s";
			this.CurrentDerivativeTime.SuffixPadding = -69;
			this.CurrentDerivativeTime.TagName = "CurrentDerivativeTime";
			this.CurrentDerivativeTime.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.CurrentDerivativeTime.EndInit();
			// 
			// CurrentLagTime
			// 
			this.CurrentLagTime.BeginInit();
			this.CurrentLagTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.CurrentLagTime.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.6333333333333333D, 0D, 0D, 1.1904761904761905D, 139D, 100D);
			this.CurrentLagTime.FontScale = false;
			this.CurrentLagTime.IsOnlyInput = true;
			this.CurrentLagTime.LeadingZeros = ((uint)(0u));
			this.CurrentLagTime.Name = "CurrentLagTime";
			this.CurrentLagTime.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.CurrentLagTime.Ranges.Clear();
			this.CurrentLagTime.Ranges.Add(new NxtControl.GuiFramework.Range<float>(null, true, null, true, propertyDictionary6));
			propertyDictionary5.Add("Text", "${Value}");
			propertyDictionary5.Add("TextColor", new NxtControl.Drawing.Color("SE.App2Base.aaLibFpData"));
			propertyDictionary5.Add("Brush", new NxtControl.Drawing.Brush(true));
			propertyDictionary5.Add("Pen", new NxtControl.Drawing.Pen("LabelPen"));
			this.CurrentLagTime.Ranges.DefaultPropertyValues = propertyDictionary5;
			this.CurrentLagTime.Suffix = "s";
			this.CurrentLagTime.SuffixPadding = -69;
			this.CurrentLagTime.TagName = "CurrentLagTime";
			this.CurrentLagTime.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.CurrentLagTime.EndInit();
			// 
			// CurrentDeadBand
			// 
			this.CurrentDeadBand.BeginInit();
			this.CurrentDeadBand.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.CurrentDeadBand.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.6333333333333333D, 0D, 0D, 1.1904761904761905D, 139D, 130D);
			this.CurrentDeadBand.FontScale = false;
			this.CurrentDeadBand.IsOnlyInput = true;
			this.CurrentDeadBand.LeadingZeros = ((uint)(0u));
			this.CurrentDeadBand.Name = "CurrentDeadBand";
			this.CurrentDeadBand.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.CurrentDeadBand.Ranges.Clear();
			this.CurrentDeadBand.Ranges.Add(new NxtControl.GuiFramework.Range<float>(null, true, null, true, propertyDictionary8));
			propertyDictionary7.Add("Text", "${Value}");
			propertyDictionary7.Add("TextColor", new NxtControl.Drawing.Color("SE.App2Base.aaLibFpData"));
			propertyDictionary7.Add("Brush", new NxtControl.Drawing.Brush(true));
			propertyDictionary7.Add("Pen", new NxtControl.Drawing.Pen("LabelPen"));
			this.CurrentDeadBand.Ranges.DefaultPropertyValues = propertyDictionary7;
			this.CurrentDeadBand.SuffixPadding = -69;
			this.CurrentDeadBand.TagName = "CurrentDeadBand";
			this.CurrentDeadBand.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.CurrentDeadBand.EndInit();
			// 
			// CurrentOutMin
			// 
			this.CurrentOutMin.BeginInit();
			this.CurrentOutMin.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.CurrentOutMin.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.6333333333333333D, 0D, 0D, 1.1904761904761905D, 139D, 370D);
			this.CurrentOutMin.FontScale = false;
			this.CurrentOutMin.IsOnlyInput = true;
			this.CurrentOutMin.LeadingZeros = ((uint)(0u));
			this.CurrentOutMin.Name = "CurrentOutMin";
			this.CurrentOutMin.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.CurrentOutMin.Ranges.Clear();
			this.CurrentOutMin.Ranges.Add(new NxtControl.GuiFramework.Range<float>(null, true, null, true, propertyDictionary10));
			propertyDictionary9.Add("Text", "${Value}");
			propertyDictionary9.Add("TextColor", new NxtControl.Drawing.Color("SE.App2Base.aaLibFpData"));
			propertyDictionary9.Add("Brush", new NxtControl.Drawing.Brush(true));
			propertyDictionary9.Add("Pen", new NxtControl.Drawing.Pen("LabelPen"));
			this.CurrentOutMin.Ranges.DefaultPropertyValues = propertyDictionary9;
			this.CurrentOutMin.TagName = "CurrentOutMin";
			this.CurrentOutMin.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.CurrentOutMin.EndInit();
			// 
			// CurrentOutMax
			// 
			this.CurrentOutMax.BeginInit();
			this.CurrentOutMax.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.CurrentOutMax.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.6333333333333333D, 0D, 0D, 1.1904761904761905D, 139D, 400D);
			this.CurrentOutMax.FontScale = false;
			this.CurrentOutMax.IsOnlyInput = true;
			this.CurrentOutMax.LeadingZeros = ((uint)(0u));
			this.CurrentOutMax.Name = "CurrentOutMax";
			this.CurrentOutMax.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.CurrentOutMax.Ranges.Clear();
			this.CurrentOutMax.Ranges.Add(new NxtControl.GuiFramework.Range<float>(null, true, null, true, propertyDictionary12));
			propertyDictionary11.Add("Text", "${Value}");
			propertyDictionary11.Add("TextColor", new NxtControl.Drawing.Color("SE.App2Base.aaLibFpData"));
			propertyDictionary11.Add("Brush", new NxtControl.Drawing.Brush(true));
			propertyDictionary11.Add("Pen", new NxtControl.Drawing.Pen("LabelPen"));
			this.CurrentOutMax.Ranges.DefaultPropertyValues = propertyDictionary11;
			this.CurrentOutMax.TagName = "CurrentOutMax";
			this.CurrentOutMax.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.CurrentOutMax.EndInit();
			// 
			// CurrentIntegralTime
			// 
			this.CurrentIntegralTime.BeginInit();
			this.CurrentIntegralTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.CurrentIntegralTime.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.6333333333333333D, 0D, 0D, 1.1904761904761905D, 139D, 40D);
			this.CurrentIntegralTime.FontScale = false;
			this.CurrentIntegralTime.IsOnlyInput = true;
			this.CurrentIntegralTime.LeadingZeros = ((uint)(0u));
			this.CurrentIntegralTime.Name = "CurrentIntegralTime";
			this.CurrentIntegralTime.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.CurrentIntegralTime.Ranges.Clear();
			this.CurrentIntegralTime.Ranges.Add(new NxtControl.GuiFramework.Range<float>(null, true, null, true, propertyDictionary14));
			propertyDictionary13.Add("Text", "${Value}");
			propertyDictionary13.Add("TextColor", new NxtControl.Drawing.Color("SE.App2Base.aaLibFpData"));
			propertyDictionary13.Add("Brush", new NxtControl.Drawing.Brush(true));
			propertyDictionary13.Add("Pen", new NxtControl.Drawing.Pen("LabelPen"));
			this.CurrentIntegralTime.Ranges.DefaultPropertyValues = propertyDictionary13;
			this.CurrentIntegralTime.Suffix = "s";
			this.CurrentIntegralTime.SuffixPadding = -69;
			this.CurrentIntegralTime.TagName = "CurrentIntegralTime";
			this.CurrentIntegralTime.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.CurrentIntegralTime.EndInit();
			// 
			// CurrentDWorkOnError
			// 
			this.CurrentDWorkOnError.BeginInit();
			this.CurrentDWorkOnError.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.CurrentDWorkOnError.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.6333333333333333D, 0D, 0D, 1.1904761904761905D, 139D, 160D);
			this.CurrentDWorkOnError.FontScale = false;
			this.CurrentDWorkOnError.IsOnlyInput = true;
			this.CurrentDWorkOnError.LeadingZeros = ((uint)(0u));
			this.CurrentDWorkOnError.Name = "CurrentDWorkOnError";
			this.CurrentDWorkOnError.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			propertyDictionary16.Add("Text", "Off");
			propertyDictionary17.Add("Text", "On");
			this.CurrentDWorkOnError.Ranges.Clear();
			this.CurrentDWorkOnError.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(false, propertyDictionary16));
			this.CurrentDWorkOnError.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(true, propertyDictionary17));
			propertyDictionary15.Add("Text", "false");
			propertyDictionary15.Add("TextColor", new NxtControl.Drawing.Color("SE.App2Base.aaLibFpData"));
			propertyDictionary15.Add("Brush", new NxtControl.Drawing.Brush(true));
			propertyDictionary15.Add("Pen", new NxtControl.Drawing.Pen("LabelPen"));
			this.CurrentDWorkOnError.Ranges.DefaultPropertyValues = propertyDictionary15;
			this.CurrentDWorkOnError.TagName = "CurrentDWorkOnError";
			this.CurrentDWorkOnError.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.CurrentDWorkOnError.EndInit();
			// 
			// CurrentDirection
			// 
			this.CurrentDirection.BeginInit();
			this.CurrentDirection.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.CurrentDirection.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.6333333333333333D, 0D, 0D, 1.1904761904761905D, 139D, 190D);
			this.CurrentDirection.FontScale = false;
			this.CurrentDirection.IsOnlyInput = true;
			this.CurrentDirection.LeadingZeros = ((uint)(0u));
			this.CurrentDirection.Name = "CurrentDirection";
			this.CurrentDirection.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			propertyDictionary19.Add("Text", "False");
			propertyDictionary20.Add("Text", "True");
			this.CurrentDirection.Ranges.Clear();
			this.CurrentDirection.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(false, propertyDictionary19));
			this.CurrentDirection.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(true, propertyDictionary20));
			propertyDictionary18.Add("Text", "false");
			propertyDictionary18.Add("TextColor", new NxtControl.Drawing.Color("SE.App2Base.aaLibFpData"));
			propertyDictionary18.Add("Brush", new NxtControl.Drawing.Brush(true));
			propertyDictionary18.Add("Pen", new NxtControl.Drawing.Pen("LabelPen"));
			this.CurrentDirection.Ranges.DefaultPropertyValues = propertyDictionary18;
			this.CurrentDirection.TagName = "CurrentDirection";
			this.CurrentDirection.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.CurrentDirection.EndInit();
			// 
			// btnBump
			// 
			this.btnBump.BeginInit();
			this.btnBump.DesignMatrix = new NxtControl.Drawing.Matrix2D(1.475D, 0D, 0D, 0.83333333333333348D, 139D, 458D);
			this.btnBump.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.btnBump.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.btnBump.FalseText = "$key:SE.App2CommonProcess.TxtDisable";
			this.btnBump.FalseTextKey = "SE.App2CommonProcess.TxtDisable";
			this.btnBump.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.btnBump.Name = "btnBump";
			this.btnBump.SecurityLevel = 0;
			this.btnBump.TagName = "Bump";
			this.btnBump.TrueBrush = new NxtControl.Drawing.Brush("ButtonBrush");
			this.btnBump.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.btnBump.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.btnBump.TrueText = "$key:SE.App2CommonProcess.TxtEnable";
			this.btnBump.TrueTextKey = "SE.App2CommonProcess.TxtEnable";
			this.btnBump.Value = false;
			this.btnBump.EndInit();
			// 
			// txtOutputBias
			// 
			this.txtOutputBias.BeginInit();
			this.txtOutputBias.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.6333333333333333D, 0D, 0D, 0.64000000000000012D, 139D, 488D);
			this.txtOutputBias.Font = new NxtControl.Drawing.Font("SE.App2Base.Sp");
			this.txtOutputBias.MaximumTag = null;
			this.txtOutputBias.MinimumTag = null;
			this.txtOutputBias.Name = "txtOutputBias";
			this.txtOutputBias.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.txtOutputBias.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.txtOutputBias.SecurityLevel = 0;
			this.txtOutputBias.SendValueOnLostFocus = true;
			this.txtOutputBias.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.txtOutputBias.TagName = "OutBias";
			this.txtOutputBias.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.txtOutputBias.UseInputPad = true;
			this.txtOutputBias.Value = 0F;
			this.txtOutputBias.EndInit();
			// 
			// CurrentMode
			// 
			this.CurrentMode.BeginInit();
			this.CurrentMode.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.CurrentMode.IsOnlyInput = true;
			this.CurrentMode.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.CurrentMode.Name = "CurrentMode";
			this.CurrentMode.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.CurrentMode.TagName = "CurrentMode";
			this.CurrentMode.Value = ((short)(0));
			this.CurrentMode.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.CurrentModeValueChanged);
			this.CurrentMode.EndInit();
			// 
			// labelS1
			// 
			this.labelS1.BeginInit();
			this.labelS1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1.1065199717264698D, 0D, 0D, 1D, 14D, 8D);
			this.labelS1.Font = new NxtControl.Drawing.Font("SE.App2Base.LabelFont");
			this.labelS1.Name = "labelS1";
			this.labelS1.NameSpace = "SE.App2CommonProcess";
			this.labelS1.SeperatorVisiblity = true;
			this.labelS1.Text = "Gain";
			this.labelS1.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.labelS1.TextColor = new NxtControl.Drawing.Color("FpLabelText");
			this.labelS1.TextKey = "LabelGain";
			this.labelS1.EndInit();
			// 
			// labelS2
			// 
			this.labelS2.BeginInit();
			this.labelS2.DesignMatrix = new NxtControl.Drawing.Matrix2D(1.1065199717264698D, 0D, 0D, 1D, 14D, 38D);
			this.labelS2.Font = new NxtControl.Drawing.Font("SE.App2Base.LabelFont");
			this.labelS2.Name = "labelS2";
			this.labelS2.NameSpace = "SE.App2CommonProcess";
			this.labelS2.SeperatorVisiblity = true;
			this.labelS2.Text = "Integral Time (Ti)";
			this.labelS2.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.labelS2.TextColor = new NxtControl.Drawing.Color("FpLabelText");
			this.labelS2.TextKey = "LabelCtrlReset";
			this.labelS2.EndInit();
			// 
			// labelS3
			// 
			this.labelS3.BeginInit();
			this.labelS3.DesignMatrix = new NxtControl.Drawing.Matrix2D(1.1684850901431518D, 0D, 0D, 1D, 7D, 68D);
			this.labelS3.Font = new NxtControl.Drawing.Font("SE.App2Base.LabelFont");
			this.labelS3.Name = "labelS3";
			this.labelS3.NameSpace = "SE.App2CommonProcess";
			this.labelS3.SeperatorVisiblity = true;
			this.labelS3.Text = "Derivative Time (Td)";
			this.labelS3.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.labelS3.TextColor = new NxtControl.Drawing.Color("FpLabelText");
			this.labelS3.TextKey = "LabelCtrlRate";
			this.labelS3.EndInit();
			// 
			// labelS4
			// 
			this.labelS4.BeginInit();
			this.labelS4.DesignMatrix = new NxtControl.Drawing.Matrix2D(1.1065199717264698D, 0D, 0D, 1D, 14D, 98D);
			this.labelS4.Font = new NxtControl.Drawing.Font("SE.App2Base.LabelFont");
			this.labelS4.Name = "labelS4";
			this.labelS4.NameSpace = "SE.App2CommonProcess";
			this.labelS4.SeperatorVisiblity = true;
			this.labelS4.Text = "Lag Time";
			this.labelS4.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.labelS4.TextColor = new NxtControl.Drawing.Color("FpLabelText");
			this.labelS4.TextKey = "LabelCtrlLagTime";
			this.labelS4.EndInit();
			// 
			// labelS5
			// 
			this.labelS5.BeginInit();
			this.labelS5.DesignMatrix = new NxtControl.Drawing.Matrix2D(1.1065199717264698D, 0D, 0D, 1D, 14D, 128D);
			this.labelS5.Font = new NxtControl.Drawing.Font("SE.App2Base.LabelFont");
			this.labelS5.Name = "labelS5";
			this.labelS5.NameSpace = "SE.App2CommonProcess";
			this.labelS5.SeperatorVisiblity = true;
			this.labelS5.Text = "Deadband";
			this.labelS5.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.labelS5.TextColor = new NxtControl.Drawing.Color("FpLabelText");
			this.labelS5.TextKey = "LabelCtrlDeadband";
			this.labelS5.EndInit();
			// 
			// labelS6
			// 
			this.labelS6.BeginInit();
			this.labelS6.DesignMatrix = new NxtControl.Drawing.Matrix2D(1.1065199717264698D, 0D, 0D, 1D, 14D, 158D);
			this.labelS6.Font = new NxtControl.Drawing.Font("SE.App2Base.LabelFont");
			this.labelS6.Name = "labelS6";
			this.labelS6.NameSpace = "SE.App2CommonProcess";
			this.labelS6.SeperatorVisiblity = true;
			this.labelS6.Text = "D work on Error";
			this.labelS6.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.labelS6.TextColor = new NxtControl.Drawing.Color("FpLabelText");
			this.labelS6.TextKey = "LabelDworkOnError";
			this.labelS6.EndInit();
			// 
			// labelS7
			// 
			this.labelS7.BeginInit();
			this.labelS7.DesignMatrix = new NxtControl.Drawing.Matrix2D(1.1065199717264698D, 0D, 0D, 1D, 14D, 188D);
			this.labelS7.Font = new NxtControl.Drawing.Font("SE.App2Base.LabelFont");
			this.labelS7.Name = "labelS7";
			this.labelS7.NameSpace = "SE.App2CommonProcess";
			this.labelS7.SeperatorVisiblity = true;
			this.labelS7.Text = "Direction";
			this.labelS7.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.labelS7.TextColor = new NxtControl.Drawing.Color("FpLabelText");
			this.labelS7.TextKey = "LabelDirection";
			this.labelS7.EndInit();
			// 
			// labelS8
			// 
			this.labelS8.BeginInit();
			this.labelS8.DesignMatrix = new NxtControl.Drawing.Matrix2D(1.1065199717264698D, 0D, 0D, 1D, 14D, 248D);
			this.labelS8.Font = new NxtControl.Drawing.Font("SE.App2Base.LabelFont");
			this.labelS8.Name = "labelS8";
			this.labelS8.NameSpace = "SE.App2CommonProcess";
			this.labelS8.SeperatorVisiblity = true;
			this.labelS8.Text = "Feed Fwd Gain";
			this.labelS8.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.labelS8.TextColor = new NxtControl.Drawing.Color("FpLabelText");
			this.labelS8.TextKey = "LabelCtrlFfGain";
			this.labelS8.EndInit();
			// 
			// labelS9
			// 
			this.labelS9.BeginInit();
			this.labelS9.DesignMatrix = new NxtControl.Drawing.Matrix2D(1.1065199717264698D, 0D, 0D, 1D, 14D, 218D);
			this.labelS9.Font = new NxtControl.Drawing.Font("SE.App2Base.LabelFont");
			this.labelS9.Name = "labelS9";
			this.labelS9.NameSpace = "SE.App2CommonProcess";
			this.labelS9.SeperatorVisiblity = true;
			this.labelS9.Text = "Feed Fwd Active";
			this.labelS9.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.labelS9.TextColor = new NxtControl.Drawing.Color("FpLabelText");
			this.labelS9.TextKey = "LabelCtrlFfActive";
			this.labelS9.EndInit();
			// 
			// labelS10
			// 
			this.labelS10.BeginInit();
			this.labelS10.DesignMatrix = new NxtControl.Drawing.Matrix2D(1.1065199717264698D, 0D, 0D, 1D, 14D, 278D);
			this.labelS10.Font = new NxtControl.Drawing.Font("SE.App2Base.LabelFont");
			this.labelS10.Name = "labelS10";
			this.labelS10.NameSpace = "SE.App2CommonProcess";
			this.labelS10.SeperatorVisiblity = true;
			this.labelS10.Text = "Cycle Time";
			this.labelS10.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.labelS10.TextColor = new NxtControl.Drawing.Color("FpLabelText");
			this.labelS10.TextKey = "LabelCtrlCycleTime";
			this.labelS10.EndInit();
			// 
			// labelS11
			// 
			this.labelS11.BeginInit();
			this.labelS11.DesignMatrix = new NxtControl.Drawing.Matrix2D(1.1065199717264698D, 0D, 0D, 1D, 14D, 308D);
			this.labelS11.Font = new NxtControl.Drawing.Font("SE.App2Base.LabelFont");
			this.labelS11.Name = "labelS11";
			this.labelS11.NameSpace = "SE.App2CommonProcess";
			this.labelS11.SeperatorVisiblity = true;
			this.labelS11.Text = "Sp Rate Up";
			this.labelS11.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.labelS11.TextColor = new NxtControl.Drawing.Color("FpLabelText");
			this.labelS11.TextKey = "LabelSpRateUp";
			this.labelS11.EndInit();
			// 
			// labelS12
			// 
			this.labelS12.BeginInit();
			this.labelS12.DesignMatrix = new NxtControl.Drawing.Matrix2D(1.1065199717264698D, 0D, 0D, 1D, 14D, 338D);
			this.labelS12.Font = new NxtControl.Drawing.Font("SE.App2Base.LabelFont");
			this.labelS12.Name = "labelS12";
			this.labelS12.NameSpace = "SE.App2CommonProcess";
			this.labelS12.SeperatorVisiblity = true;
			this.labelS12.Text = "Sp Rate Down";
			this.labelS12.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.labelS12.TextColor = new NxtControl.Drawing.Color("FpLabelText");
			this.labelS12.TextKey = "LabelSpRateDown";
			this.labelS12.EndInit();
			// 
			// labelS13
			// 
			this.labelS13.BeginInit();
			this.labelS13.DesignMatrix = new NxtControl.Drawing.Matrix2D(1.1065199717264698D, 0D, 0D, 1D, 14D, 368D);
			this.labelS13.Font = new NxtControl.Drawing.Font("SE.App2Base.LabelFont");
			this.labelS13.Name = "labelS13";
			this.labelS13.NameSpace = "SE.App2CommonProcess";
			this.labelS13.SeperatorVisiblity = true;
			this.labelS13.Text = "Min Out";
			this.labelS13.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.labelS13.TextColor = new NxtControl.Drawing.Color("FpLabelText");
			this.labelS13.TextKey = "LabelMinOut";
			this.labelS13.EndInit();
			// 
			// labelS14
			// 
			this.labelS14.BeginInit();
			this.labelS14.DesignMatrix = new NxtControl.Drawing.Matrix2D(1.1065199717264698D, 0D, 0D, 1D, 14D, 398D);
			this.labelS14.Font = new NxtControl.Drawing.Font("SE.App2Base.LabelFont");
			this.labelS14.Name = "labelS14";
			this.labelS14.NameSpace = "SE.App2CommonProcess";
			this.labelS14.SeperatorVisiblity = true;
			this.labelS14.Text = "Max Out";
			this.labelS14.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.labelS14.TextColor = new NxtControl.Drawing.Color("FpLabelText");
			this.labelS14.TextKey = "LabelMaxOut";
			this.labelS14.EndInit();
			// 
			// labelS15
			// 
			this.labelS15.BeginInit();
			this.labelS15.DesignMatrix = new NxtControl.Drawing.Matrix2D(1.1065199717264698D, 0D, 0D, 1D, 14D, 428D);
			this.labelS15.Font = new NxtControl.Drawing.Font("SE.App2Base.LabelFont");
			this.labelS15.Name = "labelS15";
			this.labelS15.NameSpace = "SE.App2CommonProcess";
			this.labelS15.SeperatorVisiblity = true;
			this.labelS15.Text = "Track Sp in Man";
			this.labelS15.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.labelS15.TextColor = new NxtControl.Drawing.Color("FpLabelText");
			this.labelS15.TextKey = "LabelTrackSPinMan";
			this.labelS15.EndInit();
			// 
			// labelS16
			// 
			this.labelS16.BeginInit();
			this.labelS16.DesignMatrix = new NxtControl.Drawing.Matrix2D(1.1065199717264698D, 0D, 0D, 1D, 14D, 458D);
			this.labelS16.Font = new NxtControl.Drawing.Font("SE.App2Base.LabelFont");
			this.labelS16.Name = "labelS16";
			this.labelS16.NameSpace = "SE.App2CommonProcess";
			this.labelS16.SeperatorVisiblity = true;
			this.labelS16.Text = "Bump";
			this.labelS16.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.labelS16.TextColor = new NxtControl.Drawing.Color("FpLabelText");
			this.labelS16.TextKey = "LabelBump";
			this.labelS16.EndInit();
			// 
			// labelS17
			// 
			this.labelS17.BeginInit();
			this.labelS17.DesignMatrix = new NxtControl.Drawing.Matrix2D(1.1065199717264698D, 0D, 0D, 1D, 14D, 488D);
			this.labelS17.Font = new NxtControl.Drawing.Font("SE.App2Base.LabelFont");
			this.labelS17.Name = "labelS17";
			this.labelS17.NameSpace = "SE.App2CommonProcess";
			this.labelS17.SeperatorVisiblity = true;
			this.labelS17.Text = "Outbias";
			this.labelS17.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.labelS17.TextColor = new NxtControl.Drawing.Color("FpLabelText");
			this.labelS17.TextKey = "LabelOutbias";
			this.labelS17.EndInit();
			// 
			// ExtParaSel
			// 
			this.ExtParaSel.BeginInit();
			this.ExtParaSel.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.ExtParaSel.IsOnlyInput = true;
			this.ExtParaSel.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.ExtParaSel.Name = "ExtParaSel";
			this.ExtParaSel.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.ExtParaSel.TagName = "ExtParaSel";
			this.ExtParaSel.Value = false;
			this.ExtParaSel.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.ExtParaSelValueChanged);
			this.ExtParaSel.EndInit();
			// 
			// CurrentOutbias
			// 
			this.CurrentOutbias.BeginInit();
			this.CurrentOutbias.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.CurrentOutbias.IsOnlyInput = true;
			this.CurrentOutbias.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.CurrentOutbias.Name = "CurrentOutbias";
			this.CurrentOutbias.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.CurrentOutbias.TagName = "CurrentOutbias";
			this.CurrentOutbias.Value = 0F;
			this.CurrentOutbias.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.CurrentOutbiasValueChanged);
			this.CurrentOutbias.EndInit();
			// 
			// CurrentGain_1
			// 
			this.CurrentGain_1.BeginInit();
			this.CurrentGain_1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.CurrentGain_1.IsOnlyInput = true;
			this.CurrentGain_1.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.CurrentGain_1.Name = "CurrentGain_1";
			this.CurrentGain_1.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.CurrentGain_1.TagName = "CurrentGain";
			this.CurrentGain_1.Value = 0F;
			this.CurrentGain_1.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.CurrentGain_1ValueChanged);
			this.CurrentGain_1.EndInit();
			// 
			// CurrentIntegralTime_1
			// 
			this.CurrentIntegralTime_1.BeginInit();
			this.CurrentIntegralTime_1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.CurrentIntegralTime_1.IsOnlyInput = true;
			this.CurrentIntegralTime_1.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.CurrentIntegralTime_1.Name = "CurrentIntegralTime_1";
			this.CurrentIntegralTime_1.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.CurrentIntegralTime_1.TagName = "CurrentIntegralTime";
			this.CurrentIntegralTime_1.Value = 0F;
			this.CurrentIntegralTime_1.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.CurrentIntegralTime_1ValueChanged);
			this.CurrentIntegralTime_1.EndInit();
			// 
			// Gain
			// 
			this.Gain.BeginInit();
			this.Gain.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.Gain.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.Gain.Name = "Gain";
			this.Gain.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.Gain.TagName = "Gain";
			this.Gain.Value = 0F;
			this.Gain.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.GainOutputValueChanged);
			this.Gain.EndInit();
			// 
			// IntegralTime
			// 
			this.IntegralTime.BeginInit();
			this.IntegralTime.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.IntegralTime.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.IntegralTime.Name = "IntegralTime";
			this.IntegralTime.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.IntegralTime.TagName = "IntegralTime";
			this.IntegralTime.Value = 0F;
			this.IntegralTime.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.IntegralTimeOutputValueChanged);
			this.IntegralTime.EndInit();
			// 
			// CurrentDerivativeTime_1
			// 
			this.CurrentDerivativeTime_1.BeginInit();
			this.CurrentDerivativeTime_1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.CurrentDerivativeTime_1.IsOnlyInput = true;
			this.CurrentDerivativeTime_1.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.CurrentDerivativeTime_1.Name = "CurrentDerivativeTime_1";
			this.CurrentDerivativeTime_1.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.CurrentDerivativeTime_1.TagName = "CurrentDerivativeTime";
			this.CurrentDerivativeTime_1.Value = 0F;
			this.CurrentDerivativeTime_1.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.CurrentDerivativeTime_1ValueChanged);
			this.CurrentDerivativeTime_1.EndInit();
			// 
			// DerivativeTime
			// 
			this.DerivativeTime.BeginInit();
			this.DerivativeTime.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.DerivativeTime.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.DerivativeTime.Name = "DerivativeTime";
			this.DerivativeTime.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.DerivativeTime.TagName = "DerivativeTime";
			this.DerivativeTime.Value = 0F;
			this.DerivativeTime.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.DerivativeTimeOutputValueChanged);
			this.DerivativeTime.EndInit();
			// 
			// OutRate
			// 
			this.OutRate.BeginInit();
			this.OutRate.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.6333333333333333D, 0D, 0D, 0.96153846153846156D, 139D, 518D);
			this.OutRate.Font = new NxtControl.Drawing.Font("SE.App2Base.Sp");
			this.OutRate.MaximumTag = null;
			this.OutRate.MinimumTag = null;
			this.OutRate.Name = "OutRate";
			this.OutRate.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.OutRate.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.OutRate.SecurityLevel = 12;
			this.OutRate.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.OutRate.TagName = "OutRate";
			this.OutRate.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.OutRate.UseInputPad = true;
			this.OutRate.UseRange = true;
			this.OutRate.Value = 0F;
			this.OutRate.EndInit();
			// 
			// Gain_kp
			// 
			this.Gain_kp.BeginInit();
			this.Gain_kp.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.6333333333333333D, 0D, 0D, 0.96153846153846156D, 139D, 548D);
			this.Gain_kp.Font = new NxtControl.Drawing.Font("SE.App2Base.Sp");
			this.Gain_kp.Maximum = 1F;
			this.Gain_kp.MaximumTag = null;
			this.Gain_kp.MinimumTag = null;
			this.Gain_kp.Name = "Gain_kp";
			this.Gain_kp.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.Gain_kp.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.Gain_kp.SecurityLevel = 12;
			this.Gain_kp.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.Gain_kp.TagName = "GainKp";
			this.Gain_kp.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.Gain_kp.UseInputPad = true;
			this.Gain_kp.UseRange = true;
			this.Gain_kp.Value = 0F;
			this.Gain_kp.EndInit();
			// 
			// Ovs_att
			// 
			this.Ovs_att.BeginInit();
			this.Ovs_att.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.6333333333333333D, 0D, 0D, 0.96153846153846156D, 139D, 578D);
			this.Ovs_att.Font = new NxtControl.Drawing.Font("SE.App2Base.Sp");
			this.Ovs_att.Maximum = 1F;
			this.Ovs_att.MaximumTag = null;
			this.Ovs_att.MinimumTag = null;
			this.Ovs_att.Name = "Ovs_att";
			this.Ovs_att.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.Ovs_att.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.Ovs_att.SecurityLevel = 12;
			this.Ovs_att.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.Ovs_att.TagName = "OvsAtt";
			this.Ovs_att.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.Ovs_att.UseInputPad = true;
			this.Ovs_att.UseRange = true;
			this.Ovs_att.Value = 0F;
			this.Ovs_att.EndInit();
			// 
			// labelS18
			// 
			this.labelS18.BeginInit();
			this.labelS18.DesignMatrix = new NxtControl.Drawing.Matrix2D(1.2127458890122109D, 0D, 0D, 1D, 2D, 518D);
			this.labelS18.Font = new NxtControl.Drawing.Font("SE.App2Base.LabelFont");
			this.labelS18.Name = "labelS18";
			this.labelS18.NameSpace = "SE.App2CommonProcess";
			this.labelS18.SeperatorVisiblity = true;
			this.labelS18.Text = "Output Change Rate";
			this.labelS18.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.labelS18.TextColor = new NxtControl.Drawing.Color("FpLabelText");
			this.labelS18.TextKey = "LabelOutputRate";
			this.labelS18.EndInit();
			// 
			// labelS19
			// 
			this.labelS19.BeginInit();
			this.labelS19.DesignMatrix = new NxtControl.Drawing.Matrix2D(1.1950415694645873D, 0D, 0D, 1D, 3D, 548D);
			this.labelS19.Font = new NxtControl.Drawing.Font("SE.App2Base.LabelFont");
			this.labelS19.Name = "labelS19";
			this.labelS19.NameSpace = "SE.App2CommonProcess";
			this.labelS19.SeperatorVisiblity = true;
			this.labelS19.Text = "Deadband Factor ";
			this.labelS19.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.labelS19.TextColor = new NxtControl.Drawing.Color("FpLabelText");
			this.labelS19.TextKey = "LabelGainKp";
			this.labelS19.EndInit();
			// 
			// labelS20
			// 
			this.labelS20.BeginInit();
			this.labelS20.DesignMatrix = new NxtControl.Drawing.Matrix2D(1.1507807705955284D, 0D, 0D, 1D, 8D, 578D);
			this.labelS20.Font = new NxtControl.Drawing.Font("SE.App2Base.LabelFont");
			this.labelS20.Name = "labelS20";
			this.labelS20.NameSpace = "SE.App2CommonProcess";
			this.labelS20.SeperatorVisiblity = true;
			this.labelS20.Text = "Overshoot Factor";
			this.labelS20.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.labelS20.TextColor = new NxtControl.Drawing.Color("FpLabelText");
			this.labelS20.TextKey = "LabelOvsAtt";
			this.labelS20.EndInit();
			// 
			// fpParameter
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(274D)), ((float)(614D)));
			this.Brush = new NxtControl.Drawing.Brush("FpBackgroundBrush");
			this.FormBorderStyle = NxtControl.GuiFramework.FormBorderStyle.FixedSingle;
			this.SecurityToken = ((uint)(4294967175u));
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.CurrentOutMax,
			this.CurrentOutMin,
			this.CurrentDeadBand,
			this.CurrentGain,
			this.CurrentDerivativeTime,
			this.CurrentIntegralTime,
			this.CurrentLagTime,
			this.txtGain,
			this.txtIntegralTime,
			this.txtDerivativeTime,
			this.txtLagTime,
			this.txtDeadband,
			this.txtFeedFwdGain,
			this.txtSpRateUp,
			this.txtSpRateDn,
			this.txtOutMin,
			this.btnFeedFwdOn,
			this.btnDWorkOnError,
			this.btnTrackSpInMan,
			this.btnDirection,
			this.txtCycleTime,
			this.CurrentDWorkOnError,
			this.CurrentDirection,
			this.txtOutMax,
			this.btnBump,
			this.txtOutputBias,
			this.CurrentMode,
			this.labelS1,
			this.labelS2,
			this.labelS3,
			this.labelS4,
			this.labelS5,
			this.labelS6,
			this.labelS7,
			this.labelS8,
			this.labelS9,
			this.labelS10,
			this.labelS11,
			this.labelS12,
			this.labelS13,
			this.labelS14,
			this.labelS15,
			this.labelS16,
			this.labelS17,
			this.ExtParaSel,
			this.CurrentOutbias,
			this.CurrentGain_1,
			this.CurrentIntegralTime_1,
			this.Gain,
			this.IntegralTime,
			this.CurrentDerivativeTime_1,
			this.DerivativeTime,
			this.OutRate,
			this.Gain_kp,
			this.Ovs_att,
			this.labelS18,
			this.labelS19,
			this.labelS20});
			this.Size = new System.Drawing.Size(274, 614);
			this.SecurityParameterChanged += new SE.App2Base.Faceplates.SEAppLibHMIFaceplate.OnSecurityParameterChanged(this.FpParameterSecurityParameterChanged);

		}
		private System.HMI.Symbols.Base.TextBox<float> txtGain;
		private System.HMI.Symbols.Base.TextBox<float> txtIntegralTime;
		private System.HMI.Symbols.Base.TextBox<float> txtDerivativeTime;
		private System.HMI.Symbols.Base.TextBox<float> txtLagTime;
		private System.HMI.Symbols.Base.TextBox<float> txtDeadband;
		private System.HMI.Symbols.Base.TextBox<float> txtSpRateUp;
		private System.HMI.Symbols.Base.TextBox<float> txtSpRateDn;
		private System.HMI.Symbols.Base.TextBox<float> txtOutMin;
		private System.HMI.Symbols.Base.TextBox<float> txtOutMax;
		private System.HMI.Symbols.Base.TextBox<float> txtFeedFwdGain;
		private System.HMI.Symbols.Base.SwitchButton btnFeedFwdOn;
		private System.HMI.Symbols.Base.SwitchButton btnDWorkOnError;
		private System.HMI.Symbols.Base.SwitchButton btnTrackSpInMan;
		private System.HMI.Symbols.Base.SwitchButton btnDirection;
		private System.HMI.Symbols.Base.TextBox<int> txtCycleTime;
		private System.HMI.Symbols.Base.Label<float> CurrentGain;
		private System.HMI.Symbols.Base.Label<float> CurrentDerivativeTime;
		private System.HMI.Symbols.Base.Label<float> CurrentLagTime;
		private System.HMI.Symbols.Base.Label<float> CurrentDeadBand;
		private System.HMI.Symbols.Base.Label<float> CurrentOutMin;
		private System.HMI.Symbols.Base.Label<float> CurrentOutMax;
		private System.HMI.Symbols.Base.Label<bool> CurrentDWorkOnError;
		private System.HMI.Symbols.Base.Label<float> CurrentIntegralTime;
		private System.HMI.Symbols.Base.Label<bool> CurrentDirection;
		private System.HMI.Symbols.Base.SwitchButton btnBump;
		private System.HMI.Symbols.Base.TextBox<float> txtOutputBias;
		private System.HMI.Symbols.Base.Execute<System.Int16> CurrentMode;
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
		private SE.App2Base.Graphics.LabelS labelS11;
		private SE.App2Base.Graphics.LabelS labelS12;
		private SE.App2Base.Graphics.LabelS labelS13;
		private SE.App2Base.Graphics.LabelS labelS14;
		private SE.App2Base.Graphics.LabelS labelS15;
		private SE.App2Base.Graphics.LabelS labelS16;
		private SE.App2Base.Graphics.LabelS labelS17;
		private System.HMI.Symbols.Base.Execute<bool> ExtParaSel;
		private System.HMI.Symbols.Base.Execute<float> CurrentOutbias;
		private System.HMI.Symbols.Base.Execute<float> CurrentGain_1;
		private System.HMI.Symbols.Base.Execute<float> CurrentIntegralTime_1;
		private System.HMI.Symbols.Base.Execute<float> CurrentDerivativeTime_1;
		private System.HMI.Symbols.Base.Execute<float> Gain;
		private System.HMI.Symbols.Base.Execute<float> IntegralTime;
		private System.HMI.Symbols.Base.Execute<float> DerivativeTime;
		private System.HMI.Symbols.Base.TextBox<float> OutRate;
		private System.HMI.Symbols.Base.TextBox<float> Gain_kp;
		private System.HMI.Symbols.Base.TextBox<float> Ovs_att;
		private SE.App2Base.Graphics.LabelS labelS18;
		private SE.App2Base.Graphics.LabelS labelS19;
		private SE.App2Base.Graphics.LabelS labelS20;
		
		#endregion
	}
}



