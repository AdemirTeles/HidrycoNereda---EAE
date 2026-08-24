/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 6/4/2026
 * Time: 5:16 PM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.Phase
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
			this.rectangle1 = new NxtControl.GuiFramework.Rectangle();
			this.DisplayPhaseName = new NxtControl.GuiFramework.RoundedRectangle();
			this.DisplayPhaseState = new NxtControl.GuiFramework.RoundedRectangle();
			this.DisplayPhaseTime = new NxtControl.GuiFramework.RoundedRectangle();
			this.OpenFp = new NxtControl.GuiFramework.Rectangle();
			this.OpCdt = new NxtControl.GuiFramework.Rectangle();
			this.execute_11 = new System.HMI.Symbols.Base.Execute<string>();
			this.CurrPhaseState = new System.HMI.Symbols.Base.Execute<string>();
			this.CurrPhaseTime = new System.HMI.Symbols.Base.Execute<uint>();
			this.READY = new System.HMI.Symbols.Base.Execute<bool>();
			this.STARTING = new System.HMI.Symbols.Base.Execute<bool>();
			this.RUN = new System.HMI.Symbols.Base.Execute<bool>();
			this.STOPPING = new System.HMI.Symbols.Base.Execute<bool>();
			this.ABORTING = new System.HMI.Symbols.Base.Execute<bool>();
			this.ABORTED = new System.HMI.Symbols.Base.Execute<bool>();
			this.INTERLOCKED = new System.HMI.Symbols.Base.Execute<bool>();
			this.group1 = new NxtControl.GuiFramework.Group();
			// 
			// rectangle1
			// 
			this.rectangle1.Bounds = new NxtControl.Drawing.RectF(((float)(72D)), ((float)(40D)), ((float)(432D)), ((float)(32D)));
			this.rectangle1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(78)), ((byte)(78)), ((byte)(78))));
			this.rectangle1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle1.Name = "rectangle1";
			this.rectangle1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(78)), ((byte)(78)), ((byte)(78))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// DisplayPhaseName
			// 
			this.DisplayPhaseName.Bounds = new NxtControl.Drawing.RectF(((float)(74D)), ((float)(42D)), ((float)(164D)), ((float)(28D)));
			this.DisplayPhaseName.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(130)), ((byte)(130)), ((byte)(130))));
			this.DisplayPhaseName.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.DisplayPhaseName.Name = "DisplayPhaseName";
			this.DisplayPhaseName.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(240)), ((byte)(240)), ((byte)(240))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.DisplayPhaseName.Radius = 8D;
			this.DisplayPhaseName.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			this.DisplayPhaseName.TextColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			// 
			// DisplayPhaseState
			// 
			this.DisplayPhaseState.Bounds = new NxtControl.Drawing.RectF(((float)(242D)), ((float)(42D)), ((float)(102D)), ((float)(28D)));
			this.DisplayPhaseState.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(240)), ((byte)(240)), ((byte)(240))));
			this.DisplayPhaseState.Font = new NxtControl.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
			this.DisplayPhaseState.Name = "DisplayPhaseState";
			this.DisplayPhaseState.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(210)), ((byte)(210)), ((byte)(210))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.DisplayPhaseState.Radius = 8D;
			this.DisplayPhaseState.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			// 
			// DisplayPhaseTime
			// 
			this.DisplayPhaseTime.Bounds = new NxtControl.Drawing.RectF(((float)(348D)), ((float)(42D)), ((float)(153D)), ((float)(28D)));
			this.DisplayPhaseTime.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(240)), ((byte)(240)), ((byte)(240))));
			this.DisplayPhaseTime.Font = new NxtControl.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
			this.DisplayPhaseTime.Name = "DisplayPhaseTime";
			this.DisplayPhaseTime.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(210)), ((byte)(210)), ((byte)(210))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.DisplayPhaseTime.Radius = 8D;
			this.DisplayPhaseTime.Text = "0h : 0min : 0s";
			this.DisplayPhaseTime.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			// 
			// OpenFp
			// 
			this.OpenFp.Bounds = new NxtControl.Drawing.RectF(((float)(72D)), ((float)(40D)), ((float)(432D)), ((float)(32D)));
			this.OpenFp.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("transparent"));
			this.OpenFp.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.OpenFp.Name = "OpenFp";
			this.OpenFp.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("fpDefault", NxtControl.GuiFramework.MouseButtonType.Click));
			this.OpenFp.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// OpCdt
			// 
			this.OpCdt.Bounds = new NxtControl.Drawing.RectF(((float)(40D)), ((float)(40D)), ((float)(32D)), ((float)(32D)));
			this.OpCdt.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(240)), ((byte)(240)), ((byte)(240))));
			this.OpCdt.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.OpCdt.ImageBytes = resources.GetString("OpCdt.ImageBytes");
			this.OpCdt.Name = "OpCdt";
			this.OpCdt.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("fpOpCdt", NxtControl.GuiFramework.MouseButtonType.Click));
			this.OpCdt.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(78)), ((byte)(78)), ((byte)(78))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// execute_11
			// 
			this.execute_11.BeginInit();
			this.execute_11.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.execute_11.IsOnlyInput = true;
			this.execute_11.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.execute_11.Name = "execute_11";
			this.execute_11.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.execute_11.TagName = "PhaseName";
			this.execute_11.Value = null;
			this.execute_11.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.PhaseNameValueChanged);
			this.execute_11.EndInit();
			// 
			// CurrPhaseState
			// 
			this.CurrPhaseState.BeginInit();
			this.CurrPhaseState.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.CurrPhaseState.IsOnlyInput = true;
			this.CurrPhaseState.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.CurrPhaseState.Name = "CurrPhaseState";
			this.CurrPhaseState.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.CurrPhaseState.TagName = "CurrPhaseState";
			this.CurrPhaseState.Value = null;
			this.CurrPhaseState.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.CurrPhaseStateValueChanged);
			this.CurrPhaseState.EndInit();
			// 
			// CurrPhaseTime
			// 
			this.CurrPhaseTime.BeginInit();
			this.CurrPhaseTime.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.CurrPhaseTime.IsOnlyInput = true;
			this.CurrPhaseTime.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.CurrPhaseTime.Name = "CurrPhaseTime";
			this.CurrPhaseTime.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.CurrPhaseTime.TagName = "CurrPhaseTime";
			this.CurrPhaseTime.Value = ((uint)(0u));
			this.CurrPhaseTime.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.CurrPhaseTimeValueChanged);
			this.CurrPhaseTime.EndInit();
			// 
			// READY
			// 
			this.READY.BeginInit();
			this.READY.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.READY.IsOnlyInput = true;
			this.READY.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.READY.Name = "READY";
			this.READY.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.READY.TagName = "READY";
			this.READY.Value = false;
			this.READY.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.READYValueChanged);
			this.READY.EndInit();
			// 
			// STARTING
			// 
			this.STARTING.BeginInit();
			this.STARTING.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.STARTING.IsOnlyInput = true;
			this.STARTING.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.STARTING.Name = "STARTING";
			this.STARTING.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.STARTING.TagName = "STARTING";
			this.STARTING.Value = false;
			this.STARTING.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.STARTINGValueChanged);
			this.STARTING.EndInit();
			// 
			// RUN
			// 
			this.RUN.BeginInit();
			this.RUN.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.RUN.IsOnlyInput = true;
			this.RUN.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.RUN.Name = "RUN";
			this.RUN.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.RUN.TagName = "RUN";
			this.RUN.Value = false;
			this.RUN.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.RUNValueChanged);
			this.RUN.EndInit();
			// 
			// STOPPING
			// 
			this.STOPPING.BeginInit();
			this.STOPPING.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.STOPPING.IsOnlyInput = true;
			this.STOPPING.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.STOPPING.Name = "STOPPING";
			this.STOPPING.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.STOPPING.TagName = "STOPPING";
			this.STOPPING.Value = false;
			this.STOPPING.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.STOPPINGValueChanged);
			this.STOPPING.EndInit();
			// 
			// ABORTING
			// 
			this.ABORTING.BeginInit();
			this.ABORTING.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.ABORTING.IsOnlyInput = true;
			this.ABORTING.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.ABORTING.Name = "ABORTING";
			this.ABORTING.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.ABORTING.TagName = "ABORTING";
			this.ABORTING.Value = false;
			this.ABORTING.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.ABORTINGValueChanged);
			this.ABORTING.EndInit();
			// 
			// ABORTED
			// 
			this.ABORTED.BeginInit();
			this.ABORTED.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.ABORTED.IsOnlyInput = true;
			this.ABORTED.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.ABORTED.Name = "ABORTED";
			this.ABORTED.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.ABORTED.TagName = "ABORTED";
			this.ABORTED.Value = false;
			this.ABORTED.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.ABORTEDValueChanged);
			this.ABORTED.EndInit();
			// 
			// INTERLOCKED
			// 
			this.INTERLOCKED.BeginInit();
			this.INTERLOCKED.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.INTERLOCKED.IsOnlyInput = true;
			this.INTERLOCKED.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.INTERLOCKED.Name = "INTERLOCKED";
			this.INTERLOCKED.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.INTERLOCKED.TagName = "INTERLOCKED";
			this.INTERLOCKED.Value = false;
			this.INTERLOCKED.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.INTERLOCKEDValueChanged);
			this.INTERLOCKED.EndInit();
			// 
			// group1
			// 
			this.group1.BeginInit();
			this.group1.Name = "group1";
			this.group1.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.rectangle1,
			this.DisplayPhaseName,
			this.DisplayPhaseState,
			this.DisplayPhaseTime,
			this.OpCdt,
			this.OpenFp});
			this.group1.EndInit();
			// 
			// sDefault
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.execute_11,
			this.CurrPhaseState,
			this.CurrPhaseTime,
			this.READY,
			this.STARTING,
			this.RUN,
			this.STOPPING,
			this.ABORTING,
			this.ABORTED,
			this.INTERLOCKED,
			this.group1});
			this.SymbolSize = new System.Drawing.Size(600, 136);

		}
		private NxtControl.GuiFramework.Rectangle rectangle1;
		private NxtControl.GuiFramework.RoundedRectangle DisplayPhaseName;
		private NxtControl.GuiFramework.RoundedRectangle DisplayPhaseState;
		private NxtControl.GuiFramework.RoundedRectangle DisplayPhaseTime;
		private NxtControl.GuiFramework.Rectangle OpenFp;
		private NxtControl.GuiFramework.Rectangle OpCdt;
		private NxtControl.GuiFramework.Group group1;
		//private System.HMI.Symbols.Base.Execute<string> PhaseName;
		private System.HMI.Symbols.Base.Execute<string> execute_11;
		private System.HMI.Symbols.Base.Execute<string> CurrPhaseState;
		private System.HMI.Symbols.Base.Execute<uint> CurrPhaseTime;
		private System.HMI.Symbols.Base.Execute<bool> ABORTED;
		private System.HMI.Symbols.Base.Execute<bool> INTERLOCKED;
		private System.HMI.Symbols.Base.Execute<bool> READY;
		private System.HMI.Symbols.Base.Execute<bool> STARTING;
		private System.HMI.Symbols.Base.Execute<bool> RUN;
		private System.HMI.Symbols.Base.Execute<bool> STOPPING;
		private System.HMI.Symbols.Base.Execute<bool> ABORTING;
		#endregion
	}
}
