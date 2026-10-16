/*
 * Hidryco - Motor_Generico - fpParameter
 * ISA-101: tempos de supervisao de partida/parada e velocidade manual (so com inversor).
 */

using System;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Faceplates.Motor_Generico
{
	public partial class fpParameter : NxtControl.GuiFramework.HMIFaceplate
	{
		public fpParameter()
		{
			InitializeComponent();
		}

		void InversorValueChanged(object sender, ValueChangedEventArgs e)
		{
			bool inv = Convert.ToBoolean(e.Value);
			lblVel.Visible = inv; vManual.Visible = inv;
		}

	}
}
