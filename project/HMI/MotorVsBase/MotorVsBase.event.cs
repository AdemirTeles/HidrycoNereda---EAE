/*
 * Created by EcoStruxure Automation Expert.
 * User: SESA215738
 * Date: 07/12/2020
 * Time: 5:41 pm
 * 
 */
using System;
using NxtControl.GuiFramework;
using NxtControl.Services;

#region Definitions;
#region #MotorVsBase_HMI;

namespace HMI.Main.Symbols.MotorVsBase
{

  public class UPDEventArgs : System.EventArgs
  {
    IHMIAccessorService accessorService;
    int channelId;
    int cookie; 
    int eventIndex;

    public UPDEventArgs(int channelId, int cookie, int eventIndex)
    {
      this.accessorService = (IHMIAccessorService)ServiceProvider.GetService(typeof(IHMIAccessorService));
      this.channelId = channelId;
      this.cookie = cookie;
      this.eventIndex = eventIndex;
    }
    public bool Get_FbStatus(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,0, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? FbStatus
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,0, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }

    public bool Get_TransFbStatus(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,1, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? TransFbStatus
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,1, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }

    public bool Get_SpeedFbStatus(ref System.Single value)
    {
      if (accessorService == null)
        return false;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,2, ref var);
      if (ret) value = (System.Single) var;
      return ret;
    }

    public System.Single? SpeedFbStatus
    { get {
      if (accessorService == null)
        return null;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,2, ref var);
      if (!ret) return null;
      return (System.Single) var;
    }  }

    public bool Get_CurrentSp(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,3, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? CurrentSp
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,3, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }

    public bool Get_CurrentOp(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,4, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? CurrentOp
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,4, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }

    public bool Get_CurrentSpeedSp(ref System.Single value)
    {
      if (accessorService == null)
        return false;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,5, ref var);
      if (ret) value = (System.Single) var;
      return ret;
    }

    public System.Single? CurrentSpeedSp
    { get {
      if (accessorService == null)
        return null;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,5, ref var);
      if (!ret) return null;
      return (System.Single) var;
    }  }

    public bool Get_CurrentSpeedOp(ref System.Single value)
    {
      if (accessorService == null)
        return false;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,6, ref var);
      if (ret) value = (System.Single) var;
      return ret;
    }

    public System.Single? CurrentSpeedOp
    { get {
      if (accessorService == null)
        return null;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,6, ref var);
      if (!ret) return null;
      return (System.Single) var;
    }  }

    public bool Get_CurrentOwner(ref System.UInt16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,7, ref var);
      if (ret) value = (System.UInt16) var;
      return ret;
    }

    public System.UInt16? CurrentOwner
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,7, ref var);
      if (!ret) return null;
      return (System.UInt16) var;
    }  }

    public bool Get_NeedReset(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,8, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? NeedReset
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,8, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_IlckCond(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,9, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? IlckCond
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,9, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_FbFail(ref NxtControl.GuiFramework.VTQ<System.Boolean> value)
    {
      if (accessorService == null)
        return false;
      NxtControl.GuiFramework.VTQ<System.Boolean> var = default;
      bool ret = accessorService.GetVTQValue<System.Boolean>(channelId, cookie, eventIndex, true,10, ref var);
      if (ret) value = (NxtControl.GuiFramework.VTQ<System.Boolean>) var;
      return ret;
    }

    public NxtControl.GuiFramework.VTQ<System.Boolean>? FbFail
    { get {
      if (accessorService == null)
        return null;
      NxtControl.GuiFramework.VTQ<System.Boolean> var = default;
      bool ret = accessorService.GetVTQValue<System.Boolean>(channelId, cookie, eventIndex, true,10, ref var);
      if (!ret) return null;
      return (NxtControl.GuiFramework.VTQ<System.Boolean>) var;
    }  }

    public bool Get_DeviceFail(ref NxtControl.GuiFramework.VTQ<System.Boolean> value)
    {
      if (accessorService == null)
        return false;
      NxtControl.GuiFramework.VTQ<System.Boolean> var = default;
      bool ret = accessorService.GetVTQValue<System.Boolean>(channelId, cookie, eventIndex, true,11, ref var);
      if (ret) value = (NxtControl.GuiFramework.VTQ<System.Boolean>) var;
      return ret;
    }

    public NxtControl.GuiFramework.VTQ<System.Boolean>? DeviceFail
    { get {
      if (accessorService == null)
        return null;
      NxtControl.GuiFramework.VTQ<System.Boolean> var = default;
      bool ret = accessorService.GetVTQValue<System.Boolean>(channelId, cookie, eventIndex, true,11, ref var);
      if (!ret) return null;
      return (NxtControl.GuiFramework.VTQ<System.Boolean>) var;
    }  }

    public bool Get_Fail(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,12, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? Fail
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,12, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_PermStop(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,13, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? PermStop
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,13, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_PermFwd(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,14, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? PermFwd
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,14, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_PermRev(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,15, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? PermRev
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,15, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_StdOwnerConnected(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,16, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? StdOwnerConnected
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,16, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_CurrentSpeedOwner(ref System.UInt16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,17, ref var);
      if (ret) value = (System.UInt16) var;
      return ret;
    }

    public System.UInt16? CurrentSpeedOwner
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,17, ref var);
      if (!ret) return null;
      return (System.UInt16) var;
    }  }

    public bool Get_CurrentSpeedSpMin(ref System.Single value)
    {
      if (accessorService == null)
        return false;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,18, ref var);
      if (ret) value = (System.Single) var;
      return ret;
    }

    public System.Single? CurrentSpeedSpMin
    { get {
      if (accessorService == null)
        return null;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,18, ref var);
      if (!ret) return null;
      return (System.Single) var;
    }  }

    public bool Get_CurrentSpeedSpMax(ref System.Single value)
    {
      if (accessorService == null)
        return false;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,19, ref var);
      if (ret) value = (System.Single) var;
      return ret;
    }

    public System.Single? CurrentSpeedSpMax
    { get {
      if (accessorService == null)
        return null;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,19, ref var);
      if (!ret) return null;
      return (System.Single) var;
    }  }

    public bool Get_ExternalControlled(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,20, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? ExternalControlled
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,20, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }


  }

  public class UPD_TIMEEventArgs : System.EventArgs
  {
    IHMIAccessorService accessorService;
    int channelId;
    int cookie; 
    int eventIndex;

    public UPD_TIMEEventArgs(int channelId, int cookie, int eventIndex)
    {
      this.accessorService = (IHMIAccessorService)ServiceProvider.GetService(typeof(IHMIAccessorService));
      this.channelId = channelId;
      this.cookie = cookie;
      this.eventIndex = eventIndex;
    }
    public bool Get_PassiveRemainTime(ref System.Single value)
    {
      if (accessorService == null)
        return false;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,0, ref var);
      if (ret) value = (System.Single) var;
      return ret;
    }

    public System.Single? PassiveRemainTime
    { get {
      if (accessorService == null)
        return null;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,0, ref var);
      if (!ret) return null;
      return (System.Single) var;
    }  }


  }

}

namespace HMI.Main.Symbols.MotorVsBase
{

  public class OWNEREventArgs : System.EventArgs
  {
    public OWNEREventArgs()
    {
    }
    private System.UInt16? Owner_field = null;
    public System.UInt16? Owner
    {
       get { return Owner_field; }
       set { Owner_field = value; }
    }

  }

  public class SPEED_OWNEREventArgs : System.EventArgs
  {
    public SPEED_OWNEREventArgs()
    {
    }
    private System.Boolean? EnSpeedOwner_field = null;
    public System.Boolean? EnSpeedOwner
    {
       get { return EnSpeedOwner_field; }
       set { EnSpeedOwner_field = value; }
    }
    private System.Boolean? SpeedOwner_field = null;
    public System.Boolean? SpeedOwner
    {
       get { return SpeedOwner_field; }
       set { SpeedOwner_field = value; }
    }

  }

  public class CFGEventArgs : System.EventArgs
  {
    public CFGEventArgs()
    {
    }
    private System.Int32? MonTime_field = null;
    public System.Int32? MonTime
    {
       get { return MonTime_field; }
       set { MonTime_field = value; }
    }
    private System.Int32? TripTime_field = null;
    public System.Int32? TripTime
    {
       get { return TripTime_field; }
       set { TripTime_field = value; }
    }
    private System.Int32? PassiveTime_field = null;
    public System.Int32? PassiveTime
    {
       get { return PassiveTime_field; }
       set { PassiveTime_field = value; }
    }
    private System.Boolean? ConfResetReq_field = null;
    public System.Boolean? ConfResetReq
    {
       get { return ConfResetReq_field; }
       set { ConfResetReq_field = value; }
    }
    private System.Boolean? FailResetReq_field = null;
    public System.Boolean? FailResetReq
    {
       get { return FailResetReq_field; }
       set { FailResetReq_field = value; }
    }
    private System.Int32? ScanTime_field = null;
    public System.Int32? ScanTime
    {
       get { return ScanTime_field; }
       set { ScanTime_field = value; }
    }
    private System.Byte? AlmAckType_field = null;
    public System.Byte? AlmAckType
    {
       get { return AlmAckType_field; }
       set { AlmAckType_field = value; }
    }
    private System.Boolean? EnTrackSp_field = null;
    public System.Boolean? EnTrackSp
    {
       get { return EnTrackSp_field; }
       set { EnTrackSp_field = value; }
    }
    private System.Boolean? EnResetSp_field = null;
    public System.Boolean? EnResetSp
    {
       get { return EnResetSp_field; }
       set { EnResetSp_field = value; }
    }
    private System.Boolean? DisReverse_field = null;
    public System.Boolean? DisReverse
    {
       get { return DisReverse_field; }
       set { DisReverse_field = value; }
    }
    private System.Boolean? SpeedSpRangeSel_field = null;
    public System.Boolean? SpeedSpRangeSel
    {
       get { return SpeedSpRangeSel_field; }
       set { SpeedSpRangeSel_field = value; }
    }

  }

  public class SPEEDSP_CFGEventArgs : System.EventArgs
  {
    public SPEEDSP_CFGEventArgs()
    {
    }
    private System.Single? SpeedRawMin_field = null;
    public System.Single? SpeedRawMin
    {
       get { return SpeedRawMin_field; }
       set { SpeedRawMin_field = value; }
    }
    private System.Single? SpeedRawMax_field = null;
    public System.Single? SpeedRawMax
    {
       get { return SpeedRawMax_field; }
       set { SpeedRawMax_field = value; }
    }
    private System.Boolean? SpeedRawIsAbsolute_field = null;
    public System.Boolean? SpeedRawIsAbsolute
    {
       get { return SpeedRawIsAbsolute_field; }
       set { SpeedRawIsAbsolute_field = value; }
    }
    private System.Single? SpeedSpMin_field = null;
    public System.Single? SpeedSpMin
    {
       get { return SpeedSpMin_field; }
       set { SpeedSpMin_field = value; }
    }
    private System.Single? SpeedSpMax_field = null;
    public System.Single? SpeedSpMax
    {
       get { return SpeedSpMax_field; }
       set { SpeedSpMax_field = value; }
    }

  }

  public class SPEEDOUT_CFGEventArgs : System.EventArgs
  {
    public SPEEDOUT_CFGEventArgs()
    {
    }
    private System.Single? SpeedOutMin_field = null;
    public System.Single? SpeedOutMin
    {
       get { return SpeedOutMin_field; }
       set { SpeedOutMin_field = value; }
    }
    private System.Single? SpeedOutMax_field = null;
    public System.Single? SpeedOutMax
    {
       get { return SpeedOutMax_field; }
       set { SpeedOutMax_field = value; }
    }

  }

  public class SP_CMDEventArgs : System.EventArgs
  {
    public SP_CMDEventArgs()
    {
    }
    private System.Int16? Sp_field = null;
    public System.Int16? Sp
    {
       get { return Sp_field; }
       set { Sp_field = value; }
    }

  }

  public class SPEEDSP_CMDEventArgs : System.EventArgs
  {
    public SPEEDSP_CMDEventArgs()
    {
    }
    private System.Single? SpeedSp_field = null;
    public System.Single? SpeedSp
    {
       get { return SpeedSp_field; }
       set { SpeedSp_field = value; }
    }

  }

  public class RESET_CMDEventArgs : System.EventArgs
  {
    public RESET_CMDEventArgs()
    {
    }
    private System.Boolean? Reset_field = null;
    public System.Boolean? Reset
    {
       get { return Reset_field; }
       set { Reset_field = value; }
    }

  }

  public class IND_MODEEventArgs : System.EventArgs
  {
    public IND_MODEEventArgs()
    {
    }
    private System.Boolean? Simulation_field = null;
    public System.Boolean? Simulation
    {
       get { return Simulation_field; }
       set { Simulation_field = value; }
    }
    private System.Boolean? FbOverride_field = null;
    public System.Boolean? FbOverride
    {
       get { return FbOverride_field; }
       set { FbOverride_field = value; }
    }
    private System.Boolean? Maintenance_field = null;
    public System.Boolean? Maintenance
    {
       get { return Maintenance_field; }
       set { Maintenance_field = value; }
    }
    private System.Boolean? OutOfService_field = null;
    public System.Boolean? OutOfService
    {
       get { return OutOfService_field; }
       set { OutOfService_field = value; }
    }

  }

}

namespace HMI.Main.Symbols.MotorVsBase
{
  partial class sDefault
  {

    private event EventHandler<HMI.Main.Symbols.MotorVsBase.UPDEventArgs> UPD_Fired;

    private event EventHandler<HMI.Main.Symbols.MotorVsBase.UPD_TIMEEventArgs> UPD_TIME_Fired;

    protected override void OnEndInit()
    {
      if (UPD_Fired != null)
        AttachEventInput(0);
      if (UPD_TIME_Fired != null)
        AttachEventInput(1);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (UPD_Fired != null)
          {
            try
            {
              UPD_Fired(this, new HMI.Main.Symbols.MotorVsBase.UPDEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","UPD_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 1:
          if (UPD_TIME_Fired != null)
          {
            try
            {
              UPD_TIME_Fired(this, new HMI.Main.Symbols.MotorVsBase.UPD_TIMEEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","UPD_TIME_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_OWNER(System.UInt16 Owner)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {Owner});
    }
    public bool FireEvent_OWNER(HMI.Main.Symbols.MotorVsBase.OWNEREventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.Owner.HasValue) _values_[0] = ea.Owner.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_OWNER(System.UInt16 Owner, bool ignore_Owner)
    {
      object[] _values_ = new object[1];
      if (!ignore_Owner) _values_[0] = Owner;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_SPEED_OWNER(System.Boolean EnSpeedOwner, System.Boolean SpeedOwner)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {EnSpeedOwner, SpeedOwner});
    }
    public bool FireEvent_SPEED_OWNER(HMI.Main.Symbols.MotorVsBase.SPEED_OWNEREventArgs ea)
    {
      object[] _values_ = new object[2];
      if (ea.EnSpeedOwner.HasValue) _values_[0] = ea.EnSpeedOwner.Value;
      if (ea.SpeedOwner.HasValue) _values_[1] = ea.SpeedOwner.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_SPEED_OWNER(System.Boolean EnSpeedOwner, bool ignore_EnSpeedOwner, System.Boolean SpeedOwner, bool ignore_SpeedOwner)
    {
      object[] _values_ = new object[2];
      if (!ignore_EnSpeedOwner) _values_[0] = EnSpeedOwner;
      if (!ignore_SpeedOwner) _values_[1] = SpeedOwner;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_CFG(System.Int32 MonTime, System.Int32 TripTime, System.Int32 PassiveTime, System.Boolean ConfResetReq, System.Boolean FailResetReq, System.Int32 ScanTime, System.Byte AlmAckType, System.Boolean EnTrackSp, System.Boolean EnResetSp, System.Boolean DisReverse, System.Boolean SpeedSpRangeSel)
    {
      return ((IHMIAccessorOutput)this).FireEvent(2, new object[] {MonTime, TripTime, PassiveTime, ConfResetReq, FailResetReq, ScanTime, AlmAckType, EnTrackSp, EnResetSp, DisReverse, SpeedSpRangeSel});
    }
    public bool FireEvent_CFG(HMI.Main.Symbols.MotorVsBase.CFGEventArgs ea)
    {
      object[] _values_ = new object[11];
      if (ea.MonTime.HasValue) _values_[0] = ea.MonTime.Value;
      if (ea.TripTime.HasValue) _values_[1] = ea.TripTime.Value;
      if (ea.PassiveTime.HasValue) _values_[2] = ea.PassiveTime.Value;
      if (ea.ConfResetReq.HasValue) _values_[3] = ea.ConfResetReq.Value;
      if (ea.FailResetReq.HasValue) _values_[4] = ea.FailResetReq.Value;
      if (ea.ScanTime.HasValue) _values_[5] = ea.ScanTime.Value;
      if (ea.AlmAckType.HasValue) _values_[6] = ea.AlmAckType.Value;
      if (ea.EnTrackSp.HasValue) _values_[7] = ea.EnTrackSp.Value;
      if (ea.EnResetSp.HasValue) _values_[8] = ea.EnResetSp.Value;
      if (ea.DisReverse.HasValue) _values_[9] = ea.DisReverse.Value;
      if (ea.SpeedSpRangeSel.HasValue) _values_[10] = ea.SpeedSpRangeSel.Value;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_CFG(System.Int32 MonTime, bool ignore_MonTime, System.Int32 TripTime, bool ignore_TripTime, System.Int32 PassiveTime, bool ignore_PassiveTime, System.Boolean ConfResetReq, bool ignore_ConfResetReq, System.Boolean FailResetReq, bool ignore_FailResetReq, System.Int32 ScanTime, bool ignore_ScanTime, System.Byte AlmAckType, bool ignore_AlmAckType, System.Boolean EnTrackSp, bool ignore_EnTrackSp, System.Boolean EnResetSp, bool ignore_EnResetSp, System.Boolean DisReverse, bool ignore_DisReverse, System.Boolean SpeedSpRangeSel, bool ignore_SpeedSpRangeSel)
    {
      object[] _values_ = new object[11];
      if (!ignore_MonTime) _values_[0] = MonTime;
      if (!ignore_TripTime) _values_[1] = TripTime;
      if (!ignore_PassiveTime) _values_[2] = PassiveTime;
      if (!ignore_ConfResetReq) _values_[3] = ConfResetReq;
      if (!ignore_FailResetReq) _values_[4] = FailResetReq;
      if (!ignore_ScanTime) _values_[5] = ScanTime;
      if (!ignore_AlmAckType) _values_[6] = AlmAckType;
      if (!ignore_EnTrackSp) _values_[7] = EnTrackSp;
      if (!ignore_EnResetSp) _values_[8] = EnResetSp;
      if (!ignore_DisReverse) _values_[9] = DisReverse;
      if (!ignore_SpeedSpRangeSel) _values_[10] = SpeedSpRangeSel;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_SPEEDSP_CFG(System.Single SpeedRawMin, System.Single SpeedRawMax, System.Boolean SpeedRawIsAbsolute, System.Single SpeedSpMin, System.Single SpeedSpMax)
    {
      return ((IHMIAccessorOutput)this).FireEvent(3, new object[] {SpeedRawMin, SpeedRawMax, SpeedRawIsAbsolute, SpeedSpMin, SpeedSpMax});
    }
    public bool FireEvent_SPEEDSP_CFG(HMI.Main.Symbols.MotorVsBase.SPEEDSP_CFGEventArgs ea)
    {
      object[] _values_ = new object[5];
      if (ea.SpeedRawMin.HasValue) _values_[0] = ea.SpeedRawMin.Value;
      if (ea.SpeedRawMax.HasValue) _values_[1] = ea.SpeedRawMax.Value;
      if (ea.SpeedRawIsAbsolute.HasValue) _values_[2] = ea.SpeedRawIsAbsolute.Value;
      if (ea.SpeedSpMin.HasValue) _values_[3] = ea.SpeedSpMin.Value;
      if (ea.SpeedSpMax.HasValue) _values_[4] = ea.SpeedSpMax.Value;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_SPEEDSP_CFG(System.Single SpeedRawMin, bool ignore_SpeedRawMin, System.Single SpeedRawMax, bool ignore_SpeedRawMax, System.Boolean SpeedRawIsAbsolute, bool ignore_SpeedRawIsAbsolute, System.Single SpeedSpMin, bool ignore_SpeedSpMin, System.Single SpeedSpMax, bool ignore_SpeedSpMax)
    {
      object[] _values_ = new object[5];
      if (!ignore_SpeedRawMin) _values_[0] = SpeedRawMin;
      if (!ignore_SpeedRawMax) _values_[1] = SpeedRawMax;
      if (!ignore_SpeedRawIsAbsolute) _values_[2] = SpeedRawIsAbsolute;
      if (!ignore_SpeedSpMin) _values_[3] = SpeedSpMin;
      if (!ignore_SpeedSpMax) _values_[4] = SpeedSpMax;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_SPEEDOUT_CFG(System.Single SpeedOutMin, System.Single SpeedOutMax)
    {
      return ((IHMIAccessorOutput)this).FireEvent(4, new object[] {SpeedOutMin, SpeedOutMax});
    }
    public bool FireEvent_SPEEDOUT_CFG(HMI.Main.Symbols.MotorVsBase.SPEEDOUT_CFGEventArgs ea)
    {
      object[] _values_ = new object[2];
      if (ea.SpeedOutMin.HasValue) _values_[0] = ea.SpeedOutMin.Value;
      if (ea.SpeedOutMax.HasValue) _values_[1] = ea.SpeedOutMax.Value;
      return ((IHMIAccessorOutput)this).FireEvent(4, _values_);
    }
    public bool FireEvent_SPEEDOUT_CFG(System.Single SpeedOutMin, bool ignore_SpeedOutMin, System.Single SpeedOutMax, bool ignore_SpeedOutMax)
    {
      object[] _values_ = new object[2];
      if (!ignore_SpeedOutMin) _values_[0] = SpeedOutMin;
      if (!ignore_SpeedOutMax) _values_[1] = SpeedOutMax;
      return ((IHMIAccessorOutput)this).FireEvent(4, _values_);
    }
    public bool FireEvent_SP_CMD(System.Int16 Sp)
    {
      return ((IHMIAccessorOutput)this).FireEvent(5, new object[] {Sp});
    }
    public bool FireEvent_SP_CMD(HMI.Main.Symbols.MotorVsBase.SP_CMDEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.Sp.HasValue) _values_[0] = ea.Sp.Value;
      return ((IHMIAccessorOutput)this).FireEvent(5, _values_);
    }
    public bool FireEvent_SP_CMD(System.Int16 Sp, bool ignore_Sp)
    {
      object[] _values_ = new object[1];
      if (!ignore_Sp) _values_[0] = Sp;
      return ((IHMIAccessorOutput)this).FireEvent(5, _values_);
    }
    public bool FireEvent_SPEEDSP_CMD(System.Single SpeedSp)
    {
      return ((IHMIAccessorOutput)this).FireEvent(6, new object[] {SpeedSp});
    }
    public bool FireEvent_SPEEDSP_CMD(HMI.Main.Symbols.MotorVsBase.SPEEDSP_CMDEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.SpeedSp.HasValue) _values_[0] = ea.SpeedSp.Value;
      return ((IHMIAccessorOutput)this).FireEvent(6, _values_);
    }
    public bool FireEvent_SPEEDSP_CMD(System.Single SpeedSp, bool ignore_SpeedSp)
    {
      object[] _values_ = new object[1];
      if (!ignore_SpeedSp) _values_[0] = SpeedSp;
      return ((IHMIAccessorOutput)this).FireEvent(6, _values_);
    }
    public bool FireEvent_RESET_CMD(System.Boolean Reset)
    {
      return ((IHMIAccessorOutput)this).FireEvent(7, new object[] {Reset});
    }
    public bool FireEvent_RESET_CMD(HMI.Main.Symbols.MotorVsBase.RESET_CMDEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.Reset.HasValue) _values_[0] = ea.Reset.Value;
      return ((IHMIAccessorOutput)this).FireEvent(7, _values_);
    }
    public bool FireEvent_RESET_CMD(System.Boolean Reset, bool ignore_Reset)
    {
      object[] _values_ = new object[1];
      if (!ignore_Reset) _values_[0] = Reset;
      return ((IHMIAccessorOutput)this).FireEvent(7, _values_);
    }
    public bool FireEvent_IND_MODE(System.Boolean Simulation, System.Boolean FbOverride, System.Boolean Maintenance, System.Boolean OutOfService)
    {
      return ((IHMIAccessorOutput)this).FireEvent(8, new object[] {Simulation, FbOverride, Maintenance, OutOfService});
    }
    public bool FireEvent_IND_MODE(HMI.Main.Symbols.MotorVsBase.IND_MODEEventArgs ea)
    {
      object[] _values_ = new object[4];
      if (ea.Simulation.HasValue) _values_[0] = ea.Simulation.Value;
      if (ea.FbOverride.HasValue) _values_[1] = ea.FbOverride.Value;
      if (ea.Maintenance.HasValue) _values_[2] = ea.Maintenance.Value;
      if (ea.OutOfService.HasValue) _values_[3] = ea.OutOfService.Value;
      return ((IHMIAccessorOutput)this).FireEvent(8, _values_);
    }
    public bool FireEvent_IND_MODE(System.Boolean Simulation, bool ignore_Simulation, System.Boolean FbOverride, bool ignore_FbOverride, System.Boolean Maintenance, bool ignore_Maintenance, System.Boolean OutOfService, bool ignore_OutOfService)
    {
      object[] _values_ = new object[4];
      if (!ignore_Simulation) _values_[0] = Simulation;
      if (!ignore_FbOverride) _values_[1] = FbOverride;
      if (!ignore_Maintenance) _values_[2] = Maintenance;
      if (!ignore_OutOfService) _values_[3] = OutOfService;
      return ((IHMIAccessorOutput)this).FireEvent(8, _values_);
    }

  }
}

namespace HMI.Main.Faceplates.MotorVsBase
{
  partial class fpDefault
  {

    private event EventHandler<HMI.Main.Symbols.MotorVsBase.UPDEventArgs> UPD_Fired;

    private event EventHandler<HMI.Main.Symbols.MotorVsBase.UPD_TIMEEventArgs> UPD_TIME_Fired;

    protected override void OnEndInit()
    {
      if (UPD_Fired != null)
        AttachEventInput(0);
      if (UPD_TIME_Fired != null)
        AttachEventInput(1);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (UPD_Fired != null)
          {
            try
            {
              UPD_Fired(this, new HMI.Main.Symbols.MotorVsBase.UPDEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","UPD_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 1:
          if (UPD_TIME_Fired != null)
          {
            try
            {
              UPD_TIME_Fired(this, new HMI.Main.Symbols.MotorVsBase.UPD_TIMEEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","UPD_TIME_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_OWNER(System.UInt16 Owner)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {Owner});
    }
    public bool FireEvent_OWNER(HMI.Main.Symbols.MotorVsBase.OWNEREventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.Owner.HasValue) _values_[0] = ea.Owner.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_OWNER(System.UInt16 Owner, bool ignore_Owner)
    {
      object[] _values_ = new object[1];
      if (!ignore_Owner) _values_[0] = Owner;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_SPEED_OWNER(System.Boolean EnSpeedOwner, System.Boolean SpeedOwner)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {EnSpeedOwner, SpeedOwner});
    }
    public bool FireEvent_SPEED_OWNER(HMI.Main.Symbols.MotorVsBase.SPEED_OWNEREventArgs ea)
    {
      object[] _values_ = new object[2];
      if (ea.EnSpeedOwner.HasValue) _values_[0] = ea.EnSpeedOwner.Value;
      if (ea.SpeedOwner.HasValue) _values_[1] = ea.SpeedOwner.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_SPEED_OWNER(System.Boolean EnSpeedOwner, bool ignore_EnSpeedOwner, System.Boolean SpeedOwner, bool ignore_SpeedOwner)
    {
      object[] _values_ = new object[2];
      if (!ignore_EnSpeedOwner) _values_[0] = EnSpeedOwner;
      if (!ignore_SpeedOwner) _values_[1] = SpeedOwner;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_CFG(System.Int32 MonTime, System.Int32 TripTime, System.Int32 PassiveTime, System.Boolean ConfResetReq, System.Boolean FailResetReq, System.Int32 ScanTime, System.Byte AlmAckType, System.Boolean EnTrackSp, System.Boolean EnResetSp, System.Boolean DisReverse, System.Boolean SpeedSpRangeSel)
    {
      return ((IHMIAccessorOutput)this).FireEvent(2, new object[] {MonTime, TripTime, PassiveTime, ConfResetReq, FailResetReq, ScanTime, AlmAckType, EnTrackSp, EnResetSp, DisReverse, SpeedSpRangeSel});
    }
    public bool FireEvent_CFG(HMI.Main.Symbols.MotorVsBase.CFGEventArgs ea)
    {
      object[] _values_ = new object[11];
      if (ea.MonTime.HasValue) _values_[0] = ea.MonTime.Value;
      if (ea.TripTime.HasValue) _values_[1] = ea.TripTime.Value;
      if (ea.PassiveTime.HasValue) _values_[2] = ea.PassiveTime.Value;
      if (ea.ConfResetReq.HasValue) _values_[3] = ea.ConfResetReq.Value;
      if (ea.FailResetReq.HasValue) _values_[4] = ea.FailResetReq.Value;
      if (ea.ScanTime.HasValue) _values_[5] = ea.ScanTime.Value;
      if (ea.AlmAckType.HasValue) _values_[6] = ea.AlmAckType.Value;
      if (ea.EnTrackSp.HasValue) _values_[7] = ea.EnTrackSp.Value;
      if (ea.EnResetSp.HasValue) _values_[8] = ea.EnResetSp.Value;
      if (ea.DisReverse.HasValue) _values_[9] = ea.DisReverse.Value;
      if (ea.SpeedSpRangeSel.HasValue) _values_[10] = ea.SpeedSpRangeSel.Value;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_CFG(System.Int32 MonTime, bool ignore_MonTime, System.Int32 TripTime, bool ignore_TripTime, System.Int32 PassiveTime, bool ignore_PassiveTime, System.Boolean ConfResetReq, bool ignore_ConfResetReq, System.Boolean FailResetReq, bool ignore_FailResetReq, System.Int32 ScanTime, bool ignore_ScanTime, System.Byte AlmAckType, bool ignore_AlmAckType, System.Boolean EnTrackSp, bool ignore_EnTrackSp, System.Boolean EnResetSp, bool ignore_EnResetSp, System.Boolean DisReverse, bool ignore_DisReverse, System.Boolean SpeedSpRangeSel, bool ignore_SpeedSpRangeSel)
    {
      object[] _values_ = new object[11];
      if (!ignore_MonTime) _values_[0] = MonTime;
      if (!ignore_TripTime) _values_[1] = TripTime;
      if (!ignore_PassiveTime) _values_[2] = PassiveTime;
      if (!ignore_ConfResetReq) _values_[3] = ConfResetReq;
      if (!ignore_FailResetReq) _values_[4] = FailResetReq;
      if (!ignore_ScanTime) _values_[5] = ScanTime;
      if (!ignore_AlmAckType) _values_[6] = AlmAckType;
      if (!ignore_EnTrackSp) _values_[7] = EnTrackSp;
      if (!ignore_EnResetSp) _values_[8] = EnResetSp;
      if (!ignore_DisReverse) _values_[9] = DisReverse;
      if (!ignore_SpeedSpRangeSel) _values_[10] = SpeedSpRangeSel;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_SPEEDSP_CFG(System.Single SpeedRawMin, System.Single SpeedRawMax, System.Boolean SpeedRawIsAbsolute, System.Single SpeedSpMin, System.Single SpeedSpMax)
    {
      return ((IHMIAccessorOutput)this).FireEvent(3, new object[] {SpeedRawMin, SpeedRawMax, SpeedRawIsAbsolute, SpeedSpMin, SpeedSpMax});
    }
    public bool FireEvent_SPEEDSP_CFG(HMI.Main.Symbols.MotorVsBase.SPEEDSP_CFGEventArgs ea)
    {
      object[] _values_ = new object[5];
      if (ea.SpeedRawMin.HasValue) _values_[0] = ea.SpeedRawMin.Value;
      if (ea.SpeedRawMax.HasValue) _values_[1] = ea.SpeedRawMax.Value;
      if (ea.SpeedRawIsAbsolute.HasValue) _values_[2] = ea.SpeedRawIsAbsolute.Value;
      if (ea.SpeedSpMin.HasValue) _values_[3] = ea.SpeedSpMin.Value;
      if (ea.SpeedSpMax.HasValue) _values_[4] = ea.SpeedSpMax.Value;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_SPEEDSP_CFG(System.Single SpeedRawMin, bool ignore_SpeedRawMin, System.Single SpeedRawMax, bool ignore_SpeedRawMax, System.Boolean SpeedRawIsAbsolute, bool ignore_SpeedRawIsAbsolute, System.Single SpeedSpMin, bool ignore_SpeedSpMin, System.Single SpeedSpMax, bool ignore_SpeedSpMax)
    {
      object[] _values_ = new object[5];
      if (!ignore_SpeedRawMin) _values_[0] = SpeedRawMin;
      if (!ignore_SpeedRawMax) _values_[1] = SpeedRawMax;
      if (!ignore_SpeedRawIsAbsolute) _values_[2] = SpeedRawIsAbsolute;
      if (!ignore_SpeedSpMin) _values_[3] = SpeedSpMin;
      if (!ignore_SpeedSpMax) _values_[4] = SpeedSpMax;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_SPEEDOUT_CFG(System.Single SpeedOutMin, System.Single SpeedOutMax)
    {
      return ((IHMIAccessorOutput)this).FireEvent(4, new object[] {SpeedOutMin, SpeedOutMax});
    }
    public bool FireEvent_SPEEDOUT_CFG(HMI.Main.Symbols.MotorVsBase.SPEEDOUT_CFGEventArgs ea)
    {
      object[] _values_ = new object[2];
      if (ea.SpeedOutMin.HasValue) _values_[0] = ea.SpeedOutMin.Value;
      if (ea.SpeedOutMax.HasValue) _values_[1] = ea.SpeedOutMax.Value;
      return ((IHMIAccessorOutput)this).FireEvent(4, _values_);
    }
    public bool FireEvent_SPEEDOUT_CFG(System.Single SpeedOutMin, bool ignore_SpeedOutMin, System.Single SpeedOutMax, bool ignore_SpeedOutMax)
    {
      object[] _values_ = new object[2];
      if (!ignore_SpeedOutMin) _values_[0] = SpeedOutMin;
      if (!ignore_SpeedOutMax) _values_[1] = SpeedOutMax;
      return ((IHMIAccessorOutput)this).FireEvent(4, _values_);
    }
    public bool FireEvent_SP_CMD(System.Int16 Sp)
    {
      return ((IHMIAccessorOutput)this).FireEvent(5, new object[] {Sp});
    }
    public bool FireEvent_SP_CMD(HMI.Main.Symbols.MotorVsBase.SP_CMDEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.Sp.HasValue) _values_[0] = ea.Sp.Value;
      return ((IHMIAccessorOutput)this).FireEvent(5, _values_);
    }
    public bool FireEvent_SP_CMD(System.Int16 Sp, bool ignore_Sp)
    {
      object[] _values_ = new object[1];
      if (!ignore_Sp) _values_[0] = Sp;
      return ((IHMIAccessorOutput)this).FireEvent(5, _values_);
    }
    public bool FireEvent_SPEEDSP_CMD(System.Single SpeedSp)
    {
      return ((IHMIAccessorOutput)this).FireEvent(6, new object[] {SpeedSp});
    }
    public bool FireEvent_SPEEDSP_CMD(HMI.Main.Symbols.MotorVsBase.SPEEDSP_CMDEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.SpeedSp.HasValue) _values_[0] = ea.SpeedSp.Value;
      return ((IHMIAccessorOutput)this).FireEvent(6, _values_);
    }
    public bool FireEvent_SPEEDSP_CMD(System.Single SpeedSp, bool ignore_SpeedSp)
    {
      object[] _values_ = new object[1];
      if (!ignore_SpeedSp) _values_[0] = SpeedSp;
      return ((IHMIAccessorOutput)this).FireEvent(6, _values_);
    }
    public bool FireEvent_RESET_CMD(System.Boolean Reset)
    {
      return ((IHMIAccessorOutput)this).FireEvent(7, new object[] {Reset});
    }
    public bool FireEvent_RESET_CMD(HMI.Main.Symbols.MotorVsBase.RESET_CMDEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.Reset.HasValue) _values_[0] = ea.Reset.Value;
      return ((IHMIAccessorOutput)this).FireEvent(7, _values_);
    }
    public bool FireEvent_RESET_CMD(System.Boolean Reset, bool ignore_Reset)
    {
      object[] _values_ = new object[1];
      if (!ignore_Reset) _values_[0] = Reset;
      return ((IHMIAccessorOutput)this).FireEvent(7, _values_);
    }
    public bool FireEvent_IND_MODE(System.Boolean Simulation, System.Boolean FbOverride, System.Boolean Maintenance, System.Boolean OutOfService)
    {
      return ((IHMIAccessorOutput)this).FireEvent(8, new object[] {Simulation, FbOverride, Maintenance, OutOfService});
    }
    public bool FireEvent_IND_MODE(HMI.Main.Symbols.MotorVsBase.IND_MODEEventArgs ea)
    {
      object[] _values_ = new object[4];
      if (ea.Simulation.HasValue) _values_[0] = ea.Simulation.Value;
      if (ea.FbOverride.HasValue) _values_[1] = ea.FbOverride.Value;
      if (ea.Maintenance.HasValue) _values_[2] = ea.Maintenance.Value;
      if (ea.OutOfService.HasValue) _values_[3] = ea.OutOfService.Value;
      return ((IHMIAccessorOutput)this).FireEvent(8, _values_);
    }
    public bool FireEvent_IND_MODE(System.Boolean Simulation, bool ignore_Simulation, System.Boolean FbOverride, bool ignore_FbOverride, System.Boolean Maintenance, bool ignore_Maintenance, System.Boolean OutOfService, bool ignore_OutOfService)
    {
      object[] _values_ = new object[4];
      if (!ignore_Simulation) _values_[0] = Simulation;
      if (!ignore_FbOverride) _values_[1] = FbOverride;
      if (!ignore_Maintenance) _values_[2] = Maintenance;
      if (!ignore_OutOfService) _values_[3] = OutOfService;
      return ((IHMIAccessorOutput)this).FireEvent(8, _values_);
    }

  }
}

namespace HMI.Main.Faceplates.MotorVsBase
{
  partial class fpParameter
  {

    private event EventHandler<HMI.Main.Symbols.MotorVsBase.UPDEventArgs> UPD_Fired;

    private event EventHandler<HMI.Main.Symbols.MotorVsBase.UPD_TIMEEventArgs> UPD_TIME_Fired;

    protected override void OnEndInit()
    {
      if (UPD_Fired != null)
        AttachEventInput(0);
      if (UPD_TIME_Fired != null)
        AttachEventInput(1);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (UPD_Fired != null)
          {
            try
            {
              UPD_Fired(this, new HMI.Main.Symbols.MotorVsBase.UPDEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","UPD_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 1:
          if (UPD_TIME_Fired != null)
          {
            try
            {
              UPD_TIME_Fired(this, new HMI.Main.Symbols.MotorVsBase.UPD_TIMEEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","UPD_TIME_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_OWNER(System.UInt16 Owner)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {Owner});
    }
    public bool FireEvent_OWNER(HMI.Main.Symbols.MotorVsBase.OWNEREventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.Owner.HasValue) _values_[0] = ea.Owner.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_OWNER(System.UInt16 Owner, bool ignore_Owner)
    {
      object[] _values_ = new object[1];
      if (!ignore_Owner) _values_[0] = Owner;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_SPEED_OWNER(System.Boolean EnSpeedOwner, System.Boolean SpeedOwner)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {EnSpeedOwner, SpeedOwner});
    }
    public bool FireEvent_SPEED_OWNER(HMI.Main.Symbols.MotorVsBase.SPEED_OWNEREventArgs ea)
    {
      object[] _values_ = new object[2];
      if (ea.EnSpeedOwner.HasValue) _values_[0] = ea.EnSpeedOwner.Value;
      if (ea.SpeedOwner.HasValue) _values_[1] = ea.SpeedOwner.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_SPEED_OWNER(System.Boolean EnSpeedOwner, bool ignore_EnSpeedOwner, System.Boolean SpeedOwner, bool ignore_SpeedOwner)
    {
      object[] _values_ = new object[2];
      if (!ignore_EnSpeedOwner) _values_[0] = EnSpeedOwner;
      if (!ignore_SpeedOwner) _values_[1] = SpeedOwner;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_CFG(System.Int32 MonTime, System.Int32 TripTime, System.Int32 PassiveTime, System.Boolean ConfResetReq, System.Boolean FailResetReq, System.Int32 ScanTime, System.Byte AlmAckType, System.Boolean EnTrackSp, System.Boolean EnResetSp, System.Boolean DisReverse, System.Boolean SpeedSpRangeSel)
    {
      return ((IHMIAccessorOutput)this).FireEvent(2, new object[] {MonTime, TripTime, PassiveTime, ConfResetReq, FailResetReq, ScanTime, AlmAckType, EnTrackSp, EnResetSp, DisReverse, SpeedSpRangeSel});
    }
    public bool FireEvent_CFG(HMI.Main.Symbols.MotorVsBase.CFGEventArgs ea)
    {
      object[] _values_ = new object[11];
      if (ea.MonTime.HasValue) _values_[0] = ea.MonTime.Value;
      if (ea.TripTime.HasValue) _values_[1] = ea.TripTime.Value;
      if (ea.PassiveTime.HasValue) _values_[2] = ea.PassiveTime.Value;
      if (ea.ConfResetReq.HasValue) _values_[3] = ea.ConfResetReq.Value;
      if (ea.FailResetReq.HasValue) _values_[4] = ea.FailResetReq.Value;
      if (ea.ScanTime.HasValue) _values_[5] = ea.ScanTime.Value;
      if (ea.AlmAckType.HasValue) _values_[6] = ea.AlmAckType.Value;
      if (ea.EnTrackSp.HasValue) _values_[7] = ea.EnTrackSp.Value;
      if (ea.EnResetSp.HasValue) _values_[8] = ea.EnResetSp.Value;
      if (ea.DisReverse.HasValue) _values_[9] = ea.DisReverse.Value;
      if (ea.SpeedSpRangeSel.HasValue) _values_[10] = ea.SpeedSpRangeSel.Value;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_CFG(System.Int32 MonTime, bool ignore_MonTime, System.Int32 TripTime, bool ignore_TripTime, System.Int32 PassiveTime, bool ignore_PassiveTime, System.Boolean ConfResetReq, bool ignore_ConfResetReq, System.Boolean FailResetReq, bool ignore_FailResetReq, System.Int32 ScanTime, bool ignore_ScanTime, System.Byte AlmAckType, bool ignore_AlmAckType, System.Boolean EnTrackSp, bool ignore_EnTrackSp, System.Boolean EnResetSp, bool ignore_EnResetSp, System.Boolean DisReverse, bool ignore_DisReverse, System.Boolean SpeedSpRangeSel, bool ignore_SpeedSpRangeSel)
    {
      object[] _values_ = new object[11];
      if (!ignore_MonTime) _values_[0] = MonTime;
      if (!ignore_TripTime) _values_[1] = TripTime;
      if (!ignore_PassiveTime) _values_[2] = PassiveTime;
      if (!ignore_ConfResetReq) _values_[3] = ConfResetReq;
      if (!ignore_FailResetReq) _values_[4] = FailResetReq;
      if (!ignore_ScanTime) _values_[5] = ScanTime;
      if (!ignore_AlmAckType) _values_[6] = AlmAckType;
      if (!ignore_EnTrackSp) _values_[7] = EnTrackSp;
      if (!ignore_EnResetSp) _values_[8] = EnResetSp;
      if (!ignore_DisReverse) _values_[9] = DisReverse;
      if (!ignore_SpeedSpRangeSel) _values_[10] = SpeedSpRangeSel;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_SPEEDSP_CFG(System.Single SpeedRawMin, System.Single SpeedRawMax, System.Boolean SpeedRawIsAbsolute, System.Single SpeedSpMin, System.Single SpeedSpMax)
    {
      return ((IHMIAccessorOutput)this).FireEvent(3, new object[] {SpeedRawMin, SpeedRawMax, SpeedRawIsAbsolute, SpeedSpMin, SpeedSpMax});
    }
    public bool FireEvent_SPEEDSP_CFG(HMI.Main.Symbols.MotorVsBase.SPEEDSP_CFGEventArgs ea)
    {
      object[] _values_ = new object[5];
      if (ea.SpeedRawMin.HasValue) _values_[0] = ea.SpeedRawMin.Value;
      if (ea.SpeedRawMax.HasValue) _values_[1] = ea.SpeedRawMax.Value;
      if (ea.SpeedRawIsAbsolute.HasValue) _values_[2] = ea.SpeedRawIsAbsolute.Value;
      if (ea.SpeedSpMin.HasValue) _values_[3] = ea.SpeedSpMin.Value;
      if (ea.SpeedSpMax.HasValue) _values_[4] = ea.SpeedSpMax.Value;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_SPEEDSP_CFG(System.Single SpeedRawMin, bool ignore_SpeedRawMin, System.Single SpeedRawMax, bool ignore_SpeedRawMax, System.Boolean SpeedRawIsAbsolute, bool ignore_SpeedRawIsAbsolute, System.Single SpeedSpMin, bool ignore_SpeedSpMin, System.Single SpeedSpMax, bool ignore_SpeedSpMax)
    {
      object[] _values_ = new object[5];
      if (!ignore_SpeedRawMin) _values_[0] = SpeedRawMin;
      if (!ignore_SpeedRawMax) _values_[1] = SpeedRawMax;
      if (!ignore_SpeedRawIsAbsolute) _values_[2] = SpeedRawIsAbsolute;
      if (!ignore_SpeedSpMin) _values_[3] = SpeedSpMin;
      if (!ignore_SpeedSpMax) _values_[4] = SpeedSpMax;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_SPEEDOUT_CFG(System.Single SpeedOutMin, System.Single SpeedOutMax)
    {
      return ((IHMIAccessorOutput)this).FireEvent(4, new object[] {SpeedOutMin, SpeedOutMax});
    }
    public bool FireEvent_SPEEDOUT_CFG(HMI.Main.Symbols.MotorVsBase.SPEEDOUT_CFGEventArgs ea)
    {
      object[] _values_ = new object[2];
      if (ea.SpeedOutMin.HasValue) _values_[0] = ea.SpeedOutMin.Value;
      if (ea.SpeedOutMax.HasValue) _values_[1] = ea.SpeedOutMax.Value;
      return ((IHMIAccessorOutput)this).FireEvent(4, _values_);
    }
    public bool FireEvent_SPEEDOUT_CFG(System.Single SpeedOutMin, bool ignore_SpeedOutMin, System.Single SpeedOutMax, bool ignore_SpeedOutMax)
    {
      object[] _values_ = new object[2];
      if (!ignore_SpeedOutMin) _values_[0] = SpeedOutMin;
      if (!ignore_SpeedOutMax) _values_[1] = SpeedOutMax;
      return ((IHMIAccessorOutput)this).FireEvent(4, _values_);
    }
    public bool FireEvent_SP_CMD(System.Int16 Sp)
    {
      return ((IHMIAccessorOutput)this).FireEvent(5, new object[] {Sp});
    }
    public bool FireEvent_SP_CMD(HMI.Main.Symbols.MotorVsBase.SP_CMDEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.Sp.HasValue) _values_[0] = ea.Sp.Value;
      return ((IHMIAccessorOutput)this).FireEvent(5, _values_);
    }
    public bool FireEvent_SP_CMD(System.Int16 Sp, bool ignore_Sp)
    {
      object[] _values_ = new object[1];
      if (!ignore_Sp) _values_[0] = Sp;
      return ((IHMIAccessorOutput)this).FireEvent(5, _values_);
    }
    public bool FireEvent_SPEEDSP_CMD(System.Single SpeedSp)
    {
      return ((IHMIAccessorOutput)this).FireEvent(6, new object[] {SpeedSp});
    }
    public bool FireEvent_SPEEDSP_CMD(HMI.Main.Symbols.MotorVsBase.SPEEDSP_CMDEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.SpeedSp.HasValue) _values_[0] = ea.SpeedSp.Value;
      return ((IHMIAccessorOutput)this).FireEvent(6, _values_);
    }
    public bool FireEvent_SPEEDSP_CMD(System.Single SpeedSp, bool ignore_SpeedSp)
    {
      object[] _values_ = new object[1];
      if (!ignore_SpeedSp) _values_[0] = SpeedSp;
      return ((IHMIAccessorOutput)this).FireEvent(6, _values_);
    }
    public bool FireEvent_RESET_CMD(System.Boolean Reset)
    {
      return ((IHMIAccessorOutput)this).FireEvent(7, new object[] {Reset});
    }
    public bool FireEvent_RESET_CMD(HMI.Main.Symbols.MotorVsBase.RESET_CMDEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.Reset.HasValue) _values_[0] = ea.Reset.Value;
      return ((IHMIAccessorOutput)this).FireEvent(7, _values_);
    }
    public bool FireEvent_RESET_CMD(System.Boolean Reset, bool ignore_Reset)
    {
      object[] _values_ = new object[1];
      if (!ignore_Reset) _values_[0] = Reset;
      return ((IHMIAccessorOutput)this).FireEvent(7, _values_);
    }
    public bool FireEvent_IND_MODE(System.Boolean Simulation, System.Boolean FbOverride, System.Boolean Maintenance, System.Boolean OutOfService)
    {
      return ((IHMIAccessorOutput)this).FireEvent(8, new object[] {Simulation, FbOverride, Maintenance, OutOfService});
    }
    public bool FireEvent_IND_MODE(HMI.Main.Symbols.MotorVsBase.IND_MODEEventArgs ea)
    {
      object[] _values_ = new object[4];
      if (ea.Simulation.HasValue) _values_[0] = ea.Simulation.Value;
      if (ea.FbOverride.HasValue) _values_[1] = ea.FbOverride.Value;
      if (ea.Maintenance.HasValue) _values_[2] = ea.Maintenance.Value;
      if (ea.OutOfService.HasValue) _values_[3] = ea.OutOfService.Value;
      return ((IHMIAccessorOutput)this).FireEvent(8, _values_);
    }
    public bool FireEvent_IND_MODE(System.Boolean Simulation, bool ignore_Simulation, System.Boolean FbOverride, bool ignore_FbOverride, System.Boolean Maintenance, bool ignore_Maintenance, System.Boolean OutOfService, bool ignore_OutOfService)
    {
      object[] _values_ = new object[4];
      if (!ignore_Simulation) _values_[0] = Simulation;
      if (!ignore_FbOverride) _values_[1] = FbOverride;
      if (!ignore_Maintenance) _values_[2] = Maintenance;
      if (!ignore_OutOfService) _values_[3] = OutOfService;
      return ((IHMIAccessorOutput)this).FireEvent(8, _values_);
    }

  }
}

namespace HMI.Main.Symbols.MotorVsBase
{
  partial class sMotor
  {

    private event EventHandler<HMI.Main.Symbols.MotorVsBase.UPDEventArgs> UPD_Fired;

    private event EventHandler<HMI.Main.Symbols.MotorVsBase.UPD_TIMEEventArgs> UPD_TIME_Fired;

    protected override void OnEndInit()
    {
      if (UPD_Fired != null)
        AttachEventInput(0);
      if (UPD_TIME_Fired != null)
        AttachEventInput(1);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (UPD_Fired != null)
          {
            try
            {
              UPD_Fired(this, new HMI.Main.Symbols.MotorVsBase.UPDEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","UPD_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 1:
          if (UPD_TIME_Fired != null)
          {
            try
            {
              UPD_TIME_Fired(this, new HMI.Main.Symbols.MotorVsBase.UPD_TIMEEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","UPD_TIME_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_OWNER(System.UInt16 Owner)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {Owner});
    }
    public bool FireEvent_OWNER(HMI.Main.Symbols.MotorVsBase.OWNEREventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.Owner.HasValue) _values_[0] = ea.Owner.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_OWNER(System.UInt16 Owner, bool ignore_Owner)
    {
      object[] _values_ = new object[1];
      if (!ignore_Owner) _values_[0] = Owner;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_SPEED_OWNER(System.Boolean EnSpeedOwner, System.Boolean SpeedOwner)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {EnSpeedOwner, SpeedOwner});
    }
    public bool FireEvent_SPEED_OWNER(HMI.Main.Symbols.MotorVsBase.SPEED_OWNEREventArgs ea)
    {
      object[] _values_ = new object[2];
      if (ea.EnSpeedOwner.HasValue) _values_[0] = ea.EnSpeedOwner.Value;
      if (ea.SpeedOwner.HasValue) _values_[1] = ea.SpeedOwner.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_SPEED_OWNER(System.Boolean EnSpeedOwner, bool ignore_EnSpeedOwner, System.Boolean SpeedOwner, bool ignore_SpeedOwner)
    {
      object[] _values_ = new object[2];
      if (!ignore_EnSpeedOwner) _values_[0] = EnSpeedOwner;
      if (!ignore_SpeedOwner) _values_[1] = SpeedOwner;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_CFG(System.Int32 MonTime, System.Int32 TripTime, System.Int32 PassiveTime, System.Boolean ConfResetReq, System.Boolean FailResetReq, System.Int32 ScanTime, System.Byte AlmAckType, System.Boolean EnTrackSp, System.Boolean EnResetSp, System.Boolean DisReverse, System.Boolean SpeedSpRangeSel)
    {
      return ((IHMIAccessorOutput)this).FireEvent(2, new object[] {MonTime, TripTime, PassiveTime, ConfResetReq, FailResetReq, ScanTime, AlmAckType, EnTrackSp, EnResetSp, DisReverse, SpeedSpRangeSel});
    }
    public bool FireEvent_CFG(HMI.Main.Symbols.MotorVsBase.CFGEventArgs ea)
    {
      object[] _values_ = new object[11];
      if (ea.MonTime.HasValue) _values_[0] = ea.MonTime.Value;
      if (ea.TripTime.HasValue) _values_[1] = ea.TripTime.Value;
      if (ea.PassiveTime.HasValue) _values_[2] = ea.PassiveTime.Value;
      if (ea.ConfResetReq.HasValue) _values_[3] = ea.ConfResetReq.Value;
      if (ea.FailResetReq.HasValue) _values_[4] = ea.FailResetReq.Value;
      if (ea.ScanTime.HasValue) _values_[5] = ea.ScanTime.Value;
      if (ea.AlmAckType.HasValue) _values_[6] = ea.AlmAckType.Value;
      if (ea.EnTrackSp.HasValue) _values_[7] = ea.EnTrackSp.Value;
      if (ea.EnResetSp.HasValue) _values_[8] = ea.EnResetSp.Value;
      if (ea.DisReverse.HasValue) _values_[9] = ea.DisReverse.Value;
      if (ea.SpeedSpRangeSel.HasValue) _values_[10] = ea.SpeedSpRangeSel.Value;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_CFG(System.Int32 MonTime, bool ignore_MonTime, System.Int32 TripTime, bool ignore_TripTime, System.Int32 PassiveTime, bool ignore_PassiveTime, System.Boolean ConfResetReq, bool ignore_ConfResetReq, System.Boolean FailResetReq, bool ignore_FailResetReq, System.Int32 ScanTime, bool ignore_ScanTime, System.Byte AlmAckType, bool ignore_AlmAckType, System.Boolean EnTrackSp, bool ignore_EnTrackSp, System.Boolean EnResetSp, bool ignore_EnResetSp, System.Boolean DisReverse, bool ignore_DisReverse, System.Boolean SpeedSpRangeSel, bool ignore_SpeedSpRangeSel)
    {
      object[] _values_ = new object[11];
      if (!ignore_MonTime) _values_[0] = MonTime;
      if (!ignore_TripTime) _values_[1] = TripTime;
      if (!ignore_PassiveTime) _values_[2] = PassiveTime;
      if (!ignore_ConfResetReq) _values_[3] = ConfResetReq;
      if (!ignore_FailResetReq) _values_[4] = FailResetReq;
      if (!ignore_ScanTime) _values_[5] = ScanTime;
      if (!ignore_AlmAckType) _values_[6] = AlmAckType;
      if (!ignore_EnTrackSp) _values_[7] = EnTrackSp;
      if (!ignore_EnResetSp) _values_[8] = EnResetSp;
      if (!ignore_DisReverse) _values_[9] = DisReverse;
      if (!ignore_SpeedSpRangeSel) _values_[10] = SpeedSpRangeSel;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_SPEEDSP_CFG(System.Single SpeedRawMin, System.Single SpeedRawMax, System.Boolean SpeedRawIsAbsolute, System.Single SpeedSpMin, System.Single SpeedSpMax)
    {
      return ((IHMIAccessorOutput)this).FireEvent(3, new object[] {SpeedRawMin, SpeedRawMax, SpeedRawIsAbsolute, SpeedSpMin, SpeedSpMax});
    }
    public bool FireEvent_SPEEDSP_CFG(HMI.Main.Symbols.MotorVsBase.SPEEDSP_CFGEventArgs ea)
    {
      object[] _values_ = new object[5];
      if (ea.SpeedRawMin.HasValue) _values_[0] = ea.SpeedRawMin.Value;
      if (ea.SpeedRawMax.HasValue) _values_[1] = ea.SpeedRawMax.Value;
      if (ea.SpeedRawIsAbsolute.HasValue) _values_[2] = ea.SpeedRawIsAbsolute.Value;
      if (ea.SpeedSpMin.HasValue) _values_[3] = ea.SpeedSpMin.Value;
      if (ea.SpeedSpMax.HasValue) _values_[4] = ea.SpeedSpMax.Value;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_SPEEDSP_CFG(System.Single SpeedRawMin, bool ignore_SpeedRawMin, System.Single SpeedRawMax, bool ignore_SpeedRawMax, System.Boolean SpeedRawIsAbsolute, bool ignore_SpeedRawIsAbsolute, System.Single SpeedSpMin, bool ignore_SpeedSpMin, System.Single SpeedSpMax, bool ignore_SpeedSpMax)
    {
      object[] _values_ = new object[5];
      if (!ignore_SpeedRawMin) _values_[0] = SpeedRawMin;
      if (!ignore_SpeedRawMax) _values_[1] = SpeedRawMax;
      if (!ignore_SpeedRawIsAbsolute) _values_[2] = SpeedRawIsAbsolute;
      if (!ignore_SpeedSpMin) _values_[3] = SpeedSpMin;
      if (!ignore_SpeedSpMax) _values_[4] = SpeedSpMax;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_SPEEDOUT_CFG(System.Single SpeedOutMin, System.Single SpeedOutMax)
    {
      return ((IHMIAccessorOutput)this).FireEvent(4, new object[] {SpeedOutMin, SpeedOutMax});
    }
    public bool FireEvent_SPEEDOUT_CFG(HMI.Main.Symbols.MotorVsBase.SPEEDOUT_CFGEventArgs ea)
    {
      object[] _values_ = new object[2];
      if (ea.SpeedOutMin.HasValue) _values_[0] = ea.SpeedOutMin.Value;
      if (ea.SpeedOutMax.HasValue) _values_[1] = ea.SpeedOutMax.Value;
      return ((IHMIAccessorOutput)this).FireEvent(4, _values_);
    }
    public bool FireEvent_SPEEDOUT_CFG(System.Single SpeedOutMin, bool ignore_SpeedOutMin, System.Single SpeedOutMax, bool ignore_SpeedOutMax)
    {
      object[] _values_ = new object[2];
      if (!ignore_SpeedOutMin) _values_[0] = SpeedOutMin;
      if (!ignore_SpeedOutMax) _values_[1] = SpeedOutMax;
      return ((IHMIAccessorOutput)this).FireEvent(4, _values_);
    }
    public bool FireEvent_SP_CMD(System.Int16 Sp)
    {
      return ((IHMIAccessorOutput)this).FireEvent(5, new object[] {Sp});
    }
    public bool FireEvent_SP_CMD(HMI.Main.Symbols.MotorVsBase.SP_CMDEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.Sp.HasValue) _values_[0] = ea.Sp.Value;
      return ((IHMIAccessorOutput)this).FireEvent(5, _values_);
    }
    public bool FireEvent_SP_CMD(System.Int16 Sp, bool ignore_Sp)
    {
      object[] _values_ = new object[1];
      if (!ignore_Sp) _values_[0] = Sp;
      return ((IHMIAccessorOutput)this).FireEvent(5, _values_);
    }
    public bool FireEvent_SPEEDSP_CMD(System.Single SpeedSp)
    {
      return ((IHMIAccessorOutput)this).FireEvent(6, new object[] {SpeedSp});
    }
    public bool FireEvent_SPEEDSP_CMD(HMI.Main.Symbols.MotorVsBase.SPEEDSP_CMDEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.SpeedSp.HasValue) _values_[0] = ea.SpeedSp.Value;
      return ((IHMIAccessorOutput)this).FireEvent(6, _values_);
    }
    public bool FireEvent_SPEEDSP_CMD(System.Single SpeedSp, bool ignore_SpeedSp)
    {
      object[] _values_ = new object[1];
      if (!ignore_SpeedSp) _values_[0] = SpeedSp;
      return ((IHMIAccessorOutput)this).FireEvent(6, _values_);
    }
    public bool FireEvent_RESET_CMD(System.Boolean Reset)
    {
      return ((IHMIAccessorOutput)this).FireEvent(7, new object[] {Reset});
    }
    public bool FireEvent_RESET_CMD(HMI.Main.Symbols.MotorVsBase.RESET_CMDEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.Reset.HasValue) _values_[0] = ea.Reset.Value;
      return ((IHMIAccessorOutput)this).FireEvent(7, _values_);
    }
    public bool FireEvent_RESET_CMD(System.Boolean Reset, bool ignore_Reset)
    {
      object[] _values_ = new object[1];
      if (!ignore_Reset) _values_[0] = Reset;
      return ((IHMIAccessorOutput)this).FireEvent(7, _values_);
    }
    public bool FireEvent_IND_MODE(System.Boolean Simulation, System.Boolean FbOverride, System.Boolean Maintenance, System.Boolean OutOfService)
    {
      return ((IHMIAccessorOutput)this).FireEvent(8, new object[] {Simulation, FbOverride, Maintenance, OutOfService});
    }
    public bool FireEvent_IND_MODE(HMI.Main.Symbols.MotorVsBase.IND_MODEEventArgs ea)
    {
      object[] _values_ = new object[4];
      if (ea.Simulation.HasValue) _values_[0] = ea.Simulation.Value;
      if (ea.FbOverride.HasValue) _values_[1] = ea.FbOverride.Value;
      if (ea.Maintenance.HasValue) _values_[2] = ea.Maintenance.Value;
      if (ea.OutOfService.HasValue) _values_[3] = ea.OutOfService.Value;
      return ((IHMIAccessorOutput)this).FireEvent(8, _values_);
    }
    public bool FireEvent_IND_MODE(System.Boolean Simulation, bool ignore_Simulation, System.Boolean FbOverride, bool ignore_FbOverride, System.Boolean Maintenance, bool ignore_Maintenance, System.Boolean OutOfService, bool ignore_OutOfService)
    {
      object[] _values_ = new object[4];
      if (!ignore_Simulation) _values_[0] = Simulation;
      if (!ignore_FbOverride) _values_[1] = FbOverride;
      if (!ignore_Maintenance) _values_[2] = Maintenance;
      if (!ignore_OutOfService) _values_[3] = OutOfService;
      return ((IHMIAccessorOutput)this).FireEvent(8, _values_);
    }

  }
}

namespace HMI.Main.Symbols.MotorVsBase
{
  partial class sPump
  {

    private event EventHandler<HMI.Main.Symbols.MotorVsBase.UPDEventArgs> UPD_Fired;

    private event EventHandler<HMI.Main.Symbols.MotorVsBase.UPD_TIMEEventArgs> UPD_TIME_Fired;

    protected override void OnEndInit()
    {
      if (UPD_Fired != null)
        AttachEventInput(0);
      if (UPD_TIME_Fired != null)
        AttachEventInput(1);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (UPD_Fired != null)
          {
            try
            {
              UPD_Fired(this, new HMI.Main.Symbols.MotorVsBase.UPDEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","UPD_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 1:
          if (UPD_TIME_Fired != null)
          {
            try
            {
              UPD_TIME_Fired(this, new HMI.Main.Symbols.MotorVsBase.UPD_TIMEEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","UPD_TIME_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_OWNER(System.UInt16 Owner)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {Owner});
    }
    public bool FireEvent_OWNER(HMI.Main.Symbols.MotorVsBase.OWNEREventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.Owner.HasValue) _values_[0] = ea.Owner.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_OWNER(System.UInt16 Owner, bool ignore_Owner)
    {
      object[] _values_ = new object[1];
      if (!ignore_Owner) _values_[0] = Owner;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_SPEED_OWNER(System.Boolean EnSpeedOwner, System.Boolean SpeedOwner)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {EnSpeedOwner, SpeedOwner});
    }
    public bool FireEvent_SPEED_OWNER(HMI.Main.Symbols.MotorVsBase.SPEED_OWNEREventArgs ea)
    {
      object[] _values_ = new object[2];
      if (ea.EnSpeedOwner.HasValue) _values_[0] = ea.EnSpeedOwner.Value;
      if (ea.SpeedOwner.HasValue) _values_[1] = ea.SpeedOwner.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_SPEED_OWNER(System.Boolean EnSpeedOwner, bool ignore_EnSpeedOwner, System.Boolean SpeedOwner, bool ignore_SpeedOwner)
    {
      object[] _values_ = new object[2];
      if (!ignore_EnSpeedOwner) _values_[0] = EnSpeedOwner;
      if (!ignore_SpeedOwner) _values_[1] = SpeedOwner;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_CFG(System.Int32 MonTime, System.Int32 TripTime, System.Int32 PassiveTime, System.Boolean ConfResetReq, System.Boolean FailResetReq, System.Int32 ScanTime, System.Byte AlmAckType, System.Boolean EnTrackSp, System.Boolean EnResetSp, System.Boolean DisReverse, System.Boolean SpeedSpRangeSel)
    {
      return ((IHMIAccessorOutput)this).FireEvent(2, new object[] {MonTime, TripTime, PassiveTime, ConfResetReq, FailResetReq, ScanTime, AlmAckType, EnTrackSp, EnResetSp, DisReverse, SpeedSpRangeSel});
    }
    public bool FireEvent_CFG(HMI.Main.Symbols.MotorVsBase.CFGEventArgs ea)
    {
      object[] _values_ = new object[11];
      if (ea.MonTime.HasValue) _values_[0] = ea.MonTime.Value;
      if (ea.TripTime.HasValue) _values_[1] = ea.TripTime.Value;
      if (ea.PassiveTime.HasValue) _values_[2] = ea.PassiveTime.Value;
      if (ea.ConfResetReq.HasValue) _values_[3] = ea.ConfResetReq.Value;
      if (ea.FailResetReq.HasValue) _values_[4] = ea.FailResetReq.Value;
      if (ea.ScanTime.HasValue) _values_[5] = ea.ScanTime.Value;
      if (ea.AlmAckType.HasValue) _values_[6] = ea.AlmAckType.Value;
      if (ea.EnTrackSp.HasValue) _values_[7] = ea.EnTrackSp.Value;
      if (ea.EnResetSp.HasValue) _values_[8] = ea.EnResetSp.Value;
      if (ea.DisReverse.HasValue) _values_[9] = ea.DisReverse.Value;
      if (ea.SpeedSpRangeSel.HasValue) _values_[10] = ea.SpeedSpRangeSel.Value;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_CFG(System.Int32 MonTime, bool ignore_MonTime, System.Int32 TripTime, bool ignore_TripTime, System.Int32 PassiveTime, bool ignore_PassiveTime, System.Boolean ConfResetReq, bool ignore_ConfResetReq, System.Boolean FailResetReq, bool ignore_FailResetReq, System.Int32 ScanTime, bool ignore_ScanTime, System.Byte AlmAckType, bool ignore_AlmAckType, System.Boolean EnTrackSp, bool ignore_EnTrackSp, System.Boolean EnResetSp, bool ignore_EnResetSp, System.Boolean DisReverse, bool ignore_DisReverse, System.Boolean SpeedSpRangeSel, bool ignore_SpeedSpRangeSel)
    {
      object[] _values_ = new object[11];
      if (!ignore_MonTime) _values_[0] = MonTime;
      if (!ignore_TripTime) _values_[1] = TripTime;
      if (!ignore_PassiveTime) _values_[2] = PassiveTime;
      if (!ignore_ConfResetReq) _values_[3] = ConfResetReq;
      if (!ignore_FailResetReq) _values_[4] = FailResetReq;
      if (!ignore_ScanTime) _values_[5] = ScanTime;
      if (!ignore_AlmAckType) _values_[6] = AlmAckType;
      if (!ignore_EnTrackSp) _values_[7] = EnTrackSp;
      if (!ignore_EnResetSp) _values_[8] = EnResetSp;
      if (!ignore_DisReverse) _values_[9] = DisReverse;
      if (!ignore_SpeedSpRangeSel) _values_[10] = SpeedSpRangeSel;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_SPEEDSP_CFG(System.Single SpeedRawMin, System.Single SpeedRawMax, System.Boolean SpeedRawIsAbsolute, System.Single SpeedSpMin, System.Single SpeedSpMax)
    {
      return ((IHMIAccessorOutput)this).FireEvent(3, new object[] {SpeedRawMin, SpeedRawMax, SpeedRawIsAbsolute, SpeedSpMin, SpeedSpMax});
    }
    public bool FireEvent_SPEEDSP_CFG(HMI.Main.Symbols.MotorVsBase.SPEEDSP_CFGEventArgs ea)
    {
      object[] _values_ = new object[5];
      if (ea.SpeedRawMin.HasValue) _values_[0] = ea.SpeedRawMin.Value;
      if (ea.SpeedRawMax.HasValue) _values_[1] = ea.SpeedRawMax.Value;
      if (ea.SpeedRawIsAbsolute.HasValue) _values_[2] = ea.SpeedRawIsAbsolute.Value;
      if (ea.SpeedSpMin.HasValue) _values_[3] = ea.SpeedSpMin.Value;
      if (ea.SpeedSpMax.HasValue) _values_[4] = ea.SpeedSpMax.Value;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_SPEEDSP_CFG(System.Single SpeedRawMin, bool ignore_SpeedRawMin, System.Single SpeedRawMax, bool ignore_SpeedRawMax, System.Boolean SpeedRawIsAbsolute, bool ignore_SpeedRawIsAbsolute, System.Single SpeedSpMin, bool ignore_SpeedSpMin, System.Single SpeedSpMax, bool ignore_SpeedSpMax)
    {
      object[] _values_ = new object[5];
      if (!ignore_SpeedRawMin) _values_[0] = SpeedRawMin;
      if (!ignore_SpeedRawMax) _values_[1] = SpeedRawMax;
      if (!ignore_SpeedRawIsAbsolute) _values_[2] = SpeedRawIsAbsolute;
      if (!ignore_SpeedSpMin) _values_[3] = SpeedSpMin;
      if (!ignore_SpeedSpMax) _values_[4] = SpeedSpMax;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_SPEEDOUT_CFG(System.Single SpeedOutMin, System.Single SpeedOutMax)
    {
      return ((IHMIAccessorOutput)this).FireEvent(4, new object[] {SpeedOutMin, SpeedOutMax});
    }
    public bool FireEvent_SPEEDOUT_CFG(HMI.Main.Symbols.MotorVsBase.SPEEDOUT_CFGEventArgs ea)
    {
      object[] _values_ = new object[2];
      if (ea.SpeedOutMin.HasValue) _values_[0] = ea.SpeedOutMin.Value;
      if (ea.SpeedOutMax.HasValue) _values_[1] = ea.SpeedOutMax.Value;
      return ((IHMIAccessorOutput)this).FireEvent(4, _values_);
    }
    public bool FireEvent_SPEEDOUT_CFG(System.Single SpeedOutMin, bool ignore_SpeedOutMin, System.Single SpeedOutMax, bool ignore_SpeedOutMax)
    {
      object[] _values_ = new object[2];
      if (!ignore_SpeedOutMin) _values_[0] = SpeedOutMin;
      if (!ignore_SpeedOutMax) _values_[1] = SpeedOutMax;
      return ((IHMIAccessorOutput)this).FireEvent(4, _values_);
    }
    public bool FireEvent_SP_CMD(System.Int16 Sp)
    {
      return ((IHMIAccessorOutput)this).FireEvent(5, new object[] {Sp});
    }
    public bool FireEvent_SP_CMD(HMI.Main.Symbols.MotorVsBase.SP_CMDEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.Sp.HasValue) _values_[0] = ea.Sp.Value;
      return ((IHMIAccessorOutput)this).FireEvent(5, _values_);
    }
    public bool FireEvent_SP_CMD(System.Int16 Sp, bool ignore_Sp)
    {
      object[] _values_ = new object[1];
      if (!ignore_Sp) _values_[0] = Sp;
      return ((IHMIAccessorOutput)this).FireEvent(5, _values_);
    }
    public bool FireEvent_SPEEDSP_CMD(System.Single SpeedSp)
    {
      return ((IHMIAccessorOutput)this).FireEvent(6, new object[] {SpeedSp});
    }
    public bool FireEvent_SPEEDSP_CMD(HMI.Main.Symbols.MotorVsBase.SPEEDSP_CMDEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.SpeedSp.HasValue) _values_[0] = ea.SpeedSp.Value;
      return ((IHMIAccessorOutput)this).FireEvent(6, _values_);
    }
    public bool FireEvent_SPEEDSP_CMD(System.Single SpeedSp, bool ignore_SpeedSp)
    {
      object[] _values_ = new object[1];
      if (!ignore_SpeedSp) _values_[0] = SpeedSp;
      return ((IHMIAccessorOutput)this).FireEvent(6, _values_);
    }
    public bool FireEvent_RESET_CMD(System.Boolean Reset)
    {
      return ((IHMIAccessorOutput)this).FireEvent(7, new object[] {Reset});
    }
    public bool FireEvent_RESET_CMD(HMI.Main.Symbols.MotorVsBase.RESET_CMDEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.Reset.HasValue) _values_[0] = ea.Reset.Value;
      return ((IHMIAccessorOutput)this).FireEvent(7, _values_);
    }
    public bool FireEvent_RESET_CMD(System.Boolean Reset, bool ignore_Reset)
    {
      object[] _values_ = new object[1];
      if (!ignore_Reset) _values_[0] = Reset;
      return ((IHMIAccessorOutput)this).FireEvent(7, _values_);
    }
    public bool FireEvent_IND_MODE(System.Boolean Simulation, System.Boolean FbOverride, System.Boolean Maintenance, System.Boolean OutOfService)
    {
      return ((IHMIAccessorOutput)this).FireEvent(8, new object[] {Simulation, FbOverride, Maintenance, OutOfService});
    }
    public bool FireEvent_IND_MODE(HMI.Main.Symbols.MotorVsBase.IND_MODEEventArgs ea)
    {
      object[] _values_ = new object[4];
      if (ea.Simulation.HasValue) _values_[0] = ea.Simulation.Value;
      if (ea.FbOverride.HasValue) _values_[1] = ea.FbOverride.Value;
      if (ea.Maintenance.HasValue) _values_[2] = ea.Maintenance.Value;
      if (ea.OutOfService.HasValue) _values_[3] = ea.OutOfService.Value;
      return ((IHMIAccessorOutput)this).FireEvent(8, _values_);
    }
    public bool FireEvent_IND_MODE(System.Boolean Simulation, bool ignore_Simulation, System.Boolean FbOverride, bool ignore_FbOverride, System.Boolean Maintenance, bool ignore_Maintenance, System.Boolean OutOfService, bool ignore_OutOfService)
    {
      object[] _values_ = new object[4];
      if (!ignore_Simulation) _values_[0] = Simulation;
      if (!ignore_FbOverride) _values_[1] = FbOverride;
      if (!ignore_Maintenance) _values_[2] = Maintenance;
      if (!ignore_OutOfService) _values_[3] = OutOfService;
      return ((IHMIAccessorOutput)this).FireEvent(8, _values_);
    }

  }
}

namespace HMI.Main.Faceplates.MotorVsBase
{
  partial class fpTrend
  {

    private event EventHandler<HMI.Main.Symbols.MotorVsBase.UPDEventArgs> UPD_Fired;

    private event EventHandler<HMI.Main.Symbols.MotorVsBase.UPD_TIMEEventArgs> UPD_TIME_Fired;

    protected override void OnEndInit()
    {
      if (UPD_Fired != null)
        AttachEventInput(0);
      if (UPD_TIME_Fired != null)
        AttachEventInput(1);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (UPD_Fired != null)
          {
            try
            {
              UPD_Fired(this, new HMI.Main.Symbols.MotorVsBase.UPDEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","UPD_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 1:
          if (UPD_TIME_Fired != null)
          {
            try
            {
              UPD_TIME_Fired(this, new HMI.Main.Symbols.MotorVsBase.UPD_TIMEEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","UPD_TIME_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_OWNER(System.UInt16 Owner)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {Owner});
    }
    public bool FireEvent_OWNER(HMI.Main.Symbols.MotorVsBase.OWNEREventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.Owner.HasValue) _values_[0] = ea.Owner.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_OWNER(System.UInt16 Owner, bool ignore_Owner)
    {
      object[] _values_ = new object[1];
      if (!ignore_Owner) _values_[0] = Owner;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_SPEED_OWNER(System.Boolean EnSpeedOwner, System.Boolean SpeedOwner)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {EnSpeedOwner, SpeedOwner});
    }
    public bool FireEvent_SPEED_OWNER(HMI.Main.Symbols.MotorVsBase.SPEED_OWNEREventArgs ea)
    {
      object[] _values_ = new object[2];
      if (ea.EnSpeedOwner.HasValue) _values_[0] = ea.EnSpeedOwner.Value;
      if (ea.SpeedOwner.HasValue) _values_[1] = ea.SpeedOwner.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_SPEED_OWNER(System.Boolean EnSpeedOwner, bool ignore_EnSpeedOwner, System.Boolean SpeedOwner, bool ignore_SpeedOwner)
    {
      object[] _values_ = new object[2];
      if (!ignore_EnSpeedOwner) _values_[0] = EnSpeedOwner;
      if (!ignore_SpeedOwner) _values_[1] = SpeedOwner;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_CFG(System.Int32 MonTime, System.Int32 TripTime, System.Int32 PassiveTime, System.Boolean ConfResetReq, System.Boolean FailResetReq, System.Int32 ScanTime, System.Byte AlmAckType, System.Boolean EnTrackSp, System.Boolean EnResetSp, System.Boolean DisReverse, System.Boolean SpeedSpRangeSel)
    {
      return ((IHMIAccessorOutput)this).FireEvent(2, new object[] {MonTime, TripTime, PassiveTime, ConfResetReq, FailResetReq, ScanTime, AlmAckType, EnTrackSp, EnResetSp, DisReverse, SpeedSpRangeSel});
    }
    public bool FireEvent_CFG(HMI.Main.Symbols.MotorVsBase.CFGEventArgs ea)
    {
      object[] _values_ = new object[11];
      if (ea.MonTime.HasValue) _values_[0] = ea.MonTime.Value;
      if (ea.TripTime.HasValue) _values_[1] = ea.TripTime.Value;
      if (ea.PassiveTime.HasValue) _values_[2] = ea.PassiveTime.Value;
      if (ea.ConfResetReq.HasValue) _values_[3] = ea.ConfResetReq.Value;
      if (ea.FailResetReq.HasValue) _values_[4] = ea.FailResetReq.Value;
      if (ea.ScanTime.HasValue) _values_[5] = ea.ScanTime.Value;
      if (ea.AlmAckType.HasValue) _values_[6] = ea.AlmAckType.Value;
      if (ea.EnTrackSp.HasValue) _values_[7] = ea.EnTrackSp.Value;
      if (ea.EnResetSp.HasValue) _values_[8] = ea.EnResetSp.Value;
      if (ea.DisReverse.HasValue) _values_[9] = ea.DisReverse.Value;
      if (ea.SpeedSpRangeSel.HasValue) _values_[10] = ea.SpeedSpRangeSel.Value;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_CFG(System.Int32 MonTime, bool ignore_MonTime, System.Int32 TripTime, bool ignore_TripTime, System.Int32 PassiveTime, bool ignore_PassiveTime, System.Boolean ConfResetReq, bool ignore_ConfResetReq, System.Boolean FailResetReq, bool ignore_FailResetReq, System.Int32 ScanTime, bool ignore_ScanTime, System.Byte AlmAckType, bool ignore_AlmAckType, System.Boolean EnTrackSp, bool ignore_EnTrackSp, System.Boolean EnResetSp, bool ignore_EnResetSp, System.Boolean DisReverse, bool ignore_DisReverse, System.Boolean SpeedSpRangeSel, bool ignore_SpeedSpRangeSel)
    {
      object[] _values_ = new object[11];
      if (!ignore_MonTime) _values_[0] = MonTime;
      if (!ignore_TripTime) _values_[1] = TripTime;
      if (!ignore_PassiveTime) _values_[2] = PassiveTime;
      if (!ignore_ConfResetReq) _values_[3] = ConfResetReq;
      if (!ignore_FailResetReq) _values_[4] = FailResetReq;
      if (!ignore_ScanTime) _values_[5] = ScanTime;
      if (!ignore_AlmAckType) _values_[6] = AlmAckType;
      if (!ignore_EnTrackSp) _values_[7] = EnTrackSp;
      if (!ignore_EnResetSp) _values_[8] = EnResetSp;
      if (!ignore_DisReverse) _values_[9] = DisReverse;
      if (!ignore_SpeedSpRangeSel) _values_[10] = SpeedSpRangeSel;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_SPEEDSP_CFG(System.Single SpeedRawMin, System.Single SpeedRawMax, System.Boolean SpeedRawIsAbsolute, System.Single SpeedSpMin, System.Single SpeedSpMax)
    {
      return ((IHMIAccessorOutput)this).FireEvent(3, new object[] {SpeedRawMin, SpeedRawMax, SpeedRawIsAbsolute, SpeedSpMin, SpeedSpMax});
    }
    public bool FireEvent_SPEEDSP_CFG(HMI.Main.Symbols.MotorVsBase.SPEEDSP_CFGEventArgs ea)
    {
      object[] _values_ = new object[5];
      if (ea.SpeedRawMin.HasValue) _values_[0] = ea.SpeedRawMin.Value;
      if (ea.SpeedRawMax.HasValue) _values_[1] = ea.SpeedRawMax.Value;
      if (ea.SpeedRawIsAbsolute.HasValue) _values_[2] = ea.SpeedRawIsAbsolute.Value;
      if (ea.SpeedSpMin.HasValue) _values_[3] = ea.SpeedSpMin.Value;
      if (ea.SpeedSpMax.HasValue) _values_[4] = ea.SpeedSpMax.Value;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_SPEEDSP_CFG(System.Single SpeedRawMin, bool ignore_SpeedRawMin, System.Single SpeedRawMax, bool ignore_SpeedRawMax, System.Boolean SpeedRawIsAbsolute, bool ignore_SpeedRawIsAbsolute, System.Single SpeedSpMin, bool ignore_SpeedSpMin, System.Single SpeedSpMax, bool ignore_SpeedSpMax)
    {
      object[] _values_ = new object[5];
      if (!ignore_SpeedRawMin) _values_[0] = SpeedRawMin;
      if (!ignore_SpeedRawMax) _values_[1] = SpeedRawMax;
      if (!ignore_SpeedRawIsAbsolute) _values_[2] = SpeedRawIsAbsolute;
      if (!ignore_SpeedSpMin) _values_[3] = SpeedSpMin;
      if (!ignore_SpeedSpMax) _values_[4] = SpeedSpMax;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_SPEEDOUT_CFG(System.Single SpeedOutMin, System.Single SpeedOutMax)
    {
      return ((IHMIAccessorOutput)this).FireEvent(4, new object[] {SpeedOutMin, SpeedOutMax});
    }
    public bool FireEvent_SPEEDOUT_CFG(HMI.Main.Symbols.MotorVsBase.SPEEDOUT_CFGEventArgs ea)
    {
      object[] _values_ = new object[2];
      if (ea.SpeedOutMin.HasValue) _values_[0] = ea.SpeedOutMin.Value;
      if (ea.SpeedOutMax.HasValue) _values_[1] = ea.SpeedOutMax.Value;
      return ((IHMIAccessorOutput)this).FireEvent(4, _values_);
    }
    public bool FireEvent_SPEEDOUT_CFG(System.Single SpeedOutMin, bool ignore_SpeedOutMin, System.Single SpeedOutMax, bool ignore_SpeedOutMax)
    {
      object[] _values_ = new object[2];
      if (!ignore_SpeedOutMin) _values_[0] = SpeedOutMin;
      if (!ignore_SpeedOutMax) _values_[1] = SpeedOutMax;
      return ((IHMIAccessorOutput)this).FireEvent(4, _values_);
    }
    public bool FireEvent_SP_CMD(System.Int16 Sp)
    {
      return ((IHMIAccessorOutput)this).FireEvent(5, new object[] {Sp});
    }
    public bool FireEvent_SP_CMD(HMI.Main.Symbols.MotorVsBase.SP_CMDEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.Sp.HasValue) _values_[0] = ea.Sp.Value;
      return ((IHMIAccessorOutput)this).FireEvent(5, _values_);
    }
    public bool FireEvent_SP_CMD(System.Int16 Sp, bool ignore_Sp)
    {
      object[] _values_ = new object[1];
      if (!ignore_Sp) _values_[0] = Sp;
      return ((IHMIAccessorOutput)this).FireEvent(5, _values_);
    }
    public bool FireEvent_SPEEDSP_CMD(System.Single SpeedSp)
    {
      return ((IHMIAccessorOutput)this).FireEvent(6, new object[] {SpeedSp});
    }
    public bool FireEvent_SPEEDSP_CMD(HMI.Main.Symbols.MotorVsBase.SPEEDSP_CMDEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.SpeedSp.HasValue) _values_[0] = ea.SpeedSp.Value;
      return ((IHMIAccessorOutput)this).FireEvent(6, _values_);
    }
    public bool FireEvent_SPEEDSP_CMD(System.Single SpeedSp, bool ignore_SpeedSp)
    {
      object[] _values_ = new object[1];
      if (!ignore_SpeedSp) _values_[0] = SpeedSp;
      return ((IHMIAccessorOutput)this).FireEvent(6, _values_);
    }
    public bool FireEvent_RESET_CMD(System.Boolean Reset)
    {
      return ((IHMIAccessorOutput)this).FireEvent(7, new object[] {Reset});
    }
    public bool FireEvent_RESET_CMD(HMI.Main.Symbols.MotorVsBase.RESET_CMDEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.Reset.HasValue) _values_[0] = ea.Reset.Value;
      return ((IHMIAccessorOutput)this).FireEvent(7, _values_);
    }
    public bool FireEvent_RESET_CMD(System.Boolean Reset, bool ignore_Reset)
    {
      object[] _values_ = new object[1];
      if (!ignore_Reset) _values_[0] = Reset;
      return ((IHMIAccessorOutput)this).FireEvent(7, _values_);
    }
    public bool FireEvent_IND_MODE(System.Boolean Simulation, System.Boolean FbOverride, System.Boolean Maintenance, System.Boolean OutOfService)
    {
      return ((IHMIAccessorOutput)this).FireEvent(8, new object[] {Simulation, FbOverride, Maintenance, OutOfService});
    }
    public bool FireEvent_IND_MODE(HMI.Main.Symbols.MotorVsBase.IND_MODEEventArgs ea)
    {
      object[] _values_ = new object[4];
      if (ea.Simulation.HasValue) _values_[0] = ea.Simulation.Value;
      if (ea.FbOverride.HasValue) _values_[1] = ea.FbOverride.Value;
      if (ea.Maintenance.HasValue) _values_[2] = ea.Maintenance.Value;
      if (ea.OutOfService.HasValue) _values_[3] = ea.OutOfService.Value;
      return ((IHMIAccessorOutput)this).FireEvent(8, _values_);
    }
    public bool FireEvent_IND_MODE(System.Boolean Simulation, bool ignore_Simulation, System.Boolean FbOverride, bool ignore_FbOverride, System.Boolean Maintenance, bool ignore_Maintenance, System.Boolean OutOfService, bool ignore_OutOfService)
    {
      object[] _values_ = new object[4];
      if (!ignore_Simulation) _values_[0] = Simulation;
      if (!ignore_FbOverride) _values_[1] = FbOverride;
      if (!ignore_Maintenance) _values_[2] = Maintenance;
      if (!ignore_OutOfService) _values_[3] = OutOfService;
      return ((IHMIAccessorOutput)this).FireEvent(8, _values_);
    }

  }
}

namespace HMI.Main.Symbols.MotorVsBase
{
  partial class sArrows
  {

    private event EventHandler<HMI.Main.Symbols.MotorVsBase.UPDEventArgs> UPD_Fired;

    private event EventHandler<HMI.Main.Symbols.MotorVsBase.UPD_TIMEEventArgs> UPD_TIME_Fired;

    protected override void OnEndInit()
    {
      if (UPD_Fired != null)
        AttachEventInput(0);
      if (UPD_TIME_Fired != null)
        AttachEventInput(1);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (UPD_Fired != null)
          {
            try
            {
              UPD_Fired(this, new HMI.Main.Symbols.MotorVsBase.UPDEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","UPD_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 1:
          if (UPD_TIME_Fired != null)
          {
            try
            {
              UPD_TIME_Fired(this, new HMI.Main.Symbols.MotorVsBase.UPD_TIMEEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","UPD_TIME_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_OWNER(System.UInt16 Owner)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {Owner});
    }
    public bool FireEvent_OWNER(HMI.Main.Symbols.MotorVsBase.OWNEREventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.Owner.HasValue) _values_[0] = ea.Owner.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_OWNER(System.UInt16 Owner, bool ignore_Owner)
    {
      object[] _values_ = new object[1];
      if (!ignore_Owner) _values_[0] = Owner;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_SPEED_OWNER(System.Boolean EnSpeedOwner, System.Boolean SpeedOwner)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {EnSpeedOwner, SpeedOwner});
    }
    public bool FireEvent_SPEED_OWNER(HMI.Main.Symbols.MotorVsBase.SPEED_OWNEREventArgs ea)
    {
      object[] _values_ = new object[2];
      if (ea.EnSpeedOwner.HasValue) _values_[0] = ea.EnSpeedOwner.Value;
      if (ea.SpeedOwner.HasValue) _values_[1] = ea.SpeedOwner.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_SPEED_OWNER(System.Boolean EnSpeedOwner, bool ignore_EnSpeedOwner, System.Boolean SpeedOwner, bool ignore_SpeedOwner)
    {
      object[] _values_ = new object[2];
      if (!ignore_EnSpeedOwner) _values_[0] = EnSpeedOwner;
      if (!ignore_SpeedOwner) _values_[1] = SpeedOwner;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_CFG(System.Int32 MonTime, System.Int32 TripTime, System.Int32 PassiveTime, System.Boolean ConfResetReq, System.Boolean FailResetReq, System.Int32 ScanTime, System.Byte AlmAckType, System.Boolean EnTrackSp, System.Boolean EnResetSp, System.Boolean DisReverse, System.Boolean SpeedSpRangeSel)
    {
      return ((IHMIAccessorOutput)this).FireEvent(2, new object[] {MonTime, TripTime, PassiveTime, ConfResetReq, FailResetReq, ScanTime, AlmAckType, EnTrackSp, EnResetSp, DisReverse, SpeedSpRangeSel});
    }
    public bool FireEvent_CFG(HMI.Main.Symbols.MotorVsBase.CFGEventArgs ea)
    {
      object[] _values_ = new object[11];
      if (ea.MonTime.HasValue) _values_[0] = ea.MonTime.Value;
      if (ea.TripTime.HasValue) _values_[1] = ea.TripTime.Value;
      if (ea.PassiveTime.HasValue) _values_[2] = ea.PassiveTime.Value;
      if (ea.ConfResetReq.HasValue) _values_[3] = ea.ConfResetReq.Value;
      if (ea.FailResetReq.HasValue) _values_[4] = ea.FailResetReq.Value;
      if (ea.ScanTime.HasValue) _values_[5] = ea.ScanTime.Value;
      if (ea.AlmAckType.HasValue) _values_[6] = ea.AlmAckType.Value;
      if (ea.EnTrackSp.HasValue) _values_[7] = ea.EnTrackSp.Value;
      if (ea.EnResetSp.HasValue) _values_[8] = ea.EnResetSp.Value;
      if (ea.DisReverse.HasValue) _values_[9] = ea.DisReverse.Value;
      if (ea.SpeedSpRangeSel.HasValue) _values_[10] = ea.SpeedSpRangeSel.Value;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_CFG(System.Int32 MonTime, bool ignore_MonTime, System.Int32 TripTime, bool ignore_TripTime, System.Int32 PassiveTime, bool ignore_PassiveTime, System.Boolean ConfResetReq, bool ignore_ConfResetReq, System.Boolean FailResetReq, bool ignore_FailResetReq, System.Int32 ScanTime, bool ignore_ScanTime, System.Byte AlmAckType, bool ignore_AlmAckType, System.Boolean EnTrackSp, bool ignore_EnTrackSp, System.Boolean EnResetSp, bool ignore_EnResetSp, System.Boolean DisReverse, bool ignore_DisReverse, System.Boolean SpeedSpRangeSel, bool ignore_SpeedSpRangeSel)
    {
      object[] _values_ = new object[11];
      if (!ignore_MonTime) _values_[0] = MonTime;
      if (!ignore_TripTime) _values_[1] = TripTime;
      if (!ignore_PassiveTime) _values_[2] = PassiveTime;
      if (!ignore_ConfResetReq) _values_[3] = ConfResetReq;
      if (!ignore_FailResetReq) _values_[4] = FailResetReq;
      if (!ignore_ScanTime) _values_[5] = ScanTime;
      if (!ignore_AlmAckType) _values_[6] = AlmAckType;
      if (!ignore_EnTrackSp) _values_[7] = EnTrackSp;
      if (!ignore_EnResetSp) _values_[8] = EnResetSp;
      if (!ignore_DisReverse) _values_[9] = DisReverse;
      if (!ignore_SpeedSpRangeSel) _values_[10] = SpeedSpRangeSel;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_SPEEDSP_CFG(System.Single SpeedRawMin, System.Single SpeedRawMax, System.Boolean SpeedRawIsAbsolute, System.Single SpeedSpMin, System.Single SpeedSpMax)
    {
      return ((IHMIAccessorOutput)this).FireEvent(3, new object[] {SpeedRawMin, SpeedRawMax, SpeedRawIsAbsolute, SpeedSpMin, SpeedSpMax});
    }
    public bool FireEvent_SPEEDSP_CFG(HMI.Main.Symbols.MotorVsBase.SPEEDSP_CFGEventArgs ea)
    {
      object[] _values_ = new object[5];
      if (ea.SpeedRawMin.HasValue) _values_[0] = ea.SpeedRawMin.Value;
      if (ea.SpeedRawMax.HasValue) _values_[1] = ea.SpeedRawMax.Value;
      if (ea.SpeedRawIsAbsolute.HasValue) _values_[2] = ea.SpeedRawIsAbsolute.Value;
      if (ea.SpeedSpMin.HasValue) _values_[3] = ea.SpeedSpMin.Value;
      if (ea.SpeedSpMax.HasValue) _values_[4] = ea.SpeedSpMax.Value;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_SPEEDSP_CFG(System.Single SpeedRawMin, bool ignore_SpeedRawMin, System.Single SpeedRawMax, bool ignore_SpeedRawMax, System.Boolean SpeedRawIsAbsolute, bool ignore_SpeedRawIsAbsolute, System.Single SpeedSpMin, bool ignore_SpeedSpMin, System.Single SpeedSpMax, bool ignore_SpeedSpMax)
    {
      object[] _values_ = new object[5];
      if (!ignore_SpeedRawMin) _values_[0] = SpeedRawMin;
      if (!ignore_SpeedRawMax) _values_[1] = SpeedRawMax;
      if (!ignore_SpeedRawIsAbsolute) _values_[2] = SpeedRawIsAbsolute;
      if (!ignore_SpeedSpMin) _values_[3] = SpeedSpMin;
      if (!ignore_SpeedSpMax) _values_[4] = SpeedSpMax;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_SPEEDOUT_CFG(System.Single SpeedOutMin, System.Single SpeedOutMax)
    {
      return ((IHMIAccessorOutput)this).FireEvent(4, new object[] {SpeedOutMin, SpeedOutMax});
    }
    public bool FireEvent_SPEEDOUT_CFG(HMI.Main.Symbols.MotorVsBase.SPEEDOUT_CFGEventArgs ea)
    {
      object[] _values_ = new object[2];
      if (ea.SpeedOutMin.HasValue) _values_[0] = ea.SpeedOutMin.Value;
      if (ea.SpeedOutMax.HasValue) _values_[1] = ea.SpeedOutMax.Value;
      return ((IHMIAccessorOutput)this).FireEvent(4, _values_);
    }
    public bool FireEvent_SPEEDOUT_CFG(System.Single SpeedOutMin, bool ignore_SpeedOutMin, System.Single SpeedOutMax, bool ignore_SpeedOutMax)
    {
      object[] _values_ = new object[2];
      if (!ignore_SpeedOutMin) _values_[0] = SpeedOutMin;
      if (!ignore_SpeedOutMax) _values_[1] = SpeedOutMax;
      return ((IHMIAccessorOutput)this).FireEvent(4, _values_);
    }
    public bool FireEvent_SP_CMD(System.Int16 Sp)
    {
      return ((IHMIAccessorOutput)this).FireEvent(5, new object[] {Sp});
    }
    public bool FireEvent_SP_CMD(HMI.Main.Symbols.MotorVsBase.SP_CMDEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.Sp.HasValue) _values_[0] = ea.Sp.Value;
      return ((IHMIAccessorOutput)this).FireEvent(5, _values_);
    }
    public bool FireEvent_SP_CMD(System.Int16 Sp, bool ignore_Sp)
    {
      object[] _values_ = new object[1];
      if (!ignore_Sp) _values_[0] = Sp;
      return ((IHMIAccessorOutput)this).FireEvent(5, _values_);
    }
    public bool FireEvent_SPEEDSP_CMD(System.Single SpeedSp)
    {
      return ((IHMIAccessorOutput)this).FireEvent(6, new object[] {SpeedSp});
    }
    public bool FireEvent_SPEEDSP_CMD(HMI.Main.Symbols.MotorVsBase.SPEEDSP_CMDEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.SpeedSp.HasValue) _values_[0] = ea.SpeedSp.Value;
      return ((IHMIAccessorOutput)this).FireEvent(6, _values_);
    }
    public bool FireEvent_SPEEDSP_CMD(System.Single SpeedSp, bool ignore_SpeedSp)
    {
      object[] _values_ = new object[1];
      if (!ignore_SpeedSp) _values_[0] = SpeedSp;
      return ((IHMIAccessorOutput)this).FireEvent(6, _values_);
    }
    public bool FireEvent_RESET_CMD(System.Boolean Reset)
    {
      return ((IHMIAccessorOutput)this).FireEvent(7, new object[] {Reset});
    }
    public bool FireEvent_RESET_CMD(HMI.Main.Symbols.MotorVsBase.RESET_CMDEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.Reset.HasValue) _values_[0] = ea.Reset.Value;
      return ((IHMIAccessorOutput)this).FireEvent(7, _values_);
    }
    public bool FireEvent_RESET_CMD(System.Boolean Reset, bool ignore_Reset)
    {
      object[] _values_ = new object[1];
      if (!ignore_Reset) _values_[0] = Reset;
      return ((IHMIAccessorOutput)this).FireEvent(7, _values_);
    }
    public bool FireEvent_IND_MODE(System.Boolean Simulation, System.Boolean FbOverride, System.Boolean Maintenance, System.Boolean OutOfService)
    {
      return ((IHMIAccessorOutput)this).FireEvent(8, new object[] {Simulation, FbOverride, Maintenance, OutOfService});
    }
    public bool FireEvent_IND_MODE(HMI.Main.Symbols.MotorVsBase.IND_MODEEventArgs ea)
    {
      object[] _values_ = new object[4];
      if (ea.Simulation.HasValue) _values_[0] = ea.Simulation.Value;
      if (ea.FbOverride.HasValue) _values_[1] = ea.FbOverride.Value;
      if (ea.Maintenance.HasValue) _values_[2] = ea.Maintenance.Value;
      if (ea.OutOfService.HasValue) _values_[3] = ea.OutOfService.Value;
      return ((IHMIAccessorOutput)this).FireEvent(8, _values_);
    }
    public bool FireEvent_IND_MODE(System.Boolean Simulation, bool ignore_Simulation, System.Boolean FbOverride, bool ignore_FbOverride, System.Boolean Maintenance, bool ignore_Maintenance, System.Boolean OutOfService, bool ignore_OutOfService)
    {
      object[] _values_ = new object[4];
      if (!ignore_Simulation) _values_[0] = Simulation;
      if (!ignore_FbOverride) _values_[1] = FbOverride;
      if (!ignore_Maintenance) _values_[2] = Maintenance;
      if (!ignore_OutOfService) _values_[3] = OutOfService;
      return ((IHMIAccessorOutput)this).FireEvent(8, _values_);
    }

  }
}

namespace HMI.Main.Symbols.MotorVsBase
{
  partial class sConveyor
  {

    private event EventHandler<HMI.Main.Symbols.MotorVsBase.UPDEventArgs> UPD_Fired;

    private event EventHandler<HMI.Main.Symbols.MotorVsBase.UPD_TIMEEventArgs> UPD_TIME_Fired;

    protected override void OnEndInit()
    {
      if (UPD_Fired != null)
        AttachEventInput(0);
      if (UPD_TIME_Fired != null)
        AttachEventInput(1);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (UPD_Fired != null)
          {
            try
            {
              UPD_Fired(this, new HMI.Main.Symbols.MotorVsBase.UPDEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","UPD_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 1:
          if (UPD_TIME_Fired != null)
          {
            try
            {
              UPD_TIME_Fired(this, new HMI.Main.Symbols.MotorVsBase.UPD_TIMEEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","UPD_TIME_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_OWNER(System.UInt16 Owner)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {Owner});
    }
    public bool FireEvent_OWNER(HMI.Main.Symbols.MotorVsBase.OWNEREventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.Owner.HasValue) _values_[0] = ea.Owner.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_OWNER(System.UInt16 Owner, bool ignore_Owner)
    {
      object[] _values_ = new object[1];
      if (!ignore_Owner) _values_[0] = Owner;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_SPEED_OWNER(System.Boolean EnSpeedOwner, System.Boolean SpeedOwner)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {EnSpeedOwner, SpeedOwner});
    }
    public bool FireEvent_SPEED_OWNER(HMI.Main.Symbols.MotorVsBase.SPEED_OWNEREventArgs ea)
    {
      object[] _values_ = new object[2];
      if (ea.EnSpeedOwner.HasValue) _values_[0] = ea.EnSpeedOwner.Value;
      if (ea.SpeedOwner.HasValue) _values_[1] = ea.SpeedOwner.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_SPEED_OWNER(System.Boolean EnSpeedOwner, bool ignore_EnSpeedOwner, System.Boolean SpeedOwner, bool ignore_SpeedOwner)
    {
      object[] _values_ = new object[2];
      if (!ignore_EnSpeedOwner) _values_[0] = EnSpeedOwner;
      if (!ignore_SpeedOwner) _values_[1] = SpeedOwner;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_CFG(System.Int32 MonTime, System.Int32 TripTime, System.Int32 PassiveTime, System.Boolean ConfResetReq, System.Boolean FailResetReq, System.Int32 ScanTime, System.Byte AlmAckType, System.Boolean EnTrackSp, System.Boolean EnResetSp, System.Boolean DisReverse, System.Boolean SpeedSpRangeSel)
    {
      return ((IHMIAccessorOutput)this).FireEvent(2, new object[] {MonTime, TripTime, PassiveTime, ConfResetReq, FailResetReq, ScanTime, AlmAckType, EnTrackSp, EnResetSp, DisReverse, SpeedSpRangeSel});
    }
    public bool FireEvent_CFG(HMI.Main.Symbols.MotorVsBase.CFGEventArgs ea)
    {
      object[] _values_ = new object[11];
      if (ea.MonTime.HasValue) _values_[0] = ea.MonTime.Value;
      if (ea.TripTime.HasValue) _values_[1] = ea.TripTime.Value;
      if (ea.PassiveTime.HasValue) _values_[2] = ea.PassiveTime.Value;
      if (ea.ConfResetReq.HasValue) _values_[3] = ea.ConfResetReq.Value;
      if (ea.FailResetReq.HasValue) _values_[4] = ea.FailResetReq.Value;
      if (ea.ScanTime.HasValue) _values_[5] = ea.ScanTime.Value;
      if (ea.AlmAckType.HasValue) _values_[6] = ea.AlmAckType.Value;
      if (ea.EnTrackSp.HasValue) _values_[7] = ea.EnTrackSp.Value;
      if (ea.EnResetSp.HasValue) _values_[8] = ea.EnResetSp.Value;
      if (ea.DisReverse.HasValue) _values_[9] = ea.DisReverse.Value;
      if (ea.SpeedSpRangeSel.HasValue) _values_[10] = ea.SpeedSpRangeSel.Value;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_CFG(System.Int32 MonTime, bool ignore_MonTime, System.Int32 TripTime, bool ignore_TripTime, System.Int32 PassiveTime, bool ignore_PassiveTime, System.Boolean ConfResetReq, bool ignore_ConfResetReq, System.Boolean FailResetReq, bool ignore_FailResetReq, System.Int32 ScanTime, bool ignore_ScanTime, System.Byte AlmAckType, bool ignore_AlmAckType, System.Boolean EnTrackSp, bool ignore_EnTrackSp, System.Boolean EnResetSp, bool ignore_EnResetSp, System.Boolean DisReverse, bool ignore_DisReverse, System.Boolean SpeedSpRangeSel, bool ignore_SpeedSpRangeSel)
    {
      object[] _values_ = new object[11];
      if (!ignore_MonTime) _values_[0] = MonTime;
      if (!ignore_TripTime) _values_[1] = TripTime;
      if (!ignore_PassiveTime) _values_[2] = PassiveTime;
      if (!ignore_ConfResetReq) _values_[3] = ConfResetReq;
      if (!ignore_FailResetReq) _values_[4] = FailResetReq;
      if (!ignore_ScanTime) _values_[5] = ScanTime;
      if (!ignore_AlmAckType) _values_[6] = AlmAckType;
      if (!ignore_EnTrackSp) _values_[7] = EnTrackSp;
      if (!ignore_EnResetSp) _values_[8] = EnResetSp;
      if (!ignore_DisReverse) _values_[9] = DisReverse;
      if (!ignore_SpeedSpRangeSel) _values_[10] = SpeedSpRangeSel;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_SPEEDSP_CFG(System.Single SpeedRawMin, System.Single SpeedRawMax, System.Boolean SpeedRawIsAbsolute, System.Single SpeedSpMin, System.Single SpeedSpMax)
    {
      return ((IHMIAccessorOutput)this).FireEvent(3, new object[] {SpeedRawMin, SpeedRawMax, SpeedRawIsAbsolute, SpeedSpMin, SpeedSpMax});
    }
    public bool FireEvent_SPEEDSP_CFG(HMI.Main.Symbols.MotorVsBase.SPEEDSP_CFGEventArgs ea)
    {
      object[] _values_ = new object[5];
      if (ea.SpeedRawMin.HasValue) _values_[0] = ea.SpeedRawMin.Value;
      if (ea.SpeedRawMax.HasValue) _values_[1] = ea.SpeedRawMax.Value;
      if (ea.SpeedRawIsAbsolute.HasValue) _values_[2] = ea.SpeedRawIsAbsolute.Value;
      if (ea.SpeedSpMin.HasValue) _values_[3] = ea.SpeedSpMin.Value;
      if (ea.SpeedSpMax.HasValue) _values_[4] = ea.SpeedSpMax.Value;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_SPEEDSP_CFG(System.Single SpeedRawMin, bool ignore_SpeedRawMin, System.Single SpeedRawMax, bool ignore_SpeedRawMax, System.Boolean SpeedRawIsAbsolute, bool ignore_SpeedRawIsAbsolute, System.Single SpeedSpMin, bool ignore_SpeedSpMin, System.Single SpeedSpMax, bool ignore_SpeedSpMax)
    {
      object[] _values_ = new object[5];
      if (!ignore_SpeedRawMin) _values_[0] = SpeedRawMin;
      if (!ignore_SpeedRawMax) _values_[1] = SpeedRawMax;
      if (!ignore_SpeedRawIsAbsolute) _values_[2] = SpeedRawIsAbsolute;
      if (!ignore_SpeedSpMin) _values_[3] = SpeedSpMin;
      if (!ignore_SpeedSpMax) _values_[4] = SpeedSpMax;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_SPEEDOUT_CFG(System.Single SpeedOutMin, System.Single SpeedOutMax)
    {
      return ((IHMIAccessorOutput)this).FireEvent(4, new object[] {SpeedOutMin, SpeedOutMax});
    }
    public bool FireEvent_SPEEDOUT_CFG(HMI.Main.Symbols.MotorVsBase.SPEEDOUT_CFGEventArgs ea)
    {
      object[] _values_ = new object[2];
      if (ea.SpeedOutMin.HasValue) _values_[0] = ea.SpeedOutMin.Value;
      if (ea.SpeedOutMax.HasValue) _values_[1] = ea.SpeedOutMax.Value;
      return ((IHMIAccessorOutput)this).FireEvent(4, _values_);
    }
    public bool FireEvent_SPEEDOUT_CFG(System.Single SpeedOutMin, bool ignore_SpeedOutMin, System.Single SpeedOutMax, bool ignore_SpeedOutMax)
    {
      object[] _values_ = new object[2];
      if (!ignore_SpeedOutMin) _values_[0] = SpeedOutMin;
      if (!ignore_SpeedOutMax) _values_[1] = SpeedOutMax;
      return ((IHMIAccessorOutput)this).FireEvent(4, _values_);
    }
    public bool FireEvent_SP_CMD(System.Int16 Sp)
    {
      return ((IHMIAccessorOutput)this).FireEvent(5, new object[] {Sp});
    }
    public bool FireEvent_SP_CMD(HMI.Main.Symbols.MotorVsBase.SP_CMDEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.Sp.HasValue) _values_[0] = ea.Sp.Value;
      return ((IHMIAccessorOutput)this).FireEvent(5, _values_);
    }
    public bool FireEvent_SP_CMD(System.Int16 Sp, bool ignore_Sp)
    {
      object[] _values_ = new object[1];
      if (!ignore_Sp) _values_[0] = Sp;
      return ((IHMIAccessorOutput)this).FireEvent(5, _values_);
    }
    public bool FireEvent_SPEEDSP_CMD(System.Single SpeedSp)
    {
      return ((IHMIAccessorOutput)this).FireEvent(6, new object[] {SpeedSp});
    }
    public bool FireEvent_SPEEDSP_CMD(HMI.Main.Symbols.MotorVsBase.SPEEDSP_CMDEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.SpeedSp.HasValue) _values_[0] = ea.SpeedSp.Value;
      return ((IHMIAccessorOutput)this).FireEvent(6, _values_);
    }
    public bool FireEvent_SPEEDSP_CMD(System.Single SpeedSp, bool ignore_SpeedSp)
    {
      object[] _values_ = new object[1];
      if (!ignore_SpeedSp) _values_[0] = SpeedSp;
      return ((IHMIAccessorOutput)this).FireEvent(6, _values_);
    }
    public bool FireEvent_RESET_CMD(System.Boolean Reset)
    {
      return ((IHMIAccessorOutput)this).FireEvent(7, new object[] {Reset});
    }
    public bool FireEvent_RESET_CMD(HMI.Main.Symbols.MotorVsBase.RESET_CMDEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.Reset.HasValue) _values_[0] = ea.Reset.Value;
      return ((IHMIAccessorOutput)this).FireEvent(7, _values_);
    }
    public bool FireEvent_RESET_CMD(System.Boolean Reset, bool ignore_Reset)
    {
      object[] _values_ = new object[1];
      if (!ignore_Reset) _values_[0] = Reset;
      return ((IHMIAccessorOutput)this).FireEvent(7, _values_);
    }
    public bool FireEvent_IND_MODE(System.Boolean Simulation, System.Boolean FbOverride, System.Boolean Maintenance, System.Boolean OutOfService)
    {
      return ((IHMIAccessorOutput)this).FireEvent(8, new object[] {Simulation, FbOverride, Maintenance, OutOfService});
    }
    public bool FireEvent_IND_MODE(HMI.Main.Symbols.MotorVsBase.IND_MODEEventArgs ea)
    {
      object[] _values_ = new object[4];
      if (ea.Simulation.HasValue) _values_[0] = ea.Simulation.Value;
      if (ea.FbOverride.HasValue) _values_[1] = ea.FbOverride.Value;
      if (ea.Maintenance.HasValue) _values_[2] = ea.Maintenance.Value;
      if (ea.OutOfService.HasValue) _values_[3] = ea.OutOfService.Value;
      return ((IHMIAccessorOutput)this).FireEvent(8, _values_);
    }
    public bool FireEvent_IND_MODE(System.Boolean Simulation, bool ignore_Simulation, System.Boolean FbOverride, bool ignore_FbOverride, System.Boolean Maintenance, bool ignore_Maintenance, System.Boolean OutOfService, bool ignore_OutOfService)
    {
      object[] _values_ = new object[4];
      if (!ignore_Simulation) _values_[0] = Simulation;
      if (!ignore_FbOverride) _values_[1] = FbOverride;
      if (!ignore_Maintenance) _values_[2] = Maintenance;
      if (!ignore_OutOfService) _values_[3] = OutOfService;
      return ((IHMIAccessorOutput)this).FireEvent(8, _values_);
    }

  }
}

namespace HMI.Main.Symbols.MotorVsBase
{
  partial class sInstanceName
  {

    private event EventHandler<HMI.Main.Symbols.MotorVsBase.UPDEventArgs> UPD_Fired;

    private event EventHandler<HMI.Main.Symbols.MotorVsBase.UPD_TIMEEventArgs> UPD_TIME_Fired;

    protected override void OnEndInit()
    {
      if (UPD_Fired != null)
        AttachEventInput(0);
      if (UPD_TIME_Fired != null)
        AttachEventInput(1);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (UPD_Fired != null)
          {
            try
            {
              UPD_Fired(this, new HMI.Main.Symbols.MotorVsBase.UPDEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","UPD_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 1:
          if (UPD_TIME_Fired != null)
          {
            try
            {
              UPD_TIME_Fired(this, new HMI.Main.Symbols.MotorVsBase.UPD_TIMEEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","UPD_TIME_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_OWNER(System.UInt16 Owner)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {Owner});
    }
    public bool FireEvent_OWNER(HMI.Main.Symbols.MotorVsBase.OWNEREventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.Owner.HasValue) _values_[0] = ea.Owner.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_OWNER(System.UInt16 Owner, bool ignore_Owner)
    {
      object[] _values_ = new object[1];
      if (!ignore_Owner) _values_[0] = Owner;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_SPEED_OWNER(System.Boolean EnSpeedOwner, System.Boolean SpeedOwner)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {EnSpeedOwner, SpeedOwner});
    }
    public bool FireEvent_SPEED_OWNER(HMI.Main.Symbols.MotorVsBase.SPEED_OWNEREventArgs ea)
    {
      object[] _values_ = new object[2];
      if (ea.EnSpeedOwner.HasValue) _values_[0] = ea.EnSpeedOwner.Value;
      if (ea.SpeedOwner.HasValue) _values_[1] = ea.SpeedOwner.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_SPEED_OWNER(System.Boolean EnSpeedOwner, bool ignore_EnSpeedOwner, System.Boolean SpeedOwner, bool ignore_SpeedOwner)
    {
      object[] _values_ = new object[2];
      if (!ignore_EnSpeedOwner) _values_[0] = EnSpeedOwner;
      if (!ignore_SpeedOwner) _values_[1] = SpeedOwner;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_CFG(System.Int32 MonTime, System.Int32 TripTime, System.Int32 PassiveTime, System.Boolean ConfResetReq, System.Boolean FailResetReq, System.Int32 ScanTime, System.Byte AlmAckType, System.Boolean EnTrackSp, System.Boolean EnResetSp, System.Boolean DisReverse, System.Boolean SpeedSpRangeSel)
    {
      return ((IHMIAccessorOutput)this).FireEvent(2, new object[] {MonTime, TripTime, PassiveTime, ConfResetReq, FailResetReq, ScanTime, AlmAckType, EnTrackSp, EnResetSp, DisReverse, SpeedSpRangeSel});
    }
    public bool FireEvent_CFG(HMI.Main.Symbols.MotorVsBase.CFGEventArgs ea)
    {
      object[] _values_ = new object[11];
      if (ea.MonTime.HasValue) _values_[0] = ea.MonTime.Value;
      if (ea.TripTime.HasValue) _values_[1] = ea.TripTime.Value;
      if (ea.PassiveTime.HasValue) _values_[2] = ea.PassiveTime.Value;
      if (ea.ConfResetReq.HasValue) _values_[3] = ea.ConfResetReq.Value;
      if (ea.FailResetReq.HasValue) _values_[4] = ea.FailResetReq.Value;
      if (ea.ScanTime.HasValue) _values_[5] = ea.ScanTime.Value;
      if (ea.AlmAckType.HasValue) _values_[6] = ea.AlmAckType.Value;
      if (ea.EnTrackSp.HasValue) _values_[7] = ea.EnTrackSp.Value;
      if (ea.EnResetSp.HasValue) _values_[8] = ea.EnResetSp.Value;
      if (ea.DisReverse.HasValue) _values_[9] = ea.DisReverse.Value;
      if (ea.SpeedSpRangeSel.HasValue) _values_[10] = ea.SpeedSpRangeSel.Value;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_CFG(System.Int32 MonTime, bool ignore_MonTime, System.Int32 TripTime, bool ignore_TripTime, System.Int32 PassiveTime, bool ignore_PassiveTime, System.Boolean ConfResetReq, bool ignore_ConfResetReq, System.Boolean FailResetReq, bool ignore_FailResetReq, System.Int32 ScanTime, bool ignore_ScanTime, System.Byte AlmAckType, bool ignore_AlmAckType, System.Boolean EnTrackSp, bool ignore_EnTrackSp, System.Boolean EnResetSp, bool ignore_EnResetSp, System.Boolean DisReverse, bool ignore_DisReverse, System.Boolean SpeedSpRangeSel, bool ignore_SpeedSpRangeSel)
    {
      object[] _values_ = new object[11];
      if (!ignore_MonTime) _values_[0] = MonTime;
      if (!ignore_TripTime) _values_[1] = TripTime;
      if (!ignore_PassiveTime) _values_[2] = PassiveTime;
      if (!ignore_ConfResetReq) _values_[3] = ConfResetReq;
      if (!ignore_FailResetReq) _values_[4] = FailResetReq;
      if (!ignore_ScanTime) _values_[5] = ScanTime;
      if (!ignore_AlmAckType) _values_[6] = AlmAckType;
      if (!ignore_EnTrackSp) _values_[7] = EnTrackSp;
      if (!ignore_EnResetSp) _values_[8] = EnResetSp;
      if (!ignore_DisReverse) _values_[9] = DisReverse;
      if (!ignore_SpeedSpRangeSel) _values_[10] = SpeedSpRangeSel;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_SPEEDSP_CFG(System.Single SpeedRawMin, System.Single SpeedRawMax, System.Boolean SpeedRawIsAbsolute, System.Single SpeedSpMin, System.Single SpeedSpMax)
    {
      return ((IHMIAccessorOutput)this).FireEvent(3, new object[] {SpeedRawMin, SpeedRawMax, SpeedRawIsAbsolute, SpeedSpMin, SpeedSpMax});
    }
    public bool FireEvent_SPEEDSP_CFG(HMI.Main.Symbols.MotorVsBase.SPEEDSP_CFGEventArgs ea)
    {
      object[] _values_ = new object[5];
      if (ea.SpeedRawMin.HasValue) _values_[0] = ea.SpeedRawMin.Value;
      if (ea.SpeedRawMax.HasValue) _values_[1] = ea.SpeedRawMax.Value;
      if (ea.SpeedRawIsAbsolute.HasValue) _values_[2] = ea.SpeedRawIsAbsolute.Value;
      if (ea.SpeedSpMin.HasValue) _values_[3] = ea.SpeedSpMin.Value;
      if (ea.SpeedSpMax.HasValue) _values_[4] = ea.SpeedSpMax.Value;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_SPEEDSP_CFG(System.Single SpeedRawMin, bool ignore_SpeedRawMin, System.Single SpeedRawMax, bool ignore_SpeedRawMax, System.Boolean SpeedRawIsAbsolute, bool ignore_SpeedRawIsAbsolute, System.Single SpeedSpMin, bool ignore_SpeedSpMin, System.Single SpeedSpMax, bool ignore_SpeedSpMax)
    {
      object[] _values_ = new object[5];
      if (!ignore_SpeedRawMin) _values_[0] = SpeedRawMin;
      if (!ignore_SpeedRawMax) _values_[1] = SpeedRawMax;
      if (!ignore_SpeedRawIsAbsolute) _values_[2] = SpeedRawIsAbsolute;
      if (!ignore_SpeedSpMin) _values_[3] = SpeedSpMin;
      if (!ignore_SpeedSpMax) _values_[4] = SpeedSpMax;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_SPEEDOUT_CFG(System.Single SpeedOutMin, System.Single SpeedOutMax)
    {
      return ((IHMIAccessorOutput)this).FireEvent(4, new object[] {SpeedOutMin, SpeedOutMax});
    }
    public bool FireEvent_SPEEDOUT_CFG(HMI.Main.Symbols.MotorVsBase.SPEEDOUT_CFGEventArgs ea)
    {
      object[] _values_ = new object[2];
      if (ea.SpeedOutMin.HasValue) _values_[0] = ea.SpeedOutMin.Value;
      if (ea.SpeedOutMax.HasValue) _values_[1] = ea.SpeedOutMax.Value;
      return ((IHMIAccessorOutput)this).FireEvent(4, _values_);
    }
    public bool FireEvent_SPEEDOUT_CFG(System.Single SpeedOutMin, bool ignore_SpeedOutMin, System.Single SpeedOutMax, bool ignore_SpeedOutMax)
    {
      object[] _values_ = new object[2];
      if (!ignore_SpeedOutMin) _values_[0] = SpeedOutMin;
      if (!ignore_SpeedOutMax) _values_[1] = SpeedOutMax;
      return ((IHMIAccessorOutput)this).FireEvent(4, _values_);
    }
    public bool FireEvent_SP_CMD(System.Int16 Sp)
    {
      return ((IHMIAccessorOutput)this).FireEvent(5, new object[] {Sp});
    }
    public bool FireEvent_SP_CMD(HMI.Main.Symbols.MotorVsBase.SP_CMDEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.Sp.HasValue) _values_[0] = ea.Sp.Value;
      return ((IHMIAccessorOutput)this).FireEvent(5, _values_);
    }
    public bool FireEvent_SP_CMD(System.Int16 Sp, bool ignore_Sp)
    {
      object[] _values_ = new object[1];
      if (!ignore_Sp) _values_[0] = Sp;
      return ((IHMIAccessorOutput)this).FireEvent(5, _values_);
    }
    public bool FireEvent_SPEEDSP_CMD(System.Single SpeedSp)
    {
      return ((IHMIAccessorOutput)this).FireEvent(6, new object[] {SpeedSp});
    }
    public bool FireEvent_SPEEDSP_CMD(HMI.Main.Symbols.MotorVsBase.SPEEDSP_CMDEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.SpeedSp.HasValue) _values_[0] = ea.SpeedSp.Value;
      return ((IHMIAccessorOutput)this).FireEvent(6, _values_);
    }
    public bool FireEvent_SPEEDSP_CMD(System.Single SpeedSp, bool ignore_SpeedSp)
    {
      object[] _values_ = new object[1];
      if (!ignore_SpeedSp) _values_[0] = SpeedSp;
      return ((IHMIAccessorOutput)this).FireEvent(6, _values_);
    }
    public bool FireEvent_RESET_CMD(System.Boolean Reset)
    {
      return ((IHMIAccessorOutput)this).FireEvent(7, new object[] {Reset});
    }
    public bool FireEvent_RESET_CMD(HMI.Main.Symbols.MotorVsBase.RESET_CMDEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.Reset.HasValue) _values_[0] = ea.Reset.Value;
      return ((IHMIAccessorOutput)this).FireEvent(7, _values_);
    }
    public bool FireEvent_RESET_CMD(System.Boolean Reset, bool ignore_Reset)
    {
      object[] _values_ = new object[1];
      if (!ignore_Reset) _values_[0] = Reset;
      return ((IHMIAccessorOutput)this).FireEvent(7, _values_);
    }
    public bool FireEvent_IND_MODE(System.Boolean Simulation, System.Boolean FbOverride, System.Boolean Maintenance, System.Boolean OutOfService)
    {
      return ((IHMIAccessorOutput)this).FireEvent(8, new object[] {Simulation, FbOverride, Maintenance, OutOfService});
    }
    public bool FireEvent_IND_MODE(HMI.Main.Symbols.MotorVsBase.IND_MODEEventArgs ea)
    {
      object[] _values_ = new object[4];
      if (ea.Simulation.HasValue) _values_[0] = ea.Simulation.Value;
      if (ea.FbOverride.HasValue) _values_[1] = ea.FbOverride.Value;
      if (ea.Maintenance.HasValue) _values_[2] = ea.Maintenance.Value;
      if (ea.OutOfService.HasValue) _values_[3] = ea.OutOfService.Value;
      return ((IHMIAccessorOutput)this).FireEvent(8, _values_);
    }
    public bool FireEvent_IND_MODE(System.Boolean Simulation, bool ignore_Simulation, System.Boolean FbOverride, bool ignore_FbOverride, System.Boolean Maintenance, bool ignore_Maintenance, System.Boolean OutOfService, bool ignore_OutOfService)
    {
      object[] _values_ = new object[4];
      if (!ignore_Simulation) _values_[0] = Simulation;
      if (!ignore_FbOverride) _values_[1] = FbOverride;
      if (!ignore_Maintenance) _values_[2] = Maintenance;
      if (!ignore_OutOfService) _values_[3] = OutOfService;
      return ((IHMIAccessorOutput)this).FireEvent(8, _values_);
    }

  }
}

namespace HMI.Main.Symbols.MotorVsBase
{
  partial class sFan
  {

    private event EventHandler<HMI.Main.Symbols.MotorVsBase.UPDEventArgs> UPD_Fired;

    private event EventHandler<HMI.Main.Symbols.MotorVsBase.UPD_TIMEEventArgs> UPD_TIME_Fired;

    protected override void OnEndInit()
    {
      if (UPD_Fired != null)
        AttachEventInput(0);
      if (UPD_TIME_Fired != null)
        AttachEventInput(1);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (UPD_Fired != null)
          {
            try
            {
              UPD_Fired(this, new HMI.Main.Symbols.MotorVsBase.UPDEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","UPD_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 1:
          if (UPD_TIME_Fired != null)
          {
            try
            {
              UPD_TIME_Fired(this, new HMI.Main.Symbols.MotorVsBase.UPD_TIMEEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","UPD_TIME_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_OWNER(System.UInt16 Owner)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {Owner});
    }
    public bool FireEvent_OWNER(HMI.Main.Symbols.MotorVsBase.OWNEREventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.Owner.HasValue) _values_[0] = ea.Owner.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_OWNER(System.UInt16 Owner, bool ignore_Owner)
    {
      object[] _values_ = new object[1];
      if (!ignore_Owner) _values_[0] = Owner;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_SPEED_OWNER(System.Boolean EnSpeedOwner, System.Boolean SpeedOwner)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {EnSpeedOwner, SpeedOwner});
    }
    public bool FireEvent_SPEED_OWNER(HMI.Main.Symbols.MotorVsBase.SPEED_OWNEREventArgs ea)
    {
      object[] _values_ = new object[2];
      if (ea.EnSpeedOwner.HasValue) _values_[0] = ea.EnSpeedOwner.Value;
      if (ea.SpeedOwner.HasValue) _values_[1] = ea.SpeedOwner.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_SPEED_OWNER(System.Boolean EnSpeedOwner, bool ignore_EnSpeedOwner, System.Boolean SpeedOwner, bool ignore_SpeedOwner)
    {
      object[] _values_ = new object[2];
      if (!ignore_EnSpeedOwner) _values_[0] = EnSpeedOwner;
      if (!ignore_SpeedOwner) _values_[1] = SpeedOwner;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_CFG(System.Int32 MonTime, System.Int32 TripTime, System.Int32 PassiveTime, System.Boolean ConfResetReq, System.Boolean FailResetReq, System.Int32 ScanTime, System.Byte AlmAckType, System.Boolean EnTrackSp, System.Boolean EnResetSp, System.Boolean DisReverse, System.Boolean SpeedSpRangeSel)
    {
      return ((IHMIAccessorOutput)this).FireEvent(2, new object[] {MonTime, TripTime, PassiveTime, ConfResetReq, FailResetReq, ScanTime, AlmAckType, EnTrackSp, EnResetSp, DisReverse, SpeedSpRangeSel});
    }
    public bool FireEvent_CFG(HMI.Main.Symbols.MotorVsBase.CFGEventArgs ea)
    {
      object[] _values_ = new object[11];
      if (ea.MonTime.HasValue) _values_[0] = ea.MonTime.Value;
      if (ea.TripTime.HasValue) _values_[1] = ea.TripTime.Value;
      if (ea.PassiveTime.HasValue) _values_[2] = ea.PassiveTime.Value;
      if (ea.ConfResetReq.HasValue) _values_[3] = ea.ConfResetReq.Value;
      if (ea.FailResetReq.HasValue) _values_[4] = ea.FailResetReq.Value;
      if (ea.ScanTime.HasValue) _values_[5] = ea.ScanTime.Value;
      if (ea.AlmAckType.HasValue) _values_[6] = ea.AlmAckType.Value;
      if (ea.EnTrackSp.HasValue) _values_[7] = ea.EnTrackSp.Value;
      if (ea.EnResetSp.HasValue) _values_[8] = ea.EnResetSp.Value;
      if (ea.DisReverse.HasValue) _values_[9] = ea.DisReverse.Value;
      if (ea.SpeedSpRangeSel.HasValue) _values_[10] = ea.SpeedSpRangeSel.Value;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_CFG(System.Int32 MonTime, bool ignore_MonTime, System.Int32 TripTime, bool ignore_TripTime, System.Int32 PassiveTime, bool ignore_PassiveTime, System.Boolean ConfResetReq, bool ignore_ConfResetReq, System.Boolean FailResetReq, bool ignore_FailResetReq, System.Int32 ScanTime, bool ignore_ScanTime, System.Byte AlmAckType, bool ignore_AlmAckType, System.Boolean EnTrackSp, bool ignore_EnTrackSp, System.Boolean EnResetSp, bool ignore_EnResetSp, System.Boolean DisReverse, bool ignore_DisReverse, System.Boolean SpeedSpRangeSel, bool ignore_SpeedSpRangeSel)
    {
      object[] _values_ = new object[11];
      if (!ignore_MonTime) _values_[0] = MonTime;
      if (!ignore_TripTime) _values_[1] = TripTime;
      if (!ignore_PassiveTime) _values_[2] = PassiveTime;
      if (!ignore_ConfResetReq) _values_[3] = ConfResetReq;
      if (!ignore_FailResetReq) _values_[4] = FailResetReq;
      if (!ignore_ScanTime) _values_[5] = ScanTime;
      if (!ignore_AlmAckType) _values_[6] = AlmAckType;
      if (!ignore_EnTrackSp) _values_[7] = EnTrackSp;
      if (!ignore_EnResetSp) _values_[8] = EnResetSp;
      if (!ignore_DisReverse) _values_[9] = DisReverse;
      if (!ignore_SpeedSpRangeSel) _values_[10] = SpeedSpRangeSel;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_SPEEDSP_CFG(System.Single SpeedRawMin, System.Single SpeedRawMax, System.Boolean SpeedRawIsAbsolute, System.Single SpeedSpMin, System.Single SpeedSpMax)
    {
      return ((IHMIAccessorOutput)this).FireEvent(3, new object[] {SpeedRawMin, SpeedRawMax, SpeedRawIsAbsolute, SpeedSpMin, SpeedSpMax});
    }
    public bool FireEvent_SPEEDSP_CFG(HMI.Main.Symbols.MotorVsBase.SPEEDSP_CFGEventArgs ea)
    {
      object[] _values_ = new object[5];
      if (ea.SpeedRawMin.HasValue) _values_[0] = ea.SpeedRawMin.Value;
      if (ea.SpeedRawMax.HasValue) _values_[1] = ea.SpeedRawMax.Value;
      if (ea.SpeedRawIsAbsolute.HasValue) _values_[2] = ea.SpeedRawIsAbsolute.Value;
      if (ea.SpeedSpMin.HasValue) _values_[3] = ea.SpeedSpMin.Value;
      if (ea.SpeedSpMax.HasValue) _values_[4] = ea.SpeedSpMax.Value;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_SPEEDSP_CFG(System.Single SpeedRawMin, bool ignore_SpeedRawMin, System.Single SpeedRawMax, bool ignore_SpeedRawMax, System.Boolean SpeedRawIsAbsolute, bool ignore_SpeedRawIsAbsolute, System.Single SpeedSpMin, bool ignore_SpeedSpMin, System.Single SpeedSpMax, bool ignore_SpeedSpMax)
    {
      object[] _values_ = new object[5];
      if (!ignore_SpeedRawMin) _values_[0] = SpeedRawMin;
      if (!ignore_SpeedRawMax) _values_[1] = SpeedRawMax;
      if (!ignore_SpeedRawIsAbsolute) _values_[2] = SpeedRawIsAbsolute;
      if (!ignore_SpeedSpMin) _values_[3] = SpeedSpMin;
      if (!ignore_SpeedSpMax) _values_[4] = SpeedSpMax;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_SPEEDOUT_CFG(System.Single SpeedOutMin, System.Single SpeedOutMax)
    {
      return ((IHMIAccessorOutput)this).FireEvent(4, new object[] {SpeedOutMin, SpeedOutMax});
    }
    public bool FireEvent_SPEEDOUT_CFG(HMI.Main.Symbols.MotorVsBase.SPEEDOUT_CFGEventArgs ea)
    {
      object[] _values_ = new object[2];
      if (ea.SpeedOutMin.HasValue) _values_[0] = ea.SpeedOutMin.Value;
      if (ea.SpeedOutMax.HasValue) _values_[1] = ea.SpeedOutMax.Value;
      return ((IHMIAccessorOutput)this).FireEvent(4, _values_);
    }
    public bool FireEvent_SPEEDOUT_CFG(System.Single SpeedOutMin, bool ignore_SpeedOutMin, System.Single SpeedOutMax, bool ignore_SpeedOutMax)
    {
      object[] _values_ = new object[2];
      if (!ignore_SpeedOutMin) _values_[0] = SpeedOutMin;
      if (!ignore_SpeedOutMax) _values_[1] = SpeedOutMax;
      return ((IHMIAccessorOutput)this).FireEvent(4, _values_);
    }
    public bool FireEvent_SP_CMD(System.Int16 Sp)
    {
      return ((IHMIAccessorOutput)this).FireEvent(5, new object[] {Sp});
    }
    public bool FireEvent_SP_CMD(HMI.Main.Symbols.MotorVsBase.SP_CMDEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.Sp.HasValue) _values_[0] = ea.Sp.Value;
      return ((IHMIAccessorOutput)this).FireEvent(5, _values_);
    }
    public bool FireEvent_SP_CMD(System.Int16 Sp, bool ignore_Sp)
    {
      object[] _values_ = new object[1];
      if (!ignore_Sp) _values_[0] = Sp;
      return ((IHMIAccessorOutput)this).FireEvent(5, _values_);
    }
    public bool FireEvent_SPEEDSP_CMD(System.Single SpeedSp)
    {
      return ((IHMIAccessorOutput)this).FireEvent(6, new object[] {SpeedSp});
    }
    public bool FireEvent_SPEEDSP_CMD(HMI.Main.Symbols.MotorVsBase.SPEEDSP_CMDEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.SpeedSp.HasValue) _values_[0] = ea.SpeedSp.Value;
      return ((IHMIAccessorOutput)this).FireEvent(6, _values_);
    }
    public bool FireEvent_SPEEDSP_CMD(System.Single SpeedSp, bool ignore_SpeedSp)
    {
      object[] _values_ = new object[1];
      if (!ignore_SpeedSp) _values_[0] = SpeedSp;
      return ((IHMIAccessorOutput)this).FireEvent(6, _values_);
    }
    public bool FireEvent_RESET_CMD(System.Boolean Reset)
    {
      return ((IHMIAccessorOutput)this).FireEvent(7, new object[] {Reset});
    }
    public bool FireEvent_RESET_CMD(HMI.Main.Symbols.MotorVsBase.RESET_CMDEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.Reset.HasValue) _values_[0] = ea.Reset.Value;
      return ((IHMIAccessorOutput)this).FireEvent(7, _values_);
    }
    public bool FireEvent_RESET_CMD(System.Boolean Reset, bool ignore_Reset)
    {
      object[] _values_ = new object[1];
      if (!ignore_Reset) _values_[0] = Reset;
      return ((IHMIAccessorOutput)this).FireEvent(7, _values_);
    }
    public bool FireEvent_IND_MODE(System.Boolean Simulation, System.Boolean FbOverride, System.Boolean Maintenance, System.Boolean OutOfService)
    {
      return ((IHMIAccessorOutput)this).FireEvent(8, new object[] {Simulation, FbOverride, Maintenance, OutOfService});
    }
    public bool FireEvent_IND_MODE(HMI.Main.Symbols.MotorVsBase.IND_MODEEventArgs ea)
    {
      object[] _values_ = new object[4];
      if (ea.Simulation.HasValue) _values_[0] = ea.Simulation.Value;
      if (ea.FbOverride.HasValue) _values_[1] = ea.FbOverride.Value;
      if (ea.Maintenance.HasValue) _values_[2] = ea.Maintenance.Value;
      if (ea.OutOfService.HasValue) _values_[3] = ea.OutOfService.Value;
      return ((IHMIAccessorOutput)this).FireEvent(8, _values_);
    }
    public bool FireEvent_IND_MODE(System.Boolean Simulation, bool ignore_Simulation, System.Boolean FbOverride, bool ignore_FbOverride, System.Boolean Maintenance, bool ignore_Maintenance, System.Boolean OutOfService, bool ignore_OutOfService)
    {
      object[] _values_ = new object[4];
      if (!ignore_Simulation) _values_[0] = Simulation;
      if (!ignore_FbOverride) _values_[1] = FbOverride;
      if (!ignore_Maintenance) _values_[2] = Maintenance;
      if (!ignore_OutOfService) _values_[3] = OutOfService;
      return ((IHMIAccessorOutput)this).FireEvent(8, _values_);
    }

  }
}
#endregion #MotorVsBase_HMI;

#endregion Definitions;



