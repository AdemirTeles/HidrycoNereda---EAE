/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 2/9/2026
 * Time: 9:47 AM
 * 
 */

using System;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Symbols.Boia
{
	/// <summary>
	/// Description of sDefault.
	/// </summary>
	public partial class sDefault : NxtControl.GuiFramework.HMISymbol
	{
		private readonly NxtControl.Drawing.Color _colorGreen   = NxtControl.Drawing.SystemColors.Green;
		private readonly NxtControl.Drawing.Color _colorRed     = NxtControl.Drawing.Color.FromName("SE.App2Base.aaLibAlarmActive");
		private readonly NxtControl.Drawing.Color _colorYellow  = NxtControl.Drawing.Color.FromName("SE.App2Base.Abnormal");
		private bool _stsBoia;
		private uint _stsAnimacao;
		public sDefault()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
		}

		void StsBoiaValueChanged(object sender, ValueChangedEventArgs e)
		{
			// TODO: Implement StsBoiaValueChanged
			
			_stsBoia = Convert.ToBoolean(e.Value);
			
			
			group1.Visible = _stsBoia;
			group2.Visible = !_stsBoia;
			
		}

		void StsAnimacaoValueChanged(object sender, ValueChangedEventArgs e)
		{
			_stsAnimacao = Convert.ToUInt16(e.Value);
			
			NxtControl.Drawing.Color color;

			switch (_stsAnimacao)
			{
				case 0: // Vermelho
					color = _colorRed;
					break;

				case 1: // Verde
					color = _colorGreen;
					break;

				case 2: // Amarelo
					color = _colorYellow;
					break;
					
				default:
					color = _colorRed; // cor segura padrão
					break;
			}
			
			ellipse1.BrushColor = color;
			ellipse2.BrushColor = color;
			// TODO: Implement StsAnimacaoValueChanged
		}
	}
}
