/*
 * Hidryco - Motor_Generico - fpDefault
 * ISA-101: estado (texto + caixa cheia/vazada), falha com indicador de prioridade, chave/disponibilidade em texto, velocidade (inversor), modo, comando manual, reset e navegacao.
 */

using System;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Faceplates.Motor_Generico
{
	public partial class fpDefault : NxtControl.GuiFramework.HMIFaceplate
	{
		public fpDefault()
		{
			InitializeComponent();
			Atualiza();
		}
		const float NAV_Y = 358F;

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


		void Atualiza()
		{
			// estado: texto + caixa cheia (ligado) / vazada (desligado), sem verde/vermelho
			textoEstado.Text = ligado ? "LIGADO" : "DESLIGADO";
			caixaEstado.BrushColor = ligado ? new NxtControl.Drawing.Color(64, 64, 64) : new NxtControl.Drawing.Color(255, 255, 255);
			int pr; bool nr;
			string f = FalhaAtiva(out pr, out nr);
			Indicador(alP1, alP1n, alP2, alP2n, alTxt, pr, f, nr);
			Pisca(AlgumNaoRec());
			textoChave.Text = manutencao ? "Chave em manutenção (0)" : (local ? "Chave em local" : (remoto ? "Chave em remoto" : "Sem comunicação"));
			textoDisp.Text = bloqGerador ? "Bloqueado pelo gerador" : (bloqueado ? "Intertravado" : (disponivel ? "Disponível para o automático" : (automatico ? "Indisponível" : "Em manual")));
			textoGerador.Visible = animGerador > 0;
			textoGerador.Text = animGerador == 3 ? "Gerador: selecionado e ligado" : (animGerador == 2 ? "Gerador: selecionado" : "Gerador: pode alimentar este equipamento");
			// velocidade (so com inversor): barra 0-100 %, ponteiro = real, marca vazada = referencia
			tituloVel.Visible = inversor; vel.Visible = inversor; velBarra.Visible = inversor; velRef.Visible = inversor; velPonteiro.Visible = inversor;
			velPonteiro.Location = new NxtControl.Drawing.PointF(160F + 180F * Limita(velocidade) / 100F - 5F, 116F);
			velRef.Location = new NxtControl.Drawing.PointF(160F + 180F * Limita(referencia) / 100F - 5F, 98F);
			// navegacao: sem inversor o botao Medicoes some e os outros 3 se redistribuem na mesma largura
			btnMedicoes.Visible = inversor;
			if (inversor) { Nav(btnAjustes, 0, 4); Nav(btnManutencao, 1, 4); Nav(btnMedicoes, 2, 4); Nav(btnDiagnostico, 3, 4); }
			else { Nav(btnAjustes, 0, 3); Nav(btnManutencao, 1, 3); Nav(btnDiagnostico, 2, 3); }
			// modo e comando
			// modo: o botao do modo atual fica ativo
			Selecao(btnAutomatico, automatico); Selecao(btnManual, !automatico);
			// comando: em manual mostra o comando do operador; em automatico mostra o estado do motor (o clique e ignorado)
			bool liga = automatico ? ligado : cmdManual;
			Selecao(btnLigar, liga); Selecao(btnDesligar, !liga);
			tituloComando.Text = automatico ? "Comando manual (em automático: só indica)" : "Comando manual";
		}

		static float Limita(float v) { return v < 0F ? 0F : (v > 100F ? 100F : v); }

		void BtnAutomaticoClick(object sender, EventArgs e) { FireEvent_E_MODO_OPERACAO(true); }
		void BtnManualClick(object sender, EventArgs e) { FireEvent_E_MODO_OPERACAO(false); }
		void BtnLigarClick(object sender, EventArgs e) { if (!automatico) FireEvent_E_COMANDO_MANUAL(true); }
		void BtnDesligarClick(object sender, EventArgs e) { if (!automatico) FireEvent_E_COMANDO_MANUAL(false); }

		const float NAV_X = 20F, NAV_W = 320F, NAV_GAP = 8F;
		void Nav(DrawnButton b, int i, int n)
		{
			float w = (NAV_W - NAV_GAP * (n - 1)) / n;
			b.Bounds = new NxtControl.Drawing.RectF(NAV_X + i * (w + NAV_GAP), NAV_Y, w, 32F);
		}
		void BtnResetClick(object sender, EventArgs e) { FireEvent_E_RESET_FALHA(true); FireEvent_E_RESET_FALHA(false); }

	}
}
