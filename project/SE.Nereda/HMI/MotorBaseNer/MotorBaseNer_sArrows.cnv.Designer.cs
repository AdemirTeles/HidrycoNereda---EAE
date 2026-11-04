/*
 * Created by EcoStruxure Automation Expert.
 * User: SESA397657
 * Date: 13/03/2021
 * Time: 1:56 pm
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.MotorBaseNer
{
	/// <summary>
	/// Summary description for sDefault.
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
			this.FbStatus = new System.HMI.Symbols.Base.Execute<short>();
			this.execute_11 = new System.HMI.Symbols.Base.Execute<NxtControl.GuiFramework.VTQ<bool>>();
			this.execute_12 = new System.HMI.Symbols.Base.Execute<NxtControl.GuiFramework.VTQ<bool>>();
			this.rightArrow = new NxtControl.GuiFramework.Polygon();
			this.leftArrow = new NxtControl.GuiFramework.Polygon();
			// 
			// FbStatus
			// 
			this.FbStatus.BeginInit();
			this.FbStatus.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.FbStatus.IsOnlyInput = true;
			this.FbStatus.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.FbStatus.Name = "FbStatus";
			this.FbStatus.SecurityLevel = 0;
			this.FbStatus.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.FbStatus.TagName = "FbStatus";
			this.FbStatus.Value = ((short)(0));
			this.FbStatus.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.FbStatusValueChanged);
			this.FbStatus.EndInit();
			// 
			// execute_11
			// 
			this.execute_11.BeginInit();
			this.execute_11.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.execute_11.IsOnlyInput = true;
			this.execute_11.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.execute_11.Name = "execute_11";
			this.execute_11.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.execute_11.TagName = "FbFail";
			this.execute_11.Value = new NxtControl.GuiFramework.VTQ<bool>(false, new System.DateTime(((long)(0))), ((uint)(0u)));
			this.execute_11.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.FbFailValueChanged);
			this.execute_11.EndInit();
			// 
			// execute_12
			// 
			this.execute_12.BeginInit();
			this.execute_12.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.execute_12.IsOnlyInput = true;
			this.execute_12.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.execute_12.Name = "execute_12";
			this.execute_12.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.execute_12.TagName = "DeviceFail";
			this.execute_12.Value = new NxtControl.GuiFramework.VTQ<bool>(false, new System.DateTime(((long)(0))), ((uint)(0u)));
			this.execute_12.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.DeviceFailValueChanged);
			this.execute_12.EndInit();
			// 
			// rightArrow
			// 
			this.rightArrow.Bounds = new NxtControl.Drawing.RectF(((float)(25D)), ((float)(34D)), ((float)(40D)), ((float)(20D)));
			this.rightArrow.Closed = true;
			this.rightArrow.Font = new NxtControl.Drawing.Font("HMI Sans Serif", 9F, System.Drawing.FontStyle.Regular);
			this.rightArrow.Name = "rightArrow";
			this.rightArrow.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(25D, 40.19047619047619D),
			new NxtControl.Drawing.PointF(49.7887323943662D, 40.19047619047619D),
			new NxtControl.Drawing.PointF(49.7887323943662D, 34D),
			new NxtControl.Drawing.PointF(65D, 44D),
			new NxtControl.Drawing.PointF(49.7887323943662D, 54D),
			new NxtControl.Drawing.PointF(49.7887323943662D, 47.80952380952381D),
			new NxtControl.Drawing.PointF(25D, 47.80952380952381D)});
			// 
			// leftArrow
			// 
			this.leftArrow.Bounds = new NxtControl.Drawing.RectF(((float)(25D)), ((float)(34D)), ((float)(40D)), ((float)(20D)));
			this.leftArrow.Closed = true;
			this.leftArrow.Font = new NxtControl.Drawing.Font("HMI Sans Serif", 9F, System.Drawing.FontStyle.Regular);
			this.leftArrow.Name = "leftArrow";
			this.leftArrow.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(65D, 40.19047619047619D),
			new NxtControl.Drawing.PointF(40.211267605633793D, 40.19047619047619D),
			new NxtControl.Drawing.PointF(40.211267605633793D, 34D),
			new NxtControl.Drawing.PointF(25D, 44D),
			new NxtControl.Drawing.PointF(40.211267605633793D, 54D),
			new NxtControl.Drawing.PointF(40.211267605633793D, 47.80952380952381D),
			new NxtControl.Drawing.PointF(65D, 47.80952380952381D)});
			// 
			// sArrows
			// 
			this.SecurityToken = ((uint)(4294967175u));
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.FbStatus,
			this.execute_11,
			this.execute_12,
			this.rightArrow,
			this.leftArrow});
			this.SymbolSize = new System.Drawing.Size(192, 128);

		}
		private System.HMI.Symbols.Base.Execute<short> FbStatus;
		private System.HMI.Symbols.Base.Execute<NxtControl.GuiFramework.VTQ<bool>> execute_11;
		private System.HMI.Symbols.Base.Execute<NxtControl.GuiFramework.VTQ<bool>> execute_12;
		private NxtControl.GuiFramework.Polygon rightArrow;
		private NxtControl.GuiFramework.Polygon leftArrow;
		#endregion
	}
}



