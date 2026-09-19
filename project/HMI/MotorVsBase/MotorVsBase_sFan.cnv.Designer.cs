using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace HMI.Main.Symbols.MotorVsBase
{
	/// <summary>
	/// Summary description for sMotor.
	/// </summary>
	partial class sFan
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.abnormal = new SE.App2Base.Graphics.Abnormal();
			this.alarmFrame = new NxtControl.GuiFramework.AlarmFrame();
			this.SMeters = new SE.App2Base.Graphics.SMeters();
			this.state = new SE.App2Base.Graphics.State();
			this.owner = new SE.App2Base.Graphics.OwnerBasic();
			this.FbStatus = new System.HMI.Symbols.Base.Execute<short>();
			this.TransFbStatus = new System.HMI.Symbols.Base.Execute<short>();
			this.SpeedFbStatus = new System.HMI.Symbols.Base.Execute<float>();
			this.CurrentOp = new System.HMI.Symbols.Base.Execute<short>();
			this.CurrentSpeedSp = new System.HMI.Symbols.Base.Execute<float>();
			this.NeedReset = new System.HMI.Symbols.Base.Execute<bool>();
			this.IlckCond = new System.HMI.Symbols.Base.Execute<bool>();
			this.Fail = new System.HMI.Symbols.Base.Execute<bool>();
			this.PermStop = new System.HMI.Symbols.Base.Execute<bool>();
			this.PermFwd = new System.HMI.Symbols.Base.Execute<bool>();
			this.PermRev = new System.HMI.Symbols.Base.Execute<bool>();
			this.StdOwnerConnected = new System.HMI.Symbols.Base.Execute<bool>();
			this.SpeedSpMax = new System.HMI.Symbols.Base.Execute<float>();
			this.Simulation = new System.HMI.Symbols.Base.Execute<bool>();
			this.FbOverride = new System.HMI.Symbols.Base.Execute<bool>();
			this.Maintenance = new System.HMI.Symbols.Base.Execute<bool>();
			this.OutOfService = new System.HMI.Symbols.Base.Execute<bool>();
			this.DisReverse = new System.HMI.Symbols.Base.Execute<bool>();
			this.failure = new SE.App2CommonProcess.Graphics.FailureSmallBasic();
			this.interlock = new SE.App2CommonProcess.Graphics.InterlockSmallBasic();
			this.permissive = new SE.App2CommonProcess.Graphics.PermissiveSmallBasic();
			this.CurrentOwner = new System.HMI.Symbols.Base.Execute<ushort>();
			this.InstanceName = new NxtControl.GuiFramework.AliasDisplayLabel();
			this.ExternalControlled = new System.HMI.Symbols.Base.Execute<bool>();
			this.execute_11 = new System.HMI.Symbols.Base.Execute<NxtControl.GuiFramework.VTQ<bool>>();
			this.execute_12 = new System.HMI.Symbols.Base.Execute<NxtControl.GuiFramework.VTQ<bool>>();
			this.symbol = new SE.App2CommonProcess.Graphics.SFan();
			((System.ComponentModel.ISupportInitialize)(this.alarmFrame)).BeginInit();
			// 
			// abnormal
			// 
			this.abnormal.BeginInit();
			this.abnormal.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 78D, 48D);
			this.abnormal.Name = "abnormal";
			this.abnormal.SymbolBackgroundClickState = GuiFramework.Shapes.SymbolBackgroundClickState.Unknown;
			this.abnormal.EndInit();
			// 
			// alarmFrame
			// 
			this.alarmFrame.Bounds = new NxtControl.Drawing.RectF(((float)(14D)), ((float)(22D)), ((float)(108D)), ((float)(134D)));
			this.alarmFrame.FrameWidth = ((uint)(2u));
			this.alarmFrame.Name = "alarmFrame";
			this.alarmFrame.Radius = 5D;
			// 
			// SMeters
			// 
			this.SMeters.BeginInit();
			this.SMeters.AbnormalXOffset = 0D;
			this.SMeters.AbnormalYOffset = 0D;
			this.SMeters.BarGraphSize = 96D;
			this.SMeters.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, -13D, -5D);
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
			this.SMeters.SymbolBackgroundClickState = GuiFramework.Shapes.SymbolBackgroundClickState.Unknown;
			this.SMeters.TextAlignmentPvSpOp = SE.App2Base.Graphics.SMeters.TextAlignment.Right;
			this.SMeters.TextLocationPvSpOp = SE.App2Base.Graphics.SMeters.TextLocation.Right;
			this.SMeters.Unit = "%";
			this.SMeters.ValuePct = 0D;
			this.SMeters.EndInit();
			// 
			// state
			// 
			this.state.BeginInit();
			this.state.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 60D, 61D);
			this.state.ExternalControlled = false;
			this.state.Name = "state";
			this.state.SymbolBackgroundClickState = GuiFramework.Shapes.SymbolBackgroundClickState.Unknown;
			this.state.EndInit();
			// 
			// owner
			// 
			this.owner.BeginInit();
			this.owner.BasicOwner = ((ushort)(0));
			this.owner.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 76D, 61D);
			this.owner.ExternalAvailable = false;
			this.owner.InstanceName = "";
			this.owner.Name = "owner";
			this.owner.SymbolBackgroundClickState = GuiFramework.Shapes.SymbolBackgroundClickState.Unknown;
			this.owner.OnAbnormalDetected += new SE.App2Base.Graphics.OwnerBasic.AbnormalDetected(this.OwnerOnAbnormalDetected);
			this.owner.EndInit();
			// 
			// FbStatus
			// 
			this.FbStatus.BeginInit();
			this.FbStatus.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.FbStatus.IsOnlyInput = true;
			this.FbStatus.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.FbStatus.Name = "FbStatus";
			this.FbStatus.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.FbStatus.SymbolBackgroundClickState = GuiFramework.Shapes.SymbolBackgroundClickState.Unknown;
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
			this.TransFbStatus.SymbolBackgroundClickState = GuiFramework.Shapes.SymbolBackgroundClickState.Unknown;
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
			this.SpeedFbStatus.SymbolBackgroundClickState = GuiFramework.Shapes.SymbolBackgroundClickState.Unknown;
			this.SpeedFbStatus.TagName = "SpeedFbStatus";
			this.SpeedFbStatus.Value = 0F;
			this.SpeedFbStatus.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.SpeedFbStatusValueChanged);
			this.SpeedFbStatus.EndInit();
			// 
			// CurrentOp
			// 
			this.CurrentOp.BeginInit();
			this.CurrentOp.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.CurrentOp.IsOnlyInput = true;
			this.CurrentOp.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.CurrentOp.Name = "CurrentOp";
			this.CurrentOp.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.CurrentOp.SymbolBackgroundClickState = GuiFramework.Shapes.SymbolBackgroundClickState.Unknown;
			this.CurrentOp.TagName = "CurrentOp";
			this.CurrentOp.Value = ((short)(0));
			this.CurrentOp.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.CurrentOpValueChanged);
			this.CurrentOp.EndInit();
			// 
			// CurrentSpeedSp
			// 
			this.CurrentSpeedSp.BeginInit();
			this.CurrentSpeedSp.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.CurrentSpeedSp.IsOnlyInput = true;
			this.CurrentSpeedSp.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.CurrentSpeedSp.Name = "CurrentSpeedSp";
			this.CurrentSpeedSp.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.CurrentSpeedSp.SymbolBackgroundClickState = GuiFramework.Shapes.SymbolBackgroundClickState.Unknown;
			this.CurrentSpeedSp.TagName = "CurrentSpeedSp";
			this.CurrentSpeedSp.Value = 0F;
			this.CurrentSpeedSp.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.CurrentSpeedSpValueChanged);
			this.CurrentSpeedSp.EndInit();
			// 
			// NeedReset
			// 
			this.NeedReset.BeginInit();
			this.NeedReset.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.NeedReset.IsOnlyInput = true;
			this.NeedReset.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.NeedReset.Name = "NeedReset";
			this.NeedReset.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.NeedReset.SymbolBackgroundClickState = GuiFramework.Shapes.SymbolBackgroundClickState.Unknown;
			this.NeedReset.TagName = "NeedReset";
			this.NeedReset.Value = false;
			this.NeedReset.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.NeedResetValueChanged);
			this.NeedReset.EndInit();
			// 
			// IlckCond
			// 
			this.IlckCond.BeginInit();
			this.IlckCond.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.IlckCond.IsOnlyInput = true;
			this.IlckCond.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.IlckCond.Name = "IlckCond";
			this.IlckCond.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.IlckCond.SymbolBackgroundClickState = GuiFramework.Shapes.SymbolBackgroundClickState.Unknown;
			this.IlckCond.TagName = "IlckCond";
			this.IlckCond.Value = false;
			this.IlckCond.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.IlckCondValueChanged);
			this.IlckCond.EndInit();
			// 
			// Fail
			// 
			this.Fail.BeginInit();
			this.Fail.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.Fail.IsOnlyInput = true;
			this.Fail.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.Fail.Name = "Fail";
			this.Fail.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.Fail.SymbolBackgroundClickState = GuiFramework.Shapes.SymbolBackgroundClickState.Unknown;
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
			this.PermStop.SymbolBackgroundClickState = GuiFramework.Shapes.SymbolBackgroundClickState.Unknown;
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
			this.PermFwd.SymbolBackgroundClickState = GuiFramework.Shapes.SymbolBackgroundClickState.Unknown;
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
			this.PermRev.SymbolBackgroundClickState = GuiFramework.Shapes.SymbolBackgroundClickState.Unknown;
			this.PermRev.TagName = "PermRev";
			this.PermRev.Value = false;
			this.PermRev.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.PermRevValueChanged);
			this.PermRev.EndInit();
			// 
			// StdOwnerConnected
			// 
			this.StdOwnerConnected.BeginInit();
			this.StdOwnerConnected.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.StdOwnerConnected.IsOnlyInput = true;
			this.StdOwnerConnected.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.StdOwnerConnected.Name = "StdOwnerConnected";
			this.StdOwnerConnected.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.StdOwnerConnected.SymbolBackgroundClickState = GuiFramework.Shapes.SymbolBackgroundClickState.Unknown;
			this.StdOwnerConnected.TagName = "StdOwnerConnected";
			this.StdOwnerConnected.Value = false;
			this.StdOwnerConnected.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.StdOwnerConnectedValueChanged);
			this.StdOwnerConnected.EndInit();
			// 
			// SpeedSpMax
			// 
			this.SpeedSpMax.BeginInit();
			this.SpeedSpMax.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.SpeedSpMax.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.SpeedSpMax.Name = "SpeedSpMax";
			this.SpeedSpMax.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.SpeedSpMax.SymbolBackgroundClickState = GuiFramework.Shapes.SymbolBackgroundClickState.Unknown;
			this.SpeedSpMax.TagName = "SpeedSpMax";
			this.SpeedSpMax.Value = 0F;
			this.SpeedSpMax.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.SpeedSpMaxValueChanged);
			this.SpeedSpMax.EndInit();
			// 
			// Simulation
			// 
			this.Simulation.BeginInit();
			this.Simulation.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.Simulation.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.Simulation.Name = "Simulation";
			this.Simulation.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.Simulation.SymbolBackgroundClickState = GuiFramework.Shapes.SymbolBackgroundClickState.Unknown;
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
			this.FbOverride.SymbolBackgroundClickState = GuiFramework.Shapes.SymbolBackgroundClickState.Unknown;
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
			this.Maintenance.SymbolBackgroundClickState = GuiFramework.Shapes.SymbolBackgroundClickState.Unknown;
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
			this.OutOfService.SymbolBackgroundClickState = GuiFramework.Shapes.SymbolBackgroundClickState.Unknown;
			this.OutOfService.TagName = "OutOfService";
			this.OutOfService.Value = false;
			this.OutOfService.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.OutOfServiceValueChanged);
			this.OutOfService.EndInit();
			// 
			// DisReverse
			// 
			this.DisReverse.BeginInit();
			this.DisReverse.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.DisReverse.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.DisReverse.Name = "DisReverse";
			this.DisReverse.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.DisReverse.SymbolBackgroundClickState = GuiFramework.Shapes.SymbolBackgroundClickState.Unknown;
			this.DisReverse.TagName = "DisReverse";
			this.DisReverse.Value = false;
			this.DisReverse.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.DisReverseValueChanged);
			this.DisReverse.EndInit();
			// 
			// failure
			// 
			this.failure.BeginInit();
			this.failure.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 41D, 61D);
			this.failure.FailSignal = false;
			this.failure.InstanceName = "";
			this.failure.Name = "failure";
			this.failure.SymbolBackgroundClickState = GuiFramework.Shapes.SymbolBackgroundClickState.Unknown;
			this.failure.SymbolType = "SE.App2CommonProcess.Symbols.FailCondSum.sFailureSmall";
			this.failure.OnAbnormalDetected += new SE.App2CommonProcess.Graphics.FailureSmallBasic.AbnormalDetected(this.FailureOnAbnormalDetected);
			this.failure.OnAvailablityChanged += new SE.App2CommonProcess.Graphics.FailureSmallBasic.AvailablityChanged(this.FailureOnAvailablityChanged);
			this.failure.EndInit();
			// 
			// interlock
			// 
			this.interlock.BeginInit();
			this.interlock.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 41D, 27D);
			this.interlock.InstanceName = "";
			this.interlock.InterlockSignal = false;
			this.interlock.Name = "interlock";
			this.interlock.SymbolBackgroundClickState = GuiFramework.Shapes.SymbolBackgroundClickState.Unknown;
			this.interlock.SymbolType = "SE.App2CommonProcess.Symbols.IlckCondSum.sInterlockSmall";
			this.interlock.OnAbnormalDetected += new SE.App2CommonProcess.Graphics.InterlockSmallBasic.AbnormalDetected(this.InterlockOnAbnormalDetected);
			this.interlock.OnAvailablityChanged += new SE.App2CommonProcess.Graphics.InterlockSmallBasic.AvailablityChanged(this.InterlockOnAvailablityChanged);
			this.interlock.EndInit();
			// 
			// permissive
			// 
			this.permissive.BeginInit();
			this.permissive.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 41D, 44D);
			this.permissive.InstanceName = "";
			this.permissive.Name = "permissive";
			this.permissive.PermissiveActive1Signal = false;
			this.permissive.PermissiveActive2Signal = false;
			this.permissive.PermissivePassiveSignal = false;
			this.permissive.SymbolBackgroundClickState = GuiFramework.Shapes.SymbolBackgroundClickState.Unknown;
			this.permissive.SymbolType = "SE.App2CommonProcess.Symbols.PermCondSum.sPermissiveSmall";
			this.permissive.OnAbnormalDetected += new SE.App2CommonProcess.Graphics.PermissiveSmallBasic.AbnormalDetected(this.PermissiveOnAbnormalDetected);
			this.permissive.OnAvailablityChanged += new SE.App2CommonProcess.Graphics.PermissiveSmallBasic.AvailablityChanged(this.PermissiveOnAvailablityChanged);
			this.permissive.EndInit();
			// 
			// CurrentOwner
			// 
			this.CurrentOwner.BeginInit();
			this.CurrentOwner.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.CurrentOwner.IsOnlyInput = true;
			this.CurrentOwner.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.CurrentOwner.Name = "CurrentOwner";
			this.CurrentOwner.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.CurrentOwner.SymbolBackgroundClickState = GuiFramework.Shapes.SymbolBackgroundClickState.Unknown;
			this.CurrentOwner.TagName = "CurrentOwner";
			this.CurrentOwner.Value = ((ushort)(0));
			this.CurrentOwner.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.CurrentOwnerValueChanged);
			this.CurrentOwner.EndInit();
			// 
			// InstanceName
			// 
			this.InstanceName.AngleIgnore = true;
			this.InstanceName.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.InstanceName.Bounds = new NxtControl.Drawing.RectF(((float)(18D)), ((float)(3.5D)), ((float)(42D)), ((float)(16D)));
			this.InstanceName.Brush = new NxtControl.Drawing.Brush(true);
			this.InstanceName.CustomInstanceName = null;
			this.InstanceName.Font = new NxtControl.Drawing.Font("SE.App2Base.SymInstanceLabel");
			this.InstanceName.FontScale = true;
			this.InstanceName.Name = "InstanceName";
			this.InstanceName.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.InstanceName.Text = "Label";
			this.InstanceName.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.InstanceName.TextAutoSize = true;
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
			this.ExternalControlled.SymbolBackgroundClickState = GuiFramework.Shapes.SymbolBackgroundClickState.Unknown;
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
			this.execute_11.SymbolBackgroundClickState = GuiFramework.Shapes.SymbolBackgroundClickState.Unknown;
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
			this.execute_12.SymbolBackgroundClickState = GuiFramework.Shapes.SymbolBackgroundClickState.Unknown;
			this.execute_12.TagName = "FbFail";
			this.execute_12.Value = new NxtControl.GuiFramework.VTQ<bool>(false, new System.DateTime(((long)(0))), ((uint)(0u)));
			this.execute_12.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.FbFailValueChanged);
			this.execute_12.EndInit();
			// 
			// symbol
			// 
			this.symbol.BeginInit();
			this.symbol.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 60D, 17D);
			this.symbol.Name = "symbol";
			this.symbol.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("fpDefault", NxtControl.GuiFramework.MouseButtonType.Click));
			this.symbol.SymbolBackgroundClickState = GuiFramework.Shapes.SymbolBackgroundClickState.Unknown;
			this.symbol.EndInit();
			// 
			// sFan
			// 
			this.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("fpDefault", NxtControl.GuiFramework.MouseButtonType.Click));
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.alarmFrame,
			this.FbStatus,
			this.TransFbStatus,
			this.SpeedFbStatus,
			this.CurrentOp,
			this.CurrentSpeedSp,
			this.NeedReset,
			this.IlckCond,
			this.Fail,
			this.PermStop,
			this.PermFwd,
			this.PermRev,
			this.StdOwnerConnected,
			this.SpeedSpMax,
			this.Simulation,
			this.FbOverride,
			this.Maintenance,
			this.OutOfService,
			this.DisReverse,
			this.state,
			this.owner,
			this.failure,
			this.interlock,
			this.permissive,
			this.CurrentOwner,
			this.SMeters,
			this.InstanceName,
			this.ExternalControlled,
			this.execute_11,
			this.symbol,
			this.execute_12,
			this.abnormal});
			this.SymbolSize = new System.Drawing.Size(258, 211);
			this.UpdateOptionalService += new SE.App2Base.Symbols.SEAppLibHMISymbol.OnUpdateOptionalService(this.SMotorUpdateOptionalService);
			((System.ComponentModel.ISupportInitialize)(this.alarmFrame)).EndInit();

		}
		private SE.App2Base.Graphics.Abnormal abnormal;
		private NxtControl.GuiFramework.AlarmFrame alarmFrame;
		private NxtControl.GuiFramework.AliasDisplayLabel InstanceName;
		private SE.App2Base.Graphics.SMeters SMeters;
		private SE.App2Base.Graphics.State state;
		private SE.App2Base.Graphics.OwnerBasic owner;
		private System.HMI.Symbols.Base.Execute<short> FbStatus;
		private System.HMI.Symbols.Base.Execute<short> TransFbStatus;
		private System.HMI.Symbols.Base.Execute<float> SpeedFbStatus;
		private System.HMI.Symbols.Base.Execute<short> CurrentOp;
		private System.HMI.Symbols.Base.Execute<float> CurrentSpeedSp;
		private System.HMI.Symbols.Base.Execute<bool> NeedReset;
		private System.HMI.Symbols.Base.Execute<bool> IlckCond;
		private System.HMI.Symbols.Base.Execute<bool> Fail;
		private System.HMI.Symbols.Base.Execute<bool> PermStop;
		private System.HMI.Symbols.Base.Execute<bool> PermFwd;
		private System.HMI.Symbols.Base.Execute<bool> PermRev;
		private System.HMI.Symbols.Base.Execute<bool> StdOwnerConnected;
		private System.HMI.Symbols.Base.Execute<float> SpeedSpMax;
		private System.HMI.Symbols.Base.Execute<bool> Simulation;
		private System.HMI.Symbols.Base.Execute<bool> FbOverride;
		private System.HMI.Symbols.Base.Execute<bool> Maintenance;
		private System.HMI.Symbols.Base.Execute<bool> OutOfService;
		private System.HMI.Symbols.Base.Execute<bool> DisReverse;
		private SE.App2CommonProcess.Graphics.FailureSmallBasic failure;
		private SE.App2CommonProcess.Graphics.InterlockSmallBasic interlock;
		private SE.App2CommonProcess.Graphics.PermissiveSmallBasic permissive;
		private System.HMI.Symbols.Base.Execute<ushort> CurrentOwner;
		private System.HMI.Symbols.Base.Execute<bool> ExternalControlled;
		private System.HMI.Symbols.Base.Execute<NxtControl.GuiFramework.VTQ<bool>> execute_11;
		private System.HMI.Symbols.Base.Execute<NxtControl.GuiFramework.VTQ<bool>> execute_12;
		private SE.App2CommonProcess.Graphics.SFan symbol;
		#endregion
	}
}



