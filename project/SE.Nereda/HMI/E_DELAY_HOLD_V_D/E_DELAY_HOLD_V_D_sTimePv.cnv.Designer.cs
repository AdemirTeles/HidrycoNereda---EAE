/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 7/7/2026
 * Time: 9:47 PM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.E_DELAY_HOLD_V_D
{
	/// <summary>
	/// Summary description for sTimePv.
	/// </summary>
	partial class sTimePv
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.DurPv = new System.HMI.Symbols.Base.TimeLabel();
			// 
			// DurPv
			// 
			this.DurPv.BeginInit();
			this.DurPv.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.DurPv.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.48D, 0D, 0D, 1D, 32D, 24D);
			this.DurPv.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.DurPv.FontScale = false;
			this.DurPv.IsOnlyInput = true;
			this.DurPv.Name = "DurPv";
			this.DurPv.Pen = new NxtControl.Drawing.Pen("LabelPen");
			this.DurPv.TagName = "DurPv";
			this.DurPv.TextColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.DurPv.EndInit();
			// 
			// sTimePv
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.DurPv});
			this.SymbolSize = new System.Drawing.Size(200, 200);

		}
		private System.HMI.Symbols.Base.TimeLabel DurPv;
		#endregion
	}
}
