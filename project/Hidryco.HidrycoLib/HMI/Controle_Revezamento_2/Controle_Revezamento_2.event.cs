/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 10/19/2026
 * Time: 10:00 AM
 * 
 */
using System;
using NxtControl.GuiFramework;
using NxtControl.Services;

#region Definitions;
#region #Controle_Revezamento_2_HMI;

namespace Hidryco.HidrycoLib.Symbols.Controle_Revezamento_2
{

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
    public bool Get_STS_RESTANTE_HOR(ref System.UInt16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,0, ref var);
      if (ret) value = (System.UInt16) var;
      return ret;
    }

    public System.UInt16? STS_RESTANTE_HOR
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,0, ref var);
      if (!ret) return null;
      return (System.UInt16) var;
    }  }

    public bool Get_STS_RESTANTE_MIN(ref System.UInt16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,1, ref var);
      if (ret) value = (System.UInt16) var;
      return ret;
    }

    public System.UInt16? STS_RESTANTE_MIN
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,1, ref var);
      if (!ret) return null;
      return (System.UInt16) var;
    }  }

    public bool Get_STS_RESTANTE_SEG(ref System.UInt16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,2, ref var);
      if (ret) value = (System.UInt16) var;
      return ret;
    }

    public System.UInt16? STS_RESTANTE_SEG
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

namespace Hidryco.HidrycoLib.Symbols.Controle_Revezamento_2
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
    private System.UInt16? STP_TEMPO_B1_field = null;
    public System.UInt16? STP_TEMPO_B1
    {
       get { return STP_TEMPO_B1_field; }
       set { STP_TEMPO_B1_field = value; }
    }
    private System.UInt16? STP_TEMPO_B2_field = null;
    public System.UInt16? STP_TEMPO_B2
    {
       get { return STP_TEMPO_B2_field; }
       set { STP_TEMPO_B2_field = value; }
    }

  }

}

namespace Hidryco.HidrycoLib.Symbols.Controle_Revezamento_2
{
  partial class sAjustes
  {

    private event EventHandler<Hidryco.HidrycoLib.Symbols.Controle_Revezamento_2.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    private event EventHandler<Hidryco.HidrycoLib.Symbols.Controle_Revezamento_2.E_ATUALIZA_TEMPO_RESTANTEEventArgs> E_ATUALIZA_TEMPO_RESTANTE_Fired;

    protected override void OnEndInit()
    {
      if (LOAD_PERS_DATA_Fired != null)
        AttachEventInput(0);
      if (E_ATUALIZA_TEMPO_RESTANTE_Fired != null)
        AttachEventInput(1);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (LOAD_PERS_DATA_Fired != null)
          {
            try
            {
              LOAD_PERS_DATA_Fired(this, new Hidryco.HidrycoLib.Symbols.Controle_Revezamento_2.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","LOAD_PERS_DATA_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 1:
          if (E_ATUALIZA_TEMPO_RESTANTE_Fired != null)
          {
            try
            {
              E_ATUALIZA_TEMPO_RESTANTE_Fired(this, new Hidryco.HidrycoLib.Symbols.Controle_Revezamento_2.E_ATUALIZA_TEMPO_RESTANTEEventArgs(channelId, cookie, eventIndex));
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
    public bool FireEvent_E_ATUALIZA_SETPOINT(System.Boolean CMD_HABILITA, System.UInt16 STP_TEMPO_B1, System.UInt16 STP_TEMPO_B2)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {CMD_HABILITA, STP_TEMPO_B1, STP_TEMPO_B2});
    }
    public bool FireEvent_E_ATUALIZA_SETPOINT(Hidryco.HidrycoLib.Symbols.Controle_Revezamento_2.E_ATUALIZA_SETPOINTEventArgs ea)
    {
      object[] _values_ = new object[3];
      if (ea.CMD_HABILITA.HasValue) _values_[0] = ea.CMD_HABILITA.Value;
      if (ea.STP_TEMPO_B1.HasValue) _values_[1] = ea.STP_TEMPO_B1.Value;
      if (ea.STP_TEMPO_B2.HasValue) _values_[2] = ea.STP_TEMPO_B2.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_E_ATUALIZA_SETPOINT(System.Boolean CMD_HABILITA, bool ignore_CMD_HABILITA, System.UInt16 STP_TEMPO_B1, bool ignore_STP_TEMPO_B1, System.UInt16 STP_TEMPO_B2, bool ignore_STP_TEMPO_B2)
    {
      object[] _values_ = new object[3];
      if (!ignore_CMD_HABILITA) _values_[0] = CMD_HABILITA;
      if (!ignore_STP_TEMPO_B1) _values_[1] = STP_TEMPO_B1;
      if (!ignore_STP_TEMPO_B2) _values_[2] = STP_TEMPO_B2;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }

  }
}

namespace Hidryco.HidrycoLib.Symbols.Controle_Revezamento_2
{
  partial class sStatus
  {

    private event EventHandler<Hidryco.HidrycoLib.Symbols.Controle_Revezamento_2.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    private event EventHandler<Hidryco.HidrycoLib.Symbols.Controle_Revezamento_2.E_ATUALIZA_TEMPO_RESTANTEEventArgs> E_ATUALIZA_TEMPO_RESTANTE_Fired;

    protected override void OnEndInit()
    {
      if (LOAD_PERS_DATA_Fired != null)
        AttachEventInput(0);
      if (E_ATUALIZA_TEMPO_RESTANTE_Fired != null)
        AttachEventInput(1);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (LOAD_PERS_DATA_Fired != null)
          {
            try
            {
              LOAD_PERS_DATA_Fired(this, new Hidryco.HidrycoLib.Symbols.Controle_Revezamento_2.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","LOAD_PERS_DATA_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 1:
          if (E_ATUALIZA_TEMPO_RESTANTE_Fired != null)
          {
            try
            {
              E_ATUALIZA_TEMPO_RESTANTE_Fired(this, new Hidryco.HidrycoLib.Symbols.Controle_Revezamento_2.E_ATUALIZA_TEMPO_RESTANTEEventArgs(channelId, cookie, eventIndex));
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
    public bool FireEvent_E_ATUALIZA_SETPOINT(System.Boolean CMD_HABILITA, System.UInt16 STP_TEMPO_B1, System.UInt16 STP_TEMPO_B2)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {CMD_HABILITA, STP_TEMPO_B1, STP_TEMPO_B2});
    }
    public bool FireEvent_E_ATUALIZA_SETPOINT(Hidryco.HidrycoLib.Symbols.Controle_Revezamento_2.E_ATUALIZA_SETPOINTEventArgs ea)
    {
      object[] _values_ = new object[3];
      if (ea.CMD_HABILITA.HasValue) _values_[0] = ea.CMD_HABILITA.Value;
      if (ea.STP_TEMPO_B1.HasValue) _values_[1] = ea.STP_TEMPO_B1.Value;
      if (ea.STP_TEMPO_B2.HasValue) _values_[2] = ea.STP_TEMPO_B2.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_E_ATUALIZA_SETPOINT(System.Boolean CMD_HABILITA, bool ignore_CMD_HABILITA, System.UInt16 STP_TEMPO_B1, bool ignore_STP_TEMPO_B1, System.UInt16 STP_TEMPO_B2, bool ignore_STP_TEMPO_B2)
    {
      object[] _values_ = new object[3];
      if (!ignore_CMD_HABILITA) _values_[0] = CMD_HABILITA;
      if (!ignore_STP_TEMPO_B1) _values_[1] = STP_TEMPO_B1;
      if (!ignore_STP_TEMPO_B2) _values_[2] = STP_TEMPO_B2;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }

  }
}

#endregion #Controle_Revezamento_2_HMI;

#endregion Definitions;
