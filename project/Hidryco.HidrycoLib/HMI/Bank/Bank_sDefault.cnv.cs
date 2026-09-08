/*
 * Criado pelo EcoStruxure Automation Expert.
 * Usuário:  
 * Data: 02/03/2026
 * Tempo: 19:51
 */

using System;
using NxtControl.GuiFramework;
using Hidryco.HidrycoLib.SupportClasses;

namespace Hidryco.HidrycoLib.Symbols.Bank
{
	public partial class sDefault : NxtControl.GuiFramework.HMISymbol
	{

		public sDefault()
		{
			InitializeComponent();
		}

		void StsAnimacaoValueChanged(object sender, ValueChangedEventArgs e)
		{

			NxtControl.Drawing.Color color;

			switch ((Int16)e.Value)
			{
				case 0:
					color = HidrycoColors.Desligado;
					break;

				case 1: 
					color = HidrycoColors.Ligado;
					break;

				case 2:
					color = HidrycoColors.Falha;
					break;

				default: 
					color = HidrycoColors.Unknown;
					break;
			}

			rectangle1.BrushColor = color;
			rectangle2.BrushColor = color;
			rectangle3.BrushColor = color;
			polygon1.BrushColor   = color;
			polygon2.BrushColor   = color;
		}
	}
}