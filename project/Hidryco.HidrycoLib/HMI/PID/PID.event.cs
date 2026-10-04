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
    private System.Boolean? CMD_HABILITA_field = null;
    public System.Boolean? CMD_HABILITA
    {
       get { return CMD_HABILITA_field; }
       set { CMD_HABILITA_field = value; }
    }
    private System.Single? STP_DESEJADO_field = null;
    public System.Single? STP_DESEJADO
    {
       get { return STP_DESEJADO_field; }
       set { STP_DESEJADO_field = value; }
    }
    private System.Single? STP_PARAMETRO_KP_field = null;
    public System.Single? STP_PARAMETRO_KP
    {
       get { return STP_PARAMETRO_KP_field; }
       set { STP_PARAMETRO_KP_field = value; }
    }
    private System.Single? STP_PARAMETRO_KI_field = null;
    public System.Single? STP_PARAMETRO_KI
    {
       get { return STP_PARAMETRO_KI_field; }
       set { STP_PARAMETRO_KI_field = value; }
    }
    private System.Single? STP_PARAMETRO_KD_field = null;
    public System.Single? STP_PARAMETRO_KD
    {
       get { return STP_PARAMETRO_KD_field; }
       set { STP_PARAMETRO_KD_field = value; }
    }
    private System.Single? STP_MAXIMO_field = null;
    public System.Single? STP_MAXIMO
    {
       get { return STP_MAXIMO_field; }
       set { STP_MAXIMO_field = value; }
    }
    private System.Single? STP_MINIMO_field = null;
    public System.Single? STP_MINIMO
    {
       get { return STP_MINIMO_field; }
       set { STP_MINIMO_field = value; }
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
    public bool FireEvent_E_ATUALIZA_SETPOINT(System.Boolean CMD_HABILITA, System.Single STP_DESEJADO, System.Single STP_PARAMETRO_KP, System.Single STP_PARAMETRO_KI, System.Single STP_PARAMETRO_KD, System.Single STP_MAXIMO, System.Single STP_MINIMO)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {CMD_HABILITA, STP_DESEJADO, STP_PARAMETRO_KP, STP_PARAMETRO_KI, STP_PARAMETRO_KD, STP_MAXIMO, STP_MINIMO});
    }
    public bool FireEvent_E_ATUALIZA_SETPOINT(Hidryco.HidrycoLib.Symbols.PID.E_ATUALIZA_SETPOINTEventArgs ea)
    {
      object[] _values_ = new object[7];
      if (ea.CMD_HABILITA.HasValue) _values_[0] = ea.CMD_HABILITA.Value;
      if (ea.STP_DESEJADO.HasValue) _values_[1] = ea.STP_DESEJADO.Value;
      if (ea.STP_PARAMETRO_KP.HasValue) _values_[2] = ea.STP_PARAMETRO_KP.Value;
      if (ea.STP_PARAMETRO_KI.HasValue) _values_[3] = ea.STP_PARAMETRO_KI.Value;
      if (ea.STP_PARAMETRO_KD.HasValue) _values_[4] = ea.STP_PARAMETRO_KD.Value;
      if (ea.STP_MAXIMO.HasValue) _values_[5] = ea.STP_MAXIMO.Value;
      if (ea.STP_MINIMO.HasValue) _values_[6] = ea.STP_MINIMO.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_E_ATUALIZA_SETPOINT(System.Boolean CMD_HABILITA, bool ignore_CMD_HABILITA, System.Single STP_DESEJADO, bool ignore_STP_DESEJADO, System.Single STP_PARAMETRO_KP, bool ignore_STP_PARAMETRO_KP, System.Single STP_PARAMETRO_KI, bool ignore_STP_PARAMETRO_KI, System.Single STP_PARAMETRO_KD, bool ignore_STP_PARAMETRO_KD, System.Single STP_MAXIMO, bool ignore_STP_MAXIMO, System.Single STP_MINIMO, bool ignore_STP_MINIMO)
    {
      object[] _values_ = new object[7];
      if (!ignore_CMD_HABILITA) _values_[0] = CMD_HABILITA;
      if (!ignore_STP_DESEJADO) _values_[1] = STP_DESEJADO;
      if (!ignore_STP_PARAMETRO_KP) _values_[2] = STP_PARAMETRO_KP;
      if (!ignore_STP_PARAMETRO_KI) _values_[3] = STP_PARAMETRO_KI;
      if (!ignore_STP_PARAMETRO_KD) _values_[4] = STP_PARAMETRO_KD;
      if (!ignore_STP_MAXIMO) _values_[5] = STP_MAXIMO;
      if (!ignore_STP_MINIMO) _values_[6] = STP_MINIMO;
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
    public bool FireEvent_E_ATUALIZA_SETPOINT(System.Boolean CMD_HABILITA, System.Single STP_DESEJADO, System.Single STP_PARAMETRO_KP, System.Single STP_PARAMETRO_KI, System.Single STP_PARAMETRO_KD, System.Single STP_MAXIMO, System.Single STP_MINIMO)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {CMD_HABILITA, STP_DESEJADO, STP_PARAMETRO_KP, STP_PARAMETRO_KI, STP_PARAMETRO_KD, STP_MAXIMO, STP_MINIMO});
    }
    public bool FireEvent_E_ATUALIZA_SETPOINT(Hidryco.HidrycoLib.Symbols.PID.E_ATUALIZA_SETPOINTEventArgs ea)
    {
      object[] _values_ = new object[7];
      if (ea.CMD_HABILITA.HasValue) _values_[0] = ea.CMD_HABILITA.Value;
      if (ea.STP_DESEJADO.HasValue) _values_[1] = ea.STP_DESEJADO.Value;
      if (ea.STP_PARAMETRO_KP.HasValue) _values_[2] = ea.STP_PARAMETRO_KP.Value;
      if (ea.STP_PARAMETRO_KI.HasValue) _values_[3] = ea.STP_PARAMETRO_KI.Value;
      if (ea.STP_PARAMETRO_KD.HasValue) _values_[4] = ea.STP_PARAMETRO_KD.Value;
      if (ea.STP_MAXIMO.HasValue) _values_[5] = ea.STP_MAXIMO.Value;
      if (ea.STP_MINIMO.HasValue) _values_[6] = ea.STP_MINIMO.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_E_ATUALIZA_SETPOINT(System.Boolean CMD_HABILITA, bool ignore_CMD_HABILITA, System.Single STP_DESEJADO, bool ignore_STP_DESEJADO, System.Single STP_PARAMETRO_KP, bool ignore_STP_PARAMETRO_KP, System.Single STP_PARAMETRO_KI, bool ignore_STP_PARAMETRO_KI, System.Single STP_PARAMETRO_KD, bool ignore_STP_PARAMETRO_KD, System.Single STP_MAXIMO, bool ignore_STP_MAXIMO, System.Single STP_MINIMO, bool ignore_STP_MINIMO)
    {
      object[] _values_ = new object[7];
      if (!ignore_CMD_HABILITA) _values_[0] = CMD_HABILITA;
      if (!ignore_STP_DESEJADO) _values_[1] = STP_DESEJADO;
      if (!ignore_STP_PARAMETRO_KP) _values_[2] = STP_PARAMETRO_KP;
      if (!ignore_STP_PARAMETRO_KI) _values_[3] = STP_PARAMETRO_KI;
      if (!ignore_STP_PARAMETRO_KD) _values_[4] = STP_PARAMETRO_KD;
      if (!ignore_STP_MAXIMO) _values_[5] = STP_MAXIMO;
      if (!ignore_STP_MINIMO) _values_[6] = STP_MINIMO;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }

  }
}
#endregion #PID_HMI;

#endregion Definitions;
