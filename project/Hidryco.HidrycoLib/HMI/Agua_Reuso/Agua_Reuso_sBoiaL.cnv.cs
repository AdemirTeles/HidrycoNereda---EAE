/*
 * Hidryco - Agua_Reuso - sBoiaL
 * Boia 1000-LSL-01 (nivel baixo): sobe/desce com a boia; verde levantada, vermelha abaixada (perigo); cinza sem comunicacao.
 */

using System;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Symbols.Agua_Reuso
{
	public partial class sBoiaL : NxtControl.GuiFramework.HMISymbol
	{
		public sBoiaL()
		{
			InitializeComponent();
			Atualiza();
		}

		const bool PERIGO_LEVANTADA = false;      // LSH: perigo com a boia levantada; LSL: perigo abaixada
		static readonly NxtControl.Drawing.Color VERDE = new NxtControl.Drawing.Color(0, 170, 70);
		static readonly NxtControl.Drawing.Color VERMELHO = new NxtControl.Drawing.Color(220, 30, 30);
		static readonly NxtControl.Drawing.Color CINZA = new NxtControl.Drawing.Color(180, 180, 180);
		bool recebido, levantada, semCom;

		void PosValueChanged(object sender, ValueChangedEventArgs e) { levantada = Convert.ToBoolean(e.Value); recebido = true; Atualiza(); }
		void SemComValueChanged(object sender, ValueChangedEventArgs e) { semCom = Convert.ToBoolean(e.Value); Atualiza(); }

		void Atualiza()
		{
			// animacao: circulo sobe quando a boia esta levantada e desce quando abaixada
			boia.Bounds = new NxtControl.Drawing.RectF(8F, levantada ? 8F : 28F, 16F, 16F);
			if (!recebido || semCom) boia.BrushColor = CINZA;
			else boia.BrushColor = (levantada == PERIGO_LEVANTADA) ? VERMELHO : VERDE;
		}
	}
}
