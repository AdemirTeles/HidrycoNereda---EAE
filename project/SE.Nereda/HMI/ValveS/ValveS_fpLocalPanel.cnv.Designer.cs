/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 6/12/2026
 * Time: 4:50 PM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using NxtControl.GuiFramework;

namespace SE.Nereda.Faceplates.ValveS
{
	/// <summary>
	/// Summary description for fpLocalPanel.
	/// </summary>
	partial class fpLocalPanel
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.LocalPanel = new SE.Nereda.Symbols.FieldSignals.sPanel();
			// 
			// LocalPanel
			// 
			this.LocalPanel.BeginInit();
			this.LocalPanel.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 8D, 8D);
			this.LocalPanel.Name = "LocalPanel";
			this.LocalPanel.SecurityToken = ((uint)(4294967295u));
			this.LocalPanel.TagName = "LocalPanel";
			this.LocalPanel.EndInit();
			// 
			// fpLocalPanel
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(408D)), ((float)(328D)));
			this.Brush = new NxtControl.Drawing.Brush("FaceplateBrush");
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.LocalPanel});
			this.Size = new System.Drawing.Size(408, 328);

		}
		private SE.Nereda.Symbols.FieldSignals.sPanel LocalPanel;
		#endregion
	}
}
