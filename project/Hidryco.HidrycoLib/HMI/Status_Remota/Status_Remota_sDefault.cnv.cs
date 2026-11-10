/*
 * Hidryco - Status_Remota - sDefault
 * Estado da comunicacao da remota: verde comunicando, amarelo sem comunicacao, cinza aguardando,
 * cinza escuro SEM DADOS DO CLP (sinal de vida STS_VIVO parado: CLP desligado, parado ou sem rede com a IHM).
 */

using System;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Symbols.Status_Remota
{
	public partial class sDefault : NxtControl.GuiFramework.HMISymbol
	{
		// Sem nenhum dado do CLP por mais que isto (o CLP manda STS_VIVO a cada 2 s) = SEM DADOS DO CLP
		const double LIMITE_SEM_DADOS_S = 7D;

		public sDefault()
		{
			InitializeComponent();
			ultimoDado = DateTime.Now;
			Atualiza();
			tVigia = new System.Timers.Timer(1000D);
			tVigia.Elapsed += new System.Timers.ElapsedEventHandler(TVigiaElapsed);
			tVigia.Start();
		}

		// ---- dados recebidos da logica (Execute invisiveis)
		short est;
		DateTime ultimoDado;
		bool semDados;
		void XESTValueChanged(object s, ValueChangedEventArgs e) { est = Convert.ToInt16(e.Value); ultimoDado = DateTime.Now; semDados = false; Atualiza(); }
		void XVIVOValueChanged(object s, ValueChangedEventArgs e) { ultimoDado = DateTime.Now; if (semDados) { semDados = false; Atualiza(); } }

		/// <summary>0 aguardando, 1 comunicando, 2 sem comunicacao, 3 sem dados do CLP</summary>
		public int Estado { get { return semDados ? 3 : est; } }

		/// <summary>Disparado a cada mudanca de Estado (usado no diagnostico da tela HARDWARE)</summary>
		public event EventHandler EstadoMudou;

		System.Timers.Timer tVigia;

		// O temporizador roda em outra thread: a verificacao vai para a thread da IHM
		void TVigiaElapsed(object sender, System.Timers.ElapsedEventArgs e)
		{
			NxtControl.Services.IHMIMainThreadService svc = NxtControl.Services.ServiceProvider.GetService(typeof(NxtControl.Services.IHMIMainThreadService)) as NxtControl.Services.IHMIMainThreadService;
			if (svc != null) svc.SafeThreadAsyncCall(new Action(Vigia));
		}

		void Vigia()
		{
			bool sd = (DateTime.Now - ultimoDado).TotalSeconds > LIMITE_SEM_DADOS_S;
			if (sd != semDados) { semDados = sd; Atualiza(); }
		}

		static readonly NxtControl.Drawing.Color OK = new NxtControl.Drawing.Color(0, 140, 60);
		static readonly NxtControl.Drawing.Color FALHA = Hidryco.HidrycoLib.SupportClasses.HidrycoColors.Falha;
		static readonly NxtControl.Drawing.Color AGUARDA = new NxtControl.Drawing.Color(150, 150, 150);
		static readonly NxtControl.Drawing.Color SEMDADOS = new NxtControl.Drawing.Color(80, 80, 80);
		int ultimoEstado = -1;

		void Atualiza()
		{
			if (semDados) { fundo.Brush = new NxtControl.Drawing.Brush(SEMDADOS); tEst.Text = "SEM DADOS DO CLP"; tEst.Color = new NxtControl.Drawing.Color(255, 255, 255); }
			else if (est == 1) { fundo.Brush = new NxtControl.Drawing.Brush(OK); tEst.Text = "COMUNICANDO"; tEst.Color = new NxtControl.Drawing.Color(255, 255, 255); }
			else if (est == 2) { fundo.Brush = new NxtControl.Drawing.Brush(FALHA); tEst.Text = "SEM COMUNICAÇÃO"; tEst.Color = new NxtControl.Drawing.Color(0, 0, 0); }
			else { fundo.Brush = new NxtControl.Drawing.Brush(AGUARDA); tEst.Text = "AGUARDANDO"; tEst.Color = new NxtControl.Drawing.Color(255, 255, 255); }
			if (Estado != ultimoEstado)
			{
				ultimoEstado = Estado;
				EventHandler h = EstadoMudou;
				if (h != null) h(this, EventArgs.Empty);
			}
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && tVigia != null)
			{
				tVigia.Stop();
				tVigia.Dispose();
				tVigia = null;
			}
			base.Dispose(disposing);
		}
	}
}
