/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 8/3/2026
 * Time: 3:11 PM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using NxtControl.GuiFramework;

namespace SE.Nereda.Faceplates.AutoResetCdt
{
	/// <summary>
	/// Summary description for fpReset.
	/// </summary>
	partial class fpReset
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary1 = new NxtControl.GuiFramework.PropertyDictionary();
			this.rectangle2 = new NxtControl.GuiFramework.Rectangle();
			this.label1 = new NxtControl.GuiFramework.Label();
			this.label2 = new NxtControl.GuiFramework.Label();
			this.TimeOut = new System.HMI.Symbols.Base.TimeTextBox();
			this.ResetNbr = new System.HMI.Symbols.Base.TextBox<short>();
			this.TimeOut_1 = new SE.Nereda.Symbols.E_DELAY_V_D.sDefault();
			this.label3 = new NxtControl.GuiFramework.Label();
			this.line1 = new NxtControl.GuiFramework.Line();
			this.label4 = new NxtControl.GuiFramework.Label();
			this.CurrResetNbr = new System.HMI.Symbols.Base.Execute<short>();
			this.CurrResetNbr_1 = new System.HMI.Symbols.Base.FreeText<short>();
			// 
			// rectangle2
			// 
			this.rectangle2.Bounds = new NxtControl.Drawing.RectF(((float)(8D)), ((float)(8D)), ((float)(344D)), ((float)(176D)));
			this.rectangle2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(250)), ((byte)(250)), ((byte)(250))));
			this.rectangle2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle2.Name = "rectangle2";
			// 
			// label1
			// 
			this.label1.AngleIgnore = true;
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.label1.Bounds = new NxtControl.Drawing.RectF(((float)(16D)), ((float)(16D)), ((float)(256D)), ((float)(26D)));
			this.label1.Brush = new NxtControl.Drawing.Brush("LabelBrush");
			this.label1.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.label1.FontScale = true;
			this.label1.Name = "label1";
			this.label1.Pen = new NxtControl.Drawing.Pen("LabelPen");
			this.label1.Text = "Auto-Reset Interlock Permit Interval ";
			this.label1.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.label1.TextAutoSizeHorizontalOffset = 10;
			this.label1.TextPadding = new NxtControl.Drawing.Padding(2);
			// 
			// label2
			// 
			this.label2.AngleIgnore = true;
			this.label2.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.label2.Bounds = new NxtControl.Drawing.RectF(((float)(16D)), ((float)(48D)), ((float)(176D)), ((float)(26D)));
			this.label2.Brush = new NxtControl.Drawing.Brush("LabelBrush");
			this.label2.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.label2.FontScale = true;
			this.label2.Name = "label2";
			this.label2.Pen = new NxtControl.Drawing.Pen("LabelPen");
			this.label2.Text = "Number of Auto-Resets";
			this.label2.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.label2.TextAutoSizeHorizontalOffset = 10;
			this.label2.TextPadding = new NxtControl.Drawing.Padding(2);
			// 
			// TimeOut
			// 
			this.TimeOut.BeginInit();
			this.TimeOut.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.53333333333333333D, 0D, 0D, 1D, 264D, 16D);
			this.TimeOut.MaximumTag = null;
			this.TimeOut.MinimumTag = null;
			this.TimeOut.Name = "TimeOut";
			this.TimeOut.TagName = "TimeOut";
			this.TimeOut.TextColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.TimeOut.UseInputPad = true;
			this.TimeOut.Value = new NxtControl.GuiFramework.Time(((long)(0)));
			this.TimeOut.EndInit();
			// 
			// ResetNbr
			// 
			this.ResetNbr.BeginInit();
			this.ResetNbr.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.53333333333333333D, 0D, 0D, 1D, 264D, 48D);
			this.ResetNbr.MaximumTag = null;
			this.ResetNbr.MinimumTag = null;
			this.ResetNbr.Name = "ResetNbr";
			this.ResetNbr.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.ResetNbr.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.ResetNbr.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.ResetNbr.TagName = "ResetNbr";
			this.ResetNbr.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			this.ResetNbr.TextColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.ResetNbr.UseInputPad = true;
			this.ResetNbr.Value = ((short)(0));
			this.ResetNbr.EndInit();
			// 
			// TimeOut_1
			// 
			this.TimeOut_1.BeginInit();
			this.TimeOut_1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 24D, 104D);
			this.TimeOut_1.Name = "TimeOut_1";
			this.TimeOut_1.SecurityToken = ((uint)(4294967295u));
			this.TimeOut_1.TagName = "TimeOut";
			this.TimeOut_1.EndInit();
			// 
			// label3
			// 
			this.label3.AngleIgnore = true;
			this.label3.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.label3.Bounds = new NxtControl.Drawing.RectF(((float)(16D)), ((float)(80D)), ((float)(280D)), ((float)(26D)));
			this.label3.Brush = new NxtControl.Drawing.Brush("LabelBrush");
			this.label3.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.label3.FontScale = true;
			this.label3.Name = "label3";
			this.label3.Pen = new NxtControl.Drawing.Pen("LabelPen");
			this.label3.Text = "Auto-Reset Interlock Permit Interval Time";
			this.label3.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.label3.TextAutoSizeHorizontalOffset = 10;
			this.label3.TextPadding = new NxtControl.Drawing.Padding(2);
			// 
			// line1
			// 
			this.line1.EndPoint = new NxtControl.Drawing.PointF(352D, 80D);
			this.line1.Name = "line1";
			this.line1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line1.StartPoint = new NxtControl.Drawing.PointF(8D, 80D);
			// 
			// label4
			// 
			this.label4.AngleIgnore = true;
			this.label4.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.label4.Bounds = new NxtControl.Drawing.RectF(((float)(16D)), ((float)(136D)), ((float)(280D)), ((float)(26D)));
			this.label4.Brush = new NxtControl.Drawing.Brush("LabelBrush");
			this.label4.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.label4.FontScale = true;
			this.label4.Name = "label4";
			this.label4.Pen = new NxtControl.Drawing.Pen("LabelPen");
			this.label4.Text = "Current number of Reset";
			this.label4.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.label4.TextAutoSizeHorizontalOffset = 10;
			this.label4.TextPadding = new NxtControl.Drawing.Padding(2);
			// 
			// CurrResetNbr
			// 
			this.CurrResetNbr.BeginInit();
			this.CurrResetNbr.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.CurrResetNbr.IsOnlyInput = true;
			this.CurrResetNbr.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.CurrResetNbr.Name = "CurrResetNbr";
			this.CurrResetNbr.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.CurrResetNbr.TagName = "CurrResetNbr";
			this.CurrResetNbr.Value = ((short)(0));
			this.CurrResetNbr.EndInit();
			// 
			// CurrResetNbr_1
			// 
			this.CurrResetNbr_1.BeginInit();
			this.CurrResetNbr_1.DecimalPlacesCount = ((uint)(2u));
			this.CurrResetNbr_1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 24D, 160D);
			this.CurrResetNbr_1.IsOnlyInput = true;
			this.CurrResetNbr_1.Name = "CurrResetNbr_1";
			propertyDictionary1.Add("Text", "${Value}");
			propertyDictionary1.Add("TextColor", new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			this.CurrResetNbr_1.Ranges.DefaultPropertyValues = propertyDictionary1;
			this.CurrResetNbr_1.TagName = "CurrResetNbr";
			this.CurrResetNbr_1.TextAngle = 0F;
			this.CurrResetNbr_1.EndInit();
			// 
			// fpReset
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(360D)), ((float)(192D)));
			this.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(154)), ((byte)(154)), ((byte)(154))));
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.rectangle2,
			this.label1,
			this.label2,
			this.TimeOut,
			this.ResetNbr,
			this.TimeOut_1,
			this.label3,
			this.line1,
			this.label4,
			this.CurrResetNbr,
			this.CurrResetNbr_1});
			this.Size = new System.Drawing.Size(360, 192);
			this.Title = "Auto Reset Settings";

		}
		private NxtControl.GuiFramework.Rectangle rectangle2;
		private NxtControl.GuiFramework.Label label1;
		private NxtControl.GuiFramework.Label label2;
		private System.HMI.Symbols.Base.TimeTextBox TimeOut;
		private System.HMI.Symbols.Base.TextBox<short> ResetNbr;
		private SE.Nereda.Symbols.E_DELAY_V_D.sDefault TimeOut_1;
		private NxtControl.GuiFramework.Label label3;
		private NxtControl.GuiFramework.Line line1;
		private NxtControl.GuiFramework.Label label4;
		private System.HMI.Symbols.Base.Execute<short> CurrResetNbr;
		private System.HMI.Symbols.Base.FreeText<short> CurrResetNbr_1;
		#endregion
	}
}
