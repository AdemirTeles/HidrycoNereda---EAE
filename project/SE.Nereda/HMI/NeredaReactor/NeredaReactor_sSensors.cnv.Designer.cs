/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 6/10/2026
 * Time: 3:37 PM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.NeredaReactor
{
	/// <summary>
	/// Summary description for sSensor.
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
			this.sQT002 = new SE.Nereda.Symbols.AnalogInput.sDisplayPv2();
			this.sDefault1 = new SE.Nereda.Symbols.AnalogInput_Status.sDefault();
			this.sQT003 = new SE.Nereda.Symbols.AnalogInput.sDisplayPv2();
			this.sDefault2 = new SE.Nereda.Symbols.AnalogInput_Status.sDefault();
			this.sQT010 = new SE.Nereda.Symbols.AnalogInput.sDisplayPv2();
			this.sDefault3 = new SE.Nereda.Symbols.AnalogInput_Status.sDefault();
			this.sLT001 = new SE.Nereda.Symbols.AnalogInput.sDisplayPv2();
			this.sDefault4 = new SE.Nereda.Symbols.AnalogInput_Status.sDefault();
			this.rectangle1 = new NxtControl.GuiFramework.Rectangle();
			this.rectangle2 = new NxtControl.GuiFramework.Rectangle();
			this.rectangle3 = new NxtControl.GuiFramework.Rectangle();
			this.rectangle4 = new NxtControl.GuiFramework.Rectangle();
			this.freeText1 = new NxtControl.GuiFramework.FreeText();
			this.freeText2 = new NxtControl.GuiFramework.FreeText();
			this.freeText3 = new NxtControl.GuiFramework.FreeText();
			this.freeText4 = new NxtControl.GuiFramework.FreeText();
			// 
			// sQT002
			// 
			this.sQT002.BeginInit();
			this.sQT002._iSensorName = "NVPP 001 41QT1002";
			this.sQT002._iUnit = "°C";
			this.sQT002.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 32D, 24D);
			this.sQT002.Name = "sQT002";
			this.sQT002.SecurityToken = ((uint)(4294967295u));
			this.sQT002.TagName = "Sensors.TemperatureMeasurement";
			this.sQT002.EndInit();
			// 
			// sDefault1
			// 
			this.sDefault1.BeginInit();
			this.sDefault1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 8D, 24D);
			this.sDefault1.Name = "sDefault1";
			this.sDefault1.SecurityToken = ((uint)(4294967295u));
			this.sDefault1.TagName = "Sensors.TemperatureMeasurement_Status";
			this.sDefault1.EndInit();
			// 
			// sQT003
			// 
			this.sQT003.BeginInit();
			this.sQT003._iSensorName = "NVPP 001 41QT1003";
			this.sQT003._iUnit = "mg/l";
			this.sQT003.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 240D, 24D);
			this.sQT003.Name = "sQT003";
			this.sQT003.SecurityToken = ((uint)(4294967295u));
			this.sQT003.TagName = "Sensors.OxygenMeasurementReactor";
			this.sQT003.EndInit();
			// 
			// sDefault2
			// 
			this.sDefault2.BeginInit();
			this.sDefault2.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 216D, 24D);
			this.sDefault2.Name = "sDefault2";
			this.sDefault2.SecurityToken = ((uint)(4294967295u));
			this.sDefault2.TagName = "Sensors.OxygenMeasurementReactor_Status";
			this.sDefault2.EndInit();
			// 
			// sQT010
			// 
			this.sQT010.BeginInit();
			this.sQT010._iSensorName = "NVPP 001 41QT1010";
			this.sQT010._iUnit = "";
			this.sQT010.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 32D, 96D);
			this.sQT010.Name = "sQT010";
			this.sQT010.SecurityToken = ((uint)(4294967295u));
			this.sQT010.TagName = "Sensors.pHMeasurementReactor";
			this.sQT010.EndInit();
			// 
			// sDefault3
			// 
			this.sDefault3.BeginInit();
			this.sDefault3.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 8D, 96D);
			this.sDefault3.Name = "sDefault3";
			this.sDefault3.SecurityToken = ((uint)(4294967295u));
			this.sDefault3.TagName = "Sensors.pHMeasurementReactor_Status";
			this.sDefault3.EndInit();
			// 
			// sLT001
			// 
			this.sLT001.BeginInit();
			this.sLT001._iSensorName = "NVPP 001 lt 004";
			this.sLT001._iUnit = "m";
			this.sLT001.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 240D, 96D);
			this.sLT001.Name = "sLT001";
			this.sLT001.SecurityToken = ((uint)(4294967295u));
			this.sLT001.TagName = "Sensors.LevelMeasurementReactor";
			this.sLT001.EndInit();
			// 
			// sDefault4
			// 
			this.sDefault4.BeginInit();
			this.sDefault4.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 216D, 96D);
			this.sDefault4.Name = "sDefault4";
			this.sDefault4.SecurityToken = ((uint)(4294967295u));
			this.sDefault4.TagName = "Sensors.LevelMeasurementReactor_Status";
			this.sDefault4.EndInit();
			// 
			// rectangle1
			// 
			this.rectangle1.Bounds = new NxtControl.Drawing.RectF(((float)(16D)), ((float)(32D)), ((float)(24D)), ((float)(32D)));
			this.rectangle1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(114)), ((byte)(114)), ((byte)(114))));
			this.rectangle1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle1.Name = "rectangle1";
			// 
			// rectangle2
			// 
			this.rectangle2.Bounds = new NxtControl.Drawing.RectF(((float)(16D)), ((float)(104D)), ((float)(24D)), ((float)(32D)));
			this.rectangle2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(114)), ((byte)(114)), ((byte)(114))));
			this.rectangle2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle2.Name = "rectangle2";
			// 
			// rectangle3
			// 
			this.rectangle3.Bounds = new NxtControl.Drawing.RectF(((float)(224D)), ((float)(32D)), ((float)(24D)), ((float)(32D)));
			this.rectangle3.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(114)), ((byte)(114)), ((byte)(114))));
			this.rectangle3.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle3.Name = "rectangle3";
			// 
			// rectangle4
			// 
			this.rectangle4.Bounds = new NxtControl.Drawing.RectF(((float)(224D)), ((float)(104D)), ((float)(24D)), ((float)(32D)));
			this.rectangle4.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(114)), ((byte)(114)), ((byte)(114))));
			this.rectangle4.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle4.Name = "rectangle4";
			// 
			// freeText1
			// 
			this.freeText1.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText1.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText1.Location = new NxtControl.Drawing.PointF(8D, 8D);
			this.freeText1.Name = "freeText1";
			this.freeText1.Text = "Temperature measurement reactor";
			// 
			// freeText2
			// 
			this.freeText2.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText2.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText2.Location = new NxtControl.Drawing.PointF(216D, 8D);
			this.freeText2.Name = "freeText2";
			this.freeText2.Text = "Oxygen measurement reactor";
			// 
			// freeText3
			// 
			this.freeText3.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText3.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText3.Location = new NxtControl.Drawing.PointF(8D, 80D);
			this.freeText3.Name = "freeText3";
			this.freeText3.Text = "pH measurement reactor";
			// 
			// freeText4
			// 
			this.freeText4.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText4.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText4.Location = new NxtControl.Drawing.PointF(216D, 80D);
			this.freeText4.Name = "freeText4";
			this.freeText4.Text = "Level measurement reactor";
			// 
			// sSensors
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.rectangle4,
			this.rectangle3,
			this.rectangle2,
			this.rectangle1,
			this.sQT002,
			this.sDefault1,
			this.sQT003,
			this.sDefault2,
			this.sQT010,
			this.sDefault3,
			this.sLT001,
			this.sDefault4,
			this.freeText1,
			this.freeText2,
			this.freeText3,
			this.freeText4});
			this.SymbolSize = new System.Drawing.Size(400, 152);

		}
		private SE.Nereda.Symbols.AnalogInput.sDisplayPv2 sQT002;
		private SE.Nereda.Symbols.AnalogInput_Status.sDefault sDefault1;
		private SE.Nereda.Symbols.AnalogInput.sDisplayPv2 sQT003;
		private SE.Nereda.Symbols.AnalogInput_Status.sDefault sDefault2;
		private SE.Nereda.Symbols.AnalogInput.sDisplayPv2 sQT010;
		private SE.Nereda.Symbols.AnalogInput_Status.sDefault sDefault3;
		private SE.Nereda.Symbols.AnalogInput.sDisplayPv2 sLT001;
		private SE.Nereda.Symbols.AnalogInput_Status.sDefault sDefault4;
		private NxtControl.GuiFramework.Rectangle rectangle1;
		private NxtControl.GuiFramework.Rectangle rectangle2;
		private NxtControl.GuiFramework.Rectangle rectangle3;
		private NxtControl.GuiFramework.Rectangle rectangle4;
		private NxtControl.GuiFramework.FreeText freeText1;
		private NxtControl.GuiFramework.FreeText freeText2;
		private NxtControl.GuiFramework.FreeText freeText3;
		private NxtControl.GuiFramework.FreeText freeText4;
		#endregion
	}
}
