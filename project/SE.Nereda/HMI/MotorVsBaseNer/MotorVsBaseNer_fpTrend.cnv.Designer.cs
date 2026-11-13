/*
 * Created by EcoStruxure Automation Expert.
 * User: SESA671563
 * Date: 10/19/2022
 * Time: 10:16 PM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using NxtControl.GuiFramework;

namespace SE.Nereda.Faceplates.MotorVsBaseNer
{
	/// <summary>
	/// Summary description for fpTrend.
	/// </summary>
	partial class fpTrend
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.trendControl1 = new NxtControl.GuiFramework.TrendControl();
			this.btn5m = new NxtControl.GuiFramework.DrawnButton();
			this.btn30m = new NxtControl.GuiFramework.DrawnButton();
			this.btn1h = new NxtControl.GuiFramework.DrawnButton();
			this.btn8h = new NxtControl.GuiFramework.DrawnButton();
			((System.ComponentModel.ISupportInitialize)(this.trendControl1)).BeginInit();
			// 
			// trendControl1
			// 
			this.trendControl1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.trendControl1.Location = new System.Drawing.Point(0, 40);
			this.trendControl1.MinimalSize = new System.Drawing.Size(60, 60);
			this.trendControl1.Name = "trendControl1";
			this.trendControl1.ParentSymbol = this;
			this.trendControl1.Series.Add(new NxtControl.GuiFramework.TrendFastLine("SpeedFbStatus", new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), false, 0D, 100D, "Left", null, "Velocidade real (%)", 2, NxtControl.Drawing.DashStyle.Solid, true, "0.0", 100000));
			this.trendControl1.Series.Add(new NxtControl.GuiFramework.TrendFastLine("CurrentSpeedSp", new NxtControl.Drawing.Color(((byte)(0)), ((byte)(90)), ((byte)(200))), false, 0D, 100D, "Left", null, "Refer\u00eancia (%)", 2, NxtControl.Drawing.DashStyle.Dash, true, "0.0", 100000));
			this.trendControl1.Size = new System.Drawing.Size(550, 500);
			this.trendControl1.Text = "trendControl1";
			this.trendControl1.TimeScale = new NxtControl.GuiFramework.TrendTimeScale(true, "HH:mm", false, true);
			this.trendControl1.TimeSpan = System.TimeSpan.Parse("00:05:00");
			this.trendControl1.ValueScales.Add(new NxtControl.GuiFramework.TrendValueScale(NxtControl.GuiFramework.TrendValueScaleType.Left, true, "#,##0.##", 0D, 100D, true, "", 0D, 100D, false, false, true));
			this.trendControl1.ValueScales.Add(new NxtControl.GuiFramework.TrendValueScale(NxtControl.GuiFramework.TrendValueScaleType.Right, true, "#,##0.##", 0D, 0D, false, "", 0D, 100D, false, false, true));
			this.trendControl1.ZoomPercentX = 10D;
			this.trendControl1.ZoomPercentY = 10D;
			// 
			// fpTrend
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(550D)), ((float)(540D)));
			this.Brush = new NxtControl.Drawing.Brush("FaceplateBrush");
			this.Name = "fpTrend";
			// 
			// btn5m
			// 
			this.btn5m.Bounds = new NxtControl.Drawing.RectF(((float)(10D)), ((float)(6D)), ((float)(80D)), ((float)(28D)));
			this.btn5m.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(215)), ((byte)(215)), ((byte)(215))));
			this.btn5m.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.btn5m.InnerBorderColor = new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208)));
			this.btn5m.Name = "btn5m";
			this.btn5m.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.btn5m.Radius = 2D;
			this.btn5m.Text = "5 min";
			this.btn5m.TextColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.btn5m.TextColorMouseDown = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.btn5m.Use3DEffect = false;
			this.btn5m.Click += new System.EventHandler(this.BtnTempoClick);
			// 
			// btn30m
			// 
			this.btn30m.Bounds = new NxtControl.Drawing.RectF(((float)(96D)), ((float)(6D)), ((float)(80D)), ((float)(28D)));
			this.btn30m.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(215)), ((byte)(215)), ((byte)(215))));
			this.btn30m.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.btn30m.InnerBorderColor = new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208)));
			this.btn30m.Name = "btn30m";
			this.btn30m.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.btn30m.Radius = 2D;
			this.btn30m.Text = "30 min";
			this.btn30m.TextColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.btn30m.TextColorMouseDown = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.btn30m.Use3DEffect = false;
			this.btn30m.Click += new System.EventHandler(this.BtnTempoClick);
			// 
			// btn1h
			// 
			this.btn1h.Bounds = new NxtControl.Drawing.RectF(((float)(182D)), ((float)(6D)), ((float)(80D)), ((float)(28D)));
			this.btn1h.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(215)), ((byte)(215)), ((byte)(215))));
			this.btn1h.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.btn1h.InnerBorderColor = new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208)));
			this.btn1h.Name = "btn1h";
			this.btn1h.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.btn1h.Radius = 2D;
			this.btn1h.Text = "1 h";
			this.btn1h.TextColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.btn1h.TextColorMouseDown = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.btn1h.Use3DEffect = false;
			this.btn1h.Click += new System.EventHandler(this.BtnTempoClick);
			// 
			// btn8h
			// 
			this.btn8h.Bounds = new NxtControl.Drawing.RectF(((float)(268D)), ((float)(6D)), ((float)(80D)), ((float)(28D)));
			this.btn8h.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(215)), ((byte)(215)), ((byte)(215))));
			this.btn8h.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.btn8h.InnerBorderColor = new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208)));
			this.btn8h.Name = "btn8h";
			this.btn8h.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.btn8h.Radius = 2D;
			this.btn8h.Text = "8 h";
			this.btn8h.TextColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.btn8h.TextColorMouseDown = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.btn8h.Use3DEffect = false;
			this.btn8h.Click += new System.EventHandler(this.BtnTempoClick);
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.btn5m,
			this.btn30m,
			this.btn1h,
			this.btn8h,
			this.trendControl1});
			this.Size = new System.Drawing.Size(550, 540);
			((System.ComponentModel.ISupportInitialize)(this.trendControl1)).EndInit();

		}
		private NxtControl.GuiFramework.TrendControl trendControl1;
		private NxtControl.GuiFramework.DrawnButton btn5m;
		private NxtControl.GuiFramework.DrawnButton btn30m;
		private NxtControl.GuiFramework.DrawnButton btn1h;
		private NxtControl.GuiFramework.DrawnButton btn8h;
		#endregion
	}
}



