/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 6/3/2026
 * Time: 11:56 AM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.TestActState2
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
			this.state = new NxtControl.GuiFramework.Rectangle();
			this.starting = new NxtControl.GuiFramework.Polygon();
			this.stopping = new NxtControl.GuiFramework.Polygon();
			this.Mode = new NxtControl.GuiFramework.Rectangle();
			this.group1 = new NxtControl.GuiFramework.Group();
			this.ManuelMode = new NxtControl.GuiFramework.Rectangle();
			this.group2 = new NxtControl.GuiFramework.Group();
			this.CurrentSp = new System.HMI.Symbols.Base.Execute<short>();
			this.FbStatus = new System.HMI.Symbols.Base.Execute<short>();
			this.FbReady = new System.HMI.Symbols.Base.Execute<bool>();
			this.PowerFb = new System.HMI.Symbols.Base.Execute<bool>();
			this.Prog = new System.HMI.Symbols.Base.Execute<bool>();
			this.Oper = new System.HMI.Symbols.Base.Execute<bool>();
			this.Remote = new System.HMI.Symbols.Base.Execute<bool>();
			this.DeviceType = new System.HMI.Symbols.Base.Execute<short>();
			this.fbSimulation = new System.HMI.Symbols.Base.Execute<bool>();
			this.fbOverride = new System.HMI.Symbols.Base.Execute<bool>();
			this.Interlocked = new System.HMI.Symbols.Base.Execute<bool>();
			// 
			// state
			// 
			this.state.Bounds = new NxtControl.Drawing.RectF(((float)(36D)), ((float)(8D)), ((float)(16D)), ((float)(16D)));
			this.state.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.state.Name = "state";
			this.state.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			// 
			// starting
			// 
			this.starting.Bounds = new NxtControl.Drawing.RectF(((float)(39D)), ((float)(11D)), ((float)(10D)), ((float)(10D)));
			this.starting.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(204)), ((byte)(255)), ((byte)(204))));
			this.starting.Closed = true;
			this.starting.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.starting.Name = "starting";
			this.starting.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(39D, 11D),
			new NxtControl.Drawing.PointF(39D, 21D),
			new NxtControl.Drawing.PointF(49D, 16D)});
			// 
			// stopping
			// 
			this.stopping.Bounds = new NxtControl.Drawing.RectF(((float)(39D)), ((float)(11D)), ((float)(10D)), ((float)(10D)));
			this.stopping.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(204)), ((byte)(255)), ((byte)(204))));
			this.stopping.Closed = true;
			this.stopping.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.stopping.Name = "stopping";
			this.stopping.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(49D, 11D),
			new NxtControl.Drawing.PointF(49D, 21D),
			new NxtControl.Drawing.PointF(39D, 16D)});
			// 
			// Mode
			// 
			this.Mode.Bounds = new NxtControl.Drawing.RectF(((float)(54D)), ((float)(8D)), ((float)(38D)), ((float)(16D)));
			this.Mode.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("transparent"));
			this.Mode.Font = new NxtControl.Drawing.Font("Lucida Console", 8F, System.Drawing.FontStyle.Bold);
			this.Mode.Name = "Mode";
			this.Mode.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.Mode.Text = "STE";
			this.Mode.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.Mode.TextColor = new NxtControl.Drawing.Color(((byte)(78)), ((byte)(78)), ((byte)(78)));
			// 
			// group1
			// 
			this.group1.BeginInit();
			this.group1.Name = "group1";
			this.group1.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.state,
			this.starting,
			this.stopping,
			this.Mode});
			this.group1.EndInit();
			// 
			// ManuelMode
			// 
			this.ManuelMode.Bounds = new NxtControl.Drawing.RectF(((float)(16D)), ((float)(8D)), ((float)(16D)), ((float)(16D)));
			this.ManuelMode.Brush = new NxtControl.Drawing.Brush("Transparent");
			this.ManuelMode.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.ManuelMode.ImageBytes = resources.GetString("ManuelMode.ImageBytes");
			this.ManuelMode.Name = "ManuelMode";
			this.ManuelMode.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// group2
			// 
			this.group2.BeginInit();
			this.group2.Name = "group2";
			this.group2.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.group1,
			this.ManuelMode});
			this.group2.EndInit();
			// 
			// CurrentSp
			// 
			this.CurrentSp.BeginInit();
			this.CurrentSp.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.CurrentSp.IsOnlyInput = true;
			this.CurrentSp.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.CurrentSp.Name = "CurrentSp";
			this.CurrentSp.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.CurrentSp.TagName = "CurrentSp";
			this.CurrentSp.Value = ((short)(0));
			this.CurrentSp.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.CurrentSpValueChanged);
			this.CurrentSp.EndInit();
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
			// FbReady
			// 
			this.FbReady.BeginInit();
			this.FbReady.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.FbReady.IsOnlyInput = true;
			this.FbReady.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.FbReady.Name = "FbReady";
			this.FbReady.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.FbReady.TagName = "FbReady";
			this.FbReady.Value = false;
			this.FbReady.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.FbReadyValueChanged);
			this.FbReady.EndInit();
			// 
			// PowerFb
			// 
			this.PowerFb.BeginInit();
			this.PowerFb.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.PowerFb.IsOnlyInput = true;
			this.PowerFb.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.PowerFb.Name = "PowerFb";
			this.PowerFb.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.PowerFb.TagName = "PowerFb";
			this.PowerFb.Value = false;
			this.PowerFb.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.PowerFbValueChanged);
			this.PowerFb.EndInit();
			// 
			// Prog
			// 
			this.Prog.BeginInit();
			this.Prog.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.Prog.IsOnlyInput = true;
			this.Prog.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.Prog.Name = "Prog";
			this.Prog.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.Prog.TagName = "Prog";
			this.Prog.Value = false;
			this.Prog.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.ProgValueChanged);
			this.Prog.EndInit();
			// 
			// Oper
			// 
			this.Oper.BeginInit();
			this.Oper.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.Oper.IsOnlyInput = true;
			this.Oper.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.Oper.Name = "Oper";
			this.Oper.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.Oper.TagName = "Oper";
			this.Oper.Value = false;
			this.Oper.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.OperValueChanged);
			this.Oper.EndInit();
			// 
			// Remote
			// 
			this.Remote.BeginInit();
			this.Remote.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.Remote.IsOnlyInput = true;
			this.Remote.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.Remote.Name = "Remote";
			this.Remote.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.Remote.TagName = "Remote";
			this.Remote.Value = false;
			this.Remote.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.RemoteValueChanged);
			this.Remote.EndInit();
			// 
			// DeviceType
			// 
			this.DeviceType.BeginInit();
			this.DeviceType.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.DeviceType.IsOnlyInput = true;
			this.DeviceType.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.DeviceType.Name = "DeviceType";
			this.DeviceType.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.DeviceType.TagName = "DeviceType";
			this.DeviceType.Value = ((short)(0));
			this.DeviceType.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.DeviceTypeValueChanged);
			this.DeviceType.EndInit();
			// 
			// fbSimulation
			// 
			this.fbSimulation.BeginInit();
			this.fbSimulation.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.fbSimulation.IsOnlyInput = true;
			this.fbSimulation.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.fbSimulation.Name = "fbSimulation";
			this.fbSimulation.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.fbSimulation.TagName = "fbSimulation";
			this.fbSimulation.Value = false;
			this.fbSimulation.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.FbSimulationValueChanged);
			this.fbSimulation.EndInit();
			// 
			// fbOverride
			// 
			this.fbOverride.BeginInit();
			this.fbOverride.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.fbOverride.IsOnlyInput = true;
			this.fbOverride.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.fbOverride.Name = "fbOverride";
			this.fbOverride.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.fbOverride.TagName = "fbOverride";
			this.fbOverride.Value = false;
			this.fbOverride.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.FbOverrideValueChanged);
			this.fbOverride.EndInit();
			// 
			// Interlocked
			// 
			this.Interlocked.BeginInit();
			this.Interlocked.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.Interlocked.IsOnlyInput = true;
			this.Interlocked.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.Interlocked.Name = "Interlocked";
			this.Interlocked.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.Interlocked.TagName = "Interlocked";
			this.Interlocked.Value = false;
			this.Interlocked.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.InterlockedValueChanged);
			this.Interlocked.EndInit();
			// 
			// sDefault
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.group2,
			this.CurrentSp,
			this.FbStatus,
			this.FbReady,
			this.PowerFb,
			this.Prog,
			this.Oper,
			this.Remote,
			this.DeviceType,
			this.fbSimulation,
			this.fbOverride,
			this.Interlocked});
			this.SymbolSize = new System.Drawing.Size(328, 232);

		}
		private NxtControl.GuiFramework.Rectangle state;
		private NxtControl.GuiFramework.Polygon starting;
		private NxtControl.GuiFramework.Polygon stopping;
		private NxtControl.GuiFramework.Rectangle Mode;
		private NxtControl.GuiFramework.Group group1;
		private NxtControl.GuiFramework.Rectangle ManuelMode;
		private NxtControl.GuiFramework.Group group2;
		private System.HMI.Symbols.Base.Execute<short> CurrentSp;
		private System.HMI.Symbols.Base.Execute<short> FbStatus;
		private System.HMI.Symbols.Base.Execute<bool> FbReady;
		private System.HMI.Symbols.Base.Execute<bool> PowerFb;
		private System.HMI.Symbols.Base.Execute<bool> Prog;
		private System.HMI.Symbols.Base.Execute<bool> Oper;
		private System.HMI.Symbols.Base.Execute<bool> Remote;
		private System.HMI.Symbols.Base.Execute<short> DeviceType;
		private System.HMI.Symbols.Base.Execute<bool> fbSimulation;
		private System.HMI.Symbols.Base.Execute<bool> fbOverride;
		private System.HMI.Symbols.Base.Execute<bool> Interlocked;
		#endregion
	}
}
