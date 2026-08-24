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
#region #CmdLowerLevel_HMI;

namespace SE.Nereda.Symbols.CmdLowerLevel
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

namespace SE.Nereda.Symbols.CmdLowerLevel
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

}

namespace SE.Nereda.Symbols.CmdLowerLevel
{
  partial class sDefault
  {

    private event EventHandler<SE.Nereda.Symbols.CmdLowerLevel.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

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
              LOAD_PERS_DATA_Fired(this, new SE.Nereda.Symbols.CmdLowerLevel.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
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
    public bool FireEvent_FEED_FLOW_SP(SE.Nereda.Symbols.CmdLowerLevel.FEED_FLOW_SPEventArgs ea)
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
    public bool FireEvent_FEED_FLOW_SP_MAN(SE.Nereda.Symbols.CmdLowerLevel.FEED_FLOW_SP_MANEventArgs ea)
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

  }
}
#endregion #CmdLowerLevel_HMI;

#endregion Definitions;
