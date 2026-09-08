/*
 * Created by EcoStruxure Automation Expert.
 * User: SESA713705
 * Date: 8/20/2024
 * Time: 3:40 PM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.ResetValvesManager
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
			this.Reset = new System.HMI.Symbols.Base.CheckButton();
			// 
			// Reset
			// 
			this.Reset.BeginInit();
			this.Reset.DesignMatrix = new NxtControl.Drawing.Matrix2D(1.8D, 0D, 0D, 1D, 8D, 8D);
			this.Reset.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.Reset.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.Reset.FalseText = "RESET All Valves";
			this.Reset.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.Reset.FontScale = false;
			this.Reset.Name = "Reset";
			this.Reset.TagName = "Reset";
			this.Reset.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.Reset.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.Reset.TrueText = "RESET All Valves";
			this.Reset.Value = false;
			this.Reset.EndInit();
			// 
			// sDefault
			// 
			this.Name = "sDefault";
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.Reset});
			this.SymbolSize = new System.Drawing.Size(600, 400);

		}
		private System.HMI.Symbols.Base.CheckButton Reset;
		#endregion
	}
}
