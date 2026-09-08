/*
 * Created by EcoStruxure Automation Expert.
 * User: SESA371406
 * Date: 06/08/2021
 * Time: 10:27 am
 * 
 */
using System;
using NxtControl.GuiFramework;
using NxtControl.Services;

#region Definitions;
#region #ATV320_HMI;

namespace SE.Nereda.Symbols.ATV320
{

  public class UPDATE_STATUSEventArgs : System.EventArgs
  {
    IHMIAccessorService accessorService;
    int channelId;
    int cookie; 
    int eventIndex;

    public UPDATE_STATUSEventArgs(int channelId, int cookie, int eventIndex)
    {
      this.accessorService = (IHMIAccessorService)ServiceProvider.GetService(typeof(IHMIAccessorService));
      this.channelId = channelId;
      this.cookie = cookie;
      this.eventIndex = eventIndex;
    }
    public bool Get_RFRD(ref System.UInt16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,0, ref var);
      if (ret) value = (System.UInt16) var;
      return ret;
    }

    public System.UInt16? RFRD
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,0, ref var);
      if (!ret) return null;
      return (System.UInt16) var;
    }  }

    public bool Get_ETA(ref System.UInt16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,1, ref var);
      if (ret) value = (System.UInt16) var;
      return ret;
    }

    public System.UInt16? ETA
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,1, ref var);
      if (!ret) return null;
      return (System.UInt16) var;
    }  }

    public bool Get_Run_Stop(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,2, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? Run_Stop
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,2, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_Default_ATV320(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,3, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? Default_ATV320
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,3, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }


  }

}

namespace SE.Nereda.Symbols.ATV320
{

  public class CNF_RESET_ERROREventArgs : System.EventArgs
  {
    public CNF_RESET_ERROREventArgs()
    {
    }
    private System.Boolean? RESET_ERROR_ATV320_field = null;
    public System.Boolean? RESET_ERROR_ATV320
    {
       get { return RESET_ERROR_ATV320_field; }
       set { RESET_ERROR_ATV320_field = value; }
    }

  }

  public class CNF_QUICK_STOPEventArgs : System.EventArgs
  {
    public CNF_QUICK_STOPEventArgs()
    {
    }
    private System.Boolean? QUICK_STOP_ATV320_field = null;
    public System.Boolean? QUICK_STOP_ATV320
    {
       get { return QUICK_STOP_ATV320_field; }
       set { QUICK_STOP_ATV320_field = value; }
    }

  }

  public class CNF_SPEED_VALUEEventArgs : System.EventArgs
  {
    public CNF_SPEED_VALUEEventArgs()
    {
    }
    private System.Int16? SPEED_REF_VALUE_ATV320_field = null;
    public System.Int16? SPEED_REF_VALUE_ATV320
    {
       get { return SPEED_REF_VALUE_ATV320_field; }
       set { SPEED_REF_VALUE_ATV320_field = value; }
    }

  }

}

namespace SE.Nereda.Symbols.ATV320
{
  partial class sDefault
  {

    private event EventHandler<SE.Nereda.Symbols.ATV320.UPDATE_STATUSEventArgs> UPDATE_STATUS_Fired;

    protected override void OnEndInit()
    {
      if (UPDATE_STATUS_Fired != null)
        AttachEventInput(0);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (UPDATE_STATUS_Fired != null)
          {
            try
            {
              UPDATE_STATUS_Fired(this, new SE.Nereda.Symbols.ATV320.UPDATE_STATUSEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","UPDATE_STATUS_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_CNF_RESET_ERROR(System.Boolean RESET_ERROR_ATV320)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {RESET_ERROR_ATV320});
    }
    public bool FireEvent_CNF_RESET_ERROR(SE.Nereda.Symbols.ATV320.CNF_RESET_ERROREventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.RESET_ERROR_ATV320.HasValue) _values_[0] = ea.RESET_ERROR_ATV320.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_CNF_RESET_ERROR(System.Boolean RESET_ERROR_ATV320, bool ignore_RESET_ERROR_ATV320)
    {
      object[] _values_ = new object[1];
      if (!ignore_RESET_ERROR_ATV320) _values_[0] = RESET_ERROR_ATV320;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_CNF_QUICK_STOP(System.Boolean QUICK_STOP_ATV320)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {QUICK_STOP_ATV320});
    }
    public bool FireEvent_CNF_QUICK_STOP(SE.Nereda.Symbols.ATV320.CNF_QUICK_STOPEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.QUICK_STOP_ATV320.HasValue) _values_[0] = ea.QUICK_STOP_ATV320.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_CNF_QUICK_STOP(System.Boolean QUICK_STOP_ATV320, bool ignore_QUICK_STOP_ATV320)
    {
      object[] _values_ = new object[1];
      if (!ignore_QUICK_STOP_ATV320) _values_[0] = QUICK_STOP_ATV320;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_CNF_SPEED_VALUE(System.Int16 SPEED_REF_VALUE_ATV320)
    {
      return ((IHMIAccessorOutput)this).FireEvent(2, new object[] {SPEED_REF_VALUE_ATV320});
    }
    public bool FireEvent_CNF_SPEED_VALUE(SE.Nereda.Symbols.ATV320.CNF_SPEED_VALUEEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.SPEED_REF_VALUE_ATV320.HasValue) _values_[0] = ea.SPEED_REF_VALUE_ATV320.Value;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_CNF_SPEED_VALUE(System.Int16 SPEED_REF_VALUE_ATV320, bool ignore_SPEED_REF_VALUE_ATV320)
    {
      object[] _values_ = new object[1];
      if (!ignore_SPEED_REF_VALUE_ATV320) _values_[0] = SPEED_REF_VALUE_ATV320;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }

  }
}
#endregion #ATV320_HMI;

#endregion Definitions;
