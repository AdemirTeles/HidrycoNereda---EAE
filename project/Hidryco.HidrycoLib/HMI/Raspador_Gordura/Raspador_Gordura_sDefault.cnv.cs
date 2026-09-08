/*
 * Criado pelo EcoStruxure Automation Expert.
 * Usuário:  
 * Data: 04/03/2026
 * Tempo: 12:01
 * 
 */

using System;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Symbols.Raspador_Gordura
{
	/// <summary>
	/// Description of sDefault.
	/// </summary>
	public partial class sDefault : NxtControl.GuiFramework.HMISymbol
	{
		private ushort _stsAnimacao;

		private readonly NxtControl.Drawing.Color _colorGreen   = NxtControl.Drawing.SystemColors.Green;
		private readonly NxtControl.Drawing.Color _colorRed     = NxtControl.Drawing.Color.FromName("SE.App2Base.aaLibAlarmActive");
		private readonly NxtControl.Drawing.Color _colorYellow  = NxtControl.Drawing.Color.FromName("SE.App2Base.Abnormal");
		private readonly NxtControl.Drawing.Color _colorBlue    = NxtControl.Drawing.SystemColors.Blue;
		private readonly NxtControl.Drawing.Color _colorUnknown = NxtControl.Drawing.Color.FromName("SE.App2Base.Unknown");

		public sDefault()
		{
			InitializeComponent();
		}

		void STS_ANIMACAOValueChanged(object sender, ValueChangedEventArgs e)
		{
			_stsAnimacao = Convert.ToUInt16(e.Value);


			NxtControl.Drawing.Color color;

			switch (_stsAnimacao)
			{
				case 0: // Vermelho
					color = _colorRed;
					break;

				case 1: // Verde
					color = _colorGreen;
					break;

				case 2: // Amarelo
					color = _colorYellow;
					break;

				case 3: // Azul
					color = _colorBlue;
					break;

				default: // Desconhecido
					color = _colorUnknown;
					break;
			}

			// Aplica a cor em todas as formas
			Base1R.BrushColor   = color;
			Base2R.BrushColor   = color;
			Base3R.BrushColor = color;
		}

	}
}
