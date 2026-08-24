/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 6/5/2026
 * Time: 4:25 PM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using NxtControl.GuiFramework;

namespace SE.Nereda.Faceplates.AnalogInput
{
	/// <summary>
	/// Summary description for fpDefault.
	/// </summary>
	partial class fpDefault
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
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary4 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary3 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary6 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary5 = new NxtControl.GuiFramework.PropertyDictionary();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fpDefault));
			this.Pv = new System.HMI.Symbols.Base.FreeText<float>();
			this.freeText1 = new NxtControl.GuiFramework.FreeText();
			this.Unit = new NxtControl.GuiFramework.FreeText();
			this.PvMin = new System.HMI.Symbols.Base.FreeText<float>();
			this.PvMax = new System.HMI.Symbols.Base.FreeText<float>();
			this.highHighBtn = new SE.App2Base.Symbols.LimitAlarm.sButton();
			this.highBtn = new SE.App2Base.Symbols.LimitAlarm.sButton();
			this.lowBtn = new SE.App2Base.Symbols.LimitAlarm.sButton();
			this.lowLowBtn = new SE.App2Base.Symbols.LimitAlarm.sButton();
			this.deviationBtn = new SE.App2Base.Symbols.DeviationAlarm.sButton();
			this.rateOfChangeBtn = new SE.App2Base.Symbols.ROCAlarm.sButton();
			this.HighHigh = new NxtControl.GuiFramework.Polygon();
			this.HighHighBar = new NxtControl.GuiFramework.Rectangle();
			this.HighBar = new NxtControl.GuiFramework.Rectangle();
			this.High = new NxtControl.GuiFramework.Polygon();
			this.LowBar = new NxtControl.GuiFramework.Rectangle();
			this.LowLowBar = new NxtControl.GuiFramework.Rectangle();
			this.Low = new NxtControl.GuiFramework.Polygon();
			this.LowLow = new NxtControl.GuiFramework.Polygon();
			this.ShowLevel = new NxtControl.GuiFramework.Rectangle();
			this.Unit2 = new NxtControl.GuiFramework.FreeText();
			this.Unit3 = new NxtControl.GuiFramework.FreeText();
			this.Settings = new NxtControl.GuiFramework.Rectangle();
			this.Trends = new NxtControl.GuiFramework.Rectangle();
			this.AnalogInput = new SE.Nereda.Symbols.AnalogInputBase.sDefault();
			this.LevelStatus = new NxtControl.GuiFramework.FreeText();
			this.SetColor = new NxtControl.GuiFramework.Rectangle();
			this.line1 = new NxtControl.GuiFramework.Line();
			this.rectangle1 = new NxtControl.GuiFramework.Rectangle();
			this.LevelSp1 = new System.HMI.Symbols.Base.TextBox<float>();
			this.LevelSp2 = new System.HMI.Symbols.Base.TextBox<float>();
			this.rectangle2 = new NxtControl.GuiFramework.Rectangle();
			this.rectangle3 = new NxtControl.GuiFramework.Rectangle();
			this.L1v = new NxtControl.GuiFramework.Rectangle();
			this.L2v = new NxtControl.GuiFramework.Rectangle();
			this.Override = new NxtControl.GuiFramework.FreeText();
			this.iUnit = new System.HMI.Symbols.Base.Execute<string>();
			this.group1 = new NxtControl.GuiFramework.Group();
			this.iFlowSensor = new System.HMI.Symbols.Base.Execute<bool>();
			this.HiHiDisabled = new System.HMI.Symbols.Base.Execute<bool>();
			this.HiDisabled = new System.HMI.Symbols.Base.Execute<bool>();
			this.LoDisabled = new System.HMI.Symbols.Base.Execute<bool>();
			this.LoLoDisabled = new System.HMI.Symbols.Base.Execute<bool>();
			// 
			// Pv
			// 
			this.Pv.BeginInit();
			this.Pv.DecimalPlacesCount = ((uint)(2u));
			this.Pv.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 144D, 56D);
			this.Pv.Font = new NxtControl.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular);
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
			// freeText1
			// 
			this.freeText1.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText1.Font = new NxtControl.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular);
			this.freeText1.Location = new NxtControl.Drawing.PointF(32D, 56D);
			this.freeText1.Name = "freeText1";
			this.freeText1.Text = "Process Value :";
			// 
			// Unit
			// 
			this.Unit.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.Unit.Font = new NxtControl.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular);
			this.Unit.Location = new NxtControl.Drawing.PointF(208D, 56D);
			this.Unit.Name = "Unit";
			this.Unit.Text = "%";
			// 
			// PvMin
			// 
			this.PvMin.BeginInit();
			this.PvMin.DecimalPlacesCount = ((uint)(2u));
			this.PvMin.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 8D, 296D);
			this.PvMin.Font = new NxtControl.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular);
			this.PvMin.IsOnlyInput = true;
			this.PvMin.Name = "PvMin";
			this.PvMin.Ranges.Clear();
			this.PvMin.Ranges.Add(new NxtControl.GuiFramework.Range<float>(null, true, null, true, propertyDictionary4));
			propertyDictionary3.Add("Text", "${Value}");
			propertyDictionary3.Add("TextColor", new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			this.PvMin.Ranges.DefaultPropertyValues = propertyDictionary3;
			this.PvMin.TagName = "PvMin";
			this.PvMin.TextAngle = 0F;
			this.PvMin.EndInit();
			// 
			// PvMax
			// 
			this.PvMax.BeginInit();
			this.PvMax.DecimalPlacesCount = ((uint)(2u));
			this.PvMax.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 8D, 136D);
			this.PvMax.Font = new NxtControl.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular);
			this.PvMax.IsOnlyInput = true;
			this.PvMax.Name = "PvMax";
			this.PvMax.Ranges.Clear();
			this.PvMax.Ranges.Add(new NxtControl.GuiFramework.Range<float>(null, true, null, true, propertyDictionary6));
			propertyDictionary5.Add("Text", "${Value}");
			propertyDictionary5.Add("TextColor", new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			this.PvMax.Ranges.DefaultPropertyValues = propertyDictionary5;
			this.PvMax.TagName = "PvMax";
			this.PvMax.TextAngle = 0F;
			this.PvMax.EndInit();
			// 
			// highHighBtn
			// 
			this.highHighBtn.BeginInit();
			this.highHighBtn.AlarmName = "HiHi";
			this.highHighBtn.DefaultInstanceName = null;
			this.highHighBtn.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 192D, 136D);
			this.highHighBtn.Instancelayer = SE.App2Base.SupportClasses.InstanceLayer.Base;
			this.highHighBtn.MyTagDisplayName = null;
			this.highHighBtn.Name = "highHighBtn";
			this.highHighBtn.SecurityToken = ((uint)(4294967295u));
			this.highHighBtn.TagName = "highHigh";
			this.highHighBtn.Unit = "";
			this.highHighBtn.EndInit();
			// 
			// highBtn
			// 
			this.highBtn.BeginInit();
			this.highBtn.AlarmName = "Hi";
			this.highBtn.DefaultInstanceName = null;
			this.highBtn.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 192D, 168D);
			this.highBtn.Instancelayer = SE.App2Base.SupportClasses.InstanceLayer.Base;
			this.highBtn.MyTagDisplayName = null;
			this.highBtn.Name = "highBtn";
			this.highBtn.SecurityToken = ((uint)(4294967295u));
			this.highBtn.TagName = "high";
			this.highBtn.Unit = "";
			this.highBtn.EndInit();
			// 
			// lowBtn
			// 
			this.lowBtn.BeginInit();
			this.lowBtn.AlarmName = "Lo";
			this.lowBtn.DefaultInstanceName = null;
			this.lowBtn.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 192D, 264D);
			this.lowBtn.Instancelayer = SE.App2Base.SupportClasses.InstanceLayer.Base;
			this.lowBtn.MyTagDisplayName = null;
			this.lowBtn.Name = "lowBtn";
			this.lowBtn.SecurityToken = ((uint)(4294967295u));
			this.lowBtn.TagName = "low";
			this.lowBtn.Unit = "";
			this.lowBtn.EndInit();
			// 
			// lowLowBtn
			// 
			this.lowLowBtn.BeginInit();
			this.lowLowBtn.AlarmName = "LoLo";
			this.lowLowBtn.DefaultInstanceName = null;
			this.lowLowBtn.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 192D, 296D);
			this.lowLowBtn.Instancelayer = SE.App2Base.SupportClasses.InstanceLayer.Base;
			this.lowLowBtn.MyTagDisplayName = null;
			this.lowLowBtn.Name = "lowLowBtn";
			this.lowLowBtn.SecurityToken = ((uint)(4294967295u));
			this.lowLowBtn.TagName = "lowLow";
			this.lowLowBtn.Unit = "";
			this.lowLowBtn.EndInit();
			// 
			// deviationBtn
			// 
			this.deviationBtn.BeginInit();
			this.deviationBtn.AlarmName = "TxtDeviation";
			this.deviationBtn.DefaultInstanceName = null;
			this.deviationBtn.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 192D, 232D);
			this.deviationBtn.Instancelayer = SE.App2Base.SupportClasses.InstanceLayer.Base;
			this.deviationBtn.MyTagDisplayName = null;
			this.deviationBtn.Name = "deviationBtn";
			this.deviationBtn.SecurityToken = ((uint)(4294967295u));
			this.deviationBtn.TagName = "deviation";
			this.deviationBtn.Unit = "";
			this.deviationBtn.EndInit();
			// 
			// rateOfChangeBtn
			// 
			this.rateOfChangeBtn.BeginInit();
			this.rateOfChangeBtn.AlarmName = "TxtROC";
			this.rateOfChangeBtn.DecimalPlacesCount = ((uint)(1u));
			this.rateOfChangeBtn.DefaultInstanceName = null;
			this.rateOfChangeBtn.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 192D, 200D);
			this.rateOfChangeBtn.Instancelayer = SE.App2Base.SupportClasses.InstanceLayer.Base;
			this.rateOfChangeBtn.MaxLimitValue = 100F;
			this.rateOfChangeBtn.MinLimitValue = -100F;
			this.rateOfChangeBtn.MyTagDisplayName = null;
			this.rateOfChangeBtn.Name = "rateOfChangeBtn";
			this.rateOfChangeBtn.SecurityToken = ((uint)(4294967175u));
			this.rateOfChangeBtn.TagName = "rateOfChange";
			this.rateOfChangeBtn.Unit = "";
			this.rateOfChangeBtn.EndInit();
			// 
			// HighHigh
			// 
			this.HighHigh.Bounds = new NxtControl.Drawing.RectF(((float)(104D)), ((float)(128D)), ((float)(48D)), ((float)(8D)));
			this.HighHigh.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(0)), ((byte)(0))));
			this.HighHigh.Closed = true;
			this.HighHigh.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.HighHigh.Name = "HighHigh";
			this.HighHigh.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(175)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.HighHigh.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(104D, 136D),
			new NxtControl.Drawing.PointF(152D, 136D),
			new NxtControl.Drawing.PointF(152D, 128D),
			new NxtControl.Drawing.PointF(136D, 136D)});
			// 
			// HighHighBar
			// 
			this.HighHighBar.Bounds = new NxtControl.Drawing.RectF(((float)(128D)), ((float)(136D)), ((float)(8D)), ((float)(176D)));
			this.HighHighBar.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(0)), ((byte)(0))));
			this.HighHighBar.FillDirection = NxtControl.Drawing.FillDirection.TopToDown;
			this.HighHighBar.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.HighHighBar.Name = "HighHighBar";
			this.HighHighBar.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// HighBar
			// 
			this.HighBar.Bounds = new NxtControl.Drawing.RectF(((float)(128D)), ((float)(136D)), ((float)(8D)), ((float)(176D)));
			this.HighBar.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(254)), ((byte)(186)), ((byte)(10))));
			this.HighBar.FillDirection = NxtControl.Drawing.FillDirection.TopToDown;
			this.HighBar.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.HighBar.Name = "HighBar";
			this.HighBar.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// High
			// 
			this.High.Bounds = new NxtControl.Drawing.RectF(((float)(104D)), ((float)(160D)), ((float)(48D)), ((float)(8D)));
			this.High.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(254)), ((byte)(186)), ((byte)(10))));
			this.High.Closed = true;
			this.High.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.High.Name = "High";
			this.High.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(227)), ((byte)(163)), ((byte)(9))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.High.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(104D, 168D),
			new NxtControl.Drawing.PointF(152D, 168D),
			new NxtControl.Drawing.PointF(152D, 160D),
			new NxtControl.Drawing.PointF(136D, 168D)});
			// 
			// LowBar
			// 
			this.LowBar.Bounds = new NxtControl.Drawing.RectF(((float)(128D)), ((float)(136D)), ((float)(8D)), ((float)(176D)));
			this.LowBar.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(254)), ((byte)(186)), ((byte)(10))));
			this.LowBar.FillDirection = NxtControl.Drawing.FillDirection.DownToTop;
			this.LowBar.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.LowBar.Name = "LowBar";
			this.LowBar.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// LowLowBar
			// 
			this.LowLowBar.Bounds = new NxtControl.Drawing.RectF(((float)(128D)), ((float)(136D)), ((float)(8D)), ((float)(176D)));
			this.LowLowBar.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(0)), ((byte)(0))));
			this.LowLowBar.FillDirection = NxtControl.Drawing.FillDirection.DownToTop;
			this.LowLowBar.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.LowLowBar.Name = "LowLowBar";
			this.LowLowBar.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// Low
			// 
			this.Low.Bounds = new NxtControl.Drawing.RectF(((float)(104D)), ((float)(280D)), ((float)(48D)), ((float)(8D)));
			this.Low.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(254)), ((byte)(186)), ((byte)(10))));
			this.Low.Closed = true;
			this.Low.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.Low.Name = "Low";
			this.Low.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(227)), ((byte)(163)), ((byte)(9))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.Low.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(104D, 280D),
			new NxtControl.Drawing.PointF(152D, 280D),
			new NxtControl.Drawing.PointF(152D, 288D),
			new NxtControl.Drawing.PointF(136D, 280D)});
			// 
			// LowLow
			// 
			this.LowLow.Bounds = new NxtControl.Drawing.RectF(((float)(104D)), ((float)(312D)), ((float)(48D)), ((float)(8D)));
			this.LowLow.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(0)), ((byte)(0))));
			this.LowLow.Closed = true;
			this.LowLow.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.LowLow.Name = "LowLow";
			this.LowLow.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(175)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.LowLow.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(104D, 312D),
			new NxtControl.Drawing.PointF(152D, 312D),
			new NxtControl.Drawing.PointF(152D, 320D),
			new NxtControl.Drawing.PointF(136D, 312D)});
			// 
			// ShowLevel
			// 
			this.ShowLevel.Bounds = new NxtControl.Drawing.RectF(((float)(106D)), ((float)(138D)), ((float)(20D)), ((float)(172D)));
			this.ShowLevel.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(61)), ((byte)(205)), ((byte)(88))));
			this.ShowLevel.FillDirection = NxtControl.Drawing.FillDirection.DownToTop;
			this.ShowLevel.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.ShowLevel.Name = "ShowLevel";
			this.ShowLevel.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// Unit2
			// 
			this.Unit2.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.Unit2.Font = new NxtControl.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular);
			this.Unit2.Location = new NxtControl.Drawing.PointF(64D, 136D);
			this.Unit2.Name = "Unit2";
			this.Unit2.Text = "%";
			// 
			// Unit3
			// 
			this.Unit3.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.Unit3.Font = new NxtControl.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular);
			this.Unit3.Location = new NxtControl.Drawing.PointF(64D, 296D);
			this.Unit3.Name = "Unit3";
			this.Unit3.Text = "%";
			// 
			// Settings
			// 
			this.Settings.Bounds = new NxtControl.Drawing.RectF(((float)(152D)), ((float)(0D)), ((float)(40D)), ((float)(40D)));
			this.Settings.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("transparent"));
			this.Settings.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.Settings.ImageBytes = resources.GetString("Settings.ImageBytes");
			this.Settings.Name = "Settings";
			this.Settings.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(114)), ((byte)(114)), ((byte)(114))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.Settings.Click += new System.EventHandler(this.SettingsClick);
			// 
			// Trends
			// 
			this.Trends.Bounds = new NxtControl.Drawing.RectF(((float)(192D)), ((float)(0D)), ((float)(40D)), ((float)(40D)));
			this.Trends.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("transparent"));
			this.Trends.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.Trends.ImageBytes = resources.GetString("Trends.ImageBytes");
			this.Trends.Name = "Trends";
			this.Trends.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(114)), ((byte)(114)), ((byte)(114))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.Trends.Click += new System.EventHandler(this.TrendsClick);
			// 
			// AnalogInput
			// 
			this.AnalogInput.BeginInit();
			this.AnalogInput.DefaultInstanceName = null;
			this.AnalogInput.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.1431221705371972D, 0D, 0D, 0.13525045115765141D, -30D, 184D);
			this.AnalogInput.Instancelayer = SE.App2Base.SupportClasses.InstanceLayer.Base;
			this.AnalogInput.MyTagDisplayName = null;
			this.AnalogInput.Name = "AnalogInput";
			this.AnalogInput.SecurityToken = ((uint)(4294967175u));
			this.AnalogInput.TagName = "AnalogInput";
			this.AnalogInput.EndInit();
			// 
			// LevelStatus
			// 
			this.LevelStatus.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.LevelStatus.Font = new NxtControl.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular);
			this.LevelStatus.Location = new NxtControl.Drawing.PointF(8D, 88D);
			this.LevelStatus.Name = "LevelStatus";
			this.LevelStatus.Text = "#########";
			// 
			// SetColor
			// 
			this.SetColor.Bounds = new NxtControl.Drawing.RectF(((float)(232D)), ((float)(0D)), ((float)(40D)), ((float)(40D)));
			this.SetColor.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("transparent"));
			this.SetColor.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.SetColor.ImageBytes = resources.GetString("SetColor.ImageBytes");
			this.SetColor.Name = "SetColor";
			this.SetColor.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("fpColor", NxtControl.GuiFramework.MouseButtonType.Click));
			this.SetColor.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(114)), ((byte)(114)), ((byte)(114))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// line1
			// 
			this.line1.EndPoint = new NxtControl.Drawing.PointF(272D, 112D);
			this.line1.Name = "line1";
			this.line1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line1.StartPoint = new NxtControl.Drawing.PointF(0D, 112D);
			// 
			// rectangle1
			// 
			this.rectangle1.Bounds = new NxtControl.Drawing.RectF(((float)(104D)), ((float)(136D)), ((float)(24D)), ((float)(176D)));
			this.rectangle1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("transparent"));
			this.rectangle1.FillDirection = NxtControl.Drawing.FillDirection.DownToTop;
			this.rectangle1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle1.Name = "rectangle1";
			this.rectangle1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(106)), ((byte)(106)), ((byte)(106))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// LevelSp1
			// 
			this.LevelSp1.BeginInit();
			this.LevelSp1.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.56666666666666665D, 0D, 0D, 1.0729783037475347D, 43D, 352D);
			this.LevelSp1.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.LevelSp1.MaximumTag = null;
			this.LevelSp1.MinimumTag = null;
			this.LevelSp1.Name = "LevelSp1";
			this.LevelSp1.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.LevelSp1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Black"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.LevelSp1.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.LevelSp1.TagName = "LevelSp1";
			this.LevelSp1.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			this.LevelSp1.UseInputPad = true;
			this.LevelSp1.Value = 0F;
			this.LevelSp1.EndInit();
			// 
			// LevelSp2
			// 
			this.LevelSp2.BeginInit();
			this.LevelSp2.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.56666666666666665D, 0D, 0D, 1D, 171D, 352D);
			this.LevelSp2.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.LevelSp2.MaximumTag = null;
			this.LevelSp2.MinimumTag = null;
			this.LevelSp2.Name = "LevelSp2";
			this.LevelSp2.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.LevelSp2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Black"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.LevelSp2.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.LevelSp2.TagName = "LevelSp2";
			this.LevelSp2.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			this.LevelSp2.UseInputPad = true;
			this.LevelSp2.Value = 0F;
			this.LevelSp2.EndInit();
			// 
			// rectangle2
			// 
			this.rectangle2.Bounds = new NxtControl.Drawing.RectF(((float)(16D)), ((float)(352D)), ((float)(27D)), ((float)(27D)));
			this.rectangle2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(210)), ((byte)(210)), ((byte)(210))));
			this.rectangle2.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.rectangle2.Name = "rectangle2";
			this.rectangle2.Text = "L1";
			this.rectangle2.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			// 
			// rectangle3
			// 
			this.rectangle3.Bounds = new NxtControl.Drawing.RectF(((float)(144D)), ((float)(352D)), ((float)(27D)), ((float)(27D)));
			this.rectangle3.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(210)), ((byte)(210)), ((byte)(210))));
			this.rectangle3.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.rectangle3.Name = "rectangle3";
			this.rectangle3.Text = "L2";
			this.rectangle3.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			// 
			// L1v
			// 
			this.L1v.Bounds = new NxtControl.Drawing.RectF(((float)(8D)), ((float)(352D)), ((float)(8D)), ((float)(27D)));
			this.L1v.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(54)), ((byte)(54)), ((byte)(54))), new NxtControl.Drawing.GradientFill(NxtControl.Drawing.GradientFillOrientation.Center, NxtControl.Drawing.GradientFillBrightness.Light));
			this.L1v.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.L1v.Name = "L1v";
			// 
			// L2v
			// 
			this.L2v.Bounds = new NxtControl.Drawing.RectF(((float)(136D)), ((float)(352D)), ((float)(8D)), ((float)(27D)));
			this.L2v.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(54)), ((byte)(54)), ((byte)(54))), new NxtControl.Drawing.GradientFill(NxtControl.Drawing.GradientFillOrientation.Center, NxtControl.Drawing.GradientFillBrightness.Light));
			this.L2v.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.L2v.Name = "L2v";
			// 
			// Override
			// 
			this.Override.Color = new NxtControl.Drawing.BlinkColor("SE.Nereda.Orangwhite");
			this.Override.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.Override.Location = new NxtControl.Drawing.PointF(8D, 8D);
			this.Override.Name = "Override";
			this.Override.Text = "Override : Enabled";
			// 
			// iUnit
			// 
			this.iUnit.BeginInit();
			this.iUnit.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.iUnit.IsOnlyInput = true;
			this.iUnit.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.iUnit.Name = "iUnit";
			this.iUnit.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.iUnit.TagName = "iUnit";
			this.iUnit.Value = null;
			this.iUnit.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.IUnitValueChanged);
			this.iUnit.EndInit();
			// 
			// group1
			// 
			this.group1.BeginInit();
			this.group1.Name = "group1";
			this.group1.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.rectangle1,
			this.HighBar,
			this.HighHighBar,
			this.LowBar,
			this.LowLowBar,
			this.ShowLevel,
			this.PvMin,
			this.PvMax,
			this.High,
			this.HighHigh,
			this.Low,
			this.LowLow,
			this.Unit2,
			this.Unit3});
			this.group1.EndInit();
			// 
			// iFlowSensor
			// 
			this.iFlowSensor.BeginInit();
			this.iFlowSensor.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.iFlowSensor.IsOnlyInput = true;
			this.iFlowSensor.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.iFlowSensor.Name = "iFlowSensor";
			this.iFlowSensor.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.iFlowSensor.TagName = "iFlowSensor";
			this.iFlowSensor.Value = false;
			this.iFlowSensor.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.IFlowSensorValueChanged);
			this.iFlowSensor.EndInit();
			// 
			// HiHiDisabled
			// 
			this.HiHiDisabled.BeginInit();
			this.HiHiDisabled.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.HiHiDisabled.IsOnlyInput = true;
			this.HiHiDisabled.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.HiHiDisabled.Name = "HiHiDisabled";
			this.HiHiDisabled.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.HiHiDisabled.TagName = "HiHiDisabled";
			this.HiHiDisabled.Value = false;
			this.HiHiDisabled.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.HiHiDisabledValueChanged);
			this.HiHiDisabled.EndInit();
			// 
			// HiDisabled
			// 
			this.HiDisabled.BeginInit();
			this.HiDisabled.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.HiDisabled.IsOnlyInput = true;
			this.HiDisabled.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.HiDisabled.Name = "HiDisabled";
			this.HiDisabled.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.HiDisabled.TagName = "HiDisabled";
			this.HiDisabled.Value = false;
			this.HiDisabled.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.HiDisabledValueChanged);
			this.HiDisabled.EndInit();
			// 
			// LoDisabled
			// 
			this.LoDisabled.BeginInit();
			this.LoDisabled.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.LoDisabled.IsOnlyInput = true;
			this.LoDisabled.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.LoDisabled.Name = "LoDisabled";
			this.LoDisabled.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.LoDisabled.TagName = "LoDisabled";
			this.LoDisabled.Value = false;
			this.LoDisabled.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.LoDisabledValueChanged);
			this.LoDisabled.EndInit();
			// 
			// LoLoDisabled
			// 
			this.LoLoDisabled.BeginInit();
			this.LoLoDisabled.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.LoLoDisabled.IsOnlyInput = true;
			this.LoLoDisabled.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.LoLoDisabled.Name = "LoLoDisabled";
			this.LoLoDisabled.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.LoLoDisabled.TagName = "LoLoDisabled";
			this.LoLoDisabled.Value = false;
			this.LoLoDisabled.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.LoLoDisabledValueChanged);
			this.LoLoDisabled.EndInit();
			// 
			// fpDefault
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(270D)), ((float)(392D)));
			this.Brush = new NxtControl.Drawing.Brush("FaceplateBrush");
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.Pv,
			this.freeText1,
			this.Unit,
			this.line1,
			this.highHighBtn,
			this.highBtn,
			this.lowBtn,
			this.lowLowBtn,
			this.deviationBtn,
			this.rateOfChangeBtn,
			this.Settings,
			this.Trends,
			this.AnalogInput,
			this.LevelStatus,
			this.SetColor,
			this.L1v,
			this.L2v,
			this.LevelSp2,
			this.rectangle3,
			this.LevelSp1,
			this.rectangle2,
			this.Override,
			this.iUnit,
			this.group1,
			this.iFlowSensor,
			this.HiHiDisabled,
			this.HiDisabled,
			this.LoDisabled,
			this.LoLoDisabled});
			this.Size = new System.Drawing.Size(270, 392);

		}
		private System.HMI.Symbols.Base.FreeText<float> Pv;
		private NxtControl.GuiFramework.FreeText freeText1;
		private NxtControl.GuiFramework.FreeText Unit;
		private NxtControl.GuiFramework.Line line1;
		private System.HMI.Symbols.Base.FreeText<float> PvMin;
		private System.HMI.Symbols.Base.FreeText<float> PvMax;
		private SE.App2Base.Symbols.LimitAlarm.sButton highHighBtn;
		private SE.App2Base.Symbols.LimitAlarm.sButton highBtn;
		private SE.App2Base.Symbols.LimitAlarm.sButton lowBtn;
		private SE.App2Base.Symbols.LimitAlarm.sButton lowLowBtn;
		private SE.App2Base.Symbols.DeviationAlarm.sButton deviationBtn;
		private SE.App2Base.Symbols.ROCAlarm.sButton rateOfChangeBtn;
		private NxtControl.GuiFramework.Polygon HighHigh;
		private NxtControl.GuiFramework.Rectangle HighHighBar;
		private NxtControl.GuiFramework.Rectangle HighBar;
		private NxtControl.GuiFramework.Polygon High;
		private NxtControl.GuiFramework.Rectangle LowBar;
		private NxtControl.GuiFramework.Rectangle LowLowBar;
		private NxtControl.GuiFramework.Polygon Low;
		private NxtControl.GuiFramework.Polygon LowLow;
		private NxtControl.GuiFramework.Rectangle ShowLevel;
		private NxtControl.GuiFramework.FreeText Unit2;
		private NxtControl.GuiFramework.FreeText Unit3;
		private NxtControl.GuiFramework.Rectangle Settings;
		private NxtControl.GuiFramework.Rectangle Trends;
		private SE.Nereda.Symbols.AnalogInputBase.sDefault AnalogInput;
		private NxtControl.GuiFramework.FreeText LevelStatus;
		private NxtControl.GuiFramework.Rectangle SetColor;
		private NxtControl.GuiFramework.Rectangle rectangle1;
		private System.HMI.Symbols.Base.TextBox<float> LevelSp1;
		private System.HMI.Symbols.Base.TextBox<float> LevelSp2;
		private NxtControl.GuiFramework.Rectangle rectangle2;
		private NxtControl.GuiFramework.Rectangle rectangle3;
		private NxtControl.GuiFramework.Rectangle L1v;
		private NxtControl.GuiFramework.Rectangle L2v;
		private NxtControl.GuiFramework.FreeText Override;
		private System.HMI.Symbols.Base.Execute<string> iUnit;
		private NxtControl.GuiFramework.Group group1;
		private System.HMI.Symbols.Base.Execute<bool> iFlowSensor;
		private System.HMI.Symbols.Base.Execute<bool> HiHiDisabled;
		private System.HMI.Symbols.Base.Execute<bool> HiDisabled;
		private System.HMI.Symbols.Base.Execute<bool> LoDisabled;
		private System.HMI.Symbols.Base.Execute<bool> LoLoDisabled;
		#endregion
	}
}
