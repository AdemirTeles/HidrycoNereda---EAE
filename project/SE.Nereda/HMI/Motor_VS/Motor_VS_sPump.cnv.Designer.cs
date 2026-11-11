/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 6/2/2026
 * Time: 9:20 AM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.Motor_VS
{
	/// <summary>
	/// Summary description for sDefault.
	/// </summary>
	partial class sPump
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
			this.raioCirc = new NxtControl.GuiFramework.Ellipse();
			this.raioRaio = new NxtControl.GuiFramework.Polygon();
			this.Pump = new NxtControl.GuiFramework.Ellipse();
			this.State = new SE.Nereda.Symbols.ActState.sCompacto();
			this.modo = new SE.Nereda.Symbols.ActState.sModo();
			this.alarmFrame = new NxtControl.GuiFramework.AlarmFrame();
			this.interlock = new SE.App2CommonProcess.Symbols.IlckCondSum.sInterlockSmall();
			this.failure = new SE.App2CommonProcess.Symbols.FailCondSum.sFailureSmall();
			this.permissive = new SE.App2CommonProcess.Symbols.PermCondSum.sPermissiveSmall();
			this.group1 = new NxtControl.GuiFramework.Group();
			this.MotName = new NxtControl.GuiFramework.Rectangle();
			this.OpenFp = new NxtControl.GuiFramework.Rectangle();
			this.PipeIn = new NxtControl.GuiFramework.Rectangle();
			this.PipeOut = new NxtControl.GuiFramework.Rectangle();
			this.BaseVs = new SE.Nereda.Symbols.MotorVsBaseNer.sDefault();
			this.SpeedSp = new System.HMI.Symbols.Base.FreeText<float>();
			this.FbSpeed = new System.HMI.Symbols.Base.FreeText<float>();
			this.Unit = new NxtControl.GuiFramework.FreeText();
			this.SpeedPv = new NxtControl.GuiFramework.Arc();
			this.SpeedInfo = new NxtControl.GuiFramework.Group();
			this.group2 = new NxtControl.GuiFramework.Group();
			((System.ComponentModel.ISupportInitialize)(this.alarmFrame)).BeginInit();
			// 
			// Pump
			// 
			this.Pump.Bounds = new NxtControl.Drawing.RectF(((float)(40D)), ((float)(48D)), ((float)(32D)), ((float)(32D)));
			this.Pump.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.Pump.Name = "Pump";
			// 
			// State
			// 
			this.State.BeginInit();
			this.State.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 40D, 92D);
			this.State.Name = "State";
			this.State.SecurityToken = ((uint)(4294967295u));
			this.State.TagName = "State";
			this.State.ActuatorStatus += new SE.Nereda.Symbols.ActState.sCompacto.ActState(this.StateActuatorStatus);
			this.State.EndInit();
			// 
			// alarmFrame
			// 
			this.alarmFrame.Bounds = new NxtControl.Drawing.RectF(((float)(37D)), ((float)(46D)), ((float)(41D)), ((float)(40D)));
			this.alarmFrame.FrameWidth = ((uint)(2u));
			this.alarmFrame.Name = "alarmFrame";
			this.alarmFrame.Radius = 5D;
			// 
			// interlock
			// 
			this.interlock.BeginInit();
			this.interlock.DefaultInstanceName = null;
			this.interlock.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 32D, 32D);
			this.interlock.Instancelayer = SE.App2Base.SupportClasses.InstanceLayer.Base;
			this.interlock.MyTagDisplayName = null;
			this.interlock.Name = "interlock";
			this.interlock.SecurityToken = ((uint)(4294967295u));
			this.interlock.TagName = "interlock";
			this.interlock.EndInit();
			// 
			// failure
			// 
			this.failure.BeginInit();
			this.failure.DefaultInstanceName = null;
			this.failure.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 64D, 32D);
			this.failure.Instancelayer = SE.App2Base.SupportClasses.InstanceLayer.Base;
			this.failure.MyTagDisplayName = null;
			this.failure.Name = "failure";
			this.failure.SecurityToken = ((uint)(4294967295u));
			this.failure.TagName = "failure";
			this.failure.EndInit();
			// 
			// permissive
			// 
			this.permissive.BeginInit();
			this.permissive.DefaultInstanceName = null;
			this.permissive.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 48D, 32D);
			this.permissive.Instancelayer = SE.App2Base.SupportClasses.InstanceLayer.Base;
			this.permissive.MyTagDisplayName = null;
			this.permissive.Name = "permissive";
			this.permissive.SecurityToken = ((uint)(4294967295u));
			this.permissive.TagName = "permissive";
			this.permissive.EndInit();
			// 
			// group1
			// 
			this.group1.BeginInit();
			this.group1.Name = "group1";
			this.group1.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.interlock,
			this.failure,
			this.permissive});
			this.group1.EndInit();
			// 
			// MotName
			// 
			this.MotName.Bounds = new NxtControl.Drawing.RectF(((float)(12D)), ((float)(16D)), ((float)(88D)), ((float)(16D)));
			this.MotName.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("transparent"));
			this.MotName.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.MotName.FontScale = true;
			this.MotName.Name = "MotName";
			this.MotName.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.MotName.Text = "Motor";
			this.MotName.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			// 
			// OpenFp
			// 
			this.OpenFp.Bounds = new NxtControl.Drawing.RectF(((float)(32D)), ((float)(48D)), ((float)(88D)), ((float)(56D)));
			this.OpenFp.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("transparent"));
			this.OpenFp.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.OpenFp.Name = "OpenFp";
			this.OpenFp.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.OpenFp.Click += new System.EventHandler(this.OpenFpClick);
			// 
			// PipeIn
			// 
			this.PipeIn.Bounds = new NxtControl.Drawing.RectF(((float)(38D)), ((float)(70D)), ((float)(16D)), ((float)(10D)));
			this.PipeIn.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.PipeIn.Name = "PipeIn";
			// 
			// PipeOut
			// 
			this.PipeOut.Bounds = new NxtControl.Drawing.RectF(((float)(58D)), ((float)(48D)), ((float)(16D)), ((float)(10D)));
			this.PipeOut.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.PipeOut.Name = "PipeOut";
			// 
			// BaseVs
			// 
			this.BaseVs.BeginInit();
			this.BaseVs.DefaultInstanceName = null;
			this.BaseVs.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.050015550305329642D, 0D, 0D, 0.050015550305329635D, 45.100031100610664D, 52.150046650916011D);
			this.BaseVs.Instancelayer = SE.App2Base.SupportClasses.InstanceLayer.Base;
			this.BaseVs.MyTagDisplayName = null;
			this.BaseVs.Name = "BaseVs";
			this.BaseVs.SecurityToken = ((uint)(4294967295u));
			this.BaseVs.TagName = "BaseVs";
			this.BaseVs.EndInit();
			// 
			// SpeedSp
			// 
			this.SpeedSp.BeginInit();
			this.SpeedSp.DecimalPlacesCount = ((uint)(2u));
			this.SpeedSp.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 82D, 90D);
			this.SpeedSp.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.SpeedSp.IsOnlyInput = true;
			this.SpeedSp.Name = "SpeedSp";
			this.SpeedSp.Ranges.Clear();
			this.SpeedSp.Ranges.Add(new NxtControl.GuiFramework.Range<float>(null, true, null, true, propertyDictionary2));
			propertyDictionary1.Add("Text", "${Value}");
			propertyDictionary1.Add("TextColor", new NxtControl.Drawing.Color("LabelTextColor"));
			this.SpeedSp.Ranges.DefaultPropertyValues = propertyDictionary1;
			this.SpeedSp.TagName = "SpeedSp";
			this.SpeedSp.TextAngle = 0F;
			this.SpeedSp.EndInit();
			// 
			// FbSpeed
			// 
			this.FbSpeed.BeginInit();
			this.FbSpeed.DecimalPlacesCount = ((uint)(2u));
			this.FbSpeed.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 82D, 73D);
			this.FbSpeed.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.FbSpeed.IsOnlyInput = true;
			this.FbSpeed.Name = "FbSpeed";
			this.FbSpeed.Ranges.Clear();
			this.FbSpeed.Ranges.Add(new NxtControl.GuiFramework.Range<float>(null, true, null, true, propertyDictionary4));
			propertyDictionary3.Add("Text", "${Value}");
			propertyDictionary3.Add("TextColor", new NxtControl.Drawing.Color("LabelTextColor"));
			this.FbSpeed.Ranges.DefaultPropertyValues = propertyDictionary3;
			this.FbSpeed.TagName = "FbSpeed";
			this.FbSpeed.TextAngle = 0F;
			this.FbSpeed.EndInit();
			// 
			// Unit
			// 
			this.Unit.Color = new NxtControl.Drawing.Color("LabelTextColor");
			this.Unit.Font = new NxtControl.Drawing.Font("LabelFont");
			this.Unit.Location = new NxtControl.Drawing.PointF(84D, 60D);
			this.Unit.Name = "Unit";
			this.Unit.Text = "%";
			// 
			// SpeedPv
			// 
			this.SpeedPv.Bounds = new NxtControl.Drawing.RectF(((float)(43D)), ((float)(51D)), ((float)(26D)), ((float)(26D)));
			this.SpeedPv.Center = new NxtControl.Drawing.PointF(56D, 64D);
			this.SpeedPv.Name = "SpeedPv";
			this.SpeedPv.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(198)), ((byte)(26))), 4F, NxtControl.Drawing.DashStyle.Solid, NxtControl.Drawing.LineCap.Round, NxtControl.Drawing.LineCap.Round, ((uint)(0u)), ((uint)(0u)), System.Drawing.Drawing2D.LineJoin.Miter, null);
			this.SpeedPv.RadiusX = 13D;
			this.SpeedPv.RadiusY = 13D;
			this.SpeedPv.StartAngle = 116D;
			this.SpeedPv.SweepAngle = 306D;
			// 
			// SpeedInfo
			// 
			this.SpeedInfo.BeginInit();
			this.SpeedInfo.Name = "SpeedInfo";
			this.SpeedInfo.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.SpeedSp,
			this.FbSpeed,
			this.Unit});
			this.SpeedInfo.EndInit();
			// 
			// group2
			// 
			this.group2.BeginInit();
			this.group2.Name = "group2";
			this.group2.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.BaseVs,
			this.alarmFrame,
			this.State,
			this.group1,
			this.MotName,
			this.PipeIn,
			this.PipeOut,
			this.Pump,
			this.SpeedPv,
			this.SpeedInfo,
			this.OpenFp});
			this.group2.EndInit();
			// 
			// modo
			// 
			this.modo.BeginInit();
			this.modo.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.7D, 0D, 0D, 0.7D, 104D, 16D);
			this.modo.Name = "modo";
			this.modo.SecurityToken = ((uint)(4294967295u));
			this.modo.TagName = "State";
			this.modo.EndInit();
			// 
			// sPump
			// 
			// 
			// raioCirc
			// 
			this.raioCirc.Bounds = new NxtControl.Drawing.RectF(((float)(12D)), ((float)(50D)), ((float)(24D)), ((float)(24D)));
			this.raioCirc.Brush = new NxtControl.Drawing.Brush(true);
			this.raioCirc.Name = "raioCirc";
			this.raioCirc.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(154)), ((byte)(154)), ((byte)(154))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.raioCirc.Visible = false;
			// 
			// raioRaio
			// 
			this.raioRaio.Bounds = new NxtControl.Drawing.RectF(((float)(19D)), ((float)(53D)), ((float)(10D)), ((float)(18D)));
			this.raioRaio.Brush = new NxtControl.Drawing.Brush(true);
			this.raioRaio.Closed = true;
			this.raioRaio.Name = "raioRaio";
			this.raioRaio.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(154)), ((byte)(154)), ((byte)(154))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.raioRaio.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(25.0606D, 53D),
			new NxtControl.Drawing.PointF(19D, 64.1429D),
			new NxtControl.Drawing.PointF(23.0404D, 64.1429D),
			new NxtControl.Drawing.PointF(23.0404D, 71D),
			new NxtControl.Drawing.PointF(29D, 60.7143D),
			new NxtControl.Drawing.PointF(25.0606D, 60.7143D)});
			this.raioRaio.Visible = false;
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.group2,
			this.raioCirc,
			this.raioRaio,
			this.modo});
			this.SymbolSize = new System.Drawing.Size(600, 400);
			((System.ComponentModel.ISupportInitialize)(this.alarmFrame)).EndInit();

		}
		private NxtControl.GuiFramework.Ellipse Pump;
		private SE.Nereda.Symbols.ActState.sCompacto State;
		private SE.Nereda.Symbols.ActState.sModo modo;
		private NxtControl.GuiFramework.AlarmFrame alarmFrame;
		private SE.App2CommonProcess.Symbols.IlckCondSum.sInterlockSmall interlock;
		private SE.App2CommonProcess.Symbols.FailCondSum.sFailureSmall failure;
		private SE.App2CommonProcess.Symbols.PermCondSum.sPermissiveSmall permissive;
		private NxtControl.GuiFramework.Group group1;
		private NxtControl.GuiFramework.Rectangle MotName;
		private NxtControl.GuiFramework.Rectangle OpenFp;
		private NxtControl.GuiFramework.Ellipse raioCirc;
		private NxtControl.GuiFramework.Polygon raioRaio;
		private NxtControl.GuiFramework.Rectangle PipeIn;
		private NxtControl.GuiFramework.Rectangle PipeOut;
		private NxtControl.GuiFramework.Group SpeedInfo;
		private SE.Nereda.Symbols.MotorVsBaseNer.sDefault BaseVs;
		private System.HMI.Symbols.Base.FreeText<float> SpeedSp;
		private System.HMI.Symbols.Base.FreeText<float> FbSpeed;
		private NxtControl.GuiFramework.FreeText Unit;
		private NxtControl.GuiFramework.Arc SpeedPv;
		private NxtControl.GuiFramework.Group group2;
		#endregion
	}
}
