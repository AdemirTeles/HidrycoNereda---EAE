using System;
using NxtControl.GuiFramework;
using Hidryco.HidrycoLib.SupportClasses;

namespace Hidryco.HidrycoLib.Faceplates.Valvula_Saida_Digital
{
	public partial class Faceplate1 : NxtControl.GuiFramework.HMIFaceplate
	{
		public Faceplate1()
		{
			InitializeComponent();
		}

		
		void BtnAbrirManualClick(object sender, EventArgs e)
		{
			FireEvent_E_COMANDO_MANUAL(true,false);
		}

		void BtnFecharManualClick(object sender, EventArgs e)
		{
			FireEvent_E_COMANDO_MANUAL(false,true);
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

		        btnAbrirManual.BrushColor = HidrycoColors.botaoFalse;
		        btnFecharManual.BrushColor = HidrycoColors.botaoFalse;
		        btnAbrirManual.Enabled = false;
		        btnFecharManual.Enabled = false;
		
		    }
		    else
		    {

		        btnAbrirManual.Enabled = true;
		        btnFecharManual.Enabled = true;
		        
		        if ((bool)fbkCmdOn.Value){
		        	btnAbrirManual.BrushColor = HidrycoColors.botaoTrue;
		        }
		        
		        if ((bool)fbkCmdOff.Value){
		        	btnFecharManual.BrushColor = HidrycoColors.botaoTrue;
		        }
		
		    }
		}

		void FbkCmdOnValueChanged(object sender, ValueChangedEventArgs e)
		{
			if ((bool)e.Value){
				btnAbrirManual.BrushColor = HidrycoColors.botaoTrue;
				btnFecharManual.BrushColor = HidrycoColors.botaoFalse;
			}
		}

		void FbkCmdOffValueChanged(object sender, ValueChangedEventArgs e)
		{
			if ((bool)e.Value){
				btnAbrirManual.BrushColor = HidrycoColors.botaoFalse;
				btnFecharManual.BrushColor = HidrycoColors.botaoTrue;
			}
		}
	}
}
