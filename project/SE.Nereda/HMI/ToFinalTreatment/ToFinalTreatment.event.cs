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
#region #ToFinalTreatment_HMI;

namespace SE.Nereda.Symbols.ToFinalTreatment
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

namespace SE.Nereda.Symbols.ToFinalTreatment
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
    private System.Single? StartLevelSp_Ctp003_field = null;
    public System.Single? StartLevelSp_Ctp003
    {
       get { return StartLevelSp_Ctp003_field; }
       set { StartLevelSp_Ctp003_field = value; }
    }
    private System.Single? StopLevelSp_Ctp003_field = null;
    public System.Single? StopLevelSp_Ctp003
    {
       get { return StopLevelSp_Ctp003_field; }
       set { StopLevelSp_Ctp003_field = value; }
    }

  }

  public class MAN_STARTEventArgs : System.EventArgs
  {
    public MAN_STARTEventArgs()
    {
    }
    private System.Boolean? ManStart_field = null;
    public System.Boolean? ManStart
    {
       get { return ManStart_field; }
       set { ManStart_field = value; }
    }
    private System.Int16? Mode_field = null;
    public System.Int16? Mode
    {
       get { return Mode_field; }
       set { Mode_field = value; }
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

  public class ENABLEEventArgs : System.EventArgs
  {
    public ENABLEEventArgs()
    {
    }
    private System.Boolean? Enable_field = null;
    public System.Boolean? Enable
    {
       get { return Enable_field; }
       set { Enable_field = value; }
    }

  }

}

namespace SE.Nereda.Symbols.ToFinalTreatment
{
  partial class sDefault
  {

    private event EventHandler<SE.Nereda.Symbols.ToFinalTreatment.GRAPHEventArgs> GRAPH_Fired;

    private event EventHandler<SE.Nereda.Symbols.ToFinalTreatment.RESET_BTNsEventArgs> RESET_BTNs_Fired;

    private event EventHandler<SE.Nereda.Symbols.ToFinalTreatment.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    protected override void OnEndInit()
    {
      if (GRAPH_Fired != null)
        AttachEventInput(0);
      if (RESET_BTNs_Fired != null)
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
          if (GRAPH_Fired != null)
          {
            try
            {
              GRAPH_Fired(this, new SE.Nereda.Symbols.ToFinalTreatment.GRAPHEventArgs(channelId, cookie, eventIndex));
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
          if (RESET_BTNs_Fired != null)
          {
            try
            {
              RESET_BTNs_Fired(this, new SE.Nereda.Symbols.ToFinalTreatment.RESET_BTNsEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","RESET_BTNs_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 2:
          if (LOAD_PERS_DATA_Fired != null)
          {
            try
            {
              LOAD_PERS_DATA_Fired(this, new SE.Nereda.Symbols.ToFinalTreatment.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
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
    public bool FireEvent_SPEED_CAP_SP(System.Single CapacitySp, System.Single StartLevelSp_Ctp003, System.Single StopLevelSp_Ctp003)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {CapacitySp, StartLevelSp_Ctp003, StopLevelSp_Ctp003});
    }
    public bool FireEvent_SPEED_CAP_SP(SE.Nereda.Symbols.ToFinalTreatment.SPEED_CAP_SPEventArgs ea)
    {
      object[] _values_ = new object[3];
      if (ea.CapacitySp.HasValue) _values_[0] = ea.CapacitySp.Value;
      if (ea.StartLevelSp_Ctp003.HasValue) _values_[1] = ea.StartLevelSp_Ctp003.Value;
      if (ea.StopLevelSp_Ctp003.HasValue) _values_[2] = ea.StopLevelSp_Ctp003.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_SPEED_CAP_SP(System.Single CapacitySp, bool ignore_CapacitySp, System.Single StartLevelSp_Ctp003, bool ignore_StartLevelSp_Ctp003, System.Single StopLevelSp_Ctp003, bool ignore_StopLevelSp_Ctp003)
    {
      object[] _values_ = new object[3];
      if (!ignore_CapacitySp) _values_[0] = CapacitySp;
      if (!ignore_StartLevelSp_Ctp003) _values_[1] = StartLevelSp_Ctp003;
      if (!ignore_StopLevelSp_Ctp003) _values_[2] = StopLevelSp_Ctp003;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_MAN_START(System.Boolean ManStart, System.Int16 Mode)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {ManStart, Mode});
    }
    public bool FireEvent_MAN_START(SE.Nereda.Symbols.ToFinalTreatment.MAN_STARTEventArgs ea)
    {
      object[] _values_ = new object[2];
      if (ea.ManStart.HasValue) _values_[0] = ea.ManStart.Value;
      if (ea.Mode.HasValue) _values_[1] = ea.Mode.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_MAN_START(System.Boolean ManStart, bool ignore_ManStart, System.Int16 Mode, bool ignore_Mode)
    {
      object[] _values_ = new object[2];
      if (!ignore_ManStart) _values_[0] = ManStart;
      if (!ignore_Mode) _values_[1] = Mode;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_RESET_LO_LO_F(System.Boolean ResetLoLoFlow)
    {
      return ((IHMIAccessorOutput)this).FireEvent(2, new object[] {ResetLoLoFlow});
    }
    public bool FireEvent_RESET_LO_LO_F(SE.Nereda.Symbols.ToFinalTreatment.RESET_LO_LO_FEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.ResetLoLoFlow.HasValue) _values_[0] = ea.ResetLoLoFlow.Value;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_RESET_LO_LO_F(System.Boolean ResetLoLoFlow, bool ignore_ResetLoLoFlow)
    {
      object[] _values_ = new object[1];
      if (!ignore_ResetLoLoFlow) _values_[0] = ResetLoLoFlow;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_ENABLE(System.Boolean Enable)
    {
      return ((IHMIAccessorOutput)this).FireEvent(3, new object[] {Enable});
    }
    public bool FireEvent_ENABLE(SE.Nereda.Symbols.ToFinalTreatment.ENABLEEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.Enable.HasValue) _values_[0] = ea.Enable.Value;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_ENABLE(System.Boolean Enable, bool ignore_Enable)
    {
      object[] _values_ = new object[1];
      if (!ignore_Enable) _values_[0] = Enable;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }

  }
}

namespace SE.Nereda.Faceplates.ToFinalTreatment
{
  partial class fpGrafcet
  {

    private event EventHandler<SE.Nereda.Symbols.ToFinalTreatment.GRAPHEventArgs> GRAPH_Fired;

    private event EventHandler<SE.Nereda.Symbols.ToFinalTreatment.RESET_BTNsEventArgs> RESET_BTNs_Fired;

    private event EventHandler<SE.Nereda.Symbols.ToFinalTreatment.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    protected override void OnEndInit()
    {
      if (GRAPH_Fired != null)
        AttachEventInput(0);
      if (RESET_BTNs_Fired != null)
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
          if (GRAPH_Fired != null)
          {
            try
            {
              GRAPH_Fired(this, new SE.Nereda.Symbols.ToFinalTreatment.GRAPHEventArgs(channelId, cookie, eventIndex));
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
          if (RESET_BTNs_Fired != null)
          {
            try
            {
              RESET_BTNs_Fired(this, new SE.Nereda.Symbols.ToFinalTreatment.RESET_BTNsEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","RESET_BTNs_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 2:
          if (LOAD_PERS_DATA_Fired != null)
          {
            try
            {
              LOAD_PERS_DATA_Fired(this, new SE.Nereda.Symbols.ToFinalTreatment.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
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
    public bool FireEvent_SPEED_CAP_SP(System.Single CapacitySp, System.Single StartLevelSp_Ctp003, System.Single StopLevelSp_Ctp003)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {CapacitySp, StartLevelSp_Ctp003, StopLevelSp_Ctp003});
    }
    public bool FireEvent_SPEED_CAP_SP(SE.Nereda.Symbols.ToFinalTreatment.SPEED_CAP_SPEventArgs ea)
    {
      object[] _values_ = new object[3];
      if (ea.CapacitySp.HasValue) _values_[0] = ea.CapacitySp.Value;
      if (ea.StartLevelSp_Ctp003.HasValue) _values_[1] = ea.StartLevelSp_Ctp003.Value;
      if (ea.StopLevelSp_Ctp003.HasValue) _values_[2] = ea.StopLevelSp_Ctp003.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_SPEED_CAP_SP(System.Single CapacitySp, bool ignore_CapacitySp, System.Single StartLevelSp_Ctp003, bool ignore_StartLevelSp_Ctp003, System.Single StopLevelSp_Ctp003, bool ignore_StopLevelSp_Ctp003)
    {
      object[] _values_ = new object[3];
      if (!ignore_CapacitySp) _values_[0] = CapacitySp;
      if (!ignore_StartLevelSp_Ctp003) _values_[1] = StartLevelSp_Ctp003;
      if (!ignore_StopLevelSp_Ctp003) _values_[2] = StopLevelSp_Ctp003;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_MAN_START(System.Boolean ManStart, System.Int16 Mode)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {ManStart, Mode});
    }
    public bool FireEvent_MAN_START(SE.Nereda.Symbols.ToFinalTreatment.MAN_STARTEventArgs ea)
    {
      object[] _values_ = new object[2];
      if (ea.ManStart.HasValue) _values_[0] = ea.ManStart.Value;
      if (ea.Mode.HasValue) _values_[1] = ea.Mode.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_MAN_START(System.Boolean ManStart, bool ignore_ManStart, System.Int16 Mode, bool ignore_Mode)
    {
      object[] _values_ = new object[2];
      if (!ignore_ManStart) _values_[0] = ManStart;
      if (!ignore_Mode) _values_[1] = Mode;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_RESET_LO_LO_F(System.Boolean ResetLoLoFlow)
    {
      return ((IHMIAccessorOutput)this).FireEvent(2, new object[] {ResetLoLoFlow});
    }
    public bool FireEvent_RESET_LO_LO_F(SE.Nereda.Symbols.ToFinalTreatment.RESET_LO_LO_FEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.ResetLoLoFlow.HasValue) _values_[0] = ea.ResetLoLoFlow.Value;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_RESET_LO_LO_F(System.Boolean ResetLoLoFlow, bool ignore_ResetLoLoFlow)
    {
      object[] _values_ = new object[1];
      if (!ignore_ResetLoLoFlow) _values_[0] = ResetLoLoFlow;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_ENABLE(System.Boolean Enable)
    {
      return ((IHMIAccessorOutput)this).FireEvent(3, new object[] {Enable});
    }
    public bool FireEvent_ENABLE(SE.Nereda.Symbols.ToFinalTreatment.ENABLEEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.Enable.HasValue) _values_[0] = ea.Enable.Value;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_ENABLE(System.Boolean Enable, bool ignore_Enable)
    {
      object[] _values_ = new object[1];
      if (!ignore_Enable) _values_[0] = Enable;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }

  }
}

namespace SE.Nereda.Faceplates.ToFinalTreatment
{
  partial class fpPID
  {

    private event EventHandler<SE.Nereda.Symbols.ToFinalTreatment.GRAPHEventArgs> GRAPH_Fired;

    private event EventHandler<SE.Nereda.Symbols.ToFinalTreatment.RESET_BTNsEventArgs> RESET_BTNs_Fired;

    private event EventHandler<SE.Nereda.Symbols.ToFinalTreatment.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    protected override void OnEndInit()
    {
      if (GRAPH_Fired != null)
        AttachEventInput(0);
      if (RESET_BTNs_Fired != null)
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
          if (GRAPH_Fired != null)
          {
            try
            {
              GRAPH_Fired(this, new SE.Nereda.Symbols.ToFinalTreatment.GRAPHEventArgs(channelId, cookie, eventIndex));
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
          if (RESET_BTNs_Fired != null)
          {
            try
            {
              RESET_BTNs_Fired(this, new SE.Nereda.Symbols.ToFinalTreatment.RESET_BTNsEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","RESET_BTNs_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 2:
          if (LOAD_PERS_DATA_Fired != null)
          {
            try
            {
              LOAD_PERS_DATA_Fired(this, new SE.Nereda.Symbols.ToFinalTreatment.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
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
    public bool FireEvent_SPEED_CAP_SP(System.Single CapacitySp, System.Single StartLevelSp_Ctp003, System.Single StopLevelSp_Ctp003)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {CapacitySp, StartLevelSp_Ctp003, StopLevelSp_Ctp003});
    }
    public bool FireEvent_SPEED_CAP_SP(SE.Nereda.Symbols.ToFinalTreatment.SPEED_CAP_SPEventArgs ea)
    {
      object[] _values_ = new object[3];
      if (ea.CapacitySp.HasValue) _values_[0] = ea.CapacitySp.Value;
      if (ea.StartLevelSp_Ctp003.HasValue) _values_[1] = ea.StartLevelSp_Ctp003.Value;
      if (ea.StopLevelSp_Ctp003.HasValue) _values_[2] = ea.StopLevelSp_Ctp003.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_SPEED_CAP_SP(System.Single CapacitySp, bool ignore_CapacitySp, System.Single StartLevelSp_Ctp003, bool ignore_StartLevelSp_Ctp003, System.Single StopLevelSp_Ctp003, bool ignore_StopLevelSp_Ctp003)
    {
      object[] _values_ = new object[3];
      if (!ignore_CapacitySp) _values_[0] = CapacitySp;
      if (!ignore_StartLevelSp_Ctp003) _values_[1] = StartLevelSp_Ctp003;
      if (!ignore_StopLevelSp_Ctp003) _values_[2] = StopLevelSp_Ctp003;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_MAN_START(System.Boolean ManStart, System.Int16 Mode)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {ManStart, Mode});
    }
    public bool FireEvent_MAN_START(SE.Nereda.Symbols.ToFinalTreatment.MAN_STARTEventArgs ea)
    {
      object[] _values_ = new object[2];
      if (ea.ManStart.HasValue) _values_[0] = ea.ManStart.Value;
      if (ea.Mode.HasValue) _values_[1] = ea.Mode.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_MAN_START(System.Boolean ManStart, bool ignore_ManStart, System.Int16 Mode, bool ignore_Mode)
    {
      object[] _values_ = new object[2];
      if (!ignore_ManStart) _values_[0] = ManStart;
      if (!ignore_Mode) _values_[1] = Mode;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_RESET_LO_LO_F(System.Boolean ResetLoLoFlow)
    {
      return ((IHMIAccessorOutput)this).FireEvent(2, new object[] {ResetLoLoFlow});
    }
    public bool FireEvent_RESET_LO_LO_F(SE.Nereda.Symbols.ToFinalTreatment.RESET_LO_LO_FEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.ResetLoLoFlow.HasValue) _values_[0] = ea.ResetLoLoFlow.Value;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_RESET_LO_LO_F(System.Boolean ResetLoLoFlow, bool ignore_ResetLoLoFlow)
    {
      object[] _values_ = new object[1];
      if (!ignore_ResetLoLoFlow) _values_[0] = ResetLoLoFlow;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_ENABLE(System.Boolean Enable)
    {
      return ((IHMIAccessorOutput)this).FireEvent(3, new object[] {Enable});
    }
    public bool FireEvent_ENABLE(SE.Nereda.Symbols.ToFinalTreatment.ENABLEEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.Enable.HasValue) _values_[0] = ea.Enable.Value;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_ENABLE(System.Boolean Enable, bool ignore_Enable)
    {
      object[] _values_ = new object[1];
      if (!ignore_Enable) _values_[0] = Enable;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }

  }
}

namespace SE.Nereda.Symbols.ToFinalTreatment
{
  partial class sPID
  {

    private event EventHandler<SE.Nereda.Symbols.ToFinalTreatment.GRAPHEventArgs> GRAPH_Fired;

    private event EventHandler<SE.Nereda.Symbols.ToFinalTreatment.RESET_BTNsEventArgs> RESET_BTNs_Fired;

    private event EventHandler<SE.Nereda.Symbols.ToFinalTreatment.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    protected override void OnEndInit()
    {
      if (GRAPH_Fired != null)
        AttachEventInput(0);
      if (RESET_BTNs_Fired != null)
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
          if (GRAPH_Fired != null)
          {
            try
            {
              GRAPH_Fired(this, new SE.Nereda.Symbols.ToFinalTreatment.GRAPHEventArgs(channelId, cookie, eventIndex));
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
          if (RESET_BTNs_Fired != null)
          {
            try
            {
              RESET_BTNs_Fired(this, new SE.Nereda.Symbols.ToFinalTreatment.RESET_BTNsEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","RESET_BTNs_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 2:
          if (LOAD_PERS_DATA_Fired != null)
          {
            try
            {
              LOAD_PERS_DATA_Fired(this, new SE.Nereda.Symbols.ToFinalTreatment.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
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
    public bool FireEvent_SPEED_CAP_SP(System.Single CapacitySp, System.Single StartLevelSp_Ctp003, System.Single StopLevelSp_Ctp003)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {CapacitySp, StartLevelSp_Ctp003, StopLevelSp_Ctp003});
    }
    public bool FireEvent_SPEED_CAP_SP(SE.Nereda.Symbols.ToFinalTreatment.SPEED_CAP_SPEventArgs ea)
    {
      object[] _values_ = new object[3];
      if (ea.CapacitySp.HasValue) _values_[0] = ea.CapacitySp.Value;
      if (ea.StartLevelSp_Ctp003.HasValue) _values_[1] = ea.StartLevelSp_Ctp003.Value;
      if (ea.StopLevelSp_Ctp003.HasValue) _values_[2] = ea.StopLevelSp_Ctp003.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_SPEED_CAP_SP(System.Single CapacitySp, bool ignore_CapacitySp, System.Single StartLevelSp_Ctp003, bool ignore_StartLevelSp_Ctp003, System.Single StopLevelSp_Ctp003, bool ignore_StopLevelSp_Ctp003)
    {
      object[] _values_ = new object[3];
      if (!ignore_CapacitySp) _values_[0] = CapacitySp;
      if (!ignore_StartLevelSp_Ctp003) _values_[1] = StartLevelSp_Ctp003;
      if (!ignore_StopLevelSp_Ctp003) _values_[2] = StopLevelSp_Ctp003;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_MAN_START(System.Boolean ManStart, System.Int16 Mode)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {ManStart, Mode});
    }
    public bool FireEvent_MAN_START(SE.Nereda.Symbols.ToFinalTreatment.MAN_STARTEventArgs ea)
    {
      object[] _values_ = new object[2];
      if (ea.ManStart.HasValue) _values_[0] = ea.ManStart.Value;
      if (ea.Mode.HasValue) _values_[1] = ea.Mode.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_MAN_START(System.Boolean ManStart, bool ignore_ManStart, System.Int16 Mode, bool ignore_Mode)
    {
      object[] _values_ = new object[2];
      if (!ignore_ManStart) _values_[0] = ManStart;
      if (!ignore_Mode) _values_[1] = Mode;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_RESET_LO_LO_F(System.Boolean ResetLoLoFlow)
    {
      return ((IHMIAccessorOutput)this).FireEvent(2, new object[] {ResetLoLoFlow});
    }
    public bool FireEvent_RESET_LO_LO_F(SE.Nereda.Symbols.ToFinalTreatment.RESET_LO_LO_FEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.ResetLoLoFlow.HasValue) _values_[0] = ea.ResetLoLoFlow.Value;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_RESET_LO_LO_F(System.Boolean ResetLoLoFlow, bool ignore_ResetLoLoFlow)
    {
      object[] _values_ = new object[1];
      if (!ignore_ResetLoLoFlow) _values_[0] = ResetLoLoFlow;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_ENABLE(System.Boolean Enable)
    {
      return ((IHMIAccessorOutput)this).FireEvent(3, new object[] {Enable});
    }
    public bool FireEvent_ENABLE(SE.Nereda.Symbols.ToFinalTreatment.ENABLEEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.Enable.HasValue) _values_[0] = ea.Enable.Value;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_ENABLE(System.Boolean Enable, bool ignore_Enable)
    {
      object[] _values_ = new object[1];
      if (!ignore_Enable) _values_[0] = Enable;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }

  }
}
#endregion #ToFinalTreatment_HMI;

#endregion Definitions;
