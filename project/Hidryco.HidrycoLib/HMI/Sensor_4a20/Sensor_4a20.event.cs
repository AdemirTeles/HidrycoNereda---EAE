/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 1/29/2026
 * Time: 9:09 AM
 * 
 */
using System;
using NxtControl.GuiFramework;
using NxtControl.Services;

#region Definitions;
#region #Sensor_4a20_HMI;

namespace Hidryco.HidrycoLib.Symbols.Sensor_4a20
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


  }

  public class E_ATUALIZA_ALARMESEventArgs : System.EventArgs
  {
    IHMIAccessorService accessorService;
    int channelId;
    int cookie; 
    int eventIndex;

    public E_ATUALIZA_ALARMESEventArgs(int channelId, int cookie, int eventIndex)
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

namespace Hidryco.HidrycoLib.Symbols.Sensor_4a20
{

  public class E_ATUALIZA_SETPOINTSEventArgs : System.EventArgs
  {
    public E_ATUALIZA_SETPOINTSEventArgs()
    {
    }
    private System.UInt16? STP_TEMPO_ALARME_HH_field = null;
    public System.UInt16? STP_TEMPO_ALARME_HH
    {
       get { return STP_TEMPO_ALARME_HH_field; }
       set { STP_TEMPO_ALARME_HH_field = value; }
    }
    private System.UInt16? STP_TEMPO_ALARME_H_field = null;
    public System.UInt16? STP_TEMPO_ALARME_H
    {
       get { return STP_TEMPO_ALARME_H_field; }
       set { STP_TEMPO_ALARME_H_field = value; }
    }
    private System.UInt16? STP_TEMPO_ALARME_L_field = null;
    public System.UInt16? STP_TEMPO_ALARME_L
    {
       get { return STP_TEMPO_ALARME_L_field; }
       set { STP_TEMPO_ALARME_L_field = value; }
    }
    private System.UInt16? STP_TEMPO_ALARME_LL_field = null;
    public System.UInt16? STP_TEMPO_ALARME_LL
    {
       get { return STP_TEMPO_ALARME_LL_field; }
       set { STP_TEMPO_ALARME_LL_field = value; }
    }
    private System.Single? STP_ALARME_HH_field = null;
    public System.Single? STP_ALARME_HH
    {
       get { return STP_ALARME_HH_field; }
       set { STP_ALARME_HH_field = value; }
    }
    private System.Single? STP_ALARME_H_field = null;
    public System.Single? STP_ALARME_H
    {
       get { return STP_ALARME_H_field; }
       set { STP_ALARME_H_field = value; }
    }
    private System.Single? STP_ALARME_L_field = null;
    public System.Single? STP_ALARME_L
    {
       get { return STP_ALARME_L_field; }
       set { STP_ALARME_L_field = value; }
    }
    private System.Single? STP_ALARME_LL_field = null;
    public System.Single? STP_ALARME_LL
    {
       get { return STP_ALARME_LL_field; }
       set { STP_ALARME_LL_field = value; }
    }
    private System.Boolean? CMD_HABILITA_ALARME_HH_field = null;
    public System.Boolean? CMD_HABILITA_ALARME_HH
    {
       get { return CMD_HABILITA_ALARME_HH_field; }
       set { CMD_HABILITA_ALARME_HH_field = value; }
    }
    private System.Boolean? CMD_HABILITA_ALARME_H_field = null;
    public System.Boolean? CMD_HABILITA_ALARME_H
    {
       get { return CMD_HABILITA_ALARME_H_field; }
       set { CMD_HABILITA_ALARME_H_field = value; }
    }
    private System.Boolean? CMD_HABILITA_ALARME_L_field = null;
    public System.Boolean? CMD_HABILITA_ALARME_L
    {
       get { return CMD_HABILITA_ALARME_L_field; }
       set { CMD_HABILITA_ALARME_L_field = value; }
    }
    private System.Boolean? CMD_HABILITA_ALARME_LL_field = null;
    public System.Boolean? CMD_HABILITA_ALARME_LL
    {
       get { return CMD_HABILITA_ALARME_LL_field; }
       set { CMD_HABILITA_ALARME_LL_field = value; }
    }
    private System.Single? STP_RANGE_MAXIMO_field = null;
    public System.Single? STP_RANGE_MAXIMO
    {
       get { return STP_RANGE_MAXIMO_field; }
       set { STP_RANGE_MAXIMO_field = value; }
    }
    private System.Single? STP_RANGE_MINIMO_field = null;
    public System.Single? STP_RANGE_MINIMO
    {
       get { return STP_RANGE_MINIMO_field; }
       set { STP_RANGE_MINIMO_field = value; }
    }
    private System.Boolean? CMD_HABILITA_SENSOR_field = null;
    public System.Boolean? CMD_HABILITA_SENSOR
    {
       get { return CMD_HABILITA_SENSOR_field; }
       set { CMD_HABILITA_SENSOR_field = value; }
    }

  }

  public class E_RESET_FALHAEventArgs : System.EventArgs
  {
    public E_RESET_FALHAEventArgs()
    {
    }

  }

  public class E_RESET_ALARMESEventArgs : System.EventArgs
  {
    public E_RESET_ALARMESEventArgs()
    {
    }

  }

}

namespace Hidryco.HidrycoLib.Symbols.Sensor_4a20
{
  partial class sDefault
  {

    private event EventHandler<Hidryco.HidrycoLib.Symbols.Sensor_4a20.E_ATUALIZA_STS_SENSOREventArgs> E_ATUALIZA_STS_SENSOR_Fired;

    private event EventHandler<Hidryco.HidrycoLib.Symbols.Sensor_4a20.E_ATUALIZA_ALARMESEventArgs> E_ATUALIZA_ALARMES_Fired;

    protected override void OnEndInit()
    {
      if (E_ATUALIZA_STS_SENSOR_Fired != null)
        AttachEventInput(0);
      if (E_ATUALIZA_ALARMES_Fired != null)
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
              E_ATUALIZA_STS_SENSOR_Fired(this, new Hidryco.HidrycoLib.Symbols.Sensor_4a20.E_ATUALIZA_STS_SENSOREventArgs(channelId, cookie, eventIndex));
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
          if (E_ATUALIZA_ALARMES_Fired != null)
          {
            try
            {
              E_ATUALIZA_ALARMES_Fired(this, new Hidryco.HidrycoLib.Symbols.Sensor_4a20.E_ATUALIZA_ALARMESEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","E_ATUALIZA_ALARMES_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_E_ATUALIZA_SETPOINTS(System.UInt16 STP_TEMPO_ALARME_HH, System.UInt16 STP_TEMPO_ALARME_H, System.UInt16 STP_TEMPO_ALARME_L, System.UInt16 STP_TEMPO_ALARME_LL, System.Single STP_ALARME_HH, System.Single STP_ALARME_H, System.Single STP_ALARME_L, System.Single STP_ALARME_LL, System.Boolean CMD_HABILITA_ALARME_HH, System.Boolean CMD_HABILITA_ALARME_H, System.Boolean CMD_HABILITA_ALARME_L, System.Boolean CMD_HABILITA_ALARME_LL, System.Single STP_RANGE_MAXIMO, System.Single STP_RANGE_MINIMO, System.Boolean CMD_HABILITA_SENSOR)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {STP_TEMPO_ALARME_HH, STP_TEMPO_ALARME_H, STP_TEMPO_ALARME_L, STP_TEMPO_ALARME_LL, STP_ALARME_HH, STP_ALARME_H, STP_ALARME_L, STP_ALARME_LL, CMD_HABILITA_ALARME_HH, CMD_HABILITA_ALARME_H, CMD_HABILITA_ALARME_L, CMD_HABILITA_ALARME_LL, STP_RANGE_MAXIMO, STP_RANGE_MINIMO, CMD_HABILITA_SENSOR});
    }
    public bool FireEvent_E_ATUALIZA_SETPOINTS(Hidryco.HidrycoLib.Symbols.Sensor_4a20.E_ATUALIZA_SETPOINTSEventArgs ea)
    {
      object[] _values_ = new object[15];
      if (ea.STP_TEMPO_ALARME_HH.HasValue) _values_[0] = ea.STP_TEMPO_ALARME_HH.Value;
      if (ea.STP_TEMPO_ALARME_H.HasValue) _values_[1] = ea.STP_TEMPO_ALARME_H.Value;
      if (ea.STP_TEMPO_ALARME_L.HasValue) _values_[2] = ea.STP_TEMPO_ALARME_L.Value;
      if (ea.STP_TEMPO_ALARME_LL.HasValue) _values_[3] = ea.STP_TEMPO_ALARME_LL.Value;
      if (ea.STP_ALARME_HH.HasValue) _values_[4] = ea.STP_ALARME_HH.Value;
      if (ea.STP_ALARME_H.HasValue) _values_[5] = ea.STP_ALARME_H.Value;
      if (ea.STP_ALARME_L.HasValue) _values_[6] = ea.STP_ALARME_L.Value;
      if (ea.STP_ALARME_LL.HasValue) _values_[7] = ea.STP_ALARME_LL.Value;
      if (ea.CMD_HABILITA_ALARME_HH.HasValue) _values_[8] = ea.CMD_HABILITA_ALARME_HH.Value;
      if (ea.CMD_HABILITA_ALARME_H.HasValue) _values_[9] = ea.CMD_HABILITA_ALARME_H.Value;
      if (ea.CMD_HABILITA_ALARME_L.HasValue) _values_[10] = ea.CMD_HABILITA_ALARME_L.Value;
      if (ea.CMD_HABILITA_ALARME_LL.HasValue) _values_[11] = ea.CMD_HABILITA_ALARME_LL.Value;
      if (ea.STP_RANGE_MAXIMO.HasValue) _values_[12] = ea.STP_RANGE_MAXIMO.Value;
      if (ea.STP_RANGE_MINIMO.HasValue) _values_[13] = ea.STP_RANGE_MINIMO.Value;
      if (ea.CMD_HABILITA_SENSOR.HasValue) _values_[14] = ea.CMD_HABILITA_SENSOR.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_E_ATUALIZA_SETPOINTS(System.UInt16 STP_TEMPO_ALARME_HH, bool ignore_STP_TEMPO_ALARME_HH, System.UInt16 STP_TEMPO_ALARME_H, bool ignore_STP_TEMPO_ALARME_H, System.UInt16 STP_TEMPO_ALARME_L, bool ignore_STP_TEMPO_ALARME_L, System.UInt16 STP_TEMPO_ALARME_LL, bool ignore_STP_TEMPO_ALARME_LL, System.Single STP_ALARME_HH, bool ignore_STP_ALARME_HH, System.Single STP_ALARME_H, bool ignore_STP_ALARME_H, System.Single STP_ALARME_L, bool ignore_STP_ALARME_L, System.Single STP_ALARME_LL, bool ignore_STP_ALARME_LL, System.Boolean CMD_HABILITA_ALARME_HH, bool ignore_CMD_HABILITA_ALARME_HH, System.Boolean CMD_HABILITA_ALARME_H, bool ignore_CMD_HABILITA_ALARME_H, System.Boolean CMD_HABILITA_ALARME_L, bool ignore_CMD_HABILITA_ALARME_L, System.Boolean CMD_HABILITA_ALARME_LL, bool ignore_CMD_HABILITA_ALARME_LL, System.Single STP_RANGE_MAXIMO, bool ignore_STP_RANGE_MAXIMO, System.Single STP_RANGE_MINIMO, bool ignore_STP_RANGE_MINIMO, System.Boolean CMD_HABILITA_SENSOR, bool ignore_CMD_HABILITA_SENSOR)
    {
      object[] _values_ = new object[15];
      if (!ignore_STP_TEMPO_ALARME_HH) _values_[0] = STP_TEMPO_ALARME_HH;
      if (!ignore_STP_TEMPO_ALARME_H) _values_[1] = STP_TEMPO_ALARME_H;
      if (!ignore_STP_TEMPO_ALARME_L) _values_[2] = STP_TEMPO_ALARME_L;
      if (!ignore_STP_TEMPO_ALARME_LL) _values_[3] = STP_TEMPO_ALARME_LL;
      if (!ignore_STP_ALARME_HH) _values_[4] = STP_ALARME_HH;
      if (!ignore_STP_ALARME_H) _values_[5] = STP_ALARME_H;
      if (!ignore_STP_ALARME_L) _values_[6] = STP_ALARME_L;
      if (!ignore_STP_ALARME_LL) _values_[7] = STP_ALARME_LL;
      if (!ignore_CMD_HABILITA_ALARME_HH) _values_[8] = CMD_HABILITA_ALARME_HH;
      if (!ignore_CMD_HABILITA_ALARME_H) _values_[9] = CMD_HABILITA_ALARME_H;
      if (!ignore_CMD_HABILITA_ALARME_L) _values_[10] = CMD_HABILITA_ALARME_L;
      if (!ignore_CMD_HABILITA_ALARME_LL) _values_[11] = CMD_HABILITA_ALARME_LL;
      if (!ignore_STP_RANGE_MAXIMO) _values_[12] = STP_RANGE_MAXIMO;
      if (!ignore_STP_RANGE_MINIMO) _values_[13] = STP_RANGE_MINIMO;
      if (!ignore_CMD_HABILITA_SENSOR) _values_[14] = CMD_HABILITA_SENSOR;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_E_RESET_FALHA()
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {});
    }
    public bool FireEvent_E_RESET_FALHA(Hidryco.HidrycoLib.Symbols.Sensor_4a20.E_RESET_FALHAEventArgs ea)
    {
      object[] _values_ = new object[0];
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_E_RESET_ALARMES()
    {
      return ((IHMIAccessorOutput)this).FireEvent(2, new object[] {});
    }
    public bool FireEvent_E_RESET_ALARMES(Hidryco.HidrycoLib.Symbols.Sensor_4a20.E_RESET_ALARMESEventArgs ea)
    {
      object[] _values_ = new object[0];
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }

  }
}

namespace Hidryco.HidrycoLib.Faceplates.Sensor_4a20
{
  partial class fpAlarmes
  {

    private event EventHandler<Hidryco.HidrycoLib.Symbols.Sensor_4a20.E_ATUALIZA_STS_SENSOREventArgs> E_ATUALIZA_STS_SENSOR_Fired;

    private event EventHandler<Hidryco.HidrycoLib.Symbols.Sensor_4a20.E_ATUALIZA_ALARMESEventArgs> E_ATUALIZA_ALARMES_Fired;

    protected override void OnEndInit()
    {
      if (E_ATUALIZA_STS_SENSOR_Fired != null)
        AttachEventInput(0);
      if (E_ATUALIZA_ALARMES_Fired != null)
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
              E_ATUALIZA_STS_SENSOR_Fired(this, new Hidryco.HidrycoLib.Symbols.Sensor_4a20.E_ATUALIZA_STS_SENSOREventArgs(channelId, cookie, eventIndex));
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
          if (E_ATUALIZA_ALARMES_Fired != null)
          {
            try
            {
              E_ATUALIZA_ALARMES_Fired(this, new Hidryco.HidrycoLib.Symbols.Sensor_4a20.E_ATUALIZA_ALARMESEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","E_ATUALIZA_ALARMES_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_E_ATUALIZA_SETPOINTS(System.UInt16 STP_TEMPO_ALARME_HH, System.UInt16 STP_TEMPO_ALARME_H, System.UInt16 STP_TEMPO_ALARME_L, System.UInt16 STP_TEMPO_ALARME_LL, System.Single STP_ALARME_HH, System.Single STP_ALARME_H, System.Single STP_ALARME_L, System.Single STP_ALARME_LL, System.Boolean CMD_HABILITA_ALARME_HH, System.Boolean CMD_HABILITA_ALARME_H, System.Boolean CMD_HABILITA_ALARME_L, System.Boolean CMD_HABILITA_ALARME_LL, System.Single STP_RANGE_MAXIMO, System.Single STP_RANGE_MINIMO, System.Boolean CMD_HABILITA_SENSOR)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {STP_TEMPO_ALARME_HH, STP_TEMPO_ALARME_H, STP_TEMPO_ALARME_L, STP_TEMPO_ALARME_LL, STP_ALARME_HH, STP_ALARME_H, STP_ALARME_L, STP_ALARME_LL, CMD_HABILITA_ALARME_HH, CMD_HABILITA_ALARME_H, CMD_HABILITA_ALARME_L, CMD_HABILITA_ALARME_LL, STP_RANGE_MAXIMO, STP_RANGE_MINIMO, CMD_HABILITA_SENSOR});
    }
    public bool FireEvent_E_ATUALIZA_SETPOINTS(Hidryco.HidrycoLib.Symbols.Sensor_4a20.E_ATUALIZA_SETPOINTSEventArgs ea)
    {
      object[] _values_ = new object[15];
      if (ea.STP_TEMPO_ALARME_HH.HasValue) _values_[0] = ea.STP_TEMPO_ALARME_HH.Value;
      if (ea.STP_TEMPO_ALARME_H.HasValue) _values_[1] = ea.STP_TEMPO_ALARME_H.Value;
      if (ea.STP_TEMPO_ALARME_L.HasValue) _values_[2] = ea.STP_TEMPO_ALARME_L.Value;
      if (ea.STP_TEMPO_ALARME_LL.HasValue) _values_[3] = ea.STP_TEMPO_ALARME_LL.Value;
      if (ea.STP_ALARME_HH.HasValue) _values_[4] = ea.STP_ALARME_HH.Value;
      if (ea.STP_ALARME_H.HasValue) _values_[5] = ea.STP_ALARME_H.Value;
      if (ea.STP_ALARME_L.HasValue) _values_[6] = ea.STP_ALARME_L.Value;
      if (ea.STP_ALARME_LL.HasValue) _values_[7] = ea.STP_ALARME_LL.Value;
      if (ea.CMD_HABILITA_ALARME_HH.HasValue) _values_[8] = ea.CMD_HABILITA_ALARME_HH.Value;
      if (ea.CMD_HABILITA_ALARME_H.HasValue) _values_[9] = ea.CMD_HABILITA_ALARME_H.Value;
      if (ea.CMD_HABILITA_ALARME_L.HasValue) _values_[10] = ea.CMD_HABILITA_ALARME_L.Value;
      if (ea.CMD_HABILITA_ALARME_LL.HasValue) _values_[11] = ea.CMD_HABILITA_ALARME_LL.Value;
      if (ea.STP_RANGE_MAXIMO.HasValue) _values_[12] = ea.STP_RANGE_MAXIMO.Value;
      if (ea.STP_RANGE_MINIMO.HasValue) _values_[13] = ea.STP_RANGE_MINIMO.Value;
      if (ea.CMD_HABILITA_SENSOR.HasValue) _values_[14] = ea.CMD_HABILITA_SENSOR.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_E_ATUALIZA_SETPOINTS(System.UInt16 STP_TEMPO_ALARME_HH, bool ignore_STP_TEMPO_ALARME_HH, System.UInt16 STP_TEMPO_ALARME_H, bool ignore_STP_TEMPO_ALARME_H, System.UInt16 STP_TEMPO_ALARME_L, bool ignore_STP_TEMPO_ALARME_L, System.UInt16 STP_TEMPO_ALARME_LL, bool ignore_STP_TEMPO_ALARME_LL, System.Single STP_ALARME_HH, bool ignore_STP_ALARME_HH, System.Single STP_ALARME_H, bool ignore_STP_ALARME_H, System.Single STP_ALARME_L, bool ignore_STP_ALARME_L, System.Single STP_ALARME_LL, bool ignore_STP_ALARME_LL, System.Boolean CMD_HABILITA_ALARME_HH, bool ignore_CMD_HABILITA_ALARME_HH, System.Boolean CMD_HABILITA_ALARME_H, bool ignore_CMD_HABILITA_ALARME_H, System.Boolean CMD_HABILITA_ALARME_L, bool ignore_CMD_HABILITA_ALARME_L, System.Boolean CMD_HABILITA_ALARME_LL, bool ignore_CMD_HABILITA_ALARME_LL, System.Single STP_RANGE_MAXIMO, bool ignore_STP_RANGE_MAXIMO, System.Single STP_RANGE_MINIMO, bool ignore_STP_RANGE_MINIMO, System.Boolean CMD_HABILITA_SENSOR, bool ignore_CMD_HABILITA_SENSOR)
    {
      object[] _values_ = new object[15];
      if (!ignore_STP_TEMPO_ALARME_HH) _values_[0] = STP_TEMPO_ALARME_HH;
      if (!ignore_STP_TEMPO_ALARME_H) _values_[1] = STP_TEMPO_ALARME_H;
      if (!ignore_STP_TEMPO_ALARME_L) _values_[2] = STP_TEMPO_ALARME_L;
      if (!ignore_STP_TEMPO_ALARME_LL) _values_[3] = STP_TEMPO_ALARME_LL;
      if (!ignore_STP_ALARME_HH) _values_[4] = STP_ALARME_HH;
      if (!ignore_STP_ALARME_H) _values_[5] = STP_ALARME_H;
      if (!ignore_STP_ALARME_L) _values_[6] = STP_ALARME_L;
      if (!ignore_STP_ALARME_LL) _values_[7] = STP_ALARME_LL;
      if (!ignore_CMD_HABILITA_ALARME_HH) _values_[8] = CMD_HABILITA_ALARME_HH;
      if (!ignore_CMD_HABILITA_ALARME_H) _values_[9] = CMD_HABILITA_ALARME_H;
      if (!ignore_CMD_HABILITA_ALARME_L) _values_[10] = CMD_HABILITA_ALARME_L;
      if (!ignore_CMD_HABILITA_ALARME_LL) _values_[11] = CMD_HABILITA_ALARME_LL;
      if (!ignore_STP_RANGE_MAXIMO) _values_[12] = STP_RANGE_MAXIMO;
      if (!ignore_STP_RANGE_MINIMO) _values_[13] = STP_RANGE_MINIMO;
      if (!ignore_CMD_HABILITA_SENSOR) _values_[14] = CMD_HABILITA_SENSOR;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_E_RESET_FALHA()
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {});
    }
    public bool FireEvent_E_RESET_FALHA(Hidryco.HidrycoLib.Symbols.Sensor_4a20.E_RESET_FALHAEventArgs ea)
    {
      object[] _values_ = new object[0];
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_E_RESET_ALARMES()
    {
      return ((IHMIAccessorOutput)this).FireEvent(2, new object[] {});
    }
    public bool FireEvent_E_RESET_ALARMES(Hidryco.HidrycoLib.Symbols.Sensor_4a20.E_RESET_ALARMESEventArgs ea)
    {
      object[] _values_ = new object[0];
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }

  }
}

namespace Hidryco.HidrycoLib.Faceplates.Sensor_4a20
{
  partial class fpAjustes
  {

    private event EventHandler<Hidryco.HidrycoLib.Symbols.Sensor_4a20.E_ATUALIZA_STS_SENSOREventArgs> E_ATUALIZA_STS_SENSOR_Fired;

    private event EventHandler<Hidryco.HidrycoLib.Symbols.Sensor_4a20.E_ATUALIZA_ALARMESEventArgs> E_ATUALIZA_ALARMES_Fired;

    protected override void OnEndInit()
    {
      if (E_ATUALIZA_STS_SENSOR_Fired != null)
        AttachEventInput(0);
      if (E_ATUALIZA_ALARMES_Fired != null)
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
              E_ATUALIZA_STS_SENSOR_Fired(this, new Hidryco.HidrycoLib.Symbols.Sensor_4a20.E_ATUALIZA_STS_SENSOREventArgs(channelId, cookie, eventIndex));
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
          if (E_ATUALIZA_ALARMES_Fired != null)
          {
            try
            {
              E_ATUALIZA_ALARMES_Fired(this, new Hidryco.HidrycoLib.Symbols.Sensor_4a20.E_ATUALIZA_ALARMESEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","E_ATUALIZA_ALARMES_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_E_ATUALIZA_SETPOINTS(System.UInt16 STP_TEMPO_ALARME_HH, System.UInt16 STP_TEMPO_ALARME_H, System.UInt16 STP_TEMPO_ALARME_L, System.UInt16 STP_TEMPO_ALARME_LL, System.Single STP_ALARME_HH, System.Single STP_ALARME_H, System.Single STP_ALARME_L, System.Single STP_ALARME_LL, System.Boolean CMD_HABILITA_ALARME_HH, System.Boolean CMD_HABILITA_ALARME_H, System.Boolean CMD_HABILITA_ALARME_L, System.Boolean CMD_HABILITA_ALARME_LL, System.Single STP_RANGE_MAXIMO, System.Single STP_RANGE_MINIMO, System.Boolean CMD_HABILITA_SENSOR)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {STP_TEMPO_ALARME_HH, STP_TEMPO_ALARME_H, STP_TEMPO_ALARME_L, STP_TEMPO_ALARME_LL, STP_ALARME_HH, STP_ALARME_H, STP_ALARME_L, STP_ALARME_LL, CMD_HABILITA_ALARME_HH, CMD_HABILITA_ALARME_H, CMD_HABILITA_ALARME_L, CMD_HABILITA_ALARME_LL, STP_RANGE_MAXIMO, STP_RANGE_MINIMO, CMD_HABILITA_SENSOR});
    }
    public bool FireEvent_E_ATUALIZA_SETPOINTS(Hidryco.HidrycoLib.Symbols.Sensor_4a20.E_ATUALIZA_SETPOINTSEventArgs ea)
    {
      object[] _values_ = new object[15];
      if (ea.STP_TEMPO_ALARME_HH.HasValue) _values_[0] = ea.STP_TEMPO_ALARME_HH.Value;
      if (ea.STP_TEMPO_ALARME_H.HasValue) _values_[1] = ea.STP_TEMPO_ALARME_H.Value;
      if (ea.STP_TEMPO_ALARME_L.HasValue) _values_[2] = ea.STP_TEMPO_ALARME_L.Value;
      if (ea.STP_TEMPO_ALARME_LL.HasValue) _values_[3] = ea.STP_TEMPO_ALARME_LL.Value;
      if (ea.STP_ALARME_HH.HasValue) _values_[4] = ea.STP_ALARME_HH.Value;
      if (ea.STP_ALARME_H.HasValue) _values_[5] = ea.STP_ALARME_H.Value;
      if (ea.STP_ALARME_L.HasValue) _values_[6] = ea.STP_ALARME_L.Value;
      if (ea.STP_ALARME_LL.HasValue) _values_[7] = ea.STP_ALARME_LL.Value;
      if (ea.CMD_HABILITA_ALARME_HH.HasValue) _values_[8] = ea.CMD_HABILITA_ALARME_HH.Value;
      if (ea.CMD_HABILITA_ALARME_H.HasValue) _values_[9] = ea.CMD_HABILITA_ALARME_H.Value;
      if (ea.CMD_HABILITA_ALARME_L.HasValue) _values_[10] = ea.CMD_HABILITA_ALARME_L.Value;
      if (ea.CMD_HABILITA_ALARME_LL.HasValue) _values_[11] = ea.CMD_HABILITA_ALARME_LL.Value;
      if (ea.STP_RANGE_MAXIMO.HasValue) _values_[12] = ea.STP_RANGE_MAXIMO.Value;
      if (ea.STP_RANGE_MINIMO.HasValue) _values_[13] = ea.STP_RANGE_MINIMO.Value;
      if (ea.CMD_HABILITA_SENSOR.HasValue) _values_[14] = ea.CMD_HABILITA_SENSOR.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_E_ATUALIZA_SETPOINTS(System.UInt16 STP_TEMPO_ALARME_HH, bool ignore_STP_TEMPO_ALARME_HH, System.UInt16 STP_TEMPO_ALARME_H, bool ignore_STP_TEMPO_ALARME_H, System.UInt16 STP_TEMPO_ALARME_L, bool ignore_STP_TEMPO_ALARME_L, System.UInt16 STP_TEMPO_ALARME_LL, bool ignore_STP_TEMPO_ALARME_LL, System.Single STP_ALARME_HH, bool ignore_STP_ALARME_HH, System.Single STP_ALARME_H, bool ignore_STP_ALARME_H, System.Single STP_ALARME_L, bool ignore_STP_ALARME_L, System.Single STP_ALARME_LL, bool ignore_STP_ALARME_LL, System.Boolean CMD_HABILITA_ALARME_HH, bool ignore_CMD_HABILITA_ALARME_HH, System.Boolean CMD_HABILITA_ALARME_H, bool ignore_CMD_HABILITA_ALARME_H, System.Boolean CMD_HABILITA_ALARME_L, bool ignore_CMD_HABILITA_ALARME_L, System.Boolean CMD_HABILITA_ALARME_LL, bool ignore_CMD_HABILITA_ALARME_LL, System.Single STP_RANGE_MAXIMO, bool ignore_STP_RANGE_MAXIMO, System.Single STP_RANGE_MINIMO, bool ignore_STP_RANGE_MINIMO, System.Boolean CMD_HABILITA_SENSOR, bool ignore_CMD_HABILITA_SENSOR)
    {
      object[] _values_ = new object[15];
      if (!ignore_STP_TEMPO_ALARME_HH) _values_[0] = STP_TEMPO_ALARME_HH;
      if (!ignore_STP_TEMPO_ALARME_H) _values_[1] = STP_TEMPO_ALARME_H;
      if (!ignore_STP_TEMPO_ALARME_L) _values_[2] = STP_TEMPO_ALARME_L;
      if (!ignore_STP_TEMPO_ALARME_LL) _values_[3] = STP_TEMPO_ALARME_LL;
      if (!ignore_STP_ALARME_HH) _values_[4] = STP_ALARME_HH;
      if (!ignore_STP_ALARME_H) _values_[5] = STP_ALARME_H;
      if (!ignore_STP_ALARME_L) _values_[6] = STP_ALARME_L;
      if (!ignore_STP_ALARME_LL) _values_[7] = STP_ALARME_LL;
      if (!ignore_CMD_HABILITA_ALARME_HH) _values_[8] = CMD_HABILITA_ALARME_HH;
      if (!ignore_CMD_HABILITA_ALARME_H) _values_[9] = CMD_HABILITA_ALARME_H;
      if (!ignore_CMD_HABILITA_ALARME_L) _values_[10] = CMD_HABILITA_ALARME_L;
      if (!ignore_CMD_HABILITA_ALARME_LL) _values_[11] = CMD_HABILITA_ALARME_LL;
      if (!ignore_STP_RANGE_MAXIMO) _values_[12] = STP_RANGE_MAXIMO;
      if (!ignore_STP_RANGE_MINIMO) _values_[13] = STP_RANGE_MINIMO;
      if (!ignore_CMD_HABILITA_SENSOR) _values_[14] = CMD_HABILITA_SENSOR;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_E_RESET_FALHA()
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {});
    }
    public bool FireEvent_E_RESET_FALHA(Hidryco.HidrycoLib.Symbols.Sensor_4a20.E_RESET_FALHAEventArgs ea)
    {
      object[] _values_ = new object[0];
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_E_RESET_ALARMES()
    {
      return ((IHMIAccessorOutput)this).FireEvent(2, new object[] {});
    }
    public bool FireEvent_E_RESET_ALARMES(Hidryco.HidrycoLib.Symbols.Sensor_4a20.E_RESET_ALARMESEventArgs ea)
    {
      object[] _values_ = new object[0];
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }

  }
}

namespace Hidryco.HidrycoLib.Faceplates.Sensor_4a20
{
  partial class fpGrafico
  {

    private event EventHandler<Hidryco.HidrycoLib.Symbols.Sensor_4a20.E_ATUALIZA_STS_SENSOREventArgs> E_ATUALIZA_STS_SENSOR_Fired;

    private event EventHandler<Hidryco.HidrycoLib.Symbols.Sensor_4a20.E_ATUALIZA_ALARMESEventArgs> E_ATUALIZA_ALARMES_Fired;

    protected override void OnEndInit()
    {
      if (E_ATUALIZA_STS_SENSOR_Fired != null)
        AttachEventInput(0);
      if (E_ATUALIZA_ALARMES_Fired != null)
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
              E_ATUALIZA_STS_SENSOR_Fired(this, new Hidryco.HidrycoLib.Symbols.Sensor_4a20.E_ATUALIZA_STS_SENSOREventArgs(channelId, cookie, eventIndex));
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
          if (E_ATUALIZA_ALARMES_Fired != null)
          {
            try
            {
              E_ATUALIZA_ALARMES_Fired(this, new Hidryco.HidrycoLib.Symbols.Sensor_4a20.E_ATUALIZA_ALARMESEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","E_ATUALIZA_ALARMES_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_E_ATUALIZA_SETPOINTS(System.UInt16 STP_TEMPO_ALARME_HH, System.UInt16 STP_TEMPO_ALARME_H, System.UInt16 STP_TEMPO_ALARME_L, System.UInt16 STP_TEMPO_ALARME_LL, System.Single STP_ALARME_HH, System.Single STP_ALARME_H, System.Single STP_ALARME_L, System.Single STP_ALARME_LL, System.Boolean CMD_HABILITA_ALARME_HH, System.Boolean CMD_HABILITA_ALARME_H, System.Boolean CMD_HABILITA_ALARME_L, System.Boolean CMD_HABILITA_ALARME_LL, System.Single STP_RANGE_MAXIMO, System.Single STP_RANGE_MINIMO, System.Boolean CMD_HABILITA_SENSOR)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {STP_TEMPO_ALARME_HH, STP_TEMPO_ALARME_H, STP_TEMPO_ALARME_L, STP_TEMPO_ALARME_LL, STP_ALARME_HH, STP_ALARME_H, STP_ALARME_L, STP_ALARME_LL, CMD_HABILITA_ALARME_HH, CMD_HABILITA_ALARME_H, CMD_HABILITA_ALARME_L, CMD_HABILITA_ALARME_LL, STP_RANGE_MAXIMO, STP_RANGE_MINIMO, CMD_HABILITA_SENSOR});
    }
    public bool FireEvent_E_ATUALIZA_SETPOINTS(Hidryco.HidrycoLib.Symbols.Sensor_4a20.E_ATUALIZA_SETPOINTSEventArgs ea)
    {
      object[] _values_ = new object[15];
      if (ea.STP_TEMPO_ALARME_HH.HasValue) _values_[0] = ea.STP_TEMPO_ALARME_HH.Value;
      if (ea.STP_TEMPO_ALARME_H.HasValue) _values_[1] = ea.STP_TEMPO_ALARME_H.Value;
      if (ea.STP_TEMPO_ALARME_L.HasValue) _values_[2] = ea.STP_TEMPO_ALARME_L.Value;
      if (ea.STP_TEMPO_ALARME_LL.HasValue) _values_[3] = ea.STP_TEMPO_ALARME_LL.Value;
      if (ea.STP_ALARME_HH.HasValue) _values_[4] = ea.STP_ALARME_HH.Value;
      if (ea.STP_ALARME_H.HasValue) _values_[5] = ea.STP_ALARME_H.Value;
      if (ea.STP_ALARME_L.HasValue) _values_[6] = ea.STP_ALARME_L.Value;
      if (ea.STP_ALARME_LL.HasValue) _values_[7] = ea.STP_ALARME_LL.Value;
      if (ea.CMD_HABILITA_ALARME_HH.HasValue) _values_[8] = ea.CMD_HABILITA_ALARME_HH.Value;
      if (ea.CMD_HABILITA_ALARME_H.HasValue) _values_[9] = ea.CMD_HABILITA_ALARME_H.Value;
      if (ea.CMD_HABILITA_ALARME_L.HasValue) _values_[10] = ea.CMD_HABILITA_ALARME_L.Value;
      if (ea.CMD_HABILITA_ALARME_LL.HasValue) _values_[11] = ea.CMD_HABILITA_ALARME_LL.Value;
      if (ea.STP_RANGE_MAXIMO.HasValue) _values_[12] = ea.STP_RANGE_MAXIMO.Value;
      if (ea.STP_RANGE_MINIMO.HasValue) _values_[13] = ea.STP_RANGE_MINIMO.Value;
      if (ea.CMD_HABILITA_SENSOR.HasValue) _values_[14] = ea.CMD_HABILITA_SENSOR.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_E_ATUALIZA_SETPOINTS(System.UInt16 STP_TEMPO_ALARME_HH, bool ignore_STP_TEMPO_ALARME_HH, System.UInt16 STP_TEMPO_ALARME_H, bool ignore_STP_TEMPO_ALARME_H, System.UInt16 STP_TEMPO_ALARME_L, bool ignore_STP_TEMPO_ALARME_L, System.UInt16 STP_TEMPO_ALARME_LL, bool ignore_STP_TEMPO_ALARME_LL, System.Single STP_ALARME_HH, bool ignore_STP_ALARME_HH, System.Single STP_ALARME_H, bool ignore_STP_ALARME_H, System.Single STP_ALARME_L, bool ignore_STP_ALARME_L, System.Single STP_ALARME_LL, bool ignore_STP_ALARME_LL, System.Boolean CMD_HABILITA_ALARME_HH, bool ignore_CMD_HABILITA_ALARME_HH, System.Boolean CMD_HABILITA_ALARME_H, bool ignore_CMD_HABILITA_ALARME_H, System.Boolean CMD_HABILITA_ALARME_L, bool ignore_CMD_HABILITA_ALARME_L, System.Boolean CMD_HABILITA_ALARME_LL, bool ignore_CMD_HABILITA_ALARME_LL, System.Single STP_RANGE_MAXIMO, bool ignore_STP_RANGE_MAXIMO, System.Single STP_RANGE_MINIMO, bool ignore_STP_RANGE_MINIMO, System.Boolean CMD_HABILITA_SENSOR, bool ignore_CMD_HABILITA_SENSOR)
    {
      object[] _values_ = new object[15];
      if (!ignore_STP_TEMPO_ALARME_HH) _values_[0] = STP_TEMPO_ALARME_HH;
      if (!ignore_STP_TEMPO_ALARME_H) _values_[1] = STP_TEMPO_ALARME_H;
      if (!ignore_STP_TEMPO_ALARME_L) _values_[2] = STP_TEMPO_ALARME_L;
      if (!ignore_STP_TEMPO_ALARME_LL) _values_[3] = STP_TEMPO_ALARME_LL;
      if (!ignore_STP_ALARME_HH) _values_[4] = STP_ALARME_HH;
      if (!ignore_STP_ALARME_H) _values_[5] = STP_ALARME_H;
      if (!ignore_STP_ALARME_L) _values_[6] = STP_ALARME_L;
      if (!ignore_STP_ALARME_LL) _values_[7] = STP_ALARME_LL;
      if (!ignore_CMD_HABILITA_ALARME_HH) _values_[8] = CMD_HABILITA_ALARME_HH;
      if (!ignore_CMD_HABILITA_ALARME_H) _values_[9] = CMD_HABILITA_ALARME_H;
      if (!ignore_CMD_HABILITA_ALARME_L) _values_[10] = CMD_HABILITA_ALARME_L;
      if (!ignore_CMD_HABILITA_ALARME_LL) _values_[11] = CMD_HABILITA_ALARME_LL;
      if (!ignore_STP_RANGE_MAXIMO) _values_[12] = STP_RANGE_MAXIMO;
      if (!ignore_STP_RANGE_MINIMO) _values_[13] = STP_RANGE_MINIMO;
      if (!ignore_CMD_HABILITA_SENSOR) _values_[14] = CMD_HABILITA_SENSOR;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_E_RESET_FALHA()
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {});
    }
    public bool FireEvent_E_RESET_FALHA(Hidryco.HidrycoLib.Symbols.Sensor_4a20.E_RESET_FALHAEventArgs ea)
    {
      object[] _values_ = new object[0];
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_E_RESET_ALARMES()
    {
      return ((IHMIAccessorOutput)this).FireEvent(2, new object[] {});
    }
    public bool FireEvent_E_RESET_ALARMES(Hidryco.HidrycoLib.Symbols.Sensor_4a20.E_RESET_ALARMESEventArgs ea)
    {
      object[] _values_ = new object[0];
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }

  }
}
#endregion #Sensor_4a20_HMI;

#endregion Definitions;
