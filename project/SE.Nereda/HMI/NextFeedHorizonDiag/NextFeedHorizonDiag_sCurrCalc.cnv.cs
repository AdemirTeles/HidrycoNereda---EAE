/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 10/19/2026
 * Time: 12:57 PM
 * 
 */

using System;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.NextFeedHorizonDiag
{
	/// <summary>
	/// Description of sCurrCalc.
	/// </summary>
	public partial class sCurrCalc : NxtControl.GuiFramework.HMISymbol
	{
		public sCurrCalc()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			this.CURR_Fired += CURR_Fired_EventHandler;
		}

		void CURR_Fired_EventHandler(object sender, CURREventArgs e)
		{
			// TODO: Implement CURR_Fired_EventHandler
			if(e.CurrTimesFed == 0){
				CalcResult.Text = e.CurrNextFeedHorizon.ToString() + " = " + "(" + e.CurrI_R.ToString() + " - 1)" + " x " + e.CurrStartFeedInterval.ToString() + " - " + e.CurrFallBackElapsedTime.ToString() + " + " + e.CurrSettleTime.ToString();
			}
			
			else if(e.CurrTimesFed >= 1){
				CalcResult.Text = e.CurrNextFeedHorizon.ToString() + " = " + "(" + e.CurrNbrRAv.ToString() + " x " + e.CurrStartFeedInterval.ToString() + ")" + " - " + e.CurrRecipeElapsedTime.ToString();
			}
		}
	}
}
