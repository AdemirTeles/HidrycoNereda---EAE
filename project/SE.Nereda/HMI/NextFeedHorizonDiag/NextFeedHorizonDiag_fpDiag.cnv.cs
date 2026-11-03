/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 10/6/2026
 * Time: 3:58 PM
 * 
 */

using System;
using NxtControl.GuiFramework;

namespace SE.Nereda.Faceplates.NextFeedHorizonDiag
{
	/// <summary>
	/// Description of fpDiag.
	/// </summary>
	public partial class fpDiag : NxtControl.GuiFramework.HMIFaceplate
	{
		float CorrectValue;
		public fpDiag()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			this.REQ_Fired += REQ_Fired_EventHandler;
			this.RESET_BTNs_Fired += RESET_BTNs_Fired_EventHandler;
			this.CURR_Fired += CURR_Fired_EventHandler;
		}

		void REQ_Fired_EventHandler(object sender, SE.Nereda.Symbols.NextFeedHorizonDiag.REQEventArgs e)
		{
			// TODO: Implement REQ_Fired_EventHandler
			if(e.TimesFed >= 1){
				CalcResult.Text = e.NextFeedHorizon.ToString() + " = " + e.NextFeedHorizonPlant.ToString() + " + " + "(" + e.StartFeedInterval.ToString() + " x " + "(" + e.i_R.ToString() + " - 1))";
			
				CorrectValue = (float)(e.NextFeedHorizonPlant + (e.StartFeedInterval * (e.i_R - 1)));
				CorrectResult.Text = CorrectValue.ToString();
			}
			
			if(CorrectValue == (float)e.NextFeedHorizon){
				CorrectResult.BrushColor = new NxtControl.Drawing.Color(0,255,0);
			}
			else{
				CorrectResult.BrushColor = new NxtControl.Drawing.Color(255,0,0);
			}
		}

		void UpBtnClick(object sender, EventArgs e)
		{
			// TODO: Implement UpBtnClick
			FireEvent_UP_EO(true);
		}

		void DownBtnClick(object sender, EventArgs e)
		{
			// TODO: Implement DownBtnClick
			FireEvent_DOWN_EO(true);
		}

		void RESET_BTNs_Fired_EventHandler(object sender, SE.Nereda.Symbols.NextFeedHorizonDiag.RESET_BTNsEventArgs e)
		{
			// TODO: Implement RESET_BTNs_Fired_EventHandler
			FireEvent_UP_EO(false);
			FireEvent_DOWN_EO(false);
		}

		void CURR_Fired_EventHandler(object sender, SE.Nereda.Symbols.NextFeedHorizonDiag.CURREventArgs e)
		{
			// TODO: Implement CURR_Fired_EventHandler
			if(e.CurrTimesFed >= 1){
				Calc.Text = e.CurrNextFeedHorizon.ToString() + "   =   " + e.CurrNextFeedHorizonPlant.ToString() + "   +   " + " ( " + e.CurrStartFeedInterval.ToString() + "   x   " + " ( " + e.CurrI_R.ToString() + "  -  1 ) )";
				if((float)e.CurrNextFeedHorizon == (float)(e.CurrNextFeedHorizonPlant + (e.CurrStartFeedInterval * (e.CurrI_R - 1)))){
					Calc.Color = new NxtControl.Drawing.Color(24, 158, 58);
				}
				else{
					Calc.Color = new NxtControl.Drawing.Color(255, 0, 0);
				}
			}
		}
	}
}
