/*
 * Hidryco - EEE_Bruto - sBoiaL
 * Boia LSL-04 (nivel baixo): a boia sobe/desce no cabo; verde = normal, vermelha = perigo (abaixada), cinza = sem leitura.
 * O estado aparece escrito ao lado (levantada / abaixada).
 */

using System;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Symbols.EEE_Bruto
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
		static readonly NxtControl.Drawing.Color TEXTO_CINZA = new NxtControl.Drawing.Color(110, 110, 110);
		static readonly NxtControl.Drawing.Color TEXTO_VERDE = new NxtControl.Drawing.Color(0, 120, 50);
		bool recebido, levantada;

		void PosValueChanged(object sender, ValueChangedEventArgs e) { levantada = Convert.ToBoolean(e.Value); recebido = true; Atualiza(); }

		void Atualiza()
		{
			// animacao: a boia sobe no cabo quando levantada e desce quando abaixada
			float topo = levantada ? 2F : 25F;
			boia.Bounds = new NxtControl.Drawing.RectF(2F, topo, 32F, 22F);
			cabo.EndPoint = new NxtControl.Drawing.PointF(18D, topo);
			estado.Location = new NxtControl.Drawing.PointF(40D, topo + 3F);
			if (!recebido)
			{
				boia.BrushColor = CINZA;
				estado.Color = TEXTO_CINZA;
				estado.Text = "sem leitura";
				return;
			}
			bool perigo = (levantada == PERIGO_LEVANTADA);
			boia.BrushColor = perigo ? VERMELHO : VERDE;
			estado.Color = perigo ? VERMELHO : TEXTO_VERDE;
			estado.Text = levantada ? "levantada" : "abaixada";
		}
	}
}
