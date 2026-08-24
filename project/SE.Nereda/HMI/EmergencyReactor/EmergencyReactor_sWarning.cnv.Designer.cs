/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 7/15/2026
 * Time: 5:35 PM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.EmergencyReactor
{
	/// <summary>
	/// Summary description for sWarning.
	/// </summary>
	partial class sWarning
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.rectangle5 = new NxtControl.GuiFramework.Rectangle();
			this.rectangle6 = new NxtControl.GuiFramework.Rectangle();
			this.group1 = new NxtControl.GuiFramework.Group();
			// 
			// rectangle5
			// 
			this.rectangle5.Bounds = new NxtControl.Drawing.RectF(((float)(88D)), ((float)(24D)), ((float)(224D)), ((float)(440D)));
			this.rectangle5.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("transparent"));
			this.rectangle5.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle5.Name = "rectangle5";
			this.rectangle5.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.BlinkColor("SE.HwCommon.DevLEDOrangeRedFlash"), 2F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// rectangle6
			// 
			this.rectangle6.Bounds = new NxtControl.Drawing.RectF(((float)(88D)), ((float)(24D)), ((float)(224D)), ((float)(72D)));
			this.rectangle6.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular);
			this.rectangle6.Name = "rectangle6";
			this.rectangle6.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.BlinkColor("SE.HwCommon.DevLEDOrangeRedFlash"), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.rectangle6.Text = "Sum of Steps Duration Exceeds The Actual Reactor Cycle Time";
			this.rectangle6.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			// 
			// group1
			// 
			this.group1.BeginInit();
			this.group1.Name = "group1";
			this.group1.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.rectangle5,
			this.rectangle6});
			this.group1.EndInit();
			// 
			// sWarning
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.group1});
			this.SymbolSize = new System.Drawing.Size(440, 696);

		}
		private NxtControl.GuiFramework.Rectangle rectangle5;
		private NxtControl.GuiFramework.Rectangle rectangle6;
		private NxtControl.GuiFramework.Group group1;
		#endregion
	}
}
