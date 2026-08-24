/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 6/26/2026
 * Time: 3:21 PM
 * 
 */
using System;
using NxtControl.GuiFramework;
using NxtControl.Services;

#region Definitions;
#region #CalamityValveLogic_HMI;

namespace SE.Nereda.Symbols.CalamityValveLogic
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

namespace SE.Nereda.Symbols.CalamityValveLogic
{

  public class CNF_DUR_SPEventArgs : System.EventArgs
  {
    public CNF_DUR_SPEventArgs()
    {
    }
    private NxtControl.GuiFramework.Time? OpeningValveDurSp_field = null;
    public NxtControl.GuiFramework.Time? OpeningValveDurSp
    {
       get { return OpeningValveDurSp_field; }
       set { OpeningValveDurSp_field = value; }
    }

  }

  public class FORCE_CLOSEEventArgs : System.EventArgs
  {
    public FORCE_CLOSEEventArgs()
    {
    }
    private System.Boolean? ForceClose_field = null;
    public System.Boolean? ForceClose
    {
       get { return ForceClose_field; }
       set { ForceClose_field = value; }
    }

  }

}

namespace SE.Nereda.Symbols.CalamityValveLogic
{
  partial class sDefault
  {

    private event EventHandler<SE.Nereda.Symbols.CalamityValveLogic.GRAPHEventArgs> GRAPH_Fired;

    private event EventHandler<SE.Nereda.Symbols.CalamityValveLogic.RESET_BTNsEventArgs> RESET_BTNs_Fired;

    private event EventHandler<SE.Nereda.Symbols.CalamityValveLogic.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

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
              GRAPH_Fired(this, new SE.Nereda.Symbols.CalamityValveLogic.GRAPHEventArgs(channelId, cookie, eventIndex));
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
              RESET_BTNs_Fired(this, new SE.Nereda.Symbols.CalamityValveLogic.RESET_BTNsEventArgs(channelId, cookie, eventIndex));
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
              LOAD_PERS_DATA_Fired(this, new SE.Nereda.Symbols.CalamityValveLogic.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
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
    public bool FireEvent_CNF_DUR_SP(NxtControl.GuiFramework.Time OpeningValveDurSp)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {OpeningValveDurSp});
    }
    public bool FireEvent_CNF_DUR_SP(SE.Nereda.Symbols.CalamityValveLogic.CNF_DUR_SPEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.OpeningValveDurSp.HasValue) _values_[0] = ea.OpeningValveDurSp.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_CNF_DUR_SP(NxtControl.GuiFramework.Time OpeningValveDurSp, bool ignore_OpeningValveDurSp)
    {
      object[] _values_ = new object[1];
      if (!ignore_OpeningValveDurSp) _values_[0] = OpeningValveDurSp;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_FORCE_CLOSE(System.Boolean ForceClose)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {ForceClose});
    }
    public bool FireEvent_FORCE_CLOSE(SE.Nereda.Symbols.CalamityValveLogic.FORCE_CLOSEEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.ForceClose.HasValue) _values_[0] = ea.ForceClose.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_FORCE_CLOSE(System.Boolean ForceClose, bool ignore_ForceClose)
    {
      object[] _values_ = new object[1];
      if (!ignore_ForceClose) _values_[0] = ForceClose;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }

  }
}

namespace SE.Nereda.Faceplates.CalamityValveLogic
{
  partial class fpDiagram
  {

    private event EventHandler<SE.Nereda.Symbols.CalamityValveLogic.GRAPHEventArgs> GRAPH_Fired;

    private event EventHandler<SE.Nereda.Symbols.CalamityValveLogic.RESET_BTNsEventArgs> RESET_BTNs_Fired;

    private event EventHandler<SE.Nereda.Symbols.CalamityValveLogic.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

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
              GRAPH_Fired(this, new SE.Nereda.Symbols.CalamityValveLogic.GRAPHEventArgs(channelId, cookie, eventIndex));
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
              RESET_BTNs_Fired(this, new SE.Nereda.Symbols.CalamityValveLogic.RESET_BTNsEventArgs(channelId, cookie, eventIndex));
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
              LOAD_PERS_DATA_Fired(this, new SE.Nereda.Symbols.CalamityValveLogic.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
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
    public bool FireEvent_CNF_DUR_SP(NxtControl.GuiFramework.Time OpeningValveDurSp)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {OpeningValveDurSp});
    }
    public bool FireEvent_CNF_DUR_SP(SE.Nereda.Symbols.CalamityValveLogic.CNF_DUR_SPEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.OpeningValveDurSp.HasValue) _values_[0] = ea.OpeningValveDurSp.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_CNF_DUR_SP(NxtControl.GuiFramework.Time OpeningValveDurSp, bool ignore_OpeningValveDurSp)
    {
      object[] _values_ = new object[1];
      if (!ignore_OpeningValveDurSp) _values_[0] = OpeningValveDurSp;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_FORCE_CLOSE(System.Boolean ForceClose)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {ForceClose});
    }
    public bool FireEvent_FORCE_CLOSE(SE.Nereda.Symbols.CalamityValveLogic.FORCE_CLOSEEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.ForceClose.HasValue) _values_[0] = ea.ForceClose.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_FORCE_CLOSE(System.Boolean ForceClose, bool ignore_ForceClose)
    {
      object[] _values_ = new object[1];
      if (!ignore_ForceClose) _values_[0] = ForceClose;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }

  }
}

namespace SE.Nereda.Symbols.CalamityValveLogic
{
  partial class sSettings
  {

    private event EventHandler<SE.Nereda.Symbols.CalamityValveLogic.GRAPHEventArgs> GRAPH_Fired;

    private event EventHandler<SE.Nereda.Symbols.CalamityValveLogic.RESET_BTNsEventArgs> RESET_BTNs_Fired;

    private event EventHandler<SE.Nereda.Symbols.CalamityValveLogic.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

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
              GRAPH_Fired(this, new SE.Nereda.Symbols.CalamityValveLogic.GRAPHEventArgs(channelId, cookie, eventIndex));
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
              RESET_BTNs_Fired(this, new SE.Nereda.Symbols.CalamityValveLogic.RESET_BTNsEventArgs(channelId, cookie, eventIndex));
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
              LOAD_PERS_DATA_Fired(this, new SE.Nereda.Symbols.CalamityValveLogic.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
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
    public bool FireEvent_CNF_DUR_SP(NxtControl.GuiFramework.Time OpeningValveDurSp)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {OpeningValveDurSp});
    }
    public bool FireEvent_CNF_DUR_SP(SE.Nereda.Symbols.CalamityValveLogic.CNF_DUR_SPEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.OpeningValveDurSp.HasValue) _values_[0] = ea.OpeningValveDurSp.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_CNF_DUR_SP(NxtControl.GuiFramework.Time OpeningValveDurSp, bool ignore_OpeningValveDurSp)
    {
      object[] _values_ = new object[1];
      if (!ignore_OpeningValveDurSp) _values_[0] = OpeningValveDurSp;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_FORCE_CLOSE(System.Boolean ForceClose)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {ForceClose});
    }
    public bool FireEvent_FORCE_CLOSE(SE.Nereda.Symbols.CalamityValveLogic.FORCE_CLOSEEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.ForceClose.HasValue) _values_[0] = ea.ForceClose.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_FORCE_CLOSE(System.Boolean ForceClose, bool ignore_ForceClose)
    {
      object[] _values_ = new object[1];
      if (!ignore_ForceClose) _values_[0] = ForceClose;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }

  }
}

namespace SE.Nereda.Symbols.CalamityValveLogic
{
  partial class sDuration
  {

    private event EventHandler<SE.Nereda.Symbols.CalamityValveLogic.GRAPHEventArgs> GRAPH_Fired;

    private event EventHandler<SE.Nereda.Symbols.CalamityValveLogic.RESET_BTNsEventArgs> RESET_BTNs_Fired;

    private event EventHandler<SE.Nereda.Symbols.CalamityValveLogic.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

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
              GRAPH_Fired(this, new SE.Nereda.Symbols.CalamityValveLogic.GRAPHEventArgs(channelId, cookie, eventIndex));
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
              RESET_BTNs_Fired(this, new SE.Nereda.Symbols.CalamityValveLogic.RESET_BTNsEventArgs(channelId, cookie, eventIndex));
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
              LOAD_PERS_DATA_Fired(this, new SE.Nereda.Symbols.CalamityValveLogic.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
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
    public bool FireEvent_CNF_DUR_SP(NxtControl.GuiFramework.Time OpeningValveDurSp)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {OpeningValveDurSp});
    }
    public bool FireEvent_CNF_DUR_SP(SE.Nereda.Symbols.CalamityValveLogic.CNF_DUR_SPEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.OpeningValveDurSp.HasValue) _values_[0] = ea.OpeningValveDurSp.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_CNF_DUR_SP(NxtControl.GuiFramework.Time OpeningValveDurSp, bool ignore_OpeningValveDurSp)
    {
      object[] _values_ = new object[1];
      if (!ignore_OpeningValveDurSp) _values_[0] = OpeningValveDurSp;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_FORCE_CLOSE(System.Boolean ForceClose)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {ForceClose});
    }
    public bool FireEvent_FORCE_CLOSE(SE.Nereda.Symbols.CalamityValveLogic.FORCE_CLOSEEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.ForceClose.HasValue) _values_[0] = ea.ForceClose.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_FORCE_CLOSE(System.Boolean ForceClose, bool ignore_ForceClose)
    {
      object[] _values_ = new object[1];
      if (!ignore_ForceClose) _values_[0] = ForceClose;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }

  }
}

namespace SE.Nereda.Symbols.CalamityValveLogic
{
  partial class sForceClose
  {

    private event EventHandler<SE.Nereda.Symbols.CalamityValveLogic.GRAPHEventArgs> GRAPH_Fired;

    private event EventHandler<SE.Nereda.Symbols.CalamityValveLogic.RESET_BTNsEventArgs> RESET_BTNs_Fired;

    private event EventHandler<SE.Nereda.Symbols.CalamityValveLogic.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

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
              GRAPH_Fired(this, new SE.Nereda.Symbols.CalamityValveLogic.GRAPHEventArgs(channelId, cookie, eventIndex));
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
              RESET_BTNs_Fired(this, new SE.Nereda.Symbols.CalamityValveLogic.RESET_BTNsEventArgs(channelId, cookie, eventIndex));
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
              LOAD_PERS_DATA_Fired(this, new SE.Nereda.Symbols.CalamityValveLogic.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
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
    public bool FireEvent_CNF_DUR_SP(NxtControl.GuiFramework.Time OpeningValveDurSp)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {OpeningValveDurSp});
    }
    public bool FireEvent_CNF_DUR_SP(SE.Nereda.Symbols.CalamityValveLogic.CNF_DUR_SPEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.OpeningValveDurSp.HasValue) _values_[0] = ea.OpeningValveDurSp.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_CNF_DUR_SP(NxtControl.GuiFramework.Time OpeningValveDurSp, bool ignore_OpeningValveDurSp)
    {
      object[] _values_ = new object[1];
      if (!ignore_OpeningValveDurSp) _values_[0] = OpeningValveDurSp;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_FORCE_CLOSE(System.Boolean ForceClose)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {ForceClose});
    }
    public bool FireEvent_FORCE_CLOSE(SE.Nereda.Symbols.CalamityValveLogic.FORCE_CLOSEEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.ForceClose.HasValue) _values_[0] = ea.ForceClose.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_FORCE_CLOSE(System.Boolean ForceClose, bool ignore_ForceClose)
    {
      object[] _values_ = new object[1];
      if (!ignore_ForceClose) _values_[0] = ForceClose;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }

  }
}
#endregion #CalamityValveLogic_HMI;

#endregion Definitions;
