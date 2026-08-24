/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 7/20/2026
 * Time: 5:05 PM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.OpeningValveDurLogic
{
	/// <summary>
	/// Summary description for sDurSetPoint.
	/// </summary>
	partial class sDurSetPoint
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.OpeningValveDurSp = new System.HMI.Symbols.Base.TimeTextBox();
			// 
			// OpeningValveDurSp
			// 
			this.OpeningValveDurSp.BeginInit();
			this.OpeningValveDurSp.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.64D, 0D, 0D, 1D, 40D, 64D);
			this.OpeningValveDurSp.MaximumTag = null;
			this.OpeningValveDurSp.MinimumTag = null;
			this.OpeningValveDurSp.Name = "OpeningValveDurSp";
			this.OpeningValveDurSp.TagName = "OpeningValveDurSp";
			this.OpeningValveDurSp.TextColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.OpeningValveDurSp.Value = new NxtControl.GuiFramework.Time(((long)(0)));
			this.OpeningValveDurSp.EndInit();
			// 
			// sDurSetPoint
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.OpeningValveDurSp});
			this.SymbolSize = new System.Drawing.Size(200, 200);

		}
		private System.HMI.Symbols.Base.TimeTextBox OpeningValveDurSp;
		#endregion
	}
}
