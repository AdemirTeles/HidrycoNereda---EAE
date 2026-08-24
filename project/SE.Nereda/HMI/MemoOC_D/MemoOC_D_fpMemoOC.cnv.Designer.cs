/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 8/17/2026
 * Time: 4:40 PM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using NxtControl.GuiFramework;

namespace SE.Nereda.Faceplates.MemoOC_D
{
	/// <summary>
	/// Summary description for fpMemoOC.
	/// </summary>
	partial class fpMemoOC
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary1 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary2 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary3 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary4 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary5 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary6 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary7 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary8 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary9 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary10 = new NxtControl.GuiFramework.PropertyDictionary();
			this.rectangle2 = new NxtControl.GuiFramework.Rectangle();
			this.rectangle1 = new NxtControl.GuiFramework.Rectangle();
			this.line1 = new NxtControl.GuiFramework.Line();
			this.freeText1 = new NxtControl.GuiFramework.FreeText();
			this.OCStatus_Curr = new System.HMI.Symbols.Base.FreeText<ushort>();
			this.freeText2 = new NxtControl.GuiFramework.FreeText();
			this.OCStatus1 = new System.HMI.Symbols.Base.FreeText<ushort>();
			this.OCStatus2 = new System.HMI.Symbols.Base.FreeText<ushort>();
			this.OCStatus3 = new System.HMI.Symbols.Base.FreeText<ushort>();
			this.OCStatus4 = new System.HMI.Symbols.Base.FreeText<ushort>();
			this.OCStatus5 = new System.HMI.Symbols.Base.FreeText<ushort>();
			this.OCStatus6 = new System.HMI.Symbols.Base.FreeText<ushort>();
			this.OCStatus7 = new System.HMI.Symbols.Base.FreeText<ushort>();
			this.OCStatus8 = new System.HMI.Symbols.Base.FreeText<ushort>();
			this.OCStatus9 = new System.HMI.Symbols.Base.FreeText<ushort>();
			this.freeText3 = new NxtControl.GuiFramework.FreeText();
			this.freeText4 = new NxtControl.GuiFramework.FreeText();
			this.freeText5 = new NxtControl.GuiFramework.FreeText();
			this.freeText6 = new NxtControl.GuiFramework.FreeText();
			this.freeText7 = new NxtControl.GuiFramework.FreeText();
			this.freeText8 = new NxtControl.GuiFramework.FreeText();
			this.freeText9 = new NxtControl.GuiFramework.FreeText();
			this.freeText10 = new NxtControl.GuiFramework.FreeText();
			this.freeText11 = new NxtControl.GuiFramework.FreeText();
			this.freeText12 = new NxtControl.GuiFramework.FreeText();
			this.rectangle3 = new NxtControl.GuiFramework.Rectangle();
			this.line2 = new NxtControl.GuiFramework.Line();
			this.freeText13 = new NxtControl.GuiFramework.FreeText();
			this.freeText14 = new NxtControl.GuiFramework.FreeText();
			this.Hx0 = new NxtControl.GuiFramework.FreeText();
			this.Hx1 = new NxtControl.GuiFramework.FreeText();
			this.Hx2 = new NxtControl.GuiFramework.FreeText();
			this.Hx3 = new NxtControl.GuiFramework.FreeText();
			this.Hx4 = new NxtControl.GuiFramework.FreeText();
			this.Hx5 = new NxtControl.GuiFramework.FreeText();
			this.Hx6 = new NxtControl.GuiFramework.FreeText();
			this.Hx7 = new NxtControl.GuiFramework.FreeText();
			this.Hx8 = new NxtControl.GuiFramework.FreeText();
			this.Hx9 = new NxtControl.GuiFramework.FreeText();
			this.OCStatus_Curr_1 = new System.HMI.Symbols.Base.Execute<ushort>();
			this.OCStatus1_1 = new System.HMI.Symbols.Base.Execute<ushort>();
			this.OCStatus2_1 = new System.HMI.Symbols.Base.Execute<ushort>();
			this.OCStatus3_1 = new System.HMI.Symbols.Base.Execute<ushort>();
			this.OCStatus4_1 = new System.HMI.Symbols.Base.Execute<ushort>();
			this.OCStatus5_1 = new System.HMI.Symbols.Base.Execute<ushort>();
			this.OCStatus6_1 = new System.HMI.Symbols.Base.Execute<ushort>();
			this.OCStatus7_1 = new System.HMI.Symbols.Base.Execute<ushort>();
			this.OCStatus8_1 = new System.HMI.Symbols.Base.Execute<ushort>();
			this.OCStatus9_1 = new System.HMI.Symbols.Base.Execute<ushort>();
			// 
			// rectangle2
			// 
			this.rectangle2.Bounds = new NxtControl.Drawing.RectF(((float)(8D)), ((float)(56D)), ((float)(376D)), ((float)(256D)));
			this.rectangle2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle2.Name = "rectangle2";
			// 
			// rectangle1
			// 
			this.rectangle1.Bounds = new NxtControl.Drawing.RectF(((float)(8D)), ((float)(8D)), ((float)(376D)), ((float)(32D)));
			this.rectangle1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(235)), ((byte)(235)), ((byte)(235))));
			this.rectangle1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle1.Name = "rectangle1";
			// 
			// line1
			// 
			this.line1.EndPoint = new NxtControl.Drawing.PointF(216D, 312D);
			this.line1.Name = "line1";
			this.line1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line1.StartPoint = new NxtControl.Drawing.PointF(216D, 8D);
			// 
			// freeText1
			// 
			this.freeText1.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(114)), ((byte)(188)));
			this.freeText1.Font = new NxtControl.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
			this.freeText1.Location = new NxtControl.Drawing.PointF(16D, 16D);
			this.freeText1.Name = "freeText1";
			this.freeText1.Text = "OC Status History";
			// 
			// OCStatus_Curr
			// 
			this.OCStatus_Curr.BeginInit();
			this.OCStatus_Curr.DecimalPlacesCount = ((uint)(2u));
			this.OCStatus_Curr.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 224D, 64D);
			this.OCStatus_Curr.Font = new NxtControl.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
			this.OCStatus_Curr.IsOnlyInput = true;
			this.OCStatus_Curr.Name = "OCStatus_Curr";
			propertyDictionary1.Add("Text", "${Value}");
			propertyDictionary1.Add("TextColor", new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			this.OCStatus_Curr.Ranges.DefaultPropertyValues = propertyDictionary1;
			this.OCStatus_Curr.TagName = "OCStatus_Curr";
			this.OCStatus_Curr.TextAngle = 0F;
			this.OCStatus_Curr.EndInit();
			// 
			// freeText2
			// 
			this.freeText2.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(114)), ((byte)(188)));
			this.freeText2.Font = new NxtControl.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
			this.freeText2.Location = new NxtControl.Drawing.PointF(224D, 16D);
			this.freeText2.Name = "freeText2";
			this.freeText2.Text = "OC Status Values";
			// 
			// OCStatus1
			// 
			this.OCStatus1.BeginInit();
			this.OCStatus1.DecimalPlacesCount = ((uint)(2u));
			this.OCStatus1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 224D, 88D);
			this.OCStatus1.Font = new NxtControl.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
			this.OCStatus1.IsOnlyInput = true;
			this.OCStatus1.Name = "OCStatus1";
			propertyDictionary2.Add("Text", "${Value}");
			propertyDictionary2.Add("TextColor", new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			this.OCStatus1.Ranges.DefaultPropertyValues = propertyDictionary2;
			this.OCStatus1.TagName = "OCStatus1";
			this.OCStatus1.TextAngle = 0F;
			this.OCStatus1.EndInit();
			// 
			// OCStatus2
			// 
			this.OCStatus2.BeginInit();
			this.OCStatus2.DecimalPlacesCount = ((uint)(2u));
			this.OCStatus2.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 224D, 112D);
			this.OCStatus2.Font = new NxtControl.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
			this.OCStatus2.IsOnlyInput = true;
			this.OCStatus2.Name = "OCStatus2";
			propertyDictionary3.Add("Text", "${Value}");
			propertyDictionary3.Add("TextColor", new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			this.OCStatus2.Ranges.DefaultPropertyValues = propertyDictionary3;
			this.OCStatus2.TagName = "OCStatus2";
			this.OCStatus2.TextAngle = 0F;
			this.OCStatus2.EndInit();
			// 
			// OCStatus3
			// 
			this.OCStatus3.BeginInit();
			this.OCStatus3.DecimalPlacesCount = ((uint)(2u));
			this.OCStatus3.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 224D, 140D);
			this.OCStatus3.Font = new NxtControl.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
			this.OCStatus3.IsOnlyInput = true;
			this.OCStatus3.Name = "OCStatus3";
			propertyDictionary4.Add("Text", "${Value}");
			propertyDictionary4.Add("TextColor", new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			this.OCStatus3.Ranges.DefaultPropertyValues = propertyDictionary4;
			this.OCStatus3.TagName = "OCStatus3";
			this.OCStatus3.TextAngle = 0F;
			this.OCStatus3.EndInit();
			// 
			// OCStatus4
			// 
			this.OCStatus4.BeginInit();
			this.OCStatus4.DecimalPlacesCount = ((uint)(2u));
			this.OCStatus4.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 224D, 168D);
			this.OCStatus4.Font = new NxtControl.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
			this.OCStatus4.IsOnlyInput = true;
			this.OCStatus4.Name = "OCStatus4";
			propertyDictionary5.Add("Text", "${Value}");
			propertyDictionary5.Add("TextColor", new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			this.OCStatus4.Ranges.DefaultPropertyValues = propertyDictionary5;
			this.OCStatus4.TagName = "OCStatus4";
			this.OCStatus4.TextAngle = 0F;
			this.OCStatus4.EndInit();
			// 
			// OCStatus5
			// 
			this.OCStatus5.BeginInit();
			this.OCStatus5.DecimalPlacesCount = ((uint)(2u));
			this.OCStatus5.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 224D, 192D);
			this.OCStatus5.Font = new NxtControl.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
			this.OCStatus5.IsOnlyInput = true;
			this.OCStatus5.Name = "OCStatus5";
			propertyDictionary6.Add("Text", "${Value}");
			propertyDictionary6.Add("TextColor", new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			this.OCStatus5.Ranges.DefaultPropertyValues = propertyDictionary6;
			this.OCStatus5.TagName = "OCStatus5";
			this.OCStatus5.TextAngle = 0F;
			this.OCStatus5.EndInit();
			// 
			// OCStatus6
			// 
			this.OCStatus6.BeginInit();
			this.OCStatus6.DecimalPlacesCount = ((uint)(2u));
			this.OCStatus6.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 224D, 216D);
			this.OCStatus6.Font = new NxtControl.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
			this.OCStatus6.IsOnlyInput = true;
			this.OCStatus6.Name = "OCStatus6";
			propertyDictionary7.Add("Text", "${Value}");
			propertyDictionary7.Add("TextColor", new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			this.OCStatus6.Ranges.DefaultPropertyValues = propertyDictionary7;
			this.OCStatus6.TagName = "OCStatus6";
			this.OCStatus6.TextAngle = 0F;
			this.OCStatus6.EndInit();
			// 
			// OCStatus7
			// 
			this.OCStatus7.BeginInit();
			this.OCStatus7.DecimalPlacesCount = ((uint)(2u));
			this.OCStatus7.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 224D, 240D);
			this.OCStatus7.Font = new NxtControl.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
			this.OCStatus7.IsOnlyInput = true;
			this.OCStatus7.Name = "OCStatus7";
			propertyDictionary8.Add("Text", "${Value}");
			propertyDictionary8.Add("TextColor", new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			this.OCStatus7.Ranges.DefaultPropertyValues = propertyDictionary8;
			this.OCStatus7.TagName = "OCStatus7";
			this.OCStatus7.TextAngle = 0F;
			this.OCStatus7.EndInit();
			// 
			// OCStatus8
			// 
			this.OCStatus8.BeginInit();
			this.OCStatus8.DecimalPlacesCount = ((uint)(2u));
			this.OCStatus8.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 224D, 264D);
			this.OCStatus8.Font = new NxtControl.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
			this.OCStatus8.IsOnlyInput = true;
			this.OCStatus8.Name = "OCStatus8";
			propertyDictionary9.Add("Text", "${Value}");
			propertyDictionary9.Add("TextColor", new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			this.OCStatus8.Ranges.DefaultPropertyValues = propertyDictionary9;
			this.OCStatus8.TagName = "OCStatus8";
			this.OCStatus8.TextAngle = 0F;
			this.OCStatus8.EndInit();
			// 
			// OCStatus9
			// 
			this.OCStatus9.BeginInit();
			this.OCStatus9.DecimalPlacesCount = ((uint)(2u));
			this.OCStatus9.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 224D, 288D);
			this.OCStatus9.Font = new NxtControl.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
			this.OCStatus9.IsOnlyInput = true;
			this.OCStatus9.Name = "OCStatus9";
			propertyDictionary10.Add("Text", "${Value}");
			propertyDictionary10.Add("TextColor", new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			this.OCStatus9.Ranges.DefaultPropertyValues = propertyDictionary10;
			this.OCStatus9.TagName = "OCStatus9";
			this.OCStatus9.TextAngle = 0F;
			this.OCStatus9.EndInit();
			// 
			// freeText3
			// 
			this.freeText3.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText3.Font = new NxtControl.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
			this.freeText3.Location = new NxtControl.Drawing.PointF(16D, 64D);
			this.freeText3.Name = "freeText3";
			this.freeText3.Text = "Current OC Status Value";
			// 
			// freeText4
			// 
			this.freeText4.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText4.Font = new NxtControl.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
			this.freeText4.Location = new NxtControl.Drawing.PointF(16D, 88D);
			this.freeText4.Name = "freeText4";
			this.freeText4.Text = "-1 OC Status Value";
			// 
			// freeText5
			// 
			this.freeText5.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText5.Font = new NxtControl.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
			this.freeText5.Location = new NxtControl.Drawing.PointF(16D, 112D);
			this.freeText5.Name = "freeText5";
			this.freeText5.Text = "-2 OC Status Value";
			// 
			// freeText6
			// 
			this.freeText6.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText6.Font = new NxtControl.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
			this.freeText6.Location = new NxtControl.Drawing.PointF(16D, 140D);
			this.freeText6.Name = "freeText6";
			this.freeText6.Text = "-3 OC Status Value";
			// 
			// freeText7
			// 
			this.freeText7.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText7.Font = new NxtControl.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
			this.freeText7.Location = new NxtControl.Drawing.PointF(16D, 168D);
			this.freeText7.Name = "freeText7";
			this.freeText7.Text = "-4 OC Status Value";
			// 
			// freeText8
			// 
			this.freeText8.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText8.Font = new NxtControl.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
			this.freeText8.Location = new NxtControl.Drawing.PointF(16D, 192D);
			this.freeText8.Name = "freeText8";
			this.freeText8.Text = "-5 OC Status Value";
			// 
			// freeText9
			// 
			this.freeText9.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText9.Font = new NxtControl.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
			this.freeText9.Location = new NxtControl.Drawing.PointF(16D, 216D);
			this.freeText9.Name = "freeText9";
			this.freeText9.Text = "-6 OC Status Value";
			// 
			// freeText10
			// 
			this.freeText10.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText10.Font = new NxtControl.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
			this.freeText10.Location = new NxtControl.Drawing.PointF(16D, 240D);
			this.freeText10.Name = "freeText10";
			this.freeText10.Text = "-7 OC Status Value";
			// 
			// freeText11
			// 
			this.freeText11.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText11.Font = new NxtControl.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
			this.freeText11.Location = new NxtControl.Drawing.PointF(16D, 264D);
			this.freeText11.Name = "freeText11";
			this.freeText11.Text = "-8 OC Status Value";
			// 
			// freeText12
			// 
			this.freeText12.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText12.Font = new NxtControl.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
			this.freeText12.Location = new NxtControl.Drawing.PointF(16D, 288D);
			this.freeText12.Name = "freeText12";
			this.freeText12.Text = "-9 OC Status Value";
			// 
			// rectangle3
			// 
			this.rectangle3.Bounds = new NxtControl.Drawing.RectF(((float)(8D)), ((float)(40D)), ((float)(376D)), ((float)(16D)));
			this.rectangle3.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(235)), ((byte)(235)), ((byte)(235))));
			this.rectangle3.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle3.Name = "rectangle3";
			// 
			// line2
			// 
			this.line2.EndPoint = new NxtControl.Drawing.PointF(296D, 312D);
			this.line2.Name = "line2";
			this.line2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line2.StartPoint = new NxtControl.Drawing.PointF(296D, 40D);
			// 
			// freeText13
			// 
			this.freeText13.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText13.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText13.Location = new NxtControl.Drawing.PointF(232D, 40D);
			this.freeText13.Name = "freeText13";
			this.freeText13.Text = "Decimal";
			// 
			// freeText14
			// 
			this.freeText14.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText14.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText14.Location = new NxtControl.Drawing.PointF(304D, 40D);
			this.freeText14.Name = "freeText14";
			this.freeText14.Text = "Hexadecimal";
			// 
			// Hx0
			// 
			this.Hx0.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.Hx0.Font = new NxtControl.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
			this.Hx0.Location = new NxtControl.Drawing.PointF(304D, 64D);
			this.Hx0.Name = "Hx0";
			this.Hx0.Text = "16#xxxx";
			// 
			// Hx1
			// 
			this.Hx1.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.Hx1.Font = new NxtControl.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
			this.Hx1.Location = new NxtControl.Drawing.PointF(304D, 88D);
			this.Hx1.Name = "Hx1";
			this.Hx1.Text = "16#xxxx";
			// 
			// Hx2
			// 
			this.Hx2.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.Hx2.Font = new NxtControl.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
			this.Hx2.Location = new NxtControl.Drawing.PointF(304D, 112D);
			this.Hx2.Name = "Hx2";
			this.Hx2.Text = "16#xxxx";
			// 
			// Hx3
			// 
			this.Hx3.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.Hx3.Font = new NxtControl.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
			this.Hx3.Location = new NxtControl.Drawing.PointF(304D, 140D);
			this.Hx3.Name = "Hx3";
			this.Hx3.Text = "16#xxxx";
			// 
			// Hx4
			// 
			this.Hx4.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.Hx4.Font = new NxtControl.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
			this.Hx4.Location = new NxtControl.Drawing.PointF(304D, 168D);
			this.Hx4.Name = "Hx4";
			this.Hx4.Text = "16#xxxx";
			// 
			// Hx5
			// 
			this.Hx5.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.Hx5.Font = new NxtControl.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
			this.Hx5.Location = new NxtControl.Drawing.PointF(304D, 192D);
			this.Hx5.Name = "Hx5";
			this.Hx5.Text = "16#xxxx";
			// 
			// Hx6
			// 
			this.Hx6.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.Hx6.Font = new NxtControl.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
			this.Hx6.Location = new NxtControl.Drawing.PointF(304D, 216D);
			this.Hx6.Name = "Hx6";
			this.Hx6.Text = "16#xxxx";
			// 
			// Hx7
			// 
			this.Hx7.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.Hx7.Font = new NxtControl.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
			this.Hx7.Location = new NxtControl.Drawing.PointF(304D, 240D);
			this.Hx7.Name = "Hx7";
			this.Hx7.Text = "16#xxxx";
			// 
			// Hx8
			// 
			this.Hx8.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.Hx8.Font = new NxtControl.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
			this.Hx8.Location = new NxtControl.Drawing.PointF(304D, 264D);
			this.Hx8.Name = "Hx8";
			this.Hx8.Text = "16#xxxx";
			// 
			// Hx9
			// 
			this.Hx9.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.Hx9.Font = new NxtControl.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
			this.Hx9.Location = new NxtControl.Drawing.PointF(304D, 288D);
			this.Hx9.Name = "Hx9";
			this.Hx9.Text = "16#xxxx";
			// 
			// OCStatus_Curr_1
			// 
			this.OCStatus_Curr_1.BeginInit();
			this.OCStatus_Curr_1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.OCStatus_Curr_1.IsOnlyInput = true;
			this.OCStatus_Curr_1.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.OCStatus_Curr_1.Name = "OCStatus_Curr_1";
			this.OCStatus_Curr_1.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.OCStatus_Curr_1.TagName = "OCStatus_Curr";
			this.OCStatus_Curr_1.Value = ((ushort)(0));
			this.OCStatus_Curr_1.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.OCStatus_Curr_1ValueChanged);
			this.OCStatus_Curr_1.EndInit();
			// 
			// OCStatus1_1
			// 
			this.OCStatus1_1.BeginInit();
			this.OCStatus1_1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.OCStatus1_1.IsOnlyInput = true;
			this.OCStatus1_1.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.OCStatus1_1.Name = "OCStatus1_1";
			this.OCStatus1_1.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.OCStatus1_1.TagName = "OCStatus1";
			this.OCStatus1_1.Value = ((ushort)(0));
			this.OCStatus1_1.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.OCStatus1_1ValueChanged);
			this.OCStatus1_1.EndInit();
			// 
			// OCStatus2_1
			// 
			this.OCStatus2_1.BeginInit();
			this.OCStatus2_1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.OCStatus2_1.IsOnlyInput = true;
			this.OCStatus2_1.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.OCStatus2_1.Name = "OCStatus2_1";
			this.OCStatus2_1.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.OCStatus2_1.TagName = "OCStatus2";
			this.OCStatus2_1.Value = ((ushort)(0));
			this.OCStatus2_1.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.OCStatus2_1ValueChanged);
			this.OCStatus2_1.EndInit();
			// 
			// OCStatus3_1
			// 
			this.OCStatus3_1.BeginInit();
			this.OCStatus3_1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.OCStatus3_1.IsOnlyInput = true;
			this.OCStatus3_1.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.OCStatus3_1.Name = "OCStatus3_1";
			this.OCStatus3_1.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.OCStatus3_1.TagName = "OCStatus3";
			this.OCStatus3_1.Value = ((ushort)(0));
			this.OCStatus3_1.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.OCStatus3_1ValueChanged);
			this.OCStatus3_1.EndInit();
			// 
			// OCStatus4_1
			// 
			this.OCStatus4_1.BeginInit();
			this.OCStatus4_1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.OCStatus4_1.IsOnlyInput = true;
			this.OCStatus4_1.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.OCStatus4_1.Name = "OCStatus4_1";
			this.OCStatus4_1.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.OCStatus4_1.TagName = "OCStatus4";
			this.OCStatus4_1.Value = ((ushort)(0));
			this.OCStatus4_1.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.OCStatus4_1ValueChanged);
			this.OCStatus4_1.EndInit();
			// 
			// OCStatus5_1
			// 
			this.OCStatus5_1.BeginInit();
			this.OCStatus5_1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.OCStatus5_1.IsOnlyInput = true;
			this.OCStatus5_1.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.OCStatus5_1.Name = "OCStatus5_1";
			this.OCStatus5_1.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.OCStatus5_1.TagName = "OCStatus5";
			this.OCStatus5_1.Value = ((ushort)(0));
			this.OCStatus5_1.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.OCStatus5_1ValueChanged);
			this.OCStatus5_1.EndInit();
			// 
			// OCStatus6_1
			// 
			this.OCStatus6_1.BeginInit();
			this.OCStatus6_1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.OCStatus6_1.IsOnlyInput = true;
			this.OCStatus6_1.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.OCStatus6_1.Name = "OCStatus6_1";
			this.OCStatus6_1.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.OCStatus6_1.TagName = "OCStatus6";
			this.OCStatus6_1.Value = ((ushort)(0));
			this.OCStatus6_1.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.OCStatus6_1ValueChanged);
			this.OCStatus6_1.EndInit();
			// 
			// OCStatus7_1
			// 
			this.OCStatus7_1.BeginInit();
			this.OCStatus7_1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.OCStatus7_1.IsOnlyInput = true;
			this.OCStatus7_1.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.OCStatus7_1.Name = "OCStatus7_1";
			this.OCStatus7_1.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.OCStatus7_1.TagName = "OCStatus7";
			this.OCStatus7_1.Value = ((ushort)(0));
			this.OCStatus7_1.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.OCStatus7_1ValueChanged);
			this.OCStatus7_1.EndInit();
			// 
			// OCStatus8_1
			// 
			this.OCStatus8_1.BeginInit();
			this.OCStatus8_1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.OCStatus8_1.IsOnlyInput = true;
			this.OCStatus8_1.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.OCStatus8_1.Name = "OCStatus8_1";
			this.OCStatus8_1.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.OCStatus8_1.TagName = "OCStatus8";
			this.OCStatus8_1.Value = ((ushort)(0));
			this.OCStatus8_1.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.OCStatus8_1ValueChanged);
			this.OCStatus8_1.EndInit();
			// 
			// OCStatus9_1
			// 
			this.OCStatus9_1.BeginInit();
			this.OCStatus9_1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.OCStatus9_1.IsOnlyInput = true;
			this.OCStatus9_1.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.OCStatus9_1.Name = "OCStatus9_1";
			this.OCStatus9_1.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.OCStatus9_1.TagName = "OCStatus9";
			this.OCStatus9_1.Value = ((ushort)(0));
			this.OCStatus9_1.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.OCStatus9_1ValueChanged);
			this.OCStatus9_1.EndInit();
			// 
			// fpMemoOC
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(392D)), ((float)(320D)));
			this.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(154)), ((byte)(154)), ((byte)(154))));
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.rectangle3,
			this.rectangle2,
			this.rectangle1,
			this.line1,
			this.freeText1,
			this.OCStatus_Curr,
			this.freeText2,
			this.OCStatus1,
			this.OCStatus2,
			this.OCStatus3,
			this.OCStatus4,
			this.OCStatus5,
			this.OCStatus6,
			this.OCStatus7,
			this.OCStatus8,
			this.OCStatus9,
			this.freeText3,
			this.freeText4,
			this.freeText5,
			this.freeText6,
			this.freeText7,
			this.freeText8,
			this.freeText9,
			this.freeText10,
			this.freeText11,
			this.freeText12,
			this.line2,
			this.freeText13,
			this.freeText14,
			this.Hx0,
			this.Hx1,
			this.Hx2,
			this.Hx3,
			this.Hx4,
			this.Hx5,
			this.Hx6,
			this.Hx7,
			this.Hx8,
			this.Hx9,
			this.OCStatus_Curr_1,
			this.OCStatus1_1,
			this.OCStatus2_1,
			this.OCStatus3_1,
			this.OCStatus4_1,
			this.OCStatus5_1,
			this.OCStatus6_1,
			this.OCStatus7_1,
			this.OCStatus8_1,
			this.OCStatus9_1});
			this.Size = new System.Drawing.Size(392, 320);
			this.Title = "OC Status History";

		}
		private NxtControl.GuiFramework.Rectangle rectangle2;
		private NxtControl.GuiFramework.Rectangle rectangle1;
		private NxtControl.GuiFramework.Line line1;
		private NxtControl.GuiFramework.FreeText freeText1;
		private System.HMI.Symbols.Base.FreeText<ushort> OCStatus_Curr;
		private NxtControl.GuiFramework.FreeText freeText2;
		private System.HMI.Symbols.Base.FreeText<ushort> OCStatus1;
		private System.HMI.Symbols.Base.FreeText<ushort> OCStatus2;
		private System.HMI.Symbols.Base.FreeText<ushort> OCStatus3;
		private System.HMI.Symbols.Base.FreeText<ushort> OCStatus4;
		private System.HMI.Symbols.Base.FreeText<ushort> OCStatus5;
		private System.HMI.Symbols.Base.FreeText<ushort> OCStatus6;
		private System.HMI.Symbols.Base.FreeText<ushort> OCStatus7;
		private System.HMI.Symbols.Base.FreeText<ushort> OCStatus8;
		private System.HMI.Symbols.Base.FreeText<ushort> OCStatus9;
		private NxtControl.GuiFramework.FreeText freeText3;
		private NxtControl.GuiFramework.FreeText freeText4;
		private NxtControl.GuiFramework.FreeText freeText5;
		private NxtControl.GuiFramework.FreeText freeText6;
		private NxtControl.GuiFramework.FreeText freeText7;
		private NxtControl.GuiFramework.FreeText freeText8;
		private NxtControl.GuiFramework.FreeText freeText9;
		private NxtControl.GuiFramework.FreeText freeText10;
		private NxtControl.GuiFramework.FreeText freeText11;
		private NxtControl.GuiFramework.FreeText freeText12;
		private NxtControl.GuiFramework.Rectangle rectangle3;
		private NxtControl.GuiFramework.Line line2;
		private NxtControl.GuiFramework.FreeText freeText13;
		private NxtControl.GuiFramework.FreeText freeText14;
		private NxtControl.GuiFramework.FreeText Hx0;
		private NxtControl.GuiFramework.FreeText Hx1;
		private NxtControl.GuiFramework.FreeText Hx2;
		private NxtControl.GuiFramework.FreeText Hx3;
		private NxtControl.GuiFramework.FreeText Hx4;
		private NxtControl.GuiFramework.FreeText Hx5;
		private NxtControl.GuiFramework.FreeText Hx6;
		private NxtControl.GuiFramework.FreeText Hx7;
		private NxtControl.GuiFramework.FreeText Hx8;
		private NxtControl.GuiFramework.FreeText Hx9;
		private System.HMI.Symbols.Base.Execute<ushort> OCStatus_Curr_1;
		private System.HMI.Symbols.Base.Execute<ushort> OCStatus1_1;
		private System.HMI.Symbols.Base.Execute<ushort> OCStatus2_1;
		private System.HMI.Symbols.Base.Execute<ushort> OCStatus3_1;
		private System.HMI.Symbols.Base.Execute<ushort> OCStatus4_1;
		private System.HMI.Symbols.Base.Execute<ushort> OCStatus5_1;
		private System.HMI.Symbols.Base.Execute<ushort> OCStatus6_1;
		private System.HMI.Symbols.Base.Execute<ushort> OCStatus7_1;
		private System.HMI.Symbols.Base.Execute<ushort> OCStatus8_1;
		private System.HMI.Symbols.Base.Execute<ushort> OCStatus9_1;
		#endregion
	}
}
