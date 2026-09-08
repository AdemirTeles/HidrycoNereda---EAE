/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 6/7/2026
 * Time: 3:01 PM
 * 
 */

using System;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.NeredaReactor
{
	/// <summary>
	/// Description of sDefault.
	/// </summary>
	public partial class sPhases : NxtControl.GuiFramework.HMISymbol
	{
		bool iEmergencyOn;
		public sPhases()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
		}

		void InStatusValueChanged(object sender, ValueChangedEventArgs e)
		{
			// TODO: Implement InStatusValueChanged
			switch(Convert.ToInt32(InStatus.Value))
				{
				case 0:
					DisplayStatus.Text = "REACTOR READY";
					DisplayStatus.TextColor = new NxtControl.Drawing.Color(255, 255, 0);
					break;
				case 1:
					DisplayStatus.Text = "REACTOR STARTING";
					DisplayStatus.TextColor = new NxtControl.Drawing.Color(255, 255, 0);
					break;
				case 2:
					DisplayStatus.Text = "REACTOR RUNNING";
					DisplayStatus.TextColor = new NxtControl.Drawing.Color(255, 255, 0);
					break;
				case 3:
					DisplayStatus.Text = "REACTOR STOPPING";
					DisplayStatus.TextColor = new NxtControl.Drawing.Color(255, 255, 0);
					break;
				case 5:
					DisplayStatus.Text = "REACTOR ABORTING";
					DisplayStatus.TextColor = new NxtControl.Drawing.Color(255, 255, 0);
					break;
				case 6:
					DisplayStatus.Text = "REACTOR ABORTED";
					DisplayStatus.TextColor = new NxtControl.Drawing.Color(255, 0, 0);
					break;
				case 7:
					DisplayStatus.Text = "REACTOR INTERLOCKED";
					DisplayStatus.TextColor = new NxtControl.Drawing.Color(255, 0, 0);
					break;
				case 10:
					DisplayStatus.Text = "REACTOR STATUS";
					DisplayStatus.TextColor = new NxtControl.Drawing.Color(255, 255, 0);
					break;
				}
		}
	}
}
