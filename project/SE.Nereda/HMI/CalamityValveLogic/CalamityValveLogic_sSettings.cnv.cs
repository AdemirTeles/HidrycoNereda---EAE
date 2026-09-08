/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 6/29/2026
 * Time: 10:07 AM
 * 
 */

using System;
using NxtControl.GuiFramework;
using System.ComponentModel;

namespace SE.Nereda.Symbols.CalamityValveLogic
{
	/// <summary>
	/// Description of sSettings.
	/// </summary>
	public partial class sSettings : NxtControl.GuiFramework.HMISymbol
	{
		private string _VLVN = "Valve xxx";
		public sSettings()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
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
