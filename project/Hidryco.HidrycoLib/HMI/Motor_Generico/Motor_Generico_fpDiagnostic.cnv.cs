/*
 * Hidryco - Motor_Generico - fpDiagnostic
 * ISA-101: estados em texto (sim/nao) e falhas com indicador de prioridade 1; linhas que nao se aplicam ao motor somem.
 */

using System;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Faceplates.Motor_Generico
{
	public partial class fpDiagnostic : NxtControl.GuiFramework.HMIFaceplate
	{
		public fpDiagnostic()
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

		// ---- estado recebido da logica (Execute invisiveis)
		bool ligado, automatico, cmdManual, remoto, local, manutencao, disponivel, bloqueado, bloqGerador, inversor = false;
		bool fEmerg, fTerm, fInv, fPart, fPara, fCom;
		short animGerador;
		float velocidade, referencia;

		void LigadoValueChanged(object s, ValueChangedEventArgs e) { ligado = Convert.ToBoolean(e.Value); Atualiza(); }
		void AutomaticoValueChanged(object s, ValueChangedEventArgs e) { automatico = Convert.ToBoolean(e.Value); Atualiza(); }
		void CmdManualValueChanged(object s, ValueChangedEventArgs e) { cmdManual = Convert.ToBoolean(e.Value); Atualiza(); }
		void RemotoValueChanged(object s, ValueChangedEventArgs e) { remoto = Convert.ToBoolean(e.Value); Atualiza(); }
		void LocalValueChanged(object s, ValueChangedEventArgs e) { local = Convert.ToBoolean(e.Value); Atualiza(); }
		void ManutencaoValueChanged(object s, ValueChangedEventArgs e) { manutencao = Convert.ToBoolean(e.Value); Atualiza(); }
		void DisponivelValueChanged(object s, ValueChangedEventArgs e) { disponivel = Convert.ToBoolean(e.Value); Atualiza(); }
		void BloqueadoValueChanged(object s, ValueChangedEventArgs e) { bloqueado = Convert.ToBoolean(e.Value); Atualiza(); }
		void BloqGeradorValueChanged(object s, ValueChangedEventArgs e) { bloqGerador = Convert.ToBoolean(e.Value); Atualiza(); }
		void InversorValueChanged(object s, ValueChangedEventArgs e) { inversor = Convert.ToBoolean(e.Value); Atualiza(); }
		void EmergValueChanged(object s, ValueChangedEventArgs e) { fEmerg = Convert.ToBoolean(e.Value); Atualiza(); }
		void TermValueChanged(object s, ValueChangedEventArgs e) { fTerm = Convert.ToBoolean(e.Value); Atualiza(); }
		void InvValueChanged(object s, ValueChangedEventArgs e) { fInv = Convert.ToBoolean(e.Value); Atualiza(); }
		void PartValueChanged(object s, ValueChangedEventArgs e) { fPart = Convert.ToBoolean(e.Value); Atualiza(); }
		void ParaValueChanged(object s, ValueChangedEventArgs e) { fPara = Convert.ToBoolean(e.Value); Atualiza(); }
		void ComValueChanged(object s, ValueChangedEventArgs e) { fCom = Convert.ToBoolean(e.Value); Atualiza(); }
		// estado de reconhecimento de cada alarme (STATE_1 do ALARM_BIT)
		byte eEmerg, eTerm, eInv, ePart, ePara, eCom;
		void EEmergValueChanged(object s, ValueChangedEventArgs e) { eEmerg = Convert.ToByte(e.Value); Atualiza(); }
		void ETermValueChanged(object s, ValueChangedEventArgs e) { eTerm = Convert.ToByte(e.Value); Atualiza(); }
		void EInvValueChanged(object s, ValueChangedEventArgs e) { eInv = Convert.ToByte(e.Value); Atualiza(); }
		void EPartValueChanged(object s, ValueChangedEventArgs e) { ePart = Convert.ToByte(e.Value); Atualiza(); }
		void EParaValueChanged(object s, ValueChangedEventArgs e) { ePara = Convert.ToByte(e.Value); Atualiza(); }
		void EComValueChanged(object s, ValueChangedEventArgs e) { eCom = Convert.ToByte(e.Value); Atualiza(); }
		bool AlgumNaoRec() { return NaoRec(eEmerg) || NaoRec(eTerm) || NaoRec(eInv) || NaoRec(ePart) || NaoRec(ePara) || NaoRec(eCom); }
		void AnimGeradorValueChanged(object s, ValueChangedEventArgs e) { animGerador = Convert.ToInt16(e.Value); Atualiza(); }
		void VelocidadeValueChanged(object s, ValueChangedEventArgs e) { velocidade = Convert.ToSingle(e.Value); Atualiza(); }
		void ReferenciaValueChanged(object s, ValueChangedEventArgs e) { referencia = Convert.ToSingle(e.Value); Atualiza(); }

		// Falha de maior relevancia. Prioridade 1 (classe Alarm): emergencia, termica, acionamento, partida, parada.
		// Prioridade 2 (classe Warning): falha de comunicacao. naoRec = ainda nao reconhecida (a forma pisca).
		string FalhaAtiva(out int prioridade, out bool naoRec)
		{
			prioridade = 1;
			if (fEmerg) { naoRec = NaoRec(eEmerg); return "EMERGÊNCIA"; }
			if (fTerm) { naoRec = NaoRec(eTerm); return "TÉRMICA"; }
			if (fInv) { naoRec = NaoRec(eInv); return inversor ? "FALHA INVERSOR" : "FALHA ACIONAMENTO"; }
			if (fPart) { naoRec = NaoRec(ePart); return "FALHA DE PARTIDA"; }
			if (fPara) { naoRec = NaoRec(ePara); return "FALHA DE PARADA"; }
			prioridade = 2;
			if (fCom) { naoRec = NaoRec(eCom); return "FALHA COMUNICAÇÃO"; }
			prioridade = 0; naoRec = false;
			return "";
		}

		// Botao que mostra o proprio valor (ISA-101): ativo = cinza escuro com texto branco; inativo = cinza claro com texto preto.
		// Os botoes ficam sempre habilitados (desabilitado o EAE desbota o botao e a cor deixa de indicar o estado);
		// o clique e que e ignorado quando o comando nao se aplica (mesmo cuidado do fpSemPosicionar do Atuador_Coester_CSR6T).
		static void Selecao(DrawnButton b, bool sel)
		{
			b.BrushColor = sel ? new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60))) : new NxtControl.Drawing.Color(((byte)(215)), ((byte)(215)), ((byte)(215)));
			b.TextColor = sel ? new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255))) : new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			b.TextColorMouseDown = b.TextColor;
		}


		bool usaTermica, usaCom;
		void UsaTermicaValueChanged(object s, ValueChangedEventArgs e) { usaTermica = Convert.ToBoolean(e.Value); Atualiza(); }
		void UsaComValueChanged(object s, ValueChangedEventArgs e) { usaCom = Convert.ToBoolean(e.Value); Atualiza(); }

		// Linha de falha: some se nao se aplica; ativa = forma da prioridade + "ATIVO" (pisca se nao reconhecida); normal = traco cinza
		float Linha(FreeText rot, FreeText normal, Rectangle p1, FreeText p1n, Polygon p2, FreeText p2n, FreeText txt, bool aplica, bool ativa, int prioridade, bool naoRec, float y)
		{
			rot.Visible = aplica;
			if (!aplica) { normal.Visible = false; Indicador(p1, p1n, p2, p2n, txt, 0, ""); return y; }
			rot.Location = new NxtControl.Drawing.PointF(24F, y);
			normal.Location = new NxtControl.Drawing.PointF(244F, y);
			p1.Bounds = new NxtControl.Drawing.RectF(240F, y, 16F, 16F);
			p1n.Location = new NxtControl.Drawing.PointF(244F, y + 1F);
			p2.Location = new NxtControl.Drawing.PointF(240F, y);
			p2n.Location = new NxtControl.Drawing.PointF(245F, y + 4F);
			txt.Location = new NxtControl.Drawing.PointF(260F, y);
			normal.Visible = !ativa;
			Indicador(p1, p1n, p2, p2n, txt, ativa ? prioridade : 0, "ATIVO", naoRec);
			return y + 26F;
		}

		void Atualiza()
		{
			rInv.Text = inversor ? "Falha inversor" : "Falha acionamento";
			float yF = 264F;
			yF = Linha(rEmerg, nEmerg, iEmergP1, iEmergP1n, iEmergP2, iEmergP2n, iEmergTxt, true, fEmerg, 1, NaoRec(eEmerg), yF);
			yF = Linha(rTerm, nTerm, iTermP1, iTermP1n, iTermP2, iTermP2n, iTermTxt, usaTermica, fTerm, 1, NaoRec(eTerm), yF);
			yF = Linha(rInv, nInv, iInvP1, iInvP1n, iInvP2, iInvP2n, iInvTxt, true, fInv, 1, NaoRec(eInv), yF);
			yF = Linha(rPart, nPart, iPartP1, iPartP1n, iPartP2, iPartP2n, iPartTxt, true, fPart, 1, NaoRec(ePart), yF);
			yF = Linha(rPara, nPara, iParaP1, iParaP1n, iParaP2, iParaP2n, iParaTxt, true, fPara, 1, NaoRec(ePara), yF);
			yF = Linha(rCom, nCom, iComP1, iComP1n, iComP2, iComP2n, iComTxt, usaCom, fCom, 2, NaoRec(eCom), yF);
			tVelRef.Visible = inversor; vVelRef.Visible = inversor; tVel.Visible = inversor; vVel.Visible = inversor;
			Pisca(AlgumNaoRec());
		}

	}
}
