/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 7/7/2026
 * Time: 5:42 PM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.COUNTER
{
	/// <summary>
	/// Summary description for ElapsedDur.
	/// </summary>
	partial class ElapsedDur
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.ElapsedDur_1 = new System.HMI.Symbols.Base.TimeLabel();
			// 
			// ElapsedDur_1
			// 
			this.ElapsedDur_1.BeginInit();
			this.ElapsedDur_1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.ElapsedDur_1.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.48D, 0D, 0D, 1D, 16D, 16D);
			this.ElapsedDur_1.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.ElapsedDur_1.FontScale = false;
			this.ElapsedDur_1.IsOnlyInput = true;
			this.ElapsedDur_1.Name = "ElapsedDur_1";
			this.ElapsedDur_1.Pen = new NxtControl.Drawing.Pen("LabelPen");
			this.ElapsedDur_1.TagName = "ElapsedDur";
			this.ElapsedDur_1.TextColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.ElapsedDur_1.EndInit();
			// 
			// ElapsedDur
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.ElapsedDur_1});
			this.SymbolSize = new System.Drawing.Size(200, 200);

		}
		private System.HMI.Symbols.Base.TimeLabel ElapsedDur_1;
		#endregion
	}
}
