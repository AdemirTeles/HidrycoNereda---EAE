/*
 * Hidryco - Prensa_Vibropac - fpDefault
 * Prensa desaguadora Vibropac C-Press (VSD-1200): estado, motores, modo, comando manual do ciclo e reset.
 */

using System;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Faceplates.Prensa_Vibropac
{
	public partial class fpDefault : NxtControl.GuiFramework.HMIFaceplate
	{
		public fpDefault()
		{
			InitializeComponent();
			hab = true;   // ate a logica responder, nao mostra "desabilitado"
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
		bool fCom, hab, auto, ciclo, cMan, aSkid, emg, fMot, disp, fun, vs1, fs1, zs1, zs2;
		byte eCom, eEmg, eSkd, eMot;
		short m1, m2, m3, m4, m5;
		float niv;
		void XFCOMValueChanged(object s, ValueChangedEventArgs e) { fCom = Convert.ToBoolean(e.Value); Atualiza(); }
		void XHABValueChanged(object s, ValueChangedEventArgs e) { hab = Convert.ToBoolean(e.Value); Atualiza(); }
		void XAUTOValueChanged(object s, ValueChangedEventArgs e) { auto = Convert.ToBoolean(e.Value); Atualiza(); }
		void XCICValueChanged(object s, ValueChangedEventArgs e) { ciclo = Convert.ToBoolean(e.Value); Atualiza(); }
		void XCMANValueChanged(object s, ValueChangedEventArgs e) { cMan = Convert.ToBoolean(e.Value); Atualiza(); }
		void XALSValueChanged(object s, ValueChangedEventArgs e) { aSkid = Convert.ToBoolean(e.Value); Atualiza(); }
		void XEMGValueChanged(object s, ValueChangedEventArgs e) { emg = Convert.ToBoolean(e.Value); Atualiza(); }
		void XFMOTValueChanged(object s, ValueChangedEventArgs e) { fMot = Convert.ToBoolean(e.Value); Atualiza(); }
		void XDISPValueChanged(object s, ValueChangedEventArgs e) { disp = Convert.ToBoolean(e.Value); Atualiza(); }
		void XECOMValueChanged(object s, ValueChangedEventArgs e) { eCom = Convert.ToByte(e.Value); Atualiza(); }
		void XEEMGValueChanged(object s, ValueChangedEventArgs e) { eEmg = Convert.ToByte(e.Value); Atualiza(); }
		void XESKDValueChanged(object s, ValueChangedEventArgs e) { eSkd = Convert.ToByte(e.Value); Atualiza(); }
		void XEMOTValueChanged(object s, ValueChangedEventArgs e) { eMot = Convert.ToByte(e.Value); Atualiza(); }
		void XM1ValueChanged(object s, ValueChangedEventArgs e) { m1 = Convert.ToInt16(e.Value); Atualiza(); }
		void XM2ValueChanged(object s, ValueChangedEventArgs e) { m2 = Convert.ToInt16(e.Value); Atualiza(); }
		void XM3ValueChanged(object s, ValueChangedEventArgs e) { m3 = Convert.ToInt16(e.Value); Atualiza(); }
		void XM4ValueChanged(object s, ValueChangedEventArgs e) { m4 = Convert.ToInt16(e.Value); Atualiza(); }
		void XM5ValueChanged(object s, ValueChangedEventArgs e) { m5 = Convert.ToInt16(e.Value); Atualiza(); }
		void XNIVValueChanged(object s, ValueChangedEventArgs e) { niv = Convert.ToSingle(e.Value); Atualiza(); }
		void XFUNValueChanged(object s, ValueChangedEventArgs e) { fun = Convert.ToBoolean(e.Value); Atualiza(); }
		void XVS1ValueChanged(object s, ValueChangedEventArgs e) { vs1 = Convert.ToBoolean(e.Value); Atualiza(); }
		void XFS1ValueChanged(object s, ValueChangedEventArgs e) { fs1 = Convert.ToBoolean(e.Value); Atualiza(); }
		void XZS1ValueChanged(object s, ValueChangedEventArgs e) { zs1 = Convert.ToBoolean(e.Value); Atualiza(); }
		void XZS2ValueChanged(object s, ValueChangedEventArgs e) { zs2 = Convert.ToBoolean(e.Value); Atualiza(); }

		int Prioridade(out string texto, out bool naoRec)
		{
			if (!hab) { texto = ""; naoRec = false; return 0; }
			if (fCom) { texto = "SEM COMUNICAÇÃO"; naoRec = NaoRec(eCom); return 2; }
			if (emg) { texto = "EMERGÊNCIA ACIONADA"; naoRec = NaoRec(eEmg); return 1; }
			if (fMot) { texto = "FALHA DE MOTOR"; naoRec = NaoRec(eMot); return 1; }
			if (aSkid) { texto = "ALARME NO SKID"; naoRec = NaoRec(eSkd); return 1; }
			texto = ""; naoRec = false; return 0;
		}
		bool AlgumNaoRec() { return hab && ((fCom && NaoRec(eCom)) || (emg && NaoRec(eEmg)) || (fMot && NaoRec(eMot)) || (aSkid && NaoRec(eSkd))); }
		static readonly string[] NOMES_M = { "Prensa M1", "Limpeza M2", "Agitador M3", "Bomba de água M4", "Compressor M5" };
		static string Mot(short v, bool reverso) { if (reverso) { switch (v) { case 0: return "parado"; case 1: return "avante"; case 2: return "reverso"; case 3: return "FALHA"; } } else { switch (v) { case 0: return "parado"; case 1: return "funcionando"; case 2: return "FALHA"; } } return "?"; }
		static string Nivel(short v) { switch (v) { case 0: return "muito baixo"; case 1: return "baixo"; case 2: return "alto"; case 3: return "muito alto"; } return "?"; }
		string Estado()
		{
			if (!hab) return "DESABILITADO (FUTURO)";
			if (fCom) return "SEM COMUNICAÇÃO";
			return (ciclo ? "CICLO LIGADO" : "ciclo desligado") + (auto ? "  (automático)" : "  (MANUAL)");
		}

		static readonly NxtControl.Drawing.Color corSel = new NxtControl.Drawing.Color(96, 96, 96);
		static readonly NxtControl.Drawing.Color corNor = new NxtControl.Drawing.Color(208, 208, 208);
		static readonly NxtControl.Drawing.Color branco = new NxtControl.Drawing.Color(255, 255, 255);
		static readonly NxtControl.Drawing.Color preto = new NxtControl.Drawing.Color(0, 0, 0);
		void Marca(DrawnButton b, bool sel) { b.BrushColor = sel ? corSel : corNor; b.TextColor = sel ? branco : preto; }
		void Atualiza()
		{
			string t; bool nr; int p = Prioridade(out t, out nr);
			Indicador(alP1, alP1n, alP2, alP2n, alTxt, p, t, nr);
			Pisca(AlgumNaoRec());
			e1.Text = Estado();
			e2.Text = !hab ? "" : fCom ? "????" : (fun ? "PRENSA FUNCIONANDO" : "prensa parada") + "   floculador " + niv.ToString("0") + " %";
			short[] m = { m1, m2, m3, m4, m5 };
			FreeText[] nm = { nm0, nm1, nm2, nm3, nm4 };
			FreeText[] vm = { vm0, vm1, vm2, vm3, vm4 };
			for (int i = 0; i < 5; i++) { nm[i].Text = NOMES_M[i]; vm[i].Text = fCom ? "????" : Mot(m[i], i == 1); }
			rDet.Text = fCom ? "" : "Floculador (LT1): " + niv.ToString("0.0") + " %";
			rDet2.Text = fCom ? "" : "Limpeza: VS1 " + (vs1 ? "aberta" : "fechada") + "  FS1 " + (fs1 ? "com fluxo" : "sem fluxo");
			rDet3.Text = fCom ? "" : "Fim de curso: frontal " + (zs1 ? "atuado" : "-") + "  traseiro " + (zs2 ? "atuado" : "-");
			Marca(btnAuto, auto); Marca(btnMan, !auto);
			Marca(btnLiga, !auto && cMan); Marca(btnDesl, !auto && !cMan);
			btnLiga.Enabled = !auto && hab; btnDesl.Enabled = !auto && hab;
		}

		void BtnAutoClick(object sender, EventArgs e) { FireEvent_E_MODO(true); }
		void BtnManClick(object sender, EventArgs e) { FireEvent_E_MODO(false); }
		void BtnLigaClick(object sender, EventArgs e) { FireEvent_E_CICLO_MANUAL(true); }
		void BtnDeslClick(object sender, EventArgs e) { FireEvent_E_CICLO_MANUAL(false); }
		void BtnResetClick(object sender, EventArgs e) { FireEvent_E_RESET(true); FireEvent_E_RESET(false); }

	}
}
