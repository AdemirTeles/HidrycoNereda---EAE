/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 7/15/2026
 * Time: 3:21 PM
 * 
 */
using System;
using NxtControl.GuiFramework;
using NxtControl.Services;

#region Definitions;
#region #NextFeedHorizon_HMI;

namespace SE.Nereda.Symbols.NextFeedHorizon
{

  public class N_F_HEventArgs : System.EventArgs
  {
    IHMIAccessorService accessorService;
    int channelId;
    int cookie; 
    int eventIndex;

    public N_F_HEventArgs(int channelId, int cookie, int eventIndex)
    {
      this.accessorService = (IHMIAccessorService)ServiceProvider.GetService(typeof(IHMIAccessorService));
      this.channelId = channelId;
      this.cookie = cookie;
      this.eventIndex = eventIndex;
    }
    public bool Get_NextFeedHorizonR1(ref NxtControl.GuiFramework.Time value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,0, ref var);
      if (ret) value = (NxtControl.GuiFramework.Time) var;
      return ret;
    }

    public NxtControl.GuiFramework.Time? NextFeedHorizonR1
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,0, ref var);
      if (!ret) return null;
      return (NxtControl.GuiFramework.Time) var;
    }  }

    public bool Get_NextFeedHorizonR2(ref NxtControl.GuiFramework.Time value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,1, ref var);
      if (ret) value = (NxtControl.GuiFramework.Time) var;
      return ret;
    }

    public NxtControl.GuiFramework.Time? NextFeedHorizonR2
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,1, ref var);
      if (!ret) return null;
      return (NxtControl.GuiFramework.Time) var;
    }  }

    public bool Get_NextFeedHorizonR3(ref NxtControl.GuiFramework.Time value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,2, ref var);
      if (ret) value = (NxtControl.GuiFramework.Time) var;
      return ret;
    }

    public NxtControl.GuiFramework.Time? NextFeedHorizonR3
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,2, ref var);
      if (!ret) return null;
      return (NxtControl.GuiFramework.Time) var;
    }  }

    public bool Get_NextFeedHorizonR4(ref NxtControl.GuiFramework.Time value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,3, ref var);
      if (ret) value = (NxtControl.GuiFramework.Time) var;
      return ret;
    }

    public NxtControl.GuiFramework.Time? NextFeedHorizonR4
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,3, ref var);
      if (!ret) return null;
      return (NxtControl.GuiFramework.Time) var;
    }  }

    public bool Get_NextFeedHorizonR5(ref NxtControl.GuiFramework.Time value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,4, ref var);
      if (ret) value = (NxtControl.GuiFramework.Time) var;
      return ret;
    }

    public NxtControl.GuiFramework.Time? NextFeedHorizonR5
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,4, ref var);
      if (!ret) return null;
      return (NxtControl.GuiFramework.Time) var;
    }  }

    public bool Get_NextFeedHorizonR6(ref NxtControl.GuiFramework.Time value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,5, ref var);
      if (ret) value = (NxtControl.GuiFramework.Time) var;
      return ret;
    }

    public NxtControl.GuiFramework.Time? NextFeedHorizonR6
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,5, ref var);
      if (!ret) return null;
      return (NxtControl.GuiFramework.Time) var;
    }  }


  }

}

namespace SE.Nereda.Symbols.NextFeedHorizon
{
  partial class sDefault
  {

    private event EventHandler<SE.Nereda.Symbols.NextFeedHorizon.N_F_HEventArgs> N_F_H_Fired;

    protected override void OnEndInit()
    {
      if (N_F_H_Fired != null)
        AttachEventInput(0);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (N_F_H_Fired != null)
          {
            try
            {
              N_F_H_Fired(this, new SE.Nereda.Symbols.NextFeedHorizon.N_F_HEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","N_F_H_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }

  }
}

namespace SE.Nereda.Symbols.NextFeedHorizon
{
  partial class sNFHR1
  {

    private event EventHandler<SE.Nereda.Symbols.NextFeedHorizon.N_F_HEventArgs> N_F_H_Fired;

    protected override void OnEndInit()
    {
      if (N_F_H_Fired != null)
        AttachEventInput(0);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (N_F_H_Fired != null)
          {
            try
            {
              N_F_H_Fired(this, new SE.Nereda.Symbols.NextFeedHorizon.N_F_HEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","N_F_H_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }

  }
}

namespace SE.Nereda.Symbols.NextFeedHorizon
{
  partial class sNFHR3
  {

    private event EventHandler<SE.Nereda.Symbols.NextFeedHorizon.N_F_HEventArgs> N_F_H_Fired;

    protected override void OnEndInit()
    {
      if (N_F_H_Fired != null)
        AttachEventInput(0);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (N_F_H_Fired != null)
          {
            try
            {
              N_F_H_Fired(this, new SE.Nereda.Symbols.NextFeedHorizon.N_F_HEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","N_F_H_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }

  }
}

namespace SE.Nereda.Symbols.NextFeedHorizon
{
  partial class sNFHR2
  {

    private event EventHandler<SE.Nereda.Symbols.NextFeedHorizon.N_F_HEventArgs> N_F_H_Fired;

    protected override void OnEndInit()
    {
      if (N_F_H_Fired != null)
        AttachEventInput(0);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (N_F_H_Fired != null)
          {
            try
            {
              N_F_H_Fired(this, new SE.Nereda.Symbols.NextFeedHorizon.N_F_HEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","N_F_H_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }

  }
}

namespace SE.Nereda.Symbols.NextFeedHorizon
{
  partial class sNFHR11
  {

    private event EventHandler<SE.Nereda.Symbols.NextFeedHorizon.N_F_HEventArgs> N_F_H_Fired;

    protected override void OnEndInit()
    {
      if (N_F_H_Fired != null)
        AttachEventInput(0);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (N_F_H_Fired != null)
          {
            try
            {
              N_F_H_Fired(this, new SE.Nereda.Symbols.NextFeedHorizon.N_F_HEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","N_F_H_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }

  }
}

namespace SE.Nereda.Symbols.NextFeedHorizon
{
  partial class sNFHR21
  {

    private event EventHandler<SE.Nereda.Symbols.NextFeedHorizon.N_F_HEventArgs> N_F_H_Fired;

    protected override void OnEndInit()
    {
      if (N_F_H_Fired != null)
        AttachEventInput(0);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (N_F_H_Fired != null)
          {
            try
            {
              N_F_H_Fired(this, new SE.Nereda.Symbols.NextFeedHorizon.N_F_HEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","N_F_H_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }

  }
}

namespace SE.Nereda.Symbols.NextFeedHorizon
{
  partial class sNFHR31
  {

    private event EventHandler<SE.Nereda.Symbols.NextFeedHorizon.N_F_HEventArgs> N_F_H_Fired;

    protected override void OnEndInit()
    {
      if (N_F_H_Fired != null)
        AttachEventInput(0);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (N_F_H_Fired != null)
          {
            try
            {
              N_F_H_Fired(this, new SE.Nereda.Symbols.NextFeedHorizon.N_F_HEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","N_F_H_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }

  }
}
#endregion #NextFeedHorizon_HMI;

#endregion Definitions;
