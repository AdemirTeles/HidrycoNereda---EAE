/*
 * Criado pelo EcoStruxure Automation Expert.
 * Usuário:  
 * Data: 30/03/2026
 * Tempo: 17:04
 * 
 */

using System;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Symbols.Preparador_Polimero
{
	/// <summary>
	/// Description of sDefault.
	/// </summary>
	public partial class sResumo : NxtControl.GuiFramework.HMISymbol
	{
		public sResumo()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();

		}


		void StsEmergenciaValueChanged(object sender, ValueChangedEventArgs e)
		{
			emergencia_acionada.Visible = Convert.ToBoolean(e.Value);
		}
	}
}
