/*
 * Created by EcoStruxure Automation Expert.
 * User: SESA713705
 * Date: 6/3/2026
 * Time: 11:56 AM
 * 
 */

using System;
using NxtControl.GuiFramework;
using System.ComponentModel;

namespace SE.Nereda.Symbols.ActState
{
	/// <summary>
	/// Description of sDefault.
	/// </summary>
	public partial class sDefault : NxtControl.GuiFramework.HMISymbol
	{
		// ================================================================
		// Internal values
		// ================================================================

		bool iPowerFb;
		bool iFbOverride;
		bool iFbSimulation;
		bool iFbReady;

		bool iProg;
		bool iOper;
		bool iRemote;
		bool iInterlocked;
		bool iNeedReset;

		Int16 iCurrentSp;
		Int16 iFbStatus;
		Int16 iDeviceType;
		
		// ================================================================
		// Actuator state delegate
		// ================================================================

		public delegate void ActState(Int16 StateValue);
		public event ActState ActuatorStatus;

		private Int16 iActStateV;

		// ================================================================
		// Manual mode delegate
		// ================================================================

		public delegate void ActManMode(bool ManValue);
		public event ActManMode ActManModeStatus;

		private bool iManV;
		
		public sDefault()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			starting.Visible = false;
			stopping.Visible = false;
			ManuelMode.Visible = false;
		}
		
		// ================================================================
		// Manual state update
		// Can be called without receiving STATE_Fired
		// ================================================================

		public void UpdateState()
		{

			State();
		}

		// ================================================================
		// State control
		// ================================================================
		
		void State()
		{
			state.Text = "";
			Mode.Text = "";
		
			starting.Visible = false;
			stopping.Visible = false;
			
			state.BrushColor = SE.Nereda.ProjectColors.PassiveStatus;
			state.PenColor = new NxtControl.Drawing.Color(0, 0, 0);
		
			// ============================================================
			// Operating mode
			// ============================================================
		
			ManuelMode.Visible = iRemote || iOper;
		
			iManV = false;
		
			if (iProg == true)
			{
				Mode.Text = "P";
				iManV = false;
			}
			else if (iOper == true)
			{
				Mode.Text = "O";
				iManV = false;
			}
			else if (iRemote == true)
			{
				Mode.Text = "R";
				iManV = true;
			}
		
			// ============================================================
			// Priority 1: Power OFF
			// ============================================================
		
			if (iPowerFb == false)
			{
				state.BrushColor = SE.Nereda.ProjectColors.PowerOFF;
		
				state.Text = "";
		
				starting.Visible = false;
				stopping.Visible = false;
				ManuelMode.Visible = false;
		
				Mode.Text = "OFF";
		
				iActStateV = 100;
				iManV = false;
			}
			
			// ============================================================
			// Priority 2: Interlocked
			// Checked only when device is ready
			// ============================================================
		
			else if (iInterlocked == true)
			{
				state.BrushColor = SE.Nereda.ProjectColors.PassiveStatus;
		
				state.Text = "";
		
				Mode.Text = "Ilck";
		
				starting.Visible = false;
				stopping.Visible = false;
		
				iActStateV = 10;
			}
		
			// ============================================================
			// Priority 3: Device not ready
			// Checked only when power is available
			// ============================================================
		
			else if (iFbReady == false)
			{
				state.BrushColor = new NxtControl.Drawing.BlinkColor("SE.Nereda.Orangwhite");
		
				if (iNeedReset == true)
				{
					state.Text = "";
					Mode.Text = "Reset";
		
					starting.Visible = false;
					stopping.Visible = false;
				}
				
				else{
					state.Text = "?";
				}

				starting.Visible = false;
				stopping.Visible = false;
		
				iActStateV = 253;
			}

			// ============================================================
			// Device powered, ready and not interlocked
			// ============================================================
		
			else
			{
				// ========================================================
				// Priority 4: Simulation or override indication
				// ========================================================
		
				if (iFbOverride == true || iFbSimulation == true)
				{
					state.PenColor = new NxtControl.Drawing.Color(254, 208, 26);
		
					state.Text = "S";
				}
				else
				{
					state.PenColor = new NxtControl.Drawing.Color(0, 0, 0);
		
					state.Text = "";
				}
		
				// ========================================================
				// Priority 5: Normal device state
				// ========================================================
		
				if (iDeviceType == 1)
				{
					// ====================================================
					// Device type 1: MOTOR
					// ====================================================
		
					// Motor starting
					if ((iCurrentSp == 1 || iCurrentSp == 2) &&
					    (iFbStatus == 0 || iFbStatus == 253))
					{
						state.BrushColor = SE.Nereda.ProjectColors.ActiveStatus;
		
						starting.Visible = true;
						stopping.Visible = false;
		
						iActStateV = iFbStatus;
					}
		
					// Motor running
					else if ((iCurrentSp == 1 && iFbStatus == 1) ||
					         (iCurrentSp == 2 && iFbStatus == 2))
					{
						state.BrushColor = SE.Nereda.ProjectColors.ActiveStatus;
		
						starting.Visible = false;
						stopping.Visible = false;
		
						iActStateV = iFbStatus;
					}
		
					// Motor stopping
					else if (iCurrentSp == 0 &&
					         (iFbStatus == 1 ||
					          iFbStatus == 2 ||
					          iFbStatus == 253))
					{
						state.BrushColor = SE.Nereda.ProjectColors.PassiveStatus;
		
						starting.Visible = false;
						stopping.Visible = true;
		
						iActStateV = iFbStatus;
					}
		
					// Motor stopped
					else if (iCurrentSp == 0 &&
					         iFbStatus == 0)
					{
						state.BrushColor = SE.Nereda.ProjectColors.PassiveStatus;
		
						starting.Visible = false;
						stopping.Visible = false;
		
						iActStateV = 0;
					}
				}
		
				else if (iDeviceType == 2)
				{
					// ====================================================
					// Device type 2: VALVE
					// ====================================================
		
					// Valve opening
					if (iCurrentSp == 1 &&
					    (iFbStatus == 2 || iFbStatus == 253))
					{
						state.BrushColor = SE.Nereda.ProjectColors.ActiveStatus;
		
						starting.Visible = true;
						stopping.Visible = false;
		
						iActStateV = iFbStatus;
					}
		
					// Valve opened
					else if (iCurrentSp == 1 &&
					         iFbStatus == 1)
					{
						state.BrushColor = SE.Nereda.ProjectColors.ActiveStatus;
		
						starting.Visible = false;
						stopping.Visible = false;
		
						iActStateV = iFbStatus;
					}
		
					// Valve closing
					else if (iCurrentSp == 2 &&
					         (iFbStatus == 1 || iFbStatus == 253))
					{
						state.BrushColor = SE.Nereda.ProjectColors.PassiveStatus;
		
						starting.Visible = false;
						stopping.Visible = true;
		
						iActStateV = iFbStatus;
					}
		
					// Valve closed
					else if (iCurrentSp == 2 &&
					         iFbStatus == 2)
					{
						state.BrushColor = SE.Nereda.ProjectColors.PassiveStatus;
		
						starting.Visible = false;
						stopping.Visible = false;
		
						iActStateV = 0;
					}
				}
			}
		
			SendState();
		}

		// ================================================================
		// Send delegates and confirmation event
		// ================================================================

		void SendState()
		{
			if (this.ActuatorStatus != null)
			{
				this.ActuatorStatus(iActStateV);
			}

			if (this.ActManModeStatus != null)
			{
				this.ActManModeStatus(iManV);
			}

			FireEvent_CNF_ACT_STATE(iActStateV);
		}

		void CurrentSpValueChanged(object sender, ValueChangedEventArgs e)
		{
			// TODO: Implement CurrentSpValueChanged
			iCurrentSp = (Int16) e.Value;
			State();
		}

		void FbStatusValueChanged(object sender, ValueChangedEventArgs e)
		{
			// TODO: Implement FbStatusValueChanged
			iFbStatus = (Int16) e.Value;
			State();
		}

		void FbReadyValueChanged(object sender, ValueChangedEventArgs e)
		{
			// TODO: Implement FbReadyValueChanged
			iFbReady = (bool) e.Value;
			State();
		}

		void PowerFbValueChanged(object sender, ValueChangedEventArgs e)
		{
			// TODO: Implement PowerFbValueChanged
			iPowerFb = (bool) e.Value;
			State();
		}

		void ProgValueChanged(object sender, ValueChangedEventArgs e)
		{
			// TODO: Implement ProgValueChanged
			iProg = (bool) e.Value;
			State();
		}

		void OperValueChanged(object sender, ValueChangedEventArgs e)
		{
			// TODO: Implement OperValueChanged
			iOper = (bool) e.Value;
			State();
		}

		void RemoteValueChanged(object sender, ValueChangedEventArgs e)
		{
			// TODO: Implement RemoteValueChanged
			iRemote = (bool) e.Value;
			State();
		}

		void DeviceTypeValueChanged(object sender, ValueChangedEventArgs e)
		{
			// TODO: Implement DeviceTypeValueChanged
			iDeviceType = (Int16) e.Value;
			State();
		}

		void FbSimulationValueChanged(object sender, ValueChangedEventArgs e)
		{
			// TODO: Implement FbSimulationValueChanged
			iFbSimulation = (bool) e.Value;
			State();
		}

		void FbOverrideValueChanged(object sender, ValueChangedEventArgs e)
		{
			// TODO: Implement FbOverrideValueChanged
			iFbOverride = (bool) e.Value;
			State();
		}

		void InterlockedValueChanged(object sender, ValueChangedEventArgs e)
		{
			// TODO: Implement InterlockedValueChanged
			iInterlocked = (bool) e.Value;
			State();
		}

		void NeedResetValueChanged(object sender, ValueChangedEventArgs e)
		{
			// TODO: Implement NeedResetValueChanged
			iNeedReset = (bool) e.Value;
			State();
		}
	}
}
