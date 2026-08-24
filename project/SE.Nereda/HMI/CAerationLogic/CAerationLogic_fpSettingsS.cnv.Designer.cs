/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 6/11/2026
 * Time: 3:14 PM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using NxtControl.GuiFramework;

namespace SE.Nereda.Faceplates.CAerationLogic
{
	/// <summary>
	/// Summary description for fpSettings.
	/// </summary>
	partial class fpSettingsS
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.rectangle1 = new NxtControl.GuiFramework.Rectangle();
			this.freeText2 = new NxtControl.GuiFramework.FreeText();
			this.C2_IN = new System.HMI.Symbols.Base.TextBox<float>();
			this.freeText3 = new NxtControl.GuiFramework.FreeText();
			this.C3_IN = new System.HMI.Symbols.Base.TextBox<float>();
			// 
			// rectangle1
			// 
			this.rectangle1.Bounds = new NxtControl.Drawing.RectF(((float)(8D)), ((float)(8D)), ((float)(368D)), ((float)(80D)));
			this.rectangle1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(250)), ((byte)(250)), ((byte)(250))));
			this.rectangle1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle1.Name = "rectangle1";
			// 
			// freeText2
			// 
			this.freeText2.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText2.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.freeText2.Location = new NxtControl.Drawing.PointF(16D, 20D);
			this.freeText2.Name = "freeText2";
			this.freeText2.Text = "Starting 2nd Blower Sp (C2) :";
			// 
			// C2_IN
			// 
			this.C2_IN.BeginInit();
			this.C2_IN.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.58666666666666667D, 0D, 0D, 1D, 256D, 16D);
			this.C2_IN.MaximumTag = null;
			this.C2_IN.MinimumTag = null;
			this.C2_IN.Name = "C2_IN";
			this.C2_IN.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.C2_IN.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Black"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.C2_IN.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.C2_IN.Suffix = "%";
			this.C2_IN.TagName = "C2_IN";
			this.C2_IN.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			this.C2_IN.TextColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.C2_IN.UseInputPad = true;
			this.C2_IN.Value = 0F;
			this.C2_IN.EndInit();
			// 
			// freeText3
			// 
			this.freeText3.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText3.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.freeText3.Location = new NxtControl.Drawing.PointF(16D, 52D);
			this.freeText3.Name = "freeText3";
			this.freeText3.Text = "Starting 3rd Blower Sp (C3) :";
			// 
			// C3_IN
			// 
			this.C3_IN.BeginInit();
			this.C3_IN.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.58666666666666667D, 0D, 0D, 1D, 256D, 48D);
			this.C3_IN.MaximumTag = null;
			this.C3_IN.MinimumTag = null;
			this.C3_IN.Name = "C3_IN";
			this.C3_IN.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.C3_IN.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Black"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.C3_IN.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.C3_IN.Suffix = "%";
			this.C3_IN.TagName = "C3_IN";
			this.C3_IN.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			this.C3_IN.TextColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.C3_IN.UseInputPad = true;
			this.C3_IN.Value = 0F;
			this.C3_IN.EndInit();
			// 
			// fpSettingsS
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(384D)), ((float)(96D)));
			this.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(154)), ((byte)(154)), ((byte)(154))));
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.rectangle1,
			this.freeText2,
			this.C2_IN,
			this.freeText3,
			this.C3_IN});
			this.Size = new System.Drawing.Size(384, 96);
			this.Title = "Aeration Settings";

		}
		private NxtControl.GuiFramework.Rectangle rectangle1;
		private NxtControl.GuiFramework.FreeText freeText2;
		private System.HMI.Symbols.Base.TextBox<float> C2_IN;
		private NxtControl.GuiFramework.FreeText freeText3;
		private System.HMI.Symbols.Base.TextBox<float> C3_IN;
		#endregion
	}
}
