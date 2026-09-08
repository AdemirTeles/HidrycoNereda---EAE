/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 7/10/2026
 * Time: 3:29 PM
 * 
 */

using System;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.ValveS
{
	/// <summary>
	/// Description of Symbol1.
	/// </summary>
	public partial class Symbol1 : NxtControl.GuiFramework.HMISymbol
	{
		public Symbol1()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
		}

		void StateActuatorStatus(short StateValue)
		{
			// TODO: Implement StateActuatorStatus
			// =1: Started ; =0: Stopped ; =255: Error ; =100: Power Off
			freeText1.Text = StateValue.ToString();
		}
	}
}
