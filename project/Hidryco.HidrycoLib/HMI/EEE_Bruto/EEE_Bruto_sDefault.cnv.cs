/*
 * Hidryco - EEE_Bruto - sDefault
 * ISA-101: elevatoria - estado em texto, bombas pedidas/ligadas, principal, nivel e indicador de alarme.
 */

using System;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Symbols.EEE_Bruto
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
		short estado;
		ushort necessidade, ligadas, principal, segunda, rh, rm, rs;
		bool fRecalque, boiaH, fBoiaL, buffer, boiaL, nivelBaixo;
		byte eRecalque, eNivelAlto, eFalhaBoia;
		void EstadoValueChanged(object s, ValueChangedEventArgs e) { estado = Convert.ToInt16(e.Value); Atualiza(); }
		void NecessidadeValueChanged(object s, ValueChangedEventArgs e) { necessidade = Convert.ToUInt16(e.Value); Atualiza(); }
		void LigadasValueChanged(object s, ValueChangedEventArgs e) { ligadas = Convert.ToUInt16(e.Value); Atualiza(); }
		void PrincipalValueChanged(object s, ValueChangedEventArgs e) { principal = Convert.ToUInt16(e.Value); Atualiza(); }
		void SegundaValueChanged(object s, ValueChangedEventArgs e) { segunda = Convert.ToUInt16(e.Value); Atualiza(); }
		void RhValueChanged(object s, ValueChangedEventArgs e) { rh = Convert.ToUInt16(e.Value); Atualiza(); }
		void RmValueChanged(object s, ValueChangedEventArgs e) { rm = Convert.ToUInt16(e.Value); Atualiza(); }
		void RsValueChanged(object s, ValueChangedEventArgs e) { rs = Convert.ToUInt16(e.Value); Atualiza(); }
		void RecalqueValueChanged(object s, ValueChangedEventArgs e) { fRecalque = Convert.ToBoolean(e.Value); Atualiza(); }
		void BoiaHValueChanged(object s, ValueChangedEventArgs e) { boiaH = Convert.ToBoolean(e.Value); Atualiza(); }
		void BoiaLValueChanged(object s, ValueChangedEventArgs e) { boiaL = Convert.ToBoolean(e.Value); Atualiza(); }
		void FalhaBoiaValueChanged(object s, ValueChangedEventArgs e) { fBoiaL = Convert.ToBoolean(e.Value); Atualiza(); }
		void NivelBaixoValueChanged(object s, ValueChangedEventArgs e) { nivelBaixo = Convert.ToBoolean(e.Value); Atualiza(); }
		void BufferValueChanged(object s, ValueChangedEventArgs e) { buffer = Convert.ToBoolean(e.Value); Atualiza(); }
		void ERecalqueValueChanged(object s, ValueChangedEventArgs e) { eRecalque = Convert.ToByte(e.Value); Atualiza(); }
		void ENivelAltoValueChanged(object s, ValueChangedEventArgs e) { eNivelAlto = Convert.ToByte(e.Value); Atualiza(); }
		void EFalhaBoiaValueChanged(object s, ValueChangedEventArgs e) { eFalhaBoia = Convert.ToByte(e.Value); Atualiza(); }

		static readonly string[] ESTADOS = { "Parada", "Bombeando", "Segurando: HH do tanque do Nereda", "Operação pelas boias (LIT-03 em falha)", "Falha de recalque - reset", "Nível baixo (LSL): bombas bloqueadas", "Automático desabilitado", "Emergência acionada" };
		string TextoEstado() { return estado >= 0 && estado < ESTADOS.Length ? ESTADOS[estado] : "-"; }
		static string Bomba(ushort b) { return b >= 1 && b <= 3 ? "BS-0" + b.ToString() : "-"; }

		// Alarme de maior prioridade: recalque e nivel alto = prioridade 1 (Alarm); defeito da LSL = prioridade 2 (Warning)
		int Prioridade(out string texto, out bool naoRec)
		{
			if (fRecalque) { texto = "FALHA DE RECALQUE"; naoRec = NaoRec(eRecalque); return 1; }
			if (boiaH) { texto = "NÍVEL ALTO (LSH)"; naoRec = NaoRec(eNivelAlto); return 1; }
			if (fBoiaL) { texto = "DEFEITO DA LSL"; naoRec = NaoRec(eFalhaBoia); return 2; }
			texto = ""; naoRec = false; return 0;
		}
		bool AlgumNaoRec() { return NaoRec(eRecalque) || NaoRec(eNivelAlto) || NaoRec(eFalhaBoia); }


		void Atualiza()
		{
			string t; bool nr; int p = Prioridade(out t, out nr);
			// no simbolo o texto e curto (cabe ao lado da forma)
			string curto = fRecalque ? "RECALQUE" : (boiaH ? "NÍVEL ALTO" : (fBoiaL ? "BOIA LSL" : ""));
			Indicador(alP1, alP1n, alP2, alP2n, alTxt, p, curto, nr);
			Pisca(AlgumNaoRec());
			textoEstado.Text = TextoEstado();
			textoBombas.Text = "Bombas: " + ligadas.ToString() + " ligada(s) / " + necessidade.ToString() + " pedida(s)";
			textoPrincipal.Text = "Principal " + Bomba(principal);
		}

	}
}
