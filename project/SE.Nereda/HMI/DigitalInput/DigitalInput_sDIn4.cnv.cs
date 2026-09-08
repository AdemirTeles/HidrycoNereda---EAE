/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 6/15/2026
 * Time: 10:37 PM
 * 
 */

using System;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.DigitalInput
{
	/// <summary>
	/// Description of sDIn4.
	/// </summary>
	public partial class sDIn4 : NxtControl.GuiFramework.HMISymbol
	{
		public sDIn4()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
		}

		void OpenFpClick(object sender, EventArgs e)
		{
			// TODO: Implement OpenFpClick
			this.DigitalInput.DoOpenFaceplate("fpDefault");
		}
	}
}
