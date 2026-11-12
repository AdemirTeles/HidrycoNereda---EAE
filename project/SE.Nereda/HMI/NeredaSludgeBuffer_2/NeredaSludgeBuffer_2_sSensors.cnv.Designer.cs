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

namespace SE.Nereda.Symbols.NeredaSludgeBuffer_2
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
			this.rectangle2 = new NxtControl.GuiFramework.Rectangle();
			this.rectangle1 = new NxtControl.GuiFramework.Rectangle();
			this.sQT002 = new SE.Nereda.Symbols.AnalogInput.sDisplayPv2();
			this.sDefault1 = new SE.Nereda.Symbols.AnalogInput_Status.sDefault();
			this.sQT003 = new SE.Nereda.Symbols.AnalogInput.sDisplayPv2();
			this.sQT004 = new SE.Nereda.Symbols.AnalogInput.sDisplayPv2();
			this.freeText4 = new NxtControl.GuiFramework.FreeText();
			this.freeText5 = new NxtControl.GuiFramework.FreeText();
			this.sDefault2 = new SE.Nereda.Symbols.AnalogInput_Status.sDefault();
			this.sQT010 = new SE.Nereda.Symbols.AnalogInput.sDisplayPv2();
			this.sDefault3 = new SE.Nereda.Symbols.AnalogInput_Status.sDefault();
			this.freeText1 = new NxtControl.GuiFramework.FreeText();
			this.freeText2 = new NxtControl.GuiFramework.FreeText();
			this.freeText3 = new NxtControl.GuiFramework.FreeText();
			this.sDIn21 = new SE.Nereda.Symbols.DigitalInput.sDIn2();
			// 
			// rectangle3
			// 
			this.rectangle3.Bounds = new NxtControl.Drawing.RectF(((float)(240D)), ((float)(32D)), ((float)(24D)), ((float)(32D)));
			this.rectangle3.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(114)), ((byte)(114)), ((byte)(114))));
			this.rectangle3.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle3.Name = "rectangle3";
			// 
			// rectangle2
			// 
			this.rectangle2.Bounds = new NxtControl.Drawing.RectF(((float)(16D)), ((float)(104D)), ((float)(24D)), ((float)(32D)));
			this.rectangle2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(114)), ((byte)(114)), ((byte)(114))));
			this.rectangle2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle2.Name = "rectangle2";
			// 
			// rectangle1
			// 
			this.rectangle1.Bounds = new NxtControl.Drawing.RectF(((float)(16D)), ((float)(32D)), ((float)(24D)), ((float)(32D)));
			this.rectangle1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(114)), ((byte)(114)), ((byte)(114))));
			this.rectangle1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle1.Name = "rectangle1";
			// 
			// sQT002
			// 
			this.sQT002.BeginInit();
			this.sQT002._iSensorName = "49QT0003 S\u00f3lidos descarte";
			this.sQT002._iUnit = "";
			this.sQT002.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 32D, 24D);
			this.sQT002.Name = "sQT002";
			this.sQT002.SecurityToken = ((uint)(4294967295u));
			this.sQT002.TagName = "Sensors.DrySolidDischargeSludge";
			this.sQT002.EndInit();
			// 
			// sDefault1
			// 
			this.sDefault1.BeginInit();
			this.sDefault1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 8D, 24D);
			this.sDefault1.Name = "sDefault1";
			this.sDefault1.SecurityToken = ((uint)(4294967295u));
			this.sDefault1.TagName = "Sensors.SB_Flow_Sensor_Status";
			this.sDefault1.EndInit();
			// 
			// sQT003
			// 
			this.sQT003.BeginInit();
			this.sQT003._iSensorName = "49FT0004 Vaz\u00e3o descarte";
			this.sQT003._iUnit = "m\u00b3/h";
			this.sQT003.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 256D, 24D);
			this.sQT003.Name = "sQT003";
			this.sQT003.SecurityToken = ((uint)(4294967295u));
			this.sQT003.TagName = "Sensors.FlowMeasurementDischargeSludge";
			this.sQT003.EndInit();
			// 
			// sDefault2
			// 
			this.sDefault2.BeginInit();
			this.sDefault2.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 232D, 24D);
			this.sDefault2.Name = "sDefault2";
			this.sDefault2.SecurityToken = ((uint)(4294967295u));
			this.sDefault2.TagName = "Sensors.SB_Flow_Sensor_Status1";
			this.sDefault2.EndInit();
			// 
			// sQT010
			// 
			this.sQT010.BeginInit();
			this.sQT010._iSensorName = "49LIT0001 N\u00edvel";
			this.sQT010._iUnit = "m";
			this.sQT010.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 32D, 96D);
			this.sQT010.Name = "sQT010";
			this.sQT010.SecurityToken = ((uint)(4294967295u));
			this.sQT010.TagName = "Sensors.LevelMeasurementSludgeBuffer";
			this.sQT010.EndInit();
			// 
			// sDefault3
			// 
			this.sDefault3.BeginInit();
			this.sDefault3.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 8D, 96D);
			this.sDefault3.Name = "sDefault3";
			this.sDefault3.SecurityToken = ((uint)(4294967295u));
			this.sDefault3.TagName = "Sensors.NVPP_001_lt_003_Status";
			this.sDefault3.EndInit();
			// 
			// freeText1
			// 
			this.freeText1.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText1.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText1.Location = new NxtControl.Drawing.PointF(8D, 8D);
			this.freeText1.Name = "freeText1";
			this.freeText1.Text = "S\u00f3lidos no descarte";
			// 
			// sQT004 (turbidez do 49QT0003)
			// 
			this.sQT004.BeginInit();
			this.sQT004._iSensorName = "49QT0003 Turbidez";
			this.sQT004._iUnit = "";
			this.sQT004.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 480D, 24D);
			this.sQT004.Name = "sQT004";
			this.sQT004.SecurityToken = ((uint)(4294967295u));
			this.sQT004.TagName = "Sensors.TurbidityDischargeSludge";
			this.sQT004.EndInit();
			// 
			// freeText4
			// 
			this.freeText4.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText4.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText4.Location = new NxtControl.Drawing.PointF(456D, 8D);
			this.freeText4.Name = "freeText4";
			this.freeText4.Text = "Turbidez no descarte";
			// 
			// freeText5
			// 
			this.freeText5.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText5.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText5.Location = new NxtControl.Drawing.PointF(232D, 80D);
			this.freeText5.Name = "freeText5";
			this.freeText5.Text = "N\u00edvel alto do buffer";
			// 
			// freeText2
			// 
			this.freeText2.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText2.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText2.Location = new NxtControl.Drawing.PointF(232D, 8D);
			this.freeText2.Name = "freeText2";
			this.freeText2.Text = "Vaz\u00e3o de descarte";
			// 
			// freeText3
			// 
			this.freeText3.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText3.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText3.Location = new NxtControl.Drawing.PointF(8D, 80D);
			this.freeText3.Name = "freeText3";
			this.freeText3.Text = "N\u00edvel do buffer de lodo";
			// 
			// sDIn21
			// 
			this.sDIn21.BeginInit();
			this.sDIn21.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 256D, 96D);
			this.sDIn21.Name = "sDIn21";
			this.sDIn21.SecurityToken = ((uint)(4294967295u));
			this.sDIn21.TagName = "Sensors.LevelSwitchSludgeBuffer";
			this.sDIn21.EndInit();
			// 
			// sSensors
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.sQT004,
			this.freeText4,
			this.freeText5,
			this.rectangle3,
			this.rectangle2,
			this.rectangle1,
			this.sQT002,
			this.sDefault1,
			this.sQT003,
			this.sDefault2,
			this.sQT010,
			this.sDefault3,
			this.freeText1,
			this.freeText2,
			this.freeText3,
			this.sDIn21});
			this.SymbolSize = new System.Drawing.Size(664, 200);

		}
		private NxtControl.GuiFramework.Rectangle rectangle3;
		private NxtControl.GuiFramework.Rectangle rectangle1;
		private NxtControl.GuiFramework.FreeText freeText1;
		private SE.Nereda.Symbols.AnalogInput.sDisplayPv2 sQT004;
		private NxtControl.GuiFramework.FreeText freeText4;
		private NxtControl.GuiFramework.FreeText freeText5;
		private NxtControl.GuiFramework.FreeText freeText2;
		private NxtControl.GuiFramework.Rectangle rectangle2;
		private SE.Nereda.Symbols.AnalogInput.sDisplayPv2 sQT002;
		private SE.Nereda.Symbols.AnalogInput_Status.sDefault sDefault1;
		private SE.Nereda.Symbols.AnalogInput.sDisplayPv2 sQT003;
		private SE.Nereda.Symbols.AnalogInput_Status.sDefault sDefault2;
		private SE.Nereda.Symbols.AnalogInput.sDisplayPv2 sQT010;
		private SE.Nereda.Symbols.AnalogInput_Status.sDefault sDefault3;
		private NxtControl.GuiFramework.FreeText freeText3;
		private SE.Nereda.Symbols.DigitalInput.sDIn2 sDIn21;
		#endregion
	}
}
