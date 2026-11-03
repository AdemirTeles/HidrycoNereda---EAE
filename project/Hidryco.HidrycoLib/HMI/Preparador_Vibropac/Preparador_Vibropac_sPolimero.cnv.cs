/*
 * Hidryco - Preparador_Vibropac - sPolimero
 * ISA-101: preparador de polimero e dosadoras DO-01/DO-02 (M4/M5), estado e alarme.
 */

using System;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Symbols.Preparador_Vibropac
{
	public partial class sPolimero : NxtControl.GuiFramework.HMISymbol
	{
		public sPolimero()
		{
			InitializeComponent();
			hab = true;   // ate a logica responder, nao mostra "desabilitado"
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
		bool fCom, hab, auto, ciclo, cMan, aSkid, emg, fMot, disp, dos, silo, fAg, vs01, res;
		byte eCom, eEmg, eSkd, eMot, eSil, eAgu, eVaz;
		short m1, m2, m3, m4, m5, nivP, aVz;
		float vAg, vPo;
		void XFCOMValueChanged(object s, ValueChangedEventArgs e) { fCom = Convert.ToBoolean(e.Value); Atualiza(); }
		void XHABValueChanged(object s, ValueChangedEventArgs e) { hab = Convert.ToBoolean(e.Value); Atualiza(); }
		void XAUTOValueChanged(object s, ValueChangedEventArgs e) { auto = Convert.ToBoolean(e.Value); Atualiza(); }
		void XCICValueChanged(object s, ValueChangedEventArgs e) { ciclo = Convert.ToBoolean(e.Value); Atualiza(); }
		void XCMANValueChanged(object s, ValueChangedEventArgs e) { cMan = Convert.ToBoolean(e.Value); Atualiza(); }
		void XALSValueChanged(object s, ValueChangedEventArgs e) { aSkid = Convert.ToBoolean(e.Value); Atualiza(); }
		void XEMGValueChanged(object s, ValueChangedEventArgs e) { emg = Convert.ToBoolean(e.Value); Atualiza(); }
		void XFMOTValueChanged(object s, ValueChangedEventArgs e) { fMot = Convert.ToBoolean(e.Value); Atualiza(); }
		void XDISPValueChanged(object s, ValueChangedEventArgs e) { disp = Convert.ToBoolean(e.Value); Atualiza(); }
		void XECOMValueChanged(object s, ValueChangedEventArgs e) { eCom = Convert.ToByte(e.Value); Atualiza(); }
		void XEEMGValueChanged(object s, ValueChangedEventArgs e) { eEmg = Convert.ToByte(e.Value); Atualiza(); }
		void XESKDValueChanged(object s, ValueChangedEventArgs e) { eSkd = Convert.ToByte(e.Value); Atualiza(); }
		void XEMOTValueChanged(object s, ValueChangedEventArgs e) { eMot = Convert.ToByte(e.Value); Atualiza(); }
		void XM1ValueChanged(object s, ValueChangedEventArgs e) { m1 = Convert.ToInt16(e.Value); Atualiza(); }
		void XM2ValueChanged(object s, ValueChangedEventArgs e) { m2 = Convert.ToInt16(e.Value); Atualiza(); }
		void XM3ValueChanged(object s, ValueChangedEventArgs e) { m3 = Convert.ToInt16(e.Value); Atualiza(); }
		void XM4ValueChanged(object s, ValueChangedEventArgs e) { m4 = Convert.ToInt16(e.Value); Atualiza(); }
		void XM5ValueChanged(object s, ValueChangedEventArgs e) { m5 = Convert.ToInt16(e.Value); Atualiza(); }
		void XDOSValueChanged(object s, ValueChangedEventArgs e) { dos = Convert.ToBoolean(e.Value); Atualiza(); }
		void XSILOValueChanged(object s, ValueChangedEventArgs e) { silo = Convert.ToBoolean(e.Value); Atualiza(); }
		void XNIVPValueChanged(object s, ValueChangedEventArgs e) { nivP = Convert.ToInt16(e.Value); Atualiza(); }
		void XVAGValueChanged(object s, ValueChangedEventArgs e) { vAg = Convert.ToSingle(e.Value); Atualiza(); }
		void XVPOValueChanged(object s, ValueChangedEventArgs e) { vPo = Convert.ToSingle(e.Value); Atualiza(); }
		void XFAGValueChanged(object s, ValueChangedEventArgs e) { fAg = Convert.ToBoolean(e.Value); Atualiza(); }
		void XAVZValueChanged(object s, ValueChangedEventArgs e) { aVz = Convert.ToInt16(e.Value); Atualiza(); }
		void XVS01ValueChanged(object s, ValueChangedEventArgs e) { vs01 = Convert.ToBoolean(e.Value); Atualiza(); }
		void XRESValueChanged(object s, ValueChangedEventArgs e) { res = Convert.ToBoolean(e.Value); Atualiza(); }
		void XESILValueChanged(object s, ValueChangedEventArgs e) { eSil = Convert.ToByte(e.Value); Atualiza(); }
		void XEAGUValueChanged(object s, ValueChangedEventArgs e) { eAgu = Convert.ToByte(e.Value); Atualiza(); }
		void XEVAZValueChanged(object s, ValueChangedEventArgs e) { eVaz = Convert.ToByte(e.Value); Atualiza(); }

		int Prioridade(out string texto, out bool naoRec)
		{
			if (!hab) { texto = ""; naoRec = false; return 0; }
			if (fCom) { texto = "SEM COMUNICAÇÃO"; naoRec = NaoRec(eCom); return 2; }
			if (emg) { texto = "EMERGÊNCIA ACIONADA"; naoRec = NaoRec(eEmg); return 1; }
			if (fMot) { texto = "FALHA DE MOTOR"; naoRec = NaoRec(eMot); return 1; }
			if (aSkid) { texto = "ALARME NO SKID"; naoRec = NaoRec(eSkd); return 1; }
			if (fAg) { texto = "FALTA D'ÁGUA"; naoRec = NaoRec(eAgu); return 1; }
			if (aVz != 0) { texto = aVz == 1 ? "VAZÃO DE POLÍMERO BAIXA" : "VAZÃO DE POLÍMERO ALTA"; naoRec = NaoRec(eVaz); return 1; }
			if (silo) { texto = "SILO DE PÓ COM NÍVEL BAIXO"; naoRec = NaoRec(eSil); return 2; }
			texto = ""; naoRec = false; return 0;
		}
		bool AlgumNaoRec() { return hab && ((fCom && NaoRec(eCom)) || (emg && NaoRec(eEmg)) || (fMot && NaoRec(eMot)) || (aSkid && NaoRec(eSkd)) || (fAg && NaoRec(eAgu)) || (aVz != 0 && NaoRec(eVaz)) || (silo && NaoRec(eSil))); }
		static readonly string[] NOMES_M = { "Agitador mistura M1", "Agitador maturação M2", "Dosador volumétrico M3", "Bomba dosadora M4", "Bomba dosadora M5" };
		static string Mot(short v, bool reverso) { if (reverso) { switch (v) { case 0: return "parado"; case 1: return "avante"; case 2: return "reverso"; case 3: return "FALHA"; } } else { switch (v) { case 0: return "parado"; case 1: return "funcionando"; case 2: return "FALHA"; } } return "?"; }
		static string Nivel(short v) { switch (v) { case 0: return "muito baixo"; case 1: return "baixo"; case 2: return "alto"; case 3: return "muito alto"; } return "?"; }
		string Estado()
		{
			if (!hab) return "DESABILITADO (FUTURO)";
			if (fCom) return "SEM COMUNICAÇÃO";
			return (ciclo ? "CICLO LIGADO" : "ciclo desligado") + (auto ? "  (automático)" : "  (MANUAL)");
		}


		// Cores de estado da biblioteca (HidrycoColors): ligado, desligado, falha; sem comunicacao/desabilitado = desconhecido
		NxtControl.Drawing.Color CorMotor(short v, bool reverso)
		{
			if (!hab || fCom) return Hidryco.HidrycoLib.SupportClasses.HidrycoColors.Unknown;
			if (reverso) return v == 3 ? Hidryco.HidrycoLib.SupportClasses.HidrycoColors.Falha : (v == 1 || v == 2 ? Hidryco.HidrycoLib.SupportClasses.HidrycoColors.Ligado : Hidryco.HidrycoLib.SupportClasses.HidrycoColors.Desligado);
			return v == 2 ? Hidryco.HidrycoLib.SupportClasses.HidrycoColors.Falha : (v == 1 ? Hidryco.HidrycoLib.SupportClasses.HidrycoColors.Ligado : Hidryco.HidrycoLib.SupportClasses.HidrycoColors.Desligado);
		}
		NxtControl.Drawing.Color CorBool(bool ativo)
		{
			if (!hab || fCom) return Hidryco.HidrycoLib.SupportClasses.HidrycoColors.Unknown;
			return ativo ? Hidryco.HidrycoLib.SupportClasses.HidrycoColors.Ligado : Hidryco.HidrycoLib.SupportClasses.HidrycoColors.Desligado;
		}
		static void Pinta(NxtControl.Drawing.Color c, params NxtControl.GuiFramework.FillShape[] formas) { foreach (NxtControl.GuiFramework.FillShape f in formas) f.BrushColor = c; }

		void Atualiza()
		{
			string t; bool nr; int p = Prioridade(out t, out nr);
			Indicador(alP1, alP1n, alP2, alP2n, alTxt, p, "", nr);
			Pisca(AlgumNaoRec());
			bool ok = hab && !fCom;
			l1.Text = Estado();
			l2.Text = !ok ? "" : ((dos ? "DOSANDO" : "sem dosagem") + "   preparo: " + Nivel(nivP));
			tFT2.Text = ok ? vPo.ToString("0") + " %" : "????";
			Pinta(CorMotor(m1, false), fM1);
			Pinta(CorMotor(m2, false), fM2);
			Pinta(CorMotor(m3, false), fM3);
			Pinta(CorBool(vs01), vsE, vsD);
			do1.Animacao = ok ? (int)m4 : 4;
			do2.Animacao = ok ? (int)m5 : 4;
			float h = ok ? 76F * (nivP < 0 ? 0 : Math.Min((short)3, nivP)) / 3F : 0F;
			nivBarra.Bounds = new NxtControl.Drawing.RectF(224F, 168F - h, 8F, h);
		}

	}
}
