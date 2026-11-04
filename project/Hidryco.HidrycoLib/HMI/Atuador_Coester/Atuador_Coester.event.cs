/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 10/27/2026
 * Time: 10:00 AM
 * 
 */
using System;
using NxtControl.GuiFramework;
using NxtControl.Services;

#region Definitions;
#region #Atuador_Coester_HMI;

namespace Hidryco.HidrycoLib.Symbols.Atuador_Coester
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
    public bool Get_STS_COMUNICACAO_OK(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,0, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_COMUNICACAO_OK
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,0, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_FALHA_COMUNICACAO(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,1, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_FALHA_COMUNICACAO
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,1, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_REMOTO(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,2, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_REMOTO
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,2, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_LOCAL(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,3, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_LOCAL
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,3, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_DESLIGADO(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,4, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_DESLIGADO
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

    public bool Get_STS_ABRINDO(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,7, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_ABRINDO
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,7, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_FECHANDO(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,8, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_FECHANDO
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,8, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_ANIMACAO(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,9, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? STS_ANIMACAO
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,9, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }

    public bool Get_fbkStsAutomatico(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,10, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? fbkStsAutomatico
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,10, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_DISPONIVEL_AUTOMATICO(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,11, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_DISPONIVEL_AUTOMATICO
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,11, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_FALHA_POSICAO(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,12, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_FALHA_POSICAO
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,12, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_ALM_COMUNICACAO_EST(ref System.Byte value)
    {
      if (accessorService == null)
        return false;
      byte var = 0;
      bool ret = accessorService.GetByteValue(channelId, cookie, eventIndex, true,13, ref var);
      if (ret) value = (System.Byte) var;
      return ret;
    }

    public System.Byte? STS_ALM_COMUNICACAO_EST
    { get {
      if (accessorService == null)
        return null;
      byte var = 0;
      bool ret = accessorService.GetByteValue(channelId, cookie, eventIndex, true,13, ref var);
      if (!ret) return null;
      return (System.Byte) var;
    }  }

    public bool Get_STS_ALM_POSICAO_EST(ref System.Byte value)
    {
      if (accessorService == null)
        return false;
      byte var = 0;
      bool ret = accessorService.GetByteValue(channelId, cookie, eventIndex, true,14, ref var);
      if (ret) value = (System.Byte) var;
      return ret;
    }

    public System.Byte? STS_ALM_POSICAO_EST
    { get {
      if (accessorService == null)
        return null;
      byte var = 0;
      bool ret = accessorService.GetByteValue(channelId, cookie, eventIndex, true,14, ref var);
      if (!ret) return null;
      return (System.Byte) var;
    }  }

    public bool Get_STS_POSICIONADOR(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,15, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_POSICIONADOR
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,15, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_POSICAO(ref System.Single value)
    {
      if (accessorService == null)
        return false;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,16, ref var);
      if (ret) value = (System.Single) var;
      return ret;
    }

    public System.Single? STS_POSICAO
    { get {
      if (accessorService == null)
        return null;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,16, ref var);
      if (!ret) return null;
      return (System.Single) var;
    }  }

    public bool Get_STS_POSICAO_REFERENCIA(ref System.Single value)
    {
      if (accessorService == null)
        return false;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,17, ref var);
      if (ret) value = (System.Single) var;
      return ret;
    }

    public System.Single? STS_POSICAO_REFERENCIA
    { get {
      if (accessorService == null)
        return null;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,17, ref var);
      if (!ret) return null;
      return (System.Single) var;
    }  }

    public bool Get_STS_FALHA_ATUADOR(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,18, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_FALHA_ATUADOR
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,18, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_CODIGO_FALHA(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,19, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? STS_CODIGO_FALHA
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,19, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }

    public bool Get_STS_ALM_ATUADOR_EST(ref System.Byte value)
    {
      if (accessorService == null)
        return false;
      byte var = 0;
      bool ret = accessorService.GetByteValue(channelId, cookie, eventIndex, true,20, ref var);
      if (ret) value = (System.Byte) var;
      return ret;
    }

    public System.Byte? STS_ALM_ATUADOR_EST
    { get {
      if (accessorService == null)
        return null;
      byte var = 0;
      bool ret = accessorService.GetByteValue(channelId, cookie, eventIndex, true,20, ref var);
      if (!ret) return null;
      return (System.Byte) var;
    }  }

    public bool Get_STS_TORQUE(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,21, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? STS_TORQUE
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,21, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }

    public bool Get_STS_TEMPO_PERCURSO(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,22, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? STS_TEMPO_PERCURSO
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,22, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }

    public bool Get_STS_TEMPERATURA(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,23, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? STS_TEMPERATURA
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,23, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }

    public bool Get_STS_TORQUE_PCT(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,24, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? STS_TORQUE_PCT
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,24, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }

    public bool Get_STS_STATUS2(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,25, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? STS_STATUS2
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,25, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }

    public bool Get_STS_ALARME1(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,26, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? STS_ALARME1
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,26, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }

    public bool Get_STS_ALARME2(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,27, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? STS_ALARME2
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,27, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }

    public bool Get_STS_ALARME(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,28, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_ALARME
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,28, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }


  }

}

namespace Hidryco.HidrycoLib.Symbols.Atuador_Coester
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
    private System.Single? STP_TOLERANCIA_POSICAO_field = null;
    public System.Single? STP_TOLERANCIA_POSICAO
    {
       get { return STP_TOLERANCIA_POSICAO_field; }
       set { STP_TOLERANCIA_POSICAO_field = value; }
    }

  }

}

namespace Hidryco.HidrycoLib.Symbols.Atuador_Coester
{
  partial class sValvula
  {

    private event EventHandler<Hidryco.HidrycoLib.Symbols.Atuador_Coester.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    private event EventHandler<Hidryco.HidrycoLib.Symbols.Atuador_Coester.REQEventArgs> REQ_Fired;

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
              LOAD_PERS_DATA_Fired(this, new Hidryco.HidrycoLib.Symbols.Atuador_Coester.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
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
              REQ_Fired(this, new Hidryco.HidrycoLib.Symbols.Atuador_Coester.REQEventArgs(channelId, cookie, eventIndex));
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
    public bool FireEvent_E_STS_AUTOMATICO(Hidryco.HidrycoLib.Symbols.Atuador_Coester.E_STS_AUTOMATICOEventArgs ea)
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
    public bool FireEvent_E_CMD_ABRIR_MANUAL(Hidryco.HidrycoLib.Symbols.Atuador_Coester.E_CMD_ABRIR_MANUALEventArgs ea)
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
    public bool FireEvent_E_CMD_FECHAR_MANUAL(Hidryco.HidrycoLib.Symbols.Atuador_Coester.E_CMD_FECHAR_MANUALEventArgs ea)
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
    public bool FireEvent_E_CMD_PARAR_MANUAL(System.Boolean CMD_PARAR_MANUAL)
    {
      return ((IHMIAccessorOutput)this).FireEvent(3, new object[] {CMD_PARAR_MANUAL});
    }
    public bool FireEvent_E_CMD_PARAR_MANUAL(Hidryco.HidrycoLib.Symbols.Atuador_Coester.E_CMD_PARAR_MANUALEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.CMD_PARAR_MANUAL.HasValue) _values_[0] = ea.CMD_PARAR_MANUAL.Value;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_E_CMD_PARAR_MANUAL(System.Boolean CMD_PARAR_MANUAL, bool ignore_CMD_PARAR_MANUAL)
    {
      object[] _values_ = new object[1];
      if (!ignore_CMD_PARAR_MANUAL) _values_[0] = CMD_PARAR_MANUAL;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_E_CMD_POSICIONAR_MANUAL(System.Boolean CMD_POSICIONAR_MANUAL)
    {
      return ((IHMIAccessorOutput)this).FireEvent(4, new object[] {CMD_POSICIONAR_MANUAL});
    }
    public bool FireEvent_E_CMD_POSICIONAR_MANUAL(Hidryco.HidrycoLib.Symbols.Atuador_Coester.E_CMD_POSICIONAR_MANUALEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.CMD_POSICIONAR_MANUAL.HasValue) _values_[0] = ea.CMD_POSICIONAR_MANUAL.Value;
      return ((IHMIAccessorOutput)this).FireEvent(4, _values_);
    }
    public bool FireEvent_E_CMD_POSICIONAR_MANUAL(System.Boolean CMD_POSICIONAR_MANUAL, bool ignore_CMD_POSICIONAR_MANUAL)
    {
      object[] _values_ = new object[1];
      if (!ignore_CMD_POSICIONAR_MANUAL) _values_[0] = CMD_POSICIONAR_MANUAL;
      return ((IHMIAccessorOutput)this).FireEvent(4, _values_);
    }
    public bool FireEvent_E_CMD_RESET_FALHA(System.Boolean CMD_RESET_FALHA)
    {
      return ((IHMIAccessorOutput)this).FireEvent(5, new object[] {CMD_RESET_FALHA});
    }
    public bool FireEvent_E_CMD_RESET_FALHA(Hidryco.HidrycoLib.Symbols.Atuador_Coester.E_CMD_RESET_FALHAEventArgs ea)
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
    public bool FireEvent_CNF(System.UInt16 STP_FALHA_ABERTURA, System.UInt16 STP_FALHA_FECHAMENTO, System.Int16 STP_POSICAO_DESEJADA_MANUAL, System.Single STP_TOLERANCIA_POSICAO)
    {
      return ((IHMIAccessorOutput)this).FireEvent(6, new object[] {STP_FALHA_ABERTURA, STP_FALHA_FECHAMENTO, STP_POSICAO_DESEJADA_MANUAL, STP_TOLERANCIA_POSICAO});
    }
    public bool FireEvent_CNF(Hidryco.HidrycoLib.Symbols.Atuador_Coester.CNFEventArgs ea)
    {
      object[] _values_ = new object[4];
      if (ea.STP_FALHA_ABERTURA.HasValue) _values_[0] = ea.STP_FALHA_ABERTURA.Value;
      if (ea.STP_FALHA_FECHAMENTO.HasValue) _values_[1] = ea.STP_FALHA_FECHAMENTO.Value;
      if (ea.STP_POSICAO_DESEJADA_MANUAL.HasValue) _values_[2] = ea.STP_POSICAO_DESEJADA_MANUAL.Value;
      if (ea.STP_TOLERANCIA_POSICAO.HasValue) _values_[3] = ea.STP_TOLERANCIA_POSICAO.Value;
      return ((IHMIAccessorOutput)this).FireEvent(6, _values_);
    }
    public bool FireEvent_CNF(System.UInt16 STP_FALHA_ABERTURA, bool ignore_STP_FALHA_ABERTURA, System.UInt16 STP_FALHA_FECHAMENTO, bool ignore_STP_FALHA_FECHAMENTO, System.Int16 STP_POSICAO_DESEJADA_MANUAL, bool ignore_STP_POSICAO_DESEJADA_MANUAL, System.Single STP_TOLERANCIA_POSICAO, bool ignore_STP_TOLERANCIA_POSICAO)
    {
      object[] _values_ = new object[4];
      if (!ignore_STP_FALHA_ABERTURA) _values_[0] = STP_FALHA_ABERTURA;
      if (!ignore_STP_FALHA_FECHAMENTO) _values_[1] = STP_FALHA_FECHAMENTO;
      if (!ignore_STP_POSICAO_DESEJADA_MANUAL) _values_[2] = STP_POSICAO_DESEJADA_MANUAL;
      if (!ignore_STP_TOLERANCIA_POSICAO) _values_[3] = STP_TOLERANCIA_POSICAO;
      return ((IHMIAccessorOutput)this).FireEvent(6, _values_);
    }

  }
}

namespace Hidryco.HidrycoLib.Symbols.Atuador_Coester
{
  partial class sValvulaV
  {

    private event EventHandler<Hidryco.HidrycoLib.Symbols.Atuador_Coester.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    private event EventHandler<Hidryco.HidrycoLib.Symbols.Atuador_Coester.REQEventArgs> REQ_Fired;

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
              LOAD_PERS_DATA_Fired(this, new Hidryco.HidrycoLib.Symbols.Atuador_Coester.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
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
              REQ_Fired(this, new Hidryco.HidrycoLib.Symbols.Atuador_Coester.REQEventArgs(channelId, cookie, eventIndex));
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
    public bool FireEvent_E_STS_AUTOMATICO(Hidryco.HidrycoLib.Symbols.Atuador_Coester.E_STS_AUTOMATICOEventArgs ea)
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
    public bool FireEvent_E_CMD_ABRIR_MANUAL(Hidryco.HidrycoLib.Symbols.Atuador_Coester.E_CMD_ABRIR_MANUALEventArgs ea)
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
    public bool FireEvent_E_CMD_FECHAR_MANUAL(Hidryco.HidrycoLib.Symbols.Atuador_Coester.E_CMD_FECHAR_MANUALEventArgs ea)
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
    public bool FireEvent_E_CMD_PARAR_MANUAL(System.Boolean CMD_PARAR_MANUAL)
    {
      return ((IHMIAccessorOutput)this).FireEvent(3, new object[] {CMD_PARAR_MANUAL});
    }
    public bool FireEvent_E_CMD_PARAR_MANUAL(Hidryco.HidrycoLib.Symbols.Atuador_Coester.E_CMD_PARAR_MANUALEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.CMD_PARAR_MANUAL.HasValue) _values_[0] = ea.CMD_PARAR_MANUAL.Value;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_E_CMD_PARAR_MANUAL(System.Boolean CMD_PARAR_MANUAL, bool ignore_CMD_PARAR_MANUAL)
    {
      object[] _values_ = new object[1];
      if (!ignore_CMD_PARAR_MANUAL) _values_[0] = CMD_PARAR_MANUAL;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_E_CMD_POSICIONAR_MANUAL(System.Boolean CMD_POSICIONAR_MANUAL)
    {
      return ((IHMIAccessorOutput)this).FireEvent(4, new object[] {CMD_POSICIONAR_MANUAL});
    }
    public bool FireEvent_E_CMD_POSICIONAR_MANUAL(Hidryco.HidrycoLib.Symbols.Atuador_Coester.E_CMD_POSICIONAR_MANUALEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.CMD_POSICIONAR_MANUAL.HasValue) _values_[0] = ea.CMD_POSICIONAR_MANUAL.Value;
      return ((IHMIAccessorOutput)this).FireEvent(4, _values_);
    }
    public bool FireEvent_E_CMD_POSICIONAR_MANUAL(System.Boolean CMD_POSICIONAR_MANUAL, bool ignore_CMD_POSICIONAR_MANUAL)
    {
      object[] _values_ = new object[1];
      if (!ignore_CMD_POSICIONAR_MANUAL) _values_[0] = CMD_POSICIONAR_MANUAL;
      return ((IHMIAccessorOutput)this).FireEvent(4, _values_);
    }
    public bool FireEvent_E_CMD_RESET_FALHA(System.Boolean CMD_RESET_FALHA)
    {
      return ((IHMIAccessorOutput)this).FireEvent(5, new object[] {CMD_RESET_FALHA});
    }
    public bool FireEvent_E_CMD_RESET_FALHA(Hidryco.HidrycoLib.Symbols.Atuador_Coester.E_CMD_RESET_FALHAEventArgs ea)
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
    public bool FireEvent_CNF(System.UInt16 STP_FALHA_ABERTURA, System.UInt16 STP_FALHA_FECHAMENTO, System.Int16 STP_POSICAO_DESEJADA_MANUAL, System.Single STP_TOLERANCIA_POSICAO)
    {
      return ((IHMIAccessorOutput)this).FireEvent(6, new object[] {STP_FALHA_ABERTURA, STP_FALHA_FECHAMENTO, STP_POSICAO_DESEJADA_MANUAL, STP_TOLERANCIA_POSICAO});
    }
    public bool FireEvent_CNF(Hidryco.HidrycoLib.Symbols.Atuador_Coester.CNFEventArgs ea)
    {
      object[] _values_ = new object[4];
      if (ea.STP_FALHA_ABERTURA.HasValue) _values_[0] = ea.STP_FALHA_ABERTURA.Value;
      if (ea.STP_FALHA_FECHAMENTO.HasValue) _values_[1] = ea.STP_FALHA_FECHAMENTO.Value;
      if (ea.STP_POSICAO_DESEJADA_MANUAL.HasValue) _values_[2] = ea.STP_POSICAO_DESEJADA_MANUAL.Value;
      if (ea.STP_TOLERANCIA_POSICAO.HasValue) _values_[3] = ea.STP_TOLERANCIA_POSICAO.Value;
      return ((IHMIAccessorOutput)this).FireEvent(6, _values_);
    }
    public bool FireEvent_CNF(System.UInt16 STP_FALHA_ABERTURA, bool ignore_STP_FALHA_ABERTURA, System.UInt16 STP_FALHA_FECHAMENTO, bool ignore_STP_FALHA_FECHAMENTO, System.Int16 STP_POSICAO_DESEJADA_MANUAL, bool ignore_STP_POSICAO_DESEJADA_MANUAL, System.Single STP_TOLERANCIA_POSICAO, bool ignore_STP_TOLERANCIA_POSICAO)
    {
      object[] _values_ = new object[4];
      if (!ignore_STP_FALHA_ABERTURA) _values_[0] = STP_FALHA_ABERTURA;
      if (!ignore_STP_FALHA_FECHAMENTO) _values_[1] = STP_FALHA_FECHAMENTO;
      if (!ignore_STP_POSICAO_DESEJADA_MANUAL) _values_[2] = STP_POSICAO_DESEJADA_MANUAL;
      if (!ignore_STP_TOLERANCIA_POSICAO) _values_[3] = STP_TOLERANCIA_POSICAO;
      return ((IHMIAccessorOutput)this).FireEvent(6, _values_);
    }

  }
}

namespace Hidryco.HidrycoLib.Symbols.Atuador_Coester
{
  partial class sComporta
  {

    private event EventHandler<Hidryco.HidrycoLib.Symbols.Atuador_Coester.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    private event EventHandler<Hidryco.HidrycoLib.Symbols.Atuador_Coester.REQEventArgs> REQ_Fired;

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
              LOAD_PERS_DATA_Fired(this, new Hidryco.HidrycoLib.Symbols.Atuador_Coester.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
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
              REQ_Fired(this, new Hidryco.HidrycoLib.Symbols.Atuador_Coester.REQEventArgs(channelId, cookie, eventIndex));
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
    public bool FireEvent_E_STS_AUTOMATICO(Hidryco.HidrycoLib.Symbols.Atuador_Coester.E_STS_AUTOMATICOEventArgs ea)
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
    public bool FireEvent_E_CMD_ABRIR_MANUAL(Hidryco.HidrycoLib.Symbols.Atuador_Coester.E_CMD_ABRIR_MANUALEventArgs ea)
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
    public bool FireEvent_E_CMD_FECHAR_MANUAL(Hidryco.HidrycoLib.Symbols.Atuador_Coester.E_CMD_FECHAR_MANUALEventArgs ea)
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
    public bool FireEvent_E_CMD_PARAR_MANUAL(System.Boolean CMD_PARAR_MANUAL)
    {
      return ((IHMIAccessorOutput)this).FireEvent(3, new object[] {CMD_PARAR_MANUAL});
    }
    public bool FireEvent_E_CMD_PARAR_MANUAL(Hidryco.HidrycoLib.Symbols.Atuador_Coester.E_CMD_PARAR_MANUALEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.CMD_PARAR_MANUAL.HasValue) _values_[0] = ea.CMD_PARAR_MANUAL.Value;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_E_CMD_PARAR_MANUAL(System.Boolean CMD_PARAR_MANUAL, bool ignore_CMD_PARAR_MANUAL)
    {
      object[] _values_ = new object[1];
      if (!ignore_CMD_PARAR_MANUAL) _values_[0] = CMD_PARAR_MANUAL;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_E_CMD_POSICIONAR_MANUAL(System.Boolean CMD_POSICIONAR_MANUAL)
    {
      return ((IHMIAccessorOutput)this).FireEvent(4, new object[] {CMD_POSICIONAR_MANUAL});
    }
    public bool FireEvent_E_CMD_POSICIONAR_MANUAL(Hidryco.HidrycoLib.Symbols.Atuador_Coester.E_CMD_POSICIONAR_MANUALEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.CMD_POSICIONAR_MANUAL.HasValue) _values_[0] = ea.CMD_POSICIONAR_MANUAL.Value;
      return ((IHMIAccessorOutput)this).FireEvent(4, _values_);
    }
    public bool FireEvent_E_CMD_POSICIONAR_MANUAL(System.Boolean CMD_POSICIONAR_MANUAL, bool ignore_CMD_POSICIONAR_MANUAL)
    {
      object[] _values_ = new object[1];
      if (!ignore_CMD_POSICIONAR_MANUAL) _values_[0] = CMD_POSICIONAR_MANUAL;
      return ((IHMIAccessorOutput)this).FireEvent(4, _values_);
    }
    public bool FireEvent_E_CMD_RESET_FALHA(System.Boolean CMD_RESET_FALHA)
    {
      return ((IHMIAccessorOutput)this).FireEvent(5, new object[] {CMD_RESET_FALHA});
    }
    public bool FireEvent_E_CMD_RESET_FALHA(Hidryco.HidrycoLib.Symbols.Atuador_Coester.E_CMD_RESET_FALHAEventArgs ea)
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
    public bool FireEvent_CNF(System.UInt16 STP_FALHA_ABERTURA, System.UInt16 STP_FALHA_FECHAMENTO, System.Int16 STP_POSICAO_DESEJADA_MANUAL, System.Single STP_TOLERANCIA_POSICAO)
    {
      return ((IHMIAccessorOutput)this).FireEvent(6, new object[] {STP_FALHA_ABERTURA, STP_FALHA_FECHAMENTO, STP_POSICAO_DESEJADA_MANUAL, STP_TOLERANCIA_POSICAO});
    }
    public bool FireEvent_CNF(Hidryco.HidrycoLib.Symbols.Atuador_Coester.CNFEventArgs ea)
    {
      object[] _values_ = new object[4];
      if (ea.STP_FALHA_ABERTURA.HasValue) _values_[0] = ea.STP_FALHA_ABERTURA.Value;
      if (ea.STP_FALHA_FECHAMENTO.HasValue) _values_[1] = ea.STP_FALHA_FECHAMENTO.Value;
      if (ea.STP_POSICAO_DESEJADA_MANUAL.HasValue) _values_[2] = ea.STP_POSICAO_DESEJADA_MANUAL.Value;
      if (ea.STP_TOLERANCIA_POSICAO.HasValue) _values_[3] = ea.STP_TOLERANCIA_POSICAO.Value;
      return ((IHMIAccessorOutput)this).FireEvent(6, _values_);
    }
    public bool FireEvent_CNF(System.UInt16 STP_FALHA_ABERTURA, bool ignore_STP_FALHA_ABERTURA, System.UInt16 STP_FALHA_FECHAMENTO, bool ignore_STP_FALHA_FECHAMENTO, System.Int16 STP_POSICAO_DESEJADA_MANUAL, bool ignore_STP_POSICAO_DESEJADA_MANUAL, System.Single STP_TOLERANCIA_POSICAO, bool ignore_STP_TOLERANCIA_POSICAO)
    {
      object[] _values_ = new object[4];
      if (!ignore_STP_FALHA_ABERTURA) _values_[0] = STP_FALHA_ABERTURA;
      if (!ignore_STP_FALHA_FECHAMENTO) _values_[1] = STP_FALHA_FECHAMENTO;
      if (!ignore_STP_POSICAO_DESEJADA_MANUAL) _values_[2] = STP_POSICAO_DESEJADA_MANUAL;
      if (!ignore_STP_TOLERANCIA_POSICAO) _values_[3] = STP_TOLERANCIA_POSICAO;
      return ((IHMIAccessorOutput)this).FireEvent(6, _values_);
    }

  }
}

namespace Hidryco.HidrycoLib.Faceplates.Atuador_Coester
{
  partial class fpDefault
  {

    private event EventHandler<Hidryco.HidrycoLib.Symbols.Atuador_Coester.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    private event EventHandler<Hidryco.HidrycoLib.Symbols.Atuador_Coester.REQEventArgs> REQ_Fired;

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
              LOAD_PERS_DATA_Fired(this, new Hidryco.HidrycoLib.Symbols.Atuador_Coester.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
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
              REQ_Fired(this, new Hidryco.HidrycoLib.Symbols.Atuador_Coester.REQEventArgs(channelId, cookie, eventIndex));
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
    public bool FireEvent_E_STS_AUTOMATICO(Hidryco.HidrycoLib.Symbols.Atuador_Coester.E_STS_AUTOMATICOEventArgs ea)
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
    public bool FireEvent_E_CMD_ABRIR_MANUAL(Hidryco.HidrycoLib.Symbols.Atuador_Coester.E_CMD_ABRIR_MANUALEventArgs ea)
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
    public bool FireEvent_E_CMD_FECHAR_MANUAL(Hidryco.HidrycoLib.Symbols.Atuador_Coester.E_CMD_FECHAR_MANUALEventArgs ea)
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
    public bool FireEvent_E_CMD_PARAR_MANUAL(System.Boolean CMD_PARAR_MANUAL)
    {
      return ((IHMIAccessorOutput)this).FireEvent(3, new object[] {CMD_PARAR_MANUAL});
    }
    public bool FireEvent_E_CMD_PARAR_MANUAL(Hidryco.HidrycoLib.Symbols.Atuador_Coester.E_CMD_PARAR_MANUALEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.CMD_PARAR_MANUAL.HasValue) _values_[0] = ea.CMD_PARAR_MANUAL.Value;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_E_CMD_PARAR_MANUAL(System.Boolean CMD_PARAR_MANUAL, bool ignore_CMD_PARAR_MANUAL)
    {
      object[] _values_ = new object[1];
      if (!ignore_CMD_PARAR_MANUAL) _values_[0] = CMD_PARAR_MANUAL;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_E_CMD_POSICIONAR_MANUAL(System.Boolean CMD_POSICIONAR_MANUAL)
    {
      return ((IHMIAccessorOutput)this).FireEvent(4, new object[] {CMD_POSICIONAR_MANUAL});
    }
    public bool FireEvent_E_CMD_POSICIONAR_MANUAL(Hidryco.HidrycoLib.Symbols.Atuador_Coester.E_CMD_POSICIONAR_MANUALEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.CMD_POSICIONAR_MANUAL.HasValue) _values_[0] = ea.CMD_POSICIONAR_MANUAL.Value;
      return ((IHMIAccessorOutput)this).FireEvent(4, _values_);
    }
    public bool FireEvent_E_CMD_POSICIONAR_MANUAL(System.Boolean CMD_POSICIONAR_MANUAL, bool ignore_CMD_POSICIONAR_MANUAL)
    {
      object[] _values_ = new object[1];
      if (!ignore_CMD_POSICIONAR_MANUAL) _values_[0] = CMD_POSICIONAR_MANUAL;
      return ((IHMIAccessorOutput)this).FireEvent(4, _values_);
    }
    public bool FireEvent_E_CMD_RESET_FALHA(System.Boolean CMD_RESET_FALHA)
    {
      return ((IHMIAccessorOutput)this).FireEvent(5, new object[] {CMD_RESET_FALHA});
    }
    public bool FireEvent_E_CMD_RESET_FALHA(Hidryco.HidrycoLib.Symbols.Atuador_Coester.E_CMD_RESET_FALHAEventArgs ea)
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
    public bool FireEvent_CNF(System.UInt16 STP_FALHA_ABERTURA, System.UInt16 STP_FALHA_FECHAMENTO, System.Int16 STP_POSICAO_DESEJADA_MANUAL, System.Single STP_TOLERANCIA_POSICAO)
    {
      return ((IHMIAccessorOutput)this).FireEvent(6, new object[] {STP_FALHA_ABERTURA, STP_FALHA_FECHAMENTO, STP_POSICAO_DESEJADA_MANUAL, STP_TOLERANCIA_POSICAO});
    }
    public bool FireEvent_CNF(Hidryco.HidrycoLib.Symbols.Atuador_Coester.CNFEventArgs ea)
    {
      object[] _values_ = new object[4];
      if (ea.STP_FALHA_ABERTURA.HasValue) _values_[0] = ea.STP_FALHA_ABERTURA.Value;
      if (ea.STP_FALHA_FECHAMENTO.HasValue) _values_[1] = ea.STP_FALHA_FECHAMENTO.Value;
      if (ea.STP_POSICAO_DESEJADA_MANUAL.HasValue) _values_[2] = ea.STP_POSICAO_DESEJADA_MANUAL.Value;
      if (ea.STP_TOLERANCIA_POSICAO.HasValue) _values_[3] = ea.STP_TOLERANCIA_POSICAO.Value;
      return ((IHMIAccessorOutput)this).FireEvent(6, _values_);
    }
    public bool FireEvent_CNF(System.UInt16 STP_FALHA_ABERTURA, bool ignore_STP_FALHA_ABERTURA, System.UInt16 STP_FALHA_FECHAMENTO, bool ignore_STP_FALHA_FECHAMENTO, System.Int16 STP_POSICAO_DESEJADA_MANUAL, bool ignore_STP_POSICAO_DESEJADA_MANUAL, System.Single STP_TOLERANCIA_POSICAO, bool ignore_STP_TOLERANCIA_POSICAO)
    {
      object[] _values_ = new object[4];
      if (!ignore_STP_FALHA_ABERTURA) _values_[0] = STP_FALHA_ABERTURA;
      if (!ignore_STP_FALHA_FECHAMENTO) _values_[1] = STP_FALHA_FECHAMENTO;
      if (!ignore_STP_POSICAO_DESEJADA_MANUAL) _values_[2] = STP_POSICAO_DESEJADA_MANUAL;
      if (!ignore_STP_TOLERANCIA_POSICAO) _values_[3] = STP_TOLERANCIA_POSICAO;
      return ((IHMIAccessorOutput)this).FireEvent(6, _values_);
    }

  }
}

namespace Hidryco.HidrycoLib.Faceplates.Atuador_Coester
{
  partial class fpDiagnostico
  {

    private event EventHandler<Hidryco.HidrycoLib.Symbols.Atuador_Coester.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    private event EventHandler<Hidryco.HidrycoLib.Symbols.Atuador_Coester.REQEventArgs> REQ_Fired;

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
              LOAD_PERS_DATA_Fired(this, new Hidryco.HidrycoLib.Symbols.Atuador_Coester.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
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
              REQ_Fired(this, new Hidryco.HidrycoLib.Symbols.Atuador_Coester.REQEventArgs(channelId, cookie, eventIndex));
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
    public bool FireEvent_E_STS_AUTOMATICO(Hidryco.HidrycoLib.Symbols.Atuador_Coester.E_STS_AUTOMATICOEventArgs ea)
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
    public bool FireEvent_E_CMD_ABRIR_MANUAL(Hidryco.HidrycoLib.Symbols.Atuador_Coester.E_CMD_ABRIR_MANUALEventArgs ea)
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
    public bool FireEvent_E_CMD_FECHAR_MANUAL(Hidryco.HidrycoLib.Symbols.Atuador_Coester.E_CMD_FECHAR_MANUALEventArgs ea)
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
    public bool FireEvent_E_CMD_PARAR_MANUAL(System.Boolean CMD_PARAR_MANUAL)
    {
      return ((IHMIAccessorOutput)this).FireEvent(3, new object[] {CMD_PARAR_MANUAL});
    }
    public bool FireEvent_E_CMD_PARAR_MANUAL(Hidryco.HidrycoLib.Symbols.Atuador_Coester.E_CMD_PARAR_MANUALEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.CMD_PARAR_MANUAL.HasValue) _values_[0] = ea.CMD_PARAR_MANUAL.Value;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_E_CMD_PARAR_MANUAL(System.Boolean CMD_PARAR_MANUAL, bool ignore_CMD_PARAR_MANUAL)
    {
      object[] _values_ = new object[1];
      if (!ignore_CMD_PARAR_MANUAL) _values_[0] = CMD_PARAR_MANUAL;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_E_CMD_POSICIONAR_MANUAL(System.Boolean CMD_POSICIONAR_MANUAL)
    {
      return ((IHMIAccessorOutput)this).FireEvent(4, new object[] {CMD_POSICIONAR_MANUAL});
    }
    public bool FireEvent_E_CMD_POSICIONAR_MANUAL(Hidryco.HidrycoLib.Symbols.Atuador_Coester.E_CMD_POSICIONAR_MANUALEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.CMD_POSICIONAR_MANUAL.HasValue) _values_[0] = ea.CMD_POSICIONAR_MANUAL.Value;
      return ((IHMIAccessorOutput)this).FireEvent(4, _values_);
    }
    public bool FireEvent_E_CMD_POSICIONAR_MANUAL(System.Boolean CMD_POSICIONAR_MANUAL, bool ignore_CMD_POSICIONAR_MANUAL)
    {
      object[] _values_ = new object[1];
      if (!ignore_CMD_POSICIONAR_MANUAL) _values_[0] = CMD_POSICIONAR_MANUAL;
      return ((IHMIAccessorOutput)this).FireEvent(4, _values_);
    }
    public bool FireEvent_E_CMD_RESET_FALHA(System.Boolean CMD_RESET_FALHA)
    {
      return ((IHMIAccessorOutput)this).FireEvent(5, new object[] {CMD_RESET_FALHA});
    }
    public bool FireEvent_E_CMD_RESET_FALHA(Hidryco.HidrycoLib.Symbols.Atuador_Coester.E_CMD_RESET_FALHAEventArgs ea)
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
    public bool FireEvent_CNF(System.UInt16 STP_FALHA_ABERTURA, System.UInt16 STP_FALHA_FECHAMENTO, System.Int16 STP_POSICAO_DESEJADA_MANUAL, System.Single STP_TOLERANCIA_POSICAO)
    {
      return ((IHMIAccessorOutput)this).FireEvent(6, new object[] {STP_FALHA_ABERTURA, STP_FALHA_FECHAMENTO, STP_POSICAO_DESEJADA_MANUAL, STP_TOLERANCIA_POSICAO});
    }
    public bool FireEvent_CNF(Hidryco.HidrycoLib.Symbols.Atuador_Coester.CNFEventArgs ea)
    {
      object[] _values_ = new object[4];
      if (ea.STP_FALHA_ABERTURA.HasValue) _values_[0] = ea.STP_FALHA_ABERTURA.Value;
      if (ea.STP_FALHA_FECHAMENTO.HasValue) _values_[1] = ea.STP_FALHA_FECHAMENTO.Value;
      if (ea.STP_POSICAO_DESEJADA_MANUAL.HasValue) _values_[2] = ea.STP_POSICAO_DESEJADA_MANUAL.Value;
      if (ea.STP_TOLERANCIA_POSICAO.HasValue) _values_[3] = ea.STP_TOLERANCIA_POSICAO.Value;
      return ((IHMIAccessorOutput)this).FireEvent(6, _values_);
    }
    public bool FireEvent_CNF(System.UInt16 STP_FALHA_ABERTURA, bool ignore_STP_FALHA_ABERTURA, System.UInt16 STP_FALHA_FECHAMENTO, bool ignore_STP_FALHA_FECHAMENTO, System.Int16 STP_POSICAO_DESEJADA_MANUAL, bool ignore_STP_POSICAO_DESEJADA_MANUAL, System.Single STP_TOLERANCIA_POSICAO, bool ignore_STP_TOLERANCIA_POSICAO)
    {
      object[] _values_ = new object[4];
      if (!ignore_STP_FALHA_ABERTURA) _values_[0] = STP_FALHA_ABERTURA;
      if (!ignore_STP_FALHA_FECHAMENTO) _values_[1] = STP_FALHA_FECHAMENTO;
      if (!ignore_STP_POSICAO_DESEJADA_MANUAL) _values_[2] = STP_POSICAO_DESEJADA_MANUAL;
      if (!ignore_STP_TOLERANCIA_POSICAO) _values_[3] = STP_TOLERANCIA_POSICAO;
      return ((IHMIAccessorOutput)this).FireEvent(6, _values_);
    }

  }
}
#endregion #Atuador_Coester_HMI;

#endregion Definitions;
