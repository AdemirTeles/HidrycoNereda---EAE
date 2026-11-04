/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 7/6/2026
 * Time: 9:37 AM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.EmergencyManagement
{
	/// <summary>
	/// Summary description for sData.
	/// </summary>
	partial class sDataR1
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary2 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary3 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary1 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary4 = new NxtControl.GuiFramework.PropertyDictionary();
			this.rectangle1 = new NxtControl.GuiFramework.Rectangle();
			this.freeText1 = new NxtControl.GuiFramework.FreeText();
			this.EmergencyON = new System.HMI.Symbols.Base.Led<bool>();
			this.freeText2 = new NxtControl.GuiFramework.FreeText();
			this.line1 = new NxtControl.GuiFramework.Line();
			this.StartFeedPositionR1 = new System.HMI.Symbols.Base.FreeText<short>();
			this.freeText3 = new NxtControl.GuiFramework.FreeText();
			this.CT_ReactorActual = new System.HMI.Symbols.Base.TimeLabel();
			this.ellipse1 = new NxtControl.GuiFramework.Ellipse();
			this.group1 = new NxtControl.GuiFramework.Group();
			this.freeText5 = new NxtControl.GuiFramework.FreeText();
			this.AerateTimeR1 = new System.HMI.Symbols.Base.TimeLabel();
			this.freeText6 = new NxtControl.GuiFramework.FreeText();
			this.MinutesSinceLastFeedR1 = new System.HMI.Symbols.Base.TimeLabel();
			this.freeText7 = new NxtControl.GuiFramework.FreeText();
			this.StartInterval = new System.HMI.Symbols.Base.TimeLabel();
			this.freeText8 = new NxtControl.GuiFramework.FreeText();
			this.iCT_Nominal = new System.HMI.Symbols.Base.TimeLabel();
			this.rectangle2 = new NxtControl.GuiFramework.Rectangle();
			this.rectangle3 = new NxtControl.GuiFramework.Rectangle();
			this.freeText9 = new NxtControl.GuiFramework.FreeText();
			this.line2 = new NxtControl.GuiFramework.Line();
			this.line3 = new NxtControl.GuiFramework.Line();
			this.line4 = new NxtControl.GuiFramework.Line();
			this.StartUpDelay = new SE.Nereda.Symbols.E_DELAY_V_D.sCounter2();
			this.rectangle4 = new NxtControl.GuiFramework.Rectangle();
			this.NextFeedHorizon = new SE.Nereda.Symbols.NextFeedHorizon.sNFHR11();
			this.line5 = new NxtControl.GuiFramework.Line();
			this.freeText4 = new NxtControl.GuiFramework.FreeText();
			this.MinutesSinceLastAerateR1 = new System.HMI.Symbols.Base.TimeLabel();
			this.freeText10 = new NxtControl.GuiFramework.FreeText();
			this.SettleTimeR1 = new System.HMI.Symbols.Base.TimeLabel();
			this.line6 = new NxtControl.GuiFramework.Line();
			this.line7 = new NxtControl.GuiFramework.Line();
			this.group2 = new NxtControl.GuiFramework.Group();
			// 
			// rectangle1
			// 
			this.rectangle1.Bounds = new NxtControl.Drawing.RectF(((float)(24D)), ((float)(24D)), ((float)(232D)), ((float)(544D)));
			this.rectangle1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("transparent"));
			this.rectangle1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle1.Name = "rectangle1";
			// 
			// freeText1
			// 
			this.freeText1.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText1.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.freeText1.Location = new NxtControl.Drawing.PointF(32D, 36D);
			this.freeText1.Name = "freeText1";
			this.freeText1.Text = "Emerg\u00eancia ativa :";
			// 
			// EmergencyON
			// 
			this.EmergencyON.BeginInit();
			this.EmergencyON.ColorFrame = new NxtControl.Drawing.Color(((byte)(114)), ((byte)(114)), ((byte)(114)));
			this.EmergencyON.DesignMatrix = new NxtControl.Drawing.Matrix2D(4.8333333333333339D, 0D, 0D, 1.5D, 213D, 44D);
			this.EmergencyON.FrameSize = 33F;
			this.EmergencyON.IsOnlyInput = true;
			this.EmergencyON.Name = "EmergencyON";
			propertyDictionary2.Add("Color", new NxtControl.Drawing.Color("LedFalseColor"));
			propertyDictionary3.Add("Color", new NxtControl.Drawing.Color("DevActive1"));
			this.EmergencyON.Ranges.Clear();
			this.EmergencyON.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(false, propertyDictionary2));
			this.EmergencyON.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(true, propertyDictionary3));
			propertyDictionary1.Add("Color", new NxtControl.Drawing.Color("LedFalseColor"));
			this.EmergencyON.Ranges.DefaultPropertyValues = propertyDictionary1;
			this.EmergencyON.TagName = "EmergencyON";
			this.EmergencyON.EndInit();
			// 
			// freeText2
			// 
			this.freeText2.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText2.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.freeText2.Location = new NxtControl.Drawing.PointF(32D, 96D);
			this.freeText2.Name = "freeText2";
			this.freeText2.Text = "Ordem alim. atual :";
			// 
			// line1
			// 
			this.line1.EndPoint = new NxtControl.Drawing.PointF(24D, 88D);
			this.line1.Name = "line1";
			this.line1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line1.StartPoint = new NxtControl.Drawing.PointF(256D, 88D);
			// 
			// StartFeedPositionR1
			// 
			this.StartFeedPositionR1.BeginInit();
			this.StartFeedPositionR1.DecimalPlacesCount = ((uint)(2u));
			this.StartFeedPositionR1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 190D, 95D);
			this.StartFeedPositionR1.Font = new NxtControl.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
			this.StartFeedPositionR1.IsOnlyInput = true;
			this.StartFeedPositionR1.Name = "StartFeedPositionR1";
			propertyDictionary4.Add("Text", "${Value}");
			propertyDictionary4.Add("TextColor", new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			this.StartFeedPositionR1.Ranges.DefaultPropertyValues = propertyDictionary4;
			this.StartFeedPositionR1.TagName = "StartFeedPositionR1";
			this.StartFeedPositionR1.TextAngle = 0F;
			this.StartFeedPositionR1.EndInit();
			// 
			// freeText3
			// 
			this.freeText3.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText3.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.freeText3.Location = new NxtControl.Drawing.PointF(32D, 330D);
			this.freeText3.Name = "freeText3";
			this.freeText3.Text = "Ciclo atual :";
			// 
			// CT_ReactorActual
			// 
			this.CT_ReactorActual.BeginInit();
			this.CT_ReactorActual.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.CT_ReactorActual.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.48D, 0D, 0D, 1D, 184D, 328D);
			this.CT_ReactorActual.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.CT_ReactorActual.FontScale = false;
			this.CT_ReactorActual.IsOnlyInput = true;
			this.CT_ReactorActual.Name = "CT_ReactorActual";
			this.CT_ReactorActual.Pen = new NxtControl.Drawing.Pen("LabelPen");
			this.CT_ReactorActual.TagName = "CT_ReactorActual";
			this.CT_ReactorActual.TextColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.CT_ReactorActual.EndInit();
			// 
			// ellipse1
			// 
			this.ellipse1.Bounds = new NxtControl.Drawing.RectF(((float)(189D)), ((float)(36D)), ((float)(48D)), ((float)(16D)));
			this.ellipse1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("transparent"));
			this.ellipse1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.ellipse1.Name = "ellipse1";
			this.ellipse1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(230)), ((byte)(230)), ((byte)(230))), 2F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// group1
			// 
			this.group1.BeginInit();
			this.group1.Name = "group1";
			this.group1.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.EmergencyON,
			this.ellipse1});
			this.group1.EndInit();
			// 
			// freeText5
			// 
			this.freeText5.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText5.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.freeText5.Location = new NxtControl.Drawing.PointF(32D, 410D);
			this.freeText5.Name = "freeText5";
			this.freeText5.Text = "Aera\u00e7\u00e3o (S5) :";
			// 
			// AerateTimeR1
			// 
			this.AerateTimeR1.BeginInit();
			this.AerateTimeR1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.AerateTimeR1.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.48D, 0D, 0D, 1D, 184D, 408D);
			this.AerateTimeR1.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.AerateTimeR1.FontScale = false;
			this.AerateTimeR1.IsOnlyInput = true;
			this.AerateTimeR1.Name = "AerateTimeR1";
			this.AerateTimeR1.Pen = new NxtControl.Drawing.Pen("LabelPen");
			this.AerateTimeR1.TagName = "AerateTimeR1";
			this.AerateTimeR1.TextColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.AerateTimeR1.EndInit();
			// 
			// freeText6
			// 
			this.freeText6.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText6.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.freeText6.Location = new NxtControl.Drawing.PointF(32D, 128D);
			this.freeText6.Name = "freeText6";
			this.freeText6.Text = "Desde in\u00edcio alim. :";
			// 
			// MinutesSinceLastFeedR1
			// 
			this.MinutesSinceLastFeedR1.BeginInit();
			this.MinutesSinceLastFeedR1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.MinutesSinceLastFeedR1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1.44D, 0D, 0D, 1D, 32D, 152D);
			this.MinutesSinceLastFeedR1.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.MinutesSinceLastFeedR1.FontScale = false;
			this.MinutesSinceLastFeedR1.IsOnlyInput = true;
			this.MinutesSinceLastFeedR1.Name = "MinutesSinceLastFeedR1";
			this.MinutesSinceLastFeedR1.Pen = new NxtControl.Drawing.Pen("LabelPen");
			this.MinutesSinceLastFeedR1.TagName = "MinutesSinceLastFeedR1";
			this.MinutesSinceLastFeedR1.TextColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.MinutesSinceLastFeedR1.EndInit();
			// 
			// freeText7
			// 
			this.freeText7.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText7.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.freeText7.Location = new NxtControl.Drawing.PointF(32D, 250D);
			this.freeText7.Name = "freeText7";
			this.freeText7.Text = "Intervalo alim. :";
			// 
			// StartInterval
			// 
			this.StartInterval.BeginInit();
			this.StartInterval.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.StartInterval.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.48D, 0D, 0D, 1D, 184D, 248D);
			this.StartInterval.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.StartInterval.FontScale = false;
			this.StartInterval.IsOnlyInput = true;
			this.StartInterval.Name = "StartInterval";
			this.StartInterval.Pen = new NxtControl.Drawing.Pen("LabelPen");
			this.StartInterval.TagName = "FeedInterval";
			this.StartInterval.TextColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.StartInterval.EndInit();
			// 
			// freeText8
			// 
			this.freeText8.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText8.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.freeText8.Location = new NxtControl.Drawing.PointF(32D, 290D);
			this.freeText8.Name = "freeText8";
			this.freeText8.Text = "Ciclo nominal :";
			// 
			// iCT_Nominal
			// 
			this.iCT_Nominal.BeginInit();
			this.iCT_Nominal.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.iCT_Nominal.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.48D, 0D, 0D, 1D, 184D, 288D);
			this.iCT_Nominal.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.iCT_Nominal.FontScale = false;
			this.iCT_Nominal.IsOnlyInput = true;
			this.iCT_Nominal.Name = "iCT_Nominal";
			this.iCT_Nominal.Pen = new NxtControl.Drawing.Pen("LabelPen");
			this.iCT_Nominal.TagName = "iCT_Nominal";
			this.iCT_Nominal.TextColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.iCT_Nominal.EndInit();
			// 
			// rectangle2
			// 
			this.rectangle2.Bounds = new NxtControl.Drawing.RectF(((float)(24D)), ((float)(406D)), ((float)(232D)), ((float)(26D)));
			this.rectangle2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(245)), ((byte)(245)), ((byte)(245))));
			this.rectangle2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle2.Name = "rectangle2";
			this.rectangle2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// rectangle3
			// 
			this.rectangle3.Bounds = new NxtControl.Drawing.RectF(((float)(24D)), ((float)(88D)), ((float)(232D)), ((float)(32D)));
			this.rectangle3.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(245)), ((byte)(245)), ((byte)(245))));
			this.rectangle3.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle3.Name = "rectangle3";
			this.rectangle3.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// freeText9
			// 
			this.freeText9.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText9.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.freeText9.Location = new NxtControl.Drawing.PointF(32D, 528D);
			this.freeText9.Name = "freeText9";
			this.freeText9.Text = "Atraso partida :";
			// 
			// line2
			// 
			this.line2.EndPoint = new NxtControl.Drawing.PointF(256D, 520D);
			this.line2.Name = "line2";
			this.line2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line2.StartPoint = new NxtControl.Drawing.PointF(24D, 520D);
			// 
			// line3
			// 
			this.line3.EndPoint = new NxtControl.Drawing.PointF(256D, 120D);
			this.line3.Name = "line3";
			this.line3.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line3.StartPoint = new NxtControl.Drawing.PointF(24D, 120D);
			// 
			// line4
			// 
			this.line4.EndPoint = new NxtControl.Drawing.PointF(256D, 232D);
			this.line4.Name = "line4";
			this.line4.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line4.StartPoint = new NxtControl.Drawing.PointF(24D, 232D);
			// 
			// StartUpDelay
			// 
			this.StartUpDelay.BeginInit();
			this.StartUpDelay.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 32D, 544D);
			this.StartUpDelay.Name = "StartUpDelay";
			this.StartUpDelay.SecurityToken = ((uint)(4294967295u));
			this.StartUpDelay.TagName = "StartUpDelay";
			this.StartUpDelay.EndInit();
			// 
			// rectangle4
			// 
			this.rectangle4.Bounds = new NxtControl.Drawing.RectF(((float)(24D)), ((float)(448D)), ((float)(232D)), ((float)(120D)));
			this.rectangle4.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(245)), ((byte)(245)), ((byte)(245))));
			this.rectangle4.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle4.Name = "rectangle4";
			this.rectangle4.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// NextFeedHorizon
			// 
			this.NextFeedHorizon.BeginInit();
			this.NextFeedHorizon.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 32D, 464D);
			this.NextFeedHorizon.Name = "NextFeedHorizon";
			this.NextFeedHorizon.SecurityToken = ((uint)(4294967295u));
			this.NextFeedHorizon.TagName = "NextFeedHorizon";
			this.NextFeedHorizon.EndInit();
			// 
			// line5
			// 
			this.line5.EndPoint = new NxtControl.Drawing.PointF(256D, 176D);
			this.line5.Name = "line5";
			this.line5.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line5.StartPoint = new NxtControl.Drawing.PointF(24D, 176D);
			// 
			// freeText4
			// 
			this.freeText4.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText4.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.freeText4.Location = new NxtControl.Drawing.PointF(32D, 184D);
			this.freeText4.Name = "freeText4";
			this.freeText4.Text = "Desde \u00faltima aera\u00e7\u00e3o :";
			// 
			// MinutesSinceLastAerateR1
			// 
			this.MinutesSinceLastAerateR1.BeginInit();
			this.MinutesSinceLastAerateR1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.MinutesSinceLastAerateR1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1.3866666666666667D, 0D, 0D, 1D, 32D, 208D);
			this.MinutesSinceLastAerateR1.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.MinutesSinceLastAerateR1.FontScale = false;
			this.MinutesSinceLastAerateR1.IsOnlyInput = true;
			this.MinutesSinceLastAerateR1.Name = "MinutesSinceLastAerateR1";
			this.MinutesSinceLastAerateR1.Pen = new NxtControl.Drawing.Pen("LabelPen");
			this.MinutesSinceLastAerateR1.TagName = "MinutesSinceLastAerateR1";
			this.MinutesSinceLastAerateR1.TextColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.MinutesSinceLastAerateR1.EndInit();
			// 
			// freeText10
			// 
			this.freeText10.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText10.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.freeText10.Location = new NxtControl.Drawing.PointF(32D, 370D);
			this.freeText10.Name = "freeText10";
			this.freeText10.Text = "Decanta\u00e7\u00e3o :";
			// 
			// SettleTimeR1
			// 
			this.SettleTimeR1.BeginInit();
			this.SettleTimeR1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.SettleTimeR1.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.48D, 0D, 0D, 1D, 184D, 368D);
			this.SettleTimeR1.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.SettleTimeR1.FontScale = false;
			this.SettleTimeR1.IsOnlyInput = true;
			this.SettleTimeR1.Name = "SettleTimeR1";
			this.SettleTimeR1.Pen = new NxtControl.Drawing.Pen("LabelPen");
			this.SettleTimeR1.TagName = "SettleTimeR1";
			this.SettleTimeR1.TextColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.SettleTimeR1.EndInit();
			// 
			// line6
			// 
			this.line6.EndPoint = new NxtControl.Drawing.PointF(256D, 64D);
			this.line6.Name = "line6";
			this.line6.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line6.StartPoint = new NxtControl.Drawing.PointF(24D, 64D);
			// 
			// line7
			// 
			this.line7.EndPoint = new NxtControl.Drawing.PointF(256D, 448D);
			this.line7.Name = "line7";
			this.line7.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line7.StartPoint = new NxtControl.Drawing.PointF(24D, 448D);
			// 
			// group2
			// 
			this.group2.BeginInit();
			this.group2.Name = "group2";
			this.group2.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.rectangle4,
			this.rectangle3,
			this.freeText1,
			this.line1,
			this.group1,
			this.freeText9,
			this.line2,
			this.line3,
			this.line4,
			this.StartUpDelay,
			this.freeText6,
			this.MinutesSinceLastFeedR1,
			this.freeText2,
			this.StartFeedPositionR1,
			this.NextFeedHorizon,
			this.line5,
			this.freeText4,
			this.MinutesSinceLastAerateR1,
			this.line6,
			this.line7,
			this.rectangle2,
			this.freeText7,
			this.StartInterval,
			this.freeText3,
			this.CT_ReactorActual,
			this.freeText8,
			this.iCT_Nominal,
			this.freeText5,
			this.AerateTimeR1,
			this.freeText10,
			this.SettleTimeR1});
			this.group2.EndInit();
			// 
			// sDataR1
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.group2,
			this.rectangle1});
			this.SymbolSize = new System.Drawing.Size(536, 688);

		}
		private NxtControl.GuiFramework.Rectangle rectangle1;
		private NxtControl.GuiFramework.FreeText freeText1;
		private System.HMI.Symbols.Base.Led<bool> EmergencyON;
		private NxtControl.GuiFramework.FreeText freeText2;
		private NxtControl.GuiFramework.Line line1;
		private System.HMI.Symbols.Base.FreeText<short> StartFeedPositionR1;
		private NxtControl.GuiFramework.FreeText freeText3;
		private System.HMI.Symbols.Base.TimeLabel CT_ReactorActual;
		private NxtControl.GuiFramework.Ellipse ellipse1;
		private NxtControl.GuiFramework.Group group1;
		private NxtControl.GuiFramework.FreeText freeText5;
		private System.HMI.Symbols.Base.TimeLabel AerateTimeR1;
		private NxtControl.GuiFramework.FreeText freeText6;
		private System.HMI.Symbols.Base.TimeLabel MinutesSinceLastFeedR1;
		private NxtControl.GuiFramework.FreeText freeText7;
		private System.HMI.Symbols.Base.TimeLabel StartInterval;
		private NxtControl.GuiFramework.FreeText freeText8;
		private System.HMI.Symbols.Base.TimeLabel iCT_Nominal;
		private NxtControl.GuiFramework.Rectangle rectangle2;
		private NxtControl.GuiFramework.Rectangle rectangle3;
		private SE.Nereda.Symbols.E_DELAY_V_D.sCounter2 StartUpDelay;
		private NxtControl.GuiFramework.FreeText freeText9;
		private NxtControl.GuiFramework.Line line2;
		private NxtControl.GuiFramework.Line line3;
		private NxtControl.GuiFramework.Line line4;
		private NxtControl.GuiFramework.Rectangle rectangle4;
		private SE.Nereda.Symbols.NextFeedHorizon.sNFHR11 NextFeedHorizon;
		private NxtControl.GuiFramework.Line line5;
		private NxtControl.GuiFramework.FreeText freeText4;
		private System.HMI.Symbols.Base.TimeLabel MinutesSinceLastAerateR1;
		private NxtControl.GuiFramework.FreeText freeText10;
		private System.HMI.Symbols.Base.TimeLabel SettleTimeR1;
		private NxtControl.GuiFramework.Line line6;
		private NxtControl.GuiFramework.Line line7;
		private NxtControl.GuiFramework.Group group2;
		#endregion
	}
}
