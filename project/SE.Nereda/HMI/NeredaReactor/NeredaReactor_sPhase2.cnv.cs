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
	public partial class sPhase2 : NxtControl.GuiFramework.HMISymbol
	{
		bool iEmergencyOn;
		public sPhase2()
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
					DisplayStatus.Text = "REATOR PRONTO";
					DisplayStatus.TextColor = new NxtControl.Drawing.Color(255, 255, 0);
					break;
				case 1:
					DisplayStatus.Text = "REATOR PARTINDO";
					DisplayStatus.TextColor = new NxtControl.Drawing.Color(255, 255, 0);
					break;
				case 2:
					DisplayStatus.Text = "REATOR EM OPERA\u00c7\u00c3O";
					DisplayStatus.TextColor = new NxtControl.Drawing.Color(255, 255, 0);
					break;
				case 3:
					DisplayStatus.Text = "REATOR PARANDO";
					DisplayStatus.TextColor = new NxtControl.Drawing.Color(255, 255, 0);
					break;
				case 5:
					DisplayStatus.Text = "REATOR ABORTANDO";
					DisplayStatus.TextColor = new NxtControl.Drawing.Color(255, 255, 0);
					break;
				case 6:
					DisplayStatus.Text = "REATOR ABORTADO";
					DisplayStatus.TextColor = new NxtControl.Drawing.Color(255, 0, 0);
					break;
				case 7:
					DisplayStatus.Text = "REATOR INTERTRAVADO";
					DisplayStatus.TextColor = new NxtControl.Drawing.Color(255, 0, 0);
					break;
				case 10:
					DisplayStatus.Text = "ESTADO DO REATOR";
					DisplayStatus.TextColor = new NxtControl.Drawing.Color(255, 255, 0);
					break;
				}
		}
	}
}
