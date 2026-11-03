/*
 * Hidryco - Fase_Solida - fpDefault
 * Fase solida: liga/desliga o desaguamento por prensa, estado da alimentacao, solenoides manuais e reconhecimento.
 */

using System;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Faceplates.Fase_Solida
{
	public partial class fpDefault : NxtControl.GuiFramework.HMIFaceplate
	{
		public fpDefault()
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

		// ---- dados recebidos da logica (Execute invisiveis)
		short e1, e2, e3, m1, m2, m3, b1, b2, b3, soA, svM;
		float nTq;
		bool nBx, sNv, sSo, emg, fRem, aDj, sBo, fRot, sPt, ftF, cPp;
		byte eSo, eNt, eEm, eRe, eDj, eRo, eSb, eSp, eFt;
		void XE1ValueChanged(object s, ValueChangedEventArgs e) { e1 = Convert.ToInt16(e.Value); Atualiza(); }
		void XE2ValueChanged(object s, ValueChangedEventArgs e) { e2 = Convert.ToInt16(e.Value); Atualiza(); }
		void XE3ValueChanged(object s, ValueChangedEventArgs e) { e3 = Convert.ToInt16(e.Value); Atualiza(); }
		void XM1ValueChanged(object s, ValueChangedEventArgs e) { m1 = Convert.ToInt16(e.Value); Atualiza(); }
		void XM2ValueChanged(object s, ValueChangedEventArgs e) { m2 = Convert.ToInt16(e.Value); Atualiza(); }
		void XM3ValueChanged(object s, ValueChangedEventArgs e) { m3 = Convert.ToInt16(e.Value); Atualiza(); }
		void XB1ValueChanged(object s, ValueChangedEventArgs e) { b1 = Convert.ToInt16(e.Value); Atualiza(); }
		void XB2ValueChanged(object s, ValueChangedEventArgs e) { b2 = Convert.ToInt16(e.Value); Atualiza(); }
		void XB3ValueChanged(object s, ValueChangedEventArgs e) { b3 = Convert.ToInt16(e.Value); Atualiza(); }
		void XSOAValueChanged(object s, ValueChangedEventArgs e) { soA = Convert.ToInt16(e.Value); Atualiza(); }
		void XNTQValueChanged(object s, ValueChangedEventArgs e) { nTq = Convert.ToSingle(e.Value); Atualiza(); }
		void XNBXValueChanged(object s, ValueChangedEventArgs e) { nBx = Convert.ToBoolean(e.Value); Atualiza(); }
		void XSNVValueChanged(object s, ValueChangedEventArgs e) { sNv = Convert.ToBoolean(e.Value); Atualiza(); }
		void XSSOValueChanged(object s, ValueChangedEventArgs e) { sSo = Convert.ToBoolean(e.Value); Atualiza(); }
		void XEMGValueChanged(object s, ValueChangedEventArgs e) { emg = Convert.ToBoolean(e.Value); Atualiza(); }
		void XFREMValueChanged(object s, ValueChangedEventArgs e) { fRem = Convert.ToBoolean(e.Value); Atualiza(); }
		void XADJValueChanged(object s, ValueChangedEventArgs e) { aDj = Convert.ToBoolean(e.Value); Atualiza(); }
		void XSBOValueChanged(object s, ValueChangedEventArgs e) { sBo = Convert.ToBoolean(e.Value); Atualiza(); }
		void XFROTValueChanged(object s, ValueChangedEventArgs e) { fRot = Convert.ToBoolean(e.Value); Atualiza(); }
		void XSPTValueChanged(object s, ValueChangedEventArgs e) { sPt = Convert.ToBoolean(e.Value); Atualiza(); }
		void XFTFValueChanged(object s, ValueChangedEventArgs e) { ftF = Convert.ToBoolean(e.Value); Atualiza(); }
		void XCPPValueChanged(object s, ValueChangedEventArgs e) { cPp = Convert.ToBoolean(e.Value); Atualiza(); }
		void XESOValueChanged(object s, ValueChangedEventArgs e) { eSo = Convert.ToByte(e.Value); Atualiza(); }
		void XENTValueChanged(object s, ValueChangedEventArgs e) { eNt = Convert.ToByte(e.Value); Atualiza(); }
		void XEEMValueChanged(object s, ValueChangedEventArgs e) { eEm = Convert.ToByte(e.Value); Atualiza(); }
		void XEREValueChanged(object s, ValueChangedEventArgs e) { eRe = Convert.ToByte(e.Value); Atualiza(); }
		void XEDJValueChanged(object s, ValueChangedEventArgs e) { eDj = Convert.ToByte(e.Value); Atualiza(); }
		void XEROValueChanged(object s, ValueChangedEventArgs e) { eRo = Convert.ToByte(e.Value); Atualiza(); }
		void XESBValueChanged(object s, ValueChangedEventArgs e) { eSb = Convert.ToByte(e.Value); Atualiza(); }
		void XESPValueChanged(object s, ValueChangedEventArgs e) { eSp = Convert.ToByte(e.Value); Atualiza(); }
		void XEFTValueChanged(object s, ValueChangedEventArgs e) { eFt = Convert.ToByte(e.Value); Atualiza(); }
		void XSVValueChanged(object s, ValueChangedEventArgs e) { svM = Convert.ToInt16(e.Value); Atualiza(); }

		int Prioridade(out string texto, out bool naoRec)
		{
			if (emg) { texto = "EMERGÊNCIA DO PCM LODO"; naoRec = NaoRec(eEm); return 1; }
			if (sSo) { texto = "NENHUM SOPRADOR DISPONÍVEL"; naoRec = NaoRec(eSo); return 1; }
			if (fRot) { texto = "VÁLVULAS DA ROTA NÃO ABRIRAM"; naoRec = NaoRec(eRo); return 1; }
			if (fRem) { texto = "REMOTA DO PCE LODO SEM COMUNICAÇÃO"; naoRec = NaoRec(eRe); return 2; }
			if (nBx) { texto = sNv ? "SEM MEDIÇÃO DE NÍVEL DOS TANQUES" : "TANQUES EM NÍVEL BAIXO"; naoRec = NaoRec(eNt); return 2; }
			if (sBo) { texto = "PRENSA SEM BOMBA DISPONÍVEL"; naoRec = NaoRec(eSb); return 2; }
			if (ftF) { texto = "MEDIDOR DE VAZÃO EM FALHA"; naoRec = NaoRec(eFt); return 2; }
			if (sPt) { texto = "PRENSA NÃO PARTIU"; naoRec = NaoRec(eSp); return 2; }
			if (aDj) { texto = "DISJUNTOR DESLIGADO"; naoRec = NaoRec(eDj); return 2; }
			texto = ""; naoRec = false; return 0;
		}
		bool AlgumNaoRec() { return (emg && NaoRec(eEm)) || (sSo && NaoRec(eSo)) || (fRot && NaoRec(eRo)) || (fRem && NaoRec(eRe)) || (nBx && NaoRec(eNt))
			|| (sBo && NaoRec(eSb)) || (ftF && NaoRec(eFt)) || (sPt && NaoRec(eSp)) || (aDj && NaoRec(eDj)); }
		static readonly string[] EST = { "parada", "abrindo válvulas", "partindo bomba", "ALIMENTANDO", "suspensa", "parando" };
		static readonly string[] MOT = { "", " - prensa indisponível", " - setpoint de vazão zero", " - sem bomba ou rota disponível", " - houve falha de rota (válvula bloqueada até o reset)",
			" - emergência", " - floculador cheio", " - tanque de lodo baixo", " - FT em falha (velocidade mantida)", " - prensa não partiu" };
		static string Prensa(short e, short m, short b)
		{
			string s = (e >= 0 && e < EST.Length) ? EST[e] : "?";
			if (b > 0) s += " (BO-0" + b.ToString() + ")";
			return s + ((m >= 0 && m < MOT.Length) ? MOT[m] : "");
		}

		static readonly NxtControl.Drawing.Color corSel = new NxtControl.Drawing.Color(96, 96, 96);
		static readonly NxtControl.Drawing.Color corNor = new NxtControl.Drawing.Color(208, 208, 208);
		static readonly NxtControl.Drawing.Color branco = new NxtControl.Drawing.Color(255, 255, 255);
		static readonly NxtControl.Drawing.Color preto = new NxtControl.Drawing.Color(0, 0, 0);
		void Marca(DrawnButton b, bool sel) { b.BrushColor = sel ? corSel : corNor; b.TextColor = sel ? branco : preto; }
		void XCValueChanged(object s, ValueChangedEventArgs e) { Atualiza(); }
		bool C(System.HMI.Symbols.Base.Execute<bool> x) { return x.Value != null && Convert.ToBoolean(x.Value); }
		void Atualiza()
		{
			string t; bool nr; int p = Prioridade(out t, out nr);
			Indicador(alP1, alP1n, alP2, alP2n, alTxt, p, t, nr);
			Pisca(AlgumNaoRec());
			eAD1.Text = Prensa(e1, m1, b1); eAD2.Text = Prensa(e2, m2, b2); eAD3.Text = Prensa(e3, m3, b3);
			bool c1 = C(xC1), c2 = C(xC2), c3 = C(xC3);
			Marca(btnLiga1, c1); Marca(btnDesl1, !c1); Marca(btnLiga2, c2); Marca(btnDesl2, !c2); Marca(btnLiga3, c3); Marca(btnDesl3, !c3);
			DrawnButton[] sv = { btnSv01, btnSv02, btnSv03, btnSv04, btnSv06, btnSv08 };
			for (int i = 0; i < 6; i++) Marca(sv[i], (svM & (1 << i)) != 0);
		}
		void Cmd(bool a1, bool i1, bool a2, bool i2, bool a3, bool i3) { FireEvent_E_COMANDO(a1, i1, a2, i2, a3, i3); }
		void BtnLiga1Click(object sender, EventArgs e) { Cmd(true, false, false, true, false, true); }
		void BtnDesl1Click(object sender, EventArgs e) { Cmd(false, false, false, true, false, true); }
		void BtnLiga2Click(object sender, EventArgs e) { Cmd(false, true, true, false, false, true); }
		void BtnDesl2Click(object sender, EventArgs e) { Cmd(false, true, false, false, false, true); }
		void BtnLiga3Click(object sender, EventArgs e) { Cmd(false, true, false, true, true, false); }
		void BtnDesl3Click(object sender, EventArgs e) { Cmd(false, true, false, true, false, false); }
		void BtnSvClick(object sender, EventArgs e)
		{
			DrawnButton[] sv = { btnSv01, btnSv02, btnSv03, btnSv04, btnSv06, btnSv08 };
			int m = svM;
			for (int i = 0; i < 6; i++) if (sender == sv[i]) m ^= (1 << i);
			FireEvent_E_SV((m & 1) != 0, (m & 2) != 0, (m & 4) != 0, (m & 8) != 0, (m & 16) != 0, (m & 32) != 0);
		}
		void BtnResetClick(object sender, EventArgs e) { FireEvent_E_RESET(true); FireEvent_E_RESET(false); }

	}
}
