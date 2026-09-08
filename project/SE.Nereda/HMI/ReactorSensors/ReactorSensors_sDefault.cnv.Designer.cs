/*
 * Created by EcoStruxure Automation Expert.
 * User: SESA371406
 * Date: 11/14/2023
 * Time: 3:51 PM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.ReactorSensors
{
	/// <summary>
	/// Summary description for sDefault.
	/// </summary>
	partial class sDefault
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.DrySolidsMeasurementReactor = new SE.Nereda.Symbols.AnalogInput.sDisplayPv2();
			this.DrySolidsMeasurementReactor_Status = new SE.Nereda.Symbols.AnalogInput_Status.sDefault();
			this.rectangle5 = new NxtControl.GuiFramework.Rectangle();
			// 
			// DrySolidsMeasurementReactor
			// 
			this.DrySolidsMeasurementReactor.BeginInit();
			this.DrySolidsMeasurementReactor._iSensorName = "Name";
			this.DrySolidsMeasurementReactor._iUnit = "%";
			this.DrySolidsMeasurementReactor.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 40D, 16D);
			this.DrySolidsMeasurementReactor.Name = "DrySolidsMeasurementReactor";
			this.DrySolidsMeasurementReactor.SecurityToken = ((uint)(4294967295u));
			this.DrySolidsMeasurementReactor.TagName = "DrySolidsMeasurementReactor";
			this.DrySolidsMeasurementReactor.EndInit();
			// 
			// DrySolidsMeasurementReactor_Status
			// 
			this.DrySolidsMeasurementReactor_Status.BeginInit();
			this.DrySolidsMeasurementReactor_Status.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 16D, 16D);
			this.DrySolidsMeasurementReactor_Status.Name = "DrySolidsMeasurementReactor_Status";
			this.DrySolidsMeasurementReactor_Status.SecurityToken = ((uint)(4294967295u));
			this.DrySolidsMeasurementReactor_Status.TagName = "DrySolidsMeasurementReactor_Status";
			this.DrySolidsMeasurementReactor_Status.EndInit();
			// 
			// rectangle5
			// 
			this.rectangle5.Bounds = new NxtControl.Drawing.RectF(((float)(24D)), ((float)(24D)), ((float)(24D)), ((float)(32D)));
			this.rectangle5.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(114)), ((byte)(114)), ((byte)(114))));
			this.rectangle5.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle5.Name = "rectangle5";
			// 
			// sDefault
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.DrySolidsMeasurementReactor,
			this.DrySolidsMeasurementReactor_Status,
			this.rectangle5});
			this.SymbolSize = new System.Drawing.Size(664, 344);

		}
		private SE.Nereda.Symbols.AnalogInput.sDisplayPv2 DrySolidsMeasurementReactor;
		private SE.Nereda.Symbols.AnalogInput_Status.sDefault DrySolidsMeasurementReactor_Status;
		private NxtControl.GuiFramework.Rectangle rectangle5;
		#endregion
	}
}
