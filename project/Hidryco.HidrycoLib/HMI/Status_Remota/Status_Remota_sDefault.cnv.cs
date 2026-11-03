/*
 * Hidryco - Status_Remota - sDefault
 * Estado da comunicacao da remota: verde comunicando, amarelo sem comunicacao, cinza aguardando.
 */

using System;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Symbols.Status_Remota
{
	public partial class sDefault : NxtControl.GuiFramework.HMISymbol
	{
		public sDefault()
		{
			InitializeComponent();
			Atualiza();
		}

		// ---- dados recebidos da logica (Execute invisiveis)
		short est;
		void XESTValueChanged(object s, ValueChangedEventArgs e) { est = Convert.ToInt16(e.Value); Atualiza(); }

		static readonly NxtControl.Drawing.Color OK = new NxtControl.Drawing.Color(0, 140, 60);
		static readonly NxtControl.Drawing.Color FALHA = Hidryco.HidrycoLib.SupportClasses.HidrycoColors.Falha;
		static readonly NxtControl.Drawing.Color AGUARDA = new NxtControl.Drawing.Color(150, 150, 150);

		void Atualiza()
		{
			if (est == 1) { fundo.Brush = new NxtControl.Drawing.Brush(OK); tEst.Text = "COMUNICANDO"; tEst.Color = new NxtControl.Drawing.Color(255, 255, 255); }
			else if (est == 2) { fundo.Brush = new NxtControl.Drawing.Brush(FALHA); tEst.Text = "SEM COMUNICAÇÃO"; tEst.Color = new NxtControl.Drawing.Color(0, 0, 0); }
			else { fundo.Brush = new NxtControl.Drawing.Brush(AGUARDA); tEst.Text = "AGUARDANDO"; tEst.Color = new NxtControl.Drawing.Color(255, 255, 255); }
		}
	}
}
