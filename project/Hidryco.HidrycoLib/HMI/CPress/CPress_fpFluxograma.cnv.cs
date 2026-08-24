/*
 * Criado pelo EcoStruxure Automation Expert.
 * Usuário:  
 * Data: 15/05/2026
 * Tempo: 17:20
 * 
 */
using System;
using NxtControl.GuiFramework;
using Hidryco.HidrycoLib.SupportClasses;

namespace Hidryco.HidrycoLib.Faceplates.CPress
{
    public partial class fpFluxograma : NxtControl.GuiFramework.HMIFaceplate
    {
        public fpFluxograma()
        {
            InitializeComponent();
        }

        // ── Alarme e Emergência ──────────────────────────
        void StsAlarmeAcionadoValueChanged(object sender, ValueChangedEventArgs e)
        {
        	alarme_acionado1.Visible = Convert.ToBoolean(e.Value);
        }

        void StsEmergenciaValueChanged(object sender, ValueChangedEventArgs e)
        {
        	emergencia_acionada1.Visible = Convert.ToBoolean(e.Value);
        }

        // ── Método auxiliar para resolver cor ────────────
        private NxtControl.Drawing.Color ResolverCor(object value)
        {
            switch (Convert.ToInt16(value))
            {
                case 0:  return HidrycoColors.Desligado;    
                case 1:  return HidrycoColors.Ligado;       
                case 2:  return HidrycoColors.Falha;        
                case 3:  return HidrycoColors.Manutencao;  
                default: return HidrycoColors.Unknown;
            }
        }

        // ── Anexo 01 (m01_01, m01_02, m01_03) ───────────
        void StsAnimacaoM01ValueChanged(object sender, ValueChangedEventArgs e)
        {
            color = ResolverCor(e.Value);
            m01_01.BrushColor = color;
            m01_02.BrushColor = color;
            m01_03.BrushColor = color;
        }

        // ── Anexo 02 (m02_01, m02_02, m02_03) ───────────
        void StsAnimacaoM02ValueChanged(object sender, ValueChangedEventArgs e)
        {
            NxtControl.Drawing.Color color_m02;

            switch (Convert.ToInt16(e.Value))
            {
                case 0:
                    color_m02 = HidrycoColors.Desligado;
                    break;
                case 1:
                    color_m02 = HidrycoColors.Ligado;
                    break;
                case 2:
                    color_m02 = HidrycoColors.Ligado;
                    break;
                case 3:
                    color_m02 = HidrycoColors.Falha;
                    break;
                default:
                    color_m02 = HidrycoColors.Unknown;
                    break;
            }

            m02_01.BrushColor = color_m02;
            m02_02.BrushColor = color_m02;
            m02_03.BrushColor = color_m02;
        }

        // ── Anexo 03 (m03_01, m03_02, m03_03) ───────────
        void StsAnimacaoM03ValueChanged(object sender, ValueChangedEventArgs e)
        {
            color = ResolverCor(e.Value);
            m03_01.BrushColor = color;
            m03_02.BrushColor = color;
            m03_03.BrushColor = color;
        }

        // ── Anexo 04 (m04_01, m04_02, m04_03) ───────────
        void StsAnimacaoM04ValueChanged(object sender, ValueChangedEventArgs e)
        {
            color = ResolverCor(e.Value);
            m04_01.BrushColor = color;
            m04_02.BrushColor = color;
            m04_03.BrushColor = color;
        }

        // ── Anexo 05 (m05_01, m05_02) ───────────────────
        void StsAnimacaoM05ValueChanged(object sender, ValueChangedEventArgs e)
        {
            color = ResolverCor(e.Value);
            m05_01.BrushColor = color;
            m05_02.BrushColor = color;
		}

		void StsVS1ValueChanged(object sender, ValueChangedEventArgs e)
		{
			color = ResolverCor(e.Value);
			vs01_01.BrushColor = color;
			vs01_02.BrushColor = color;
			vs01_03.BrushColor = color;
		}
    }
}