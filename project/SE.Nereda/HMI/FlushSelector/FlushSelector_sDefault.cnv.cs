/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 6/22/2026
 * Time: 8:23 PM
 * 
 */

using System;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.FlushSelector
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
			this.REQ_FLUSH_Fired += REQ_FLUSH_Fired_EventHandler;
		}

		void REQ_FLUSH_Fired_EventHandler(object sender, REQ_FLUSHEventArgs e)
		{
			// TODO: Implement REQ_FLUSH_Fired_EventHandler
			GSI_RDY.BrushColor = new NxtControl.Drawing.Color(106, 106, 106);
			GSs_RDY.BrushColor = new NxtControl.Drawing.Color(106, 106, 106);
			SLB_RDY.BrushColor = new NxtControl.Drawing.Color(106, 106, 106);
			
			GSI_RDY.PenColor = new NxtControl.Drawing.Color(0,0,0);
			GSs_RDY.PenColor = new NxtControl.Drawing.Color(0,0,0);
			SLB_RDY.PenColor = new NxtControl.Drawing.Color(0,0,0);
			
			if(e.FbReady_SLB == true){
				SLB_RDY.BrushColor = new NxtControl.Drawing.Color(255,255,255);
			}
			if(e.FbReady_GSs == true){
				GSs_RDY.BrushColor = new NxtControl.Drawing.Color(255,255,255);
			}
			if(e.FbReady_GSInst == true){
				GSI_RDY.BrushColor = new NxtControl.Drawing.Color(255,255,255);
			}
			
			switch(e.FbSelected){
				case 1 :
					GSI_RDY.BrushColor = GSI_RDY.PenColor = new NxtControl.Drawing.Color(0,255,0);
					break;
				case 2 :
					GSs_RDY.BrushColor = GSs_RDY.PenColor = new NxtControl.Drawing.Color(0,255,0);
					break;
				case 3 :
					SLB_RDY.BrushColor = SLB_RDY.PenColor = new NxtControl.Drawing.Color(0,255,0);
					break;
			}
		}
	}
}
