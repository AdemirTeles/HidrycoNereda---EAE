/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 7/4/2026
 * Time: 10:10 PM
 * 
 */
using System;
using NxtControl.GuiFramework;
using NxtControl.Services;

#region Definitions;
#region #EmergencyManagement_HMI;

namespace SE.Nereda.Symbols.EmergencyManagement
{

  public class REACTOR1_DATAEventArgs : System.EventArgs
  {
    IHMIAccessorService accessorService;
    int channelId;
    int cookie; 
    int eventIndex;

    public REACTOR1_DATAEventArgs(int channelId, int cookie, int eventIndex)
    {
      this.accessorService = (IHMIAccessorService)ServiceProvider.GetService(typeof(IHMIAccessorService));
      this.channelId = channelId;
      this.cookie = cookie;
      this.eventIndex = eventIndex;
    }
    public bool Get_MinutesSinceLastFeedR1(ref NxtControl.GuiFramework.Time value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,0, ref var);
      if (ret) value = (NxtControl.GuiFramework.Time) var;
      return ret;
    }

    public NxtControl.GuiFramework.Time? MinutesSinceLastFeedR1
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,0, ref var);
      if (!ret) return null;
      return (NxtControl.GuiFramework.Time) var;
    }  }

    public bool Get_AerateTimeR1(ref NxtControl.GuiFramework.Time value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,1, ref var);
      if (ret) value = (NxtControl.GuiFramework.Time) var;
      return ret;
    }

    public NxtControl.GuiFramework.Time? AerateTimeR1
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,1, ref var);
      if (!ret) return null;
      return (NxtControl.GuiFramework.Time) var;
    }  }

    public bool Get_StartFeedPositionR1(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,2, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? StartFeedPositionR1
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,2, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }

    public bool Get_CurrAerateTimeR1(ref NxtControl.GuiFramework.Time value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,3, ref var);
      if (ret) value = (NxtControl.GuiFramework.Time) var;
      return ret;
    }

    public NxtControl.GuiFramework.Time? CurrAerateTimeR1
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,3, ref var);
      if (!ret) return null;
      return (NxtControl.GuiFramework.Time) var;
    }  }


  }

  public class REACTOR2_DATAEventArgs : System.EventArgs
  {
    IHMIAccessorService accessorService;
    int channelId;
    int cookie; 
    int eventIndex;

    public REACTOR2_DATAEventArgs(int channelId, int cookie, int eventIndex)
    {
      this.accessorService = (IHMIAccessorService)ServiceProvider.GetService(typeof(IHMIAccessorService));
      this.channelId = channelId;
      this.cookie = cookie;
      this.eventIndex = eventIndex;
    }
    public bool Get_MinutesSinceLastFeedR2(ref NxtControl.GuiFramework.Time value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,0, ref var);
      if (ret) value = (NxtControl.GuiFramework.Time) var;
      return ret;
    }

    public NxtControl.GuiFramework.Time? MinutesSinceLastFeedR2
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,0, ref var);
      if (!ret) return null;
      return (NxtControl.GuiFramework.Time) var;
    }  }

    public bool Get_AerateTimeR2(ref NxtControl.GuiFramework.Time value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,1, ref var);
      if (ret) value = (NxtControl.GuiFramework.Time) var;
      return ret;
    }

    public NxtControl.GuiFramework.Time? AerateTimeR2
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,1, ref var);
      if (!ret) return null;
      return (NxtControl.GuiFramework.Time) var;
    }  }

    public bool Get_StartFeedPositionR2(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,2, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? StartFeedPositionR2
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,2, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }

    public bool Get_CurrAerateTimeR2(ref NxtControl.GuiFramework.Time value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,3, ref var);
      if (ret) value = (NxtControl.GuiFramework.Time) var;
      return ret;
    }

    public NxtControl.GuiFramework.Time? CurrAerateTimeR2
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,3, ref var);
      if (!ret) return null;
      return (NxtControl.GuiFramework.Time) var;
    }  }


  }

  public class REACTOR3_DATAEventArgs : System.EventArgs
  {
    IHMIAccessorService accessorService;
    int channelId;
    int cookie; 
    int eventIndex;

    public REACTOR3_DATAEventArgs(int channelId, int cookie, int eventIndex)
    {
      this.accessorService = (IHMIAccessorService)ServiceProvider.GetService(typeof(IHMIAccessorService));
      this.channelId = channelId;
      this.cookie = cookie;
      this.eventIndex = eventIndex;
    }
    public bool Get_MinutesSinceLastFeedR3(ref NxtControl.GuiFramework.Time value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,0, ref var);
      if (ret) value = (NxtControl.GuiFramework.Time) var;
      return ret;
    }

    public NxtControl.GuiFramework.Time? MinutesSinceLastFeedR3
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,0, ref var);
      if (!ret) return null;
      return (NxtControl.GuiFramework.Time) var;
    }  }

    public bool Get_AerateTimeR3(ref NxtControl.GuiFramework.Time value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,1, ref var);
      if (ret) value = (NxtControl.GuiFramework.Time) var;
      return ret;
    }

    public NxtControl.GuiFramework.Time? AerateTimeR3
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,1, ref var);
      if (!ret) return null;
      return (NxtControl.GuiFramework.Time) var;
    }  }

    public bool Get_StartFeedPositionR3(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,2, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? StartFeedPositionR3
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,2, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }

    public bool Get_CurrAerateTimeR3(ref NxtControl.GuiFramework.Time value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,3, ref var);
      if (ret) value = (NxtControl.GuiFramework.Time) var;
      return ret;
    }

    public NxtControl.GuiFramework.Time? CurrAerateTimeR3
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,3, ref var);
      if (!ret) return null;
      return (NxtControl.GuiFramework.Time) var;
    }  }


  }

  public class REACTOR4_DATAEventArgs : System.EventArgs
  {
    IHMIAccessorService accessorService;
    int channelId;
    int cookie; 
    int eventIndex;

    public REACTOR4_DATAEventArgs(int channelId, int cookie, int eventIndex)
    {
      this.accessorService = (IHMIAccessorService)ServiceProvider.GetService(typeof(IHMIAccessorService));
      this.channelId = channelId;
      this.cookie = cookie;
      this.eventIndex = eventIndex;
    }
    public bool Get_MinutesSinceLastFeedR4(ref NxtControl.GuiFramework.Time value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,0, ref var);
      if (ret) value = (NxtControl.GuiFramework.Time) var;
      return ret;
    }

    public NxtControl.GuiFramework.Time? MinutesSinceLastFeedR4
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,0, ref var);
      if (!ret) return null;
      return (NxtControl.GuiFramework.Time) var;
    }  }

    public bool Get_AerateTimeR4(ref NxtControl.GuiFramework.Time value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,1, ref var);
      if (ret) value = (NxtControl.GuiFramework.Time) var;
      return ret;
    }

    public NxtControl.GuiFramework.Time? AerateTimeR4
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,1, ref var);
      if (!ret) return null;
      return (NxtControl.GuiFramework.Time) var;
    }  }

    public bool Get_StartFeedPositionR4(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,2, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? StartFeedPositionR4
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,2, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }

    public bool Get_CurrAerateTimeR4(ref NxtControl.GuiFramework.Time value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,3, ref var);
      if (ret) value = (NxtControl.GuiFramework.Time) var;
      return ret;
    }

    public NxtControl.GuiFramework.Time? CurrAerateTimeR4
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,3, ref var);
      if (!ret) return null;
      return (NxtControl.GuiFramework.Time) var;
    }  }


  }

  public class REACTOR5_DATAEventArgs : System.EventArgs
  {
    IHMIAccessorService accessorService;
    int channelId;
    int cookie; 
    int eventIndex;

    public REACTOR5_DATAEventArgs(int channelId, int cookie, int eventIndex)
    {
      this.accessorService = (IHMIAccessorService)ServiceProvider.GetService(typeof(IHMIAccessorService));
      this.channelId = channelId;
      this.cookie = cookie;
      this.eventIndex = eventIndex;
    }
    public bool Get_MinutesSinceLastFeedR5(ref NxtControl.GuiFramework.Time value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,0, ref var);
      if (ret) value = (NxtControl.GuiFramework.Time) var;
      return ret;
    }

    public NxtControl.GuiFramework.Time? MinutesSinceLastFeedR5
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,0, ref var);
      if (!ret) return null;
      return (NxtControl.GuiFramework.Time) var;
    }  }

    public bool Get_AerateTimeR5(ref NxtControl.GuiFramework.Time value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,1, ref var);
      if (ret) value = (NxtControl.GuiFramework.Time) var;
      return ret;
    }

    public NxtControl.GuiFramework.Time? AerateTimeR5
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,1, ref var);
      if (!ret) return null;
      return (NxtControl.GuiFramework.Time) var;
    }  }

    public bool Get_StartFeedPositionR5(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,2, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? StartFeedPositionR5
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,2, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }

    public bool Get_CurrAerateTimeR5(ref NxtControl.GuiFramework.Time value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,3, ref var);
      if (ret) value = (NxtControl.GuiFramework.Time) var;
      return ret;
    }

    public NxtControl.GuiFramework.Time? CurrAerateTimeR5
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,3, ref var);
      if (!ret) return null;
      return (NxtControl.GuiFramework.Time) var;
    }  }


  }

  public class REACTOR6_DATAEventArgs : System.EventArgs
  {
    IHMIAccessorService accessorService;
    int channelId;
    int cookie; 
    int eventIndex;

    public REACTOR6_DATAEventArgs(int channelId, int cookie, int eventIndex)
    {
      this.accessorService = (IHMIAccessorService)ServiceProvider.GetService(typeof(IHMIAccessorService));
      this.channelId = channelId;
      this.cookie = cookie;
      this.eventIndex = eventIndex;
    }
    public bool Get_MinutesSinceLastFeedR6(ref NxtControl.GuiFramework.Time value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,0, ref var);
      if (ret) value = (NxtControl.GuiFramework.Time) var;
      return ret;
    }

    public NxtControl.GuiFramework.Time? MinutesSinceLastFeedR6
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,0, ref var);
      if (!ret) return null;
      return (NxtControl.GuiFramework.Time) var;
    }  }

    public bool Get_AerateTimeR6(ref NxtControl.GuiFramework.Time value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,1, ref var);
      if (ret) value = (NxtControl.GuiFramework.Time) var;
      return ret;
    }

    public NxtControl.GuiFramework.Time? AerateTimeR6
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,1, ref var);
      if (!ret) return null;
      return (NxtControl.GuiFramework.Time) var;
    }  }

    public bool Get_StartFeedPositionR6(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,2, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? StartFeedPositionR6
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,2, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }

    public bool Get_CurrAerateTimeR6(ref NxtControl.GuiFramework.Time value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,3, ref var);
      if (ret) value = (NxtControl.GuiFramework.Time) var;
      return ret;
    }

    public NxtControl.GuiFramework.Time? CurrAerateTimeR6
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,3, ref var);
      if (!ret) return null;
      return (NxtControl.GuiFramework.Time) var;
    }  }


  }

  public class CT_REACTOR_ACTUALEventArgs : System.EventArgs
  {
    IHMIAccessorService accessorService;
    int channelId;
    int cookie; 
    int eventIndex;

    public CT_REACTOR_ACTUALEventArgs(int channelId, int cookie, int eventIndex)
    {
      this.accessorService = (IHMIAccessorService)ServiceProvider.GetService(typeof(IHMIAccessorService));
      this.channelId = channelId;
      this.cookie = cookie;
      this.eventIndex = eventIndex;
    }
    public bool Get_CT_ReactorActual(ref NxtControl.GuiFramework.Time value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,0, ref var);
      if (ret) value = (NxtControl.GuiFramework.Time) var;
      return ret;
    }

    public NxtControl.GuiFramework.Time? CT_ReactorActual
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,0, ref var);
      if (!ret) return null;
      return (NxtControl.GuiFramework.Time) var;
    }  }


  }

  public class NBR_TOT_AV_REACTOREventArgs : System.EventArgs
  {
    IHMIAccessorService accessorService;
    int channelId;
    int cookie; 
    int eventIndex;

    public NBR_TOT_AV_REACTOREventArgs(int channelId, int cookie, int eventIndex)
    {
      this.accessorService = (IHMIAccessorService)ServiceProvider.GetService(typeof(IHMIAccessorService));
      this.channelId = channelId;
      this.cookie = cookie;
      this.eventIndex = eventIndex;
    }
    public bool Get_NbrTotalReactors(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,0, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? NbrTotalReactors
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,0, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }

    public bool Get_NbrAvailableReactors(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,1, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? NbrAvailableReactors
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,1, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }

    public bool Get_iCT_Nominal(ref NxtControl.GuiFramework.Time value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,2, ref var);
      if (ret) value = (NxtControl.GuiFramework.Time) var;
      return ret;
    }

    public NxtControl.GuiFramework.Time? iCT_Nominal
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,2, ref var);
      if (!ret) return null;
      return (NxtControl.GuiFramework.Time) var;
    }  }


  }

  public class FEED_INTERVALEventArgs : System.EventArgs
  {
    IHMIAccessorService accessorService;
    int channelId;
    int cookie; 
    int eventIndex;

    public FEED_INTERVALEventArgs(int channelId, int cookie, int eventIndex)
    {
      this.accessorService = (IHMIAccessorService)ServiceProvider.GetService(typeof(IHMIAccessorService));
      this.channelId = channelId;
      this.cookie = cookie;
      this.eventIndex = eventIndex;
    }
    public bool Get_FeedInterval(ref NxtControl.GuiFramework.Time value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,0, ref var);
      if (ret) value = (NxtControl.GuiFramework.Time) var;
      return ret;
    }

    public NxtControl.GuiFramework.Time? FeedInterval
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,0, ref var);
      if (!ret) return null;
      return (NxtControl.GuiFramework.Time) var;
    }  }


  }

  public class GRAPHEventArgs : System.EventArgs
  {
    IHMIAccessorService accessorService;
    int channelId;
    int cookie; 
    int eventIndex;

    public GRAPHEventArgs(int channelId, int cookie, int eventIndex)
    {
      this.accessorService = (IHMIAccessorService)ServiceProvider.GetService(typeof(IHMIAccessorService));
      this.channelId = channelId;
      this.cookie = cookie;
      this.eventIndex = eventIndex;
    }
    public bool Get_Grafcet(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,0, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? Grafcet
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,0, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }


  }

  public class EMER_ONEventArgs : System.EventArgs
  {
    IHMIAccessorService accessorService;
    int channelId;
    int cookie; 
    int eventIndex;

    public EMER_ONEventArgs(int channelId, int cookie, int eventIndex)
    {
      this.accessorService = (IHMIAccessorService)ServiceProvider.GetService(typeof(IHMIAccessorService));
      this.channelId = channelId;
      this.cookie = cookie;
      this.eventIndex = eventIndex;
    }
    public bool Get_EmergencyON(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,0, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? EmergencyON
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,0, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }


  }

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

namespace SE.Nereda.Symbols.EmergencyManagement
{

  public class CT_NOMINALEventArgs : System.EventArgs
  {
    public CT_NOMINALEventArgs()
    {
    }
    private NxtControl.GuiFramework.Time? CT_Nominal_field = null;
    public NxtControl.GuiFramework.Time? CT_Nominal
    {
       get { return CT_Nominal_field; }
       set { CT_Nominal_field = value; }
    }

  }

  public class START_UP_DELAYEventArgs : System.EventArgs
  {
    public START_UP_DELAYEventArgs()
    {
    }
    private NxtControl.GuiFramework.Time? StartUpDelay_field = null;
    public NxtControl.GuiFramework.Time? StartUpDelay
    {
       get { return StartUpDelay_field; }
       set { StartUpDelay_field = value; }
    }

  }

}

namespace SE.Nereda.Symbols.EmergencyManagement
{
  partial class sDefault
  {

    private event EventHandler<SE.Nereda.Symbols.EmergencyManagement.REACTOR1_DATAEventArgs> REACTOR1_DATA_Fired;

    private event EventHandler<SE.Nereda.Symbols.EmergencyManagement.REACTOR2_DATAEventArgs> REACTOR2_DATA_Fired;

    private event EventHandler<SE.Nereda.Symbols.EmergencyManagement.REACTOR3_DATAEventArgs> REACTOR3_DATA_Fired;

    private event EventHandler<SE.Nereda.Symbols.EmergencyManagement.REACTOR4_DATAEventArgs> REACTOR4_DATA_Fired;

    private event EventHandler<SE.Nereda.Symbols.EmergencyManagement.REACTOR5_DATAEventArgs> REACTOR5_DATA_Fired;

    private event EventHandler<SE.Nereda.Symbols.EmergencyManagement.REACTOR6_DATAEventArgs> REACTOR6_DATA_Fired;

    private event EventHandler<SE.Nereda.Symbols.EmergencyManagement.CT_REACTOR_ACTUALEventArgs> CT_REACTOR_ACTUAL_Fired;

    private event EventHandler<SE.Nereda.Symbols.EmergencyManagement.NBR_TOT_AV_REACTOREventArgs> NBR_TOT_AV_REACTOR_Fired;

    private event EventHandler<SE.Nereda.Symbols.EmergencyManagement.FEED_INTERVALEventArgs> FEED_INTERVAL_Fired;

    private event EventHandler<SE.Nereda.Symbols.EmergencyManagement.GRAPHEventArgs> GRAPH_Fired;

    private event EventHandler<SE.Nereda.Symbols.EmergencyManagement.EMER_ONEventArgs> EMER_ON_Fired;

    private event EventHandler<SE.Nereda.Symbols.EmergencyManagement.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    protected override void OnEndInit()
    {
      if (REACTOR1_DATA_Fired != null)
        AttachEventInput(0);
      if (REACTOR2_DATA_Fired != null)
        AttachEventInput(1);
      if (REACTOR3_DATA_Fired != null)
        AttachEventInput(2);
      if (REACTOR4_DATA_Fired != null)
        AttachEventInput(3);
      if (REACTOR5_DATA_Fired != null)
        AttachEventInput(4);
      if (REACTOR6_DATA_Fired != null)
        AttachEventInput(5);
      if (CT_REACTOR_ACTUAL_Fired != null)
        AttachEventInput(6);
      if (NBR_TOT_AV_REACTOR_Fired != null)
        AttachEventInput(7);
      if (FEED_INTERVAL_Fired != null)
        AttachEventInput(8);
      if (GRAPH_Fired != null)
        AttachEventInput(9);
      if (EMER_ON_Fired != null)
        AttachEventInput(10);
      if (LOAD_PERS_DATA_Fired != null)
        AttachEventInput(11);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (REACTOR1_DATA_Fired != null)
          {
            try
            {
              REACTOR1_DATA_Fired(this, new SE.Nereda.Symbols.EmergencyManagement.REACTOR1_DATAEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REACTOR1_DATA_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 1:
          if (REACTOR2_DATA_Fired != null)
          {
            try
            {
              REACTOR2_DATA_Fired(this, new SE.Nereda.Symbols.EmergencyManagement.REACTOR2_DATAEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REACTOR2_DATA_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 2:
          if (REACTOR3_DATA_Fired != null)
          {
            try
            {
              REACTOR3_DATA_Fired(this, new SE.Nereda.Symbols.EmergencyManagement.REACTOR3_DATAEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REACTOR3_DATA_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 3:
          if (REACTOR4_DATA_Fired != null)
          {
            try
            {
              REACTOR4_DATA_Fired(this, new SE.Nereda.Symbols.EmergencyManagement.REACTOR4_DATAEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REACTOR4_DATA_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 4:
          if (REACTOR5_DATA_Fired != null)
          {
            try
            {
              REACTOR5_DATA_Fired(this, new SE.Nereda.Symbols.EmergencyManagement.REACTOR5_DATAEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REACTOR5_DATA_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 5:
          if (REACTOR6_DATA_Fired != null)
          {
            try
            {
              REACTOR6_DATA_Fired(this, new SE.Nereda.Symbols.EmergencyManagement.REACTOR6_DATAEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REACTOR6_DATA_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 6:
          if (CT_REACTOR_ACTUAL_Fired != null)
          {
            try
            {
              CT_REACTOR_ACTUAL_Fired(this, new SE.Nereda.Symbols.EmergencyManagement.CT_REACTOR_ACTUALEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","CT_REACTOR_ACTUAL_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 7:
          if (NBR_TOT_AV_REACTOR_Fired != null)
          {
            try
            {
              NBR_TOT_AV_REACTOR_Fired(this, new SE.Nereda.Symbols.EmergencyManagement.NBR_TOT_AV_REACTOREventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","NBR_TOT_AV_REACTOR_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 8:
          if (FEED_INTERVAL_Fired != null)
          {
            try
            {
              FEED_INTERVAL_Fired(this, new SE.Nereda.Symbols.EmergencyManagement.FEED_INTERVALEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","FEED_INTERVAL_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 9:
          if (GRAPH_Fired != null)
          {
            try
            {
              GRAPH_Fired(this, new SE.Nereda.Symbols.EmergencyManagement.GRAPHEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","GRAPH_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 10:
          if (EMER_ON_Fired != null)
          {
            try
            {
              EMER_ON_Fired(this, new SE.Nereda.Symbols.EmergencyManagement.EMER_ONEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","EMER_ON_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 11:
          if (LOAD_PERS_DATA_Fired != null)
          {
            try
            {
              LOAD_PERS_DATA_Fired(this, new SE.Nereda.Symbols.EmergencyManagement.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
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
    public bool FireEvent_CT_NOMINAL(NxtControl.GuiFramework.Time CT_Nominal)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {CT_Nominal});
    }
    public bool FireEvent_CT_NOMINAL(SE.Nereda.Symbols.EmergencyManagement.CT_NOMINALEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.CT_Nominal.HasValue) _values_[0] = ea.CT_Nominal.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_CT_NOMINAL(NxtControl.GuiFramework.Time CT_Nominal, bool ignore_CT_Nominal)
    {
      object[] _values_ = new object[1];
      if (!ignore_CT_Nominal) _values_[0] = CT_Nominal;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_START_UP_DELAY(NxtControl.GuiFramework.Time StartUpDelay)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {StartUpDelay});
    }
    public bool FireEvent_START_UP_DELAY(SE.Nereda.Symbols.EmergencyManagement.START_UP_DELAYEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.StartUpDelay.HasValue) _values_[0] = ea.StartUpDelay.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_START_UP_DELAY(NxtControl.GuiFramework.Time StartUpDelay, bool ignore_StartUpDelay)
    {
      object[] _values_ = new object[1];
      if (!ignore_StartUpDelay) _values_[0] = StartUpDelay;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }

  }
}

namespace SE.Nereda.Faceplates.EmergencyManagement
{
  partial class fpSettings
  {

    private event EventHandler<SE.Nereda.Symbols.EmergencyManagement.REACTOR1_DATAEventArgs> REACTOR1_DATA_Fired;

    private event EventHandler<SE.Nereda.Symbols.EmergencyManagement.REACTOR2_DATAEventArgs> REACTOR2_DATA_Fired;

    private event EventHandler<SE.Nereda.Symbols.EmergencyManagement.REACTOR3_DATAEventArgs> REACTOR3_DATA_Fired;

    private event EventHandler<SE.Nereda.Symbols.EmergencyManagement.REACTOR4_DATAEventArgs> REACTOR4_DATA_Fired;

    private event EventHandler<SE.Nereda.Symbols.EmergencyManagement.REACTOR5_DATAEventArgs> REACTOR5_DATA_Fired;

    private event EventHandler<SE.Nereda.Symbols.EmergencyManagement.REACTOR6_DATAEventArgs> REACTOR6_DATA_Fired;

    private event EventHandler<SE.Nereda.Symbols.EmergencyManagement.CT_REACTOR_ACTUALEventArgs> CT_REACTOR_ACTUAL_Fired;

    private event EventHandler<SE.Nereda.Symbols.EmergencyManagement.NBR_TOT_AV_REACTOREventArgs> NBR_TOT_AV_REACTOR_Fired;

    private event EventHandler<SE.Nereda.Symbols.EmergencyManagement.FEED_INTERVALEventArgs> FEED_INTERVAL_Fired;

    private event EventHandler<SE.Nereda.Symbols.EmergencyManagement.GRAPHEventArgs> GRAPH_Fired;

    private event EventHandler<SE.Nereda.Symbols.EmergencyManagement.EMER_ONEventArgs> EMER_ON_Fired;

    private event EventHandler<SE.Nereda.Symbols.EmergencyManagement.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    protected override void OnEndInit()
    {
      if (REACTOR1_DATA_Fired != null)
        AttachEventInput(0);
      if (REACTOR2_DATA_Fired != null)
        AttachEventInput(1);
      if (REACTOR3_DATA_Fired != null)
        AttachEventInput(2);
      if (REACTOR4_DATA_Fired != null)
        AttachEventInput(3);
      if (REACTOR5_DATA_Fired != null)
        AttachEventInput(4);
      if (REACTOR6_DATA_Fired != null)
        AttachEventInput(5);
      if (CT_REACTOR_ACTUAL_Fired != null)
        AttachEventInput(6);
      if (NBR_TOT_AV_REACTOR_Fired != null)
        AttachEventInput(7);
      if (FEED_INTERVAL_Fired != null)
        AttachEventInput(8);
      if (GRAPH_Fired != null)
        AttachEventInput(9);
      if (EMER_ON_Fired != null)
        AttachEventInput(10);
      if (LOAD_PERS_DATA_Fired != null)
        AttachEventInput(11);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (REACTOR1_DATA_Fired != null)
          {
            try
            {
              REACTOR1_DATA_Fired(this, new SE.Nereda.Symbols.EmergencyManagement.REACTOR1_DATAEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REACTOR1_DATA_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 1:
          if (REACTOR2_DATA_Fired != null)
          {
            try
            {
              REACTOR2_DATA_Fired(this, new SE.Nereda.Symbols.EmergencyManagement.REACTOR2_DATAEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REACTOR2_DATA_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 2:
          if (REACTOR3_DATA_Fired != null)
          {
            try
            {
              REACTOR3_DATA_Fired(this, new SE.Nereda.Symbols.EmergencyManagement.REACTOR3_DATAEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REACTOR3_DATA_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 3:
          if (REACTOR4_DATA_Fired != null)
          {
            try
            {
              REACTOR4_DATA_Fired(this, new SE.Nereda.Symbols.EmergencyManagement.REACTOR4_DATAEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REACTOR4_DATA_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 4:
          if (REACTOR5_DATA_Fired != null)
          {
            try
            {
              REACTOR5_DATA_Fired(this, new SE.Nereda.Symbols.EmergencyManagement.REACTOR5_DATAEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REACTOR5_DATA_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 5:
          if (REACTOR6_DATA_Fired != null)
          {
            try
            {
              REACTOR6_DATA_Fired(this, new SE.Nereda.Symbols.EmergencyManagement.REACTOR6_DATAEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REACTOR6_DATA_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 6:
          if (CT_REACTOR_ACTUAL_Fired != null)
          {
            try
            {
              CT_REACTOR_ACTUAL_Fired(this, new SE.Nereda.Symbols.EmergencyManagement.CT_REACTOR_ACTUALEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","CT_REACTOR_ACTUAL_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 7:
          if (NBR_TOT_AV_REACTOR_Fired != null)
          {
            try
            {
              NBR_TOT_AV_REACTOR_Fired(this, new SE.Nereda.Symbols.EmergencyManagement.NBR_TOT_AV_REACTOREventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","NBR_TOT_AV_REACTOR_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 8:
          if (FEED_INTERVAL_Fired != null)
          {
            try
            {
              FEED_INTERVAL_Fired(this, new SE.Nereda.Symbols.EmergencyManagement.FEED_INTERVALEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","FEED_INTERVAL_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 9:
          if (GRAPH_Fired != null)
          {
            try
            {
              GRAPH_Fired(this, new SE.Nereda.Symbols.EmergencyManagement.GRAPHEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","GRAPH_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 10:
          if (EMER_ON_Fired != null)
          {
            try
            {
              EMER_ON_Fired(this, new SE.Nereda.Symbols.EmergencyManagement.EMER_ONEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","EMER_ON_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 11:
          if (LOAD_PERS_DATA_Fired != null)
          {
            try
            {
              LOAD_PERS_DATA_Fired(this, new SE.Nereda.Symbols.EmergencyManagement.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
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
    public bool FireEvent_CT_NOMINAL(NxtControl.GuiFramework.Time CT_Nominal)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {CT_Nominal});
    }
    public bool FireEvent_CT_NOMINAL(SE.Nereda.Symbols.EmergencyManagement.CT_NOMINALEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.CT_Nominal.HasValue) _values_[0] = ea.CT_Nominal.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_CT_NOMINAL(NxtControl.GuiFramework.Time CT_Nominal, bool ignore_CT_Nominal)
    {
      object[] _values_ = new object[1];
      if (!ignore_CT_Nominal) _values_[0] = CT_Nominal;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_START_UP_DELAY(NxtControl.GuiFramework.Time StartUpDelay)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {StartUpDelay});
    }
    public bool FireEvent_START_UP_DELAY(SE.Nereda.Symbols.EmergencyManagement.START_UP_DELAYEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.StartUpDelay.HasValue) _values_[0] = ea.StartUpDelay.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_START_UP_DELAY(NxtControl.GuiFramework.Time StartUpDelay, bool ignore_StartUpDelay)
    {
      object[] _values_ = new object[1];
      if (!ignore_StartUpDelay) _values_[0] = StartUpDelay;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }

  }
}

namespace SE.Nereda.Faceplates.EmergencyManagement
{
  partial class fpEquations
  {

    private event EventHandler<SE.Nereda.Symbols.EmergencyManagement.REACTOR1_DATAEventArgs> REACTOR1_DATA_Fired;

    private event EventHandler<SE.Nereda.Symbols.EmergencyManagement.REACTOR2_DATAEventArgs> REACTOR2_DATA_Fired;

    private event EventHandler<SE.Nereda.Symbols.EmergencyManagement.REACTOR3_DATAEventArgs> REACTOR3_DATA_Fired;

    private event EventHandler<SE.Nereda.Symbols.EmergencyManagement.REACTOR4_DATAEventArgs> REACTOR4_DATA_Fired;

    private event EventHandler<SE.Nereda.Symbols.EmergencyManagement.REACTOR5_DATAEventArgs> REACTOR5_DATA_Fired;

    private event EventHandler<SE.Nereda.Symbols.EmergencyManagement.REACTOR6_DATAEventArgs> REACTOR6_DATA_Fired;

    private event EventHandler<SE.Nereda.Symbols.EmergencyManagement.CT_REACTOR_ACTUALEventArgs> CT_REACTOR_ACTUAL_Fired;

    private event EventHandler<SE.Nereda.Symbols.EmergencyManagement.NBR_TOT_AV_REACTOREventArgs> NBR_TOT_AV_REACTOR_Fired;

    private event EventHandler<SE.Nereda.Symbols.EmergencyManagement.FEED_INTERVALEventArgs> FEED_INTERVAL_Fired;

    private event EventHandler<SE.Nereda.Symbols.EmergencyManagement.GRAPHEventArgs> GRAPH_Fired;

    private event EventHandler<SE.Nereda.Symbols.EmergencyManagement.EMER_ONEventArgs> EMER_ON_Fired;

    private event EventHandler<SE.Nereda.Symbols.EmergencyManagement.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    protected override void OnEndInit()
    {
      if (REACTOR1_DATA_Fired != null)
        AttachEventInput(0);
      if (REACTOR2_DATA_Fired != null)
        AttachEventInput(1);
      if (REACTOR3_DATA_Fired != null)
        AttachEventInput(2);
      if (REACTOR4_DATA_Fired != null)
        AttachEventInput(3);
      if (REACTOR5_DATA_Fired != null)
        AttachEventInput(4);
      if (REACTOR6_DATA_Fired != null)
        AttachEventInput(5);
      if (CT_REACTOR_ACTUAL_Fired != null)
        AttachEventInput(6);
      if (NBR_TOT_AV_REACTOR_Fired != null)
        AttachEventInput(7);
      if (FEED_INTERVAL_Fired != null)
        AttachEventInput(8);
      if (GRAPH_Fired != null)
        AttachEventInput(9);
      if (EMER_ON_Fired != null)
        AttachEventInput(10);
      if (LOAD_PERS_DATA_Fired != null)
        AttachEventInput(11);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (REACTOR1_DATA_Fired != null)
          {
            try
            {
              REACTOR1_DATA_Fired(this, new SE.Nereda.Symbols.EmergencyManagement.REACTOR1_DATAEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REACTOR1_DATA_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 1:
          if (REACTOR2_DATA_Fired != null)
          {
            try
            {
              REACTOR2_DATA_Fired(this, new SE.Nereda.Symbols.EmergencyManagement.REACTOR2_DATAEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REACTOR2_DATA_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 2:
          if (REACTOR3_DATA_Fired != null)
          {
            try
            {
              REACTOR3_DATA_Fired(this, new SE.Nereda.Symbols.EmergencyManagement.REACTOR3_DATAEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REACTOR3_DATA_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 3:
          if (REACTOR4_DATA_Fired != null)
          {
            try
            {
              REACTOR4_DATA_Fired(this, new SE.Nereda.Symbols.EmergencyManagement.REACTOR4_DATAEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REACTOR4_DATA_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 4:
          if (REACTOR5_DATA_Fired != null)
          {
            try
            {
              REACTOR5_DATA_Fired(this, new SE.Nereda.Symbols.EmergencyManagement.REACTOR5_DATAEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REACTOR5_DATA_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 5:
          if (REACTOR6_DATA_Fired != null)
          {
            try
            {
              REACTOR6_DATA_Fired(this, new SE.Nereda.Symbols.EmergencyManagement.REACTOR6_DATAEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REACTOR6_DATA_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 6:
          if (CT_REACTOR_ACTUAL_Fired != null)
          {
            try
            {
              CT_REACTOR_ACTUAL_Fired(this, new SE.Nereda.Symbols.EmergencyManagement.CT_REACTOR_ACTUALEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","CT_REACTOR_ACTUAL_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 7:
          if (NBR_TOT_AV_REACTOR_Fired != null)
          {
            try
            {
              NBR_TOT_AV_REACTOR_Fired(this, new SE.Nereda.Symbols.EmergencyManagement.NBR_TOT_AV_REACTOREventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","NBR_TOT_AV_REACTOR_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 8:
          if (FEED_INTERVAL_Fired != null)
          {
            try
            {
              FEED_INTERVAL_Fired(this, new SE.Nereda.Symbols.EmergencyManagement.FEED_INTERVALEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","FEED_INTERVAL_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 9:
          if (GRAPH_Fired != null)
          {
            try
            {
              GRAPH_Fired(this, new SE.Nereda.Symbols.EmergencyManagement.GRAPHEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","GRAPH_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 10:
          if (EMER_ON_Fired != null)
          {
            try
            {
              EMER_ON_Fired(this, new SE.Nereda.Symbols.EmergencyManagement.EMER_ONEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","EMER_ON_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 11:
          if (LOAD_PERS_DATA_Fired != null)
          {
            try
            {
              LOAD_PERS_DATA_Fired(this, new SE.Nereda.Symbols.EmergencyManagement.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
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
    public bool FireEvent_CT_NOMINAL(NxtControl.GuiFramework.Time CT_Nominal)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {CT_Nominal});
    }
    public bool FireEvent_CT_NOMINAL(SE.Nereda.Symbols.EmergencyManagement.CT_NOMINALEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.CT_Nominal.HasValue) _values_[0] = ea.CT_Nominal.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_CT_NOMINAL(NxtControl.GuiFramework.Time CT_Nominal, bool ignore_CT_Nominal)
    {
      object[] _values_ = new object[1];
      if (!ignore_CT_Nominal) _values_[0] = CT_Nominal;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_START_UP_DELAY(NxtControl.GuiFramework.Time StartUpDelay)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {StartUpDelay});
    }
    public bool FireEvent_START_UP_DELAY(SE.Nereda.Symbols.EmergencyManagement.START_UP_DELAYEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.StartUpDelay.HasValue) _values_[0] = ea.StartUpDelay.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_START_UP_DELAY(NxtControl.GuiFramework.Time StartUpDelay, bool ignore_StartUpDelay)
    {
      object[] _values_ = new object[1];
      if (!ignore_StartUpDelay) _values_[0] = StartUpDelay;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }

  }
}

namespace SE.Nereda.Faceplates.EmergencyManagement
{
  partial class fpDiagram
  {

    private event EventHandler<SE.Nereda.Symbols.EmergencyManagement.REACTOR1_DATAEventArgs> REACTOR1_DATA_Fired;

    private event EventHandler<SE.Nereda.Symbols.EmergencyManagement.REACTOR2_DATAEventArgs> REACTOR2_DATA_Fired;

    private event EventHandler<SE.Nereda.Symbols.EmergencyManagement.REACTOR3_DATAEventArgs> REACTOR3_DATA_Fired;

    private event EventHandler<SE.Nereda.Symbols.EmergencyManagement.REACTOR4_DATAEventArgs> REACTOR4_DATA_Fired;

    private event EventHandler<SE.Nereda.Symbols.EmergencyManagement.REACTOR5_DATAEventArgs> REACTOR5_DATA_Fired;

    private event EventHandler<SE.Nereda.Symbols.EmergencyManagement.REACTOR6_DATAEventArgs> REACTOR6_DATA_Fired;

    private event EventHandler<SE.Nereda.Symbols.EmergencyManagement.CT_REACTOR_ACTUALEventArgs> CT_REACTOR_ACTUAL_Fired;

    private event EventHandler<SE.Nereda.Symbols.EmergencyManagement.NBR_TOT_AV_REACTOREventArgs> NBR_TOT_AV_REACTOR_Fired;

    private event EventHandler<SE.Nereda.Symbols.EmergencyManagement.FEED_INTERVALEventArgs> FEED_INTERVAL_Fired;

    private event EventHandler<SE.Nereda.Symbols.EmergencyManagement.GRAPHEventArgs> GRAPH_Fired;

    private event EventHandler<SE.Nereda.Symbols.EmergencyManagement.EMER_ONEventArgs> EMER_ON_Fired;

    private event EventHandler<SE.Nereda.Symbols.EmergencyManagement.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    protected override void OnEndInit()
    {
      if (REACTOR1_DATA_Fired != null)
        AttachEventInput(0);
      if (REACTOR2_DATA_Fired != null)
        AttachEventInput(1);
      if (REACTOR3_DATA_Fired != null)
        AttachEventInput(2);
      if (REACTOR4_DATA_Fired != null)
        AttachEventInput(3);
      if (REACTOR5_DATA_Fired != null)
        AttachEventInput(4);
      if (REACTOR6_DATA_Fired != null)
        AttachEventInput(5);
      if (CT_REACTOR_ACTUAL_Fired != null)
        AttachEventInput(6);
      if (NBR_TOT_AV_REACTOR_Fired != null)
        AttachEventInput(7);
      if (FEED_INTERVAL_Fired != null)
        AttachEventInput(8);
      if (GRAPH_Fired != null)
        AttachEventInput(9);
      if (EMER_ON_Fired != null)
        AttachEventInput(10);
      if (LOAD_PERS_DATA_Fired != null)
        AttachEventInput(11);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (REACTOR1_DATA_Fired != null)
          {
            try
            {
              REACTOR1_DATA_Fired(this, new SE.Nereda.Symbols.EmergencyManagement.REACTOR1_DATAEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REACTOR1_DATA_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 1:
          if (REACTOR2_DATA_Fired != null)
          {
            try
            {
              REACTOR2_DATA_Fired(this, new SE.Nereda.Symbols.EmergencyManagement.REACTOR2_DATAEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REACTOR2_DATA_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 2:
          if (REACTOR3_DATA_Fired != null)
          {
            try
            {
              REACTOR3_DATA_Fired(this, new SE.Nereda.Symbols.EmergencyManagement.REACTOR3_DATAEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REACTOR3_DATA_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 3:
          if (REACTOR4_DATA_Fired != null)
          {
            try
            {
              REACTOR4_DATA_Fired(this, new SE.Nereda.Symbols.EmergencyManagement.REACTOR4_DATAEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REACTOR4_DATA_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 4:
          if (REACTOR5_DATA_Fired != null)
          {
            try
            {
              REACTOR5_DATA_Fired(this, new SE.Nereda.Symbols.EmergencyManagement.REACTOR5_DATAEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REACTOR5_DATA_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 5:
          if (REACTOR6_DATA_Fired != null)
          {
            try
            {
              REACTOR6_DATA_Fired(this, new SE.Nereda.Symbols.EmergencyManagement.REACTOR6_DATAEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REACTOR6_DATA_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 6:
          if (CT_REACTOR_ACTUAL_Fired != null)
          {
            try
            {
              CT_REACTOR_ACTUAL_Fired(this, new SE.Nereda.Symbols.EmergencyManagement.CT_REACTOR_ACTUALEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","CT_REACTOR_ACTUAL_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 7:
          if (NBR_TOT_AV_REACTOR_Fired != null)
          {
            try
            {
              NBR_TOT_AV_REACTOR_Fired(this, new SE.Nereda.Symbols.EmergencyManagement.NBR_TOT_AV_REACTOREventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","NBR_TOT_AV_REACTOR_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 8:
          if (FEED_INTERVAL_Fired != null)
          {
            try
            {
              FEED_INTERVAL_Fired(this, new SE.Nereda.Symbols.EmergencyManagement.FEED_INTERVALEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","FEED_INTERVAL_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 9:
          if (GRAPH_Fired != null)
          {
            try
            {
              GRAPH_Fired(this, new SE.Nereda.Symbols.EmergencyManagement.GRAPHEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","GRAPH_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 10:
          if (EMER_ON_Fired != null)
          {
            try
            {
              EMER_ON_Fired(this, new SE.Nereda.Symbols.EmergencyManagement.EMER_ONEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","EMER_ON_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 11:
          if (LOAD_PERS_DATA_Fired != null)
          {
            try
            {
              LOAD_PERS_DATA_Fired(this, new SE.Nereda.Symbols.EmergencyManagement.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
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
    public bool FireEvent_CT_NOMINAL(NxtControl.GuiFramework.Time CT_Nominal)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {CT_Nominal});
    }
    public bool FireEvent_CT_NOMINAL(SE.Nereda.Symbols.EmergencyManagement.CT_NOMINALEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.CT_Nominal.HasValue) _values_[0] = ea.CT_Nominal.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_CT_NOMINAL(NxtControl.GuiFramework.Time CT_Nominal, bool ignore_CT_Nominal)
    {
      object[] _values_ = new object[1];
      if (!ignore_CT_Nominal) _values_[0] = CT_Nominal;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_START_UP_DELAY(NxtControl.GuiFramework.Time StartUpDelay)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {StartUpDelay});
    }
    public bool FireEvent_START_UP_DELAY(SE.Nereda.Symbols.EmergencyManagement.START_UP_DELAYEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.StartUpDelay.HasValue) _values_[0] = ea.StartUpDelay.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_START_UP_DELAY(NxtControl.GuiFramework.Time StartUpDelay, bool ignore_StartUpDelay)
    {
      object[] _values_ = new object[1];
      if (!ignore_StartUpDelay) _values_[0] = StartUpDelay;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }

  }
}

namespace SE.Nereda.Symbols.EmergencyManagement
{
  partial class sDataR1
  {

    private event EventHandler<SE.Nereda.Symbols.EmergencyManagement.REACTOR1_DATAEventArgs> REACTOR1_DATA_Fired;

    private event EventHandler<SE.Nereda.Symbols.EmergencyManagement.REACTOR2_DATAEventArgs> REACTOR2_DATA_Fired;

    private event EventHandler<SE.Nereda.Symbols.EmergencyManagement.REACTOR3_DATAEventArgs> REACTOR3_DATA_Fired;

    private event EventHandler<SE.Nereda.Symbols.EmergencyManagement.REACTOR4_DATAEventArgs> REACTOR4_DATA_Fired;

    private event EventHandler<SE.Nereda.Symbols.EmergencyManagement.REACTOR5_DATAEventArgs> REACTOR5_DATA_Fired;

    private event EventHandler<SE.Nereda.Symbols.EmergencyManagement.REACTOR6_DATAEventArgs> REACTOR6_DATA_Fired;

    private event EventHandler<SE.Nereda.Symbols.EmergencyManagement.CT_REACTOR_ACTUALEventArgs> CT_REACTOR_ACTUAL_Fired;

    private event EventHandler<SE.Nereda.Symbols.EmergencyManagement.NBR_TOT_AV_REACTOREventArgs> NBR_TOT_AV_REACTOR_Fired;

    private event EventHandler<SE.Nereda.Symbols.EmergencyManagement.FEED_INTERVALEventArgs> FEED_INTERVAL_Fired;

    private event EventHandler<SE.Nereda.Symbols.EmergencyManagement.GRAPHEventArgs> GRAPH_Fired;

    private event EventHandler<SE.Nereda.Symbols.EmergencyManagement.EMER_ONEventArgs> EMER_ON_Fired;

    private event EventHandler<SE.Nereda.Symbols.EmergencyManagement.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    protected override void OnEndInit()
    {
      if (REACTOR1_DATA_Fired != null)
        AttachEventInput(0);
      if (REACTOR2_DATA_Fired != null)
        AttachEventInput(1);
      if (REACTOR3_DATA_Fired != null)
        AttachEventInput(2);
      if (REACTOR4_DATA_Fired != null)
        AttachEventInput(3);
      if (REACTOR5_DATA_Fired != null)
        AttachEventInput(4);
      if (REACTOR6_DATA_Fired != null)
        AttachEventInput(5);
      if (CT_REACTOR_ACTUAL_Fired != null)
        AttachEventInput(6);
      if (NBR_TOT_AV_REACTOR_Fired != null)
        AttachEventInput(7);
      if (FEED_INTERVAL_Fired != null)
        AttachEventInput(8);
      if (GRAPH_Fired != null)
        AttachEventInput(9);
      if (EMER_ON_Fired != null)
        AttachEventInput(10);
      if (LOAD_PERS_DATA_Fired != null)
        AttachEventInput(11);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (REACTOR1_DATA_Fired != null)
          {
            try
            {
              REACTOR1_DATA_Fired(this, new SE.Nereda.Symbols.EmergencyManagement.REACTOR1_DATAEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REACTOR1_DATA_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 1:
          if (REACTOR2_DATA_Fired != null)
          {
            try
            {
              REACTOR2_DATA_Fired(this, new SE.Nereda.Symbols.EmergencyManagement.REACTOR2_DATAEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REACTOR2_DATA_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 2:
          if (REACTOR3_DATA_Fired != null)
          {
            try
            {
              REACTOR3_DATA_Fired(this, new SE.Nereda.Symbols.EmergencyManagement.REACTOR3_DATAEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REACTOR3_DATA_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 3:
          if (REACTOR4_DATA_Fired != null)
          {
            try
            {
              REACTOR4_DATA_Fired(this, new SE.Nereda.Symbols.EmergencyManagement.REACTOR4_DATAEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REACTOR4_DATA_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 4:
          if (REACTOR5_DATA_Fired != null)
          {
            try
            {
              REACTOR5_DATA_Fired(this, new SE.Nereda.Symbols.EmergencyManagement.REACTOR5_DATAEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REACTOR5_DATA_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 5:
          if (REACTOR6_DATA_Fired != null)
          {
            try
            {
              REACTOR6_DATA_Fired(this, new SE.Nereda.Symbols.EmergencyManagement.REACTOR6_DATAEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REACTOR6_DATA_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 6:
          if (CT_REACTOR_ACTUAL_Fired != null)
          {
            try
            {
              CT_REACTOR_ACTUAL_Fired(this, new SE.Nereda.Symbols.EmergencyManagement.CT_REACTOR_ACTUALEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","CT_REACTOR_ACTUAL_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 7:
          if (NBR_TOT_AV_REACTOR_Fired != null)
          {
            try
            {
              NBR_TOT_AV_REACTOR_Fired(this, new SE.Nereda.Symbols.EmergencyManagement.NBR_TOT_AV_REACTOREventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","NBR_TOT_AV_REACTOR_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 8:
          if (FEED_INTERVAL_Fired != null)
          {
            try
            {
              FEED_INTERVAL_Fired(this, new SE.Nereda.Symbols.EmergencyManagement.FEED_INTERVALEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","FEED_INTERVAL_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 9:
          if (GRAPH_Fired != null)
          {
            try
            {
              GRAPH_Fired(this, new SE.Nereda.Symbols.EmergencyManagement.GRAPHEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","GRAPH_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 10:
          if (EMER_ON_Fired != null)
          {
            try
            {
              EMER_ON_Fired(this, new SE.Nereda.Symbols.EmergencyManagement.EMER_ONEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","EMER_ON_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 11:
          if (LOAD_PERS_DATA_Fired != null)
          {
            try
            {
              LOAD_PERS_DATA_Fired(this, new SE.Nereda.Symbols.EmergencyManagement.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
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
    public bool FireEvent_CT_NOMINAL(NxtControl.GuiFramework.Time CT_Nominal)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {CT_Nominal});
    }
    public bool FireEvent_CT_NOMINAL(SE.Nereda.Symbols.EmergencyManagement.CT_NOMINALEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.CT_Nominal.HasValue) _values_[0] = ea.CT_Nominal.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_CT_NOMINAL(NxtControl.GuiFramework.Time CT_Nominal, bool ignore_CT_Nominal)
    {
      object[] _values_ = new object[1];
      if (!ignore_CT_Nominal) _values_[0] = CT_Nominal;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_START_UP_DELAY(NxtControl.GuiFramework.Time StartUpDelay)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {StartUpDelay});
    }
    public bool FireEvent_START_UP_DELAY(SE.Nereda.Symbols.EmergencyManagement.START_UP_DELAYEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.StartUpDelay.HasValue) _values_[0] = ea.StartUpDelay.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_START_UP_DELAY(NxtControl.GuiFramework.Time StartUpDelay, bool ignore_StartUpDelay)
    {
      object[] _values_ = new object[1];
      if (!ignore_StartUpDelay) _values_[0] = StartUpDelay;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }

  }
}

namespace SE.Nereda.Symbols.EmergencyManagement
{
  partial class sSettingsBtn
  {

    private event EventHandler<SE.Nereda.Symbols.EmergencyManagement.REACTOR1_DATAEventArgs> REACTOR1_DATA_Fired;

    private event EventHandler<SE.Nereda.Symbols.EmergencyManagement.REACTOR2_DATAEventArgs> REACTOR2_DATA_Fired;

    private event EventHandler<SE.Nereda.Symbols.EmergencyManagement.REACTOR3_DATAEventArgs> REACTOR3_DATA_Fired;

    private event EventHandler<SE.Nereda.Symbols.EmergencyManagement.REACTOR4_DATAEventArgs> REACTOR4_DATA_Fired;

    private event EventHandler<SE.Nereda.Symbols.EmergencyManagement.REACTOR5_DATAEventArgs> REACTOR5_DATA_Fired;

    private event EventHandler<SE.Nereda.Symbols.EmergencyManagement.REACTOR6_DATAEventArgs> REACTOR6_DATA_Fired;

    private event EventHandler<SE.Nereda.Symbols.EmergencyManagement.CT_REACTOR_ACTUALEventArgs> CT_REACTOR_ACTUAL_Fired;

    private event EventHandler<SE.Nereda.Symbols.EmergencyManagement.NBR_TOT_AV_REACTOREventArgs> NBR_TOT_AV_REACTOR_Fired;

    private event EventHandler<SE.Nereda.Symbols.EmergencyManagement.FEED_INTERVALEventArgs> FEED_INTERVAL_Fired;

    private event EventHandler<SE.Nereda.Symbols.EmergencyManagement.GRAPHEventArgs> GRAPH_Fired;

    private event EventHandler<SE.Nereda.Symbols.EmergencyManagement.EMER_ONEventArgs> EMER_ON_Fired;

    private event EventHandler<SE.Nereda.Symbols.EmergencyManagement.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    protected override void OnEndInit()
    {
      if (REACTOR1_DATA_Fired != null)
        AttachEventInput(0);
      if (REACTOR2_DATA_Fired != null)
        AttachEventInput(1);
      if (REACTOR3_DATA_Fired != null)
        AttachEventInput(2);
      if (REACTOR4_DATA_Fired != null)
        AttachEventInput(3);
      if (REACTOR5_DATA_Fired != null)
        AttachEventInput(4);
      if (REACTOR6_DATA_Fired != null)
        AttachEventInput(5);
      if (CT_REACTOR_ACTUAL_Fired != null)
        AttachEventInput(6);
      if (NBR_TOT_AV_REACTOR_Fired != null)
        AttachEventInput(7);
      if (FEED_INTERVAL_Fired != null)
        AttachEventInput(8);
      if (GRAPH_Fired != null)
        AttachEventInput(9);
      if (EMER_ON_Fired != null)
        AttachEventInput(10);
      if (LOAD_PERS_DATA_Fired != null)
        AttachEventInput(11);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (REACTOR1_DATA_Fired != null)
          {
            try
            {
              REACTOR1_DATA_Fired(this, new SE.Nereda.Symbols.EmergencyManagement.REACTOR1_DATAEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REACTOR1_DATA_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 1:
          if (REACTOR2_DATA_Fired != null)
          {
            try
            {
              REACTOR2_DATA_Fired(this, new SE.Nereda.Symbols.EmergencyManagement.REACTOR2_DATAEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REACTOR2_DATA_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 2:
          if (REACTOR3_DATA_Fired != null)
          {
            try
            {
              REACTOR3_DATA_Fired(this, new SE.Nereda.Symbols.EmergencyManagement.REACTOR3_DATAEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REACTOR3_DATA_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 3:
          if (REACTOR4_DATA_Fired != null)
          {
            try
            {
              REACTOR4_DATA_Fired(this, new SE.Nereda.Symbols.EmergencyManagement.REACTOR4_DATAEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REACTOR4_DATA_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 4:
          if (REACTOR5_DATA_Fired != null)
          {
            try
            {
              REACTOR5_DATA_Fired(this, new SE.Nereda.Symbols.EmergencyManagement.REACTOR5_DATAEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REACTOR5_DATA_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 5:
          if (REACTOR6_DATA_Fired != null)
          {
            try
            {
              REACTOR6_DATA_Fired(this, new SE.Nereda.Symbols.EmergencyManagement.REACTOR6_DATAEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REACTOR6_DATA_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 6:
          if (CT_REACTOR_ACTUAL_Fired != null)
          {
            try
            {
              CT_REACTOR_ACTUAL_Fired(this, new SE.Nereda.Symbols.EmergencyManagement.CT_REACTOR_ACTUALEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","CT_REACTOR_ACTUAL_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 7:
          if (NBR_TOT_AV_REACTOR_Fired != null)
          {
            try
            {
              NBR_TOT_AV_REACTOR_Fired(this, new SE.Nereda.Symbols.EmergencyManagement.NBR_TOT_AV_REACTOREventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","NBR_TOT_AV_REACTOR_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 8:
          if (FEED_INTERVAL_Fired != null)
          {
            try
            {
              FEED_INTERVAL_Fired(this, new SE.Nereda.Symbols.EmergencyManagement.FEED_INTERVALEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","FEED_INTERVAL_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 9:
          if (GRAPH_Fired != null)
          {
            try
            {
              GRAPH_Fired(this, new SE.Nereda.Symbols.EmergencyManagement.GRAPHEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","GRAPH_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 10:
          if (EMER_ON_Fired != null)
          {
            try
            {
              EMER_ON_Fired(this, new SE.Nereda.Symbols.EmergencyManagement.EMER_ONEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","EMER_ON_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 11:
          if (LOAD_PERS_DATA_Fired != null)
          {
            try
            {
              LOAD_PERS_DATA_Fired(this, new SE.Nereda.Symbols.EmergencyManagement.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
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
    public bool FireEvent_CT_NOMINAL(NxtControl.GuiFramework.Time CT_Nominal)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {CT_Nominal});
    }
    public bool FireEvent_CT_NOMINAL(SE.Nereda.Symbols.EmergencyManagement.CT_NOMINALEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.CT_Nominal.HasValue) _values_[0] = ea.CT_Nominal.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_CT_NOMINAL(NxtControl.GuiFramework.Time CT_Nominal, bool ignore_CT_Nominal)
    {
      object[] _values_ = new object[1];
      if (!ignore_CT_Nominal) _values_[0] = CT_Nominal;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_START_UP_DELAY(NxtControl.GuiFramework.Time StartUpDelay)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {StartUpDelay});
    }
    public bool FireEvent_START_UP_DELAY(SE.Nereda.Symbols.EmergencyManagement.START_UP_DELAYEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.StartUpDelay.HasValue) _values_[0] = ea.StartUpDelay.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_START_UP_DELAY(NxtControl.GuiFramework.Time StartUpDelay, bool ignore_StartUpDelay)
    {
      object[] _values_ = new object[1];
      if (!ignore_StartUpDelay) _values_[0] = StartUpDelay;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }

  }
}

namespace SE.Nereda.Symbols.EmergencyManagement
{
  partial class sDataR2
  {

    private event EventHandler<SE.Nereda.Symbols.EmergencyManagement.REACTOR1_DATAEventArgs> REACTOR1_DATA_Fired;

    private event EventHandler<SE.Nereda.Symbols.EmergencyManagement.REACTOR2_DATAEventArgs> REACTOR2_DATA_Fired;

    private event EventHandler<SE.Nereda.Symbols.EmergencyManagement.REACTOR3_DATAEventArgs> REACTOR3_DATA_Fired;

    private event EventHandler<SE.Nereda.Symbols.EmergencyManagement.REACTOR4_DATAEventArgs> REACTOR4_DATA_Fired;

    private event EventHandler<SE.Nereda.Symbols.EmergencyManagement.REACTOR5_DATAEventArgs> REACTOR5_DATA_Fired;

    private event EventHandler<SE.Nereda.Symbols.EmergencyManagement.REACTOR6_DATAEventArgs> REACTOR6_DATA_Fired;

    private event EventHandler<SE.Nereda.Symbols.EmergencyManagement.CT_REACTOR_ACTUALEventArgs> CT_REACTOR_ACTUAL_Fired;

    private event EventHandler<SE.Nereda.Symbols.EmergencyManagement.NBR_TOT_AV_REACTOREventArgs> NBR_TOT_AV_REACTOR_Fired;

    private event EventHandler<SE.Nereda.Symbols.EmergencyManagement.FEED_INTERVALEventArgs> FEED_INTERVAL_Fired;

    private event EventHandler<SE.Nereda.Symbols.EmergencyManagement.GRAPHEventArgs> GRAPH_Fired;

    private event EventHandler<SE.Nereda.Symbols.EmergencyManagement.EMER_ONEventArgs> EMER_ON_Fired;

    private event EventHandler<SE.Nereda.Symbols.EmergencyManagement.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    protected override void OnEndInit()
    {
      if (REACTOR1_DATA_Fired != null)
        AttachEventInput(0);
      if (REACTOR2_DATA_Fired != null)
        AttachEventInput(1);
      if (REACTOR3_DATA_Fired != null)
        AttachEventInput(2);
      if (REACTOR4_DATA_Fired != null)
        AttachEventInput(3);
      if (REACTOR5_DATA_Fired != null)
        AttachEventInput(4);
      if (REACTOR6_DATA_Fired != null)
        AttachEventInput(5);
      if (CT_REACTOR_ACTUAL_Fired != null)
        AttachEventInput(6);
      if (NBR_TOT_AV_REACTOR_Fired != null)
        AttachEventInput(7);
      if (FEED_INTERVAL_Fired != null)
        AttachEventInput(8);
      if (GRAPH_Fired != null)
        AttachEventInput(9);
      if (EMER_ON_Fired != null)
        AttachEventInput(10);
      if (LOAD_PERS_DATA_Fired != null)
        AttachEventInput(11);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (REACTOR1_DATA_Fired != null)
          {
            try
            {
              REACTOR1_DATA_Fired(this, new SE.Nereda.Symbols.EmergencyManagement.REACTOR1_DATAEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REACTOR1_DATA_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 1:
          if (REACTOR2_DATA_Fired != null)
          {
            try
            {
              REACTOR2_DATA_Fired(this, new SE.Nereda.Symbols.EmergencyManagement.REACTOR2_DATAEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REACTOR2_DATA_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 2:
          if (REACTOR3_DATA_Fired != null)
          {
            try
            {
              REACTOR3_DATA_Fired(this, new SE.Nereda.Symbols.EmergencyManagement.REACTOR3_DATAEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REACTOR3_DATA_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 3:
          if (REACTOR4_DATA_Fired != null)
          {
            try
            {
              REACTOR4_DATA_Fired(this, new SE.Nereda.Symbols.EmergencyManagement.REACTOR4_DATAEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REACTOR4_DATA_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 4:
          if (REACTOR5_DATA_Fired != null)
          {
            try
            {
              REACTOR5_DATA_Fired(this, new SE.Nereda.Symbols.EmergencyManagement.REACTOR5_DATAEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REACTOR5_DATA_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 5:
          if (REACTOR6_DATA_Fired != null)
          {
            try
            {
              REACTOR6_DATA_Fired(this, new SE.Nereda.Symbols.EmergencyManagement.REACTOR6_DATAEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REACTOR6_DATA_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 6:
          if (CT_REACTOR_ACTUAL_Fired != null)
          {
            try
            {
              CT_REACTOR_ACTUAL_Fired(this, new SE.Nereda.Symbols.EmergencyManagement.CT_REACTOR_ACTUALEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","CT_REACTOR_ACTUAL_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 7:
          if (NBR_TOT_AV_REACTOR_Fired != null)
          {
            try
            {
              NBR_TOT_AV_REACTOR_Fired(this, new SE.Nereda.Symbols.EmergencyManagement.NBR_TOT_AV_REACTOREventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","NBR_TOT_AV_REACTOR_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 8:
          if (FEED_INTERVAL_Fired != null)
          {
            try
            {
              FEED_INTERVAL_Fired(this, new SE.Nereda.Symbols.EmergencyManagement.FEED_INTERVALEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","FEED_INTERVAL_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 9:
          if (GRAPH_Fired != null)
          {
            try
            {
              GRAPH_Fired(this, new SE.Nereda.Symbols.EmergencyManagement.GRAPHEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","GRAPH_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 10:
          if (EMER_ON_Fired != null)
          {
            try
            {
              EMER_ON_Fired(this, new SE.Nereda.Symbols.EmergencyManagement.EMER_ONEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","EMER_ON_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 11:
          if (LOAD_PERS_DATA_Fired != null)
          {
            try
            {
              LOAD_PERS_DATA_Fired(this, new SE.Nereda.Symbols.EmergencyManagement.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
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
    public bool FireEvent_CT_NOMINAL(NxtControl.GuiFramework.Time CT_Nominal)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {CT_Nominal});
    }
    public bool FireEvent_CT_NOMINAL(SE.Nereda.Symbols.EmergencyManagement.CT_NOMINALEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.CT_Nominal.HasValue) _values_[0] = ea.CT_Nominal.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_CT_NOMINAL(NxtControl.GuiFramework.Time CT_Nominal, bool ignore_CT_Nominal)
    {
      object[] _values_ = new object[1];
      if (!ignore_CT_Nominal) _values_[0] = CT_Nominal;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_START_UP_DELAY(NxtControl.GuiFramework.Time StartUpDelay)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {StartUpDelay});
    }
    public bool FireEvent_START_UP_DELAY(SE.Nereda.Symbols.EmergencyManagement.START_UP_DELAYEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.StartUpDelay.HasValue) _values_[0] = ea.StartUpDelay.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_START_UP_DELAY(NxtControl.GuiFramework.Time StartUpDelay, bool ignore_StartUpDelay)
    {
      object[] _values_ = new object[1];
      if (!ignore_StartUpDelay) _values_[0] = StartUpDelay;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }

  }
}

namespace SE.Nereda.Symbols.EmergencyManagement
{
  partial class sDataR3
  {

    private event EventHandler<SE.Nereda.Symbols.EmergencyManagement.REACTOR1_DATAEventArgs> REACTOR1_DATA_Fired;

    private event EventHandler<SE.Nereda.Symbols.EmergencyManagement.REACTOR2_DATAEventArgs> REACTOR2_DATA_Fired;

    private event EventHandler<SE.Nereda.Symbols.EmergencyManagement.REACTOR3_DATAEventArgs> REACTOR3_DATA_Fired;

    private event EventHandler<SE.Nereda.Symbols.EmergencyManagement.REACTOR4_DATAEventArgs> REACTOR4_DATA_Fired;

    private event EventHandler<SE.Nereda.Symbols.EmergencyManagement.REACTOR5_DATAEventArgs> REACTOR5_DATA_Fired;

    private event EventHandler<SE.Nereda.Symbols.EmergencyManagement.REACTOR6_DATAEventArgs> REACTOR6_DATA_Fired;

    private event EventHandler<SE.Nereda.Symbols.EmergencyManagement.CT_REACTOR_ACTUALEventArgs> CT_REACTOR_ACTUAL_Fired;

    private event EventHandler<SE.Nereda.Symbols.EmergencyManagement.NBR_TOT_AV_REACTOREventArgs> NBR_TOT_AV_REACTOR_Fired;

    private event EventHandler<SE.Nereda.Symbols.EmergencyManagement.FEED_INTERVALEventArgs> FEED_INTERVAL_Fired;

    private event EventHandler<SE.Nereda.Symbols.EmergencyManagement.GRAPHEventArgs> GRAPH_Fired;

    private event EventHandler<SE.Nereda.Symbols.EmergencyManagement.EMER_ONEventArgs> EMER_ON_Fired;

    private event EventHandler<SE.Nereda.Symbols.EmergencyManagement.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    protected override void OnEndInit()
    {
      if (REACTOR1_DATA_Fired != null)
        AttachEventInput(0);
      if (REACTOR2_DATA_Fired != null)
        AttachEventInput(1);
      if (REACTOR3_DATA_Fired != null)
        AttachEventInput(2);
      if (REACTOR4_DATA_Fired != null)
        AttachEventInput(3);
      if (REACTOR5_DATA_Fired != null)
        AttachEventInput(4);
      if (REACTOR6_DATA_Fired != null)
        AttachEventInput(5);
      if (CT_REACTOR_ACTUAL_Fired != null)
        AttachEventInput(6);
      if (NBR_TOT_AV_REACTOR_Fired != null)
        AttachEventInput(7);
      if (FEED_INTERVAL_Fired != null)
        AttachEventInput(8);
      if (GRAPH_Fired != null)
        AttachEventInput(9);
      if (EMER_ON_Fired != null)
        AttachEventInput(10);
      if (LOAD_PERS_DATA_Fired != null)
        AttachEventInput(11);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (REACTOR1_DATA_Fired != null)
          {
            try
            {
              REACTOR1_DATA_Fired(this, new SE.Nereda.Symbols.EmergencyManagement.REACTOR1_DATAEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REACTOR1_DATA_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 1:
          if (REACTOR2_DATA_Fired != null)
          {
            try
            {
              REACTOR2_DATA_Fired(this, new SE.Nereda.Symbols.EmergencyManagement.REACTOR2_DATAEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REACTOR2_DATA_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 2:
          if (REACTOR3_DATA_Fired != null)
          {
            try
            {
              REACTOR3_DATA_Fired(this, new SE.Nereda.Symbols.EmergencyManagement.REACTOR3_DATAEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REACTOR3_DATA_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 3:
          if (REACTOR4_DATA_Fired != null)
          {
            try
            {
              REACTOR4_DATA_Fired(this, new SE.Nereda.Symbols.EmergencyManagement.REACTOR4_DATAEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REACTOR4_DATA_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 4:
          if (REACTOR5_DATA_Fired != null)
          {
            try
            {
              REACTOR5_DATA_Fired(this, new SE.Nereda.Symbols.EmergencyManagement.REACTOR5_DATAEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REACTOR5_DATA_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 5:
          if (REACTOR6_DATA_Fired != null)
          {
            try
            {
              REACTOR6_DATA_Fired(this, new SE.Nereda.Symbols.EmergencyManagement.REACTOR6_DATAEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REACTOR6_DATA_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 6:
          if (CT_REACTOR_ACTUAL_Fired != null)
          {
            try
            {
              CT_REACTOR_ACTUAL_Fired(this, new SE.Nereda.Symbols.EmergencyManagement.CT_REACTOR_ACTUALEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","CT_REACTOR_ACTUAL_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 7:
          if (NBR_TOT_AV_REACTOR_Fired != null)
          {
            try
            {
              NBR_TOT_AV_REACTOR_Fired(this, new SE.Nereda.Symbols.EmergencyManagement.NBR_TOT_AV_REACTOREventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","NBR_TOT_AV_REACTOR_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 8:
          if (FEED_INTERVAL_Fired != null)
          {
            try
            {
              FEED_INTERVAL_Fired(this, new SE.Nereda.Symbols.EmergencyManagement.FEED_INTERVALEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","FEED_INTERVAL_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 9:
          if (GRAPH_Fired != null)
          {
            try
            {
              GRAPH_Fired(this, new SE.Nereda.Symbols.EmergencyManagement.GRAPHEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","GRAPH_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 10:
          if (EMER_ON_Fired != null)
          {
            try
            {
              EMER_ON_Fired(this, new SE.Nereda.Symbols.EmergencyManagement.EMER_ONEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","EMER_ON_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 11:
          if (LOAD_PERS_DATA_Fired != null)
          {
            try
            {
              LOAD_PERS_DATA_Fired(this, new SE.Nereda.Symbols.EmergencyManagement.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
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
    public bool FireEvent_CT_NOMINAL(NxtControl.GuiFramework.Time CT_Nominal)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {CT_Nominal});
    }
    public bool FireEvent_CT_NOMINAL(SE.Nereda.Symbols.EmergencyManagement.CT_NOMINALEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.CT_Nominal.HasValue) _values_[0] = ea.CT_Nominal.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_CT_NOMINAL(NxtControl.GuiFramework.Time CT_Nominal, bool ignore_CT_Nominal)
    {
      object[] _values_ = new object[1];
      if (!ignore_CT_Nominal) _values_[0] = CT_Nominal;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_START_UP_DELAY(NxtControl.GuiFramework.Time StartUpDelay)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {StartUpDelay});
    }
    public bool FireEvent_START_UP_DELAY(SE.Nereda.Symbols.EmergencyManagement.START_UP_DELAYEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.StartUpDelay.HasValue) _values_[0] = ea.StartUpDelay.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_START_UP_DELAY(NxtControl.GuiFramework.Time StartUpDelay, bool ignore_StartUpDelay)
    {
      object[] _values_ = new object[1];
      if (!ignore_StartUpDelay) _values_[0] = StartUpDelay;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }

  }
}

namespace SE.Nereda.Symbols.EmergencyManagement
{
  partial class sReactorAvExist
  {

    private event EventHandler<SE.Nereda.Symbols.EmergencyManagement.REACTOR1_DATAEventArgs> REACTOR1_DATA_Fired;

    private event EventHandler<SE.Nereda.Symbols.EmergencyManagement.REACTOR2_DATAEventArgs> REACTOR2_DATA_Fired;

    private event EventHandler<SE.Nereda.Symbols.EmergencyManagement.REACTOR3_DATAEventArgs> REACTOR3_DATA_Fired;

    private event EventHandler<SE.Nereda.Symbols.EmergencyManagement.REACTOR4_DATAEventArgs> REACTOR4_DATA_Fired;

    private event EventHandler<SE.Nereda.Symbols.EmergencyManagement.REACTOR5_DATAEventArgs> REACTOR5_DATA_Fired;

    private event EventHandler<SE.Nereda.Symbols.EmergencyManagement.REACTOR6_DATAEventArgs> REACTOR6_DATA_Fired;

    private event EventHandler<SE.Nereda.Symbols.EmergencyManagement.CT_REACTOR_ACTUALEventArgs> CT_REACTOR_ACTUAL_Fired;

    private event EventHandler<SE.Nereda.Symbols.EmergencyManagement.NBR_TOT_AV_REACTOREventArgs> NBR_TOT_AV_REACTOR_Fired;

    private event EventHandler<SE.Nereda.Symbols.EmergencyManagement.FEED_INTERVALEventArgs> FEED_INTERVAL_Fired;

    private event EventHandler<SE.Nereda.Symbols.EmergencyManagement.GRAPHEventArgs> GRAPH_Fired;

    private event EventHandler<SE.Nereda.Symbols.EmergencyManagement.EMER_ONEventArgs> EMER_ON_Fired;

    private event EventHandler<SE.Nereda.Symbols.EmergencyManagement.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    protected override void OnEndInit()
    {
      if (REACTOR1_DATA_Fired != null)
        AttachEventInput(0);
      if (REACTOR2_DATA_Fired != null)
        AttachEventInput(1);
      if (REACTOR3_DATA_Fired != null)
        AttachEventInput(2);
      if (REACTOR4_DATA_Fired != null)
        AttachEventInput(3);
      if (REACTOR5_DATA_Fired != null)
        AttachEventInput(4);
      if (REACTOR6_DATA_Fired != null)
        AttachEventInput(5);
      if (CT_REACTOR_ACTUAL_Fired != null)
        AttachEventInput(6);
      if (NBR_TOT_AV_REACTOR_Fired != null)
        AttachEventInput(7);
      if (FEED_INTERVAL_Fired != null)
        AttachEventInput(8);
      if (GRAPH_Fired != null)
        AttachEventInput(9);
      if (EMER_ON_Fired != null)
        AttachEventInput(10);
      if (LOAD_PERS_DATA_Fired != null)
        AttachEventInput(11);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (REACTOR1_DATA_Fired != null)
          {
            try
            {
              REACTOR1_DATA_Fired(this, new SE.Nereda.Symbols.EmergencyManagement.REACTOR1_DATAEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REACTOR1_DATA_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 1:
          if (REACTOR2_DATA_Fired != null)
          {
            try
            {
              REACTOR2_DATA_Fired(this, new SE.Nereda.Symbols.EmergencyManagement.REACTOR2_DATAEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REACTOR2_DATA_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 2:
          if (REACTOR3_DATA_Fired != null)
          {
            try
            {
              REACTOR3_DATA_Fired(this, new SE.Nereda.Symbols.EmergencyManagement.REACTOR3_DATAEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REACTOR3_DATA_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 3:
          if (REACTOR4_DATA_Fired != null)
          {
            try
            {
              REACTOR4_DATA_Fired(this, new SE.Nereda.Symbols.EmergencyManagement.REACTOR4_DATAEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REACTOR4_DATA_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 4:
          if (REACTOR5_DATA_Fired != null)
          {
            try
            {
              REACTOR5_DATA_Fired(this, new SE.Nereda.Symbols.EmergencyManagement.REACTOR5_DATAEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REACTOR5_DATA_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 5:
          if (REACTOR6_DATA_Fired != null)
          {
            try
            {
              REACTOR6_DATA_Fired(this, new SE.Nereda.Symbols.EmergencyManagement.REACTOR6_DATAEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REACTOR6_DATA_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 6:
          if (CT_REACTOR_ACTUAL_Fired != null)
          {
            try
            {
              CT_REACTOR_ACTUAL_Fired(this, new SE.Nereda.Symbols.EmergencyManagement.CT_REACTOR_ACTUALEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","CT_REACTOR_ACTUAL_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 7:
          if (NBR_TOT_AV_REACTOR_Fired != null)
          {
            try
            {
              NBR_TOT_AV_REACTOR_Fired(this, new SE.Nereda.Symbols.EmergencyManagement.NBR_TOT_AV_REACTOREventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","NBR_TOT_AV_REACTOR_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 8:
          if (FEED_INTERVAL_Fired != null)
          {
            try
            {
              FEED_INTERVAL_Fired(this, new SE.Nereda.Symbols.EmergencyManagement.FEED_INTERVALEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","FEED_INTERVAL_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 9:
          if (GRAPH_Fired != null)
          {
            try
            {
              GRAPH_Fired(this, new SE.Nereda.Symbols.EmergencyManagement.GRAPHEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","GRAPH_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 10:
          if (EMER_ON_Fired != null)
          {
            try
            {
              EMER_ON_Fired(this, new SE.Nereda.Symbols.EmergencyManagement.EMER_ONEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","EMER_ON_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 11:
          if (LOAD_PERS_DATA_Fired != null)
          {
            try
            {
              LOAD_PERS_DATA_Fired(this, new SE.Nereda.Symbols.EmergencyManagement.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
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
    public bool FireEvent_CT_NOMINAL(NxtControl.GuiFramework.Time CT_Nominal)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {CT_Nominal});
    }
    public bool FireEvent_CT_NOMINAL(SE.Nereda.Symbols.EmergencyManagement.CT_NOMINALEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.CT_Nominal.HasValue) _values_[0] = ea.CT_Nominal.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_CT_NOMINAL(NxtControl.GuiFramework.Time CT_Nominal, bool ignore_CT_Nominal)
    {
      object[] _values_ = new object[1];
      if (!ignore_CT_Nominal) _values_[0] = CT_Nominal;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_START_UP_DELAY(NxtControl.GuiFramework.Time StartUpDelay)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {StartUpDelay});
    }
    public bool FireEvent_START_UP_DELAY(SE.Nereda.Symbols.EmergencyManagement.START_UP_DELAYEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.StartUpDelay.HasValue) _values_[0] = ea.StartUpDelay.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_START_UP_DELAY(NxtControl.GuiFramework.Time StartUpDelay, bool ignore_StartUpDelay)
    {
      object[] _values_ = new object[1];
      if (!ignore_StartUpDelay) _values_[0] = StartUpDelay;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }

  }
}
#endregion #EmergencyManagement_HMI;

#endregion Definitions;
