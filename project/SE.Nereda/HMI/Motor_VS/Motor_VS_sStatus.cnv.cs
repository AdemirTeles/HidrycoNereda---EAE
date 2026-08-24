/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 6/26/2026
 * Time: 2:28 PM
 * 
 */

using System;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.Motor_VS
{
	/// <summary>
	/// Description of sStatus.
	/// </summary>
	public partial class sStatus : NxtControl.GuiFramework.HMISymbol
	{
		public sStatus()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
		}

		void StateActuatorStatus(short StateValue)
		{
			// TODO: Implement StateActuatorStatus
			if(StateValue == 0 || StateValue == 254){
				Status.BrushColor = SE.Nereda.ProjectColors.PassiveStatus;
				Status.Text = "Stopped";
			}
			if(StateValue == 1){
				Status.BrushColor = SE.Nereda.ProjectColors.ActiveStatus;
				Status.Text = "Running";
			}
			if(StateValue == 253){
				Status.BrushColor = new NxtControl.Drawing.BlinkColor("SE.Nereda.Orangwhite");
				Status.Text = "?";
			}
			if(StateValue == 100){
				Status.BrushColor = SE.Nereda.ProjectColors.PowerOFF;
				Status.Text = "OFF";
			}
			if(StateValue == 10){
				Status.BrushColor = SE.Nereda.ProjectColors.PassiveStatus;
				Status.Text = "OFF";
			}
		}
	}
}
