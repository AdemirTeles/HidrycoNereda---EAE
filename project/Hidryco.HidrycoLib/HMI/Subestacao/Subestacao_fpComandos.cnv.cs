/*
 * Hidryco - Subestacao - fpComandos
 * Comandos de abrir/fechar dos Masterpact 1Q1, 1Q0 e 1Q2 com intertravamentos e confirmacao, e os alarmes de cada um.
 */

using System;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Faceplates.Subestacao
{
	public partial class fpComandos : NxtControl.GuiFramework.HMIFaceplate
	{
		public fpComandos()
		{
			InitializeComponent();
			Atualiza();
		}

		static readonly NxtControl.Drawing.Color corFechado = new NxtControl.Drawing.Color(((byte)(200)), ((byte)(30)), ((byte)(30)));
		static readonly NxtControl.Drawing.Color corAberto = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(140)), ((byte)(60)));
		static readonly NxtControl.Drawing.Color corIndef = new NxtControl.Drawing.Color(((byte)(190)), ((byte)(190)), ((byte)(190)));
		static void Cor(Rectangle r, int e) { r.Brush = new NxtControl.Drawing.Brush(e == 2 ? corFechado : e == 1 ? corAberto : corIndef); }
		static bool B(object v) { return v != null && Convert.ToBoolean(v); }
		static short S(object v) { return v == null ? (short)0 : Convert.ToInt16(v); }
		static string Estado(short e) { switch (e) { case 1: return "Aberto"; case 2: return "Fechado"; case 3: return "Posição indefinida"; default: return "Sem informação"; } }
		void Muda(object s, ValueChangedEventArgs e) { Atualiza(); }
		short pendente;

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
		static byte E(object v) { return v == null ? (byte)0 : Convert.ToByte(v); }

		void Linha(Rectangle p1, FreeText p1n, Polygon p2, FreeText p2n, FreeText txt, FreeText normal, bool ativo, int prioridade, bool naoRec)
		{
			Indicador(p1, p1n, p2, p2n, txt, ativo ? prioridade : 0, "ATIVO", naoRec);
			normal.Visible = !ativo;
		}

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

		// Alarmes de um Masterpact (falha = prioridade 1; posicao indefinida e sem resposta = prioridade 2)
		bool Alarmes(object aF, object eF, object aD, object eD, object aC, object eC,
		             Rectangle fP1, FreeText fP1n, Polygon fP2, FreeText fP2n, FreeText fTxt, FreeText fN,
		             Rectangle dP1, FreeText dP1n, Polygon dP2, FreeText dP2n, FreeText dTxt, FreeText dN,
		             Rectangle cP1, FreeText cP1n, Polygon cP2, FreeText cP2n, FreeText cTxt, FreeText cN)
		{
			bool nF = NaoRec(E(eF)), nD = NaoRec(E(eD)), nC = NaoRec(E(eC));
			Linha(fP1, fP1n, fP2, fP2n, fTxt, fN, B(aF), 1, nF);
			Linha(dP1, dP1n, dP2, dP2n, dTxt, dN, B(aD), 2, nD);
			Linha(cP1, cP1n, cP2, cP2n, cTxt, cN, B(aC), 2, nC);
			return nF || nD || nC;
		}

		void BtnResetClick(object sender, EventArgs e) { FireEvent_E_RESET(true); FireEvent_E_RESET(false); }

		// Atualiza uma coluna; "outros" = estados dos dois outros Masterpact (fechar so com um deles aberto)
		void Coluna(string nome, short est, bool local, bool remoto, bool pronto, bool mola, bool semFalha, bool pA, bool pF, bool cA, bool cF, short o1, short o2, string o1n, string o2n,
		            Rectangle b, FreeText te, FreeText vL, FreeText vP, FreeText vC, FreeText vSF, FreeText tc, FreeText tm, DrawnButton bA, DrawnButton bF, bool remota)
		{
			Cor(b, remota ? 0 : est);
			te.Text = remota ? "Sem informação" : Estado(est);
			vL.Text = remota ? "—" : local ? "LOCAL" : remoto ? "Remoto" : "—";
			vP.Text = remota ? "—" : pronto ? "Sim" : "Não";
			vC.Text = remota ? "—" : mola ? "Carregada" : "Descarregada";
			vSF.Text = remota ? "—" : semFalha ? "Normal" : "DESARMADO";
			tc.Text = cA ? "Abrindo..." : cF ? "Fechando..." : "";
			bA.Enabled = pA && !cA && !cF;
			bF.Enabled = pF && !cA && !cF;
			string m = "";
			if (!remota && est == 1 && !pF)
			{
				if (local || !remoto) m += "\r\n- em local";
				if (!pronto) m += "\r\n- não está pronto para fechar";
				if (!mola) m += "\r\n- mola descarregada";
				if (!semFalha) m += "\r\n- desarmado";
				if (o1 != 1 && o2 != 1) m += "\r\n- " + o1n + " e " + o2n + " fechados";
				m = m.Length > 0 ? "Fechar bloqueado:" + m : "";
			}
			else if (!remota && est == 2 && !pA) m = "Abrir bloqueado: em local";
			tm.Text = m;
		}

		void Atualiza()
		{
			bool remota = B(xRemota.Value);
			tRemota.Text = remota ? "Remota 1 sem comunicação: comandos bloqueados" : "";
			short e1 = S(xE_1Q1.Value), e0 = S(xE_1Q0.Value), e2 = S(xE_1Q2.Value);

			Coluna("1Q1", e1, B(xL_1Q1.Value), B(xR_1Q1.Value), B(xP_1Q1.Value), B(xC_1Q1.Value), B(xSF_1Q1.Value), B(xPA_1Q1.Value), B(xPF_1Q1.Value), B(xCA_1Q1.Value), B(xCF_1Q1.Value), e0, e2, "1Q0", "1Q2", b1Q1, e1Q1, vL_1Q1, vP_1Q1, vC_1Q1, vSF_1Q1, c1Q1, m1Q1, btnAbrir1Q1, btnFechar1Q1, remota);
			Coluna("1Q0", e0, B(xL_1Q0.Value), B(xR_1Q0.Value), B(xP_1Q0.Value), B(xC_1Q0.Value), B(xSF_1Q0.Value), B(xPA_1Q0.Value), B(xPF_1Q0.Value), B(xCA_1Q0.Value), B(xCF_1Q0.Value), e1, e2, "1Q1", "1Q2", b1Q0, e1Q0, vL_1Q0, vP_1Q0, vC_1Q0, vSF_1Q0, c1Q0, m1Q0, btnAbrir1Q0, btnFechar1Q0, remota);
			Coluna("1Q2", e2, B(xL_1Q2.Value), B(xR_1Q2.Value), B(xP_1Q2.Value), B(xC_1Q2.Value), B(xSF_1Q2.Value), B(xPA_1Q2.Value), B(xPF_1Q2.Value), B(xCA_1Q2.Value), B(xCF_1Q2.Value), e0, e1, "1Q0", "1Q1", b1Q2, e1Q2, vL_1Q2, vP_1Q2, vC_1Q2, vSF_1Q2, c1Q2, m1Q2, btnAbrir1Q2, btnFechar1Q2, remota);

			bool naoRec = false;
			naoRec |= Alarmes(xAF1q1.Value, xEF1q1.Value, xAD1q1.Value, xED1q1.Value, xAC1q1.Value, xEC1q1.Value,
				iF1q1P1, iF1q1P1n, iF1q1P2, iF1q1P2n, iF1q1Txt, nF1q1, iD1q1P1, iD1q1P1n, iD1q1P2, iD1q1P2n, iD1q1Txt, nD1q1, iC1q1P1, iC1q1P1n, iC1q1P2, iC1q1P2n, iC1q1Txt, nC1q1);
			naoRec |= Alarmes(xAF1q0.Value, xEF1q0.Value, xAD1q0.Value, xED1q0.Value, xAC1q0.Value, xEC1q0.Value,
				iF1q0P1, iF1q0P1n, iF1q0P2, iF1q0P2n, iF1q0Txt, nF1q0, iD1q0P1, iD1q0P1n, iD1q0P2, iD1q0P2n, iD1q0Txt, nD1q0, iC1q0P1, iC1q0P1n, iC1q0P2, iC1q0P2n, iC1q0Txt, nC1q0);
			naoRec |= Alarmes(xAF1q2.Value, xEF1q2.Value, xAD1q2.Value, xED1q2.Value, xAC1q2.Value, xEC1q2.Value,
				iF1q2P1, iF1q2P1n, iF1q2P2, iF1q2P2n, iF1q2Txt, nF1q2, iD1q2P1, iD1q2P1n, iD1q2P2, iD1q2P2n, iD1q2Txt, nD1q2, iC1q2P1, iC1q2P1n, iC1q2P2, iC1q2P2n, iC1q2Txt, nC1q2);
			Pisca(naoRec);
		}

		void BtnCmdClick(object sender, EventArgs e)
		{
			string t;
			if (sender == btnAbrir1Q1) { pendente = 1; t = "ABRIR o 1Q1 (entrada da barra A)?\r\nA barra A fica sem alimentação, a não ser pelo 1Q0."; }
			else if (sender == btnFechar1Q1) { pendente = 2; t = "FECHAR o 1Q1 (entrada da barra A)?"; }
			else if (sender == btnAbrir1Q0) { pendente = 3; t = "ABRIR o 1Q0 (acoplamento das barras)?"; }
			else if (sender == btnFechar1Q0) { pendente = 4; t = "FECHAR o 1Q0 (acoplamento das barras)?\r\nUma QTAM passa a alimentar as duas barras."; }
			else if (sender == btnAbrir1Q2) { pendente = 5; t = "ABRIR o 1Q2 (entrada da barra B)?\r\nA barra B fica sem alimentação, a não ser pelo 1Q0."; }
			else { pendente = 6; t = "FECHAR o 1Q2 (entrada da barra B)?"; }
			confTexto.Text = t;
			Confirmacao(true);
		}
		void Confirmacao(bool v) { confFundo.Visible = v; confTexto.Visible = v; btnConfirmar.Visible = v; btnCancelar.Visible = v; }
		void BtnConfirmarClick(object sender, EventArgs e) { Confirmacao(false); if (pendente > 0) FireEvent_E_COMANDO(pendente); pendente = 0; }
		void BtnCancelarClick(object sender, EventArgs e) { Confirmacao(false); pendente = 0; }

	}
}
