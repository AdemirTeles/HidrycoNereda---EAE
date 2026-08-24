using System;
using System.ComponentModel;
using NxtControl.GuiFramework;
using SE.App2CommonProcess.SupportClasses;
using SE.App2Base.SupportClasses;
using NxtControl.ComponentModel;
using System.Collections.Generic;
using Hidryco.HidrycoLib.SupportClasses;

namespace Hidryco.HidrycoLib.Symbols.Equipamento_On_Off
{
  public partial class Comporta : SE.App2Base.Symbols.SEAppLibHMISymbol
  {
    public Comporta()
    {
      InitializeComponent();

    }
    
    void StsAnimacaoValueChanged(object sender, ValueChangedEventArgs e)
		{
			comporta1.Animacao = Convert.ToInt16(e.Value);
		}


		void StsFalhaComunicacaoValueChanged(object sender, ValueChangedEventArgs e)
		{
			falha_comunicacao1.Visible = (bool)e.Value;
		}

		void STS_ALARMEValueChanged(object sender, ValueChangedEventArgs e)
		{
			alarme_icon1.Visible = (bool)e.Value;
		}
	
  }
}
