/*
 * Created by EcoStruxure Automation Expert.
 * User: SESA713705
 * Date: 8/19/2024
 * Time: 3:34 PM
 * 
 */
using System;
using NxtControl.GuiFramework;
using NxtControl.Services;

#region Definitions;
#region #AtvResetError_HMI;

namespace SE.Nereda.Symbols.AtvResetError
{

  public class REQ_ETAEventArgs : System.EventArgs
  {
    IHMIAccessorService accessorService;
    int channelId;
    int cookie; 
    int eventIndex;

    public REQ_ETAEventArgs(int channelId, int cookie, int eventIndex)
    {
      this.accessorService = (IHMIAccessorService)ServiceProvider.GetService(typeof(IHMIAccessorService));
      this.channelId = channelId;
      this.cookie = cookie;
      this.eventIndex = eventIndex;
    }
    public bool Get_ETA(ref System.UInt16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,0, ref var);
      if (ret) value = (System.UInt16) var;
      return ret;
    }

    public System.UInt16? ETA
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,0, ref var);
      if (!ret) return null;
      return (System.UInt16) var;
    }  }


  }

  public class REQ_NEED_RESETEventArgs : System.EventArgs
  {
    IHMIAccessorService accessorService;
    int channelId;
    int cookie; 
    int eventIndex;

    public REQ_NEED_RESETEventArgs(int channelId, int cookie, int eventIndex)
    {
      this.accessorService = (IHMIAccessorService)ServiceProvider.GetService(typeof(IHMIAccessorService));
      this.channelId = channelId;
      this.cookie = cookie;
      this.eventIndex = eventIndex;
    }
    public bool Get_NeedReset(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,0, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? NeedReset
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,0, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }


  }

}

namespace SE.Nereda.Symbols.AtvResetError
{

  public class RESET_HMIEventArgs : System.EventArgs
  {
    public RESET_HMIEventArgs()
    {
    }
    private System.Boolean? ResetHMI_field = null;
    public System.Boolean? ResetHMI
    {
       get { return ResetHMI_field; }
       set { ResetHMI_field = value; }
    }

  }

}

namespace SE.Nereda.Symbols.AtvResetError
{
  partial class sDefault
  {

    private event EventHandler<SE.Nereda.Symbols.AtvResetError.REQ_ETAEventArgs> REQ_ETA_Fired;

    private event EventHandler<SE.Nereda.Symbols.AtvResetError.REQ_NEED_RESETEventArgs> REQ_NEED_RESET_Fired;

    protected override void OnEndInit()
    {
      if (REQ_ETA_Fired != null)
        AttachEventInput(0);
      if (REQ_NEED_RESET_Fired != null)
        AttachEventInput(1);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (REQ_ETA_Fired != null)
          {
            try
            {
              REQ_ETA_Fired(this, new SE.Nereda.Symbols.AtvResetError.REQ_ETAEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REQ_ETA_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 1:
          if (REQ_NEED_RESET_Fired != null)
          {
            try
            {
              REQ_NEED_RESET_Fired(this, new SE.Nereda.Symbols.AtvResetError.REQ_NEED_RESETEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REQ_NEED_RESET_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_RESET_HMI(System.Boolean ResetHMI)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {ResetHMI});
    }
    public bool FireEvent_RESET_HMI(SE.Nereda.Symbols.AtvResetError.RESET_HMIEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.ResetHMI.HasValue) _values_[0] = ea.ResetHMI.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_RESET_HMI(System.Boolean ResetHMI, bool ignore_ResetHMI)
    {
      object[] _values_ = new object[1];
      if (!ignore_ResetHMI) _values_[0] = ResetHMI;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }

  }
}

namespace SE.Nereda.Symbols.AtvResetError
{
  partial class sATVState
  {

    private event EventHandler<SE.Nereda.Symbols.AtvResetError.REQ_ETAEventArgs> REQ_ETA_Fired;

    private event EventHandler<SE.Nereda.Symbols.AtvResetError.REQ_NEED_RESETEventArgs> REQ_NEED_RESET_Fired;

    protected override void OnEndInit()
    {
      if (REQ_ETA_Fired != null)
        AttachEventInput(0);
      if (REQ_NEED_RESET_Fired != null)
        AttachEventInput(1);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (REQ_ETA_Fired != null)
          {
            try
            {
              REQ_ETA_Fired(this, new SE.Nereda.Symbols.AtvResetError.REQ_ETAEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REQ_ETA_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 1:
          if (REQ_NEED_RESET_Fired != null)
          {
            try
            {
              REQ_NEED_RESET_Fired(this, new SE.Nereda.Symbols.AtvResetError.REQ_NEED_RESETEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REQ_NEED_RESET_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_RESET_HMI(System.Boolean ResetHMI)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {ResetHMI});
    }
    public bool FireEvent_RESET_HMI(SE.Nereda.Symbols.AtvResetError.RESET_HMIEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.ResetHMI.HasValue) _values_[0] = ea.ResetHMI.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_RESET_HMI(System.Boolean ResetHMI, bool ignore_ResetHMI)
    {
      object[] _values_ = new object[1];
      if (!ignore_ResetHMI) _values_[0] = ResetHMI;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }

  }
}
#endregion #AtvResetError_HMI;

#endregion Definitions;
