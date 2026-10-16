/*
 * Hidryco - Agua_Reuso - sDefault
 * ISA-101: agua de reuso - niveis dos dois PIT, boia LSL-01 e indicador de alarme.
 */

using System;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Symbols.Agua_Reuso
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

		// ---- dados recebidos da logica (Execute invisiveis)
		float n1, p1, n2, p2;
		short c1, c2;
		bool boiaNormal, nivelBaixo, fRem1, fRem2;
		byte eNivelBaixo, eRem1, eRem2;
		void N1ValueChanged(object s, ValueChangedEventArgs e) { n1 = Convert.ToSingle(e.Value); Atualiza(); }
		void P1ValueChanged(object s, ValueChangedEventArgs e) { p1 = Convert.ToSingle(e.Value); Atualiza(); }
		void N2ValueChanged(object s, ValueChangedEventArgs e) { n2 = Convert.ToSingle(e.Value); Atualiza(); }
		void P2ValueChanged(object s, ValueChangedEventArgs e) { p2 = Convert.ToSingle(e.Value); Atualiza(); }
		void C1ValueChanged(object s, ValueChangedEventArgs e) { c1 = Convert.ToInt16(e.Value); Atualiza(); }
		void C2ValueChanged(object s, ValueChangedEventArgs e) { c2 = Convert.ToInt16(e.Value); Atualiza(); }
		void BoiaValueChanged(object s, ValueChangedEventArgs e) { boiaNormal = Convert.ToBoolean(e.Value); Atualiza(); }
		void NivelBaixoValueChanged(object s, ValueChangedEventArgs e) { nivelBaixo = Convert.ToBoolean(e.Value); Atualiza(); }
		void Rem1ValueChanged(object s, ValueChangedEventArgs e) { fRem1 = Convert.ToBoolean(e.Value); Atualiza(); }
		void Rem2ValueChanged(object s, ValueChangedEventArgs e) { fRem2 = Convert.ToBoolean(e.Value); Atualiza(); }
		void ENivelBaixoValueChanged(object s, ValueChangedEventArgs e) { eNivelBaixo = Convert.ToByte(e.Value); Atualiza(); }
		void ERem1ValueChanged(object s, ValueChangedEventArgs e) { eRem1 = Convert.ToByte(e.Value); Atualiza(); }
		void ERem2ValueChanged(object s, ValueChangedEventArgs e) { eRem2 = Convert.ToByte(e.Value); Atualiza(); }

		// Valor invalido nunca aparece como numero (ISA-101): sinal invalido = ????, desabilitado = DESAB.
		static string Valor(float n, float p, short c)
		{
			if (c == 5) return "????";
			if (c == 7) return "DESAB.";
			return n.ToString("0.00") + " m  (" + p.ToString("0") + " %)";
		}
		static readonly string[] COND = { "normal", "HH", "H", "L", "LL", "SINAL INVÁLIDO", "FALHA - RESET", "desabilitado" };
		static string Cond(short c) { return c >= 0 && c < COND.Length ? COND[c] : "-"; }
		// prioridade da condicao do sensor: HH, LL e falha = 1; H e L = 2
		static int PrioCond(short c) { return (c == 1 || c == 4 || c == 5 || c == 6) ? 1 : ((c == 2 || c == 3) ? 2 : 0); }

		// Alarme de maior prioridade da agua de reuso
		int Prioridade(out string texto, out bool naoRec)
		{
			if (fRem2) { texto = "SEM COMUNICAÇÃO REMOTA 2"; naoRec = NaoRec(eRem2); return 1; }
			if (fRem1) { texto = "SEM COMUNICAÇÃO REMOTA 1"; naoRec = NaoRec(eRem1); return 1; }
			if (PrioCond(c1) == 1) { texto = "PIT-01 " + Cond(c1); naoRec = false; return 1; }
			if (PrioCond(c2) == 1) { texto = "PIT-02 " + Cond(c2); naoRec = false; return 1; }
			if (nivelBaixo) { texto = "NÍVEL BAIXO (LSL-01)"; naoRec = NaoRec(eNivelBaixo); return 2; }
			if (PrioCond(c1) == 2) { texto = "PIT-01 " + Cond(c1); naoRec = false; return 2; }
			if (PrioCond(c2) == 2) { texto = "PIT-02 " + Cond(c2); naoRec = false; return 2; }
			texto = ""; naoRec = false; return 0;
		}
		bool AlgumNaoRec() { return NaoRec(eNivelBaixo) || NaoRec(eRem1) || NaoRec(eRem2); }


		void Atualiza()
		{
			string t; bool nr; int p = Prioridade(out t, out nr);
			Indicador(alP1, alP1n, alP2, alP2n, alTxt, p, p > 0 ? "ALARME" : "", nr);
			Pisca(AlgumNaoRec());
			v1.Text = Valor(n1, p1, c1);
			v2.Text = Valor(n2, p2, c2);
			v3.Text = fRem1 ? "????" : (nivelBaixo ? "NÍVEL BAIXO" : (boiaNormal ? "normal" : "abaixada"));
		}

	}
}
