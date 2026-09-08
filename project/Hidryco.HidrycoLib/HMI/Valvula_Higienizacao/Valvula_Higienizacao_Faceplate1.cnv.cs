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

namespace Hidryco.HidrycoLib.Faceplates.Valvula_Higienizacao
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
			FireEvent_E_ATUALIZA_COMANDO(true);
		}
		
		void DrawnButton2Click(object sender, EventArgs e)
		{
			FireEvent_E_ATUALIZA_COMANDO(false);
		}
		
		private bool _cmdLigaManual;
		void FbkCmdLigaManualValueChanged(object sender, ValueChangedEventArgs e)
		{
			_cmdLigaManual = (bool)e.Value;
			ButtonEnablement(_cmdLigaManual);
		}
		

		
		public void ButtonEnablement(bool CSpVal)
		{
			
			if (CSpVal) {
				btnManOff.Enabled = true;
				btnManOn.Enabled = false;
			}
				
			if (!CSpVal) {
				btnManOn.Enabled = true;
				btnManOff.Enabled = false;
			}
		}
		
	}
	
	
}
