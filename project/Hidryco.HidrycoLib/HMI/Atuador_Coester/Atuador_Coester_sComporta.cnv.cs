/*
 * Hidryco - Atuador_Coester 2.2 - sComporta
 * ISA-101: comporta com atuador (cores do estado na placa e na moldura), letra do modo (A/M), estado em texto e indicador de alarme.
 */
using System;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Symbols.Atuador_Coester
{
	public partial class sComporta : NxtControl.GuiFramework.HMISymbol
	{
		public sComporta()
		{
			InitializeComponent();
			Atualiza();
		}

		// Indicador de alarme (ISA-101): forma + numero de prioridade; escondido quando normal; pisca se nao reconhecido
		bool fase = true;
		System.Timers.Timer tPisca;
		static bool NaoRec(byte estadoAlarme) { return estadoAlarme >= 2 && estadoAlarme <= 4; }

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
		short anim;
		bool auto, rem, loc, desl, fCom, fPos, fAtu;
		byte eCom, ePos, eAtu;
		void XANIMValueChanged(object s, ValueChangedEventArgs e) { anim = Convert.ToInt16(e.Value); Atualiza(); }
		void XAUTOValueChanged(object s, ValueChangedEventArgs e) { auto = Convert.ToBoolean(e.Value); Atualiza(); }
		void XREMValueChanged(object s, ValueChangedEventArgs e) { rem = Convert.ToBoolean(e.Value); Atualiza(); }
		void XLOCValueChanged(object s, ValueChangedEventArgs e) { loc = Convert.ToBoolean(e.Value); Atualiza(); }
		void XDESLValueChanged(object s, ValueChangedEventArgs e) { desl = Convert.ToBoolean(e.Value); Atualiza(); }
		void XFCOMValueChanged(object s, ValueChangedEventArgs e) { fCom = Convert.ToBoolean(e.Value); Atualiza(); }
		void XFPOSValueChanged(object s, ValueChangedEventArgs e) { fPos = Convert.ToBoolean(e.Value); Atualiza(); }
		void XFATUValueChanged(object s, ValueChangedEventArgs e) { fAtu = Convert.ToBoolean(e.Value); Atualiza(); }
		void XECOMValueChanged(object s, ValueChangedEventArgs e) { eCom = Convert.ToByte(e.Value); Atualiza(); }
		void XEPOSValueChanged(object s, ValueChangedEventArgs e) { ePos = Convert.ToByte(e.Value); Atualiza(); }
		void XEATUValueChanged(object s, ValueChangedEventArgs e) { eAtu = Convert.ToByte(e.Value); Atualiza(); }

		// Cores no padrao dos motores e valvulas do projeto (HidrycoColors): aberta = vermelho (Ligado), fechada = verde (Desligado),
		// falha ou sem comunicacao = amarelo (Falha); intermediaria parada = meio verde / meio vermelho;
		// abrindo = placa vermelho fixo e moldura piscando; fechando = placa verde fixo e moldura piscando.
		static readonly NxtControl.Drawing.Color ABERTA = Hidryco.HidrycoLib.SupportClasses.HidrycoColors.Ligado;
		static readonly NxtControl.Drawing.Color FECHADA = Hidryco.HidrycoLib.SupportClasses.HidrycoColors.Desligado;
		static readonly NxtControl.Drawing.Color FALHA = Hidryco.HidrycoLib.SupportClasses.HidrycoColors.Falha;

		// STS_ANIMACAO: 0 fechada, 1 aberta, 2 falha, 3 intermediaria parada, 4 abrindo, 5 fechando
		static string Texto(short a) { switch (a) { case 0: return "FECHADA"; case 1: return "ABERTA"; case 4: return "ABRINDO"; case 5: return "FECHANDO"; case 2: return "FALHA"; } return "PARADA"; }

		void Atualiza()
		{
			int p = (fCom || fAtu) ? 1 : (fPos ? 2 : 0);
			bool nr = (fCom && NaoRec(eCom)) || (fAtu && NaoRec(eAtu)) || (fPos && NaoRec(ePos));
			bool mostra = !nr || fase;
			alP1.Visible = p == 1 && mostra; alP1n.Visible = p == 1 && mostra;
			alP2.Visible = p == 2 && mostra; alP2n.Visible = p == 2 && mostra;
			alTxt.Visible = false;
			bool movendo = !fCom && (anim == 4 || anim == 5);
			Pisca(nr || movendo);
			NxtControl.Drawing.Color e, d;
			if (fCom || anim == 2) { e = FALHA; d = FALHA; }
			else if (anim == 1) { e = ABERTA; d = ABERTA; }
			else if (anim == 0) { e = FECHADA; d = FECHADA; }
			else if (anim == 4) { e = ABERTA; d = fase ? ABERTA : FECHADA; }
			else if (anim == 5) { e = FECHADA; d = fase ? FECHADA : ABERTA; }
			else { e = FECHADA; d = ABERTA; }
			corpoE.BrushColor = e;
			corpoD.BrushColor = d;
			// caixa R/L e A/M no padrao dos motores; o estado fora do normal (L, D, M) fica em preto, o normal (R, A) em cinza
			tRem.Text = fCom ? "?" : (rem ? "R" : (desl ? "D" : (loc ? "L" : "?")));
			tRem.Color = (!fCom && rem) ? NORMAL : FORA;
			tModo.Text = auto ? "A" : "M";
			tModo.Color = auto ? NORMAL : FORA;
			tPos.Text = fCom ? "????" : Texto(anim);
		}

		static readonly NxtControl.Drawing.Color NORMAL = new NxtControl.Drawing.Color("LabelTextColor");
		static readonly NxtControl.Drawing.Color FORA = new NxtControl.Drawing.Color(0, 0, 0);
	}
}
