/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 6/21/2026
 * Time: 11:02 AM
 * 
 */
using System;
using NxtControl.GuiFramework;
using NxtControl.Services;

#region Definitions;
#region #FlushingManager_HMI;

namespace SE.Nereda.Symbols.FlushingManager
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

  public class LEVEL_PVEventArgs : System.EventArgs
  {
    IHMIAccessorService accessorService;
    int channelId;
    int cookie; 
    int eventIndex;

    public LEVEL_PVEventArgs(int channelId, int cookie, int eventIndex)
    {
      this.accessorService = (IHMIAccessorService)ServiceProvider.GetService(typeof(IHMIAccessorService));
      this.channelId = channelId;
      this.cookie = cookie;
      this.eventIndex = eventIndex;
    }
    public bool Get_LevelPvMax(ref System.Single value)
    {
      if (accessorService == null)
        return false;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,0, ref var);
      if (ret) value = (System.Single) var;
      return ret;
    }

    public System.Single? LevelPvMax
    { get {
      if (accessorService == null)
        return null;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,0, ref var);
      if (!ret) return null;
      return (System.Single) var;
    }  }

    public bool Get_LevelPvMin(ref System.Single value)
    {
      if (accessorService == null)
        return false;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,1, ref var);
      if (ret) value = (System.Single) var;
      return ret;
    }

    public System.Single? LevelPvMin
    { get {
      if (accessorService == null)
        return null;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,1, ref var);
      if (!ret) return null;
      return (System.Single) var;
    }  }

    public bool Get_LevelPv(ref System.Single value)
    {
      if (accessorService == null)
        return false;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,2, ref var);
      if (ret) value = (System.Single) var;
      return ret;
    }

    public System.Single? LevelPv
    { get {
      if (accessorService == null)
        return null;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,2, ref var);
      if (!ret) return null;
      return (System.Single) var;
    }  }


  }

  public class RESET_BTNsEventArgs : System.EventArgs
  {
    IHMIAccessorService accessorService;
    int channelId;
    int cookie; 
    int eventIndex;

    public RESET_BTNsEventArgs(int channelId, int cookie, int eventIndex)
    {
      this.accessorService = (IHMIAccessorService)ServiceProvider.GetService(typeof(IHMIAccessorService));
      this.channelId = channelId;
      this.cookie = cookie;
      this.eventIndex = eventIndex;
    }

  }

  public class FLOW_SPEventArgs : System.EventArgs
  {
    IHMIAccessorService accessorService;
    int channelId;
    int cookie; 
    int eventIndex;

    public FLOW_SPEventArgs(int channelId, int cookie, int eventIndex)
    {
      this.accessorService = (IHMIAccessorService)ServiceProvider.GetService(typeof(IHMIAccessorService));
      this.channelId = channelId;
      this.cookie = cookie;
      this.eventIndex = eventIndex;
    }
    public bool Get_FlowSP(ref System.Single value)
    {
      if (accessorService == null)
        return false;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,0, ref var);
      if (ret) value = (System.Single) var;
      return ret;
    }

    public System.Single? FlowSP
    { get {
      if (accessorService == null)
        return null;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,0, ref var);
      if (!ret) return null;
      return (System.Single) var;
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

}

namespace SE.Nereda.Symbols.FlushingManager
{

  public class SPEED_CAP_SPEventArgs : System.EventArgs
  {
    public SPEED_CAP_SPEventArgs()
    {
    }
    private System.Single? CapacitySp_field = null;
    public System.Single? CapacitySp
    {
       get { return CapacitySp_field; }
       set { CapacitySp_field = value; }
    }
    private System.Single? SwitchSpeedSp_field = null;
    public System.Single? SwitchSpeedSp
    {
       get { return SwitchSpeedSp_field; }
       set { SwitchSpeedSp_field = value; }
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

  public class PUMP_SPEventArgs : System.EventArgs
  {
    public PUMP_SPEventArgs()
    {
    }
    private System.Single? StartSp_field = null;
    public System.Single? StartSp
    {
       get { return StartSp_field; }
       set { StartSp_field = value; }
    }
    private System.Single? StopSp_field = null;
    public System.Single? StopSp
    {
       get { return StopSp_field; }
       set { StopSp_field = value; }
    }

  }

}

namespace SE.Nereda.Symbols.FlushingManager
{
  partial class sDefault
  {

    private event EventHandler<SE.Nereda.Symbols.FlushingManager.GRAPHEventArgs> GRAPH_Fired;

    private event EventHandler<SE.Nereda.Symbols.FlushingManager.LEVEL_PVEventArgs> LEVEL_PV_Fired;

    private event EventHandler<SE.Nereda.Symbols.FlushingManager.RESET_BTNsEventArgs> RESET_BTNs_Fired;

    private event EventHandler<SE.Nereda.Symbols.FlushingManager.FLOW_SPEventArgs> FLOW_SP_Fired;

    private event EventHandler<SE.Nereda.Symbols.FlushingManager.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    protected override void OnEndInit()
    {
      if (GRAPH_Fired != null)
        AttachEventInput(0);
      if (LEVEL_PV_Fired != null)
        AttachEventInput(1);
      if (RESET_BTNs_Fired != null)
        AttachEventInput(2);
      if (FLOW_SP_Fired != null)
        AttachEventInput(3);
      if (LOAD_PERS_DATA_Fired != null)
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
              GRAPH_Fired(this, new SE.Nereda.Symbols.FlushingManager.GRAPHEventArgs(channelId, cookie, eventIndex));
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
          if (LEVEL_PV_Fired != null)
          {
            try
            {
              LEVEL_PV_Fired(this, new SE.Nereda.Symbols.FlushingManager.LEVEL_PVEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","LEVEL_PV_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 2:
          if (RESET_BTNs_Fired != null)
          {
            try
            {
              RESET_BTNs_Fired(this, new SE.Nereda.Symbols.FlushingManager.RESET_BTNsEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","RESET_BTNs_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 3:
          if (FLOW_SP_Fired != null)
          {
            try
            {
              FLOW_SP_Fired(this, new SE.Nereda.Symbols.FlushingManager.FLOW_SPEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","FLOW_SP_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 4:
          if (LOAD_PERS_DATA_Fired != null)
          {
            try
            {
              LOAD_PERS_DATA_Fired(this, new SE.Nereda.Symbols.FlushingManager.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
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
    public bool FireEvent_SPEED_CAP_SP(System.Single CapacitySp, System.Single SwitchSpeedSp)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {CapacitySp, SwitchSpeedSp});
    }
    public bool FireEvent_SPEED_CAP_SP(SE.Nereda.Symbols.FlushingManager.SPEED_CAP_SPEventArgs ea)
    {
      object[] _values_ = new object[2];
      if (ea.CapacitySp.HasValue) _values_[0] = ea.CapacitySp.Value;
      if (ea.SwitchSpeedSp.HasValue) _values_[1] = ea.SwitchSpeedSp.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_SPEED_CAP_SP(System.Single CapacitySp, bool ignore_CapacitySp, System.Single SwitchSpeedSp, bool ignore_SwitchSpeedSp)
    {
      object[] _values_ = new object[2];
      if (!ignore_CapacitySp) _values_[0] = CapacitySp;
      if (!ignore_SwitchSpeedSp) _values_[1] = SwitchSpeedSp;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_RESET_LO_LO_F(System.Boolean ResetLoLoFlow)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {ResetLoLoFlow});
    }
    public bool FireEvent_RESET_LO_LO_F(SE.Nereda.Symbols.FlushingManager.RESET_LO_LO_FEventArgs ea)
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
    public bool FireEvent_PUMP_SP(System.Single StartSp, System.Single StopSp)
    {
      return ((IHMIAccessorOutput)this).FireEvent(2, new object[] {StartSp, StopSp});
    }
    public bool FireEvent_PUMP_SP(SE.Nereda.Symbols.FlushingManager.PUMP_SPEventArgs ea)
    {
      object[] _values_ = new object[2];
      if (ea.StartSp.HasValue) _values_[0] = ea.StartSp.Value;
      if (ea.StopSp.HasValue) _values_[1] = ea.StopSp.Value;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_PUMP_SP(System.Single StartSp, bool ignore_StartSp, System.Single StopSp, bool ignore_StopSp)
    {
      object[] _values_ = new object[2];
      if (!ignore_StartSp) _values_[0] = StartSp;
      if (!ignore_StopSp) _values_[1] = StopSp;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }

  }
}

namespace SE.Nereda.Faceplates.FlushingManager
{
  partial class fpGrafcet
  {

    private event EventHandler<SE.Nereda.Symbols.FlushingManager.GRAPHEventArgs> GRAPH_Fired;

    private event EventHandler<SE.Nereda.Symbols.FlushingManager.LEVEL_PVEventArgs> LEVEL_PV_Fired;

    private event EventHandler<SE.Nereda.Symbols.FlushingManager.RESET_BTNsEventArgs> RESET_BTNs_Fired;

    private event EventHandler<SE.Nereda.Symbols.FlushingManager.FLOW_SPEventArgs> FLOW_SP_Fired;

    private event EventHandler<SE.Nereda.Symbols.FlushingManager.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    protected override void OnEndInit()
    {
      if (GRAPH_Fired != null)
        AttachEventInput(0);
      if (LEVEL_PV_Fired != null)
        AttachEventInput(1);
      if (RESET_BTNs_Fired != null)
        AttachEventInput(2);
      if (FLOW_SP_Fired != null)
        AttachEventInput(3);
      if (LOAD_PERS_DATA_Fired != null)
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
              GRAPH_Fired(this, new SE.Nereda.Symbols.FlushingManager.GRAPHEventArgs(channelId, cookie, eventIndex));
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
          if (LEVEL_PV_Fired != null)
          {
            try
            {
              LEVEL_PV_Fired(this, new SE.Nereda.Symbols.FlushingManager.LEVEL_PVEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","LEVEL_PV_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 2:
          if (RESET_BTNs_Fired != null)
          {
            try
            {
              RESET_BTNs_Fired(this, new SE.Nereda.Symbols.FlushingManager.RESET_BTNsEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","RESET_BTNs_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 3:
          if (FLOW_SP_Fired != null)
          {
            try
            {
              FLOW_SP_Fired(this, new SE.Nereda.Symbols.FlushingManager.FLOW_SPEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","FLOW_SP_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 4:
          if (LOAD_PERS_DATA_Fired != null)
          {
            try
            {
              LOAD_PERS_DATA_Fired(this, new SE.Nereda.Symbols.FlushingManager.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
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
    public bool FireEvent_SPEED_CAP_SP(System.Single CapacitySp, System.Single SwitchSpeedSp)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {CapacitySp, SwitchSpeedSp});
    }
    public bool FireEvent_SPEED_CAP_SP(SE.Nereda.Symbols.FlushingManager.SPEED_CAP_SPEventArgs ea)
    {
      object[] _values_ = new object[2];
      if (ea.CapacitySp.HasValue) _values_[0] = ea.CapacitySp.Value;
      if (ea.SwitchSpeedSp.HasValue) _values_[1] = ea.SwitchSpeedSp.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_SPEED_CAP_SP(System.Single CapacitySp, bool ignore_CapacitySp, System.Single SwitchSpeedSp, bool ignore_SwitchSpeedSp)
    {
      object[] _values_ = new object[2];
      if (!ignore_CapacitySp) _values_[0] = CapacitySp;
      if (!ignore_SwitchSpeedSp) _values_[1] = SwitchSpeedSp;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_RESET_LO_LO_F(System.Boolean ResetLoLoFlow)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {ResetLoLoFlow});
    }
    public bool FireEvent_RESET_LO_LO_F(SE.Nereda.Symbols.FlushingManager.RESET_LO_LO_FEventArgs ea)
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
    public bool FireEvent_PUMP_SP(System.Single StartSp, System.Single StopSp)
    {
      return ((IHMIAccessorOutput)this).FireEvent(2, new object[] {StartSp, StopSp});
    }
    public bool FireEvent_PUMP_SP(SE.Nereda.Symbols.FlushingManager.PUMP_SPEventArgs ea)
    {
      object[] _values_ = new object[2];
      if (ea.StartSp.HasValue) _values_[0] = ea.StartSp.Value;
      if (ea.StopSp.HasValue) _values_[1] = ea.StopSp.Value;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_PUMP_SP(System.Single StartSp, bool ignore_StartSp, System.Single StopSp, bool ignore_StopSp)
    {
      object[] _values_ = new object[2];
      if (!ignore_StartSp) _values_[0] = StartSp;
      if (!ignore_StopSp) _values_[1] = StopSp;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }

  }
}

namespace SE.Nereda.Symbols.FlushingManager
{
  partial class sShowLevel
  {

    private event EventHandler<SE.Nereda.Symbols.FlushingManager.GRAPHEventArgs> GRAPH_Fired;

    private event EventHandler<SE.Nereda.Symbols.FlushingManager.LEVEL_PVEventArgs> LEVEL_PV_Fired;

    private event EventHandler<SE.Nereda.Symbols.FlushingManager.RESET_BTNsEventArgs> RESET_BTNs_Fired;

    private event EventHandler<SE.Nereda.Symbols.FlushingManager.FLOW_SPEventArgs> FLOW_SP_Fired;

    private event EventHandler<SE.Nereda.Symbols.FlushingManager.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    protected override void OnEndInit()
    {
      if (GRAPH_Fired != null)
        AttachEventInput(0);
      if (LEVEL_PV_Fired != null)
        AttachEventInput(1);
      if (RESET_BTNs_Fired != null)
        AttachEventInput(2);
      if (FLOW_SP_Fired != null)
        AttachEventInput(3);
      if (LOAD_PERS_DATA_Fired != null)
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
              GRAPH_Fired(this, new SE.Nereda.Symbols.FlushingManager.GRAPHEventArgs(channelId, cookie, eventIndex));
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
          if (LEVEL_PV_Fired != null)
          {
            try
            {
              LEVEL_PV_Fired(this, new SE.Nereda.Symbols.FlushingManager.LEVEL_PVEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","LEVEL_PV_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 2:
          if (RESET_BTNs_Fired != null)
          {
            try
            {
              RESET_BTNs_Fired(this, new SE.Nereda.Symbols.FlushingManager.RESET_BTNsEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","RESET_BTNs_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 3:
          if (FLOW_SP_Fired != null)
          {
            try
            {
              FLOW_SP_Fired(this, new SE.Nereda.Symbols.FlushingManager.FLOW_SPEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","FLOW_SP_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 4:
          if (LOAD_PERS_DATA_Fired != null)
          {
            try
            {
              LOAD_PERS_DATA_Fired(this, new SE.Nereda.Symbols.FlushingManager.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
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
    public bool FireEvent_SPEED_CAP_SP(System.Single CapacitySp, System.Single SwitchSpeedSp)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {CapacitySp, SwitchSpeedSp});
    }
    public bool FireEvent_SPEED_CAP_SP(SE.Nereda.Symbols.FlushingManager.SPEED_CAP_SPEventArgs ea)
    {
      object[] _values_ = new object[2];
      if (ea.CapacitySp.HasValue) _values_[0] = ea.CapacitySp.Value;
      if (ea.SwitchSpeedSp.HasValue) _values_[1] = ea.SwitchSpeedSp.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_SPEED_CAP_SP(System.Single CapacitySp, bool ignore_CapacitySp, System.Single SwitchSpeedSp, bool ignore_SwitchSpeedSp)
    {
      object[] _values_ = new object[2];
      if (!ignore_CapacitySp) _values_[0] = CapacitySp;
      if (!ignore_SwitchSpeedSp) _values_[1] = SwitchSpeedSp;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_RESET_LO_LO_F(System.Boolean ResetLoLoFlow)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {ResetLoLoFlow});
    }
    public bool FireEvent_RESET_LO_LO_F(SE.Nereda.Symbols.FlushingManager.RESET_LO_LO_FEventArgs ea)
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
    public bool FireEvent_PUMP_SP(System.Single StartSp, System.Single StopSp)
    {
      return ((IHMIAccessorOutput)this).FireEvent(2, new object[] {StartSp, StopSp});
    }
    public bool FireEvent_PUMP_SP(SE.Nereda.Symbols.FlushingManager.PUMP_SPEventArgs ea)
    {
      object[] _values_ = new object[2];
      if (ea.StartSp.HasValue) _values_[0] = ea.StartSp.Value;
      if (ea.StopSp.HasValue) _values_[1] = ea.StopSp.Value;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_PUMP_SP(System.Single StartSp, bool ignore_StartSp, System.Single StopSp, bool ignore_StopSp)
    {
      object[] _values_ = new object[2];
      if (!ignore_StartSp) _values_[0] = StartSp;
      if (!ignore_StopSp) _values_[1] = StopSp;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }

  }
}

namespace SE.Nereda.Faceplates.FlushingManager
{
  partial class fpPID
  {

    private event EventHandler<SE.Nereda.Symbols.FlushingManager.GRAPHEventArgs> GRAPH_Fired;

    private event EventHandler<SE.Nereda.Symbols.FlushingManager.LEVEL_PVEventArgs> LEVEL_PV_Fired;

    private event EventHandler<SE.Nereda.Symbols.FlushingManager.RESET_BTNsEventArgs> RESET_BTNs_Fired;

    private event EventHandler<SE.Nereda.Symbols.FlushingManager.FLOW_SPEventArgs> FLOW_SP_Fired;

    private event EventHandler<SE.Nereda.Symbols.FlushingManager.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    protected override void OnEndInit()
    {
      if (GRAPH_Fired != null)
        AttachEventInput(0);
      if (LEVEL_PV_Fired != null)
        AttachEventInput(1);
      if (RESET_BTNs_Fired != null)
        AttachEventInput(2);
      if (FLOW_SP_Fired != null)
        AttachEventInput(3);
      if (LOAD_PERS_DATA_Fired != null)
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
              GRAPH_Fired(this, new SE.Nereda.Symbols.FlushingManager.GRAPHEventArgs(channelId, cookie, eventIndex));
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
          if (LEVEL_PV_Fired != null)
          {
            try
            {
              LEVEL_PV_Fired(this, new SE.Nereda.Symbols.FlushingManager.LEVEL_PVEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","LEVEL_PV_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 2:
          if (RESET_BTNs_Fired != null)
          {
            try
            {
              RESET_BTNs_Fired(this, new SE.Nereda.Symbols.FlushingManager.RESET_BTNsEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","RESET_BTNs_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 3:
          if (FLOW_SP_Fired != null)
          {
            try
            {
              FLOW_SP_Fired(this, new SE.Nereda.Symbols.FlushingManager.FLOW_SPEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","FLOW_SP_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 4:
          if (LOAD_PERS_DATA_Fired != null)
          {
            try
            {
              LOAD_PERS_DATA_Fired(this, new SE.Nereda.Symbols.FlushingManager.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
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
    public bool FireEvent_SPEED_CAP_SP(System.Single CapacitySp, System.Single SwitchSpeedSp)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {CapacitySp, SwitchSpeedSp});
    }
    public bool FireEvent_SPEED_CAP_SP(SE.Nereda.Symbols.FlushingManager.SPEED_CAP_SPEventArgs ea)
    {
      object[] _values_ = new object[2];
      if (ea.CapacitySp.HasValue) _values_[0] = ea.CapacitySp.Value;
      if (ea.SwitchSpeedSp.HasValue) _values_[1] = ea.SwitchSpeedSp.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_SPEED_CAP_SP(System.Single CapacitySp, bool ignore_CapacitySp, System.Single SwitchSpeedSp, bool ignore_SwitchSpeedSp)
    {
      object[] _values_ = new object[2];
      if (!ignore_CapacitySp) _values_[0] = CapacitySp;
      if (!ignore_SwitchSpeedSp) _values_[1] = SwitchSpeedSp;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_RESET_LO_LO_F(System.Boolean ResetLoLoFlow)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {ResetLoLoFlow});
    }
    public bool FireEvent_RESET_LO_LO_F(SE.Nereda.Symbols.FlushingManager.RESET_LO_LO_FEventArgs ea)
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
    public bool FireEvent_PUMP_SP(System.Single StartSp, System.Single StopSp)
    {
      return ((IHMIAccessorOutput)this).FireEvent(2, new object[] {StartSp, StopSp});
    }
    public bool FireEvent_PUMP_SP(SE.Nereda.Symbols.FlushingManager.PUMP_SPEventArgs ea)
    {
      object[] _values_ = new object[2];
      if (ea.StartSp.HasValue) _values_[0] = ea.StartSp.Value;
      if (ea.StopSp.HasValue) _values_[1] = ea.StopSp.Value;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_PUMP_SP(System.Single StartSp, bool ignore_StartSp, System.Single StopSp, bool ignore_StopSp)
    {
      object[] _values_ = new object[2];
      if (!ignore_StartSp) _values_[0] = StartSp;
      if (!ignore_StopSp) _values_[1] = StopSp;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }

  }
}

namespace SE.Nereda.Symbols.FlushingManager
{
  partial class sPID
  {

    private event EventHandler<SE.Nereda.Symbols.FlushingManager.GRAPHEventArgs> GRAPH_Fired;

    private event EventHandler<SE.Nereda.Symbols.FlushingManager.LEVEL_PVEventArgs> LEVEL_PV_Fired;

    private event EventHandler<SE.Nereda.Symbols.FlushingManager.RESET_BTNsEventArgs> RESET_BTNs_Fired;

    private event EventHandler<SE.Nereda.Symbols.FlushingManager.FLOW_SPEventArgs> FLOW_SP_Fired;

    private event EventHandler<SE.Nereda.Symbols.FlushingManager.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    protected override void OnEndInit()
    {
      if (GRAPH_Fired != null)
        AttachEventInput(0);
      if (LEVEL_PV_Fired != null)
        AttachEventInput(1);
      if (RESET_BTNs_Fired != null)
        AttachEventInput(2);
      if (FLOW_SP_Fired != null)
        AttachEventInput(3);
      if (LOAD_PERS_DATA_Fired != null)
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
              GRAPH_Fired(this, new SE.Nereda.Symbols.FlushingManager.GRAPHEventArgs(channelId, cookie, eventIndex));
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
          if (LEVEL_PV_Fired != null)
          {
            try
            {
              LEVEL_PV_Fired(this, new SE.Nereda.Symbols.FlushingManager.LEVEL_PVEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","LEVEL_PV_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 2:
          if (RESET_BTNs_Fired != null)
          {
            try
            {
              RESET_BTNs_Fired(this, new SE.Nereda.Symbols.FlushingManager.RESET_BTNsEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","RESET_BTNs_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 3:
          if (FLOW_SP_Fired != null)
          {
            try
            {
              FLOW_SP_Fired(this, new SE.Nereda.Symbols.FlushingManager.FLOW_SPEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","FLOW_SP_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 4:
          if (LOAD_PERS_DATA_Fired != null)
          {
            try
            {
              LOAD_PERS_DATA_Fired(this, new SE.Nereda.Symbols.FlushingManager.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
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
    public bool FireEvent_SPEED_CAP_SP(System.Single CapacitySp, System.Single SwitchSpeedSp)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {CapacitySp, SwitchSpeedSp});
    }
    public bool FireEvent_SPEED_CAP_SP(SE.Nereda.Symbols.FlushingManager.SPEED_CAP_SPEventArgs ea)
    {
      object[] _values_ = new object[2];
      if (ea.CapacitySp.HasValue) _values_[0] = ea.CapacitySp.Value;
      if (ea.SwitchSpeedSp.HasValue) _values_[1] = ea.SwitchSpeedSp.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_SPEED_CAP_SP(System.Single CapacitySp, bool ignore_CapacitySp, System.Single SwitchSpeedSp, bool ignore_SwitchSpeedSp)
    {
      object[] _values_ = new object[2];
      if (!ignore_CapacitySp) _values_[0] = CapacitySp;
      if (!ignore_SwitchSpeedSp) _values_[1] = SwitchSpeedSp;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_RESET_LO_LO_F(System.Boolean ResetLoLoFlow)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {ResetLoLoFlow});
    }
    public bool FireEvent_RESET_LO_LO_F(SE.Nereda.Symbols.FlushingManager.RESET_LO_LO_FEventArgs ea)
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
    public bool FireEvent_PUMP_SP(System.Single StartSp, System.Single StopSp)
    {
      return ((IHMIAccessorOutput)this).FireEvent(2, new object[] {StartSp, StopSp});
    }
    public bool FireEvent_PUMP_SP(SE.Nereda.Symbols.FlushingManager.PUMP_SPEventArgs ea)
    {
      object[] _values_ = new object[2];
      if (ea.StartSp.HasValue) _values_[0] = ea.StartSp.Value;
      if (ea.StopSp.HasValue) _values_[1] = ea.StopSp.Value;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_PUMP_SP(System.Single StartSp, bool ignore_StartSp, System.Single StopSp, bool ignore_StopSp)
    {
      object[] _values_ = new object[2];
      if (!ignore_StartSp) _values_[0] = StartSp;
      if (!ignore_StopSp) _values_[1] = StopSp;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }

  }
}

namespace SE.Nereda.Symbols.FlushingManager
{
  partial class sFlushFlowSp
  {

    private event EventHandler<SE.Nereda.Symbols.FlushingManager.GRAPHEventArgs> GRAPH_Fired;

    private event EventHandler<SE.Nereda.Symbols.FlushingManager.LEVEL_PVEventArgs> LEVEL_PV_Fired;

    private event EventHandler<SE.Nereda.Symbols.FlushingManager.RESET_BTNsEventArgs> RESET_BTNs_Fired;

    private event EventHandler<SE.Nereda.Symbols.FlushingManager.FLOW_SPEventArgs> FLOW_SP_Fired;

    private event EventHandler<SE.Nereda.Symbols.FlushingManager.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    protected override void OnEndInit()
    {
      if (GRAPH_Fired != null)
        AttachEventInput(0);
      if (LEVEL_PV_Fired != null)
        AttachEventInput(1);
      if (RESET_BTNs_Fired != null)
        AttachEventInput(2);
      if (FLOW_SP_Fired != null)
        AttachEventInput(3);
      if (LOAD_PERS_DATA_Fired != null)
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
              GRAPH_Fired(this, new SE.Nereda.Symbols.FlushingManager.GRAPHEventArgs(channelId, cookie, eventIndex));
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
          if (LEVEL_PV_Fired != null)
          {
            try
            {
              LEVEL_PV_Fired(this, new SE.Nereda.Symbols.FlushingManager.LEVEL_PVEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","LEVEL_PV_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 2:
          if (RESET_BTNs_Fired != null)
          {
            try
            {
              RESET_BTNs_Fired(this, new SE.Nereda.Symbols.FlushingManager.RESET_BTNsEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","RESET_BTNs_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 3:
          if (FLOW_SP_Fired != null)
          {
            try
            {
              FLOW_SP_Fired(this, new SE.Nereda.Symbols.FlushingManager.FLOW_SPEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","FLOW_SP_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 4:
          if (LOAD_PERS_DATA_Fired != null)
          {
            try
            {
              LOAD_PERS_DATA_Fired(this, new SE.Nereda.Symbols.FlushingManager.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
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
    public bool FireEvent_SPEED_CAP_SP(System.Single CapacitySp, System.Single SwitchSpeedSp)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {CapacitySp, SwitchSpeedSp});
    }
    public bool FireEvent_SPEED_CAP_SP(SE.Nereda.Symbols.FlushingManager.SPEED_CAP_SPEventArgs ea)
    {
      object[] _values_ = new object[2];
      if (ea.CapacitySp.HasValue) _values_[0] = ea.CapacitySp.Value;
      if (ea.SwitchSpeedSp.HasValue) _values_[1] = ea.SwitchSpeedSp.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_SPEED_CAP_SP(System.Single CapacitySp, bool ignore_CapacitySp, System.Single SwitchSpeedSp, bool ignore_SwitchSpeedSp)
    {
      object[] _values_ = new object[2];
      if (!ignore_CapacitySp) _values_[0] = CapacitySp;
      if (!ignore_SwitchSpeedSp) _values_[1] = SwitchSpeedSp;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_RESET_LO_LO_F(System.Boolean ResetLoLoFlow)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {ResetLoLoFlow});
    }
    public bool FireEvent_RESET_LO_LO_F(SE.Nereda.Symbols.FlushingManager.RESET_LO_LO_FEventArgs ea)
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
    public bool FireEvent_PUMP_SP(System.Single StartSp, System.Single StopSp)
    {
      return ((IHMIAccessorOutput)this).FireEvent(2, new object[] {StartSp, StopSp});
    }
    public bool FireEvent_PUMP_SP(SE.Nereda.Symbols.FlushingManager.PUMP_SPEventArgs ea)
    {
      object[] _values_ = new object[2];
      if (ea.StartSp.HasValue) _values_[0] = ea.StartSp.Value;
      if (ea.StopSp.HasValue) _values_[1] = ea.StopSp.Value;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_PUMP_SP(System.Single StartSp, bool ignore_StartSp, System.Single StopSp, bool ignore_StopSp)
    {
      object[] _values_ = new object[2];
      if (!ignore_StartSp) _values_[0] = StartSp;
      if (!ignore_StopSp) _values_[1] = StopSp;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }

  }
}
#endregion #FlushingManager_HMI;

#endregion Definitions;
