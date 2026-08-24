/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 6/29/2026
 * Time: 10:07 AM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.CalamityValveLogic
{
	/// <summary>
	/// Summary description for sSettings.
	/// </summary>
	partial class sSettings
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.freeText2 = new NxtControl.GuiFramework.FreeText();
			this.OpeningValveDurSp = new System.HMI.Symbols.Base.TimeTextBox();
			this.ValveName = new NxtControl.GuiFramework.FreeText();
			// 
			// freeText2
			// 
			this.freeText2.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText2.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.freeText2.Location = new NxtControl.Drawing.PointF(16D, 28D);
			this.freeText2.Name = "freeText2";
			this.freeText2.Text = "Opening duration -";
			// 
			// OpeningValveDurSp
			// 
			this.OpeningValveDurSp.BeginInit();
			this.OpeningValveDurSp.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.64D, 0D, 0D, 1D, 240D, 24D);
			this.OpeningValveDurSp.MaximumTag = null;
			this.OpeningValveDurSp.MinimumTag = null;
			this.OpeningValveDurSp.Name = "OpeningValveDurSp";
			this.OpeningValveDurSp.TagName = "OpeningValveDurSp";
			this.OpeningValveDurSp.UseInputPad = true;
			this.OpeningValveDurSp.Value = new NxtControl.GuiFramework.Time(((long)(0)));
			this.OpeningValveDurSp.EndInit();
			// 
			// ValveName
			// 
			this.ValveName.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.ValveName.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.ValveName.Location = new NxtControl.Drawing.PointF(144D, 28D);
			this.ValveName.Name = "ValveName";
			this.ValveName.Text = "Valve xxx :";
			// 
			// sSettings
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.freeText2,
			this.OpeningValveDurSp,
			this.ValveName});
			this.SymbolSize = new System.Drawing.Size(448, 184);

		}
		private NxtControl.GuiFramework.FreeText freeText2;
		private System.HMI.Symbols.Base.TimeTextBox OpeningValveDurSp;
		private NxtControl.GuiFramework.FreeText ValveName;
		#endregion
	}
}
