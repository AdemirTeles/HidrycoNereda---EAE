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

namespace Hidryco.HidrycoLib.Symbols.Motor_Inversor_Automatico_Unico
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
			NxtControl.Drawing.Color color;
			
			switch (Convert.ToInt16(e.Value))
			{
				case 0: // Vermelho
					color = HidrycoColors.Desligado;
					break;

				case 1: // Verde
					color = HidrycoColors.Ligado;
					break;

				case 2: // Amarelo
					color = HidrycoColors.Falha;
					break;

				case 3: // Azul
					color = HidrycoColors.Manutencao;
					break;

				default: // Desconhecido
					color = HidrycoColors.Unknown;
					break;
			}

			// Aplica a cor em todas as formas
			Base1R.BrushColor   = color;
			Base2R.BrushColor   = color;
			Base3R.BrushColor = color;
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
