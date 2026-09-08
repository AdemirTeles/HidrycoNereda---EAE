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
	partial class s3DValve
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(s3DValve));
			this.ManuelMode = new NxtControl.GuiFramework.Rectangle();
			this.State = new SE.Nereda.Symbols.ActState.sDefault();
			this.alarmFrame = new NxtControl.GuiFramework.AlarmFrame();
			this.interlock = new SE.App2CommonProcess.Symbols.IlckCondSum.sInterlockSmall();
			this.permissive = new SE.App2CommonProcess.Symbols.PermCondSum.sPermissiveSmall();
			this.VlvName = new NxtControl.GuiFramework.Rectangle();
			this.OpenFp = new NxtControl.GuiFramework.Rectangle();
			this.Base = new SE.App2CommonProcess.Symbols.ValveBase.sDefault();
			this.pipe24 = new NxtControl.GuiFramework.Pipe();
			this.pipe23 = new NxtControl.GuiFramework.Pipe();
			this.VlvBase1 = new NxtControl.GuiFramework.Ellipse();
			this.VlvBase2 = new NxtControl.GuiFramework.RoundedRectangle();
			this.rectangle4 = new NxtControl.GuiFramework.Rectangle();
			this.rectangle8 = new NxtControl.GuiFramework.Rectangle();
			this.pipe1 = new NxtControl.GuiFramework.Pipe();
			this.pipe2 = new NxtControl.GuiFramework.Pipe();
			this.VlvBase3 = new NxtControl.GuiFramework.Ellipse();
			this.VlvBase4 = new NxtControl.GuiFramework.RoundedRectangle();
			this.rectangle2 = new NxtControl.GuiFramework.Rectangle();
			this.rectangle1 = new NxtControl.GuiFramework.Rectangle();
			this.Horizontal1 = new NxtControl.GuiFramework.Group();
			this.Vertical1 = new NxtControl.GuiFramework.Group();
			this.State_1 = new SE.Nereda.Symbols.ActState.sStateTop();
			this.Horizontal = new NxtControl.GuiFramework.Group();
			this.Vertical = new NxtControl.GuiFramework.Group();
			((System.ComponentModel.ISupportInitialize)(this.alarmFrame)).BeginInit();
			// 
			// ManuelMode
			// 
			this.ManuelMode.Bounds = new NxtControl.Drawing.RectF(((float)(48D)), ((float)(80D)), ((float)(24D)), ((float)(20.689655303955078D)));
			this.ManuelMode.Brush = new NxtControl.Drawing.Brush("Transparent");
			this.ManuelMode.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.ManuelMode.ImageBytes = resources.GetString("ManuelMode.ImageBytes");
			this.ManuelMode.Name = "ManuelMode";
			this.ManuelMode.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// State
			// 
			this.State.BeginInit();
			this.State.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 28D, 40D);
			this.State.Name = "State";
			this.State.SecurityToken = ((uint)(4294967295u));
			this.State.TagName = "State";
			this.State.ActuatorStatus += new SE.Nereda.Symbols.ActState.sDefault.ActState(this.StateActuatorStatus);
			this.State.ActManModeStatus += new SE.Nereda.Symbols.ActState.sDefault.ActManMode(this.StateActManModeStatus);
			this.State.EndInit();
			// 
			// alarmFrame
			// 
			this.alarmFrame.Bounds = new NxtControl.Drawing.RectF(((float)(6D)), ((float)(56D)), ((float)(68D)), ((float)(64D)));
			this.alarmFrame.FrameWidth = ((uint)(2u));
			this.alarmFrame.Name = "alarmFrame";
			this.alarmFrame.Radius = 5D;
			// 
			// interlock
			// 
			this.interlock.BeginInit();
			this.interlock.DefaultInstanceName = null;
			this.interlock.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 8D, 44D);
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
			this.permissive.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 24D, 44D);
			this.permissive.Instancelayer = SE.App2Base.SupportClasses.InstanceLayer.Base;
			this.permissive.MyTagDisplayName = null;
			this.permissive.Name = "permissive";
			this.permissive.SecurityToken = ((uint)(4294967295u));
			this.permissive.TagName = "permissive";
			this.permissive.EndInit();
			// 
			// VlvName
			// 
			this.VlvName.Bounds = new NxtControl.Drawing.RectF(((float)(16D)), ((float)(120D)), ((float)(96D)), ((float)(16D)));
			this.VlvName.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("transparent"));
			this.VlvName.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.VlvName.Name = "VlvName";
			this.VlvName.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.VlvName.Text = "Valve";
			this.VlvName.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			// 
			// OpenFp
			// 
			this.OpenFp.Bounds = new NxtControl.Drawing.RectF(((float)(24D)), ((float)(56D)), ((float)(64D)), ((float)(64D)));
			this.OpenFp.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("transparent"));
			this.OpenFp.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.OpenFp.Name = "OpenFp";
			this.OpenFp.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("fpOptions", NxtControl.GuiFramework.MouseButtonType.Click));
			this.OpenFp.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.OpenFp.Click += new System.EventHandler(this.OpenFpClick);
			// 
			// Base
			// 
			this.Base.BeginInit();
			this.Base.DefaultInstanceName = null;
			this.Base.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.10532425321157672D, 0D, 0D, 0.10532425321157676D, 54.736108961461085D, 87.15740597430738D);
			this.Base.Instancelayer = SE.App2Base.SupportClasses.InstanceLayer.Base;
			this.Base.MyTagDisplayName = null;
			this.Base.Name = "Base";
			this.Base.SecurityToken = ((uint)(4294967175u));
			this.Base.TagName = "Base";
			this.Base.EndInit();
			// 
			// pipe24
			// 
			this.pipe24.Bounds = new NxtControl.Drawing.RectF(((float)(60D)), ((float)(58D)), ((float)(0D)), ((float)(24D)));
			this.pipe24.InnerColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.pipe24.Name = "pipe24";
			this.pipe24.OuterColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.pipe24.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(60D, 82D),
			new NxtControl.Drawing.PointF(60D, 58D)});
			this.pipe24.Width = 10;
			// 
			// pipe23
			// 
			this.pipe23.Bounds = new NxtControl.Drawing.RectF(((float)(40D)), ((float)(90D)), ((float)(40D)), ((float)(0D)));
			this.pipe23.InnerColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.pipe23.Name = "pipe23";
			this.pipe23.OuterColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.pipe23.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(40D, 90D),
			new NxtControl.Drawing.PointF(80D, 90D)});
			this.pipe23.Width = 12;
			// 
			// VlvBase1
			// 
			this.VlvBase1.Bounds = new NxtControl.Drawing.RectF(((float)(46D)), ((float)(76D)), ((float)(28D)), ((float)(28D)));
			this.VlvBase1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(154)), ((byte)(154)), ((byte)(154))), new NxtControl.Drawing.GradientFill(NxtControl.Drawing.GradientFillOrientation.Center, NxtControl.Drawing.GradientFillBrightness.Dark));
			this.VlvBase1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.VlvBase1.Name = "VlvBase1";
			this.VlvBase1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(78)), ((byte)(78)), ((byte)(78))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// VlvBase2
			// 
			this.VlvBase2.Bounds = new NxtControl.Drawing.RectF(((float)(44D)), ((float)(58D)), ((float)(32D)), ((float)(8D)));
			this.VlvBase2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(154)), ((byte)(154)), ((byte)(154))), new NxtControl.Drawing.GradientFill(NxtControl.Drawing.GradientFillOrientation.HorizontalCenter, NxtControl.Drawing.GradientFillBrightness.Dark));
			this.VlvBase2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.VlvBase2.Name = "VlvBase2";
			this.VlvBase2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(78)), ((byte)(78)), ((byte)(78))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.VlvBase2.Radius = 30D;
			// 
			// rectangle4
			// 
			this.rectangle4.Bounds = new NxtControl.Drawing.RectF(((float)(32D)), ((float)(78D)), ((float)(8D)), ((float)(24D)));
			this.rectangle4.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(154)), ((byte)(154)), ((byte)(154))), new NxtControl.Drawing.GradientFill(NxtControl.Drawing.GradientFillOrientation.VerticalCenter));
			this.rectangle4.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle4.Name = "rectangle4";
			this.rectangle4.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(106)), ((byte)(106)), ((byte)(106))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// rectangle8
			// 
			this.rectangle8.Bounds = new NxtControl.Drawing.RectF(((float)(80D)), ((float)(78D)), ((float)(8D)), ((float)(24D)));
			this.rectangle8.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(154)), ((byte)(154)), ((byte)(154))), new NxtControl.Drawing.GradientFill(NxtControl.Drawing.GradientFillOrientation.VerticalCenter));
			this.rectangle8.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle8.Name = "rectangle8";
			this.rectangle8.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(106)), ((byte)(106)), ((byte)(106))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// pipe1
			// 
			this.pipe1.Bounds = new NxtControl.Drawing.RectF(((float)(30D)), ((float)(90D)), ((float)(32D)), ((float)(0D)));
			this.pipe1.InnerColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.pipe1.Name = "pipe1";
			this.pipe1.OuterColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.pipe1.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(62D, 90D),
			new NxtControl.Drawing.PointF(30D, 90D)});
			this.pipe1.Width = 10;
			// 
			// pipe2
			// 
			this.pipe2.Bounds = new NxtControl.Drawing.RectF(((float)(60D)), ((float)(70D)), ((float)(0D)), ((float)(40D)));
			this.pipe2.InnerColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.pipe2.Name = "pipe2";
			this.pipe2.OuterColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.pipe2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(60D, 70D),
			new NxtControl.Drawing.PointF(60D, 110D)});
			this.pipe2.Width = 12;
			// 
			// VlvBase3
			// 
			this.VlvBase3.Bounds = new NxtControl.Drawing.RectF(((float)(46D)), ((float)(76D)), ((float)(28D)), ((float)(28D)));
			this.VlvBase3.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(154)), ((byte)(154)), ((byte)(154))), new NxtControl.Drawing.GradientFill(NxtControl.Drawing.GradientFillOrientation.Center, NxtControl.Drawing.GradientFillBrightness.Dark));
			this.VlvBase3.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.VlvBase3.Name = "VlvBase3";
			this.VlvBase3.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(78)), ((byte)(78)), ((byte)(78))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// VlvBase4
			// 
			this.VlvBase4.Bounds = new NxtControl.Drawing.RectF(((float)(26D)), ((float)(74D)), ((float)(8D)), ((float)(32D)));
			this.VlvBase4.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(154)), ((byte)(154)), ((byte)(154))), new NxtControl.Drawing.GradientFill(NxtControl.Drawing.GradientFillOrientation.VerticalCenter, NxtControl.Drawing.GradientFillBrightness.Dark));
			this.VlvBase4.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.VlvBase4.Name = "VlvBase4";
			this.VlvBase4.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(78)), ((byte)(78)), ((byte)(78))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.VlvBase4.Radius = 30D;
			// 
			// rectangle2
			// 
			this.rectangle2.Bounds = new NxtControl.Drawing.RectF(((float)(48D)), ((float)(62D)), ((float)(24D)), ((float)(8D)));
			this.rectangle2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(154)), ((byte)(154)), ((byte)(154))), new NxtControl.Drawing.GradientFill(NxtControl.Drawing.GradientFillOrientation.HorizontalCenter));
			this.rectangle2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle2.Name = "rectangle2";
			this.rectangle2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(106)), ((byte)(106)), ((byte)(106))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// rectangle1
			// 
			this.rectangle1.Bounds = new NxtControl.Drawing.RectF(((float)(48D)), ((float)(110D)), ((float)(24D)), ((float)(8D)));
			this.rectangle1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(154)), ((byte)(154)), ((byte)(154))), new NxtControl.Drawing.GradientFill(NxtControl.Drawing.GradientFillOrientation.HorizontalCenter));
			this.rectangle1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle1.Name = "rectangle1";
			this.rectangle1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(106)), ((byte)(106)), ((byte)(106))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// Horizontal1
			// 
			this.Horizontal1.BeginInit();
			this.Horizontal1.Name = "Horizontal1";
			this.Horizontal1.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.pipe24,
			this.pipe23,
			this.VlvBase1,
			this.VlvBase2,
			this.rectangle4,
			this.rectangle8});
			this.Horizontal1.EndInit();
			// 
			// Vertical1
			// 
			this.Vertical1.BeginInit();
			this.Vertical1.Name = "Vertical1";
			this.Vertical1.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.pipe1,
			this.pipe2,
			this.VlvBase3,
			this.VlvBase4,
			this.rectangle2,
			this.rectangle1});
			this.Vertical1.EndInit();
			// 
			// State_1
			// 
			this.State_1.BeginInit();
			this.State_1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 8D, 56D);
			this.State_1.Name = "State_1";
			this.State_1.SecurityToken = ((uint)(4294967295u));
			this.State_1.TagName = "State";
			this.State_1.EndInit();
			// 
			// Horizontal
			// 
			this.Horizontal.BeginInit();
			this.Horizontal.Name = "Horizontal";
			this.Horizontal.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.Horizontal1,
			this.State});
			this.Horizontal.EndInit();
			// 
			// Vertical
			// 
			this.Vertical.BeginInit();
			this.Vertical.Name = "Vertical";
			this.Vertical.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.Vertical1,
			this.State_1});
			this.Vertical.EndInit();
			// 
			// s3DValve
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.Base,
			this.alarmFrame,
			this.interlock,
			this.permissive,
			this.VlvName,
			this.Horizontal,
			this.Vertical,
			this.ManuelMode,
			this.OpenFp});
			this.SymbolSize = new System.Drawing.Size(368, 288);
			((System.ComponentModel.ISupportInitialize)(this.alarmFrame)).EndInit();

		}
		private NxtControl.GuiFramework.Rectangle ManuelMode;
		private SE.Nereda.Symbols.ActState.sDefault State;
		private NxtControl.GuiFramework.AlarmFrame alarmFrame;
		private SE.App2CommonProcess.Symbols.IlckCondSum.sInterlockSmall interlock;
		private SE.App2CommonProcess.Symbols.PermCondSum.sPermissiveSmall permissive;
		private NxtControl.GuiFramework.Rectangle VlvName;
		private NxtControl.GuiFramework.Rectangle OpenFp;
		private SE.App2CommonProcess.Symbols.ValveBase.sDefault Base;
		private NxtControl.GuiFramework.Pipe pipe24;
		private NxtControl.GuiFramework.Pipe pipe23;
		private NxtControl.GuiFramework.Ellipse VlvBase1;
		private NxtControl.GuiFramework.RoundedRectangle VlvBase2;
		private NxtControl.GuiFramework.Rectangle rectangle4;
		private NxtControl.GuiFramework.Rectangle rectangle8;
		private NxtControl.GuiFramework.Rectangle rectangle1;
		private NxtControl.GuiFramework.Pipe pipe1;
		private NxtControl.GuiFramework.Pipe pipe2;
		private NxtControl.GuiFramework.Ellipse VlvBase3;
		private NxtControl.GuiFramework.RoundedRectangle VlvBase4;
		private NxtControl.GuiFramework.Rectangle rectangle2;
		private NxtControl.GuiFramework.Group Horizontal1;
		private NxtControl.GuiFramework.Group Vertical1;
		private SE.Nereda.Symbols.ActState.sStateTop State_1;
		private NxtControl.GuiFramework.Group Horizontal;
		private NxtControl.GuiFramework.Group Vertical;
		#endregion
	}
}
