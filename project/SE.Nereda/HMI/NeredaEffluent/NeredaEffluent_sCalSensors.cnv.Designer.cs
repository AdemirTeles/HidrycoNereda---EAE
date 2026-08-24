/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 6/29/2026
 * Time: 9:58 AM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.NeredaEffluent
{
	/// <summary>
	/// Summary description for sCalSensors.
	/// </summary>
	partial class sCalSensors
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.rectangle3 = new NxtControl.GuiFramework.Rectangle();
			this.rectangle1 = new NxtControl.GuiFramework.Rectangle();
			this.freeText1 = new NxtControl.GuiFramework.FreeText();
			this.freeText2 = new NxtControl.GuiFramework.FreeText();
			this.sDisplayPv21 = new SE.Nereda.Symbols.AnalogInput.sDisplayPv2();
			this.sDefault1 = new SE.Nereda.Symbols.AnalogInput_Status.sDefault();
			this.sDisplayPv22 = new SE.Nereda.Symbols.AnalogInput.sDisplayPv2();
			this.sDefault2 = new SE.Nereda.Symbols.AnalogInput_Status.sDefault();
			// 
			// rectangle3
			// 
			this.rectangle3.Bounds = new NxtControl.Drawing.RectF(((float)(224D)), ((float)(32D)), ((float)(24D)), ((float)(32D)));
			this.rectangle3.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(114)), ((byte)(114)), ((byte)(114))));
			this.rectangle3.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle3.Name = "rectangle3";
			// 
			// rectangle1
			// 
			this.rectangle1.Bounds = new NxtControl.Drawing.RectF(((float)(16D)), ((float)(32D)), ((float)(24D)), ((float)(32D)));
			this.rectangle1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(114)), ((byte)(114)), ((byte)(114))));
			this.rectangle1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle1.Name = "rectangle1";
			// 
			// freeText1
			// 
			this.freeText1.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText1.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText1.Location = new NxtControl.Drawing.PointF(8D, 8D);
			this.freeText1.Name = "freeText1";
			this.freeText1.Text = "Level measurement Calamity";
			// 
			// freeText2
			// 
			this.freeText2.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText2.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText2.Location = new NxtControl.Drawing.PointF(216D, 8D);
			this.freeText2.Name = "freeText2";
			this.freeText2.Text = "Ambient Temperature";
			// 
			// sDisplayPv21
			// 
			this.sDisplayPv21.BeginInit();
			this.sDisplayPv21._iSensorName = "46 2 AP LT 95 001";
			this.sDisplayPv21._iUnit = "m";
			this.sDisplayPv21.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 32D, 24D);
			this.sDisplayPv21.Name = "sDisplayPv21";
			this.sDisplayPv21.SecurityToken = ((uint)(4294967295u));
			this.sDisplayPv21.TagName = "Sensors.NVPP_46_2_AP_LT_95_001";
			this.sDisplayPv21.EndInit();
			// 
			// sDefault1
			// 
			this.sDefault1.BeginInit();
			this.sDefault1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 8D, 24D);
			this.sDefault1.Name = "sDefault1";
			this.sDefault1.SecurityToken = ((uint)(4294967295u));
			this.sDefault1.TagName = "Sensors.NVPP_46_2_AP_LT_95_001_Status";
			this.sDefault1.EndInit();
			// 
			// sDisplayPv22
			// 
			this.sDisplayPv22.BeginInit();
			this.sDisplayPv22._iSensorName = "NVPP 001 the 002";
			this.sDisplayPv22._iUnit = "°C";
			this.sDisplayPv22.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 240D, 24D);
			this.sDisplayPv22.Name = "sDisplayPv22";
			this.sDisplayPv22.SecurityToken = ((uint)(4294967295u));
			this.sDisplayPv22.TagName = "Sensors.NVPP_001_the_002";
			this.sDisplayPv22.EndInit();
			// 
			// sDefault2
			// 
			this.sDefault2.BeginInit();
			this.sDefault2.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 216D, 24D);
			this.sDefault2.Name = "sDefault2";
			this.sDefault2.SecurityToken = ((uint)(4294967295u));
			this.sDefault2.TagName = "Sensors.NVPP_001_the_002_Status";
			this.sDefault2.EndInit();
			// 
			// sCalSensors
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.rectangle3,
			this.rectangle1,
			this.freeText1,
			this.freeText2,
			this.sDisplayPv21,
			this.sDefault1,
			this.sDisplayPv22,
			this.sDefault2});
			this.SymbolSize = new System.Drawing.Size(472, 152);

		}
		private NxtControl.GuiFramework.Rectangle rectangle3;
		private NxtControl.GuiFramework.Rectangle rectangle1;
		private NxtControl.GuiFramework.FreeText freeText1;
		private NxtControl.GuiFramework.FreeText freeText2;
		private SE.Nereda.Symbols.AnalogInput.sDisplayPv2 sDisplayPv21;
		private SE.Nereda.Symbols.AnalogInput_Status.sDefault sDefault1;
		private SE.Nereda.Symbols.AnalogInput.sDisplayPv2 sDisplayPv22;
		private SE.Nereda.Symbols.AnalogInput_Status.sDefault sDefault2;
		#endregion
	}
}
