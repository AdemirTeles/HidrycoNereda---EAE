/*
 * Criado pelo EcoStruxure Automation Expert.
 * Usuário:  
 * Data: 22/08/2026
 * Tempo: 14:12
 * 
 */

using System;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.CmdSludgeDischargeSLBLogic
{
	/// <summary>
	/// Painel de status das bombas da descarga (Sludge Buffer).
	/// Atualizado pelo evento PUMP_STS (CmdSludgeDischargeSLBLogicBasic.HMI_STS, a cada 1 s e na mudanca).
	/// Barra vertical = velocidade enviada a cada bomba em servico [%]; marcadores Cmin / C3 / C2 / Cmax.
	/// </summary>
	public partial class sDefault : NxtControl.GuiFramework.HMISymbol
	{
		const float BarTop = 34F;
		const float BarHeight = 134F;

		public sDefault()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			this.PUMP_STS_Fired += PUMP_STS_Fired_EventHandler;
		}

		static float F(System.Single? v) { return v.HasValue ? (float)v.Value : 0F; }
		static int I(System.Int16? v) { return v.HasValue ? (int)v.Value : 0; }
		static bool B(System.Boolean? v) { return v.HasValue && v.Value; }
		static float Clamp(float v) { return v < 0F ? 0F : (v > 100F ? 100F : v); }

		static string PumpName(int i)
		{
			if (i == 1) return "P4901";
			if (i == 2) return "P4902";
			if (i == 3) return "P4903";
			return "";
		}

		void Marker(NxtControl.GuiFramework.Polygon mk, NxtControl.GuiFramework.FreeText lb, string name, float pct, bool visible)
		{
			float y = BarTop + BarHeight - (BarHeight * Clamp(pct) / 100F) - 1F;
			mk.Location = new NxtControl.Drawing.PointF(294, y);
			lb.Location = new NxtControl.Drawing.PointF(332, y - 6F);
			lb.Text = name + " " + pct.ToString("0");
			mk.Visible = visible;
			lb.Visible = visible;
		}

		void PUMP_STS_Fired_EventHandler(object sender, SE.Nereda.Symbols.CmdSludgeDischargeSLBLogic.PUMP_STSEventArgs e)
		{
			int grafcet = I(e.StsGrafcet);
			int mode = I(e.PumpMode);
			int nPumps = I(e.NPumps);
			int pause = I(e.PauseCause);
			int sel = I(e.SelectedPump);
			int sec = I(e.SecondPump);
			float speed = F(e.PumpSpeed);
			bool atMin = B(e.AtMin);
			bool parBad = B(e.ParBad);
			bool sup = B(e.HmiSup);
			bool flowFail = B(e.HmiFlowFail);
			int tC2 = I(e.HmiTC2);
			int tC3 = I(e.HmiTC3);
			int tDec = I(e.HmiTDec);

			// ---- estado
			string state;
			switch (grafcet)
			{
				case 1: state = "Opening valves"; break;
				case 2: state = "Ready to run"; break;
				case 4: state = "Stopping pumps"; break;
				case 5: state = "Closing valves"; break;
				case 6: state = "Stopped"; break;
				case 7:
				case 8: state = "Aborting"; break;
				case 9: state = "Aborted"; break;
				case 3:
					if (pause == 1) state = "Paused: low level 49LT0001";
					else if (pause == 2) state = "Paused: flow LowLow 49FT0004";
					else if (!sup) state = nPumps >= 1 ? "1 pump on flow control" : "Starting pump";
					else if (mode == 1) state = "Lowering to C2: " + tDec.ToString() + " s";
					else if (mode == 2) state = nPumps >= 2 ? "Both pumps at C2: " + tC2.ToString() + " s" : "Starting 2nd pump at C2";
					else if (mode == 3) state = tC3 > 0 ? "2 pumps - below C3: " + tC3.ToString() + " s" : "2 pumps on flow control";
					else state = nPumps >= 1 ? "1 pump on flow control" : "Starting pump";
					break;
				default: state = "Idle"; break;
			}
			txtState.Text = state;

			// ---- bombas em servico
			string pumps = PumpName(sel);
			if (sec >= 1 && sec <= 3)
				pumps = pumps.Length > 0 ? pumps + " + " + PumpName(sec) : PumpName(sec);
			txtPumps.Text = "Pumps in service: " + (pumps.Length > 0 ? pumps : "none") + "  (running: " + nPumps.ToString() + ")";

			// ---- velocidade
			bool running = (grafcet == 3) && (pause == 0) && (nPumps >= 1);
			float shown = running ? Clamp(speed) : 0F;
			txtSpeed.Text = "Speed per pump: " + shown.ToString("0.0") + " %";
			rectBarFill.FillPercent = shown;
			rectBarFill.BrushColor = atMin ? new NxtControl.Drawing.Color(254, 186, 10) : new NxtControl.Drawing.Color(61, 205, 88);

			// ---- marcadores (C2/C3/Cmax so no modo sobrenadante, 2 + 1 bombas)
			Marker(mkCmin, lbCmin, "Cmin", F(e.HmiCmin), true);
			Marker(mkC3, lbC3, "C3", F(e.HmiC3), sup);
			Marker(mkC2, lbC2, "C2", F(e.HmiC2), sup);
			Marker(mkCmax, lbCmax, "Cmax", F(e.HmiCmax), sup);
			txtMode.Text = sup ? "Duty 2 + standby 1  (2nd pump above Cmax)" : "Duty 1 + standby 2";

			// ---- avisos
			if (flowFail)
				txtWarn1.Text = "Flowmeter failed: speed from setpoint";
			else if (atMin && running)
				txtWarn1.Text = "At minimum speed (Cmin)";
			else
				txtWarn1.Text = "";
			txtWarn2.Text = parBad ? "Check settings: C3 > Cmin, 2 x C3 < Cmax" : "";
		}
	}
}
