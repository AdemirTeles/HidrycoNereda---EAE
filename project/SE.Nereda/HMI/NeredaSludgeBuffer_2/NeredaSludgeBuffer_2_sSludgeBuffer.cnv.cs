/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 7/11/2026
 * Time: 9:35 PM
 * 
 */

using System;
using NxtControl.GuiFramework;
using System.ComponentModel;

namespace SE.Nereda.Symbols.NeredaSludgeBuffer_2
{
	/// <summary>
	/// Description of sSludgeBuffer.
	/// </summary>
	public partial class sSludgeBuffer : NxtControl.GuiFramework.HMISymbol
	{
		private string _SLUDGE_BUFFER = "Name";
		float Percent;
		public sSludgeBuffer()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			InitializeComponent();
			WaterLevel.FillPercent = 0;
			WaterBase.Visible = false;
			WaterTop.Visible = false;
		}
		
		[RefreshProperties(RefreshProperties.Repaint)]
		[Category("Tagnames")]
		[DisplayName("Name Code")]
		
		public string _iSLUDGE_BUFFER
		{
			get{
				return _SLUDGE_BUFFER;
			}
			set{
				_SLUDGE_BUFFER = value;
				SLUDGE_BUFFER.Text = value.ToString();
			}
		}

		void SPvBarVer1ShareLevelPv(float ShPvMax, float ShPvMin, float ShPv)
		{
			// TODO: Implement SPvBarVer1ShareLevelPv
			Percent = (float) (ShPv / ShPvMax) *100;
			if(Percent > 0){
				WaterBase.Visible = WaterTop.Visible = true;
			}
			else if(Percent == 0){
				WaterBase.Visible = false;
				WaterTop.Visible = false;
			}
			
			WaterLevel.FillPercent = Percent;
			WaterTop.Location = new NxtControl.Drawing.PointF(32, 232 + (Percent * (96 - 232) / 100));
		}
	}
}
