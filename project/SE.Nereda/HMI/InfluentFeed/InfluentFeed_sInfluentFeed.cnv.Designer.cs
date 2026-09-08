/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 7/8/2026
 * Time: 12:10 PM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.InfluentFeed
{
	/// <summary>
	/// Summary description for sInfluentFeed.
	/// </summary>
	partial class sInfluentFeed
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.ellipse16 = new NxtControl.GuiFramework.Ellipse();
			this.rectangle3 = new NxtControl.GuiFramework.Rectangle();
			this.ellipse3 = new NxtControl.GuiFramework.Ellipse();
			this.rectangle2 = new NxtControl.GuiFramework.Rectangle();
			this.WaterBase = new NxtControl.GuiFramework.Ellipse();
			this.WaterLevel = new NxtControl.GuiFramework.Rectangle();
			this.WaterTop = new NxtControl.GuiFramework.Ellipse();
			this.ellipse15 = new NxtControl.GuiFramework.Ellipse();
			this.ellipse14 = new NxtControl.GuiFramework.Ellipse();
			this.INFLUENT = new NxtControl.GuiFramework.Rectangle();
			this.sPvBarVer2 = new SE.Nereda.Symbols.AnalogInput.sPvBarVer();
			this.rectangle1 = new NxtControl.GuiFramework.Rectangle();
			this.sMotorVs1 = new SE.Nereda.Symbols.Motor_VS.sMotorVs();
			this.sMixer1 = new SE.Nereda.Symbols.MixerLogic.sMixer();
			this.freeText1 = new NxtControl.GuiFramework.FreeText();
			this.sMotor1 = new SE.Nereda.Symbols.MotorS.sMotor();
			this.rectangle4 = new NxtControl.GuiFramework.Rectangle();
			this.sGritScreen1 = new SE.Nereda.Symbols.GritScreenLogic.sGritScreen();
			this.pipe1 = new NxtControl.GuiFramework.Pipe();
			this.freeText2 = new NxtControl.GuiFramework.FreeText();
			this.group1 = new NxtControl.GuiFramework.Group();
			this.group2 = new NxtControl.GuiFramework.Group();
			// 
			// ellipse16
			// 
			this.ellipse16.Bounds = new NxtControl.Drawing.RectF(((float)(32D)), ((float)(344D)), ((float)(280D)), ((float)(88D)));
			this.ellipse16.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255))), new NxtControl.Drawing.GradientFill(NxtControl.Drawing.GradientFillOrientation.HorizontalCenter, NxtControl.Drawing.GradientFillBrightness.Dark));
			this.ellipse16.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.ellipse16.Name = "ellipse16";
			this.ellipse16.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(78)), ((byte)(78)), ((byte)(78))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// rectangle3
			// 
			this.rectangle3.Bounds = new NxtControl.Drawing.RectF(((float)(32D)), ((float)(64D)), ((float)(280D)), ((float)(328D)));
			this.rectangle3.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255))), new NxtControl.Drawing.GradientFill(NxtControl.Drawing.GradientFillOrientation.HorizontalCenter, NxtControl.Drawing.GradientFillBrightness.Dark));
			this.rectangle3.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle3.Name = "rectangle3";
			this.rectangle3.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// ellipse3
			// 
			this.ellipse3.Bounds = new NxtControl.Drawing.RectF(((float)(48D)), ((float)(320D)), ((float)(248D)), ((float)(88D)));
			this.ellipse3.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(154)), ((byte)(154)), ((byte)(154))), new NxtControl.Drawing.GradientFill(NxtControl.Drawing.GradientFillOrientation.HorizontalCenter, NxtControl.Drawing.GradientFillBrightness.Dark));
			this.ellipse3.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.ellipse3.Name = "ellipse3";
			this.ellipse3.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(78)), ((byte)(78)), ((byte)(78))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// rectangle2
			// 
			this.rectangle2.Bounds = new NxtControl.Drawing.RectF(((float)(48D)), ((float)(112D)), ((float)(248D)), ((float)(256D)));
			this.rectangle2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(154)), ((byte)(154)), ((byte)(154))), new NxtControl.Drawing.GradientFill(NxtControl.Drawing.GradientFillOrientation.HorizontalCenter, NxtControl.Drawing.GradientFillBrightness.Dark));
			this.rectangle2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle2.Name = "rectangle2";
			this.rectangle2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// WaterBase
			// 
			this.WaterBase.Bounds = new NxtControl.Drawing.RectF(((float)(48D)), ((float)(320D)), ((float)(248D)), ((float)(88D)));
			this.WaterBase.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(165)), ((byte)(213)), ((byte)(226))));
			this.WaterBase.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.WaterBase.Name = "WaterBase";
			this.WaterBase.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// WaterLevel
			// 
			this.WaterLevel.Bounds = new NxtControl.Drawing.RectF(((float)(48D)), ((float)(232D)), ((float)(248D)), ((float)(136D)));
			this.WaterLevel.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(165)), ((byte)(213)), ((byte)(226))));
			this.WaterLevel.FillDirection = NxtControl.Drawing.FillDirection.DownToTop;
			this.WaterLevel.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.WaterLevel.Name = "WaterLevel";
			this.WaterLevel.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// WaterTop
			// 
			this.WaterTop.Bounds = new NxtControl.Drawing.RectF(((float)(48D)), ((float)(192D)), ((float)(248D)), ((float)(88D)));
			this.WaterTop.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(165)), ((byte)(213)), ((byte)(226))));
			this.WaterTop.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.WaterTop.Name = "WaterTop";
			this.WaterTop.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(120)), ((byte)(192)), ((byte)(212))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// ellipse15
			// 
			this.ellipse15.Bounds = new NxtControl.Drawing.RectF(((float)(32D)), ((float)(136D)), ((float)(280D)), ((float)(88D)));
			this.ellipse15.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255))), new NxtControl.Drawing.GradientFill(NxtControl.Drawing.GradientFillOrientation.HorizontalCenter, NxtControl.Drawing.GradientFillBrightness.Dark));
			this.ellipse15.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.ellipse15.Name = "ellipse15";
			this.ellipse15.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(135)), ((byte)(135)), ((byte)(135))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// ellipse14
			// 
			this.ellipse14.Bounds = new NxtControl.Drawing.RectF(((float)(32D)), ((float)(24D)), ((float)(280D)), ((float)(88D)));
			this.ellipse14.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255))), new NxtControl.Drawing.GradientFill(NxtControl.Drawing.GradientFillOrientation.DiagonalRightTop));
			this.ellipse14.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.ellipse14.Name = "ellipse14";
			this.ellipse14.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(78)), ((byte)(78)), ((byte)(78))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// INFLUENT
			// 
			this.INFLUENT.Bounds = new NxtControl.Drawing.RectF(((float)(32D)), ((float)(164D)), ((float)(280D)), ((float)(40D)));
			this.INFLUENT.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("transparent"));
			this.INFLUENT.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.INFLUENT.Name = "INFLUENT";
			this.INFLUENT.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.INFLUENT.Text = "INFLUENT";
			this.INFLUENT.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			// 
			// sPvBarVer2
			// 
			this.sPvBarVer2.BeginInit();
			this.sPvBarVer2._iSensorName = "";
			this.sPvBarVer2._iUnit = "m";
			this.sPvBarVer2.DesignMatrix = new NxtControl.Drawing.Matrix2D(1.5D, 0D, 0D, 1.5000000000000002D, 56D, 198D);
			this.sPvBarVer2.Name = "sPvBarVer2";
			this.sPvBarVer2.SecurityToken = ((uint)(4294967295u));
			this.sPvBarVer2.TagName = "Sensors.LevelPvInfluentBuffer";
			this.sPvBarVer2.ShareLevelPv += new SE.Nereda.Symbols.AnalogInput.sPvBarVer.ShLevelPv(this.SPvBarVer1ShareLevelPv);
			this.sPvBarVer2.EndInit();
			// 
			// rectangle1
			// 
			this.rectangle1.Bounds = new NxtControl.Drawing.RectF(((float)(32D)), ((float)(80D)), ((float)(280D)), ((float)(120D)));
			this.rectangle1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255))), new NxtControl.Drawing.GradientFill(NxtControl.Drawing.GradientFillOrientation.HorizontalCenter, NxtControl.Drawing.GradientFillBrightness.Dark));
			this.rectangle1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle1.Name = "rectangle1";
			this.rectangle1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// sMotorVs1
			// 
			this.sMotorVs1.BeginInit();
			this.sMotorVs1._iMotName = "";
			this.sMotorVs1._iUnit = "%";
			this.sMotorVs1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 176D, 252D);
			this.sMotorVs1.Name = "sMotorVs1";
			this.sMotorVs1.SecurityToken = ((uint)(4294967295u));
			this.sMotorVs1.StateTextPosition = SE.Nereda.Symbols.Motor_VS.sMotorVs.StateTextPositionOption.Horizontal;
			this.sMotorVs1.SymbolNameDisplay = SE.Nereda.Symbols.Motor_VS.sMotorVs.SymbolNameDisplayOption.Show;
			this.sMotorVs1.TagName = "Actuators.Mixer01";
			this.sMotorVs1.EndInit();
			// 
			// sMixer1
			// 
			this.sMixer1.BeginInit();
			this.sMixer1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 208D, 318D);
			this.sMixer1.Name = "sMixer1";
			this.sMixer1.SecurityToken = ((uint)(4294967295u));
			this.sMixer1.TagName = "InfluentFeedLogic.Mixer01Logic";
			this.sMixer1.EndInit();
			// 
			// freeText1
			// 
			this.freeText1.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText1.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText1.Location = new NxtControl.Drawing.PointF(184D, 254D);
			this.freeText1.Name = "freeText1";
			this.freeText1.Text = "NVPP 001 mng 001";
			// 
			// sMotor1
			// 
			this.sMotor1.BeginInit();
			this.sMotor1._iMotName = "";
			this.sMotor1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 16D, 56D);
			this.sMotor1.Name = "sMotor1";
			this.sMotor1.SecurityToken = ((uint)(4294967295u));
			this.sMotor1.StateTextPosition = SE.Nereda.Symbols.MotorS.sMotor.StateTextPositionOption.Vertical;
			this.sMotor1.SymbolNameDisplay = SE.Nereda.Symbols.MotorS.sMotor.SymbolNameDisplayOption.Show;
			this.sMotor1.TagName = "Actuators.GritScreenMotor";
			this.sMotor1.EndInit();
			// 
			// rectangle4
			// 
			this.rectangle4.Bounds = new NxtControl.Drawing.RectF(((float)(96D)), ((float)(76D)), ((float)(152D)), ((float)(88D)));
			this.rectangle4.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(210)), ((byte)(210)), ((byte)(210))));
			this.rectangle4.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle4.Name = "rectangle4";
			// 
			// sGritScreen1
			// 
			this.sGritScreen1.BeginInit();
			this.sGritScreen1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1.7435897435897441D, 0D, 0D, 1.7435897435897436D, 104D, 90D);
			this.sGritScreen1.Name = "sGritScreen1";
			this.sGritScreen1.SecurityToken = ((uint)(4294967295u));
			this.sGritScreen1.TagName = "InfluentFeedLogic.GritScreenLogic";
			this.sGritScreen1.EndInit();
			// 
			// pipe1
			// 
			this.pipe1.Bounds = new NxtControl.Drawing.RectF(((float)(80D)), ((float)(120D)), ((float)(168D)), ((float)(0D)));
			this.pipe1.InnerColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.pipe1.Name = "pipe1";
			this.pipe1.OuterColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.pipe1.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(80D, 120D),
			new NxtControl.Drawing.PointF(248D, 120D)});
			this.pipe1.Width = 8;
			// 
			// freeText2
			// 
			this.freeText2.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText2.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText2.Location = new NxtControl.Drawing.PointF(120D, 56D);
			this.freeText2.Name = "freeText2";
			this.freeText2.Text = "NVPP 001 RGI 001";
			// 
			// group1
			// 
			this.group1.BeginInit();
			this.group1.Name = "group1";
			this.group1.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.sPvBarVer2,
			this.INFLUENT,
			this.sMixer1,
			this.sMotorVs1,
			this.freeText1,
			this.rectangle4,
			this.pipe1,
			this.sMotor1,
			this.sGritScreen1,
			this.freeText2});
			this.group1.EndInit();
			// 
			// group2
			// 
			this.group2.BeginInit();
			this.group2.Name = "group2";
			this.group2.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.ellipse16,
			this.rectangle3,
			this.ellipse3,
			this.rectangle2,
			this.WaterBase,
			this.WaterLevel,
			this.WaterTop,
			this.ellipse15,
			this.rectangle1,
			this.ellipse14});
			this.group2.EndInit();
			// 
			// sInfluentFeed
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.group2,
			this.group1});
			this.SymbolSize = new System.Drawing.Size(880, 728);

		}
		private NxtControl.GuiFramework.Ellipse ellipse16;
		private NxtControl.GuiFramework.Rectangle rectangle3;
		private NxtControl.GuiFramework.Ellipse ellipse3;
		private NxtControl.GuiFramework.Rectangle rectangle2;
		private NxtControl.GuiFramework.Ellipse WaterBase;
		private NxtControl.GuiFramework.Rectangle WaterLevel;
		private NxtControl.GuiFramework.Ellipse WaterTop;
		private NxtControl.GuiFramework.Ellipse ellipse15;
		private NxtControl.GuiFramework.Ellipse ellipse14;
		private NxtControl.GuiFramework.Rectangle INFLUENT;
		private SE.Nereda.Symbols.AnalogInput.sPvBarVer sPvBarVer2;
		private NxtControl.GuiFramework.Rectangle rectangle1;
		private SE.Nereda.Symbols.Motor_VS.sMotorVs sMotorVs1;
		private SE.Nereda.Symbols.MixerLogic.sMixer sMixer1;
		private NxtControl.GuiFramework.FreeText freeText1;
		private SE.Nereda.Symbols.MotorS.sMotor sMotor1;
		private NxtControl.GuiFramework.Rectangle rectangle4;
		private SE.Nereda.Symbols.GritScreenLogic.sGritScreen sGritScreen1;
		private NxtControl.GuiFramework.Pipe pipe1;
		private NxtControl.GuiFramework.FreeText freeText2;
		private NxtControl.GuiFramework.Group group1;
		private NxtControl.GuiFramework.Group group2;
		#endregion
	}
}
