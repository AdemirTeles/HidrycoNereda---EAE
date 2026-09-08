/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 6/15/2026
 * Time: 10:21 AM
 * 
 */

using System;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.ValveS
{
	/// <summary>
	/// Description of sCounter.
	/// </summary>
	public partial class sCounter : NxtControl.GuiFramework.HMISymbol
	{
		int TimeS;
		int TimeM;
		int TimeH;
		public sCounter()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			this.OPD_Fired += OPD_Fired_EventHandler;
		}

		void OPD_Fired_EventHandler(object sender, OPDEventArgs e)
		{
			// TODO: Implement OPD_Fired_EventHandler
			TimeH = (int) e.Counter / 3600;
			TimeM = (int) (e.Counter % 3600) / 60;
			TimeS = (int) e.Counter % 60;
			
			Duration.Text = TimeH.ToString() + "h " + ": " + TimeM.ToString() + "min " + ": " + TimeS.ToString() + "s";
		}
	}
}
