/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 6/5/2026
 * Time: 4:25 PM
 * 
 */

using System;
using NxtControl.GuiFramework;
using System.ComponentModel;
using SE.App2Base.SupportClasses;

namespace SE.Nereda.Faceplates.AnalogInput
{
	/// <summary>
	/// Faceplate do sensor do Nereda no padrao Hidryco. Eventos do CLP (REQ_PV, REQ_ALM_LIM_SP, FB_COLOR, CH_FAIL),
	/// botoes de limite Schneider e pontos L1/L2 inalterados.
	/// </summary>
	public partial class fpDefault : NxtControl.GuiFramework.HMIFaceplate
	{
		float iPvMin, iPvMax = 100f;
		float spHH, spH, spL, spLL;
		string InUnit;
		bool iLoLoPv, iLoPv, iHiPv, iHiHiPv, iChFail, isitFlowSensor;
		bool disHH, disH, disL, disLL;

		public fpDefault()
		{
			InitializeComponent();
			this.REQ_PV_Fired += REQ_PV_Fired_EventHandler;
			this.REQ_ALM_LIM_SP_Fired += REQ_ALM_LIM_SP_Fired_EventHandler;
			this.FB_COLOR_Fired += FB_COLOR_Fired_EventHandler;
			this.CH_FAIL_Fired += CH_FAIL_Fired_EventHandler;
			Estados();
		}

		float Pct(float v)
		{
			float f = iPvMax - iPvMin;
			return f > 0 ? Math.Max(0f, Math.Min(100f, (v - iPvMin) / f * 100f)) : 0f;
		}

		void REQ_PV_Fired_EventHandler(object sender, SE.Nereda.Symbols.AnalogInput.REQ_PVEventArgs e)
		{
			Override.Visible = (bool)e.OverrideStatus;
			iPvMax = (float)e.PvMax;
			iPvMin = (float)e.PvMin;
			ShowLevel.FillPercent = Pct((float)e.Pv);
			L1v.BrushColor = (bool)e.L1 ? new NxtControl.Drawing.Color(0, 255, 0) : new NxtControl.Drawing.Color(54, 54, 54);
			L2v.BrushColor = (bool)e.L2 ? new NxtControl.Drawing.Color(0, 255, 0) : new NxtControl.Drawing.Color(54, 54, 54);
			Marcas();
		}

		void REQ_ALM_LIM_SP_Fired_EventHandler(object sender, SE.Nereda.Symbols.AnalogInput.REQ_ALM_LIM_SPEventArgs e)
		{
			spHH = (float)e.HiHiSp; spH = (float)e.HiSp; spL = (float)e.LoSp; spLL = (float)e.LoLoSp;
			iLoLoPv = (bool)e.LoLoPv;
			iLoPv = (bool)e.LoPv;
			iHiPv = (bool)e.HiPv;
			iHiHiPv = (bool)e.HiHiPv;
			Marcas();
			Estados();
		}

		// marcas dos limites na barra (escondidas quando o alarme esta desabilitado)
		void Marcas()
		{
			Marca(mHH, spHH, disHH);
			Marca(mH, spH, disH);
			Marca(mL, spL, disL);
			Marca(mLL, spLL, disLL);
		}
		void Marca(Rectangle m, float sp, bool desab)
		{
			m.Visible = !desab;
			m.Bounds = new NxtControl.Drawing.RectF(20f + 338f * Pct(sp) / 100f, 94f, 2f, 22f);
		}

		void SettingsClick(object sender, EventArgs e)
		{
			AnalogInput.Unit.EngineeringValue = InUnit;
			this.AnalogInput.DoOpenFaceplate("fpParameter");
		}

		void TrendsClick(object sender, EventArgs e)
		{
			this.AnalogInput.DoOpenFaceplate("fpTrend");
		}

		void FB_COLOR_Fired_EventHandler(object sender, SE.Nereda.Symbols.AnalogInput.FB_COLOREventArgs e)
		{
			switch (e.iColor)
			{
				case 1: ShowLevel.BrushColor = new NxtControl.Drawing.Color(255, 255, 255); break;
				case 2: ShowLevel.BrushColor = new NxtControl.Drawing.Color(154, 154, 154); break;
				case 3: ShowLevel.BrushColor = new NxtControl.Drawing.Color(178, 14, 18); break;
				case 4: ShowLevel.BrushColor = new NxtControl.Drawing.Color(234, 22, 30); break;
				case 5: ShowLevel.BrushColor = new NxtControl.Drawing.Color(254, 186, 10); break;
				case 6: ShowLevel.BrushColor = new NxtControl.Drawing.Color(255, 255, 0); break;
				case 7: ShowLevel.BrushColor = new NxtControl.Drawing.Color(150, 214, 66); break;
				case 8: ShowLevel.BrushColor = new NxtControl.Drawing.Color(61, 205, 88); break;
				case 9: ShowLevel.BrushColor = new NxtControl.Drawing.Color(2, 178, 238); break;
				case 10: ShowLevel.BrushColor = new NxtControl.Drawing.Color(0, 114, 188); break;
				case 11: ShowLevel.BrushColor = new NxtControl.Drawing.Color(47, 54, 153); break;
				case 12: ShowLevel.BrushColor = new NxtControl.Drawing.Color(111, 49, 152); break;
			}
		}

		void CH_FAIL_Fired_EventHandler(object sender, SE.Nereda.Symbols.AnalogInput.CH_FAILEventArgs e)
		{
			iChFail = (bool)e.ChFail;
			Estados();
		}

		static readonly NxtControl.Drawing.Color Normal = new NxtControl.Drawing.Color(64, 64, 64);
		static readonly NxtControl.Drawing.Color Aviso = new NxtControl.Drawing.Color(200, 120, 0);
		static readonly NxtControl.Drawing.Color Grave = new NxtControl.Drawing.Color(210, 0, 0);

		void Est(FreeText f, bool desab, bool ativo, bool grave)
		{
			f.Text = desab ? "Desabilitado" : (ativo ? "ATIVO" : "\u2014");
			f.Color = desab ? Normal : (ativo ? (grave ? Grave : Aviso) : Normal);
		}

		// situacao do valor (mesma regra de antes, com textos que servem para qualquer medicao) e coluna Estado
		void Estados()
		{
			if (iChFail)
			{
				LevelStatus.Text = "Falha do canal de E/S";
				LevelStatus.Color = Grave;
			}
			else if (iHiPv && iHiHiPv) { LevelStatus.Text = "Muito alto (HH)"; LevelStatus.Color = Grave; }
			else if (iLoPv && iLoLoPv) { LevelStatus.Text = "Muito baixo (LL)"; LevelStatus.Color = Grave; }
			else if (iHiPv) { LevelStatus.Text = "Alto (H)"; LevelStatus.Color = Aviso; }
			else if (iLoPv) { LevelStatus.Text = "Baixo (L)"; LevelStatus.Color = Aviso; }
			else { LevelStatus.Text = "Normal"; LevelStatus.Color = new NxtControl.Drawing.Color(40, 150, 60); }
			Est(estHH, disHH, iHiHiPv, true);
			Est(estH, disH, iHiPv, false);
			Est(estL, disL, iLoPv, false);
			Est(estLL, disLL, iLoLoPv, true);
			estFalha.Text = iChFail ? "FALHA" : "\u2014";
			estFalha.Color = iChFail ? Grave : Normal;
		}

		void IUnitValueChanged(object sender, ValueChangedEventArgs e)
		{
			if (isitFlowSensor == true)
				InUnit = Unit.Text = Unit2.Text = Unit3.Text = highHighBtn.Unit = highBtn.Unit = lowBtn.Unit = lowLowBtn.Unit =
					rateOfChangeBtn.Unit = deviationBtn.Unit = "m\u00b3/h";
			else
				InUnit = Unit.Text = Unit2.Text = Unit3.Text = highHighBtn.Unit = highBtn.Unit = lowBtn.Unit = lowLowBtn.Unit =
					rateOfChangeBtn.Unit = deviationBtn.Unit = e.Value.ToString();
		}

		void IFlowSensorValueChanged(object sender, ValueChangedEventArgs e) { isitFlowSensor = (bool)e.Value; }
		void HiHiDisabledValueChanged(object sender, ValueChangedEventArgs e) { disHH = (bool)e.Value; Marcas(); Estados(); }
		void HiDisabledValueChanged(object sender, ValueChangedEventArgs e) { disH = (bool)e.Value; Marcas(); Estados(); }
		void LoDisabledValueChanged(object sender, ValueChangedEventArgs e) { disL = (bool)e.Value; Marcas(); Estados(); }
		void LoLoDisabledValueChanged(object sender, ValueChangedEventArgs e) { disLL = (bool)e.Value; Marcas(); Estados(); }
	}
}
