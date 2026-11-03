/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 9/18/2026
 * Time: 3:25 AM
 * 
 */
 
using System;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.EmergencySludgeBuffer
{
    public partial class Symbol1 : NxtControl.GuiFramework.HMISymbol
    {
        public Symbol1()
        {
            InitializeComponent();

            // Subcreve o evento que recebe a mudança de passo do EAE
            this.GRAPH_Fired += GRAPH_Fired_EventHandler;
        }

        void GRAPH_Fired_EventHandler(object sender, GRAPHEventArgs e)
        {
            // Reseta a cor dos 5 passos para o estado inativo (Cinza)
            NxtControl.Drawing.Color inactiveColor = new NxtControl.Drawing.Color(78, 78, 78);
            Step0.BrushColor = Step1.BrushColor = Step2.BrushColor = Step3.BrushColor = Step4.BrushColor = Step5.BrushColor = inactiveColor;

            // Destaca em verde apenas o passo ativo (0 a 4)
            NxtControl.Drawing.Color activeColor = new NxtControl.Drawing.Color(0, 255, 0);

            switch (e.Grafcet)
            {
                case 0: // IDLE
                    Step0.BrushColor = activeColor;
                    break;
                case 1: // FEED
                    Step1.BrushColor = activeColor;
                    break;
                case 2: // WAIT
                    Step2.BrushColor = activeColor;
                    break;
                case 3: // SLUDGE DISCHARGE
                    Step3.BrushColor = activeColor;
                    break;
                case 4: // SUPERNATANT DISCHARGE
                    Step4.BrushColor = activeColor;
                    break;
                case 5: // SUPERNATANT DISCHARGE
                    Step5.BrushColor = activeColor;
                    break;
            }
        }
    }
}
