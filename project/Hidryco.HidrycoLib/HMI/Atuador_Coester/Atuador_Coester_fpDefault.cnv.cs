/*
 * Hidryco - Atuador_Coester 2.1 - fpDefault
 * ISA-101: estado, posicao, alarme por prioridade, chave/modo/disponibilidade, comando manual, tempos, reset e diagnostico.
 * Parar e posicionar so aparecem no posicionador (STS_POSICIONADOR, 700-VC-01); as demais so abrir e fechar.
 */

using System;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Faceplates.Atuador_Coester
{
	public partial class fpDefault : NxtControl.GuiFramework.HMIFaceplate
	{
		public fpDefault()
		{
			InitializeComponent();
			Atualiza();
		}

		// Indicador de alarme (ISA-101): forma + numero de prioridade; escondido quando normal; pisca se nao reconhecido
		bool fase = true;
		System.Timers.Timer tPisca;
		static bool NaoRec(byte estadoAlarme) { return estadoAlarme >= 2 && estadoAlarme <= 4; }

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

		static readonly string[] FALHAS = { "", "FALTA DE FASE", "SOBREAQUECIMENTO DO MOTOR", "ATUADOR SEM PROGRAMAÇÃO", "PARADA DE EMERGÊNCIA LOCAL",
			"TORQUE NA ABERTURA", "TORQUE NO FECHAMENTO", "VÁLVULA TRAVADA", "OPERAÇÃO INCOMPLETA", "FALHA AO ENERGIZAR O MOTOR",
			"MOTOR ENERGIZADO APÓS FIM DE CURSO", "MOTOR ENERGIZADO APÓS PARADA", "FALHA DE COMANDO", "TENSÃO ALTA", "TENSÃO BAIXA",
			"FIM DE CURSO MECÂNICO ULTRAPASSADO", "FIM DE CURSO PROGRAMADO ULTRAPASSADO", "CARTÃO DE REDE NÃO DETECTADO" };
		static string Falha(short c) { return c > 0 && c < FALHAS.Length ? FALHAS[c] : "FALHA DO ATUADOR"; }

		// ---- dados recebidos da logica (Execute invisiveis)
		short anim, cod;
		float pos, refe;
		bool auto, rem, loc, desl, fCom, fAtu, fPos, disp, posic;
		byte eCom, eAtu, ePos;
		void XANIMValueChanged(object s, ValueChangedEventArgs e) { anim = Convert.ToInt16(e.Value); Atualiza(); }
		void XPOSValueChanged(object s, ValueChangedEventArgs e) { pos = Convert.ToSingle(e.Value); Atualiza(); }
		void XREFValueChanged(object s, ValueChangedEventArgs e) { refe = Convert.ToSingle(e.Value); Atualiza(); }
		void XAUTOValueChanged(object s, ValueChangedEventArgs e) { auto = Convert.ToBoolean(e.Value); Atualiza(); }
		void XREMValueChanged(object s, ValueChangedEventArgs e) { rem = Convert.ToBoolean(e.Value); Atualiza(); }
		void XLOCValueChanged(object s, ValueChangedEventArgs e) { loc = Convert.ToBoolean(e.Value); Atualiza(); }
		void XDESLValueChanged(object s, ValueChangedEventArgs e) { desl = Convert.ToBoolean(e.Value); Atualiza(); }
		void XFCOMValueChanged(object s, ValueChangedEventArgs e) { fCom = Convert.ToBoolean(e.Value); Atualiza(); }
		void XFATUValueChanged(object s, ValueChangedEventArgs e) { fAtu = Convert.ToBoolean(e.Value); Atualiza(); }
		void XFPOSValueChanged(object s, ValueChangedEventArgs e) { fPos = Convert.ToBoolean(e.Value); Atualiza(); }
		void XCODValueChanged(object s, ValueChangedEventArgs e) { cod = Convert.ToInt16(e.Value); Atualiza(); }
		void XDISPValueChanged(object s, ValueChangedEventArgs e) { disp = Convert.ToBoolean(e.Value); Atualiza(); }
		void XMODValueChanged(object s, ValueChangedEventArgs e) { posic = Convert.ToBoolean(e.Value); Atualiza(); }
		void XECOMValueChanged(object s, ValueChangedEventArgs e) { eCom = Convert.ToByte(e.Value); Atualiza(); }
		void XEATUValueChanged(object s, ValueChangedEventArgs e) { eAtu = Convert.ToByte(e.Value); Atualiza(); }
		void XEPOSValueChanged(object s, ValueChangedEventArgs e) { ePos = Convert.ToByte(e.Value); Atualiza(); }

		// Alarme de maior prioridade
		int Prioridade(out string texto, out bool naoRec)
		{
			if (fCom) { texto = "SEM COMUNICAÇÃO"; naoRec = NaoRec(eCom); return 1; }
			if (fAtu) { texto = Falha(cod); naoRec = NaoRec(eAtu); return 1; }
			if (fPos) { texto = posic ? "NÃO ATINGIU A POSIÇÃO" : "NÃO ABRIU / NÃO FECHOU"; naoRec = NaoRec(ePos); return 2; }
			texto = ""; naoRec = false; return 0;
		}
		// STS_ANIMACAO: 0 fechada, 1 aberta, 2 falha, 3 intermediaria parada, 4 abrindo, 5 fechando
		string Estado()
		{
			if (fCom) return "SEM COMUNICAÇÃO";
			// falha do atuador: so na linha de alarme e no diagnostico; o estado mostra a posicao real
			if (fPos) return posic ? "NÃO ATINGIU A POSIÇÃO" : "NÃO ABRIU / NÃO FECHOU";
			switch (anim)
			{
				case 0: return "FECHADA";
				case 1: return "ABERTA";
				case 3: return "INTERMEDIÁRIA";
				case 4: return "ABRINDO";
				case 5: return "FECHANDO";
			}
			return "-";
		}
		string Chave() { return fCom ? "????" : (rem ? "REMOTO" : (loc ? "LOCAL" : (desl ? "DESLIGADO" : "-"))); }

		static readonly NxtControl.Drawing.Color ATIVO = new NxtControl.Drawing.Color(96, 96, 96);
		static readonly NxtControl.Drawing.Color INATIVO = new NxtControl.Drawing.Color(208, 208, 208);
		static readonly NxtControl.Drawing.Color BRANCO = new NxtControl.Drawing.Color(255, 255, 255);
		static readonly NxtControl.Drawing.Color PRETO = new NxtControl.Drawing.Color(0, 0, 0);

		void Atualiza()
		{
			string t; bool nr; int p = Prioridade(out t, out nr);
			bool mostra = !nr || fase;
			alP1.Visible = p == 1 && mostra; alP1n.Visible = p == 1 && mostra;
			alP2.Visible = p == 2 && mostra; alP2n.Visible = p == 2 && mostra;
			alTxt.Visible = p > 0; alTxt.Text = t;
			Pisca((fCom && NaoRec(eCom)) || (fAtu && NaoRec(eAtu)) || (fPos && NaoRec(ePos)));
			textoEstado.Text = Estado();
			float pp = Math.Max(0F, Math.Min(100F, pos));
			float rr = Math.Max(0F, Math.Min(100F, refe));
			barra.Bounds = new NxtControl.Drawing.RectF(20F, 72F, 320F * pp / 100F, 18F);
			marcaRef.Location = new NxtControl.Drawing.PointF(14F + 320F * rr / 100F, 92F);
			marcaRef.Visible = posic;
			vPos.Text = fCom ? "Atual: ????" : ("Atual: " + pos.ToString("0") + " %");
			vRef.Text = posic ? ("Referência: " + refe.ToString("0") + " %") : "";
			textoChave.Text = "Chave: " + Chave();
			textoDisp.Text = "Disp. automático: " + (disp ? "SIM" : "NÃO");
			btnAutomatico.BrushColor = auto ? ATIVO : INATIVO;
			btnManual.BrushColor = !auto ? ATIVO : INATIVO;
			btnAutomatico.TextColor = auto ? BRANCO : PRETO;
			btnManual.TextColor = !auto ? BRANCO : PRETO;
			bool podeMan = !auto && rem && !fCom;
			btnAbrir.Enabled = podeMan; btnFechar.Enabled = podeMan; btnParar.Enabled = podeMan; btnPosicionar.Enabled = podeMan;
			// parar e posicionar so no posicionador
			btnParar.Visible = posic; rSp.Visible = posic; vSpMan.Visible = posic; btnPosicionar.Visible = posic;
			textoCmd.Text = auto ? "Em automático: comandos manuais desabilitados"
				: (fCom ? "Sem comunicação: sem comando" : (rem ? "Manual: comando pelos botões" : "Fora de remoto: comando no atuador"));
		}

		void BtnAutomaticoClick(object sender, EventArgs e) { FireEvent_E_STS_AUTOMATICO(true); }
		void BtnManualClick(object sender, EventArgs e) { FireEvent_E_STS_AUTOMATICO(false); }
		void BtnAbrirClick(object sender, EventArgs e) { if (!auto) FireEvent_E_CMD_ABRIR_MANUAL(true); }
		void BtnFecharClick(object sender, EventArgs e) { if (!auto) FireEvent_E_CMD_FECHAR_MANUAL(true); }
		void BtnPararClick(object sender, EventArgs e) { if (!auto && posic) FireEvent_E_CMD_PARAR_MANUAL(true); }
		void BtnPosicionarClick(object sender, EventArgs e) { if (!auto && posic) FireEvent_E_CMD_POSICIONAR_MANUAL(true); }
		void BtnResetClick(object sender, EventArgs e) { FireEvent_E_CMD_RESET_FALHA(true); FireEvent_E_CMD_RESET_FALHA(false); }
	}
}
