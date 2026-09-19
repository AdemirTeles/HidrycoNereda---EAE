/*
 * Created by EcoStruxure Automation Expert.
 * User: SESA630210
 * Date: 10/12/2023
 * Time: 10:04 AM
 * 
 */
using System;
using NxtControl.GuiFramework;
using NxtControl.Services;

#region Definitions;
#region #PIDBase_HMI;

namespace HMI.Main.Symbols.PIDBase
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
    public bool Get_Pv(ref System.Single value)
    {
      if (accessorService == null)
        return false;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,0, ref var);
      if (ret) value = (System.Single) var;
      return ret;
    }

    public System.Single? Pv
    { get {
      if (accessorService == null)
        return null;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,0, ref var);
      if (!ret) return null;
      return (System.Single) var;
    }  }

    public bool Get_PvMin(ref System.Single value)
    {
      if (accessorService == null)
        return false;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,1, ref var);
      if (ret) value = (System.Single) var;
      return ret;
    }

    public System.Single? PvMin
    { get {
      if (accessorService == null)
        return null;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,1, ref var);
      if (!ret) return null;
      return (System.Single) var;
    }  }

    public bool Get_PvMax(ref System.Single value)
    {
      if (accessorService == null)
        return false;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,2, ref var);
      if (ret) value = (System.Single) var;
      return ret;
    }

    public System.Single? PvMax
    { get {
      if (accessorService == null)
        return null;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,2, ref var);
      if (!ret) return null;
      return (System.Single) var;
    }  }

    public bool Get_CurrentSp(ref System.Single value)
    {
      if (accessorService == null)
        return false;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,3, ref var);
      if (ret) value = (System.Single) var;
      return ret;
    }

    public System.Single? CurrentSp
    { get {
      if (accessorService == null)
        return null;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,3, ref var);
      if (!ret) return null;
      return (System.Single) var;
    }  }

    public bool Get_CurrentOp(ref System.Single value)
    {
      if (accessorService == null)
        return false;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,4, ref var);
      if (ret) value = (System.Single) var;
      return ret;
    }

    public System.Single? CurrentOp
    { get {
      if (accessorService == null)
        return null;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,4, ref var);
      if (!ret) return null;
      return (System.Single) var;
    }  }

    public bool Get_CurrentMode(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,5, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? CurrentMode
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,5, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }

    public bool Get_OutChannelProhibited(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,6, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? OutChannelProhibited
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,6, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_TrackOutput(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,7, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? TrackOutput
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,7, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_CurrentOutbias(ref System.Single value)
    {
      if (accessorService == null)
        return false;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,8, ref var);
      if (ret) value = (System.Single) var;
      return ret;
    }

    public System.Single? CurrentOutbias
    { get {
      if (accessorService == null)
        return null;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,8, ref var);
      if (!ret) return null;
      return (System.Single) var;
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

    public bool Get_StdOwnerConnected(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,10, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? StdOwnerConnected
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


  }

  public class UPD_CFGEventArgs : System.EventArgs
  {
    IHMIAccessorService accessorService;
    int channelId;
    int cookie; 
    int eventIndex;

    public UPD_CFGEventArgs(int channelId, int cookie, int eventIndex)
    {
      this.accessorService = (IHMIAccessorService)ServiceProvider.GetService(typeof(IHMIAccessorService));
      this.channelId = channelId;
      this.cookie = cookie;
      this.eventIndex = eventIndex;
    }
    public bool Get_ExtParaSel(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,0, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? ExtParaSel
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,0, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_CurrentGain(ref System.Single value)
    {
      if (accessorService == null)
        return false;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,1, ref var);
      if (ret) value = (System.Single) var;
      return ret;
    }

    public System.Single? CurrentGain
    { get {
      if (accessorService == null)
        return null;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,1, ref var);
      if (!ret) return null;
      return (System.Single) var;
    }  }

    public bool Get_CurrentIntegralTime(ref System.Single value)
    {
      if (accessorService == null)
        return false;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,2, ref var);
      if (ret) value = (System.Single) var;
      return ret;
    }

    public System.Single? CurrentIntegralTime
    { get {
      if (accessorService == null)
        return null;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,2, ref var);
      if (!ret) return null;
      return (System.Single) var;
    }  }

    public bool Get_CurrentDerivativeTime(ref System.Single value)
    {
      if (accessorService == null)
        return false;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,3, ref var);
      if (ret) value = (System.Single) var;
      return ret;
    }

    public System.Single? CurrentDerivativeTime
    { get {
      if (accessorService == null)
        return null;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,3, ref var);
      if (!ret) return null;
      return (System.Single) var;
    }  }

    public bool Get_CurrentLagTime(ref System.Single value)
    {
      if (accessorService == null)
        return false;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,4, ref var);
      if (ret) value = (System.Single) var;
      return ret;
    }

    public System.Single? CurrentLagTime
    { get {
      if (accessorService == null)
        return null;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,4, ref var);
      if (!ret) return null;
      return (System.Single) var;
    }  }

    public bool Get_CurrentDeadBand(ref System.Single value)
    {
      if (accessorService == null)
        return false;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,5, ref var);
      if (ret) value = (System.Single) var;
      return ret;
    }

    public System.Single? CurrentDeadBand
    { get {
      if (accessorService == null)
        return null;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,5, ref var);
      if (!ret) return null;
      return (System.Single) var;
    }  }

    public bool Get_CurrentOutMin(ref System.Single value)
    {
      if (accessorService == null)
        return false;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,6, ref var);
      if (ret) value = (System.Single) var;
      return ret;
    }

    public System.Single? CurrentOutMin
    { get {
      if (accessorService == null)
        return null;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,6, ref var);
      if (!ret) return null;
      return (System.Single) var;
    }  }

    public bool Get_CurrentOutMax(ref System.Single value)
    {
      if (accessorService == null)
        return false;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,7, ref var);
      if (ret) value = (System.Single) var;
      return ret;
    }

    public System.Single? CurrentOutMax
    { get {
      if (accessorService == null)
        return null;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,7, ref var);
      if (!ret) return null;
      return (System.Single) var;
    }  }

    public bool Get_CurrentDWorkOnError(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,8, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? CurrentDWorkOnError
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,8, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_CurrentDirection(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,9, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? CurrentDirection
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,9, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }


  }

}

namespace HMI.Main.Symbols.PIDBase
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

  public class SP_CMDEventArgs : System.EventArgs
  {
    public SP_CMDEventArgs()
    {
    }
    private System.Single? Sp_field = null;
    public System.Single? Sp
    {
       get { return Sp_field; }
       set { Sp_field = value; }
    }

  }

  public class MANUAL_CMDEventArgs : System.EventArgs
  {
    public MANUAL_CMDEventArgs()
    {
    }
    private System.Single? ManualSp_field = null;
    public System.Single? ManualSp
    {
       get { return ManualSp_field; }
       set { ManualSp_field = value; }
    }

  }

  public class CFGEventArgs : System.EventArgs
  {
    public CFGEventArgs()
    {
    }
    private System.Single? OutMin_field = null;
    public System.Single? OutMin
    {
       get { return OutMin_field; }
       set { OutMin_field = value; }
    }
    private System.Single? OutMax_field = null;
    public System.Single? OutMax
    {
       get { return OutMax_field; }
       set { OutMax_field = value; }
    }
    private System.Boolean? Bump_field = null;
    public System.Boolean? Bump
    {
       get { return Bump_field; }
       set { Bump_field = value; }
    }
    private System.Single? SpRateUp_field = null;
    public System.Single? SpRateUp
    {
       get { return SpRateUp_field; }
       set { SpRateUp_field = value; }
    }
    private System.Single? SpRateDown_field = null;
    public System.Single? SpRateDown
    {
       get { return SpRateDown_field; }
       set { SpRateDown_field = value; }
    }
    private System.Boolean? TrackSpInManual_field = null;
    public System.Boolean? TrackSpInManual
    {
       get { return TrackSpInManual_field; }
       set { TrackSpInManual_field = value; }
    }
    private System.Single? OutRate_field = null;
    public System.Single? OutRate
    {
       get { return OutRate_field; }
       set { OutRate_field = value; }
    }
    private System.Single? GainKp_field = null;
    public System.Single? GainKp
    {
       get { return GainKp_field; }
       set { GainKp_field = value; }
    }
    private System.Single? OvsAtt_field = null;
    public System.Single? OvsAtt
    {
       get { return OvsAtt_field; }
       set { OvsAtt_field = value; }
    }

  }

  public class PID_CFGEventArgs : System.EventArgs
  {
    public PID_CFGEventArgs()
    {
    }
    private System.Single? Gain_field = null;
    public System.Single? Gain
    {
       get { return Gain_field; }
       set { Gain_field = value; }
    }
    private System.Single? DerivativeTime_field = null;
    public System.Single? DerivativeTime
    {
       get { return DerivativeTime_field; }
       set { DerivativeTime_field = value; }
    }
    private System.Single? IntegralTime_field = null;
    public System.Single? IntegralTime
    {
       get { return IntegralTime_field; }
       set { IntegralTime_field = value; }
    }
    private System.Int16? Mode_field = null;
    public System.Int16? Mode
    {
       get { return Mode_field; }
       set { Mode_field = value; }
    }
    private System.Single? LagTime_field = null;
    public System.Single? LagTime
    {
       get { return LagTime_field; }
       set { LagTime_field = value; }
    }
    private System.Single? DeadBand_field = null;
    public System.Single? DeadBand
    {
       get { return DeadBand_field; }
       set { DeadBand_field = value; }
    }
    private System.Boolean? Direction_field = null;
    public System.Boolean? Direction
    {
       get { return Direction_field; }
       set { Direction_field = value; }
    }
    private System.Int32? CycleTime_field = null;
    public System.Int32? CycleTime
    {
       get { return CycleTime_field; }
       set { CycleTime_field = value; }
    }
    private System.Boolean? DWorkOnError_field = null;
    public System.Boolean? DWorkOnError
    {
       get { return DWorkOnError_field; }
       set { DWorkOnError_field = value; }
    }
    private System.Boolean? EnFeedFwd_field = null;
    public System.Boolean? EnFeedFwd
    {
       get { return EnFeedFwd_field; }
       set { EnFeedFwd_field = value; }
    }
    private System.Single? FeedFwdGain_field = null;
    public System.Single? FeedFwdGain
    {
       get { return FeedFwdGain_field; }
       set { FeedFwdGain_field = value; }
    }

  }

  public class OUTBIAS_CFGEventArgs : System.EventArgs
  {
    public OUTBIAS_CFGEventArgs()
    {
    }
    private System.Single? OutBias_field = null;
    public System.Single? OutBias
    {
       get { return OutBias_field; }
       set { OutBias_field = value; }
    }

  }

}

namespace HMI.Main.Symbols.PIDBase
{
  partial class sBarPvSpOpHoriz
  {

    private event EventHandler<HMI.Main.Symbols.PIDBase.UPDEventArgs> UPD_Fired;

    private event EventHandler<HMI.Main.Symbols.PIDBase.UPD_CFGEventArgs> UPD_CFG_Fired;

    protected override void OnEndInit()
    {
      if (UPD_Fired != null)
        AttachEventInput(0);
      if (UPD_CFG_Fired != null)
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
              UPD_Fired(this, new HMI.Main.Symbols.PIDBase.UPDEventArgs(channelId, cookie, eventIndex));
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
          if (UPD_CFG_Fired != null)
          {
            try
            {
              UPD_CFG_Fired(this, new HMI.Main.Symbols.PIDBase.UPD_CFGEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","UPD_CFG_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_OWNER(System.UInt16 Owner)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {Owner});
    }
    public bool FireEvent_OWNER(HMI.Main.Symbols.PIDBase.OWNEREventArgs ea)
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
    public bool FireEvent_SP_CMD(System.Single Sp)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {Sp});
    }
    public bool FireEvent_SP_CMD(HMI.Main.Symbols.PIDBase.SP_CMDEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.Sp.HasValue) _values_[0] = ea.Sp.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_SP_CMD(System.Single Sp, bool ignore_Sp)
    {
      object[] _values_ = new object[1];
      if (!ignore_Sp) _values_[0] = Sp;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_MANUAL_CMD(System.Single ManualSp)
    {
      return ((IHMIAccessorOutput)this).FireEvent(2, new object[] {ManualSp});
    }
    public bool FireEvent_MANUAL_CMD(HMI.Main.Symbols.PIDBase.MANUAL_CMDEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.ManualSp.HasValue) _values_[0] = ea.ManualSp.Value;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_MANUAL_CMD(System.Single ManualSp, bool ignore_ManualSp)
    {
      object[] _values_ = new object[1];
      if (!ignore_ManualSp) _values_[0] = ManualSp;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_CFG(System.Single OutMin, System.Single OutMax, System.Boolean Bump, System.Single SpRateUp, System.Single SpRateDown, System.Boolean TrackSpInManual, System.Single OutRate, System.Single GainKp, System.Single OvsAtt)
    {
      return ((IHMIAccessorOutput)this).FireEvent(3, new object[] {OutMin, OutMax, Bump, SpRateUp, SpRateDown, TrackSpInManual, OutRate, GainKp, OvsAtt});
    }
    public bool FireEvent_CFG(HMI.Main.Symbols.PIDBase.CFGEventArgs ea)
    {
      object[] _values_ = new object[9];
      if (ea.OutMin.HasValue) _values_[0] = ea.OutMin.Value;
      if (ea.OutMax.HasValue) _values_[1] = ea.OutMax.Value;
      if (ea.Bump.HasValue) _values_[2] = ea.Bump.Value;
      if (ea.SpRateUp.HasValue) _values_[3] = ea.SpRateUp.Value;
      if (ea.SpRateDown.HasValue) _values_[4] = ea.SpRateDown.Value;
      if (ea.TrackSpInManual.HasValue) _values_[5] = ea.TrackSpInManual.Value;
      if (ea.OutRate.HasValue) _values_[6] = ea.OutRate.Value;
      if (ea.GainKp.HasValue) _values_[7] = ea.GainKp.Value;
      if (ea.OvsAtt.HasValue) _values_[8] = ea.OvsAtt.Value;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_CFG(System.Single OutMin, bool ignore_OutMin, System.Single OutMax, bool ignore_OutMax, System.Boolean Bump, bool ignore_Bump, System.Single SpRateUp, bool ignore_SpRateUp, System.Single SpRateDown, bool ignore_SpRateDown, System.Boolean TrackSpInManual, bool ignore_TrackSpInManual, System.Single OutRate, bool ignore_OutRate, System.Single GainKp, bool ignore_GainKp, System.Single OvsAtt, bool ignore_OvsAtt)
    {
      object[] _values_ = new object[9];
      if (!ignore_OutMin) _values_[0] = OutMin;
      if (!ignore_OutMax) _values_[1] = OutMax;
      if (!ignore_Bump) _values_[2] = Bump;
      if (!ignore_SpRateUp) _values_[3] = SpRateUp;
      if (!ignore_SpRateDown) _values_[4] = SpRateDown;
      if (!ignore_TrackSpInManual) _values_[5] = TrackSpInManual;
      if (!ignore_OutRate) _values_[6] = OutRate;
      if (!ignore_GainKp) _values_[7] = GainKp;
      if (!ignore_OvsAtt) _values_[8] = OvsAtt;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_PID_CFG(System.Single Gain, System.Single DerivativeTime, System.Single IntegralTime, System.Int16 Mode, System.Single LagTime, System.Single DeadBand, System.Boolean Direction, System.Int32 CycleTime, System.Boolean DWorkOnError, System.Boolean EnFeedFwd, System.Single FeedFwdGain)
    {
      return ((IHMIAccessorOutput)this).FireEvent(4, new object[] {Gain, DerivativeTime, IntegralTime, Mode, LagTime, DeadBand, Direction, CycleTime, DWorkOnError, EnFeedFwd, FeedFwdGain});
    }
    public bool FireEvent_PID_CFG(HMI.Main.Symbols.PIDBase.PID_CFGEventArgs ea)
    {
      object[] _values_ = new object[11];
      if (ea.Gain.HasValue) _values_[0] = ea.Gain.Value;
      if (ea.DerivativeTime.HasValue) _values_[1] = ea.DerivativeTime.Value;
      if (ea.IntegralTime.HasValue) _values_[2] = ea.IntegralTime.Value;
      if (ea.Mode.HasValue) _values_[3] = ea.Mode.Value;
      if (ea.LagTime.HasValue) _values_[4] = ea.LagTime.Value;
      if (ea.DeadBand.HasValue) _values_[5] = ea.DeadBand.Value;
      if (ea.Direction.HasValue) _values_[6] = ea.Direction.Value;
      if (ea.CycleTime.HasValue) _values_[7] = ea.CycleTime.Value;
      if (ea.DWorkOnError.HasValue) _values_[8] = ea.DWorkOnError.Value;
      if (ea.EnFeedFwd.HasValue) _values_[9] = ea.EnFeedFwd.Value;
      if (ea.FeedFwdGain.HasValue) _values_[10] = ea.FeedFwdGain.Value;
      return ((IHMIAccessorOutput)this).FireEvent(4, _values_);
    }
    public bool FireEvent_PID_CFG(System.Single Gain, bool ignore_Gain, System.Single DerivativeTime, bool ignore_DerivativeTime, System.Single IntegralTime, bool ignore_IntegralTime, System.Int16 Mode, bool ignore_Mode, System.Single LagTime, bool ignore_LagTime, System.Single DeadBand, bool ignore_DeadBand, System.Boolean Direction, bool ignore_Direction, System.Int32 CycleTime, bool ignore_CycleTime, System.Boolean DWorkOnError, bool ignore_DWorkOnError, System.Boolean EnFeedFwd, bool ignore_EnFeedFwd, System.Single FeedFwdGain, bool ignore_FeedFwdGain)
    {
      object[] _values_ = new object[11];
      if (!ignore_Gain) _values_[0] = Gain;
      if (!ignore_DerivativeTime) _values_[1] = DerivativeTime;
      if (!ignore_IntegralTime) _values_[2] = IntegralTime;
      if (!ignore_Mode) _values_[3] = Mode;
      if (!ignore_LagTime) _values_[4] = LagTime;
      if (!ignore_DeadBand) _values_[5] = DeadBand;
      if (!ignore_Direction) _values_[6] = Direction;
      if (!ignore_CycleTime) _values_[7] = CycleTime;
      if (!ignore_DWorkOnError) _values_[8] = DWorkOnError;
      if (!ignore_EnFeedFwd) _values_[9] = EnFeedFwd;
      if (!ignore_FeedFwdGain) _values_[10] = FeedFwdGain;
      return ((IHMIAccessorOutput)this).FireEvent(4, _values_);
    }
    public bool FireEvent_OUTBIAS_CFG(System.Single OutBias)
    {
      return ((IHMIAccessorOutput)this).FireEvent(5, new object[] {OutBias});
    }
    public bool FireEvent_OUTBIAS_CFG(HMI.Main.Symbols.PIDBase.OUTBIAS_CFGEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.OutBias.HasValue) _values_[0] = ea.OutBias.Value;
      return ((IHMIAccessorOutput)this).FireEvent(5, _values_);
    }
    public bool FireEvent_OUTBIAS_CFG(System.Single OutBias, bool ignore_OutBias)
    {
      object[] _values_ = new object[1];
      if (!ignore_OutBias) _values_[0] = OutBias;
      return ((IHMIAccessorOutput)this).FireEvent(5, _values_);
    }

  }
}

namespace HMI.Main.Symbols.PIDBase
{
  partial class sBarPvSpOpVert
  {

    private event EventHandler<HMI.Main.Symbols.PIDBase.UPDEventArgs> UPD_Fired;

    private event EventHandler<HMI.Main.Symbols.PIDBase.UPD_CFGEventArgs> UPD_CFG_Fired;

    protected override void OnEndInit()
    {
      if (UPD_Fired != null)
        AttachEventInput(0);
      if (UPD_CFG_Fired != null)
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
              UPD_Fired(this, new HMI.Main.Symbols.PIDBase.UPDEventArgs(channelId, cookie, eventIndex));
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
          if (UPD_CFG_Fired != null)
          {
            try
            {
              UPD_CFG_Fired(this, new HMI.Main.Symbols.PIDBase.UPD_CFGEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","UPD_CFG_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_OWNER(System.UInt16 Owner)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {Owner});
    }
    public bool FireEvent_OWNER(HMI.Main.Symbols.PIDBase.OWNEREventArgs ea)
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
    public bool FireEvent_SP_CMD(System.Single Sp)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {Sp});
    }
    public bool FireEvent_SP_CMD(HMI.Main.Symbols.PIDBase.SP_CMDEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.Sp.HasValue) _values_[0] = ea.Sp.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_SP_CMD(System.Single Sp, bool ignore_Sp)
    {
      object[] _values_ = new object[1];
      if (!ignore_Sp) _values_[0] = Sp;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_MANUAL_CMD(System.Single ManualSp)
    {
      return ((IHMIAccessorOutput)this).FireEvent(2, new object[] {ManualSp});
    }
    public bool FireEvent_MANUAL_CMD(HMI.Main.Symbols.PIDBase.MANUAL_CMDEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.ManualSp.HasValue) _values_[0] = ea.ManualSp.Value;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_MANUAL_CMD(System.Single ManualSp, bool ignore_ManualSp)
    {
      object[] _values_ = new object[1];
      if (!ignore_ManualSp) _values_[0] = ManualSp;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_CFG(System.Single OutMin, System.Single OutMax, System.Boolean Bump, System.Single SpRateUp, System.Single SpRateDown, System.Boolean TrackSpInManual, System.Single OutRate, System.Single GainKp, System.Single OvsAtt)
    {
      return ((IHMIAccessorOutput)this).FireEvent(3, new object[] {OutMin, OutMax, Bump, SpRateUp, SpRateDown, TrackSpInManual, OutRate, GainKp, OvsAtt});
    }
    public bool FireEvent_CFG(HMI.Main.Symbols.PIDBase.CFGEventArgs ea)
    {
      object[] _values_ = new object[9];
      if (ea.OutMin.HasValue) _values_[0] = ea.OutMin.Value;
      if (ea.OutMax.HasValue) _values_[1] = ea.OutMax.Value;
      if (ea.Bump.HasValue) _values_[2] = ea.Bump.Value;
      if (ea.SpRateUp.HasValue) _values_[3] = ea.SpRateUp.Value;
      if (ea.SpRateDown.HasValue) _values_[4] = ea.SpRateDown.Value;
      if (ea.TrackSpInManual.HasValue) _values_[5] = ea.TrackSpInManual.Value;
      if (ea.OutRate.HasValue) _values_[6] = ea.OutRate.Value;
      if (ea.GainKp.HasValue) _values_[7] = ea.GainKp.Value;
      if (ea.OvsAtt.HasValue) _values_[8] = ea.OvsAtt.Value;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_CFG(System.Single OutMin, bool ignore_OutMin, System.Single OutMax, bool ignore_OutMax, System.Boolean Bump, bool ignore_Bump, System.Single SpRateUp, bool ignore_SpRateUp, System.Single SpRateDown, bool ignore_SpRateDown, System.Boolean TrackSpInManual, bool ignore_TrackSpInManual, System.Single OutRate, bool ignore_OutRate, System.Single GainKp, bool ignore_GainKp, System.Single OvsAtt, bool ignore_OvsAtt)
    {
      object[] _values_ = new object[9];
      if (!ignore_OutMin) _values_[0] = OutMin;
      if (!ignore_OutMax) _values_[1] = OutMax;
      if (!ignore_Bump) _values_[2] = Bump;
      if (!ignore_SpRateUp) _values_[3] = SpRateUp;
      if (!ignore_SpRateDown) _values_[4] = SpRateDown;
      if (!ignore_TrackSpInManual) _values_[5] = TrackSpInManual;
      if (!ignore_OutRate) _values_[6] = OutRate;
      if (!ignore_GainKp) _values_[7] = GainKp;
      if (!ignore_OvsAtt) _values_[8] = OvsAtt;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_PID_CFG(System.Single Gain, System.Single DerivativeTime, System.Single IntegralTime, System.Int16 Mode, System.Single LagTime, System.Single DeadBand, System.Boolean Direction, System.Int32 CycleTime, System.Boolean DWorkOnError, System.Boolean EnFeedFwd, System.Single FeedFwdGain)
    {
      return ((IHMIAccessorOutput)this).FireEvent(4, new object[] {Gain, DerivativeTime, IntegralTime, Mode, LagTime, DeadBand, Direction, CycleTime, DWorkOnError, EnFeedFwd, FeedFwdGain});
    }
    public bool FireEvent_PID_CFG(HMI.Main.Symbols.PIDBase.PID_CFGEventArgs ea)
    {
      object[] _values_ = new object[11];
      if (ea.Gain.HasValue) _values_[0] = ea.Gain.Value;
      if (ea.DerivativeTime.HasValue) _values_[1] = ea.DerivativeTime.Value;
      if (ea.IntegralTime.HasValue) _values_[2] = ea.IntegralTime.Value;
      if (ea.Mode.HasValue) _values_[3] = ea.Mode.Value;
      if (ea.LagTime.HasValue) _values_[4] = ea.LagTime.Value;
      if (ea.DeadBand.HasValue) _values_[5] = ea.DeadBand.Value;
      if (ea.Direction.HasValue) _values_[6] = ea.Direction.Value;
      if (ea.CycleTime.HasValue) _values_[7] = ea.CycleTime.Value;
      if (ea.DWorkOnError.HasValue) _values_[8] = ea.DWorkOnError.Value;
      if (ea.EnFeedFwd.HasValue) _values_[9] = ea.EnFeedFwd.Value;
      if (ea.FeedFwdGain.HasValue) _values_[10] = ea.FeedFwdGain.Value;
      return ((IHMIAccessorOutput)this).FireEvent(4, _values_);
    }
    public bool FireEvent_PID_CFG(System.Single Gain, bool ignore_Gain, System.Single DerivativeTime, bool ignore_DerivativeTime, System.Single IntegralTime, bool ignore_IntegralTime, System.Int16 Mode, bool ignore_Mode, System.Single LagTime, bool ignore_LagTime, System.Single DeadBand, bool ignore_DeadBand, System.Boolean Direction, bool ignore_Direction, System.Int32 CycleTime, bool ignore_CycleTime, System.Boolean DWorkOnError, bool ignore_DWorkOnError, System.Boolean EnFeedFwd, bool ignore_EnFeedFwd, System.Single FeedFwdGain, bool ignore_FeedFwdGain)
    {
      object[] _values_ = new object[11];
      if (!ignore_Gain) _values_[0] = Gain;
      if (!ignore_DerivativeTime) _values_[1] = DerivativeTime;
      if (!ignore_IntegralTime) _values_[2] = IntegralTime;
      if (!ignore_Mode) _values_[3] = Mode;
      if (!ignore_LagTime) _values_[4] = LagTime;
      if (!ignore_DeadBand) _values_[5] = DeadBand;
      if (!ignore_Direction) _values_[6] = Direction;
      if (!ignore_CycleTime) _values_[7] = CycleTime;
      if (!ignore_DWorkOnError) _values_[8] = DWorkOnError;
      if (!ignore_EnFeedFwd) _values_[9] = EnFeedFwd;
      if (!ignore_FeedFwdGain) _values_[10] = FeedFwdGain;
      return ((IHMIAccessorOutput)this).FireEvent(4, _values_);
    }
    public bool FireEvent_OUTBIAS_CFG(System.Single OutBias)
    {
      return ((IHMIAccessorOutput)this).FireEvent(5, new object[] {OutBias});
    }
    public bool FireEvent_OUTBIAS_CFG(HMI.Main.Symbols.PIDBase.OUTBIAS_CFGEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.OutBias.HasValue) _values_[0] = ea.OutBias.Value;
      return ((IHMIAccessorOutput)this).FireEvent(5, _values_);
    }
    public bool FireEvent_OUTBIAS_CFG(System.Single OutBias, bool ignore_OutBias)
    {
      object[] _values_ = new object[1];
      if (!ignore_OutBias) _values_[0] = OutBias;
      return ((IHMIAccessorOutput)this).FireEvent(5, _values_);
    }

  }
}

namespace HMI.Main.Symbols.PIDBase
{
  partial class sDisplayPvSpOp
  {

    private event EventHandler<HMI.Main.Symbols.PIDBase.UPDEventArgs> UPD_Fired;

    private event EventHandler<HMI.Main.Symbols.PIDBase.UPD_CFGEventArgs> UPD_CFG_Fired;

    protected override void OnEndInit()
    {
      if (UPD_Fired != null)
        AttachEventInput(0);
      if (UPD_CFG_Fired != null)
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
              UPD_Fired(this, new HMI.Main.Symbols.PIDBase.UPDEventArgs(channelId, cookie, eventIndex));
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
          if (UPD_CFG_Fired != null)
          {
            try
            {
              UPD_CFG_Fired(this, new HMI.Main.Symbols.PIDBase.UPD_CFGEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","UPD_CFG_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_OWNER(System.UInt16 Owner)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {Owner});
    }
    public bool FireEvent_OWNER(HMI.Main.Symbols.PIDBase.OWNEREventArgs ea)
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
    public bool FireEvent_SP_CMD(System.Single Sp)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {Sp});
    }
    public bool FireEvent_SP_CMD(HMI.Main.Symbols.PIDBase.SP_CMDEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.Sp.HasValue) _values_[0] = ea.Sp.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_SP_CMD(System.Single Sp, bool ignore_Sp)
    {
      object[] _values_ = new object[1];
      if (!ignore_Sp) _values_[0] = Sp;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_MANUAL_CMD(System.Single ManualSp)
    {
      return ((IHMIAccessorOutput)this).FireEvent(2, new object[] {ManualSp});
    }
    public bool FireEvent_MANUAL_CMD(HMI.Main.Symbols.PIDBase.MANUAL_CMDEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.ManualSp.HasValue) _values_[0] = ea.ManualSp.Value;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_MANUAL_CMD(System.Single ManualSp, bool ignore_ManualSp)
    {
      object[] _values_ = new object[1];
      if (!ignore_ManualSp) _values_[0] = ManualSp;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_CFG(System.Single OutMin, System.Single OutMax, System.Boolean Bump, System.Single SpRateUp, System.Single SpRateDown, System.Boolean TrackSpInManual, System.Single OutRate, System.Single GainKp, System.Single OvsAtt)
    {
      return ((IHMIAccessorOutput)this).FireEvent(3, new object[] {OutMin, OutMax, Bump, SpRateUp, SpRateDown, TrackSpInManual, OutRate, GainKp, OvsAtt});
    }
    public bool FireEvent_CFG(HMI.Main.Symbols.PIDBase.CFGEventArgs ea)
    {
      object[] _values_ = new object[9];
      if (ea.OutMin.HasValue) _values_[0] = ea.OutMin.Value;
      if (ea.OutMax.HasValue) _values_[1] = ea.OutMax.Value;
      if (ea.Bump.HasValue) _values_[2] = ea.Bump.Value;
      if (ea.SpRateUp.HasValue) _values_[3] = ea.SpRateUp.Value;
      if (ea.SpRateDown.HasValue) _values_[4] = ea.SpRateDown.Value;
      if (ea.TrackSpInManual.HasValue) _values_[5] = ea.TrackSpInManual.Value;
      if (ea.OutRate.HasValue) _values_[6] = ea.OutRate.Value;
      if (ea.GainKp.HasValue) _values_[7] = ea.GainKp.Value;
      if (ea.OvsAtt.HasValue) _values_[8] = ea.OvsAtt.Value;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_CFG(System.Single OutMin, bool ignore_OutMin, System.Single OutMax, bool ignore_OutMax, System.Boolean Bump, bool ignore_Bump, System.Single SpRateUp, bool ignore_SpRateUp, System.Single SpRateDown, bool ignore_SpRateDown, System.Boolean TrackSpInManual, bool ignore_TrackSpInManual, System.Single OutRate, bool ignore_OutRate, System.Single GainKp, bool ignore_GainKp, System.Single OvsAtt, bool ignore_OvsAtt)
    {
      object[] _values_ = new object[9];
      if (!ignore_OutMin) _values_[0] = OutMin;
      if (!ignore_OutMax) _values_[1] = OutMax;
      if (!ignore_Bump) _values_[2] = Bump;
      if (!ignore_SpRateUp) _values_[3] = SpRateUp;
      if (!ignore_SpRateDown) _values_[4] = SpRateDown;
      if (!ignore_TrackSpInManual) _values_[5] = TrackSpInManual;
      if (!ignore_OutRate) _values_[6] = OutRate;
      if (!ignore_GainKp) _values_[7] = GainKp;
      if (!ignore_OvsAtt) _values_[8] = OvsAtt;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_PID_CFG(System.Single Gain, System.Single DerivativeTime, System.Single IntegralTime, System.Int16 Mode, System.Single LagTime, System.Single DeadBand, System.Boolean Direction, System.Int32 CycleTime, System.Boolean DWorkOnError, System.Boolean EnFeedFwd, System.Single FeedFwdGain)
    {
      return ((IHMIAccessorOutput)this).FireEvent(4, new object[] {Gain, DerivativeTime, IntegralTime, Mode, LagTime, DeadBand, Direction, CycleTime, DWorkOnError, EnFeedFwd, FeedFwdGain});
    }
    public bool FireEvent_PID_CFG(HMI.Main.Symbols.PIDBase.PID_CFGEventArgs ea)
    {
      object[] _values_ = new object[11];
      if (ea.Gain.HasValue) _values_[0] = ea.Gain.Value;
      if (ea.DerivativeTime.HasValue) _values_[1] = ea.DerivativeTime.Value;
      if (ea.IntegralTime.HasValue) _values_[2] = ea.IntegralTime.Value;
      if (ea.Mode.HasValue) _values_[3] = ea.Mode.Value;
      if (ea.LagTime.HasValue) _values_[4] = ea.LagTime.Value;
      if (ea.DeadBand.HasValue) _values_[5] = ea.DeadBand.Value;
      if (ea.Direction.HasValue) _values_[6] = ea.Direction.Value;
      if (ea.CycleTime.HasValue) _values_[7] = ea.CycleTime.Value;
      if (ea.DWorkOnError.HasValue) _values_[8] = ea.DWorkOnError.Value;
      if (ea.EnFeedFwd.HasValue) _values_[9] = ea.EnFeedFwd.Value;
      if (ea.FeedFwdGain.HasValue) _values_[10] = ea.FeedFwdGain.Value;
      return ((IHMIAccessorOutput)this).FireEvent(4, _values_);
    }
    public bool FireEvent_PID_CFG(System.Single Gain, bool ignore_Gain, System.Single DerivativeTime, bool ignore_DerivativeTime, System.Single IntegralTime, bool ignore_IntegralTime, System.Int16 Mode, bool ignore_Mode, System.Single LagTime, bool ignore_LagTime, System.Single DeadBand, bool ignore_DeadBand, System.Boolean Direction, bool ignore_Direction, System.Int32 CycleTime, bool ignore_CycleTime, System.Boolean DWorkOnError, bool ignore_DWorkOnError, System.Boolean EnFeedFwd, bool ignore_EnFeedFwd, System.Single FeedFwdGain, bool ignore_FeedFwdGain)
    {
      object[] _values_ = new object[11];
      if (!ignore_Gain) _values_[0] = Gain;
      if (!ignore_DerivativeTime) _values_[1] = DerivativeTime;
      if (!ignore_IntegralTime) _values_[2] = IntegralTime;
      if (!ignore_Mode) _values_[3] = Mode;
      if (!ignore_LagTime) _values_[4] = LagTime;
      if (!ignore_DeadBand) _values_[5] = DeadBand;
      if (!ignore_Direction) _values_[6] = Direction;
      if (!ignore_CycleTime) _values_[7] = CycleTime;
      if (!ignore_DWorkOnError) _values_[8] = DWorkOnError;
      if (!ignore_EnFeedFwd) _values_[9] = EnFeedFwd;
      if (!ignore_FeedFwdGain) _values_[10] = FeedFwdGain;
      return ((IHMIAccessorOutput)this).FireEvent(4, _values_);
    }
    public bool FireEvent_OUTBIAS_CFG(System.Single OutBias)
    {
      return ((IHMIAccessorOutput)this).FireEvent(5, new object[] {OutBias});
    }
    public bool FireEvent_OUTBIAS_CFG(HMI.Main.Symbols.PIDBase.OUTBIAS_CFGEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.OutBias.HasValue) _values_[0] = ea.OutBias.Value;
      return ((IHMIAccessorOutput)this).FireEvent(5, _values_);
    }
    public bool FireEvent_OUTBIAS_CFG(System.Single OutBias, bool ignore_OutBias)
    {
      object[] _values_ = new object[1];
      if (!ignore_OutBias) _values_[0] = OutBias;
      return ((IHMIAccessorOutput)this).FireEvent(5, _values_);
    }

  }
}

namespace HMI.Main.Faceplates.PIDBase
{
  partial class fpDefault
  {

    private event EventHandler<HMI.Main.Symbols.PIDBase.UPDEventArgs> UPD_Fired;

    private event EventHandler<HMI.Main.Symbols.PIDBase.UPD_CFGEventArgs> UPD_CFG_Fired;

    protected override void OnEndInit()
    {
      if (UPD_Fired != null)
        AttachEventInput(0);
      if (UPD_CFG_Fired != null)
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
              UPD_Fired(this, new HMI.Main.Symbols.PIDBase.UPDEventArgs(channelId, cookie, eventIndex));
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
          if (UPD_CFG_Fired != null)
          {
            try
            {
              UPD_CFG_Fired(this, new HMI.Main.Symbols.PIDBase.UPD_CFGEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","UPD_CFG_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_OWNER(System.UInt16 Owner)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {Owner});
    }
    public bool FireEvent_OWNER(HMI.Main.Symbols.PIDBase.OWNEREventArgs ea)
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
    public bool FireEvent_SP_CMD(System.Single Sp)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {Sp});
    }
    public bool FireEvent_SP_CMD(HMI.Main.Symbols.PIDBase.SP_CMDEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.Sp.HasValue) _values_[0] = ea.Sp.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_SP_CMD(System.Single Sp, bool ignore_Sp)
    {
      object[] _values_ = new object[1];
      if (!ignore_Sp) _values_[0] = Sp;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_MANUAL_CMD(System.Single ManualSp)
    {
      return ((IHMIAccessorOutput)this).FireEvent(2, new object[] {ManualSp});
    }
    public bool FireEvent_MANUAL_CMD(HMI.Main.Symbols.PIDBase.MANUAL_CMDEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.ManualSp.HasValue) _values_[0] = ea.ManualSp.Value;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_MANUAL_CMD(System.Single ManualSp, bool ignore_ManualSp)
    {
      object[] _values_ = new object[1];
      if (!ignore_ManualSp) _values_[0] = ManualSp;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_CFG(System.Single OutMin, System.Single OutMax, System.Boolean Bump, System.Single SpRateUp, System.Single SpRateDown, System.Boolean TrackSpInManual, System.Single OutRate, System.Single GainKp, System.Single OvsAtt)
    {
      return ((IHMIAccessorOutput)this).FireEvent(3, new object[] {OutMin, OutMax, Bump, SpRateUp, SpRateDown, TrackSpInManual, OutRate, GainKp, OvsAtt});
    }
    public bool FireEvent_CFG(HMI.Main.Symbols.PIDBase.CFGEventArgs ea)
    {
      object[] _values_ = new object[9];
      if (ea.OutMin.HasValue) _values_[0] = ea.OutMin.Value;
      if (ea.OutMax.HasValue) _values_[1] = ea.OutMax.Value;
      if (ea.Bump.HasValue) _values_[2] = ea.Bump.Value;
      if (ea.SpRateUp.HasValue) _values_[3] = ea.SpRateUp.Value;
      if (ea.SpRateDown.HasValue) _values_[4] = ea.SpRateDown.Value;
      if (ea.TrackSpInManual.HasValue) _values_[5] = ea.TrackSpInManual.Value;
      if (ea.OutRate.HasValue) _values_[6] = ea.OutRate.Value;
      if (ea.GainKp.HasValue) _values_[7] = ea.GainKp.Value;
      if (ea.OvsAtt.HasValue) _values_[8] = ea.OvsAtt.Value;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_CFG(System.Single OutMin, bool ignore_OutMin, System.Single OutMax, bool ignore_OutMax, System.Boolean Bump, bool ignore_Bump, System.Single SpRateUp, bool ignore_SpRateUp, System.Single SpRateDown, bool ignore_SpRateDown, System.Boolean TrackSpInManual, bool ignore_TrackSpInManual, System.Single OutRate, bool ignore_OutRate, System.Single GainKp, bool ignore_GainKp, System.Single OvsAtt, bool ignore_OvsAtt)
    {
      object[] _values_ = new object[9];
      if (!ignore_OutMin) _values_[0] = OutMin;
      if (!ignore_OutMax) _values_[1] = OutMax;
      if (!ignore_Bump) _values_[2] = Bump;
      if (!ignore_SpRateUp) _values_[3] = SpRateUp;
      if (!ignore_SpRateDown) _values_[4] = SpRateDown;
      if (!ignore_TrackSpInManual) _values_[5] = TrackSpInManual;
      if (!ignore_OutRate) _values_[6] = OutRate;
      if (!ignore_GainKp) _values_[7] = GainKp;
      if (!ignore_OvsAtt) _values_[8] = OvsAtt;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_PID_CFG(System.Single Gain, System.Single DerivativeTime, System.Single IntegralTime, System.Int16 Mode, System.Single LagTime, System.Single DeadBand, System.Boolean Direction, System.Int32 CycleTime, System.Boolean DWorkOnError, System.Boolean EnFeedFwd, System.Single FeedFwdGain)
    {
      return ((IHMIAccessorOutput)this).FireEvent(4, new object[] {Gain, DerivativeTime, IntegralTime, Mode, LagTime, DeadBand, Direction, CycleTime, DWorkOnError, EnFeedFwd, FeedFwdGain});
    }
    public bool FireEvent_PID_CFG(HMI.Main.Symbols.PIDBase.PID_CFGEventArgs ea)
    {
      object[] _values_ = new object[11];
      if (ea.Gain.HasValue) _values_[0] = ea.Gain.Value;
      if (ea.DerivativeTime.HasValue) _values_[1] = ea.DerivativeTime.Value;
      if (ea.IntegralTime.HasValue) _values_[2] = ea.IntegralTime.Value;
      if (ea.Mode.HasValue) _values_[3] = ea.Mode.Value;
      if (ea.LagTime.HasValue) _values_[4] = ea.LagTime.Value;
      if (ea.DeadBand.HasValue) _values_[5] = ea.DeadBand.Value;
      if (ea.Direction.HasValue) _values_[6] = ea.Direction.Value;
      if (ea.CycleTime.HasValue) _values_[7] = ea.CycleTime.Value;
      if (ea.DWorkOnError.HasValue) _values_[8] = ea.DWorkOnError.Value;
      if (ea.EnFeedFwd.HasValue) _values_[9] = ea.EnFeedFwd.Value;
      if (ea.FeedFwdGain.HasValue) _values_[10] = ea.FeedFwdGain.Value;
      return ((IHMIAccessorOutput)this).FireEvent(4, _values_);
    }
    public bool FireEvent_PID_CFG(System.Single Gain, bool ignore_Gain, System.Single DerivativeTime, bool ignore_DerivativeTime, System.Single IntegralTime, bool ignore_IntegralTime, System.Int16 Mode, bool ignore_Mode, System.Single LagTime, bool ignore_LagTime, System.Single DeadBand, bool ignore_DeadBand, System.Boolean Direction, bool ignore_Direction, System.Int32 CycleTime, bool ignore_CycleTime, System.Boolean DWorkOnError, bool ignore_DWorkOnError, System.Boolean EnFeedFwd, bool ignore_EnFeedFwd, System.Single FeedFwdGain, bool ignore_FeedFwdGain)
    {
      object[] _values_ = new object[11];
      if (!ignore_Gain) _values_[0] = Gain;
      if (!ignore_DerivativeTime) _values_[1] = DerivativeTime;
      if (!ignore_IntegralTime) _values_[2] = IntegralTime;
      if (!ignore_Mode) _values_[3] = Mode;
      if (!ignore_LagTime) _values_[4] = LagTime;
      if (!ignore_DeadBand) _values_[5] = DeadBand;
      if (!ignore_Direction) _values_[6] = Direction;
      if (!ignore_CycleTime) _values_[7] = CycleTime;
      if (!ignore_DWorkOnError) _values_[8] = DWorkOnError;
      if (!ignore_EnFeedFwd) _values_[9] = EnFeedFwd;
      if (!ignore_FeedFwdGain) _values_[10] = FeedFwdGain;
      return ((IHMIAccessorOutput)this).FireEvent(4, _values_);
    }
    public bool FireEvent_OUTBIAS_CFG(System.Single OutBias)
    {
      return ((IHMIAccessorOutput)this).FireEvent(5, new object[] {OutBias});
    }
    public bool FireEvent_OUTBIAS_CFG(HMI.Main.Symbols.PIDBase.OUTBIAS_CFGEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.OutBias.HasValue) _values_[0] = ea.OutBias.Value;
      return ((IHMIAccessorOutput)this).FireEvent(5, _values_);
    }
    public bool FireEvent_OUTBIAS_CFG(System.Single OutBias, bool ignore_OutBias)
    {
      object[] _values_ = new object[1];
      if (!ignore_OutBias) _values_[0] = OutBias;
      return ((IHMIAccessorOutput)this).FireEvent(5, _values_);
    }

  }
}

namespace HMI.Main.Faceplates.PIDBase
{
  partial class fpParameter
  {

    private event EventHandler<HMI.Main.Symbols.PIDBase.UPDEventArgs> UPD_Fired;

    private event EventHandler<HMI.Main.Symbols.PIDBase.UPD_CFGEventArgs> UPD_CFG_Fired;

    protected override void OnEndInit()
    {
      if (UPD_Fired != null)
        AttachEventInput(0);
      if (UPD_CFG_Fired != null)
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
              UPD_Fired(this, new HMI.Main.Symbols.PIDBase.UPDEventArgs(channelId, cookie, eventIndex));
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
          if (UPD_CFG_Fired != null)
          {
            try
            {
              UPD_CFG_Fired(this, new HMI.Main.Symbols.PIDBase.UPD_CFGEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","UPD_CFG_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_OWNER(System.UInt16 Owner)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {Owner});
    }
    public bool FireEvent_OWNER(HMI.Main.Symbols.PIDBase.OWNEREventArgs ea)
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
    public bool FireEvent_SP_CMD(System.Single Sp)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {Sp});
    }
    public bool FireEvent_SP_CMD(HMI.Main.Symbols.PIDBase.SP_CMDEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.Sp.HasValue) _values_[0] = ea.Sp.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_SP_CMD(System.Single Sp, bool ignore_Sp)
    {
      object[] _values_ = new object[1];
      if (!ignore_Sp) _values_[0] = Sp;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_MANUAL_CMD(System.Single ManualSp)
    {
      return ((IHMIAccessorOutput)this).FireEvent(2, new object[] {ManualSp});
    }
    public bool FireEvent_MANUAL_CMD(HMI.Main.Symbols.PIDBase.MANUAL_CMDEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.ManualSp.HasValue) _values_[0] = ea.ManualSp.Value;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_MANUAL_CMD(System.Single ManualSp, bool ignore_ManualSp)
    {
      object[] _values_ = new object[1];
      if (!ignore_ManualSp) _values_[0] = ManualSp;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_CFG(System.Single OutMin, System.Single OutMax, System.Boolean Bump, System.Single SpRateUp, System.Single SpRateDown, System.Boolean TrackSpInManual, System.Single OutRate, System.Single GainKp, System.Single OvsAtt)
    {
      return ((IHMIAccessorOutput)this).FireEvent(3, new object[] {OutMin, OutMax, Bump, SpRateUp, SpRateDown, TrackSpInManual, OutRate, GainKp, OvsAtt});
    }
    public bool FireEvent_CFG(HMI.Main.Symbols.PIDBase.CFGEventArgs ea)
    {
      object[] _values_ = new object[9];
      if (ea.OutMin.HasValue) _values_[0] = ea.OutMin.Value;
      if (ea.OutMax.HasValue) _values_[1] = ea.OutMax.Value;
      if (ea.Bump.HasValue) _values_[2] = ea.Bump.Value;
      if (ea.SpRateUp.HasValue) _values_[3] = ea.SpRateUp.Value;
      if (ea.SpRateDown.HasValue) _values_[4] = ea.SpRateDown.Value;
      if (ea.TrackSpInManual.HasValue) _values_[5] = ea.TrackSpInManual.Value;
      if (ea.OutRate.HasValue) _values_[6] = ea.OutRate.Value;
      if (ea.GainKp.HasValue) _values_[7] = ea.GainKp.Value;
      if (ea.OvsAtt.HasValue) _values_[8] = ea.OvsAtt.Value;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_CFG(System.Single OutMin, bool ignore_OutMin, System.Single OutMax, bool ignore_OutMax, System.Boolean Bump, bool ignore_Bump, System.Single SpRateUp, bool ignore_SpRateUp, System.Single SpRateDown, bool ignore_SpRateDown, System.Boolean TrackSpInManual, bool ignore_TrackSpInManual, System.Single OutRate, bool ignore_OutRate, System.Single GainKp, bool ignore_GainKp, System.Single OvsAtt, bool ignore_OvsAtt)
    {
      object[] _values_ = new object[9];
      if (!ignore_OutMin) _values_[0] = OutMin;
      if (!ignore_OutMax) _values_[1] = OutMax;
      if (!ignore_Bump) _values_[2] = Bump;
      if (!ignore_SpRateUp) _values_[3] = SpRateUp;
      if (!ignore_SpRateDown) _values_[4] = SpRateDown;
      if (!ignore_TrackSpInManual) _values_[5] = TrackSpInManual;
      if (!ignore_OutRate) _values_[6] = OutRate;
      if (!ignore_GainKp) _values_[7] = GainKp;
      if (!ignore_OvsAtt) _values_[8] = OvsAtt;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_PID_CFG(System.Single Gain, System.Single DerivativeTime, System.Single IntegralTime, System.Int16 Mode, System.Single LagTime, System.Single DeadBand, System.Boolean Direction, System.Int32 CycleTime, System.Boolean DWorkOnError, System.Boolean EnFeedFwd, System.Single FeedFwdGain)
    {
      return ((IHMIAccessorOutput)this).FireEvent(4, new object[] {Gain, DerivativeTime, IntegralTime, Mode, LagTime, DeadBand, Direction, CycleTime, DWorkOnError, EnFeedFwd, FeedFwdGain});
    }
    public bool FireEvent_PID_CFG(HMI.Main.Symbols.PIDBase.PID_CFGEventArgs ea)
    {
      object[] _values_ = new object[11];
      if (ea.Gain.HasValue) _values_[0] = ea.Gain.Value;
      if (ea.DerivativeTime.HasValue) _values_[1] = ea.DerivativeTime.Value;
      if (ea.IntegralTime.HasValue) _values_[2] = ea.IntegralTime.Value;
      if (ea.Mode.HasValue) _values_[3] = ea.Mode.Value;
      if (ea.LagTime.HasValue) _values_[4] = ea.LagTime.Value;
      if (ea.DeadBand.HasValue) _values_[5] = ea.DeadBand.Value;
      if (ea.Direction.HasValue) _values_[6] = ea.Direction.Value;
      if (ea.CycleTime.HasValue) _values_[7] = ea.CycleTime.Value;
      if (ea.DWorkOnError.HasValue) _values_[8] = ea.DWorkOnError.Value;
      if (ea.EnFeedFwd.HasValue) _values_[9] = ea.EnFeedFwd.Value;
      if (ea.FeedFwdGain.HasValue) _values_[10] = ea.FeedFwdGain.Value;
      return ((IHMIAccessorOutput)this).FireEvent(4, _values_);
    }
    public bool FireEvent_PID_CFG(System.Single Gain, bool ignore_Gain, System.Single DerivativeTime, bool ignore_DerivativeTime, System.Single IntegralTime, bool ignore_IntegralTime, System.Int16 Mode, bool ignore_Mode, System.Single LagTime, bool ignore_LagTime, System.Single DeadBand, bool ignore_DeadBand, System.Boolean Direction, bool ignore_Direction, System.Int32 CycleTime, bool ignore_CycleTime, System.Boolean DWorkOnError, bool ignore_DWorkOnError, System.Boolean EnFeedFwd, bool ignore_EnFeedFwd, System.Single FeedFwdGain, bool ignore_FeedFwdGain)
    {
      object[] _values_ = new object[11];
      if (!ignore_Gain) _values_[0] = Gain;
      if (!ignore_DerivativeTime) _values_[1] = DerivativeTime;
      if (!ignore_IntegralTime) _values_[2] = IntegralTime;
      if (!ignore_Mode) _values_[3] = Mode;
      if (!ignore_LagTime) _values_[4] = LagTime;
      if (!ignore_DeadBand) _values_[5] = DeadBand;
      if (!ignore_Direction) _values_[6] = Direction;
      if (!ignore_CycleTime) _values_[7] = CycleTime;
      if (!ignore_DWorkOnError) _values_[8] = DWorkOnError;
      if (!ignore_EnFeedFwd) _values_[9] = EnFeedFwd;
      if (!ignore_FeedFwdGain) _values_[10] = FeedFwdGain;
      return ((IHMIAccessorOutput)this).FireEvent(4, _values_);
    }
    public bool FireEvent_OUTBIAS_CFG(System.Single OutBias)
    {
      return ((IHMIAccessorOutput)this).FireEvent(5, new object[] {OutBias});
    }
    public bool FireEvent_OUTBIAS_CFG(HMI.Main.Symbols.PIDBase.OUTBIAS_CFGEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.OutBias.HasValue) _values_[0] = ea.OutBias.Value;
      return ((IHMIAccessorOutput)this).FireEvent(5, _values_);
    }
    public bool FireEvent_OUTBIAS_CFG(System.Single OutBias, bool ignore_OutBias)
    {
      object[] _values_ = new object[1];
      if (!ignore_OutBias) _values_[0] = OutBias;
      return ((IHMIAccessorOutput)this).FireEvent(5, _values_);
    }

  }
}

namespace HMI.Main.Faceplates.PIDBase
{
  partial class fpTrend
  {

    private event EventHandler<HMI.Main.Symbols.PIDBase.UPDEventArgs> UPD_Fired;

    private event EventHandler<HMI.Main.Symbols.PIDBase.UPD_CFGEventArgs> UPD_CFG_Fired;

    protected override void OnEndInit()
    {
      if (UPD_Fired != null)
        AttachEventInput(0);
      if (UPD_CFG_Fired != null)
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
              UPD_Fired(this, new HMI.Main.Symbols.PIDBase.UPDEventArgs(channelId, cookie, eventIndex));
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
          if (UPD_CFG_Fired != null)
          {
            try
            {
              UPD_CFG_Fired(this, new HMI.Main.Symbols.PIDBase.UPD_CFGEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","UPD_CFG_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_OWNER(System.UInt16 Owner)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {Owner});
    }
    public bool FireEvent_OWNER(HMI.Main.Symbols.PIDBase.OWNEREventArgs ea)
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
    public bool FireEvent_SP_CMD(System.Single Sp)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {Sp});
    }
    public bool FireEvent_SP_CMD(HMI.Main.Symbols.PIDBase.SP_CMDEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.Sp.HasValue) _values_[0] = ea.Sp.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_SP_CMD(System.Single Sp, bool ignore_Sp)
    {
      object[] _values_ = new object[1];
      if (!ignore_Sp) _values_[0] = Sp;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_MANUAL_CMD(System.Single ManualSp)
    {
      return ((IHMIAccessorOutput)this).FireEvent(2, new object[] {ManualSp});
    }
    public bool FireEvent_MANUAL_CMD(HMI.Main.Symbols.PIDBase.MANUAL_CMDEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.ManualSp.HasValue) _values_[0] = ea.ManualSp.Value;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_MANUAL_CMD(System.Single ManualSp, bool ignore_ManualSp)
    {
      object[] _values_ = new object[1];
      if (!ignore_ManualSp) _values_[0] = ManualSp;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_CFG(System.Single OutMin, System.Single OutMax, System.Boolean Bump, System.Single SpRateUp, System.Single SpRateDown, System.Boolean TrackSpInManual, System.Single OutRate, System.Single GainKp, System.Single OvsAtt)
    {
      return ((IHMIAccessorOutput)this).FireEvent(3, new object[] {OutMin, OutMax, Bump, SpRateUp, SpRateDown, TrackSpInManual, OutRate, GainKp, OvsAtt});
    }
    public bool FireEvent_CFG(HMI.Main.Symbols.PIDBase.CFGEventArgs ea)
    {
      object[] _values_ = new object[9];
      if (ea.OutMin.HasValue) _values_[0] = ea.OutMin.Value;
      if (ea.OutMax.HasValue) _values_[1] = ea.OutMax.Value;
      if (ea.Bump.HasValue) _values_[2] = ea.Bump.Value;
      if (ea.SpRateUp.HasValue) _values_[3] = ea.SpRateUp.Value;
      if (ea.SpRateDown.HasValue) _values_[4] = ea.SpRateDown.Value;
      if (ea.TrackSpInManual.HasValue) _values_[5] = ea.TrackSpInManual.Value;
      if (ea.OutRate.HasValue) _values_[6] = ea.OutRate.Value;
      if (ea.GainKp.HasValue) _values_[7] = ea.GainKp.Value;
      if (ea.OvsAtt.HasValue) _values_[8] = ea.OvsAtt.Value;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_CFG(System.Single OutMin, bool ignore_OutMin, System.Single OutMax, bool ignore_OutMax, System.Boolean Bump, bool ignore_Bump, System.Single SpRateUp, bool ignore_SpRateUp, System.Single SpRateDown, bool ignore_SpRateDown, System.Boolean TrackSpInManual, bool ignore_TrackSpInManual, System.Single OutRate, bool ignore_OutRate, System.Single GainKp, bool ignore_GainKp, System.Single OvsAtt, bool ignore_OvsAtt)
    {
      object[] _values_ = new object[9];
      if (!ignore_OutMin) _values_[0] = OutMin;
      if (!ignore_OutMax) _values_[1] = OutMax;
      if (!ignore_Bump) _values_[2] = Bump;
      if (!ignore_SpRateUp) _values_[3] = SpRateUp;
      if (!ignore_SpRateDown) _values_[4] = SpRateDown;
      if (!ignore_TrackSpInManual) _values_[5] = TrackSpInManual;
      if (!ignore_OutRate) _values_[6] = OutRate;
      if (!ignore_GainKp) _values_[7] = GainKp;
      if (!ignore_OvsAtt) _values_[8] = OvsAtt;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_PID_CFG(System.Single Gain, System.Single DerivativeTime, System.Single IntegralTime, System.Int16 Mode, System.Single LagTime, System.Single DeadBand, System.Boolean Direction, System.Int32 CycleTime, System.Boolean DWorkOnError, System.Boolean EnFeedFwd, System.Single FeedFwdGain)
    {
      return ((IHMIAccessorOutput)this).FireEvent(4, new object[] {Gain, DerivativeTime, IntegralTime, Mode, LagTime, DeadBand, Direction, CycleTime, DWorkOnError, EnFeedFwd, FeedFwdGain});
    }
    public bool FireEvent_PID_CFG(HMI.Main.Symbols.PIDBase.PID_CFGEventArgs ea)
    {
      object[] _values_ = new object[11];
      if (ea.Gain.HasValue) _values_[0] = ea.Gain.Value;
      if (ea.DerivativeTime.HasValue) _values_[1] = ea.DerivativeTime.Value;
      if (ea.IntegralTime.HasValue) _values_[2] = ea.IntegralTime.Value;
      if (ea.Mode.HasValue) _values_[3] = ea.Mode.Value;
      if (ea.LagTime.HasValue) _values_[4] = ea.LagTime.Value;
      if (ea.DeadBand.HasValue) _values_[5] = ea.DeadBand.Value;
      if (ea.Direction.HasValue) _values_[6] = ea.Direction.Value;
      if (ea.CycleTime.HasValue) _values_[7] = ea.CycleTime.Value;
      if (ea.DWorkOnError.HasValue) _values_[8] = ea.DWorkOnError.Value;
      if (ea.EnFeedFwd.HasValue) _values_[9] = ea.EnFeedFwd.Value;
      if (ea.FeedFwdGain.HasValue) _values_[10] = ea.FeedFwdGain.Value;
      return ((IHMIAccessorOutput)this).FireEvent(4, _values_);
    }
    public bool FireEvent_PID_CFG(System.Single Gain, bool ignore_Gain, System.Single DerivativeTime, bool ignore_DerivativeTime, System.Single IntegralTime, bool ignore_IntegralTime, System.Int16 Mode, bool ignore_Mode, System.Single LagTime, bool ignore_LagTime, System.Single DeadBand, bool ignore_DeadBand, System.Boolean Direction, bool ignore_Direction, System.Int32 CycleTime, bool ignore_CycleTime, System.Boolean DWorkOnError, bool ignore_DWorkOnError, System.Boolean EnFeedFwd, bool ignore_EnFeedFwd, System.Single FeedFwdGain, bool ignore_FeedFwdGain)
    {
      object[] _values_ = new object[11];
      if (!ignore_Gain) _values_[0] = Gain;
      if (!ignore_DerivativeTime) _values_[1] = DerivativeTime;
      if (!ignore_IntegralTime) _values_[2] = IntegralTime;
      if (!ignore_Mode) _values_[3] = Mode;
      if (!ignore_LagTime) _values_[4] = LagTime;
      if (!ignore_DeadBand) _values_[5] = DeadBand;
      if (!ignore_Direction) _values_[6] = Direction;
      if (!ignore_CycleTime) _values_[7] = CycleTime;
      if (!ignore_DWorkOnError) _values_[8] = DWorkOnError;
      if (!ignore_EnFeedFwd) _values_[9] = EnFeedFwd;
      if (!ignore_FeedFwdGain) _values_[10] = FeedFwdGain;
      return ((IHMIAccessorOutput)this).FireEvent(4, _values_);
    }
    public bool FireEvent_OUTBIAS_CFG(System.Single OutBias)
    {
      return ((IHMIAccessorOutput)this).FireEvent(5, new object[] {OutBias});
    }
    public bool FireEvent_OUTBIAS_CFG(HMI.Main.Symbols.PIDBase.OUTBIAS_CFGEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.OutBias.HasValue) _values_[0] = ea.OutBias.Value;
      return ((IHMIAccessorOutput)this).FireEvent(5, _values_);
    }
    public bool FireEvent_OUTBIAS_CFG(System.Single OutBias, bool ignore_OutBias)
    {
      object[] _values_ = new object[1];
      if (!ignore_OutBias) _values_[0] = OutBias;
      return ((IHMIAccessorOutput)this).FireEvent(5, _values_);
    }

  }
}

namespace HMI.Main.Symbols.PIDBase
{
  partial class sInstanceName
  {

    private event EventHandler<HMI.Main.Symbols.PIDBase.UPDEventArgs> UPD_Fired;

    private event EventHandler<HMI.Main.Symbols.PIDBase.UPD_CFGEventArgs> UPD_CFG_Fired;

    protected override void OnEndInit()
    {
      if (UPD_Fired != null)
        AttachEventInput(0);
      if (UPD_CFG_Fired != null)
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
              UPD_Fired(this, new HMI.Main.Symbols.PIDBase.UPDEventArgs(channelId, cookie, eventIndex));
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
          if (UPD_CFG_Fired != null)
          {
            try
            {
              UPD_CFG_Fired(this, new HMI.Main.Symbols.PIDBase.UPD_CFGEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","UPD_CFG_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_OWNER(System.UInt16 Owner)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {Owner});
    }
    public bool FireEvent_OWNER(HMI.Main.Symbols.PIDBase.OWNEREventArgs ea)
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
    public bool FireEvent_SP_CMD(System.Single Sp)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {Sp});
    }
    public bool FireEvent_SP_CMD(HMI.Main.Symbols.PIDBase.SP_CMDEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.Sp.HasValue) _values_[0] = ea.Sp.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_SP_CMD(System.Single Sp, bool ignore_Sp)
    {
      object[] _values_ = new object[1];
      if (!ignore_Sp) _values_[0] = Sp;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_MANUAL_CMD(System.Single ManualSp)
    {
      return ((IHMIAccessorOutput)this).FireEvent(2, new object[] {ManualSp});
    }
    public bool FireEvent_MANUAL_CMD(HMI.Main.Symbols.PIDBase.MANUAL_CMDEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.ManualSp.HasValue) _values_[0] = ea.ManualSp.Value;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_MANUAL_CMD(System.Single ManualSp, bool ignore_ManualSp)
    {
      object[] _values_ = new object[1];
      if (!ignore_ManualSp) _values_[0] = ManualSp;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_CFG(System.Single OutMin, System.Single OutMax, System.Boolean Bump, System.Single SpRateUp, System.Single SpRateDown, System.Boolean TrackSpInManual, System.Single OutRate, System.Single GainKp, System.Single OvsAtt)
    {
      return ((IHMIAccessorOutput)this).FireEvent(3, new object[] {OutMin, OutMax, Bump, SpRateUp, SpRateDown, TrackSpInManual, OutRate, GainKp, OvsAtt});
    }
    public bool FireEvent_CFG(HMI.Main.Symbols.PIDBase.CFGEventArgs ea)
    {
      object[] _values_ = new object[9];
      if (ea.OutMin.HasValue) _values_[0] = ea.OutMin.Value;
      if (ea.OutMax.HasValue) _values_[1] = ea.OutMax.Value;
      if (ea.Bump.HasValue) _values_[2] = ea.Bump.Value;
      if (ea.SpRateUp.HasValue) _values_[3] = ea.SpRateUp.Value;
      if (ea.SpRateDown.HasValue) _values_[4] = ea.SpRateDown.Value;
      if (ea.TrackSpInManual.HasValue) _values_[5] = ea.TrackSpInManual.Value;
      if (ea.OutRate.HasValue) _values_[6] = ea.OutRate.Value;
      if (ea.GainKp.HasValue) _values_[7] = ea.GainKp.Value;
      if (ea.OvsAtt.HasValue) _values_[8] = ea.OvsAtt.Value;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_CFG(System.Single OutMin, bool ignore_OutMin, System.Single OutMax, bool ignore_OutMax, System.Boolean Bump, bool ignore_Bump, System.Single SpRateUp, bool ignore_SpRateUp, System.Single SpRateDown, bool ignore_SpRateDown, System.Boolean TrackSpInManual, bool ignore_TrackSpInManual, System.Single OutRate, bool ignore_OutRate, System.Single GainKp, bool ignore_GainKp, System.Single OvsAtt, bool ignore_OvsAtt)
    {
      object[] _values_ = new object[9];
      if (!ignore_OutMin) _values_[0] = OutMin;
      if (!ignore_OutMax) _values_[1] = OutMax;
      if (!ignore_Bump) _values_[2] = Bump;
      if (!ignore_SpRateUp) _values_[3] = SpRateUp;
      if (!ignore_SpRateDown) _values_[4] = SpRateDown;
      if (!ignore_TrackSpInManual) _values_[5] = TrackSpInManual;
      if (!ignore_OutRate) _values_[6] = OutRate;
      if (!ignore_GainKp) _values_[7] = GainKp;
      if (!ignore_OvsAtt) _values_[8] = OvsAtt;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_PID_CFG(System.Single Gain, System.Single DerivativeTime, System.Single IntegralTime, System.Int16 Mode, System.Single LagTime, System.Single DeadBand, System.Boolean Direction, System.Int32 CycleTime, System.Boolean DWorkOnError, System.Boolean EnFeedFwd, System.Single FeedFwdGain)
    {
      return ((IHMIAccessorOutput)this).FireEvent(4, new object[] {Gain, DerivativeTime, IntegralTime, Mode, LagTime, DeadBand, Direction, CycleTime, DWorkOnError, EnFeedFwd, FeedFwdGain});
    }
    public bool FireEvent_PID_CFG(HMI.Main.Symbols.PIDBase.PID_CFGEventArgs ea)
    {
      object[] _values_ = new object[11];
      if (ea.Gain.HasValue) _values_[0] = ea.Gain.Value;
      if (ea.DerivativeTime.HasValue) _values_[1] = ea.DerivativeTime.Value;
      if (ea.IntegralTime.HasValue) _values_[2] = ea.IntegralTime.Value;
      if (ea.Mode.HasValue) _values_[3] = ea.Mode.Value;
      if (ea.LagTime.HasValue) _values_[4] = ea.LagTime.Value;
      if (ea.DeadBand.HasValue) _values_[5] = ea.DeadBand.Value;
      if (ea.Direction.HasValue) _values_[6] = ea.Direction.Value;
      if (ea.CycleTime.HasValue) _values_[7] = ea.CycleTime.Value;
      if (ea.DWorkOnError.HasValue) _values_[8] = ea.DWorkOnError.Value;
      if (ea.EnFeedFwd.HasValue) _values_[9] = ea.EnFeedFwd.Value;
      if (ea.FeedFwdGain.HasValue) _values_[10] = ea.FeedFwdGain.Value;
      return ((IHMIAccessorOutput)this).FireEvent(4, _values_);
    }
    public bool FireEvent_PID_CFG(System.Single Gain, bool ignore_Gain, System.Single DerivativeTime, bool ignore_DerivativeTime, System.Single IntegralTime, bool ignore_IntegralTime, System.Int16 Mode, bool ignore_Mode, System.Single LagTime, bool ignore_LagTime, System.Single DeadBand, bool ignore_DeadBand, System.Boolean Direction, bool ignore_Direction, System.Int32 CycleTime, bool ignore_CycleTime, System.Boolean DWorkOnError, bool ignore_DWorkOnError, System.Boolean EnFeedFwd, bool ignore_EnFeedFwd, System.Single FeedFwdGain, bool ignore_FeedFwdGain)
    {
      object[] _values_ = new object[11];
      if (!ignore_Gain) _values_[0] = Gain;
      if (!ignore_DerivativeTime) _values_[1] = DerivativeTime;
      if (!ignore_IntegralTime) _values_[2] = IntegralTime;
      if (!ignore_Mode) _values_[3] = Mode;
      if (!ignore_LagTime) _values_[4] = LagTime;
      if (!ignore_DeadBand) _values_[5] = DeadBand;
      if (!ignore_Direction) _values_[6] = Direction;
      if (!ignore_CycleTime) _values_[7] = CycleTime;
      if (!ignore_DWorkOnError) _values_[8] = DWorkOnError;
      if (!ignore_EnFeedFwd) _values_[9] = EnFeedFwd;
      if (!ignore_FeedFwdGain) _values_[10] = FeedFwdGain;
      return ((IHMIAccessorOutput)this).FireEvent(4, _values_);
    }
    public bool FireEvent_OUTBIAS_CFG(System.Single OutBias)
    {
      return ((IHMIAccessorOutput)this).FireEvent(5, new object[] {OutBias});
    }
    public bool FireEvent_OUTBIAS_CFG(HMI.Main.Symbols.PIDBase.OUTBIAS_CFGEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.OutBias.HasValue) _values_[0] = ea.OutBias.Value;
      return ((IHMIAccessorOutput)this).FireEvent(5, _values_);
    }
    public bool FireEvent_OUTBIAS_CFG(System.Single OutBias, bool ignore_OutBias)
    {
      object[] _values_ = new object[1];
      if (!ignore_OutBias) _values_[0] = OutBias;
      return ((IHMIAccessorOutput)this).FireEvent(5, _values_);
    }

  }
}
#endregion #PIDBase_HMI;

#endregion Definitions;



