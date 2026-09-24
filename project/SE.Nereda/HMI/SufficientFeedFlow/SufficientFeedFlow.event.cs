/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 9/23/2026
 * Time: 3:20 PM
 * 
 */
using System;
using NxtControl.GuiFramework;
using NxtControl.Services;

#region Definitions;
#region #SufficientFeedFlow_HMI;

namespace SE.Nereda.Symbols.SufficientFeedFlow
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

namespace SE.Nereda.Symbols.SufficientFeedFlow
{

  public class CNFEventArgs : System.EventArgs
  {
    public CNFEventArgs()
    {
    }
    private System.Int32? LevelCheckTimeSp_field = null;
    public System.Int32? LevelCheckTimeSp
    {
       get { return LevelCheckTimeSp_field; }
       set { LevelCheckTimeSp_field = value; }
    }
    private System.Single? MinLevelRiseSp_field = null;
    public System.Single? MinLevelRiseSp
    {
       get { return MinLevelRiseSp_field; }
       set { MinLevelRiseSp_field = value; }
    }

  }

}

namespace SE.Nereda.Symbols.SufficientFeedFlow
{
  partial class sDefault
  {

    private event EventHandler<SE.Nereda.Symbols.SufficientFeedFlow.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

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
              LOAD_PERS_DATA_Fired(this, new SE.Nereda.Symbols.SufficientFeedFlow.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
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
    public bool FireEvent_CNF(System.Int32 LevelCheckTimeSp, System.Single MinLevelRiseSp)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {LevelCheckTimeSp, MinLevelRiseSp});
    }
    public bool FireEvent_CNF(SE.Nereda.Symbols.SufficientFeedFlow.CNFEventArgs ea)
    {
      object[] _values_ = new object[2];
      if (ea.LevelCheckTimeSp.HasValue) _values_[0] = ea.LevelCheckTimeSp.Value;
      if (ea.MinLevelRiseSp.HasValue) _values_[1] = ea.MinLevelRiseSp.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_CNF(System.Int32 LevelCheckTimeSp, bool ignore_LevelCheckTimeSp, System.Single MinLevelRiseSp, bool ignore_MinLevelRiseSp)
    {
      object[] _values_ = new object[2];
      if (!ignore_LevelCheckTimeSp) _values_[0] = LevelCheckTimeSp;
      if (!ignore_MinLevelRiseSp) _values_[1] = MinLevelRiseSp;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }

  }
}
#endregion #SufficientFeedFlow_HMI;

#endregion Definitions;
