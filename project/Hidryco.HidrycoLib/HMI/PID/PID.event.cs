/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 1/20/2026
 * Time: 3:23 PM
 * 
 */
using System;
using NxtControl.GuiFramework;
using NxtControl.Services;

#region Definitions;
#region #PID_HMI;

namespace Hidryco.HidrycoLib.Symbols.PID
{

  public class E_ATUALIZA_SAIDA_PIDEventArgs : System.EventArgs
  {
    IHMIAccessorService accessorService;
    int channelId;
    int cookie; 
    int eventIndex;

    public E_ATUALIZA_SAIDA_PIDEventArgs(int channelId, int cookie, int eventIndex)
    {
      this.accessorService = (IHMIAccessorService)ServiceProvider.GetService(typeof(IHMIAccessorService));
      this.channelId = channelId;
      this.cookie = cookie;
      this.eventIndex = eventIndex;
    }
    public bool Get_stsSaidaPID(ref System.Single value)
    {
      if (accessorService == null)
        return false;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,0, ref var);
      if (ret) value = (System.Single) var;
      return ret;
    }

    public System.Single? stsSaidaPID
    { get {
      if (accessorService == null)
        return null;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,0, ref var);
      if (!ret) return null;
      return (System.Single) var;
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

namespace Hidryco.HidrycoLib.Symbols.PID
{

  public class E_ATUALIZA_SETPOINTEventArgs : System.EventArgs
  {
    public E_ATUALIZA_SETPOINTEventArgs()
    {
    }
    private System.Boolean? cmdHabilitaPID_field = null;
    public System.Boolean? cmdHabilitaPID
    {
       get { return cmdHabilitaPID_field; }
       set { cmdHabilitaPID_field = value; }
    }
    private System.Single? stpDesejado_field = null;
    public System.Single? stpDesejado
    {
       get { return stpDesejado_field; }
       set { stpDesejado_field = value; }
    }
    private System.Single? stpKP_field = null;
    public System.Single? stpKP
    {
       get { return stpKP_field; }
       set { stpKP_field = value; }
    }
    private System.Single? stpKI_field = null;
    public System.Single? stpKI
    {
       get { return stpKI_field; }
       set { stpKI_field = value; }
    }
    private System.Single? stpKD_field = null;
    public System.Single? stpKD
    {
       get { return stpKD_field; }
       set { stpKD_field = value; }
    }
    private System.Single? stpMaximo_field = null;
    public System.Single? stpMaximo
    {
       get { return stpMaximo_field; }
       set { stpMaximo_field = value; }
    }
    private System.Single? stpMinimo_field = null;
    public System.Single? stpMinimo
    {
       get { return stpMinimo_field; }
       set { stpMinimo_field = value; }
    }

  }

}

namespace Hidryco.HidrycoLib.Symbols.PID
{
  partial class sDefault
  {

    private event EventHandler<Hidryco.HidrycoLib.Symbols.PID.E_ATUALIZA_SAIDA_PIDEventArgs> E_ATUALIZA_SAIDA_PID_Fired;

    private event EventHandler<Hidryco.HidrycoLib.Symbols.PID.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    protected override void OnEndInit()
    {
      if (E_ATUALIZA_SAIDA_PID_Fired != null)
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
          if (E_ATUALIZA_SAIDA_PID_Fired != null)
          {
            try
            {
              E_ATUALIZA_SAIDA_PID_Fired(this, new Hidryco.HidrycoLib.Symbols.PID.E_ATUALIZA_SAIDA_PIDEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","E_ATUALIZA_SAIDA_PID_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 1:
          if (LOAD_PERS_DATA_Fired != null)
          {
            try
            {
              LOAD_PERS_DATA_Fired(this, new Hidryco.HidrycoLib.Symbols.PID.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
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
    public bool FireEvent_E_ATUALIZA_SETPOINT(System.Boolean cmdHabilitaPID, System.Single stpDesejado, System.Single stpKP, System.Single stpKI, System.Single stpKD, System.Single stpMaximo, System.Single stpMinimo)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {cmdHabilitaPID, stpDesejado, stpKP, stpKI, stpKD, stpMaximo, stpMinimo});
    }
    public bool FireEvent_E_ATUALIZA_SETPOINT(Hidryco.HidrycoLib.Symbols.PID.E_ATUALIZA_SETPOINTEventArgs ea)
    {
      object[] _values_ = new object[7];
      if (ea.cmdHabilitaPID.HasValue) _values_[0] = ea.cmdHabilitaPID.Value;
      if (ea.stpDesejado.HasValue) _values_[1] = ea.stpDesejado.Value;
      if (ea.stpKP.HasValue) _values_[2] = ea.stpKP.Value;
      if (ea.stpKI.HasValue) _values_[3] = ea.stpKI.Value;
      if (ea.stpKD.HasValue) _values_[4] = ea.stpKD.Value;
      if (ea.stpMaximo.HasValue) _values_[5] = ea.stpMaximo.Value;
      if (ea.stpMinimo.HasValue) _values_[6] = ea.stpMinimo.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_E_ATUALIZA_SETPOINT(System.Boolean cmdHabilitaPID, bool ignore_cmdHabilitaPID, System.Single stpDesejado, bool ignore_stpDesejado, System.Single stpKP, bool ignore_stpKP, System.Single stpKI, bool ignore_stpKI, System.Single stpKD, bool ignore_stpKD, System.Single stpMaximo, bool ignore_stpMaximo, System.Single stpMinimo, bool ignore_stpMinimo)
    {
      object[] _values_ = new object[7];
      if (!ignore_cmdHabilitaPID) _values_[0] = cmdHabilitaPID;
      if (!ignore_stpDesejado) _values_[1] = stpDesejado;
      if (!ignore_stpKP) _values_[2] = stpKP;
      if (!ignore_stpKI) _values_[3] = stpKI;
      if (!ignore_stpKD) _values_[4] = stpKD;
      if (!ignore_stpMaximo) _values_[5] = stpMaximo;
      if (!ignore_stpMinimo) _values_[6] = stpMinimo;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }

  }
}

namespace Hidryco.HidrycoLib.Faceplates.PID
{
  partial class Faceplate1
  {

    private event EventHandler<Hidryco.HidrycoLib.Symbols.PID.E_ATUALIZA_SAIDA_PIDEventArgs> E_ATUALIZA_SAIDA_PID_Fired;

    private event EventHandler<Hidryco.HidrycoLib.Symbols.PID.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    protected override void OnEndInit()
    {
      if (E_ATUALIZA_SAIDA_PID_Fired != null)
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
          if (E_ATUALIZA_SAIDA_PID_Fired != null)
          {
            try
            {
              E_ATUALIZA_SAIDA_PID_Fired(this, new Hidryco.HidrycoLib.Symbols.PID.E_ATUALIZA_SAIDA_PIDEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","E_ATUALIZA_SAIDA_PID_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 1:
          if (LOAD_PERS_DATA_Fired != null)
          {
            try
            {
              LOAD_PERS_DATA_Fired(this, new Hidryco.HidrycoLib.Symbols.PID.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
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
    public bool FireEvent_E_ATUALIZA_SETPOINT(System.Boolean cmdHabilitaPID, System.Single stpDesejado, System.Single stpKP, System.Single stpKI, System.Single stpKD, System.Single stpMaximo, System.Single stpMinimo)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {cmdHabilitaPID, stpDesejado, stpKP, stpKI, stpKD, stpMaximo, stpMinimo});
    }
    public bool FireEvent_E_ATUALIZA_SETPOINT(Hidryco.HidrycoLib.Symbols.PID.E_ATUALIZA_SETPOINTEventArgs ea)
    {
      object[] _values_ = new object[7];
      if (ea.cmdHabilitaPID.HasValue) _values_[0] = ea.cmdHabilitaPID.Value;
      if (ea.stpDesejado.HasValue) _values_[1] = ea.stpDesejado.Value;
      if (ea.stpKP.HasValue) _values_[2] = ea.stpKP.Value;
      if (ea.stpKI.HasValue) _values_[3] = ea.stpKI.Value;
      if (ea.stpKD.HasValue) _values_[4] = ea.stpKD.Value;
      if (ea.stpMaximo.HasValue) _values_[5] = ea.stpMaximo.Value;
      if (ea.stpMinimo.HasValue) _values_[6] = ea.stpMinimo.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_E_ATUALIZA_SETPOINT(System.Boolean cmdHabilitaPID, bool ignore_cmdHabilitaPID, System.Single stpDesejado, bool ignore_stpDesejado, System.Single stpKP, bool ignore_stpKP, System.Single stpKI, bool ignore_stpKI, System.Single stpKD, bool ignore_stpKD, System.Single stpMaximo, bool ignore_stpMaximo, System.Single stpMinimo, bool ignore_stpMinimo)
    {
      object[] _values_ = new object[7];
      if (!ignore_cmdHabilitaPID) _values_[0] = cmdHabilitaPID;
      if (!ignore_stpDesejado) _values_[1] = stpDesejado;
      if (!ignore_stpKP) _values_[2] = stpKP;
      if (!ignore_stpKI) _values_[3] = stpKI;
      if (!ignore_stpKD) _values_[4] = stpKD;
      if (!ignore_stpMaximo) _values_[5] = stpMaximo;
      if (!ignore_stpMinimo) _values_[6] = stpMinimo;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }

  }
}
#endregion #PID_HMI;

#endregion Definitions;
