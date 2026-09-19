using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace HMI.Main.Symbols.MotorVsBase
{
	/// <summary>
	/// Summary description for sDefault.
	/// </summary>
	partial class sDefault
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.MotBase = new NxtControl.GuiFramework.Ellipse();
			this.ArcRev = new NxtControl.GuiFramework.Arc();
			this.Reverse = new NxtControl.GuiFramework.Group();
			this.Arrowrev = new NxtControl.GuiFramework.Polygon();
			this.arc1 = new NxtControl.GuiFramework.Arc();
			this.Arrowfwd = new NxtControl.GuiFramework.Polygon();
			this.Forward = new NxtControl.GuiFramework.Group();
			this.group1 = new NxtControl.GuiFramework.Group();
			this.Base = new NxtControl.GuiFramework.Polygon();
			this.alarmFrame = new NxtControl.GuiFramework.AlarmFrame();
			this.motorBody = new NxtControl.GuiFramework.Group();
			this.SMeters = new SE.App2Base.Graphics.SMeters();
			this.abnormal = new SE.App2Base.Graphics.Abnormal();
			this.failure = new SE.App2CommonProcess.Graphics.FailureSmallBasic();
			this.interlock = new SE.App2CommonProcess.Graphics.InterlockSmallBasic();
			this.permissive = new SE.App2CommonProcess.Graphics.PermissiveSmallBasic();
			this.FbStatus = new System.HMI.Symbols.Base.Execute<short>();
			this.TransFbStatus = new System.HMI.Symbols.Base.Execute<short>();
			this.SpeedFbStatus = new System.HMI.Symbols.Base.Execute<float>();
			this.Simulation = new System.HMI.Symbols.Base.Execute<bool>();
			this.FbOverride = new System.HMI.Symbols.Base.Execute<bool>();
			this.NeedReset = new System.HMI.Symbols.Base.Execute<bool>();
			this.OutOfService = new System.HMI.Symbols.Base.Execute<bool>();
			this.Fail = new System.HMI.Symbols.Base.Execute<bool>();
			this.PermStop = new System.HMI.Symbols.Base.Execute<bool>();
			this.PermFwd = new System.HMI.Symbols.Base.Execute<bool>();
			this.PermRev = new System.HMI.Symbols.Base.Execute<bool>();
			this.IlckCond = new System.HMI.Symbols.Base.Execute<bool>();
			this.StdOwnerConnected = new System.HMI.Symbols.Base.Execute<bool>();
			this.CurrentOp = new System.HMI.Symbols.Base.Execute<short>();
			this.SpeedSpMin = new System.HMI.Symbols.Base.Execute<float>();
			this.SpeedSpMax = new System.HMI.Symbols.Base.Execute<float>();
			this.Maintenance = new System.HMI.Symbols.Base.Execute<bool>();
			this.DisReverse = new System.HMI.Symbols.Base.Execute<bool>();
			this.state = new SE.App2Base.Graphics.State();
			this.CurrentSpeedSp = new System.HMI.Symbols.Base.Execute<float>();
			this.owner = new SE.App2Base.Graphics.OwnerBasic();
			this.clickFrame = new NxtControl.GuiFramework.Rectangle();
			this.CurrentOwner = new System.HMI.Symbols.Base.Execute<ushort>();
			this.InstanceName = new NxtControl.GuiFramework.AliasDisplayLabel();
			this.ExternalControlled = new System.HMI.Symbols.Base.Execute<bool>();
			this.DeviceFail = new System.HMI.Symbols.Base.Execute<NxtControl.GuiFramework.VTQ<bool>>();
			this.FbFail = new System.HMI.Symbols.Base.Execute<NxtControl.GuiFramework.VTQ<bool>>();
			((System.ComponentModel.ISupportInitialize)(this.alarmFrame)).BeginInit();
			// 
			// MotBase
			// 
			this.MotBase.Bounds = new NxtControl.Drawing.RectF(((float)(56D)), ((float)(43D)), ((float)(22D)), ((float)(22D)));
			this.MotBase.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("SE.App2Base.aaLibSymBodyActive"));
			this.MotBase.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.MotBase.Name = "MotBase";
			this.MotBase.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("SymStaticIconColor"), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// ArcRev
			// 
			this.ArcRev.Bounds = new NxtControl.Drawing.RectF(((float)(60D)), ((float)(47D)), ((float)(14D)), ((float)(14D)));
			this.ArcRev.Center = new NxtControl.Drawing.PointF(67D, 54D);
			this.ArcRev.Name = "ArcRev";
			this.ArcRev.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("SymStaticIconColor"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.ArcRev.RadiusX = 7D;
			this.ArcRev.RadiusY = 7D;
			this.ArcRev.StartAngle = 120D;
			this.ArcRev.SweepAngle = 250D;
			// 
			// Reverse
			// 
			this.Reverse.BeginInit();
			this.Reverse.Name = "Reverse";
			this.Reverse.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.ArcRev,
			this.Arrowrev});
			this.Reverse.EndInit();
			// 
			// Arrowrev
			// 
			this.Arrowrev.Bounds = new NxtControl.Drawing.RectF(((float)(62.8D)), ((float)(59.5D)), ((float)(2D)), ((float)(2D)));
			this.Arrowrev.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("SymStaticIconColor"));
			this.Arrowrev.Closed = true;
			this.Arrowrev.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.Arrowrev.Name = "Arrowrev";
			this.Arrowrev.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("SymStaticIconColor"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.Arrowrev.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(62.8D, 61.5D),
			new NxtControl.Drawing.PointF(64.8D, 59.5D),
			new NxtControl.Drawing.PointF(64.8D, 61.5D)});
			// 
			// arc1
			// 
			this.arc1.Bounds = new NxtControl.Drawing.RectF(((float)(60D)), ((float)(47D)), ((float)(14D)), ((float)(14D)));
			this.arc1.Center = new NxtControl.Drawing.PointF(67D, 54D);
			this.arc1.Name = "arc1";
			this.arc1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("SymStaticIconColor"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.arc1.RadiusX = 7D;
			this.arc1.RadiusY = 7D;
			this.arc1.StartAngle = 170D;
			this.arc1.SweepAngle = 250D;
			// 
			// Arrowfwd
			// 
			this.Arrowfwd.Bounds = new NxtControl.Drawing.RectF(((float)(70D)), ((float)(59D)), ((float)(2D)), ((float)(2D)));
			this.Arrowfwd.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("SymStaticIconColor"));
			this.Arrowfwd.Closed = true;
			this.Arrowfwd.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.Arrowfwd.Name = "Arrowfwd";
			this.Arrowfwd.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("SymStaticIconColor"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.Arrowfwd.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(72D, 61D),
			new NxtControl.Drawing.PointF(70D, 59D),
			new NxtControl.Drawing.PointF(70D, 61D)});
			// 
			// Forward
			// 
			this.Forward.BeginInit();
			this.Forward.Name = "Forward";
			this.Forward.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.Arrowfwd,
			this.arc1});
			this.Forward.EndInit();
			// 
			// group1
			// 
			this.group1.BeginInit();
			this.group1.Name = "group1";
			this.group1.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.Base,
			this.MotBase});
			this.group1.EndInit();
			// 
			// Base
			// 
			this.Base.Bounds = new NxtControl.Drawing.RectF(((float)(56D)), ((float)(59D)), ((float)(24D)), ((float)(8D)));
			this.Base.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("SE.App2Base.aaLibSymBodyActive"));
			this.Base.Closed = true;
			this.Base.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.Base.Name = "Base";
			this.Base.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("SymStaticIconColor"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.Base.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(56D, 67D),
			new NxtControl.Drawing.PointF(80D, 67D),
			new NxtControl.Drawing.PointF(72D, 59D),
			new NxtControl.Drawing.PointF(64D, 59D)});
			// 
			// alarmFrame
			// 
			this.alarmFrame.Bounds = new NxtControl.Drawing.RectF(((float)(14D)), ((float)(20D)), ((float)(108D)), ((float)(149D)));
			this.alarmFrame.FrameWidth = ((uint)(2u));
			this.alarmFrame.Name = "alarmFrame";
			this.alarmFrame.Radius = 5D;
			// 
			// motorBody
			// 
			this.motorBody.BeginInit();
			this.motorBody.Name = "motorBody";
			this.motorBody.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("fpDefault", NxtControl.GuiFramework.MouseButtonType.Click));
			this.motorBody.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.group1,
			this.Forward,
			this.Reverse});
			this.motorBody.EndInit();
			// 
			// SMeters
			// 
			this.SMeters.BeginInit();
			this.SMeters.AbnormalXOffset = 0D;
			this.SMeters.AbnormalYOffset = 0D;
			this.SMeters.BarGraphSize = 96D;
			this.SMeters.DecimalPlacesCount = ((uint)(2u));
			this.SMeters.DecimalPlacesCountOut = ((uint)(2u));
			this.SMeters.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, -13D, 11D);
			this.SMeters.display = SE.App2Base.Graphics.SMeters.Display.BarGraph;
			this.SMeters.FrameColor = new NxtControl.Drawing.Color("SymLineColor");
			this.SMeters.LeftOffset = ((uint)(60u));
			this.SMeters.Name = "SMeters";
			this.SMeters.NumericalVisible = SE.App2Base.Graphics.SMeters.NumericalDisplaySel.PvSp;
			this.SMeters.OpColor = new NxtControl.Drawing.Color("SE.App2Base.aaLibSymOp");
			this.SMeters.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("fpDefault", NxtControl.GuiFramework.MouseButtonType.Click));
			this.SMeters.PvColor = new NxtControl.Drawing.Color("SE.App2Base.aaLibSymPv");
			this.SMeters.RangeVisible = SE.App2Base.SupportClasses.BoolType.False;
			this.SMeters.Rotation = SE.App2Base.SupportClasses.Rotation.Horizontal;
			this.SMeters.SpColor = new NxtControl.Drawing.Color("SE.App2Base.aaLibSymSp");
			this.SMeters.SpIndicator = SE.App2Base.Graphics.SMeters.Indicator.PvBarSpTriangle;
			this.SMeters.TextAlignmentPvSpOp = SE.App2Base.Graphics.SMeters.TextAlignment.Right;
			this.SMeters.TextLocationPvSpOp = SE.App2Base.Graphics.SMeters.TextLocation.Right;
			this.SMeters.Unit = "%";
			this.SMeters.ValuePct = 0D;
			this.SMeters.EndInit();
			// 
			// abnormal
			// 
			this.abnormal.BeginInit();
			this.abnormal.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 74D, 55D);
			this.abnormal.Name = "abnormal";
			this.abnormal.EndInit();
			// 
			// failure
			// 
			this.failure.BeginInit();
			this.failure.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 78D, 24D);
			this.failure.FailSignal = false;
			this.failure.InstanceName = "";
			this.failure.Name = "failure";
			this.failure.OnAbnormalDetected += new SE.App2CommonProcess.Graphics.FailureSmallBasic.AbnormalDetected(this.FailureOnAbnormalDetected);
			this.failure.OnAvailablityChanged += new SE.App2CommonProcess.Graphics.FailureSmallBasic.AvailablityChanged(this.FailureOnAvailablityChanged);
			this.failure.EndInit();
			// 
			// interlock
			// 
			this.interlock.BeginInit();
			this.interlock.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 44D, 24D);
			this.interlock.InstanceName = "";
			this.interlock.InterlockSignal = false;
			this.interlock.Name = "interlock";
			this.interlock.OnAbnormalDetected += new SE.App2CommonProcess.Graphics.InterlockSmallBasic.AbnormalDetected(this.InterlockOnAbnormalDetected);
			this.interlock.OnAvailablityChanged += new SE.App2CommonProcess.Graphics.InterlockSmallBasic.AvailablityChanged(this.InterlockOnAvailablityChanged);
			this.interlock.EndInit();
			// 
			// permissive
			// 
			this.permissive.BeginInit();
			this.permissive.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 61D, 24D);
			this.permissive.InstanceName = "";
			this.permissive.Name = "permissive";
			this.permissive.PermissiveActive1Signal = false;
			this.permissive.PermissiveActive2Signal = false;
			this.permissive.PermissivePassiveSignal = false;
			this.permissive.OnAbnormalDetected += new SE.App2CommonProcess.Graphics.PermissiveSmallBasic.AbnormalDetected(this.PermissiveOnAbnormalDetected);
			this.permissive.OnAvailablityChanged += new SE.App2CommonProcess.Graphics.PermissiveSmallBasic.AvailablityChanged(this.PermissiveOnAvailablityChanged);
			this.permissive.EndInit();
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
			// PermFwd
			// 
			this.PermFwd.BeginInit();
			this.PermFwd.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.PermFwd.IsOnlyInput = true;
			this.PermFwd.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.PermFwd.Name = "PermFwd";
			this.PermFwd.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.PermFwd.TagName = "PermFwd";
			this.PermFwd.Value = false;
			this.PermFwd.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.PermFwdValueChanged);
			this.PermFwd.EndInit();
			// 
			// PermRev
			// 
			this.PermRev.BeginInit();
			this.PermRev.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.PermRev.IsOnlyInput = true;
			this.PermRev.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.PermRev.Name = "PermRev";
			this.PermRev.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.PermRev.TagName = "PermRev";
			this.PermRev.Value = false;
			this.PermRev.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.PermRevValueChanged);
			this.PermRev.EndInit();
			// 
			// IlckCond
			// 
			this.IlckCond.BeginInit();
			this.IlckCond.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.IlckCond.IsOnlyInput = true;
			this.IlckCond.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.IlckCond.Name = "IlckCond";
			this.IlckCond.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.IlckCond.TagName = "IlckCond";
			this.IlckCond.Value = false;
			this.IlckCond.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.IlckCondValueChanged);
			this.IlckCond.EndInit();
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
			// SpeedSpMin
			// 
			this.SpeedSpMin.BeginInit();
			this.SpeedSpMin.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.SpeedSpMin.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.SpeedSpMin.Name = "SpeedSpMin";
			this.SpeedSpMin.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.SpeedSpMin.TagName = "SpeedSpMin";
			this.SpeedSpMin.Value = 0F;
			this.SpeedSpMin.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.SpeedSpMinValueChanged);
			this.SpeedSpMin.EndInit();
			// 
			// SpeedSpMax
			// 
			this.SpeedSpMax.BeginInit();
			this.SpeedSpMax.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.SpeedSpMax.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.SpeedSpMax.Name = "SpeedSpMax";
			this.SpeedSpMax.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.SpeedSpMax.TagName = "SpeedSpMax";
			this.SpeedSpMax.Value = 0F;
			this.SpeedSpMax.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.SpeedSpMaxValueChanged);
			this.SpeedSpMax.EndInit();
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
			// state
			// 
			this.state.BeginInit();
			this.state.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 54D, 74D);
			this.state.ExternalControlled = false;
			this.state.Name = "state";
			this.state.EndInit();
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
			// owner
			// 
			this.owner.BeginInit();
			this.owner.BasicOwner = ((ushort)(0));
			this.owner.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 70D, 74D);
			this.owner.ExternalAvailable = false;
			this.owner.InstanceName = "";
			this.owner.Name = "owner";
			this.owner.OnAbnormalDetected += new SE.App2Base.Graphics.OwnerBasic.AbnormalDetected(this.OwnerOnAbnormalDetected);
			this.owner.EndInit();
			// 
			// clickFrame
			// 
			this.clickFrame.Bounds = new NxtControl.Drawing.RectF(((float)(26D)), ((float)(132D)), ((float)(24D)), ((float)(17D)));
			this.clickFrame.Brush = new NxtControl.Drawing.Brush();
			this.clickFrame.Font = new NxtControl.Drawing.Font("HMI Sans Serif", 9F, System.Drawing.FontStyle.Regular);
			this.clickFrame.Name = "clickFrame";
			this.clickFrame.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("fpDefault", NxtControl.GuiFramework.MouseButtonType.Click));
			this.clickFrame.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
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
			this.InstanceName.Bounds = new NxtControl.Drawing.RectF(((float)(18D)), ((float)(4D)), ((float)(100D)), ((float)(13D)));
			this.InstanceName.Brush = new NxtControl.Drawing.Brush();
			this.InstanceName.CustomInstanceName = null;
			this.InstanceName.Font = new NxtControl.Drawing.Font("SE.App2Base.SymInstanceLabel");
			this.InstanceName.FontScale = true;
			this.InstanceName.Name = "InstanceName";
			this.InstanceName.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.InstanceName.Text = "Label";
			this.InstanceName.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
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
			// DeviceFail
			// 
			this.DeviceFail.BeginInit();
			this.DeviceFail.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.DeviceFail.IsOnlyInput = true;
			this.DeviceFail.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.DeviceFail.Name = "DeviceFail";
			this.DeviceFail.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.DeviceFail.TagName = "DeviceFail";
			this.DeviceFail.Value = new NxtControl.GuiFramework.VTQ<bool>(false, new System.DateTime(((long)(0))), ((uint)(0u)));
			this.DeviceFail.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.DeviceFailValueChanged);
			this.DeviceFail.EndInit();
			// 
			// FbFail
			// 
			this.FbFail.BeginInit();
			this.FbFail.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.FbFail.IsOnlyInput = true;
			this.FbFail.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.FbFail.Name = "FbFail";
			this.FbFail.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.FbFail.TagName = "FbFail";
			this.FbFail.Value = new NxtControl.GuiFramework.VTQ<bool>(false, new System.DateTime(((long)(0))), ((uint)(0u)));
			this.FbFail.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.FbFailValueChanged);
			this.FbFail.EndInit();
			// 
			// sDefault
			// 
			this.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("fpDefault", NxtControl.GuiFramework.MouseButtonType.Click));
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.alarmFrame,
			this.motorBody,
			this.abnormal,
			this.failure,
			this.interlock,
			this.permissive,
			this.FbStatus,
			this.TransFbStatus,
			this.SpeedFbStatus,
			this.Simulation,
			this.FbOverride,
			this.NeedReset,
			this.OutOfService,
			this.Fail,
			this.PermStop,
			this.PermFwd,
			this.PermRev,
			this.IlckCond,
			this.StdOwnerConnected,
			this.CurrentOp,
			this.SpeedSpMin,
			this.SpeedSpMax,
			this.Maintenance,
			this.DisReverse,
			this.state,
			this.CurrentSpeedSp,
			this.owner,
			this.clickFrame,
			this.CurrentOwner,
			this.SMeters,
			this.InstanceName,
			this.ExternalControlled,
			this.DeviceFail,
			this.FbFail});
			this.SymbolSize = new System.Drawing.Size(136, 200);
			this.UpdateOptionalService += new SE.App2Base.Symbols.SEAppLibHMISymbol.OnUpdateOptionalService(this.SDefaultUpdateOptionalService);
			((System.ComponentModel.ISupportInitialize)(this.alarmFrame)).EndInit();

		}
		private NxtControl.GuiFramework.Ellipse MotBase;
		private NxtControl.GuiFramework.Arc ArcRev;
		private NxtControl.GuiFramework.Group Reverse;
		private NxtControl.GuiFramework.Polygon Arrowrev;
		private NxtControl.GuiFramework.Arc arc1;
		private NxtControl.GuiFramework.Polygon Arrowfwd;
		private NxtControl.GuiFramework.Group Forward;
		private NxtControl.GuiFramework.Group group1;
		private NxtControl.GuiFramework.Polygon Base;
		private NxtControl.GuiFramework.AlarmFrame alarmFrame;
		private NxtControl.GuiFramework.AliasDisplayLabel InstanceName;
		private NxtControl.GuiFramework.Group motorBody;
		private SE.App2Base.Graphics.SMeters SMeters;
		private SE.App2Base.Graphics.Abnormal abnormal;
		private SE.App2CommonProcess.Graphics.FailureSmallBasic failure;
		private SE.App2CommonProcess.Graphics.InterlockSmallBasic interlock;
		private SE.App2CommonProcess.Graphics.PermissiveSmallBasic permissive;
		private System.HMI.Symbols.Base.Execute<short> FbStatus;
		private System.HMI.Symbols.Base.Execute<short> TransFbStatus;
		private System.HMI.Symbols.Base.Execute<float> SpeedFbStatus;
		private System.HMI.Symbols.Base.Execute<bool> Simulation;
		private System.HMI.Symbols.Base.Execute<bool> FbOverride;
		private System.HMI.Symbols.Base.Execute<bool> NeedReset;
		private System.HMI.Symbols.Base.Execute<bool> OutOfService;
		private System.HMI.Symbols.Base.Execute<bool> Fail;
		private System.HMI.Symbols.Base.Execute<bool> PermStop;
		private System.HMI.Symbols.Base.Execute<bool> PermFwd;
		private System.HMI.Symbols.Base.Execute<bool> PermRev;
		private System.HMI.Symbols.Base.Execute<bool> IlckCond;
		private System.HMI.Symbols.Base.Execute<bool> StdOwnerConnected;
		private System.HMI.Symbols.Base.Execute<short> CurrentOp;
		private System.HMI.Symbols.Base.Execute<float> SpeedSpMin;
		private System.HMI.Symbols.Base.Execute<float> SpeedSpMax;
		private System.HMI.Symbols.Base.Execute<bool> Maintenance;
		private System.HMI.Symbols.Base.Execute<bool> DisReverse;
		private SE.App2Base.Graphics.State state;
		private System.HMI.Symbols.Base.Execute<float> CurrentSpeedSp;
		private SE.App2Base.Graphics.OwnerBasic owner;
		private NxtControl.GuiFramework.Rectangle clickFrame;
		private System.HMI.Symbols.Base.Execute<ushort> CurrentOwner;
		private System.HMI.Symbols.Base.Execute<bool> ExternalControlled;
		private System.HMI.Symbols.Base.Execute<NxtControl.GuiFramework.VTQ<bool>> DeviceFail;
		private System.HMI.Symbols.Base.Execute<NxtControl.GuiFramework.VTQ<bool>> FbFail;
		#endregion
	}
}



