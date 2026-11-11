/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 11/10/2026
 * Time: 1:32 PM
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
	/// Summary description for Canvas3.
	/// </summary>
	partial class Canvas3
	{
		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.LODO_A3_DI32K0 = new Hidryco.HidrycoLib.Symbols.IO_DI32.sDefault();
			this.LODO_A4_DI32K0 = new Hidryco.HidrycoLib.Symbols.IO_DI32.sDefault();
			this.LODO_A5_DI32K0 = new Hidryco.HidrycoLib.Symbols.IO_DI32.sDefault();
			this.LODO_A7_DQ32TK0 = new Hidryco.HidrycoLib.Symbols.IO_DQ32.sDefault();
			// 
			// LODO_A3_DI32K0
			// 
			this.LODO_A3_DI32K0.BeginInit();
			this.LODO_A3_DI32K0.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.72783505154639183D, 0D, 0D, 0.72783505154639194D, 24D, 24D);
			this.LODO_A3_DI32K0.Name = "LODO_A3_DI32K0";
			this.LODO_A3_DI32K0.SecurityToken = ((uint)(4294967295u));
			this.LODO_A3_DI32K0.TagName = "30F3EE7E3AD8A0F5";
			this.LODO_A3_DI32K0.EndInit();
			// 
			// LODO_A4_DI32K0
			// 
			this.LODO_A4_DI32K0.BeginInit();
			this.LODO_A4_DI32K0.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.72783505154639183D, 0D, 0D, 0.72783505154639183D, 392D, 24D);
			this.LODO_A4_DI32K0.Name = "LODO_A4_DI32K0";
			this.LODO_A4_DI32K0.SecurityToken = ((uint)(4294967295u));
			this.LODO_A4_DI32K0.TagName = "65D9218EACBDB7CC";
			this.LODO_A4_DI32K0.EndInit();
			// 
			// LODO_A5_DI32K0
			// 
			this.LODO_A5_DI32K0.BeginInit();
			this.LODO_A5_DI32K0.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.72783505154639183D, 0D, 0D, 0.72783505154639194D, 704D, 344D);
			this.LODO_A5_DI32K0.Name = "LODO_A5_DI32K0";
			this.LODO_A5_DI32K0.SecurityToken = ((uint)(4294967295u));
			this.LODO_A5_DI32K0.TagName = "78E3750417D7F450";
			this.LODO_A5_DI32K0.EndInit();
			// 
			// LODO_A7_DQ32TK0
			// 
			this.LODO_A7_DQ32TK0.BeginInit();
			this.LODO_A7_DQ32TK0.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.72279260780287469D, 0D, 0D, 0.72279260780287469D, 1072D, 344D);
			this.LODO_A7_DQ32TK0.Name = "LODO_A7_DQ32TK0";
			this.LODO_A7_DQ32TK0.SecurityToken = ((uint)(4294967295u));
			this.LODO_A7_DQ32TK0.TagName = "7F6806FC163DFD68";
			this.LODO_A7_DQ32TK0.EndInit();
			// 
			// Canvas3
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(1447D)), ((float)(750D)));
			this.Brush = new NxtControl.Drawing.Brush("CanvasBrush");
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.LODO_A3_DI32K0,
			this.LODO_A4_DI32K0,
			this.LODO_A5_DI32K0,
			this.LODO_A7_DQ32TK0});
			this.Size = new System.Drawing.Size(1447, 750);

		}
		private Hidryco.HidrycoLib.Symbols.IO_DI32.sDefault LODO_A3_DI32K0;
		private Hidryco.HidrycoLib.Symbols.IO_DI32.sDefault LODO_A4_DI32K0;
		private Hidryco.HidrycoLib.Symbols.IO_DI32.sDefault LODO_A5_DI32K0;
		private Hidryco.HidrycoLib.Symbols.IO_DQ32.sDefault LODO_A7_DQ32TK0;
		#endregion
	}
}
