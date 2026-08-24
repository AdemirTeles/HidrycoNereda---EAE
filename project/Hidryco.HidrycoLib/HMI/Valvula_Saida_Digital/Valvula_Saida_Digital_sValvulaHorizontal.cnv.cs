/*
 * Created by EcoStruxure Automation Expert.
 * User:
 * Date: 1/26/2026
 * Time: 1:13 PM
 */

using System;
using NxtControl.GuiFramework;
using Hidryco.HidrycoLib.SupportClasses;

namespace Hidryco.HidrycoLib.Symbols.Valvula_Saida_Digital
{
    /// <summary>
    /// Símbolo de válvula On/Off controlada por StsAnimacao:
    /// 0 = fechada, 1 = aberta, 2 = falha, 4 = transição (abrindo/fechando)
    /// </summary>
    public partial class sValvulaHorizontal : HMISymbol
    {
        public sValvulaHorizontal()
        {
            InitializeComponent();
            
        }

        void StsAnimacaoValueChanged(object sender, ValueChangedEventArgs e)
		{
			NxtControl.Drawing.Color color;
			NxtControl.Drawing.Color colorTwo;
			
			switch (Convert.ToInt16(e.Value))
			{
				case 0: 
					color = HidrycoColors.Desligado;
					colorTwo = HidrycoColors.Desligado;
					break;

				case 1:
					color = HidrycoColors.Ligado;
					colorTwo = HidrycoColors.Ligado;
					break;

				case 2: 
					color = HidrycoColors.Falha;
					colorTwo = HidrycoColors.Falha;
					break;

				case 3:
					color = HidrycoColors.Manutencao;
					colorTwo = HidrycoColors.Manutencao;
					break;
					
				case 4:
					color = HidrycoColors.Desligado;
					colorTwo = HidrycoColors.Ligado;
					break;

				default: 
					color = HidrycoColors.Unknown;
					colorTwo = HidrycoColors.Unknown;
					break;
			}

			// Aplica a cor em todas as formas
			rectangle1.BrushColor = color;
			polygon1.BrushColor = color;
			polygon2.BrushColor = colorTwo;

		}



    }
}
