/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 10/6/2026
 * Time: 3:58 PM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using NxtControl.GuiFramework;

namespace SE.Nereda.Faceplates.NextFeedHorizonDiag
{
	/// <summary>
	/// Summary description for fpDiag.
	/// </summary>
	partial class fpDiag2
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fpDiag2));
			this.Calc = new NxtControl.GuiFramework.FreeText();
			this.freeText4 = new NxtControl.GuiFramework.FreeText();
			this.rectangle4 = new NxtControl.GuiFramework.Rectangle();
			this.rectangle5 = new NxtControl.GuiFramework.Rectangle();
			// 
			// Calc
			// 
			this.Calc.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.Calc.Font = new NxtControl.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
			this.Calc.Location = new NxtControl.Drawing.PointF(16D, 40D);
			this.Calc.Name = "Calc";
			this.Calc.Text = "Equation";
			// 
			// freeText4
			// 
			this.freeText4.Color = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.freeText4.Font = new NxtControl.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
			this.freeText4.Location = new NxtControl.Drawing.PointF(16D, 8D);
			this.freeText4.Name = "freeText4";
			this.freeText4.Text = "Current Calculation :";
			// 
			// rectangle4
			// 
			this.rectangle4.Bounds = new NxtControl.Drawing.RectF(((float)(8D)), ((float)(32D)), ((float)(544D)), ((float)(32D)));
			this.rectangle4.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle4.Name = "rectangle4";
			// 
			// rectangle5
			// 
			this.rectangle5.Bounds = new NxtControl.Drawing.RectF(((float)(8D)), ((float)(72D)), ((float)(544D)), ((float)(40D)));
			this.rectangle5.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle5.ImageBytes = resources.GetString("rectangle5.ImageBytes");
			this.rectangle5.Name = "rectangle5";
			// 
			// fpDiag2
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(560D)), ((float)(120D)));
			this.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(114)), ((byte)(114)), ((byte)(114))));
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.rectangle4,
			this.Calc,
			this.freeText4,
			this.rectangle5});
			this.Size = new System.Drawing.Size(560, 120);
			this.Title = "Next Feed Horizon Diagnostic";

		}
		private NxtControl.GuiFramework.FreeText Calc;
		private NxtControl.GuiFramework.FreeText freeText4;
		private NxtControl.GuiFramework.Rectangle rectangle4;
		private NxtControl.GuiFramework.Rectangle rectangle5;
		#endregion
	}
}
