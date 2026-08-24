/*
 * Created by EcoStruxure Automation Expert.
 * User: SESA583220
 * Date: 10/3/2022
 * Time: 5:35 PM
 * 
 */

using System;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.Mode
{
	/// <summary>
	/// Description of Symbol1.
	/// </summary>
	public partial class ReactorMode : NxtControl.GuiFramework.HMISymbol
	{
		public ReactorMode()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
		}
		void EmergencyValueChanged(object sender, ValueChangedEventArgs e)
		{
			// TODO: Implement EmergencyValueChanged
			if (Convert.ToBoolean(Emergency.Value))
			    ModeTxt.Text = "Emergency"; 
		}
		
		void AutoValueChanged(object sender, ValueChangedEventArgs e)
		{
			// TODO: Implement AutoValueChanged
			if (Convert.ToBoolean(Auto.Value))
			    ModeTxt.Text = "Automatic";    
		}

		void ManualValueChanged(object sender, ValueChangedEventArgs e)
		{
			// TODO: Implement ManualValueChanged
			if (Convert.ToBoolean(Manual.Value))
			    ModeTxt.Text = "Manual";    
		}

		void OFFValueChanged(object sender, ValueChangedEventArgs e)
		{
			// TODO: Implement OFFValueChanged
			if (Convert.ToBoolean(OFF.Value))
			{
			    ModeTxt.Text = "OFF"; 
			}
		}	
	}
}
