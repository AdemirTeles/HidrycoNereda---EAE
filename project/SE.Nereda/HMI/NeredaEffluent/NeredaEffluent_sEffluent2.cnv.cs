/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 7/8/2026
 * Time: 11:48 AM
 * 
 */

using System;
using NxtControl.GuiFramework;
using System.ComponentModel;

namespace SE.Nereda.Symbols.NeredaEffluent
{
	/// <summary>
	/// Description of sEffluent2.
	/// </summary>
	public partial class sEffluent2 : NxtControl.GuiFramework.HMISymbol
	{
		private string _EFFLUENT = "Name";
		float Percent;
		public sEffluent2()
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
		
		public string _iEFFLUENT
		{
			get{
				return _EFFLUENT;
			}
			set{
				_EFFLUENT = value;
				EFFLUENT.Text = value.ToString();
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
			WaterTop.Location = new NxtControl.Drawing.PointF(48, 320 + (Percent * (112 - 320) / 100));
		}
	}
}
