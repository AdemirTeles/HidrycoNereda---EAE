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
	partial class sPump
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.Base = new SE.App2CommonProcess.Symbols.MotorBase.sDefault();
			this.State = new SE.Nereda.Symbols.ActState.sDefault();
			this.alarmFrame = new NxtControl.GuiFramework.AlarmFrame();
			this.interlock = new SE.App2CommonProcess.Symbols.IlckCondSum.sInterlockSmall();
			this.failure = new SE.App2CommonProcess.Symbols.FailCondSum.sFailureSmall();
			this.permissive = new SE.App2CommonProcess.Symbols.PermCondSum.sPermissiveSmall();
			this.group1 = new NxtControl.GuiFramework.Group();
			this.MotName = new NxtControl.GuiFramework.Rectangle();
			this.OpenFp = new NxtControl.GuiFramework.Rectangle();
			this.InLet = new NxtControl.GuiFramework.Rectangle();
			this.OutLet = new NxtControl.GuiFramework.Rectangle();
			this.MotBase = new NxtControl.GuiFramework.Ellipse();
			this.group2 = new NxtControl.GuiFramework.Group();
			((System.ComponentModel.ISupportInitialize)(this.alarmFrame)).BeginInit();
			// 
			// Base
			// 
			this.Base.BeginInit();
			this.Base.DefaultInstanceName = null;
			this.Base.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.26666666666666666D, 0D, 0D, 0.16666666666666666D, 64D, 64.833333333333329D);
			this.Base.Instancelayer = SE.App2Base.SupportClasses.InstanceLayer.Base;
			this.Base.MyTagDisplayName = null;
			this.Base.Name = "Base";
			this.Base.SecurityToken = ((uint)(4294967175u));
			this.Base.TagName = "Base";
			this.Base.EndInit();
			// 
			// State
			// 
			this.State.BeginInit();
			this.State.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 28D, 96D);
			this.State.Name = "State";
			this.State.SecurityToken = ((uint)(4294967295u));
			this.State.TagName = "State";
			this.State.ActuatorStatus += new SE.Nereda.Symbols.ActState.sDefault.ActState(this.StateActuatorStatus);
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
			this.OpenFp.Bounds = new NxtControl.Drawing.RectF(((float)(40D)), ((float)(48D)), ((float)(48D)), ((float)(64D)));
			this.OpenFp.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("transparent"));
			this.OpenFp.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.OpenFp.Name = "OpenFp";
			this.OpenFp.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("fpOptions", NxtControl.GuiFramework.MouseButtonType.Click));
			this.OpenFp.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.OpenFp.Click += new System.EventHandler(this.OpenFpClick);
			// 
			// InLet
			// 
			this.InLet.Bounds = new NxtControl.Drawing.RectF(((float)(48D)), ((float)(84D)), ((float)(20D)), ((float)(8D)));
			this.InLet.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.InLet.Name = "InLet";
			// 
			// OutLet
			// 
			this.OutLet.Bounds = new NxtControl.Drawing.RectF(((float)(76D)), ((float)(56D)), ((float)(8D)), ((float)(20D)));
			this.OutLet.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.OutLet.Name = "OutLet";
			// 
			// MotBase
			// 
			this.MotBase.Bounds = new NxtControl.Drawing.RectF(((float)(52D)), ((float)(60D)), ((float)(32D)), ((float)(32D)));
			this.MotBase.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.MotBase.Name = "MotBase";
			// 
			// group2
			// 
			this.group2.BeginInit();
			this.group2.Name = "group2";
			this.group2.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.InLet,
			this.OutLet,
			this.MotBase});
			this.group2.EndInit();
			// 
			// sPump
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.Base,
			this.alarmFrame,
			this.group1,
			this.MotName,
			this.State,
			this.group2,
			this.OpenFp});
			this.SymbolSize = new System.Drawing.Size(600, 400);
			((System.ComponentModel.ISupportInitialize)(this.alarmFrame)).EndInit();

		}
		private SE.App2CommonProcess.Symbols.MotorBase.sDefault Base;
		private SE.Nereda.Symbols.ActState.sDefault State;
		private NxtControl.GuiFramework.AlarmFrame alarmFrame;
		private SE.App2CommonProcess.Symbols.IlckCondSum.sInterlockSmall interlock;
		private SE.App2CommonProcess.Symbols.FailCondSum.sFailureSmall failure;
		private SE.App2CommonProcess.Symbols.PermCondSum.sPermissiveSmall permissive;
		private NxtControl.GuiFramework.Group group1;
		private NxtControl.GuiFramework.Rectangle MotName;
		private NxtControl.GuiFramework.Rectangle OpenFp;
		private NxtControl.GuiFramework.Rectangle InLet;
		private NxtControl.GuiFramework.Rectangle OutLet;
		private NxtControl.GuiFramework.Ellipse MotBase;
		private NxtControl.GuiFramework.Group group2;
		#endregion
	}
}
