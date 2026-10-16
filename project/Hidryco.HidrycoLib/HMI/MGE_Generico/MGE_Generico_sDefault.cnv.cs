/*
 * Hidryco - MGE_Generico - sDefault
 * ISA-101: multimedidor - potencia ativa e reativa, FP, frequencia e indicador de alarme.
 */

using System;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Symbols.MGE_Generico
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

		// ---- alarmes recebidos da logica (Execute invisiveis)
		bool aCom, aFPL, aVFH, aVFL, aVNH, aVNL, aIAH, aIBH, aICH, aIAL, aIBL, aICL, aFRH, aFRL;
		byte eCom, eFPL, eVFH, eVFL, eVNH, eVNL, eIAH, eIBH, eICH, eIAL, eIBL, eICL, eFRH, eFRL;
		void AComValueChanged(object s, ValueChangedEventArgs e) { aCom = Convert.ToBoolean(e.Value); Atualiza(); }
		void AFPLValueChanged(object s, ValueChangedEventArgs e) { aFPL = Convert.ToBoolean(e.Value); Atualiza(); }
		void AVFHValueChanged(object s, ValueChangedEventArgs e) { aVFH = Convert.ToBoolean(e.Value); Atualiza(); }
		void AVFLValueChanged(object s, ValueChangedEventArgs e) { aVFL = Convert.ToBoolean(e.Value); Atualiza(); }
		void AVNHValueChanged(object s, ValueChangedEventArgs e) { aVNH = Convert.ToBoolean(e.Value); Atualiza(); }
		void AVNLValueChanged(object s, ValueChangedEventArgs e) { aVNL = Convert.ToBoolean(e.Value); Atualiza(); }
		void AIAHValueChanged(object s, ValueChangedEventArgs e) { aIAH = Convert.ToBoolean(e.Value); Atualiza(); }
		void AIBHValueChanged(object s, ValueChangedEventArgs e) { aIBH = Convert.ToBoolean(e.Value); Atualiza(); }
		void AICHValueChanged(object s, ValueChangedEventArgs e) { aICH = Convert.ToBoolean(e.Value); Atualiza(); }
		void AIALValueChanged(object s, ValueChangedEventArgs e) { aIAL = Convert.ToBoolean(e.Value); Atualiza(); }
		void AIBLValueChanged(object s, ValueChangedEventArgs e) { aIBL = Convert.ToBoolean(e.Value); Atualiza(); }
		void AICLValueChanged(object s, ValueChangedEventArgs e) { aICL = Convert.ToBoolean(e.Value); Atualiza(); }
		void AFRHValueChanged(object s, ValueChangedEventArgs e) { aFRH = Convert.ToBoolean(e.Value); Atualiza(); }
		void AFRLValueChanged(object s, ValueChangedEventArgs e) { aFRL = Convert.ToBoolean(e.Value); Atualiza(); }
		void EComValueChanged(object s, ValueChangedEventArgs e) { eCom = Convert.ToByte(e.Value); Atualiza(); }
		void EFPLValueChanged(object s, ValueChangedEventArgs e) { eFPL = Convert.ToByte(e.Value); Atualiza(); }
		void EVFHValueChanged(object s, ValueChangedEventArgs e) { eVFH = Convert.ToByte(e.Value); Atualiza(); }
		void EVFLValueChanged(object s, ValueChangedEventArgs e) { eVFL = Convert.ToByte(e.Value); Atualiza(); }
		void EVNHValueChanged(object s, ValueChangedEventArgs e) { eVNH = Convert.ToByte(e.Value); Atualiza(); }
		void EVNLValueChanged(object s, ValueChangedEventArgs e) { eVNL = Convert.ToByte(e.Value); Atualiza(); }
		void EIAHValueChanged(object s, ValueChangedEventArgs e) { eIAH = Convert.ToByte(e.Value); Atualiza(); }
		void EIBHValueChanged(object s, ValueChangedEventArgs e) { eIBH = Convert.ToByte(e.Value); Atualiza(); }
		void EICHValueChanged(object s, ValueChangedEventArgs e) { eICH = Convert.ToByte(e.Value); Atualiza(); }
		void EIALValueChanged(object s, ValueChangedEventArgs e) { eIAL = Convert.ToByte(e.Value); Atualiza(); }
		void EIBLValueChanged(object s, ValueChangedEventArgs e) { eIBL = Convert.ToByte(e.Value); Atualiza(); }
		void EICLValueChanged(object s, ValueChangedEventArgs e) { eICL = Convert.ToByte(e.Value); Atualiza(); }
		void EFRHValueChanged(object s, ValueChangedEventArgs e) { eFRH = Convert.ToByte(e.Value); Atualiza(); }
		void EFRLValueChanged(object s, ValueChangedEventArgs e) { eFRL = Convert.ToByte(e.Value); Atualiza(); }

		// Alarme de maior prioridade: comunicacao = 1 (Alarm); os demais = 2 (Warning)
		int Prioridade(out string texto, out bool naoRec)
		{
			if (aCom) { texto = "SEM COMUNICAÇÃO"; naoRec = NaoRec(eCom); return 1; }
			if (aFPL) { texto = "FP BAIXO"; naoRec = NaoRec(eFPL); return 2; }
			if (aVFH) { texto = "TENSÃO FF ALTA"; naoRec = NaoRec(eVFH); return 2; }
			if (aVFL) { texto = "TENSÃO FF BAIXA"; naoRec = NaoRec(eVFL); return 2; }
			if (aVNH) { texto = "TENSÃO FN ALTA"; naoRec = NaoRec(eVNH); return 2; }
			if (aVNL) { texto = "TENSÃO FN BAIXA"; naoRec = NaoRec(eVNL); return 2; }
			if (aIAH) { texto = "CORRENTE A ALTA"; naoRec = NaoRec(eIAH); return 2; }
			if (aIBH) { texto = "CORRENTE B ALTA"; naoRec = NaoRec(eIBH); return 2; }
			if (aICH) { texto = "CORRENTE C ALTA"; naoRec = NaoRec(eICH); return 2; }
			if (aIAL) { texto = "CORRENTE A BAIXA"; naoRec = NaoRec(eIAL); return 2; }
			if (aIBL) { texto = "CORRENTE B BAIXA"; naoRec = NaoRec(eIBL); return 2; }
			if (aICL) { texto = "CORRENTE C BAIXA"; naoRec = NaoRec(eICL); return 2; }
			if (aFRH) { texto = "FREQUÊNCIA ALTA"; naoRec = NaoRec(eFRH); return 2; }
			if (aFRL) { texto = "FREQUÊNCIA BAIXA"; naoRec = NaoRec(eFRL); return 2; }
			texto = ""; naoRec = false; return 0;
		}
		bool AlgumNaoRec() { return NaoRec(eCom) || NaoRec(eFPL) || NaoRec(eVFH) || NaoRec(eVFL) || NaoRec(eVNH) || NaoRec(eVNL) || NaoRec(eIAH) || NaoRec(eIBH) || NaoRec(eICH) || NaoRec(eIAL) || NaoRec(eIBL) || NaoRec(eICL) || NaoRec(eFRH) || NaoRec(eFRL); }


		void Atualiza()
		{
			string t; bool nr; int p = Prioridade(out t, out nr);
			Indicador(alP1, alP1n, alP2, alP2n, alTxt, p, p > 0 ? "ALARME" : "", nr);
			Pisca(AlgumNaoRec());
			// valor invalido nunca aparece como numero (ISA-101)
			textoEstado.Text = aCom ? "SEM COMUNICAÇÃO - valores congelados" : (p > 0 ? t : "normal");
		}

	}
}
