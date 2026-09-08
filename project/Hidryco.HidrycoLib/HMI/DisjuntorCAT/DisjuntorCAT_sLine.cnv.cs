/*
 * Criado pelo EcoStruxure Automation Expert.
 * Usuário:  
 * Data: 08/06/2026
 * Tempo: 16:17
 * 
 */

using System;
using NxtControl.GuiFramework;
using Hidryco.HidrycoLib.SupportClasses;

namespace Hidryco.HidrycoLib.Symbols.DisjuntorCAT
{
	/// <summary>
	/// Description of sLine.
	/// </summary>
	public partial class sLine : NxtControl.GuiFramework.HMISymbol
	{
		public sLine()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
		}

		void StsDisjuntorLigadoValueChanged(object sender, ValueChangedEventArgs e)
		{
			if ((bool)e.Value){
				line1.PenColor = HidrycoColors.Ligado;

			}else{
				line1.PenColor = HidrycoColors.Desligado;
			}
		}
		
			
	}
}
