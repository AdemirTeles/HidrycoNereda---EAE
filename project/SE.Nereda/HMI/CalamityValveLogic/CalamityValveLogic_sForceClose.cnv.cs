/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 6/29/2026
 * Time: 2:53 PM
 * 
 */

using System;
using NxtControl.GuiFramework;
using System.ComponentModel;

namespace SE.Nereda.Symbols.CalamityValveLogic
{
	/// <summary>
	/// Description of sForceClose.
	/// </summary>
	public partial class sForceClose : NxtControl.GuiFramework.HMISymbol
	{
		private string _VLVN = "46 2 AP izp 95 0xx";
		public sForceClose()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			this.RESET_BTNs_Fired += RESET_BTNs_Fired_EventHandler;
		}

		void ForceCloseClick(object sender, EventArgs e)
		{
			// TODO: Implement ForceCloseClick
			FireEvent_FORCE_CLOSE(true);
		}

		void RESET_BTNs_Fired_EventHandler(object sender, RESET_BTNsEventArgs e)
		{
			// TODO: Implement RESET_BTNs_Fired_EventHandler
			FireEvent_FORCE_CLOSE(false);
		}
		
		[RefreshProperties(RefreshProperties.Repaint)]
		[Category("Tagnames")]
		[DisplayName("Valve Name")]
		
		public string _iVLVN
		{
			get{
				return _VLVN;
			}
			set{
				_VLVN = value;
				ValveName.Text = value.ToString();
			}
		}
	}
}
