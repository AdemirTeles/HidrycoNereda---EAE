using System;
using System.Drawing;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Graphics
{
    public partial class Energizado_por_Gerador : NxtControl.GuiFramework.GraphicSymbol
    {
        public Energizado_por_Gerador()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Estado de animação do gerador:
        ///   0 - Não conectado no gerador (invisível)
        ///   1 - Conectado, porém não marcado checkbox (só contorno)
        ///   2 - Conectado, checkbox marcado, porém desligado (raio cinza claro)
        ///   3 - Conectado, checkbox marcado e ligado (raio vermelho)
        /// </summary>
        private int _animacao = 0;
        public int Animacao
        {
            get { return _animacao; }
            set
            {
                _animacao = value;
                AtualizarVisual();
            }
        }

        private void AtualizarVisual()
        {
            switch (_animacao)
            {
                case 0: // Invisível
                    ellipse1.Visible = false;
                    polygon1.Visible = false;
                    break;

                case 1: // Só contorno
                    ellipse1.Visible = true;
                    polygon1.Visible = true;
                    ellipse1.BrushColor = Color.Transparent;
                    polygon1.BrushColor = Color.Transparent;
                    break;

                case 2: // Raio cinza claro
                    ellipse1.Visible = true;
                    polygon1.Visible = true;
                    ellipse1.BrushColor = Color.Transparent;
                    polygon1.BrushColor = Color.LightGray;
                    break;

                case 3: // Raio vermelho
                    ellipse1.Visible = true;
                    polygon1.Visible = true;
                    ellipse1.BrushColor = Color.Transparent;
                    polygon1.BrushColor = Color.Red;
                    break;
            }
            Invalidate();
        }
    }
}