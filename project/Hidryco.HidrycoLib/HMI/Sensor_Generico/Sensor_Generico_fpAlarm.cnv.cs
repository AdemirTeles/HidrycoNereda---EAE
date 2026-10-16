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


		void UnidadeValueChanged(object sender, ValueChangedEventArgs e)
		{
			string u = Convert.ToString(e.Value);
			string suf = u != null && u.Length > 0 ? " " + u : "";
			spHH.Suffix = suf; spH.Suffix = suf; spL.Suffix = suf; spLL.Suffix = suf;
		}

		void BtnResetClick(object sender, EventArgs e)
		{
			FireEvent_E_RESET(true);
			FireEvent_E_RESET(false);
		}

	}
}
