/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 8/3/2026
 * Time: 3:11 PM
 * 
 */

using System;
using NxtControl.GuiFramework;

namespace SE.Nereda.Faceplates.AutoResetCdt
{
	/// <summary>
	/// Description of fpReset.
	/// </summary>
	public partial class fpReset : NxtControl.GuiFramework.HMIFaceplate
	{
		float iRNbr;
		public fpReset()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
		}

//		void CurrResetNbrValueChanged(object sender, ValueChangedEventArgs e)
//		{
//			// TODO: Implement CurrResetNbrValueChanged
//			iRNbr = (float) e.Value - 1;
//			if(iRNbr < 0){
//				RNbr.Text = 0.ToString();
//			}
//			else{
//				RNbr.Text = iRNbr.ToString();
//			}
//		}
	}
}
