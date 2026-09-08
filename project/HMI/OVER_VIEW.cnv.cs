/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 6/10/2026
 * Time: 3:50 PM
 * 
 */

using System;
using NxtControl.GuiFramework;


namespace HMI.Main.Canvases
{
	/// <summary>
	/// Description of OVER_VIEW.
	/// </summary>
	public partial class OVER_VIEW : NxtControl.GuiFramework.HMICanvas
	{
		public OVER_VIEW()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
		}

		void INFLUENT_FEEDClick(object sender, EventArgs e)
		{
			// TODO: Implement INFLUENT_FEEDClick
			OpenCanvas("INFLUENT_FEED");
		}

		void EFFLUENTClick(object sender, EventArgs e)
		{
			// TODO: Implement EFFLUENTClick
			OpenCanvas("EFFLUENT");
		}

		void NVPP_REACTOR01Click(object sender, EventArgs e)
		{
			// TODO: Implement NVPP_REACTOR01Click
			OpenCanvas("REACTOR1");
		}

		void NVPP_REACTOR02Click(object sender, EventArgs e)
		{
			// TODO: Implement NVPP_REACTOR02Click
			OpenCanvas("REACTOR2");
		}

		void NVPP_REACTOR03Click(object sender, EventArgs e)
		{
			// TODO: Implement NVPP_REACTOR03Click
			OpenCanvas("REACTOR3");
		}

		void SLUDGE_BUFFERClick(object sender, EventArgs e)
		{
			// TODO: Implement SLUDGE_BUFFERClick
			OpenCanvas("SLUDGE_BUFFER");
		}

		void EFFLUENT_1Click(object sender, EventArgs e)
		{
			// TODO: Implement EFFLUENT_1Click
			OpenCanvas("CALAMITY");
		}
	}
}
