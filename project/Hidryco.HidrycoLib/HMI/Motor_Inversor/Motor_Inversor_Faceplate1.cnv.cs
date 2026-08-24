/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 1/23/2026
 * Time: 1:58 PM
 * 
 */

using System;
using NxtControl.GuiFramework;
using Hidryco.HidrycoLib.SupportClasses;

namespace Hidryco.HidrycoLib.Faceplates.Motor_Inversor
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
		
		void BtnModoAutomaticoClick(object sender, EventArgs e)
		{
			FireEvent_E_MODO_OPERACAO(true);
		}

		void BtnModoManualClick(object sender, EventArgs e)
		{
			FireEvent_E_MODO_OPERACAO(false);
		}
		
		void BtnLigarManualClick(object sender, EventArgs e)
		{
			FireEvent_E_COMANDO_MANUAL(true);
		}

		void BtnDesligarManualClick(object sender, EventArgs e)
		{
			FireEvent_E_COMANDO_MANUAL(false);
		}
		
		void BtnResetFalhaMouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			FireEvent_E_RESET_FALHA(true);
		}

		void BtnResetFalhaMouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			FireEvent_E_RESET_FALHA(false);
		}

		void FbkStsAutomaticoValueChanged(object sender, ValueChangedEventArgs e)
		{
		    if ((bool)e.Value)
		    {
		        btnModoAutomatico.BrushColor = HidrycoColors.botaoTrue;
		        btnModoManual.BrushColor = HidrycoColors.botaoFalse;
		
		        btnLigarManual.BrushColor = HidrycoColors.botaoFalse;
		        btnDesligarManual.BrushColor = HidrycoColors.botaoFalse;
		
		        btnLigarManual.Enabled = false;
		        btnDesligarManual.Enabled = false;
		    }
		    else
		    {
		        btnModoAutomatico.BrushColor = HidrycoColors.botaoFalse;
		        btnModoManual.BrushColor = HidrycoColors.botaoTrue;
		
		        btnLigarManual.Enabled = true;
		        btnDesligarManual.Enabled = true;
		    }
		}

		void FbkCmdManualValueChanged(object sender, ValueChangedEventArgs e)
		{
		    if ((bool)fbkStsAutomatico.Value)
		        return;
		
		    if ((bool)e.Value)
		    {
		        btnLigarManual.BrushColor = HidrycoColors.botaoTrue;
		        btnDesligarManual.BrushColor = HidrycoColors.botaoFalse;
		    }
		    else
		    {
		        btnLigarManual.BrushColor = HidrycoColors.botaoFalse;
		        btnDesligarManual.BrushColor = HidrycoColors.botaoTrue;
		    }
		}
	}
}
