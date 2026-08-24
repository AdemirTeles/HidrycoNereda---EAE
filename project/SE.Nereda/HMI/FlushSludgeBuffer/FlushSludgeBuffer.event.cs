/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 6/19/2026
 * Time: 3:20 PM
 * 
 */
using System;
using NxtControl.GuiFramework;
using NxtControl.Services;

#region Definitions;
#region #FlushSludgeBuffer_HMI;

namespace SE.Nereda.Symbols.FlushSludgeBuffer
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

}

namespace SE.Nereda.Symbols.FlushSludgeBuffer
{

  public class FLUSH_SPEventArgs : System.EventArgs
  {
    public FLUSH_SPEventArgs()
    {
    }
    private NxtControl.GuiFramework.Time? FlushDuration_field = null;
    public NxtControl.GuiFramework.Time? FlushDuration
    {
       get { return FlushDuration_field; }
       set { FlushDuration_field = value; }
    }
    private System.Single? FlushFlowSp_field = null;
    public System.Single? FlushFlowSp
    {
       get { return FlushFlowSp_field; }
       set { FlushFlowSp_field = value; }
    }
    private System.Single? FlushStartSp_field = null;
    public System.Single? FlushStartSp
    {
       get { return FlushStartSp_field; }
       set { FlushStartSp_field = value; }
    }

  }

  public class START_FLUSHEventArgs : System.EventArgs
  {
    public START_FLUSHEventArgs()
    {
    }
    private System.Boolean? StartFlush_field = null;
    public System.Boolean? StartFlush
    {
       get { return StartFlush_field; }
       set { StartFlush_field = value; }
    }
    private System.Boolean? StopFlush_field = null;
    public System.Boolean? StopFlush
    {
       get { return StopFlush_field; }
       set { StopFlush_field = value; }
    }

  }

}

namespace SE.Nereda.Symbols.FlushSludgeBuffer
{
  partial class sDefault
  {

    private event EventHandler<SE.Nereda.Symbols.FlushSludgeBuffer.GRAPHEventArgs> GRAPH_Fired;

    private event EventHandler<SE.Nereda.Symbols.FlushSludgeBuffer.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    private event EventHandler<SE.Nereda.Symbols.FlushSludgeBuffer.RESET_BTNsEventArgs> RESET_BTNs_Fired;

    protected override void OnEndInit()
    {
      if (GRAPH_Fired != null)
        AttachEventInput(0);
      if (LOAD_PERS_DATA_Fired != null)
        AttachEventInput(1);
      if (RESET_BTNs_Fired != null)
        AttachEventInput(2);

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
              GRAPH_Fired(this, new SE.Nereda.Symbols.FlushSludgeBuffer.GRAPHEventArgs(channelId, cookie, eventIndex));
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
          if (LOAD_PERS_DATA_Fired != null)
          {
            try
            {
              LOAD_PERS_DATA_Fired(this, new SE.Nereda.Symbols.FlushSludgeBuffer.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","LOAD_PERS_DATA_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 2:
          if (RESET_BTNs_Fired != null)
          {
            try
            {
              RESET_BTNs_Fired(this, new SE.Nereda.Symbols.FlushSludgeBuffer.RESET_BTNsEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","RESET_BTNs_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_FLUSH_SP(NxtControl.GuiFramework.Time FlushDuration, System.Single FlushFlowSp, System.Single FlushStartSp)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {FlushDuration, FlushFlowSp, FlushStartSp});
    }
    public bool FireEvent_FLUSH_SP(SE.Nereda.Symbols.FlushSludgeBuffer.FLUSH_SPEventArgs ea)
    {
      object[] _values_ = new object[3];
      if (ea.FlushDuration.HasValue) _values_[0] = ea.FlushDuration.Value;
      if (ea.FlushFlowSp.HasValue) _values_[1] = ea.FlushFlowSp.Value;
      if (ea.FlushStartSp.HasValue) _values_[2] = ea.FlushStartSp.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_FLUSH_SP(NxtControl.GuiFramework.Time FlushDuration, bool ignore_FlushDuration, System.Single FlushFlowSp, bool ignore_FlushFlowSp, System.Single FlushStartSp, bool ignore_FlushStartSp)
    {
      object[] _values_ = new object[3];
      if (!ignore_FlushDuration) _values_[0] = FlushDuration;
      if (!ignore_FlushFlowSp) _values_[1] = FlushFlowSp;
      if (!ignore_FlushStartSp) _values_[2] = FlushStartSp;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_START_FLUSH(System.Boolean StartFlush, System.Boolean StopFlush)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {StartFlush, StopFlush});
    }
    public bool FireEvent_START_FLUSH(SE.Nereda.Symbols.FlushSludgeBuffer.START_FLUSHEventArgs ea)
    {
      object[] _values_ = new object[2];
      if (ea.StartFlush.HasValue) _values_[0] = ea.StartFlush.Value;
      if (ea.StopFlush.HasValue) _values_[1] = ea.StopFlush.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_START_FLUSH(System.Boolean StartFlush, bool ignore_StartFlush, System.Boolean StopFlush, bool ignore_StopFlush)
    {
      object[] _values_ = new object[2];
      if (!ignore_StartFlush) _values_[0] = StartFlush;
      if (!ignore_StopFlush) _values_[1] = StopFlush;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }

  }
}

namespace SE.Nereda.Faceplates.FlushSludgeBuffer
{
  partial class fpCtrl
  {

    private event EventHandler<SE.Nereda.Symbols.FlushSludgeBuffer.GRAPHEventArgs> GRAPH_Fired;

    private event EventHandler<SE.Nereda.Symbols.FlushSludgeBuffer.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    private event EventHandler<SE.Nereda.Symbols.FlushSludgeBuffer.RESET_BTNsEventArgs> RESET_BTNs_Fired;

    protected override void OnEndInit()
    {
      if (GRAPH_Fired != null)
        AttachEventInput(0);
      if (LOAD_PERS_DATA_Fired != null)
        AttachEventInput(1);
      if (RESET_BTNs_Fired != null)
        AttachEventInput(2);

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
              GRAPH_Fired(this, new SE.Nereda.Symbols.FlushSludgeBuffer.GRAPHEventArgs(channelId, cookie, eventIndex));
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
          if (LOAD_PERS_DATA_Fired != null)
          {
            try
            {
              LOAD_PERS_DATA_Fired(this, new SE.Nereda.Symbols.FlushSludgeBuffer.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","LOAD_PERS_DATA_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 2:
          if (RESET_BTNs_Fired != null)
          {
            try
            {
              RESET_BTNs_Fired(this, new SE.Nereda.Symbols.FlushSludgeBuffer.RESET_BTNsEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","RESET_BTNs_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_FLUSH_SP(NxtControl.GuiFramework.Time FlushDuration, System.Single FlushFlowSp, System.Single FlushStartSp)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {FlushDuration, FlushFlowSp, FlushStartSp});
    }
    public bool FireEvent_FLUSH_SP(SE.Nereda.Symbols.FlushSludgeBuffer.FLUSH_SPEventArgs ea)
    {
      object[] _values_ = new object[3];
      if (ea.FlushDuration.HasValue) _values_[0] = ea.FlushDuration.Value;
      if (ea.FlushFlowSp.HasValue) _values_[1] = ea.FlushFlowSp.Value;
      if (ea.FlushStartSp.HasValue) _values_[2] = ea.FlushStartSp.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_FLUSH_SP(NxtControl.GuiFramework.Time FlushDuration, bool ignore_FlushDuration, System.Single FlushFlowSp, bool ignore_FlushFlowSp, System.Single FlushStartSp, bool ignore_FlushStartSp)
    {
      object[] _values_ = new object[3];
      if (!ignore_FlushDuration) _values_[0] = FlushDuration;
      if (!ignore_FlushFlowSp) _values_[1] = FlushFlowSp;
      if (!ignore_FlushStartSp) _values_[2] = FlushStartSp;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_START_FLUSH(System.Boolean StartFlush, System.Boolean StopFlush)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {StartFlush, StopFlush});
    }
    public bool FireEvent_START_FLUSH(SE.Nereda.Symbols.FlushSludgeBuffer.START_FLUSHEventArgs ea)
    {
      object[] _values_ = new object[2];
      if (ea.StartFlush.HasValue) _values_[0] = ea.StartFlush.Value;
      if (ea.StopFlush.HasValue) _values_[1] = ea.StopFlush.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_START_FLUSH(System.Boolean StartFlush, bool ignore_StartFlush, System.Boolean StopFlush, bool ignore_StopFlush)
    {
      object[] _values_ = new object[2];
      if (!ignore_StartFlush) _values_[0] = StartFlush;
      if (!ignore_StopFlush) _values_[1] = StopFlush;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }

  }
}

namespace SE.Nereda.Symbols.FlushSludgeBuffer
{
  partial class sSettings
  {

    private event EventHandler<SE.Nereda.Symbols.FlushSludgeBuffer.GRAPHEventArgs> GRAPH_Fired;

    private event EventHandler<SE.Nereda.Symbols.FlushSludgeBuffer.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    private event EventHandler<SE.Nereda.Symbols.FlushSludgeBuffer.RESET_BTNsEventArgs> RESET_BTNs_Fired;

    protected override void OnEndInit()
    {
      if (GRAPH_Fired != null)
        AttachEventInput(0);
      if (LOAD_PERS_DATA_Fired != null)
        AttachEventInput(1);
      if (RESET_BTNs_Fired != null)
        AttachEventInput(2);

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
              GRAPH_Fired(this, new SE.Nereda.Symbols.FlushSludgeBuffer.GRAPHEventArgs(channelId, cookie, eventIndex));
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
          if (LOAD_PERS_DATA_Fired != null)
          {
            try
            {
              LOAD_PERS_DATA_Fired(this, new SE.Nereda.Symbols.FlushSludgeBuffer.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","LOAD_PERS_DATA_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 2:
          if (RESET_BTNs_Fired != null)
          {
            try
            {
              RESET_BTNs_Fired(this, new SE.Nereda.Symbols.FlushSludgeBuffer.RESET_BTNsEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","RESET_BTNs_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_FLUSH_SP(NxtControl.GuiFramework.Time FlushDuration, System.Single FlushFlowSp, System.Single FlushStartSp)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {FlushDuration, FlushFlowSp, FlushStartSp});
    }
    public bool FireEvent_FLUSH_SP(SE.Nereda.Symbols.FlushSludgeBuffer.FLUSH_SPEventArgs ea)
    {
      object[] _values_ = new object[3];
      if (ea.FlushDuration.HasValue) _values_[0] = ea.FlushDuration.Value;
      if (ea.FlushFlowSp.HasValue) _values_[1] = ea.FlushFlowSp.Value;
      if (ea.FlushStartSp.HasValue) _values_[2] = ea.FlushStartSp.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_FLUSH_SP(NxtControl.GuiFramework.Time FlushDuration, bool ignore_FlushDuration, System.Single FlushFlowSp, bool ignore_FlushFlowSp, System.Single FlushStartSp, bool ignore_FlushStartSp)
    {
      object[] _values_ = new object[3];
      if (!ignore_FlushDuration) _values_[0] = FlushDuration;
      if (!ignore_FlushFlowSp) _values_[1] = FlushFlowSp;
      if (!ignore_FlushStartSp) _values_[2] = FlushStartSp;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_START_FLUSH(System.Boolean StartFlush, System.Boolean StopFlush)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {StartFlush, StopFlush});
    }
    public bool FireEvent_START_FLUSH(SE.Nereda.Symbols.FlushSludgeBuffer.START_FLUSHEventArgs ea)
    {
      object[] _values_ = new object[2];
      if (ea.StartFlush.HasValue) _values_[0] = ea.StartFlush.Value;
      if (ea.StopFlush.HasValue) _values_[1] = ea.StopFlush.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_START_FLUSH(System.Boolean StartFlush, bool ignore_StartFlush, System.Boolean StopFlush, bool ignore_StopFlush)
    {
      object[] _values_ = new object[2];
      if (!ignore_StartFlush) _values_[0] = StartFlush;
      if (!ignore_StopFlush) _values_[1] = StopFlush;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }

  }
}

namespace SE.Nereda.Symbols.FlushSludgeBuffer
{
  partial class sInfos
  {

    private event EventHandler<SE.Nereda.Symbols.FlushSludgeBuffer.GRAPHEventArgs> GRAPH_Fired;

    private event EventHandler<SE.Nereda.Symbols.FlushSludgeBuffer.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    private event EventHandler<SE.Nereda.Symbols.FlushSludgeBuffer.RESET_BTNsEventArgs> RESET_BTNs_Fired;

    protected override void OnEndInit()
    {
      if (GRAPH_Fired != null)
        AttachEventInput(0);
      if (LOAD_PERS_DATA_Fired != null)
        AttachEventInput(1);
      if (RESET_BTNs_Fired != null)
        AttachEventInput(2);

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
              GRAPH_Fired(this, new SE.Nereda.Symbols.FlushSludgeBuffer.GRAPHEventArgs(channelId, cookie, eventIndex));
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
          if (LOAD_PERS_DATA_Fired != null)
          {
            try
            {
              LOAD_PERS_DATA_Fired(this, new SE.Nereda.Symbols.FlushSludgeBuffer.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","LOAD_PERS_DATA_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 2:
          if (RESET_BTNs_Fired != null)
          {
            try
            {
              RESET_BTNs_Fired(this, new SE.Nereda.Symbols.FlushSludgeBuffer.RESET_BTNsEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","RESET_BTNs_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_FLUSH_SP(NxtControl.GuiFramework.Time FlushDuration, System.Single FlushFlowSp, System.Single FlushStartSp)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {FlushDuration, FlushFlowSp, FlushStartSp});
    }
    public bool FireEvent_FLUSH_SP(SE.Nereda.Symbols.FlushSludgeBuffer.FLUSH_SPEventArgs ea)
    {
      object[] _values_ = new object[3];
      if (ea.FlushDuration.HasValue) _values_[0] = ea.FlushDuration.Value;
      if (ea.FlushFlowSp.HasValue) _values_[1] = ea.FlushFlowSp.Value;
      if (ea.FlushStartSp.HasValue) _values_[2] = ea.FlushStartSp.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_FLUSH_SP(NxtControl.GuiFramework.Time FlushDuration, bool ignore_FlushDuration, System.Single FlushFlowSp, bool ignore_FlushFlowSp, System.Single FlushStartSp, bool ignore_FlushStartSp)
    {
      object[] _values_ = new object[3];
      if (!ignore_FlushDuration) _values_[0] = FlushDuration;
      if (!ignore_FlushFlowSp) _values_[1] = FlushFlowSp;
      if (!ignore_FlushStartSp) _values_[2] = FlushStartSp;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_START_FLUSH(System.Boolean StartFlush, System.Boolean StopFlush)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {StartFlush, StopFlush});
    }
    public bool FireEvent_START_FLUSH(SE.Nereda.Symbols.FlushSludgeBuffer.START_FLUSHEventArgs ea)
    {
      object[] _values_ = new object[2];
      if (ea.StartFlush.HasValue) _values_[0] = ea.StartFlush.Value;
      if (ea.StopFlush.HasValue) _values_[1] = ea.StopFlush.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_START_FLUSH(System.Boolean StartFlush, bool ignore_StartFlush, System.Boolean StopFlush, bool ignore_StopFlush)
    {
      object[] _values_ = new object[2];
      if (!ignore_StartFlush) _values_[0] = StartFlush;
      if (!ignore_StopFlush) _values_[1] = StopFlush;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }

  }
}
#endregion #FlushSludgeBuffer_HMI;

#endregion Definitions;
