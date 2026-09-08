/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 7/3/2026
 * Time: 10:08 PM
 * 
 */
using System;
using NxtControl.GuiFramework;
using NxtControl.Services;

#region Definitions;
#region #ActuatorsSimulation_HMI;

namespace SE.Nereda.Symbols.ActuatorsSimulation
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

namespace SE.Nereda.Symbols.ActuatorsSimulation
{

  public class ENABLEEventArgs : System.EventArgs
  {
    public ENABLEEventArgs()
    {
    }
    private System.Boolean? EnableSim_field = null;
    public System.Boolean? EnableSim
    {
       get { return EnableSim_field; }
       set { EnableSim_field = value; }
    }

  }

}

namespace SE.Nereda.Symbols.ActuatorsSimulation
{
  partial class sDefault
  {

    private event EventHandler<SE.Nereda.Symbols.ActuatorsSimulation.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

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
              LOAD_PERS_DATA_Fired(this, new SE.Nereda.Symbols.ActuatorsSimulation.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
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
    public bool FireEvent_ENABLE(System.Boolean EnableSim)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {EnableSim});
    }
    public bool FireEvent_ENABLE(SE.Nereda.Symbols.ActuatorsSimulation.ENABLEEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.EnableSim.HasValue) _values_[0] = ea.EnableSim.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_ENABLE(System.Boolean EnableSim, bool ignore_EnableSim)
    {
      object[] _values_ = new object[1];
      if (!ignore_EnableSim) _values_[0] = EnableSim;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }

  }
}
#endregion #ActuatorsSimulation_HMI;

#endregion Definitions;
