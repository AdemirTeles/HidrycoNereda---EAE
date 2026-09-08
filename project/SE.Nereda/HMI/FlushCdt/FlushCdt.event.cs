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
#region #FlushCdt_HMI;

namespace SE.Nereda.Symbols.FlushCdt
{

  public class FLUSH_RDYEventArgs : System.EventArgs
  {
    IHMIAccessorService accessorService;
    int channelId;
    int cookie; 
    int eventIndex;

    public FLUSH_RDYEventArgs(int channelId, int cookie, int eventIndex)
    {
      this.accessorService = (IHMIAccessorService)ServiceProvider.GetService(typeof(IHMIAccessorService));
      this.channelId = channelId;
      this.cookie = cookie;
      this.eventIndex = eventIndex;
    }
    public bool Get_FlushReady(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,0, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? FlushReady
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,0, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
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
    public bool Get_itemsName1(ref System.String value)
    {
      if (accessorService == null)
        return false;
      string var = null;
      bool ret = accessorService.GetStringValue(channelId, cookie, eventIndex, true,0, ref var);
      if (ret) value = (System.String) var;
      return ret;
    }

    public System.String itemsName1
    { get {
      if (accessorService == null)
        return null;
      string var = null;
      bool ret = accessorService.GetStringValue(channelId, cookie, eventIndex, true,0, ref var);
      if (!ret) return null;
      return (System.String) var;
    }  }

    public bool Get_itemsName2(ref System.String value)
    {
      if (accessorService == null)
        return false;
      string var = null;
      bool ret = accessorService.GetStringValue(channelId, cookie, eventIndex, true,1, ref var);
      if (ret) value = (System.String) var;
      return ret;
    }

    public System.String itemsName2
    { get {
      if (accessorService == null)
        return null;
      string var = null;
      bool ret = accessorService.GetStringValue(channelId, cookie, eventIndex, true,1, ref var);
      if (!ret) return null;
      return (System.String) var;
    }  }

    public bool Get_itemsName3(ref System.String value)
    {
      if (accessorService == null)
        return false;
      string var = null;
      bool ret = accessorService.GetStringValue(channelId, cookie, eventIndex, true,2, ref var);
      if (ret) value = (System.String) var;
      return ret;
    }

    public System.String itemsName3
    { get {
      if (accessorService == null)
        return null;
      string var = null;
      bool ret = accessorService.GetStringValue(channelId, cookie, eventIndex, true,2, ref var);
      if (!ret) return null;
      return (System.String) var;
    }  }

    public bool Get_itemsName4(ref System.String value)
    {
      if (accessorService == null)
        return false;
      string var = null;
      bool ret = accessorService.GetStringValue(channelId, cookie, eventIndex, true,3, ref var);
      if (ret) value = (System.String) var;
      return ret;
    }

    public System.String itemsName4
    { get {
      if (accessorService == null)
        return null;
      string var = null;
      bool ret = accessorService.GetStringValue(channelId, cookie, eventIndex, true,3, ref var);
      if (!ret) return null;
      return (System.String) var;
    }  }

    public bool Get_itemsName5(ref System.String value)
    {
      if (accessorService == null)
        return false;
      string var = null;
      bool ret = accessorService.GetStringValue(channelId, cookie, eventIndex, true,4, ref var);
      if (ret) value = (System.String) var;
      return ret;
    }

    public System.String itemsName5
    { get {
      if (accessorService == null)
        return null;
      string var = null;
      bool ret = accessorService.GetStringValue(channelId, cookie, eventIndex, true,4, ref var);
      if (!ret) return null;
      return (System.String) var;
    }  }

    public bool Get_itemsName6(ref System.String value)
    {
      if (accessorService == null)
        return false;
      string var = null;
      bool ret = accessorService.GetStringValue(channelId, cookie, eventIndex, true,5, ref var);
      if (ret) value = (System.String) var;
      return ret;
    }

    public System.String itemsName6
    { get {
      if (accessorService == null)
        return null;
      string var = null;
      bool ret = accessorService.GetStringValue(channelId, cookie, eventIndex, true,5, ref var);
      if (!ret) return null;
      return (System.String) var;
    }  }

    public bool Get_itemsName7(ref System.String value)
    {
      if (accessorService == null)
        return false;
      string var = null;
      bool ret = accessorService.GetStringValue(channelId, cookie, eventIndex, true,6, ref var);
      if (ret) value = (System.String) var;
      return ret;
    }

    public System.String itemsName7
    { get {
      if (accessorService == null)
        return null;
      string var = null;
      bool ret = accessorService.GetStringValue(channelId, cookie, eventIndex, true,6, ref var);
      if (!ret) return null;
      return (System.String) var;
    }  }

    public bool Get_itemsName8(ref System.String value)
    {
      if (accessorService == null)
        return false;
      string var = null;
      bool ret = accessorService.GetStringValue(channelId, cookie, eventIndex, true,7, ref var);
      if (ret) value = (System.String) var;
      return ret;
    }

    public System.String itemsName8
    { get {
      if (accessorService == null)
        return null;
      string var = null;
      bool ret = accessorService.GetStringValue(channelId, cookie, eventIndex, true,7, ref var);
      if (!ret) return null;
      return (System.String) var;
    }  }

    public bool Get_iTemsValue1(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,8, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? iTemsValue1
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,8, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }

    public bool Get_iTemsValue2(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,9, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? iTemsValue2
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,9, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }

    public bool Get_FlushName(ref System.String value)
    {
      if (accessorService == null)
        return false;
      string var = null;
      bool ret = accessorService.GetStringValue(channelId, cookie, eventIndex, true,10, ref var);
      if (ret) value = (System.String) var;
      return ret;
    }

    public System.String FlushName
    { get {
      if (accessorService == null)
        return null;
      string var = null;
      bool ret = accessorService.GetStringValue(channelId, cookie, eventIndex, true,10, ref var);
      if (!ret) return null;
      return (System.String) var;
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

namespace SE.Nereda.Symbols.FlushCdt
{

  public class ACTIVEEventArgs : System.EventArgs
  {
    public ACTIVEEventArgs()
    {
    }
    private System.Boolean? ActiveCdts_field = null;
    public System.Boolean? ActiveCdts
    {
       get { return ActiveCdts_field; }
       set { ActiveCdts_field = value; }
    }

  }

}

namespace SE.Nereda.Symbols.FlushCdt
{
  partial class sDefault
  {

    private event EventHandler<SE.Nereda.Symbols.FlushCdt.FLUSH_RDYEventArgs> FLUSH_RDY_Fired;

    private event EventHandler<SE.Nereda.Symbols.FlushCdt.REQ_ITEMSEventArgs> REQ_ITEMS_Fired;

    private event EventHandler<SE.Nereda.Symbols.FlushCdt.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    protected override void OnEndInit()
    {
      if (FLUSH_RDY_Fired != null)
        AttachEventInput(0);
      if (REQ_ITEMS_Fired != null)
        AttachEventInput(1);
      if (LOAD_PERS_DATA_Fired != null)
        AttachEventInput(2);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (FLUSH_RDY_Fired != null)
          {
            try
            {
              FLUSH_RDY_Fired(this, new SE.Nereda.Symbols.FlushCdt.FLUSH_RDYEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","FLUSH_RDY_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 1:
          if (REQ_ITEMS_Fired != null)
          {
            try
            {
              REQ_ITEMS_Fired(this, new SE.Nereda.Symbols.FlushCdt.REQ_ITEMSEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REQ_ITEMS_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 2:
          if (LOAD_PERS_DATA_Fired != null)
          {
            try
            {
              LOAD_PERS_DATA_Fired(this, new SE.Nereda.Symbols.FlushCdt.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
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
    public bool FireEvent_ACTIVE(System.Boolean ActiveCdts)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {ActiveCdts});
    }
    public bool FireEvent_ACTIVE(SE.Nereda.Symbols.FlushCdt.ACTIVEEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.ActiveCdts.HasValue) _values_[0] = ea.ActiveCdts.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_ACTIVE(System.Boolean ActiveCdts, bool ignore_ActiveCdts)
    {
      object[] _values_ = new object[1];
      if (!ignore_ActiveCdts) _values_[0] = ActiveCdts;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }

  }
}

namespace SE.Nereda.Faceplates.FlushCdt
{
  partial class fpInfos
  {

    private event EventHandler<SE.Nereda.Symbols.FlushCdt.FLUSH_RDYEventArgs> FLUSH_RDY_Fired;

    private event EventHandler<SE.Nereda.Symbols.FlushCdt.REQ_ITEMSEventArgs> REQ_ITEMS_Fired;

    private event EventHandler<SE.Nereda.Symbols.FlushCdt.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    protected override void OnEndInit()
    {
      if (FLUSH_RDY_Fired != null)
        AttachEventInput(0);
      if (REQ_ITEMS_Fired != null)
        AttachEventInput(1);
      if (LOAD_PERS_DATA_Fired != null)
        AttachEventInput(2);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (FLUSH_RDY_Fired != null)
          {
            try
            {
              FLUSH_RDY_Fired(this, new SE.Nereda.Symbols.FlushCdt.FLUSH_RDYEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","FLUSH_RDY_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 1:
          if (REQ_ITEMS_Fired != null)
          {
            try
            {
              REQ_ITEMS_Fired(this, new SE.Nereda.Symbols.FlushCdt.REQ_ITEMSEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REQ_ITEMS_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 2:
          if (LOAD_PERS_DATA_Fired != null)
          {
            try
            {
              LOAD_PERS_DATA_Fired(this, new SE.Nereda.Symbols.FlushCdt.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
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
    public bool FireEvent_ACTIVE(System.Boolean ActiveCdts)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {ActiveCdts});
    }
    public bool FireEvent_ACTIVE(SE.Nereda.Symbols.FlushCdt.ACTIVEEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.ActiveCdts.HasValue) _values_[0] = ea.ActiveCdts.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_ACTIVE(System.Boolean ActiveCdts, bool ignore_ActiveCdts)
    {
      object[] _values_ = new object[1];
      if (!ignore_ActiveCdts) _values_[0] = ActiveCdts;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }

  }
}

namespace SE.Nereda.Symbols.FlushCdt
{
  partial class sForce
  {

    private event EventHandler<SE.Nereda.Symbols.FlushCdt.FLUSH_RDYEventArgs> FLUSH_RDY_Fired;

    private event EventHandler<SE.Nereda.Symbols.FlushCdt.REQ_ITEMSEventArgs> REQ_ITEMS_Fired;

    private event EventHandler<SE.Nereda.Symbols.FlushCdt.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    protected override void OnEndInit()
    {
      if (FLUSH_RDY_Fired != null)
        AttachEventInput(0);
      if (REQ_ITEMS_Fired != null)
        AttachEventInput(1);
      if (LOAD_PERS_DATA_Fired != null)
        AttachEventInput(2);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (FLUSH_RDY_Fired != null)
          {
            try
            {
              FLUSH_RDY_Fired(this, new SE.Nereda.Symbols.FlushCdt.FLUSH_RDYEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","FLUSH_RDY_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 1:
          if (REQ_ITEMS_Fired != null)
          {
            try
            {
              REQ_ITEMS_Fired(this, new SE.Nereda.Symbols.FlushCdt.REQ_ITEMSEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REQ_ITEMS_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 2:
          if (LOAD_PERS_DATA_Fired != null)
          {
            try
            {
              LOAD_PERS_DATA_Fired(this, new SE.Nereda.Symbols.FlushCdt.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
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
    public bool FireEvent_ACTIVE(System.Boolean ActiveCdts)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {ActiveCdts});
    }
    public bool FireEvent_ACTIVE(SE.Nereda.Symbols.FlushCdt.ACTIVEEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.ActiveCdts.HasValue) _values_[0] = ea.ActiveCdts.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_ACTIVE(System.Boolean ActiveCdts, bool ignore_ActiveCdts)
    {
      object[] _values_ = new object[1];
      if (!ignore_ActiveCdts) _values_[0] = ActiveCdts;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }

  }
}
#endregion #FlushCdt_HMI;

#endregion Definitions;
