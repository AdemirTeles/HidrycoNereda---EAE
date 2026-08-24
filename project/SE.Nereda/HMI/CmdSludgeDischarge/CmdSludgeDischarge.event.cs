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
#region #CmdSludgeDischarge_HMI;

namespace SE.Nereda.Symbols.CmdSludgeDischarge
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

namespace SE.Nereda.Symbols.CmdSludgeDischarge
{

  public class CNF_SD_SPEventArgs : System.EventArgs
  {
    public CNF_SD_SPEventArgs()
    {
    }
    private System.Single? SDLevelSetPoint_field = null;
    public System.Single? SDLevelSetPoint
    {
       get { return SDLevelSetPoint_field; }
       set { SDLevelSetPoint_field = value; }
    }

  }

}

namespace SE.Nereda.Symbols.CmdSludgeDischarge
{
  partial class sDefault
  {

    private event EventHandler<SE.Nereda.Symbols.CmdSludgeDischarge.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

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
              LOAD_PERS_DATA_Fired(this, new SE.Nereda.Symbols.CmdSludgeDischarge.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
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
    public bool FireEvent_CNF_SD_SP(System.Single SDLevelSetPoint)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {SDLevelSetPoint});
    }
    public bool FireEvent_CNF_SD_SP(SE.Nereda.Symbols.CmdSludgeDischarge.CNF_SD_SPEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.SDLevelSetPoint.HasValue) _values_[0] = ea.SDLevelSetPoint.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_CNF_SD_SP(System.Single SDLevelSetPoint, bool ignore_SDLevelSetPoint)
    {
      object[] _values_ = new object[1];
      if (!ignore_SDLevelSetPoint) _values_[0] = SDLevelSetPoint;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }

  }
}
#endregion #CmdSludgeDischarge_HMI;

#endregion Definitions;
