/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 6/7/2026
 * Time: 3:25 PM
 * 
 */
using System;
using NxtControl.GuiFramework;
using NxtControl.Services;

#region Definitions;
#region #ReactorLogic_HMI;

namespace SE.Nereda.Symbols.ReactorLogic
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

namespace SE.Nereda.Symbols.ReactorLogic
{

  public class CNFEventArgs : System.EventArgs
  {
    public CNFEventArgs()
    {
    }

  }

}

namespace SE.Nereda.Symbols.ReactorLogic
{
  partial class sDefault
  {

    private event EventHandler<SE.Nereda.Symbols.ReactorLogic.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

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
              LOAD_PERS_DATA_Fired(this, new SE.Nereda.Symbols.ReactorLogic.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
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
    public bool FireEvent_CNF()
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {});
    }
    public bool FireEvent_CNF(SE.Nereda.Symbols.ReactorLogic.CNFEventArgs ea)
    {
      object[] _values_ = new object[0];
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }

  }
}

namespace SE.Nereda.Symbols.ReactorLogic
{
  partial class sPhases
  {

    private event EventHandler<SE.Nereda.Symbols.ReactorLogic.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

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
              LOAD_PERS_DATA_Fired(this, new SE.Nereda.Symbols.ReactorLogic.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
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
    public bool FireEvent_CNF()
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {});
    }
    public bool FireEvent_CNF(SE.Nereda.Symbols.ReactorLogic.CNFEventArgs ea)
    {
      object[] _values_ = new object[0];
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }

  }
}
#endregion #ReactorLogic_HMI;

#endregion Definitions;
