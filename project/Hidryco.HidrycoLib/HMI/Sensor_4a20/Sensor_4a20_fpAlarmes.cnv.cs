/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 1/29/2026
 * Time: 10:57 AM
 * 
 */

using System;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Faceplates.Sensor_4a20
{
	/// <summary>
	/// Description of Faceplate1.
	/// </summary>
	public partial class fpAlarmes : NxtControl.GuiFramework.HMIFaceplate
	{
		public fpAlarmes()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
		}

		void BtnResetAlarmesClick(object sender, EventArgs e)
		{
			FireEvent_E_RESET_ALARMES();
		}

	}
}
