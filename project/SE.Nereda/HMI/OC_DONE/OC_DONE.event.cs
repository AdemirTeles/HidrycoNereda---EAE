/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 7/10/2026
 * Time: 4:53 PM
 * 
 */
using System;
using NxtControl.GuiFramework;
using NxtControl.Services;

#region Definitions;
#region #OC_DONE_HMI;

namespace SE.Nereda.Symbols.OC_DONE
{

  public class OC_INEventArgs : System.EventArgs
  {
    IHMIAccessorService accessorService;
    int channelId;
    int cookie; 
    int eventIndex;

    public OC_INEventArgs(int channelId, int cookie, int eventIndex)
    {
      this.accessorService = (IHMIAccessorService)ServiceProvider.GetService(typeof(IHMIAccessorService));
      this.channelId = channelId;
      this.cookie = cookie;
      this.eventIndex = eventIndex;
    }
    public bool Get_OC(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,0, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? OC
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,0, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }


  }

}

namespace SE.Nereda.Symbols.OC_DONE
{

  public class OC_DONEEventArgs : System.EventArgs
  {
    public OC_DONEEventArgs()
    {
    }
    private System.Boolean? OC_Done_field = null;
    public System.Boolean? OC_Done
    {
       get { return OC_Done_field; }
       set { OC_Done_field = value; }
    }

  }

}

namespace SE.Nereda.Symbols.OC_DONE
{
  partial class sDefault
  {

    private event EventHandler<SE.Nereda.Symbols.OC_DONE.OC_INEventArgs> OC_IN_Fired;

    protected override void OnEndInit()
    {
      if (OC_IN_Fired != null)
        AttachEventInput(0);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (OC_IN_Fired != null)
          {
            try
            {
              OC_IN_Fired(this, new SE.Nereda.Symbols.OC_DONE.OC_INEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","OC_IN_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_OC_DONE(System.Boolean OC_Done)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {OC_Done});
    }
    public bool FireEvent_OC_DONE(SE.Nereda.Symbols.OC_DONE.OC_DONEEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.OC_Done.HasValue) _values_[0] = ea.OC_Done.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_OC_DONE(System.Boolean OC_Done, bool ignore_OC_Done)
    {
      object[] _values_ = new object[1];
      if (!ignore_OC_Done) _values_[0] = OC_Done;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }

  }
}
#endregion #OC_DONE_HMI;

#endregion Definitions;
