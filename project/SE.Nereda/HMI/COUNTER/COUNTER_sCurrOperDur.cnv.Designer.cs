/*
 * Created by EcoStruxure Automation Expert.
 * User: SESA713705
 * Date: 2/4/2026
 * Time: 11:49 AM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.COUNTER
{
	/// <summary>
	/// Summary description for sDefault.
	/// </summary>
	partial class sCurrOperDur
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.CurrOperDur = new System.HMI.Symbols.Base.TimeLabel();
			// 
			// CurrOperDur
			// 
			this.CurrOperDur.BeginInit();
			this.CurrOperDur.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.CurrOperDur.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.48D, 0D, 0D, 1D, 16D, 16D);
			this.CurrOperDur.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.CurrOperDur.FontScale = false;
			this.CurrOperDur.IsOnlyInput = true;
			this.CurrOperDur.Name = "CurrOperDur";
			this.CurrOperDur.Pen = new NxtControl.Drawing.Pen("LabelPen");
			this.CurrOperDur.TagName = "CurrOperDur";
			this.CurrOperDur.TextColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.CurrOperDur.EndInit();
			// 
			// sCurrOperDur
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.CurrOperDur});
			this.SymbolSize = new System.Drawing.Size(600, 400);

		}
		private System.HMI.Symbols.Base.TimeLabel CurrOperDur;
		#endregion
	}
}
