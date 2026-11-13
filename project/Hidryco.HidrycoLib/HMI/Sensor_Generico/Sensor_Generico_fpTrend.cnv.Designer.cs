/*
 * Hidryco - Sensor_Generico - fpTrend
 * Grafico do valor (STS_SENSOR) com os limites HH/H/L/LL tracejados (STS_LIMITE_*, ja em unidade de engenharia pelo CLP) e escala fixa na faixa do sensor.
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Faceplates.Sensor_Generico
{
	partial class fpTrend
	{

		#region Component Designer generated code
		private void InitializeComponent()
		{
			this.trendControl1 = new NxtControl.GuiFramework.TrendControl();
			this.btn5m = new NxtControl.GuiFramework.DrawnButton();
			this.btn30m = new NxtControl.GuiFramework.DrawnButton();
			this.btn1h = new NxtControl.GuiFramework.DrawnButton();
			this.btn8h = new NxtControl.GuiFramework.DrawnButton();
			this.tCasas = new System.HMI.Symbols.Base.Execute<ushort>();
			this.tRangeMin = new System.HMI.Symbols.Base.TextBox<float>();
			this.tRangeMax = new System.HMI.Symbols.Base.TextBox<float>();
			this.tHabHH = new System.HMI.Symbols.Base.CheckButton();
			this.tHabH = new System.HMI.Symbols.Base.CheckButton();
			this.tHabL = new System.HMI.Symbols.Base.CheckButton();
			this.tHabLL = new System.HMI.Symbols.Base.CheckButton();
			this.tUnidade = new System.HMI.Symbols.Base.Execute<string>();
			((System.ComponentModel.ISupportInitialize)(this.trendControl1)).BeginInit();
			// 
			// trendControl1
			// 
			this.trendControl1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.trendControl1.Location = new System.Drawing.Point(0, 40);
			this.trendControl1.MinimalSize = new System.Drawing.Size(60, 60);
			this.trendControl1.Name = "trendControl1";
			this.trendControl1.ParentSymbol = this;
			this.trendControl1.Series.Add(new NxtControl.GuiFramework.TrendFastLine("STS_SENSOR", new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), false, 0D, 100D, "Left", "", "Valor", 2, NxtControl.Drawing.DashStyle.Solid, true, "0.00", 100000));
			this.trendControl1.Series.Add(new NxtControl.GuiFramework.TrendFastLine("STS_LIMITE_HH", new NxtControl.Drawing.Color(((byte)(192)), ((byte)(0)), ((byte)(0))), true, 0D, 100D, "Left", "", "Limite HH", 1, NxtControl.Drawing.DashStyle.Dash, false, "", 100000));
			this.trendControl1.Series.Add(new NxtControl.GuiFramework.TrendFastLine("STS_LIMITE_H", new NxtControl.Drawing.Color(((byte)(230)), ((byte)(140)), ((byte)(0))), true, 0D, 100D, "Left", "", "Limite H", 1, NxtControl.Drawing.DashStyle.Dash, false, "", 100000));
			this.trendControl1.Series.Add(new NxtControl.GuiFramework.TrendFastLine("STS_LIMITE_L", new NxtControl.Drawing.Color(((byte)(230)), ((byte)(140)), ((byte)(0))), true, 0D, 100D, "Left", "", "Limite L", 1, NxtControl.Drawing.DashStyle.Dash, false, "", 100000));
			this.trendControl1.Series.Add(new NxtControl.GuiFramework.TrendFastLine("STS_LIMITE_LL", new NxtControl.Drawing.Color(((byte)(192)), ((byte)(0)), ((byte)(0))), true, 0D, 100D, "Left", "", "Limite LL", 1, NxtControl.Drawing.DashStyle.Dash, false, "", 100000));
			this.trendControl1.Size = new System.Drawing.Size(693, 393);
			this.trendControl1.Text = "trendControl1";
			this.trendControl1.TimeScale = new NxtControl.GuiFramework.TrendTimeScale(true, "HH:mm", false, true);
			this.trendControl1.TimeSpan = System.TimeSpan.Parse("00:30:00");
			this.trendControl1.ValueScales.Add(new NxtControl.GuiFramework.TrendValueScale(NxtControl.GuiFramework.TrendValueScaleType.Left, true, "#,##0.##", 0D, 100D, true, "", 0D, 100D, false, false, true));
			this.trendControl1.ValueScales.Add(new NxtControl.GuiFramework.TrendValueScale(NxtControl.GuiFramework.TrendValueScaleType.Right, true, "#,##0.##", 0D, 0D, false, "", 0D, 100D, false, false, true));
			this.trendControl1.ZoomPercentX = 10D;
			this.trendControl1.ZoomPercentY = 10D;
			// 
			// tCasas
			// 
			this.tCasas.BeginInit();
			this.tCasas.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.tCasas.IsOnlyInput = true;
			this.tCasas.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.tCasas.Name = "tCasas";
			this.tCasas.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.tCasas.TagName = "CFG_CASAS_DECIMAIS";
			this.tCasas.Value = ((ushort)(0));
			this.tCasas.Visible = false;
			this.tCasas.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.OcultoValueChanged);
			this.tCasas.EndInit();
			// 
			// tRangeMin
			// 
			this.tRangeMin.BeginInit();
			this.tRangeMin.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.7D, 0D, 0D, 1D, 220D, 112D);
			this.tRangeMin.MaximumTag = null;
			this.tRangeMin.MinimumTag = null;
			this.tRangeMin.Name = "tRangeMin";
			this.tRangeMin.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.tRangeMin.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.tRangeMin.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.tRangeMin.TagName = "STP_RANGE_MINIMO";
			this.tRangeMin.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.tRangeMin.UseInputPad = true;
			this.tRangeMin.Value = 0F;
			this.tRangeMin.Visible = false;
			this.tRangeMin.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.OcultoValueChanged);
			this.tRangeMin.EndInit();
			// 
			// tRangeMax
			// 
			this.tRangeMax.BeginInit();
			this.tRangeMax.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.7D, 0D, 0D, 1D, 220D, 152D);
			this.tRangeMax.MaximumTag = null;
			this.tRangeMax.MinimumTag = null;
			this.tRangeMax.Name = "tRangeMax";
			this.tRangeMax.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.tRangeMax.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.tRangeMax.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.tRangeMax.TagName = "STP_RANGE_MAXIMO";
			this.tRangeMax.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.tRangeMax.UseInputPad = true;
			this.tRangeMax.Value = 0F;
			this.tRangeMax.Visible = false;
			this.tRangeMax.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.OcultoValueChanged);
			this.tRangeMax.EndInit();
			// 
			// tHabHH
			// 
			this.tHabHH.BeginInit();
			this.tHabHH.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 70D, 84D);
			this.tHabHH.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.tHabHH.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.tHabHH.FalseText = "Não";
			this.tHabHH.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.tHabHH.FontScale = false;
			this.tHabHH.Name = "tHabHH";
			this.tHabHH.TagName = "CMD_HABILITA_ALARME_HH";
			this.tHabHH.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.tHabHH.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.tHabHH.TrueText = "Sim";
			this.tHabHH.Value = false;
			this.tHabHH.Visible = false;
			this.tHabHH.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.OcultoValueChanged);
			this.tHabHH.EndInit();
			// 
			// tHabH
			// 
			this.tHabH.BeginInit();
			this.tHabH.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 70D, 124D);
			this.tHabH.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.tHabH.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.tHabH.FalseText = "Não";
			this.tHabH.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.tHabH.FontScale = false;
			this.tHabH.Name = "tHabH";
			this.tHabH.TagName = "CMD_HABILITA_ALARME_H";
			this.tHabH.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.tHabH.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.tHabH.TrueText = "Sim";
			this.tHabH.Value = false;
			this.tHabH.Visible = false;
			this.tHabH.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.OcultoValueChanged);
			this.tHabH.EndInit();
			// 
			// tHabL
			// 
			this.tHabL.BeginInit();
			this.tHabL.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 70D, 164D);
			this.tHabL.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.tHabL.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.tHabL.FalseText = "Não";
			this.tHabL.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.tHabL.FontScale = false;
			this.tHabL.Name = "tHabL";
			this.tHabL.TagName = "CMD_HABILITA_ALARME_L";
			this.tHabL.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.tHabL.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.tHabL.TrueText = "Sim";
			this.tHabL.Value = false;
			this.tHabL.Visible = false;
			this.tHabL.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.OcultoValueChanged);
			this.tHabL.EndInit();
			// 
			// tHabLL
			// 
			this.tHabLL.BeginInit();
			this.tHabLL.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 70D, 204D);
			this.tHabLL.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.tHabLL.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.tHabLL.FalseText = "Não";
			this.tHabLL.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.tHabLL.FontScale = false;
			this.tHabLL.Name = "tHabLL";
			this.tHabLL.TagName = "CMD_HABILITA_ALARME_LL";
			this.tHabLL.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.tHabLL.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.tHabLL.TrueText = "Sim";
			this.tHabLL.Value = false;
			this.tHabLL.Visible = false;
			this.tHabLL.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.OcultoValueChanged);
			this.tHabLL.EndInit();
			// 
			// tUnidade
			// 
			this.tUnidade.BeginInit();
			this.tUnidade.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.tUnidade.IsOnlyInput = true;
			this.tUnidade.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.tUnidade.Name = "tUnidade";
			this.tUnidade.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.tUnidade.TagName = "CFG_UNIDADE";
			this.tUnidade.Value = null;
			this.tUnidade.Visible = false;
			this.tUnidade.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.OcultoValueChanged);
			this.tUnidade.EndInit();
			// 
			// fpTrend
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(700D)), ((float)(440D)));
			this.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(224)), ((byte)(224)), ((byte)(224))));
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
			this.trendControl1,
			this.tRangeMin,
			this.tRangeMax,
			this.tHabHH,
			this.tHabH,
			this.tHabL,
			this.tHabLL,
			this.tUnidade,
			this.tCasas});
			this.Size = new System.Drawing.Size(700, 440);
			((System.ComponentModel.ISupportInitialize)(this.trendControl1)).EndInit();

		}
		private NxtControl.GuiFramework.TrendControl trendControl1;
		private NxtControl.GuiFramework.DrawnButton btn5m;
		private NxtControl.GuiFramework.DrawnButton btn30m;
		private NxtControl.GuiFramework.DrawnButton btn1h;
		private NxtControl.GuiFramework.DrawnButton btn8h;
		private System.HMI.Symbols.Base.Execute<ushort> tCasas;
		private System.HMI.Symbols.Base.TextBox<float> tRangeMin;
		private System.HMI.Symbols.Base.TextBox<float> tRangeMax;
		private System.HMI.Symbols.Base.CheckButton tHabHH;
		private System.HMI.Symbols.Base.CheckButton tHabH;
		private System.HMI.Symbols.Base.CheckButton tHabL;
		private System.HMI.Symbols.Base.CheckButton tHabLL;
		private System.HMI.Symbols.Base.Execute<string> tUnidade;
		#endregion
	}
}
