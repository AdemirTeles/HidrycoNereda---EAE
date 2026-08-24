/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 1/23/2026
 * Time: 2:01 PM
 * 
 */

using System;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Faceplates.Motor_Inversor_Automatico_Unico
{
	/// <summary>
	/// Description of Faceplate3.
	/// </summary>
	public partial class Faceplate3 : NxtControl.GuiFramework.HMIFaceplate
	{
		public Faceplate3()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
		}
		
		void BtnResetHorimetroMouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			FireEvent_E_RESET_HORIMETRO(true);
		}

		void BtnResetHorimetroMouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			FireEvent_E_RESET_HORIMETRO(false);
		}

		void BtnResetPartidasMouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			FireEvent_E_RESET_NUMERO_PARTIDAS(true);
		}

		void BtnResetPartidasMouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			FireEvent_E_RESET_NUMERO_PARTIDAS(false);
		}
	}
}
