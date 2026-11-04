/*
 * Hidryco - DesidratacaoLodo - fpParametros
 * Fase solida: parametros (vazao das prensas, PID, protecoes, rodizios e nivel dos tanques).
 */

using System;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Faceplates.DesidratacaoLodo
{
	public partial class fpParametros : NxtControl.GuiFramework.HMIFaceplate
	{
		public fpParametros()
		{
			InitializeComponent();
			Atualiza();
		}
		static readonly NxtControl.Drawing.Color corSel = new NxtControl.Drawing.Color(96, 96, 96);
		static readonly NxtControl.Drawing.Color corNor = new NxtControl.Drawing.Color(208, 208, 208);
		static readonly NxtControl.Drawing.Color branco = new NxtControl.Drawing.Color(255, 255, 255);
		static readonly NxtControl.Drawing.Color preto = new NxtControl.Drawing.Color(0, 0, 0);
		void Marca(DrawnButton b, bool sel) { b.BrushColor = sel ? corSel : corNor; b.TextColor = sel ? branco : preto; }
		void XHabValueChanged(object s, ValueChangedEventArgs e) { Atualiza(); }
		void Atualiza()
		{
			bool h = xHab.Value != null && Convert.ToBoolean(xHab.Value);
			Marca(btnSoOn, h); Marca(btnSoOff, !h);
		}
		void BtnSoOnClick(object sender, EventArgs e) { FireEvent_E_PARAMETROS(true, false, 0F, true, 0F, true, 0F, true, 0F, true, 0F, true, 0F, true, 0F, true, 0F, true, (System.Int16)0, true, (System.Int16)0, true, (System.Int16)0, true, 0F, true); }
		void BtnSoOffClick(object sender, EventArgs e) { FireEvent_E_PARAMETROS(false, false, 0F, true, 0F, true, 0F, true, 0F, true, 0F, true, 0F, true, 0F, true, 0F, true, (System.Int16)0, true, (System.Int16)0, true, (System.Int16)0, true, 0F, true); }


	}
}
