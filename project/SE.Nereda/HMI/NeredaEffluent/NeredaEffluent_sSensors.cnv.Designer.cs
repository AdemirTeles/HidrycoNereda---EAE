/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 6/25/2026
 * Time: 11:30 AM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.NeredaEffluent
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
			this.rectangle4 = new NxtControl.GuiFramework.Rectangle();
			this.freeText4 = new NxtControl.GuiFramework.FreeText();
			this.rectangle5 = new NxtControl.GuiFramework.Rectangle();
			this.freeText5 = new NxtControl.GuiFramework.FreeText();
			this.rectangle6 = new NxtControl.GuiFramework.Rectangle();
			this.freeText6 = new NxtControl.GuiFramework.FreeText();
			this.rectangle7 = new NxtControl.GuiFramework.Rectangle();
			this.freeText7 = new NxtControl.GuiFramework.FreeText();
			this.rectangle8 = new NxtControl.GuiFramework.Rectangle();
			this.freeText8 = new NxtControl.GuiFramework.FreeText();
			this.sDisplayPv21 = new SE.Nereda.Symbols.AnalogInput.sDisplayPv2();
			this.sDisplayPv22 = new SE.Nereda.Symbols.AnalogInput.sDisplayPv2();
			this.sDisplayPv23 = new SE.Nereda.Symbols.AnalogInput.sDisplayPv2();
			this.sDisplayPv24 = new SE.Nereda.Symbols.AnalogInput.sDisplayPv2();
			this.sDisplayPv25 = new SE.Nereda.Symbols.AnalogInput.sDisplayPv2();
			this.sDisplayPv26 = new SE.Nereda.Symbols.AnalogInput.sDisplayPv2();
			this.sDisplayPv27 = new SE.Nereda.Symbols.AnalogInput.sDisplayPv2();
			this.sDisplayPv28 = new SE.Nereda.Symbols.AnalogInput.sDisplayPv2();
			this.sDefault1 = new SE.Nereda.Symbols.AnalogInput_Status.sDefault();
			this.sDefault2 = new SE.Nereda.Symbols.AnalogInput_Status.sDefault();
			this.sDefault3 = new SE.Nereda.Symbols.AnalogInput_Status.sDefault();
			this.sDefault4 = new SE.Nereda.Symbols.AnalogInput_Status.sDefault();
			this.sDefault5 = new SE.Nereda.Symbols.AnalogInput_Status.sDefault();
			this.sDefault6 = new SE.Nereda.Symbols.AnalogInput_Status.sDefault();
			this.sDefault7 = new SE.Nereda.Symbols.AnalogInput_Status.sDefault();
			this.sDefault8 = new SE.Nereda.Symbols.AnalogInput_Status.sDefault();
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
			this.rectangle2.Bounds = new NxtControl.Drawing.RectF(((float)(640D)), ((float)(32D)), ((float)(24D)), ((float)(32D)));
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
			this.freeText1.Text = "Level measurement Effluent";
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
			this.freeText3.Location = new NxtControl.Drawing.PointF(632D, 8D);
			this.freeText3.Name = "freeText3";
			this.freeText3.Text = "Turbidity/dry solids measurement";
			// 
			// rectangle4
			// 
			this.rectangle4.Bounds = new NxtControl.Drawing.RectF(((float)(224D)), ((float)(112D)), ((float)(24D)), ((float)(32D)));
			this.rectangle4.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(114)), ((byte)(114)), ((byte)(114))));
			this.rectangle4.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle4.Name = "rectangle4";
			// 
			// freeText4
			// 
			this.freeText4.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText4.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText4.Location = new NxtControl.Drawing.PointF(216D, 88D);
			this.freeText4.Name = "freeText4";
			this.freeText4.Text = "Auto sampler";
			// 
			// rectangle5
			// 
			this.rectangle5.Bounds = new NxtControl.Drawing.RectF(((float)(16D)), ((float)(112D)), ((float)(24D)), ((float)(32D)));
			this.rectangle5.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(114)), ((byte)(114)), ((byte)(114))));
			this.rectangle5.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle5.Name = "rectangle5";
			// 
			// freeText5
			// 
			this.freeText5.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText5.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText5.Location = new NxtControl.Drawing.PointF(8D, 88D);
			this.freeText5.Name = "freeText5";
			this.freeText5.Text = "Phosphate PO4 measurement";
			// 
			// rectangle6
			// 
			this.rectangle6.Bounds = new NxtControl.Drawing.RectF(((float)(640D)), ((float)(112D)), ((float)(24D)), ((float)(32D)));
			this.rectangle6.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(114)), ((byte)(114)), ((byte)(114))));
			this.rectangle6.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle6.Name = "rectangle6";
			// 
			// freeText6
			// 
			this.freeText6.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText6.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText6.Location = new NxtControl.Drawing.PointF(632D, 88D);
			this.freeText6.Name = "freeText6";
			this.freeText6.Text = "Nitrate NO3 measurement";
			// 
			// rectangle7
			// 
			this.rectangle7.Bounds = new NxtControl.Drawing.RectF(((float)(432D)), ((float)(32D)), ((float)(24D)), ((float)(32D)));
			this.rectangle7.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(114)), ((byte)(114)), ((byte)(114))));
			this.rectangle7.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle7.Name = "rectangle7";
			// 
			// freeText7
			// 
			this.freeText7.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText7.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText7.Location = new NxtControl.Drawing.PointF(424D, 8D);
			this.freeText7.Name = "freeText7";
			this.freeText7.Text = "Ambient Temperature";
			// 
			// rectangle8
			// 
			this.rectangle8.Bounds = new NxtControl.Drawing.RectF(((float)(432D)), ((float)(112D)), ((float)(24D)), ((float)(32D)));
			this.rectangle8.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(114)), ((byte)(114)), ((byte)(114))));
			this.rectangle8.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle8.Name = "rectangle8";
			// 
			// freeText8
			// 
			this.freeText8.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText8.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText8.Location = new NxtControl.Drawing.PointF(424D, 88D);
			this.freeText8.Name = "freeText8";
			this.freeText8.Text = "Ammonium NH4 measurement";
			// 
			// sDisplayPv21
			// 
			this.sDisplayPv21.BeginInit();
			this.sDisplayPv21._iSensorName = "NVPP 001 lt 002";
			this.sDisplayPv21._iUnit = "m";
			this.sDisplayPv21.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 32D, 24D);
			this.sDisplayPv21.Name = "sDisplayPv21";
			this.sDisplayPv21.SecurityToken = ((uint)(4294967295u));
			this.sDisplayPv21.TagName = "Sensors.NVPP_001_lt_002";
			this.sDisplayPv21.EndInit();
			// 
			// sDisplayPv22
			// 
			this.sDisplayPv22.BeginInit();
			this.sDisplayPv22._iSensorName = "NVPP 001 ft 002";
			this.sDisplayPv22._iUnit = "m³/h";
			this.sDisplayPv22.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 240D, 24D);
			this.sDisplayPv22.Name = "sDisplayPv22";
			this.sDisplayPv22.SecurityToken = ((uint)(4294967295u));
			this.sDisplayPv22.TagName = "Sensors.NVPP_001_ft_002";
			this.sDisplayPv22.EndInit();
			// 
			// sDisplayPv23
			// 
			this.sDisplayPv23.BeginInit();
			this.sDisplayPv23._iSensorName = "NVPP 001 40QT2103";
			this.sDisplayPv23._iUnit = "";
			this.sDisplayPv23.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 240D, 104D);
			this.sDisplayPv23.Name = "sDisplayPv23";
			this.sDisplayPv23.SecurityToken = ((uint)(4294967295u));
			this.sDisplayPv23.TagName = "Sensors.NVPP_001_40QT2103";
			this.sDisplayPv23.EndInit();
			// 
			// sDisplayPv24
			// 
			this.sDisplayPv24.BeginInit();
			this.sDisplayPv24._iSensorName = "NVPP 001 the 002";
			this.sDisplayPv24._iUnit = "°C";
			this.sDisplayPv24.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 448D, 24D);
			this.sDisplayPv24.Name = "sDisplayPv24";
			this.sDisplayPv24.SecurityToken = ((uint)(4294967295u));
			this.sDisplayPv24.TagName = "Sensors.NVPP_001_the_002";
			this.sDisplayPv24.EndInit();
			// 
			// sDisplayPv25
			// 
			this.sDisplayPv25.BeginInit();
			this.sDisplayPv25._iSensorName = "NVPP 001 40QT2101";
			this.sDisplayPv25._iUnit = "ntu";
			this.sDisplayPv25.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 656D, 24D);
			this.sDisplayPv25.Name = "sDisplayPv25";
			this.sDisplayPv25.SecurityToken = ((uint)(4294967295u));
			this.sDisplayPv25.TagName = "Sensors.NVPP_001_40QT2101";
			this.sDisplayPv25.EndInit();
			// 
			// sDisplayPv26
			// 
			this.sDisplayPv26.BeginInit();
			this.sDisplayPv26._iSensorName = "NVPP 001 40QT2102";
			this.sDisplayPv26._iUnit = "mgl/l";
			this.sDisplayPv26.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 32D, 104D);
			this.sDisplayPv26.Name = "sDisplayPv26";
			this.sDisplayPv26.SecurityToken = ((uint)(4294967295u));
			this.sDisplayPv26.TagName = "Sensors.NVPP_001_40QT2102";
			this.sDisplayPv26.EndInit();
			// 
			// sDisplayPv27
			// 
			this.sDisplayPv27.BeginInit();
			this.sDisplayPv27._iSensorName = "NVPP 001 40QT2105";
			this.sDisplayPv27._iUnit = "mg/l";
			this.sDisplayPv27.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 656D, 104D);
			this.sDisplayPv27.Name = "sDisplayPv27";
			this.sDisplayPv27.SecurityToken = ((uint)(4294967295u));
			this.sDisplayPv27.TagName = "Sensors.NVPP_001_40QT2105";
			this.sDisplayPv27.EndInit();
			// 
			// sDisplayPv28
			// 
			this.sDisplayPv28.BeginInit();
			this.sDisplayPv28._iSensorName = "NVPP 001 40QT2104";
			this.sDisplayPv28._iUnit = "mg/l";
			this.sDisplayPv28.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 448D, 104D);
			this.sDisplayPv28.Name = "sDisplayPv28";
			this.sDisplayPv28.SecurityToken = ((uint)(4294967295u));
			this.sDisplayPv28.TagName = "Sensors.NVPP_001_40QT2104";
			this.sDisplayPv28.EndInit();
			// 
			// sDefault1
			// 
			this.sDefault1.BeginInit();
			this.sDefault1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 8D, 24D);
			this.sDefault1.Name = "sDefault1";
			this.sDefault1.SecurityToken = ((uint)(4294967295u));
			this.sDefault1.TagName = "Sensors.NVPP_001_lt_002_Status";
			this.sDefault1.EndInit();
			// 
			// sDefault2
			// 
			this.sDefault2.BeginInit();
			this.sDefault2.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 216D, 24D);
			this.sDefault2.Name = "sDefault2";
			this.sDefault2.SecurityToken = ((uint)(4294967295u));
			this.sDefault2.TagName = "Sensors.NVPP_001_ft_002_Status";
			this.sDefault2.EndInit();
			// 
			// sDefault3
			// 
			this.sDefault3.BeginInit();
			this.sDefault3.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 424D, 24D);
			this.sDefault3.Name = "sDefault3";
			this.sDefault3.SecurityToken = ((uint)(4294967295u));
			this.sDefault3.TagName = "Sensors.NVPP_001_the_002_Status";
			this.sDefault3.EndInit();
			// 
			// sDefault4
			// 
			this.sDefault4.BeginInit();
			this.sDefault4.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 632D, 24D);
			this.sDefault4.Name = "sDefault4";
			this.sDefault4.SecurityToken = ((uint)(4294967295u));
			this.sDefault4.TagName = "Sensors.NVPP_001_40QT2101_Status";
			this.sDefault4.EndInit();
			// 
			// sDefault5
			// 
			this.sDefault5.BeginInit();
			this.sDefault5.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 8D, 104D);
			this.sDefault5.Name = "sDefault5";
			this.sDefault5.SecurityToken = ((uint)(4294967295u));
			this.sDefault5.TagName = "Sensors.NVPP_001_40QT2102_Status";
			this.sDefault5.EndInit();
			// 
			// sDefault6
			// 
			this.sDefault6.BeginInit();
			this.sDefault6.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 216D, 104D);
			this.sDefault6.Name = "sDefault6";
			this.sDefault6.SecurityToken = ((uint)(4294967295u));
			this.sDefault6.TagName = "Sensors.NVPP_001_40QT2103_Status";
			this.sDefault6.EndInit();
			// 
			// sDefault7
			// 
			this.sDefault7.BeginInit();
			this.sDefault7.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 424D, 104D);
			this.sDefault7.Name = "sDefault7";
			this.sDefault7.SecurityToken = ((uint)(4294967295u));
			this.sDefault7.TagName = "Sensors.NVPP_001_40QT2104_Status";
			this.sDefault7.EndInit();
			// 
			// sDefault8
			// 
			this.sDefault8.BeginInit();
			this.sDefault8.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 632D, 104D);
			this.sDefault8.Name = "sDefault8";
			this.sDefault8.SecurityToken = ((uint)(4294967295u));
			this.sDefault8.TagName = "Sensors.NVPP_001_40QT2105_Status";
			this.sDefault8.EndInit();
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
			this.rectangle4,
			this.freeText4,
			this.rectangle5,
			this.freeText5,
			this.rectangle6,
			this.freeText6,
			this.rectangle7,
			this.freeText7,
			this.rectangle8,
			this.freeText8,
			this.sDisplayPv21,
			this.sDisplayPv22,
			this.sDisplayPv23,
			this.sDisplayPv24,
			this.sDisplayPv25,
			this.sDisplayPv26,
			this.sDisplayPv27,
			this.sDisplayPv28,
			this.sDefault1,
			this.sDefault2,
			this.sDefault3,
			this.sDefault4,
			this.sDefault5,
			this.sDefault6,
			this.sDefault7,
			this.sDefault8});
			this.SymbolSize = new System.Drawing.Size(848, 440);

		}
		private NxtControl.GuiFramework.Rectangle rectangle3;
		private NxtControl.GuiFramework.Rectangle rectangle2;
		private NxtControl.GuiFramework.Rectangle rectangle1;
		private NxtControl.GuiFramework.FreeText freeText1;
		private NxtControl.GuiFramework.FreeText freeText2;
		private NxtControl.GuiFramework.FreeText freeText3;
		private NxtControl.GuiFramework.Rectangle rectangle4;
		private NxtControl.GuiFramework.FreeText freeText4;
		private NxtControl.GuiFramework.Rectangle rectangle5;
		private NxtControl.GuiFramework.FreeText freeText5;
		private NxtControl.GuiFramework.Rectangle rectangle6;
		private NxtControl.GuiFramework.FreeText freeText6;
		private NxtControl.GuiFramework.Rectangle rectangle7;
		private NxtControl.GuiFramework.FreeText freeText7;
		private NxtControl.GuiFramework.Rectangle rectangle8;
		private NxtControl.GuiFramework.FreeText freeText8;
		private SE.Nereda.Symbols.AnalogInput.sDisplayPv2 sDisplayPv21;
		private SE.Nereda.Symbols.AnalogInput.sDisplayPv2 sDisplayPv22;
		private SE.Nereda.Symbols.AnalogInput.sDisplayPv2 sDisplayPv23;
		private SE.Nereda.Symbols.AnalogInput.sDisplayPv2 sDisplayPv24;
		private SE.Nereda.Symbols.AnalogInput.sDisplayPv2 sDisplayPv25;
		private SE.Nereda.Symbols.AnalogInput.sDisplayPv2 sDisplayPv26;
		private SE.Nereda.Symbols.AnalogInput.sDisplayPv2 sDisplayPv27;
		private SE.Nereda.Symbols.AnalogInput.sDisplayPv2 sDisplayPv28;
		private SE.Nereda.Symbols.AnalogInput_Status.sDefault sDefault1;
		private SE.Nereda.Symbols.AnalogInput_Status.sDefault sDefault2;
		private SE.Nereda.Symbols.AnalogInput_Status.sDefault sDefault3;
		private SE.Nereda.Symbols.AnalogInput_Status.sDefault sDefault4;
		private SE.Nereda.Symbols.AnalogInput_Status.sDefault sDefault5;
		private SE.Nereda.Symbols.AnalogInput_Status.sDefault sDefault6;
		private SE.Nereda.Symbols.AnalogInput_Status.sDefault sDefault7;
		private SE.Nereda.Symbols.AnalogInput_Status.sDefault sDefault8;
		#endregion
	}
}
