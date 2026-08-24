/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 6/29/2026
 * Time: 10:22 AM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.OpeningValveDurLogic
{
	/// <summary>
	/// Summary description for sDuration.
	/// </summary>
	partial class sDuration
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.ValveName = new NxtControl.GuiFramework.FreeText();
			this.rectangle1 = new NxtControl.GuiFramework.Rectangle();
			this.OpeningValveDur = new SE.Nereda.Symbols.E_DELAY_V_D.sCounter();
			// 
			// ValveName
			// 
			this.ValveName.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.ValveName.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.ValveName.Location = new NxtControl.Drawing.PointF(12D, 18D);
			this.ValveName.Name = "ValveName";
			this.ValveName.Text = "Valve xxx :";
			// 
			// rectangle1
			// 
			this.rectangle1.Bounds = new NxtControl.Drawing.RectF(((float)(8D)), ((float)(16D)), ((float)(360D)), ((float)(16D)));
			this.rectangle1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(245)), ((byte)(245)), ((byte)(245))));
			this.rectangle1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle1.Name = "rectangle1";
			// 
			// OpeningValveDur
			// 
			this.OpeningValveDur.BeginInit();
			this.OpeningValveDur.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 96D, 15D);
			this.OpeningValveDur.Name = "OpeningValveDur";
			this.OpeningValveDur.SecurityToken = ((uint)(4294967295u));
			this.OpeningValveDur.TagName = "OpeningValveDur";
			this.OpeningValveDur.EndInit();
			// 
			// sDuration
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.rectangle1,
			this.ValveName,
			this.OpeningValveDur});
			this.SymbolSize = new System.Drawing.Size(456, 200);

		}
		private NxtControl.GuiFramework.FreeText ValveName;
		private NxtControl.GuiFramework.Rectangle rectangle1;
		private SE.Nereda.Symbols.E_DELAY_V_D.sCounter OpeningValveDur;
		#endregion
	}
}
