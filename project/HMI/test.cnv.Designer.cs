/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 9/18/2026
 * Time: 5:03 AM
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
	/// Summary description for test.
	/// </summary>
	partial class test
	{
		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.sDefault1 = new SE.IoTMx.Symbols.TM262L01MDESE8T.sDefault();
			this.sDefault2 = new SE.HwCommon.Symbols.CPUDiagnostics2Core.sDefault();
			// 
			// sDefault1
			// 
			this.sDefault1.BeginInit();
			this.sDefault1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 72D, 64D);
			this.sDefault1.HeaderText = "";
			this.sDefault1.Name = "sDefault1";
			this.sDefault1.SecurityToken = ((uint)(4294967295u));
			this.sDefault1.TagName = "F903885E680FD8F5";
			this.sDefault1.EndInit();
			// 
			// sDefault2
			// 
			this.sDefault2.BeginInit();
			this.sDefault2.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 536D, -8D);
			this.sDefault2.Name = "sDefault2";
			this.sDefault2.SecurityToken = ((uint)(4294967175u));
			this.sDefault2.TagName = "F903885E680FD8F5.cpuDiag2Core";
			this.sDefault2.EndInit();
			// 
			// test
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(1024D)), ((float)(530D)));
			this.Brush = new NxtControl.Drawing.Brush("CanvasBrush");
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.sDefault1,
			this.sDefault2});
			this.Size = new System.Drawing.Size(1024, 530);

		}
		private SE.IoTMx.Symbols.TM262L01MDESE8T.sDefault sDefault1;
		private SE.HwCommon.Symbols.CPUDiagnostics2Core.sDefault sDefault2;
		#endregion
	}
}
