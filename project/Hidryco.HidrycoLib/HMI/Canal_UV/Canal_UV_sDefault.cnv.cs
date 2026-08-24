/*
 * Criado pelo EcoStruxure Automation Expert.
 * Usuário:  
 * Data: 03/03/2026
 * Tempo: 09:28
 * 
 */

using System;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Symbols.Canal_UV
{
	/// <summary>
	/// Description of sDefault.
	/// </summary>
	public partial class sDefault : NxtControl.GuiFramework.HMISymbol
	{
		public sDefault()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			
		}

		void StsLowWaterLevelConditionValueChanged(object sender, ValueChangedEventArgs e)
		{
			boiaLon.Visible = !((bool)e.Value);
			boiaLoff.Visible = (bool)e.Value;
		}
	}
}
