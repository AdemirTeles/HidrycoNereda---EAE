/*
 * Criado pelo EcoStruxure Automation Expert.
 * Usuário:  
 * Data: 20/01/2026
 * Tempo: 09:27
 * 
 */
using System;
using NxtControl.GuiFramework;
using NxtControl.Services;

#region Definitions;
#region #Sensor_Comunicacao_HMI;

namespace Hidryco.HidrycoLib.Symbols.Sensor_Comunicacao
{

  public class E_ATUALIZA_STS_SENSOREventArgs : System.EventArgs
  {
    IHMIAccessorService accessorService;
    int channelId;
    int cookie; 
    int eventIndex;

    public E_ATUALIZA_STS_SENSOREventArgs(int channelId, int cookie, int eventIndex)
    {
      this.accessorService = (IHMIAccessorService)ServiceProvider.GetService(typeof(IHMIAccessorService));
      this.channelId = channelId;
      this.cookie = cookie;
      this.eventIndex = eventIndex;
    }
    public bool Get_STS_SENSOR(ref System.Single value)
    {
      if (accessorService == null)
        return false;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,0, ref var);
      if (ret) value = (System.Single) var;
      return ret;
    }

    public System.Single? STS_SENSOR
    { get {
      if (accessorService == null)
        return null;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,0, ref var);
      if (!ret) return null;
      return (System.Single) var;
    }  }

    public bool Get_STS_FALHA_SENSOR(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,1, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_FALHA_SENSOR
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,1, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_FALHA_COMUNICACAO(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,2, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_FALHA_COMUNICACAO
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,2, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }


  }

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
    public bool Get_STS_ALARME_HH(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,0, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_ALARME_HH
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,0, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_ALARME_H(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,1, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_ALARME_H
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,1, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_ALARME_L(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,2, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_ALARME_L
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,2, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_ALARME_LL(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,3, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_ALARME_LL
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,3, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_ALARME(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,4, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_ALARME
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,4, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }


  }

}

namespace Hidryco.HidrycoLib.Symbols.Sensor_Comunicacao
{

  public class E_RESET_ALARMESEventArgs : System.EventArgs
  {
    public E_RESET_ALARMESEventArgs()
    {
    }

  }

  public class E_ATUALIZA_SETPOINTSEventArgs : System.EventArgs
  {
    public E_ATUALIZA_SETPOINTSEventArgs()
    {
    }
    private System.UInt16? stpTempoAlarmeHH_field = null;
    public System.UInt16? stpTempoAlarmeHH
    {
       get { return stpTempoAlarmeHH_field; }
       set { stpTempoAlarmeHH_field = value; }
    }
    private System.UInt16? stpTempoAlarmeH_field = null;
    public System.UInt16? stpTempoAlarmeH
    {
       get { return stpTempoAlarmeH_field; }
       set { stpTempoAlarmeH_field = value; }
    }
    private System.UInt16? stpTempoAlarmeL_field = null;
    public System.UInt16? stpTempoAlarmeL
    {
       get { return stpTempoAlarmeL_field; }
       set { stpTempoAlarmeL_field = value; }
    }
    private System.UInt16? stpTempoAlarmeLL_field = null;
    public System.UInt16? stpTempoAlarmeLL
    {
       get { return stpTempoAlarmeLL_field; }
       set { stpTempoAlarmeLL_field = value; }
    }
    private System.Single? stpAlarmeHH_field = null;
    public System.Single? stpAlarmeHH
    {
       get { return stpAlarmeHH_field; }
       set { stpAlarmeHH_field = value; }
    }
    private System.Single? stpAlarmeH_field = null;
    public System.Single? stpAlarmeH
    {
       get { return stpAlarmeH_field; }
       set { stpAlarmeH_field = value; }
    }
    private System.Single? stpAlarmeL_field = null;
    public System.Single? stpAlarmeL
    {
       get { return stpAlarmeL_field; }
       set { stpAlarmeL_field = value; }
    }
    private System.Single? stpAlarmeLL_field = null;
    public System.Single? stpAlarmeLL
    {
       get { return stpAlarmeLL_field; }
       set { stpAlarmeLL_field = value; }
    }
    private System.Boolean? cmdHabilitaSensor_field = null;
    public System.Boolean? cmdHabilitaSensor
    {
       get { return cmdHabilitaSensor_field; }
       set { cmdHabilitaSensor_field = value; }
    }
    private System.Boolean? cmdHabilitaAlarmeHH_field = null;
    public System.Boolean? cmdHabilitaAlarmeHH
    {
       get { return cmdHabilitaAlarmeHH_field; }
       set { cmdHabilitaAlarmeHH_field = value; }
    }
    private System.Boolean? cmdHabilitaAlarmeH_field = null;
    public System.Boolean? cmdHabilitaAlarmeH
    {
       get { return cmdHabilitaAlarmeH_field; }
       set { cmdHabilitaAlarmeH_field = value; }
    }
    private System.Boolean? cmdHabilitaAlarmeL_field = null;
    public System.Boolean? cmdHabilitaAlarmeL
    {
       get { return cmdHabilitaAlarmeL_field; }
       set { cmdHabilitaAlarmeL_field = value; }
    }
    private System.Boolean? cmdHabilitaAlarmeLL_field = null;
    public System.Boolean? cmdHabilitaAlarmeLL
    {
       get { return cmdHabilitaAlarmeLL_field; }
       set { cmdHabilitaAlarmeLL_field = value; }
    }

  }

}

namespace Hidryco.HidrycoLib.Symbols.Sensor_Comunicacao
{
  partial class sDefault
  {

    private event EventHandler<Hidryco.HidrycoLib.Symbols.Sensor_Comunicacao.E_ATUALIZA_STS_SENSOREventArgs> E_ATUALIZA_STS_SENSOR_Fired;

    private event EventHandler<Hidryco.HidrycoLib.Symbols.Sensor_Comunicacao.REQEventArgs> REQ_Fired;

    protected override void OnEndInit()
    {
      if (E_ATUALIZA_STS_SENSOR_Fired != null)
        AttachEventInput(0);
      if (REQ_Fired != null)
        AttachEventInput(1);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (E_ATUALIZA_STS_SENSOR_Fired != null)
          {
            try
            {
              E_ATUALIZA_STS_SENSOR_Fired(this, new Hidryco.HidrycoLib.Symbols.Sensor_Comunicacao.E_ATUALIZA_STS_SENSOREventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","E_ATUALIZA_STS_SENSOR_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 1:
          if (REQ_Fired != null)
          {
            try
            {
              REQ_Fired(this, new Hidryco.HidrycoLib.Symbols.Sensor_Comunicacao.REQEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REQ_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_E_RESET_ALARMES()
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {});
    }
    public bool FireEvent_E_RESET_ALARMES(Hidryco.HidrycoLib.Symbols.Sensor_Comunicacao.E_RESET_ALARMESEventArgs ea)
    {
      object[] _values_ = new object[0];
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_E_ATUALIZA_SETPOINTS(System.UInt16 stpTempoAlarmeHH, System.UInt16 stpTempoAlarmeH, System.UInt16 stpTempoAlarmeL, System.UInt16 stpTempoAlarmeLL, System.Single stpAlarmeHH, System.Single stpAlarmeH, System.Single stpAlarmeL, System.Single stpAlarmeLL, System.Boolean cmdHabilitaSensor, System.Boolean cmdHabilitaAlarmeHH, System.Boolean cmdHabilitaAlarmeH, System.Boolean cmdHabilitaAlarmeL, System.Boolean cmdHabilitaAlarmeLL)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {stpTempoAlarmeHH, stpTempoAlarmeH, stpTempoAlarmeL, stpTempoAlarmeLL, stpAlarmeHH, stpAlarmeH, stpAlarmeL, stpAlarmeLL, cmdHabilitaSensor, cmdHabilitaAlarmeHH, cmdHabilitaAlarmeH, cmdHabilitaAlarmeL, cmdHabilitaAlarmeLL});
    }
    public bool FireEvent_E_ATUALIZA_SETPOINTS(Hidryco.HidrycoLib.Symbols.Sensor_Comunicacao.E_ATUALIZA_SETPOINTSEventArgs ea)
    {
      object[] _values_ = new object[13];
      if (ea.stpTempoAlarmeHH.HasValue) _values_[0] = ea.stpTempoAlarmeHH.Value;
      if (ea.stpTempoAlarmeH.HasValue) _values_[1] = ea.stpTempoAlarmeH.Value;
      if (ea.stpTempoAlarmeL.HasValue) _values_[2] = ea.stpTempoAlarmeL.Value;
      if (ea.stpTempoAlarmeLL.HasValue) _values_[3] = ea.stpTempoAlarmeLL.Value;
      if (ea.stpAlarmeHH.HasValue) _values_[4] = ea.stpAlarmeHH.Value;
      if (ea.stpAlarmeH.HasValue) _values_[5] = ea.stpAlarmeH.Value;
      if (ea.stpAlarmeL.HasValue) _values_[6] = ea.stpAlarmeL.Value;
      if (ea.stpAlarmeLL.HasValue) _values_[7] = ea.stpAlarmeLL.Value;
      if (ea.cmdHabilitaSensor.HasValue) _values_[8] = ea.cmdHabilitaSensor.Value;
      if (ea.cmdHabilitaAlarmeHH.HasValue) _values_[9] = ea.cmdHabilitaAlarmeHH.Value;
      if (ea.cmdHabilitaAlarmeH.HasValue) _values_[10] = ea.cmdHabilitaAlarmeH.Value;
      if (ea.cmdHabilitaAlarmeL.HasValue) _values_[11] = ea.cmdHabilitaAlarmeL.Value;
      if (ea.cmdHabilitaAlarmeLL.HasValue) _values_[12] = ea.cmdHabilitaAlarmeLL.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_E_ATUALIZA_SETPOINTS(System.UInt16 stpTempoAlarmeHH, bool ignore_stpTempoAlarmeHH, System.UInt16 stpTempoAlarmeH, bool ignore_stpTempoAlarmeH, System.UInt16 stpTempoAlarmeL, bool ignore_stpTempoAlarmeL, System.UInt16 stpTempoAlarmeLL, bool ignore_stpTempoAlarmeLL, System.Single stpAlarmeHH, bool ignore_stpAlarmeHH, System.Single stpAlarmeH, bool ignore_stpAlarmeH, System.Single stpAlarmeL, bool ignore_stpAlarmeL, System.Single stpAlarmeLL, bool ignore_stpAlarmeLL, System.Boolean cmdHabilitaSensor, bool ignore_cmdHabilitaSensor, System.Boolean cmdHabilitaAlarmeHH, bool ignore_cmdHabilitaAlarmeHH, System.Boolean cmdHabilitaAlarmeH, bool ignore_cmdHabilitaAlarmeH, System.Boolean cmdHabilitaAlarmeL, bool ignore_cmdHabilitaAlarmeL, System.Boolean cmdHabilitaAlarmeLL, bool ignore_cmdHabilitaAlarmeLL)
    {
      object[] _values_ = new object[13];
      if (!ignore_stpTempoAlarmeHH) _values_[0] = stpTempoAlarmeHH;
      if (!ignore_stpTempoAlarmeH) _values_[1] = stpTempoAlarmeH;
      if (!ignore_stpTempoAlarmeL) _values_[2] = stpTempoAlarmeL;
      if (!ignore_stpTempoAlarmeLL) _values_[3] = stpTempoAlarmeLL;
      if (!ignore_stpAlarmeHH) _values_[4] = stpAlarmeHH;
      if (!ignore_stpAlarmeH) _values_[5] = stpAlarmeH;
      if (!ignore_stpAlarmeL) _values_[6] = stpAlarmeL;
      if (!ignore_stpAlarmeLL) _values_[7] = stpAlarmeLL;
      if (!ignore_cmdHabilitaSensor) _values_[8] = cmdHabilitaSensor;
      if (!ignore_cmdHabilitaAlarmeHH) _values_[9] = cmdHabilitaAlarmeHH;
      if (!ignore_cmdHabilitaAlarmeH) _values_[10] = cmdHabilitaAlarmeH;
      if (!ignore_cmdHabilitaAlarmeL) _values_[11] = cmdHabilitaAlarmeL;
      if (!ignore_cmdHabilitaAlarmeLL) _values_[12] = cmdHabilitaAlarmeLL;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }

  }
}

namespace Hidryco.HidrycoLib.Faceplates.Sensor_Comunicacao
{
  partial class fpAlarmes
  {

    private event EventHandler<Hidryco.HidrycoLib.Symbols.Sensor_Comunicacao.E_ATUALIZA_STS_SENSOREventArgs> E_ATUALIZA_STS_SENSOR_Fired;

    private event EventHandler<Hidryco.HidrycoLib.Symbols.Sensor_Comunicacao.REQEventArgs> REQ_Fired;

    protected override void OnEndInit()
    {
      if (E_ATUALIZA_STS_SENSOR_Fired != null)
        AttachEventInput(0);
      if (REQ_Fired != null)
        AttachEventInput(1);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (E_ATUALIZA_STS_SENSOR_Fired != null)
          {
            try
            {
              E_ATUALIZA_STS_SENSOR_Fired(this, new Hidryco.HidrycoLib.Symbols.Sensor_Comunicacao.E_ATUALIZA_STS_SENSOREventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","E_ATUALIZA_STS_SENSOR_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 1:
          if (REQ_Fired != null)
          {
            try
            {
              REQ_Fired(this, new Hidryco.HidrycoLib.Symbols.Sensor_Comunicacao.REQEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REQ_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_E_RESET_ALARMES()
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {});
    }
    public bool FireEvent_E_RESET_ALARMES(Hidryco.HidrycoLib.Symbols.Sensor_Comunicacao.E_RESET_ALARMESEventArgs ea)
    {
      object[] _values_ = new object[0];
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_E_ATUALIZA_SETPOINTS(System.UInt16 stpTempoAlarmeHH, System.UInt16 stpTempoAlarmeH, System.UInt16 stpTempoAlarmeL, System.UInt16 stpTempoAlarmeLL, System.Single stpAlarmeHH, System.Single stpAlarmeH, System.Single stpAlarmeL, System.Single stpAlarmeLL, System.Boolean cmdHabilitaSensor, System.Boolean cmdHabilitaAlarmeHH, System.Boolean cmdHabilitaAlarmeH, System.Boolean cmdHabilitaAlarmeL, System.Boolean cmdHabilitaAlarmeLL)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {stpTempoAlarmeHH, stpTempoAlarmeH, stpTempoAlarmeL, stpTempoAlarmeLL, stpAlarmeHH, stpAlarmeH, stpAlarmeL, stpAlarmeLL, cmdHabilitaSensor, cmdHabilitaAlarmeHH, cmdHabilitaAlarmeH, cmdHabilitaAlarmeL, cmdHabilitaAlarmeLL});
    }
    public bool FireEvent_E_ATUALIZA_SETPOINTS(Hidryco.HidrycoLib.Symbols.Sensor_Comunicacao.E_ATUALIZA_SETPOINTSEventArgs ea)
    {
      object[] _values_ = new object[13];
      if (ea.stpTempoAlarmeHH.HasValue) _values_[0] = ea.stpTempoAlarmeHH.Value;
      if (ea.stpTempoAlarmeH.HasValue) _values_[1] = ea.stpTempoAlarmeH.Value;
      if (ea.stpTempoAlarmeL.HasValue) _values_[2] = ea.stpTempoAlarmeL.Value;
      if (ea.stpTempoAlarmeLL.HasValue) _values_[3] = ea.stpTempoAlarmeLL.Value;
      if (ea.stpAlarmeHH.HasValue) _values_[4] = ea.stpAlarmeHH.Value;
      if (ea.stpAlarmeH.HasValue) _values_[5] = ea.stpAlarmeH.Value;
      if (ea.stpAlarmeL.HasValue) _values_[6] = ea.stpAlarmeL.Value;
      if (ea.stpAlarmeLL.HasValue) _values_[7] = ea.stpAlarmeLL.Value;
      if (ea.cmdHabilitaSensor.HasValue) _values_[8] = ea.cmdHabilitaSensor.Value;
      if (ea.cmdHabilitaAlarmeHH.HasValue) _values_[9] = ea.cmdHabilitaAlarmeHH.Value;
      if (ea.cmdHabilitaAlarmeH.HasValue) _values_[10] = ea.cmdHabilitaAlarmeH.Value;
      if (ea.cmdHabilitaAlarmeL.HasValue) _values_[11] = ea.cmdHabilitaAlarmeL.Value;
      if (ea.cmdHabilitaAlarmeLL.HasValue) _values_[12] = ea.cmdHabilitaAlarmeLL.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_E_ATUALIZA_SETPOINTS(System.UInt16 stpTempoAlarmeHH, bool ignore_stpTempoAlarmeHH, System.UInt16 stpTempoAlarmeH, bool ignore_stpTempoAlarmeH, System.UInt16 stpTempoAlarmeL, bool ignore_stpTempoAlarmeL, System.UInt16 stpTempoAlarmeLL, bool ignore_stpTempoAlarmeLL, System.Single stpAlarmeHH, bool ignore_stpAlarmeHH, System.Single stpAlarmeH, bool ignore_stpAlarmeH, System.Single stpAlarmeL, bool ignore_stpAlarmeL, System.Single stpAlarmeLL, bool ignore_stpAlarmeLL, System.Boolean cmdHabilitaSensor, bool ignore_cmdHabilitaSensor, System.Boolean cmdHabilitaAlarmeHH, bool ignore_cmdHabilitaAlarmeHH, System.Boolean cmdHabilitaAlarmeH, bool ignore_cmdHabilitaAlarmeH, System.Boolean cmdHabilitaAlarmeL, bool ignore_cmdHabilitaAlarmeL, System.Boolean cmdHabilitaAlarmeLL, bool ignore_cmdHabilitaAlarmeLL)
    {
      object[] _values_ = new object[13];
      if (!ignore_stpTempoAlarmeHH) _values_[0] = stpTempoAlarmeHH;
      if (!ignore_stpTempoAlarmeH) _values_[1] = stpTempoAlarmeH;
      if (!ignore_stpTempoAlarmeL) _values_[2] = stpTempoAlarmeL;
      if (!ignore_stpTempoAlarmeLL) _values_[3] = stpTempoAlarmeLL;
      if (!ignore_stpAlarmeHH) _values_[4] = stpAlarmeHH;
      if (!ignore_stpAlarmeH) _values_[5] = stpAlarmeH;
      if (!ignore_stpAlarmeL) _values_[6] = stpAlarmeL;
      if (!ignore_stpAlarmeLL) _values_[7] = stpAlarmeLL;
      if (!ignore_cmdHabilitaSensor) _values_[8] = cmdHabilitaSensor;
      if (!ignore_cmdHabilitaAlarmeHH) _values_[9] = cmdHabilitaAlarmeHH;
      if (!ignore_cmdHabilitaAlarmeH) _values_[10] = cmdHabilitaAlarmeH;
      if (!ignore_cmdHabilitaAlarmeL) _values_[11] = cmdHabilitaAlarmeL;
      if (!ignore_cmdHabilitaAlarmeLL) _values_[12] = cmdHabilitaAlarmeLL;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }

  }
}

namespace Hidryco.HidrycoLib.Faceplates.Sensor_Comunicacao
{
  partial class fpGrafico
  {

    private event EventHandler<Hidryco.HidrycoLib.Symbols.Sensor_Comunicacao.E_ATUALIZA_STS_SENSOREventArgs> E_ATUALIZA_STS_SENSOR_Fired;

    private event EventHandler<Hidryco.HidrycoLib.Symbols.Sensor_Comunicacao.REQEventArgs> REQ_Fired;

    protected override void OnEndInit()
    {
      if (E_ATUALIZA_STS_SENSOR_Fired != null)
        AttachEventInput(0);
      if (REQ_Fired != null)
        AttachEventInput(1);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (E_ATUALIZA_STS_SENSOR_Fired != null)
          {
            try
            {
              E_ATUALIZA_STS_SENSOR_Fired(this, new Hidryco.HidrycoLib.Symbols.Sensor_Comunicacao.E_ATUALIZA_STS_SENSOREventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","E_ATUALIZA_STS_SENSOR_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 1:
          if (REQ_Fired != null)
          {
            try
            {
              REQ_Fired(this, new Hidryco.HidrycoLib.Symbols.Sensor_Comunicacao.REQEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REQ_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_E_RESET_ALARMES()
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {});
    }
    public bool FireEvent_E_RESET_ALARMES(Hidryco.HidrycoLib.Symbols.Sensor_Comunicacao.E_RESET_ALARMESEventArgs ea)
    {
      object[] _values_ = new object[0];
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_E_ATUALIZA_SETPOINTS(System.UInt16 stpTempoAlarmeHH, System.UInt16 stpTempoAlarmeH, System.UInt16 stpTempoAlarmeL, System.UInt16 stpTempoAlarmeLL, System.Single stpAlarmeHH, System.Single stpAlarmeH, System.Single stpAlarmeL, System.Single stpAlarmeLL, System.Boolean cmdHabilitaSensor, System.Boolean cmdHabilitaAlarmeHH, System.Boolean cmdHabilitaAlarmeH, System.Boolean cmdHabilitaAlarmeL, System.Boolean cmdHabilitaAlarmeLL)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {stpTempoAlarmeHH, stpTempoAlarmeH, stpTempoAlarmeL, stpTempoAlarmeLL, stpAlarmeHH, stpAlarmeH, stpAlarmeL, stpAlarmeLL, cmdHabilitaSensor, cmdHabilitaAlarmeHH, cmdHabilitaAlarmeH, cmdHabilitaAlarmeL, cmdHabilitaAlarmeLL});
    }
    public bool FireEvent_E_ATUALIZA_SETPOINTS(Hidryco.HidrycoLib.Symbols.Sensor_Comunicacao.E_ATUALIZA_SETPOINTSEventArgs ea)
    {
      object[] _values_ = new object[13];
      if (ea.stpTempoAlarmeHH.HasValue) _values_[0] = ea.stpTempoAlarmeHH.Value;
      if (ea.stpTempoAlarmeH.HasValue) _values_[1] = ea.stpTempoAlarmeH.Value;
      if (ea.stpTempoAlarmeL.HasValue) _values_[2] = ea.stpTempoAlarmeL.Value;
      if (ea.stpTempoAlarmeLL.HasValue) _values_[3] = ea.stpTempoAlarmeLL.Value;
      if (ea.stpAlarmeHH.HasValue) _values_[4] = ea.stpAlarmeHH.Value;
      if (ea.stpAlarmeH.HasValue) _values_[5] = ea.stpAlarmeH.Value;
      if (ea.stpAlarmeL.HasValue) _values_[6] = ea.stpAlarmeL.Value;
      if (ea.stpAlarmeLL.HasValue) _values_[7] = ea.stpAlarmeLL.Value;
      if (ea.cmdHabilitaSensor.HasValue) _values_[8] = ea.cmdHabilitaSensor.Value;
      if (ea.cmdHabilitaAlarmeHH.HasValue) _values_[9] = ea.cmdHabilitaAlarmeHH.Value;
      if (ea.cmdHabilitaAlarmeH.HasValue) _values_[10] = ea.cmdHabilitaAlarmeH.Value;
      if (ea.cmdHabilitaAlarmeL.HasValue) _values_[11] = ea.cmdHabilitaAlarmeL.Value;
      if (ea.cmdHabilitaAlarmeLL.HasValue) _values_[12] = ea.cmdHabilitaAlarmeLL.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_E_ATUALIZA_SETPOINTS(System.UInt16 stpTempoAlarmeHH, bool ignore_stpTempoAlarmeHH, System.UInt16 stpTempoAlarmeH, bool ignore_stpTempoAlarmeH, System.UInt16 stpTempoAlarmeL, bool ignore_stpTempoAlarmeL, System.UInt16 stpTempoAlarmeLL, bool ignore_stpTempoAlarmeLL, System.Single stpAlarmeHH, bool ignore_stpAlarmeHH, System.Single stpAlarmeH, bool ignore_stpAlarmeH, System.Single stpAlarmeL, bool ignore_stpAlarmeL, System.Single stpAlarmeLL, bool ignore_stpAlarmeLL, System.Boolean cmdHabilitaSensor, bool ignore_cmdHabilitaSensor, System.Boolean cmdHabilitaAlarmeHH, bool ignore_cmdHabilitaAlarmeHH, System.Boolean cmdHabilitaAlarmeH, bool ignore_cmdHabilitaAlarmeH, System.Boolean cmdHabilitaAlarmeL, bool ignore_cmdHabilitaAlarmeL, System.Boolean cmdHabilitaAlarmeLL, bool ignore_cmdHabilitaAlarmeLL)
    {
      object[] _values_ = new object[13];
      if (!ignore_stpTempoAlarmeHH) _values_[0] = stpTempoAlarmeHH;
      if (!ignore_stpTempoAlarmeH) _values_[1] = stpTempoAlarmeH;
      if (!ignore_stpTempoAlarmeL) _values_[2] = stpTempoAlarmeL;
      if (!ignore_stpTempoAlarmeLL) _values_[3] = stpTempoAlarmeLL;
      if (!ignore_stpAlarmeHH) _values_[4] = stpAlarmeHH;
      if (!ignore_stpAlarmeH) _values_[5] = stpAlarmeH;
      if (!ignore_stpAlarmeL) _values_[6] = stpAlarmeL;
      if (!ignore_stpAlarmeLL) _values_[7] = stpAlarmeLL;
      if (!ignore_cmdHabilitaSensor) _values_[8] = cmdHabilitaSensor;
      if (!ignore_cmdHabilitaAlarmeHH) _values_[9] = cmdHabilitaAlarmeHH;
      if (!ignore_cmdHabilitaAlarmeH) _values_[10] = cmdHabilitaAlarmeH;
      if (!ignore_cmdHabilitaAlarmeL) _values_[11] = cmdHabilitaAlarmeL;
      if (!ignore_cmdHabilitaAlarmeLL) _values_[12] = cmdHabilitaAlarmeLL;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }

  }
}

namespace Hidryco.HidrycoLib.Faceplates.Sensor_Comunicacao
{
  partial class fpAjustes
  {

    private event EventHandler<Hidryco.HidrycoLib.Symbols.Sensor_Comunicacao.E_ATUALIZA_STS_SENSOREventArgs> E_ATUALIZA_STS_SENSOR_Fired;

    private event EventHandler<Hidryco.HidrycoLib.Symbols.Sensor_Comunicacao.REQEventArgs> REQ_Fired;

    protected override void OnEndInit()
    {
      if (E_ATUALIZA_STS_SENSOR_Fired != null)
        AttachEventInput(0);
      if (REQ_Fired != null)
        AttachEventInput(1);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (E_ATUALIZA_STS_SENSOR_Fired != null)
          {
            try
            {
              E_ATUALIZA_STS_SENSOR_Fired(this, new Hidryco.HidrycoLib.Symbols.Sensor_Comunicacao.E_ATUALIZA_STS_SENSOREventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","E_ATUALIZA_STS_SENSOR_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 1:
          if (REQ_Fired != null)
          {
            try
            {
              REQ_Fired(this, new Hidryco.HidrycoLib.Symbols.Sensor_Comunicacao.REQEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REQ_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_E_RESET_ALARMES()
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {});
    }
    public bool FireEvent_E_RESET_ALARMES(Hidryco.HidrycoLib.Symbols.Sensor_Comunicacao.E_RESET_ALARMESEventArgs ea)
    {
      object[] _values_ = new object[0];
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_E_ATUALIZA_SETPOINTS(System.UInt16 stpTempoAlarmeHH, System.UInt16 stpTempoAlarmeH, System.UInt16 stpTempoAlarmeL, System.UInt16 stpTempoAlarmeLL, System.Single stpAlarmeHH, System.Single stpAlarmeH, System.Single stpAlarmeL, System.Single stpAlarmeLL, System.Boolean cmdHabilitaSensor, System.Boolean cmdHabilitaAlarmeHH, System.Boolean cmdHabilitaAlarmeH, System.Boolean cmdHabilitaAlarmeL, System.Boolean cmdHabilitaAlarmeLL)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {stpTempoAlarmeHH, stpTempoAlarmeH, stpTempoAlarmeL, stpTempoAlarmeLL, stpAlarmeHH, stpAlarmeH, stpAlarmeL, stpAlarmeLL, cmdHabilitaSensor, cmdHabilitaAlarmeHH, cmdHabilitaAlarmeH, cmdHabilitaAlarmeL, cmdHabilitaAlarmeLL});
    }
    public bool FireEvent_E_ATUALIZA_SETPOINTS(Hidryco.HidrycoLib.Symbols.Sensor_Comunicacao.E_ATUALIZA_SETPOINTSEventArgs ea)
    {
      object[] _values_ = new object[13];
      if (ea.stpTempoAlarmeHH.HasValue) _values_[0] = ea.stpTempoAlarmeHH.Value;
      if (ea.stpTempoAlarmeH.HasValue) _values_[1] = ea.stpTempoAlarmeH.Value;
      if (ea.stpTempoAlarmeL.HasValue) _values_[2] = ea.stpTempoAlarmeL.Value;
      if (ea.stpTempoAlarmeLL.HasValue) _values_[3] = ea.stpTempoAlarmeLL.Value;
      if (ea.stpAlarmeHH.HasValue) _values_[4] = ea.stpAlarmeHH.Value;
      if (ea.stpAlarmeH.HasValue) _values_[5] = ea.stpAlarmeH.Value;
      if (ea.stpAlarmeL.HasValue) _values_[6] = ea.stpAlarmeL.Value;
      if (ea.stpAlarmeLL.HasValue) _values_[7] = ea.stpAlarmeLL.Value;
      if (ea.cmdHabilitaSensor.HasValue) _values_[8] = ea.cmdHabilitaSensor.Value;
      if (ea.cmdHabilitaAlarmeHH.HasValue) _values_[9] = ea.cmdHabilitaAlarmeHH.Value;
      if (ea.cmdHabilitaAlarmeH.HasValue) _values_[10] = ea.cmdHabilitaAlarmeH.Value;
      if (ea.cmdHabilitaAlarmeL.HasValue) _values_[11] = ea.cmdHabilitaAlarmeL.Value;
      if (ea.cmdHabilitaAlarmeLL.HasValue) _values_[12] = ea.cmdHabilitaAlarmeLL.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_E_ATUALIZA_SETPOINTS(System.UInt16 stpTempoAlarmeHH, bool ignore_stpTempoAlarmeHH, System.UInt16 stpTempoAlarmeH, bool ignore_stpTempoAlarmeH, System.UInt16 stpTempoAlarmeL, bool ignore_stpTempoAlarmeL, System.UInt16 stpTempoAlarmeLL, bool ignore_stpTempoAlarmeLL, System.Single stpAlarmeHH, bool ignore_stpAlarmeHH, System.Single stpAlarmeH, bool ignore_stpAlarmeH, System.Single stpAlarmeL, bool ignore_stpAlarmeL, System.Single stpAlarmeLL, bool ignore_stpAlarmeLL, System.Boolean cmdHabilitaSensor, bool ignore_cmdHabilitaSensor, System.Boolean cmdHabilitaAlarmeHH, bool ignore_cmdHabilitaAlarmeHH, System.Boolean cmdHabilitaAlarmeH, bool ignore_cmdHabilitaAlarmeH, System.Boolean cmdHabilitaAlarmeL, bool ignore_cmdHabilitaAlarmeL, System.Boolean cmdHabilitaAlarmeLL, bool ignore_cmdHabilitaAlarmeLL)
    {
      object[] _values_ = new object[13];
      if (!ignore_stpTempoAlarmeHH) _values_[0] = stpTempoAlarmeHH;
      if (!ignore_stpTempoAlarmeH) _values_[1] = stpTempoAlarmeH;
      if (!ignore_stpTempoAlarmeL) _values_[2] = stpTempoAlarmeL;
      if (!ignore_stpTempoAlarmeLL) _values_[3] = stpTempoAlarmeLL;
      if (!ignore_stpAlarmeHH) _values_[4] = stpAlarmeHH;
      if (!ignore_stpAlarmeH) _values_[5] = stpAlarmeH;
      if (!ignore_stpAlarmeL) _values_[6] = stpAlarmeL;
      if (!ignore_stpAlarmeLL) _values_[7] = stpAlarmeLL;
      if (!ignore_cmdHabilitaSensor) _values_[8] = cmdHabilitaSensor;
      if (!ignore_cmdHabilitaAlarmeHH) _values_[9] = cmdHabilitaAlarmeHH;
      if (!ignore_cmdHabilitaAlarmeH) _values_[10] = cmdHabilitaAlarmeH;
      if (!ignore_cmdHabilitaAlarmeL) _values_[11] = cmdHabilitaAlarmeL;
      if (!ignore_cmdHabilitaAlarmeLL) _values_[12] = cmdHabilitaAlarmeLL;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }

  }
}
#endregion #Sensor_Comunicacao_HMI;

#endregion Definitions;
