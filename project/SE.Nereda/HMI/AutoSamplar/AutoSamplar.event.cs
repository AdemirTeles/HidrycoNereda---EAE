/*
 * Created by EcoStruxure Automation Expert.
 * User: SESA713705
 * Date: 9/26/2024
 * Time: 11:08 AM
 * 
 */
using System;
using NxtControl.GuiFramework;
using NxtControl.Services;

#region Definitions;
#region #AutoSamplar_HMI;

namespace SE.Nereda.Symbols.AutoSamplar
{

  public class REQ_PULSEEventArgs : System.EventArgs
  {
    IHMIAccessorService accessorService;
    int channelId;
    int cookie; 
    int eventIndex;

    public REQ_PULSEEventArgs(int channelId, int cookie, int eventIndex)
    {
      this.accessorService = (IHMIAccessorService)ServiceProvider.GetService(typeof(IHMIAccessorService));
      this.channelId = channelId;
      this.cookie = cookie;
      this.eventIndex = eventIndex;
    }
    public bool Get_Pulse(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,0, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? Pulse
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,0, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_PulseCount(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,1, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? PulseCount
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,1, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }


  }

  public class REQ_STATEEventArgs : System.EventArgs
  {
    IHMIAccessorService accessorService;
    int channelId;
    int cookie; 
    int eventIndex;

    public REQ_STATEEventArgs(int channelId, int cookie, int eventIndex)
    {
      this.accessorService = (IHMIAccessorService)ServiceProvider.GetService(typeof(IHMIAccessorService));
      this.channelId = channelId;
      this.cookie = cookie;
      this.eventIndex = eventIndex;
    }
    public bool Get_State(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,0, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? State
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

  public class M_CUBE_C_TEventArgs : System.EventArgs
  {
    IHMIAccessorService accessorService;
    int channelId;
    int cookie; 
    int eventIndex;

    public M_CUBE_C_TEventArgs(int channelId, int cookie, int eventIndex)
    {
      this.accessorService = (IHMIAccessorService)ServiceProvider.GetService(typeof(IHMIAccessorService));
      this.channelId = channelId;
      this.cookie = cookie;
      this.eventIndex = eventIndex;
    }
    public bool Get_mCube_CycleTime(ref NxtControl.GuiFramework.Time value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,0, ref var);
      if (ret) value = (NxtControl.GuiFramework.Time) var;
      return ret;
    }

    public NxtControl.GuiFramework.Time? mCube_CycleTime
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,0, ref var);
      if (!ret) return null;
      return (NxtControl.GuiFramework.Time) var;
    }  }

    public bool Get_FlowSp(ref System.Single value)
    {
      if (accessorService == null)
        return false;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,1, ref var);
      if (ret) value = (System.Single) var;
      return ret;
    }

    public System.Single? FlowSp
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

namespace SE.Nereda.Symbols.AutoSamplar
{

  public class CNF_DELAY_TIMEEventArgs : System.EventArgs
  {
    public CNF_DELAY_TIMEEventArgs()
    {
    }
    private NxtControl.GuiFramework.Time? DelayTime_field = null;
    public NxtControl.GuiFramework.Time? DelayTime
    {
       get { return DelayTime_field; }
       set { DelayTime_field = value; }
    }

  }

  public class CNF_FLOW_SPEventArgs : System.EventArgs
  {
    public CNF_FLOW_SPEventArgs()
    {
    }
    private System.Single? FlowSetpoint_field = null;
    public System.Single? FlowSetpoint
    {
       get { return FlowSetpoint_field; }
       set { FlowSetpoint_field = value; }
    }

  }

  public class M_CUBE_SPEventArgs : System.EventArgs
  {
    public M_CUBE_SPEventArgs()
    {
    }
    private System.Single? mCubeSp_field = null;
    public System.Single? mCubeSp
    {
       get { return mCubeSp_field; }
       set { mCubeSp_field = value; }
    }

  }

}

namespace SE.Nereda.Symbols.AutoSamplar
{
  partial class sDefault
  {

    private event EventHandler<SE.Nereda.Symbols.AutoSamplar.REQ_PULSEEventArgs> REQ_PULSE_Fired;

    private event EventHandler<SE.Nereda.Symbols.AutoSamplar.REQ_STATEEventArgs> REQ_STATE_Fired;

    private event EventHandler<SE.Nereda.Symbols.AutoSamplar.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    private event EventHandler<SE.Nereda.Symbols.AutoSamplar.M_CUBE_C_TEventArgs> M_CUBE_C_T_Fired;

    protected override void OnEndInit()
    {
      if (REQ_PULSE_Fired != null)
        AttachEventInput(0);
      if (REQ_STATE_Fired != null)
        AttachEventInput(1);
      if (LOAD_PERS_DATA_Fired != null)
        AttachEventInput(2);
      if (M_CUBE_C_T_Fired != null)
        AttachEventInput(3);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (REQ_PULSE_Fired != null)
          {
            try
            {
              REQ_PULSE_Fired(this, new SE.Nereda.Symbols.AutoSamplar.REQ_PULSEEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REQ_PULSE_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 1:
          if (REQ_STATE_Fired != null)
          {
            try
            {
              REQ_STATE_Fired(this, new SE.Nereda.Symbols.AutoSamplar.REQ_STATEEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REQ_STATE_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 2:
          if (LOAD_PERS_DATA_Fired != null)
          {
            try
            {
              LOAD_PERS_DATA_Fired(this, new SE.Nereda.Symbols.AutoSamplar.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","LOAD_PERS_DATA_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 3:
          if (M_CUBE_C_T_Fired != null)
          {
            try
            {
              M_CUBE_C_T_Fired(this, new SE.Nereda.Symbols.AutoSamplar.M_CUBE_C_TEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","M_CUBE_C_T_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_CNF_DELAY_TIME(NxtControl.GuiFramework.Time DelayTime)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {DelayTime});
    }
    public bool FireEvent_CNF_DELAY_TIME(SE.Nereda.Symbols.AutoSamplar.CNF_DELAY_TIMEEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.DelayTime.HasValue) _values_[0] = ea.DelayTime.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_CNF_DELAY_TIME(NxtControl.GuiFramework.Time DelayTime, bool ignore_DelayTime)
    {
      object[] _values_ = new object[1];
      if (!ignore_DelayTime) _values_[0] = DelayTime;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_CNF_FLOW_SP(System.Single FlowSetpoint)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {FlowSetpoint});
    }
    public bool FireEvent_CNF_FLOW_SP(SE.Nereda.Symbols.AutoSamplar.CNF_FLOW_SPEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.FlowSetpoint.HasValue) _values_[0] = ea.FlowSetpoint.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_CNF_FLOW_SP(System.Single FlowSetpoint, bool ignore_FlowSetpoint)
    {
      object[] _values_ = new object[1];
      if (!ignore_FlowSetpoint) _values_[0] = FlowSetpoint;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_M_CUBE_SP(System.Single mCubeSp)
    {
      return ((IHMIAccessorOutput)this).FireEvent(2, new object[] {mCubeSp});
    }
    public bool FireEvent_M_CUBE_SP(SE.Nereda.Symbols.AutoSamplar.M_CUBE_SPEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.mCubeSp.HasValue) _values_[0] = ea.mCubeSp.Value;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_M_CUBE_SP(System.Single mCubeSp, bool ignore_mCubeSp)
    {
      object[] _values_ = new object[1];
      if (!ignore_mCubeSp) _values_[0] = mCubeSp;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }

  }
}

namespace SE.Nereda.Faceplates.AutoSamplar
{
  partial class fpSettings
  {

    private event EventHandler<SE.Nereda.Symbols.AutoSamplar.REQ_PULSEEventArgs> REQ_PULSE_Fired;

    private event EventHandler<SE.Nereda.Symbols.AutoSamplar.REQ_STATEEventArgs> REQ_STATE_Fired;

    private event EventHandler<SE.Nereda.Symbols.AutoSamplar.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    private event EventHandler<SE.Nereda.Symbols.AutoSamplar.M_CUBE_C_TEventArgs> M_CUBE_C_T_Fired;

    protected override void OnEndInit()
    {
      if (REQ_PULSE_Fired != null)
        AttachEventInput(0);
      if (REQ_STATE_Fired != null)
        AttachEventInput(1);
      if (LOAD_PERS_DATA_Fired != null)
        AttachEventInput(2);
      if (M_CUBE_C_T_Fired != null)
        AttachEventInput(3);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (REQ_PULSE_Fired != null)
          {
            try
            {
              REQ_PULSE_Fired(this, new SE.Nereda.Symbols.AutoSamplar.REQ_PULSEEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REQ_PULSE_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 1:
          if (REQ_STATE_Fired != null)
          {
            try
            {
              REQ_STATE_Fired(this, new SE.Nereda.Symbols.AutoSamplar.REQ_STATEEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REQ_STATE_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 2:
          if (LOAD_PERS_DATA_Fired != null)
          {
            try
            {
              LOAD_PERS_DATA_Fired(this, new SE.Nereda.Symbols.AutoSamplar.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","LOAD_PERS_DATA_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 3:
          if (M_CUBE_C_T_Fired != null)
          {
            try
            {
              M_CUBE_C_T_Fired(this, new SE.Nereda.Symbols.AutoSamplar.M_CUBE_C_TEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","M_CUBE_C_T_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_CNF_DELAY_TIME(NxtControl.GuiFramework.Time DelayTime)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {DelayTime});
    }
    public bool FireEvent_CNF_DELAY_TIME(SE.Nereda.Symbols.AutoSamplar.CNF_DELAY_TIMEEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.DelayTime.HasValue) _values_[0] = ea.DelayTime.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_CNF_DELAY_TIME(NxtControl.GuiFramework.Time DelayTime, bool ignore_DelayTime)
    {
      object[] _values_ = new object[1];
      if (!ignore_DelayTime) _values_[0] = DelayTime;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_CNF_FLOW_SP(System.Single FlowSetpoint)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {FlowSetpoint});
    }
    public bool FireEvent_CNF_FLOW_SP(SE.Nereda.Symbols.AutoSamplar.CNF_FLOW_SPEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.FlowSetpoint.HasValue) _values_[0] = ea.FlowSetpoint.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_CNF_FLOW_SP(System.Single FlowSetpoint, bool ignore_FlowSetpoint)
    {
      object[] _values_ = new object[1];
      if (!ignore_FlowSetpoint) _values_[0] = FlowSetpoint;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_M_CUBE_SP(System.Single mCubeSp)
    {
      return ((IHMIAccessorOutput)this).FireEvent(2, new object[] {mCubeSp});
    }
    public bool FireEvent_M_CUBE_SP(SE.Nereda.Symbols.AutoSamplar.M_CUBE_SPEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.mCubeSp.HasValue) _values_[0] = ea.mCubeSp.Value;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_M_CUBE_SP(System.Single mCubeSp, bool ignore_mCubeSp)
    {
      object[] _values_ = new object[1];
      if (!ignore_mCubeSp) _values_[0] = mCubeSp;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }

  }
}
#endregion #AutoSamplar_HMI;

#endregion Definitions;
