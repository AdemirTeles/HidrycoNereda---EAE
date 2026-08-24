/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 6/15/2026
 * Time: 3:56 PM
 * 
 */
using System;
using NxtControl.GuiFramework;
using NxtControl.Services;

#region Definitions;
#region #GritScreenLogic_HMI;

namespace SE.Nereda.Symbols.GritScreenLogic
{

  public class GRAPHEventArgs : System.EventArgs
  {
    IHMIAccessorService accessorService;
    int channelId;
    int cookie; 
    int eventIndex;

    public GRAPHEventArgs(int channelId, int cookie, int eventIndex)
    {
      this.accessorService = (IHMIAccessorService)ServiceProvider.GetService(typeof(IHMIAccessorService));
      this.channelId = channelId;
      this.cookie = cookie;
      this.eventIndex = eventIndex;
    }
    public bool Get_Grafcet(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,0, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? Grafcet
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,0, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }


  }

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

  public class FB_GS_STATEEventArgs : System.EventArgs
  {
    IHMIAccessorService accessorService;
    int channelId;
    int cookie; 
    int eventIndex;

    public FB_GS_STATEEventArgs(int channelId, int cookie, int eventIndex)
    {
      this.accessorService = (IHMIAccessorService)ServiceProvider.GetService(typeof(IHMIAccessorService));
      this.channelId = channelId;
      this.cookie = cookie;
      this.eventIndex = eventIndex;
    }
    public bool Get_FbGritScreenRun(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,0, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? FbGritScreenRun
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,0, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }


  }

  public class NEED_RESET_SEventArgs : System.EventArgs
  {
    IHMIAccessorService accessorService;
    int channelId;
    int cookie; 
    int eventIndex;

    public NEED_RESET_SEventArgs(int channelId, int cookie, int eventIndex)
    {
      this.accessorService = (IHMIAccessorService)ServiceProvider.GetService(typeof(IHMIAccessorService));
      this.channelId = channelId;
      this.cookie = cookie;
      this.eventIndex = eventIndex;
    }
    public bool Get_NeedResetSafety(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,0, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? NeedResetSafety
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,0, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }


  }

  public class RUN_H_TEventArgs : System.EventArgs
  {
    IHMIAccessorService accessorService;
    int channelId;
    int cookie; 
    int eventIndex;

    public RUN_H_TEventArgs(int channelId, int cookie, int eventIndex)
    {
      this.accessorService = (IHMIAccessorService)ServiceProvider.GetService(typeof(IHMIAccessorService));
      this.channelId = channelId;
      this.cookie = cookie;
      this.eventIndex = eventIndex;
    }
    public bool Get_RunHoldT(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,0, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? RunHoldT
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

namespace SE.Nereda.Symbols.GritScreenLogic
{

  public class RUN_HOLD_SPEventArgs : System.EventArgs
  {
    public RUN_HOLD_SPEventArgs()
    {
    }
    private NxtControl.GuiFramework.Time? RunHoldTimeSp_field = null;
    public NxtControl.GuiFramework.Time? RunHoldTimeSp
    {
       get { return RunHoldTimeSp_field; }
       set { RunHoldTimeSp_field = value; }
    }

  }

  public class RESET_SAFETYEventArgs : System.EventArgs
  {
    public RESET_SAFETYEventArgs()
    {
    }
    private System.Boolean? ResetSafetyStop_field = null;
    public System.Boolean? ResetSafetyStop
    {
       get { return ResetSafetyStop_field; }
       set { ResetSafetyStop_field = value; }
    }

  }

}

namespace SE.Nereda.Symbols.GritScreenLogic
{
  partial class sDefault
  {

    private event EventHandler<SE.Nereda.Symbols.GritScreenLogic.GRAPHEventArgs> GRAPH_Fired;

    private event EventHandler<SE.Nereda.Symbols.GritScreenLogic.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    private event EventHandler<SE.Nereda.Symbols.GritScreenLogic.FB_GS_STATEEventArgs> FB_GS_STATE_Fired;

    private event EventHandler<SE.Nereda.Symbols.GritScreenLogic.NEED_RESET_SEventArgs> NEED_RESET_S_Fired;

    private event EventHandler<SE.Nereda.Symbols.GritScreenLogic.RUN_H_TEventArgs> RUN_H_T_Fired;

    protected override void OnEndInit()
    {
      if (GRAPH_Fired != null)
        AttachEventInput(0);
      if (LOAD_PERS_DATA_Fired != null)
        AttachEventInput(1);
      if (FB_GS_STATE_Fired != null)
        AttachEventInput(2);
      if (NEED_RESET_S_Fired != null)
        AttachEventInput(3);
      if (RUN_H_T_Fired != null)
        AttachEventInput(4);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (GRAPH_Fired != null)
          {
            try
            {
              GRAPH_Fired(this, new SE.Nereda.Symbols.GritScreenLogic.GRAPHEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","GRAPH_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 1:
          if (LOAD_PERS_DATA_Fired != null)
          {
            try
            {
              LOAD_PERS_DATA_Fired(this, new SE.Nereda.Symbols.GritScreenLogic.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","LOAD_PERS_DATA_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 2:
          if (FB_GS_STATE_Fired != null)
          {
            try
            {
              FB_GS_STATE_Fired(this, new SE.Nereda.Symbols.GritScreenLogic.FB_GS_STATEEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","FB_GS_STATE_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 3:
          if (NEED_RESET_S_Fired != null)
          {
            try
            {
              NEED_RESET_S_Fired(this, new SE.Nereda.Symbols.GritScreenLogic.NEED_RESET_SEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","NEED_RESET_S_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 4:
          if (RUN_H_T_Fired != null)
          {
            try
            {
              RUN_H_T_Fired(this, new SE.Nereda.Symbols.GritScreenLogic.RUN_H_TEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","RUN_H_T_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_RUN_HOLD_SP(NxtControl.GuiFramework.Time RunHoldTimeSp)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {RunHoldTimeSp});
    }
    public bool FireEvent_RUN_HOLD_SP(SE.Nereda.Symbols.GritScreenLogic.RUN_HOLD_SPEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.RunHoldTimeSp.HasValue) _values_[0] = ea.RunHoldTimeSp.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_RUN_HOLD_SP(NxtControl.GuiFramework.Time RunHoldTimeSp, bool ignore_RunHoldTimeSp)
    {
      object[] _values_ = new object[1];
      if (!ignore_RunHoldTimeSp) _values_[0] = RunHoldTimeSp;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_RESET_SAFETY(System.Boolean ResetSafetyStop)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {ResetSafetyStop});
    }
    public bool FireEvent_RESET_SAFETY(SE.Nereda.Symbols.GritScreenLogic.RESET_SAFETYEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.ResetSafetyStop.HasValue) _values_[0] = ea.ResetSafetyStop.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_RESET_SAFETY(System.Boolean ResetSafetyStop, bool ignore_ResetSafetyStop)
    {
      object[] _values_ = new object[1];
      if (!ignore_ResetSafetyStop) _values_[0] = ResetSafetyStop;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }

  }
}

namespace SE.Nereda.Symbols.GritScreenLogic
{
  partial class sGritScreen
  {

    private event EventHandler<SE.Nereda.Symbols.GritScreenLogic.GRAPHEventArgs> GRAPH_Fired;

    private event EventHandler<SE.Nereda.Symbols.GritScreenLogic.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    private event EventHandler<SE.Nereda.Symbols.GritScreenLogic.FB_GS_STATEEventArgs> FB_GS_STATE_Fired;

    private event EventHandler<SE.Nereda.Symbols.GritScreenLogic.NEED_RESET_SEventArgs> NEED_RESET_S_Fired;

    private event EventHandler<SE.Nereda.Symbols.GritScreenLogic.RUN_H_TEventArgs> RUN_H_T_Fired;

    protected override void OnEndInit()
    {
      if (GRAPH_Fired != null)
        AttachEventInput(0);
      if (LOAD_PERS_DATA_Fired != null)
        AttachEventInput(1);
      if (FB_GS_STATE_Fired != null)
        AttachEventInput(2);
      if (NEED_RESET_S_Fired != null)
        AttachEventInput(3);
      if (RUN_H_T_Fired != null)
        AttachEventInput(4);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (GRAPH_Fired != null)
          {
            try
            {
              GRAPH_Fired(this, new SE.Nereda.Symbols.GritScreenLogic.GRAPHEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","GRAPH_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 1:
          if (LOAD_PERS_DATA_Fired != null)
          {
            try
            {
              LOAD_PERS_DATA_Fired(this, new SE.Nereda.Symbols.GritScreenLogic.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","LOAD_PERS_DATA_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 2:
          if (FB_GS_STATE_Fired != null)
          {
            try
            {
              FB_GS_STATE_Fired(this, new SE.Nereda.Symbols.GritScreenLogic.FB_GS_STATEEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","FB_GS_STATE_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 3:
          if (NEED_RESET_S_Fired != null)
          {
            try
            {
              NEED_RESET_S_Fired(this, new SE.Nereda.Symbols.GritScreenLogic.NEED_RESET_SEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","NEED_RESET_S_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 4:
          if (RUN_H_T_Fired != null)
          {
            try
            {
              RUN_H_T_Fired(this, new SE.Nereda.Symbols.GritScreenLogic.RUN_H_TEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","RUN_H_T_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_RUN_HOLD_SP(NxtControl.GuiFramework.Time RunHoldTimeSp)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {RunHoldTimeSp});
    }
    public bool FireEvent_RUN_HOLD_SP(SE.Nereda.Symbols.GritScreenLogic.RUN_HOLD_SPEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.RunHoldTimeSp.HasValue) _values_[0] = ea.RunHoldTimeSp.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_RUN_HOLD_SP(NxtControl.GuiFramework.Time RunHoldTimeSp, bool ignore_RunHoldTimeSp)
    {
      object[] _values_ = new object[1];
      if (!ignore_RunHoldTimeSp) _values_[0] = RunHoldTimeSp;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_RESET_SAFETY(System.Boolean ResetSafetyStop)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {ResetSafetyStop});
    }
    public bool FireEvent_RESET_SAFETY(SE.Nereda.Symbols.GritScreenLogic.RESET_SAFETYEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.ResetSafetyStop.HasValue) _values_[0] = ea.ResetSafetyStop.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_RESET_SAFETY(System.Boolean ResetSafetyStop, bool ignore_ResetSafetyStop)
    {
      object[] _values_ = new object[1];
      if (!ignore_ResetSafetyStop) _values_[0] = ResetSafetyStop;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }

  }
}

namespace SE.Nereda.Symbols.GritScreenLogic
{
  partial class sResetSafetyStop
  {

    private event EventHandler<SE.Nereda.Symbols.GritScreenLogic.GRAPHEventArgs> GRAPH_Fired;

    private event EventHandler<SE.Nereda.Symbols.GritScreenLogic.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    private event EventHandler<SE.Nereda.Symbols.GritScreenLogic.FB_GS_STATEEventArgs> FB_GS_STATE_Fired;

    private event EventHandler<SE.Nereda.Symbols.GritScreenLogic.NEED_RESET_SEventArgs> NEED_RESET_S_Fired;

    private event EventHandler<SE.Nereda.Symbols.GritScreenLogic.RUN_H_TEventArgs> RUN_H_T_Fired;

    protected override void OnEndInit()
    {
      if (GRAPH_Fired != null)
        AttachEventInput(0);
      if (LOAD_PERS_DATA_Fired != null)
        AttachEventInput(1);
      if (FB_GS_STATE_Fired != null)
        AttachEventInput(2);
      if (NEED_RESET_S_Fired != null)
        AttachEventInput(3);
      if (RUN_H_T_Fired != null)
        AttachEventInput(4);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (GRAPH_Fired != null)
          {
            try
            {
              GRAPH_Fired(this, new SE.Nereda.Symbols.GritScreenLogic.GRAPHEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","GRAPH_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 1:
          if (LOAD_PERS_DATA_Fired != null)
          {
            try
            {
              LOAD_PERS_DATA_Fired(this, new SE.Nereda.Symbols.GritScreenLogic.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","LOAD_PERS_DATA_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 2:
          if (FB_GS_STATE_Fired != null)
          {
            try
            {
              FB_GS_STATE_Fired(this, new SE.Nereda.Symbols.GritScreenLogic.FB_GS_STATEEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","FB_GS_STATE_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 3:
          if (NEED_RESET_S_Fired != null)
          {
            try
            {
              NEED_RESET_S_Fired(this, new SE.Nereda.Symbols.GritScreenLogic.NEED_RESET_SEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","NEED_RESET_S_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 4:
          if (RUN_H_T_Fired != null)
          {
            try
            {
              RUN_H_T_Fired(this, new SE.Nereda.Symbols.GritScreenLogic.RUN_H_TEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","RUN_H_T_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_RUN_HOLD_SP(NxtControl.GuiFramework.Time RunHoldTimeSp)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {RunHoldTimeSp});
    }
    public bool FireEvent_RUN_HOLD_SP(SE.Nereda.Symbols.GritScreenLogic.RUN_HOLD_SPEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.RunHoldTimeSp.HasValue) _values_[0] = ea.RunHoldTimeSp.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_RUN_HOLD_SP(NxtControl.GuiFramework.Time RunHoldTimeSp, bool ignore_RunHoldTimeSp)
    {
      object[] _values_ = new object[1];
      if (!ignore_RunHoldTimeSp) _values_[0] = RunHoldTimeSp;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_RESET_SAFETY(System.Boolean ResetSafetyStop)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {ResetSafetyStop});
    }
    public bool FireEvent_RESET_SAFETY(SE.Nereda.Symbols.GritScreenLogic.RESET_SAFETYEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.ResetSafetyStop.HasValue) _values_[0] = ea.ResetSafetyStop.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_RESET_SAFETY(System.Boolean ResetSafetyStop, bool ignore_ResetSafetyStop)
    {
      object[] _values_ = new object[1];
      if (!ignore_ResetSafetyStop) _values_[0] = ResetSafetyStop;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }

  }
}

namespace SE.Nereda.Symbols.GritScreenLogic
{
  partial class sResetSafetyStopNotif
  {

    private event EventHandler<SE.Nereda.Symbols.GritScreenLogic.GRAPHEventArgs> GRAPH_Fired;

    private event EventHandler<SE.Nereda.Symbols.GritScreenLogic.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    private event EventHandler<SE.Nereda.Symbols.GritScreenLogic.FB_GS_STATEEventArgs> FB_GS_STATE_Fired;

    private event EventHandler<SE.Nereda.Symbols.GritScreenLogic.NEED_RESET_SEventArgs> NEED_RESET_S_Fired;

    private event EventHandler<SE.Nereda.Symbols.GritScreenLogic.RUN_H_TEventArgs> RUN_H_T_Fired;

    protected override void OnEndInit()
    {
      if (GRAPH_Fired != null)
        AttachEventInput(0);
      if (LOAD_PERS_DATA_Fired != null)
        AttachEventInput(1);
      if (FB_GS_STATE_Fired != null)
        AttachEventInput(2);
      if (NEED_RESET_S_Fired != null)
        AttachEventInput(3);
      if (RUN_H_T_Fired != null)
        AttachEventInput(4);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (GRAPH_Fired != null)
          {
            try
            {
              GRAPH_Fired(this, new SE.Nereda.Symbols.GritScreenLogic.GRAPHEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","GRAPH_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 1:
          if (LOAD_PERS_DATA_Fired != null)
          {
            try
            {
              LOAD_PERS_DATA_Fired(this, new SE.Nereda.Symbols.GritScreenLogic.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","LOAD_PERS_DATA_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 2:
          if (FB_GS_STATE_Fired != null)
          {
            try
            {
              FB_GS_STATE_Fired(this, new SE.Nereda.Symbols.GritScreenLogic.FB_GS_STATEEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","FB_GS_STATE_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 3:
          if (NEED_RESET_S_Fired != null)
          {
            try
            {
              NEED_RESET_S_Fired(this, new SE.Nereda.Symbols.GritScreenLogic.NEED_RESET_SEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","NEED_RESET_S_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 4:
          if (RUN_H_T_Fired != null)
          {
            try
            {
              RUN_H_T_Fired(this, new SE.Nereda.Symbols.GritScreenLogic.RUN_H_TEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","RUN_H_T_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_RUN_HOLD_SP(NxtControl.GuiFramework.Time RunHoldTimeSp)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {RunHoldTimeSp});
    }
    public bool FireEvent_RUN_HOLD_SP(SE.Nereda.Symbols.GritScreenLogic.RUN_HOLD_SPEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.RunHoldTimeSp.HasValue) _values_[0] = ea.RunHoldTimeSp.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_RUN_HOLD_SP(NxtControl.GuiFramework.Time RunHoldTimeSp, bool ignore_RunHoldTimeSp)
    {
      object[] _values_ = new object[1];
      if (!ignore_RunHoldTimeSp) _values_[0] = RunHoldTimeSp;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_RESET_SAFETY(System.Boolean ResetSafetyStop)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {ResetSafetyStop});
    }
    public bool FireEvent_RESET_SAFETY(SE.Nereda.Symbols.GritScreenLogic.RESET_SAFETYEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.ResetSafetyStop.HasValue) _values_[0] = ea.ResetSafetyStop.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_RESET_SAFETY(System.Boolean ResetSafetyStop, bool ignore_ResetSafetyStop)
    {
      object[] _values_ = new object[1];
      if (!ignore_ResetSafetyStop) _values_[0] = ResetSafetyStop;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }

  }
}

namespace SE.Nereda.Symbols.GritScreenLogic
{
  partial class sRunHoldTime
  {

    private event EventHandler<SE.Nereda.Symbols.GritScreenLogic.GRAPHEventArgs> GRAPH_Fired;

    private event EventHandler<SE.Nereda.Symbols.GritScreenLogic.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    private event EventHandler<SE.Nereda.Symbols.GritScreenLogic.FB_GS_STATEEventArgs> FB_GS_STATE_Fired;

    private event EventHandler<SE.Nereda.Symbols.GritScreenLogic.NEED_RESET_SEventArgs> NEED_RESET_S_Fired;

    private event EventHandler<SE.Nereda.Symbols.GritScreenLogic.RUN_H_TEventArgs> RUN_H_T_Fired;

    protected override void OnEndInit()
    {
      if (GRAPH_Fired != null)
        AttachEventInput(0);
      if (LOAD_PERS_DATA_Fired != null)
        AttachEventInput(1);
      if (FB_GS_STATE_Fired != null)
        AttachEventInput(2);
      if (NEED_RESET_S_Fired != null)
        AttachEventInput(3);
      if (RUN_H_T_Fired != null)
        AttachEventInput(4);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (GRAPH_Fired != null)
          {
            try
            {
              GRAPH_Fired(this, new SE.Nereda.Symbols.GritScreenLogic.GRAPHEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","GRAPH_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 1:
          if (LOAD_PERS_DATA_Fired != null)
          {
            try
            {
              LOAD_PERS_DATA_Fired(this, new SE.Nereda.Symbols.GritScreenLogic.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","LOAD_PERS_DATA_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 2:
          if (FB_GS_STATE_Fired != null)
          {
            try
            {
              FB_GS_STATE_Fired(this, new SE.Nereda.Symbols.GritScreenLogic.FB_GS_STATEEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","FB_GS_STATE_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 3:
          if (NEED_RESET_S_Fired != null)
          {
            try
            {
              NEED_RESET_S_Fired(this, new SE.Nereda.Symbols.GritScreenLogic.NEED_RESET_SEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","NEED_RESET_S_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 4:
          if (RUN_H_T_Fired != null)
          {
            try
            {
              RUN_H_T_Fired(this, new SE.Nereda.Symbols.GritScreenLogic.RUN_H_TEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","RUN_H_T_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_RUN_HOLD_SP(NxtControl.GuiFramework.Time RunHoldTimeSp)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {RunHoldTimeSp});
    }
    public bool FireEvent_RUN_HOLD_SP(SE.Nereda.Symbols.GritScreenLogic.RUN_HOLD_SPEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.RunHoldTimeSp.HasValue) _values_[0] = ea.RunHoldTimeSp.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_RUN_HOLD_SP(NxtControl.GuiFramework.Time RunHoldTimeSp, bool ignore_RunHoldTimeSp)
    {
      object[] _values_ = new object[1];
      if (!ignore_RunHoldTimeSp) _values_[0] = RunHoldTimeSp;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_RESET_SAFETY(System.Boolean ResetSafetyStop)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {ResetSafetyStop});
    }
    public bool FireEvent_RESET_SAFETY(SE.Nereda.Symbols.GritScreenLogic.RESET_SAFETYEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.ResetSafetyStop.HasValue) _values_[0] = ea.ResetSafetyStop.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_RESET_SAFETY(System.Boolean ResetSafetyStop, bool ignore_ResetSafetyStop)
    {
      object[] _values_ = new object[1];
      if (!ignore_ResetSafetyStop) _values_[0] = ResetSafetyStop;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }

  }
}
#endregion #GritScreenLogic_HMI;

#endregion Definitions;
