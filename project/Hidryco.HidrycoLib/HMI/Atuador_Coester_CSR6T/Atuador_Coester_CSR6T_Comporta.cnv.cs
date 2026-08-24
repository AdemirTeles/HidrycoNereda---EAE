using System;
using System.ComponentModel;
using NxtControl.GuiFramework;
using SE.App2CommonProcess.SupportClasses;
using SE.App2Base.SupportClasses;
using NxtControl.ComponentModel;
using System.Collections.Generic;

namespace Hidryco.HidrycoLib.Symbols.Atuador_Coester_CSR6T
{
  public partial class Comporta : SE.App2Base.Symbols.SEAppLibHMISymbol
  {
    public Comporta()
    {
      InitializeComponent();

    }
    
    private int _configShowPositioner;
    
    
    void StsAnimacaoValueChanged(object sender, ValueChangedEventArgs e)
		{
			comporta1.Animacao = Convert.ToInt16(e.Value);
		}
    
    void StsFalhaComunicacaoValueChanged(object sender, ValueChangedEventArgs e)
		{
			falha_comunicacao1.Visible = (bool)e.Value;
		}
    
		void Group1Click(object sender, EventArgs e)
		{
			NxtControl.GuiFramework.HMIFaceplate hmiFaceplate = null;
			if (_configShowPositioner == 1){
				hmiFaceplate = fpPosicionador;
			} else {
				hmiFaceplate = fpSemPosicionar;
			}
			
			if (hmiFaceplate.Initialized == true){
				hmiFaceplate.Activate();
			}else{
				OnInitializeFaceplate(hmiFaceplate);
				hmiFaceplate.Show(this);
			}
		}

		void ConfigShowPositionerValueChanged(object sender, ValueChangedEventArgs e)
		{
			
			_configShowPositioner = Convert.ToInt16(e.Value);
			
		}
	
  }
}
