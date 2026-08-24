/*
 * Created by EcoStruxure Automation Expert.
 * User: SESA685388
 * Date: 10/24/2023
 * Time: 10:47 PM
 * 
 */
using System;
using NxtControl.GuiFramework;
using NxtControl.Services;

#region Definitions;
#region #SludgeBufferLogic_2_HMI;

namespace SE.Nereda.Symbols.SludgeBufferLogic_2
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
    public bool Get_LevelPv(ref System.Single value)
    {
      if (accessorService == null)
        return false;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,0, ref var);
      if (ret) value = (System.Single) var;
      return ret;
    }

    public System.Single? LevelPv
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

    public bool Get_LevelPvMax(ref System.Single value)
    {
      if (accessorService == null)
        return false;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,2, ref var);
      if (ret) value = (System.Single) var;
      return ret;
    }

    public System.Single? LevelPvMax
    { get {
      if (accessorService == null)
        return null;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,2, ref var);
      if (!ret) return null;
      return (System.Single) var;
    }  }


  }

  public class HI_HI_LEventArgs : System.EventArgs
  {
    IHMIAccessorService accessorService;
    int channelId;
    int cookie; 
    int eventIndex;

    public HI_HI_LEventArgs(int channelId, int cookie, int eventIndex)
    {
      this.accessorService = (IHMIAccessorService)ServiceProvider.GetService(typeof(IHMIAccessorService));
      this.channelId = channelId;
      this.cookie = cookie;
      this.eventIndex = eventIndex;
    }
    public bool Get_LevelHiHi(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,0, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? LevelHiHi
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

namespace SE.Nereda.Symbols.SludgeBufferLogic_2
{

  public class SPEED_SPEventArgs : System.EventArgs
  {
    public SPEED_SPEventArgs()
    {
    }
    private System.Single? SpeedSp_field = null;
    public System.Single? SpeedSp
    {
       get { return SpeedSp_field; }
       set { SpeedSp_field = value; }
    }

  }

  public class RESET_LL_FEventArgs : System.EventArgs
  {
    public RESET_LL_FEventArgs()
    {
    }
    private System.Boolean? ResetLoLoFlow_field = null;
    public System.Boolean? ResetLoLoFlow
    {
       get { return ResetLoLoFlow_field; }
       set { ResetLoLoFlow_field = value; }
    }

  }

}

namespace SE.Nereda.Symbols.SludgeBufferLogic_2
{
  partial class sSLB
  {

    private event EventHandler<SE.Nereda.Symbols.SludgeBufferLogic_2.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    private event EventHandler<SE.Nereda.Symbols.SludgeBufferLogic_2.GRAPHEventArgs> GRAPH_Fired;

    private event EventHandler<SE.Nereda.Symbols.SludgeBufferLogic_2.LEVEL_PVEventArgs> LEVEL_PV_Fired;

    private event EventHandler<SE.Nereda.Symbols.SludgeBufferLogic_2.HI_HI_LEventArgs> HI_HI_L_Fired;

    protected override void OnEndInit()
    {
      if (LOAD_PERS_DATA_Fired != null)
        AttachEventInput(0);
      if (GRAPH_Fired != null)
        AttachEventInput(1);
      if (LEVEL_PV_Fired != null)
        AttachEventInput(2);
      if (HI_HI_L_Fired != null)
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
              LOAD_PERS_DATA_Fired(this, new SE.Nereda.Symbols.SludgeBufferLogic_2.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
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
              GRAPH_Fired(this, new SE.Nereda.Symbols.SludgeBufferLogic_2.GRAPHEventArgs(channelId, cookie, eventIndex));
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
          if (LEVEL_PV_Fired != null)
          {
            try
            {
              LEVEL_PV_Fired(this, new SE.Nereda.Symbols.SludgeBufferLogic_2.LEVEL_PVEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","LEVEL_PV_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 3:
          if (HI_HI_L_Fired != null)
          {
            try
            {
              HI_HI_L_Fired(this, new SE.Nereda.Symbols.SludgeBufferLogic_2.HI_HI_LEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","HI_HI_L_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_SPEED_SP(System.Single SpeedSp)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {SpeedSp});
    }
    public bool FireEvent_SPEED_SP(SE.Nereda.Symbols.SludgeBufferLogic_2.SPEED_SPEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.SpeedSp.HasValue) _values_[0] = ea.SpeedSp.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_SPEED_SP(System.Single SpeedSp, bool ignore_SpeedSp)
    {
      object[] _values_ = new object[1];
      if (!ignore_SpeedSp) _values_[0] = SpeedSp;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_RESET_LL_F(System.Boolean ResetLoLoFlow)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {ResetLoLoFlow});
    }
    public bool FireEvent_RESET_LL_F(SE.Nereda.Symbols.SludgeBufferLogic_2.RESET_LL_FEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.ResetLoLoFlow.HasValue) _values_[0] = ea.ResetLoLoFlow.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_RESET_LL_F(System.Boolean ResetLoLoFlow, bool ignore_ResetLoLoFlow)
    {
      object[] _values_ = new object[1];
      if (!ignore_ResetLoLoFlow) _values_[0] = ResetLoLoFlow;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }

  }
}

namespace SE.Nereda.Symbols.SludgeBufferLogic_2
{
  partial class sDefault
  {

    private event EventHandler<SE.Nereda.Symbols.SludgeBufferLogic_2.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    private event EventHandler<SE.Nereda.Symbols.SludgeBufferLogic_2.GRAPHEventArgs> GRAPH_Fired;

    private event EventHandler<SE.Nereda.Symbols.SludgeBufferLogic_2.LEVEL_PVEventArgs> LEVEL_PV_Fired;

    private event EventHandler<SE.Nereda.Symbols.SludgeBufferLogic_2.HI_HI_LEventArgs> HI_HI_L_Fired;

    protected override void OnEndInit()
    {
      if (LOAD_PERS_DATA_Fired != null)
        AttachEventInput(0);
      if (GRAPH_Fired != null)
        AttachEventInput(1);
      if (LEVEL_PV_Fired != null)
        AttachEventInput(2);
      if (HI_HI_L_Fired != null)
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
              LOAD_PERS_DATA_Fired(this, new SE.Nereda.Symbols.SludgeBufferLogic_2.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
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
              GRAPH_Fired(this, new SE.Nereda.Symbols.SludgeBufferLogic_2.GRAPHEventArgs(channelId, cookie, eventIndex));
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
          if (LEVEL_PV_Fired != null)
          {
            try
            {
              LEVEL_PV_Fired(this, new SE.Nereda.Symbols.SludgeBufferLogic_2.LEVEL_PVEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","LEVEL_PV_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 3:
          if (HI_HI_L_Fired != null)
          {
            try
            {
              HI_HI_L_Fired(this, new SE.Nereda.Symbols.SludgeBufferLogic_2.HI_HI_LEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","HI_HI_L_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_SPEED_SP(System.Single SpeedSp)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {SpeedSp});
    }
    public bool FireEvent_SPEED_SP(SE.Nereda.Symbols.SludgeBufferLogic_2.SPEED_SPEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.SpeedSp.HasValue) _values_[0] = ea.SpeedSp.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_SPEED_SP(System.Single SpeedSp, bool ignore_SpeedSp)
    {
      object[] _values_ = new object[1];
      if (!ignore_SpeedSp) _values_[0] = SpeedSp;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_RESET_LL_F(System.Boolean ResetLoLoFlow)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {ResetLoLoFlow});
    }
    public bool FireEvent_RESET_LL_F(SE.Nereda.Symbols.SludgeBufferLogic_2.RESET_LL_FEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.ResetLoLoFlow.HasValue) _values_[0] = ea.ResetLoLoFlow.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_RESET_LL_F(System.Boolean ResetLoLoFlow, bool ignore_ResetLoLoFlow)
    {
      object[] _values_ = new object[1];
      if (!ignore_ResetLoLoFlow) _values_[0] = ResetLoLoFlow;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }

  }
}
#endregion #SludgeBufferLogic_2_HMI;

#endregion Definitions;
