/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 6/15/2026
 * Time: 10:21 AM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.ValveS
{
	/// <summary>
	/// Summary description for sCounter.
	/// </summary>
	partial class sCounter
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.Duration = new NxtControl.GuiFramework.FreeText();
			// 
			// Duration
			// 
			this.Duration.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.Duration.Font = new NxtControl.Drawing.Font("LabelFont");
			this.Duration.Location = new NxtControl.Drawing.PointF(16D, 16D);
			this.Duration.Name = "Duration";
			this.Duration.Text = "0h : 0min : 0s";
			// 
			// sCounter
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.Duration});
			this.SymbolSize = new System.Drawing.Size(136, 48);

		}
		private NxtControl.GuiFramework.FreeText Duration;
		#endregion
	}
}
