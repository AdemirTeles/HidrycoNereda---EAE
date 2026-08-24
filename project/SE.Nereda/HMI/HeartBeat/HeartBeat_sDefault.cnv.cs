/*
 * Created by EcoStruxure Automation Expert.
 * User: SESA197029
 * Date: 25/02/2022
 * Time: 3:53 pm
 * 
 */

using System;
using System.Drawing;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.HeartBeat
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
			this.New_State_Fired += New_State_Fired_EventHandler;
		}

		void New_State_Fired_EventHandler(object sender, New_StateEventArgs e)
		{
			// TODO: Implement New_State_Fired_EventHandler
			if(e.State.Value)
			{
				this.label2.TextColor = new NxtControl.Drawing.BlinkColor("DevError");
				//this.label2.TextColor = NxtControl.Drawing.ProjectColors.DevLEDRedFlash;
			}
			else
			{
				this.label2.TextColor = new NxtControl.Drawing.Color("Green");
			}
			
		}
	}
}
