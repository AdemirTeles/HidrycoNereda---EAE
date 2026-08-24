/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 6/15/2026
 * Time: 10:18 PM
 * 
 */
using System;
using NxtControl.GuiFramework;
using NxtControl.Services;

#region Definitions;
#region #DigitalInput_HMI;

namespace SE.Nereda.Symbols.DigitalInput
{

  public class NEED_RESETEventArgs : System.EventArgs
  {
    IHMIAccessorService accessorService;
    int channelId;
    int cookie; 
    int eventIndex;

    public NEED_RESETEventArgs(int channelId, int cookie, int eventIndex)
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

  public class PVEventArgs : System.EventArgs
  {
    IHMIAccessorService accessorService;
    int channelId;
    int cookie; 
    int eventIndex;

    public PVEventArgs(int channelId, int cookie, int eventIndex)
    {
      this.accessorService = (IHMIAccessorService)ServiceProvider.GetService(typeof(IHMIAccessorService));
      this.channelId = channelId;
      this.cookie = cookie;
      this.eventIndex = eventIndex;
    }
    public bool Get_Pv(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,0, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? Pv
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

namespace SE.Nereda.Symbols.DigitalInput
{

  public class RESETEventArgs : System.EventArgs
  {
    public RESETEventArgs()
    {
    }
    private System.Boolean? Reset_field = null;
    public System.Boolean? Reset
    {
       get { return Reset_field; }
       set { Reset_field = value; }
    }

  }

}

namespace SE.Nereda.Symbols.DigitalInput
{
  partial class sDIn2
  {

    private event EventHandler<SE.Nereda.Symbols.DigitalInput.NEED_RESETEventArgs> NEED_RESET_Fired;

    private event EventHandler<SE.Nereda.Symbols.DigitalInput.PVEventArgs> PV_Fired;

    protected override void OnEndInit()
    {
      if (NEED_RESET_Fired != null)
        AttachEventInput(0);
      if (PV_Fired != null)
        AttachEventInput(1);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (NEED_RESET_Fired != null)
          {
            try
            {
              NEED_RESET_Fired(this, new SE.Nereda.Symbols.DigitalInput.NEED_RESETEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","NEED_RESET_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 1:
          if (PV_Fired != null)
          {
            try
            {
              PV_Fired(this, new SE.Nereda.Symbols.DigitalInput.PVEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","PV_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_RESET(System.Boolean Reset)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {Reset});
    }
    public bool FireEvent_RESET(SE.Nereda.Symbols.DigitalInput.RESETEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.Reset.HasValue) _values_[0] = ea.Reset.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_RESET(System.Boolean Reset, bool ignore_Reset)
    {
      object[] _values_ = new object[1];
      if (!ignore_Reset) _values_[0] = Reset;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }

  }
}

namespace SE.Nereda.Symbols.DigitalInput
{
  partial class sDIn1
  {

    private event EventHandler<SE.Nereda.Symbols.DigitalInput.NEED_RESETEventArgs> NEED_RESET_Fired;

    private event EventHandler<SE.Nereda.Symbols.DigitalInput.PVEventArgs> PV_Fired;

    protected override void OnEndInit()
    {
      if (NEED_RESET_Fired != null)
        AttachEventInput(0);
      if (PV_Fired != null)
        AttachEventInput(1);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (NEED_RESET_Fired != null)
          {
            try
            {
              NEED_RESET_Fired(this, new SE.Nereda.Symbols.DigitalInput.NEED_RESETEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","NEED_RESET_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 1:
          if (PV_Fired != null)
          {
            try
            {
              PV_Fired(this, new SE.Nereda.Symbols.DigitalInput.PVEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","PV_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_RESET(System.Boolean Reset)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {Reset});
    }
    public bool FireEvent_RESET(SE.Nereda.Symbols.DigitalInput.RESETEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.Reset.HasValue) _values_[0] = ea.Reset.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_RESET(System.Boolean Reset, bool ignore_Reset)
    {
      object[] _values_ = new object[1];
      if (!ignore_Reset) _values_[0] = Reset;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }

  }
}

namespace SE.Nereda.Symbols.DigitalInput
{
  partial class sDIn3
  {

    private event EventHandler<SE.Nereda.Symbols.DigitalInput.NEED_RESETEventArgs> NEED_RESET_Fired;

    private event EventHandler<SE.Nereda.Symbols.DigitalInput.PVEventArgs> PV_Fired;

    protected override void OnEndInit()
    {
      if (NEED_RESET_Fired != null)
        AttachEventInput(0);
      if (PV_Fired != null)
        AttachEventInput(1);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (NEED_RESET_Fired != null)
          {
            try
            {
              NEED_RESET_Fired(this, new SE.Nereda.Symbols.DigitalInput.NEED_RESETEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","NEED_RESET_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 1:
          if (PV_Fired != null)
          {
            try
            {
              PV_Fired(this, new SE.Nereda.Symbols.DigitalInput.PVEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","PV_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_RESET(System.Boolean Reset)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {Reset});
    }
    public bool FireEvent_RESET(SE.Nereda.Symbols.DigitalInput.RESETEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.Reset.HasValue) _values_[0] = ea.Reset.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_RESET(System.Boolean Reset, bool ignore_Reset)
    {
      object[] _values_ = new object[1];
      if (!ignore_Reset) _values_[0] = Reset;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }

  }
}

namespace SE.Nereda.Symbols.DigitalInput
{
  partial class sDIn4
  {

    private event EventHandler<SE.Nereda.Symbols.DigitalInput.NEED_RESETEventArgs> NEED_RESET_Fired;

    private event EventHandler<SE.Nereda.Symbols.DigitalInput.PVEventArgs> PV_Fired;

    protected override void OnEndInit()
    {
      if (NEED_RESET_Fired != null)
        AttachEventInput(0);
      if (PV_Fired != null)
        AttachEventInput(1);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (NEED_RESET_Fired != null)
          {
            try
            {
              NEED_RESET_Fired(this, new SE.Nereda.Symbols.DigitalInput.NEED_RESETEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","NEED_RESET_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 1:
          if (PV_Fired != null)
          {
            try
            {
              PV_Fired(this, new SE.Nereda.Symbols.DigitalInput.PVEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","PV_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_RESET(System.Boolean Reset)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {Reset});
    }
    public bool FireEvent_RESET(SE.Nereda.Symbols.DigitalInput.RESETEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.Reset.HasValue) _values_[0] = ea.Reset.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_RESET(System.Boolean Reset, bool ignore_Reset)
    {
      object[] _values_ = new object[1];
      if (!ignore_Reset) _values_[0] = Reset;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }

  }
}
#endregion #DigitalInput_HMI;

#endregion Definitions;
