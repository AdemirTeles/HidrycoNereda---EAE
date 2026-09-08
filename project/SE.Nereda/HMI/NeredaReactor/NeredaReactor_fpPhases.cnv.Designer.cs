/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 7/9/2026
 * Time: 10:00 AM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using NxtControl.GuiFramework;

namespace SE.Nereda.Faceplates.NeredaReactor
{
	/// <summary>
	/// Summary description for fpPhases.
	/// </summary>
	partial class fpPhases
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
			this.roundedRectangle3 = new NxtControl.GuiFramework.RoundedRectangle();
			this.freeText1 = new NxtControl.GuiFramework.FreeText();
			this.freeText2 = new NxtControl.GuiFramework.FreeText();
			this.freeText3 = new NxtControl.GuiFramework.FreeText();
			this.freeText4 = new NxtControl.GuiFramework.FreeText();
			this.freeText5 = new NxtControl.GuiFramework.FreeText();
			this.FeedRun = new System.HMI.Symbols.Base.Led<bool>();
			this.AerateRun = new System.HMI.Symbols.Base.Led<bool>();
			this.SDRun = new System.HMI.Symbols.Base.Led<bool>();
			this.VentRun = new System.HMI.Symbols.Base.Led<bool>();
			this.WaitRun = new System.HMI.Symbols.Base.Led<bool>();
			// 
			// roundedRectangle3
			// 
			this.roundedRectangle3.Bounds = new NxtControl.Drawing.RectF(((float)(8D)), ((float)(8D)), ((float)(175.5142822265625D)), ((float)(192D)));
			this.roundedRectangle3.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255))), new NxtControl.Drawing.GradientFill(NxtControl.Drawing.GradientFillOrientation.DiagonalLeftTop));
			this.roundedRectangle3.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.roundedRectangle3.Name = "roundedRectangle3";
			this.roundedRectangle3.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(114)), ((byte)(114)), ((byte)(114))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// freeText1
			// 
			this.freeText1.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText1.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.freeText1.Location = new NxtControl.Drawing.PointF(51.20840336134453D, 22D);
			this.freeText1.Name = "freeText1";
			this.freeText1.Text = "Phase Feed";
			// 
			// freeText2
			// 
			this.freeText2.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText2.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.freeText2.Location = new NxtControl.Drawing.PointF(51.20840336134453D, 58D);
			this.freeText2.Name = "freeText2";
			this.freeText2.Text = "Phase Aerate";
			// 
			// freeText3
			// 
			this.freeText3.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText3.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.freeText3.Location = new NxtControl.Drawing.PointF(51.20840336134453D, 94D);
			this.freeText3.Name = "freeText3";
			this.freeText3.Text = "Phase Discharge";
			// 
			// freeText4
			// 
			this.freeText4.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText4.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.freeText4.Location = new NxtControl.Drawing.PointF(51.20840336134453D, 130D);
			this.freeText4.Name = "freeText4";
			this.freeText4.Text = "Phase Vent";
			// 
			// freeText5
			// 
			this.freeText5.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText5.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.freeText5.Location = new NxtControl.Drawing.PointF(51.20840336134453D, 165D);
			this.freeText5.Name = "freeText5";
			this.freeText5.Text = "Phase Wait";
			// 
			// FeedRun
			// 
			this.FeedRun.BeginInit();
			this.FeedRun.ColorFrame = new NxtControl.Drawing.Color("LedFrameColor");
			this.FeedRun.DesignMatrix = new NxtControl.Drawing.Matrix2D(1.7115196078431374D, 0D, 0D, 1.7380681818181807D, 25.604201680672272D, 30.928409090909089D);
			this.FeedRun.FrameSize = 33F;
			this.FeedRun.IsOnlyInput = true;
			this.FeedRun.Name = "FeedRun";
			propertyDictionary2.Add("Color", new NxtControl.Drawing.Color("LedFalseColor"));
			propertyDictionary3.Add("Color", new NxtControl.Drawing.Color("DevAnalogOut"));
			this.FeedRun.Ranges.Clear();
			this.FeedRun.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(false, propertyDictionary2));
			this.FeedRun.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(true, propertyDictionary3));
			propertyDictionary1.Add("Color", new NxtControl.Drawing.Color("LedFalseColor"));
			this.FeedRun.Ranges.DefaultPropertyValues = propertyDictionary1;
			this.FeedRun.TagName = "FeedRun";
			this.FeedRun.EndInit();
			// 
			// AerateRun
			// 
			this.AerateRun.BeginInit();
			this.AerateRun.ColorFrame = new NxtControl.Drawing.Color("LedFrameColor");
			this.AerateRun.DesignMatrix = new NxtControl.Drawing.Matrix2D(1.7115196078431374D, 0D, 0D, 1.7380681818181827D, 25.604201680672272D, 66.68295454545455D);
			this.AerateRun.FrameSize = 33F;
			this.AerateRun.IsOnlyInput = true;
			this.AerateRun.Name = "AerateRun";
			propertyDictionary5.Add("Color", new NxtControl.Drawing.Color("LedFalseColor"));
			propertyDictionary6.Add("Color", new NxtControl.Drawing.Color("DevAnalogOut"));
			this.AerateRun.Ranges.Clear();
			this.AerateRun.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(false, propertyDictionary5));
			this.AerateRun.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(true, propertyDictionary6));
			propertyDictionary4.Add("Color", new NxtControl.Drawing.Color("LedFalseColor"));
			this.AerateRun.Ranges.DefaultPropertyValues = propertyDictionary4;
			this.AerateRun.TagName = "AerateRun";
			this.AerateRun.EndInit();
			// 
			// SDRun
			// 
			this.SDRun.BeginInit();
			this.SDRun.ColorFrame = new NxtControl.Drawing.Color("LedFrameColor");
			this.SDRun.DesignMatrix = new NxtControl.Drawing.Matrix2D(1.7115196078431374D, 0D, 0D, 1.7380681818181816D, 25.604201680672272D, 102.43750000000001D);
			this.SDRun.FrameSize = 33F;
			this.SDRun.IsOnlyInput = true;
			this.SDRun.Name = "SDRun";
			propertyDictionary8.Add("Color", new NxtControl.Drawing.Color("LedFalseColor"));
			propertyDictionary9.Add("Color", new NxtControl.Drawing.Color("DevAnalogOut"));
			this.SDRun.Ranges.Clear();
			this.SDRun.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(false, propertyDictionary8));
			this.SDRun.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(true, propertyDictionary9));
			propertyDictionary7.Add("Color", new NxtControl.Drawing.Color("LedFalseColor"));
			this.SDRun.Ranges.DefaultPropertyValues = propertyDictionary7;
			this.SDRun.TagName = "SludgeDischargeRun";
			this.SDRun.EndInit();
			// 
			// VentRun
			// 
			this.VentRun.BeginInit();
			this.VentRun.ColorFrame = new NxtControl.Drawing.Color("LedFrameColor");
			this.VentRun.DesignMatrix = new NxtControl.Drawing.Matrix2D(1.7115196078431374D, 0D, 0D, 1.7380681818181771D, 25.604201680672272D, 138.19204545454539D);
			this.VentRun.FrameSize = 33F;
			this.VentRun.IsOnlyInput = true;
			this.VentRun.Name = "VentRun";
			propertyDictionary11.Add("Color", new NxtControl.Drawing.Color("LedFalseColor"));
			propertyDictionary12.Add("Color", new NxtControl.Drawing.Color("DevAnalogOut"));
			this.VentRun.Ranges.Clear();
			this.VentRun.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(false, propertyDictionary11));
			this.VentRun.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(true, propertyDictionary12));
			propertyDictionary10.Add("Color", new NxtControl.Drawing.Color("LedFalseColor"));
			this.VentRun.Ranges.DefaultPropertyValues = propertyDictionary10;
			this.VentRun.TagName = "VentRun";
			this.VentRun.EndInit();
			// 
			// WaitRun
			// 
			this.WaitRun.BeginInit();
			this.WaitRun.ColorFrame = new NxtControl.Drawing.Color("LedFrameColor");
			this.WaitRun.DesignMatrix = new NxtControl.Drawing.Matrix2D(1.7115196078431374D, 0D, 0D, 1.7380681818181829D, 25.604201680672272D, 173.94659090909084D);
			this.WaitRun.FrameSize = 33F;
			this.WaitRun.IsOnlyInput = true;
			this.WaitRun.Name = "WaitRun";
			propertyDictionary14.Add("Color", new NxtControl.Drawing.Color("LedFalseColor"));
			propertyDictionary15.Add("Color", new NxtControl.Drawing.Color("DevAnalogOut"));
			this.WaitRun.Ranges.Clear();
			this.WaitRun.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(false, propertyDictionary14));
			this.WaitRun.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(true, propertyDictionary15));
			propertyDictionary13.Add("Color", new NxtControl.Drawing.Color("LedFalseColor"));
			this.WaitRun.Ranges.DefaultPropertyValues = propertyDictionary13;
			this.WaitRun.TagName = "WaitRun";
			this.WaitRun.EndInit();
			// 
			// fpPhases
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(192D)), ((float)(208D)));
			this.Brush = new NxtControl.Drawing.Brush("FaceplateBrush");
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.roundedRectangle3,
			this.freeText1,
			this.freeText2,
			this.freeText3,
			this.freeText4,
			this.freeText5,
			this.FeedRun,
			this.AerateRun,
			this.SDRun,
			this.VentRun,
			this.WaitRun});
			this.Size = new System.Drawing.Size(192, 208);

		}
		private NxtControl.GuiFramework.RoundedRectangle roundedRectangle3;
		private NxtControl.GuiFramework.FreeText freeText1;
		private NxtControl.GuiFramework.FreeText freeText2;
		private NxtControl.GuiFramework.FreeText freeText3;
		private NxtControl.GuiFramework.FreeText freeText4;
		private NxtControl.GuiFramework.FreeText freeText5;
		private System.HMI.Symbols.Base.Led<bool> FeedRun;
		private System.HMI.Symbols.Base.Led<bool> AerateRun;
		private System.HMI.Symbols.Base.Led<bool> SDRun;
		private System.HMI.Symbols.Base.Led<bool> VentRun;
		private System.HMI.Symbols.Base.Led<bool> WaitRun;
		#endregion
	}
}
