/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 7/4/2026
 * Time: 10:10 PM
 * 
 */
using System;
using NxtControl.GuiFramework;
using NxtControl.Services;

#region Definitions;
#region #EmergencyReactor_HMI;

namespace SE.Nereda.Symbols.EmergencyReactor
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

  public class EMERGENCY_ONEventArgs : System.EventArgs
  {
    IHMIAccessorService accessorService;
    int channelId;
    int cookie; 
    int eventIndex;

    public EMERGENCY_ONEventArgs(int channelId, int cookie, int eventIndex)
    {
      this.accessorService = (IHMIAccessorService)ServiceProvider.GetService(typeof(IHMIAccessorService));
      this.channelId = channelId;
      this.cookie = cookie;
      this.eventIndex = eventIndex;
    }
    public bool Get_EmergencyON(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,0, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? EmergencyON
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,0, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }


  }

  public class RESET_F_TRSEventArgs : System.EventArgs
  {
    IHMIAccessorService accessorService;
    int channelId;
    int cookie; 
    int eventIndex;

    public RESET_F_TRSEventArgs(int channelId, int cookie, int eventIndex)
    {
      this.accessorService = (IHMIAccessorService)ServiceProvider.GetService(typeof(IHMIAccessorService));
      this.channelId = channelId;
      this.cookie = cookie;
      this.eventIndex = eventIndex;
    }

  }

  public class ENABLE_FORCE_INEventArgs : System.EventArgs
  {
    IHMIAccessorService accessorService;
    int channelId;
    int cookie; 
    int eventIndex;

    public ENABLE_FORCE_INEventArgs(int channelId, int cookie, int eventIndex)
    {
      this.accessorService = (IHMIAccessorService)ServiceProvider.GetService(typeof(IHMIAccessorService));
      this.channelId = channelId;
      this.cookie = cookie;
      this.eventIndex = eventIndex;
    }
    public bool Get_iEnableForce(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,0, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? iEnableForce
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,0, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }


  }

  public class S5_AERATE_TEventArgs : System.EventArgs
  {
    IHMIAccessorService accessorService;
    int channelId;
    int cookie; 
    int eventIndex;

    public S5_AERATE_TEventArgs(int channelId, int cookie, int eventIndex)
    {
      this.accessorService = (IHMIAccessorService)ServiceProvider.GetService(typeof(IHMIAccessorService));
      this.channelId = channelId;
      this.cookie = cookie;
      this.eventIndex = eventIndex;
    }
    public bool Get_S5_AerateTime(ref NxtControl.GuiFramework.Time value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,0, ref var);
      if (ret) value = (NxtControl.GuiFramework.Time) var;
      return ret;
    }

    public NxtControl.GuiFramework.Time? S5_AerateTime
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,0, ref var);
      if (!ret) return null;
      return (NxtControl.GuiFramework.Time) var;
    }  }

    public bool Get_CurrAerateTime(ref NxtControl.GuiFramework.Time value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,1, ref var);
      if (ret) value = (NxtControl.GuiFramework.Time) var;
      return ret;
    }

    public NxtControl.GuiFramework.Time? CurrAerateTime
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,1, ref var);
      if (!ret) return null;
      return (NxtControl.GuiFramework.Time) var;
    }  }


  }

  public class WARNINGEventArgs : System.EventArgs
  {
    IHMIAccessorService accessorService;
    int channelId;
    int cookie; 
    int eventIndex;

    public WARNINGEventArgs(int channelId, int cookie, int eventIndex)
    {
      this.accessorService = (IHMIAccessorService)ServiceProvider.GetService(typeof(IHMIAccessorService));
      this.channelId = channelId;
      this.cookie = cookie;
      this.eventIndex = eventIndex;
    }
    public bool Get_WarningSteps(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,0, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? WarningSteps
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,0, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
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

  public class FORCE_UNAVEventArgs : System.EventArgs
  {
    IHMIAccessorService accessorService;
    int channelId;
    int cookie; 
    int eventIndex;

    public FORCE_UNAVEventArgs(int channelId, int cookie, int eventIndex)
    {
      this.accessorService = (IHMIAccessorService)ServiceProvider.GetService(typeof(IHMIAccessorService));
      this.channelId = channelId;
      this.cookie = cookie;
      this.eventIndex = eventIndex;
    }
    public bool Get_ForceUnavailable(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,0, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? ForceUnavailable
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

namespace SE.Nereda.Symbols.EmergencyReactor
{

  public class FORCEEventArgs : System.EventArgs
  {
    public FORCEEventArgs()
    {
    }
    private System.Int16? Force_field = null;
    public System.Int16? Force
    {
       get { return Force_field; }
       set { Force_field = value; }
    }

  }

  public class ENABLE_FORCE_OUTEventArgs : System.EventArgs
  {
    public ENABLE_FORCE_OUTEventArgs()
    {
    }
    private System.Boolean? oEnableForce_field = null;
    public System.Boolean? oEnableForce
    {
       get { return oEnableForce_field; }
       set { oEnableForce_field = value; }
    }

  }

  public class STEPS_TIMEEventArgs : System.EventArgs
  {
    public STEPS_TIMEEventArgs()
    {
    }
    private NxtControl.GuiFramework.Time? S1_FeedTime_field = null;
    public NxtControl.GuiFramework.Time? S1_FeedTime
    {
       get { return S1_FeedTime_field; }
       set { S1_FeedTime_field = value; }
    }
    private NxtControl.GuiFramework.Time? S2_WaitTime_field = null;
    public NxtControl.GuiFramework.Time? S2_WaitTime
    {
       get { return S2_WaitTime_field; }
       set { S2_WaitTime_field = value; }
    }
    private NxtControl.GuiFramework.Time? S3_SludgeDischargeTime_field = null;
    public NxtControl.GuiFramework.Time? S3_SludgeDischargeTime
    {
       get { return S3_SludgeDischargeTime_field; }
       set { S3_SludgeDischargeTime_field = value; }
    }
    private NxtControl.GuiFramework.Time? S4_LowerLevelTime_field = null;
    public NxtControl.GuiFramework.Time? S4_LowerLevelTime
    {
       get { return S4_LowerLevelTime_field; }
       set { S4_LowerLevelTime_field = value; }
    }
    private NxtControl.GuiFramework.Time? S6_VentTime_field = null;
    public NxtControl.GuiFramework.Time? S6_VentTime
    {
       get { return S6_VentTime_field; }
       set { S6_VentTime_field = value; }
    }
    private NxtControl.GuiFramework.Time? S7_SludgeDischargeTime_field = null;
    public NxtControl.GuiFramework.Time? S7_SludgeDischargeTime
    {
       get { return S7_SludgeDischargeTime_field; }
       set { S7_SludgeDischargeTime_field = value; }
    }
    private NxtControl.GuiFramework.Time? S8_WaitTime_field = null;
    public NxtControl.GuiFramework.Time? S8_WaitTime
    {
       get { return S8_WaitTime_field; }
       set { S8_WaitTime_field = value; }
    }

  }

  public class FEED_PAREventArgs : System.EventArgs
  {
    public FEED_PAREventArgs()
    {
    }
    private System.Single? FeedCapacity_field = null;
    public System.Single? FeedCapacity
    {
       get { return FeedCapacity_field; }
       set { FeedCapacity_field = value; }
    }

  }

  public class AERATE_PAREventArgs : System.EventArgs
  {
    public AERATE_PAREventArgs()
    {
    }
    private System.Single? AerationCapacity_field = null;
    public System.Single? AerationCapacity
    {
       get { return AerationCapacity_field; }
       set { AerationCapacity_field = value; }
    }
    private System.Boolean? InfluentGrid_field = null;
    public System.Boolean? InfluentGrid
    {
       get { return InfluentGrid_field; }
       set { InfluentGrid_field = value; }
    }
    private System.Boolean? AerationGrid_field = null;
    public System.Boolean? AerationGrid
    {
       get { return AerationGrid_field; }
       set { AerationGrid_field = value; }
    }

  }

  public class VENT_PAREventArgs : System.EventArgs
  {
    public VENT_PAREventArgs()
    {
    }
    private System.Boolean? AirVentGrid_field = null;
    public System.Boolean? AirVentGrid
    {
       get { return AirVentGrid_field; }
       set { AirVentGrid_field = value; }
    }
    private System.Boolean? AirVentInfGrid_field = null;
    public System.Boolean? AirVentInfGrid
    {
       get { return AirVentInfGrid_field; }
       set { AirVentInfGrid_field = value; }
    }

  }

  public class AIR_LICK_TEventArgs : System.EventArgs
  {
    public AIR_LICK_TEventArgs()
    {
    }
    private NxtControl.GuiFramework.Time? AirLockTime_field = null;
    public NxtControl.GuiFramework.Time? AirLockTime
    {
       get { return AirLockTime_field; }
       set { AirLockTime_field = value; }
    }

  }

}

namespace SE.Nereda.Symbols.EmergencyReactor
{
  partial class sDefault
  {

    private event EventHandler<SE.Nereda.Symbols.EmergencyReactor.GRAPHEventArgs> GRAPH_Fired;

    private event EventHandler<SE.Nereda.Symbols.EmergencyReactor.EMERGENCY_ONEventArgs> EMERGENCY_ON_Fired;

    private event EventHandler<SE.Nereda.Symbols.EmergencyReactor.RESET_F_TRSEventArgs> RESET_F_TRS_Fired;

    private event EventHandler<SE.Nereda.Symbols.EmergencyReactor.ENABLE_FORCE_INEventArgs> ENABLE_FORCE_IN_Fired;

    private event EventHandler<SE.Nereda.Symbols.EmergencyReactor.S5_AERATE_TEventArgs> S5_AERATE_T_Fired;

    private event EventHandler<SE.Nereda.Symbols.EmergencyReactor.WARNINGEventArgs> WARNING_Fired;

    private event EventHandler<SE.Nereda.Symbols.EmergencyReactor.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    private event EventHandler<SE.Nereda.Symbols.EmergencyReactor.FORCE_UNAVEventArgs> FORCE_UNAV_Fired;

    protected override void OnEndInit()
    {
      if (GRAPH_Fired != null)
        AttachEventInput(0);
      if (EMERGENCY_ON_Fired != null)
        AttachEventInput(1);
      if (RESET_F_TRS_Fired != null)
        AttachEventInput(2);
      if (ENABLE_FORCE_IN_Fired != null)
        AttachEventInput(3);
      if (S5_AERATE_T_Fired != null)
        AttachEventInput(4);
      if (WARNING_Fired != null)
        AttachEventInput(5);
      if (LOAD_PERS_DATA_Fired != null)
        AttachEventInput(6);
      if (FORCE_UNAV_Fired != null)
        AttachEventInput(7);

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
              GRAPH_Fired(this, new SE.Nereda.Symbols.EmergencyReactor.GRAPHEventArgs(channelId, cookie, eventIndex));
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
          if (EMERGENCY_ON_Fired != null)
          {
            try
            {
              EMERGENCY_ON_Fired(this, new SE.Nereda.Symbols.EmergencyReactor.EMERGENCY_ONEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","EMERGENCY_ON_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 2:
          if (RESET_F_TRS_Fired != null)
          {
            try
            {
              RESET_F_TRS_Fired(this, new SE.Nereda.Symbols.EmergencyReactor.RESET_F_TRSEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","RESET_F_TRS_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 3:
          if (ENABLE_FORCE_IN_Fired != null)
          {
            try
            {
              ENABLE_FORCE_IN_Fired(this, new SE.Nereda.Symbols.EmergencyReactor.ENABLE_FORCE_INEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","ENABLE_FORCE_IN_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 4:
          if (S5_AERATE_T_Fired != null)
          {
            try
            {
              S5_AERATE_T_Fired(this, new SE.Nereda.Symbols.EmergencyReactor.S5_AERATE_TEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","S5_AERATE_T_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 5:
          if (WARNING_Fired != null)
          {
            try
            {
              WARNING_Fired(this, new SE.Nereda.Symbols.EmergencyReactor.WARNINGEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","WARNING_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 6:
          if (LOAD_PERS_DATA_Fired != null)
          {
            try
            {
              LOAD_PERS_DATA_Fired(this, new SE.Nereda.Symbols.EmergencyReactor.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","LOAD_PERS_DATA_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 7:
          if (FORCE_UNAV_Fired != null)
          {
            try
            {
              FORCE_UNAV_Fired(this, new SE.Nereda.Symbols.EmergencyReactor.FORCE_UNAVEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","FORCE_UNAV_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_FORCE(System.Int16 Force)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {Force});
    }
    public bool FireEvent_FORCE(SE.Nereda.Symbols.EmergencyReactor.FORCEEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.Force.HasValue) _values_[0] = ea.Force.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_FORCE(System.Int16 Force, bool ignore_Force)
    {
      object[] _values_ = new object[1];
      if (!ignore_Force) _values_[0] = Force;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_ENABLE_FORCE_OUT(System.Boolean oEnableForce)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {oEnableForce});
    }
    public bool FireEvent_ENABLE_FORCE_OUT(SE.Nereda.Symbols.EmergencyReactor.ENABLE_FORCE_OUTEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.oEnableForce.HasValue) _values_[0] = ea.oEnableForce.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_ENABLE_FORCE_OUT(System.Boolean oEnableForce, bool ignore_oEnableForce)
    {
      object[] _values_ = new object[1];
      if (!ignore_oEnableForce) _values_[0] = oEnableForce;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_STEPS_TIME(NxtControl.GuiFramework.Time S1_FeedTime, NxtControl.GuiFramework.Time S2_WaitTime, NxtControl.GuiFramework.Time S3_SludgeDischargeTime, NxtControl.GuiFramework.Time S4_LowerLevelTime, NxtControl.GuiFramework.Time S6_VentTime, NxtControl.GuiFramework.Time S7_SludgeDischargeTime, NxtControl.GuiFramework.Time S8_WaitTime)
    {
      return ((IHMIAccessorOutput)this).FireEvent(2, new object[] {S1_FeedTime, S2_WaitTime, S3_SludgeDischargeTime, S4_LowerLevelTime, S6_VentTime, S7_SludgeDischargeTime, S8_WaitTime});
    }
    public bool FireEvent_STEPS_TIME(SE.Nereda.Symbols.EmergencyReactor.STEPS_TIMEEventArgs ea)
    {
      object[] _values_ = new object[7];
      if (ea.S1_FeedTime.HasValue) _values_[0] = ea.S1_FeedTime.Value;
      if (ea.S2_WaitTime.HasValue) _values_[1] = ea.S2_WaitTime.Value;
      if (ea.S3_SludgeDischargeTime.HasValue) _values_[2] = ea.S3_SludgeDischargeTime.Value;
      if (ea.S4_LowerLevelTime.HasValue) _values_[3] = ea.S4_LowerLevelTime.Value;
      if (ea.S6_VentTime.HasValue) _values_[4] = ea.S6_VentTime.Value;
      if (ea.S7_SludgeDischargeTime.HasValue) _values_[5] = ea.S7_SludgeDischargeTime.Value;
      if (ea.S8_WaitTime.HasValue) _values_[6] = ea.S8_WaitTime.Value;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_STEPS_TIME(NxtControl.GuiFramework.Time S1_FeedTime, bool ignore_S1_FeedTime, NxtControl.GuiFramework.Time S2_WaitTime, bool ignore_S2_WaitTime, NxtControl.GuiFramework.Time S3_SludgeDischargeTime, bool ignore_S3_SludgeDischargeTime, NxtControl.GuiFramework.Time S4_LowerLevelTime, bool ignore_S4_LowerLevelTime, NxtControl.GuiFramework.Time S6_VentTime, bool ignore_S6_VentTime, NxtControl.GuiFramework.Time S7_SludgeDischargeTime, bool ignore_S7_SludgeDischargeTime, NxtControl.GuiFramework.Time S8_WaitTime, bool ignore_S8_WaitTime)
    {
      object[] _values_ = new object[7];
      if (!ignore_S1_FeedTime) _values_[0] = S1_FeedTime;
      if (!ignore_S2_WaitTime) _values_[1] = S2_WaitTime;
      if (!ignore_S3_SludgeDischargeTime) _values_[2] = S3_SludgeDischargeTime;
      if (!ignore_S4_LowerLevelTime) _values_[3] = S4_LowerLevelTime;
      if (!ignore_S6_VentTime) _values_[4] = S6_VentTime;
      if (!ignore_S7_SludgeDischargeTime) _values_[5] = S7_SludgeDischargeTime;
      if (!ignore_S8_WaitTime) _values_[6] = S8_WaitTime;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_FEED_PAR(System.Single FeedCapacity)
    {
      return ((IHMIAccessorOutput)this).FireEvent(3, new object[] {FeedCapacity});
    }
    public bool FireEvent_FEED_PAR(SE.Nereda.Symbols.EmergencyReactor.FEED_PAREventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.FeedCapacity.HasValue) _values_[0] = ea.FeedCapacity.Value;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_FEED_PAR(System.Single FeedCapacity, bool ignore_FeedCapacity)
    {
      object[] _values_ = new object[1];
      if (!ignore_FeedCapacity) _values_[0] = FeedCapacity;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_AERATE_PAR(System.Single AerationCapacity, System.Boolean InfluentGrid, System.Boolean AerationGrid)
    {
      return ((IHMIAccessorOutput)this).FireEvent(4, new object[] {AerationCapacity, InfluentGrid, AerationGrid});
    }
    public bool FireEvent_AERATE_PAR(SE.Nereda.Symbols.EmergencyReactor.AERATE_PAREventArgs ea)
    {
      object[] _values_ = new object[3];
      if (ea.AerationCapacity.HasValue) _values_[0] = ea.AerationCapacity.Value;
      if (ea.InfluentGrid.HasValue) _values_[1] = ea.InfluentGrid.Value;
      if (ea.AerationGrid.HasValue) _values_[2] = ea.AerationGrid.Value;
      return ((IHMIAccessorOutput)this).FireEvent(4, _values_);
    }
    public bool FireEvent_AERATE_PAR(System.Single AerationCapacity, bool ignore_AerationCapacity, System.Boolean InfluentGrid, bool ignore_InfluentGrid, System.Boolean AerationGrid, bool ignore_AerationGrid)
    {
      object[] _values_ = new object[3];
      if (!ignore_AerationCapacity) _values_[0] = AerationCapacity;
      if (!ignore_InfluentGrid) _values_[1] = InfluentGrid;
      if (!ignore_AerationGrid) _values_[2] = AerationGrid;
      return ((IHMIAccessorOutput)this).FireEvent(4, _values_);
    }
    public bool FireEvent_VENT_PAR(System.Boolean AirVentGrid, System.Boolean AirVentInfGrid)
    {
      return ((IHMIAccessorOutput)this).FireEvent(5, new object[] {AirVentGrid, AirVentInfGrid});
    }
    public bool FireEvent_VENT_PAR(SE.Nereda.Symbols.EmergencyReactor.VENT_PAREventArgs ea)
    {
      object[] _values_ = new object[2];
      if (ea.AirVentGrid.HasValue) _values_[0] = ea.AirVentGrid.Value;
      if (ea.AirVentInfGrid.HasValue) _values_[1] = ea.AirVentInfGrid.Value;
      return ((IHMIAccessorOutput)this).FireEvent(5, _values_);
    }
    public bool FireEvent_VENT_PAR(System.Boolean AirVentGrid, bool ignore_AirVentGrid, System.Boolean AirVentInfGrid, bool ignore_AirVentInfGrid)
    {
      object[] _values_ = new object[2];
      if (!ignore_AirVentGrid) _values_[0] = AirVentGrid;
      if (!ignore_AirVentInfGrid) _values_[1] = AirVentInfGrid;
      return ((IHMIAccessorOutput)this).FireEvent(5, _values_);
    }
    public bool FireEvent_AIR_LICK_T(NxtControl.GuiFramework.Time AirLockTime)
    {
      return ((IHMIAccessorOutput)this).FireEvent(6, new object[] {AirLockTime});
    }
    public bool FireEvent_AIR_LICK_T(SE.Nereda.Symbols.EmergencyReactor.AIR_LICK_TEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.AirLockTime.HasValue) _values_[0] = ea.AirLockTime.Value;
      return ((IHMIAccessorOutput)this).FireEvent(6, _values_);
    }
    public bool FireEvent_AIR_LICK_T(NxtControl.GuiFramework.Time AirLockTime, bool ignore_AirLockTime)
    {
      object[] _values_ = new object[1];
      if (!ignore_AirLockTime) _values_[0] = AirLockTime;
      return ((IHMIAccessorOutput)this).FireEvent(6, _values_);
    }

  }
}

namespace SE.Nereda.Faceplates.EmergencyReactor
{
  partial class fpSettings
  {

    private event EventHandler<SE.Nereda.Symbols.EmergencyReactor.GRAPHEventArgs> GRAPH_Fired;

    private event EventHandler<SE.Nereda.Symbols.EmergencyReactor.EMERGENCY_ONEventArgs> EMERGENCY_ON_Fired;

    private event EventHandler<SE.Nereda.Symbols.EmergencyReactor.RESET_F_TRSEventArgs> RESET_F_TRS_Fired;

    private event EventHandler<SE.Nereda.Symbols.EmergencyReactor.ENABLE_FORCE_INEventArgs> ENABLE_FORCE_IN_Fired;

    private event EventHandler<SE.Nereda.Symbols.EmergencyReactor.S5_AERATE_TEventArgs> S5_AERATE_T_Fired;

    private event EventHandler<SE.Nereda.Symbols.EmergencyReactor.WARNINGEventArgs> WARNING_Fired;

    private event EventHandler<SE.Nereda.Symbols.EmergencyReactor.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    private event EventHandler<SE.Nereda.Symbols.EmergencyReactor.FORCE_UNAVEventArgs> FORCE_UNAV_Fired;

    protected override void OnEndInit()
    {
      if (GRAPH_Fired != null)
        AttachEventInput(0);
      if (EMERGENCY_ON_Fired != null)
        AttachEventInput(1);
      if (RESET_F_TRS_Fired != null)
        AttachEventInput(2);
      if (ENABLE_FORCE_IN_Fired != null)
        AttachEventInput(3);
      if (S5_AERATE_T_Fired != null)
        AttachEventInput(4);
      if (WARNING_Fired != null)
        AttachEventInput(5);
      if (LOAD_PERS_DATA_Fired != null)
        AttachEventInput(6);
      if (FORCE_UNAV_Fired != null)
        AttachEventInput(7);

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
              GRAPH_Fired(this, new SE.Nereda.Symbols.EmergencyReactor.GRAPHEventArgs(channelId, cookie, eventIndex));
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
          if (EMERGENCY_ON_Fired != null)
          {
            try
            {
              EMERGENCY_ON_Fired(this, new SE.Nereda.Symbols.EmergencyReactor.EMERGENCY_ONEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","EMERGENCY_ON_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 2:
          if (RESET_F_TRS_Fired != null)
          {
            try
            {
              RESET_F_TRS_Fired(this, new SE.Nereda.Symbols.EmergencyReactor.RESET_F_TRSEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","RESET_F_TRS_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 3:
          if (ENABLE_FORCE_IN_Fired != null)
          {
            try
            {
              ENABLE_FORCE_IN_Fired(this, new SE.Nereda.Symbols.EmergencyReactor.ENABLE_FORCE_INEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","ENABLE_FORCE_IN_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 4:
          if (S5_AERATE_T_Fired != null)
          {
            try
            {
              S5_AERATE_T_Fired(this, new SE.Nereda.Symbols.EmergencyReactor.S5_AERATE_TEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","S5_AERATE_T_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 5:
          if (WARNING_Fired != null)
          {
            try
            {
              WARNING_Fired(this, new SE.Nereda.Symbols.EmergencyReactor.WARNINGEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","WARNING_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 6:
          if (LOAD_PERS_DATA_Fired != null)
          {
            try
            {
              LOAD_PERS_DATA_Fired(this, new SE.Nereda.Symbols.EmergencyReactor.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","LOAD_PERS_DATA_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 7:
          if (FORCE_UNAV_Fired != null)
          {
            try
            {
              FORCE_UNAV_Fired(this, new SE.Nereda.Symbols.EmergencyReactor.FORCE_UNAVEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","FORCE_UNAV_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_FORCE(System.Int16 Force)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {Force});
    }
    public bool FireEvent_FORCE(SE.Nereda.Symbols.EmergencyReactor.FORCEEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.Force.HasValue) _values_[0] = ea.Force.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_FORCE(System.Int16 Force, bool ignore_Force)
    {
      object[] _values_ = new object[1];
      if (!ignore_Force) _values_[0] = Force;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_ENABLE_FORCE_OUT(System.Boolean oEnableForce)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {oEnableForce});
    }
    public bool FireEvent_ENABLE_FORCE_OUT(SE.Nereda.Symbols.EmergencyReactor.ENABLE_FORCE_OUTEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.oEnableForce.HasValue) _values_[0] = ea.oEnableForce.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_ENABLE_FORCE_OUT(System.Boolean oEnableForce, bool ignore_oEnableForce)
    {
      object[] _values_ = new object[1];
      if (!ignore_oEnableForce) _values_[0] = oEnableForce;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_STEPS_TIME(NxtControl.GuiFramework.Time S1_FeedTime, NxtControl.GuiFramework.Time S2_WaitTime, NxtControl.GuiFramework.Time S3_SludgeDischargeTime, NxtControl.GuiFramework.Time S4_LowerLevelTime, NxtControl.GuiFramework.Time S6_VentTime, NxtControl.GuiFramework.Time S7_SludgeDischargeTime, NxtControl.GuiFramework.Time S8_WaitTime)
    {
      return ((IHMIAccessorOutput)this).FireEvent(2, new object[] {S1_FeedTime, S2_WaitTime, S3_SludgeDischargeTime, S4_LowerLevelTime, S6_VentTime, S7_SludgeDischargeTime, S8_WaitTime});
    }
    public bool FireEvent_STEPS_TIME(SE.Nereda.Symbols.EmergencyReactor.STEPS_TIMEEventArgs ea)
    {
      object[] _values_ = new object[7];
      if (ea.S1_FeedTime.HasValue) _values_[0] = ea.S1_FeedTime.Value;
      if (ea.S2_WaitTime.HasValue) _values_[1] = ea.S2_WaitTime.Value;
      if (ea.S3_SludgeDischargeTime.HasValue) _values_[2] = ea.S3_SludgeDischargeTime.Value;
      if (ea.S4_LowerLevelTime.HasValue) _values_[3] = ea.S4_LowerLevelTime.Value;
      if (ea.S6_VentTime.HasValue) _values_[4] = ea.S6_VentTime.Value;
      if (ea.S7_SludgeDischargeTime.HasValue) _values_[5] = ea.S7_SludgeDischargeTime.Value;
      if (ea.S8_WaitTime.HasValue) _values_[6] = ea.S8_WaitTime.Value;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_STEPS_TIME(NxtControl.GuiFramework.Time S1_FeedTime, bool ignore_S1_FeedTime, NxtControl.GuiFramework.Time S2_WaitTime, bool ignore_S2_WaitTime, NxtControl.GuiFramework.Time S3_SludgeDischargeTime, bool ignore_S3_SludgeDischargeTime, NxtControl.GuiFramework.Time S4_LowerLevelTime, bool ignore_S4_LowerLevelTime, NxtControl.GuiFramework.Time S6_VentTime, bool ignore_S6_VentTime, NxtControl.GuiFramework.Time S7_SludgeDischargeTime, bool ignore_S7_SludgeDischargeTime, NxtControl.GuiFramework.Time S8_WaitTime, bool ignore_S8_WaitTime)
    {
      object[] _values_ = new object[7];
      if (!ignore_S1_FeedTime) _values_[0] = S1_FeedTime;
      if (!ignore_S2_WaitTime) _values_[1] = S2_WaitTime;
      if (!ignore_S3_SludgeDischargeTime) _values_[2] = S3_SludgeDischargeTime;
      if (!ignore_S4_LowerLevelTime) _values_[3] = S4_LowerLevelTime;
      if (!ignore_S6_VentTime) _values_[4] = S6_VentTime;
      if (!ignore_S7_SludgeDischargeTime) _values_[5] = S7_SludgeDischargeTime;
      if (!ignore_S8_WaitTime) _values_[6] = S8_WaitTime;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_FEED_PAR(System.Single FeedCapacity)
    {
      return ((IHMIAccessorOutput)this).FireEvent(3, new object[] {FeedCapacity});
    }
    public bool FireEvent_FEED_PAR(SE.Nereda.Symbols.EmergencyReactor.FEED_PAREventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.FeedCapacity.HasValue) _values_[0] = ea.FeedCapacity.Value;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_FEED_PAR(System.Single FeedCapacity, bool ignore_FeedCapacity)
    {
      object[] _values_ = new object[1];
      if (!ignore_FeedCapacity) _values_[0] = FeedCapacity;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_AERATE_PAR(System.Single AerationCapacity, System.Boolean InfluentGrid, System.Boolean AerationGrid)
    {
      return ((IHMIAccessorOutput)this).FireEvent(4, new object[] {AerationCapacity, InfluentGrid, AerationGrid});
    }
    public bool FireEvent_AERATE_PAR(SE.Nereda.Symbols.EmergencyReactor.AERATE_PAREventArgs ea)
    {
      object[] _values_ = new object[3];
      if (ea.AerationCapacity.HasValue) _values_[0] = ea.AerationCapacity.Value;
      if (ea.InfluentGrid.HasValue) _values_[1] = ea.InfluentGrid.Value;
      if (ea.AerationGrid.HasValue) _values_[2] = ea.AerationGrid.Value;
      return ((IHMIAccessorOutput)this).FireEvent(4, _values_);
    }
    public bool FireEvent_AERATE_PAR(System.Single AerationCapacity, bool ignore_AerationCapacity, System.Boolean InfluentGrid, bool ignore_InfluentGrid, System.Boolean AerationGrid, bool ignore_AerationGrid)
    {
      object[] _values_ = new object[3];
      if (!ignore_AerationCapacity) _values_[0] = AerationCapacity;
      if (!ignore_InfluentGrid) _values_[1] = InfluentGrid;
      if (!ignore_AerationGrid) _values_[2] = AerationGrid;
      return ((IHMIAccessorOutput)this).FireEvent(4, _values_);
    }
    public bool FireEvent_VENT_PAR(System.Boolean AirVentGrid, System.Boolean AirVentInfGrid)
    {
      return ((IHMIAccessorOutput)this).FireEvent(5, new object[] {AirVentGrid, AirVentInfGrid});
    }
    public bool FireEvent_VENT_PAR(SE.Nereda.Symbols.EmergencyReactor.VENT_PAREventArgs ea)
    {
      object[] _values_ = new object[2];
      if (ea.AirVentGrid.HasValue) _values_[0] = ea.AirVentGrid.Value;
      if (ea.AirVentInfGrid.HasValue) _values_[1] = ea.AirVentInfGrid.Value;
      return ((IHMIAccessorOutput)this).FireEvent(5, _values_);
    }
    public bool FireEvent_VENT_PAR(System.Boolean AirVentGrid, bool ignore_AirVentGrid, System.Boolean AirVentInfGrid, bool ignore_AirVentInfGrid)
    {
      object[] _values_ = new object[2];
      if (!ignore_AirVentGrid) _values_[0] = AirVentGrid;
      if (!ignore_AirVentInfGrid) _values_[1] = AirVentInfGrid;
      return ((IHMIAccessorOutput)this).FireEvent(5, _values_);
    }
    public bool FireEvent_AIR_LICK_T(NxtControl.GuiFramework.Time AirLockTime)
    {
      return ((IHMIAccessorOutput)this).FireEvent(6, new object[] {AirLockTime});
    }
    public bool FireEvent_AIR_LICK_T(SE.Nereda.Symbols.EmergencyReactor.AIR_LICK_TEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.AirLockTime.HasValue) _values_[0] = ea.AirLockTime.Value;
      return ((IHMIAccessorOutput)this).FireEvent(6, _values_);
    }
    public bool FireEvent_AIR_LICK_T(NxtControl.GuiFramework.Time AirLockTime, bool ignore_AirLockTime)
    {
      object[] _values_ = new object[1];
      if (!ignore_AirLockTime) _values_[0] = AirLockTime;
      return ((IHMIAccessorOutput)this).FireEvent(6, _values_);
    }

  }
}

namespace SE.Nereda.Symbols.EmergencyReactor
{
  partial class sDelayAfterCycle
  {

    private event EventHandler<SE.Nereda.Symbols.EmergencyReactor.GRAPHEventArgs> GRAPH_Fired;

    private event EventHandler<SE.Nereda.Symbols.EmergencyReactor.EMERGENCY_ONEventArgs> EMERGENCY_ON_Fired;

    private event EventHandler<SE.Nereda.Symbols.EmergencyReactor.RESET_F_TRSEventArgs> RESET_F_TRS_Fired;

    private event EventHandler<SE.Nereda.Symbols.EmergencyReactor.ENABLE_FORCE_INEventArgs> ENABLE_FORCE_IN_Fired;

    private event EventHandler<SE.Nereda.Symbols.EmergencyReactor.S5_AERATE_TEventArgs> S5_AERATE_T_Fired;

    private event EventHandler<SE.Nereda.Symbols.EmergencyReactor.WARNINGEventArgs> WARNING_Fired;

    private event EventHandler<SE.Nereda.Symbols.EmergencyReactor.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    private event EventHandler<SE.Nereda.Symbols.EmergencyReactor.FORCE_UNAVEventArgs> FORCE_UNAV_Fired;

    protected override void OnEndInit()
    {
      if (GRAPH_Fired != null)
        AttachEventInput(0);
      if (EMERGENCY_ON_Fired != null)
        AttachEventInput(1);
      if (RESET_F_TRS_Fired != null)
        AttachEventInput(2);
      if (ENABLE_FORCE_IN_Fired != null)
        AttachEventInput(3);
      if (S5_AERATE_T_Fired != null)
        AttachEventInput(4);
      if (WARNING_Fired != null)
        AttachEventInput(5);
      if (LOAD_PERS_DATA_Fired != null)
        AttachEventInput(6);
      if (FORCE_UNAV_Fired != null)
        AttachEventInput(7);

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
              GRAPH_Fired(this, new SE.Nereda.Symbols.EmergencyReactor.GRAPHEventArgs(channelId, cookie, eventIndex));
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
          if (EMERGENCY_ON_Fired != null)
          {
            try
            {
              EMERGENCY_ON_Fired(this, new SE.Nereda.Symbols.EmergencyReactor.EMERGENCY_ONEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","EMERGENCY_ON_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 2:
          if (RESET_F_TRS_Fired != null)
          {
            try
            {
              RESET_F_TRS_Fired(this, new SE.Nereda.Symbols.EmergencyReactor.RESET_F_TRSEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","RESET_F_TRS_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 3:
          if (ENABLE_FORCE_IN_Fired != null)
          {
            try
            {
              ENABLE_FORCE_IN_Fired(this, new SE.Nereda.Symbols.EmergencyReactor.ENABLE_FORCE_INEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","ENABLE_FORCE_IN_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 4:
          if (S5_AERATE_T_Fired != null)
          {
            try
            {
              S5_AERATE_T_Fired(this, new SE.Nereda.Symbols.EmergencyReactor.S5_AERATE_TEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","S5_AERATE_T_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 5:
          if (WARNING_Fired != null)
          {
            try
            {
              WARNING_Fired(this, new SE.Nereda.Symbols.EmergencyReactor.WARNINGEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","WARNING_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 6:
          if (LOAD_PERS_DATA_Fired != null)
          {
            try
            {
              LOAD_PERS_DATA_Fired(this, new SE.Nereda.Symbols.EmergencyReactor.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","LOAD_PERS_DATA_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 7:
          if (FORCE_UNAV_Fired != null)
          {
            try
            {
              FORCE_UNAV_Fired(this, new SE.Nereda.Symbols.EmergencyReactor.FORCE_UNAVEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","FORCE_UNAV_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_FORCE(System.Int16 Force)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {Force});
    }
    public bool FireEvent_FORCE(SE.Nereda.Symbols.EmergencyReactor.FORCEEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.Force.HasValue) _values_[0] = ea.Force.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_FORCE(System.Int16 Force, bool ignore_Force)
    {
      object[] _values_ = new object[1];
      if (!ignore_Force) _values_[0] = Force;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_ENABLE_FORCE_OUT(System.Boolean oEnableForce)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {oEnableForce});
    }
    public bool FireEvent_ENABLE_FORCE_OUT(SE.Nereda.Symbols.EmergencyReactor.ENABLE_FORCE_OUTEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.oEnableForce.HasValue) _values_[0] = ea.oEnableForce.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_ENABLE_FORCE_OUT(System.Boolean oEnableForce, bool ignore_oEnableForce)
    {
      object[] _values_ = new object[1];
      if (!ignore_oEnableForce) _values_[0] = oEnableForce;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_STEPS_TIME(NxtControl.GuiFramework.Time S1_FeedTime, NxtControl.GuiFramework.Time S2_WaitTime, NxtControl.GuiFramework.Time S3_SludgeDischargeTime, NxtControl.GuiFramework.Time S4_LowerLevelTime, NxtControl.GuiFramework.Time S6_VentTime, NxtControl.GuiFramework.Time S7_SludgeDischargeTime, NxtControl.GuiFramework.Time S8_WaitTime)
    {
      return ((IHMIAccessorOutput)this).FireEvent(2, new object[] {S1_FeedTime, S2_WaitTime, S3_SludgeDischargeTime, S4_LowerLevelTime, S6_VentTime, S7_SludgeDischargeTime, S8_WaitTime});
    }
    public bool FireEvent_STEPS_TIME(SE.Nereda.Symbols.EmergencyReactor.STEPS_TIMEEventArgs ea)
    {
      object[] _values_ = new object[7];
      if (ea.S1_FeedTime.HasValue) _values_[0] = ea.S1_FeedTime.Value;
      if (ea.S2_WaitTime.HasValue) _values_[1] = ea.S2_WaitTime.Value;
      if (ea.S3_SludgeDischargeTime.HasValue) _values_[2] = ea.S3_SludgeDischargeTime.Value;
      if (ea.S4_LowerLevelTime.HasValue) _values_[3] = ea.S4_LowerLevelTime.Value;
      if (ea.S6_VentTime.HasValue) _values_[4] = ea.S6_VentTime.Value;
      if (ea.S7_SludgeDischargeTime.HasValue) _values_[5] = ea.S7_SludgeDischargeTime.Value;
      if (ea.S8_WaitTime.HasValue) _values_[6] = ea.S8_WaitTime.Value;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_STEPS_TIME(NxtControl.GuiFramework.Time S1_FeedTime, bool ignore_S1_FeedTime, NxtControl.GuiFramework.Time S2_WaitTime, bool ignore_S2_WaitTime, NxtControl.GuiFramework.Time S3_SludgeDischargeTime, bool ignore_S3_SludgeDischargeTime, NxtControl.GuiFramework.Time S4_LowerLevelTime, bool ignore_S4_LowerLevelTime, NxtControl.GuiFramework.Time S6_VentTime, bool ignore_S6_VentTime, NxtControl.GuiFramework.Time S7_SludgeDischargeTime, bool ignore_S7_SludgeDischargeTime, NxtControl.GuiFramework.Time S8_WaitTime, bool ignore_S8_WaitTime)
    {
      object[] _values_ = new object[7];
      if (!ignore_S1_FeedTime) _values_[0] = S1_FeedTime;
      if (!ignore_S2_WaitTime) _values_[1] = S2_WaitTime;
      if (!ignore_S3_SludgeDischargeTime) _values_[2] = S3_SludgeDischargeTime;
      if (!ignore_S4_LowerLevelTime) _values_[3] = S4_LowerLevelTime;
      if (!ignore_S6_VentTime) _values_[4] = S6_VentTime;
      if (!ignore_S7_SludgeDischargeTime) _values_[5] = S7_SludgeDischargeTime;
      if (!ignore_S8_WaitTime) _values_[6] = S8_WaitTime;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_FEED_PAR(System.Single FeedCapacity)
    {
      return ((IHMIAccessorOutput)this).FireEvent(3, new object[] {FeedCapacity});
    }
    public bool FireEvent_FEED_PAR(SE.Nereda.Symbols.EmergencyReactor.FEED_PAREventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.FeedCapacity.HasValue) _values_[0] = ea.FeedCapacity.Value;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_FEED_PAR(System.Single FeedCapacity, bool ignore_FeedCapacity)
    {
      object[] _values_ = new object[1];
      if (!ignore_FeedCapacity) _values_[0] = FeedCapacity;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_AERATE_PAR(System.Single AerationCapacity, System.Boolean InfluentGrid, System.Boolean AerationGrid)
    {
      return ((IHMIAccessorOutput)this).FireEvent(4, new object[] {AerationCapacity, InfluentGrid, AerationGrid});
    }
    public bool FireEvent_AERATE_PAR(SE.Nereda.Symbols.EmergencyReactor.AERATE_PAREventArgs ea)
    {
      object[] _values_ = new object[3];
      if (ea.AerationCapacity.HasValue) _values_[0] = ea.AerationCapacity.Value;
      if (ea.InfluentGrid.HasValue) _values_[1] = ea.InfluentGrid.Value;
      if (ea.AerationGrid.HasValue) _values_[2] = ea.AerationGrid.Value;
      return ((IHMIAccessorOutput)this).FireEvent(4, _values_);
    }
    public bool FireEvent_AERATE_PAR(System.Single AerationCapacity, bool ignore_AerationCapacity, System.Boolean InfluentGrid, bool ignore_InfluentGrid, System.Boolean AerationGrid, bool ignore_AerationGrid)
    {
      object[] _values_ = new object[3];
      if (!ignore_AerationCapacity) _values_[0] = AerationCapacity;
      if (!ignore_InfluentGrid) _values_[1] = InfluentGrid;
      if (!ignore_AerationGrid) _values_[2] = AerationGrid;
      return ((IHMIAccessorOutput)this).FireEvent(4, _values_);
    }
    public bool FireEvent_VENT_PAR(System.Boolean AirVentGrid, System.Boolean AirVentInfGrid)
    {
      return ((IHMIAccessorOutput)this).FireEvent(5, new object[] {AirVentGrid, AirVentInfGrid});
    }
    public bool FireEvent_VENT_PAR(SE.Nereda.Symbols.EmergencyReactor.VENT_PAREventArgs ea)
    {
      object[] _values_ = new object[2];
      if (ea.AirVentGrid.HasValue) _values_[0] = ea.AirVentGrid.Value;
      if (ea.AirVentInfGrid.HasValue) _values_[1] = ea.AirVentInfGrid.Value;
      return ((IHMIAccessorOutput)this).FireEvent(5, _values_);
    }
    public bool FireEvent_VENT_PAR(System.Boolean AirVentGrid, bool ignore_AirVentGrid, System.Boolean AirVentInfGrid, bool ignore_AirVentInfGrid)
    {
      object[] _values_ = new object[2];
      if (!ignore_AirVentGrid) _values_[0] = AirVentGrid;
      if (!ignore_AirVentInfGrid) _values_[1] = AirVentInfGrid;
      return ((IHMIAccessorOutput)this).FireEvent(5, _values_);
    }
    public bool FireEvent_AIR_LICK_T(NxtControl.GuiFramework.Time AirLockTime)
    {
      return ((IHMIAccessorOutput)this).FireEvent(6, new object[] {AirLockTime});
    }
    public bool FireEvent_AIR_LICK_T(SE.Nereda.Symbols.EmergencyReactor.AIR_LICK_TEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.AirLockTime.HasValue) _values_[0] = ea.AirLockTime.Value;
      return ((IHMIAccessorOutput)this).FireEvent(6, _values_);
    }
    public bool FireEvent_AIR_LICK_T(NxtControl.GuiFramework.Time AirLockTime, bool ignore_AirLockTime)
    {
      object[] _values_ = new object[1];
      if (!ignore_AirLockTime) _values_[0] = AirLockTime;
      return ((IHMIAccessorOutput)this).FireEvent(6, _values_);
    }

  }
}

namespace SE.Nereda.Symbols.EmergencyReactor
{
  partial class sWarning
  {

    private event EventHandler<SE.Nereda.Symbols.EmergencyReactor.GRAPHEventArgs> GRAPH_Fired;

    private event EventHandler<SE.Nereda.Symbols.EmergencyReactor.EMERGENCY_ONEventArgs> EMERGENCY_ON_Fired;

    private event EventHandler<SE.Nereda.Symbols.EmergencyReactor.RESET_F_TRSEventArgs> RESET_F_TRS_Fired;

    private event EventHandler<SE.Nereda.Symbols.EmergencyReactor.ENABLE_FORCE_INEventArgs> ENABLE_FORCE_IN_Fired;

    private event EventHandler<SE.Nereda.Symbols.EmergencyReactor.S5_AERATE_TEventArgs> S5_AERATE_T_Fired;

    private event EventHandler<SE.Nereda.Symbols.EmergencyReactor.WARNINGEventArgs> WARNING_Fired;

    private event EventHandler<SE.Nereda.Symbols.EmergencyReactor.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    private event EventHandler<SE.Nereda.Symbols.EmergencyReactor.FORCE_UNAVEventArgs> FORCE_UNAV_Fired;

    protected override void OnEndInit()
    {
      if (GRAPH_Fired != null)
        AttachEventInput(0);
      if (EMERGENCY_ON_Fired != null)
        AttachEventInput(1);
      if (RESET_F_TRS_Fired != null)
        AttachEventInput(2);
      if (ENABLE_FORCE_IN_Fired != null)
        AttachEventInput(3);
      if (S5_AERATE_T_Fired != null)
        AttachEventInput(4);
      if (WARNING_Fired != null)
        AttachEventInput(5);
      if (LOAD_PERS_DATA_Fired != null)
        AttachEventInput(6);
      if (FORCE_UNAV_Fired != null)
        AttachEventInput(7);

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
              GRAPH_Fired(this, new SE.Nereda.Symbols.EmergencyReactor.GRAPHEventArgs(channelId, cookie, eventIndex));
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
          if (EMERGENCY_ON_Fired != null)
          {
            try
            {
              EMERGENCY_ON_Fired(this, new SE.Nereda.Symbols.EmergencyReactor.EMERGENCY_ONEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","EMERGENCY_ON_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 2:
          if (RESET_F_TRS_Fired != null)
          {
            try
            {
              RESET_F_TRS_Fired(this, new SE.Nereda.Symbols.EmergencyReactor.RESET_F_TRSEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","RESET_F_TRS_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 3:
          if (ENABLE_FORCE_IN_Fired != null)
          {
            try
            {
              ENABLE_FORCE_IN_Fired(this, new SE.Nereda.Symbols.EmergencyReactor.ENABLE_FORCE_INEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","ENABLE_FORCE_IN_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 4:
          if (S5_AERATE_T_Fired != null)
          {
            try
            {
              S5_AERATE_T_Fired(this, new SE.Nereda.Symbols.EmergencyReactor.S5_AERATE_TEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","S5_AERATE_T_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 5:
          if (WARNING_Fired != null)
          {
            try
            {
              WARNING_Fired(this, new SE.Nereda.Symbols.EmergencyReactor.WARNINGEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","WARNING_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 6:
          if (LOAD_PERS_DATA_Fired != null)
          {
            try
            {
              LOAD_PERS_DATA_Fired(this, new SE.Nereda.Symbols.EmergencyReactor.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","LOAD_PERS_DATA_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 7:
          if (FORCE_UNAV_Fired != null)
          {
            try
            {
              FORCE_UNAV_Fired(this, new SE.Nereda.Symbols.EmergencyReactor.FORCE_UNAVEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","FORCE_UNAV_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_FORCE(System.Int16 Force)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {Force});
    }
    public bool FireEvent_FORCE(SE.Nereda.Symbols.EmergencyReactor.FORCEEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.Force.HasValue) _values_[0] = ea.Force.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_FORCE(System.Int16 Force, bool ignore_Force)
    {
      object[] _values_ = new object[1];
      if (!ignore_Force) _values_[0] = Force;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_ENABLE_FORCE_OUT(System.Boolean oEnableForce)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {oEnableForce});
    }
    public bool FireEvent_ENABLE_FORCE_OUT(SE.Nereda.Symbols.EmergencyReactor.ENABLE_FORCE_OUTEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.oEnableForce.HasValue) _values_[0] = ea.oEnableForce.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_ENABLE_FORCE_OUT(System.Boolean oEnableForce, bool ignore_oEnableForce)
    {
      object[] _values_ = new object[1];
      if (!ignore_oEnableForce) _values_[0] = oEnableForce;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_STEPS_TIME(NxtControl.GuiFramework.Time S1_FeedTime, NxtControl.GuiFramework.Time S2_WaitTime, NxtControl.GuiFramework.Time S3_SludgeDischargeTime, NxtControl.GuiFramework.Time S4_LowerLevelTime, NxtControl.GuiFramework.Time S6_VentTime, NxtControl.GuiFramework.Time S7_SludgeDischargeTime, NxtControl.GuiFramework.Time S8_WaitTime)
    {
      return ((IHMIAccessorOutput)this).FireEvent(2, new object[] {S1_FeedTime, S2_WaitTime, S3_SludgeDischargeTime, S4_LowerLevelTime, S6_VentTime, S7_SludgeDischargeTime, S8_WaitTime});
    }
    public bool FireEvent_STEPS_TIME(SE.Nereda.Symbols.EmergencyReactor.STEPS_TIMEEventArgs ea)
    {
      object[] _values_ = new object[7];
      if (ea.S1_FeedTime.HasValue) _values_[0] = ea.S1_FeedTime.Value;
      if (ea.S2_WaitTime.HasValue) _values_[1] = ea.S2_WaitTime.Value;
      if (ea.S3_SludgeDischargeTime.HasValue) _values_[2] = ea.S3_SludgeDischargeTime.Value;
      if (ea.S4_LowerLevelTime.HasValue) _values_[3] = ea.S4_LowerLevelTime.Value;
      if (ea.S6_VentTime.HasValue) _values_[4] = ea.S6_VentTime.Value;
      if (ea.S7_SludgeDischargeTime.HasValue) _values_[5] = ea.S7_SludgeDischargeTime.Value;
      if (ea.S8_WaitTime.HasValue) _values_[6] = ea.S8_WaitTime.Value;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_STEPS_TIME(NxtControl.GuiFramework.Time S1_FeedTime, bool ignore_S1_FeedTime, NxtControl.GuiFramework.Time S2_WaitTime, bool ignore_S2_WaitTime, NxtControl.GuiFramework.Time S3_SludgeDischargeTime, bool ignore_S3_SludgeDischargeTime, NxtControl.GuiFramework.Time S4_LowerLevelTime, bool ignore_S4_LowerLevelTime, NxtControl.GuiFramework.Time S6_VentTime, bool ignore_S6_VentTime, NxtControl.GuiFramework.Time S7_SludgeDischargeTime, bool ignore_S7_SludgeDischargeTime, NxtControl.GuiFramework.Time S8_WaitTime, bool ignore_S8_WaitTime)
    {
      object[] _values_ = new object[7];
      if (!ignore_S1_FeedTime) _values_[0] = S1_FeedTime;
      if (!ignore_S2_WaitTime) _values_[1] = S2_WaitTime;
      if (!ignore_S3_SludgeDischargeTime) _values_[2] = S3_SludgeDischargeTime;
      if (!ignore_S4_LowerLevelTime) _values_[3] = S4_LowerLevelTime;
      if (!ignore_S6_VentTime) _values_[4] = S6_VentTime;
      if (!ignore_S7_SludgeDischargeTime) _values_[5] = S7_SludgeDischargeTime;
      if (!ignore_S8_WaitTime) _values_[6] = S8_WaitTime;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_FEED_PAR(System.Single FeedCapacity)
    {
      return ((IHMIAccessorOutput)this).FireEvent(3, new object[] {FeedCapacity});
    }
    public bool FireEvent_FEED_PAR(SE.Nereda.Symbols.EmergencyReactor.FEED_PAREventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.FeedCapacity.HasValue) _values_[0] = ea.FeedCapacity.Value;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_FEED_PAR(System.Single FeedCapacity, bool ignore_FeedCapacity)
    {
      object[] _values_ = new object[1];
      if (!ignore_FeedCapacity) _values_[0] = FeedCapacity;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_AERATE_PAR(System.Single AerationCapacity, System.Boolean InfluentGrid, System.Boolean AerationGrid)
    {
      return ((IHMIAccessorOutput)this).FireEvent(4, new object[] {AerationCapacity, InfluentGrid, AerationGrid});
    }
    public bool FireEvent_AERATE_PAR(SE.Nereda.Symbols.EmergencyReactor.AERATE_PAREventArgs ea)
    {
      object[] _values_ = new object[3];
      if (ea.AerationCapacity.HasValue) _values_[0] = ea.AerationCapacity.Value;
      if (ea.InfluentGrid.HasValue) _values_[1] = ea.InfluentGrid.Value;
      if (ea.AerationGrid.HasValue) _values_[2] = ea.AerationGrid.Value;
      return ((IHMIAccessorOutput)this).FireEvent(4, _values_);
    }
    public bool FireEvent_AERATE_PAR(System.Single AerationCapacity, bool ignore_AerationCapacity, System.Boolean InfluentGrid, bool ignore_InfluentGrid, System.Boolean AerationGrid, bool ignore_AerationGrid)
    {
      object[] _values_ = new object[3];
      if (!ignore_AerationCapacity) _values_[0] = AerationCapacity;
      if (!ignore_InfluentGrid) _values_[1] = InfluentGrid;
      if (!ignore_AerationGrid) _values_[2] = AerationGrid;
      return ((IHMIAccessorOutput)this).FireEvent(4, _values_);
    }
    public bool FireEvent_VENT_PAR(System.Boolean AirVentGrid, System.Boolean AirVentInfGrid)
    {
      return ((IHMIAccessorOutput)this).FireEvent(5, new object[] {AirVentGrid, AirVentInfGrid});
    }
    public bool FireEvent_VENT_PAR(SE.Nereda.Symbols.EmergencyReactor.VENT_PAREventArgs ea)
    {
      object[] _values_ = new object[2];
      if (ea.AirVentGrid.HasValue) _values_[0] = ea.AirVentGrid.Value;
      if (ea.AirVentInfGrid.HasValue) _values_[1] = ea.AirVentInfGrid.Value;
      return ((IHMIAccessorOutput)this).FireEvent(5, _values_);
    }
    public bool FireEvent_VENT_PAR(System.Boolean AirVentGrid, bool ignore_AirVentGrid, System.Boolean AirVentInfGrid, bool ignore_AirVentInfGrid)
    {
      object[] _values_ = new object[2];
      if (!ignore_AirVentGrid) _values_[0] = AirVentGrid;
      if (!ignore_AirVentInfGrid) _values_[1] = AirVentInfGrid;
      return ((IHMIAccessorOutput)this).FireEvent(5, _values_);
    }
    public bool FireEvent_AIR_LICK_T(NxtControl.GuiFramework.Time AirLockTime)
    {
      return ((IHMIAccessorOutput)this).FireEvent(6, new object[] {AirLockTime});
    }
    public bool FireEvent_AIR_LICK_T(SE.Nereda.Symbols.EmergencyReactor.AIR_LICK_TEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.AirLockTime.HasValue) _values_[0] = ea.AirLockTime.Value;
      return ((IHMIAccessorOutput)this).FireEvent(6, _values_);
    }
    public bool FireEvent_AIR_LICK_T(NxtControl.GuiFramework.Time AirLockTime, bool ignore_AirLockTime)
    {
      object[] _values_ = new object[1];
      if (!ignore_AirLockTime) _values_[0] = AirLockTime;
      return ((IHMIAccessorOutput)this).FireEvent(6, _values_);
    }

  }
}

namespace SE.Nereda.Faceplates.EmergencyReactor
{
  partial class fpCurrAerateTime
  {

    private event EventHandler<SE.Nereda.Symbols.EmergencyReactor.GRAPHEventArgs> GRAPH_Fired;

    private event EventHandler<SE.Nereda.Symbols.EmergencyReactor.EMERGENCY_ONEventArgs> EMERGENCY_ON_Fired;

    private event EventHandler<SE.Nereda.Symbols.EmergencyReactor.RESET_F_TRSEventArgs> RESET_F_TRS_Fired;

    private event EventHandler<SE.Nereda.Symbols.EmergencyReactor.ENABLE_FORCE_INEventArgs> ENABLE_FORCE_IN_Fired;

    private event EventHandler<SE.Nereda.Symbols.EmergencyReactor.S5_AERATE_TEventArgs> S5_AERATE_T_Fired;

    private event EventHandler<SE.Nereda.Symbols.EmergencyReactor.WARNINGEventArgs> WARNING_Fired;

    private event EventHandler<SE.Nereda.Symbols.EmergencyReactor.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    private event EventHandler<SE.Nereda.Symbols.EmergencyReactor.FORCE_UNAVEventArgs> FORCE_UNAV_Fired;

    protected override void OnEndInit()
    {
      if (GRAPH_Fired != null)
        AttachEventInput(0);
      if (EMERGENCY_ON_Fired != null)
        AttachEventInput(1);
      if (RESET_F_TRS_Fired != null)
        AttachEventInput(2);
      if (ENABLE_FORCE_IN_Fired != null)
        AttachEventInput(3);
      if (S5_AERATE_T_Fired != null)
        AttachEventInput(4);
      if (WARNING_Fired != null)
        AttachEventInput(5);
      if (LOAD_PERS_DATA_Fired != null)
        AttachEventInput(6);
      if (FORCE_UNAV_Fired != null)
        AttachEventInput(7);

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
              GRAPH_Fired(this, new SE.Nereda.Symbols.EmergencyReactor.GRAPHEventArgs(channelId, cookie, eventIndex));
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
          if (EMERGENCY_ON_Fired != null)
          {
            try
            {
              EMERGENCY_ON_Fired(this, new SE.Nereda.Symbols.EmergencyReactor.EMERGENCY_ONEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","EMERGENCY_ON_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 2:
          if (RESET_F_TRS_Fired != null)
          {
            try
            {
              RESET_F_TRS_Fired(this, new SE.Nereda.Symbols.EmergencyReactor.RESET_F_TRSEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","RESET_F_TRS_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 3:
          if (ENABLE_FORCE_IN_Fired != null)
          {
            try
            {
              ENABLE_FORCE_IN_Fired(this, new SE.Nereda.Symbols.EmergencyReactor.ENABLE_FORCE_INEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","ENABLE_FORCE_IN_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 4:
          if (S5_AERATE_T_Fired != null)
          {
            try
            {
              S5_AERATE_T_Fired(this, new SE.Nereda.Symbols.EmergencyReactor.S5_AERATE_TEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","S5_AERATE_T_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 5:
          if (WARNING_Fired != null)
          {
            try
            {
              WARNING_Fired(this, new SE.Nereda.Symbols.EmergencyReactor.WARNINGEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","WARNING_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 6:
          if (LOAD_PERS_DATA_Fired != null)
          {
            try
            {
              LOAD_PERS_DATA_Fired(this, new SE.Nereda.Symbols.EmergencyReactor.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","LOAD_PERS_DATA_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 7:
          if (FORCE_UNAV_Fired != null)
          {
            try
            {
              FORCE_UNAV_Fired(this, new SE.Nereda.Symbols.EmergencyReactor.FORCE_UNAVEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","FORCE_UNAV_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_FORCE(System.Int16 Force)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {Force});
    }
    public bool FireEvent_FORCE(SE.Nereda.Symbols.EmergencyReactor.FORCEEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.Force.HasValue) _values_[0] = ea.Force.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_FORCE(System.Int16 Force, bool ignore_Force)
    {
      object[] _values_ = new object[1];
      if (!ignore_Force) _values_[0] = Force;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_ENABLE_FORCE_OUT(System.Boolean oEnableForce)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {oEnableForce});
    }
    public bool FireEvent_ENABLE_FORCE_OUT(SE.Nereda.Symbols.EmergencyReactor.ENABLE_FORCE_OUTEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.oEnableForce.HasValue) _values_[0] = ea.oEnableForce.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_ENABLE_FORCE_OUT(System.Boolean oEnableForce, bool ignore_oEnableForce)
    {
      object[] _values_ = new object[1];
      if (!ignore_oEnableForce) _values_[0] = oEnableForce;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_STEPS_TIME(NxtControl.GuiFramework.Time S1_FeedTime, NxtControl.GuiFramework.Time S2_WaitTime, NxtControl.GuiFramework.Time S3_SludgeDischargeTime, NxtControl.GuiFramework.Time S4_LowerLevelTime, NxtControl.GuiFramework.Time S6_VentTime, NxtControl.GuiFramework.Time S7_SludgeDischargeTime, NxtControl.GuiFramework.Time S8_WaitTime)
    {
      return ((IHMIAccessorOutput)this).FireEvent(2, new object[] {S1_FeedTime, S2_WaitTime, S3_SludgeDischargeTime, S4_LowerLevelTime, S6_VentTime, S7_SludgeDischargeTime, S8_WaitTime});
    }
    public bool FireEvent_STEPS_TIME(SE.Nereda.Symbols.EmergencyReactor.STEPS_TIMEEventArgs ea)
    {
      object[] _values_ = new object[7];
      if (ea.S1_FeedTime.HasValue) _values_[0] = ea.S1_FeedTime.Value;
      if (ea.S2_WaitTime.HasValue) _values_[1] = ea.S2_WaitTime.Value;
      if (ea.S3_SludgeDischargeTime.HasValue) _values_[2] = ea.S3_SludgeDischargeTime.Value;
      if (ea.S4_LowerLevelTime.HasValue) _values_[3] = ea.S4_LowerLevelTime.Value;
      if (ea.S6_VentTime.HasValue) _values_[4] = ea.S6_VentTime.Value;
      if (ea.S7_SludgeDischargeTime.HasValue) _values_[5] = ea.S7_SludgeDischargeTime.Value;
      if (ea.S8_WaitTime.HasValue) _values_[6] = ea.S8_WaitTime.Value;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_STEPS_TIME(NxtControl.GuiFramework.Time S1_FeedTime, bool ignore_S1_FeedTime, NxtControl.GuiFramework.Time S2_WaitTime, bool ignore_S2_WaitTime, NxtControl.GuiFramework.Time S3_SludgeDischargeTime, bool ignore_S3_SludgeDischargeTime, NxtControl.GuiFramework.Time S4_LowerLevelTime, bool ignore_S4_LowerLevelTime, NxtControl.GuiFramework.Time S6_VentTime, bool ignore_S6_VentTime, NxtControl.GuiFramework.Time S7_SludgeDischargeTime, bool ignore_S7_SludgeDischargeTime, NxtControl.GuiFramework.Time S8_WaitTime, bool ignore_S8_WaitTime)
    {
      object[] _values_ = new object[7];
      if (!ignore_S1_FeedTime) _values_[0] = S1_FeedTime;
      if (!ignore_S2_WaitTime) _values_[1] = S2_WaitTime;
      if (!ignore_S3_SludgeDischargeTime) _values_[2] = S3_SludgeDischargeTime;
      if (!ignore_S4_LowerLevelTime) _values_[3] = S4_LowerLevelTime;
      if (!ignore_S6_VentTime) _values_[4] = S6_VentTime;
      if (!ignore_S7_SludgeDischargeTime) _values_[5] = S7_SludgeDischargeTime;
      if (!ignore_S8_WaitTime) _values_[6] = S8_WaitTime;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_FEED_PAR(System.Single FeedCapacity)
    {
      return ((IHMIAccessorOutput)this).FireEvent(3, new object[] {FeedCapacity});
    }
    public bool FireEvent_FEED_PAR(SE.Nereda.Symbols.EmergencyReactor.FEED_PAREventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.FeedCapacity.HasValue) _values_[0] = ea.FeedCapacity.Value;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_FEED_PAR(System.Single FeedCapacity, bool ignore_FeedCapacity)
    {
      object[] _values_ = new object[1];
      if (!ignore_FeedCapacity) _values_[0] = FeedCapacity;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_AERATE_PAR(System.Single AerationCapacity, System.Boolean InfluentGrid, System.Boolean AerationGrid)
    {
      return ((IHMIAccessorOutput)this).FireEvent(4, new object[] {AerationCapacity, InfluentGrid, AerationGrid});
    }
    public bool FireEvent_AERATE_PAR(SE.Nereda.Symbols.EmergencyReactor.AERATE_PAREventArgs ea)
    {
      object[] _values_ = new object[3];
      if (ea.AerationCapacity.HasValue) _values_[0] = ea.AerationCapacity.Value;
      if (ea.InfluentGrid.HasValue) _values_[1] = ea.InfluentGrid.Value;
      if (ea.AerationGrid.HasValue) _values_[2] = ea.AerationGrid.Value;
      return ((IHMIAccessorOutput)this).FireEvent(4, _values_);
    }
    public bool FireEvent_AERATE_PAR(System.Single AerationCapacity, bool ignore_AerationCapacity, System.Boolean InfluentGrid, bool ignore_InfluentGrid, System.Boolean AerationGrid, bool ignore_AerationGrid)
    {
      object[] _values_ = new object[3];
      if (!ignore_AerationCapacity) _values_[0] = AerationCapacity;
      if (!ignore_InfluentGrid) _values_[1] = InfluentGrid;
      if (!ignore_AerationGrid) _values_[2] = AerationGrid;
      return ((IHMIAccessorOutput)this).FireEvent(4, _values_);
    }
    public bool FireEvent_VENT_PAR(System.Boolean AirVentGrid, System.Boolean AirVentInfGrid)
    {
      return ((IHMIAccessorOutput)this).FireEvent(5, new object[] {AirVentGrid, AirVentInfGrid});
    }
    public bool FireEvent_VENT_PAR(SE.Nereda.Symbols.EmergencyReactor.VENT_PAREventArgs ea)
    {
      object[] _values_ = new object[2];
      if (ea.AirVentGrid.HasValue) _values_[0] = ea.AirVentGrid.Value;
      if (ea.AirVentInfGrid.HasValue) _values_[1] = ea.AirVentInfGrid.Value;
      return ((IHMIAccessorOutput)this).FireEvent(5, _values_);
    }
    public bool FireEvent_VENT_PAR(System.Boolean AirVentGrid, bool ignore_AirVentGrid, System.Boolean AirVentInfGrid, bool ignore_AirVentInfGrid)
    {
      object[] _values_ = new object[2];
      if (!ignore_AirVentGrid) _values_[0] = AirVentGrid;
      if (!ignore_AirVentInfGrid) _values_[1] = AirVentInfGrid;
      return ((IHMIAccessorOutput)this).FireEvent(5, _values_);
    }
    public bool FireEvent_AIR_LICK_T(NxtControl.GuiFramework.Time AirLockTime)
    {
      return ((IHMIAccessorOutput)this).FireEvent(6, new object[] {AirLockTime});
    }
    public bool FireEvent_AIR_LICK_T(SE.Nereda.Symbols.EmergencyReactor.AIR_LICK_TEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.AirLockTime.HasValue) _values_[0] = ea.AirLockTime.Value;
      return ((IHMIAccessorOutput)this).FireEvent(6, _values_);
    }
    public bool FireEvent_AIR_LICK_T(NxtControl.GuiFramework.Time AirLockTime, bool ignore_AirLockTime)
    {
      object[] _values_ = new object[1];
      if (!ignore_AirLockTime) _values_[0] = AirLockTime;
      return ((IHMIAccessorOutput)this).FireEvent(6, _values_);
    }

  }
}
#endregion #EmergencyReactor_HMI;

#endregion Definitions;
