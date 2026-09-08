/*
 * Criado pelo EcoStruxure Automation Expert.
 * Usuário:  
 * Data: 21/04/2026
 * Tempo: 13:41
 * 
 */
using System;
using NxtControl.GuiFramework;
using NxtControl.Services;

#region Definitions;
#region #Unifilar_HMI;

namespace Hidryco.HidrycoLib.Symbols.Unifilar
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
    public bool Get_PCE_DISJUNTOR_LIGADO(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,0, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? PCE_DISJUNTOR_LIGADO
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,0, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_V4603_DISJUNTOR_LIGADO(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,1, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? V4603_DISJUNTOR_LIGADO
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,1, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_V4604_DISJUNTOR_LIGADO(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,2, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? V4604_DISJUNTOR_LIGADO
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,2, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_COMP_500_02_DISJUNTOR_LIGADO(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,3, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? COMP_500_02_DISJUNTOR_LIGADO
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,3, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_UCT_200_01_DISJUNTOR_LIGADO(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,4, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? UCT_200_01_DISJUNTOR_LIGADO
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,4, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_PCM_EEE_BRUTO_DISJUNTOR_LIGADO(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,5, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? PCM_EEE_BRUTO_DISJUNTOR_LIGADO
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,5, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_QGBT_220V_DISJUNTOR_LIGADO(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,6, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? QGBT_220V_DISJUNTOR_LIGADO
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,6, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_PCM_DESINFECCAO_DISJUNTOR_LIGADO(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,7, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? PCM_DESINFECCAO_DISJUNTOR_LIGADO
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,7, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_BANCO_CAPACITORES_DISJUNTOR_LIGADO(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,8, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? BANCO_CAPACITORES_DISJUNTOR_LIGADO
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,8, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_V4601_DISJUNTOR_LIGADO(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,9, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? V4601_DISJUNTOR_LIGADO
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,9, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_V4602_DISJUNTOR_LIGADO(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,10, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? V4602_DISJUNTOR_LIGADO
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,10, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_COMP_500_01_DISJUNTOR_LIGADO(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,11, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? COMP_500_01_DISJUNTOR_LIGADO
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,11, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_UCT_200_02_DISJUNTOR_LIGADO(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,12, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? UCT_200_02_DISJUNTOR_LIGADO
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,12, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_UCT_200_03_DISJUNTOR_LIGADO(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,13, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? UCT_200_03_DISJUNTOR_LIGADO
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,13, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_PCM_NET_DISJUNTOR_LIGADO(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,14, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? PCM_NET_DISJUNTOR_LIGADO
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,14, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_PCM_LD_DISJUNTOR_LIGADO(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,15, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? PCM_LD_DISJUNTOR_LIGADO
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,15, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_CAP2_DISJUNTOR_LIGADO(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,16, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? CAP2_DISJUNTOR_LIGADO
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,16, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_QBGT_220V_DISJUNTOR_LIGADO(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,17, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? QBGT_220V_DISJUNTOR_LIGADO
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,17, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_QL_ADM_DISJUNTOR_LIGADO(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,18, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? QL_ADM_DISJUNTOR_LIGADO
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,18, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_QL_PORTARIA_DISJUNTOR_LIGADO(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,19, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? QL_PORTARIA_DISJUNTOR_LIGADO
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,19, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_QLSL_DISJUNTOR_LIGADO(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,20, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? QLSL_DISJUNTOR_LIGADO
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,20, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_QL_ILUMINACAO_DISJUNTOR_LIGADO(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,21, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? QL_ILUMINACAO_DISJUNTOR_LIGADO
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,21, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_PCE_SOPRADORES_DISJUNTOR_LIGADO(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,22, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? PCE_SOPRADORES_DISJUNTOR_LIGADO
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,22, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_QL_LODO_DISJUNTOR_LIGADO(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,23, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? QL_LODO_DISJUNTOR_LIGADO
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,23, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_PCM_AGUA_REUSO_DISJUNTOR_LIGADO(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,24, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? PCM_AGUA_REUSO_DISJUNTOR_LIGADO
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,24, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_LOCAL_1Q0(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,25, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? LOCAL_1Q0
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,25, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_REMOTO_1Q0(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,26, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? REMOTO_1Q0
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,26, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_PRONTO_1Q0(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,27, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? PRONTO_1Q0
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,27, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_CARREGADO_1Q0(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,28, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? CARREGADO_1Q0
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,28, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_SEM_FALHA_1Q0(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,29, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? SEM_FALHA_1Q0
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,29, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_ABERTO_1Q0(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,30, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? ABERTO_1Q0
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,30, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_FECHADO_1Q0(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,31, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? FECHADO_1Q0
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,31, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_LOCAL_1Q1(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,32, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? LOCAL_1Q1
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,32, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_REMOTO_1Q1(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,33, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? REMOTO_1Q1
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,33, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_PRONTO_1Q1(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,34, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? PRONTO_1Q1
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,34, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_CARREGADO_1Q1(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,35, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? CARREGADO_1Q1
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,35, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_SEM_FALHA_1Q1(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,36, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? SEM_FALHA_1Q1
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,36, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_ABERTO_1Q1(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,37, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? ABERTO_1Q1
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,37, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_FECHADO_1Q1(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,38, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? FECHADO_1Q1
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,38, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_LOCAL_1Q2(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,39, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? LOCAL_1Q2
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,39, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_REMOTO_1Q2(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,40, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? REMOTO_1Q2
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,40, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_PRONTO_1Q2(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,41, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? PRONTO_1Q2
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,41, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_CARREGADO_1Q2(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,42, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? CARREGADO_1Q2
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,42, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_SEM_FALHA_1Q2(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,43, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? SEM_FALHA_1Q2
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,43, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_ABERTO_1Q2(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,44, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? ABERTO_1Q2
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,44, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_FECHADO_1Q2(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,45, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? FECHADO_1Q2
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,45, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_CO_100_01_DISJUNTOR_LIGADO(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,46, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? CO_100_01_DISJUNTOR_LIGADO
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,46, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_CO_100_02_DISJUNTOR_LIGADO(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,47, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? CO_100_02_DISJUNTOR_LIGADO
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,47, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_CO_100_03_DISJUNTOR_LIGADO(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,48, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? CO_100_03_DISJUNTOR_LIGADO
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,48, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_CO_100_04_DISJUNTOR_LIGADO(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,49, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? CO_100_04_DISJUNTOR_LIGADO
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,49, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_GM_100_01_02_DISJUNTOR_LIGADO(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,50, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? GM_100_01_02_DISJUNTOR_LIGADO
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,50, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_MO_100_01_DISJUNTOR_LIGADO(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,51, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? MO_100_01_DISJUNTOR_LIGADO
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,51, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_UV_700_01_DISJUNTOR_LIGADO(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,52, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? UV_700_01_DISJUNTOR_LIGADO
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,52, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_UV_700_02_DISJUNTOR_LIGADO(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,53, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? UV_700_02_DISJUNTOR_LIGADO
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,53, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_VC_700_01_DISJUNTOR_LIGADO(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,54, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? VC_700_01_DISJUNTOR_LIGADO
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,54, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_MO_700_01_DISJUNTOR_LIGADO(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,55, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? MO_700_01_DISJUNTOR_LIGADO
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,55, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_MO_300_01_DISJUNTOR_LIGADO(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,56, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? MO_300_01_DISJUNTOR_LIGADO
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,56, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_R4005A_DISJUNTOR_LIGADO(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,57, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? R4005A_DISJUNTOR_LIGADO
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,57, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_R4005B_DISJUNTOR_LIGADO(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,58, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? R4005B_DISJUNTOR_LIGADO
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,58, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_P4901_DISJUNTOR_LIGADO(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,59, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? P4901_DISJUNTOR_LIGADO
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,59, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_P4902_DISJUNTOR_LIGADO(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,60, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? P4902_DISJUNTOR_LIGADO
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,60, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_P4903_DISJUNTOR_LIGADO(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,61, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? P4903_DISJUNTOR_LIGADO
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,61, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_SO_900_01_DISJUNTOR_LIGADO(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,62, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? SO_900_01_DISJUNTOR_LIGADO
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,62, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_SO_900_02_DISJUNTOR_LIGADO(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,63, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? SO_900_02_DISJUNTOR_LIGADO
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,63, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_AD_900_01_DISJUNTOR_LIGADO(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,64, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? AD_900_01_DISJUNTOR_LIGADO
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,64, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_AD_900_02_DISJUNTOR_LIGADO(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,65, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? AD_900_02_DISJUNTOR_LIGADO
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,65, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_AD_900_03_DISJUNTOR_LIGADO(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,66, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? AD_900_03_DISJUNTOR_LIGADO
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,66, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_PP_900_01_DISJUNTOR_LIGADO(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,67, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? PP_900_01_DISJUNTOR_LIGADO
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,67, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_MN_900_01_DISJUNTOR_LIGADO(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,68, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? MN_900_01_DISJUNTOR_LIGADO
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,68, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_MN_900_02_DISJUNTOR_LIGADO(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,69, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? MN_900_02_DISJUNTOR_LIGADO
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,69, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_MN_900_03_DISJUNTOR_LIGADO(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,70, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? MN_900_03_DISJUNTOR_LIGADO
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,70, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_MN_900_04_DISJUNTOR_LIGADO(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,71, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? MN_900_04_DISJUNTOR_LIGADO
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,71, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_MN_900_05_DISJUNTOR_LIGADO(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,72, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? MN_900_05_DISJUNTOR_LIGADO
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,72, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_BO_900_01_DISJUNTOR_LIGADO(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,73, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? BO_900_01_DISJUNTOR_LIGADO
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,73, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_BO_900_02_DISJUNTOR_LIGADO(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,74, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? BO_900_02_DISJUNTOR_LIGADO
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,74, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_BO_900_03_DISJUNTOR_LIGADO(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,75, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? BO_900_03_DISJUNTOR_LIGADO
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,75, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_BR_900_01_DISJUNTOR_LIGADO(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,76, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? BR_900_01_DISJUNTOR_LIGADO
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,76, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_BR_900_02_DISJUNTOR_LIGADO(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,77, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? BR_900_02_DISJUNTOR_LIGADO
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,77, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_VA_900_01_DISJUNTOR_LIGADO(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,78, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? VA_900_01_DISJUNTOR_LIGADO
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,78, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_VA_900_02_DISJUNTOR_LIGADO(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,79, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? VA_900_02_DISJUNTOR_LIGADO
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,79, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_VE_900_01_DISJUNTOR_LIGADO(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,80, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? VE_900_01_DISJUNTOR_LIGADO
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,80, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_VA_900_06_DISJUNTOR_LIGADO(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,81, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? VA_900_06_DISJUNTOR_LIGADO
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,81, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_VA_900_07_DISJUNTOR_LIGADO(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,82, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? VA_900_07_DISJUNTOR_LIGADO
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,82, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_VA_900_08_DISJUNTOR_LIGADO(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,83, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? VA_900_08_DISJUNTOR_LIGADO
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,83, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_VA_900_09_DISJUNTOR_LIGADO(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,84, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? VA_900_09_DISJUNTOR_LIGADO
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,84, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_VA_900_10_DISJUNTOR_LIGADO(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,85, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? VA_900_10_DISJUNTOR_LIGADO
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,85, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_VA_900_11_DISJUNTOR_LIGADO(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,86, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? VA_900_11_DISJUNTOR_LIGADO
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,86, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_VA_900_12_DISJUNTOR_LIGADO(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,87, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? VA_900_12_DISJUNTOR_LIGADO
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,87, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_VA_900_13_DISJUNTOR_LIGADO(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,88, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? VA_900_13_DISJUNTOR_LIGADO
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,88, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_VB_900_03_DISJUNTOR_LIGADO(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,89, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? VB_900_03_DISJUNTOR_LIGADO
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,89, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_VB_900_04_DISJUNTOR_LIGADO(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,90, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? VB_900_04_DISJUNTOR_LIGADO
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,90, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_QTAM1_DISJUNTOR_LIGADO_GERADOR(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,91, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_QTAM1_DISJUNTOR_LIGADO_GERADOR
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,91, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_QTAM1_DISJUNTOR_LIGADO_QUADRO(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,92, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_QTAM1_DISJUNTOR_LIGADO_QUADRO
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,92, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_QTAM2_DISJUNTOR_LIGADO_GERADOR(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,93, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_QTAM2_DISJUNTOR_LIGADO_GERADOR
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,93, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_QTAM2_DISJUNTOR_LIGADO_QUADRO(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,94, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_QTAM2_DISJUNTOR_LIGADO_QUADRO
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,94, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }


  }

}

namespace Hidryco.HidrycoLib.Symbols.Unifilar
{

  public class CNFEventArgs : System.EventArgs
  {
    public CNFEventArgs()
    {
    }
    private System.Boolean? ABRIR_1Q0_field = null;
    public System.Boolean? ABRIR_1Q0
    {
       get { return ABRIR_1Q0_field; }
       set { ABRIR_1Q0_field = value; }
    }
    private System.Boolean? FECHAR_1Q0_field = null;
    public System.Boolean? FECHAR_1Q0
    {
       get { return FECHAR_1Q0_field; }
       set { FECHAR_1Q0_field = value; }
    }
    private System.Boolean? ABRIR_1Q1_field = null;
    public System.Boolean? ABRIR_1Q1
    {
       get { return ABRIR_1Q1_field; }
       set { ABRIR_1Q1_field = value; }
    }
    private System.Boolean? FECHAR_1Q1_field = null;
    public System.Boolean? FECHAR_1Q1
    {
       get { return FECHAR_1Q1_field; }
       set { FECHAR_1Q1_field = value; }
    }
    private System.Boolean? ABRIR_1Q2_field = null;
    public System.Boolean? ABRIR_1Q2
    {
       get { return ABRIR_1Q2_field; }
       set { ABRIR_1Q2_field = value; }
    }
    private System.Boolean? FECHAR_1Q2_field = null;
    public System.Boolean? FECHAR_1Q2
    {
       get { return FECHAR_1Q2_field; }
       set { FECHAR_1Q2_field = value; }
    }

  }

}

namespace Hidryco.HidrycoLib.Symbols.Unifilar
{
  partial class sDefault
  {

    private event EventHandler<Hidryco.HidrycoLib.Symbols.Unifilar.REQEventArgs> REQ_Fired;

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
              REQ_Fired(this, new Hidryco.HidrycoLib.Symbols.Unifilar.REQEventArgs(channelId, cookie, eventIndex));
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
    public bool FireEvent_CNF(System.Boolean ABRIR_1Q0, System.Boolean FECHAR_1Q0, System.Boolean ABRIR_1Q1, System.Boolean FECHAR_1Q1, System.Boolean ABRIR_1Q2, System.Boolean FECHAR_1Q2)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {ABRIR_1Q0, FECHAR_1Q0, ABRIR_1Q1, FECHAR_1Q1, ABRIR_1Q2, FECHAR_1Q2});
    }
    public bool FireEvent_CNF(Hidryco.HidrycoLib.Symbols.Unifilar.CNFEventArgs ea)
    {
      object[] _values_ = new object[6];
      if (ea.ABRIR_1Q0.HasValue) _values_[0] = ea.ABRIR_1Q0.Value;
      if (ea.FECHAR_1Q0.HasValue) _values_[1] = ea.FECHAR_1Q0.Value;
      if (ea.ABRIR_1Q1.HasValue) _values_[2] = ea.ABRIR_1Q1.Value;
      if (ea.FECHAR_1Q1.HasValue) _values_[3] = ea.FECHAR_1Q1.Value;
      if (ea.ABRIR_1Q2.HasValue) _values_[4] = ea.ABRIR_1Q2.Value;
      if (ea.FECHAR_1Q2.HasValue) _values_[5] = ea.FECHAR_1Q2.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_CNF(System.Boolean ABRIR_1Q0, bool ignore_ABRIR_1Q0, System.Boolean FECHAR_1Q0, bool ignore_FECHAR_1Q0, System.Boolean ABRIR_1Q1, bool ignore_ABRIR_1Q1, System.Boolean FECHAR_1Q1, bool ignore_FECHAR_1Q1, System.Boolean ABRIR_1Q2, bool ignore_ABRIR_1Q2, System.Boolean FECHAR_1Q2, bool ignore_FECHAR_1Q2)
    {
      object[] _values_ = new object[6];
      if (!ignore_ABRIR_1Q0) _values_[0] = ABRIR_1Q0;
      if (!ignore_FECHAR_1Q0) _values_[1] = FECHAR_1Q0;
      if (!ignore_ABRIR_1Q1) _values_[2] = ABRIR_1Q1;
      if (!ignore_FECHAR_1Q1) _values_[3] = FECHAR_1Q1;
      if (!ignore_ABRIR_1Q2) _values_[4] = ABRIR_1Q2;
      if (!ignore_FECHAR_1Q2) _values_[5] = FECHAR_1Q2;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }

  }
}
#endregion #Unifilar_HMI;

#endregion Definitions;
