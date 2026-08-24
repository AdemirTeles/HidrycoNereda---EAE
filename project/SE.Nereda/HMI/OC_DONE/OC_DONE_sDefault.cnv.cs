/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 7/10/2026
 * Time: 4:53 PM
 * 
 */

using System;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.OC_DONE
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
			FireEvent_OC_DONE(true);
		}

		void OC_DoneValueChanged(object sender, ValueChangedEventArgs e)
		{
			// TODO: Implement OC_DoneValueChanged
			FireEvent_OC_DONE(true);
			Fire();
		}
		
		void Fire(){
			FireEvent_OC_DONE(true);
		}

		void OC_DoneOutputValueChanged(object sender, ValueChangedEventArgs e)
		{
			// TODO: Implement OC_DoneOutputValueChanged
			FireEvent_OC_DONE(true);
			Fire();
		}
	}
}
