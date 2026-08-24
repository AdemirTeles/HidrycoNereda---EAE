/*
 * Created by EcoStruxure Automation Expert.
 * User: SESA713705
 * Date: 8/27/2024
 * Time: 7:41 PM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.AtvResetError
{
	/// <summary>
	/// Summary description for sATVState.
	/// </summary>
	partial class sATVState
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.DriverState = new NxtControl.GuiFramework.FreeText();
			// 
			// DriverState
			// 
			this.DriverState.Color = new NxtControl.Drawing.BlinkColor("ButtonNotMatchingTextColor");
			this.DriverState.Font = new NxtControl.Drawing.Font("LabelFont");
			this.DriverState.Location = new NxtControl.Drawing.PointF(8D, 8D);
			this.DriverState.Name = "DriverState";
			this.DriverState.Text = "Drive Not Ready";
			// 
			// sATVState
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.DriverState});
			this.SymbolSize = new System.Drawing.Size(128, 48);

		}
		private NxtControl.GuiFramework.FreeText DriverState;
		#endregion
	}
}
