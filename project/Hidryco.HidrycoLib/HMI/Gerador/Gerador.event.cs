/*
 * Criado pelo EcoStruxure Automation Expert.
 * Usuário:  
 * Data: 13/05/2026
 * Tempo: 09:41
 * 
 */
using System;
using NxtControl.GuiFramework;
using NxtControl.Services;

#region Definitions;
#region #Gerador_HMI;

namespace Hidryco.HidrycoLib.Symbols.Gerador
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
    public bool Get_Generator_voltage_L1L2(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,0, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? Generator_voltage_L1L2
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,0, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }

    public bool Get_Generator_voltage_L2L3(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,1, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? Generator_voltage_L2L3
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,1, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }

    public bool Get_Generator_voltage_L3L1(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,2, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? Generator_voltage_L3L1
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,2, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }

    public bool Get_Generator_voltage_L1N(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,3, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? Generator_voltage_L1N
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,3, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }

    public bool Get_Generator_voltage_L2N(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,4, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? Generator_voltage_L2N
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,4, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }

    public bool Get_Generator_voltage_L3N(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,5, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? Generator_voltage_L3N
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,5, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }

    public bool Get_Generator_frequency_L1(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,6, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? Generator_frequency_L1
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,6, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }

    public bool Get_Generator_frequency_L2(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,7, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? Generator_frequency_L2
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,7, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }

    public bool Get_Generator_frequency_L3(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,8, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? Generator_frequency_L3
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,8, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }

    public bool Get_Generator_current_L1(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,9, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? Generator_current_L1
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,9, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }

    public bool Get_Generator_current_L2(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,10, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? Generator_current_L2
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,10, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }

    public bool Get_Generator_current_L3(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,11, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? Generator_current_L3
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,11, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }

    public bool Get_Generator_power_L1(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,12, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? Generator_power_L1
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,12, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }

    public bool Get_Generator_power_L2(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,13, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? Generator_power_L2
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,13, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }

    public bool Get_Generator_power_L3(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,14, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? Generator_power_L3
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,14, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }

    public bool Get_Generator_power(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,15, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? Generator_power
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,15, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }

    public bool Get_Generator_reactive_power_L1(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,16, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? Generator_reactive_power_L1
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,16, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }

    public bool Get_Generator_reactive_power_L2(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,17, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? Generator_reactive_power_L2
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,17, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }

    public bool Get_Generator_reactive_power_L3(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,18, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? Generator_reactive_power_L3
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,18, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }

    public bool Get_Generator_reactive_power(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,19, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? Generator_reactive_power
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,19, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }

    public bool Get_Generator_apparent_power_L1(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,20, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? Generator_apparent_power_L1
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,20, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }

    public bool Get_Generator_apparent_power_L2(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,21, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? Generator_apparent_power_L2
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,21, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }

    public bool Get_Generator_apparent_power_L3(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,22, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? Generator_apparent_power_L3
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,22, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }

    public bool Get_Generator_apparent_power(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,23, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? Generator_apparent_power
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,23, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }

    public bool Get_Generator_PF(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,24, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? Generator_PF
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,24, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }

    public bool Get_Cosphi(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,25, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? Cosphi
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,25, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }

    public bool Get_Cosphi_InductiveCapacitive_0Inductive_1C(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,26, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? Cosphi_InductiveCapacitive_0Inductive_1C
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,26, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }

    public bool Get_Generator_voltage_phase_angle_L1L2(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,27, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? Generator_voltage_phase_angle_L1L2
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,27, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }

    public bool Get_Generator_voltage_phase_angle_L2L3(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,28, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? Generator_voltage_phase_angle_L2L3
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,28, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }

    public bool Get_Generator_voltage_phase_angle_L3L1(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,29, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? Generator_voltage_phase_angle_L3L1
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,29, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }

    public bool Get_Rotacao_do_motor(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,30, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? Rotacao_do_motor
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,30, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }

    public bool Get_Temperatura_liq_arrefecimento(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,31, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? Temperatura_liq_arrefecimento
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,31, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }

    public bool Get_Pressao_do_oleo_do_motor(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,32, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? Pressao_do_oleo_do_motor
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,32, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }

    public bool Get_Temperatura_do_oleo_do_motor(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,33, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? Temperatura_do_oleo_do_motor
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,33, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }

    public bool Get_Temperatura_do_combustivel(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,34, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? Temperatura_do_combustivel
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,34, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }

    public bool Get_Temperatura_do_ar_de_admissao(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,35, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? Temperatura_do_ar_de_admissao
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,35, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }

    public bool Get_Nivel_do_liq_arrefecimento(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,36, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? Nivel_do_liq_arrefecimento
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,36, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }

    public bool Get_Consumo_de_combustivel(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,37, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? Consumo_de_combustivel
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,37, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }

    public bool Get_Temp_coletor_de_admissao(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,38, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? Temp_coletor_de_admissao
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,38, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }

    public bool Get_Carga_do_motor(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,39, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? Carga_do_motor
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,39, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }

    public bool Get_Temperatura_de_exaustao(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,40, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? Temperatura_de_exaustao
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,40, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }

    public bool Get_Horimetro_total_do_motor(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,41, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? Horimetro_total_do_motor
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,41, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }

    public bool Get_Tensao_da_bateria(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,42, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? Tensao_da_bateria
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,42, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }

    public bool Get_Nivel_de_oleo(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,43, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? Nivel_de_oleo
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,43, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }

    public bool Get_Temperatura_ambiente(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,44, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? Temperatura_ambiente
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,44, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }

    public bool Get_Combustivel_total_viagem(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,45, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? Combustivel_total_viagem
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,45, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }

    public bool Get_Combustivel_total_acumulado(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,46, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? Combustivel_total_acumulado
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,46, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }

    public bool Get_Horas_de_funcionamento_absolutas(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,47, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? Horas_de_funcionamento_absolutas
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,47, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }

    public bool Get_Horas_de_funcionamento_relativas(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,48, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? Horas_de_funcionamento_relativas
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,48, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }

    public bool Get_No_total_de_alarmes(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,49, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? No_total_de_alarmes
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,49, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }

    public bool Get_No_de_alarmes_nao_reconhecidos(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,50, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? No_de_alarmes_nao_reconhecidos
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,50, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }

    public bool Get_GB_position_ON(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,51, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? GB_position_ON
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,51, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_Running(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,52, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? Running
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,52, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_Generator_voltagefrequency_OK(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,53, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? Generator_voltagefrequency_OK
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,53, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_Mains_failure(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,54, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? Mains_failure
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,54, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_Block_mode(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,55, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? Block_mode
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,55, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_Manual_mode(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,56, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? Manual_mode
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,56, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_Semiauto_mode(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,57, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? Semiauto_mode
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,57, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_Auto_mode(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,58, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? Auto_mode
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,58, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_GB_position_OFF(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,59, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? GB_position_OFF
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,59, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }


  }

}

namespace Hidryco.HidrycoLib.Symbols.Gerador
{

  public class INDEventArgs : System.EventArgs
  {
    public INDEventArgs()
    {
    }
    private System.Boolean? Remote_start_field = null;
    public System.Boolean? Remote_start
    {
       get { return Remote_start_field; }
       set { Remote_start_field = value; }
    }
    private System.Boolean? Remote_stop_field = null;
    public System.Boolean? Remote_stop
    {
       get { return Remote_stop_field; }
       set { Remote_stop_field = value; }
    }
    private System.Boolean? Remote_GB_ON_field = null;
    public System.Boolean? Remote_GB_ON
    {
       get { return Remote_GB_ON_field; }
       set { Remote_GB_ON_field = value; }
    }
    private System.Boolean? Remote_GB_OFF_field = null;
    public System.Boolean? Remote_GB_OFF
    {
       get { return Remote_GB_OFF_field; }
       set { Remote_GB_OFF_field = value; }
    }
    private System.Boolean? Start_sync_field = null;
    public System.Boolean? Start_sync
    {
       get { return Start_sync_field; }
       set { Start_sync_field = value; }
    }
    private System.Boolean? Deload_stop_field = null;
    public System.Boolean? Deload_stop
    {
       get { return Deload_stop_field; }
       set { Deload_stop_field = value; }
    }
    private System.Int16? Setpoint_do_regulador_de_potencia_ativa_field = null;
    public System.Int16? Setpoint_do_regulador_de_potencia_ativa
    {
       get { return Setpoint_do_regulador_de_potencia_ativa_field; }
       set { Setpoint_do_regulador_de_potencia_ativa_field = value; }
    }
    private System.Int16? Setpoint_cosPhi_field = null;
    public System.Int16? Setpoint_cosPhi
    {
       get { return Setpoint_cosPhi_field; }
       set { Setpoint_cosPhi_field = value; }
    }
    private System.Int16? Setpoint_de_potencia_reativa_field = null;
    public System.Int16? Setpoint_de_potencia_reativa
    {
       get { return Setpoint_de_potencia_reativa_field; }
       set { Setpoint_de_potencia_reativa_field = value; }
    }
    private System.Int16? Setpoint_do_regulador_de_frequencia_field = null;
    public System.Int16? Setpoint_do_regulador_de_frequencia
    {
       get { return Setpoint_do_regulador_de_frequencia_field; }
       set { Setpoint_do_regulador_de_frequencia_field = value; }
    }
    private System.Int16? Setpoint_do_regulador_de_tensao_field = null;
    public System.Int16? Setpoint_do_regulador_de_tensao
    {
       get { return Setpoint_do_regulador_de_tensao_field; }
       set { Setpoint_do_regulador_de_tensao_field = value; }
    }

  }

}


namespace Hidryco.HidrycoLib.Symbols.Gerador
{

  public class E_Remote_startEventArgs : System.EventArgs
  {
    public E_Remote_startEventArgs()
    {
    }
    private System.Boolean? Remote_start_field = null;
    public System.Boolean? Remote_start
    {
       get { return Remote_start_field; }
       set { Remote_start_field = value; }
    }

  }

}

namespace Hidryco.HidrycoLib.Symbols.Gerador
{

  public class E_Remote_stopEventArgs : System.EventArgs
  {
    public E_Remote_stopEventArgs()
    {
    }
    private System.Boolean? Remote_stop_field = null;
    public System.Boolean? Remote_stop
    {
       get { return Remote_stop_field; }
       set { Remote_stop_field = value; }
    }

  }

}

namespace Hidryco.HidrycoLib.Symbols.Gerador
{

  public class E_Remote_GB_ONEventArgs : System.EventArgs
  {
    public E_Remote_GB_ONEventArgs()
    {
    }
    private System.Boolean? Remote_GB_ON_field = null;
    public System.Boolean? Remote_GB_ON
    {
       get { return Remote_GB_ON_field; }
       set { Remote_GB_ON_field = value; }
    }

  }

}

namespace Hidryco.HidrycoLib.Symbols.Gerador
{

  public class E_Remote_GB_OFFEventArgs : System.EventArgs
  {
    public E_Remote_GB_OFFEventArgs()
    {
    }
    private System.Boolean? Remote_GB_OFF_field = null;
    public System.Boolean? Remote_GB_OFF
    {
       get { return Remote_GB_OFF_field; }
       set { Remote_GB_OFF_field = value; }
    }

  }

}

namespace Hidryco.HidrycoLib.Symbols.Gerador
{

  public class E_Start_syncEventArgs : System.EventArgs
  {
    public E_Start_syncEventArgs()
    {
    }
    private System.Boolean? Start_sync_field = null;
    public System.Boolean? Start_sync
    {
       get { return Start_sync_field; }
       set { Start_sync_field = value; }
    }

  }

}

namespace Hidryco.HidrycoLib.Symbols.Gerador
{

  public class E_Deload_stopEventArgs : System.EventArgs
  {
    public E_Deload_stopEventArgs()
    {
    }
    private System.Boolean? Deload_stop_field = null;
    public System.Boolean? Deload_stop
    {
       get { return Deload_stop_field; }
       set { Deload_stop_field = value; }
    }

  }

}

namespace Hidryco.HidrycoLib.Symbols.Gerador
{
  partial class sDefault
  {

    
    public bool FireEvent_E_Remote_start(System.Boolean Remote_start)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {Remote_start});
    }
    public bool FireEvent_E_Remote_start(Hidryco.HidrycoLib.Symbols.Gerador.E_Remote_startEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.Remote_start.HasValue) _values_[0] = ea.Remote_start.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_E_Remote_start(System.Boolean Remote_start, bool ignore_Remote_start)
    {
      object[] _values_ = new object[1];
      if (!ignore_Remote_start) _values_[0] = Remote_start;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }

    public bool FireEvent_E_Remote_stop(System.Boolean Remote_stop)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {Remote_stop});
    }
    public bool FireEvent_E_Remote_stop(Hidryco.HidrycoLib.Symbols.Gerador.E_Remote_stopEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.Remote_stop.HasValue) _values_[0] = ea.Remote_stop.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_E_Remote_stop(System.Boolean Remote_stop, bool ignore_Remote_stop)
    {
      object[] _values_ = new object[1];
      if (!ignore_Remote_stop) _values_[0] = Remote_stop;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }

    public bool FireEvent_E_Remote_GB_ON(System.Boolean Remote_GB_ON)
    {
      return ((IHMIAccessorOutput)this).FireEvent(2, new object[] {Remote_GB_ON});
    }
    public bool FireEvent_E_Remote_GB_ON(Hidryco.HidrycoLib.Symbols.Gerador.E_Remote_GB_ONEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.Remote_GB_ON.HasValue) _values_[0] = ea.Remote_GB_ON.Value;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_E_Remote_GB_ON(System.Boolean Remote_GB_ON, bool ignore_Remote_GB_ON)
    {
      object[] _values_ = new object[1];
      if (!ignore_Remote_GB_ON) _values_[0] = Remote_GB_ON;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }

    public bool FireEvent_E_Remote_GB_OFF(System.Boolean Remote_GB_OFF)
    {
      return ((IHMIAccessorOutput)this).FireEvent(3, new object[] {Remote_GB_OFF});
    }
    public bool FireEvent_E_Remote_GB_OFF(Hidryco.HidrycoLib.Symbols.Gerador.E_Remote_GB_OFFEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.Remote_GB_OFF.HasValue) _values_[0] = ea.Remote_GB_OFF.Value;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_E_Remote_GB_OFF(System.Boolean Remote_GB_OFF, bool ignore_Remote_GB_OFF)
    {
      object[] _values_ = new object[1];
      if (!ignore_Remote_GB_OFF) _values_[0] = Remote_GB_OFF;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }

    public bool FireEvent_E_Start_sync(System.Boolean Start_sync)
    {
      return ((IHMIAccessorOutput)this).FireEvent(4, new object[] {Start_sync});
    }
    public bool FireEvent_E_Start_sync(Hidryco.HidrycoLib.Symbols.Gerador.E_Start_syncEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.Start_sync.HasValue) _values_[0] = ea.Start_sync.Value;
      return ((IHMIAccessorOutput)this).FireEvent(4, _values_);
    }
    public bool FireEvent_E_Start_sync(System.Boolean Start_sync, bool ignore_Start_sync)
    {
      object[] _values_ = new object[1];
      if (!ignore_Start_sync) _values_[0] = Start_sync;
      return ((IHMIAccessorOutput)this).FireEvent(4, _values_);
    }

    public bool FireEvent_E_Deload_stop(System.Boolean Deload_stop)
    {
      return ((IHMIAccessorOutput)this).FireEvent(5, new object[] {Deload_stop});
    }
    public bool FireEvent_E_Deload_stop(Hidryco.HidrycoLib.Symbols.Gerador.E_Deload_stopEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.Deload_stop.HasValue) _values_[0] = ea.Deload_stop.Value;
      return ((IHMIAccessorOutput)this).FireEvent(5, _values_);
    }
    public bool FireEvent_E_Deload_stop(System.Boolean Deload_stop, bool ignore_Deload_stop)
    {
      object[] _values_ = new object[1];
      if (!ignore_Deload_stop) _values_[0] = Deload_stop;
      return ((IHMIAccessorOutput)this).FireEvent(5, _values_);
    }

    private event EventHandler<Hidryco.HidrycoLib.Symbols.Gerador.REQEventArgs> REQ_Fired;

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
              REQ_Fired(this, new Hidryco.HidrycoLib.Symbols.Gerador.REQEventArgs(channelId, cookie, eventIndex));
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

  }
}
#endregion #Gerador_HMI;

#endregion Definitions;
