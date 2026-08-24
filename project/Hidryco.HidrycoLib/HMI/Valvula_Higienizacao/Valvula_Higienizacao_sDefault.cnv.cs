/*
 * Criado pelo EcoStruxure Automation Expert.
 * Usuário:  
 * Data: 04/03/2026
 * Tempo: 12:01
 * 
 */

using System;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Symbols.Valvula_Higienizacao
{
	/// <summary>
	/// Description of sDefault.
	/// </summary>
	public partial class sDefault : NxtControl.GuiFramework.HMISymbol
	{
		

		public sDefault()
		{
			InitializeComponent();
		}

		void STS_ANIMACAOValueChanged(object sender, ValueChangedEventArgs e)
		{
			valvula_Horizontal1.Animacao = Convert.ToUInt16(e.Value);
		}
	}
}
