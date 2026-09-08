/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 6/25/2026
 * Time: 4:19 PM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.FlushingManager
{
	/// <summary>
	/// Summary description for sShowLevel.
	/// </summary>
	partial class sShowLevel
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.ShowLevel = new NxtControl.GuiFramework.Rectangle();
			// 
			// ShowLevel
			// 
			this.ShowLevel.Bounds = new NxtControl.Drawing.RectF(((float)(16D)), ((float)(16D)), ((float)(198D)), ((float)(298D)));
			this.ShowLevel.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(235)), ((byte)(145))));
			this.ShowLevel.FillDirection = NxtControl.Drawing.FillDirection.DownToTop;
			this.ShowLevel.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.ShowLevel.Name = "ShowLevel";
			this.ShowLevel.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// sShowLevel
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.ShowLevel});
			this.SymbolSize = new System.Drawing.Size(344, 408);

		}
		private NxtControl.GuiFramework.Rectangle ShowLevel;
		#endregion
	}
}
