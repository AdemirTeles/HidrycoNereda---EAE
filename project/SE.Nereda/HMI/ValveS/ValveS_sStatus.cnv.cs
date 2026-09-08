/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 6/24/2026
 * Time: 11:46 AM
 * 
 */

using System;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.ValveS
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
				Status.Text = "Closed";
			}
			if(StateValue == 1){
				Status.BrushColor = SE.Nereda.ProjectColors.ActiveStatus;
				Status.Text = "Opened";
			}
			if(StateValue == 253){
				Status.BrushColor = new NxtControl.Drawing.BlinkColor("SE.Nereda.Orangwhite");
				Status.Text = "?";
			}
			if(StateValue == 100){
				Status.BrushColor = SE.Nereda.ProjectColors.PowerOFF;
				Status.Text = "OFF";
			}
		}
	}
}
