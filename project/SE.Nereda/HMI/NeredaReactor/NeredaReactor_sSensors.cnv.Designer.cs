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
			this.sDisplayPv21 = new SE.Nereda.Symbols.AnalogInput.sDisplayPv2();
			this.sDisplayPv22 = new SE.Nereda.Symbols.AnalogInput.sDisplayPv2();
			this.sDisplayPv23 = new SE.Nereda.Symbols.AnalogInput.sDisplayPv2();
			this.sDisplayPv24 = new SE.Nereda.Symbols.AnalogInput.sDisplayPv2();
			this.sDisplayPv25 = new SE.Nereda.Symbols.AnalogInput.sDisplayPv2();
			this.sDisplayPv26 = new SE.Nereda.Symbols.AnalogInput.sDisplayPv2();
			this.sDisplayPv27 = new SE.Nereda.Symbols.AnalogInput.sDisplayPv2();
			this.sDisplayPv28 = new SE.Nereda.Symbols.AnalogInput.sDisplayPv2();
			this.sDisplayPv29 = new SE.Nereda.Symbols.AnalogInput.sDisplayPv2();
			this.sDisplayPv210 = new SE.Nereda.Symbols.AnalogInput.sDisplayPv2();
			this.sDisplayPv211 = new SE.Nereda.Symbols.AnalogInput.sDisplayPv2();
			// 
			// sDisplayPv21
			// 
			this.sDisplayPv21.BeginInit();
			this.sDisplayPv21._iSensorName = "Level Measurement";
			this.sDisplayPv21._iUnit = "m";
			this.sDisplayPv21.DesignMatrix = new NxtControl.Drawing.Matrix2D(1.1052631578947369D, 0D, 0D, 1D, 32D, 16D);
			this.sDisplayPv21.Name = "sDisplayPv21";
			this.sDisplayPv21.SecurityToken = ((uint)(4294967295u));
			this.sDisplayPv21.TagName = "Sensors.LevelMeasurementReactor";
			this.sDisplayPv21.EndInit();
			// 
			// sDisplayPv22
			// 
			this.sDisplayPv22.BeginInit();
			this.sDisplayPv22._iSensorName = "Air Flow Measurement";
			this.sDisplayPv22._iUnit = "";
			this.sDisplayPv22.DesignMatrix = new NxtControl.Drawing.Matrix2D(1.1052631578947369D, 0D, 0D, 1D, 232D, 16D);
			this.sDisplayPv22.Name = "sDisplayPv22";
			this.sDisplayPv22.SecurityToken = ((uint)(4294967295u));
			this.sDisplayPv22.TagName = "Sensors.AirFlowMeasurementReactor";
			this.sDisplayPv22.EndInit();
			// 
			// sDisplayPv23
			// 
			this.sDisplayPv23.BeginInit();
			this.sDisplayPv23._iSensorName = "DrySolids Measurement";
			this.sDisplayPv23._iUnit = "";
			this.sDisplayPv23.DesignMatrix = new NxtControl.Drawing.Matrix2D(1.10062893081761D, 0D, 0D, 1D, 32D, 88D);
			this.sDisplayPv23.Name = "sDisplayPv23";
			this.sDisplayPv23.SecurityToken = ((uint)(4294967295u));
			this.sDisplayPv23.TagName = "Sensors.DrySolidsMeasurementReactor";
			this.sDisplayPv23.EndInit();
			// 
			// sDisplayPv24
			// 
			this.sDisplayPv24.BeginInit();
			this.sDisplayPv24._iSensorName = "Oxygen Measurement";
			this.sDisplayPv24._iUnit = "";
			this.sDisplayPv24.DesignMatrix = new NxtControl.Drawing.Matrix2D(1.1052631578947369D, 0D, 0D, 1D, 232D, 88D);
			this.sDisplayPv24.Name = "sDisplayPv24";
			this.sDisplayPv24.SecurityToken = ((uint)(4294967295u));
			this.sDisplayPv24.TagName = "Sensors.OxygenMeasurementReactor";
			this.sDisplayPv24.EndInit();
			// 
			// sDisplayPv25
			// 
			this.sDisplayPv25.BeginInit();
			this.sDisplayPv25._iSensorName = "pH Measurement";
			this.sDisplayPv25._iUnit = "";
			this.sDisplayPv25.DesignMatrix = new NxtControl.Drawing.Matrix2D(1.1052631578947369D, 0D, 0D, 1D, 32D, 160D);
			this.sDisplayPv25.Name = "sDisplayPv25";
			this.sDisplayPv25.SecurityToken = ((uint)(4294967295u));
			this.sDisplayPv25.TagName = "Sensors.pHMeasurementReactor";
			this.sDisplayPv25.EndInit();
			// 
			// sDisplayPv26
			// 
			this.sDisplayPv26.BeginInit();
			this.sDisplayPv26._iSensorName = "Redox Measurement";
			this.sDisplayPv26._iUnit = "";
			this.sDisplayPv26.DesignMatrix = new NxtControl.Drawing.Matrix2D(1.1052631578947369D, 0D, 0D, 1D, 232D, 160D);
			this.sDisplayPv26.Name = "sDisplayPv26";
			this.sDisplayPv26.SecurityToken = ((uint)(4294967295u));
			this.sDisplayPv26.TagName = "Sensors.RedoxMeasurementReactor";
			this.sDisplayPv26.EndInit();
			// 
			// sDisplayPv27
			// 
			this.sDisplayPv27.BeginInit();
			this.sDisplayPv27._iSensorName = "Temp Measurement";
			this.sDisplayPv27._iUnit = "";
			this.sDisplayPv27.DesignMatrix = new NxtControl.Drawing.Matrix2D(1.1052631578947369D, 0D, 0D, 1D, 32D, 232D);
			this.sDisplayPv27.Name = "sDisplayPv27";
			this.sDisplayPv27.SecurityToken = ((uint)(4294967295u));
			this.sDisplayPv27.TagName = "Sensors.TemperatureMeasurement";
			this.sDisplayPv27.EndInit();
			// 
			// sDisplayPv28
			// 
			this.sDisplayPv28.BeginInit();
			this.sDisplayPv28._iSensorName = "Turbidity Measurement";
			this.sDisplayPv28._iUnit = "";
			this.sDisplayPv28.DesignMatrix = new NxtControl.Drawing.Matrix2D(1.1045751633986929D, 0D, 0D, 1D, 232D, 232D);
			this.sDisplayPv28.Name = "sDisplayPv28";
			this.sDisplayPv28.SecurityToken = ((uint)(4294967295u));
			this.sDisplayPv28.TagName = "Sensors.TurbidityMeasurementBothReactors";
			this.sDisplayPv28.EndInit();
			// 
			// sDisplayPv29
			// 
			this.sDisplayPv29.BeginInit();
			this.sDisplayPv29._iSensorName = "NH4 Measurement";
			this.sDisplayPv29._iUnit = "";
			this.sDisplayPv29.DesignMatrix = new NxtControl.Drawing.Matrix2D(1.1052631578947369D, 0D, 0D, 1D, 32D, 304D);
			this.sDisplayPv29.Name = "sDisplayPv29";
			this.sDisplayPv29.SecurityToken = ((uint)(4294967295u));
			this.sDisplayPv29.TagName = "Sensors.NH4MeasurementReactor";
			this.sDisplayPv29.EndInit();
			// 
			// sDisplayPv210
			// 
			this.sDisplayPv210.BeginInit();
			this.sDisplayPv210._iSensorName = "NO3 Measurement";
			this.sDisplayPv210._iUnit = "";
			this.sDisplayPv210.DesignMatrix = new NxtControl.Drawing.Matrix2D(1.1052631578947369D, 0D, 0D, 1D, 232D, 304D);
			this.sDisplayPv210.Name = "sDisplayPv210";
			this.sDisplayPv210.SecurityToken = ((uint)(4294967295u));
			this.sDisplayPv210.TagName = "Sensors.NO3MeasurementReactor";
			this.sDisplayPv210.EndInit();
			// 
			// sDisplayPv211
			// 
			this.sDisplayPv211.BeginInit();
			this.sDisplayPv211._iSensorName = "PO4 Measurement";
			this.sDisplayPv211._iUnit = "";
			this.sDisplayPv211.DesignMatrix = new NxtControl.Drawing.Matrix2D(1.1052631578947369D, 0D, 0D, 1D, 128D, 376D);
			this.sDisplayPv211.Name = "sDisplayPv211";
			this.sDisplayPv211.SecurityToken = ((uint)(4294967295u));
			this.sDisplayPv211.TagName = "Sensors.PO4MeasurementReactor";
			this.sDisplayPv211.EndInit();
			// 
			// sSensors
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.sDisplayPv21,
			this.sDisplayPv22,
			this.sDisplayPv23,
			this.sDisplayPv24,
			this.sDisplayPv25,
			this.sDisplayPv26,
			this.sDisplayPv27,
			this.sDisplayPv28,
			this.sDisplayPv29,
			this.sDisplayPv210,
			this.sDisplayPv211});
			this.SymbolSize = new System.Drawing.Size(416, 432);

		}
		private SE.Nereda.Symbols.AnalogInput.sDisplayPv2 sDisplayPv21;
		private SE.Nereda.Symbols.AnalogInput.sDisplayPv2 sDisplayPv22;
		private SE.Nereda.Symbols.AnalogInput.sDisplayPv2 sDisplayPv23;
		private SE.Nereda.Symbols.AnalogInput.sDisplayPv2 sDisplayPv24;
		private SE.Nereda.Symbols.AnalogInput.sDisplayPv2 sDisplayPv25;
		private SE.Nereda.Symbols.AnalogInput.sDisplayPv2 sDisplayPv26;
		private SE.Nereda.Symbols.AnalogInput.sDisplayPv2 sDisplayPv27;
		private SE.Nereda.Symbols.AnalogInput.sDisplayPv2 sDisplayPv28;
		private SE.Nereda.Symbols.AnalogInput.sDisplayPv2 sDisplayPv29;
		private SE.Nereda.Symbols.AnalogInput.sDisplayPv2 sDisplayPv210;
		private SE.Nereda.Symbols.AnalogInput.sDisplayPv2 sDisplayPv211;
		#endregion
	}
}
