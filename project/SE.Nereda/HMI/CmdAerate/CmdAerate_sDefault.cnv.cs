/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 6/7/2026
 * Time: 4:40 PM
 * 
 */

using System;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.CmdAerate
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

		void D_C_Sel_1ValueChanged(object sender, ValueChangedEventArgs e)
		{
			// TODO: Implement D_C_Sel_1ValueChanged
			AirValveAerationGridMan.Enabled = AirValveInfluentGridMan.Enabled = !((bool)e.Value);
		}
	}
}
