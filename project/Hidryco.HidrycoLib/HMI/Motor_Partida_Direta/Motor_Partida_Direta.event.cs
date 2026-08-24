/*
 * Criado pelo EcoStruxure Automation Expert.
 * Usuário:  
 * Data: 15/01/2026
 * Tempo: 13:27
 * 
 */
using System;
using NxtControl.GuiFramework;
using NxtControl.Services;

#region Definitions;
#region #Motor_Partida_Direta_HMI;

namespace Hidryco.HidrycoLib.Symbols.Motor_Partida_Direta
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
    public bool Get_STS_REMOTO(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,0, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_REMOTO
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,0, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_ANIMACAO(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,1, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? STS_ANIMACAO
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,1, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }

    public bool Get_STS_NUMERO_PARTIDA(ref System.UInt32 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,2, ref var);
      if (ret) value = (System.UInt32) var;
      return ret;
    }

    public System.UInt32? STS_NUMERO_PARTIDA
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,2, ref var);
      if (!ret) return null;
      return (System.UInt32) var;
    }  }

    public bool Get_STS_HORIMETRO_HORA(ref System.UInt32 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,3, ref var);
      if (ret) value = (System.UInt32) var;
      return ret;
    }

    public System.UInt32? STS_HORIMETRO_HORA
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,3, ref var);
      if (!ret) return null;
      return (System.UInt32) var;
    }  }

    public bool Get_fbkStsAutomatico(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,4, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? fbkStsAutomatico
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,4, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_fbkCmdManual(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,5, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? fbkCmdManual
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,5, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_PROTECAO_TERMICA(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,6, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_PROTECAO_TERMICA
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,6, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_ANIMACAO_GERADOR(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,7, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? STS_ANIMACAO_GERADOR
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,7, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }

    public bool Get_STS_LIGADO(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,8, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_LIGADO
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,8, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_ALARME(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,9, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_ALARME
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,9, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }


  }

}

namespace Hidryco.HidrycoLib.Symbols.Motor_Partida_Direta
{

  public class E_RESET_FALHAEventArgs : System.EventArgs
  {
    public E_RESET_FALHAEventArgs()
    {
    }
    private System.Boolean? cmdResetFalha_field = null;
    public System.Boolean? cmdResetFalha
    {
       get { return cmdResetFalha_field; }
       set { cmdResetFalha_field = value; }
    }

  }

  public class E_RESET_HORIMETROEventArgs : System.EventArgs
  {
    public E_RESET_HORIMETROEventArgs()
    {
    }
    private System.Boolean? cmdResetHorimetro_field = null;
    public System.Boolean? cmdResetHorimetro
    {
       get { return cmdResetHorimetro_field; }
       set { cmdResetHorimetro_field = value; }
    }

  }

  public class E_RESET_NUMERO_PARTIDASEventArgs : System.EventArgs
  {
    public E_RESET_NUMERO_PARTIDASEventArgs()
    {
    }
    private System.Boolean? cmdResetNumeroPartida_field = null;
    public System.Boolean? cmdResetNumeroPartida
    {
       get { return cmdResetNumeroPartida_field; }
       set { cmdResetNumeroPartida_field = value; }
    }

  }

  public class E_STS_AUTOMATICOEventArgs : System.EventArgs
  {
    public E_STS_AUTOMATICOEventArgs()
    {
    }
    private System.Boolean? stsAutomatico_field = null;
    public System.Boolean? stsAutomatico
    {
       get { return stsAutomatico_field; }
       set { stsAutomatico_field = value; }
    }

  }

  public class E_CMD_MANUALEventArgs : System.EventArgs
  {
    public E_CMD_MANUALEventArgs()
    {
    }
    private System.Boolean? cmdManual_field = null;
    public System.Boolean? cmdManual
    {
       get { return cmdManual_field; }
       set { cmdManual_field = value; }
    }

  }

  public class E_AJUSTE_STPEventArgs : System.EventArgs
  {
    public E_AJUSTE_STPEventArgs()
    {
    }
    private System.UInt16? stpTempoFalhaLigamento_field = null;
    public System.UInt16? stpTempoFalhaLigamento
    {
       get { return stpTempoFalhaLigamento_field; }
       set { stpTempoFalhaLigamento_field = value; }
    }
    private System.UInt16? stpTempoFalhaDesligamento_field = null;
    public System.UInt16? stpTempoFalhaDesligamento
    {
       get { return stpTempoFalhaDesligamento_field; }
       set { stpTempoFalhaDesligamento_field = value; }
    }

  }

}

namespace Hidryco.HidrycoLib.Faceplates.Motor_Partida_Direta
{
  partial class Faceplate1
  {

    private event EventHandler<Hidryco.HidrycoLib.Symbols.Motor_Partida_Direta.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    private event EventHandler<Hidryco.HidrycoLib.Symbols.Motor_Partida_Direta.REQEventArgs> REQ_Fired;

    protected override void OnEndInit()
    {
      if (LOAD_PERS_DATA_Fired != null)
        AttachEventInput(0);
      if (REQ_Fired != null)
        AttachEventInput(1);

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
              LOAD_PERS_DATA_Fired(this, new Hidryco.HidrycoLib.Symbols.Motor_Partida_Direta.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
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
          if (REQ_Fired != null)
          {
            try
            {
              REQ_Fired(this, new Hidryco.HidrycoLib.Symbols.Motor_Partida_Direta.REQEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REQ_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_E_RESET_FALHA(System.Boolean cmdResetFalha)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {cmdResetFalha});
    }
    public bool FireEvent_E_RESET_FALHA(Hidryco.HidrycoLib.Symbols.Motor_Partida_Direta.E_RESET_FALHAEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.cmdResetFalha.HasValue) _values_[0] = ea.cmdResetFalha.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_E_RESET_FALHA(System.Boolean cmdResetFalha, bool ignore_cmdResetFalha)
    {
      object[] _values_ = new object[1];
      if (!ignore_cmdResetFalha) _values_[0] = cmdResetFalha;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_E_RESET_HORIMETRO(System.Boolean cmdResetHorimetro)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {cmdResetHorimetro});
    }
    public bool FireEvent_E_RESET_HORIMETRO(Hidryco.HidrycoLib.Symbols.Motor_Partida_Direta.E_RESET_HORIMETROEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.cmdResetHorimetro.HasValue) _values_[0] = ea.cmdResetHorimetro.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_E_RESET_HORIMETRO(System.Boolean cmdResetHorimetro, bool ignore_cmdResetHorimetro)
    {
      object[] _values_ = new object[1];
      if (!ignore_cmdResetHorimetro) _values_[0] = cmdResetHorimetro;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_E_RESET_NUMERO_PARTIDAS(System.Boolean cmdResetNumeroPartida)
    {
      return ((IHMIAccessorOutput)this).FireEvent(2, new object[] {cmdResetNumeroPartida});
    }
    public bool FireEvent_E_RESET_NUMERO_PARTIDAS(Hidryco.HidrycoLib.Symbols.Motor_Partida_Direta.E_RESET_NUMERO_PARTIDASEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.cmdResetNumeroPartida.HasValue) _values_[0] = ea.cmdResetNumeroPartida.Value;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_E_RESET_NUMERO_PARTIDAS(System.Boolean cmdResetNumeroPartida, bool ignore_cmdResetNumeroPartida)
    {
      object[] _values_ = new object[1];
      if (!ignore_cmdResetNumeroPartida) _values_[0] = cmdResetNumeroPartida;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_E_STS_AUTOMATICO(System.Boolean stsAutomatico)
    {
      return ((IHMIAccessorOutput)this).FireEvent(3, new object[] {stsAutomatico});
    }
    public bool FireEvent_E_STS_AUTOMATICO(Hidryco.HidrycoLib.Symbols.Motor_Partida_Direta.E_STS_AUTOMATICOEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.stsAutomatico.HasValue) _values_[0] = ea.stsAutomatico.Value;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_E_STS_AUTOMATICO(System.Boolean stsAutomatico, bool ignore_stsAutomatico)
    {
      object[] _values_ = new object[1];
      if (!ignore_stsAutomatico) _values_[0] = stsAutomatico;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_E_CMD_MANUAL(System.Boolean cmdManual)
    {
      return ((IHMIAccessorOutput)this).FireEvent(4, new object[] {cmdManual});
    }
    public bool FireEvent_E_CMD_MANUAL(Hidryco.HidrycoLib.Symbols.Motor_Partida_Direta.E_CMD_MANUALEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.cmdManual.HasValue) _values_[0] = ea.cmdManual.Value;
      return ((IHMIAccessorOutput)this).FireEvent(4, _values_);
    }
    public bool FireEvent_E_CMD_MANUAL(System.Boolean cmdManual, bool ignore_cmdManual)
    {
      object[] _values_ = new object[1];
      if (!ignore_cmdManual) _values_[0] = cmdManual;
      return ((IHMIAccessorOutput)this).FireEvent(4, _values_);
    }
    public bool FireEvent_E_AJUSTE_STP(System.UInt16 stpTempoFalhaLigamento, System.UInt16 stpTempoFalhaDesligamento)
    {
      return ((IHMIAccessorOutput)this).FireEvent(5, new object[] {stpTempoFalhaLigamento, stpTempoFalhaDesligamento});
    }
    public bool FireEvent_E_AJUSTE_STP(Hidryco.HidrycoLib.Symbols.Motor_Partida_Direta.E_AJUSTE_STPEventArgs ea)
    {
      object[] _values_ = new object[2];
      if (ea.stpTempoFalhaLigamento.HasValue) _values_[0] = ea.stpTempoFalhaLigamento.Value;
      if (ea.stpTempoFalhaDesligamento.HasValue) _values_[1] = ea.stpTempoFalhaDesligamento.Value;
      return ((IHMIAccessorOutput)this).FireEvent(5, _values_);
    }
    public bool FireEvent_E_AJUSTE_STP(System.UInt16 stpTempoFalhaLigamento, bool ignore_stpTempoFalhaLigamento, System.UInt16 stpTempoFalhaDesligamento, bool ignore_stpTempoFalhaDesligamento)
    {
      object[] _values_ = new object[2];
      if (!ignore_stpTempoFalhaLigamento) _values_[0] = stpTempoFalhaLigamento;
      if (!ignore_stpTempoFalhaDesligamento) _values_[1] = stpTempoFalhaDesligamento;
      return ((IHMIAccessorOutput)this).FireEvent(5, _values_);
    }

  }
}

namespace Hidryco.HidrycoLib.Symbols.Motor_Partida_Direta
{
  partial class sBomba
  {

    private event EventHandler<Hidryco.HidrycoLib.Symbols.Motor_Partida_Direta.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    private event EventHandler<Hidryco.HidrycoLib.Symbols.Motor_Partida_Direta.REQEventArgs> REQ_Fired;

    protected override void OnEndInit()
    {
      if (LOAD_PERS_DATA_Fired != null)
        AttachEventInput(0);
      if (REQ_Fired != null)
        AttachEventInput(1);

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
              LOAD_PERS_DATA_Fired(this, new Hidryco.HidrycoLib.Symbols.Motor_Partida_Direta.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
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
          if (REQ_Fired != null)
          {
            try
            {
              REQ_Fired(this, new Hidryco.HidrycoLib.Symbols.Motor_Partida_Direta.REQEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REQ_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_E_RESET_FALHA(System.Boolean cmdResetFalha)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {cmdResetFalha});
    }
    public bool FireEvent_E_RESET_FALHA(Hidryco.HidrycoLib.Symbols.Motor_Partida_Direta.E_RESET_FALHAEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.cmdResetFalha.HasValue) _values_[0] = ea.cmdResetFalha.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_E_RESET_FALHA(System.Boolean cmdResetFalha, bool ignore_cmdResetFalha)
    {
      object[] _values_ = new object[1];
      if (!ignore_cmdResetFalha) _values_[0] = cmdResetFalha;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_E_RESET_HORIMETRO(System.Boolean cmdResetHorimetro)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {cmdResetHorimetro});
    }
    public bool FireEvent_E_RESET_HORIMETRO(Hidryco.HidrycoLib.Symbols.Motor_Partida_Direta.E_RESET_HORIMETROEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.cmdResetHorimetro.HasValue) _values_[0] = ea.cmdResetHorimetro.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_E_RESET_HORIMETRO(System.Boolean cmdResetHorimetro, bool ignore_cmdResetHorimetro)
    {
      object[] _values_ = new object[1];
      if (!ignore_cmdResetHorimetro) _values_[0] = cmdResetHorimetro;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_E_RESET_NUMERO_PARTIDAS(System.Boolean cmdResetNumeroPartida)
    {
      return ((IHMIAccessorOutput)this).FireEvent(2, new object[] {cmdResetNumeroPartida});
    }
    public bool FireEvent_E_RESET_NUMERO_PARTIDAS(Hidryco.HidrycoLib.Symbols.Motor_Partida_Direta.E_RESET_NUMERO_PARTIDASEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.cmdResetNumeroPartida.HasValue) _values_[0] = ea.cmdResetNumeroPartida.Value;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_E_RESET_NUMERO_PARTIDAS(System.Boolean cmdResetNumeroPartida, bool ignore_cmdResetNumeroPartida)
    {
      object[] _values_ = new object[1];
      if (!ignore_cmdResetNumeroPartida) _values_[0] = cmdResetNumeroPartida;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_E_STS_AUTOMATICO(System.Boolean stsAutomatico)
    {
      return ((IHMIAccessorOutput)this).FireEvent(3, new object[] {stsAutomatico});
    }
    public bool FireEvent_E_STS_AUTOMATICO(Hidryco.HidrycoLib.Symbols.Motor_Partida_Direta.E_STS_AUTOMATICOEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.stsAutomatico.HasValue) _values_[0] = ea.stsAutomatico.Value;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_E_STS_AUTOMATICO(System.Boolean stsAutomatico, bool ignore_stsAutomatico)
    {
      object[] _values_ = new object[1];
      if (!ignore_stsAutomatico) _values_[0] = stsAutomatico;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_E_CMD_MANUAL(System.Boolean cmdManual)
    {
      return ((IHMIAccessorOutput)this).FireEvent(4, new object[] {cmdManual});
    }
    public bool FireEvent_E_CMD_MANUAL(Hidryco.HidrycoLib.Symbols.Motor_Partida_Direta.E_CMD_MANUALEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.cmdManual.HasValue) _values_[0] = ea.cmdManual.Value;
      return ((IHMIAccessorOutput)this).FireEvent(4, _values_);
    }
    public bool FireEvent_E_CMD_MANUAL(System.Boolean cmdManual, bool ignore_cmdManual)
    {
      object[] _values_ = new object[1];
      if (!ignore_cmdManual) _values_[0] = cmdManual;
      return ((IHMIAccessorOutput)this).FireEvent(4, _values_);
    }
    public bool FireEvent_E_AJUSTE_STP(System.UInt16 stpTempoFalhaLigamento, System.UInt16 stpTempoFalhaDesligamento)
    {
      return ((IHMIAccessorOutput)this).FireEvent(5, new object[] {stpTempoFalhaLigamento, stpTempoFalhaDesligamento});
    }
    public bool FireEvent_E_AJUSTE_STP(Hidryco.HidrycoLib.Symbols.Motor_Partida_Direta.E_AJUSTE_STPEventArgs ea)
    {
      object[] _values_ = new object[2];
      if (ea.stpTempoFalhaLigamento.HasValue) _values_[0] = ea.stpTempoFalhaLigamento.Value;
      if (ea.stpTempoFalhaDesligamento.HasValue) _values_[1] = ea.stpTempoFalhaDesligamento.Value;
      return ((IHMIAccessorOutput)this).FireEvent(5, _values_);
    }
    public bool FireEvent_E_AJUSTE_STP(System.UInt16 stpTempoFalhaLigamento, bool ignore_stpTempoFalhaLigamento, System.UInt16 stpTempoFalhaDesligamento, bool ignore_stpTempoFalhaDesligamento)
    {
      object[] _values_ = new object[2];
      if (!ignore_stpTempoFalhaLigamento) _values_[0] = stpTempoFalhaLigamento;
      if (!ignore_stpTempoFalhaDesligamento) _values_[1] = stpTempoFalhaDesligamento;
      return ((IHMIAccessorOutput)this).FireEvent(5, _values_);
    }

  }
}

namespace Hidryco.HidrycoLib.Faceplates.Motor_Partida_Direta
{
  partial class Faceplate2
  {

    private event EventHandler<Hidryco.HidrycoLib.Symbols.Motor_Partida_Direta.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    private event EventHandler<Hidryco.HidrycoLib.Symbols.Motor_Partida_Direta.REQEventArgs> REQ_Fired;

    protected override void OnEndInit()
    {
      if (LOAD_PERS_DATA_Fired != null)
        AttachEventInput(0);
      if (REQ_Fired != null)
        AttachEventInput(1);

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
              LOAD_PERS_DATA_Fired(this, new Hidryco.HidrycoLib.Symbols.Motor_Partida_Direta.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
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
          if (REQ_Fired != null)
          {
            try
            {
              REQ_Fired(this, new Hidryco.HidrycoLib.Symbols.Motor_Partida_Direta.REQEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REQ_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_E_RESET_FALHA(System.Boolean cmdResetFalha)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {cmdResetFalha});
    }
    public bool FireEvent_E_RESET_FALHA(Hidryco.HidrycoLib.Symbols.Motor_Partida_Direta.E_RESET_FALHAEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.cmdResetFalha.HasValue) _values_[0] = ea.cmdResetFalha.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_E_RESET_FALHA(System.Boolean cmdResetFalha, bool ignore_cmdResetFalha)
    {
      object[] _values_ = new object[1];
      if (!ignore_cmdResetFalha) _values_[0] = cmdResetFalha;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_E_RESET_HORIMETRO(System.Boolean cmdResetHorimetro)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {cmdResetHorimetro});
    }
    public bool FireEvent_E_RESET_HORIMETRO(Hidryco.HidrycoLib.Symbols.Motor_Partida_Direta.E_RESET_HORIMETROEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.cmdResetHorimetro.HasValue) _values_[0] = ea.cmdResetHorimetro.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_E_RESET_HORIMETRO(System.Boolean cmdResetHorimetro, bool ignore_cmdResetHorimetro)
    {
      object[] _values_ = new object[1];
      if (!ignore_cmdResetHorimetro) _values_[0] = cmdResetHorimetro;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_E_RESET_NUMERO_PARTIDAS(System.Boolean cmdResetNumeroPartida)
    {
      return ((IHMIAccessorOutput)this).FireEvent(2, new object[] {cmdResetNumeroPartida});
    }
    public bool FireEvent_E_RESET_NUMERO_PARTIDAS(Hidryco.HidrycoLib.Symbols.Motor_Partida_Direta.E_RESET_NUMERO_PARTIDASEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.cmdResetNumeroPartida.HasValue) _values_[0] = ea.cmdResetNumeroPartida.Value;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_E_RESET_NUMERO_PARTIDAS(System.Boolean cmdResetNumeroPartida, bool ignore_cmdResetNumeroPartida)
    {
      object[] _values_ = new object[1];
      if (!ignore_cmdResetNumeroPartida) _values_[0] = cmdResetNumeroPartida;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_E_STS_AUTOMATICO(System.Boolean stsAutomatico)
    {
      return ((IHMIAccessorOutput)this).FireEvent(3, new object[] {stsAutomatico});
    }
    public bool FireEvent_E_STS_AUTOMATICO(Hidryco.HidrycoLib.Symbols.Motor_Partida_Direta.E_STS_AUTOMATICOEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.stsAutomatico.HasValue) _values_[0] = ea.stsAutomatico.Value;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_E_STS_AUTOMATICO(System.Boolean stsAutomatico, bool ignore_stsAutomatico)
    {
      object[] _values_ = new object[1];
      if (!ignore_stsAutomatico) _values_[0] = stsAutomatico;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_E_CMD_MANUAL(System.Boolean cmdManual)
    {
      return ((IHMIAccessorOutput)this).FireEvent(4, new object[] {cmdManual});
    }
    public bool FireEvent_E_CMD_MANUAL(Hidryco.HidrycoLib.Symbols.Motor_Partida_Direta.E_CMD_MANUALEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.cmdManual.HasValue) _values_[0] = ea.cmdManual.Value;
      return ((IHMIAccessorOutput)this).FireEvent(4, _values_);
    }
    public bool FireEvent_E_CMD_MANUAL(System.Boolean cmdManual, bool ignore_cmdManual)
    {
      object[] _values_ = new object[1];
      if (!ignore_cmdManual) _values_[0] = cmdManual;
      return ((IHMIAccessorOutput)this).FireEvent(4, _values_);
    }
    public bool FireEvent_E_AJUSTE_STP(System.UInt16 stpTempoFalhaLigamento, System.UInt16 stpTempoFalhaDesligamento)
    {
      return ((IHMIAccessorOutput)this).FireEvent(5, new object[] {stpTempoFalhaLigamento, stpTempoFalhaDesligamento});
    }
    public bool FireEvent_E_AJUSTE_STP(Hidryco.HidrycoLib.Symbols.Motor_Partida_Direta.E_AJUSTE_STPEventArgs ea)
    {
      object[] _values_ = new object[2];
      if (ea.stpTempoFalhaLigamento.HasValue) _values_[0] = ea.stpTempoFalhaLigamento.Value;
      if (ea.stpTempoFalhaDesligamento.HasValue) _values_[1] = ea.stpTempoFalhaDesligamento.Value;
      return ((IHMIAccessorOutput)this).FireEvent(5, _values_);
    }
    public bool FireEvent_E_AJUSTE_STP(System.UInt16 stpTempoFalhaLigamento, bool ignore_stpTempoFalhaLigamento, System.UInt16 stpTempoFalhaDesligamento, bool ignore_stpTempoFalhaDesligamento)
    {
      object[] _values_ = new object[2];
      if (!ignore_stpTempoFalhaLigamento) _values_[0] = stpTempoFalhaLigamento;
      if (!ignore_stpTempoFalhaDesligamento) _values_[1] = stpTempoFalhaDesligamento;
      return ((IHMIAccessorOutput)this).FireEvent(5, _values_);
    }

  }
}

namespace Hidryco.HidrycoLib.Faceplates.Motor_Partida_Direta
{
  partial class Faceplate3
  {

    private event EventHandler<Hidryco.HidrycoLib.Symbols.Motor_Partida_Direta.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    private event EventHandler<Hidryco.HidrycoLib.Symbols.Motor_Partida_Direta.REQEventArgs> REQ_Fired;

    protected override void OnEndInit()
    {
      if (LOAD_PERS_DATA_Fired != null)
        AttachEventInput(0);
      if (REQ_Fired != null)
        AttachEventInput(1);

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
              LOAD_PERS_DATA_Fired(this, new Hidryco.HidrycoLib.Symbols.Motor_Partida_Direta.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
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
          if (REQ_Fired != null)
          {
            try
            {
              REQ_Fired(this, new Hidryco.HidrycoLib.Symbols.Motor_Partida_Direta.REQEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REQ_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_E_RESET_FALHA(System.Boolean cmdResetFalha)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {cmdResetFalha});
    }
    public bool FireEvent_E_RESET_FALHA(Hidryco.HidrycoLib.Symbols.Motor_Partida_Direta.E_RESET_FALHAEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.cmdResetFalha.HasValue) _values_[0] = ea.cmdResetFalha.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_E_RESET_FALHA(System.Boolean cmdResetFalha, bool ignore_cmdResetFalha)
    {
      object[] _values_ = new object[1];
      if (!ignore_cmdResetFalha) _values_[0] = cmdResetFalha;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_E_RESET_HORIMETRO(System.Boolean cmdResetHorimetro)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {cmdResetHorimetro});
    }
    public bool FireEvent_E_RESET_HORIMETRO(Hidryco.HidrycoLib.Symbols.Motor_Partida_Direta.E_RESET_HORIMETROEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.cmdResetHorimetro.HasValue) _values_[0] = ea.cmdResetHorimetro.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_E_RESET_HORIMETRO(System.Boolean cmdResetHorimetro, bool ignore_cmdResetHorimetro)
    {
      object[] _values_ = new object[1];
      if (!ignore_cmdResetHorimetro) _values_[0] = cmdResetHorimetro;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_E_RESET_NUMERO_PARTIDAS(System.Boolean cmdResetNumeroPartida)
    {
      return ((IHMIAccessorOutput)this).FireEvent(2, new object[] {cmdResetNumeroPartida});
    }
    public bool FireEvent_E_RESET_NUMERO_PARTIDAS(Hidryco.HidrycoLib.Symbols.Motor_Partida_Direta.E_RESET_NUMERO_PARTIDASEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.cmdResetNumeroPartida.HasValue) _values_[0] = ea.cmdResetNumeroPartida.Value;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_E_RESET_NUMERO_PARTIDAS(System.Boolean cmdResetNumeroPartida, bool ignore_cmdResetNumeroPartida)
    {
      object[] _values_ = new object[1];
      if (!ignore_cmdResetNumeroPartida) _values_[0] = cmdResetNumeroPartida;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_E_STS_AUTOMATICO(System.Boolean stsAutomatico)
    {
      return ((IHMIAccessorOutput)this).FireEvent(3, new object[] {stsAutomatico});
    }
    public bool FireEvent_E_STS_AUTOMATICO(Hidryco.HidrycoLib.Symbols.Motor_Partida_Direta.E_STS_AUTOMATICOEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.stsAutomatico.HasValue) _values_[0] = ea.stsAutomatico.Value;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_E_STS_AUTOMATICO(System.Boolean stsAutomatico, bool ignore_stsAutomatico)
    {
      object[] _values_ = new object[1];
      if (!ignore_stsAutomatico) _values_[0] = stsAutomatico;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_E_CMD_MANUAL(System.Boolean cmdManual)
    {
      return ((IHMIAccessorOutput)this).FireEvent(4, new object[] {cmdManual});
    }
    public bool FireEvent_E_CMD_MANUAL(Hidryco.HidrycoLib.Symbols.Motor_Partida_Direta.E_CMD_MANUALEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.cmdManual.HasValue) _values_[0] = ea.cmdManual.Value;
      return ((IHMIAccessorOutput)this).FireEvent(4, _values_);
    }
    public bool FireEvent_E_CMD_MANUAL(System.Boolean cmdManual, bool ignore_cmdManual)
    {
      object[] _values_ = new object[1];
      if (!ignore_cmdManual) _values_[0] = cmdManual;
      return ((IHMIAccessorOutput)this).FireEvent(4, _values_);
    }
    public bool FireEvent_E_AJUSTE_STP(System.UInt16 stpTempoFalhaLigamento, System.UInt16 stpTempoFalhaDesligamento)
    {
      return ((IHMIAccessorOutput)this).FireEvent(5, new object[] {stpTempoFalhaLigamento, stpTempoFalhaDesligamento});
    }
    public bool FireEvent_E_AJUSTE_STP(Hidryco.HidrycoLib.Symbols.Motor_Partida_Direta.E_AJUSTE_STPEventArgs ea)
    {
      object[] _values_ = new object[2];
      if (ea.stpTempoFalhaLigamento.HasValue) _values_[0] = ea.stpTempoFalhaLigamento.Value;
      if (ea.stpTempoFalhaDesligamento.HasValue) _values_[1] = ea.stpTempoFalhaDesligamento.Value;
      return ((IHMIAccessorOutput)this).FireEvent(5, _values_);
    }
    public bool FireEvent_E_AJUSTE_STP(System.UInt16 stpTempoFalhaLigamento, bool ignore_stpTempoFalhaLigamento, System.UInt16 stpTempoFalhaDesligamento, bool ignore_stpTempoFalhaDesligamento)
    {
      object[] _values_ = new object[2];
      if (!ignore_stpTempoFalhaLigamento) _values_[0] = stpTempoFalhaLigamento;
      if (!ignore_stpTempoFalhaDesligamento) _values_[1] = stpTempoFalhaDesligamento;
      return ((IHMIAccessorOutput)this).FireEvent(5, _values_);
    }

  }
}
#endregion #Motor_Partida_Direta_HMI;

#endregion Definitions;
