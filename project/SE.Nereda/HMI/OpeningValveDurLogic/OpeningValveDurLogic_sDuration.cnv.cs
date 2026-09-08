/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 6/29/2026
 * Time: 10:22 AM
 * 
 */

using System;
using NxtControl.GuiFramework;
using System.ComponentModel;

namespace SE.Nereda.Symbols.OpeningValveDurLogic
{
	/// <summary>
	/// Description of sDuration.
	/// </summary>
	public partial class sDuration : NxtControl.GuiFramework.HMISymbol
	{
		private string _VLVN = "Valve xxx";
		public sDuration()
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
