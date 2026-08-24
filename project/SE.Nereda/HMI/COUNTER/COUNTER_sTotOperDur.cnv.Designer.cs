/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 7/7/2026
 * Time: 5:41 PM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.COUNTER
{
	/// <summary>
	/// Summary description for sTotOperDur.
	/// </summary>
	partial class sTotOperDur
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.TotOperDur = new System.HMI.Symbols.Base.TimeLabel();
			// 
			// TotOperDur
			// 
			this.TotOperDur.BeginInit();
			this.TotOperDur.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.TotOperDur.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.48D, 0D, 0D, 1D, 16D, 16D);
			this.TotOperDur.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.TotOperDur.FontScale = false;
			this.TotOperDur.IsOnlyInput = true;
			this.TotOperDur.Name = "TotOperDur";
			this.TotOperDur.Pen = new NxtControl.Drawing.Pen("LabelPen");
			this.TotOperDur.TagName = "TotOperDur";
			this.TotOperDur.TextColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.TotOperDur.EndInit();
			// 
			// sTotOperDur
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.TotOperDur});
			this.SymbolSize = new System.Drawing.Size(200, 200);

		}
		private System.HMI.Symbols.Base.TimeLabel TotOperDur;
		#endregion
	}
}
