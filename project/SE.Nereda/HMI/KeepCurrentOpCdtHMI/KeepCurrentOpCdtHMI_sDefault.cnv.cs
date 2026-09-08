/*
 * Created by EcoStruxure Automation Expert.
 * User: SESA713705
 * Date: 8/20/2024
 * Time: 11:59 AM
 * 
 */

using System;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.KeepCurrentOpCdtHMI
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
			this.NEED_UPDATE_Fired += NEED_UPDATE_Fired_EventHandler;
		}

		void NEED_UPDATE_Fired_EventHandler(object sender, NEED_UPDATEEventArgs e)
		{
			// TODO: Implement NEED_UPDATE_Fired_EventHandler
			if(e.NeedUpdate == true){
				UpdateOpCndt.Enabled = true;
			}
			else{
				UpdateOpCndt.Checked = false;
				UpdateOpCndt.Enabled = false;
			}
		}
	}
}
