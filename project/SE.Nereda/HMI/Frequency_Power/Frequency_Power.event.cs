/*
 * Created by EcoStruxure Automation Expert.
 * User: SESA371406
 * Date: 7/5/2024
 * Time: 9:33 AM
 * 
 */
using System;
using NxtControl.GuiFramework;
using NxtControl.Services;

#region Definitions;
#region #Frequency_Power_HMI;

namespace SE.Nereda.Symbols.Frequency_Power
{

  public class FREQUENCYEventArgs : System.EventArgs
  {
    IHMIAccessorService accessorService;
    int channelId;
    int cookie; 
    int eventIndex;

    public FREQUENCYEventArgs(int channelId, int cookie, int eventIndex)
    {
      this.accessorService = (IHMIAccessorService)ServiceProvider.GetService(typeof(IHMIAccessorService));
      this.channelId = channelId;
      this.cookie = cookie;
      this.eventIndex = eventIndex;
    }
    public bool Get_Frequency(ref System.Single value)
    {
      if (accessorService == null)
        return false;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,0, ref var);
      if (ret) value = (System.Single) var;
      return ret;
    }

    public System.Single? Frequency
    { get {
      if (accessorService == null)
        return null;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,0, ref var);
      if (!ret) return null;
      return (System.Single) var;
    }  }


  }

  public class POWEREventArgs : System.EventArgs
  {
    IHMIAccessorService accessorService;
    int channelId;
    int cookie; 
    int eventIndex;

    public POWEREventArgs(int channelId, int cookie, int eventIndex)
    {
      this.accessorService = (IHMIAccessorService)ServiceProvider.GetService(typeof(IHMIAccessorService));
      this.channelId = channelId;
      this.cookie = cookie;
      this.eventIndex = eventIndex;
    }
    public bool Get_Power(ref System.Single value)
    {
      if (accessorService == null)
        return false;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,0, ref var);
      if (ret) value = (System.Single) var;
      return ret;
    }

    public System.Single? Power
    { get {
      if (accessorService == null)
        return null;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,0, ref var);
      if (!ret) return null;
      return (System.Single) var;
    }  }


  }

}

namespace SE.Nereda.Symbols.Frequency_Power
{
  partial class sDefault
  {

    private event EventHandler<SE.Nereda.Symbols.Frequency_Power.FREQUENCYEventArgs> FREQUENCY_Fired;

    private event EventHandler<SE.Nereda.Symbols.Frequency_Power.POWEREventArgs> POWER_Fired;

    protected override void OnEndInit()
    {
      if (FREQUENCY_Fired != null)
        AttachEventInput(0);
      if (POWER_Fired != null)
        AttachEventInput(1);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (FREQUENCY_Fired != null)
          {
            try
            {
              FREQUENCY_Fired(this, new SE.Nereda.Symbols.Frequency_Power.FREQUENCYEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","FREQUENCY_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 1:
          if (POWER_Fired != null)
          {
            try
            {
              POWER_Fired(this, new SE.Nereda.Symbols.Frequency_Power.POWEREventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","POWER_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }

  }
}
#endregion #Frequency_Power_HMI;

#endregion Definitions;
