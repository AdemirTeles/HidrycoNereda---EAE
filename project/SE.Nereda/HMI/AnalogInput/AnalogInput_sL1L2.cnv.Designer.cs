/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 6/10/2026
 * Time: 12:05 PM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.AnalogInput
{
	/// <summary>
	/// Summary description for sL1L2.
	/// </summary>
	partial class sL1L2
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
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary5 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary6 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary4 = new NxtControl.GuiFramework.PropertyDictionary();
			this.freeText1 = new NxtControl.GuiFramework.FreeText();
			this.line1 = new NxtControl.GuiFramework.Line();
			this.freeText2 = new NxtControl.GuiFramework.FreeText();
			this.freeText3 = new NxtControl.GuiFramework.FreeText();
			this.L1 = new System.HMI.Symbols.Base.Led<bool>();
			this.L2 = new System.HMI.Symbols.Base.Led<bool>();
			// 
			// freeText1
			// 
			this.freeText1.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText1.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.freeText1.Location = new NxtControl.Drawing.PointF(8D, 8D);
			this.freeText1.Name = "freeText1";
			this.freeText1.Text = "Reactor Level Sensor:";
			// 
			// line1
			// 
			this.line1.EndPoint = new NxtControl.Drawing.PointF(72D, 40D);
			this.line1.Name = "line1";
			this.line1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line1.StartPoint = new NxtControl.Drawing.PointF(72D, 24D);
			// 
			// freeText2
			// 
			this.freeText2.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText2.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText2.Location = new NxtControl.Drawing.PointF(8D, 24D);
			this.freeText2.Name = "freeText2";
			this.freeText2.Text = "L1 :";
			// 
			// freeText3
			// 
			this.freeText3.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText3.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText3.Location = new NxtControl.Drawing.PointF(80D, 24D);
			this.freeText3.Name = "freeText3";
			this.freeText3.Text = "L2 :";
			// 
			// L1
			// 
			this.L1.BeginInit();
			this.L1.ColorFrame = new NxtControl.Drawing.Color("LedFrameColor");
			this.L1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 46D, 30D);
			this.L1.FrameSize = 33F;
			this.L1.IsOnlyInput = true;
			this.L1.Name = "L1";
			propertyDictionary2.Add("Color", new NxtControl.Drawing.Color("LedFalseColor"));
			propertyDictionary3.Add("Color", new NxtControl.Drawing.Color("DevAnalogOut"));
			this.L1.Ranges.Clear();
			this.L1.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(false, propertyDictionary2));
			this.L1.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(true, propertyDictionary3));
			propertyDictionary1.Add("Color", new NxtControl.Drawing.Color("LedFalseColor"));
			this.L1.Ranges.DefaultPropertyValues = propertyDictionary1;
			this.L1.TagName = "L1";
			this.L1.EndInit();
			// 
			// L2
			// 
			this.L2.BeginInit();
			this.L2.ColorFrame = new NxtControl.Drawing.Color("LedFrameColor");
			this.L2.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 118D, 30D);
			this.L2.FrameSize = 33F;
			this.L2.IsOnlyInput = true;
			this.L2.Name = "L2";
			propertyDictionary5.Add("Color", new NxtControl.Drawing.Color("LedFalseColor"));
			propertyDictionary6.Add("Color", new NxtControl.Drawing.Color("DevAnalogOut"));
			this.L2.Ranges.Clear();
			this.L2.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(false, propertyDictionary5));
			this.L2.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(true, propertyDictionary6));
			propertyDictionary4.Add("Color", new NxtControl.Drawing.Color("LedFalseColor"));
			this.L2.Ranges.DefaultPropertyValues = propertyDictionary4;
			this.L2.TagName = "L2";
			this.L2.EndInit();
			// 
			// sL1L2
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.freeText1,
			this.line1,
			this.freeText2,
			this.freeText3,
			this.L1,
			this.L2});
			this.SymbolSize = new System.Drawing.Size(200, 200);

		}
		private NxtControl.GuiFramework.FreeText freeText1;
		private NxtControl.GuiFramework.Line line1;
		private NxtControl.GuiFramework.FreeText freeText2;
		private NxtControl.GuiFramework.FreeText freeText3;
		private System.HMI.Symbols.Base.Led<bool> L1;
		private System.HMI.Symbols.Base.Led<bool> L2;
		#endregion
	}
}
