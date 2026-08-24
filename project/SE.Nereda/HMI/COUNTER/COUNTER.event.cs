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
#region #COUNTER_HMI;

namespace SE.Nereda.Symbols.COUNTER
{

  public class OPDEventArgs : System.EventArgs
  {
    IHMIAccessorService accessorService;
    int channelId;
    int cookie; 
    int eventIndex;

    public OPDEventArgs(int channelId, int cookie, int eventIndex)
    {
      this.accessorService = (IHMIAccessorService)ServiceProvider.GetService(typeof(IHMIAccessorService));
      this.channelId = channelId;
      this.cookie = cookie;
      this.eventIndex = eventIndex;
    }
    public bool Get_CurrOperDur(ref NxtControl.GuiFramework.Time value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,0, ref var);
      if (ret) value = (NxtControl.GuiFramework.Time) var;
      return ret;
    }

    public NxtControl.GuiFramework.Time? CurrOperDur
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,0, ref var);
      if (!ret) return null;
      return (NxtControl.GuiFramework.Time) var;
    }  }

    public bool Get_TotOperDur(ref NxtControl.GuiFramework.Time value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,1, ref var);
      if (ret) value = (NxtControl.GuiFramework.Time) var;
      return ret;
    }

    public NxtControl.GuiFramework.Time? TotOperDur
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,1, ref var);
      if (!ret) return null;
      return (NxtControl.GuiFramework.Time) var;
    }  }


  }

  public class EPDEventArgs : System.EventArgs
  {
    IHMIAccessorService accessorService;
    int channelId;
    int cookie; 
    int eventIndex;

    public EPDEventArgs(int channelId, int cookie, int eventIndex)
    {
      this.accessorService = (IHMIAccessorService)ServiceProvider.GetService(typeof(IHMIAccessorService));
      this.channelId = channelId;
      this.cookie = cookie;
      this.eventIndex = eventIndex;
    }
    public bool Get_ElapsedDur(ref NxtControl.GuiFramework.Time value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,0, ref var);
      if (ret) value = (NxtControl.GuiFramework.Time) var;
      return ret;
    }

    public NxtControl.GuiFramework.Time? ElapsedDur
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,0, ref var);
      if (!ret) return null;
      return (NxtControl.GuiFramework.Time) var;
    }  }


  }

  public class SP_PVEventArgs : System.EventArgs
  {
    IHMIAccessorService accessorService;
    int channelId;
    int cookie; 
    int eventIndex;

    public SP_PVEventArgs(int channelId, int cookie, int eventIndex)
    {
      this.accessorService = (IHMIAccessorService)ServiceProvider.GetService(typeof(IHMIAccessorService));
      this.channelId = channelId;
      this.cookie = cookie;
      this.eventIndex = eventIndex;
    }
    public bool Get_Sp(ref NxtControl.GuiFramework.Time value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,0, ref var);
      if (ret) value = (NxtControl.GuiFramework.Time) var;
      return ret;
    }

    public NxtControl.GuiFramework.Time? Sp
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,0, ref var);
      if (!ret) return null;
      return (NxtControl.GuiFramework.Time) var;
    }  }

    public bool Get_Pv(ref NxtControl.GuiFramework.Time value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,1, ref var);
      if (ret) value = (NxtControl.GuiFramework.Time) var;
      return ret;
    }

    public NxtControl.GuiFramework.Time? Pv
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,1, ref var);
      if (!ret) return null;
      return (NxtControl.GuiFramework.Time) var;
    }  }

    public bool Get_DownCount(ref NxtControl.GuiFramework.Time value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,2, ref var);
      if (ret) value = (NxtControl.GuiFramework.Time) var;
      return ret;
    }

    public NxtControl.GuiFramework.Time? DownCount
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,2, ref var);
      if (!ret) return null;
      return (NxtControl.GuiFramework.Time) var;
    }  }


  }

}

namespace SE.Nereda.Symbols.COUNTER
{
  partial class sCurrOperDur
  {

    private event EventHandler<SE.Nereda.Symbols.COUNTER.OPDEventArgs> OPD_Fired;

    private event EventHandler<SE.Nereda.Symbols.COUNTER.EPDEventArgs> EPD_Fired;

    private event EventHandler<SE.Nereda.Symbols.COUNTER.SP_PVEventArgs> SP_PV_Fired;

    protected override void OnEndInit()
    {
      if (OPD_Fired != null)
        AttachEventInput(0);
      if (EPD_Fired != null)
        AttachEventInput(1);
      if (SP_PV_Fired != null)
        AttachEventInput(2);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (OPD_Fired != null)
          {
            try
            {
              OPD_Fired(this, new SE.Nereda.Symbols.COUNTER.OPDEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","OPD_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 1:
          if (EPD_Fired != null)
          {
            try
            {
              EPD_Fired(this, new SE.Nereda.Symbols.COUNTER.EPDEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","EPD_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 2:
          if (SP_PV_Fired != null)
          {
            try
            {
              SP_PV_Fired(this, new SE.Nereda.Symbols.COUNTER.SP_PVEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","SP_PV_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }

  }
}

namespace SE.Nereda.Symbols.COUNTER
{
  partial class sTotOperDur
  {

    private event EventHandler<SE.Nereda.Symbols.COUNTER.OPDEventArgs> OPD_Fired;

    private event EventHandler<SE.Nereda.Symbols.COUNTER.EPDEventArgs> EPD_Fired;

    private event EventHandler<SE.Nereda.Symbols.COUNTER.SP_PVEventArgs> SP_PV_Fired;

    protected override void OnEndInit()
    {
      if (OPD_Fired != null)
        AttachEventInput(0);
      if (EPD_Fired != null)
        AttachEventInput(1);
      if (SP_PV_Fired != null)
        AttachEventInput(2);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (OPD_Fired != null)
          {
            try
            {
              OPD_Fired(this, new SE.Nereda.Symbols.COUNTER.OPDEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","OPD_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 1:
          if (EPD_Fired != null)
          {
            try
            {
              EPD_Fired(this, new SE.Nereda.Symbols.COUNTER.EPDEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","EPD_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 2:
          if (SP_PV_Fired != null)
          {
            try
            {
              SP_PV_Fired(this, new SE.Nereda.Symbols.COUNTER.SP_PVEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","SP_PV_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }

  }
}

namespace SE.Nereda.Symbols.COUNTER
{
  partial class ElapsedDur
  {

    private event EventHandler<SE.Nereda.Symbols.COUNTER.OPDEventArgs> OPD_Fired;

    private event EventHandler<SE.Nereda.Symbols.COUNTER.EPDEventArgs> EPD_Fired;

    private event EventHandler<SE.Nereda.Symbols.COUNTER.SP_PVEventArgs> SP_PV_Fired;

    protected override void OnEndInit()
    {
      if (OPD_Fired != null)
        AttachEventInput(0);
      if (EPD_Fired != null)
        AttachEventInput(1);
      if (SP_PV_Fired != null)
        AttachEventInput(2);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (OPD_Fired != null)
          {
            try
            {
              OPD_Fired(this, new SE.Nereda.Symbols.COUNTER.OPDEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","OPD_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 1:
          if (EPD_Fired != null)
          {
            try
            {
              EPD_Fired(this, new SE.Nereda.Symbols.COUNTER.EPDEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","EPD_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 2:
          if (SP_PV_Fired != null)
          {
            try
            {
              SP_PV_Fired(this, new SE.Nereda.Symbols.COUNTER.SP_PVEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","SP_PV_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }

  }
}

namespace SE.Nereda.Symbols.COUNTER
{
  partial class sDefault
  {

    private event EventHandler<SE.Nereda.Symbols.COUNTER.OPDEventArgs> OPD_Fired;

    private event EventHandler<SE.Nereda.Symbols.COUNTER.EPDEventArgs> EPD_Fired;

    private event EventHandler<SE.Nereda.Symbols.COUNTER.SP_PVEventArgs> SP_PV_Fired;

    protected override void OnEndInit()
    {
      if (OPD_Fired != null)
        AttachEventInput(0);
      if (EPD_Fired != null)
        AttachEventInput(1);
      if (SP_PV_Fired != null)
        AttachEventInput(2);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (OPD_Fired != null)
          {
            try
            {
              OPD_Fired(this, new SE.Nereda.Symbols.COUNTER.OPDEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","OPD_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 1:
          if (EPD_Fired != null)
          {
            try
            {
              EPD_Fired(this, new SE.Nereda.Symbols.COUNTER.EPDEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","EPD_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 2:
          if (SP_PV_Fired != null)
          {
            try
            {
              SP_PV_Fired(this, new SE.Nereda.Symbols.COUNTER.SP_PVEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","SP_PV_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }

  }
}

namespace SE.Nereda.Symbols.COUNTER
{
  partial class sDownCount
  {

    private event EventHandler<SE.Nereda.Symbols.COUNTER.OPDEventArgs> OPD_Fired;

    private event EventHandler<SE.Nereda.Symbols.COUNTER.EPDEventArgs> EPD_Fired;

    private event EventHandler<SE.Nereda.Symbols.COUNTER.SP_PVEventArgs> SP_PV_Fired;

    protected override void OnEndInit()
    {
      if (OPD_Fired != null)
        AttachEventInput(0);
      if (EPD_Fired != null)
        AttachEventInput(1);
      if (SP_PV_Fired != null)
        AttachEventInput(2);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (OPD_Fired != null)
          {
            try
            {
              OPD_Fired(this, new SE.Nereda.Symbols.COUNTER.OPDEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","OPD_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 1:
          if (EPD_Fired != null)
          {
            try
            {
              EPD_Fired(this, new SE.Nereda.Symbols.COUNTER.EPDEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","EPD_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 2:
          if (SP_PV_Fired != null)
          {
            try
            {
              SP_PV_Fired(this, new SE.Nereda.Symbols.COUNTER.SP_PVEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","SP_PV_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }

  }
}
#endregion #COUNTER_HMI;

#endregion Definitions;
