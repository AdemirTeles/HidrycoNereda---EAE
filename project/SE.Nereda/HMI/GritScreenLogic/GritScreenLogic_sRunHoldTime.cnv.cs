/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 7/11/2026
 * Time: 2:41 PM
 * 
 */

using System;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.GritScreenLogic
{
	/// <summary>
	/// Description of sRunHoldTime.
	/// </summary>
	public partial class sRunHoldTime : NxtControl.GuiFramework.HMISymbol
	{
		public sRunHoldTime()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
		}

		void RunHoldTValueChanged(object sender, ValueChangedEventArgs e)
		{
			// TODO: Implement RunHoldTValueChanged
			group1.Visible = (bool) e.Value;
		}
	}
}
