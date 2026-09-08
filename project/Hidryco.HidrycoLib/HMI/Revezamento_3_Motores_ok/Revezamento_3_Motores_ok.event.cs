/*
 * Criado pelo EcoStruxure Automation Expert.
 * Usuário:  
 * Data: 25/02/2026
 * Tempo: 09:32
 * 
 */
using System;
using NxtControl.GuiFramework;
using NxtControl.Services;

#region Definitions;
#region #Revezamento_3_Motores_ok_HMI;

namespace Hidryco.HidrycoLib.Symbols.Revezamento_3_Motores_ok
{

  public class E_ATUALIZA_TEMPO_RESTANTEEventArgs : System.EventArgs
  {
    IHMIAccessorService accessorService;
    int channelId;
    int cookie; 
    int eventIndex;

    public E_ATUALIZA_TEMPO_RESTANTEEventArgs(int channelId, int cookie, int eventIndex)
    {
      this.accessorService = (IHMIAccessorService)ServiceProvider.GetService(typeof(IHMIAccessorService));
      this.channelId = channelId;
      this.cookie = cookie;
      this.eventIndex = eventIndex;
    }
    public bool Get_stsTempoRestanteHora(ref System.UInt16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,0, ref var);
      if (ret) value = (System.UInt16) var;
      return ret;
    }

    public System.UInt16? stsTempoRestanteHora
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,0, ref var);
      if (!ret) return null;
      return (System.UInt16) var;
    }  }

    public bool Get_stsTempoRestanteMinuto(ref System.UInt16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,1, ref var);
      if (ret) value = (System.UInt16) var;
      return ret;
    }

    public System.UInt16? stsTempoRestanteMinuto
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,1, ref var);
      if (!ret) return null;
      return (System.UInt16) var;
    }  }

    public bool Get_stsTempoRestanteSegundo(ref System.UInt16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,2, ref var);
      if (ret) value = (System.UInt16) var;
      return ret;
    }

    public System.UInt16? stsTempoRestanteSegundo
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,2, ref var);
      if (!ret) return null;
      return (System.UInt16) var;
    }  }


  }

}

namespace Hidryco.HidrycoLib.Symbols.Revezamento_3_Motores_ok
{

  public class E_ATUALIZA_SETPOINTEventArgs : System.EventArgs
  {
    public E_ATUALIZA_SETPOINTEventArgs()
    {
    }
    private System.Boolean? cmdHabilitaRevezamento_field = null;
    public System.Boolean? cmdHabilitaRevezamento
    {
       get { return cmdHabilitaRevezamento_field; }
       set { cmdHabilitaRevezamento_field = value; }
    }
    private System.UInt16? stpTempoEquipamento1_field = null;
    public System.UInt16? stpTempoEquipamento1
    {
       get { return stpTempoEquipamento1_field; }
       set { stpTempoEquipamento1_field = value; }
    }
    private System.UInt16? stpTempoEquipamento2_field = null;
    public System.UInt16? stpTempoEquipamento2
    {
       get { return stpTempoEquipamento2_field; }
       set { stpTempoEquipamento2_field = value; }
    }
    private System.UInt16? stpTempoEquipamento3_field = null;
    public System.UInt16? stpTempoEquipamento3
    {
       get { return stpTempoEquipamento3_field; }
       set { stpTempoEquipamento3_field = value; }
    }

  }

}

namespace Hidryco.HidrycoLib.Symbols.Revezamento_3_Motores_ok
{
  partial class sDefault
  {

    private event EventHandler<Hidryco.HidrycoLib.Symbols.Revezamento_3_Motores_ok.E_ATUALIZA_TEMPO_RESTANTEEventArgs> E_ATUALIZA_TEMPO_RESTANTE_Fired;

    protected override void OnEndInit()
    {
      if (E_ATUALIZA_TEMPO_RESTANTE_Fired != null)
        AttachEventInput(0);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (E_ATUALIZA_TEMPO_RESTANTE_Fired != null)
          {
            try
            {
              E_ATUALIZA_TEMPO_RESTANTE_Fired(this, new Hidryco.HidrycoLib.Symbols.Revezamento_3_Motores_ok.E_ATUALIZA_TEMPO_RESTANTEEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","E_ATUALIZA_TEMPO_RESTANTE_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_E_ATUALIZA_SETPOINT(System.Boolean cmdHabilitaRevezamento, System.UInt16 stpTempoEquipamento1, System.UInt16 stpTempoEquipamento2, System.UInt16 stpTempoEquipamento3)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {cmdHabilitaRevezamento, stpTempoEquipamento1, stpTempoEquipamento2, stpTempoEquipamento3});
    }
    public bool FireEvent_E_ATUALIZA_SETPOINT(Hidryco.HidrycoLib.Symbols.Revezamento_3_Motores_ok.E_ATUALIZA_SETPOINTEventArgs ea)
    {
      object[] _values_ = new object[4];
      if (ea.cmdHabilitaRevezamento.HasValue) _values_[0] = ea.cmdHabilitaRevezamento.Value;
      if (ea.stpTempoEquipamento1.HasValue) _values_[1] = ea.stpTempoEquipamento1.Value;
      if (ea.stpTempoEquipamento2.HasValue) _values_[2] = ea.stpTempoEquipamento2.Value;
      if (ea.stpTempoEquipamento3.HasValue) _values_[3] = ea.stpTempoEquipamento3.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_E_ATUALIZA_SETPOINT(System.Boolean cmdHabilitaRevezamento, bool ignore_cmdHabilitaRevezamento, System.UInt16 stpTempoEquipamento1, bool ignore_stpTempoEquipamento1, System.UInt16 stpTempoEquipamento2, bool ignore_stpTempoEquipamento2, System.UInt16 stpTempoEquipamento3, bool ignore_stpTempoEquipamento3)
    {
      object[] _values_ = new object[4];
      if (!ignore_cmdHabilitaRevezamento) _values_[0] = cmdHabilitaRevezamento;
      if (!ignore_stpTempoEquipamento1) _values_[1] = stpTempoEquipamento1;
      if (!ignore_stpTempoEquipamento2) _values_[2] = stpTempoEquipamento2;
      if (!ignore_stpTempoEquipamento3) _values_[3] = stpTempoEquipamento3;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }

  }
}

namespace Hidryco.HidrycoLib.Faceplates.Revezamento_3_Motores_ok
{
  partial class Faceplate1
  {

    private event EventHandler<Hidryco.HidrycoLib.Symbols.Revezamento_3_Motores_ok.E_ATUALIZA_TEMPO_RESTANTEEventArgs> E_ATUALIZA_TEMPO_RESTANTE_Fired;

    protected override void OnEndInit()
    {
      if (E_ATUALIZA_TEMPO_RESTANTE_Fired != null)
        AttachEventInput(0);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (E_ATUALIZA_TEMPO_RESTANTE_Fired != null)
          {
            try
            {
              E_ATUALIZA_TEMPO_RESTANTE_Fired(this, new Hidryco.HidrycoLib.Symbols.Revezamento_3_Motores_ok.E_ATUALIZA_TEMPO_RESTANTEEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","E_ATUALIZA_TEMPO_RESTANTE_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_E_ATUALIZA_SETPOINT(System.Boolean cmdHabilitaRevezamento, System.UInt16 stpTempoEquipamento1, System.UInt16 stpTempoEquipamento2, System.UInt16 stpTempoEquipamento3)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {cmdHabilitaRevezamento, stpTempoEquipamento1, stpTempoEquipamento2, stpTempoEquipamento3});
    }
    public bool FireEvent_E_ATUALIZA_SETPOINT(Hidryco.HidrycoLib.Symbols.Revezamento_3_Motores_ok.E_ATUALIZA_SETPOINTEventArgs ea)
    {
      object[] _values_ = new object[4];
      if (ea.cmdHabilitaRevezamento.HasValue) _values_[0] = ea.cmdHabilitaRevezamento.Value;
      if (ea.stpTempoEquipamento1.HasValue) _values_[1] = ea.stpTempoEquipamento1.Value;
      if (ea.stpTempoEquipamento2.HasValue) _values_[2] = ea.stpTempoEquipamento2.Value;
      if (ea.stpTempoEquipamento3.HasValue) _values_[3] = ea.stpTempoEquipamento3.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_E_ATUALIZA_SETPOINT(System.Boolean cmdHabilitaRevezamento, bool ignore_cmdHabilitaRevezamento, System.UInt16 stpTempoEquipamento1, bool ignore_stpTempoEquipamento1, System.UInt16 stpTempoEquipamento2, bool ignore_stpTempoEquipamento2, System.UInt16 stpTempoEquipamento3, bool ignore_stpTempoEquipamento3)
    {
      object[] _values_ = new object[4];
      if (!ignore_cmdHabilitaRevezamento) _values_[0] = cmdHabilitaRevezamento;
      if (!ignore_stpTempoEquipamento1) _values_[1] = stpTempoEquipamento1;
      if (!ignore_stpTempoEquipamento2) _values_[2] = stpTempoEquipamento2;
      if (!ignore_stpTempoEquipamento3) _values_[3] = stpTempoEquipamento3;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }

  }
}
#endregion #Revezamento_3_Motores_ok_HMI;

#endregion Definitions;
