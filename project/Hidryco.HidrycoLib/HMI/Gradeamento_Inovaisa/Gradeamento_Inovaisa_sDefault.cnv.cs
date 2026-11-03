/*
 * Hidryco - Gradeamento_Inovaisa - sDefault
 * ISA-101: gradeamento - ciclo remoto, comunicacao, emergencia e alarme.
 */

using System;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Symbols.Gradeamento_Inovaisa
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
		bool alm, emg, com, aPai, ciclo, fMot, func;
		byte eCom, eEmg, ePai;
		void XALMValueChanged(object s, ValueChangedEventArgs e) { alm = Convert.ToBoolean(e.Value); Atualiza(); }
		void XEMGValueChanged(object s, ValueChangedEventArgs e) { emg = Convert.ToBoolean(e.Value); Atualiza(); }
		void XCOMValueChanged(object s, ValueChangedEventArgs e) { com = Convert.ToBoolean(e.Value); Atualiza(); }
		void XAPAIValueChanged(object s, ValueChangedEventArgs e) { aPai = Convert.ToBoolean(e.Value); Atualiza(); }
		void XCICValueChanged(object s, ValueChangedEventArgs e) { ciclo = Convert.ToBoolean(e.Value); Atualiza(); }
		void XFMOTValueChanged(object s, ValueChangedEventArgs e) { fMot = Convert.ToBoolean(e.Value); Atualiza(); }
		void XFUNCValueChanged(object s, ValueChangedEventArgs e) { func = Convert.ToBoolean(e.Value); Atualiza(); }
		void XECOMValueChanged(object s, ValueChangedEventArgs e) { eCom = Convert.ToByte(e.Value); Atualiza(); }
		void XEEMGValueChanged(object s, ValueChangedEventArgs e) { eEmg = Convert.ToByte(e.Value); Atualiza(); }
		void XEPAIValueChanged(object s, ValueChangedEventArgs e) { ePai = Convert.ToByte(e.Value); Atualiza(); }

		int Prioridade(out string texto, out bool naoRec)
		{
			if (!com) { texto = "SEM COMUNICAÇÃO COM O PAINEL"; naoRec = NaoRec(eCom); return 2; }
			if (emg) { texto = "EMERGÊNCIA ACIONADA"; naoRec = NaoRec(eEmg); return 1; }
			if (aPai) { texto = "ALARME NO PAINEL"; naoRec = NaoRec(ePai); return 1; }
			if (fMot) { texto = "FALHA OU SOBRETORQUE (GRADE OU ROSCA)"; naoRec = false; return 1; }
			texto = ""; naoRec = false; return 0;
		}
		bool AlgumNaoRec() { return (!com && NaoRec(eCom)) || (emg && NaoRec(eEmg)) || (aPai && NaoRec(ePai)); }
		string Estado()
		{
			if (!com) return "SEM COMUNICAÇÃO";
			return (ciclo ? "CICLO REMOTO LIGADO" : "ciclo remoto desligado") + (func ? "  -  limpando" : "");
		}
		static readonly NxtControl.Drawing.Color LIGADO = Hidryco.HidrycoLib.SupportClasses.HidrycoColors.Ligado;
		static readonly NxtControl.Drawing.Color PARADO = Hidryco.HidrycoLib.SupportClasses.HidrycoColors.Desligado;
		static readonly NxtControl.Drawing.Color SEMCOM = Hidryco.HidrycoLib.SupportClasses.HidrycoColors.Unknown;

		void Atualiza()
		{
			string t; bool nr; int p = Prioridade(out t, out nr);
			Indicador(alP1, alP1n, alP2, alP2n, alTxt, p, t, nr);
			Pisca(AlgumNaoRec());
			l1.Text = Estado();
			l2.Text = !com ? "" : (emg ? "EMERGÊNCIA ACIONADA" : (func ? "grade ou rosca funcionando" : "grades e rosca paradas"));
			stCiclo.Brush = new NxtControl.Drawing.Brush(!com ? SEMCOM : (func ? LIGADO : PARADO));
		}

	}
}
