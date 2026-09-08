/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 6/4/2026
 * Time: 5:16 PM
 * 
 */
using System;
using NxtControl.GuiFramework;
using NxtControl.Services;

#region Definitions;
#region #Phase_HMI;

namespace SE.Nereda.Symbols.Phase
{

  public class REQ_STATEEventArgs : System.EventArgs
  {
    IHMIAccessorService accessorService;
    int channelId;
    int cookie; 
    int eventIndex;

    public REQ_STATEEventArgs(int channelId, int cookie, int eventIndex)
    {
      this.accessorService = (IHMIAccessorService)ServiceProvider.GetService(typeof(IHMIAccessorService));
      this.channelId = channelId;
      this.cookie = cookie;
      this.eventIndex = eventIndex;
    }
    public bool Get_STARTING(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,0, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STARTING
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,0, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_RUN(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,1, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? RUN
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,1, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STOPPING(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,2, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STOPPING
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,2, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_ABORTING(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,3, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? ABORTING
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,3, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_ABORTED(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,4, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? ABORTED
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,4, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_INTERLOCKED(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,5, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? INTERLOCKED
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,5, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_READY(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,6, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? READY
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,6, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }


  }

  public class REQ_PHASE_NAMEEventArgs : System.EventArgs
  {
    IHMIAccessorService accessorService;
    int channelId;
    int cookie; 
    int eventIndex;

    public REQ_PHASE_NAMEEventArgs(int channelId, int cookie, int eventIndex)
    {
      this.accessorService = (IHMIAccessorService)ServiceProvider.GetService(typeof(IHMIAccessorService));
      this.channelId = channelId;
      this.cookie = cookie;
      this.eventIndex = eventIndex;
    }
    public bool Get_PhaseName(ref System.String value)
    {
      if (accessorService == null)
        return false;
      string var = null;
      bool ret = accessorService.GetStringValue(channelId, cookie, eventIndex, true,0, ref var);
      if (ret) value = (System.String) var;
      return ret;
    }

    public System.String PhaseName
    { get {
      if (accessorService == null)
        return null;
      string var = null;
      bool ret = accessorService.GetStringValue(channelId, cookie, eventIndex, true,0, ref var);
      if (!ret) return null;
      return (System.String) var;
    }  }


  }

  public class CURR_STATEEventArgs : System.EventArgs
  {
    IHMIAccessorService accessorService;
    int channelId;
    int cookie; 
    int eventIndex;

    public CURR_STATEEventArgs(int channelId, int cookie, int eventIndex)
    {
      this.accessorService = (IHMIAccessorService)ServiceProvider.GetService(typeof(IHMIAccessorService));
      this.channelId = channelId;
      this.cookie = cookie;
      this.eventIndex = eventIndex;
    }
    public bool Get_CurrPhaseState(ref System.String value)
    {
      if (accessorService == null)
        return false;
      string var = null;
      bool ret = accessorService.GetStringValue(channelId, cookie, eventIndex, true,0, ref var);
      if (ret) value = (System.String) var;
      return ret;
    }

    public System.String CurrPhaseState
    { get {
      if (accessorService == null)
        return null;
      string var = null;
      bool ret = accessorService.GetStringValue(channelId, cookie, eventIndex, true,0, ref var);
      if (!ret) return null;
      return (System.String) var;
    }  }

    public bool Get_Grafcet(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,1, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? Grafcet
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,1, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }

    public bool Get_PrevState(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,2, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? PrevState
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,2, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }

    public bool Get_PrevPrevState(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,3, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? PrevPrevState
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,3, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }


  }

  public class CURR_TIMEEventArgs : System.EventArgs
  {
    IHMIAccessorService accessorService;
    int channelId;
    int cookie; 
    int eventIndex;

    public CURR_TIMEEventArgs(int channelId, int cookie, int eventIndex)
    {
      this.accessorService = (IHMIAccessorService)ServiceProvider.GetService(typeof(IHMIAccessorService));
      this.channelId = channelId;
      this.cookie = cookie;
      this.eventIndex = eventIndex;
    }
    public bool Get_CurrPhaseTime(ref System.UInt32 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,0, ref var);
      if (ret) value = (System.UInt32) var;
      return ret;
    }

    public System.UInt32? CurrPhaseTime
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,0, ref var);
      if (!ret) return null;
      return (System.UInt32) var;
    }  }


  }

  public class CURR_MODEEventArgs : System.EventArgs
  {
    IHMIAccessorService accessorService;
    int channelId;
    int cookie; 
    int eventIndex;

    public CURR_MODEEventArgs(int channelId, int cookie, int eventIndex)
    {
      this.accessorService = (IHMIAccessorService)ServiceProvider.GetService(typeof(IHMIAccessorService));
      this.channelId = channelId;
      this.cookie = cookie;
      this.eventIndex = eventIndex;
    }
    public bool Get_CurrMode(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,0, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? CurrMode
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,0, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }


  }

  public class REQ_ITEMSEventArgs : System.EventArgs
  {
    IHMIAccessorService accessorService;
    int channelId;
    int cookie; 
    int eventIndex;

    public REQ_ITEMSEventArgs(int channelId, int cookie, int eventIndex)
    {
      this.accessorService = (IHMIAccessorService)ServiceProvider.GetService(typeof(IHMIAccessorService));
      this.channelId = channelId;
      this.cookie = cookie;
      this.eventIndex = eventIndex;
    }
    public bool Get_item1(ref System.String value)
    {
      if (accessorService == null)
        return false;
      string var = null;
      bool ret = accessorService.GetStringValue(channelId, cookie, eventIndex, true,0, ref var);
      if (ret) value = (System.String) var;
      return ret;
    }

    public System.String item1
    { get {
      if (accessorService == null)
        return null;
      string var = null;
      bool ret = accessorService.GetStringValue(channelId, cookie, eventIndex, true,0, ref var);
      if (!ret) return null;
      return (System.String) var;
    }  }

    public bool Get_item2(ref System.String value)
    {
      if (accessorService == null)
        return false;
      string var = null;
      bool ret = accessorService.GetStringValue(channelId, cookie, eventIndex, true,1, ref var);
      if (ret) value = (System.String) var;
      return ret;
    }

    public System.String item2
    { get {
      if (accessorService == null)
        return null;
      string var = null;
      bool ret = accessorService.GetStringValue(channelId, cookie, eventIndex, true,1, ref var);
      if (!ret) return null;
      return (System.String) var;
    }  }

    public bool Get_item3(ref System.String value)
    {
      if (accessorService == null)
        return false;
      string var = null;
      bool ret = accessorService.GetStringValue(channelId, cookie, eventIndex, true,2, ref var);
      if (ret) value = (System.String) var;
      return ret;
    }

    public System.String item3
    { get {
      if (accessorService == null)
        return null;
      string var = null;
      bool ret = accessorService.GetStringValue(channelId, cookie, eventIndex, true,2, ref var);
      if (!ret) return null;
      return (System.String) var;
    }  }

    public bool Get_item4(ref System.String value)
    {
      if (accessorService == null)
        return false;
      string var = null;
      bool ret = accessorService.GetStringValue(channelId, cookie, eventIndex, true,3, ref var);
      if (ret) value = (System.String) var;
      return ret;
    }

    public System.String item4
    { get {
      if (accessorService == null)
        return null;
      string var = null;
      bool ret = accessorService.GetStringValue(channelId, cookie, eventIndex, true,3, ref var);
      if (!ret) return null;
      return (System.String) var;
    }  }

    public bool Get_item5(ref System.String value)
    {
      if (accessorService == null)
        return false;
      string var = null;
      bool ret = accessorService.GetStringValue(channelId, cookie, eventIndex, true,4, ref var);
      if (ret) value = (System.String) var;
      return ret;
    }

    public System.String item5
    { get {
      if (accessorService == null)
        return null;
      string var = null;
      bool ret = accessorService.GetStringValue(channelId, cookie, eventIndex, true,4, ref var);
      if (!ret) return null;
      return (System.String) var;
    }  }

    public bool Get_item6(ref System.String value)
    {
      if (accessorService == null)
        return false;
      string var = null;
      bool ret = accessorService.GetStringValue(channelId, cookie, eventIndex, true,5, ref var);
      if (ret) value = (System.String) var;
      return ret;
    }

    public System.String item6
    { get {
      if (accessorService == null)
        return null;
      string var = null;
      bool ret = accessorService.GetStringValue(channelId, cookie, eventIndex, true,5, ref var);
      if (!ret) return null;
      return (System.String) var;
    }  }

    public bool Get_item7(ref System.String value)
    {
      if (accessorService == null)
        return false;
      string var = null;
      bool ret = accessorService.GetStringValue(channelId, cookie, eventIndex, true,6, ref var);
      if (ret) value = (System.String) var;
      return ret;
    }

    public System.String item7
    { get {
      if (accessorService == null)
        return null;
      string var = null;
      bool ret = accessorService.GetStringValue(channelId, cookie, eventIndex, true,6, ref var);
      if (!ret) return null;
      return (System.String) var;
    }  }

    public bool Get_item8(ref System.String value)
    {
      if (accessorService == null)
        return false;
      string var = null;
      bool ret = accessorService.GetStringValue(channelId, cookie, eventIndex, true,7, ref var);
      if (ret) value = (System.String) var;
      return ret;
    }

    public System.String item8
    { get {
      if (accessorService == null)
        return null;
      string var = null;
      bool ret = accessorService.GetStringValue(channelId, cookie, eventIndex, true,7, ref var);
      if (!ret) return null;
      return (System.String) var;
    }  }

    public bool Get_itemsValues1(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,8, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? itemsValues1
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,8, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }

    public bool Get_itemsValues2(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,9, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? itemsValues2
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,9, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }

    public bool Get_item9(ref System.String value)
    {
      if (accessorService == null)
        return false;
      string var = null;
      bool ret = accessorService.GetStringValue(channelId, cookie, eventIndex, true,10, ref var);
      if (ret) value = (System.String) var;
      return ret;
    }

    public System.String item9
    { get {
      if (accessorService == null)
        return null;
      string var = null;
      bool ret = accessorService.GetStringValue(channelId, cookie, eventIndex, true,10, ref var);
      if (!ret) return null;
      return (System.String) var;
    }  }

    public bool Get_item10(ref System.String value)
    {
      if (accessorService == null)
        return false;
      string var = null;
      bool ret = accessorService.GetStringValue(channelId, cookie, eventIndex, true,11, ref var);
      if (ret) value = (System.String) var;
      return ret;
    }

    public System.String item10
    { get {
      if (accessorService == null)
        return null;
      string var = null;
      bool ret = accessorService.GetStringValue(channelId, cookie, eventIndex, true,11, ref var);
      if (!ret) return null;
      return (System.String) var;
    }  }

    public bool Get_item11(ref System.String value)
    {
      if (accessorService == null)
        return false;
      string var = null;
      bool ret = accessorService.GetStringValue(channelId, cookie, eventIndex, true,12, ref var);
      if (ret) value = (System.String) var;
      return ret;
    }

    public System.String item11
    { get {
      if (accessorService == null)
        return null;
      string var = null;
      bool ret = accessorService.GetStringValue(channelId, cookie, eventIndex, true,12, ref var);
      if (!ret) return null;
      return (System.String) var;
    }  }

    public bool Get_item12(ref System.String value)
    {
      if (accessorService == null)
        return false;
      string var = null;
      bool ret = accessorService.GetStringValue(channelId, cookie, eventIndex, true,13, ref var);
      if (ret) value = (System.String) var;
      return ret;
    }

    public System.String item12
    { get {
      if (accessorService == null)
        return null;
      string var = null;
      bool ret = accessorService.GetStringValue(channelId, cookie, eventIndex, true,13, ref var);
      if (!ret) return null;
      return (System.String) var;
    }  }

    public bool Get_item13(ref System.String value)
    {
      if (accessorService == null)
        return false;
      string var = null;
      bool ret = accessorService.GetStringValue(channelId, cookie, eventIndex, true,14, ref var);
      if (ret) value = (System.String) var;
      return ret;
    }

    public System.String item13
    { get {
      if (accessorService == null)
        return null;
      string var = null;
      bool ret = accessorService.GetStringValue(channelId, cookie, eventIndex, true,14, ref var);
      if (!ret) return null;
      return (System.String) var;
    }  }

    public bool Get_item14(ref System.String value)
    {
      if (accessorService == null)
        return false;
      string var = null;
      bool ret = accessorService.GetStringValue(channelId, cookie, eventIndex, true,15, ref var);
      if (ret) value = (System.String) var;
      return ret;
    }

    public System.String item14
    { get {
      if (accessorService == null)
        return null;
      string var = null;
      bool ret = accessorService.GetStringValue(channelId, cookie, eventIndex, true,15, ref var);
      if (!ret) return null;
      return (System.String) var;
    }  }

    public bool Get_item15(ref System.String value)
    {
      if (accessorService == null)
        return false;
      string var = null;
      bool ret = accessorService.GetStringValue(channelId, cookie, eventIndex, true,16, ref var);
      if (ret) value = (System.String) var;
      return ret;
    }

    public System.String item15
    { get {
      if (accessorService == null)
        return null;
      string var = null;
      bool ret = accessorService.GetStringValue(channelId, cookie, eventIndex, true,16, ref var);
      if (!ret) return null;
      return (System.String) var;
    }  }

    public bool Get_item16(ref System.String value)
    {
      if (accessorService == null)
        return false;
      string var = null;
      bool ret = accessorService.GetStringValue(channelId, cookie, eventIndex, true,17, ref var);
      if (ret) value = (System.String) var;
      return ret;
    }

    public System.String item16
    { get {
      if (accessorService == null)
        return null;
      string var = null;
      bool ret = accessorService.GetStringValue(channelId, cookie, eventIndex, true,17, ref var);
      if (!ret) return null;
      return (System.String) var;
    }  }

    public bool Get_itemsValues3(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,18, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? itemsValues3
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,18, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }

    public bool Get_itemsValues4(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,19, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? itemsValues4
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,19, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }


  }

  public class RESET_FORCE_TRSEventArgs : System.EventArgs
  {
    IHMIAccessorService accessorService;
    int channelId;
    int cookie; 
    int eventIndex;

    public RESET_FORCE_TRSEventArgs(int channelId, int cookie, int eventIndex)
    {
      this.accessorService = (IHMIAccessorService)ServiceProvider.GetService(typeof(IHMIAccessorService));
      this.channelId = channelId;
      this.cookie = cookie;
      this.eventIndex = eventIndex;
    }

  }

  public class RESET_BTN_MANEventArgs : System.EventArgs
  {
    IHMIAccessorService accessorService;
    int channelId;
    int cookie; 
    int eventIndex;

    public RESET_BTN_MANEventArgs(int channelId, int cookie, int eventIndex)
    {
      this.accessorService = (IHMIAccessorService)ServiceProvider.GetService(typeof(IHMIAccessorService));
      this.channelId = channelId;
      this.cookie = cookie;
      this.eventIndex = eventIndex;
    }

  }

}

namespace SE.Nereda.Symbols.Phase
{

  public class MAN_STARTEventArgs : System.EventArgs
  {
    public MAN_STARTEventArgs()
    {
    }
    private System.Boolean? ManStart_field = null;
    public System.Boolean? ManStart
    {
       get { return ManStart_field; }
       set { ManStart_field = value; }
    }

  }

  public class MAN_STOPEventArgs : System.EventArgs
  {
    public MAN_STOPEventArgs()
    {
    }
    private System.Boolean? ManStop_field = null;
    public System.Boolean? ManStop
    {
       get { return ManStop_field; }
       set { ManStop_field = value; }
    }

  }

  public class MAN_RESETEventArgs : System.EventArgs
  {
    public MAN_RESETEventArgs()
    {
    }
    private System.Boolean? ManReset_field = null;
    public System.Boolean? ManReset
    {
       get { return ManReset_field; }
       set { ManReset_field = value; }
    }

  }

  public class NEREDA_C_STARTEventArgs : System.EventArgs
  {
    public NEREDA_C_STARTEventArgs()
    {
    }
    private System.Boolean? NeredaCtrllerStart_field = null;
    public System.Boolean? NeredaCtrllerStart
    {
       get { return NeredaCtrllerStart_field; }
       set { NeredaCtrllerStart_field = value; }
    }

  }

  public class NEREDA_C_STOPEventArgs : System.EventArgs
  {
    public NEREDA_C_STOPEventArgs()
    {
    }
    private System.Boolean? NeredaCtrllerStop_field = null;
    public System.Boolean? NeredaCtrllerStop
    {
       get { return NeredaCtrllerStop_field; }
       set { NeredaCtrllerStop_field = value; }
    }

  }

  public class NEREDA_C_RESETEventArgs : System.EventArgs
  {
    public NEREDA_C_RESETEventArgs()
    {
    }
    private System.Boolean? NeredaCtrllerReset_field = null;
    public System.Boolean? NeredaCtrllerReset
    {
       get { return NeredaCtrllerReset_field; }
       set { NeredaCtrllerReset_field = value; }
    }

  }

  public class FORCEEventArgs : System.EventArgs
  {
    public FORCEEventArgs()
    {
    }
    private System.Int16? TrsForce_field = null;
    public System.Int16? TrsForce
    {
       get { return TrsForce_field; }
       set { TrsForce_field = value; }
    }

  }

}

namespace SE.Nereda.Symbols.Phase
{
  partial class sDefault
  {

    private event EventHandler<SE.Nereda.Symbols.Phase.REQ_STATEEventArgs> REQ_STATE_Fired;

    private event EventHandler<SE.Nereda.Symbols.Phase.REQ_PHASE_NAMEEventArgs> REQ_PHASE_NAME_Fired;

    private event EventHandler<SE.Nereda.Symbols.Phase.CURR_STATEEventArgs> CURR_STATE_Fired;

    private event EventHandler<SE.Nereda.Symbols.Phase.CURR_TIMEEventArgs> CURR_TIME_Fired;

    private event EventHandler<SE.Nereda.Symbols.Phase.CURR_MODEEventArgs> CURR_MODE_Fired;

    private event EventHandler<SE.Nereda.Symbols.Phase.REQ_ITEMSEventArgs> REQ_ITEMS_Fired;

    private event EventHandler<SE.Nereda.Symbols.Phase.RESET_FORCE_TRSEventArgs> RESET_FORCE_TRS_Fired;

    private event EventHandler<SE.Nereda.Symbols.Phase.RESET_BTN_MANEventArgs> RESET_BTN_MAN_Fired;

    protected override void OnEndInit()
    {
      if (REQ_STATE_Fired != null)
        AttachEventInput(0);
      if (REQ_PHASE_NAME_Fired != null)
        AttachEventInput(1);
      if (CURR_STATE_Fired != null)
        AttachEventInput(2);
      if (CURR_TIME_Fired != null)
        AttachEventInput(3);
      if (CURR_MODE_Fired != null)
        AttachEventInput(4);
      if (REQ_ITEMS_Fired != null)
        AttachEventInput(5);
      if (RESET_FORCE_TRS_Fired != null)
        AttachEventInput(6);
      if (RESET_BTN_MAN_Fired != null)
        AttachEventInput(7);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (REQ_STATE_Fired != null)
          {
            try
            {
              REQ_STATE_Fired(this, new SE.Nereda.Symbols.Phase.REQ_STATEEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REQ_STATE_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 1:
          if (REQ_PHASE_NAME_Fired != null)
          {
            try
            {
              REQ_PHASE_NAME_Fired(this, new SE.Nereda.Symbols.Phase.REQ_PHASE_NAMEEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REQ_PHASE_NAME_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 2:
          if (CURR_STATE_Fired != null)
          {
            try
            {
              CURR_STATE_Fired(this, new SE.Nereda.Symbols.Phase.CURR_STATEEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","CURR_STATE_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 3:
          if (CURR_TIME_Fired != null)
          {
            try
            {
              CURR_TIME_Fired(this, new SE.Nereda.Symbols.Phase.CURR_TIMEEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","CURR_TIME_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 4:
          if (CURR_MODE_Fired != null)
          {
            try
            {
              CURR_MODE_Fired(this, new SE.Nereda.Symbols.Phase.CURR_MODEEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","CURR_MODE_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 5:
          if (REQ_ITEMS_Fired != null)
          {
            try
            {
              REQ_ITEMS_Fired(this, new SE.Nereda.Symbols.Phase.REQ_ITEMSEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REQ_ITEMS_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 6:
          if (RESET_FORCE_TRS_Fired != null)
          {
            try
            {
              RESET_FORCE_TRS_Fired(this, new SE.Nereda.Symbols.Phase.RESET_FORCE_TRSEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","RESET_FORCE_TRS_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 7:
          if (RESET_BTN_MAN_Fired != null)
          {
            try
            {
              RESET_BTN_MAN_Fired(this, new SE.Nereda.Symbols.Phase.RESET_BTN_MANEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","RESET_BTN_MAN_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_MAN_START(System.Boolean ManStart)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {ManStart});
    }
    public bool FireEvent_MAN_START(SE.Nereda.Symbols.Phase.MAN_STARTEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.ManStart.HasValue) _values_[0] = ea.ManStart.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_MAN_START(System.Boolean ManStart, bool ignore_ManStart)
    {
      object[] _values_ = new object[1];
      if (!ignore_ManStart) _values_[0] = ManStart;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_MAN_STOP(System.Boolean ManStop)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {ManStop});
    }
    public bool FireEvent_MAN_STOP(SE.Nereda.Symbols.Phase.MAN_STOPEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.ManStop.HasValue) _values_[0] = ea.ManStop.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_MAN_STOP(System.Boolean ManStop, bool ignore_ManStop)
    {
      object[] _values_ = new object[1];
      if (!ignore_ManStop) _values_[0] = ManStop;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_MAN_RESET(System.Boolean ManReset)
    {
      return ((IHMIAccessorOutput)this).FireEvent(2, new object[] {ManReset});
    }
    public bool FireEvent_MAN_RESET(SE.Nereda.Symbols.Phase.MAN_RESETEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.ManReset.HasValue) _values_[0] = ea.ManReset.Value;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_MAN_RESET(System.Boolean ManReset, bool ignore_ManReset)
    {
      object[] _values_ = new object[1];
      if (!ignore_ManReset) _values_[0] = ManReset;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_NEREDA_C_START(System.Boolean NeredaCtrllerStart)
    {
      return ((IHMIAccessorOutput)this).FireEvent(3, new object[] {NeredaCtrllerStart});
    }
    public bool FireEvent_NEREDA_C_START(SE.Nereda.Symbols.Phase.NEREDA_C_STARTEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.NeredaCtrllerStart.HasValue) _values_[0] = ea.NeredaCtrllerStart.Value;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_NEREDA_C_START(System.Boolean NeredaCtrllerStart, bool ignore_NeredaCtrllerStart)
    {
      object[] _values_ = new object[1];
      if (!ignore_NeredaCtrllerStart) _values_[0] = NeredaCtrllerStart;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_NEREDA_C_STOP(System.Boolean NeredaCtrllerStop)
    {
      return ((IHMIAccessorOutput)this).FireEvent(4, new object[] {NeredaCtrllerStop});
    }
    public bool FireEvent_NEREDA_C_STOP(SE.Nereda.Symbols.Phase.NEREDA_C_STOPEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.NeredaCtrllerStop.HasValue) _values_[0] = ea.NeredaCtrllerStop.Value;
      return ((IHMIAccessorOutput)this).FireEvent(4, _values_);
    }
    public bool FireEvent_NEREDA_C_STOP(System.Boolean NeredaCtrllerStop, bool ignore_NeredaCtrllerStop)
    {
      object[] _values_ = new object[1];
      if (!ignore_NeredaCtrllerStop) _values_[0] = NeredaCtrllerStop;
      return ((IHMIAccessorOutput)this).FireEvent(4, _values_);
    }
    public bool FireEvent_NEREDA_C_RESET(System.Boolean NeredaCtrllerReset)
    {
      return ((IHMIAccessorOutput)this).FireEvent(5, new object[] {NeredaCtrllerReset});
    }
    public bool FireEvent_NEREDA_C_RESET(SE.Nereda.Symbols.Phase.NEREDA_C_RESETEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.NeredaCtrllerReset.HasValue) _values_[0] = ea.NeredaCtrllerReset.Value;
      return ((IHMIAccessorOutput)this).FireEvent(5, _values_);
    }
    public bool FireEvent_NEREDA_C_RESET(System.Boolean NeredaCtrllerReset, bool ignore_NeredaCtrllerReset)
    {
      object[] _values_ = new object[1];
      if (!ignore_NeredaCtrllerReset) _values_[0] = NeredaCtrllerReset;
      return ((IHMIAccessorOutput)this).FireEvent(5, _values_);
    }
    public bool FireEvent_FORCE(System.Int16 TrsForce)
    {
      return ((IHMIAccessorOutput)this).FireEvent(6, new object[] {TrsForce});
    }
    public bool FireEvent_FORCE(SE.Nereda.Symbols.Phase.FORCEEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.TrsForce.HasValue) _values_[0] = ea.TrsForce.Value;
      return ((IHMIAccessorOutput)this).FireEvent(6, _values_);
    }
    public bool FireEvent_FORCE(System.Int16 TrsForce, bool ignore_TrsForce)
    {
      object[] _values_ = new object[1];
      if (!ignore_TrsForce) _values_[0] = TrsForce;
      return ((IHMIAccessorOutput)this).FireEvent(6, _values_);
    }

  }
}

namespace SE.Nereda.Faceplates.Phase
{
  partial class fpDefault
  {

    private event EventHandler<SE.Nereda.Symbols.Phase.REQ_STATEEventArgs> REQ_STATE_Fired;

    private event EventHandler<SE.Nereda.Symbols.Phase.REQ_PHASE_NAMEEventArgs> REQ_PHASE_NAME_Fired;

    private event EventHandler<SE.Nereda.Symbols.Phase.CURR_STATEEventArgs> CURR_STATE_Fired;

    private event EventHandler<SE.Nereda.Symbols.Phase.CURR_TIMEEventArgs> CURR_TIME_Fired;

    private event EventHandler<SE.Nereda.Symbols.Phase.CURR_MODEEventArgs> CURR_MODE_Fired;

    private event EventHandler<SE.Nereda.Symbols.Phase.REQ_ITEMSEventArgs> REQ_ITEMS_Fired;

    private event EventHandler<SE.Nereda.Symbols.Phase.RESET_FORCE_TRSEventArgs> RESET_FORCE_TRS_Fired;

    private event EventHandler<SE.Nereda.Symbols.Phase.RESET_BTN_MANEventArgs> RESET_BTN_MAN_Fired;

    protected override void OnEndInit()
    {
      if (REQ_STATE_Fired != null)
        AttachEventInput(0);
      if (REQ_PHASE_NAME_Fired != null)
        AttachEventInput(1);
      if (CURR_STATE_Fired != null)
        AttachEventInput(2);
      if (CURR_TIME_Fired != null)
        AttachEventInput(3);
      if (CURR_MODE_Fired != null)
        AttachEventInput(4);
      if (REQ_ITEMS_Fired != null)
        AttachEventInput(5);
      if (RESET_FORCE_TRS_Fired != null)
        AttachEventInput(6);
      if (RESET_BTN_MAN_Fired != null)
        AttachEventInput(7);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (REQ_STATE_Fired != null)
          {
            try
            {
              REQ_STATE_Fired(this, new SE.Nereda.Symbols.Phase.REQ_STATEEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REQ_STATE_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 1:
          if (REQ_PHASE_NAME_Fired != null)
          {
            try
            {
              REQ_PHASE_NAME_Fired(this, new SE.Nereda.Symbols.Phase.REQ_PHASE_NAMEEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REQ_PHASE_NAME_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 2:
          if (CURR_STATE_Fired != null)
          {
            try
            {
              CURR_STATE_Fired(this, new SE.Nereda.Symbols.Phase.CURR_STATEEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","CURR_STATE_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 3:
          if (CURR_TIME_Fired != null)
          {
            try
            {
              CURR_TIME_Fired(this, new SE.Nereda.Symbols.Phase.CURR_TIMEEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","CURR_TIME_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 4:
          if (CURR_MODE_Fired != null)
          {
            try
            {
              CURR_MODE_Fired(this, new SE.Nereda.Symbols.Phase.CURR_MODEEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","CURR_MODE_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 5:
          if (REQ_ITEMS_Fired != null)
          {
            try
            {
              REQ_ITEMS_Fired(this, new SE.Nereda.Symbols.Phase.REQ_ITEMSEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REQ_ITEMS_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 6:
          if (RESET_FORCE_TRS_Fired != null)
          {
            try
            {
              RESET_FORCE_TRS_Fired(this, new SE.Nereda.Symbols.Phase.RESET_FORCE_TRSEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","RESET_FORCE_TRS_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 7:
          if (RESET_BTN_MAN_Fired != null)
          {
            try
            {
              RESET_BTN_MAN_Fired(this, new SE.Nereda.Symbols.Phase.RESET_BTN_MANEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","RESET_BTN_MAN_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_MAN_START(System.Boolean ManStart)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {ManStart});
    }
    public bool FireEvent_MAN_START(SE.Nereda.Symbols.Phase.MAN_STARTEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.ManStart.HasValue) _values_[0] = ea.ManStart.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_MAN_START(System.Boolean ManStart, bool ignore_ManStart)
    {
      object[] _values_ = new object[1];
      if (!ignore_ManStart) _values_[0] = ManStart;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_MAN_STOP(System.Boolean ManStop)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {ManStop});
    }
    public bool FireEvent_MAN_STOP(SE.Nereda.Symbols.Phase.MAN_STOPEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.ManStop.HasValue) _values_[0] = ea.ManStop.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_MAN_STOP(System.Boolean ManStop, bool ignore_ManStop)
    {
      object[] _values_ = new object[1];
      if (!ignore_ManStop) _values_[0] = ManStop;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_MAN_RESET(System.Boolean ManReset)
    {
      return ((IHMIAccessorOutput)this).FireEvent(2, new object[] {ManReset});
    }
    public bool FireEvent_MAN_RESET(SE.Nereda.Symbols.Phase.MAN_RESETEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.ManReset.HasValue) _values_[0] = ea.ManReset.Value;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_MAN_RESET(System.Boolean ManReset, bool ignore_ManReset)
    {
      object[] _values_ = new object[1];
      if (!ignore_ManReset) _values_[0] = ManReset;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_NEREDA_C_START(System.Boolean NeredaCtrllerStart)
    {
      return ((IHMIAccessorOutput)this).FireEvent(3, new object[] {NeredaCtrllerStart});
    }
    public bool FireEvent_NEREDA_C_START(SE.Nereda.Symbols.Phase.NEREDA_C_STARTEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.NeredaCtrllerStart.HasValue) _values_[0] = ea.NeredaCtrllerStart.Value;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_NEREDA_C_START(System.Boolean NeredaCtrllerStart, bool ignore_NeredaCtrllerStart)
    {
      object[] _values_ = new object[1];
      if (!ignore_NeredaCtrllerStart) _values_[0] = NeredaCtrllerStart;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_NEREDA_C_STOP(System.Boolean NeredaCtrllerStop)
    {
      return ((IHMIAccessorOutput)this).FireEvent(4, new object[] {NeredaCtrllerStop});
    }
    public bool FireEvent_NEREDA_C_STOP(SE.Nereda.Symbols.Phase.NEREDA_C_STOPEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.NeredaCtrllerStop.HasValue) _values_[0] = ea.NeredaCtrllerStop.Value;
      return ((IHMIAccessorOutput)this).FireEvent(4, _values_);
    }
    public bool FireEvent_NEREDA_C_STOP(System.Boolean NeredaCtrllerStop, bool ignore_NeredaCtrllerStop)
    {
      object[] _values_ = new object[1];
      if (!ignore_NeredaCtrllerStop) _values_[0] = NeredaCtrllerStop;
      return ((IHMIAccessorOutput)this).FireEvent(4, _values_);
    }
    public bool FireEvent_NEREDA_C_RESET(System.Boolean NeredaCtrllerReset)
    {
      return ((IHMIAccessorOutput)this).FireEvent(5, new object[] {NeredaCtrllerReset});
    }
    public bool FireEvent_NEREDA_C_RESET(SE.Nereda.Symbols.Phase.NEREDA_C_RESETEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.NeredaCtrllerReset.HasValue) _values_[0] = ea.NeredaCtrllerReset.Value;
      return ((IHMIAccessorOutput)this).FireEvent(5, _values_);
    }
    public bool FireEvent_NEREDA_C_RESET(System.Boolean NeredaCtrllerReset, bool ignore_NeredaCtrllerReset)
    {
      object[] _values_ = new object[1];
      if (!ignore_NeredaCtrllerReset) _values_[0] = NeredaCtrllerReset;
      return ((IHMIAccessorOutput)this).FireEvent(5, _values_);
    }
    public bool FireEvent_FORCE(System.Int16 TrsForce)
    {
      return ((IHMIAccessorOutput)this).FireEvent(6, new object[] {TrsForce});
    }
    public bool FireEvent_FORCE(SE.Nereda.Symbols.Phase.FORCEEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.TrsForce.HasValue) _values_[0] = ea.TrsForce.Value;
      return ((IHMIAccessorOutput)this).FireEvent(6, _values_);
    }
    public bool FireEvent_FORCE(System.Int16 TrsForce, bool ignore_TrsForce)
    {
      object[] _values_ = new object[1];
      if (!ignore_TrsForce) _values_[0] = TrsForce;
      return ((IHMIAccessorOutput)this).FireEvent(6, _values_);
    }

  }
}

namespace SE.Nereda.Faceplates.Phase
{
  partial class fpOpCdt
  {

    private event EventHandler<SE.Nereda.Symbols.Phase.REQ_STATEEventArgs> REQ_STATE_Fired;

    private event EventHandler<SE.Nereda.Symbols.Phase.REQ_PHASE_NAMEEventArgs> REQ_PHASE_NAME_Fired;

    private event EventHandler<SE.Nereda.Symbols.Phase.CURR_STATEEventArgs> CURR_STATE_Fired;

    private event EventHandler<SE.Nereda.Symbols.Phase.CURR_TIMEEventArgs> CURR_TIME_Fired;

    private event EventHandler<SE.Nereda.Symbols.Phase.CURR_MODEEventArgs> CURR_MODE_Fired;

    private event EventHandler<SE.Nereda.Symbols.Phase.REQ_ITEMSEventArgs> REQ_ITEMS_Fired;

    private event EventHandler<SE.Nereda.Symbols.Phase.RESET_FORCE_TRSEventArgs> RESET_FORCE_TRS_Fired;

    private event EventHandler<SE.Nereda.Symbols.Phase.RESET_BTN_MANEventArgs> RESET_BTN_MAN_Fired;

    protected override void OnEndInit()
    {
      if (REQ_STATE_Fired != null)
        AttachEventInput(0);
      if (REQ_PHASE_NAME_Fired != null)
        AttachEventInput(1);
      if (CURR_STATE_Fired != null)
        AttachEventInput(2);
      if (CURR_TIME_Fired != null)
        AttachEventInput(3);
      if (CURR_MODE_Fired != null)
        AttachEventInput(4);
      if (REQ_ITEMS_Fired != null)
        AttachEventInput(5);
      if (RESET_FORCE_TRS_Fired != null)
        AttachEventInput(6);
      if (RESET_BTN_MAN_Fired != null)
        AttachEventInput(7);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (REQ_STATE_Fired != null)
          {
            try
            {
              REQ_STATE_Fired(this, new SE.Nereda.Symbols.Phase.REQ_STATEEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REQ_STATE_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 1:
          if (REQ_PHASE_NAME_Fired != null)
          {
            try
            {
              REQ_PHASE_NAME_Fired(this, new SE.Nereda.Symbols.Phase.REQ_PHASE_NAMEEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REQ_PHASE_NAME_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 2:
          if (CURR_STATE_Fired != null)
          {
            try
            {
              CURR_STATE_Fired(this, new SE.Nereda.Symbols.Phase.CURR_STATEEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","CURR_STATE_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 3:
          if (CURR_TIME_Fired != null)
          {
            try
            {
              CURR_TIME_Fired(this, new SE.Nereda.Symbols.Phase.CURR_TIMEEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","CURR_TIME_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 4:
          if (CURR_MODE_Fired != null)
          {
            try
            {
              CURR_MODE_Fired(this, new SE.Nereda.Symbols.Phase.CURR_MODEEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","CURR_MODE_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 5:
          if (REQ_ITEMS_Fired != null)
          {
            try
            {
              REQ_ITEMS_Fired(this, new SE.Nereda.Symbols.Phase.REQ_ITEMSEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REQ_ITEMS_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 6:
          if (RESET_FORCE_TRS_Fired != null)
          {
            try
            {
              RESET_FORCE_TRS_Fired(this, new SE.Nereda.Symbols.Phase.RESET_FORCE_TRSEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","RESET_FORCE_TRS_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 7:
          if (RESET_BTN_MAN_Fired != null)
          {
            try
            {
              RESET_BTN_MAN_Fired(this, new SE.Nereda.Symbols.Phase.RESET_BTN_MANEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","RESET_BTN_MAN_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_MAN_START(System.Boolean ManStart)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {ManStart});
    }
    public bool FireEvent_MAN_START(SE.Nereda.Symbols.Phase.MAN_STARTEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.ManStart.HasValue) _values_[0] = ea.ManStart.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_MAN_START(System.Boolean ManStart, bool ignore_ManStart)
    {
      object[] _values_ = new object[1];
      if (!ignore_ManStart) _values_[0] = ManStart;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_MAN_STOP(System.Boolean ManStop)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {ManStop});
    }
    public bool FireEvent_MAN_STOP(SE.Nereda.Symbols.Phase.MAN_STOPEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.ManStop.HasValue) _values_[0] = ea.ManStop.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_MAN_STOP(System.Boolean ManStop, bool ignore_ManStop)
    {
      object[] _values_ = new object[1];
      if (!ignore_ManStop) _values_[0] = ManStop;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_MAN_RESET(System.Boolean ManReset)
    {
      return ((IHMIAccessorOutput)this).FireEvent(2, new object[] {ManReset});
    }
    public bool FireEvent_MAN_RESET(SE.Nereda.Symbols.Phase.MAN_RESETEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.ManReset.HasValue) _values_[0] = ea.ManReset.Value;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_MAN_RESET(System.Boolean ManReset, bool ignore_ManReset)
    {
      object[] _values_ = new object[1];
      if (!ignore_ManReset) _values_[0] = ManReset;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_NEREDA_C_START(System.Boolean NeredaCtrllerStart)
    {
      return ((IHMIAccessorOutput)this).FireEvent(3, new object[] {NeredaCtrllerStart});
    }
    public bool FireEvent_NEREDA_C_START(SE.Nereda.Symbols.Phase.NEREDA_C_STARTEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.NeredaCtrllerStart.HasValue) _values_[0] = ea.NeredaCtrllerStart.Value;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_NEREDA_C_START(System.Boolean NeredaCtrllerStart, bool ignore_NeredaCtrllerStart)
    {
      object[] _values_ = new object[1];
      if (!ignore_NeredaCtrllerStart) _values_[0] = NeredaCtrllerStart;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_NEREDA_C_STOP(System.Boolean NeredaCtrllerStop)
    {
      return ((IHMIAccessorOutput)this).FireEvent(4, new object[] {NeredaCtrllerStop});
    }
    public bool FireEvent_NEREDA_C_STOP(SE.Nereda.Symbols.Phase.NEREDA_C_STOPEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.NeredaCtrllerStop.HasValue) _values_[0] = ea.NeredaCtrllerStop.Value;
      return ((IHMIAccessorOutput)this).FireEvent(4, _values_);
    }
    public bool FireEvent_NEREDA_C_STOP(System.Boolean NeredaCtrllerStop, bool ignore_NeredaCtrllerStop)
    {
      object[] _values_ = new object[1];
      if (!ignore_NeredaCtrllerStop) _values_[0] = NeredaCtrllerStop;
      return ((IHMIAccessorOutput)this).FireEvent(4, _values_);
    }
    public bool FireEvent_NEREDA_C_RESET(System.Boolean NeredaCtrllerReset)
    {
      return ((IHMIAccessorOutput)this).FireEvent(5, new object[] {NeredaCtrllerReset});
    }
    public bool FireEvent_NEREDA_C_RESET(SE.Nereda.Symbols.Phase.NEREDA_C_RESETEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.NeredaCtrllerReset.HasValue) _values_[0] = ea.NeredaCtrllerReset.Value;
      return ((IHMIAccessorOutput)this).FireEvent(5, _values_);
    }
    public bool FireEvent_NEREDA_C_RESET(System.Boolean NeredaCtrllerReset, bool ignore_NeredaCtrllerReset)
    {
      object[] _values_ = new object[1];
      if (!ignore_NeredaCtrllerReset) _values_[0] = NeredaCtrllerReset;
      return ((IHMIAccessorOutput)this).FireEvent(5, _values_);
    }
    public bool FireEvent_FORCE(System.Int16 TrsForce)
    {
      return ((IHMIAccessorOutput)this).FireEvent(6, new object[] {TrsForce});
    }
    public bool FireEvent_FORCE(SE.Nereda.Symbols.Phase.FORCEEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.TrsForce.HasValue) _values_[0] = ea.TrsForce.Value;
      return ((IHMIAccessorOutput)this).FireEvent(6, _values_);
    }
    public bool FireEvent_FORCE(System.Int16 TrsForce, bool ignore_TrsForce)
    {
      object[] _values_ = new object[1];
      if (!ignore_TrsForce) _values_[0] = TrsForce;
      return ((IHMIAccessorOutput)this).FireEvent(6, _values_);
    }

  }
}
#endregion #Phase_HMI;

#endregion Definitions;
