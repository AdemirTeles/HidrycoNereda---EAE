using System;
using System.ComponentModel;
using NxtControl.GuiFramework;
using SE.App2CommonProcess.SupportClasses;
using SE.App2Base.SupportClasses;
using NxtControl.ComponentModel;
using System.Collections.Generic;
using Hidryco.HidrycoLib.SupportClasses;

namespace Hidryco.HidrycoLib.Symbols.Valvula_Saida_Digital
{
  public partial class Comporta : SE.App2Base.Symbols.SEAppLibHMISymbol
  {
    public Comporta()
    {
      InitializeComponent();

    }
    
    void StsAnimacaoValueChanged(object sender, ValueChangedEventArgs e)
		{
			NxtControl.Drawing.Color color;
			
			switch (Convert.ToInt16(e.Value))
			{
				case 0: 
					color = HidrycoColors.Desligado;
					break;

				case 1:
					color = HidrycoColors.Ligado;
					break;

				case 2: 
					color = HidrycoColors.Falha;
					break;

				case 3:
					color = HidrycoColors.Manutencao;
					break;

				default: 
					color = HidrycoColors.Unknown;
					break;
			}

			// Aplica a cor em todas as formas
			rectangle1.BrushColor = color;
			rectangle2.BrushColor = color;
			rectangle3.BrushColor = color;
			rectangle4.BrushColor = color;
			rectangle5.BrushColor = color;
			rectangle6.BrushColor = color;
		}


	
  }
}
