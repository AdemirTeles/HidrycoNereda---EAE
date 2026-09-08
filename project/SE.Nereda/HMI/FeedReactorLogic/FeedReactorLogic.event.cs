/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 6/13/2026
 * Time: 7:00 PM
 * 
 */
using System;
using NxtControl.GuiFramework;
using NxtControl.Services;

#region Definitions;
#region #FeedReactorLogic_HMI;

namespace SE.Nereda.Symbols.FeedReactorLogic
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

  public class RESET_BTNEventArgs : System.EventArgs
  {
    IHMIAccessorService accessorService;
    int channelId;
    int cookie; 
    int eventIndex;

    public RESET_BTNEventArgs(int channelId, int cookie, int eventIndex)
    {
      this.accessorService = (IHMIAccessorService)ServiceProvider.GetService(typeof(IHMIAccessorService));
      this.channelId = channelId;
      this.cookie = cookie;
      this.eventIndex = eventIndex;
    }

  }

}

namespace SE.Nereda.Symbols.FeedReactorLogic
{

  public class RESET_LOGICEventArgs : System.EventArgs
  {
    public RESET_LOGICEventArgs()
    {
    }
    private System.Boolean? ResetLogic_field = null;
    public System.Boolean? ResetLogic
    {
       get { return ResetLogic_field; }
       set { ResetLogic_field = value; }
    }

  }

  public class RESET_LO_LO_FEventArgs : System.EventArgs
  {
    public RESET_LO_LO_FEventArgs()
    {
    }
    private System.Boolean? ResetLoLoFlow_field = null;
    public System.Boolean? ResetLoLoFlow
    {
       get { return ResetLoLoFlow_field; }
       set { ResetLoLoFlow_field = value; }
    }

  }

  public class P_CNGEventArgs : System.EventArgs
  {
    public P_CNGEventArgs()
    {
    }
    private System.Boolean? OneP3PConfig_field = null;
    public System.Boolean? OneP3PConfig
    {
       get { return OneP3PConfig_field; }
       set { OneP3PConfig_field = value; }
    }

  }

  public class PAREventArgs : System.EventArgs
  {
    public PAREventArgs()
    {
    }
    private System.Single? MaxCapacityOnePump_field = null;
    public System.Single? MaxCapacityOnePump
    {
       get { return MaxCapacityOnePump_field; }
       set { MaxCapacityOnePump_field = value; }
    }
    private System.Single? C2Capacity_field = null;
    public System.Single? C2Capacity
    {
       get { return C2Capacity_field; }
       set { C2Capacity_field = value; }
    }
    private System.Single? C3Capacity_field = null;
    public System.Single? C3Capacity
    {
       get { return C3Capacity_field; }
       set { C3Capacity_field = value; }
    }
    private NxtControl.GuiFramework.Time? RestartWaitingTime_field = null;
    public NxtControl.GuiFramework.Time? RestartWaitingTime
    {
       get { return RestartWaitingTime_field; }
       set { RestartWaitingTime_field = value; }
    }

  }

}

namespace SE.Nereda.Symbols.FeedReactorLogic
{
  partial class sDefault
  {

    private event EventHandler<SE.Nereda.Symbols.FeedReactorLogic.GRAPHEventArgs> GRAPH_Fired;

    private event EventHandler<SE.Nereda.Symbols.FeedReactorLogic.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    private event EventHandler<SE.Nereda.Symbols.FeedReactorLogic.RESET_BTNEventArgs> RESET_BTN_Fired;

    protected override void OnEndInit()
    {
      if (GRAPH_Fired != null)
        AttachEventInput(0);
      if (LOAD_PERS_DATA_Fired != null)
        AttachEventInput(1);
      if (RESET_BTN_Fired != null)
        AttachEventInput(2);

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
              GRAPH_Fired(this, new SE.Nereda.Symbols.FeedReactorLogic.GRAPHEventArgs(channelId, cookie, eventIndex));
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
              LOAD_PERS_DATA_Fired(this, new SE.Nereda.Symbols.FeedReactorLogic.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
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
          if (RESET_BTN_Fired != null)
          {
            try
            {
              RESET_BTN_Fired(this, new SE.Nereda.Symbols.FeedReactorLogic.RESET_BTNEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","RESET_BTN_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_RESET_LOGIC(System.Boolean ResetLogic)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {ResetLogic});
    }
    public bool FireEvent_RESET_LOGIC(SE.Nereda.Symbols.FeedReactorLogic.RESET_LOGICEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.ResetLogic.HasValue) _values_[0] = ea.ResetLogic.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_RESET_LOGIC(System.Boolean ResetLogic, bool ignore_ResetLogic)
    {
      object[] _values_ = new object[1];
      if (!ignore_ResetLogic) _values_[0] = ResetLogic;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_RESET_LO_LO_F(System.Boolean ResetLoLoFlow)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {ResetLoLoFlow});
    }
    public bool FireEvent_RESET_LO_LO_F(SE.Nereda.Symbols.FeedReactorLogic.RESET_LO_LO_FEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.ResetLoLoFlow.HasValue) _values_[0] = ea.ResetLoLoFlow.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_RESET_LO_LO_F(System.Boolean ResetLoLoFlow, bool ignore_ResetLoLoFlow)
    {
      object[] _values_ = new object[1];
      if (!ignore_ResetLoLoFlow) _values_[0] = ResetLoLoFlow;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_P_CNG(System.Boolean OneP3PConfig)
    {
      return ((IHMIAccessorOutput)this).FireEvent(2, new object[] {OneP3PConfig});
    }
    public bool FireEvent_P_CNG(SE.Nereda.Symbols.FeedReactorLogic.P_CNGEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.OneP3PConfig.HasValue) _values_[0] = ea.OneP3PConfig.Value;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_P_CNG(System.Boolean OneP3PConfig, bool ignore_OneP3PConfig)
    {
      object[] _values_ = new object[1];
      if (!ignore_OneP3PConfig) _values_[0] = OneP3PConfig;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_PAR(System.Single MaxCapacityOnePump, System.Single C2Capacity, System.Single C3Capacity, NxtControl.GuiFramework.Time RestartWaitingTime)
    {
      return ((IHMIAccessorOutput)this).FireEvent(3, new object[] {MaxCapacityOnePump, C2Capacity, C3Capacity, RestartWaitingTime});
    }
    public bool FireEvent_PAR(SE.Nereda.Symbols.FeedReactorLogic.PAREventArgs ea)
    {
      object[] _values_ = new object[4];
      if (ea.MaxCapacityOnePump.HasValue) _values_[0] = ea.MaxCapacityOnePump.Value;
      if (ea.C2Capacity.HasValue) _values_[1] = ea.C2Capacity.Value;
      if (ea.C3Capacity.HasValue) _values_[2] = ea.C3Capacity.Value;
      if (ea.RestartWaitingTime.HasValue) _values_[3] = ea.RestartWaitingTime.Value;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_PAR(System.Single MaxCapacityOnePump, bool ignore_MaxCapacityOnePump, System.Single C2Capacity, bool ignore_C2Capacity, System.Single C3Capacity, bool ignore_C3Capacity, NxtControl.GuiFramework.Time RestartWaitingTime, bool ignore_RestartWaitingTime)
    {
      object[] _values_ = new object[4];
      if (!ignore_MaxCapacityOnePump) _values_[0] = MaxCapacityOnePump;
      if (!ignore_C2Capacity) _values_[1] = C2Capacity;
      if (!ignore_C3Capacity) _values_[2] = C3Capacity;
      if (!ignore_RestartWaitingTime) _values_[3] = RestartWaitingTime;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }

  }
}

namespace SE.Nereda.Symbols.FeedReactorLogic
{
  partial class sPID
  {

    private event EventHandler<SE.Nereda.Symbols.FeedReactorLogic.GRAPHEventArgs> GRAPH_Fired;

    private event EventHandler<SE.Nereda.Symbols.FeedReactorLogic.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    private event EventHandler<SE.Nereda.Symbols.FeedReactorLogic.RESET_BTNEventArgs> RESET_BTN_Fired;

    protected override void OnEndInit()
    {
      if (GRAPH_Fired != null)
        AttachEventInput(0);
      if (LOAD_PERS_DATA_Fired != null)
        AttachEventInput(1);
      if (RESET_BTN_Fired != null)
        AttachEventInput(2);

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
              GRAPH_Fired(this, new SE.Nereda.Symbols.FeedReactorLogic.GRAPHEventArgs(channelId, cookie, eventIndex));
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
              LOAD_PERS_DATA_Fired(this, new SE.Nereda.Symbols.FeedReactorLogic.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
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
          if (RESET_BTN_Fired != null)
          {
            try
            {
              RESET_BTN_Fired(this, new SE.Nereda.Symbols.FeedReactorLogic.RESET_BTNEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","RESET_BTN_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_RESET_LOGIC(System.Boolean ResetLogic)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {ResetLogic});
    }
    public bool FireEvent_RESET_LOGIC(SE.Nereda.Symbols.FeedReactorLogic.RESET_LOGICEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.ResetLogic.HasValue) _values_[0] = ea.ResetLogic.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_RESET_LOGIC(System.Boolean ResetLogic, bool ignore_ResetLogic)
    {
      object[] _values_ = new object[1];
      if (!ignore_ResetLogic) _values_[0] = ResetLogic;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_RESET_LO_LO_F(System.Boolean ResetLoLoFlow)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {ResetLoLoFlow});
    }
    public bool FireEvent_RESET_LO_LO_F(SE.Nereda.Symbols.FeedReactorLogic.RESET_LO_LO_FEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.ResetLoLoFlow.HasValue) _values_[0] = ea.ResetLoLoFlow.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_RESET_LO_LO_F(System.Boolean ResetLoLoFlow, bool ignore_ResetLoLoFlow)
    {
      object[] _values_ = new object[1];
      if (!ignore_ResetLoLoFlow) _values_[0] = ResetLoLoFlow;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_P_CNG(System.Boolean OneP3PConfig)
    {
      return ((IHMIAccessorOutput)this).FireEvent(2, new object[] {OneP3PConfig});
    }
    public bool FireEvent_P_CNG(SE.Nereda.Symbols.FeedReactorLogic.P_CNGEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.OneP3PConfig.HasValue) _values_[0] = ea.OneP3PConfig.Value;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_P_CNG(System.Boolean OneP3PConfig, bool ignore_OneP3PConfig)
    {
      object[] _values_ = new object[1];
      if (!ignore_OneP3PConfig) _values_[0] = OneP3PConfig;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_PAR(System.Single MaxCapacityOnePump, System.Single C2Capacity, System.Single C3Capacity, NxtControl.GuiFramework.Time RestartWaitingTime)
    {
      return ((IHMIAccessorOutput)this).FireEvent(3, new object[] {MaxCapacityOnePump, C2Capacity, C3Capacity, RestartWaitingTime});
    }
    public bool FireEvent_PAR(SE.Nereda.Symbols.FeedReactorLogic.PAREventArgs ea)
    {
      object[] _values_ = new object[4];
      if (ea.MaxCapacityOnePump.HasValue) _values_[0] = ea.MaxCapacityOnePump.Value;
      if (ea.C2Capacity.HasValue) _values_[1] = ea.C2Capacity.Value;
      if (ea.C3Capacity.HasValue) _values_[2] = ea.C3Capacity.Value;
      if (ea.RestartWaitingTime.HasValue) _values_[3] = ea.RestartWaitingTime.Value;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_PAR(System.Single MaxCapacityOnePump, bool ignore_MaxCapacityOnePump, System.Single C2Capacity, bool ignore_C2Capacity, System.Single C3Capacity, bool ignore_C3Capacity, NxtControl.GuiFramework.Time RestartWaitingTime, bool ignore_RestartWaitingTime)
    {
      object[] _values_ = new object[4];
      if (!ignore_MaxCapacityOnePump) _values_[0] = MaxCapacityOnePump;
      if (!ignore_C2Capacity) _values_[1] = C2Capacity;
      if (!ignore_C3Capacity) _values_[2] = C3Capacity;
      if (!ignore_RestartWaitingTime) _values_[3] = RestartWaitingTime;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }

  }
}

namespace SE.Nereda.Faceplates.FeedReactorLogic
{
  partial class fpPID
  {

    private event EventHandler<SE.Nereda.Symbols.FeedReactorLogic.GRAPHEventArgs> GRAPH_Fired;

    private event EventHandler<SE.Nereda.Symbols.FeedReactorLogic.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    private event EventHandler<SE.Nereda.Symbols.FeedReactorLogic.RESET_BTNEventArgs> RESET_BTN_Fired;

    protected override void OnEndInit()
    {
      if (GRAPH_Fired != null)
        AttachEventInput(0);
      if (LOAD_PERS_DATA_Fired != null)
        AttachEventInput(1);
      if (RESET_BTN_Fired != null)
        AttachEventInput(2);

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
              GRAPH_Fired(this, new SE.Nereda.Symbols.FeedReactorLogic.GRAPHEventArgs(channelId, cookie, eventIndex));
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
              LOAD_PERS_DATA_Fired(this, new SE.Nereda.Symbols.FeedReactorLogic.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
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
          if (RESET_BTN_Fired != null)
          {
            try
            {
              RESET_BTN_Fired(this, new SE.Nereda.Symbols.FeedReactorLogic.RESET_BTNEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","RESET_BTN_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_RESET_LOGIC(System.Boolean ResetLogic)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {ResetLogic});
    }
    public bool FireEvent_RESET_LOGIC(SE.Nereda.Symbols.FeedReactorLogic.RESET_LOGICEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.ResetLogic.HasValue) _values_[0] = ea.ResetLogic.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_RESET_LOGIC(System.Boolean ResetLogic, bool ignore_ResetLogic)
    {
      object[] _values_ = new object[1];
      if (!ignore_ResetLogic) _values_[0] = ResetLogic;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_RESET_LO_LO_F(System.Boolean ResetLoLoFlow)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {ResetLoLoFlow});
    }
    public bool FireEvent_RESET_LO_LO_F(SE.Nereda.Symbols.FeedReactorLogic.RESET_LO_LO_FEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.ResetLoLoFlow.HasValue) _values_[0] = ea.ResetLoLoFlow.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_RESET_LO_LO_F(System.Boolean ResetLoLoFlow, bool ignore_ResetLoLoFlow)
    {
      object[] _values_ = new object[1];
      if (!ignore_ResetLoLoFlow) _values_[0] = ResetLoLoFlow;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_P_CNG(System.Boolean OneP3PConfig)
    {
      return ((IHMIAccessorOutput)this).FireEvent(2, new object[] {OneP3PConfig});
    }
    public bool FireEvent_P_CNG(SE.Nereda.Symbols.FeedReactorLogic.P_CNGEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.OneP3PConfig.HasValue) _values_[0] = ea.OneP3PConfig.Value;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_P_CNG(System.Boolean OneP3PConfig, bool ignore_OneP3PConfig)
    {
      object[] _values_ = new object[1];
      if (!ignore_OneP3PConfig) _values_[0] = OneP3PConfig;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_PAR(System.Single MaxCapacityOnePump, System.Single C2Capacity, System.Single C3Capacity, NxtControl.GuiFramework.Time RestartWaitingTime)
    {
      return ((IHMIAccessorOutput)this).FireEvent(3, new object[] {MaxCapacityOnePump, C2Capacity, C3Capacity, RestartWaitingTime});
    }
    public bool FireEvent_PAR(SE.Nereda.Symbols.FeedReactorLogic.PAREventArgs ea)
    {
      object[] _values_ = new object[4];
      if (ea.MaxCapacityOnePump.HasValue) _values_[0] = ea.MaxCapacityOnePump.Value;
      if (ea.C2Capacity.HasValue) _values_[1] = ea.C2Capacity.Value;
      if (ea.C3Capacity.HasValue) _values_[2] = ea.C3Capacity.Value;
      if (ea.RestartWaitingTime.HasValue) _values_[3] = ea.RestartWaitingTime.Value;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_PAR(System.Single MaxCapacityOnePump, bool ignore_MaxCapacityOnePump, System.Single C2Capacity, bool ignore_C2Capacity, System.Single C3Capacity, bool ignore_C3Capacity, NxtControl.GuiFramework.Time RestartWaitingTime, bool ignore_RestartWaitingTime)
    {
      object[] _values_ = new object[4];
      if (!ignore_MaxCapacityOnePump) _values_[0] = MaxCapacityOnePump;
      if (!ignore_C2Capacity) _values_[1] = C2Capacity;
      if (!ignore_C3Capacity) _values_[2] = C3Capacity;
      if (!ignore_RestartWaitingTime) _values_[3] = RestartWaitingTime;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }

  }
}

namespace SE.Nereda.Symbols.FeedReactorLogic
{
  partial class sGrafcet
  {

    private event EventHandler<SE.Nereda.Symbols.FeedReactorLogic.GRAPHEventArgs> GRAPH_Fired;

    private event EventHandler<SE.Nereda.Symbols.FeedReactorLogic.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    private event EventHandler<SE.Nereda.Symbols.FeedReactorLogic.RESET_BTNEventArgs> RESET_BTN_Fired;

    protected override void OnEndInit()
    {
      if (GRAPH_Fired != null)
        AttachEventInput(0);
      if (LOAD_PERS_DATA_Fired != null)
        AttachEventInput(1);
      if (RESET_BTN_Fired != null)
        AttachEventInput(2);

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
              GRAPH_Fired(this, new SE.Nereda.Symbols.FeedReactorLogic.GRAPHEventArgs(channelId, cookie, eventIndex));
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
              LOAD_PERS_DATA_Fired(this, new SE.Nereda.Symbols.FeedReactorLogic.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
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
          if (RESET_BTN_Fired != null)
          {
            try
            {
              RESET_BTN_Fired(this, new SE.Nereda.Symbols.FeedReactorLogic.RESET_BTNEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","RESET_BTN_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_RESET_LOGIC(System.Boolean ResetLogic)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {ResetLogic});
    }
    public bool FireEvent_RESET_LOGIC(SE.Nereda.Symbols.FeedReactorLogic.RESET_LOGICEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.ResetLogic.HasValue) _values_[0] = ea.ResetLogic.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_RESET_LOGIC(System.Boolean ResetLogic, bool ignore_ResetLogic)
    {
      object[] _values_ = new object[1];
      if (!ignore_ResetLogic) _values_[0] = ResetLogic;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_RESET_LO_LO_F(System.Boolean ResetLoLoFlow)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {ResetLoLoFlow});
    }
    public bool FireEvent_RESET_LO_LO_F(SE.Nereda.Symbols.FeedReactorLogic.RESET_LO_LO_FEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.ResetLoLoFlow.HasValue) _values_[0] = ea.ResetLoLoFlow.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_RESET_LO_LO_F(System.Boolean ResetLoLoFlow, bool ignore_ResetLoLoFlow)
    {
      object[] _values_ = new object[1];
      if (!ignore_ResetLoLoFlow) _values_[0] = ResetLoLoFlow;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_P_CNG(System.Boolean OneP3PConfig)
    {
      return ((IHMIAccessorOutput)this).FireEvent(2, new object[] {OneP3PConfig});
    }
    public bool FireEvent_P_CNG(SE.Nereda.Symbols.FeedReactorLogic.P_CNGEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.OneP3PConfig.HasValue) _values_[0] = ea.OneP3PConfig.Value;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_P_CNG(System.Boolean OneP3PConfig, bool ignore_OneP3PConfig)
    {
      object[] _values_ = new object[1];
      if (!ignore_OneP3PConfig) _values_[0] = OneP3PConfig;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_PAR(System.Single MaxCapacityOnePump, System.Single C2Capacity, System.Single C3Capacity, NxtControl.GuiFramework.Time RestartWaitingTime)
    {
      return ((IHMIAccessorOutput)this).FireEvent(3, new object[] {MaxCapacityOnePump, C2Capacity, C3Capacity, RestartWaitingTime});
    }
    public bool FireEvent_PAR(SE.Nereda.Symbols.FeedReactorLogic.PAREventArgs ea)
    {
      object[] _values_ = new object[4];
      if (ea.MaxCapacityOnePump.HasValue) _values_[0] = ea.MaxCapacityOnePump.Value;
      if (ea.C2Capacity.HasValue) _values_[1] = ea.C2Capacity.Value;
      if (ea.C3Capacity.HasValue) _values_[2] = ea.C3Capacity.Value;
      if (ea.RestartWaitingTime.HasValue) _values_[3] = ea.RestartWaitingTime.Value;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_PAR(System.Single MaxCapacityOnePump, bool ignore_MaxCapacityOnePump, System.Single C2Capacity, bool ignore_C2Capacity, System.Single C3Capacity, bool ignore_C3Capacity, NxtControl.GuiFramework.Time RestartWaitingTime, bool ignore_RestartWaitingTime)
    {
      object[] _values_ = new object[4];
      if (!ignore_MaxCapacityOnePump) _values_[0] = MaxCapacityOnePump;
      if (!ignore_C2Capacity) _values_[1] = C2Capacity;
      if (!ignore_C3Capacity) _values_[2] = C3Capacity;
      if (!ignore_RestartWaitingTime) _values_[3] = RestartWaitingTime;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }

  }
}
#endregion #FeedReactorLogic_HMI;

#endregion Definitions;
