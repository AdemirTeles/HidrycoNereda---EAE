/*
 * Criado pelo EcoStruxure Automation Expert.
 * Usuário:  
 * Data: 25/02/2026
 * Tempo: 16:49
 * 
 */
using System;
using NxtControl.GuiFramework;
using NxtControl.Services;

#region Definitions;
#region #Necessidade_2_Equipamentos_ok_HMI;

namespace Hidryco.HidrycoLib.Symbols.Necessidade_2_Equipamentos_ok
{

  public class E_ATUALIZA_NECESSIDADEEventArgs : System.EventArgs
  {
    IHMIAccessorService accessorService;
    int channelId;
    int cookie; 
    int eventIndex;

    public E_ATUALIZA_NECESSIDADEEventArgs(int channelId, int cookie, int eventIndex)
    {
      this.accessorService = (IHMIAccessorService)ServiceProvider.GetService(typeof(IHMIAccessorService));
      this.channelId = channelId;
      this.cookie = cookie;
      this.eventIndex = eventIndex;
    }
    public bool Get_stsNecessidadeEquipamentos(ref System.UInt16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,0, ref var);
      if (ret) value = (System.UInt16) var;
      return ret;
    }

    public System.UInt16? stsNecessidadeEquipamentos
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,0, ref var);
      if (!ret) return null;
      return (System.UInt16) var;
    }  }


  }

}

namespace Hidryco.HidrycoLib.Symbols.Necessidade_2_Equipamentos_ok
{

  public class E_ATUALIZA_SETPOINTEventArgs : System.EventArgs
  {
    public E_ATUALIZA_SETPOINTEventArgs()
    {
    }
    private System.Single? stpLimiteFaixa1_field = null;
    public System.Single? stpLimiteFaixa1
    {
       get { return stpLimiteFaixa1_field; }
       set { stpLimiteFaixa1_field = value; }
    }
    private System.Single? stpLimiteFaixa2_field = null;
    public System.Single? stpLimiteFaixa2
    {
       get { return stpLimiteFaixa2_field; }
       set { stpLimiteFaixa2_field = value; }
    }
    private System.Single? stpLimiteFaixa3_field = null;
    public System.Single? stpLimiteFaixa3
    {
       get { return stpLimiteFaixa3_field; }
       set { stpLimiteFaixa3_field = value; }
    }
    private System.Single? stpLimiteFaixa4_field = null;
    public System.Single? stpLimiteFaixa4
    {
       get { return stpLimiteFaixa4_field; }
       set { stpLimiteFaixa4_field = value; }
    }
    private System.Boolean? cmdHabilita_field = null;
    public System.Boolean? cmdHabilita
    {
       get { return cmdHabilita_field; }
       set { cmdHabilita_field = value; }
    }

  }

}

namespace Hidryco.HidrycoLib.Symbols.Necessidade_2_Equipamentos_ok
{
  partial class sDefault
  {

    private event EventHandler<Hidryco.HidrycoLib.Symbols.Necessidade_2_Equipamentos_ok.E_ATUALIZA_NECESSIDADEEventArgs> E_ATUALIZA_NECESSIDADE_Fired;

    protected override void OnEndInit()
    {
      if (E_ATUALIZA_NECESSIDADE_Fired != null)
        AttachEventInput(0);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (E_ATUALIZA_NECESSIDADE_Fired != null)
          {
            try
            {
              E_ATUALIZA_NECESSIDADE_Fired(this, new Hidryco.HidrycoLib.Symbols.Necessidade_2_Equipamentos_ok.E_ATUALIZA_NECESSIDADEEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","E_ATUALIZA_NECESSIDADE_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_E_ATUALIZA_SETPOINT(System.Single stpLimiteFaixa1, System.Single stpLimiteFaixa2, System.Single stpLimiteFaixa3, System.Single stpLimiteFaixa4, System.Boolean cmdHabilita)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {stpLimiteFaixa1, stpLimiteFaixa2, stpLimiteFaixa3, stpLimiteFaixa4, cmdHabilita});
    }
    public bool FireEvent_E_ATUALIZA_SETPOINT(Hidryco.HidrycoLib.Symbols.Necessidade_2_Equipamentos_ok.E_ATUALIZA_SETPOINTEventArgs ea)
    {
      object[] _values_ = new object[5];
      if (ea.stpLimiteFaixa1.HasValue) _values_[0] = ea.stpLimiteFaixa1.Value;
      if (ea.stpLimiteFaixa2.HasValue) _values_[1] = ea.stpLimiteFaixa2.Value;
      if (ea.stpLimiteFaixa3.HasValue) _values_[2] = ea.stpLimiteFaixa3.Value;
      if (ea.stpLimiteFaixa4.HasValue) _values_[3] = ea.stpLimiteFaixa4.Value;
      if (ea.cmdHabilita.HasValue) _values_[4] = ea.cmdHabilita.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_E_ATUALIZA_SETPOINT(System.Single stpLimiteFaixa1, bool ignore_stpLimiteFaixa1, System.Single stpLimiteFaixa2, bool ignore_stpLimiteFaixa2, System.Single stpLimiteFaixa3, bool ignore_stpLimiteFaixa3, System.Single stpLimiteFaixa4, bool ignore_stpLimiteFaixa4, System.Boolean cmdHabilita, bool ignore_cmdHabilita)
    {
      object[] _values_ = new object[5];
      if (!ignore_stpLimiteFaixa1) _values_[0] = stpLimiteFaixa1;
      if (!ignore_stpLimiteFaixa2) _values_[1] = stpLimiteFaixa2;
      if (!ignore_stpLimiteFaixa3) _values_[2] = stpLimiteFaixa3;
      if (!ignore_stpLimiteFaixa4) _values_[3] = stpLimiteFaixa4;
      if (!ignore_cmdHabilita) _values_[4] = cmdHabilita;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }

  }
}

namespace Hidryco.HidrycoLib.Faceplates.Necessidade_2_Equipamentos_ok
{
  partial class Faceplate1
  {

    private event EventHandler<Hidryco.HidrycoLib.Symbols.Necessidade_2_Equipamentos_ok.E_ATUALIZA_NECESSIDADEEventArgs> E_ATUALIZA_NECESSIDADE_Fired;

    protected override void OnEndInit()
    {
      if (E_ATUALIZA_NECESSIDADE_Fired != null)
        AttachEventInput(0);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (E_ATUALIZA_NECESSIDADE_Fired != null)
          {
            try
            {
              E_ATUALIZA_NECESSIDADE_Fired(this, new Hidryco.HidrycoLib.Symbols.Necessidade_2_Equipamentos_ok.E_ATUALIZA_NECESSIDADEEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","E_ATUALIZA_NECESSIDADE_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_E_ATUALIZA_SETPOINT(System.Single stpLimiteFaixa1, System.Single stpLimiteFaixa2, System.Single stpLimiteFaixa3, System.Single stpLimiteFaixa4, System.Boolean cmdHabilita)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {stpLimiteFaixa1, stpLimiteFaixa2, stpLimiteFaixa3, stpLimiteFaixa4, cmdHabilita});
    }
    public bool FireEvent_E_ATUALIZA_SETPOINT(Hidryco.HidrycoLib.Symbols.Necessidade_2_Equipamentos_ok.E_ATUALIZA_SETPOINTEventArgs ea)
    {
      object[] _values_ = new object[5];
      if (ea.stpLimiteFaixa1.HasValue) _values_[0] = ea.stpLimiteFaixa1.Value;
      if (ea.stpLimiteFaixa2.HasValue) _values_[1] = ea.stpLimiteFaixa2.Value;
      if (ea.stpLimiteFaixa3.HasValue) _values_[2] = ea.stpLimiteFaixa3.Value;
      if (ea.stpLimiteFaixa4.HasValue) _values_[3] = ea.stpLimiteFaixa4.Value;
      if (ea.cmdHabilita.HasValue) _values_[4] = ea.cmdHabilita.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_E_ATUALIZA_SETPOINT(System.Single stpLimiteFaixa1, bool ignore_stpLimiteFaixa1, System.Single stpLimiteFaixa2, bool ignore_stpLimiteFaixa2, System.Single stpLimiteFaixa3, bool ignore_stpLimiteFaixa3, System.Single stpLimiteFaixa4, bool ignore_stpLimiteFaixa4, System.Boolean cmdHabilita, bool ignore_cmdHabilita)
    {
      object[] _values_ = new object[5];
      if (!ignore_stpLimiteFaixa1) _values_[0] = stpLimiteFaixa1;
      if (!ignore_stpLimiteFaixa2) _values_[1] = stpLimiteFaixa2;
      if (!ignore_stpLimiteFaixa3) _values_[2] = stpLimiteFaixa3;
      if (!ignore_stpLimiteFaixa4) _values_[3] = stpLimiteFaixa4;
      if (!ignore_cmdHabilita) _values_[4] = cmdHabilita;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }

  }
}
#endregion #Necessidade_2_Equipamentos_ok_HMI;

#endregion Definitions;
