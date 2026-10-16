using System;
using Hidryco.HidrycoLib.SupportClasses;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Symbols.Motor_Generico
{
	public partial class sSoprador : HMISymbol
	{

		public sSoprador()
		{
			InitializeComponent();
		}

		void StsAnimacaoValueChanged(object sender, ValueChangedEventArgs e)
		{	
			//soprador1.Animacao = Convert.ToInt16(e.Value);
		}


		void StsFalhaComunicacaoValueChanged(object sender, ValueChangedEventArgs e)
		{
			fCom = Convert.ToBoolean(e.Value);
			Icones();
		}

		void StsProtecaoTermicaValueChanged(object sender, ValueChangedEventArgs e)
		{
			fTerm = Convert.ToBoolean(e.Value);
			Icones();
		}

		// Icones de termica e de falha de comunicacao piscam (500 ms) enquanto o alarme correspondente nao foi reconhecido;
		// reconhecido e ainda ativo = icone fixo (mesmo criterio ISA-101 dos faceplates)
		bool fTerm, fCom, fase = true;
		byte eTerm, eCom;
		System.Timers.Timer tPisca;
		static bool NaoRec(byte estadoAlarme) { return estadoAlarme >= 2 && estadoAlarme <= 4; }
		void ETermValueChanged(object sender, ValueChangedEventArgs e) { eTerm = Convert.ToByte(e.Value); Icones(); }
		void EComValueChanged(object sender, ValueChangedEventArgs e) { eCom = Convert.ToByte(e.Value); Icones(); }
		void Icones()
		{
			bool pTerm = fTerm && NaoRec(eTerm), pCom = fCom && NaoRec(eCom);
			Pisca(pTerm || pCom);
			unidade_Portecao_Termica1.Visible = fTerm && (!pTerm || fase);
			falha_comunicacao1.Visible = fCom && (!pCom || fase);
		}
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
			Icones();
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

		// 0 = nao conectado ao gerador, 1 = conectado, 2 = selecionado (gerador desligado), 3 = selecionado e gerador ligado
		void StsAnimacaoGeradorValueChanged(object sender, ValueChangedEventArgs e)
		{
			energizado_por_Gerador1.Animacao = Convert.ToInt32(e.Value);
		}

		// Velocidade em % so aparece em motor com inversor (STS_INVERSOR = cfgInversor do CAT)
		void CfgInversorValueChanged(object sender, ValueChangedEventArgs e)
		{
			velocidade.Visible = Convert.ToBoolean(e.Value);
		}
	}
}