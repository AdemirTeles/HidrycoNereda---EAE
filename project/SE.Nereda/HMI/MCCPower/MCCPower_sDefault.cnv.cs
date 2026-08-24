/*
 * Created by EcoStruxure Automation Expert.
 * User: SESA371406
 * Date: 3/8/2024
 * Time: 2:03 PM
 * 
 */

using System;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.MCCPower
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

		void MCCPowerValueChanged(object sender, ValueChangedEventArgs e)
		{
			// TODO: Implement MCCPowerValueChanged
			
			if (Convert.ToBoolean (MCCPower.Value))
			{
			label2.Text = "MCC POWER ON";
			label2.TextColor = new NxtControl.Drawing.Color ("Green");
			roundedRectangle1.PenColor = new NxtControl.Drawing.Color("Green");
			}
			else
			{
			label2.Text = "MCC POWER Default";
            label2.TextColor = new NxtControl.Drawing.Color ("Red");			
			roundedRectangle1.PenColor = new NxtControl.Drawing.BlinkColor("AlarmGoneNotAcked");
			}		
		}

		
	}
}
