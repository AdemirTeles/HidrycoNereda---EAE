/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 6/24/2026
 * Time: 10:03 AM
 * 
 */

using System;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.FlushCdt
{
	/// <summary>
	/// Description of sForce.
	/// </summary>
	public partial class sForce : NxtControl.GuiFramework.HMISymbol
	{
		public sForce()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			this.REQ_ITEMS_Fired += REQ_ITEMS_Fired_EventHandler;
		}

		void REQ_ITEMS_Fired_EventHandler(object sender, REQ_ITEMSEventArgs e)
		{
			// TODO: Implement REQ_ITEMS_Fired_EventHandler
			FlushCdtName.Text = e.FlushName;
		}
	}
}
