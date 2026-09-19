using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace HMI.Main.Symbols.PIDBase
{
	/// <summary>
	/// Summary description for sPvSpOp.
	/// </summary>
	partial class sDisplayPvSpOp
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.PvSpGroup = new SE.App2Base.Graphics.SMeters();
			this.OpGroup = new SE.App2Base.Graphics.SMeters();
			this.Pv = new System.HMI.Symbols.Base.Execute<float>();
			this.PvMin = new System.HMI.Symbols.Base.Execute<float>();
			this.PvMax = new System.HMI.Symbols.Base.Execute<float>();
			this.CurrentSp = new System.HMI.Symbols.Base.Execute<float>();
			this.CurrentOp = new System.HMI.Symbols.Base.Execute<float>();
			this.OutMin = new System.HMI.Symbols.Base.Execute<float>();
			this.OutMax = new System.HMI.Symbols.Base.Execute<float>();
			this.interlock = new SE.App2CommonProcess.Graphics.InterlockSmallBasic();
			this.owner = new SE.App2Base.Graphics.OwnerBasic();
			this.IlckCond = new System.HMI.Symbols.Base.Execute<bool>();
			this.StdOwnerConnected = new System.HMI.Symbols.Base.Execute<bool>();
			this.CurrentOwner = new System.HMI.Symbols.Base.Execute<ushort>();
			this.InstanceName = new NxtControl.GuiFramework.AliasDisplayLabel();
			this.clickFrame = new NxtControl.GuiFramework.Rectangle();
			// 
			// PvSpGroup
			// 
			this.PvSpGroup.BeginInit();
			this.PvSpGroup.AbnormalVisible = true;
			this.PvSpGroup.AbnormalXOffset = -108D;
			this.PvSpGroup.AbnormalYOffset = 6D;
			this.PvSpGroup.BarGraphSize = 96D;
			this.PvSpGroup.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 88D, -62D);
			this.PvSpGroup.display = SE.App2Base.Graphics.SMeters.Display.Numeric;
			this.PvSpGroup.FrameColor = new NxtControl.Drawing.Color("SymStaticIconColor");
			this.PvSpGroup.LeftOffset = ((uint)(60u));
			this.PvSpGroup.Name = "PvSpGroup";
			this.PvSpGroup.NumericalVisible = SE.App2Base.Graphics.SMeters.NumericalDisplaySel.PvSp;
			this.PvSpGroup.OpColor = new NxtControl.Drawing.Color("SE.App2Base.aaLibSymOp");
			this.PvSpGroup.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("fpDefault", NxtControl.GuiFramework.MouseButtonType.Click));
			this.PvSpGroup.PvColor = new NxtControl.Drawing.Color("SE.App2Base.aaLibSymPv");
			this.PvSpGroup.RangeVisible = SE.App2Base.SupportClasses.BoolType.True;
			this.PvSpGroup.Rotation = SE.App2Base.SupportClasses.Rotation.Horizontal;
			this.PvSpGroup.SpColor = new NxtControl.Drawing.Color("SE.App2Base.aaLibSymSp");
			this.PvSpGroup.SpIndicator = SE.App2Base.Graphics.SMeters.Indicator.PvBarSpTriangle;
			this.PvSpGroup.TextAlignmentPvSpOp = SE.App2Base.Graphics.SMeters.TextAlignment.Right;
			this.PvSpGroup.TextLocationPvSpOp = SE.App2Base.Graphics.SMeters.TextLocation.Left;
			this.PvSpGroup.Unit = "%";
			this.PvSpGroup.ValuePct = 0D;
			this.PvSpGroup.EndInit();
			// 
			// OpGroup
			// 
			this.OpGroup.BeginInit();
			this.OpGroup.AbnormalXOffset = -108D;
			this.OpGroup.AbnormalYOffset = 6D;
			this.OpGroup.BarGraphSize = 96D;
			this.OpGroup.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 88D, -14D);
			this.OpGroup.display = SE.App2Base.Graphics.SMeters.Display.Numeric;
			this.OpGroup.FrameColor = new NxtControl.Drawing.Color("SymStaticIconColor");
			this.OpGroup.LeftOffset = ((uint)(60u));
			this.OpGroup.Name = "OpGroup";
			this.OpGroup.NumericalVisible = SE.App2Base.Graphics.SMeters.NumericalDisplaySel.Op;
			this.OpGroup.OpColor = new NxtControl.Drawing.Color("SE.App2Base.aaLibSymOp");
			this.OpGroup.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("fpDefault", NxtControl.GuiFramework.MouseButtonType.Click));
			this.OpGroup.PvColor = new NxtControl.Drawing.Color("SE.App2Base.aaLibSymPv");
			this.OpGroup.RangeVisible = SE.App2Base.SupportClasses.BoolType.True;
			this.OpGroup.Rotation = SE.App2Base.SupportClasses.Rotation.Horizontal;
			this.OpGroup.SpColor = new NxtControl.Drawing.Color("SE.App2Base.aaLibSymSp");
			this.OpGroup.SpIndicator = SE.App2Base.Graphics.SMeters.Indicator.PvBarSpTriangle;
			this.OpGroup.TextAlignmentPvSpOp = SE.App2Base.Graphics.SMeters.TextAlignment.Right;
			this.OpGroup.TextLocationPvSpOp = SE.App2Base.Graphics.SMeters.TextLocation.Left;
			this.OpGroup.Unit = "%";
			this.OpGroup.ValuePct = 0D;
			this.OpGroup.EndInit();
			// 
			// Pv
			// 
			this.Pv.BeginInit();
			this.Pv.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.Pv.IsOnlyInput = true;
			this.Pv.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.Pv.Name = "Pv";
			this.Pv.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.Pv.TagName = "Pv";
			this.Pv.Value = 0F;
			this.Pv.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.PvValueChanged);
			this.Pv.EndInit();
			// 
			// PvMin
			// 
			this.PvMin.BeginInit();
			this.PvMin.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.PvMin.IsOnlyInput = true;
			this.PvMin.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.PvMin.Name = "PvMin";
			this.PvMin.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.PvMin.TagName = "PvMin";
			this.PvMin.Value = 0F;
			this.PvMin.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.PvMinValueChanged);
			this.PvMin.EndInit();
			// 
			// PvMax
			// 
			this.PvMax.BeginInit();
			this.PvMax.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.PvMax.IsOnlyInput = true;
			this.PvMax.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.PvMax.Name = "PvMax";
			this.PvMax.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.PvMax.TagName = "PvMax";
			this.PvMax.Value = 0F;
			this.PvMax.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.PvMaxValueChanged);
			this.PvMax.EndInit();
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
			this.CurrentSp.Value = 0F;
			this.CurrentSp.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.CurrentSpValueChanged);
			this.CurrentSp.EndInit();
			// 
			// CurrentOp
			// 
			this.CurrentOp.BeginInit();
			this.CurrentOp.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.CurrentOp.IsOnlyInput = true;
			this.CurrentOp.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.CurrentOp.Name = "CurrentOp";
			this.CurrentOp.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.CurrentOp.TagName = "CurrentOp";
			this.CurrentOp.Value = 0F;
			this.CurrentOp.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.CurrentOpValueChanged);
			this.CurrentOp.EndInit();
			// 
			// OutMin
			// 
			this.OutMin.BeginInit();
			this.OutMin.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.OutMin.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.OutMin.Name = "OutMin";
			this.OutMin.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.OutMin.TagName = "OutMin";
			this.OutMin.Value = 0F;
			this.OutMin.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.OutMinValueChanged);
			this.OutMin.EndInit();
			// 
			// OutMax
			// 
			this.OutMax.BeginInit();
			this.OutMax.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.OutMax.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.OutMax.Name = "OutMax";
			this.OutMax.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.OutMax.TagName = "OutMax";
			this.OutMax.Value = 0F;
			this.OutMax.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.OutMaxValueChanged);
			this.OutMax.EndInit();
			// 
			// interlock
			// 
			this.interlock.BeginInit();
			this.interlock.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 116D, 33D);
			this.interlock.InstanceName = "";
			this.interlock.InterlockSignal = false;
			this.interlock.Name = "interlock";
			this.interlock.SymbolType = "SE.App2CommonProcess.Symbols.IlckCondSum.sInterlockSmall";
			this.interlock.OnAbnormalDetected += new SE.App2CommonProcess.Graphics.InterlockSmallBasic.AbnormalDetected(this.InterlockOnAbnormalDetected);
			this.interlock.EndInit();
			// 
			// owner
			// 
			this.owner.BeginInit();
			this.owner.BasicOwner = ((ushort)(0));
			this.owner.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 116D, 50D);
			this.owner.ExternalAvailable = false;
			this.owner.InstanceName = "";
			this.owner.Name = "owner";
			this.owner.OnAbnormalDetected += new SE.App2Base.Graphics.OwnerBasic.AbnormalDetected(this.OwnerOnAbnormalDetected);
			this.owner.EndInit();
			// 
			// IlckCond
			// 
			this.IlckCond.BeginInit();
			this.IlckCond.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.IlckCond.IsOnlyInput = true;
			this.IlckCond.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.IlckCond.Name = "IlckCond";
			this.IlckCond.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.IlckCond.TagName = "IlckCond";
			this.IlckCond.Value = false;
			this.IlckCond.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.IlckCondValueChanged);
			this.IlckCond.EndInit();
			// 
			// StdOwnerConnected
			// 
			this.StdOwnerConnected.BeginInit();
			this.StdOwnerConnected.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.StdOwnerConnected.IsOnlyInput = true;
			this.StdOwnerConnected.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.StdOwnerConnected.Name = "StdOwnerConnected";
			this.StdOwnerConnected.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.StdOwnerConnected.TagName = "StdOwnerConnected";
			this.StdOwnerConnected.Value = false;
			this.StdOwnerConnected.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.StdOwnerConnectedValueChanged);
			this.StdOwnerConnected.EndInit();
			// 
			// CurrentOwner
			// 
			this.CurrentOwner.BeginInit();
			this.CurrentOwner.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.CurrentOwner.IsOnlyInput = true;
			this.CurrentOwner.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.CurrentOwner.Name = "CurrentOwner";
			this.CurrentOwner.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.CurrentOwner.TagName = "CurrentOwner";
			this.CurrentOwner.Value = ((ushort)(0));
			this.CurrentOwner.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.CurrentOwnerValueChanged);
			this.CurrentOwner.EndInit();
			// 
			// InstanceName
			// 
			this.InstanceName.AngleIgnore = true;
			this.InstanceName.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.InstanceName.Bounds = new NxtControl.Drawing.RectF(((float)(20D)), ((float)(5D)), ((float)(100D)), ((float)(13D)));
			this.InstanceName.Brush = new NxtControl.Drawing.Brush(true);
			this.InstanceName.CustomInstanceName = null;
			this.InstanceName.Font = new NxtControl.Drawing.Font("SE.App2Base.SymInstanceLabel");
			this.InstanceName.FontScale = true;
			this.InstanceName.Name = "InstanceName";
			this.InstanceName.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.InstanceName.Text = "PID";
			this.InstanceName.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.InstanceName.TextAutoSizeHorizontalOffset = 10;
			this.InstanceName.TextColor = new NxtControl.Drawing.Color("SE.App2Base.aaLibSymInstanceLabelTextColor");
			this.InstanceName.TextPadding = new NxtControl.Drawing.Padding(2);
			// 
			// clickFrame
			// 
			this.clickFrame.Bounds = new NxtControl.Drawing.RectF(((float)(76D)), ((float)(42D)), ((float)(38D)), ((float)(41D)));
			this.clickFrame.Brush = new NxtControl.Drawing.Brush(true);
			this.clickFrame.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.clickFrame.Name = "clickFrame";
			this.clickFrame.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("fpDefault", NxtControl.GuiFramework.MouseButtonType.Click));
			this.clickFrame.Pen = new NxtControl.Drawing.Pen("Transparent");
			// 
			// sDisplayPvSpOp
			// 
			this.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("fpDefault", NxtControl.GuiFramework.MouseButtonType.Click));
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.PvSpGroup,
			this.OpGroup,
			this.Pv,
			this.PvMin,
			this.PvMax,
			this.CurrentSp,
			this.CurrentOp,
			this.OutMin,
			this.OutMax,
			this.interlock,
			this.owner,
			this.IlckCond,
			this.StdOwnerConnected,
			this.CurrentOwner,
			this.InstanceName,
			this.clickFrame});
			this.SymbolSize = new System.Drawing.Size(133, 101);
			this.UpdateOptionalService += new SE.App2Base.Symbols.SEAppLibHMISymbol.OnUpdateOptionalService(this.SDisplayPvSpOpUpdateOptionalService);

		}
		private SE.App2Base.Graphics.SMeters PvSpGroup;
		private SE.App2Base.Graphics.SMeters OpGroup;
		private NxtControl.GuiFramework.AliasDisplayLabel InstanceName;
		private System.HMI.Symbols.Base.Execute<float> Pv;
		private System.HMI.Symbols.Base.Execute<float> PvMin;
		private System.HMI.Symbols.Base.Execute<float> PvMax;
		private System.HMI.Symbols.Base.Execute<float> CurrentSp;
		private System.HMI.Symbols.Base.Execute<float> CurrentOp;
		private System.HMI.Symbols.Base.Execute<float> OutMin;
		private System.HMI.Symbols.Base.Execute<float> OutMax;
		private SE.App2CommonProcess.Graphics.InterlockSmallBasic interlock;
		private SE.App2Base.Graphics.OwnerBasic owner;
		private System.HMI.Symbols.Base.Execute<bool> IlckCond;
		private System.HMI.Symbols.Base.Execute<bool> StdOwnerConnected;
		private System.HMI.Symbols.Base.Execute<ushort> CurrentOwner;
		private NxtControl.GuiFramework.Rectangle clickFrame;
		
		#endregion
	}
}



