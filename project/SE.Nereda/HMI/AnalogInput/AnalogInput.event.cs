/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 6/5/2026
 * Time: 3:20 PM
 * 
 */
using System;
using NxtControl.GuiFramework;
using NxtControl.Services;

#region Definitions;
#region #AnalogInput_HMI;

namespace SE.Nereda.Symbols.AnalogInput
{

  public class REQ_PVEventArgs : System.EventArgs
  {
    IHMIAccessorService accessorService;
    int channelId;
    int cookie; 
    int eventIndex;

    public REQ_PVEventArgs(int channelId, int cookie, int eventIndex)
    {
      this.accessorService = (IHMIAccessorService)ServiceProvider.GetService(typeof(IHMIAccessorService));
      this.channelId = channelId;
      this.cookie = cookie;
      this.eventIndex = eventIndex;
    }
    public bool Get_Pv(ref System.Single value)
    {
      if (accessorService == null)
        return false;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,0, ref var);
      if (ret) value = (System.Single) var;
      return ret;
    }

    public System.Single? Pv
    { get {
      if (accessorService == null)
        return null;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,0, ref var);
      if (!ret) return null;
      return (System.Single) var;
    }  }

    public bool Get_PvMin(ref System.Single value)
    {
      if (accessorService == null)
        return false;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,1, ref var);
      if (ret) value = (System.Single) var;
      return ret;
    }

    public System.Single? PvMin
    { get {
      if (accessorService == null)
        return null;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,1, ref var);
      if (!ret) return null;
      return (System.Single) var;
    }  }

    public bool Get_PvMax(ref System.Single value)
    {
      if (accessorService == null)
        return false;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,2, ref var);
      if (ret) value = (System.Single) var;
      return ret;
    }

    public System.Single? PvMax
    { get {
      if (accessorService == null)
        return null;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,2, ref var);
      if (!ret) return null;
      return (System.Single) var;
    }  }

    public bool Get_L1(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,3, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? L1
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,3, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_L2(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,4, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? L2
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,4, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_OverrideStatus(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,5, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? OverrideStatus
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,5, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }


  }

  public class REQ_ALM_LIM_SPEventArgs : System.EventArgs
  {
    IHMIAccessorService accessorService;
    int channelId;
    int cookie; 
    int eventIndex;

    public REQ_ALM_LIM_SPEventArgs(int channelId, int cookie, int eventIndex)
    {
      this.accessorService = (IHMIAccessorService)ServiceProvider.GetService(typeof(IHMIAccessorService));
      this.channelId = channelId;
      this.cookie = cookie;
      this.eventIndex = eventIndex;
    }
    public bool Get_HiHiSp(ref System.Single value)
    {
      if (accessorService == null)
        return false;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,0, ref var);
      if (ret) value = (System.Single) var;
      return ret;
    }

    public System.Single? HiHiSp
    { get {
      if (accessorService == null)
        return null;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,0, ref var);
      if (!ret) return null;
      return (System.Single) var;
    }  }

    public bool Get_HiSp(ref System.Single value)
    {
      if (accessorService == null)
        return false;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,1, ref var);
      if (ret) value = (System.Single) var;
      return ret;
    }

    public System.Single? HiSp
    { get {
      if (accessorService == null)
        return null;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,1, ref var);
      if (!ret) return null;
      return (System.Single) var;
    }  }

    public bool Get_LoSp(ref System.Single value)
    {
      if (accessorService == null)
        return false;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,2, ref var);
      if (ret) value = (System.Single) var;
      return ret;
    }

    public System.Single? LoSp
    { get {
      if (accessorService == null)
        return null;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,2, ref var);
      if (!ret) return null;
      return (System.Single) var;
    }  }

    public bool Get_LoLoSp(ref System.Single value)
    {
      if (accessorService == null)
        return false;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,3, ref var);
      if (ret) value = (System.Single) var;
      return ret;
    }

    public System.Single? LoLoSp
    { get {
      if (accessorService == null)
        return null;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,3, ref var);
      if (!ret) return null;
      return (System.Single) var;
    }  }

    public bool Get_HiHiPv(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,4, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? HiHiPv
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,4, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_HiPv(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,5, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? HiPv
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,5, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_LoPv(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,6, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? LoPv
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,6, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_LoLoPv(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,7, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? LoLoPv
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,7, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_HiHiDisabled(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,8, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? HiHiDisabled
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,8, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_HiDisabled(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,9, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? HiDisabled
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,9, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_LoDisabled(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,10, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? LoDisabled
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,10, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_LoLoDisabled(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,11, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? LoLoDisabled
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,11, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }


  }

  public class REQ_UNITEventArgs : System.EventArgs
  {
    IHMIAccessorService accessorService;
    int channelId;
    int cookie; 
    int eventIndex;

    public REQ_UNITEventArgs(int channelId, int cookie, int eventIndex)
    {
      this.accessorService = (IHMIAccessorService)ServiceProvider.GetService(typeof(IHMIAccessorService));
      this.channelId = channelId;
      this.cookie = cookie;
      this.eventIndex = eventIndex;
    }
    public bool Get_iUnit(ref System.String value)
    {
      if (accessorService == null)
        return false;
      string var = null;
      bool ret = accessorService.GetStringValue(channelId, cookie, eventIndex, true,0, ref var);
      if (ret) value = (System.String) var;
      return ret;
    }

    public System.String iUnit
    { get {
      if (accessorService == null)
        return null;
      string var = null;
      bool ret = accessorService.GetStringValue(channelId, cookie, eventIndex, true,0, ref var);
      if (!ret) return null;
      return (System.String) var;
    }  }

    public bool Get_iFlowSensor(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,1, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? iFlowSensor
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,1, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }


  }

  public class FB_COLOREventArgs : System.EventArgs
  {
    IHMIAccessorService accessorService;
    int channelId;
    int cookie; 
    int eventIndex;

    public FB_COLOREventArgs(int channelId, int cookie, int eventIndex)
    {
      this.accessorService = (IHMIAccessorService)ServiceProvider.GetService(typeof(IHMIAccessorService));
      this.channelId = channelId;
      this.cookie = cookie;
      this.eventIndex = eventIndex;
    }
    public bool Get_iColor(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,0, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? iColor
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,0, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }


  }

  public class CH_FAILEventArgs : System.EventArgs
  {
    IHMIAccessorService accessorService;
    int channelId;
    int cookie; 
    int eventIndex;

    public CH_FAILEventArgs(int channelId, int cookie, int eventIndex)
    {
      this.accessorService = (IHMIAccessorService)ServiceProvider.GetService(typeof(IHMIAccessorService));
      this.channelId = channelId;
      this.cookie = cookie;
      this.eventIndex = eventIndex;
    }
    public bool Get_ChFail(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,0, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? ChFail
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

namespace SE.Nereda.Symbols.AnalogInput
{

  public class CNF_UNITEventArgs : System.EventArgs
  {
    public CNF_UNITEventArgs()
    {
    }
    private System.String oUnit_field = null;
    public System.String oUnit
    {
       get { return oUnit_field; }
       set { oUnit_field = value; }
    }
    private System.Boolean? oFlowSensor_field = null;
    public System.Boolean? oFlowSensor
    {
       get { return oFlowSensor_field; }
       set { oFlowSensor_field = value; }
    }

  }

  public class CNF_COLOREventArgs : System.EventArgs
  {
    public CNF_COLOREventArgs()
    {
    }
    private System.Int16? oColor_field = null;
    public System.Int16? oColor
    {
       get { return oColor_field; }
       set { oColor_field = value; }
    }

  }

  public class CNF_LEVEL_SPEventArgs : System.EventArgs
  {
    public CNF_LEVEL_SPEventArgs()
    {
    }
    private System.Single? LevelSp1_field = null;
    public System.Single? LevelSp1
    {
       get { return LevelSp1_field; }
       set { LevelSp1_field = value; }
    }
    private System.Single? LevelSp2_field = null;
    public System.Single? LevelSp2
    {
       get { return LevelSp2_field; }
       set { LevelSp2_field = value; }
    }

  }

  public class CNF_EN_F_CEventArgs : System.EventArgs
  {
    public CNF_EN_F_CEventArgs()
    {
    }
    private System.Boolean? EnFlowConversion_field = null;
    public System.Boolean? EnFlowConversion
    {
       get { return EnFlowConversion_field; }
       set { EnFlowConversion_field = value; }
    }

  }

}

namespace SE.Nereda.Symbols.AnalogInput
{
  partial class sDisplayPv1
  {

    private event EventHandler<SE.Nereda.Symbols.AnalogInput.REQ_PVEventArgs> REQ_PV_Fired;

    private event EventHandler<SE.Nereda.Symbols.AnalogInput.REQ_ALM_LIM_SPEventArgs> REQ_ALM_LIM_SP_Fired;

    private event EventHandler<SE.Nereda.Symbols.AnalogInput.REQ_UNITEventArgs> REQ_UNIT_Fired;

    private event EventHandler<SE.Nereda.Symbols.AnalogInput.FB_COLOREventArgs> FB_COLOR_Fired;

    private event EventHandler<SE.Nereda.Symbols.AnalogInput.CH_FAILEventArgs> CH_FAIL_Fired;

    private event EventHandler<SE.Nereda.Symbols.AnalogInput.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    protected override void OnEndInit()
    {
      if (REQ_PV_Fired != null)
        AttachEventInput(0);
      if (REQ_ALM_LIM_SP_Fired != null)
        AttachEventInput(1);
      if (REQ_UNIT_Fired != null)
        AttachEventInput(2);
      if (FB_COLOR_Fired != null)
        AttachEventInput(3);
      if (CH_FAIL_Fired != null)
        AttachEventInput(4);
      if (LOAD_PERS_DATA_Fired != null)
        AttachEventInput(5);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (REQ_PV_Fired != null)
          {
            try
            {
              REQ_PV_Fired(this, new SE.Nereda.Symbols.AnalogInput.REQ_PVEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REQ_PV_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 1:
          if (REQ_ALM_LIM_SP_Fired != null)
          {
            try
            {
              REQ_ALM_LIM_SP_Fired(this, new SE.Nereda.Symbols.AnalogInput.REQ_ALM_LIM_SPEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REQ_ALM_LIM_SP_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 2:
          if (REQ_UNIT_Fired != null)
          {
            try
            {
              REQ_UNIT_Fired(this, new SE.Nereda.Symbols.AnalogInput.REQ_UNITEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REQ_UNIT_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 3:
          if (FB_COLOR_Fired != null)
          {
            try
            {
              FB_COLOR_Fired(this, new SE.Nereda.Symbols.AnalogInput.FB_COLOREventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","FB_COLOR_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 4:
          if (CH_FAIL_Fired != null)
          {
            try
            {
              CH_FAIL_Fired(this, new SE.Nereda.Symbols.AnalogInput.CH_FAILEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","CH_FAIL_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 5:
          if (LOAD_PERS_DATA_Fired != null)
          {
            try
            {
              LOAD_PERS_DATA_Fired(this, new SE.Nereda.Symbols.AnalogInput.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
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
    public bool FireEvent_CNF_UNIT(System.String oUnit, System.Boolean oFlowSensor)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {oUnit, oFlowSensor});
    }
    public bool FireEvent_CNF_UNIT(SE.Nereda.Symbols.AnalogInput.CNF_UNITEventArgs ea)
    {
      object[] _values_ = new object[2];
      if (ea.oUnit != null) _values_[0] = ea.oUnit;
      if (ea.oFlowSensor.HasValue) _values_[1] = ea.oFlowSensor.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_CNF_UNIT(System.String oUnit, bool ignore_oUnit, System.Boolean oFlowSensor, bool ignore_oFlowSensor)
    {
      object[] _values_ = new object[2];
      if (!ignore_oUnit) _values_[0] = oUnit;
      if (!ignore_oFlowSensor) _values_[1] = oFlowSensor;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_CNF_COLOR(System.Int16 oColor)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {oColor});
    }
    public bool FireEvent_CNF_COLOR(SE.Nereda.Symbols.AnalogInput.CNF_COLOREventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.oColor.HasValue) _values_[0] = ea.oColor.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_CNF_COLOR(System.Int16 oColor, bool ignore_oColor)
    {
      object[] _values_ = new object[1];
      if (!ignore_oColor) _values_[0] = oColor;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_CNF_LEVEL_SP(System.Single LevelSp1, System.Single LevelSp2)
    {
      return ((IHMIAccessorOutput)this).FireEvent(2, new object[] {LevelSp1, LevelSp2});
    }
    public bool FireEvent_CNF_LEVEL_SP(SE.Nereda.Symbols.AnalogInput.CNF_LEVEL_SPEventArgs ea)
    {
      object[] _values_ = new object[2];
      if (ea.LevelSp1.HasValue) _values_[0] = ea.LevelSp1.Value;
      if (ea.LevelSp2.HasValue) _values_[1] = ea.LevelSp2.Value;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_CNF_LEVEL_SP(System.Single LevelSp1, bool ignore_LevelSp1, System.Single LevelSp2, bool ignore_LevelSp2)
    {
      object[] _values_ = new object[2];
      if (!ignore_LevelSp1) _values_[0] = LevelSp1;
      if (!ignore_LevelSp2) _values_[1] = LevelSp2;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_CNF_EN_F_C(System.Boolean EnFlowConversion)
    {
      return ((IHMIAccessorOutput)this).FireEvent(3, new object[] {EnFlowConversion});
    }
    public bool FireEvent_CNF_EN_F_C(SE.Nereda.Symbols.AnalogInput.CNF_EN_F_CEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.EnFlowConversion.HasValue) _values_[0] = ea.EnFlowConversion.Value;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_CNF_EN_F_C(System.Boolean EnFlowConversion, bool ignore_EnFlowConversion)
    {
      object[] _values_ = new object[1];
      if (!ignore_EnFlowConversion) _values_[0] = EnFlowConversion;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }

  }
}

namespace SE.Nereda.Faceplates.AnalogInput
{
  partial class fpDefault
  {

    private event EventHandler<SE.Nereda.Symbols.AnalogInput.REQ_PVEventArgs> REQ_PV_Fired;

    private event EventHandler<SE.Nereda.Symbols.AnalogInput.REQ_ALM_LIM_SPEventArgs> REQ_ALM_LIM_SP_Fired;

    private event EventHandler<SE.Nereda.Symbols.AnalogInput.REQ_UNITEventArgs> REQ_UNIT_Fired;

    private event EventHandler<SE.Nereda.Symbols.AnalogInput.FB_COLOREventArgs> FB_COLOR_Fired;

    private event EventHandler<SE.Nereda.Symbols.AnalogInput.CH_FAILEventArgs> CH_FAIL_Fired;

    private event EventHandler<SE.Nereda.Symbols.AnalogInput.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    protected override void OnEndInit()
    {
      if (REQ_PV_Fired != null)
        AttachEventInput(0);
      if (REQ_ALM_LIM_SP_Fired != null)
        AttachEventInput(1);
      if (REQ_UNIT_Fired != null)
        AttachEventInput(2);
      if (FB_COLOR_Fired != null)
        AttachEventInput(3);
      if (CH_FAIL_Fired != null)
        AttachEventInput(4);
      if (LOAD_PERS_DATA_Fired != null)
        AttachEventInput(5);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (REQ_PV_Fired != null)
          {
            try
            {
              REQ_PV_Fired(this, new SE.Nereda.Symbols.AnalogInput.REQ_PVEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REQ_PV_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 1:
          if (REQ_ALM_LIM_SP_Fired != null)
          {
            try
            {
              REQ_ALM_LIM_SP_Fired(this, new SE.Nereda.Symbols.AnalogInput.REQ_ALM_LIM_SPEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REQ_ALM_LIM_SP_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 2:
          if (REQ_UNIT_Fired != null)
          {
            try
            {
              REQ_UNIT_Fired(this, new SE.Nereda.Symbols.AnalogInput.REQ_UNITEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REQ_UNIT_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 3:
          if (FB_COLOR_Fired != null)
          {
            try
            {
              FB_COLOR_Fired(this, new SE.Nereda.Symbols.AnalogInput.FB_COLOREventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","FB_COLOR_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 4:
          if (CH_FAIL_Fired != null)
          {
            try
            {
              CH_FAIL_Fired(this, new SE.Nereda.Symbols.AnalogInput.CH_FAILEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","CH_FAIL_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 5:
          if (LOAD_PERS_DATA_Fired != null)
          {
            try
            {
              LOAD_PERS_DATA_Fired(this, new SE.Nereda.Symbols.AnalogInput.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
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
    public bool FireEvent_CNF_UNIT(System.String oUnit, System.Boolean oFlowSensor)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {oUnit, oFlowSensor});
    }
    public bool FireEvent_CNF_UNIT(SE.Nereda.Symbols.AnalogInput.CNF_UNITEventArgs ea)
    {
      object[] _values_ = new object[2];
      if (ea.oUnit != null) _values_[0] = ea.oUnit;
      if (ea.oFlowSensor.HasValue) _values_[1] = ea.oFlowSensor.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_CNF_UNIT(System.String oUnit, bool ignore_oUnit, System.Boolean oFlowSensor, bool ignore_oFlowSensor)
    {
      object[] _values_ = new object[2];
      if (!ignore_oUnit) _values_[0] = oUnit;
      if (!ignore_oFlowSensor) _values_[1] = oFlowSensor;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_CNF_COLOR(System.Int16 oColor)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {oColor});
    }
    public bool FireEvent_CNF_COLOR(SE.Nereda.Symbols.AnalogInput.CNF_COLOREventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.oColor.HasValue) _values_[0] = ea.oColor.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_CNF_COLOR(System.Int16 oColor, bool ignore_oColor)
    {
      object[] _values_ = new object[1];
      if (!ignore_oColor) _values_[0] = oColor;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_CNF_LEVEL_SP(System.Single LevelSp1, System.Single LevelSp2)
    {
      return ((IHMIAccessorOutput)this).FireEvent(2, new object[] {LevelSp1, LevelSp2});
    }
    public bool FireEvent_CNF_LEVEL_SP(SE.Nereda.Symbols.AnalogInput.CNF_LEVEL_SPEventArgs ea)
    {
      object[] _values_ = new object[2];
      if (ea.LevelSp1.HasValue) _values_[0] = ea.LevelSp1.Value;
      if (ea.LevelSp2.HasValue) _values_[1] = ea.LevelSp2.Value;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_CNF_LEVEL_SP(System.Single LevelSp1, bool ignore_LevelSp1, System.Single LevelSp2, bool ignore_LevelSp2)
    {
      object[] _values_ = new object[2];
      if (!ignore_LevelSp1) _values_[0] = LevelSp1;
      if (!ignore_LevelSp2) _values_[1] = LevelSp2;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_CNF_EN_F_C(System.Boolean EnFlowConversion)
    {
      return ((IHMIAccessorOutput)this).FireEvent(3, new object[] {EnFlowConversion});
    }
    public bool FireEvent_CNF_EN_F_C(SE.Nereda.Symbols.AnalogInput.CNF_EN_F_CEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.EnFlowConversion.HasValue) _values_[0] = ea.EnFlowConversion.Value;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_CNF_EN_F_C(System.Boolean EnFlowConversion, bool ignore_EnFlowConversion)
    {
      object[] _values_ = new object[1];
      if (!ignore_EnFlowConversion) _values_[0] = EnFlowConversion;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }

  }
}

namespace SE.Nereda.Symbols.AnalogInput
{
  partial class sDisplayPv2
  {

    private event EventHandler<SE.Nereda.Symbols.AnalogInput.REQ_PVEventArgs> REQ_PV_Fired;

    private event EventHandler<SE.Nereda.Symbols.AnalogInput.REQ_ALM_LIM_SPEventArgs> REQ_ALM_LIM_SP_Fired;

    private event EventHandler<SE.Nereda.Symbols.AnalogInput.REQ_UNITEventArgs> REQ_UNIT_Fired;

    private event EventHandler<SE.Nereda.Symbols.AnalogInput.FB_COLOREventArgs> FB_COLOR_Fired;

    private event EventHandler<SE.Nereda.Symbols.AnalogInput.CH_FAILEventArgs> CH_FAIL_Fired;

    private event EventHandler<SE.Nereda.Symbols.AnalogInput.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    protected override void OnEndInit()
    {
      if (REQ_PV_Fired != null)
        AttachEventInput(0);
      if (REQ_ALM_LIM_SP_Fired != null)
        AttachEventInput(1);
      if (REQ_UNIT_Fired != null)
        AttachEventInput(2);
      if (FB_COLOR_Fired != null)
        AttachEventInput(3);
      if (CH_FAIL_Fired != null)
        AttachEventInput(4);
      if (LOAD_PERS_DATA_Fired != null)
        AttachEventInput(5);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (REQ_PV_Fired != null)
          {
            try
            {
              REQ_PV_Fired(this, new SE.Nereda.Symbols.AnalogInput.REQ_PVEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REQ_PV_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 1:
          if (REQ_ALM_LIM_SP_Fired != null)
          {
            try
            {
              REQ_ALM_LIM_SP_Fired(this, new SE.Nereda.Symbols.AnalogInput.REQ_ALM_LIM_SPEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REQ_ALM_LIM_SP_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 2:
          if (REQ_UNIT_Fired != null)
          {
            try
            {
              REQ_UNIT_Fired(this, new SE.Nereda.Symbols.AnalogInput.REQ_UNITEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REQ_UNIT_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 3:
          if (FB_COLOR_Fired != null)
          {
            try
            {
              FB_COLOR_Fired(this, new SE.Nereda.Symbols.AnalogInput.FB_COLOREventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","FB_COLOR_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 4:
          if (CH_FAIL_Fired != null)
          {
            try
            {
              CH_FAIL_Fired(this, new SE.Nereda.Symbols.AnalogInput.CH_FAILEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","CH_FAIL_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 5:
          if (LOAD_PERS_DATA_Fired != null)
          {
            try
            {
              LOAD_PERS_DATA_Fired(this, new SE.Nereda.Symbols.AnalogInput.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
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
    public bool FireEvent_CNF_UNIT(System.String oUnit, System.Boolean oFlowSensor)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {oUnit, oFlowSensor});
    }
    public bool FireEvent_CNF_UNIT(SE.Nereda.Symbols.AnalogInput.CNF_UNITEventArgs ea)
    {
      object[] _values_ = new object[2];
      if (ea.oUnit != null) _values_[0] = ea.oUnit;
      if (ea.oFlowSensor.HasValue) _values_[1] = ea.oFlowSensor.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_CNF_UNIT(System.String oUnit, bool ignore_oUnit, System.Boolean oFlowSensor, bool ignore_oFlowSensor)
    {
      object[] _values_ = new object[2];
      if (!ignore_oUnit) _values_[0] = oUnit;
      if (!ignore_oFlowSensor) _values_[1] = oFlowSensor;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_CNF_COLOR(System.Int16 oColor)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {oColor});
    }
    public bool FireEvent_CNF_COLOR(SE.Nereda.Symbols.AnalogInput.CNF_COLOREventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.oColor.HasValue) _values_[0] = ea.oColor.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_CNF_COLOR(System.Int16 oColor, bool ignore_oColor)
    {
      object[] _values_ = new object[1];
      if (!ignore_oColor) _values_[0] = oColor;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_CNF_LEVEL_SP(System.Single LevelSp1, System.Single LevelSp2)
    {
      return ((IHMIAccessorOutput)this).FireEvent(2, new object[] {LevelSp1, LevelSp2});
    }
    public bool FireEvent_CNF_LEVEL_SP(SE.Nereda.Symbols.AnalogInput.CNF_LEVEL_SPEventArgs ea)
    {
      object[] _values_ = new object[2];
      if (ea.LevelSp1.HasValue) _values_[0] = ea.LevelSp1.Value;
      if (ea.LevelSp2.HasValue) _values_[1] = ea.LevelSp2.Value;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_CNF_LEVEL_SP(System.Single LevelSp1, bool ignore_LevelSp1, System.Single LevelSp2, bool ignore_LevelSp2)
    {
      object[] _values_ = new object[2];
      if (!ignore_LevelSp1) _values_[0] = LevelSp1;
      if (!ignore_LevelSp2) _values_[1] = LevelSp2;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_CNF_EN_F_C(System.Boolean EnFlowConversion)
    {
      return ((IHMIAccessorOutput)this).FireEvent(3, new object[] {EnFlowConversion});
    }
    public bool FireEvent_CNF_EN_F_C(SE.Nereda.Symbols.AnalogInput.CNF_EN_F_CEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.EnFlowConversion.HasValue) _values_[0] = ea.EnFlowConversion.Value;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_CNF_EN_F_C(System.Boolean EnFlowConversion, bool ignore_EnFlowConversion)
    {
      object[] _values_ = new object[1];
      if (!ignore_EnFlowConversion) _values_[0] = EnFlowConversion;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }

  }
}

namespace SE.Nereda.Symbols.AnalogInput
{
  partial class sPvBarHoz
  {

    private event EventHandler<SE.Nereda.Symbols.AnalogInput.REQ_PVEventArgs> REQ_PV_Fired;

    private event EventHandler<SE.Nereda.Symbols.AnalogInput.REQ_ALM_LIM_SPEventArgs> REQ_ALM_LIM_SP_Fired;

    private event EventHandler<SE.Nereda.Symbols.AnalogInput.REQ_UNITEventArgs> REQ_UNIT_Fired;

    private event EventHandler<SE.Nereda.Symbols.AnalogInput.FB_COLOREventArgs> FB_COLOR_Fired;

    private event EventHandler<SE.Nereda.Symbols.AnalogInput.CH_FAILEventArgs> CH_FAIL_Fired;

    private event EventHandler<SE.Nereda.Symbols.AnalogInput.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    protected override void OnEndInit()
    {
      if (REQ_PV_Fired != null)
        AttachEventInput(0);
      if (REQ_ALM_LIM_SP_Fired != null)
        AttachEventInput(1);
      if (REQ_UNIT_Fired != null)
        AttachEventInput(2);
      if (FB_COLOR_Fired != null)
        AttachEventInput(3);
      if (CH_FAIL_Fired != null)
        AttachEventInput(4);
      if (LOAD_PERS_DATA_Fired != null)
        AttachEventInput(5);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (REQ_PV_Fired != null)
          {
            try
            {
              REQ_PV_Fired(this, new SE.Nereda.Symbols.AnalogInput.REQ_PVEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REQ_PV_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 1:
          if (REQ_ALM_LIM_SP_Fired != null)
          {
            try
            {
              REQ_ALM_LIM_SP_Fired(this, new SE.Nereda.Symbols.AnalogInput.REQ_ALM_LIM_SPEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REQ_ALM_LIM_SP_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 2:
          if (REQ_UNIT_Fired != null)
          {
            try
            {
              REQ_UNIT_Fired(this, new SE.Nereda.Symbols.AnalogInput.REQ_UNITEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REQ_UNIT_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 3:
          if (FB_COLOR_Fired != null)
          {
            try
            {
              FB_COLOR_Fired(this, new SE.Nereda.Symbols.AnalogInput.FB_COLOREventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","FB_COLOR_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 4:
          if (CH_FAIL_Fired != null)
          {
            try
            {
              CH_FAIL_Fired(this, new SE.Nereda.Symbols.AnalogInput.CH_FAILEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","CH_FAIL_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 5:
          if (LOAD_PERS_DATA_Fired != null)
          {
            try
            {
              LOAD_PERS_DATA_Fired(this, new SE.Nereda.Symbols.AnalogInput.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
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
    public bool FireEvent_CNF_UNIT(System.String oUnit, System.Boolean oFlowSensor)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {oUnit, oFlowSensor});
    }
    public bool FireEvent_CNF_UNIT(SE.Nereda.Symbols.AnalogInput.CNF_UNITEventArgs ea)
    {
      object[] _values_ = new object[2];
      if (ea.oUnit != null) _values_[0] = ea.oUnit;
      if (ea.oFlowSensor.HasValue) _values_[1] = ea.oFlowSensor.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_CNF_UNIT(System.String oUnit, bool ignore_oUnit, System.Boolean oFlowSensor, bool ignore_oFlowSensor)
    {
      object[] _values_ = new object[2];
      if (!ignore_oUnit) _values_[0] = oUnit;
      if (!ignore_oFlowSensor) _values_[1] = oFlowSensor;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_CNF_COLOR(System.Int16 oColor)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {oColor});
    }
    public bool FireEvent_CNF_COLOR(SE.Nereda.Symbols.AnalogInput.CNF_COLOREventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.oColor.HasValue) _values_[0] = ea.oColor.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_CNF_COLOR(System.Int16 oColor, bool ignore_oColor)
    {
      object[] _values_ = new object[1];
      if (!ignore_oColor) _values_[0] = oColor;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_CNF_LEVEL_SP(System.Single LevelSp1, System.Single LevelSp2)
    {
      return ((IHMIAccessorOutput)this).FireEvent(2, new object[] {LevelSp1, LevelSp2});
    }
    public bool FireEvent_CNF_LEVEL_SP(SE.Nereda.Symbols.AnalogInput.CNF_LEVEL_SPEventArgs ea)
    {
      object[] _values_ = new object[2];
      if (ea.LevelSp1.HasValue) _values_[0] = ea.LevelSp1.Value;
      if (ea.LevelSp2.HasValue) _values_[1] = ea.LevelSp2.Value;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_CNF_LEVEL_SP(System.Single LevelSp1, bool ignore_LevelSp1, System.Single LevelSp2, bool ignore_LevelSp2)
    {
      object[] _values_ = new object[2];
      if (!ignore_LevelSp1) _values_[0] = LevelSp1;
      if (!ignore_LevelSp2) _values_[1] = LevelSp2;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_CNF_EN_F_C(System.Boolean EnFlowConversion)
    {
      return ((IHMIAccessorOutput)this).FireEvent(3, new object[] {EnFlowConversion});
    }
    public bool FireEvent_CNF_EN_F_C(SE.Nereda.Symbols.AnalogInput.CNF_EN_F_CEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.EnFlowConversion.HasValue) _values_[0] = ea.EnFlowConversion.Value;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_CNF_EN_F_C(System.Boolean EnFlowConversion, bool ignore_EnFlowConversion)
    {
      object[] _values_ = new object[1];
      if (!ignore_EnFlowConversion) _values_[0] = EnFlowConversion;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }

  }
}

namespace SE.Nereda.Symbols.AnalogInput
{
  partial class sPvBarVer
  {

    private event EventHandler<SE.Nereda.Symbols.AnalogInput.REQ_PVEventArgs> REQ_PV_Fired;

    private event EventHandler<SE.Nereda.Symbols.AnalogInput.REQ_ALM_LIM_SPEventArgs> REQ_ALM_LIM_SP_Fired;

    private event EventHandler<SE.Nereda.Symbols.AnalogInput.REQ_UNITEventArgs> REQ_UNIT_Fired;

    private event EventHandler<SE.Nereda.Symbols.AnalogInput.FB_COLOREventArgs> FB_COLOR_Fired;

    private event EventHandler<SE.Nereda.Symbols.AnalogInput.CH_FAILEventArgs> CH_FAIL_Fired;

    private event EventHandler<SE.Nereda.Symbols.AnalogInput.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    protected override void OnEndInit()
    {
      if (REQ_PV_Fired != null)
        AttachEventInput(0);
      if (REQ_ALM_LIM_SP_Fired != null)
        AttachEventInput(1);
      if (REQ_UNIT_Fired != null)
        AttachEventInput(2);
      if (FB_COLOR_Fired != null)
        AttachEventInput(3);
      if (CH_FAIL_Fired != null)
        AttachEventInput(4);
      if (LOAD_PERS_DATA_Fired != null)
        AttachEventInput(5);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (REQ_PV_Fired != null)
          {
            try
            {
              REQ_PV_Fired(this, new SE.Nereda.Symbols.AnalogInput.REQ_PVEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REQ_PV_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 1:
          if (REQ_ALM_LIM_SP_Fired != null)
          {
            try
            {
              REQ_ALM_LIM_SP_Fired(this, new SE.Nereda.Symbols.AnalogInput.REQ_ALM_LIM_SPEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REQ_ALM_LIM_SP_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 2:
          if (REQ_UNIT_Fired != null)
          {
            try
            {
              REQ_UNIT_Fired(this, new SE.Nereda.Symbols.AnalogInput.REQ_UNITEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REQ_UNIT_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 3:
          if (FB_COLOR_Fired != null)
          {
            try
            {
              FB_COLOR_Fired(this, new SE.Nereda.Symbols.AnalogInput.FB_COLOREventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","FB_COLOR_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 4:
          if (CH_FAIL_Fired != null)
          {
            try
            {
              CH_FAIL_Fired(this, new SE.Nereda.Symbols.AnalogInput.CH_FAILEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","CH_FAIL_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 5:
          if (LOAD_PERS_DATA_Fired != null)
          {
            try
            {
              LOAD_PERS_DATA_Fired(this, new SE.Nereda.Symbols.AnalogInput.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
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
    public bool FireEvent_CNF_UNIT(System.String oUnit, System.Boolean oFlowSensor)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {oUnit, oFlowSensor});
    }
    public bool FireEvent_CNF_UNIT(SE.Nereda.Symbols.AnalogInput.CNF_UNITEventArgs ea)
    {
      object[] _values_ = new object[2];
      if (ea.oUnit != null) _values_[0] = ea.oUnit;
      if (ea.oFlowSensor.HasValue) _values_[1] = ea.oFlowSensor.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_CNF_UNIT(System.String oUnit, bool ignore_oUnit, System.Boolean oFlowSensor, bool ignore_oFlowSensor)
    {
      object[] _values_ = new object[2];
      if (!ignore_oUnit) _values_[0] = oUnit;
      if (!ignore_oFlowSensor) _values_[1] = oFlowSensor;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_CNF_COLOR(System.Int16 oColor)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {oColor});
    }
    public bool FireEvent_CNF_COLOR(SE.Nereda.Symbols.AnalogInput.CNF_COLOREventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.oColor.HasValue) _values_[0] = ea.oColor.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_CNF_COLOR(System.Int16 oColor, bool ignore_oColor)
    {
      object[] _values_ = new object[1];
      if (!ignore_oColor) _values_[0] = oColor;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_CNF_LEVEL_SP(System.Single LevelSp1, System.Single LevelSp2)
    {
      return ((IHMIAccessorOutput)this).FireEvent(2, new object[] {LevelSp1, LevelSp2});
    }
    public bool FireEvent_CNF_LEVEL_SP(SE.Nereda.Symbols.AnalogInput.CNF_LEVEL_SPEventArgs ea)
    {
      object[] _values_ = new object[2];
      if (ea.LevelSp1.HasValue) _values_[0] = ea.LevelSp1.Value;
      if (ea.LevelSp2.HasValue) _values_[1] = ea.LevelSp2.Value;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_CNF_LEVEL_SP(System.Single LevelSp1, bool ignore_LevelSp1, System.Single LevelSp2, bool ignore_LevelSp2)
    {
      object[] _values_ = new object[2];
      if (!ignore_LevelSp1) _values_[0] = LevelSp1;
      if (!ignore_LevelSp2) _values_[1] = LevelSp2;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_CNF_EN_F_C(System.Boolean EnFlowConversion)
    {
      return ((IHMIAccessorOutput)this).FireEvent(3, new object[] {EnFlowConversion});
    }
    public bool FireEvent_CNF_EN_F_C(SE.Nereda.Symbols.AnalogInput.CNF_EN_F_CEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.EnFlowConversion.HasValue) _values_[0] = ea.EnFlowConversion.Value;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_CNF_EN_F_C(System.Boolean EnFlowConversion, bool ignore_EnFlowConversion)
    {
      object[] _values_ = new object[1];
      if (!ignore_EnFlowConversion) _values_[0] = EnFlowConversion;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }

  }
}

namespace SE.Nereda.Symbols.AnalogInput
{
  partial class sDisplayPv3
  {

    private event EventHandler<SE.Nereda.Symbols.AnalogInput.REQ_PVEventArgs> REQ_PV_Fired;

    private event EventHandler<SE.Nereda.Symbols.AnalogInput.REQ_ALM_LIM_SPEventArgs> REQ_ALM_LIM_SP_Fired;

    private event EventHandler<SE.Nereda.Symbols.AnalogInput.REQ_UNITEventArgs> REQ_UNIT_Fired;

    private event EventHandler<SE.Nereda.Symbols.AnalogInput.FB_COLOREventArgs> FB_COLOR_Fired;

    private event EventHandler<SE.Nereda.Symbols.AnalogInput.CH_FAILEventArgs> CH_FAIL_Fired;

    private event EventHandler<SE.Nereda.Symbols.AnalogInput.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    protected override void OnEndInit()
    {
      if (REQ_PV_Fired != null)
        AttachEventInput(0);
      if (REQ_ALM_LIM_SP_Fired != null)
        AttachEventInput(1);
      if (REQ_UNIT_Fired != null)
        AttachEventInput(2);
      if (FB_COLOR_Fired != null)
        AttachEventInput(3);
      if (CH_FAIL_Fired != null)
        AttachEventInput(4);
      if (LOAD_PERS_DATA_Fired != null)
        AttachEventInput(5);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (REQ_PV_Fired != null)
          {
            try
            {
              REQ_PV_Fired(this, new SE.Nereda.Symbols.AnalogInput.REQ_PVEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REQ_PV_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 1:
          if (REQ_ALM_LIM_SP_Fired != null)
          {
            try
            {
              REQ_ALM_LIM_SP_Fired(this, new SE.Nereda.Symbols.AnalogInput.REQ_ALM_LIM_SPEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REQ_ALM_LIM_SP_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 2:
          if (REQ_UNIT_Fired != null)
          {
            try
            {
              REQ_UNIT_Fired(this, new SE.Nereda.Symbols.AnalogInput.REQ_UNITEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REQ_UNIT_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 3:
          if (FB_COLOR_Fired != null)
          {
            try
            {
              FB_COLOR_Fired(this, new SE.Nereda.Symbols.AnalogInput.FB_COLOREventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","FB_COLOR_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 4:
          if (CH_FAIL_Fired != null)
          {
            try
            {
              CH_FAIL_Fired(this, new SE.Nereda.Symbols.AnalogInput.CH_FAILEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","CH_FAIL_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 5:
          if (LOAD_PERS_DATA_Fired != null)
          {
            try
            {
              LOAD_PERS_DATA_Fired(this, new SE.Nereda.Symbols.AnalogInput.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
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
    public bool FireEvent_CNF_UNIT(System.String oUnit, System.Boolean oFlowSensor)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {oUnit, oFlowSensor});
    }
    public bool FireEvent_CNF_UNIT(SE.Nereda.Symbols.AnalogInput.CNF_UNITEventArgs ea)
    {
      object[] _values_ = new object[2];
      if (ea.oUnit != null) _values_[0] = ea.oUnit;
      if (ea.oFlowSensor.HasValue) _values_[1] = ea.oFlowSensor.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_CNF_UNIT(System.String oUnit, bool ignore_oUnit, System.Boolean oFlowSensor, bool ignore_oFlowSensor)
    {
      object[] _values_ = new object[2];
      if (!ignore_oUnit) _values_[0] = oUnit;
      if (!ignore_oFlowSensor) _values_[1] = oFlowSensor;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_CNF_COLOR(System.Int16 oColor)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {oColor});
    }
    public bool FireEvent_CNF_COLOR(SE.Nereda.Symbols.AnalogInput.CNF_COLOREventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.oColor.HasValue) _values_[0] = ea.oColor.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_CNF_COLOR(System.Int16 oColor, bool ignore_oColor)
    {
      object[] _values_ = new object[1];
      if (!ignore_oColor) _values_[0] = oColor;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_CNF_LEVEL_SP(System.Single LevelSp1, System.Single LevelSp2)
    {
      return ((IHMIAccessorOutput)this).FireEvent(2, new object[] {LevelSp1, LevelSp2});
    }
    public bool FireEvent_CNF_LEVEL_SP(SE.Nereda.Symbols.AnalogInput.CNF_LEVEL_SPEventArgs ea)
    {
      object[] _values_ = new object[2];
      if (ea.LevelSp1.HasValue) _values_[0] = ea.LevelSp1.Value;
      if (ea.LevelSp2.HasValue) _values_[1] = ea.LevelSp2.Value;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_CNF_LEVEL_SP(System.Single LevelSp1, bool ignore_LevelSp1, System.Single LevelSp2, bool ignore_LevelSp2)
    {
      object[] _values_ = new object[2];
      if (!ignore_LevelSp1) _values_[0] = LevelSp1;
      if (!ignore_LevelSp2) _values_[1] = LevelSp2;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_CNF_EN_F_C(System.Boolean EnFlowConversion)
    {
      return ((IHMIAccessorOutput)this).FireEvent(3, new object[] {EnFlowConversion});
    }
    public bool FireEvent_CNF_EN_F_C(SE.Nereda.Symbols.AnalogInput.CNF_EN_F_CEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.EnFlowConversion.HasValue) _values_[0] = ea.EnFlowConversion.Value;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_CNF_EN_F_C(System.Boolean EnFlowConversion, bool ignore_EnFlowConversion)
    {
      object[] _values_ = new object[1];
      if (!ignore_EnFlowConversion) _values_[0] = EnFlowConversion;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }

  }
}

namespace SE.Nereda.Symbols.AnalogInput
{
  partial class sHorizontal
  {

    private event EventHandler<SE.Nereda.Symbols.AnalogInput.REQ_PVEventArgs> REQ_PV_Fired;

    private event EventHandler<SE.Nereda.Symbols.AnalogInput.REQ_ALM_LIM_SPEventArgs> REQ_ALM_LIM_SP_Fired;

    private event EventHandler<SE.Nereda.Symbols.AnalogInput.REQ_UNITEventArgs> REQ_UNIT_Fired;

    private event EventHandler<SE.Nereda.Symbols.AnalogInput.FB_COLOREventArgs> FB_COLOR_Fired;

    private event EventHandler<SE.Nereda.Symbols.AnalogInput.CH_FAILEventArgs> CH_FAIL_Fired;

    private event EventHandler<SE.Nereda.Symbols.AnalogInput.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    protected override void OnEndInit()
    {
      if (REQ_PV_Fired != null)
        AttachEventInput(0);
      if (REQ_ALM_LIM_SP_Fired != null)
        AttachEventInput(1);
      if (REQ_UNIT_Fired != null)
        AttachEventInput(2);
      if (FB_COLOR_Fired != null)
        AttachEventInput(3);
      if (CH_FAIL_Fired != null)
        AttachEventInput(4);
      if (LOAD_PERS_DATA_Fired != null)
        AttachEventInput(5);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (REQ_PV_Fired != null)
          {
            try
            {
              REQ_PV_Fired(this, new SE.Nereda.Symbols.AnalogInput.REQ_PVEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REQ_PV_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 1:
          if (REQ_ALM_LIM_SP_Fired != null)
          {
            try
            {
              REQ_ALM_LIM_SP_Fired(this, new SE.Nereda.Symbols.AnalogInput.REQ_ALM_LIM_SPEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REQ_ALM_LIM_SP_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 2:
          if (REQ_UNIT_Fired != null)
          {
            try
            {
              REQ_UNIT_Fired(this, new SE.Nereda.Symbols.AnalogInput.REQ_UNITEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REQ_UNIT_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 3:
          if (FB_COLOR_Fired != null)
          {
            try
            {
              FB_COLOR_Fired(this, new SE.Nereda.Symbols.AnalogInput.FB_COLOREventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","FB_COLOR_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 4:
          if (CH_FAIL_Fired != null)
          {
            try
            {
              CH_FAIL_Fired(this, new SE.Nereda.Symbols.AnalogInput.CH_FAILEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","CH_FAIL_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 5:
          if (LOAD_PERS_DATA_Fired != null)
          {
            try
            {
              LOAD_PERS_DATA_Fired(this, new SE.Nereda.Symbols.AnalogInput.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
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
    public bool FireEvent_CNF_UNIT(System.String oUnit, System.Boolean oFlowSensor)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {oUnit, oFlowSensor});
    }
    public bool FireEvent_CNF_UNIT(SE.Nereda.Symbols.AnalogInput.CNF_UNITEventArgs ea)
    {
      object[] _values_ = new object[2];
      if (ea.oUnit != null) _values_[0] = ea.oUnit;
      if (ea.oFlowSensor.HasValue) _values_[1] = ea.oFlowSensor.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_CNF_UNIT(System.String oUnit, bool ignore_oUnit, System.Boolean oFlowSensor, bool ignore_oFlowSensor)
    {
      object[] _values_ = new object[2];
      if (!ignore_oUnit) _values_[0] = oUnit;
      if (!ignore_oFlowSensor) _values_[1] = oFlowSensor;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_CNF_COLOR(System.Int16 oColor)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {oColor});
    }
    public bool FireEvent_CNF_COLOR(SE.Nereda.Symbols.AnalogInput.CNF_COLOREventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.oColor.HasValue) _values_[0] = ea.oColor.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_CNF_COLOR(System.Int16 oColor, bool ignore_oColor)
    {
      object[] _values_ = new object[1];
      if (!ignore_oColor) _values_[0] = oColor;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_CNF_LEVEL_SP(System.Single LevelSp1, System.Single LevelSp2)
    {
      return ((IHMIAccessorOutput)this).FireEvent(2, new object[] {LevelSp1, LevelSp2});
    }
    public bool FireEvent_CNF_LEVEL_SP(SE.Nereda.Symbols.AnalogInput.CNF_LEVEL_SPEventArgs ea)
    {
      object[] _values_ = new object[2];
      if (ea.LevelSp1.HasValue) _values_[0] = ea.LevelSp1.Value;
      if (ea.LevelSp2.HasValue) _values_[1] = ea.LevelSp2.Value;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_CNF_LEVEL_SP(System.Single LevelSp1, bool ignore_LevelSp1, System.Single LevelSp2, bool ignore_LevelSp2)
    {
      object[] _values_ = new object[2];
      if (!ignore_LevelSp1) _values_[0] = LevelSp1;
      if (!ignore_LevelSp2) _values_[1] = LevelSp2;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_CNF_EN_F_C(System.Boolean EnFlowConversion)
    {
      return ((IHMIAccessorOutput)this).FireEvent(3, new object[] {EnFlowConversion});
    }
    public bool FireEvent_CNF_EN_F_C(SE.Nereda.Symbols.AnalogInput.CNF_EN_F_CEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.EnFlowConversion.HasValue) _values_[0] = ea.EnFlowConversion.Value;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_CNF_EN_F_C(System.Boolean EnFlowConversion, bool ignore_EnFlowConversion)
    {
      object[] _values_ = new object[1];
      if (!ignore_EnFlowConversion) _values_[0] = EnFlowConversion;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }

  }
}

namespace SE.Nereda.Symbols.AnalogInput
{
  partial class sVertical
  {

    private event EventHandler<SE.Nereda.Symbols.AnalogInput.REQ_PVEventArgs> REQ_PV_Fired;

    private event EventHandler<SE.Nereda.Symbols.AnalogInput.REQ_ALM_LIM_SPEventArgs> REQ_ALM_LIM_SP_Fired;

    private event EventHandler<SE.Nereda.Symbols.AnalogInput.REQ_UNITEventArgs> REQ_UNIT_Fired;

    private event EventHandler<SE.Nereda.Symbols.AnalogInput.FB_COLOREventArgs> FB_COLOR_Fired;

    private event EventHandler<SE.Nereda.Symbols.AnalogInput.CH_FAILEventArgs> CH_FAIL_Fired;

    private event EventHandler<SE.Nereda.Symbols.AnalogInput.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    protected override void OnEndInit()
    {
      if (REQ_PV_Fired != null)
        AttachEventInput(0);
      if (REQ_ALM_LIM_SP_Fired != null)
        AttachEventInput(1);
      if (REQ_UNIT_Fired != null)
        AttachEventInput(2);
      if (FB_COLOR_Fired != null)
        AttachEventInput(3);
      if (CH_FAIL_Fired != null)
        AttachEventInput(4);
      if (LOAD_PERS_DATA_Fired != null)
        AttachEventInput(5);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (REQ_PV_Fired != null)
          {
            try
            {
              REQ_PV_Fired(this, new SE.Nereda.Symbols.AnalogInput.REQ_PVEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REQ_PV_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 1:
          if (REQ_ALM_LIM_SP_Fired != null)
          {
            try
            {
              REQ_ALM_LIM_SP_Fired(this, new SE.Nereda.Symbols.AnalogInput.REQ_ALM_LIM_SPEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REQ_ALM_LIM_SP_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 2:
          if (REQ_UNIT_Fired != null)
          {
            try
            {
              REQ_UNIT_Fired(this, new SE.Nereda.Symbols.AnalogInput.REQ_UNITEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REQ_UNIT_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 3:
          if (FB_COLOR_Fired != null)
          {
            try
            {
              FB_COLOR_Fired(this, new SE.Nereda.Symbols.AnalogInput.FB_COLOREventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","FB_COLOR_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 4:
          if (CH_FAIL_Fired != null)
          {
            try
            {
              CH_FAIL_Fired(this, new SE.Nereda.Symbols.AnalogInput.CH_FAILEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","CH_FAIL_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 5:
          if (LOAD_PERS_DATA_Fired != null)
          {
            try
            {
              LOAD_PERS_DATA_Fired(this, new SE.Nereda.Symbols.AnalogInput.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
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
    public bool FireEvent_CNF_UNIT(System.String oUnit, System.Boolean oFlowSensor)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {oUnit, oFlowSensor});
    }
    public bool FireEvent_CNF_UNIT(SE.Nereda.Symbols.AnalogInput.CNF_UNITEventArgs ea)
    {
      object[] _values_ = new object[2];
      if (ea.oUnit != null) _values_[0] = ea.oUnit;
      if (ea.oFlowSensor.HasValue) _values_[1] = ea.oFlowSensor.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_CNF_UNIT(System.String oUnit, bool ignore_oUnit, System.Boolean oFlowSensor, bool ignore_oFlowSensor)
    {
      object[] _values_ = new object[2];
      if (!ignore_oUnit) _values_[0] = oUnit;
      if (!ignore_oFlowSensor) _values_[1] = oFlowSensor;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_CNF_COLOR(System.Int16 oColor)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {oColor});
    }
    public bool FireEvent_CNF_COLOR(SE.Nereda.Symbols.AnalogInput.CNF_COLOREventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.oColor.HasValue) _values_[0] = ea.oColor.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_CNF_COLOR(System.Int16 oColor, bool ignore_oColor)
    {
      object[] _values_ = new object[1];
      if (!ignore_oColor) _values_[0] = oColor;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_CNF_LEVEL_SP(System.Single LevelSp1, System.Single LevelSp2)
    {
      return ((IHMIAccessorOutput)this).FireEvent(2, new object[] {LevelSp1, LevelSp2});
    }
    public bool FireEvent_CNF_LEVEL_SP(SE.Nereda.Symbols.AnalogInput.CNF_LEVEL_SPEventArgs ea)
    {
      object[] _values_ = new object[2];
      if (ea.LevelSp1.HasValue) _values_[0] = ea.LevelSp1.Value;
      if (ea.LevelSp2.HasValue) _values_[1] = ea.LevelSp2.Value;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_CNF_LEVEL_SP(System.Single LevelSp1, bool ignore_LevelSp1, System.Single LevelSp2, bool ignore_LevelSp2)
    {
      object[] _values_ = new object[2];
      if (!ignore_LevelSp1) _values_[0] = LevelSp1;
      if (!ignore_LevelSp2) _values_[1] = LevelSp2;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_CNF_EN_F_C(System.Boolean EnFlowConversion)
    {
      return ((IHMIAccessorOutput)this).FireEvent(3, new object[] {EnFlowConversion});
    }
    public bool FireEvent_CNF_EN_F_C(SE.Nereda.Symbols.AnalogInput.CNF_EN_F_CEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.EnFlowConversion.HasValue) _values_[0] = ea.EnFlowConversion.Value;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_CNF_EN_F_C(System.Boolean EnFlowConversion, bool ignore_EnFlowConversion)
    {
      object[] _values_ = new object[1];
      if (!ignore_EnFlowConversion) _values_[0] = EnFlowConversion;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }

  }
}

namespace SE.Nereda.Faceplates.AnalogInput
{
  partial class fpColor
  {

    private event EventHandler<SE.Nereda.Symbols.AnalogInput.REQ_PVEventArgs> REQ_PV_Fired;

    private event EventHandler<SE.Nereda.Symbols.AnalogInput.REQ_ALM_LIM_SPEventArgs> REQ_ALM_LIM_SP_Fired;

    private event EventHandler<SE.Nereda.Symbols.AnalogInput.REQ_UNITEventArgs> REQ_UNIT_Fired;

    private event EventHandler<SE.Nereda.Symbols.AnalogInput.FB_COLOREventArgs> FB_COLOR_Fired;

    private event EventHandler<SE.Nereda.Symbols.AnalogInput.CH_FAILEventArgs> CH_FAIL_Fired;

    private event EventHandler<SE.Nereda.Symbols.AnalogInput.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    protected override void OnEndInit()
    {
      if (REQ_PV_Fired != null)
        AttachEventInput(0);
      if (REQ_ALM_LIM_SP_Fired != null)
        AttachEventInput(1);
      if (REQ_UNIT_Fired != null)
        AttachEventInput(2);
      if (FB_COLOR_Fired != null)
        AttachEventInput(3);
      if (CH_FAIL_Fired != null)
        AttachEventInput(4);
      if (LOAD_PERS_DATA_Fired != null)
        AttachEventInput(5);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (REQ_PV_Fired != null)
          {
            try
            {
              REQ_PV_Fired(this, new SE.Nereda.Symbols.AnalogInput.REQ_PVEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REQ_PV_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 1:
          if (REQ_ALM_LIM_SP_Fired != null)
          {
            try
            {
              REQ_ALM_LIM_SP_Fired(this, new SE.Nereda.Symbols.AnalogInput.REQ_ALM_LIM_SPEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REQ_ALM_LIM_SP_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 2:
          if (REQ_UNIT_Fired != null)
          {
            try
            {
              REQ_UNIT_Fired(this, new SE.Nereda.Symbols.AnalogInput.REQ_UNITEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REQ_UNIT_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 3:
          if (FB_COLOR_Fired != null)
          {
            try
            {
              FB_COLOR_Fired(this, new SE.Nereda.Symbols.AnalogInput.FB_COLOREventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","FB_COLOR_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 4:
          if (CH_FAIL_Fired != null)
          {
            try
            {
              CH_FAIL_Fired(this, new SE.Nereda.Symbols.AnalogInput.CH_FAILEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","CH_FAIL_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 5:
          if (LOAD_PERS_DATA_Fired != null)
          {
            try
            {
              LOAD_PERS_DATA_Fired(this, new SE.Nereda.Symbols.AnalogInput.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
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
    public bool FireEvent_CNF_UNIT(System.String oUnit, System.Boolean oFlowSensor)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {oUnit, oFlowSensor});
    }
    public bool FireEvent_CNF_UNIT(SE.Nereda.Symbols.AnalogInput.CNF_UNITEventArgs ea)
    {
      object[] _values_ = new object[2];
      if (ea.oUnit != null) _values_[0] = ea.oUnit;
      if (ea.oFlowSensor.HasValue) _values_[1] = ea.oFlowSensor.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_CNF_UNIT(System.String oUnit, bool ignore_oUnit, System.Boolean oFlowSensor, bool ignore_oFlowSensor)
    {
      object[] _values_ = new object[2];
      if (!ignore_oUnit) _values_[0] = oUnit;
      if (!ignore_oFlowSensor) _values_[1] = oFlowSensor;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_CNF_COLOR(System.Int16 oColor)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {oColor});
    }
    public bool FireEvent_CNF_COLOR(SE.Nereda.Symbols.AnalogInput.CNF_COLOREventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.oColor.HasValue) _values_[0] = ea.oColor.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_CNF_COLOR(System.Int16 oColor, bool ignore_oColor)
    {
      object[] _values_ = new object[1];
      if (!ignore_oColor) _values_[0] = oColor;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_CNF_LEVEL_SP(System.Single LevelSp1, System.Single LevelSp2)
    {
      return ((IHMIAccessorOutput)this).FireEvent(2, new object[] {LevelSp1, LevelSp2});
    }
    public bool FireEvent_CNF_LEVEL_SP(SE.Nereda.Symbols.AnalogInput.CNF_LEVEL_SPEventArgs ea)
    {
      object[] _values_ = new object[2];
      if (ea.LevelSp1.HasValue) _values_[0] = ea.LevelSp1.Value;
      if (ea.LevelSp2.HasValue) _values_[1] = ea.LevelSp2.Value;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_CNF_LEVEL_SP(System.Single LevelSp1, bool ignore_LevelSp1, System.Single LevelSp2, bool ignore_LevelSp2)
    {
      object[] _values_ = new object[2];
      if (!ignore_LevelSp1) _values_[0] = LevelSp1;
      if (!ignore_LevelSp2) _values_[1] = LevelSp2;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_CNF_EN_F_C(System.Boolean EnFlowConversion)
    {
      return ((IHMIAccessorOutput)this).FireEvent(3, new object[] {EnFlowConversion});
    }
    public bool FireEvent_CNF_EN_F_C(SE.Nereda.Symbols.AnalogInput.CNF_EN_F_CEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.EnFlowConversion.HasValue) _values_[0] = ea.EnFlowConversion.Value;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_CNF_EN_F_C(System.Boolean EnFlowConversion, bool ignore_EnFlowConversion)
    {
      object[] _values_ = new object[1];
      if (!ignore_EnFlowConversion) _values_[0] = EnFlowConversion;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }

  }
}

namespace SE.Nereda.Symbols.AnalogInput
{
  partial class sL1L2
  {

    private event EventHandler<SE.Nereda.Symbols.AnalogInput.REQ_PVEventArgs> REQ_PV_Fired;

    private event EventHandler<SE.Nereda.Symbols.AnalogInput.REQ_ALM_LIM_SPEventArgs> REQ_ALM_LIM_SP_Fired;

    private event EventHandler<SE.Nereda.Symbols.AnalogInput.REQ_UNITEventArgs> REQ_UNIT_Fired;

    private event EventHandler<SE.Nereda.Symbols.AnalogInput.FB_COLOREventArgs> FB_COLOR_Fired;

    private event EventHandler<SE.Nereda.Symbols.AnalogInput.CH_FAILEventArgs> CH_FAIL_Fired;

    private event EventHandler<SE.Nereda.Symbols.AnalogInput.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    protected override void OnEndInit()
    {
      if (REQ_PV_Fired != null)
        AttachEventInput(0);
      if (REQ_ALM_LIM_SP_Fired != null)
        AttachEventInput(1);
      if (REQ_UNIT_Fired != null)
        AttachEventInput(2);
      if (FB_COLOR_Fired != null)
        AttachEventInput(3);
      if (CH_FAIL_Fired != null)
        AttachEventInput(4);
      if (LOAD_PERS_DATA_Fired != null)
        AttachEventInput(5);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (REQ_PV_Fired != null)
          {
            try
            {
              REQ_PV_Fired(this, new SE.Nereda.Symbols.AnalogInput.REQ_PVEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REQ_PV_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 1:
          if (REQ_ALM_LIM_SP_Fired != null)
          {
            try
            {
              REQ_ALM_LIM_SP_Fired(this, new SE.Nereda.Symbols.AnalogInput.REQ_ALM_LIM_SPEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REQ_ALM_LIM_SP_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 2:
          if (REQ_UNIT_Fired != null)
          {
            try
            {
              REQ_UNIT_Fired(this, new SE.Nereda.Symbols.AnalogInput.REQ_UNITEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REQ_UNIT_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 3:
          if (FB_COLOR_Fired != null)
          {
            try
            {
              FB_COLOR_Fired(this, new SE.Nereda.Symbols.AnalogInput.FB_COLOREventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","FB_COLOR_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 4:
          if (CH_FAIL_Fired != null)
          {
            try
            {
              CH_FAIL_Fired(this, new SE.Nereda.Symbols.AnalogInput.CH_FAILEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","CH_FAIL_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 5:
          if (LOAD_PERS_DATA_Fired != null)
          {
            try
            {
              LOAD_PERS_DATA_Fired(this, new SE.Nereda.Symbols.AnalogInput.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
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
    public bool FireEvent_CNF_UNIT(System.String oUnit, System.Boolean oFlowSensor)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {oUnit, oFlowSensor});
    }
    public bool FireEvent_CNF_UNIT(SE.Nereda.Symbols.AnalogInput.CNF_UNITEventArgs ea)
    {
      object[] _values_ = new object[2];
      if (ea.oUnit != null) _values_[0] = ea.oUnit;
      if (ea.oFlowSensor.HasValue) _values_[1] = ea.oFlowSensor.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_CNF_UNIT(System.String oUnit, bool ignore_oUnit, System.Boolean oFlowSensor, bool ignore_oFlowSensor)
    {
      object[] _values_ = new object[2];
      if (!ignore_oUnit) _values_[0] = oUnit;
      if (!ignore_oFlowSensor) _values_[1] = oFlowSensor;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_CNF_COLOR(System.Int16 oColor)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {oColor});
    }
    public bool FireEvent_CNF_COLOR(SE.Nereda.Symbols.AnalogInput.CNF_COLOREventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.oColor.HasValue) _values_[0] = ea.oColor.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_CNF_COLOR(System.Int16 oColor, bool ignore_oColor)
    {
      object[] _values_ = new object[1];
      if (!ignore_oColor) _values_[0] = oColor;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_CNF_LEVEL_SP(System.Single LevelSp1, System.Single LevelSp2)
    {
      return ((IHMIAccessorOutput)this).FireEvent(2, new object[] {LevelSp1, LevelSp2});
    }
    public bool FireEvent_CNF_LEVEL_SP(SE.Nereda.Symbols.AnalogInput.CNF_LEVEL_SPEventArgs ea)
    {
      object[] _values_ = new object[2];
      if (ea.LevelSp1.HasValue) _values_[0] = ea.LevelSp1.Value;
      if (ea.LevelSp2.HasValue) _values_[1] = ea.LevelSp2.Value;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_CNF_LEVEL_SP(System.Single LevelSp1, bool ignore_LevelSp1, System.Single LevelSp2, bool ignore_LevelSp2)
    {
      object[] _values_ = new object[2];
      if (!ignore_LevelSp1) _values_[0] = LevelSp1;
      if (!ignore_LevelSp2) _values_[1] = LevelSp2;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_CNF_EN_F_C(System.Boolean EnFlowConversion)
    {
      return ((IHMIAccessorOutput)this).FireEvent(3, new object[] {EnFlowConversion});
    }
    public bool FireEvent_CNF_EN_F_C(SE.Nereda.Symbols.AnalogInput.CNF_EN_F_CEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.EnFlowConversion.HasValue) _values_[0] = ea.EnFlowConversion.Value;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_CNF_EN_F_C(System.Boolean EnFlowConversion, bool ignore_EnFlowConversion)
    {
      object[] _values_ = new object[1];
      if (!ignore_EnFlowConversion) _values_[0] = EnFlowConversion;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }

  }
}

namespace SE.Nereda.Symbols.AnalogInput
{
  partial class sShowLevel
  {

    private event EventHandler<SE.Nereda.Symbols.AnalogInput.REQ_PVEventArgs> REQ_PV_Fired;

    private event EventHandler<SE.Nereda.Symbols.AnalogInput.REQ_ALM_LIM_SPEventArgs> REQ_ALM_LIM_SP_Fired;

    private event EventHandler<SE.Nereda.Symbols.AnalogInput.REQ_UNITEventArgs> REQ_UNIT_Fired;

    private event EventHandler<SE.Nereda.Symbols.AnalogInput.FB_COLOREventArgs> FB_COLOR_Fired;

    private event EventHandler<SE.Nereda.Symbols.AnalogInput.CH_FAILEventArgs> CH_FAIL_Fired;

    private event EventHandler<SE.Nereda.Symbols.AnalogInput.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    protected override void OnEndInit()
    {
      if (REQ_PV_Fired != null)
        AttachEventInput(0);
      if (REQ_ALM_LIM_SP_Fired != null)
        AttachEventInput(1);
      if (REQ_UNIT_Fired != null)
        AttachEventInput(2);
      if (FB_COLOR_Fired != null)
        AttachEventInput(3);
      if (CH_FAIL_Fired != null)
        AttachEventInput(4);
      if (LOAD_PERS_DATA_Fired != null)
        AttachEventInput(5);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (REQ_PV_Fired != null)
          {
            try
            {
              REQ_PV_Fired(this, new SE.Nereda.Symbols.AnalogInput.REQ_PVEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REQ_PV_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 1:
          if (REQ_ALM_LIM_SP_Fired != null)
          {
            try
            {
              REQ_ALM_LIM_SP_Fired(this, new SE.Nereda.Symbols.AnalogInput.REQ_ALM_LIM_SPEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REQ_ALM_LIM_SP_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 2:
          if (REQ_UNIT_Fired != null)
          {
            try
            {
              REQ_UNIT_Fired(this, new SE.Nereda.Symbols.AnalogInput.REQ_UNITEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REQ_UNIT_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 3:
          if (FB_COLOR_Fired != null)
          {
            try
            {
              FB_COLOR_Fired(this, new SE.Nereda.Symbols.AnalogInput.FB_COLOREventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","FB_COLOR_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 4:
          if (CH_FAIL_Fired != null)
          {
            try
            {
              CH_FAIL_Fired(this, new SE.Nereda.Symbols.AnalogInput.CH_FAILEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","CH_FAIL_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 5:
          if (LOAD_PERS_DATA_Fired != null)
          {
            try
            {
              LOAD_PERS_DATA_Fired(this, new SE.Nereda.Symbols.AnalogInput.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
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
    public bool FireEvent_CNF_UNIT(System.String oUnit, System.Boolean oFlowSensor)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {oUnit, oFlowSensor});
    }
    public bool FireEvent_CNF_UNIT(SE.Nereda.Symbols.AnalogInput.CNF_UNITEventArgs ea)
    {
      object[] _values_ = new object[2];
      if (ea.oUnit != null) _values_[0] = ea.oUnit;
      if (ea.oFlowSensor.HasValue) _values_[1] = ea.oFlowSensor.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_CNF_UNIT(System.String oUnit, bool ignore_oUnit, System.Boolean oFlowSensor, bool ignore_oFlowSensor)
    {
      object[] _values_ = new object[2];
      if (!ignore_oUnit) _values_[0] = oUnit;
      if (!ignore_oFlowSensor) _values_[1] = oFlowSensor;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_CNF_COLOR(System.Int16 oColor)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {oColor});
    }
    public bool FireEvent_CNF_COLOR(SE.Nereda.Symbols.AnalogInput.CNF_COLOREventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.oColor.HasValue) _values_[0] = ea.oColor.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_CNF_COLOR(System.Int16 oColor, bool ignore_oColor)
    {
      object[] _values_ = new object[1];
      if (!ignore_oColor) _values_[0] = oColor;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_CNF_LEVEL_SP(System.Single LevelSp1, System.Single LevelSp2)
    {
      return ((IHMIAccessorOutput)this).FireEvent(2, new object[] {LevelSp1, LevelSp2});
    }
    public bool FireEvent_CNF_LEVEL_SP(SE.Nereda.Symbols.AnalogInput.CNF_LEVEL_SPEventArgs ea)
    {
      object[] _values_ = new object[2];
      if (ea.LevelSp1.HasValue) _values_[0] = ea.LevelSp1.Value;
      if (ea.LevelSp2.HasValue) _values_[1] = ea.LevelSp2.Value;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_CNF_LEVEL_SP(System.Single LevelSp1, bool ignore_LevelSp1, System.Single LevelSp2, bool ignore_LevelSp2)
    {
      object[] _values_ = new object[2];
      if (!ignore_LevelSp1) _values_[0] = LevelSp1;
      if (!ignore_LevelSp2) _values_[1] = LevelSp2;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_CNF_EN_F_C(System.Boolean EnFlowConversion)
    {
      return ((IHMIAccessorOutput)this).FireEvent(3, new object[] {EnFlowConversion});
    }
    public bool FireEvent_CNF_EN_F_C(SE.Nereda.Symbols.AnalogInput.CNF_EN_F_CEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.EnFlowConversion.HasValue) _values_[0] = ea.EnFlowConversion.Value;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_CNF_EN_F_C(System.Boolean EnFlowConversion, bool ignore_EnFlowConversion)
    {
      object[] _values_ = new object[1];
      if (!ignore_EnFlowConversion) _values_[0] = EnFlowConversion;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }

  }
}

namespace SE.Nereda.Symbols.AnalogInput
{
  partial class sDisplayPv4
  {

    private event EventHandler<SE.Nereda.Symbols.AnalogInput.REQ_PVEventArgs> REQ_PV_Fired;

    private event EventHandler<SE.Nereda.Symbols.AnalogInput.REQ_ALM_LIM_SPEventArgs> REQ_ALM_LIM_SP_Fired;

    private event EventHandler<SE.Nereda.Symbols.AnalogInput.REQ_UNITEventArgs> REQ_UNIT_Fired;

    private event EventHandler<SE.Nereda.Symbols.AnalogInput.FB_COLOREventArgs> FB_COLOR_Fired;

    private event EventHandler<SE.Nereda.Symbols.AnalogInput.CH_FAILEventArgs> CH_FAIL_Fired;

    private event EventHandler<SE.Nereda.Symbols.AnalogInput.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    protected override void OnEndInit()
    {
      if (REQ_PV_Fired != null)
        AttachEventInput(0);
      if (REQ_ALM_LIM_SP_Fired != null)
        AttachEventInput(1);
      if (REQ_UNIT_Fired != null)
        AttachEventInput(2);
      if (FB_COLOR_Fired != null)
        AttachEventInput(3);
      if (CH_FAIL_Fired != null)
        AttachEventInput(4);
      if (LOAD_PERS_DATA_Fired != null)
        AttachEventInput(5);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (REQ_PV_Fired != null)
          {
            try
            {
              REQ_PV_Fired(this, new SE.Nereda.Symbols.AnalogInput.REQ_PVEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REQ_PV_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 1:
          if (REQ_ALM_LIM_SP_Fired != null)
          {
            try
            {
              REQ_ALM_LIM_SP_Fired(this, new SE.Nereda.Symbols.AnalogInput.REQ_ALM_LIM_SPEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REQ_ALM_LIM_SP_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 2:
          if (REQ_UNIT_Fired != null)
          {
            try
            {
              REQ_UNIT_Fired(this, new SE.Nereda.Symbols.AnalogInput.REQ_UNITEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REQ_UNIT_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 3:
          if (FB_COLOR_Fired != null)
          {
            try
            {
              FB_COLOR_Fired(this, new SE.Nereda.Symbols.AnalogInput.FB_COLOREventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","FB_COLOR_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 4:
          if (CH_FAIL_Fired != null)
          {
            try
            {
              CH_FAIL_Fired(this, new SE.Nereda.Symbols.AnalogInput.CH_FAILEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","CH_FAIL_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 5:
          if (LOAD_PERS_DATA_Fired != null)
          {
            try
            {
              LOAD_PERS_DATA_Fired(this, new SE.Nereda.Symbols.AnalogInput.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
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
    public bool FireEvent_CNF_UNIT(System.String oUnit, System.Boolean oFlowSensor)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {oUnit, oFlowSensor});
    }
    public bool FireEvent_CNF_UNIT(SE.Nereda.Symbols.AnalogInput.CNF_UNITEventArgs ea)
    {
      object[] _values_ = new object[2];
      if (ea.oUnit != null) _values_[0] = ea.oUnit;
      if (ea.oFlowSensor.HasValue) _values_[1] = ea.oFlowSensor.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_CNF_UNIT(System.String oUnit, bool ignore_oUnit, System.Boolean oFlowSensor, bool ignore_oFlowSensor)
    {
      object[] _values_ = new object[2];
      if (!ignore_oUnit) _values_[0] = oUnit;
      if (!ignore_oFlowSensor) _values_[1] = oFlowSensor;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_CNF_COLOR(System.Int16 oColor)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {oColor});
    }
    public bool FireEvent_CNF_COLOR(SE.Nereda.Symbols.AnalogInput.CNF_COLOREventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.oColor.HasValue) _values_[0] = ea.oColor.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_CNF_COLOR(System.Int16 oColor, bool ignore_oColor)
    {
      object[] _values_ = new object[1];
      if (!ignore_oColor) _values_[0] = oColor;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_CNF_LEVEL_SP(System.Single LevelSp1, System.Single LevelSp2)
    {
      return ((IHMIAccessorOutput)this).FireEvent(2, new object[] {LevelSp1, LevelSp2});
    }
    public bool FireEvent_CNF_LEVEL_SP(SE.Nereda.Symbols.AnalogInput.CNF_LEVEL_SPEventArgs ea)
    {
      object[] _values_ = new object[2];
      if (ea.LevelSp1.HasValue) _values_[0] = ea.LevelSp1.Value;
      if (ea.LevelSp2.HasValue) _values_[1] = ea.LevelSp2.Value;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_CNF_LEVEL_SP(System.Single LevelSp1, bool ignore_LevelSp1, System.Single LevelSp2, bool ignore_LevelSp2)
    {
      object[] _values_ = new object[2];
      if (!ignore_LevelSp1) _values_[0] = LevelSp1;
      if (!ignore_LevelSp2) _values_[1] = LevelSp2;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_CNF_EN_F_C(System.Boolean EnFlowConversion)
    {
      return ((IHMIAccessorOutput)this).FireEvent(3, new object[] {EnFlowConversion});
    }
    public bool FireEvent_CNF_EN_F_C(SE.Nereda.Symbols.AnalogInput.CNF_EN_F_CEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.EnFlowConversion.HasValue) _values_[0] = ea.EnFlowConversion.Value;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_CNF_EN_F_C(System.Boolean EnFlowConversion, bool ignore_EnFlowConversion)
    {
      object[] _values_ = new object[1];
      if (!ignore_EnFlowConversion) _values_[0] = EnFlowConversion;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }

  }
}
#endregion #AnalogInput_HMI;

#endregion Definitions;
