/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 7/7/2026
 * Time: 9:46 PM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.EmergencyReactor
{
	/// <summary>
	/// Summary description for sDelayAfterCycle.
	/// </summary>
	partial class sDelayAfterCycle
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.freeText4 = new NxtControl.GuiFramework.FreeText();
			this.rectangle1 = new NxtControl.GuiFramework.Rectangle();
			// 
			// freeText4
			// 
			this.freeText4.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText4.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.freeText4.Location = new NxtControl.Drawing.PointF(16D, 18D);
			this.freeText4.Name = "freeText4";
			this.freeText4.Text = "Delay After Cycle :";
			// 
			// rectangle1
			// 
			this.rectangle1.Bounds = new NxtControl.Drawing.RectF(((float)(8D)), ((float)(8D)), ((float)(224D)), ((float)(48D)));
			this.rectangle1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("transparent"));
			this.rectangle1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle1.Name = "rectangle1";
			// 
			// sDelayAfterCycle
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.rectangle1,
			this.freeText4});
			this.SymbolSize = new System.Drawing.Size(328, 464);

		}
		private NxtControl.GuiFramework.FreeText freeText4;
		private NxtControl.GuiFramework.Rectangle rectangle1;
		#endregion
	}
}
