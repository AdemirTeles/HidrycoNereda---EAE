/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 7/9/2026
 * Time: 10:25 AM
 * 
 */
using System;
using NxtControl.GuiFramework;
using NxtControl.Services;

#region Definitions;
#region #NeredaMetalSaltDosing_HMI;

namespace SE.Nereda.Symbols.NeredaMetalSaltDosing
{

  public class STATEEventArgs : System.EventArgs
  {
    IHMIAccessorService accessorService;
    int channelId;
    int cookie; 
    int eventIndex;

    public STATEEventArgs(int channelId, int cookie, int eventIndex)
    {
      this.accessorService = (IHMIAccessorService)ServiceProvider.GetService(typeof(IHMIAccessorService));
      this.channelId = channelId;
      this.cookie = cookie;
      this.eventIndex = eventIndex;
    }
    public bool Get_State(ref System.String value)
    {
      if (accessorService == null)
        return false;
      string var = null;
      bool ret = accessorService.GetStringValue(channelId, cookie, eventIndex, true,0, ref var);
      if (ret) value = (System.String) var;
      return ret;
    }

    public System.String State
    { get {
      if (accessorService == null)
        return null;
      string var = null;
      bool ret = accessorService.GetStringValue(channelId, cookie, eventIndex, true,0, ref var);
      if (!ret) return null;
      return (System.String) var;
    }  }


  }

  public class LEVEL_PVEventArgs : System.EventArgs
  {
    IHMIAccessorService accessorService;
    int channelId;
    int cookie; 
    int eventIndex;

    public LEVEL_PVEventArgs(int channelId, int cookie, int eventIndex)
    {
      this.accessorService = (IHMIAccessorService)ServiceProvider.GetService(typeof(IHMIAccessorService));
      this.channelId = channelId;
      this.cookie = cookie;
      this.eventIndex = eventIndex;
    }
    public bool Get_Pv(ref System.Single value)
    {
      if (accessorService == null)
        return false;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,0, ref var);
      if (ret) value = (System.Single) var;
      return ret;
    }

    public System.Single? Pv
    { get {
      if (accessorService == null)
        return null;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,0, ref var);
      if (!ret) return null;
      return (System.Single) var;
    }  }

    public bool Get_PvMax(ref System.Single value)
    {
      if (accessorService == null)
        return false;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,1, ref var);
      if (ret) value = (System.Single) var;
      return ret;
    }

    public System.Single? PvMax
    { get {
      if (accessorService == null)
        return null;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,1, ref var);
      if (!ret) return null;
      return (System.Single) var;
    }  }

    public bool Get_PvMin(ref System.Single value)
    {
      if (accessorService == null)
        return false;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,2, ref var);
      if (ret) value = (System.Single) var;
      return ret;
    }

    public System.Single? PvMin
    { get {
      if (accessorService == null)
        return null;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,2, ref var);
      if (!ret) return null;
      return (System.Single) var;
    }  }


  }

}

namespace SE.Nereda.Symbols.NeredaMetalSaltDosing
{
  partial class sDefault
  {

    private event EventHandler<SE.Nereda.Symbols.NeredaMetalSaltDosing.STATEEventArgs> STATE_Fired;

    private event EventHandler<SE.Nereda.Symbols.NeredaMetalSaltDosing.LEVEL_PVEventArgs> LEVEL_PV_Fired;

    protected override void OnEndInit()
    {
      if (STATE_Fired != null)
        AttachEventInput(0);
      if (LEVEL_PV_Fired != null)
        AttachEventInput(1);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (STATE_Fired != null)
          {
            try
            {
              STATE_Fired(this, new SE.Nereda.Symbols.NeredaMetalSaltDosing.STATEEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","STATE_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 1:
          if (LEVEL_PV_Fired != null)
          {
            try
            {
              LEVEL_PV_Fired(this, new SE.Nereda.Symbols.NeredaMetalSaltDosing.LEVEL_PVEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","LEVEL_PV_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }

  }
}

namespace SE.Nereda.Symbols.NeredaMetalSaltDosing
{
  partial class sSensors
  {

    private event EventHandler<SE.Nereda.Symbols.NeredaMetalSaltDosing.STATEEventArgs> STATE_Fired;

    private event EventHandler<SE.Nereda.Symbols.NeredaMetalSaltDosing.LEVEL_PVEventArgs> LEVEL_PV_Fired;

    protected override void OnEndInit()
    {
      if (STATE_Fired != null)
        AttachEventInput(0);
      if (LEVEL_PV_Fired != null)
        AttachEventInput(1);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (STATE_Fired != null)
          {
            try
            {
              STATE_Fired(this, new SE.Nereda.Symbols.NeredaMetalSaltDosing.STATEEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","STATE_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 1:
          if (LEVEL_PV_Fired != null)
          {
            try
            {
              LEVEL_PV_Fired(this, new SE.Nereda.Symbols.NeredaMetalSaltDosing.LEVEL_PVEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","LEVEL_PV_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }

  }
}
#endregion #NeredaMetalSaltDosing_HMI;

#endregion Definitions;
