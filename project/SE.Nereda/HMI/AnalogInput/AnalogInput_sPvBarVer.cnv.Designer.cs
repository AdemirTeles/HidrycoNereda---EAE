/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 6/5/2026
 * Time: 3:20 PM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.AnalogInput
{
	/// <summary>
	/// Summary description for sDefault.
	/// </summary>
	partial class sPvBarVer
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary2 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary1 = new NxtControl.GuiFramework.PropertyDictionary();
			this.OpenFp = new NxtControl.GuiFramework.Rectangle();
			this.Unit = new NxtControl.GuiFramework.FreeText();
			this.Pv = new System.HMI.Symbols.Base.FreeText<float>();
			this.SensorName = new NxtControl.GuiFramework.FreeText();
			this.alarmSAFrame1 = new NxtControl.GuiFramework.AlarmFrame();
			this.ShowLevel = new NxtControl.GuiFramework.Rectangle();
			this.rectangle1 = new NxtControl.GuiFramework.Rectangle();
			this.StatusTxt = new NxtControl.GuiFramework.FreeText();
			this.Override = new NxtControl.GuiFramework.Ellipse();
			this.Pv_1 = new System.HMI.Symbols.Base.Execute<float>();
			this.PvMin = new System.HMI.Symbols.Base.Execute<float>();
			this.PvMax = new System.HMI.Symbols.Base.Execute<float>();
			this.OverrideStatus = new System.HMI.Symbols.Base.Execute<bool>();
			this.ChFail = new System.HMI.Symbols.Base.Execute<bool>();
			this.HiHiPv = new System.HMI.Symbols.Base.Execute<bool>();
			this.HiPv = new System.HMI.Symbols.Base.Execute<bool>();
			this.LoPv = new System.HMI.Symbols.Base.Execute<bool>();
			this.LoLoPv = new System.HMI.Symbols.Base.Execute<bool>();
			this.iColor = new System.HMI.Symbols.Base.Execute<short>();
			this.iUnit = new System.HMI.Symbols.Base.Execute<string>();
			((System.ComponentModel.ISupportInitialize)(this.alarmSAFrame1)).BeginInit();
			// 
			// OpenFp
			// 
			this.OpenFp.Bounds = new NxtControl.Drawing.RectF(((float)(16D)), ((float)(32D)), ((float)(64D)), ((float)(96D)));
			this.OpenFp.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("transparent"));
			this.OpenFp.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.OpenFp.Name = "OpenFp";
			this.OpenFp.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("fpDefault", NxtControl.GuiFramework.MouseButtonType.Click));
			this.OpenFp.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// Unit
			// 
			this.Unit.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.Unit.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.Unit.Location = new NxtControl.Drawing.PointF(40D, 80D);
			this.Unit.Name = "Unit";
			this.Unit.Text = "%";
			// 
			// Pv
			// 
			this.Pv.BeginInit();
			this.Pv.DecimalPlacesCount = ((uint)(2u));
			this.Pv.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 32D, 56D);
			this.Pv.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.Pv.IsOnlyInput = true;
			this.Pv.Name = "Pv";
			this.Pv.Ranges.Clear();
			this.Pv.Ranges.Add(new NxtControl.GuiFramework.Range<float>(null, true, null, true, propertyDictionary2));
			propertyDictionary1.Add("Text", "${Value}");
			propertyDictionary1.Add("TextColor", new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			this.Pv.Ranges.DefaultPropertyValues = propertyDictionary1;
			this.Pv.TagName = "Pv";
			this.Pv.TextAngle = 0F;
			this.Pv.EndInit();
			// 
			// SensorName
			// 
			this.SensorName.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.SensorName.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.SensorName.Location = new NxtControl.Drawing.PointF(16D, 12D);
			this.SensorName.Name = "SensorName";
			this.SensorName.Text = "Name";
			// 
			// alarmSAFrame1
			// 
			this.alarmSAFrame1.Bounds = new NxtControl.Drawing.RectF(((float)(16D)), ((float)(32D)), ((float)(16D)), ((float)(96D)));
			this.alarmSAFrame1.FrameWidth = ((uint)(2u));
			this.alarmSAFrame1.Name = "alarmSAFrame1";
			this.alarmSAFrame1.Radius = 5D;
			// 
			// ShowLevel
			// 
			this.ShowLevel.Bounds = new NxtControl.Drawing.RectF(((float)(18D)), ((float)(34D)), ((float)(12D)), ((float)(92D)));
			this.ShowLevel.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(61)), ((byte)(205)), ((byte)(88))));
			this.ShowLevel.FillDirection = NxtControl.Drawing.FillDirection.DownToTop;
			this.ShowLevel.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.ShowLevel.Name = "ShowLevel";
			this.ShowLevel.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// rectangle1
			// 
			this.rectangle1.Bounds = new NxtControl.Drawing.RectF(((float)(16D)), ((float)(32D)), ((float)(16D)), ((float)(96D)));
			this.rectangle1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("transparent"));
			this.rectangle1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle1.Name = "rectangle1";
			// 
			// StatusTxt
			// 
			this.StatusTxt.Color = new NxtControl.Drawing.BlinkColor("SE.HwCommon.DevLEDOrangeRedFlash");
			this.StatusTxt.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.StatusTxt.Location = new NxtControl.Drawing.PointF(36D, 32D);
			this.StatusTxt.Name = "StatusTxt";
			this.StatusTxt.Text = "Senosr Status";
			// 
			// Override
			// 
			this.Override.Bounds = new NxtControl.Drawing.RectF(((float)(24D)), ((float)(120D)), ((float)(12D)), ((float)(12D)));
			this.Override.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.BlinkColor("SE.Nereda.Orangwhite"));
			this.Override.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular);
			this.Override.Name = "Override";
			this.Override.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.Override.Text = "!";
			this.Override.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Pv_1
			// 
			this.Pv_1.BeginInit();
			this.Pv_1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.Pv_1.IsOnlyInput = true;
			this.Pv_1.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.Pv_1.Name = "Pv_1";
			this.Pv_1.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.Pv_1.TagName = "Pv";
			this.Pv_1.Value = 0F;
			this.Pv_1.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.Pv_1ValueChanged);
			this.Pv_1.EndInit();
			// 
			// PvMin
			// 
			this.PvMin.BeginInit();
			this.PvMin.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.PvMin.IsOnlyInput = true;
			this.PvMin.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.PvMin.Name = "PvMin";
			this.PvMin.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.PvMin.TagName = "PvMin";
			this.PvMin.Value = 0F;
			this.PvMin.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.PvMinValueChanged);
			this.PvMin.EndInit();
			// 
			// PvMax
			// 
			this.PvMax.BeginInit();
			this.PvMax.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.PvMax.IsOnlyInput = true;
			this.PvMax.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.PvMax.Name = "PvMax";
			this.PvMax.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.PvMax.TagName = "PvMax";
			this.PvMax.Value = 0F;
			this.PvMax.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.PvMaxValueChanged);
			this.PvMax.EndInit();
			// 
			// OverrideStatus
			// 
			this.OverrideStatus.BeginInit();
			this.OverrideStatus.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.OverrideStatus.IsOnlyInput = true;
			this.OverrideStatus.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.OverrideStatus.Name = "OverrideStatus";
			this.OverrideStatus.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.OverrideStatus.TagName = "OverrideStatus";
			this.OverrideStatus.Value = false;
			this.OverrideStatus.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.OverrideStatusValueChanged);
			this.OverrideStatus.EndInit();
			// 
			// ChFail
			// 
			this.ChFail.BeginInit();
			this.ChFail.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.ChFail.IsOnlyInput = true;
			this.ChFail.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.ChFail.Name = "ChFail";
			this.ChFail.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.ChFail.TagName = "ChFail";
			this.ChFail.Value = false;
			this.ChFail.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.ChFailValueChanged);
			this.ChFail.EndInit();
			// 
			// HiHiPv
			// 
			this.HiHiPv.BeginInit();
			this.HiHiPv.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.HiHiPv.IsOnlyInput = true;
			this.HiHiPv.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.HiHiPv.Name = "HiHiPv";
			this.HiHiPv.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.HiHiPv.TagName = "HiHiPv";
			this.HiHiPv.Value = false;
			this.HiHiPv.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.HiHiPvValueChanged);
			this.HiHiPv.EndInit();
			// 
			// HiPv
			// 
			this.HiPv.BeginInit();
			this.HiPv.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.HiPv.IsOnlyInput = true;
			this.HiPv.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.HiPv.Name = "HiPv";
			this.HiPv.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.HiPv.TagName = "HiPv";
			this.HiPv.Value = false;
			this.HiPv.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.HiPvValueChanged);
			this.HiPv.EndInit();
			// 
			// LoPv
			// 
			this.LoPv.BeginInit();
			this.LoPv.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.LoPv.IsOnlyInput = true;
			this.LoPv.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.LoPv.Name = "LoPv";
			this.LoPv.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.LoPv.TagName = "LoPv";
			this.LoPv.Value = false;
			this.LoPv.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.LoPvValueChanged);
			this.LoPv.EndInit();
			// 
			// LoLoPv
			// 
			this.LoLoPv.BeginInit();
			this.LoLoPv.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.LoLoPv.IsOnlyInput = true;
			this.LoLoPv.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.LoLoPv.Name = "LoLoPv";
			this.LoLoPv.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.LoLoPv.TagName = "LoLoPv";
			this.LoLoPv.Value = false;
			this.LoLoPv.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.LoLoPvValueChanged);
			this.LoLoPv.EndInit();
			// 
			// iColor
			// 
			this.iColor.BeginInit();
			this.iColor.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 276D, 236D);
			this.iColor.IsOnlyInput = true;
			this.iColor.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.iColor.Name = "iColor";
			this.iColor.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.iColor.TagName = "iColor";
			this.iColor.Value = ((short)(0));
			this.iColor.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.IColorValueChanged);
			this.iColor.EndInit();
			// 
			// iUnit
			// 
			this.iUnit.BeginInit();
			this.iUnit.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 168D, 104D);
			this.iUnit.IsOnlyInput = true;
			this.iUnit.Location = new NxtControl.Drawing.PointF(168D, 104D);
			this.iUnit.Name = "iUnit";
			this.iUnit.Size = new NxtControl.Drawing.SizeF(100D, 20D);
			this.iUnit.TagName = "iUnit";
			this.iUnit.Value = null;
			this.iUnit.EndInit();
			// 
			// sPvBarVer
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.Unit,
			this.Pv,
			this.SensorName,
			this.ShowLevel,
			this.rectangle1,
			this.alarmSAFrame1,
			this.OpenFp,
			this.StatusTxt,
			this.Override,
			this.Pv_1,
			this.PvMin,
			this.PvMax,
			this.OverrideStatus,
			this.ChFail,
			this.HiHiPv,
			this.HiPv,
			this.LoPv,
			this.LoLoPv,
			this.iColor,
			this.iUnit});
			this.SymbolSize = new System.Drawing.Size(208, 152);
			((System.ComponentModel.ISupportInitialize)(this.alarmSAFrame1)).EndInit();

		}
		private NxtControl.GuiFramework.Rectangle OpenFp;
		private NxtControl.GuiFramework.FreeText Unit;
		private System.HMI.Symbols.Base.FreeText<float> Pv;
		private NxtControl.GuiFramework.FreeText SensorName;
		private NxtControl.GuiFramework.AlarmFrame alarmSAFrame1;
		private NxtControl.GuiFramework.Rectangle ShowLevel;
		private NxtControl.GuiFramework.Rectangle rectangle1;
		private NxtControl.GuiFramework.FreeText StatusTxt;
		private NxtControl.GuiFramework.Ellipse Override;
		private System.HMI.Symbols.Base.Execute<float> Pv_1;
		private System.HMI.Symbols.Base.Execute<float> PvMin;
		private System.HMI.Symbols.Base.Execute<float> PvMax;
		private System.HMI.Symbols.Base.Execute<bool> OverrideStatus;
		private System.HMI.Symbols.Base.Execute<bool> ChFail;
		private System.HMI.Symbols.Base.Execute<bool> HiHiPv;
		private System.HMI.Symbols.Base.Execute<bool> HiPv;
		private System.HMI.Symbols.Base.Execute<bool> LoPv;
		private System.HMI.Symbols.Base.Execute<bool> LoLoPv;
		private System.HMI.Symbols.Base.Execute<short> iColor;
		private System.HMI.Symbols.Base.Execute<string> iUnit;
		#endregion
	}
}
