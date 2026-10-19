/*
 * Hidryco - Desinfeccao_UV - fpDefault
 * Desinfeccao: estado do controle, parametros do PID e dos alarmes, totalizador e reconhecimento.
 */

using System;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Faceplates.Desinfeccao_UV
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
		float vaz, vMax, sPid, vPos;
		bool ativo, ftF, remOk, aDj, aVa, aVr, fRem, dPce, dPcm, dUv1, dUv2, dVc, dMo, hab;
		short motivo;
		byte eVa, eVr, eDj, eRem;
		void XVAZValueChanged(object s, ValueChangedEventArgs e) { vaz = Convert.ToSingle(e.Value); Atualiza(); }
		void XVMAXValueChanged(object s, ValueChangedEventArgs e) { vMax = Convert.ToSingle(e.Value); Atualiza(); }
		void XATIVOValueChanged(object s, ValueChangedEventArgs e) { ativo = Convert.ToBoolean(e.Value); Atualiza(); }
		void XMOTValueChanged(object s, ValueChangedEventArgs e) { motivo = Convert.ToInt16(e.Value); Atualiza(); }
		void XSPIDValueChanged(object s, ValueChangedEventArgs e) { sPid = Convert.ToSingle(e.Value); Atualiza(); }
		void XVPOSValueChanged(object s, ValueChangedEventArgs e) { vPos = Convert.ToSingle(e.Value); Atualiza(); }
		void XFTFValueChanged(object s, ValueChangedEventArgs e) { ftF = Convert.ToBoolean(e.Value); Atualiza(); }
		void XREMValueChanged(object s, ValueChangedEventArgs e) { remOk = Convert.ToBoolean(e.Value); Atualiza(); }
		void XADJValueChanged(object s, ValueChangedEventArgs e) { aDj = Convert.ToBoolean(e.Value); Atualiza(); }
		void XAVAValueChanged(object s, ValueChangedEventArgs e) { aVa = Convert.ToBoolean(e.Value); Atualiza(); }
		void XAVRValueChanged(object s, ValueChangedEventArgs e) { aVr = Convert.ToBoolean(e.Value); Atualiza(); }
		void XFREMValueChanged(object s, ValueChangedEventArgs e) { fRem = Convert.ToBoolean(e.Value); Atualiza(); }
		void XDPCEValueChanged(object s, ValueChangedEventArgs e) { dPce = Convert.ToBoolean(e.Value); Atualiza(); }
		void XDPCMValueChanged(object s, ValueChangedEventArgs e) { dPcm = Convert.ToBoolean(e.Value); Atualiza(); }
		void XDUV1ValueChanged(object s, ValueChangedEventArgs e) { dUv1 = Convert.ToBoolean(e.Value); Atualiza(); }
		void XDUV2ValueChanged(object s, ValueChangedEventArgs e) { dUv2 = Convert.ToBoolean(e.Value); Atualiza(); }
		void XDVCValueChanged(object s, ValueChangedEventArgs e) { dVc = Convert.ToBoolean(e.Value); Atualiza(); }
		void XDMOValueChanged(object s, ValueChangedEventArgs e) { dMo = Convert.ToBoolean(e.Value); Atualiza(); }
		void XEVAValueChanged(object s, ValueChangedEventArgs e) { eVa = Convert.ToByte(e.Value); Atualiza(); }
		void XEVRValueChanged(object s, ValueChangedEventArgs e) { eVr = Convert.ToByte(e.Value); Atualiza(); }
		void XEDJValueChanged(object s, ValueChangedEventArgs e) { eDj = Convert.ToByte(e.Value); Atualiza(); }
		void XEREMValueChanged(object s, ValueChangedEventArgs e) { eRem = Convert.ToByte(e.Value); Atualiza(); }
		void XHABValueChanged(object s, ValueChangedEventArgs e) { hab = Convert.ToBoolean(e.Value); Atualiza(); }

		int Prioridade(out string texto, out bool naoRec)
		{
			if (aVa) { texto = "VAZÃO DE LANÇAMENTO ACIMA DO LIMITE"; naoRec = NaoRec(eVa); return 1; }
			if (ftF) { texto = "700-FT-01 EM FALHA - VÁLVULA MANTIDA"; naoRec = false; return 1; }
			if (fRem) { texto = "SEM COMUNICAÇÃO COM A REMOTA"; naoRec = NaoRec(eRem); return 2; }
			if (aDj) { texto = "DISJUNTOR DESLIGADO"; naoRec = NaoRec(eDj); return 2; }
			if (aVr) { texto = "VARIAÇÃO BRUSCA DA VAZÃO"; naoRec = NaoRec(eVr); return 2; }
			texto = ""; naoRec = false; return 0;
		}
		bool AlgumNaoRec() { return (aVa && NaoRec(eVa)) || (fRem && NaoRec(eRem)) || (aDj && NaoRec(eDj)) || (aVr && NaoRec(eVr)); }
		static readonly string[] MOTIVO = { "PID CONTROLANDO A VC-01", "controle desabilitado - válvula mantida", "FT-01 em falha - válvula mantida", "VC-01 indisponível (manual, local, falha ou sem comunicação)", "retomando o controle..." };
		string Motivo() { return motivo >= 0 && motivo < MOTIVO.Length ? MOTIVO[motivo] : "-"; }
		string Dj() { if (!remOk) return "????"; return "PCE " + (dPce ? "DESL" : "ok") + "  PCM " + (dPcm ? "DESL" : "ok") + "  UV1 " + (dUv1 ? "lig" : "DESL") + "  UV2 " + (dUv2 ? "lig" : "DESL") + "  VC " + (dVc ? "lig" : "DESL") + "  MO " + (dMo ? "lig" : "desl"); }
		int tot;
		void XTOTValueChanged(object s, ValueChangedEventArgs e) { tot = Convert.ToInt32(e.Value); Atualiza(); }

		void Atualiza()
		{
			string t; bool nr; int p = Prioridade(out t, out nr);
			Indicador(alP1, alP1n, alP2, alP2n, alTxt, p, t, nr);
			Pisca(AlgumNaoRec());
			e1.Text = "Vazão: " + (ftF ? "????" : vaz.ToString("0") + " m³/h") + "   VC-01: " + vPos.ToString("0.0") + " %";
			e2.Text = Motivo();
			btnHab.BrushColor = hab ? new NxtControl.Drawing.Color(96, 96, 96) : new NxtControl.Drawing.Color(208, 208, 208);
			btnDesab.BrushColor = !hab ? new NxtControl.Drawing.Color(96, 96, 96) : new NxtControl.Drawing.Color(208, 208, 208);
			btnHab.TextColor = hab ? new NxtControl.Drawing.Color(255, 255, 255) : new NxtControl.Drawing.Color(0, 0, 0);
			btnDesab.TextColor = !hab ? new NxtControl.Drawing.Color(255, 255, 255) : new NxtControl.Drawing.Color(0, 0, 0);
			rTot.Text = "Total lançado: " + tot.ToString() + " m³";
		}

		void BtnHabClick(object sender, EventArgs e) { FireEvent_E_PARAMETROS(true, false, 0F, true, 0F, true, 0F, true, 0F, true, 0F, true, 0F, true, 0F, true, (short)0, true, 0F, true); }
		void BtnDesabClick(object sender, EventArgs e) { FireEvent_E_PARAMETROS(false, false, 0F, true, 0F, true, 0F, true, 0F, true, 0F, true, 0F, true, 0F, true, (short)0, true, 0F, true); }
		void BtnZeraClick(object sender, EventArgs e) { FireEvent_E_ZERA_TOTAL(true); FireEvent_E_ZERA_TOTAL(false); }
		void BtnResetClick(object sender, EventArgs e) { FireEvent_E_RESET(true); FireEvent_E_RESET(false); }

	}
}
