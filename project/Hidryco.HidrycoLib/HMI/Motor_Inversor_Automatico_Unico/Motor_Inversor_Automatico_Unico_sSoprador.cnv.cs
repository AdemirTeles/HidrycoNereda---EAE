using System;
using Hidryco.HidrycoLib.SupportClasses;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Symbols.Motor_Inversor_Automatico_Unico
{
	public partial class sSoprador : HMISymbol
	{

		public sSoprador()
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
			ellipse1.BrushColor   = color;
			polygon1.BrushColor   = color;
			rectangle2.BrushColor = color;
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