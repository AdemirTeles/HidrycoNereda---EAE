/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 6/7/2026
 * Time: 4:40 PM
 * 
 */
using System;
using NxtControl.GuiFramework;
using NxtControl.Services;

#region Definitions;
#region #CmdSludgeDischargeSLB_HMI;

namespace SE.Nereda.Symbols.CmdSludgeDischargeSLB
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

}

namespace SE.Nereda.Symbols.CmdSludgeDischargeSLB
{

  public class FEED_FLOW_SPEventArgs : System.EventArgs
  {
    public FEED_FLOW_SPEventArgs()
    {
    }
    private System.Single? FeedFlowSp_field = null;
    public System.Single? FeedFlowSp
    {
       get { return FeedFlowSp_field; }
       set { FeedFlowSp_field = value; }
    }

  }

  public class FEED_FLOW_SP_MANEventArgs : System.EventArgs
  {
    public FEED_FLOW_SP_MANEventArgs()
    {
    }
    private System.Single? FeedFlowSpMan_field = null;
    public System.Single? FeedFlowSpMan
    {
       get { return FeedFlowSpMan_field; }
       set { FeedFlowSpMan_field = value; }
    }

  }

  public class PAUSE_PAREventArgs : System.EventArgs
  {
    public PAUSE_PAREventArgs()
    {
    }
    private NxtControl.GuiFramework.Time? T_Restart_field = null;
    public NxtControl.GuiFramework.Time? T_Restart
    {
       get { return T_Restart_field; }
       set { T_Restart_field = value; }
    }
    private NxtControl.GuiFramework.Time? T_FlowLL_field = null;
    public NxtControl.GuiFramework.Time? T_FlowLL
    {
       get { return T_FlowLL_field; }
       set { T_FlowLL_field = value; }
    }

  }

  public class PUMP_MIN_PAREventArgs : System.EventArgs
  {
    public PUMP_MIN_PAREventArgs()
    {
    }
    private System.Single? Cmin_field = null;
    public System.Single? Cmin
    {
       get { return Cmin_field; }
       set { Cmin_field = value; }
    }

  }

}

namespace SE.Nereda.Symbols.CmdSludgeDischargeSLB
{
  partial class sDefault
  {

    private event EventHandler<SE.Nereda.Symbols.CmdSludgeDischargeSLB.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    protected override void OnEndInit()
    {
      if (LOAD_PERS_DATA_Fired != null)
        AttachEventInput(0);

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
              LOAD_PERS_DATA_Fired(this, new SE.Nereda.Symbols.CmdSludgeDischargeSLB.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
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
    public bool FireEvent_FEED_FLOW_SP(System.Single FeedFlowSp)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {FeedFlowSp});
    }
    public bool FireEvent_FEED_FLOW_SP(SE.Nereda.Symbols.CmdSludgeDischargeSLB.FEED_FLOW_SPEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.FeedFlowSp.HasValue) _values_[0] = ea.FeedFlowSp.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_FEED_FLOW_SP(System.Single FeedFlowSp, bool ignore_FeedFlowSp)
    {
      object[] _values_ = new object[1];
      if (!ignore_FeedFlowSp) _values_[0] = FeedFlowSp;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_FEED_FLOW_SP_MAN(System.Single FeedFlowSpMan)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {FeedFlowSpMan});
    }
    public bool FireEvent_FEED_FLOW_SP_MAN(SE.Nereda.Symbols.CmdSludgeDischargeSLB.FEED_FLOW_SP_MANEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.FeedFlowSpMan.HasValue) _values_[0] = ea.FeedFlowSpMan.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_FEED_FLOW_SP_MAN(System.Single FeedFlowSpMan, bool ignore_FeedFlowSpMan)
    {
      object[] _values_ = new object[1];
      if (!ignore_FeedFlowSpMan) _values_[0] = FeedFlowSpMan;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_PAUSE_PAR(NxtControl.GuiFramework.Time T_Restart, NxtControl.GuiFramework.Time T_FlowLL)
    {
      return ((IHMIAccessorOutput)this).FireEvent(2, new object[] {T_Restart, T_FlowLL});
    }
    public bool FireEvent_PAUSE_PAR(SE.Nereda.Symbols.CmdSludgeDischargeSLB.PAUSE_PAREventArgs ea)
    {
      object[] _values_ = new object[2];
      if (ea.T_Restart.HasValue) _values_[0] = ea.T_Restart.Value;
      if (ea.T_FlowLL.HasValue) _values_[1] = ea.T_FlowLL.Value;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_PAUSE_PAR(NxtControl.GuiFramework.Time T_Restart, bool ignore_T_Restart, NxtControl.GuiFramework.Time T_FlowLL, bool ignore_T_FlowLL)
    {
      object[] _values_ = new object[2];
      if (!ignore_T_Restart) _values_[0] = T_Restart;
      if (!ignore_T_FlowLL) _values_[1] = T_FlowLL;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_PUMP_MIN_PAR(System.Single Cmin)
    {
      return ((IHMIAccessorOutput)this).FireEvent(3, new object[] {Cmin});
    }
    public bool FireEvent_PUMP_MIN_PAR(SE.Nereda.Symbols.CmdSludgeDischargeSLB.PUMP_MIN_PAREventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.Cmin.HasValue) _values_[0] = ea.Cmin.Value;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_PUMP_MIN_PAR(System.Single Cmin, bool ignore_Cmin)
    {
      object[] _values_ = new object[1];
      if (!ignore_Cmin) _values_[0] = Cmin;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }

  }
}
#endregion #CmdSludgeDischargeSLB_HMI;

#endregion Definitions;
