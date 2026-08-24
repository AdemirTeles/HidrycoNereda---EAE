/*
 * Criado pelo EcoStruxure Automation Expert.
 * Usuário:  
 * Data: 04/03/2026
 * Tempo: 14:04
 * 
 */

using System;
using System.Runtime.InteropServices;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Faceplates.Raspador_Gordura
{
	/// <summary>
	/// Description of Faceplate1.
	/// </summary>
	public partial class Faceplate1 : NxtControl.GuiFramework.HMIFaceplate
	{
		public Faceplate1()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
		}
		
		void DrawnButton1Click(object sender, EventArgs e)
		{
			FireEvent_E_ATUALIZA_COMANDO_LIGA_MANUAL(true);
		}
		
		void DrawnButton2Click(object sender, EventArgs e)
		{
			FireEvent_E_ATUALIZA_COMANDO_LIGA_MANUAL(false);
		}
		
		private bool _cmdLigaManual;
		void FbkCmdLigaManualValueChanged(object sender, ValueChangedEventArgs e)
		{
			_cmdLigaManual = (bool)e.Value;
			EnableBTN(_cmdLigaManual, _cmdLigaIntermitente);
		}
		

		
		public void EnableBTN(bool ligaManual, bool ligaIntermitente)
		{
			
			if (ligaManual) {
				btnManOff.Enabled = true;
				btnManOn.Enabled = false;
				if (ligaIntermitente) {
					btnInterOff.Enabled = true;
					btnInterOn.Enabled = false;
				} else {
					btnInterOff.Enabled = false;
					btnInterOn.Enabled = true;
				}
				
				
			}
			else if (!ligaManual) {
				btnManOn.Enabled = true;
				btnManOff.Enabled = false;
				btnInterOff.Enabled = false;
				btnInterOn.Enabled = false;
			}
		}
		
		private bool _cmdLigaIntermitente;
		void FbkCmdLigaIntermitenteValueChanged(object sender, ValueChangedEventArgs e)
		{
			_cmdLigaIntermitente = (bool)e.Value;
			EnableBTN(_cmdLigaManual, _cmdLigaIntermitente);
		}

		void BtnInterOnClick(object sender, EventArgs e)
		{
			FireEvent_E_ATUALIZA_COMANDO_LIGA_INTERMITENTE(true);
		}

		void BtnInterOffClick(object sender, EventArgs e)
		{
			FireEvent_E_ATUALIZA_COMANDO_LIGA_INTERMITENTE(false);
		}
		
	}
	
	
}
