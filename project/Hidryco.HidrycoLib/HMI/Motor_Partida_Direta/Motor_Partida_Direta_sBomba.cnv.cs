/*
 * Criado pelo EcoStruxure Automation Expert.
 * Usuário:  
 * Data: 19/01/2026
 * Tempo: 09:25
 * 
 */

using System;
using NxtControl.GuiFramework;
using Hidryco.HidrycoLib.SupportClasses;

namespace Hidryco.HidrycoLib.Symbols.Motor_Partida_Direta
{
	/// <summary>
	/// Description of Symbol1.
	/// </summary>
	public partial class sBomba : NxtControl.GuiFramework.HMISymbol
	{

		public sBomba()
		{
			InitializeComponent();
		}

		void StsAnimacaoValueChanged(object sender, ValueChangedEventArgs e)
		{
			bomba1.Animacao = Convert.ToInt16(e.Value);
		}
		void StsProtecaoTermicaValueChanged(object sender, ValueChangedEventArgs e)
		{
			unidade_Portecao_Termica1.Visible = (bool)e.Value;
		}
	}
}
