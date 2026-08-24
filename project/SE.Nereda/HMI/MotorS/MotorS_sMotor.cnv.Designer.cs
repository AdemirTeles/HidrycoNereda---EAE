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

namespace SE.Nereda.Symbols.MotorS
{
	/// <summary>
	/// Summary description for sDefault.
	/// </summary>
	partial class sMotor
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sMotor));
			this.Base = new SE.App2CommonProcess.Symbols.MotorBase.sDefault();
			this.ManuelMode = new NxtControl.GuiFramework.Rectangle();
			this.State = new SE.Nereda.Symbols.ActState.sDefault();
			this.alarmFrame = new NxtControl.GuiFramework.AlarmFrame();
			this.interlock = new SE.App2CommonProcess.Symbols.IlckCondSum.sInterlockSmall();
			this.failure = new SE.App2CommonProcess.Symbols.FailCondSum.sFailureSmall();
			this.permissive = new SE.App2CommonProcess.Symbols.PermCondSum.sPermissiveSmall();
			this.group1 = new NxtControl.GuiFramework.Group();
			this.MotName = new NxtControl.GuiFramework.Rectangle();
			this.OpenFp = new NxtControl.GuiFramework.Rectangle();
			this.MotBase1 = new NxtControl.GuiFramework.RoundedRectangle();
			this.MotBase2 = new NxtControl.GuiFramework.Rectangle();
			this.line1 = new NxtControl.GuiFramework.Line();
			this.line2 = new NxtControl.GuiFramework.Line();
			this.line3 = new NxtControl.GuiFramework.Line();
			this.group2 = new NxtControl.GuiFramework.Group();
			this.MotBase3 = new NxtControl.GuiFramework.Rectangle();
			this.VertMot = new NxtControl.GuiFramework.Group();
			this.MotBase6 = new NxtControl.GuiFramework.Rectangle();
			this.MotBase4 = new NxtControl.GuiFramework.RoundedRectangle();
			this.MotBase5 = new NxtControl.GuiFramework.Rectangle();
			this.line4 = new NxtControl.GuiFramework.Line();
			this.line5 = new NxtControl.GuiFramework.Line();
			this.line6 = new NxtControl.GuiFramework.Line();
			this.group4 = new NxtControl.GuiFramework.Group();
			this.HoriMot = new NxtControl.GuiFramework.Group();
			((System.ComponentModel.ISupportInitialize)(this.alarmFrame)).BeginInit();
			// 
			// Base
			// 
			this.Base.BeginInit();
			this.Base.DefaultInstanceName = null;
			this.Base.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.26666666666666666D, 0D, 0D, 0.16666666666666666D, 48D, 48.833333333333329D);
			this.Base.Instancelayer = SE.App2Base.SupportClasses.InstanceLayer.Base;
			this.Base.MyTagDisplayName = null;
			this.Base.Name = "Base";
			this.Base.SecurityToken = ((uint)(4294967175u));
			this.Base.TagName = "Base";
			this.Base.EndInit();
			// 
			// ManuelMode
			// 
			this.ManuelMode.Bounds = new NxtControl.Drawing.RectF(((float)(28D)), ((float)(48D)), ((float)(16D)), ((float)(13.793103218078613D)));
			this.ManuelMode.Brush = new NxtControl.Drawing.Brush("Transparent");
			this.ManuelMode.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.ManuelMode.ImageBytes = resources.GetString("ManuelMode.ImageBytes");
			this.ManuelMode.Name = "ManuelMode";
			this.ManuelMode.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// State
			// 
			this.State.BeginInit();
			this.State.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 48D, 48D);
			this.State.Name = "State";
			this.State.SecurityToken = ((uint)(4294967295u));
			this.State.TagName = "State";
			this.State.ActuatorStatus += new SE.Nereda.Symbols.ActState.sDefault.ActState(this.StateActuatorStatus);
			this.State.ActManModeStatus += new SE.Nereda.Symbols.ActState.sDefault.ActManMode(this.StateActManModeStatus);
			this.State.EndInit();
			// 
			// alarmFrame
			// 
			this.alarmFrame.Bounds = new NxtControl.Drawing.RectF(((float)(46D)), ((float)(46D)), ((float)(40D)), ((float)(48D)));
			this.alarmFrame.FrameWidth = ((uint)(2u));
			this.alarmFrame.Name = "alarmFrame";
			this.alarmFrame.Radius = 5D;
			// 
			// interlock
			// 
			this.interlock.BeginInit();
			this.interlock.DefaultInstanceName = null;
			this.interlock.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 37D, 32D);
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
			this.failure.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 69D, 32D);
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
			this.permissive.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 53D, 32D);
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
			this.MotName.Bounds = new NxtControl.Drawing.RectF(((float)(12D)), ((float)(16D)), ((float)(96D)), ((float)(16D)));
			this.MotName.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("transparent"));
			this.MotName.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.MotName.Name = "MotName";
			this.MotName.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.MotName.Text = "Motor";
			this.MotName.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			// 
			// OpenFp
			// 
			this.OpenFp.Bounds = new NxtControl.Drawing.RectF(((float)(40D)), ((float)(32D)), ((float)(48D)), ((float)(64D)));
			this.OpenFp.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("transparent"));
			this.OpenFp.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.OpenFp.Name = "OpenFp";
			this.OpenFp.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("fpOptions", NxtControl.GuiFramework.MouseButtonType.Click));
			this.OpenFp.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.OpenFp.Click += new System.EventHandler(this.OpenFpClick);
			// 
			// MotBase1
			// 
			this.MotBase1.Bounds = new NxtControl.Drawing.RectF(((float)(48D)), ((float)(48D)), ((float)(24D)), ((float)(16D)));
			this.MotBase1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.MotBase1.Name = "MotBase1";
			// 
			// MotBase2
			// 
			this.MotBase2.Bounds = new NxtControl.Drawing.RectF(((float)(48D)), ((float)(56D)), ((float)(24D)), ((float)(24D)));
			this.MotBase2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.MotBase2.Name = "MotBase2";
			// 
			// line1
			// 
			this.line1.EndPoint = new NxtControl.Drawing.PointF(54D, 76D);
			this.line1.Name = "line1";
			this.line1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.line1.StartPoint = new NxtControl.Drawing.PointF(54D, 60D);
			// 
			// line2
			// 
			this.line2.EndPoint = new NxtControl.Drawing.PointF(60D, 76D);
			this.line2.Name = "line2";
			this.line2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.line2.StartPoint = new NxtControl.Drawing.PointF(60D, 60D);
			// 
			// line3
			// 
			this.line3.EndPoint = new NxtControl.Drawing.PointF(66D, 76D);
			this.line3.Name = "line3";
			this.line3.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.line3.StartPoint = new NxtControl.Drawing.PointF(66D, 60D);
			// 
			// group2
			// 
			this.group2.BeginInit();
			this.group2.Name = "group2";
			this.group2.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.line1,
			this.line2,
			this.line3});
			this.group2.EndInit();
			// 
			// MotBase3
			// 
			this.MotBase3.Bounds = new NxtControl.Drawing.RectF(((float)(52D)), ((float)(76D)), ((float)(16D)), ((float)(8D)));
			this.MotBase3.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.MotBase3.Name = "MotBase3";
			// 
			// VertMot
			// 
			this.VertMot.BeginInit();
			this.VertMot.Name = "VertMot";
			this.VertMot.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.MotBase3,
			this.MotBase1,
			this.MotBase2,
			this.group2});
			this.VertMot.EndInit();
			// 
			// MotBase6
			// 
			this.MotBase6.Bounds = new NxtControl.Drawing.RectF(((float)(76D)), ((float)(72D)), ((float)(8D)), ((float)(16D)));
			this.MotBase6.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.MotBase6.Name = "MotBase6";
			// 
			// MotBase4
			// 
			this.MotBase4.Bounds = new NxtControl.Drawing.RectF(((float)(48D)), ((float)(68D)), ((float)(16D)), ((float)(24D)));
			this.MotBase4.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.MotBase4.Name = "MotBase4";
			// 
			// MotBase5
			// 
			this.MotBase5.Bounds = new NxtControl.Drawing.RectF(((float)(56D)), ((float)(68D)), ((float)(24D)), ((float)(24D)));
			this.MotBase5.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.MotBase5.Name = "MotBase5";
			// 
			// line4
			// 
			this.line4.EndPoint = new NxtControl.Drawing.PointF(76D, 86D);
			this.line4.Name = "line4";
			this.line4.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.line4.StartPoint = new NxtControl.Drawing.PointF(60D, 86D);
			// 
			// line5
			// 
			this.line5.EndPoint = new NxtControl.Drawing.PointF(76D, 80D);
			this.line5.Name = "line5";
			this.line5.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.line5.StartPoint = new NxtControl.Drawing.PointF(60D, 80D);
			// 
			// line6
			// 
			this.line6.EndPoint = new NxtControl.Drawing.PointF(76D, 74D);
			this.line6.Name = "line6";
			this.line6.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.line6.StartPoint = new NxtControl.Drawing.PointF(60D, 74D);
			// 
			// group4
			// 
			this.group4.BeginInit();
			this.group4.Name = "group4";
			this.group4.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.line4,
			this.line5,
			this.line6});
			this.group4.EndInit();
			// 
			// HoriMot
			// 
			this.HoriMot.BeginInit();
			this.HoriMot.Name = "HoriMot";
			this.HoriMot.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.MotBase6,
			this.MotBase4,
			this.MotBase5,
			this.group4});
			this.HoriMot.EndInit();
			// 
			// sMotor
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.Base,
			this.alarmFrame,
			this.ManuelMode,
			this.group1,
			this.MotName,
			this.VertMot,
			this.HoriMot,
			this.State,
			this.OpenFp});
			this.SymbolSize = new System.Drawing.Size(600, 400);
			((System.ComponentModel.ISupportInitialize)(this.alarmFrame)).EndInit();

		}
		private SE.App2CommonProcess.Symbols.MotorBase.sDefault Base;
		private NxtControl.GuiFramework.Rectangle ManuelMode;
		private SE.Nereda.Symbols.ActState.sDefault State;
		private NxtControl.GuiFramework.AlarmFrame alarmFrame;
		private SE.App2CommonProcess.Symbols.IlckCondSum.sInterlockSmall interlock;
		private SE.App2CommonProcess.Symbols.FailCondSum.sFailureSmall failure;
		private SE.App2CommonProcess.Symbols.PermCondSum.sPermissiveSmall permissive;
		private NxtControl.GuiFramework.Group group1;
		private NxtControl.GuiFramework.Group group2;
		private NxtControl.GuiFramework.Rectangle MotName;
		private NxtControl.GuiFramework.Rectangle OpenFp;
		private NxtControl.GuiFramework.RoundedRectangle MotBase1;
		private NxtControl.GuiFramework.Rectangle MotBase2;
		private NxtControl.GuiFramework.Line line1;
		private NxtControl.GuiFramework.Line line2;
		private NxtControl.GuiFramework.Line line3;
		private NxtControl.GuiFramework.Rectangle MotBase3;
		private NxtControl.GuiFramework.Group VertMot;
		private NxtControl.GuiFramework.Rectangle MotBase6;
		private NxtControl.GuiFramework.RoundedRectangle MotBase4;
		private NxtControl.GuiFramework.Rectangle MotBase5;
		private NxtControl.GuiFramework.Group group4;
		private NxtControl.GuiFramework.Line line4;
		private NxtControl.GuiFramework.Line line5;
		private NxtControl.GuiFramework.Line line6;
		private NxtControl.GuiFramework.Group HoriMot;
		#endregion
	}
}
