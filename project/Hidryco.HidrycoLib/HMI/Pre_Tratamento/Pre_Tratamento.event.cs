/*
 * Criado pelo EcoStruxure Automation Expert.
 * Usuário:  
 * Data: 09/03/2026
 * Tempo: 11:29
 * 
 */
using System;
using NxtControl.GuiFramework;
using NxtControl.Services;

#region Definitions;
#region #Pre_Tratamento_HMI;

namespace Hidryco.HidrycoLib.Symbols.Pre_Tratamento
{

  public class E_ATUALIZA_ENTRADASEventArgs : System.EventArgs
  {
    IHMIAccessorService accessorService;
    int channelId;
    int cookie; 
    int eventIndex;

    public E_ATUALIZA_ENTRADASEventArgs(int channelId, int cookie, int eventIndex)
    {
      this.accessorService = (IHMIAccessorService)ServiceProvider.GetService(typeof(IHMIAccessorService));
      this.channelId = channelId;
      this.cookie = cookie;
      this.eventIndex = eventIndex;
    }
    public bool Get_STS_NIVEL_BAIXO_PENEIRA(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,0, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_NIVEL_BAIXO_PENEIRA
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,0, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_NIVEL_ALTO_PENEIRA(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,1, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_NIVEL_ALTO_PENEIRA
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,1, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_NIVEL_BAIXO_TANQUE_AGUA(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,2, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_NIVEL_BAIXO_TANQUE_AGUA
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,2, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_NIVEL_ALTO_TANQUE_GORDURA(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,3, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_NIVEL_ALTO_TANQUE_GORDURA
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,3, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_NIVEL_PENEIRA(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,4, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? STS_NIVEL_PENEIRA
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,4, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }

    public bool Get_STS_EMERGENCIA(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,5, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_EMERGENCIA
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,5, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_ANIMACAO_GERADOR(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,6, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? STS_ANIMACAO_GERADOR
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,6, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }


  }

  public class E_ATUALIZA_RESUMOEventArgs : System.EventArgs
  {
    IHMIAccessorService accessorService;
    int channelId;
    int cookie; 
    int eventIndex;

    public E_ATUALIZA_RESUMOEventArgs(int channelId, int cookie, int eventIndex)
    {
      this.accessorService = (IHMIAccessorService)ServiceProvider.GetService(typeof(IHMIAccessorService));
      this.channelId = channelId;
      this.cookie = cookie;
      this.eventIndex = eventIndex;
    }
    public bool Get_STS_ANIMACAO_BOMBA1(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,0, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? STS_ANIMACAO_BOMBA1
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,0, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }

    public bool Get_STS_ANIMACAO_BOMBA2(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,1, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? STS_ANIMACAO_BOMBA2
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,1, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }

    public bool Get_STS_ANIMACAO_PENEIRA(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,2, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? STS_ANIMACAO_PENEIRA
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,2, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }

    public bool Get_STS_ANIMACAO_VALVULA1(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,3, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? STS_ANIMACAO_VALVULA1
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,3, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }

    public bool Get_STS_ANIMACAO_VALVULA2(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,4, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? STS_ANIMACAO_VALVULA2
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,4, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }

    public bool Get_STS_ANIMACAO_COMPRESSOR(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,5, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? STS_ANIMACAO_COMPRESSOR
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,5, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }

    public bool Get_STS_ANIMACAO_RASPADOR(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,6, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? STS_ANIMACAO_RASPADOR
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,6, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }

    public bool Get_STS_ANIMACAO_ROSCA1(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,7, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? STS_ANIMACAO_ROSCA1
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,7, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }

    public bool Get_STS_ANIMACAO_ROSCA2(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,8, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? STS_ANIMACAO_ROSCA2
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,8, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }

    public bool Get_STS_EMERGENCIA(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,9, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_EMERGENCIA
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,9, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_NIVEL_BAIXO_PENEIRA(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,10, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_NIVEL_BAIXO_PENEIRA
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,10, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_NIVEL_ALTO_PENEIRA(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,11, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_NIVEL_ALTO_PENEIRA
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,11, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_NIVEL_BAIXO_TANQUE_AGUA(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,12, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_NIVEL_BAIXO_TANQUE_AGUA
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,12, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_NIVEL_ALTO_TANQUE_GORDURA(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,13, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_NIVEL_ALTO_TANQUE_GORDURA
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,13, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
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


  }

}

namespace Hidryco.HidrycoLib.Symbols.Pre_Tratamento
{

  public class E_ATUALIZA_COMANDOEventArgs : System.EventArgs
  {
    public E_ATUALIZA_COMANDOEventArgs()
    {
    }
    private System.Boolean? cmdLigaSubsistemaPeneira_field = null;
    public System.Boolean? cmdLigaSubsistemaPeneira
    {
       get { return cmdLigaSubsistemaPeneira_field; }
       set { cmdLigaSubsistemaPeneira_field = value; }
    }
    private System.Boolean? cmdSelecaoSubsistemaPeneira_field = null;
    public System.Boolean? cmdSelecaoSubsistemaPeneira
    {
       get { return cmdSelecaoSubsistemaPeneira_field; }
       set { cmdSelecaoSubsistemaPeneira_field = value; }
    }
    private System.Boolean? cmdLigaSubsistemaRoscas_field = null;
    public System.Boolean? cmdLigaSubsistemaRoscas
    {
       get { return cmdLigaSubsistemaRoscas_field; }
       set { cmdLigaSubsistemaRoscas_field = value; }
    }
    private System.Boolean? cmdSelecaoSubsistemaRoscas_field = null;
    public System.Boolean? cmdSelecaoSubsistemaRoscas
    {
       get { return cmdSelecaoSubsistemaRoscas_field; }
       set { cmdSelecaoSubsistemaRoscas_field = value; }
    }
    private System.Boolean? cmdLigaSubsistemaRaspComp_field = null;
    public System.Boolean? cmdLigaSubsistemaRaspComp
    {
       get { return cmdLigaSubsistemaRaspComp_field; }
       set { cmdLigaSubsistemaRaspComp_field = value; }
    }
    private System.Boolean? cmdSelecaoSubsistemaRaspComp_field = null;
    public System.Boolean? cmdSelecaoSubsistemaRaspComp
    {
       get { return cmdSelecaoSubsistemaRaspComp_field; }
       set { cmdSelecaoSubsistemaRaspComp_field = value; }
    }
    private System.Boolean? cmdSelecaoBombaHigienizacao_field = null;
    public System.Boolean? cmdSelecaoBombaHigienizacao
    {
       get { return cmdSelecaoBombaHigienizacao_field; }
       set { cmdSelecaoBombaHigienizacao_field = value; }
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

namespace Hidryco.HidrycoLib.Symbols.Pre_Tratamento
{
  partial class sDefault
  {

    private event EventHandler<Hidryco.HidrycoLib.Symbols.Pre_Tratamento.E_ATUALIZA_ENTRADASEventArgs> E_ATUALIZA_ENTRADAS_Fired;

    private event EventHandler<Hidryco.HidrycoLib.Symbols.Pre_Tratamento.E_ATUALIZA_RESUMOEventArgs> E_ATUALIZA_RESUMO_Fired;

    protected override void OnEndInit()
    {
      if (E_ATUALIZA_ENTRADAS_Fired != null)
        AttachEventInput(0);
      if (E_ATUALIZA_RESUMO_Fired != null)
        AttachEventInput(1);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (E_ATUALIZA_ENTRADAS_Fired != null)
          {
            try
            {
              E_ATUALIZA_ENTRADAS_Fired(this, new Hidryco.HidrycoLib.Symbols.Pre_Tratamento.E_ATUALIZA_ENTRADASEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","E_ATUALIZA_ENTRADAS_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 1:
          if (E_ATUALIZA_RESUMO_Fired != null)
          {
            try
            {
              E_ATUALIZA_RESUMO_Fired(this, new Hidryco.HidrycoLib.Symbols.Pre_Tratamento.E_ATUALIZA_RESUMOEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","E_ATUALIZA_RESUMO_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_E_ATUALIZA_COMANDO(System.Boolean cmdLigaSubsistemaPeneira, System.Boolean cmdSelecaoSubsistemaPeneira, System.Boolean cmdLigaSubsistemaRoscas, System.Boolean cmdSelecaoSubsistemaRoscas, System.Boolean cmdLigaSubsistemaRaspComp, System.Boolean cmdSelecaoSubsistemaRaspComp, System.Boolean cmdSelecaoBombaHigienizacao)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {cmdLigaSubsistemaPeneira, cmdSelecaoSubsistemaPeneira, cmdLigaSubsistemaRoscas, cmdSelecaoSubsistemaRoscas, cmdLigaSubsistemaRaspComp, cmdSelecaoSubsistemaRaspComp, cmdSelecaoBombaHigienizacao});
    }
    public bool FireEvent_E_ATUALIZA_COMANDO(Hidryco.HidrycoLib.Symbols.Pre_Tratamento.E_ATUALIZA_COMANDOEventArgs ea)
    {
      object[] _values_ = new object[7];
      if (ea.cmdLigaSubsistemaPeneira.HasValue) _values_[0] = ea.cmdLigaSubsistemaPeneira.Value;
      if (ea.cmdSelecaoSubsistemaPeneira.HasValue) _values_[1] = ea.cmdSelecaoSubsistemaPeneira.Value;
      if (ea.cmdLigaSubsistemaRoscas.HasValue) _values_[2] = ea.cmdLigaSubsistemaRoscas.Value;
      if (ea.cmdSelecaoSubsistemaRoscas.HasValue) _values_[3] = ea.cmdSelecaoSubsistemaRoscas.Value;
      if (ea.cmdLigaSubsistemaRaspComp.HasValue) _values_[4] = ea.cmdLigaSubsistemaRaspComp.Value;
      if (ea.cmdSelecaoSubsistemaRaspComp.HasValue) _values_[5] = ea.cmdSelecaoSubsistemaRaspComp.Value;
      if (ea.cmdSelecaoBombaHigienizacao.HasValue) _values_[6] = ea.cmdSelecaoBombaHigienizacao.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_E_ATUALIZA_COMANDO(System.Boolean cmdLigaSubsistemaPeneira, bool ignore_cmdLigaSubsistemaPeneira, System.Boolean cmdSelecaoSubsistemaPeneira, bool ignore_cmdSelecaoSubsistemaPeneira, System.Boolean cmdLigaSubsistemaRoscas, bool ignore_cmdLigaSubsistemaRoscas, System.Boolean cmdSelecaoSubsistemaRoscas, bool ignore_cmdSelecaoSubsistemaRoscas, System.Boolean cmdLigaSubsistemaRaspComp, bool ignore_cmdLigaSubsistemaRaspComp, System.Boolean cmdSelecaoSubsistemaRaspComp, bool ignore_cmdSelecaoSubsistemaRaspComp, System.Boolean cmdSelecaoBombaHigienizacao, bool ignore_cmdSelecaoBombaHigienizacao)
    {
      object[] _values_ = new object[7];
      if (!ignore_cmdLigaSubsistemaPeneira) _values_[0] = cmdLigaSubsistemaPeneira;
      if (!ignore_cmdSelecaoSubsistemaPeneira) _values_[1] = cmdSelecaoSubsistemaPeneira;
      if (!ignore_cmdLigaSubsistemaRoscas) _values_[2] = cmdLigaSubsistemaRoscas;
      if (!ignore_cmdSelecaoSubsistemaRoscas) _values_[3] = cmdSelecaoSubsistemaRoscas;
      if (!ignore_cmdLigaSubsistemaRaspComp) _values_[4] = cmdLigaSubsistemaRaspComp;
      if (!ignore_cmdSelecaoSubsistemaRaspComp) _values_[5] = cmdSelecaoSubsistemaRaspComp;
      if (!ignore_cmdSelecaoBombaHigienizacao) _values_[6] = cmdSelecaoBombaHigienizacao;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_E_RESET_FALHA(System.Boolean cmdResetFalha)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {cmdResetFalha});
    }
    public bool FireEvent_E_RESET_FALHA(Hidryco.HidrycoLib.Symbols.Pre_Tratamento.E_RESET_FALHAEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.cmdResetFalha.HasValue) _values_[0] = ea.cmdResetFalha.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_E_RESET_FALHA(System.Boolean cmdResetFalha, bool ignore_cmdResetFalha)
    {
      object[] _values_ = new object[1];
      if (!ignore_cmdResetFalha) _values_[0] = cmdResetFalha;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }

  }
}

namespace Hidryco.HidrycoLib.Symbols.Pre_Tratamento
{
  partial class sResumo
  {

    private event EventHandler<Hidryco.HidrycoLib.Symbols.Pre_Tratamento.E_ATUALIZA_ENTRADASEventArgs> E_ATUALIZA_ENTRADAS_Fired;

    private event EventHandler<Hidryco.HidrycoLib.Symbols.Pre_Tratamento.E_ATUALIZA_RESUMOEventArgs> E_ATUALIZA_RESUMO_Fired;

    protected override void OnEndInit()
    {
      if (E_ATUALIZA_ENTRADAS_Fired != null)
        AttachEventInput(0);
      if (E_ATUALIZA_RESUMO_Fired != null)
        AttachEventInput(1);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (E_ATUALIZA_ENTRADAS_Fired != null)
          {
            try
            {
              E_ATUALIZA_ENTRADAS_Fired(this, new Hidryco.HidrycoLib.Symbols.Pre_Tratamento.E_ATUALIZA_ENTRADASEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","E_ATUALIZA_ENTRADAS_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 1:
          if (E_ATUALIZA_RESUMO_Fired != null)
          {
            try
            {
              E_ATUALIZA_RESUMO_Fired(this, new Hidryco.HidrycoLib.Symbols.Pre_Tratamento.E_ATUALIZA_RESUMOEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","E_ATUALIZA_RESUMO_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_E_ATUALIZA_COMANDO(System.Boolean cmdLigaSubsistemaPeneira, System.Boolean cmdSelecaoSubsistemaPeneira, System.Boolean cmdLigaSubsistemaRoscas, System.Boolean cmdSelecaoSubsistemaRoscas, System.Boolean cmdLigaSubsistemaRaspComp, System.Boolean cmdSelecaoSubsistemaRaspComp, System.Boolean cmdSelecaoBombaHigienizacao)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {cmdLigaSubsistemaPeneira, cmdSelecaoSubsistemaPeneira, cmdLigaSubsistemaRoscas, cmdSelecaoSubsistemaRoscas, cmdLigaSubsistemaRaspComp, cmdSelecaoSubsistemaRaspComp, cmdSelecaoBombaHigienizacao});
    }
    public bool FireEvent_E_ATUALIZA_COMANDO(Hidryco.HidrycoLib.Symbols.Pre_Tratamento.E_ATUALIZA_COMANDOEventArgs ea)
    {
      object[] _values_ = new object[7];
      if (ea.cmdLigaSubsistemaPeneira.HasValue) _values_[0] = ea.cmdLigaSubsistemaPeneira.Value;
      if (ea.cmdSelecaoSubsistemaPeneira.HasValue) _values_[1] = ea.cmdSelecaoSubsistemaPeneira.Value;
      if (ea.cmdLigaSubsistemaRoscas.HasValue) _values_[2] = ea.cmdLigaSubsistemaRoscas.Value;
      if (ea.cmdSelecaoSubsistemaRoscas.HasValue) _values_[3] = ea.cmdSelecaoSubsistemaRoscas.Value;
      if (ea.cmdLigaSubsistemaRaspComp.HasValue) _values_[4] = ea.cmdLigaSubsistemaRaspComp.Value;
      if (ea.cmdSelecaoSubsistemaRaspComp.HasValue) _values_[5] = ea.cmdSelecaoSubsistemaRaspComp.Value;
      if (ea.cmdSelecaoBombaHigienizacao.HasValue) _values_[6] = ea.cmdSelecaoBombaHigienizacao.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_E_ATUALIZA_COMANDO(System.Boolean cmdLigaSubsistemaPeneira, bool ignore_cmdLigaSubsistemaPeneira, System.Boolean cmdSelecaoSubsistemaPeneira, bool ignore_cmdSelecaoSubsistemaPeneira, System.Boolean cmdLigaSubsistemaRoscas, bool ignore_cmdLigaSubsistemaRoscas, System.Boolean cmdSelecaoSubsistemaRoscas, bool ignore_cmdSelecaoSubsistemaRoscas, System.Boolean cmdLigaSubsistemaRaspComp, bool ignore_cmdLigaSubsistemaRaspComp, System.Boolean cmdSelecaoSubsistemaRaspComp, bool ignore_cmdSelecaoSubsistemaRaspComp, System.Boolean cmdSelecaoBombaHigienizacao, bool ignore_cmdSelecaoBombaHigienizacao)
    {
      object[] _values_ = new object[7];
      if (!ignore_cmdLigaSubsistemaPeneira) _values_[0] = cmdLigaSubsistemaPeneira;
      if (!ignore_cmdSelecaoSubsistemaPeneira) _values_[1] = cmdSelecaoSubsistemaPeneira;
      if (!ignore_cmdLigaSubsistemaRoscas) _values_[2] = cmdLigaSubsistemaRoscas;
      if (!ignore_cmdSelecaoSubsistemaRoscas) _values_[3] = cmdSelecaoSubsistemaRoscas;
      if (!ignore_cmdLigaSubsistemaRaspComp) _values_[4] = cmdLigaSubsistemaRaspComp;
      if (!ignore_cmdSelecaoSubsistemaRaspComp) _values_[5] = cmdSelecaoSubsistemaRaspComp;
      if (!ignore_cmdSelecaoBombaHigienizacao) _values_[6] = cmdSelecaoBombaHigienizacao;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_E_RESET_FALHA(System.Boolean cmdResetFalha)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {cmdResetFalha});
    }
    public bool FireEvent_E_RESET_FALHA(Hidryco.HidrycoLib.Symbols.Pre_Tratamento.E_RESET_FALHAEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.cmdResetFalha.HasValue) _values_[0] = ea.cmdResetFalha.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_E_RESET_FALHA(System.Boolean cmdResetFalha, bool ignore_cmdResetFalha)
    {
      object[] _values_ = new object[1];
      if (!ignore_cmdResetFalha) _values_[0] = cmdResetFalha;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }

  }
}
#endregion #Pre_Tratamento_HMI;

#endregion Definitions;
