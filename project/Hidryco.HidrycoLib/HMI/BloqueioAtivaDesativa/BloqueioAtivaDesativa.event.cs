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
    public bool Get_stsBloqueioAutomatico(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,0, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? stsBloqueioAutomatico
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,0, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_stsBloqueioManual(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,1, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? stsBloqueioManual
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,1, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }


  }

}

namespace Hidryco.HidrycoLib.Symbols.BloqueioAtivaDesativa
{

  public class E_ATUALIZA_SETPOINTEventArgs : System.EventArgs
  {
    public E_ATUALIZA_SETPOINTEventArgs()
    {
    }
    private System.Boolean? cmdHabilita_field = null;
    public System.Boolean? cmdHabilita
    {
       get { return cmdHabilita_field; }
       set { cmdHabilita_field = value; }
    }
    private System.Single? stpAtivaBloqueio_field = null;
    public System.Single? stpAtivaBloqueio
    {
       get { return stpAtivaBloqueio_field; }
       set { stpAtivaBloqueio_field = value; }
    }
    private System.Single? stpDesativaBloqueio_field = null;
    public System.Single? stpDesativaBloqueio
    {
       get { return stpDesativaBloqueio_field; }
       set { stpDesativaBloqueio_field = value; }
    }

  }

}

namespace Hidryco.HidrycoLib.Symbols.BloqueioAtivaDesativa
{
  partial class sDefault
  {

    private event EventHandler<Hidryco.HidrycoLib.Symbols.BloqueioAtivaDesativa.E_ATUALIZA_BLOQUEIOEventArgs> E_ATUALIZA_BLOQUEIO_Fired;

    protected override void OnEndInit()
    {
      if (E_ATUALIZA_BLOQUEIO_Fired != null)
        AttachEventInput(0);

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

      }
    }
    public bool FireEvent_E_ATUALIZA_SETPOINT(System.Boolean cmdHabilita, System.Single stpAtivaBloqueio, System.Single stpDesativaBloqueio)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {cmdHabilita, stpAtivaBloqueio, stpDesativaBloqueio});
    }
    public bool FireEvent_E_ATUALIZA_SETPOINT(Hidryco.HidrycoLib.Symbols.BloqueioAtivaDesativa.E_ATUALIZA_SETPOINTEventArgs ea)
    {
      object[] _values_ = new object[3];
      if (ea.cmdHabilita.HasValue) _values_[0] = ea.cmdHabilita.Value;
      if (ea.stpAtivaBloqueio.HasValue) _values_[1] = ea.stpAtivaBloqueio.Value;
      if (ea.stpDesativaBloqueio.HasValue) _values_[2] = ea.stpDesativaBloqueio.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_E_ATUALIZA_SETPOINT(System.Boolean cmdHabilita, bool ignore_cmdHabilita, System.Single stpAtivaBloqueio, bool ignore_stpAtivaBloqueio, System.Single stpDesativaBloqueio, bool ignore_stpDesativaBloqueio)
    {
      object[] _values_ = new object[3];
      if (!ignore_cmdHabilita) _values_[0] = cmdHabilita;
      if (!ignore_stpAtivaBloqueio) _values_[1] = stpAtivaBloqueio;
      if (!ignore_stpDesativaBloqueio) _values_[2] = stpDesativaBloqueio;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }

  }
}

namespace Hidryco.HidrycoLib.Faceplates.BloqueioAtivaDesativa
{
  partial class fpAjuste
  {

    private event EventHandler<Hidryco.HidrycoLib.Symbols.BloqueioAtivaDesativa.E_ATUALIZA_BLOQUEIOEventArgs> E_ATUALIZA_BLOQUEIO_Fired;

    protected override void OnEndInit()
    {
      if (E_ATUALIZA_BLOQUEIO_Fired != null)
        AttachEventInput(0);

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

      }
    }
    public bool FireEvent_E_ATUALIZA_SETPOINT(System.Boolean cmdHabilita, System.Single stpAtivaBloqueio, System.Single stpDesativaBloqueio)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {cmdHabilita, stpAtivaBloqueio, stpDesativaBloqueio});
    }
    public bool FireEvent_E_ATUALIZA_SETPOINT(Hidryco.HidrycoLib.Symbols.BloqueioAtivaDesativa.E_ATUALIZA_SETPOINTEventArgs ea)
    {
      object[] _values_ = new object[3];
      if (ea.cmdHabilita.HasValue) _values_[0] = ea.cmdHabilita.Value;
      if (ea.stpAtivaBloqueio.HasValue) _values_[1] = ea.stpAtivaBloqueio.Value;
      if (ea.stpDesativaBloqueio.HasValue) _values_[2] = ea.stpDesativaBloqueio.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_E_ATUALIZA_SETPOINT(System.Boolean cmdHabilita, bool ignore_cmdHabilita, System.Single stpAtivaBloqueio, bool ignore_stpAtivaBloqueio, System.Single stpDesativaBloqueio, bool ignore_stpDesativaBloqueio)
    {
      object[] _values_ = new object[3];
      if (!ignore_cmdHabilita) _values_[0] = cmdHabilita;
      if (!ignore_stpAtivaBloqueio) _values_[1] = stpAtivaBloqueio;
      if (!ignore_stpDesativaBloqueio) _values_[2] = stpDesativaBloqueio;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }

  }
}
#endregion #BloqueioAtivaDesativa_HMI;

#endregion Definitions;
