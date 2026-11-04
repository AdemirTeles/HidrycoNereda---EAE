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
#region #Gradeamento_Inovaisa_HMI;

namespace Hidryco.HidrycoLib.Symbols.Gradeamento_Inovaisa
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
    public bool Get_STS_ALARME(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,0, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_ALARME
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,0, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_EMERGENCIA(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,1, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_EMERGENCIA
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,1, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_COMUNICACAO_OK(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,2, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_COMUNICACAO_OK
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,2, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_FALHA_COMUNICACAO(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,3, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_FALHA_COMUNICACAO
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,3, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_ALARME_ACIONADO(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,4, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_ALARME_ACIONADO
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,4, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_CICLO_LIGADO(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,5, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_CICLO_LIGADO
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,5, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_FALHA_MOTOR(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,6, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_FALHA_MOTOR
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,6, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_FUNCIONANDO(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,7, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_FUNCIONANDO
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,7, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_ALM_COMUNICACAO_EST(ref System.Byte value)
    {
      if (accessorService == null)
        return false;
      byte var = 0;
      bool ret = accessorService.GetByteValue(channelId, cookie, eventIndex, true,8, ref var);
      if (ret) value = (System.Byte) var;
      return ret;
    }

    public System.Byte? STS_ALM_COMUNICACAO_EST
    { get {
      if (accessorService == null)
        return null;
      byte var = 0;
      bool ret = accessorService.GetByteValue(channelId, cookie, eventIndex, true,8, ref var);
      if (!ret) return null;
      return (System.Byte) var;
    }  }

    public bool Get_STS_ALM_EMERGENCIA_EST(ref System.Byte value)
    {
      if (accessorService == null)
        return false;
      byte var = 0;
      bool ret = accessorService.GetByteValue(channelId, cookie, eventIndex, true,9, ref var);
      if (ret) value = (System.Byte) var;
      return ret;
    }

    public System.Byte? STS_ALM_EMERGENCIA_EST
    { get {
      if (accessorService == null)
        return null;
      byte var = 0;
      bool ret = accessorService.GetByteValue(channelId, cookie, eventIndex, true,9, ref var);
      if (!ret) return null;
      return (System.Byte) var;
    }  }

    public bool Get_STS_ALM_PAINEL_EST(ref System.Byte value)
    {
      if (accessorService == null)
        return false;
      byte var = 0;
      bool ret = accessorService.GetByteValue(channelId, cookie, eventIndex, true,10, ref var);
      if (ret) value = (System.Byte) var;
      return ret;
    }

    public System.Byte? STS_ALM_PAINEL_EST
    { get {
      if (accessorService == null)
        return null;
      byte var = 0;
      bool ret = accessorService.GetByteValue(channelId, cookie, eventIndex, true,10, ref var);
      if (!ret) return null;
      return (System.Byte) var;
    }  }


    public bool Get_STS_ANIMACAO_GERADOR(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,11, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? STS_ANIMACAO_GERADOR
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,11, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }

  }

}

namespace Hidryco.HidrycoLib.Symbols.Gradeamento_Inovaisa
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

namespace Hidryco.HidrycoLib.Symbols.Gradeamento_Inovaisa
{
  partial class sDefault
  {

    private event EventHandler<Hidryco.HidrycoLib.Symbols.Gradeamento_Inovaisa.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    private event EventHandler<Hidryco.HidrycoLib.Symbols.Gradeamento_Inovaisa.REQEventArgs> REQ_Fired;

    protected override void OnEndInit()
    {
      if (LOAD_PERS_DATA_Fired != null)
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
          if (LOAD_PERS_DATA_Fired != null)
          {
            try
            {
              LOAD_PERS_DATA_Fired(this, new Hidryco.HidrycoLib.Symbols.Gradeamento_Inovaisa.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
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
          if (REQ_Fired != null)
          {
            try
            {
              REQ_Fired(this, new Hidryco.HidrycoLib.Symbols.Gradeamento_Inovaisa.REQEventArgs(channelId, cookie, eventIndex));
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
    public bool FireEvent_E_RESET_FALHAS_PROCESSO(System.Boolean cmdResetFalhas)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {cmdResetFalhas});
    }
    public bool FireEvent_E_RESET_FALHAS_PROCESSO(Hidryco.HidrycoLib.Symbols.Gradeamento_Inovaisa.E_RESET_FALHAS_PROCESSOEventArgs ea)
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

namespace Hidryco.HidrycoLib.Faceplates.Gradeamento_Inovaisa
{
  partial class fpDefault
  {

    private event EventHandler<Hidryco.HidrycoLib.Symbols.Gradeamento_Inovaisa.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    private event EventHandler<Hidryco.HidrycoLib.Symbols.Gradeamento_Inovaisa.REQEventArgs> REQ_Fired;

    protected override void OnEndInit()
    {
      if (LOAD_PERS_DATA_Fired != null)
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
          if (LOAD_PERS_DATA_Fired != null)
          {
            try
            {
              LOAD_PERS_DATA_Fired(this, new Hidryco.HidrycoLib.Symbols.Gradeamento_Inovaisa.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
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
          if (REQ_Fired != null)
          {
            try
            {
              REQ_Fired(this, new Hidryco.HidrycoLib.Symbols.Gradeamento_Inovaisa.REQEventArgs(channelId, cookie, eventIndex));
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
    public bool FireEvent_E_RESET_FALHAS_PROCESSO(System.Boolean cmdResetFalhas)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {cmdResetFalhas});
    }
    public bool FireEvent_E_RESET_FALHAS_PROCESSO(Hidryco.HidrycoLib.Symbols.Gradeamento_Inovaisa.E_RESET_FALHAS_PROCESSOEventArgs ea)
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

namespace Hidryco.HidrycoLib.Faceplates.Gradeamento_Inovaisa
{
  partial class fpSkid
  {

    private event EventHandler<Hidryco.HidrycoLib.Symbols.Gradeamento_Inovaisa.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    private event EventHandler<Hidryco.HidrycoLib.Symbols.Gradeamento_Inovaisa.REQEventArgs> REQ_Fired;

    protected override void OnEndInit()
    {
      if (LOAD_PERS_DATA_Fired != null)
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
          if (LOAD_PERS_DATA_Fired != null)
          {
            try
            {
              LOAD_PERS_DATA_Fired(this, new Hidryco.HidrycoLib.Symbols.Gradeamento_Inovaisa.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
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
          if (REQ_Fired != null)
          {
            try
            {
              REQ_Fired(this, new Hidryco.HidrycoLib.Symbols.Gradeamento_Inovaisa.REQEventArgs(channelId, cookie, eventIndex));
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
    public bool FireEvent_E_RESET_FALHAS_PROCESSO(System.Boolean cmdResetFalhas)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {cmdResetFalhas});
    }
    public bool FireEvent_E_RESET_FALHAS_PROCESSO(Hidryco.HidrycoLib.Symbols.Gradeamento_Inovaisa.E_RESET_FALHAS_PROCESSOEventArgs ea)
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

#endregion #Gradeamento_Inovaisa_HMI;

#endregion Definitions;
