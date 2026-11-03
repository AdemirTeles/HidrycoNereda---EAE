/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 10/23/2026
 * Time: 9:01 AM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;

using NxtControl.GuiFramework;

namespace HMI.Main.Canvases
{
	/// <summary>
	/// Summary description for SB_EMERGENCY_RECIPE.
	/// </summary>
	partial class SB_EMERGENCY_RECIPE
	{
		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.EmergencySB = new SE.Nereda.Symbols.EmergencySludgeBuffer.Symbol1();
			// 
			// EmergencySB
			// 
			this.EmergencySB.BeginInit();
			this.EmergencySB.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 64D, 184D);
			this.EmergencySB.Name = "EmergencySB";
			this.EmergencySB.SecurityToken = ((uint)(4294967295u));
			this.EmergencySB.TagName = "9C8DCCD6030E46A0";
			this.EmergencySB.EndInit();
			// 
			// SB_EMERGENCY_RECIPE
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(1366D)), ((float)(698D)));
			this.Brush = new NxtControl.Drawing.Brush("CanvasBrush");
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.EmergencySB});
			this.Size = new System.Drawing.Size(1366, 698);

		}
		private SE.Nereda.Symbols.EmergencySludgeBuffer.Symbol1 EmergencySB;
		#endregion
	}
}
