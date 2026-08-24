/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 1/26/2026
 * Time: 1:13 PM
 * 
 */
using System;
using NxtControl.GuiFramework;
using NxtControl.Services;

#region Definitions;
#region #Valvula_Saida_Digital_HMI;

namespace Hidryco.HidrycoLib.Symbols.Valvula_Saida_Digital
{

  public class REQEventArgs : System.EventArgs
  {
    IHMIAccessorService accessorService;
    int channelId;
    int cookie; 
    int eventIndex;

    public REQEventArgs(int channelId, int cookie, int eventIndex)
    {
      this.accessorService = (IHMIAccessorService)ServiceProvider.GetService(typeof(IHMIAccessorService));
      this.channelId = channelId;
      this.cookie = cookie;
      this.eventIndex = eventIndex;
    }
    public bool Get_stsRemoto(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,0, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? stsRemoto
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,0, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_stsFalhaComunicacao(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,1, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? stsFalhaComunicacao
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,1, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_ABERTO(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,2, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_ABERTO
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,2, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_FECHADO(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,3, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_FECHADO
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,3, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_ALARME(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,4, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_ALARME
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,4, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }


  }

  public class E_ANIMACAOEventArgs : System.EventArgs
  {
    IHMIAccessorService accessorService;
    int channelId;
    int cookie; 
    int eventIndex;

    public E_ANIMACAOEventArgs(int channelId, int cookie, int eventIndex)
    {
      this.accessorService = (IHMIAccessorService)ServiceProvider.GetService(typeof(IHMIAccessorService));
      this.channelId = channelId;
      this.cookie = cookie;
      this.eventIndex = eventIndex;
    }
    public bool Get_stsAnimacao(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,0, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? stsAnimacao
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,0, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }

    public bool Get_STS_ABERTO(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,1, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_ABERTO
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,1, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_FECHADO(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,2, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_FECHADO
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,2, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_ALARME(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,3, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_ALARME
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,3, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }


  }

  public class E_ATUALIZA_FEEDBACKEventArgs : System.EventArgs
  {
    IHMIAccessorService accessorService;
    int channelId;
    int cookie; 
    int eventIndex;

    public E_ATUALIZA_FEEDBACKEventArgs(int channelId, int cookie, int eventIndex)
    {
      this.accessorService = (IHMIAccessorService)ServiceProvider.GetService(typeof(IHMIAccessorService));
      this.channelId = channelId;
      this.cookie = cookie;
      this.eventIndex = eventIndex;
    }
    public bool Get_fbkStsAutomatico(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,0, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? fbkStsAutomatico
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,0, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_fbkCmdOn(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,1, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? fbkCmdOn
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,1, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_fbkCmdOff(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,2, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? fbkCmdOff
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,2, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }


  }

}

namespace Hidryco.HidrycoLib.Symbols.Valvula_Saida_Digital
{

  public class E_COMANDO_MANUALEventArgs : System.EventArgs
  {
    public E_COMANDO_MANUALEventArgs()
    {
    }
    private System.Boolean? cmdOn_field = null;
    public System.Boolean? cmdOn
    {
       get { return cmdOn_field; }
       set { cmdOn_field = value; }
    }
    private System.Boolean? cmdOff_field = null;
    public System.Boolean? cmdOff
    {
       get { return cmdOff_field; }
       set { cmdOff_field = value; }
    }

  }

  public class E_AJUSTE_SETPOINTSEventArgs : System.EventArgs
  {
    public E_AJUSTE_SETPOINTSEventArgs()
    {
    }
    private System.UInt16? stpTempoFalhaAbertura_field = null;
    public System.UInt16? stpTempoFalhaAbertura
    {
       get { return stpTempoFalhaAbertura_field; }
       set { stpTempoFalhaAbertura_field = value; }
    }
    private System.UInt16? stpTempoFalhaFechamento_field = null;
    public System.UInt16? stpTempoFalhaFechamento
    {
       get { return stpTempoFalhaFechamento_field; }
       set { stpTempoFalhaFechamento_field = value; }
    }

  }

  public class E_RESET_FALHAEventArgs : System.EventArgs
  {
    public E_RESET_FALHAEventArgs()
    {
    }
    private System.Boolean? cmdResetFalhaFeedback_field = null;
    public System.Boolean? cmdResetFalhaFeedback
    {
       get { return cmdResetFalhaFeedback_field; }
       set { cmdResetFalhaFeedback_field = value; }
    }

  }

}

namespace Hidryco.HidrycoLib.Symbols.Valvula_Saida_Digital
{
  partial class sValvulaHorizontal
  {

    private event EventHandler<Hidryco.HidrycoLib.Symbols.Valvula_Saida_Digital.REQEventArgs> REQ_Fired;

    private event EventHandler<Hidryco.HidrycoLib.Symbols.Valvula_Saida_Digital.E_ANIMACAOEventArgs> E_ANIMACAO_Fired;

    private event EventHandler<Hidryco.HidrycoLib.Symbols.Valvula_Saida_Digital.E_ATUALIZA_FEEDBACKEventArgs> E_ATUALIZA_FEEDBACK_Fired;

    protected override void OnEndInit()
    {
      if (REQ_Fired != null)
        AttachEventInput(0);
      if (E_ANIMACAO_Fired != null)
        AttachEventInput(1);
      if (E_ATUALIZA_FEEDBACK_Fired != null)
        AttachEventInput(2);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (REQ_Fired != null)
          {
            try
            {
              REQ_Fired(this, new Hidryco.HidrycoLib.Symbols.Valvula_Saida_Digital.REQEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REQ_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 1:
          if (E_ANIMACAO_Fired != null)
          {
            try
            {
              E_ANIMACAO_Fired(this, new Hidryco.HidrycoLib.Symbols.Valvula_Saida_Digital.E_ANIMACAOEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","E_ANIMACAO_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 2:
          if (E_ATUALIZA_FEEDBACK_Fired != null)
          {
            try
            {
              E_ATUALIZA_FEEDBACK_Fired(this, new Hidryco.HidrycoLib.Symbols.Valvula_Saida_Digital.E_ATUALIZA_FEEDBACKEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","E_ATUALIZA_FEEDBACK_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_E_COMANDO_MANUAL(System.Boolean cmdOn, System.Boolean cmdOff)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {cmdOn, cmdOff});
    }
    public bool FireEvent_E_COMANDO_MANUAL(Hidryco.HidrycoLib.Symbols.Valvula_Saida_Digital.E_COMANDO_MANUALEventArgs ea)
    {
      object[] _values_ = new object[2];
      if (ea.cmdOn.HasValue) _values_[0] = ea.cmdOn.Value;
      if (ea.cmdOff.HasValue) _values_[1] = ea.cmdOff.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_E_COMANDO_MANUAL(System.Boolean cmdOn, bool ignore_cmdOn, System.Boolean cmdOff, bool ignore_cmdOff)
    {
      object[] _values_ = new object[2];
      if (!ignore_cmdOn) _values_[0] = cmdOn;
      if (!ignore_cmdOff) _values_[1] = cmdOff;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_E_AJUSTE_SETPOINTS(System.UInt16 stpTempoFalhaAbertura, System.UInt16 stpTempoFalhaFechamento)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {stpTempoFalhaAbertura, stpTempoFalhaFechamento});
    }
    public bool FireEvent_E_AJUSTE_SETPOINTS(Hidryco.HidrycoLib.Symbols.Valvula_Saida_Digital.E_AJUSTE_SETPOINTSEventArgs ea)
    {
      object[] _values_ = new object[2];
      if (ea.stpTempoFalhaAbertura.HasValue) _values_[0] = ea.stpTempoFalhaAbertura.Value;
      if (ea.stpTempoFalhaFechamento.HasValue) _values_[1] = ea.stpTempoFalhaFechamento.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_E_AJUSTE_SETPOINTS(System.UInt16 stpTempoFalhaAbertura, bool ignore_stpTempoFalhaAbertura, System.UInt16 stpTempoFalhaFechamento, bool ignore_stpTempoFalhaFechamento)
    {
      object[] _values_ = new object[2];
      if (!ignore_stpTempoFalhaAbertura) _values_[0] = stpTempoFalhaAbertura;
      if (!ignore_stpTempoFalhaFechamento) _values_[1] = stpTempoFalhaFechamento;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_E_RESET_FALHA(System.Boolean cmdResetFalhaFeedback)
    {
      return ((IHMIAccessorOutput)this).FireEvent(2, new object[] {cmdResetFalhaFeedback});
    }
    public bool FireEvent_E_RESET_FALHA(Hidryco.HidrycoLib.Symbols.Valvula_Saida_Digital.E_RESET_FALHAEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.cmdResetFalhaFeedback.HasValue) _values_[0] = ea.cmdResetFalhaFeedback.Value;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_E_RESET_FALHA(System.Boolean cmdResetFalhaFeedback, bool ignore_cmdResetFalhaFeedback)
    {
      object[] _values_ = new object[1];
      if (!ignore_cmdResetFalhaFeedback) _values_[0] = cmdResetFalhaFeedback;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }

  }
}

namespace Hidryco.HidrycoLib.Faceplates.Valvula_Saida_Digital
{
  partial class Faceplate1
  {

    private event EventHandler<Hidryco.HidrycoLib.Symbols.Valvula_Saida_Digital.REQEventArgs> REQ_Fired;

    private event EventHandler<Hidryco.HidrycoLib.Symbols.Valvula_Saida_Digital.E_ANIMACAOEventArgs> E_ANIMACAO_Fired;

    private event EventHandler<Hidryco.HidrycoLib.Symbols.Valvula_Saida_Digital.E_ATUALIZA_FEEDBACKEventArgs> E_ATUALIZA_FEEDBACK_Fired;

    protected override void OnEndInit()
    {
      if (REQ_Fired != null)
        AttachEventInput(0);
      if (E_ANIMACAO_Fired != null)
        AttachEventInput(1);
      if (E_ATUALIZA_FEEDBACK_Fired != null)
        AttachEventInput(2);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (REQ_Fired != null)
          {
            try
            {
              REQ_Fired(this, new Hidryco.HidrycoLib.Symbols.Valvula_Saida_Digital.REQEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REQ_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 1:
          if (E_ANIMACAO_Fired != null)
          {
            try
            {
              E_ANIMACAO_Fired(this, new Hidryco.HidrycoLib.Symbols.Valvula_Saida_Digital.E_ANIMACAOEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","E_ANIMACAO_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 2:
          if (E_ATUALIZA_FEEDBACK_Fired != null)
          {
            try
            {
              E_ATUALIZA_FEEDBACK_Fired(this, new Hidryco.HidrycoLib.Symbols.Valvula_Saida_Digital.E_ATUALIZA_FEEDBACKEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","E_ATUALIZA_FEEDBACK_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_E_COMANDO_MANUAL(System.Boolean cmdOn, System.Boolean cmdOff)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {cmdOn, cmdOff});
    }
    public bool FireEvent_E_COMANDO_MANUAL(Hidryco.HidrycoLib.Symbols.Valvula_Saida_Digital.E_COMANDO_MANUALEventArgs ea)
    {
      object[] _values_ = new object[2];
      if (ea.cmdOn.HasValue) _values_[0] = ea.cmdOn.Value;
      if (ea.cmdOff.HasValue) _values_[1] = ea.cmdOff.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_E_COMANDO_MANUAL(System.Boolean cmdOn, bool ignore_cmdOn, System.Boolean cmdOff, bool ignore_cmdOff)
    {
      object[] _values_ = new object[2];
      if (!ignore_cmdOn) _values_[0] = cmdOn;
      if (!ignore_cmdOff) _values_[1] = cmdOff;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_E_AJUSTE_SETPOINTS(System.UInt16 stpTempoFalhaAbertura, System.UInt16 stpTempoFalhaFechamento)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {stpTempoFalhaAbertura, stpTempoFalhaFechamento});
    }
    public bool FireEvent_E_AJUSTE_SETPOINTS(Hidryco.HidrycoLib.Symbols.Valvula_Saida_Digital.E_AJUSTE_SETPOINTSEventArgs ea)
    {
      object[] _values_ = new object[2];
      if (ea.stpTempoFalhaAbertura.HasValue) _values_[0] = ea.stpTempoFalhaAbertura.Value;
      if (ea.stpTempoFalhaFechamento.HasValue) _values_[1] = ea.stpTempoFalhaFechamento.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_E_AJUSTE_SETPOINTS(System.UInt16 stpTempoFalhaAbertura, bool ignore_stpTempoFalhaAbertura, System.UInt16 stpTempoFalhaFechamento, bool ignore_stpTempoFalhaFechamento)
    {
      object[] _values_ = new object[2];
      if (!ignore_stpTempoFalhaAbertura) _values_[0] = stpTempoFalhaAbertura;
      if (!ignore_stpTempoFalhaFechamento) _values_[1] = stpTempoFalhaFechamento;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_E_RESET_FALHA(System.Boolean cmdResetFalhaFeedback)
    {
      return ((IHMIAccessorOutput)this).FireEvent(2, new object[] {cmdResetFalhaFeedback});
    }
    public bool FireEvent_E_RESET_FALHA(Hidryco.HidrycoLib.Symbols.Valvula_Saida_Digital.E_RESET_FALHAEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.cmdResetFalhaFeedback.HasValue) _values_[0] = ea.cmdResetFalhaFeedback.Value;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_E_RESET_FALHA(System.Boolean cmdResetFalhaFeedback, bool ignore_cmdResetFalhaFeedback)
    {
      object[] _values_ = new object[1];
      if (!ignore_cmdResetFalhaFeedback) _values_[0] = cmdResetFalhaFeedback;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }

  }
}

namespace Hidryco.HidrycoLib.Faceplates.Valvula_Saida_Digital
{
  partial class Faceplate2
  {

    private event EventHandler<Hidryco.HidrycoLib.Symbols.Valvula_Saida_Digital.REQEventArgs> REQ_Fired;

    private event EventHandler<Hidryco.HidrycoLib.Symbols.Valvula_Saida_Digital.E_ANIMACAOEventArgs> E_ANIMACAO_Fired;

    private event EventHandler<Hidryco.HidrycoLib.Symbols.Valvula_Saida_Digital.E_ATUALIZA_FEEDBACKEventArgs> E_ATUALIZA_FEEDBACK_Fired;

    protected override void OnEndInit()
    {
      if (REQ_Fired != null)
        AttachEventInput(0);
      if (E_ANIMACAO_Fired != null)
        AttachEventInput(1);
      if (E_ATUALIZA_FEEDBACK_Fired != null)
        AttachEventInput(2);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (REQ_Fired != null)
          {
            try
            {
              REQ_Fired(this, new Hidryco.HidrycoLib.Symbols.Valvula_Saida_Digital.REQEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REQ_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 1:
          if (E_ANIMACAO_Fired != null)
          {
            try
            {
              E_ANIMACAO_Fired(this, new Hidryco.HidrycoLib.Symbols.Valvula_Saida_Digital.E_ANIMACAOEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","E_ANIMACAO_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 2:
          if (E_ATUALIZA_FEEDBACK_Fired != null)
          {
            try
            {
              E_ATUALIZA_FEEDBACK_Fired(this, new Hidryco.HidrycoLib.Symbols.Valvula_Saida_Digital.E_ATUALIZA_FEEDBACKEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","E_ATUALIZA_FEEDBACK_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_E_COMANDO_MANUAL(System.Boolean cmdOn, System.Boolean cmdOff)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {cmdOn, cmdOff});
    }
    public bool FireEvent_E_COMANDO_MANUAL(Hidryco.HidrycoLib.Symbols.Valvula_Saida_Digital.E_COMANDO_MANUALEventArgs ea)
    {
      object[] _values_ = new object[2];
      if (ea.cmdOn.HasValue) _values_[0] = ea.cmdOn.Value;
      if (ea.cmdOff.HasValue) _values_[1] = ea.cmdOff.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_E_COMANDO_MANUAL(System.Boolean cmdOn, bool ignore_cmdOn, System.Boolean cmdOff, bool ignore_cmdOff)
    {
      object[] _values_ = new object[2];
      if (!ignore_cmdOn) _values_[0] = cmdOn;
      if (!ignore_cmdOff) _values_[1] = cmdOff;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_E_AJUSTE_SETPOINTS(System.UInt16 stpTempoFalhaAbertura, System.UInt16 stpTempoFalhaFechamento)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {stpTempoFalhaAbertura, stpTempoFalhaFechamento});
    }
    public bool FireEvent_E_AJUSTE_SETPOINTS(Hidryco.HidrycoLib.Symbols.Valvula_Saida_Digital.E_AJUSTE_SETPOINTSEventArgs ea)
    {
      object[] _values_ = new object[2];
      if (ea.stpTempoFalhaAbertura.HasValue) _values_[0] = ea.stpTempoFalhaAbertura.Value;
      if (ea.stpTempoFalhaFechamento.HasValue) _values_[1] = ea.stpTempoFalhaFechamento.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_E_AJUSTE_SETPOINTS(System.UInt16 stpTempoFalhaAbertura, bool ignore_stpTempoFalhaAbertura, System.UInt16 stpTempoFalhaFechamento, bool ignore_stpTempoFalhaFechamento)
    {
      object[] _values_ = new object[2];
      if (!ignore_stpTempoFalhaAbertura) _values_[0] = stpTempoFalhaAbertura;
      if (!ignore_stpTempoFalhaFechamento) _values_[1] = stpTempoFalhaFechamento;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_E_RESET_FALHA(System.Boolean cmdResetFalhaFeedback)
    {
      return ((IHMIAccessorOutput)this).FireEvent(2, new object[] {cmdResetFalhaFeedback});
    }
    public bool FireEvent_E_RESET_FALHA(Hidryco.HidrycoLib.Symbols.Valvula_Saida_Digital.E_RESET_FALHAEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.cmdResetFalhaFeedback.HasValue) _values_[0] = ea.cmdResetFalhaFeedback.Value;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_E_RESET_FALHA(System.Boolean cmdResetFalhaFeedback, bool ignore_cmdResetFalhaFeedback)
    {
      object[] _values_ = new object[1];
      if (!ignore_cmdResetFalhaFeedback) _values_[0] = cmdResetFalhaFeedback;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }

  }
}

namespace Hidryco.HidrycoLib.Symbols.Valvula_Saida_Digital
{
  partial class Comporta
  {

    private event EventHandler<Hidryco.HidrycoLib.Symbols.Valvula_Saida_Digital.REQEventArgs> REQ_Fired;

    private event EventHandler<Hidryco.HidrycoLib.Symbols.Valvula_Saida_Digital.E_ANIMACAOEventArgs> E_ANIMACAO_Fired;

    private event EventHandler<Hidryco.HidrycoLib.Symbols.Valvula_Saida_Digital.E_ATUALIZA_FEEDBACKEventArgs> E_ATUALIZA_FEEDBACK_Fired;

    protected override void OnEndInit()
    {
      if (REQ_Fired != null)
        AttachEventInput(0);
      if (E_ANIMACAO_Fired != null)
        AttachEventInput(1);
      if (E_ATUALIZA_FEEDBACK_Fired != null)
        AttachEventInput(2);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (REQ_Fired != null)
          {
            try
            {
              REQ_Fired(this, new Hidryco.HidrycoLib.Symbols.Valvula_Saida_Digital.REQEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REQ_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 1:
          if (E_ANIMACAO_Fired != null)
          {
            try
            {
              E_ANIMACAO_Fired(this, new Hidryco.HidrycoLib.Symbols.Valvula_Saida_Digital.E_ANIMACAOEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","E_ANIMACAO_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 2:
          if (E_ATUALIZA_FEEDBACK_Fired != null)
          {
            try
            {
              E_ATUALIZA_FEEDBACK_Fired(this, new Hidryco.HidrycoLib.Symbols.Valvula_Saida_Digital.E_ATUALIZA_FEEDBACKEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","E_ATUALIZA_FEEDBACK_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_E_COMANDO_MANUAL(System.Boolean cmdOn, System.Boolean cmdOff)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {cmdOn, cmdOff});
    }
    public bool FireEvent_E_COMANDO_MANUAL(Hidryco.HidrycoLib.Symbols.Valvula_Saida_Digital.E_COMANDO_MANUALEventArgs ea)
    {
      object[] _values_ = new object[2];
      if (ea.cmdOn.HasValue) _values_[0] = ea.cmdOn.Value;
      if (ea.cmdOff.HasValue) _values_[1] = ea.cmdOff.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_E_COMANDO_MANUAL(System.Boolean cmdOn, bool ignore_cmdOn, System.Boolean cmdOff, bool ignore_cmdOff)
    {
      object[] _values_ = new object[2];
      if (!ignore_cmdOn) _values_[0] = cmdOn;
      if (!ignore_cmdOff) _values_[1] = cmdOff;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_E_AJUSTE_SETPOINTS(System.UInt16 stpTempoFalhaAbertura, System.UInt16 stpTempoFalhaFechamento)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {stpTempoFalhaAbertura, stpTempoFalhaFechamento});
    }
    public bool FireEvent_E_AJUSTE_SETPOINTS(Hidryco.HidrycoLib.Symbols.Valvula_Saida_Digital.E_AJUSTE_SETPOINTSEventArgs ea)
    {
      object[] _values_ = new object[2];
      if (ea.stpTempoFalhaAbertura.HasValue) _values_[0] = ea.stpTempoFalhaAbertura.Value;
      if (ea.stpTempoFalhaFechamento.HasValue) _values_[1] = ea.stpTempoFalhaFechamento.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_E_AJUSTE_SETPOINTS(System.UInt16 stpTempoFalhaAbertura, bool ignore_stpTempoFalhaAbertura, System.UInt16 stpTempoFalhaFechamento, bool ignore_stpTempoFalhaFechamento)
    {
      object[] _values_ = new object[2];
      if (!ignore_stpTempoFalhaAbertura) _values_[0] = stpTempoFalhaAbertura;
      if (!ignore_stpTempoFalhaFechamento) _values_[1] = stpTempoFalhaFechamento;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_E_RESET_FALHA(System.Boolean cmdResetFalhaFeedback)
    {
      return ((IHMIAccessorOutput)this).FireEvent(2, new object[] {cmdResetFalhaFeedback});
    }
    public bool FireEvent_E_RESET_FALHA(Hidryco.HidrycoLib.Symbols.Valvula_Saida_Digital.E_RESET_FALHAEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.cmdResetFalhaFeedback.HasValue) _values_[0] = ea.cmdResetFalhaFeedback.Value;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_E_RESET_FALHA(System.Boolean cmdResetFalhaFeedback, bool ignore_cmdResetFalhaFeedback)
    {
      object[] _values_ = new object[1];
      if (!ignore_cmdResetFalhaFeedback) _values_[0] = cmdResetFalhaFeedback;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }

  }
}

namespace Hidryco.HidrycoLib.Symbols.Valvula_Saida_Digital
{
  partial class sValvulaVertical
  {

    private event EventHandler<Hidryco.HidrycoLib.Symbols.Valvula_Saida_Digital.REQEventArgs> REQ_Fired;

    private event EventHandler<Hidryco.HidrycoLib.Symbols.Valvula_Saida_Digital.E_ANIMACAOEventArgs> E_ANIMACAO_Fired;

    private event EventHandler<Hidryco.HidrycoLib.Symbols.Valvula_Saida_Digital.E_ATUALIZA_FEEDBACKEventArgs> E_ATUALIZA_FEEDBACK_Fired;

    protected override void OnEndInit()
    {
      if (REQ_Fired != null)
        AttachEventInput(0);
      if (E_ANIMACAO_Fired != null)
        AttachEventInput(1);
      if (E_ATUALIZA_FEEDBACK_Fired != null)
        AttachEventInput(2);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (REQ_Fired != null)
          {
            try
            {
              REQ_Fired(this, new Hidryco.HidrycoLib.Symbols.Valvula_Saida_Digital.REQEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REQ_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 1:
          if (E_ANIMACAO_Fired != null)
          {
            try
            {
              E_ANIMACAO_Fired(this, new Hidryco.HidrycoLib.Symbols.Valvula_Saida_Digital.E_ANIMACAOEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","E_ANIMACAO_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 2:
          if (E_ATUALIZA_FEEDBACK_Fired != null)
          {
            try
            {
              E_ATUALIZA_FEEDBACK_Fired(this, new Hidryco.HidrycoLib.Symbols.Valvula_Saida_Digital.E_ATUALIZA_FEEDBACKEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","E_ATUALIZA_FEEDBACK_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_E_COMANDO_MANUAL(System.Boolean cmdOn, System.Boolean cmdOff)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {cmdOn, cmdOff});
    }
    public bool FireEvent_E_COMANDO_MANUAL(Hidryco.HidrycoLib.Symbols.Valvula_Saida_Digital.E_COMANDO_MANUALEventArgs ea)
    {
      object[] _values_ = new object[2];
      if (ea.cmdOn.HasValue) _values_[0] = ea.cmdOn.Value;
      if (ea.cmdOff.HasValue) _values_[1] = ea.cmdOff.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_E_COMANDO_MANUAL(System.Boolean cmdOn, bool ignore_cmdOn, System.Boolean cmdOff, bool ignore_cmdOff)
    {
      object[] _values_ = new object[2];
      if (!ignore_cmdOn) _values_[0] = cmdOn;
      if (!ignore_cmdOff) _values_[1] = cmdOff;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_E_AJUSTE_SETPOINTS(System.UInt16 stpTempoFalhaAbertura, System.UInt16 stpTempoFalhaFechamento)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {stpTempoFalhaAbertura, stpTempoFalhaFechamento});
    }
    public bool FireEvent_E_AJUSTE_SETPOINTS(Hidryco.HidrycoLib.Symbols.Valvula_Saida_Digital.E_AJUSTE_SETPOINTSEventArgs ea)
    {
      object[] _values_ = new object[2];
      if (ea.stpTempoFalhaAbertura.HasValue) _values_[0] = ea.stpTempoFalhaAbertura.Value;
      if (ea.stpTempoFalhaFechamento.HasValue) _values_[1] = ea.stpTempoFalhaFechamento.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_E_AJUSTE_SETPOINTS(System.UInt16 stpTempoFalhaAbertura, bool ignore_stpTempoFalhaAbertura, System.UInt16 stpTempoFalhaFechamento, bool ignore_stpTempoFalhaFechamento)
    {
      object[] _values_ = new object[2];
      if (!ignore_stpTempoFalhaAbertura) _values_[0] = stpTempoFalhaAbertura;
      if (!ignore_stpTempoFalhaFechamento) _values_[1] = stpTempoFalhaFechamento;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_E_RESET_FALHA(System.Boolean cmdResetFalhaFeedback)
    {
      return ((IHMIAccessorOutput)this).FireEvent(2, new object[] {cmdResetFalhaFeedback});
    }
    public bool FireEvent_E_RESET_FALHA(Hidryco.HidrycoLib.Symbols.Valvula_Saida_Digital.E_RESET_FALHAEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.cmdResetFalhaFeedback.HasValue) _values_[0] = ea.cmdResetFalhaFeedback.Value;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_E_RESET_FALHA(System.Boolean cmdResetFalhaFeedback, bool ignore_cmdResetFalhaFeedback)
    {
      object[] _values_ = new object[1];
      if (!ignore_cmdResetFalhaFeedback) _values_[0] = cmdResetFalhaFeedback;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }

  }
}
#endregion #Valvula_Saida_Digital_HMI;

#endregion Definitions;
