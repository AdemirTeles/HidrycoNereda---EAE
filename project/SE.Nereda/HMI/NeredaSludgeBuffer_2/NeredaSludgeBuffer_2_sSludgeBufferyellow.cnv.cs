/*
 * Criado pelo EcoStruxure Automation Expert.
 * Usuário:  
 * Data: 23/08/2026
 * Tempo: 17:28
 * 
 */

using System;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.NeredaSludgeBuffer_2
{
	/// <summary>
	/// Description of sSludgeBufferyellow.
	/// </summary>
	public partial class sSludgeBufferyellow : NxtControl.GuiFramework.HMISymbol
	{
		private float nivelMax = 0f;
		// último LevelPvMax recebido

		public sSludgeBufferyellow()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			this.LEVEL_Fired += LEVEL_Fired_EventHandler;   // sem esta linha o evento LEVEL nunca chega
		}

		void LEVEL_Fired_EventHandler(object sender, LEVELEventArgs e)
		{
			if (e.LevelPvMax.HasValue)
				nivelMax = e.LevelPvMax.Value;
			Desenha(e.LevelPv ?? 0f);
		}

		void LevelPvValueChanged(object sender, ValueChangedEventArgs e)
		{
			if (LevelPv.Value == null)
				return;
			Desenha(Convert.ToSingle(LevelPv.Value));
		}
		void Desenha(float pv)
		{
			if (nivelMax <= 0f)
				return;                       // sem nível máximo válido: não mexe no desenho
			float pct = pv / nivelMax * 100f;
			if (pct < 0f)
				pct = 0f;
			if (pct > 100f)
				pct = 100f;
			ShowLevel.FillPercent = pct;
		}
	}
}