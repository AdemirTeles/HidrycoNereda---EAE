/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 10/15/2026
 * Time: 11:30 AM
 * 
 */
using System;
using NxtControl.GuiFramework;
using NxtControl.Services;

#region Definitions;
#region #MGE_Generico_HMI;

namespace Hidryco.HidrycoLib.Symbols.MGE_Generico
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
    public bool Get_STS_TENSAO_AB(ref System.Single value)
    {
      if (accessorService == null)
        return false;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,0, ref var);
      if (ret) value = (System.Single) var;
      return ret;
    }

    public System.Single? STS_TENSAO_AB
    { get {
      if (accessorService == null)
        return null;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,0, ref var);
      if (!ret) return null;
      return (System.Single) var;
    }  }

    public bool Get_STS_TENSAO_BC(ref System.Single value)
    {
      if (accessorService == null)
        return false;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,1, ref var);
      if (ret) value = (System.Single) var;
      return ret;
    }

    public System.Single? STS_TENSAO_BC
    { get {
      if (accessorService == null)
        return null;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,1, ref var);
      if (!ret) return null;
      return (System.Single) var;
    }  }

    public bool Get_STS_TENSAO_CA(ref System.Single value)
    {
      if (accessorService == null)
        return false;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,2, ref var);
      if (ret) value = (System.Single) var;
      return ret;
    }

    public System.Single? STS_TENSAO_CA
    { get {
      if (accessorService == null)
        return null;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,2, ref var);
      if (!ret) return null;
      return (System.Single) var;
    }  }

    public bool Get_STS_TENSAO_AN(ref System.Single value)
    {
      if (accessorService == null)
        return false;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,3, ref var);
      if (ret) value = (System.Single) var;
      return ret;
    }

    public System.Single? STS_TENSAO_AN
    { get {
      if (accessorService == null)
        return null;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,3, ref var);
      if (!ret) return null;
      return (System.Single) var;
    }  }

    public bool Get_STS_TENSAO_BN(ref System.Single value)
    {
      if (accessorService == null)
        return false;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,4, ref var);
      if (ret) value = (System.Single) var;
      return ret;
    }

    public System.Single? STS_TENSAO_BN
    { get {
      if (accessorService == null)
        return null;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,4, ref var);
      if (!ret) return null;
      return (System.Single) var;
    }  }

    public bool Get_STS_TENSAO_CN(ref System.Single value)
    {
      if (accessorService == null)
        return false;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,5, ref var);
      if (ret) value = (System.Single) var;
      return ret;
    }

    public System.Single? STS_TENSAO_CN
    { get {
      if (accessorService == null)
        return null;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,5, ref var);
      if (!ret) return null;
      return (System.Single) var;
    }  }

    public bool Get_STS_CORRENTE_A(ref System.Single value)
    {
      if (accessorService == null)
        return false;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,6, ref var);
      if (ret) value = (System.Single) var;
      return ret;
    }

    public System.Single? STS_CORRENTE_A
    { get {
      if (accessorService == null)
        return null;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,6, ref var);
      if (!ret) return null;
      return (System.Single) var;
    }  }

    public bool Get_STS_CORRENTE_B(ref System.Single value)
    {
      if (accessorService == null)
        return false;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,7, ref var);
      if (ret) value = (System.Single) var;
      return ret;
    }

    public System.Single? STS_CORRENTE_B
    { get {
      if (accessorService == null)
        return null;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,7, ref var);
      if (!ret) return null;
      return (System.Single) var;
    }  }

    public bool Get_STS_CORRENTE_C(ref System.Single value)
    {
      if (accessorService == null)
        return false;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,8, ref var);
      if (ret) value = (System.Single) var;
      return ret;
    }

    public System.Single? STS_CORRENTE_C
    { get {
      if (accessorService == null)
        return null;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,8, ref var);
      if (!ret) return null;
      return (System.Single) var;
    }  }

    public bool Get_STS_POTENCIA_ATIVA_A(ref System.Single value)
    {
      if (accessorService == null)
        return false;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,9, ref var);
      if (ret) value = (System.Single) var;
      return ret;
    }

    public System.Single? STS_POTENCIA_ATIVA_A
    { get {
      if (accessorService == null)
        return null;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,9, ref var);
      if (!ret) return null;
      return (System.Single) var;
    }  }

    public bool Get_STS_POTENCIA_ATIVA_B(ref System.Single value)
    {
      if (accessorService == null)
        return false;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,10, ref var);
      if (ret) value = (System.Single) var;
      return ret;
    }

    public System.Single? STS_POTENCIA_ATIVA_B
    { get {
      if (accessorService == null)
        return null;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,10, ref var);
      if (!ret) return null;
      return (System.Single) var;
    }  }

    public bool Get_STS_POTENCIA_ATIVA_C(ref System.Single value)
    {
      if (accessorService == null)
        return false;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,11, ref var);
      if (ret) value = (System.Single) var;
      return ret;
    }

    public System.Single? STS_POTENCIA_ATIVA_C
    { get {
      if (accessorService == null)
        return null;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,11, ref var);
      if (!ret) return null;
      return (System.Single) var;
    }  }

    public bool Get_STS_POTENCIA_ATIVA_TOTAL(ref System.Single value)
    {
      if (accessorService == null)
        return false;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,12, ref var);
      if (ret) value = (System.Single) var;
      return ret;
    }

    public System.Single? STS_POTENCIA_ATIVA_TOTAL
    { get {
      if (accessorService == null)
        return null;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,12, ref var);
      if (!ret) return null;
      return (System.Single) var;
    }  }

    public bool Get_STS_POTENCIA_REATIVA_A(ref System.Single value)
    {
      if (accessorService == null)
        return false;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,13, ref var);
      if (ret) value = (System.Single) var;
      return ret;
    }

    public System.Single? STS_POTENCIA_REATIVA_A
    { get {
      if (accessorService == null)
        return null;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,13, ref var);
      if (!ret) return null;
      return (System.Single) var;
    }  }

    public bool Get_STS_POTENCIA_REATIVA_B(ref System.Single value)
    {
      if (accessorService == null)
        return false;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,14, ref var);
      if (ret) value = (System.Single) var;
      return ret;
    }

    public System.Single? STS_POTENCIA_REATIVA_B
    { get {
      if (accessorService == null)
        return null;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,14, ref var);
      if (!ret) return null;
      return (System.Single) var;
    }  }

    public bool Get_STS_POTENCIA_REATIVA_C(ref System.Single value)
    {
      if (accessorService == null)
        return false;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,15, ref var);
      if (ret) value = (System.Single) var;
      return ret;
    }

    public System.Single? STS_POTENCIA_REATIVA_C
    { get {
      if (accessorService == null)
        return null;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,15, ref var);
      if (!ret) return null;
      return (System.Single) var;
    }  }

    public bool Get_STS_POTENCIA_REATIVA_TOTAL(ref System.Single value)
    {
      if (accessorService == null)
        return false;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,16, ref var);
      if (ret) value = (System.Single) var;
      return ret;
    }

    public System.Single? STS_POTENCIA_REATIVA_TOTAL
    { get {
      if (accessorService == null)
        return null;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,16, ref var);
      if (!ret) return null;
      return (System.Single) var;
    }  }

    public bool Get_STS_POTENCIA_APARENTE_TOTAL(ref System.Single value)
    {
      if (accessorService == null)
        return false;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,17, ref var);
      if (ret) value = (System.Single) var;
      return ret;
    }

    public System.Single? STS_POTENCIA_APARENTE_TOTAL
    { get {
      if (accessorService == null)
        return null;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,17, ref var);
      if (!ret) return null;
      return (System.Single) var;
    }  }

    public bool Get_STS_FATOR_POTENCIAL_TOTAL(ref System.Single value)
    {
      if (accessorService == null)
        return false;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,18, ref var);
      if (ret) value = (System.Single) var;
      return ret;
    }

    public System.Single? STS_FATOR_POTENCIAL_TOTAL
    { get {
      if (accessorService == null)
        return null;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,18, ref var);
      if (!ret) return null;
      return (System.Single) var;
    }  }

    public bool Get_STS_FREQUENCIA(ref System.Single value)
    {
      if (accessorService == null)
        return false;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,19, ref var);
      if (ret) value = (System.Single) var;
      return ret;
    }

    public System.Single? STS_FREQUENCIA
    { get {
      if (accessorService == null)
        return null;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,19, ref var);
      if (!ret) return null;
      return (System.Single) var;
    }  }

    public bool Get_STS_ALARME_FP_BAIXO(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,20, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_ALARME_FP_BAIXO
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,20, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_ALARME_TENSAO_FF_H(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,21, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_ALARME_TENSAO_FF_H
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,21, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_ALARME_TENSAO_FF_L(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,22, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_ALARME_TENSAO_FF_L
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,22, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_ALARME_TENSAO_FN_H(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,23, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_ALARME_TENSAO_FN_H
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,23, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_ALARME_TENSAO_FN_L(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,24, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_ALARME_TENSAO_FN_L
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,24, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_ALARME_CORRENTE_A_H(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,25, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_ALARME_CORRENTE_A_H
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,25, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_ALARME_CORRENTE_B_H(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,26, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_ALARME_CORRENTE_B_H
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,26, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_ALARME_CORRENTE_C_H(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,27, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_ALARME_CORRENTE_C_H
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,27, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_ALARME_CORRENTE_A_L(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,28, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_ALARME_CORRENTE_A_L
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,28, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_ALARME_CORRENTE_B_L(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,29, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_ALARME_CORRENTE_B_L
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,29, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_ALARME_CORRENTE_C_L(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,30, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_ALARME_CORRENTE_C_L
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,30, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_ALARME_FREQUENCIA_H(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,31, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_ALARME_FREQUENCIA_H
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,31, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_ALARME_FREQUENCIA_L(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,32, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_ALARME_FREQUENCIA_L
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,32, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_FALHA_COMUNICACAO(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,33, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_FALHA_COMUNICACAO
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,33, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_ALARME(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,34, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_ALARME
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,34, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_ALM_FP_BAIXO_EST(ref System.Byte value)
    {
      if (accessorService == null)
        return false;
      byte var = 0;
      bool ret = accessorService.GetByteValue(channelId, cookie, eventIndex, true,35, ref var);
      if (ret) value = (System.Byte) var;
      return ret;
    }

    public System.Byte? STS_ALM_FP_BAIXO_EST
    { get {
      if (accessorService == null)
        return null;
      byte var = 0;
      bool ret = accessorService.GetByteValue(channelId, cookie, eventIndex, true,35, ref var);
      if (!ret) return null;
      return (System.Byte) var;
    }  }

    public bool Get_STS_ALM_TENSAO_FF_H_EST(ref System.Byte value)
    {
      if (accessorService == null)
        return false;
      byte var = 0;
      bool ret = accessorService.GetByteValue(channelId, cookie, eventIndex, true,36, ref var);
      if (ret) value = (System.Byte) var;
      return ret;
    }

    public System.Byte? STS_ALM_TENSAO_FF_H_EST
    { get {
      if (accessorService == null)
        return null;
      byte var = 0;
      bool ret = accessorService.GetByteValue(channelId, cookie, eventIndex, true,36, ref var);
      if (!ret) return null;
      return (System.Byte) var;
    }  }

    public bool Get_STS_ALM_TENSAO_FF_L_EST(ref System.Byte value)
    {
      if (accessorService == null)
        return false;
      byte var = 0;
      bool ret = accessorService.GetByteValue(channelId, cookie, eventIndex, true,37, ref var);
      if (ret) value = (System.Byte) var;
      return ret;
    }

    public System.Byte? STS_ALM_TENSAO_FF_L_EST
    { get {
      if (accessorService == null)
        return null;
      byte var = 0;
      bool ret = accessorService.GetByteValue(channelId, cookie, eventIndex, true,37, ref var);
      if (!ret) return null;
      return (System.Byte) var;
    }  }

    public bool Get_STS_ALM_TENSAO_FN_H_EST(ref System.Byte value)
    {
      if (accessorService == null)
        return false;
      byte var = 0;
      bool ret = accessorService.GetByteValue(channelId, cookie, eventIndex, true,38, ref var);
      if (ret) value = (System.Byte) var;
      return ret;
    }

    public System.Byte? STS_ALM_TENSAO_FN_H_EST
    { get {
      if (accessorService == null)
        return null;
      byte var = 0;
      bool ret = accessorService.GetByteValue(channelId, cookie, eventIndex, true,38, ref var);
      if (!ret) return null;
      return (System.Byte) var;
    }  }

    public bool Get_STS_ALM_TENSAO_FN_L_EST(ref System.Byte value)
    {
      if (accessorService == null)
        return false;
      byte var = 0;
      bool ret = accessorService.GetByteValue(channelId, cookie, eventIndex, true,39, ref var);
      if (ret) value = (System.Byte) var;
      return ret;
    }

    public System.Byte? STS_ALM_TENSAO_FN_L_EST
    { get {
      if (accessorService == null)
        return null;
      byte var = 0;
      bool ret = accessorService.GetByteValue(channelId, cookie, eventIndex, true,39, ref var);
      if (!ret) return null;
      return (System.Byte) var;
    }  }

    public bool Get_STS_ALM_CORRENTE_A_H_EST(ref System.Byte value)
    {
      if (accessorService == null)
        return false;
      byte var = 0;
      bool ret = accessorService.GetByteValue(channelId, cookie, eventIndex, true,40, ref var);
      if (ret) value = (System.Byte) var;
      return ret;
    }

    public System.Byte? STS_ALM_CORRENTE_A_H_EST
    { get {
      if (accessorService == null)
        return null;
      byte var = 0;
      bool ret = accessorService.GetByteValue(channelId, cookie, eventIndex, true,40, ref var);
      if (!ret) return null;
      return (System.Byte) var;
    }  }

    public bool Get_STS_ALM_CORRENTE_B_H_EST(ref System.Byte value)
    {
      if (accessorService == null)
        return false;
      byte var = 0;
      bool ret = accessorService.GetByteValue(channelId, cookie, eventIndex, true,41, ref var);
      if (ret) value = (System.Byte) var;
      return ret;
    }

    public System.Byte? STS_ALM_CORRENTE_B_H_EST
    { get {
      if (accessorService == null)
        return null;
      byte var = 0;
      bool ret = accessorService.GetByteValue(channelId, cookie, eventIndex, true,41, ref var);
      if (!ret) return null;
      return (System.Byte) var;
    }  }

    public bool Get_STS_ALM_CORRENTE_C_H_EST(ref System.Byte value)
    {
      if (accessorService == null)
        return false;
      byte var = 0;
      bool ret = accessorService.GetByteValue(channelId, cookie, eventIndex, true,42, ref var);
      if (ret) value = (System.Byte) var;
      return ret;
    }

    public System.Byte? STS_ALM_CORRENTE_C_H_EST
    { get {
      if (accessorService == null)
        return null;
      byte var = 0;
      bool ret = accessorService.GetByteValue(channelId, cookie, eventIndex, true,42, ref var);
      if (!ret) return null;
      return (System.Byte) var;
    }  }

    public bool Get_STS_ALM_CORRENTE_A_L_EST(ref System.Byte value)
    {
      if (accessorService == null)
        return false;
      byte var = 0;
      bool ret = accessorService.GetByteValue(channelId, cookie, eventIndex, true,43, ref var);
      if (ret) value = (System.Byte) var;
      return ret;
    }

    public System.Byte? STS_ALM_CORRENTE_A_L_EST
    { get {
      if (accessorService == null)
        return null;
      byte var = 0;
      bool ret = accessorService.GetByteValue(channelId, cookie, eventIndex, true,43, ref var);
      if (!ret) return null;
      return (System.Byte) var;
    }  }

    public bool Get_STS_ALM_CORRENTE_B_L_EST(ref System.Byte value)
    {
      if (accessorService == null)
        return false;
      byte var = 0;
      bool ret = accessorService.GetByteValue(channelId, cookie, eventIndex, true,44, ref var);
      if (ret) value = (System.Byte) var;
      return ret;
    }

    public System.Byte? STS_ALM_CORRENTE_B_L_EST
    { get {
      if (accessorService == null)
        return null;
      byte var = 0;
      bool ret = accessorService.GetByteValue(channelId, cookie, eventIndex, true,44, ref var);
      if (!ret) return null;
      return (System.Byte) var;
    }  }

    public bool Get_STS_ALM_CORRENTE_C_L_EST(ref System.Byte value)
    {
      if (accessorService == null)
        return false;
      byte var = 0;
      bool ret = accessorService.GetByteValue(channelId, cookie, eventIndex, true,45, ref var);
      if (ret) value = (System.Byte) var;
      return ret;
    }

    public System.Byte? STS_ALM_CORRENTE_C_L_EST
    { get {
      if (accessorService == null)
        return null;
      byte var = 0;
      bool ret = accessorService.GetByteValue(channelId, cookie, eventIndex, true,45, ref var);
      if (!ret) return null;
      return (System.Byte) var;
    }  }

    public bool Get_STS_ALM_FREQUENCIA_H_EST(ref System.Byte value)
    {
      if (accessorService == null)
        return false;
      byte var = 0;
      bool ret = accessorService.GetByteValue(channelId, cookie, eventIndex, true,46, ref var);
      if (ret) value = (System.Byte) var;
      return ret;
    }

    public System.Byte? STS_ALM_FREQUENCIA_H_EST
    { get {
      if (accessorService == null)
        return null;
      byte var = 0;
      bool ret = accessorService.GetByteValue(channelId, cookie, eventIndex, true,46, ref var);
      if (!ret) return null;
      return (System.Byte) var;
    }  }

    public bool Get_STS_ALM_FREQUENCIA_L_EST(ref System.Byte value)
    {
      if (accessorService == null)
        return false;
      byte var = 0;
      bool ret = accessorService.GetByteValue(channelId, cookie, eventIndex, true,47, ref var);
      if (ret) value = (System.Byte) var;
      return ret;
    }

    public System.Byte? STS_ALM_FREQUENCIA_L_EST
    { get {
      if (accessorService == null)
        return null;
      byte var = 0;
      bool ret = accessorService.GetByteValue(channelId, cookie, eventIndex, true,47, ref var);
      if (!ret) return null;
      return (System.Byte) var;
    }  }

    public bool Get_STS_ALM_COMUNICACAO_EST(ref System.Byte value)
    {
      if (accessorService == null)
        return false;
      byte var = 0;
      bool ret = accessorService.GetByteValue(channelId, cookie, eventIndex, true,48, ref var);
      if (ret) value = (System.Byte) var;
      return ret;
    }

    public System.Byte? STS_ALM_COMUNICACAO_EST
    { get {
      if (accessorService == null)
        return null;
      byte var = 0;
      bool ret = accessorService.GetByteValue(channelId, cookie, eventIndex, true,48, ref var);
      if (!ret) return null;
      return (System.Byte) var;
    }  }


  }

}

namespace Hidryco.HidrycoLib.Symbols.MGE_Generico
{

  public class E_PARAMETROSEventArgs : System.EventArgs
  {
    public E_PARAMETROSEventArgs()
    {
    }
    private System.Single? STP_FP_BAIXO_field = null;
    public System.Single? STP_FP_BAIXO
    {
       get { return STP_FP_BAIXO_field; }
       set { STP_FP_BAIXO_field = value; }
    }
    private System.Single? STP_TENSAO_FF_H_field = null;
    public System.Single? STP_TENSAO_FF_H
    {
       get { return STP_TENSAO_FF_H_field; }
       set { STP_TENSAO_FF_H_field = value; }
    }
    private System.Single? STP_TENSAO_FF_L_field = null;
    public System.Single? STP_TENSAO_FF_L
    {
       get { return STP_TENSAO_FF_L_field; }
       set { STP_TENSAO_FF_L_field = value; }
    }
    private System.Single? STP_TENSAO_FN_H_field = null;
    public System.Single? STP_TENSAO_FN_H
    {
       get { return STP_TENSAO_FN_H_field; }
       set { STP_TENSAO_FN_H_field = value; }
    }
    private System.Single? STP_TENSAO_FN_L_field = null;
    public System.Single? STP_TENSAO_FN_L
    {
       get { return STP_TENSAO_FN_L_field; }
       set { STP_TENSAO_FN_L_field = value; }
    }
    private System.Single? STP_CORRENTE_H_field = null;
    public System.Single? STP_CORRENTE_H
    {
       get { return STP_CORRENTE_H_field; }
       set { STP_CORRENTE_H_field = value; }
    }
    private System.Single? STP_CORRENTE_L_field = null;
    public System.Single? STP_CORRENTE_L
    {
       get { return STP_CORRENTE_L_field; }
       set { STP_CORRENTE_L_field = value; }
    }
    private System.Single? STP_FREQUENCIA_H_field = null;
    public System.Single? STP_FREQUENCIA_H
    {
       get { return STP_FREQUENCIA_H_field; }
       set { STP_FREQUENCIA_H_field = value; }
    }
    private System.Single? STP_FREQUENCIA_L_field = null;
    public System.Single? STP_FREQUENCIA_L
    {
       get { return STP_FREQUENCIA_L_field; }
       set { STP_FREQUENCIA_L_field = value; }
    }
    private System.UInt16? STP_TEMPO_FP_field = null;
    public System.UInt16? STP_TEMPO_FP
    {
       get { return STP_TEMPO_FP_field; }
       set { STP_TEMPO_FP_field = value; }
    }
    private System.UInt16? STP_TEMPO_TENSAO_field = null;
    public System.UInt16? STP_TEMPO_TENSAO
    {
       get { return STP_TEMPO_TENSAO_field; }
       set { STP_TEMPO_TENSAO_field = value; }
    }
    private System.UInt16? STP_TEMPO_CORRENTE_field = null;
    public System.UInt16? STP_TEMPO_CORRENTE
    {
       get { return STP_TEMPO_CORRENTE_field; }
       set { STP_TEMPO_CORRENTE_field = value; }
    }
    private System.UInt16? STP_TEMPO_FREQUENCIA_field = null;
    public System.UInt16? STP_TEMPO_FREQUENCIA
    {
       get { return STP_TEMPO_FREQUENCIA_field; }
       set { STP_TEMPO_FREQUENCIA_field = value; }
    }

  }

  public class E_RESETEventArgs : System.EventArgs
  {
    public E_RESETEventArgs()
    {
    }
    private System.Boolean? CMD_RESET_field = null;
    public System.Boolean? CMD_RESET
    {
       get { return CMD_RESET_field; }
       set { CMD_RESET_field = value; }
    }

  }

}

namespace Hidryco.HidrycoLib.Symbols.MGE_Generico
{
  partial class sDefault
  {

    private event EventHandler<Hidryco.HidrycoLib.Symbols.MGE_Generico.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    private event EventHandler<Hidryco.HidrycoLib.Symbols.MGE_Generico.REQEventArgs> REQ_Fired;

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
              LOAD_PERS_DATA_Fired(this, new Hidryco.HidrycoLib.Symbols.MGE_Generico.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
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
              REQ_Fired(this, new Hidryco.HidrycoLib.Symbols.MGE_Generico.REQEventArgs(channelId, cookie, eventIndex));
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
    public bool FireEvent_E_PARAMETROS(System.Single STP_FP_BAIXO, System.Single STP_TENSAO_FF_H, System.Single STP_TENSAO_FF_L, System.Single STP_TENSAO_FN_H, System.Single STP_TENSAO_FN_L, System.Single STP_CORRENTE_H, System.Single STP_CORRENTE_L, System.Single STP_FREQUENCIA_H, System.Single STP_FREQUENCIA_L, System.UInt16 STP_TEMPO_FP, System.UInt16 STP_TEMPO_TENSAO, System.UInt16 STP_TEMPO_CORRENTE, System.UInt16 STP_TEMPO_FREQUENCIA)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {STP_FP_BAIXO, STP_TENSAO_FF_H, STP_TENSAO_FF_L, STP_TENSAO_FN_H, STP_TENSAO_FN_L, STP_CORRENTE_H, STP_CORRENTE_L, STP_FREQUENCIA_H, STP_FREQUENCIA_L, STP_TEMPO_FP, STP_TEMPO_TENSAO, STP_TEMPO_CORRENTE, STP_TEMPO_FREQUENCIA});
    }
    public bool FireEvent_E_PARAMETROS(Hidryco.HidrycoLib.Symbols.MGE_Generico.E_PARAMETROSEventArgs ea)
    {
      object[] _values_ = new object[13];
      if (ea.STP_FP_BAIXO.HasValue) _values_[0] = ea.STP_FP_BAIXO.Value;
      if (ea.STP_TENSAO_FF_H.HasValue) _values_[1] = ea.STP_TENSAO_FF_H.Value;
      if (ea.STP_TENSAO_FF_L.HasValue) _values_[2] = ea.STP_TENSAO_FF_L.Value;
      if (ea.STP_TENSAO_FN_H.HasValue) _values_[3] = ea.STP_TENSAO_FN_H.Value;
      if (ea.STP_TENSAO_FN_L.HasValue) _values_[4] = ea.STP_TENSAO_FN_L.Value;
      if (ea.STP_CORRENTE_H.HasValue) _values_[5] = ea.STP_CORRENTE_H.Value;
      if (ea.STP_CORRENTE_L.HasValue) _values_[6] = ea.STP_CORRENTE_L.Value;
      if (ea.STP_FREQUENCIA_H.HasValue) _values_[7] = ea.STP_FREQUENCIA_H.Value;
      if (ea.STP_FREQUENCIA_L.HasValue) _values_[8] = ea.STP_FREQUENCIA_L.Value;
      if (ea.STP_TEMPO_FP.HasValue) _values_[9] = ea.STP_TEMPO_FP.Value;
      if (ea.STP_TEMPO_TENSAO.HasValue) _values_[10] = ea.STP_TEMPO_TENSAO.Value;
      if (ea.STP_TEMPO_CORRENTE.HasValue) _values_[11] = ea.STP_TEMPO_CORRENTE.Value;
      if (ea.STP_TEMPO_FREQUENCIA.HasValue) _values_[12] = ea.STP_TEMPO_FREQUENCIA.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_E_PARAMETROS(System.Single STP_FP_BAIXO, bool ignore_STP_FP_BAIXO, System.Single STP_TENSAO_FF_H, bool ignore_STP_TENSAO_FF_H, System.Single STP_TENSAO_FF_L, bool ignore_STP_TENSAO_FF_L, System.Single STP_TENSAO_FN_H, bool ignore_STP_TENSAO_FN_H, System.Single STP_TENSAO_FN_L, bool ignore_STP_TENSAO_FN_L, System.Single STP_CORRENTE_H, bool ignore_STP_CORRENTE_H, System.Single STP_CORRENTE_L, bool ignore_STP_CORRENTE_L, System.Single STP_FREQUENCIA_H, bool ignore_STP_FREQUENCIA_H, System.Single STP_FREQUENCIA_L, bool ignore_STP_FREQUENCIA_L, System.UInt16 STP_TEMPO_FP, bool ignore_STP_TEMPO_FP, System.UInt16 STP_TEMPO_TENSAO, bool ignore_STP_TEMPO_TENSAO, System.UInt16 STP_TEMPO_CORRENTE, bool ignore_STP_TEMPO_CORRENTE, System.UInt16 STP_TEMPO_FREQUENCIA, bool ignore_STP_TEMPO_FREQUENCIA)
    {
      object[] _values_ = new object[13];
      if (!ignore_STP_FP_BAIXO) _values_[0] = STP_FP_BAIXO;
      if (!ignore_STP_TENSAO_FF_H) _values_[1] = STP_TENSAO_FF_H;
      if (!ignore_STP_TENSAO_FF_L) _values_[2] = STP_TENSAO_FF_L;
      if (!ignore_STP_TENSAO_FN_H) _values_[3] = STP_TENSAO_FN_H;
      if (!ignore_STP_TENSAO_FN_L) _values_[4] = STP_TENSAO_FN_L;
      if (!ignore_STP_CORRENTE_H) _values_[5] = STP_CORRENTE_H;
      if (!ignore_STP_CORRENTE_L) _values_[6] = STP_CORRENTE_L;
      if (!ignore_STP_FREQUENCIA_H) _values_[7] = STP_FREQUENCIA_H;
      if (!ignore_STP_FREQUENCIA_L) _values_[8] = STP_FREQUENCIA_L;
      if (!ignore_STP_TEMPO_FP) _values_[9] = STP_TEMPO_FP;
      if (!ignore_STP_TEMPO_TENSAO) _values_[10] = STP_TEMPO_TENSAO;
      if (!ignore_STP_TEMPO_CORRENTE) _values_[11] = STP_TEMPO_CORRENTE;
      if (!ignore_STP_TEMPO_FREQUENCIA) _values_[12] = STP_TEMPO_FREQUENCIA;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_E_RESET(System.Boolean CMD_RESET)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {CMD_RESET});
    }
    public bool FireEvent_E_RESET(Hidryco.HidrycoLib.Symbols.MGE_Generico.E_RESETEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.CMD_RESET.HasValue) _values_[0] = ea.CMD_RESET.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_E_RESET(System.Boolean CMD_RESET, bool ignore_CMD_RESET)
    {
      object[] _values_ = new object[1];
      if (!ignore_CMD_RESET) _values_[0] = CMD_RESET;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }

  }
}

namespace Hidryco.HidrycoLib.Faceplates.MGE_Generico
{
  partial class fpDefault
  {

    private event EventHandler<Hidryco.HidrycoLib.Symbols.MGE_Generico.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    private event EventHandler<Hidryco.HidrycoLib.Symbols.MGE_Generico.REQEventArgs> REQ_Fired;

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
              LOAD_PERS_DATA_Fired(this, new Hidryco.HidrycoLib.Symbols.MGE_Generico.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
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
              REQ_Fired(this, new Hidryco.HidrycoLib.Symbols.MGE_Generico.REQEventArgs(channelId, cookie, eventIndex));
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
    public bool FireEvent_E_PARAMETROS(System.Single STP_FP_BAIXO, System.Single STP_TENSAO_FF_H, System.Single STP_TENSAO_FF_L, System.Single STP_TENSAO_FN_H, System.Single STP_TENSAO_FN_L, System.Single STP_CORRENTE_H, System.Single STP_CORRENTE_L, System.Single STP_FREQUENCIA_H, System.Single STP_FREQUENCIA_L, System.UInt16 STP_TEMPO_FP, System.UInt16 STP_TEMPO_TENSAO, System.UInt16 STP_TEMPO_CORRENTE, System.UInt16 STP_TEMPO_FREQUENCIA)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {STP_FP_BAIXO, STP_TENSAO_FF_H, STP_TENSAO_FF_L, STP_TENSAO_FN_H, STP_TENSAO_FN_L, STP_CORRENTE_H, STP_CORRENTE_L, STP_FREQUENCIA_H, STP_FREQUENCIA_L, STP_TEMPO_FP, STP_TEMPO_TENSAO, STP_TEMPO_CORRENTE, STP_TEMPO_FREQUENCIA});
    }
    public bool FireEvent_E_PARAMETROS(Hidryco.HidrycoLib.Symbols.MGE_Generico.E_PARAMETROSEventArgs ea)
    {
      object[] _values_ = new object[13];
      if (ea.STP_FP_BAIXO.HasValue) _values_[0] = ea.STP_FP_BAIXO.Value;
      if (ea.STP_TENSAO_FF_H.HasValue) _values_[1] = ea.STP_TENSAO_FF_H.Value;
      if (ea.STP_TENSAO_FF_L.HasValue) _values_[2] = ea.STP_TENSAO_FF_L.Value;
      if (ea.STP_TENSAO_FN_H.HasValue) _values_[3] = ea.STP_TENSAO_FN_H.Value;
      if (ea.STP_TENSAO_FN_L.HasValue) _values_[4] = ea.STP_TENSAO_FN_L.Value;
      if (ea.STP_CORRENTE_H.HasValue) _values_[5] = ea.STP_CORRENTE_H.Value;
      if (ea.STP_CORRENTE_L.HasValue) _values_[6] = ea.STP_CORRENTE_L.Value;
      if (ea.STP_FREQUENCIA_H.HasValue) _values_[7] = ea.STP_FREQUENCIA_H.Value;
      if (ea.STP_FREQUENCIA_L.HasValue) _values_[8] = ea.STP_FREQUENCIA_L.Value;
      if (ea.STP_TEMPO_FP.HasValue) _values_[9] = ea.STP_TEMPO_FP.Value;
      if (ea.STP_TEMPO_TENSAO.HasValue) _values_[10] = ea.STP_TEMPO_TENSAO.Value;
      if (ea.STP_TEMPO_CORRENTE.HasValue) _values_[11] = ea.STP_TEMPO_CORRENTE.Value;
      if (ea.STP_TEMPO_FREQUENCIA.HasValue) _values_[12] = ea.STP_TEMPO_FREQUENCIA.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_E_PARAMETROS(System.Single STP_FP_BAIXO, bool ignore_STP_FP_BAIXO, System.Single STP_TENSAO_FF_H, bool ignore_STP_TENSAO_FF_H, System.Single STP_TENSAO_FF_L, bool ignore_STP_TENSAO_FF_L, System.Single STP_TENSAO_FN_H, bool ignore_STP_TENSAO_FN_H, System.Single STP_TENSAO_FN_L, bool ignore_STP_TENSAO_FN_L, System.Single STP_CORRENTE_H, bool ignore_STP_CORRENTE_H, System.Single STP_CORRENTE_L, bool ignore_STP_CORRENTE_L, System.Single STP_FREQUENCIA_H, bool ignore_STP_FREQUENCIA_H, System.Single STP_FREQUENCIA_L, bool ignore_STP_FREQUENCIA_L, System.UInt16 STP_TEMPO_FP, bool ignore_STP_TEMPO_FP, System.UInt16 STP_TEMPO_TENSAO, bool ignore_STP_TEMPO_TENSAO, System.UInt16 STP_TEMPO_CORRENTE, bool ignore_STP_TEMPO_CORRENTE, System.UInt16 STP_TEMPO_FREQUENCIA, bool ignore_STP_TEMPO_FREQUENCIA)
    {
      object[] _values_ = new object[13];
      if (!ignore_STP_FP_BAIXO) _values_[0] = STP_FP_BAIXO;
      if (!ignore_STP_TENSAO_FF_H) _values_[1] = STP_TENSAO_FF_H;
      if (!ignore_STP_TENSAO_FF_L) _values_[2] = STP_TENSAO_FF_L;
      if (!ignore_STP_TENSAO_FN_H) _values_[3] = STP_TENSAO_FN_H;
      if (!ignore_STP_TENSAO_FN_L) _values_[4] = STP_TENSAO_FN_L;
      if (!ignore_STP_CORRENTE_H) _values_[5] = STP_CORRENTE_H;
      if (!ignore_STP_CORRENTE_L) _values_[6] = STP_CORRENTE_L;
      if (!ignore_STP_FREQUENCIA_H) _values_[7] = STP_FREQUENCIA_H;
      if (!ignore_STP_FREQUENCIA_L) _values_[8] = STP_FREQUENCIA_L;
      if (!ignore_STP_TEMPO_FP) _values_[9] = STP_TEMPO_FP;
      if (!ignore_STP_TEMPO_TENSAO) _values_[10] = STP_TEMPO_TENSAO;
      if (!ignore_STP_TEMPO_CORRENTE) _values_[11] = STP_TEMPO_CORRENTE;
      if (!ignore_STP_TEMPO_FREQUENCIA) _values_[12] = STP_TEMPO_FREQUENCIA;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_E_RESET(System.Boolean CMD_RESET)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {CMD_RESET});
    }
    public bool FireEvent_E_RESET(Hidryco.HidrycoLib.Symbols.MGE_Generico.E_RESETEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.CMD_RESET.HasValue) _values_[0] = ea.CMD_RESET.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_E_RESET(System.Boolean CMD_RESET, bool ignore_CMD_RESET)
    {
      object[] _values_ = new object[1];
      if (!ignore_CMD_RESET) _values_[0] = CMD_RESET;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }

  }
}

namespace Hidryco.HidrycoLib.Faceplates.MGE_Generico
{
  partial class fpParameter
  {

    private event EventHandler<Hidryco.HidrycoLib.Symbols.MGE_Generico.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    private event EventHandler<Hidryco.HidrycoLib.Symbols.MGE_Generico.REQEventArgs> REQ_Fired;

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
              LOAD_PERS_DATA_Fired(this, new Hidryco.HidrycoLib.Symbols.MGE_Generico.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
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
              REQ_Fired(this, new Hidryco.HidrycoLib.Symbols.MGE_Generico.REQEventArgs(channelId, cookie, eventIndex));
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
    public bool FireEvent_E_PARAMETROS(System.Single STP_FP_BAIXO, System.Single STP_TENSAO_FF_H, System.Single STP_TENSAO_FF_L, System.Single STP_TENSAO_FN_H, System.Single STP_TENSAO_FN_L, System.Single STP_CORRENTE_H, System.Single STP_CORRENTE_L, System.Single STP_FREQUENCIA_H, System.Single STP_FREQUENCIA_L, System.UInt16 STP_TEMPO_FP, System.UInt16 STP_TEMPO_TENSAO, System.UInt16 STP_TEMPO_CORRENTE, System.UInt16 STP_TEMPO_FREQUENCIA)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {STP_FP_BAIXO, STP_TENSAO_FF_H, STP_TENSAO_FF_L, STP_TENSAO_FN_H, STP_TENSAO_FN_L, STP_CORRENTE_H, STP_CORRENTE_L, STP_FREQUENCIA_H, STP_FREQUENCIA_L, STP_TEMPO_FP, STP_TEMPO_TENSAO, STP_TEMPO_CORRENTE, STP_TEMPO_FREQUENCIA});
    }
    public bool FireEvent_E_PARAMETROS(Hidryco.HidrycoLib.Symbols.MGE_Generico.E_PARAMETROSEventArgs ea)
    {
      object[] _values_ = new object[13];
      if (ea.STP_FP_BAIXO.HasValue) _values_[0] = ea.STP_FP_BAIXO.Value;
      if (ea.STP_TENSAO_FF_H.HasValue) _values_[1] = ea.STP_TENSAO_FF_H.Value;
      if (ea.STP_TENSAO_FF_L.HasValue) _values_[2] = ea.STP_TENSAO_FF_L.Value;
      if (ea.STP_TENSAO_FN_H.HasValue) _values_[3] = ea.STP_TENSAO_FN_H.Value;
      if (ea.STP_TENSAO_FN_L.HasValue) _values_[4] = ea.STP_TENSAO_FN_L.Value;
      if (ea.STP_CORRENTE_H.HasValue) _values_[5] = ea.STP_CORRENTE_H.Value;
      if (ea.STP_CORRENTE_L.HasValue) _values_[6] = ea.STP_CORRENTE_L.Value;
      if (ea.STP_FREQUENCIA_H.HasValue) _values_[7] = ea.STP_FREQUENCIA_H.Value;
      if (ea.STP_FREQUENCIA_L.HasValue) _values_[8] = ea.STP_FREQUENCIA_L.Value;
      if (ea.STP_TEMPO_FP.HasValue) _values_[9] = ea.STP_TEMPO_FP.Value;
      if (ea.STP_TEMPO_TENSAO.HasValue) _values_[10] = ea.STP_TEMPO_TENSAO.Value;
      if (ea.STP_TEMPO_CORRENTE.HasValue) _values_[11] = ea.STP_TEMPO_CORRENTE.Value;
      if (ea.STP_TEMPO_FREQUENCIA.HasValue) _values_[12] = ea.STP_TEMPO_FREQUENCIA.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_E_PARAMETROS(System.Single STP_FP_BAIXO, bool ignore_STP_FP_BAIXO, System.Single STP_TENSAO_FF_H, bool ignore_STP_TENSAO_FF_H, System.Single STP_TENSAO_FF_L, bool ignore_STP_TENSAO_FF_L, System.Single STP_TENSAO_FN_H, bool ignore_STP_TENSAO_FN_H, System.Single STP_TENSAO_FN_L, bool ignore_STP_TENSAO_FN_L, System.Single STP_CORRENTE_H, bool ignore_STP_CORRENTE_H, System.Single STP_CORRENTE_L, bool ignore_STP_CORRENTE_L, System.Single STP_FREQUENCIA_H, bool ignore_STP_FREQUENCIA_H, System.Single STP_FREQUENCIA_L, bool ignore_STP_FREQUENCIA_L, System.UInt16 STP_TEMPO_FP, bool ignore_STP_TEMPO_FP, System.UInt16 STP_TEMPO_TENSAO, bool ignore_STP_TEMPO_TENSAO, System.UInt16 STP_TEMPO_CORRENTE, bool ignore_STP_TEMPO_CORRENTE, System.UInt16 STP_TEMPO_FREQUENCIA, bool ignore_STP_TEMPO_FREQUENCIA)
    {
      object[] _values_ = new object[13];
      if (!ignore_STP_FP_BAIXO) _values_[0] = STP_FP_BAIXO;
      if (!ignore_STP_TENSAO_FF_H) _values_[1] = STP_TENSAO_FF_H;
      if (!ignore_STP_TENSAO_FF_L) _values_[2] = STP_TENSAO_FF_L;
      if (!ignore_STP_TENSAO_FN_H) _values_[3] = STP_TENSAO_FN_H;
      if (!ignore_STP_TENSAO_FN_L) _values_[4] = STP_TENSAO_FN_L;
      if (!ignore_STP_CORRENTE_H) _values_[5] = STP_CORRENTE_H;
      if (!ignore_STP_CORRENTE_L) _values_[6] = STP_CORRENTE_L;
      if (!ignore_STP_FREQUENCIA_H) _values_[7] = STP_FREQUENCIA_H;
      if (!ignore_STP_FREQUENCIA_L) _values_[8] = STP_FREQUENCIA_L;
      if (!ignore_STP_TEMPO_FP) _values_[9] = STP_TEMPO_FP;
      if (!ignore_STP_TEMPO_TENSAO) _values_[10] = STP_TEMPO_TENSAO;
      if (!ignore_STP_TEMPO_CORRENTE) _values_[11] = STP_TEMPO_CORRENTE;
      if (!ignore_STP_TEMPO_FREQUENCIA) _values_[12] = STP_TEMPO_FREQUENCIA;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_E_RESET(System.Boolean CMD_RESET)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {CMD_RESET});
    }
    public bool FireEvent_E_RESET(Hidryco.HidrycoLib.Symbols.MGE_Generico.E_RESETEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.CMD_RESET.HasValue) _values_[0] = ea.CMD_RESET.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_E_RESET(System.Boolean CMD_RESET, bool ignore_CMD_RESET)
    {
      object[] _values_ = new object[1];
      if (!ignore_CMD_RESET) _values_[0] = CMD_RESET;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }

  }
}
#endregion #MGE_Generico_HMI;

#endregion Definitions;
