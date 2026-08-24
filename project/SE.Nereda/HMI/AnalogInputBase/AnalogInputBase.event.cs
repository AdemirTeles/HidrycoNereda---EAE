/*
 * Created by EcoStruxure Automation Expert.
 * User: SESA489241
 * Date: 15/01/2021
 * Time: 9:31 pm
 * 
 */
using System;
using NxtControl.GuiFramework;
using NxtControl.Services;

#region Definitions;
#region #AnalogInputBase_HMI;

namespace SE.Nereda.Symbols.AnalogInputBase
{

  public class OP_UPDEventArgs : System.EventArgs
  {
    IHMIAccessorService accessorService;
    int channelId;
    int cookie; 
    int eventIndex;

    public OP_UPDEventArgs(int channelId, int cookie, int eventIndex)
    {
      this.accessorService = (IHMIAccessorService)ServiceProvider.GetService(typeof(IHMIAccessorService));
      this.channelId = channelId;
      this.cookie = cookie;
      this.eventIndex = eventIndex;
    }
    public bool Get_ChFailAlarm(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,0, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? ChFailAlarm
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,0, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_AlarmSuppressed(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,1, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? AlarmSuppressed
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,1, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }


  }

  public class OP_UPD_PVEventArgs : System.EventArgs
  {
    IHMIAccessorService accessorService;
    int channelId;
    int cookie; 
    int eventIndex;

    public OP_UPD_PVEventArgs(int channelId, int cookie, int eventIndex)
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

    public bool Get_InputValue(ref System.Single value)
    {
      if (accessorService == null)
        return false;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,1, ref var);
      if (ret) value = (System.Single) var;
      return ret;
    }

    public System.Single? InputValue
    { get {
      if (accessorService == null)
        return null;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,1, ref var);
      if (!ret) return null;
      return (System.Single) var;
    }  }


  }

}

namespace SE.Nereda.Symbols.AnalogInputBase
{

  public class CFGEventArgs : System.EventArgs
  {
    public CFGEventArgs()
    {
    }
    private System.Single? RawPvMin_field = null;
    public System.Single? RawPvMin
    {
       get { return RawPvMin_field; }
       set { RawPvMin_field = value; }
    }
    private System.Single? RawPvMax_field = null;
    public System.Single? RawPvMax
    {
       get { return RawPvMax_field; }
       set { RawPvMax_field = value; }
    }
    private System.Single? PvMin_field = null;
    public System.Single? PvMin
    {
       get { return PvMin_field; }
       set { PvMin_field = value; }
    }
    private System.Single? PvMax_field = null;
    public System.Single? PvMax
    {
       get { return PvMax_field; }
       set { PvMax_field = value; }
    }
    private System.Boolean? EnScale_field = null;
    public System.Boolean? EnScale
    {
       get { return EnScale_field; }
       set { EnScale_field = value; }
    }
    private System.Boolean? UseLimits_field = null;
    public System.Boolean? UseLimits
    {
       get { return UseLimits_field; }
       set { UseLimits_field = value; }
    }
    private System.Single? PvCutOff_field = null;
    public System.Single? PvCutOff
    {
       get { return PvCutOff_field; }
       set { PvCutOff_field = value; }
    }
    private System.Single? PvOffset_field = null;
    public System.Single? PvOffset
    {
       get { return PvOffset_field; }
       set { PvOffset_field = value; }
    }
    private System.Int32? Pt1FTime_field = null;
    public System.Int32? Pt1FTime
    {
       get { return Pt1FTime_field; }
       set { Pt1FTime_field = value; }
    }
    private System.Int32? Pt1CycleTime_field = null;
    public System.Int32? Pt1CycleTime
    {
       get { return Pt1CycleTime_field; }
       set { Pt1CycleTime_field = value; }
    }
    private System.Int16? BadPvSel_field = null;
    public System.Int16? BadPvSel
    {
       get { return BadPvSel_field; }
       set { BadPvSel_field = value; }
    }
    private System.Single? BadPv_field = null;
    public System.Single? BadPv
    {
       get { return BadPv_field; }
       set { BadPv_field = value; }
    }
    private System.Byte? SmoothType_field = null;
    public System.Byte? SmoothType
    {
       get { return SmoothType_field; }
       set { SmoothType_field = value; }
    }
    private System.Int32? TimeDiff_field = null;
    public System.Int32? TimeDiff
    {
       get { return TimeDiff_field; }
       set { TimeDiff_field = value; }
    }
    private System.Single? ValDiff_field = null;
    public System.Single? ValDiff
    {
       get { return ValDiff_field; }
       set { ValDiff_field = value; }
    }
    private System.Byte? AlmAckType_field = null;
    public System.Byte? AlmAckType
    {
       get { return AlmAckType_field; }
       set { AlmAckType_field = value; }
    }

  }

  public class IND_MODEEventArgs : System.EventArgs
  {
    public IND_MODEEventArgs()
    {
    }
    private System.Boolean? PvOverride_field = null;
    public System.Boolean? PvOverride
    {
       get { return PvOverride_field; }
       set { PvOverride_field = value; }
    }
    private System.Single? PvOverrideVal_field = null;
    public System.Single? PvOverrideVal
    {
       get { return PvOverrideVal_field; }
       set { PvOverrideVal_field = value; }
    }

  }

}

namespace SE.Nereda.Faceplates.AnalogInputBase
{
  partial class fpDefault
  {

    private event EventHandler<SE.Nereda.Symbols.AnalogInputBase.OP_UPDEventArgs> OP_UPD_Fired;

    private event EventHandler<SE.Nereda.Symbols.AnalogInputBase.OP_UPD_PVEventArgs> OP_UPD_PV_Fired;

    protected override void OnEndInit()
    {
      if (OP_UPD_Fired != null)
        AttachEventInput(0);
      if (OP_UPD_PV_Fired != null)
        AttachEventInput(1);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (OP_UPD_Fired != null)
          {
            try
            {
              OP_UPD_Fired(this, new SE.Nereda.Symbols.AnalogInputBase.OP_UPDEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","OP_UPD_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 1:
          if (OP_UPD_PV_Fired != null)
          {
            try
            {
              OP_UPD_PV_Fired(this, new SE.Nereda.Symbols.AnalogInputBase.OP_UPD_PVEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","OP_UPD_PV_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_CFG(System.Single RawPvMin, System.Single RawPvMax, System.Single PvMin, System.Single PvMax, System.Boolean EnScale, System.Boolean UseLimits, System.Single PvCutOff, System.Single PvOffset, System.Int32 Pt1FTime, System.Int32 Pt1CycleTime, System.Int16 BadPvSel, System.Single BadPv, System.Byte SmoothType, System.Int32 TimeDiff, System.Single ValDiff, System.Byte AlmAckType)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {RawPvMin, RawPvMax, PvMin, PvMax, EnScale, UseLimits, PvCutOff, PvOffset, Pt1FTime, Pt1CycleTime, BadPvSel, BadPv, SmoothType, TimeDiff, ValDiff, AlmAckType});
    }
    public bool FireEvent_CFG(SE.Nereda.Symbols.AnalogInputBase.CFGEventArgs ea)
    {
      object[] _values_ = new object[16];
      if (ea.RawPvMin.HasValue) _values_[0] = ea.RawPvMin.Value;
      if (ea.RawPvMax.HasValue) _values_[1] = ea.RawPvMax.Value;
      if (ea.PvMin.HasValue) _values_[2] = ea.PvMin.Value;
      if (ea.PvMax.HasValue) _values_[3] = ea.PvMax.Value;
      if (ea.EnScale.HasValue) _values_[4] = ea.EnScale.Value;
      if (ea.UseLimits.HasValue) _values_[5] = ea.UseLimits.Value;
      if (ea.PvCutOff.HasValue) _values_[6] = ea.PvCutOff.Value;
      if (ea.PvOffset.HasValue) _values_[7] = ea.PvOffset.Value;
      if (ea.Pt1FTime.HasValue) _values_[8] = ea.Pt1FTime.Value;
      if (ea.Pt1CycleTime.HasValue) _values_[9] = ea.Pt1CycleTime.Value;
      if (ea.BadPvSel.HasValue) _values_[10] = ea.BadPvSel.Value;
      if (ea.BadPv.HasValue) _values_[11] = ea.BadPv.Value;
      if (ea.SmoothType.HasValue) _values_[12] = ea.SmoothType.Value;
      if (ea.TimeDiff.HasValue) _values_[13] = ea.TimeDiff.Value;
      if (ea.ValDiff.HasValue) _values_[14] = ea.ValDiff.Value;
      if (ea.AlmAckType.HasValue) _values_[15] = ea.AlmAckType.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_CFG(System.Single RawPvMin, bool ignore_RawPvMin, System.Single RawPvMax, bool ignore_RawPvMax, System.Single PvMin, bool ignore_PvMin, System.Single PvMax, bool ignore_PvMax, System.Boolean EnScale, bool ignore_EnScale, System.Boolean UseLimits, bool ignore_UseLimits, System.Single PvCutOff, bool ignore_PvCutOff, System.Single PvOffset, bool ignore_PvOffset, System.Int32 Pt1FTime, bool ignore_Pt1FTime, System.Int32 Pt1CycleTime, bool ignore_Pt1CycleTime, System.Int16 BadPvSel, bool ignore_BadPvSel, System.Single BadPv, bool ignore_BadPv, System.Byte SmoothType, bool ignore_SmoothType, System.Int32 TimeDiff, bool ignore_TimeDiff, System.Single ValDiff, bool ignore_ValDiff, System.Byte AlmAckType, bool ignore_AlmAckType)
    {
      object[] _values_ = new object[16];
      if (!ignore_RawPvMin) _values_[0] = RawPvMin;
      if (!ignore_RawPvMax) _values_[1] = RawPvMax;
      if (!ignore_PvMin) _values_[2] = PvMin;
      if (!ignore_PvMax) _values_[3] = PvMax;
      if (!ignore_EnScale) _values_[4] = EnScale;
      if (!ignore_UseLimits) _values_[5] = UseLimits;
      if (!ignore_PvCutOff) _values_[6] = PvCutOff;
      if (!ignore_PvOffset) _values_[7] = PvOffset;
      if (!ignore_Pt1FTime) _values_[8] = Pt1FTime;
      if (!ignore_Pt1CycleTime) _values_[9] = Pt1CycleTime;
      if (!ignore_BadPvSel) _values_[10] = BadPvSel;
      if (!ignore_BadPv) _values_[11] = BadPv;
      if (!ignore_SmoothType) _values_[12] = SmoothType;
      if (!ignore_TimeDiff) _values_[13] = TimeDiff;
      if (!ignore_ValDiff) _values_[14] = ValDiff;
      if (!ignore_AlmAckType) _values_[15] = AlmAckType;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_IND_MODE(System.Boolean PvOverride, System.Single PvOverrideVal)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {PvOverride, PvOverrideVal});
    }
    public bool FireEvent_IND_MODE(SE.Nereda.Symbols.AnalogInputBase.IND_MODEEventArgs ea)
    {
      object[] _values_ = new object[2];
      if (ea.PvOverride.HasValue) _values_[0] = ea.PvOverride.Value;
      if (ea.PvOverrideVal.HasValue) _values_[1] = ea.PvOverrideVal.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_IND_MODE(System.Boolean PvOverride, bool ignore_PvOverride, System.Single PvOverrideVal, bool ignore_PvOverrideVal)
    {
      object[] _values_ = new object[2];
      if (!ignore_PvOverride) _values_[0] = PvOverride;
      if (!ignore_PvOverrideVal) _values_[1] = PvOverrideVal;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }

  }
}

namespace SE.Nereda.Faceplates.AnalogInputBase
{
  partial class fpParameter
  {

    private event EventHandler<SE.Nereda.Symbols.AnalogInputBase.OP_UPDEventArgs> OP_UPD_Fired;

    private event EventHandler<SE.Nereda.Symbols.AnalogInputBase.OP_UPD_PVEventArgs> OP_UPD_PV_Fired;

    protected override void OnEndInit()
    {
      if (OP_UPD_Fired != null)
        AttachEventInput(0);
      if (OP_UPD_PV_Fired != null)
        AttachEventInput(1);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (OP_UPD_Fired != null)
          {
            try
            {
              OP_UPD_Fired(this, new SE.Nereda.Symbols.AnalogInputBase.OP_UPDEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","OP_UPD_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 1:
          if (OP_UPD_PV_Fired != null)
          {
            try
            {
              OP_UPD_PV_Fired(this, new SE.Nereda.Symbols.AnalogInputBase.OP_UPD_PVEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","OP_UPD_PV_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_CFG(System.Single RawPvMin, System.Single RawPvMax, System.Single PvMin, System.Single PvMax, System.Boolean EnScale, System.Boolean UseLimits, System.Single PvCutOff, System.Single PvOffset, System.Int32 Pt1FTime, System.Int32 Pt1CycleTime, System.Int16 BadPvSel, System.Single BadPv, System.Byte SmoothType, System.Int32 TimeDiff, System.Single ValDiff, System.Byte AlmAckType)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {RawPvMin, RawPvMax, PvMin, PvMax, EnScale, UseLimits, PvCutOff, PvOffset, Pt1FTime, Pt1CycleTime, BadPvSel, BadPv, SmoothType, TimeDiff, ValDiff, AlmAckType});
    }
    public bool FireEvent_CFG(SE.Nereda.Symbols.AnalogInputBase.CFGEventArgs ea)
    {
      object[] _values_ = new object[16];
      if (ea.RawPvMin.HasValue) _values_[0] = ea.RawPvMin.Value;
      if (ea.RawPvMax.HasValue) _values_[1] = ea.RawPvMax.Value;
      if (ea.PvMin.HasValue) _values_[2] = ea.PvMin.Value;
      if (ea.PvMax.HasValue) _values_[3] = ea.PvMax.Value;
      if (ea.EnScale.HasValue) _values_[4] = ea.EnScale.Value;
      if (ea.UseLimits.HasValue) _values_[5] = ea.UseLimits.Value;
      if (ea.PvCutOff.HasValue) _values_[6] = ea.PvCutOff.Value;
      if (ea.PvOffset.HasValue) _values_[7] = ea.PvOffset.Value;
      if (ea.Pt1FTime.HasValue) _values_[8] = ea.Pt1FTime.Value;
      if (ea.Pt1CycleTime.HasValue) _values_[9] = ea.Pt1CycleTime.Value;
      if (ea.BadPvSel.HasValue) _values_[10] = ea.BadPvSel.Value;
      if (ea.BadPv.HasValue) _values_[11] = ea.BadPv.Value;
      if (ea.SmoothType.HasValue) _values_[12] = ea.SmoothType.Value;
      if (ea.TimeDiff.HasValue) _values_[13] = ea.TimeDiff.Value;
      if (ea.ValDiff.HasValue) _values_[14] = ea.ValDiff.Value;
      if (ea.AlmAckType.HasValue) _values_[15] = ea.AlmAckType.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_CFG(System.Single RawPvMin, bool ignore_RawPvMin, System.Single RawPvMax, bool ignore_RawPvMax, System.Single PvMin, bool ignore_PvMin, System.Single PvMax, bool ignore_PvMax, System.Boolean EnScale, bool ignore_EnScale, System.Boolean UseLimits, bool ignore_UseLimits, System.Single PvCutOff, bool ignore_PvCutOff, System.Single PvOffset, bool ignore_PvOffset, System.Int32 Pt1FTime, bool ignore_Pt1FTime, System.Int32 Pt1CycleTime, bool ignore_Pt1CycleTime, System.Int16 BadPvSel, bool ignore_BadPvSel, System.Single BadPv, bool ignore_BadPv, System.Byte SmoothType, bool ignore_SmoothType, System.Int32 TimeDiff, bool ignore_TimeDiff, System.Single ValDiff, bool ignore_ValDiff, System.Byte AlmAckType, bool ignore_AlmAckType)
    {
      object[] _values_ = new object[16];
      if (!ignore_RawPvMin) _values_[0] = RawPvMin;
      if (!ignore_RawPvMax) _values_[1] = RawPvMax;
      if (!ignore_PvMin) _values_[2] = PvMin;
      if (!ignore_PvMax) _values_[3] = PvMax;
      if (!ignore_EnScale) _values_[4] = EnScale;
      if (!ignore_UseLimits) _values_[5] = UseLimits;
      if (!ignore_PvCutOff) _values_[6] = PvCutOff;
      if (!ignore_PvOffset) _values_[7] = PvOffset;
      if (!ignore_Pt1FTime) _values_[8] = Pt1FTime;
      if (!ignore_Pt1CycleTime) _values_[9] = Pt1CycleTime;
      if (!ignore_BadPvSel) _values_[10] = BadPvSel;
      if (!ignore_BadPv) _values_[11] = BadPv;
      if (!ignore_SmoothType) _values_[12] = SmoothType;
      if (!ignore_TimeDiff) _values_[13] = TimeDiff;
      if (!ignore_ValDiff) _values_[14] = ValDiff;
      if (!ignore_AlmAckType) _values_[15] = AlmAckType;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_IND_MODE(System.Boolean PvOverride, System.Single PvOverrideVal)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {PvOverride, PvOverrideVal});
    }
    public bool FireEvent_IND_MODE(SE.Nereda.Symbols.AnalogInputBase.IND_MODEEventArgs ea)
    {
      object[] _values_ = new object[2];
      if (ea.PvOverride.HasValue) _values_[0] = ea.PvOverride.Value;
      if (ea.PvOverrideVal.HasValue) _values_[1] = ea.PvOverrideVal.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_IND_MODE(System.Boolean PvOverride, bool ignore_PvOverride, System.Single PvOverrideVal, bool ignore_PvOverrideVal)
    {
      object[] _values_ = new object[2];
      if (!ignore_PvOverride) _values_[0] = PvOverride;
      if (!ignore_PvOverrideVal) _values_[1] = PvOverrideVal;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }

  }
}

namespace SE.Nereda.Symbols.AnalogInputBase
{
  partial class sDefault
  {

    private event EventHandler<SE.Nereda.Symbols.AnalogInputBase.OP_UPDEventArgs> OP_UPD_Fired;

    private event EventHandler<SE.Nereda.Symbols.AnalogInputBase.OP_UPD_PVEventArgs> OP_UPD_PV_Fired;

    protected override void OnEndInit()
    {
      if (OP_UPD_Fired != null)
        AttachEventInput(0);
      if (OP_UPD_PV_Fired != null)
        AttachEventInput(1);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (OP_UPD_Fired != null)
          {
            try
            {
              OP_UPD_Fired(this, new SE.Nereda.Symbols.AnalogInputBase.OP_UPDEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","OP_UPD_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 1:
          if (OP_UPD_PV_Fired != null)
          {
            try
            {
              OP_UPD_PV_Fired(this, new SE.Nereda.Symbols.AnalogInputBase.OP_UPD_PVEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","OP_UPD_PV_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_CFG(System.Single RawPvMin, System.Single RawPvMax, System.Single PvMin, System.Single PvMax, System.Boolean EnScale, System.Boolean UseLimits, System.Single PvCutOff, System.Single PvOffset, System.Int32 Pt1FTime, System.Int32 Pt1CycleTime, System.Int16 BadPvSel, System.Single BadPv, System.Byte SmoothType, System.Int32 TimeDiff, System.Single ValDiff, System.Byte AlmAckType)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {RawPvMin, RawPvMax, PvMin, PvMax, EnScale, UseLimits, PvCutOff, PvOffset, Pt1FTime, Pt1CycleTime, BadPvSel, BadPv, SmoothType, TimeDiff, ValDiff, AlmAckType});
    }
    public bool FireEvent_CFG(SE.Nereda.Symbols.AnalogInputBase.CFGEventArgs ea)
    {
      object[] _values_ = new object[16];
      if (ea.RawPvMin.HasValue) _values_[0] = ea.RawPvMin.Value;
      if (ea.RawPvMax.HasValue) _values_[1] = ea.RawPvMax.Value;
      if (ea.PvMin.HasValue) _values_[2] = ea.PvMin.Value;
      if (ea.PvMax.HasValue) _values_[3] = ea.PvMax.Value;
      if (ea.EnScale.HasValue) _values_[4] = ea.EnScale.Value;
      if (ea.UseLimits.HasValue) _values_[5] = ea.UseLimits.Value;
      if (ea.PvCutOff.HasValue) _values_[6] = ea.PvCutOff.Value;
      if (ea.PvOffset.HasValue) _values_[7] = ea.PvOffset.Value;
      if (ea.Pt1FTime.HasValue) _values_[8] = ea.Pt1FTime.Value;
      if (ea.Pt1CycleTime.HasValue) _values_[9] = ea.Pt1CycleTime.Value;
      if (ea.BadPvSel.HasValue) _values_[10] = ea.BadPvSel.Value;
      if (ea.BadPv.HasValue) _values_[11] = ea.BadPv.Value;
      if (ea.SmoothType.HasValue) _values_[12] = ea.SmoothType.Value;
      if (ea.TimeDiff.HasValue) _values_[13] = ea.TimeDiff.Value;
      if (ea.ValDiff.HasValue) _values_[14] = ea.ValDiff.Value;
      if (ea.AlmAckType.HasValue) _values_[15] = ea.AlmAckType.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_CFG(System.Single RawPvMin, bool ignore_RawPvMin, System.Single RawPvMax, bool ignore_RawPvMax, System.Single PvMin, bool ignore_PvMin, System.Single PvMax, bool ignore_PvMax, System.Boolean EnScale, bool ignore_EnScale, System.Boolean UseLimits, bool ignore_UseLimits, System.Single PvCutOff, bool ignore_PvCutOff, System.Single PvOffset, bool ignore_PvOffset, System.Int32 Pt1FTime, bool ignore_Pt1FTime, System.Int32 Pt1CycleTime, bool ignore_Pt1CycleTime, System.Int16 BadPvSel, bool ignore_BadPvSel, System.Single BadPv, bool ignore_BadPv, System.Byte SmoothType, bool ignore_SmoothType, System.Int32 TimeDiff, bool ignore_TimeDiff, System.Single ValDiff, bool ignore_ValDiff, System.Byte AlmAckType, bool ignore_AlmAckType)
    {
      object[] _values_ = new object[16];
      if (!ignore_RawPvMin) _values_[0] = RawPvMin;
      if (!ignore_RawPvMax) _values_[1] = RawPvMax;
      if (!ignore_PvMin) _values_[2] = PvMin;
      if (!ignore_PvMax) _values_[3] = PvMax;
      if (!ignore_EnScale) _values_[4] = EnScale;
      if (!ignore_UseLimits) _values_[5] = UseLimits;
      if (!ignore_PvCutOff) _values_[6] = PvCutOff;
      if (!ignore_PvOffset) _values_[7] = PvOffset;
      if (!ignore_Pt1FTime) _values_[8] = Pt1FTime;
      if (!ignore_Pt1CycleTime) _values_[9] = Pt1CycleTime;
      if (!ignore_BadPvSel) _values_[10] = BadPvSel;
      if (!ignore_BadPv) _values_[11] = BadPv;
      if (!ignore_SmoothType) _values_[12] = SmoothType;
      if (!ignore_TimeDiff) _values_[13] = TimeDiff;
      if (!ignore_ValDiff) _values_[14] = ValDiff;
      if (!ignore_AlmAckType) _values_[15] = AlmAckType;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_IND_MODE(System.Boolean PvOverride, System.Single PvOverrideVal)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {PvOverride, PvOverrideVal});
    }
    public bool FireEvent_IND_MODE(SE.Nereda.Symbols.AnalogInputBase.IND_MODEEventArgs ea)
    {
      object[] _values_ = new object[2];
      if (ea.PvOverride.HasValue) _values_[0] = ea.PvOverride.Value;
      if (ea.PvOverrideVal.HasValue) _values_[1] = ea.PvOverrideVal.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_IND_MODE(System.Boolean PvOverride, bool ignore_PvOverride, System.Single PvOverrideVal, bool ignore_PvOverrideVal)
    {
      object[] _values_ = new object[2];
      if (!ignore_PvOverride) _values_[0] = PvOverride;
      if (!ignore_PvOverrideVal) _values_[1] = PvOverrideVal;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }

  }
}

namespace SE.Nereda.Symbols.AnalogInputBase
{
  partial class sVertical
  {

    private event EventHandler<SE.Nereda.Symbols.AnalogInputBase.OP_UPDEventArgs> OP_UPD_Fired;

    private event EventHandler<SE.Nereda.Symbols.AnalogInputBase.OP_UPD_PVEventArgs> OP_UPD_PV_Fired;

    protected override void OnEndInit()
    {
      if (OP_UPD_Fired != null)
        AttachEventInput(0);
      if (OP_UPD_PV_Fired != null)
        AttachEventInput(1);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (OP_UPD_Fired != null)
          {
            try
            {
              OP_UPD_Fired(this, new SE.Nereda.Symbols.AnalogInputBase.OP_UPDEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","OP_UPD_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 1:
          if (OP_UPD_PV_Fired != null)
          {
            try
            {
              OP_UPD_PV_Fired(this, new SE.Nereda.Symbols.AnalogInputBase.OP_UPD_PVEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","OP_UPD_PV_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_CFG(System.Single RawPvMin, System.Single RawPvMax, System.Single PvMin, System.Single PvMax, System.Boolean EnScale, System.Boolean UseLimits, System.Single PvCutOff, System.Single PvOffset, System.Int32 Pt1FTime, System.Int32 Pt1CycleTime, System.Int16 BadPvSel, System.Single BadPv, System.Byte SmoothType, System.Int32 TimeDiff, System.Single ValDiff, System.Byte AlmAckType)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {RawPvMin, RawPvMax, PvMin, PvMax, EnScale, UseLimits, PvCutOff, PvOffset, Pt1FTime, Pt1CycleTime, BadPvSel, BadPv, SmoothType, TimeDiff, ValDiff, AlmAckType});
    }
    public bool FireEvent_CFG(SE.Nereda.Symbols.AnalogInputBase.CFGEventArgs ea)
    {
      object[] _values_ = new object[16];
      if (ea.RawPvMin.HasValue) _values_[0] = ea.RawPvMin.Value;
      if (ea.RawPvMax.HasValue) _values_[1] = ea.RawPvMax.Value;
      if (ea.PvMin.HasValue) _values_[2] = ea.PvMin.Value;
      if (ea.PvMax.HasValue) _values_[3] = ea.PvMax.Value;
      if (ea.EnScale.HasValue) _values_[4] = ea.EnScale.Value;
      if (ea.UseLimits.HasValue) _values_[5] = ea.UseLimits.Value;
      if (ea.PvCutOff.HasValue) _values_[6] = ea.PvCutOff.Value;
      if (ea.PvOffset.HasValue) _values_[7] = ea.PvOffset.Value;
      if (ea.Pt1FTime.HasValue) _values_[8] = ea.Pt1FTime.Value;
      if (ea.Pt1CycleTime.HasValue) _values_[9] = ea.Pt1CycleTime.Value;
      if (ea.BadPvSel.HasValue) _values_[10] = ea.BadPvSel.Value;
      if (ea.BadPv.HasValue) _values_[11] = ea.BadPv.Value;
      if (ea.SmoothType.HasValue) _values_[12] = ea.SmoothType.Value;
      if (ea.TimeDiff.HasValue) _values_[13] = ea.TimeDiff.Value;
      if (ea.ValDiff.HasValue) _values_[14] = ea.ValDiff.Value;
      if (ea.AlmAckType.HasValue) _values_[15] = ea.AlmAckType.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_CFG(System.Single RawPvMin, bool ignore_RawPvMin, System.Single RawPvMax, bool ignore_RawPvMax, System.Single PvMin, bool ignore_PvMin, System.Single PvMax, bool ignore_PvMax, System.Boolean EnScale, bool ignore_EnScale, System.Boolean UseLimits, bool ignore_UseLimits, System.Single PvCutOff, bool ignore_PvCutOff, System.Single PvOffset, bool ignore_PvOffset, System.Int32 Pt1FTime, bool ignore_Pt1FTime, System.Int32 Pt1CycleTime, bool ignore_Pt1CycleTime, System.Int16 BadPvSel, bool ignore_BadPvSel, System.Single BadPv, bool ignore_BadPv, System.Byte SmoothType, bool ignore_SmoothType, System.Int32 TimeDiff, bool ignore_TimeDiff, System.Single ValDiff, bool ignore_ValDiff, System.Byte AlmAckType, bool ignore_AlmAckType)
    {
      object[] _values_ = new object[16];
      if (!ignore_RawPvMin) _values_[0] = RawPvMin;
      if (!ignore_RawPvMax) _values_[1] = RawPvMax;
      if (!ignore_PvMin) _values_[2] = PvMin;
      if (!ignore_PvMax) _values_[3] = PvMax;
      if (!ignore_EnScale) _values_[4] = EnScale;
      if (!ignore_UseLimits) _values_[5] = UseLimits;
      if (!ignore_PvCutOff) _values_[6] = PvCutOff;
      if (!ignore_PvOffset) _values_[7] = PvOffset;
      if (!ignore_Pt1FTime) _values_[8] = Pt1FTime;
      if (!ignore_Pt1CycleTime) _values_[9] = Pt1CycleTime;
      if (!ignore_BadPvSel) _values_[10] = BadPvSel;
      if (!ignore_BadPv) _values_[11] = BadPv;
      if (!ignore_SmoothType) _values_[12] = SmoothType;
      if (!ignore_TimeDiff) _values_[13] = TimeDiff;
      if (!ignore_ValDiff) _values_[14] = ValDiff;
      if (!ignore_AlmAckType) _values_[15] = AlmAckType;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_IND_MODE(System.Boolean PvOverride, System.Single PvOverrideVal)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {PvOverride, PvOverrideVal});
    }
    public bool FireEvent_IND_MODE(SE.Nereda.Symbols.AnalogInputBase.IND_MODEEventArgs ea)
    {
      object[] _values_ = new object[2];
      if (ea.PvOverride.HasValue) _values_[0] = ea.PvOverride.Value;
      if (ea.PvOverrideVal.HasValue) _values_[1] = ea.PvOverrideVal.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_IND_MODE(System.Boolean PvOverride, bool ignore_PvOverride, System.Single PvOverrideVal, bool ignore_PvOverrideVal)
    {
      object[] _values_ = new object[2];
      if (!ignore_PvOverride) _values_[0] = PvOverride;
      if (!ignore_PvOverrideVal) _values_[1] = PvOverrideVal;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }

  }
}

namespace SE.Nereda.Faceplates.AnalogInputBase
{
  partial class fpTrend
  {

    private event EventHandler<SE.Nereda.Symbols.AnalogInputBase.OP_UPDEventArgs> OP_UPD_Fired;

    private event EventHandler<SE.Nereda.Symbols.AnalogInputBase.OP_UPD_PVEventArgs> OP_UPD_PV_Fired;

    protected override void OnEndInit()
    {
      if (OP_UPD_Fired != null)
        AttachEventInput(0);
      if (OP_UPD_PV_Fired != null)
        AttachEventInput(1);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (OP_UPD_Fired != null)
          {
            try
            {
              OP_UPD_Fired(this, new SE.Nereda.Symbols.AnalogInputBase.OP_UPDEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","OP_UPD_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 1:
          if (OP_UPD_PV_Fired != null)
          {
            try
            {
              OP_UPD_PV_Fired(this, new SE.Nereda.Symbols.AnalogInputBase.OP_UPD_PVEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","OP_UPD_PV_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_CFG(System.Single RawPvMin, System.Single RawPvMax, System.Single PvMin, System.Single PvMax, System.Boolean EnScale, System.Boolean UseLimits, System.Single PvCutOff, System.Single PvOffset, System.Int32 Pt1FTime, System.Int32 Pt1CycleTime, System.Int16 BadPvSel, System.Single BadPv, System.Byte SmoothType, System.Int32 TimeDiff, System.Single ValDiff, System.Byte AlmAckType)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {RawPvMin, RawPvMax, PvMin, PvMax, EnScale, UseLimits, PvCutOff, PvOffset, Pt1FTime, Pt1CycleTime, BadPvSel, BadPv, SmoothType, TimeDiff, ValDiff, AlmAckType});
    }
    public bool FireEvent_CFG(SE.Nereda.Symbols.AnalogInputBase.CFGEventArgs ea)
    {
      object[] _values_ = new object[16];
      if (ea.RawPvMin.HasValue) _values_[0] = ea.RawPvMin.Value;
      if (ea.RawPvMax.HasValue) _values_[1] = ea.RawPvMax.Value;
      if (ea.PvMin.HasValue) _values_[2] = ea.PvMin.Value;
      if (ea.PvMax.HasValue) _values_[3] = ea.PvMax.Value;
      if (ea.EnScale.HasValue) _values_[4] = ea.EnScale.Value;
      if (ea.UseLimits.HasValue) _values_[5] = ea.UseLimits.Value;
      if (ea.PvCutOff.HasValue) _values_[6] = ea.PvCutOff.Value;
      if (ea.PvOffset.HasValue) _values_[7] = ea.PvOffset.Value;
      if (ea.Pt1FTime.HasValue) _values_[8] = ea.Pt1FTime.Value;
      if (ea.Pt1CycleTime.HasValue) _values_[9] = ea.Pt1CycleTime.Value;
      if (ea.BadPvSel.HasValue) _values_[10] = ea.BadPvSel.Value;
      if (ea.BadPv.HasValue) _values_[11] = ea.BadPv.Value;
      if (ea.SmoothType.HasValue) _values_[12] = ea.SmoothType.Value;
      if (ea.TimeDiff.HasValue) _values_[13] = ea.TimeDiff.Value;
      if (ea.ValDiff.HasValue) _values_[14] = ea.ValDiff.Value;
      if (ea.AlmAckType.HasValue) _values_[15] = ea.AlmAckType.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_CFG(System.Single RawPvMin, bool ignore_RawPvMin, System.Single RawPvMax, bool ignore_RawPvMax, System.Single PvMin, bool ignore_PvMin, System.Single PvMax, bool ignore_PvMax, System.Boolean EnScale, bool ignore_EnScale, System.Boolean UseLimits, bool ignore_UseLimits, System.Single PvCutOff, bool ignore_PvCutOff, System.Single PvOffset, bool ignore_PvOffset, System.Int32 Pt1FTime, bool ignore_Pt1FTime, System.Int32 Pt1CycleTime, bool ignore_Pt1CycleTime, System.Int16 BadPvSel, bool ignore_BadPvSel, System.Single BadPv, bool ignore_BadPv, System.Byte SmoothType, bool ignore_SmoothType, System.Int32 TimeDiff, bool ignore_TimeDiff, System.Single ValDiff, bool ignore_ValDiff, System.Byte AlmAckType, bool ignore_AlmAckType)
    {
      object[] _values_ = new object[16];
      if (!ignore_RawPvMin) _values_[0] = RawPvMin;
      if (!ignore_RawPvMax) _values_[1] = RawPvMax;
      if (!ignore_PvMin) _values_[2] = PvMin;
      if (!ignore_PvMax) _values_[3] = PvMax;
      if (!ignore_EnScale) _values_[4] = EnScale;
      if (!ignore_UseLimits) _values_[5] = UseLimits;
      if (!ignore_PvCutOff) _values_[6] = PvCutOff;
      if (!ignore_PvOffset) _values_[7] = PvOffset;
      if (!ignore_Pt1FTime) _values_[8] = Pt1FTime;
      if (!ignore_Pt1CycleTime) _values_[9] = Pt1CycleTime;
      if (!ignore_BadPvSel) _values_[10] = BadPvSel;
      if (!ignore_BadPv) _values_[11] = BadPv;
      if (!ignore_SmoothType) _values_[12] = SmoothType;
      if (!ignore_TimeDiff) _values_[13] = TimeDiff;
      if (!ignore_ValDiff) _values_[14] = ValDiff;
      if (!ignore_AlmAckType) _values_[15] = AlmAckType;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_IND_MODE(System.Boolean PvOverride, System.Single PvOverrideVal)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {PvOverride, PvOverrideVal});
    }
    public bool FireEvent_IND_MODE(SE.Nereda.Symbols.AnalogInputBase.IND_MODEEventArgs ea)
    {
      object[] _values_ = new object[2];
      if (ea.PvOverride.HasValue) _values_[0] = ea.PvOverride.Value;
      if (ea.PvOverrideVal.HasValue) _values_[1] = ea.PvOverrideVal.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_IND_MODE(System.Boolean PvOverride, bool ignore_PvOverride, System.Single PvOverrideVal, bool ignore_PvOverrideVal)
    {
      object[] _values_ = new object[2];
      if (!ignore_PvOverride) _values_[0] = PvOverride;
      if (!ignore_PvOverrideVal) _values_[1] = PvOverrideVal;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }

  }
}

namespace SE.Nereda.Symbols.AnalogInputBase
{
  partial class sDisplayPv
  {

    private event EventHandler<SE.Nereda.Symbols.AnalogInputBase.OP_UPDEventArgs> OP_UPD_Fired;

    private event EventHandler<SE.Nereda.Symbols.AnalogInputBase.OP_UPD_PVEventArgs> OP_UPD_PV_Fired;

    protected override void OnEndInit()
    {
      if (OP_UPD_Fired != null)
        AttachEventInput(0);
      if (OP_UPD_PV_Fired != null)
        AttachEventInput(1);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (OP_UPD_Fired != null)
          {
            try
            {
              OP_UPD_Fired(this, new SE.Nereda.Symbols.AnalogInputBase.OP_UPDEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","OP_UPD_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 1:
          if (OP_UPD_PV_Fired != null)
          {
            try
            {
              OP_UPD_PV_Fired(this, new SE.Nereda.Symbols.AnalogInputBase.OP_UPD_PVEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","OP_UPD_PV_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_CFG(System.Single RawPvMin, System.Single RawPvMax, System.Single PvMin, System.Single PvMax, System.Boolean EnScale, System.Boolean UseLimits, System.Single PvCutOff, System.Single PvOffset, System.Int32 Pt1FTime, System.Int32 Pt1CycleTime, System.Int16 BadPvSel, System.Single BadPv, System.Byte SmoothType, System.Int32 TimeDiff, System.Single ValDiff, System.Byte AlmAckType)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {RawPvMin, RawPvMax, PvMin, PvMax, EnScale, UseLimits, PvCutOff, PvOffset, Pt1FTime, Pt1CycleTime, BadPvSel, BadPv, SmoothType, TimeDiff, ValDiff, AlmAckType});
    }
    public bool FireEvent_CFG(SE.Nereda.Symbols.AnalogInputBase.CFGEventArgs ea)
    {
      object[] _values_ = new object[16];
      if (ea.RawPvMin.HasValue) _values_[0] = ea.RawPvMin.Value;
      if (ea.RawPvMax.HasValue) _values_[1] = ea.RawPvMax.Value;
      if (ea.PvMin.HasValue) _values_[2] = ea.PvMin.Value;
      if (ea.PvMax.HasValue) _values_[3] = ea.PvMax.Value;
      if (ea.EnScale.HasValue) _values_[4] = ea.EnScale.Value;
      if (ea.UseLimits.HasValue) _values_[5] = ea.UseLimits.Value;
      if (ea.PvCutOff.HasValue) _values_[6] = ea.PvCutOff.Value;
      if (ea.PvOffset.HasValue) _values_[7] = ea.PvOffset.Value;
      if (ea.Pt1FTime.HasValue) _values_[8] = ea.Pt1FTime.Value;
      if (ea.Pt1CycleTime.HasValue) _values_[9] = ea.Pt1CycleTime.Value;
      if (ea.BadPvSel.HasValue) _values_[10] = ea.BadPvSel.Value;
      if (ea.BadPv.HasValue) _values_[11] = ea.BadPv.Value;
      if (ea.SmoothType.HasValue) _values_[12] = ea.SmoothType.Value;
      if (ea.TimeDiff.HasValue) _values_[13] = ea.TimeDiff.Value;
      if (ea.ValDiff.HasValue) _values_[14] = ea.ValDiff.Value;
      if (ea.AlmAckType.HasValue) _values_[15] = ea.AlmAckType.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_CFG(System.Single RawPvMin, bool ignore_RawPvMin, System.Single RawPvMax, bool ignore_RawPvMax, System.Single PvMin, bool ignore_PvMin, System.Single PvMax, bool ignore_PvMax, System.Boolean EnScale, bool ignore_EnScale, System.Boolean UseLimits, bool ignore_UseLimits, System.Single PvCutOff, bool ignore_PvCutOff, System.Single PvOffset, bool ignore_PvOffset, System.Int32 Pt1FTime, bool ignore_Pt1FTime, System.Int32 Pt1CycleTime, bool ignore_Pt1CycleTime, System.Int16 BadPvSel, bool ignore_BadPvSel, System.Single BadPv, bool ignore_BadPv, System.Byte SmoothType, bool ignore_SmoothType, System.Int32 TimeDiff, bool ignore_TimeDiff, System.Single ValDiff, bool ignore_ValDiff, System.Byte AlmAckType, bool ignore_AlmAckType)
    {
      object[] _values_ = new object[16];
      if (!ignore_RawPvMin) _values_[0] = RawPvMin;
      if (!ignore_RawPvMax) _values_[1] = RawPvMax;
      if (!ignore_PvMin) _values_[2] = PvMin;
      if (!ignore_PvMax) _values_[3] = PvMax;
      if (!ignore_EnScale) _values_[4] = EnScale;
      if (!ignore_UseLimits) _values_[5] = UseLimits;
      if (!ignore_PvCutOff) _values_[6] = PvCutOff;
      if (!ignore_PvOffset) _values_[7] = PvOffset;
      if (!ignore_Pt1FTime) _values_[8] = Pt1FTime;
      if (!ignore_Pt1CycleTime) _values_[9] = Pt1CycleTime;
      if (!ignore_BadPvSel) _values_[10] = BadPvSel;
      if (!ignore_BadPv) _values_[11] = BadPv;
      if (!ignore_SmoothType) _values_[12] = SmoothType;
      if (!ignore_TimeDiff) _values_[13] = TimeDiff;
      if (!ignore_ValDiff) _values_[14] = ValDiff;
      if (!ignore_AlmAckType) _values_[15] = AlmAckType;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_IND_MODE(System.Boolean PvOverride, System.Single PvOverrideVal)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {PvOverride, PvOverrideVal});
    }
    public bool FireEvent_IND_MODE(SE.Nereda.Symbols.AnalogInputBase.IND_MODEEventArgs ea)
    {
      object[] _values_ = new object[2];
      if (ea.PvOverride.HasValue) _values_[0] = ea.PvOverride.Value;
      if (ea.PvOverrideVal.HasValue) _values_[1] = ea.PvOverrideVal.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_IND_MODE(System.Boolean PvOverride, bool ignore_PvOverride, System.Single PvOverrideVal, bool ignore_PvOverrideVal)
    {
      object[] _values_ = new object[2];
      if (!ignore_PvOverride) _values_[0] = PvOverride;
      if (!ignore_PvOverrideVal) _values_[1] = PvOverrideVal;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }

  }
}

namespace SE.Nereda.Symbols.AnalogInputBase
{
  partial class sInstanceName
  {

    private event EventHandler<SE.Nereda.Symbols.AnalogInputBase.OP_UPDEventArgs> OP_UPD_Fired;

    private event EventHandler<SE.Nereda.Symbols.AnalogInputBase.OP_UPD_PVEventArgs> OP_UPD_PV_Fired;

    protected override void OnEndInit()
    {
      if (OP_UPD_Fired != null)
        AttachEventInput(0);
      if (OP_UPD_PV_Fired != null)
        AttachEventInput(1);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (OP_UPD_Fired != null)
          {
            try
            {
              OP_UPD_Fired(this, new SE.Nereda.Symbols.AnalogInputBase.OP_UPDEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","OP_UPD_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 1:
          if (OP_UPD_PV_Fired != null)
          {
            try
            {
              OP_UPD_PV_Fired(this, new SE.Nereda.Symbols.AnalogInputBase.OP_UPD_PVEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","OP_UPD_PV_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_CFG(System.Single RawPvMin, System.Single RawPvMax, System.Single PvMin, System.Single PvMax, System.Boolean EnScale, System.Boolean UseLimits, System.Single PvCutOff, System.Single PvOffset, System.Int32 Pt1FTime, System.Int32 Pt1CycleTime, System.Int16 BadPvSel, System.Single BadPv, System.Byte SmoothType, System.Int32 TimeDiff, System.Single ValDiff, System.Byte AlmAckType)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {RawPvMin, RawPvMax, PvMin, PvMax, EnScale, UseLimits, PvCutOff, PvOffset, Pt1FTime, Pt1CycleTime, BadPvSel, BadPv, SmoothType, TimeDiff, ValDiff, AlmAckType});
    }
    public bool FireEvent_CFG(SE.Nereda.Symbols.AnalogInputBase.CFGEventArgs ea)
    {
      object[] _values_ = new object[16];
      if (ea.RawPvMin.HasValue) _values_[0] = ea.RawPvMin.Value;
      if (ea.RawPvMax.HasValue) _values_[1] = ea.RawPvMax.Value;
      if (ea.PvMin.HasValue) _values_[2] = ea.PvMin.Value;
      if (ea.PvMax.HasValue) _values_[3] = ea.PvMax.Value;
      if (ea.EnScale.HasValue) _values_[4] = ea.EnScale.Value;
      if (ea.UseLimits.HasValue) _values_[5] = ea.UseLimits.Value;
      if (ea.PvCutOff.HasValue) _values_[6] = ea.PvCutOff.Value;
      if (ea.PvOffset.HasValue) _values_[7] = ea.PvOffset.Value;
      if (ea.Pt1FTime.HasValue) _values_[8] = ea.Pt1FTime.Value;
      if (ea.Pt1CycleTime.HasValue) _values_[9] = ea.Pt1CycleTime.Value;
      if (ea.BadPvSel.HasValue) _values_[10] = ea.BadPvSel.Value;
      if (ea.BadPv.HasValue) _values_[11] = ea.BadPv.Value;
      if (ea.SmoothType.HasValue) _values_[12] = ea.SmoothType.Value;
      if (ea.TimeDiff.HasValue) _values_[13] = ea.TimeDiff.Value;
      if (ea.ValDiff.HasValue) _values_[14] = ea.ValDiff.Value;
      if (ea.AlmAckType.HasValue) _values_[15] = ea.AlmAckType.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_CFG(System.Single RawPvMin, bool ignore_RawPvMin, System.Single RawPvMax, bool ignore_RawPvMax, System.Single PvMin, bool ignore_PvMin, System.Single PvMax, bool ignore_PvMax, System.Boolean EnScale, bool ignore_EnScale, System.Boolean UseLimits, bool ignore_UseLimits, System.Single PvCutOff, bool ignore_PvCutOff, System.Single PvOffset, bool ignore_PvOffset, System.Int32 Pt1FTime, bool ignore_Pt1FTime, System.Int32 Pt1CycleTime, bool ignore_Pt1CycleTime, System.Int16 BadPvSel, bool ignore_BadPvSel, System.Single BadPv, bool ignore_BadPv, System.Byte SmoothType, bool ignore_SmoothType, System.Int32 TimeDiff, bool ignore_TimeDiff, System.Single ValDiff, bool ignore_ValDiff, System.Byte AlmAckType, bool ignore_AlmAckType)
    {
      object[] _values_ = new object[16];
      if (!ignore_RawPvMin) _values_[0] = RawPvMin;
      if (!ignore_RawPvMax) _values_[1] = RawPvMax;
      if (!ignore_PvMin) _values_[2] = PvMin;
      if (!ignore_PvMax) _values_[3] = PvMax;
      if (!ignore_EnScale) _values_[4] = EnScale;
      if (!ignore_UseLimits) _values_[5] = UseLimits;
      if (!ignore_PvCutOff) _values_[6] = PvCutOff;
      if (!ignore_PvOffset) _values_[7] = PvOffset;
      if (!ignore_Pt1FTime) _values_[8] = Pt1FTime;
      if (!ignore_Pt1CycleTime) _values_[9] = Pt1CycleTime;
      if (!ignore_BadPvSel) _values_[10] = BadPvSel;
      if (!ignore_BadPv) _values_[11] = BadPv;
      if (!ignore_SmoothType) _values_[12] = SmoothType;
      if (!ignore_TimeDiff) _values_[13] = TimeDiff;
      if (!ignore_ValDiff) _values_[14] = ValDiff;
      if (!ignore_AlmAckType) _values_[15] = AlmAckType;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_IND_MODE(System.Boolean PvOverride, System.Single PvOverrideVal)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {PvOverride, PvOverrideVal});
    }
    public bool FireEvent_IND_MODE(SE.Nereda.Symbols.AnalogInputBase.IND_MODEEventArgs ea)
    {
      object[] _values_ = new object[2];
      if (ea.PvOverride.HasValue) _values_[0] = ea.PvOverride.Value;
      if (ea.PvOverrideVal.HasValue) _values_[1] = ea.PvOverrideVal.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_IND_MODE(System.Boolean PvOverride, bool ignore_PvOverride, System.Single PvOverrideVal, bool ignore_PvOverrideVal)
    {
      object[] _values_ = new object[2];
      if (!ignore_PvOverride) _values_[0] = PvOverride;
      if (!ignore_PvOverrideVal) _values_[1] = PvOverrideVal;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }

  }
}
#endregion #AnalogInputBase_HMI;

#endregion Definitions;



