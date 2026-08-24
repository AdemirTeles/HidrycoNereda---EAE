using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.AnalogInputBase
{
	/// <summary>
	/// Summary description for sVertical.
	/// </summary>
	partial class sVertical
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.SMeters1 = new SE.App2Base.Graphics.SMeters();
			this.Pv = new System.HMI.Symbols.Base.Execute<float>();
			this.PvMin = new System.HMI.Symbols.Base.Execute<float>();
			this.PvMax = new System.HMI.Symbols.Base.Execute<float>();
			this.clickFrame = new NxtControl.GuiFramework.Rectangle();
			this.alarmFrame1 = new NxtControl.GuiFramework.AlarmFrame();
			this.execute_11 = new System.HMI.Symbols.Base.Execute<bool>();
			this.lblInstanceName = new NxtControl.GuiFramework.AliasDisplayLabel();
			((System.ComponentModel.ISupportInitialize)(this.alarmFrame1)).BeginInit();
			// 
			// SMeters1
			// 
			this.SMeters1.BeginInit();
			this.SMeters1.AbnormalVisible = true;
			this.SMeters1.AbnormalXOffset = -18D;
			this.SMeters1.AbnormalYOffset = 2D;
			this.SMeters1.BarGraphSize = 100D;
			this.SMeters1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1.0865384615384615D, 0D, 0D, 1.112676056338028D, -21.509615384615387D, 31.774647887323944D);
			this.SMeters1.display = SE.App2Base.Graphics.SMeters.Display.BarGraph;
			this.SMeters1.FrameColor = new NxtControl.Drawing.Color("SymStaticIconColor");
			this.SMeters1.LeftOffset = ((uint)(60u));
			this.SMeters1.Name = "SMeters1";
			this.SMeters1.NumericalVisible = SE.App2Base.Graphics.SMeters.NumericalDisplaySel.Pv;
			this.SMeters1.OpColor = new NxtControl.Drawing.Color("SE.App2Base.aaLibSymOp");
			this.SMeters1.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("fpDefault", NxtControl.GuiFramework.MouseButtonType.Click));
			this.SMeters1.PvColor = new NxtControl.Drawing.Color("SE.App2Base.aaLibSymPv");
			this.SMeters1.RangeVisible = SE.App2Base.SupportClasses.BoolType.False;
			this.SMeters1.Rotation = SE.App2Base.SupportClasses.Rotation.Vertical;
			this.SMeters1.SpColor = new NxtControl.Drawing.Color("SE.App2Base.aaLibSymSp");
			this.SMeters1.SpIndicator = SE.App2Base.Graphics.SMeters.Indicator.None;
			this.SMeters1.TextAlignmentPvSpOp = SE.App2Base.Graphics.SMeters.TextAlignment.Left;
			this.SMeters1.TextLocationPvSpOp = SE.App2Base.Graphics.SMeters.TextLocation.Right;
			this.SMeters1.Unit = "%";
			this.SMeters1.ValuePct = 0D;
			this.SMeters1.EndInit();
			// 
			// Pv
			// 
			this.Pv.BeginInit();
			this.Pv.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.Pv.IsOnlyInput = true;
			this.Pv.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.Pv.Name = "Pv";
			this.Pv.SecurityLevel = 0;
			this.Pv.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.Pv.TagName = "Pv";
			this.Pv.Value = 0F;
			this.Pv.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.ExecPvValueChanged);
			this.Pv.EndInit();
			// 
			// PvMin
			// 
			this.PvMin.BeginInit();
			this.PvMin.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.PvMin.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.PvMin.Name = "PvMin";
			this.PvMin.SecurityLevel = 0;
			this.PvMin.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.PvMin.TagName = "PvMin";
			this.PvMin.Value = 0F;
			this.PvMin.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.ExecPvMinValueChanged);
			this.PvMin.EndInit();
			// 
			// PvMax
			// 
			this.PvMax.BeginInit();
			this.PvMax.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.PvMax.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.PvMax.Name = "PvMax";
			this.PvMax.SecurityLevel = 0;
			this.PvMax.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.PvMax.TagName = "PvMax";
			this.PvMax.Value = 0F;
			this.PvMax.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.ExecPvMaxValueChanged);
			this.PvMax.EndInit();
			// 
			// clickFrame
			// 
			this.clickFrame.Bounds = new NxtControl.Drawing.RectF(((float)(8D)), ((float)(32D)), ((float)(82D)), ((float)(158D)));
			this.clickFrame.Brush = new NxtControl.Drawing.Brush(true);
			this.clickFrame.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.clickFrame.Name = "clickFrame";
			this.clickFrame.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("fpDefault", NxtControl.GuiFramework.MouseButtonType.Click));
			this.clickFrame.Pen = new NxtControl.Drawing.Pen("Transparent");
			// 
			// alarmFrame1
			// 
			this.alarmFrame1.Bounds = new NxtControl.Drawing.RectF(((float)(6D)), ((float)(28D)), ((float)(82D)), ((float)(158D)));
			this.alarmFrame1.FrameWidth = ((uint)(2u));
			this.alarmFrame1.Name = "alarmFrame1";
			this.alarmFrame1.Radius = 5D;
			// 
			// execute_11
			// 
			this.execute_11.BeginInit();
			this.execute_11.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.execute_11.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.execute_11.Name = "execute_11";
			this.execute_11.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.execute_11.TagName = "PvOverride";
			this.execute_11.Value = false;
			this.execute_11.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.OverValueChanged);
			this.execute_11.EndInit();
			// 
			// lblInstanceName
			// 
			this.lblInstanceName.AngleIgnore = true;
			this.lblInstanceName.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lblInstanceName.Bounds = new NxtControl.Drawing.RectF(((float)(7D)), ((float)(12D)), ((float)(80D)), ((float)(13D)));
			this.lblInstanceName.Brush = new NxtControl.Drawing.Brush(true);
			this.lblInstanceName.CustomInstanceName = null;
			this.lblInstanceName.Font = new NxtControl.Drawing.Font("SE.App2Base.SymInstanceLabel");
			this.lblInstanceName.FontScale = true;
			this.lblInstanceName.Name = "lblInstanceName";
			this.lblInstanceName.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.lblInstanceName.Text = "Label";
			this.lblInstanceName.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.lblInstanceName.TextAutoSizeHorizontalOffset = 10;
			this.lblInstanceName.TextColor = new NxtControl.Drawing.Color("SE.App2Base.SymInstanceLabelTextColor");
			this.lblInstanceName.TextPadding = new NxtControl.Drawing.Padding(2);
			// 
			// sVertical
			// 
			this.SecurityToken = ((uint)(4294967175u));
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.alarmFrame1,
			this.Pv,
			this.PvMin,
			this.PvMax,
			this.clickFrame,
			this.SMeters1,
			this.execute_11,
			this.lblInstanceName});
			this.SymbolSize = new System.Drawing.Size(503, 485);
			((System.ComponentModel.ISupportInitialize)(this.alarmFrame1)).EndInit();

		}
		private SE.App2Base.Graphics.SMeters SMeters1;
		private System.HMI.Symbols.Base.Execute<float> Pv;
		private System.HMI.Symbols.Base.Execute<float> PvMin;
		private System.HMI.Symbols.Base.Execute<float> PvMax;
		private NxtControl.GuiFramework.AliasDisplayLabel lblInstanceName;
		private NxtControl.GuiFramework.Rectangle clickFrame;
		private NxtControl.GuiFramework.AlarmFrame alarmFrame1;
		private System.HMI.Symbols.Base.Execute<bool> execute_11;
		#endregion
	}
}



