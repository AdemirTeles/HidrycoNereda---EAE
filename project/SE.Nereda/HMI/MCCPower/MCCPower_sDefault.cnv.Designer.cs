/*
 * Created by EcoStruxure Automation Expert.
 * User: SESA371406
 * Date: 3/8/2024
 * Time: 2:03 PM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.MCCPower
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
			this.roundedRectangle1 = new NxtControl.GuiFramework.RoundedRectangle();
			this.label2 = new NxtControl.GuiFramework.Label();
			this.MCCPower = new System.HMI.Symbols.Base.Execute<bool>();
			this.MCCPowerOFF = new System.HMI.Symbols.Base.Execute<bool>();
			// 
			// roundedRectangle1
			// 
			this.roundedRectangle1.Bounds = new NxtControl.Drawing.RectF(((float)(176D)), ((float)(128D)), ((float)(192D)), ((float)(40D)));
			this.roundedRectangle1.Brush = new NxtControl.Drawing.Brush();
			this.roundedRectangle1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.roundedRectangle1.Name = "roundedRectangle1";
			this.roundedRectangle1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Dash);
			// 
			// label2
			// 
			this.label2.AngleIgnore = true;
			this.label2.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.label2.Bounds = new NxtControl.Drawing.RectF(((float)(192D)), ((float)(128D)), ((float)(158D)), ((float)(42D)));
			this.label2.Brush = new NxtControl.Drawing.Brush("LabelBrush");
			this.label2.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.label2.FontScale = true;
			this.label2.Name = "label2";
			this.label2.Pen = new NxtControl.Drawing.Pen("LabelPen");
			this.label2.Text = "MCC POWER ON";
			this.label2.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			this.label2.TextAutoSizeHorizontalOffset = 10;
			this.label2.TextColor = new NxtControl.Drawing.BlinkColor("DevError");
			this.label2.TextPadding = new NxtControl.Drawing.Padding(2);
			// 
			// MCCPower
			// 
			this.MCCPower.BeginInit();
			this.MCCPower.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.MCCPower.IsOnlyInput = true;
			this.MCCPower.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.MCCPower.Name = "MCCPower";
			this.MCCPower.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.MCCPower.TagName = "MCCPower";
			this.MCCPower.Value = false;
			this.MCCPower.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.MCCPowerValueChanged);
			this.MCCPower.EndInit();
			// 
			// MCCPowerOFF
			// 
			this.MCCPowerOFF.BeginInit();
			this.MCCPowerOFF.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.MCCPowerOFF.IsOnlyInput = true;
			this.MCCPowerOFF.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.MCCPowerOFF.Name = "MCCPowerOFF";
			this.MCCPowerOFF.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.MCCPowerOFF.TagName = "";
			this.MCCPowerOFF.Value = false;
			this.MCCPowerOFF.EndInit();
			// 
			// sDefault
			// 
			this.Name = "sDefault";
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.roundedRectangle1,
			this.label2,
			this.MCCPower,
			this.MCCPowerOFF});
			this.SymbolSize = new System.Drawing.Size(600, 400);

		}
		private NxtControl.GuiFramework.RoundedRectangle roundedRectangle1;
		private NxtControl.GuiFramework.Label label2;
		private System.HMI.Symbols.Base.Execute<bool> MCCPower;
		private System.HMI.Symbols.Base.Execute<bool> MCCPowerOFF;
		#endregion
	}
}
