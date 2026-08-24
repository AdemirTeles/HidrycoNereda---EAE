/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 6/16/2026
 * Time: 10:36 PM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.FeedInfluentLogic
{
	/// <summary>
	/// Summary description for sHiHiAlarms.
	/// </summary>
	partial class sHiHiAlarms
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary11 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary12 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary10 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary14 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary15 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary13 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary17 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary18 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary16 = new NxtControl.GuiFramework.PropertyDictionary();
			this.EmergencyStop = new NxtControl.GuiFramework.RoundedRectangle();
			this.HiHiLvl_Calamity = new System.HMI.Symbols.Base.Led<bool>();
			this.HiHiLvl_SludgeBuffer = new System.HMI.Symbols.Base.Led<bool>();
			this.freeText3 = new NxtControl.GuiFramework.FreeText();
			this.freeText4 = new NxtControl.GuiFramework.FreeText();
			this.HiLevelSwitch = new System.HMI.Symbols.Base.Led<bool>();
			this.freeText5 = new NxtControl.GuiFramework.FreeText();
			this.line3 = new NxtControl.GuiFramework.Line();
			this.group1 = new NxtControl.GuiFramework.Group();
			// 
			// EmergencyStop
			// 
			this.EmergencyStop.Bounds = new NxtControl.Drawing.RectF(((float)(8D)), ((float)(8D)), ((float)(152D)), ((float)(96D)));
			this.EmergencyStop.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.EmergencyStop.Name = "EmergencyStop";
			this.EmergencyStop.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.BlinkColor("DevError"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.EmergencyStop.Radius = 8D;
			this.EmergencyStop.Text = "Pump at forced stop";
			this.EmergencyStop.TextAlignment = NxtControl.Drawing.ContentAlignment.TopCenter;
			// 
			// HiHiLvl_Calamity
			// 
			this.HiHiLvl_Calamity.BeginInit();
			this.HiHiLvl_Calamity.ColorFrame = new NxtControl.Drawing.Color("LedFrameColor");
			this.HiHiLvl_Calamity.DesignMatrix = new NxtControl.Drawing.Matrix2D(1.25D, 0D, 0D, 1.25D, 23.5D, 63.5D);
			this.HiHiLvl_Calamity.FrameSize = 33F;
			this.HiHiLvl_Calamity.IsOnlyInput = true;
			this.HiHiLvl_Calamity.Name = "HiHiLvl_Calamity";
			propertyDictionary11.Add("Color", new NxtControl.Drawing.Color(((byte)(154)), ((byte)(154)), ((byte)(154))));
			propertyDictionary12.Add("Color", new NxtControl.Drawing.BlinkColor("SE.Nereda.DevLEDRedFlash"));
			this.HiHiLvl_Calamity.Ranges.Clear();
			this.HiHiLvl_Calamity.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(false, propertyDictionary11));
			this.HiHiLvl_Calamity.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(true, propertyDictionary12));
			propertyDictionary10.Add("Color", new NxtControl.Drawing.Color("LedFalseColor"));
			this.HiHiLvl_Calamity.Ranges.DefaultPropertyValues = propertyDictionary10;
			this.HiHiLvl_Calamity.TagName = "HiHiCalamity";
			this.HiHiLvl_Calamity.EndInit();
			// 
			// HiHiLvl_SludgeBuffer
			// 
			this.HiHiLvl_SludgeBuffer.BeginInit();
			this.HiHiLvl_SludgeBuffer.ColorFrame = new NxtControl.Drawing.Color("LedFrameColor");
			this.HiHiLvl_SludgeBuffer.DesignMatrix = new NxtControl.Drawing.Matrix2D(1.25D, 0D, 0D, 1.25D, 23.5D, 39.5D);
			this.HiHiLvl_SludgeBuffer.FrameSize = 33F;
			this.HiHiLvl_SludgeBuffer.IsOnlyInput = true;
			this.HiHiLvl_SludgeBuffer.Name = "HiHiLvl_SludgeBuffer";
			propertyDictionary14.Add("Color", new NxtControl.Drawing.Color(((byte)(154)), ((byte)(154)), ((byte)(154))));
			propertyDictionary15.Add("Color", new NxtControl.Drawing.BlinkColor("SE.Nereda.DevLEDRedFlash"));
			this.HiHiLvl_SludgeBuffer.Ranges.Clear();
			this.HiHiLvl_SludgeBuffer.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(false, propertyDictionary14));
			this.HiHiLvl_SludgeBuffer.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(true, propertyDictionary15));
			propertyDictionary13.Add("Color", new NxtControl.Drawing.Color("LedFalseColor"));
			this.HiHiLvl_SludgeBuffer.Ranges.DefaultPropertyValues = propertyDictionary13;
			this.HiHiLvl_SludgeBuffer.TagName = "HiHiSB";
			this.HiHiLvl_SludgeBuffer.EndInit();
			// 
			// freeText3
			// 
			this.freeText3.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText3.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText3.Location = new NxtControl.Drawing.PointF(33D, 32D);
			this.freeText3.Name = "freeText3";
			this.freeText3.Text = "HiHi Level SB";
			// 
			// freeText4
			// 
			this.freeText4.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText4.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText4.Location = new NxtControl.Drawing.PointF(33D, 56D);
			this.freeText4.Name = "freeText4";
			this.freeText4.Text = "HiHi Level CALAMITY";
			// 
			// HiLevelSwitch
			// 
			this.HiLevelSwitch.BeginInit();
			this.HiLevelSwitch.ColorFrame = new NxtControl.Drawing.Color("LedFrameColor");
			this.HiLevelSwitch.DesignMatrix = new NxtControl.Drawing.Matrix2D(1.25D, 0D, 0D, 1.25D, 23.5D, 87.5D);
			this.HiLevelSwitch.FrameSize = 33F;
			this.HiLevelSwitch.IsOnlyInput = true;
			this.HiLevelSwitch.Name = "HiLevelSwitch";
			propertyDictionary17.Add("Color", new NxtControl.Drawing.Color(((byte)(154)), ((byte)(154)), ((byte)(154))));
			propertyDictionary18.Add("Color", new NxtControl.Drawing.BlinkColor("SE.Nereda.DevLEDRedFlash"));
			this.HiLevelSwitch.Ranges.Clear();
			this.HiLevelSwitch.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(false, propertyDictionary17));
			this.HiLevelSwitch.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(true, propertyDictionary18));
			propertyDictionary16.Add("Color", new NxtControl.Drawing.Color("LedFalseColor"));
			this.HiLevelSwitch.Ranges.DefaultPropertyValues = propertyDictionary16;
			this.HiLevelSwitch.TagName = "SwitchLevelCalamity";
			this.HiLevelSwitch.EndInit();
			// 
			// freeText5
			// 
			this.freeText5.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText5.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText5.Location = new NxtControl.Drawing.PointF(32D, 80D);
			this.freeText5.Name = "freeText5";
			this.freeText5.Text = "Level Switch CALAMITY";
			// 
			// line3
			// 
			this.line3.EndPoint = new NxtControl.Drawing.PointF(160D, 24D);
			this.line3.Name = "line3";
			this.line3.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.BlinkColor("DevError"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line3.StartPoint = new NxtControl.Drawing.PointF(8D, 24D);
			// 
			// group1
			// 
			this.group1.BeginInit();
			this.group1.Name = "group1";
			this.group1.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.EmergencyStop,
			this.HiHiLvl_Calamity,
			this.HiHiLvl_SludgeBuffer,
			this.freeText3,
			this.freeText4,
			this.HiLevelSwitch,
			this.freeText5,
			this.line3});
			this.group1.EndInit();
			// 
			// sHiHiAlarms
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.group1});
			this.SymbolSize = new System.Drawing.Size(184, 128);

		}
		private NxtControl.GuiFramework.RoundedRectangle EmergencyStop;
		private System.HMI.Symbols.Base.Led<bool> HiHiLvl_Calamity;
		private System.HMI.Symbols.Base.Led<bool> HiHiLvl_SludgeBuffer;
		private NxtControl.GuiFramework.FreeText freeText3;
		private NxtControl.GuiFramework.FreeText freeText4;
		private System.HMI.Symbols.Base.Led<bool> HiLevelSwitch;
		private NxtControl.GuiFramework.FreeText freeText5;
		private NxtControl.GuiFramework.Line line3;
		private NxtControl.GuiFramework.Group group1;
		#endregion
	}
}
