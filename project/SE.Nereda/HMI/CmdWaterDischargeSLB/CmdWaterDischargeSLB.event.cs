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
#region #CmdWaterDischargeSLB_HMI;

namespace SE.Nereda.Symbols.CmdWaterDischargeSLB
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

namespace SE.Nereda.Symbols.CmdWaterDischargeSLB
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

  public class DISCHARGE_PAREventArgs : System.EventArgs
  {
    public DISCHARGE_PAREventArgs()
    {
    }
    private System.Single? Cmax_field = null;
    public System.Single? Cmax
    {
       get { return Cmax_field; }
       set { Cmax_field = value; }
    }
    private System.Single? C2_field = null;
    public System.Single? C2
    {
       get { return C2_field; }
       set { C2_field = value; }
    }
    private System.Single? C3_field = null;
    public System.Single? C3
    {
       get { return C3_field; }
       set { C3_field = value; }
    }
    private NxtControl.GuiFramework.Time? T_C2_field = null;
    public NxtControl.GuiFramework.Time? T_C2
    {
       get { return T_C2_field; }
       set { T_C2_field = value; }
    }
    private NxtControl.GuiFramework.Time? T_C3_field = null;
    public NxtControl.GuiFramework.Time? T_C3
    {
       get { return T_C3_field; }
       set { T_C3_field = value; }
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

}

namespace SE.Nereda.Symbols.CmdWaterDischargeSLB
{
  partial class sDefault
  {

    private event EventHandler<SE.Nereda.Symbols.CmdWaterDischargeSLB.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

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
              LOAD_PERS_DATA_Fired(this, new SE.Nereda.Symbols.CmdWaterDischargeSLB.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
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
    public bool FireEvent_FEED_FLOW_SP(SE.Nereda.Symbols.CmdWaterDischargeSLB.FEED_FLOW_SPEventArgs ea)
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
    public bool FireEvent_FEED_FLOW_SP_MAN(SE.Nereda.Symbols.CmdWaterDischargeSLB.FEED_FLOW_SP_MANEventArgs ea)
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
    public bool FireEvent_DISCHARGE_PAR(System.Single Cmax, System.Single C2, System.Single C3, NxtControl.GuiFramework.Time T_C2, NxtControl.GuiFramework.Time T_C3)
    {
      return ((IHMIAccessorOutput)this).FireEvent(2, new object[] {Cmax, C2, C3, T_C2, T_C3});
    }
    public bool FireEvent_DISCHARGE_PAR(SE.Nereda.Symbols.CmdWaterDischargeSLB.DISCHARGE_PAREventArgs ea)
    {
      object[] _values_ = new object[5];
      if (ea.Cmax.HasValue) _values_[0] = ea.Cmax.Value;
      if (ea.C2.HasValue) _values_[1] = ea.C2.Value;
      if (ea.C3.HasValue) _values_[2] = ea.C3.Value;
      if (ea.T_C2.HasValue) _values_[3] = ea.T_C2.Value;
      if (ea.T_C3.HasValue) _values_[4] = ea.T_C3.Value;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_DISCHARGE_PAR(System.Single Cmax, bool ignore_Cmax, System.Single C2, bool ignore_C2, System.Single C3, bool ignore_C3, NxtControl.GuiFramework.Time T_C2, bool ignore_T_C2, NxtControl.GuiFramework.Time T_C3, bool ignore_T_C3)
    {
      object[] _values_ = new object[5];
      if (!ignore_Cmax) _values_[0] = Cmax;
      if (!ignore_C2) _values_[1] = C2;
      if (!ignore_C3) _values_[2] = C3;
      if (!ignore_T_C2) _values_[3] = T_C2;
      if (!ignore_T_C3) _values_[4] = T_C3;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_PAUSE_PAR(NxtControl.GuiFramework.Time T_Restart, NxtControl.GuiFramework.Time T_FlowLL)
    {
      return ((IHMIAccessorOutput)this).FireEvent(3, new object[] {T_Restart, T_FlowLL});
    }
    public bool FireEvent_PAUSE_PAR(SE.Nereda.Symbols.CmdWaterDischargeSLB.PAUSE_PAREventArgs ea)
    {
      object[] _values_ = new object[2];
      if (ea.T_Restart.HasValue) _values_[0] = ea.T_Restart.Value;
      if (ea.T_FlowLL.HasValue) _values_[1] = ea.T_FlowLL.Value;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_PAUSE_PAR(NxtControl.GuiFramework.Time T_Restart, bool ignore_T_Restart, NxtControl.GuiFramework.Time T_FlowLL, bool ignore_T_FlowLL)
    {
      object[] _values_ = new object[2];
      if (!ignore_T_Restart) _values_[0] = T_Restart;
      if (!ignore_T_FlowLL) _values_[1] = T_FlowLL;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }

  }
}
#endregion #CmdWaterDischargeSLB_HMI;

#endregion Definitions;
