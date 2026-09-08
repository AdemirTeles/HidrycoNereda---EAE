/*
 * Created by EcoStruxure Automation Expert.
 * User: SESA583220
 * Date: 10/3/2022
 * Time: 5:35 PM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.Mode
{
	/// <summary>
	/// Summary description for Symbol1.
	/// </summary>
	partial class ReactorMode
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.Auto = new System.HMI.Symbols.Base.Execute<bool>();
			this.Manual = new System.HMI.Symbols.Base.Execute<bool>();
			this.OFF = new System.HMI.Symbols.Base.Execute<bool>();
			this.Emergency = new System.HMI.Symbols.Base.Execute<bool>();
			this.roundedRectangle1 = new NxtControl.GuiFramework.RoundedRectangle();
			this.ModeTxt = new NxtControl.GuiFramework.Label();
			// 
			// Auto
			// 
			this.Auto.BeginInit();
			this.Auto.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.Auto.IsOnlyInput = true;
			this.Auto.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.Auto.Name = "Auto";
			this.Auto.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.Auto.TagName = "Auto";
			this.Auto.Value = false;
			this.Auto.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.AutoValueChanged);
			this.Auto.EndInit();
			// 
			// Manual
			// 
			this.Manual.BeginInit();
			this.Manual.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.Manual.IsOnlyInput = true;
			this.Manual.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.Manual.Name = "Manual";
			this.Manual.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.Manual.TagName = "Manual";
			this.Manual.Value = false;
			this.Manual.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.ManualValueChanged);
			this.Manual.EndInit();
			// 
			// OFF
			// 
			this.OFF.BeginInit();
			this.OFF.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.OFF.IsOnlyInput = true;
			this.OFF.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.OFF.Name = "OFF";
			this.OFF.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.OFF.TagName = "OFF";
			this.OFF.Value = false;
			this.OFF.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.OFFValueChanged);
			this.OFF.EndInit();
			// 
			// Emergency
			// 
			this.Emergency.BeginInit();
			this.Emergency.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.Emergency.IsOnlyInput = true;
			this.Emergency.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.Emergency.Name = "Emergency";
			this.Emergency.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.Emergency.TagName = "Emergency";
			this.Emergency.Value = false;
			this.Emergency.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.EmergencyValueChanged);
			this.Emergency.EndInit();
			// 
			// roundedRectangle1
			// 
			this.roundedRectangle1.Bounds = new NxtControl.Drawing.RectF(((float)(16D)), ((float)(16D)), ((float)(192D)), ((float)(40D)));
			this.roundedRectangle1.Brush = new NxtControl.Drawing.Brush(true);
			this.roundedRectangle1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.roundedRectangle1.Name = "roundedRectangle1";
			this.roundedRectangle1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Dash);
			// 
			// ModeTxt
			// 
			this.ModeTxt.AngleIgnore = true;
			this.ModeTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.ModeTxt.Bounds = new NxtControl.Drawing.RectF(((float)(32D)), ((float)(16D)), ((float)(158D)), ((float)(42D)));
			this.ModeTxt.Brush = new NxtControl.Drawing.Brush("LabelBrush");
			this.ModeTxt.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.ModeTxt.FontScale = true;
			this.ModeTxt.Name = "ModeTxt";
			this.ModeTxt.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("ModeSelect", NxtControl.GuiFramework.MouseButtonType.Click));
			this.ModeTxt.Pen = new NxtControl.Drawing.Pen("LabelPen");
			this.ModeTxt.Text = "Mode";
			this.ModeTxt.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			this.ModeTxt.TextAutoSizeHorizontalOffset = 10;
			this.ModeTxt.TextColor = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(205)), ((byte)(32)));
			this.ModeTxt.TextPadding = new NxtControl.Drawing.Padding(2);
			// 
			// ReactorMode
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.Auto,
			this.Manual,
			this.OFF,
			this.Emergency,
			this.roundedRectangle1,
			this.ModeTxt});
			this.SymbolSize = new System.Drawing.Size(232, 80);

		}
		private System.HMI.Symbols.Base.Execute<bool> Auto;
		private System.HMI.Symbols.Base.Execute<bool> Manual;
		private System.HMI.Symbols.Base.Execute<bool> OFF;
		private System.HMI.Symbols.Base.Execute<bool> Emergency;
		private NxtControl.GuiFramework.RoundedRectangle roundedRectangle1;
		private NxtControl.GuiFramework.Label ModeTxt;
		#endregion
	}
}
