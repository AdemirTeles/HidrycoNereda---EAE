/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 6/19/2026
 * Time: 11:38 PM
 * 
 */

using System;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.FlushGritScreens
{
	/// <summary>
	/// Description of sSettings.
	/// </summary>
	public partial class sSettings : NxtControl.GuiFramework.HMISymbol
	{
		bool Active;
		bool NotActive;
		public sSettings()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
		}
	}
}
