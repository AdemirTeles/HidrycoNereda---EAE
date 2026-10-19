/*
 * Hidryco - UV_Trojan - fpDefault
 * UV: valores do sistema, canais (potencia, intensidade, horas), limpeza, alarme e reconhecimento.
 */

using System;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Faceplates.UV_Trojan
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

		// ---- dados recebidos da logica (Execute invisiveis)
		bool fCom, aMen, aMai, aCri, aLim, sCom, doseBx, cIns, c1Op, c2Op, c1Nb, c2Nb, c1Of, c2Of, c1Ma, c2Ma, c1Nr, c2Nr, lCic, uviMw;
		float vaz, dose, uvt, c1In, c2In;
		short c1Al, c2Al, c1Po, c2Po, lc1, lc2;
		byte eCom, eCri, eMai, eMen, eLim;
		void XFCOMValueChanged(object s, ValueChangedEventArgs e) { fCom = Convert.ToBoolean(e.Value); Atualiza(); }
		void XAMENValueChanged(object s, ValueChangedEventArgs e) { aMen = Convert.ToBoolean(e.Value); Atualiza(); }
		void XAMAIValueChanged(object s, ValueChangedEventArgs e) { aMai = Convert.ToBoolean(e.Value); Atualiza(); }
		void XACRIValueChanged(object s, ValueChangedEventArgs e) { aCri = Convert.ToBoolean(e.Value); Atualiza(); }
		void XALIMValueChanged(object s, ValueChangedEventArgs e) { aLim = Convert.ToBoolean(e.Value); Atualiza(); }
		void XSCOMValueChanged(object s, ValueChangedEventArgs e) { sCom = Convert.ToBoolean(e.Value); Atualiza(); }
		void XDBXValueChanged(object s, ValueChangedEventArgs e) { doseBx = Convert.ToBoolean(e.Value); Atualiza(); }
		void XCINSValueChanged(object s, ValueChangedEventArgs e) { cIns = Convert.ToBoolean(e.Value); Atualiza(); }
		void XVAZValueChanged(object s, ValueChangedEventArgs e) { vaz = Convert.ToSingle(e.Value); Atualiza(); }
		void XDOSEValueChanged(object s, ValueChangedEventArgs e) { dose = Convert.ToSingle(e.Value); Atualiza(); }
		void XUVTValueChanged(object s, ValueChangedEventArgs e) { uvt = Convert.ToSingle(e.Value); Atualiza(); }
		void XC1OPValueChanged(object s, ValueChangedEventArgs e) { c1Op = Convert.ToBoolean(e.Value); Atualiza(); }
		void XC2OPValueChanged(object s, ValueChangedEventArgs e) { c2Op = Convert.ToBoolean(e.Value); Atualiza(); }
		void XC1ALValueChanged(object s, ValueChangedEventArgs e) { c1Al = Convert.ToInt16(e.Value); Atualiza(); }
		void XC2ALValueChanged(object s, ValueChangedEventArgs e) { c2Al = Convert.ToInt16(e.Value); Atualiza(); }
		void XC1NBValueChanged(object s, ValueChangedEventArgs e) { c1Nb = Convert.ToBoolean(e.Value); Atualiza(); }
		void XC2NBValueChanged(object s, ValueChangedEventArgs e) { c2Nb = Convert.ToBoolean(e.Value); Atualiza(); }
		void XC1OFValueChanged(object s, ValueChangedEventArgs e) { c1Of = Convert.ToBoolean(e.Value); Atualiza(); }
		void XC2OFValueChanged(object s, ValueChangedEventArgs e) { c2Of = Convert.ToBoolean(e.Value); Atualiza(); }
		void XC1MAValueChanged(object s, ValueChangedEventArgs e) { c1Ma = Convert.ToBoolean(e.Value); Atualiza(); }
		void XC2MAValueChanged(object s, ValueChangedEventArgs e) { c2Ma = Convert.ToBoolean(e.Value); Atualiza(); }
		void XC1NRValueChanged(object s, ValueChangedEventArgs e) { c1Nr = Convert.ToBoolean(e.Value); Atualiza(); }
		void XC2NRValueChanged(object s, ValueChangedEventArgs e) { c2Nr = Convert.ToBoolean(e.Value); Atualiza(); }
		void XLCICValueChanged(object s, ValueChangedEventArgs e) { lCic = Convert.ToBoolean(e.Value); Atualiza(); }
		void XECOMValueChanged(object s, ValueChangedEventArgs e) { eCom = Convert.ToByte(e.Value); Atualiza(); }
		void XECRIValueChanged(object s, ValueChangedEventArgs e) { eCri = Convert.ToByte(e.Value); Atualiza(); }
		void XEMAIValueChanged(object s, ValueChangedEventArgs e) { eMai = Convert.ToByte(e.Value); Atualiza(); }
		void XEMENValueChanged(object s, ValueChangedEventArgs e) { eMen = Convert.ToByte(e.Value); Atualiza(); }
		void XELIMValueChanged(object s, ValueChangedEventArgs e) { eLim = Convert.ToByte(e.Value); Atualiza(); }
		void XC1POValueChanged(object s, ValueChangedEventArgs e) { c1Po = Convert.ToInt16(e.Value); Atualiza(); }
		void XC2POValueChanged(object s, ValueChangedEventArgs e) { c2Po = Convert.ToInt16(e.Value); Atualiza(); }
		void XC1INValueChanged(object s, ValueChangedEventArgs e) { c1In = Convert.ToSingle(e.Value); Atualiza(); }
		void XC2INValueChanged(object s, ValueChangedEventArgs e) { c2In = Convert.ToSingle(e.Value); Atualiza(); }
		void XUVMWValueChanged(object s, ValueChangedEventArgs e) { uviMw = Convert.ToBoolean(e.Value); Atualiza(); }
		void XLC1ValueChanged(object s, ValueChangedEventArgs e) { lc1 = Convert.ToInt16(e.Value); Atualiza(); }
		void XLC2ValueChanged(object s, ValueChangedEventArgs e) { lc2 = Convert.ToInt16(e.Value); Atualiza(); }

		// Alarme de maior prioridade do UV
		int Prioridade(out string texto, out bool naoRec)
		{
			if (fCom) { texto = "SEM COMUNICAÇÃO COM O PAINEL UV"; naoRec = NaoRec(eCom); return 1; }
			if (aCri) { texto = "ALARME CRÍTICO" + (cIns ? " - CANAIS INSUFICIENTES" : ""); naoRec = NaoRec(eCri); return 1; }
			if (aMai) { texto = "ALARME MAIOR" + (doseBx ? " - DOSE ABAIXO DO ALVO" : ""); naoRec = NaoRec(eMai); return 1; }
			if (aLim) { texto = "ALARME DA LIMPEZA"; naoRec = NaoRec(eLim); return 2; }
			if (aMen) { texto = "ALARME MENOR"; naoRec = NaoRec(eMen); return 2; }
			if (sCom) { texto = "SCC SEM HEARTBEAT DO CLP"; naoRec = false; return 2; }
			texto = ""; naoRec = false; return 0;
		}
		bool AlgumNaoRec() { return (fCom && NaoRec(eCom)) || (aCri && NaoRec(eCri)) || (aMai && NaoRec(eMai)) || (aLim && NaoRec(eLim)) || (aMen && NaoRec(eMen)); }
		static readonly string[] NIVEL_AL = { "", " - alarme menor", " - alarme maior", " - ALARME CRÍTICO" };
		string Canal(bool op, short al, bool nb, bool of, bool ma, bool nr)
		{
			if (fCom) return "????";
			string s = op ? "OPERANDO" : "parado";
			if (nb) s += " - NÍVEL BAIXO";
			if (of) s += " - offline";
			if (ma) s += " - manutenção";
			if (nr) s += " - fora de remoto";
			return s + (al >= 0 && al < NIVEL_AL.Length ? NIVEL_AL[al] : "");
		}

		static readonly NxtControl.Drawing.Color CHEIO = new NxtControl.Drawing.Color(64, 64, 64);
		static readonly NxtControl.Drawing.Color VAZIO = new NxtControl.Drawing.Color(255, 255, 255);
		string Uvi(float v) { return v.ToString("0.0") + (uviMw ? " mW/cm²" : " %"); }

		void Atualiza()
		{
			string t; bool nr; int p = Prioridade(out t, out nr);
			Indicador(alP1, alP1n, alP2, alP2n, alTxt, p, t, nr);
			Pisca(AlgumNaoRec());
			string q = "????";
			vSis1.Text = "Vazão: " + (fCom ? q : vaz.ToString("0")) + "     Dose (RED): " + (fCom ? q : dose.ToString("0.0") + " mJ/cm²");
			vSis2.Text = "UVT: " + (fCom ? q : uvt.ToString("0.0") + " %") + (doseBx && !fCom ? "     DOSE ABAIXO DO ALVO" : "");
			b1.BrushColor = (c1Op && !fCom) ? CHEIO : VAZIO;
			b2.BrushColor = (c2Op && !fCom) ? CHEIO : VAZIO;
			v1a.Text = Canal(c1Op, c1Al, c1Nb, c1Of, c1Ma, c1Nr);
			v2a.Text = Canal(c2Op, c2Al, c2Nb, c2Of, c2Ma, c2Nr);
			v1b.Text = "Potência: " + (fCom ? q : c1Po.ToString() + " %") + "     Intensidade: " + (fCom ? q : Uvi(c1In));
			v2b.Text = "Potência: " + (fCom ? q : c2Po.ToString() + " %") + "     Intensidade: " + (fCom ? q : Uvi(c2In));
			v1c.Text = "Horas das lâmpadas: " + (fCom ? q : c1Ho.ToString()) + " h";
			v2c.Text = "Horas das lâmpadas: " + (fCom ? q : c2Ho.ToString()) + " h";
			vLimp.Text = fCom ? q : ((lCic ? "EM CICLO" : "parada") + "     ciclos: grupo 1 = " + lc1.ToString() + ", grupo 2 = " + lc2.ToString() + (aLim ? "     ALARME" : ""));
		}
		int c1Ho, c2Ho;
		void XC1HOValueChanged(object s, ValueChangedEventArgs e) { c1Ho = Convert.ToInt32(e.Value); Atualiza(); }
		void XC2HOValueChanged(object s, ValueChangedEventArgs e) { c2Ho = Convert.ToInt32(e.Value); Atualiza(); }

		void BtnResetClick(object sender, EventArgs e) { FireEvent_E_RESET(true); FireEvent_E_RESET(false); }

	}
}
