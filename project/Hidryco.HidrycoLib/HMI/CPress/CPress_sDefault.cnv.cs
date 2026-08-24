/*
 * Criado pelo EcoStruxure Automation Expert.
 * Usuário:  
 * Data: 30/03/2026
 * Tempo: 10:13
 * 
 */

using System;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Symbols.CPress
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

		void StsEmergenciaValueChanged(object sender, ValueChangedEventArgs e)
		{
			emergencia_acionada1.Visible = Convert.ToBoolean(e.Value);
		}
	}
}
