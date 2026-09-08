/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 6/15/2026
 * Time: 10:37 PM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.DigitalInput
{
	/// <summary>
	/// Summary description for sDIn4.
	/// </summary>
	partial class sDIn4
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary2 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary3 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary1 = new NxtControl.GuiFramework.PropertyDictionary();
			this.Pv = new System.HMI.Symbols.Base.Led<bool>();
			this.OpenFp = new NxtControl.GuiFramework.Rectangle();
			this.DigitalInput = new SE.App2CommonProcess.Symbols.DigitalInputBase.sRoundIndicator();
			this.group1 = new NxtControl.GuiFramework.Group();
			// 
			// Pv
			// 
			this.Pv.BeginInit();
			this.Pv.ColorFrame = new NxtControl.Drawing.Color("LedFrameColor");
			this.Pv.DesignMatrix = new NxtControl.Drawing.Matrix2D(1.6666666666666667D, 0D, 0D, 1.6666666666666667D, 18D, 18D);
			this.Pv.FrameSize = 33F;
			this.Pv.IsOnlyInput = true;
			this.Pv.Name = "Pv";
			propertyDictionary2.Add("Color", new NxtControl.Drawing.Color(((byte)(0)), ((byte)(255)), ((byte)(0))));
			propertyDictionary3.Add("Color", new NxtControl.Drawing.Color(((byte)(255)), ((byte)(0)), ((byte)(0))));
			this.Pv.Ranges.Clear();
			this.Pv.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(false, propertyDictionary2));
			this.Pv.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(true, propertyDictionary3));
			propertyDictionary1.Add("Color", new NxtControl.Drawing.Color("LedFalseColor"));
			this.Pv.Ranges.DefaultPropertyValues = propertyDictionary1;
			this.Pv.TagName = "Pv";
			this.Pv.EndInit();
			// 
			// OpenFp
			// 
			this.OpenFp.Bounds = new NxtControl.Drawing.RectF(((float)(6D)), ((float)(6D)), ((float)(24D)), ((float)(24D)));
			this.OpenFp.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("transparent"));
			this.OpenFp.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.OpenFp.Name = "OpenFp";
			this.OpenFp.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.OpenFp.Click += new System.EventHandler(this.OpenFpClick);
			// 
			// DigitalInput
			// 
			this.DigitalInput.BeginInit();
			this.DigitalInput.DefaultInstanceName = null;
			this.DigitalInput.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.13793103448275862D, 0D, 0D, 0.13793103448275862D, 14D, 15D);
			this.DigitalInput.FalseColor = new NxtControl.Drawing.Color("SE.App2Base.aaLibSymBodyPassive");
			this.DigitalInput.FalseText = "TxtOFF";
			this.DigitalInput.Instancelayer = SE.App2Base.SupportClasses.InstanceLayer.Base;
			this.DigitalInput.MyTagDisplayName = null;
			this.DigitalInput.Name = "DigitalInput";
			this.DigitalInput.SecurityToken = ((uint)(4294967175u));
			this.DigitalInput.TagName = "DigitalInput";
			this.DigitalInput.TrueColor = new NxtControl.Drawing.Color("SE.App2Base.aaLibSymBodyActive");
			this.DigitalInput.TrueText = "TxtON";
			this.DigitalInput.EndInit();
			// 
			// group1
			// 
			this.group1.BeginInit();
			this.group1.Name = "group1";
			this.group1.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.DigitalInput,
			this.Pv,
			this.OpenFp});
			this.group1.EndInit();
			// 
			// sDIn4
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.group1});
			this.SymbolSize = new System.Drawing.Size(200, 200);

		}
		private System.HMI.Symbols.Base.Led<bool> Pv;
		private NxtControl.GuiFramework.Rectangle OpenFp;
		private SE.App2CommonProcess.Symbols.DigitalInputBase.sRoundIndicator DigitalInput;
		private NxtControl.GuiFramework.Group group1;
		#endregion
	}
}
