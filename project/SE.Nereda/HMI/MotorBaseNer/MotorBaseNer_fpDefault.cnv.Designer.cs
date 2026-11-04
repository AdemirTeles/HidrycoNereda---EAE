/*
 * Created by EcoStruxure Automation Expert.
 * User: SESA397657
 * Date: 05/04/2021
 * Time: 11:02 am
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
			this.line7 = new NxtControl.GuiFramework.Line();
			this.line1 = new NxtControl.GuiFramework.Line();
			this.IconBottomBorder1 = new NxtControl.GuiFramework.Group();
			this.lblIsPv = new NxtControl.GuiFramework.Label();
			this.lblReqOp = new NxtControl.GuiFramework.Label();
			this.btnManOff = new NxtControl.GuiFramework.DrawnButton();
			this.btnManOn = new NxtControl.GuiFramework.DrawnButton();
			this.btnReset = new NxtControl.GuiFramework.DrawnButton();
			this.NeedReset = new System.HMI.Symbols.Base.Execute<bool>();
			this.Fb = new System.HMI.Symbols.Base.Execute<short>();
			this.CurrentSp = new System.HMI.Symbols.Base.Execute<short>();
			this.TransFbStatus = new System.HMI.Symbols.Base.Execute<short>();
			this.lblAutoSp = new NxtControl.GuiFramework.Label();
			this.labelS2 = new SE.App2Base.Graphics.LabelS();
			this.labelS1 = new SE.App2Base.Graphics.LabelS();
			this.labelS3 = new SE.App2Base.Graphics.LabelS();
			this.fpNavigationPane = new SE.App2Base.Graphics.FpNavigationPane();
			this.Sim = new System.HMI.Symbols.Base.Execute<bool>();
			this.Over = new System.HMI.Symbols.Base.Execute<bool>();
			this.Maint = new System.HMI.Symbols.Base.Execute<bool>();
			this.Oos = new System.HMI.Symbols.Base.Execute<bool>();
			this.ownerStatus = new SE.App2Base.Graphics.OwnerStatusBasic();
			this.ownerSwitch = new SE.App2Base.Graphics.OwnerSwitchBasic();
			this.CurrentOwnerBasic = new System.HMI.Symbols.Base.Execute<ushort>();
			this.CurrentOp = new System.HMI.Symbols.Base.Execute<short>();
			this.StdOwnerConnected = new System.HMI.Symbols.Base.Execute<bool>();
			this.ExternalControlled = new System.HMI.Symbols.Base.Execute<bool>();
			// 
			// line7
			// 
			this.line7.EndPoint = new NxtControl.Drawing.PointF(270D, 150D);
			this.line7.Name = "line7";
			this.line7.Pen = new NxtControl.Drawing.Pen("FpLinePen");
			this.line7.StartPoint = new NxtControl.Drawing.PointF(1D, 150D);
			// 
			// line1
			// 
			this.line1.EndPoint = new NxtControl.Drawing.PointF(270D, 150D);
			this.line1.Name = "line1";
			this.line1.Pen = new NxtControl.Drawing.Pen("FpLinePen");
			this.line1.StartPoint = new NxtControl.Drawing.PointF(1D, 150D);
			// 
			// IconBottomBorder1
			// 
			this.IconBottomBorder1.BeginInit();
			this.IconBottomBorder1.Name = "IconBottomBorder1";
			this.IconBottomBorder1.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.line7,
			this.line1});
			this.IconBottomBorder1.EndInit();
			// 
			// lblIsPv
			// 
			this.lblIsPv.AngleIgnore = true;
			this.lblIsPv.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lblIsPv.Bounds = new NxtControl.Drawing.RectF(((float)(120D)), ((float)(8D)), ((float)(109D)), ((float)(25D)));
			this.lblIsPv.Brush = new NxtControl.Drawing.Brush();
			this.lblIsPv.Font = new NxtControl.Drawing.Font("SE.App2Base.Pv");
			this.lblIsPv.Name = "lblIsPv";
			this.lblIsPv.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.lblIsPv.Text = "$key:SE.App2CommonProcess.LabelUnknown";
			this.lblIsPv.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.lblIsPv.TextColor = new NxtControl.Drawing.Color("SE.App2Base.aaLibFpData");
			// 
			// lblReqOp
			// 
			this.lblReqOp.AngleIgnore = true;
			this.lblReqOp.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lblReqOp.Bounds = new NxtControl.Drawing.RectF(((float)(120D)), ((float)(52D)), ((float)(109D)), ((float)(25D)));
			this.lblReqOp.Brush = new NxtControl.Drawing.Brush();
			this.lblReqOp.Font = new NxtControl.Drawing.Font("SE.App2Base.Pv");
			this.lblReqOp.IsPrefixSuffixOutside = false;
			this.lblReqOp.Name = "lblReqOp";
			this.lblReqOp.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.lblReqOp.SuffixPadding = 1;
			this.lblReqOp.Text = "$key:SE.App2CommonProcess.LabelUnknown";
			this.lblReqOp.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.lblReqOp.TextColor = new NxtControl.Drawing.Color("SE.App2Base.aaLibFpOp");
			// 
			// btnManOff
			// 
			this.btnManOff.Bounds = new NxtControl.Drawing.RectF(((float)(16D)), ((float)(224D)), ((float)(114D)), ((float)(30D)));
			this.btnManOff.Brush = new NxtControl.Drawing.Brush("ButtonBrush");
			this.btnManOff.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.btnManOff.InnerBorderColor = new NxtControl.Drawing.Color("ButtonInnerBorderColor");
			this.btnManOff.Name = "btnManOff";
			this.btnManOff.Pen = new NxtControl.Drawing.Pen("ButtonPen");
			this.btnManOff.Radius = 4D;
			this.btnManOff.Text = "$key:SE.App2CommonProcess.BtnManPassive";
			this.btnManOff.TextColor = new NxtControl.Drawing.Color("ButtonTextColor");
			this.btnManOff.TextColorMouseDown = new NxtControl.Drawing.Color("ButtonTextColorMouseDown");
			this.btnManOff.Use3DEffect = false;
			this.btnManOff.Click += new System.EventHandler(this.BtnManOffClick);
			// 
			// btnManOn
			// 
			this.btnManOn.Bounds = new NxtControl.Drawing.RectF(((float)(141D)), ((float)(224D)), ((float)(114D)), ((float)(30D)));
			this.btnManOn.Brush = new NxtControl.Drawing.Brush("ButtonBrush");
			this.btnManOn.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.btnManOn.InnerBorderColor = new NxtControl.Drawing.Color("ButtonInnerBorderColor");
			this.btnManOn.Name = "btnManOn";
			this.btnManOn.Pen = new NxtControl.Drawing.Pen("ButtonPen");
			this.btnManOn.Radius = 4D;
			this.btnManOn.Text = "$key:SE.App2CommonProcess.BtnManActive";
			this.btnManOn.TextColor = new NxtControl.Drawing.Color("ButtonTextColor");
			this.btnManOn.TextColorMouseDown = new NxtControl.Drawing.Color("ButtonTextColorMouseDown");
			this.btnManOn.Use3DEffect = false;
			this.btnManOn.Click += new System.EventHandler(this.BtnManOnClick);
			// 
			// btnReset
			// 
			this.btnReset.Bounds = new NxtControl.Drawing.RectF(((float)(81D)), ((float)(280D)), ((float)(108D)), ((float)(30D)));
			this.btnReset.Brush = new NxtControl.Drawing.Brush("ButtonBrush");
			this.btnReset.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.btnReset.InnerBorderColor = new NxtControl.Drawing.Color("ButtonInnerBorderColor");
			this.btnReset.Name = "btnReset";
			this.btnReset.Pen = new NxtControl.Drawing.Pen("ButtonPen");
			this.btnReset.Radius = 4D;
			this.btnReset.Text = "$key:SE.App2CommonProcess.LabelRearm";
			this.btnReset.TextColor = new NxtControl.Drawing.Color("ButtonTextColor");
			this.btnReset.TextColorMouseDown = new NxtControl.Drawing.Color("ButtonTextColorMouseDown");
			this.btnReset.Use3DEffect = false;
			this.btnReset.Click += new System.EventHandler(this.BtnResetClick);
			// 
			// NeedReset
			// 
			this.NeedReset.BeginInit();
			this.NeedReset.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.NeedReset.IsOnlyInput = true;
			this.NeedReset.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.NeedReset.Name = "NeedReset";
			this.NeedReset.SecurityLevel = 0;
			this.NeedReset.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.NeedReset.TagName = "NeedReset";
			this.NeedReset.Value = false;
			this.NeedReset.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.NeedResetValueChanged);
			this.NeedReset.EndInit();
			// 
			// Fb
			// 
			this.Fb.BeginInit();
			this.Fb.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.Fb.IsOnlyInput = true;
			this.Fb.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.Fb.Name = "Fb";
			this.Fb.SecurityLevel = 0;
			this.Fb.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.Fb.TagName = "FbStatus";
			this.Fb.Value = ((short)(0));
			this.Fb.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.FbValueChanged);
			this.Fb.EndInit();
			// 
			// CurrentSp
			// 
			this.CurrentSp.BeginInit();
			this.CurrentSp.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.CurrentSp.IsOnlyInput = true;
			this.CurrentSp.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.CurrentSp.Name = "CurrentSp";
			this.CurrentSp.SecurityLevel = 0;
			this.CurrentSp.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.CurrentSp.TagName = "CurrentSp";
			this.CurrentSp.Value = ((short)(0));
			this.CurrentSp.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.CurrentSpValueChanged);
			this.CurrentSp.EndInit();
			// 
			// TransFbStatus
			// 
			this.TransFbStatus.BeginInit();
			this.TransFbStatus.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.TransFbStatus.IsOnlyInput = true;
			this.TransFbStatus.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.TransFbStatus.Name = "TransFbStatus";
			this.TransFbStatus.SecurityLevel = 0;
			this.TransFbStatus.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.TransFbStatus.TagName = "TransFbStatus";
			this.TransFbStatus.Value = ((short)(0));
			this.TransFbStatus.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.TransFbStatusValueChanged);
			this.TransFbStatus.EndInit();
			// 
			// lblAutoSp
			// 
			this.lblAutoSp.AngleIgnore = true;
			this.lblAutoSp.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lblAutoSp.Bounds = new NxtControl.Drawing.RectF(((float)(120D)), ((float)(30D)), ((float)(109D)), ((float)(25D)));
			this.lblAutoSp.Brush = new NxtControl.Drawing.Brush();
			this.lblAutoSp.Font = new NxtControl.Drawing.Font("SE.App2Base.Pv");
			this.lblAutoSp.Name = "lblAutoSp";
			this.lblAutoSp.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.lblAutoSp.Text = "$key:SE.App2CommonProcess.LabelUnknown";
			this.lblAutoSp.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.lblAutoSp.TextColor = new NxtControl.Drawing.Color("SE.App2Base.aaLibFpSp");
			// 
			// labelS2
			// 
			this.labelS2.BeginInit();
			this.labelS2.DesignMatrix = new NxtControl.Drawing.Matrix2D(1.0000000084395959D, 0D, 0D, 1D, 5D, 30D);
			this.labelS2.Font = new NxtControl.Drawing.Font("SE.App2Base.LabelFont");
			this.labelS2.Name = "labelS2";
			this.labelS2.NameSpace = "SE.App2CommonProcess";
			this.labelS2.SeperatorVisiblity = true;
			this.labelS2.Text = "Current Setpoint";
			this.labelS2.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.labelS2.TextColor = new NxtControl.Drawing.Color("FpLabelText");
			this.labelS2.TextKey = "LabelCurrentSetpoint";
			this.labelS2.EndInit();
			// 
			// labelS1
			// 
			this.labelS1.BeginInit();
			this.labelS1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 5D, 8D);
			this.labelS1.Font = new NxtControl.Drawing.Font("SE.App2Base.LabelFont");
			this.labelS1.Name = "labelS1";
			this.labelS1.NameSpace = "SE.App2CommonProcess";
			this.labelS1.SeperatorVisiblity = true;
			this.labelS1.Text = "Status";
			this.labelS1.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.labelS1.TextColor = new NxtControl.Drawing.Color("FpLabelText");
			this.labelS1.TextKey = "LabelRunState";
			this.labelS1.EndInit();
			// 
			// labelS3
			// 
			this.labelS3.BeginInit();
			this.labelS3.DesignMatrix = new NxtControl.Drawing.Matrix2D(1.0000000084395959D, 0D, 0D, 1D, 5D, 52D);
			this.labelS3.Font = new NxtControl.Drawing.Font("SE.App2Base.LabelFont");
			this.labelS3.Name = "labelS3";
			this.labelS3.NameSpace = "SE.App2CommonProcess";
			this.labelS3.SeperatorVisiblity = true;
			this.labelS3.Text = "Current Output";
			this.labelS3.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.labelS3.TextColor = new NxtControl.Drawing.Color("FpLabelText");
			this.labelS3.TextKey = "LabelCurrentOutput";
			this.labelS3.EndInit();
			// 
			// fpNavigationPane
			// 
			this.fpNavigationPane.BeginInit();
			this.fpNavigationPane.Backwash.AliasName = "";
			this.fpNavigationPane.Backwash.Availablity = SE.App2Base.SupportClasses.FpIconSymbolAllocation.NotAvailable;
			this.fpNavigationPane.Backwash.InstanceName = null;
			this.fpNavigationPane.Backwash.ParentTitle = "Title";
			this.fpNavigationPane.Backwash.SymbolType = "SE.AppWWW.Symbols.Backwash.sDefault";
			this.fpNavigationPane.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 215D, 0D);
			this.fpNavigationPane.Failure.AliasName = "";
			this.fpNavigationPane.Failure.Availablity = SE.App2Base.SupportClasses.FpIconSymbolAllocation.Slot3L;
			this.fpNavigationPane.Failure.InstanceName = null;
			this.fpNavigationPane.Failure.LabelActive1 = SE.App2Base.SupportClasses.CondActive1LabelText.On;
			this.fpNavigationPane.Failure.LabelPassive = SE.App2Base.SupportClasses.CondPassiveLabelText.Off;
			this.fpNavigationPane.Failure.ParentTitle = "Title";
			this.fpNavigationPane.Failure.SymbolType = "SE.AppCommonProcess.Symbols.CondSum.sFailure";
			this.fpNavigationPane.Filtration.AliasName = "";
			this.fpNavigationPane.Filtration.Availablity = SE.App2Base.SupportClasses.FpIconSymbolAllocation.NotAvailable;
			this.fpNavigationPane.Filtration.InstanceName = null;
			this.fpNavigationPane.Filtration.ParentTitle = "Title";
			this.fpNavigationPane.Filtration.SymbolType = "SE.AppWWW.Symbols.Filtration.sDefault";
			this.fpNavigationPane.GeneralPropertySubscription.AddRange(new string[] {
			"System.ShowTagNames"});
			this.fpNavigationPane.HideSlider = false;
			this.fpNavigationPane.InputParameters.Availablity = SE.App2Base.SupportClasses.FpIconSymbolAllocation.NotAvailable;
			this.fpNavigationPane.Interlock.AliasName = "";
			this.fpNavigationPane.Interlock.Availablity = SE.App2Base.SupportClasses.FpIconSymbolAllocation.Slot2L;
			this.fpNavigationPane.Interlock.InstanceName = null;
			this.fpNavigationPane.Interlock.LabelActive1 = SE.App2Base.SupportClasses.CondActive1LabelText.On;
			this.fpNavigationPane.Interlock.LabelPassive = SE.App2Base.SupportClasses.CondPassiveLabelText.Off;
			this.fpNavigationPane.Interlock.ParentTitle = "Title";
			this.fpNavigationPane.Interlock.SymbolType = "SE.AppCommonProcess.Symbols.IlckCondSum.sInterlock";
			this.fpNavigationPane.IsBasic = false;
			this.fpNavigationPane.LocalPanel.AliasName = "";
			this.fpNavigationPane.LocalPanel.Availablity = SE.App2Base.SupportClasses.FpIconSymbolAllocation.Slot4R;
			this.fpNavigationPane.LocalPanel.InstanceName = null;
			this.fpNavigationPane.LocalPanel.LabelActive1 = SE.App2Base.SupportClasses.CondActive1LabelText.On;
			this.fpNavigationPane.LocalPanel.LabelPassive = SE.App2Base.SupportClasses.CondPassiveLabelText.Off;
			this.fpNavigationPane.LocalPanel.ParentTitle = "Title";
			this.fpNavigationPane.LocalPanel.SymbolType = "SE.AppCommonProcess.Symbols.DevLp.sDefault";
			this.fpNavigationPane.Maintenance.AliasName = "";
			this.fpNavigationPane.Maintenance.Availablity = SE.App2Base.SupportClasses.FpIconSymbolAllocation.Slot1L;
			this.fpNavigationPane.Maintenance.InstanceName = null;
			this.fpNavigationPane.Maintenance.ParentTitle = "Title";
			this.fpNavigationPane.Maintenance.SymbolType = "SE.AppCommonProcess.Symbols.DevMnt.sDefault";
			this.fpNavigationPane.Measures.Availablity = SE.App2Base.SupportClasses.FpIconSymbolAllocation.NotAvailable;
			this.fpNavigationPane.Name = "fpNavigationPane";
			this.fpNavigationPane.OutputParameters.Availablity = SE.App2Base.SupportClasses.FpIconSymbolAllocation.NotAvailable;
			this.fpNavigationPane.Owner.AliasName = "";
			this.fpNavigationPane.Owner.Availablity = SE.App2Base.SupportClasses.FpIconSymbolAllocation.Slot1R;
			this.fpNavigationPane.Owner.InstanceName = null;
			this.fpNavigationPane.Owner.ParentTitle = "Title";
			this.fpNavigationPane.Owner.SymbolType = "SE.App2Base.Symbols.Owner.sOwnerConfig";
			this.fpNavigationPane.Parameter.Availablity = SE.App2Base.SupportClasses.FpIconSymbolAllocation.Slot2R;
			this.fpNavigationPane.ParentTitle = "";
			this.fpNavigationPane.Permissive.AliasName = "";
			this.fpNavigationPane.Permissive.Availablity = SE.App2Base.SupportClasses.FpIconSymbolAllocation.Slot4L;
			this.fpNavigationPane.Permissive.InstanceName = null;
			this.fpNavigationPane.Permissive.LabelActive1 = SE.App2Base.SupportClasses.CondActive1LabelText.On;
			this.fpNavigationPane.Permissive.LabelPassive = SE.App2Base.SupportClasses.CondPassiveLabelText.Off;
			this.fpNavigationPane.Permissive.ParentTitle = "Title";
			this.fpNavigationPane.Permissive.SymbolType = "SE.AppCommonProcess.Symbols.PermCondSum.sPermissive";
			this.fpNavigationPane.SecMode = 6;
			this.fpNavigationPane.SecOwner = 3;
			this.fpNavigationPane.SecParameter = 12;
			this.fpNavigationPane.SecSetpoint = 3;
			this.fpNavigationPane.ShortFlush.AliasName = "";
			this.fpNavigationPane.ShortFlush.Availablity = SE.App2Base.SupportClasses.FpIconSymbolAllocation.NotAvailable;
			this.fpNavigationPane.ShortFlush.InstanceName = null;
			this.fpNavigationPane.ShortFlush.ParentTitle = "Title";
			this.fpNavigationPane.ShortFlush.SymbolType = "SE.AppWWW.Symbols.ShortFlush.sDefault";
			this.fpNavigationPane.Trend.Availablity = SE.App2Base.SupportClasses.FpIconSymbolAllocation.Slot3R;
			this.fpNavigationPane.OnParameterClick += new SE.App2Base.Graphics.FpNavigationPane.ParameterClicked(this.FpNavigationPaneOnParameterClick);
			this.fpNavigationPane.OnTrendClick += new SE.App2Base.Graphics.FpNavigationPane.TrendClicked(this.FpNavigationPaneOnTrendClick);
			this.fpNavigationPane.EndInit();
			// 
			// Sim
			// 
			this.Sim.BeginInit();
			this.Sim.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.Sim.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.Sim.Name = "Sim";
			this.Sim.SecurityLevel = 0;
			this.Sim.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.Sim.TagName = "Simulation";
			this.Sim.Value = false;
			this.Sim.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.SimValueChanged);
			this.Sim.EndInit();
			// 
			// Over
			// 
			this.Over.BeginInit();
			this.Over.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.Over.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.Over.Name = "Over";
			this.Over.SecurityLevel = 0;
			this.Over.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.Over.TagName = "FbOverride";
			this.Over.Value = false;
			this.Over.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.OverValueChanged);
			this.Over.EndInit();
			// 
			// Maint
			// 
			this.Maint.BeginInit();
			this.Maint.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.Maint.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.Maint.Name = "Maint";
			this.Maint.SecurityLevel = 0;
			this.Maint.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.Maint.TagName = "Maintenance";
			this.Maint.Value = false;
			this.Maint.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.MaintValueChanged);
			this.Maint.EndInit();
			// 
			// Oos
			// 
			this.Oos.BeginInit();
			this.Oos.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.Oos.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.Oos.Name = "Oos";
			this.Oos.SecurityLevel = 0;
			this.Oos.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.Oos.TagName = "OutOfService";
			this.Oos.Value = false;
			this.Oos.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.OosValueChanged);
			this.Oos.EndInit();
			// 
			// ownerStatus
			// 
			this.ownerStatus.BeginInit();
			this.ownerStatus.CurrentBasicOwner = false;
			this.ownerStatus.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 5D, 74D);
			this.ownerStatus.ExternalAvailable = false;
			this.ownerStatus.InstanceName = "";
			this.ownerStatus.Name = "ownerStatus";
			this.ownerStatus.EndInit();
			// 
			// ownerSwitch
			// 
			this.ownerSwitch.BeginInit();
			this.ownerSwitch.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 5D, 169D);
			this.ownerSwitch.ExternalAvailable = false;
			this.ownerSwitch.InstanceName = "";
			this.ownerSwitch.Name = "ownerSwitch";
			this.ownerSwitch.SecOwner = 0;
			this.ownerSwitch.SecurityToken = ((uint)(4294967295u));
			this.ownerSwitch.OnBasicOwnerChanged += new SE.App2Base.Graphics.OwnerSwitchBasic.BasicOwnerChanged(this.OwnerSwitchOnBasicOwnerChanged);
			this.ownerSwitch.EndInit();
			// 
			// CurrentOwnerBasic
			// 
			this.CurrentOwnerBasic.BeginInit();
			this.CurrentOwnerBasic.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.CurrentOwnerBasic.IsOnlyInput = true;
			this.CurrentOwnerBasic.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.CurrentOwnerBasic.Name = "CurrentOwnerBasic";
			this.CurrentOwnerBasic.SecurityLevel = 0;
			this.CurrentOwnerBasic.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.CurrentOwnerBasic.TagName = "CurrentOwner";
			this.CurrentOwnerBasic.Value = ((ushort)(0));
			this.CurrentOwnerBasic.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.CurrentOwnerBasicValueChanged);
			this.CurrentOwnerBasic.EndInit();
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
			// fpDefault
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(275D)), ((float)(350D)));
			this.Brush = new NxtControl.Drawing.Brush("FpBackgroundBrush");
			this.FormBorderStyle = NxtControl.GuiFramework.FormBorderStyle.FixedSingle;
			this.SecurityToken = ((uint)(4294967175u));
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.IconBottomBorder1,
			this.btnManOff,
			this.btnManOn,
			this.btnReset,
			this.NeedReset,
			this.Fb,
			this.CurrentSp,
			this.TransFbStatus,
			this.lblReqOp,
			this.lblAutoSp,
			this.lblIsPv,
			this.labelS2,
			this.labelS1,
			this.labelS3,
			this.Sim,
			this.Over,
			this.Maint,
			this.Oos,
			this.ownerStatus,
			this.ownerSwitch,
			this.CurrentOwnerBasic,
			this.CurrentOp,
			this.StdOwnerConnected,
			this.ExternalControlled,
			this.fpNavigationPane});
			this.Size = new System.Drawing.Size(275, 350);
			this.SecurityOwnerChanged += new SE.App2Base.Faceplates.SEAppLibHMIFaceplate.OnSecurityOwnerChanged(this.FpDefaultSecurityOwnerChanged);
			this.SecurityParameterChanged += new SE.App2Base.Faceplates.SEAppLibHMIFaceplate.OnSecurityParameterChanged(this.FpDefaultSecurityParameterChanged);
			this.SecuritySetpointChanged += new SE.App2Base.Faceplates.SEAppLibHMIFaceplate.OnSecuritySetpointChanged(this.FpDefaultSecuritySetpointChanged);
			this.UpdateOptionalService += new SE.App2Base.Faceplates.SEAppLibHMIFaceplate.OnUpdateOptionalService(this.FpDefaultUpdateOptionalService);

		}
		private NxtControl.GuiFramework.Line line7;
		private NxtControl.GuiFramework.Line line1;
		private NxtControl.GuiFramework.Group IconBottomBorder1;
		private NxtControl.GuiFramework.Label lblIsPv;
		private NxtControl.GuiFramework.Label lblReqOp;
		private NxtControl.GuiFramework.DrawnButton btnManOff;
		private NxtControl.GuiFramework.DrawnButton btnManOn;
		private NxtControl.GuiFramework.DrawnButton btnReset;
		private System.HMI.Symbols.Base.Execute<bool> NeedReset;
		private System.HMI.Symbols.Base.Execute<short> Fb;
		private System.HMI.Symbols.Base.Execute<short> CurrentSp;
		private System.HMI.Symbols.Base.Execute<short> TransFbStatus;
		private NxtControl.GuiFramework.Label lblAutoSp;
		private SE.App2Base.Graphics.LabelS labelS2;
		private SE.App2Base.Graphics.LabelS labelS1;
		private SE.App2Base.Graphics.LabelS labelS3;
		private SE.App2Base.Graphics.FpNavigationPane fpNavigationPane;
		private System.HMI.Symbols.Base.Execute<bool> Sim;
		private System.HMI.Symbols.Base.Execute<bool> Over;
		private System.HMI.Symbols.Base.Execute<bool> Maint;
		private System.HMI.Symbols.Base.Execute<bool> Oos;
		private SE.App2Base.Graphics.OwnerStatusBasic ownerStatus;
		private SE.App2Base.Graphics.OwnerSwitchBasic ownerSwitch;
		private System.HMI.Symbols.Base.Execute<ushort> CurrentOwnerBasic;
		private System.HMI.Symbols.Base.Execute<short> CurrentOp;
		private System.HMI.Symbols.Base.Execute<bool> StdOwnerConnected;
		private System.HMI.Symbols.Base.Execute<bool> ExternalControlled;
		#endregion
	}
}



