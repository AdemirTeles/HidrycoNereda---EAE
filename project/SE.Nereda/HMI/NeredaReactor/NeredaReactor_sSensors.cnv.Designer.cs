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
			this.freeText4 = new NxtControl.GuiFramework.FreeText();
			this.freeText3 = new NxtControl.GuiFramework.FreeText();
			this.freeText2 = new NxtControl.GuiFramework.FreeText();
			this.freeText1 = new NxtControl.GuiFramework.FreeText();
			this.rectangle1 = new NxtControl.GuiFramework.Rectangle();
			this.rectangle2 = new NxtControl.GuiFramework.Rectangle();
			this.rectangle3 = new NxtControl.GuiFramework.Rectangle();
			this.rectangle4 = new NxtControl.GuiFramework.Rectangle();
			this.sDisplayPv21 = new SE.Nereda.Symbols.AnalogInput.sDisplayPv2();
			this.sDefault4 = new SE.Nereda.Symbols.AnalogInput_Status.sDefault();
			this.sDisplayPv22 = new SE.Nereda.Symbols.AnalogInput.sDisplayPv2();
			this.sDisplayPv23 = new SE.Nereda.Symbols.AnalogInput.sDisplayPv2();
			this.sDisplayPv24 = new SE.Nereda.Symbols.AnalogInput.sDisplayPv2();
			this.rectangle5 = new NxtControl.GuiFramework.Rectangle();
			this.sDefault1 = new SE.Nereda.Symbols.AnalogInput_Status.sDefault();
			this.sDisplayPv25 = new SE.Nereda.Symbols.AnalogInput.sDisplayPv2();
			this.sDefault2 = new SE.Nereda.Symbols.AnalogInput_Status.sDefault();
			this.DrySolids = new NxtControl.GuiFramework.FreeText();
			this.sDisplayPv26 = new SE.Nereda.Symbols.AnalogInput.sDisplayPv2();
			this.freeText5 = new NxtControl.GuiFramework.FreeText();
			this.sDisplayPv27 = new SE.Nereda.Symbols.AnalogInput.sDisplayPv2();
			this.sDisplayPv28 = new SE.Nereda.Symbols.AnalogInput.sDisplayPv2();
			this.sDisplayPv29 = new SE.Nereda.Symbols.AnalogInput.sDisplayPv2();
			this.freeText6 = new NxtControl.GuiFramework.FreeText();
			this.freeText7 = new NxtControl.GuiFramework.FreeText();
			this.freeText8 = new NxtControl.GuiFramework.FreeText();
			// 
			// freeText4
			// 
			this.freeText4.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText4.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText4.Location = new NxtControl.Drawing.PointF(216D, 80D);
			this.freeText4.Name = "freeText4";
			this.freeText4.Text = "Level measurement reactor";
			// 
			// freeText3
			// 
			this.freeText3.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText3.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText3.Location = new NxtControl.Drawing.PointF(8D, 80D);
			this.freeText3.Name = "freeText3";
			this.freeText3.Text = "pH measurement reactor";
			// 
			// freeText2
			// 
			this.freeText2.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText2.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText2.Location = new NxtControl.Drawing.PointF(216D, 8D);
			this.freeText2.Name = "freeText2";
			this.freeText2.Text = "Oxygen measurement reactor";
			// 
			// freeText1
			// 
			this.freeText1.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText1.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText1.Location = new NxtControl.Drawing.PointF(8D, 8D);
			this.freeText1.Name = "freeText1";
			this.freeText1.Text = "Temperature measurement reactor";
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
			// sDisplayPv21
			// 
			this.sDisplayPv21.BeginInit();
			this.sDisplayPv21._iSensorName = "Name";
			this.sDisplayPv21._iUnit = "m";
			this.sDisplayPv21.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 240D, 96D);
			this.sDisplayPv21.Name = "sDisplayPv21";
			this.sDisplayPv21.SecurityToken = ((uint)(4294967295u));
			this.sDisplayPv21.TagName = "Sensors.LevelMeasurementReactor";
			this.sDisplayPv21.EndInit();
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
			// sDisplayPv22
			// 
			this.sDisplayPv22.BeginInit();
			this.sDisplayPv22._iSensorName = "Name";
			this.sDisplayPv22._iUnit = "%";
			this.sDisplayPv22.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 240D, 24D);
			this.sDisplayPv22.Name = "sDisplayPv22";
			this.sDisplayPv22.SecurityToken = ((uint)(4294967295u));
			this.sDisplayPv22.TagName = "Sensors.OxygenMeasurementReactor";
			this.sDisplayPv22.EndInit();
			// 
			// sDisplayPv23
			// 
			this.sDisplayPv23.BeginInit();
			this.sDisplayPv23._iSensorName = "Name";
			this.sDisplayPv23._iUnit = "%";
			this.sDisplayPv23.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 32D, 24D);
			this.sDisplayPv23.Name = "sDisplayPv23";
			this.sDisplayPv23.SecurityToken = ((uint)(4294967295u));
			this.sDisplayPv23.TagName = "Sensors.TemperatureMeasurement";
			this.sDisplayPv23.EndInit();
			// 
			// sDisplayPv24
			// 
			this.sDisplayPv24.BeginInit();
			this.sDisplayPv24._iSensorName = "Name";
			this.sDisplayPv24._iUnit = "%";
			this.sDisplayPv24.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 32D, 96D);
			this.sDisplayPv24.Name = "sDisplayPv24";
			this.sDisplayPv24.SecurityToken = ((uint)(4294967295u));
			this.sDisplayPv24.TagName = "Sensors.pHMeasurementReactor";
			this.sDisplayPv24.EndInit();
			// 
			// rectangle5
			// 
			this.rectangle5.Bounds = new NxtControl.Drawing.RectF(((float)(224D)), ((float)(184D)), ((float)(24D)), ((float)(32D)));
			this.rectangle5.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(114)), ((byte)(114)), ((byte)(114))));
			this.rectangle5.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle5.Name = "rectangle5";
			// 
			// sDefault1
			// 
			this.sDefault1.BeginInit();
			this.sDefault1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 216D, 176D);
			this.sDefault1.Name = "sDefault1";
			this.sDefault1.SecurityToken = ((uint)(4294967295u));
			this.sDefault1.TagName = "Sensors.LevelMeasurementReactor_Status";
			this.sDefault1.EndInit();
			// 
			// sDisplayPv25
			// 
			this.sDisplayPv25.BeginInit();
			this.sDisplayPv25._iSensorName = "Name";
			this.sDisplayPv25._iUnit = "";
			this.sDisplayPv25.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 240D, 176D);
			this.sDisplayPv25.Name = "sDisplayPv25";
			this.sDisplayPv25.SecurityToken = ((uint)(4294967295u));
			this.sDisplayPv25.TagName = "Sensors.DrySolidsMeasurementReactor";
			this.sDisplayPv25.EndInit();
			// 
			// sDefault2
			// 
			this.sDefault2.BeginInit();
			this.sDefault2.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 217D, 27D);
			this.sDefault2.Name = "sDefault2";
			this.sDefault2.SecurityToken = ((uint)(4294967295u));
			this.sDefault2.TagName = "Sensors.OxygenMeasurementReactor_Status";
			this.sDefault2.EndInit();
			// 
			// DrySolids
			// 
			this.DrySolids.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.DrySolids.Font = new NxtControl.Drawing.Font("LabelFont");
			this.DrySolids.Location = new NxtControl.Drawing.PointF(216D, 160D);
			this.DrySolids.Name = "DrySolids";
			this.DrySolids.Text = "DrySolids measurement reactor";
			// 
			// sDisplayPv26
			// 
			this.sDisplayPv26.BeginInit();
			this.sDisplayPv26._iSensorName = "Name";
			this.sDisplayPv26._iUnit = "%";
			this.sDisplayPv26.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 24D, 176D);
			this.sDisplayPv26.Name = "sDisplayPv26";
			this.sDisplayPv26.SecurityToken = ((uint)(4294967295u));
			this.sDisplayPv26.TagName = "Sensors.RedoxMeasurementReactor";
			this.sDisplayPv26.EndInit();
			// 
			// freeText5
			// 
			this.freeText5.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText5.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText5.Location = new NxtControl.Drawing.PointF(16D, 160D);
			this.freeText5.Name = "freeText5";
			this.freeText5.Text = "Redox measurement reactor";
			// 
			// sDisplayPv27
			// 
			this.sDisplayPv27.BeginInit();
			this.sDisplayPv27._iSensorName = "Name";
			this.sDisplayPv27._iUnit = "";
			this.sDisplayPv27.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 24D, 248D);
			this.sDisplayPv27.Name = "sDisplayPv27";
			this.sDisplayPv27.SecurityToken = ((uint)(4294967295u));
			this.sDisplayPv27.TagName = "Sensors.NH4MeasurementReactor";
			this.sDisplayPv27.EndInit();
			// 
			// sDisplayPv28
			// 
			this.sDisplayPv28.BeginInit();
			this.sDisplayPv28._iSensorName = "Name";
			this.sDisplayPv28._iUnit = "";
			this.sDisplayPv28.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 240D, 248D);
			this.sDisplayPv28.Name = "sDisplayPv28";
			this.sDisplayPv28.SecurityToken = ((uint)(4294967295u));
			this.sDisplayPv28.TagName = "Sensors.NO3MeasurementReactor";
			this.sDisplayPv28.EndInit();
			// 
			// sDisplayPv29
			// 
			this.sDisplayPv29.BeginInit();
			this.sDisplayPv29._iSensorName = "Name";
			this.sDisplayPv29._iUnit = "";
			this.sDisplayPv29.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 136D, 320D);
			this.sDisplayPv29.Name = "sDisplayPv29";
			this.sDisplayPv29.SecurityToken = ((uint)(4294967295u));
			this.sDisplayPv29.TagName = "Sensors.PO4MeasurementReactor";
			this.sDisplayPv29.EndInit();
			// 
			// freeText6
			// 
			this.freeText6.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText6.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText6.Location = new NxtControl.Drawing.PointF(24D, 232D);
			this.freeText6.Name = "freeText6";
			this.freeText6.Text = "NH4 measurement reactor";
			// 
			// freeText7
			// 
			this.freeText7.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText7.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText7.Location = new NxtControl.Drawing.PointF(232D, 232D);
			this.freeText7.Name = "freeText7";
			this.freeText7.Text = "NO3 measurement reactor";
			// 
			// freeText8
			// 
			this.freeText8.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText8.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText8.Location = new NxtControl.Drawing.PointF(136D, 304D);
			this.freeText8.Name = "freeText8";
			this.freeText8.Text = "PO4 measurement reactor";
			// 
			// sSensors
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.rectangle4,
			this.rectangle3,
			this.rectangle2,
			this.rectangle1,
			this.sDefault4,
			this.freeText1,
			this.freeText2,
			this.freeText3,
			this.freeText4,
			this.sDisplayPv21,
			this.sDisplayPv22,
			this.sDisplayPv23,
			this.sDisplayPv24,
			this.rectangle5,
			this.sDefault1,
			this.sDisplayPv25,
			this.sDefault2,
			this.DrySolids,
			this.sDisplayPv26,
			this.freeText5,
			this.sDisplayPv27,
			this.sDisplayPv28,
			this.sDisplayPv29,
			this.freeText6,
			this.freeText7,
			this.freeText8});
			this.SymbolSize = new System.Drawing.Size(416, 392);

		}
		private SE.Nereda.Symbols.AnalogInput_Status.sDefault sDefault1;
		private SE.Nereda.Symbols.AnalogInput_Status.sDefault sDefault2;
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
		private SE.Nereda.Symbols.AnalogInput.sDisplayPv2 sDisplayPv22;
		private SE.Nereda.Symbols.AnalogInput.sDisplayPv2 sDisplayPv23;
		private SE.Nereda.Symbols.AnalogInput.sDisplayPv2 sDisplayPv24;
		private NxtControl.GuiFramework.Rectangle rectangle5;
		private SE.Nereda.Symbols.AnalogInput.sDisplayPv2 sDisplayPv25;
		private NxtControl.GuiFramework.FreeText DrySolids;
		private SE.Nereda.Symbols.AnalogInput.sDisplayPv2 sDisplayPv26;
		private NxtControl.GuiFramework.FreeText freeText5;
		private SE.Nereda.Symbols.AnalogInput.sDisplayPv2 sDisplayPv27;
		private SE.Nereda.Symbols.AnalogInput.sDisplayPv2 sDisplayPv28;
		private SE.Nereda.Symbols.AnalogInput.sDisplayPv2 sDisplayPv29;
		private NxtControl.GuiFramework.FreeText freeText6;
		private NxtControl.GuiFramework.FreeText freeText7;
		private NxtControl.GuiFramework.FreeText freeText8;
		#endregion
	}
}
