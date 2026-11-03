/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 10/21/2026
 * Time: 11:57 AM
 * 
 */

using System;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.EmergencyInit2
{
	/// <summary>
	/// Description of sInitStatus.
	/// </summary>
	public partial class sInitStatus : NxtControl.GuiFramework.HMISymbol
	{
		bool InEnoughTime;
		bool InInitCmd;
		bool InInitDone;
		bool InEmergencyON;
		int InInitStatus;
		public sInitStatus()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
		}

		void EnoughTimeValueChanged(object sender, ValueChangedEventArgs e)
		{
			// TODO: Implement EnoughTimeValueChanged
			InEnoughTime = (bool) e.Value;
		}

		void InitCmdValueChanged(object sender, ValueChangedEventArgs e)
		{
			// TODO: Implement InitCmdValueChanged
			InInitCmd = (bool) e.Value;
		}

		void InitDoneValueChanged(object sender, ValueChangedEventArgs e)
		{
			// TODO: Implement InitDoneValueChanged
			InInitDone = (bool) e.Value;
			Status();
		}

		void EmergencyONValueChanged(object sender, ValueChangedEventArgs e)
		{
			// TODO: Implement EmergencyONValueChanged
			InEmergencyON = (bool) e.Value;
			Status();
		}
		
		void InitStatus_1ValueChanged(object sender, ValueChangedEventArgs e)
		{
			// TODO: Implement InitStatus_1ValueChanged
			InInitStatus = InitStatus_1.Value;
			Status();
		}
		
		void Status(){
			if(InEmergencyON == false){
				EmerInitStatus.Text = "Emergency OFF";
			}
			else{
				if(InInitDone == false){
					if(InInitStatus == 0){
						EmerInitStatus.Text = "Initialization is not yet done";
					}
					if(InInitStatus == 1){
						EmerInitStatus.Text = "Initialize to Step 1";
					}
					if(InInitStatus == 2){
						EmerInitStatus.Text = "Initialize to Step 2";
					}
					if(InInitStatus == 10){
						EmerInitStatus.Text = "Initialize to Step 10";
					}
					if(InInitStatus == 200){
						EmerInitStatus.Text = "Waiting for Settle Time";
					}
				}
				else{
					EmerInitStatus.Text = "Initialization is done";
				}
			}	
		}
	}
}
