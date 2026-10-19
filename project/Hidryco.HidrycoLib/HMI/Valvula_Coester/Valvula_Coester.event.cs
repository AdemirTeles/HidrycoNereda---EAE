/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 10/19/2026
 * Time: 10:00 AM
 * 
 */
using System;
using NxtControl.GuiFramework;
using NxtControl.Services;

#region Definitions;
#region #Valvula_Coester_HMI;

namespace Hidryco.HidrycoLib.Symbols.Valvula_Coester
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

    public bool Get_STS_REMOTO(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,1, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_REMOTO
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,1, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_LOCAL(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,2, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_LOCAL
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,2, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_DESLIGADO(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,3, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_DESLIGADO
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,3, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_AUTOMATICO(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,4, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_AUTOMATICO
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,4, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_ABERTA(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,5, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_ABERTA
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,5, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_FECHADA(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,6, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_FECHADA
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,6, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_INTERMEDIARIA(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,7, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_INTERMEDIARIA
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,7, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_ABRINDO(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,8, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_ABRINDO
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,8, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_FECHANDO(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,9, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_FECHANDO
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,9, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_VOLANTE(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,10, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_VOLANTE
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,10, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_POSICAO(ref System.Single value)
    {
      if (accessorService == null)
        return false;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,11, ref var);
      if (ret) value = (System.Single) var;
      return ret;
    }

    public System.Single? STS_POSICAO
    { get {
      if (accessorService == null)
        return null;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,11, ref var);
      if (!ret) return null;
      return (System.Single) var;
    }  }

    public bool Get_STS_POSICAO_REFERENCIA(ref System.Single value)
    {
      if (accessorService == null)
        return false;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,12, ref var);
      if (ret) value = (System.Single) var;
      return ret;
    }

    public System.Single? STS_POSICAO_REFERENCIA
    { get {
      if (accessorService == null)
        return null;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,12, ref var);
      if (!ret) return null;
      return (System.Single) var;
    }  }

    public bool Get_STS_TORQUE(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,13, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? STS_TORQUE
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,13, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }

    public bool Get_STS_TORQUE_PCT(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,14, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? STS_TORQUE_PCT
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,14, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }

    public bool Get_STS_TEMPERATURA(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,15, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? STS_TEMPERATURA
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,15, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }

    public bool Get_STS_TEMPO_PERCURSO(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,16, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? STS_TEMPO_PERCURSO
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,16, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }

    public bool Get_STS_PARTIDAS_DIA(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,17, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? STS_PARTIDAS_DIA
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,17, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }

    public bool Get_STS_PARTIDAS_DIA_MAX(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,18, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? STS_PARTIDAS_DIA_MAX
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,18, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }

    public bool Get_STS_MODO_CONTINUO(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,19, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_MODO_CONTINUO
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,19, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_MODULANTE(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,20, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_MODULANTE
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,20, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_CMD_MANUAL(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,21, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? STS_CMD_MANUAL
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,21, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }

    public bool Get_STS_FALHA_COMUNICACAO(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,22, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_FALHA_COMUNICACAO
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,22, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_FALHA_ATUADOR(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,23, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_FALHA_ATUADOR
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,23, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_FALHA_POSICAO(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,24, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_FALHA_POSICAO
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,24, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_CODIGO_FALHA(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,25, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? STS_CODIGO_FALHA
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,25, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }

    public bool Get_STS_BLOQUEADO(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,26, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_BLOQUEADO
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,26, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_DISPONIVEL_AUTOMATICO(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,27, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_DISPONIVEL_AUTOMATICO
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,27, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
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

    public bool Get_STS_AVISO_CONFIG(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,29, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_AVISO_CONFIG
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,29, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_AVISO_PARTIDAS(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,30, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_AVISO_PARTIDAS
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,30, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_ANIMACAO(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,31, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? STS_ANIMACAO
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,31, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }

    public bool Get_STS_STATUS2(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,32, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? STS_STATUS2
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,32, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }

    public bool Get_STS_ALARME1(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,33, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? STS_ALARME1
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,33, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }

    public bool Get_STS_ALARME2(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,34, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? STS_ALARME2
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,34, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }

    public bool Get_STS_ALM_COMUNICACAO_EST(ref System.Byte value)
    {
      if (accessorService == null)
        return false;
      byte var = 0;
      bool ret = accessorService.GetByteValue(channelId, cookie, eventIndex, true,35, ref var);
      if (ret) value = (System.Byte) var;
      return ret;
    }

    public System.Byte? STS_ALM_COMUNICACAO_EST
    { get {
      if (accessorService == null)
        return null;
      byte var = 0;
      bool ret = accessorService.GetByteValue(channelId, cookie, eventIndex, true,35, ref var);
      if (!ret) return null;
      return (System.Byte) var;
    }  }

    public bool Get_STS_ALM_ATUADOR_EST(ref System.Byte value)
    {
      if (accessorService == null)
        return false;
      byte var = 0;
      bool ret = accessorService.GetByteValue(channelId, cookie, eventIndex, true,36, ref var);
      if (ret) value = (System.Byte) var;
      return ret;
    }

    public System.Byte? STS_ALM_ATUADOR_EST
    { get {
      if (accessorService == null)
        return null;
      byte var = 0;
      bool ret = accessorService.GetByteValue(channelId, cookie, eventIndex, true,36, ref var);
      if (!ret) return null;
      return (System.Byte) var;
    }  }

    public bool Get_STS_ALM_POSICAO_EST(ref System.Byte value)
    {
      if (accessorService == null)
        return false;
      byte var = 0;
      bool ret = accessorService.GetByteValue(channelId, cookie, eventIndex, true,37, ref var);
      if (ret) value = (System.Byte) var;
      return ret;
    }

    public System.Byte? STS_ALM_POSICAO_EST
    { get {
      if (accessorService == null)
        return null;
      byte var = 0;
      bool ret = accessorService.GetByteValue(channelId, cookie, eventIndex, true,37, ref var);
      if (!ret) return null;
      return (System.Byte) var;
    }  }


  }

}

namespace Hidryco.HidrycoLib.Symbols.Valvula_Coester
{

  public class E_MODO_OPERACAOEventArgs : System.EventArgs
  {
    public E_MODO_OPERACAOEventArgs()
    {
    }
    private System.Boolean? CMD_AUTOMATICO_field = null;
    public System.Boolean? CMD_AUTOMATICO
    {
       get { return CMD_AUTOMATICO_field; }
       set { CMD_AUTOMATICO_field = value; }
    }

  }

  public class E_COMANDO_MANUALEventArgs : System.EventArgs
  {
    public E_COMANDO_MANUALEventArgs()
    {
    }
    private System.Int16? CMD_MANUAL_field = null;
    public System.Int16? CMD_MANUAL
    {
       get { return CMD_MANUAL_field; }
       set { CMD_MANUAL_field = value; }
    }
    private System.Single? STP_POSICAO_MANUAL_field = null;
    public System.Single? STP_POSICAO_MANUAL
    {
       get { return STP_POSICAO_MANUAL_field; }
       set { STP_POSICAO_MANUAL_field = value; }
    }

  }

  public class E_PARAMETROSEventArgs : System.EventArgs
  {
    public E_PARAMETROSEventArgs()
    {
    }
    private System.Int16? STP_TEMPO_FALHA_POSICAO_field = null;
    public System.Int16? STP_TEMPO_FALHA_POSICAO
    {
       get { return STP_TEMPO_FALHA_POSICAO_field; }
       set { STP_TEMPO_FALHA_POSICAO_field = value; }
    }
    private System.Single? STP_TOLERANCIA_POSICAO_field = null;
    public System.Single? STP_TOLERANCIA_POSICAO
    {
       get { return STP_TOLERANCIA_POSICAO_field; }
       set { STP_TOLERANCIA_POSICAO_field = value; }
    }

  }

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

}

namespace Hidryco.HidrycoLib.Symbols.Valvula_Coester
{
  partial class sValvula
  {

    private event EventHandler<Hidryco.HidrycoLib.Symbols.Valvula_Coester.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    private event EventHandler<Hidryco.HidrycoLib.Symbols.Valvula_Coester.REQEventArgs> REQ_Fired;

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
              LOAD_PERS_DATA_Fired(this, new Hidryco.HidrycoLib.Symbols.Valvula_Coester.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
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
              REQ_Fired(this, new Hidryco.HidrycoLib.Symbols.Valvula_Coester.REQEventArgs(channelId, cookie, eventIndex));
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
    public bool FireEvent_E_MODO_OPERACAO(System.Boolean CMD_AUTOMATICO)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {CMD_AUTOMATICO});
    }
    public bool FireEvent_E_MODO_OPERACAO(Hidryco.HidrycoLib.Symbols.Valvula_Coester.E_MODO_OPERACAOEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.CMD_AUTOMATICO.HasValue) _values_[0] = ea.CMD_AUTOMATICO.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_E_MODO_OPERACAO(System.Boolean CMD_AUTOMATICO, bool ignore_CMD_AUTOMATICO)
    {
      object[] _values_ = new object[1];
      if (!ignore_CMD_AUTOMATICO) _values_[0] = CMD_AUTOMATICO;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_E_COMANDO_MANUAL(System.Int16 CMD_MANUAL, System.Single STP_POSICAO_MANUAL)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {CMD_MANUAL, STP_POSICAO_MANUAL});
    }
    public bool FireEvent_E_COMANDO_MANUAL(Hidryco.HidrycoLib.Symbols.Valvula_Coester.E_COMANDO_MANUALEventArgs ea)
    {
      object[] _values_ = new object[2];
      if (ea.CMD_MANUAL.HasValue) _values_[0] = ea.CMD_MANUAL.Value;
      if (ea.STP_POSICAO_MANUAL.HasValue) _values_[1] = ea.STP_POSICAO_MANUAL.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_E_COMANDO_MANUAL(System.Int16 CMD_MANUAL, bool ignore_CMD_MANUAL, System.Single STP_POSICAO_MANUAL, bool ignore_STP_POSICAO_MANUAL)
    {
      object[] _values_ = new object[2];
      if (!ignore_CMD_MANUAL) _values_[0] = CMD_MANUAL;
      if (!ignore_STP_POSICAO_MANUAL) _values_[1] = STP_POSICAO_MANUAL;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_E_PARAMETROS(System.Int16 STP_TEMPO_FALHA_POSICAO, System.Single STP_TOLERANCIA_POSICAO)
    {
      return ((IHMIAccessorOutput)this).FireEvent(2, new object[] {STP_TEMPO_FALHA_POSICAO, STP_TOLERANCIA_POSICAO});
    }
    public bool FireEvent_E_PARAMETROS(Hidryco.HidrycoLib.Symbols.Valvula_Coester.E_PARAMETROSEventArgs ea)
    {
      object[] _values_ = new object[2];
      if (ea.STP_TEMPO_FALHA_POSICAO.HasValue) _values_[0] = ea.STP_TEMPO_FALHA_POSICAO.Value;
      if (ea.STP_TOLERANCIA_POSICAO.HasValue) _values_[1] = ea.STP_TOLERANCIA_POSICAO.Value;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_E_PARAMETROS(System.Int16 STP_TEMPO_FALHA_POSICAO, bool ignore_STP_TEMPO_FALHA_POSICAO, System.Single STP_TOLERANCIA_POSICAO, bool ignore_STP_TOLERANCIA_POSICAO)
    {
      object[] _values_ = new object[2];
      if (!ignore_STP_TEMPO_FALHA_POSICAO) _values_[0] = STP_TEMPO_FALHA_POSICAO;
      if (!ignore_STP_TOLERANCIA_POSICAO) _values_[1] = STP_TOLERANCIA_POSICAO;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_E_RESET_FALHA(System.Boolean CMD_RESET_FALHA)
    {
      return ((IHMIAccessorOutput)this).FireEvent(3, new object[] {CMD_RESET_FALHA});
    }
    public bool FireEvent_E_RESET_FALHA(Hidryco.HidrycoLib.Symbols.Valvula_Coester.E_RESET_FALHAEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.CMD_RESET_FALHA.HasValue) _values_[0] = ea.CMD_RESET_FALHA.Value;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_E_RESET_FALHA(System.Boolean CMD_RESET_FALHA, bool ignore_CMD_RESET_FALHA)
    {
      object[] _values_ = new object[1];
      if (!ignore_CMD_RESET_FALHA) _values_[0] = CMD_RESET_FALHA;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }

  }
}

namespace Hidryco.HidrycoLib.Faceplates.Valvula_Coester
{
  partial class fpDefault
  {

    private event EventHandler<Hidryco.HidrycoLib.Symbols.Valvula_Coester.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    private event EventHandler<Hidryco.HidrycoLib.Symbols.Valvula_Coester.REQEventArgs> REQ_Fired;

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
              LOAD_PERS_DATA_Fired(this, new Hidryco.HidrycoLib.Symbols.Valvula_Coester.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
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
              REQ_Fired(this, new Hidryco.HidrycoLib.Symbols.Valvula_Coester.REQEventArgs(channelId, cookie, eventIndex));
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
    public bool FireEvent_E_MODO_OPERACAO(System.Boolean CMD_AUTOMATICO)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {CMD_AUTOMATICO});
    }
    public bool FireEvent_E_MODO_OPERACAO(Hidryco.HidrycoLib.Symbols.Valvula_Coester.E_MODO_OPERACAOEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.CMD_AUTOMATICO.HasValue) _values_[0] = ea.CMD_AUTOMATICO.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_E_MODO_OPERACAO(System.Boolean CMD_AUTOMATICO, bool ignore_CMD_AUTOMATICO)
    {
      object[] _values_ = new object[1];
      if (!ignore_CMD_AUTOMATICO) _values_[0] = CMD_AUTOMATICO;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_E_COMANDO_MANUAL(System.Int16 CMD_MANUAL, System.Single STP_POSICAO_MANUAL)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {CMD_MANUAL, STP_POSICAO_MANUAL});
    }
    public bool FireEvent_E_COMANDO_MANUAL(Hidryco.HidrycoLib.Symbols.Valvula_Coester.E_COMANDO_MANUALEventArgs ea)
    {
      object[] _values_ = new object[2];
      if (ea.CMD_MANUAL.HasValue) _values_[0] = ea.CMD_MANUAL.Value;
      if (ea.STP_POSICAO_MANUAL.HasValue) _values_[1] = ea.STP_POSICAO_MANUAL.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_E_COMANDO_MANUAL(System.Int16 CMD_MANUAL, bool ignore_CMD_MANUAL, System.Single STP_POSICAO_MANUAL, bool ignore_STP_POSICAO_MANUAL)
    {
      object[] _values_ = new object[2];
      if (!ignore_CMD_MANUAL) _values_[0] = CMD_MANUAL;
      if (!ignore_STP_POSICAO_MANUAL) _values_[1] = STP_POSICAO_MANUAL;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_E_PARAMETROS(System.Int16 STP_TEMPO_FALHA_POSICAO, System.Single STP_TOLERANCIA_POSICAO)
    {
      return ((IHMIAccessorOutput)this).FireEvent(2, new object[] {STP_TEMPO_FALHA_POSICAO, STP_TOLERANCIA_POSICAO});
    }
    public bool FireEvent_E_PARAMETROS(Hidryco.HidrycoLib.Symbols.Valvula_Coester.E_PARAMETROSEventArgs ea)
    {
      object[] _values_ = new object[2];
      if (ea.STP_TEMPO_FALHA_POSICAO.HasValue) _values_[0] = ea.STP_TEMPO_FALHA_POSICAO.Value;
      if (ea.STP_TOLERANCIA_POSICAO.HasValue) _values_[1] = ea.STP_TOLERANCIA_POSICAO.Value;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_E_PARAMETROS(System.Int16 STP_TEMPO_FALHA_POSICAO, bool ignore_STP_TEMPO_FALHA_POSICAO, System.Single STP_TOLERANCIA_POSICAO, bool ignore_STP_TOLERANCIA_POSICAO)
    {
      object[] _values_ = new object[2];
      if (!ignore_STP_TEMPO_FALHA_POSICAO) _values_[0] = STP_TEMPO_FALHA_POSICAO;
      if (!ignore_STP_TOLERANCIA_POSICAO) _values_[1] = STP_TOLERANCIA_POSICAO;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_E_RESET_FALHA(System.Boolean CMD_RESET_FALHA)
    {
      return ((IHMIAccessorOutput)this).FireEvent(3, new object[] {CMD_RESET_FALHA});
    }
    public bool FireEvent_E_RESET_FALHA(Hidryco.HidrycoLib.Symbols.Valvula_Coester.E_RESET_FALHAEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.CMD_RESET_FALHA.HasValue) _values_[0] = ea.CMD_RESET_FALHA.Value;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_E_RESET_FALHA(System.Boolean CMD_RESET_FALHA, bool ignore_CMD_RESET_FALHA)
    {
      object[] _values_ = new object[1];
      if (!ignore_CMD_RESET_FALHA) _values_[0] = CMD_RESET_FALHA;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }

  }
}

namespace Hidryco.HidrycoLib.Faceplates.Valvula_Coester
{
  partial class fpDiagnostico
  {

    private event EventHandler<Hidryco.HidrycoLib.Symbols.Valvula_Coester.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    private event EventHandler<Hidryco.HidrycoLib.Symbols.Valvula_Coester.REQEventArgs> REQ_Fired;

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
              LOAD_PERS_DATA_Fired(this, new Hidryco.HidrycoLib.Symbols.Valvula_Coester.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
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
              REQ_Fired(this, new Hidryco.HidrycoLib.Symbols.Valvula_Coester.REQEventArgs(channelId, cookie, eventIndex));
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
    public bool FireEvent_E_MODO_OPERACAO(System.Boolean CMD_AUTOMATICO)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {CMD_AUTOMATICO});
    }
    public bool FireEvent_E_MODO_OPERACAO(Hidryco.HidrycoLib.Symbols.Valvula_Coester.E_MODO_OPERACAOEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.CMD_AUTOMATICO.HasValue) _values_[0] = ea.CMD_AUTOMATICO.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_E_MODO_OPERACAO(System.Boolean CMD_AUTOMATICO, bool ignore_CMD_AUTOMATICO)
    {
      object[] _values_ = new object[1];
      if (!ignore_CMD_AUTOMATICO) _values_[0] = CMD_AUTOMATICO;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_E_COMANDO_MANUAL(System.Int16 CMD_MANUAL, System.Single STP_POSICAO_MANUAL)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {CMD_MANUAL, STP_POSICAO_MANUAL});
    }
    public bool FireEvent_E_COMANDO_MANUAL(Hidryco.HidrycoLib.Symbols.Valvula_Coester.E_COMANDO_MANUALEventArgs ea)
    {
      object[] _values_ = new object[2];
      if (ea.CMD_MANUAL.HasValue) _values_[0] = ea.CMD_MANUAL.Value;
      if (ea.STP_POSICAO_MANUAL.HasValue) _values_[1] = ea.STP_POSICAO_MANUAL.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_E_COMANDO_MANUAL(System.Int16 CMD_MANUAL, bool ignore_CMD_MANUAL, System.Single STP_POSICAO_MANUAL, bool ignore_STP_POSICAO_MANUAL)
    {
      object[] _values_ = new object[2];
      if (!ignore_CMD_MANUAL) _values_[0] = CMD_MANUAL;
      if (!ignore_STP_POSICAO_MANUAL) _values_[1] = STP_POSICAO_MANUAL;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_E_PARAMETROS(System.Int16 STP_TEMPO_FALHA_POSICAO, System.Single STP_TOLERANCIA_POSICAO)
    {
      return ((IHMIAccessorOutput)this).FireEvent(2, new object[] {STP_TEMPO_FALHA_POSICAO, STP_TOLERANCIA_POSICAO});
    }
    public bool FireEvent_E_PARAMETROS(Hidryco.HidrycoLib.Symbols.Valvula_Coester.E_PARAMETROSEventArgs ea)
    {
      object[] _values_ = new object[2];
      if (ea.STP_TEMPO_FALHA_POSICAO.HasValue) _values_[0] = ea.STP_TEMPO_FALHA_POSICAO.Value;
      if (ea.STP_TOLERANCIA_POSICAO.HasValue) _values_[1] = ea.STP_TOLERANCIA_POSICAO.Value;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_E_PARAMETROS(System.Int16 STP_TEMPO_FALHA_POSICAO, bool ignore_STP_TEMPO_FALHA_POSICAO, System.Single STP_TOLERANCIA_POSICAO, bool ignore_STP_TOLERANCIA_POSICAO)
    {
      object[] _values_ = new object[2];
      if (!ignore_STP_TEMPO_FALHA_POSICAO) _values_[0] = STP_TEMPO_FALHA_POSICAO;
      if (!ignore_STP_TOLERANCIA_POSICAO) _values_[1] = STP_TOLERANCIA_POSICAO;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_E_RESET_FALHA(System.Boolean CMD_RESET_FALHA)
    {
      return ((IHMIAccessorOutput)this).FireEvent(3, new object[] {CMD_RESET_FALHA});
    }
    public bool FireEvent_E_RESET_FALHA(Hidryco.HidrycoLib.Symbols.Valvula_Coester.E_RESET_FALHAEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.CMD_RESET_FALHA.HasValue) _values_[0] = ea.CMD_RESET_FALHA.Value;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_E_RESET_FALHA(System.Boolean CMD_RESET_FALHA, bool ignore_CMD_RESET_FALHA)
    {
      object[] _values_ = new object[1];
      if (!ignore_CMD_RESET_FALHA) _values_[0] = CMD_RESET_FALHA;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }

  }
}

#endregion #Valvula_Coester_HMI;

#endregion Definitions;
