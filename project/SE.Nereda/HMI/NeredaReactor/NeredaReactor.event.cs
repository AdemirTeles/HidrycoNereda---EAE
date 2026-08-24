/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 6/7/2026
 * Time: 3:01 PM
 * 
 */
using System;
using NxtControl.GuiFramework;
using NxtControl.Services;

#region Definitions;
#region #NeredaReactor_HMI;

namespace SE.Nereda.Symbols.NeredaReactor
{

  public class PHASEEventArgs : System.EventArgs
  {
    IHMIAccessorService accessorService;
    int channelId;
    int cookie; 
    int eventIndex;

    public PHASEEventArgs(int channelId, int cookie, int eventIndex)
    {
      this.accessorService = (IHMIAccessorService)ServiceProvider.GetService(typeof(IHMIAccessorService));
      this.channelId = channelId;
      this.cookie = cookie;
      this.eventIndex = eventIndex;
    }
    public bool Get_FeedRun(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,0, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? FeedRun
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,0, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_AerateRun(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,1, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? AerateRun
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,1, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_SludgeDischargeRun(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,2, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? SludgeDischargeRun
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,2, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_VentRun(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,3, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? VentRun
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,3, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_WaitRun(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,4, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? WaitRun
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,4, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_ReactorStatus(ref System.String value)
    {
      if (accessorService == null)
        return false;
      string var = null;
      bool ret = accessorService.GetStringValue(channelId, cookie, eventIndex, true,5, ref var);
      if (ret) value = (System.String) var;
      return ret;
    }

    public System.String ReactorStatus
    { get {
      if (accessorService == null)
        return null;
      string var = null;
      bool ret = accessorService.GetStringValue(channelId, cookie, eventIndex, true,5, ref var);
      if (!ret) return null;
      return (System.String) var;
    }  }


  }

  public class LEVELEventArgs : System.EventArgs
  {
    IHMIAccessorService accessorService;
    int channelId;
    int cookie; 
    int eventIndex;

    public LEVELEventArgs(int channelId, int cookie, int eventIndex)
    {
      this.accessorService = (IHMIAccessorService)ServiceProvider.GetService(typeof(IHMIAccessorService));
      this.channelId = channelId;
      this.cookie = cookie;
      this.eventIndex = eventIndex;
    }
    public bool Get_LevelPv(ref System.Single value)
    {
      if (accessorService == null)
        return false;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,0, ref var);
      if (ret) value = (System.Single) var;
      return ret;
    }

    public System.Single? LevelPv
    { get {
      if (accessorService == null)
        return null;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,0, ref var);
      if (!ret) return null;
      return (System.Single) var;
    }  }

    public bool Get_LevelPvMax(ref System.Single value)
    {
      if (accessorService == null)
        return false;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,1, ref var);
      if (ret) value = (System.Single) var;
      return ret;
    }

    public System.Single? LevelPvMax
    { get {
      if (accessorService == null)
        return null;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,1, ref var);
      if (!ret) return null;
      return (System.Single) var;
    }  }


  }

  public class COLOREventArgs : System.EventArgs
  {
    IHMIAccessorService accessorService;
    int channelId;
    int cookie; 
    int eventIndex;

    public COLOREventArgs(int channelId, int cookie, int eventIndex)
    {
      this.accessorService = (IHMIAccessorService)ServiceProvider.GetService(typeof(IHMIAccessorService));
      this.channelId = channelId;
      this.cookie = cookie;
      this.eventIndex = eventIndex;
    }
    public bool Get_ColorIn(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,0, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? ColorIn
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,0, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }


  }

  public class REA_STATUSEventArgs : System.EventArgs
  {
    IHMIAccessorService accessorService;
    int channelId;
    int cookie; 
    int eventIndex;

    public REA_STATUSEventArgs(int channelId, int cookie, int eventIndex)
    {
      this.accessorService = (IHMIAccessorService)ServiceProvider.GetService(typeof(IHMIAccessorService));
      this.channelId = channelId;
      this.cookie = cookie;
      this.eventIndex = eventIndex;
    }
    public bool Get_InStatus(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,0, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? InStatus
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,0, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }


  }

}

namespace SE.Nereda.Symbols.NeredaReactor
{

  public class CNF_STATUSEventArgs : System.EventArgs
  {
    public CNF_STATUSEventArgs()
    {
    }
    private System.Int16? Status_field = null;
    public System.Int16? Status
    {
       get { return Status_field; }
       set { Status_field = value; }
    }

  }

}

namespace SE.Nereda.Symbols.NeredaReactor
{
  partial class sStatus
  {

    private event EventHandler<SE.Nereda.Symbols.NeredaReactor.PHASEEventArgs> PHASE_Fired;

    private event EventHandler<SE.Nereda.Symbols.NeredaReactor.LEVELEventArgs> LEVEL_Fired;

    private event EventHandler<SE.Nereda.Symbols.NeredaReactor.COLOREventArgs> COLOR_Fired;

    private event EventHandler<SE.Nereda.Symbols.NeredaReactor.REA_STATUSEventArgs> REA_STATUS_Fired;

    protected override void OnEndInit()
    {
      if (PHASE_Fired != null)
        AttachEventInput(0);
      if (LEVEL_Fired != null)
        AttachEventInput(1);
      if (COLOR_Fired != null)
        AttachEventInput(2);
      if (REA_STATUS_Fired != null)
        AttachEventInput(3);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (PHASE_Fired != null)
          {
            try
            {
              PHASE_Fired(this, new SE.Nereda.Symbols.NeredaReactor.PHASEEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","PHASE_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 1:
          if (LEVEL_Fired != null)
          {
            try
            {
              LEVEL_Fired(this, new SE.Nereda.Symbols.NeredaReactor.LEVELEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","LEVEL_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 2:
          if (COLOR_Fired != null)
          {
            try
            {
              COLOR_Fired(this, new SE.Nereda.Symbols.NeredaReactor.COLOREventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","COLOR_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 3:
          if (REA_STATUS_Fired != null)
          {
            try
            {
              REA_STATUS_Fired(this, new SE.Nereda.Symbols.NeredaReactor.REA_STATUSEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REA_STATUS_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_CNF_STATUS(System.Int16 Status)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {Status});
    }
    public bool FireEvent_CNF_STATUS(SE.Nereda.Symbols.NeredaReactor.CNF_STATUSEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.Status.HasValue) _values_[0] = ea.Status.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_CNF_STATUS(System.Int16 Status, bool ignore_Status)
    {
      object[] _values_ = new object[1];
      if (!ignore_Status) _values_[0] = Status;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }

  }
}

namespace SE.Nereda.Symbols.NeredaReactor
{
  partial class sReactor1
  {

    private event EventHandler<SE.Nereda.Symbols.NeredaReactor.PHASEEventArgs> PHASE_Fired;

    private event EventHandler<SE.Nereda.Symbols.NeredaReactor.LEVELEventArgs> LEVEL_Fired;

    private event EventHandler<SE.Nereda.Symbols.NeredaReactor.COLOREventArgs> COLOR_Fired;

    private event EventHandler<SE.Nereda.Symbols.NeredaReactor.REA_STATUSEventArgs> REA_STATUS_Fired;

    protected override void OnEndInit()
    {
      if (PHASE_Fired != null)
        AttachEventInput(0);
      if (LEVEL_Fired != null)
        AttachEventInput(1);
      if (COLOR_Fired != null)
        AttachEventInput(2);
      if (REA_STATUS_Fired != null)
        AttachEventInput(3);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (PHASE_Fired != null)
          {
            try
            {
              PHASE_Fired(this, new SE.Nereda.Symbols.NeredaReactor.PHASEEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","PHASE_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 1:
          if (LEVEL_Fired != null)
          {
            try
            {
              LEVEL_Fired(this, new SE.Nereda.Symbols.NeredaReactor.LEVELEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","LEVEL_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 2:
          if (COLOR_Fired != null)
          {
            try
            {
              COLOR_Fired(this, new SE.Nereda.Symbols.NeredaReactor.COLOREventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","COLOR_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 3:
          if (REA_STATUS_Fired != null)
          {
            try
            {
              REA_STATUS_Fired(this, new SE.Nereda.Symbols.NeredaReactor.REA_STATUSEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REA_STATUS_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_CNF_STATUS(System.Int16 Status)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {Status});
    }
    public bool FireEvent_CNF_STATUS(SE.Nereda.Symbols.NeredaReactor.CNF_STATUSEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.Status.HasValue) _values_[0] = ea.Status.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_CNF_STATUS(System.Int16 Status, bool ignore_Status)
    {
      object[] _values_ = new object[1];
      if (!ignore_Status) _values_[0] = Status;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }

  }
}

namespace SE.Nereda.Symbols.NeredaReactor
{
  partial class sPhases
  {

    private event EventHandler<SE.Nereda.Symbols.NeredaReactor.PHASEEventArgs> PHASE_Fired;

    private event EventHandler<SE.Nereda.Symbols.NeredaReactor.LEVELEventArgs> LEVEL_Fired;

    private event EventHandler<SE.Nereda.Symbols.NeredaReactor.COLOREventArgs> COLOR_Fired;

    private event EventHandler<SE.Nereda.Symbols.NeredaReactor.REA_STATUSEventArgs> REA_STATUS_Fired;

    protected override void OnEndInit()
    {
      if (PHASE_Fired != null)
        AttachEventInput(0);
      if (LEVEL_Fired != null)
        AttachEventInput(1);
      if (COLOR_Fired != null)
        AttachEventInput(2);
      if (REA_STATUS_Fired != null)
        AttachEventInput(3);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (PHASE_Fired != null)
          {
            try
            {
              PHASE_Fired(this, new SE.Nereda.Symbols.NeredaReactor.PHASEEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","PHASE_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 1:
          if (LEVEL_Fired != null)
          {
            try
            {
              LEVEL_Fired(this, new SE.Nereda.Symbols.NeredaReactor.LEVELEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","LEVEL_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 2:
          if (COLOR_Fired != null)
          {
            try
            {
              COLOR_Fired(this, new SE.Nereda.Symbols.NeredaReactor.COLOREventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","COLOR_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 3:
          if (REA_STATUS_Fired != null)
          {
            try
            {
              REA_STATUS_Fired(this, new SE.Nereda.Symbols.NeredaReactor.REA_STATUSEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REA_STATUS_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_CNF_STATUS(System.Int16 Status)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {Status});
    }
    public bool FireEvent_CNF_STATUS(SE.Nereda.Symbols.NeredaReactor.CNF_STATUSEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.Status.HasValue) _values_[0] = ea.Status.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_CNF_STATUS(System.Int16 Status, bool ignore_Status)
    {
      object[] _values_ = new object[1];
      if (!ignore_Status) _values_[0] = Status;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }

  }
}

namespace SE.Nereda.Symbols.NeredaReactor
{
  partial class sReactor2
  {

    private event EventHandler<SE.Nereda.Symbols.NeredaReactor.PHASEEventArgs> PHASE_Fired;

    private event EventHandler<SE.Nereda.Symbols.NeredaReactor.LEVELEventArgs> LEVEL_Fired;

    private event EventHandler<SE.Nereda.Symbols.NeredaReactor.COLOREventArgs> COLOR_Fired;

    private event EventHandler<SE.Nereda.Symbols.NeredaReactor.REA_STATUSEventArgs> REA_STATUS_Fired;

    protected override void OnEndInit()
    {
      if (PHASE_Fired != null)
        AttachEventInput(0);
      if (LEVEL_Fired != null)
        AttachEventInput(1);
      if (COLOR_Fired != null)
        AttachEventInput(2);
      if (REA_STATUS_Fired != null)
        AttachEventInput(3);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (PHASE_Fired != null)
          {
            try
            {
              PHASE_Fired(this, new SE.Nereda.Symbols.NeredaReactor.PHASEEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","PHASE_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 1:
          if (LEVEL_Fired != null)
          {
            try
            {
              LEVEL_Fired(this, new SE.Nereda.Symbols.NeredaReactor.LEVELEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","LEVEL_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 2:
          if (COLOR_Fired != null)
          {
            try
            {
              COLOR_Fired(this, new SE.Nereda.Symbols.NeredaReactor.COLOREventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","COLOR_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 3:
          if (REA_STATUS_Fired != null)
          {
            try
            {
              REA_STATUS_Fired(this, new SE.Nereda.Symbols.NeredaReactor.REA_STATUSEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REA_STATUS_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_CNF_STATUS(System.Int16 Status)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {Status});
    }
    public bool FireEvent_CNF_STATUS(SE.Nereda.Symbols.NeredaReactor.CNF_STATUSEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.Status.HasValue) _values_[0] = ea.Status.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_CNF_STATUS(System.Int16 Status, bool ignore_Status)
    {
      object[] _values_ = new object[1];
      if (!ignore_Status) _values_[0] = Status;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }

  }
}

namespace SE.Nereda.Symbols.NeredaReactor
{
  partial class sSensors
  {

    private event EventHandler<SE.Nereda.Symbols.NeredaReactor.PHASEEventArgs> PHASE_Fired;

    private event EventHandler<SE.Nereda.Symbols.NeredaReactor.LEVELEventArgs> LEVEL_Fired;

    private event EventHandler<SE.Nereda.Symbols.NeredaReactor.COLOREventArgs> COLOR_Fired;

    private event EventHandler<SE.Nereda.Symbols.NeredaReactor.REA_STATUSEventArgs> REA_STATUS_Fired;

    protected override void OnEndInit()
    {
      if (PHASE_Fired != null)
        AttachEventInput(0);
      if (LEVEL_Fired != null)
        AttachEventInput(1);
      if (COLOR_Fired != null)
        AttachEventInput(2);
      if (REA_STATUS_Fired != null)
        AttachEventInput(3);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (PHASE_Fired != null)
          {
            try
            {
              PHASE_Fired(this, new SE.Nereda.Symbols.NeredaReactor.PHASEEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","PHASE_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 1:
          if (LEVEL_Fired != null)
          {
            try
            {
              LEVEL_Fired(this, new SE.Nereda.Symbols.NeredaReactor.LEVELEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","LEVEL_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 2:
          if (COLOR_Fired != null)
          {
            try
            {
              COLOR_Fired(this, new SE.Nereda.Symbols.NeredaReactor.COLOREventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","COLOR_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 3:
          if (REA_STATUS_Fired != null)
          {
            try
            {
              REA_STATUS_Fired(this, new SE.Nereda.Symbols.NeredaReactor.REA_STATUSEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REA_STATUS_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_CNF_STATUS(System.Int16 Status)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {Status});
    }
    public bool FireEvent_CNF_STATUS(SE.Nereda.Symbols.NeredaReactor.CNF_STATUSEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.Status.HasValue) _values_[0] = ea.Status.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_CNF_STATUS(System.Int16 Status, bool ignore_Status)
    {
      object[] _values_ = new object[1];
      if (!ignore_Status) _values_[0] = Status;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }

  }
}

namespace SE.Nereda.Faceplates.NeredaReactor
{
  partial class fpSettings
  {

    private event EventHandler<SE.Nereda.Symbols.NeredaReactor.PHASEEventArgs> PHASE_Fired;

    private event EventHandler<SE.Nereda.Symbols.NeredaReactor.LEVELEventArgs> LEVEL_Fired;

    private event EventHandler<SE.Nereda.Symbols.NeredaReactor.COLOREventArgs> COLOR_Fired;

    private event EventHandler<SE.Nereda.Symbols.NeredaReactor.REA_STATUSEventArgs> REA_STATUS_Fired;

    protected override void OnEndInit()
    {
      if (PHASE_Fired != null)
        AttachEventInput(0);
      if (LEVEL_Fired != null)
        AttachEventInput(1);
      if (COLOR_Fired != null)
        AttachEventInput(2);
      if (REA_STATUS_Fired != null)
        AttachEventInput(3);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (PHASE_Fired != null)
          {
            try
            {
              PHASE_Fired(this, new SE.Nereda.Symbols.NeredaReactor.PHASEEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","PHASE_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 1:
          if (LEVEL_Fired != null)
          {
            try
            {
              LEVEL_Fired(this, new SE.Nereda.Symbols.NeredaReactor.LEVELEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","LEVEL_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 2:
          if (COLOR_Fired != null)
          {
            try
            {
              COLOR_Fired(this, new SE.Nereda.Symbols.NeredaReactor.COLOREventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","COLOR_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 3:
          if (REA_STATUS_Fired != null)
          {
            try
            {
              REA_STATUS_Fired(this, new SE.Nereda.Symbols.NeredaReactor.REA_STATUSEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REA_STATUS_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_CNF_STATUS(System.Int16 Status)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {Status});
    }
    public bool FireEvent_CNF_STATUS(SE.Nereda.Symbols.NeredaReactor.CNF_STATUSEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.Status.HasValue) _values_[0] = ea.Status.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_CNF_STATUS(System.Int16 Status, bool ignore_Status)
    {
      object[] _values_ = new object[1];
      if (!ignore_Status) _values_[0] = Status;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }

  }
}

namespace SE.Nereda.Symbols.NeredaReactor
{
  partial class sSettingsBtn
  {

    private event EventHandler<SE.Nereda.Symbols.NeredaReactor.PHASEEventArgs> PHASE_Fired;

    private event EventHandler<SE.Nereda.Symbols.NeredaReactor.LEVELEventArgs> LEVEL_Fired;

    private event EventHandler<SE.Nereda.Symbols.NeredaReactor.COLOREventArgs> COLOR_Fired;

    private event EventHandler<SE.Nereda.Symbols.NeredaReactor.REA_STATUSEventArgs> REA_STATUS_Fired;

    protected override void OnEndInit()
    {
      if (PHASE_Fired != null)
        AttachEventInput(0);
      if (LEVEL_Fired != null)
        AttachEventInput(1);
      if (COLOR_Fired != null)
        AttachEventInput(2);
      if (REA_STATUS_Fired != null)
        AttachEventInput(3);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (PHASE_Fired != null)
          {
            try
            {
              PHASE_Fired(this, new SE.Nereda.Symbols.NeredaReactor.PHASEEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","PHASE_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 1:
          if (LEVEL_Fired != null)
          {
            try
            {
              LEVEL_Fired(this, new SE.Nereda.Symbols.NeredaReactor.LEVELEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","LEVEL_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 2:
          if (COLOR_Fired != null)
          {
            try
            {
              COLOR_Fired(this, new SE.Nereda.Symbols.NeredaReactor.COLOREventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","COLOR_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 3:
          if (REA_STATUS_Fired != null)
          {
            try
            {
              REA_STATUS_Fired(this, new SE.Nereda.Symbols.NeredaReactor.REA_STATUSEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REA_STATUS_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_CNF_STATUS(System.Int16 Status)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {Status});
    }
    public bool FireEvent_CNF_STATUS(SE.Nereda.Symbols.NeredaReactor.CNF_STATUSEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.Status.HasValue) _values_[0] = ea.Status.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_CNF_STATUS(System.Int16 Status, bool ignore_Status)
    {
      object[] _values_ = new object[1];
      if (!ignore_Status) _values_[0] = Status;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }

  }
}

namespace SE.Nereda.Symbols.NeredaReactor
{
  partial class sReactor3
  {

    private event EventHandler<SE.Nereda.Symbols.NeredaReactor.PHASEEventArgs> PHASE_Fired;

    private event EventHandler<SE.Nereda.Symbols.NeredaReactor.LEVELEventArgs> LEVEL_Fired;

    private event EventHandler<SE.Nereda.Symbols.NeredaReactor.COLOREventArgs> COLOR_Fired;

    private event EventHandler<SE.Nereda.Symbols.NeredaReactor.REA_STATUSEventArgs> REA_STATUS_Fired;

    protected override void OnEndInit()
    {
      if (PHASE_Fired != null)
        AttachEventInput(0);
      if (LEVEL_Fired != null)
        AttachEventInput(1);
      if (COLOR_Fired != null)
        AttachEventInput(2);
      if (REA_STATUS_Fired != null)
        AttachEventInput(3);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (PHASE_Fired != null)
          {
            try
            {
              PHASE_Fired(this, new SE.Nereda.Symbols.NeredaReactor.PHASEEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","PHASE_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 1:
          if (LEVEL_Fired != null)
          {
            try
            {
              LEVEL_Fired(this, new SE.Nereda.Symbols.NeredaReactor.LEVELEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","LEVEL_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 2:
          if (COLOR_Fired != null)
          {
            try
            {
              COLOR_Fired(this, new SE.Nereda.Symbols.NeredaReactor.COLOREventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","COLOR_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 3:
          if (REA_STATUS_Fired != null)
          {
            try
            {
              REA_STATUS_Fired(this, new SE.Nereda.Symbols.NeredaReactor.REA_STATUSEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REA_STATUS_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_CNF_STATUS(System.Int16 Status)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {Status});
    }
    public bool FireEvent_CNF_STATUS(SE.Nereda.Symbols.NeredaReactor.CNF_STATUSEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.Status.HasValue) _values_[0] = ea.Status.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_CNF_STATUS(System.Int16 Status, bool ignore_Status)
    {
      object[] _values_ = new object[1];
      if (!ignore_Status) _values_[0] = Status;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }

  }
}

namespace SE.Nereda.Faceplates.NeredaReactor
{
  partial class fpPhases
  {

    private event EventHandler<SE.Nereda.Symbols.NeredaReactor.PHASEEventArgs> PHASE_Fired;

    private event EventHandler<SE.Nereda.Symbols.NeredaReactor.LEVELEventArgs> LEVEL_Fired;

    private event EventHandler<SE.Nereda.Symbols.NeredaReactor.COLOREventArgs> COLOR_Fired;

    private event EventHandler<SE.Nereda.Symbols.NeredaReactor.REA_STATUSEventArgs> REA_STATUS_Fired;

    protected override void OnEndInit()
    {
      if (PHASE_Fired != null)
        AttachEventInput(0);
      if (LEVEL_Fired != null)
        AttachEventInput(1);
      if (COLOR_Fired != null)
        AttachEventInput(2);
      if (REA_STATUS_Fired != null)
        AttachEventInput(3);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (PHASE_Fired != null)
          {
            try
            {
              PHASE_Fired(this, new SE.Nereda.Symbols.NeredaReactor.PHASEEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","PHASE_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 1:
          if (LEVEL_Fired != null)
          {
            try
            {
              LEVEL_Fired(this, new SE.Nereda.Symbols.NeredaReactor.LEVELEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","LEVEL_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 2:
          if (COLOR_Fired != null)
          {
            try
            {
              COLOR_Fired(this, new SE.Nereda.Symbols.NeredaReactor.COLOREventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","COLOR_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 3:
          if (REA_STATUS_Fired != null)
          {
            try
            {
              REA_STATUS_Fired(this, new SE.Nereda.Symbols.NeredaReactor.REA_STATUSEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REA_STATUS_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_CNF_STATUS(System.Int16 Status)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {Status});
    }
    public bool FireEvent_CNF_STATUS(SE.Nereda.Symbols.NeredaReactor.CNF_STATUSEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.Status.HasValue) _values_[0] = ea.Status.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_CNF_STATUS(System.Int16 Status, bool ignore_Status)
    {
      object[] _values_ = new object[1];
      if (!ignore_Status) _values_[0] = Status;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }

  }
}

namespace SE.Nereda.Symbols.NeredaReactor
{
  partial class sReactor4
  {

    private event EventHandler<SE.Nereda.Symbols.NeredaReactor.PHASEEventArgs> PHASE_Fired;

    private event EventHandler<SE.Nereda.Symbols.NeredaReactor.LEVELEventArgs> LEVEL_Fired;

    private event EventHandler<SE.Nereda.Symbols.NeredaReactor.COLOREventArgs> COLOR_Fired;

    private event EventHandler<SE.Nereda.Symbols.NeredaReactor.REA_STATUSEventArgs> REA_STATUS_Fired;

    protected override void OnEndInit()
    {
      if (PHASE_Fired != null)
        AttachEventInput(0);
      if (LEVEL_Fired != null)
        AttachEventInput(1);
      if (COLOR_Fired != null)
        AttachEventInput(2);
      if (REA_STATUS_Fired != null)
        AttachEventInput(3);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (PHASE_Fired != null)
          {
            try
            {
              PHASE_Fired(this, new SE.Nereda.Symbols.NeredaReactor.PHASEEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","PHASE_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 1:
          if (LEVEL_Fired != null)
          {
            try
            {
              LEVEL_Fired(this, new SE.Nereda.Symbols.NeredaReactor.LEVELEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","LEVEL_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 2:
          if (COLOR_Fired != null)
          {
            try
            {
              COLOR_Fired(this, new SE.Nereda.Symbols.NeredaReactor.COLOREventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","COLOR_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 3:
          if (REA_STATUS_Fired != null)
          {
            try
            {
              REA_STATUS_Fired(this, new SE.Nereda.Symbols.NeredaReactor.REA_STATUSEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REA_STATUS_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_CNF_STATUS(System.Int16 Status)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {Status});
    }
    public bool FireEvent_CNF_STATUS(SE.Nereda.Symbols.NeredaReactor.CNF_STATUSEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.Status.HasValue) _values_[0] = ea.Status.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_CNF_STATUS(System.Int16 Status, bool ignore_Status)
    {
      object[] _values_ = new object[1];
      if (!ignore_Status) _values_[0] = Status;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }

  }
}
#endregion #NeredaReactor_HMI;

#endregion Definitions;
