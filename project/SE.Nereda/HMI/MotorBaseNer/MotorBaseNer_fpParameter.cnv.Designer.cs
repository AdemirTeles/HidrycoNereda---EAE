/*
 * Created by EcoStruxure Automation Expert.
 * User: SESA397657
 * Date: 08/04/2021
 * Time: 3:24 pm
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using NxtControl.GuiFramework;

namespace SE.Nereda.Faceplates.MotorBaseNer
{
	/// <summary>
	/// Summary description for fpParamater.
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
			this.FailResetReq = new System.HMI.Symbols.Base.SwitchButton();
			this.Sim = new System.HMI.Symbols.Base.SwitchButton();
			this.Over = new System.HMI.Symbols.Base.SwitchButton();
			this.Maint = new System.HMI.Symbols.Base.SwitchButton();
			this.Pv = new System.HMI.Symbols.Base.Execute<short>();
			this.txtTripTime = new System.HMI.Symbols.Base.TextBox<int>();
			this.txtMonTime = new System.HMI.Symbols.Base.TextBox<int>();
			this.execute_11 = new System.HMI.Symbols.Base.Execute<bool>();
			this.labelS1 = new SE.App2Base.Graphics.LabelS();
			this.labelS2 = new SE.App2Base.Graphics.LabelS();
			this.labelS5 = new SE.App2Base.Graphics.LabelS();
			this.labelS6 = new SE.App2Base.Graphics.LabelS();
			this.LabelSim = new SE.App2Base.Graphics.LabelS();
			this.LabelOver = new SE.App2Base.Graphics.LabelS();
			this.LabelMaint = new SE.App2Base.Graphics.LabelS();
			this.execute_13 = new System.HMI.Symbols.Base.Execute<bool>();
			this.SwOos = new System.HMI.Symbols.Base.SwitchButton();
			this.LabelOos = new SE.App2Base.Graphics.LabelS();
			this.OutOfService = new System.HMI.Symbols.Base.Execute<bool>();
			this.FbOverride = new System.HMI.Symbols.Base.Execute<bool>();
			this.TransFbStatus = new System.HMI.Symbols.Base.Execute<short>();
			// 
			// ConfResetReq
			// 
			this.ConfResetReq.BeginInit();
			this.ConfResetReq.DesignMatrix = new NxtControl.Drawing.Matrix2D(1.475D, 0D, 0D, 0.83333333333333348D, 120D, 77D);
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
			// FailResetReq
			// 
			this.FailResetReq.BeginInit();
			this.FailResetReq.DesignMatrix = new NxtControl.Drawing.Matrix2D(1.475D, 0D, 0D, 0.83333333333333348D, 120D, 107D);
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
			// Sim
			// 
			this.Sim.BeginInit();
			this.Sim.DesignMatrix = new NxtControl.Drawing.Matrix2D(1.475D, 0D, 0D, 0.83333333333333348D, 120D, 137D);
			this.Sim.FalseBrush = new NxtControl.Drawing.Brush("ButtonBrush");
			this.Sim.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.Sim.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.Sim.FalseText = "$key:SE.App2CommonProcess.TxtDisable";
			this.Sim.FalseTextKey = "SE.App2CommonProcess.TxtDisable";
			this.Sim.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.Sim.Name = "Sim";
			this.Sim.SecurityLevel = 0;
			this.Sim.TagName = "Simulation";
			this.Sim.TrueBrush = new NxtControl.Drawing.Brush("ButtonBrush");
			this.Sim.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.Sim.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.Sim.TrueText = "$key:SE.App2CommonProcess.TxtEnable";
			this.Sim.TrueTextKey = "SE.App2CommonProcess.TxtEnable";
			this.Sim.Value = false;
			this.Sim.EndInit();
			// 
			// Over
			// 
			this.Over.BeginInit();
			this.Over.DesignMatrix = new NxtControl.Drawing.Matrix2D(1.475D, 0D, 0D, 0.83333333333333348D, 120D, 167D);
			this.Over.FalseBrush = new NxtControl.Drawing.Brush("ButtonBrush");
			this.Over.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.Over.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.Over.FalseText = "$key:SE.App2CommonProcess.TxtDisable";
			this.Over.FalseTextKey = "SE.App2CommonProcess.TxtDisable";
			this.Over.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.Over.Name = "Over";
			this.Over.SecurityLevel = 0;
			this.Over.TagName = "FbOverride";
			this.Over.TrueBrush = new NxtControl.Drawing.Brush("ButtonBrush");
			this.Over.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.Over.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.Over.TrueText = "$key:SE.App2CommonProcess.TxtEnable";
			this.Over.TrueTextKey = "SE.App2CommonProcess.TxtEnable";
			this.Over.Value = false;
			this.Over.EndInit();
			// 
			// Maint
			// 
			this.Maint.BeginInit();
			this.Maint.DesignMatrix = new NxtControl.Drawing.Matrix2D(1.475D, 0D, 0D, 0.83333333333333348D, 120D, 197D);
			this.Maint.FalseBrush = new NxtControl.Drawing.Brush("ButtonBrush");
			this.Maint.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.Maint.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.Maint.FalseText = "$key:SE.App2CommonProcess.TxtDisable";
			this.Maint.FalseTextKey = "SE.App2CommonProcess.TxtDisable";
			this.Maint.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.Maint.Name = "Maint";
			this.Maint.SecurityLevel = 0;
			this.Maint.TagName = "Maintenance";
			this.Maint.TrueBrush = new NxtControl.Drawing.Brush("ButtonBrush");
			this.Maint.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.Maint.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.Maint.TrueText = "$key:SE.App2CommonProcess.TxtEnable";
			this.Maint.TrueTextKey = "SE.App2CommonProcess.TxtEnable";
			this.Maint.Value = false;
			this.Maint.EndInit();
			// 
			// Pv
			// 
			this.Pv.BeginInit();
			this.Pv.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.Pv.IsOnlyInput = true;
			this.Pv.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.Pv.Name = "Pv";
			this.Pv.SecurityLevel = 0;
			this.Pv.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.Pv.TagName = "FbStatus";
			this.Pv.Value = ((short)(0));
			this.Pv.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.PvValueChanged);
			this.Pv.EndInit();
			// 
			// txtTripTime
			// 
			this.txtTripTime.BeginInit();
			this.txtTripTime.DecimalPlacesCount = ((uint)(0u));
			this.txtTripTime.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.6333333333333333D, 0D, 0D, 1D, 119D, 46D);
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
			// txtMonTime
			// 
			this.txtMonTime.BeginInit();
			this.txtMonTime.DecimalPlacesCount = ((uint)(0u));
			this.txtMonTime.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.6333333333333333D, 0D, 0D, 1D, 120D, 15D);
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
			// execute_11
			// 
			this.execute_11.BeginInit();
			this.execute_11.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.execute_11.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.execute_11.Name = "execute_11";
			this.execute_11.SecurityLevel = 0;
			this.execute_11.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.execute_11.TagName = "Simulation";
			this.execute_11.Value = false;
			this.execute_11.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.SimValueChanged);
			this.execute_11.EndInit();
			// 
			// labelS1
			// 
			this.labelS1.BeginInit();
			this.labelS1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1.0000000084395959D, 0D, 0D, 1D, 5D, 15D);
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
			this.labelS2.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 4D, 46D);
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
			// labelS5
			// 
			this.labelS5.BeginInit();
			this.labelS5.DesignMatrix = new NxtControl.Drawing.Matrix2D(1.0000000084395959D, 0D, 0D, 1D, 4D, 77D);
			this.labelS5.Font = new NxtControl.Drawing.Font("SE.App2Base.LabelFont");
			this.labelS5.Name = "labelS5";
			this.labelS5.NameSpace = "SE.App2CommonProcess";
			this.labelS5.SeperatorVisiblity = true;
			this.labelS5.Text = "Feedback Reset";
			this.labelS5.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.labelS5.TextColor = new NxtControl.Drawing.Color("FpLabelText");
			this.labelS5.TextKey = "LabelFBReset";
			this.labelS5.EndInit();
			// 
			// labelS6
			// 
			this.labelS6.BeginInit();
			this.labelS6.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 4D, 107D);
			this.labelS6.Font = new NxtControl.Drawing.Font("SE.App2Base.LabelFont");
			this.labelS6.Name = "labelS6";
			this.labelS6.NameSpace = "SE.App2CommonProcess";
			this.labelS6.SeperatorVisiblity = true;
			this.labelS6.Text = "Fail Reset";
			this.labelS6.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.labelS6.TextColor = new NxtControl.Drawing.Color("FpLabelText");
			this.labelS6.TextKey = "LabelFailReset";
			this.labelS6.EndInit();
			// 
			// LabelSim
			// 
			this.LabelSim.BeginInit();
			this.LabelSim.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 4D, 136D);
			this.LabelSim.Font = new NxtControl.Drawing.Font("SE.App2Base.LabelFont");
			this.LabelSim.Name = "LabelSim";
			this.LabelSim.NameSpace = "SE.App2CommonProcess";
			this.LabelSim.SeperatorVisiblity = true;
			this.LabelSim.Text = "Simulation";
			this.LabelSim.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.LabelSim.TextColor = new NxtControl.Drawing.Color("FpLabelText");
			this.LabelSim.TextKey = "LabelSimulation";
			this.LabelSim.EndInit();
			// 
			// LabelOver
			// 
			this.LabelOver.BeginInit();
			this.LabelOver.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 4D, 165D);
			this.LabelOver.Font = new NxtControl.Drawing.Font("SE.App2Base.LabelFont");
			this.LabelOver.Name = "LabelOver";
			this.LabelOver.NameSpace = "SE.App2CommonProcess";
			this.LabelOver.SeperatorVisiblity = true;
			this.LabelOver.Text = "Override";
			this.LabelOver.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.LabelOver.TextColor = new NxtControl.Drawing.Color("FpLabelText");
			this.LabelOver.TextKey = "LabelOverride";
			this.LabelOver.EndInit();
			// 
			// LabelMaint
			// 
			this.LabelMaint.BeginInit();
			this.LabelMaint.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 4D, 197D);
			this.LabelMaint.Font = new NxtControl.Drawing.Font("SE.App2Base.LabelFont");
			this.LabelMaint.Name = "LabelMaint";
			this.LabelMaint.NameSpace = "SE.App2CommonProcess";
			this.LabelMaint.SeperatorVisiblity = true;
			this.LabelMaint.Text = "Maintenance";
			this.LabelMaint.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.LabelMaint.TextColor = new NxtControl.Drawing.Color("FpLabelText");
			this.LabelMaint.TextKey = "LabelMaint";
			this.LabelMaint.EndInit();
			// 
			// execute_13
			// 
			this.execute_13.BeginInit();
			this.execute_13.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.execute_13.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.execute_13.Name = "execute_13";
			this.execute_13.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.execute_13.TagName = "Maintenance";
			this.execute_13.Value = false;
			this.execute_13.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.MaintValueChanged);
			this.execute_13.EndInit();
			// 
			// SwOos
			// 
			this.SwOos.BeginInit();
			this.SwOos.DesignMatrix = new NxtControl.Drawing.Matrix2D(1.475D, 0D, 0D, 0.83333333333333348D, 120D, 228D);
			this.SwOos.FalseBrush = new NxtControl.Drawing.Brush("ButtonBrush");
			this.SwOos.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.SwOos.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.SwOos.FalseText = "$key:SE.App2CommonProcess.TxtDisable";
			this.SwOos.FalseTextKey = "SE.App2CommonProcess.TxtDisable";
			this.SwOos.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.SwOos.Name = "SwOos";
			this.SwOos.SecurityLevel = 0;
			this.SwOos.TagName = "OutOfService";
			this.SwOos.TrueBrush = new NxtControl.Drawing.Brush("ButtonBrush");
			this.SwOos.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.SwOos.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.SwOos.TrueText = "$key:SE.App2CommonProcess.TxtEnable";
			this.SwOos.TrueTextKey = "SE.App2CommonProcess.TxtEnable";
			this.SwOos.Value = false;
			this.SwOos.EndInit();
			// 
			// LabelOos
			// 
			this.LabelOos.BeginInit();
			this.LabelOos.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 4D, 227D);
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
			// OutOfService
			// 
			this.OutOfService.BeginInit();
			this.OutOfService.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.OutOfService.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.OutOfService.Name = "OutOfService";
			this.OutOfService.SecurityLevel = 0;
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
			this.FbOverride.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.OverValueChanged);
			this.FbOverride.EndInit();
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
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(268D)), ((float)(289D)));
			this.Brush = new NxtControl.Drawing.Brush("FpBackgroundBrush");
			this.FormBorderStyle = NxtControl.GuiFramework.FormBorderStyle.FixedSingle;
			this.SecurityToken = ((uint)(4294967175u));
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.ConfResetReq,
			this.FailResetReq,
			this.Sim,
			this.Over,
			this.Maint,
			this.Pv,
			this.txtTripTime,
			this.txtMonTime,
			this.execute_11,
			this.labelS1,
			this.labelS2,
			this.labelS5,
			this.labelS6,
			this.LabelSim,
			this.LabelOver,
			this.LabelMaint,
			this.execute_13,
			this.SwOos,
			this.LabelOos,
			this.OutOfService,
			this.FbOverride,
			this.TransFbStatus});
			this.Size = new System.Drawing.Size(268, 289);
			this.SecurityOwnerChanged += new SE.App2Base.Faceplates.SEAppLibHMIFaceplate.OnSecurityOwnerChanged(this.FpParameterSecurityOwnerChanged);
			this.SecurityParameterChanged += new SE.App2Base.Faceplates.SEAppLibHMIFaceplate.OnSecurityParameterChanged(this.FpParameterSecurityParameterChanged);
			this.SecurityModeChanged += new SE.App2Base.Faceplates.SEAppLibHMIFaceplate.OnSecurityModeChanged(this.FpParameterSecurityModeChanged);

		}
		private System.HMI.Symbols.Base.SwitchButton ConfResetReq;
		private System.HMI.Symbols.Base.SwitchButton FailResetReq;
		private System.HMI.Symbols.Base.SwitchButton Sim;
		private System.HMI.Symbols.Base.SwitchButton Over;
		private System.HMI.Symbols.Base.SwitchButton Maint;
		private System.HMI.Symbols.Base.Execute<short> Pv;
		private System.HMI.Symbols.Base.TextBox<int> txtTripTime;
		private System.HMI.Symbols.Base.TextBox<int> txtMonTime;
		private System.HMI.Symbols.Base.Execute<bool> execute_11;
		private SE.App2Base.Graphics.LabelS labelS1;
		private SE.App2Base.Graphics.LabelS labelS2;
		private SE.App2Base.Graphics.LabelS labelS5;
		private SE.App2Base.Graphics.LabelS labelS6;
		private SE.App2Base.Graphics.LabelS LabelSim;
		private SE.App2Base.Graphics.LabelS LabelOver;
		private SE.App2Base.Graphics.LabelS LabelMaint;
		private System.HMI.Symbols.Base.Execute<bool> execute_13;
		private System.HMI.Symbols.Base.SwitchButton SwOos;
		private SE.App2Base.Graphics.LabelS LabelOos;
		private System.HMI.Symbols.Base.Execute<bool> OutOfService;
		private System.HMI.Symbols.Base.Execute<bool> FbOverride;
		private System.HMI.Symbols.Base.Execute<short> TransFbStatus;
		#endregion
	}
}



