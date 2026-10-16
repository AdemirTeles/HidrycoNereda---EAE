/*
 * Hidryco - UCT_PreTratamento - sSkid
 * Desenho do skid da UCT (arranjo do Pre_Tratamento antigo) com os simbolos dos equipamentos, subsistemas, niveis, bomba de gordura e valvula de lavagem.
 */

using System;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Symbols.UCT_PreTratamento
{
	public partial class sSkid : NxtControl.GuiFramework.HMISymbol
	{
		public sSkid()
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

		bool aCOM;
		void V_aCOMChanged(object s, ValueChangedEventArgs e) { aCOM = Convert.ToBoolean(e.Value); Atualiza(); }
		bool aEMERGENCIA;
		void V_aEMERGENCIAChanged(object s, ValueChangedEventArgs e) { aEMERGENCIA = Convert.ToBoolean(e.Value); Atualiza(); }
		bool aDEFPEN;
		void V_aDEFPENChanged(object s, ValueChangedEventArgs e) { aDEFPEN = Convert.ToBoolean(e.Value); Atualiza(); }
		bool aDEFB1;
		void V_aDEFB1Changed(object s, ValueChangedEventArgs e) { aDEFB1 = Convert.ToBoolean(e.Value); Atualiza(); }
		bool aDEFB2;
		void V_aDEFB2Changed(object s, ValueChangedEventArgs e) { aDEFB2 = Convert.ToBoolean(e.Value); Atualiza(); }
		bool aDEFCMP;
		void V_aDEFCMPChanged(object s, ValueChangedEventArgs e) { aDEFCMP = Convert.ToBoolean(e.Value); Atualiza(); }
		bool aDEFRSP;
		void V_aDEFRSPChanged(object s, ValueChangedEventArgs e) { aDEFRSP = Convert.ToBoolean(e.Value); Atualiza(); }
		bool aDEFR1;
		void V_aDEFR1Changed(object s, ValueChangedEventArgs e) { aDEFR1 = Convert.ToBoolean(e.Value); Atualiza(); }
		bool aDEFR2;
		void V_aDEFR2Changed(object s, ValueChangedEventArgs e) { aDEFR2 = Convert.ToBoolean(e.Value); Atualiza(); }
		bool aNIVELAGUA;
		void V_aNIVELAGUAChanged(object s, ValueChangedEventArgs e) { aNIVELAGUA = Convert.ToBoolean(e.Value); Atualiza(); }
		bool aNIVELPENEIRA;
		void V_aNIVELPENEIRAChanged(object s, ValueChangedEventArgs e) { aNIVELPENEIRA = Convert.ToBoolean(e.Value); Atualiza(); }
		byte eCOM;
		void V_eCOMChanged(object s, ValueChangedEventArgs e) { eCOM = Convert.ToByte(e.Value); Atualiza(); }
		byte eEMERGENCIA;
		void V_eEMERGENCIAChanged(object s, ValueChangedEventArgs e) { eEMERGENCIA = Convert.ToByte(e.Value); Atualiza(); }
		byte eDEFPEN;
		void V_eDEFPENChanged(object s, ValueChangedEventArgs e) { eDEFPEN = Convert.ToByte(e.Value); Atualiza(); }
		byte eDEFB1;
		void V_eDEFB1Changed(object s, ValueChangedEventArgs e) { eDEFB1 = Convert.ToByte(e.Value); Atualiza(); }
		byte eDEFB2;
		void V_eDEFB2Changed(object s, ValueChangedEventArgs e) { eDEFB2 = Convert.ToByte(e.Value); Atualiza(); }
		byte eDEFCMP;
		void V_eDEFCMPChanged(object s, ValueChangedEventArgs e) { eDEFCMP = Convert.ToByte(e.Value); Atualiza(); }
		byte eDEFRSP;
		void V_eDEFRSPChanged(object s, ValueChangedEventArgs e) { eDEFRSP = Convert.ToByte(e.Value); Atualiza(); }
		byte eDEFR1;
		void V_eDEFR1Changed(object s, ValueChangedEventArgs e) { eDEFR1 = Convert.ToByte(e.Value); Atualiza(); }
		byte eDEFR2;
		void V_eDEFR2Changed(object s, ValueChangedEventArgs e) { eDEFR2 = Convert.ToByte(e.Value); Atualiza(); }
		byte eNIVELAGUA;
		void V_eNIVELAGUAChanged(object s, ValueChangedEventArgs e) { eNIVELAGUA = Convert.ToByte(e.Value); Atualiza(); }
		byte eNIVELPENEIRA;
		void V_eNIVELPENEIRAChanged(object s, ValueChangedEventArgs e) { eNIVELPENEIRA = Convert.ToByte(e.Value); Atualiza(); }
		bool disp;
		void V_dispChanged(object s, ValueChangedEventArgs e) { disp = Convert.ToBoolean(e.Value); Atualiza(); }
		bool hab;
		void V_habChanged(object s, ValueChangedEventArgs e) { hab = Convert.ToBoolean(e.Value); Atualiza(); }
		bool bloq;
		void V_bloqChanged(object s, ValueChangedEventArgs e) { bloq = Convert.ToBoolean(e.Value); Atualiza(); }
		bool autoPen;
		void V_autoPenChanged(object s, ValueChangedEventArgs e) { autoPen = Convert.ToBoolean(e.Value); Atualiza(); }
		bool autoRos;
		void V_autoRosChanged(object s, ValueChangedEventArgs e) { autoRos = Convert.ToBoolean(e.Value); Atualiza(); }
		bool autoRc;
		void V_autoRcChanged(object s, ValueChangedEventArgs e) { autoRc = Convert.ToBoolean(e.Value); Atualiza(); }
		bool ligPen;
		void V_ligPenChanged(object s, ValueChangedEventArgs e) { ligPen = Convert.ToBoolean(e.Value); Atualiza(); }
		bool ligRos;
		void V_ligRosChanged(object s, ValueChangedEventArgs e) { ligRos = Convert.ToBoolean(e.Value); Atualiza(); }
		bool ligRc;
		void V_ligRcChanged(object s, ValueChangedEventArgs e) { ligRc = Convert.ToBoolean(e.Value); Atualiza(); }
		bool selB2;
		void V_selB2Changed(object s, ValueChangedEventArgs e) { selB2 = Convert.ToBoolean(e.Value); Atualiza(); }
		bool valv;
		void V_valvChanged(object s, ValueChangedEventArgs e) { valv = Convert.ToBoolean(e.Value); Atualiza(); }
		short etapa;
		void V_etapaChanged(object s, ValueChangedEventArgs e) { etapa = Convert.ToInt16(e.Value); Atualiza(); }
		bool nAltoG;
		void V_nAltoGChanged(object s, ValueChangedEventArgs e) { nAltoG = Convert.ToBoolean(e.Value); Atualiza(); }

		static void Selecao(DrawnButton b, bool sel)
		{
			b.BrushColor = sel ? new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60))) : new NxtControl.Drawing.Color(((byte)(215)), ((byte)(215)), ((byte)(215)));
			b.TextColor = sel ? new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255))) : new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			b.TextColorMouseDown = b.TextColor;
		}
		static string TextoEstado(short a)
		{
			switch (a) { case 1: return "LIGADO"; case 2: return "FALHA"; case 3: return "MANUTENÇÃO"; case 4: return "SEM COMUNICAÇÃO"; default: return "DESLIGADO"; }
		}

		// Alarme de maior prioridade (classe Alarm = 1, Warning = 2), na ordem da lista
		int Prioridade(out string texto, out bool naoRec)
		{
			if (aCOM) { texto = "SEM COMUNICAÇÃO"; naoRec = NaoRec(eCOM); return 1; }
			if (aEMERGENCIA) { texto = "EMERGÊNCIA"; naoRec = NaoRec(eEMERGENCIA); return 1; }
			if (aDEFPEN) { texto = "DEFEITO PENEIRA"; naoRec = NaoRec(eDEFPEN); return 1; }
			if (aDEFB1) { texto = "DEFEITO BOMBA 1"; naoRec = NaoRec(eDEFB1); return 1; }
			if (aDEFB2) { texto = "DEFEITO BOMBA 2"; naoRec = NaoRec(eDEFB2); return 1; }
			if (aDEFCMP) { texto = "DEFEITO COMPRESSOR"; naoRec = NaoRec(eDEFCMP); return 1; }
			if (aDEFRSP) { texto = "DEFEITO RASPADOR"; naoRec = NaoRec(eDEFRSP); return 1; }
			if (aDEFR1) { texto = "DEFEITO ROSCA 1"; naoRec = NaoRec(eDEFR1); return 1; }
			if (aDEFR2) { texto = "DEFEITO ROSCA 2"; naoRec = NaoRec(eDEFR2); return 1; }
			if (aNIVELAGUA) { texto = "NÍVEL BAIXO ÁGUA"; naoRec = NaoRec(eNIVELAGUA); return 2; }
			if (aNIVELPENEIRA) { texto = "NÍVEL ALTO PENEIRA"; naoRec = NaoRec(eNIVELPENEIRA); return 2; }
			texto = ""; naoRec = false; return 0;
		}
		bool AlgumNaoRec() { return NaoRec(eCOM) || NaoRec(eEMERGENCIA) || NaoRec(eDEFPEN) || NaoRec(eDEFB1) || NaoRec(eDEFB2) || NaoRec(eDEFCMP) || NaoRec(eDEFRSP) || NaoRec(eDEFR1) || NaoRec(eDEFR2) || NaoRec(eNIVELAGUA) || NaoRec(eNIVELPENEIRA); }
		string TextoUCT()
		{
			if (!hab) return "FORA DE OPERAÇÃO";
			if (aCOM) return "SEM COMUNICAÇÃO";
			return disp ? "DISPONÍVEL" : "INDISPONÍVEL";
		}
		static string TextoEtapa(short e)
		{
			switch (e) { case 1: return "pré-lavagem"; case 2: return "bombeando"; case 3: return "nível normal - desligando"; case 4: return "fora do automático"; default: return "parada"; }
		}


		// cores do padrao da HidrycoLib (Graphics.Bomba/Motor): 0 desligado, 1 ligado, 2 falha, 3 manutencao, outro = desconhecido
		static NxtControl.Drawing.Color Cor(int a)
		{
			switch (a)
			{
				case 0: return Hidryco.HidrycoLib.SupportClasses.HidrycoColors.Desligado;
				case 1: return Hidryco.HidrycoLib.SupportClasses.HidrycoColors.Ligado;
				case 2: return Hidryco.HidrycoLib.SupportClasses.HidrycoColors.Falha;
				case 3: return Hidryco.HidrycoLib.SupportClasses.HidrycoColors.Manutencao;
				default: return Hidryco.HidrycoLib.SupportClasses.HidrycoColors.Unknown;
			}
		}


		void Atualiza()
		{
			string t; bool nr; int p = Prioridade(out t, out nr);
			Indicador(alP1, alP1n, alP2, alP2n, alTxt, p, t, nr);
			Pisca(AlgumNaoRec());
			textoEstado.Text = TextoUCT();
			textoBloq.Visible = bloq;
			Selecao(btnAutoPen, autoPen); Selecao(btnManPen, !autoPen); Selecao(btnLigPen, ligPen); Selecao(btnDesPen, !ligPen);
			Selecao(btnAutoRos, autoRos); Selecao(btnManRos, !autoRos); Selecao(btnLigRos, ligRos); Selecao(btnDesRos, !ligRos);
			Selecao(btnAutoRc, autoRc); Selecao(btnManRc, !autoRc); Selecao(btnLigRc, ligRc); Selecao(btnDesRc, !ligRc);
			Selecao(btnB2, selB2); Selecao(btnB1, !selB2);
			// valvula de lavagem nas cores da HidrycoLib: aberta = ligado, fechada = desligado
			NxtControl.Drawing.Color c = Cor(aCOM ? 4 : (valv ? 1 : 0));
			vl1.BrushColor = c; vl2.BrushColor = c;
			textoValv.Text = valv ? "aberta" : "fechada";
			textoEtapa.Text = "Bomba de gordura: " + TextoEtapa(etapa);
			vRest.Visible = etapa == 1 || etapa == 3;
		}
		void BtnManPenClick(object sender, EventArgs e) { FireEvent_E_SELECAO_SUBSISTEMA_PENEIRA(false); }
		void BtnAutoPenClick(object sender, EventArgs e) { FireEvent_E_SELECAO_SUBSISTEMA_PENEIRA(true); }
		void BtnDesPenClick(object sender, EventArgs e) { FireEvent_E_LIGA_SUBSISTEMA_PENEIRA(false); }
		void BtnLigPenClick(object sender, EventArgs e) { FireEvent_E_LIGA_SUBSISTEMA_PENEIRA(true); }
		void BtnManRosClick(object sender, EventArgs e) { FireEvent_E_SELECAO_SUBSISTEMA_ROSCAS(false); }
		void BtnAutoRosClick(object sender, EventArgs e) { FireEvent_E_SELECAO_SUBSISTEMA_ROSCAS(true); }
		void BtnDesRosClick(object sender, EventArgs e) { FireEvent_E_LIGA_SUBSISTEMA_ROSCAS(false); }
		void BtnLigRosClick(object sender, EventArgs e) { FireEvent_E_LIGA_SUBSISTEMA_ROSCAS(true); }
		void BtnManRcClick(object sender, EventArgs e) { FireEvent_E_SELECAO_SUBSISTEMA_RASPCOMP(false); }
		void BtnAutoRcClick(object sender, EventArgs e) { FireEvent_E_SELECAO_SUBSISTEMA_RASPCOMP(true); }
		void BtnDesRcClick(object sender, EventArgs e) { FireEvent_E_LIGA_SUBSISTEMA_RASPCOMP(false); }
		void BtnLigRcClick(object sender, EventArgs e) { FireEvent_E_LIGA_SUBSISTEMA_RASPCOMP(true); }
		void BtnB1Click(object sender, EventArgs e) { FireEvent_E_SELECAO_BOMBA_HIGIENIZACAO(false); }
		void BtnB2Click(object sender, EventArgs e) { FireEvent_E_SELECAO_BOMBA_HIGIENIZACAO(true); }
		void BtnResetClick(object sender, EventArgs e) { FireEvent_E_RESET_FALHA(true); FireEvent_E_RESET_FALHA(false); }

	}
}
