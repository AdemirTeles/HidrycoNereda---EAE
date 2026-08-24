/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 6/2/2026
 * Time: 9:20 AM
 * 
 */
using System;
using NxtControl.GuiFramework;
using NxtControl.Services;

#region Definitions;
#region #ValveS_HMI;

namespace SE.Nereda.Symbols.ValveS
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

  public class OPDEventArgs : System.EventArgs
  {
    IHMIAccessorService accessorService;
    int channelId;
    int cookie; 
    int eventIndex;

    public OPDEventArgs(int channelId, int cookie, int eventIndex)
    {
      this.accessorService = (IHMIAccessorService)ServiceProvider.GetService(typeof(IHMIAccessorService));
      this.channelId = channelId;
      this.cookie = cookie;
      this.eventIndex = eventIndex;
    }
    public bool Get_Counter(ref System.UInt32 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,0, ref var);
      if (ret) value = (System.UInt32) var;
      return ret;
    }

    public System.UInt32? Counter
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,0, ref var);
      if (!ret) return null;
      return (System.UInt32) var;
    }  }


  }

  public class FB_FAILEventArgs : System.EventArgs
  {
    IHMIAccessorService accessorService;
    int channelId;
    int cookie; 
    int eventIndex;

    public FB_FAILEventArgs(int channelId, int cookie, int eventIndex)
    {
      this.accessorService = (IHMIAccessorService)ServiceProvider.GetService(typeof(IHMIAccessorService));
      this.channelId = channelId;
      this.cookie = cookie;
      this.eventIndex = eventIndex;
    }
    public bool Get_FbFailure(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,0, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? FbFailure
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

namespace SE.Nereda.Symbols.ValveS
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

namespace SE.Nereda.Symbols.ValveS
{
  partial class sDefault
  {

    private event EventHandler<SE.Nereda.Symbols.ValveS.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    private event EventHandler<SE.Nereda.Symbols.ValveS.NEED_RESETEventArgs> NEED_RESET_Fired;

    private event EventHandler<SE.Nereda.Symbols.ValveS.OPDEventArgs> OPD_Fired;

    private event EventHandler<SE.Nereda.Symbols.ValveS.FB_FAILEventArgs> FB_FAIL_Fired;

    protected override void OnEndInit()
    {
      if (LOAD_PERS_DATA_Fired != null)
        AttachEventInput(0);
      if (NEED_RESET_Fired != null)
        AttachEventInput(1);
      if (OPD_Fired != null)
        AttachEventInput(2);
      if (FB_FAIL_Fired != null)
        AttachEventInput(3);

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
              LOAD_PERS_DATA_Fired(this, new SE.Nereda.Symbols.ValveS.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
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
          if (NEED_RESET_Fired != null)
          {
            try
            {
              NEED_RESET_Fired(this, new SE.Nereda.Symbols.ValveS.NEED_RESETEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","NEED_RESET_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 2:
          if (OPD_Fired != null)
          {
            try
            {
              OPD_Fired(this, new SE.Nereda.Symbols.ValveS.OPDEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","OPD_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 3:
          if (FB_FAIL_Fired != null)
          {
            try
            {
              FB_FAIL_Fired(this, new SE.Nereda.Symbols.ValveS.FB_FAILEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","FB_FAIL_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_RESET(System.Boolean Reset)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {Reset});
    }
    public bool FireEvent_RESET(SE.Nereda.Symbols.ValveS.RESETEventArgs ea)
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

namespace SE.Nereda.Faceplates.ValveS
{
  partial class fpOptions
  {

    private event EventHandler<SE.Nereda.Symbols.ValveS.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    private event EventHandler<SE.Nereda.Symbols.ValveS.NEED_RESETEventArgs> NEED_RESET_Fired;

    private event EventHandler<SE.Nereda.Symbols.ValveS.OPDEventArgs> OPD_Fired;

    private event EventHandler<SE.Nereda.Symbols.ValveS.FB_FAILEventArgs> FB_FAIL_Fired;

    protected override void OnEndInit()
    {
      if (LOAD_PERS_DATA_Fired != null)
        AttachEventInput(0);
      if (NEED_RESET_Fired != null)
        AttachEventInput(1);
      if (OPD_Fired != null)
        AttachEventInput(2);
      if (FB_FAIL_Fired != null)
        AttachEventInput(3);

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
              LOAD_PERS_DATA_Fired(this, new SE.Nereda.Symbols.ValveS.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
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
          if (NEED_RESET_Fired != null)
          {
            try
            {
              NEED_RESET_Fired(this, new SE.Nereda.Symbols.ValveS.NEED_RESETEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","NEED_RESET_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 2:
          if (OPD_Fired != null)
          {
            try
            {
              OPD_Fired(this, new SE.Nereda.Symbols.ValveS.OPDEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","OPD_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 3:
          if (FB_FAIL_Fired != null)
          {
            try
            {
              FB_FAIL_Fired(this, new SE.Nereda.Symbols.ValveS.FB_FAILEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","FB_FAIL_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_RESET(System.Boolean Reset)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {Reset});
    }
    public bool FireEvent_RESET(SE.Nereda.Symbols.ValveS.RESETEventArgs ea)
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

namespace SE.Nereda.Symbols.ValveS
{
  partial class s3DValve
  {

    private event EventHandler<SE.Nereda.Symbols.ValveS.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    private event EventHandler<SE.Nereda.Symbols.ValveS.NEED_RESETEventArgs> NEED_RESET_Fired;

    private event EventHandler<SE.Nereda.Symbols.ValveS.OPDEventArgs> OPD_Fired;

    private event EventHandler<SE.Nereda.Symbols.ValveS.FB_FAILEventArgs> FB_FAIL_Fired;

    protected override void OnEndInit()
    {
      if (LOAD_PERS_DATA_Fired != null)
        AttachEventInput(0);
      if (NEED_RESET_Fired != null)
        AttachEventInput(1);
      if (OPD_Fired != null)
        AttachEventInput(2);
      if (FB_FAIL_Fired != null)
        AttachEventInput(3);

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
              LOAD_PERS_DATA_Fired(this, new SE.Nereda.Symbols.ValveS.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
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
          if (NEED_RESET_Fired != null)
          {
            try
            {
              NEED_RESET_Fired(this, new SE.Nereda.Symbols.ValveS.NEED_RESETEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","NEED_RESET_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 2:
          if (OPD_Fired != null)
          {
            try
            {
              OPD_Fired(this, new SE.Nereda.Symbols.ValveS.OPDEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","OPD_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 3:
          if (FB_FAIL_Fired != null)
          {
            try
            {
              FB_FAIL_Fired(this, new SE.Nereda.Symbols.ValveS.FB_FAILEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","FB_FAIL_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_RESET(System.Boolean Reset)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {Reset});
    }
    public bool FireEvent_RESET(SE.Nereda.Symbols.ValveS.RESETEventArgs ea)
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

namespace SE.Nereda.Faceplates.ValveS
{
  partial class fpLocalPanel
  {

    private event EventHandler<SE.Nereda.Symbols.ValveS.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    private event EventHandler<SE.Nereda.Symbols.ValveS.NEED_RESETEventArgs> NEED_RESET_Fired;

    private event EventHandler<SE.Nereda.Symbols.ValveS.OPDEventArgs> OPD_Fired;

    private event EventHandler<SE.Nereda.Symbols.ValveS.FB_FAILEventArgs> FB_FAIL_Fired;

    protected override void OnEndInit()
    {
      if (LOAD_PERS_DATA_Fired != null)
        AttachEventInput(0);
      if (NEED_RESET_Fired != null)
        AttachEventInput(1);
      if (OPD_Fired != null)
        AttachEventInput(2);
      if (FB_FAIL_Fired != null)
        AttachEventInput(3);

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
              LOAD_PERS_DATA_Fired(this, new SE.Nereda.Symbols.ValveS.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
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
          if (NEED_RESET_Fired != null)
          {
            try
            {
              NEED_RESET_Fired(this, new SE.Nereda.Symbols.ValveS.NEED_RESETEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","NEED_RESET_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 2:
          if (OPD_Fired != null)
          {
            try
            {
              OPD_Fired(this, new SE.Nereda.Symbols.ValveS.OPDEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","OPD_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 3:
          if (FB_FAIL_Fired != null)
          {
            try
            {
              FB_FAIL_Fired(this, new SE.Nereda.Symbols.ValveS.FB_FAILEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","FB_FAIL_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_RESET(System.Boolean Reset)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {Reset});
    }
    public bool FireEvent_RESET(SE.Nereda.Symbols.ValveS.RESETEventArgs ea)
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

namespace SE.Nereda.Symbols.ValveS
{
  partial class sCounter
  {

    private event EventHandler<SE.Nereda.Symbols.ValveS.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    private event EventHandler<SE.Nereda.Symbols.ValveS.NEED_RESETEventArgs> NEED_RESET_Fired;

    private event EventHandler<SE.Nereda.Symbols.ValveS.OPDEventArgs> OPD_Fired;

    private event EventHandler<SE.Nereda.Symbols.ValveS.FB_FAILEventArgs> FB_FAIL_Fired;

    protected override void OnEndInit()
    {
      if (LOAD_PERS_DATA_Fired != null)
        AttachEventInput(0);
      if (NEED_RESET_Fired != null)
        AttachEventInput(1);
      if (OPD_Fired != null)
        AttachEventInput(2);
      if (FB_FAIL_Fired != null)
        AttachEventInput(3);

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
              LOAD_PERS_DATA_Fired(this, new SE.Nereda.Symbols.ValveS.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
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
          if (NEED_RESET_Fired != null)
          {
            try
            {
              NEED_RESET_Fired(this, new SE.Nereda.Symbols.ValveS.NEED_RESETEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","NEED_RESET_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 2:
          if (OPD_Fired != null)
          {
            try
            {
              OPD_Fired(this, new SE.Nereda.Symbols.ValveS.OPDEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","OPD_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 3:
          if (FB_FAIL_Fired != null)
          {
            try
            {
              FB_FAIL_Fired(this, new SE.Nereda.Symbols.ValveS.FB_FAILEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","FB_FAIL_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_RESET(System.Boolean Reset)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {Reset});
    }
    public bool FireEvent_RESET(SE.Nereda.Symbols.ValveS.RESETEventArgs ea)
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

namespace SE.Nereda.Symbols.ValveS
{
  partial class sStatus
  {

    private event EventHandler<SE.Nereda.Symbols.ValveS.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    private event EventHandler<SE.Nereda.Symbols.ValveS.NEED_RESETEventArgs> NEED_RESET_Fired;

    private event EventHandler<SE.Nereda.Symbols.ValveS.OPDEventArgs> OPD_Fired;

    private event EventHandler<SE.Nereda.Symbols.ValveS.FB_FAILEventArgs> FB_FAIL_Fired;

    protected override void OnEndInit()
    {
      if (LOAD_PERS_DATA_Fired != null)
        AttachEventInput(0);
      if (NEED_RESET_Fired != null)
        AttachEventInput(1);
      if (OPD_Fired != null)
        AttachEventInput(2);
      if (FB_FAIL_Fired != null)
        AttachEventInput(3);

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
              LOAD_PERS_DATA_Fired(this, new SE.Nereda.Symbols.ValveS.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
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
          if (NEED_RESET_Fired != null)
          {
            try
            {
              NEED_RESET_Fired(this, new SE.Nereda.Symbols.ValveS.NEED_RESETEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","NEED_RESET_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 2:
          if (OPD_Fired != null)
          {
            try
            {
              OPD_Fired(this, new SE.Nereda.Symbols.ValveS.OPDEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","OPD_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 3:
          if (FB_FAIL_Fired != null)
          {
            try
            {
              FB_FAIL_Fired(this, new SE.Nereda.Symbols.ValveS.FB_FAILEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","FB_FAIL_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_RESET(System.Boolean Reset)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {Reset});
    }
    public bool FireEvent_RESET(SE.Nereda.Symbols.ValveS.RESETEventArgs ea)
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

namespace SE.Nereda.Symbols.ValveS
{
  partial class Symbol1
  {

    private event EventHandler<SE.Nereda.Symbols.ValveS.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    private event EventHandler<SE.Nereda.Symbols.ValveS.NEED_RESETEventArgs> NEED_RESET_Fired;

    private event EventHandler<SE.Nereda.Symbols.ValveS.OPDEventArgs> OPD_Fired;

    private event EventHandler<SE.Nereda.Symbols.ValveS.FB_FAILEventArgs> FB_FAIL_Fired;

    protected override void OnEndInit()
    {
      if (LOAD_PERS_DATA_Fired != null)
        AttachEventInput(0);
      if (NEED_RESET_Fired != null)
        AttachEventInput(1);
      if (OPD_Fired != null)
        AttachEventInput(2);
      if (FB_FAIL_Fired != null)
        AttachEventInput(3);

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
              LOAD_PERS_DATA_Fired(this, new SE.Nereda.Symbols.ValveS.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
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
          if (NEED_RESET_Fired != null)
          {
            try
            {
              NEED_RESET_Fired(this, new SE.Nereda.Symbols.ValveS.NEED_RESETEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","NEED_RESET_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 2:
          if (OPD_Fired != null)
          {
            try
            {
              OPD_Fired(this, new SE.Nereda.Symbols.ValveS.OPDEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","OPD_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 3:
          if (FB_FAIL_Fired != null)
          {
            try
            {
              FB_FAIL_Fired(this, new SE.Nereda.Symbols.ValveS.FB_FAILEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","FB_FAIL_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_RESET(System.Boolean Reset)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {Reset});
    }
    public bool FireEvent_RESET(SE.Nereda.Symbols.ValveS.RESETEventArgs ea)
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
#endregion #ValveS_HMI;

#endregion Definitions;
