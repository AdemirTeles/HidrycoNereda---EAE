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

namespace SE.Nereda.Faceplates.ValveS
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
			this.OpenMotFp = new NxtControl.GuiFramework.DrawnButton();
			this.maintenance = new SE.App2CommonProcess.Symbols.DevMnt.sDefault();
			this.RearmBtn = new NxtControl.GuiFramework.DrawnButton();
			this.Base = new SE.App2CommonProcess.Symbols.ValveBase.sDefault();
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
			// OpenMotFp
			// 
			this.OpenMotFp.Bounds = new NxtControl.Drawing.RectF(((float)(72D)), ((float)(88D)), ((float)(88D)), ((float)(56D)));
			this.OpenMotFp.Brush = new NxtControl.Drawing.Brush("ButtonBrush");
			this.OpenMotFp.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.OpenMotFp.InnerBorderColor = new NxtControl.Drawing.Color("ButtonInnerBorderColor");
			this.OpenMotFp.Name = "OpenMotFp";
			this.OpenMotFp.Pen = new NxtControl.Drawing.Pen("ButtonPen");
			this.OpenMotFp.Radius = 4D;
			this.OpenMotFp.Text = "Valve Faceplate";
			this.OpenMotFp.TextColor = new NxtControl.Drawing.Color("ButtonTextColor");
			this.OpenMotFp.TextColorMouseDown = new NxtControl.Drawing.Color("ButtonTextColorMouseDown");
			this.OpenMotFp.Use3DEffect = false;
			this.OpenMotFp.Click += new System.EventHandler(this.OpenMotFpClick);
			// 
			// maintenance
			// 
			this.maintenance.BeginInit();
			this.maintenance.DefaultInstanceName = null;
			this.maintenance.DesignMatrix = new NxtControl.Drawing.Matrix2D(2D, 0D, 0D, 2D, 8D, 104D);
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
			this.RearmBtn.Bounds = new NxtControl.Drawing.RectF(((float)(72D)), ((float)(8D)), ((float)(88D)), ((float)(56D)));
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
			// Base
			// 
			this.Base.BeginInit();
			this.Base.DefaultInstanceName = null;
			this.Base.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.24358974358974358D, 0D, 0D, 0.24358974358974367D, 101.07692307692309D, 102.05128205128204D);
			this.Base.Instancelayer = SE.App2Base.SupportClasses.InstanceLayer.Base;
			this.Base.MyTagDisplayName = null;
			this.Base.Name = "Base";
			this.Base.SecurityToken = ((uint)(4294967175u));
			this.Base.TagName = "Base";
			this.Base.EndInit();
			// 
			// fpOptions
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(168D)), ((float)(152D)));
			this.Brush = new NxtControl.Drawing.Brush("FaceplateBrush");
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.Base,
			this.interlock,
			this.permissive,
			this.OpenMotFp,
			this.maintenance,
			this.RearmBtn});
			this.Size = new System.Drawing.Size(168, 152);
			this.Title = "Options";

		}
		private SE.App2CommonProcess.Symbols.IlckCondSum.sInterlock interlock;
		private SE.App2CommonProcess.Symbols.PermCondSum.sPermissive permissive;
		private NxtControl.GuiFramework.DrawnButton OpenMotFp;
		private SE.App2CommonProcess.Symbols.DevMnt.sDefault maintenance;
		private NxtControl.GuiFramework.DrawnButton RearmBtn;
		private SE.App2CommonProcess.Symbols.ValveBase.sDefault Base;
		#endregion
	}
}
