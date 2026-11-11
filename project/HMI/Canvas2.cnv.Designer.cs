/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 11/10/2026
 * Time: 1:29 PM
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
	/// Summary description for Canvas2.
	/// </summary>
	partial class Canvas2
	{
		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.EEEB_A2_DI32K0 = new Hidryco.HidrycoLib.Symbols.IO_DI32.sDefault();
			this.EEEB_A3_DQ32TK0 = new Hidryco.HidrycoLib.Symbols.IO_DQ32.sDefault();
			// 
			// EEEB_A2_DI32K0
			// 
			this.EEEB_A2_DI32K0.BeginInit();
			this.EEEB_A2_DI32K0.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 64D, 40D);
			this.EEEB_A2_DI32K0.Name = "EEEB_A2_DI32K0";
			this.EEEB_A2_DI32K0.SecurityToken = ((uint)(4294967295u));
			this.EEEB_A2_DI32K0.TagName = "3279F1FC19862FC5";
			this.EEEB_A2_DI32K0.EndInit();
			// 
			// EEEB_A3_DQ32TK0
			// 
			this.EEEB_A3_DQ32TK0.BeginInit();
			this.EEEB_A3_DQ32TK0.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 544D, 32D);
			this.EEEB_A3_DQ32TK0.Name = "EEEB_A3_DQ32TK0";
			this.EEEB_A3_DQ32TK0.SecurityToken = ((uint)(4294967295u));
			this.EEEB_A3_DQ32TK0.TagName = "4C518970B8E10B12";
			this.EEEB_A3_DQ32TK0.EndInit();
			// 
			// Canvas2
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(1366D)), ((float)(698D)));
			this.Brush = new NxtControl.Drawing.Brush("CanvasBrush");
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.EEEB_A2_DI32K0,
			this.EEEB_A3_DQ32TK0});
			this.Size = new System.Drawing.Size(1366, 698);

		}
		private Hidryco.HidrycoLib.Symbols.IO_DI32.sDefault EEEB_A2_DI32K0;
		private Hidryco.HidrycoLib.Symbols.IO_DQ32.sDefault EEEB_A3_DQ32TK0;
		#endregion
	}
}
