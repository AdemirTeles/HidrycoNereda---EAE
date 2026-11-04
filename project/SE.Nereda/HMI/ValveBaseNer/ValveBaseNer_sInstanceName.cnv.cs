/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 3/12/2025
 * Time: 3:28 PM
 * 
 */

using System;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.ValveBaseNer
{
	/// <summary>
	/// Description of InstanceName.
	/// </summary>
	public partial class sInstanceName : SE.App2Base.Symbols.SEAppLibHMISymbol
	{
		public sInstanceName()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
		}
		
		
		public override void UpdateTagDisplayName()
		{
			base.UpdateTagDisplayName();
			aliasDisplayLabel1.CustomInstanceName = TagDisplayName;
		}
		
	}
}
