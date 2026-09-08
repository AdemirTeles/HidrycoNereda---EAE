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

  public class REQ_STATUSEventArgs : System.EventArgs
  {
    IHMIAccessorService accessorService;
    int channelId;
    int cookie; 
    int eventIndex;

    public REQ_STATUSEventArgs(int channelId, int cookie, int eventIndex)
    {
      this.accessorService = (IHMIAccessorService)ServiceProvider.GetService(typeof(IHMIAccessorService));
      this.channelId = channelId;
      this.cookie = cookie;
      this.eventIndex = eventIndex;
    }

  }

}

namespace SE.Nereda.Symbols.NeredaSludgeBuffer_2
{

  public class CNF_STATUSEventArgs : System.EventArgs
  {
    public CNF_STATUSEventArgs()
    {
    }
    private System.Int16? Status_field = null;
    public System.Int16? Status
    {
       get { return Status_field; }
       set { Status_field = value; }
    }

  }

}

namespace SE.Nereda.Symbols.NeredaSludgeBuffer_2
{
  partial class sPhases
  {

    private event EventHandler<SE.Nereda.Symbols.NeredaSludgeBuffer_2.REQ_STATUSEventArgs> REQ_STATUS_Fired;

    protected override void OnEndInit()
    {
      if (REQ_STATUS_Fired != null)
        AttachEventInput(0);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (REQ_STATUS_Fired != null)
          {
            try
            {
              REQ_STATUS_Fired(this, new SE.Nereda.Symbols.NeredaSludgeBuffer_2.REQ_STATUSEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REQ_STATUS_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_CNF_STATUS(System.Int16 Status)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {Status});
    }
    public bool FireEvent_CNF_STATUS(SE.Nereda.Symbols.NeredaSludgeBuffer_2.CNF_STATUSEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.Status.HasValue) _values_[0] = ea.Status.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_CNF_STATUS(System.Int16 Status, bool ignore_Status)
    {
      object[] _values_ = new object[1];
      if (!ignore_Status) _values_[0] = Status;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }

  }
}

namespace SE.Nereda.Symbols.NeredaSludgeBuffer_2
{
  partial class sSensors
  {

    private event EventHandler<SE.Nereda.Symbols.NeredaSludgeBuffer_2.REQ_STATUSEventArgs> REQ_STATUS_Fired;

    protected override void OnEndInit()
    {
      if (REQ_STATUS_Fired != null)
        AttachEventInput(0);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (REQ_STATUS_Fired != null)
          {
            try
            {
              REQ_STATUS_Fired(this, new SE.Nereda.Symbols.NeredaSludgeBuffer_2.REQ_STATUSEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REQ_STATUS_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_CNF_STATUS(System.Int16 Status)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {Status});
    }
    public bool FireEvent_CNF_STATUS(SE.Nereda.Symbols.NeredaSludgeBuffer_2.CNF_STATUSEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.Status.HasValue) _values_[0] = ea.Status.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_CNF_STATUS(System.Int16 Status, bool ignore_Status)
    {
      object[] _values_ = new object[1];
      if (!ignore_Status) _values_[0] = Status;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }

  }
}

namespace SE.Nereda.Symbols.NeredaSludgeBuffer_2
{
  partial class sSludgeBuffer
  {

    private event EventHandler<SE.Nereda.Symbols.NeredaSludgeBuffer_2.REQ_STATUSEventArgs> REQ_STATUS_Fired;

    protected override void OnEndInit()
    {
      if (REQ_STATUS_Fired != null)
        AttachEventInput(0);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (REQ_STATUS_Fired != null)
          {
            try
            {
              REQ_STATUS_Fired(this, new SE.Nereda.Symbols.NeredaSludgeBuffer_2.REQ_STATUSEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REQ_STATUS_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_CNF_STATUS(System.Int16 Status)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {Status});
    }
    public bool FireEvent_CNF_STATUS(SE.Nereda.Symbols.NeredaSludgeBuffer_2.CNF_STATUSEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.Status.HasValue) _values_[0] = ea.Status.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_CNF_STATUS(System.Int16 Status, bool ignore_Status)
    {
      object[] _values_ = new object[1];
      if (!ignore_Status) _values_[0] = Status;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }

  }
}

namespace SE.Nereda.Symbols.NeredaSludgeBuffer_2
{
  partial class sSettingsSLB
  {

    private event EventHandler<SE.Nereda.Symbols.NeredaSludgeBuffer_2.REQ_STATUSEventArgs> REQ_STATUS_Fired;

    protected override void OnEndInit()
    {
      if (REQ_STATUS_Fired != null)
        AttachEventInput(0);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (REQ_STATUS_Fired != null)
          {
            try
            {
              REQ_STATUS_Fired(this, new SE.Nereda.Symbols.NeredaSludgeBuffer_2.REQ_STATUSEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REQ_STATUS_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_CNF_STATUS(System.Int16 Status)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {Status});
    }
    public bool FireEvent_CNF_STATUS(SE.Nereda.Symbols.NeredaSludgeBuffer_2.CNF_STATUSEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.Status.HasValue) _values_[0] = ea.Status.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_CNF_STATUS(System.Int16 Status, bool ignore_Status)
    {
      object[] _values_ = new object[1];
      if (!ignore_Status) _values_[0] = Status;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }

  }
}

namespace SE.Nereda.Faceplates.NeredaSludgeBuffer_2
{
  partial class fpSettings
  {

    private event EventHandler<SE.Nereda.Symbols.NeredaSludgeBuffer_2.REQ_STATUSEventArgs> REQ_STATUS_Fired;

    protected override void OnEndInit()
    {
      if (REQ_STATUS_Fired != null)
        AttachEventInput(0);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (REQ_STATUS_Fired != null)
          {
            try
            {
              REQ_STATUS_Fired(this, new SE.Nereda.Symbols.NeredaSludgeBuffer_2.REQ_STATUSEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REQ_STATUS_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_CNF_STATUS(System.Int16 Status)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {Status});
    }
    public bool FireEvent_CNF_STATUS(SE.Nereda.Symbols.NeredaSludgeBuffer_2.CNF_STATUSEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.Status.HasValue) _values_[0] = ea.Status.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_CNF_STATUS(System.Int16 Status, bool ignore_Status)
    {
      object[] _values_ = new object[1];
      if (!ignore_Status) _values_[0] = Status;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }

  }
}

namespace SE.Nereda.Symbols.NeredaSludgeBuffer_2
{
  partial class sSludgeBufferyellow
  {

    private event EventHandler<SE.Nereda.Symbols.NeredaSludgeBuffer_2.REQ_STATUSEventArgs> REQ_STATUS_Fired;

    protected override void OnEndInit()
    {
      if (REQ_STATUS_Fired != null)
        AttachEventInput(0);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (REQ_STATUS_Fired != null)
          {
            try
            {
              REQ_STATUS_Fired(this, new SE.Nereda.Symbols.NeredaSludgeBuffer_2.REQ_STATUSEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REQ_STATUS_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_CNF_STATUS(System.Int16 Status)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {Status});
    }
    public bool FireEvent_CNF_STATUS(SE.Nereda.Symbols.NeredaSludgeBuffer_2.CNF_STATUSEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.Status.HasValue) _values_[0] = ea.Status.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_CNF_STATUS(System.Int16 Status, bool ignore_Status)
    {
      object[] _values_ = new object[1];
      if (!ignore_Status) _values_[0] = Status;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }

  }
}
#endregion #NeredaSludgeBuffer_2_HMI;

#endregion Definitions;
