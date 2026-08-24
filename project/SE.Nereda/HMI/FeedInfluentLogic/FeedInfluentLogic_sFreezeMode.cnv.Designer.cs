/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 6/16/2026
 * Time: 11:18 PM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.FeedInfluentLogic
{
	/// <summary>
	/// Summary description for sFreezeMode.
	/// </summary>
	partial class sFreezeMode
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
			this.freeText2 = new NxtControl.GuiFramework.FreeText();
			this.FrostProtectionActive = new System.HMI.Symbols.Base.Led<bool>();
			// 
			// freeText2
			// 
			this.freeText2.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText2.Font = new NxtControl.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular);
			this.freeText2.Location = new NxtControl.Drawing.PointF(16D, 24D);
			this.freeText2.Name = "freeText2";
			this.freeText2.Text = "Influent frost protection :";
			// 
			// FrostProtectionActive
			// 
			this.FrostProtectionActive.BeginInit();
			this.FrostProtectionActive.ColorFrame = new NxtControl.Drawing.Color("LedFrameColor");
			this.FrostProtectionActive.DesignMatrix = new NxtControl.Drawing.Matrix2D(1.5D, 0D, 0D, 1.5D, 201D, 33D);
			this.FrostProtectionActive.FrameSize = 33F;
			this.FrostProtectionActive.IsOnlyInput = true;
			this.FrostProtectionActive.Name = "FrostProtectionActive";
			propertyDictionary2.Add("Color", new NxtControl.Drawing.Color("LedFalseColor"));
			propertyDictionary3.Add("Color", new NxtControl.Drawing.BlinkColor("SE.HwCommon.DevLEDOrangeFlash"));
			this.FrostProtectionActive.Ranges.Clear();
			this.FrostProtectionActive.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(false, propertyDictionary2));
			this.FrostProtectionActive.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(true, propertyDictionary3));
			propertyDictionary1.Add("Color", new NxtControl.Drawing.Color("LedFalseColor"));
			this.FrostProtectionActive.Ranges.DefaultPropertyValues = propertyDictionary1;
			this.FrostProtectionActive.TagName = "FreezeMode";
			this.FrostProtectionActive.EndInit();
			// 
			// sFreezeMode
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.freeText2,
			this.FrostProtectionActive});
			this.SymbolSize = new System.Drawing.Size(384, 280);

		}
		private NxtControl.GuiFramework.FreeText freeText2;
		private System.HMI.Symbols.Base.Led<bool> FrostProtectionActive;
		#endregion
	}
}
