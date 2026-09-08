/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 6/2/2026
 * Time: 9:20 AM
 * 
 */
using System;
using NxtControl.GuiFramework;
using NxtControl.Services;

#region Definitions;
#region #MotorS_HMI;

namespace SE.Nereda.Symbols.MotorS
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

  public class FB_STATEEventArgs : System.EventArgs
  {
    IHMIAccessorService accessorService;
    int channelId;
    int cookie; 
    int eventIndex;

    public FB_STATEEventArgs(int channelId, int cookie, int eventIndex)
    {
      this.accessorService = (IHMIAccessorService)ServiceProvider.GetService(typeof(IHMIAccessorService));
      this.channelId = channelId;
      this.cookie = cookie;
      this.eventIndex = eventIndex;
    }
    public bool Get_ElectricCircuitFail(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,0, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? ElectricCircuitFail
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,0, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_AtvNotReady(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,1, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? AtvNotReady
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,1, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }


  }

  public class NEED_RESETEventArgs : System.EventArgs
  {
    IHMIAccessorService accessorService;
    int channelId;
    int cookie; 
    int eventIndex;

    public NEED_RESETEventArgs(int channelId, int cookie, int eventIndex)
    {
      this.accessorService = (IHMIAccessorService)ServiceProvider.GetService(typeof(IHMIAccessorService));
      this.channelId = channelId;
      this.cookie = cookie;
      this.eventIndex = eventIndex;
    }
    public bool Get_NeedReset(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,0, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? NeedReset
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,0, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }


  }

  public class FB_FAILEventArgs : System.EventArgs
  {
    IHMIAccessorService accessorService;
    int channelId;
    int cookie; 
    int eventIndex;

    public FB_FAILEventArgs(int channelId, int cookie, int eventIndex)
    {
      this.accessorService = (IHMIAccessorService)ServiceProvider.GetService(typeof(IHMIAccessorService));
      this.channelId = channelId;
      this.cookie = cookie;
      this.eventIndex = eventIndex;
    }
    public bool Get_FbFailure(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,0, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? FbFailure
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,0, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }


  }

}

namespace SE.Nereda.Symbols.MotorS
{

  public class CNF_ATV_EXISTEventArgs : System.EventArgs
  {
    public CNF_ATV_EXISTEventArgs()
    {
    }
    private System.Boolean? AtvExist_field = null;
    public System.Boolean? AtvExist
    {
       get { return AtvExist_field; }
       set { AtvExist_field = value; }
    }

  }

  public class RESETEventArgs : System.EventArgs
  {
    public RESETEventArgs()
    {
    }
    private System.Boolean? Reset_field = null;
    public System.Boolean? Reset
    {
       get { return Reset_field; }
       set { Reset_field = value; }
    }

  }

}

namespace SE.Nereda.Symbols.MotorS
{
  partial class sDefault
  {

    private event EventHandler<SE.Nereda.Symbols.MotorS.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    private event EventHandler<SE.Nereda.Symbols.MotorS.FB_STATEEventArgs> FB_STATE_Fired;

    private event EventHandler<SE.Nereda.Symbols.MotorS.NEED_RESETEventArgs> NEED_RESET_Fired;

    private event EventHandler<SE.Nereda.Symbols.MotorS.FB_FAILEventArgs> FB_FAIL_Fired;

    protected override void OnEndInit()
    {
      if (LOAD_PERS_DATA_Fired != null)
        AttachEventInput(0);
      if (FB_STATE_Fired != null)
        AttachEventInput(1);
      if (NEED_RESET_Fired != null)
        AttachEventInput(2);
      if (FB_FAIL_Fired != null)
        AttachEventInput(3);

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
              LOAD_PERS_DATA_Fired(this, new SE.Nereda.Symbols.MotorS.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
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
          if (FB_STATE_Fired != null)
          {
            try
            {
              FB_STATE_Fired(this, new SE.Nereda.Symbols.MotorS.FB_STATEEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","FB_STATE_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 2:
          if (NEED_RESET_Fired != null)
          {
            try
            {
              NEED_RESET_Fired(this, new SE.Nereda.Symbols.MotorS.NEED_RESETEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","NEED_RESET_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 3:
          if (FB_FAIL_Fired != null)
          {
            try
            {
              FB_FAIL_Fired(this, new SE.Nereda.Symbols.MotorS.FB_FAILEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","FB_FAIL_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_CNF_ATV_EXIST(System.Boolean AtvExist)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {AtvExist});
    }
    public bool FireEvent_CNF_ATV_EXIST(SE.Nereda.Symbols.MotorS.CNF_ATV_EXISTEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.AtvExist.HasValue) _values_[0] = ea.AtvExist.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_CNF_ATV_EXIST(System.Boolean AtvExist, bool ignore_AtvExist)
    {
      object[] _values_ = new object[1];
      if (!ignore_AtvExist) _values_[0] = AtvExist;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_RESET(System.Boolean Reset)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {Reset});
    }
    public bool FireEvent_RESET(SE.Nereda.Symbols.MotorS.RESETEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.Reset.HasValue) _values_[0] = ea.Reset.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_RESET(System.Boolean Reset, bool ignore_Reset)
    {
      object[] _values_ = new object[1];
      if (!ignore_Reset) _values_[0] = Reset;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }

  }
}

namespace SE.Nereda.Faceplates.MotorS
{
  partial class fpOptions
  {

    private event EventHandler<SE.Nereda.Symbols.MotorS.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    private event EventHandler<SE.Nereda.Symbols.MotorS.FB_STATEEventArgs> FB_STATE_Fired;

    private event EventHandler<SE.Nereda.Symbols.MotorS.NEED_RESETEventArgs> NEED_RESET_Fired;

    private event EventHandler<SE.Nereda.Symbols.MotorS.FB_FAILEventArgs> FB_FAIL_Fired;

    protected override void OnEndInit()
    {
      if (LOAD_PERS_DATA_Fired != null)
        AttachEventInput(0);
      if (FB_STATE_Fired != null)
        AttachEventInput(1);
      if (NEED_RESET_Fired != null)
        AttachEventInput(2);
      if (FB_FAIL_Fired != null)
        AttachEventInput(3);

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
              LOAD_PERS_DATA_Fired(this, new SE.Nereda.Symbols.MotorS.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
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
          if (FB_STATE_Fired != null)
          {
            try
            {
              FB_STATE_Fired(this, new SE.Nereda.Symbols.MotorS.FB_STATEEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","FB_STATE_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 2:
          if (NEED_RESET_Fired != null)
          {
            try
            {
              NEED_RESET_Fired(this, new SE.Nereda.Symbols.MotorS.NEED_RESETEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","NEED_RESET_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 3:
          if (FB_FAIL_Fired != null)
          {
            try
            {
              FB_FAIL_Fired(this, new SE.Nereda.Symbols.MotorS.FB_FAILEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","FB_FAIL_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_CNF_ATV_EXIST(System.Boolean AtvExist)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {AtvExist});
    }
    public bool FireEvent_CNF_ATV_EXIST(SE.Nereda.Symbols.MotorS.CNF_ATV_EXISTEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.AtvExist.HasValue) _values_[0] = ea.AtvExist.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_CNF_ATV_EXIST(System.Boolean AtvExist, bool ignore_AtvExist)
    {
      object[] _values_ = new object[1];
      if (!ignore_AtvExist) _values_[0] = AtvExist;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_RESET(System.Boolean Reset)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {Reset});
    }
    public bool FireEvent_RESET(SE.Nereda.Symbols.MotorS.RESETEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.Reset.HasValue) _values_[0] = ea.Reset.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_RESET(System.Boolean Reset, bool ignore_Reset)
    {
      object[] _values_ = new object[1];
      if (!ignore_Reset) _values_[0] = Reset;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }

  }
}

namespace SE.Nereda.Faceplates.MotorS
{
  partial class fpLocalPanel
  {

    private event EventHandler<SE.Nereda.Symbols.MotorS.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    private event EventHandler<SE.Nereda.Symbols.MotorS.FB_STATEEventArgs> FB_STATE_Fired;

    private event EventHandler<SE.Nereda.Symbols.MotorS.NEED_RESETEventArgs> NEED_RESET_Fired;

    private event EventHandler<SE.Nereda.Symbols.MotorS.FB_FAILEventArgs> FB_FAIL_Fired;

    protected override void OnEndInit()
    {
      if (LOAD_PERS_DATA_Fired != null)
        AttachEventInput(0);
      if (FB_STATE_Fired != null)
        AttachEventInput(1);
      if (NEED_RESET_Fired != null)
        AttachEventInput(2);
      if (FB_FAIL_Fired != null)
        AttachEventInput(3);

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
              LOAD_PERS_DATA_Fired(this, new SE.Nereda.Symbols.MotorS.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
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
          if (FB_STATE_Fired != null)
          {
            try
            {
              FB_STATE_Fired(this, new SE.Nereda.Symbols.MotorS.FB_STATEEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","FB_STATE_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 2:
          if (NEED_RESET_Fired != null)
          {
            try
            {
              NEED_RESET_Fired(this, new SE.Nereda.Symbols.MotorS.NEED_RESETEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","NEED_RESET_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 3:
          if (FB_FAIL_Fired != null)
          {
            try
            {
              FB_FAIL_Fired(this, new SE.Nereda.Symbols.MotorS.FB_FAILEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","FB_FAIL_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_CNF_ATV_EXIST(System.Boolean AtvExist)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {AtvExist});
    }
    public bool FireEvent_CNF_ATV_EXIST(SE.Nereda.Symbols.MotorS.CNF_ATV_EXISTEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.AtvExist.HasValue) _values_[0] = ea.AtvExist.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_CNF_ATV_EXIST(System.Boolean AtvExist, bool ignore_AtvExist)
    {
      object[] _values_ = new object[1];
      if (!ignore_AtvExist) _values_[0] = AtvExist;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_RESET(System.Boolean Reset)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {Reset});
    }
    public bool FireEvent_RESET(SE.Nereda.Symbols.MotorS.RESETEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.Reset.HasValue) _values_[0] = ea.Reset.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_RESET(System.Boolean Reset, bool ignore_Reset)
    {
      object[] _values_ = new object[1];
      if (!ignore_Reset) _values_[0] = Reset;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }

  }
}

namespace SE.Nereda.Symbols.MotorS
{
  partial class sMotor
  {

    private event EventHandler<SE.Nereda.Symbols.MotorS.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    private event EventHandler<SE.Nereda.Symbols.MotorS.FB_STATEEventArgs> FB_STATE_Fired;

    private event EventHandler<SE.Nereda.Symbols.MotorS.NEED_RESETEventArgs> NEED_RESET_Fired;

    private event EventHandler<SE.Nereda.Symbols.MotorS.FB_FAILEventArgs> FB_FAIL_Fired;

    protected override void OnEndInit()
    {
      if (LOAD_PERS_DATA_Fired != null)
        AttachEventInput(0);
      if (FB_STATE_Fired != null)
        AttachEventInput(1);
      if (NEED_RESET_Fired != null)
        AttachEventInput(2);
      if (FB_FAIL_Fired != null)
        AttachEventInput(3);

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
              LOAD_PERS_DATA_Fired(this, new SE.Nereda.Symbols.MotorS.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
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
          if (FB_STATE_Fired != null)
          {
            try
            {
              FB_STATE_Fired(this, new SE.Nereda.Symbols.MotorS.FB_STATEEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","FB_STATE_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 2:
          if (NEED_RESET_Fired != null)
          {
            try
            {
              NEED_RESET_Fired(this, new SE.Nereda.Symbols.MotorS.NEED_RESETEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","NEED_RESET_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 3:
          if (FB_FAIL_Fired != null)
          {
            try
            {
              FB_FAIL_Fired(this, new SE.Nereda.Symbols.MotorS.FB_FAILEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","FB_FAIL_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_CNF_ATV_EXIST(System.Boolean AtvExist)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {AtvExist});
    }
    public bool FireEvent_CNF_ATV_EXIST(SE.Nereda.Symbols.MotorS.CNF_ATV_EXISTEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.AtvExist.HasValue) _values_[0] = ea.AtvExist.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_CNF_ATV_EXIST(System.Boolean AtvExist, bool ignore_AtvExist)
    {
      object[] _values_ = new object[1];
      if (!ignore_AtvExist) _values_[0] = AtvExist;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_RESET(System.Boolean Reset)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {Reset});
    }
    public bool FireEvent_RESET(SE.Nereda.Symbols.MotorS.RESETEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.Reset.HasValue) _values_[0] = ea.Reset.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_RESET(System.Boolean Reset, bool ignore_Reset)
    {
      object[] _values_ = new object[1];
      if (!ignore_Reset) _values_[0] = Reset;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }

  }
}

namespace SE.Nereda.Symbols.MotorS
{
  partial class sFan
  {

    private event EventHandler<SE.Nereda.Symbols.MotorS.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    private event EventHandler<SE.Nereda.Symbols.MotorS.FB_STATEEventArgs> FB_STATE_Fired;

    private event EventHandler<SE.Nereda.Symbols.MotorS.NEED_RESETEventArgs> NEED_RESET_Fired;

    private event EventHandler<SE.Nereda.Symbols.MotorS.FB_FAILEventArgs> FB_FAIL_Fired;

    protected override void OnEndInit()
    {
      if (LOAD_PERS_DATA_Fired != null)
        AttachEventInput(0);
      if (FB_STATE_Fired != null)
        AttachEventInput(1);
      if (NEED_RESET_Fired != null)
        AttachEventInput(2);
      if (FB_FAIL_Fired != null)
        AttachEventInput(3);

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
              LOAD_PERS_DATA_Fired(this, new SE.Nereda.Symbols.MotorS.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
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
          if (FB_STATE_Fired != null)
          {
            try
            {
              FB_STATE_Fired(this, new SE.Nereda.Symbols.MotorS.FB_STATEEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","FB_STATE_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 2:
          if (NEED_RESET_Fired != null)
          {
            try
            {
              NEED_RESET_Fired(this, new SE.Nereda.Symbols.MotorS.NEED_RESETEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","NEED_RESET_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 3:
          if (FB_FAIL_Fired != null)
          {
            try
            {
              FB_FAIL_Fired(this, new SE.Nereda.Symbols.MotorS.FB_FAILEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","FB_FAIL_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_CNF_ATV_EXIST(System.Boolean AtvExist)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {AtvExist});
    }
    public bool FireEvent_CNF_ATV_EXIST(SE.Nereda.Symbols.MotorS.CNF_ATV_EXISTEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.AtvExist.HasValue) _values_[0] = ea.AtvExist.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_CNF_ATV_EXIST(System.Boolean AtvExist, bool ignore_AtvExist)
    {
      object[] _values_ = new object[1];
      if (!ignore_AtvExist) _values_[0] = AtvExist;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_RESET(System.Boolean Reset)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {Reset});
    }
    public bool FireEvent_RESET(SE.Nereda.Symbols.MotorS.RESETEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.Reset.HasValue) _values_[0] = ea.Reset.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_RESET(System.Boolean Reset, bool ignore_Reset)
    {
      object[] _values_ = new object[1];
      if (!ignore_Reset) _values_[0] = Reset;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }

  }
}

namespace SE.Nereda.Symbols.MotorS
{
  partial class sPump
  {

    private event EventHandler<SE.Nereda.Symbols.MotorS.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    private event EventHandler<SE.Nereda.Symbols.MotorS.FB_STATEEventArgs> FB_STATE_Fired;

    private event EventHandler<SE.Nereda.Symbols.MotorS.NEED_RESETEventArgs> NEED_RESET_Fired;

    private event EventHandler<SE.Nereda.Symbols.MotorS.FB_FAILEventArgs> FB_FAIL_Fired;

    protected override void OnEndInit()
    {
      if (LOAD_PERS_DATA_Fired != null)
        AttachEventInput(0);
      if (FB_STATE_Fired != null)
        AttachEventInput(1);
      if (NEED_RESET_Fired != null)
        AttachEventInput(2);
      if (FB_FAIL_Fired != null)
        AttachEventInput(3);

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
              LOAD_PERS_DATA_Fired(this, new SE.Nereda.Symbols.MotorS.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
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
          if (FB_STATE_Fired != null)
          {
            try
            {
              FB_STATE_Fired(this, new SE.Nereda.Symbols.MotorS.FB_STATEEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","FB_STATE_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 2:
          if (NEED_RESET_Fired != null)
          {
            try
            {
              NEED_RESET_Fired(this, new SE.Nereda.Symbols.MotorS.NEED_RESETEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","NEED_RESET_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 3:
          if (FB_FAIL_Fired != null)
          {
            try
            {
              FB_FAIL_Fired(this, new SE.Nereda.Symbols.MotorS.FB_FAILEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","FB_FAIL_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_CNF_ATV_EXIST(System.Boolean AtvExist)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {AtvExist});
    }
    public bool FireEvent_CNF_ATV_EXIST(SE.Nereda.Symbols.MotorS.CNF_ATV_EXISTEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.AtvExist.HasValue) _values_[0] = ea.AtvExist.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_CNF_ATV_EXIST(System.Boolean AtvExist, bool ignore_AtvExist)
    {
      object[] _values_ = new object[1];
      if (!ignore_AtvExist) _values_[0] = AtvExist;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_RESET(System.Boolean Reset)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {Reset});
    }
    public bool FireEvent_RESET(SE.Nereda.Symbols.MotorS.RESETEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.Reset.HasValue) _values_[0] = ea.Reset.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_RESET(System.Boolean Reset, bool ignore_Reset)
    {
      object[] _values_ = new object[1];
      if (!ignore_Reset) _values_[0] = Reset;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }

  }
}
#endregion #MotorS_HMI;

#endregion Definitions;
