/*
 * Hidryco - Motor_Inovaisa - sGrade
 * Grade mecanizada: motor (vermelho = ligado, verde = parado, cinza = sem comunicacao), sentido e alarme.
 */

using System;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Symbols.Motor_Inovaisa
{
	public partial class sGrade : NxtControl.GuiFramework.HMISymbol
	{
		public sGrade()
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
		short fun;
		bool lig, rev, fal, sob, com, tRev, tSob;
		byte eFal, eSob;
		void XFUNValueChanged(object s, ValueChangedEventArgs e) { fun = Convert.ToInt16(e.Value); Atualiza(); }
		void XLIGValueChanged(object s, ValueChangedEventArgs e) { lig = Convert.ToBoolean(e.Value); Atualiza(); }
		void XREVValueChanged(object s, ValueChangedEventArgs e) { rev = Convert.ToBoolean(e.Value); Atualiza(); }
		void XFALValueChanged(object s, ValueChangedEventArgs e) { fal = Convert.ToBoolean(e.Value); Atualiza(); }
		void XSOBValueChanged(object s, ValueChangedEventArgs e) { sob = Convert.ToBoolean(e.Value); Atualiza(); }
		void XCOMValueChanged(object s, ValueChangedEventArgs e) { com = Convert.ToBoolean(e.Value); Atualiza(); }
		void XTREVValueChanged(object s, ValueChangedEventArgs e) { tRev = Convert.ToBoolean(e.Value); Atualiza(); }
		void XTSOBValueChanged(object s, ValueChangedEventArgs e) { tSob = Convert.ToBoolean(e.Value); Atualiza(); }
		void XEFALValueChanged(object s, ValueChangedEventArgs e) { eFal = Convert.ToByte(e.Value); Atualiza(); }
		void XESOBValueChanged(object s, ValueChangedEventArgs e) { eSob = Convert.ToByte(e.Value); Atualiza(); }

		int Prioridade(out string texto, out bool naoRec)
		{
			if (!com) { texto = ""; naoRec = false; return 0; }
			if (fal) { texto = "FALHA DO MOTOR"; naoRec = NaoRec(eFal); return 1; }
			if (sob) { texto = "SOBRETORQUE"; naoRec = NaoRec(eSob); return 1; }
			texto = ""; naoRec = false; return 0;
		}
		bool AlgumNaoRec() { return (fal && NaoRec(eFal)) || (sob && NaoRec(eSob)); }
		string Estado()
		{
			if (!com) return "SEM COMUNICAÇÃO";
			if (fal) return "FALHA";
			if (rev) return "REVERSO";
			if (lig) return tRev ? "AVANTE" : "FUNCIONANDO";
			return "PARADO";
		}
		// paleta da biblioteca (HidrycoColors): vermelho = ligado, verde = desligado, cinza = sem comunicacao
		static readonly NxtControl.Drawing.Color LIGADO = Hidryco.HidrycoLib.SupportClasses.HidrycoColors.Ligado;
		static readonly NxtControl.Drawing.Color PARADO = Hidryco.HidrycoLib.SupportClasses.HidrycoColors.Desligado;
		static readonly NxtControl.Drawing.Color SEMCOM = Hidryco.HidrycoLib.SupportClasses.HidrycoColors.Unknown;
		NxtControl.Drawing.Color Cor() { return !com ? SEMCOM : (fal ? Hidryco.HidrycoLib.SupportClasses.HidrycoColors.Falha : (lig ? LIGADO : PARADO)); }

		void Atualiza()
		{
			string t; bool nr; int p = Prioridade(out t, out nr);
			Indicador(alP1, alP1n, alP2, alP2n, alTxt, p, "", nr);
			Pisca(AlgumNaoRec());
			motor.Brush = new NxtControl.Drawing.Brush(Cor());
			tSent.Text = !com ? "" : (rev ? "RE" : (lig ? "AV" : ""));
			txSob.Text = sob ? "SOBRETORQUE" : "";
			rastelo.Visible = com && lig;
		}

	}
}
