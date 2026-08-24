/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 7/11/2026
 * Time: 9:35 PM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.NeredaSludgeBuffer
{
	/// <summary>
	/// Summary description for sSludgeBuffer.
	/// </summary>
	partial class sSludgeBuffer
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
			this.SLUDGE_BUFFER = new NxtControl.GuiFramework.Rectangle();
			this.sPvBarVer1 = new SE.Nereda.Symbols.AnalogInput.sPvBarVer();
			this.group1 = new NxtControl.GuiFramework.Group();
			// 
			// ellipse16
			// 
			this.ellipse16.Bounds = new NxtControl.Drawing.RectF(((float)(16D)), ((float)(256D)), ((float)(280D)), ((float)(88D)));
			this.ellipse16.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255))), new NxtControl.Drawing.GradientFill(NxtControl.Drawing.GradientFillOrientation.HorizontalCenter, NxtControl.Drawing.GradientFillBrightness.Dark));
			this.ellipse16.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.ellipse16.Name = "ellipse16";
			this.ellipse16.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(78)), ((byte)(78)), ((byte)(78))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// rectangle3
			// 
			this.rectangle3.Bounds = new NxtControl.Drawing.RectF(((float)(16D)), ((float)(64D)), ((float)(280D)), ((float)(240D)));
			this.rectangle3.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255))), new NxtControl.Drawing.GradientFill(NxtControl.Drawing.GradientFillOrientation.HorizontalCenter, NxtControl.Drawing.GradientFillBrightness.Dark));
			this.rectangle3.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle3.Name = "rectangle3";
			this.rectangle3.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// ellipse3
			// 
			this.ellipse3.Bounds = new NxtControl.Drawing.RectF(((float)(32D)), ((float)(232D)), ((float)(248D)), ((float)(88D)));
			this.ellipse3.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(154)), ((byte)(154)), ((byte)(154))), new NxtControl.Drawing.GradientFill(NxtControl.Drawing.GradientFillOrientation.HorizontalCenter, NxtControl.Drawing.GradientFillBrightness.Dark));
			this.ellipse3.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.ellipse3.Name = "ellipse3";
			this.ellipse3.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(78)), ((byte)(78)), ((byte)(78))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// rectangle2
			// 
			this.rectangle2.Bounds = new NxtControl.Drawing.RectF(((float)(32D)), ((float)(96D)), ((float)(248D)), ((float)(176D)));
			this.rectangle2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(154)), ((byte)(154)), ((byte)(154))), new NxtControl.Drawing.GradientFill(NxtControl.Drawing.GradientFillOrientation.HorizontalCenter, NxtControl.Drawing.GradientFillBrightness.Dark));
			this.rectangle2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle2.Name = "rectangle2";
			this.rectangle2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// WaterBase
			// 
			this.WaterBase.Bounds = new NxtControl.Drawing.RectF(((float)(32D)), ((float)(232D)), ((float)(248D)), ((float)(88D)));
			this.WaterBase.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(165)), ((byte)(213)), ((byte)(226))));
			this.WaterBase.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.WaterBase.Name = "WaterBase";
			this.WaterBase.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// WaterLevel
			// 
			this.WaterLevel.Bounds = new NxtControl.Drawing.RectF(((float)(32D)), ((float)(144D)), ((float)(248D)), ((float)(136D)));
			this.WaterLevel.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(165)), ((byte)(213)), ((byte)(226))));
			this.WaterLevel.FillDirection = NxtControl.Drawing.FillDirection.DownToTop;
			this.WaterLevel.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.WaterLevel.Name = "WaterLevel";
			this.WaterLevel.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// WaterTop
			// 
			this.WaterTop.Bounds = new NxtControl.Drawing.RectF(((float)(32D)), ((float)(96D)), ((float)(248D)), ((float)(88D)));
			this.WaterTop.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(165)), ((byte)(213)), ((byte)(226))));
			this.WaterTop.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.WaterTop.Name = "WaterTop";
			this.WaterTop.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(120)), ((byte)(192)), ((byte)(212))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// ellipse15
			// 
			this.ellipse15.Bounds = new NxtControl.Drawing.RectF(((float)(16D)), ((float)(48D)), ((float)(280D)), ((float)(88D)));
			this.ellipse15.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255))), new NxtControl.Drawing.GradientFill(NxtControl.Drawing.GradientFillOrientation.HorizontalCenter, NxtControl.Drawing.GradientFillBrightness.Dark));
			this.ellipse15.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.ellipse15.Name = "ellipse15";
			this.ellipse15.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(135)), ((byte)(135)), ((byte)(135))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// ellipse14
			// 
			this.ellipse14.Bounds = new NxtControl.Drawing.RectF(((float)(16D)), ((float)(16D)), ((float)(280D)), ((float)(88D)));
			this.ellipse14.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255))), new NxtControl.Drawing.GradientFill(NxtControl.Drawing.GradientFillOrientation.DiagonalRightTop));
			this.ellipse14.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.ellipse14.Name = "ellipse14";
			this.ellipse14.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(78)), ((byte)(78)), ((byte)(78))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// SLUDGE_BUFFER
			// 
			this.SLUDGE_BUFFER.Bounds = new NxtControl.Drawing.RectF(((float)(16D)), ((float)(100D)), ((float)(280D)), ((float)(40D)));
			this.SLUDGE_BUFFER.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("transparent"));
			this.SLUDGE_BUFFER.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.SLUDGE_BUFFER.Name = "SLUDGE_BUFFER";
			this.SLUDGE_BUFFER.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.SLUDGE_BUFFER.Text = "SLUDGE BUFFER";
			this.SLUDGE_BUFFER.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			// 
			// sPvBarVer1
			// 
			this.sPvBarVer1.BeginInit();
			this.sPvBarVer1._iSensorName = "";
			this.sPvBarVer1._iUnit = "m";
			this.sPvBarVer1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1.4954954954954955D, 0D, 0D, 1.5D, 40D, 106D);
			this.sPvBarVer1.Name = "sPvBarVer1";
			this.sPvBarVer1.SecurityToken = ((uint)(4294967295u));
			this.sPvBarVer1.TagName = "Sensors.NVPP_001_lt_003";
			this.sPvBarVer1.ShareLevelPv += new SE.Nereda.Symbols.AnalogInput.sPvBarVer.ShLevelPv(this.SPvBarVer1ShareLevelPv);
			this.sPvBarVer1.EndInit();
			// 
			// group1
			// 
			this.group1.BeginInit();
			this.group1.Name = "group1";
			this.group1.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.ellipse16,
			this.rectangle3,
			this.ellipse3,
			this.rectangle2,
			this.WaterBase,
			this.WaterLevel,
			this.WaterTop,
			this.ellipse15,
			this.ellipse14,
			this.SLUDGE_BUFFER});
			this.group1.EndInit();
			// 
			// sSludgeBuffer
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.group1,
			this.sPvBarVer1});
			this.SymbolSize = new System.Drawing.Size(800, 584);

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
		private NxtControl.GuiFramework.Rectangle SLUDGE_BUFFER;
		private NxtControl.GuiFramework.Group group1;
		private SE.Nereda.Symbols.AnalogInput.sPvBarVer sPvBarVer1;
		#endregion
	}
}
