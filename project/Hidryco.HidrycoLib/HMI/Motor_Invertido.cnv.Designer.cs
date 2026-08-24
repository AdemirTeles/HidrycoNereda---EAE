/*
 * Criado pelo EcoStruxure Automation Expert.
 * Usuário:  
 * Data: 18/08/2026
 * Tempo: 17:49
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Graphics
{
	/// <summary>
	/// Summary description for Motor_Invertido.
	/// </summary>
	partial class Motor_Invertido
	{
		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.mtr_3 = new NxtControl.GuiFramework.Rectangle();
			this.mtr_2 = new NxtControl.GuiFramework.Rectangle();
			this.mtr_1 = new NxtControl.GuiFramework.Rectangle();
			// 
			// mtr_3
			// 
			this.mtr_3.Bounds = new NxtControl.Drawing.RectF(((float)(70D)), ((float)(58D)), ((float)(3D)), ((float)(9D)));
			this.mtr_3.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.mtr_3.Name = "mtr_3";
			// 
			// mtr_2
			// 
			this.mtr_2.Bounds = new NxtControl.Drawing.RectF(((float)(73D)), ((float)(52D)), ((float)(4D)), ((float)(22D)));
			this.mtr_2.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.mtr_2.Name = "mtr_2";
			// 
			// mtr_1
			// 
			this.mtr_1.Bounds = new NxtControl.Drawing.RectF(((float)(77D)), ((float)(46D)), ((float)(44D)), ((float)(33D)));
			this.mtr_1.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.mtr_1.Name = "mtr_1";
			// 
			// Motor_Invertido
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.mtr_3,
			this.mtr_2,
			this.mtr_1});
			this.SymbolSize = new System.Drawing.Size(208, 160);

		}
		private NxtControl.GuiFramework.Rectangle mtr_3;
		private NxtControl.GuiFramework.Rectangle mtr_2;
		private NxtControl.GuiFramework.Rectangle mtr_1;
		#endregion
	}
}
