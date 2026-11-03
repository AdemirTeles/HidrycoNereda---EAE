/*
 * Hidryco - grafico BombaHelicoidal
 * Mesma convencao do grafico Bomba: Animacao 0 desligado, 1 ligado, 2 falha, 3 manutencao.
 */

using System;
using NxtControl.GuiFramework;
using Hidryco.HidrycoLib.SupportClasses;

namespace Hidryco.HidrycoLib.Graphics
{
	public partial class BombaHelicoidal : NxtControl.GuiFramework.GraphicSymbol
	{
		public BombaHelicoidal()
		{
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
			NxtControl.Drawing.Color c;
			switch (animacao)
			{
				case 0: c = HidrycoColors.Desligado; break;
				case 1: c = HidrycoColors.Ligado; break;
				case 2: c = HidrycoColors.Falha; break;
				case 3: c = HidrycoColors.Manutencao; break;
				default: c = HidrycoColors.Unknown; break;
			}
			hl_1.BrushColor = c;
			hl_2.BrushColor = c;
			hl_3.BrushColor = c;
			hl_4.BrushColor = c;
			hl_5.BrushColor = c;
			hl_6.BrushColor = c;
			hl_7.BrushColor = c;
			hl_8.BrushColor = c;
		}
	}
}
