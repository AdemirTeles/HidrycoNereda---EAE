/*
 * Criado pelo EcoStruxure Automation Expert.
 * Usuário:  
 * Data: 20/01/2026
 * Tempo: 10:06
 * 
 */

using System;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Faceplates.Sensor_Comunicacao
{
	/// <summary>
	/// Description of Faceplate1.
	/// </summary>
	public partial class fpAlarmes : NxtControl.GuiFramework.HMIFaceplate
	{
		public fpAlarmes()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
		}
        void BtnResetAlarmesClick(object sender, EventArgs e)
		{
			FireEvent_E_RESET_ALARMES();
		}
	}
}
