/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 10/21/2026
 * Time: 11:30 AM
 * 
 */

using System;
using NxtControl.GuiFramework;

namespace SE.Nereda.Faceplates.EmergencyInit2
{
	/// <summary>
	/// Description of fpInitAction.
	/// </summary>
	public partial class fpInitAction : NxtControl.GuiFramework.HMIFaceplate
	{
		bool InEnoughTime;
		bool InInitCmd;
		bool InInitDone;
		bool InEmergencyON;
		int InInitStatus;
		public fpInitAction()
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
			Status();
		}

		void InitCmdValueChanged(object sender, ValueChangedEventArgs e)
		{
			// TODO: Implement InitCmdValueChanged
			InInitCmd = (bool) e.Value;
			Status();
		}

		void InitDoneValueChanged(object sender, ValueChangedEventArgs e)
		{
			// TODO: Implement InitDoneValueChanged
			InInitDone = (bool) e.Value;
			Status();
		}

		void InitStatusValueChanged(object sender, ValueChangedEventArgs e)
		{
			// TODO: Implement InitStatusValueChanged
			InInitStatus = (int) e.Value;
			Status();
		}

		void EmergencyONValueChanged(object sender, ValueChangedEventArgs e)
		{
			// TODO: Implement EmergencyONValueChanged
			InEmergencyON = (bool) e.Value;
			Status();
		}
		
		
		void Status(){
			if(InEmergencyON == false){
				EmerInitStatus.Text = "Emergency OFF";
			}
			else{
				if(InInitDone == false && InInitStatus == 0){
					EmerInitStatus.Text = "Initialization is not yet done";
				}
				if(InInitDone == true && InInitStatus == 0){
					EmerInitStatus.Text = "Initialization is done";
				}
				if(InInitStatus == 2){
					EmerInitStatus.Text = "Initialize to Step 2";
				}
				if(InInitStatus == 10){
					EmerInitStatus.Text = "Initialize to Step 10";
				}
			}	
		}
	}
}
