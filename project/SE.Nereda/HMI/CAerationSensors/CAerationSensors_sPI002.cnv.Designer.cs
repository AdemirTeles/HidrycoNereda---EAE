/*
 * Created by EcoStruxure Automation Expert.
 * User: NVPP
 * Date: 7/1/2024
 * Time: 8:51 PM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.CAerationSensors
{
	/// <summary>
	/// Summary description for sDefault.
	/// </summary>
	partial class sPI002
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
			this.HiHiAlarm_Pi002 = new System.HMI.Symbols.Base.Led<bool>();
			this.HiAlarm_Pi002 = new System.HMI.Symbols.Base.Led<bool>();
			this.LoAlarm_Pi002 = new System.HMI.Symbols.Base.Led<bool>();
			this.LoLoAlarm_Pi002 = new System.HMI.Symbols.Base.Led<bool>();
			this.AlarmFailure_Pi002 = new System.HMI.Symbols.Base.Led<bool>();
			this.freeText1 = new NxtControl.GuiFramework.FreeText();
			this.freeText2 = new NxtControl.GuiFramework.FreeText();
			this.freeText3 = new NxtControl.GuiFramework.FreeText();
			this.freeText4 = new NxtControl.GuiFramework.FreeText();
			this.freeText5 = new NxtControl.GuiFramework.FreeText();
			// 
			// HiHiAlarm_Pi002
			// 
			this.HiHiAlarm_Pi002.BeginInit();
			this.HiHiAlarm_Pi002.Angle = 1F;
			this.HiHiAlarm_Pi002.ColorFrame = new NxtControl.Drawing.Color("LedFrameColor");
			this.HiHiAlarm_Pi002.DesignMatrix = new NxtControl.Drawing.Matrix2D(1.22874262770817D, 0D, 0D, 1.2287426277081697D, 143.50000000000003D, 23.5D);
			this.HiHiAlarm_Pi002.FrameSize = 33F;
			this.HiHiAlarm_Pi002.IsOnlyInput = true;
			this.HiHiAlarm_Pi002.Name = "HiHiAlarm_Pi002";
			propertyDictionary2.Add("Color", new NxtControl.Drawing.Color("LedFalseColor"));
			propertyDictionary3.Add("Color", new NxtControl.Drawing.BlinkColor("SE.HwCommon.DevLEDOrangeFlash"));
			this.HiHiAlarm_Pi002.Ranges.Clear();
			this.HiHiAlarm_Pi002.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(false, propertyDictionary2));
			this.HiHiAlarm_Pi002.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(true, propertyDictionary3));
			propertyDictionary1.Add("Color", new NxtControl.Drawing.Color("LedFalseColor"));
			this.HiHiAlarm_Pi002.Ranges.DefaultPropertyValues = propertyDictionary1;
			this.HiHiAlarm_Pi002.TagName = "";
			this.HiHiAlarm_Pi002.EndInit();
			// 
			// HiAlarm_Pi002
			// 
			this.HiAlarm_Pi002.BeginInit();
			this.HiAlarm_Pi002.Angle = 1F;
			this.HiAlarm_Pi002.ColorFrame = new NxtControl.Drawing.Color("LedFrameColor");
			this.HiAlarm_Pi002.DesignMatrix = new NxtControl.Drawing.Matrix2D(1.22874262770817D, 0D, 0D, 1.2287426277081694D, 143.5D, 49.499999999999993D);
			this.HiAlarm_Pi002.FrameSize = 33F;
			this.HiAlarm_Pi002.IsOnlyInput = true;
			this.HiAlarm_Pi002.Name = "HiAlarm_Pi002";
			propertyDictionary5.Add("Color", new NxtControl.Drawing.Color("LedFalseColor"));
			propertyDictionary6.Add("Color", new NxtControl.Drawing.BlinkColor("SE.HwCommon.DevLEDOrangeFlash"));
			this.HiAlarm_Pi002.Ranges.Clear();
			this.HiAlarm_Pi002.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(false, propertyDictionary5));
			this.HiAlarm_Pi002.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(true, propertyDictionary6));
			propertyDictionary4.Add("Color", new NxtControl.Drawing.Color("LedFalseColor"));
			this.HiAlarm_Pi002.Ranges.DefaultPropertyValues = propertyDictionary4;
			this.HiAlarm_Pi002.TagName = "HiAlarm_Pi002";
			this.HiAlarm_Pi002.EndInit();
			// 
			// LoAlarm_Pi002
			// 
			this.LoAlarm_Pi002.BeginInit();
			this.LoAlarm_Pi002.Angle = 1F;
			this.LoAlarm_Pi002.ColorFrame = new NxtControl.Drawing.Color("LedFrameColor");
			this.LoAlarm_Pi002.DesignMatrix = new NxtControl.Drawing.Matrix2D(1.22874262770817D, 0D, 0D, 1.22874262770817D, 143.5D, 73.5D);
			this.LoAlarm_Pi002.FrameSize = 33F;
			this.LoAlarm_Pi002.IsOnlyInput = true;
			this.LoAlarm_Pi002.Name = "LoAlarm_Pi002";
			propertyDictionary8.Add("Color", new NxtControl.Drawing.Color("LedFalseColor"));
			propertyDictionary9.Add("Color", new NxtControl.Drawing.BlinkColor("SE.HwCommon.DevLEDOrangeFlash"));
			this.LoAlarm_Pi002.Ranges.Clear();
			this.LoAlarm_Pi002.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(false, propertyDictionary8));
			this.LoAlarm_Pi002.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(true, propertyDictionary9));
			propertyDictionary7.Add("Color", new NxtControl.Drawing.Color("LedFalseColor"));
			this.LoAlarm_Pi002.Ranges.DefaultPropertyValues = propertyDictionary7;
			this.LoAlarm_Pi002.TagName = "LoAlarm_Pi002";
			this.LoAlarm_Pi002.EndInit();
			// 
			// LoLoAlarm_Pi002
			// 
			this.LoLoAlarm_Pi002.BeginInit();
			this.LoLoAlarm_Pi002.Angle = 1F;
			this.LoLoAlarm_Pi002.ColorFrame = new NxtControl.Drawing.Color("LedFrameColor");
			this.LoLoAlarm_Pi002.DesignMatrix = new NxtControl.Drawing.Matrix2D(1.22874262770817D, 0D, 0D, 1.2287426277081686D, 143.50000000000003D, 97.499999999999972D);
			this.LoLoAlarm_Pi002.FrameSize = 33F;
			this.LoLoAlarm_Pi002.IsOnlyInput = true;
			this.LoLoAlarm_Pi002.Name = "LoLoAlarm_Pi002";
			propertyDictionary11.Add("Color", new NxtControl.Drawing.Color("LedFalseColor"));
			propertyDictionary12.Add("Color", new NxtControl.Drawing.BlinkColor("SE.HwCommon.DevLEDOrangeFlash"));
			this.LoLoAlarm_Pi002.Ranges.Clear();
			this.LoLoAlarm_Pi002.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(false, propertyDictionary11));
			this.LoLoAlarm_Pi002.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(true, propertyDictionary12));
			propertyDictionary10.Add("Color", new NxtControl.Drawing.Color("LedFalseColor"));
			this.LoLoAlarm_Pi002.Ranges.DefaultPropertyValues = propertyDictionary10;
			this.LoLoAlarm_Pi002.TagName = "LoLoAlarm_Pi002";
			this.LoLoAlarm_Pi002.EndInit();
			// 
			// AlarmFailure_Pi002
			// 
			this.AlarmFailure_Pi002.BeginInit();
			this.AlarmFailure_Pi002.Angle = 1F;
			this.AlarmFailure_Pi002.ColorFrame = new NxtControl.Drawing.Color("LedFrameColor");
			this.AlarmFailure_Pi002.DesignMatrix = new NxtControl.Drawing.Matrix2D(1.22874262770817D, 0D, 0D, 1.2287426277081686D, 143.5D, 121.49999999999997D);
			this.AlarmFailure_Pi002.FrameSize = 33F;
			this.AlarmFailure_Pi002.IsOnlyInput = true;
			this.AlarmFailure_Pi002.Name = "AlarmFailure_Pi002";
			propertyDictionary14.Add("Color", new NxtControl.Drawing.Color("LedFalseColor"));
			propertyDictionary15.Add("Color", new NxtControl.Drawing.BlinkColor("SE.HwCommon.DevLEDOrangeFlash"));
			this.AlarmFailure_Pi002.Ranges.Clear();
			this.AlarmFailure_Pi002.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(false, propertyDictionary14));
			this.AlarmFailure_Pi002.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(true, propertyDictionary15));
			propertyDictionary13.Add("Color", new NxtControl.Drawing.Color("LedFalseColor"));
			this.AlarmFailure_Pi002.Ranges.DefaultPropertyValues = propertyDictionary13;
			this.AlarmFailure_Pi002.TagName = "AlarmFailure_Pi002";
			this.AlarmFailure_Pi002.EndInit();
			// 
			// freeText1
			// 
			this.freeText1.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText1.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.freeText1.Location = new NxtControl.Drawing.PointF(8D, 18D);
			this.freeText1.Name = "freeText1";
			this.freeText1.Text = "High High Alarm :";
			// 
			// freeText2
			// 
			this.freeText2.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText2.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.freeText2.Location = new NxtControl.Drawing.PointF(8D, 42D);
			this.freeText2.Name = "freeText2";
			this.freeText2.Text = "High Alarm :";
			// 
			// freeText3
			// 
			this.freeText3.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText3.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.freeText3.Location = new NxtControl.Drawing.PointF(8D, 66D);
			this.freeText3.Name = "freeText3";
			this.freeText3.Text = "Low Alarm :";
			// 
			// freeText4
			// 
			this.freeText4.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText4.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.freeText4.Location = new NxtControl.Drawing.PointF(8D, 90D);
			this.freeText4.Name = "freeText4";
			this.freeText4.Text = "Low Low Alarm :";
			// 
			// freeText5
			// 
			this.freeText5.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText5.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.freeText5.Location = new NxtControl.Drawing.PointF(8D, 114D);
			this.freeText5.Name = "freeText5";
			this.freeText5.Text = "Alarm Failure :";
			// 
			// sPI002
			// 
			this.Name = "sDefault";
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.HiHiAlarm_Pi002,
			this.HiAlarm_Pi002,
			this.LoAlarm_Pi002,
			this.LoLoAlarm_Pi002,
			this.AlarmFailure_Pi002,
			this.freeText1,
			this.freeText2,
			this.freeText3,
			this.freeText4,
			this.freeText5});
			this.SymbolSize = new System.Drawing.Size(600, 400);

		}
		private NxtControl.GuiFramework.FreeText freeText1;
		private NxtControl.GuiFramework.FreeText freeText2;
		private NxtControl.GuiFramework.FreeText freeText3;
		private NxtControl.GuiFramework.FreeText freeText4;
		private NxtControl.GuiFramework.FreeText freeText5;
		private System.HMI.Symbols.Base.Led<bool> HiHiAlarm_Pi002;
		private System.HMI.Symbols.Base.Led<bool> HiAlarm_Pi002;
		private System.HMI.Symbols.Base.Led<bool> LoAlarm_Pi002;
		private System.HMI.Symbols.Base.Led<bool> LoLoAlarm_Pi002;
		private System.HMI.Symbols.Base.Led<bool> AlarmFailure_Pi002;
		#endregion
	}
}
