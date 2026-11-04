/*
 * Hidryco - DesidratacaoLodo - sSV08
 * ISA-101: solenoide SV-08 (bit 5 de STS_SV): corpo cheio = aberta, vazio = fechada.
 */

using System;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Symbols.DesidratacaoLodo
{
	public partial class sSV08 : NxtControl.GuiFramework.HMISymbol
	{
		public sSV08()
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
			NxtControl.Drawing.Color c = (svM & 32) != 0 ? CHEIO : VAZIO;
			corpoE.BrushColor = c;
			corpoD.BrushColor = c;
		}
	}
}
