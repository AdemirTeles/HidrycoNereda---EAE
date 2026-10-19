/*
 * Hidryco - Valvula_Coester - sValvula
 * ISA-101: valvula com atuador (corpo cheio = aberta, vazio = fechada, meio = intermediaria), posicao, modo e indicador de alarme.
 */

using System;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Symbols.Valvula_Coester
{
	public partial class sValvula : NxtControl.GuiFramework.HMISymbol
	{
		public sValvula()
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

		static readonly string[] FALHAS = { "", "FALTA DE FASE", "SOBREAQUECIMENTO DO MOTOR", "ATUADOR SEM PROGRAMAÇÃO", "PARADA DE EMERGÊNCIA LOCAL",
			"TORQUE NA ABERTURA", "TORQUE NO FECHAMENTO", "VÁLVULA TRAVADA", "OPERAÇÃO INCOMPLETA", "FALHA AO ENERGIZAR O MOTOR",
			"MOTOR ENERGIZADO APÓS FIM DE CURSO", "MOTOR ENERGIZADO APÓS PARADA", "FALHA DE COMANDO", "TENSÃO ALTA", "TENSÃO BAIXA",
			"FIM DE CURSO MECÂNICO ULTRAPASSADO", "FIM DE CURSO PROGRAMADO ULTRAPASSADO", "CARTÃO DE REDE NÃO DETECTADO" };
		static string Falha(short c) { return c > 0 && c < FALHAS.Length ? FALHAS[c] : "FALHA DO ATUADOR"; }

		// ---- dados recebidos da logica (Execute invisiveis)
		short anim, cod, cmdMan;
		float pos, refe;
		bool auto, rem, loc, desl, fCom, fAtu, fPos, aCfg, aPart, bloq, disp, modul;
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
		void XACFGValueChanged(object s, ValueChangedEventArgs e) { aCfg = Convert.ToBoolean(e.Value); Atualiza(); }
		void XAPARTValueChanged(object s, ValueChangedEventArgs e) { aPart = Convert.ToBoolean(e.Value); Atualiza(); }
		void XBLOQValueChanged(object s, ValueChangedEventArgs e) { bloq = Convert.ToBoolean(e.Value); Atualiza(); }
		void XDISPValueChanged(object s, ValueChangedEventArgs e) { disp = Convert.ToBoolean(e.Value); Atualiza(); }
		void XMODValueChanged(object s, ValueChangedEventArgs e) { modul = Convert.ToBoolean(e.Value); Atualiza(); }
		void XCMDMValueChanged(object s, ValueChangedEventArgs e) { cmdMan = Convert.ToInt16(e.Value); Atualiza(); }
		void XECOMValueChanged(object s, ValueChangedEventArgs e) { eCom = Convert.ToByte(e.Value); Atualiza(); }
		void XEATUValueChanged(object s, ValueChangedEventArgs e) { eAtu = Convert.ToByte(e.Value); Atualiza(); }
		void XEPOSValueChanged(object s, ValueChangedEventArgs e) { ePos = Convert.ToByte(e.Value); Atualiza(); }

		// Alarme de maior prioridade da valvula
		int Prioridade(out string texto, out bool naoRec)
		{
			if (fCom) { texto = "SEM COMUNICAÇÃO"; naoRec = NaoRec(eCom); return 1; }
			if (fAtu) { texto = Falha(cod); naoRec = NaoRec(eAtu); return 1; }
			if (fPos) { texto = "POSIÇÃO NÃO ATINGIDA"; naoRec = NaoRec(ePos); return 2; }
			if (aCfg) { texto = "ATUADOR FORA DO POSICIONAMENTO CONTÍNUO"; naoRec = false; return 2; }
			if (aPart) { texto = "PARTIDAS/DIA ACIMA DO LIMITE"; naoRec = false; return 2; }
			texto = ""; naoRec = false; return 0;
		}
		bool AlgumNaoRec() { return (fCom && NaoRec(eCom)) || (fAtu && NaoRec(eAtu)) || (fPos && NaoRec(ePos)); }
		static readonly string[] ESTADO = { "FECHADA", "ABERTA", "INTERMEDIÁRIA", "EM MOVIMENTO", "FALHA", "FORA DE REMOTO", "SEM COMUNICAÇÃO" };
		string Estado() { return anim >= 0 && anim < ESTADO.Length ? ESTADO[anim] : "-"; }
		string Chave() { return fCom ? "????" : (rem ? "REMOTO" : (loc ? "LOCAL" : (desl ? "DESLIGADO" : "-"))); }

		static readonly NxtControl.Drawing.Color CHEIO = new NxtControl.Drawing.Color(64, 64, 64);
		static readonly NxtControl.Drawing.Color MEIO = new NxtControl.Drawing.Color(160, 160, 160);
		static readonly NxtControl.Drawing.Color VAZIO = new NxtControl.Drawing.Color(255, 255, 255);
		static readonly NxtControl.Drawing.Color SEMCOM = new NxtControl.Drawing.Color(224, 224, 224);

		void Atualiza()
		{
			string t; bool nr; int p = Prioridade(out t, out nr);
			Indicador(alP1, alP1n, alP2, alP2n, alTxt, p, "", nr);
			Pisca(AlgumNaoRec());
			NxtControl.Drawing.Color c = fCom ? SEMCOM : (anim == 1 ? CHEIO : (anim == 0 ? VAZIO : MEIO));
			corpoE.BrushColor = c;
			corpoD.BrushColor = c;
			tModo.Text = auto ? "A" : "M";
			tPos.Text = fCom ? "????" : (pos.ToString("0") + " %" + (rem ? "" : " L"));
		}

	}
}
