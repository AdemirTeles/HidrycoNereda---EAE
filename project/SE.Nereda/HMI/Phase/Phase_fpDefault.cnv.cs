/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 6/5/2026
 * Time: 9:38 AM
 * 
 */

using System;
using NxtControl.GuiFramework;

namespace SE.Nereda.Faceplates.Phase
{
	/// <summary>
	/// Description of fpDefault.
	/// </summary>
	public partial class fpDefault : NxtControl.GuiFramework.HMIFaceplate
	{
		public fpDefault()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			this.CURR_STATE_Fired += CURR_STATE_Fired_EventHandler;
			this.REQ_PHASE_NAME_Fired += REQ_PHASE_NAME_Fired_EventHandler;
			this.CURR_MODE_Fired += CURR_MODE_Fired_EventHandler;
			this.RESET_FORCE_TRS_Fired += RESET_FORCE_TRS_Fired_EventHandler;
			FTrs1.Visible = FTrs2.Visible = FTrs3.Visible = FTrs4.Visible =
			FTrs5.Visible = FTrs6.Visible = FTrs7.Visible = FTrs8.Visible =
			FTrs9.Visible = FTrs10.Visible = FTrs11.Visible = FTrs12.Visible = ActivateForce.Checked = false;
			this.RESET_BTN_MAN_Fired += RESET_BTN_MAN_Fired_EventHandler;
		}

		void CURR_STATE_Fired_EventHandler(object sender, SE.Nereda.Symbols.Phase.CURR_STATEEventArgs e)
		{
			// TODO: Implement CURR_STATE_Fired_EventHandler
			State0.BrushColor = new NxtControl.Drawing.Color(186, 186, 186);
			State1.BrushColor = new NxtControl.Drawing.Color(186, 186, 186);
			State2.BrushColor = new NxtControl.Drawing.Color(186, 186, 186);
			State3.BrushColor = new NxtControl.Drawing.Color(186, 186, 186);
			State4.BrushColor = new NxtControl.Drawing.Color(186, 186, 186);
			State5.BrushColor = new NxtControl.Drawing.Color(186, 186, 186);
			State6.BrushColor = new NxtControl.Drawing.Color(186, 186, 186);

			switch (e.Grafcet)
			{
			    case 0: //Ready
					State0.BrushColor = new NxtControl.Drawing.Color(255,255,0);
					
					if(e.PrevState == 3 && e.PrevPrevState == 2){
						FromReady.PenColor = Ready2Starting.PenColor = Starting2Run.PenColor = Run2Stopping.PenColor = Stopping2Ready1.PenColor =
						Stopping2Ready2.PenColor = ToReady1.PenColor = ToReady2.PenColor = ToReady3.PenColor = new NxtControl.Drawing.Color(0,255,0);
					}
					else if(e.PrevState == 5){
						ToReady1.PenColor = ToReady2.PenColor = ToReady3.PenColor = Aborted2Ready.PenColor = IlckAborted2Ready.PenColor = Stopping2Ready2.PenColor = new NxtControl.Drawing.Color(0,255,0);
					}
					else if(e.PrevState == 6){
						ToReady1.PenColor = ToReady2.PenColor = ToReady3.PenColor = Interlocked2Ready1.PenColor = Interlocked2Ready2.PenColor = IlckAborted2Ready.PenColor = Stopping2Ready2.PenColor = new NxtControl.Drawing.Color(0,255,0);
					}
			        break;
			
			    case 1: //Starting
			        State1.BrushColor = new NxtControl.Drawing.Color(255,255,0);
			        
			        if(e.PrevState == 0){
			        	FromReady.PenColor = Ready2Starting.PenColor = new NxtControl.Drawing.Color(0,255,0);
			        	
			        	Starting2Run.PenColor = Run2Stopping.PenColor = ToReady1.PenColor = ToReady2.PenColor = ToReady3.PenColor =
			        	Ready2Ilck1.PenColor = Ready2Ilck2.PenColor = Starting2Abort.PenColor = ToAborting1.PenColor = 
			        	Run2Abort.PenColor = ToAborting2.PenColor = Stopping2Abort.PenColor = ToAborting3.PenColor = 
			        	Aborting2Aborted.PenColor = Aborted2Interlocked1.PenColor = ReadyAborted2Interlocked2.PenColor = Interlocked2Ready1.PenColor = 
			        	Interlocked2Ready2.PenColor = Aborted2Ready.PenColor = IlckAborted2Ready.PenColor = Stopping2Ready1.PenColor = 
			        	Stopping2Ready2.PenColor = new NxtControl.Drawing.Color(0,0,0);
			        } 
			        break;
			
			    case 2: //Run
			        State2.BrushColor = new NxtControl.Drawing.Color(255,255,0);
			        
			        if(e.PrevState == 1 && e.PrevPrevState == 0){
			        	FromReady.PenColor = Ready2Starting.PenColor = Starting2Run.PenColor = new NxtControl.Drawing.Color(0,255,0);
			        }   
				    break;
			        
			    case 3: //Stopping
			        State3.BrushColor = new NxtControl.Drawing.Color(255,255,0);
			        
			        if(e.PrevState == 2 && e.PrevPrevState == 1){
			        	FromReady.PenColor = Ready2Starting.PenColor = Starting2Run.PenColor = Run2Stopping.PenColor = new NxtControl.Drawing.Color(0,255,0);
			        }
			        break;
			    
			    case 4: //Aborting
			        State4.BrushColor = new NxtControl.Drawing.Color(255,255,0);
			        
			        if(e.PrevState == 1 && e.PrevPrevState == 0){ //From Ready -> Starting -> Aborting
			        	FromReady.PenColor = Ready2Starting.PenColor = Starting2Abort.PenColor = ToAborting1.PenColor = ToAborting2.PenColor = ToAborting3.PenColor = new NxtControl.Drawing.Color(0,255,0);
			        }
			        
			        if(e.PrevState == 2 && e.PrevPrevState == 1){ //From Ready -> Starting -> Running -> Aborting
			        	FromReady.PenColor = Ready2Starting.PenColor = Starting2Run.PenColor = Run2Abort.PenColor = ToAborting2.PenColor = ToAborting3.PenColor = new NxtControl.Drawing.Color(0,255,0);
			        }

			        if(e.PrevState == 3 && e.PrevPrevState == 2){ //From Ready -> Starting -> Running -> Stopping -> Aborting
			        	FromReady.PenColor = Ready2Starting.PenColor = Starting2Run.PenColor = Run2Stopping.PenColor = Stopping2Abort.PenColor = ToAborting3.PenColor = new NxtControl.Drawing.Color(0,255,0);
			        }
			        break;
			        
			    case 5: //Aborted
			        State5.BrushColor = new NxtControl.Drawing.Color(255,255,0);
			        Aborting2Aborted.PenColor = new NxtControl.Drawing.Color(0,255,0);
			        
			        if(e.PrevPrevState == 1){ //From Ready -> Starting -> Aborting
			        	FromReady.PenColor = Ready2Starting.PenColor = Starting2Abort.PenColor = ToAborting1.PenColor = ToAborting2.PenColor = ToAborting3.PenColor = new NxtControl.Drawing.Color(0,255,0);
			        }
			        
			        if(e.PrevPrevState == 2){ //From Ready -> Starting -> Running -> Aborting
			        	FromReady.PenColor = Ready2Starting.PenColor = Starting2Run.PenColor = Run2Abort.PenColor = ToAborting2.PenColor = ToAborting3.PenColor = new NxtControl.Drawing.Color(0,255,0);
			        }

			        if(e.PrevPrevState == 3){ //From Ready -> Starting -> Running -> Stopping -> Aborting
			        	FromReady.PenColor = Ready2Starting.PenColor = Starting2Run.PenColor = Run2Stopping.PenColor = Stopping2Abort.PenColor = ToAborting3.PenColor = new NxtControl.Drawing.Color(0,255,0);
			        }
			        break;
			    
			    case 6: //Interlocked
			        State6.BrushColor = new NxtControl.Drawing.Color(255,255,0);
			        if(e.PrevState == 0){
			        	FromReady.PenColor = Ready2Ilck1.PenColor = Ready2Ilck2.PenColor = ReadyAborted2Interlocked2.PenColor = new NxtControl.Drawing.Color(0,255,0);
			        	
			        	Ready2Starting.PenColor = Starting2Run.PenColor = Run2Stopping.PenColor = ToReady1.PenColor = ToReady2.PenColor = ToReady3.PenColor =
			        	Starting2Abort.PenColor = ToAborting1.PenColor = 
			        	Run2Abort.PenColor = ToAborting2.PenColor = Stopping2Abort.PenColor = ToAborting3.PenColor = 
			        	Aborting2Aborted.PenColor = Aborted2Interlocked1.PenColor = Interlocked2Ready1.PenColor = 
			        	Interlocked2Ready2.PenColor = Aborted2Ready.PenColor = IlckAborted2Ready.PenColor = Stopping2Ready1.PenColor = 
			        	Stopping2Ready2.PenColor = new NxtControl.Drawing.Color(0,0,0);
			        }
			        else if(e.PrevState == 5){
			        	Aborted2Interlocked1.PenColor = ReadyAborted2Interlocked2.PenColor = new NxtControl.Drawing.Color(0,255,0);
			        }
			        break;
			}
		}

		void ManStartClick(object sender, EventArgs e)
		{
			// TODO: Implement ManStartClick
			FireEvent_MAN_START(true);
			FireEvent_MAN_STOP(false);
			FireEvent_MAN_RESET(false);
		}

		void ManStopClick(object sender, EventArgs e)
		{
			// TODO: Implement ManStopClick
			FireEvent_MAN_START(false);
			FireEvent_MAN_STOP(true);
			FireEvent_MAN_RESET(false);
		}

		void ManResetClick(object sender, EventArgs e)
		{
			// TODO: Implement ManResetClick
			FireEvent_MAN_START(false);
			FireEvent_MAN_STOP(false);
			FireEvent_MAN_RESET(true);
		}

		void REQ_PHASE_NAME_Fired_EventHandler(object sender, SE.Nereda.Symbols.Phase.REQ_PHASE_NAMEEventArgs e)
		{
			// TODO: Implement REQ_PHASE_NAME_Fired_EventHandler
			PhaseName.Text = "Phase: " + e.PhaseName;
		}

		void CURR_MODE_Fired_EventHandler(object sender, SE.Nereda.Symbols.Phase.CURR_MODEEventArgs e)
		{
			// TODO: Implement CURR_MODE_Fired_EventHandler
			if(e.CurrMode == 0){ //Automatic Mode
				ManStart.Enabled = ManStop.Enabled = ManReset.Enabled = false;
				NoActionAllowed.Text = "Automatic mode : No action allowed";
				NoActionAllowed.Visible = true;
			}
			else if(e.CurrMode == 1){ //OFF Mode
				ManStart.Enabled = ManStop.Enabled = ManReset.Enabled = false;
				NoActionAllowed.Text = "OFF mode : No action allowed";
				NoActionAllowed.Visible = true;
				FireEvent_MAN_START(false);
				FireEvent_MAN_STOP(false);
				FireEvent_MAN_RESET(false);
			}
			else if(e.CurrMode == 2){ //Manuel Mode
				ManStart.Enabled = ManStop.Enabled = ManReset.Enabled = true;
				NoActionAllowed.Visible = false;
			}
			else if(e.CurrMode == 3){ //Emergency Mode
				ManStart.Enabled = ManStop.Enabled = ManReset.Enabled = false;
				NoActionAllowed.Text = "Emergency mode : No action allowed";
				NoActionAllowed.Visible = true;
			}
		}

		void ActivateForceCheckedChanged(object sender, EventArgs e)
		{
			// TODO: Implement ActivateForceCheckedChanged
			FTrs1.Visible = FTrs2.Visible = FTrs3.Visible = FTrs4.Visible =
			FTrs5.Visible = FTrs6.Visible = FTrs7.Visible = FTrs8.Visible =
			FTrs9.Visible = FTrs10.Visible = FTrs11.Visible = FTrs12.Visible = ActivateForce.Checked;
			
			FireEvent_FORCE(0);
		}

		void FTrs1Click(object sender, EventArgs e)
		{
			// TODO: Implement FTrs1Click
			FireEvent_FORCE(1);
		}

		void FTrs2Click(object sender, EventArgs e)
		{
			// TODO: Implement FTrs2Click
			FireEvent_FORCE(2);
		}

		void FTrs3Click(object sender, EventArgs e)
		{
			// TODO: Implement FTrs3Click
			FireEvent_FORCE(3);
		}

		void FTrs4Click(object sender, EventArgs e)
		{
			// TODO: Implement FTrs4Click
			FireEvent_FORCE(4);
		}

		void FTrs5Click(object sender, EventArgs e)
		{
			// TODO: Implement FTrs5Click
			FireEvent_FORCE(5);
		}

		void FTrs6Click(object sender, EventArgs e)
		{
			// TODO: Implement FTrs6Click
			FireEvent_FORCE(6);
		}

		void FTrs7Click(object sender, EventArgs e)
		{
			// TODO: Implement FTrs7Click
			FireEvent_FORCE(7);
		}

		void FTrs8Click(object sender, EventArgs e)
		{
			// TODO: Implement FTrs8Click
			FireEvent_FORCE(8);
		}

		void FTrs9Click(object sender, EventArgs e)
		{
			// TODO: Implement FTrs9Click
			FireEvent_FORCE(9);
		}

		void FTrs10Click(object sender, EventArgs e)
		{
			// TODO: Implement FTrs10Click
			FireEvent_FORCE(10);
		}

		void FTrs11Click(object sender, EventArgs e)
		{
			// TODO: Implement FTrs11Click
			FireEvent_FORCE(11);
		}

		void FTrs12Click(object sender, EventArgs e)
		{
			// TODO: Implement FTrs12Click
			FireEvent_FORCE(12);
		}

		void RESET_FORCE_TRS_Fired_EventHandler(object sender, SE.Nereda.Symbols.Phase.RESET_FORCE_TRSEventArgs e)
		{
			// TODO: Implement RESET_FORCE_TRS_Fired_EventHandler
			FireEvent_FORCE(0);
		}

		void RESET_BTN_MAN_Fired_EventHandler(object sender, SE.Nereda.Symbols.Phase.RESET_BTN_MANEventArgs e)
		{
			// TODO: Implement RESET_BTN_MAN_Fired_EventHandler
			FireEvent_MAN_START(false);
			FireEvent_MAN_STOP(false);
			FireEvent_MAN_RESET(false);
		}
	}
}
