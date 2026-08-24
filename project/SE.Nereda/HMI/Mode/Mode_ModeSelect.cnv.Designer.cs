/*
 * Created by EcoStruxure Automation Expert.
 * User: SESA371406
 * Date: 3/27/2024
 * Time: 8:47 AM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using NxtControl.GuiFramework;

namespace SE.Nereda.Faceplates.Mode
{
	/// <summary>
	/// Summary description for ModeSelect.
	/// </summary>
	partial class ModeSelect
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new NxtControl.GuiFramework.Label();
			this.roundedRectangle1 = new NxtControl.GuiFramework.RoundedRectangle();
			this.fbMode = new System.HMI.Symbols.Base.Execute<short>();
			this.ModeSelector = new NxtControl.GuiFramework.DrawnComboBox();
			// 
			// label1
			// 
			this.label1.AngleIgnore = true;
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.label1.Bounds = new NxtControl.Drawing.RectF(((float)(16D)), ((float)(8D)), ((float)(124D)), ((float)(26D)));
			this.label1.Brush = new NxtControl.Drawing.Brush("LabelBrush");
			this.label1.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.label1.FontScale = true;
			this.label1.Name = "label1";
			this.label1.Pen = new NxtControl.Drawing.Pen("LabelPen");
			this.label1.Text = "Mode :";
			this.label1.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.label1.TextAutoSizeHorizontalOffset = 10;
			this.label1.TextPadding = new NxtControl.Drawing.Padding(2);
			// 
			// roundedRectangle1
			// 
			this.roundedRectangle1.Bounds = new NxtControl.Drawing.RectF(((float)(8D)), ((float)(8D)), ((float)(192D)), ((float)(72D)));
			this.roundedRectangle1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.roundedRectangle1.Name = "roundedRectangle1";
			// 
			// fbMode
			// 
			this.fbMode.BeginInit();
			this.fbMode.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.fbMode.IsOnlyInput = true;
			this.fbMode.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.fbMode.Name = "fbMode";
			this.fbMode.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.fbMode.TagName = "fbMode";
			this.fbMode.Value = ((short)(0));
			this.fbMode.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.FbModeValueChanged);
			this.fbMode.EndInit();
			// 
			// ModeSelector
			// 
			this.ModeSelector.Bounds = new NxtControl.Drawing.RectF(((float)(24D)), ((float)(40D)), ((float)(160D)), ((float)(27D)));
			this.ModeSelector.Brush = new NxtControl.Drawing.Brush("ComboBoxBrush");
			this.ModeSelector.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.ModeSelector.Items.AddRange(new string[] {
			"Automatic",
			"Off",
			"Manual",
			"Emergency"});
			this.ModeSelector.Name = "ModeSelector";
			this.ModeSelector.Pen = new NxtControl.Drawing.Pen("ComboBoxPen");
			this.ModeSelector.SelectedIndex = -1;
			this.ModeSelector.TextColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.ModeSelector.TextPadding = new NxtControl.Drawing.Padding(2);
			this.ModeSelector.SelectedIndexChanged += new System.EventHandler(this.ModeSelectedIndexChanged);
			// 
			// ModeSelect
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(208D)), ((float)(88D)));
			this.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(154)), ((byte)(154)), ((byte)(154))));
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.roundedRectangle1,
			this.label1,
			this.fbMode,
			this.ModeSelector});
			this.Size = new System.Drawing.Size(208, 88);
			this.Title = "Mode";

		}
		private NxtControl.GuiFramework.Label label1;
		private NxtControl.GuiFramework.RoundedRectangle roundedRectangle1;
		private System.HMI.Symbols.Base.Execute<short> fbMode;
		private NxtControl.GuiFramework.DrawnComboBox ModeSelector;
		#endregion
	}
}
