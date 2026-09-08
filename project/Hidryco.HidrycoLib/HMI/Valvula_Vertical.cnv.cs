/*
 * Criado pelo EcoStruxure Automation Expert.
 * Usuário:  
 * Data: 27/05/2026
 * Tempo: 11:45
 * 
 */

using System;
using NxtControl.GuiFramework;
using Hidryco.HidrycoLib.SupportClasses;

namespace Hidryco.HidrycoLib.Graphics
{
	/// <summary>
	/// Description of Valvula_Vertical.
	/// </summary>
	public partial class Valvula_Vertical : NxtControl.GuiFramework.GraphicSymbol
	{
		public Valvula_Vertical()
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
            
            vlv_1.BrushColor = _color;
            vlv_2.BrushColor = _color_two;
            vlv_3.BrushColor = _color;
        }
	}
}
