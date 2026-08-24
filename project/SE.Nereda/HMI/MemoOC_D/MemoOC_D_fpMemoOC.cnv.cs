/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 8/17/2026
 * Time: 4:40 PM
 * 
 */

using System;
using NxtControl.GuiFramework;

namespace SE.Nereda.Faceplates.MemoOC_D
{
	/// <summary>
	/// Description of fpMemoOC.
	/// </summary>
	public partial class fpMemoOC : NxtControl.GuiFramework.HMIFaceplate
	{
		public fpMemoOC()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
		}

		void OCStatus_Curr_1ValueChanged(object sender, ValueChangedEventArgs e)
		{
			// TODO: Implement OCStatus_Curr_1ValueChanged
			Hx0.Text = "16#" + Convert.ToInt32(e.Value).ToString("X4");
		}

		void OCStatus1_1ValueChanged(object sender, ValueChangedEventArgs e)
		{
			// TODO: Implement OCStatus1_1ValueChanged
			Hx1.Text = "16#" + Convert.ToInt32(e.Value).ToString("X4");
		}

		void OCStatus2_1ValueChanged(object sender, ValueChangedEventArgs e)
		{
			// TODO: Implement OCStatus2_1ValueChanged
			Hx2.Text = "16#" + Convert.ToInt32(e.Value).ToString("X4");
		}

		void OCStatus3_1ValueChanged(object sender, ValueChangedEventArgs e)
		{
			// TODO: Implement OCStatus3_1ValueChanged
			Hx3.Text = "16#" + Convert.ToInt32(e.Value).ToString("X4");
		}

		void OCStatus4_1ValueChanged(object sender, ValueChangedEventArgs e)
		{
			// TODO: Implement OCStatus4_1ValueChanged
			Hx4.Text = "16#" + Convert.ToInt32(e.Value).ToString("X4");
		}

		void OCStatus5_1ValueChanged(object sender, ValueChangedEventArgs e)
		{
			// TODO: Implement OCStatus5_1ValueChanged
			Hx5.Text = "16#" + Convert.ToInt32(e.Value).ToString("X4");
		}

		void OCStatus6_1ValueChanged(object sender, ValueChangedEventArgs e)
		{
			// TODO: Implement OCStatus6_1ValueChanged
			Hx6.Text = "16#" + Convert.ToInt32(e.Value).ToString("X4");
		}

		void OCStatus7_1ValueChanged(object sender, ValueChangedEventArgs e)
		{
			// TODO: Implement OCStatus7_1ValueChanged
			Hx7.Text = "16#" + Convert.ToInt32(e.Value).ToString("X4");
		}

		void OCStatus8_1ValueChanged(object sender, ValueChangedEventArgs e)
		{
			// TODO: Implement OCStatus8_1ValueChanged
			Hx8.Text = "16#" + Convert.ToInt32(e.Value).ToString("X4");
		}

		void OCStatus9_1ValueChanged(object sender, ValueChangedEventArgs e)
		{
			// TODO: Implement OCStatus9_1ValueChanged
			Hx9.Text = "16#" + Convert.ToInt32(e.Value).ToString("X4");
		}
	}
}
