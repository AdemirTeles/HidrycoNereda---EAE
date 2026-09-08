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

namespace SE.Nereda.Symbols.TestActState2
{
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

		// ================================================================
		// Constructor
		// ================================================================

		public sDefault()
		{
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

			// ============================================================
			// Simulation or override
			// ============================================================

			if (iFbOverride == true || iFbSimulation == true)
			{
				state.PenColor =
					new NxtControl.Drawing.Color(254, 208, 26);

				state.Text = "S";
			}
			else
			{
				state.PenColor =
					new NxtControl.Drawing.Color(0, 0, 0);

				state.Text = "";
			}

			// ============================================================
			// Power OFF
			// ============================================================

			if (iPowerFb == false)
			{
				state.BrushColor =
					SE.Nereda.ProjectColors.PowerOFF;

				starting.Visible = false;
				stopping.Visible = false;
				ManuelMode.Visible = false;

				Mode.Text = "OFF";

				iActStateV = 100;
				iManV = false;

				SendState();

				return;
			}

			// ============================================================
			// Device type 1: MOTOR
			// ============================================================

			if (iDeviceType == 1)
			{
				// Motor starting
				if ((iCurrentSp == 1 || iCurrentSp == 2) &&
				    (iFbStatus == 0 || iFbStatus == 253) &&
				    iFbReady == true)
				{
					state.BrushColor =
						SE.Nereda.ProjectColors.ActiveStatus;

					starting.Visible = true;
					stopping.Visible = false;

					iActStateV = iFbStatus;
				}

				// Motor running
				else if ((iCurrentSp == 1 && iFbStatus == 1) ||
				         (iCurrentSp == 2 && iFbStatus == 2))
				{
					state.BrushColor =
						SE.Nereda.ProjectColors.ActiveStatus;

					starting.Visible = false;
					stopping.Visible = false;

					iActStateV = iFbStatus;
				}

				// Motor stopping
				else if (iCurrentSp == 0 &&
				         (iFbStatus == 1 ||
				          iFbStatus == 2 ||
				          iFbStatus == 253) &&
				         iFbReady == true)
				{
					state.BrushColor =
						SE.Nereda.ProjectColors.PassiveStatus;

					starting.Visible = false;
					stopping.Visible = true;

					iActStateV = iFbStatus;
				}

				// Motor stopped
				else if (iCurrentSp == 0 &&
				         iFbStatus == 0)
				{
					state.BrushColor =
						SE.Nereda.ProjectColors.PassiveStatus;

					starting.Visible = false;
					stopping.Visible = false;

					iActStateV = 0;
				}

				// Motor not ready
				else if (iFbReady == false)
				{
					state.BrushColor =
						new NxtControl.Drawing.BlinkColor(
							"SE.Nereda.Orangwhite");

					state.Text = "?";

					starting.Visible = false;
					stopping.Visible = false;

					iActStateV = 253;
				}
			}

			// ============================================================
			// Device type 2: VALVE
			// ============================================================

			else if (iDeviceType == 2)
			{
				// Valve opening
				if (iCurrentSp == 1 &&
				    (iFbStatus == 2 || iFbStatus == 253) &&
				    iFbReady == true)
				{
					state.BrushColor =
						SE.Nereda.ProjectColors.ActiveStatus;

					starting.Visible = true;
					stopping.Visible = false;

					iActStateV = iFbStatus;
				}

				// Valve opened
				else if (iCurrentSp == 1 &&
				         iFbStatus == 1)
				{
					state.BrushColor =
						SE.Nereda.ProjectColors.ActiveStatus;

					starting.Visible = false;
					stopping.Visible = false;

					iActStateV = iFbStatus;
				}

				// Valve closing
				else if (iCurrentSp == 2 &&
				         (iFbStatus == 1 || iFbStatus == 253) &&
				         iFbReady == true)
				{
					state.BrushColor =
						SE.Nereda.ProjectColors.PassiveStatus;

					starting.Visible = false;
					stopping.Visible = true;

					iActStateV = iFbStatus;
				}

				// Valve closed
				else if (iCurrentSp == 2 &&
				         iFbStatus == 2)
				{
					state.BrushColor =
						SE.Nereda.ProjectColors.PassiveStatus;

					starting.Visible = false;
					stopping.Visible = false;

					iActStateV = 0;
				}

				// Valve not ready
				else if (iFbReady == false)
				{
					state.BrushColor =
						new NxtControl.Drawing.BlinkColor(
							"SE.Nereda.Orangwhite");

					state.Text = "?";

					starting.Visible = false;
					stopping.Visible = false;

					iActStateV = 253;
				}
			}

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
			// Interlock priority
			// ============================================================

			if (iInterlocked == true)
			{
				Mode.Text = "Ilck";

				starting.Visible = false;
				stopping.Visible = false;

				state.BrushColor =
					new NxtControl.Drawing.BlinkColor(
						"SE.Nereda.Orangwhite");

				iActStateV = 10;
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
	}
}