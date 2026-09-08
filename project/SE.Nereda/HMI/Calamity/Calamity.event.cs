/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 6/21/2026
 * Time: 11:02 AM
 * 
 */
using System;
using NxtControl.GuiFramework;
using NxtControl.Services;

#region Definitions;
#region #Calamity_HMI;

namespace SE.Nereda.Symbols.Calamity
{

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

  public class LEVEL_TOO_HEventArgs : System.EventArgs
  {
    IHMIAccessorService accessorService;
    int channelId;
    int cookie; 
    int eventIndex;

    public LEVEL_TOO_HEventArgs(int channelId, int cookie, int eventIndex)
    {
      this.accessorService = (IHMIAccessorService)ServiceProvider.GetService(typeof(IHMIAccessorService));
      this.channelId = channelId;
      this.cookie = cookie;
      this.eventIndex = eventIndex;
    }
    public bool Get_LevelTooHigh(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,0, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? LevelTooHigh
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,0, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }


  }

  public class LEVEL_PVEventArgs : System.EventArgs
  {
    IHMIAccessorService accessorService;
    int channelId;
    int cookie; 
    int eventIndex;

    public LEVEL_PVEventArgs(int channelId, int cookie, int eventIndex)
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

    public bool Get_LevelPvMin(ref System.Single value)
    {
      if (accessorService == null)
        return false;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,1, ref var);
      if (ret) value = (System.Single) var;
      return ret;
    }

    public System.Single? LevelPvMin
    { get {
      if (accessorService == null)
        return null;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,1, ref var);
      if (!ret) return null;
      return (System.Single) var;
    }  }

    public bool Get_LevelPvMax(ref System.Single value)
    {
      if (accessorService == null)
        return false;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,2, ref var);
      if (ret) value = (System.Single) var;
      return ret;
    }

    public System.Single? LevelPvMax
    { get {
      if (accessorService == null)
        return null;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,2, ref var);
      if (!ret) return null;
      return (System.Single) var;
    }  }


  }

  public class LEVEL_STATUSEventArgs : System.EventArgs
  {
    IHMIAccessorService accessorService;
    int channelId;
    int cookie; 
    int eventIndex;

    public LEVEL_STATUSEventArgs(int channelId, int cookie, int eventIndex)
    {
      this.accessorService = (IHMIAccessorService)ServiceProvider.GetService(typeof(IHMIAccessorService));
      this.channelId = channelId;
      this.cookie = cookie;
      this.eventIndex = eventIndex;
    }
    public bool Get_HiHiLevel(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,0, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? HiHiLevel
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,0, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_LevelSwitch(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,1, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? LevelSwitch
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,1, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }


  }

}

namespace SE.Nereda.Symbols.Calamity
{

  public class SPEED_SPEventArgs : System.EventArgs
  {
    public SPEED_SPEventArgs()
    {
    }
    private System.Single? SpeedSp_field = null;
    public System.Single? SpeedSp
    {
       get { return SpeedSp_field; }
       set { SpeedSp_field = value; }
    }

  }

  public class H1_L_SPEventArgs : System.EventArgs
  {
    public H1_L_SPEventArgs()
    {
    }
    private System.Single? H1LevelSp_field = null;
    public System.Single? H1LevelSp
    {
       get { return H1LevelSp_field; }
       set { H1LevelSp_field = value; }
    }

  }

}

namespace SE.Nereda.Symbols.Calamity
{
  partial class sDefault
  {

    private event EventHandler<SE.Nereda.Symbols.Calamity.GRAPHEventArgs> GRAPH_Fired;

    private event EventHandler<SE.Nereda.Symbols.Calamity.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    private event EventHandler<SE.Nereda.Symbols.Calamity.LEVEL_TOO_HEventArgs> LEVEL_TOO_H_Fired;

    private event EventHandler<SE.Nereda.Symbols.Calamity.LEVEL_PVEventArgs> LEVEL_PV_Fired;

    private event EventHandler<SE.Nereda.Symbols.Calamity.LEVEL_STATUSEventArgs> LEVEL_STATUS_Fired;

    protected override void OnEndInit()
    {
      if (GRAPH_Fired != null)
        AttachEventInput(0);
      if (LOAD_PERS_DATA_Fired != null)
        AttachEventInput(1);
      if (LEVEL_TOO_H_Fired != null)
        AttachEventInput(2);
      if (LEVEL_PV_Fired != null)
        AttachEventInput(3);
      if (LEVEL_STATUS_Fired != null)
        AttachEventInput(4);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (GRAPH_Fired != null)
          {
            try
            {
              GRAPH_Fired(this, new SE.Nereda.Symbols.Calamity.GRAPHEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","GRAPH_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 1:
          if (LOAD_PERS_DATA_Fired != null)
          {
            try
            {
              LOAD_PERS_DATA_Fired(this, new SE.Nereda.Symbols.Calamity.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","LOAD_PERS_DATA_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 2:
          if (LEVEL_TOO_H_Fired != null)
          {
            try
            {
              LEVEL_TOO_H_Fired(this, new SE.Nereda.Symbols.Calamity.LEVEL_TOO_HEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","LEVEL_TOO_H_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 3:
          if (LEVEL_PV_Fired != null)
          {
            try
            {
              LEVEL_PV_Fired(this, new SE.Nereda.Symbols.Calamity.LEVEL_PVEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","LEVEL_PV_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 4:
          if (LEVEL_STATUS_Fired != null)
          {
            try
            {
              LEVEL_STATUS_Fired(this, new SE.Nereda.Symbols.Calamity.LEVEL_STATUSEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","LEVEL_STATUS_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_SPEED_SP(System.Single SpeedSp)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {SpeedSp});
    }
    public bool FireEvent_SPEED_SP(SE.Nereda.Symbols.Calamity.SPEED_SPEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.SpeedSp.HasValue) _values_[0] = ea.SpeedSp.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_SPEED_SP(System.Single SpeedSp, bool ignore_SpeedSp)
    {
      object[] _values_ = new object[1];
      if (!ignore_SpeedSp) _values_[0] = SpeedSp;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_H1_L_SP(System.Single H1LevelSp)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {H1LevelSp});
    }
    public bool FireEvent_H1_L_SP(SE.Nereda.Symbols.Calamity.H1_L_SPEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.H1LevelSp.HasValue) _values_[0] = ea.H1LevelSp.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_H1_L_SP(System.Single H1LevelSp, bool ignore_H1LevelSp)
    {
      object[] _values_ = new object[1];
      if (!ignore_H1LevelSp) _values_[0] = H1LevelSp;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }

  }
}

namespace SE.Nereda.Symbols.Calamity
{
  partial class sSettings
  {

    private event EventHandler<SE.Nereda.Symbols.Calamity.GRAPHEventArgs> GRAPH_Fired;

    private event EventHandler<SE.Nereda.Symbols.Calamity.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    private event EventHandler<SE.Nereda.Symbols.Calamity.LEVEL_TOO_HEventArgs> LEVEL_TOO_H_Fired;

    private event EventHandler<SE.Nereda.Symbols.Calamity.LEVEL_PVEventArgs> LEVEL_PV_Fired;

    private event EventHandler<SE.Nereda.Symbols.Calamity.LEVEL_STATUSEventArgs> LEVEL_STATUS_Fired;

    protected override void OnEndInit()
    {
      if (GRAPH_Fired != null)
        AttachEventInput(0);
      if (LOAD_PERS_DATA_Fired != null)
        AttachEventInput(1);
      if (LEVEL_TOO_H_Fired != null)
        AttachEventInput(2);
      if (LEVEL_PV_Fired != null)
        AttachEventInput(3);
      if (LEVEL_STATUS_Fired != null)
        AttachEventInput(4);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (GRAPH_Fired != null)
          {
            try
            {
              GRAPH_Fired(this, new SE.Nereda.Symbols.Calamity.GRAPHEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","GRAPH_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 1:
          if (LOAD_PERS_DATA_Fired != null)
          {
            try
            {
              LOAD_PERS_DATA_Fired(this, new SE.Nereda.Symbols.Calamity.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","LOAD_PERS_DATA_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 2:
          if (LEVEL_TOO_H_Fired != null)
          {
            try
            {
              LEVEL_TOO_H_Fired(this, new SE.Nereda.Symbols.Calamity.LEVEL_TOO_HEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","LEVEL_TOO_H_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 3:
          if (LEVEL_PV_Fired != null)
          {
            try
            {
              LEVEL_PV_Fired(this, new SE.Nereda.Symbols.Calamity.LEVEL_PVEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","LEVEL_PV_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 4:
          if (LEVEL_STATUS_Fired != null)
          {
            try
            {
              LEVEL_STATUS_Fired(this, new SE.Nereda.Symbols.Calamity.LEVEL_STATUSEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","LEVEL_STATUS_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_SPEED_SP(System.Single SpeedSp)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {SpeedSp});
    }
    public bool FireEvent_SPEED_SP(SE.Nereda.Symbols.Calamity.SPEED_SPEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.SpeedSp.HasValue) _values_[0] = ea.SpeedSp.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_SPEED_SP(System.Single SpeedSp, bool ignore_SpeedSp)
    {
      object[] _values_ = new object[1];
      if (!ignore_SpeedSp) _values_[0] = SpeedSp;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_H1_L_SP(System.Single H1LevelSp)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {H1LevelSp});
    }
    public bool FireEvent_H1_L_SP(SE.Nereda.Symbols.Calamity.H1_L_SPEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.H1LevelSp.HasValue) _values_[0] = ea.H1LevelSp.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_H1_L_SP(System.Single H1LevelSp, bool ignore_H1LevelSp)
    {
      object[] _values_ = new object[1];
      if (!ignore_H1LevelSp) _values_[0] = H1LevelSp;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }

  }
}

namespace SE.Nereda.Faceplates.Calamity
{
  partial class fpSettings
  {

    private event EventHandler<SE.Nereda.Symbols.Calamity.GRAPHEventArgs> GRAPH_Fired;

    private event EventHandler<SE.Nereda.Symbols.Calamity.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    private event EventHandler<SE.Nereda.Symbols.Calamity.LEVEL_TOO_HEventArgs> LEVEL_TOO_H_Fired;

    private event EventHandler<SE.Nereda.Symbols.Calamity.LEVEL_PVEventArgs> LEVEL_PV_Fired;

    private event EventHandler<SE.Nereda.Symbols.Calamity.LEVEL_STATUSEventArgs> LEVEL_STATUS_Fired;

    protected override void OnEndInit()
    {
      if (GRAPH_Fired != null)
        AttachEventInput(0);
      if (LOAD_PERS_DATA_Fired != null)
        AttachEventInput(1);
      if (LEVEL_TOO_H_Fired != null)
        AttachEventInput(2);
      if (LEVEL_PV_Fired != null)
        AttachEventInput(3);
      if (LEVEL_STATUS_Fired != null)
        AttachEventInput(4);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (GRAPH_Fired != null)
          {
            try
            {
              GRAPH_Fired(this, new SE.Nereda.Symbols.Calamity.GRAPHEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","GRAPH_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 1:
          if (LOAD_PERS_DATA_Fired != null)
          {
            try
            {
              LOAD_PERS_DATA_Fired(this, new SE.Nereda.Symbols.Calamity.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","LOAD_PERS_DATA_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 2:
          if (LEVEL_TOO_H_Fired != null)
          {
            try
            {
              LEVEL_TOO_H_Fired(this, new SE.Nereda.Symbols.Calamity.LEVEL_TOO_HEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","LEVEL_TOO_H_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 3:
          if (LEVEL_PV_Fired != null)
          {
            try
            {
              LEVEL_PV_Fired(this, new SE.Nereda.Symbols.Calamity.LEVEL_PVEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","LEVEL_PV_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 4:
          if (LEVEL_STATUS_Fired != null)
          {
            try
            {
              LEVEL_STATUS_Fired(this, new SE.Nereda.Symbols.Calamity.LEVEL_STATUSEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","LEVEL_STATUS_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_SPEED_SP(System.Single SpeedSp)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {SpeedSp});
    }
    public bool FireEvent_SPEED_SP(SE.Nereda.Symbols.Calamity.SPEED_SPEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.SpeedSp.HasValue) _values_[0] = ea.SpeedSp.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_SPEED_SP(System.Single SpeedSp, bool ignore_SpeedSp)
    {
      object[] _values_ = new object[1];
      if (!ignore_SpeedSp) _values_[0] = SpeedSp;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_H1_L_SP(System.Single H1LevelSp)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {H1LevelSp});
    }
    public bool FireEvent_H1_L_SP(SE.Nereda.Symbols.Calamity.H1_L_SPEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.H1LevelSp.HasValue) _values_[0] = ea.H1LevelSp.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_H1_L_SP(System.Single H1LevelSp, bool ignore_H1LevelSp)
    {
      object[] _values_ = new object[1];
      if (!ignore_H1LevelSp) _values_[0] = H1LevelSp;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }

  }
}

namespace SE.Nereda.Symbols.Calamity
{
  partial class sDurations
  {

    private event EventHandler<SE.Nereda.Symbols.Calamity.GRAPHEventArgs> GRAPH_Fired;

    private event EventHandler<SE.Nereda.Symbols.Calamity.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    private event EventHandler<SE.Nereda.Symbols.Calamity.LEVEL_TOO_HEventArgs> LEVEL_TOO_H_Fired;

    private event EventHandler<SE.Nereda.Symbols.Calamity.LEVEL_PVEventArgs> LEVEL_PV_Fired;

    private event EventHandler<SE.Nereda.Symbols.Calamity.LEVEL_STATUSEventArgs> LEVEL_STATUS_Fired;

    protected override void OnEndInit()
    {
      if (GRAPH_Fired != null)
        AttachEventInput(0);
      if (LOAD_PERS_DATA_Fired != null)
        AttachEventInput(1);
      if (LEVEL_TOO_H_Fired != null)
        AttachEventInput(2);
      if (LEVEL_PV_Fired != null)
        AttachEventInput(3);
      if (LEVEL_STATUS_Fired != null)
        AttachEventInput(4);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (GRAPH_Fired != null)
          {
            try
            {
              GRAPH_Fired(this, new SE.Nereda.Symbols.Calamity.GRAPHEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","GRAPH_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 1:
          if (LOAD_PERS_DATA_Fired != null)
          {
            try
            {
              LOAD_PERS_DATA_Fired(this, new SE.Nereda.Symbols.Calamity.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","LOAD_PERS_DATA_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 2:
          if (LEVEL_TOO_H_Fired != null)
          {
            try
            {
              LEVEL_TOO_H_Fired(this, new SE.Nereda.Symbols.Calamity.LEVEL_TOO_HEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","LEVEL_TOO_H_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 3:
          if (LEVEL_PV_Fired != null)
          {
            try
            {
              LEVEL_PV_Fired(this, new SE.Nereda.Symbols.Calamity.LEVEL_PVEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","LEVEL_PV_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 4:
          if (LEVEL_STATUS_Fired != null)
          {
            try
            {
              LEVEL_STATUS_Fired(this, new SE.Nereda.Symbols.Calamity.LEVEL_STATUSEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","LEVEL_STATUS_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_SPEED_SP(System.Single SpeedSp)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {SpeedSp});
    }
    public bool FireEvent_SPEED_SP(SE.Nereda.Symbols.Calamity.SPEED_SPEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.SpeedSp.HasValue) _values_[0] = ea.SpeedSp.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_SPEED_SP(System.Single SpeedSp, bool ignore_SpeedSp)
    {
      object[] _values_ = new object[1];
      if (!ignore_SpeedSp) _values_[0] = SpeedSp;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_H1_L_SP(System.Single H1LevelSp)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {H1LevelSp});
    }
    public bool FireEvent_H1_L_SP(SE.Nereda.Symbols.Calamity.H1_L_SPEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.H1LevelSp.HasValue) _values_[0] = ea.H1LevelSp.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_H1_L_SP(System.Single H1LevelSp, bool ignore_H1LevelSp)
    {
      object[] _values_ = new object[1];
      if (!ignore_H1LevelSp) _values_[0] = H1LevelSp;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }

  }
}

namespace SE.Nereda.Symbols.Calamity
{
  partial class sHiHiLevelCalamity
  {

    private event EventHandler<SE.Nereda.Symbols.Calamity.GRAPHEventArgs> GRAPH_Fired;

    private event EventHandler<SE.Nereda.Symbols.Calamity.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    private event EventHandler<SE.Nereda.Symbols.Calamity.LEVEL_TOO_HEventArgs> LEVEL_TOO_H_Fired;

    private event EventHandler<SE.Nereda.Symbols.Calamity.LEVEL_PVEventArgs> LEVEL_PV_Fired;

    private event EventHandler<SE.Nereda.Symbols.Calamity.LEVEL_STATUSEventArgs> LEVEL_STATUS_Fired;

    protected override void OnEndInit()
    {
      if (GRAPH_Fired != null)
        AttachEventInput(0);
      if (LOAD_PERS_DATA_Fired != null)
        AttachEventInput(1);
      if (LEVEL_TOO_H_Fired != null)
        AttachEventInput(2);
      if (LEVEL_PV_Fired != null)
        AttachEventInput(3);
      if (LEVEL_STATUS_Fired != null)
        AttachEventInput(4);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (GRAPH_Fired != null)
          {
            try
            {
              GRAPH_Fired(this, new SE.Nereda.Symbols.Calamity.GRAPHEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","GRAPH_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 1:
          if (LOAD_PERS_DATA_Fired != null)
          {
            try
            {
              LOAD_PERS_DATA_Fired(this, new SE.Nereda.Symbols.Calamity.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","LOAD_PERS_DATA_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 2:
          if (LEVEL_TOO_H_Fired != null)
          {
            try
            {
              LEVEL_TOO_H_Fired(this, new SE.Nereda.Symbols.Calamity.LEVEL_TOO_HEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","LEVEL_TOO_H_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 3:
          if (LEVEL_PV_Fired != null)
          {
            try
            {
              LEVEL_PV_Fired(this, new SE.Nereda.Symbols.Calamity.LEVEL_PVEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","LEVEL_PV_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 4:
          if (LEVEL_STATUS_Fired != null)
          {
            try
            {
              LEVEL_STATUS_Fired(this, new SE.Nereda.Symbols.Calamity.LEVEL_STATUSEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","LEVEL_STATUS_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_SPEED_SP(System.Single SpeedSp)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {SpeedSp});
    }
    public bool FireEvent_SPEED_SP(SE.Nereda.Symbols.Calamity.SPEED_SPEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.SpeedSp.HasValue) _values_[0] = ea.SpeedSp.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_SPEED_SP(System.Single SpeedSp, bool ignore_SpeedSp)
    {
      object[] _values_ = new object[1];
      if (!ignore_SpeedSp) _values_[0] = SpeedSp;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_H1_L_SP(System.Single H1LevelSp)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {H1LevelSp});
    }
    public bool FireEvent_H1_L_SP(SE.Nereda.Symbols.Calamity.H1_L_SPEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.H1LevelSp.HasValue) _values_[0] = ea.H1LevelSp.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_H1_L_SP(System.Single H1LevelSp, bool ignore_H1LevelSp)
    {
      object[] _values_ = new object[1];
      if (!ignore_H1LevelSp) _values_[0] = H1LevelSp;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }

  }
}

namespace SE.Nereda.Faceplates.Calamity
{
  partial class fpHiHiActions
  {

    private event EventHandler<SE.Nereda.Symbols.Calamity.GRAPHEventArgs> GRAPH_Fired;

    private event EventHandler<SE.Nereda.Symbols.Calamity.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    private event EventHandler<SE.Nereda.Symbols.Calamity.LEVEL_TOO_HEventArgs> LEVEL_TOO_H_Fired;

    private event EventHandler<SE.Nereda.Symbols.Calamity.LEVEL_PVEventArgs> LEVEL_PV_Fired;

    private event EventHandler<SE.Nereda.Symbols.Calamity.LEVEL_STATUSEventArgs> LEVEL_STATUS_Fired;

    protected override void OnEndInit()
    {
      if (GRAPH_Fired != null)
        AttachEventInput(0);
      if (LOAD_PERS_DATA_Fired != null)
        AttachEventInput(1);
      if (LEVEL_TOO_H_Fired != null)
        AttachEventInput(2);
      if (LEVEL_PV_Fired != null)
        AttachEventInput(3);
      if (LEVEL_STATUS_Fired != null)
        AttachEventInput(4);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (GRAPH_Fired != null)
          {
            try
            {
              GRAPH_Fired(this, new SE.Nereda.Symbols.Calamity.GRAPHEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","GRAPH_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 1:
          if (LOAD_PERS_DATA_Fired != null)
          {
            try
            {
              LOAD_PERS_DATA_Fired(this, new SE.Nereda.Symbols.Calamity.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","LOAD_PERS_DATA_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 2:
          if (LEVEL_TOO_H_Fired != null)
          {
            try
            {
              LEVEL_TOO_H_Fired(this, new SE.Nereda.Symbols.Calamity.LEVEL_TOO_HEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","LEVEL_TOO_H_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 3:
          if (LEVEL_PV_Fired != null)
          {
            try
            {
              LEVEL_PV_Fired(this, new SE.Nereda.Symbols.Calamity.LEVEL_PVEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","LEVEL_PV_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 4:
          if (LEVEL_STATUS_Fired != null)
          {
            try
            {
              LEVEL_STATUS_Fired(this, new SE.Nereda.Symbols.Calamity.LEVEL_STATUSEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","LEVEL_STATUS_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_SPEED_SP(System.Single SpeedSp)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {SpeedSp});
    }
    public bool FireEvent_SPEED_SP(SE.Nereda.Symbols.Calamity.SPEED_SPEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.SpeedSp.HasValue) _values_[0] = ea.SpeedSp.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_SPEED_SP(System.Single SpeedSp, bool ignore_SpeedSp)
    {
      object[] _values_ = new object[1];
      if (!ignore_SpeedSp) _values_[0] = SpeedSp;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_H1_L_SP(System.Single H1LevelSp)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {H1LevelSp});
    }
    public bool FireEvent_H1_L_SP(SE.Nereda.Symbols.Calamity.H1_L_SPEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.H1LevelSp.HasValue) _values_[0] = ea.H1LevelSp.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_H1_L_SP(System.Single H1LevelSp, bool ignore_H1LevelSp)
    {
      object[] _values_ = new object[1];
      if (!ignore_H1LevelSp) _values_[0] = H1LevelSp;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }

  }
}

namespace SE.Nereda.Symbols.Calamity
{
  partial class sForceClose
  {

    private event EventHandler<SE.Nereda.Symbols.Calamity.GRAPHEventArgs> GRAPH_Fired;

    private event EventHandler<SE.Nereda.Symbols.Calamity.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    private event EventHandler<SE.Nereda.Symbols.Calamity.LEVEL_TOO_HEventArgs> LEVEL_TOO_H_Fired;

    private event EventHandler<SE.Nereda.Symbols.Calamity.LEVEL_PVEventArgs> LEVEL_PV_Fired;

    private event EventHandler<SE.Nereda.Symbols.Calamity.LEVEL_STATUSEventArgs> LEVEL_STATUS_Fired;

    protected override void OnEndInit()
    {
      if (GRAPH_Fired != null)
        AttachEventInput(0);
      if (LOAD_PERS_DATA_Fired != null)
        AttachEventInput(1);
      if (LEVEL_TOO_H_Fired != null)
        AttachEventInput(2);
      if (LEVEL_PV_Fired != null)
        AttachEventInput(3);
      if (LEVEL_STATUS_Fired != null)
        AttachEventInput(4);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (GRAPH_Fired != null)
          {
            try
            {
              GRAPH_Fired(this, new SE.Nereda.Symbols.Calamity.GRAPHEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","GRAPH_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 1:
          if (LOAD_PERS_DATA_Fired != null)
          {
            try
            {
              LOAD_PERS_DATA_Fired(this, new SE.Nereda.Symbols.Calamity.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","LOAD_PERS_DATA_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 2:
          if (LEVEL_TOO_H_Fired != null)
          {
            try
            {
              LEVEL_TOO_H_Fired(this, new SE.Nereda.Symbols.Calamity.LEVEL_TOO_HEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","LEVEL_TOO_H_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 3:
          if (LEVEL_PV_Fired != null)
          {
            try
            {
              LEVEL_PV_Fired(this, new SE.Nereda.Symbols.Calamity.LEVEL_PVEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","LEVEL_PV_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 4:
          if (LEVEL_STATUS_Fired != null)
          {
            try
            {
              LEVEL_STATUS_Fired(this, new SE.Nereda.Symbols.Calamity.LEVEL_STATUSEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","LEVEL_STATUS_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_SPEED_SP(System.Single SpeedSp)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {SpeedSp});
    }
    public bool FireEvent_SPEED_SP(SE.Nereda.Symbols.Calamity.SPEED_SPEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.SpeedSp.HasValue) _values_[0] = ea.SpeedSp.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_SPEED_SP(System.Single SpeedSp, bool ignore_SpeedSp)
    {
      object[] _values_ = new object[1];
      if (!ignore_SpeedSp) _values_[0] = SpeedSp;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_H1_L_SP(System.Single H1LevelSp)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {H1LevelSp});
    }
    public bool FireEvent_H1_L_SP(SE.Nereda.Symbols.Calamity.H1_L_SPEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.H1LevelSp.HasValue) _values_[0] = ea.H1LevelSp.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_H1_L_SP(System.Single H1LevelSp, bool ignore_H1LevelSp)
    {
      object[] _values_ = new object[1];
      if (!ignore_H1LevelSp) _values_[0] = H1LevelSp;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }

  }
}
#endregion #Calamity_HMI;

#endregion Definitions;
