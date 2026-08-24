/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 6/12/2026
 * Time: 10:11 AM
 * 
 */

using System;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.DAerationLogic
{
	/// <summary>
	/// Description of sBlowersInfos.
	/// </summary>
	public partial class sBlowersInfos : NxtControl.GuiFramework.HMISymbol
	{
		int TimeM1;
		int TimeH1;
		
		int TimeM2;
		int TimeH2;
		public sBlowersInfos()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			this.BLS_OPD_Fired += BLS_OPD_Fired_EventHandler;
		}

		void BLS_OPD_Fired_EventHandler(object sender, BLS_OPDEventArgs e)
		{
			// TODO: Implement BLS_OPD_Fired_EventHandler
			TimeH1 = (int) e.BL1TotOpDur / 60;
			TimeM1 = (int) e.BL1TotOpDur % 60;
			
			TotRunDurBl1Txt.Text = TimeH1.ToString() + " h " + ": " + TimeM1.ToString() + " min ";
			
			TimeH2 = (int) e.BL2TotOpDur / 60;
			TimeM2 = (int) e.BL2TotOpDur % 60;
			
			TotRunDurBl2Txt.Text = TimeH2.ToString() + " h " + ": " + TimeM2.ToString() + " min ";
		}
	}
}
