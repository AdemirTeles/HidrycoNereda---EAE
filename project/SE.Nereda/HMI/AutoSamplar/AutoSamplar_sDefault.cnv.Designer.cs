/*
 * Created by EcoStruxure Automation Expert.
 * User: SESA713705
 * Date: 9/26/2024
 * Time: 11:08 AM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.AutoSamplar
{
	/// <summary>
	/// Summary description for sDefault.
	/// </summary>
	partial class sDefault
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary6 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary7 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary5 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary8 = new NxtControl.GuiFramework.PropertyDictionary();
			this.drawnButton1 = new NxtControl.GuiFramework.DrawnButton();
			this.roundedRectangle1 = new NxtControl.GuiFramework.RoundedRectangle();
			this.AutoSamplarRun = new System.HMI.Symbols.Base.Led<bool>();
			this.StateText = new NxtControl.GuiFramework.FreeText();
			this.freeText1 = new NxtControl.GuiFramework.FreeText();
			this.PulseCount = new System.HMI.Symbols.Base.FreeText<short>();
			// 
			// drawnButton1
			// 
			this.drawnButton1.Bounds = new NxtControl.Drawing.RectF(((float)(40D)), ((float)(64D)), ((float)(72D)), ((float)(25D)));
			this.drawnButton1.Brush = new NxtControl.Drawing.Brush("ButtonBrush");
			this.drawnButton1.ButtonPushedBrush = new NxtControl.Drawing.Brush(true);
			this.drawnButton1.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.drawnButton1.InnerBorderColor = new NxtControl.Drawing.Color("ButtonInnerBorderColor");
			this.drawnButton1.Name = "drawnButton1";
			this.drawnButton1.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("fpSettings", NxtControl.GuiFramework.MouseButtonType.Click));
			this.drawnButton1.Pen = new NxtControl.Drawing.Pen("ButtonPen");
			this.drawnButton1.Text = "Settings";
			this.drawnButton1.TextColor = new NxtControl.Drawing.Color("ButtonTextColor");
			this.drawnButton1.TextColorMouseDown = new NxtControl.Drawing.Color("ButtonTextColorMouseDown");
			this.drawnButton1.Use3DEffect = false;
			// 
			// roundedRectangle1
			// 
			this.roundedRectangle1.Bounds = new NxtControl.Drawing.RectF(((float)(32D)), ((float)(48D)), ((float)(128D)), ((float)(64D)));
			this.roundedRectangle1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(245)), ((byte)(245)), ((byte)(245))));
			this.roundedRectangle1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular);
			this.roundedRectangle1.Name = "roundedRectangle1";
			this.roundedRectangle1.Text = "Auto Samplar";
			this.roundedRectangle1.TextAlignment = NxtControl.Drawing.ContentAlignment.TopCenter;
			// 
			// AutoSamplarRun
			// 
			this.AutoSamplarRun.BeginInit();
			this.AutoSamplarRun.ColorFrame = new NxtControl.Drawing.Color("LedFrameColor");
			this.AutoSamplarRun.DesignMatrix = new NxtControl.Drawing.Matrix2D(1.833333333333333D, 0D, 0D, 1.833333333333333D, 139D, 75D);
			this.AutoSamplarRun.FrameSize = 33F;
			this.AutoSamplarRun.IsOnlyInput = true;
			this.AutoSamplarRun.Name = "AutoSamplarRun";
			propertyDictionary6.Add("Color", new NxtControl.Drawing.Color("LedFalseColor"));
			propertyDictionary7.Add("Color", new NxtControl.Drawing.Color("DevAnalogOut"));
			this.AutoSamplarRun.Ranges.Clear();
			this.AutoSamplarRun.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(false, propertyDictionary6));
			this.AutoSamplarRun.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(true, propertyDictionary7));
			propertyDictionary5.Add("Color", new NxtControl.Drawing.Color("LedFalseColor"));
			this.AutoSamplarRun.Ranges.DefaultPropertyValues = propertyDictionary5;
			this.AutoSamplarRun.TagName = "Pulse";
			this.AutoSamplarRun.EndInit();
			// 
			// StateText
			// 
			this.StateText.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.StateText.Font = new NxtControl.Drawing.Font("LabelFont");
			this.StateText.Location = new NxtControl.Drawing.PointF(32D, 32D);
			this.StateText.Name = "StateText";
			this.StateText.Text = "State";
			// 
			// freeText1
			// 
			this.freeText1.Color = new NxtControl.Drawing.Color("LabelTextColor");
			this.freeText1.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText1.Location = new NxtControl.Drawing.PointF(40D, 96D);
			this.freeText1.Name = "freeText1";
			this.freeText1.Text = "Pulse Nbr";
			// 
			// PulseCount
			// 
			this.PulseCount.BeginInit();
			this.PulseCount.DecimalPlacesCount = ((uint)(2u));
			this.PulseCount.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 104D, 96D);
			this.PulseCount.IsOnlyInput = true;
			this.PulseCount.Name = "PulseCount";
			propertyDictionary8.Add("Text", "${Value}");
			propertyDictionary8.Add("TextColor", new NxtControl.Drawing.Color("LabelTextColor"));
			this.PulseCount.Ranges.DefaultPropertyValues = propertyDictionary8;
			this.PulseCount.TagName = "PulseCount";
			this.PulseCount.TextAngle = 0F;
			this.PulseCount.EndInit();
			// 
			// sDefault
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.roundedRectangle1,
			this.drawnButton1,
			this.AutoSamplarRun,
			this.StateText,
			this.freeText1,
			this.PulseCount});
			this.SymbolSize = new System.Drawing.Size(600, 400);

		}
		private NxtControl.GuiFramework.DrawnButton drawnButton1;
		private NxtControl.GuiFramework.RoundedRectangle roundedRectangle1;
		private System.HMI.Symbols.Base.Led<bool> AutoSamplarRun;
		private NxtControl.GuiFramework.FreeText StateText;
		private NxtControl.GuiFramework.FreeText freeText1;
		private System.HMI.Symbols.Base.FreeText<short> PulseCount;
		#endregion
	}
}
