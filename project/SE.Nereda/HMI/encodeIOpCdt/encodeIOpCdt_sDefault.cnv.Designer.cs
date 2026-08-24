/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 6/7/2026
 * Time: 2:15 PM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.encodeIOpCdt
{
	/// <summary>
	/// Summary description for sDefault.
	/// </summary>
	partial class sDefault
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
			this.rectangle1 = new NxtControl.GuiFramework.Rectangle();
			this.line1 = new NxtControl.GuiFramework.Line();
			this.freeText1 = new NxtControl.GuiFramework.FreeText();
			this.rectangle2 = new NxtControl.GuiFramework.Rectangle();
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
			// 
			// rectangle1
			// 
			this.rectangle1.Bounds = new NxtControl.Drawing.RectF(((float)(8D)), ((float)(8D)), ((float)(368D)), ((float)(48D)));
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
			// rectangle2
			// 
			this.rectangle2.Bounds = new NxtControl.Drawing.RectF(((float)(8D)), ((float)(56D)), ((float)(368D)), ((float)(256D)));
			this.rectangle2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle2.Name = "rectangle2";
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
			this.freeText3.Text = "Current OC Status Values";
			// 
			// freeText4
			// 
			this.freeText4.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText4.Font = new NxtControl.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
			this.freeText4.Location = new NxtControl.Drawing.PointF(16D, 88D);
			this.freeText4.Name = "freeText4";
			this.freeText4.Text = "-1 OC Status Values";
			// 
			// freeText5
			// 
			this.freeText5.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText5.Font = new NxtControl.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
			this.freeText5.Location = new NxtControl.Drawing.PointF(16D, 112D);
			this.freeText5.Name = "freeText5";
			this.freeText5.Text = "-2 OC Status Values";
			// 
			// freeText6
			// 
			this.freeText6.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText6.Font = new NxtControl.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
			this.freeText6.Location = new NxtControl.Drawing.PointF(16D, 140D);
			this.freeText6.Name = "freeText6";
			this.freeText6.Text = "-3 OC Status Values";
			// 
			// freeText7
			// 
			this.freeText7.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText7.Font = new NxtControl.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
			this.freeText7.Location = new NxtControl.Drawing.PointF(16D, 168D);
			this.freeText7.Name = "freeText7";
			this.freeText7.Text = "-4 OC Status Values";
			// 
			// freeText8
			// 
			this.freeText8.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText8.Font = new NxtControl.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
			this.freeText8.Location = new NxtControl.Drawing.PointF(16D, 192D);
			this.freeText8.Name = "freeText8";
			this.freeText8.Text = "-5 OC Status Values";
			// 
			// freeText9
			// 
			this.freeText9.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText9.Font = new NxtControl.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
			this.freeText9.Location = new NxtControl.Drawing.PointF(16D, 216D);
			this.freeText9.Name = "freeText9";
			this.freeText9.Text = "-6 OC Status Values";
			// 
			// freeText10
			// 
			this.freeText10.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText10.Font = new NxtControl.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
			this.freeText10.Location = new NxtControl.Drawing.PointF(16D, 240D);
			this.freeText10.Name = "freeText10";
			this.freeText10.Text = "-7 OC Status Values";
			// 
			// freeText11
			// 
			this.freeText11.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText11.Font = new NxtControl.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
			this.freeText11.Location = new NxtControl.Drawing.PointF(16D, 264D);
			this.freeText11.Name = "freeText11";
			this.freeText11.Text = "-8 OC Status Values";
			// 
			// freeText12
			// 
			this.freeText12.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText12.Font = new NxtControl.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
			this.freeText12.Location = new NxtControl.Drawing.PointF(16D, 288D);
			this.freeText12.Name = "freeText12";
			this.freeText12.Text = "-9 OC Status Values";
			// 
			// sDefault
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
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
			this.freeText12});
			this.SymbolSize = new System.Drawing.Size(408, 344);

		}
		private NxtControl.GuiFramework.Rectangle rectangle1;
		private NxtControl.GuiFramework.Line line1;
		private NxtControl.GuiFramework.FreeText freeText1;
		private NxtControl.GuiFramework.Rectangle rectangle2;
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
		#endregion
	}
}
