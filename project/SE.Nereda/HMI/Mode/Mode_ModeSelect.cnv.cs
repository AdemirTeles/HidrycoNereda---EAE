/*
 * Created by EcoStruxure Automation Expert.
 * User: SESA371406
 * Date: 3/27/2024
 * Time: 8:47 AM
 * 
 */

using System;
using NxtControl.GuiFramework;

namespace SE.Nereda.Faceplates.Mode
{
	/// <summary>
	/// Description of ModeSelect.
	/// </summary>
	public partial class ModeSelect : NxtControl.GuiFramework.HMIFaceplate
	{
		int IndexSelected;
		int ifbMode;
		public ModeSelect()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			this.REQ_STATUS_Fired += REQ_STATUS_Fired_EventHandler;
		}

		void FbModeValueChanged(object sender, ValueChangedEventArgs e)
		{
			// TODO: Implement FbModeValueChanged
			ifbMode = (int) e.Value;
			Update();
		}

		void ModeSelectedIndexChanged(object sender, EventArgs e)
		{
			// TODO: Implement ModeSelectedIndexChanged
			IndexSelected = ModeSelector.SelectedIndex;
			FireEvent_MODE_HMI((short)IndexSelected);
		}

		void REQ_STATUS_Fired_EventHandler(object sender, SE.Nereda.Symbols.Mode.REQ_STATUSEventArgs e)
		{
			// TODO: Implement REQ_STATUS_Fired_EventHandler
			ifbMode = (int) e.fbMode;
			Update();
		}
		
		void Update(){
			ModeSelector.SelectedIndex = ifbMode;
		}
	}
}
