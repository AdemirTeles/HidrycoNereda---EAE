/*
 * Created by EcoStruxure Automation Expert.
 * User: SESA713705
 * Date: 8/20/2024
 * Time: 11:59 AM
 * 
 */
using System;
using NxtControl.GuiFramework;
using NxtControl.Services;

#region Definitions;
#region #KeepCurrentOpCdtLogic_HMI;

namespace SE.Nereda.Symbols.KeepCurrentOpCdtLogic
{

  public class NEED_UPDATEEventArgs : System.EventArgs
  {
    IHMIAccessorService accessorService;
    int channelId;
    int cookie; 
    int eventIndex;

    public NEED_UPDATEEventArgs(int channelId, int cookie, int eventIndex)
    {
      this.accessorService = (IHMIAccessorService)ServiceProvider.GetService(typeof(IHMIAccessorService));
      this.channelId = channelId;
      this.cookie = cookie;
      this.eventIndex = eventIndex;
    }
    public bool Get_NeedUpdate(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,0, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? NeedUpdate
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

namespace SE.Nereda.Symbols.KeepCurrentOpCdtLogic
{

  public class UPDATEEventArgs : System.EventArgs
  {
    public UPDATEEventArgs()
    {
    }
    private System.Boolean? UpdateOpCndt_field = null;
    public System.Boolean? UpdateOpCndt
    {
       get { return UpdateOpCndt_field; }
       set { UpdateOpCndt_field = value; }
    }

  }

  public class ACTIVE_UPDATEEventArgs : System.EventArgs
  {
    public ACTIVE_UPDATEEventArgs()
    {
    }
    private System.Boolean? ActiveUpdate_field = null;
    public System.Boolean? ActiveUpdate
    {
       get { return ActiveUpdate_field; }
       set { ActiveUpdate_field = value; }
    }

  }

}

namespace SE.Nereda.Symbols.KeepCurrentOpCdtLogic
{
  partial class sDefault
  {

    private event EventHandler<SE.Nereda.Symbols.KeepCurrentOpCdtLogic.NEED_UPDATEEventArgs> NEED_UPDATE_Fired;

    private event EventHandler<SE.Nereda.Symbols.KeepCurrentOpCdtLogic.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    protected override void OnEndInit()
    {
      if (NEED_UPDATE_Fired != null)
        AttachEventInput(0);
      if (LOAD_PERS_DATA_Fired != null)
        AttachEventInput(1);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (NEED_UPDATE_Fired != null)
          {
            try
            {
              NEED_UPDATE_Fired(this, new SE.Nereda.Symbols.KeepCurrentOpCdtLogic.NEED_UPDATEEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","NEED_UPDATE_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 1:
          if (LOAD_PERS_DATA_Fired != null)
          {
            try
            {
              LOAD_PERS_DATA_Fired(this, new SE.Nereda.Symbols.KeepCurrentOpCdtLogic.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
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
    public bool FireEvent_UPDATE(System.Boolean UpdateOpCndt)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {UpdateOpCndt});
    }
    public bool FireEvent_UPDATE(SE.Nereda.Symbols.KeepCurrentOpCdtLogic.UPDATEEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.UpdateOpCndt.HasValue) _values_[0] = ea.UpdateOpCndt.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_UPDATE(System.Boolean UpdateOpCndt, bool ignore_UpdateOpCndt)
    {
      object[] _values_ = new object[1];
      if (!ignore_UpdateOpCndt) _values_[0] = UpdateOpCndt;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_ACTIVE_UPDATE(System.Boolean ActiveUpdate)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {ActiveUpdate});
    }
    public bool FireEvent_ACTIVE_UPDATE(SE.Nereda.Symbols.KeepCurrentOpCdtLogic.ACTIVE_UPDATEEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.ActiveUpdate.HasValue) _values_[0] = ea.ActiveUpdate.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_ACTIVE_UPDATE(System.Boolean ActiveUpdate, bool ignore_ActiveUpdate)
    {
      object[] _values_ = new object[1];
      if (!ignore_ActiveUpdate) _values_[0] = ActiveUpdate;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }

  }
}

namespace SE.Nereda.Faceplates.KeepCurrentOpCdtLogic
{}
#endregion #KeepCurrentOpCdtLogic_HMI;

#endregion Definitions;
