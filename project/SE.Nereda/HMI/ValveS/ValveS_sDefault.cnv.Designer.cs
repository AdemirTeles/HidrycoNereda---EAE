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

namespace SE.Nereda.Symbols.ValveS
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sDefault));
			this.ManuelMode = new NxtControl.GuiFramework.Rectangle();
			this.State = new SE.Nereda.Symbols.ActState.sDefault();
			this.alarmFrame = new NxtControl.GuiFramework.AlarmFrame();
			this.interlock = new SE.App2CommonProcess.Symbols.IlckCondSum.sInterlockSmall();
			this.permissive = new SE.App2CommonProcess.Symbols.PermCondSum.sPermissiveSmall();
			this.VlvName = new NxtControl.GuiFramework.Rectangle();
			this.OpenFp = new NxtControl.GuiFramework.Rectangle();
			this.VlvBase2 = new NxtControl.GuiFramework.Polygon();
			this.VlvBase1 = new NxtControl.GuiFramework.Rectangle();
			this.line1 = new NxtControl.GuiFramework.Line();
			this.VerticalBase = new NxtControl.GuiFramework.Group();
			this.VlvBase3 = new NxtControl.GuiFramework.Rectangle();
			this.VlvBase4 = new NxtControl.GuiFramework.Polygon();
			this.line2 = new NxtControl.GuiFramework.Line();
			this.State_1 = new SE.Nereda.Symbols.ActState.sStateTop();
			this.Base = new SE.App2CommonProcess.Symbols.ValveBase.sDefault();
			this.HorizontalBase = new NxtControl.GuiFramework.Group();
			this.Horizontal = new NxtControl.GuiFramework.Group();
			this.Vertical = new NxtControl.GuiFramework.Group();
			((System.ComponentModel.ISupportInitialize)(this.alarmFrame)).BeginInit();
			// 
			// ManuelMode
			// 
			this.ManuelMode.Bounds = new NxtControl.Drawing.RectF(((float)(88D)), ((float)(64D)), ((float)(24D)), ((float)(20.689655303955078D)));
			this.ManuelMode.Brush = new NxtControl.Drawing.Brush("Transparent");
			this.ManuelMode.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.ManuelMode.ImageBytes = resources.GetString("ManuelMode.ImageBytes");
			this.ManuelMode.Name = "ManuelMode";
			this.ManuelMode.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// State
			// 
			this.State.BeginInit();
			this.State.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 36D, 48D);
			this.State.Name = "State";
			this.State.SecurityToken = ((uint)(4294967295u));
			this.State.TagName = "State";
			this.State.ActuatorStatus += new SE.Nereda.Symbols.ActState.sDefault.ActState(this.StateActuatorStatus);
			this.State.ActManModeStatus += new SE.Nereda.Symbols.ActState.sDefault.ActManMode(this.StateActManModeStatus);
			this.State.EndInit();
			// 
			// alarmFrame
			// 
			this.alarmFrame.Bounds = new NxtControl.Drawing.RectF(((float)(31D)), ((float)(67D)), ((float)(57D)), ((float)(34D)));
			this.alarmFrame.FrameWidth = ((uint)(2u));
			this.alarmFrame.Name = "alarmFrame";
			this.alarmFrame.Radius = 5D;
			// 
			// interlock
			// 
			this.interlock.BeginInit();
			this.interlock.DefaultInstanceName = null;
			this.interlock.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 16D, 72D);
			this.interlock.Instancelayer = SE.App2Base.SupportClasses.InstanceLayer.Base;
			this.interlock.MyTagDisplayName = null;
			this.interlock.Name = "interlock";
			this.interlock.SecurityToken = ((uint)(4294967295u));
			this.interlock.TagName = "interlock";
			this.interlock.EndInit();
			// 
			// permissive
			// 
			this.permissive.BeginInit();
			this.permissive.DefaultInstanceName = null;
			this.permissive.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 16D, 88D);
			this.permissive.Instancelayer = SE.App2Base.SupportClasses.InstanceLayer.Base;
			this.permissive.MyTagDisplayName = null;
			this.permissive.Name = "permissive";
			this.permissive.SecurityToken = ((uint)(4294967295u));
			this.permissive.TagName = "permissive";
			this.permissive.EndInit();
			// 
			// VlvName
			// 
			this.VlvName.Bounds = new NxtControl.Drawing.RectF(((float)(16D)), ((float)(106D)), ((float)(96D)), ((float)(16D)));
			this.VlvName.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("transparent"));
			this.VlvName.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.VlvName.Name = "VlvName";
			this.VlvName.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.VlvName.Text = "Valve";
			this.VlvName.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			// 
			// OpenFp
			// 
			this.OpenFp.Bounds = new NxtControl.Drawing.RectF(((float)(32D)), ((float)(48D)), ((float)(56D)), ((float)(56D)));
			this.OpenFp.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("transparent"));
			this.OpenFp.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.OpenFp.Name = "OpenFp";
			this.OpenFp.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("fpOptions", NxtControl.GuiFramework.MouseButtonType.Click));
			this.OpenFp.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.OpenFp.Click += new System.EventHandler(this.OpenFpClick);
			// 
			// VlvBase2
			// 
			this.VlvBase2.Bounds = new NxtControl.Drawing.RectF(((float)(48D)), ((float)(88D)), ((float)(32D)), ((float)(16D)));
			this.VlvBase2.Closed = true;
			this.VlvBase2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.VlvBase2.Name = "VlvBase2";
			this.VlvBase2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(48D, 104D),
			new NxtControl.Drawing.PointF(48D, 88D),
			new NxtControl.Drawing.PointF(80D, 104D),
			new NxtControl.Drawing.PointF(80D, 88D)});
			// 
			// VlvBase1
			// 
			this.VlvBase1.Bounds = new NxtControl.Drawing.RectF(((float)(52D)), ((float)(68D)), ((float)(24D)), ((float)(12D)));
			this.VlvBase1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.VlvBase1.Name = "VlvBase1";
			// 
			// line1
			// 
			this.line1.EndPoint = new NxtControl.Drawing.PointF(64D, 72D);
			this.line1.Name = "line1";
			this.line1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line1.StartPoint = new NxtControl.Drawing.PointF(64D, 96D);
			// 
			// VerticalBase
			// 
			this.VerticalBase.BeginInit();
			this.VerticalBase.Name = "VerticalBase";
			this.VerticalBase.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.VlvBase2,
			this.line1,
			this.VlvBase1});
			this.VerticalBase.EndInit();
			// 
			// VlvBase3
			// 
			this.VlvBase3.Bounds = new NxtControl.Drawing.RectF(((float)(52D)), ((float)(72D)), ((float)(12D)), ((float)(24D)));
			this.VlvBase3.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.VlvBase3.Name = "VlvBase3";
			// 
			// VlvBase4
			// 
			this.VlvBase4.Bounds = new NxtControl.Drawing.RectF(((float)(72D)), ((float)(68D)), ((float)(16D)), ((float)(32D)));
			this.VlvBase4.Closed = true;
			this.VlvBase4.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.VlvBase4.Name = "VlvBase4";
			this.VlvBase4.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(72D, 100D),
			new NxtControl.Drawing.PointF(88D, 100D),
			new NxtControl.Drawing.PointF(72D, 68D),
			new NxtControl.Drawing.PointF(88D, 68D)});
			// 
			// line2
			// 
			this.line2.EndPoint = new NxtControl.Drawing.PointF(56D, 84D);
			this.line2.Name = "line2";
			this.line2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line2.StartPoint = new NxtControl.Drawing.PointF(80D, 84D);
			// 
			// State_1
			// 
			this.State_1.BeginInit();
			this.State_1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 32D, 56D);
			this.State_1.Name = "State_1";
			this.State_1.SecurityToken = ((uint)(4294967295u));
			this.State_1.TagName = "State";
			this.State_1.EndInit();
			// 
			// Base
			// 
			this.Base.BeginInit();
			this.Base.DefaultInstanceName = null;
			this.Base.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.10532425321157672D, 0D, 0D, 0.10532425321157676D, 56.736108961461071D, 51.15740597430738D);
			this.Base.Instancelayer = SE.App2Base.SupportClasses.InstanceLayer.Base;
			this.Base.MyTagDisplayName = null;
			this.Base.Name = "Base";
			this.Base.SecurityToken = ((uint)(4294967175u));
			this.Base.TagName = "Base";
			this.Base.EndInit();
			// 
			// HorizontalBase
			// 
			this.HorizontalBase.BeginInit();
			this.HorizontalBase.Name = "HorizontalBase";
			this.HorizontalBase.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.VlvBase4,
			this.line2,
			this.VlvBase3});
			this.HorizontalBase.EndInit();
			// 
			// Horizontal
			// 
			this.Horizontal.BeginInit();
			this.Horizontal.Name = "Horizontal";
			this.Horizontal.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.State_1,
			this.HorizontalBase});
			this.Horizontal.EndInit();
			// 
			// Vertical
			// 
			this.Vertical.BeginInit();
			this.Vertical.Name = "Vertical";
			this.Vertical.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.State,
			this.VerticalBase});
			this.Vertical.EndInit();
			// 
			// sDefault
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.alarmFrame,
			this.ManuelMode,
			this.VlvName,
			this.Base,
			this.Vertical,
			this.interlock,
			this.permissive,
			this.Horizontal,
			this.OpenFp});
			this.SymbolSize = new System.Drawing.Size(600, 400);
			((System.ComponentModel.ISupportInitialize)(this.alarmFrame)).EndInit();

		}
		private NxtControl.GuiFramework.Rectangle ManuelMode;
		private SE.Nereda.Symbols.ActState.sDefault State;
		private NxtControl.GuiFramework.AlarmFrame alarmFrame;
		private SE.App2CommonProcess.Symbols.IlckCondSum.sInterlockSmall interlock;
		private SE.App2CommonProcess.Symbols.PermCondSum.sPermissiveSmall permissive;
		private NxtControl.GuiFramework.Rectangle VlvName;
		private NxtControl.GuiFramework.Rectangle OpenFp;
		private NxtControl.GuiFramework.Polygon VlvBase2;
		private NxtControl.GuiFramework.Rectangle VlvBase1;
		private NxtControl.GuiFramework.Line line1;
		private NxtControl.GuiFramework.Group VerticalBase;
		private NxtControl.GuiFramework.Rectangle VlvBase3;
		private NxtControl.GuiFramework.Polygon VlvBase4;
		private NxtControl.GuiFramework.Line line2;
		private SE.Nereda.Symbols.ActState.sStateTop State_1;
		private SE.App2CommonProcess.Symbols.ValveBase.sDefault Base;
		private NxtControl.GuiFramework.Group HorizontalBase;
		private NxtControl.GuiFramework.Group Horizontal;
		private NxtControl.GuiFramework.Group Vertical;
		#endregion
	}
}
