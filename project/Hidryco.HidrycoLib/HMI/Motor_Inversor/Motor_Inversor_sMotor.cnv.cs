/*
 * Criado pelo EcoStruxure Automation Expert.
 * Usuário:  
 * Data: 11/03/2026
 * Tempo: 14:46
 * 
 */

using System;
using NxtControl.GuiFramework;
using Hidryco.HidrycoLib.SupportClasses;

namespace Hidryco.HidrycoLib.Symbols.Motor_Inversor
{
	/// <summary>
	/// Description of sMotor.
	/// </summary>
	public partial class sMotor : NxtControl.GuiFramework.HMISymbol
	{

		public sMotor()
		{
			InitializeComponent();
		}

		void StsAnimacaoValueChanged(object sender, ValueChangedEventArgs e)
		{
			motor1.Animacao = Convert.ToInt16(e.Value);
		}


		void StsFalhaComunicacaoValueChanged(object sender, ValueChangedEventArgs e)
		{
		
			falha_comunicacao1.Visible = (bool)e.Value;
		    
		}

		void StsProtecaoTermicaValueChanged(object sender, ValueChangedEventArgs e)
		{
			unidade_Portecao_Termica1.Visible = (bool)e.Value;
		}
	}
}
