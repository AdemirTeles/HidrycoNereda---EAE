/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 7/16/2026
 * Time: 1:12 AM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.COUNTER
{
	/// <summary>
	/// Summary description for sDownCount.
	/// </summary>
	partial class sDownCount
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.DownCount = new System.HMI.Symbols.Base.TimeLabel();
			// 
			// DownCount
			// 
			this.DownCount.BeginInit();
			this.DownCount.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.DownCount.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.48D, 0D, 0D, 1D, 35D, 38D);
			this.DownCount.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.DownCount.FontScale = false;
			this.DownCount.IsOnlyInput = true;
			this.DownCount.Name = "DownCount";
			this.DownCount.Pen = new NxtControl.Drawing.Pen("LabelPen");
			this.DownCount.TagName = "DownCount";
			this.DownCount.TextColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.DownCount.EndInit();
			// 
			// sDownCount
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.DownCount});
			this.SymbolSize = new System.Drawing.Size(200, 200);

		}
		private System.HMI.Symbols.Base.TimeLabel DownCount;
		#endregion
	}
}
