/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 6/13/2026
 * Time: 4:00 PM
 * 
 */

using System;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.FeedReactorLogic
{
	/// <summary>
	/// Settings das bombas de alimentacao P4001/P4002/P4003 e painel PUMPS STATUS (mesmo padrao do Sludge Buffer).
	/// Painel atualizado pelo evento PUMP_STS (FeedReactor3PsBasic.HMI_STS, a cada 1 s e na mudanca).
	/// </summary>
	public partial class sDefault : NxtControl.GuiFramework.HMISymbol
	{
		const float BarTop = 434F;
		const float BarHeight = 134F;
		const float MarkerX = 302F;
		const float LabelX = 340F;

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
			if (i == 1) return "P4001";
			if (i == 2) return "P4002";
			if (i == 3) return "P4003";
			return "";
		}

		void Marker(NxtControl.GuiFramework.Polygon mk, NxtControl.GuiFramework.FreeText lb, string name, float pct)
		{
			float y = BarTop + BarHeight - (BarHeight * Clamp(pct) / 100F) - 1F;
			mk.Location = new NxtControl.Drawing.PointF(MarkerX, y);
			lb.Location = new NxtControl.Drawing.PointF(LabelX, y - 6F);
			lb.Text = name + " " + pct.ToString("0");
		}

		void PUMP_STS_Fired_EventHandler(object sender, SE.Nereda.Symbols.FeedReactorLogic.PUMP_STSEventArgs e)
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
			bool flowFail = B(e.HmiFlowFail);
			int tC2 = I(e.HmiTC2);
			int tC3 = I(e.HmiTC3);
			int tDec = I(e.HmiTDec);
			int tWait = I(e.HmiTWait);
			float flowSp = F(e.HmiFlowSp);

			// ---- estado
			string state;
			if (grafcet != 3)
				state = "No feed request";
			else if (pause == 1)
				state = "Stopped: level LowLow 40LT0001";
			else if (pause == 2)
				state = tWait > 0 ? "pH/conductivity OK - restart in " + tWait.ToString() + " s" : "Stopped: pH/conductivity out of range";
			else if (pause == 3)
				state = tWait > 0 ? "Flow LowLow - restart wait " + tWait.ToString() + " s" : "Stopped: flow LowLow 40FT0003";
			else if (mode == 1)
				state = "Lowering to C2: " + tDec.ToString() + " s";
			else if (mode == 2)
				state = nPumps >= 2 ? "Both pumps at C2: " + tC2.ToString() + " s" : "Starting 2nd pump at C2";
			else if (mode == 3)
				state = tC3 > 0 ? "2 pumps - below C3: " + tC3.ToString() + " s" : "2 pumps on flow control";
			else
				state = nPumps >= 1 ? "1 pump on flow control" : "Starting pump";
			txtState.Text = state;

			// ---- bombas em servico
			string pumps = PumpName(sel);
			if (sec >= 1 && sec <= 3)
				pumps = pumps.Length > 0 ? pumps + " + " + PumpName(sec) : PumpName(sec);
			txtPumps.Text = "Pumps in service: " + (pumps.Length > 0 ? pumps : "none") + "  (running: " + nPumps.ToString() + ")";

			// ---- velocidade e setpoint
			bool running = (grafcet == 3) && (pause == 0) && (nPumps >= 1);
			float shown = running ? Clamp(speed) : 0F;
			txtSpeed.Text = "Speed per pump: " + shown.ToString("0.0") + " %";
			txtMode.Text = "Flow setpoint: " + flowSp.ToString("0.0") + " m³/h   (2 duty + 1 standby)";
			rectBarFill.FillPercent = shown;
			rectBarFill.BrushColor = atMin ? new NxtControl.Drawing.Color(254, 186, 10) : new NxtControl.Drawing.Color(61, 205, 88);

			// ---- marcadores
			Marker(mkCmin, lbCmin, "Cmin", F(e.HmiCmin));
			Marker(mkC3, lbC3, "C3", F(e.HmiC3));
			Marker(mkC2, lbC2, "C2", F(e.HmiC2));
			Marker(mkCmax, lbCmax, "Cmax", F(e.HmiCmax));

			// ---- avisos
			if (flowFail)
				txtWarn1.Text = "Flowmeter 40FT0003 failed: speed from setpoint";
			else if (atMin && running)
				txtWarn1.Text = "At minimum speed (Cmin)";
			else
				txtWarn1.Text = "";
			txtWarn2.Text = parBad ? "Check settings: C3 > Cmin, 2 x C3 < Cmax" : "";
		}
	}
}
