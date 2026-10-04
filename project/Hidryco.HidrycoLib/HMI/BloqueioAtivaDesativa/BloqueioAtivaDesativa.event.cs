/*
 * Criado pelo EcoStruxure Automation Expert.
 * Usuário:  
 * Data: 02/03/2026
 * Tempo: 15:58
 * 
 */
using System;
using NxtControl.GuiFramework;
using NxtControl.Services;

#region Definitions;
#region #BloqueioAtivaDesativa_HMI;

namespace Hidryco.HidrycoLib.Symbols.BloqueioAtivaDesativa
{

  public class E_ATUALIZA_BLOQUEIOEventArgs : System.EventArgs
  {
    IHMIAccessorService accessorService;
    int channelId;
    int cookie; 
    int eventIndex;

    public E_ATUALIZA_BLOQUEIOEventArgs(int channelId, int cookie, int eventIndex)
    {
      this.accessorService = (IHMIAccessorService)ServiceProvider.GetService(typeof(IHMIAccessorService));
      this.channelId = channelId;
      this.cookie = cookie;
      this.eventIndex = eventIndex;
    }
    public bool Get_STS_BLOQ_ATIVA_DESATIVA(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,0, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_BLOQ_ATIVA_DESATIVA
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,0, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }


  }

  public class LOAD_PERS_DATAEventArgs : System.EventArgs
  {
    IHMIAccessorService accessorService;
    int channelId;
    int cookie; 
    int eventIndex;

    public LOAD_PERS_DATAEventArgs(int channelId, int cookie, int eventIndex)
    {
      this.accessorService = (IHMIAccessorService)ServiceProvider.GetService(typeof(IHMIAccessorService));
      this.channelId = channelId;
      this.cookie = cookie;
      this.eventIndex = eventIndex;
    }

  }

}

namespace Hidryco.HidrycoLib.Symbols.BloqueioAtivaDesativa
{

  public class E_ATUALIZA_SETPOINTEventArgs : System.EventArgs
  {
    public E_ATUALIZA_SETPOINTEventArgs()
    {
    }
    private System.Boolean? CMD_HABILITA_field = null;
    public System.Boolean? CMD_HABILITA
    {
       get { return CMD_HABILITA_field; }
       set { CMD_HABILITA_field = value; }
    }
    private System.Single? STP_ATIVA_BLOQ_field = null;
    public System.Single? STP_ATIVA_BLOQ
    {
       get { return STP_ATIVA_BLOQ_field; }
       set { STP_ATIVA_BLOQ_field = value; }
    }
    private System.Single? STP_DESATIVA_BLOQ_field = null;
    public System.Single? STP_DESATIVA_BLOQ
    {
       get { return STP_DESATIVA_BLOQ_field; }
       set { STP_DESATIVA_BLOQ_field = value; }
    }

  }

}

namespace Hidryco.HidrycoLib.Symbols.BloqueioAtivaDesativa
{
  partial class sDefault
  {

    private event EventHandler<Hidryco.HidrycoLib.Symbols.BloqueioAtivaDesativa.E_ATUALIZA_BLOQUEIOEventArgs> E_ATUALIZA_BLOQUEIO_Fired;

    private event EventHandler<Hidryco.HidrycoLib.Symbols.BloqueioAtivaDesativa.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    protected override void OnEndInit()
    {
      if (E_ATUALIZA_BLOQUEIO_Fired != null)
        AttachEventInput(0);
      if (LOAD_PERS_DATA_Fired != null)
        AttachEventInput(1);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (E_ATUALIZA_BLOQUEIO_Fired != null)
          {
            try
            {
              E_ATUALIZA_BLOQUEIO_Fired(this, new Hidryco.HidrycoLib.Symbols.BloqueioAtivaDesativa.E_ATUALIZA_BLOQUEIOEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","E_ATUALIZA_BLOQUEIO_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 1:
          if (LOAD_PERS_DATA_Fired != null)
          {
            try
            {
              LOAD_PERS_DATA_Fired(this, new Hidryco.HidrycoLib.Symbols.BloqueioAtivaDesativa.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","LOAD_PERS_DATA_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_E_ATUALIZA_SETPOINT(System.Boolean CMD_HABILITA, System.Single STP_ATIVA_BLOQ, System.Single STP_DESATIVA_BLOQ)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {CMD_HABILITA, STP_ATIVA_BLOQ, STP_DESATIVA_BLOQ});
    }
    public bool FireEvent_E_ATUALIZA_SETPOINT(Hidryco.HidrycoLib.Symbols.BloqueioAtivaDesativa.E_ATUALIZA_SETPOINTEventArgs ea)
    {
      object[] _values_ = new object[3];
      if (ea.CMD_HABILITA.HasValue) _values_[0] = ea.CMD_HABILITA.Value;
      if (ea.STP_ATIVA_BLOQ.HasValue) _values_[1] = ea.STP_ATIVA_BLOQ.Value;
      if (ea.STP_DESATIVA_BLOQ.HasValue) _values_[2] = ea.STP_DESATIVA_BLOQ.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_E_ATUALIZA_SETPOINT(System.Boolean CMD_HABILITA, bool ignore_CMD_HABILITA, System.Single STP_ATIVA_BLOQ, bool ignore_STP_ATIVA_BLOQ, System.Single STP_DESATIVA_BLOQ, bool ignore_STP_DESATIVA_BLOQ)
    {
      object[] _values_ = new object[3];
      if (!ignore_CMD_HABILITA) _values_[0] = CMD_HABILITA;
      if (!ignore_STP_ATIVA_BLOQ) _values_[1] = STP_ATIVA_BLOQ;
      if (!ignore_STP_DESATIVA_BLOQ) _values_[2] = STP_DESATIVA_BLOQ;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }

  }
}

namespace Hidryco.HidrycoLib.Faceplates.BloqueioAtivaDesativa
{
  partial class fpAjuste
  {

    private event EventHandler<Hidryco.HidrycoLib.Symbols.BloqueioAtivaDesativa.E_ATUALIZA_BLOQUEIOEventArgs> E_ATUALIZA_BLOQUEIO_Fired;

    private event EventHandler<Hidryco.HidrycoLib.Symbols.BloqueioAtivaDesativa.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    protected override void OnEndInit()
    {
      if (E_ATUALIZA_BLOQUEIO_Fired != null)
        AttachEventInput(0);
      if (LOAD_PERS_DATA_Fired != null)
        AttachEventInput(1);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (E_ATUALIZA_BLOQUEIO_Fired != null)
          {
            try
            {
              E_ATUALIZA_BLOQUEIO_Fired(this, new Hidryco.HidrycoLib.Symbols.BloqueioAtivaDesativa.E_ATUALIZA_BLOQUEIOEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","E_ATUALIZA_BLOQUEIO_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 1:
          if (LOAD_PERS_DATA_Fired != null)
          {
            try
            {
              LOAD_PERS_DATA_Fired(this, new Hidryco.HidrycoLib.Symbols.BloqueioAtivaDesativa.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","LOAD_PERS_DATA_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_E_ATUALIZA_SETPOINT(System.Boolean CMD_HABILITA, System.Single STP_ATIVA_BLOQ, System.Single STP_DESATIVA_BLOQ)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {CMD_HABILITA, STP_ATIVA_BLOQ, STP_DESATIVA_BLOQ});
    }
    public bool FireEvent_E_ATUALIZA_SETPOINT(Hidryco.HidrycoLib.Symbols.BloqueioAtivaDesativa.E_ATUALIZA_SETPOINTEventArgs ea)
    {
      object[] _values_ = new object[3];
      if (ea.CMD_HABILITA.HasValue) _values_[0] = ea.CMD_HABILITA.Value;
      if (ea.STP_ATIVA_BLOQ.HasValue) _values_[1] = ea.STP_ATIVA_BLOQ.Value;
      if (ea.STP_DESATIVA_BLOQ.HasValue) _values_[2] = ea.STP_DESATIVA_BLOQ.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_E_ATUALIZA_SETPOINT(System.Boolean CMD_HABILITA, bool ignore_CMD_HABILITA, System.Single STP_ATIVA_BLOQ, bool ignore_STP_ATIVA_BLOQ, System.Single STP_DESATIVA_BLOQ, bool ignore_STP_DESATIVA_BLOQ)
    {
      object[] _values_ = new object[3];
      if (!ignore_CMD_HABILITA) _values_[0] = CMD_HABILITA;
      if (!ignore_STP_ATIVA_BLOQ) _values_[1] = STP_ATIVA_BLOQ;
      if (!ignore_STP_DESATIVA_BLOQ) _values_[2] = STP_DESATIVA_BLOQ;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }

  }
}
#endregion #BloqueioAtivaDesativa_HMI;

#endregion Definitions;
