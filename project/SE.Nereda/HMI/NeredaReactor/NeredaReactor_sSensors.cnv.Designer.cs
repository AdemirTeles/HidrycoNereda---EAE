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
			this.sDefault4 = new SE.Nereda.Symbols.AnalogInput_Status.sDefault();
			this.rectangle1 = new NxtControl.GuiFramework.Rectangle();
			this.rectangle2 = new NxtControl.GuiFramework.Rectangle();
			this.rectangle3 = new NxtControl.GuiFramework.Rectangle();
			this.rectangle4 = new NxtControl.GuiFramework.Rectangle();
			this.freeText1 = new NxtControl.GuiFramework.FreeText();
			this.freeText2 = new NxtControl.GuiFramework.FreeText();
			this.freeText3 = new NxtControl.GuiFramework.FreeText();
			this.freeText4 = new NxtControl.GuiFramework.FreeText();
			this.sDisplayPv21 = new SE.Nereda.Symbols.AnalogInput.sDisplayPv2();
			this.rectangle5 = new NxtControl.GuiFramework.Rectangle();
			this.rectangle6 = new NxtControl.GuiFramework.Rectangle();
			this.sDisplayPv22 = new SE.Nereda.Symbols.AnalogInput.sDisplayPv2();
			this.sDefault5 = new SE.Nereda.Symbols.AnalogInput_Status.sDefault();
			this.sDisplayPv23 = new SE.Nereda.Symbols.AnalogInput.sDisplayPv2();
			this.sDefault6 = new SE.Nereda.Symbols.AnalogInput_Status.sDefault();
			this.freeText5 = new NxtControl.GuiFramework.FreeText();
			this.freeText6 = new NxtControl.GuiFramework.FreeText();
			this.rectangle7 = new NxtControl.GuiFramework.Rectangle();
			this.rectangle8 = new NxtControl.GuiFramework.Rectangle();
			this.sDisplayPv24 = new SE.Nereda.Symbols.AnalogInput.sDisplayPv2();
			this.sDefault7 = new SE.Nereda.Symbols.AnalogInput_Status.sDefault();
			this.sDisplayPv25 = new SE.Nereda.Symbols.AnalogInput.sDisplayPv2();
			this.sDefault8 = new SE.Nereda.Symbols.AnalogInput_Status.sDefault();
			this.freeText7 = new NxtControl.GuiFramework.FreeText();
			this.freeText8 = new NxtControl.GuiFramework.FreeText();
			this.rectangle9 = new NxtControl.GuiFramework.Rectangle();
			this.sDisplayPv26 = new SE.Nereda.Symbols.AnalogInput.sDisplayPv2();
			this.sDefault9 = new SE.Nereda.Symbols.AnalogInput_Status.sDefault();
			this.freeText9 = new NxtControl.GuiFramework.FreeText();
			// 
			// sQT002
			// 
			this.sQT002.BeginInit();
			this.sQT002._iSensorName = "XX_QT_1003";
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
			this.sQT003._iSensorName = "XX_QT_1002";
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
			this.sQT010._iSensorName = "XX_QT_1006";
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
			// sDisplayPv21
			// 
			this.sDisplayPv21.BeginInit();
			this.sDisplayPv21._iSensorName = "XX_QT_10005";
			this.sDisplayPv21._iUnit = "m";
			this.sDisplayPv21.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 240D, 96D);
			this.sDisplayPv21.Name = "sDisplayPv21";
			this.sDisplayPv21.SecurityToken = ((uint)(4294967295u));
			this.sDisplayPv21.TagName = "Sensors.LevelMeasurementReactor";
			this.sDisplayPv21.EndInit();
			// 
			// rectangle5
			// 
			this.rectangle5.Bounds = new NxtControl.Drawing.RectF(((float)(16D)), ((float)(256D)), ((float)(24D)), ((float)(32D)));
			this.rectangle5.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(114)), ((byte)(114)), ((byte)(114))));
			this.rectangle5.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle5.Name = "rectangle5";
			// 
			// rectangle6
			// 
			this.rectangle6.Bounds = new NxtControl.Drawing.RectF(((float)(16D)), ((float)(184D)), ((float)(24D)), ((float)(32D)));
			this.rectangle6.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(114)), ((byte)(114)), ((byte)(114))));
			this.rectangle6.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle6.Name = "rectangle6";
			// 
			// sDisplayPv22
			// 
			this.sDisplayPv22.BeginInit();
			this.sDisplayPv22._iSensorName = "XX_QT_1001";
			this.sDisplayPv22._iUnit = "";
			this.sDisplayPv22.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 32D, 176D);
			this.sDisplayPv22.Name = "sDisplayPv22";
			this.sDisplayPv22.SecurityToken = ((uint)(4294967295u));
			this.sDisplayPv22.TagName = "Sensors.DrySolidsMeasurementReactor";
			this.sDisplayPv22.EndInit();
			// 
			// sDefault5
			// 
			this.sDefault5.BeginInit();
			this.sDefault5.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 8D, 176D);
			this.sDefault5.Name = "sDefault5";
			this.sDefault5.SecurityToken = ((uint)(4294967295u));
			this.sDefault5.TagName = "Sensors.DrySolidsMeasurementReactor_Status";
			this.sDefault5.EndInit();
			// 
			// sDisplayPv23
			// 
			this.sDisplayPv23.BeginInit();
			this.sDisplayPv23._iSensorName = "XX_QT_1007";
			this.sDisplayPv23._iUnit = "";
			this.sDisplayPv23.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 32D, 248D);
			this.sDisplayPv23.Name = "sDisplayPv23";
			this.sDisplayPv23.SecurityToken = ((uint)(4294967295u));
			this.sDisplayPv23.TagName = "Sensors.NH4MeasurementReactor";
			this.sDisplayPv23.EndInit();
			// 
			// sDefault6
			// 
			this.sDefault6.BeginInit();
			this.sDefault6.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 8D, 248D);
			this.sDefault6.Name = "sDefault6";
			this.sDefault6.SecurityToken = ((uint)(4294967295u));
			this.sDefault6.TagName = "Sensors.NH4MeasurementReactor_Status";
			this.sDefault6.EndInit();
			// 
			// freeText5
			// 
			this.freeText5.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText5.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText5.Location = new NxtControl.Drawing.PointF(8D, 160D);
			this.freeText5.Name = "freeText5";
			this.freeText5.Text = "DrySolids measurement reactor";
			// 
			// freeText6
			// 
			this.freeText6.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText6.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText6.Location = new NxtControl.Drawing.PointF(8D, 232D);
			this.freeText6.Name = "freeText6";
			this.freeText6.Text = "NH4 measurement reactor";
			// 
			// rectangle7
			// 
			this.rectangle7.Bounds = new NxtControl.Drawing.RectF(((float)(224D)), ((float)(256D)), ((float)(24D)), ((float)(32D)));
			this.rectangle7.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(114)), ((byte)(114)), ((byte)(114))));
			this.rectangle7.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle7.Name = "rectangle7";
			// 
			// rectangle8
			// 
			this.rectangle8.Bounds = new NxtControl.Drawing.RectF(((float)(224D)), ((float)(184D)), ((float)(24D)), ((float)(32D)));
			this.rectangle8.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(114)), ((byte)(114)), ((byte)(114))));
			this.rectangle8.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle8.Name = "rectangle8";
			// 
			// sDisplayPv24
			// 
			this.sDisplayPv24.BeginInit();
			this.sDisplayPv24._iSensorName = "XX_QT_1004";
			this.sDisplayPv24._iUnit = "";
			this.sDisplayPv24.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 240D, 176D);
			this.sDisplayPv24.Name = "sDisplayPv24";
			this.sDisplayPv24.SecurityToken = ((uint)(4294967295u));
			this.sDisplayPv24.TagName = "Sensors.RedoxMeasurementReactor";
			this.sDisplayPv24.EndInit();
			// 
			// sDefault7
			// 
			this.sDefault7.BeginInit();
			this.sDefault7.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 216D, 176D);
			this.sDefault7.Name = "sDefault7";
			this.sDefault7.SecurityToken = ((uint)(4294967295u));
			this.sDefault7.TagName = "Sensors.RedoxMeasurementReactor_Status";
			this.sDefault7.EndInit();
			// 
			// sDisplayPv25
			// 
			this.sDisplayPv25.BeginInit();
			this.sDisplayPv25._iSensorName = "XX_QT_1008";
			this.sDisplayPv25._iUnit = "";
			this.sDisplayPv25.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 240D, 248D);
			this.sDisplayPv25.Name = "sDisplayPv25";
			this.sDisplayPv25.SecurityToken = ((uint)(4294967295u));
			this.sDisplayPv25.TagName = "Sensors.NO3MeasurementReactor";
			this.sDisplayPv25.EndInit();
			// 
			// sDefault8
			// 
			this.sDefault8.BeginInit();
			this.sDefault8.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 216D, 248D);
			this.sDefault8.Name = "sDefault8";
			this.sDefault8.SecurityToken = ((uint)(4294967295u));
			this.sDefault8.TagName = "Sensors.NO3MeasurementReactor_Status";
			this.sDefault8.EndInit();
			// 
			// freeText7
			// 
			this.freeText7.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText7.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText7.Location = new NxtControl.Drawing.PointF(216D, 160D);
			this.freeText7.Name = "freeText7";
			this.freeText7.Text = "Redox measurement reactor";
			// 
			// freeText8
			// 
			this.freeText8.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText8.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText8.Location = new NxtControl.Drawing.PointF(216D, 232D);
			this.freeText8.Name = "freeText8";
			this.freeText8.Text = "NO3 measurement reactor";
			// 
			// rectangle9
			// 
			this.rectangle9.Bounds = new NxtControl.Drawing.RectF(((float)(120D)), ((float)(328D)), ((float)(24D)), ((float)(32D)));
			this.rectangle9.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(114)), ((byte)(114)), ((byte)(114))));
			this.rectangle9.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle9.Name = "rectangle9";
			// 
			// sDisplayPv26
			// 
			this.sDisplayPv26.BeginInit();
			this.sDisplayPv26._iSensorName = "XX_QT_1009";
			this.sDisplayPv26._iUnit = "";
			this.sDisplayPv26.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 136D, 320D);
			this.sDisplayPv26.Name = "sDisplayPv26";
			this.sDisplayPv26.SecurityToken = ((uint)(4294967295u));
			this.sDisplayPv26.TagName = "Sensors.PO4MeasurementReactor";
			this.sDisplayPv26.EndInit();
			// 
			// sDefault9
			// 
			this.sDefault9.BeginInit();
			this.sDefault9.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 112D, 320D);
			this.sDefault9.Name = "sDefault9";
			this.sDefault9.SecurityToken = ((uint)(4294967295u));
			this.sDefault9.TagName = "Sensors.NH4MeasurementReactor_Status";
			this.sDefault9.EndInit();
			// 
			// freeText9
			// 
			this.freeText9.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText9.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText9.Location = new NxtControl.Drawing.PointF(112D, 304D);
			this.freeText9.Name = "freeText9";
			this.freeText9.Text = "PO4 measurement reactor";
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
			this.sDefault4,
			this.freeText1,
			this.freeText2,
			this.freeText3,
			this.freeText4,
			this.sDisplayPv21,
			this.rectangle5,
			this.rectangle6,
			this.sDisplayPv22,
			this.sDefault5,
			this.sDisplayPv23,
			this.sDefault6,
			this.freeText5,
			this.freeText6,
			this.rectangle7,
			this.rectangle8,
			this.sDisplayPv24,
			this.sDefault7,
			this.sDisplayPv25,
			this.sDefault8,
			this.freeText7,
			this.freeText8,
			this.rectangle9,
			this.sDisplayPv26,
			this.sDefault9,
			this.freeText9});
			this.SymbolSize = new System.Drawing.Size(416, 384);

		}
		private SE.Nereda.Symbols.AnalogInput.sDisplayPv2 sQT002;
		private SE.Nereda.Symbols.AnalogInput_Status.sDefault sDefault1;
		private SE.Nereda.Symbols.AnalogInput.sDisplayPv2 sQT003;
		private SE.Nereda.Symbols.AnalogInput_Status.sDefault sDefault2;
		private SE.Nereda.Symbols.AnalogInput.sDisplayPv2 sQT010;
		private SE.Nereda.Symbols.AnalogInput_Status.sDefault sDefault3;
		private SE.Nereda.Symbols.AnalogInput_Status.sDefault sDefault4;
		private NxtControl.GuiFramework.Rectangle rectangle1;
		private NxtControl.GuiFramework.Rectangle rectangle2;
		private NxtControl.GuiFramework.Rectangle rectangle3;
		private NxtControl.GuiFramework.Rectangle rectangle4;
		private NxtControl.GuiFramework.FreeText freeText1;
		private NxtControl.GuiFramework.FreeText freeText2;
		private NxtControl.GuiFramework.FreeText freeText3;
		private NxtControl.GuiFramework.FreeText freeText4;
		private SE.Nereda.Symbols.AnalogInput.sDisplayPv2 sDisplayPv21;
		private NxtControl.GuiFramework.Rectangle rectangle5;
		private NxtControl.GuiFramework.Rectangle rectangle6;
		private SE.Nereda.Symbols.AnalogInput.sDisplayPv2 sDisplayPv22;
		private SE.Nereda.Symbols.AnalogInput_Status.sDefault sDefault5;
		private SE.Nereda.Symbols.AnalogInput.sDisplayPv2 sDisplayPv23;
		private SE.Nereda.Symbols.AnalogInput_Status.sDefault sDefault6;
		private NxtControl.GuiFramework.FreeText freeText5;
		private NxtControl.GuiFramework.FreeText freeText6;
		private NxtControl.GuiFramework.Rectangle rectangle7;
		private NxtControl.GuiFramework.Rectangle rectangle8;
		private SE.Nereda.Symbols.AnalogInput.sDisplayPv2 sDisplayPv24;
		private SE.Nereda.Symbols.AnalogInput_Status.sDefault sDefault7;
		private SE.Nereda.Symbols.AnalogInput.sDisplayPv2 sDisplayPv25;
		private SE.Nereda.Symbols.AnalogInput_Status.sDefault sDefault8;
		private NxtControl.GuiFramework.FreeText freeText7;
		private NxtControl.GuiFramework.FreeText freeText8;
		private NxtControl.GuiFramework.Rectangle rectangle9;
		private SE.Nereda.Symbols.AnalogInput.sDisplayPv2 sDisplayPv26;
		private SE.Nereda.Symbols.AnalogInput_Status.sDefault sDefault9;
		private NxtControl.GuiFramework.FreeText freeText9;
		#endregion
	}
}
