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
#region #FeedInfluentLogic_HMI;

namespace SE.Nereda.Symbols.FeedInfluentLogic
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

  public class FB_LEVEL_SPEventArgs : System.EventArgs
  {
    IHMIAccessorService accessorService;
    int channelId;
    int cookie; 
    int eventIndex;

    public FB_LEVEL_SPEventArgs(int channelId, int cookie, int eventIndex)
    {
      this.accessorService = (IHMIAccessorService)ServiceProvider.GetService(typeof(IHMIAccessorService));
      this.channelId = channelId;
      this.cookie = cookie;
      this.eventIndex = eventIndex;
    }
    public bool Get_iStartLevelSp(ref System.Single value)
    {
      if (accessorService == null)
        return false;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,0, ref var);
      if (ret) value = (System.Single) var;
      return ret;
    }

    public System.Single? iStartLevelSp
    { get {
      if (accessorService == null)
        return null;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,0, ref var);
      if (!ret) return null;
      return (System.Single) var;
    }  }

    public bool Get_iStopLevelSp(ref System.Single value)
    {
      if (accessorService == null)
        return false;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,1, ref var);
      if (ret) value = (System.Single) var;
      return ret;
    }

    public System.Single? iStopLevelSp
    { get {
      if (accessorService == null)
        return null;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,1, ref var);
      if (!ret) return null;
      return (System.Single) var;
    }  }

    public bool Get_iBreakPointSp(ref System.Single value)
    {
      if (accessorService == null)
        return false;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,2, ref var);
      if (ret) value = (System.Single) var;
      return ret;
    }

    public System.Single? iBreakPointSp
    { get {
      if (accessorService == null)
        return null;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,2, ref var);
      if (!ret) return null;
      return (System.Single) var;
    }  }


  }

  public class HI_HIEventArgs : System.EventArgs
  {
    IHMIAccessorService accessorService;
    int channelId;
    int cookie; 
    int eventIndex;

    public HI_HIEventArgs(int channelId, int cookie, int eventIndex)
    {
      this.accessorService = (IHMIAccessorService)ServiceProvider.GetService(typeof(IHMIAccessorService));
      this.channelId = channelId;
      this.cookie = cookie;
      this.eventIndex = eventIndex;
    }
    public bool Get_HiHiSB(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,0, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? HiHiSB
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,0, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_HiHiCalamity(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,1, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? HiHiCalamity
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,1, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_SwitchLevelCalamity(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,2, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? SwitchLevelCalamity
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,2, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }


  }

  public class FREEZEEventArgs : System.EventArgs
  {
    IHMIAccessorService accessorService;
    int channelId;
    int cookie; 
    int eventIndex;

    public FREEZEEventArgs(int channelId, int cookie, int eventIndex)
    {
      this.accessorService = (IHMIAccessorService)ServiceProvider.GetService(typeof(IHMIAccessorService));
      this.channelId = channelId;
      this.cookie = cookie;
      this.eventIndex = eventIndex;
    }
    public bool Get_FreezeMode(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,0, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? FreezeMode
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,0, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }


  }

  public class RESET_BTNSEventArgs : System.EventArgs
  {
    IHMIAccessorService accessorService;
    int channelId;
    int cookie; 
    int eventIndex;

    public RESET_BTNSEventArgs(int channelId, int cookie, int eventIndex)
    {
      this.accessorService = (IHMIAccessorService)ServiceProvider.GetService(typeof(IHMIAccessorService));
      this.channelId = channelId;
      this.cookie = cookie;
      this.eventIndex = eventIndex;
    }

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

}

namespace SE.Nereda.Symbols.FeedInfluentLogic
{

  public class CNF_DUR_SPEventArgs : System.EventArgs
  {
    public CNF_DUR_SPEventArgs()
    {
    }
    private NxtControl.GuiFramework.Time? FreezRunDurSp_field = null;
    public NxtControl.GuiFramework.Time? FreezRunDurSp
    {
       get { return FreezRunDurSp_field; }
       set { FreezRunDurSp_field = value; }
    }
    private NxtControl.GuiFramework.Time? FreezStopDurSp_field = null;
    public NxtControl.GuiFramework.Time? FreezStopDurSp
    {
       get { return FreezStopDurSp_field; }
       set { FreezStopDurSp_field = value; }
    }
    private NxtControl.GuiFramework.Time? FT95FlowPvWaitTime_field = null;
    public NxtControl.GuiFramework.Time? FT95FlowPvWaitTime
    {
       get { return FT95FlowPvWaitTime_field; }
       set { FT95FlowPvWaitTime_field = value; }
    }

  }

  public class CNF_FREEZ_SPEventArgs : System.EventArgs
  {
    public CNF_FREEZ_SPEventArgs()
    {
    }
    private System.Single? FreezWeatherSp_field = null;
    public System.Single? FreezWeatherSp
    {
       get { return FreezWeatherSp_field; }
       set { FreezWeatherSp_field = value; }
    }

  }

  public class CNF_RESETEventArgs : System.EventArgs
  {
    public CNF_RESETEventArgs()
    {
    }
    private System.Boolean? ResetLogic_field = null;
    public System.Boolean? ResetLogic
    {
       get { return ResetLogic_field; }
       set { ResetLogic_field = value; }
    }

  }

  public class CNF_SPEventArgs : System.EventArgs
  {
    public CNF_SPEventArgs()
    {
    }
    private System.Single? StartLevelSp_field = null;
    public System.Single? StartLevelSp
    {
       get { return StartLevelSp_field; }
       set { StartLevelSp_field = value; }
    }
    private System.Single? StopLevelSp_field = null;
    public System.Single? StopLevelSp
    {
       get { return StopLevelSp_field; }
       set { StopLevelSp_field = value; }
    }
    private System.Single? BreakPointSp_field = null;
    public System.Single? BreakPointSp
    {
       get { return BreakPointSp_field; }
       set { BreakPointSp_field = value; }
    }
    private System.Single? MaxFlowSp_field = null;
    public System.Single? MaxFlowSp
    {
       get { return MaxFlowSp_field; }
       set { MaxFlowSp_field = value; }
    }
    private NxtControl.GuiFramework.Time? FT95FlowPvWaitTime_field = null;
    public NxtControl.GuiFramework.Time? FT95FlowPvWaitTime
    {
       get { return FT95FlowPvWaitTime_field; }
       set { FT95FlowPvWaitTime_field = value; }
    }

  }

  public class CNF_RESET_F_ILCKEventArgs : System.EventArgs
  {
    public CNF_RESET_F_ILCKEventArgs()
    {
    }
    private System.Boolean? ResetLoLoFlowIlck_field = null;
    public System.Boolean? ResetLoLoFlowIlck
    {
       get { return ResetLoLoFlowIlck_field; }
       set { ResetLoLoFlowIlck_field = value; }
    }

  }

}

namespace SE.Nereda.Symbols.FeedInfluentLogic
{
  partial class sDefault
  {

    private event EventHandler<SE.Nereda.Symbols.FeedInfluentLogic.GRAPHEventArgs> GRAPH_Fired;

    private event EventHandler<SE.Nereda.Symbols.FeedInfluentLogic.FB_LEVEL_SPEventArgs> FB_LEVEL_SP_Fired;

    private event EventHandler<SE.Nereda.Symbols.FeedInfluentLogic.HI_HIEventArgs> HI_HI_Fired;

    private event EventHandler<SE.Nereda.Symbols.FeedInfluentLogic.FREEZEEventArgs> FREEZE_Fired;

    private event EventHandler<SE.Nereda.Symbols.FeedInfluentLogic.RESET_BTNSEventArgs> RESET_BTNS_Fired;

    private event EventHandler<SE.Nereda.Symbols.FeedInfluentLogic.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    protected override void OnEndInit()
    {
      if (GRAPH_Fired != null)
        AttachEventInput(0);
      if (FB_LEVEL_SP_Fired != null)
        AttachEventInput(1);
      if (HI_HI_Fired != null)
        AttachEventInput(2);
      if (FREEZE_Fired != null)
        AttachEventInput(3);
      if (RESET_BTNS_Fired != null)
        AttachEventInput(4);
      if (LOAD_PERS_DATA_Fired != null)
        AttachEventInput(5);

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
              GRAPH_Fired(this, new SE.Nereda.Symbols.FeedInfluentLogic.GRAPHEventArgs(channelId, cookie, eventIndex));
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
          if (FB_LEVEL_SP_Fired != null)
          {
            try
            {
              FB_LEVEL_SP_Fired(this, new SE.Nereda.Symbols.FeedInfluentLogic.FB_LEVEL_SPEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","FB_LEVEL_SP_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 2:
          if (HI_HI_Fired != null)
          {
            try
            {
              HI_HI_Fired(this, new SE.Nereda.Symbols.FeedInfluentLogic.HI_HIEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","HI_HI_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 3:
          if (FREEZE_Fired != null)
          {
            try
            {
              FREEZE_Fired(this, new SE.Nereda.Symbols.FeedInfluentLogic.FREEZEEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","FREEZE_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 4:
          if (RESET_BTNS_Fired != null)
          {
            try
            {
              RESET_BTNS_Fired(this, new SE.Nereda.Symbols.FeedInfluentLogic.RESET_BTNSEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","RESET_BTNS_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 5:
          if (LOAD_PERS_DATA_Fired != null)
          {
            try
            {
              LOAD_PERS_DATA_Fired(this, new SE.Nereda.Symbols.FeedInfluentLogic.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","LOAD_PERS_DATA_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_CNF_DUR_SP(NxtControl.GuiFramework.Time FreezRunDurSp, NxtControl.GuiFramework.Time FreezStopDurSp, NxtControl.GuiFramework.Time FT95FlowPvWaitTime)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {FreezRunDurSp, FreezStopDurSp, FT95FlowPvWaitTime});
    }
    public bool FireEvent_CNF_DUR_SP(SE.Nereda.Symbols.FeedInfluentLogic.CNF_DUR_SPEventArgs ea)
    {
      object[] _values_ = new object[3];
      if (ea.FreezRunDurSp.HasValue) _values_[0] = ea.FreezRunDurSp.Value;
      if (ea.FreezStopDurSp.HasValue) _values_[1] = ea.FreezStopDurSp.Value;
      if (ea.FT95FlowPvWaitTime.HasValue) _values_[2] = ea.FT95FlowPvWaitTime.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_CNF_DUR_SP(NxtControl.GuiFramework.Time FreezRunDurSp, bool ignore_FreezRunDurSp, NxtControl.GuiFramework.Time FreezStopDurSp, bool ignore_FreezStopDurSp, NxtControl.GuiFramework.Time FT95FlowPvWaitTime, bool ignore_FT95FlowPvWaitTime)
    {
      object[] _values_ = new object[3];
      if (!ignore_FreezRunDurSp) _values_[0] = FreezRunDurSp;
      if (!ignore_FreezStopDurSp) _values_[1] = FreezStopDurSp;
      if (!ignore_FT95FlowPvWaitTime) _values_[2] = FT95FlowPvWaitTime;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_CNF_FREEZ_SP(System.Single FreezWeatherSp)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {FreezWeatherSp});
    }
    public bool FireEvent_CNF_FREEZ_SP(SE.Nereda.Symbols.FeedInfluentLogic.CNF_FREEZ_SPEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.FreezWeatherSp.HasValue) _values_[0] = ea.FreezWeatherSp.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_CNF_FREEZ_SP(System.Single FreezWeatherSp, bool ignore_FreezWeatherSp)
    {
      object[] _values_ = new object[1];
      if (!ignore_FreezWeatherSp) _values_[0] = FreezWeatherSp;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_CNF_RESET(System.Boolean ResetLogic)
    {
      return ((IHMIAccessorOutput)this).FireEvent(2, new object[] {ResetLogic});
    }
    public bool FireEvent_CNF_RESET(SE.Nereda.Symbols.FeedInfluentLogic.CNF_RESETEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.ResetLogic.HasValue) _values_[0] = ea.ResetLogic.Value;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_CNF_RESET(System.Boolean ResetLogic, bool ignore_ResetLogic)
    {
      object[] _values_ = new object[1];
      if (!ignore_ResetLogic) _values_[0] = ResetLogic;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_CNF_SP(System.Single StartLevelSp, System.Single StopLevelSp, System.Single BreakPointSp, System.Single MaxFlowSp, NxtControl.GuiFramework.Time FT95FlowPvWaitTime)
    {
      return ((IHMIAccessorOutput)this).FireEvent(3, new object[] {StartLevelSp, StopLevelSp, BreakPointSp, MaxFlowSp, FT95FlowPvWaitTime});
    }
    public bool FireEvent_CNF_SP(SE.Nereda.Symbols.FeedInfluentLogic.CNF_SPEventArgs ea)
    {
      object[] _values_ = new object[5];
      if (ea.StartLevelSp.HasValue) _values_[0] = ea.StartLevelSp.Value;
      if (ea.StopLevelSp.HasValue) _values_[1] = ea.StopLevelSp.Value;
      if (ea.BreakPointSp.HasValue) _values_[2] = ea.BreakPointSp.Value;
      if (ea.MaxFlowSp.HasValue) _values_[3] = ea.MaxFlowSp.Value;
      if (ea.FT95FlowPvWaitTime.HasValue) _values_[4] = ea.FT95FlowPvWaitTime.Value;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_CNF_SP(System.Single StartLevelSp, bool ignore_StartLevelSp, System.Single StopLevelSp, bool ignore_StopLevelSp, System.Single BreakPointSp, bool ignore_BreakPointSp, System.Single MaxFlowSp, bool ignore_MaxFlowSp, NxtControl.GuiFramework.Time FT95FlowPvWaitTime, bool ignore_FT95FlowPvWaitTime)
    {
      object[] _values_ = new object[5];
      if (!ignore_StartLevelSp) _values_[0] = StartLevelSp;
      if (!ignore_StopLevelSp) _values_[1] = StopLevelSp;
      if (!ignore_BreakPointSp) _values_[2] = BreakPointSp;
      if (!ignore_MaxFlowSp) _values_[3] = MaxFlowSp;
      if (!ignore_FT95FlowPvWaitTime) _values_[4] = FT95FlowPvWaitTime;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_CNF_RESET_F_ILCK(System.Boolean ResetLoLoFlowIlck)
    {
      return ((IHMIAccessorOutput)this).FireEvent(4, new object[] {ResetLoLoFlowIlck});
    }
    public bool FireEvent_CNF_RESET_F_ILCK(SE.Nereda.Symbols.FeedInfluentLogic.CNF_RESET_F_ILCKEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.ResetLoLoFlowIlck.HasValue) _values_[0] = ea.ResetLoLoFlowIlck.Value;
      return ((IHMIAccessorOutput)this).FireEvent(4, _values_);
    }
    public bool FireEvent_CNF_RESET_F_ILCK(System.Boolean ResetLoLoFlowIlck, bool ignore_ResetLoLoFlowIlck)
    {
      object[] _values_ = new object[1];
      if (!ignore_ResetLoLoFlowIlck) _values_[0] = ResetLoLoFlowIlck;
      return ((IHMIAccessorOutput)this).FireEvent(4, _values_);
    }

  }
}

namespace SE.Nereda.Symbols.FeedInfluentLogic
{
  partial class sGraph
  {

    private event EventHandler<SE.Nereda.Symbols.FeedInfluentLogic.GRAPHEventArgs> GRAPH_Fired;

    private event EventHandler<SE.Nereda.Symbols.FeedInfluentLogic.FB_LEVEL_SPEventArgs> FB_LEVEL_SP_Fired;

    private event EventHandler<SE.Nereda.Symbols.FeedInfluentLogic.HI_HIEventArgs> HI_HI_Fired;

    private event EventHandler<SE.Nereda.Symbols.FeedInfluentLogic.FREEZEEventArgs> FREEZE_Fired;

    private event EventHandler<SE.Nereda.Symbols.FeedInfluentLogic.RESET_BTNSEventArgs> RESET_BTNS_Fired;

    private event EventHandler<SE.Nereda.Symbols.FeedInfluentLogic.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    protected override void OnEndInit()
    {
      if (GRAPH_Fired != null)
        AttachEventInput(0);
      if (FB_LEVEL_SP_Fired != null)
        AttachEventInput(1);
      if (HI_HI_Fired != null)
        AttachEventInput(2);
      if (FREEZE_Fired != null)
        AttachEventInput(3);
      if (RESET_BTNS_Fired != null)
        AttachEventInput(4);
      if (LOAD_PERS_DATA_Fired != null)
        AttachEventInput(5);

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
              GRAPH_Fired(this, new SE.Nereda.Symbols.FeedInfluentLogic.GRAPHEventArgs(channelId, cookie, eventIndex));
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
          if (FB_LEVEL_SP_Fired != null)
          {
            try
            {
              FB_LEVEL_SP_Fired(this, new SE.Nereda.Symbols.FeedInfluentLogic.FB_LEVEL_SPEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","FB_LEVEL_SP_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 2:
          if (HI_HI_Fired != null)
          {
            try
            {
              HI_HI_Fired(this, new SE.Nereda.Symbols.FeedInfluentLogic.HI_HIEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","HI_HI_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 3:
          if (FREEZE_Fired != null)
          {
            try
            {
              FREEZE_Fired(this, new SE.Nereda.Symbols.FeedInfluentLogic.FREEZEEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","FREEZE_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 4:
          if (RESET_BTNS_Fired != null)
          {
            try
            {
              RESET_BTNS_Fired(this, new SE.Nereda.Symbols.FeedInfluentLogic.RESET_BTNSEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","RESET_BTNS_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 5:
          if (LOAD_PERS_DATA_Fired != null)
          {
            try
            {
              LOAD_PERS_DATA_Fired(this, new SE.Nereda.Symbols.FeedInfluentLogic.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","LOAD_PERS_DATA_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_CNF_DUR_SP(NxtControl.GuiFramework.Time FreezRunDurSp, NxtControl.GuiFramework.Time FreezStopDurSp, NxtControl.GuiFramework.Time FT95FlowPvWaitTime)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {FreezRunDurSp, FreezStopDurSp, FT95FlowPvWaitTime});
    }
    public bool FireEvent_CNF_DUR_SP(SE.Nereda.Symbols.FeedInfluentLogic.CNF_DUR_SPEventArgs ea)
    {
      object[] _values_ = new object[3];
      if (ea.FreezRunDurSp.HasValue) _values_[0] = ea.FreezRunDurSp.Value;
      if (ea.FreezStopDurSp.HasValue) _values_[1] = ea.FreezStopDurSp.Value;
      if (ea.FT95FlowPvWaitTime.HasValue) _values_[2] = ea.FT95FlowPvWaitTime.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_CNF_DUR_SP(NxtControl.GuiFramework.Time FreezRunDurSp, bool ignore_FreezRunDurSp, NxtControl.GuiFramework.Time FreezStopDurSp, bool ignore_FreezStopDurSp, NxtControl.GuiFramework.Time FT95FlowPvWaitTime, bool ignore_FT95FlowPvWaitTime)
    {
      object[] _values_ = new object[3];
      if (!ignore_FreezRunDurSp) _values_[0] = FreezRunDurSp;
      if (!ignore_FreezStopDurSp) _values_[1] = FreezStopDurSp;
      if (!ignore_FT95FlowPvWaitTime) _values_[2] = FT95FlowPvWaitTime;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_CNF_FREEZ_SP(System.Single FreezWeatherSp)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {FreezWeatherSp});
    }
    public bool FireEvent_CNF_FREEZ_SP(SE.Nereda.Symbols.FeedInfluentLogic.CNF_FREEZ_SPEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.FreezWeatherSp.HasValue) _values_[0] = ea.FreezWeatherSp.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_CNF_FREEZ_SP(System.Single FreezWeatherSp, bool ignore_FreezWeatherSp)
    {
      object[] _values_ = new object[1];
      if (!ignore_FreezWeatherSp) _values_[0] = FreezWeatherSp;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_CNF_RESET(System.Boolean ResetLogic)
    {
      return ((IHMIAccessorOutput)this).FireEvent(2, new object[] {ResetLogic});
    }
    public bool FireEvent_CNF_RESET(SE.Nereda.Symbols.FeedInfluentLogic.CNF_RESETEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.ResetLogic.HasValue) _values_[0] = ea.ResetLogic.Value;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_CNF_RESET(System.Boolean ResetLogic, bool ignore_ResetLogic)
    {
      object[] _values_ = new object[1];
      if (!ignore_ResetLogic) _values_[0] = ResetLogic;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_CNF_SP(System.Single StartLevelSp, System.Single StopLevelSp, System.Single BreakPointSp, System.Single MaxFlowSp, NxtControl.GuiFramework.Time FT95FlowPvWaitTime)
    {
      return ((IHMIAccessorOutput)this).FireEvent(3, new object[] {StartLevelSp, StopLevelSp, BreakPointSp, MaxFlowSp, FT95FlowPvWaitTime});
    }
    public bool FireEvent_CNF_SP(SE.Nereda.Symbols.FeedInfluentLogic.CNF_SPEventArgs ea)
    {
      object[] _values_ = new object[5];
      if (ea.StartLevelSp.HasValue) _values_[0] = ea.StartLevelSp.Value;
      if (ea.StopLevelSp.HasValue) _values_[1] = ea.StopLevelSp.Value;
      if (ea.BreakPointSp.HasValue) _values_[2] = ea.BreakPointSp.Value;
      if (ea.MaxFlowSp.HasValue) _values_[3] = ea.MaxFlowSp.Value;
      if (ea.FT95FlowPvWaitTime.HasValue) _values_[4] = ea.FT95FlowPvWaitTime.Value;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_CNF_SP(System.Single StartLevelSp, bool ignore_StartLevelSp, System.Single StopLevelSp, bool ignore_StopLevelSp, System.Single BreakPointSp, bool ignore_BreakPointSp, System.Single MaxFlowSp, bool ignore_MaxFlowSp, NxtControl.GuiFramework.Time FT95FlowPvWaitTime, bool ignore_FT95FlowPvWaitTime)
    {
      object[] _values_ = new object[5];
      if (!ignore_StartLevelSp) _values_[0] = StartLevelSp;
      if (!ignore_StopLevelSp) _values_[1] = StopLevelSp;
      if (!ignore_BreakPointSp) _values_[2] = BreakPointSp;
      if (!ignore_MaxFlowSp) _values_[3] = MaxFlowSp;
      if (!ignore_FT95FlowPvWaitTime) _values_[4] = FT95FlowPvWaitTime;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_CNF_RESET_F_ILCK(System.Boolean ResetLoLoFlowIlck)
    {
      return ((IHMIAccessorOutput)this).FireEvent(4, new object[] {ResetLoLoFlowIlck});
    }
    public bool FireEvent_CNF_RESET_F_ILCK(SE.Nereda.Symbols.FeedInfluentLogic.CNF_RESET_F_ILCKEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.ResetLoLoFlowIlck.HasValue) _values_[0] = ea.ResetLoLoFlowIlck.Value;
      return ((IHMIAccessorOutput)this).FireEvent(4, _values_);
    }
    public bool FireEvent_CNF_RESET_F_ILCK(System.Boolean ResetLoLoFlowIlck, bool ignore_ResetLoLoFlowIlck)
    {
      object[] _values_ = new object[1];
      if (!ignore_ResetLoLoFlowIlck) _values_[0] = ResetLoLoFlowIlck;
      return ((IHMIAccessorOutput)this).FireEvent(4, _values_);
    }

  }
}

namespace SE.Nereda.Symbols.FeedInfluentLogic
{
  partial class sHiHiAlarms
  {

    private event EventHandler<SE.Nereda.Symbols.FeedInfluentLogic.GRAPHEventArgs> GRAPH_Fired;

    private event EventHandler<SE.Nereda.Symbols.FeedInfluentLogic.FB_LEVEL_SPEventArgs> FB_LEVEL_SP_Fired;

    private event EventHandler<SE.Nereda.Symbols.FeedInfluentLogic.HI_HIEventArgs> HI_HI_Fired;

    private event EventHandler<SE.Nereda.Symbols.FeedInfluentLogic.FREEZEEventArgs> FREEZE_Fired;

    private event EventHandler<SE.Nereda.Symbols.FeedInfluentLogic.RESET_BTNSEventArgs> RESET_BTNS_Fired;

    private event EventHandler<SE.Nereda.Symbols.FeedInfluentLogic.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    protected override void OnEndInit()
    {
      if (GRAPH_Fired != null)
        AttachEventInput(0);
      if (FB_LEVEL_SP_Fired != null)
        AttachEventInput(1);
      if (HI_HI_Fired != null)
        AttachEventInput(2);
      if (FREEZE_Fired != null)
        AttachEventInput(3);
      if (RESET_BTNS_Fired != null)
        AttachEventInput(4);
      if (LOAD_PERS_DATA_Fired != null)
        AttachEventInput(5);

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
              GRAPH_Fired(this, new SE.Nereda.Symbols.FeedInfluentLogic.GRAPHEventArgs(channelId, cookie, eventIndex));
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
          if (FB_LEVEL_SP_Fired != null)
          {
            try
            {
              FB_LEVEL_SP_Fired(this, new SE.Nereda.Symbols.FeedInfluentLogic.FB_LEVEL_SPEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","FB_LEVEL_SP_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 2:
          if (HI_HI_Fired != null)
          {
            try
            {
              HI_HI_Fired(this, new SE.Nereda.Symbols.FeedInfluentLogic.HI_HIEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","HI_HI_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 3:
          if (FREEZE_Fired != null)
          {
            try
            {
              FREEZE_Fired(this, new SE.Nereda.Symbols.FeedInfluentLogic.FREEZEEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","FREEZE_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 4:
          if (RESET_BTNS_Fired != null)
          {
            try
            {
              RESET_BTNS_Fired(this, new SE.Nereda.Symbols.FeedInfluentLogic.RESET_BTNSEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","RESET_BTNS_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 5:
          if (LOAD_PERS_DATA_Fired != null)
          {
            try
            {
              LOAD_PERS_DATA_Fired(this, new SE.Nereda.Symbols.FeedInfluentLogic.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","LOAD_PERS_DATA_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_CNF_DUR_SP(NxtControl.GuiFramework.Time FreezRunDurSp, NxtControl.GuiFramework.Time FreezStopDurSp, NxtControl.GuiFramework.Time FT95FlowPvWaitTime)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {FreezRunDurSp, FreezStopDurSp, FT95FlowPvWaitTime});
    }
    public bool FireEvent_CNF_DUR_SP(SE.Nereda.Symbols.FeedInfluentLogic.CNF_DUR_SPEventArgs ea)
    {
      object[] _values_ = new object[3];
      if (ea.FreezRunDurSp.HasValue) _values_[0] = ea.FreezRunDurSp.Value;
      if (ea.FreezStopDurSp.HasValue) _values_[1] = ea.FreezStopDurSp.Value;
      if (ea.FT95FlowPvWaitTime.HasValue) _values_[2] = ea.FT95FlowPvWaitTime.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_CNF_DUR_SP(NxtControl.GuiFramework.Time FreezRunDurSp, bool ignore_FreezRunDurSp, NxtControl.GuiFramework.Time FreezStopDurSp, bool ignore_FreezStopDurSp, NxtControl.GuiFramework.Time FT95FlowPvWaitTime, bool ignore_FT95FlowPvWaitTime)
    {
      object[] _values_ = new object[3];
      if (!ignore_FreezRunDurSp) _values_[0] = FreezRunDurSp;
      if (!ignore_FreezStopDurSp) _values_[1] = FreezStopDurSp;
      if (!ignore_FT95FlowPvWaitTime) _values_[2] = FT95FlowPvWaitTime;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_CNF_FREEZ_SP(System.Single FreezWeatherSp)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {FreezWeatherSp});
    }
    public bool FireEvent_CNF_FREEZ_SP(SE.Nereda.Symbols.FeedInfluentLogic.CNF_FREEZ_SPEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.FreezWeatherSp.HasValue) _values_[0] = ea.FreezWeatherSp.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_CNF_FREEZ_SP(System.Single FreezWeatherSp, bool ignore_FreezWeatherSp)
    {
      object[] _values_ = new object[1];
      if (!ignore_FreezWeatherSp) _values_[0] = FreezWeatherSp;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_CNF_RESET(System.Boolean ResetLogic)
    {
      return ((IHMIAccessorOutput)this).FireEvent(2, new object[] {ResetLogic});
    }
    public bool FireEvent_CNF_RESET(SE.Nereda.Symbols.FeedInfluentLogic.CNF_RESETEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.ResetLogic.HasValue) _values_[0] = ea.ResetLogic.Value;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_CNF_RESET(System.Boolean ResetLogic, bool ignore_ResetLogic)
    {
      object[] _values_ = new object[1];
      if (!ignore_ResetLogic) _values_[0] = ResetLogic;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_CNF_SP(System.Single StartLevelSp, System.Single StopLevelSp, System.Single BreakPointSp, System.Single MaxFlowSp, NxtControl.GuiFramework.Time FT95FlowPvWaitTime)
    {
      return ((IHMIAccessorOutput)this).FireEvent(3, new object[] {StartLevelSp, StopLevelSp, BreakPointSp, MaxFlowSp, FT95FlowPvWaitTime});
    }
    public bool FireEvent_CNF_SP(SE.Nereda.Symbols.FeedInfluentLogic.CNF_SPEventArgs ea)
    {
      object[] _values_ = new object[5];
      if (ea.StartLevelSp.HasValue) _values_[0] = ea.StartLevelSp.Value;
      if (ea.StopLevelSp.HasValue) _values_[1] = ea.StopLevelSp.Value;
      if (ea.BreakPointSp.HasValue) _values_[2] = ea.BreakPointSp.Value;
      if (ea.MaxFlowSp.HasValue) _values_[3] = ea.MaxFlowSp.Value;
      if (ea.FT95FlowPvWaitTime.HasValue) _values_[4] = ea.FT95FlowPvWaitTime.Value;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_CNF_SP(System.Single StartLevelSp, bool ignore_StartLevelSp, System.Single StopLevelSp, bool ignore_StopLevelSp, System.Single BreakPointSp, bool ignore_BreakPointSp, System.Single MaxFlowSp, bool ignore_MaxFlowSp, NxtControl.GuiFramework.Time FT95FlowPvWaitTime, bool ignore_FT95FlowPvWaitTime)
    {
      object[] _values_ = new object[5];
      if (!ignore_StartLevelSp) _values_[0] = StartLevelSp;
      if (!ignore_StopLevelSp) _values_[1] = StopLevelSp;
      if (!ignore_BreakPointSp) _values_[2] = BreakPointSp;
      if (!ignore_MaxFlowSp) _values_[3] = MaxFlowSp;
      if (!ignore_FT95FlowPvWaitTime) _values_[4] = FT95FlowPvWaitTime;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_CNF_RESET_F_ILCK(System.Boolean ResetLoLoFlowIlck)
    {
      return ((IHMIAccessorOutput)this).FireEvent(4, new object[] {ResetLoLoFlowIlck});
    }
    public bool FireEvent_CNF_RESET_F_ILCK(SE.Nereda.Symbols.FeedInfluentLogic.CNF_RESET_F_ILCKEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.ResetLoLoFlowIlck.HasValue) _values_[0] = ea.ResetLoLoFlowIlck.Value;
      return ((IHMIAccessorOutput)this).FireEvent(4, _values_);
    }
    public bool FireEvent_CNF_RESET_F_ILCK(System.Boolean ResetLoLoFlowIlck, bool ignore_ResetLoLoFlowIlck)
    {
      object[] _values_ = new object[1];
      if (!ignore_ResetLoLoFlowIlck) _values_[0] = ResetLoLoFlowIlck;
      return ((IHMIAccessorOutput)this).FireEvent(4, _values_);
    }

  }
}

namespace SE.Nereda.Symbols.FeedInfluentLogic
{
  partial class sFreezeMode
  {

    private event EventHandler<SE.Nereda.Symbols.FeedInfluentLogic.GRAPHEventArgs> GRAPH_Fired;

    private event EventHandler<SE.Nereda.Symbols.FeedInfluentLogic.FB_LEVEL_SPEventArgs> FB_LEVEL_SP_Fired;

    private event EventHandler<SE.Nereda.Symbols.FeedInfluentLogic.HI_HIEventArgs> HI_HI_Fired;

    private event EventHandler<SE.Nereda.Symbols.FeedInfluentLogic.FREEZEEventArgs> FREEZE_Fired;

    private event EventHandler<SE.Nereda.Symbols.FeedInfluentLogic.RESET_BTNSEventArgs> RESET_BTNS_Fired;

    private event EventHandler<SE.Nereda.Symbols.FeedInfluentLogic.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    protected override void OnEndInit()
    {
      if (GRAPH_Fired != null)
        AttachEventInput(0);
      if (FB_LEVEL_SP_Fired != null)
        AttachEventInput(1);
      if (HI_HI_Fired != null)
        AttachEventInput(2);
      if (FREEZE_Fired != null)
        AttachEventInput(3);
      if (RESET_BTNS_Fired != null)
        AttachEventInput(4);
      if (LOAD_PERS_DATA_Fired != null)
        AttachEventInput(5);

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
              GRAPH_Fired(this, new SE.Nereda.Symbols.FeedInfluentLogic.GRAPHEventArgs(channelId, cookie, eventIndex));
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
          if (FB_LEVEL_SP_Fired != null)
          {
            try
            {
              FB_LEVEL_SP_Fired(this, new SE.Nereda.Symbols.FeedInfluentLogic.FB_LEVEL_SPEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","FB_LEVEL_SP_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 2:
          if (HI_HI_Fired != null)
          {
            try
            {
              HI_HI_Fired(this, new SE.Nereda.Symbols.FeedInfluentLogic.HI_HIEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","HI_HI_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 3:
          if (FREEZE_Fired != null)
          {
            try
            {
              FREEZE_Fired(this, new SE.Nereda.Symbols.FeedInfluentLogic.FREEZEEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","FREEZE_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 4:
          if (RESET_BTNS_Fired != null)
          {
            try
            {
              RESET_BTNS_Fired(this, new SE.Nereda.Symbols.FeedInfluentLogic.RESET_BTNSEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","RESET_BTNS_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 5:
          if (LOAD_PERS_DATA_Fired != null)
          {
            try
            {
              LOAD_PERS_DATA_Fired(this, new SE.Nereda.Symbols.FeedInfluentLogic.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","LOAD_PERS_DATA_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_CNF_DUR_SP(NxtControl.GuiFramework.Time FreezRunDurSp, NxtControl.GuiFramework.Time FreezStopDurSp, NxtControl.GuiFramework.Time FT95FlowPvWaitTime)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {FreezRunDurSp, FreezStopDurSp, FT95FlowPvWaitTime});
    }
    public bool FireEvent_CNF_DUR_SP(SE.Nereda.Symbols.FeedInfluentLogic.CNF_DUR_SPEventArgs ea)
    {
      object[] _values_ = new object[3];
      if (ea.FreezRunDurSp.HasValue) _values_[0] = ea.FreezRunDurSp.Value;
      if (ea.FreezStopDurSp.HasValue) _values_[1] = ea.FreezStopDurSp.Value;
      if (ea.FT95FlowPvWaitTime.HasValue) _values_[2] = ea.FT95FlowPvWaitTime.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_CNF_DUR_SP(NxtControl.GuiFramework.Time FreezRunDurSp, bool ignore_FreezRunDurSp, NxtControl.GuiFramework.Time FreezStopDurSp, bool ignore_FreezStopDurSp, NxtControl.GuiFramework.Time FT95FlowPvWaitTime, bool ignore_FT95FlowPvWaitTime)
    {
      object[] _values_ = new object[3];
      if (!ignore_FreezRunDurSp) _values_[0] = FreezRunDurSp;
      if (!ignore_FreezStopDurSp) _values_[1] = FreezStopDurSp;
      if (!ignore_FT95FlowPvWaitTime) _values_[2] = FT95FlowPvWaitTime;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_CNF_FREEZ_SP(System.Single FreezWeatherSp)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {FreezWeatherSp});
    }
    public bool FireEvent_CNF_FREEZ_SP(SE.Nereda.Symbols.FeedInfluentLogic.CNF_FREEZ_SPEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.FreezWeatherSp.HasValue) _values_[0] = ea.FreezWeatherSp.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_CNF_FREEZ_SP(System.Single FreezWeatherSp, bool ignore_FreezWeatherSp)
    {
      object[] _values_ = new object[1];
      if (!ignore_FreezWeatherSp) _values_[0] = FreezWeatherSp;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_CNF_RESET(System.Boolean ResetLogic)
    {
      return ((IHMIAccessorOutput)this).FireEvent(2, new object[] {ResetLogic});
    }
    public bool FireEvent_CNF_RESET(SE.Nereda.Symbols.FeedInfluentLogic.CNF_RESETEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.ResetLogic.HasValue) _values_[0] = ea.ResetLogic.Value;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_CNF_RESET(System.Boolean ResetLogic, bool ignore_ResetLogic)
    {
      object[] _values_ = new object[1];
      if (!ignore_ResetLogic) _values_[0] = ResetLogic;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_CNF_SP(System.Single StartLevelSp, System.Single StopLevelSp, System.Single BreakPointSp, System.Single MaxFlowSp, NxtControl.GuiFramework.Time FT95FlowPvWaitTime)
    {
      return ((IHMIAccessorOutput)this).FireEvent(3, new object[] {StartLevelSp, StopLevelSp, BreakPointSp, MaxFlowSp, FT95FlowPvWaitTime});
    }
    public bool FireEvent_CNF_SP(SE.Nereda.Symbols.FeedInfluentLogic.CNF_SPEventArgs ea)
    {
      object[] _values_ = new object[5];
      if (ea.StartLevelSp.HasValue) _values_[0] = ea.StartLevelSp.Value;
      if (ea.StopLevelSp.HasValue) _values_[1] = ea.StopLevelSp.Value;
      if (ea.BreakPointSp.HasValue) _values_[2] = ea.BreakPointSp.Value;
      if (ea.MaxFlowSp.HasValue) _values_[3] = ea.MaxFlowSp.Value;
      if (ea.FT95FlowPvWaitTime.HasValue) _values_[4] = ea.FT95FlowPvWaitTime.Value;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_CNF_SP(System.Single StartLevelSp, bool ignore_StartLevelSp, System.Single StopLevelSp, bool ignore_StopLevelSp, System.Single BreakPointSp, bool ignore_BreakPointSp, System.Single MaxFlowSp, bool ignore_MaxFlowSp, NxtControl.GuiFramework.Time FT95FlowPvWaitTime, bool ignore_FT95FlowPvWaitTime)
    {
      object[] _values_ = new object[5];
      if (!ignore_StartLevelSp) _values_[0] = StartLevelSp;
      if (!ignore_StopLevelSp) _values_[1] = StopLevelSp;
      if (!ignore_BreakPointSp) _values_[2] = BreakPointSp;
      if (!ignore_MaxFlowSp) _values_[3] = MaxFlowSp;
      if (!ignore_FT95FlowPvWaitTime) _values_[4] = FT95FlowPvWaitTime;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_CNF_RESET_F_ILCK(System.Boolean ResetLoLoFlowIlck)
    {
      return ((IHMIAccessorOutput)this).FireEvent(4, new object[] {ResetLoLoFlowIlck});
    }
    public bool FireEvent_CNF_RESET_F_ILCK(SE.Nereda.Symbols.FeedInfluentLogic.CNF_RESET_F_ILCKEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.ResetLoLoFlowIlck.HasValue) _values_[0] = ea.ResetLoLoFlowIlck.Value;
      return ((IHMIAccessorOutput)this).FireEvent(4, _values_);
    }
    public bool FireEvent_CNF_RESET_F_ILCK(System.Boolean ResetLoLoFlowIlck, bool ignore_ResetLoLoFlowIlck)
    {
      object[] _values_ = new object[1];
      if (!ignore_ResetLoLoFlowIlck) _values_[0] = ResetLoLoFlowIlck;
      return ((IHMIAccessorOutput)this).FireEvent(4, _values_);
    }

  }
}

namespace SE.Nereda.Symbols.FeedInfluentLogic
{
  partial class sPID
  {

    private event EventHandler<SE.Nereda.Symbols.FeedInfluentLogic.GRAPHEventArgs> GRAPH_Fired;

    private event EventHandler<SE.Nereda.Symbols.FeedInfluentLogic.FB_LEVEL_SPEventArgs> FB_LEVEL_SP_Fired;

    private event EventHandler<SE.Nereda.Symbols.FeedInfluentLogic.HI_HIEventArgs> HI_HI_Fired;

    private event EventHandler<SE.Nereda.Symbols.FeedInfluentLogic.FREEZEEventArgs> FREEZE_Fired;

    private event EventHandler<SE.Nereda.Symbols.FeedInfluentLogic.RESET_BTNSEventArgs> RESET_BTNS_Fired;

    private event EventHandler<SE.Nereda.Symbols.FeedInfluentLogic.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    protected override void OnEndInit()
    {
      if (GRAPH_Fired != null)
        AttachEventInput(0);
      if (FB_LEVEL_SP_Fired != null)
        AttachEventInput(1);
      if (HI_HI_Fired != null)
        AttachEventInput(2);
      if (FREEZE_Fired != null)
        AttachEventInput(3);
      if (RESET_BTNS_Fired != null)
        AttachEventInput(4);
      if (LOAD_PERS_DATA_Fired != null)
        AttachEventInput(5);

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
              GRAPH_Fired(this, new SE.Nereda.Symbols.FeedInfluentLogic.GRAPHEventArgs(channelId, cookie, eventIndex));
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
          if (FB_LEVEL_SP_Fired != null)
          {
            try
            {
              FB_LEVEL_SP_Fired(this, new SE.Nereda.Symbols.FeedInfluentLogic.FB_LEVEL_SPEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","FB_LEVEL_SP_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 2:
          if (HI_HI_Fired != null)
          {
            try
            {
              HI_HI_Fired(this, new SE.Nereda.Symbols.FeedInfluentLogic.HI_HIEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","HI_HI_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 3:
          if (FREEZE_Fired != null)
          {
            try
            {
              FREEZE_Fired(this, new SE.Nereda.Symbols.FeedInfluentLogic.FREEZEEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","FREEZE_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 4:
          if (RESET_BTNS_Fired != null)
          {
            try
            {
              RESET_BTNS_Fired(this, new SE.Nereda.Symbols.FeedInfluentLogic.RESET_BTNSEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","RESET_BTNS_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 5:
          if (LOAD_PERS_DATA_Fired != null)
          {
            try
            {
              LOAD_PERS_DATA_Fired(this, new SE.Nereda.Symbols.FeedInfluentLogic.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","LOAD_PERS_DATA_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_CNF_DUR_SP(NxtControl.GuiFramework.Time FreezRunDurSp, NxtControl.GuiFramework.Time FreezStopDurSp, NxtControl.GuiFramework.Time FT95FlowPvWaitTime)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {FreezRunDurSp, FreezStopDurSp, FT95FlowPvWaitTime});
    }
    public bool FireEvent_CNF_DUR_SP(SE.Nereda.Symbols.FeedInfluentLogic.CNF_DUR_SPEventArgs ea)
    {
      object[] _values_ = new object[3];
      if (ea.FreezRunDurSp.HasValue) _values_[0] = ea.FreezRunDurSp.Value;
      if (ea.FreezStopDurSp.HasValue) _values_[1] = ea.FreezStopDurSp.Value;
      if (ea.FT95FlowPvWaitTime.HasValue) _values_[2] = ea.FT95FlowPvWaitTime.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_CNF_DUR_SP(NxtControl.GuiFramework.Time FreezRunDurSp, bool ignore_FreezRunDurSp, NxtControl.GuiFramework.Time FreezStopDurSp, bool ignore_FreezStopDurSp, NxtControl.GuiFramework.Time FT95FlowPvWaitTime, bool ignore_FT95FlowPvWaitTime)
    {
      object[] _values_ = new object[3];
      if (!ignore_FreezRunDurSp) _values_[0] = FreezRunDurSp;
      if (!ignore_FreezStopDurSp) _values_[1] = FreezStopDurSp;
      if (!ignore_FT95FlowPvWaitTime) _values_[2] = FT95FlowPvWaitTime;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_CNF_FREEZ_SP(System.Single FreezWeatherSp)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {FreezWeatherSp});
    }
    public bool FireEvent_CNF_FREEZ_SP(SE.Nereda.Symbols.FeedInfluentLogic.CNF_FREEZ_SPEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.FreezWeatherSp.HasValue) _values_[0] = ea.FreezWeatherSp.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_CNF_FREEZ_SP(System.Single FreezWeatherSp, bool ignore_FreezWeatherSp)
    {
      object[] _values_ = new object[1];
      if (!ignore_FreezWeatherSp) _values_[0] = FreezWeatherSp;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_CNF_RESET(System.Boolean ResetLogic)
    {
      return ((IHMIAccessorOutput)this).FireEvent(2, new object[] {ResetLogic});
    }
    public bool FireEvent_CNF_RESET(SE.Nereda.Symbols.FeedInfluentLogic.CNF_RESETEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.ResetLogic.HasValue) _values_[0] = ea.ResetLogic.Value;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_CNF_RESET(System.Boolean ResetLogic, bool ignore_ResetLogic)
    {
      object[] _values_ = new object[1];
      if (!ignore_ResetLogic) _values_[0] = ResetLogic;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_CNF_SP(System.Single StartLevelSp, System.Single StopLevelSp, System.Single BreakPointSp, System.Single MaxFlowSp, NxtControl.GuiFramework.Time FT95FlowPvWaitTime)
    {
      return ((IHMIAccessorOutput)this).FireEvent(3, new object[] {StartLevelSp, StopLevelSp, BreakPointSp, MaxFlowSp, FT95FlowPvWaitTime});
    }
    public bool FireEvent_CNF_SP(SE.Nereda.Symbols.FeedInfluentLogic.CNF_SPEventArgs ea)
    {
      object[] _values_ = new object[5];
      if (ea.StartLevelSp.HasValue) _values_[0] = ea.StartLevelSp.Value;
      if (ea.StopLevelSp.HasValue) _values_[1] = ea.StopLevelSp.Value;
      if (ea.BreakPointSp.HasValue) _values_[2] = ea.BreakPointSp.Value;
      if (ea.MaxFlowSp.HasValue) _values_[3] = ea.MaxFlowSp.Value;
      if (ea.FT95FlowPvWaitTime.HasValue) _values_[4] = ea.FT95FlowPvWaitTime.Value;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_CNF_SP(System.Single StartLevelSp, bool ignore_StartLevelSp, System.Single StopLevelSp, bool ignore_StopLevelSp, System.Single BreakPointSp, bool ignore_BreakPointSp, System.Single MaxFlowSp, bool ignore_MaxFlowSp, NxtControl.GuiFramework.Time FT95FlowPvWaitTime, bool ignore_FT95FlowPvWaitTime)
    {
      object[] _values_ = new object[5];
      if (!ignore_StartLevelSp) _values_[0] = StartLevelSp;
      if (!ignore_StopLevelSp) _values_[1] = StopLevelSp;
      if (!ignore_BreakPointSp) _values_[2] = BreakPointSp;
      if (!ignore_MaxFlowSp) _values_[3] = MaxFlowSp;
      if (!ignore_FT95FlowPvWaitTime) _values_[4] = FT95FlowPvWaitTime;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_CNF_RESET_F_ILCK(System.Boolean ResetLoLoFlowIlck)
    {
      return ((IHMIAccessorOutput)this).FireEvent(4, new object[] {ResetLoLoFlowIlck});
    }
    public bool FireEvent_CNF_RESET_F_ILCK(SE.Nereda.Symbols.FeedInfluentLogic.CNF_RESET_F_ILCKEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.ResetLoLoFlowIlck.HasValue) _values_[0] = ea.ResetLoLoFlowIlck.Value;
      return ((IHMIAccessorOutput)this).FireEvent(4, _values_);
    }
    public bool FireEvent_CNF_RESET_F_ILCK(System.Boolean ResetLoLoFlowIlck, bool ignore_ResetLoLoFlowIlck)
    {
      object[] _values_ = new object[1];
      if (!ignore_ResetLoLoFlowIlck) _values_[0] = ResetLoLoFlowIlck;
      return ((IHMIAccessorOutput)this).FireEvent(4, _values_);
    }

  }
}

namespace SE.Nereda.Faceplates.FeedInfluentLogic
{
  partial class fpPID
  {

    private event EventHandler<SE.Nereda.Symbols.FeedInfluentLogic.GRAPHEventArgs> GRAPH_Fired;

    private event EventHandler<SE.Nereda.Symbols.FeedInfluentLogic.FB_LEVEL_SPEventArgs> FB_LEVEL_SP_Fired;

    private event EventHandler<SE.Nereda.Symbols.FeedInfluentLogic.HI_HIEventArgs> HI_HI_Fired;

    private event EventHandler<SE.Nereda.Symbols.FeedInfluentLogic.FREEZEEventArgs> FREEZE_Fired;

    private event EventHandler<SE.Nereda.Symbols.FeedInfluentLogic.RESET_BTNSEventArgs> RESET_BTNS_Fired;

    private event EventHandler<SE.Nereda.Symbols.FeedInfluentLogic.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    protected override void OnEndInit()
    {
      if (GRAPH_Fired != null)
        AttachEventInput(0);
      if (FB_LEVEL_SP_Fired != null)
        AttachEventInput(1);
      if (HI_HI_Fired != null)
        AttachEventInput(2);
      if (FREEZE_Fired != null)
        AttachEventInput(3);
      if (RESET_BTNS_Fired != null)
        AttachEventInput(4);
      if (LOAD_PERS_DATA_Fired != null)
        AttachEventInput(5);

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
              GRAPH_Fired(this, new SE.Nereda.Symbols.FeedInfluentLogic.GRAPHEventArgs(channelId, cookie, eventIndex));
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
          if (FB_LEVEL_SP_Fired != null)
          {
            try
            {
              FB_LEVEL_SP_Fired(this, new SE.Nereda.Symbols.FeedInfluentLogic.FB_LEVEL_SPEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","FB_LEVEL_SP_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 2:
          if (HI_HI_Fired != null)
          {
            try
            {
              HI_HI_Fired(this, new SE.Nereda.Symbols.FeedInfluentLogic.HI_HIEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","HI_HI_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 3:
          if (FREEZE_Fired != null)
          {
            try
            {
              FREEZE_Fired(this, new SE.Nereda.Symbols.FeedInfluentLogic.FREEZEEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","FREEZE_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 4:
          if (RESET_BTNS_Fired != null)
          {
            try
            {
              RESET_BTNS_Fired(this, new SE.Nereda.Symbols.FeedInfluentLogic.RESET_BTNSEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","RESET_BTNS_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 5:
          if (LOAD_PERS_DATA_Fired != null)
          {
            try
            {
              LOAD_PERS_DATA_Fired(this, new SE.Nereda.Symbols.FeedInfluentLogic.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","LOAD_PERS_DATA_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_CNF_DUR_SP(NxtControl.GuiFramework.Time FreezRunDurSp, NxtControl.GuiFramework.Time FreezStopDurSp, NxtControl.GuiFramework.Time FT95FlowPvWaitTime)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {FreezRunDurSp, FreezStopDurSp, FT95FlowPvWaitTime});
    }
    public bool FireEvent_CNF_DUR_SP(SE.Nereda.Symbols.FeedInfluentLogic.CNF_DUR_SPEventArgs ea)
    {
      object[] _values_ = new object[3];
      if (ea.FreezRunDurSp.HasValue) _values_[0] = ea.FreezRunDurSp.Value;
      if (ea.FreezStopDurSp.HasValue) _values_[1] = ea.FreezStopDurSp.Value;
      if (ea.FT95FlowPvWaitTime.HasValue) _values_[2] = ea.FT95FlowPvWaitTime.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_CNF_DUR_SP(NxtControl.GuiFramework.Time FreezRunDurSp, bool ignore_FreezRunDurSp, NxtControl.GuiFramework.Time FreezStopDurSp, bool ignore_FreezStopDurSp, NxtControl.GuiFramework.Time FT95FlowPvWaitTime, bool ignore_FT95FlowPvWaitTime)
    {
      object[] _values_ = new object[3];
      if (!ignore_FreezRunDurSp) _values_[0] = FreezRunDurSp;
      if (!ignore_FreezStopDurSp) _values_[1] = FreezStopDurSp;
      if (!ignore_FT95FlowPvWaitTime) _values_[2] = FT95FlowPvWaitTime;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_CNF_FREEZ_SP(System.Single FreezWeatherSp)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {FreezWeatherSp});
    }
    public bool FireEvent_CNF_FREEZ_SP(SE.Nereda.Symbols.FeedInfluentLogic.CNF_FREEZ_SPEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.FreezWeatherSp.HasValue) _values_[0] = ea.FreezWeatherSp.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_CNF_FREEZ_SP(System.Single FreezWeatherSp, bool ignore_FreezWeatherSp)
    {
      object[] _values_ = new object[1];
      if (!ignore_FreezWeatherSp) _values_[0] = FreezWeatherSp;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_CNF_RESET(System.Boolean ResetLogic)
    {
      return ((IHMIAccessorOutput)this).FireEvent(2, new object[] {ResetLogic});
    }
    public bool FireEvent_CNF_RESET(SE.Nereda.Symbols.FeedInfluentLogic.CNF_RESETEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.ResetLogic.HasValue) _values_[0] = ea.ResetLogic.Value;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_CNF_RESET(System.Boolean ResetLogic, bool ignore_ResetLogic)
    {
      object[] _values_ = new object[1];
      if (!ignore_ResetLogic) _values_[0] = ResetLogic;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_CNF_SP(System.Single StartLevelSp, System.Single StopLevelSp, System.Single BreakPointSp, System.Single MaxFlowSp, NxtControl.GuiFramework.Time FT95FlowPvWaitTime)
    {
      return ((IHMIAccessorOutput)this).FireEvent(3, new object[] {StartLevelSp, StopLevelSp, BreakPointSp, MaxFlowSp, FT95FlowPvWaitTime});
    }
    public bool FireEvent_CNF_SP(SE.Nereda.Symbols.FeedInfluentLogic.CNF_SPEventArgs ea)
    {
      object[] _values_ = new object[5];
      if (ea.StartLevelSp.HasValue) _values_[0] = ea.StartLevelSp.Value;
      if (ea.StopLevelSp.HasValue) _values_[1] = ea.StopLevelSp.Value;
      if (ea.BreakPointSp.HasValue) _values_[2] = ea.BreakPointSp.Value;
      if (ea.MaxFlowSp.HasValue) _values_[3] = ea.MaxFlowSp.Value;
      if (ea.FT95FlowPvWaitTime.HasValue) _values_[4] = ea.FT95FlowPvWaitTime.Value;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_CNF_SP(System.Single StartLevelSp, bool ignore_StartLevelSp, System.Single StopLevelSp, bool ignore_StopLevelSp, System.Single BreakPointSp, bool ignore_BreakPointSp, System.Single MaxFlowSp, bool ignore_MaxFlowSp, NxtControl.GuiFramework.Time FT95FlowPvWaitTime, bool ignore_FT95FlowPvWaitTime)
    {
      object[] _values_ = new object[5];
      if (!ignore_StartLevelSp) _values_[0] = StartLevelSp;
      if (!ignore_StopLevelSp) _values_[1] = StopLevelSp;
      if (!ignore_BreakPointSp) _values_[2] = BreakPointSp;
      if (!ignore_MaxFlowSp) _values_[3] = MaxFlowSp;
      if (!ignore_FT95FlowPvWaitTime) _values_[4] = FT95FlowPvWaitTime;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_CNF_RESET_F_ILCK(System.Boolean ResetLoLoFlowIlck)
    {
      return ((IHMIAccessorOutput)this).FireEvent(4, new object[] {ResetLoLoFlowIlck});
    }
    public bool FireEvent_CNF_RESET_F_ILCK(SE.Nereda.Symbols.FeedInfluentLogic.CNF_RESET_F_ILCKEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.ResetLoLoFlowIlck.HasValue) _values_[0] = ea.ResetLoLoFlowIlck.Value;
      return ((IHMIAccessorOutput)this).FireEvent(4, _values_);
    }
    public bool FireEvent_CNF_RESET_F_ILCK(System.Boolean ResetLoLoFlowIlck, bool ignore_ResetLoLoFlowIlck)
    {
      object[] _values_ = new object[1];
      if (!ignore_ResetLoLoFlowIlck) _values_[0] = ResetLoLoFlowIlck;
      return ((IHMIAccessorOutput)this).FireEvent(4, _values_);
    }

  }
}

namespace SE.Nereda.Symbols.FeedInfluentLogic
{
  partial class sReset
  {

    private event EventHandler<SE.Nereda.Symbols.FeedInfluentLogic.GRAPHEventArgs> GRAPH_Fired;

    private event EventHandler<SE.Nereda.Symbols.FeedInfluentLogic.FB_LEVEL_SPEventArgs> FB_LEVEL_SP_Fired;

    private event EventHandler<SE.Nereda.Symbols.FeedInfluentLogic.HI_HIEventArgs> HI_HI_Fired;

    private event EventHandler<SE.Nereda.Symbols.FeedInfluentLogic.FREEZEEventArgs> FREEZE_Fired;

    private event EventHandler<SE.Nereda.Symbols.FeedInfluentLogic.RESET_BTNSEventArgs> RESET_BTNS_Fired;

    private event EventHandler<SE.Nereda.Symbols.FeedInfluentLogic.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    protected override void OnEndInit()
    {
      if (GRAPH_Fired != null)
        AttachEventInput(0);
      if (FB_LEVEL_SP_Fired != null)
        AttachEventInput(1);
      if (HI_HI_Fired != null)
        AttachEventInput(2);
      if (FREEZE_Fired != null)
        AttachEventInput(3);
      if (RESET_BTNS_Fired != null)
        AttachEventInput(4);
      if (LOAD_PERS_DATA_Fired != null)
        AttachEventInput(5);

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
              GRAPH_Fired(this, new SE.Nereda.Symbols.FeedInfluentLogic.GRAPHEventArgs(channelId, cookie, eventIndex));
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
          if (FB_LEVEL_SP_Fired != null)
          {
            try
            {
              FB_LEVEL_SP_Fired(this, new SE.Nereda.Symbols.FeedInfluentLogic.FB_LEVEL_SPEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","FB_LEVEL_SP_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 2:
          if (HI_HI_Fired != null)
          {
            try
            {
              HI_HI_Fired(this, new SE.Nereda.Symbols.FeedInfluentLogic.HI_HIEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","HI_HI_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 3:
          if (FREEZE_Fired != null)
          {
            try
            {
              FREEZE_Fired(this, new SE.Nereda.Symbols.FeedInfluentLogic.FREEZEEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","FREEZE_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 4:
          if (RESET_BTNS_Fired != null)
          {
            try
            {
              RESET_BTNS_Fired(this, new SE.Nereda.Symbols.FeedInfluentLogic.RESET_BTNSEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","RESET_BTNS_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 5:
          if (LOAD_PERS_DATA_Fired != null)
          {
            try
            {
              LOAD_PERS_DATA_Fired(this, new SE.Nereda.Symbols.FeedInfluentLogic.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","LOAD_PERS_DATA_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_CNF_DUR_SP(NxtControl.GuiFramework.Time FreezRunDurSp, NxtControl.GuiFramework.Time FreezStopDurSp, NxtControl.GuiFramework.Time FT95FlowPvWaitTime)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {FreezRunDurSp, FreezStopDurSp, FT95FlowPvWaitTime});
    }
    public bool FireEvent_CNF_DUR_SP(SE.Nereda.Symbols.FeedInfluentLogic.CNF_DUR_SPEventArgs ea)
    {
      object[] _values_ = new object[3];
      if (ea.FreezRunDurSp.HasValue) _values_[0] = ea.FreezRunDurSp.Value;
      if (ea.FreezStopDurSp.HasValue) _values_[1] = ea.FreezStopDurSp.Value;
      if (ea.FT95FlowPvWaitTime.HasValue) _values_[2] = ea.FT95FlowPvWaitTime.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_CNF_DUR_SP(NxtControl.GuiFramework.Time FreezRunDurSp, bool ignore_FreezRunDurSp, NxtControl.GuiFramework.Time FreezStopDurSp, bool ignore_FreezStopDurSp, NxtControl.GuiFramework.Time FT95FlowPvWaitTime, bool ignore_FT95FlowPvWaitTime)
    {
      object[] _values_ = new object[3];
      if (!ignore_FreezRunDurSp) _values_[0] = FreezRunDurSp;
      if (!ignore_FreezStopDurSp) _values_[1] = FreezStopDurSp;
      if (!ignore_FT95FlowPvWaitTime) _values_[2] = FT95FlowPvWaitTime;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_CNF_FREEZ_SP(System.Single FreezWeatherSp)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {FreezWeatherSp});
    }
    public bool FireEvent_CNF_FREEZ_SP(SE.Nereda.Symbols.FeedInfluentLogic.CNF_FREEZ_SPEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.FreezWeatherSp.HasValue) _values_[0] = ea.FreezWeatherSp.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_CNF_FREEZ_SP(System.Single FreezWeatherSp, bool ignore_FreezWeatherSp)
    {
      object[] _values_ = new object[1];
      if (!ignore_FreezWeatherSp) _values_[0] = FreezWeatherSp;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_CNF_RESET(System.Boolean ResetLogic)
    {
      return ((IHMIAccessorOutput)this).FireEvent(2, new object[] {ResetLogic});
    }
    public bool FireEvent_CNF_RESET(SE.Nereda.Symbols.FeedInfluentLogic.CNF_RESETEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.ResetLogic.HasValue) _values_[0] = ea.ResetLogic.Value;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_CNF_RESET(System.Boolean ResetLogic, bool ignore_ResetLogic)
    {
      object[] _values_ = new object[1];
      if (!ignore_ResetLogic) _values_[0] = ResetLogic;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_CNF_SP(System.Single StartLevelSp, System.Single StopLevelSp, System.Single BreakPointSp, System.Single MaxFlowSp, NxtControl.GuiFramework.Time FT95FlowPvWaitTime)
    {
      return ((IHMIAccessorOutput)this).FireEvent(3, new object[] {StartLevelSp, StopLevelSp, BreakPointSp, MaxFlowSp, FT95FlowPvWaitTime});
    }
    public bool FireEvent_CNF_SP(SE.Nereda.Symbols.FeedInfluentLogic.CNF_SPEventArgs ea)
    {
      object[] _values_ = new object[5];
      if (ea.StartLevelSp.HasValue) _values_[0] = ea.StartLevelSp.Value;
      if (ea.StopLevelSp.HasValue) _values_[1] = ea.StopLevelSp.Value;
      if (ea.BreakPointSp.HasValue) _values_[2] = ea.BreakPointSp.Value;
      if (ea.MaxFlowSp.HasValue) _values_[3] = ea.MaxFlowSp.Value;
      if (ea.FT95FlowPvWaitTime.HasValue) _values_[4] = ea.FT95FlowPvWaitTime.Value;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_CNF_SP(System.Single StartLevelSp, bool ignore_StartLevelSp, System.Single StopLevelSp, bool ignore_StopLevelSp, System.Single BreakPointSp, bool ignore_BreakPointSp, System.Single MaxFlowSp, bool ignore_MaxFlowSp, NxtControl.GuiFramework.Time FT95FlowPvWaitTime, bool ignore_FT95FlowPvWaitTime)
    {
      object[] _values_ = new object[5];
      if (!ignore_StartLevelSp) _values_[0] = StartLevelSp;
      if (!ignore_StopLevelSp) _values_[1] = StopLevelSp;
      if (!ignore_BreakPointSp) _values_[2] = BreakPointSp;
      if (!ignore_MaxFlowSp) _values_[3] = MaxFlowSp;
      if (!ignore_FT95FlowPvWaitTime) _values_[4] = FT95FlowPvWaitTime;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_CNF_RESET_F_ILCK(System.Boolean ResetLoLoFlowIlck)
    {
      return ((IHMIAccessorOutput)this).FireEvent(4, new object[] {ResetLoLoFlowIlck});
    }
    public bool FireEvent_CNF_RESET_F_ILCK(SE.Nereda.Symbols.FeedInfluentLogic.CNF_RESET_F_ILCKEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.ResetLoLoFlowIlck.HasValue) _values_[0] = ea.ResetLoLoFlowIlck.Value;
      return ((IHMIAccessorOutput)this).FireEvent(4, _values_);
    }
    public bool FireEvent_CNF_RESET_F_ILCK(System.Boolean ResetLoLoFlowIlck, bool ignore_ResetLoLoFlowIlck)
    {
      object[] _values_ = new object[1];
      if (!ignore_ResetLoLoFlowIlck) _values_[0] = ResetLoLoFlowIlck;
      return ((IHMIAccessorOutput)this).FireEvent(4, _values_);
    }

  }
}

namespace SE.Nereda.Symbols.FeedInfluentLogic
{
  partial class sGrafcet
  {

    private event EventHandler<SE.Nereda.Symbols.FeedInfluentLogic.GRAPHEventArgs> GRAPH_Fired;

    private event EventHandler<SE.Nereda.Symbols.FeedInfluentLogic.FB_LEVEL_SPEventArgs> FB_LEVEL_SP_Fired;

    private event EventHandler<SE.Nereda.Symbols.FeedInfluentLogic.HI_HIEventArgs> HI_HI_Fired;

    private event EventHandler<SE.Nereda.Symbols.FeedInfluentLogic.FREEZEEventArgs> FREEZE_Fired;

    private event EventHandler<SE.Nereda.Symbols.FeedInfluentLogic.RESET_BTNSEventArgs> RESET_BTNS_Fired;

    private event EventHandler<SE.Nereda.Symbols.FeedInfluentLogic.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    protected override void OnEndInit()
    {
      if (GRAPH_Fired != null)
        AttachEventInput(0);
      if (FB_LEVEL_SP_Fired != null)
        AttachEventInput(1);
      if (HI_HI_Fired != null)
        AttachEventInput(2);
      if (FREEZE_Fired != null)
        AttachEventInput(3);
      if (RESET_BTNS_Fired != null)
        AttachEventInput(4);
      if (LOAD_PERS_DATA_Fired != null)
        AttachEventInput(5);

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
              GRAPH_Fired(this, new SE.Nereda.Symbols.FeedInfluentLogic.GRAPHEventArgs(channelId, cookie, eventIndex));
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
          if (FB_LEVEL_SP_Fired != null)
          {
            try
            {
              FB_LEVEL_SP_Fired(this, new SE.Nereda.Symbols.FeedInfluentLogic.FB_LEVEL_SPEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","FB_LEVEL_SP_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 2:
          if (HI_HI_Fired != null)
          {
            try
            {
              HI_HI_Fired(this, new SE.Nereda.Symbols.FeedInfluentLogic.HI_HIEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","HI_HI_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 3:
          if (FREEZE_Fired != null)
          {
            try
            {
              FREEZE_Fired(this, new SE.Nereda.Symbols.FeedInfluentLogic.FREEZEEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","FREEZE_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 4:
          if (RESET_BTNS_Fired != null)
          {
            try
            {
              RESET_BTNS_Fired(this, new SE.Nereda.Symbols.FeedInfluentLogic.RESET_BTNSEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","RESET_BTNS_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 5:
          if (LOAD_PERS_DATA_Fired != null)
          {
            try
            {
              LOAD_PERS_DATA_Fired(this, new SE.Nereda.Symbols.FeedInfluentLogic.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","LOAD_PERS_DATA_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_CNF_DUR_SP(NxtControl.GuiFramework.Time FreezRunDurSp, NxtControl.GuiFramework.Time FreezStopDurSp, NxtControl.GuiFramework.Time FT95FlowPvWaitTime)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {FreezRunDurSp, FreezStopDurSp, FT95FlowPvWaitTime});
    }
    public bool FireEvent_CNF_DUR_SP(SE.Nereda.Symbols.FeedInfluentLogic.CNF_DUR_SPEventArgs ea)
    {
      object[] _values_ = new object[3];
      if (ea.FreezRunDurSp.HasValue) _values_[0] = ea.FreezRunDurSp.Value;
      if (ea.FreezStopDurSp.HasValue) _values_[1] = ea.FreezStopDurSp.Value;
      if (ea.FT95FlowPvWaitTime.HasValue) _values_[2] = ea.FT95FlowPvWaitTime.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_CNF_DUR_SP(NxtControl.GuiFramework.Time FreezRunDurSp, bool ignore_FreezRunDurSp, NxtControl.GuiFramework.Time FreezStopDurSp, bool ignore_FreezStopDurSp, NxtControl.GuiFramework.Time FT95FlowPvWaitTime, bool ignore_FT95FlowPvWaitTime)
    {
      object[] _values_ = new object[3];
      if (!ignore_FreezRunDurSp) _values_[0] = FreezRunDurSp;
      if (!ignore_FreezStopDurSp) _values_[1] = FreezStopDurSp;
      if (!ignore_FT95FlowPvWaitTime) _values_[2] = FT95FlowPvWaitTime;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_CNF_FREEZ_SP(System.Single FreezWeatherSp)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {FreezWeatherSp});
    }
    public bool FireEvent_CNF_FREEZ_SP(SE.Nereda.Symbols.FeedInfluentLogic.CNF_FREEZ_SPEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.FreezWeatherSp.HasValue) _values_[0] = ea.FreezWeatherSp.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_CNF_FREEZ_SP(System.Single FreezWeatherSp, bool ignore_FreezWeatherSp)
    {
      object[] _values_ = new object[1];
      if (!ignore_FreezWeatherSp) _values_[0] = FreezWeatherSp;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_CNF_RESET(System.Boolean ResetLogic)
    {
      return ((IHMIAccessorOutput)this).FireEvent(2, new object[] {ResetLogic});
    }
    public bool FireEvent_CNF_RESET(SE.Nereda.Symbols.FeedInfluentLogic.CNF_RESETEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.ResetLogic.HasValue) _values_[0] = ea.ResetLogic.Value;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_CNF_RESET(System.Boolean ResetLogic, bool ignore_ResetLogic)
    {
      object[] _values_ = new object[1];
      if (!ignore_ResetLogic) _values_[0] = ResetLogic;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_CNF_SP(System.Single StartLevelSp, System.Single StopLevelSp, System.Single BreakPointSp, System.Single MaxFlowSp, NxtControl.GuiFramework.Time FT95FlowPvWaitTime)
    {
      return ((IHMIAccessorOutput)this).FireEvent(3, new object[] {StartLevelSp, StopLevelSp, BreakPointSp, MaxFlowSp, FT95FlowPvWaitTime});
    }
    public bool FireEvent_CNF_SP(SE.Nereda.Symbols.FeedInfluentLogic.CNF_SPEventArgs ea)
    {
      object[] _values_ = new object[5];
      if (ea.StartLevelSp.HasValue) _values_[0] = ea.StartLevelSp.Value;
      if (ea.StopLevelSp.HasValue) _values_[1] = ea.StopLevelSp.Value;
      if (ea.BreakPointSp.HasValue) _values_[2] = ea.BreakPointSp.Value;
      if (ea.MaxFlowSp.HasValue) _values_[3] = ea.MaxFlowSp.Value;
      if (ea.FT95FlowPvWaitTime.HasValue) _values_[4] = ea.FT95FlowPvWaitTime.Value;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_CNF_SP(System.Single StartLevelSp, bool ignore_StartLevelSp, System.Single StopLevelSp, bool ignore_StopLevelSp, System.Single BreakPointSp, bool ignore_BreakPointSp, System.Single MaxFlowSp, bool ignore_MaxFlowSp, NxtControl.GuiFramework.Time FT95FlowPvWaitTime, bool ignore_FT95FlowPvWaitTime)
    {
      object[] _values_ = new object[5];
      if (!ignore_StartLevelSp) _values_[0] = StartLevelSp;
      if (!ignore_StopLevelSp) _values_[1] = StopLevelSp;
      if (!ignore_BreakPointSp) _values_[2] = BreakPointSp;
      if (!ignore_MaxFlowSp) _values_[3] = MaxFlowSp;
      if (!ignore_FT95FlowPvWaitTime) _values_[4] = FT95FlowPvWaitTime;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_CNF_RESET_F_ILCK(System.Boolean ResetLoLoFlowIlck)
    {
      return ((IHMIAccessorOutput)this).FireEvent(4, new object[] {ResetLoLoFlowIlck});
    }
    public bool FireEvent_CNF_RESET_F_ILCK(SE.Nereda.Symbols.FeedInfluentLogic.CNF_RESET_F_ILCKEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.ResetLoLoFlowIlck.HasValue) _values_[0] = ea.ResetLoLoFlowIlck.Value;
      return ((IHMIAccessorOutput)this).FireEvent(4, _values_);
    }
    public bool FireEvent_CNF_RESET_F_ILCK(System.Boolean ResetLoLoFlowIlck, bool ignore_ResetLoLoFlowIlck)
    {
      object[] _values_ = new object[1];
      if (!ignore_ResetLoLoFlowIlck) _values_[0] = ResetLoLoFlowIlck;
      return ((IHMIAccessorOutput)this).FireEvent(4, _values_);
    }

  }
}

namespace SE.Nereda.Symbols.FeedInfluentLogic
{
  partial class sFreezWDuration
  {

    private event EventHandler<SE.Nereda.Symbols.FeedInfluentLogic.GRAPHEventArgs> GRAPH_Fired;

    private event EventHandler<SE.Nereda.Symbols.FeedInfluentLogic.FB_LEVEL_SPEventArgs> FB_LEVEL_SP_Fired;

    private event EventHandler<SE.Nereda.Symbols.FeedInfluentLogic.HI_HIEventArgs> HI_HI_Fired;

    private event EventHandler<SE.Nereda.Symbols.FeedInfluentLogic.FREEZEEventArgs> FREEZE_Fired;

    private event EventHandler<SE.Nereda.Symbols.FeedInfluentLogic.RESET_BTNSEventArgs> RESET_BTNS_Fired;

    private event EventHandler<SE.Nereda.Symbols.FeedInfluentLogic.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    protected override void OnEndInit()
    {
      if (GRAPH_Fired != null)
        AttachEventInput(0);
      if (FB_LEVEL_SP_Fired != null)
        AttachEventInput(1);
      if (HI_HI_Fired != null)
        AttachEventInput(2);
      if (FREEZE_Fired != null)
        AttachEventInput(3);
      if (RESET_BTNS_Fired != null)
        AttachEventInput(4);
      if (LOAD_PERS_DATA_Fired != null)
        AttachEventInput(5);

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
              GRAPH_Fired(this, new SE.Nereda.Symbols.FeedInfluentLogic.GRAPHEventArgs(channelId, cookie, eventIndex));
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
          if (FB_LEVEL_SP_Fired != null)
          {
            try
            {
              FB_LEVEL_SP_Fired(this, new SE.Nereda.Symbols.FeedInfluentLogic.FB_LEVEL_SPEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","FB_LEVEL_SP_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 2:
          if (HI_HI_Fired != null)
          {
            try
            {
              HI_HI_Fired(this, new SE.Nereda.Symbols.FeedInfluentLogic.HI_HIEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","HI_HI_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 3:
          if (FREEZE_Fired != null)
          {
            try
            {
              FREEZE_Fired(this, new SE.Nereda.Symbols.FeedInfluentLogic.FREEZEEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","FREEZE_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 4:
          if (RESET_BTNS_Fired != null)
          {
            try
            {
              RESET_BTNS_Fired(this, new SE.Nereda.Symbols.FeedInfluentLogic.RESET_BTNSEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","RESET_BTNS_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 5:
          if (LOAD_PERS_DATA_Fired != null)
          {
            try
            {
              LOAD_PERS_DATA_Fired(this, new SE.Nereda.Symbols.FeedInfluentLogic.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","LOAD_PERS_DATA_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_CNF_DUR_SP(NxtControl.GuiFramework.Time FreezRunDurSp, NxtControl.GuiFramework.Time FreezStopDurSp, NxtControl.GuiFramework.Time FT95FlowPvWaitTime)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {FreezRunDurSp, FreezStopDurSp, FT95FlowPvWaitTime});
    }
    public bool FireEvent_CNF_DUR_SP(SE.Nereda.Symbols.FeedInfluentLogic.CNF_DUR_SPEventArgs ea)
    {
      object[] _values_ = new object[3];
      if (ea.FreezRunDurSp.HasValue) _values_[0] = ea.FreezRunDurSp.Value;
      if (ea.FreezStopDurSp.HasValue) _values_[1] = ea.FreezStopDurSp.Value;
      if (ea.FT95FlowPvWaitTime.HasValue) _values_[2] = ea.FT95FlowPvWaitTime.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_CNF_DUR_SP(NxtControl.GuiFramework.Time FreezRunDurSp, bool ignore_FreezRunDurSp, NxtControl.GuiFramework.Time FreezStopDurSp, bool ignore_FreezStopDurSp, NxtControl.GuiFramework.Time FT95FlowPvWaitTime, bool ignore_FT95FlowPvWaitTime)
    {
      object[] _values_ = new object[3];
      if (!ignore_FreezRunDurSp) _values_[0] = FreezRunDurSp;
      if (!ignore_FreezStopDurSp) _values_[1] = FreezStopDurSp;
      if (!ignore_FT95FlowPvWaitTime) _values_[2] = FT95FlowPvWaitTime;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_CNF_FREEZ_SP(System.Single FreezWeatherSp)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {FreezWeatherSp});
    }
    public bool FireEvent_CNF_FREEZ_SP(SE.Nereda.Symbols.FeedInfluentLogic.CNF_FREEZ_SPEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.FreezWeatherSp.HasValue) _values_[0] = ea.FreezWeatherSp.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_CNF_FREEZ_SP(System.Single FreezWeatherSp, bool ignore_FreezWeatherSp)
    {
      object[] _values_ = new object[1];
      if (!ignore_FreezWeatherSp) _values_[0] = FreezWeatherSp;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_CNF_RESET(System.Boolean ResetLogic)
    {
      return ((IHMIAccessorOutput)this).FireEvent(2, new object[] {ResetLogic});
    }
    public bool FireEvent_CNF_RESET(SE.Nereda.Symbols.FeedInfluentLogic.CNF_RESETEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.ResetLogic.HasValue) _values_[0] = ea.ResetLogic.Value;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_CNF_RESET(System.Boolean ResetLogic, bool ignore_ResetLogic)
    {
      object[] _values_ = new object[1];
      if (!ignore_ResetLogic) _values_[0] = ResetLogic;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_CNF_SP(System.Single StartLevelSp, System.Single StopLevelSp, System.Single BreakPointSp, System.Single MaxFlowSp, NxtControl.GuiFramework.Time FT95FlowPvWaitTime)
    {
      return ((IHMIAccessorOutput)this).FireEvent(3, new object[] {StartLevelSp, StopLevelSp, BreakPointSp, MaxFlowSp, FT95FlowPvWaitTime});
    }
    public bool FireEvent_CNF_SP(SE.Nereda.Symbols.FeedInfluentLogic.CNF_SPEventArgs ea)
    {
      object[] _values_ = new object[5];
      if (ea.StartLevelSp.HasValue) _values_[0] = ea.StartLevelSp.Value;
      if (ea.StopLevelSp.HasValue) _values_[1] = ea.StopLevelSp.Value;
      if (ea.BreakPointSp.HasValue) _values_[2] = ea.BreakPointSp.Value;
      if (ea.MaxFlowSp.HasValue) _values_[3] = ea.MaxFlowSp.Value;
      if (ea.FT95FlowPvWaitTime.HasValue) _values_[4] = ea.FT95FlowPvWaitTime.Value;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_CNF_SP(System.Single StartLevelSp, bool ignore_StartLevelSp, System.Single StopLevelSp, bool ignore_StopLevelSp, System.Single BreakPointSp, bool ignore_BreakPointSp, System.Single MaxFlowSp, bool ignore_MaxFlowSp, NxtControl.GuiFramework.Time FT95FlowPvWaitTime, bool ignore_FT95FlowPvWaitTime)
    {
      object[] _values_ = new object[5];
      if (!ignore_StartLevelSp) _values_[0] = StartLevelSp;
      if (!ignore_StopLevelSp) _values_[1] = StopLevelSp;
      if (!ignore_BreakPointSp) _values_[2] = BreakPointSp;
      if (!ignore_MaxFlowSp) _values_[3] = MaxFlowSp;
      if (!ignore_FT95FlowPvWaitTime) _values_[4] = FT95FlowPvWaitTime;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_CNF_RESET_F_ILCK(System.Boolean ResetLoLoFlowIlck)
    {
      return ((IHMIAccessorOutput)this).FireEvent(4, new object[] {ResetLoLoFlowIlck});
    }
    public bool FireEvent_CNF_RESET_F_ILCK(SE.Nereda.Symbols.FeedInfluentLogic.CNF_RESET_F_ILCKEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.ResetLoLoFlowIlck.HasValue) _values_[0] = ea.ResetLoLoFlowIlck.Value;
      return ((IHMIAccessorOutput)this).FireEvent(4, _values_);
    }
    public bool FireEvent_CNF_RESET_F_ILCK(System.Boolean ResetLoLoFlowIlck, bool ignore_ResetLoLoFlowIlck)
    {
      object[] _values_ = new object[1];
      if (!ignore_ResetLoLoFlowIlck) _values_[0] = ResetLoLoFlowIlck;
      return ((IHMIAccessorOutput)this).FireEvent(4, _values_);
    }

  }
}

namespace SE.Nereda.Faceplates.FeedInfluentLogic
{
  partial class fpFreezWDur
  {

    private event EventHandler<SE.Nereda.Symbols.FeedInfluentLogic.GRAPHEventArgs> GRAPH_Fired;

    private event EventHandler<SE.Nereda.Symbols.FeedInfluentLogic.FB_LEVEL_SPEventArgs> FB_LEVEL_SP_Fired;

    private event EventHandler<SE.Nereda.Symbols.FeedInfluentLogic.HI_HIEventArgs> HI_HI_Fired;

    private event EventHandler<SE.Nereda.Symbols.FeedInfluentLogic.FREEZEEventArgs> FREEZE_Fired;

    private event EventHandler<SE.Nereda.Symbols.FeedInfluentLogic.RESET_BTNSEventArgs> RESET_BTNS_Fired;

    private event EventHandler<SE.Nereda.Symbols.FeedInfluentLogic.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    protected override void OnEndInit()
    {
      if (GRAPH_Fired != null)
        AttachEventInput(0);
      if (FB_LEVEL_SP_Fired != null)
        AttachEventInput(1);
      if (HI_HI_Fired != null)
        AttachEventInput(2);
      if (FREEZE_Fired != null)
        AttachEventInput(3);
      if (RESET_BTNS_Fired != null)
        AttachEventInput(4);
      if (LOAD_PERS_DATA_Fired != null)
        AttachEventInput(5);

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
              GRAPH_Fired(this, new SE.Nereda.Symbols.FeedInfluentLogic.GRAPHEventArgs(channelId, cookie, eventIndex));
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
          if (FB_LEVEL_SP_Fired != null)
          {
            try
            {
              FB_LEVEL_SP_Fired(this, new SE.Nereda.Symbols.FeedInfluentLogic.FB_LEVEL_SPEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","FB_LEVEL_SP_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 2:
          if (HI_HI_Fired != null)
          {
            try
            {
              HI_HI_Fired(this, new SE.Nereda.Symbols.FeedInfluentLogic.HI_HIEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","HI_HI_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 3:
          if (FREEZE_Fired != null)
          {
            try
            {
              FREEZE_Fired(this, new SE.Nereda.Symbols.FeedInfluentLogic.FREEZEEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","FREEZE_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 4:
          if (RESET_BTNS_Fired != null)
          {
            try
            {
              RESET_BTNS_Fired(this, new SE.Nereda.Symbols.FeedInfluentLogic.RESET_BTNSEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","RESET_BTNS_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 5:
          if (LOAD_PERS_DATA_Fired != null)
          {
            try
            {
              LOAD_PERS_DATA_Fired(this, new SE.Nereda.Symbols.FeedInfluentLogic.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","LOAD_PERS_DATA_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_CNF_DUR_SP(NxtControl.GuiFramework.Time FreezRunDurSp, NxtControl.GuiFramework.Time FreezStopDurSp, NxtControl.GuiFramework.Time FT95FlowPvWaitTime)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {FreezRunDurSp, FreezStopDurSp, FT95FlowPvWaitTime});
    }
    public bool FireEvent_CNF_DUR_SP(SE.Nereda.Symbols.FeedInfluentLogic.CNF_DUR_SPEventArgs ea)
    {
      object[] _values_ = new object[3];
      if (ea.FreezRunDurSp.HasValue) _values_[0] = ea.FreezRunDurSp.Value;
      if (ea.FreezStopDurSp.HasValue) _values_[1] = ea.FreezStopDurSp.Value;
      if (ea.FT95FlowPvWaitTime.HasValue) _values_[2] = ea.FT95FlowPvWaitTime.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_CNF_DUR_SP(NxtControl.GuiFramework.Time FreezRunDurSp, bool ignore_FreezRunDurSp, NxtControl.GuiFramework.Time FreezStopDurSp, bool ignore_FreezStopDurSp, NxtControl.GuiFramework.Time FT95FlowPvWaitTime, bool ignore_FT95FlowPvWaitTime)
    {
      object[] _values_ = new object[3];
      if (!ignore_FreezRunDurSp) _values_[0] = FreezRunDurSp;
      if (!ignore_FreezStopDurSp) _values_[1] = FreezStopDurSp;
      if (!ignore_FT95FlowPvWaitTime) _values_[2] = FT95FlowPvWaitTime;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_CNF_FREEZ_SP(System.Single FreezWeatherSp)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {FreezWeatherSp});
    }
    public bool FireEvent_CNF_FREEZ_SP(SE.Nereda.Symbols.FeedInfluentLogic.CNF_FREEZ_SPEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.FreezWeatherSp.HasValue) _values_[0] = ea.FreezWeatherSp.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_CNF_FREEZ_SP(System.Single FreezWeatherSp, bool ignore_FreezWeatherSp)
    {
      object[] _values_ = new object[1];
      if (!ignore_FreezWeatherSp) _values_[0] = FreezWeatherSp;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_CNF_RESET(System.Boolean ResetLogic)
    {
      return ((IHMIAccessorOutput)this).FireEvent(2, new object[] {ResetLogic});
    }
    public bool FireEvent_CNF_RESET(SE.Nereda.Symbols.FeedInfluentLogic.CNF_RESETEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.ResetLogic.HasValue) _values_[0] = ea.ResetLogic.Value;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_CNF_RESET(System.Boolean ResetLogic, bool ignore_ResetLogic)
    {
      object[] _values_ = new object[1];
      if (!ignore_ResetLogic) _values_[0] = ResetLogic;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_CNF_SP(System.Single StartLevelSp, System.Single StopLevelSp, System.Single BreakPointSp, System.Single MaxFlowSp, NxtControl.GuiFramework.Time FT95FlowPvWaitTime)
    {
      return ((IHMIAccessorOutput)this).FireEvent(3, new object[] {StartLevelSp, StopLevelSp, BreakPointSp, MaxFlowSp, FT95FlowPvWaitTime});
    }
    public bool FireEvent_CNF_SP(SE.Nereda.Symbols.FeedInfluentLogic.CNF_SPEventArgs ea)
    {
      object[] _values_ = new object[5];
      if (ea.StartLevelSp.HasValue) _values_[0] = ea.StartLevelSp.Value;
      if (ea.StopLevelSp.HasValue) _values_[1] = ea.StopLevelSp.Value;
      if (ea.BreakPointSp.HasValue) _values_[2] = ea.BreakPointSp.Value;
      if (ea.MaxFlowSp.HasValue) _values_[3] = ea.MaxFlowSp.Value;
      if (ea.FT95FlowPvWaitTime.HasValue) _values_[4] = ea.FT95FlowPvWaitTime.Value;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_CNF_SP(System.Single StartLevelSp, bool ignore_StartLevelSp, System.Single StopLevelSp, bool ignore_StopLevelSp, System.Single BreakPointSp, bool ignore_BreakPointSp, System.Single MaxFlowSp, bool ignore_MaxFlowSp, NxtControl.GuiFramework.Time FT95FlowPvWaitTime, bool ignore_FT95FlowPvWaitTime)
    {
      object[] _values_ = new object[5];
      if (!ignore_StartLevelSp) _values_[0] = StartLevelSp;
      if (!ignore_StopLevelSp) _values_[1] = StopLevelSp;
      if (!ignore_BreakPointSp) _values_[2] = BreakPointSp;
      if (!ignore_MaxFlowSp) _values_[3] = MaxFlowSp;
      if (!ignore_FT95FlowPvWaitTime) _values_[4] = FT95FlowPvWaitTime;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_CNF_RESET_F_ILCK(System.Boolean ResetLoLoFlowIlck)
    {
      return ((IHMIAccessorOutput)this).FireEvent(4, new object[] {ResetLoLoFlowIlck});
    }
    public bool FireEvent_CNF_RESET_F_ILCK(SE.Nereda.Symbols.FeedInfluentLogic.CNF_RESET_F_ILCKEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.ResetLoLoFlowIlck.HasValue) _values_[0] = ea.ResetLoLoFlowIlck.Value;
      return ((IHMIAccessorOutput)this).FireEvent(4, _values_);
    }
    public bool FireEvent_CNF_RESET_F_ILCK(System.Boolean ResetLoLoFlowIlck, bool ignore_ResetLoLoFlowIlck)
    {
      object[] _values_ = new object[1];
      if (!ignore_ResetLoLoFlowIlck) _values_[0] = ResetLoLoFlowIlck;
      return ((IHMIAccessorOutput)this).FireEvent(4, _values_);
    }

  }
}
#endregion #FeedInfluentLogic_HMI;

#endregion Definitions;
