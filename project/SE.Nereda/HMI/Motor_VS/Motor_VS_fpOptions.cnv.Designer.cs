/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 6/3/2026
 * Time: 5:07 PM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using NxtControl.GuiFramework;

namespace SE.Nereda.Faceplates.Motor_VS
{
	/// <summary>
	/// Summary description for fpOptions.
	/// </summary>
	partial class fpOptions
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.interlock = new SE.App2CommonProcess.Symbols.IlckCondSum.sInterlock();
			this.permissive = new SE.App2CommonProcess.Symbols.PermCondSum.sPermissive();
			this.failure = new SE.App2CommonProcess.Symbols.FailCondSum.sFailure();
			this.OpenMotFp = new NxtControl.GuiFramework.DrawnButton();
			this.BaseVs = new SE.App2CommonProcess.Symbols.MotorVsBase.sDefault();
			this.maintenance = new SE.App2CommonProcess.Symbols.DevMnt.sDefault();
			this.RearmBtn = new NxtControl.GuiFramework.DrawnButton();
			this.MotorVsFailuresAlarms = new SE.Nereda.Symbols.MotVsFailures.sDefault();
			this.rectangle1 = new NxtControl.GuiFramework.Rectangle();
			// 
			// interlock
			// 
			this.interlock.BeginInit();
			this.interlock.DefaultInstanceName = null;
			this.interlock.DesignMatrix = new NxtControl.Drawing.Matrix2D(1.8181818181818181D, 0D, 0D, 1.8181818181818179D, 8D, 8D);
			this.interlock.Instancelayer = SE.App2Base.SupportClasses.InstanceLayer.Base;
			this.interlock.MyTagDisplayName = null;
			this.interlock.Name = "interlock";
			this.interlock.ParentTitle = "";
			this.interlock.SecurityToken = ((uint)(4294967295u));
			this.interlock.TagName = "interlock";
			this.interlock.EndInit();
			// 
			// permissive
			// 
			this.permissive.BeginInit();
			this.permissive.DefaultInstanceName = null;
			this.permissive.DesignMatrix = new NxtControl.Drawing.Matrix2D(1.8181818181818183D, 0D, 0D, 1.8181818181818183D, 8D, 56D);
			this.permissive.Instancelayer = SE.App2Base.SupportClasses.InstanceLayer.Base;
			this.permissive.MyTagDisplayName = null;
			this.permissive.Name = "permissive";
			this.permissive.ParentTitle = "";
			this.permissive.SecurityToken = ((uint)(4294967295u));
			this.permissive.TagName = "permissive";
			this.permissive.EndInit();
			// 
			// failure
			// 
			this.failure.BeginInit();
			this.failure.DefaultInstanceName = null;
			this.failure.DesignMatrix = new NxtControl.Drawing.Matrix2D(1.8181818181818181D, 0D, 0D, 1.8181818181818179D, 8D, 104D);
			this.failure.Instancelayer = SE.App2Base.SupportClasses.InstanceLayer.Base;
			this.failure.MyTagDisplayName = null;
			this.failure.Name = "failure";
			this.failure.ParentTitle = "";
			this.failure.SecurityToken = ((uint)(4294967175u));
			this.failure.TagName = "failure";
			this.failure.EndInit();
			// 
			// OpenMotFp
			// 
			this.OpenMotFp.Bounds = new NxtControl.Drawing.RectF(((float)(120D)), ((float)(88D)), ((float)(88D)), ((float)(56D)));
			this.OpenMotFp.Brush = new NxtControl.Drawing.Brush("ButtonBrush");
			this.OpenMotFp.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.OpenMotFp.InnerBorderColor = new NxtControl.Drawing.Color("ButtonInnerBorderColor");
			this.OpenMotFp.Name = "OpenMotFp";
			this.OpenMotFp.Pen = new NxtControl.Drawing.Pen("ButtonPen");
			this.OpenMotFp.Radius = 4D;
			this.OpenMotFp.Text = "Motor Faceplate";
			this.OpenMotFp.TextColor = new NxtControl.Drawing.Color("ButtonTextColor");
			this.OpenMotFp.TextColorMouseDown = new NxtControl.Drawing.Color("ButtonTextColorMouseDown");
			this.OpenMotFp.Use3DEffect = false;
			this.OpenMotFp.Click += new System.EventHandler(this.OpenMotFpClick);
			// 
			// BaseVs
			// 
			this.BaseVs.BeginInit();
			this.BaseVs.DefaultInstanceName = null;
			this.BaseVs.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.17705891121982947D, 0D, 0D, 0.17705891121982942D, 144.35411782243963D, 96.531176733659493D);
			this.BaseVs.Instancelayer = SE.App2Base.SupportClasses.InstanceLayer.Base;
			this.BaseVs.MyTagDisplayName = null;
			this.BaseVs.Name = "BaseVs";
			this.BaseVs.SecurityToken = ((uint)(4294967295u));
			this.BaseVs.TagName = "BaseVs";
			this.BaseVs.EndInit();
			// 
			// maintenance
			// 
			this.maintenance.BeginInit();
			this.maintenance.DefaultInstanceName = null;
			this.maintenance.DesignMatrix = new NxtControl.Drawing.Matrix2D(2D, 0D, 0D, 2D, 64D, 8D);
			this.maintenance.Instancelayer = SE.App2Base.SupportClasses.InstanceLayer.Base;
			this.maintenance.MyTagDisplayName = null;
			this.maintenance.Name = "maintenance";
			this.maintenance.ParentTitle = "";
			this.maintenance.SecurityToken = ((uint)(4294967175u));
			this.maintenance.TagName = "maintenance";
			this.maintenance.EndInit();
			// 
			// RearmBtn
			// 
			this.RearmBtn.Bounds = new NxtControl.Drawing.RectF(((float)(120D)), ((float)(8D)), ((float)(88D)), ((float)(56D)));
			this.RearmBtn.Brush = new NxtControl.Drawing.Brush("ButtonBrush");
			this.RearmBtn.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.RearmBtn.InnerBorderColor = new NxtControl.Drawing.Color("ButtonInnerBorderColor");
			this.RearmBtn.Name = "RearmBtn";
			this.RearmBtn.Pen = new NxtControl.Drawing.Pen("ButtonPen");
			this.RearmBtn.Radius = 4D;
			this.RearmBtn.Text = "Rearm";
			this.RearmBtn.TextColor = new NxtControl.Drawing.Color("ButtonTextColor");
			this.RearmBtn.TextColorMouseDown = new NxtControl.Drawing.Color("ButtonTextColorMouseDown");
			this.RearmBtn.Use3DEffect = false;
			this.RearmBtn.Click += new System.EventHandler(this.RearmBtnClick);
			// 
			// MotorVsFailuresAlarms
			// 
			this.MotorVsFailuresAlarms.BeginInit();
			this.MotorVsFailuresAlarms.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 64D, 56D);
			this.MotorVsFailuresAlarms.Name = "MotorVsFailuresAlarms";
			this.MotorVsFailuresAlarms.SecurityToken = ((uint)(4294967295u));
			this.MotorVsFailuresAlarms.TagName = "MotorVsFailuresAlarms";
			this.MotorVsFailuresAlarms.EndInit();
			// 
			// rectangle1
			// 
			this.rectangle1.Bounds = new NxtControl.Drawing.RectF(((float)(64D)), ((float)(104D)), ((float)(40D)), ((float)(40D)));
			this.rectangle1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular);
			this.rectangle1.Name = "rectangle1";
			this.rectangle1.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("fpLocalPanel", NxtControl.GuiFramework.MouseButtonType.Click));
			this.rectangle1.Text = "LP";
			this.rectangle1.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			// 
			// fpOptions
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(216D)), ((float)(152D)));
			this.Brush = new NxtControl.Drawing.Brush("FaceplateBrush");
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.BaseVs,
			this.interlock,
			this.permissive,
			this.failure,
			this.OpenMotFp,
			this.maintenance,
			this.RearmBtn,
			this.MotorVsFailuresAlarms,
			this.rectangle1});
			this.Size = new System.Drawing.Size(216, 152);
			this.Title = "Options";

		}
		private SE.App2CommonProcess.Symbols.IlckCondSum.sInterlock interlock;
		private SE.App2CommonProcess.Symbols.PermCondSum.sPermissive permissive;
		private SE.App2CommonProcess.Symbols.FailCondSum.sFailure failure;
		private NxtControl.GuiFramework.DrawnButton OpenMotFp;
		private SE.App2CommonProcess.Symbols.MotorVsBase.sDefault BaseVs;
		private SE.App2CommonProcess.Symbols.DevMnt.sDefault maintenance;
		private NxtControl.GuiFramework.DrawnButton RearmBtn;
		private SE.Nereda.Symbols.MotVsFailures.sDefault MotorVsFailuresAlarms;
		private NxtControl.GuiFramework.Rectangle rectangle1;
		#endregion
	}
}
