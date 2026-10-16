/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 10/16/2026
 * Time: 11:30 AM
 * 
 */
using System;
using NxtControl.GuiFramework;
using NxtControl.Services;

#region Definitions;
#region #UCT_PreTratamento_HMI;

namespace Hidryco.HidrycoLib.Symbols.UCT_PreTratamento
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
    public bool Get_STS_EMERGENCIA(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,0, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_EMERGENCIA
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,0, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_NIVEL_BAIXO_PENEIRA(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,1, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_NIVEL_BAIXO_PENEIRA
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,1, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_NIVEL_ALTO_PENEIRA(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,2, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_NIVEL_ALTO_PENEIRA
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,2, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_NIVEL_BAIXO_TANQUE_AGUA(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,3, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_NIVEL_BAIXO_TANQUE_AGUA
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,3, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_NIVEL_ALTO_TANQUE_GORDURA(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,4, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_NIVEL_ALTO_TANQUE_GORDURA
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,4, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_NIVEL_PENEIRA(ref System.Single value)
    {
      if (accessorService == null)
        return false;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,5, ref var);
      if (ret) value = (System.Single) var;
      return ret;
    }

    public System.Single? STS_NIVEL_PENEIRA
    { get {
      if (accessorService == null)
        return null;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,5, ref var);
      if (!ret) return null;
      return (System.Single) var;
    }  }

    public bool Get_STS_FALHA_COMUNICACAO(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,6, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_FALHA_COMUNICACAO
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,6, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_DISPONIVEL(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,7, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_DISPONIVEL
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,7, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_HABILITADA(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,8, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_HABILITADA
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,8, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_BLOQUEIO_EEE(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,9, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_BLOQUEIO_EEE
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,9, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_ALARME(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,10, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_ALARME
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,10, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_AUTOMATICO_PENEIRA(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,11, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_AUTOMATICO_PENEIRA
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,11, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_AUTOMATICO_ROSCAS(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,12, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_AUTOMATICO_ROSCAS
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,12, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_AUTOMATICO_RASPCOMP(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,13, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_AUTOMATICO_RASPCOMP
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,13, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_LIGA_AUTOMATICO_PENEIRA(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,14, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_LIGA_AUTOMATICO_PENEIRA
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,14, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_LIGA_AUTOMATICO_ROSCAS(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,15, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_LIGA_AUTOMATICO_ROSCAS
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,15, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_LIGA_AUTOMATICO_RASPCOMP(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,16, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_LIGA_AUTOMATICO_RASPCOMP
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,16, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_SELECAO_BOMBA(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,17, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_SELECAO_BOMBA
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,17, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_VALVULA_LAVAGEM(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,18, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_VALVULA_LAVAGEM
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,18, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_ETAPA_GORDURA(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,19, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? STS_ETAPA_GORDURA
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,19, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }

    public bool Get_STS_TEMPO_RESTANTE(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,20, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? STS_TEMPO_RESTANTE
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,20, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }

    public bool Get_STS_ALARME_COM(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,21, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_ALARME_COM
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,21, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_ALARME_EMERGENCIA(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,22, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_ALARME_EMERGENCIA
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,22, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_ALARME_DEFPEN(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,23, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_ALARME_DEFPEN
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,23, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_ALARME_DEFB1(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,24, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_ALARME_DEFB1
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,24, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_ALARME_DEFB2(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,25, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_ALARME_DEFB2
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,25, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_ALARME_DEFCMP(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,26, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_ALARME_DEFCMP
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,26, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_ALARME_DEFRSP(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,27, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_ALARME_DEFRSP
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,27, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_ALARME_DEFR1(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,28, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_ALARME_DEFR1
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,28, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_ALARME_DEFR2(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,29, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_ALARME_DEFR2
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,29, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_ALARME_NIVELAGUA(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,30, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_ALARME_NIVELAGUA
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,30, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_ALARME_NIVELPENEIRA(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,31, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_ALARME_NIVELPENEIRA
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,31, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_ALM_COM_EST(ref System.Byte value)
    {
      if (accessorService == null)
        return false;
      byte var = 0;
      bool ret = accessorService.GetByteValue(channelId, cookie, eventIndex, true,32, ref var);
      if (ret) value = (System.Byte) var;
      return ret;
    }

    public System.Byte? STS_ALM_COM_EST
    { get {
      if (accessorService == null)
        return null;
      byte var = 0;
      bool ret = accessorService.GetByteValue(channelId, cookie, eventIndex, true,32, ref var);
      if (!ret) return null;
      return (System.Byte) var;
    }  }

    public bool Get_STS_ALM_EMERGENCIA_EST(ref System.Byte value)
    {
      if (accessorService == null)
        return false;
      byte var = 0;
      bool ret = accessorService.GetByteValue(channelId, cookie, eventIndex, true,33, ref var);
      if (ret) value = (System.Byte) var;
      return ret;
    }

    public System.Byte? STS_ALM_EMERGENCIA_EST
    { get {
      if (accessorService == null)
        return null;
      byte var = 0;
      bool ret = accessorService.GetByteValue(channelId, cookie, eventIndex, true,33, ref var);
      if (!ret) return null;
      return (System.Byte) var;
    }  }

    public bool Get_STS_ALM_DEFPEN_EST(ref System.Byte value)
    {
      if (accessorService == null)
        return false;
      byte var = 0;
      bool ret = accessorService.GetByteValue(channelId, cookie, eventIndex, true,34, ref var);
      if (ret) value = (System.Byte) var;
      return ret;
    }

    public System.Byte? STS_ALM_DEFPEN_EST
    { get {
      if (accessorService == null)
        return null;
      byte var = 0;
      bool ret = accessorService.GetByteValue(channelId, cookie, eventIndex, true,34, ref var);
      if (!ret) return null;
      return (System.Byte) var;
    }  }

    public bool Get_STS_ALM_DEFB1_EST(ref System.Byte value)
    {
      if (accessorService == null)
        return false;
      byte var = 0;
      bool ret = accessorService.GetByteValue(channelId, cookie, eventIndex, true,35, ref var);
      if (ret) value = (System.Byte) var;
      return ret;
    }

    public System.Byte? STS_ALM_DEFB1_EST
    { get {
      if (accessorService == null)
        return null;
      byte var = 0;
      bool ret = accessorService.GetByteValue(channelId, cookie, eventIndex, true,35, ref var);
      if (!ret) return null;
      return (System.Byte) var;
    }  }

    public bool Get_STS_ALM_DEFB2_EST(ref System.Byte value)
    {
      if (accessorService == null)
        return false;
      byte var = 0;
      bool ret = accessorService.GetByteValue(channelId, cookie, eventIndex, true,36, ref var);
      if (ret) value = (System.Byte) var;
      return ret;
    }

    public System.Byte? STS_ALM_DEFB2_EST
    { get {
      if (accessorService == null)
        return null;
      byte var = 0;
      bool ret = accessorService.GetByteValue(channelId, cookie, eventIndex, true,36, ref var);
      if (!ret) return null;
      return (System.Byte) var;
    }  }

    public bool Get_STS_ALM_DEFCMP_EST(ref System.Byte value)
    {
      if (accessorService == null)
        return false;
      byte var = 0;
      bool ret = accessorService.GetByteValue(channelId, cookie, eventIndex, true,37, ref var);
      if (ret) value = (System.Byte) var;
      return ret;
    }

    public System.Byte? STS_ALM_DEFCMP_EST
    { get {
      if (accessorService == null)
        return null;
      byte var = 0;
      bool ret = accessorService.GetByteValue(channelId, cookie, eventIndex, true,37, ref var);
      if (!ret) return null;
      return (System.Byte) var;
    }  }

    public bool Get_STS_ALM_DEFRSP_EST(ref System.Byte value)
    {
      if (accessorService == null)
        return false;
      byte var = 0;
      bool ret = accessorService.GetByteValue(channelId, cookie, eventIndex, true,38, ref var);
      if (ret) value = (System.Byte) var;
      return ret;
    }

    public System.Byte? STS_ALM_DEFRSP_EST
    { get {
      if (accessorService == null)
        return null;
      byte var = 0;
      bool ret = accessorService.GetByteValue(channelId, cookie, eventIndex, true,38, ref var);
      if (!ret) return null;
      return (System.Byte) var;
    }  }

    public bool Get_STS_ALM_DEFR1_EST(ref System.Byte value)
    {
      if (accessorService == null)
        return false;
      byte var = 0;
      bool ret = accessorService.GetByteValue(channelId, cookie, eventIndex, true,39, ref var);
      if (ret) value = (System.Byte) var;
      return ret;
    }

    public System.Byte? STS_ALM_DEFR1_EST
    { get {
      if (accessorService == null)
        return null;
      byte var = 0;
      bool ret = accessorService.GetByteValue(channelId, cookie, eventIndex, true,39, ref var);
      if (!ret) return null;
      return (System.Byte) var;
    }  }

    public bool Get_STS_ALM_DEFR2_EST(ref System.Byte value)
    {
      if (accessorService == null)
        return false;
      byte var = 0;
      bool ret = accessorService.GetByteValue(channelId, cookie, eventIndex, true,40, ref var);
      if (ret) value = (System.Byte) var;
      return ret;
    }

    public System.Byte? STS_ALM_DEFR2_EST
    { get {
      if (accessorService == null)
        return null;
      byte var = 0;
      bool ret = accessorService.GetByteValue(channelId, cookie, eventIndex, true,40, ref var);
      if (!ret) return null;
      return (System.Byte) var;
    }  }

    public bool Get_STS_ALM_NIVELAGUA_EST(ref System.Byte value)
    {
      if (accessorService == null)
        return false;
      byte var = 0;
      bool ret = accessorService.GetByteValue(channelId, cookie, eventIndex, true,41, ref var);
      if (ret) value = (System.Byte) var;
      return ret;
    }

    public System.Byte? STS_ALM_NIVELAGUA_EST
    { get {
      if (accessorService == null)
        return null;
      byte var = 0;
      bool ret = accessorService.GetByteValue(channelId, cookie, eventIndex, true,41, ref var);
      if (!ret) return null;
      return (System.Byte) var;
    }  }

    public bool Get_STS_ALM_NIVELPENEIRA_EST(ref System.Byte value)
    {
      if (accessorService == null)
        return false;
      byte var = 0;
      bool ret = accessorService.GetByteValue(channelId, cookie, eventIndex, true,42, ref var);
      if (ret) value = (System.Byte) var;
      return ret;
    }

    public System.Byte? STS_ALM_NIVELPENEIRA_EST
    { get {
      if (accessorService == null)
        return null;
      byte var = 0;
      bool ret = accessorService.GetByteValue(channelId, cookie, eventIndex, true,42, ref var);
      if (!ret) return null;
      return (System.Byte) var;
    }  }


  }

}

namespace Hidryco.HidrycoLib.Symbols.UCT_PreTratamento
{

  public class E_LIGA_SUBSISTEMA_PENEIRAEventArgs : System.EventArgs
  {
    public E_LIGA_SUBSISTEMA_PENEIRAEventArgs()
    {
    }
    private System.Boolean? cmdLigaSubsistemaPeneira_field = null;
    public System.Boolean? cmdLigaSubsistemaPeneira
    {
       get { return cmdLigaSubsistemaPeneira_field; }
       set { cmdLigaSubsistemaPeneira_field = value; }
    }

  }

  public class E_SELECAO_SUBSISTEMA_PENEIRAEventArgs : System.EventArgs
  {
    public E_SELECAO_SUBSISTEMA_PENEIRAEventArgs()
    {
    }
    private System.Boolean? cmdSelecaoSubsistemaPeneira_field = null;
    public System.Boolean? cmdSelecaoSubsistemaPeneira
    {
       get { return cmdSelecaoSubsistemaPeneira_field; }
       set { cmdSelecaoSubsistemaPeneira_field = value; }
    }

  }

  public class E_LIGA_SUBSISTEMA_ROSCASEventArgs : System.EventArgs
  {
    public E_LIGA_SUBSISTEMA_ROSCASEventArgs()
    {
    }
    private System.Boolean? cmdLigaSubsistemaRoscas_field = null;
    public System.Boolean? cmdLigaSubsistemaRoscas
    {
       get { return cmdLigaSubsistemaRoscas_field; }
       set { cmdLigaSubsistemaRoscas_field = value; }
    }

  }

  public class E_SELECAO_SUBSISTEMA_ROSCASEventArgs : System.EventArgs
  {
    public E_SELECAO_SUBSISTEMA_ROSCASEventArgs()
    {
    }
    private System.Boolean? cmdSelecaoSubsistemaRoscas_field = null;
    public System.Boolean? cmdSelecaoSubsistemaRoscas
    {
       get { return cmdSelecaoSubsistemaRoscas_field; }
       set { cmdSelecaoSubsistemaRoscas_field = value; }
    }

  }

  public class E_LIGA_SUBSISTEMA_RASPCOMPEventArgs : System.EventArgs
  {
    public E_LIGA_SUBSISTEMA_RASPCOMPEventArgs()
    {
    }
    private System.Boolean? cmdLigaSubsistemaRaspComp_field = null;
    public System.Boolean? cmdLigaSubsistemaRaspComp
    {
       get { return cmdLigaSubsistemaRaspComp_field; }
       set { cmdLigaSubsistemaRaspComp_field = value; }
    }

  }

  public class E_SELECAO_SUBSISTEMA_RASPCOMPEventArgs : System.EventArgs
  {
    public E_SELECAO_SUBSISTEMA_RASPCOMPEventArgs()
    {
    }
    private System.Boolean? cmdSelecaoSubsistemaRaspComp_field = null;
    public System.Boolean? cmdSelecaoSubsistemaRaspComp
    {
       get { return cmdSelecaoSubsistemaRaspComp_field; }
       set { cmdSelecaoSubsistemaRaspComp_field = value; }
    }

  }

  public class E_SELECAO_BOMBA_HIGIENIZACAOEventArgs : System.EventArgs
  {
    public E_SELECAO_BOMBA_HIGIENIZACAOEventArgs()
    {
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

  public class E_VALVULA_LAVAGEMEventArgs : System.EventArgs
  {
    public E_VALVULA_LAVAGEMEventArgs()
    {
    }
    private System.Boolean? CMD_VALVULA_LAVAGEM_field = null;
    public System.Boolean? CMD_VALVULA_LAVAGEM
    {
       get { return CMD_VALVULA_LAVAGEM_field; }
       set { CMD_VALVULA_LAVAGEM_field = value; }
    }

  }

  public class E_PARAMETROSEventArgs : System.EventArgs
  {
    public E_PARAMETROSEventArgs()
    {
    }
    private System.Boolean? STP_HABILITADA_field = null;
    public System.Boolean? STP_HABILITADA
    {
       get { return STP_HABILITADA_field; }
       set { STP_HABILITADA_field = value; }
    }
    private System.UInt16? STP_TEMPO_PRE_LAVAGEM_field = null;
    public System.UInt16? STP_TEMPO_PRE_LAVAGEM
    {
       get { return STP_TEMPO_PRE_LAVAGEM_field; }
       set { STP_TEMPO_PRE_LAVAGEM_field = value; }
    }
    private System.UInt16? STP_TEMPO_VALVULA_APOS_PARTIDA_field = null;
    public System.UInt16? STP_TEMPO_VALVULA_APOS_PARTIDA
    {
       get { return STP_TEMPO_VALVULA_APOS_PARTIDA_field; }
       set { STP_TEMPO_VALVULA_APOS_PARTIDA_field = value; }
    }
    private System.UInt16? STP_TEMPO_DESLIGA_BOMBA_field = null;
    public System.UInt16? STP_TEMPO_DESLIGA_BOMBA
    {
       get { return STP_TEMPO_DESLIGA_BOMBA_field; }
       set { STP_TEMPO_DESLIGA_BOMBA_field = value; }
    }
    private System.Single? STP_VELOCIDADE_BOMBA_GORDURA_field = null;
    public System.Single? STP_VELOCIDADE_BOMBA_GORDURA
    {
       get { return STP_VELOCIDADE_BOMBA_GORDURA_field; }
       set { STP_VELOCIDADE_BOMBA_GORDURA_field = value; }
    }

  }

}

namespace Hidryco.HidrycoLib.Symbols.UCT_PreTratamento
{
  partial class sDefault
  {

    private event EventHandler<Hidryco.HidrycoLib.Symbols.UCT_PreTratamento.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    private event EventHandler<Hidryco.HidrycoLib.Symbols.UCT_PreTratamento.REQEventArgs> REQ_Fired;

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
              LOAD_PERS_DATA_Fired(this, new Hidryco.HidrycoLib.Symbols.UCT_PreTratamento.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
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
              REQ_Fired(this, new Hidryco.HidrycoLib.Symbols.UCT_PreTratamento.REQEventArgs(channelId, cookie, eventIndex));
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
    public bool FireEvent_E_LIGA_SUBSISTEMA_PENEIRA(System.Boolean cmdLigaSubsistemaPeneira)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {cmdLigaSubsistemaPeneira});
    }
    public bool FireEvent_E_LIGA_SUBSISTEMA_PENEIRA(Hidryco.HidrycoLib.Symbols.UCT_PreTratamento.E_LIGA_SUBSISTEMA_PENEIRAEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.cmdLigaSubsistemaPeneira.HasValue) _values_[0] = ea.cmdLigaSubsistemaPeneira.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_E_LIGA_SUBSISTEMA_PENEIRA(System.Boolean cmdLigaSubsistemaPeneira, bool ignore_cmdLigaSubsistemaPeneira)
    {
      object[] _values_ = new object[1];
      if (!ignore_cmdLigaSubsistemaPeneira) _values_[0] = cmdLigaSubsistemaPeneira;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_E_SELECAO_SUBSISTEMA_PENEIRA(System.Boolean cmdSelecaoSubsistemaPeneira)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {cmdSelecaoSubsistemaPeneira});
    }
    public bool FireEvent_E_SELECAO_SUBSISTEMA_PENEIRA(Hidryco.HidrycoLib.Symbols.UCT_PreTratamento.E_SELECAO_SUBSISTEMA_PENEIRAEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.cmdSelecaoSubsistemaPeneira.HasValue) _values_[0] = ea.cmdSelecaoSubsistemaPeneira.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_E_SELECAO_SUBSISTEMA_PENEIRA(System.Boolean cmdSelecaoSubsistemaPeneira, bool ignore_cmdSelecaoSubsistemaPeneira)
    {
      object[] _values_ = new object[1];
      if (!ignore_cmdSelecaoSubsistemaPeneira) _values_[0] = cmdSelecaoSubsistemaPeneira;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_E_LIGA_SUBSISTEMA_ROSCAS(System.Boolean cmdLigaSubsistemaRoscas)
    {
      return ((IHMIAccessorOutput)this).FireEvent(2, new object[] {cmdLigaSubsistemaRoscas});
    }
    public bool FireEvent_E_LIGA_SUBSISTEMA_ROSCAS(Hidryco.HidrycoLib.Symbols.UCT_PreTratamento.E_LIGA_SUBSISTEMA_ROSCASEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.cmdLigaSubsistemaRoscas.HasValue) _values_[0] = ea.cmdLigaSubsistemaRoscas.Value;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_E_LIGA_SUBSISTEMA_ROSCAS(System.Boolean cmdLigaSubsistemaRoscas, bool ignore_cmdLigaSubsistemaRoscas)
    {
      object[] _values_ = new object[1];
      if (!ignore_cmdLigaSubsistemaRoscas) _values_[0] = cmdLigaSubsistemaRoscas;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_E_SELECAO_SUBSISTEMA_ROSCAS(System.Boolean cmdSelecaoSubsistemaRoscas)
    {
      return ((IHMIAccessorOutput)this).FireEvent(3, new object[] {cmdSelecaoSubsistemaRoscas});
    }
    public bool FireEvent_E_SELECAO_SUBSISTEMA_ROSCAS(Hidryco.HidrycoLib.Symbols.UCT_PreTratamento.E_SELECAO_SUBSISTEMA_ROSCASEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.cmdSelecaoSubsistemaRoscas.HasValue) _values_[0] = ea.cmdSelecaoSubsistemaRoscas.Value;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_E_SELECAO_SUBSISTEMA_ROSCAS(System.Boolean cmdSelecaoSubsistemaRoscas, bool ignore_cmdSelecaoSubsistemaRoscas)
    {
      object[] _values_ = new object[1];
      if (!ignore_cmdSelecaoSubsistemaRoscas) _values_[0] = cmdSelecaoSubsistemaRoscas;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_E_LIGA_SUBSISTEMA_RASPCOMP(System.Boolean cmdLigaSubsistemaRaspComp)
    {
      return ((IHMIAccessorOutput)this).FireEvent(4, new object[] {cmdLigaSubsistemaRaspComp});
    }
    public bool FireEvent_E_LIGA_SUBSISTEMA_RASPCOMP(Hidryco.HidrycoLib.Symbols.UCT_PreTratamento.E_LIGA_SUBSISTEMA_RASPCOMPEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.cmdLigaSubsistemaRaspComp.HasValue) _values_[0] = ea.cmdLigaSubsistemaRaspComp.Value;
      return ((IHMIAccessorOutput)this).FireEvent(4, _values_);
    }
    public bool FireEvent_E_LIGA_SUBSISTEMA_RASPCOMP(System.Boolean cmdLigaSubsistemaRaspComp, bool ignore_cmdLigaSubsistemaRaspComp)
    {
      object[] _values_ = new object[1];
      if (!ignore_cmdLigaSubsistemaRaspComp) _values_[0] = cmdLigaSubsistemaRaspComp;
      return ((IHMIAccessorOutput)this).FireEvent(4, _values_);
    }
    public bool FireEvent_E_SELECAO_SUBSISTEMA_RASPCOMP(System.Boolean cmdSelecaoSubsistemaRaspComp)
    {
      return ((IHMIAccessorOutput)this).FireEvent(5, new object[] {cmdSelecaoSubsistemaRaspComp});
    }
    public bool FireEvent_E_SELECAO_SUBSISTEMA_RASPCOMP(Hidryco.HidrycoLib.Symbols.UCT_PreTratamento.E_SELECAO_SUBSISTEMA_RASPCOMPEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.cmdSelecaoSubsistemaRaspComp.HasValue) _values_[0] = ea.cmdSelecaoSubsistemaRaspComp.Value;
      return ((IHMIAccessorOutput)this).FireEvent(5, _values_);
    }
    public bool FireEvent_E_SELECAO_SUBSISTEMA_RASPCOMP(System.Boolean cmdSelecaoSubsistemaRaspComp, bool ignore_cmdSelecaoSubsistemaRaspComp)
    {
      object[] _values_ = new object[1];
      if (!ignore_cmdSelecaoSubsistemaRaspComp) _values_[0] = cmdSelecaoSubsistemaRaspComp;
      return ((IHMIAccessorOutput)this).FireEvent(5, _values_);
    }
    public bool FireEvent_E_SELECAO_BOMBA_HIGIENIZACAO(System.Boolean cmdSelecaoBombaHigienizacao)
    {
      return ((IHMIAccessorOutput)this).FireEvent(6, new object[] {cmdSelecaoBombaHigienizacao});
    }
    public bool FireEvent_E_SELECAO_BOMBA_HIGIENIZACAO(Hidryco.HidrycoLib.Symbols.UCT_PreTratamento.E_SELECAO_BOMBA_HIGIENIZACAOEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.cmdSelecaoBombaHigienizacao.HasValue) _values_[0] = ea.cmdSelecaoBombaHigienizacao.Value;
      return ((IHMIAccessorOutput)this).FireEvent(6, _values_);
    }
    public bool FireEvent_E_SELECAO_BOMBA_HIGIENIZACAO(System.Boolean cmdSelecaoBombaHigienizacao, bool ignore_cmdSelecaoBombaHigienizacao)
    {
      object[] _values_ = new object[1];
      if (!ignore_cmdSelecaoBombaHigienizacao) _values_[0] = cmdSelecaoBombaHigienizacao;
      return ((IHMIAccessorOutput)this).FireEvent(6, _values_);
    }
    public bool FireEvent_E_RESET_FALHA(System.Boolean cmdResetFalha)
    {
      return ((IHMIAccessorOutput)this).FireEvent(7, new object[] {cmdResetFalha});
    }
    public bool FireEvent_E_RESET_FALHA(Hidryco.HidrycoLib.Symbols.UCT_PreTratamento.E_RESET_FALHAEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.cmdResetFalha.HasValue) _values_[0] = ea.cmdResetFalha.Value;
      return ((IHMIAccessorOutput)this).FireEvent(7, _values_);
    }
    public bool FireEvent_E_RESET_FALHA(System.Boolean cmdResetFalha, bool ignore_cmdResetFalha)
    {
      object[] _values_ = new object[1];
      if (!ignore_cmdResetFalha) _values_[0] = cmdResetFalha;
      return ((IHMIAccessorOutput)this).FireEvent(7, _values_);
    }
    public bool FireEvent_E_VALVULA_LAVAGEM(System.Boolean CMD_VALVULA_LAVAGEM)
    {
      return ((IHMIAccessorOutput)this).FireEvent(8, new object[] {CMD_VALVULA_LAVAGEM});
    }
    public bool FireEvent_E_VALVULA_LAVAGEM(Hidryco.HidrycoLib.Symbols.UCT_PreTratamento.E_VALVULA_LAVAGEMEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.CMD_VALVULA_LAVAGEM.HasValue) _values_[0] = ea.CMD_VALVULA_LAVAGEM.Value;
      return ((IHMIAccessorOutput)this).FireEvent(8, _values_);
    }
    public bool FireEvent_E_VALVULA_LAVAGEM(System.Boolean CMD_VALVULA_LAVAGEM, bool ignore_CMD_VALVULA_LAVAGEM)
    {
      object[] _values_ = new object[1];
      if (!ignore_CMD_VALVULA_LAVAGEM) _values_[0] = CMD_VALVULA_LAVAGEM;
      return ((IHMIAccessorOutput)this).FireEvent(8, _values_);
    }
    public bool FireEvent_E_PARAMETROS(System.Boolean STP_HABILITADA, System.UInt16 STP_TEMPO_PRE_LAVAGEM, System.UInt16 STP_TEMPO_VALVULA_APOS_PARTIDA, System.UInt16 STP_TEMPO_DESLIGA_BOMBA, System.Single STP_VELOCIDADE_BOMBA_GORDURA)
    {
      return ((IHMIAccessorOutput)this).FireEvent(9, new object[] {STP_HABILITADA, STP_TEMPO_PRE_LAVAGEM, STP_TEMPO_VALVULA_APOS_PARTIDA, STP_TEMPO_DESLIGA_BOMBA, STP_VELOCIDADE_BOMBA_GORDURA});
    }
    public bool FireEvent_E_PARAMETROS(Hidryco.HidrycoLib.Symbols.UCT_PreTratamento.E_PARAMETROSEventArgs ea)
    {
      object[] _values_ = new object[5];
      if (ea.STP_HABILITADA.HasValue) _values_[0] = ea.STP_HABILITADA.Value;
      if (ea.STP_TEMPO_PRE_LAVAGEM.HasValue) _values_[1] = ea.STP_TEMPO_PRE_LAVAGEM.Value;
      if (ea.STP_TEMPO_VALVULA_APOS_PARTIDA.HasValue) _values_[2] = ea.STP_TEMPO_VALVULA_APOS_PARTIDA.Value;
      if (ea.STP_TEMPO_DESLIGA_BOMBA.HasValue) _values_[3] = ea.STP_TEMPO_DESLIGA_BOMBA.Value;
      if (ea.STP_VELOCIDADE_BOMBA_GORDURA.HasValue) _values_[4] = ea.STP_VELOCIDADE_BOMBA_GORDURA.Value;
      return ((IHMIAccessorOutput)this).FireEvent(9, _values_);
    }
    public bool FireEvent_E_PARAMETROS(System.Boolean STP_HABILITADA, bool ignore_STP_HABILITADA, System.UInt16 STP_TEMPO_PRE_LAVAGEM, bool ignore_STP_TEMPO_PRE_LAVAGEM, System.UInt16 STP_TEMPO_VALVULA_APOS_PARTIDA, bool ignore_STP_TEMPO_VALVULA_APOS_PARTIDA, System.UInt16 STP_TEMPO_DESLIGA_BOMBA, bool ignore_STP_TEMPO_DESLIGA_BOMBA, System.Single STP_VELOCIDADE_BOMBA_GORDURA, bool ignore_STP_VELOCIDADE_BOMBA_GORDURA)
    {
      object[] _values_ = new object[5];
      if (!ignore_STP_HABILITADA) _values_[0] = STP_HABILITADA;
      if (!ignore_STP_TEMPO_PRE_LAVAGEM) _values_[1] = STP_TEMPO_PRE_LAVAGEM;
      if (!ignore_STP_TEMPO_VALVULA_APOS_PARTIDA) _values_[2] = STP_TEMPO_VALVULA_APOS_PARTIDA;
      if (!ignore_STP_TEMPO_DESLIGA_BOMBA) _values_[3] = STP_TEMPO_DESLIGA_BOMBA;
      if (!ignore_STP_VELOCIDADE_BOMBA_GORDURA) _values_[4] = STP_VELOCIDADE_BOMBA_GORDURA;
      return ((IHMIAccessorOutput)this).FireEvent(9, _values_);
    }

  }
}

namespace Hidryco.HidrycoLib.Faceplates.UCT_PreTratamento
{
  partial class fpDefault
  {

    private event EventHandler<Hidryco.HidrycoLib.Symbols.UCT_PreTratamento.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    private event EventHandler<Hidryco.HidrycoLib.Symbols.UCT_PreTratamento.REQEventArgs> REQ_Fired;

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
              LOAD_PERS_DATA_Fired(this, new Hidryco.HidrycoLib.Symbols.UCT_PreTratamento.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
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
              REQ_Fired(this, new Hidryco.HidrycoLib.Symbols.UCT_PreTratamento.REQEventArgs(channelId, cookie, eventIndex));
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
    public bool FireEvent_E_LIGA_SUBSISTEMA_PENEIRA(System.Boolean cmdLigaSubsistemaPeneira)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {cmdLigaSubsistemaPeneira});
    }
    public bool FireEvent_E_LIGA_SUBSISTEMA_PENEIRA(Hidryco.HidrycoLib.Symbols.UCT_PreTratamento.E_LIGA_SUBSISTEMA_PENEIRAEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.cmdLigaSubsistemaPeneira.HasValue) _values_[0] = ea.cmdLigaSubsistemaPeneira.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_E_LIGA_SUBSISTEMA_PENEIRA(System.Boolean cmdLigaSubsistemaPeneira, bool ignore_cmdLigaSubsistemaPeneira)
    {
      object[] _values_ = new object[1];
      if (!ignore_cmdLigaSubsistemaPeneira) _values_[0] = cmdLigaSubsistemaPeneira;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_E_SELECAO_SUBSISTEMA_PENEIRA(System.Boolean cmdSelecaoSubsistemaPeneira)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {cmdSelecaoSubsistemaPeneira});
    }
    public bool FireEvent_E_SELECAO_SUBSISTEMA_PENEIRA(Hidryco.HidrycoLib.Symbols.UCT_PreTratamento.E_SELECAO_SUBSISTEMA_PENEIRAEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.cmdSelecaoSubsistemaPeneira.HasValue) _values_[0] = ea.cmdSelecaoSubsistemaPeneira.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_E_SELECAO_SUBSISTEMA_PENEIRA(System.Boolean cmdSelecaoSubsistemaPeneira, bool ignore_cmdSelecaoSubsistemaPeneira)
    {
      object[] _values_ = new object[1];
      if (!ignore_cmdSelecaoSubsistemaPeneira) _values_[0] = cmdSelecaoSubsistemaPeneira;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_E_LIGA_SUBSISTEMA_ROSCAS(System.Boolean cmdLigaSubsistemaRoscas)
    {
      return ((IHMIAccessorOutput)this).FireEvent(2, new object[] {cmdLigaSubsistemaRoscas});
    }
    public bool FireEvent_E_LIGA_SUBSISTEMA_ROSCAS(Hidryco.HidrycoLib.Symbols.UCT_PreTratamento.E_LIGA_SUBSISTEMA_ROSCASEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.cmdLigaSubsistemaRoscas.HasValue) _values_[0] = ea.cmdLigaSubsistemaRoscas.Value;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_E_LIGA_SUBSISTEMA_ROSCAS(System.Boolean cmdLigaSubsistemaRoscas, bool ignore_cmdLigaSubsistemaRoscas)
    {
      object[] _values_ = new object[1];
      if (!ignore_cmdLigaSubsistemaRoscas) _values_[0] = cmdLigaSubsistemaRoscas;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_E_SELECAO_SUBSISTEMA_ROSCAS(System.Boolean cmdSelecaoSubsistemaRoscas)
    {
      return ((IHMIAccessorOutput)this).FireEvent(3, new object[] {cmdSelecaoSubsistemaRoscas});
    }
    public bool FireEvent_E_SELECAO_SUBSISTEMA_ROSCAS(Hidryco.HidrycoLib.Symbols.UCT_PreTratamento.E_SELECAO_SUBSISTEMA_ROSCASEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.cmdSelecaoSubsistemaRoscas.HasValue) _values_[0] = ea.cmdSelecaoSubsistemaRoscas.Value;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_E_SELECAO_SUBSISTEMA_ROSCAS(System.Boolean cmdSelecaoSubsistemaRoscas, bool ignore_cmdSelecaoSubsistemaRoscas)
    {
      object[] _values_ = new object[1];
      if (!ignore_cmdSelecaoSubsistemaRoscas) _values_[0] = cmdSelecaoSubsistemaRoscas;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_E_LIGA_SUBSISTEMA_RASPCOMP(System.Boolean cmdLigaSubsistemaRaspComp)
    {
      return ((IHMIAccessorOutput)this).FireEvent(4, new object[] {cmdLigaSubsistemaRaspComp});
    }
    public bool FireEvent_E_LIGA_SUBSISTEMA_RASPCOMP(Hidryco.HidrycoLib.Symbols.UCT_PreTratamento.E_LIGA_SUBSISTEMA_RASPCOMPEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.cmdLigaSubsistemaRaspComp.HasValue) _values_[0] = ea.cmdLigaSubsistemaRaspComp.Value;
      return ((IHMIAccessorOutput)this).FireEvent(4, _values_);
    }
    public bool FireEvent_E_LIGA_SUBSISTEMA_RASPCOMP(System.Boolean cmdLigaSubsistemaRaspComp, bool ignore_cmdLigaSubsistemaRaspComp)
    {
      object[] _values_ = new object[1];
      if (!ignore_cmdLigaSubsistemaRaspComp) _values_[0] = cmdLigaSubsistemaRaspComp;
      return ((IHMIAccessorOutput)this).FireEvent(4, _values_);
    }
    public bool FireEvent_E_SELECAO_SUBSISTEMA_RASPCOMP(System.Boolean cmdSelecaoSubsistemaRaspComp)
    {
      return ((IHMIAccessorOutput)this).FireEvent(5, new object[] {cmdSelecaoSubsistemaRaspComp});
    }
    public bool FireEvent_E_SELECAO_SUBSISTEMA_RASPCOMP(Hidryco.HidrycoLib.Symbols.UCT_PreTratamento.E_SELECAO_SUBSISTEMA_RASPCOMPEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.cmdSelecaoSubsistemaRaspComp.HasValue) _values_[0] = ea.cmdSelecaoSubsistemaRaspComp.Value;
      return ((IHMIAccessorOutput)this).FireEvent(5, _values_);
    }
    public bool FireEvent_E_SELECAO_SUBSISTEMA_RASPCOMP(System.Boolean cmdSelecaoSubsistemaRaspComp, bool ignore_cmdSelecaoSubsistemaRaspComp)
    {
      object[] _values_ = new object[1];
      if (!ignore_cmdSelecaoSubsistemaRaspComp) _values_[0] = cmdSelecaoSubsistemaRaspComp;
      return ((IHMIAccessorOutput)this).FireEvent(5, _values_);
    }
    public bool FireEvent_E_SELECAO_BOMBA_HIGIENIZACAO(System.Boolean cmdSelecaoBombaHigienizacao)
    {
      return ((IHMIAccessorOutput)this).FireEvent(6, new object[] {cmdSelecaoBombaHigienizacao});
    }
    public bool FireEvent_E_SELECAO_BOMBA_HIGIENIZACAO(Hidryco.HidrycoLib.Symbols.UCT_PreTratamento.E_SELECAO_BOMBA_HIGIENIZACAOEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.cmdSelecaoBombaHigienizacao.HasValue) _values_[0] = ea.cmdSelecaoBombaHigienizacao.Value;
      return ((IHMIAccessorOutput)this).FireEvent(6, _values_);
    }
    public bool FireEvent_E_SELECAO_BOMBA_HIGIENIZACAO(System.Boolean cmdSelecaoBombaHigienizacao, bool ignore_cmdSelecaoBombaHigienizacao)
    {
      object[] _values_ = new object[1];
      if (!ignore_cmdSelecaoBombaHigienizacao) _values_[0] = cmdSelecaoBombaHigienizacao;
      return ((IHMIAccessorOutput)this).FireEvent(6, _values_);
    }
    public bool FireEvent_E_RESET_FALHA(System.Boolean cmdResetFalha)
    {
      return ((IHMIAccessorOutput)this).FireEvent(7, new object[] {cmdResetFalha});
    }
    public bool FireEvent_E_RESET_FALHA(Hidryco.HidrycoLib.Symbols.UCT_PreTratamento.E_RESET_FALHAEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.cmdResetFalha.HasValue) _values_[0] = ea.cmdResetFalha.Value;
      return ((IHMIAccessorOutput)this).FireEvent(7, _values_);
    }
    public bool FireEvent_E_RESET_FALHA(System.Boolean cmdResetFalha, bool ignore_cmdResetFalha)
    {
      object[] _values_ = new object[1];
      if (!ignore_cmdResetFalha) _values_[0] = cmdResetFalha;
      return ((IHMIAccessorOutput)this).FireEvent(7, _values_);
    }
    public bool FireEvent_E_VALVULA_LAVAGEM(System.Boolean CMD_VALVULA_LAVAGEM)
    {
      return ((IHMIAccessorOutput)this).FireEvent(8, new object[] {CMD_VALVULA_LAVAGEM});
    }
    public bool FireEvent_E_VALVULA_LAVAGEM(Hidryco.HidrycoLib.Symbols.UCT_PreTratamento.E_VALVULA_LAVAGEMEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.CMD_VALVULA_LAVAGEM.HasValue) _values_[0] = ea.CMD_VALVULA_LAVAGEM.Value;
      return ((IHMIAccessorOutput)this).FireEvent(8, _values_);
    }
    public bool FireEvent_E_VALVULA_LAVAGEM(System.Boolean CMD_VALVULA_LAVAGEM, bool ignore_CMD_VALVULA_LAVAGEM)
    {
      object[] _values_ = new object[1];
      if (!ignore_CMD_VALVULA_LAVAGEM) _values_[0] = CMD_VALVULA_LAVAGEM;
      return ((IHMIAccessorOutput)this).FireEvent(8, _values_);
    }
    public bool FireEvent_E_PARAMETROS(System.Boolean STP_HABILITADA, System.UInt16 STP_TEMPO_PRE_LAVAGEM, System.UInt16 STP_TEMPO_VALVULA_APOS_PARTIDA, System.UInt16 STP_TEMPO_DESLIGA_BOMBA, System.Single STP_VELOCIDADE_BOMBA_GORDURA)
    {
      return ((IHMIAccessorOutput)this).FireEvent(9, new object[] {STP_HABILITADA, STP_TEMPO_PRE_LAVAGEM, STP_TEMPO_VALVULA_APOS_PARTIDA, STP_TEMPO_DESLIGA_BOMBA, STP_VELOCIDADE_BOMBA_GORDURA});
    }
    public bool FireEvent_E_PARAMETROS(Hidryco.HidrycoLib.Symbols.UCT_PreTratamento.E_PARAMETROSEventArgs ea)
    {
      object[] _values_ = new object[5];
      if (ea.STP_HABILITADA.HasValue) _values_[0] = ea.STP_HABILITADA.Value;
      if (ea.STP_TEMPO_PRE_LAVAGEM.HasValue) _values_[1] = ea.STP_TEMPO_PRE_LAVAGEM.Value;
      if (ea.STP_TEMPO_VALVULA_APOS_PARTIDA.HasValue) _values_[2] = ea.STP_TEMPO_VALVULA_APOS_PARTIDA.Value;
      if (ea.STP_TEMPO_DESLIGA_BOMBA.HasValue) _values_[3] = ea.STP_TEMPO_DESLIGA_BOMBA.Value;
      if (ea.STP_VELOCIDADE_BOMBA_GORDURA.HasValue) _values_[4] = ea.STP_VELOCIDADE_BOMBA_GORDURA.Value;
      return ((IHMIAccessorOutput)this).FireEvent(9, _values_);
    }
    public bool FireEvent_E_PARAMETROS(System.Boolean STP_HABILITADA, bool ignore_STP_HABILITADA, System.UInt16 STP_TEMPO_PRE_LAVAGEM, bool ignore_STP_TEMPO_PRE_LAVAGEM, System.UInt16 STP_TEMPO_VALVULA_APOS_PARTIDA, bool ignore_STP_TEMPO_VALVULA_APOS_PARTIDA, System.UInt16 STP_TEMPO_DESLIGA_BOMBA, bool ignore_STP_TEMPO_DESLIGA_BOMBA, System.Single STP_VELOCIDADE_BOMBA_GORDURA, bool ignore_STP_VELOCIDADE_BOMBA_GORDURA)
    {
      object[] _values_ = new object[5];
      if (!ignore_STP_HABILITADA) _values_[0] = STP_HABILITADA;
      if (!ignore_STP_TEMPO_PRE_LAVAGEM) _values_[1] = STP_TEMPO_PRE_LAVAGEM;
      if (!ignore_STP_TEMPO_VALVULA_APOS_PARTIDA) _values_[2] = STP_TEMPO_VALVULA_APOS_PARTIDA;
      if (!ignore_STP_TEMPO_DESLIGA_BOMBA) _values_[3] = STP_TEMPO_DESLIGA_BOMBA;
      if (!ignore_STP_VELOCIDADE_BOMBA_GORDURA) _values_[4] = STP_VELOCIDADE_BOMBA_GORDURA;
      return ((IHMIAccessorOutput)this).FireEvent(9, _values_);
    }

  }
}

namespace Hidryco.HidrycoLib.Faceplates.UCT_PreTratamento
{
  partial class fpParameter
  {

    private event EventHandler<Hidryco.HidrycoLib.Symbols.UCT_PreTratamento.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    private event EventHandler<Hidryco.HidrycoLib.Symbols.UCT_PreTratamento.REQEventArgs> REQ_Fired;

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
              LOAD_PERS_DATA_Fired(this, new Hidryco.HidrycoLib.Symbols.UCT_PreTratamento.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
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
              REQ_Fired(this, new Hidryco.HidrycoLib.Symbols.UCT_PreTratamento.REQEventArgs(channelId, cookie, eventIndex));
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
    public bool FireEvent_E_LIGA_SUBSISTEMA_PENEIRA(System.Boolean cmdLigaSubsistemaPeneira)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {cmdLigaSubsistemaPeneira});
    }
    public bool FireEvent_E_LIGA_SUBSISTEMA_PENEIRA(Hidryco.HidrycoLib.Symbols.UCT_PreTratamento.E_LIGA_SUBSISTEMA_PENEIRAEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.cmdLigaSubsistemaPeneira.HasValue) _values_[0] = ea.cmdLigaSubsistemaPeneira.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_E_LIGA_SUBSISTEMA_PENEIRA(System.Boolean cmdLigaSubsistemaPeneira, bool ignore_cmdLigaSubsistemaPeneira)
    {
      object[] _values_ = new object[1];
      if (!ignore_cmdLigaSubsistemaPeneira) _values_[0] = cmdLigaSubsistemaPeneira;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_E_SELECAO_SUBSISTEMA_PENEIRA(System.Boolean cmdSelecaoSubsistemaPeneira)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {cmdSelecaoSubsistemaPeneira});
    }
    public bool FireEvent_E_SELECAO_SUBSISTEMA_PENEIRA(Hidryco.HidrycoLib.Symbols.UCT_PreTratamento.E_SELECAO_SUBSISTEMA_PENEIRAEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.cmdSelecaoSubsistemaPeneira.HasValue) _values_[0] = ea.cmdSelecaoSubsistemaPeneira.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_E_SELECAO_SUBSISTEMA_PENEIRA(System.Boolean cmdSelecaoSubsistemaPeneira, bool ignore_cmdSelecaoSubsistemaPeneira)
    {
      object[] _values_ = new object[1];
      if (!ignore_cmdSelecaoSubsistemaPeneira) _values_[0] = cmdSelecaoSubsistemaPeneira;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_E_LIGA_SUBSISTEMA_ROSCAS(System.Boolean cmdLigaSubsistemaRoscas)
    {
      return ((IHMIAccessorOutput)this).FireEvent(2, new object[] {cmdLigaSubsistemaRoscas});
    }
    public bool FireEvent_E_LIGA_SUBSISTEMA_ROSCAS(Hidryco.HidrycoLib.Symbols.UCT_PreTratamento.E_LIGA_SUBSISTEMA_ROSCASEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.cmdLigaSubsistemaRoscas.HasValue) _values_[0] = ea.cmdLigaSubsistemaRoscas.Value;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_E_LIGA_SUBSISTEMA_ROSCAS(System.Boolean cmdLigaSubsistemaRoscas, bool ignore_cmdLigaSubsistemaRoscas)
    {
      object[] _values_ = new object[1];
      if (!ignore_cmdLigaSubsistemaRoscas) _values_[0] = cmdLigaSubsistemaRoscas;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_E_SELECAO_SUBSISTEMA_ROSCAS(System.Boolean cmdSelecaoSubsistemaRoscas)
    {
      return ((IHMIAccessorOutput)this).FireEvent(3, new object[] {cmdSelecaoSubsistemaRoscas});
    }
    public bool FireEvent_E_SELECAO_SUBSISTEMA_ROSCAS(Hidryco.HidrycoLib.Symbols.UCT_PreTratamento.E_SELECAO_SUBSISTEMA_ROSCASEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.cmdSelecaoSubsistemaRoscas.HasValue) _values_[0] = ea.cmdSelecaoSubsistemaRoscas.Value;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_E_SELECAO_SUBSISTEMA_ROSCAS(System.Boolean cmdSelecaoSubsistemaRoscas, bool ignore_cmdSelecaoSubsistemaRoscas)
    {
      object[] _values_ = new object[1];
      if (!ignore_cmdSelecaoSubsistemaRoscas) _values_[0] = cmdSelecaoSubsistemaRoscas;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_E_LIGA_SUBSISTEMA_RASPCOMP(System.Boolean cmdLigaSubsistemaRaspComp)
    {
      return ((IHMIAccessorOutput)this).FireEvent(4, new object[] {cmdLigaSubsistemaRaspComp});
    }
    public bool FireEvent_E_LIGA_SUBSISTEMA_RASPCOMP(Hidryco.HidrycoLib.Symbols.UCT_PreTratamento.E_LIGA_SUBSISTEMA_RASPCOMPEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.cmdLigaSubsistemaRaspComp.HasValue) _values_[0] = ea.cmdLigaSubsistemaRaspComp.Value;
      return ((IHMIAccessorOutput)this).FireEvent(4, _values_);
    }
    public bool FireEvent_E_LIGA_SUBSISTEMA_RASPCOMP(System.Boolean cmdLigaSubsistemaRaspComp, bool ignore_cmdLigaSubsistemaRaspComp)
    {
      object[] _values_ = new object[1];
      if (!ignore_cmdLigaSubsistemaRaspComp) _values_[0] = cmdLigaSubsistemaRaspComp;
      return ((IHMIAccessorOutput)this).FireEvent(4, _values_);
    }
    public bool FireEvent_E_SELECAO_SUBSISTEMA_RASPCOMP(System.Boolean cmdSelecaoSubsistemaRaspComp)
    {
      return ((IHMIAccessorOutput)this).FireEvent(5, new object[] {cmdSelecaoSubsistemaRaspComp});
    }
    public bool FireEvent_E_SELECAO_SUBSISTEMA_RASPCOMP(Hidryco.HidrycoLib.Symbols.UCT_PreTratamento.E_SELECAO_SUBSISTEMA_RASPCOMPEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.cmdSelecaoSubsistemaRaspComp.HasValue) _values_[0] = ea.cmdSelecaoSubsistemaRaspComp.Value;
      return ((IHMIAccessorOutput)this).FireEvent(5, _values_);
    }
    public bool FireEvent_E_SELECAO_SUBSISTEMA_RASPCOMP(System.Boolean cmdSelecaoSubsistemaRaspComp, bool ignore_cmdSelecaoSubsistemaRaspComp)
    {
      object[] _values_ = new object[1];
      if (!ignore_cmdSelecaoSubsistemaRaspComp) _values_[0] = cmdSelecaoSubsistemaRaspComp;
      return ((IHMIAccessorOutput)this).FireEvent(5, _values_);
    }
    public bool FireEvent_E_SELECAO_BOMBA_HIGIENIZACAO(System.Boolean cmdSelecaoBombaHigienizacao)
    {
      return ((IHMIAccessorOutput)this).FireEvent(6, new object[] {cmdSelecaoBombaHigienizacao});
    }
    public bool FireEvent_E_SELECAO_BOMBA_HIGIENIZACAO(Hidryco.HidrycoLib.Symbols.UCT_PreTratamento.E_SELECAO_BOMBA_HIGIENIZACAOEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.cmdSelecaoBombaHigienizacao.HasValue) _values_[0] = ea.cmdSelecaoBombaHigienizacao.Value;
      return ((IHMIAccessorOutput)this).FireEvent(6, _values_);
    }
    public bool FireEvent_E_SELECAO_BOMBA_HIGIENIZACAO(System.Boolean cmdSelecaoBombaHigienizacao, bool ignore_cmdSelecaoBombaHigienizacao)
    {
      object[] _values_ = new object[1];
      if (!ignore_cmdSelecaoBombaHigienizacao) _values_[0] = cmdSelecaoBombaHigienizacao;
      return ((IHMIAccessorOutput)this).FireEvent(6, _values_);
    }
    public bool FireEvent_E_RESET_FALHA(System.Boolean cmdResetFalha)
    {
      return ((IHMIAccessorOutput)this).FireEvent(7, new object[] {cmdResetFalha});
    }
    public bool FireEvent_E_RESET_FALHA(Hidryco.HidrycoLib.Symbols.UCT_PreTratamento.E_RESET_FALHAEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.cmdResetFalha.HasValue) _values_[0] = ea.cmdResetFalha.Value;
      return ((IHMIAccessorOutput)this).FireEvent(7, _values_);
    }
    public bool FireEvent_E_RESET_FALHA(System.Boolean cmdResetFalha, bool ignore_cmdResetFalha)
    {
      object[] _values_ = new object[1];
      if (!ignore_cmdResetFalha) _values_[0] = cmdResetFalha;
      return ((IHMIAccessorOutput)this).FireEvent(7, _values_);
    }
    public bool FireEvent_E_VALVULA_LAVAGEM(System.Boolean CMD_VALVULA_LAVAGEM)
    {
      return ((IHMIAccessorOutput)this).FireEvent(8, new object[] {CMD_VALVULA_LAVAGEM});
    }
    public bool FireEvent_E_VALVULA_LAVAGEM(Hidryco.HidrycoLib.Symbols.UCT_PreTratamento.E_VALVULA_LAVAGEMEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.CMD_VALVULA_LAVAGEM.HasValue) _values_[0] = ea.CMD_VALVULA_LAVAGEM.Value;
      return ((IHMIAccessorOutput)this).FireEvent(8, _values_);
    }
    public bool FireEvent_E_VALVULA_LAVAGEM(System.Boolean CMD_VALVULA_LAVAGEM, bool ignore_CMD_VALVULA_LAVAGEM)
    {
      object[] _values_ = new object[1];
      if (!ignore_CMD_VALVULA_LAVAGEM) _values_[0] = CMD_VALVULA_LAVAGEM;
      return ((IHMIAccessorOutput)this).FireEvent(8, _values_);
    }
    public bool FireEvent_E_PARAMETROS(System.Boolean STP_HABILITADA, System.UInt16 STP_TEMPO_PRE_LAVAGEM, System.UInt16 STP_TEMPO_VALVULA_APOS_PARTIDA, System.UInt16 STP_TEMPO_DESLIGA_BOMBA, System.Single STP_VELOCIDADE_BOMBA_GORDURA)
    {
      return ((IHMIAccessorOutput)this).FireEvent(9, new object[] {STP_HABILITADA, STP_TEMPO_PRE_LAVAGEM, STP_TEMPO_VALVULA_APOS_PARTIDA, STP_TEMPO_DESLIGA_BOMBA, STP_VELOCIDADE_BOMBA_GORDURA});
    }
    public bool FireEvent_E_PARAMETROS(Hidryco.HidrycoLib.Symbols.UCT_PreTratamento.E_PARAMETROSEventArgs ea)
    {
      object[] _values_ = new object[5];
      if (ea.STP_HABILITADA.HasValue) _values_[0] = ea.STP_HABILITADA.Value;
      if (ea.STP_TEMPO_PRE_LAVAGEM.HasValue) _values_[1] = ea.STP_TEMPO_PRE_LAVAGEM.Value;
      if (ea.STP_TEMPO_VALVULA_APOS_PARTIDA.HasValue) _values_[2] = ea.STP_TEMPO_VALVULA_APOS_PARTIDA.Value;
      if (ea.STP_TEMPO_DESLIGA_BOMBA.HasValue) _values_[3] = ea.STP_TEMPO_DESLIGA_BOMBA.Value;
      if (ea.STP_VELOCIDADE_BOMBA_GORDURA.HasValue) _values_[4] = ea.STP_VELOCIDADE_BOMBA_GORDURA.Value;
      return ((IHMIAccessorOutput)this).FireEvent(9, _values_);
    }
    public bool FireEvent_E_PARAMETROS(System.Boolean STP_HABILITADA, bool ignore_STP_HABILITADA, System.UInt16 STP_TEMPO_PRE_LAVAGEM, bool ignore_STP_TEMPO_PRE_LAVAGEM, System.UInt16 STP_TEMPO_VALVULA_APOS_PARTIDA, bool ignore_STP_TEMPO_VALVULA_APOS_PARTIDA, System.UInt16 STP_TEMPO_DESLIGA_BOMBA, bool ignore_STP_TEMPO_DESLIGA_BOMBA, System.Single STP_VELOCIDADE_BOMBA_GORDURA, bool ignore_STP_VELOCIDADE_BOMBA_GORDURA)
    {
      object[] _values_ = new object[5];
      if (!ignore_STP_HABILITADA) _values_[0] = STP_HABILITADA;
      if (!ignore_STP_TEMPO_PRE_LAVAGEM) _values_[1] = STP_TEMPO_PRE_LAVAGEM;
      if (!ignore_STP_TEMPO_VALVULA_APOS_PARTIDA) _values_[2] = STP_TEMPO_VALVULA_APOS_PARTIDA;
      if (!ignore_STP_TEMPO_DESLIGA_BOMBA) _values_[3] = STP_TEMPO_DESLIGA_BOMBA;
      if (!ignore_STP_VELOCIDADE_BOMBA_GORDURA) _values_[4] = STP_VELOCIDADE_BOMBA_GORDURA;
      return ((IHMIAccessorOutput)this).FireEvent(9, _values_);
    }

  }
}

namespace Hidryco.HidrycoLib.Symbols.UCT_PreTratamento
{
  partial class sSkid
  {

    private event EventHandler<Hidryco.HidrycoLib.Symbols.UCT_PreTratamento.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    private event EventHandler<Hidryco.HidrycoLib.Symbols.UCT_PreTratamento.REQEventArgs> REQ_Fired;

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
              LOAD_PERS_DATA_Fired(this, new Hidryco.HidrycoLib.Symbols.UCT_PreTratamento.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
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
              REQ_Fired(this, new Hidryco.HidrycoLib.Symbols.UCT_PreTratamento.REQEventArgs(channelId, cookie, eventIndex));
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
    public bool FireEvent_E_LIGA_SUBSISTEMA_PENEIRA(System.Boolean cmdLigaSubsistemaPeneira)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {cmdLigaSubsistemaPeneira});
    }
    public bool FireEvent_E_LIGA_SUBSISTEMA_PENEIRA(Hidryco.HidrycoLib.Symbols.UCT_PreTratamento.E_LIGA_SUBSISTEMA_PENEIRAEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.cmdLigaSubsistemaPeneira.HasValue) _values_[0] = ea.cmdLigaSubsistemaPeneira.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_E_LIGA_SUBSISTEMA_PENEIRA(System.Boolean cmdLigaSubsistemaPeneira, bool ignore_cmdLigaSubsistemaPeneira)
    {
      object[] _values_ = new object[1];
      if (!ignore_cmdLigaSubsistemaPeneira) _values_[0] = cmdLigaSubsistemaPeneira;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_E_SELECAO_SUBSISTEMA_PENEIRA(System.Boolean cmdSelecaoSubsistemaPeneira)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {cmdSelecaoSubsistemaPeneira});
    }
    public bool FireEvent_E_SELECAO_SUBSISTEMA_PENEIRA(Hidryco.HidrycoLib.Symbols.UCT_PreTratamento.E_SELECAO_SUBSISTEMA_PENEIRAEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.cmdSelecaoSubsistemaPeneira.HasValue) _values_[0] = ea.cmdSelecaoSubsistemaPeneira.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_E_SELECAO_SUBSISTEMA_PENEIRA(System.Boolean cmdSelecaoSubsistemaPeneira, bool ignore_cmdSelecaoSubsistemaPeneira)
    {
      object[] _values_ = new object[1];
      if (!ignore_cmdSelecaoSubsistemaPeneira) _values_[0] = cmdSelecaoSubsistemaPeneira;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_E_LIGA_SUBSISTEMA_ROSCAS(System.Boolean cmdLigaSubsistemaRoscas)
    {
      return ((IHMIAccessorOutput)this).FireEvent(2, new object[] {cmdLigaSubsistemaRoscas});
    }
    public bool FireEvent_E_LIGA_SUBSISTEMA_ROSCAS(Hidryco.HidrycoLib.Symbols.UCT_PreTratamento.E_LIGA_SUBSISTEMA_ROSCASEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.cmdLigaSubsistemaRoscas.HasValue) _values_[0] = ea.cmdLigaSubsistemaRoscas.Value;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_E_LIGA_SUBSISTEMA_ROSCAS(System.Boolean cmdLigaSubsistemaRoscas, bool ignore_cmdLigaSubsistemaRoscas)
    {
      object[] _values_ = new object[1];
      if (!ignore_cmdLigaSubsistemaRoscas) _values_[0] = cmdLigaSubsistemaRoscas;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_E_SELECAO_SUBSISTEMA_ROSCAS(System.Boolean cmdSelecaoSubsistemaRoscas)
    {
      return ((IHMIAccessorOutput)this).FireEvent(3, new object[] {cmdSelecaoSubsistemaRoscas});
    }
    public bool FireEvent_E_SELECAO_SUBSISTEMA_ROSCAS(Hidryco.HidrycoLib.Symbols.UCT_PreTratamento.E_SELECAO_SUBSISTEMA_ROSCASEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.cmdSelecaoSubsistemaRoscas.HasValue) _values_[0] = ea.cmdSelecaoSubsistemaRoscas.Value;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_E_SELECAO_SUBSISTEMA_ROSCAS(System.Boolean cmdSelecaoSubsistemaRoscas, bool ignore_cmdSelecaoSubsistemaRoscas)
    {
      object[] _values_ = new object[1];
      if (!ignore_cmdSelecaoSubsistemaRoscas) _values_[0] = cmdSelecaoSubsistemaRoscas;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_E_LIGA_SUBSISTEMA_RASPCOMP(System.Boolean cmdLigaSubsistemaRaspComp)
    {
      return ((IHMIAccessorOutput)this).FireEvent(4, new object[] {cmdLigaSubsistemaRaspComp});
    }
    public bool FireEvent_E_LIGA_SUBSISTEMA_RASPCOMP(Hidryco.HidrycoLib.Symbols.UCT_PreTratamento.E_LIGA_SUBSISTEMA_RASPCOMPEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.cmdLigaSubsistemaRaspComp.HasValue) _values_[0] = ea.cmdLigaSubsistemaRaspComp.Value;
      return ((IHMIAccessorOutput)this).FireEvent(4, _values_);
    }
    public bool FireEvent_E_LIGA_SUBSISTEMA_RASPCOMP(System.Boolean cmdLigaSubsistemaRaspComp, bool ignore_cmdLigaSubsistemaRaspComp)
    {
      object[] _values_ = new object[1];
      if (!ignore_cmdLigaSubsistemaRaspComp) _values_[0] = cmdLigaSubsistemaRaspComp;
      return ((IHMIAccessorOutput)this).FireEvent(4, _values_);
    }
    public bool FireEvent_E_SELECAO_SUBSISTEMA_RASPCOMP(System.Boolean cmdSelecaoSubsistemaRaspComp)
    {
      return ((IHMIAccessorOutput)this).FireEvent(5, new object[] {cmdSelecaoSubsistemaRaspComp});
    }
    public bool FireEvent_E_SELECAO_SUBSISTEMA_RASPCOMP(Hidryco.HidrycoLib.Symbols.UCT_PreTratamento.E_SELECAO_SUBSISTEMA_RASPCOMPEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.cmdSelecaoSubsistemaRaspComp.HasValue) _values_[0] = ea.cmdSelecaoSubsistemaRaspComp.Value;
      return ((IHMIAccessorOutput)this).FireEvent(5, _values_);
    }
    public bool FireEvent_E_SELECAO_SUBSISTEMA_RASPCOMP(System.Boolean cmdSelecaoSubsistemaRaspComp, bool ignore_cmdSelecaoSubsistemaRaspComp)
    {
      object[] _values_ = new object[1];
      if (!ignore_cmdSelecaoSubsistemaRaspComp) _values_[0] = cmdSelecaoSubsistemaRaspComp;
      return ((IHMIAccessorOutput)this).FireEvent(5, _values_);
    }
    public bool FireEvent_E_SELECAO_BOMBA_HIGIENIZACAO(System.Boolean cmdSelecaoBombaHigienizacao)
    {
      return ((IHMIAccessorOutput)this).FireEvent(6, new object[] {cmdSelecaoBombaHigienizacao});
    }
    public bool FireEvent_E_SELECAO_BOMBA_HIGIENIZACAO(Hidryco.HidrycoLib.Symbols.UCT_PreTratamento.E_SELECAO_BOMBA_HIGIENIZACAOEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.cmdSelecaoBombaHigienizacao.HasValue) _values_[0] = ea.cmdSelecaoBombaHigienizacao.Value;
      return ((IHMIAccessorOutput)this).FireEvent(6, _values_);
    }
    public bool FireEvent_E_SELECAO_BOMBA_HIGIENIZACAO(System.Boolean cmdSelecaoBombaHigienizacao, bool ignore_cmdSelecaoBombaHigienizacao)
    {
      object[] _values_ = new object[1];
      if (!ignore_cmdSelecaoBombaHigienizacao) _values_[0] = cmdSelecaoBombaHigienizacao;
      return ((IHMIAccessorOutput)this).FireEvent(6, _values_);
    }
    public bool FireEvent_E_RESET_FALHA(System.Boolean cmdResetFalha)
    {
      return ((IHMIAccessorOutput)this).FireEvent(7, new object[] {cmdResetFalha});
    }
    public bool FireEvent_E_RESET_FALHA(Hidryco.HidrycoLib.Symbols.UCT_PreTratamento.E_RESET_FALHAEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.cmdResetFalha.HasValue) _values_[0] = ea.cmdResetFalha.Value;
      return ((IHMIAccessorOutput)this).FireEvent(7, _values_);
    }
    public bool FireEvent_E_RESET_FALHA(System.Boolean cmdResetFalha, bool ignore_cmdResetFalha)
    {
      object[] _values_ = new object[1];
      if (!ignore_cmdResetFalha) _values_[0] = cmdResetFalha;
      return ((IHMIAccessorOutput)this).FireEvent(7, _values_);
    }
    public bool FireEvent_E_VALVULA_LAVAGEM(System.Boolean CMD_VALVULA_LAVAGEM)
    {
      return ((IHMIAccessorOutput)this).FireEvent(8, new object[] {CMD_VALVULA_LAVAGEM});
    }
    public bool FireEvent_E_VALVULA_LAVAGEM(Hidryco.HidrycoLib.Symbols.UCT_PreTratamento.E_VALVULA_LAVAGEMEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.CMD_VALVULA_LAVAGEM.HasValue) _values_[0] = ea.CMD_VALVULA_LAVAGEM.Value;
      return ((IHMIAccessorOutput)this).FireEvent(8, _values_);
    }
    public bool FireEvent_E_VALVULA_LAVAGEM(System.Boolean CMD_VALVULA_LAVAGEM, bool ignore_CMD_VALVULA_LAVAGEM)
    {
      object[] _values_ = new object[1];
      if (!ignore_CMD_VALVULA_LAVAGEM) _values_[0] = CMD_VALVULA_LAVAGEM;
      return ((IHMIAccessorOutput)this).FireEvent(8, _values_);
    }
    public bool FireEvent_E_PARAMETROS(System.Boolean STP_HABILITADA, System.UInt16 STP_TEMPO_PRE_LAVAGEM, System.UInt16 STP_TEMPO_VALVULA_APOS_PARTIDA, System.UInt16 STP_TEMPO_DESLIGA_BOMBA, System.Single STP_VELOCIDADE_BOMBA_GORDURA)
    {
      return ((IHMIAccessorOutput)this).FireEvent(9, new object[] {STP_HABILITADA, STP_TEMPO_PRE_LAVAGEM, STP_TEMPO_VALVULA_APOS_PARTIDA, STP_TEMPO_DESLIGA_BOMBA, STP_VELOCIDADE_BOMBA_GORDURA});
    }
    public bool FireEvent_E_PARAMETROS(Hidryco.HidrycoLib.Symbols.UCT_PreTratamento.E_PARAMETROSEventArgs ea)
    {
      object[] _values_ = new object[5];
      if (ea.STP_HABILITADA.HasValue) _values_[0] = ea.STP_HABILITADA.Value;
      if (ea.STP_TEMPO_PRE_LAVAGEM.HasValue) _values_[1] = ea.STP_TEMPO_PRE_LAVAGEM.Value;
      if (ea.STP_TEMPO_VALVULA_APOS_PARTIDA.HasValue) _values_[2] = ea.STP_TEMPO_VALVULA_APOS_PARTIDA.Value;
      if (ea.STP_TEMPO_DESLIGA_BOMBA.HasValue) _values_[3] = ea.STP_TEMPO_DESLIGA_BOMBA.Value;
      if (ea.STP_VELOCIDADE_BOMBA_GORDURA.HasValue) _values_[4] = ea.STP_VELOCIDADE_BOMBA_GORDURA.Value;
      return ((IHMIAccessorOutput)this).FireEvent(9, _values_);
    }
    public bool FireEvent_E_PARAMETROS(System.Boolean STP_HABILITADA, bool ignore_STP_HABILITADA, System.UInt16 STP_TEMPO_PRE_LAVAGEM, bool ignore_STP_TEMPO_PRE_LAVAGEM, System.UInt16 STP_TEMPO_VALVULA_APOS_PARTIDA, bool ignore_STP_TEMPO_VALVULA_APOS_PARTIDA, System.UInt16 STP_TEMPO_DESLIGA_BOMBA, bool ignore_STP_TEMPO_DESLIGA_BOMBA, System.Single STP_VELOCIDADE_BOMBA_GORDURA, bool ignore_STP_VELOCIDADE_BOMBA_GORDURA)
    {
      object[] _values_ = new object[5];
      if (!ignore_STP_HABILITADA) _values_[0] = STP_HABILITADA;
      if (!ignore_STP_TEMPO_PRE_LAVAGEM) _values_[1] = STP_TEMPO_PRE_LAVAGEM;
      if (!ignore_STP_TEMPO_VALVULA_APOS_PARTIDA) _values_[2] = STP_TEMPO_VALVULA_APOS_PARTIDA;
      if (!ignore_STP_TEMPO_DESLIGA_BOMBA) _values_[3] = STP_TEMPO_DESLIGA_BOMBA;
      if (!ignore_STP_VELOCIDADE_BOMBA_GORDURA) _values_[4] = STP_VELOCIDADE_BOMBA_GORDURA;
      return ((IHMIAccessorOutput)this).FireEvent(9, _values_);
    }

  }
}

namespace Hidryco.HidrycoLib.Symbols.UCT_PreTratamento
{
  partial class sGordura
  {

    private event EventHandler<Hidryco.HidrycoLib.Symbols.UCT_PreTratamento.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    private event EventHandler<Hidryco.HidrycoLib.Symbols.UCT_PreTratamento.REQEventArgs> REQ_Fired;

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
              LOAD_PERS_DATA_Fired(this, new Hidryco.HidrycoLib.Symbols.UCT_PreTratamento.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
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
              REQ_Fired(this, new Hidryco.HidrycoLib.Symbols.UCT_PreTratamento.REQEventArgs(channelId, cookie, eventIndex));
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
    public bool FireEvent_E_LIGA_SUBSISTEMA_PENEIRA(System.Boolean cmdLigaSubsistemaPeneira)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {cmdLigaSubsistemaPeneira});
    }
    public bool FireEvent_E_LIGA_SUBSISTEMA_PENEIRA(Hidryco.HidrycoLib.Symbols.UCT_PreTratamento.E_LIGA_SUBSISTEMA_PENEIRAEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.cmdLigaSubsistemaPeneira.HasValue) _values_[0] = ea.cmdLigaSubsistemaPeneira.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_E_LIGA_SUBSISTEMA_PENEIRA(System.Boolean cmdLigaSubsistemaPeneira, bool ignore_cmdLigaSubsistemaPeneira)
    {
      object[] _values_ = new object[1];
      if (!ignore_cmdLigaSubsistemaPeneira) _values_[0] = cmdLigaSubsistemaPeneira;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_E_SELECAO_SUBSISTEMA_PENEIRA(System.Boolean cmdSelecaoSubsistemaPeneira)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {cmdSelecaoSubsistemaPeneira});
    }
    public bool FireEvent_E_SELECAO_SUBSISTEMA_PENEIRA(Hidryco.HidrycoLib.Symbols.UCT_PreTratamento.E_SELECAO_SUBSISTEMA_PENEIRAEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.cmdSelecaoSubsistemaPeneira.HasValue) _values_[0] = ea.cmdSelecaoSubsistemaPeneira.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_E_SELECAO_SUBSISTEMA_PENEIRA(System.Boolean cmdSelecaoSubsistemaPeneira, bool ignore_cmdSelecaoSubsistemaPeneira)
    {
      object[] _values_ = new object[1];
      if (!ignore_cmdSelecaoSubsistemaPeneira) _values_[0] = cmdSelecaoSubsistemaPeneira;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_E_LIGA_SUBSISTEMA_ROSCAS(System.Boolean cmdLigaSubsistemaRoscas)
    {
      return ((IHMIAccessorOutput)this).FireEvent(2, new object[] {cmdLigaSubsistemaRoscas});
    }
    public bool FireEvent_E_LIGA_SUBSISTEMA_ROSCAS(Hidryco.HidrycoLib.Symbols.UCT_PreTratamento.E_LIGA_SUBSISTEMA_ROSCASEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.cmdLigaSubsistemaRoscas.HasValue) _values_[0] = ea.cmdLigaSubsistemaRoscas.Value;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_E_LIGA_SUBSISTEMA_ROSCAS(System.Boolean cmdLigaSubsistemaRoscas, bool ignore_cmdLigaSubsistemaRoscas)
    {
      object[] _values_ = new object[1];
      if (!ignore_cmdLigaSubsistemaRoscas) _values_[0] = cmdLigaSubsistemaRoscas;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_E_SELECAO_SUBSISTEMA_ROSCAS(System.Boolean cmdSelecaoSubsistemaRoscas)
    {
      return ((IHMIAccessorOutput)this).FireEvent(3, new object[] {cmdSelecaoSubsistemaRoscas});
    }
    public bool FireEvent_E_SELECAO_SUBSISTEMA_ROSCAS(Hidryco.HidrycoLib.Symbols.UCT_PreTratamento.E_SELECAO_SUBSISTEMA_ROSCASEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.cmdSelecaoSubsistemaRoscas.HasValue) _values_[0] = ea.cmdSelecaoSubsistemaRoscas.Value;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_E_SELECAO_SUBSISTEMA_ROSCAS(System.Boolean cmdSelecaoSubsistemaRoscas, bool ignore_cmdSelecaoSubsistemaRoscas)
    {
      object[] _values_ = new object[1];
      if (!ignore_cmdSelecaoSubsistemaRoscas) _values_[0] = cmdSelecaoSubsistemaRoscas;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_E_LIGA_SUBSISTEMA_RASPCOMP(System.Boolean cmdLigaSubsistemaRaspComp)
    {
      return ((IHMIAccessorOutput)this).FireEvent(4, new object[] {cmdLigaSubsistemaRaspComp});
    }
    public bool FireEvent_E_LIGA_SUBSISTEMA_RASPCOMP(Hidryco.HidrycoLib.Symbols.UCT_PreTratamento.E_LIGA_SUBSISTEMA_RASPCOMPEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.cmdLigaSubsistemaRaspComp.HasValue) _values_[0] = ea.cmdLigaSubsistemaRaspComp.Value;
      return ((IHMIAccessorOutput)this).FireEvent(4, _values_);
    }
    public bool FireEvent_E_LIGA_SUBSISTEMA_RASPCOMP(System.Boolean cmdLigaSubsistemaRaspComp, bool ignore_cmdLigaSubsistemaRaspComp)
    {
      object[] _values_ = new object[1];
      if (!ignore_cmdLigaSubsistemaRaspComp) _values_[0] = cmdLigaSubsistemaRaspComp;
      return ((IHMIAccessorOutput)this).FireEvent(4, _values_);
    }
    public bool FireEvent_E_SELECAO_SUBSISTEMA_RASPCOMP(System.Boolean cmdSelecaoSubsistemaRaspComp)
    {
      return ((IHMIAccessorOutput)this).FireEvent(5, new object[] {cmdSelecaoSubsistemaRaspComp});
    }
    public bool FireEvent_E_SELECAO_SUBSISTEMA_RASPCOMP(Hidryco.HidrycoLib.Symbols.UCT_PreTratamento.E_SELECAO_SUBSISTEMA_RASPCOMPEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.cmdSelecaoSubsistemaRaspComp.HasValue) _values_[0] = ea.cmdSelecaoSubsistemaRaspComp.Value;
      return ((IHMIAccessorOutput)this).FireEvent(5, _values_);
    }
    public bool FireEvent_E_SELECAO_SUBSISTEMA_RASPCOMP(System.Boolean cmdSelecaoSubsistemaRaspComp, bool ignore_cmdSelecaoSubsistemaRaspComp)
    {
      object[] _values_ = new object[1];
      if (!ignore_cmdSelecaoSubsistemaRaspComp) _values_[0] = cmdSelecaoSubsistemaRaspComp;
      return ((IHMIAccessorOutput)this).FireEvent(5, _values_);
    }
    public bool FireEvent_E_SELECAO_BOMBA_HIGIENIZACAO(System.Boolean cmdSelecaoBombaHigienizacao)
    {
      return ((IHMIAccessorOutput)this).FireEvent(6, new object[] {cmdSelecaoBombaHigienizacao});
    }
    public bool FireEvent_E_SELECAO_BOMBA_HIGIENIZACAO(Hidryco.HidrycoLib.Symbols.UCT_PreTratamento.E_SELECAO_BOMBA_HIGIENIZACAOEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.cmdSelecaoBombaHigienizacao.HasValue) _values_[0] = ea.cmdSelecaoBombaHigienizacao.Value;
      return ((IHMIAccessorOutput)this).FireEvent(6, _values_);
    }
    public bool FireEvent_E_SELECAO_BOMBA_HIGIENIZACAO(System.Boolean cmdSelecaoBombaHigienizacao, bool ignore_cmdSelecaoBombaHigienizacao)
    {
      object[] _values_ = new object[1];
      if (!ignore_cmdSelecaoBombaHigienizacao) _values_[0] = cmdSelecaoBombaHigienizacao;
      return ((IHMIAccessorOutput)this).FireEvent(6, _values_);
    }
    public bool FireEvent_E_RESET_FALHA(System.Boolean cmdResetFalha)
    {
      return ((IHMIAccessorOutput)this).FireEvent(7, new object[] {cmdResetFalha});
    }
    public bool FireEvent_E_RESET_FALHA(Hidryco.HidrycoLib.Symbols.UCT_PreTratamento.E_RESET_FALHAEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.cmdResetFalha.HasValue) _values_[0] = ea.cmdResetFalha.Value;
      return ((IHMIAccessorOutput)this).FireEvent(7, _values_);
    }
    public bool FireEvent_E_RESET_FALHA(System.Boolean cmdResetFalha, bool ignore_cmdResetFalha)
    {
      object[] _values_ = new object[1];
      if (!ignore_cmdResetFalha) _values_[0] = cmdResetFalha;
      return ((IHMIAccessorOutput)this).FireEvent(7, _values_);
    }
    public bool FireEvent_E_VALVULA_LAVAGEM(System.Boolean CMD_VALVULA_LAVAGEM)
    {
      return ((IHMIAccessorOutput)this).FireEvent(8, new object[] {CMD_VALVULA_LAVAGEM});
    }
    public bool FireEvent_E_VALVULA_LAVAGEM(Hidryco.HidrycoLib.Symbols.UCT_PreTratamento.E_VALVULA_LAVAGEMEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.CMD_VALVULA_LAVAGEM.HasValue) _values_[0] = ea.CMD_VALVULA_LAVAGEM.Value;
      return ((IHMIAccessorOutput)this).FireEvent(8, _values_);
    }
    public bool FireEvent_E_VALVULA_LAVAGEM(System.Boolean CMD_VALVULA_LAVAGEM, bool ignore_CMD_VALVULA_LAVAGEM)
    {
      object[] _values_ = new object[1];
      if (!ignore_CMD_VALVULA_LAVAGEM) _values_[0] = CMD_VALVULA_LAVAGEM;
      return ((IHMIAccessorOutput)this).FireEvent(8, _values_);
    }
    public bool FireEvent_E_PARAMETROS(System.Boolean STP_HABILITADA, System.UInt16 STP_TEMPO_PRE_LAVAGEM, System.UInt16 STP_TEMPO_VALVULA_APOS_PARTIDA, System.UInt16 STP_TEMPO_DESLIGA_BOMBA, System.Single STP_VELOCIDADE_BOMBA_GORDURA)
    {
      return ((IHMIAccessorOutput)this).FireEvent(9, new object[] {STP_HABILITADA, STP_TEMPO_PRE_LAVAGEM, STP_TEMPO_VALVULA_APOS_PARTIDA, STP_TEMPO_DESLIGA_BOMBA, STP_VELOCIDADE_BOMBA_GORDURA});
    }
    public bool FireEvent_E_PARAMETROS(Hidryco.HidrycoLib.Symbols.UCT_PreTratamento.E_PARAMETROSEventArgs ea)
    {
      object[] _values_ = new object[5];
      if (ea.STP_HABILITADA.HasValue) _values_[0] = ea.STP_HABILITADA.Value;
      if (ea.STP_TEMPO_PRE_LAVAGEM.HasValue) _values_[1] = ea.STP_TEMPO_PRE_LAVAGEM.Value;
      if (ea.STP_TEMPO_VALVULA_APOS_PARTIDA.HasValue) _values_[2] = ea.STP_TEMPO_VALVULA_APOS_PARTIDA.Value;
      if (ea.STP_TEMPO_DESLIGA_BOMBA.HasValue) _values_[3] = ea.STP_TEMPO_DESLIGA_BOMBA.Value;
      if (ea.STP_VELOCIDADE_BOMBA_GORDURA.HasValue) _values_[4] = ea.STP_VELOCIDADE_BOMBA_GORDURA.Value;
      return ((IHMIAccessorOutput)this).FireEvent(9, _values_);
    }
    public bool FireEvent_E_PARAMETROS(System.Boolean STP_HABILITADA, bool ignore_STP_HABILITADA, System.UInt16 STP_TEMPO_PRE_LAVAGEM, bool ignore_STP_TEMPO_PRE_LAVAGEM, System.UInt16 STP_TEMPO_VALVULA_APOS_PARTIDA, bool ignore_STP_TEMPO_VALVULA_APOS_PARTIDA, System.UInt16 STP_TEMPO_DESLIGA_BOMBA, bool ignore_STP_TEMPO_DESLIGA_BOMBA, System.Single STP_VELOCIDADE_BOMBA_GORDURA, bool ignore_STP_VELOCIDADE_BOMBA_GORDURA)
    {
      object[] _values_ = new object[5];
      if (!ignore_STP_HABILITADA) _values_[0] = STP_HABILITADA;
      if (!ignore_STP_TEMPO_PRE_LAVAGEM) _values_[1] = STP_TEMPO_PRE_LAVAGEM;
      if (!ignore_STP_TEMPO_VALVULA_APOS_PARTIDA) _values_[2] = STP_TEMPO_VALVULA_APOS_PARTIDA;
      if (!ignore_STP_TEMPO_DESLIGA_BOMBA) _values_[3] = STP_TEMPO_DESLIGA_BOMBA;
      if (!ignore_STP_VELOCIDADE_BOMBA_GORDURA) _values_[4] = STP_VELOCIDADE_BOMBA_GORDURA;
      return ((IHMIAccessorOutput)this).FireEvent(9, _values_);
    }

  }
}
#endregion #UCT_PreTratamento_HMI;

#endregion Definitions;
