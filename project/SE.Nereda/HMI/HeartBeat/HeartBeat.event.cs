/*
 * Created by EcoStruxure Automation Expert.
 * User: SESA197029
 * Date: 25/02/2022
 * Time: 3:53 pm
 * 
 */
using System;
using NxtControl.GuiFramework;
using NxtControl.Services;

#region Definitions;
#region #HeartBeat_HMI;

namespace SE.Nereda.Symbols.HeartBeat
{

  public class REQEventArgs : System.EventArgs
  {
    IHMIAccessorService accessorService;
    int channelId;
    int cookie; 
    int eventIndex;

    public REQEventArgs(int channelId, int cookie, int eventIndex)
    {
      this.accessorService = (IHMIAccessorService)ServiceProvider.GetService(typeof(IHMIAccessorService));
      this.channelId = channelId;
      this.cookie = cookie;
      this.eventIndex = eventIndex;
    }
    public bool Get_HeartBeat_PLC_to_Nereda(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,0, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? HeartBeat_PLC_to_Nereda
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,0, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }


  }

  public class New_StateEventArgs : System.EventArgs
  {
    IHMIAccessorService accessorService;
    int channelId;
    int cookie; 
    int eventIndex;

    public New_StateEventArgs(int channelId, int cookie, int eventIndex)
    {
      this.accessorService = (IHMIAccessorService)ServiceProvider.GetService(typeof(IHMIAccessorService));
      this.channelId = channelId;
      this.cookie = cookie;
      this.eventIndex = eventIndex;
    }
    public bool Get_State(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,0, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? State
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

}

namespace SE.Nereda.Symbols.HeartBeat
{

  public class CNFEventArgs : System.EventArgs
  {
    public CNFEventArgs()
    {
    }
    private System.Boolean? HeartBeat_Nereda_to_PLC_field = null;
    public System.Boolean? HeartBeat_Nereda_to_PLC
    {
       get { return HeartBeat_Nereda_to_PLC_field; }
       set { HeartBeat_Nereda_to_PLC_field = value; }
    }

  }

  public class WATCH_DOG_T_OEventArgs : System.EventArgs
  {
    public WATCH_DOG_T_OEventArgs()
    {
    }
    private NxtControl.GuiFramework.Time? Watchdog_field = null;
    public NxtControl.GuiFramework.Time? Watchdog
    {
       get { return Watchdog_field; }
       set { Watchdog_field = value; }
    }

  }

  public class SIMEventArgs : System.EventArgs
  {
    public SIMEventArgs()
    {
    }
    private System.Boolean? EnableSim_field = null;
    public System.Boolean? EnableSim
    {
       get { return EnableSim_field; }
       set { EnableSim_field = value; }
    }

  }

}

namespace SE.Nereda.Symbols.HeartBeat
{
  partial class sDefault
  {

    private event EventHandler<SE.Nereda.Symbols.HeartBeat.REQEventArgs> REQ_Fired;

    private event EventHandler<SE.Nereda.Symbols.HeartBeat.New_StateEventArgs> New_State_Fired;

    private event EventHandler<SE.Nereda.Symbols.HeartBeat.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    protected override void OnEndInit()
    {
      if (REQ_Fired != null)
        AttachEventInput(0);
      if (New_State_Fired != null)
        AttachEventInput(1);
      if (LOAD_PERS_DATA_Fired != null)
        AttachEventInput(2);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (REQ_Fired != null)
          {
            try
            {
              REQ_Fired(this, new SE.Nereda.Symbols.HeartBeat.REQEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REQ_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 1:
          if (New_State_Fired != null)
          {
            try
            {
              New_State_Fired(this, new SE.Nereda.Symbols.HeartBeat.New_StateEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","New_State_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 2:
          if (LOAD_PERS_DATA_Fired != null)
          {
            try
            {
              LOAD_PERS_DATA_Fired(this, new SE.Nereda.Symbols.HeartBeat.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
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
    public bool FireEvent_CNF(System.Boolean HeartBeat_Nereda_to_PLC)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {HeartBeat_Nereda_to_PLC});
    }
    public bool FireEvent_CNF(SE.Nereda.Symbols.HeartBeat.CNFEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.HeartBeat_Nereda_to_PLC.HasValue) _values_[0] = ea.HeartBeat_Nereda_to_PLC.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_CNF(System.Boolean HeartBeat_Nereda_to_PLC, bool ignore_HeartBeat_Nereda_to_PLC)
    {
      object[] _values_ = new object[1];
      if (!ignore_HeartBeat_Nereda_to_PLC) _values_[0] = HeartBeat_Nereda_to_PLC;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_WATCH_DOG_T_O(NxtControl.GuiFramework.Time Watchdog)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {Watchdog});
    }
    public bool FireEvent_WATCH_DOG_T_O(SE.Nereda.Symbols.HeartBeat.WATCH_DOG_T_OEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.Watchdog.HasValue) _values_[0] = ea.Watchdog.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_WATCH_DOG_T_O(NxtControl.GuiFramework.Time Watchdog, bool ignore_Watchdog)
    {
      object[] _values_ = new object[1];
      if (!ignore_Watchdog) _values_[0] = Watchdog;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_SIM(System.Boolean EnableSim)
    {
      return ((IHMIAccessorOutput)this).FireEvent(2, new object[] {EnableSim});
    }
    public bool FireEvent_SIM(SE.Nereda.Symbols.HeartBeat.SIMEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.EnableSim.HasValue) _values_[0] = ea.EnableSim.Value;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_SIM(System.Boolean EnableSim, bool ignore_EnableSim)
    {
      object[] _values_ = new object[1];
      if (!ignore_EnableSim) _values_[0] = EnableSim;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }

  }
}

namespace SE.Nereda.Faceplates.HeartBeat
{
  partial class WatchdogConfiguration
  {

    private event EventHandler<SE.Nereda.Symbols.HeartBeat.REQEventArgs> REQ_Fired;

    private event EventHandler<SE.Nereda.Symbols.HeartBeat.New_StateEventArgs> New_State_Fired;

    private event EventHandler<SE.Nereda.Symbols.HeartBeat.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    protected override void OnEndInit()
    {
      if (REQ_Fired != null)
        AttachEventInput(0);
      if (New_State_Fired != null)
        AttachEventInput(1);
      if (LOAD_PERS_DATA_Fired != null)
        AttachEventInput(2);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (REQ_Fired != null)
          {
            try
            {
              REQ_Fired(this, new SE.Nereda.Symbols.HeartBeat.REQEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REQ_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 1:
          if (New_State_Fired != null)
          {
            try
            {
              New_State_Fired(this, new SE.Nereda.Symbols.HeartBeat.New_StateEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","New_State_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 2:
          if (LOAD_PERS_DATA_Fired != null)
          {
            try
            {
              LOAD_PERS_DATA_Fired(this, new SE.Nereda.Symbols.HeartBeat.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
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
    public bool FireEvent_CNF(System.Boolean HeartBeat_Nereda_to_PLC)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {HeartBeat_Nereda_to_PLC});
    }
    public bool FireEvent_CNF(SE.Nereda.Symbols.HeartBeat.CNFEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.HeartBeat_Nereda_to_PLC.HasValue) _values_[0] = ea.HeartBeat_Nereda_to_PLC.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_CNF(System.Boolean HeartBeat_Nereda_to_PLC, bool ignore_HeartBeat_Nereda_to_PLC)
    {
      object[] _values_ = new object[1];
      if (!ignore_HeartBeat_Nereda_to_PLC) _values_[0] = HeartBeat_Nereda_to_PLC;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_WATCH_DOG_T_O(NxtControl.GuiFramework.Time Watchdog)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {Watchdog});
    }
    public bool FireEvent_WATCH_DOG_T_O(SE.Nereda.Symbols.HeartBeat.WATCH_DOG_T_OEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.Watchdog.HasValue) _values_[0] = ea.Watchdog.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_WATCH_DOG_T_O(NxtControl.GuiFramework.Time Watchdog, bool ignore_Watchdog)
    {
      object[] _values_ = new object[1];
      if (!ignore_Watchdog) _values_[0] = Watchdog;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_SIM(System.Boolean EnableSim)
    {
      return ((IHMIAccessorOutput)this).FireEvent(2, new object[] {EnableSim});
    }
    public bool FireEvent_SIM(SE.Nereda.Symbols.HeartBeat.SIMEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.EnableSim.HasValue) _values_[0] = ea.EnableSim.Value;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_SIM(System.Boolean EnableSim, bool ignore_EnableSim)
    {
      object[] _values_ = new object[1];
      if (!ignore_EnableSim) _values_[0] = EnableSim;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }

  }
}
#endregion #HeartBeat_HMI;

#endregion Definitions;
