/*
 * Criado pelo EcoStruxure Automation Expert.
 * Usuário:  
 * Data: 18/08/2026
 * Tempo: 17:49
 * 
 */

using System;
using NxtControl.GuiFramework;
using Hidryco.HidrycoLib.SupportClasses;

namespace Hidryco.HidrycoLib.Graphics
{
	/// <summary>
	/// Description of Motor_Invertido.
	/// </summary>
	public partial class Motor_Invertido : NxtControl.GuiFramework.GraphicSymbol
	{
		public Motor_Invertido()
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
            switch (animacao)
            {
                case 0: 
					_color = HidrycoColors.Desligado;
					break;

				case 1: 
					_color = HidrycoColors.Ligado;
					break;

				case 2:
					_color = HidrycoColors.Falha;
					break;

				case 3: 
					_color = HidrycoColors.Manutencao;
					break;
					
				default:
					_color = HidrycoColors.Unknown;
					break;
            }
            
            mtr_1.BrushColor = _color;
            mtr_2.BrushColor = _color;
            mtr_3.BrushColor = _color;
        }
	}
}
