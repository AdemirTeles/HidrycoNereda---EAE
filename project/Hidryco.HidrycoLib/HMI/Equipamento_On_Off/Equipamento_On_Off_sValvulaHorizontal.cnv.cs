/*
 * Created by EcoStruxure Automation Expert.
 * User:
 * Date: 1/26/2026
 * Time: 1:13 PM
 */
using System;
using NxtControl.GuiFramework;
using SE.App2Base.SupportClasses;          // ← ADICIONAR
using Hidryco.HidrycoLib.SupportClasses;

namespace Hidryco.HidrycoLib.Symbols.Equipamento_On_Off
{
    public partial class sValvulaHorizontal : SE.App2Base.Symbols.SEAppLibHMISymbol  // ← MUDANÇA AQUI
    {
        public sValvulaHorizontal()
        {
            InitializeComponent();
        }

        // Isso é tudo que precisa para o InstanceName funcionar:
        public override void UpdateTagDisplayName()
        {
            base.UpdateTagDisplayName();
            InstanceName.CustomInstanceName = TagDisplayName;
        }

        void StsAnimacaoValueChanged(object sender, ValueChangedEventArgs e)
        {
            NxtControl.Drawing.Color color;
            NxtControl.Drawing.Color colorTwo;

            switch (Convert.ToInt16(e.Value))
            {
                case 0:
                    color = HidrycoColors.Desligado;
                    colorTwo = HidrycoColors.Desligado;
                    break;
                case 1:
                    color = HidrycoColors.Ligado;
                    colorTwo = HidrycoColors.Ligado;
                    break;
                case 2:
                    color = HidrycoColors.Falha;
                    colorTwo = HidrycoColors.Falha;
                    break;
                case 3:
                    color = HidrycoColors.Manutencao;
                    colorTwo = HidrycoColors.Manutencao;
                    break;
                case 4:
                    color = HidrycoColors.Desligado;
                    colorTwo = HidrycoColors.Ligado;
                    break;
                default:
                    color = HidrycoColors.Unknown;
                    colorTwo = HidrycoColors.Unknown;
                    break;
            }

            rectangle1.BrushColor = color;
            polygon1.BrushColor = color;
            polygon2.BrushColor = colorTwo;
        }

        void StsFalhaComunicacaoValueChanged(object sender, ValueChangedEventArgs e)
        {
            falha_comunicacao1.Visible = (bool)e.Value;
        }
    }
}