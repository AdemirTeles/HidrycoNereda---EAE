/*
 * Criado pelo EcoStruxure Automation Expert.
 * Usuário:  
 * Data: 24/02/2026
 * Tempo: 14:11
 * 
 */
using System;
using NxtControl.GuiFramework;
using NxtControl.Services;

#region Definitions;
#region #ElevatoriaEsgotoBruto_HMI;

namespace Hidryco.HidrycoLib.Symbols.ElevatoriaEsgotoBruto
{

  public class E_RESET_FALHAS_PROCESSOEventArgs : System.EventArgs
  {
    public E_RESET_FALHAS_PROCESSOEventArgs()
    {
    }
    private System.Boolean? cmdResetFalhas_field = null;
    public System.Boolean? cmdResetFalhas
    {
       get { return cmdResetFalhas_field; }
       set { cmdResetFalhas_field = value; }
    }

  }

}

namespace Hidryco.HidrycoLib.Symbols.ElevatoriaEsgotoBruto
{
  partial class sDefault
  {
    public bool FireEvent_E_RESET_FALHAS_PROCESSO(System.Boolean cmdResetFalhas)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {cmdResetFalhas});
    }
    public bool FireEvent_E_RESET_FALHAS_PROCESSO(Hidryco.HidrycoLib.Symbols.ElevatoriaEsgotoBruto.E_RESET_FALHAS_PROCESSOEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.cmdResetFalhas.HasValue) _values_[0] = ea.cmdResetFalhas.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_E_RESET_FALHAS_PROCESSO(System.Boolean cmdResetFalhas, bool ignore_cmdResetFalhas)
    {
      object[] _values_ = new object[1];
      if (!ignore_cmdResetFalhas) _values_[0] = cmdResetFalhas;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }

  }
}
#endregion #ElevatoriaEsgotoBruto_HMI;

#endregion Definitions;
