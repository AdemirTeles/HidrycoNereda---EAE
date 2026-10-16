/*
 * Hidryco - Motor_Generico - fpMaintenance
 * ISA-101: horimetro (h e min; contado no CAT com resolucao de 1 s, gravado na persistencia) e numero de partidas, com reset.
 */

using System;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Faceplates.Motor_Generico
{
	public partial class fpMaintenance : NxtControl.GuiFramework.HMIFaceplate
	{
		public fpMaintenance()
		{
			InitializeComponent();
		}

		void BtnResetHorClick(object sender, EventArgs e) { FireEvent_E_RESET_HORIMETRO(true); FireEvent_E_RESET_HORIMETRO(false); }
		void BtnResetPartClick(object sender, EventArgs e) { FireEvent_E_RESET_NUMERO_PARTIDAS(true); FireEvent_E_RESET_NUMERO_PARTIDAS(false); }

	}
}
