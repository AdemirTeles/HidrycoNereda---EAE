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
#region #Motor_Inversor_HMI;

namespace Hidryco.HidrycoLib.Symbols.Motor_Inversor
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

    public bool Get_STS_NUMERO_PARTIDA(ref System.UInt32 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,1, ref var);
      if (ret) value = (System.UInt32) var;
      return ret;
    }

    public System.UInt32? STS_NUMERO_PARTIDA
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,1, ref var);
      if (!ret) return null;
      return (System.UInt32) var;
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

    public bool Get_STS_FALHA_COMUNICACAO(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,3, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_FALHA_COMUNICACAO
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,3, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_VELOCIDADE(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,4, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? STS_VELOCIDADE
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,4, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }

    public bool Get_STS_CORRENTE(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,5, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? STS_CORRENTE
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,5, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }

    public bool Get_STS_FREQUENCIA(ref System.Single value)
    {
      if (accessorService == null)
        return false;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,6, ref var);
      if (ret) value = (System.Single) var;
      return ret;
    }

    public System.Single? STS_FREQUENCIA
    { get {
      if (accessorService == null)
        return null;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,6, ref var);
      if (!ret) return null;
      return (System.Single) var;
    }  }

    public bool Get_STS_TENSAO(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,7, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? STS_TENSAO
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,7, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }

    public bool Get_STS_TORQUE(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,8, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? STS_TORQUE
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,8, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }

    public bool Get_STS_POTENCIA(ref System.Single value)
    {
      if (accessorService == null)
        return false;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,9, ref var);
      if (ret) value = (System.Single) var;
      return ret;
    }

    public System.Single? STS_POTENCIA
    { get {
      if (accessorService == null)
        return null;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,9, ref var);
      if (!ret) return null;
      return (System.Single) var;
    }  }

    public bool Get_STS_PROTECAO_TERMICA(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,10, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_PROTECAO_TERMICA
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,10, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_fbkStsAutomatico(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,11, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? fbkStsAutomatico
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,11, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_fbkCmdManual(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,12, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? fbkCmdManual
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,12, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_ANIMACAO(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,13, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? STS_ANIMACAO
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,13, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }

    public bool Get_STS_ANIMACAO_GERADOR(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,14, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? STS_ANIMACAO_GERADOR
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,14, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }

    public bool Get_STS_LIGADO(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,15, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_LIGADO
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,15, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_ALARME(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,16, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_ALARME
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,16, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_CAPACIDADE(ref System.Single value)
    {
      if (accessorService == null)
        return false;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,17, ref var);
      if (ret) value = (System.Single) var;
      return ret;
    }

    public System.Single? STS_CAPACIDADE
    { get {
      if (accessorService == null)
        return null;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,17, ref var);
      if (!ret) return null;
      return (System.Single) var;
    }  }


  }

}

namespace Hidryco.HidrycoLib.Symbols.Motor_Inversor
{

  public class E_RESET_FALHAEventArgs : System.EventArgs
  {
    public E_RESET_FALHAEventArgs()
    {
    }
    private System.Boolean? CMD_RESET_FALHA_field = null;
    public System.Boolean? CMD_RESET_FALHA
    {
       get { return CMD_RESET_FALHA_field; }
       set { CMD_RESET_FALHA_field = value; }
    }

  }

  public class E_RESET_HORIMETROEventArgs : System.EventArgs
  {
    public E_RESET_HORIMETROEventArgs()
    {
    }
    private System.Boolean? CMD_RESET_HORIMETRO_field = null;
    public System.Boolean? CMD_RESET_HORIMETRO
    {
       get { return CMD_RESET_HORIMETRO_field; }
       set { CMD_RESET_HORIMETRO_field = value; }
    }

  }

  public class E_RESET_NUMERO_PARTIDASEventArgs : System.EventArgs
  {
    public E_RESET_NUMERO_PARTIDASEventArgs()
    {
    }
    private System.Boolean? CMD_RESET_NUMERO_PARTIDA_field = null;
    public System.Boolean? CMD_RESET_NUMERO_PARTIDA
    {
       get { return CMD_RESET_NUMERO_PARTIDA_field; }
       set { CMD_RESET_NUMERO_PARTIDA_field = value; }
    }

  }

  public class E_COMANDO_MANUALEventArgs : System.EventArgs
  {
    public E_COMANDO_MANUALEventArgs()
    {
    }
    private System.Boolean? CMD_MANUAL_field = null;
    public System.Boolean? CMD_MANUAL
    {
       get { return CMD_MANUAL_field; }
       set { CMD_MANUAL_field = value; }
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
    private System.UInt16? STP_FALHA_LIGAMENTO_field = null;
    public System.UInt16? STP_FALHA_LIGAMENTO
    {
       get { return STP_FALHA_LIGAMENTO_field; }
       set { STP_FALHA_LIGAMENTO_field = value; }
    }
    private System.UInt16? STP_FALHA_DESLIGAMENTO_field = null;
    public System.UInt16? STP_FALHA_DESLIGAMENTO
    {
       get { return STP_FALHA_DESLIGAMENTO_field; }
       set { STP_FALHA_DESLIGAMENTO_field = value; }
    }
    private System.Single? STP_SAIDA_MANUAL_field = null;
    public System.Single? STP_SAIDA_MANUAL
    {
       get { return STP_SAIDA_MANUAL_field; }
       set { STP_SAIDA_MANUAL_field = value; }
    }

  }

}

namespace Hidryco.HidrycoLib.Symbols.Motor_Inversor
{
  partial class sBomba
  {

    private event EventHandler<Hidryco.HidrycoLib.Symbols.Motor_Inversor.REQEventArgs> REQ_Fired;

    protected override void OnEndInit()
    {
      if (REQ_Fired != null)
        AttachEventInput(0);

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
              REQ_Fired(this, new Hidryco.HidrycoLib.Symbols.Motor_Inversor.REQEventArgs(channelId, cookie, eventIndex));
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
    public bool FireEvent_E_RESET_FALHA(System.Boolean CMD_RESET_FALHA)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {CMD_RESET_FALHA});
    }
    public bool FireEvent_E_RESET_FALHA(Hidryco.HidrycoLib.Symbols.Motor_Inversor.E_RESET_FALHAEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.CMD_RESET_FALHA.HasValue) _values_[0] = ea.CMD_RESET_FALHA.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_E_RESET_FALHA(System.Boolean CMD_RESET_FALHA, bool ignore_CMD_RESET_FALHA)
    {
      object[] _values_ = new object[1];
      if (!ignore_CMD_RESET_FALHA) _values_[0] = CMD_RESET_FALHA;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_E_RESET_HORIMETRO(System.Boolean CMD_RESET_HORIMETRO)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {CMD_RESET_HORIMETRO});
    }
    public bool FireEvent_E_RESET_HORIMETRO(Hidryco.HidrycoLib.Symbols.Motor_Inversor.E_RESET_HORIMETROEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.CMD_RESET_HORIMETRO.HasValue) _values_[0] = ea.CMD_RESET_HORIMETRO.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_E_RESET_HORIMETRO(System.Boolean CMD_RESET_HORIMETRO, bool ignore_CMD_RESET_HORIMETRO)
    {
      object[] _values_ = new object[1];
      if (!ignore_CMD_RESET_HORIMETRO) _values_[0] = CMD_RESET_HORIMETRO;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_E_RESET_NUMERO_PARTIDAS(System.Boolean CMD_RESET_NUMERO_PARTIDA)
    {
      return ((IHMIAccessorOutput)this).FireEvent(2, new object[] {CMD_RESET_NUMERO_PARTIDA});
    }
    public bool FireEvent_E_RESET_NUMERO_PARTIDAS(Hidryco.HidrycoLib.Symbols.Motor_Inversor.E_RESET_NUMERO_PARTIDASEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.CMD_RESET_NUMERO_PARTIDA.HasValue) _values_[0] = ea.CMD_RESET_NUMERO_PARTIDA.Value;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_E_RESET_NUMERO_PARTIDAS(System.Boolean CMD_RESET_NUMERO_PARTIDA, bool ignore_CMD_RESET_NUMERO_PARTIDA)
    {
      object[] _values_ = new object[1];
      if (!ignore_CMD_RESET_NUMERO_PARTIDA) _values_[0] = CMD_RESET_NUMERO_PARTIDA;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_E_COMANDO_MANUAL(System.Boolean CMD_MANUAL)
    {
      return ((IHMIAccessorOutput)this).FireEvent(3, new object[] {CMD_MANUAL});
    }
    public bool FireEvent_E_COMANDO_MANUAL(Hidryco.HidrycoLib.Symbols.Motor_Inversor.E_COMANDO_MANUALEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.CMD_MANUAL.HasValue) _values_[0] = ea.CMD_MANUAL.Value;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_E_COMANDO_MANUAL(System.Boolean CMD_MANUAL, bool ignore_CMD_MANUAL)
    {
      object[] _values_ = new object[1];
      if (!ignore_CMD_MANUAL) _values_[0] = CMD_MANUAL;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_E_MODO_OPERACAO(System.Boolean STS_AUTOMATICO)
    {
      return ((IHMIAccessorOutput)this).FireEvent(4, new object[] {STS_AUTOMATICO});
    }
    public bool FireEvent_E_MODO_OPERACAO(Hidryco.HidrycoLib.Symbols.Motor_Inversor.E_MODO_OPERACAOEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.STS_AUTOMATICO.HasValue) _values_[0] = ea.STS_AUTOMATICO.Value;
      return ((IHMIAccessorOutput)this).FireEvent(4, _values_);
    }
    public bool FireEvent_E_MODO_OPERACAO(System.Boolean STS_AUTOMATICO, bool ignore_STS_AUTOMATICO)
    {
      object[] _values_ = new object[1];
      if (!ignore_STS_AUTOMATICO) _values_[0] = STS_AUTOMATICO;
      return ((IHMIAccessorOutput)this).FireEvent(4, _values_);
    }
    public bool FireEvent_E_AJUSTE_STP(System.UInt16 STP_FALHA_LIGAMENTO, System.UInt16 STP_FALHA_DESLIGAMENTO, System.Single STP_SAIDA_MANUAL)
    {
      return ((IHMIAccessorOutput)this).FireEvent(5, new object[] {STP_FALHA_LIGAMENTO, STP_FALHA_DESLIGAMENTO, STP_SAIDA_MANUAL});
    }
    public bool FireEvent_E_AJUSTE_STP(Hidryco.HidrycoLib.Symbols.Motor_Inversor.E_AJUSTE_STPEventArgs ea)
    {
      object[] _values_ = new object[3];
      if (ea.STP_FALHA_LIGAMENTO.HasValue) _values_[0] = ea.STP_FALHA_LIGAMENTO.Value;
      if (ea.STP_FALHA_DESLIGAMENTO.HasValue) _values_[1] = ea.STP_FALHA_DESLIGAMENTO.Value;
      if (ea.STP_SAIDA_MANUAL.HasValue) _values_[2] = ea.STP_SAIDA_MANUAL.Value;
      return ((IHMIAccessorOutput)this).FireEvent(5, _values_);
    }
    public bool FireEvent_E_AJUSTE_STP(System.UInt16 STP_FALHA_LIGAMENTO, bool ignore_STP_FALHA_LIGAMENTO, System.UInt16 STP_FALHA_DESLIGAMENTO, bool ignore_STP_FALHA_DESLIGAMENTO, System.Single STP_SAIDA_MANUAL, bool ignore_STP_SAIDA_MANUAL)
    {
      object[] _values_ = new object[3];
      if (!ignore_STP_FALHA_LIGAMENTO) _values_[0] = STP_FALHA_LIGAMENTO;
      if (!ignore_STP_FALHA_DESLIGAMENTO) _values_[1] = STP_FALHA_DESLIGAMENTO;
      if (!ignore_STP_SAIDA_MANUAL) _values_[2] = STP_SAIDA_MANUAL;
      return ((IHMIAccessorOutput)this).FireEvent(5, _values_);
    }

  }
}

namespace Hidryco.HidrycoLib.Faceplates.Motor_Inversor
{
  partial class Faceplate1
  {

    private event EventHandler<Hidryco.HidrycoLib.Symbols.Motor_Inversor.REQEventArgs> REQ_Fired;

    protected override void OnEndInit()
    {
      if (REQ_Fired != null)
        AttachEventInput(0);

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
              REQ_Fired(this, new Hidryco.HidrycoLib.Symbols.Motor_Inversor.REQEventArgs(channelId, cookie, eventIndex));
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
    public bool FireEvent_E_RESET_FALHA(System.Boolean CMD_RESET_FALHA)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {CMD_RESET_FALHA});
    }
    public bool FireEvent_E_RESET_FALHA(Hidryco.HidrycoLib.Symbols.Motor_Inversor.E_RESET_FALHAEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.CMD_RESET_FALHA.HasValue) _values_[0] = ea.CMD_RESET_FALHA.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_E_RESET_FALHA(System.Boolean CMD_RESET_FALHA, bool ignore_CMD_RESET_FALHA)
    {
      object[] _values_ = new object[1];
      if (!ignore_CMD_RESET_FALHA) _values_[0] = CMD_RESET_FALHA;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_E_RESET_HORIMETRO(System.Boolean CMD_RESET_HORIMETRO)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {CMD_RESET_HORIMETRO});
    }
    public bool FireEvent_E_RESET_HORIMETRO(Hidryco.HidrycoLib.Symbols.Motor_Inversor.E_RESET_HORIMETROEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.CMD_RESET_HORIMETRO.HasValue) _values_[0] = ea.CMD_RESET_HORIMETRO.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_E_RESET_HORIMETRO(System.Boolean CMD_RESET_HORIMETRO, bool ignore_CMD_RESET_HORIMETRO)
    {
      object[] _values_ = new object[1];
      if (!ignore_CMD_RESET_HORIMETRO) _values_[0] = CMD_RESET_HORIMETRO;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_E_RESET_NUMERO_PARTIDAS(System.Boolean CMD_RESET_NUMERO_PARTIDA)
    {
      return ((IHMIAccessorOutput)this).FireEvent(2, new object[] {CMD_RESET_NUMERO_PARTIDA});
    }
    public bool FireEvent_E_RESET_NUMERO_PARTIDAS(Hidryco.HidrycoLib.Symbols.Motor_Inversor.E_RESET_NUMERO_PARTIDASEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.CMD_RESET_NUMERO_PARTIDA.HasValue) _values_[0] = ea.CMD_RESET_NUMERO_PARTIDA.Value;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_E_RESET_NUMERO_PARTIDAS(System.Boolean CMD_RESET_NUMERO_PARTIDA, bool ignore_CMD_RESET_NUMERO_PARTIDA)
    {
      object[] _values_ = new object[1];
      if (!ignore_CMD_RESET_NUMERO_PARTIDA) _values_[0] = CMD_RESET_NUMERO_PARTIDA;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_E_COMANDO_MANUAL(System.Boolean CMD_MANUAL)
    {
      return ((IHMIAccessorOutput)this).FireEvent(3, new object[] {CMD_MANUAL});
    }
    public bool FireEvent_E_COMANDO_MANUAL(Hidryco.HidrycoLib.Symbols.Motor_Inversor.E_COMANDO_MANUALEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.CMD_MANUAL.HasValue) _values_[0] = ea.CMD_MANUAL.Value;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_E_COMANDO_MANUAL(System.Boolean CMD_MANUAL, bool ignore_CMD_MANUAL)
    {
      object[] _values_ = new object[1];
      if (!ignore_CMD_MANUAL) _values_[0] = CMD_MANUAL;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_E_MODO_OPERACAO(System.Boolean STS_AUTOMATICO)
    {
      return ((IHMIAccessorOutput)this).FireEvent(4, new object[] {STS_AUTOMATICO});
    }
    public bool FireEvent_E_MODO_OPERACAO(Hidryco.HidrycoLib.Symbols.Motor_Inversor.E_MODO_OPERACAOEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.STS_AUTOMATICO.HasValue) _values_[0] = ea.STS_AUTOMATICO.Value;
      return ((IHMIAccessorOutput)this).FireEvent(4, _values_);
    }
    public bool FireEvent_E_MODO_OPERACAO(System.Boolean STS_AUTOMATICO, bool ignore_STS_AUTOMATICO)
    {
      object[] _values_ = new object[1];
      if (!ignore_STS_AUTOMATICO) _values_[0] = STS_AUTOMATICO;
      return ((IHMIAccessorOutput)this).FireEvent(4, _values_);
    }
    public bool FireEvent_E_AJUSTE_STP(System.UInt16 STP_FALHA_LIGAMENTO, System.UInt16 STP_FALHA_DESLIGAMENTO, System.Single STP_SAIDA_MANUAL)
    {
      return ((IHMIAccessorOutput)this).FireEvent(5, new object[] {STP_FALHA_LIGAMENTO, STP_FALHA_DESLIGAMENTO, STP_SAIDA_MANUAL});
    }
    public bool FireEvent_E_AJUSTE_STP(Hidryco.HidrycoLib.Symbols.Motor_Inversor.E_AJUSTE_STPEventArgs ea)
    {
      object[] _values_ = new object[3];
      if (ea.STP_FALHA_LIGAMENTO.HasValue) _values_[0] = ea.STP_FALHA_LIGAMENTO.Value;
      if (ea.STP_FALHA_DESLIGAMENTO.HasValue) _values_[1] = ea.STP_FALHA_DESLIGAMENTO.Value;
      if (ea.STP_SAIDA_MANUAL.HasValue) _values_[2] = ea.STP_SAIDA_MANUAL.Value;
      return ((IHMIAccessorOutput)this).FireEvent(5, _values_);
    }
    public bool FireEvent_E_AJUSTE_STP(System.UInt16 STP_FALHA_LIGAMENTO, bool ignore_STP_FALHA_LIGAMENTO, System.UInt16 STP_FALHA_DESLIGAMENTO, bool ignore_STP_FALHA_DESLIGAMENTO, System.Single STP_SAIDA_MANUAL, bool ignore_STP_SAIDA_MANUAL)
    {
      object[] _values_ = new object[3];
      if (!ignore_STP_FALHA_LIGAMENTO) _values_[0] = STP_FALHA_LIGAMENTO;
      if (!ignore_STP_FALHA_DESLIGAMENTO) _values_[1] = STP_FALHA_DESLIGAMENTO;
      if (!ignore_STP_SAIDA_MANUAL) _values_[2] = STP_SAIDA_MANUAL;
      return ((IHMIAccessorOutput)this).FireEvent(5, _values_);
    }

  }
}

namespace Hidryco.HidrycoLib.Faceplates.Motor_Inversor
{
  partial class Faceplate2
  {

    private event EventHandler<Hidryco.HidrycoLib.Symbols.Motor_Inversor.REQEventArgs> REQ_Fired;

    protected override void OnEndInit()
    {
      if (REQ_Fired != null)
        AttachEventInput(0);

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
              REQ_Fired(this, new Hidryco.HidrycoLib.Symbols.Motor_Inversor.REQEventArgs(channelId, cookie, eventIndex));
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
    public bool FireEvent_E_RESET_FALHA(System.Boolean CMD_RESET_FALHA)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {CMD_RESET_FALHA});
    }
    public bool FireEvent_E_RESET_FALHA(Hidryco.HidrycoLib.Symbols.Motor_Inversor.E_RESET_FALHAEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.CMD_RESET_FALHA.HasValue) _values_[0] = ea.CMD_RESET_FALHA.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_E_RESET_FALHA(System.Boolean CMD_RESET_FALHA, bool ignore_CMD_RESET_FALHA)
    {
      object[] _values_ = new object[1];
      if (!ignore_CMD_RESET_FALHA) _values_[0] = CMD_RESET_FALHA;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_E_RESET_HORIMETRO(System.Boolean CMD_RESET_HORIMETRO)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {CMD_RESET_HORIMETRO});
    }
    public bool FireEvent_E_RESET_HORIMETRO(Hidryco.HidrycoLib.Symbols.Motor_Inversor.E_RESET_HORIMETROEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.CMD_RESET_HORIMETRO.HasValue) _values_[0] = ea.CMD_RESET_HORIMETRO.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_E_RESET_HORIMETRO(System.Boolean CMD_RESET_HORIMETRO, bool ignore_CMD_RESET_HORIMETRO)
    {
      object[] _values_ = new object[1];
      if (!ignore_CMD_RESET_HORIMETRO) _values_[0] = CMD_RESET_HORIMETRO;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_E_RESET_NUMERO_PARTIDAS(System.Boolean CMD_RESET_NUMERO_PARTIDA)
    {
      return ((IHMIAccessorOutput)this).FireEvent(2, new object[] {CMD_RESET_NUMERO_PARTIDA});
    }
    public bool FireEvent_E_RESET_NUMERO_PARTIDAS(Hidryco.HidrycoLib.Symbols.Motor_Inversor.E_RESET_NUMERO_PARTIDASEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.CMD_RESET_NUMERO_PARTIDA.HasValue) _values_[0] = ea.CMD_RESET_NUMERO_PARTIDA.Value;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_E_RESET_NUMERO_PARTIDAS(System.Boolean CMD_RESET_NUMERO_PARTIDA, bool ignore_CMD_RESET_NUMERO_PARTIDA)
    {
      object[] _values_ = new object[1];
      if (!ignore_CMD_RESET_NUMERO_PARTIDA) _values_[0] = CMD_RESET_NUMERO_PARTIDA;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_E_COMANDO_MANUAL(System.Boolean CMD_MANUAL)
    {
      return ((IHMIAccessorOutput)this).FireEvent(3, new object[] {CMD_MANUAL});
    }
    public bool FireEvent_E_COMANDO_MANUAL(Hidryco.HidrycoLib.Symbols.Motor_Inversor.E_COMANDO_MANUALEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.CMD_MANUAL.HasValue) _values_[0] = ea.CMD_MANUAL.Value;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_E_COMANDO_MANUAL(System.Boolean CMD_MANUAL, bool ignore_CMD_MANUAL)
    {
      object[] _values_ = new object[1];
      if (!ignore_CMD_MANUAL) _values_[0] = CMD_MANUAL;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_E_MODO_OPERACAO(System.Boolean STS_AUTOMATICO)
    {
      return ((IHMIAccessorOutput)this).FireEvent(4, new object[] {STS_AUTOMATICO});
    }
    public bool FireEvent_E_MODO_OPERACAO(Hidryco.HidrycoLib.Symbols.Motor_Inversor.E_MODO_OPERACAOEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.STS_AUTOMATICO.HasValue) _values_[0] = ea.STS_AUTOMATICO.Value;
      return ((IHMIAccessorOutput)this).FireEvent(4, _values_);
    }
    public bool FireEvent_E_MODO_OPERACAO(System.Boolean STS_AUTOMATICO, bool ignore_STS_AUTOMATICO)
    {
      object[] _values_ = new object[1];
      if (!ignore_STS_AUTOMATICO) _values_[0] = STS_AUTOMATICO;
      return ((IHMIAccessorOutput)this).FireEvent(4, _values_);
    }
    public bool FireEvent_E_AJUSTE_STP(System.UInt16 STP_FALHA_LIGAMENTO, System.UInt16 STP_FALHA_DESLIGAMENTO, System.Single STP_SAIDA_MANUAL)
    {
      return ((IHMIAccessorOutput)this).FireEvent(5, new object[] {STP_FALHA_LIGAMENTO, STP_FALHA_DESLIGAMENTO, STP_SAIDA_MANUAL});
    }
    public bool FireEvent_E_AJUSTE_STP(Hidryco.HidrycoLib.Symbols.Motor_Inversor.E_AJUSTE_STPEventArgs ea)
    {
      object[] _values_ = new object[3];
      if (ea.STP_FALHA_LIGAMENTO.HasValue) _values_[0] = ea.STP_FALHA_LIGAMENTO.Value;
      if (ea.STP_FALHA_DESLIGAMENTO.HasValue) _values_[1] = ea.STP_FALHA_DESLIGAMENTO.Value;
      if (ea.STP_SAIDA_MANUAL.HasValue) _values_[2] = ea.STP_SAIDA_MANUAL.Value;
      return ((IHMIAccessorOutput)this).FireEvent(5, _values_);
    }
    public bool FireEvent_E_AJUSTE_STP(System.UInt16 STP_FALHA_LIGAMENTO, bool ignore_STP_FALHA_LIGAMENTO, System.UInt16 STP_FALHA_DESLIGAMENTO, bool ignore_STP_FALHA_DESLIGAMENTO, System.Single STP_SAIDA_MANUAL, bool ignore_STP_SAIDA_MANUAL)
    {
      object[] _values_ = new object[3];
      if (!ignore_STP_FALHA_LIGAMENTO) _values_[0] = STP_FALHA_LIGAMENTO;
      if (!ignore_STP_FALHA_DESLIGAMENTO) _values_[1] = STP_FALHA_DESLIGAMENTO;
      if (!ignore_STP_SAIDA_MANUAL) _values_[2] = STP_SAIDA_MANUAL;
      return ((IHMIAccessorOutput)this).FireEvent(5, _values_);
    }

  }
}

namespace Hidryco.HidrycoLib.Faceplates.Motor_Inversor
{
  partial class Faceplate3
  {

    private event EventHandler<Hidryco.HidrycoLib.Symbols.Motor_Inversor.REQEventArgs> REQ_Fired;

    protected override void OnEndInit()
    {
      if (REQ_Fired != null)
        AttachEventInput(0);

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
              REQ_Fired(this, new Hidryco.HidrycoLib.Symbols.Motor_Inversor.REQEventArgs(channelId, cookie, eventIndex));
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
    public bool FireEvent_E_RESET_FALHA(System.Boolean CMD_RESET_FALHA)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {CMD_RESET_FALHA});
    }
    public bool FireEvent_E_RESET_FALHA(Hidryco.HidrycoLib.Symbols.Motor_Inversor.E_RESET_FALHAEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.CMD_RESET_FALHA.HasValue) _values_[0] = ea.CMD_RESET_FALHA.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_E_RESET_FALHA(System.Boolean CMD_RESET_FALHA, bool ignore_CMD_RESET_FALHA)
    {
      object[] _values_ = new object[1];
      if (!ignore_CMD_RESET_FALHA) _values_[0] = CMD_RESET_FALHA;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_E_RESET_HORIMETRO(System.Boolean CMD_RESET_HORIMETRO)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {CMD_RESET_HORIMETRO});
    }
    public bool FireEvent_E_RESET_HORIMETRO(Hidryco.HidrycoLib.Symbols.Motor_Inversor.E_RESET_HORIMETROEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.CMD_RESET_HORIMETRO.HasValue) _values_[0] = ea.CMD_RESET_HORIMETRO.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_E_RESET_HORIMETRO(System.Boolean CMD_RESET_HORIMETRO, bool ignore_CMD_RESET_HORIMETRO)
    {
      object[] _values_ = new object[1];
      if (!ignore_CMD_RESET_HORIMETRO) _values_[0] = CMD_RESET_HORIMETRO;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_E_RESET_NUMERO_PARTIDAS(System.Boolean CMD_RESET_NUMERO_PARTIDA)
    {
      return ((IHMIAccessorOutput)this).FireEvent(2, new object[] {CMD_RESET_NUMERO_PARTIDA});
    }
    public bool FireEvent_E_RESET_NUMERO_PARTIDAS(Hidryco.HidrycoLib.Symbols.Motor_Inversor.E_RESET_NUMERO_PARTIDASEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.CMD_RESET_NUMERO_PARTIDA.HasValue) _values_[0] = ea.CMD_RESET_NUMERO_PARTIDA.Value;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_E_RESET_NUMERO_PARTIDAS(System.Boolean CMD_RESET_NUMERO_PARTIDA, bool ignore_CMD_RESET_NUMERO_PARTIDA)
    {
      object[] _values_ = new object[1];
      if (!ignore_CMD_RESET_NUMERO_PARTIDA) _values_[0] = CMD_RESET_NUMERO_PARTIDA;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_E_COMANDO_MANUAL(System.Boolean CMD_MANUAL)
    {
      return ((IHMIAccessorOutput)this).FireEvent(3, new object[] {CMD_MANUAL});
    }
    public bool FireEvent_E_COMANDO_MANUAL(Hidryco.HidrycoLib.Symbols.Motor_Inversor.E_COMANDO_MANUALEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.CMD_MANUAL.HasValue) _values_[0] = ea.CMD_MANUAL.Value;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_E_COMANDO_MANUAL(System.Boolean CMD_MANUAL, bool ignore_CMD_MANUAL)
    {
      object[] _values_ = new object[1];
      if (!ignore_CMD_MANUAL) _values_[0] = CMD_MANUAL;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_E_MODO_OPERACAO(System.Boolean STS_AUTOMATICO)
    {
      return ((IHMIAccessorOutput)this).FireEvent(4, new object[] {STS_AUTOMATICO});
    }
    public bool FireEvent_E_MODO_OPERACAO(Hidryco.HidrycoLib.Symbols.Motor_Inversor.E_MODO_OPERACAOEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.STS_AUTOMATICO.HasValue) _values_[0] = ea.STS_AUTOMATICO.Value;
      return ((IHMIAccessorOutput)this).FireEvent(4, _values_);
    }
    public bool FireEvent_E_MODO_OPERACAO(System.Boolean STS_AUTOMATICO, bool ignore_STS_AUTOMATICO)
    {
      object[] _values_ = new object[1];
      if (!ignore_STS_AUTOMATICO) _values_[0] = STS_AUTOMATICO;
      return ((IHMIAccessorOutput)this).FireEvent(4, _values_);
    }
    public bool FireEvent_E_AJUSTE_STP(System.UInt16 STP_FALHA_LIGAMENTO, System.UInt16 STP_FALHA_DESLIGAMENTO, System.Single STP_SAIDA_MANUAL)
    {
      return ((IHMIAccessorOutput)this).FireEvent(5, new object[] {STP_FALHA_LIGAMENTO, STP_FALHA_DESLIGAMENTO, STP_SAIDA_MANUAL});
    }
    public bool FireEvent_E_AJUSTE_STP(Hidryco.HidrycoLib.Symbols.Motor_Inversor.E_AJUSTE_STPEventArgs ea)
    {
      object[] _values_ = new object[3];
      if (ea.STP_FALHA_LIGAMENTO.HasValue) _values_[0] = ea.STP_FALHA_LIGAMENTO.Value;
      if (ea.STP_FALHA_DESLIGAMENTO.HasValue) _values_[1] = ea.STP_FALHA_DESLIGAMENTO.Value;
      if (ea.STP_SAIDA_MANUAL.HasValue) _values_[2] = ea.STP_SAIDA_MANUAL.Value;
      return ((IHMIAccessorOutput)this).FireEvent(5, _values_);
    }
    public bool FireEvent_E_AJUSTE_STP(System.UInt16 STP_FALHA_LIGAMENTO, bool ignore_STP_FALHA_LIGAMENTO, System.UInt16 STP_FALHA_DESLIGAMENTO, bool ignore_STP_FALHA_DESLIGAMENTO, System.Single STP_SAIDA_MANUAL, bool ignore_STP_SAIDA_MANUAL)
    {
      object[] _values_ = new object[3];
      if (!ignore_STP_FALHA_LIGAMENTO) _values_[0] = STP_FALHA_LIGAMENTO;
      if (!ignore_STP_FALHA_DESLIGAMENTO) _values_[1] = STP_FALHA_DESLIGAMENTO;
      if (!ignore_STP_SAIDA_MANUAL) _values_[2] = STP_SAIDA_MANUAL;
      return ((IHMIAccessorOutput)this).FireEvent(5, _values_);
    }

  }
}

namespace Hidryco.HidrycoLib.Faceplates.Motor_Inversor
{
  partial class Faceplate4
  {

    private event EventHandler<Hidryco.HidrycoLib.Symbols.Motor_Inversor.REQEventArgs> REQ_Fired;

    protected override void OnEndInit()
    {
      if (REQ_Fired != null)
        AttachEventInput(0);

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
              REQ_Fired(this, new Hidryco.HidrycoLib.Symbols.Motor_Inversor.REQEventArgs(channelId, cookie, eventIndex));
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
    public bool FireEvent_E_RESET_FALHA(System.Boolean CMD_RESET_FALHA)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {CMD_RESET_FALHA});
    }
    public bool FireEvent_E_RESET_FALHA(Hidryco.HidrycoLib.Symbols.Motor_Inversor.E_RESET_FALHAEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.CMD_RESET_FALHA.HasValue) _values_[0] = ea.CMD_RESET_FALHA.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_E_RESET_FALHA(System.Boolean CMD_RESET_FALHA, bool ignore_CMD_RESET_FALHA)
    {
      object[] _values_ = new object[1];
      if (!ignore_CMD_RESET_FALHA) _values_[0] = CMD_RESET_FALHA;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_E_RESET_HORIMETRO(System.Boolean CMD_RESET_HORIMETRO)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {CMD_RESET_HORIMETRO});
    }
    public bool FireEvent_E_RESET_HORIMETRO(Hidryco.HidrycoLib.Symbols.Motor_Inversor.E_RESET_HORIMETROEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.CMD_RESET_HORIMETRO.HasValue) _values_[0] = ea.CMD_RESET_HORIMETRO.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_E_RESET_HORIMETRO(System.Boolean CMD_RESET_HORIMETRO, bool ignore_CMD_RESET_HORIMETRO)
    {
      object[] _values_ = new object[1];
      if (!ignore_CMD_RESET_HORIMETRO) _values_[0] = CMD_RESET_HORIMETRO;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_E_RESET_NUMERO_PARTIDAS(System.Boolean CMD_RESET_NUMERO_PARTIDA)
    {
      return ((IHMIAccessorOutput)this).FireEvent(2, new object[] {CMD_RESET_NUMERO_PARTIDA});
    }
    public bool FireEvent_E_RESET_NUMERO_PARTIDAS(Hidryco.HidrycoLib.Symbols.Motor_Inversor.E_RESET_NUMERO_PARTIDASEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.CMD_RESET_NUMERO_PARTIDA.HasValue) _values_[0] = ea.CMD_RESET_NUMERO_PARTIDA.Value;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_E_RESET_NUMERO_PARTIDAS(System.Boolean CMD_RESET_NUMERO_PARTIDA, bool ignore_CMD_RESET_NUMERO_PARTIDA)
    {
      object[] _values_ = new object[1];
      if (!ignore_CMD_RESET_NUMERO_PARTIDA) _values_[0] = CMD_RESET_NUMERO_PARTIDA;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_E_COMANDO_MANUAL(System.Boolean CMD_MANUAL)
    {
      return ((IHMIAccessorOutput)this).FireEvent(3, new object[] {CMD_MANUAL});
    }
    public bool FireEvent_E_COMANDO_MANUAL(Hidryco.HidrycoLib.Symbols.Motor_Inversor.E_COMANDO_MANUALEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.CMD_MANUAL.HasValue) _values_[0] = ea.CMD_MANUAL.Value;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_E_COMANDO_MANUAL(System.Boolean CMD_MANUAL, bool ignore_CMD_MANUAL)
    {
      object[] _values_ = new object[1];
      if (!ignore_CMD_MANUAL) _values_[0] = CMD_MANUAL;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_E_MODO_OPERACAO(System.Boolean STS_AUTOMATICO)
    {
      return ((IHMIAccessorOutput)this).FireEvent(4, new object[] {STS_AUTOMATICO});
    }
    public bool FireEvent_E_MODO_OPERACAO(Hidryco.HidrycoLib.Symbols.Motor_Inversor.E_MODO_OPERACAOEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.STS_AUTOMATICO.HasValue) _values_[0] = ea.STS_AUTOMATICO.Value;
      return ((IHMIAccessorOutput)this).FireEvent(4, _values_);
    }
    public bool FireEvent_E_MODO_OPERACAO(System.Boolean STS_AUTOMATICO, bool ignore_STS_AUTOMATICO)
    {
      object[] _values_ = new object[1];
      if (!ignore_STS_AUTOMATICO) _values_[0] = STS_AUTOMATICO;
      return ((IHMIAccessorOutput)this).FireEvent(4, _values_);
    }
    public bool FireEvent_E_AJUSTE_STP(System.UInt16 STP_FALHA_LIGAMENTO, System.UInt16 STP_FALHA_DESLIGAMENTO, System.Single STP_SAIDA_MANUAL)
    {
      return ((IHMIAccessorOutput)this).FireEvent(5, new object[] {STP_FALHA_LIGAMENTO, STP_FALHA_DESLIGAMENTO, STP_SAIDA_MANUAL});
    }
    public bool FireEvent_E_AJUSTE_STP(Hidryco.HidrycoLib.Symbols.Motor_Inversor.E_AJUSTE_STPEventArgs ea)
    {
      object[] _values_ = new object[3];
      if (ea.STP_FALHA_LIGAMENTO.HasValue) _values_[0] = ea.STP_FALHA_LIGAMENTO.Value;
      if (ea.STP_FALHA_DESLIGAMENTO.HasValue) _values_[1] = ea.STP_FALHA_DESLIGAMENTO.Value;
      if (ea.STP_SAIDA_MANUAL.HasValue) _values_[2] = ea.STP_SAIDA_MANUAL.Value;
      return ((IHMIAccessorOutput)this).FireEvent(5, _values_);
    }
    public bool FireEvent_E_AJUSTE_STP(System.UInt16 STP_FALHA_LIGAMENTO, bool ignore_STP_FALHA_LIGAMENTO, System.UInt16 STP_FALHA_DESLIGAMENTO, bool ignore_STP_FALHA_DESLIGAMENTO, System.Single STP_SAIDA_MANUAL, bool ignore_STP_SAIDA_MANUAL)
    {
      object[] _values_ = new object[3];
      if (!ignore_STP_FALHA_LIGAMENTO) _values_[0] = STP_FALHA_LIGAMENTO;
      if (!ignore_STP_FALHA_DESLIGAMENTO) _values_[1] = STP_FALHA_DESLIGAMENTO;
      if (!ignore_STP_SAIDA_MANUAL) _values_[2] = STP_SAIDA_MANUAL;
      return ((IHMIAccessorOutput)this).FireEvent(5, _values_);
    }

  }
}

namespace Hidryco.HidrycoLib.Symbols.Motor_Inversor
{
  partial class sMotor
  {

    private event EventHandler<Hidryco.HidrycoLib.Symbols.Motor_Inversor.REQEventArgs> REQ_Fired;

    protected override void OnEndInit()
    {
      if (REQ_Fired != null)
        AttachEventInput(0);

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
              REQ_Fired(this, new Hidryco.HidrycoLib.Symbols.Motor_Inversor.REQEventArgs(channelId, cookie, eventIndex));
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
    public bool FireEvent_E_RESET_FALHA(System.Boolean CMD_RESET_FALHA)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {CMD_RESET_FALHA});
    }
    public bool FireEvent_E_RESET_FALHA(Hidryco.HidrycoLib.Symbols.Motor_Inversor.E_RESET_FALHAEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.CMD_RESET_FALHA.HasValue) _values_[0] = ea.CMD_RESET_FALHA.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_E_RESET_FALHA(System.Boolean CMD_RESET_FALHA, bool ignore_CMD_RESET_FALHA)
    {
      object[] _values_ = new object[1];
      if (!ignore_CMD_RESET_FALHA) _values_[0] = CMD_RESET_FALHA;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_E_RESET_HORIMETRO(System.Boolean CMD_RESET_HORIMETRO)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {CMD_RESET_HORIMETRO});
    }
    public bool FireEvent_E_RESET_HORIMETRO(Hidryco.HidrycoLib.Symbols.Motor_Inversor.E_RESET_HORIMETROEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.CMD_RESET_HORIMETRO.HasValue) _values_[0] = ea.CMD_RESET_HORIMETRO.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_E_RESET_HORIMETRO(System.Boolean CMD_RESET_HORIMETRO, bool ignore_CMD_RESET_HORIMETRO)
    {
      object[] _values_ = new object[1];
      if (!ignore_CMD_RESET_HORIMETRO) _values_[0] = CMD_RESET_HORIMETRO;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_E_RESET_NUMERO_PARTIDAS(System.Boolean CMD_RESET_NUMERO_PARTIDA)
    {
      return ((IHMIAccessorOutput)this).FireEvent(2, new object[] {CMD_RESET_NUMERO_PARTIDA});
    }
    public bool FireEvent_E_RESET_NUMERO_PARTIDAS(Hidryco.HidrycoLib.Symbols.Motor_Inversor.E_RESET_NUMERO_PARTIDASEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.CMD_RESET_NUMERO_PARTIDA.HasValue) _values_[0] = ea.CMD_RESET_NUMERO_PARTIDA.Value;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_E_RESET_NUMERO_PARTIDAS(System.Boolean CMD_RESET_NUMERO_PARTIDA, bool ignore_CMD_RESET_NUMERO_PARTIDA)
    {
      object[] _values_ = new object[1];
      if (!ignore_CMD_RESET_NUMERO_PARTIDA) _values_[0] = CMD_RESET_NUMERO_PARTIDA;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_E_COMANDO_MANUAL(System.Boolean CMD_MANUAL)
    {
      return ((IHMIAccessorOutput)this).FireEvent(3, new object[] {CMD_MANUAL});
    }
    public bool FireEvent_E_COMANDO_MANUAL(Hidryco.HidrycoLib.Symbols.Motor_Inversor.E_COMANDO_MANUALEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.CMD_MANUAL.HasValue) _values_[0] = ea.CMD_MANUAL.Value;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_E_COMANDO_MANUAL(System.Boolean CMD_MANUAL, bool ignore_CMD_MANUAL)
    {
      object[] _values_ = new object[1];
      if (!ignore_CMD_MANUAL) _values_[0] = CMD_MANUAL;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_E_MODO_OPERACAO(System.Boolean STS_AUTOMATICO)
    {
      return ((IHMIAccessorOutput)this).FireEvent(4, new object[] {STS_AUTOMATICO});
    }
    public bool FireEvent_E_MODO_OPERACAO(Hidryco.HidrycoLib.Symbols.Motor_Inversor.E_MODO_OPERACAOEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.STS_AUTOMATICO.HasValue) _values_[0] = ea.STS_AUTOMATICO.Value;
      return ((IHMIAccessorOutput)this).FireEvent(4, _values_);
    }
    public bool FireEvent_E_MODO_OPERACAO(System.Boolean STS_AUTOMATICO, bool ignore_STS_AUTOMATICO)
    {
      object[] _values_ = new object[1];
      if (!ignore_STS_AUTOMATICO) _values_[0] = STS_AUTOMATICO;
      return ((IHMIAccessorOutput)this).FireEvent(4, _values_);
    }
    public bool FireEvent_E_AJUSTE_STP(System.UInt16 STP_FALHA_LIGAMENTO, System.UInt16 STP_FALHA_DESLIGAMENTO, System.Single STP_SAIDA_MANUAL)
    {
      return ((IHMIAccessorOutput)this).FireEvent(5, new object[] {STP_FALHA_LIGAMENTO, STP_FALHA_DESLIGAMENTO, STP_SAIDA_MANUAL});
    }
    public bool FireEvent_E_AJUSTE_STP(Hidryco.HidrycoLib.Symbols.Motor_Inversor.E_AJUSTE_STPEventArgs ea)
    {
      object[] _values_ = new object[3];
      if (ea.STP_FALHA_LIGAMENTO.HasValue) _values_[0] = ea.STP_FALHA_LIGAMENTO.Value;
      if (ea.STP_FALHA_DESLIGAMENTO.HasValue) _values_[1] = ea.STP_FALHA_DESLIGAMENTO.Value;
      if (ea.STP_SAIDA_MANUAL.HasValue) _values_[2] = ea.STP_SAIDA_MANUAL.Value;
      return ((IHMIAccessorOutput)this).FireEvent(5, _values_);
    }
    public bool FireEvent_E_AJUSTE_STP(System.UInt16 STP_FALHA_LIGAMENTO, bool ignore_STP_FALHA_LIGAMENTO, System.UInt16 STP_FALHA_DESLIGAMENTO, bool ignore_STP_FALHA_DESLIGAMENTO, System.Single STP_SAIDA_MANUAL, bool ignore_STP_SAIDA_MANUAL)
    {
      object[] _values_ = new object[3];
      if (!ignore_STP_FALHA_LIGAMENTO) _values_[0] = STP_FALHA_LIGAMENTO;
      if (!ignore_STP_FALHA_DESLIGAMENTO) _values_[1] = STP_FALHA_DESLIGAMENTO;
      if (!ignore_STP_SAIDA_MANUAL) _values_[2] = STP_SAIDA_MANUAL;
      return ((IHMIAccessorOutput)this).FireEvent(5, _values_);
    }

  }
}

namespace Hidryco.HidrycoLib.Symbols.Motor_Inversor
{
  partial class sSoprador
  {

    private event EventHandler<Hidryco.HidrycoLib.Symbols.Motor_Inversor.REQEventArgs> REQ_Fired;

    protected override void OnEndInit()
    {
      if (REQ_Fired != null)
        AttachEventInput(0);

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
              REQ_Fired(this, new Hidryco.HidrycoLib.Symbols.Motor_Inversor.REQEventArgs(channelId, cookie, eventIndex));
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
    public bool FireEvent_E_RESET_FALHA(System.Boolean CMD_RESET_FALHA)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {CMD_RESET_FALHA});
    }
    public bool FireEvent_E_RESET_FALHA(Hidryco.HidrycoLib.Symbols.Motor_Inversor.E_RESET_FALHAEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.CMD_RESET_FALHA.HasValue) _values_[0] = ea.CMD_RESET_FALHA.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_E_RESET_FALHA(System.Boolean CMD_RESET_FALHA, bool ignore_CMD_RESET_FALHA)
    {
      object[] _values_ = new object[1];
      if (!ignore_CMD_RESET_FALHA) _values_[0] = CMD_RESET_FALHA;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_E_RESET_HORIMETRO(System.Boolean CMD_RESET_HORIMETRO)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {CMD_RESET_HORIMETRO});
    }
    public bool FireEvent_E_RESET_HORIMETRO(Hidryco.HidrycoLib.Symbols.Motor_Inversor.E_RESET_HORIMETROEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.CMD_RESET_HORIMETRO.HasValue) _values_[0] = ea.CMD_RESET_HORIMETRO.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_E_RESET_HORIMETRO(System.Boolean CMD_RESET_HORIMETRO, bool ignore_CMD_RESET_HORIMETRO)
    {
      object[] _values_ = new object[1];
      if (!ignore_CMD_RESET_HORIMETRO) _values_[0] = CMD_RESET_HORIMETRO;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_E_RESET_NUMERO_PARTIDAS(System.Boolean CMD_RESET_NUMERO_PARTIDA)
    {
      return ((IHMIAccessorOutput)this).FireEvent(2, new object[] {CMD_RESET_NUMERO_PARTIDA});
    }
    public bool FireEvent_E_RESET_NUMERO_PARTIDAS(Hidryco.HidrycoLib.Symbols.Motor_Inversor.E_RESET_NUMERO_PARTIDASEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.CMD_RESET_NUMERO_PARTIDA.HasValue) _values_[0] = ea.CMD_RESET_NUMERO_PARTIDA.Value;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_E_RESET_NUMERO_PARTIDAS(System.Boolean CMD_RESET_NUMERO_PARTIDA, bool ignore_CMD_RESET_NUMERO_PARTIDA)
    {
      object[] _values_ = new object[1];
      if (!ignore_CMD_RESET_NUMERO_PARTIDA) _values_[0] = CMD_RESET_NUMERO_PARTIDA;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_E_COMANDO_MANUAL(System.Boolean CMD_MANUAL)
    {
      return ((IHMIAccessorOutput)this).FireEvent(3, new object[] {CMD_MANUAL});
    }
    public bool FireEvent_E_COMANDO_MANUAL(Hidryco.HidrycoLib.Symbols.Motor_Inversor.E_COMANDO_MANUALEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.CMD_MANUAL.HasValue) _values_[0] = ea.CMD_MANUAL.Value;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_E_COMANDO_MANUAL(System.Boolean CMD_MANUAL, bool ignore_CMD_MANUAL)
    {
      object[] _values_ = new object[1];
      if (!ignore_CMD_MANUAL) _values_[0] = CMD_MANUAL;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_E_MODO_OPERACAO(System.Boolean STS_AUTOMATICO)
    {
      return ((IHMIAccessorOutput)this).FireEvent(4, new object[] {STS_AUTOMATICO});
    }
    public bool FireEvent_E_MODO_OPERACAO(Hidryco.HidrycoLib.Symbols.Motor_Inversor.E_MODO_OPERACAOEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.STS_AUTOMATICO.HasValue) _values_[0] = ea.STS_AUTOMATICO.Value;
      return ((IHMIAccessorOutput)this).FireEvent(4, _values_);
    }
    public bool FireEvent_E_MODO_OPERACAO(System.Boolean STS_AUTOMATICO, bool ignore_STS_AUTOMATICO)
    {
      object[] _values_ = new object[1];
      if (!ignore_STS_AUTOMATICO) _values_[0] = STS_AUTOMATICO;
      return ((IHMIAccessorOutput)this).FireEvent(4, _values_);
    }
    public bool FireEvent_E_AJUSTE_STP(System.UInt16 STP_FALHA_LIGAMENTO, System.UInt16 STP_FALHA_DESLIGAMENTO, System.Single STP_SAIDA_MANUAL)
    {
      return ((IHMIAccessorOutput)this).FireEvent(5, new object[] {STP_FALHA_LIGAMENTO, STP_FALHA_DESLIGAMENTO, STP_SAIDA_MANUAL});
    }
    public bool FireEvent_E_AJUSTE_STP(Hidryco.HidrycoLib.Symbols.Motor_Inversor.E_AJUSTE_STPEventArgs ea)
    {
      object[] _values_ = new object[3];
      if (ea.STP_FALHA_LIGAMENTO.HasValue) _values_[0] = ea.STP_FALHA_LIGAMENTO.Value;
      if (ea.STP_FALHA_DESLIGAMENTO.HasValue) _values_[1] = ea.STP_FALHA_DESLIGAMENTO.Value;
      if (ea.STP_SAIDA_MANUAL.HasValue) _values_[2] = ea.STP_SAIDA_MANUAL.Value;
      return ((IHMIAccessorOutput)this).FireEvent(5, _values_);
    }
    public bool FireEvent_E_AJUSTE_STP(System.UInt16 STP_FALHA_LIGAMENTO, bool ignore_STP_FALHA_LIGAMENTO, System.UInt16 STP_FALHA_DESLIGAMENTO, bool ignore_STP_FALHA_DESLIGAMENTO, System.Single STP_SAIDA_MANUAL, bool ignore_STP_SAIDA_MANUAL)
    {
      object[] _values_ = new object[3];
      if (!ignore_STP_FALHA_LIGAMENTO) _values_[0] = STP_FALHA_LIGAMENTO;
      if (!ignore_STP_FALHA_DESLIGAMENTO) _values_[1] = STP_FALHA_DESLIGAMENTO;
      if (!ignore_STP_SAIDA_MANUAL) _values_[2] = STP_SAIDA_MANUAL;
      return ((IHMIAccessorOutput)this).FireEvent(5, _values_);
    }

  }
}
#endregion #Motor_Inversor_HMI;

#endregion Definitions;
