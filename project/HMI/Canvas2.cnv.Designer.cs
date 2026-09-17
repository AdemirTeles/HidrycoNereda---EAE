/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 8/19/2026
 * Time: 2:50 PM
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
			this.Mode = new SE.Nereda.Symbols.Mode.ReactorMode();
			this.AERATION = new SE.Nereda.Symbols.NeredaCAeration.sBlowers();
			// 
			// Mode
			// 
			this.Mode.BeginInit();
			this.Mode.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 480D, 8D);
			this.Mode.Name = "Mode";
			this.Mode.SecurityToken = ((uint)(4294967295u));
			this.Mode.TagName = "7A79C015B9ADE3EB";
			this.Mode.EndInit();
			// 
			// AERATION
			// 
			this.AERATION.BeginInit();
			this.AERATION.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 848D, 160D);
			this.AERATION.Name = "AERATION";
			this.AERATION.SecurityToken = ((uint)(4294967295u));
			this.AERATION.TagName = "6307B68BAFBA5753";
			this.AERATION.EndInit();
			// 
			// Canvas2
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(1366D)), ((float)(698D)));
			this.Brush = new NxtControl.Drawing.Brush("CanvasBrush");
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.Mode,
			this.AERATION});
			this.Size = new System.Drawing.Size(1366, 698);

		}
		private SE.Nereda.Symbols.Mode.ReactorMode Mode;
		private SE.Nereda.Symbols.NeredaCAeration.sBlowers AERATION;
		#endregion
	}
}
