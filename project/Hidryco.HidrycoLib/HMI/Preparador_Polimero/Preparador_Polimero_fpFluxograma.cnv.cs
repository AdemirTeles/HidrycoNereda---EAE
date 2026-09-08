/*
 * Criado pelo EcoStruxure Automation Expert.
 * Usuário:  
 * Data: 18/05/2026
 * Tempo: 14:33
 * 
 */

using System;
using NxtControl.GuiFramework;
using Hidryco.HidrycoLib.SupportClasses;

namespace Hidryco.HidrycoLib.Faceplates.Preparador_Polimero
{
	/// <summary>
	/// Description of fpFluxograma.
	/// </summary>
	public partial class fpFluxograma : NxtControl.GuiFramework.HMIFaceplate
	{
		public fpFluxograma()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
		}

		void StsResistenciaRA01ValueChanged(object sender, ValueChangedEventArgs e)
		{
			unidade_Portecao_Termica1.Visible = Convert.ToBoolean(e.Value);
		}
		
		void StsAlarmeAcionadoValueChanged(object sender, ValueChangedEventArgs e)
		{
			alarme_acionado1.Visible = Convert.ToBoolean(e.Value);
		}

		void StsEmergenciaValueChanged(object sender, ValueChangedEventArgs e)
		{
			emergencia_acionada1.Visible = Convert.ToBoolean(e.Value);
		}
        
		private NxtControl.Drawing.Color ResolverCor(object value)
		{
			switch (Convert.ToInt16(value)) {
				case 0:
					return HidrycoColors.Desligado;    
				case 1:
					return HidrycoColors.Ligado;       
				case 2:
					return HidrycoColors.Falha;        
				case 3:
					return HidrycoColors.Manutencao;  
				default:
					return HidrycoColors.Unknown;
			}
		}

		void StsFuncionamentoM1ValueChanged(object sender, ValueChangedEventArgs e)
		{
			color = ResolverCor(e.Value);
			m1_1.BrushColor = color;
			m1_2.BrushColor = color;
			m1_3.BrushColor = color;
		}

		void StsFuncionamentoM2ValueChanged(object sender, ValueChangedEventArgs e)
		{
			color = ResolverCor(e.Value);
			m2_1.BrushColor = color;
			m2_2.BrushColor = color;
			m2_3.BrushColor = color;
		}
		
		void StsFuncionamentoM3ValueChanged(object sender, ValueChangedEventArgs e)
		{
			color = ResolverCor(e.Value);
			m3_1.BrushColor = color;
			m3_2.BrushColor = color;
			m3_3.BrushColor = color;
		}
	
		void StsFuncionamentoM4ValueChanged(object sender, ValueChangedEventArgs e)
		{
			color = ResolverCor(e.Value);
			m4_1.BrushColor = color;
			m4_2.BrushColor = color;
			m4_3.BrushColor = color;
		}

		void StsFuncionamentoM5ValueChanged(object sender, ValueChangedEventArgs e)
		{
			color = ResolverCor(e.Value);
			m5_1.BrushColor = color;
			m5_2.BrushColor = color;
			m5_3.BrushColor = color;
		}

		void StsVS01ValueChanged(object sender, ValueChangedEventArgs e)
		{
			color = ResolverCor(e.Value);
			vs01_01.BrushColor = color;
			vs01_02.BrushColor = color;
			vs01_03.BrushColor = color;
		}

		void StsSiloPolimeroLSL01ValueChanged(object sender, ValueChangedEventArgs e)
		{
			lslOn.Visible = Convert.ToBoolean(e.Value);
			lslOff.Visible = !Convert.ToBoolean(e.Value);		
		}

		void StsChaveMagneticaLS1ValueChanged(object sender, ValueChangedEventArgs e)
		{
			int val = Convert.ToInt16(e.Value);

			// LL - Nível muito baixo (aciona a partir do val 1)
			cmLsLLOff.Visible = val < 1;
			cmLsLLOn.Visible = val >= 1;

			// L - Nível baixo (aciona a partir do val 2)
			cmLsLOff.Visible = val < 2;
			cmLsLOn.Visible = val >= 2;

			// H - Nível alto (aciona a partir do val 2)
			cmLsHOff.Visible = val < 2;
			cmLsHOn.Visible = val >= 2;

			// HH - Nível muito alto (aciona no val 3)
			cmLsHhOff.Visible = val < 3;
			cmLsHhOn.Visible = val >= 3;
		}
	}
}
