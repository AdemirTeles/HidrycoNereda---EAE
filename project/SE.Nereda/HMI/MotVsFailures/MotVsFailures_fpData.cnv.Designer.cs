/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 8/5/2026
 * Time: 10:25 AM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using NxtControl.GuiFramework;

namespace SE.Nereda.Faceplates.MotVsFailures
{
	/// <summary>
	/// Summary description for fpData.
	/// </summary>
	partial class fpData
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
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary5 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary6 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary4 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary8 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary9 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary7 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary11 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary12 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary10 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary14 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary15 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary13 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary17 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary18 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary16 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary19 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary20 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary21 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary22 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary23 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary24 = new NxtControl.GuiFramework.PropertyDictionary();
			this.rectangle2 = new NxtControl.GuiFramework.Rectangle();
			this.freeText1 = new NxtControl.GuiFramework.FreeText();
			this.freeText2 = new NxtControl.GuiFramework.FreeText();
			this.freeText3 = new NxtControl.GuiFramework.FreeText();
			this.rectangle1 = new NxtControl.GuiFramework.Rectangle();
			this.line1 = new NxtControl.GuiFramework.Line();
			this.line2 = new NxtControl.GuiFramework.Line();
			this.freeText4 = new NxtControl.GuiFramework.FreeText();
			this.freeText5 = new NxtControl.GuiFramework.FreeText();
			this.freeText6 = new NxtControl.GuiFramework.FreeText();
			this.freeText7 = new NxtControl.GuiFramework.FreeText();
			this.freeText8 = new NxtControl.GuiFramework.FreeText();
			this.freeText9 = new NxtControl.GuiFramework.FreeText();
			this.Failure1 = new System.HMI.Symbols.Base.FreeText<bool>();
			this.line3 = new NxtControl.GuiFramework.Line();
			this.line4 = new NxtControl.GuiFramework.Line();
			this.line5 = new NxtControl.GuiFramework.Line();
			this.line6 = new NxtControl.GuiFramework.Line();
			this.line7 = new NxtControl.GuiFramework.Line();
			this.Failure2 = new System.HMI.Symbols.Base.FreeText<bool>();
			this.Failure3 = new System.HMI.Symbols.Base.FreeText<bool>();
			this.Failure4 = new System.HMI.Symbols.Base.FreeText<bool>();
			this.Failure5 = new System.HMI.Symbols.Base.FreeText<bool>();
			this.Failure6 = new System.HMI.Symbols.Base.FreeText<bool>();
			this.CountFailure1 = new System.HMI.Symbols.Base.FreeText<ushort>();
			this.CountFailure2 = new System.HMI.Symbols.Base.FreeText<ushort>();
			this.CountFailure3 = new System.HMI.Symbols.Base.FreeText<ushort>();
			this.CountFailure4 = new System.HMI.Symbols.Base.FreeText<ushort>();
			this.CountFailure5 = new System.HMI.Symbols.Base.FreeText<ushort>();
			this.CountFailure6 = new System.HMI.Symbols.Base.FreeText<ushort>();
			// 
			// rectangle2
			// 
			this.rectangle2.Bounds = new NxtControl.Drawing.RectF(((float)(8D)), ((float)(40D)), ((float)(408D)), ((float)(192D)));
			this.rectangle2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(250)), ((byte)(250)), ((byte)(250))));
			this.rectangle2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle2.Name = "rectangle2";
			// 
			// freeText1
			// 
			this.freeText1.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText1.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.freeText1.Location = new NxtControl.Drawing.PointF(16D, 16D);
			this.freeText1.Name = "freeText1";
			this.freeText1.Text = "Failure Name";
			// 
			// freeText2
			// 
			this.freeText2.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText2.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.freeText2.Location = new NxtControl.Drawing.PointF(216D, 16D);
			this.freeText2.Name = "freeText2";
			this.freeText2.Text = "Failure Present";
			// 
			// freeText3
			// 
			this.freeText3.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText3.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.freeText3.Location = new NxtControl.Drawing.PointF(328D, 16D);
			this.freeText3.Name = "freeText3";
			this.freeText3.Text = "Failure Count";
			// 
			// rectangle1
			// 
			this.rectangle1.Bounds = new NxtControl.Drawing.RectF(((float)(8D)), ((float)(8D)), ((float)(408D)), ((float)(32D)));
			this.rectangle1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(210)), ((byte)(210)), ((byte)(210))));
			this.rectangle1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle1.Name = "rectangle1";
			// 
			// line1
			// 
			this.line1.EndPoint = new NxtControl.Drawing.PointF(208D, 232D);
			this.line1.Name = "line1";
			this.line1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line1.StartPoint = new NxtControl.Drawing.PointF(208D, 8D);
			// 
			// line2
			// 
			this.line2.EndPoint = new NxtControl.Drawing.PointF(320D, 232D);
			this.line2.Name = "line2";
			this.line2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line2.StartPoint = new NxtControl.Drawing.PointF(320D, 8D);
			// 
			// freeText4
			// 
			this.freeText4.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText4.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.freeText4.Location = new NxtControl.Drawing.PointF(16D, 48D);
			this.freeText4.Name = "freeText4";
			this.freeText4.Text = "Drive Failure";
			// 
			// freeText5
			// 
			this.freeText5.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText5.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.freeText5.Location = new NxtControl.Drawing.PointF(16D, 80D);
			this.freeText5.Name = "freeText5";
			this.freeText5.Text = "Electric Circuit Failure";
			// 
			// freeText6
			// 
			this.freeText6.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText6.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.freeText6.Location = new NxtControl.Drawing.PointF(16D, 112D);
			this.freeText6.Name = "freeText6";
			this.freeText6.Text = "Frequency Inverter Failure";
			// 
			// freeText7
			// 
			this.freeText7.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText7.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.freeText7.Location = new NxtControl.Drawing.PointF(16D, 144D);
			this.freeText7.Name = "freeText7";
			this.freeText7.Text = "Power Failure";
			// 
			// freeText8
			// 
			this.freeText8.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText8.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.freeText8.Location = new NxtControl.Drawing.PointF(16D, 176D);
			this.freeText8.Name = "freeText8";
			this.freeText8.Text = "TRIP Failure";
			// 
			// freeText9
			// 
			this.freeText9.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText9.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.freeText9.Location = new NxtControl.Drawing.PointF(16D, 208D);
			this.freeText9.Name = "freeText9";
			this.freeText9.Text = "Moisture Detection Pump MS";
			// 
			// Failure1
			// 
			this.Failure1.BeginInit();
			this.Failure1.DecimalPlacesCount = ((uint)(2u));
			this.Failure1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 246D, 48D);
			this.Failure1.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.Failure1.IsOnlyInput = true;
			this.Failure1.Name = "Failure1";
			propertyDictionary2.Add("Text", "false");
			propertyDictionary2.Add("TextColor", new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			propertyDictionary3.Add("Text", "true");
			propertyDictionary3.Add("TextColor", new NxtControl.Drawing.Color(((byte)(255)), ((byte)(0)), ((byte)(0))));
			this.Failure1.Ranges.Clear();
			this.Failure1.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(false, propertyDictionary2));
			this.Failure1.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(true, propertyDictionary3));
			propertyDictionary1.Add("Text", "false");
			propertyDictionary1.Add("TextColor", new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			this.Failure1.Ranges.DefaultPropertyValues = propertyDictionary1;
			this.Failure1.TagName = "Failure1";
			this.Failure1.TextAngle = 0F;
			this.Failure1.EndInit();
			// 
			// line3
			// 
			this.line3.EndPoint = new NxtControl.Drawing.PointF(416D, 72D);
			this.line3.Name = "line3";
			this.line3.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line3.StartPoint = new NxtControl.Drawing.PointF(8D, 72D);
			// 
			// line4
			// 
			this.line4.EndPoint = new NxtControl.Drawing.PointF(416D, 104D);
			this.line4.Name = "line4";
			this.line4.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line4.StartPoint = new NxtControl.Drawing.PointF(8D, 104D);
			// 
			// line5
			// 
			this.line5.EndPoint = new NxtControl.Drawing.PointF(416D, 136D);
			this.line5.Name = "line5";
			this.line5.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line5.StartPoint = new NxtControl.Drawing.PointF(8D, 136D);
			// 
			// line6
			// 
			this.line6.EndPoint = new NxtControl.Drawing.PointF(416D, 168D);
			this.line6.Name = "line6";
			this.line6.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line6.StartPoint = new NxtControl.Drawing.PointF(8D, 168D);
			// 
			// line7
			// 
			this.line7.EndPoint = new NxtControl.Drawing.PointF(416D, 200D);
			this.line7.Name = "line7";
			this.line7.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line7.StartPoint = new NxtControl.Drawing.PointF(8D, 200D);
			// 
			// Failure2
			// 
			this.Failure2.BeginInit();
			this.Failure2.DecimalPlacesCount = ((uint)(2u));
			this.Failure2.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 246D, 80D);
			this.Failure2.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.Failure2.IsOnlyInput = true;
			this.Failure2.Name = "Failure2";
			propertyDictionary5.Add("Text", "false");
			propertyDictionary5.Add("TextColor", new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			propertyDictionary6.Add("Text", "true");
			propertyDictionary6.Add("TextColor", new NxtControl.Drawing.Color(((byte)(255)), ((byte)(0)), ((byte)(0))));
			this.Failure2.Ranges.Clear();
			this.Failure2.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(false, propertyDictionary5));
			this.Failure2.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(true, propertyDictionary6));
			propertyDictionary4.Add("Text", "false");
			propertyDictionary4.Add("TextColor", new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			this.Failure2.Ranges.DefaultPropertyValues = propertyDictionary4;
			this.Failure2.TagName = "Failure2";
			this.Failure2.TextAngle = 0F;
			this.Failure2.EndInit();
			// 
			// Failure3
			// 
			this.Failure3.BeginInit();
			this.Failure3.DecimalPlacesCount = ((uint)(2u));
			this.Failure3.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 248D, 112D);
			this.Failure3.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.Failure3.IsOnlyInput = true;
			this.Failure3.Name = "Failure3";
			propertyDictionary8.Add("Text", "false");
			propertyDictionary8.Add("TextColor", new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			propertyDictionary9.Add("Text", "true");
			propertyDictionary9.Add("TextColor", new NxtControl.Drawing.Color(((byte)(255)), ((byte)(0)), ((byte)(0))));
			this.Failure3.Ranges.Clear();
			this.Failure3.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(false, propertyDictionary8));
			this.Failure3.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(true, propertyDictionary9));
			propertyDictionary7.Add("Text", "false");
			propertyDictionary7.Add("TextColor", new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			this.Failure3.Ranges.DefaultPropertyValues = propertyDictionary7;
			this.Failure3.TagName = "Failure3";
			this.Failure3.TextAngle = 0F;
			this.Failure3.EndInit();
			// 
			// Failure4
			// 
			this.Failure4.BeginInit();
			this.Failure4.DecimalPlacesCount = ((uint)(2u));
			this.Failure4.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 246D, 144D);
			this.Failure4.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.Failure4.IsOnlyInput = true;
			this.Failure4.Name = "Failure4";
			propertyDictionary11.Add("Text", "false");
			propertyDictionary11.Add("TextColor", new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			propertyDictionary12.Add("Text", "true");
			propertyDictionary12.Add("TextColor", new NxtControl.Drawing.Color(((byte)(255)), ((byte)(0)), ((byte)(0))));
			this.Failure4.Ranges.Clear();
			this.Failure4.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(false, propertyDictionary11));
			this.Failure4.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(true, propertyDictionary12));
			propertyDictionary10.Add("Text", "false");
			propertyDictionary10.Add("TextColor", new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			this.Failure4.Ranges.DefaultPropertyValues = propertyDictionary10;
			this.Failure4.TagName = "Failure4";
			this.Failure4.TextAngle = 0F;
			this.Failure4.EndInit();
			// 
			// Failure5
			// 
			this.Failure5.BeginInit();
			this.Failure5.DecimalPlacesCount = ((uint)(2u));
			this.Failure5.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 246D, 176D);
			this.Failure5.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.Failure5.IsOnlyInput = true;
			this.Failure5.Name = "Failure5";
			propertyDictionary14.Add("Text", "false");
			propertyDictionary14.Add("TextColor", new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			propertyDictionary15.Add("Text", "true");
			propertyDictionary15.Add("TextColor", new NxtControl.Drawing.Color(((byte)(255)), ((byte)(0)), ((byte)(0))));
			this.Failure5.Ranges.Clear();
			this.Failure5.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(false, propertyDictionary14));
			this.Failure5.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(true, propertyDictionary15));
			propertyDictionary13.Add("Text", "false");
			propertyDictionary13.Add("TextColor", new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			this.Failure5.Ranges.DefaultPropertyValues = propertyDictionary13;
			this.Failure5.TagName = "Failure5";
			this.Failure5.TextAngle = 0F;
			this.Failure5.EndInit();
			// 
			// Failure6
			// 
			this.Failure6.BeginInit();
			this.Failure6.DecimalPlacesCount = ((uint)(2u));
			this.Failure6.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 246D, 208D);
			this.Failure6.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.Failure6.IsOnlyInput = true;
			this.Failure6.Name = "Failure6";
			propertyDictionary17.Add("Text", "false");
			propertyDictionary17.Add("TextColor", new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			propertyDictionary18.Add("Text", "true");
			propertyDictionary18.Add("TextColor", new NxtControl.Drawing.Color(((byte)(255)), ((byte)(0)), ((byte)(0))));
			this.Failure6.Ranges.Clear();
			this.Failure6.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(false, propertyDictionary17));
			this.Failure6.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(true, propertyDictionary18));
			propertyDictionary16.Add("Text", "false");
			propertyDictionary16.Add("TextColor", new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			this.Failure6.Ranges.DefaultPropertyValues = propertyDictionary16;
			this.Failure6.TagName = "Failure6";
			this.Failure6.TextAngle = 0F;
			this.Failure6.EndInit();
			// 
			// CountFailure1
			// 
			this.CountFailure1.BeginInit();
			this.CountFailure1.DecimalPlacesCount = ((uint)(2u));
			this.CountFailure1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 332D, 48D);
			this.CountFailure1.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.CountFailure1.IsOnlyInput = true;
			this.CountFailure1.Name = "CountFailure1";
			propertyDictionary19.Add("Text", "${Value}");
			propertyDictionary19.Add("TextColor", new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			this.CountFailure1.Ranges.DefaultPropertyValues = propertyDictionary19;
			this.CountFailure1.TagName = "CountFailure1";
			this.CountFailure1.TextAngle = 0F;
			this.CountFailure1.EndInit();
			// 
			// CountFailure2
			// 
			this.CountFailure2.BeginInit();
			this.CountFailure2.DecimalPlacesCount = ((uint)(2u));
			this.CountFailure2.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 332D, 78D);
			this.CountFailure2.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.CountFailure2.IsOnlyInput = true;
			this.CountFailure2.Name = "CountFailure2";
			propertyDictionary20.Add("Text", "${Value}");
			propertyDictionary20.Add("TextColor", new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			this.CountFailure2.Ranges.DefaultPropertyValues = propertyDictionary20;
			this.CountFailure2.TagName = "CountFailure2";
			this.CountFailure2.TextAngle = 0F;
			this.CountFailure2.EndInit();
			// 
			// CountFailure3
			// 
			this.CountFailure3.BeginInit();
			this.CountFailure3.DecimalPlacesCount = ((uint)(2u));
			this.CountFailure3.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 332D, 112D);
			this.CountFailure3.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.CountFailure3.IsOnlyInput = true;
			this.CountFailure3.Name = "CountFailure3";
			propertyDictionary21.Add("Text", "${Value}");
			propertyDictionary21.Add("TextColor", new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			this.CountFailure3.Ranges.DefaultPropertyValues = propertyDictionary21;
			this.CountFailure3.TagName = "CountFailure3";
			this.CountFailure3.TextAngle = 0F;
			this.CountFailure3.EndInit();
			// 
			// CountFailure4
			// 
			this.CountFailure4.BeginInit();
			this.CountFailure4.DecimalPlacesCount = ((uint)(2u));
			this.CountFailure4.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 332D, 144D);
			this.CountFailure4.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.CountFailure4.IsOnlyInput = true;
			this.CountFailure4.Name = "CountFailure4";
			propertyDictionary22.Add("Text", "${Value}");
			propertyDictionary22.Add("TextColor", new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			this.CountFailure4.Ranges.DefaultPropertyValues = propertyDictionary22;
			this.CountFailure4.TagName = "CountFailure4";
			this.CountFailure4.TextAngle = 0F;
			this.CountFailure4.EndInit();
			// 
			// CountFailure5
			// 
			this.CountFailure5.BeginInit();
			this.CountFailure5.DecimalPlacesCount = ((uint)(2u));
			this.CountFailure5.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 332D, 176D);
			this.CountFailure5.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.CountFailure5.IsOnlyInput = true;
			this.CountFailure5.Name = "CountFailure5";
			propertyDictionary23.Add("Text", "${Value}");
			propertyDictionary23.Add("TextColor", new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			this.CountFailure5.Ranges.DefaultPropertyValues = propertyDictionary23;
			this.CountFailure5.TagName = "CountFailure5";
			this.CountFailure5.TextAngle = 0F;
			this.CountFailure5.EndInit();
			// 
			// CountFailure6
			// 
			this.CountFailure6.BeginInit();
			this.CountFailure6.DecimalPlacesCount = ((uint)(2u));
			this.CountFailure6.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 332D, 210D);
			this.CountFailure6.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.CountFailure6.IsOnlyInput = true;
			this.CountFailure6.Name = "CountFailure6";
			propertyDictionary24.Add("Text", "${Value}");
			propertyDictionary24.Add("TextColor", new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			this.CountFailure6.Ranges.DefaultPropertyValues = propertyDictionary24;
			this.CountFailure6.TagName = "CountFailure6";
			this.CountFailure6.TextAngle = 0F;
			this.CountFailure6.EndInit();
			// 
			// fpData
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(424D)), ((float)(240D)));
			this.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(154)), ((byte)(154)), ((byte)(154))));
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.rectangle1,
			this.rectangle2,
			this.freeText1,
			this.freeText2,
			this.freeText3,
			this.line1,
			this.line2,
			this.freeText4,
			this.freeText5,
			this.freeText6,
			this.freeText7,
			this.freeText8,
			this.freeText9,
			this.Failure1,
			this.line3,
			this.line4,
			this.line5,
			this.line6,
			this.line7,
			this.Failure2,
			this.Failure3,
			this.Failure4,
			this.Failure5,
			this.Failure6,
			this.CountFailure1,
			this.CountFailure2,
			this.CountFailure3,
			this.CountFailure4,
			this.CountFailure5,
			this.CountFailure6});
			this.Size = new System.Drawing.Size(424, 240);
			this.Title = "Failures Status";

		}
		private NxtControl.GuiFramework.Rectangle rectangle2;
		private NxtControl.GuiFramework.Line line1;
		private NxtControl.GuiFramework.FreeText freeText1;
		private NxtControl.GuiFramework.FreeText freeText2;
		private NxtControl.GuiFramework.FreeText freeText3;
		private NxtControl.GuiFramework.Rectangle rectangle1;
		private NxtControl.GuiFramework.Line line2;
		private NxtControl.GuiFramework.FreeText freeText4;
		private NxtControl.GuiFramework.FreeText freeText5;
		private NxtControl.GuiFramework.FreeText freeText6;
		private NxtControl.GuiFramework.FreeText freeText7;
		private NxtControl.GuiFramework.FreeText freeText8;
		private NxtControl.GuiFramework.FreeText freeText9;
		private System.HMI.Symbols.Base.FreeText<bool> Failure1;
		private NxtControl.GuiFramework.Line line3;
		private NxtControl.GuiFramework.Line line4;
		private NxtControl.GuiFramework.Line line5;
		private NxtControl.GuiFramework.Line line6;
		private NxtControl.GuiFramework.Line line7;
		private System.HMI.Symbols.Base.FreeText<bool> Failure2;
		private System.HMI.Symbols.Base.FreeText<bool> Failure3;
		private System.HMI.Symbols.Base.FreeText<bool> Failure4;
		private System.HMI.Symbols.Base.FreeText<bool> Failure5;
		private System.HMI.Symbols.Base.FreeText<bool> Failure6;
		private System.HMI.Symbols.Base.FreeText<ushort> CountFailure1;
		private System.HMI.Symbols.Base.FreeText<ushort> CountFailure2;
		private System.HMI.Symbols.Base.FreeText<ushort> CountFailure3;
		private System.HMI.Symbols.Base.FreeText<ushort> CountFailure4;
		private System.HMI.Symbols.Base.FreeText<ushort> CountFailure5;
		private System.HMI.Symbols.Base.FreeText<ushort> CountFailure6;
		#endregion
	}
}
