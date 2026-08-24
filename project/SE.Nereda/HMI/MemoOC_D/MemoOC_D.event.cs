/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 6/7/2026
 * Time: 2:16 PM
 * 
 */
using System;
using NxtControl.GuiFramework;
using NxtControl.Services;

#region Definitions;
#region #MemoOC_D_HMI;

namespace SE.Nereda.Symbols.MemoOC_D
{

  public class OC_STATUSEventArgs : System.EventArgs
  {
    IHMIAccessorService accessorService;
    int channelId;
    int cookie; 
    int eventIndex;

    public OC_STATUSEventArgs(int channelId, int cookie, int eventIndex)
    {
      this.accessorService = (IHMIAccessorService)ServiceProvider.GetService(typeof(IHMIAccessorService));
      this.channelId = channelId;
      this.cookie = cookie;
      this.eventIndex = eventIndex;
    }
    public bool Get_OCStatus_Curr(ref System.UInt16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,0, ref var);
      if (ret) value = (System.UInt16) var;
      return ret;
    }

    public System.UInt16? OCStatus_Curr
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,0, ref var);
      if (!ret) return null;
      return (System.UInt16) var;
    }  }

    public bool Get_OCStatus1(ref System.UInt16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,1, ref var);
      if (ret) value = (System.UInt16) var;
      return ret;
    }

    public System.UInt16? OCStatus1
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,1, ref var);
      if (!ret) return null;
      return (System.UInt16) var;
    }  }

    public bool Get_OCStatus2(ref System.UInt16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,2, ref var);
      if (ret) value = (System.UInt16) var;
      return ret;
    }

    public System.UInt16? OCStatus2
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,2, ref var);
      if (!ret) return null;
      return (System.UInt16) var;
    }  }

    public bool Get_OCStatus3(ref System.UInt16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,3, ref var);
      if (ret) value = (System.UInt16) var;
      return ret;
    }

    public System.UInt16? OCStatus3
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,3, ref var);
      if (!ret) return null;
      return (System.UInt16) var;
    }  }

    public bool Get_OCStatus4(ref System.UInt16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,4, ref var);
      if (ret) value = (System.UInt16) var;
      return ret;
    }

    public System.UInt16? OCStatus4
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,4, ref var);
      if (!ret) return null;
      return (System.UInt16) var;
    }  }

    public bool Get_OCStatus5(ref System.UInt16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,5, ref var);
      if (ret) value = (System.UInt16) var;
      return ret;
    }

    public System.UInt16? OCStatus5
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,5, ref var);
      if (!ret) return null;
      return (System.UInt16) var;
    }  }

    public bool Get_OCStatus6(ref System.UInt16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,6, ref var);
      if (ret) value = (System.UInt16) var;
      return ret;
    }

    public System.UInt16? OCStatus6
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,6, ref var);
      if (!ret) return null;
      return (System.UInt16) var;
    }  }

    public bool Get_OCStatus7(ref System.UInt16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,7, ref var);
      if (ret) value = (System.UInt16) var;
      return ret;
    }

    public System.UInt16? OCStatus7
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,7, ref var);
      if (!ret) return null;
      return (System.UInt16) var;
    }  }

    public bool Get_OCStatus8(ref System.UInt16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,8, ref var);
      if (ret) value = (System.UInt16) var;
      return ret;
    }

    public System.UInt16? OCStatus8
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,8, ref var);
      if (!ret) return null;
      return (System.UInt16) var;
    }  }

    public bool Get_OCStatus9(ref System.UInt16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,9, ref var);
      if (ret) value = (System.UInt16) var;
      return ret;
    }

    public System.UInt16? OCStatus9
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,9, ref var);
      if (!ret) return null;
      return (System.UInt16) var;
    }  }


  }

}

namespace SE.Nereda.Symbols.MemoOC_D
{
  partial class sDefault
  {

    private event EventHandler<SE.Nereda.Symbols.MemoOC_D.OC_STATUSEventArgs> OC_STATUS_Fired;

    protected override void OnEndInit()
    {
      if (OC_STATUS_Fired != null)
        AttachEventInput(0);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (OC_STATUS_Fired != null)
          {
            try
            {
              OC_STATUS_Fired(this, new SE.Nereda.Symbols.MemoOC_D.OC_STATUSEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","OC_STATUS_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }

  }
}

namespace SE.Nereda.Faceplates.MemoOC_D
{
  partial class fpMemoOC
  {

    private event EventHandler<SE.Nereda.Symbols.MemoOC_D.OC_STATUSEventArgs> OC_STATUS_Fired;

    protected override void OnEndInit()
    {
      if (OC_STATUS_Fired != null)
        AttachEventInput(0);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (OC_STATUS_Fired != null)
          {
            try
            {
              OC_STATUS_Fired(this, new SE.Nereda.Symbols.MemoOC_D.OC_STATUSEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","OC_STATUS_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }

  }
}

namespace SE.Nereda.Symbols.MemoOC_D
{
  partial class sMOCBtn
  {

    private event EventHandler<SE.Nereda.Symbols.MemoOC_D.OC_STATUSEventArgs> OC_STATUS_Fired;

    protected override void OnEndInit()
    {
      if (OC_STATUS_Fired != null)
        AttachEventInput(0);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (OC_STATUS_Fired != null)
          {
            try
            {
              OC_STATUS_Fired(this, new SE.Nereda.Symbols.MemoOC_D.OC_STATUSEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","OC_STATUS_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }

  }
}
#endregion #MemoOC_D_HMI;

#endregion Definitions;
