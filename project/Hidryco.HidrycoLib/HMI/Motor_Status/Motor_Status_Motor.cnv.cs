/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 2/5/2026
 * Time: 1:44 PM
 * 
 */

using System;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Symbols.Motor_Status
{
	/// <summary>
	/// Description of sDefault.
	/// </summary>
	public partial class Motor : NxtControl.GuiFramework.HMISymbol
	{
		public Motor()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
		}

		void STS_FUNCIONAMENTOValueChanged(object sender, ValueChangedEventArgs e)
		{
			motor_Invertido1.Animacao = Convert.ToInt16(e.Value);
		}
	}
}
