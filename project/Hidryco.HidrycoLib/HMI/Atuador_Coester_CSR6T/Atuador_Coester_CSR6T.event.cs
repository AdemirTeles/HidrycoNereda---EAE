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
#region #Atuador_Coester_CSR6T_HMI;

namespace Hidryco.HidrycoLib.Symbols.Atuador_Coester_CSR6T
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

    public bool Get_STS_POSICAO_ATUAL(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,2, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? STS_POSICAO_ATUAL
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,2, ref var);
      if (!ret) return null;
      return (System.Int16) var;
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

    public bool Get_STS_ABERTO(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,5, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_ABERTO
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,5, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_FECHADO(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,6, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_FECHADO
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,6, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_ALARME(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,7, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_ALARME
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,7, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_configShowPositioner(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,8, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? configShowPositioner
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,8, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }


  }

}

namespace Hidryco.HidrycoLib.Symbols.Atuador_Coester_CSR6T
{

  public class E_STS_AUTOMATICOEventArgs : System.EventArgs
  {
    public E_STS_AUTOMATICOEventArgs()
    {
    }
    private System.Boolean? STS_AUTOMATICO_field = null;
    public System.Boolean? STS_AUTOMATICO
    {
       get { return STS_AUTOMATICO_field; }
       set { STS_AUTOMATICO_field = value; }
    }

  }

  public class E_CMD_ABRIR_MANUALEventArgs : System.EventArgs
  {
    public E_CMD_ABRIR_MANUALEventArgs()
    {
    }
    private System.Boolean? CMD_ABRIR_MANUAL_field = null;
    public System.Boolean? CMD_ABRIR_MANUAL
    {
       get { return CMD_ABRIR_MANUAL_field; }
       set { CMD_ABRIR_MANUAL_field = value; }
    }

  }

  public class E_CMD_FECHAR_MANUALEventArgs : System.EventArgs
  {
    public E_CMD_FECHAR_MANUALEventArgs()
    {
    }
    private System.Boolean? CMD_FECHAR_MANUAL_field = null;
    public System.Boolean? CMD_FECHAR_MANUAL
    {
       get { return CMD_FECHAR_MANUAL_field; }
       set { CMD_FECHAR_MANUAL_field = value; }
    }

  }

  public class E_CMD_POSICIONAR_MANUALEventArgs : System.EventArgs
  {
    public E_CMD_POSICIONAR_MANUALEventArgs()
    {
    }
    private System.Boolean? CMD_POSICIONAR_MANUAL_field = null;
    public System.Boolean? CMD_POSICIONAR_MANUAL
    {
       get { return CMD_POSICIONAR_MANUAL_field; }
       set { CMD_POSICIONAR_MANUAL_field = value; }
    }

  }

  public class E_CMD_PARAR_MANUALEventArgs : System.EventArgs
  {
    public E_CMD_PARAR_MANUALEventArgs()
    {
    }
    private System.Boolean? CMD_PARAR_MANUAL_field = null;
    public System.Boolean? CMD_PARAR_MANUAL
    {
       get { return CMD_PARAR_MANUAL_field; }
       set { CMD_PARAR_MANUAL_field = value; }
    }

  }

  public class E_CMD_RESET_FALHAEventArgs : System.EventArgs
  {
    public E_CMD_RESET_FALHAEventArgs()
    {
    }
    private System.Boolean? CMD_RESET_FALHA_field = null;
    public System.Boolean? CMD_RESET_FALHA
    {
       get { return CMD_RESET_FALHA_field; }
       set { CMD_RESET_FALHA_field = value; }
    }

  }

  public class CNFEventArgs : System.EventArgs
  {
    public CNFEventArgs()
    {
    }
    private System.UInt16? STP_FALHA_ABERTURA_field = null;
    public System.UInt16? STP_FALHA_ABERTURA
    {
       get { return STP_FALHA_ABERTURA_field; }
       set { STP_FALHA_ABERTURA_field = value; }
    }
    private System.UInt16? STP_FALHA_FECHAMENTO_field = null;
    public System.UInt16? STP_FALHA_FECHAMENTO
    {
       get { return STP_FALHA_FECHAMENTO_field; }
       set { STP_FALHA_FECHAMENTO_field = value; }
    }
    private System.Int16? STP_POSICAO_DESEJADA_MANUAL_field = null;
    public System.Int16? STP_POSICAO_DESEJADA_MANUAL
    {
       get { return STP_POSICAO_DESEJADA_MANUAL_field; }
       set { STP_POSICAO_DESEJADA_MANUAL_field = value; }
    }

  }

}

namespace Hidryco.HidrycoLib.Symbols.Atuador_Coester_CSR6T
{
  partial class Valvula
  {

    private event EventHandler<Hidryco.HidrycoLib.Symbols.Atuador_Coester_CSR6T.REQEventArgs> REQ_Fired;

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
              REQ_Fired(this, new Hidryco.HidrycoLib.Symbols.Atuador_Coester_CSR6T.REQEventArgs(channelId, cookie, eventIndex));
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
    public bool FireEvent_E_STS_AUTOMATICO(System.Boolean STS_AUTOMATICO)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {STS_AUTOMATICO});
    }
    public bool FireEvent_E_STS_AUTOMATICO(Hidryco.HidrycoLib.Symbols.Atuador_Coester_CSR6T.E_STS_AUTOMATICOEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.STS_AUTOMATICO.HasValue) _values_[0] = ea.STS_AUTOMATICO.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_E_STS_AUTOMATICO(System.Boolean STS_AUTOMATICO, bool ignore_STS_AUTOMATICO)
    {
      object[] _values_ = new object[1];
      if (!ignore_STS_AUTOMATICO) _values_[0] = STS_AUTOMATICO;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_E_CMD_ABRIR_MANUAL(System.Boolean CMD_ABRIR_MANUAL)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {CMD_ABRIR_MANUAL});
    }
    public bool FireEvent_E_CMD_ABRIR_MANUAL(Hidryco.HidrycoLib.Symbols.Atuador_Coester_CSR6T.E_CMD_ABRIR_MANUALEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.CMD_ABRIR_MANUAL.HasValue) _values_[0] = ea.CMD_ABRIR_MANUAL.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_E_CMD_ABRIR_MANUAL(System.Boolean CMD_ABRIR_MANUAL, bool ignore_CMD_ABRIR_MANUAL)
    {
      object[] _values_ = new object[1];
      if (!ignore_CMD_ABRIR_MANUAL) _values_[0] = CMD_ABRIR_MANUAL;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_E_CMD_FECHAR_MANUAL(System.Boolean CMD_FECHAR_MANUAL)
    {
      return ((IHMIAccessorOutput)this).FireEvent(2, new object[] {CMD_FECHAR_MANUAL});
    }
    public bool FireEvent_E_CMD_FECHAR_MANUAL(Hidryco.HidrycoLib.Symbols.Atuador_Coester_CSR6T.E_CMD_FECHAR_MANUALEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.CMD_FECHAR_MANUAL.HasValue) _values_[0] = ea.CMD_FECHAR_MANUAL.Value;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_E_CMD_FECHAR_MANUAL(System.Boolean CMD_FECHAR_MANUAL, bool ignore_CMD_FECHAR_MANUAL)
    {
      object[] _values_ = new object[1];
      if (!ignore_CMD_FECHAR_MANUAL) _values_[0] = CMD_FECHAR_MANUAL;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_E_CMD_POSICIONAR_MANUAL(System.Boolean CMD_POSICIONAR_MANUAL)
    {
      return ((IHMIAccessorOutput)this).FireEvent(3, new object[] {CMD_POSICIONAR_MANUAL});
    }
    public bool FireEvent_E_CMD_POSICIONAR_MANUAL(Hidryco.HidrycoLib.Symbols.Atuador_Coester_CSR6T.E_CMD_POSICIONAR_MANUALEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.CMD_POSICIONAR_MANUAL.HasValue) _values_[0] = ea.CMD_POSICIONAR_MANUAL.Value;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_E_CMD_POSICIONAR_MANUAL(System.Boolean CMD_POSICIONAR_MANUAL, bool ignore_CMD_POSICIONAR_MANUAL)
    {
      object[] _values_ = new object[1];
      if (!ignore_CMD_POSICIONAR_MANUAL) _values_[0] = CMD_POSICIONAR_MANUAL;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_E_CMD_PARAR_MANUAL(System.Boolean CMD_PARAR_MANUAL)
    {
      return ((IHMIAccessorOutput)this).FireEvent(4, new object[] {CMD_PARAR_MANUAL});
    }
    public bool FireEvent_E_CMD_PARAR_MANUAL(Hidryco.HidrycoLib.Symbols.Atuador_Coester_CSR6T.E_CMD_PARAR_MANUALEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.CMD_PARAR_MANUAL.HasValue) _values_[0] = ea.CMD_PARAR_MANUAL.Value;
      return ((IHMIAccessorOutput)this).FireEvent(4, _values_);
    }
    public bool FireEvent_E_CMD_PARAR_MANUAL(System.Boolean CMD_PARAR_MANUAL, bool ignore_CMD_PARAR_MANUAL)
    {
      object[] _values_ = new object[1];
      if (!ignore_CMD_PARAR_MANUAL) _values_[0] = CMD_PARAR_MANUAL;
      return ((IHMIAccessorOutput)this).FireEvent(4, _values_);
    }
    public bool FireEvent_E_CMD_RESET_FALHA(System.Boolean CMD_RESET_FALHA)
    {
      return ((IHMIAccessorOutput)this).FireEvent(5, new object[] {CMD_RESET_FALHA});
    }
    public bool FireEvent_E_CMD_RESET_FALHA(Hidryco.HidrycoLib.Symbols.Atuador_Coester_CSR6T.E_CMD_RESET_FALHAEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.CMD_RESET_FALHA.HasValue) _values_[0] = ea.CMD_RESET_FALHA.Value;
      return ((IHMIAccessorOutput)this).FireEvent(5, _values_);
    }
    public bool FireEvent_E_CMD_RESET_FALHA(System.Boolean CMD_RESET_FALHA, bool ignore_CMD_RESET_FALHA)
    {
      object[] _values_ = new object[1];
      if (!ignore_CMD_RESET_FALHA) _values_[0] = CMD_RESET_FALHA;
      return ((IHMIAccessorOutput)this).FireEvent(5, _values_);
    }
    public bool FireEvent_CNF(System.UInt16 STP_FALHA_ABERTURA, System.UInt16 STP_FALHA_FECHAMENTO, System.Int16 STP_POSICAO_DESEJADA_MANUAL)
    {
      return ((IHMIAccessorOutput)this).FireEvent(6, new object[] {STP_FALHA_ABERTURA, STP_FALHA_FECHAMENTO, STP_POSICAO_DESEJADA_MANUAL});
    }
    public bool FireEvent_CNF(Hidryco.HidrycoLib.Symbols.Atuador_Coester_CSR6T.CNFEventArgs ea)
    {
      object[] _values_ = new object[3];
      if (ea.STP_FALHA_ABERTURA.HasValue) _values_[0] = ea.STP_FALHA_ABERTURA.Value;
      if (ea.STP_FALHA_FECHAMENTO.HasValue) _values_[1] = ea.STP_FALHA_FECHAMENTO.Value;
      if (ea.STP_POSICAO_DESEJADA_MANUAL.HasValue) _values_[2] = ea.STP_POSICAO_DESEJADA_MANUAL.Value;
      return ((IHMIAccessorOutput)this).FireEvent(6, _values_);
    }
    public bool FireEvent_CNF(System.UInt16 STP_FALHA_ABERTURA, bool ignore_STP_FALHA_ABERTURA, System.UInt16 STP_FALHA_FECHAMENTO, bool ignore_STP_FALHA_FECHAMENTO, System.Int16 STP_POSICAO_DESEJADA_MANUAL, bool ignore_STP_POSICAO_DESEJADA_MANUAL)
    {
      object[] _values_ = new object[3];
      if (!ignore_STP_FALHA_ABERTURA) _values_[0] = STP_FALHA_ABERTURA;
      if (!ignore_STP_FALHA_FECHAMENTO) _values_[1] = STP_FALHA_FECHAMENTO;
      if (!ignore_STP_POSICAO_DESEJADA_MANUAL) _values_[2] = STP_POSICAO_DESEJADA_MANUAL;
      return ((IHMIAccessorOutput)this).FireEvent(6, _values_);
    }

  }
}

namespace Hidryco.HidrycoLib.Faceplates.Atuador_Coester_CSR6T
{
  partial class fpPosicionador
  {

    private event EventHandler<Hidryco.HidrycoLib.Symbols.Atuador_Coester_CSR6T.REQEventArgs> REQ_Fired;

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
              REQ_Fired(this, new Hidryco.HidrycoLib.Symbols.Atuador_Coester_CSR6T.REQEventArgs(channelId, cookie, eventIndex));
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
    public bool FireEvent_E_STS_AUTOMATICO(System.Boolean STS_AUTOMATICO)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {STS_AUTOMATICO});
    }
    public bool FireEvent_E_STS_AUTOMATICO(Hidryco.HidrycoLib.Symbols.Atuador_Coester_CSR6T.E_STS_AUTOMATICOEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.STS_AUTOMATICO.HasValue) _values_[0] = ea.STS_AUTOMATICO.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_E_STS_AUTOMATICO(System.Boolean STS_AUTOMATICO, bool ignore_STS_AUTOMATICO)
    {
      object[] _values_ = new object[1];
      if (!ignore_STS_AUTOMATICO) _values_[0] = STS_AUTOMATICO;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_E_CMD_ABRIR_MANUAL(System.Boolean CMD_ABRIR_MANUAL)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {CMD_ABRIR_MANUAL});
    }
    public bool FireEvent_E_CMD_ABRIR_MANUAL(Hidryco.HidrycoLib.Symbols.Atuador_Coester_CSR6T.E_CMD_ABRIR_MANUALEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.CMD_ABRIR_MANUAL.HasValue) _values_[0] = ea.CMD_ABRIR_MANUAL.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_E_CMD_ABRIR_MANUAL(System.Boolean CMD_ABRIR_MANUAL, bool ignore_CMD_ABRIR_MANUAL)
    {
      object[] _values_ = new object[1];
      if (!ignore_CMD_ABRIR_MANUAL) _values_[0] = CMD_ABRIR_MANUAL;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_E_CMD_FECHAR_MANUAL(System.Boolean CMD_FECHAR_MANUAL)
    {
      return ((IHMIAccessorOutput)this).FireEvent(2, new object[] {CMD_FECHAR_MANUAL});
    }
    public bool FireEvent_E_CMD_FECHAR_MANUAL(Hidryco.HidrycoLib.Symbols.Atuador_Coester_CSR6T.E_CMD_FECHAR_MANUALEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.CMD_FECHAR_MANUAL.HasValue) _values_[0] = ea.CMD_FECHAR_MANUAL.Value;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_E_CMD_FECHAR_MANUAL(System.Boolean CMD_FECHAR_MANUAL, bool ignore_CMD_FECHAR_MANUAL)
    {
      object[] _values_ = new object[1];
      if (!ignore_CMD_FECHAR_MANUAL) _values_[0] = CMD_FECHAR_MANUAL;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_E_CMD_POSICIONAR_MANUAL(System.Boolean CMD_POSICIONAR_MANUAL)
    {
      return ((IHMIAccessorOutput)this).FireEvent(3, new object[] {CMD_POSICIONAR_MANUAL});
    }
    public bool FireEvent_E_CMD_POSICIONAR_MANUAL(Hidryco.HidrycoLib.Symbols.Atuador_Coester_CSR6T.E_CMD_POSICIONAR_MANUALEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.CMD_POSICIONAR_MANUAL.HasValue) _values_[0] = ea.CMD_POSICIONAR_MANUAL.Value;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_E_CMD_POSICIONAR_MANUAL(System.Boolean CMD_POSICIONAR_MANUAL, bool ignore_CMD_POSICIONAR_MANUAL)
    {
      object[] _values_ = new object[1];
      if (!ignore_CMD_POSICIONAR_MANUAL) _values_[0] = CMD_POSICIONAR_MANUAL;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_E_CMD_PARAR_MANUAL(System.Boolean CMD_PARAR_MANUAL)
    {
      return ((IHMIAccessorOutput)this).FireEvent(4, new object[] {CMD_PARAR_MANUAL});
    }
    public bool FireEvent_E_CMD_PARAR_MANUAL(Hidryco.HidrycoLib.Symbols.Atuador_Coester_CSR6T.E_CMD_PARAR_MANUALEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.CMD_PARAR_MANUAL.HasValue) _values_[0] = ea.CMD_PARAR_MANUAL.Value;
      return ((IHMIAccessorOutput)this).FireEvent(4, _values_);
    }
    public bool FireEvent_E_CMD_PARAR_MANUAL(System.Boolean CMD_PARAR_MANUAL, bool ignore_CMD_PARAR_MANUAL)
    {
      object[] _values_ = new object[1];
      if (!ignore_CMD_PARAR_MANUAL) _values_[0] = CMD_PARAR_MANUAL;
      return ((IHMIAccessorOutput)this).FireEvent(4, _values_);
    }
    public bool FireEvent_E_CMD_RESET_FALHA(System.Boolean CMD_RESET_FALHA)
    {
      return ((IHMIAccessorOutput)this).FireEvent(5, new object[] {CMD_RESET_FALHA});
    }
    public bool FireEvent_E_CMD_RESET_FALHA(Hidryco.HidrycoLib.Symbols.Atuador_Coester_CSR6T.E_CMD_RESET_FALHAEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.CMD_RESET_FALHA.HasValue) _values_[0] = ea.CMD_RESET_FALHA.Value;
      return ((IHMIAccessorOutput)this).FireEvent(5, _values_);
    }
    public bool FireEvent_E_CMD_RESET_FALHA(System.Boolean CMD_RESET_FALHA, bool ignore_CMD_RESET_FALHA)
    {
      object[] _values_ = new object[1];
      if (!ignore_CMD_RESET_FALHA) _values_[0] = CMD_RESET_FALHA;
      return ((IHMIAccessorOutput)this).FireEvent(5, _values_);
    }
    public bool FireEvent_CNF(System.UInt16 STP_FALHA_ABERTURA, System.UInt16 STP_FALHA_FECHAMENTO, System.Int16 STP_POSICAO_DESEJADA_MANUAL)
    {
      return ((IHMIAccessorOutput)this).FireEvent(6, new object[] {STP_FALHA_ABERTURA, STP_FALHA_FECHAMENTO, STP_POSICAO_DESEJADA_MANUAL});
    }
    public bool FireEvent_CNF(Hidryco.HidrycoLib.Symbols.Atuador_Coester_CSR6T.CNFEventArgs ea)
    {
      object[] _values_ = new object[3];
      if (ea.STP_FALHA_ABERTURA.HasValue) _values_[0] = ea.STP_FALHA_ABERTURA.Value;
      if (ea.STP_FALHA_FECHAMENTO.HasValue) _values_[1] = ea.STP_FALHA_FECHAMENTO.Value;
      if (ea.STP_POSICAO_DESEJADA_MANUAL.HasValue) _values_[2] = ea.STP_POSICAO_DESEJADA_MANUAL.Value;
      return ((IHMIAccessorOutput)this).FireEvent(6, _values_);
    }
    public bool FireEvent_CNF(System.UInt16 STP_FALHA_ABERTURA, bool ignore_STP_FALHA_ABERTURA, System.UInt16 STP_FALHA_FECHAMENTO, bool ignore_STP_FALHA_FECHAMENTO, System.Int16 STP_POSICAO_DESEJADA_MANUAL, bool ignore_STP_POSICAO_DESEJADA_MANUAL)
    {
      object[] _values_ = new object[3];
      if (!ignore_STP_FALHA_ABERTURA) _values_[0] = STP_FALHA_ABERTURA;
      if (!ignore_STP_FALHA_FECHAMENTO) _values_[1] = STP_FALHA_FECHAMENTO;
      if (!ignore_STP_POSICAO_DESEJADA_MANUAL) _values_[2] = STP_POSICAO_DESEJADA_MANUAL;
      return ((IHMIAccessorOutput)this).FireEvent(6, _values_);
    }

  }
}

namespace Hidryco.HidrycoLib.Symbols.Atuador_Coester_CSR6T
{
  partial class Comporta
  {

    private event EventHandler<Hidryco.HidrycoLib.Symbols.Atuador_Coester_CSR6T.REQEventArgs> REQ_Fired;

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
              REQ_Fired(this, new Hidryco.HidrycoLib.Symbols.Atuador_Coester_CSR6T.REQEventArgs(channelId, cookie, eventIndex));
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
    public bool FireEvent_E_STS_AUTOMATICO(System.Boolean STS_AUTOMATICO)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {STS_AUTOMATICO});
    }
    public bool FireEvent_E_STS_AUTOMATICO(Hidryco.HidrycoLib.Symbols.Atuador_Coester_CSR6T.E_STS_AUTOMATICOEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.STS_AUTOMATICO.HasValue) _values_[0] = ea.STS_AUTOMATICO.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_E_STS_AUTOMATICO(System.Boolean STS_AUTOMATICO, bool ignore_STS_AUTOMATICO)
    {
      object[] _values_ = new object[1];
      if (!ignore_STS_AUTOMATICO) _values_[0] = STS_AUTOMATICO;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_E_CMD_ABRIR_MANUAL(System.Boolean CMD_ABRIR_MANUAL)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {CMD_ABRIR_MANUAL});
    }
    public bool FireEvent_E_CMD_ABRIR_MANUAL(Hidryco.HidrycoLib.Symbols.Atuador_Coester_CSR6T.E_CMD_ABRIR_MANUALEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.CMD_ABRIR_MANUAL.HasValue) _values_[0] = ea.CMD_ABRIR_MANUAL.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_E_CMD_ABRIR_MANUAL(System.Boolean CMD_ABRIR_MANUAL, bool ignore_CMD_ABRIR_MANUAL)
    {
      object[] _values_ = new object[1];
      if (!ignore_CMD_ABRIR_MANUAL) _values_[0] = CMD_ABRIR_MANUAL;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_E_CMD_FECHAR_MANUAL(System.Boolean CMD_FECHAR_MANUAL)
    {
      return ((IHMIAccessorOutput)this).FireEvent(2, new object[] {CMD_FECHAR_MANUAL});
    }
    public bool FireEvent_E_CMD_FECHAR_MANUAL(Hidryco.HidrycoLib.Symbols.Atuador_Coester_CSR6T.E_CMD_FECHAR_MANUALEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.CMD_FECHAR_MANUAL.HasValue) _values_[0] = ea.CMD_FECHAR_MANUAL.Value;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_E_CMD_FECHAR_MANUAL(System.Boolean CMD_FECHAR_MANUAL, bool ignore_CMD_FECHAR_MANUAL)
    {
      object[] _values_ = new object[1];
      if (!ignore_CMD_FECHAR_MANUAL) _values_[0] = CMD_FECHAR_MANUAL;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_E_CMD_POSICIONAR_MANUAL(System.Boolean CMD_POSICIONAR_MANUAL)
    {
      return ((IHMIAccessorOutput)this).FireEvent(3, new object[] {CMD_POSICIONAR_MANUAL});
    }
    public bool FireEvent_E_CMD_POSICIONAR_MANUAL(Hidryco.HidrycoLib.Symbols.Atuador_Coester_CSR6T.E_CMD_POSICIONAR_MANUALEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.CMD_POSICIONAR_MANUAL.HasValue) _values_[0] = ea.CMD_POSICIONAR_MANUAL.Value;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_E_CMD_POSICIONAR_MANUAL(System.Boolean CMD_POSICIONAR_MANUAL, bool ignore_CMD_POSICIONAR_MANUAL)
    {
      object[] _values_ = new object[1];
      if (!ignore_CMD_POSICIONAR_MANUAL) _values_[0] = CMD_POSICIONAR_MANUAL;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_E_CMD_PARAR_MANUAL(System.Boolean CMD_PARAR_MANUAL)
    {
      return ((IHMIAccessorOutput)this).FireEvent(4, new object[] {CMD_PARAR_MANUAL});
    }
    public bool FireEvent_E_CMD_PARAR_MANUAL(Hidryco.HidrycoLib.Symbols.Atuador_Coester_CSR6T.E_CMD_PARAR_MANUALEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.CMD_PARAR_MANUAL.HasValue) _values_[0] = ea.CMD_PARAR_MANUAL.Value;
      return ((IHMIAccessorOutput)this).FireEvent(4, _values_);
    }
    public bool FireEvent_E_CMD_PARAR_MANUAL(System.Boolean CMD_PARAR_MANUAL, bool ignore_CMD_PARAR_MANUAL)
    {
      object[] _values_ = new object[1];
      if (!ignore_CMD_PARAR_MANUAL) _values_[0] = CMD_PARAR_MANUAL;
      return ((IHMIAccessorOutput)this).FireEvent(4, _values_);
    }
    public bool FireEvent_E_CMD_RESET_FALHA(System.Boolean CMD_RESET_FALHA)
    {
      return ((IHMIAccessorOutput)this).FireEvent(5, new object[] {CMD_RESET_FALHA});
    }
    public bool FireEvent_E_CMD_RESET_FALHA(Hidryco.HidrycoLib.Symbols.Atuador_Coester_CSR6T.E_CMD_RESET_FALHAEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.CMD_RESET_FALHA.HasValue) _values_[0] = ea.CMD_RESET_FALHA.Value;
      return ((IHMIAccessorOutput)this).FireEvent(5, _values_);
    }
    public bool FireEvent_E_CMD_RESET_FALHA(System.Boolean CMD_RESET_FALHA, bool ignore_CMD_RESET_FALHA)
    {
      object[] _values_ = new object[1];
      if (!ignore_CMD_RESET_FALHA) _values_[0] = CMD_RESET_FALHA;
      return ((IHMIAccessorOutput)this).FireEvent(5, _values_);
    }
    public bool FireEvent_CNF(System.UInt16 STP_FALHA_ABERTURA, System.UInt16 STP_FALHA_FECHAMENTO, System.Int16 STP_POSICAO_DESEJADA_MANUAL)
    {
      return ((IHMIAccessorOutput)this).FireEvent(6, new object[] {STP_FALHA_ABERTURA, STP_FALHA_FECHAMENTO, STP_POSICAO_DESEJADA_MANUAL});
    }
    public bool FireEvent_CNF(Hidryco.HidrycoLib.Symbols.Atuador_Coester_CSR6T.CNFEventArgs ea)
    {
      object[] _values_ = new object[3];
      if (ea.STP_FALHA_ABERTURA.HasValue) _values_[0] = ea.STP_FALHA_ABERTURA.Value;
      if (ea.STP_FALHA_FECHAMENTO.HasValue) _values_[1] = ea.STP_FALHA_FECHAMENTO.Value;
      if (ea.STP_POSICAO_DESEJADA_MANUAL.HasValue) _values_[2] = ea.STP_POSICAO_DESEJADA_MANUAL.Value;
      return ((IHMIAccessorOutput)this).FireEvent(6, _values_);
    }
    public bool FireEvent_CNF(System.UInt16 STP_FALHA_ABERTURA, bool ignore_STP_FALHA_ABERTURA, System.UInt16 STP_FALHA_FECHAMENTO, bool ignore_STP_FALHA_FECHAMENTO, System.Int16 STP_POSICAO_DESEJADA_MANUAL, bool ignore_STP_POSICAO_DESEJADA_MANUAL)
    {
      object[] _values_ = new object[3];
      if (!ignore_STP_FALHA_ABERTURA) _values_[0] = STP_FALHA_ABERTURA;
      if (!ignore_STP_FALHA_FECHAMENTO) _values_[1] = STP_FALHA_FECHAMENTO;
      if (!ignore_STP_POSICAO_DESEJADA_MANUAL) _values_[2] = STP_POSICAO_DESEJADA_MANUAL;
      return ((IHMIAccessorOutput)this).FireEvent(6, _values_);
    }

  }
}

namespace Hidryco.HidrycoLib.Faceplates.Atuador_Coester_CSR6T
{
  partial class fpSemPosicionar
  {

    private event EventHandler<Hidryco.HidrycoLib.Symbols.Atuador_Coester_CSR6T.REQEventArgs> REQ_Fired;

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
              REQ_Fired(this, new Hidryco.HidrycoLib.Symbols.Atuador_Coester_CSR6T.REQEventArgs(channelId, cookie, eventIndex));
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
    public bool FireEvent_E_STS_AUTOMATICO(System.Boolean STS_AUTOMATICO)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {STS_AUTOMATICO});
    }
    public bool FireEvent_E_STS_AUTOMATICO(Hidryco.HidrycoLib.Symbols.Atuador_Coester_CSR6T.E_STS_AUTOMATICOEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.STS_AUTOMATICO.HasValue) _values_[0] = ea.STS_AUTOMATICO.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_E_STS_AUTOMATICO(System.Boolean STS_AUTOMATICO, bool ignore_STS_AUTOMATICO)
    {
      object[] _values_ = new object[1];
      if (!ignore_STS_AUTOMATICO) _values_[0] = STS_AUTOMATICO;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_E_CMD_ABRIR_MANUAL(System.Boolean CMD_ABRIR_MANUAL)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {CMD_ABRIR_MANUAL});
    }
    public bool FireEvent_E_CMD_ABRIR_MANUAL(Hidryco.HidrycoLib.Symbols.Atuador_Coester_CSR6T.E_CMD_ABRIR_MANUALEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.CMD_ABRIR_MANUAL.HasValue) _values_[0] = ea.CMD_ABRIR_MANUAL.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_E_CMD_ABRIR_MANUAL(System.Boolean CMD_ABRIR_MANUAL, bool ignore_CMD_ABRIR_MANUAL)
    {
      object[] _values_ = new object[1];
      if (!ignore_CMD_ABRIR_MANUAL) _values_[0] = CMD_ABRIR_MANUAL;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_E_CMD_FECHAR_MANUAL(System.Boolean CMD_FECHAR_MANUAL)
    {
      return ((IHMIAccessorOutput)this).FireEvent(2, new object[] {CMD_FECHAR_MANUAL});
    }
    public bool FireEvent_E_CMD_FECHAR_MANUAL(Hidryco.HidrycoLib.Symbols.Atuador_Coester_CSR6T.E_CMD_FECHAR_MANUALEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.CMD_FECHAR_MANUAL.HasValue) _values_[0] = ea.CMD_FECHAR_MANUAL.Value;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_E_CMD_FECHAR_MANUAL(System.Boolean CMD_FECHAR_MANUAL, bool ignore_CMD_FECHAR_MANUAL)
    {
      object[] _values_ = new object[1];
      if (!ignore_CMD_FECHAR_MANUAL) _values_[0] = CMD_FECHAR_MANUAL;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_E_CMD_POSICIONAR_MANUAL(System.Boolean CMD_POSICIONAR_MANUAL)
    {
      return ((IHMIAccessorOutput)this).FireEvent(3, new object[] {CMD_POSICIONAR_MANUAL});
    }
    public bool FireEvent_E_CMD_POSICIONAR_MANUAL(Hidryco.HidrycoLib.Symbols.Atuador_Coester_CSR6T.E_CMD_POSICIONAR_MANUALEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.CMD_POSICIONAR_MANUAL.HasValue) _values_[0] = ea.CMD_POSICIONAR_MANUAL.Value;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_E_CMD_POSICIONAR_MANUAL(System.Boolean CMD_POSICIONAR_MANUAL, bool ignore_CMD_POSICIONAR_MANUAL)
    {
      object[] _values_ = new object[1];
      if (!ignore_CMD_POSICIONAR_MANUAL) _values_[0] = CMD_POSICIONAR_MANUAL;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_E_CMD_PARAR_MANUAL(System.Boolean CMD_PARAR_MANUAL)
    {
      return ((IHMIAccessorOutput)this).FireEvent(4, new object[] {CMD_PARAR_MANUAL});
    }
    public bool FireEvent_E_CMD_PARAR_MANUAL(Hidryco.HidrycoLib.Symbols.Atuador_Coester_CSR6T.E_CMD_PARAR_MANUALEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.CMD_PARAR_MANUAL.HasValue) _values_[0] = ea.CMD_PARAR_MANUAL.Value;
      return ((IHMIAccessorOutput)this).FireEvent(4, _values_);
    }
    public bool FireEvent_E_CMD_PARAR_MANUAL(System.Boolean CMD_PARAR_MANUAL, bool ignore_CMD_PARAR_MANUAL)
    {
      object[] _values_ = new object[1];
      if (!ignore_CMD_PARAR_MANUAL) _values_[0] = CMD_PARAR_MANUAL;
      return ((IHMIAccessorOutput)this).FireEvent(4, _values_);
    }
    public bool FireEvent_E_CMD_RESET_FALHA(System.Boolean CMD_RESET_FALHA)
    {
      return ((IHMIAccessorOutput)this).FireEvent(5, new object[] {CMD_RESET_FALHA});
    }
    public bool FireEvent_E_CMD_RESET_FALHA(Hidryco.HidrycoLib.Symbols.Atuador_Coester_CSR6T.E_CMD_RESET_FALHAEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.CMD_RESET_FALHA.HasValue) _values_[0] = ea.CMD_RESET_FALHA.Value;
      return ((IHMIAccessorOutput)this).FireEvent(5, _values_);
    }
    public bool FireEvent_E_CMD_RESET_FALHA(System.Boolean CMD_RESET_FALHA, bool ignore_CMD_RESET_FALHA)
    {
      object[] _values_ = new object[1];
      if (!ignore_CMD_RESET_FALHA) _values_[0] = CMD_RESET_FALHA;
      return ((IHMIAccessorOutput)this).FireEvent(5, _values_);
    }
    public bool FireEvent_CNF(System.UInt16 STP_FALHA_ABERTURA, System.UInt16 STP_FALHA_FECHAMENTO, System.Int16 STP_POSICAO_DESEJADA_MANUAL)
    {
      return ((IHMIAccessorOutput)this).FireEvent(6, new object[] {STP_FALHA_ABERTURA, STP_FALHA_FECHAMENTO, STP_POSICAO_DESEJADA_MANUAL});
    }
    public bool FireEvent_CNF(Hidryco.HidrycoLib.Symbols.Atuador_Coester_CSR6T.CNFEventArgs ea)
    {
      object[] _values_ = new object[3];
      if (ea.STP_FALHA_ABERTURA.HasValue) _values_[0] = ea.STP_FALHA_ABERTURA.Value;
      if (ea.STP_FALHA_FECHAMENTO.HasValue) _values_[1] = ea.STP_FALHA_FECHAMENTO.Value;
      if (ea.STP_POSICAO_DESEJADA_MANUAL.HasValue) _values_[2] = ea.STP_POSICAO_DESEJADA_MANUAL.Value;
      return ((IHMIAccessorOutput)this).FireEvent(6, _values_);
    }
    public bool FireEvent_CNF(System.UInt16 STP_FALHA_ABERTURA, bool ignore_STP_FALHA_ABERTURA, System.UInt16 STP_FALHA_FECHAMENTO, bool ignore_STP_FALHA_FECHAMENTO, System.Int16 STP_POSICAO_DESEJADA_MANUAL, bool ignore_STP_POSICAO_DESEJADA_MANUAL)
    {
      object[] _values_ = new object[3];
      if (!ignore_STP_FALHA_ABERTURA) _values_[0] = STP_FALHA_ABERTURA;
      if (!ignore_STP_FALHA_FECHAMENTO) _values_[1] = STP_FALHA_FECHAMENTO;
      if (!ignore_STP_POSICAO_DESEJADA_MANUAL) _values_[2] = STP_POSICAO_DESEJADA_MANUAL;
      return ((IHMIAccessorOutput)this).FireEvent(6, _values_);
    }

  }
}
#endregion #Atuador_Coester_CSR6T_HMI;

#endregion Definitions;
