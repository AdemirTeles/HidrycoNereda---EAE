/*
 * Created by EcoStruxure Automation Expert.
 * User: SESA713705
 * Date: 4/25/2024
 * Time: 10:31 AM
 * 
 */
using System;
using NxtControl.GuiFramework;
using NxtControl.Services;

#region Definitions;
#region #NeredaSludgeBuffer_2_HMI;

namespace SE.Nereda.Symbols.NeredaSludgeBuffer_2
{

  public class FB_STATUSEventArgs : System.EventArgs
  {
    IHMIAccessorService accessorService;
    int channelId;
    int cookie; 
    int eventIndex;

    public FB_STATUSEventArgs(int channelId, int cookie, int eventIndex)
    {
      this.accessorService = (IHMIAccessorService)ServiceProvider.GetService(typeof(IHMIAccessorService));
      this.channelId = channelId;
      this.cookie = cookie;
      this.eventIndex = eventIndex;
    }
    public bool Get_OutStatus(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,0, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? OutStatus
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,0, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }


  }

}

namespace SE.Nereda.Symbols.NeredaSludgeBuffer_2
{

  public class REQEventArgs : System.EventArgs
  {
    public REQEventArgs()
    {
    }
    private System.Int16? InStatus_field = null;
    public System.Int16? InStatus
    {
       get { return InStatus_field; }
       set { InStatus_field = value; }
    }

  }

}

namespace SE.Nereda.Symbols.NeredaSludgeBuffer_2
{
  partial class sPhases
  {

    private event EventHandler<SE.Nereda.Symbols.NeredaSludgeBuffer_2.FB_STATUSEventArgs> FB_STATUS_Fired;

    protected override void OnEndInit()
    {
      if (FB_STATUS_Fired != null)
        AttachEventInput(0);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (FB_STATUS_Fired != null)
          {
            try
            {
              FB_STATUS_Fired(this, new SE.Nereda.Symbols.NeredaSludgeBuffer_2.FB_STATUSEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","FB_STATUS_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_REQ(System.Int16 InStatus)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {InStatus});
    }
    public bool FireEvent_REQ(SE.Nereda.Symbols.NeredaSludgeBuffer_2.REQEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.InStatus.HasValue) _values_[0] = ea.InStatus.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_REQ(System.Int16 InStatus, bool ignore_InStatus)
    {
      object[] _values_ = new object[1];
      if (!ignore_InStatus) _values_[0] = InStatus;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }

  }
}

namespace SE.Nereda.Symbols.NeredaSludgeBuffer_2
{
  partial class sSensors
  {

    private event EventHandler<SE.Nereda.Symbols.NeredaSludgeBuffer_2.FB_STATUSEventArgs> FB_STATUS_Fired;

    protected override void OnEndInit()
    {
      if (FB_STATUS_Fired != null)
        AttachEventInput(0);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (FB_STATUS_Fired != null)
          {
            try
            {
              FB_STATUS_Fired(this, new SE.Nereda.Symbols.NeredaSludgeBuffer_2.FB_STATUSEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","FB_STATUS_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_REQ(System.Int16 InStatus)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {InStatus});
    }
    public bool FireEvent_REQ(SE.Nereda.Symbols.NeredaSludgeBuffer_2.REQEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.InStatus.HasValue) _values_[0] = ea.InStatus.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_REQ(System.Int16 InStatus, bool ignore_InStatus)
    {
      object[] _values_ = new object[1];
      if (!ignore_InStatus) _values_[0] = InStatus;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }

  }
}

namespace SE.Nereda.Symbols.NeredaSludgeBuffer_2
{
  partial class sSludgeBuffer
  {

    private event EventHandler<SE.Nereda.Symbols.NeredaSludgeBuffer_2.FB_STATUSEventArgs> FB_STATUS_Fired;

    protected override void OnEndInit()
    {
      if (FB_STATUS_Fired != null)
        AttachEventInput(0);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (FB_STATUS_Fired != null)
          {
            try
            {
              FB_STATUS_Fired(this, new SE.Nereda.Symbols.NeredaSludgeBuffer_2.FB_STATUSEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","FB_STATUS_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_REQ(System.Int16 InStatus)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {InStatus});
    }
    public bool FireEvent_REQ(SE.Nereda.Symbols.NeredaSludgeBuffer_2.REQEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.InStatus.HasValue) _values_[0] = ea.InStatus.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_REQ(System.Int16 InStatus, bool ignore_InStatus)
    {
      object[] _values_ = new object[1];
      if (!ignore_InStatus) _values_[0] = InStatus;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }

  }
}

namespace SE.Nereda.Symbols.NeredaSludgeBuffer_2
{
  partial class sSettingsSLB
  {

    private event EventHandler<SE.Nereda.Symbols.NeredaSludgeBuffer_2.FB_STATUSEventArgs> FB_STATUS_Fired;

    protected override void OnEndInit()
    {
      if (FB_STATUS_Fired != null)
        AttachEventInput(0);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (FB_STATUS_Fired != null)
          {
            try
            {
              FB_STATUS_Fired(this, new SE.Nereda.Symbols.NeredaSludgeBuffer_2.FB_STATUSEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","FB_STATUS_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_REQ(System.Int16 InStatus)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {InStatus});
    }
    public bool FireEvent_REQ(SE.Nereda.Symbols.NeredaSludgeBuffer_2.REQEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.InStatus.HasValue) _values_[0] = ea.InStatus.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_REQ(System.Int16 InStatus, bool ignore_InStatus)
    {
      object[] _values_ = new object[1];
      if (!ignore_InStatus) _values_[0] = InStatus;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }

  }
}

namespace SE.Nereda.Faceplates.NeredaSludgeBuffer_2
{
  partial class fpSettings
  {

    private event EventHandler<SE.Nereda.Symbols.NeredaSludgeBuffer_2.FB_STATUSEventArgs> FB_STATUS_Fired;

    protected override void OnEndInit()
    {
      if (FB_STATUS_Fired != null)
        AttachEventInput(0);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (FB_STATUS_Fired != null)
          {
            try
            {
              FB_STATUS_Fired(this, new SE.Nereda.Symbols.NeredaSludgeBuffer_2.FB_STATUSEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","FB_STATUS_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_REQ(System.Int16 InStatus)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {InStatus});
    }
    public bool FireEvent_REQ(SE.Nereda.Symbols.NeredaSludgeBuffer_2.REQEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.InStatus.HasValue) _values_[0] = ea.InStatus.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_REQ(System.Int16 InStatus, bool ignore_InStatus)
    {
      object[] _values_ = new object[1];
      if (!ignore_InStatus) _values_[0] = InStatus;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }

  }
}

namespace SE.Nereda.Symbols.NeredaSludgeBuffer_2
{
  partial class sSludgeBufferyellow
  {

    private event EventHandler<SE.Nereda.Symbols.NeredaSludgeBuffer_2.FB_STATUSEventArgs> FB_STATUS_Fired;

    protected override void OnEndInit()
    {
      if (FB_STATUS_Fired != null)
        AttachEventInput(0);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (FB_STATUS_Fired != null)
          {
            try
            {
              FB_STATUS_Fired(this, new SE.Nereda.Symbols.NeredaSludgeBuffer_2.FB_STATUSEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","FB_STATUS_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_REQ(System.Int16 InStatus)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {InStatus});
    }
    public bool FireEvent_REQ(SE.Nereda.Symbols.NeredaSludgeBuffer_2.REQEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.InStatus.HasValue) _values_[0] = ea.InStatus.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_REQ(System.Int16 InStatus, bool ignore_InStatus)
    {
      object[] _values_ = new object[1];
      if (!ignore_InStatus) _values_[0] = InStatus;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }

  }
}
#endregion #NeredaSludgeBuffer_2_HMI;

#endregion Definitions;
