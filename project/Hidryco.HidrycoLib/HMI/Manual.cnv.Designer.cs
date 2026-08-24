/*
 * Criado pelo EcoStruxure Automation Expert.
 * Usuário:  
 * Data: 11/03/2026
 * Tempo: 16:07
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Graphics
{
	/// <summary>
	/// Summary description for Manual.
	/// </summary>
	partial class Manual
	{
		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.rectangle1 = new NxtControl.GuiFramework.Rectangle();
			this.freeText1 = new NxtControl.GuiFramework.FreeText();
			// 
			// rectangle1
			// 
			this.rectangle1.Bounds = new NxtControl.Drawing.RectF(((float)(60D)), ((float)(16D)), ((float)(32D)), ((float)(32D)));
			this.rectangle1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle1.Name = "rectangle1";
			// 
			// freeText1
			// 
			this.freeText1.Color = new NxtControl.Drawing.Color("LabelTextColor");
			this.freeText1.Font = new NxtControl.Drawing.Font("AcadEref", 12F, System.Drawing.FontStyle.Bold);
			this.freeText1.Location = new NxtControl.Drawing.PointF(67D, 22D);
			this.freeText1.Name = "freeText1";
			this.freeText1.Text = "M";
			// 
			// Manual
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.rectangle1,
			this.freeText1});
			this.SymbolSize = new System.Drawing.Size(200, 144);

		}
		private NxtControl.GuiFramework.Rectangle rectangle1;
		private NxtControl.GuiFramework.FreeText freeText1;
		#endregion
	}
}
