/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 8/10/2026
 * Time: 3:58 PM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using NxtControl.GuiFramework;

namespace SE.Nereda.Faceplates.EmergencyReactor
{
	/// <summary>
	/// Summary description for fpCurrAerateTime.
	/// </summary>
	partial class fpCurrAerateTime
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.polygon2 = new NxtControl.GuiFramework.Polygon();
			this.rectangle2 = new NxtControl.GuiFramework.Rectangle();
			this.CurrAerateTime = new System.HMI.Symbols.Base.TimeLabel();
			// 
			// polygon2
			// 
			this.polygon2.Bounds = new NxtControl.Drawing.RectF(((float)(8D)), ((float)(8D)), ((float)(256D)), ((float)(24D)));
			this.polygon2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(78)), ((byte)(78)), ((byte)(78))));
			this.polygon2.Closed = true;
			this.polygon2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular);
			this.polygon2.Name = "polygon2";
			this.polygon2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(78)), ((byte)(78)), ((byte)(78))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.polygon2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(8D, 32D),
			new NxtControl.Drawing.PointF(8D, 8D),
			new NxtControl.Drawing.PointF(216D, 8D),
			new NxtControl.Drawing.PointF(264D, 32D)});
			this.polygon2.Text = "S5 - AERATE : Remaining Time";
			this.polygon2.TextColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(0)));
			// 
			// rectangle2
			// 
			this.rectangle2.Bounds = new NxtControl.Drawing.RectF(((float)(8D)), ((float)(24D)), ((float)(256D)), ((float)(32D)));
			this.rectangle2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(250)), ((byte)(250)), ((byte)(250))));
			this.rectangle2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle2.Name = "rectangle2";
			// 
			// CurrAerateTime
			// 
			this.CurrAerateTime.BeginInit();
			this.CurrAerateTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.CurrAerateTime.DesignMatrix = new NxtControl.Drawing.Matrix2D(1.6D, 0D, 0D, 1D, 16D, 32D);
			this.CurrAerateTime.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.CurrAerateTime.FontScale = false;
			this.CurrAerateTime.IsOnlyInput = true;
			this.CurrAerateTime.Name = "CurrAerateTime";
			this.CurrAerateTime.Pen = new NxtControl.Drawing.Pen("LabelPen");
			this.CurrAerateTime.TagName = "CurrAerateTime";
			this.CurrAerateTime.TextColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.CurrAerateTime.EndInit();
			// 
			// fpCurrAerateTime
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(272D)), ((float)(64D)));
			this.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(154)), ((byte)(154)), ((byte)(154))));
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.polygon2,
			this.rectangle2,
			this.CurrAerateTime});
			this.Size = new System.Drawing.Size(272, 64);
			this.Title = "Aerate Remaining Time";

		}
		private NxtControl.GuiFramework.Polygon polygon2;
		private NxtControl.GuiFramework.Rectangle rectangle2;
		private System.HMI.Symbols.Base.TimeLabel CurrAerateTime;
		#endregion
	}
}
