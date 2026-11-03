/*
 * Hidryco - Motor_Generico - fpMeasures
 * ISA-101: medicoes do inversor (texto preto sobre cinza, unidade em todos os valores).
 */

using System;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Faceplates.Motor_Generico
{
	public partial class fpMeasures : NxtControl.GuiFramework.HMIFaceplate
	{
		public fpMeasures()
		{
			InitializeComponent();
		}

		// ---- velocidade: a tag ja vem em % do CLP (0 % no LSP, 100 % no HSP do inversor; conversao no CLP) ----
		void VelHzValueChanged(object sender, ValueChangedEventArgs e)
		{
			((IHMIPrimitiveInput<float>)vSTS_VELOCIDADE).ValueChanged(Convert.ToSingle(e.Value));
		}
	}
}
