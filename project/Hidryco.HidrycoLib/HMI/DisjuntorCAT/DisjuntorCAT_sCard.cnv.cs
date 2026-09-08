/*
 * Criado pelo EcoStruxure Automation Expert.
 * Usuário:  
 * Data: 21/05/2026
 * Tempo: 10:54
 * 
 */

using System;
using NxtControl.GuiFramework;
using Hidryco.HidrycoLib.SupportClasses;

namespace Hidryco.HidrycoLib.Symbols.DisjuntorCAT
{
	/// <summary>
	/// Description of sCard.
	/// </summary>
	public partial class sCard : NxtControl.GuiFramework.HMISymbol
	{
		public sCard()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
		}

		void StsDisjuntorLigadoValueChanged(object sender, ValueChangedEventArgs e)
		{
			if ((bool)e.Value){
				InstanceName.TextColor = HidrycoColors.Ligado;
			}else{
				InstanceName.TextColor = HidrycoColors.Desligado;
			}
		}
		
		
	}
}
