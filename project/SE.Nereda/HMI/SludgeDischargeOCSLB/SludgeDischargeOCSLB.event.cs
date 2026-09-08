/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 6/7/2026
 * Time: 3:31 PM
 * 
 */
using System;
using NxtControl.GuiFramework;
using NxtControl.Services;

#region Definitions;
#region #SludgeDischargeOCSLB_HMI;

namespace SE.Nereda.Symbols.SludgeDischargeOCSLB
{

  public class OC_STATUSWORDEventArgs : System.EventArgs
  {
    IHMIAccessorService accessorService;
    int channelId;
    int cookie; 
    int eventIndex;

    public OC_STATUSWORDEventArgs(int channelId, int cookie, int eventIndex)
    {
      this.accessorService = (IHMIAccessorService)ServiceProvider.GetService(typeof(IHMIAccessorService));
      this.channelId = channelId;
      this.cookie = cookie;
      this.eventIndex = eventIndex;
    }
    public bool Get_OC_Statusword(ref System.UInt16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,0, ref var);
      if (ret) value = (System.UInt16) var;
      return ret;
    }

    public System.UInt16? OC_Statusword
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,0, ref var);
      if (!ret) return null;
      return (System.UInt16) var;
    }  }


  }

}

namespace SE.Nereda.Symbols.SludgeDischargeOCSLB
{
  partial class sDefault
  {

    private event EventHandler<SE.Nereda.Symbols.SludgeDischargeOCSLB.OC_STATUSWORDEventArgs> OC_STATUSWORD_Fired;

    protected override void OnEndInit()
    {
      if (OC_STATUSWORD_Fired != null)
        AttachEventInput(0);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (OC_STATUSWORD_Fired != null)
          {
            try
            {
              OC_STATUSWORD_Fired(this, new SE.Nereda.Symbols.SludgeDischargeOCSLB.OC_STATUSWORDEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","OC_STATUSWORD_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }

  }
}
#endregion #SludgeDischargeOCSLB_HMI;

#endregion Definitions;
