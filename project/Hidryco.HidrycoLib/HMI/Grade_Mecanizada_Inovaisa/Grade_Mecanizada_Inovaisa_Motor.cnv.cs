/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 2/5/2026
 * Time: 1:44 PM
 * 
 */

using System;
using NxtControl.GuiFramework;
using Hidryco.HidrycoLib.SupportClasses;

namespace Hidryco.HidrycoLib.Symbols.Grade_Mecanizada_Inovaisa
{
	/// <summary>
	/// Description of sDefault.
	/// </summary>
	public partial class Motor : NxtControl.GuiFramework.HMISymbol
	{
		public Motor()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
		}
		
		
		void STS_SENSOR_SOBRETORQUEValueChanged(object sender, ValueChangedEventArgs e)
		{
			sobretorque1.Visible = (Convert.ToBoolean(e.Value));
		}

		void STS_FUNCIONAMENTOValueChanged(object sender, ValueChangedEventArgs e)
		{
			
			NxtControl.Drawing.Color _color;
			textAvante.Visible = (Convert.ToInt16(e.Value) == 1);
			iconAvante.Visible = (Convert.ToInt16(e.Value) == 1);
			
			textReverso.Visible = (Convert.ToInt16(e.Value) == 2);
			iconReverso.Visible = (Convert.ToInt16(e.Value) == 2);
			
			switch(Convert.ToInt16(e.Value)){
				case 0: 
					_color = HidrycoColors.Desligado;
					break;

				case 1: 
					_color = HidrycoColors.Ligado;
					break;

				case 2:
					_color = HidrycoColors.Ligado;
					break;

				case 3: 
					_color = HidrycoColors.Falha;
					break;
					
				default:
					_color = HidrycoColors.Unknown;
					break;
			}
			
			Base1R.BrushColor = _color;
			Base2R.BrushColor = _color;
			Base3R.BrushColor = _color;
				
			
		}
	}
}
