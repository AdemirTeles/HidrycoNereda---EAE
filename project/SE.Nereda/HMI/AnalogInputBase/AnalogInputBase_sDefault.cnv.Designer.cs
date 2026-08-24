using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.AnalogInputBase
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
			this.alarmSAFrame1 = new NxtControl.GuiFramework.AlarmFrame();
			this.clickFrame = new NxtControl.GuiFramework.Rectangle();
			this.Pv = new System.HMI.Symbols.Base.Execute<float>();
			this.PvMin = new System.HMI.Symbols.Base.Execute<float>();
			this.PvMax = new System.HMI.Symbols.Base.Execute<float>();
			this.EnableScale = new System.HMI.Symbols.Base.Execute<bool>();
			this.SMeters1 = new SE.App2Base.Graphics.SMeters();
			this.Over = new System.HMI.Symbols.Base.Execute<bool>();
			this.lblInstanceName = new NxtControl.GuiFramework.AliasDisplayLabel();
			((System.ComponentModel.ISupportInitialize)(this.alarmSAFrame1)).BeginInit();
			// 
			// alarmSAFrame1
			// 
			this.alarmSAFrame1.Bounds = new NxtControl.Drawing.RectF(((float)(8D)), ((float)(30D)), ((float)(104D)), ((float)(64D)));
			this.alarmSAFrame1.FrameWidth = ((uint)(2u));
			this.alarmSAFrame1.Name = "alarmSAFrame1";
			this.alarmSAFrame1.Radius = 5D;
			// 
			// clickFrame
			// 
			this.clickFrame.Bounds = new NxtControl.Drawing.RectF(((float)(8D)), ((float)(32D)), ((float)(104D)), ((float)(62D)));
			this.clickFrame.Brush = new NxtControl.Drawing.Brush(true);
			this.clickFrame.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.clickFrame.Name = "clickFrame";
			this.clickFrame.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("fpDefault", NxtControl.GuiFramework.MouseButtonType.Click));
			this.clickFrame.Pen = new NxtControl.Drawing.Pen("Transparent");
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
			// EnableScale
			// 
			this.EnableScale.BeginInit();
			this.EnableScale.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.EnableScale.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.EnableScale.Name = "EnableScale";
			this.EnableScale.SecurityLevel = 0;
			this.EnableScale.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.EnableScale.TagName = "EnScale";
			this.EnableScale.Value = false;
			this.EnableScale.EndInit();
			// 
			// SMeters1
			// 
			this.SMeters1.BeginInit();
			this.SMeters1.AbnormalVisible = true;
			this.SMeters1.AbnormalXOffset = -6D;
			this.SMeters1.AbnormalYOffset = -10D;
			this.SMeters1.BarGraphSize = 96D;
			this.SMeters1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1.0097087378640777D, 0D, 0D, 1D, -21.291262135922331D, -50D);
			this.SMeters1.display = SE.App2Base.Graphics.SMeters.Display.BarGraph;
			this.SMeters1.FrameColor = new NxtControl.Drawing.Color("SymStaticIconColor");
			this.SMeters1.LeftOffset = ((uint)(60u));
			this.SMeters1.Name = "SMeters1";
			this.SMeters1.NumericalVisible = SE.App2Base.Graphics.SMeters.NumericalDisplaySel.Pv;
			this.SMeters1.OpColor = new NxtControl.Drawing.Color("SE.App2Base.aaLibSymOp");
			this.SMeters1.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("fpDefault", NxtControl.GuiFramework.MouseButtonType.Click));
			this.SMeters1.PvColor = new NxtControl.Drawing.Color("SE.App2Base.aaLibSymPv");
			this.SMeters1.RangeVisible = SE.App2Base.SupportClasses.BoolType.False;
			this.SMeters1.Rotation = SE.App2Base.SupportClasses.Rotation.Horizontal;
			this.SMeters1.SpColor = new NxtControl.Drawing.Color("SE.App2Base.aaLibSymSp");
			this.SMeters1.SpIndicator = SE.App2Base.Graphics.SMeters.Indicator.None;
			this.SMeters1.TextAlignmentPvSpOp = SE.App2Base.Graphics.SMeters.TextAlignment.Right;
			this.SMeters1.TextLocationPvSpOp = SE.App2Base.Graphics.SMeters.TextLocation.Right;
			this.SMeters1.Unit = "%";
			this.SMeters1.ValuePct = 0D;
			this.SMeters1.EndInit();
			// 
			// Over
			// 
			this.Over.BeginInit();
			this.Over.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.Over.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.Over.Name = "Over";
			this.Over.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.Over.TagName = "PvOverride";
			this.Over.Value = false;
			this.Over.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.OverValueChanged);
			this.Over.EndInit();
			// 
			// lblInstanceName
			// 
			this.lblInstanceName.AngleIgnore = true;
			this.lblInstanceName.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lblInstanceName.Bounds = new NxtControl.Drawing.RectF(((float)(5D)), ((float)(14D)), ((float)(100D)), ((float)(13D)));
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
			// sDefault
			// 
			this.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("fpDefault", NxtControl.GuiFramework.MouseButtonType.Click));
			this.SecurityToken = ((uint)(4294967175u));
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.alarmSAFrame1,
			this.Pv,
			this.PvMin,
			this.PvMax,
			this.EnableScale,
			this.clickFrame,
			this.SMeters1,
			this.Over,
			this.lblInstanceName});
			this.SymbolSize = new System.Drawing.Size(144, 118);
			((System.ComponentModel.ISupportInitialize)(this.alarmSAFrame1)).EndInit();

		}
		private NxtControl.GuiFramework.AliasDisplayLabel lblInstanceName;
		private NxtControl.GuiFramework.AlarmFrame alarmSAFrame1;
		private NxtControl.GuiFramework.Rectangle clickFrame;
		private System.HMI.Symbols.Base.Execute<float> Pv;
		private System.HMI.Symbols.Base.Execute<float> PvMin;
		private System.HMI.Symbols.Base.Execute<float> PvMax;
		private System.HMI.Symbols.Base.Execute<bool> EnableScale;
		private SE.App2Base.Graphics.SMeters SMeters1;
		private System.HMI.Symbols.Base.Execute<bool> Over;
		#endregion
	}
}



