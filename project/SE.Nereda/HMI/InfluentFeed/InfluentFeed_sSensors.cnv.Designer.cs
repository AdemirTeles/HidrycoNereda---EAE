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
			this.sDisplayPv24 = new SE.Nereda.Symbols.AnalogInput.sDisplayPv2();
			this.sDisplayPv25 = new SE.Nereda.Symbols.AnalogInput.sDisplayPv2();
			this.sDisplayPv26 = new SE.Nereda.Symbols.AnalogInput.sDisplayPv2();
			this.sDIn21 = new SE.Nereda.Symbols.DigitalInput.sDIn2();
			this.sDisplayPv27 = new SE.Nereda.Symbols.AnalogInput.sDisplayPv2();
			// 
			// sDisplayPv24
			// 
			this.sDisplayPv24.BeginInit();
			this.sDisplayPv24._iSensorName = "Conductivity";
			this.sDisplayPv24._iUnit = "";
			this.sDisplayPv24.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 32D, 80D);
			this.sDisplayPv24.Name = "sDisplayPv24";
			this.sDisplayPv24.SecurityToken = ((uint)(4294967295u));
			this.sDisplayPv24.TagName = "Sensors.ConductivityPv";
			this.sDisplayPv24.EndInit();
			// 
			// sDisplayPv25
			// 
			this.sDisplayPv25.BeginInit();
			this.sDisplayPv25._iSensorName = "Feed Reactor Flow";
			this.sDisplayPv25._iUnit = "m³/h";
			this.sDisplayPv25.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 224D, 8D);
			this.sDisplayPv25.Name = "sDisplayPv25";
			this.sDisplayPv25.SecurityToken = ((uint)(4294967295u));
			this.sDisplayPv25.TagName = "Sensors.FeedReactorFlowPv";
			this.sDisplayPv25.EndInit();
			// 
			// sDisplayPv26
			// 
			this.sDisplayPv26.BeginInit();
			this.sDisplayPv26._iSensorName = "Level";
			this.sDisplayPv26._iUnit = "m";
			this.sDisplayPv26.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 32D, 8D);
			this.sDisplayPv26.Name = "sDisplayPv26";
			this.sDisplayPv26.SecurityToken = ((uint)(4294967295u));
			this.sDisplayPv26.TagName = "Sensors.LevelPvInfluentBuffer";
			this.sDisplayPv26.EndInit();
			// 
			// sDIn21
			// 
			this.sDIn21.BeginInit();
			this.sDIn21.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 128D, 152D);
			this.sDIn21.Name = "sDIn21";
			this.sDIn21.SecurityToken = ((uint)(4294967295u));
			this.sDIn21.TagName = "Sensors.LevelSwitchInfluentBuffer";
			this.sDIn21.EndInit();
			// 
			// sDisplayPv27
			// 
			this.sDisplayPv27.BeginInit();
			this.sDisplayPv27._iSensorName = "pH";
			this.sDisplayPv27._iUnit = "";
			this.sDisplayPv27.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 224D, 80D);
			this.sDisplayPv27.Name = "sDisplayPv27";
			this.sDisplayPv27.SecurityToken = ((uint)(4294967295u));
			this.sDisplayPv27.TagName = "Sensors.pH";
			this.sDisplayPv27.EndInit();
			// 
			// sSensors
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.sDisplayPv24,
			this.sDisplayPv25,
			this.sDisplayPv26,
			this.sDIn21,
			this.sDisplayPv27});
			this.SymbolSize = new System.Drawing.Size(664, 424);

		}
		private SE.Nereda.Symbols.AnalogInput.sDisplayPv2 sDisplayPv24;
		private SE.Nereda.Symbols.AnalogInput.sDisplayPv2 sDisplayPv25;
		private SE.Nereda.Symbols.AnalogInput.sDisplayPv2 sDisplayPv26;
		private SE.Nereda.Symbols.DigitalInput.sDIn2 sDIn21;
		private SE.Nereda.Symbols.AnalogInput.sDisplayPv2 sDisplayPv27;
		#endregion
	}
}
