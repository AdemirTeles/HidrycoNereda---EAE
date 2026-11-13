/*
 * Created by EcoStruxure Automation Expert.
 * User: SESA671563
 * Date: 10/19/2022
 * Time: 10:16 PM
 * 
 */

using System;
using NxtControl.GuiFramework;

namespace SE.Nereda.Faceplates.MotorVsBaseNer
{
	/// <summary>
	/// Description of fpTrend.
	/// </summary>
	public partial class fpTrend : NxtControl.GuiFramework.HMIFaceplate
	{
		public fpTrend()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			PadraoTrend();
		}

		// ---- Padrao dos trends (12/11/2026): escala automatica, 30 min ao abrir, botoes de janela,
		// legenda com nome/valor/caixinha para esconder a linha, barra de ferramentas (zoom, rolar, cursor) visivel.
		void PadraoTrend()
		{
			trendControl1.ToolBarVisible = true;
			trendControl1.LegendVisible = true;
			trendControl1.LegendCheckBoxes = true;
			TrendValueScale esc = trendControl1.ValueScalesLeft;
			if (esc != null) esc.AutoScale = true;
			Janela(btn30m, 30);
		}

		void BtnTempoClick(object sender, EventArgs e)
		{
			if (sender == btn5m) Janela(btn5m, 5);
			else if (sender == btn30m) Janela(btn30m, 30);
			else if (sender == btn1h) Janela(btn1h, 60);
			else if (sender == btn8h) Janela(btn8h, 480);
		}

		void Janela(DrawnButton sel, int minutos)
		{
			trendControl1.TimeSpan = TimeSpan.FromMinutes(minutos);
			foreach (DrawnButton b in new DrawnButton[] { btn5m, btn30m, btn1h, btn8h })
			{
				bool s = b == sel;
				b.BrushColor = s ? new NxtControl.Drawing.Color(60, 60, 60) : new NxtControl.Drawing.Color(215, 215, 215);
				b.TextColor = s ? new NxtControl.Drawing.Color(255, 255, 255) : new NxtControl.Drawing.Color(0, 0, 0);
				b.TextColorMouseDown = b.TextColor;
			}
		}
	}
}



