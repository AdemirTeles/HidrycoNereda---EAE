/*
 * Hidryco - Valvula_Coester - fpDiagnostico
 * Diagnostico do atuador: torque, temperatura, partidas, palavras de status e parametros de supervisao.
 */

using System;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Faceplates.Valvula_Coester
{
	public partial class fpDiagnostico : NxtControl.GuiFramework.HMIFaceplate
	{
		public fpDiagnostico()
		{
			InitializeComponent();
			Atualiza();
		}
		static readonly string[] FALHAS = { "", "FALTA DE FASE", "SOBREAQUECIMENTO DO MOTOR", "ATUADOR SEM PROGRAMAÇÃO", "PARADA DE EMERGÊNCIA LOCAL",
			"TORQUE NA ABERTURA", "TORQUE NO FECHAMENTO", "VÁLVULA TRAVADA", "OPERAÇÃO INCOMPLETA", "FALHA AO ENERGIZAR O MOTOR",
			"MOTOR ENERGIZADO APÓS FIM DE CURSO", "MOTOR ENERGIZADO APÓS PARADA", "FALHA DE COMANDO", "TENSÃO ALTA", "TENSÃO BAIXA",
			"FIM DE CURSO MECÂNICO ULTRAPASSADO", "FIM DE CURSO PROGRAMADO ULTRAPASSADO", "CARTÃO DE REDE NÃO DETECTADO" };
		static string Falha(short c) { return c > 0 && c < FALHAS.Length ? FALHAS[c] : "FALHA DO ATUADOR"; }

		// ---- dados recebidos da logica (Execute invisiveis)
		short torq, torqP, temp, tPerc, pDia, pMax, w2, w3, w4, cod;
		bool mCont, fAtu;
		void XTORQValueChanged(object s, ValueChangedEventArgs e) { torq = Convert.ToInt16(e.Value); Atualiza(); }
		void XTORQPValueChanged(object s, ValueChangedEventArgs e) { torqP = Convert.ToInt16(e.Value); Atualiza(); }
		void XTEMPValueChanged(object s, ValueChangedEventArgs e) { temp = Convert.ToInt16(e.Value); Atualiza(); }
		void XTPERCValueChanged(object s, ValueChangedEventArgs e) { tPerc = Convert.ToInt16(e.Value); Atualiza(); }
		void XPDIAValueChanged(object s, ValueChangedEventArgs e) { pDia = Convert.ToInt16(e.Value); Atualiza(); }
		void XPMAXValueChanged(object s, ValueChangedEventArgs e) { pMax = Convert.ToInt16(e.Value); Atualiza(); }
		void XMCONTValueChanged(object s, ValueChangedEventArgs e) { mCont = Convert.ToBoolean(e.Value); Atualiza(); }
		void XW2ValueChanged(object s, ValueChangedEventArgs e) { w2 = Convert.ToInt16(e.Value); Atualiza(); }
		void XW3ValueChanged(object s, ValueChangedEventArgs e) { w3 = Convert.ToInt16(e.Value); Atualiza(); }
		void XW4ValueChanged(object s, ValueChangedEventArgs e) { w4 = Convert.ToInt16(e.Value); Atualiza(); }
		void XCODValueChanged(object s, ValueChangedEventArgs e) { cod = Convert.ToInt16(e.Value); Atualiza(); }
		void XFATUValueChanged(object s, ValueChangedEventArgs e) { fAtu = Convert.ToBoolean(e.Value); Atualiza(); }
		static string Hex(short w) { return "16#" + ((ushort)w).ToString("X4"); }

		void Atualiza()
		{
			vTorque.Text = torq.ToString() + " Nm  (" + torqP.ToString() + " %)";
			vTemp.Text = temp.ToString() + " °C";
			vPerc.Text = tPerc.ToString() + " s";
			vPart.Text = pDia.ToString() + " / " + pMax.ToString();
			vCont.Text = mCont ? "SIM" : "NÃO";
			vWords.Text = Hex(w2) + " " + Hex(w3) + " " + Hex(w4);
			vFalha.Text = fAtu ? Falha(cod) : "-";
		}

	}
}
