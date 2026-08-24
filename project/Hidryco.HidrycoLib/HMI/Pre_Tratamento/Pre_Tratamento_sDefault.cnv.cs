/*
 * Criado pelo EcoStruxure Automation Expert.
 * Usuário:  
 * Data: 09/03/2026
 * Tempo: 11:29
 * 
 */

using System;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Symbols.Pre_Tratamento
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
		void ResetFalhasProcessoMouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			FireEvent_E_RESET_FALHA(true);
			
		}

		void ResetFalhasProcessoMouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			FireEvent_E_RESET_FALHA(false);
		}

		void StsEmergenciaAcionadaValueChanged(object sender, ValueChangedEventArgs e)
		{
			emergencia_acionada1.Visible = ((bool)e.Value);
		}

		void CmdSelecaoSubsistemaPeneiraValueChanged(object sender, ValueChangedEventArgs e)
		{
			cmdLigaSubsistemaPeneira.Enabled = (bool)e.Value;
		}

		void CmdSelecaoSubsistemaRaspCompValueChanged(object sender, ValueChangedEventArgs e)
		{
			cmdLigaSubsistemaRaspComp.Enabled = (bool)e.Value;
		}

		void CmdSelecaoSubsistemaRoscasValueChanged(object sender, ValueChangedEventArgs e)
		{
			cmdLigaSubsistemaRoscas.Enabled = (bool)e.Value;
		}
	}
}
