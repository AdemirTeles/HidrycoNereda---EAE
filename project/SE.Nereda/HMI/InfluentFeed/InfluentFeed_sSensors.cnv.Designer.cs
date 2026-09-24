/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 6/17/2026
 * Time: 3:54 PM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.InfluentFeed
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
			this.sDisplayPv21 = new SE.Nereda.Symbols.AnalogInput.sDisplayPv2();
			this.sDisplayPv22 = new SE.Nereda.Symbols.AnalogInput.sDisplayPv2();
			this.sDisplayPv23 = new SE.Nereda.Symbols.AnalogInput.sDisplayPv2();
			this.sDisplayPv24 = new SE.Nereda.Symbols.AnalogInput.sDisplayPv2();
			this.sDIn21 = new SE.Nereda.Symbols.DigitalInput.sDIn2();
			// 
			// sDisplayPv21
			// 
			this.sDisplayPv21.BeginInit();
			this.sDisplayPv21._iSensorName = "Level Measurement";
			this.sDisplayPv21._iUnit = "m";
			this.sDisplayPv21.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 48D, 40D);
			this.sDisplayPv21.Name = "sDisplayPv21";
			this.sDisplayPv21.SecurityToken = ((uint)(4294967295u));
			this.sDisplayPv21.TagName = "Sensors.LevelPvInfluentBuffer";
			this.sDisplayPv21.EndInit();
			// 
			// sDisplayPv22
			// 
			this.sDisplayPv22.BeginInit();
			this.sDisplayPv22._iSensorName = "Flow Measurement";
			this.sDisplayPv22._iUnit = "";
			this.sDisplayPv22.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 232D, 40D);
			this.sDisplayPv22.Name = "sDisplayPv22";
			this.sDisplayPv22.SecurityToken = ((uint)(4294967295u));
			this.sDisplayPv22.TagName = "Sensors.FeedReactorFlowPv";
			this.sDisplayPv22.EndInit();
			// 
			// sDisplayPv23
			// 
			this.sDisplayPv23.BeginInit();
			this.sDisplayPv23._iSensorName = "pH Measurement";
			this.sDisplayPv23._iUnit = "";
			this.sDisplayPv23.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 48D, 112D);
			this.sDisplayPv23.Name = "sDisplayPv23";
			this.sDisplayPv23.SecurityToken = ((uint)(4294967295u));
			this.sDisplayPv23.TagName = "Sensors.pH";
			this.sDisplayPv23.EndInit();
			// 
			// sDisplayPv24
			// 
			this.sDisplayPv24.BeginInit();
			this.sDisplayPv24._iSensorName = "Cond Measurement";
			this.sDisplayPv24._iUnit = "";
			this.sDisplayPv24.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 232D, 112D);
			this.sDisplayPv24.Name = "sDisplayPv24";
			this.sDisplayPv24.SecurityToken = ((uint)(4294967295u));
			this.sDisplayPv24.TagName = "Sensors.ConductivityPv";
			this.sDisplayPv24.EndInit();
			// 
			// sDIn21
			// 
			this.sDIn21.BeginInit();
			this.sDIn21.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 144D, 176D);
			this.sDIn21.Name = "sDIn21";
			this.sDIn21.SecurityToken = ((uint)(4294967295u));
			this.sDIn21.TagName = "Sensors.LevelSwitchInfluentBuffer";
			this.sDIn21.EndInit();
			// 
			// sSensors
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.sDisplayPv21,
			this.sDisplayPv22,
			this.sDisplayPv23,
			this.sDisplayPv24,
			this.sDIn21});
			this.SymbolSize = new System.Drawing.Size(664, 424);

		}
		private SE.Nereda.Symbols.AnalogInput.sDisplayPv2 sDisplayPv21;
		private SE.Nereda.Symbols.AnalogInput.sDisplayPv2 sDisplayPv22;
		private SE.Nereda.Symbols.AnalogInput.sDisplayPv2 sDisplayPv23;
		private SE.Nereda.Symbols.AnalogInput.sDisplayPv2 sDisplayPv24;
		private SE.Nereda.Symbols.DigitalInput.sDIn2 sDIn21;
		#endregion
	}
}
