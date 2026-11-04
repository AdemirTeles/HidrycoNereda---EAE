/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 7/5/2026
 * Time: 5:48 PM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using NxtControl.GuiFramework;

namespace SE.Nereda.Faceplates.EmergencyManagement
{
	/// <summary>
	/// Summary description for fpEquations.
	/// </summary>
	partial class fpEquations
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.rectangle1 = new NxtControl.GuiFramework.Rectangle();
			this.freeText1 = new NxtControl.GuiFramework.FreeText();
			this.CT_ReactorActual = new System.HMI.Symbols.Base.TimeTextBox();
			this.NbrAvailableReactors = new System.HMI.Symbols.Base.TextBox<short>();
			this.freeText2 = new NxtControl.GuiFramework.FreeText();
			this.NbrTotalReactors = new System.HMI.Symbols.Base.TextBox<short>();
			this.iCT_Nominal = new System.HMI.Symbols.Base.TimeTextBox();
			this.freeText3 = new NxtControl.GuiFramework.FreeText();
			this.freeText4 = new NxtControl.GuiFramework.FreeText();
			this.rectangle3 = new NxtControl.GuiFramework.Rectangle();
			this.freeText5 = new NxtControl.GuiFramework.FreeText();
			this.StartInterval = new System.HMI.Symbols.Base.TimeTextBox();
			this.freeText6 = new NxtControl.GuiFramework.FreeText();
			this.NbrAvailableReactors_1 = new System.HMI.Symbols.Base.TextBox<short>();
			this.freeText7 = new NxtControl.GuiFramework.FreeText();
			this.CT_ReactorActual_1 = new System.HMI.Symbols.Base.TimeTextBox();
			this.rectangle2 = new NxtControl.GuiFramework.Rectangle();
			this.freeText8 = new NxtControl.GuiFramework.FreeText();
			this.freeText9 = new NxtControl.GuiFramework.FreeText();
			this.freeText10 = new NxtControl.GuiFramework.FreeText();
			this.SettleTimeR1 = new System.HMI.Symbols.Base.TimeTextBox();
			this.MinSettleTime = new System.HMI.Symbols.Base.TimeTextBox();
			this.MinutesSinceLastAerateR1 = new System.HMI.Symbols.Base.TimeTextBox();
			this.rectangle4 = new NxtControl.GuiFramework.Rectangle();
			this.freeText11 = new NxtControl.GuiFramework.FreeText();
			this.freeText12 = new NxtControl.GuiFramework.FreeText();
			this.freeText13 = new NxtControl.GuiFramework.FreeText();
			this.timeTextBox1 = new System.HMI.Symbols.Base.TimeTextBox();
			this.timeTextBox2 = new System.HMI.Symbols.Base.TimeTextBox();
			this.timeTextBox3 = new System.HMI.Symbols.Base.TimeTextBox();
			// 
			// rectangle1
			// 
			this.rectangle1.Bounds = new NxtControl.Drawing.RectF(((float)(8D)), ((float)(8D)), ((float)(592D)), ((float)(72D)));
			this.rectangle1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(245)), ((byte)(245)), ((byte)(245))));
			this.rectangle1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle1.Name = "rectangle1";
			// 
			// freeText1
			// 
			this.freeText1.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText1.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.freeText1.Location = new NxtControl.Drawing.PointF(24D, 16D);
			this.freeText1.Name = "freeText1";
			this.freeText1.Text = "CT reator atual   =   (N\u00ba reatores dispon\u00edveis   /   N\u00ba total de reatores)   *   C" +
	"T Nominal";
			// 
			// CT_ReactorActual
			// 
			this.CT_ReactorActual.BeginInit();
			this.CT_ReactorActual.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.8D, 0D, 0D, 1D, 24D, 40D);
			this.CT_ReactorActual.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.CT_ReactorActual.IsOnlyInput = true;
			this.CT_ReactorActual.MaximumTag = null;
			this.CT_ReactorActual.MinimumTag = null;
			this.CT_ReactorActual.Name = "CT_ReactorActual";
			this.CT_ReactorActual.TagName = "CT_ReactorActual";
			this.CT_ReactorActual.Value = new NxtControl.GuiFramework.Time(((long)(0)));
			this.CT_ReactorActual.EndInit();
			// 
			// NbrAvailableReactors
			// 
			this.NbrAvailableReactors.BeginInit();
			this.NbrAvailableReactors.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.96D, 0D, 0D, 1D, 176D, 40D);
			this.NbrAvailableReactors.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.NbrAvailableReactors.IsOnlyInput = true;
			this.NbrAvailableReactors.MaximumTag = null;
			this.NbrAvailableReactors.MinimumTag = null;
			this.NbrAvailableReactors.Name = "NbrAvailableReactors";
			this.NbrAvailableReactors.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.NbrAvailableReactors.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.NbrAvailableReactors.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.NbrAvailableReactors.TagName = "NbrAvailableReactors";
			this.NbrAvailableReactors.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.NbrAvailableReactors.Value = ((short)(0));
			this.NbrAvailableReactors.EndInit();
			// 
			// freeText2
			// 
			this.freeText2.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText2.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.freeText2.Location = new NxtControl.Drawing.PointF(154D, 45D);
			this.freeText2.Name = "freeText2";
			this.freeText2.Text = "=";
			// 
			// NbrTotalReactors
			// 
			this.NbrTotalReactors.BeginInit();
			this.NbrTotalReactors.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.8D, 0D, 0D, 1D, 352D, 40D);
			this.NbrTotalReactors.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.NbrTotalReactors.IsOnlyInput = true;
			this.NbrTotalReactors.MaximumTag = null;
			this.NbrTotalReactors.MinimumTag = null;
			this.NbrTotalReactors.Name = "NbrTotalReactors";
			this.NbrTotalReactors.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.NbrTotalReactors.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.NbrTotalReactors.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.NbrTotalReactors.TagName = "NbrTotalReactors";
			this.NbrTotalReactors.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.NbrTotalReactors.Value = ((short)(0));
			this.NbrTotalReactors.EndInit();
			// 
			// iCT_Nominal
			// 
			this.iCT_Nominal.BeginInit();
			this.iCT_Nominal.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.52D, 0D, 0D, 1D, 504D, 40D);
			this.iCT_Nominal.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.iCT_Nominal.IsOnlyInput = true;
			this.iCT_Nominal.MaximumTag = null;
			this.iCT_Nominal.MinimumTag = null;
			this.iCT_Nominal.Name = "iCT_Nominal";
			this.iCT_Nominal.TagName = "iCT_Nominal";
			this.iCT_Nominal.Value = new NxtControl.GuiFramework.Time(((long)(0)));
			this.iCT_Nominal.EndInit();
			// 
			// freeText3
			// 
			this.freeText3.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText3.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.freeText3.Location = new NxtControl.Drawing.PointF(332D, 44D);
			this.freeText3.Name = "freeText3";
			this.freeText3.Text = "/";
			// 
			// freeText4
			// 
			this.freeText4.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText4.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.freeText4.Location = new NxtControl.Drawing.PointF(482D, 44D);
			this.freeText4.Name = "freeText4";
			this.freeText4.Text = "x";
			// 
			// rectangle3
			// 
			this.rectangle3.Bounds = new NxtControl.Drawing.RectF(((float)(8D)), ((float)(88D)), ((float)(592D)), ((float)(72D)));
			this.rectangle3.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(245)), ((byte)(245)), ((byte)(245))));
			this.rectangle3.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle3.Name = "rectangle3";
			// 
			// freeText5
			// 
			this.freeText5.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText5.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.freeText5.Location = new NxtControl.Drawing.PointF(24D, 96D);
			this.freeText5.Name = "freeText5";
			this.freeText5.Text = "Intervalo   =   CT reator atual   /   N\u00ba reatores dispon\u00edveis";
			// 
			// StartInterval
			// 
			this.StartInterval.BeginInit();
			this.StartInterval.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.53333333333333333D, 0D, 0D, 1D, 16D, 120D);
			this.StartInterval.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.StartInterval.IsOnlyInput = true;
			this.StartInterval.MaximumTag = null;
			this.StartInterval.MinimumTag = null;
			this.StartInterval.Name = "StartInterval";
			this.StartInterval.TagName = "FeedInterval";
			this.StartInterval.Value = new NxtControl.GuiFramework.Time(((long)(0)));
			this.StartInterval.EndInit();
			// 
			// freeText6
			// 
			this.freeText6.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText6.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.freeText6.Location = new NxtControl.Drawing.PointF(114D, 125D);
			this.freeText6.Name = "freeText6";
			this.freeText6.Text = "=";
			// 
			// NbrAvailableReactors_1
			// 
			this.NbrAvailableReactors_1.BeginInit();
			this.NbrAvailableReactors_1.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.90666666666666673D, 0D, 0D, 1D, 288D, 120D);
			this.NbrAvailableReactors_1.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.NbrAvailableReactors_1.IsOnlyInput = true;
			this.NbrAvailableReactors_1.MaximumTag = null;
			this.NbrAvailableReactors_1.MinimumTag = null;
			this.NbrAvailableReactors_1.Name = "NbrAvailableReactors_1";
			this.NbrAvailableReactors_1.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.NbrAvailableReactors_1.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.NbrAvailableReactors_1.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.NbrAvailableReactors_1.TagName = "NbrAvailableReactors";
			this.NbrAvailableReactors_1.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.NbrAvailableReactors_1.Value = ((short)(0));
			this.NbrAvailableReactors_1.EndInit();
			// 
			// freeText7
			// 
			this.freeText7.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText7.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.freeText7.Location = new NxtControl.Drawing.PointF(268D, 124D);
			this.freeText7.Name = "freeText7";
			this.freeText7.Text = "/";
			// 
			// CT_ReactorActual_1
			// 
			this.CT_ReactorActual_1.BeginInit();
			this.CT_ReactorActual_1.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.8D, 0D, 0D, 1D, 136D, 120D);
			this.CT_ReactorActual_1.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.CT_ReactorActual_1.IsOnlyInput = true;
			this.CT_ReactorActual_1.MaximumTag = null;
			this.CT_ReactorActual_1.MinimumTag = null;
			this.CT_ReactorActual_1.Name = "CT_ReactorActual_1";
			this.CT_ReactorActual_1.TagName = "CT_ReactorActual";
			this.CT_ReactorActual_1.Value = new NxtControl.GuiFramework.Time(((long)(0)));
			this.CT_ReactorActual_1.EndInit();
			// 
			// rectangle2
			// 
			this.rectangle2.Bounds = new NxtControl.Drawing.RectF(((float)(8D)), ((float)(168D)), ((float)(592D)), ((float)(72D)));
			this.rectangle2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(245)), ((byte)(245)), ((byte)(245))));
			this.rectangle2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle2.Name = "rectangle2";
			// 
			// freeText8
			// 
			this.freeText8.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText8.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.freeText8.Location = new NxtControl.Drawing.PointF(24D, 176D);
			this.freeText8.Name = "freeText8";
			this.freeText8.Text = "Decanta\u00e7\u00e3o R1   =   Tempo m\u00edn. decanta\u00e7\u00e3o  -   Tempo desde in\u00edcio aera\u00e7\u00e3o R1";
			// 
			// freeText9
			// 
			this.freeText9.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText9.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.freeText9.Location = new NxtControl.Drawing.PointF(130D, 205D);
			this.freeText9.Name = "freeText9";
			this.freeText9.Text = "=";
			// 
			// freeText10
			// 
			this.freeText10.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText10.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.freeText10.Location = new NxtControl.Drawing.PointF(292D, 204D);
			this.freeText10.Name = "freeText10";
			this.freeText10.Text = "-";
			// 
			// SettleTimeR1
			// 
			this.SettleTimeR1.BeginInit();
			this.SettleTimeR1.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.6399999999999999D, 0D, 0D, 1D, 24D, 200D);
			this.SettleTimeR1.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.SettleTimeR1.IsOnlyInput = true;
			this.SettleTimeR1.MaximumTag = null;
			this.SettleTimeR1.MinimumTag = null;
			this.SettleTimeR1.Name = "SettleTimeR1";
			this.SettleTimeR1.TagName = "SettleTimeR1";
			this.SettleTimeR1.Value = new NxtControl.GuiFramework.Time(((long)(0)));
			this.SettleTimeR1.EndInit();
			// 
			// MinSettleTime
			// 
			this.MinSettleTime.BeginInit();
			this.MinSettleTime.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.85333333333333339D, 0D, 0D, 1D, 152D, 200D);
			this.MinSettleTime.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.MinSettleTime.MaximumTag = null;
			this.MinSettleTime.MinimumTag = null;
			this.MinSettleTime.Name = "MinSettleTime";
			this.MinSettleTime.TagName = "MinSettleTime";
			this.MinSettleTime.Value = new NxtControl.GuiFramework.Time(((long)(0)));
			this.MinSettleTime.EndInit();
			// 
			// MinutesSinceLastAerateR1
			// 
			this.MinutesSinceLastAerateR1.BeginInit();
			this.MinutesSinceLastAerateR1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 312D, 200D);
			this.MinutesSinceLastAerateR1.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.MinutesSinceLastAerateR1.IsOnlyInput = true;
			this.MinutesSinceLastAerateR1.MaximumTag = null;
			this.MinutesSinceLastAerateR1.MinimumTag = null;
			this.MinutesSinceLastAerateR1.Name = "MinutesSinceLastAerateR1";
			this.MinutesSinceLastAerateR1.TagName = "MinutesSinceLastAerateR1";
			this.MinutesSinceLastAerateR1.Value = new NxtControl.GuiFramework.Time(((long)(0)));
			this.MinutesSinceLastAerateR1.EndInit();
			// 
			// rectangle4
			// 
			this.rectangle4.Bounds = new NxtControl.Drawing.RectF(((float)(8D)), ((float)(248D)), ((float)(592D)), ((float)(72D)));
			this.rectangle4.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(245)), ((byte)(245)), ((byte)(245))));
			this.rectangle4.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle4.Name = "rectangle4";
			// 
			// freeText11
			// 
			this.freeText11.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText11.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.freeText11.Location = new NxtControl.Drawing.PointF(24D, 256D);
			this.freeText11.Name = "freeText11";
			this.freeText11.Text = "Decanta\u00e7\u00e3o R2   =   Tempo m\u00edn. decanta\u00e7\u00e3o  -   Tempo desde in\u00edcio aera\u00e7\u00e3o R2";
			// 
			// freeText12
			// 
			this.freeText12.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText12.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.freeText12.Location = new NxtControl.Drawing.PointF(130D, 285D);
			this.freeText12.Name = "freeText12";
			this.freeText12.Text = "=";
			// 
			// freeText13
			// 
			this.freeText13.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText13.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.freeText13.Location = new NxtControl.Drawing.PointF(292D, 284D);
			this.freeText13.Name = "freeText13";
			this.freeText13.Text = "-";
			// 
			// timeTextBox1
			// 
			this.timeTextBox1.BeginInit();
			this.timeTextBox1.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.6399999999999999D, 0D, 0D, 1D, 24D, 280D);
			this.timeTextBox1.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.timeTextBox1.IsOnlyInput = true;
			this.timeTextBox1.MaximumTag = null;
			this.timeTextBox1.MinimumTag = null;
			this.timeTextBox1.Name = "timeTextBox1";
			this.timeTextBox1.TagName = "SettleTimeR2";
			this.timeTextBox1.Value = new NxtControl.GuiFramework.Time(((long)(0)));
			this.timeTextBox1.EndInit();
			// 
			// timeTextBox2
			// 
			this.timeTextBox2.BeginInit();
			this.timeTextBox2.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.85333333333333339D, 0D, 0D, 1D, 152D, 280D);
			this.timeTextBox2.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.timeTextBox2.MaximumTag = null;
			this.timeTextBox2.MinimumTag = null;
			this.timeTextBox2.Name = "timeTextBox2";
			this.timeTextBox2.TagName = "MinSettleTime";
			this.timeTextBox2.Value = new NxtControl.GuiFramework.Time(((long)(0)));
			this.timeTextBox2.EndInit();
			// 
			// timeTextBox3
			// 
			this.timeTextBox3.BeginInit();
			this.timeTextBox3.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 312D, 280D);
			this.timeTextBox3.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.timeTextBox3.IsOnlyInput = true;
			this.timeTextBox3.MaximumTag = null;
			this.timeTextBox3.MinimumTag = null;
			this.timeTextBox3.Name = "timeTextBox3";
			this.timeTextBox3.TagName = "MinutesSinceLastAerateR2";
			this.timeTextBox3.Value = new NxtControl.GuiFramework.Time(((long)(0)));
			this.timeTextBox3.EndInit();
			// 
			// fpEquations
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(608D)), ((float)(328D)));
			this.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(154)), ((byte)(154)), ((byte)(154))));
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.rectangle1,
			this.rectangle3,
			this.freeText1,
			this.CT_ReactorActual,
			this.NbrAvailableReactors,
			this.freeText2,
			this.NbrTotalReactors,
			this.iCT_Nominal,
			this.freeText3,
			this.freeText4,
			this.freeText5,
			this.StartInterval,
			this.freeText6,
			this.NbrAvailableReactors_1,
			this.freeText7,
			this.CT_ReactorActual_1,
			this.rectangle2,
			this.freeText8,
			this.freeText9,
			this.freeText10,
			this.SettleTimeR1,
			this.MinSettleTime,
			this.MinutesSinceLastAerateR1,
			this.rectangle4,
			this.freeText11,
			this.freeText12,
			this.freeText13,
			this.timeTextBox1,
			this.timeTextBox2,
			this.timeTextBox3});
			this.Size = new System.Drawing.Size(608, 328);
			this.Title = "Emergency Management Equations";

		}
		private NxtControl.GuiFramework.Rectangle rectangle1;
		private NxtControl.GuiFramework.FreeText freeText1;
		private System.HMI.Symbols.Base.TimeTextBox CT_ReactorActual;
		private System.HMI.Symbols.Base.TextBox<short> NbrAvailableReactors;
		private NxtControl.GuiFramework.FreeText freeText2;
		private System.HMI.Symbols.Base.TextBox<short> NbrTotalReactors;
		private System.HMI.Symbols.Base.TimeTextBox iCT_Nominal;
		private NxtControl.GuiFramework.FreeText freeText3;
		private NxtControl.GuiFramework.FreeText freeText4;
		private NxtControl.GuiFramework.Rectangle rectangle3;
		private NxtControl.GuiFramework.FreeText freeText5;
		private System.HMI.Symbols.Base.TimeTextBox StartInterval;
		private System.HMI.Symbols.Base.TimeTextBox CT_ReactorActual_1;
		private NxtControl.GuiFramework.FreeText freeText6;
		private System.HMI.Symbols.Base.TextBox<short> NbrAvailableReactors_1;
		private NxtControl.GuiFramework.FreeText freeText7;
		private NxtControl.GuiFramework.Rectangle rectangle2;
		private NxtControl.GuiFramework.FreeText freeText8;
		private NxtControl.GuiFramework.FreeText freeText9;
		private NxtControl.GuiFramework.FreeText freeText10;
		private System.HMI.Symbols.Base.TimeTextBox SettleTimeR1;
		private System.HMI.Symbols.Base.TimeTextBox MinSettleTime;
		private System.HMI.Symbols.Base.TimeTextBox MinutesSinceLastAerateR1;
		private NxtControl.GuiFramework.Rectangle rectangle4;
		private NxtControl.GuiFramework.FreeText freeText11;
		private NxtControl.GuiFramework.FreeText freeText12;
		private NxtControl.GuiFramework.FreeText freeText13;
		private System.HMI.Symbols.Base.TimeTextBox timeTextBox1;
		private System.HMI.Symbols.Base.TimeTextBox timeTextBox2;
		private System.HMI.Symbols.Base.TimeTextBox timeTextBox3;
		#endregion
	}
}
