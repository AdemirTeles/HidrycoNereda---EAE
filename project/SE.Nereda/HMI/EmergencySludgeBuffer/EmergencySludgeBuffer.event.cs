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
#region #EmergencySludgeBuffer_HMI;

namespace SE.Nereda.Symbols.EmergencySludgeBuffer
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

namespace SE.Nereda.Symbols.EmergencySludgeBuffer
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
    private NxtControl.GuiFramework.Time? S2_WaitSludge_field = null;
    public NxtControl.GuiFramework.Time? S2_WaitSludge
    {
       get { return S2_WaitSludge_field; }
       set { S2_WaitSludge_field = value; }
    }
    private NxtControl.GuiFramework.Time? S3_SludgeDischargeTime_field = null;
    public NxtControl.GuiFramework.Time? S3_SludgeDischargeTime
    {
       get { return S3_SludgeDischargeTime_field; }
       set { S3_SludgeDischargeTime_field = value; }
    }
    private NxtControl.GuiFramework.Time? S4_SupernantDischargeTime_field = null;
    public NxtControl.GuiFramework.Time? S4_SupernantDischargeTime
    {
       get { return S4_SupernantDischargeTime_field; }
       set { S4_SupernantDischargeTime_field = value; }
    }

  }

  public class SLD_DIS_PAREventArgs : System.EventArgs
  {
    public SLD_DIS_PAREventArgs()
    {
    }
    private System.Int16? SludgeDischargeCapacity_field = null;
    public System.Int16? SludgeDischargeCapacity
    {
       get { return SludgeDischargeCapacity_field; }
       set { SludgeDischargeCapacity_field = value; }
    }

  }

  public class SUP_DIS_PAREventArgs : System.EventArgs
  {
    public SUP_DIS_PAREventArgs()
    {
    }
    private System.Int16? SupernantDischargeCapacity_field = null;
    public System.Int16? SupernantDischargeCapacity
    {
       get { return SupernantDischargeCapacity_field; }
       set { SupernantDischargeCapacity_field = value; }
    }

  }

  public class REST_LVLEventArgs : System.EventArgs
  {
    public REST_LVLEventArgs()
    {
    }
    private System.Int16? Restartlvl_field = null;
    public System.Int16? Restartlvl
    {
       get { return Restartlvl_field; }
       set { Restartlvl_field = value; }
    }

  }

}

namespace SE.Nereda.Symbols.EmergencySludgeBuffer
{}

namespace SE.Nereda.Symbols.EmergencySludgeBuffer
{
  partial class Symbol1
  {

    private event EventHandler<SE.Nereda.Symbols.EmergencySludgeBuffer.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    private event EventHandler<SE.Nereda.Symbols.EmergencySludgeBuffer.GRAPHEventArgs> GRAPH_Fired;

    private event EventHandler<SE.Nereda.Symbols.EmergencySludgeBuffer.EMERGENCY_ONEventArgs> EMERGENCY_ON_Fired;

    private event EventHandler<SE.Nereda.Symbols.EmergencySludgeBuffer.FORCE_UNAVEventArgs> FORCE_UNAV_Fired;

    protected override void OnEndInit()
    {
      if (LOAD_PERS_DATA_Fired != null)
        AttachEventInput(0);
      if (GRAPH_Fired != null)
        AttachEventInput(1);
      if (EMERGENCY_ON_Fired != null)
        AttachEventInput(2);
      if (FORCE_UNAV_Fired != null)
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
              LOAD_PERS_DATA_Fired(this, new SE.Nereda.Symbols.EmergencySludgeBuffer.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
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
          if (GRAPH_Fired != null)
          {
            try
            {
              GRAPH_Fired(this, new SE.Nereda.Symbols.EmergencySludgeBuffer.GRAPHEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","GRAPH_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 2:
          if (EMERGENCY_ON_Fired != null)
          {
            try
            {
              EMERGENCY_ON_Fired(this, new SE.Nereda.Symbols.EmergencySludgeBuffer.EMERGENCY_ONEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","EMERGENCY_ON_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 3:
          if (FORCE_UNAV_Fired != null)
          {
            try
            {
              FORCE_UNAV_Fired(this, new SE.Nereda.Symbols.EmergencySludgeBuffer.FORCE_UNAVEventArgs(channelId, cookie, eventIndex));
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
    public bool FireEvent_FORCE(SE.Nereda.Symbols.EmergencySludgeBuffer.FORCEEventArgs ea)
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
    public bool FireEvent_STEPS_TIME(NxtControl.GuiFramework.Time S1_FeedTime, NxtControl.GuiFramework.Time S2_WaitSludge, NxtControl.GuiFramework.Time S3_SludgeDischargeTime, NxtControl.GuiFramework.Time S4_SupernantDischargeTime)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {S1_FeedTime, S2_WaitSludge, S3_SludgeDischargeTime, S4_SupernantDischargeTime});
    }
    public bool FireEvent_STEPS_TIME(SE.Nereda.Symbols.EmergencySludgeBuffer.STEPS_TIMEEventArgs ea)
    {
      object[] _values_ = new object[4];
      if (ea.S1_FeedTime.HasValue) _values_[0] = ea.S1_FeedTime.Value;
      if (ea.S2_WaitSludge.HasValue) _values_[1] = ea.S2_WaitSludge.Value;
      if (ea.S3_SludgeDischargeTime.HasValue) _values_[2] = ea.S3_SludgeDischargeTime.Value;
      if (ea.S4_SupernantDischargeTime.HasValue) _values_[3] = ea.S4_SupernantDischargeTime.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_STEPS_TIME(NxtControl.GuiFramework.Time S1_FeedTime, bool ignore_S1_FeedTime, NxtControl.GuiFramework.Time S2_WaitSludge, bool ignore_S2_WaitSludge, NxtControl.GuiFramework.Time S3_SludgeDischargeTime, bool ignore_S3_SludgeDischargeTime, NxtControl.GuiFramework.Time S4_SupernantDischargeTime, bool ignore_S4_SupernantDischargeTime)
    {
      object[] _values_ = new object[4];
      if (!ignore_S1_FeedTime) _values_[0] = S1_FeedTime;
      if (!ignore_S2_WaitSludge) _values_[1] = S2_WaitSludge;
      if (!ignore_S3_SludgeDischargeTime) _values_[2] = S3_SludgeDischargeTime;
      if (!ignore_S4_SupernantDischargeTime) _values_[3] = S4_SupernantDischargeTime;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_SLD_DIS_PAR(System.Int16 SludgeDischargeCapacity)
    {
      return ((IHMIAccessorOutput)this).FireEvent(2, new object[] {SludgeDischargeCapacity});
    }
    public bool FireEvent_SLD_DIS_PAR(SE.Nereda.Symbols.EmergencySludgeBuffer.SLD_DIS_PAREventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.SludgeDischargeCapacity.HasValue) _values_[0] = ea.SludgeDischargeCapacity.Value;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_SLD_DIS_PAR(System.Int16 SludgeDischargeCapacity, bool ignore_SludgeDischargeCapacity)
    {
      object[] _values_ = new object[1];
      if (!ignore_SludgeDischargeCapacity) _values_[0] = SludgeDischargeCapacity;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_SUP_DIS_PAR(System.Int16 SupernantDischargeCapacity)
    {
      return ((IHMIAccessorOutput)this).FireEvent(3, new object[] {SupernantDischargeCapacity});
    }
    public bool FireEvent_SUP_DIS_PAR(SE.Nereda.Symbols.EmergencySludgeBuffer.SUP_DIS_PAREventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.SupernantDischargeCapacity.HasValue) _values_[0] = ea.SupernantDischargeCapacity.Value;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_SUP_DIS_PAR(System.Int16 SupernantDischargeCapacity, bool ignore_SupernantDischargeCapacity)
    {
      object[] _values_ = new object[1];
      if (!ignore_SupernantDischargeCapacity) _values_[0] = SupernantDischargeCapacity;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_REST_LVL(System.Int16 Restartlvl)
    {
      return ((IHMIAccessorOutput)this).FireEvent(4, new object[] {Restartlvl});
    }
    public bool FireEvent_REST_LVL(SE.Nereda.Symbols.EmergencySludgeBuffer.REST_LVLEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.Restartlvl.HasValue) _values_[0] = ea.Restartlvl.Value;
      return ((IHMIAccessorOutput)this).FireEvent(4, _values_);
    }
    public bool FireEvent_REST_LVL(System.Int16 Restartlvl, bool ignore_Restartlvl)
    {
      object[] _values_ = new object[1];
      if (!ignore_Restartlvl) _values_[0] = Restartlvl;
      return ((IHMIAccessorOutput)this).FireEvent(4, _values_);
    }

  }
}
#endregion #EmergencySludgeBuffer_HMI;

#endregion Definitions;
