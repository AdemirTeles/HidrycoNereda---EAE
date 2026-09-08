/*
 * Created by EcoStruxure Automation Expert.
 * User: SESA713705
 * Date: 2/4/2026
 * Time: 11:49 AM
 * 
 */
using System;
using NxtControl.GuiFramework;
using NxtControl.Services;

#region Definitions;
#region #E_DELAY_V_D_HMI;

namespace SE.Nereda.Symbols.E_DELAY_V_D
{

  public class DUREventArgs : System.EventArgs
  {
    IHMIAccessorService accessorService;
    int channelId;
    int cookie; 
    int eventIndex;

    public DUREventArgs(int channelId, int cookie, int eventIndex)
    {
      this.accessorService = (IHMIAccessorService)ServiceProvider.GetService(typeof(IHMIAccessorService));
      this.channelId = channelId;
      this.cookie = cookie;
      this.eventIndex = eventIndex;
    }
    public bool Get_DurSp(ref NxtControl.GuiFramework.Time value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,0, ref var);
      if (ret) value = (NxtControl.GuiFramework.Time) var;
      return ret;
    }

    public NxtControl.GuiFramework.Time? DurSp
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,0, ref var);
      if (!ret) return null;
      return (NxtControl.GuiFramework.Time) var;
    }  }

    public bool Get_DurPv(ref NxtControl.GuiFramework.Time value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,1, ref var);
      if (ret) value = (NxtControl.GuiFramework.Time) var;
      return ret;
    }

    public NxtControl.GuiFramework.Time? DurPv
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,1, ref var);
      if (!ret) return null;
      return (NxtControl.GuiFramework.Time) var;
    }  }


  }

}

namespace SE.Nereda.Symbols.E_DELAY_V_D
{
  partial class sDefault
  {

    private event EventHandler<SE.Nereda.Symbols.E_DELAY_V_D.DUREventArgs> DUR_Fired;

    protected override void OnEndInit()
    {
      if (DUR_Fired != null)
        AttachEventInput(0);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (DUR_Fired != null)
          {
            try
            {
              DUR_Fired(this, new SE.Nereda.Symbols.E_DELAY_V_D.DUREventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","DUR_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }

  }
}

namespace SE.Nereda.Symbols.E_DELAY_V_D
{
  partial class sCounter
  {

    private event EventHandler<SE.Nereda.Symbols.E_DELAY_V_D.DUREventArgs> DUR_Fired;

    protected override void OnEndInit()
    {
      if (DUR_Fired != null)
        AttachEventInput(0);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (DUR_Fired != null)
          {
            try
            {
              DUR_Fired(this, new SE.Nereda.Symbols.E_DELAY_V_D.DUREventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","DUR_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }

  }
}

namespace SE.Nereda.Symbols.E_DELAY_V_D
{
  partial class sTimePv
  {

    private event EventHandler<SE.Nereda.Symbols.E_DELAY_V_D.DUREventArgs> DUR_Fired;

    protected override void OnEndInit()
    {
      if (DUR_Fired != null)
        AttachEventInput(0);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (DUR_Fired != null)
          {
            try
            {
              DUR_Fired(this, new SE.Nereda.Symbols.E_DELAY_V_D.DUREventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","DUR_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }

  }
}

namespace SE.Nereda.Symbols.E_DELAY_V_D
{
  partial class sCounter2
  {

    private event EventHandler<SE.Nereda.Symbols.E_DELAY_V_D.DUREventArgs> DUR_Fired;

    protected override void OnEndInit()
    {
      if (DUR_Fired != null)
        AttachEventInput(0);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (DUR_Fired != null)
          {
            try
            {
              DUR_Fired(this, new SE.Nereda.Symbols.E_DELAY_V_D.DUREventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","DUR_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }

  }
}
#endregion #E_DELAY_V_D_HMI;

#endregion Definitions;
