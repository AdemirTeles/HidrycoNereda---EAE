/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 6/3/2026
 * Time: 5:07 PM
 * 
 */

using System;
using NxtControl.GuiFramework;

namespace SE.Nereda.Faceplates.Motor_VS
{
	/// <summary>
	/// Description of fpOptions.
	/// </summary>
	public partial class fpOptions : NxtControl.GuiFramework.HMIFaceplate
	{
		public fpOptions()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			this.NEED_RESET_Fired += NEED_RESET_Fired_EventHandler;
		}

		void OpenMotFpClick(object sender, EventArgs e)
		{
			// TODO: Implement OpenMotFpClick
			this.BaseVs.DoOpenFaceplate("fpDefault");
		}

		void RearmBtnClick(object sender, EventArgs e)
		{
			// TODO: Implement RearmBtnClick
			FireEvent_RESET(true);
		}

		void NEED_RESET_Fired_EventHandler(object sender, SE.Nereda.Symbols.Motor_VS.NEED_RESETEventArgs e)
		{
			// TODO: Implement NEED_RESET_Fired_EventHandler
			RearmBtn.Enabled = (bool)e.NeedReset;
			if(e.NeedReset == false){
				FireEvent_RESET(false);
			}
		}
	}
}
