/*
 * Hidryco - UV_Trojan - sCanal2
 * Canal UV 700-UV-02 (Trojan UV3000Plus) desenhado como no P&ID: banco de lampadas nas cores HidrycoColors
 * (ligado = operando, desligado = parado, falha, manutencao = offline/manutencao/fora de remoto, desconhecido = sem comunicacao),
 * lamina d agua (cai com nivel baixo), limpador em movimento durante o ciclo de limpeza, potencia, intensidade e horas.
 */

using System;
using NxtControl.GuiFramework;
using Hidryco.HidrycoLib.SupportClasses;

namespace Hidryco.HidrycoLib.Symbols.UV_Trojan
{
	public partial class sCanal2 : NxtControl.GuiFramework.HMISymbol
	{
		public sCanal2()
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
		bool fCom, op, nb, of, ma, nr, bi, mw;
		short al, po, wg;
		float inten;
		byte eCom, eCri, eMai;
		void XFCOMValueChanged(object s, ValueChangedEventArgs e) { fCom = Convert.ToBoolean(e.Value); Atualiza(); }
		void XOPValueChanged(object s, ValueChangedEventArgs e) { op = Convert.ToBoolean(e.Value); Atualiza(); }
		void XALValueChanged(object s, ValueChangedEventArgs e) { al = Convert.ToInt16(e.Value); Atualiza(); }
		void XNBValueChanged(object s, ValueChangedEventArgs e) { nb = Convert.ToBoolean(e.Value); Atualiza(); }
		void XOFValueChanged(object s, ValueChangedEventArgs e) { of = Convert.ToBoolean(e.Value); Atualiza(); }
		void XMAValueChanged(object s, ValueChangedEventArgs e) { ma = Convert.ToBoolean(e.Value); Atualiza(); }
		void XNRValueChanged(object s, ValueChangedEventArgs e) { nr = Convert.ToBoolean(e.Value); Atualiza(); }
		void XBIValueChanged(object s, ValueChangedEventArgs e) { bi = Convert.ToBoolean(e.Value); Atualiza(); }
		void XPOValueChanged(object s, ValueChangedEventArgs e) { po = Convert.ToInt16(e.Value); Atualiza(); }
		void XINValueChanged(object s, ValueChangedEventArgs e) { inten = Convert.ToSingle(e.Value); Atualiza(); }
		void XMWValueChanged(object s, ValueChangedEventArgs e) { mw = Convert.ToBoolean(e.Value); Atualiza(); }
		void XWGValueChanged(object s, ValueChangedEventArgs e) { wg = Convert.ToInt16(e.Value); Atualiza(); }
		void XECOMValueChanged(object s, ValueChangedEventArgs e) { eCom = Convert.ToByte(e.Value); Atualiza(); }
		void XECRIValueChanged(object s, ValueChangedEventArgs e) { eCri = Convert.ToByte(e.Value); Atualiza(); }
		void XEMAIValueChanged(object s, ValueChangedEventArgs e) { eMai = Convert.ToByte(e.Value); Atualiza(); }
		int horas;
		void XHOValueChanged(object s, ValueChangedEventArgs e) { horas = Convert.ToInt32(e.Value); Atualiza(); }

		// 0 parado, 1 operando, 2 falha, 3 manutencao, 4 sem comunicacao
		int Estado()
		{
			if (fCom) return 4;
			if (of || ma || nr) return 3;
			if (nb || bi || al >= 2) return 2;
			return op ? 1 : 0;
		}
		static NxtControl.Drawing.Color Cor(int a)
		{
			switch (a)
			{
				case 0: return HidrycoColors.Desligado;
				case 1: return HidrycoColors.Ligado;
				case 2: return HidrycoColors.Falha;
				case 3: return HidrycoColors.Manutencao;
				default: return HidrycoColors.Unknown;
			}
		}
		static readonly string[] ESTADO = { "PARADO", "OPERANDO", "FALHA", "MANUTENÇÃO", "SEM COMUNICAÇÃO" };
		bool Limpando() { return !fCom && (((ushort)wg & 0x0004) != 0); }
		int Prioridade(out bool naoRec)
		{
			if (fCom) { naoRec = NaoRec(eCom); return 1; }
			if (al == 3 || nb) { naoRec = NaoRec(eCri); return 1; }
			if (al == 2 || bi) { naoRec = NaoRec(eMai); return 2; }
			if (al == 1) { naoRec = false; return 2; }
			naoRec = false; return 0;
		}

		void Atualiza()
		{
			bool nr2; int p = Prioridade(out nr2);
			Indicador(alP1, alP1n, alP2, alP2n, alTxt, p, "", nr2);
			bool limp = Limpando();
			Pisca((p > 0 && nr2) || limp);
			int a = Estado();
			NxtControl.Drawing.Color c = Cor(a);
			modTopo.BrushColor = c; modHaste1.BrushColor = c; modHaste2.BrushColor = c;
			lamp1.BrushColor = c; lamp2.BrushColor = c; lamp3.BrushColor = c; lamp4.BrushColor = c; lamp5.BrushColor = c; lamp6.BrushColor = c;
			bool baixo = !fCom && nb;
			agua1.Bounds = baixo ? new NxtControl.Drawing.RectF(6F, 84F, 274F, 18F) : new NxtControl.Drawing.RectF(6F, 46F, 274F, 56F);
			tNivel.Visible = baixo;
			limpador.Location = new NxtControl.Drawing.PointF((limp && !fase) ? 220F : 124F, 44F);
			limpador.Visible = !fCom;
			falhaCom.Visible = fCom;
			textoManut.Visible = a == 3;
			tEstado.Text = ESTADO[a] + (limp ? "  -  LIMPEZA EM CICLO" : "");
			tInfo.Text = fCom ? "????" : ("Potência " + po.ToString() + " %   Intensidade " + inten.ToString("0.0") + (mw ? " mW/cm²" : " %") + "   Lâmpadas " + horas.ToString() + " h");
		}

	}
}
