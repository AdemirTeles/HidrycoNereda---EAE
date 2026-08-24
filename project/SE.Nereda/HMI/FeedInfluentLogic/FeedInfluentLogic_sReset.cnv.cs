/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 6/18/2026
 * Time: 9:38 AM
 * 
 */

using System;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.FeedInfluentLogic
{
	/// <summary>
	/// Description of sReset.
	/// </summary>
	public partial class sReset : NxtControl.GuiFramework.HMISymbol
	{
		public sReset()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			this.RESET_BTNS_Fired += RESET_BTNS_Fired_EventHandler;
		}

		void ResetClick(object sender, EventArgs e)
		{
			// TODO: Implement ResetClick
			FireEvent_CNF_RESET_F_ILCK(true);
		}

		void RESET_BTNS_Fired_EventHandler(object sender, RESET_BTNSEventArgs e)
		{
			// TODO: Implement RESET_BTNS_Fired_EventHandler
			FireEvent_CNF_RESET_F_ILCK(false);
		}
	}
}
