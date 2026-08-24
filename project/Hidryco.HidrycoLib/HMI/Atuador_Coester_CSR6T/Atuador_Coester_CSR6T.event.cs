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

    public bool Get_stsAnimacao(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,1, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? stsAnimacao
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,1, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }

    public bool Get_stsPosicaoAtual(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,2, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? stsPosicaoAtual
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,2, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }

    public bool Get_stsFalhaComunicacao(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,3, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? stsFalhaComunicacao
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
    private System.Boolean? cmdAbrirManual_field = null;
    public System.Boolean? cmdAbrirManual
    {
       get { return cmdAbrirManual_field; }
       set { cmdAbrirManual_field = value; }
    }

  }

  public class E_CMD_FECHAR_MANUALEventArgs : System.EventArgs
  {
    public E_CMD_FECHAR_MANUALEventArgs()
    {
    }
    private System.Boolean? cmdFecharManual_field = null;
    public System.Boolean? cmdFecharManual
    {
       get { return cmdFecharManual_field; }
       set { cmdFecharManual_field = value; }
    }

  }

  public class E_CMD_POSICIONAR_MANUALEventArgs : System.EventArgs
  {
    public E_CMD_POSICIONAR_MANUALEventArgs()
    {
    }
    private System.Boolean? cmdPosicionarManual_field = null;
    public System.Boolean? cmdPosicionarManual
    {
       get { return cmdPosicionarManual_field; }
       set { cmdPosicionarManual_field = value; }
    }

  }

  public class E_CMD_PARAR_MANUALEventArgs : System.EventArgs
  {
    public E_CMD_PARAR_MANUALEventArgs()
    {
    }
    private System.Boolean? cmdPararManual_field = null;
    public System.Boolean? cmdPararManual
    {
       get { return cmdPararManual_field; }
       set { cmdPararManual_field = value; }
    }

  }

  public class CNFEventArgs : System.EventArgs
  {
    public CNFEventArgs()
    {
    }
    private System.Int16? stpPosicaoDesejadaManual_field = null;
    public System.Int16? stpPosicaoDesejadaManual
    {
       get { return stpPosicaoDesejadaManual_field; }
       set { stpPosicaoDesejadaManual_field = value; }
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
    public bool FireEvent_E_CMD_ABRIR_MANUAL(System.Boolean cmdAbrirManual)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {cmdAbrirManual});
    }
    public bool FireEvent_E_CMD_ABRIR_MANUAL(Hidryco.HidrycoLib.Symbols.Atuador_Coester_CSR6T.E_CMD_ABRIR_MANUALEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.cmdAbrirManual.HasValue) _values_[0] = ea.cmdAbrirManual.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_E_CMD_ABRIR_MANUAL(System.Boolean cmdAbrirManual, bool ignore_cmdAbrirManual)
    {
      object[] _values_ = new object[1];
      if (!ignore_cmdAbrirManual) _values_[0] = cmdAbrirManual;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_E_CMD_FECHAR_MANUAL(System.Boolean cmdFecharManual)
    {
      return ((IHMIAccessorOutput)this).FireEvent(2, new object[] {cmdFecharManual});
    }
    public bool FireEvent_E_CMD_FECHAR_MANUAL(Hidryco.HidrycoLib.Symbols.Atuador_Coester_CSR6T.E_CMD_FECHAR_MANUALEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.cmdFecharManual.HasValue) _values_[0] = ea.cmdFecharManual.Value;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_E_CMD_FECHAR_MANUAL(System.Boolean cmdFecharManual, bool ignore_cmdFecharManual)
    {
      object[] _values_ = new object[1];
      if (!ignore_cmdFecharManual) _values_[0] = cmdFecharManual;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_E_CMD_POSICIONAR_MANUAL(System.Boolean cmdPosicionarManual)
    {
      return ((IHMIAccessorOutput)this).FireEvent(3, new object[] {cmdPosicionarManual});
    }
    public bool FireEvent_E_CMD_POSICIONAR_MANUAL(Hidryco.HidrycoLib.Symbols.Atuador_Coester_CSR6T.E_CMD_POSICIONAR_MANUALEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.cmdPosicionarManual.HasValue) _values_[0] = ea.cmdPosicionarManual.Value;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_E_CMD_POSICIONAR_MANUAL(System.Boolean cmdPosicionarManual, bool ignore_cmdPosicionarManual)
    {
      object[] _values_ = new object[1];
      if (!ignore_cmdPosicionarManual) _values_[0] = cmdPosicionarManual;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_E_CMD_PARAR_MANUAL(System.Boolean cmdPararManual)
    {
      return ((IHMIAccessorOutput)this).FireEvent(4, new object[] {cmdPararManual});
    }
    public bool FireEvent_E_CMD_PARAR_MANUAL(Hidryco.HidrycoLib.Symbols.Atuador_Coester_CSR6T.E_CMD_PARAR_MANUALEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.cmdPararManual.HasValue) _values_[0] = ea.cmdPararManual.Value;
      return ((IHMIAccessorOutput)this).FireEvent(4, _values_);
    }
    public bool FireEvent_E_CMD_PARAR_MANUAL(System.Boolean cmdPararManual, bool ignore_cmdPararManual)
    {
      object[] _values_ = new object[1];
      if (!ignore_cmdPararManual) _values_[0] = cmdPararManual;
      return ((IHMIAccessorOutput)this).FireEvent(4, _values_);
    }
    public bool FireEvent_CNF(System.Int16 stpPosicaoDesejadaManual)
    {
      return ((IHMIAccessorOutput)this).FireEvent(5, new object[] {stpPosicaoDesejadaManual});
    }
    public bool FireEvent_CNF(Hidryco.HidrycoLib.Symbols.Atuador_Coester_CSR6T.CNFEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.stpPosicaoDesejadaManual.HasValue) _values_[0] = ea.stpPosicaoDesejadaManual.Value;
      return ((IHMIAccessorOutput)this).FireEvent(5, _values_);
    }
    public bool FireEvent_CNF(System.Int16 stpPosicaoDesejadaManual, bool ignore_stpPosicaoDesejadaManual)
    {
      object[] _values_ = new object[1];
      if (!ignore_stpPosicaoDesejadaManual) _values_[0] = stpPosicaoDesejadaManual;
      return ((IHMIAccessorOutput)this).FireEvent(5, _values_);
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
    public bool FireEvent_E_CMD_ABRIR_MANUAL(System.Boolean cmdAbrirManual)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {cmdAbrirManual});
    }
    public bool FireEvent_E_CMD_ABRIR_MANUAL(Hidryco.HidrycoLib.Symbols.Atuador_Coester_CSR6T.E_CMD_ABRIR_MANUALEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.cmdAbrirManual.HasValue) _values_[0] = ea.cmdAbrirManual.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_E_CMD_ABRIR_MANUAL(System.Boolean cmdAbrirManual, bool ignore_cmdAbrirManual)
    {
      object[] _values_ = new object[1];
      if (!ignore_cmdAbrirManual) _values_[0] = cmdAbrirManual;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_E_CMD_FECHAR_MANUAL(System.Boolean cmdFecharManual)
    {
      return ((IHMIAccessorOutput)this).FireEvent(2, new object[] {cmdFecharManual});
    }
    public bool FireEvent_E_CMD_FECHAR_MANUAL(Hidryco.HidrycoLib.Symbols.Atuador_Coester_CSR6T.E_CMD_FECHAR_MANUALEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.cmdFecharManual.HasValue) _values_[0] = ea.cmdFecharManual.Value;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_E_CMD_FECHAR_MANUAL(System.Boolean cmdFecharManual, bool ignore_cmdFecharManual)
    {
      object[] _values_ = new object[1];
      if (!ignore_cmdFecharManual) _values_[0] = cmdFecharManual;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_E_CMD_POSICIONAR_MANUAL(System.Boolean cmdPosicionarManual)
    {
      return ((IHMIAccessorOutput)this).FireEvent(3, new object[] {cmdPosicionarManual});
    }
    public bool FireEvent_E_CMD_POSICIONAR_MANUAL(Hidryco.HidrycoLib.Symbols.Atuador_Coester_CSR6T.E_CMD_POSICIONAR_MANUALEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.cmdPosicionarManual.HasValue) _values_[0] = ea.cmdPosicionarManual.Value;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_E_CMD_POSICIONAR_MANUAL(System.Boolean cmdPosicionarManual, bool ignore_cmdPosicionarManual)
    {
      object[] _values_ = new object[1];
      if (!ignore_cmdPosicionarManual) _values_[0] = cmdPosicionarManual;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_E_CMD_PARAR_MANUAL(System.Boolean cmdPararManual)
    {
      return ((IHMIAccessorOutput)this).FireEvent(4, new object[] {cmdPararManual});
    }
    public bool FireEvent_E_CMD_PARAR_MANUAL(Hidryco.HidrycoLib.Symbols.Atuador_Coester_CSR6T.E_CMD_PARAR_MANUALEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.cmdPararManual.HasValue) _values_[0] = ea.cmdPararManual.Value;
      return ((IHMIAccessorOutput)this).FireEvent(4, _values_);
    }
    public bool FireEvent_E_CMD_PARAR_MANUAL(System.Boolean cmdPararManual, bool ignore_cmdPararManual)
    {
      object[] _values_ = new object[1];
      if (!ignore_cmdPararManual) _values_[0] = cmdPararManual;
      return ((IHMIAccessorOutput)this).FireEvent(4, _values_);
    }
    public bool FireEvent_CNF(System.Int16 stpPosicaoDesejadaManual)
    {
      return ((IHMIAccessorOutput)this).FireEvent(5, new object[] {stpPosicaoDesejadaManual});
    }
    public bool FireEvent_CNF(Hidryco.HidrycoLib.Symbols.Atuador_Coester_CSR6T.CNFEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.stpPosicaoDesejadaManual.HasValue) _values_[0] = ea.stpPosicaoDesejadaManual.Value;
      return ((IHMIAccessorOutput)this).FireEvent(5, _values_);
    }
    public bool FireEvent_CNF(System.Int16 stpPosicaoDesejadaManual, bool ignore_stpPosicaoDesejadaManual)
    {
      object[] _values_ = new object[1];
      if (!ignore_stpPosicaoDesejadaManual) _values_[0] = stpPosicaoDesejadaManual;
      return ((IHMIAccessorOutput)this).FireEvent(5, _values_);
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
    public bool FireEvent_E_CMD_ABRIR_MANUAL(System.Boolean cmdAbrirManual)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {cmdAbrirManual});
    }
    public bool FireEvent_E_CMD_ABRIR_MANUAL(Hidryco.HidrycoLib.Symbols.Atuador_Coester_CSR6T.E_CMD_ABRIR_MANUALEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.cmdAbrirManual.HasValue) _values_[0] = ea.cmdAbrirManual.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_E_CMD_ABRIR_MANUAL(System.Boolean cmdAbrirManual, bool ignore_cmdAbrirManual)
    {
      object[] _values_ = new object[1];
      if (!ignore_cmdAbrirManual) _values_[0] = cmdAbrirManual;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_E_CMD_FECHAR_MANUAL(System.Boolean cmdFecharManual)
    {
      return ((IHMIAccessorOutput)this).FireEvent(2, new object[] {cmdFecharManual});
    }
    public bool FireEvent_E_CMD_FECHAR_MANUAL(Hidryco.HidrycoLib.Symbols.Atuador_Coester_CSR6T.E_CMD_FECHAR_MANUALEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.cmdFecharManual.HasValue) _values_[0] = ea.cmdFecharManual.Value;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_E_CMD_FECHAR_MANUAL(System.Boolean cmdFecharManual, bool ignore_cmdFecharManual)
    {
      object[] _values_ = new object[1];
      if (!ignore_cmdFecharManual) _values_[0] = cmdFecharManual;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_E_CMD_POSICIONAR_MANUAL(System.Boolean cmdPosicionarManual)
    {
      return ((IHMIAccessorOutput)this).FireEvent(3, new object[] {cmdPosicionarManual});
    }
    public bool FireEvent_E_CMD_POSICIONAR_MANUAL(Hidryco.HidrycoLib.Symbols.Atuador_Coester_CSR6T.E_CMD_POSICIONAR_MANUALEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.cmdPosicionarManual.HasValue) _values_[0] = ea.cmdPosicionarManual.Value;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_E_CMD_POSICIONAR_MANUAL(System.Boolean cmdPosicionarManual, bool ignore_cmdPosicionarManual)
    {
      object[] _values_ = new object[1];
      if (!ignore_cmdPosicionarManual) _values_[0] = cmdPosicionarManual;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_E_CMD_PARAR_MANUAL(System.Boolean cmdPararManual)
    {
      return ((IHMIAccessorOutput)this).FireEvent(4, new object[] {cmdPararManual});
    }
    public bool FireEvent_E_CMD_PARAR_MANUAL(Hidryco.HidrycoLib.Symbols.Atuador_Coester_CSR6T.E_CMD_PARAR_MANUALEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.cmdPararManual.HasValue) _values_[0] = ea.cmdPararManual.Value;
      return ((IHMIAccessorOutput)this).FireEvent(4, _values_);
    }
    public bool FireEvent_E_CMD_PARAR_MANUAL(System.Boolean cmdPararManual, bool ignore_cmdPararManual)
    {
      object[] _values_ = new object[1];
      if (!ignore_cmdPararManual) _values_[0] = cmdPararManual;
      return ((IHMIAccessorOutput)this).FireEvent(4, _values_);
    }
    public bool FireEvent_CNF(System.Int16 stpPosicaoDesejadaManual)
    {
      return ((IHMIAccessorOutput)this).FireEvent(5, new object[] {stpPosicaoDesejadaManual});
    }
    public bool FireEvent_CNF(Hidryco.HidrycoLib.Symbols.Atuador_Coester_CSR6T.CNFEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.stpPosicaoDesejadaManual.HasValue) _values_[0] = ea.stpPosicaoDesejadaManual.Value;
      return ((IHMIAccessorOutput)this).FireEvent(5, _values_);
    }
    public bool FireEvent_CNF(System.Int16 stpPosicaoDesejadaManual, bool ignore_stpPosicaoDesejadaManual)
    {
      object[] _values_ = new object[1];
      if (!ignore_stpPosicaoDesejadaManual) _values_[0] = stpPosicaoDesejadaManual;
      return ((IHMIAccessorOutput)this).FireEvent(5, _values_);
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
    public bool FireEvent_E_CMD_ABRIR_MANUAL(System.Boolean cmdAbrirManual)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {cmdAbrirManual});
    }
    public bool FireEvent_E_CMD_ABRIR_MANUAL(Hidryco.HidrycoLib.Symbols.Atuador_Coester_CSR6T.E_CMD_ABRIR_MANUALEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.cmdAbrirManual.HasValue) _values_[0] = ea.cmdAbrirManual.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_E_CMD_ABRIR_MANUAL(System.Boolean cmdAbrirManual, bool ignore_cmdAbrirManual)
    {
      object[] _values_ = new object[1];
      if (!ignore_cmdAbrirManual) _values_[0] = cmdAbrirManual;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_E_CMD_FECHAR_MANUAL(System.Boolean cmdFecharManual)
    {
      return ((IHMIAccessorOutput)this).FireEvent(2, new object[] {cmdFecharManual});
    }
    public bool FireEvent_E_CMD_FECHAR_MANUAL(Hidryco.HidrycoLib.Symbols.Atuador_Coester_CSR6T.E_CMD_FECHAR_MANUALEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.cmdFecharManual.HasValue) _values_[0] = ea.cmdFecharManual.Value;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_E_CMD_FECHAR_MANUAL(System.Boolean cmdFecharManual, bool ignore_cmdFecharManual)
    {
      object[] _values_ = new object[1];
      if (!ignore_cmdFecharManual) _values_[0] = cmdFecharManual;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_E_CMD_POSICIONAR_MANUAL(System.Boolean cmdPosicionarManual)
    {
      return ((IHMIAccessorOutput)this).FireEvent(3, new object[] {cmdPosicionarManual});
    }
    public bool FireEvent_E_CMD_POSICIONAR_MANUAL(Hidryco.HidrycoLib.Symbols.Atuador_Coester_CSR6T.E_CMD_POSICIONAR_MANUALEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.cmdPosicionarManual.HasValue) _values_[0] = ea.cmdPosicionarManual.Value;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_E_CMD_POSICIONAR_MANUAL(System.Boolean cmdPosicionarManual, bool ignore_cmdPosicionarManual)
    {
      object[] _values_ = new object[1];
      if (!ignore_cmdPosicionarManual) _values_[0] = cmdPosicionarManual;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_E_CMD_PARAR_MANUAL(System.Boolean cmdPararManual)
    {
      return ((IHMIAccessorOutput)this).FireEvent(4, new object[] {cmdPararManual});
    }
    public bool FireEvent_E_CMD_PARAR_MANUAL(Hidryco.HidrycoLib.Symbols.Atuador_Coester_CSR6T.E_CMD_PARAR_MANUALEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.cmdPararManual.HasValue) _values_[0] = ea.cmdPararManual.Value;
      return ((IHMIAccessorOutput)this).FireEvent(4, _values_);
    }
    public bool FireEvent_E_CMD_PARAR_MANUAL(System.Boolean cmdPararManual, bool ignore_cmdPararManual)
    {
      object[] _values_ = new object[1];
      if (!ignore_cmdPararManual) _values_[0] = cmdPararManual;
      return ((IHMIAccessorOutput)this).FireEvent(4, _values_);
    }
    public bool FireEvent_CNF(System.Int16 stpPosicaoDesejadaManual)
    {
      return ((IHMIAccessorOutput)this).FireEvent(5, new object[] {stpPosicaoDesejadaManual});
    }
    public bool FireEvent_CNF(Hidryco.HidrycoLib.Symbols.Atuador_Coester_CSR6T.CNFEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.stpPosicaoDesejadaManual.HasValue) _values_[0] = ea.stpPosicaoDesejadaManual.Value;
      return ((IHMIAccessorOutput)this).FireEvent(5, _values_);
    }
    public bool FireEvent_CNF(System.Int16 stpPosicaoDesejadaManual, bool ignore_stpPosicaoDesejadaManual)
    {
      object[] _values_ = new object[1];
      if (!ignore_stpPosicaoDesejadaManual) _values_[0] = stpPosicaoDesejadaManual;
      return ((IHMIAccessorOutput)this).FireEvent(5, _values_);
    }

  }
}
#endregion #Atuador_Coester_CSR6T_HMI;

#endregion Definitions;
