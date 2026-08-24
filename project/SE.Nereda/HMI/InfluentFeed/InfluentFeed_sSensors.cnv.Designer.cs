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
			this.rectangle3 = new NxtControl.GuiFramework.Rectangle();
			this.rectangle2 = new NxtControl.GuiFramework.Rectangle();
			this.rectangle1 = new NxtControl.GuiFramework.Rectangle();
			this.freeText1 = new NxtControl.GuiFramework.FreeText();
			this.freeText2 = new NxtControl.GuiFramework.FreeText();
			this.freeText3 = new NxtControl.GuiFramework.FreeText();
			this.sDefault1 = new SE.Nereda.Symbols.AnalogInput_Status.sDefault();
			this.sDisplayPv21 = new SE.Nereda.Symbols.AnalogInput.sDisplayPv2();
			this.sDefault2 = new SE.Nereda.Symbols.AnalogInput_Status.sDefault();
			this.sDisplayPv22 = new SE.Nereda.Symbols.AnalogInput.sDisplayPv2();
			this.sDefault3 = new SE.Nereda.Symbols.AnalogInput_Status.sDefault();
			this.sDisplayPv23 = new SE.Nereda.Symbols.AnalogInput.sDisplayPv2();
			// 
			// rectangle3
			// 
			this.rectangle3.Bounds = new NxtControl.Drawing.RectF(((float)(224D)), ((float)(32D)), ((float)(24D)), ((float)(32D)));
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
			// freeText1
			// 
			this.freeText1.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText1.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText1.Location = new NxtControl.Drawing.PointF(8D, 8D);
			this.freeText1.Name = "freeText1";
			this.freeText1.Text = "Level measurement influent buffer";
			// 
			// freeText2
			// 
			this.freeText2.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText2.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText2.Location = new NxtControl.Drawing.PointF(216D, 8D);
			this.freeText2.Name = "freeText2";
			this.freeText2.Text = "Flow measurement reactor feed";
			// 
			// freeText3
			// 
			this.freeText3.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText3.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText3.Location = new NxtControl.Drawing.PointF(8D, 80D);
			this.freeText3.Name = "freeText3";
			this.freeText3.Text = "Flow measurement influent feed";
			// 
			// sDefault1
			// 
			this.sDefault1.BeginInit();
			this.sDefault1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 8D, 24D);
			this.sDefault1.Name = "sDefault1";
			this.sDefault1.SecurityToken = ((uint)(4294967295u));
			this.sDefault1.TagName = "Sensors.LevelPvInfluentBuffer_Status";
			this.sDefault1.EndInit();
			// 
			// sDisplayPv21
			// 
			this.sDisplayPv21.BeginInit();
			this.sDisplayPv21._iSensorName = " NVPP 001 lt 001";
			this.sDisplayPv21._iUnit = "m";
			this.sDisplayPv21.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 32D, 24D);
			this.sDisplayPv21.Name = "sDisplayPv21";
			this.sDisplayPv21.SecurityToken = ((uint)(4294967295u));
			this.sDisplayPv21.TagName = "Sensors.LevelPvInfluentBuffer";
			this.sDisplayPv21.EndInit();
			// 
			// sDefault2
			// 
			this.sDefault2.BeginInit();
			this.sDefault2.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 216D, 24D);
			this.sDefault2.Name = "sDefault2";
			this.sDefault2.SecurityToken = ((uint)(4294967295u));
			this.sDefault2.TagName = "Sensors.FeedReactorFlowPv_Status";
			this.sDefault2.EndInit();
			// 
			// sDisplayPv22
			// 
			this.sDisplayPv22.BeginInit();
			this.sDisplayPv22._iSensorName = "NVPP 001 ft 001";
			this.sDisplayPv22._iUnit = "m³/h";
			this.sDisplayPv22.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 240D, 24D);
			this.sDisplayPv22.Name = "sDisplayPv22";
			this.sDisplayPv22.SecurityToken = ((uint)(4294967295u));
			this.sDisplayPv22.TagName = "Sensors.FeedReactorFlowPv";
			this.sDisplayPv22.EndInit();
			// 
			// sDefault3
			// 
			this.sDefault3.BeginInit();
			this.sDefault3.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 8D, 96D);
			this.sDefault3.Name = "sDefault3";
			this.sDefault3.SecurityToken = ((uint)(4294967295u));
			this.sDefault3.TagName = "Sensors.FeedInfluentFlowPv_Status";
			this.sDefault3.EndInit();
			// 
			// sDisplayPv23
			// 
			this.sDisplayPv23.BeginInit();
			this.sDisplayPv23._iSensorName = "46 2 VB FT 95 001";
			this.sDisplayPv23._iUnit = "m³/h";
			this.sDisplayPv23.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 32D, 96D);
			this.sDisplayPv23.Name = "sDisplayPv23";
			this.sDisplayPv23.SecurityToken = ((uint)(4294967295u));
			this.sDisplayPv23.TagName = "Sensors.FeedInfluentFlowPv";
			this.sDisplayPv23.EndInit();
			// 
			// sSensors
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.rectangle3,
			this.rectangle2,
			this.rectangle1,
			this.freeText1,
			this.freeText2,
			this.freeText3,
			this.sDefault1,
			this.sDisplayPv21,
			this.sDefault2,
			this.sDisplayPv22,
			this.sDefault3,
			this.sDisplayPv23});
			this.SymbolSize = new System.Drawing.Size(664, 424);

		}
		private NxtControl.GuiFramework.Rectangle rectangle3;
		private NxtControl.GuiFramework.Rectangle rectangle2;
		private NxtControl.GuiFramework.Rectangle rectangle1;
		private NxtControl.GuiFramework.FreeText freeText1;
		private NxtControl.GuiFramework.FreeText freeText2;
		private NxtControl.GuiFramework.FreeText freeText3;
		private SE.Nereda.Symbols.AnalogInput_Status.sDefault sDefault1;
		private SE.Nereda.Symbols.AnalogInput.sDisplayPv2 sDisplayPv21;
		private SE.Nereda.Symbols.AnalogInput_Status.sDefault sDefault2;
		private SE.Nereda.Symbols.AnalogInput.sDisplayPv2 sDisplayPv22;
		private SE.Nereda.Symbols.AnalogInput_Status.sDefault sDefault3;
		private SE.Nereda.Symbols.AnalogInput.sDisplayPv2 sDisplayPv23;
		#endregion
	}
}
