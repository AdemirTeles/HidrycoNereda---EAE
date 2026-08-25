/*
 * Created by EcoStruxure Automation Expert.
 * User: SESA371406
 * Date: 19/05/2022
 * Time: 10:33 am
 * 
 */
using System;
using NxtControl.GuiFramework;
using NxtControl.Services;

#region Definitions;
#region #Mode_HMI;

namespace SE.Nereda.Symbols.Mode
{

  public class REQ_STATUSEventArgs : System.EventArgs
  {
    IHMIAccessorService accessorService;
    int channelId;
    int cookie; 
    int eventIndex;

    public REQ_STATUSEventArgs(int channelId, int cookie, int eventIndex)
    {
      this.accessorService = (IHMIAccessorService)ServiceProvider.GetService(typeof(IHMIAccessorService));
      this.channelId = channelId;
      this.cookie = cookie;
      this.eventIndex = eventIndex;
    }
    public bool Get_Auto(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,0, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? Auto
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,0, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_Manual(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,1, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? Manual
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,1, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_OFF(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,2, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? OFF
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,2, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_Emergency(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,3, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? Emergency
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,3, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_fbMode(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,4, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? fbMode
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,4, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }


  }

  public class NEW_RESETEventArgs : System.EventArgs
  {
    IHMIAccessorService accessorService;
    int channelId;
    int cookie; 
    int eventIndex;

    public NEW_RESETEventArgs(int channelId, int cookie, int eventIndex)
    {
      this.accessorService = (IHMIAccessorService)ServiceProvider.GetService(typeof(IHMIAccessorService));
      this.channelId = channelId;
      this.cookie = cookie;
      this.eventIndex = eventIndex;
    }
    public bool Get_Reset(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,0, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? Reset
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,0, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }


  }

  public class REQ_NO_COMMEventArgs : System.EventArgs
  {
    IHMIAccessorService accessorService;
    int channelId;
    int cookie; 
    int eventIndex;

    public REQ_NO_COMMEventArgs(int channelId, int cookie, int eventIndex)
    {
      this.accessorService = (IHMIAccessorService)ServiceProvider.GetService(typeof(IHMIAccessorService));
      this.channelId = channelId;
      this.cookie = cookie;
      this.eventIndex = eventIndex;
    }
    public bool Get_NoComm(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,0, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? NoComm
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

namespace SE.Nereda.Symbols.Mode
{

  public class MODE_HMIEventArgs : System.EventArgs
  {
    public MODE_HMIEventArgs()
    {
    }
    private System.Int16? ModeHMI_field = null;
    public System.Int16? ModeHMI
    {
       get { return ModeHMI_field; }
       set { ModeHMI_field = value; }
    }

  }

  public class RESET_CMDEventArgs : System.EventArgs
  {
    public RESET_CMDEventArgs()
    {
    }
    private System.Boolean? ResetReactor1_field = null;
    public System.Boolean? ResetReactor1
    {
       get { return ResetReactor1_field; }
       set { ResetReactor1_field = value; }
    }
    private System.Boolean? ResetReactor2_field = null;
    public System.Boolean? ResetReactor2
    {
       get { return ResetReactor2_field; }
       set { ResetReactor2_field = value; }
    }
    private System.Boolean? ResetReactor3_field = null;
    public System.Boolean? ResetReactor3
    {
       get { return ResetReactor3_field; }
       set { ResetReactor3_field = value; }
    }
    private System.Boolean? ResetReactor4_field = null;
    public System.Boolean? ResetReactor4
    {
       get { return ResetReactor4_field; }
       set { ResetReactor4_field = value; }
    }
    private System.Boolean? ResetReactor5_field = null;
    public System.Boolean? ResetReactor5
    {
       get { return ResetReactor5_field; }
       set { ResetReactor5_field = value; }
    }
    private System.Boolean? ResetReactor6_field = null;
    public System.Boolean? ResetReactor6
    {
       get { return ResetReactor6_field; }
       set { ResetReactor6_field = value; }
    }
    private System.Boolean? ResetMetalSaltDosing_field = null;
    public System.Boolean? ResetMetalSaltDosing
    {
       get { return ResetMetalSaltDosing_field; }
       set { ResetMetalSaltDosing_field = value; }
    }
    private System.Boolean? ResetEmergency_field = null;
    public System.Boolean? ResetEmergency
    {
       get { return ResetEmergency_field; }
       set { ResetEmergency_field = value; }
    }
    private System.Boolean? ResetSludgeBuffer_field = null;
    public System.Boolean? ResetSludgeBuffer
    {
       get { return ResetSludgeBuffer_field; }
       set { ResetSludgeBuffer_field = value; }
    }

  }

}

namespace SE.Nereda.Symbols.Mode
{
  partial class ReactorMode
  {

    private event EventHandler<SE.Nereda.Symbols.Mode.REQ_STATUSEventArgs> REQ_STATUS_Fired;

    private event EventHandler<SE.Nereda.Symbols.Mode.NEW_RESETEventArgs> NEW_RESET_Fired;

    private event EventHandler<SE.Nereda.Symbols.Mode.REQ_NO_COMMEventArgs> REQ_NO_COMM_Fired;

    private event EventHandler<SE.Nereda.Symbols.Mode.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    protected override void OnEndInit()
    {
      if (REQ_STATUS_Fired != null)
        AttachEventInput(0);
      if (NEW_RESET_Fired != null)
        AttachEventInput(1);
      if (REQ_NO_COMM_Fired != null)
        AttachEventInput(2);
      if (LOAD_PERS_DATA_Fired != null)
        AttachEventInput(3);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (REQ_STATUS_Fired != null)
          {
            try
            {
              REQ_STATUS_Fired(this, new SE.Nereda.Symbols.Mode.REQ_STATUSEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REQ_STATUS_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 1:
          if (NEW_RESET_Fired != null)
          {
            try
            {
              NEW_RESET_Fired(this, new SE.Nereda.Symbols.Mode.NEW_RESETEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","NEW_RESET_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 2:
          if (REQ_NO_COMM_Fired != null)
          {
            try
            {
              REQ_NO_COMM_Fired(this, new SE.Nereda.Symbols.Mode.REQ_NO_COMMEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REQ_NO_COMM_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 3:
          if (LOAD_PERS_DATA_Fired != null)
          {
            try
            {
              LOAD_PERS_DATA_Fired(this, new SE.Nereda.Symbols.Mode.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
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
    public bool FireEvent_MODE_HMI(System.Int16 ModeHMI)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {ModeHMI});
    }
    public bool FireEvent_MODE_HMI(SE.Nereda.Symbols.Mode.MODE_HMIEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.ModeHMI.HasValue) _values_[0] = ea.ModeHMI.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_MODE_HMI(System.Int16 ModeHMI, bool ignore_ModeHMI)
    {
      object[] _values_ = new object[1];
      if (!ignore_ModeHMI) _values_[0] = ModeHMI;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_RESET_CMD(System.Boolean ResetReactor1, System.Boolean ResetReactor2, System.Boolean ResetReactor3, System.Boolean ResetReactor4, System.Boolean ResetReactor5, System.Boolean ResetReactor6, System.Boolean ResetMetalSaltDosing, System.Boolean ResetEmergency, System.Boolean ResetSludgeBuffer)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {ResetReactor1, ResetReactor2, ResetReactor3, ResetReactor4, ResetReactor5, ResetReactor6, ResetMetalSaltDosing, ResetEmergency, ResetSludgeBuffer});
    }
    public bool FireEvent_RESET_CMD(SE.Nereda.Symbols.Mode.RESET_CMDEventArgs ea)
    {
      object[] _values_ = new object[9];
      if (ea.ResetReactor1.HasValue) _values_[0] = ea.ResetReactor1.Value;
      if (ea.ResetReactor2.HasValue) _values_[1] = ea.ResetReactor2.Value;
      if (ea.ResetReactor3.HasValue) _values_[2] = ea.ResetReactor3.Value;
      if (ea.ResetReactor4.HasValue) _values_[3] = ea.ResetReactor4.Value;
      if (ea.ResetReactor5.HasValue) _values_[4] = ea.ResetReactor5.Value;
      if (ea.ResetReactor6.HasValue) _values_[5] = ea.ResetReactor6.Value;
      if (ea.ResetMetalSaltDosing.HasValue) _values_[6] = ea.ResetMetalSaltDosing.Value;
      if (ea.ResetEmergency.HasValue) _values_[7] = ea.ResetEmergency.Value;
      if (ea.ResetSludgeBuffer.HasValue) _values_[8] = ea.ResetSludgeBuffer.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_RESET_CMD(System.Boolean ResetReactor1, bool ignore_ResetReactor1, System.Boolean ResetReactor2, bool ignore_ResetReactor2, System.Boolean ResetReactor3, bool ignore_ResetReactor3, System.Boolean ResetReactor4, bool ignore_ResetReactor4, System.Boolean ResetReactor5, bool ignore_ResetReactor5, System.Boolean ResetReactor6, bool ignore_ResetReactor6, System.Boolean ResetMetalSaltDosing, bool ignore_ResetMetalSaltDosing, System.Boolean ResetEmergency, bool ignore_ResetEmergency, System.Boolean ResetSludgeBuffer, bool ignore_ResetSludgeBuffer)
    {
      object[] _values_ = new object[9];
      if (!ignore_ResetReactor1) _values_[0] = ResetReactor1;
      if (!ignore_ResetReactor2) _values_[1] = ResetReactor2;
      if (!ignore_ResetReactor3) _values_[2] = ResetReactor3;
      if (!ignore_ResetReactor4) _values_[3] = ResetReactor4;
      if (!ignore_ResetReactor5) _values_[4] = ResetReactor5;
      if (!ignore_ResetReactor6) _values_[5] = ResetReactor6;
      if (!ignore_ResetMetalSaltDosing) _values_[6] = ResetMetalSaltDosing;
      if (!ignore_ResetEmergency) _values_[7] = ResetEmergency;
      if (!ignore_ResetSludgeBuffer) _values_[8] = ResetSludgeBuffer;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }

  }
}

namespace SE.Nereda.Symbols.Mode
{
  partial class ResetReactor1
  {

    private event EventHandler<SE.Nereda.Symbols.Mode.REQ_STATUSEventArgs> REQ_STATUS_Fired;

    private event EventHandler<SE.Nereda.Symbols.Mode.NEW_RESETEventArgs> NEW_RESET_Fired;

    private event EventHandler<SE.Nereda.Symbols.Mode.REQ_NO_COMMEventArgs> REQ_NO_COMM_Fired;

    private event EventHandler<SE.Nereda.Symbols.Mode.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    protected override void OnEndInit()
    {
      if (REQ_STATUS_Fired != null)
        AttachEventInput(0);
      if (NEW_RESET_Fired != null)
        AttachEventInput(1);
      if (REQ_NO_COMM_Fired != null)
        AttachEventInput(2);
      if (LOAD_PERS_DATA_Fired != null)
        AttachEventInput(3);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (REQ_STATUS_Fired != null)
          {
            try
            {
              REQ_STATUS_Fired(this, new SE.Nereda.Symbols.Mode.REQ_STATUSEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REQ_STATUS_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 1:
          if (NEW_RESET_Fired != null)
          {
            try
            {
              NEW_RESET_Fired(this, new SE.Nereda.Symbols.Mode.NEW_RESETEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","NEW_RESET_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 2:
          if (REQ_NO_COMM_Fired != null)
          {
            try
            {
              REQ_NO_COMM_Fired(this, new SE.Nereda.Symbols.Mode.REQ_NO_COMMEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REQ_NO_COMM_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 3:
          if (LOAD_PERS_DATA_Fired != null)
          {
            try
            {
              LOAD_PERS_DATA_Fired(this, new SE.Nereda.Symbols.Mode.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
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
    public bool FireEvent_MODE_HMI(System.Int16 ModeHMI)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {ModeHMI});
    }
    public bool FireEvent_MODE_HMI(SE.Nereda.Symbols.Mode.MODE_HMIEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.ModeHMI.HasValue) _values_[0] = ea.ModeHMI.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_MODE_HMI(System.Int16 ModeHMI, bool ignore_ModeHMI)
    {
      object[] _values_ = new object[1];
      if (!ignore_ModeHMI) _values_[0] = ModeHMI;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_RESET_CMD(System.Boolean ResetReactor1, System.Boolean ResetReactor2, System.Boolean ResetReactor3, System.Boolean ResetReactor4, System.Boolean ResetReactor5, System.Boolean ResetReactor6, System.Boolean ResetMetalSaltDosing, System.Boolean ResetEmergency, System.Boolean ResetSludgeBuffer)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {ResetReactor1, ResetReactor2, ResetReactor3, ResetReactor4, ResetReactor5, ResetReactor6, ResetMetalSaltDosing, ResetEmergency, ResetSludgeBuffer});
    }
    public bool FireEvent_RESET_CMD(SE.Nereda.Symbols.Mode.RESET_CMDEventArgs ea)
    {
      object[] _values_ = new object[9];
      if (ea.ResetReactor1.HasValue) _values_[0] = ea.ResetReactor1.Value;
      if (ea.ResetReactor2.HasValue) _values_[1] = ea.ResetReactor2.Value;
      if (ea.ResetReactor3.HasValue) _values_[2] = ea.ResetReactor3.Value;
      if (ea.ResetReactor4.HasValue) _values_[3] = ea.ResetReactor4.Value;
      if (ea.ResetReactor5.HasValue) _values_[4] = ea.ResetReactor5.Value;
      if (ea.ResetReactor6.HasValue) _values_[5] = ea.ResetReactor6.Value;
      if (ea.ResetMetalSaltDosing.HasValue) _values_[6] = ea.ResetMetalSaltDosing.Value;
      if (ea.ResetEmergency.HasValue) _values_[7] = ea.ResetEmergency.Value;
      if (ea.ResetSludgeBuffer.HasValue) _values_[8] = ea.ResetSludgeBuffer.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_RESET_CMD(System.Boolean ResetReactor1, bool ignore_ResetReactor1, System.Boolean ResetReactor2, bool ignore_ResetReactor2, System.Boolean ResetReactor3, bool ignore_ResetReactor3, System.Boolean ResetReactor4, bool ignore_ResetReactor4, System.Boolean ResetReactor5, bool ignore_ResetReactor5, System.Boolean ResetReactor6, bool ignore_ResetReactor6, System.Boolean ResetMetalSaltDosing, bool ignore_ResetMetalSaltDosing, System.Boolean ResetEmergency, bool ignore_ResetEmergency, System.Boolean ResetSludgeBuffer, bool ignore_ResetSludgeBuffer)
    {
      object[] _values_ = new object[9];
      if (!ignore_ResetReactor1) _values_[0] = ResetReactor1;
      if (!ignore_ResetReactor2) _values_[1] = ResetReactor2;
      if (!ignore_ResetReactor3) _values_[2] = ResetReactor3;
      if (!ignore_ResetReactor4) _values_[3] = ResetReactor4;
      if (!ignore_ResetReactor5) _values_[4] = ResetReactor5;
      if (!ignore_ResetReactor6) _values_[5] = ResetReactor6;
      if (!ignore_ResetMetalSaltDosing) _values_[6] = ResetMetalSaltDosing;
      if (!ignore_ResetEmergency) _values_[7] = ResetEmergency;
      if (!ignore_ResetSludgeBuffer) _values_[8] = ResetSludgeBuffer;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }

  }
}

namespace SE.Nereda.Symbols.Mode
{
  partial class ResetReactor2
  {

    private event EventHandler<SE.Nereda.Symbols.Mode.REQ_STATUSEventArgs> REQ_STATUS_Fired;

    private event EventHandler<SE.Nereda.Symbols.Mode.NEW_RESETEventArgs> NEW_RESET_Fired;

    private event EventHandler<SE.Nereda.Symbols.Mode.REQ_NO_COMMEventArgs> REQ_NO_COMM_Fired;

    private event EventHandler<SE.Nereda.Symbols.Mode.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    protected override void OnEndInit()
    {
      if (REQ_STATUS_Fired != null)
        AttachEventInput(0);
      if (NEW_RESET_Fired != null)
        AttachEventInput(1);
      if (REQ_NO_COMM_Fired != null)
        AttachEventInput(2);
      if (LOAD_PERS_DATA_Fired != null)
        AttachEventInput(3);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (REQ_STATUS_Fired != null)
          {
            try
            {
              REQ_STATUS_Fired(this, new SE.Nereda.Symbols.Mode.REQ_STATUSEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REQ_STATUS_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 1:
          if (NEW_RESET_Fired != null)
          {
            try
            {
              NEW_RESET_Fired(this, new SE.Nereda.Symbols.Mode.NEW_RESETEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","NEW_RESET_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 2:
          if (REQ_NO_COMM_Fired != null)
          {
            try
            {
              REQ_NO_COMM_Fired(this, new SE.Nereda.Symbols.Mode.REQ_NO_COMMEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REQ_NO_COMM_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 3:
          if (LOAD_PERS_DATA_Fired != null)
          {
            try
            {
              LOAD_PERS_DATA_Fired(this, new SE.Nereda.Symbols.Mode.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
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
    public bool FireEvent_MODE_HMI(System.Int16 ModeHMI)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {ModeHMI});
    }
    public bool FireEvent_MODE_HMI(SE.Nereda.Symbols.Mode.MODE_HMIEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.ModeHMI.HasValue) _values_[0] = ea.ModeHMI.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_MODE_HMI(System.Int16 ModeHMI, bool ignore_ModeHMI)
    {
      object[] _values_ = new object[1];
      if (!ignore_ModeHMI) _values_[0] = ModeHMI;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_RESET_CMD(System.Boolean ResetReactor1, System.Boolean ResetReactor2, System.Boolean ResetReactor3, System.Boolean ResetReactor4, System.Boolean ResetReactor5, System.Boolean ResetReactor6, System.Boolean ResetMetalSaltDosing, System.Boolean ResetEmergency, System.Boolean ResetSludgeBuffer)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {ResetReactor1, ResetReactor2, ResetReactor3, ResetReactor4, ResetReactor5, ResetReactor6, ResetMetalSaltDosing, ResetEmergency, ResetSludgeBuffer});
    }
    public bool FireEvent_RESET_CMD(SE.Nereda.Symbols.Mode.RESET_CMDEventArgs ea)
    {
      object[] _values_ = new object[9];
      if (ea.ResetReactor1.HasValue) _values_[0] = ea.ResetReactor1.Value;
      if (ea.ResetReactor2.HasValue) _values_[1] = ea.ResetReactor2.Value;
      if (ea.ResetReactor3.HasValue) _values_[2] = ea.ResetReactor3.Value;
      if (ea.ResetReactor4.HasValue) _values_[3] = ea.ResetReactor4.Value;
      if (ea.ResetReactor5.HasValue) _values_[4] = ea.ResetReactor5.Value;
      if (ea.ResetReactor6.HasValue) _values_[5] = ea.ResetReactor6.Value;
      if (ea.ResetMetalSaltDosing.HasValue) _values_[6] = ea.ResetMetalSaltDosing.Value;
      if (ea.ResetEmergency.HasValue) _values_[7] = ea.ResetEmergency.Value;
      if (ea.ResetSludgeBuffer.HasValue) _values_[8] = ea.ResetSludgeBuffer.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_RESET_CMD(System.Boolean ResetReactor1, bool ignore_ResetReactor1, System.Boolean ResetReactor2, bool ignore_ResetReactor2, System.Boolean ResetReactor3, bool ignore_ResetReactor3, System.Boolean ResetReactor4, bool ignore_ResetReactor4, System.Boolean ResetReactor5, bool ignore_ResetReactor5, System.Boolean ResetReactor6, bool ignore_ResetReactor6, System.Boolean ResetMetalSaltDosing, bool ignore_ResetMetalSaltDosing, System.Boolean ResetEmergency, bool ignore_ResetEmergency, System.Boolean ResetSludgeBuffer, bool ignore_ResetSludgeBuffer)
    {
      object[] _values_ = new object[9];
      if (!ignore_ResetReactor1) _values_[0] = ResetReactor1;
      if (!ignore_ResetReactor2) _values_[1] = ResetReactor2;
      if (!ignore_ResetReactor3) _values_[2] = ResetReactor3;
      if (!ignore_ResetReactor4) _values_[3] = ResetReactor4;
      if (!ignore_ResetReactor5) _values_[4] = ResetReactor5;
      if (!ignore_ResetReactor6) _values_[5] = ResetReactor6;
      if (!ignore_ResetMetalSaltDosing) _values_[6] = ResetMetalSaltDosing;
      if (!ignore_ResetEmergency) _values_[7] = ResetEmergency;
      if (!ignore_ResetSludgeBuffer) _values_[8] = ResetSludgeBuffer;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }

  }
}

namespace SE.Nereda.Symbols.Mode
{
  partial class ResetReactor3
  {

    private event EventHandler<SE.Nereda.Symbols.Mode.REQ_STATUSEventArgs> REQ_STATUS_Fired;

    private event EventHandler<SE.Nereda.Symbols.Mode.NEW_RESETEventArgs> NEW_RESET_Fired;

    private event EventHandler<SE.Nereda.Symbols.Mode.REQ_NO_COMMEventArgs> REQ_NO_COMM_Fired;

    private event EventHandler<SE.Nereda.Symbols.Mode.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    protected override void OnEndInit()
    {
      if (REQ_STATUS_Fired != null)
        AttachEventInput(0);
      if (NEW_RESET_Fired != null)
        AttachEventInput(1);
      if (REQ_NO_COMM_Fired != null)
        AttachEventInput(2);
      if (LOAD_PERS_DATA_Fired != null)
        AttachEventInput(3);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (REQ_STATUS_Fired != null)
          {
            try
            {
              REQ_STATUS_Fired(this, new SE.Nereda.Symbols.Mode.REQ_STATUSEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REQ_STATUS_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 1:
          if (NEW_RESET_Fired != null)
          {
            try
            {
              NEW_RESET_Fired(this, new SE.Nereda.Symbols.Mode.NEW_RESETEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","NEW_RESET_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 2:
          if (REQ_NO_COMM_Fired != null)
          {
            try
            {
              REQ_NO_COMM_Fired(this, new SE.Nereda.Symbols.Mode.REQ_NO_COMMEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REQ_NO_COMM_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 3:
          if (LOAD_PERS_DATA_Fired != null)
          {
            try
            {
              LOAD_PERS_DATA_Fired(this, new SE.Nereda.Symbols.Mode.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
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
    public bool FireEvent_MODE_HMI(System.Int16 ModeHMI)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {ModeHMI});
    }
    public bool FireEvent_MODE_HMI(SE.Nereda.Symbols.Mode.MODE_HMIEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.ModeHMI.HasValue) _values_[0] = ea.ModeHMI.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_MODE_HMI(System.Int16 ModeHMI, bool ignore_ModeHMI)
    {
      object[] _values_ = new object[1];
      if (!ignore_ModeHMI) _values_[0] = ModeHMI;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_RESET_CMD(System.Boolean ResetReactor1, System.Boolean ResetReactor2, System.Boolean ResetReactor3, System.Boolean ResetReactor4, System.Boolean ResetReactor5, System.Boolean ResetReactor6, System.Boolean ResetMetalSaltDosing, System.Boolean ResetEmergency, System.Boolean ResetSludgeBuffer)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {ResetReactor1, ResetReactor2, ResetReactor3, ResetReactor4, ResetReactor5, ResetReactor6, ResetMetalSaltDosing, ResetEmergency, ResetSludgeBuffer});
    }
    public bool FireEvent_RESET_CMD(SE.Nereda.Symbols.Mode.RESET_CMDEventArgs ea)
    {
      object[] _values_ = new object[9];
      if (ea.ResetReactor1.HasValue) _values_[0] = ea.ResetReactor1.Value;
      if (ea.ResetReactor2.HasValue) _values_[1] = ea.ResetReactor2.Value;
      if (ea.ResetReactor3.HasValue) _values_[2] = ea.ResetReactor3.Value;
      if (ea.ResetReactor4.HasValue) _values_[3] = ea.ResetReactor4.Value;
      if (ea.ResetReactor5.HasValue) _values_[4] = ea.ResetReactor5.Value;
      if (ea.ResetReactor6.HasValue) _values_[5] = ea.ResetReactor6.Value;
      if (ea.ResetMetalSaltDosing.HasValue) _values_[6] = ea.ResetMetalSaltDosing.Value;
      if (ea.ResetEmergency.HasValue) _values_[7] = ea.ResetEmergency.Value;
      if (ea.ResetSludgeBuffer.HasValue) _values_[8] = ea.ResetSludgeBuffer.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_RESET_CMD(System.Boolean ResetReactor1, bool ignore_ResetReactor1, System.Boolean ResetReactor2, bool ignore_ResetReactor2, System.Boolean ResetReactor3, bool ignore_ResetReactor3, System.Boolean ResetReactor4, bool ignore_ResetReactor4, System.Boolean ResetReactor5, bool ignore_ResetReactor5, System.Boolean ResetReactor6, bool ignore_ResetReactor6, System.Boolean ResetMetalSaltDosing, bool ignore_ResetMetalSaltDosing, System.Boolean ResetEmergency, bool ignore_ResetEmergency, System.Boolean ResetSludgeBuffer, bool ignore_ResetSludgeBuffer)
    {
      object[] _values_ = new object[9];
      if (!ignore_ResetReactor1) _values_[0] = ResetReactor1;
      if (!ignore_ResetReactor2) _values_[1] = ResetReactor2;
      if (!ignore_ResetReactor3) _values_[2] = ResetReactor3;
      if (!ignore_ResetReactor4) _values_[3] = ResetReactor4;
      if (!ignore_ResetReactor5) _values_[4] = ResetReactor5;
      if (!ignore_ResetReactor6) _values_[5] = ResetReactor6;
      if (!ignore_ResetMetalSaltDosing) _values_[6] = ResetMetalSaltDosing;
      if (!ignore_ResetEmergency) _values_[7] = ResetEmergency;
      if (!ignore_ResetSludgeBuffer) _values_[8] = ResetSludgeBuffer;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }

  }
}

namespace SE.Nereda.Symbols.Mode
{
  partial class ResetReactor4
  {

    private event EventHandler<SE.Nereda.Symbols.Mode.REQ_STATUSEventArgs> REQ_STATUS_Fired;

    private event EventHandler<SE.Nereda.Symbols.Mode.NEW_RESETEventArgs> NEW_RESET_Fired;

    private event EventHandler<SE.Nereda.Symbols.Mode.REQ_NO_COMMEventArgs> REQ_NO_COMM_Fired;

    private event EventHandler<SE.Nereda.Symbols.Mode.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    protected override void OnEndInit()
    {
      if (REQ_STATUS_Fired != null)
        AttachEventInput(0);
      if (NEW_RESET_Fired != null)
        AttachEventInput(1);
      if (REQ_NO_COMM_Fired != null)
        AttachEventInput(2);
      if (LOAD_PERS_DATA_Fired != null)
        AttachEventInput(3);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (REQ_STATUS_Fired != null)
          {
            try
            {
              REQ_STATUS_Fired(this, new SE.Nereda.Symbols.Mode.REQ_STATUSEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REQ_STATUS_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 1:
          if (NEW_RESET_Fired != null)
          {
            try
            {
              NEW_RESET_Fired(this, new SE.Nereda.Symbols.Mode.NEW_RESETEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","NEW_RESET_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 2:
          if (REQ_NO_COMM_Fired != null)
          {
            try
            {
              REQ_NO_COMM_Fired(this, new SE.Nereda.Symbols.Mode.REQ_NO_COMMEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REQ_NO_COMM_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 3:
          if (LOAD_PERS_DATA_Fired != null)
          {
            try
            {
              LOAD_PERS_DATA_Fired(this, new SE.Nereda.Symbols.Mode.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
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
    public bool FireEvent_MODE_HMI(System.Int16 ModeHMI)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {ModeHMI});
    }
    public bool FireEvent_MODE_HMI(SE.Nereda.Symbols.Mode.MODE_HMIEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.ModeHMI.HasValue) _values_[0] = ea.ModeHMI.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_MODE_HMI(System.Int16 ModeHMI, bool ignore_ModeHMI)
    {
      object[] _values_ = new object[1];
      if (!ignore_ModeHMI) _values_[0] = ModeHMI;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_RESET_CMD(System.Boolean ResetReactor1, System.Boolean ResetReactor2, System.Boolean ResetReactor3, System.Boolean ResetReactor4, System.Boolean ResetReactor5, System.Boolean ResetReactor6, System.Boolean ResetMetalSaltDosing, System.Boolean ResetEmergency, System.Boolean ResetSludgeBuffer)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {ResetReactor1, ResetReactor2, ResetReactor3, ResetReactor4, ResetReactor5, ResetReactor6, ResetMetalSaltDosing, ResetEmergency, ResetSludgeBuffer});
    }
    public bool FireEvent_RESET_CMD(SE.Nereda.Symbols.Mode.RESET_CMDEventArgs ea)
    {
      object[] _values_ = new object[9];
      if (ea.ResetReactor1.HasValue) _values_[0] = ea.ResetReactor1.Value;
      if (ea.ResetReactor2.HasValue) _values_[1] = ea.ResetReactor2.Value;
      if (ea.ResetReactor3.HasValue) _values_[2] = ea.ResetReactor3.Value;
      if (ea.ResetReactor4.HasValue) _values_[3] = ea.ResetReactor4.Value;
      if (ea.ResetReactor5.HasValue) _values_[4] = ea.ResetReactor5.Value;
      if (ea.ResetReactor6.HasValue) _values_[5] = ea.ResetReactor6.Value;
      if (ea.ResetMetalSaltDosing.HasValue) _values_[6] = ea.ResetMetalSaltDosing.Value;
      if (ea.ResetEmergency.HasValue) _values_[7] = ea.ResetEmergency.Value;
      if (ea.ResetSludgeBuffer.HasValue) _values_[8] = ea.ResetSludgeBuffer.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_RESET_CMD(System.Boolean ResetReactor1, bool ignore_ResetReactor1, System.Boolean ResetReactor2, bool ignore_ResetReactor2, System.Boolean ResetReactor3, bool ignore_ResetReactor3, System.Boolean ResetReactor4, bool ignore_ResetReactor4, System.Boolean ResetReactor5, bool ignore_ResetReactor5, System.Boolean ResetReactor6, bool ignore_ResetReactor6, System.Boolean ResetMetalSaltDosing, bool ignore_ResetMetalSaltDosing, System.Boolean ResetEmergency, bool ignore_ResetEmergency, System.Boolean ResetSludgeBuffer, bool ignore_ResetSludgeBuffer)
    {
      object[] _values_ = new object[9];
      if (!ignore_ResetReactor1) _values_[0] = ResetReactor1;
      if (!ignore_ResetReactor2) _values_[1] = ResetReactor2;
      if (!ignore_ResetReactor3) _values_[2] = ResetReactor3;
      if (!ignore_ResetReactor4) _values_[3] = ResetReactor4;
      if (!ignore_ResetReactor5) _values_[4] = ResetReactor5;
      if (!ignore_ResetReactor6) _values_[5] = ResetReactor6;
      if (!ignore_ResetMetalSaltDosing) _values_[6] = ResetMetalSaltDosing;
      if (!ignore_ResetEmergency) _values_[7] = ResetEmergency;
      if (!ignore_ResetSludgeBuffer) _values_[8] = ResetSludgeBuffer;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }

  }
}

namespace SE.Nereda.Faceplates.Mode
{
  partial class ModeSelect
  {

    private event EventHandler<SE.Nereda.Symbols.Mode.REQ_STATUSEventArgs> REQ_STATUS_Fired;

    private event EventHandler<SE.Nereda.Symbols.Mode.NEW_RESETEventArgs> NEW_RESET_Fired;

    private event EventHandler<SE.Nereda.Symbols.Mode.REQ_NO_COMMEventArgs> REQ_NO_COMM_Fired;

    private event EventHandler<SE.Nereda.Symbols.Mode.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    protected override void OnEndInit()
    {
      if (REQ_STATUS_Fired != null)
        AttachEventInput(0);
      if (NEW_RESET_Fired != null)
        AttachEventInput(1);
      if (REQ_NO_COMM_Fired != null)
        AttachEventInput(2);
      if (LOAD_PERS_DATA_Fired != null)
        AttachEventInput(3);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (REQ_STATUS_Fired != null)
          {
            try
            {
              REQ_STATUS_Fired(this, new SE.Nereda.Symbols.Mode.REQ_STATUSEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REQ_STATUS_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 1:
          if (NEW_RESET_Fired != null)
          {
            try
            {
              NEW_RESET_Fired(this, new SE.Nereda.Symbols.Mode.NEW_RESETEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","NEW_RESET_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 2:
          if (REQ_NO_COMM_Fired != null)
          {
            try
            {
              REQ_NO_COMM_Fired(this, new SE.Nereda.Symbols.Mode.REQ_NO_COMMEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REQ_NO_COMM_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 3:
          if (LOAD_PERS_DATA_Fired != null)
          {
            try
            {
              LOAD_PERS_DATA_Fired(this, new SE.Nereda.Symbols.Mode.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
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
    public bool FireEvent_MODE_HMI(System.Int16 ModeHMI)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {ModeHMI});
    }
    public bool FireEvent_MODE_HMI(SE.Nereda.Symbols.Mode.MODE_HMIEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.ModeHMI.HasValue) _values_[0] = ea.ModeHMI.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_MODE_HMI(System.Int16 ModeHMI, bool ignore_ModeHMI)
    {
      object[] _values_ = new object[1];
      if (!ignore_ModeHMI) _values_[0] = ModeHMI;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_RESET_CMD(System.Boolean ResetReactor1, System.Boolean ResetReactor2, System.Boolean ResetReactor3, System.Boolean ResetReactor4, System.Boolean ResetReactor5, System.Boolean ResetReactor6, System.Boolean ResetMetalSaltDosing, System.Boolean ResetEmergency, System.Boolean ResetSludgeBuffer)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {ResetReactor1, ResetReactor2, ResetReactor3, ResetReactor4, ResetReactor5, ResetReactor6, ResetMetalSaltDosing, ResetEmergency, ResetSludgeBuffer});
    }
    public bool FireEvent_RESET_CMD(SE.Nereda.Symbols.Mode.RESET_CMDEventArgs ea)
    {
      object[] _values_ = new object[9];
      if (ea.ResetReactor1.HasValue) _values_[0] = ea.ResetReactor1.Value;
      if (ea.ResetReactor2.HasValue) _values_[1] = ea.ResetReactor2.Value;
      if (ea.ResetReactor3.HasValue) _values_[2] = ea.ResetReactor3.Value;
      if (ea.ResetReactor4.HasValue) _values_[3] = ea.ResetReactor4.Value;
      if (ea.ResetReactor5.HasValue) _values_[4] = ea.ResetReactor5.Value;
      if (ea.ResetReactor6.HasValue) _values_[5] = ea.ResetReactor6.Value;
      if (ea.ResetMetalSaltDosing.HasValue) _values_[6] = ea.ResetMetalSaltDosing.Value;
      if (ea.ResetEmergency.HasValue) _values_[7] = ea.ResetEmergency.Value;
      if (ea.ResetSludgeBuffer.HasValue) _values_[8] = ea.ResetSludgeBuffer.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_RESET_CMD(System.Boolean ResetReactor1, bool ignore_ResetReactor1, System.Boolean ResetReactor2, bool ignore_ResetReactor2, System.Boolean ResetReactor3, bool ignore_ResetReactor3, System.Boolean ResetReactor4, bool ignore_ResetReactor4, System.Boolean ResetReactor5, bool ignore_ResetReactor5, System.Boolean ResetReactor6, bool ignore_ResetReactor6, System.Boolean ResetMetalSaltDosing, bool ignore_ResetMetalSaltDosing, System.Boolean ResetEmergency, bool ignore_ResetEmergency, System.Boolean ResetSludgeBuffer, bool ignore_ResetSludgeBuffer)
    {
      object[] _values_ = new object[9];
      if (!ignore_ResetReactor1) _values_[0] = ResetReactor1;
      if (!ignore_ResetReactor2) _values_[1] = ResetReactor2;
      if (!ignore_ResetReactor3) _values_[2] = ResetReactor3;
      if (!ignore_ResetReactor4) _values_[3] = ResetReactor4;
      if (!ignore_ResetReactor5) _values_[4] = ResetReactor5;
      if (!ignore_ResetReactor6) _values_[5] = ResetReactor6;
      if (!ignore_ResetMetalSaltDosing) _values_[6] = ResetMetalSaltDosing;
      if (!ignore_ResetEmergency) _values_[7] = ResetEmergency;
      if (!ignore_ResetSludgeBuffer) _values_[8] = ResetSludgeBuffer;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }

  }
}

namespace SE.Nereda.Symbols.Mode
{
  partial class ResetMetalSaltDosing
  {

    private event EventHandler<SE.Nereda.Symbols.Mode.REQ_STATUSEventArgs> REQ_STATUS_Fired;

    private event EventHandler<SE.Nereda.Symbols.Mode.NEW_RESETEventArgs> NEW_RESET_Fired;

    private event EventHandler<SE.Nereda.Symbols.Mode.REQ_NO_COMMEventArgs> REQ_NO_COMM_Fired;

    private event EventHandler<SE.Nereda.Symbols.Mode.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    protected override void OnEndInit()
    {
      if (REQ_STATUS_Fired != null)
        AttachEventInput(0);
      if (NEW_RESET_Fired != null)
        AttachEventInput(1);
      if (REQ_NO_COMM_Fired != null)
        AttachEventInput(2);
      if (LOAD_PERS_DATA_Fired != null)
        AttachEventInput(3);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (REQ_STATUS_Fired != null)
          {
            try
            {
              REQ_STATUS_Fired(this, new SE.Nereda.Symbols.Mode.REQ_STATUSEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REQ_STATUS_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 1:
          if (NEW_RESET_Fired != null)
          {
            try
            {
              NEW_RESET_Fired(this, new SE.Nereda.Symbols.Mode.NEW_RESETEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","NEW_RESET_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 2:
          if (REQ_NO_COMM_Fired != null)
          {
            try
            {
              REQ_NO_COMM_Fired(this, new SE.Nereda.Symbols.Mode.REQ_NO_COMMEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REQ_NO_COMM_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 3:
          if (LOAD_PERS_DATA_Fired != null)
          {
            try
            {
              LOAD_PERS_DATA_Fired(this, new SE.Nereda.Symbols.Mode.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
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
    public bool FireEvent_MODE_HMI(System.Int16 ModeHMI)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {ModeHMI});
    }
    public bool FireEvent_MODE_HMI(SE.Nereda.Symbols.Mode.MODE_HMIEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.ModeHMI.HasValue) _values_[0] = ea.ModeHMI.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_MODE_HMI(System.Int16 ModeHMI, bool ignore_ModeHMI)
    {
      object[] _values_ = new object[1];
      if (!ignore_ModeHMI) _values_[0] = ModeHMI;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_RESET_CMD(System.Boolean ResetReactor1, System.Boolean ResetReactor2, System.Boolean ResetReactor3, System.Boolean ResetReactor4, System.Boolean ResetReactor5, System.Boolean ResetReactor6, System.Boolean ResetMetalSaltDosing, System.Boolean ResetEmergency, System.Boolean ResetSludgeBuffer)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {ResetReactor1, ResetReactor2, ResetReactor3, ResetReactor4, ResetReactor5, ResetReactor6, ResetMetalSaltDosing, ResetEmergency, ResetSludgeBuffer});
    }
    public bool FireEvent_RESET_CMD(SE.Nereda.Symbols.Mode.RESET_CMDEventArgs ea)
    {
      object[] _values_ = new object[9];
      if (ea.ResetReactor1.HasValue) _values_[0] = ea.ResetReactor1.Value;
      if (ea.ResetReactor2.HasValue) _values_[1] = ea.ResetReactor2.Value;
      if (ea.ResetReactor3.HasValue) _values_[2] = ea.ResetReactor3.Value;
      if (ea.ResetReactor4.HasValue) _values_[3] = ea.ResetReactor4.Value;
      if (ea.ResetReactor5.HasValue) _values_[4] = ea.ResetReactor5.Value;
      if (ea.ResetReactor6.HasValue) _values_[5] = ea.ResetReactor6.Value;
      if (ea.ResetMetalSaltDosing.HasValue) _values_[6] = ea.ResetMetalSaltDosing.Value;
      if (ea.ResetEmergency.HasValue) _values_[7] = ea.ResetEmergency.Value;
      if (ea.ResetSludgeBuffer.HasValue) _values_[8] = ea.ResetSludgeBuffer.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_RESET_CMD(System.Boolean ResetReactor1, bool ignore_ResetReactor1, System.Boolean ResetReactor2, bool ignore_ResetReactor2, System.Boolean ResetReactor3, bool ignore_ResetReactor3, System.Boolean ResetReactor4, bool ignore_ResetReactor4, System.Boolean ResetReactor5, bool ignore_ResetReactor5, System.Boolean ResetReactor6, bool ignore_ResetReactor6, System.Boolean ResetMetalSaltDosing, bool ignore_ResetMetalSaltDosing, System.Boolean ResetEmergency, bool ignore_ResetEmergency, System.Boolean ResetSludgeBuffer, bool ignore_ResetSludgeBuffer)
    {
      object[] _values_ = new object[9];
      if (!ignore_ResetReactor1) _values_[0] = ResetReactor1;
      if (!ignore_ResetReactor2) _values_[1] = ResetReactor2;
      if (!ignore_ResetReactor3) _values_[2] = ResetReactor3;
      if (!ignore_ResetReactor4) _values_[3] = ResetReactor4;
      if (!ignore_ResetReactor5) _values_[4] = ResetReactor5;
      if (!ignore_ResetReactor6) _values_[5] = ResetReactor6;
      if (!ignore_ResetMetalSaltDosing) _values_[6] = ResetMetalSaltDosing;
      if (!ignore_ResetEmergency) _values_[7] = ResetEmergency;
      if (!ignore_ResetSludgeBuffer) _values_[8] = ResetSludgeBuffer;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }

  }
}

namespace SE.Nereda.Symbols.Mode
{
  partial class ResetReactor5
  {

    private event EventHandler<SE.Nereda.Symbols.Mode.REQ_STATUSEventArgs> REQ_STATUS_Fired;

    private event EventHandler<SE.Nereda.Symbols.Mode.NEW_RESETEventArgs> NEW_RESET_Fired;

    private event EventHandler<SE.Nereda.Symbols.Mode.REQ_NO_COMMEventArgs> REQ_NO_COMM_Fired;

    private event EventHandler<SE.Nereda.Symbols.Mode.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    protected override void OnEndInit()
    {
      if (REQ_STATUS_Fired != null)
        AttachEventInput(0);
      if (NEW_RESET_Fired != null)
        AttachEventInput(1);
      if (REQ_NO_COMM_Fired != null)
        AttachEventInput(2);
      if (LOAD_PERS_DATA_Fired != null)
        AttachEventInput(3);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (REQ_STATUS_Fired != null)
          {
            try
            {
              REQ_STATUS_Fired(this, new SE.Nereda.Symbols.Mode.REQ_STATUSEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REQ_STATUS_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 1:
          if (NEW_RESET_Fired != null)
          {
            try
            {
              NEW_RESET_Fired(this, new SE.Nereda.Symbols.Mode.NEW_RESETEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","NEW_RESET_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 2:
          if (REQ_NO_COMM_Fired != null)
          {
            try
            {
              REQ_NO_COMM_Fired(this, new SE.Nereda.Symbols.Mode.REQ_NO_COMMEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REQ_NO_COMM_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 3:
          if (LOAD_PERS_DATA_Fired != null)
          {
            try
            {
              LOAD_PERS_DATA_Fired(this, new SE.Nereda.Symbols.Mode.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
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
    public bool FireEvent_MODE_HMI(System.Int16 ModeHMI)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {ModeHMI});
    }
    public bool FireEvent_MODE_HMI(SE.Nereda.Symbols.Mode.MODE_HMIEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.ModeHMI.HasValue) _values_[0] = ea.ModeHMI.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_MODE_HMI(System.Int16 ModeHMI, bool ignore_ModeHMI)
    {
      object[] _values_ = new object[1];
      if (!ignore_ModeHMI) _values_[0] = ModeHMI;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_RESET_CMD(System.Boolean ResetReactor1, System.Boolean ResetReactor2, System.Boolean ResetReactor3, System.Boolean ResetReactor4, System.Boolean ResetReactor5, System.Boolean ResetReactor6, System.Boolean ResetMetalSaltDosing, System.Boolean ResetEmergency, System.Boolean ResetSludgeBuffer)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {ResetReactor1, ResetReactor2, ResetReactor3, ResetReactor4, ResetReactor5, ResetReactor6, ResetMetalSaltDosing, ResetEmergency, ResetSludgeBuffer});
    }
    public bool FireEvent_RESET_CMD(SE.Nereda.Symbols.Mode.RESET_CMDEventArgs ea)
    {
      object[] _values_ = new object[9];
      if (ea.ResetReactor1.HasValue) _values_[0] = ea.ResetReactor1.Value;
      if (ea.ResetReactor2.HasValue) _values_[1] = ea.ResetReactor2.Value;
      if (ea.ResetReactor3.HasValue) _values_[2] = ea.ResetReactor3.Value;
      if (ea.ResetReactor4.HasValue) _values_[3] = ea.ResetReactor4.Value;
      if (ea.ResetReactor5.HasValue) _values_[4] = ea.ResetReactor5.Value;
      if (ea.ResetReactor6.HasValue) _values_[5] = ea.ResetReactor6.Value;
      if (ea.ResetMetalSaltDosing.HasValue) _values_[6] = ea.ResetMetalSaltDosing.Value;
      if (ea.ResetEmergency.HasValue) _values_[7] = ea.ResetEmergency.Value;
      if (ea.ResetSludgeBuffer.HasValue) _values_[8] = ea.ResetSludgeBuffer.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_RESET_CMD(System.Boolean ResetReactor1, bool ignore_ResetReactor1, System.Boolean ResetReactor2, bool ignore_ResetReactor2, System.Boolean ResetReactor3, bool ignore_ResetReactor3, System.Boolean ResetReactor4, bool ignore_ResetReactor4, System.Boolean ResetReactor5, bool ignore_ResetReactor5, System.Boolean ResetReactor6, bool ignore_ResetReactor6, System.Boolean ResetMetalSaltDosing, bool ignore_ResetMetalSaltDosing, System.Boolean ResetEmergency, bool ignore_ResetEmergency, System.Boolean ResetSludgeBuffer, bool ignore_ResetSludgeBuffer)
    {
      object[] _values_ = new object[9];
      if (!ignore_ResetReactor1) _values_[0] = ResetReactor1;
      if (!ignore_ResetReactor2) _values_[1] = ResetReactor2;
      if (!ignore_ResetReactor3) _values_[2] = ResetReactor3;
      if (!ignore_ResetReactor4) _values_[3] = ResetReactor4;
      if (!ignore_ResetReactor5) _values_[4] = ResetReactor5;
      if (!ignore_ResetReactor6) _values_[5] = ResetReactor6;
      if (!ignore_ResetMetalSaltDosing) _values_[6] = ResetMetalSaltDosing;
      if (!ignore_ResetEmergency) _values_[7] = ResetEmergency;
      if (!ignore_ResetSludgeBuffer) _values_[8] = ResetSludgeBuffer;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }

  }
}

namespace SE.Nereda.Symbols.Mode
{
  partial class ResetReactor6
  {

    private event EventHandler<SE.Nereda.Symbols.Mode.REQ_STATUSEventArgs> REQ_STATUS_Fired;

    private event EventHandler<SE.Nereda.Symbols.Mode.NEW_RESETEventArgs> NEW_RESET_Fired;

    private event EventHandler<SE.Nereda.Symbols.Mode.REQ_NO_COMMEventArgs> REQ_NO_COMM_Fired;

    private event EventHandler<SE.Nereda.Symbols.Mode.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    protected override void OnEndInit()
    {
      if (REQ_STATUS_Fired != null)
        AttachEventInput(0);
      if (NEW_RESET_Fired != null)
        AttachEventInput(1);
      if (REQ_NO_COMM_Fired != null)
        AttachEventInput(2);
      if (LOAD_PERS_DATA_Fired != null)
        AttachEventInput(3);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (REQ_STATUS_Fired != null)
          {
            try
            {
              REQ_STATUS_Fired(this, new SE.Nereda.Symbols.Mode.REQ_STATUSEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REQ_STATUS_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 1:
          if (NEW_RESET_Fired != null)
          {
            try
            {
              NEW_RESET_Fired(this, new SE.Nereda.Symbols.Mode.NEW_RESETEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","NEW_RESET_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 2:
          if (REQ_NO_COMM_Fired != null)
          {
            try
            {
              REQ_NO_COMM_Fired(this, new SE.Nereda.Symbols.Mode.REQ_NO_COMMEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REQ_NO_COMM_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 3:
          if (LOAD_PERS_DATA_Fired != null)
          {
            try
            {
              LOAD_PERS_DATA_Fired(this, new SE.Nereda.Symbols.Mode.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
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
    public bool FireEvent_MODE_HMI(System.Int16 ModeHMI)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {ModeHMI});
    }
    public bool FireEvent_MODE_HMI(SE.Nereda.Symbols.Mode.MODE_HMIEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.ModeHMI.HasValue) _values_[0] = ea.ModeHMI.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_MODE_HMI(System.Int16 ModeHMI, bool ignore_ModeHMI)
    {
      object[] _values_ = new object[1];
      if (!ignore_ModeHMI) _values_[0] = ModeHMI;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_RESET_CMD(System.Boolean ResetReactor1, System.Boolean ResetReactor2, System.Boolean ResetReactor3, System.Boolean ResetReactor4, System.Boolean ResetReactor5, System.Boolean ResetReactor6, System.Boolean ResetMetalSaltDosing, System.Boolean ResetEmergency, System.Boolean ResetSludgeBuffer)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {ResetReactor1, ResetReactor2, ResetReactor3, ResetReactor4, ResetReactor5, ResetReactor6, ResetMetalSaltDosing, ResetEmergency, ResetSludgeBuffer});
    }
    public bool FireEvent_RESET_CMD(SE.Nereda.Symbols.Mode.RESET_CMDEventArgs ea)
    {
      object[] _values_ = new object[9];
      if (ea.ResetReactor1.HasValue) _values_[0] = ea.ResetReactor1.Value;
      if (ea.ResetReactor2.HasValue) _values_[1] = ea.ResetReactor2.Value;
      if (ea.ResetReactor3.HasValue) _values_[2] = ea.ResetReactor3.Value;
      if (ea.ResetReactor4.HasValue) _values_[3] = ea.ResetReactor4.Value;
      if (ea.ResetReactor5.HasValue) _values_[4] = ea.ResetReactor5.Value;
      if (ea.ResetReactor6.HasValue) _values_[5] = ea.ResetReactor6.Value;
      if (ea.ResetMetalSaltDosing.HasValue) _values_[6] = ea.ResetMetalSaltDosing.Value;
      if (ea.ResetEmergency.HasValue) _values_[7] = ea.ResetEmergency.Value;
      if (ea.ResetSludgeBuffer.HasValue) _values_[8] = ea.ResetSludgeBuffer.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_RESET_CMD(System.Boolean ResetReactor1, bool ignore_ResetReactor1, System.Boolean ResetReactor2, bool ignore_ResetReactor2, System.Boolean ResetReactor3, bool ignore_ResetReactor3, System.Boolean ResetReactor4, bool ignore_ResetReactor4, System.Boolean ResetReactor5, bool ignore_ResetReactor5, System.Boolean ResetReactor6, bool ignore_ResetReactor6, System.Boolean ResetMetalSaltDosing, bool ignore_ResetMetalSaltDosing, System.Boolean ResetEmergency, bool ignore_ResetEmergency, System.Boolean ResetSludgeBuffer, bool ignore_ResetSludgeBuffer)
    {
      object[] _values_ = new object[9];
      if (!ignore_ResetReactor1) _values_[0] = ResetReactor1;
      if (!ignore_ResetReactor2) _values_[1] = ResetReactor2;
      if (!ignore_ResetReactor3) _values_[2] = ResetReactor3;
      if (!ignore_ResetReactor4) _values_[3] = ResetReactor4;
      if (!ignore_ResetReactor5) _values_[4] = ResetReactor5;
      if (!ignore_ResetReactor6) _values_[5] = ResetReactor6;
      if (!ignore_ResetMetalSaltDosing) _values_[6] = ResetMetalSaltDosing;
      if (!ignore_ResetEmergency) _values_[7] = ResetEmergency;
      if (!ignore_ResetSludgeBuffer) _values_[8] = ResetSludgeBuffer;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }

  }
}
#endregion #Mode_HMI;

#endregion Definitions;
