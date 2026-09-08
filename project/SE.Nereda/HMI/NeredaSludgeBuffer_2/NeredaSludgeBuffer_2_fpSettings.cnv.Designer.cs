/*
 * Criado pelo EcoStruxure Automation Expert.
 * Usuário:  
 * Data: 23/08/2026
 * Tempo: 17:19
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using NxtControl.GuiFramework;

namespace SE.Nereda.Faceplates.NeredaSludgeBuffer_2
{
	/// <summary>
	/// Summary description for fbSettings.
	/// </summary>
	partial class fpSettings
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.sDefault1 = new SE.Nereda.Symbols.CmdSludgeDischargeSLB.sDefault();
			this.sDefault2 = new SE.Nereda.Symbols.CmdWaterDischargeSLB.sDefault();
			// 
			// sDefault1
			// 
			this.sDefault1.BeginInit();
			this.sDefault1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 24D, 24D);
			this.sDefault1.Name = "sDefault1";
			this.sDefault1.SecurityToken = ((uint)(4294967295u));
			this.sDefault1.TagName = "Logic.CmdSludgeDischargeSLB1";
			this.sDefault1.EndInit();
			// 
			// sDefault2
			// 
			this.sDefault2.BeginInit();
			this.sDefault2.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 24D, 128D);
			this.sDefault2.Name = "sDefault2";
			this.sDefault2.SecurityToken = ((uint)(4294967295u));
			this.sDefault2.TagName = "Logic.CmdWaterDischargeSLB1";
			this.sDefault2.EndInit();
			// 
			// fpSettings
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(600D)), ((float)(400D)));
			this.Brush = new NxtControl.Drawing.Brush("FaceplateBrush");
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.sDefault1,
			this.sDefault2});
			this.Size = new System.Drawing.Size(600, 400);

		}
		private SE.Nereda.Symbols.CmdSludgeDischargeSLB.sDefault sDefault1;
		private SE.Nereda.Symbols.CmdWaterDischargeSLB.sDefault sDefault2;
		#endregion
	}
}
