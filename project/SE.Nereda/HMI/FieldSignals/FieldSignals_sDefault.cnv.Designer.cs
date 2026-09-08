/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 3/5/2026
 * Time: 9:16 AM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.FieldSignals
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
			this.roundedRectangle2 = new NxtControl.GuiFramework.RoundedRectangle();
			this.freeText3 = new NxtControl.GuiFramework.FreeText();
			this.LT004 = new NxtControl.GuiFramework.FreeText();
			this.freeText5 = new NxtControl.GuiFramework.FreeText();
			this.roundedRectangle3 = new NxtControl.GuiFramework.RoundedRectangle();
			// 
			// roundedRectangle2
			// 
			this.roundedRectangle2.Bounds = new NxtControl.Drawing.RectF(((float)(8D)), ((float)(8D)), ((float)(264D)), ((float)(304D)));
			this.roundedRectangle2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(245)), ((byte)(245)), ((byte)(245))));
			this.roundedRectangle2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.roundedRectangle2.Name = "roundedRectangle2";
			// 
			// freeText3
			// 
			this.freeText3.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText3.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText3.Location = new NxtControl.Drawing.PointF(16D, 88D);
			this.freeText3.Name = "freeText3";
			this.freeText3.Text = "Frequency Inverter Failure :";
			// 
			// LT004
			// 
			this.LT004.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.LT004.Font = new NxtControl.Drawing.Font("LabelFont");
			this.LT004.Location = new NxtControl.Drawing.PointF(16D, 64D);
			this.LT004.Name = "LT004";
			this.LT004.Text = "Safety Switch OFF :";
			// 
			// freeText5
			// 
			this.freeText5.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText5.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText5.Location = new NxtControl.Drawing.PointF(16D, 40D);
			this.freeText5.Name = "freeText5";
			this.freeText5.Text = "Electric Circuit Failure :";
			// 
			// roundedRectangle3
			// 
			this.roundedRectangle3.Bounds = new NxtControl.Drawing.RectF(((float)(8D)), ((float)(8D)), ((float)(264D)), ((float)(24D)));
			this.roundedRectangle3.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(215)), ((byte)(215)), ((byte)(215))));
			this.roundedRectangle3.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.roundedRectangle3.Name = "roundedRectangle3";
			this.roundedRectangle3.Text = "Flushing Grit Screen Installation Conditions";
			this.roundedRectangle3.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			// 
			// sDefault
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.roundedRectangle2,
			this.freeText3,
			this.LT004,
			this.freeText5,
			this.roundedRectangle3});
			this.SymbolSize = new System.Drawing.Size(600, 400);

		}
		private NxtControl.GuiFramework.RoundedRectangle roundedRectangle2;
		private NxtControl.GuiFramework.FreeText freeText3;
		private NxtControl.GuiFramework.FreeText LT004;
		private NxtControl.GuiFramework.FreeText freeText5;
		private NxtControl.GuiFramework.RoundedRectangle roundedRectangle3;
		#endregion
	}
}
