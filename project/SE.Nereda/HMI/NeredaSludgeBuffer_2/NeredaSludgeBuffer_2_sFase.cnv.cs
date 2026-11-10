/*
 * Hidryco - sFase: nome do equipamento e faixa com a fase ativa (cor por fase; vermelho = abortada).
 * Fonte: evento FASE do IThis (FaseAtiva, FaseAbortada, Abortado), calculado no CLP (FaseAtivaNereda).
 */
using System;
using System.ComponentModel;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.NeredaSludgeBuffer_2
{
	/// <summary>
	/// Nome do equipamento e fase ativa em uma faixa colorida.
	/// </summary>
	public partial class sFase : NxtControl.GuiFramework.HMISymbol
	{
		private string _Nome = "Buffer de lodo";
		// numeracao = FaseAtivaNereda no CLP
		private static readonly string[] NOMES = { "Sem fase", "Alimentação", "Descarte de lodo", "Descarte de água", "Espera" };
		private static readonly NxtControl.Drawing.Color[] CORES = { new NxtControl.Drawing.Color(175, 175, 175), new NxtControl.Drawing.Color(0, 140, 70), new NxtControl.Drawing.Color(160, 100, 20), new NxtControl.Drawing.Color(0, 125, 140), new NxtControl.Drawing.Color(110, 110, 110) };
		private static readonly NxtControl.Drawing.Color COR_ABORTADA = new NxtControl.Drawing.Color(200, 30, 30);
		private static readonly NxtControl.Drawing.Color COR_OUTRA = new NxtControl.Drawing.Color(0, 125, 125);

		public sFase()
		{
			InitializeComponent();
			this.FASE_Fired += FASE_Fired_EventHandler;
		}

		[RefreshProperties(RefreshProperties.Repaint)]
		[Category("Tagnames")]
		[DisplayName("Nome")]
		public string _iNome
		{
			get { return _Nome; }
			set
			{
				_Nome = value;
				txtNome.Text = value == null ? "" : value;
			}
		}

		static string Nome(int n)
		{
			return (n >= 0 && n < NOMES.Length) ? NOMES[n] : ("Fase " + n);
		}

		void FASE_Fired_EventHandler(object sender, FASEEventArgs e)
		{
			int ativa = e.FaseAtiva ?? 0;
			int abortada = e.FaseAbortada ?? 0;
			bool abortado = e.Abortado ?? false;
			if (abortado && abortada > 0)
			{
				faixa.Text = "Abortada: " + Nome(abortada);
				faixa.Brush = new NxtControl.Drawing.Brush(COR_ABORTADA);
				return;
			}
			faixa.Text = Nome(ativa);
			faixa.Brush = new NxtControl.Drawing.Brush((ativa >= 0 && ativa < CORES.Length) ? CORES[ativa] : COR_OUTRA);
		}
	}
}
