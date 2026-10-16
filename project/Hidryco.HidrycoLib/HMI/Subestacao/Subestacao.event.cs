/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 10/15/2026
 * Time: 3:00 PM
 * 
 */
using System;
using NxtControl.GuiFramework;
using NxtControl.Services;

#region Definitions;
#region #Subestacao_HMI;

namespace Hidryco.HidrycoLib.Symbols.Subestacao
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
    public bool Get_DJ_RES_A1(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,0, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? DJ_RES_A1
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,0, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_DJ_RES_A2(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,1, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? DJ_RES_A2
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,1, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_DJ_PCM_EEE_BRUTO(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,2, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? DJ_PCM_EEE_BRUTO
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,2, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_DJ_PCM_DESINFECCAO(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,3, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? DJ_PCM_DESINFECCAO
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,3, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_DJ_QGBT_220V(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,4, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? DJ_QGBT_220V
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,4, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_DJ_UCT_200_01(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,5, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? DJ_UCT_200_01
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,5, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_DJ_COMP_500_02(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,6, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? DJ_COMP_500_02
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,6, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_DJ_V4603(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,7, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? DJ_V4603
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,7, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_DJ_V4604(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,8, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? DJ_V4604
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,8, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_DJ_BANCO_CAPACITORES(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,9, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? DJ_BANCO_CAPACITORES
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,9, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_DJ_PCE_SUBESTACAO(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,10, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? DJ_PCE_SUBESTACAO
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,10, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_DJ_COMP_500_01(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,11, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? DJ_COMP_500_01
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,11, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_DJ_UCT_200_02(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,12, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? DJ_UCT_200_02
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,12, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_DJ_UCT_200_03(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,13, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? DJ_UCT_200_03
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,13, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_DJ_PCM_NEREDA(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,14, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? DJ_PCM_NEREDA
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,14, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_DJ_PCM_LODO(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,15, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? DJ_PCM_LODO
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,15, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_DJ_CAP2(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,16, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? DJ_CAP2
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,16, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_DJ_PCM_AGUA_REUSO(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,17, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? DJ_PCM_AGUA_REUSO
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,17, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_DJ_MO_500_01(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,18, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? DJ_MO_500_01
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,18, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_DJ_V4601(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,19, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? DJ_V4601
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,19, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_DJ_V4602(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,20, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? DJ_V4602
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,20, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_DJ_RES_B1(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,21, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? DJ_RES_B1
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,21, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_DJ_RES_B2(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,22, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? DJ_RES_B2
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,22, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_DJ_RES_B3(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,23, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? DJ_RES_B3
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,23, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_DJ_QGBT_220V_ENTRADA(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,24, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? DJ_QGBT_220V_ENTRADA
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,24, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_DJ_QL_ADM(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,25, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? DJ_QL_ADM
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,25, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_DJ_QL_PORTARIA(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,26, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? DJ_QL_PORTARIA
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,26, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_DJ_QLSL(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,27, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? DJ_QLSL
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,27, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_DJ_QL_ILUMINACAO(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,28, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? DJ_QL_ILUMINACAO
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,28, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_DJ_PCE_SOPRADORES(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,29, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? DJ_PCE_SOPRADORES
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,29, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_DJ_QL_LODO(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,30, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? DJ_QL_LODO
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,30, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_DJ_RES_C1(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,31, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? DJ_RES_C1
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,31, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_DJ_RES_C2(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,32, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? DJ_RES_C2
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,32, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_DJ_RES_C3(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,33, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? DJ_RES_C3
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,33, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_DJ_RES_C4(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,34, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? DJ_RES_C4
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,34, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_DJ_RES_C5(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,35, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? DJ_RES_C5
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,35, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_DJ_RES_C6(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,36, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? DJ_RES_C6
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,36, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_MPL_1Q1(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,37, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? MPL_1Q1
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,37, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_MPR_1Q1(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,38, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? MPR_1Q1
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,38, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_MPP_1Q1(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,39, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? MPP_1Q1
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,39, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_MPC_1Q1(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,40, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? MPC_1Q1
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,40, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_MPSF_1Q1(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,41, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? MPSF_1Q1
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,41, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_MPL_1Q0(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,42, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? MPL_1Q0
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,42, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_MPR_1Q0(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,43, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? MPR_1Q0
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,43, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_MPP_1Q0(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,44, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? MPP_1Q0
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,44, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_MPC_1Q0(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,45, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? MPC_1Q0
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,45, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_MPSF_1Q0(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,46, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? MPSF_1Q0
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,46, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_MPL_1Q2(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,47, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? MPL_1Q2
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,47, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_MPR_1Q2(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,48, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? MPR_1Q2
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,48, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_MPP_1Q2(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,49, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? MPP_1Q2
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,49, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_MPC_1Q2(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,50, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? MPC_1Q2
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,50, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_MPSF_1Q2(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,51, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? MPSF_1Q2
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,51, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_EST_1Q1(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,52, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? EST_1Q1
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,52, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }

    public bool Get_EST_1Q0(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,53, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? EST_1Q0
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,53, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }

    public bool Get_EST_1Q2(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,54, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? EST_1Q2
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,54, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }

    public bool Get_FONTE_BARRA_A(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,55, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? FONTE_BARRA_A
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,55, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }

    public bool Get_FONTE_BARRA_B(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,56, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? FONTE_BARRA_B
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,56, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }

    public bool Get_PLANTA_NO_GERADOR(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,57, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? PLANTA_NO_GERADOR
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,57, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_FALHA_REMOTA1(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,58, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? FALHA_REMOTA1
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,58, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_QTAM1_DISJ_GERADOR(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,59, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? QTAM1_DISJ_GERADOR
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,59, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }

    public bool Get_QTAM2_DISJ_GERADOR(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,60, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? QTAM2_DISJ_GERADOR
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,60, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }

    public bool Get_QTAM1_DISJ_REDE(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,61, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? QTAM1_DISJ_REDE
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,61, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }

    public bool Get_QTAM2_DISJ_REDE(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,62, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? QTAM2_DISJ_REDE
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,62, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }

    public bool Get_STS_FALHA_1Q1(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,63, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_FALHA_1Q1
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,63, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_FALHA_1Q0(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,64, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_FALHA_1Q0
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,64, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_FALHA_1Q2(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,65, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_FALHA_1Q2
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,65, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_DISCORDANCIA_1Q1(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,66, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_DISCORDANCIA_1Q1
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,66, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_DISCORDANCIA_1Q0(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,67, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_DISCORDANCIA_1Q0
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,67, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_DISCORDANCIA_1Q2(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,68, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_DISCORDANCIA_1Q2
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,68, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_SEM_RESPOSTA_1Q1(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,69, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_SEM_RESPOSTA_1Q1
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,69, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_SEM_RESPOSTA_1Q0(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,70, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_SEM_RESPOSTA_1Q0
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,70, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_SEM_RESPOSTA_1Q2(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,71, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_SEM_RESPOSTA_1Q2
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,71, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_ALARME(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,72, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_ALARME
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,72, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_ALM_FALHA_1Q1_EST(ref System.Byte value)
    {
      if (accessorService == null)
        return false;
      byte var = 0;
      bool ret = accessorService.GetByteValue(channelId, cookie, eventIndex, true,73, ref var);
      if (ret) value = (System.Byte) var;
      return ret;
    }

    public System.Byte? STS_ALM_FALHA_1Q1_EST
    { get {
      if (accessorService == null)
        return null;
      byte var = 0;
      bool ret = accessorService.GetByteValue(channelId, cookie, eventIndex, true,73, ref var);
      if (!ret) return null;
      return (System.Byte) var;
    }  }

    public bool Get_STS_ALM_FALHA_1Q0_EST(ref System.Byte value)
    {
      if (accessorService == null)
        return false;
      byte var = 0;
      bool ret = accessorService.GetByteValue(channelId, cookie, eventIndex, true,74, ref var);
      if (ret) value = (System.Byte) var;
      return ret;
    }

    public System.Byte? STS_ALM_FALHA_1Q0_EST
    { get {
      if (accessorService == null)
        return null;
      byte var = 0;
      bool ret = accessorService.GetByteValue(channelId, cookie, eventIndex, true,74, ref var);
      if (!ret) return null;
      return (System.Byte) var;
    }  }

    public bool Get_STS_ALM_FALHA_1Q2_EST(ref System.Byte value)
    {
      if (accessorService == null)
        return false;
      byte var = 0;
      bool ret = accessorService.GetByteValue(channelId, cookie, eventIndex, true,75, ref var);
      if (ret) value = (System.Byte) var;
      return ret;
    }

    public System.Byte? STS_ALM_FALHA_1Q2_EST
    { get {
      if (accessorService == null)
        return null;
      byte var = 0;
      bool ret = accessorService.GetByteValue(channelId, cookie, eventIndex, true,75, ref var);
      if (!ret) return null;
      return (System.Byte) var;
    }  }

    public bool Get_STS_ALM_DISCORDANCIA_1Q1_EST(ref System.Byte value)
    {
      if (accessorService == null)
        return false;
      byte var = 0;
      bool ret = accessorService.GetByteValue(channelId, cookie, eventIndex, true,76, ref var);
      if (ret) value = (System.Byte) var;
      return ret;
    }

    public System.Byte? STS_ALM_DISCORDANCIA_1Q1_EST
    { get {
      if (accessorService == null)
        return null;
      byte var = 0;
      bool ret = accessorService.GetByteValue(channelId, cookie, eventIndex, true,76, ref var);
      if (!ret) return null;
      return (System.Byte) var;
    }  }

    public bool Get_STS_ALM_DISCORDANCIA_1Q0_EST(ref System.Byte value)
    {
      if (accessorService == null)
        return false;
      byte var = 0;
      bool ret = accessorService.GetByteValue(channelId, cookie, eventIndex, true,77, ref var);
      if (ret) value = (System.Byte) var;
      return ret;
    }

    public System.Byte? STS_ALM_DISCORDANCIA_1Q0_EST
    { get {
      if (accessorService == null)
        return null;
      byte var = 0;
      bool ret = accessorService.GetByteValue(channelId, cookie, eventIndex, true,77, ref var);
      if (!ret) return null;
      return (System.Byte) var;
    }  }

    public bool Get_STS_ALM_DISCORDANCIA_1Q2_EST(ref System.Byte value)
    {
      if (accessorService == null)
        return false;
      byte var = 0;
      bool ret = accessorService.GetByteValue(channelId, cookie, eventIndex, true,78, ref var);
      if (ret) value = (System.Byte) var;
      return ret;
    }

    public System.Byte? STS_ALM_DISCORDANCIA_1Q2_EST
    { get {
      if (accessorService == null)
        return null;
      byte var = 0;
      bool ret = accessorService.GetByteValue(channelId, cookie, eventIndex, true,78, ref var);
      if (!ret) return null;
      return (System.Byte) var;
    }  }

    public bool Get_STS_ALM_SEM_RESPOSTA_1Q1_EST(ref System.Byte value)
    {
      if (accessorService == null)
        return false;
      byte var = 0;
      bool ret = accessorService.GetByteValue(channelId, cookie, eventIndex, true,79, ref var);
      if (ret) value = (System.Byte) var;
      return ret;
    }

    public System.Byte? STS_ALM_SEM_RESPOSTA_1Q1_EST
    { get {
      if (accessorService == null)
        return null;
      byte var = 0;
      bool ret = accessorService.GetByteValue(channelId, cookie, eventIndex, true,79, ref var);
      if (!ret) return null;
      return (System.Byte) var;
    }  }

    public bool Get_STS_ALM_SEM_RESPOSTA_1Q0_EST(ref System.Byte value)
    {
      if (accessorService == null)
        return false;
      byte var = 0;
      bool ret = accessorService.GetByteValue(channelId, cookie, eventIndex, true,80, ref var);
      if (ret) value = (System.Byte) var;
      return ret;
    }

    public System.Byte? STS_ALM_SEM_RESPOSTA_1Q0_EST
    { get {
      if (accessorService == null)
        return null;
      byte var = 0;
      bool ret = accessorService.GetByteValue(channelId, cookie, eventIndex, true,80, ref var);
      if (!ret) return null;
      return (System.Byte) var;
    }  }

    public bool Get_STS_ALM_SEM_RESPOSTA_1Q2_EST(ref System.Byte value)
    {
      if (accessorService == null)
        return false;
      byte var = 0;
      bool ret = accessorService.GetByteValue(channelId, cookie, eventIndex, true,81, ref var);
      if (ret) value = (System.Byte) var;
      return ret;
    }

    public System.Byte? STS_ALM_SEM_RESPOSTA_1Q2_EST
    { get {
      if (accessorService == null)
        return null;
      byte var = 0;
      bool ret = accessorService.GetByteValue(channelId, cookie, eventIndex, true,81, ref var);
      if (!ret) return null;
      return (System.Byte) var;
    }  }

    public bool Get_PERM_ABRIR1Q1(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,82, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? PERM_ABRIR1Q1
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,82, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_PERM_FECHAR1Q1(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,83, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? PERM_FECHAR1Q1
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,83, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_PERM_ABRIR1Q0(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,84, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? PERM_ABRIR1Q0
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,84, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_PERM_FECHAR1Q0(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,85, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? PERM_FECHAR1Q0
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,85, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_PERM_ABRIR1Q2(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,86, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? PERM_ABRIR1Q2
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,86, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_PERM_FECHAR1Q2(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,87, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? PERM_FECHAR1Q2
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,87, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_CMD_ABRIR1Q1(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,88, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? CMD_ABRIR1Q1
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,88, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_CMD_FECHAR1Q1(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,89, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? CMD_FECHAR1Q1
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,89, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_CMD_ABRIR1Q0(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,90, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? CMD_ABRIR1Q0
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,90, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_CMD_FECHAR1Q0(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,91, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? CMD_FECHAR1Q0
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,91, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_CMD_ABRIR1Q2(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,92, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? CMD_ABRIR1Q2
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,92, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_CMD_FECHAR1Q2(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,93, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? CMD_FECHAR1Q2
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,93, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }


  }

}

namespace Hidryco.HidrycoLib.Symbols.Subestacao
{

  public class E_PARAMETROSEventArgs : System.EventArgs
  {
    public E_PARAMETROSEventArgs()
    {
    }
    private System.Boolean? HAB_V4601_field = null;
    public System.Boolean? HAB_V4601
    {
       get { return HAB_V4601_field; }
       set { HAB_V4601_field = value; }
    }
    private System.Boolean? HAB_V4602_field = null;
    public System.Boolean? HAB_V4602
    {
       get { return HAB_V4602_field; }
       set { HAB_V4602_field = value; }
    }
    private System.Boolean? HAB_V4603_field = null;
    public System.Boolean? HAB_V4603
    {
       get { return HAB_V4603_field; }
       set { HAB_V4603_field = value; }
    }
    private System.Boolean? HAB_V4604_field = null;
    public System.Boolean? HAB_V4604
    {
       get { return HAB_V4604_field; }
       set { HAB_V4604_field = value; }
    }
    private System.Boolean? HAB_EX_500_01_field = null;
    public System.Boolean? HAB_EX_500_01
    {
       get { return HAB_EX_500_01_field; }
       set { HAB_EX_500_01_field = value; }
    }
    private System.Boolean? HAB_EX_500_02_field = null;
    public System.Boolean? HAB_EX_500_02
    {
       get { return HAB_EX_500_02_field; }
       set { HAB_EX_500_02_field = value; }
    }
    private System.Boolean? HAB_EX_500_03_field = null;
    public System.Boolean? HAB_EX_500_03
    {
       get { return HAB_EX_500_03_field; }
       set { HAB_EX_500_03_field = value; }
    }
    private System.Boolean? HAB_EX_500_04_field = null;
    public System.Boolean? HAB_EX_500_04
    {
       get { return HAB_EX_500_04_field; }
       set { HAB_EX_500_04_field = value; }
    }
    private System.Boolean? HAB_EX_500_05_field = null;
    public System.Boolean? HAB_EX_500_05
    {
       get { return HAB_EX_500_05_field; }
       set { HAB_EX_500_05_field = value; }
    }
    private System.Boolean? HAB_COMP_500_01_field = null;
    public System.Boolean? HAB_COMP_500_01
    {
       get { return HAB_COMP_500_01_field; }
       set { HAB_COMP_500_01_field = value; }
    }
    private System.Boolean? HAB_COMP_500_02_field = null;
    public System.Boolean? HAB_COMP_500_02
    {
       get { return HAB_COMP_500_02_field; }
       set { HAB_COMP_500_02_field = value; }
    }
    private System.Boolean? HAB_UCT_200_01_field = null;
    public System.Boolean? HAB_UCT_200_01
    {
       get { return HAB_UCT_200_01_field; }
       set { HAB_UCT_200_01_field = value; }
    }
    private System.Boolean? HAB_UCT_200_02_field = null;
    public System.Boolean? HAB_UCT_200_02
    {
       get { return HAB_UCT_200_02_field; }
       set { HAB_UCT_200_02_field = value; }
    }
    private System.Boolean? HAB_UCT_200_03_field = null;
    public System.Boolean? HAB_UCT_200_03
    {
       get { return HAB_UCT_200_03_field; }
       set { HAB_UCT_200_03_field = value; }
    }
    private System.Boolean? HAB_BS_100_01_field = null;
    public System.Boolean? HAB_BS_100_01
    {
       get { return HAB_BS_100_01_field; }
       set { HAB_BS_100_01_field = value; }
    }
    private System.Boolean? HAB_BS_100_02_field = null;
    public System.Boolean? HAB_BS_100_02
    {
       get { return HAB_BS_100_02_field; }
       set { HAB_BS_100_02_field = value; }
    }
    private System.Boolean? HAB_BS_100_03_field = null;
    public System.Boolean? HAB_BS_100_03
    {
       get { return HAB_BS_100_03_field; }
       set { HAB_BS_100_03_field = value; }
    }
    private System.Boolean? HAB_GM_100_01_field = null;
    public System.Boolean? HAB_GM_100_01
    {
       get { return HAB_GM_100_01_field; }
       set { HAB_GM_100_01_field = value; }
    }
    private System.Boolean? HAB_UV_700_01_field = null;
    public System.Boolean? HAB_UV_700_01
    {
       get { return HAB_UV_700_01_field; }
       set { HAB_UV_700_01_field = value; }
    }
    private System.Boolean? HAB_UV_700_02_field = null;
    public System.Boolean? HAB_UV_700_02
    {
       get { return HAB_UV_700_02_field; }
       set { HAB_UV_700_02_field = value; }
    }
    private System.Boolean? HAB_DO_800_04_field = null;
    public System.Boolean? HAB_DO_800_04
    {
       get { return HAB_DO_800_04_field; }
       set { HAB_DO_800_04_field = value; }
    }
    private System.Boolean? HAB_DO_800_05_field = null;
    public System.Boolean? HAB_DO_800_05
    {
       get { return HAB_DO_800_05_field; }
       set { HAB_DO_800_05_field = value; }
    }
    private System.Boolean? HAB_P4901_field = null;
    public System.Boolean? HAB_P4901
    {
       get { return HAB_P4901_field; }
       set { HAB_P4901_field = value; }
    }
    private System.Boolean? HAB_P4902_field = null;
    public System.Boolean? HAB_P4902
    {
       get { return HAB_P4902_field; }
       set { HAB_P4902_field = value; }
    }
    private System.Boolean? HAB_P4903_field = null;
    public System.Boolean? HAB_P4903
    {
       get { return HAB_P4903_field; }
       set { HAB_P4903_field = value; }
    }
    private System.Boolean? HAB_R4005A_field = null;
    public System.Boolean? HAB_R4005A
    {
       get { return HAB_R4005A_field; }
       set { HAB_R4005A_field = value; }
    }
    private System.Boolean? HAB_R4005B_field = null;
    public System.Boolean? HAB_R4005B
    {
       get { return HAB_R4005B_field; }
       set { HAB_R4005B_field = value; }
    }
    private System.Boolean? HAB_MO_300_01_field = null;
    public System.Boolean? HAB_MO_300_01
    {
       get { return HAB_MO_300_01_field; }
       set { HAB_MO_300_01_field = value; }
    }
    private System.Boolean? HAB_QL_PORTARIA_field = null;
    public System.Boolean? HAB_QL_PORTARIA
    {
       get { return HAB_QL_PORTARIA_field; }
       set { HAB_QL_PORTARIA_field = value; }
    }
    private System.Boolean? HAB_QL_ADM_field = null;
    public System.Boolean? HAB_QL_ADM
    {
       get { return HAB_QL_ADM_field; }
       set { HAB_QL_ADM_field = value; }
    }
    private System.Boolean? HAB_QL_LODO_field = null;
    public System.Boolean? HAB_QL_LODO
    {
       get { return HAB_QL_LODO_field; }
       set { HAB_QL_LODO_field = value; }
    }
    private System.Boolean? HAB_QLSL_field = null;
    public System.Boolean? HAB_QLSL
    {
       get { return HAB_QLSL_field; }
       set { HAB_QLSL_field = value; }
    }
    private System.Boolean? HAB_QL_ILUMINACAO_field = null;
    public System.Boolean? HAB_QL_ILUMINACAO
    {
       get { return HAB_QL_ILUMINACAO_field; }
       set { HAB_QL_ILUMINACAO_field = value; }
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

  public class E_COMANDOEventArgs : System.EventArgs
  {
    public E_COMANDOEventArgs()
    {
    }
    private System.Int16? CMD_DISJUNTOR_field = null;
    public System.Int16? CMD_DISJUNTOR
    {
       get { return CMD_DISJUNTOR_field; }
       set { CMD_DISJUNTOR_field = value; }
    }

  }

}

namespace Hidryco.HidrycoLib.Symbols.Subestacao
{
  partial class sDefault
  {

    private event EventHandler<Hidryco.HidrycoLib.Symbols.Subestacao.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    private event EventHandler<Hidryco.HidrycoLib.Symbols.Subestacao.REQEventArgs> REQ_Fired;

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
              LOAD_PERS_DATA_Fired(this, new Hidryco.HidrycoLib.Symbols.Subestacao.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
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
              REQ_Fired(this, new Hidryco.HidrycoLib.Symbols.Subestacao.REQEventArgs(channelId, cookie, eventIndex));
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
    public bool FireEvent_E_PARAMETROS(System.Boolean HAB_V4601, System.Boolean HAB_V4602, System.Boolean HAB_V4603, System.Boolean HAB_V4604, System.Boolean HAB_EX_500_01, System.Boolean HAB_EX_500_02, System.Boolean HAB_EX_500_03, System.Boolean HAB_EX_500_04, System.Boolean HAB_EX_500_05, System.Boolean HAB_COMP_500_01, System.Boolean HAB_COMP_500_02, System.Boolean HAB_UCT_200_01, System.Boolean HAB_UCT_200_02, System.Boolean HAB_UCT_200_03, System.Boolean HAB_BS_100_01, System.Boolean HAB_BS_100_02, System.Boolean HAB_BS_100_03, System.Boolean HAB_GM_100_01, System.Boolean HAB_UV_700_01, System.Boolean HAB_UV_700_02, System.Boolean HAB_DO_800_04, System.Boolean HAB_DO_800_05, System.Boolean HAB_P4901, System.Boolean HAB_P4902, System.Boolean HAB_P4903, System.Boolean HAB_R4005A, System.Boolean HAB_R4005B, System.Boolean HAB_MO_300_01, System.Boolean HAB_QL_PORTARIA, System.Boolean HAB_QL_ADM, System.Boolean HAB_QL_LODO, System.Boolean HAB_QLSL, System.Boolean HAB_QL_ILUMINACAO)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {HAB_V4601, HAB_V4602, HAB_V4603, HAB_V4604, HAB_EX_500_01, HAB_EX_500_02, HAB_EX_500_03, HAB_EX_500_04, HAB_EX_500_05, HAB_COMP_500_01, HAB_COMP_500_02, HAB_UCT_200_01, HAB_UCT_200_02, HAB_UCT_200_03, HAB_BS_100_01, HAB_BS_100_02, HAB_BS_100_03, HAB_GM_100_01, HAB_UV_700_01, HAB_UV_700_02, HAB_DO_800_04, HAB_DO_800_05, HAB_P4901, HAB_P4902, HAB_P4903, HAB_R4005A, HAB_R4005B, HAB_MO_300_01, HAB_QL_PORTARIA, HAB_QL_ADM, HAB_QL_LODO, HAB_QLSL, HAB_QL_ILUMINACAO});
    }
    public bool FireEvent_E_PARAMETROS(Hidryco.HidrycoLib.Symbols.Subestacao.E_PARAMETROSEventArgs ea)
    {
      object[] _values_ = new object[33];
      if (ea.HAB_V4601.HasValue) _values_[0] = ea.HAB_V4601.Value;
      if (ea.HAB_V4602.HasValue) _values_[1] = ea.HAB_V4602.Value;
      if (ea.HAB_V4603.HasValue) _values_[2] = ea.HAB_V4603.Value;
      if (ea.HAB_V4604.HasValue) _values_[3] = ea.HAB_V4604.Value;
      if (ea.HAB_EX_500_01.HasValue) _values_[4] = ea.HAB_EX_500_01.Value;
      if (ea.HAB_EX_500_02.HasValue) _values_[5] = ea.HAB_EX_500_02.Value;
      if (ea.HAB_EX_500_03.HasValue) _values_[6] = ea.HAB_EX_500_03.Value;
      if (ea.HAB_EX_500_04.HasValue) _values_[7] = ea.HAB_EX_500_04.Value;
      if (ea.HAB_EX_500_05.HasValue) _values_[8] = ea.HAB_EX_500_05.Value;
      if (ea.HAB_COMP_500_01.HasValue) _values_[9] = ea.HAB_COMP_500_01.Value;
      if (ea.HAB_COMP_500_02.HasValue) _values_[10] = ea.HAB_COMP_500_02.Value;
      if (ea.HAB_UCT_200_01.HasValue) _values_[11] = ea.HAB_UCT_200_01.Value;
      if (ea.HAB_UCT_200_02.HasValue) _values_[12] = ea.HAB_UCT_200_02.Value;
      if (ea.HAB_UCT_200_03.HasValue) _values_[13] = ea.HAB_UCT_200_03.Value;
      if (ea.HAB_BS_100_01.HasValue) _values_[14] = ea.HAB_BS_100_01.Value;
      if (ea.HAB_BS_100_02.HasValue) _values_[15] = ea.HAB_BS_100_02.Value;
      if (ea.HAB_BS_100_03.HasValue) _values_[16] = ea.HAB_BS_100_03.Value;
      if (ea.HAB_GM_100_01.HasValue) _values_[17] = ea.HAB_GM_100_01.Value;
      if (ea.HAB_UV_700_01.HasValue) _values_[18] = ea.HAB_UV_700_01.Value;
      if (ea.HAB_UV_700_02.HasValue) _values_[19] = ea.HAB_UV_700_02.Value;
      if (ea.HAB_DO_800_04.HasValue) _values_[20] = ea.HAB_DO_800_04.Value;
      if (ea.HAB_DO_800_05.HasValue) _values_[21] = ea.HAB_DO_800_05.Value;
      if (ea.HAB_P4901.HasValue) _values_[22] = ea.HAB_P4901.Value;
      if (ea.HAB_P4902.HasValue) _values_[23] = ea.HAB_P4902.Value;
      if (ea.HAB_P4903.HasValue) _values_[24] = ea.HAB_P4903.Value;
      if (ea.HAB_R4005A.HasValue) _values_[25] = ea.HAB_R4005A.Value;
      if (ea.HAB_R4005B.HasValue) _values_[26] = ea.HAB_R4005B.Value;
      if (ea.HAB_MO_300_01.HasValue) _values_[27] = ea.HAB_MO_300_01.Value;
      if (ea.HAB_QL_PORTARIA.HasValue) _values_[28] = ea.HAB_QL_PORTARIA.Value;
      if (ea.HAB_QL_ADM.HasValue) _values_[29] = ea.HAB_QL_ADM.Value;
      if (ea.HAB_QL_LODO.HasValue) _values_[30] = ea.HAB_QL_LODO.Value;
      if (ea.HAB_QLSL.HasValue) _values_[31] = ea.HAB_QLSL.Value;
      if (ea.HAB_QL_ILUMINACAO.HasValue) _values_[32] = ea.HAB_QL_ILUMINACAO.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_E_PARAMETROS(System.Boolean HAB_V4601, bool ignore_HAB_V4601, System.Boolean HAB_V4602, bool ignore_HAB_V4602, System.Boolean HAB_V4603, bool ignore_HAB_V4603, System.Boolean HAB_V4604, bool ignore_HAB_V4604, System.Boolean HAB_EX_500_01, bool ignore_HAB_EX_500_01, System.Boolean HAB_EX_500_02, bool ignore_HAB_EX_500_02, System.Boolean HAB_EX_500_03, bool ignore_HAB_EX_500_03, System.Boolean HAB_EX_500_04, bool ignore_HAB_EX_500_04, System.Boolean HAB_EX_500_05, bool ignore_HAB_EX_500_05, System.Boolean HAB_COMP_500_01, bool ignore_HAB_COMP_500_01, System.Boolean HAB_COMP_500_02, bool ignore_HAB_COMP_500_02, System.Boolean HAB_UCT_200_01, bool ignore_HAB_UCT_200_01, System.Boolean HAB_UCT_200_02, bool ignore_HAB_UCT_200_02, System.Boolean HAB_UCT_200_03, bool ignore_HAB_UCT_200_03, System.Boolean HAB_BS_100_01, bool ignore_HAB_BS_100_01, System.Boolean HAB_BS_100_02, bool ignore_HAB_BS_100_02, System.Boolean HAB_BS_100_03, bool ignore_HAB_BS_100_03, System.Boolean HAB_GM_100_01, bool ignore_HAB_GM_100_01, System.Boolean HAB_UV_700_01, bool ignore_HAB_UV_700_01, System.Boolean HAB_UV_700_02, bool ignore_HAB_UV_700_02, System.Boolean HAB_DO_800_04, bool ignore_HAB_DO_800_04, System.Boolean HAB_DO_800_05, bool ignore_HAB_DO_800_05, System.Boolean HAB_P4901, bool ignore_HAB_P4901, System.Boolean HAB_P4902, bool ignore_HAB_P4902, System.Boolean HAB_P4903, bool ignore_HAB_P4903, System.Boolean HAB_R4005A, bool ignore_HAB_R4005A, System.Boolean HAB_R4005B, bool ignore_HAB_R4005B, System.Boolean HAB_MO_300_01, bool ignore_HAB_MO_300_01, System.Boolean HAB_QL_PORTARIA, bool ignore_HAB_QL_PORTARIA, System.Boolean HAB_QL_ADM, bool ignore_HAB_QL_ADM, System.Boolean HAB_QL_LODO, bool ignore_HAB_QL_LODO, System.Boolean HAB_QLSL, bool ignore_HAB_QLSL, System.Boolean HAB_QL_ILUMINACAO, bool ignore_HAB_QL_ILUMINACAO)
    {
      object[] _values_ = new object[33];
      if (!ignore_HAB_V4601) _values_[0] = HAB_V4601;
      if (!ignore_HAB_V4602) _values_[1] = HAB_V4602;
      if (!ignore_HAB_V4603) _values_[2] = HAB_V4603;
      if (!ignore_HAB_V4604) _values_[3] = HAB_V4604;
      if (!ignore_HAB_EX_500_01) _values_[4] = HAB_EX_500_01;
      if (!ignore_HAB_EX_500_02) _values_[5] = HAB_EX_500_02;
      if (!ignore_HAB_EX_500_03) _values_[6] = HAB_EX_500_03;
      if (!ignore_HAB_EX_500_04) _values_[7] = HAB_EX_500_04;
      if (!ignore_HAB_EX_500_05) _values_[8] = HAB_EX_500_05;
      if (!ignore_HAB_COMP_500_01) _values_[9] = HAB_COMP_500_01;
      if (!ignore_HAB_COMP_500_02) _values_[10] = HAB_COMP_500_02;
      if (!ignore_HAB_UCT_200_01) _values_[11] = HAB_UCT_200_01;
      if (!ignore_HAB_UCT_200_02) _values_[12] = HAB_UCT_200_02;
      if (!ignore_HAB_UCT_200_03) _values_[13] = HAB_UCT_200_03;
      if (!ignore_HAB_BS_100_01) _values_[14] = HAB_BS_100_01;
      if (!ignore_HAB_BS_100_02) _values_[15] = HAB_BS_100_02;
      if (!ignore_HAB_BS_100_03) _values_[16] = HAB_BS_100_03;
      if (!ignore_HAB_GM_100_01) _values_[17] = HAB_GM_100_01;
      if (!ignore_HAB_UV_700_01) _values_[18] = HAB_UV_700_01;
      if (!ignore_HAB_UV_700_02) _values_[19] = HAB_UV_700_02;
      if (!ignore_HAB_DO_800_04) _values_[20] = HAB_DO_800_04;
      if (!ignore_HAB_DO_800_05) _values_[21] = HAB_DO_800_05;
      if (!ignore_HAB_P4901) _values_[22] = HAB_P4901;
      if (!ignore_HAB_P4902) _values_[23] = HAB_P4902;
      if (!ignore_HAB_P4903) _values_[24] = HAB_P4903;
      if (!ignore_HAB_R4005A) _values_[25] = HAB_R4005A;
      if (!ignore_HAB_R4005B) _values_[26] = HAB_R4005B;
      if (!ignore_HAB_MO_300_01) _values_[27] = HAB_MO_300_01;
      if (!ignore_HAB_QL_PORTARIA) _values_[28] = HAB_QL_PORTARIA;
      if (!ignore_HAB_QL_ADM) _values_[29] = HAB_QL_ADM;
      if (!ignore_HAB_QL_LODO) _values_[30] = HAB_QL_LODO;
      if (!ignore_HAB_QLSL) _values_[31] = HAB_QLSL;
      if (!ignore_HAB_QL_ILUMINACAO) _values_[32] = HAB_QL_ILUMINACAO;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_E_RESET(System.Boolean CMD_RESET)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {CMD_RESET});
    }
    public bool FireEvent_E_RESET(Hidryco.HidrycoLib.Symbols.Subestacao.E_RESETEventArgs ea)
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
    public bool FireEvent_E_COMANDO(System.Int16 CMD_DISJUNTOR)
    {
      return ((IHMIAccessorOutput)this).FireEvent(2, new object[] {CMD_DISJUNTOR});
    }
    public bool FireEvent_E_COMANDO(Hidryco.HidrycoLib.Symbols.Subestacao.E_COMANDOEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.CMD_DISJUNTOR.HasValue) _values_[0] = ea.CMD_DISJUNTOR.Value;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_E_COMANDO(System.Int16 CMD_DISJUNTOR, bool ignore_CMD_DISJUNTOR)
    {
      object[] _values_ = new object[1];
      if (!ignore_CMD_DISJUNTOR) _values_[0] = CMD_DISJUNTOR;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }

  }
}

namespace Hidryco.HidrycoLib.Faceplates.Subestacao
{
  partial class fpCargas
  {

    private event EventHandler<Hidryco.HidrycoLib.Symbols.Subestacao.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    private event EventHandler<Hidryco.HidrycoLib.Symbols.Subestacao.REQEventArgs> REQ_Fired;

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
              LOAD_PERS_DATA_Fired(this, new Hidryco.HidrycoLib.Symbols.Subestacao.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
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
              REQ_Fired(this, new Hidryco.HidrycoLib.Symbols.Subestacao.REQEventArgs(channelId, cookie, eventIndex));
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
    public bool FireEvent_E_PARAMETROS(System.Boolean HAB_V4601, System.Boolean HAB_V4602, System.Boolean HAB_V4603, System.Boolean HAB_V4604, System.Boolean HAB_EX_500_01, System.Boolean HAB_EX_500_02, System.Boolean HAB_EX_500_03, System.Boolean HAB_EX_500_04, System.Boolean HAB_EX_500_05, System.Boolean HAB_COMP_500_01, System.Boolean HAB_COMP_500_02, System.Boolean HAB_UCT_200_01, System.Boolean HAB_UCT_200_02, System.Boolean HAB_UCT_200_03, System.Boolean HAB_BS_100_01, System.Boolean HAB_BS_100_02, System.Boolean HAB_BS_100_03, System.Boolean HAB_GM_100_01, System.Boolean HAB_UV_700_01, System.Boolean HAB_UV_700_02, System.Boolean HAB_DO_800_04, System.Boolean HAB_DO_800_05, System.Boolean HAB_P4901, System.Boolean HAB_P4902, System.Boolean HAB_P4903, System.Boolean HAB_R4005A, System.Boolean HAB_R4005B, System.Boolean HAB_MO_300_01, System.Boolean HAB_QL_PORTARIA, System.Boolean HAB_QL_ADM, System.Boolean HAB_QL_LODO, System.Boolean HAB_QLSL, System.Boolean HAB_QL_ILUMINACAO)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {HAB_V4601, HAB_V4602, HAB_V4603, HAB_V4604, HAB_EX_500_01, HAB_EX_500_02, HAB_EX_500_03, HAB_EX_500_04, HAB_EX_500_05, HAB_COMP_500_01, HAB_COMP_500_02, HAB_UCT_200_01, HAB_UCT_200_02, HAB_UCT_200_03, HAB_BS_100_01, HAB_BS_100_02, HAB_BS_100_03, HAB_GM_100_01, HAB_UV_700_01, HAB_UV_700_02, HAB_DO_800_04, HAB_DO_800_05, HAB_P4901, HAB_P4902, HAB_P4903, HAB_R4005A, HAB_R4005B, HAB_MO_300_01, HAB_QL_PORTARIA, HAB_QL_ADM, HAB_QL_LODO, HAB_QLSL, HAB_QL_ILUMINACAO});
    }
    public bool FireEvent_E_PARAMETROS(Hidryco.HidrycoLib.Symbols.Subestacao.E_PARAMETROSEventArgs ea)
    {
      object[] _values_ = new object[33];
      if (ea.HAB_V4601.HasValue) _values_[0] = ea.HAB_V4601.Value;
      if (ea.HAB_V4602.HasValue) _values_[1] = ea.HAB_V4602.Value;
      if (ea.HAB_V4603.HasValue) _values_[2] = ea.HAB_V4603.Value;
      if (ea.HAB_V4604.HasValue) _values_[3] = ea.HAB_V4604.Value;
      if (ea.HAB_EX_500_01.HasValue) _values_[4] = ea.HAB_EX_500_01.Value;
      if (ea.HAB_EX_500_02.HasValue) _values_[5] = ea.HAB_EX_500_02.Value;
      if (ea.HAB_EX_500_03.HasValue) _values_[6] = ea.HAB_EX_500_03.Value;
      if (ea.HAB_EX_500_04.HasValue) _values_[7] = ea.HAB_EX_500_04.Value;
      if (ea.HAB_EX_500_05.HasValue) _values_[8] = ea.HAB_EX_500_05.Value;
      if (ea.HAB_COMP_500_01.HasValue) _values_[9] = ea.HAB_COMP_500_01.Value;
      if (ea.HAB_COMP_500_02.HasValue) _values_[10] = ea.HAB_COMP_500_02.Value;
      if (ea.HAB_UCT_200_01.HasValue) _values_[11] = ea.HAB_UCT_200_01.Value;
      if (ea.HAB_UCT_200_02.HasValue) _values_[12] = ea.HAB_UCT_200_02.Value;
      if (ea.HAB_UCT_200_03.HasValue) _values_[13] = ea.HAB_UCT_200_03.Value;
      if (ea.HAB_BS_100_01.HasValue) _values_[14] = ea.HAB_BS_100_01.Value;
      if (ea.HAB_BS_100_02.HasValue) _values_[15] = ea.HAB_BS_100_02.Value;
      if (ea.HAB_BS_100_03.HasValue) _values_[16] = ea.HAB_BS_100_03.Value;
      if (ea.HAB_GM_100_01.HasValue) _values_[17] = ea.HAB_GM_100_01.Value;
      if (ea.HAB_UV_700_01.HasValue) _values_[18] = ea.HAB_UV_700_01.Value;
      if (ea.HAB_UV_700_02.HasValue) _values_[19] = ea.HAB_UV_700_02.Value;
      if (ea.HAB_DO_800_04.HasValue) _values_[20] = ea.HAB_DO_800_04.Value;
      if (ea.HAB_DO_800_05.HasValue) _values_[21] = ea.HAB_DO_800_05.Value;
      if (ea.HAB_P4901.HasValue) _values_[22] = ea.HAB_P4901.Value;
      if (ea.HAB_P4902.HasValue) _values_[23] = ea.HAB_P4902.Value;
      if (ea.HAB_P4903.HasValue) _values_[24] = ea.HAB_P4903.Value;
      if (ea.HAB_R4005A.HasValue) _values_[25] = ea.HAB_R4005A.Value;
      if (ea.HAB_R4005B.HasValue) _values_[26] = ea.HAB_R4005B.Value;
      if (ea.HAB_MO_300_01.HasValue) _values_[27] = ea.HAB_MO_300_01.Value;
      if (ea.HAB_QL_PORTARIA.HasValue) _values_[28] = ea.HAB_QL_PORTARIA.Value;
      if (ea.HAB_QL_ADM.HasValue) _values_[29] = ea.HAB_QL_ADM.Value;
      if (ea.HAB_QL_LODO.HasValue) _values_[30] = ea.HAB_QL_LODO.Value;
      if (ea.HAB_QLSL.HasValue) _values_[31] = ea.HAB_QLSL.Value;
      if (ea.HAB_QL_ILUMINACAO.HasValue) _values_[32] = ea.HAB_QL_ILUMINACAO.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_E_PARAMETROS(System.Boolean HAB_V4601, bool ignore_HAB_V4601, System.Boolean HAB_V4602, bool ignore_HAB_V4602, System.Boolean HAB_V4603, bool ignore_HAB_V4603, System.Boolean HAB_V4604, bool ignore_HAB_V4604, System.Boolean HAB_EX_500_01, bool ignore_HAB_EX_500_01, System.Boolean HAB_EX_500_02, bool ignore_HAB_EX_500_02, System.Boolean HAB_EX_500_03, bool ignore_HAB_EX_500_03, System.Boolean HAB_EX_500_04, bool ignore_HAB_EX_500_04, System.Boolean HAB_EX_500_05, bool ignore_HAB_EX_500_05, System.Boolean HAB_COMP_500_01, bool ignore_HAB_COMP_500_01, System.Boolean HAB_COMP_500_02, bool ignore_HAB_COMP_500_02, System.Boolean HAB_UCT_200_01, bool ignore_HAB_UCT_200_01, System.Boolean HAB_UCT_200_02, bool ignore_HAB_UCT_200_02, System.Boolean HAB_UCT_200_03, bool ignore_HAB_UCT_200_03, System.Boolean HAB_BS_100_01, bool ignore_HAB_BS_100_01, System.Boolean HAB_BS_100_02, bool ignore_HAB_BS_100_02, System.Boolean HAB_BS_100_03, bool ignore_HAB_BS_100_03, System.Boolean HAB_GM_100_01, bool ignore_HAB_GM_100_01, System.Boolean HAB_UV_700_01, bool ignore_HAB_UV_700_01, System.Boolean HAB_UV_700_02, bool ignore_HAB_UV_700_02, System.Boolean HAB_DO_800_04, bool ignore_HAB_DO_800_04, System.Boolean HAB_DO_800_05, bool ignore_HAB_DO_800_05, System.Boolean HAB_P4901, bool ignore_HAB_P4901, System.Boolean HAB_P4902, bool ignore_HAB_P4902, System.Boolean HAB_P4903, bool ignore_HAB_P4903, System.Boolean HAB_R4005A, bool ignore_HAB_R4005A, System.Boolean HAB_R4005B, bool ignore_HAB_R4005B, System.Boolean HAB_MO_300_01, bool ignore_HAB_MO_300_01, System.Boolean HAB_QL_PORTARIA, bool ignore_HAB_QL_PORTARIA, System.Boolean HAB_QL_ADM, bool ignore_HAB_QL_ADM, System.Boolean HAB_QL_LODO, bool ignore_HAB_QL_LODO, System.Boolean HAB_QLSL, bool ignore_HAB_QLSL, System.Boolean HAB_QL_ILUMINACAO, bool ignore_HAB_QL_ILUMINACAO)
    {
      object[] _values_ = new object[33];
      if (!ignore_HAB_V4601) _values_[0] = HAB_V4601;
      if (!ignore_HAB_V4602) _values_[1] = HAB_V4602;
      if (!ignore_HAB_V4603) _values_[2] = HAB_V4603;
      if (!ignore_HAB_V4604) _values_[3] = HAB_V4604;
      if (!ignore_HAB_EX_500_01) _values_[4] = HAB_EX_500_01;
      if (!ignore_HAB_EX_500_02) _values_[5] = HAB_EX_500_02;
      if (!ignore_HAB_EX_500_03) _values_[6] = HAB_EX_500_03;
      if (!ignore_HAB_EX_500_04) _values_[7] = HAB_EX_500_04;
      if (!ignore_HAB_EX_500_05) _values_[8] = HAB_EX_500_05;
      if (!ignore_HAB_COMP_500_01) _values_[9] = HAB_COMP_500_01;
      if (!ignore_HAB_COMP_500_02) _values_[10] = HAB_COMP_500_02;
      if (!ignore_HAB_UCT_200_01) _values_[11] = HAB_UCT_200_01;
      if (!ignore_HAB_UCT_200_02) _values_[12] = HAB_UCT_200_02;
      if (!ignore_HAB_UCT_200_03) _values_[13] = HAB_UCT_200_03;
      if (!ignore_HAB_BS_100_01) _values_[14] = HAB_BS_100_01;
      if (!ignore_HAB_BS_100_02) _values_[15] = HAB_BS_100_02;
      if (!ignore_HAB_BS_100_03) _values_[16] = HAB_BS_100_03;
      if (!ignore_HAB_GM_100_01) _values_[17] = HAB_GM_100_01;
      if (!ignore_HAB_UV_700_01) _values_[18] = HAB_UV_700_01;
      if (!ignore_HAB_UV_700_02) _values_[19] = HAB_UV_700_02;
      if (!ignore_HAB_DO_800_04) _values_[20] = HAB_DO_800_04;
      if (!ignore_HAB_DO_800_05) _values_[21] = HAB_DO_800_05;
      if (!ignore_HAB_P4901) _values_[22] = HAB_P4901;
      if (!ignore_HAB_P4902) _values_[23] = HAB_P4902;
      if (!ignore_HAB_P4903) _values_[24] = HAB_P4903;
      if (!ignore_HAB_R4005A) _values_[25] = HAB_R4005A;
      if (!ignore_HAB_R4005B) _values_[26] = HAB_R4005B;
      if (!ignore_HAB_MO_300_01) _values_[27] = HAB_MO_300_01;
      if (!ignore_HAB_QL_PORTARIA) _values_[28] = HAB_QL_PORTARIA;
      if (!ignore_HAB_QL_ADM) _values_[29] = HAB_QL_ADM;
      if (!ignore_HAB_QL_LODO) _values_[30] = HAB_QL_LODO;
      if (!ignore_HAB_QLSL) _values_[31] = HAB_QLSL;
      if (!ignore_HAB_QL_ILUMINACAO) _values_[32] = HAB_QL_ILUMINACAO;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_E_RESET(System.Boolean CMD_RESET)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {CMD_RESET});
    }
    public bool FireEvent_E_RESET(Hidryco.HidrycoLib.Symbols.Subestacao.E_RESETEventArgs ea)
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
    public bool FireEvent_E_COMANDO(System.Int16 CMD_DISJUNTOR)
    {
      return ((IHMIAccessorOutput)this).FireEvent(2, new object[] {CMD_DISJUNTOR});
    }
    public bool FireEvent_E_COMANDO(Hidryco.HidrycoLib.Symbols.Subestacao.E_COMANDOEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.CMD_DISJUNTOR.HasValue) _values_[0] = ea.CMD_DISJUNTOR.Value;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_E_COMANDO(System.Int16 CMD_DISJUNTOR, bool ignore_CMD_DISJUNTOR)
    {
      object[] _values_ = new object[1];
      if (!ignore_CMD_DISJUNTOR) _values_[0] = CMD_DISJUNTOR;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }

  }
}

namespace Hidryco.HidrycoLib.Faceplates.Subestacao
{
  partial class fpComandos
  {

    private event EventHandler<Hidryco.HidrycoLib.Symbols.Subestacao.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    private event EventHandler<Hidryco.HidrycoLib.Symbols.Subestacao.REQEventArgs> REQ_Fired;

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
              LOAD_PERS_DATA_Fired(this, new Hidryco.HidrycoLib.Symbols.Subestacao.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
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
              REQ_Fired(this, new Hidryco.HidrycoLib.Symbols.Subestacao.REQEventArgs(channelId, cookie, eventIndex));
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
    public bool FireEvent_E_PARAMETROS(System.Boolean HAB_V4601, System.Boolean HAB_V4602, System.Boolean HAB_V4603, System.Boolean HAB_V4604, System.Boolean HAB_EX_500_01, System.Boolean HAB_EX_500_02, System.Boolean HAB_EX_500_03, System.Boolean HAB_EX_500_04, System.Boolean HAB_EX_500_05, System.Boolean HAB_COMP_500_01, System.Boolean HAB_COMP_500_02, System.Boolean HAB_UCT_200_01, System.Boolean HAB_UCT_200_02, System.Boolean HAB_UCT_200_03, System.Boolean HAB_BS_100_01, System.Boolean HAB_BS_100_02, System.Boolean HAB_BS_100_03, System.Boolean HAB_GM_100_01, System.Boolean HAB_UV_700_01, System.Boolean HAB_UV_700_02, System.Boolean HAB_DO_800_04, System.Boolean HAB_DO_800_05, System.Boolean HAB_P4901, System.Boolean HAB_P4902, System.Boolean HAB_P4903, System.Boolean HAB_R4005A, System.Boolean HAB_R4005B, System.Boolean HAB_MO_300_01, System.Boolean HAB_QL_PORTARIA, System.Boolean HAB_QL_ADM, System.Boolean HAB_QL_LODO, System.Boolean HAB_QLSL, System.Boolean HAB_QL_ILUMINACAO)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {HAB_V4601, HAB_V4602, HAB_V4603, HAB_V4604, HAB_EX_500_01, HAB_EX_500_02, HAB_EX_500_03, HAB_EX_500_04, HAB_EX_500_05, HAB_COMP_500_01, HAB_COMP_500_02, HAB_UCT_200_01, HAB_UCT_200_02, HAB_UCT_200_03, HAB_BS_100_01, HAB_BS_100_02, HAB_BS_100_03, HAB_GM_100_01, HAB_UV_700_01, HAB_UV_700_02, HAB_DO_800_04, HAB_DO_800_05, HAB_P4901, HAB_P4902, HAB_P4903, HAB_R4005A, HAB_R4005B, HAB_MO_300_01, HAB_QL_PORTARIA, HAB_QL_ADM, HAB_QL_LODO, HAB_QLSL, HAB_QL_ILUMINACAO});
    }
    public bool FireEvent_E_PARAMETROS(Hidryco.HidrycoLib.Symbols.Subestacao.E_PARAMETROSEventArgs ea)
    {
      object[] _values_ = new object[33];
      if (ea.HAB_V4601.HasValue) _values_[0] = ea.HAB_V4601.Value;
      if (ea.HAB_V4602.HasValue) _values_[1] = ea.HAB_V4602.Value;
      if (ea.HAB_V4603.HasValue) _values_[2] = ea.HAB_V4603.Value;
      if (ea.HAB_V4604.HasValue) _values_[3] = ea.HAB_V4604.Value;
      if (ea.HAB_EX_500_01.HasValue) _values_[4] = ea.HAB_EX_500_01.Value;
      if (ea.HAB_EX_500_02.HasValue) _values_[5] = ea.HAB_EX_500_02.Value;
      if (ea.HAB_EX_500_03.HasValue) _values_[6] = ea.HAB_EX_500_03.Value;
      if (ea.HAB_EX_500_04.HasValue) _values_[7] = ea.HAB_EX_500_04.Value;
      if (ea.HAB_EX_500_05.HasValue) _values_[8] = ea.HAB_EX_500_05.Value;
      if (ea.HAB_COMP_500_01.HasValue) _values_[9] = ea.HAB_COMP_500_01.Value;
      if (ea.HAB_COMP_500_02.HasValue) _values_[10] = ea.HAB_COMP_500_02.Value;
      if (ea.HAB_UCT_200_01.HasValue) _values_[11] = ea.HAB_UCT_200_01.Value;
      if (ea.HAB_UCT_200_02.HasValue) _values_[12] = ea.HAB_UCT_200_02.Value;
      if (ea.HAB_UCT_200_03.HasValue) _values_[13] = ea.HAB_UCT_200_03.Value;
      if (ea.HAB_BS_100_01.HasValue) _values_[14] = ea.HAB_BS_100_01.Value;
      if (ea.HAB_BS_100_02.HasValue) _values_[15] = ea.HAB_BS_100_02.Value;
      if (ea.HAB_BS_100_03.HasValue) _values_[16] = ea.HAB_BS_100_03.Value;
      if (ea.HAB_GM_100_01.HasValue) _values_[17] = ea.HAB_GM_100_01.Value;
      if (ea.HAB_UV_700_01.HasValue) _values_[18] = ea.HAB_UV_700_01.Value;
      if (ea.HAB_UV_700_02.HasValue) _values_[19] = ea.HAB_UV_700_02.Value;
      if (ea.HAB_DO_800_04.HasValue) _values_[20] = ea.HAB_DO_800_04.Value;
      if (ea.HAB_DO_800_05.HasValue) _values_[21] = ea.HAB_DO_800_05.Value;
      if (ea.HAB_P4901.HasValue) _values_[22] = ea.HAB_P4901.Value;
      if (ea.HAB_P4902.HasValue) _values_[23] = ea.HAB_P4902.Value;
      if (ea.HAB_P4903.HasValue) _values_[24] = ea.HAB_P4903.Value;
      if (ea.HAB_R4005A.HasValue) _values_[25] = ea.HAB_R4005A.Value;
      if (ea.HAB_R4005B.HasValue) _values_[26] = ea.HAB_R4005B.Value;
      if (ea.HAB_MO_300_01.HasValue) _values_[27] = ea.HAB_MO_300_01.Value;
      if (ea.HAB_QL_PORTARIA.HasValue) _values_[28] = ea.HAB_QL_PORTARIA.Value;
      if (ea.HAB_QL_ADM.HasValue) _values_[29] = ea.HAB_QL_ADM.Value;
      if (ea.HAB_QL_LODO.HasValue) _values_[30] = ea.HAB_QL_LODO.Value;
      if (ea.HAB_QLSL.HasValue) _values_[31] = ea.HAB_QLSL.Value;
      if (ea.HAB_QL_ILUMINACAO.HasValue) _values_[32] = ea.HAB_QL_ILUMINACAO.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_E_PARAMETROS(System.Boolean HAB_V4601, bool ignore_HAB_V4601, System.Boolean HAB_V4602, bool ignore_HAB_V4602, System.Boolean HAB_V4603, bool ignore_HAB_V4603, System.Boolean HAB_V4604, bool ignore_HAB_V4604, System.Boolean HAB_EX_500_01, bool ignore_HAB_EX_500_01, System.Boolean HAB_EX_500_02, bool ignore_HAB_EX_500_02, System.Boolean HAB_EX_500_03, bool ignore_HAB_EX_500_03, System.Boolean HAB_EX_500_04, bool ignore_HAB_EX_500_04, System.Boolean HAB_EX_500_05, bool ignore_HAB_EX_500_05, System.Boolean HAB_COMP_500_01, bool ignore_HAB_COMP_500_01, System.Boolean HAB_COMP_500_02, bool ignore_HAB_COMP_500_02, System.Boolean HAB_UCT_200_01, bool ignore_HAB_UCT_200_01, System.Boolean HAB_UCT_200_02, bool ignore_HAB_UCT_200_02, System.Boolean HAB_UCT_200_03, bool ignore_HAB_UCT_200_03, System.Boolean HAB_BS_100_01, bool ignore_HAB_BS_100_01, System.Boolean HAB_BS_100_02, bool ignore_HAB_BS_100_02, System.Boolean HAB_BS_100_03, bool ignore_HAB_BS_100_03, System.Boolean HAB_GM_100_01, bool ignore_HAB_GM_100_01, System.Boolean HAB_UV_700_01, bool ignore_HAB_UV_700_01, System.Boolean HAB_UV_700_02, bool ignore_HAB_UV_700_02, System.Boolean HAB_DO_800_04, bool ignore_HAB_DO_800_04, System.Boolean HAB_DO_800_05, bool ignore_HAB_DO_800_05, System.Boolean HAB_P4901, bool ignore_HAB_P4901, System.Boolean HAB_P4902, bool ignore_HAB_P4902, System.Boolean HAB_P4903, bool ignore_HAB_P4903, System.Boolean HAB_R4005A, bool ignore_HAB_R4005A, System.Boolean HAB_R4005B, bool ignore_HAB_R4005B, System.Boolean HAB_MO_300_01, bool ignore_HAB_MO_300_01, System.Boolean HAB_QL_PORTARIA, bool ignore_HAB_QL_PORTARIA, System.Boolean HAB_QL_ADM, bool ignore_HAB_QL_ADM, System.Boolean HAB_QL_LODO, bool ignore_HAB_QL_LODO, System.Boolean HAB_QLSL, bool ignore_HAB_QLSL, System.Boolean HAB_QL_ILUMINACAO, bool ignore_HAB_QL_ILUMINACAO)
    {
      object[] _values_ = new object[33];
      if (!ignore_HAB_V4601) _values_[0] = HAB_V4601;
      if (!ignore_HAB_V4602) _values_[1] = HAB_V4602;
      if (!ignore_HAB_V4603) _values_[2] = HAB_V4603;
      if (!ignore_HAB_V4604) _values_[3] = HAB_V4604;
      if (!ignore_HAB_EX_500_01) _values_[4] = HAB_EX_500_01;
      if (!ignore_HAB_EX_500_02) _values_[5] = HAB_EX_500_02;
      if (!ignore_HAB_EX_500_03) _values_[6] = HAB_EX_500_03;
      if (!ignore_HAB_EX_500_04) _values_[7] = HAB_EX_500_04;
      if (!ignore_HAB_EX_500_05) _values_[8] = HAB_EX_500_05;
      if (!ignore_HAB_COMP_500_01) _values_[9] = HAB_COMP_500_01;
      if (!ignore_HAB_COMP_500_02) _values_[10] = HAB_COMP_500_02;
      if (!ignore_HAB_UCT_200_01) _values_[11] = HAB_UCT_200_01;
      if (!ignore_HAB_UCT_200_02) _values_[12] = HAB_UCT_200_02;
      if (!ignore_HAB_UCT_200_03) _values_[13] = HAB_UCT_200_03;
      if (!ignore_HAB_BS_100_01) _values_[14] = HAB_BS_100_01;
      if (!ignore_HAB_BS_100_02) _values_[15] = HAB_BS_100_02;
      if (!ignore_HAB_BS_100_03) _values_[16] = HAB_BS_100_03;
      if (!ignore_HAB_GM_100_01) _values_[17] = HAB_GM_100_01;
      if (!ignore_HAB_UV_700_01) _values_[18] = HAB_UV_700_01;
      if (!ignore_HAB_UV_700_02) _values_[19] = HAB_UV_700_02;
      if (!ignore_HAB_DO_800_04) _values_[20] = HAB_DO_800_04;
      if (!ignore_HAB_DO_800_05) _values_[21] = HAB_DO_800_05;
      if (!ignore_HAB_P4901) _values_[22] = HAB_P4901;
      if (!ignore_HAB_P4902) _values_[23] = HAB_P4902;
      if (!ignore_HAB_P4903) _values_[24] = HAB_P4903;
      if (!ignore_HAB_R4005A) _values_[25] = HAB_R4005A;
      if (!ignore_HAB_R4005B) _values_[26] = HAB_R4005B;
      if (!ignore_HAB_MO_300_01) _values_[27] = HAB_MO_300_01;
      if (!ignore_HAB_QL_PORTARIA) _values_[28] = HAB_QL_PORTARIA;
      if (!ignore_HAB_QL_ADM) _values_[29] = HAB_QL_ADM;
      if (!ignore_HAB_QL_LODO) _values_[30] = HAB_QL_LODO;
      if (!ignore_HAB_QLSL) _values_[31] = HAB_QLSL;
      if (!ignore_HAB_QL_ILUMINACAO) _values_[32] = HAB_QL_ILUMINACAO;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_E_RESET(System.Boolean CMD_RESET)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {CMD_RESET});
    }
    public bool FireEvent_E_RESET(Hidryco.HidrycoLib.Symbols.Subestacao.E_RESETEventArgs ea)
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
    public bool FireEvent_E_COMANDO(System.Int16 CMD_DISJUNTOR)
    {
      return ((IHMIAccessorOutput)this).FireEvent(2, new object[] {CMD_DISJUNTOR});
    }
    public bool FireEvent_E_COMANDO(Hidryco.HidrycoLib.Symbols.Subestacao.E_COMANDOEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.CMD_DISJUNTOR.HasValue) _values_[0] = ea.CMD_DISJUNTOR.Value;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_E_COMANDO(System.Int16 CMD_DISJUNTOR, bool ignore_CMD_DISJUNTOR)
    {
      object[] _values_ = new object[1];
      if (!ignore_CMD_DISJUNTOR) _values_[0] = CMD_DISJUNTOR;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }

  }
}
#endregion #Subestacao_HMI;

#endregion Definitions;
