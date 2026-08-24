/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 6/3/2026
 * Time: 10:19 AM
 * 
 */

using System;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.FieldSignals
{
	/// <summary>
	/// Description of sPanel.
	/// </summary>
	public partial class sPanel : NxtControl.GuiFramework.HMISymbol
	{
		bool ElecCircFail;
		bool SafetySwitchOff;
		bool FreqInverFail;
		int AtvEta;
		bool RemoteSel;
		bool AutoSel;
		bool PowerFb;
		bool AtvReady;
		bool Trip;
		bool Mdpms;
		public sPanel()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			this.REQ_NAME_Fired += REQ_NAME_Fired_EventHandler;
		}

		void SwitchElectriCircuitFailCheckedChanged(object sender, EventArgs e)
		{
			// TODO: Implement SwitchElectriCircuitFailCheckedChanged
			ElecCircFail = SwitchElectriCircuitFail.Checked;
			LocalPanel();
		}

		void SwitchSafetySwitchOffCheckedChanged(object sender, EventArgs e)
		{
			// TODO: Implement SwitchSafetySwitchOffCheckedChanged
			SafetySwitchOff = SwitchSafetySwitchOff.Checked;
			LocalPanel();
		}

		void SwitchFreqInverterFailCheckedChanged(object sender, EventArgs e)
		{
			// TODO: Implement SwitchFreqInverterFailCheckedChanged
			FreqInverFail = SwitchFreqInverterFail.Checked;
			LocalPanel();
		}

		void SwitchRemoteCheckedChanged(object sender, EventArgs e)
		{
			// TODO: Implement SwitchRemoteCheckedChanged
			RemoteSel = SwitchRemote.Checked;
			LocalPanel();
		}

		void SwitchAutoCheckedChanged(object sender, EventArgs e)
		{
			// TODO: Implement SwitchAutoCheckedChanged
			AutoSel = SwitchAuto.Checked;
			LocalPanel();
		}

		void SwitchPowerFbCheckedChanged(object sender, EventArgs e)
		{
			// TODO: Implement SwitchPowerFbCheckedChanged
			PowerFb = SwitchPowerFb.Checked;
			LocalPanel();
		}

		void SwitchAtvReadyCheckedChanged(object sender, EventArgs e)
		{
			// TODO: Implement SwitchAtvReadyCheckedChanged
			AtvReady = SwitchAtvReady.Checked;
			LocalPanel();
		}
		
		void LocalPanel()
		{
			if (ElecCircFail == false)
				LampElectriCircuitFail.BrushColor = new NxtControl.Drawing.Color(210, 210, 210);
			else
				LampElectriCircuitFail.BrushColor = new NxtControl.Drawing.Color(255, 0, 0);
		
			if (SafetySwitchOff == false)
				LampchSafetySwitchOff.BrushColor = new NxtControl.Drawing.Color(210, 210, 210);
			else
				LampchSafetySwitchOff.BrushColor = new NxtControl.Drawing.Color(0, 255, 0);
		
			if (FreqInverFail == false)
				LampFreqInverterFail.BrushColor = new NxtControl.Drawing.Color(210, 210, 210);
			else
				LampFreqInverterFail.BrushColor = new NxtControl.Drawing.Color(255, 0, 0);
		
			if (RemoteSel == false)
				LampRemote.BrushColor = new NxtControl.Drawing.Color(210, 210, 210);
			else
				LampRemote.BrushColor = new NxtControl.Drawing.Color(0, 255, 0);
		
			if (AutoSel == false)
				LampAuto.BrushColor = new NxtControl.Drawing.Color(210, 210, 210);
			else
				LampAuto.BrushColor = new NxtControl.Drawing.Color(0, 255, 0);
		
			if (PowerFb == false)
				LampPowerFb.BrushColor = new NxtControl.Drawing.Color(210, 210, 210);
			else
				LampPowerFb.BrushColor = new NxtControl.Drawing.Color(0, 255, 0);
		
			if (AtvReady == false)
				LampAtvReady.BrushColor = new NxtControl.Drawing.Color(255, 0, 0);
			else
				LampAtvReady.BrushColor = new NxtControl.Drawing.Color(0, 255, 0);
			
			FireEvent_CNF_VALUES(ElecCircFail, SafetySwitchOff, FreqInverFail, RemoteSel, AutoSel, PowerFb, AtvReady);
		}

		void REQ_NAME_Fired_EventHandler(object sender, REQ_NAMEEventArgs e)
		{
			// TODO: Implement REQ_NAME_Fired_EventHandler
			PanelName.Text = e.Name;
		}
	}
}
