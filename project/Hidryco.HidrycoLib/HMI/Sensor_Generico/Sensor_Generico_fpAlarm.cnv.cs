/*
 * Hidryco - Sensor_Generico - fpAlarm
 * ISA-101: alarmes HH/H/L/LL (monitorar, setpoint, tempo, estado com forma+prioridade). Sem histerese; memorizados ate o reset.
 */

using System;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Faceplates.Sensor_Generico
{
	public partial class fpAlarm : NxtControl.GuiFramework.HMIFaceplate
	{
		public fpAlarm()
		{
			InitializeComponent();
			LigaReplica();
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

		bool alHH, alH, alL, alLL;
		byte eHH, eH, eL, eLL;
		void AlHHValueChanged(object sender, ValueChangedEventArgs e) { alHH = Convert.ToBoolean(e.Value); Atualiza(); }
		void EHHValueChanged(object sender, ValueChangedEventArgs e) { eHH = Convert.ToByte(e.Value); Atualiza(); }
		void AlHValueChanged(object sender, ValueChangedEventArgs e) { alH = Convert.ToBoolean(e.Value); Atualiza(); }
		void EHValueChanged(object sender, ValueChangedEventArgs e) { eH = Convert.ToByte(e.Value); Atualiza(); }
		void AlLValueChanged(object sender, ValueChangedEventArgs e) { alL = Convert.ToBoolean(e.Value); Atualiza(); }
		void ELValueChanged(object sender, ValueChangedEventArgs e) { eL = Convert.ToByte(e.Value); Atualiza(); }
		void AlLLValueChanged(object sender, ValueChangedEventArgs e) { alLL = Convert.ToBoolean(e.Value); Atualiza(); }
		void ELLValueChanged(object sender, ValueChangedEventArgs e) { eLL = Convert.ToByte(e.Value); Atualiza(); }

		void Atualiza()
		{
			Indicador(estHHP1, estHHP1n, estHHP2, estHHP2n, estHHTxt, alHH ? 1 : 0, "ATIVO", NaoRec(eHH));
			normalHH.Visible = !alHH;
			Indicador(estHP1, estHP1n, estHP2, estHP2n, estHTxt, alH ? 2 : 0, "ATIVO", NaoRec(eH));
			normalH.Visible = !alH;
			Indicador(estLP1, estLP1n, estLP2, estLP2n, estLTxt, alL ? 2 : 0, "ATIVO", NaoRec(eL));
			normalL.Visible = !alL;
			Indicador(estLLP1, estLLP1n, estLLP2, estLLP2n, estLLTxt, alLL ? 1 : 0, "ATIVO", NaoRec(eLL));
			normalLL.Visible = !alLL;
			Pisca(NaoRec(eHH) || NaoRec(eH) || NaoRec(eL) || NaoRec(eLL));
		}


		// setpoints na unidade do sensor; sensor de nivel (CFG_NIVEL): em % da altura maxima
		string unidadeSp = "";
		bool nivelSp;
		void UnidadeValueChanged(object sender, ValueChangedEventArgs e) { unidadeSp = Convert.ToString(e.Value); SufixoSp(); }
		void NivelValueChanged(object sender, ValueChangedEventArgs e) { nivelSp = Convert.ToBoolean(e.Value); SufixoSp(); }
		void SufixoSp()
		{
			string suf = nivelSp ? " %" : (unidadeSp != null && unidadeSp.Length > 0 ? " " + unidadeSp : "");
			spHH.Suffix = suf; spH.Suffix = suf; spL.Suffix = suf; spLL.Suffix = suf;
		}

		void BtnResetClick(object sender, EventArgs e)
		{
			FireEvent_E_RESET(true);
			FireEvent_E_RESET(false);
		}

		// ---- Replicacao dos ajustes: avisa a tela quando o operador grava faixa, altura, alarmes ou habilitacoes.
		// As telas ESTOCAGEM_LODO e VISAO_GERAL replicam o LIT-900-01/02 no AnalogInput do SludgeHoldingTank1/2 da Nereda.
		void LigaReplica()
		{
			foreach (System.HMI.Symbols.Base.TextBox<float> c in new System.HMI.Symbols.Base.TextBox<float>[] { rRangeMin, rRangeMax, rAltura, spHH, spH, spL, spLL })
				c.OutputValueChanged += Replica;
			foreach (System.HMI.Symbols.Base.CheckButton c in new System.HMI.Symbols.Base.CheckButton[] { habHH, habH, habL, habLL })
				c.OutputValueChanged += Replica;
			foreach (System.HMI.Symbols.Base.TextBox<ushort> c in new System.HMI.Symbols.Base.TextBox<ushort>[] { tempoHH, tempoH, tempoL, tempoLL })
				c.OutputValueChanged += Replica;
		}

		static float ValF(System.HMI.Symbols.Base.TextBox<float> c, object sender, ValueChangedEventArgs e)
		{
			return object.ReferenceEquals(c, sender) ? Convert.ToSingle(e.Value) : Convert.ToSingle(c.Value);
		}

		static bool ValB(System.HMI.Symbols.Base.CheckButton c, object sender, ValueChangedEventArgs e)
		{
			return object.ReferenceEquals(c, sender) ? Convert.ToBoolean(e.Value) : Convert.ToBoolean(c.Value);
		}

		static ushort ValU(System.HMI.Symbols.Base.TextBox<ushort> c, object sender, ValueChangedEventArgs e)
		{
			return object.ReferenceEquals(c, sender) ? Convert.ToUInt16(e.Value) : Convert.ToUInt16(c.Value);
		}

		void Replica(object sender, ValueChangedEventArgs e)
		{
			Hidryco.HidrycoLib.SupportClasses.AjustesSensor a = new Hidryco.HidrycoLib.SupportClasses.AjustesSensor();
			a.Tag = TagName;
			a.RangeMin = ValF(rRangeMin, sender, e);
			a.RangeMax = ValF(rRangeMax, sender, e);
			a.Altura = ValF(rAltura, sender, e);
			a.Nivel = Convert.ToBoolean(xNivel.Value);
			a.Hab[0] = ValB(habHH, sender, e); a.Hab[1] = ValB(habH, sender, e); a.Hab[2] = ValB(habL, sender, e); a.Hab[3] = ValB(habLL, sender, e);
			a.Sp[0] = ValF(spHH, sender, e); a.Sp[1] = ValF(spH, sender, e); a.Sp[2] = ValF(spL, sender, e); a.Sp[3] = ValF(spLL, sender, e);
			a.Tempo[0] = ValU(tempoHH, sender, e); a.Tempo[1] = ValU(tempoH, sender, e); a.Tempo[2] = ValU(tempoL, sender, e); a.Tempo[3] = ValU(tempoLL, sender, e);
			Hidryco.HidrycoLib.SupportClasses.ReplicaSensor.Publicar(a);
		}
	}
}
