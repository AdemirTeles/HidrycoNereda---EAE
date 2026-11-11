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
#region #MotorBase_HMI;

namespace SE.Nereda.Symbols.MotorBaseNer
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

    public bool Get_CurrentOp(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,2, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? CurrentOp
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,2, ref var);
      if (!ret) return null;
      return (System.Int16) var;
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

    public bool Get_NeedReset(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,4, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? NeedReset
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,4, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_FbFail(ref NxtControl.GuiFramework.VTQ<System.Boolean> value)
    {
      if (accessorService == null)
        return false;
      NxtControl.GuiFramework.VTQ<System.Boolean> var = default;
      bool ret = accessorService.GetVTQValue<System.Boolean>(channelId, cookie, eventIndex, true,5, ref var);
      if (ret) value = (NxtControl.GuiFramework.VTQ<System.Boolean>) var;
      return ret;
    }

    public NxtControl.GuiFramework.VTQ<System.Boolean>? FbFail
    { get {
      if (accessorService == null)
        return null;
      NxtControl.GuiFramework.VTQ<System.Boolean> var = default;
      bool ret = accessorService.GetVTQValue<System.Boolean>(channelId, cookie, eventIndex, true,5, ref var);
      if (!ret) return null;
      return (NxtControl.GuiFramework.VTQ<System.Boolean>) var;
    }  }

    public bool Get_DeviceFail(ref NxtControl.GuiFramework.VTQ<System.Boolean> value)
    {
      if (accessorService == null)
        return false;
      NxtControl.GuiFramework.VTQ<System.Boolean> var = default;
      bool ret = accessorService.GetVTQValue<System.Boolean>(channelId, cookie, eventIndex, true,6, ref var);
      if (ret) value = (NxtControl.GuiFramework.VTQ<System.Boolean>) var;
      return ret;
    }

    public NxtControl.GuiFramework.VTQ<System.Boolean>? DeviceFail
    { get {
      if (accessorService == null)
        return null;
      NxtControl.GuiFramework.VTQ<System.Boolean> var = default;
      bool ret = accessorService.GetVTQValue<System.Boolean>(channelId, cookie, eventIndex, true,6, ref var);
      if (!ret) return null;
      return (NxtControl.GuiFramework.VTQ<System.Boolean>) var;
    }  }

    public bool Get_IlckCond(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,7, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? IlckCond
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,7, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_PermStop(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,8, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? PermStop
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,8, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_PermRun(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,9, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? PermRun
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,9, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_Fail(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,10, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? Fail
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,10, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_CurrentOwner(ref System.UInt16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,11, ref var);
      if (ret) value = (System.UInt16) var;
      return ret;
    }

    public System.UInt16? CurrentOwner
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,11, ref var);
      if (!ret) return null;
      return (System.UInt16) var;
    }  }

    public bool Get_StdOwnerConnected(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,12, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? StdOwnerConnected
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,12, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_ExternalControlled(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,13, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? ExternalControlled
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,13, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }


  }

}

namespace SE.Nereda.Symbols.MotorBaseNer
{

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

}

namespace SE.Nereda.Symbols.MotorBaseNer
{
  partial class sDefault
  {

    private event EventHandler<SE.Nereda.Symbols.MotorBaseNer.UPDEventArgs> UPD_Fired;

    protected override void OnEndInit()
    {
      if (UPD_Fired != null)
        AttachEventInput(0);

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
              UPD_Fired(this, new SE.Nereda.Symbols.MotorBaseNer.UPDEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","UPD_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_CFG(System.Int32 MonTime, System.Int32 TripTime, System.Boolean ConfResetReq, System.Boolean FailResetReq, System.Int32 ScanTime, System.Byte AlmAckType, System.Boolean EnTrackSp, System.Boolean EnResetSp)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {MonTime, TripTime, ConfResetReq, FailResetReq, ScanTime, AlmAckType, EnTrackSp, EnResetSp});
    }
    public bool FireEvent_CFG(SE.Nereda.Symbols.MotorBaseNer.CFGEventArgs ea)
    {
      object[] _values_ = new object[8];
      if (ea.MonTime.HasValue) _values_[0] = ea.MonTime.Value;
      if (ea.TripTime.HasValue) _values_[1] = ea.TripTime.Value;
      if (ea.ConfResetReq.HasValue) _values_[2] = ea.ConfResetReq.Value;
      if (ea.FailResetReq.HasValue) _values_[3] = ea.FailResetReq.Value;
      if (ea.ScanTime.HasValue) _values_[4] = ea.ScanTime.Value;
      if (ea.AlmAckType.HasValue) _values_[5] = ea.AlmAckType.Value;
      if (ea.EnTrackSp.HasValue) _values_[6] = ea.EnTrackSp.Value;
      if (ea.EnResetSp.HasValue) _values_[7] = ea.EnResetSp.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_CFG(System.Int32 MonTime, bool ignore_MonTime, System.Int32 TripTime, bool ignore_TripTime, System.Boolean ConfResetReq, bool ignore_ConfResetReq, System.Boolean FailResetReq, bool ignore_FailResetReq, System.Int32 ScanTime, bool ignore_ScanTime, System.Byte AlmAckType, bool ignore_AlmAckType, System.Boolean EnTrackSp, bool ignore_EnTrackSp, System.Boolean EnResetSp, bool ignore_EnResetSp)
    {
      object[] _values_ = new object[8];
      if (!ignore_MonTime) _values_[0] = MonTime;
      if (!ignore_TripTime) _values_[1] = TripTime;
      if (!ignore_ConfResetReq) _values_[2] = ConfResetReq;
      if (!ignore_FailResetReq) _values_[3] = FailResetReq;
      if (!ignore_ScanTime) _values_[4] = ScanTime;
      if (!ignore_AlmAckType) _values_[5] = AlmAckType;
      if (!ignore_EnTrackSp) _values_[6] = EnTrackSp;
      if (!ignore_EnResetSp) _values_[7] = EnResetSp;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_SP_CMD(System.Int16 Sp)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {Sp});
    }
    public bool FireEvent_SP_CMD(SE.Nereda.Symbols.MotorBaseNer.SP_CMDEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.Sp.HasValue) _values_[0] = ea.Sp.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_SP_CMD(System.Int16 Sp, bool ignore_Sp)
    {
      object[] _values_ = new object[1];
      if (!ignore_Sp) _values_[0] = Sp;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_RESET_CMD(System.Boolean Reset)
    {
      return ((IHMIAccessorOutput)this).FireEvent(2, new object[] {Reset});
    }
    public bool FireEvent_RESET_CMD(SE.Nereda.Symbols.MotorBaseNer.RESET_CMDEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.Reset.HasValue) _values_[0] = ea.Reset.Value;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_RESET_CMD(System.Boolean Reset, bool ignore_Reset)
    {
      object[] _values_ = new object[1];
      if (!ignore_Reset) _values_[0] = Reset;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_IND_MODE(System.Boolean Simulation, System.Boolean FbOverride, System.Boolean Maintenance, System.Boolean OutOfService)
    {
      return ((IHMIAccessorOutput)this).FireEvent(3, new object[] {Simulation, FbOverride, Maintenance, OutOfService});
    }
    public bool FireEvent_IND_MODE(SE.Nereda.Symbols.MotorBaseNer.IND_MODEEventArgs ea)
    {
      object[] _values_ = new object[4];
      if (ea.Simulation.HasValue) _values_[0] = ea.Simulation.Value;
      if (ea.FbOverride.HasValue) _values_[1] = ea.FbOverride.Value;
      if (ea.Maintenance.HasValue) _values_[2] = ea.Maintenance.Value;
      if (ea.OutOfService.HasValue) _values_[3] = ea.OutOfService.Value;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_IND_MODE(System.Boolean Simulation, bool ignore_Simulation, System.Boolean FbOverride, bool ignore_FbOverride, System.Boolean Maintenance, bool ignore_Maintenance, System.Boolean OutOfService, bool ignore_OutOfService)
    {
      object[] _values_ = new object[4];
      if (!ignore_Simulation) _values_[0] = Simulation;
      if (!ignore_FbOverride) _values_[1] = FbOverride;
      if (!ignore_Maintenance) _values_[2] = Maintenance;
      if (!ignore_OutOfService) _values_[3] = OutOfService;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_OWNER(System.UInt16 Owner)
    {
      return ((IHMIAccessorOutput)this).FireEvent(4, new object[] {Owner});
    }
    public bool FireEvent_OWNER(SE.Nereda.Symbols.MotorBaseNer.OWNEREventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.Owner.HasValue) _values_[0] = ea.Owner.Value;
      return ((IHMIAccessorOutput)this).FireEvent(4, _values_);
    }
    public bool FireEvent_OWNER(System.UInt16 Owner, bool ignore_Owner)
    {
      object[] _values_ = new object[1];
      if (!ignore_Owner) _values_[0] = Owner;
      return ((IHMIAccessorOutput)this).FireEvent(4, _values_);
    }

  }
}

namespace SE.Nereda.Faceplates.MotorBaseNer
{
  partial class fpDefault
  {

    private event EventHandler<SE.Nereda.Symbols.MotorBaseNer.UPDEventArgs> UPD_Fired;

    protected override void OnEndInit()
    {
      if (UPD_Fired != null)
        AttachEventInput(0);

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
              UPD_Fired(this, new SE.Nereda.Symbols.MotorBaseNer.UPDEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","UPD_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_CFG(System.Int32 MonTime, System.Int32 TripTime, System.Boolean ConfResetReq, System.Boolean FailResetReq, System.Int32 ScanTime, System.Byte AlmAckType, System.Boolean EnTrackSp, System.Boolean EnResetSp)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {MonTime, TripTime, ConfResetReq, FailResetReq, ScanTime, AlmAckType, EnTrackSp, EnResetSp});
    }
    public bool FireEvent_CFG(SE.Nereda.Symbols.MotorBaseNer.CFGEventArgs ea)
    {
      object[] _values_ = new object[8];
      if (ea.MonTime.HasValue) _values_[0] = ea.MonTime.Value;
      if (ea.TripTime.HasValue) _values_[1] = ea.TripTime.Value;
      if (ea.ConfResetReq.HasValue) _values_[2] = ea.ConfResetReq.Value;
      if (ea.FailResetReq.HasValue) _values_[3] = ea.FailResetReq.Value;
      if (ea.ScanTime.HasValue) _values_[4] = ea.ScanTime.Value;
      if (ea.AlmAckType.HasValue) _values_[5] = ea.AlmAckType.Value;
      if (ea.EnTrackSp.HasValue) _values_[6] = ea.EnTrackSp.Value;
      if (ea.EnResetSp.HasValue) _values_[7] = ea.EnResetSp.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_CFG(System.Int32 MonTime, bool ignore_MonTime, System.Int32 TripTime, bool ignore_TripTime, System.Boolean ConfResetReq, bool ignore_ConfResetReq, System.Boolean FailResetReq, bool ignore_FailResetReq, System.Int32 ScanTime, bool ignore_ScanTime, System.Byte AlmAckType, bool ignore_AlmAckType, System.Boolean EnTrackSp, bool ignore_EnTrackSp, System.Boolean EnResetSp, bool ignore_EnResetSp)
    {
      object[] _values_ = new object[8];
      if (!ignore_MonTime) _values_[0] = MonTime;
      if (!ignore_TripTime) _values_[1] = TripTime;
      if (!ignore_ConfResetReq) _values_[2] = ConfResetReq;
      if (!ignore_FailResetReq) _values_[3] = FailResetReq;
      if (!ignore_ScanTime) _values_[4] = ScanTime;
      if (!ignore_AlmAckType) _values_[5] = AlmAckType;
      if (!ignore_EnTrackSp) _values_[6] = EnTrackSp;
      if (!ignore_EnResetSp) _values_[7] = EnResetSp;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_SP_CMD(System.Int16 Sp)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {Sp});
    }
    public bool FireEvent_SP_CMD(SE.Nereda.Symbols.MotorBaseNer.SP_CMDEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.Sp.HasValue) _values_[0] = ea.Sp.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_SP_CMD(System.Int16 Sp, bool ignore_Sp)
    {
      object[] _values_ = new object[1];
      if (!ignore_Sp) _values_[0] = Sp;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_RESET_CMD(System.Boolean Reset)
    {
      return ((IHMIAccessorOutput)this).FireEvent(2, new object[] {Reset});
    }
    public bool FireEvent_RESET_CMD(SE.Nereda.Symbols.MotorBaseNer.RESET_CMDEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.Reset.HasValue) _values_[0] = ea.Reset.Value;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_RESET_CMD(System.Boolean Reset, bool ignore_Reset)
    {
      object[] _values_ = new object[1];
      if (!ignore_Reset) _values_[0] = Reset;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_IND_MODE(System.Boolean Simulation, System.Boolean FbOverride, System.Boolean Maintenance, System.Boolean OutOfService)
    {
      return ((IHMIAccessorOutput)this).FireEvent(3, new object[] {Simulation, FbOverride, Maintenance, OutOfService});
    }
    public bool FireEvent_IND_MODE(SE.Nereda.Symbols.MotorBaseNer.IND_MODEEventArgs ea)
    {
      object[] _values_ = new object[4];
      if (ea.Simulation.HasValue) _values_[0] = ea.Simulation.Value;
      if (ea.FbOverride.HasValue) _values_[1] = ea.FbOverride.Value;
      if (ea.Maintenance.HasValue) _values_[2] = ea.Maintenance.Value;
      if (ea.OutOfService.HasValue) _values_[3] = ea.OutOfService.Value;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_IND_MODE(System.Boolean Simulation, bool ignore_Simulation, System.Boolean FbOverride, bool ignore_FbOverride, System.Boolean Maintenance, bool ignore_Maintenance, System.Boolean OutOfService, bool ignore_OutOfService)
    {
      object[] _values_ = new object[4];
      if (!ignore_Simulation) _values_[0] = Simulation;
      if (!ignore_FbOverride) _values_[1] = FbOverride;
      if (!ignore_Maintenance) _values_[2] = Maintenance;
      if (!ignore_OutOfService) _values_[3] = OutOfService;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_OWNER(System.UInt16 Owner)
    {
      return ((IHMIAccessorOutput)this).FireEvent(4, new object[] {Owner});
    }
    public bool FireEvent_OWNER(SE.Nereda.Symbols.MotorBaseNer.OWNEREventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.Owner.HasValue) _values_[0] = ea.Owner.Value;
      return ((IHMIAccessorOutput)this).FireEvent(4, _values_);
    }
    public bool FireEvent_OWNER(System.UInt16 Owner, bool ignore_Owner)
    {
      object[] _values_ = new object[1];
      if (!ignore_Owner) _values_[0] = Owner;
      return ((IHMIAccessorOutput)this).FireEvent(4, _values_);
    }

  }
}

namespace SE.Nereda.Faceplates.MotorBaseNer
{
  partial class fpParameter
  {

    private event EventHandler<SE.Nereda.Symbols.MotorBaseNer.UPDEventArgs> UPD_Fired;

    protected override void OnEndInit()
    {
      if (UPD_Fired != null)
        AttachEventInput(0);

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
              UPD_Fired(this, new SE.Nereda.Symbols.MotorBaseNer.UPDEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","UPD_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_CFG(System.Int32 MonTime, System.Int32 TripTime, System.Boolean ConfResetReq, System.Boolean FailResetReq, System.Int32 ScanTime, System.Byte AlmAckType, System.Boolean EnTrackSp, System.Boolean EnResetSp)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {MonTime, TripTime, ConfResetReq, FailResetReq, ScanTime, AlmAckType, EnTrackSp, EnResetSp});
    }
    public bool FireEvent_CFG(SE.Nereda.Symbols.MotorBaseNer.CFGEventArgs ea)
    {
      object[] _values_ = new object[8];
      if (ea.MonTime.HasValue) _values_[0] = ea.MonTime.Value;
      if (ea.TripTime.HasValue) _values_[1] = ea.TripTime.Value;
      if (ea.ConfResetReq.HasValue) _values_[2] = ea.ConfResetReq.Value;
      if (ea.FailResetReq.HasValue) _values_[3] = ea.FailResetReq.Value;
      if (ea.ScanTime.HasValue) _values_[4] = ea.ScanTime.Value;
      if (ea.AlmAckType.HasValue) _values_[5] = ea.AlmAckType.Value;
      if (ea.EnTrackSp.HasValue) _values_[6] = ea.EnTrackSp.Value;
      if (ea.EnResetSp.HasValue) _values_[7] = ea.EnResetSp.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_CFG(System.Int32 MonTime, bool ignore_MonTime, System.Int32 TripTime, bool ignore_TripTime, System.Boolean ConfResetReq, bool ignore_ConfResetReq, System.Boolean FailResetReq, bool ignore_FailResetReq, System.Int32 ScanTime, bool ignore_ScanTime, System.Byte AlmAckType, bool ignore_AlmAckType, System.Boolean EnTrackSp, bool ignore_EnTrackSp, System.Boolean EnResetSp, bool ignore_EnResetSp)
    {
      object[] _values_ = new object[8];
      if (!ignore_MonTime) _values_[0] = MonTime;
      if (!ignore_TripTime) _values_[1] = TripTime;
      if (!ignore_ConfResetReq) _values_[2] = ConfResetReq;
      if (!ignore_FailResetReq) _values_[3] = FailResetReq;
      if (!ignore_ScanTime) _values_[4] = ScanTime;
      if (!ignore_AlmAckType) _values_[5] = AlmAckType;
      if (!ignore_EnTrackSp) _values_[6] = EnTrackSp;
      if (!ignore_EnResetSp) _values_[7] = EnResetSp;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_SP_CMD(System.Int16 Sp)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {Sp});
    }
    public bool FireEvent_SP_CMD(SE.Nereda.Symbols.MotorBaseNer.SP_CMDEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.Sp.HasValue) _values_[0] = ea.Sp.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_SP_CMD(System.Int16 Sp, bool ignore_Sp)
    {
      object[] _values_ = new object[1];
      if (!ignore_Sp) _values_[0] = Sp;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_RESET_CMD(System.Boolean Reset)
    {
      return ((IHMIAccessorOutput)this).FireEvent(2, new object[] {Reset});
    }
    public bool FireEvent_RESET_CMD(SE.Nereda.Symbols.MotorBaseNer.RESET_CMDEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.Reset.HasValue) _values_[0] = ea.Reset.Value;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_RESET_CMD(System.Boolean Reset, bool ignore_Reset)
    {
      object[] _values_ = new object[1];
      if (!ignore_Reset) _values_[0] = Reset;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_IND_MODE(System.Boolean Simulation, System.Boolean FbOverride, System.Boolean Maintenance, System.Boolean OutOfService)
    {
      return ((IHMIAccessorOutput)this).FireEvent(3, new object[] {Simulation, FbOverride, Maintenance, OutOfService});
    }
    public bool FireEvent_IND_MODE(SE.Nereda.Symbols.MotorBaseNer.IND_MODEEventArgs ea)
    {
      object[] _values_ = new object[4];
      if (ea.Simulation.HasValue) _values_[0] = ea.Simulation.Value;
      if (ea.FbOverride.HasValue) _values_[1] = ea.FbOverride.Value;
      if (ea.Maintenance.HasValue) _values_[2] = ea.Maintenance.Value;
      if (ea.OutOfService.HasValue) _values_[3] = ea.OutOfService.Value;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_IND_MODE(System.Boolean Simulation, bool ignore_Simulation, System.Boolean FbOverride, bool ignore_FbOverride, System.Boolean Maintenance, bool ignore_Maintenance, System.Boolean OutOfService, bool ignore_OutOfService)
    {
      object[] _values_ = new object[4];
      if (!ignore_Simulation) _values_[0] = Simulation;
      if (!ignore_FbOverride) _values_[1] = FbOverride;
      if (!ignore_Maintenance) _values_[2] = Maintenance;
      if (!ignore_OutOfService) _values_[3] = OutOfService;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_OWNER(System.UInt16 Owner)
    {
      return ((IHMIAccessorOutput)this).FireEvent(4, new object[] {Owner});
    }
    public bool FireEvent_OWNER(SE.Nereda.Symbols.MotorBaseNer.OWNEREventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.Owner.HasValue) _values_[0] = ea.Owner.Value;
      return ((IHMIAccessorOutput)this).FireEvent(4, _values_);
    }
    public bool FireEvent_OWNER(System.UInt16 Owner, bool ignore_Owner)
    {
      object[] _values_ = new object[1];
      if (!ignore_Owner) _values_[0] = Owner;
      return ((IHMIAccessorOutput)this).FireEvent(4, _values_);
    }

  }
}

namespace SE.Nereda.Symbols.MotorBaseNer
{
  partial class sMotor
  {

    private event EventHandler<SE.Nereda.Symbols.MotorBaseNer.UPDEventArgs> UPD_Fired;

    protected override void OnEndInit()
    {
      if (UPD_Fired != null)
        AttachEventInput(0);

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
              UPD_Fired(this, new SE.Nereda.Symbols.MotorBaseNer.UPDEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","UPD_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_CFG(System.Int32 MonTime, System.Int32 TripTime, System.Boolean ConfResetReq, System.Boolean FailResetReq, System.Int32 ScanTime, System.Byte AlmAckType, System.Boolean EnTrackSp, System.Boolean EnResetSp)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {MonTime, TripTime, ConfResetReq, FailResetReq, ScanTime, AlmAckType, EnTrackSp, EnResetSp});
    }
    public bool FireEvent_CFG(SE.Nereda.Symbols.MotorBaseNer.CFGEventArgs ea)
    {
      object[] _values_ = new object[8];
      if (ea.MonTime.HasValue) _values_[0] = ea.MonTime.Value;
      if (ea.TripTime.HasValue) _values_[1] = ea.TripTime.Value;
      if (ea.ConfResetReq.HasValue) _values_[2] = ea.ConfResetReq.Value;
      if (ea.FailResetReq.HasValue) _values_[3] = ea.FailResetReq.Value;
      if (ea.ScanTime.HasValue) _values_[4] = ea.ScanTime.Value;
      if (ea.AlmAckType.HasValue) _values_[5] = ea.AlmAckType.Value;
      if (ea.EnTrackSp.HasValue) _values_[6] = ea.EnTrackSp.Value;
      if (ea.EnResetSp.HasValue) _values_[7] = ea.EnResetSp.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_CFG(System.Int32 MonTime, bool ignore_MonTime, System.Int32 TripTime, bool ignore_TripTime, System.Boolean ConfResetReq, bool ignore_ConfResetReq, System.Boolean FailResetReq, bool ignore_FailResetReq, System.Int32 ScanTime, bool ignore_ScanTime, System.Byte AlmAckType, bool ignore_AlmAckType, System.Boolean EnTrackSp, bool ignore_EnTrackSp, System.Boolean EnResetSp, bool ignore_EnResetSp)
    {
      object[] _values_ = new object[8];
      if (!ignore_MonTime) _values_[0] = MonTime;
      if (!ignore_TripTime) _values_[1] = TripTime;
      if (!ignore_ConfResetReq) _values_[2] = ConfResetReq;
      if (!ignore_FailResetReq) _values_[3] = FailResetReq;
      if (!ignore_ScanTime) _values_[4] = ScanTime;
      if (!ignore_AlmAckType) _values_[5] = AlmAckType;
      if (!ignore_EnTrackSp) _values_[6] = EnTrackSp;
      if (!ignore_EnResetSp) _values_[7] = EnResetSp;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_SP_CMD(System.Int16 Sp)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {Sp});
    }
    public bool FireEvent_SP_CMD(SE.Nereda.Symbols.MotorBaseNer.SP_CMDEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.Sp.HasValue) _values_[0] = ea.Sp.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_SP_CMD(System.Int16 Sp, bool ignore_Sp)
    {
      object[] _values_ = new object[1];
      if (!ignore_Sp) _values_[0] = Sp;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_RESET_CMD(System.Boolean Reset)
    {
      return ((IHMIAccessorOutput)this).FireEvent(2, new object[] {Reset});
    }
    public bool FireEvent_RESET_CMD(SE.Nereda.Symbols.MotorBaseNer.RESET_CMDEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.Reset.HasValue) _values_[0] = ea.Reset.Value;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_RESET_CMD(System.Boolean Reset, bool ignore_Reset)
    {
      object[] _values_ = new object[1];
      if (!ignore_Reset) _values_[0] = Reset;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_IND_MODE(System.Boolean Simulation, System.Boolean FbOverride, System.Boolean Maintenance, System.Boolean OutOfService)
    {
      return ((IHMIAccessorOutput)this).FireEvent(3, new object[] {Simulation, FbOverride, Maintenance, OutOfService});
    }
    public bool FireEvent_IND_MODE(SE.Nereda.Symbols.MotorBaseNer.IND_MODEEventArgs ea)
    {
      object[] _values_ = new object[4];
      if (ea.Simulation.HasValue) _values_[0] = ea.Simulation.Value;
      if (ea.FbOverride.HasValue) _values_[1] = ea.FbOverride.Value;
      if (ea.Maintenance.HasValue) _values_[2] = ea.Maintenance.Value;
      if (ea.OutOfService.HasValue) _values_[3] = ea.OutOfService.Value;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_IND_MODE(System.Boolean Simulation, bool ignore_Simulation, System.Boolean FbOverride, bool ignore_FbOverride, System.Boolean Maintenance, bool ignore_Maintenance, System.Boolean OutOfService, bool ignore_OutOfService)
    {
      object[] _values_ = new object[4];
      if (!ignore_Simulation) _values_[0] = Simulation;
      if (!ignore_FbOverride) _values_[1] = FbOverride;
      if (!ignore_Maintenance) _values_[2] = Maintenance;
      if (!ignore_OutOfService) _values_[3] = OutOfService;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_OWNER(System.UInt16 Owner)
    {
      return ((IHMIAccessorOutput)this).FireEvent(4, new object[] {Owner});
    }
    public bool FireEvent_OWNER(SE.Nereda.Symbols.MotorBaseNer.OWNEREventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.Owner.HasValue) _values_[0] = ea.Owner.Value;
      return ((IHMIAccessorOutput)this).FireEvent(4, _values_);
    }
    public bool FireEvent_OWNER(System.UInt16 Owner, bool ignore_Owner)
    {
      object[] _values_ = new object[1];
      if (!ignore_Owner) _values_[0] = Owner;
      return ((IHMIAccessorOutput)this).FireEvent(4, _values_);
    }

  }
}

namespace SE.Nereda.Symbols.MotorBaseNer
{
  partial class sDiagnostico
  {

    private event EventHandler<SE.Nereda.Symbols.MotorBaseNer.UPDEventArgs> UPD_Fired;

    protected override void OnEndInit()
    {
      if (UPD_Fired != null)
        AttachEventInput(0);

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
              UPD_Fired(this, new SE.Nereda.Symbols.MotorBaseNer.UPDEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","UPD_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_CFG(System.Int32 MonTime, System.Int32 TripTime, System.Boolean ConfResetReq, System.Boolean FailResetReq, System.Int32 ScanTime, System.Byte AlmAckType, System.Boolean EnTrackSp, System.Boolean EnResetSp)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {MonTime, TripTime, ConfResetReq, FailResetReq, ScanTime, AlmAckType, EnTrackSp, EnResetSp});
    }
    public bool FireEvent_CFG(SE.Nereda.Symbols.MotorBaseNer.CFGEventArgs ea)
    {
      object[] _values_ = new object[8];
      if (ea.MonTime.HasValue) _values_[0] = ea.MonTime.Value;
      if (ea.TripTime.HasValue) _values_[1] = ea.TripTime.Value;
      if (ea.ConfResetReq.HasValue) _values_[2] = ea.ConfResetReq.Value;
      if (ea.FailResetReq.HasValue) _values_[3] = ea.FailResetReq.Value;
      if (ea.ScanTime.HasValue) _values_[4] = ea.ScanTime.Value;
      if (ea.AlmAckType.HasValue) _values_[5] = ea.AlmAckType.Value;
      if (ea.EnTrackSp.HasValue) _values_[6] = ea.EnTrackSp.Value;
      if (ea.EnResetSp.HasValue) _values_[7] = ea.EnResetSp.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_CFG(System.Int32 MonTime, bool ignore_MonTime, System.Int32 TripTime, bool ignore_TripTime, System.Boolean ConfResetReq, bool ignore_ConfResetReq, System.Boolean FailResetReq, bool ignore_FailResetReq, System.Int32 ScanTime, bool ignore_ScanTime, System.Byte AlmAckType, bool ignore_AlmAckType, System.Boolean EnTrackSp, bool ignore_EnTrackSp, System.Boolean EnResetSp, bool ignore_EnResetSp)
    {
      object[] _values_ = new object[8];
      if (!ignore_MonTime) _values_[0] = MonTime;
      if (!ignore_TripTime) _values_[1] = TripTime;
      if (!ignore_ConfResetReq) _values_[2] = ConfResetReq;
      if (!ignore_FailResetReq) _values_[3] = FailResetReq;
      if (!ignore_ScanTime) _values_[4] = ScanTime;
      if (!ignore_AlmAckType) _values_[5] = AlmAckType;
      if (!ignore_EnTrackSp) _values_[6] = EnTrackSp;
      if (!ignore_EnResetSp) _values_[7] = EnResetSp;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_SP_CMD(System.Int16 Sp)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {Sp});
    }
    public bool FireEvent_SP_CMD(SE.Nereda.Symbols.MotorBaseNer.SP_CMDEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.Sp.HasValue) _values_[0] = ea.Sp.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_SP_CMD(System.Int16 Sp, bool ignore_Sp)
    {
      object[] _values_ = new object[1];
      if (!ignore_Sp) _values_[0] = Sp;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_RESET_CMD(System.Boolean Reset)
    {
      return ((IHMIAccessorOutput)this).FireEvent(2, new object[] {Reset});
    }
    public bool FireEvent_RESET_CMD(SE.Nereda.Symbols.MotorBaseNer.RESET_CMDEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.Reset.HasValue) _values_[0] = ea.Reset.Value;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_RESET_CMD(System.Boolean Reset, bool ignore_Reset)
    {
      object[] _values_ = new object[1];
      if (!ignore_Reset) _values_[0] = Reset;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_IND_MODE(System.Boolean Simulation, System.Boolean FbOverride, System.Boolean Maintenance, System.Boolean OutOfService)
    {
      return ((IHMIAccessorOutput)this).FireEvent(3, new object[] {Simulation, FbOverride, Maintenance, OutOfService});
    }
    public bool FireEvent_IND_MODE(SE.Nereda.Symbols.MotorBaseNer.IND_MODEEventArgs ea)
    {
      object[] _values_ = new object[4];
      if (ea.Simulation.HasValue) _values_[0] = ea.Simulation.Value;
      if (ea.FbOverride.HasValue) _values_[1] = ea.FbOverride.Value;
      if (ea.Maintenance.HasValue) _values_[2] = ea.Maintenance.Value;
      if (ea.OutOfService.HasValue) _values_[3] = ea.OutOfService.Value;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_IND_MODE(System.Boolean Simulation, bool ignore_Simulation, System.Boolean FbOverride, bool ignore_FbOverride, System.Boolean Maintenance, bool ignore_Maintenance, System.Boolean OutOfService, bool ignore_OutOfService)
    {
      object[] _values_ = new object[4];
      if (!ignore_Simulation) _values_[0] = Simulation;
      if (!ignore_FbOverride) _values_[1] = FbOverride;
      if (!ignore_Maintenance) _values_[2] = Maintenance;
      if (!ignore_OutOfService) _values_[3] = OutOfService;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_OWNER(System.UInt16 Owner)
    {
      return ((IHMIAccessorOutput)this).FireEvent(4, new object[] {Owner});
    }
    public bool FireEvent_OWNER(SE.Nereda.Symbols.MotorBaseNer.OWNEREventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.Owner.HasValue) _values_[0] = ea.Owner.Value;
      return ((IHMIAccessorOutput)this).FireEvent(4, _values_);
    }
    public bool FireEvent_OWNER(System.UInt16 Owner, bool ignore_Owner)
    {
      object[] _values_ = new object[1];
      if (!ignore_Owner) _values_[0] = Owner;
      return ((IHMIAccessorOutput)this).FireEvent(4, _values_);
    }

  }
}

namespace SE.Nereda.Symbols.MotorBaseNer
{
  partial class sPump
  {

    private event EventHandler<SE.Nereda.Symbols.MotorBaseNer.UPDEventArgs> UPD_Fired;

    protected override void OnEndInit()
    {
      if (UPD_Fired != null)
        AttachEventInput(0);

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
              UPD_Fired(this, new SE.Nereda.Symbols.MotorBaseNer.UPDEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","UPD_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_CFG(System.Int32 MonTime, System.Int32 TripTime, System.Boolean ConfResetReq, System.Boolean FailResetReq, System.Int32 ScanTime, System.Byte AlmAckType, System.Boolean EnTrackSp, System.Boolean EnResetSp)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {MonTime, TripTime, ConfResetReq, FailResetReq, ScanTime, AlmAckType, EnTrackSp, EnResetSp});
    }
    public bool FireEvent_CFG(SE.Nereda.Symbols.MotorBaseNer.CFGEventArgs ea)
    {
      object[] _values_ = new object[8];
      if (ea.MonTime.HasValue) _values_[0] = ea.MonTime.Value;
      if (ea.TripTime.HasValue) _values_[1] = ea.TripTime.Value;
      if (ea.ConfResetReq.HasValue) _values_[2] = ea.ConfResetReq.Value;
      if (ea.FailResetReq.HasValue) _values_[3] = ea.FailResetReq.Value;
      if (ea.ScanTime.HasValue) _values_[4] = ea.ScanTime.Value;
      if (ea.AlmAckType.HasValue) _values_[5] = ea.AlmAckType.Value;
      if (ea.EnTrackSp.HasValue) _values_[6] = ea.EnTrackSp.Value;
      if (ea.EnResetSp.HasValue) _values_[7] = ea.EnResetSp.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_CFG(System.Int32 MonTime, bool ignore_MonTime, System.Int32 TripTime, bool ignore_TripTime, System.Boolean ConfResetReq, bool ignore_ConfResetReq, System.Boolean FailResetReq, bool ignore_FailResetReq, System.Int32 ScanTime, bool ignore_ScanTime, System.Byte AlmAckType, bool ignore_AlmAckType, System.Boolean EnTrackSp, bool ignore_EnTrackSp, System.Boolean EnResetSp, bool ignore_EnResetSp)
    {
      object[] _values_ = new object[8];
      if (!ignore_MonTime) _values_[0] = MonTime;
      if (!ignore_TripTime) _values_[1] = TripTime;
      if (!ignore_ConfResetReq) _values_[2] = ConfResetReq;
      if (!ignore_FailResetReq) _values_[3] = FailResetReq;
      if (!ignore_ScanTime) _values_[4] = ScanTime;
      if (!ignore_AlmAckType) _values_[5] = AlmAckType;
      if (!ignore_EnTrackSp) _values_[6] = EnTrackSp;
      if (!ignore_EnResetSp) _values_[7] = EnResetSp;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_SP_CMD(System.Int16 Sp)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {Sp});
    }
    public bool FireEvent_SP_CMD(SE.Nereda.Symbols.MotorBaseNer.SP_CMDEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.Sp.HasValue) _values_[0] = ea.Sp.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_SP_CMD(System.Int16 Sp, bool ignore_Sp)
    {
      object[] _values_ = new object[1];
      if (!ignore_Sp) _values_[0] = Sp;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_RESET_CMD(System.Boolean Reset)
    {
      return ((IHMIAccessorOutput)this).FireEvent(2, new object[] {Reset});
    }
    public bool FireEvent_RESET_CMD(SE.Nereda.Symbols.MotorBaseNer.RESET_CMDEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.Reset.HasValue) _values_[0] = ea.Reset.Value;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_RESET_CMD(System.Boolean Reset, bool ignore_Reset)
    {
      object[] _values_ = new object[1];
      if (!ignore_Reset) _values_[0] = Reset;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_IND_MODE(System.Boolean Simulation, System.Boolean FbOverride, System.Boolean Maintenance, System.Boolean OutOfService)
    {
      return ((IHMIAccessorOutput)this).FireEvent(3, new object[] {Simulation, FbOverride, Maintenance, OutOfService});
    }
    public bool FireEvent_IND_MODE(SE.Nereda.Symbols.MotorBaseNer.IND_MODEEventArgs ea)
    {
      object[] _values_ = new object[4];
      if (ea.Simulation.HasValue) _values_[0] = ea.Simulation.Value;
      if (ea.FbOverride.HasValue) _values_[1] = ea.FbOverride.Value;
      if (ea.Maintenance.HasValue) _values_[2] = ea.Maintenance.Value;
      if (ea.OutOfService.HasValue) _values_[3] = ea.OutOfService.Value;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_IND_MODE(System.Boolean Simulation, bool ignore_Simulation, System.Boolean FbOverride, bool ignore_FbOverride, System.Boolean Maintenance, bool ignore_Maintenance, System.Boolean OutOfService, bool ignore_OutOfService)
    {
      object[] _values_ = new object[4];
      if (!ignore_Simulation) _values_[0] = Simulation;
      if (!ignore_FbOverride) _values_[1] = FbOverride;
      if (!ignore_Maintenance) _values_[2] = Maintenance;
      if (!ignore_OutOfService) _values_[3] = OutOfService;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_OWNER(System.UInt16 Owner)
    {
      return ((IHMIAccessorOutput)this).FireEvent(4, new object[] {Owner});
    }
    public bool FireEvent_OWNER(SE.Nereda.Symbols.MotorBaseNer.OWNEREventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.Owner.HasValue) _values_[0] = ea.Owner.Value;
      return ((IHMIAccessorOutput)this).FireEvent(4, _values_);
    }
    public bool FireEvent_OWNER(System.UInt16 Owner, bool ignore_Owner)
    {
      object[] _values_ = new object[1];
      if (!ignore_Owner) _values_[0] = Owner;
      return ((IHMIAccessorOutput)this).FireEvent(4, _values_);
    }

  }
}

namespace SE.Nereda.Symbols.MotorBaseNer
{
  partial class sFan
  {

    private event EventHandler<SE.Nereda.Symbols.MotorBaseNer.UPDEventArgs> UPD_Fired;

    protected override void OnEndInit()
    {
      if (UPD_Fired != null)
        AttachEventInput(0);

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
              UPD_Fired(this, new SE.Nereda.Symbols.MotorBaseNer.UPDEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","UPD_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_CFG(System.Int32 MonTime, System.Int32 TripTime, System.Boolean ConfResetReq, System.Boolean FailResetReq, System.Int32 ScanTime, System.Byte AlmAckType, System.Boolean EnTrackSp, System.Boolean EnResetSp)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {MonTime, TripTime, ConfResetReq, FailResetReq, ScanTime, AlmAckType, EnTrackSp, EnResetSp});
    }
    public bool FireEvent_CFG(SE.Nereda.Symbols.MotorBaseNer.CFGEventArgs ea)
    {
      object[] _values_ = new object[8];
      if (ea.MonTime.HasValue) _values_[0] = ea.MonTime.Value;
      if (ea.TripTime.HasValue) _values_[1] = ea.TripTime.Value;
      if (ea.ConfResetReq.HasValue) _values_[2] = ea.ConfResetReq.Value;
      if (ea.FailResetReq.HasValue) _values_[3] = ea.FailResetReq.Value;
      if (ea.ScanTime.HasValue) _values_[4] = ea.ScanTime.Value;
      if (ea.AlmAckType.HasValue) _values_[5] = ea.AlmAckType.Value;
      if (ea.EnTrackSp.HasValue) _values_[6] = ea.EnTrackSp.Value;
      if (ea.EnResetSp.HasValue) _values_[7] = ea.EnResetSp.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_CFG(System.Int32 MonTime, bool ignore_MonTime, System.Int32 TripTime, bool ignore_TripTime, System.Boolean ConfResetReq, bool ignore_ConfResetReq, System.Boolean FailResetReq, bool ignore_FailResetReq, System.Int32 ScanTime, bool ignore_ScanTime, System.Byte AlmAckType, bool ignore_AlmAckType, System.Boolean EnTrackSp, bool ignore_EnTrackSp, System.Boolean EnResetSp, bool ignore_EnResetSp)
    {
      object[] _values_ = new object[8];
      if (!ignore_MonTime) _values_[0] = MonTime;
      if (!ignore_TripTime) _values_[1] = TripTime;
      if (!ignore_ConfResetReq) _values_[2] = ConfResetReq;
      if (!ignore_FailResetReq) _values_[3] = FailResetReq;
      if (!ignore_ScanTime) _values_[4] = ScanTime;
      if (!ignore_AlmAckType) _values_[5] = AlmAckType;
      if (!ignore_EnTrackSp) _values_[6] = EnTrackSp;
      if (!ignore_EnResetSp) _values_[7] = EnResetSp;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_SP_CMD(System.Int16 Sp)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {Sp});
    }
    public bool FireEvent_SP_CMD(SE.Nereda.Symbols.MotorBaseNer.SP_CMDEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.Sp.HasValue) _values_[0] = ea.Sp.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_SP_CMD(System.Int16 Sp, bool ignore_Sp)
    {
      object[] _values_ = new object[1];
      if (!ignore_Sp) _values_[0] = Sp;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_RESET_CMD(System.Boolean Reset)
    {
      return ((IHMIAccessorOutput)this).FireEvent(2, new object[] {Reset});
    }
    public bool FireEvent_RESET_CMD(SE.Nereda.Symbols.MotorBaseNer.RESET_CMDEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.Reset.HasValue) _values_[0] = ea.Reset.Value;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_RESET_CMD(System.Boolean Reset, bool ignore_Reset)
    {
      object[] _values_ = new object[1];
      if (!ignore_Reset) _values_[0] = Reset;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_IND_MODE(System.Boolean Simulation, System.Boolean FbOverride, System.Boolean Maintenance, System.Boolean OutOfService)
    {
      return ((IHMIAccessorOutput)this).FireEvent(3, new object[] {Simulation, FbOverride, Maintenance, OutOfService});
    }
    public bool FireEvent_IND_MODE(SE.Nereda.Symbols.MotorBaseNer.IND_MODEEventArgs ea)
    {
      object[] _values_ = new object[4];
      if (ea.Simulation.HasValue) _values_[0] = ea.Simulation.Value;
      if (ea.FbOverride.HasValue) _values_[1] = ea.FbOverride.Value;
      if (ea.Maintenance.HasValue) _values_[2] = ea.Maintenance.Value;
      if (ea.OutOfService.HasValue) _values_[3] = ea.OutOfService.Value;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_IND_MODE(System.Boolean Simulation, bool ignore_Simulation, System.Boolean FbOverride, bool ignore_FbOverride, System.Boolean Maintenance, bool ignore_Maintenance, System.Boolean OutOfService, bool ignore_OutOfService)
    {
      object[] _values_ = new object[4];
      if (!ignore_Simulation) _values_[0] = Simulation;
      if (!ignore_FbOverride) _values_[1] = FbOverride;
      if (!ignore_Maintenance) _values_[2] = Maintenance;
      if (!ignore_OutOfService) _values_[3] = OutOfService;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_OWNER(System.UInt16 Owner)
    {
      return ((IHMIAccessorOutput)this).FireEvent(4, new object[] {Owner});
    }
    public bool FireEvent_OWNER(SE.Nereda.Symbols.MotorBaseNer.OWNEREventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.Owner.HasValue) _values_[0] = ea.Owner.Value;
      return ((IHMIAccessorOutput)this).FireEvent(4, _values_);
    }
    public bool FireEvent_OWNER(System.UInt16 Owner, bool ignore_Owner)
    {
      object[] _values_ = new object[1];
      if (!ignore_Owner) _values_[0] = Owner;
      return ((IHMIAccessorOutput)this).FireEvent(4, _values_);
    }

  }
}

namespace SE.Nereda.Symbols.MotorBaseNer
{
  partial class sBlower
  {

    private event EventHandler<SE.Nereda.Symbols.MotorBaseNer.UPDEventArgs> UPD_Fired;

    protected override void OnEndInit()
    {
      if (UPD_Fired != null)
        AttachEventInput(0);

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
              UPD_Fired(this, new SE.Nereda.Symbols.MotorBaseNer.UPDEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","UPD_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_CFG(System.Int32 MonTime, System.Int32 TripTime, System.Boolean ConfResetReq, System.Boolean FailResetReq, System.Int32 ScanTime, System.Byte AlmAckType, System.Boolean EnTrackSp, System.Boolean EnResetSp)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {MonTime, TripTime, ConfResetReq, FailResetReq, ScanTime, AlmAckType, EnTrackSp, EnResetSp});
    }
    public bool FireEvent_CFG(SE.Nereda.Symbols.MotorBaseNer.CFGEventArgs ea)
    {
      object[] _values_ = new object[8];
      if (ea.MonTime.HasValue) _values_[0] = ea.MonTime.Value;
      if (ea.TripTime.HasValue) _values_[1] = ea.TripTime.Value;
      if (ea.ConfResetReq.HasValue) _values_[2] = ea.ConfResetReq.Value;
      if (ea.FailResetReq.HasValue) _values_[3] = ea.FailResetReq.Value;
      if (ea.ScanTime.HasValue) _values_[4] = ea.ScanTime.Value;
      if (ea.AlmAckType.HasValue) _values_[5] = ea.AlmAckType.Value;
      if (ea.EnTrackSp.HasValue) _values_[6] = ea.EnTrackSp.Value;
      if (ea.EnResetSp.HasValue) _values_[7] = ea.EnResetSp.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_CFG(System.Int32 MonTime, bool ignore_MonTime, System.Int32 TripTime, bool ignore_TripTime, System.Boolean ConfResetReq, bool ignore_ConfResetReq, System.Boolean FailResetReq, bool ignore_FailResetReq, System.Int32 ScanTime, bool ignore_ScanTime, System.Byte AlmAckType, bool ignore_AlmAckType, System.Boolean EnTrackSp, bool ignore_EnTrackSp, System.Boolean EnResetSp, bool ignore_EnResetSp)
    {
      object[] _values_ = new object[8];
      if (!ignore_MonTime) _values_[0] = MonTime;
      if (!ignore_TripTime) _values_[1] = TripTime;
      if (!ignore_ConfResetReq) _values_[2] = ConfResetReq;
      if (!ignore_FailResetReq) _values_[3] = FailResetReq;
      if (!ignore_ScanTime) _values_[4] = ScanTime;
      if (!ignore_AlmAckType) _values_[5] = AlmAckType;
      if (!ignore_EnTrackSp) _values_[6] = EnTrackSp;
      if (!ignore_EnResetSp) _values_[7] = EnResetSp;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_SP_CMD(System.Int16 Sp)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {Sp});
    }
    public bool FireEvent_SP_CMD(SE.Nereda.Symbols.MotorBaseNer.SP_CMDEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.Sp.HasValue) _values_[0] = ea.Sp.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_SP_CMD(System.Int16 Sp, bool ignore_Sp)
    {
      object[] _values_ = new object[1];
      if (!ignore_Sp) _values_[0] = Sp;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_RESET_CMD(System.Boolean Reset)
    {
      return ((IHMIAccessorOutput)this).FireEvent(2, new object[] {Reset});
    }
    public bool FireEvent_RESET_CMD(SE.Nereda.Symbols.MotorBaseNer.RESET_CMDEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.Reset.HasValue) _values_[0] = ea.Reset.Value;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_RESET_CMD(System.Boolean Reset, bool ignore_Reset)
    {
      object[] _values_ = new object[1];
      if (!ignore_Reset) _values_[0] = Reset;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_IND_MODE(System.Boolean Simulation, System.Boolean FbOverride, System.Boolean Maintenance, System.Boolean OutOfService)
    {
      return ((IHMIAccessorOutput)this).FireEvent(3, new object[] {Simulation, FbOverride, Maintenance, OutOfService});
    }
    public bool FireEvent_IND_MODE(SE.Nereda.Symbols.MotorBaseNer.IND_MODEEventArgs ea)
    {
      object[] _values_ = new object[4];
      if (ea.Simulation.HasValue) _values_[0] = ea.Simulation.Value;
      if (ea.FbOverride.HasValue) _values_[1] = ea.FbOverride.Value;
      if (ea.Maintenance.HasValue) _values_[2] = ea.Maintenance.Value;
      if (ea.OutOfService.HasValue) _values_[3] = ea.OutOfService.Value;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_IND_MODE(System.Boolean Simulation, bool ignore_Simulation, System.Boolean FbOverride, bool ignore_FbOverride, System.Boolean Maintenance, bool ignore_Maintenance, System.Boolean OutOfService, bool ignore_OutOfService)
    {
      object[] _values_ = new object[4];
      if (!ignore_Simulation) _values_[0] = Simulation;
      if (!ignore_FbOverride) _values_[1] = FbOverride;
      if (!ignore_Maintenance) _values_[2] = Maintenance;
      if (!ignore_OutOfService) _values_[3] = OutOfService;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_OWNER(System.UInt16 Owner)
    {
      return ((IHMIAccessorOutput)this).FireEvent(4, new object[] {Owner});
    }
    public bool FireEvent_OWNER(SE.Nereda.Symbols.MotorBaseNer.OWNEREventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.Owner.HasValue) _values_[0] = ea.Owner.Value;
      return ((IHMIAccessorOutput)this).FireEvent(4, _values_);
    }
    public bool FireEvent_OWNER(System.UInt16 Owner, bool ignore_Owner)
    {
      object[] _values_ = new object[1];
      if (!ignore_Owner) _values_[0] = Owner;
      return ((IHMIAccessorOutput)this).FireEvent(4, _values_);
    }

  }
}

namespace SE.Nereda.Faceplates.MotorBaseNer
{
  partial class fpTrend
  {

    private event EventHandler<SE.Nereda.Symbols.MotorBaseNer.UPDEventArgs> UPD_Fired;

    protected override void OnEndInit()
    {
      if (UPD_Fired != null)
        AttachEventInput(0);

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
              UPD_Fired(this, new SE.Nereda.Symbols.MotorBaseNer.UPDEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","UPD_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_CFG(System.Int32 MonTime, System.Int32 TripTime, System.Boolean ConfResetReq, System.Boolean FailResetReq, System.Int32 ScanTime, System.Byte AlmAckType, System.Boolean EnTrackSp, System.Boolean EnResetSp)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {MonTime, TripTime, ConfResetReq, FailResetReq, ScanTime, AlmAckType, EnTrackSp, EnResetSp});
    }
    public bool FireEvent_CFG(SE.Nereda.Symbols.MotorBaseNer.CFGEventArgs ea)
    {
      object[] _values_ = new object[8];
      if (ea.MonTime.HasValue) _values_[0] = ea.MonTime.Value;
      if (ea.TripTime.HasValue) _values_[1] = ea.TripTime.Value;
      if (ea.ConfResetReq.HasValue) _values_[2] = ea.ConfResetReq.Value;
      if (ea.FailResetReq.HasValue) _values_[3] = ea.FailResetReq.Value;
      if (ea.ScanTime.HasValue) _values_[4] = ea.ScanTime.Value;
      if (ea.AlmAckType.HasValue) _values_[5] = ea.AlmAckType.Value;
      if (ea.EnTrackSp.HasValue) _values_[6] = ea.EnTrackSp.Value;
      if (ea.EnResetSp.HasValue) _values_[7] = ea.EnResetSp.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_CFG(System.Int32 MonTime, bool ignore_MonTime, System.Int32 TripTime, bool ignore_TripTime, System.Boolean ConfResetReq, bool ignore_ConfResetReq, System.Boolean FailResetReq, bool ignore_FailResetReq, System.Int32 ScanTime, bool ignore_ScanTime, System.Byte AlmAckType, bool ignore_AlmAckType, System.Boolean EnTrackSp, bool ignore_EnTrackSp, System.Boolean EnResetSp, bool ignore_EnResetSp)
    {
      object[] _values_ = new object[8];
      if (!ignore_MonTime) _values_[0] = MonTime;
      if (!ignore_TripTime) _values_[1] = TripTime;
      if (!ignore_ConfResetReq) _values_[2] = ConfResetReq;
      if (!ignore_FailResetReq) _values_[3] = FailResetReq;
      if (!ignore_ScanTime) _values_[4] = ScanTime;
      if (!ignore_AlmAckType) _values_[5] = AlmAckType;
      if (!ignore_EnTrackSp) _values_[6] = EnTrackSp;
      if (!ignore_EnResetSp) _values_[7] = EnResetSp;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_SP_CMD(System.Int16 Sp)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {Sp});
    }
    public bool FireEvent_SP_CMD(SE.Nereda.Symbols.MotorBaseNer.SP_CMDEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.Sp.HasValue) _values_[0] = ea.Sp.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_SP_CMD(System.Int16 Sp, bool ignore_Sp)
    {
      object[] _values_ = new object[1];
      if (!ignore_Sp) _values_[0] = Sp;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_RESET_CMD(System.Boolean Reset)
    {
      return ((IHMIAccessorOutput)this).FireEvent(2, new object[] {Reset});
    }
    public bool FireEvent_RESET_CMD(SE.Nereda.Symbols.MotorBaseNer.RESET_CMDEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.Reset.HasValue) _values_[0] = ea.Reset.Value;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_RESET_CMD(System.Boolean Reset, bool ignore_Reset)
    {
      object[] _values_ = new object[1];
      if (!ignore_Reset) _values_[0] = Reset;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_IND_MODE(System.Boolean Simulation, System.Boolean FbOverride, System.Boolean Maintenance, System.Boolean OutOfService)
    {
      return ((IHMIAccessorOutput)this).FireEvent(3, new object[] {Simulation, FbOverride, Maintenance, OutOfService});
    }
    public bool FireEvent_IND_MODE(SE.Nereda.Symbols.MotorBaseNer.IND_MODEEventArgs ea)
    {
      object[] _values_ = new object[4];
      if (ea.Simulation.HasValue) _values_[0] = ea.Simulation.Value;
      if (ea.FbOverride.HasValue) _values_[1] = ea.FbOverride.Value;
      if (ea.Maintenance.HasValue) _values_[2] = ea.Maintenance.Value;
      if (ea.OutOfService.HasValue) _values_[3] = ea.OutOfService.Value;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_IND_MODE(System.Boolean Simulation, bool ignore_Simulation, System.Boolean FbOverride, bool ignore_FbOverride, System.Boolean Maintenance, bool ignore_Maintenance, System.Boolean OutOfService, bool ignore_OutOfService)
    {
      object[] _values_ = new object[4];
      if (!ignore_Simulation) _values_[0] = Simulation;
      if (!ignore_FbOverride) _values_[1] = FbOverride;
      if (!ignore_Maintenance) _values_[2] = Maintenance;
      if (!ignore_OutOfService) _values_[3] = OutOfService;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_OWNER(System.UInt16 Owner)
    {
      return ((IHMIAccessorOutput)this).FireEvent(4, new object[] {Owner});
    }
    public bool FireEvent_OWNER(SE.Nereda.Symbols.MotorBaseNer.OWNEREventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.Owner.HasValue) _values_[0] = ea.Owner.Value;
      return ((IHMIAccessorOutput)this).FireEvent(4, _values_);
    }
    public bool FireEvent_OWNER(System.UInt16 Owner, bool ignore_Owner)
    {
      object[] _values_ = new object[1];
      if (!ignore_Owner) _values_[0] = Owner;
      return ((IHMIAccessorOutput)this).FireEvent(4, _values_);
    }

  }
}

namespace SE.Nereda.Symbols.MotorBaseNer
{
  partial class sConveyor
  {

    private event EventHandler<SE.Nereda.Symbols.MotorBaseNer.UPDEventArgs> UPD_Fired;

    protected override void OnEndInit()
    {
      if (UPD_Fired != null)
        AttachEventInput(0);

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
              UPD_Fired(this, new SE.Nereda.Symbols.MotorBaseNer.UPDEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","UPD_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_CFG(System.Int32 MonTime, System.Int32 TripTime, System.Boolean ConfResetReq, System.Boolean FailResetReq, System.Int32 ScanTime, System.Byte AlmAckType, System.Boolean EnTrackSp, System.Boolean EnResetSp)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {MonTime, TripTime, ConfResetReq, FailResetReq, ScanTime, AlmAckType, EnTrackSp, EnResetSp});
    }
    public bool FireEvent_CFG(SE.Nereda.Symbols.MotorBaseNer.CFGEventArgs ea)
    {
      object[] _values_ = new object[8];
      if (ea.MonTime.HasValue) _values_[0] = ea.MonTime.Value;
      if (ea.TripTime.HasValue) _values_[1] = ea.TripTime.Value;
      if (ea.ConfResetReq.HasValue) _values_[2] = ea.ConfResetReq.Value;
      if (ea.FailResetReq.HasValue) _values_[3] = ea.FailResetReq.Value;
      if (ea.ScanTime.HasValue) _values_[4] = ea.ScanTime.Value;
      if (ea.AlmAckType.HasValue) _values_[5] = ea.AlmAckType.Value;
      if (ea.EnTrackSp.HasValue) _values_[6] = ea.EnTrackSp.Value;
      if (ea.EnResetSp.HasValue) _values_[7] = ea.EnResetSp.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_CFG(System.Int32 MonTime, bool ignore_MonTime, System.Int32 TripTime, bool ignore_TripTime, System.Boolean ConfResetReq, bool ignore_ConfResetReq, System.Boolean FailResetReq, bool ignore_FailResetReq, System.Int32 ScanTime, bool ignore_ScanTime, System.Byte AlmAckType, bool ignore_AlmAckType, System.Boolean EnTrackSp, bool ignore_EnTrackSp, System.Boolean EnResetSp, bool ignore_EnResetSp)
    {
      object[] _values_ = new object[8];
      if (!ignore_MonTime) _values_[0] = MonTime;
      if (!ignore_TripTime) _values_[1] = TripTime;
      if (!ignore_ConfResetReq) _values_[2] = ConfResetReq;
      if (!ignore_FailResetReq) _values_[3] = FailResetReq;
      if (!ignore_ScanTime) _values_[4] = ScanTime;
      if (!ignore_AlmAckType) _values_[5] = AlmAckType;
      if (!ignore_EnTrackSp) _values_[6] = EnTrackSp;
      if (!ignore_EnResetSp) _values_[7] = EnResetSp;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_SP_CMD(System.Int16 Sp)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {Sp});
    }
    public bool FireEvent_SP_CMD(SE.Nereda.Symbols.MotorBaseNer.SP_CMDEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.Sp.HasValue) _values_[0] = ea.Sp.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_SP_CMD(System.Int16 Sp, bool ignore_Sp)
    {
      object[] _values_ = new object[1];
      if (!ignore_Sp) _values_[0] = Sp;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_RESET_CMD(System.Boolean Reset)
    {
      return ((IHMIAccessorOutput)this).FireEvent(2, new object[] {Reset});
    }
    public bool FireEvent_RESET_CMD(SE.Nereda.Symbols.MotorBaseNer.RESET_CMDEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.Reset.HasValue) _values_[0] = ea.Reset.Value;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_RESET_CMD(System.Boolean Reset, bool ignore_Reset)
    {
      object[] _values_ = new object[1];
      if (!ignore_Reset) _values_[0] = Reset;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_IND_MODE(System.Boolean Simulation, System.Boolean FbOverride, System.Boolean Maintenance, System.Boolean OutOfService)
    {
      return ((IHMIAccessorOutput)this).FireEvent(3, new object[] {Simulation, FbOverride, Maintenance, OutOfService});
    }
    public bool FireEvent_IND_MODE(SE.Nereda.Symbols.MotorBaseNer.IND_MODEEventArgs ea)
    {
      object[] _values_ = new object[4];
      if (ea.Simulation.HasValue) _values_[0] = ea.Simulation.Value;
      if (ea.FbOverride.HasValue) _values_[1] = ea.FbOverride.Value;
      if (ea.Maintenance.HasValue) _values_[2] = ea.Maintenance.Value;
      if (ea.OutOfService.HasValue) _values_[3] = ea.OutOfService.Value;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_IND_MODE(System.Boolean Simulation, bool ignore_Simulation, System.Boolean FbOverride, bool ignore_FbOverride, System.Boolean Maintenance, bool ignore_Maintenance, System.Boolean OutOfService, bool ignore_OutOfService)
    {
      object[] _values_ = new object[4];
      if (!ignore_Simulation) _values_[0] = Simulation;
      if (!ignore_FbOverride) _values_[1] = FbOverride;
      if (!ignore_Maintenance) _values_[2] = Maintenance;
      if (!ignore_OutOfService) _values_[3] = OutOfService;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_OWNER(System.UInt16 Owner)
    {
      return ((IHMIAccessorOutput)this).FireEvent(4, new object[] {Owner});
    }
    public bool FireEvent_OWNER(SE.Nereda.Symbols.MotorBaseNer.OWNEREventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.Owner.HasValue) _values_[0] = ea.Owner.Value;
      return ((IHMIAccessorOutput)this).FireEvent(4, _values_);
    }
    public bool FireEvent_OWNER(System.UInt16 Owner, bool ignore_Owner)
    {
      object[] _values_ = new object[1];
      if (!ignore_Owner) _values_[0] = Owner;
      return ((IHMIAccessorOutput)this).FireEvent(4, _values_);
    }

  }
}

namespace SE.Nereda.Symbols.MotorBaseNer
{
  partial class sArrows
  {

    private event EventHandler<SE.Nereda.Symbols.MotorBaseNer.UPDEventArgs> UPD_Fired;

    protected override void OnEndInit()
    {
      if (UPD_Fired != null)
        AttachEventInput(0);

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
              UPD_Fired(this, new SE.Nereda.Symbols.MotorBaseNer.UPDEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","UPD_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_CFG(System.Int32 MonTime, System.Int32 TripTime, System.Boolean ConfResetReq, System.Boolean FailResetReq, System.Int32 ScanTime, System.Byte AlmAckType, System.Boolean EnTrackSp, System.Boolean EnResetSp)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {MonTime, TripTime, ConfResetReq, FailResetReq, ScanTime, AlmAckType, EnTrackSp, EnResetSp});
    }
    public bool FireEvent_CFG(SE.Nereda.Symbols.MotorBaseNer.CFGEventArgs ea)
    {
      object[] _values_ = new object[8];
      if (ea.MonTime.HasValue) _values_[0] = ea.MonTime.Value;
      if (ea.TripTime.HasValue) _values_[1] = ea.TripTime.Value;
      if (ea.ConfResetReq.HasValue) _values_[2] = ea.ConfResetReq.Value;
      if (ea.FailResetReq.HasValue) _values_[3] = ea.FailResetReq.Value;
      if (ea.ScanTime.HasValue) _values_[4] = ea.ScanTime.Value;
      if (ea.AlmAckType.HasValue) _values_[5] = ea.AlmAckType.Value;
      if (ea.EnTrackSp.HasValue) _values_[6] = ea.EnTrackSp.Value;
      if (ea.EnResetSp.HasValue) _values_[7] = ea.EnResetSp.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_CFG(System.Int32 MonTime, bool ignore_MonTime, System.Int32 TripTime, bool ignore_TripTime, System.Boolean ConfResetReq, bool ignore_ConfResetReq, System.Boolean FailResetReq, bool ignore_FailResetReq, System.Int32 ScanTime, bool ignore_ScanTime, System.Byte AlmAckType, bool ignore_AlmAckType, System.Boolean EnTrackSp, bool ignore_EnTrackSp, System.Boolean EnResetSp, bool ignore_EnResetSp)
    {
      object[] _values_ = new object[8];
      if (!ignore_MonTime) _values_[0] = MonTime;
      if (!ignore_TripTime) _values_[1] = TripTime;
      if (!ignore_ConfResetReq) _values_[2] = ConfResetReq;
      if (!ignore_FailResetReq) _values_[3] = FailResetReq;
      if (!ignore_ScanTime) _values_[4] = ScanTime;
      if (!ignore_AlmAckType) _values_[5] = AlmAckType;
      if (!ignore_EnTrackSp) _values_[6] = EnTrackSp;
      if (!ignore_EnResetSp) _values_[7] = EnResetSp;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_SP_CMD(System.Int16 Sp)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {Sp});
    }
    public bool FireEvent_SP_CMD(SE.Nereda.Symbols.MotorBaseNer.SP_CMDEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.Sp.HasValue) _values_[0] = ea.Sp.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_SP_CMD(System.Int16 Sp, bool ignore_Sp)
    {
      object[] _values_ = new object[1];
      if (!ignore_Sp) _values_[0] = Sp;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_RESET_CMD(System.Boolean Reset)
    {
      return ((IHMIAccessorOutput)this).FireEvent(2, new object[] {Reset});
    }
    public bool FireEvent_RESET_CMD(SE.Nereda.Symbols.MotorBaseNer.RESET_CMDEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.Reset.HasValue) _values_[0] = ea.Reset.Value;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_RESET_CMD(System.Boolean Reset, bool ignore_Reset)
    {
      object[] _values_ = new object[1];
      if (!ignore_Reset) _values_[0] = Reset;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_IND_MODE(System.Boolean Simulation, System.Boolean FbOverride, System.Boolean Maintenance, System.Boolean OutOfService)
    {
      return ((IHMIAccessorOutput)this).FireEvent(3, new object[] {Simulation, FbOverride, Maintenance, OutOfService});
    }
    public bool FireEvent_IND_MODE(SE.Nereda.Symbols.MotorBaseNer.IND_MODEEventArgs ea)
    {
      object[] _values_ = new object[4];
      if (ea.Simulation.HasValue) _values_[0] = ea.Simulation.Value;
      if (ea.FbOverride.HasValue) _values_[1] = ea.FbOverride.Value;
      if (ea.Maintenance.HasValue) _values_[2] = ea.Maintenance.Value;
      if (ea.OutOfService.HasValue) _values_[3] = ea.OutOfService.Value;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_IND_MODE(System.Boolean Simulation, bool ignore_Simulation, System.Boolean FbOverride, bool ignore_FbOverride, System.Boolean Maintenance, bool ignore_Maintenance, System.Boolean OutOfService, bool ignore_OutOfService)
    {
      object[] _values_ = new object[4];
      if (!ignore_Simulation) _values_[0] = Simulation;
      if (!ignore_FbOverride) _values_[1] = FbOverride;
      if (!ignore_Maintenance) _values_[2] = Maintenance;
      if (!ignore_OutOfService) _values_[3] = OutOfService;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_OWNER(System.UInt16 Owner)
    {
      return ((IHMIAccessorOutput)this).FireEvent(4, new object[] {Owner});
    }
    public bool FireEvent_OWNER(SE.Nereda.Symbols.MotorBaseNer.OWNEREventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.Owner.HasValue) _values_[0] = ea.Owner.Value;
      return ((IHMIAccessorOutput)this).FireEvent(4, _values_);
    }
    public bool FireEvent_OWNER(System.UInt16 Owner, bool ignore_Owner)
    {
      object[] _values_ = new object[1];
      if (!ignore_Owner) _values_[0] = Owner;
      return ((IHMIAccessorOutput)this).FireEvent(4, _values_);
    }

  }
}

namespace SE.Nereda.Symbols.MotorBaseNer
{
  partial class sInstanceName
  {

    private event EventHandler<SE.Nereda.Symbols.MotorBaseNer.UPDEventArgs> UPD_Fired;

    protected override void OnEndInit()
    {
      if (UPD_Fired != null)
        AttachEventInput(0);

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
              UPD_Fired(this, new SE.Nereda.Symbols.MotorBaseNer.UPDEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","UPD_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_CFG(System.Int32 MonTime, System.Int32 TripTime, System.Boolean ConfResetReq, System.Boolean FailResetReq, System.Int32 ScanTime, System.Byte AlmAckType, System.Boolean EnTrackSp, System.Boolean EnResetSp)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {MonTime, TripTime, ConfResetReq, FailResetReq, ScanTime, AlmAckType, EnTrackSp, EnResetSp});
    }
    public bool FireEvent_CFG(SE.Nereda.Symbols.MotorBaseNer.CFGEventArgs ea)
    {
      object[] _values_ = new object[8];
      if (ea.MonTime.HasValue) _values_[0] = ea.MonTime.Value;
      if (ea.TripTime.HasValue) _values_[1] = ea.TripTime.Value;
      if (ea.ConfResetReq.HasValue) _values_[2] = ea.ConfResetReq.Value;
      if (ea.FailResetReq.HasValue) _values_[3] = ea.FailResetReq.Value;
      if (ea.ScanTime.HasValue) _values_[4] = ea.ScanTime.Value;
      if (ea.AlmAckType.HasValue) _values_[5] = ea.AlmAckType.Value;
      if (ea.EnTrackSp.HasValue) _values_[6] = ea.EnTrackSp.Value;
      if (ea.EnResetSp.HasValue) _values_[7] = ea.EnResetSp.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_CFG(System.Int32 MonTime, bool ignore_MonTime, System.Int32 TripTime, bool ignore_TripTime, System.Boolean ConfResetReq, bool ignore_ConfResetReq, System.Boolean FailResetReq, bool ignore_FailResetReq, System.Int32 ScanTime, bool ignore_ScanTime, System.Byte AlmAckType, bool ignore_AlmAckType, System.Boolean EnTrackSp, bool ignore_EnTrackSp, System.Boolean EnResetSp, bool ignore_EnResetSp)
    {
      object[] _values_ = new object[8];
      if (!ignore_MonTime) _values_[0] = MonTime;
      if (!ignore_TripTime) _values_[1] = TripTime;
      if (!ignore_ConfResetReq) _values_[2] = ConfResetReq;
      if (!ignore_FailResetReq) _values_[3] = FailResetReq;
      if (!ignore_ScanTime) _values_[4] = ScanTime;
      if (!ignore_AlmAckType) _values_[5] = AlmAckType;
      if (!ignore_EnTrackSp) _values_[6] = EnTrackSp;
      if (!ignore_EnResetSp) _values_[7] = EnResetSp;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_SP_CMD(System.Int16 Sp)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {Sp});
    }
    public bool FireEvent_SP_CMD(SE.Nereda.Symbols.MotorBaseNer.SP_CMDEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.Sp.HasValue) _values_[0] = ea.Sp.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_SP_CMD(System.Int16 Sp, bool ignore_Sp)
    {
      object[] _values_ = new object[1];
      if (!ignore_Sp) _values_[0] = Sp;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_RESET_CMD(System.Boolean Reset)
    {
      return ((IHMIAccessorOutput)this).FireEvent(2, new object[] {Reset});
    }
    public bool FireEvent_RESET_CMD(SE.Nereda.Symbols.MotorBaseNer.RESET_CMDEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.Reset.HasValue) _values_[0] = ea.Reset.Value;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_RESET_CMD(System.Boolean Reset, bool ignore_Reset)
    {
      object[] _values_ = new object[1];
      if (!ignore_Reset) _values_[0] = Reset;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_IND_MODE(System.Boolean Simulation, System.Boolean FbOverride, System.Boolean Maintenance, System.Boolean OutOfService)
    {
      return ((IHMIAccessorOutput)this).FireEvent(3, new object[] {Simulation, FbOverride, Maintenance, OutOfService});
    }
    public bool FireEvent_IND_MODE(SE.Nereda.Symbols.MotorBaseNer.IND_MODEEventArgs ea)
    {
      object[] _values_ = new object[4];
      if (ea.Simulation.HasValue) _values_[0] = ea.Simulation.Value;
      if (ea.FbOverride.HasValue) _values_[1] = ea.FbOverride.Value;
      if (ea.Maintenance.HasValue) _values_[2] = ea.Maintenance.Value;
      if (ea.OutOfService.HasValue) _values_[3] = ea.OutOfService.Value;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_IND_MODE(System.Boolean Simulation, bool ignore_Simulation, System.Boolean FbOverride, bool ignore_FbOverride, System.Boolean Maintenance, bool ignore_Maintenance, System.Boolean OutOfService, bool ignore_OutOfService)
    {
      object[] _values_ = new object[4];
      if (!ignore_Simulation) _values_[0] = Simulation;
      if (!ignore_FbOverride) _values_[1] = FbOverride;
      if (!ignore_Maintenance) _values_[2] = Maintenance;
      if (!ignore_OutOfService) _values_[3] = OutOfService;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_OWNER(System.UInt16 Owner)
    {
      return ((IHMIAccessorOutput)this).FireEvent(4, new object[] {Owner});
    }
    public bool FireEvent_OWNER(SE.Nereda.Symbols.MotorBaseNer.OWNEREventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.Owner.HasValue) _values_[0] = ea.Owner.Value;
      return ((IHMIAccessorOutput)this).FireEvent(4, _values_);
    }
    public bool FireEvent_OWNER(System.UInt16 Owner, bool ignore_Owner)
    {
      object[] _values_ = new object[1];
      if (!ignore_Owner) _values_[0] = Owner;
      return ((IHMIAccessorOutput)this).FireEvent(4, _values_);
    }

  }
}
#endregion #MotorBase_HMI;

#endregion Definitions;



