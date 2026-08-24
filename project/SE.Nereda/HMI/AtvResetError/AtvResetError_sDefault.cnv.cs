/*
 * Created by EcoStruxure Automation Expert.
 * User: SESA713705
 * Date: 8/19/2024
 * Time: 3:34 PM
 * 
 */

using System;
using NxtControl.GuiFramework;
using System.ComponentModel;

namespace SE.Nereda.Symbols.AtvResetError
{
	/// <summary>
	/// Description of sDefault.
	/// </summary>
	public partial class sDefault : NxtControl.GuiFramework.HMISymbol
	{
		private string _NAME = "ObjectName";
		
		public sDefault()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
		}
		
		[RefreshProperties(RefreshProperties.Repaint)]
		[Category("Tagnames")]
		[DisplayName("Name_Object Code")]
		
		public string _iBL001
		{
			get{
				return _NAME;
			}
			set{
				_NAME = value;
				Name_Object.Text = value.ToString();
			}
		}

		void Execute_11ValueChanged(object sender, ValueChangedEventArgs e)
		{
			// TODO: Implement Execute_11ValueChanged
			if(NeedReset.Value == true){
				ResetHMI.Enabled = true;
			}
			else{
				ResetHMI.Enabled = false;
				ResetHMI.Checked = false;
			}
		}
	}
}
