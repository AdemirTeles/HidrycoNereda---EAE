/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 6/5/2026
 * Time: 3:20 PM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.AnalogInput
{
	/// <summary>
	/// Summary description for sDefault.
	/// </summary>
	partial class sPvBarHoz
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary2 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary1 = new NxtControl.GuiFramework.PropertyDictionary();
			this.OpenFp = new NxtControl.GuiFramework.Rectangle();
			this.Unit = new NxtControl.GuiFramework.FreeText();
			this.Pv = new System.HMI.Symbols.Base.FreeText<float>();
			this.SensorName = new NxtControl.GuiFramework.FreeText();
			this.alarmSAFrame1 = new NxtControl.GuiFramework.AlarmFrame();
			this.ShowLevel = new NxtControl.GuiFramework.Rectangle();
			this.rectangle1 = new NxtControl.GuiFramework.Rectangle();
			this.ChFailure = new NxtControl.GuiFramework.FreeText();
			((System.ComponentModel.ISupportInitialize)(this.alarmSAFrame1)).BeginInit();
			// 
			// OpenFp
			// 
			this.OpenFp.Bounds = new NxtControl.Drawing.RectF(((float)(16D)), ((float)(32D)), ((float)(96D)), ((float)(40D)));
			this.OpenFp.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("transparent"));
			this.OpenFp.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.OpenFp.Name = "OpenFp";
			this.OpenFp.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("fpDefault", NxtControl.GuiFramework.MouseButtonType.Click));
			this.OpenFp.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// Unit
			// 
			this.Unit.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.Unit.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.Unit.Location = new NxtControl.Drawing.PointF(80D, 56D);
			this.Unit.Name = "Unit";
			this.Unit.Text = "%";
			// 
			// Pv
			// 
			this.Pv.BeginInit();
			this.Pv.DecimalPlacesCount = ((uint)(2u));
			this.Pv.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 16D, 56D);
			this.Pv.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.Pv.IsOnlyInput = true;
			this.Pv.Name = "Pv";
			this.Pv.Ranges.Clear();
			this.Pv.Ranges.Add(new NxtControl.GuiFramework.Range<float>(null, true, null, true, propertyDictionary2));
			propertyDictionary1.Add("Text", "${Value}");
			propertyDictionary1.Add("TextColor", new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			this.Pv.Ranges.DefaultPropertyValues = propertyDictionary1;
			this.Pv.TagName = "Pv";
			this.Pv.TextAngle = 0F;
			this.Pv.EndInit();
			// 
			// SensorName
			// 
			this.SensorName.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.SensorName.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.SensorName.Location = new NxtControl.Drawing.PointF(16D, 12D);
			this.SensorName.Name = "SensorName";
			this.SensorName.Text = "Name";
			// 
			// alarmSAFrame1
			// 
			this.alarmSAFrame1.Bounds = new NxtControl.Drawing.RectF(((float)(16D)), ((float)(32D)), ((float)(96D)), ((float)(16D)));
			this.alarmSAFrame1.FrameWidth = ((uint)(2u));
			this.alarmSAFrame1.Name = "alarmSAFrame1";
			this.alarmSAFrame1.Radius = 5D;
			// 
			// ShowLevel
			// 
			this.ShowLevel.Bounds = new NxtControl.Drawing.RectF(((float)(18D)), ((float)(34D)), ((float)(92D)), ((float)(12D)));
			this.ShowLevel.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(61)), ((byte)(205)), ((byte)(88))));
			this.ShowLevel.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.ShowLevel.Name = "ShowLevel";
			this.ShowLevel.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// rectangle1
			// 
			this.rectangle1.Bounds = new NxtControl.Drawing.RectF(((float)(16D)), ((float)(32D)), ((float)(96D)), ((float)(16D)));
			this.rectangle1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("transparent"));
			this.rectangle1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle1.Name = "rectangle1";
			// 
			// ChFailure
			// 
			this.ChFailure.Color = new NxtControl.Drawing.BlinkColor("SE.HwCommon.DevLEDOrangeRedFlash");
			this.ChFailure.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.ChFailure.Location = new NxtControl.Drawing.PointF(12D, 72D);
			this.ChFailure.Name = "ChFailure";
			this.ChFailure.Text = "I/O Channel Failure";
			// 
			// sPvBarHoz
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.Unit,
			this.Pv,
			this.SensorName,
			this.ShowLevel,
			this.rectangle1,
			this.alarmSAFrame1,
			this.OpenFp,
			this.ChFailure});
			this.SymbolSize = new System.Drawing.Size(160, 96);
			((System.ComponentModel.ISupportInitialize)(this.alarmSAFrame1)).EndInit();

		}
		private NxtControl.GuiFramework.Rectangle OpenFp;
		private NxtControl.GuiFramework.FreeText Unit;
		private System.HMI.Symbols.Base.FreeText<float> Pv;
		private NxtControl.GuiFramework.FreeText SensorName;
		private NxtControl.GuiFramework.AlarmFrame alarmSAFrame1;
		private NxtControl.GuiFramework.Rectangle ShowLevel;
		private NxtControl.GuiFramework.Rectangle rectangle1;
		private NxtControl.GuiFramework.FreeText ChFailure;
		#endregion
	}
}
