/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 7/4/2026
 * Time: 2:35 PM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.NeredaSludgeBuffer
{
	/// <summary>
	/// Summary description for sSensors.
	/// </summary>
	partial class sSensors
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
			this.sDisplayPv21 = new SE.Nereda.Symbols.AnalogInput.sDisplayPv2();
			this.sDisplayPv22 = new SE.Nereda.Symbols.AnalogInput.sDisplayPv2();
			this.freeText2 = new NxtControl.GuiFramework.FreeText();
			this.sDefault1 = new SE.Nereda.Symbols.AnalogInput_Status.sDefault();
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
			this.freeText1.Text = "Level measurement sludge buffer";
			// 
			// sDisplayPv21
			// 
			this.sDisplayPv21.BeginInit();
			this.sDisplayPv21._iSensorName = "NVPP 001 lt 009";
			this.sDisplayPv21._iUnit = "m";
			this.sDisplayPv21.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 32D, 24D);
			this.sDisplayPv21.Name = "sDisplayPv21";
			this.sDisplayPv21.SecurityToken = ((uint)(4294967295u));
			this.sDisplayPv21.TagName = "Sensors.NVPP_001_lt_003";
			this.sDisplayPv21.EndInit();
			// 
			// sDisplayPv22
			// 
			this.sDisplayPv22.BeginInit();
			this.sDisplayPv22._iSensorName = "SLB Flow Sensors";
			this.sDisplayPv22._iUnit = "m³/h";
			this.sDisplayPv22.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 240D, 24D);
			this.sDisplayPv22.Name = "sDisplayPv22";
			this.sDisplayPv22.SecurityToken = ((uint)(4294967295u));
			this.sDisplayPv22.TagName = "Sensors.SB_Flow_Sensor";
			this.sDisplayPv22.EndInit();
			// 
			// freeText2
			// 
			this.freeText2.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText2.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText2.Location = new NxtControl.Drawing.PointF(216D, 8D);
			this.freeText2.Name = "freeText2";
			this.freeText2.Text = "Flow measurement sludge buffer";
			// 
			// sDefault1
			// 
			this.sDefault1.BeginInit();
			this.sDefault1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 8D, 24D);
			this.sDefault1.Name = "sDefault1";
			this.sDefault1.SecurityToken = ((uint)(4294967295u));
			this.sDefault1.TagName = "Sensors.NVPP_001_lt_003_Status";
			this.sDefault1.EndInit();
			// 
			// sDefault2
			// 
			this.sDefault2.BeginInit();
			this.sDefault2.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 216D, 24D);
			this.sDefault2.Name = "sDefault2";
			this.sDefault2.SecurityToken = ((uint)(4294967295u));
			this.sDefault2.TagName = "Sensors.SB_Flow_Sensor_Status";
			this.sDefault2.EndInit();
			// 
			// sSensors
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.rectangle3,
			this.rectangle1,
			this.freeText1,
			this.sDisplayPv21,
			this.sDisplayPv22,
			this.freeText2,
			this.sDefault1,
			this.sDefault2});
			this.SymbolSize = new System.Drawing.Size(664, 200);

		}
		private NxtControl.GuiFramework.Rectangle rectangle3;
		private NxtControl.GuiFramework.Rectangle rectangle1;
		private NxtControl.GuiFramework.FreeText freeText1;
		private SE.Nereda.Symbols.AnalogInput.sDisplayPv2 sDisplayPv21;
		private SE.Nereda.Symbols.AnalogInput.sDisplayPv2 sDisplayPv22;
		private NxtControl.GuiFramework.FreeText freeText2;
		private SE.Nereda.Symbols.AnalogInput_Status.sDefault sDefault1;
		private SE.Nereda.Symbols.AnalogInput_Status.sDefault sDefault2;
		#endregion
	}
}
