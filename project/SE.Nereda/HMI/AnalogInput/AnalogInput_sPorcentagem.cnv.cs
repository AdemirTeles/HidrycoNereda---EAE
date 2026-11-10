/*
 * Hidryco - AnalogInput sPorcentagem: Pv em % da faixa, calculado no CLP (PvPorcentagem -> IThis.REQ_PCT).
 */
using System;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.AnalogInput
{
	/// <summary>
	/// Valor em porcentagem da faixa de medicao.
	/// </summary>
	public partial class sPorcentagem : NxtControl.GuiFramework.HMISymbol
	{
		public sPorcentagem()
		{
			InitializeComponent();
			this.REQ_PCT_Fired += REQ_PCT_Fired_EventHandler;
		}

		void REQ_PCT_Fired_EventHandler(object sender, REQ_PCTEventArgs e)
		{
			float? v = e.PvPct;
			valor.Text = v.HasValue ? v.Value.ToString("0.0") + " %" : "--- %";
		}
	}
}
