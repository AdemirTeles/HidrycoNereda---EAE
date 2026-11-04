/*
 * Created by EcoStruxure Automation Expert.
 * User: SESA397657
 * Date: 13/03/2021
 * Time: 1:56 pm
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.MotorBaseNer
{
	/// <summary>
	/// Summary description for sDefault.
	/// </summary>
	partial class sBlower
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.MotBase = new NxtControl.GuiFramework.Ellipse();
			this.FbStatus = new System.HMI.Symbols.Base.Execute<short>();
			this.TransFbStatus = new System.HMI.Symbols.Base.Execute<short>();
			this.Inlet = new NxtControl.GuiFramework.Rectangle();
			this.ellipse1 = new NxtControl.GuiFramework.Ellipse();
			this.ellipse2 = new NxtControl.GuiFramework.Ellipse();
			this.line2 = new NxtControl.GuiFramework.Line();
			this.line4 = new NxtControl.GuiFramework.Line();
			this.line5 = new NxtControl.GuiFramework.Line();
			this.line6 = new NxtControl.GuiFramework.Line();
			this.line7 = new NxtControl.GuiFramework.Line();
			this.line8 = new NxtControl.GuiFramework.Line();
			this.group1 = new NxtControl.GuiFramework.Group();
			this.group2 = new NxtControl.GuiFramework.Group();
			this.abnormal = new SE.App2Base.Graphics.Abnormal();
			this.Sim = new System.HMI.Symbols.Base.Execute<bool>();
			this.Over = new System.HMI.Symbols.Base.Execute<bool>();
			this.Maint = new System.HMI.Symbols.Base.Execute<bool>();
			this.NeedReset = new System.HMI.Symbols.Base.Execute<bool>();
			this.failure = new SE.App2CommonProcess.Graphics.FailureSmallBasic();
			this.interlock = new SE.App2CommonProcess.Graphics.InterlockSmallBasic();
			this.permissive = new SE.App2CommonProcess.Graphics.PermissiveSmallBasic();
			this.owner = new SE.App2Base.Graphics.OwnerBasic();
			this.Fail = new System.HMI.Symbols.Base.Execute<bool>();
			this.Ilck = new System.HMI.Symbols.Base.Execute<bool>();
			this.PermStop = new System.HMI.Symbols.Base.Execute<bool>();
			this.PermRun = new System.HMI.Symbols.Base.Execute<bool>();
			this.alarmFrame1 = new NxtControl.GuiFramework.AlarmFrame();
			this.Oos = new System.HMI.Symbols.Base.Execute<bool>();
			this.state = new SE.App2Base.Graphics.State();
			this.CurrentOp = new System.HMI.Symbols.Base.Execute<short>();
			this.StdOwnerConnected = new System.HMI.Symbols.Base.Execute<bool>();
			this.CurrentOwner = new System.HMI.Symbols.Base.Execute<ushort>();
			this.InstanceName = new NxtControl.GuiFramework.AliasDisplayLabel();
			this.ExternalControlled = new System.HMI.Symbols.Base.Execute<bool>();
			this.execute_11 = new System.HMI.Symbols.Base.Execute<NxtControl.GuiFramework.VTQ<bool>>();
			this.execute_12 = new System.HMI.Symbols.Base.Execute<NxtControl.GuiFramework.VTQ<bool>>();
			((System.ComponentModel.ISupportInitialize)(this.alarmFrame1)).BeginInit();
			// 
			// MotBase
			// 
			this.MotBase.Bounds = new NxtControl.Drawing.RectF(((float)(62D)), ((float)(49D)), ((float)(22D)), ((float)(22D)));
			this.MotBase.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("SE.App2Base.aaLibSymBodyActive"));
			this.MotBase.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.MotBase.Name = "MotBase";
			this.MotBase.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("fpDefault", NxtControl.GuiFramework.MouseButtonType.Click));
			this.MotBase.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("SymStaticIconColor"), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// FbStatus
			// 
			this.FbStatus.BeginInit();
			this.FbStatus.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.FbStatus.IsOnlyInput = true;
			this.FbStatus.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.FbStatus.Name = "FbStatus";
			this.FbStatus.SecurityLevel = 0;
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
			this.TransFbStatus.SecurityLevel = 0;
			this.TransFbStatus.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.TransFbStatus.TagName = "TransFbStatus";
			this.TransFbStatus.Value = ((short)(0));
			this.TransFbStatus.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.TransFbStatusValueChanged);
			this.TransFbStatus.EndInit();
			// 
			// Inlet
			// 
			this.Inlet.Bounds = new NxtControl.Drawing.RectF(((float)(74D)), ((float)(49D)), ((float)(13D)), ((float)(10D)));
			this.Inlet.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("SE.App2Base.aaLibSymBodyActive"));
			this.Inlet.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.Inlet.Name = "Inlet";
			this.Inlet.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("SymStaticIconColor"), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// ellipse1
			// 
			this.ellipse1.Bounds = new NxtControl.Drawing.RectF(((float)(70D)), ((float)(58D)), ((float)(5D)), ((float)(5D)));
			this.ellipse1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("Transparent"));
			this.ellipse1.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.ellipse1.Name = "ellipse1";
			this.ellipse1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("SymStaticIconColor"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.ellipse1.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
			// 
			// ellipse2
			// 
			this.ellipse2.Bounds = new NxtControl.Drawing.RectF(((float)(65D)), ((float)(53D)), ((float)(15D)), ((float)(15D)));
			this.ellipse2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("Transparent"));
			this.ellipse2.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.ellipse2.Name = "ellipse2";
			this.ellipse2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("SymStaticIconColor"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.ellipse2.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
			// 
			// line2
			// 
			this.line2.EndPoint = new NxtControl.Drawing.PointF(71D, 62D);
			this.line2.Name = "line2";
			this.line2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("SymStaticIconColor"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line2.StartPoint = new NxtControl.Drawing.PointF(66D, 64D);
			// 
			// line4
			// 
			this.line4.EndPoint = new NxtControl.Drawing.PointF(73D, 53D);
			this.line4.Name = "line4";
			this.line4.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("SymStaticIconColor"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line4.StartPoint = new NxtControl.Drawing.PointF(73D, 58D);
			// 
			// line5
			// 
			this.line5.EndPoint = new NxtControl.Drawing.PointF(79D, 64D);
			this.line5.Name = "line5";
			this.line5.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("SymStaticIconColor"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line5.StartPoint = new NxtControl.Drawing.PointF(74D, 62D);
			// 
			// line6
			// 
			this.line6.EndPoint = new NxtControl.Drawing.PointF(73D, 63D);
			this.line6.Name = "line6";
			this.line6.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("SymStaticIconColor"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line6.StartPoint = new NxtControl.Drawing.PointF(73D, 68D);
			// 
			// line7
			// 
			this.line7.EndPoint = new NxtControl.Drawing.PointF(71D, 59D);
			this.line7.Name = "line7";
			this.line7.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("SymStaticIconColor"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line7.StartPoint = new NxtControl.Drawing.PointF(66D, 57D);
			// 
			// line8
			// 
			this.line8.EndPoint = new NxtControl.Drawing.PointF(79D, 56D);
			this.line8.Name = "line8";
			this.line8.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("SymStaticIconColor"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line8.StartPoint = new NxtControl.Drawing.PointF(74D, 59D);
			// 
			// group1
			// 
			this.group1.BeginInit();
			this.group1.Name = "group1";
			this.group1.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.ellipse1,
			this.ellipse2,
			this.line2,
			this.line4,
			this.line5,
			this.line6,
			this.line7,
			this.line8});
			this.group1.EndInit();
			// 
			// group2
			// 
			this.group2.BeginInit();
			this.group2.Name = "group2";
			this.group2.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("fpDefault", NxtControl.GuiFramework.MouseButtonType.Click));
			this.group2.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.MotBase,
			this.group1});
			this.group2.EndInit();
			// 
			// abnormal
			// 
			this.abnormal.BeginInit();
			this.abnormal.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 80D, 60D);
			this.abnormal.Name = "abnormal";
			this.abnormal.EndInit();
			// 
			// Sim
			// 
			this.Sim.BeginInit();
			this.Sim.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.Sim.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.Sim.Name = "Sim";
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
			this.Maint.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.Maint.TagName = "Maintenance";
			this.Maint.Value = false;
			this.Maint.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.MaintValueChanged);
			this.Maint.EndInit();
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
			// failure
			// 
			this.failure.BeginInit();
			this.failure.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 84D, 28D);
			this.failure.FailSignal = false;
			this.failure.InstanceName = "";
			this.failure.Name = "failure";
			this.failure.OnAbnormalDetected += new SE.App2CommonProcess.Graphics.FailureSmallBasic.AbnormalDetected(this.FailureHOnAbnormalDetected);
			this.failure.OnAvailablityChanged += new SE.App2CommonProcess.Graphics.FailureSmallBasic.AvailablityChanged(this.FailureOnAvailablityChanged);
			this.failure.EndInit();
			// 
			// interlock
			// 
			this.interlock.BeginInit();
			this.interlock.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 51D, 28D);
			this.interlock.InstanceName = "";
			this.interlock.InterlockSignal = false;
			this.interlock.Name = "interlock";
			this.interlock.OnAbnormalDetected += new SE.App2CommonProcess.Graphics.InterlockSmallBasic.AbnormalDetected(this.InterlockHOnAbnormalDetected);
			this.interlock.OnAvailablityChanged += new SE.App2CommonProcess.Graphics.InterlockSmallBasic.AvailablityChanged(this.InterlockOnAvailablityChanged);
			this.interlock.EndInit();
			// 
			// permissive
			// 
			this.permissive.BeginInit();
			this.permissive.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 68D, 28D);
			this.permissive.InstanceName = "";
			this.permissive.Name = "permissive";
			this.permissive.PermissiveActive1Signal = false;
			this.permissive.PermissiveActive2Signal = false;
			this.permissive.PermissivePassiveSignal = false;
			this.permissive.OnAbnormalDetected += new SE.App2CommonProcess.Graphics.PermissiveSmallBasic.AbnormalDetected(this.PermissiveHOnAbnormalDetected);
			this.permissive.OnAvailablityChanged += new SE.App2CommonProcess.Graphics.PermissiveSmallBasic.AvailablityChanged(this.PermissiveOnAvailablityChanged);
			this.permissive.EndInit();
			// 
			// owner
			// 
			this.owner.BeginInit();
			this.owner.BasicOwner = ((ushort)(0));
			this.owner.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 84D, 80D);
			this.owner.ExternalAvailable = false;
			this.owner.InstanceName = "";
			this.owner.Name = "owner";
			this.owner.OnAbnormalDetected += new SE.App2Base.Graphics.OwnerBasic.AbnormalDetected(this.OwnerOnAbnormalDetected);
			this.owner.EndInit();
			// 
			// Fail
			// 
			this.Fail.BeginInit();
			this.Fail.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.Fail.IsOnlyInput = true;
			this.Fail.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.Fail.Name = "Fail";
			this.Fail.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.Fail.TagName = "Fail";
			this.Fail.Value = false;
			this.Fail.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.FailValueChanged);
			this.Fail.EndInit();
			// 
			// Ilck
			// 
			this.Ilck.BeginInit();
			this.Ilck.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.Ilck.IsOnlyInput = true;
			this.Ilck.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.Ilck.Name = "Ilck";
			this.Ilck.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.Ilck.TagName = "IlckCond";
			this.Ilck.Value = false;
			this.Ilck.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.IlckValueChanged);
			this.Ilck.EndInit();
			// 
			// PermStop
			// 
			this.PermStop.BeginInit();
			this.PermStop.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.PermStop.IsOnlyInput = true;
			this.PermStop.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.PermStop.Name = "PermStop";
			this.PermStop.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.PermStop.TagName = "PermStop";
			this.PermStop.Value = false;
			this.PermStop.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.PermStopValueChanged);
			this.PermStop.EndInit();
			// 
			// PermRun
			// 
			this.PermRun.BeginInit();
			this.PermRun.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.PermRun.IsOnlyInput = true;
			this.PermRun.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.PermRun.Name = "PermRun";
			this.PermRun.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.PermRun.TagName = "PermRun";
			this.PermRun.Value = false;
			this.PermRun.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.PermRunValueChanged);
			this.PermRun.EndInit();
			// 
			// alarmFrame1
			// 
			this.alarmFrame1.Bounds = new NxtControl.Drawing.RectF(((float)(48D)), ((float)(26D)), ((float)(53D)), ((float)(71D)));
			this.alarmFrame1.FrameWidth = ((uint)(2u));
			this.alarmFrame1.Name = "alarmFrame1";
			this.alarmFrame1.Radius = 5D;
			// 
			// Oos
			// 
			this.Oos.BeginInit();
			this.Oos.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.Oos.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.Oos.Name = "Oos";
			this.Oos.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.Oos.TagName = "OutOfService";
			this.Oos.Value = false;
			this.Oos.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.OosValueChanged);
			this.Oos.EndInit();
			// 
			// state
			// 
			this.state.BeginInit();
			this.state.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 67D, 80D);
			this.state.ExternalControlled = false;
			this.state.Name = "state";
			this.state.EndInit();
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
			// InstanceName
			// 
			this.InstanceName.AngleIgnore = true;
			this.InstanceName.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.InstanceName.Bounds = new NxtControl.Drawing.RectF(((float)(43.5D)), ((float)(9D)), ((float)(58D)), ((float)(13D)));
			this.InstanceName.Brush = new NxtControl.Drawing.Brush();
			this.InstanceName.CustomInstanceName = null;
			this.InstanceName.Font = new NxtControl.Drawing.Font("SE.App2Base.SymInstanceLabel");
			this.InstanceName.FontScale = true;
			this.InstanceName.Name = "InstanceName";
			this.InstanceName.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.InstanceName.Text = "Motor";
			this.InstanceName.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			this.InstanceName.TextColor = new NxtControl.Drawing.Color("SE.App2Base.aaLibSymInstanceLabelTextColor");
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
			// execute_11
			// 
			this.execute_11.BeginInit();
			this.execute_11.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.execute_11.IsOnlyInput = true;
			this.execute_11.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.execute_11.Name = "execute_11";
			this.execute_11.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.execute_11.TagName = "DeviceFail";
			this.execute_11.Value = new NxtControl.GuiFramework.VTQ<bool>(false, new System.DateTime(((long)(0))), ((uint)(0u)));
			this.execute_11.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.DeviceFailValueChanged);
			this.execute_11.EndInit();
			// 
			// execute_12
			// 
			this.execute_12.BeginInit();
			this.execute_12.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.execute_12.IsOnlyInput = true;
			this.execute_12.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.execute_12.Name = "execute_12";
			this.execute_12.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.execute_12.TagName = "FbFail";
			this.execute_12.Value = new NxtControl.GuiFramework.VTQ<bool>(false, new System.DateTime(((long)(0))), ((uint)(0u)));
			this.execute_12.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.FbFailValueChanged);
			this.execute_12.EndInit();
			// 
			// sBlower
			// 
			this.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("fpDefault", NxtControl.GuiFramework.MouseButtonType.Click));
			this.SecurityToken = ((uint)(4294967175u));
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.alarmFrame1,
			this.FbStatus,
			this.TransFbStatus,
			this.Inlet,
			this.group2,
			this.abnormal,
			this.Sim,
			this.Over,
			this.Maint,
			this.NeedReset,
			this.failure,
			this.interlock,
			this.permissive,
			this.owner,
			this.Fail,
			this.Ilck,
			this.PermStop,
			this.PermRun,
			this.Oos,
			this.state,
			this.CurrentOp,
			this.StdOwnerConnected,
			this.CurrentOwner,
			this.InstanceName,
			this.ExternalControlled,
			this.execute_11,
			this.execute_12});
			this.SymbolSize = new System.Drawing.Size(150, 128);
			this.UpdateOptionalService += new SE.App2Base.Symbols.SEAppLibHMISymbol.OnUpdateOptionalService(this.SBlowerUpdateOptionalService);
			((System.ComponentModel.ISupportInitialize)(this.alarmFrame1)).EndInit();

		}
		private NxtControl.GuiFramework.Ellipse MotBase;
		private System.HMI.Symbols.Base.Execute<short> FbStatus;
		private System.HMI.Symbols.Base.Execute<short> TransFbStatus;
		private NxtControl.GuiFramework.Rectangle Inlet;
		private NxtControl.GuiFramework.Ellipse ellipse1;
		private NxtControl.GuiFramework.Ellipse ellipse2;
		private NxtControl.GuiFramework.Line line2;
		private NxtControl.GuiFramework.Line line4;
		private NxtControl.GuiFramework.Line line5;
		private NxtControl.GuiFramework.Line line6;
		private NxtControl.GuiFramework.Line line7;
		private NxtControl.GuiFramework.Line line8;
		private NxtControl.GuiFramework.Group group1;
		private NxtControl.GuiFramework.Group group2;
		private SE.App2Base.Graphics.Abnormal abnormal;
		private System.HMI.Symbols.Base.Execute<bool> Sim;
		private System.HMI.Symbols.Base.Execute<bool> Over;
		private System.HMI.Symbols.Base.Execute<bool> Maint;
		private System.HMI.Symbols.Base.Execute<bool> NeedReset;
		private SE.App2CommonProcess.Graphics.FailureSmallBasic failure;
		private SE.App2CommonProcess.Graphics.InterlockSmallBasic interlock;
		private SE.App2CommonProcess.Graphics.PermissiveSmallBasic permissive;
		private SE.App2Base.Graphics.OwnerBasic owner;
		private System.HMI.Symbols.Base.Execute<bool> Fail;
		private System.HMI.Symbols.Base.Execute<bool> Ilck;
		private System.HMI.Symbols.Base.Execute<bool> PermStop;
		private System.HMI.Symbols.Base.Execute<bool> PermRun;
		private NxtControl.GuiFramework.AlarmFrame alarmFrame1;
		private System.HMI.Symbols.Base.Execute<bool> Oos;
		private SE.App2Base.Graphics.State state;
		private System.HMI.Symbols.Base.Execute<short> CurrentOp;
		private System.HMI.Symbols.Base.Execute<bool> StdOwnerConnected;
		private System.HMI.Symbols.Base.Execute<ushort> CurrentOwner;
		private NxtControl.GuiFramework.AliasDisplayLabel InstanceName;
		private System.HMI.Symbols.Base.Execute<bool> ExternalControlled;
		private System.HMI.Symbols.Base.Execute<NxtControl.GuiFramework.VTQ<bool>> execute_11;
		private System.HMI.Symbols.Base.Execute<NxtControl.GuiFramework.VTQ<bool>> execute_12;
		#endregion
	}
}



