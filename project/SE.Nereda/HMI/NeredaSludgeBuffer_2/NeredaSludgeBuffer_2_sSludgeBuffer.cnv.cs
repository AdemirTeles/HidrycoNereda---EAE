/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 7/11/2026
 * Time: 9:35 PM
 * 
 */

using System;
using NxtControl.GuiFramework;
using System.ComponentModel;

namespace SE.Nereda.Symbols.NeredaSludgeBuffer_2
{
	/// <summary>
	/// Description of sSludgeBuffer.
	/// </summary>
	public partial class sSludgeBuffer : NxtControl.GuiFramework.HMISymbol
	{
		private string _SLUDGE_BUFFER = "TANQUE DE EQUALIZAÇÃO DE LODO";
		private float nivelMax = 0f;
		// ultimo LevelPvMax recebido

		public sSludgeBuffer()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			this.LEVEL_Fired += LEVEL_Fired_EventHandler;   // sem esta linha o evento LEVEL nunca chega
			WaterLevel.FillPercent = 0;
			WaterBase.Visible = false;
			WaterTop.Visible = false;
		}
		
		[RefreshProperties(RefreshProperties.Repaint)]
		[Category("Tagnames")]
		[DisplayName("Name Code")]
		
		public string _iSLUDGE_BUFFER
		{
			get{
				return _SLUDGE_BUFFER;
			}
			set{
				_SLUDGE_BUFFER = value;
				SLUDGE_BUFFER.Text = value.ToString();
			}
		}

		void LEVEL_Fired_EventHandler(object sender, LEVELEventArgs e)
		{
			if (e.LevelPvMax.HasValue)
				nivelMax = e.LevelPvMax.Value;
			Desenha(e.LevelPv ?? 0f);
		}

		void Desenha(float pv)
		{
			if (nivelMax <= 0f)
				return;                       // sem nivel maximo valido: nao mexe no desenho
			float pct = pv / nivelMax * 100f;
			if (pct < 0f)
				pct = 0f;
			if (pct > 100f)
				pct = 100f;
			WaterBase.Visible = WaterTop.Visible = pct > 0f;
			WaterLevel.FillPercent = pct;
			// topo da agua: da base (y 232) ate o topo do tanque (y 96)
			WaterTop.Location = new NxtControl.Drawing.PointF(32, 232 + (pct * (96 - 232) / 100));
		}
	}
}