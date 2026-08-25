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
#region #Motor_VS_HMI;

namespace SE.Nereda.Symbols.Motor_VS
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

  public class SPEED_SP_FBEventArgs : System.EventArgs
  {
    IHMIAccessorService accessorService;
    int channelId;
    int cookie; 
    int eventIndex;

    public SPEED_SP_FBEventArgs(int channelId, int cookie, int eventIndex)
    {
      this.accessorService = (IHMIAccessorService)ServiceProvider.GetService(typeof(IHMIAccessorService));
      this.channelId = channelId;
      this.cookie = cookie;
      this.eventIndex = eventIndex;
    }
    public bool Get_SpeedSp(ref System.Single value)
    {
      if (accessorService == null)
        return false;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,0, ref var);
      if (ret) value = (System.Single) var;
      return ret;
    }

    public System.Single? SpeedSp
    { get {
      if (accessorService == null)
        return null;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,0, ref var);
      if (!ret) return null;
      return (System.Single) var;
    }  }

    public bool Get_FbSpeed(ref System.Single value)
    {
      if (accessorService == null)
        return false;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,1, ref var);
      if (ret) value = (System.Single) var;
      return ret;
    }

    public System.Single? FbSpeed
    { get {
      if (accessorService == null)
        return null;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,1, ref var);
      if (!ret) return null;
      return (System.Single) var;
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

  public class FB_FWDEventArgs : System.EventArgs
  {
    IHMIAccessorService accessorService;
    int channelId;
    int cookie; 
    int eventIndex;

    public FB_FWDEventArgs(int channelId, int cookie, int eventIndex)
    {
      this.accessorService = (IHMIAccessorService)ServiceProvider.GetService(typeof(IHMIAccessorService));
      this.channelId = channelId;
      this.cookie = cookie;
      this.eventIndex = eventIndex;
    }
    public bool Get_FbFwd(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,0, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? FbFwd
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,0, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }


  }

  public class FB_CAPACITYEventArgs : System.EventArgs
  {
    IHMIAccessorService accessorService;
    int channelId;
    int cookie; 
    int eventIndex;

    public FB_CAPACITYEventArgs(int channelId, int cookie, int eventIndex)
    {
      this.accessorService = (IHMIAccessorService)ServiceProvider.GetService(typeof(IHMIAccessorService));
      this.channelId = channelId;
      this.cookie = cookie;
      this.eventIndex = eventIndex;
    }

  }

}

namespace SE.Nereda.Symbols.Motor_VS
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

  public class SPEED_SP_CONFEventArgs : System.EventArgs
  {
    public SPEED_SP_CONFEventArgs()
    {
    }
    private System.Single? SpeedSpMin_field = null;
    public System.Single? SpeedSpMin
    {
       get { return SpeedSpMin_field; }
       set { SpeedSpMin_field = value; }
    }
    private System.Single? SpeedSpMax_field = null;
    public System.Single? SpeedSpMax
    {
       get { return SpeedSpMax_field; }
       set { SpeedSpMax_field = value; }
    }

  }

}

namespace SE.Nereda.Symbols.Motor_VS
{
  partial class sDefault
  {

    private event EventHandler<SE.Nereda.Symbols.Motor_VS.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    private event EventHandler<SE.Nereda.Symbols.Motor_VS.FB_STATEEventArgs> FB_STATE_Fired;

    private event EventHandler<SE.Nereda.Symbols.Motor_VS.SPEED_SP_FBEventArgs> SPEED_SP_FB_Fired;

    private event EventHandler<SE.Nereda.Symbols.Motor_VS.NEED_RESETEventArgs> NEED_RESET_Fired;

    private event EventHandler<SE.Nereda.Symbols.Motor_VS.FB_FAILEventArgs> FB_FAIL_Fired;

    private event EventHandler<SE.Nereda.Symbols.Motor_VS.FB_FWDEventArgs> FB_FWD_Fired;

    private event EventHandler<SE.Nereda.Symbols.Motor_VS.FB_CAPACITYEventArgs> FB_CAPACITY_Fired;

    protected override void OnEndInit()
    {
      if (LOAD_PERS_DATA_Fired != null)
        AttachEventInput(0);
      if (FB_STATE_Fired != null)
        AttachEventInput(1);
      if (SPEED_SP_FB_Fired != null)
        AttachEventInput(2);
      if (NEED_RESET_Fired != null)
        AttachEventInput(3);
      if (FB_FAIL_Fired != null)
        AttachEventInput(4);
      if (FB_FWD_Fired != null)
        AttachEventInput(5);
      if (FB_CAPACITY_Fired != null)
        AttachEventInput(6);

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
              LOAD_PERS_DATA_Fired(this, new SE.Nereda.Symbols.Motor_VS.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
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
              FB_STATE_Fired(this, new SE.Nereda.Symbols.Motor_VS.FB_STATEEventArgs(channelId, cookie, eventIndex));
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
          if (SPEED_SP_FB_Fired != null)
          {
            try
            {
              SPEED_SP_FB_Fired(this, new SE.Nereda.Symbols.Motor_VS.SPEED_SP_FBEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","SPEED_SP_FB_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 3:
          if (NEED_RESET_Fired != null)
          {
            try
            {
              NEED_RESET_Fired(this, new SE.Nereda.Symbols.Motor_VS.NEED_RESETEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","NEED_RESET_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 4:
          if (FB_FAIL_Fired != null)
          {
            try
            {
              FB_FAIL_Fired(this, new SE.Nereda.Symbols.Motor_VS.FB_FAILEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","FB_FAIL_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 5:
          if (FB_FWD_Fired != null)
          {
            try
            {
              FB_FWD_Fired(this, new SE.Nereda.Symbols.Motor_VS.FB_FWDEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","FB_FWD_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 6:
          if (FB_CAPACITY_Fired != null)
          {
            try
            {
              FB_CAPACITY_Fired(this, new SE.Nereda.Symbols.Motor_VS.FB_CAPACITYEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","FB_CAPACITY_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_CNF_ATV_EXIST(System.Boolean AtvExist)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {AtvExist});
    }
    public bool FireEvent_CNF_ATV_EXIST(SE.Nereda.Symbols.Motor_VS.CNF_ATV_EXISTEventArgs ea)
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
    public bool FireEvent_RESET(SE.Nereda.Symbols.Motor_VS.RESETEventArgs ea)
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
    public bool FireEvent_SPEED_SP_CONF(System.Single SpeedSpMin, System.Single SpeedSpMax)
    {
      return ((IHMIAccessorOutput)this).FireEvent(2, new object[] {SpeedSpMin, SpeedSpMax});
    }
    public bool FireEvent_SPEED_SP_CONF(SE.Nereda.Symbols.Motor_VS.SPEED_SP_CONFEventArgs ea)
    {
      object[] _values_ = new object[2];
      if (ea.SpeedSpMin.HasValue) _values_[0] = ea.SpeedSpMin.Value;
      if (ea.SpeedSpMax.HasValue) _values_[1] = ea.SpeedSpMax.Value;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_SPEED_SP_CONF(System.Single SpeedSpMin, bool ignore_SpeedSpMin, System.Single SpeedSpMax, bool ignore_SpeedSpMax)
    {
      object[] _values_ = new object[2];
      if (!ignore_SpeedSpMin) _values_[0] = SpeedSpMin;
      if (!ignore_SpeedSpMax) _values_[1] = SpeedSpMax;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }

  }
}

namespace SE.Nereda.Faceplates.Motor_VS
{
  partial class fpOptions
  {

    private event EventHandler<SE.Nereda.Symbols.Motor_VS.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    private event EventHandler<SE.Nereda.Symbols.Motor_VS.FB_STATEEventArgs> FB_STATE_Fired;

    private event EventHandler<SE.Nereda.Symbols.Motor_VS.SPEED_SP_FBEventArgs> SPEED_SP_FB_Fired;

    private event EventHandler<SE.Nereda.Symbols.Motor_VS.NEED_RESETEventArgs> NEED_RESET_Fired;

    private event EventHandler<SE.Nereda.Symbols.Motor_VS.FB_FAILEventArgs> FB_FAIL_Fired;

    private event EventHandler<SE.Nereda.Symbols.Motor_VS.FB_FWDEventArgs> FB_FWD_Fired;

    private event EventHandler<SE.Nereda.Symbols.Motor_VS.FB_CAPACITYEventArgs> FB_CAPACITY_Fired;

    protected override void OnEndInit()
    {
      if (LOAD_PERS_DATA_Fired != null)
        AttachEventInput(0);
      if (FB_STATE_Fired != null)
        AttachEventInput(1);
      if (SPEED_SP_FB_Fired != null)
        AttachEventInput(2);
      if (NEED_RESET_Fired != null)
        AttachEventInput(3);
      if (FB_FAIL_Fired != null)
        AttachEventInput(4);
      if (FB_FWD_Fired != null)
        AttachEventInput(5);
      if (FB_CAPACITY_Fired != null)
        AttachEventInput(6);

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
              LOAD_PERS_DATA_Fired(this, new SE.Nereda.Symbols.Motor_VS.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
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
              FB_STATE_Fired(this, new SE.Nereda.Symbols.Motor_VS.FB_STATEEventArgs(channelId, cookie, eventIndex));
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
          if (SPEED_SP_FB_Fired != null)
          {
            try
            {
              SPEED_SP_FB_Fired(this, new SE.Nereda.Symbols.Motor_VS.SPEED_SP_FBEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","SPEED_SP_FB_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 3:
          if (NEED_RESET_Fired != null)
          {
            try
            {
              NEED_RESET_Fired(this, new SE.Nereda.Symbols.Motor_VS.NEED_RESETEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","NEED_RESET_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 4:
          if (FB_FAIL_Fired != null)
          {
            try
            {
              FB_FAIL_Fired(this, new SE.Nereda.Symbols.Motor_VS.FB_FAILEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","FB_FAIL_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 5:
          if (FB_FWD_Fired != null)
          {
            try
            {
              FB_FWD_Fired(this, new SE.Nereda.Symbols.Motor_VS.FB_FWDEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","FB_FWD_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 6:
          if (FB_CAPACITY_Fired != null)
          {
            try
            {
              FB_CAPACITY_Fired(this, new SE.Nereda.Symbols.Motor_VS.FB_CAPACITYEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","FB_CAPACITY_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_CNF_ATV_EXIST(System.Boolean AtvExist)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {AtvExist});
    }
    public bool FireEvent_CNF_ATV_EXIST(SE.Nereda.Symbols.Motor_VS.CNF_ATV_EXISTEventArgs ea)
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
    public bool FireEvent_RESET(SE.Nereda.Symbols.Motor_VS.RESETEventArgs ea)
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
    public bool FireEvent_SPEED_SP_CONF(System.Single SpeedSpMin, System.Single SpeedSpMax)
    {
      return ((IHMIAccessorOutput)this).FireEvent(2, new object[] {SpeedSpMin, SpeedSpMax});
    }
    public bool FireEvent_SPEED_SP_CONF(SE.Nereda.Symbols.Motor_VS.SPEED_SP_CONFEventArgs ea)
    {
      object[] _values_ = new object[2];
      if (ea.SpeedSpMin.HasValue) _values_[0] = ea.SpeedSpMin.Value;
      if (ea.SpeedSpMax.HasValue) _values_[1] = ea.SpeedSpMax.Value;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_SPEED_SP_CONF(System.Single SpeedSpMin, bool ignore_SpeedSpMin, System.Single SpeedSpMax, bool ignore_SpeedSpMax)
    {
      object[] _values_ = new object[2];
      if (!ignore_SpeedSpMin) _values_[0] = SpeedSpMin;
      if (!ignore_SpeedSpMax) _values_[1] = SpeedSpMax;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }

  }
}

namespace SE.Nereda.Symbols.Motor_VS
{
  partial class sPump
  {

    private event EventHandler<SE.Nereda.Symbols.Motor_VS.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    private event EventHandler<SE.Nereda.Symbols.Motor_VS.FB_STATEEventArgs> FB_STATE_Fired;

    private event EventHandler<SE.Nereda.Symbols.Motor_VS.SPEED_SP_FBEventArgs> SPEED_SP_FB_Fired;

    private event EventHandler<SE.Nereda.Symbols.Motor_VS.NEED_RESETEventArgs> NEED_RESET_Fired;

    private event EventHandler<SE.Nereda.Symbols.Motor_VS.FB_FAILEventArgs> FB_FAIL_Fired;

    private event EventHandler<SE.Nereda.Symbols.Motor_VS.FB_FWDEventArgs> FB_FWD_Fired;

    private event EventHandler<SE.Nereda.Symbols.Motor_VS.FB_CAPACITYEventArgs> FB_CAPACITY_Fired;

    protected override void OnEndInit()
    {
      if (LOAD_PERS_DATA_Fired != null)
        AttachEventInput(0);
      if (FB_STATE_Fired != null)
        AttachEventInput(1);
      if (SPEED_SP_FB_Fired != null)
        AttachEventInput(2);
      if (NEED_RESET_Fired != null)
        AttachEventInput(3);
      if (FB_FAIL_Fired != null)
        AttachEventInput(4);
      if (FB_FWD_Fired != null)
        AttachEventInput(5);
      if (FB_CAPACITY_Fired != null)
        AttachEventInput(6);

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
              LOAD_PERS_DATA_Fired(this, new SE.Nereda.Symbols.Motor_VS.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
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
              FB_STATE_Fired(this, new SE.Nereda.Symbols.Motor_VS.FB_STATEEventArgs(channelId, cookie, eventIndex));
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
          if (SPEED_SP_FB_Fired != null)
          {
            try
            {
              SPEED_SP_FB_Fired(this, new SE.Nereda.Symbols.Motor_VS.SPEED_SP_FBEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","SPEED_SP_FB_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 3:
          if (NEED_RESET_Fired != null)
          {
            try
            {
              NEED_RESET_Fired(this, new SE.Nereda.Symbols.Motor_VS.NEED_RESETEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","NEED_RESET_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 4:
          if (FB_FAIL_Fired != null)
          {
            try
            {
              FB_FAIL_Fired(this, new SE.Nereda.Symbols.Motor_VS.FB_FAILEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","FB_FAIL_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 5:
          if (FB_FWD_Fired != null)
          {
            try
            {
              FB_FWD_Fired(this, new SE.Nereda.Symbols.Motor_VS.FB_FWDEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","FB_FWD_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 6:
          if (FB_CAPACITY_Fired != null)
          {
            try
            {
              FB_CAPACITY_Fired(this, new SE.Nereda.Symbols.Motor_VS.FB_CAPACITYEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","FB_CAPACITY_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_CNF_ATV_EXIST(System.Boolean AtvExist)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {AtvExist});
    }
    public bool FireEvent_CNF_ATV_EXIST(SE.Nereda.Symbols.Motor_VS.CNF_ATV_EXISTEventArgs ea)
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
    public bool FireEvent_RESET(SE.Nereda.Symbols.Motor_VS.RESETEventArgs ea)
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
    public bool FireEvent_SPEED_SP_CONF(System.Single SpeedSpMin, System.Single SpeedSpMax)
    {
      return ((IHMIAccessorOutput)this).FireEvent(2, new object[] {SpeedSpMin, SpeedSpMax});
    }
    public bool FireEvent_SPEED_SP_CONF(SE.Nereda.Symbols.Motor_VS.SPEED_SP_CONFEventArgs ea)
    {
      object[] _values_ = new object[2];
      if (ea.SpeedSpMin.HasValue) _values_[0] = ea.SpeedSpMin.Value;
      if (ea.SpeedSpMax.HasValue) _values_[1] = ea.SpeedSpMax.Value;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_SPEED_SP_CONF(System.Single SpeedSpMin, bool ignore_SpeedSpMin, System.Single SpeedSpMax, bool ignore_SpeedSpMax)
    {
      object[] _values_ = new object[2];
      if (!ignore_SpeedSpMin) _values_[0] = SpeedSpMin;
      if (!ignore_SpeedSpMax) _values_[1] = SpeedSpMax;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }

  }
}

namespace SE.Nereda.Symbols.Motor_VS
{
  partial class sBlower
  {

    private event EventHandler<SE.Nereda.Symbols.Motor_VS.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    private event EventHandler<SE.Nereda.Symbols.Motor_VS.FB_STATEEventArgs> FB_STATE_Fired;

    private event EventHandler<SE.Nereda.Symbols.Motor_VS.SPEED_SP_FBEventArgs> SPEED_SP_FB_Fired;

    private event EventHandler<SE.Nereda.Symbols.Motor_VS.NEED_RESETEventArgs> NEED_RESET_Fired;

    private event EventHandler<SE.Nereda.Symbols.Motor_VS.FB_FAILEventArgs> FB_FAIL_Fired;

    private event EventHandler<SE.Nereda.Symbols.Motor_VS.FB_FWDEventArgs> FB_FWD_Fired;

    private event EventHandler<SE.Nereda.Symbols.Motor_VS.FB_CAPACITYEventArgs> FB_CAPACITY_Fired;

    protected override void OnEndInit()
    {
      if (LOAD_PERS_DATA_Fired != null)
        AttachEventInput(0);
      if (FB_STATE_Fired != null)
        AttachEventInput(1);
      if (SPEED_SP_FB_Fired != null)
        AttachEventInput(2);
      if (NEED_RESET_Fired != null)
        AttachEventInput(3);
      if (FB_FAIL_Fired != null)
        AttachEventInput(4);
      if (FB_FWD_Fired != null)
        AttachEventInput(5);
      if (FB_CAPACITY_Fired != null)
        AttachEventInput(6);

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
              LOAD_PERS_DATA_Fired(this, new SE.Nereda.Symbols.Motor_VS.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
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
              FB_STATE_Fired(this, new SE.Nereda.Symbols.Motor_VS.FB_STATEEventArgs(channelId, cookie, eventIndex));
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
          if (SPEED_SP_FB_Fired != null)
          {
            try
            {
              SPEED_SP_FB_Fired(this, new SE.Nereda.Symbols.Motor_VS.SPEED_SP_FBEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","SPEED_SP_FB_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 3:
          if (NEED_RESET_Fired != null)
          {
            try
            {
              NEED_RESET_Fired(this, new SE.Nereda.Symbols.Motor_VS.NEED_RESETEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","NEED_RESET_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 4:
          if (FB_FAIL_Fired != null)
          {
            try
            {
              FB_FAIL_Fired(this, new SE.Nereda.Symbols.Motor_VS.FB_FAILEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","FB_FAIL_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 5:
          if (FB_FWD_Fired != null)
          {
            try
            {
              FB_FWD_Fired(this, new SE.Nereda.Symbols.Motor_VS.FB_FWDEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","FB_FWD_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 6:
          if (FB_CAPACITY_Fired != null)
          {
            try
            {
              FB_CAPACITY_Fired(this, new SE.Nereda.Symbols.Motor_VS.FB_CAPACITYEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","FB_CAPACITY_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_CNF_ATV_EXIST(System.Boolean AtvExist)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {AtvExist});
    }
    public bool FireEvent_CNF_ATV_EXIST(SE.Nereda.Symbols.Motor_VS.CNF_ATV_EXISTEventArgs ea)
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
    public bool FireEvent_RESET(SE.Nereda.Symbols.Motor_VS.RESETEventArgs ea)
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
    public bool FireEvent_SPEED_SP_CONF(System.Single SpeedSpMin, System.Single SpeedSpMax)
    {
      return ((IHMIAccessorOutput)this).FireEvent(2, new object[] {SpeedSpMin, SpeedSpMax});
    }
    public bool FireEvent_SPEED_SP_CONF(SE.Nereda.Symbols.Motor_VS.SPEED_SP_CONFEventArgs ea)
    {
      object[] _values_ = new object[2];
      if (ea.SpeedSpMin.HasValue) _values_[0] = ea.SpeedSpMin.Value;
      if (ea.SpeedSpMax.HasValue) _values_[1] = ea.SpeedSpMax.Value;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_SPEED_SP_CONF(System.Single SpeedSpMin, bool ignore_SpeedSpMin, System.Single SpeedSpMax, bool ignore_SpeedSpMax)
    {
      object[] _values_ = new object[2];
      if (!ignore_SpeedSpMin) _values_[0] = SpeedSpMin;
      if (!ignore_SpeedSpMax) _values_[1] = SpeedSpMax;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }

  }
}

namespace SE.Nereda.Faceplates.Motor_VS
{
  partial class fpLocalPanel
  {

    private event EventHandler<SE.Nereda.Symbols.Motor_VS.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    private event EventHandler<SE.Nereda.Symbols.Motor_VS.FB_STATEEventArgs> FB_STATE_Fired;

    private event EventHandler<SE.Nereda.Symbols.Motor_VS.SPEED_SP_FBEventArgs> SPEED_SP_FB_Fired;

    private event EventHandler<SE.Nereda.Symbols.Motor_VS.NEED_RESETEventArgs> NEED_RESET_Fired;

    private event EventHandler<SE.Nereda.Symbols.Motor_VS.FB_FAILEventArgs> FB_FAIL_Fired;

    private event EventHandler<SE.Nereda.Symbols.Motor_VS.FB_FWDEventArgs> FB_FWD_Fired;

    private event EventHandler<SE.Nereda.Symbols.Motor_VS.FB_CAPACITYEventArgs> FB_CAPACITY_Fired;

    protected override void OnEndInit()
    {
      if (LOAD_PERS_DATA_Fired != null)
        AttachEventInput(0);
      if (FB_STATE_Fired != null)
        AttachEventInput(1);
      if (SPEED_SP_FB_Fired != null)
        AttachEventInput(2);
      if (NEED_RESET_Fired != null)
        AttachEventInput(3);
      if (FB_FAIL_Fired != null)
        AttachEventInput(4);
      if (FB_FWD_Fired != null)
        AttachEventInput(5);
      if (FB_CAPACITY_Fired != null)
        AttachEventInput(6);

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
              LOAD_PERS_DATA_Fired(this, new SE.Nereda.Symbols.Motor_VS.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
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
              FB_STATE_Fired(this, new SE.Nereda.Symbols.Motor_VS.FB_STATEEventArgs(channelId, cookie, eventIndex));
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
          if (SPEED_SP_FB_Fired != null)
          {
            try
            {
              SPEED_SP_FB_Fired(this, new SE.Nereda.Symbols.Motor_VS.SPEED_SP_FBEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","SPEED_SP_FB_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 3:
          if (NEED_RESET_Fired != null)
          {
            try
            {
              NEED_RESET_Fired(this, new SE.Nereda.Symbols.Motor_VS.NEED_RESETEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","NEED_RESET_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 4:
          if (FB_FAIL_Fired != null)
          {
            try
            {
              FB_FAIL_Fired(this, new SE.Nereda.Symbols.Motor_VS.FB_FAILEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","FB_FAIL_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 5:
          if (FB_FWD_Fired != null)
          {
            try
            {
              FB_FWD_Fired(this, new SE.Nereda.Symbols.Motor_VS.FB_FWDEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","FB_FWD_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 6:
          if (FB_CAPACITY_Fired != null)
          {
            try
            {
              FB_CAPACITY_Fired(this, new SE.Nereda.Symbols.Motor_VS.FB_CAPACITYEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","FB_CAPACITY_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_CNF_ATV_EXIST(System.Boolean AtvExist)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {AtvExist});
    }
    public bool FireEvent_CNF_ATV_EXIST(SE.Nereda.Symbols.Motor_VS.CNF_ATV_EXISTEventArgs ea)
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
    public bool FireEvent_RESET(SE.Nereda.Symbols.Motor_VS.RESETEventArgs ea)
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
    public bool FireEvent_SPEED_SP_CONF(System.Single SpeedSpMin, System.Single SpeedSpMax)
    {
      return ((IHMIAccessorOutput)this).FireEvent(2, new object[] {SpeedSpMin, SpeedSpMax});
    }
    public bool FireEvent_SPEED_SP_CONF(SE.Nereda.Symbols.Motor_VS.SPEED_SP_CONFEventArgs ea)
    {
      object[] _values_ = new object[2];
      if (ea.SpeedSpMin.HasValue) _values_[0] = ea.SpeedSpMin.Value;
      if (ea.SpeedSpMax.HasValue) _values_[1] = ea.SpeedSpMax.Value;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_SPEED_SP_CONF(System.Single SpeedSpMin, bool ignore_SpeedSpMin, System.Single SpeedSpMax, bool ignore_SpeedSpMax)
    {
      object[] _values_ = new object[2];
      if (!ignore_SpeedSpMin) _values_[0] = SpeedSpMin;
      if (!ignore_SpeedSpMax) _values_[1] = SpeedSpMax;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }

  }
}

namespace SE.Nereda.Symbols.Motor_VS
{
  partial class sMotorVs
  {

    private event EventHandler<SE.Nereda.Symbols.Motor_VS.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    private event EventHandler<SE.Nereda.Symbols.Motor_VS.FB_STATEEventArgs> FB_STATE_Fired;

    private event EventHandler<SE.Nereda.Symbols.Motor_VS.SPEED_SP_FBEventArgs> SPEED_SP_FB_Fired;

    private event EventHandler<SE.Nereda.Symbols.Motor_VS.NEED_RESETEventArgs> NEED_RESET_Fired;

    private event EventHandler<SE.Nereda.Symbols.Motor_VS.FB_FAILEventArgs> FB_FAIL_Fired;

    private event EventHandler<SE.Nereda.Symbols.Motor_VS.FB_FWDEventArgs> FB_FWD_Fired;

    private event EventHandler<SE.Nereda.Symbols.Motor_VS.FB_CAPACITYEventArgs> FB_CAPACITY_Fired;

    protected override void OnEndInit()
    {
      if (LOAD_PERS_DATA_Fired != null)
        AttachEventInput(0);
      if (FB_STATE_Fired != null)
        AttachEventInput(1);
      if (SPEED_SP_FB_Fired != null)
        AttachEventInput(2);
      if (NEED_RESET_Fired != null)
        AttachEventInput(3);
      if (FB_FAIL_Fired != null)
        AttachEventInput(4);
      if (FB_FWD_Fired != null)
        AttachEventInput(5);
      if (FB_CAPACITY_Fired != null)
        AttachEventInput(6);

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
              LOAD_PERS_DATA_Fired(this, new SE.Nereda.Symbols.Motor_VS.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
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
              FB_STATE_Fired(this, new SE.Nereda.Symbols.Motor_VS.FB_STATEEventArgs(channelId, cookie, eventIndex));
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
          if (SPEED_SP_FB_Fired != null)
          {
            try
            {
              SPEED_SP_FB_Fired(this, new SE.Nereda.Symbols.Motor_VS.SPEED_SP_FBEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","SPEED_SP_FB_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 3:
          if (NEED_RESET_Fired != null)
          {
            try
            {
              NEED_RESET_Fired(this, new SE.Nereda.Symbols.Motor_VS.NEED_RESETEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","NEED_RESET_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 4:
          if (FB_FAIL_Fired != null)
          {
            try
            {
              FB_FAIL_Fired(this, new SE.Nereda.Symbols.Motor_VS.FB_FAILEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","FB_FAIL_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 5:
          if (FB_FWD_Fired != null)
          {
            try
            {
              FB_FWD_Fired(this, new SE.Nereda.Symbols.Motor_VS.FB_FWDEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","FB_FWD_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 6:
          if (FB_CAPACITY_Fired != null)
          {
            try
            {
              FB_CAPACITY_Fired(this, new SE.Nereda.Symbols.Motor_VS.FB_CAPACITYEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","FB_CAPACITY_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_CNF_ATV_EXIST(System.Boolean AtvExist)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {AtvExist});
    }
    public bool FireEvent_CNF_ATV_EXIST(SE.Nereda.Symbols.Motor_VS.CNF_ATV_EXISTEventArgs ea)
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
    public bool FireEvent_RESET(SE.Nereda.Symbols.Motor_VS.RESETEventArgs ea)
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
    public bool FireEvent_SPEED_SP_CONF(System.Single SpeedSpMin, System.Single SpeedSpMax)
    {
      return ((IHMIAccessorOutput)this).FireEvent(2, new object[] {SpeedSpMin, SpeedSpMax});
    }
    public bool FireEvent_SPEED_SP_CONF(SE.Nereda.Symbols.Motor_VS.SPEED_SP_CONFEventArgs ea)
    {
      object[] _values_ = new object[2];
      if (ea.SpeedSpMin.HasValue) _values_[0] = ea.SpeedSpMin.Value;
      if (ea.SpeedSpMax.HasValue) _values_[1] = ea.SpeedSpMax.Value;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_SPEED_SP_CONF(System.Single SpeedSpMin, bool ignore_SpeedSpMin, System.Single SpeedSpMax, bool ignore_SpeedSpMax)
    {
      object[] _values_ = new object[2];
      if (!ignore_SpeedSpMin) _values_[0] = SpeedSpMin;
      if (!ignore_SpeedSpMax) _values_[1] = SpeedSpMax;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }

  }
}

namespace SE.Nereda.Symbols.Motor_VS
{
  partial class sStatus
  {

    private event EventHandler<SE.Nereda.Symbols.Motor_VS.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    private event EventHandler<SE.Nereda.Symbols.Motor_VS.FB_STATEEventArgs> FB_STATE_Fired;

    private event EventHandler<SE.Nereda.Symbols.Motor_VS.SPEED_SP_FBEventArgs> SPEED_SP_FB_Fired;

    private event EventHandler<SE.Nereda.Symbols.Motor_VS.NEED_RESETEventArgs> NEED_RESET_Fired;

    private event EventHandler<SE.Nereda.Symbols.Motor_VS.FB_FAILEventArgs> FB_FAIL_Fired;

    private event EventHandler<SE.Nereda.Symbols.Motor_VS.FB_FWDEventArgs> FB_FWD_Fired;

    private event EventHandler<SE.Nereda.Symbols.Motor_VS.FB_CAPACITYEventArgs> FB_CAPACITY_Fired;

    protected override void OnEndInit()
    {
      if (LOAD_PERS_DATA_Fired != null)
        AttachEventInput(0);
      if (FB_STATE_Fired != null)
        AttachEventInput(1);
      if (SPEED_SP_FB_Fired != null)
        AttachEventInput(2);
      if (NEED_RESET_Fired != null)
        AttachEventInput(3);
      if (FB_FAIL_Fired != null)
        AttachEventInput(4);
      if (FB_FWD_Fired != null)
        AttachEventInput(5);
      if (FB_CAPACITY_Fired != null)
        AttachEventInput(6);

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
              LOAD_PERS_DATA_Fired(this, new SE.Nereda.Symbols.Motor_VS.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
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
              FB_STATE_Fired(this, new SE.Nereda.Symbols.Motor_VS.FB_STATEEventArgs(channelId, cookie, eventIndex));
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
          if (SPEED_SP_FB_Fired != null)
          {
            try
            {
              SPEED_SP_FB_Fired(this, new SE.Nereda.Symbols.Motor_VS.SPEED_SP_FBEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","SPEED_SP_FB_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 3:
          if (NEED_RESET_Fired != null)
          {
            try
            {
              NEED_RESET_Fired(this, new SE.Nereda.Symbols.Motor_VS.NEED_RESETEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","NEED_RESET_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 4:
          if (FB_FAIL_Fired != null)
          {
            try
            {
              FB_FAIL_Fired(this, new SE.Nereda.Symbols.Motor_VS.FB_FAILEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","FB_FAIL_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 5:
          if (FB_FWD_Fired != null)
          {
            try
            {
              FB_FWD_Fired(this, new SE.Nereda.Symbols.Motor_VS.FB_FWDEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","FB_FWD_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 6:
          if (FB_CAPACITY_Fired != null)
          {
            try
            {
              FB_CAPACITY_Fired(this, new SE.Nereda.Symbols.Motor_VS.FB_CAPACITYEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","FB_CAPACITY_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_CNF_ATV_EXIST(System.Boolean AtvExist)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {AtvExist});
    }
    public bool FireEvent_CNF_ATV_EXIST(SE.Nereda.Symbols.Motor_VS.CNF_ATV_EXISTEventArgs ea)
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
    public bool FireEvent_RESET(SE.Nereda.Symbols.Motor_VS.RESETEventArgs ea)
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
    public bool FireEvent_SPEED_SP_CONF(System.Single SpeedSpMin, System.Single SpeedSpMax)
    {
      return ((IHMIAccessorOutput)this).FireEvent(2, new object[] {SpeedSpMin, SpeedSpMax});
    }
    public bool FireEvent_SPEED_SP_CONF(SE.Nereda.Symbols.Motor_VS.SPEED_SP_CONFEventArgs ea)
    {
      object[] _values_ = new object[2];
      if (ea.SpeedSpMin.HasValue) _values_[0] = ea.SpeedSpMin.Value;
      if (ea.SpeedSpMax.HasValue) _values_[1] = ea.SpeedSpMax.Value;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_SPEED_SP_CONF(System.Single SpeedSpMin, bool ignore_SpeedSpMin, System.Single SpeedSpMax, bool ignore_SpeedSpMax)
    {
      object[] _values_ = new object[2];
      if (!ignore_SpeedSpMin) _values_[0] = SpeedSpMin;
      if (!ignore_SpeedSpMax) _values_[1] = SpeedSpMax;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }

  }
}
#endregion #Motor_VS_HMI;

#endregion Definitions;
