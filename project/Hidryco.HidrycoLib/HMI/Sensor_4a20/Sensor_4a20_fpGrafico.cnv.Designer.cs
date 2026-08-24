/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 2/4/2026
 * Time: 9:39 AM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Faceplates.Sensor_4a20
{
	/// <summary>
	/// Summary description for fpGrafico.
	/// </summary>
	partial class fpGrafico
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.trendControl1 = new NxtControl.GuiFramework.TrendControl();
			((System.ComponentModel.ISupportInitialize)(this.trendControl1)).BeginInit();
			// 
			// trendControl1
			// 
			this.trendControl1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.trendControl1.Location = new System.Drawing.Point(0, 0);
			this.trendControl1.MinimalSize = new System.Drawing.Size(60, 60);
			this.trendControl1.Name = "trendControl1";
			this.trendControl1.ParentSymbol = this;
			this.trendControl1.Series.Add(new NxtControl.GuiFramework.TrendFastLine("stsSensor", new NxtControl.Drawing.Color(((byte)(255)), ((byte)(127)), ((byte)(71))), false, 0D, 100D, "Left", "", "", 1, NxtControl.Drawing.DashStyle.Solid, true, "", 100000));
			this.trendControl1.Size = new System.Drawing.Size(593, 393);
			this.trendControl1.Text = "trendControl1";
			this.trendControl1.TimeScale = new NxtControl.GuiFramework.TrendTimeScale(true, "HH:mm", false, true);
			this.trendControl1.TimeSpan = System.TimeSpan.Parse("00:05:00");
			this.trendControl1.ValueScales.Add(new NxtControl.GuiFramework.TrendValueScale(NxtControl.GuiFramework.TrendValueScaleType.Left, true, "#,##0.##", 0D, 100D, true, "", 0D, 100D, false, false, true));
			this.trendControl1.ValueScales.Add(new NxtControl.GuiFramework.TrendValueScale(NxtControl.GuiFramework.TrendValueScaleType.Right, true, "#,##0.##", 0D, 0D, false, "", 0D, 100D, false, false, true));
			this.trendControl1.ZoomPercentX = 10D;
			this.trendControl1.ZoomPercentY = 10D;
			// 
			// fpGrafico
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(600D)), ((float)(400D)));
			this.Brush = new NxtControl.Drawing.Brush("FaceplateBrush");
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.trendControl1});
			this.Size = new System.Drawing.Size(600, 400);
			((System.ComponentModel.ISupportInitialize)(this.trendControl1)).EndInit();

		}
		private NxtControl.GuiFramework.TrendControl trendControl1;
		#endregion
	}
}
