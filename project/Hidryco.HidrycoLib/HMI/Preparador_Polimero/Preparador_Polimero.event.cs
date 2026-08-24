/*
 * Criado pelo EcoStruxure Automation Expert.
 * Usuário:  
 * Data: 30/03/2026
 * Tempo: 17:04
 * 
 */
using System;
using NxtControl.GuiFramework;
using NxtControl.Services;

#region Definitions;
#region #Preparador_Polimero_HMI;

namespace Hidryco.HidrycoLib.Symbols.Preparador_Polimero
{

  public class REQEventArgs : System.EventArgs
  {
    IHMIAccessorService accessorService;
    int channelId;
    int cookie; 
    int eventIndex;

    public REQEventArgs(int channelId, int cookie, int eventIndex)
    {
      this.accessorService = (IHMIAccessorService)ServiceProvider.GetService(typeof(IHMIAccessorService));
      this.channelId = channelId;
      this.cookie = cookie;
      this.eventIndex = eventIndex;
    }
    public bool Get_stsAlarmeAcionado(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,0, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? stsAlarmeAcionado
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,0, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }

    public bool Get_stsEmergencia(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,1, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? stsEmergencia
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,1, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }

    public bool Get_stsFuncionamentoM1(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,2, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? stsFuncionamentoM1
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,2, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }

    public bool Get_stsFuncionamentoM2(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,3, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? stsFuncionamentoM2
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,3, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }

    public bool Get_stsFuncionamentoM3(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,4, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? stsFuncionamentoM3
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,4, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }

    public bool Get_stsFuncionamentoM4(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,5, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? stsFuncionamentoM4
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,5, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }

    public bool Get_stsFuncionamentoM5(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,6, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? stsFuncionamentoM5
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,6, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }

    public bool Get_stsVS01(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,7, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? stsVS01
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,7, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }

    public bool Get_stsSiloPolimeroLSL01(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,8, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? stsSiloPolimeroLSL01
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,8, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }

    public bool Get_stsChaveMagneticaLS1(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,9, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? stsChaveMagneticaLS1
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,9, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }

    public bool Get_stsResistenciaRA01(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,10, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? stsResistenciaRA01
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,10, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }

    public bool Get_stsFIT01(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,11, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? stsFIT01
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,11, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }

    public bool Get_stsFIT02(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,12, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? stsFIT02
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,12, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }

    public bool Get_stsAlarmeFaltaAgua(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,13, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? stsAlarmeFaltaAgua
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,13, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }

    public bool Get_stsAlarmeVazaoPolimero(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,14, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? stsAlarmeVazaoPolimero
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,14, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }


  }

  public class E_ATUALIZA_FEEDBACKEventArgs : System.EventArgs
  {
    IHMIAccessorService accessorService;
    int channelId;
    int cookie; 
    int eventIndex;

    public E_ATUALIZA_FEEDBACKEventArgs(int channelId, int cookie, int eventIndex)
    {
      this.accessorService = (IHMIAccessorService)ServiceProvider.GetService(typeof(IHMIAccessorService));
      this.channelId = channelId;
      this.cookie = cookie;
      this.eventIndex = eventIndex;
    }

  }

}

namespace Hidryco.HidrycoLib.Symbols.Preparador_Polimero
{

  public class CNFEventArgs : System.EventArgs
  {
    public CNFEventArgs()
    {
    }
    private System.Boolean? cmdLigaDesligaCicloRemoto_field = null;
    public System.Boolean? cmdLigaDesligaCicloRemoto
    {
       get { return cmdLigaDesligaCicloRemoto_field; }
       set { cmdLigaDesligaCicloRemoto_field = value; }
    }
    private System.Boolean? cmdResetFalha_field = null;
    public System.Boolean? cmdResetFalha
    {
       get { return cmdResetFalha_field; }
       set { cmdResetFalha_field = value; }
    }

  }

}

namespace Hidryco.HidrycoLib.Symbols.Preparador_Polimero
{
  partial class sResumo
  {

    private event EventHandler<Hidryco.HidrycoLib.Symbols.Preparador_Polimero.REQEventArgs> REQ_Fired;

    private event EventHandler<Hidryco.HidrycoLib.Symbols.Preparador_Polimero.E_ATUALIZA_FEEDBACKEventArgs> E_ATUALIZA_FEEDBACK_Fired;

    protected override void OnEndInit()
    {
      if (REQ_Fired != null)
        AttachEventInput(0);
      if (E_ATUALIZA_FEEDBACK_Fired != null)
        AttachEventInput(1);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (REQ_Fired != null)
          {
            try
            {
              REQ_Fired(this, new Hidryco.HidrycoLib.Symbols.Preparador_Polimero.REQEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REQ_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 1:
          if (E_ATUALIZA_FEEDBACK_Fired != null)
          {
            try
            {
              E_ATUALIZA_FEEDBACK_Fired(this, new Hidryco.HidrycoLib.Symbols.Preparador_Polimero.E_ATUALIZA_FEEDBACKEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","E_ATUALIZA_FEEDBACK_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_CNF(System.Boolean cmdLigaDesligaCicloRemoto, System.Boolean cmdResetFalha)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {cmdLigaDesligaCicloRemoto, cmdResetFalha});
    }
    public bool FireEvent_CNF(Hidryco.HidrycoLib.Symbols.Preparador_Polimero.CNFEventArgs ea)
    {
      object[] _values_ = new object[2];
      if (ea.cmdLigaDesligaCicloRemoto.HasValue) _values_[0] = ea.cmdLigaDesligaCicloRemoto.Value;
      if (ea.cmdResetFalha.HasValue) _values_[1] = ea.cmdResetFalha.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_CNF(System.Boolean cmdLigaDesligaCicloRemoto, bool ignore_cmdLigaDesligaCicloRemoto, System.Boolean cmdResetFalha, bool ignore_cmdResetFalha)
    {
      object[] _values_ = new object[2];
      if (!ignore_cmdLigaDesligaCicloRemoto) _values_[0] = cmdLigaDesligaCicloRemoto;
      if (!ignore_cmdResetFalha) _values_[1] = cmdResetFalha;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }

  }
}

namespace Hidryco.HidrycoLib.Symbols.Preparador_Polimero
{}

namespace Hidryco.HidrycoLib.Faceplates.Preparador_Polimero
{
  partial class fpFluxograma
  {

    private event EventHandler<Hidryco.HidrycoLib.Symbols.Preparador_Polimero.REQEventArgs> REQ_Fired;

    private event EventHandler<Hidryco.HidrycoLib.Symbols.Preparador_Polimero.E_ATUALIZA_FEEDBACKEventArgs> E_ATUALIZA_FEEDBACK_Fired;

    protected override void OnEndInit()
    {
      if (REQ_Fired != null)
        AttachEventInput(0);
      if (E_ATUALIZA_FEEDBACK_Fired != null)
        AttachEventInput(1);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (REQ_Fired != null)
          {
            try
            {
              REQ_Fired(this, new Hidryco.HidrycoLib.Symbols.Preparador_Polimero.REQEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REQ_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 1:
          if (E_ATUALIZA_FEEDBACK_Fired != null)
          {
            try
            {
              E_ATUALIZA_FEEDBACK_Fired(this, new Hidryco.HidrycoLib.Symbols.Preparador_Polimero.E_ATUALIZA_FEEDBACKEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","E_ATUALIZA_FEEDBACK_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_CNF(System.Boolean cmdLigaDesligaCicloRemoto, System.Boolean cmdResetFalha)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {cmdLigaDesligaCicloRemoto, cmdResetFalha});
    }
    public bool FireEvent_CNF(Hidryco.HidrycoLib.Symbols.Preparador_Polimero.CNFEventArgs ea)
    {
      object[] _values_ = new object[2];
      if (ea.cmdLigaDesligaCicloRemoto.HasValue) _values_[0] = ea.cmdLigaDesligaCicloRemoto.Value;
      if (ea.cmdResetFalha.HasValue) _values_[1] = ea.cmdResetFalha.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_CNF(System.Boolean cmdLigaDesligaCicloRemoto, bool ignore_cmdLigaDesligaCicloRemoto, System.Boolean cmdResetFalha, bool ignore_cmdResetFalha)
    {
      object[] _values_ = new object[2];
      if (!ignore_cmdLigaDesligaCicloRemoto) _values_[0] = cmdLigaDesligaCicloRemoto;
      if (!ignore_cmdResetFalha) _values_[1] = cmdResetFalha;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }

  }
}
#endregion #Preparador_Polimero_HMI;

#endregion Definitions;
