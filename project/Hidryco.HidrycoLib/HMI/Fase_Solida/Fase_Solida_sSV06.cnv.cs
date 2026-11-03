/*
 * Hidryco - Fase_Solida - sSV06
 * ISA-101: solenoide SV-06 (bit 4 de STS_SV): corpo cheio = aberta, vazio = fechada.
 */

using System;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Symbols.Fase_Solida
{
	public partial class sSV06 : NxtControl.GuiFramework.HMISymbol
	{
		public sSV06()
		{
			InitializeComponent();
			Atualiza();
		}
		// ---- dados recebidos da logica (Execute invisiveis)
		short svM;
		void XSVValueChanged(object s, ValueChangedEventArgs e) { svM = Convert.ToInt16(e.Value); Atualiza(); }
		static readonly NxtControl.Drawing.Color CHEIO = new NxtControl.Drawing.Color(64, 64, 64);
		static readonly NxtControl.Drawing.Color VAZIO = new NxtControl.Drawing.Color(255, 255, 255);
		void Atualiza()
		{
			NxtControl.Drawing.Color c = (svM & 16) != 0 ? CHEIO : VAZIO;
			corpoE.BrushColor = c;
			corpoD.BrushColor = c;
		}
	}
}
