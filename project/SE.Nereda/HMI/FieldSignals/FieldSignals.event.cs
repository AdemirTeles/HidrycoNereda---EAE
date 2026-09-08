/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 3/5/2026
 * Time: 9:16 AM
 * 
 */
using System;
using NxtControl.GuiFramework;
using NxtControl.Services;

#region Definitions;
#region #FieldSignals_HMI;

namespace SE.Nereda.Symbols.FieldSignals
{

  public class REQ_STATEEventArgs : System.EventArgs
  {
    IHMIAccessorService accessorService;
    int channelId;
    int cookie; 
    int eventIndex;

    public REQ_STATEEventArgs(int channelId, int cookie, int eventIndex)
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

    public bool Get_SafetySwitchOff(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,1, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? SafetySwitchOff
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,1, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_FrequencyInverterFail(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,2, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? FrequencyInverterFail
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,2, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_AtvEta(ref System.UInt16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,3, ref var);
      if (ret) value = (System.UInt16) var;
      return ret;
    }

    public System.UInt16? AtvEta
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,3, ref var);
      if (!ret) return null;
      return (System.UInt16) var;
    }  }

    public bool Get_RemoteSelect(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,4, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? RemoteSelect
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,4, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_AutoSelect(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,5, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? AutoSelect
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,5, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_PowerFb(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,6, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? PowerFb
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,6, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_AtvReady(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,7, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? AtvReady
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,7, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_Frequency(ref System.Single value)
    {
      if (accessorService == null)
        return false;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,8, ref var);
      if (ret) value = (System.Single) var;
      return ret;
    }

    public System.Single? Frequency
    { get {
      if (accessorService == null)
        return null;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,8, ref var);
      if (!ret) return null;
      return (System.Single) var;
    }  }

    public bool Get_PowerKW(ref System.Single value)
    {
      if (accessorService == null)
        return false;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,9, ref var);
      if (ret) value = (System.Single) var;
      return ret;
    }

    public System.Single? PowerKW
    { get {
      if (accessorService == null)
        return null;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,9, ref var);
      if (!ret) return null;
      return (System.Single) var;
    }  }


  }

  public class REQ_NAMEEventArgs : System.EventArgs
  {
    IHMIAccessorService accessorService;
    int channelId;
    int cookie; 
    int eventIndex;

    public REQ_NAMEEventArgs(int channelId, int cookie, int eventIndex)
    {
      this.accessorService = (IHMIAccessorService)ServiceProvider.GetService(typeof(IHMIAccessorService));
      this.channelId = channelId;
      this.cookie = cookie;
      this.eventIndex = eventIndex;
    }
    public bool Get_Name(ref System.String value)
    {
      if (accessorService == null)
        return false;
      string var = null;
      bool ret = accessorService.GetStringValue(channelId, cookie, eventIndex, true,0, ref var);
      if (ret) value = (System.String) var;
      return ret;
    }

    public System.String Name
    { get {
      if (accessorService == null)
        return null;
      string var = null;
      bool ret = accessorService.GetStringValue(channelId, cookie, eventIndex, true,0, ref var);
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

namespace SE.Nereda.Symbols.FieldSignals
{

  public class CNF_ELEC_CIRC_FAILEventArgs : System.EventArgs
  {
    public CNF_ELEC_CIRC_FAILEventArgs()
    {
    }
    private System.Boolean? OverrideV_ElectricCircuitFail_field = null;
    public System.Boolean? OverrideV_ElectricCircuitFail
    {
       get { return OverrideV_ElectricCircuitFail_field; }
       set { OverrideV_ElectricCircuitFail_field = value; }
    }
    private System.Boolean? EnOverride_ElectricCircuitFail_field = null;
    public System.Boolean? EnOverride_ElectricCircuitFail
    {
       get { return EnOverride_ElectricCircuitFail_field; }
       set { EnOverride_ElectricCircuitFail_field = value; }
    }

  }

  public class CNF_SAF_SWEventArgs : System.EventArgs
  {
    public CNF_SAF_SWEventArgs()
    {
    }
    private System.Boolean? OverrideV_SafetySwitchOff_field = null;
    public System.Boolean? OverrideV_SafetySwitchOff
    {
       get { return OverrideV_SafetySwitchOff_field; }
       set { OverrideV_SafetySwitchOff_field = value; }
    }
    private System.Boolean? EnOverride_SafetySwitchOff_field = null;
    public System.Boolean? EnOverride_SafetySwitchOff
    {
       get { return EnOverride_SafetySwitchOff_field; }
       set { EnOverride_SafetySwitchOff_field = value; }
    }

  }

  public class CNF_FREQ_INV_FAILEventArgs : System.EventArgs
  {
    public CNF_FREQ_INV_FAILEventArgs()
    {
    }
    private System.Boolean? OverrideV_FrequencyInverterFail_field = null;
    public System.Boolean? OverrideV_FrequencyInverterFail
    {
       get { return OverrideV_FrequencyInverterFail_field; }
       set { OverrideV_FrequencyInverterFail_field = value; }
    }
    private System.Boolean? EnOverride_FrequencyInverterFail_field = null;
    public System.Boolean? EnOverride_FrequencyInverterFail
    {
       get { return EnOverride_FrequencyInverterFail_field; }
       set { EnOverride_FrequencyInverterFail_field = value; }
    }

  }

  public class CNF_ETA_ATVEventArgs : System.EventArgs
  {
    public CNF_ETA_ATVEventArgs()
    {
    }
    private System.UInt16? OverrideV_AtvEta_field = null;
    public System.UInt16? OverrideV_AtvEta
    {
       get { return OverrideV_AtvEta_field; }
       set { OverrideV_AtvEta_field = value; }
    }
    private System.Boolean? EnOverride_AtvEta_field = null;
    public System.Boolean? EnOverride_AtvEta
    {
       get { return EnOverride_AtvEta_field; }
       set { EnOverride_AtvEta_field = value; }
    }

  }

  public class CNF_REMOTEEventArgs : System.EventArgs
  {
    public CNF_REMOTEEventArgs()
    {
    }
    private System.Boolean? OverrideV_RemoteSelect_field = null;
    public System.Boolean? OverrideV_RemoteSelect
    {
       get { return OverrideV_RemoteSelect_field; }
       set { OverrideV_RemoteSelect_field = value; }
    }
    private System.Boolean? EnOverride_RemoteSelect_field = null;
    public System.Boolean? EnOverride_RemoteSelect
    {
       get { return EnOverride_RemoteSelect_field; }
       set { EnOverride_RemoteSelect_field = value; }
    }

  }

  public class CNF_AUTOEventArgs : System.EventArgs
  {
    public CNF_AUTOEventArgs()
    {
    }
    private System.Boolean? OverrideV_AutoSelect_field = null;
    public System.Boolean? OverrideV_AutoSelect
    {
       get { return OverrideV_AutoSelect_field; }
       set { OverrideV_AutoSelect_field = value; }
    }
    private System.Boolean? EnOverride_AutoSelect_field = null;
    public System.Boolean? EnOverride_AutoSelect
    {
       get { return EnOverride_AutoSelect_field; }
       set { EnOverride_AutoSelect_field = value; }
    }

  }

  public class CNF_POWEREventArgs : System.EventArgs
  {
    public CNF_POWEREventArgs()
    {
    }
    private System.Boolean? OverrideV_PowerFb_field = null;
    public System.Boolean? OverrideV_PowerFb
    {
       get { return OverrideV_PowerFb_field; }
       set { OverrideV_PowerFb_field = value; }
    }
    private System.Boolean? EnOverride_PowerFb_field = null;
    public System.Boolean? EnOverride_PowerFb
    {
       get { return EnOverride_PowerFb_field; }
       set { EnOverride_PowerFb_field = value; }
    }

  }

  public class CNF_ATV_RDYEventArgs : System.EventArgs
  {
    public CNF_ATV_RDYEventArgs()
    {
    }
    private System.Boolean? OverrideV_AtvReady_field = null;
    public System.Boolean? OverrideV_AtvReady
    {
       get { return OverrideV_AtvReady_field; }
       set { OverrideV_AtvReady_field = value; }
    }
    private System.Boolean? EnOverride_AtvReady_field = null;
    public System.Boolean? EnOverride_AtvReady
    {
       get { return EnOverride_AtvReady_field; }
       set { EnOverride_AtvReady_field = value; }
    }

  }

  public class CNF_TRIPEventArgs : System.EventArgs
  {
    public CNF_TRIPEventArgs()
    {
    }
    private System.Boolean? EnOverride_Trip_field = null;
    public System.Boolean? EnOverride_Trip
    {
       get { return EnOverride_Trip_field; }
       set { EnOverride_Trip_field = value; }
    }
    private System.Boolean? OverrideV_Trip_field = null;
    public System.Boolean? OverrideV_Trip
    {
       get { return OverrideV_Trip_field; }
       set { OverrideV_Trip_field = value; }
    }

  }

  public class CNF_MDPMSEventArgs : System.EventArgs
  {
    public CNF_MDPMSEventArgs()
    {
    }
    private System.Boolean? EnOverride_MDPMS_field = null;
    public System.Boolean? EnOverride_MDPMS
    {
       get { return EnOverride_MDPMS_field; }
       set { EnOverride_MDPMS_field = value; }
    }
    private System.Boolean? OverrideV_MDPMS_field = null;
    public System.Boolean? OverrideV_MDPMS
    {
       get { return OverrideV_MDPMS_field; }
       set { OverrideV_MDPMS_field = value; }
    }

  }

  public class CNF_VALUESEventArgs : System.EventArgs
  {
    public CNF_VALUESEventArgs()
    {
    }
    private System.Boolean? OverrideV_ElectricCircuitFail_field = null;
    public System.Boolean? OverrideV_ElectricCircuitFail
    {
       get { return OverrideV_ElectricCircuitFail_field; }
       set { OverrideV_ElectricCircuitFail_field = value; }
    }
    private System.Boolean? OverrideV_SafetySwitchOff_field = null;
    public System.Boolean? OverrideV_SafetySwitchOff
    {
       get { return OverrideV_SafetySwitchOff_field; }
       set { OverrideV_SafetySwitchOff_field = value; }
    }
    private System.Boolean? OverrideV_FrequencyInverterFail_field = null;
    public System.Boolean? OverrideV_FrequencyInverterFail
    {
       get { return OverrideV_FrequencyInverterFail_field; }
       set { OverrideV_FrequencyInverterFail_field = value; }
    }
    private System.Boolean? OverrideV_RemoteSelect_field = null;
    public System.Boolean? OverrideV_RemoteSelect
    {
       get { return OverrideV_RemoteSelect_field; }
       set { OverrideV_RemoteSelect_field = value; }
    }
    private System.Boolean? OverrideV_AutoSelect_field = null;
    public System.Boolean? OverrideV_AutoSelect
    {
       get { return OverrideV_AutoSelect_field; }
       set { OverrideV_AutoSelect_field = value; }
    }
    private System.Boolean? OverrideV_PowerFb_field = null;
    public System.Boolean? OverrideV_PowerFb
    {
       get { return OverrideV_PowerFb_field; }
       set { OverrideV_PowerFb_field = value; }
    }
    private System.Boolean? OverrideV_AtvReady_field = null;
    public System.Boolean? OverrideV_AtvReady
    {
       get { return OverrideV_AtvReady_field; }
       set { OverrideV_AtvReady_field = value; }
    }

  }

}

namespace SE.Nereda.Symbols.FieldSignals
{
  partial class sDefault
  {

    private event EventHandler<SE.Nereda.Symbols.FieldSignals.REQ_STATEEventArgs> REQ_STATE_Fired;

    private event EventHandler<SE.Nereda.Symbols.FieldSignals.REQ_NAMEEventArgs> REQ_NAME_Fired;

    private event EventHandler<SE.Nereda.Symbols.FieldSignals.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    protected override void OnEndInit()
    {
      if (REQ_STATE_Fired != null)
        AttachEventInput(0);
      if (REQ_NAME_Fired != null)
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
          if (REQ_STATE_Fired != null)
          {
            try
            {
              REQ_STATE_Fired(this, new SE.Nereda.Symbols.FieldSignals.REQ_STATEEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REQ_STATE_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 1:
          if (REQ_NAME_Fired != null)
          {
            try
            {
              REQ_NAME_Fired(this, new SE.Nereda.Symbols.FieldSignals.REQ_NAMEEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REQ_NAME_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 2:
          if (LOAD_PERS_DATA_Fired != null)
          {
            try
            {
              LOAD_PERS_DATA_Fired(this, new SE.Nereda.Symbols.FieldSignals.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
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
    public bool FireEvent_CNF_ELEC_CIRC_FAIL(System.Boolean OverrideV_ElectricCircuitFail, System.Boolean EnOverride_ElectricCircuitFail)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {OverrideV_ElectricCircuitFail, EnOverride_ElectricCircuitFail});
    }
    public bool FireEvent_CNF_ELEC_CIRC_FAIL(SE.Nereda.Symbols.FieldSignals.CNF_ELEC_CIRC_FAILEventArgs ea)
    {
      object[] _values_ = new object[2];
      if (ea.OverrideV_ElectricCircuitFail.HasValue) _values_[0] = ea.OverrideV_ElectricCircuitFail.Value;
      if (ea.EnOverride_ElectricCircuitFail.HasValue) _values_[1] = ea.EnOverride_ElectricCircuitFail.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_CNF_ELEC_CIRC_FAIL(System.Boolean OverrideV_ElectricCircuitFail, bool ignore_OverrideV_ElectricCircuitFail, System.Boolean EnOverride_ElectricCircuitFail, bool ignore_EnOverride_ElectricCircuitFail)
    {
      object[] _values_ = new object[2];
      if (!ignore_OverrideV_ElectricCircuitFail) _values_[0] = OverrideV_ElectricCircuitFail;
      if (!ignore_EnOverride_ElectricCircuitFail) _values_[1] = EnOverride_ElectricCircuitFail;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_CNF_SAF_SW(System.Boolean OverrideV_SafetySwitchOff, System.Boolean EnOverride_SafetySwitchOff)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {OverrideV_SafetySwitchOff, EnOverride_SafetySwitchOff});
    }
    public bool FireEvent_CNF_SAF_SW(SE.Nereda.Symbols.FieldSignals.CNF_SAF_SWEventArgs ea)
    {
      object[] _values_ = new object[2];
      if (ea.OverrideV_SafetySwitchOff.HasValue) _values_[0] = ea.OverrideV_SafetySwitchOff.Value;
      if (ea.EnOverride_SafetySwitchOff.HasValue) _values_[1] = ea.EnOverride_SafetySwitchOff.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_CNF_SAF_SW(System.Boolean OverrideV_SafetySwitchOff, bool ignore_OverrideV_SafetySwitchOff, System.Boolean EnOverride_SafetySwitchOff, bool ignore_EnOverride_SafetySwitchOff)
    {
      object[] _values_ = new object[2];
      if (!ignore_OverrideV_SafetySwitchOff) _values_[0] = OverrideV_SafetySwitchOff;
      if (!ignore_EnOverride_SafetySwitchOff) _values_[1] = EnOverride_SafetySwitchOff;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_CNF_FREQ_INV_FAIL(System.Boolean OverrideV_FrequencyInverterFail, System.Boolean EnOverride_FrequencyInverterFail)
    {
      return ((IHMIAccessorOutput)this).FireEvent(2, new object[] {OverrideV_FrequencyInverterFail, EnOverride_FrequencyInverterFail});
    }
    public bool FireEvent_CNF_FREQ_INV_FAIL(SE.Nereda.Symbols.FieldSignals.CNF_FREQ_INV_FAILEventArgs ea)
    {
      object[] _values_ = new object[2];
      if (ea.OverrideV_FrequencyInverterFail.HasValue) _values_[0] = ea.OverrideV_FrequencyInverterFail.Value;
      if (ea.EnOverride_FrequencyInverterFail.HasValue) _values_[1] = ea.EnOverride_FrequencyInverterFail.Value;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_CNF_FREQ_INV_FAIL(System.Boolean OverrideV_FrequencyInverterFail, bool ignore_OverrideV_FrequencyInverterFail, System.Boolean EnOverride_FrequencyInverterFail, bool ignore_EnOverride_FrequencyInverterFail)
    {
      object[] _values_ = new object[2];
      if (!ignore_OverrideV_FrequencyInverterFail) _values_[0] = OverrideV_FrequencyInverterFail;
      if (!ignore_EnOverride_FrequencyInverterFail) _values_[1] = EnOverride_FrequencyInverterFail;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_CNF_ETA_ATV(System.UInt16 OverrideV_AtvEta, System.Boolean EnOverride_AtvEta)
    {
      return ((IHMIAccessorOutput)this).FireEvent(3, new object[] {OverrideV_AtvEta, EnOverride_AtvEta});
    }
    public bool FireEvent_CNF_ETA_ATV(SE.Nereda.Symbols.FieldSignals.CNF_ETA_ATVEventArgs ea)
    {
      object[] _values_ = new object[2];
      if (ea.OverrideV_AtvEta.HasValue) _values_[0] = ea.OverrideV_AtvEta.Value;
      if (ea.EnOverride_AtvEta.HasValue) _values_[1] = ea.EnOverride_AtvEta.Value;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_CNF_ETA_ATV(System.UInt16 OverrideV_AtvEta, bool ignore_OverrideV_AtvEta, System.Boolean EnOverride_AtvEta, bool ignore_EnOverride_AtvEta)
    {
      object[] _values_ = new object[2];
      if (!ignore_OverrideV_AtvEta) _values_[0] = OverrideV_AtvEta;
      if (!ignore_EnOverride_AtvEta) _values_[1] = EnOverride_AtvEta;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_CNF_REMOTE(System.Boolean OverrideV_RemoteSelect, System.Boolean EnOverride_RemoteSelect)
    {
      return ((IHMIAccessorOutput)this).FireEvent(4, new object[] {OverrideV_RemoteSelect, EnOverride_RemoteSelect});
    }
    public bool FireEvent_CNF_REMOTE(SE.Nereda.Symbols.FieldSignals.CNF_REMOTEEventArgs ea)
    {
      object[] _values_ = new object[2];
      if (ea.OverrideV_RemoteSelect.HasValue) _values_[0] = ea.OverrideV_RemoteSelect.Value;
      if (ea.EnOverride_RemoteSelect.HasValue) _values_[1] = ea.EnOverride_RemoteSelect.Value;
      return ((IHMIAccessorOutput)this).FireEvent(4, _values_);
    }
    public bool FireEvent_CNF_REMOTE(System.Boolean OverrideV_RemoteSelect, bool ignore_OverrideV_RemoteSelect, System.Boolean EnOverride_RemoteSelect, bool ignore_EnOverride_RemoteSelect)
    {
      object[] _values_ = new object[2];
      if (!ignore_OverrideV_RemoteSelect) _values_[0] = OverrideV_RemoteSelect;
      if (!ignore_EnOverride_RemoteSelect) _values_[1] = EnOverride_RemoteSelect;
      return ((IHMIAccessorOutput)this).FireEvent(4, _values_);
    }
    public bool FireEvent_CNF_AUTO(System.Boolean OverrideV_AutoSelect, System.Boolean EnOverride_AutoSelect)
    {
      return ((IHMIAccessorOutput)this).FireEvent(5, new object[] {OverrideV_AutoSelect, EnOverride_AutoSelect});
    }
    public bool FireEvent_CNF_AUTO(SE.Nereda.Symbols.FieldSignals.CNF_AUTOEventArgs ea)
    {
      object[] _values_ = new object[2];
      if (ea.OverrideV_AutoSelect.HasValue) _values_[0] = ea.OverrideV_AutoSelect.Value;
      if (ea.EnOverride_AutoSelect.HasValue) _values_[1] = ea.EnOverride_AutoSelect.Value;
      return ((IHMIAccessorOutput)this).FireEvent(5, _values_);
    }
    public bool FireEvent_CNF_AUTO(System.Boolean OverrideV_AutoSelect, bool ignore_OverrideV_AutoSelect, System.Boolean EnOverride_AutoSelect, bool ignore_EnOverride_AutoSelect)
    {
      object[] _values_ = new object[2];
      if (!ignore_OverrideV_AutoSelect) _values_[0] = OverrideV_AutoSelect;
      if (!ignore_EnOverride_AutoSelect) _values_[1] = EnOverride_AutoSelect;
      return ((IHMIAccessorOutput)this).FireEvent(5, _values_);
    }
    public bool FireEvent_CNF_POWER(System.Boolean OverrideV_PowerFb, System.Boolean EnOverride_PowerFb)
    {
      return ((IHMIAccessorOutput)this).FireEvent(6, new object[] {OverrideV_PowerFb, EnOverride_PowerFb});
    }
    public bool FireEvent_CNF_POWER(SE.Nereda.Symbols.FieldSignals.CNF_POWEREventArgs ea)
    {
      object[] _values_ = new object[2];
      if (ea.OverrideV_PowerFb.HasValue) _values_[0] = ea.OverrideV_PowerFb.Value;
      if (ea.EnOverride_PowerFb.HasValue) _values_[1] = ea.EnOverride_PowerFb.Value;
      return ((IHMIAccessorOutput)this).FireEvent(6, _values_);
    }
    public bool FireEvent_CNF_POWER(System.Boolean OverrideV_PowerFb, bool ignore_OverrideV_PowerFb, System.Boolean EnOverride_PowerFb, bool ignore_EnOverride_PowerFb)
    {
      object[] _values_ = new object[2];
      if (!ignore_OverrideV_PowerFb) _values_[0] = OverrideV_PowerFb;
      if (!ignore_EnOverride_PowerFb) _values_[1] = EnOverride_PowerFb;
      return ((IHMIAccessorOutput)this).FireEvent(6, _values_);
    }
    public bool FireEvent_CNF_ATV_RDY(System.Boolean OverrideV_AtvReady, System.Boolean EnOverride_AtvReady)
    {
      return ((IHMIAccessorOutput)this).FireEvent(7, new object[] {OverrideV_AtvReady, EnOverride_AtvReady});
    }
    public bool FireEvent_CNF_ATV_RDY(SE.Nereda.Symbols.FieldSignals.CNF_ATV_RDYEventArgs ea)
    {
      object[] _values_ = new object[2];
      if (ea.OverrideV_AtvReady.HasValue) _values_[0] = ea.OverrideV_AtvReady.Value;
      if (ea.EnOverride_AtvReady.HasValue) _values_[1] = ea.EnOverride_AtvReady.Value;
      return ((IHMIAccessorOutput)this).FireEvent(7, _values_);
    }
    public bool FireEvent_CNF_ATV_RDY(System.Boolean OverrideV_AtvReady, bool ignore_OverrideV_AtvReady, System.Boolean EnOverride_AtvReady, bool ignore_EnOverride_AtvReady)
    {
      object[] _values_ = new object[2];
      if (!ignore_OverrideV_AtvReady) _values_[0] = OverrideV_AtvReady;
      if (!ignore_EnOverride_AtvReady) _values_[1] = EnOverride_AtvReady;
      return ((IHMIAccessorOutput)this).FireEvent(7, _values_);
    }
    public bool FireEvent_CNF_TRIP(System.Boolean EnOverride_Trip, System.Boolean OverrideV_Trip)
    {
      return ((IHMIAccessorOutput)this).FireEvent(8, new object[] {EnOverride_Trip, OverrideV_Trip});
    }
    public bool FireEvent_CNF_TRIP(SE.Nereda.Symbols.FieldSignals.CNF_TRIPEventArgs ea)
    {
      object[] _values_ = new object[2];
      if (ea.EnOverride_Trip.HasValue) _values_[0] = ea.EnOverride_Trip.Value;
      if (ea.OverrideV_Trip.HasValue) _values_[1] = ea.OverrideV_Trip.Value;
      return ((IHMIAccessorOutput)this).FireEvent(8, _values_);
    }
    public bool FireEvent_CNF_TRIP(System.Boolean EnOverride_Trip, bool ignore_EnOverride_Trip, System.Boolean OverrideV_Trip, bool ignore_OverrideV_Trip)
    {
      object[] _values_ = new object[2];
      if (!ignore_EnOverride_Trip) _values_[0] = EnOverride_Trip;
      if (!ignore_OverrideV_Trip) _values_[1] = OverrideV_Trip;
      return ((IHMIAccessorOutput)this).FireEvent(8, _values_);
    }
    public bool FireEvent_CNF_MDPMS(System.Boolean EnOverride_MDPMS, System.Boolean OverrideV_MDPMS)
    {
      return ((IHMIAccessorOutput)this).FireEvent(9, new object[] {EnOverride_MDPMS, OverrideV_MDPMS});
    }
    public bool FireEvent_CNF_MDPMS(SE.Nereda.Symbols.FieldSignals.CNF_MDPMSEventArgs ea)
    {
      object[] _values_ = new object[2];
      if (ea.EnOverride_MDPMS.HasValue) _values_[0] = ea.EnOverride_MDPMS.Value;
      if (ea.OverrideV_MDPMS.HasValue) _values_[1] = ea.OverrideV_MDPMS.Value;
      return ((IHMIAccessorOutput)this).FireEvent(9, _values_);
    }
    public bool FireEvent_CNF_MDPMS(System.Boolean EnOverride_MDPMS, bool ignore_EnOverride_MDPMS, System.Boolean OverrideV_MDPMS, bool ignore_OverrideV_MDPMS)
    {
      object[] _values_ = new object[2];
      if (!ignore_EnOverride_MDPMS) _values_[0] = EnOverride_MDPMS;
      if (!ignore_OverrideV_MDPMS) _values_[1] = OverrideV_MDPMS;
      return ((IHMIAccessorOutput)this).FireEvent(9, _values_);
    }
    public bool FireEvent_CNF_VALUES(System.Boolean OverrideV_ElectricCircuitFail, System.Boolean OverrideV_SafetySwitchOff, System.Boolean OverrideV_FrequencyInverterFail, System.Boolean OverrideV_RemoteSelect, System.Boolean OverrideV_AutoSelect, System.Boolean OverrideV_PowerFb, System.Boolean OverrideV_AtvReady)
    {
      return ((IHMIAccessorOutput)this).FireEvent(10, new object[] {OverrideV_ElectricCircuitFail, OverrideV_SafetySwitchOff, OverrideV_FrequencyInverterFail, OverrideV_RemoteSelect, OverrideV_AutoSelect, OverrideV_PowerFb, OverrideV_AtvReady});
    }
    public bool FireEvent_CNF_VALUES(SE.Nereda.Symbols.FieldSignals.CNF_VALUESEventArgs ea)
    {
      object[] _values_ = new object[7];
      if (ea.OverrideV_ElectricCircuitFail.HasValue) _values_[0] = ea.OverrideV_ElectricCircuitFail.Value;
      if (ea.OverrideV_SafetySwitchOff.HasValue) _values_[1] = ea.OverrideV_SafetySwitchOff.Value;
      if (ea.OverrideV_FrequencyInverterFail.HasValue) _values_[2] = ea.OverrideV_FrequencyInverterFail.Value;
      if (ea.OverrideV_RemoteSelect.HasValue) _values_[3] = ea.OverrideV_RemoteSelect.Value;
      if (ea.OverrideV_AutoSelect.HasValue) _values_[4] = ea.OverrideV_AutoSelect.Value;
      if (ea.OverrideV_PowerFb.HasValue) _values_[5] = ea.OverrideV_PowerFb.Value;
      if (ea.OverrideV_AtvReady.HasValue) _values_[6] = ea.OverrideV_AtvReady.Value;
      return ((IHMIAccessorOutput)this).FireEvent(10, _values_);
    }
    public bool FireEvent_CNF_VALUES(System.Boolean OverrideV_ElectricCircuitFail, bool ignore_OverrideV_ElectricCircuitFail, System.Boolean OverrideV_SafetySwitchOff, bool ignore_OverrideV_SafetySwitchOff, System.Boolean OverrideV_FrequencyInverterFail, bool ignore_OverrideV_FrequencyInverterFail, System.Boolean OverrideV_RemoteSelect, bool ignore_OverrideV_RemoteSelect, System.Boolean OverrideV_AutoSelect, bool ignore_OverrideV_AutoSelect, System.Boolean OverrideV_PowerFb, bool ignore_OverrideV_PowerFb, System.Boolean OverrideV_AtvReady, bool ignore_OverrideV_AtvReady)
    {
      object[] _values_ = new object[7];
      if (!ignore_OverrideV_ElectricCircuitFail) _values_[0] = OverrideV_ElectricCircuitFail;
      if (!ignore_OverrideV_SafetySwitchOff) _values_[1] = OverrideV_SafetySwitchOff;
      if (!ignore_OverrideV_FrequencyInverterFail) _values_[2] = OverrideV_FrequencyInverterFail;
      if (!ignore_OverrideV_RemoteSelect) _values_[3] = OverrideV_RemoteSelect;
      if (!ignore_OverrideV_AutoSelect) _values_[4] = OverrideV_AutoSelect;
      if (!ignore_OverrideV_PowerFb) _values_[5] = OverrideV_PowerFb;
      if (!ignore_OverrideV_AtvReady) _values_[6] = OverrideV_AtvReady;
      return ((IHMIAccessorOutput)this).FireEvent(10, _values_);
    }

  }
}

namespace SE.Nereda.Symbols.FieldSignals
{
  partial class sPanel
  {

    private event EventHandler<SE.Nereda.Symbols.FieldSignals.REQ_STATEEventArgs> REQ_STATE_Fired;

    private event EventHandler<SE.Nereda.Symbols.FieldSignals.REQ_NAMEEventArgs> REQ_NAME_Fired;

    private event EventHandler<SE.Nereda.Symbols.FieldSignals.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    protected override void OnEndInit()
    {
      if (REQ_STATE_Fired != null)
        AttachEventInput(0);
      if (REQ_NAME_Fired != null)
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
          if (REQ_STATE_Fired != null)
          {
            try
            {
              REQ_STATE_Fired(this, new SE.Nereda.Symbols.FieldSignals.REQ_STATEEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REQ_STATE_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 1:
          if (REQ_NAME_Fired != null)
          {
            try
            {
              REQ_NAME_Fired(this, new SE.Nereda.Symbols.FieldSignals.REQ_NAMEEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REQ_NAME_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 2:
          if (LOAD_PERS_DATA_Fired != null)
          {
            try
            {
              LOAD_PERS_DATA_Fired(this, new SE.Nereda.Symbols.FieldSignals.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
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
    public bool FireEvent_CNF_ELEC_CIRC_FAIL(System.Boolean OverrideV_ElectricCircuitFail, System.Boolean EnOverride_ElectricCircuitFail)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {OverrideV_ElectricCircuitFail, EnOverride_ElectricCircuitFail});
    }
    public bool FireEvent_CNF_ELEC_CIRC_FAIL(SE.Nereda.Symbols.FieldSignals.CNF_ELEC_CIRC_FAILEventArgs ea)
    {
      object[] _values_ = new object[2];
      if (ea.OverrideV_ElectricCircuitFail.HasValue) _values_[0] = ea.OverrideV_ElectricCircuitFail.Value;
      if (ea.EnOverride_ElectricCircuitFail.HasValue) _values_[1] = ea.EnOverride_ElectricCircuitFail.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_CNF_ELEC_CIRC_FAIL(System.Boolean OverrideV_ElectricCircuitFail, bool ignore_OverrideV_ElectricCircuitFail, System.Boolean EnOverride_ElectricCircuitFail, bool ignore_EnOverride_ElectricCircuitFail)
    {
      object[] _values_ = new object[2];
      if (!ignore_OverrideV_ElectricCircuitFail) _values_[0] = OverrideV_ElectricCircuitFail;
      if (!ignore_EnOverride_ElectricCircuitFail) _values_[1] = EnOverride_ElectricCircuitFail;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_CNF_SAF_SW(System.Boolean OverrideV_SafetySwitchOff, System.Boolean EnOverride_SafetySwitchOff)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {OverrideV_SafetySwitchOff, EnOverride_SafetySwitchOff});
    }
    public bool FireEvent_CNF_SAF_SW(SE.Nereda.Symbols.FieldSignals.CNF_SAF_SWEventArgs ea)
    {
      object[] _values_ = new object[2];
      if (ea.OverrideV_SafetySwitchOff.HasValue) _values_[0] = ea.OverrideV_SafetySwitchOff.Value;
      if (ea.EnOverride_SafetySwitchOff.HasValue) _values_[1] = ea.EnOverride_SafetySwitchOff.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_CNF_SAF_SW(System.Boolean OverrideV_SafetySwitchOff, bool ignore_OverrideV_SafetySwitchOff, System.Boolean EnOverride_SafetySwitchOff, bool ignore_EnOverride_SafetySwitchOff)
    {
      object[] _values_ = new object[2];
      if (!ignore_OverrideV_SafetySwitchOff) _values_[0] = OverrideV_SafetySwitchOff;
      if (!ignore_EnOverride_SafetySwitchOff) _values_[1] = EnOverride_SafetySwitchOff;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_CNF_FREQ_INV_FAIL(System.Boolean OverrideV_FrequencyInverterFail, System.Boolean EnOverride_FrequencyInverterFail)
    {
      return ((IHMIAccessorOutput)this).FireEvent(2, new object[] {OverrideV_FrequencyInverterFail, EnOverride_FrequencyInverterFail});
    }
    public bool FireEvent_CNF_FREQ_INV_FAIL(SE.Nereda.Symbols.FieldSignals.CNF_FREQ_INV_FAILEventArgs ea)
    {
      object[] _values_ = new object[2];
      if (ea.OverrideV_FrequencyInverterFail.HasValue) _values_[0] = ea.OverrideV_FrequencyInverterFail.Value;
      if (ea.EnOverride_FrequencyInverterFail.HasValue) _values_[1] = ea.EnOverride_FrequencyInverterFail.Value;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_CNF_FREQ_INV_FAIL(System.Boolean OverrideV_FrequencyInverterFail, bool ignore_OverrideV_FrequencyInverterFail, System.Boolean EnOverride_FrequencyInverterFail, bool ignore_EnOverride_FrequencyInverterFail)
    {
      object[] _values_ = new object[2];
      if (!ignore_OverrideV_FrequencyInverterFail) _values_[0] = OverrideV_FrequencyInverterFail;
      if (!ignore_EnOverride_FrequencyInverterFail) _values_[1] = EnOverride_FrequencyInverterFail;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_CNF_ETA_ATV(System.UInt16 OverrideV_AtvEta, System.Boolean EnOverride_AtvEta)
    {
      return ((IHMIAccessorOutput)this).FireEvent(3, new object[] {OverrideV_AtvEta, EnOverride_AtvEta});
    }
    public bool FireEvent_CNF_ETA_ATV(SE.Nereda.Symbols.FieldSignals.CNF_ETA_ATVEventArgs ea)
    {
      object[] _values_ = new object[2];
      if (ea.OverrideV_AtvEta.HasValue) _values_[0] = ea.OverrideV_AtvEta.Value;
      if (ea.EnOverride_AtvEta.HasValue) _values_[1] = ea.EnOverride_AtvEta.Value;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_CNF_ETA_ATV(System.UInt16 OverrideV_AtvEta, bool ignore_OverrideV_AtvEta, System.Boolean EnOverride_AtvEta, bool ignore_EnOverride_AtvEta)
    {
      object[] _values_ = new object[2];
      if (!ignore_OverrideV_AtvEta) _values_[0] = OverrideV_AtvEta;
      if (!ignore_EnOverride_AtvEta) _values_[1] = EnOverride_AtvEta;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_CNF_REMOTE(System.Boolean OverrideV_RemoteSelect, System.Boolean EnOverride_RemoteSelect)
    {
      return ((IHMIAccessorOutput)this).FireEvent(4, new object[] {OverrideV_RemoteSelect, EnOverride_RemoteSelect});
    }
    public bool FireEvent_CNF_REMOTE(SE.Nereda.Symbols.FieldSignals.CNF_REMOTEEventArgs ea)
    {
      object[] _values_ = new object[2];
      if (ea.OverrideV_RemoteSelect.HasValue) _values_[0] = ea.OverrideV_RemoteSelect.Value;
      if (ea.EnOverride_RemoteSelect.HasValue) _values_[1] = ea.EnOverride_RemoteSelect.Value;
      return ((IHMIAccessorOutput)this).FireEvent(4, _values_);
    }
    public bool FireEvent_CNF_REMOTE(System.Boolean OverrideV_RemoteSelect, bool ignore_OverrideV_RemoteSelect, System.Boolean EnOverride_RemoteSelect, bool ignore_EnOverride_RemoteSelect)
    {
      object[] _values_ = new object[2];
      if (!ignore_OverrideV_RemoteSelect) _values_[0] = OverrideV_RemoteSelect;
      if (!ignore_EnOverride_RemoteSelect) _values_[1] = EnOverride_RemoteSelect;
      return ((IHMIAccessorOutput)this).FireEvent(4, _values_);
    }
    public bool FireEvent_CNF_AUTO(System.Boolean OverrideV_AutoSelect, System.Boolean EnOverride_AutoSelect)
    {
      return ((IHMIAccessorOutput)this).FireEvent(5, new object[] {OverrideV_AutoSelect, EnOverride_AutoSelect});
    }
    public bool FireEvent_CNF_AUTO(SE.Nereda.Symbols.FieldSignals.CNF_AUTOEventArgs ea)
    {
      object[] _values_ = new object[2];
      if (ea.OverrideV_AutoSelect.HasValue) _values_[0] = ea.OverrideV_AutoSelect.Value;
      if (ea.EnOverride_AutoSelect.HasValue) _values_[1] = ea.EnOverride_AutoSelect.Value;
      return ((IHMIAccessorOutput)this).FireEvent(5, _values_);
    }
    public bool FireEvent_CNF_AUTO(System.Boolean OverrideV_AutoSelect, bool ignore_OverrideV_AutoSelect, System.Boolean EnOverride_AutoSelect, bool ignore_EnOverride_AutoSelect)
    {
      object[] _values_ = new object[2];
      if (!ignore_OverrideV_AutoSelect) _values_[0] = OverrideV_AutoSelect;
      if (!ignore_EnOverride_AutoSelect) _values_[1] = EnOverride_AutoSelect;
      return ((IHMIAccessorOutput)this).FireEvent(5, _values_);
    }
    public bool FireEvent_CNF_POWER(System.Boolean OverrideV_PowerFb, System.Boolean EnOverride_PowerFb)
    {
      return ((IHMIAccessorOutput)this).FireEvent(6, new object[] {OverrideV_PowerFb, EnOverride_PowerFb});
    }
    public bool FireEvent_CNF_POWER(SE.Nereda.Symbols.FieldSignals.CNF_POWEREventArgs ea)
    {
      object[] _values_ = new object[2];
      if (ea.OverrideV_PowerFb.HasValue) _values_[0] = ea.OverrideV_PowerFb.Value;
      if (ea.EnOverride_PowerFb.HasValue) _values_[1] = ea.EnOverride_PowerFb.Value;
      return ((IHMIAccessorOutput)this).FireEvent(6, _values_);
    }
    public bool FireEvent_CNF_POWER(System.Boolean OverrideV_PowerFb, bool ignore_OverrideV_PowerFb, System.Boolean EnOverride_PowerFb, bool ignore_EnOverride_PowerFb)
    {
      object[] _values_ = new object[2];
      if (!ignore_OverrideV_PowerFb) _values_[0] = OverrideV_PowerFb;
      if (!ignore_EnOverride_PowerFb) _values_[1] = EnOverride_PowerFb;
      return ((IHMIAccessorOutput)this).FireEvent(6, _values_);
    }
    public bool FireEvent_CNF_ATV_RDY(System.Boolean OverrideV_AtvReady, System.Boolean EnOverride_AtvReady)
    {
      return ((IHMIAccessorOutput)this).FireEvent(7, new object[] {OverrideV_AtvReady, EnOverride_AtvReady});
    }
    public bool FireEvent_CNF_ATV_RDY(SE.Nereda.Symbols.FieldSignals.CNF_ATV_RDYEventArgs ea)
    {
      object[] _values_ = new object[2];
      if (ea.OverrideV_AtvReady.HasValue) _values_[0] = ea.OverrideV_AtvReady.Value;
      if (ea.EnOverride_AtvReady.HasValue) _values_[1] = ea.EnOverride_AtvReady.Value;
      return ((IHMIAccessorOutput)this).FireEvent(7, _values_);
    }
    public bool FireEvent_CNF_ATV_RDY(System.Boolean OverrideV_AtvReady, bool ignore_OverrideV_AtvReady, System.Boolean EnOverride_AtvReady, bool ignore_EnOverride_AtvReady)
    {
      object[] _values_ = new object[2];
      if (!ignore_OverrideV_AtvReady) _values_[0] = OverrideV_AtvReady;
      if (!ignore_EnOverride_AtvReady) _values_[1] = EnOverride_AtvReady;
      return ((IHMIAccessorOutput)this).FireEvent(7, _values_);
    }
    public bool FireEvent_CNF_TRIP(System.Boolean EnOverride_Trip, System.Boolean OverrideV_Trip)
    {
      return ((IHMIAccessorOutput)this).FireEvent(8, new object[] {EnOverride_Trip, OverrideV_Trip});
    }
    public bool FireEvent_CNF_TRIP(SE.Nereda.Symbols.FieldSignals.CNF_TRIPEventArgs ea)
    {
      object[] _values_ = new object[2];
      if (ea.EnOverride_Trip.HasValue) _values_[0] = ea.EnOverride_Trip.Value;
      if (ea.OverrideV_Trip.HasValue) _values_[1] = ea.OverrideV_Trip.Value;
      return ((IHMIAccessorOutput)this).FireEvent(8, _values_);
    }
    public bool FireEvent_CNF_TRIP(System.Boolean EnOverride_Trip, bool ignore_EnOverride_Trip, System.Boolean OverrideV_Trip, bool ignore_OverrideV_Trip)
    {
      object[] _values_ = new object[2];
      if (!ignore_EnOverride_Trip) _values_[0] = EnOverride_Trip;
      if (!ignore_OverrideV_Trip) _values_[1] = OverrideV_Trip;
      return ((IHMIAccessorOutput)this).FireEvent(8, _values_);
    }
    public bool FireEvent_CNF_MDPMS(System.Boolean EnOverride_MDPMS, System.Boolean OverrideV_MDPMS)
    {
      return ((IHMIAccessorOutput)this).FireEvent(9, new object[] {EnOverride_MDPMS, OverrideV_MDPMS});
    }
    public bool FireEvent_CNF_MDPMS(SE.Nereda.Symbols.FieldSignals.CNF_MDPMSEventArgs ea)
    {
      object[] _values_ = new object[2];
      if (ea.EnOverride_MDPMS.HasValue) _values_[0] = ea.EnOverride_MDPMS.Value;
      if (ea.OverrideV_MDPMS.HasValue) _values_[1] = ea.OverrideV_MDPMS.Value;
      return ((IHMIAccessorOutput)this).FireEvent(9, _values_);
    }
    public bool FireEvent_CNF_MDPMS(System.Boolean EnOverride_MDPMS, bool ignore_EnOverride_MDPMS, System.Boolean OverrideV_MDPMS, bool ignore_OverrideV_MDPMS)
    {
      object[] _values_ = new object[2];
      if (!ignore_EnOverride_MDPMS) _values_[0] = EnOverride_MDPMS;
      if (!ignore_OverrideV_MDPMS) _values_[1] = OverrideV_MDPMS;
      return ((IHMIAccessorOutput)this).FireEvent(9, _values_);
    }
    public bool FireEvent_CNF_VALUES(System.Boolean OverrideV_ElectricCircuitFail, System.Boolean OverrideV_SafetySwitchOff, System.Boolean OverrideV_FrequencyInverterFail, System.Boolean OverrideV_RemoteSelect, System.Boolean OverrideV_AutoSelect, System.Boolean OverrideV_PowerFb, System.Boolean OverrideV_AtvReady)
    {
      return ((IHMIAccessorOutput)this).FireEvent(10, new object[] {OverrideV_ElectricCircuitFail, OverrideV_SafetySwitchOff, OverrideV_FrequencyInverterFail, OverrideV_RemoteSelect, OverrideV_AutoSelect, OverrideV_PowerFb, OverrideV_AtvReady});
    }
    public bool FireEvent_CNF_VALUES(SE.Nereda.Symbols.FieldSignals.CNF_VALUESEventArgs ea)
    {
      object[] _values_ = new object[7];
      if (ea.OverrideV_ElectricCircuitFail.HasValue) _values_[0] = ea.OverrideV_ElectricCircuitFail.Value;
      if (ea.OverrideV_SafetySwitchOff.HasValue) _values_[1] = ea.OverrideV_SafetySwitchOff.Value;
      if (ea.OverrideV_FrequencyInverterFail.HasValue) _values_[2] = ea.OverrideV_FrequencyInverterFail.Value;
      if (ea.OverrideV_RemoteSelect.HasValue) _values_[3] = ea.OverrideV_RemoteSelect.Value;
      if (ea.OverrideV_AutoSelect.HasValue) _values_[4] = ea.OverrideV_AutoSelect.Value;
      if (ea.OverrideV_PowerFb.HasValue) _values_[5] = ea.OverrideV_PowerFb.Value;
      if (ea.OverrideV_AtvReady.HasValue) _values_[6] = ea.OverrideV_AtvReady.Value;
      return ((IHMIAccessorOutput)this).FireEvent(10, _values_);
    }
    public bool FireEvent_CNF_VALUES(System.Boolean OverrideV_ElectricCircuitFail, bool ignore_OverrideV_ElectricCircuitFail, System.Boolean OverrideV_SafetySwitchOff, bool ignore_OverrideV_SafetySwitchOff, System.Boolean OverrideV_FrequencyInverterFail, bool ignore_OverrideV_FrequencyInverterFail, System.Boolean OverrideV_RemoteSelect, bool ignore_OverrideV_RemoteSelect, System.Boolean OverrideV_AutoSelect, bool ignore_OverrideV_AutoSelect, System.Boolean OverrideV_PowerFb, bool ignore_OverrideV_PowerFb, System.Boolean OverrideV_AtvReady, bool ignore_OverrideV_AtvReady)
    {
      object[] _values_ = new object[7];
      if (!ignore_OverrideV_ElectricCircuitFail) _values_[0] = OverrideV_ElectricCircuitFail;
      if (!ignore_OverrideV_SafetySwitchOff) _values_[1] = OverrideV_SafetySwitchOff;
      if (!ignore_OverrideV_FrequencyInverterFail) _values_[2] = OverrideV_FrequencyInverterFail;
      if (!ignore_OverrideV_RemoteSelect) _values_[3] = OverrideV_RemoteSelect;
      if (!ignore_OverrideV_AutoSelect) _values_[4] = OverrideV_AutoSelect;
      if (!ignore_OverrideV_PowerFb) _values_[5] = OverrideV_PowerFb;
      if (!ignore_OverrideV_AtvReady) _values_[6] = OverrideV_AtvReady;
      return ((IHMIAccessorOutput)this).FireEvent(10, _values_);
    }

  }
}
#endregion #FieldSignals_HMI;

#endregion Definitions;
