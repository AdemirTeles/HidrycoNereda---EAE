/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 6/7/2026
 * Time: 2:15 PM
 * 
 */

using System;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.EffluentCdt
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
		}

//		void FLUSH_RDY_Fired_EventHandler(object sender, FLUSH_RDYEventArgs e)
//		{
//			// TODO: Implement FLUSH_RDY_Fired_EventHandler
//			if(e.FlushReady == false){
//				Cdt.PenColor = new NxtControl.Drawing.BlinkColor("SE.Nereda.DevLEDRedFlash");
//			    Cdt.Pen.Width = 2;
//			}
//			else{
//				Cdt.PenColor = new NxtControl.Drawing.Color(0,0,0);
//			    Cdt.Pen.Width = 1;
//			}
//		}
	}
}
