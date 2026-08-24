/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 6/16/2026
 * Time: 3:42 PM
 * 
 */

using System;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.MixerLogic
{
	/// <summary>
	/// Description of sMixer.
	/// </summary>
	public partial class sMixer : NxtControl.GuiFramework.HMISymbol
	{
		public sMixer()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			this.MIXER_Fired += MIXER_Fired_EventHandler;
			MixerON.Visible = false;
			MixerOFF.Visible = true;
		}

		void MIXER_Fired_EventHandler(object sender, MIXEREventArgs e)
		{
			// TODO: Implement MIXER_Fired_EventHandler
			MixerON.Visible = (bool) e.FbMixerRun;
			MixerOFF.Visible = (bool) !e.FbMixerRun;
		}
	}
}
