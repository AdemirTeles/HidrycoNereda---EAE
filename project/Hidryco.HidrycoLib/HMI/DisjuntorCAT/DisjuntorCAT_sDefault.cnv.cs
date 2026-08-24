/*
 * Criado pelo EcoStruxure Automation Expert.
 * Usuário:  
 * Data: 19/05/2026
 * Tempo: 13:38
 * 
 */

using System;
using NxtControl.GuiFramework;
using Hidryco.HidrycoLib.SupportClasses;

namespace Hidryco.HidrycoLib.Symbols.DisjuntorCAT
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

		void StsDisjuntorLigadoValueChanged(object sender, ValueChangedEventArgs e)
		{
			line3.Visible = (bool)e.Value;
			if ((bool)e.Value){
				line1.PenColor = HidrycoColors.Ligado;
				line2.PenColor = HidrycoColors.Ligado;
				line3.PenColor = HidrycoColors.Ligado;
				line4.PenColor = HidrycoColors.Ligado;
				InstanceName.TextColor = HidrycoColors.Ligado;
			}else{
				line1.PenColor = HidrycoColors.Desligado;
				line2.PenColor = HidrycoColors.Desligado;
				line4.PenColor = HidrycoColors.Desligado;
				InstanceName.TextColor = HidrycoColors.Desligado;
			}
		}
	}
}
