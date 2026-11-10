/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 10/6/2026
 * Time: 3:09 PM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.NextFeedHorizon
{
	/// <summary>
	/// Summary description for sCalc.
	/// </summary>
	partial class sCalc
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sCalc));
			this.NextFeedHorizonR1 = new System.HMI.Symbols.Base.TimeTextBox();
			this.rectangle1 = new NxtControl.GuiFramework.Rectangle();
			this.rectangle2 = new NxtControl.GuiFramework.Rectangle();
			// 
			// NextFeedHorizonR1
			// 
			this.NextFeedHorizonR1.BeginInit();
			this.NextFeedHorizonR1.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.53333333333333333D, 0D, 0D, 1D, 16D, 56D);
			this.NextFeedHorizonR1.IsOnlyInput = true;
			this.NextFeedHorizonR1.MaximumTag = null;
			this.NextFeedHorizonR1.MinimumTag = null;
			this.NextFeedHorizonR1.Name = "NextFeedHorizonR1";
			this.NextFeedHorizonR1.TagName = "NextFeedHorizonR1";
			this.NextFeedHorizonR1.Value = new NxtControl.GuiFramework.Time(((long)(0)));
			this.NextFeedHorizonR1.EndInit();
			// 
			// rectangle1
			// 
			this.rectangle1.Bounds = new NxtControl.Drawing.RectF(((float)(16D)), ((float)(24D)), ((float)(600D)), ((float)(16D)));
			this.rectangle1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle1.ImageBytes = resources.GetString("rectangle1.ImageBytes");
			this.rectangle1.Name = "rectangle1";
			// 
			// rectangle2
			// 
			this.rectangle2.Bounds = new NxtControl.Drawing.RectF(((float)(16D)), ((float)(40D)), ((float)(600D)), ((float)(16D)));
			this.rectangle2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(245)), ((byte)(245)), ((byte)(245))));
			this.rectangle2.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.rectangle2.Name = "rectangle2";
			this.rectangle2.Text = "Reactor 1";
			this.rectangle2.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			// 
			// sCalc
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.rectangle1,
			this.rectangle2,
			this.NextFeedHorizonR1});
			this.SymbolSize = new System.Drawing.Size(664, 496);

		}
		private System.HMI.Symbols.Base.TimeTextBox NextFeedHorizonR1;
		private NxtControl.GuiFramework.Rectangle rectangle1;
		private NxtControl.GuiFramework.Rectangle rectangle2;
		#endregion
	}
}
