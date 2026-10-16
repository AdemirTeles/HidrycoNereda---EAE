/*
 * Hidryco - Subestacao - sDefault
 * Unifilar do QGBT 440 V: QTAM 1 (G2) e QTAM 2 (G1), 1Q1/1Q0/1Q2, barras A e B, saidas e QGBT 220 V. Vermelho = fechado, verde = aberto.
 */

using System;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Symbols.Subestacao
{
	public partial class sDefault : NxtControl.GuiFramework.HMISymbol
	{
		public sDefault()
		{
			InitializeComponent();
			Atualiza();
		}

		// Indicador de alarme (ISA-101): forma + numero de prioridade + texto; escondido quando normal.
		// naoRec = alarme ainda nao reconhecido: a forma pisca (fase do temporizador), o texto fica fixo.
		bool fase = true;
		void Indicador(Rectangle p1, FreeText p1n, Polygon p2, FreeText p2n, FreeText txt, int prioridade, string texto, bool naoRec = false)
		{
			bool mostra = !naoRec || fase;
			p1.Visible = prioridade == 1 && mostra; p1n.Visible = prioridade == 1 && mostra;
			p2.Visible = prioridade == 2 && mostra; p2n.Visible = prioridade == 2 && mostra;
			txt.Visible = prioridade > 0;
			txt.Text = texto;
		}

		// Estado do ALARM_BIT (STATE_1): 2 = ativo nao reconhecido, 3 = saiu nao reconhecido, 4 = ativo e saiu nao reconhecido
		static bool NaoRec(byte estadoAlarme) { return estadoAlarme >= 2 && estadoAlarme <= 4; }

		System.Timers.Timer tPisca;

		// Liga o pisca (500 ms) enquanto houver alarme nao reconhecido; desliga e deixa a forma fixa quando nao houver
		void Pisca(bool precisa)
		{
			if (precisa && tPisca == null)
			{
				tPisca = new System.Timers.Timer();
				tPisca.Interval = 500D;
				tPisca.Elapsed += new System.Timers.ElapsedEventHandler(TPiscaElapsed);
				tPisca.Start();
			}
			else if (!precisa && tPisca != null)
			{
				tPisca.Stop();
				tPisca.Dispose();
				tPisca = null;
				fase = true;
			}
		}

		// O temporizador roda em outra thread: a troca de fase vai para a thread da IHM
		void TPiscaElapsed(object sender, System.Timers.ElapsedEventArgs e)
		{
			NxtControl.Services.IHMIMainThreadService svc = NxtControl.Services.ServiceProvider.GetService(typeof(NxtControl.Services.IHMIMainThreadService)) as NxtControl.Services.IHMIMainThreadService;
			if (svc != null) svc.SafeThreadAsyncCall(new Action(AlternaFase));
		}

		void AlternaFase()
		{
			if (tPisca == null) return;
			fase = !fase;
			Atualiza();
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && tPisca != null)
			{
				tPisca.Stop();
				tPisca.Dispose();
				tPisca = null;
			}
			base.Dispose(disposing);
		}


		static readonly NxtControl.Drawing.Color corFechado = new NxtControl.Drawing.Color(((byte)(200)), ((byte)(30)), ((byte)(30)));
		static readonly NxtControl.Drawing.Color corAberto = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(140)), ((byte)(60)));
		static readonly NxtControl.Drawing.Color corIndef = new NxtControl.Drawing.Color(((byte)(190)), ((byte)(190)), ((byte)(190)));
		// e: 2 fechado (vermelho), 1 aberto (verde), outro = sem informacao (cinza)
		static void Cor(Rectangle r, int e) { r.Brush = new NxtControl.Drawing.Brush(e == 2 ? corFechado : e == 1 ? corAberto : corIndef); }
		static bool B(object v) { return v != null && Convert.ToBoolean(v); }
		static short S(object v) { return v == null ? (short)0 : Convert.ToInt16(v); }
		static byte E(object v) { return v == null ? (byte)0 : Convert.ToByte(v); }
		static string Fonte(short f) { switch (f) { case 1: return "REDE"; case 2: return "GERADOR"; case 0: return "SEM ALIMENTAÇÃO"; default: return "INDEFINIDA"; } }
		static string Estado(short e) { switch (e) { case 1: return "Aberto"; case 2: return "Fechado"; case 3: return "Posição indefinida"; default: return "Sem informação"; } }
		static string Sinais(bool local, bool remoto, bool mola, bool pronto, bool semFalha)
		{
			string s = local ? "Local" : remoto ? "Remoto" : "Local/remoto: —";
			s += mola ? " · mola carregada" : " · mola descarregada";
			if (pronto) s += "\r\nPronto para fechar";
			if (!semFalha) s += "\r\nFALHA (desarmado)";
			return s;
		}
		void DjChanged(object s, ValueChangedEventArgs e) { Atualiza(); }
		void MpChanged(object s, ValueChangedEventArgs e) { Atualiza(); }

		void Linha(Rectangle p1, FreeText p1n, Polygon p2, FreeText p2n, FreeText txt, FreeText normal, bool ativo, int prioridade, bool naoRec)
		{
			Indicador(p1, p1n, p2, p2n, txt, ativo ? prioridade : 0, "ATIVO", naoRec);
			normal.Visible = !ativo;
		}

		void Atualiza()
		{
			bool remota = B(xRemota.Value);

			Cor(bRES_A1, remota ? 0 : (B(xDJ_RES_A1.Value) ? 2 : 1));
			Cor(bRES_A2, remota ? 0 : (B(xDJ_RES_A2.Value) ? 2 : 1));
			Cor(bPCM_EEE_BRUTO, remota ? 0 : (B(xDJ_PCM_EEE_BRUTO.Value) ? 2 : 1));
			Cor(bPCM_DESINFECCAO, remota ? 0 : (B(xDJ_PCM_DESINFECCAO.Value) ? 2 : 1));
			Cor(bQGBT_220V, remota ? 0 : (B(xDJ_QGBT_220V.Value) ? 2 : 1));
			Cor(bUCT_200_01, remota ? 0 : (B(xDJ_UCT_200_01.Value) ? 2 : 1));
			Cor(bCOMP_500_02, remota ? 0 : (B(xDJ_COMP_500_02.Value) ? 2 : 1));
			Cor(bV4603, remota ? 0 : (B(xDJ_V4603.Value) ? 2 : 1));
			Cor(bV4604, remota ? 0 : (B(xDJ_V4604.Value) ? 2 : 1));
			Cor(bBANCO_CAPACITORES, remota ? 0 : (B(xDJ_BANCO_CAPACITORES.Value) ? 2 : 1));
			Cor(bPCE_SUBESTACAO, remota ? 0 : (B(xDJ_PCE_SUBESTACAO.Value) ? 2 : 1));
			Cor(bCOMP_500_01, remota ? 0 : (B(xDJ_COMP_500_01.Value) ? 2 : 1));
			Cor(bUCT_200_02, remota ? 0 : (B(xDJ_UCT_200_02.Value) ? 2 : 1));
			Cor(bUCT_200_03, remota ? 0 : (B(xDJ_UCT_200_03.Value) ? 2 : 1));
			Cor(bPCM_NEREDA, remota ? 0 : (B(xDJ_PCM_NEREDA.Value) ? 2 : 1));
			Cor(bPCM_LODO, remota ? 0 : (B(xDJ_PCM_LODO.Value) ? 2 : 1));
			Cor(bCAP2, remota ? 0 : (B(xDJ_CAP2.Value) ? 2 : 1));
			Cor(bPCM_AGUA_REUSO, remota ? 0 : (B(xDJ_PCM_AGUA_REUSO.Value) ? 2 : 1));
			Cor(bMO_500_01, remota ? 0 : (B(xDJ_MO_500_01.Value) ? 2 : 1));
			Cor(bV4601, remota ? 0 : (B(xDJ_V4601.Value) ? 2 : 1));
			Cor(bV4602, remota ? 0 : (B(xDJ_V4602.Value) ? 2 : 1));
			Cor(bRES_B1, remota ? 0 : (B(xDJ_RES_B1.Value) ? 2 : 1));
			Cor(bRES_B2, remota ? 0 : (B(xDJ_RES_B2.Value) ? 2 : 1));
			Cor(bRES_B3, remota ? 0 : (B(xDJ_RES_B3.Value) ? 2 : 1));
			Cor(bQGBT_220V_ENTRADA, remota ? 0 : (B(xDJ_QGBT_220V_ENTRADA.Value) ? 2 : 1));
			Cor(bQL_ADM, remota ? 0 : (B(xDJ_QL_ADM.Value) ? 2 : 1));
			Cor(bQL_PORTARIA, remota ? 0 : (B(xDJ_QL_PORTARIA.Value) ? 2 : 1));
			Cor(bQLSL, remota ? 0 : (B(xDJ_QLSL.Value) ? 2 : 1));
			Cor(bQL_ILUMINACAO, remota ? 0 : (B(xDJ_QL_ILUMINACAO.Value) ? 2 : 1));
			Cor(bPCE_SOPRADORES, remota ? 0 : (B(xDJ_PCE_SOPRADORES.Value) ? 2 : 1));
			Cor(bQL_LODO, remota ? 0 : (B(xDJ_QL_LODO.Value) ? 2 : 1));
			Cor(bRES_C1, remota ? 0 : (B(xDJ_RES_C1.Value) ? 2 : 1));
			Cor(bRES_C2, remota ? 0 : (B(xDJ_RES_C2.Value) ? 2 : 1));
			Cor(bRES_C3, remota ? 0 : (B(xDJ_RES_C3.Value) ? 2 : 1));
			Cor(bRES_C4, remota ? 0 : (B(xDJ_RES_C4.Value) ? 2 : 1));
			Cor(bRES_C5, remota ? 0 : (B(xDJ_RES_C5.Value) ? 2 : 1));
			Cor(bRES_C6, remota ? 0 : (B(xDJ_RES_C6.Value) ? 2 : 1));
			Cor(b1Q1, S(xEST_1Q1.Value)); tEst1Q1.Text = Estado(S(xEST_1Q1.Value));
			tSt1Q1.Text = remota ? "" : Sinais(B(xMPL_1Q1.Value), B(xMPR_1Q1.Value), B(xMPC_1Q1.Value), B(xMPP_1Q1.Value), B(xMPSF_1Q1.Value));
			Cor(b1Q0, S(xEST_1Q0.Value)); tEst1Q0.Text = Estado(S(xEST_1Q0.Value));
			tSt1Q0.Text = remota ? "" : Sinais(B(xMPL_1Q0.Value), B(xMPR_1Q0.Value), B(xMPC_1Q0.Value), B(xMPP_1Q0.Value), B(xMPSF_1Q0.Value));
			Cor(b1Q2, S(xEST_1Q2.Value)); tEst1Q2.Text = Estado(S(xEST_1Q2.Value));
			tSt1Q2.Text = remota ? "" : Sinais(B(xMPL_1Q2.Value), B(xMPR_1Q2.Value), B(xMPC_1Q2.Value), B(xMPP_1Q2.Value), B(xMPSF_1Q2.Value));
			Cor(bQ2QTAM1, S(xQTAM1_GERADOR.Value)); Cor(bQ1QTAM1, S(xQTAM1_REDE.Value));
			tFonteQTAM1.Text = "Saída: " + (S(xQTAM1_GERADOR.Value) == 2 ? "GERADOR" : S(xQTAM1_REDE.Value) == 2 ? "REDE" : (S(xQTAM1_GERADOR.Value) == 0 && S(xQTAM1_REDE.Value) == 0) ? "SEM INFORMAÇÃO" : "SEM FONTE");
			Cor(bQ2QTAM2, S(xQTAM2_GERADOR.Value)); Cor(bQ1QTAM2, S(xQTAM2_REDE.Value));
			tFonteQTAM2.Text = "Saída: " + (S(xQTAM2_GERADOR.Value) == 2 ? "GERADOR" : S(xQTAM2_REDE.Value) == 2 ? "REDE" : (S(xQTAM2_GERADOR.Value) == 0 && S(xQTAM2_REDE.Value) == 0) ? "SEM INFORMAÇÃO" : "SEM FONTE");
			tBarraA.Text = "BARRA A - " + Fonte(S(xFA.Value));
			tBarraB.Text = "BARRA B - " + Fonte(S(xFB.Value));
			tPlanta.Text = B(xPlanta.Value) ? "Planta nos geradores" : "Planta na rede";
			tRemota.Text = remota ? "Remota 1 sem comunicação: disjuntores sem informação" : "";
			bool algum = false, naoRec = false; int prio = 0;

			{ bool a = B(xAF1q1.Value); bool nr = NaoRec(E(xEF1q1.Value)); Linha(iF1q1P1, iF1q1P1n, iF1q1P2, iF1q1P2n, iF1q1Txt, nF1q1, a, 1, nr); if (a) { algum = true; if (prio == 0 || 1 < prio) prio = 1; } naoRec |= nr; }
			{ bool a = B(xAF1q0.Value); bool nr = NaoRec(E(xEF1q0.Value)); Linha(iF1q0P1, iF1q0P1n, iF1q0P2, iF1q0P2n, iF1q0Txt, nF1q0, a, 1, nr); if (a) { algum = true; if (prio == 0 || 1 < prio) prio = 1; } naoRec |= nr; }
			{ bool a = B(xAF1q2.Value); bool nr = NaoRec(E(xEF1q2.Value)); Linha(iF1q2P1, iF1q2P1n, iF1q2P2, iF1q2P2n, iF1q2Txt, nF1q2, a, 1, nr); if (a) { algum = true; if (prio == 0 || 1 < prio) prio = 1; } naoRec |= nr; }
			{ bool a = B(xAD1q1.Value); bool nr = NaoRec(E(xED1q1.Value)); Linha(iD1q1P1, iD1q1P1n, iD1q1P2, iD1q1P2n, iD1q1Txt, nD1q1, a, 2, nr); if (a) { algum = true; if (prio == 0 || 2 < prio) prio = 2; } naoRec |= nr; }
			{ bool a = B(xAD1q0.Value); bool nr = NaoRec(E(xED1q0.Value)); Linha(iD1q0P1, iD1q0P1n, iD1q0P2, iD1q0P2n, iD1q0Txt, nD1q0, a, 2, nr); if (a) { algum = true; if (prio == 0 || 2 < prio) prio = 2; } naoRec |= nr; }
			{ bool a = B(xAD1q2.Value); bool nr = NaoRec(E(xED1q2.Value)); Linha(iD1q2P1, iD1q2P1n, iD1q2P2, iD1q2P2n, iD1q2Txt, nD1q2, a, 2, nr); if (a) { algum = true; if (prio == 0 || 2 < prio) prio = 2; } naoRec |= nr; }
			{ bool a = B(xAC1q1.Value); bool nr = NaoRec(E(xEC1q1.Value)); Linha(iC1q1P1, iC1q1P1n, iC1q1P2, iC1q1P2n, iC1q1Txt, nC1q1, a, 2, nr); if (a) { algum = true; if (prio == 0 || 2 < prio) prio = 2; } naoRec |= nr; }
			{ bool a = B(xAC1q0.Value); bool nr = NaoRec(E(xEC1q0.Value)); Linha(iC1q0P1, iC1q0P1n, iC1q0P2, iC1q0P2n, iC1q0Txt, nC1q0, a, 2, nr); if (a) { algum = true; if (prio == 0 || 2 < prio) prio = 2; } naoRec |= nr; }
			{ bool a = B(xAC1q2.Value); bool nr = NaoRec(E(xEC1q2.Value)); Linha(iC1q2P1, iC1q2P1n, iC1q2P2, iC1q2P2n, iC1q2Txt, nC1q2, a, 2, nr); if (a) { algum = true; if (prio == 0 || 2 < prio) prio = 2; } naoRec |= nr; }
			Indicador(alP1, alP1n, alP2, alP2n, alTxt, algum ? prio : 0, algum ? "ALARME NO QGBT" : "", naoRec);
			Pisca(naoRec);
		}

		void BtnResetClick(object sender, EventArgs e) { FireEvent_E_RESET(true); FireEvent_E_RESET(false); }

	}
}
