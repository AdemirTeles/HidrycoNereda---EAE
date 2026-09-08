/*
 * Criado pelo EcoStruxure Automation Expert.
 * Usuário:  
 * Data: 27/05/2026
 * Tempo: 12:13
 * 
 */

using System;
using NxtControl.GuiFramework;
using Hidryco.HidrycoLib.SupportClasses;

namespace Hidryco.HidrycoLib.Graphics
{
	/// <summary>
	/// Description of Comporta.
	/// </summary>
	public partial class Comporta : NxtControl.GuiFramework.GraphicSymbol
	{
		public Comporta()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
		}
		
		private int _animacao = 0;
		public int Animacao
        {
            get { return _animacao; }
            set
            {
                _animacao = value;
                AtualizarVisual(_animacao);
            }
        }
		
		private void AtualizarVisual(int animacao)
        {
			
			NxtControl.Drawing.Color _color;
			NxtControl.Drawing.Color _color_two;
            switch (animacao)
            {
                case 0: 
					_color = HidrycoColors.Desligado;
					_color_two = HidrycoColors.Desligado;
					break;

				case 1: 
					_color = HidrycoColors.Ligado;
					_color_two = HidrycoColors.Ligado;
					break;

				case 2:
					_color = HidrycoColors.Falha;
					_color_two = HidrycoColors.Falha;
					break;

				case 3: 
					_color = HidrycoColors.Manutencao;
					_color_two = HidrycoColors.Manutencao;
					break;
					
				case 4: 
					_color = HidrycoColors.Desligado;
					_color_two = HidrycoColors.Ligado;
					break;
					
				default:
					_color = HidrycoColors.Unknown;
					_color_two = HidrycoColors.Unknown;
					break;
            }
            
            comp_1.BrushColor = _color;
            comp_2.BrushColor = _color;
            comp_3.BrushColor = _color;
            comp_4.BrushColor = _color_two;
            comp_5.BrushColor = _color_two;
            comp_6.BrushColor = _color_two;
        }
		
	}
}
