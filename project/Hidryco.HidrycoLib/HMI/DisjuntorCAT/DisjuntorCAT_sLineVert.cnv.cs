/*
 * Criado pelo EcoStruxure Automation Expert.
 * Usuário:  
 * Data: 11/06/2026
 * Tempo: 10:00
 * 
 */

using System;
using NxtControl.GuiFramework;
using Hidryco.HidrycoLib.SupportClasses;

namespace Hidryco.HidrycoLib.Symbols.DisjuntorCAT
{
	/// <summary>
	/// Description of sLineVert.
	/// </summary>
	public partial class sLineVert : NxtControl.GuiFramework.HMISymbol
	{
		public sLineVert()
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
