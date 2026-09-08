/*
 * Criado pelo EcoStruxure Automation Expert.
 * Usuário:  
 * Data: 11/03/2026
 * Tempo: 11:50
 * 
 */

using System;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Symbols.Pre_Tratamento
{
	/// <summary>
	/// Description of Resumo.
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


		void StsEmergenciaAcionadaValueChanged(object sender, ValueChangedEventArgs e)
		{
			emergencia_acionada2.Visible = (bool)e.Value;
		}
	}
}
