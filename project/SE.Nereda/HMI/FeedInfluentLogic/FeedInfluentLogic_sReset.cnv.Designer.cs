/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 6/18/2026
 * Time: 9:38 AM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.FeedInfluentLogic
{
	/// <summary>
	/// Summary description for sReset.
	/// </summary>
	partial class sReset
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.Reset = new NxtControl.GuiFramework.DrawnButton();
			// 
			// Reset
			// 
			this.Reset.Bounds = new NxtControl.Drawing.RectF(((float)(8D)), ((float)(8D)), ((float)(48D)), ((float)(48D)));
			this.Reset.Brush = new NxtControl.Drawing.Brush("ButtonBrush");
			this.Reset.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.Reset.InnerBorderColor = new NxtControl.Drawing.Color("ButtonInnerBorderColor");
			this.Reset.Name = "Reset";
			this.Reset.Pen = new NxtControl.Drawing.Pen("ButtonPen");
			this.Reset.Radius = 4D;
			this.Reset.Text = "RESET LoLo Flow\r\n";
			this.Reset.TextColor = new NxtControl.Drawing.Color("ButtonTextColor");
			this.Reset.TextColorMouseDown = new NxtControl.Drawing.Color("ButtonTextColorMouseDown");
			this.Reset.Use3DEffect = false;
			this.Reset.Click += new System.EventHandler(this.ResetClick);
			// 
			// sReset
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.Reset});
			this.SymbolSize = new System.Drawing.Size(200, 200);

		}
		private NxtControl.GuiFramework.DrawnButton Reset;
		#endregion
	}
}
