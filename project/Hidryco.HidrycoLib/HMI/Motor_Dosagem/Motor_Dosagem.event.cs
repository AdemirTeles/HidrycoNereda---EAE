/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 1/22/2026
 * Time: 5:25 PM
 * 
 */
using System;
using NxtControl.GuiFramework;
using NxtControl.Services;

#region Definitions;
#region #Motor_Dosagem_HMI;

namespace Hidryco.HidrycoLib.Symbols.Motor_Dosagem
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

    public bool Get_STS_HORIMETRO_HORA(ref System.UInt32 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,2, ref var);
      if (ret) value = (System.UInt32) var;
      return ret;
    }

    public System.UInt32? STS_HORIMETRO_HORA
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,2, ref var);
      if (!ret) return null;
      return (System.UInt32) var;
    }  }

    public bool Get_STS_ENTRADA_MEDICAO(ref System.Single value)
    {
      if (accessorService == null)
        return false;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,3, ref var);
      if (ret) value = (System.Single) var;
      return ret;
    }

    public System.Single? STS_ENTRADA_MEDICAO
    { get {
      if (accessorService == null)
        return null;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,3, ref var);
      if (!ret) return null;
      return (System.Single) var;
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

    public bool Get_STS_FALHA_COMUNICACAO(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,7, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_FALHA_COMUNICACAO
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,7, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_NUMERO_PARTIDA(ref System.UInt32 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,8, ref var);
      if (ret) value = (System.UInt32) var;
      return ret;
    }

    public System.UInt32? STS_NUMERO_PARTIDA
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,8, ref var);
      if (!ret) return null;
      return (System.UInt32) var;
    }  }

    public bool Get_STS_ANIMACAO_GERADOR(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,9, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? STS_ANIMACAO_GERADOR
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,9, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }

    public bool Get_STS_LIGADO(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,10, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_LIGADO
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,10, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_ALARME(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,11, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_ALARME
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,11, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_CAPACIDADE(ref System.Single value)
    {
      if (accessorService == null)
        return false;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,12, ref var);
      if (ret) value = (System.Single) var;
      return ret;
    }

    public System.Single? STS_CAPACIDADE
    { get {
      if (accessorService == null)
        return null;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,12, ref var);
      if (!ret) return null;
      return (System.Single) var;
    }  }

    public bool Get_STS_POTENCIA(ref System.Single value)
    {
      if (accessorService == null)
        return false;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,13, ref var);
      if (ret) value = (System.Single) var;
      return ret;
    }

    public System.Single? STS_POTENCIA
    { get {
      if (accessorService == null)
        return null;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,13, ref var);
      if (!ret) return null;
      return (System.Single) var;
    }  }

    public bool Get_STS_FREQUENCIA(ref System.Single value)
    {
      if (accessorService == null)
        return false;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,14, ref var);
      if (ret) value = (System.Single) var;
      return ret;
    }

    public System.Single? STS_FREQUENCIA
    { get {
      if (accessorService == null)
        return null;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,14, ref var);
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

namespace Hidryco.HidrycoLib.Symbols.Motor_Dosagem
{

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
    private System.Boolean? cmdResetNumeroPartidas_field = null;
    public System.Boolean? cmdResetNumeroPartidas
    {
       get { return cmdResetNumeroPartidas_field; }
       set { cmdResetNumeroPartidas_field = value; }
    }

  }

  public class E_COMANDO_MANUALEventArgs : System.EventArgs
  {
    public E_COMANDO_MANUALEventArgs()
    {
    }
    private System.Boolean? cmdManual_field = null;
    public System.Boolean? cmdManual
    {
       get { return cmdManual_field; }
       set { cmdManual_field = value; }
    }

  }

  public class E_MODO_OPERACAOEventArgs : System.EventArgs
  {
    public E_MODO_OPERACAOEventArgs()
    {
    }
    private System.Boolean? STS_AUTOMATICO_field = null;
    public System.Boolean? STS_AUTOMATICO
    {
       get { return STS_AUTOMATICO_field; }
       set { STS_AUTOMATICO_field = value; }
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
    private System.Single? stpSaidaManual_field = null;
    public System.Single? stpSaidaManual
    {
       get { return stpSaidaManual_field; }
       set { stpSaidaManual_field = value; }
    }

  }

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

}

namespace Hidryco.HidrycoLib.Symbols.Motor_Dosagem
{
  partial class sBomba
  {

    private event EventHandler<Hidryco.HidrycoLib.Symbols.Motor_Dosagem.REQEventArgs> REQ_Fired;

    private event EventHandler<Hidryco.HidrycoLib.Symbols.Motor_Dosagem.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    protected override void OnEndInit()
    {
      if (REQ_Fired != null)
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
          if (REQ_Fired != null)
          {
            try
            {
              REQ_Fired(this, new Hidryco.HidrycoLib.Symbols.Motor_Dosagem.REQEventArgs(channelId, cookie, eventIndex));
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
          if (LOAD_PERS_DATA_Fired != null)
          {
            try
            {
              LOAD_PERS_DATA_Fired(this, new Hidryco.HidrycoLib.Symbols.Motor_Dosagem.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
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
    public bool FireEvent_E_RESET_HORIMETRO(System.Boolean cmdResetHorimetro)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {cmdResetHorimetro});
    }
    public bool FireEvent_E_RESET_HORIMETRO(Hidryco.HidrycoLib.Symbols.Motor_Dosagem.E_RESET_HORIMETROEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.cmdResetHorimetro.HasValue) _values_[0] = ea.cmdResetHorimetro.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_E_RESET_HORIMETRO(System.Boolean cmdResetHorimetro, bool ignore_cmdResetHorimetro)
    {
      object[] _values_ = new object[1];
      if (!ignore_cmdResetHorimetro) _values_[0] = cmdResetHorimetro;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_E_RESET_NUMERO_PARTIDAS(System.Boolean cmdResetNumeroPartidas)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {cmdResetNumeroPartidas});
    }
    public bool FireEvent_E_RESET_NUMERO_PARTIDAS(Hidryco.HidrycoLib.Symbols.Motor_Dosagem.E_RESET_NUMERO_PARTIDASEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.cmdResetNumeroPartidas.HasValue) _values_[0] = ea.cmdResetNumeroPartidas.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_E_RESET_NUMERO_PARTIDAS(System.Boolean cmdResetNumeroPartidas, bool ignore_cmdResetNumeroPartidas)
    {
      object[] _values_ = new object[1];
      if (!ignore_cmdResetNumeroPartidas) _values_[0] = cmdResetNumeroPartidas;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_E_COMANDO_MANUAL(System.Boolean cmdManual)
    {
      return ((IHMIAccessorOutput)this).FireEvent(2, new object[] {cmdManual});
    }
    public bool FireEvent_E_COMANDO_MANUAL(Hidryco.HidrycoLib.Symbols.Motor_Dosagem.E_COMANDO_MANUALEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.cmdManual.HasValue) _values_[0] = ea.cmdManual.Value;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_E_COMANDO_MANUAL(System.Boolean cmdManual, bool ignore_cmdManual)
    {
      object[] _values_ = new object[1];
      if (!ignore_cmdManual) _values_[0] = cmdManual;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_E_MODO_OPERACAO(System.Boolean STS_AUTOMATICO)
    {
      return ((IHMIAccessorOutput)this).FireEvent(3, new object[] {STS_AUTOMATICO});
    }
    public bool FireEvent_E_MODO_OPERACAO(Hidryco.HidrycoLib.Symbols.Motor_Dosagem.E_MODO_OPERACAOEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.STS_AUTOMATICO.HasValue) _values_[0] = ea.STS_AUTOMATICO.Value;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_E_MODO_OPERACAO(System.Boolean STS_AUTOMATICO, bool ignore_STS_AUTOMATICO)
    {
      object[] _values_ = new object[1];
      if (!ignore_STS_AUTOMATICO) _values_[0] = STS_AUTOMATICO;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_E_AJUSTE_STP(System.UInt16 stpTempoFalhaLigamento, System.UInt16 stpTempoFalhaDesligamento, System.Single stpSaidaManual)
    {
      return ((IHMIAccessorOutput)this).FireEvent(4, new object[] {stpTempoFalhaLigamento, stpTempoFalhaDesligamento, stpSaidaManual});
    }
    public bool FireEvent_E_AJUSTE_STP(Hidryco.HidrycoLib.Symbols.Motor_Dosagem.E_AJUSTE_STPEventArgs ea)
    {
      object[] _values_ = new object[3];
      if (ea.stpTempoFalhaLigamento.HasValue) _values_[0] = ea.stpTempoFalhaLigamento.Value;
      if (ea.stpTempoFalhaDesligamento.HasValue) _values_[1] = ea.stpTempoFalhaDesligamento.Value;
      if (ea.stpSaidaManual.HasValue) _values_[2] = ea.stpSaidaManual.Value;
      return ((IHMIAccessorOutput)this).FireEvent(4, _values_);
    }
    public bool FireEvent_E_AJUSTE_STP(System.UInt16 stpTempoFalhaLigamento, bool ignore_stpTempoFalhaLigamento, System.UInt16 stpTempoFalhaDesligamento, bool ignore_stpTempoFalhaDesligamento, System.Single stpSaidaManual, bool ignore_stpSaidaManual)
    {
      object[] _values_ = new object[3];
      if (!ignore_stpTempoFalhaLigamento) _values_[0] = stpTempoFalhaLigamento;
      if (!ignore_stpTempoFalhaDesligamento) _values_[1] = stpTempoFalhaDesligamento;
      if (!ignore_stpSaidaManual) _values_[2] = stpSaidaManual;
      return ((IHMIAccessorOutput)this).FireEvent(4, _values_);
    }
    public bool FireEvent_E_RESET_FALHA(System.Boolean cmdResetFalha)
    {
      return ((IHMIAccessorOutput)this).FireEvent(5, new object[] {cmdResetFalha});
    }
    public bool FireEvent_E_RESET_FALHA(Hidryco.HidrycoLib.Symbols.Motor_Dosagem.E_RESET_FALHAEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.cmdResetFalha.HasValue) _values_[0] = ea.cmdResetFalha.Value;
      return ((IHMIAccessorOutput)this).FireEvent(5, _values_);
    }
    public bool FireEvent_E_RESET_FALHA(System.Boolean cmdResetFalha, bool ignore_cmdResetFalha)
    {
      object[] _values_ = new object[1];
      if (!ignore_cmdResetFalha) _values_[0] = cmdResetFalha;
      return ((IHMIAccessorOutput)this).FireEvent(5, _values_);
    }

  }
}

namespace Hidryco.HidrycoLib.Faceplates.Motor_Dosagem
{
  partial class Faceplate1
  {

    private event EventHandler<Hidryco.HidrycoLib.Symbols.Motor_Dosagem.REQEventArgs> REQ_Fired;

    private event EventHandler<Hidryco.HidrycoLib.Symbols.Motor_Dosagem.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    protected override void OnEndInit()
    {
      if (REQ_Fired != null)
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
          if (REQ_Fired != null)
          {
            try
            {
              REQ_Fired(this, new Hidryco.HidrycoLib.Symbols.Motor_Dosagem.REQEventArgs(channelId, cookie, eventIndex));
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
          if (LOAD_PERS_DATA_Fired != null)
          {
            try
            {
              LOAD_PERS_DATA_Fired(this, new Hidryco.HidrycoLib.Symbols.Motor_Dosagem.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
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
    public bool FireEvent_E_RESET_HORIMETRO(System.Boolean cmdResetHorimetro)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {cmdResetHorimetro});
    }
    public bool FireEvent_E_RESET_HORIMETRO(Hidryco.HidrycoLib.Symbols.Motor_Dosagem.E_RESET_HORIMETROEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.cmdResetHorimetro.HasValue) _values_[0] = ea.cmdResetHorimetro.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_E_RESET_HORIMETRO(System.Boolean cmdResetHorimetro, bool ignore_cmdResetHorimetro)
    {
      object[] _values_ = new object[1];
      if (!ignore_cmdResetHorimetro) _values_[0] = cmdResetHorimetro;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_E_RESET_NUMERO_PARTIDAS(System.Boolean cmdResetNumeroPartidas)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {cmdResetNumeroPartidas});
    }
    public bool FireEvent_E_RESET_NUMERO_PARTIDAS(Hidryco.HidrycoLib.Symbols.Motor_Dosagem.E_RESET_NUMERO_PARTIDASEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.cmdResetNumeroPartidas.HasValue) _values_[0] = ea.cmdResetNumeroPartidas.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_E_RESET_NUMERO_PARTIDAS(System.Boolean cmdResetNumeroPartidas, bool ignore_cmdResetNumeroPartidas)
    {
      object[] _values_ = new object[1];
      if (!ignore_cmdResetNumeroPartidas) _values_[0] = cmdResetNumeroPartidas;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_E_COMANDO_MANUAL(System.Boolean cmdManual)
    {
      return ((IHMIAccessorOutput)this).FireEvent(2, new object[] {cmdManual});
    }
    public bool FireEvent_E_COMANDO_MANUAL(Hidryco.HidrycoLib.Symbols.Motor_Dosagem.E_COMANDO_MANUALEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.cmdManual.HasValue) _values_[0] = ea.cmdManual.Value;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_E_COMANDO_MANUAL(System.Boolean cmdManual, bool ignore_cmdManual)
    {
      object[] _values_ = new object[1];
      if (!ignore_cmdManual) _values_[0] = cmdManual;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_E_MODO_OPERACAO(System.Boolean STS_AUTOMATICO)
    {
      return ((IHMIAccessorOutput)this).FireEvent(3, new object[] {STS_AUTOMATICO});
    }
    public bool FireEvent_E_MODO_OPERACAO(Hidryco.HidrycoLib.Symbols.Motor_Dosagem.E_MODO_OPERACAOEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.STS_AUTOMATICO.HasValue) _values_[0] = ea.STS_AUTOMATICO.Value;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_E_MODO_OPERACAO(System.Boolean STS_AUTOMATICO, bool ignore_STS_AUTOMATICO)
    {
      object[] _values_ = new object[1];
      if (!ignore_STS_AUTOMATICO) _values_[0] = STS_AUTOMATICO;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_E_AJUSTE_STP(System.UInt16 stpTempoFalhaLigamento, System.UInt16 stpTempoFalhaDesligamento, System.Single stpSaidaManual)
    {
      return ((IHMIAccessorOutput)this).FireEvent(4, new object[] {stpTempoFalhaLigamento, stpTempoFalhaDesligamento, stpSaidaManual});
    }
    public bool FireEvent_E_AJUSTE_STP(Hidryco.HidrycoLib.Symbols.Motor_Dosagem.E_AJUSTE_STPEventArgs ea)
    {
      object[] _values_ = new object[3];
      if (ea.stpTempoFalhaLigamento.HasValue) _values_[0] = ea.stpTempoFalhaLigamento.Value;
      if (ea.stpTempoFalhaDesligamento.HasValue) _values_[1] = ea.stpTempoFalhaDesligamento.Value;
      if (ea.stpSaidaManual.HasValue) _values_[2] = ea.stpSaidaManual.Value;
      return ((IHMIAccessorOutput)this).FireEvent(4, _values_);
    }
    public bool FireEvent_E_AJUSTE_STP(System.UInt16 stpTempoFalhaLigamento, bool ignore_stpTempoFalhaLigamento, System.UInt16 stpTempoFalhaDesligamento, bool ignore_stpTempoFalhaDesligamento, System.Single stpSaidaManual, bool ignore_stpSaidaManual)
    {
      object[] _values_ = new object[3];
      if (!ignore_stpTempoFalhaLigamento) _values_[0] = stpTempoFalhaLigamento;
      if (!ignore_stpTempoFalhaDesligamento) _values_[1] = stpTempoFalhaDesligamento;
      if (!ignore_stpSaidaManual) _values_[2] = stpSaidaManual;
      return ((IHMIAccessorOutput)this).FireEvent(4, _values_);
    }
    public bool FireEvent_E_RESET_FALHA(System.Boolean cmdResetFalha)
    {
      return ((IHMIAccessorOutput)this).FireEvent(5, new object[] {cmdResetFalha});
    }
    public bool FireEvent_E_RESET_FALHA(Hidryco.HidrycoLib.Symbols.Motor_Dosagem.E_RESET_FALHAEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.cmdResetFalha.HasValue) _values_[0] = ea.cmdResetFalha.Value;
      return ((IHMIAccessorOutput)this).FireEvent(5, _values_);
    }
    public bool FireEvent_E_RESET_FALHA(System.Boolean cmdResetFalha, bool ignore_cmdResetFalha)
    {
      object[] _values_ = new object[1];
      if (!ignore_cmdResetFalha) _values_[0] = cmdResetFalha;
      return ((IHMIAccessorOutput)this).FireEvent(5, _values_);
    }

  }
}

namespace Hidryco.HidrycoLib.Faceplates.Motor_Dosagem
{
  partial class Faceplate2
  {

    private event EventHandler<Hidryco.HidrycoLib.Symbols.Motor_Dosagem.REQEventArgs> REQ_Fired;

    private event EventHandler<Hidryco.HidrycoLib.Symbols.Motor_Dosagem.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    protected override void OnEndInit()
    {
      if (REQ_Fired != null)
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
          if (REQ_Fired != null)
          {
            try
            {
              REQ_Fired(this, new Hidryco.HidrycoLib.Symbols.Motor_Dosagem.REQEventArgs(channelId, cookie, eventIndex));
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
          if (LOAD_PERS_DATA_Fired != null)
          {
            try
            {
              LOAD_PERS_DATA_Fired(this, new Hidryco.HidrycoLib.Symbols.Motor_Dosagem.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
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
    public bool FireEvent_E_RESET_HORIMETRO(System.Boolean cmdResetHorimetro)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {cmdResetHorimetro});
    }
    public bool FireEvent_E_RESET_HORIMETRO(Hidryco.HidrycoLib.Symbols.Motor_Dosagem.E_RESET_HORIMETROEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.cmdResetHorimetro.HasValue) _values_[0] = ea.cmdResetHorimetro.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_E_RESET_HORIMETRO(System.Boolean cmdResetHorimetro, bool ignore_cmdResetHorimetro)
    {
      object[] _values_ = new object[1];
      if (!ignore_cmdResetHorimetro) _values_[0] = cmdResetHorimetro;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_E_RESET_NUMERO_PARTIDAS(System.Boolean cmdResetNumeroPartidas)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {cmdResetNumeroPartidas});
    }
    public bool FireEvent_E_RESET_NUMERO_PARTIDAS(Hidryco.HidrycoLib.Symbols.Motor_Dosagem.E_RESET_NUMERO_PARTIDASEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.cmdResetNumeroPartidas.HasValue) _values_[0] = ea.cmdResetNumeroPartidas.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_E_RESET_NUMERO_PARTIDAS(System.Boolean cmdResetNumeroPartidas, bool ignore_cmdResetNumeroPartidas)
    {
      object[] _values_ = new object[1];
      if (!ignore_cmdResetNumeroPartidas) _values_[0] = cmdResetNumeroPartidas;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_E_COMANDO_MANUAL(System.Boolean cmdManual)
    {
      return ((IHMIAccessorOutput)this).FireEvent(2, new object[] {cmdManual});
    }
    public bool FireEvent_E_COMANDO_MANUAL(Hidryco.HidrycoLib.Symbols.Motor_Dosagem.E_COMANDO_MANUALEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.cmdManual.HasValue) _values_[0] = ea.cmdManual.Value;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_E_COMANDO_MANUAL(System.Boolean cmdManual, bool ignore_cmdManual)
    {
      object[] _values_ = new object[1];
      if (!ignore_cmdManual) _values_[0] = cmdManual;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_E_MODO_OPERACAO(System.Boolean STS_AUTOMATICO)
    {
      return ((IHMIAccessorOutput)this).FireEvent(3, new object[] {STS_AUTOMATICO});
    }
    public bool FireEvent_E_MODO_OPERACAO(Hidryco.HidrycoLib.Symbols.Motor_Dosagem.E_MODO_OPERACAOEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.STS_AUTOMATICO.HasValue) _values_[0] = ea.STS_AUTOMATICO.Value;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_E_MODO_OPERACAO(System.Boolean STS_AUTOMATICO, bool ignore_STS_AUTOMATICO)
    {
      object[] _values_ = new object[1];
      if (!ignore_STS_AUTOMATICO) _values_[0] = STS_AUTOMATICO;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_E_AJUSTE_STP(System.UInt16 stpTempoFalhaLigamento, System.UInt16 stpTempoFalhaDesligamento, System.Single stpSaidaManual)
    {
      return ((IHMIAccessorOutput)this).FireEvent(4, new object[] {stpTempoFalhaLigamento, stpTempoFalhaDesligamento, stpSaidaManual});
    }
    public bool FireEvent_E_AJUSTE_STP(Hidryco.HidrycoLib.Symbols.Motor_Dosagem.E_AJUSTE_STPEventArgs ea)
    {
      object[] _values_ = new object[3];
      if (ea.stpTempoFalhaLigamento.HasValue) _values_[0] = ea.stpTempoFalhaLigamento.Value;
      if (ea.stpTempoFalhaDesligamento.HasValue) _values_[1] = ea.stpTempoFalhaDesligamento.Value;
      if (ea.stpSaidaManual.HasValue) _values_[2] = ea.stpSaidaManual.Value;
      return ((IHMIAccessorOutput)this).FireEvent(4, _values_);
    }
    public bool FireEvent_E_AJUSTE_STP(System.UInt16 stpTempoFalhaLigamento, bool ignore_stpTempoFalhaLigamento, System.UInt16 stpTempoFalhaDesligamento, bool ignore_stpTempoFalhaDesligamento, System.Single stpSaidaManual, bool ignore_stpSaidaManual)
    {
      object[] _values_ = new object[3];
      if (!ignore_stpTempoFalhaLigamento) _values_[0] = stpTempoFalhaLigamento;
      if (!ignore_stpTempoFalhaDesligamento) _values_[1] = stpTempoFalhaDesligamento;
      if (!ignore_stpSaidaManual) _values_[2] = stpSaidaManual;
      return ((IHMIAccessorOutput)this).FireEvent(4, _values_);
    }
    public bool FireEvent_E_RESET_FALHA(System.Boolean cmdResetFalha)
    {
      return ((IHMIAccessorOutput)this).FireEvent(5, new object[] {cmdResetFalha});
    }
    public bool FireEvent_E_RESET_FALHA(Hidryco.HidrycoLib.Symbols.Motor_Dosagem.E_RESET_FALHAEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.cmdResetFalha.HasValue) _values_[0] = ea.cmdResetFalha.Value;
      return ((IHMIAccessorOutput)this).FireEvent(5, _values_);
    }
    public bool FireEvent_E_RESET_FALHA(System.Boolean cmdResetFalha, bool ignore_cmdResetFalha)
    {
      object[] _values_ = new object[1];
      if (!ignore_cmdResetFalha) _values_[0] = cmdResetFalha;
      return ((IHMIAccessorOutput)this).FireEvent(5, _values_);
    }

  }
}

namespace Hidryco.HidrycoLib.Faceplates.Motor_Dosagem
{
  partial class Faceplate3
  {

    private event EventHandler<Hidryco.HidrycoLib.Symbols.Motor_Dosagem.REQEventArgs> REQ_Fired;

    private event EventHandler<Hidryco.HidrycoLib.Symbols.Motor_Dosagem.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    protected override void OnEndInit()
    {
      if (REQ_Fired != null)
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
          if (REQ_Fired != null)
          {
            try
            {
              REQ_Fired(this, new Hidryco.HidrycoLib.Symbols.Motor_Dosagem.REQEventArgs(channelId, cookie, eventIndex));
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
          if (LOAD_PERS_DATA_Fired != null)
          {
            try
            {
              LOAD_PERS_DATA_Fired(this, new Hidryco.HidrycoLib.Symbols.Motor_Dosagem.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
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
    public bool FireEvent_E_RESET_HORIMETRO(System.Boolean cmdResetHorimetro)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {cmdResetHorimetro});
    }
    public bool FireEvent_E_RESET_HORIMETRO(Hidryco.HidrycoLib.Symbols.Motor_Dosagem.E_RESET_HORIMETROEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.cmdResetHorimetro.HasValue) _values_[0] = ea.cmdResetHorimetro.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_E_RESET_HORIMETRO(System.Boolean cmdResetHorimetro, bool ignore_cmdResetHorimetro)
    {
      object[] _values_ = new object[1];
      if (!ignore_cmdResetHorimetro) _values_[0] = cmdResetHorimetro;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_E_RESET_NUMERO_PARTIDAS(System.Boolean cmdResetNumeroPartidas)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {cmdResetNumeroPartidas});
    }
    public bool FireEvent_E_RESET_NUMERO_PARTIDAS(Hidryco.HidrycoLib.Symbols.Motor_Dosagem.E_RESET_NUMERO_PARTIDASEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.cmdResetNumeroPartidas.HasValue) _values_[0] = ea.cmdResetNumeroPartidas.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_E_RESET_NUMERO_PARTIDAS(System.Boolean cmdResetNumeroPartidas, bool ignore_cmdResetNumeroPartidas)
    {
      object[] _values_ = new object[1];
      if (!ignore_cmdResetNumeroPartidas) _values_[0] = cmdResetNumeroPartidas;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_E_COMANDO_MANUAL(System.Boolean cmdManual)
    {
      return ((IHMIAccessorOutput)this).FireEvent(2, new object[] {cmdManual});
    }
    public bool FireEvent_E_COMANDO_MANUAL(Hidryco.HidrycoLib.Symbols.Motor_Dosagem.E_COMANDO_MANUALEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.cmdManual.HasValue) _values_[0] = ea.cmdManual.Value;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_E_COMANDO_MANUAL(System.Boolean cmdManual, bool ignore_cmdManual)
    {
      object[] _values_ = new object[1];
      if (!ignore_cmdManual) _values_[0] = cmdManual;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_E_MODO_OPERACAO(System.Boolean STS_AUTOMATICO)
    {
      return ((IHMIAccessorOutput)this).FireEvent(3, new object[] {STS_AUTOMATICO});
    }
    public bool FireEvent_E_MODO_OPERACAO(Hidryco.HidrycoLib.Symbols.Motor_Dosagem.E_MODO_OPERACAOEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.STS_AUTOMATICO.HasValue) _values_[0] = ea.STS_AUTOMATICO.Value;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_E_MODO_OPERACAO(System.Boolean STS_AUTOMATICO, bool ignore_STS_AUTOMATICO)
    {
      object[] _values_ = new object[1];
      if (!ignore_STS_AUTOMATICO) _values_[0] = STS_AUTOMATICO;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_E_AJUSTE_STP(System.UInt16 stpTempoFalhaLigamento, System.UInt16 stpTempoFalhaDesligamento, System.Single stpSaidaManual)
    {
      return ((IHMIAccessorOutput)this).FireEvent(4, new object[] {stpTempoFalhaLigamento, stpTempoFalhaDesligamento, stpSaidaManual});
    }
    public bool FireEvent_E_AJUSTE_STP(Hidryco.HidrycoLib.Symbols.Motor_Dosagem.E_AJUSTE_STPEventArgs ea)
    {
      object[] _values_ = new object[3];
      if (ea.stpTempoFalhaLigamento.HasValue) _values_[0] = ea.stpTempoFalhaLigamento.Value;
      if (ea.stpTempoFalhaDesligamento.HasValue) _values_[1] = ea.stpTempoFalhaDesligamento.Value;
      if (ea.stpSaidaManual.HasValue) _values_[2] = ea.stpSaidaManual.Value;
      return ((IHMIAccessorOutput)this).FireEvent(4, _values_);
    }
    public bool FireEvent_E_AJUSTE_STP(System.UInt16 stpTempoFalhaLigamento, bool ignore_stpTempoFalhaLigamento, System.UInt16 stpTempoFalhaDesligamento, bool ignore_stpTempoFalhaDesligamento, System.Single stpSaidaManual, bool ignore_stpSaidaManual)
    {
      object[] _values_ = new object[3];
      if (!ignore_stpTempoFalhaLigamento) _values_[0] = stpTempoFalhaLigamento;
      if (!ignore_stpTempoFalhaDesligamento) _values_[1] = stpTempoFalhaDesligamento;
      if (!ignore_stpSaidaManual) _values_[2] = stpSaidaManual;
      return ((IHMIAccessorOutput)this).FireEvent(4, _values_);
    }
    public bool FireEvent_E_RESET_FALHA(System.Boolean cmdResetFalha)
    {
      return ((IHMIAccessorOutput)this).FireEvent(5, new object[] {cmdResetFalha});
    }
    public bool FireEvent_E_RESET_FALHA(Hidryco.HidrycoLib.Symbols.Motor_Dosagem.E_RESET_FALHAEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.cmdResetFalha.HasValue) _values_[0] = ea.cmdResetFalha.Value;
      return ((IHMIAccessorOutput)this).FireEvent(5, _values_);
    }
    public bool FireEvent_E_RESET_FALHA(System.Boolean cmdResetFalha, bool ignore_cmdResetFalha)
    {
      object[] _values_ = new object[1];
      if (!ignore_cmdResetFalha) _values_[0] = cmdResetFalha;
      return ((IHMIAccessorOutput)this).FireEvent(5, _values_);
    }

  }
}

namespace Hidryco.HidrycoLib.Faceplates.Motor_Dosagem
{
  partial class Faceplate4
  {

    private event EventHandler<Hidryco.HidrycoLib.Symbols.Motor_Dosagem.REQEventArgs> REQ_Fired;

    private event EventHandler<Hidryco.HidrycoLib.Symbols.Motor_Dosagem.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    protected override void OnEndInit()
    {
      if (REQ_Fired != null)
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
          if (REQ_Fired != null)
          {
            try
            {
              REQ_Fired(this, new Hidryco.HidrycoLib.Symbols.Motor_Dosagem.REQEventArgs(channelId, cookie, eventIndex));
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
          if (LOAD_PERS_DATA_Fired != null)
          {
            try
            {
              LOAD_PERS_DATA_Fired(this, new Hidryco.HidrycoLib.Symbols.Motor_Dosagem.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
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
    public bool FireEvent_E_RESET_HORIMETRO(System.Boolean cmdResetHorimetro)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {cmdResetHorimetro});
    }
    public bool FireEvent_E_RESET_HORIMETRO(Hidryco.HidrycoLib.Symbols.Motor_Dosagem.E_RESET_HORIMETROEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.cmdResetHorimetro.HasValue) _values_[0] = ea.cmdResetHorimetro.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_E_RESET_HORIMETRO(System.Boolean cmdResetHorimetro, bool ignore_cmdResetHorimetro)
    {
      object[] _values_ = new object[1];
      if (!ignore_cmdResetHorimetro) _values_[0] = cmdResetHorimetro;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_E_RESET_NUMERO_PARTIDAS(System.Boolean cmdResetNumeroPartidas)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {cmdResetNumeroPartidas});
    }
    public bool FireEvent_E_RESET_NUMERO_PARTIDAS(Hidryco.HidrycoLib.Symbols.Motor_Dosagem.E_RESET_NUMERO_PARTIDASEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.cmdResetNumeroPartidas.HasValue) _values_[0] = ea.cmdResetNumeroPartidas.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_E_RESET_NUMERO_PARTIDAS(System.Boolean cmdResetNumeroPartidas, bool ignore_cmdResetNumeroPartidas)
    {
      object[] _values_ = new object[1];
      if (!ignore_cmdResetNumeroPartidas) _values_[0] = cmdResetNumeroPartidas;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_E_COMANDO_MANUAL(System.Boolean cmdManual)
    {
      return ((IHMIAccessorOutput)this).FireEvent(2, new object[] {cmdManual});
    }
    public bool FireEvent_E_COMANDO_MANUAL(Hidryco.HidrycoLib.Symbols.Motor_Dosagem.E_COMANDO_MANUALEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.cmdManual.HasValue) _values_[0] = ea.cmdManual.Value;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_E_COMANDO_MANUAL(System.Boolean cmdManual, bool ignore_cmdManual)
    {
      object[] _values_ = new object[1];
      if (!ignore_cmdManual) _values_[0] = cmdManual;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_E_MODO_OPERACAO(System.Boolean STS_AUTOMATICO)
    {
      return ((IHMIAccessorOutput)this).FireEvent(3, new object[] {STS_AUTOMATICO});
    }
    public bool FireEvent_E_MODO_OPERACAO(Hidryco.HidrycoLib.Symbols.Motor_Dosagem.E_MODO_OPERACAOEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.STS_AUTOMATICO.HasValue) _values_[0] = ea.STS_AUTOMATICO.Value;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_E_MODO_OPERACAO(System.Boolean STS_AUTOMATICO, bool ignore_STS_AUTOMATICO)
    {
      object[] _values_ = new object[1];
      if (!ignore_STS_AUTOMATICO) _values_[0] = STS_AUTOMATICO;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_E_AJUSTE_STP(System.UInt16 stpTempoFalhaLigamento, System.UInt16 stpTempoFalhaDesligamento, System.Single stpSaidaManual)
    {
      return ((IHMIAccessorOutput)this).FireEvent(4, new object[] {stpTempoFalhaLigamento, stpTempoFalhaDesligamento, stpSaidaManual});
    }
    public bool FireEvent_E_AJUSTE_STP(Hidryco.HidrycoLib.Symbols.Motor_Dosagem.E_AJUSTE_STPEventArgs ea)
    {
      object[] _values_ = new object[3];
      if (ea.stpTempoFalhaLigamento.HasValue) _values_[0] = ea.stpTempoFalhaLigamento.Value;
      if (ea.stpTempoFalhaDesligamento.HasValue) _values_[1] = ea.stpTempoFalhaDesligamento.Value;
      if (ea.stpSaidaManual.HasValue) _values_[2] = ea.stpSaidaManual.Value;
      return ((IHMIAccessorOutput)this).FireEvent(4, _values_);
    }
    public bool FireEvent_E_AJUSTE_STP(System.UInt16 stpTempoFalhaLigamento, bool ignore_stpTempoFalhaLigamento, System.UInt16 stpTempoFalhaDesligamento, bool ignore_stpTempoFalhaDesligamento, System.Single stpSaidaManual, bool ignore_stpSaidaManual)
    {
      object[] _values_ = new object[3];
      if (!ignore_stpTempoFalhaLigamento) _values_[0] = stpTempoFalhaLigamento;
      if (!ignore_stpTempoFalhaDesligamento) _values_[1] = stpTempoFalhaDesligamento;
      if (!ignore_stpSaidaManual) _values_[2] = stpSaidaManual;
      return ((IHMIAccessorOutput)this).FireEvent(4, _values_);
    }
    public bool FireEvent_E_RESET_FALHA(System.Boolean cmdResetFalha)
    {
      return ((IHMIAccessorOutput)this).FireEvent(5, new object[] {cmdResetFalha});
    }
    public bool FireEvent_E_RESET_FALHA(Hidryco.HidrycoLib.Symbols.Motor_Dosagem.E_RESET_FALHAEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.cmdResetFalha.HasValue) _values_[0] = ea.cmdResetFalha.Value;
      return ((IHMIAccessorOutput)this).FireEvent(5, _values_);
    }
    public bool FireEvent_E_RESET_FALHA(System.Boolean cmdResetFalha, bool ignore_cmdResetFalha)
    {
      object[] _values_ = new object[1];
      if (!ignore_cmdResetFalha) _values_[0] = cmdResetFalha;
      return ((IHMIAccessorOutput)this).FireEvent(5, _values_);
    }

  }
}
#endregion #Motor_Dosagem_HMI;

#endregion Definitions;
