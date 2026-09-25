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
			this.sDefault1 = new SE.IoTMx.Symbols.TM262L01MDESE8T.sDefault();
			this.sDefault2 = new SE.IoTMx.Symbols.BMTM3.sDefault();
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
			// sDefault1
			// 
			this.sDefault1.BeginInit();
			this.sDefault1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 120D, 104D);
			this.sDefault1.HeaderText = "";
			this.sDefault1.Name = "sDefault1";
			this.sDefault1.SecurityToken = ((uint)(4294967295u));
			this.sDefault1.TagName = "F903885E680FD8F5";
			this.sDefault1.EndInit();
			// 
			// sDefault2
			// 
			this.sDefault2.BeginInit();
			this.sDefault2.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 613D, 340D);
			this.sDefault2.Name = "sDefault2";
			this.sDefault2.SecurityToken = ((uint)(4294967295u));
			this.sDefault2.TagName = "22B94E91D408B02E";
			this.sDefault2.EndInit();
			// 
			// Canvas2
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(1366D)), ((float)(698D)));
			this.Brush = new NxtControl.Drawing.Brush("CanvasBrush");
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.Mode,
			this.sDefault1,
			this.sDefault2});
			this.Size = new System.Drawing.Size(1366, 698);

		}
		private SE.Nereda.Symbols.Mode.ReactorMode Mode;
		private SE.IoTMx.Symbols.TM262L01MDESE8T.sDefault sDefault1;
		private SE.IoTMx.Symbols.BMTM3.sDefault sDefault2;
		#endregion
	}
}
