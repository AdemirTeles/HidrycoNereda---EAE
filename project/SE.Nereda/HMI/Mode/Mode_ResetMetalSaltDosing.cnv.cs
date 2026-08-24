/*
 * Created by EcoStruxure Automation Expert.
 * User: SESA713705
 * Date: 8/30/2024
 * Time: 12:34 PM
 * 
 */

using System;
using NxtControl.GuiFramework;
using System.Threading.Tasks;


namespace SE.Nereda.Symbols.Mode
{
	/// <summary>
	/// Description of ResetMetalSaltDosing.
	/// </summary>
	public partial class ResetMetalSaltDosing : NxtControl.GuiFramework.HMISymbol
	{
		public ResetMetalSaltDosing()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
		}

		void Reset_CommandValueChanged(object sender, ValueChangedEventArgs e)
		{
			// TODO: Implement Reset_CommandValueChanged
			Task.Delay(1000).ContinueWith(u=> Reset_Command.Checked = false);
		}


	}
}
