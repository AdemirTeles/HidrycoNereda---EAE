/*
 * Created by EcoStruxure Automation Expert.
 * User: SESA583220
 * Date: 10/4/2022
 * Time: 8:49 AM
 * 
 */

using System;
using NxtControl.GuiFramework;
using System.Threading.Tasks;

namespace SE.Nereda.Symbols.Mode
{
	/// <summary>
	/// Description of ResetCommand.
	/// </summary>
	public partial class ResetReactor2 : NxtControl.GuiFramework.HMISymbol
	{
		public ResetReactor2()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
		}


		void Reset_CommandOutputValueChanged(object sender, ValueChangedEventArgs e)
		{
			Task.Delay(1000).ContinueWith(t=> Reset_Command.Checked = false);
		}
	}
}
