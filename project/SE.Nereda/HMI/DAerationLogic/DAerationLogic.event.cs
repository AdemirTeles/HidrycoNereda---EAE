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
#region #DAerationLogic_HMI;

namespace SE.Nereda.Symbols.DAerationLogic
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

  public class BLS_OPDEventArgs : System.EventArgs
  {
    IHMIAccessorService accessorService;
    int channelId;
    int cookie; 
    int eventIndex;

    public BLS_OPDEventArgs(int channelId, int cookie, int eventIndex)
    {
      this.accessorService = (IHMIAccessorService)ServiceProvider.GetService(typeof(IHMIAccessorService));
      this.channelId = channelId;
      this.cookie = cookie;
      this.eventIndex = eventIndex;
    }
    public bool Get_BL1TotOpDur(ref System.UInt32 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,0, ref var);
      if (ret) value = (System.UInt32) var;
      return ret;
    }

    public System.UInt32? BL1TotOpDur
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,0, ref var);
      if (!ret) return null;
      return (System.UInt32) var;
    }  }

    public bool Get_BL2TotOpDur(ref System.UInt32 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,1, ref var);
      if (ret) value = (System.UInt32) var;
      return ret;
    }

    public System.UInt32? BL2TotOpDur
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,1, ref var);
      if (!ret) return null;
      return (System.UInt32) var;
    }  }

    public bool Get_BL1OpCount(ref System.UInt32 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,2, ref var);
      if (ret) value = (System.UInt32) var;
      return ret;
    }

    public System.UInt32? BL1OpCount
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,2, ref var);
      if (!ret) return null;
      return (System.UInt32) var;
    }  }

    public bool Get_BL2OpCount(ref System.UInt32 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,3, ref var);
      if (ret) value = (System.UInt32) var;
      return ret;
    }

    public System.UInt32? BL2OpCount
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,3, ref var);
      if (!ret) return null;
      return (System.UInt32) var;
    }  }


  }

  public class CAP_INEventArgs : System.EventArgs
  {
    IHMIAccessorService accessorService;
    int channelId;
    int cookie; 
    int eventIndex;

    public CAP_INEventArgs(int channelId, int cookie, int eventIndex)
    {
      this.accessorService = (IHMIAccessorService)ServiceProvider.GetService(typeof(IHMIAccessorService));
      this.channelId = channelId;
      this.cookie = cookie;
      this.eventIndex = eventIndex;
    }
    public bool Get_iC_IN(ref System.Single value)
    {
      if (accessorService == null)
        return false;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,0, ref var);
      if (ret) value = (System.Single) var;
      return ret;
    }

    public System.Single? iC_IN
    { get {
      if (accessorService == null)
        return null;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,0, ref var);
      if (!ret) return null;
      return (System.Single) var;
    }  }


  }

  public class PARAMETEREventArgs : System.EventArgs
  {
    IHMIAccessorService accessorService;
    int channelId;
    int cookie; 
    int eventIndex;

    public PARAMETEREventArgs(int channelId, int cookie, int eventIndex)
    {
      this.accessorService = (IHMIAccessorService)ServiceProvider.GetService(typeof(IHMIAccessorService));
      this.channelId = channelId;
      this.cookie = cookie;
      this.eventIndex = eventIndex;
    }
    public bool Get_iC_MAX(ref System.Single value)
    {
      if (accessorService == null)
        return false;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,0, ref var);
      if (ret) value = (System.Single) var;
      return ret;
    }

    public System.Single? iC_MAX
    { get {
      if (accessorService == null)
        return null;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,0, ref var);
      if (!ret) return null;
      return (System.Single) var;
    }  }

    public bool Get_iC2_IN(ref System.Single value)
    {
      if (accessorService == null)
        return false;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,1, ref var);
      if (ret) value = (System.Single) var;
      return ret;
    }

    public System.Single? iC2_IN
    { get {
      if (accessorService == null)
        return null;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,1, ref var);
      if (!ret) return null;
      return (System.Single) var;
    }  }

    public bool Get_iC3_IN(ref System.Single value)
    {
      if (accessorService == null)
        return false;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,2, ref var);
      if (ret) value = (System.Single) var;
      return ret;
    }

    public System.Single? iC3_IN
    { get {
      if (accessorService == null)
        return null;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,2, ref var);
      if (!ret) return null;
      return (System.Single) var;
    }  }


  }

  public class CAP_OUTEventArgs : System.EventArgs
  {
    IHMIAccessorService accessorService;
    int channelId;
    int cookie; 
    int eventIndex;

    public CAP_OUTEventArgs(int channelId, int cookie, int eventIndex)
    {
      this.accessorService = (IHMIAccessorService)ServiceProvider.GetService(typeof(IHMIAccessorService));
      this.channelId = channelId;
      this.cookie = cookie;
      this.eventIndex = eventIndex;
    }
    public bool Get_iC_OUT(ref System.Single value)
    {
      if (accessorService == null)
        return false;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,0, ref var);
      if (ret) value = (System.Single) var;
      return ret;
    }

    public System.Single? iC_OUT
    { get {
      if (accessorService == null)
        return null;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,0, ref var);
      if (!ret) return null;
      return (System.Single) var;
    }  }


  }

  public class IN_CAP_CNFGEventArgs : System.EventArgs
  {
    IHMIAccessorService accessorService;
    int channelId;
    int cookie; 
    int eventIndex;

    public IN_CAP_CNFGEventArgs(int channelId, int cookie, int eventIndex)
    {
      this.accessorService = (IHMIAccessorService)ServiceProvider.GetService(typeof(IHMIAccessorService));
      this.channelId = channelId;
      this.cookie = cookie;
      this.eventIndex = eventIndex;
    }
    public bool Get_iCapacityConfig(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,0, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? iCapacityConfig
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,0, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }


  }

}

namespace SE.Nereda.Symbols.DAerationLogic
{

  public class AERATION_PAREventArgs : System.EventArgs
  {
    public AERATION_PAREventArgs()
    {
    }
    private System.Single? C_MAX_field = null;
    public System.Single? C_MAX
    {
       get { return C_MAX_field; }
       set { C_MAX_field = value; }
    }
    private System.Single? C2_IN_field = null;
    public System.Single? C2_IN
    {
       get { return C2_IN_field; }
       set { C2_IN_field = value; }
    }
    private System.Single? C3_IN_field = null;
    public System.Single? C3_IN
    {
       get { return C3_IN_field; }
       set { C3_IN_field = value; }
    }

  }

  public class CAP_CNFGEventArgs : System.EventArgs
  {
    public CAP_CNFGEventArgs()
    {
    }
    private System.Int16? CapacityConfig_field = null;
    public System.Int16? CapacityConfig
    {
       get { return CapacityConfig_field; }
       set { CapacityConfig_field = value; }
    }

  }

}

namespace SE.Nereda.Symbols.DAerationLogic
{
  partial class sGraphBtn
  {

    private event EventHandler<SE.Nereda.Symbols.DAerationLogic.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    private event EventHandler<SE.Nereda.Symbols.DAerationLogic.GRAPHEventArgs> GRAPH_Fired;

    private event EventHandler<SE.Nereda.Symbols.DAerationLogic.BLS_OPDEventArgs> BLS_OPD_Fired;

    private event EventHandler<SE.Nereda.Symbols.DAerationLogic.CAP_INEventArgs> CAP_IN_Fired;

    private event EventHandler<SE.Nereda.Symbols.DAerationLogic.PARAMETEREventArgs> PARAMETER_Fired;

    private event EventHandler<SE.Nereda.Symbols.DAerationLogic.CAP_OUTEventArgs> CAP_OUT_Fired;

    private event EventHandler<SE.Nereda.Symbols.DAerationLogic.IN_CAP_CNFGEventArgs> IN_CAP_CNFG_Fired;

    protected override void OnEndInit()
    {
      if (LOAD_PERS_DATA_Fired != null)
        AttachEventInput(0);
      if (GRAPH_Fired != null)
        AttachEventInput(1);
      if (BLS_OPD_Fired != null)
        AttachEventInput(2);
      if (CAP_IN_Fired != null)
        AttachEventInput(3);
      if (PARAMETER_Fired != null)
        AttachEventInput(4);
      if (CAP_OUT_Fired != null)
        AttachEventInput(5);
      if (IN_CAP_CNFG_Fired != null)
        AttachEventInput(6);

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
              LOAD_PERS_DATA_Fired(this, new SE.Nereda.Symbols.DAerationLogic.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
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
              GRAPH_Fired(this, new SE.Nereda.Symbols.DAerationLogic.GRAPHEventArgs(channelId, cookie, eventIndex));
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
          if (BLS_OPD_Fired != null)
          {
            try
            {
              BLS_OPD_Fired(this, new SE.Nereda.Symbols.DAerationLogic.BLS_OPDEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","BLS_OPD_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 3:
          if (CAP_IN_Fired != null)
          {
            try
            {
              CAP_IN_Fired(this, new SE.Nereda.Symbols.DAerationLogic.CAP_INEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","CAP_IN_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 4:
          if (PARAMETER_Fired != null)
          {
            try
            {
              PARAMETER_Fired(this, new SE.Nereda.Symbols.DAerationLogic.PARAMETEREventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","PARAMETER_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 5:
          if (CAP_OUT_Fired != null)
          {
            try
            {
              CAP_OUT_Fired(this, new SE.Nereda.Symbols.DAerationLogic.CAP_OUTEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","CAP_OUT_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 6:
          if (IN_CAP_CNFG_Fired != null)
          {
            try
            {
              IN_CAP_CNFG_Fired(this, new SE.Nereda.Symbols.DAerationLogic.IN_CAP_CNFGEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","IN_CAP_CNFG_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_AERATION_PAR(System.Single C_MAX, System.Single C2_IN, System.Single C3_IN)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {C_MAX, C2_IN, C3_IN});
    }
    public bool FireEvent_AERATION_PAR(SE.Nereda.Symbols.DAerationLogic.AERATION_PAREventArgs ea)
    {
      object[] _values_ = new object[3];
      if (ea.C_MAX.HasValue) _values_[0] = ea.C_MAX.Value;
      if (ea.C2_IN.HasValue) _values_[1] = ea.C2_IN.Value;
      if (ea.C3_IN.HasValue) _values_[2] = ea.C3_IN.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_AERATION_PAR(System.Single C_MAX, bool ignore_C_MAX, System.Single C2_IN, bool ignore_C2_IN, System.Single C3_IN, bool ignore_C3_IN)
    {
      object[] _values_ = new object[3];
      if (!ignore_C_MAX) _values_[0] = C_MAX;
      if (!ignore_C2_IN) _values_[1] = C2_IN;
      if (!ignore_C3_IN) _values_[2] = C3_IN;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_CAP_CNFG(System.Int16 CapacityConfig)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {CapacityConfig});
    }
    public bool FireEvent_CAP_CNFG(SE.Nereda.Symbols.DAerationLogic.CAP_CNFGEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.CapacityConfig.HasValue) _values_[0] = ea.CapacityConfig.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_CAP_CNFG(System.Int16 CapacityConfig, bool ignore_CapacityConfig)
    {
      object[] _values_ = new object[1];
      if (!ignore_CapacityConfig) _values_[0] = CapacityConfig;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }

  }
}

namespace SE.Nereda.Symbols.DAerationLogic
{
  partial class sAerMonitoring
  {

    private event EventHandler<SE.Nereda.Symbols.DAerationLogic.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    private event EventHandler<SE.Nereda.Symbols.DAerationLogic.GRAPHEventArgs> GRAPH_Fired;

    private event EventHandler<SE.Nereda.Symbols.DAerationLogic.BLS_OPDEventArgs> BLS_OPD_Fired;

    private event EventHandler<SE.Nereda.Symbols.DAerationLogic.CAP_INEventArgs> CAP_IN_Fired;

    private event EventHandler<SE.Nereda.Symbols.DAerationLogic.PARAMETEREventArgs> PARAMETER_Fired;

    private event EventHandler<SE.Nereda.Symbols.DAerationLogic.CAP_OUTEventArgs> CAP_OUT_Fired;

    private event EventHandler<SE.Nereda.Symbols.DAerationLogic.IN_CAP_CNFGEventArgs> IN_CAP_CNFG_Fired;

    protected override void OnEndInit()
    {
      if (LOAD_PERS_DATA_Fired != null)
        AttachEventInput(0);
      if (GRAPH_Fired != null)
        AttachEventInput(1);
      if (BLS_OPD_Fired != null)
        AttachEventInput(2);
      if (CAP_IN_Fired != null)
        AttachEventInput(3);
      if (PARAMETER_Fired != null)
        AttachEventInput(4);
      if (CAP_OUT_Fired != null)
        AttachEventInput(5);
      if (IN_CAP_CNFG_Fired != null)
        AttachEventInput(6);

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
              LOAD_PERS_DATA_Fired(this, new SE.Nereda.Symbols.DAerationLogic.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
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
              GRAPH_Fired(this, new SE.Nereda.Symbols.DAerationLogic.GRAPHEventArgs(channelId, cookie, eventIndex));
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
          if (BLS_OPD_Fired != null)
          {
            try
            {
              BLS_OPD_Fired(this, new SE.Nereda.Symbols.DAerationLogic.BLS_OPDEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","BLS_OPD_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 3:
          if (CAP_IN_Fired != null)
          {
            try
            {
              CAP_IN_Fired(this, new SE.Nereda.Symbols.DAerationLogic.CAP_INEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","CAP_IN_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 4:
          if (PARAMETER_Fired != null)
          {
            try
            {
              PARAMETER_Fired(this, new SE.Nereda.Symbols.DAerationLogic.PARAMETEREventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","PARAMETER_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 5:
          if (CAP_OUT_Fired != null)
          {
            try
            {
              CAP_OUT_Fired(this, new SE.Nereda.Symbols.DAerationLogic.CAP_OUTEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","CAP_OUT_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 6:
          if (IN_CAP_CNFG_Fired != null)
          {
            try
            {
              IN_CAP_CNFG_Fired(this, new SE.Nereda.Symbols.DAerationLogic.IN_CAP_CNFGEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","IN_CAP_CNFG_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_AERATION_PAR(System.Single C_MAX, System.Single C2_IN, System.Single C3_IN)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {C_MAX, C2_IN, C3_IN});
    }
    public bool FireEvent_AERATION_PAR(SE.Nereda.Symbols.DAerationLogic.AERATION_PAREventArgs ea)
    {
      object[] _values_ = new object[3];
      if (ea.C_MAX.HasValue) _values_[0] = ea.C_MAX.Value;
      if (ea.C2_IN.HasValue) _values_[1] = ea.C2_IN.Value;
      if (ea.C3_IN.HasValue) _values_[2] = ea.C3_IN.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_AERATION_PAR(System.Single C_MAX, bool ignore_C_MAX, System.Single C2_IN, bool ignore_C2_IN, System.Single C3_IN, bool ignore_C3_IN)
    {
      object[] _values_ = new object[3];
      if (!ignore_C_MAX) _values_[0] = C_MAX;
      if (!ignore_C2_IN) _values_[1] = C2_IN;
      if (!ignore_C3_IN) _values_[2] = C3_IN;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_CAP_CNFG(System.Int16 CapacityConfig)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {CapacityConfig});
    }
    public bool FireEvent_CAP_CNFG(SE.Nereda.Symbols.DAerationLogic.CAP_CNFGEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.CapacityConfig.HasValue) _values_[0] = ea.CapacityConfig.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_CAP_CNFG(System.Int16 CapacityConfig, bool ignore_CapacityConfig)
    {
      object[] _values_ = new object[1];
      if (!ignore_CapacityConfig) _values_[0] = CapacityConfig;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }

  }
}

namespace SE.Nereda.Faceplates.DAerationLogic
{
  partial class fpAerSettings
  {

    private event EventHandler<SE.Nereda.Symbols.DAerationLogic.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    private event EventHandler<SE.Nereda.Symbols.DAerationLogic.GRAPHEventArgs> GRAPH_Fired;

    private event EventHandler<SE.Nereda.Symbols.DAerationLogic.BLS_OPDEventArgs> BLS_OPD_Fired;

    private event EventHandler<SE.Nereda.Symbols.DAerationLogic.CAP_INEventArgs> CAP_IN_Fired;

    private event EventHandler<SE.Nereda.Symbols.DAerationLogic.PARAMETEREventArgs> PARAMETER_Fired;

    private event EventHandler<SE.Nereda.Symbols.DAerationLogic.CAP_OUTEventArgs> CAP_OUT_Fired;

    private event EventHandler<SE.Nereda.Symbols.DAerationLogic.IN_CAP_CNFGEventArgs> IN_CAP_CNFG_Fired;

    protected override void OnEndInit()
    {
      if (LOAD_PERS_DATA_Fired != null)
        AttachEventInput(0);
      if (GRAPH_Fired != null)
        AttachEventInput(1);
      if (BLS_OPD_Fired != null)
        AttachEventInput(2);
      if (CAP_IN_Fired != null)
        AttachEventInput(3);
      if (PARAMETER_Fired != null)
        AttachEventInput(4);
      if (CAP_OUT_Fired != null)
        AttachEventInput(5);
      if (IN_CAP_CNFG_Fired != null)
        AttachEventInput(6);

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
              LOAD_PERS_DATA_Fired(this, new SE.Nereda.Symbols.DAerationLogic.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
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
              GRAPH_Fired(this, new SE.Nereda.Symbols.DAerationLogic.GRAPHEventArgs(channelId, cookie, eventIndex));
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
          if (BLS_OPD_Fired != null)
          {
            try
            {
              BLS_OPD_Fired(this, new SE.Nereda.Symbols.DAerationLogic.BLS_OPDEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","BLS_OPD_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 3:
          if (CAP_IN_Fired != null)
          {
            try
            {
              CAP_IN_Fired(this, new SE.Nereda.Symbols.DAerationLogic.CAP_INEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","CAP_IN_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 4:
          if (PARAMETER_Fired != null)
          {
            try
            {
              PARAMETER_Fired(this, new SE.Nereda.Symbols.DAerationLogic.PARAMETEREventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","PARAMETER_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 5:
          if (CAP_OUT_Fired != null)
          {
            try
            {
              CAP_OUT_Fired(this, new SE.Nereda.Symbols.DAerationLogic.CAP_OUTEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","CAP_OUT_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 6:
          if (IN_CAP_CNFG_Fired != null)
          {
            try
            {
              IN_CAP_CNFG_Fired(this, new SE.Nereda.Symbols.DAerationLogic.IN_CAP_CNFGEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","IN_CAP_CNFG_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_AERATION_PAR(System.Single C_MAX, System.Single C2_IN, System.Single C3_IN)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {C_MAX, C2_IN, C3_IN});
    }
    public bool FireEvent_AERATION_PAR(SE.Nereda.Symbols.DAerationLogic.AERATION_PAREventArgs ea)
    {
      object[] _values_ = new object[3];
      if (ea.C_MAX.HasValue) _values_[0] = ea.C_MAX.Value;
      if (ea.C2_IN.HasValue) _values_[1] = ea.C2_IN.Value;
      if (ea.C3_IN.HasValue) _values_[2] = ea.C3_IN.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_AERATION_PAR(System.Single C_MAX, bool ignore_C_MAX, System.Single C2_IN, bool ignore_C2_IN, System.Single C3_IN, bool ignore_C3_IN)
    {
      object[] _values_ = new object[3];
      if (!ignore_C_MAX) _values_[0] = C_MAX;
      if (!ignore_C2_IN) _values_[1] = C2_IN;
      if (!ignore_C3_IN) _values_[2] = C3_IN;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_CAP_CNFG(System.Int16 CapacityConfig)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {CapacityConfig});
    }
    public bool FireEvent_CAP_CNFG(SE.Nereda.Symbols.DAerationLogic.CAP_CNFGEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.CapacityConfig.HasValue) _values_[0] = ea.CapacityConfig.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_CAP_CNFG(System.Int16 CapacityConfig, bool ignore_CapacityConfig)
    {
      object[] _values_ = new object[1];
      if (!ignore_CapacityConfig) _values_[0] = CapacityConfig;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }

  }
}

namespace SE.Nereda.Symbols.DAerationLogic
{
  partial class sGraph
  {

    private event EventHandler<SE.Nereda.Symbols.DAerationLogic.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    private event EventHandler<SE.Nereda.Symbols.DAerationLogic.GRAPHEventArgs> GRAPH_Fired;

    private event EventHandler<SE.Nereda.Symbols.DAerationLogic.BLS_OPDEventArgs> BLS_OPD_Fired;

    private event EventHandler<SE.Nereda.Symbols.DAerationLogic.CAP_INEventArgs> CAP_IN_Fired;

    private event EventHandler<SE.Nereda.Symbols.DAerationLogic.PARAMETEREventArgs> PARAMETER_Fired;

    private event EventHandler<SE.Nereda.Symbols.DAerationLogic.CAP_OUTEventArgs> CAP_OUT_Fired;

    private event EventHandler<SE.Nereda.Symbols.DAerationLogic.IN_CAP_CNFGEventArgs> IN_CAP_CNFG_Fired;

    protected override void OnEndInit()
    {
      if (LOAD_PERS_DATA_Fired != null)
        AttachEventInput(0);
      if (GRAPH_Fired != null)
        AttachEventInput(1);
      if (BLS_OPD_Fired != null)
        AttachEventInput(2);
      if (CAP_IN_Fired != null)
        AttachEventInput(3);
      if (PARAMETER_Fired != null)
        AttachEventInput(4);
      if (CAP_OUT_Fired != null)
        AttachEventInput(5);
      if (IN_CAP_CNFG_Fired != null)
        AttachEventInput(6);

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
              LOAD_PERS_DATA_Fired(this, new SE.Nereda.Symbols.DAerationLogic.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
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
              GRAPH_Fired(this, new SE.Nereda.Symbols.DAerationLogic.GRAPHEventArgs(channelId, cookie, eventIndex));
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
          if (BLS_OPD_Fired != null)
          {
            try
            {
              BLS_OPD_Fired(this, new SE.Nereda.Symbols.DAerationLogic.BLS_OPDEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","BLS_OPD_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 3:
          if (CAP_IN_Fired != null)
          {
            try
            {
              CAP_IN_Fired(this, new SE.Nereda.Symbols.DAerationLogic.CAP_INEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","CAP_IN_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 4:
          if (PARAMETER_Fired != null)
          {
            try
            {
              PARAMETER_Fired(this, new SE.Nereda.Symbols.DAerationLogic.PARAMETEREventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","PARAMETER_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 5:
          if (CAP_OUT_Fired != null)
          {
            try
            {
              CAP_OUT_Fired(this, new SE.Nereda.Symbols.DAerationLogic.CAP_OUTEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","CAP_OUT_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 6:
          if (IN_CAP_CNFG_Fired != null)
          {
            try
            {
              IN_CAP_CNFG_Fired(this, new SE.Nereda.Symbols.DAerationLogic.IN_CAP_CNFGEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","IN_CAP_CNFG_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_AERATION_PAR(System.Single C_MAX, System.Single C2_IN, System.Single C3_IN)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {C_MAX, C2_IN, C3_IN});
    }
    public bool FireEvent_AERATION_PAR(SE.Nereda.Symbols.DAerationLogic.AERATION_PAREventArgs ea)
    {
      object[] _values_ = new object[3];
      if (ea.C_MAX.HasValue) _values_[0] = ea.C_MAX.Value;
      if (ea.C2_IN.HasValue) _values_[1] = ea.C2_IN.Value;
      if (ea.C3_IN.HasValue) _values_[2] = ea.C3_IN.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_AERATION_PAR(System.Single C_MAX, bool ignore_C_MAX, System.Single C2_IN, bool ignore_C2_IN, System.Single C3_IN, bool ignore_C3_IN)
    {
      object[] _values_ = new object[3];
      if (!ignore_C_MAX) _values_[0] = C_MAX;
      if (!ignore_C2_IN) _values_[1] = C2_IN;
      if (!ignore_C3_IN) _values_[2] = C3_IN;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_CAP_CNFG(System.Int16 CapacityConfig)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {CapacityConfig});
    }
    public bool FireEvent_CAP_CNFG(SE.Nereda.Symbols.DAerationLogic.CAP_CNFGEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.CapacityConfig.HasValue) _values_[0] = ea.CapacityConfig.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_CAP_CNFG(System.Int16 CapacityConfig, bool ignore_CapacityConfig)
    {
      object[] _values_ = new object[1];
      if (!ignore_CapacityConfig) _values_[0] = CapacityConfig;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }

  }
}

namespace SE.Nereda.Symbols.DAerationLogic
{
  partial class sSettingsBtn
  {

    private event EventHandler<SE.Nereda.Symbols.DAerationLogic.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    private event EventHandler<SE.Nereda.Symbols.DAerationLogic.GRAPHEventArgs> GRAPH_Fired;

    private event EventHandler<SE.Nereda.Symbols.DAerationLogic.BLS_OPDEventArgs> BLS_OPD_Fired;

    private event EventHandler<SE.Nereda.Symbols.DAerationLogic.CAP_INEventArgs> CAP_IN_Fired;

    private event EventHandler<SE.Nereda.Symbols.DAerationLogic.PARAMETEREventArgs> PARAMETER_Fired;

    private event EventHandler<SE.Nereda.Symbols.DAerationLogic.CAP_OUTEventArgs> CAP_OUT_Fired;

    private event EventHandler<SE.Nereda.Symbols.DAerationLogic.IN_CAP_CNFGEventArgs> IN_CAP_CNFG_Fired;

    protected override void OnEndInit()
    {
      if (LOAD_PERS_DATA_Fired != null)
        AttachEventInput(0);
      if (GRAPH_Fired != null)
        AttachEventInput(1);
      if (BLS_OPD_Fired != null)
        AttachEventInput(2);
      if (CAP_IN_Fired != null)
        AttachEventInput(3);
      if (PARAMETER_Fired != null)
        AttachEventInput(4);
      if (CAP_OUT_Fired != null)
        AttachEventInput(5);
      if (IN_CAP_CNFG_Fired != null)
        AttachEventInput(6);

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
              LOAD_PERS_DATA_Fired(this, new SE.Nereda.Symbols.DAerationLogic.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
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
              GRAPH_Fired(this, new SE.Nereda.Symbols.DAerationLogic.GRAPHEventArgs(channelId, cookie, eventIndex));
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
          if (BLS_OPD_Fired != null)
          {
            try
            {
              BLS_OPD_Fired(this, new SE.Nereda.Symbols.DAerationLogic.BLS_OPDEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","BLS_OPD_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 3:
          if (CAP_IN_Fired != null)
          {
            try
            {
              CAP_IN_Fired(this, new SE.Nereda.Symbols.DAerationLogic.CAP_INEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","CAP_IN_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 4:
          if (PARAMETER_Fired != null)
          {
            try
            {
              PARAMETER_Fired(this, new SE.Nereda.Symbols.DAerationLogic.PARAMETEREventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","PARAMETER_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 5:
          if (CAP_OUT_Fired != null)
          {
            try
            {
              CAP_OUT_Fired(this, new SE.Nereda.Symbols.DAerationLogic.CAP_OUTEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","CAP_OUT_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 6:
          if (IN_CAP_CNFG_Fired != null)
          {
            try
            {
              IN_CAP_CNFG_Fired(this, new SE.Nereda.Symbols.DAerationLogic.IN_CAP_CNFGEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","IN_CAP_CNFG_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_AERATION_PAR(System.Single C_MAX, System.Single C2_IN, System.Single C3_IN)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {C_MAX, C2_IN, C3_IN});
    }
    public bool FireEvent_AERATION_PAR(SE.Nereda.Symbols.DAerationLogic.AERATION_PAREventArgs ea)
    {
      object[] _values_ = new object[3];
      if (ea.C_MAX.HasValue) _values_[0] = ea.C_MAX.Value;
      if (ea.C2_IN.HasValue) _values_[1] = ea.C2_IN.Value;
      if (ea.C3_IN.HasValue) _values_[2] = ea.C3_IN.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_AERATION_PAR(System.Single C_MAX, bool ignore_C_MAX, System.Single C2_IN, bool ignore_C2_IN, System.Single C3_IN, bool ignore_C3_IN)
    {
      object[] _values_ = new object[3];
      if (!ignore_C_MAX) _values_[0] = C_MAX;
      if (!ignore_C2_IN) _values_[1] = C2_IN;
      if (!ignore_C3_IN) _values_[2] = C3_IN;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_CAP_CNFG(System.Int16 CapacityConfig)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {CapacityConfig});
    }
    public bool FireEvent_CAP_CNFG(SE.Nereda.Symbols.DAerationLogic.CAP_CNFGEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.CapacityConfig.HasValue) _values_[0] = ea.CapacityConfig.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_CAP_CNFG(System.Int16 CapacityConfig, bool ignore_CapacityConfig)
    {
      object[] _values_ = new object[1];
      if (!ignore_CapacityConfig) _values_[0] = CapacityConfig;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }

  }
}

namespace SE.Nereda.Faceplates.DAerationLogic
{
  partial class fpSettingsS
  {

    private event EventHandler<SE.Nereda.Symbols.DAerationLogic.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    private event EventHandler<SE.Nereda.Symbols.DAerationLogic.GRAPHEventArgs> GRAPH_Fired;

    private event EventHandler<SE.Nereda.Symbols.DAerationLogic.BLS_OPDEventArgs> BLS_OPD_Fired;

    private event EventHandler<SE.Nereda.Symbols.DAerationLogic.CAP_INEventArgs> CAP_IN_Fired;

    private event EventHandler<SE.Nereda.Symbols.DAerationLogic.PARAMETEREventArgs> PARAMETER_Fired;

    private event EventHandler<SE.Nereda.Symbols.DAerationLogic.CAP_OUTEventArgs> CAP_OUT_Fired;

    private event EventHandler<SE.Nereda.Symbols.DAerationLogic.IN_CAP_CNFGEventArgs> IN_CAP_CNFG_Fired;

    protected override void OnEndInit()
    {
      if (LOAD_PERS_DATA_Fired != null)
        AttachEventInput(0);
      if (GRAPH_Fired != null)
        AttachEventInput(1);
      if (BLS_OPD_Fired != null)
        AttachEventInput(2);
      if (CAP_IN_Fired != null)
        AttachEventInput(3);
      if (PARAMETER_Fired != null)
        AttachEventInput(4);
      if (CAP_OUT_Fired != null)
        AttachEventInput(5);
      if (IN_CAP_CNFG_Fired != null)
        AttachEventInput(6);

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
              LOAD_PERS_DATA_Fired(this, new SE.Nereda.Symbols.DAerationLogic.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
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
              GRAPH_Fired(this, new SE.Nereda.Symbols.DAerationLogic.GRAPHEventArgs(channelId, cookie, eventIndex));
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
          if (BLS_OPD_Fired != null)
          {
            try
            {
              BLS_OPD_Fired(this, new SE.Nereda.Symbols.DAerationLogic.BLS_OPDEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","BLS_OPD_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 3:
          if (CAP_IN_Fired != null)
          {
            try
            {
              CAP_IN_Fired(this, new SE.Nereda.Symbols.DAerationLogic.CAP_INEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","CAP_IN_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 4:
          if (PARAMETER_Fired != null)
          {
            try
            {
              PARAMETER_Fired(this, new SE.Nereda.Symbols.DAerationLogic.PARAMETEREventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","PARAMETER_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 5:
          if (CAP_OUT_Fired != null)
          {
            try
            {
              CAP_OUT_Fired(this, new SE.Nereda.Symbols.DAerationLogic.CAP_OUTEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","CAP_OUT_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 6:
          if (IN_CAP_CNFG_Fired != null)
          {
            try
            {
              IN_CAP_CNFG_Fired(this, new SE.Nereda.Symbols.DAerationLogic.IN_CAP_CNFGEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","IN_CAP_CNFG_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_AERATION_PAR(System.Single C_MAX, System.Single C2_IN, System.Single C3_IN)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {C_MAX, C2_IN, C3_IN});
    }
    public bool FireEvent_AERATION_PAR(SE.Nereda.Symbols.DAerationLogic.AERATION_PAREventArgs ea)
    {
      object[] _values_ = new object[3];
      if (ea.C_MAX.HasValue) _values_[0] = ea.C_MAX.Value;
      if (ea.C2_IN.HasValue) _values_[1] = ea.C2_IN.Value;
      if (ea.C3_IN.HasValue) _values_[2] = ea.C3_IN.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_AERATION_PAR(System.Single C_MAX, bool ignore_C_MAX, System.Single C2_IN, bool ignore_C2_IN, System.Single C3_IN, bool ignore_C3_IN)
    {
      object[] _values_ = new object[3];
      if (!ignore_C_MAX) _values_[0] = C_MAX;
      if (!ignore_C2_IN) _values_[1] = C2_IN;
      if (!ignore_C3_IN) _values_[2] = C3_IN;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_CAP_CNFG(System.Int16 CapacityConfig)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {CapacityConfig});
    }
    public bool FireEvent_CAP_CNFG(SE.Nereda.Symbols.DAerationLogic.CAP_CNFGEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.CapacityConfig.HasValue) _values_[0] = ea.CapacityConfig.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_CAP_CNFG(System.Int16 CapacityConfig, bool ignore_CapacityConfig)
    {
      object[] _values_ = new object[1];
      if (!ignore_CapacityConfig) _values_[0] = CapacityConfig;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }

  }
}

namespace SE.Nereda.Symbols.DAerationLogic
{
  partial class sBlowersInfos
  {

    private event EventHandler<SE.Nereda.Symbols.DAerationLogic.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    private event EventHandler<SE.Nereda.Symbols.DAerationLogic.GRAPHEventArgs> GRAPH_Fired;

    private event EventHandler<SE.Nereda.Symbols.DAerationLogic.BLS_OPDEventArgs> BLS_OPD_Fired;

    private event EventHandler<SE.Nereda.Symbols.DAerationLogic.CAP_INEventArgs> CAP_IN_Fired;

    private event EventHandler<SE.Nereda.Symbols.DAerationLogic.PARAMETEREventArgs> PARAMETER_Fired;

    private event EventHandler<SE.Nereda.Symbols.DAerationLogic.CAP_OUTEventArgs> CAP_OUT_Fired;

    private event EventHandler<SE.Nereda.Symbols.DAerationLogic.IN_CAP_CNFGEventArgs> IN_CAP_CNFG_Fired;

    protected override void OnEndInit()
    {
      if (LOAD_PERS_DATA_Fired != null)
        AttachEventInput(0);
      if (GRAPH_Fired != null)
        AttachEventInput(1);
      if (BLS_OPD_Fired != null)
        AttachEventInput(2);
      if (CAP_IN_Fired != null)
        AttachEventInput(3);
      if (PARAMETER_Fired != null)
        AttachEventInput(4);
      if (CAP_OUT_Fired != null)
        AttachEventInput(5);
      if (IN_CAP_CNFG_Fired != null)
        AttachEventInput(6);

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
              LOAD_PERS_DATA_Fired(this, new SE.Nereda.Symbols.DAerationLogic.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
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
              GRAPH_Fired(this, new SE.Nereda.Symbols.DAerationLogic.GRAPHEventArgs(channelId, cookie, eventIndex));
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
          if (BLS_OPD_Fired != null)
          {
            try
            {
              BLS_OPD_Fired(this, new SE.Nereda.Symbols.DAerationLogic.BLS_OPDEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","BLS_OPD_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 3:
          if (CAP_IN_Fired != null)
          {
            try
            {
              CAP_IN_Fired(this, new SE.Nereda.Symbols.DAerationLogic.CAP_INEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","CAP_IN_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 4:
          if (PARAMETER_Fired != null)
          {
            try
            {
              PARAMETER_Fired(this, new SE.Nereda.Symbols.DAerationLogic.PARAMETEREventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","PARAMETER_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 5:
          if (CAP_OUT_Fired != null)
          {
            try
            {
              CAP_OUT_Fired(this, new SE.Nereda.Symbols.DAerationLogic.CAP_OUTEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","CAP_OUT_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 6:
          if (IN_CAP_CNFG_Fired != null)
          {
            try
            {
              IN_CAP_CNFG_Fired(this, new SE.Nereda.Symbols.DAerationLogic.IN_CAP_CNFGEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","IN_CAP_CNFG_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_AERATION_PAR(System.Single C_MAX, System.Single C2_IN, System.Single C3_IN)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {C_MAX, C2_IN, C3_IN});
    }
    public bool FireEvent_AERATION_PAR(SE.Nereda.Symbols.DAerationLogic.AERATION_PAREventArgs ea)
    {
      object[] _values_ = new object[3];
      if (ea.C_MAX.HasValue) _values_[0] = ea.C_MAX.Value;
      if (ea.C2_IN.HasValue) _values_[1] = ea.C2_IN.Value;
      if (ea.C3_IN.HasValue) _values_[2] = ea.C3_IN.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_AERATION_PAR(System.Single C_MAX, bool ignore_C_MAX, System.Single C2_IN, bool ignore_C2_IN, System.Single C3_IN, bool ignore_C3_IN)
    {
      object[] _values_ = new object[3];
      if (!ignore_C_MAX) _values_[0] = C_MAX;
      if (!ignore_C2_IN) _values_[1] = C2_IN;
      if (!ignore_C3_IN) _values_[2] = C3_IN;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_CAP_CNFG(System.Int16 CapacityConfig)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {CapacityConfig});
    }
    public bool FireEvent_CAP_CNFG(SE.Nereda.Symbols.DAerationLogic.CAP_CNFGEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.CapacityConfig.HasValue) _values_[0] = ea.CapacityConfig.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_CAP_CNFG(System.Int16 CapacityConfig, bool ignore_CapacityConfig)
    {
      object[] _values_ = new object[1];
      if (!ignore_CapacityConfig) _values_[0] = CapacityConfig;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }

  }
}
#endregion #DAerationLogic_HMI;

#endregion Definitions;
