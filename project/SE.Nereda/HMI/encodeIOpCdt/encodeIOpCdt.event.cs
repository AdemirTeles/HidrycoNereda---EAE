/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 6/7/2026
 * Time: 2:16 PM
 * 
 */
using System;
using NxtControl.GuiFramework;
using NxtControl.Services;

#region Definitions;
#region #encodeIOpCdt_HMI;

namespace SE.Nereda.Symbols.encodeIOpCdt
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

  public class OC_STATUSEventArgs : System.EventArgs
  {
    IHMIAccessorService accessorService;
    int channelId;
    int cookie; 
    int eventIndex;

    public OC_STATUSEventArgs(int channelId, int cookie, int eventIndex)
    {
      this.accessorService = (IHMIAccessorService)ServiceProvider.GetService(typeof(IHMIAccessorService));
      this.channelId = channelId;
      this.cookie = cookie;
      this.eventIndex = eventIndex;
    }
    public bool Get_OCStatus_Curr(ref System.UInt16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,0, ref var);
      if (ret) value = (System.UInt16) var;
      return ret;
    }

    public System.UInt16? OCStatus_Curr
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,0, ref var);
      if (!ret) return null;
      return (System.UInt16) var;
    }  }

    public bool Get_OCStatus1(ref System.UInt16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,1, ref var);
      if (ret) value = (System.UInt16) var;
      return ret;
    }

    public System.UInt16? OCStatus1
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,1, ref var);
      if (!ret) return null;
      return (System.UInt16) var;
    }  }

    public bool Get_OCStatus2(ref System.UInt16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,2, ref var);
      if (ret) value = (System.UInt16) var;
      return ret;
    }

    public System.UInt16? OCStatus2
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,2, ref var);
      if (!ret) return null;
      return (System.UInt16) var;
    }  }

    public bool Get_OCStatus3(ref System.UInt16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,3, ref var);
      if (ret) value = (System.UInt16) var;
      return ret;
    }

    public System.UInt16? OCStatus3
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,3, ref var);
      if (!ret) return null;
      return (System.UInt16) var;
    }  }

    public bool Get_OCStatus4(ref System.UInt16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,4, ref var);
      if (ret) value = (System.UInt16) var;
      return ret;
    }

    public System.UInt16? OCStatus4
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,4, ref var);
      if (!ret) return null;
      return (System.UInt16) var;
    }  }

    public bool Get_OCStatus5(ref System.UInt16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,5, ref var);
      if (ret) value = (System.UInt16) var;
      return ret;
    }

    public System.UInt16? OCStatus5
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,5, ref var);
      if (!ret) return null;
      return (System.UInt16) var;
    }  }

    public bool Get_OCStatus6(ref System.UInt16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,6, ref var);
      if (ret) value = (System.UInt16) var;
      return ret;
    }

    public System.UInt16? OCStatus6
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,6, ref var);
      if (!ret) return null;
      return (System.UInt16) var;
    }  }

    public bool Get_OCStatus7(ref System.UInt16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,7, ref var);
      if (ret) value = (System.UInt16) var;
      return ret;
    }

    public System.UInt16? OCStatus7
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,7, ref var);
      if (!ret) return null;
      return (System.UInt16) var;
    }  }

    public bool Get_OCStatus8(ref System.UInt16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,8, ref var);
      if (ret) value = (System.UInt16) var;
      return ret;
    }

    public System.UInt16? OCStatus8
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,8, ref var);
      if (!ret) return null;
      return (System.UInt16) var;
    }  }

    public bool Get_OCStatus9(ref System.UInt16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,9, ref var);
      if (ret) value = (System.UInt16) var;
      return ret;
    }

    public System.UInt16? OCStatus9
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,9, ref var);
      if (!ret) return null;
      return (System.UInt16) var;
    }  }


  }

}

namespace SE.Nereda.Symbols.encodeIOpCdt
{

  public class CNF_ITEMS_NAMEEventArgs : System.EventArgs
  {
    public CNF_ITEMS_NAMEEventArgs()
    {
    }
    private System.String itemsName1_field = null;
    public System.String itemsName1
    {
       get { return itemsName1_field; }
       set { itemsName1_field = value; }
    }
    private System.String itemsName2_field = null;
    public System.String itemsName2
    {
       get { return itemsName2_field; }
       set { itemsName2_field = value; }
    }
    private System.String itemsName3_field = null;
    public System.String itemsName3
    {
       get { return itemsName3_field; }
       set { itemsName3_field = value; }
    }
    private System.String itemsName4_field = null;
    public System.String itemsName4
    {
       get { return itemsName4_field; }
       set { itemsName4_field = value; }
    }
    private System.String itemsName5_field = null;
    public System.String itemsName5
    {
       get { return itemsName5_field; }
       set { itemsName5_field = value; }
    }
    private System.String itemsName6_field = null;
    public System.String itemsName6
    {
       get { return itemsName6_field; }
       set { itemsName6_field = value; }
    }
    private System.String itemsName7_field = null;
    public System.String itemsName7
    {
       get { return itemsName7_field; }
       set { itemsName7_field = value; }
    }
    private System.String itemsName8_field = null;
    public System.String itemsName8
    {
       get { return itemsName8_field; }
       set { itemsName8_field = value; }
    }
    private System.String itemsName9_field = null;
    public System.String itemsName9
    {
       get { return itemsName9_field; }
       set { itemsName9_field = value; }
    }
    private System.String itemsName10_field = null;
    public System.String itemsName10
    {
       get { return itemsName10_field; }
       set { itemsName10_field = value; }
    }
    private System.String itemsName11_field = null;
    public System.String itemsName11
    {
       get { return itemsName11_field; }
       set { itemsName11_field = value; }
    }
    private System.String itemsName12_field = null;
    public System.String itemsName12
    {
       get { return itemsName12_field; }
       set { itemsName12_field = value; }
    }
    private System.String itemsName13_field = null;
    public System.String itemsName13
    {
       get { return itemsName13_field; }
       set { itemsName13_field = value; }
    }
    private System.String itemsName14_field = null;
    public System.String itemsName14
    {
       get { return itemsName14_field; }
       set { itemsName14_field = value; }
    }
    private System.String itemsName15_field = null;
    public System.String itemsName15
    {
       get { return itemsName15_field; }
       set { itemsName15_field = value; }
    }
    private System.String itemsName16_field = null;
    public System.String itemsName16
    {
       get { return itemsName16_field; }
       set { itemsName16_field = value; }
    }

  }

}

namespace SE.Nereda.Symbols.encodeIOpCdt
{
  partial class sDefault
  {

    private event EventHandler<SE.Nereda.Symbols.encodeIOpCdt.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    private event EventHandler<SE.Nereda.Symbols.encodeIOpCdt.OC_STATUSEventArgs> OC_STATUS_Fired;

    protected override void OnEndInit()
    {
      if (LOAD_PERS_DATA_Fired != null)
        AttachEventInput(0);
      if (OC_STATUS_Fired != null)
        AttachEventInput(1);

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
              LOAD_PERS_DATA_Fired(this, new SE.Nereda.Symbols.encodeIOpCdt.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","LOAD_PERS_DATA_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 1:
          if (OC_STATUS_Fired != null)
          {
            try
            {
              OC_STATUS_Fired(this, new SE.Nereda.Symbols.encodeIOpCdt.OC_STATUSEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","OC_STATUS_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_CNF_ITEMS_NAME(System.String itemsName1, System.String itemsName2, System.String itemsName3, System.String itemsName4, System.String itemsName5, System.String itemsName6, System.String itemsName7, System.String itemsName8, System.String itemsName9, System.String itemsName10, System.String itemsName11, System.String itemsName12, System.String itemsName13, System.String itemsName14, System.String itemsName15, System.String itemsName16)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {itemsName1, itemsName2, itemsName3, itemsName4, itemsName5, itemsName6, itemsName7, itemsName8, itemsName9, itemsName10, itemsName11, itemsName12, itemsName13, itemsName14, itemsName15, itemsName16});
    }
    public bool FireEvent_CNF_ITEMS_NAME(SE.Nereda.Symbols.encodeIOpCdt.CNF_ITEMS_NAMEEventArgs ea)
    {
      object[] _values_ = new object[16];
      if (ea.itemsName1 != null) _values_[0] = ea.itemsName1;
      if (ea.itemsName2 != null) _values_[1] = ea.itemsName2;
      if (ea.itemsName3 != null) _values_[2] = ea.itemsName3;
      if (ea.itemsName4 != null) _values_[3] = ea.itemsName4;
      if (ea.itemsName5 != null) _values_[4] = ea.itemsName5;
      if (ea.itemsName6 != null) _values_[5] = ea.itemsName6;
      if (ea.itemsName7 != null) _values_[6] = ea.itemsName7;
      if (ea.itemsName8 != null) _values_[7] = ea.itemsName8;
      if (ea.itemsName9 != null) _values_[8] = ea.itemsName9;
      if (ea.itemsName10 != null) _values_[9] = ea.itemsName10;
      if (ea.itemsName11 != null) _values_[10] = ea.itemsName11;
      if (ea.itemsName12 != null) _values_[11] = ea.itemsName12;
      if (ea.itemsName13 != null) _values_[12] = ea.itemsName13;
      if (ea.itemsName14 != null) _values_[13] = ea.itemsName14;
      if (ea.itemsName15 != null) _values_[14] = ea.itemsName15;
      if (ea.itemsName16 != null) _values_[15] = ea.itemsName16;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_CNF_ITEMS_NAME(System.String itemsName1, bool ignore_itemsName1, System.String itemsName2, bool ignore_itemsName2, System.String itemsName3, bool ignore_itemsName3, System.String itemsName4, bool ignore_itemsName4, System.String itemsName5, bool ignore_itemsName5, System.String itemsName6, bool ignore_itemsName6, System.String itemsName7, bool ignore_itemsName7, System.String itemsName8, bool ignore_itemsName8, System.String itemsName9, bool ignore_itemsName9, System.String itemsName10, bool ignore_itemsName10, System.String itemsName11, bool ignore_itemsName11, System.String itemsName12, bool ignore_itemsName12, System.String itemsName13, bool ignore_itemsName13, System.String itemsName14, bool ignore_itemsName14, System.String itemsName15, bool ignore_itemsName15, System.String itemsName16, bool ignore_itemsName16)
    {
      object[] _values_ = new object[16];
      if (!ignore_itemsName1) _values_[0] = itemsName1;
      if (!ignore_itemsName2) _values_[1] = itemsName2;
      if (!ignore_itemsName3) _values_[2] = itemsName3;
      if (!ignore_itemsName4) _values_[3] = itemsName4;
      if (!ignore_itemsName5) _values_[4] = itemsName5;
      if (!ignore_itemsName6) _values_[5] = itemsName6;
      if (!ignore_itemsName7) _values_[6] = itemsName7;
      if (!ignore_itemsName8) _values_[7] = itemsName8;
      if (!ignore_itemsName9) _values_[8] = itemsName9;
      if (!ignore_itemsName10) _values_[9] = itemsName10;
      if (!ignore_itemsName11) _values_[10] = itemsName11;
      if (!ignore_itemsName12) _values_[11] = itemsName12;
      if (!ignore_itemsName13) _values_[12] = itemsName13;
      if (!ignore_itemsName14) _values_[13] = itemsName14;
      if (!ignore_itemsName15) _values_[14] = itemsName15;
      if (!ignore_itemsName16) _values_[15] = itemsName16;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }

  }
}

namespace SE.Nereda.Symbols.encodeIOpCdt
{}
#endregion #encodeIOpCdt_HMI;

#endregion Definitions;
