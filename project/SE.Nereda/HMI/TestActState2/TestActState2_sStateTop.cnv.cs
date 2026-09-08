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
	/// <summary>
	/// Description of sDefault.
	/// </summary>
	public partial class sStateTop : NxtControl.GuiFramework.HMISymbol
	{
		public sStateTop()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			this.STATE_Fired += STATE_Fired_EventHandler;
			starting.Visible = stopping.Visible = ManuelMode.Visible = false;
		}
		public delegate void ActState(Int16 StateValue);
		public event ActState ActuatorStatus;
		private Int16 iActStateV;
		
		public delegate void ActManMode(bool ManValue);
		public event ActManMode ActManModeStatus;
		private bool iManV;
		void STATE_Fired_EventHandler(object sender, STATEEventArgs e)
		{
			// TODO: Implement STATE_Fired_EventHandler
			// Reset displayed texts each time the event is fired
			state.Text = "";
			Mode.Text = "";
			
			if(e.fbOverride == true || e.fbSimulation == true){
				state.PenColor = new NxtControl.Drawing.Color(254, 208, 26);
				state.Text = "S";
			}
			else if(e.fbOverride == false && e.fbSimulation == false){
				state.PenColor = new NxtControl.Drawing.Color(0,0,0);
				state.Text = "";
			}
		
			// ============================================================
			// CASE 1: Actuator is powered off
			// ============================================================
			if (e.PowerFb == false)
			{
				state.BrushColor = SE.Nereda.ProjectColors.PowerOFF;
		
				starting.Visible = false;
				stopping.Visible = false;
		
				Mode.Text = "OFF";
		
				// Specific state value used when power feedback is OFF
				iActStateV = 100;
		
				// Send actuator state value
				if (this.ActuatorStatus != null)
					this.ActuatorStatus(iActStateV);
			}
		
			// ============================================================
			// CASE 2: Actuator is powered on
			// ============================================================
			else
			{
				// ========================================================
				// DEVICE TYPE 1: MOTOR
				// ========================================================
				if (e.DeviceType == 1)
				{
					// ----------------------------------------------------
					// Motor starting
					// CurrentSp = 1 or 2
					// FbStatus = 0 or 253
					// FbReady = true
					// ----------------------------------------------------
					if ((((e.CurrentSp == 1 || e.CurrentSp == 2) && e.FbStatus == 0) ||
					     ((e.CurrentSp == 1 || e.CurrentSp == 2) && e.FbStatus == 253)) &&
					    e.FbReady == true)
					{
						state.BrushColor = SE.Nereda.ProjectColors.ActiveStatus;
		
						starting.Visible = true;
						stopping.Visible = false;
		
						iActStateV = (short)e.FbStatus;
		
						if (this.ActuatorStatus != null)
							this.ActuatorStatus(iActStateV);
					}
		
					// ----------------------------------------------------
					// Motor running in the requested direction
					// CurrentSp = 1 with FbStatus = 1
					// or CurrentSp = 2 with FbStatus = 2
					// ----------------------------------------------------
					else if ((e.CurrentSp == 1 && e.FbStatus == 1) ||
					         (e.CurrentSp == 2 && e.FbStatus == 2))
					{
						state.BrushColor = SE.Nereda.ProjectColors.ActiveStatus;
		
						starting.Visible = false;
						stopping.Visible = false;
		
						iActStateV = (short)e.FbStatus;
		
						if (this.ActuatorStatus != null)
							this.ActuatorStatus(iActStateV);
					}
		
					// ----------------------------------------------------
					// Motor stopping
					// CurrentSp = 0
					// FbStatus = 1, 2 or 253
					// FbReady = true
					// ----------------------------------------------------
					else if (((e.CurrentSp == 0 && (e.FbStatus == 1 || e.FbStatus == 2)) ||
					          (e.CurrentSp == 0 && e.FbStatus == 253)) &&
					         e.FbReady == true)
					{
						state.BrushColor = SE.Nereda.ProjectColors.PassiveStatus;
		
						starting.Visible = false;
						stopping.Visible = true;
		
						iActStateV = (short)e.FbStatus;
		
						if (this.ActuatorStatus != null)
							this.ActuatorStatus(iActStateV);
					}
		
					// ----------------------------------------------------
					// Motor stopped
					// CurrentSp = 0 and FbStatus = 0
					// ----------------------------------------------------
					else if (e.CurrentSp == 0 && e.FbStatus == 0)
					{
						state.BrushColor = SE.Nereda.ProjectColors.PassiveStatus;
		
						starting.Visible = false;
						stopping.Visible = false;
		
						iActStateV = 0;
		
						if (this.ActuatorStatus != null)
							this.ActuatorStatus(iActStateV);
					}
		
					// ----------------------------------------------------
					// Motor unknown state / feedback fault
					// FbStatus = 253 and FbReady = false
					// ----------------------------------------------------
					else if (e.FbStatus == 253 && e.FbReady == false)
					{
						state.BrushColor = new NxtControl.Drawing.BlinkColor("SE.Nereda.Orangwhite");
						state.Text = "?";
		
						starting.Visible = false;
						stopping.Visible = false;
		
						iActStateV = 253;
		
						if (this.ActuatorStatus != null)
							this.ActuatorStatus(iActStateV);
					}
		
					// ----------------------------------------------------
					// Motor not ready
					// ----------------------------------------------------
					else if (e.FbReady == false)
					{
						state.BrushColor = new NxtControl.Drawing.BlinkColor("SE.Nereda.Orangwhite");
						state.Text = "?";
		
						starting.Visible = false;
						stopping.Visible = false;
		
						iActStateV = 0;
		
						if (this.ActuatorStatus != null)
							this.ActuatorStatus(iActStateV);
					}
				}
		
				// ========================================================
				// DEVICE TYPE 2: VALVE
				// ========================================================
				else if (e.DeviceType == 2)
				{
					// ----------------------------------------------------
					// Valve opening
					// CurrentSp = 1
					// FbStatus = 2 or 253
					// FbReady = true
					// ----------------------------------------------------
					if (((e.CurrentSp == 1 && e.FbStatus == 2) ||
					     (e.CurrentSp == 1 && e.FbStatus == 253)) &&
					    e.FbReady == true)
					{
						state.BrushColor = SE.Nereda.ProjectColors.ActiveStatus;
		
						starting.Visible = true;
						stopping.Visible = false;
		
						iActStateV = (short)e.FbStatus;
		
						if (this.ActuatorStatus != null)
							this.ActuatorStatus(iActStateV);
					}
		
					// ----------------------------------------------------
					// Valve opened
					// CurrentSp = 1 and FbStatus = 1
					// ----------------------------------------------------
					else if (e.CurrentSp == 1 && e.FbStatus == 1)
					{
						state.BrushColor = SE.Nereda.ProjectColors.ActiveStatus;
		
						starting.Visible = false;
						stopping.Visible = false;
		
						iActStateV = (short)e.FbStatus;
		
						if (this.ActuatorStatus != null)
							this.ActuatorStatus(iActStateV);
					}
		
					// ----------------------------------------------------
					// Valve closing
					// CurrentSp = 2
					// FbStatus = 1 or 253
					// FbReady = true
					// ----------------------------------------------------
					else if (((e.CurrentSp == 2 && e.FbStatus == 1) ||
					          (e.CurrentSp == 2 && e.FbStatus == 253)) &&
					         e.FbReady == true)
					{
						state.BrushColor = SE.Nereda.ProjectColors.PassiveStatus;
		
						starting.Visible = false;
						stopping.Visible = true;
		
						iActStateV = (short)e.FbStatus;
		
						if (this.ActuatorStatus != null)
							this.ActuatorStatus(iActStateV);
					}
		
					// ----------------------------------------------------
					// Valve closed
					// CurrentSp = 2 and FbStatus = 2
					// ----------------------------------------------------
					else if (e.CurrentSp == 2 && e.FbStatus == 2)
					{
						state.BrushColor = SE.Nereda.ProjectColors.PassiveStatus;
		
						starting.Visible = false;
						stopping.Visible = false;
		
						iActStateV = 0;
		
						if (this.ActuatorStatus != null)
							this.ActuatorStatus(iActStateV);
					}
		
					// ----------------------------------------------------
					// Valve unknown state / feedback fault
					// FbStatus = 253 and FbReady = false
					// ----------------------------------------------------
					else if (e.FbStatus == 253 && e.FbReady == false)
					{
						state.BrushColor = new NxtControl.Drawing.BlinkColor("SE.Nereda.Orangwhite");
						state.Text = "?";
		
						starting.Visible = false;
						stopping.Visible = false;
		
						iActStateV = 253;
		
						if (this.ActuatorStatus != null)
							this.ActuatorStatus(iActStateV);
					}
		
					// ----------------------------------------------------
					// Valve not ready
					// ----------------------------------------------------
					else if (e.FbReady == false)
					{
						state.BrushColor = new NxtControl.Drawing.BlinkColor("SE.Nereda.Orangwhite");
						state.Text = "?";
		
						starting.Visible = false;
						stopping.Visible = false;
		
						iActStateV = 0;
		
						if (this.ActuatorStatus != null)
							this.ActuatorStatus(iActStateV);
					}
				}
		
				// ========================================================
				// Send actuator state confirmation
				// ========================================================
				FireEvent_CNF_ACT_STATE(iActStateV);
		
				// ========================================================
				// Control mode management
				// ========================================================
		
				// Program mode
				if (e.Prog == true)
				{
					Mode.Text = "P";
		
					iManV = false;
		
					if (this.ActManModeStatus != null)
						this.ActManModeStatus(iManV);
				}
		
				// Operator mode
				if (e.Oper == true)
				{
					Mode.Text = "O";
		
					iManV = false;
		
					if (this.ActManModeStatus != null)
						this.ActManModeStatus(iManV);
				}
		
				// Remote mode
				ManuelMode.Visible = (bool) e.Remote || (bool)e.Oper;
				if (e.Remote == true)
				{
					Mode.Text = "R";
		
					iManV = true;
		
					if (this.ActManModeStatus != null)
						this.ActManModeStatus(iManV);
				}
				
				// Interlock
				if (e.Interlocked == true)
				{
					Mode.Text = "Ilck";
					starting.Visible = false;
					stopping.Visible = false;
					state.BrushColor = new NxtControl.Drawing.BlinkColor("SE.Nereda.Orangwhite");
					iActStateV = 10;
					
					// Send actuator state value
					if (this.ActuatorStatus != null)
						this.ActuatorStatus(iActStateV);
				}
			}
		}
	}
}
