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
#region #EffluentCdt_HMI;

namespace SE.Nereda.Symbols.EffluentCdt
{

  public class EFFLUENTEventArgs : System.EventArgs
  {
    IHMIAccessorService accessorService;
    int channelId;
    int cookie; 
    int eventIndex;

    public EFFLUENTEventArgs(int channelId, int cookie, int eventIndex)
    {
      this.accessorService = (IHMIAccessorService)ServiceProvider.GetService(typeof(IHMIAccessorService));
      this.channelId = channelId;
      this.cookie = cookie;
      this.eventIndex = eventIndex;
    }
    public bool Get_StartEffluent(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,0, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? StartEffluent
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,0, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_StopEffluent(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,1, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? StopEffluent
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,1, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_EffluentReady(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,2, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? EffluentReady
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,2, ref var);
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

    public bool Get_StartName(ref System.String value)
    {
      if (accessorService == null)
        return false;
      string var = null;
      bool ret = accessorService.GetStringValue(channelId, cookie, eventIndex, true,10, ref var);
      if (ret) value = (System.String) var;
      return ret;
    }

    public System.String StartName
    { get {
      if (accessorService == null)
        return null;
      string var = null;
      bool ret = accessorService.GetStringValue(channelId, cookie, eventIndex, true,10, ref var);
      if (!ret) return null;
      return (System.String) var;
    }  }

    public bool Get_StopName(ref System.String value)
    {
      if (accessorService == null)
        return false;
      string var = null;
      bool ret = accessorService.GetStringValue(channelId, cookie, eventIndex, true,11, ref var);
      if (ret) value = (System.String) var;
      return ret;
    }

    public System.String StopName
    { get {
      if (accessorService == null)
        return null;
      string var = null;
      bool ret = accessorService.GetStringValue(channelId, cookie, eventIndex, true,11, ref var);
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

namespace SE.Nereda.Symbols.EffluentCdt
{

  public class ACTIVEEventArgs : System.EventArgs
  {
    public ACTIVEEventArgs()
    {
    }
    private System.Boolean? ActiveRdy_field = null;
    public System.Boolean? ActiveRdy
    {
       get { return ActiveRdy_field; }
       set { ActiveRdy_field = value; }
    }
    private System.Boolean? ActiveStop_field = null;
    public System.Boolean? ActiveStop
    {
       get { return ActiveStop_field; }
       set { ActiveStop_field = value; }
    }
    private System.Boolean? ActiveStart_field = null;
    public System.Boolean? ActiveStart
    {
       get { return ActiveStart_field; }
       set { ActiveStart_field = value; }
    }
    private System.Boolean? Mode_field = null;
    public System.Boolean? Mode
    {
       get { return Mode_field; }
       set { Mode_field = value; }
    }

  }

}

namespace SE.Nereda.Symbols.EffluentCdt
{
  partial class sDefault
  {

    private event EventHandler<SE.Nereda.Symbols.EffluentCdt.EFFLUENTEventArgs> EFFLUENT_Fired;

    private event EventHandler<SE.Nereda.Symbols.EffluentCdt.REQ_ITEMSEventArgs> REQ_ITEMS_Fired;

    private event EventHandler<SE.Nereda.Symbols.EffluentCdt.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    protected override void OnEndInit()
    {
      if (EFFLUENT_Fired != null)
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
          if (EFFLUENT_Fired != null)
          {
            try
            {
              EFFLUENT_Fired(this, new SE.Nereda.Symbols.EffluentCdt.EFFLUENTEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","EFFLUENT_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 1:
          if (REQ_ITEMS_Fired != null)
          {
            try
            {
              REQ_ITEMS_Fired(this, new SE.Nereda.Symbols.EffluentCdt.REQ_ITEMSEventArgs(channelId, cookie, eventIndex));
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
              LOAD_PERS_DATA_Fired(this, new SE.Nereda.Symbols.EffluentCdt.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
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
    public bool FireEvent_ACTIVE(System.Boolean ActiveRdy, System.Boolean ActiveStop, System.Boolean ActiveStart, System.Boolean Mode)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {ActiveRdy, ActiveStop, ActiveStart, Mode});
    }
    public bool FireEvent_ACTIVE(SE.Nereda.Symbols.EffluentCdt.ACTIVEEventArgs ea)
    {
      object[] _values_ = new object[4];
      if (ea.ActiveRdy.HasValue) _values_[0] = ea.ActiveRdy.Value;
      if (ea.ActiveStop.HasValue) _values_[1] = ea.ActiveStop.Value;
      if (ea.ActiveStart.HasValue) _values_[2] = ea.ActiveStart.Value;
      if (ea.Mode.HasValue) _values_[3] = ea.Mode.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_ACTIVE(System.Boolean ActiveRdy, bool ignore_ActiveRdy, System.Boolean ActiveStop, bool ignore_ActiveStop, System.Boolean ActiveStart, bool ignore_ActiveStart, System.Boolean Mode, bool ignore_Mode)
    {
      object[] _values_ = new object[4];
      if (!ignore_ActiveRdy) _values_[0] = ActiveRdy;
      if (!ignore_ActiveStop) _values_[1] = ActiveStop;
      if (!ignore_ActiveStart) _values_[2] = ActiveStart;
      if (!ignore_Mode) _values_[3] = Mode;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }

  }
}

namespace SE.Nereda.Faceplates.EffluentCdt
{
  partial class fpStartCdts
  {

    private event EventHandler<SE.Nereda.Symbols.EffluentCdt.EFFLUENTEventArgs> EFFLUENT_Fired;

    private event EventHandler<SE.Nereda.Symbols.EffluentCdt.REQ_ITEMSEventArgs> REQ_ITEMS_Fired;

    private event EventHandler<SE.Nereda.Symbols.EffluentCdt.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    protected override void OnEndInit()
    {
      if (EFFLUENT_Fired != null)
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
          if (EFFLUENT_Fired != null)
          {
            try
            {
              EFFLUENT_Fired(this, new SE.Nereda.Symbols.EffluentCdt.EFFLUENTEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","EFFLUENT_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 1:
          if (REQ_ITEMS_Fired != null)
          {
            try
            {
              REQ_ITEMS_Fired(this, new SE.Nereda.Symbols.EffluentCdt.REQ_ITEMSEventArgs(channelId, cookie, eventIndex));
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
              LOAD_PERS_DATA_Fired(this, new SE.Nereda.Symbols.EffluentCdt.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
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
    public bool FireEvent_ACTIVE(System.Boolean ActiveRdy, System.Boolean ActiveStop, System.Boolean ActiveStart, System.Boolean Mode)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {ActiveRdy, ActiveStop, ActiveStart, Mode});
    }
    public bool FireEvent_ACTIVE(SE.Nereda.Symbols.EffluentCdt.ACTIVEEventArgs ea)
    {
      object[] _values_ = new object[4];
      if (ea.ActiveRdy.HasValue) _values_[0] = ea.ActiveRdy.Value;
      if (ea.ActiveStop.HasValue) _values_[1] = ea.ActiveStop.Value;
      if (ea.ActiveStart.HasValue) _values_[2] = ea.ActiveStart.Value;
      if (ea.Mode.HasValue) _values_[3] = ea.Mode.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_ACTIVE(System.Boolean ActiveRdy, bool ignore_ActiveRdy, System.Boolean ActiveStop, bool ignore_ActiveStop, System.Boolean ActiveStart, bool ignore_ActiveStart, System.Boolean Mode, bool ignore_Mode)
    {
      object[] _values_ = new object[4];
      if (!ignore_ActiveRdy) _values_[0] = ActiveRdy;
      if (!ignore_ActiveStop) _values_[1] = ActiveStop;
      if (!ignore_ActiveStart) _values_[2] = ActiveStart;
      if (!ignore_Mode) _values_[3] = Mode;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }

  }
}

namespace SE.Nereda.Faceplates.EffluentCdt
{
  partial class fpStopCdts
  {

    private event EventHandler<SE.Nereda.Symbols.EffluentCdt.EFFLUENTEventArgs> EFFLUENT_Fired;

    private event EventHandler<SE.Nereda.Symbols.EffluentCdt.REQ_ITEMSEventArgs> REQ_ITEMS_Fired;

    private event EventHandler<SE.Nereda.Symbols.EffluentCdt.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    protected override void OnEndInit()
    {
      if (EFFLUENT_Fired != null)
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
          if (EFFLUENT_Fired != null)
          {
            try
            {
              EFFLUENT_Fired(this, new SE.Nereda.Symbols.EffluentCdt.EFFLUENTEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","EFFLUENT_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 1:
          if (REQ_ITEMS_Fired != null)
          {
            try
            {
              REQ_ITEMS_Fired(this, new SE.Nereda.Symbols.EffluentCdt.REQ_ITEMSEventArgs(channelId, cookie, eventIndex));
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
              LOAD_PERS_DATA_Fired(this, new SE.Nereda.Symbols.EffluentCdt.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
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
    public bool FireEvent_ACTIVE(System.Boolean ActiveRdy, System.Boolean ActiveStop, System.Boolean ActiveStart, System.Boolean Mode)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {ActiveRdy, ActiveStop, ActiveStart, Mode});
    }
    public bool FireEvent_ACTIVE(SE.Nereda.Symbols.EffluentCdt.ACTIVEEventArgs ea)
    {
      object[] _values_ = new object[4];
      if (ea.ActiveRdy.HasValue) _values_[0] = ea.ActiveRdy.Value;
      if (ea.ActiveStop.HasValue) _values_[1] = ea.ActiveStop.Value;
      if (ea.ActiveStart.HasValue) _values_[2] = ea.ActiveStart.Value;
      if (ea.Mode.HasValue) _values_[3] = ea.Mode.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_ACTIVE(System.Boolean ActiveRdy, bool ignore_ActiveRdy, System.Boolean ActiveStop, bool ignore_ActiveStop, System.Boolean ActiveStart, bool ignore_ActiveStart, System.Boolean Mode, bool ignore_Mode)
    {
      object[] _values_ = new object[4];
      if (!ignore_ActiveRdy) _values_[0] = ActiveRdy;
      if (!ignore_ActiveStop) _values_[1] = ActiveStop;
      if (!ignore_ActiveStart) _values_[2] = ActiveStart;
      if (!ignore_Mode) _values_[3] = Mode;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }

  }
}

namespace SE.Nereda.Symbols.EffluentCdt
{
  partial class sForce
  {

    private event EventHandler<SE.Nereda.Symbols.EffluentCdt.EFFLUENTEventArgs> EFFLUENT_Fired;

    private event EventHandler<SE.Nereda.Symbols.EffluentCdt.REQ_ITEMSEventArgs> REQ_ITEMS_Fired;

    private event EventHandler<SE.Nereda.Symbols.EffluentCdt.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    protected override void OnEndInit()
    {
      if (EFFLUENT_Fired != null)
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
          if (EFFLUENT_Fired != null)
          {
            try
            {
              EFFLUENT_Fired(this, new SE.Nereda.Symbols.EffluentCdt.EFFLUENTEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","EFFLUENT_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 1:
          if (REQ_ITEMS_Fired != null)
          {
            try
            {
              REQ_ITEMS_Fired(this, new SE.Nereda.Symbols.EffluentCdt.REQ_ITEMSEventArgs(channelId, cookie, eventIndex));
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
              LOAD_PERS_DATA_Fired(this, new SE.Nereda.Symbols.EffluentCdt.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
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
    public bool FireEvent_ACTIVE(System.Boolean ActiveRdy, System.Boolean ActiveStop, System.Boolean ActiveStart, System.Boolean Mode)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {ActiveRdy, ActiveStop, ActiveStart, Mode});
    }
    public bool FireEvent_ACTIVE(SE.Nereda.Symbols.EffluentCdt.ACTIVEEventArgs ea)
    {
      object[] _values_ = new object[4];
      if (ea.ActiveRdy.HasValue) _values_[0] = ea.ActiveRdy.Value;
      if (ea.ActiveStop.HasValue) _values_[1] = ea.ActiveStop.Value;
      if (ea.ActiveStart.HasValue) _values_[2] = ea.ActiveStart.Value;
      if (ea.Mode.HasValue) _values_[3] = ea.Mode.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_ACTIVE(System.Boolean ActiveRdy, bool ignore_ActiveRdy, System.Boolean ActiveStop, bool ignore_ActiveStop, System.Boolean ActiveStart, bool ignore_ActiveStart, System.Boolean Mode, bool ignore_Mode)
    {
      object[] _values_ = new object[4];
      if (!ignore_ActiveRdy) _values_[0] = ActiveRdy;
      if (!ignore_ActiveStop) _values_[1] = ActiveStop;
      if (!ignore_ActiveStart) _values_[2] = ActiveStart;
      if (!ignore_Mode) _values_[3] = Mode;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }

  }
}
#endregion #EffluentCdt_HMI;

#endregion Definitions;
