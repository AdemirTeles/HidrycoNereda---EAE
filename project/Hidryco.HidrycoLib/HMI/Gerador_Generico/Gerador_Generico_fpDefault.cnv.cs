/*
 * Hidryco - Gerador_Generico - fpDefault
 * ISA-101: grandezas do gerador, estado do QTA, motor, alarmes (forma + prioridade, piscando ate reconhecer).
 */

using System;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Faceplates.Gerador_Generico
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


		void Linha(Rectangle p1, FreeText p1n, Polygon p2, FreeText p2n, FreeText txt, FreeText normal, bool ativo, int prioridade, bool naoRec)
		{
			Indicador(p1, p1n, p2, p2n, txt, ativo ? prioridade : 0, "ATIVO", naoRec);
			normal.Visible = !ativo;
		}

		void Atualiza()
		{
			string t; bool nr; int p = Prioridade(out t, out nr);
			Indicador(alP1, alP1n, alP2, alP2n, alTxt, p, t, nr);
			Pisca(AlgumNaoRec());
			textoEstado.Text = aCom ? "Sem comunicação - valores congelados" : (operando ? "Em operação" : "Parado") + (p > 0 ? " - em alarme" : "");
			tGB.Text = aCom ? "—" : TextoDisjuntor(sGB);
			tMB.Text = aCom ? "—" : TextoDisjuntor(sMB);
			tModo.Text = aCom ? "—" : TextoModo(sModo);
			tFonte.Text = aCom ? "—" : TextoFonte(sFonte);
			Linha(iComP1, iComP1n, iComP2, iComP2n, iComTxt, nCom, aCom, 1, NaoRec(eCom));
			Linha(iAGCP1, iAGCP1n, iAGCP2, iAGCP2n, iAGCTxt, nAGC, aAGC, 1, NaoRec(eAGC));
			Linha(iPartidaP1, iPartidaP1n, iPartidaP2, iPartidaP2n, iPartidaTxt, nPartida, aPartida, 1, NaoRec(ePartida));
			Linha(iMotorP1, iMotorP1n, iMotorP2, iMotorP2n, iMotorTxt, nMotor, aMotor, 1, NaoRec(eMotor));
			Linha(iEmergenciaP1, iEmergenciaP1n, iEmergenciaP2, iEmergenciaP2n, iEmergenciaTxt, nEmergencia, aEmergencia, 1, NaoRec(eEmergencia));
			Linha(iDisjuntorP1, iDisjuntorP1n, iDisjuntorP2, iDisjuntorP2n, iDisjuntorTxt, nDisjuntor, aDisjuntor, 1, NaoRec(eDisjuntor));
			Linha(iFaltaRedeP1, iFaltaRedeP1n, iFaltaRedeP2, iFaltaRedeP2n, iFaltaRedeTxt, nFaltaRede, aFaltaRede, 2, NaoRec(eFaltaRede));
			Linha(iForaAutoP1, iForaAutoP1n, iForaAutoP2, iForaAutoP2n, iForaAutoTxt, nForaAuto, aForaAuto, 2, NaoRec(eForaAuto));
			Comandos();
		}

		// Reconhece os alarmes do gerador no EAE (os do AGC: botao Reconhecer no AGC)
		void BtnResetClick(object sender, EventArgs e) { FireEvent_E_RESET(true); FireEvent_E_RESET(false); }

		// ---- comandos basicos do AGC (v1.1)
		static bool B(object v) { return v != null && Convert.ToBoolean(v); }
		short pendente;
		void PermChanged(object s, ValueChangedEventArgs e) { Comandos(); }
		void Comandos()
		{
			bool ativo = B(xCmdAtivo.Value);
			btnAuto.Enabled = !ativo && B(xPAuto.Value);
			btnSemi.Enabled = !ativo && B(xPSemi.Value);
			btnPartir.Enabled = !ativo && B(xPPartir.Value);
			btnParar.Enabled = !ativo && B(xPParar.Value);
			btnRecAGC.Enabled = !ativo && B(xPRec.Value);
			tCmdInfo.Text = aCom ? "Sem comunicação com o AGC: comandos bloqueados." : ativo ? "Enviando comando ao AGC..." : "Partir e parar só em semiautomático.";
		}
		void BtnCmdClick(object sender, EventArgs e)
		{
			string t;
			if (sender == btnAuto) { pendente = 1; t = "Colocar o AGC em AUTOMÁTICO?\r\nO gerador volta a assumir sozinho na falta de rede."; }
			else if (sender == btnSemi) { pendente = 2; t = "Colocar o AGC em SEMIAUTOMÁTICO?\r\nO gerador deixa de assumir sozinho na falta de rede."; }
			else if (sender == btnPartir) { pendente = 3; t = "PARTIR o gerador?"; }
			else if (sender == btnParar) { pendente = 4; t = "PARAR o gerador?\r\nCom a planta no gerador, a carga do QTA é desligada."; }
			else { pendente = 5; t = "Reconhecer os alarmes no AGC?"; }
			confTexto.Text = t;
			Confirmacao(true);
		}
		void Confirmacao(bool v) { confFundo.Visible = v; confTexto.Visible = v; btnConfirmar.Visible = v; btnCancelar.Visible = v; }
		void BtnConfirmarClick(object sender, EventArgs e) { Confirmacao(false); if (pendente > 0) FireEvent_E_COMANDO(pendente); pendente = 0; }
		void BtnCancelarClick(object sender, EventArgs e) { Confirmacao(false); pendente = 0; }

	}
}
