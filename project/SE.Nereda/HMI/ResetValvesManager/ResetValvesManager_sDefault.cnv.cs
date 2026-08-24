/*
 * Created by EcoStruxure Automation Expert.
 * User: SESA713705
 * Date: 8/20/2024
 * Time: 3:40 PM
 * 
 */

using System;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.ResetValvesManager
{
	/// <summary>
	/// Description of sDefault.
	/// </summary>
	public partial class sDefault : NxtControl.GuiFramework.HMISymbol
	{
		public sDefault()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			this.NEED_RESET_Fired += NEED_RESET_Fired_EventHandler;
		}

		void NEED_RESET_Fired_EventHandler(object sender, NEED_RESETEventArgs e)
		{
			// TODO: Implement NEED_RESET_Fired_EventHandler
			if(e.NeedReset == true){
				Reset.Enabled = true;
			}
			else{
				Reset.Checked = false;
				Reset.Enabled = false;
			}
		}
	}
}
