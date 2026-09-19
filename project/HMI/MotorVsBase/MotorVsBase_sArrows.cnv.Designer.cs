using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace HMI.Main.Symbols.MotorVsBase
{
	/// <summary>
	/// Summary description for sArrows.
	/// </summary>
	partial class sArrows
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.rightArrow = new NxtControl.GuiFramework.Polygon();
			this.leftArrow = new NxtControl.GuiFramework.Polygon();
			this.FbFail = new System.HMI.Symbols.Base.Execute<NxtControl.GuiFramework.VTQ<bool>>();
			this.DeviceFail = new System.HMI.Symbols.Base.Execute<NxtControl.GuiFramework.VTQ<bool>>();
			this.FbStatus = new System.HMI.Symbols.Base.Execute<short>();
			// 
			// rightArrow
			// 
			this.rightArrow.Bounds = new NxtControl.Drawing.RectF(((float)(33D)), ((float)(58D)), ((float)(40D)), ((float)(20D)));
			this.rightArrow.Closed = true;
			this.rightArrow.Font = new NxtControl.Drawing.Font("HMI Sans Serif", 9F, System.Drawing.FontStyle.Regular);
			this.rightArrow.Name = "rightArrow";
			this.rightArrow.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(33D, 64.19047619047619D),
			new NxtControl.Drawing.PointF(57.7887323943662D, 64.19047619047619D),
			new NxtControl.Drawing.PointF(57.7887323943662D, 58D),
			new NxtControl.Drawing.PointF(73D, 68D),
			new NxtControl.Drawing.PointF(57.7887323943662D, 78D),
			new NxtControl.Drawing.PointF(57.7887323943662D, 71.80952380952381D),
			new NxtControl.Drawing.PointF(33D, 71.80952380952381D)});
			// 
			// leftArrow
			// 
			this.leftArrow.Bounds = new NxtControl.Drawing.RectF(((float)(33D)), ((float)(58D)), ((float)(40D)), ((float)(20D)));
			this.leftArrow.Closed = true;
			this.leftArrow.Font = new NxtControl.Drawing.Font("HMI Sans Serif", 9F, System.Drawing.FontStyle.Regular);
			this.leftArrow.Name = "leftArrow";
			this.leftArrow.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(73D, 64.19047619047619D),
			new NxtControl.Drawing.PointF(48.211267605633807D, 64.19047619047619D),
			new NxtControl.Drawing.PointF(48.211267605633807D, 58D),
			new NxtControl.Drawing.PointF(33D, 68D),
			new NxtControl.Drawing.PointF(48.211267605633807D, 78D),
			new NxtControl.Drawing.PointF(48.211267605633807D, 71.80952380952381D),
			new NxtControl.Drawing.PointF(73D, 71.80952380952381D)});
			// 
			// FbFail
			// 
			this.FbFail.BeginInit();
			this.FbFail.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.FbFail.IsOnlyInput = true;
			this.FbFail.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.FbFail.Name = "FbFail";
			this.FbFail.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.FbFail.TagName = "FbFail";
			this.FbFail.Value = new NxtControl.GuiFramework.VTQ<bool>(false, new System.DateTime(((long)(0))), ((uint)(0u)));
			this.FbFail.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.FbFailValueChanged);
			this.FbFail.EndInit();
			// 
			// DeviceFail
			// 
			this.DeviceFail.BeginInit();
			this.DeviceFail.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.DeviceFail.IsOnlyInput = true;
			this.DeviceFail.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.DeviceFail.Name = "DeviceFail";
			this.DeviceFail.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.DeviceFail.TagName = "DeviceFail";
			this.DeviceFail.Value = new NxtControl.GuiFramework.VTQ<bool>(false, new System.DateTime(((long)(0))), ((uint)(0u)));
			this.DeviceFail.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.DeviceFailValueChanged);
			this.DeviceFail.EndInit();
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
			// sArrows
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.rightArrow,
			this.leftArrow,
			this.FbFail,
			this.DeviceFail,
			this.FbStatus});
			this.SymbolSize = new System.Drawing.Size(200, 200);

		}
		private NxtControl.GuiFramework.Polygon rightArrow;
		private NxtControl.GuiFramework.Polygon leftArrow;
		private System.HMI.Symbols.Base.Execute<NxtControl.GuiFramework.VTQ<bool>> FbFail;
		private System.HMI.Symbols.Base.Execute<NxtControl.GuiFramework.VTQ<bool>> DeviceFail;
		private System.HMI.Symbols.Base.Execute<short> FbStatus;
		#endregion
	}
}
