/*
 * Hidryco - Gerador_Generico - sDefault
 * ISA-101: grupo gerador - estado, modo, potencia, frequencia e indicador de alarme.
 */

using System;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Symbols.Gerador_Generico
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

		// ---- alarmes e estados recebidos da logica (Execute invisiveis)
		bool aCom, aAGC, aPartida, aMotor, aEmergencia, aDisjuntor, aFaltaRede, aForaAuto, operando;
		byte eCom, eAGC, ePartida, eMotor, eEmergencia, eDisjuntor, eFaltaRede, eForaAuto;
		short sGB, sMB, sModo, sFonte;
		void AComValueChanged(object s, ValueChangedEventArgs e) { aCom = Convert.ToBoolean(e.Value); Atualiza(); }
		void AAGCValueChanged(object s, ValueChangedEventArgs e) { aAGC = Convert.ToBoolean(e.Value); Atualiza(); }
		void APartidaValueChanged(object s, ValueChangedEventArgs e) { aPartida = Convert.ToBoolean(e.Value); Atualiza(); }
		void AMotorValueChanged(object s, ValueChangedEventArgs e) { aMotor = Convert.ToBoolean(e.Value); Atualiza(); }
		void AEmergenciaValueChanged(object s, ValueChangedEventArgs e) { aEmergencia = Convert.ToBoolean(e.Value); Atualiza(); }
		void ADisjuntorValueChanged(object s, ValueChangedEventArgs e) { aDisjuntor = Convert.ToBoolean(e.Value); Atualiza(); }
		void AFaltaRedeValueChanged(object s, ValueChangedEventArgs e) { aFaltaRede = Convert.ToBoolean(e.Value); Atualiza(); }
		void AForaAutoValueChanged(object s, ValueChangedEventArgs e) { aForaAuto = Convert.ToBoolean(e.Value); Atualiza(); }
		void EComValueChanged(object s, ValueChangedEventArgs e) { eCom = Convert.ToByte(e.Value); Atualiza(); }
		void EAGCValueChanged(object s, ValueChangedEventArgs e) { eAGC = Convert.ToByte(e.Value); Atualiza(); }
		void EPartidaValueChanged(object s, ValueChangedEventArgs e) { ePartida = Convert.ToByte(e.Value); Atualiza(); }
		void EMotorValueChanged(object s, ValueChangedEventArgs e) { eMotor = Convert.ToByte(e.Value); Atualiza(); }
		void EEmergenciaValueChanged(object s, ValueChangedEventArgs e) { eEmergencia = Convert.ToByte(e.Value); Atualiza(); }
		void EDisjuntorValueChanged(object s, ValueChangedEventArgs e) { eDisjuntor = Convert.ToByte(e.Value); Atualiza(); }
		void EFaltaRedeValueChanged(object s, ValueChangedEventArgs e) { eFaltaRede = Convert.ToByte(e.Value); Atualiza(); }
		void EForaAutoValueChanged(object s, ValueChangedEventArgs e) { eForaAuto = Convert.ToByte(e.Value); Atualiza(); }
		void SGBValueChanged(object s, ValueChangedEventArgs e) { sGB = Convert.ToInt16(e.Value); Atualiza(); }
		void SMBValueChanged(object s, ValueChangedEventArgs e) { sMB = Convert.ToInt16(e.Value); Atualiza(); }
		void SModoValueChanged(object s, ValueChangedEventArgs e) { sModo = Convert.ToInt16(e.Value); Atualiza(); }
		void SFonteValueChanged(object s, ValueChangedEventArgs e) { sFonte = Convert.ToInt16(e.Value); Atualiza(); }
		void OperandoValueChanged(object s, ValueChangedEventArgs e) { operando = Convert.ToBoolean(e.Value); Atualiza(); }

		// Alarme de maior prioridade (classe Alarm = 1, Warning = 2)
		int Prioridade(out string texto, out bool naoRec)
		{
			if (aCom) { texto = "SEM COMUNICAÇÃO"; naoRec = NaoRec(eCom); return 1; }
			if (aAGC) { texto = "ALARME NO AGC"; naoRec = NaoRec(eAGC); return 1; }
			if (aPartida) { texto = "FALHA NA PARTIDA"; naoRec = NaoRec(ePartida); return 1; }
			if (aMotor) { texto = "DESLIGAMENTO DO MOTOR"; naoRec = NaoRec(eMotor); return 1; }
			if (aEmergencia) { texto = "EMERGÊNCIA"; naoRec = NaoRec(eEmergencia); return 1; }
			if (aDisjuntor) { texto = "FALHA DE DISJUNTOR"; naoRec = NaoRec(eDisjuntor); return 1; }
			if (aFaltaRede) { texto = "FALTA DE REDE"; naoRec = NaoRec(eFaltaRede); return 2; }
			if (aForaAuto) { texto = "FORA DO AUTOMÁTICO"; naoRec = NaoRec(eForaAuto); return 2; }
			texto = ""; naoRec = false; return 0;
		}
		bool AlgumNaoRec() { return NaoRec(eCom) || NaoRec(eAGC) || NaoRec(ePartida) || NaoRec(eMotor) || NaoRec(eEmergencia) || NaoRec(eDisjuntor) || NaoRec(eFaltaRede) || NaoRec(eForaAuto); }

		static string TextoDisjuntor(short v) { return v == 2 ? "Fechado" : v == 1 ? "Aberto" : "Indefinido"; }
		static string TextoModo(short v)
		{
			switch (v) { case 1: return "Automático"; case 2: return "Semiautomático"; case 3: return "Manual"; case 4: return "Bloqueio"; case 5: return "Teste"; default: return "Indefinido"; }
		}
		static string TextoFonte(short v)
		{
			switch (v) { case 1: return "Rede"; case 2: return "Gerador"; case 0: return "Sem fonte"; default: return "Indefinida"; }
		}


		void Atualiza()
		{
			string t; bool nr; int p = Prioridade(out t, out nr);
			Indicador(alP1, alP1n, alP2, alP2n, alTxt, p, p > 0 ? "ALARME" : "", nr);
			Pisca(AlgumNaoRec());
			// sem comunicacao: o estado nao e mostrado como se fosse valido (ISA-101)
			textoEstado.Text = aCom ? "SEM COMUNICAÇÃO" : (operando ? "Em operação" : "Parado");
			textoModo.Text = aCom ? "" : TextoModo(sModo);
			textoAlarme.Text = aCom ? "valores congelados" : (p > 0 ? t : "Fonte: " + TextoFonte(sFonte));
		}

	}
}
