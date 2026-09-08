/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 7/8/2026
 * Time: 12:10 PM
 * 
 */

using System;
using NxtControl.GuiFramework;
using System.ComponentModel;

namespace SE.Nereda.Symbols.InfluentFeed
{
	/// <summary>
	/// Description of sInfluentFeed.
	/// </summary>
	public partial class sInfluentFeed : NxtControl.GuiFramework.HMISymbol
	{
		private string _INFLUENT = "Name";
		float Percent;
		public sInfluentFeed()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			WaterLevel.FillPercent = 0;
			WaterBase.Visible = false;
			WaterTop.Visible = false;
		}
		
		[RefreshProperties(RefreshProperties.Repaint)]
		[Category("Tagnames")]
		[DisplayName("Name Code")]
		
		public string _iINFLUENT
		{
			get{
				return _INFLUENT;
			}
			set{
				_INFLUENT = value;
				INFLUENT.Text = value.ToString();
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
			WaterTop.Location = new NxtControl.Drawing.PointF(48, 320 + (Percent * (192 - 320) / 100));
		}
	}
}
