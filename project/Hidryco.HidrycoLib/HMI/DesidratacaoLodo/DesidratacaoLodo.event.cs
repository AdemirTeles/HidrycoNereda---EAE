/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 10/21/2026
 * Time: 10:00 AM
 * 
 */
using System;
using NxtControl.GuiFramework;
using NxtControl.Services;

#region Definitions;
#region #DesidratacaoLodo_HMI;

namespace Hidryco.HidrycoLib.Symbols.DesidratacaoLodo
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
    public bool Get_STS_SO_ATIVO(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,0, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? STS_SO_ATIVO
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,0, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }

    public bool Get_STS_SO_TRANSFERINDO(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,1, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_SO_TRANSFERINDO
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,1, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_SO_HORAS_ATUAL(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,2, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? STS_SO_HORAS_ATUAL
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,2, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }

    public bool Get_STS_SEM_SOPRADOR(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,3, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_SEM_SOPRADOR
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,3, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_NIVEL_TQ(ref System.Single value)
    {
      if (accessorService == null)
        return false;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,4, ref var);
      if (ret) value = (System.Single) var;
      return ret;
    }

    public System.Single? STS_NIVEL_TQ
    { get {
      if (accessorService == null)
        return null;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,4, ref var);
      if (!ret) return null;
      return (System.Single) var;
    }  }

    public bool Get_STS_NIVEL_BAIXO_TQ(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,5, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_NIVEL_BAIXO_TQ
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,5, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_SEM_NIVEL_TQ(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,6, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_SEM_NIVEL_TQ
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,6, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_AD1_ESTADO(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,7, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? STS_AD1_ESTADO
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,7, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }

    public bool Get_STS_AD1_MOTIVO(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,8, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? STS_AD1_MOTIVO
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,8, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }

    public bool Get_STS_AD1_BOMBA(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,9, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? STS_AD1_BOMBA
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,9, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }

    public bool Get_STS_AD1_ALIMENTANDO(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,10, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_AD1_ALIMENTANDO
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,10, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_AD1_FALHA_ROTA(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,11, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_AD1_FALHA_ROTA
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,11, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_AD1_SEM_PARTIR(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,12, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_AD1_SEM_PARTIR
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,12, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_AD2_ESTADO(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,13, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? STS_AD2_ESTADO
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,13, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }

    public bool Get_STS_AD2_MOTIVO(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,14, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? STS_AD2_MOTIVO
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,14, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }

    public bool Get_STS_AD2_BOMBA(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,15, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? STS_AD2_BOMBA
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,15, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }

    public bool Get_STS_AD2_ALIMENTANDO(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,16, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_AD2_ALIMENTANDO
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,16, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_AD2_FALHA_ROTA(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,17, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_AD2_FALHA_ROTA
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,17, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_AD2_SEM_PARTIR(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,18, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_AD2_SEM_PARTIR
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,18, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_AD3_ESTADO(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,19, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? STS_AD3_ESTADO
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,19, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }

    public bool Get_STS_AD3_MOTIVO(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,20, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? STS_AD3_MOTIVO
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,20, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }

    public bool Get_STS_AD3_BOMBA(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,21, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? STS_AD3_BOMBA
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,21, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }

    public bool Get_STS_AD3_ALIMENTANDO(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,22, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_AD3_ALIMENTANDO
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,22, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_AD3_FALHA_ROTA(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,23, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_AD3_FALHA_ROTA
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,23, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_AD3_SEM_PARTIR(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,24, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_AD3_SEM_PARTIR
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,24, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_BO1_HORAS(ref System.Int32 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,25, ref var);
      if (ret) value = (System.Int32) var;
      return ret;
    }

    public System.Int32? STS_BO1_HORAS
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,25, ref var);
      if (!ret) return null;
      return (System.Int32) var;
    }  }

    public bool Get_STS_BO1_PRENSA(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,26, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? STS_BO1_PRENSA
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,26, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }

    public bool Get_STS_BO2_HORAS(ref System.Int32 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,27, ref var);
      if (ret) value = (System.Int32) var;
      return ret;
    }

    public System.Int32? STS_BO2_HORAS
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,27, ref var);
      if (!ret) return null;
      return (System.Int32) var;
    }  }

    public bool Get_STS_BO2_PRENSA(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,28, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? STS_BO2_PRENSA
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,28, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }

    public bool Get_STS_BO3_HORAS(ref System.Int32 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,29, ref var);
      if (ret) value = (System.Int32) var;
      return ret;
    }

    public System.Int32? STS_BO3_HORAS
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,29, ref var);
      if (!ret) return null;
      return (System.Int32) var;
    }  }

    public bool Get_STS_BO3_PRENSA(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,30, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? STS_BO3_PRENSA
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,30, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }

    public bool Get_STS_VALVULAS_CMD(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,31, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? STS_VALVULAS_CMD
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,31, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }

    public bool Get_STS_VALVULAS_BLOQ(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,32, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? STS_VALVULAS_BLOQ
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,32, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }

    public bool Get_STS_EMERGENCIA(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,33, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_EMERGENCIA
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,33, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_REMOTA1_OK(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,34, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_REMOTA1_OK
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,34, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_REMOTA2_OK(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,35, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_REMOTA2_OK
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,35, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_FALHA_REMOTA(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,36, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_FALHA_REMOTA
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,36, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_MONIT_TRAFO(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,37, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_MONIT_TRAFO
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,37, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_MONIT_FONTE(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,38, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_MONIT_FONTE
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,38, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_DJ1(ref System.Int32 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,39, ref var);
      if (ret) value = (System.Int32) var;
      return ret;
    }

    public System.Int32? STS_DJ1
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,39, ref var);
      if (!ret) return null;
      return (System.Int32) var;
    }  }

    public bool Get_STS_DJ2(ref System.Int32 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,40, ref var);
      if (ret) value = (System.Int32) var;
      return ret;
    }

    public System.Int32? STS_DJ2
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,40, ref var);
      if (!ret) return null;
      return (System.Int32) var;
    }  }

    public bool Get_STS_AVISO_DISJUNTOR(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,41, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_AVISO_DISJUNTOR
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,41, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_SEM_BOMBA(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,42, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_SEM_BOMBA
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,42, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_FALHA_ROTA(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,43, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_FALHA_ROTA
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,43, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_SEM_PARTIR(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,44, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_SEM_PARTIR
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,44, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_FT_FALHA(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,45, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_FT_FALHA
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,45, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_CICLO_PP(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,46, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_CICLO_PP
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,46, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_SV(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,47, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? STS_SV
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,47, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }

    public bool Get_STS_ALARME(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,48, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_ALARME
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,48, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_ALM_SOPRADORES_EST(ref System.Byte value)
    {
      if (accessorService == null)
        return false;
      byte var = 0;
      bool ret = accessorService.GetByteValue(channelId, cookie, eventIndex, true,49, ref var);
      if (ret) value = (System.Byte) var;
      return ret;
    }

    public System.Byte? STS_ALM_SOPRADORES_EST
    { get {
      if (accessorService == null)
        return null;
      byte var = 0;
      bool ret = accessorService.GetByteValue(channelId, cookie, eventIndex, true,49, ref var);
      if (!ret) return null;
      return (System.Byte) var;
    }  }

    public bool Get_STS_ALM_NIVEL_TQ_EST(ref System.Byte value)
    {
      if (accessorService == null)
        return false;
      byte var = 0;
      bool ret = accessorService.GetByteValue(channelId, cookie, eventIndex, true,50, ref var);
      if (ret) value = (System.Byte) var;
      return ret;
    }

    public System.Byte? STS_ALM_NIVEL_TQ_EST
    { get {
      if (accessorService == null)
        return null;
      byte var = 0;
      bool ret = accessorService.GetByteValue(channelId, cookie, eventIndex, true,50, ref var);
      if (!ret) return null;
      return (System.Byte) var;
    }  }

    public bool Get_STS_ALM_EMERGENCIA_EST(ref System.Byte value)
    {
      if (accessorService == null)
        return false;
      byte var = 0;
      bool ret = accessorService.GetByteValue(channelId, cookie, eventIndex, true,51, ref var);
      if (ret) value = (System.Byte) var;
      return ret;
    }

    public System.Byte? STS_ALM_EMERGENCIA_EST
    { get {
      if (accessorService == null)
        return null;
      byte var = 0;
      bool ret = accessorService.GetByteValue(channelId, cookie, eventIndex, true,51, ref var);
      if (!ret) return null;
      return (System.Byte) var;
    }  }

    public bool Get_STS_ALM_REMOTA_EST(ref System.Byte value)
    {
      if (accessorService == null)
        return false;
      byte var = 0;
      bool ret = accessorService.GetByteValue(channelId, cookie, eventIndex, true,52, ref var);
      if (ret) value = (System.Byte) var;
      return ret;
    }

    public System.Byte? STS_ALM_REMOTA_EST
    { get {
      if (accessorService == null)
        return null;
      byte var = 0;
      bool ret = accessorService.GetByteValue(channelId, cookie, eventIndex, true,52, ref var);
      if (!ret) return null;
      return (System.Byte) var;
    }  }

    public bool Get_STS_ALM_DISJUNTOR_EST(ref System.Byte value)
    {
      if (accessorService == null)
        return false;
      byte var = 0;
      bool ret = accessorService.GetByteValue(channelId, cookie, eventIndex, true,53, ref var);
      if (ret) value = (System.Byte) var;
      return ret;
    }

    public System.Byte? STS_ALM_DISJUNTOR_EST
    { get {
      if (accessorService == null)
        return null;
      byte var = 0;
      bool ret = accessorService.GetByteValue(channelId, cookie, eventIndex, true,53, ref var);
      if (!ret) return null;
      return (System.Byte) var;
    }  }

    public bool Get_STS_ALM_ROTA_EST(ref System.Byte value)
    {
      if (accessorService == null)
        return false;
      byte var = 0;
      bool ret = accessorService.GetByteValue(channelId, cookie, eventIndex, true,54, ref var);
      if (ret) value = (System.Byte) var;
      return ret;
    }

    public System.Byte? STS_ALM_ROTA_EST
    { get {
      if (accessorService == null)
        return null;
      byte var = 0;
      bool ret = accessorService.GetByteValue(channelId, cookie, eventIndex, true,54, ref var);
      if (!ret) return null;
      return (System.Byte) var;
    }  }

    public bool Get_STS_ALM_SEM_BOMBA_EST(ref System.Byte value)
    {
      if (accessorService == null)
        return false;
      byte var = 0;
      bool ret = accessorService.GetByteValue(channelId, cookie, eventIndex, true,55, ref var);
      if (ret) value = (System.Byte) var;
      return ret;
    }

    public System.Byte? STS_ALM_SEM_BOMBA_EST
    { get {
      if (accessorService == null)
        return null;
      byte var = 0;
      bool ret = accessorService.GetByteValue(channelId, cookie, eventIndex, true,55, ref var);
      if (!ret) return null;
      return (System.Byte) var;
    }  }

    public bool Get_STS_ALM_SEM_PARTIR_EST(ref System.Byte value)
    {
      if (accessorService == null)
        return false;
      byte var = 0;
      bool ret = accessorService.GetByteValue(channelId, cookie, eventIndex, true,56, ref var);
      if (ret) value = (System.Byte) var;
      return ret;
    }

    public System.Byte? STS_ALM_SEM_PARTIR_EST
    { get {
      if (accessorService == null)
        return null;
      byte var = 0;
      bool ret = accessorService.GetByteValue(channelId, cookie, eventIndex, true,56, ref var);
      if (!ret) return null;
      return (System.Byte) var;
    }  }

    public bool Get_STS_ALM_FT_EST(ref System.Byte value)
    {
      if (accessorService == null)
        return false;
      byte var = 0;
      bool ret = accessorService.GetByteValue(channelId, cookie, eventIndex, true,57, ref var);
      if (ret) value = (System.Byte) var;
      return ret;
    }

    public System.Byte? STS_ALM_FT_EST
    { get {
      if (accessorService == null)
        return null;
      byte var = 0;
      bool ret = accessorService.GetByteValue(channelId, cookie, eventIndex, true,57, ref var);
      if (!ret) return null;
      return (System.Byte) var;
    }  }


  }

}

namespace Hidryco.HidrycoLib.Symbols.DesidratacaoLodo
{

  public class E_PARAMETROSEventArgs : System.EventArgs
  {
    public E_PARAMETROSEventArgs()
    {
    }
    private System.Boolean? HAB_SOPRADORES_field = null;
    public System.Boolean? HAB_SOPRADORES
    {
       get { return HAB_SOPRADORES_field; }
       set { HAB_SOPRADORES_field = value; }
    }
    private System.Single? STP_NIVEL_MIN_TQ_field = null;
    public System.Single? STP_NIVEL_MIN_TQ
    {
       get { return STP_NIVEL_MIN_TQ_field; }
       set { STP_NIVEL_MIN_TQ_field = value; }
    }
    private System.Single? STP_NIVEL_RETOMA_TQ_field = null;
    public System.Single? STP_NIVEL_RETOMA_TQ
    {
       get { return STP_NIVEL_RETOMA_TQ_field; }
       set { STP_NIVEL_RETOMA_TQ_field = value; }
    }
    private System.Single? STP_VAZAO_AD1_field = null;
    public System.Single? STP_VAZAO_AD1
    {
       get { return STP_VAZAO_AD1_field; }
       set { STP_VAZAO_AD1_field = value; }
    }
    private System.Single? STP_VAZAO_AD2_field = null;
    public System.Single? STP_VAZAO_AD2
    {
       get { return STP_VAZAO_AD2_field; }
       set { STP_VAZAO_AD2_field = value; }
    }
    private System.Single? STP_VAZAO_AD3_field = null;
    public System.Single? STP_VAZAO_AD3
    {
       get { return STP_VAZAO_AD3_field; }
       set { STP_VAZAO_AD3_field = value; }
    }
    private System.Single? STP_VEL_INICIAL_field = null;
    public System.Single? STP_VEL_INICIAL
    {
       get { return STP_VEL_INICIAL_field; }
       set { STP_VEL_INICIAL_field = value; }
    }
    private System.Single? STP_NIVEL_SUSPENDE_field = null;
    public System.Single? STP_NIVEL_SUSPENDE
    {
       get { return STP_NIVEL_SUSPENDE_field; }
       set { STP_NIVEL_SUSPENDE_field = value; }
    }
    private System.Single? STP_NIVEL_RETOMA_field = null;
    public System.Single? STP_NIVEL_RETOMA
    {
       get { return STP_NIVEL_RETOMA_field; }
       set { STP_NIVEL_RETOMA_field = value; }
    }
    private System.Int16? STP_TEMPO_VALVULAS_field = null;
    public System.Int16? STP_TEMPO_VALVULAS
    {
       get { return STP_TEMPO_VALVULAS_field; }
       set { STP_TEMPO_VALVULAS_field = value; }
    }
    private System.Int16? STP_DIF_HORAS_BO_field = null;
    public System.Int16? STP_DIF_HORAS_BO
    {
       get { return STP_DIF_HORAS_BO_field; }
       set { STP_DIF_HORAS_BO_field = value; }
    }
    private System.Int16? STP_TEMPO_SEM_PARTIR_field = null;
    public System.Int16? STP_TEMPO_SEM_PARTIR
    {
       get { return STP_TEMPO_SEM_PARTIR_field; }
       set { STP_TEMPO_SEM_PARTIR_field = value; }
    }
    private System.Single? STP_VEL_SOPRADORES_field = null;
    public System.Single? STP_VEL_SOPRADORES
    {
       get { return STP_VEL_SOPRADORES_field; }
       set { STP_VEL_SOPRADORES_field = value; }
    }

  }

  public class E_COMANDOEventArgs : System.EventArgs
  {
    public E_COMANDOEventArgs()
    {
    }
    private System.Boolean? CMD_AD1_field = null;
    public System.Boolean? CMD_AD1
    {
       get { return CMD_AD1_field; }
       set { CMD_AD1_field = value; }
    }
    private System.Boolean? CMD_AD2_field = null;
    public System.Boolean? CMD_AD2
    {
       get { return CMD_AD2_field; }
       set { CMD_AD2_field = value; }
    }
    private System.Boolean? CMD_AD3_field = null;
    public System.Boolean? CMD_AD3
    {
       get { return CMD_AD3_field; }
       set { CMD_AD3_field = value; }
    }

  }

  public class E_SVEventArgs : System.EventArgs
  {
    public E_SVEventArgs()
    {
    }
    private System.Boolean? CMD_SV01_field = null;
    public System.Boolean? CMD_SV01
    {
       get { return CMD_SV01_field; }
       set { CMD_SV01_field = value; }
    }
    private System.Boolean? CMD_SV02_field = null;
    public System.Boolean? CMD_SV02
    {
       get { return CMD_SV02_field; }
       set { CMD_SV02_field = value; }
    }
    private System.Boolean? CMD_SV03_field = null;
    public System.Boolean? CMD_SV03
    {
       get { return CMD_SV03_field; }
       set { CMD_SV03_field = value; }
    }
    private System.Boolean? CMD_SV04_field = null;
    public System.Boolean? CMD_SV04
    {
       get { return CMD_SV04_field; }
       set { CMD_SV04_field = value; }
    }
    private System.Boolean? CMD_SV06_field = null;
    public System.Boolean? CMD_SV06
    {
       get { return CMD_SV06_field; }
       set { CMD_SV06_field = value; }
    }
    private System.Boolean? CMD_SV08_field = null;
    public System.Boolean? CMD_SV08
    {
       get { return CMD_SV08_field; }
       set { CMD_SV08_field = value; }
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

namespace Hidryco.HidrycoLib.Symbols.DesidratacaoLodo
{
  partial class sDefault
  {

    private event EventHandler<Hidryco.HidrycoLib.Symbols.DesidratacaoLodo.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    private event EventHandler<Hidryco.HidrycoLib.Symbols.DesidratacaoLodo.REQEventArgs> REQ_Fired;

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
              LOAD_PERS_DATA_Fired(this, new Hidryco.HidrycoLib.Symbols.DesidratacaoLodo.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
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
              REQ_Fired(this, new Hidryco.HidrycoLib.Symbols.DesidratacaoLodo.REQEventArgs(channelId, cookie, eventIndex));
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
    public bool FireEvent_E_PARAMETROS(System.Boolean HAB_SOPRADORES, System.Single STP_NIVEL_MIN_TQ, System.Single STP_NIVEL_RETOMA_TQ, System.Single STP_VAZAO_AD1, System.Single STP_VAZAO_AD2, System.Single STP_VAZAO_AD3, System.Single STP_VEL_INICIAL, System.Single STP_NIVEL_SUSPENDE, System.Single STP_NIVEL_RETOMA, System.Int16 STP_TEMPO_VALVULAS, System.Int16 STP_DIF_HORAS_BO, System.Int16 STP_TEMPO_SEM_PARTIR, System.Single STP_VEL_SOPRADORES)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {HAB_SOPRADORES, STP_NIVEL_MIN_TQ, STP_NIVEL_RETOMA_TQ, STP_VAZAO_AD1, STP_VAZAO_AD2, STP_VAZAO_AD3, STP_VEL_INICIAL, STP_NIVEL_SUSPENDE, STP_NIVEL_RETOMA, STP_TEMPO_VALVULAS, STP_DIF_HORAS_BO, STP_TEMPO_SEM_PARTIR, STP_VEL_SOPRADORES});
    }
    public bool FireEvent_E_PARAMETROS(Hidryco.HidrycoLib.Symbols.DesidratacaoLodo.E_PARAMETROSEventArgs ea)
    {
      object[] _values_ = new object[13];
      if (ea.HAB_SOPRADORES.HasValue) _values_[0] = ea.HAB_SOPRADORES.Value;
      if (ea.STP_NIVEL_MIN_TQ.HasValue) _values_[1] = ea.STP_NIVEL_MIN_TQ.Value;
      if (ea.STP_NIVEL_RETOMA_TQ.HasValue) _values_[2] = ea.STP_NIVEL_RETOMA_TQ.Value;
      if (ea.STP_VAZAO_AD1.HasValue) _values_[3] = ea.STP_VAZAO_AD1.Value;
      if (ea.STP_VAZAO_AD2.HasValue) _values_[4] = ea.STP_VAZAO_AD2.Value;
      if (ea.STP_VAZAO_AD3.HasValue) _values_[5] = ea.STP_VAZAO_AD3.Value;
      if (ea.STP_VEL_INICIAL.HasValue) _values_[6] = ea.STP_VEL_INICIAL.Value;
      if (ea.STP_NIVEL_SUSPENDE.HasValue) _values_[7] = ea.STP_NIVEL_SUSPENDE.Value;
      if (ea.STP_NIVEL_RETOMA.HasValue) _values_[8] = ea.STP_NIVEL_RETOMA.Value;
      if (ea.STP_TEMPO_VALVULAS.HasValue) _values_[9] = ea.STP_TEMPO_VALVULAS.Value;
      if (ea.STP_DIF_HORAS_BO.HasValue) _values_[10] = ea.STP_DIF_HORAS_BO.Value;
      if (ea.STP_TEMPO_SEM_PARTIR.HasValue) _values_[11] = ea.STP_TEMPO_SEM_PARTIR.Value;
      if (ea.STP_VEL_SOPRADORES.HasValue) _values_[12] = ea.STP_VEL_SOPRADORES.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_E_PARAMETROS(System.Boolean HAB_SOPRADORES, bool ignore_HAB_SOPRADORES, System.Single STP_NIVEL_MIN_TQ, bool ignore_STP_NIVEL_MIN_TQ, System.Single STP_NIVEL_RETOMA_TQ, bool ignore_STP_NIVEL_RETOMA_TQ, System.Single STP_VAZAO_AD1, bool ignore_STP_VAZAO_AD1, System.Single STP_VAZAO_AD2, bool ignore_STP_VAZAO_AD2, System.Single STP_VAZAO_AD3, bool ignore_STP_VAZAO_AD3, System.Single STP_VEL_INICIAL, bool ignore_STP_VEL_INICIAL, System.Single STP_NIVEL_SUSPENDE, bool ignore_STP_NIVEL_SUSPENDE, System.Single STP_NIVEL_RETOMA, bool ignore_STP_NIVEL_RETOMA, System.Int16 STP_TEMPO_VALVULAS, bool ignore_STP_TEMPO_VALVULAS, System.Int16 STP_DIF_HORAS_BO, bool ignore_STP_DIF_HORAS_BO, System.Int16 STP_TEMPO_SEM_PARTIR, bool ignore_STP_TEMPO_SEM_PARTIR, System.Single STP_VEL_SOPRADORES, bool ignore_STP_VEL_SOPRADORES)
    {
      object[] _values_ = new object[13];
      if (!ignore_HAB_SOPRADORES) _values_[0] = HAB_SOPRADORES;
      if (!ignore_STP_NIVEL_MIN_TQ) _values_[1] = STP_NIVEL_MIN_TQ;
      if (!ignore_STP_NIVEL_RETOMA_TQ) _values_[2] = STP_NIVEL_RETOMA_TQ;
      if (!ignore_STP_VAZAO_AD1) _values_[3] = STP_VAZAO_AD1;
      if (!ignore_STP_VAZAO_AD2) _values_[4] = STP_VAZAO_AD2;
      if (!ignore_STP_VAZAO_AD3) _values_[5] = STP_VAZAO_AD3;
      if (!ignore_STP_VEL_INICIAL) _values_[6] = STP_VEL_INICIAL;
      if (!ignore_STP_NIVEL_SUSPENDE) _values_[7] = STP_NIVEL_SUSPENDE;
      if (!ignore_STP_NIVEL_RETOMA) _values_[8] = STP_NIVEL_RETOMA;
      if (!ignore_STP_TEMPO_VALVULAS) _values_[9] = STP_TEMPO_VALVULAS;
      if (!ignore_STP_DIF_HORAS_BO) _values_[10] = STP_DIF_HORAS_BO;
      if (!ignore_STP_TEMPO_SEM_PARTIR) _values_[11] = STP_TEMPO_SEM_PARTIR;
      if (!ignore_STP_VEL_SOPRADORES) _values_[12] = STP_VEL_SOPRADORES;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_E_COMANDO(System.Boolean CMD_AD1, System.Boolean CMD_AD2, System.Boolean CMD_AD3)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {CMD_AD1, CMD_AD2, CMD_AD3});
    }
    public bool FireEvent_E_COMANDO(Hidryco.HidrycoLib.Symbols.DesidratacaoLodo.E_COMANDOEventArgs ea)
    {
      object[] _values_ = new object[3];
      if (ea.CMD_AD1.HasValue) _values_[0] = ea.CMD_AD1.Value;
      if (ea.CMD_AD2.HasValue) _values_[1] = ea.CMD_AD2.Value;
      if (ea.CMD_AD3.HasValue) _values_[2] = ea.CMD_AD3.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_E_COMANDO(System.Boolean CMD_AD1, bool ignore_CMD_AD1, System.Boolean CMD_AD2, bool ignore_CMD_AD2, System.Boolean CMD_AD3, bool ignore_CMD_AD3)
    {
      object[] _values_ = new object[3];
      if (!ignore_CMD_AD1) _values_[0] = CMD_AD1;
      if (!ignore_CMD_AD2) _values_[1] = CMD_AD2;
      if (!ignore_CMD_AD3) _values_[2] = CMD_AD3;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_E_SV(System.Boolean CMD_SV01, System.Boolean CMD_SV02, System.Boolean CMD_SV03, System.Boolean CMD_SV04, System.Boolean CMD_SV06, System.Boolean CMD_SV08)
    {
      return ((IHMIAccessorOutput)this).FireEvent(2, new object[] {CMD_SV01, CMD_SV02, CMD_SV03, CMD_SV04, CMD_SV06, CMD_SV08});
    }
    public bool FireEvent_E_SV(Hidryco.HidrycoLib.Symbols.DesidratacaoLodo.E_SVEventArgs ea)
    {
      object[] _values_ = new object[6];
      if (ea.CMD_SV01.HasValue) _values_[0] = ea.CMD_SV01.Value;
      if (ea.CMD_SV02.HasValue) _values_[1] = ea.CMD_SV02.Value;
      if (ea.CMD_SV03.HasValue) _values_[2] = ea.CMD_SV03.Value;
      if (ea.CMD_SV04.HasValue) _values_[3] = ea.CMD_SV04.Value;
      if (ea.CMD_SV06.HasValue) _values_[4] = ea.CMD_SV06.Value;
      if (ea.CMD_SV08.HasValue) _values_[5] = ea.CMD_SV08.Value;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_E_SV(System.Boolean CMD_SV01, bool ignore_CMD_SV01, System.Boolean CMD_SV02, bool ignore_CMD_SV02, System.Boolean CMD_SV03, bool ignore_CMD_SV03, System.Boolean CMD_SV04, bool ignore_CMD_SV04, System.Boolean CMD_SV06, bool ignore_CMD_SV06, System.Boolean CMD_SV08, bool ignore_CMD_SV08)
    {
      object[] _values_ = new object[6];
      if (!ignore_CMD_SV01) _values_[0] = CMD_SV01;
      if (!ignore_CMD_SV02) _values_[1] = CMD_SV02;
      if (!ignore_CMD_SV03) _values_[2] = CMD_SV03;
      if (!ignore_CMD_SV04) _values_[3] = CMD_SV04;
      if (!ignore_CMD_SV06) _values_[4] = CMD_SV06;
      if (!ignore_CMD_SV08) _values_[5] = CMD_SV08;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_E_RESET(System.Boolean CMD_RESET)
    {
      return ((IHMIAccessorOutput)this).FireEvent(3, new object[] {CMD_RESET});
    }
    public bool FireEvent_E_RESET(Hidryco.HidrycoLib.Symbols.DesidratacaoLodo.E_RESETEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.CMD_RESET.HasValue) _values_[0] = ea.CMD_RESET.Value;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_E_RESET(System.Boolean CMD_RESET, bool ignore_CMD_RESET)
    {
      object[] _values_ = new object[1];
      if (!ignore_CMD_RESET) _values_[0] = CMD_RESET;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }

  }
}

namespace Hidryco.HidrycoLib.Symbols.DesidratacaoLodo
{
  partial class sFaixa
  {

    private event EventHandler<Hidryco.HidrycoLib.Symbols.DesidratacaoLodo.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    private event EventHandler<Hidryco.HidrycoLib.Symbols.DesidratacaoLodo.REQEventArgs> REQ_Fired;

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
              LOAD_PERS_DATA_Fired(this, new Hidryco.HidrycoLib.Symbols.DesidratacaoLodo.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
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
              REQ_Fired(this, new Hidryco.HidrycoLib.Symbols.DesidratacaoLodo.REQEventArgs(channelId, cookie, eventIndex));
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
    public bool FireEvent_E_PARAMETROS(System.Boolean HAB_SOPRADORES, System.Single STP_NIVEL_MIN_TQ, System.Single STP_NIVEL_RETOMA_TQ, System.Single STP_VAZAO_AD1, System.Single STP_VAZAO_AD2, System.Single STP_VAZAO_AD3, System.Single STP_VEL_INICIAL, System.Single STP_NIVEL_SUSPENDE, System.Single STP_NIVEL_RETOMA, System.Int16 STP_TEMPO_VALVULAS, System.Int16 STP_DIF_HORAS_BO, System.Int16 STP_TEMPO_SEM_PARTIR, System.Single STP_VEL_SOPRADORES)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {HAB_SOPRADORES, STP_NIVEL_MIN_TQ, STP_NIVEL_RETOMA_TQ, STP_VAZAO_AD1, STP_VAZAO_AD2, STP_VAZAO_AD3, STP_VEL_INICIAL, STP_NIVEL_SUSPENDE, STP_NIVEL_RETOMA, STP_TEMPO_VALVULAS, STP_DIF_HORAS_BO, STP_TEMPO_SEM_PARTIR, STP_VEL_SOPRADORES});
    }
    public bool FireEvent_E_PARAMETROS(Hidryco.HidrycoLib.Symbols.DesidratacaoLodo.E_PARAMETROSEventArgs ea)
    {
      object[] _values_ = new object[13];
      if (ea.HAB_SOPRADORES.HasValue) _values_[0] = ea.HAB_SOPRADORES.Value;
      if (ea.STP_NIVEL_MIN_TQ.HasValue) _values_[1] = ea.STP_NIVEL_MIN_TQ.Value;
      if (ea.STP_NIVEL_RETOMA_TQ.HasValue) _values_[2] = ea.STP_NIVEL_RETOMA_TQ.Value;
      if (ea.STP_VAZAO_AD1.HasValue) _values_[3] = ea.STP_VAZAO_AD1.Value;
      if (ea.STP_VAZAO_AD2.HasValue) _values_[4] = ea.STP_VAZAO_AD2.Value;
      if (ea.STP_VAZAO_AD3.HasValue) _values_[5] = ea.STP_VAZAO_AD3.Value;
      if (ea.STP_VEL_INICIAL.HasValue) _values_[6] = ea.STP_VEL_INICIAL.Value;
      if (ea.STP_NIVEL_SUSPENDE.HasValue) _values_[7] = ea.STP_NIVEL_SUSPENDE.Value;
      if (ea.STP_NIVEL_RETOMA.HasValue) _values_[8] = ea.STP_NIVEL_RETOMA.Value;
      if (ea.STP_TEMPO_VALVULAS.HasValue) _values_[9] = ea.STP_TEMPO_VALVULAS.Value;
      if (ea.STP_DIF_HORAS_BO.HasValue) _values_[10] = ea.STP_DIF_HORAS_BO.Value;
      if (ea.STP_TEMPO_SEM_PARTIR.HasValue) _values_[11] = ea.STP_TEMPO_SEM_PARTIR.Value;
      if (ea.STP_VEL_SOPRADORES.HasValue) _values_[12] = ea.STP_VEL_SOPRADORES.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_E_PARAMETROS(System.Boolean HAB_SOPRADORES, bool ignore_HAB_SOPRADORES, System.Single STP_NIVEL_MIN_TQ, bool ignore_STP_NIVEL_MIN_TQ, System.Single STP_NIVEL_RETOMA_TQ, bool ignore_STP_NIVEL_RETOMA_TQ, System.Single STP_VAZAO_AD1, bool ignore_STP_VAZAO_AD1, System.Single STP_VAZAO_AD2, bool ignore_STP_VAZAO_AD2, System.Single STP_VAZAO_AD3, bool ignore_STP_VAZAO_AD3, System.Single STP_VEL_INICIAL, bool ignore_STP_VEL_INICIAL, System.Single STP_NIVEL_SUSPENDE, bool ignore_STP_NIVEL_SUSPENDE, System.Single STP_NIVEL_RETOMA, bool ignore_STP_NIVEL_RETOMA, System.Int16 STP_TEMPO_VALVULAS, bool ignore_STP_TEMPO_VALVULAS, System.Int16 STP_DIF_HORAS_BO, bool ignore_STP_DIF_HORAS_BO, System.Int16 STP_TEMPO_SEM_PARTIR, bool ignore_STP_TEMPO_SEM_PARTIR, System.Single STP_VEL_SOPRADORES, bool ignore_STP_VEL_SOPRADORES)
    {
      object[] _values_ = new object[13];
      if (!ignore_HAB_SOPRADORES) _values_[0] = HAB_SOPRADORES;
      if (!ignore_STP_NIVEL_MIN_TQ) _values_[1] = STP_NIVEL_MIN_TQ;
      if (!ignore_STP_NIVEL_RETOMA_TQ) _values_[2] = STP_NIVEL_RETOMA_TQ;
      if (!ignore_STP_VAZAO_AD1) _values_[3] = STP_VAZAO_AD1;
      if (!ignore_STP_VAZAO_AD2) _values_[4] = STP_VAZAO_AD2;
      if (!ignore_STP_VAZAO_AD3) _values_[5] = STP_VAZAO_AD3;
      if (!ignore_STP_VEL_INICIAL) _values_[6] = STP_VEL_INICIAL;
      if (!ignore_STP_NIVEL_SUSPENDE) _values_[7] = STP_NIVEL_SUSPENDE;
      if (!ignore_STP_NIVEL_RETOMA) _values_[8] = STP_NIVEL_RETOMA;
      if (!ignore_STP_TEMPO_VALVULAS) _values_[9] = STP_TEMPO_VALVULAS;
      if (!ignore_STP_DIF_HORAS_BO) _values_[10] = STP_DIF_HORAS_BO;
      if (!ignore_STP_TEMPO_SEM_PARTIR) _values_[11] = STP_TEMPO_SEM_PARTIR;
      if (!ignore_STP_VEL_SOPRADORES) _values_[12] = STP_VEL_SOPRADORES;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_E_COMANDO(System.Boolean CMD_AD1, System.Boolean CMD_AD2, System.Boolean CMD_AD3)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {CMD_AD1, CMD_AD2, CMD_AD3});
    }
    public bool FireEvent_E_COMANDO(Hidryco.HidrycoLib.Symbols.DesidratacaoLodo.E_COMANDOEventArgs ea)
    {
      object[] _values_ = new object[3];
      if (ea.CMD_AD1.HasValue) _values_[0] = ea.CMD_AD1.Value;
      if (ea.CMD_AD2.HasValue) _values_[1] = ea.CMD_AD2.Value;
      if (ea.CMD_AD3.HasValue) _values_[2] = ea.CMD_AD3.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_E_COMANDO(System.Boolean CMD_AD1, bool ignore_CMD_AD1, System.Boolean CMD_AD2, bool ignore_CMD_AD2, System.Boolean CMD_AD3, bool ignore_CMD_AD3)
    {
      object[] _values_ = new object[3];
      if (!ignore_CMD_AD1) _values_[0] = CMD_AD1;
      if (!ignore_CMD_AD2) _values_[1] = CMD_AD2;
      if (!ignore_CMD_AD3) _values_[2] = CMD_AD3;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_E_SV(System.Boolean CMD_SV01, System.Boolean CMD_SV02, System.Boolean CMD_SV03, System.Boolean CMD_SV04, System.Boolean CMD_SV06, System.Boolean CMD_SV08)
    {
      return ((IHMIAccessorOutput)this).FireEvent(2, new object[] {CMD_SV01, CMD_SV02, CMD_SV03, CMD_SV04, CMD_SV06, CMD_SV08});
    }
    public bool FireEvent_E_SV(Hidryco.HidrycoLib.Symbols.DesidratacaoLodo.E_SVEventArgs ea)
    {
      object[] _values_ = new object[6];
      if (ea.CMD_SV01.HasValue) _values_[0] = ea.CMD_SV01.Value;
      if (ea.CMD_SV02.HasValue) _values_[1] = ea.CMD_SV02.Value;
      if (ea.CMD_SV03.HasValue) _values_[2] = ea.CMD_SV03.Value;
      if (ea.CMD_SV04.HasValue) _values_[3] = ea.CMD_SV04.Value;
      if (ea.CMD_SV06.HasValue) _values_[4] = ea.CMD_SV06.Value;
      if (ea.CMD_SV08.HasValue) _values_[5] = ea.CMD_SV08.Value;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_E_SV(System.Boolean CMD_SV01, bool ignore_CMD_SV01, System.Boolean CMD_SV02, bool ignore_CMD_SV02, System.Boolean CMD_SV03, bool ignore_CMD_SV03, System.Boolean CMD_SV04, bool ignore_CMD_SV04, System.Boolean CMD_SV06, bool ignore_CMD_SV06, System.Boolean CMD_SV08, bool ignore_CMD_SV08)
    {
      object[] _values_ = new object[6];
      if (!ignore_CMD_SV01) _values_[0] = CMD_SV01;
      if (!ignore_CMD_SV02) _values_[1] = CMD_SV02;
      if (!ignore_CMD_SV03) _values_[2] = CMD_SV03;
      if (!ignore_CMD_SV04) _values_[3] = CMD_SV04;
      if (!ignore_CMD_SV06) _values_[4] = CMD_SV06;
      if (!ignore_CMD_SV08) _values_[5] = CMD_SV08;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_E_RESET(System.Boolean CMD_RESET)
    {
      return ((IHMIAccessorOutput)this).FireEvent(3, new object[] {CMD_RESET});
    }
    public bool FireEvent_E_RESET(Hidryco.HidrycoLib.Symbols.DesidratacaoLodo.E_RESETEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.CMD_RESET.HasValue) _values_[0] = ea.CMD_RESET.Value;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_E_RESET(System.Boolean CMD_RESET, bool ignore_CMD_RESET)
    {
      object[] _values_ = new object[1];
      if (!ignore_CMD_RESET) _values_[0] = CMD_RESET;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }

  }
}

namespace Hidryco.HidrycoLib.Symbols.DesidratacaoLodo
{
  partial class sSV01
  {

    private event EventHandler<Hidryco.HidrycoLib.Symbols.DesidratacaoLodo.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    private event EventHandler<Hidryco.HidrycoLib.Symbols.DesidratacaoLodo.REQEventArgs> REQ_Fired;

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
              LOAD_PERS_DATA_Fired(this, new Hidryco.HidrycoLib.Symbols.DesidratacaoLodo.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
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
              REQ_Fired(this, new Hidryco.HidrycoLib.Symbols.DesidratacaoLodo.REQEventArgs(channelId, cookie, eventIndex));
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
    public bool FireEvent_E_PARAMETROS(System.Boolean HAB_SOPRADORES, System.Single STP_NIVEL_MIN_TQ, System.Single STP_NIVEL_RETOMA_TQ, System.Single STP_VAZAO_AD1, System.Single STP_VAZAO_AD2, System.Single STP_VAZAO_AD3, System.Single STP_VEL_INICIAL, System.Single STP_NIVEL_SUSPENDE, System.Single STP_NIVEL_RETOMA, System.Int16 STP_TEMPO_VALVULAS, System.Int16 STP_DIF_HORAS_BO, System.Int16 STP_TEMPO_SEM_PARTIR, System.Single STP_VEL_SOPRADORES)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {HAB_SOPRADORES, STP_NIVEL_MIN_TQ, STP_NIVEL_RETOMA_TQ, STP_VAZAO_AD1, STP_VAZAO_AD2, STP_VAZAO_AD3, STP_VEL_INICIAL, STP_NIVEL_SUSPENDE, STP_NIVEL_RETOMA, STP_TEMPO_VALVULAS, STP_DIF_HORAS_BO, STP_TEMPO_SEM_PARTIR, STP_VEL_SOPRADORES});
    }
    public bool FireEvent_E_PARAMETROS(Hidryco.HidrycoLib.Symbols.DesidratacaoLodo.E_PARAMETROSEventArgs ea)
    {
      object[] _values_ = new object[13];
      if (ea.HAB_SOPRADORES.HasValue) _values_[0] = ea.HAB_SOPRADORES.Value;
      if (ea.STP_NIVEL_MIN_TQ.HasValue) _values_[1] = ea.STP_NIVEL_MIN_TQ.Value;
      if (ea.STP_NIVEL_RETOMA_TQ.HasValue) _values_[2] = ea.STP_NIVEL_RETOMA_TQ.Value;
      if (ea.STP_VAZAO_AD1.HasValue) _values_[3] = ea.STP_VAZAO_AD1.Value;
      if (ea.STP_VAZAO_AD2.HasValue) _values_[4] = ea.STP_VAZAO_AD2.Value;
      if (ea.STP_VAZAO_AD3.HasValue) _values_[5] = ea.STP_VAZAO_AD3.Value;
      if (ea.STP_VEL_INICIAL.HasValue) _values_[6] = ea.STP_VEL_INICIAL.Value;
      if (ea.STP_NIVEL_SUSPENDE.HasValue) _values_[7] = ea.STP_NIVEL_SUSPENDE.Value;
      if (ea.STP_NIVEL_RETOMA.HasValue) _values_[8] = ea.STP_NIVEL_RETOMA.Value;
      if (ea.STP_TEMPO_VALVULAS.HasValue) _values_[9] = ea.STP_TEMPO_VALVULAS.Value;
      if (ea.STP_DIF_HORAS_BO.HasValue) _values_[10] = ea.STP_DIF_HORAS_BO.Value;
      if (ea.STP_TEMPO_SEM_PARTIR.HasValue) _values_[11] = ea.STP_TEMPO_SEM_PARTIR.Value;
      if (ea.STP_VEL_SOPRADORES.HasValue) _values_[12] = ea.STP_VEL_SOPRADORES.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_E_PARAMETROS(System.Boolean HAB_SOPRADORES, bool ignore_HAB_SOPRADORES, System.Single STP_NIVEL_MIN_TQ, bool ignore_STP_NIVEL_MIN_TQ, System.Single STP_NIVEL_RETOMA_TQ, bool ignore_STP_NIVEL_RETOMA_TQ, System.Single STP_VAZAO_AD1, bool ignore_STP_VAZAO_AD1, System.Single STP_VAZAO_AD2, bool ignore_STP_VAZAO_AD2, System.Single STP_VAZAO_AD3, bool ignore_STP_VAZAO_AD3, System.Single STP_VEL_INICIAL, bool ignore_STP_VEL_INICIAL, System.Single STP_NIVEL_SUSPENDE, bool ignore_STP_NIVEL_SUSPENDE, System.Single STP_NIVEL_RETOMA, bool ignore_STP_NIVEL_RETOMA, System.Int16 STP_TEMPO_VALVULAS, bool ignore_STP_TEMPO_VALVULAS, System.Int16 STP_DIF_HORAS_BO, bool ignore_STP_DIF_HORAS_BO, System.Int16 STP_TEMPO_SEM_PARTIR, bool ignore_STP_TEMPO_SEM_PARTIR, System.Single STP_VEL_SOPRADORES, bool ignore_STP_VEL_SOPRADORES)
    {
      object[] _values_ = new object[13];
      if (!ignore_HAB_SOPRADORES) _values_[0] = HAB_SOPRADORES;
      if (!ignore_STP_NIVEL_MIN_TQ) _values_[1] = STP_NIVEL_MIN_TQ;
      if (!ignore_STP_NIVEL_RETOMA_TQ) _values_[2] = STP_NIVEL_RETOMA_TQ;
      if (!ignore_STP_VAZAO_AD1) _values_[3] = STP_VAZAO_AD1;
      if (!ignore_STP_VAZAO_AD2) _values_[4] = STP_VAZAO_AD2;
      if (!ignore_STP_VAZAO_AD3) _values_[5] = STP_VAZAO_AD3;
      if (!ignore_STP_VEL_INICIAL) _values_[6] = STP_VEL_INICIAL;
      if (!ignore_STP_NIVEL_SUSPENDE) _values_[7] = STP_NIVEL_SUSPENDE;
      if (!ignore_STP_NIVEL_RETOMA) _values_[8] = STP_NIVEL_RETOMA;
      if (!ignore_STP_TEMPO_VALVULAS) _values_[9] = STP_TEMPO_VALVULAS;
      if (!ignore_STP_DIF_HORAS_BO) _values_[10] = STP_DIF_HORAS_BO;
      if (!ignore_STP_TEMPO_SEM_PARTIR) _values_[11] = STP_TEMPO_SEM_PARTIR;
      if (!ignore_STP_VEL_SOPRADORES) _values_[12] = STP_VEL_SOPRADORES;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_E_COMANDO(System.Boolean CMD_AD1, System.Boolean CMD_AD2, System.Boolean CMD_AD3)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {CMD_AD1, CMD_AD2, CMD_AD3});
    }
    public bool FireEvent_E_COMANDO(Hidryco.HidrycoLib.Symbols.DesidratacaoLodo.E_COMANDOEventArgs ea)
    {
      object[] _values_ = new object[3];
      if (ea.CMD_AD1.HasValue) _values_[0] = ea.CMD_AD1.Value;
      if (ea.CMD_AD2.HasValue) _values_[1] = ea.CMD_AD2.Value;
      if (ea.CMD_AD3.HasValue) _values_[2] = ea.CMD_AD3.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_E_COMANDO(System.Boolean CMD_AD1, bool ignore_CMD_AD1, System.Boolean CMD_AD2, bool ignore_CMD_AD2, System.Boolean CMD_AD3, bool ignore_CMD_AD3)
    {
      object[] _values_ = new object[3];
      if (!ignore_CMD_AD1) _values_[0] = CMD_AD1;
      if (!ignore_CMD_AD2) _values_[1] = CMD_AD2;
      if (!ignore_CMD_AD3) _values_[2] = CMD_AD3;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_E_SV(System.Boolean CMD_SV01, System.Boolean CMD_SV02, System.Boolean CMD_SV03, System.Boolean CMD_SV04, System.Boolean CMD_SV06, System.Boolean CMD_SV08)
    {
      return ((IHMIAccessorOutput)this).FireEvent(2, new object[] {CMD_SV01, CMD_SV02, CMD_SV03, CMD_SV04, CMD_SV06, CMD_SV08});
    }
    public bool FireEvent_E_SV(Hidryco.HidrycoLib.Symbols.DesidratacaoLodo.E_SVEventArgs ea)
    {
      object[] _values_ = new object[6];
      if (ea.CMD_SV01.HasValue) _values_[0] = ea.CMD_SV01.Value;
      if (ea.CMD_SV02.HasValue) _values_[1] = ea.CMD_SV02.Value;
      if (ea.CMD_SV03.HasValue) _values_[2] = ea.CMD_SV03.Value;
      if (ea.CMD_SV04.HasValue) _values_[3] = ea.CMD_SV04.Value;
      if (ea.CMD_SV06.HasValue) _values_[4] = ea.CMD_SV06.Value;
      if (ea.CMD_SV08.HasValue) _values_[5] = ea.CMD_SV08.Value;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_E_SV(System.Boolean CMD_SV01, bool ignore_CMD_SV01, System.Boolean CMD_SV02, bool ignore_CMD_SV02, System.Boolean CMD_SV03, bool ignore_CMD_SV03, System.Boolean CMD_SV04, bool ignore_CMD_SV04, System.Boolean CMD_SV06, bool ignore_CMD_SV06, System.Boolean CMD_SV08, bool ignore_CMD_SV08)
    {
      object[] _values_ = new object[6];
      if (!ignore_CMD_SV01) _values_[0] = CMD_SV01;
      if (!ignore_CMD_SV02) _values_[1] = CMD_SV02;
      if (!ignore_CMD_SV03) _values_[2] = CMD_SV03;
      if (!ignore_CMD_SV04) _values_[3] = CMD_SV04;
      if (!ignore_CMD_SV06) _values_[4] = CMD_SV06;
      if (!ignore_CMD_SV08) _values_[5] = CMD_SV08;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_E_RESET(System.Boolean CMD_RESET)
    {
      return ((IHMIAccessorOutput)this).FireEvent(3, new object[] {CMD_RESET});
    }
    public bool FireEvent_E_RESET(Hidryco.HidrycoLib.Symbols.DesidratacaoLodo.E_RESETEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.CMD_RESET.HasValue) _values_[0] = ea.CMD_RESET.Value;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_E_RESET(System.Boolean CMD_RESET, bool ignore_CMD_RESET)
    {
      object[] _values_ = new object[1];
      if (!ignore_CMD_RESET) _values_[0] = CMD_RESET;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }

  }
}

namespace Hidryco.HidrycoLib.Symbols.DesidratacaoLodo
{
  partial class sSV02
  {

    private event EventHandler<Hidryco.HidrycoLib.Symbols.DesidratacaoLodo.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    private event EventHandler<Hidryco.HidrycoLib.Symbols.DesidratacaoLodo.REQEventArgs> REQ_Fired;

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
              LOAD_PERS_DATA_Fired(this, new Hidryco.HidrycoLib.Symbols.DesidratacaoLodo.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
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
              REQ_Fired(this, new Hidryco.HidrycoLib.Symbols.DesidratacaoLodo.REQEventArgs(channelId, cookie, eventIndex));
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
    public bool FireEvent_E_PARAMETROS(System.Boolean HAB_SOPRADORES, System.Single STP_NIVEL_MIN_TQ, System.Single STP_NIVEL_RETOMA_TQ, System.Single STP_VAZAO_AD1, System.Single STP_VAZAO_AD2, System.Single STP_VAZAO_AD3, System.Single STP_VEL_INICIAL, System.Single STP_NIVEL_SUSPENDE, System.Single STP_NIVEL_RETOMA, System.Int16 STP_TEMPO_VALVULAS, System.Int16 STP_DIF_HORAS_BO, System.Int16 STP_TEMPO_SEM_PARTIR, System.Single STP_VEL_SOPRADORES)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {HAB_SOPRADORES, STP_NIVEL_MIN_TQ, STP_NIVEL_RETOMA_TQ, STP_VAZAO_AD1, STP_VAZAO_AD2, STP_VAZAO_AD3, STP_VEL_INICIAL, STP_NIVEL_SUSPENDE, STP_NIVEL_RETOMA, STP_TEMPO_VALVULAS, STP_DIF_HORAS_BO, STP_TEMPO_SEM_PARTIR, STP_VEL_SOPRADORES});
    }
    public bool FireEvent_E_PARAMETROS(Hidryco.HidrycoLib.Symbols.DesidratacaoLodo.E_PARAMETROSEventArgs ea)
    {
      object[] _values_ = new object[13];
      if (ea.HAB_SOPRADORES.HasValue) _values_[0] = ea.HAB_SOPRADORES.Value;
      if (ea.STP_NIVEL_MIN_TQ.HasValue) _values_[1] = ea.STP_NIVEL_MIN_TQ.Value;
      if (ea.STP_NIVEL_RETOMA_TQ.HasValue) _values_[2] = ea.STP_NIVEL_RETOMA_TQ.Value;
      if (ea.STP_VAZAO_AD1.HasValue) _values_[3] = ea.STP_VAZAO_AD1.Value;
      if (ea.STP_VAZAO_AD2.HasValue) _values_[4] = ea.STP_VAZAO_AD2.Value;
      if (ea.STP_VAZAO_AD3.HasValue) _values_[5] = ea.STP_VAZAO_AD3.Value;
      if (ea.STP_VEL_INICIAL.HasValue) _values_[6] = ea.STP_VEL_INICIAL.Value;
      if (ea.STP_NIVEL_SUSPENDE.HasValue) _values_[7] = ea.STP_NIVEL_SUSPENDE.Value;
      if (ea.STP_NIVEL_RETOMA.HasValue) _values_[8] = ea.STP_NIVEL_RETOMA.Value;
      if (ea.STP_TEMPO_VALVULAS.HasValue) _values_[9] = ea.STP_TEMPO_VALVULAS.Value;
      if (ea.STP_DIF_HORAS_BO.HasValue) _values_[10] = ea.STP_DIF_HORAS_BO.Value;
      if (ea.STP_TEMPO_SEM_PARTIR.HasValue) _values_[11] = ea.STP_TEMPO_SEM_PARTIR.Value;
      if (ea.STP_VEL_SOPRADORES.HasValue) _values_[12] = ea.STP_VEL_SOPRADORES.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_E_PARAMETROS(System.Boolean HAB_SOPRADORES, bool ignore_HAB_SOPRADORES, System.Single STP_NIVEL_MIN_TQ, bool ignore_STP_NIVEL_MIN_TQ, System.Single STP_NIVEL_RETOMA_TQ, bool ignore_STP_NIVEL_RETOMA_TQ, System.Single STP_VAZAO_AD1, bool ignore_STP_VAZAO_AD1, System.Single STP_VAZAO_AD2, bool ignore_STP_VAZAO_AD2, System.Single STP_VAZAO_AD3, bool ignore_STP_VAZAO_AD3, System.Single STP_VEL_INICIAL, bool ignore_STP_VEL_INICIAL, System.Single STP_NIVEL_SUSPENDE, bool ignore_STP_NIVEL_SUSPENDE, System.Single STP_NIVEL_RETOMA, bool ignore_STP_NIVEL_RETOMA, System.Int16 STP_TEMPO_VALVULAS, bool ignore_STP_TEMPO_VALVULAS, System.Int16 STP_DIF_HORAS_BO, bool ignore_STP_DIF_HORAS_BO, System.Int16 STP_TEMPO_SEM_PARTIR, bool ignore_STP_TEMPO_SEM_PARTIR, System.Single STP_VEL_SOPRADORES, bool ignore_STP_VEL_SOPRADORES)
    {
      object[] _values_ = new object[13];
      if (!ignore_HAB_SOPRADORES) _values_[0] = HAB_SOPRADORES;
      if (!ignore_STP_NIVEL_MIN_TQ) _values_[1] = STP_NIVEL_MIN_TQ;
      if (!ignore_STP_NIVEL_RETOMA_TQ) _values_[2] = STP_NIVEL_RETOMA_TQ;
      if (!ignore_STP_VAZAO_AD1) _values_[3] = STP_VAZAO_AD1;
      if (!ignore_STP_VAZAO_AD2) _values_[4] = STP_VAZAO_AD2;
      if (!ignore_STP_VAZAO_AD3) _values_[5] = STP_VAZAO_AD3;
      if (!ignore_STP_VEL_INICIAL) _values_[6] = STP_VEL_INICIAL;
      if (!ignore_STP_NIVEL_SUSPENDE) _values_[7] = STP_NIVEL_SUSPENDE;
      if (!ignore_STP_NIVEL_RETOMA) _values_[8] = STP_NIVEL_RETOMA;
      if (!ignore_STP_TEMPO_VALVULAS) _values_[9] = STP_TEMPO_VALVULAS;
      if (!ignore_STP_DIF_HORAS_BO) _values_[10] = STP_DIF_HORAS_BO;
      if (!ignore_STP_TEMPO_SEM_PARTIR) _values_[11] = STP_TEMPO_SEM_PARTIR;
      if (!ignore_STP_VEL_SOPRADORES) _values_[12] = STP_VEL_SOPRADORES;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_E_COMANDO(System.Boolean CMD_AD1, System.Boolean CMD_AD2, System.Boolean CMD_AD3)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {CMD_AD1, CMD_AD2, CMD_AD3});
    }
    public bool FireEvent_E_COMANDO(Hidryco.HidrycoLib.Symbols.DesidratacaoLodo.E_COMANDOEventArgs ea)
    {
      object[] _values_ = new object[3];
      if (ea.CMD_AD1.HasValue) _values_[0] = ea.CMD_AD1.Value;
      if (ea.CMD_AD2.HasValue) _values_[1] = ea.CMD_AD2.Value;
      if (ea.CMD_AD3.HasValue) _values_[2] = ea.CMD_AD3.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_E_COMANDO(System.Boolean CMD_AD1, bool ignore_CMD_AD1, System.Boolean CMD_AD2, bool ignore_CMD_AD2, System.Boolean CMD_AD3, bool ignore_CMD_AD3)
    {
      object[] _values_ = new object[3];
      if (!ignore_CMD_AD1) _values_[0] = CMD_AD1;
      if (!ignore_CMD_AD2) _values_[1] = CMD_AD2;
      if (!ignore_CMD_AD3) _values_[2] = CMD_AD3;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_E_SV(System.Boolean CMD_SV01, System.Boolean CMD_SV02, System.Boolean CMD_SV03, System.Boolean CMD_SV04, System.Boolean CMD_SV06, System.Boolean CMD_SV08)
    {
      return ((IHMIAccessorOutput)this).FireEvent(2, new object[] {CMD_SV01, CMD_SV02, CMD_SV03, CMD_SV04, CMD_SV06, CMD_SV08});
    }
    public bool FireEvent_E_SV(Hidryco.HidrycoLib.Symbols.DesidratacaoLodo.E_SVEventArgs ea)
    {
      object[] _values_ = new object[6];
      if (ea.CMD_SV01.HasValue) _values_[0] = ea.CMD_SV01.Value;
      if (ea.CMD_SV02.HasValue) _values_[1] = ea.CMD_SV02.Value;
      if (ea.CMD_SV03.HasValue) _values_[2] = ea.CMD_SV03.Value;
      if (ea.CMD_SV04.HasValue) _values_[3] = ea.CMD_SV04.Value;
      if (ea.CMD_SV06.HasValue) _values_[4] = ea.CMD_SV06.Value;
      if (ea.CMD_SV08.HasValue) _values_[5] = ea.CMD_SV08.Value;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_E_SV(System.Boolean CMD_SV01, bool ignore_CMD_SV01, System.Boolean CMD_SV02, bool ignore_CMD_SV02, System.Boolean CMD_SV03, bool ignore_CMD_SV03, System.Boolean CMD_SV04, bool ignore_CMD_SV04, System.Boolean CMD_SV06, bool ignore_CMD_SV06, System.Boolean CMD_SV08, bool ignore_CMD_SV08)
    {
      object[] _values_ = new object[6];
      if (!ignore_CMD_SV01) _values_[0] = CMD_SV01;
      if (!ignore_CMD_SV02) _values_[1] = CMD_SV02;
      if (!ignore_CMD_SV03) _values_[2] = CMD_SV03;
      if (!ignore_CMD_SV04) _values_[3] = CMD_SV04;
      if (!ignore_CMD_SV06) _values_[4] = CMD_SV06;
      if (!ignore_CMD_SV08) _values_[5] = CMD_SV08;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_E_RESET(System.Boolean CMD_RESET)
    {
      return ((IHMIAccessorOutput)this).FireEvent(3, new object[] {CMD_RESET});
    }
    public bool FireEvent_E_RESET(Hidryco.HidrycoLib.Symbols.DesidratacaoLodo.E_RESETEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.CMD_RESET.HasValue) _values_[0] = ea.CMD_RESET.Value;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_E_RESET(System.Boolean CMD_RESET, bool ignore_CMD_RESET)
    {
      object[] _values_ = new object[1];
      if (!ignore_CMD_RESET) _values_[0] = CMD_RESET;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }

  }
}

namespace Hidryco.HidrycoLib.Symbols.DesidratacaoLodo
{
  partial class sSV03
  {

    private event EventHandler<Hidryco.HidrycoLib.Symbols.DesidratacaoLodo.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    private event EventHandler<Hidryco.HidrycoLib.Symbols.DesidratacaoLodo.REQEventArgs> REQ_Fired;

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
              LOAD_PERS_DATA_Fired(this, new Hidryco.HidrycoLib.Symbols.DesidratacaoLodo.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
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
              REQ_Fired(this, new Hidryco.HidrycoLib.Symbols.DesidratacaoLodo.REQEventArgs(channelId, cookie, eventIndex));
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
    public bool FireEvent_E_PARAMETROS(System.Boolean HAB_SOPRADORES, System.Single STP_NIVEL_MIN_TQ, System.Single STP_NIVEL_RETOMA_TQ, System.Single STP_VAZAO_AD1, System.Single STP_VAZAO_AD2, System.Single STP_VAZAO_AD3, System.Single STP_VEL_INICIAL, System.Single STP_NIVEL_SUSPENDE, System.Single STP_NIVEL_RETOMA, System.Int16 STP_TEMPO_VALVULAS, System.Int16 STP_DIF_HORAS_BO, System.Int16 STP_TEMPO_SEM_PARTIR, System.Single STP_VEL_SOPRADORES)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {HAB_SOPRADORES, STP_NIVEL_MIN_TQ, STP_NIVEL_RETOMA_TQ, STP_VAZAO_AD1, STP_VAZAO_AD2, STP_VAZAO_AD3, STP_VEL_INICIAL, STP_NIVEL_SUSPENDE, STP_NIVEL_RETOMA, STP_TEMPO_VALVULAS, STP_DIF_HORAS_BO, STP_TEMPO_SEM_PARTIR, STP_VEL_SOPRADORES});
    }
    public bool FireEvent_E_PARAMETROS(Hidryco.HidrycoLib.Symbols.DesidratacaoLodo.E_PARAMETROSEventArgs ea)
    {
      object[] _values_ = new object[13];
      if (ea.HAB_SOPRADORES.HasValue) _values_[0] = ea.HAB_SOPRADORES.Value;
      if (ea.STP_NIVEL_MIN_TQ.HasValue) _values_[1] = ea.STP_NIVEL_MIN_TQ.Value;
      if (ea.STP_NIVEL_RETOMA_TQ.HasValue) _values_[2] = ea.STP_NIVEL_RETOMA_TQ.Value;
      if (ea.STP_VAZAO_AD1.HasValue) _values_[3] = ea.STP_VAZAO_AD1.Value;
      if (ea.STP_VAZAO_AD2.HasValue) _values_[4] = ea.STP_VAZAO_AD2.Value;
      if (ea.STP_VAZAO_AD3.HasValue) _values_[5] = ea.STP_VAZAO_AD3.Value;
      if (ea.STP_VEL_INICIAL.HasValue) _values_[6] = ea.STP_VEL_INICIAL.Value;
      if (ea.STP_NIVEL_SUSPENDE.HasValue) _values_[7] = ea.STP_NIVEL_SUSPENDE.Value;
      if (ea.STP_NIVEL_RETOMA.HasValue) _values_[8] = ea.STP_NIVEL_RETOMA.Value;
      if (ea.STP_TEMPO_VALVULAS.HasValue) _values_[9] = ea.STP_TEMPO_VALVULAS.Value;
      if (ea.STP_DIF_HORAS_BO.HasValue) _values_[10] = ea.STP_DIF_HORAS_BO.Value;
      if (ea.STP_TEMPO_SEM_PARTIR.HasValue) _values_[11] = ea.STP_TEMPO_SEM_PARTIR.Value;
      if (ea.STP_VEL_SOPRADORES.HasValue) _values_[12] = ea.STP_VEL_SOPRADORES.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_E_PARAMETROS(System.Boolean HAB_SOPRADORES, bool ignore_HAB_SOPRADORES, System.Single STP_NIVEL_MIN_TQ, bool ignore_STP_NIVEL_MIN_TQ, System.Single STP_NIVEL_RETOMA_TQ, bool ignore_STP_NIVEL_RETOMA_TQ, System.Single STP_VAZAO_AD1, bool ignore_STP_VAZAO_AD1, System.Single STP_VAZAO_AD2, bool ignore_STP_VAZAO_AD2, System.Single STP_VAZAO_AD3, bool ignore_STP_VAZAO_AD3, System.Single STP_VEL_INICIAL, bool ignore_STP_VEL_INICIAL, System.Single STP_NIVEL_SUSPENDE, bool ignore_STP_NIVEL_SUSPENDE, System.Single STP_NIVEL_RETOMA, bool ignore_STP_NIVEL_RETOMA, System.Int16 STP_TEMPO_VALVULAS, bool ignore_STP_TEMPO_VALVULAS, System.Int16 STP_DIF_HORAS_BO, bool ignore_STP_DIF_HORAS_BO, System.Int16 STP_TEMPO_SEM_PARTIR, bool ignore_STP_TEMPO_SEM_PARTIR, System.Single STP_VEL_SOPRADORES, bool ignore_STP_VEL_SOPRADORES)
    {
      object[] _values_ = new object[13];
      if (!ignore_HAB_SOPRADORES) _values_[0] = HAB_SOPRADORES;
      if (!ignore_STP_NIVEL_MIN_TQ) _values_[1] = STP_NIVEL_MIN_TQ;
      if (!ignore_STP_NIVEL_RETOMA_TQ) _values_[2] = STP_NIVEL_RETOMA_TQ;
      if (!ignore_STP_VAZAO_AD1) _values_[3] = STP_VAZAO_AD1;
      if (!ignore_STP_VAZAO_AD2) _values_[4] = STP_VAZAO_AD2;
      if (!ignore_STP_VAZAO_AD3) _values_[5] = STP_VAZAO_AD3;
      if (!ignore_STP_VEL_INICIAL) _values_[6] = STP_VEL_INICIAL;
      if (!ignore_STP_NIVEL_SUSPENDE) _values_[7] = STP_NIVEL_SUSPENDE;
      if (!ignore_STP_NIVEL_RETOMA) _values_[8] = STP_NIVEL_RETOMA;
      if (!ignore_STP_TEMPO_VALVULAS) _values_[9] = STP_TEMPO_VALVULAS;
      if (!ignore_STP_DIF_HORAS_BO) _values_[10] = STP_DIF_HORAS_BO;
      if (!ignore_STP_TEMPO_SEM_PARTIR) _values_[11] = STP_TEMPO_SEM_PARTIR;
      if (!ignore_STP_VEL_SOPRADORES) _values_[12] = STP_VEL_SOPRADORES;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_E_COMANDO(System.Boolean CMD_AD1, System.Boolean CMD_AD2, System.Boolean CMD_AD3)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {CMD_AD1, CMD_AD2, CMD_AD3});
    }
    public bool FireEvent_E_COMANDO(Hidryco.HidrycoLib.Symbols.DesidratacaoLodo.E_COMANDOEventArgs ea)
    {
      object[] _values_ = new object[3];
      if (ea.CMD_AD1.HasValue) _values_[0] = ea.CMD_AD1.Value;
      if (ea.CMD_AD2.HasValue) _values_[1] = ea.CMD_AD2.Value;
      if (ea.CMD_AD3.HasValue) _values_[2] = ea.CMD_AD3.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_E_COMANDO(System.Boolean CMD_AD1, bool ignore_CMD_AD1, System.Boolean CMD_AD2, bool ignore_CMD_AD2, System.Boolean CMD_AD3, bool ignore_CMD_AD3)
    {
      object[] _values_ = new object[3];
      if (!ignore_CMD_AD1) _values_[0] = CMD_AD1;
      if (!ignore_CMD_AD2) _values_[1] = CMD_AD2;
      if (!ignore_CMD_AD3) _values_[2] = CMD_AD3;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_E_SV(System.Boolean CMD_SV01, System.Boolean CMD_SV02, System.Boolean CMD_SV03, System.Boolean CMD_SV04, System.Boolean CMD_SV06, System.Boolean CMD_SV08)
    {
      return ((IHMIAccessorOutput)this).FireEvent(2, new object[] {CMD_SV01, CMD_SV02, CMD_SV03, CMD_SV04, CMD_SV06, CMD_SV08});
    }
    public bool FireEvent_E_SV(Hidryco.HidrycoLib.Symbols.DesidratacaoLodo.E_SVEventArgs ea)
    {
      object[] _values_ = new object[6];
      if (ea.CMD_SV01.HasValue) _values_[0] = ea.CMD_SV01.Value;
      if (ea.CMD_SV02.HasValue) _values_[1] = ea.CMD_SV02.Value;
      if (ea.CMD_SV03.HasValue) _values_[2] = ea.CMD_SV03.Value;
      if (ea.CMD_SV04.HasValue) _values_[3] = ea.CMD_SV04.Value;
      if (ea.CMD_SV06.HasValue) _values_[4] = ea.CMD_SV06.Value;
      if (ea.CMD_SV08.HasValue) _values_[5] = ea.CMD_SV08.Value;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_E_SV(System.Boolean CMD_SV01, bool ignore_CMD_SV01, System.Boolean CMD_SV02, bool ignore_CMD_SV02, System.Boolean CMD_SV03, bool ignore_CMD_SV03, System.Boolean CMD_SV04, bool ignore_CMD_SV04, System.Boolean CMD_SV06, bool ignore_CMD_SV06, System.Boolean CMD_SV08, bool ignore_CMD_SV08)
    {
      object[] _values_ = new object[6];
      if (!ignore_CMD_SV01) _values_[0] = CMD_SV01;
      if (!ignore_CMD_SV02) _values_[1] = CMD_SV02;
      if (!ignore_CMD_SV03) _values_[2] = CMD_SV03;
      if (!ignore_CMD_SV04) _values_[3] = CMD_SV04;
      if (!ignore_CMD_SV06) _values_[4] = CMD_SV06;
      if (!ignore_CMD_SV08) _values_[5] = CMD_SV08;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_E_RESET(System.Boolean CMD_RESET)
    {
      return ((IHMIAccessorOutput)this).FireEvent(3, new object[] {CMD_RESET});
    }
    public bool FireEvent_E_RESET(Hidryco.HidrycoLib.Symbols.DesidratacaoLodo.E_RESETEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.CMD_RESET.HasValue) _values_[0] = ea.CMD_RESET.Value;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_E_RESET(System.Boolean CMD_RESET, bool ignore_CMD_RESET)
    {
      object[] _values_ = new object[1];
      if (!ignore_CMD_RESET) _values_[0] = CMD_RESET;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }

  }
}

namespace Hidryco.HidrycoLib.Symbols.DesidratacaoLodo
{
  partial class sSV04
  {

    private event EventHandler<Hidryco.HidrycoLib.Symbols.DesidratacaoLodo.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    private event EventHandler<Hidryco.HidrycoLib.Symbols.DesidratacaoLodo.REQEventArgs> REQ_Fired;

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
              LOAD_PERS_DATA_Fired(this, new Hidryco.HidrycoLib.Symbols.DesidratacaoLodo.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
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
              REQ_Fired(this, new Hidryco.HidrycoLib.Symbols.DesidratacaoLodo.REQEventArgs(channelId, cookie, eventIndex));
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
    public bool FireEvent_E_PARAMETROS(System.Boolean HAB_SOPRADORES, System.Single STP_NIVEL_MIN_TQ, System.Single STP_NIVEL_RETOMA_TQ, System.Single STP_VAZAO_AD1, System.Single STP_VAZAO_AD2, System.Single STP_VAZAO_AD3, System.Single STP_VEL_INICIAL, System.Single STP_NIVEL_SUSPENDE, System.Single STP_NIVEL_RETOMA, System.Int16 STP_TEMPO_VALVULAS, System.Int16 STP_DIF_HORAS_BO, System.Int16 STP_TEMPO_SEM_PARTIR, System.Single STP_VEL_SOPRADORES)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {HAB_SOPRADORES, STP_NIVEL_MIN_TQ, STP_NIVEL_RETOMA_TQ, STP_VAZAO_AD1, STP_VAZAO_AD2, STP_VAZAO_AD3, STP_VEL_INICIAL, STP_NIVEL_SUSPENDE, STP_NIVEL_RETOMA, STP_TEMPO_VALVULAS, STP_DIF_HORAS_BO, STP_TEMPO_SEM_PARTIR, STP_VEL_SOPRADORES});
    }
    public bool FireEvent_E_PARAMETROS(Hidryco.HidrycoLib.Symbols.DesidratacaoLodo.E_PARAMETROSEventArgs ea)
    {
      object[] _values_ = new object[13];
      if (ea.HAB_SOPRADORES.HasValue) _values_[0] = ea.HAB_SOPRADORES.Value;
      if (ea.STP_NIVEL_MIN_TQ.HasValue) _values_[1] = ea.STP_NIVEL_MIN_TQ.Value;
      if (ea.STP_NIVEL_RETOMA_TQ.HasValue) _values_[2] = ea.STP_NIVEL_RETOMA_TQ.Value;
      if (ea.STP_VAZAO_AD1.HasValue) _values_[3] = ea.STP_VAZAO_AD1.Value;
      if (ea.STP_VAZAO_AD2.HasValue) _values_[4] = ea.STP_VAZAO_AD2.Value;
      if (ea.STP_VAZAO_AD3.HasValue) _values_[5] = ea.STP_VAZAO_AD3.Value;
      if (ea.STP_VEL_INICIAL.HasValue) _values_[6] = ea.STP_VEL_INICIAL.Value;
      if (ea.STP_NIVEL_SUSPENDE.HasValue) _values_[7] = ea.STP_NIVEL_SUSPENDE.Value;
      if (ea.STP_NIVEL_RETOMA.HasValue) _values_[8] = ea.STP_NIVEL_RETOMA.Value;
      if (ea.STP_TEMPO_VALVULAS.HasValue) _values_[9] = ea.STP_TEMPO_VALVULAS.Value;
      if (ea.STP_DIF_HORAS_BO.HasValue) _values_[10] = ea.STP_DIF_HORAS_BO.Value;
      if (ea.STP_TEMPO_SEM_PARTIR.HasValue) _values_[11] = ea.STP_TEMPO_SEM_PARTIR.Value;
      if (ea.STP_VEL_SOPRADORES.HasValue) _values_[12] = ea.STP_VEL_SOPRADORES.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_E_PARAMETROS(System.Boolean HAB_SOPRADORES, bool ignore_HAB_SOPRADORES, System.Single STP_NIVEL_MIN_TQ, bool ignore_STP_NIVEL_MIN_TQ, System.Single STP_NIVEL_RETOMA_TQ, bool ignore_STP_NIVEL_RETOMA_TQ, System.Single STP_VAZAO_AD1, bool ignore_STP_VAZAO_AD1, System.Single STP_VAZAO_AD2, bool ignore_STP_VAZAO_AD2, System.Single STP_VAZAO_AD3, bool ignore_STP_VAZAO_AD3, System.Single STP_VEL_INICIAL, bool ignore_STP_VEL_INICIAL, System.Single STP_NIVEL_SUSPENDE, bool ignore_STP_NIVEL_SUSPENDE, System.Single STP_NIVEL_RETOMA, bool ignore_STP_NIVEL_RETOMA, System.Int16 STP_TEMPO_VALVULAS, bool ignore_STP_TEMPO_VALVULAS, System.Int16 STP_DIF_HORAS_BO, bool ignore_STP_DIF_HORAS_BO, System.Int16 STP_TEMPO_SEM_PARTIR, bool ignore_STP_TEMPO_SEM_PARTIR, System.Single STP_VEL_SOPRADORES, bool ignore_STP_VEL_SOPRADORES)
    {
      object[] _values_ = new object[13];
      if (!ignore_HAB_SOPRADORES) _values_[0] = HAB_SOPRADORES;
      if (!ignore_STP_NIVEL_MIN_TQ) _values_[1] = STP_NIVEL_MIN_TQ;
      if (!ignore_STP_NIVEL_RETOMA_TQ) _values_[2] = STP_NIVEL_RETOMA_TQ;
      if (!ignore_STP_VAZAO_AD1) _values_[3] = STP_VAZAO_AD1;
      if (!ignore_STP_VAZAO_AD2) _values_[4] = STP_VAZAO_AD2;
      if (!ignore_STP_VAZAO_AD3) _values_[5] = STP_VAZAO_AD3;
      if (!ignore_STP_VEL_INICIAL) _values_[6] = STP_VEL_INICIAL;
      if (!ignore_STP_NIVEL_SUSPENDE) _values_[7] = STP_NIVEL_SUSPENDE;
      if (!ignore_STP_NIVEL_RETOMA) _values_[8] = STP_NIVEL_RETOMA;
      if (!ignore_STP_TEMPO_VALVULAS) _values_[9] = STP_TEMPO_VALVULAS;
      if (!ignore_STP_DIF_HORAS_BO) _values_[10] = STP_DIF_HORAS_BO;
      if (!ignore_STP_TEMPO_SEM_PARTIR) _values_[11] = STP_TEMPO_SEM_PARTIR;
      if (!ignore_STP_VEL_SOPRADORES) _values_[12] = STP_VEL_SOPRADORES;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_E_COMANDO(System.Boolean CMD_AD1, System.Boolean CMD_AD2, System.Boolean CMD_AD3)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {CMD_AD1, CMD_AD2, CMD_AD3});
    }
    public bool FireEvent_E_COMANDO(Hidryco.HidrycoLib.Symbols.DesidratacaoLodo.E_COMANDOEventArgs ea)
    {
      object[] _values_ = new object[3];
      if (ea.CMD_AD1.HasValue) _values_[0] = ea.CMD_AD1.Value;
      if (ea.CMD_AD2.HasValue) _values_[1] = ea.CMD_AD2.Value;
      if (ea.CMD_AD3.HasValue) _values_[2] = ea.CMD_AD3.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_E_COMANDO(System.Boolean CMD_AD1, bool ignore_CMD_AD1, System.Boolean CMD_AD2, bool ignore_CMD_AD2, System.Boolean CMD_AD3, bool ignore_CMD_AD3)
    {
      object[] _values_ = new object[3];
      if (!ignore_CMD_AD1) _values_[0] = CMD_AD1;
      if (!ignore_CMD_AD2) _values_[1] = CMD_AD2;
      if (!ignore_CMD_AD3) _values_[2] = CMD_AD3;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_E_SV(System.Boolean CMD_SV01, System.Boolean CMD_SV02, System.Boolean CMD_SV03, System.Boolean CMD_SV04, System.Boolean CMD_SV06, System.Boolean CMD_SV08)
    {
      return ((IHMIAccessorOutput)this).FireEvent(2, new object[] {CMD_SV01, CMD_SV02, CMD_SV03, CMD_SV04, CMD_SV06, CMD_SV08});
    }
    public bool FireEvent_E_SV(Hidryco.HidrycoLib.Symbols.DesidratacaoLodo.E_SVEventArgs ea)
    {
      object[] _values_ = new object[6];
      if (ea.CMD_SV01.HasValue) _values_[0] = ea.CMD_SV01.Value;
      if (ea.CMD_SV02.HasValue) _values_[1] = ea.CMD_SV02.Value;
      if (ea.CMD_SV03.HasValue) _values_[2] = ea.CMD_SV03.Value;
      if (ea.CMD_SV04.HasValue) _values_[3] = ea.CMD_SV04.Value;
      if (ea.CMD_SV06.HasValue) _values_[4] = ea.CMD_SV06.Value;
      if (ea.CMD_SV08.HasValue) _values_[5] = ea.CMD_SV08.Value;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_E_SV(System.Boolean CMD_SV01, bool ignore_CMD_SV01, System.Boolean CMD_SV02, bool ignore_CMD_SV02, System.Boolean CMD_SV03, bool ignore_CMD_SV03, System.Boolean CMD_SV04, bool ignore_CMD_SV04, System.Boolean CMD_SV06, bool ignore_CMD_SV06, System.Boolean CMD_SV08, bool ignore_CMD_SV08)
    {
      object[] _values_ = new object[6];
      if (!ignore_CMD_SV01) _values_[0] = CMD_SV01;
      if (!ignore_CMD_SV02) _values_[1] = CMD_SV02;
      if (!ignore_CMD_SV03) _values_[2] = CMD_SV03;
      if (!ignore_CMD_SV04) _values_[3] = CMD_SV04;
      if (!ignore_CMD_SV06) _values_[4] = CMD_SV06;
      if (!ignore_CMD_SV08) _values_[5] = CMD_SV08;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_E_RESET(System.Boolean CMD_RESET)
    {
      return ((IHMIAccessorOutput)this).FireEvent(3, new object[] {CMD_RESET});
    }
    public bool FireEvent_E_RESET(Hidryco.HidrycoLib.Symbols.DesidratacaoLodo.E_RESETEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.CMD_RESET.HasValue) _values_[0] = ea.CMD_RESET.Value;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_E_RESET(System.Boolean CMD_RESET, bool ignore_CMD_RESET)
    {
      object[] _values_ = new object[1];
      if (!ignore_CMD_RESET) _values_[0] = CMD_RESET;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }

  }
}

namespace Hidryco.HidrycoLib.Symbols.DesidratacaoLodo
{
  partial class sSV06
  {

    private event EventHandler<Hidryco.HidrycoLib.Symbols.DesidratacaoLodo.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    private event EventHandler<Hidryco.HidrycoLib.Symbols.DesidratacaoLodo.REQEventArgs> REQ_Fired;

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
              LOAD_PERS_DATA_Fired(this, new Hidryco.HidrycoLib.Symbols.DesidratacaoLodo.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
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
              REQ_Fired(this, new Hidryco.HidrycoLib.Symbols.DesidratacaoLodo.REQEventArgs(channelId, cookie, eventIndex));
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
    public bool FireEvent_E_PARAMETROS(System.Boolean HAB_SOPRADORES, System.Single STP_NIVEL_MIN_TQ, System.Single STP_NIVEL_RETOMA_TQ, System.Single STP_VAZAO_AD1, System.Single STP_VAZAO_AD2, System.Single STP_VAZAO_AD3, System.Single STP_VEL_INICIAL, System.Single STP_NIVEL_SUSPENDE, System.Single STP_NIVEL_RETOMA, System.Int16 STP_TEMPO_VALVULAS, System.Int16 STP_DIF_HORAS_BO, System.Int16 STP_TEMPO_SEM_PARTIR, System.Single STP_VEL_SOPRADORES)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {HAB_SOPRADORES, STP_NIVEL_MIN_TQ, STP_NIVEL_RETOMA_TQ, STP_VAZAO_AD1, STP_VAZAO_AD2, STP_VAZAO_AD3, STP_VEL_INICIAL, STP_NIVEL_SUSPENDE, STP_NIVEL_RETOMA, STP_TEMPO_VALVULAS, STP_DIF_HORAS_BO, STP_TEMPO_SEM_PARTIR, STP_VEL_SOPRADORES});
    }
    public bool FireEvent_E_PARAMETROS(Hidryco.HidrycoLib.Symbols.DesidratacaoLodo.E_PARAMETROSEventArgs ea)
    {
      object[] _values_ = new object[13];
      if (ea.HAB_SOPRADORES.HasValue) _values_[0] = ea.HAB_SOPRADORES.Value;
      if (ea.STP_NIVEL_MIN_TQ.HasValue) _values_[1] = ea.STP_NIVEL_MIN_TQ.Value;
      if (ea.STP_NIVEL_RETOMA_TQ.HasValue) _values_[2] = ea.STP_NIVEL_RETOMA_TQ.Value;
      if (ea.STP_VAZAO_AD1.HasValue) _values_[3] = ea.STP_VAZAO_AD1.Value;
      if (ea.STP_VAZAO_AD2.HasValue) _values_[4] = ea.STP_VAZAO_AD2.Value;
      if (ea.STP_VAZAO_AD3.HasValue) _values_[5] = ea.STP_VAZAO_AD3.Value;
      if (ea.STP_VEL_INICIAL.HasValue) _values_[6] = ea.STP_VEL_INICIAL.Value;
      if (ea.STP_NIVEL_SUSPENDE.HasValue) _values_[7] = ea.STP_NIVEL_SUSPENDE.Value;
      if (ea.STP_NIVEL_RETOMA.HasValue) _values_[8] = ea.STP_NIVEL_RETOMA.Value;
      if (ea.STP_TEMPO_VALVULAS.HasValue) _values_[9] = ea.STP_TEMPO_VALVULAS.Value;
      if (ea.STP_DIF_HORAS_BO.HasValue) _values_[10] = ea.STP_DIF_HORAS_BO.Value;
      if (ea.STP_TEMPO_SEM_PARTIR.HasValue) _values_[11] = ea.STP_TEMPO_SEM_PARTIR.Value;
      if (ea.STP_VEL_SOPRADORES.HasValue) _values_[12] = ea.STP_VEL_SOPRADORES.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_E_PARAMETROS(System.Boolean HAB_SOPRADORES, bool ignore_HAB_SOPRADORES, System.Single STP_NIVEL_MIN_TQ, bool ignore_STP_NIVEL_MIN_TQ, System.Single STP_NIVEL_RETOMA_TQ, bool ignore_STP_NIVEL_RETOMA_TQ, System.Single STP_VAZAO_AD1, bool ignore_STP_VAZAO_AD1, System.Single STP_VAZAO_AD2, bool ignore_STP_VAZAO_AD2, System.Single STP_VAZAO_AD3, bool ignore_STP_VAZAO_AD3, System.Single STP_VEL_INICIAL, bool ignore_STP_VEL_INICIAL, System.Single STP_NIVEL_SUSPENDE, bool ignore_STP_NIVEL_SUSPENDE, System.Single STP_NIVEL_RETOMA, bool ignore_STP_NIVEL_RETOMA, System.Int16 STP_TEMPO_VALVULAS, bool ignore_STP_TEMPO_VALVULAS, System.Int16 STP_DIF_HORAS_BO, bool ignore_STP_DIF_HORAS_BO, System.Int16 STP_TEMPO_SEM_PARTIR, bool ignore_STP_TEMPO_SEM_PARTIR, System.Single STP_VEL_SOPRADORES, bool ignore_STP_VEL_SOPRADORES)
    {
      object[] _values_ = new object[13];
      if (!ignore_HAB_SOPRADORES) _values_[0] = HAB_SOPRADORES;
      if (!ignore_STP_NIVEL_MIN_TQ) _values_[1] = STP_NIVEL_MIN_TQ;
      if (!ignore_STP_NIVEL_RETOMA_TQ) _values_[2] = STP_NIVEL_RETOMA_TQ;
      if (!ignore_STP_VAZAO_AD1) _values_[3] = STP_VAZAO_AD1;
      if (!ignore_STP_VAZAO_AD2) _values_[4] = STP_VAZAO_AD2;
      if (!ignore_STP_VAZAO_AD3) _values_[5] = STP_VAZAO_AD3;
      if (!ignore_STP_VEL_INICIAL) _values_[6] = STP_VEL_INICIAL;
      if (!ignore_STP_NIVEL_SUSPENDE) _values_[7] = STP_NIVEL_SUSPENDE;
      if (!ignore_STP_NIVEL_RETOMA) _values_[8] = STP_NIVEL_RETOMA;
      if (!ignore_STP_TEMPO_VALVULAS) _values_[9] = STP_TEMPO_VALVULAS;
      if (!ignore_STP_DIF_HORAS_BO) _values_[10] = STP_DIF_HORAS_BO;
      if (!ignore_STP_TEMPO_SEM_PARTIR) _values_[11] = STP_TEMPO_SEM_PARTIR;
      if (!ignore_STP_VEL_SOPRADORES) _values_[12] = STP_VEL_SOPRADORES;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_E_COMANDO(System.Boolean CMD_AD1, System.Boolean CMD_AD2, System.Boolean CMD_AD3)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {CMD_AD1, CMD_AD2, CMD_AD3});
    }
    public bool FireEvent_E_COMANDO(Hidryco.HidrycoLib.Symbols.DesidratacaoLodo.E_COMANDOEventArgs ea)
    {
      object[] _values_ = new object[3];
      if (ea.CMD_AD1.HasValue) _values_[0] = ea.CMD_AD1.Value;
      if (ea.CMD_AD2.HasValue) _values_[1] = ea.CMD_AD2.Value;
      if (ea.CMD_AD3.HasValue) _values_[2] = ea.CMD_AD3.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_E_COMANDO(System.Boolean CMD_AD1, bool ignore_CMD_AD1, System.Boolean CMD_AD2, bool ignore_CMD_AD2, System.Boolean CMD_AD3, bool ignore_CMD_AD3)
    {
      object[] _values_ = new object[3];
      if (!ignore_CMD_AD1) _values_[0] = CMD_AD1;
      if (!ignore_CMD_AD2) _values_[1] = CMD_AD2;
      if (!ignore_CMD_AD3) _values_[2] = CMD_AD3;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_E_SV(System.Boolean CMD_SV01, System.Boolean CMD_SV02, System.Boolean CMD_SV03, System.Boolean CMD_SV04, System.Boolean CMD_SV06, System.Boolean CMD_SV08)
    {
      return ((IHMIAccessorOutput)this).FireEvent(2, new object[] {CMD_SV01, CMD_SV02, CMD_SV03, CMD_SV04, CMD_SV06, CMD_SV08});
    }
    public bool FireEvent_E_SV(Hidryco.HidrycoLib.Symbols.DesidratacaoLodo.E_SVEventArgs ea)
    {
      object[] _values_ = new object[6];
      if (ea.CMD_SV01.HasValue) _values_[0] = ea.CMD_SV01.Value;
      if (ea.CMD_SV02.HasValue) _values_[1] = ea.CMD_SV02.Value;
      if (ea.CMD_SV03.HasValue) _values_[2] = ea.CMD_SV03.Value;
      if (ea.CMD_SV04.HasValue) _values_[3] = ea.CMD_SV04.Value;
      if (ea.CMD_SV06.HasValue) _values_[4] = ea.CMD_SV06.Value;
      if (ea.CMD_SV08.HasValue) _values_[5] = ea.CMD_SV08.Value;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_E_SV(System.Boolean CMD_SV01, bool ignore_CMD_SV01, System.Boolean CMD_SV02, bool ignore_CMD_SV02, System.Boolean CMD_SV03, bool ignore_CMD_SV03, System.Boolean CMD_SV04, bool ignore_CMD_SV04, System.Boolean CMD_SV06, bool ignore_CMD_SV06, System.Boolean CMD_SV08, bool ignore_CMD_SV08)
    {
      object[] _values_ = new object[6];
      if (!ignore_CMD_SV01) _values_[0] = CMD_SV01;
      if (!ignore_CMD_SV02) _values_[1] = CMD_SV02;
      if (!ignore_CMD_SV03) _values_[2] = CMD_SV03;
      if (!ignore_CMD_SV04) _values_[3] = CMD_SV04;
      if (!ignore_CMD_SV06) _values_[4] = CMD_SV06;
      if (!ignore_CMD_SV08) _values_[5] = CMD_SV08;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_E_RESET(System.Boolean CMD_RESET)
    {
      return ((IHMIAccessorOutput)this).FireEvent(3, new object[] {CMD_RESET});
    }
    public bool FireEvent_E_RESET(Hidryco.HidrycoLib.Symbols.DesidratacaoLodo.E_RESETEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.CMD_RESET.HasValue) _values_[0] = ea.CMD_RESET.Value;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_E_RESET(System.Boolean CMD_RESET, bool ignore_CMD_RESET)
    {
      object[] _values_ = new object[1];
      if (!ignore_CMD_RESET) _values_[0] = CMD_RESET;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }

  }
}

namespace Hidryco.HidrycoLib.Symbols.DesidratacaoLodo
{
  partial class sSV08
  {

    private event EventHandler<Hidryco.HidrycoLib.Symbols.DesidratacaoLodo.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    private event EventHandler<Hidryco.HidrycoLib.Symbols.DesidratacaoLodo.REQEventArgs> REQ_Fired;

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
              LOAD_PERS_DATA_Fired(this, new Hidryco.HidrycoLib.Symbols.DesidratacaoLodo.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
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
              REQ_Fired(this, new Hidryco.HidrycoLib.Symbols.DesidratacaoLodo.REQEventArgs(channelId, cookie, eventIndex));
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
    public bool FireEvent_E_PARAMETROS(System.Boolean HAB_SOPRADORES, System.Single STP_NIVEL_MIN_TQ, System.Single STP_NIVEL_RETOMA_TQ, System.Single STP_VAZAO_AD1, System.Single STP_VAZAO_AD2, System.Single STP_VAZAO_AD3, System.Single STP_VEL_INICIAL, System.Single STP_NIVEL_SUSPENDE, System.Single STP_NIVEL_RETOMA, System.Int16 STP_TEMPO_VALVULAS, System.Int16 STP_DIF_HORAS_BO, System.Int16 STP_TEMPO_SEM_PARTIR, System.Single STP_VEL_SOPRADORES)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {HAB_SOPRADORES, STP_NIVEL_MIN_TQ, STP_NIVEL_RETOMA_TQ, STP_VAZAO_AD1, STP_VAZAO_AD2, STP_VAZAO_AD3, STP_VEL_INICIAL, STP_NIVEL_SUSPENDE, STP_NIVEL_RETOMA, STP_TEMPO_VALVULAS, STP_DIF_HORAS_BO, STP_TEMPO_SEM_PARTIR, STP_VEL_SOPRADORES});
    }
    public bool FireEvent_E_PARAMETROS(Hidryco.HidrycoLib.Symbols.DesidratacaoLodo.E_PARAMETROSEventArgs ea)
    {
      object[] _values_ = new object[13];
      if (ea.HAB_SOPRADORES.HasValue) _values_[0] = ea.HAB_SOPRADORES.Value;
      if (ea.STP_NIVEL_MIN_TQ.HasValue) _values_[1] = ea.STP_NIVEL_MIN_TQ.Value;
      if (ea.STP_NIVEL_RETOMA_TQ.HasValue) _values_[2] = ea.STP_NIVEL_RETOMA_TQ.Value;
      if (ea.STP_VAZAO_AD1.HasValue) _values_[3] = ea.STP_VAZAO_AD1.Value;
      if (ea.STP_VAZAO_AD2.HasValue) _values_[4] = ea.STP_VAZAO_AD2.Value;
      if (ea.STP_VAZAO_AD3.HasValue) _values_[5] = ea.STP_VAZAO_AD3.Value;
      if (ea.STP_VEL_INICIAL.HasValue) _values_[6] = ea.STP_VEL_INICIAL.Value;
      if (ea.STP_NIVEL_SUSPENDE.HasValue) _values_[7] = ea.STP_NIVEL_SUSPENDE.Value;
      if (ea.STP_NIVEL_RETOMA.HasValue) _values_[8] = ea.STP_NIVEL_RETOMA.Value;
      if (ea.STP_TEMPO_VALVULAS.HasValue) _values_[9] = ea.STP_TEMPO_VALVULAS.Value;
      if (ea.STP_DIF_HORAS_BO.HasValue) _values_[10] = ea.STP_DIF_HORAS_BO.Value;
      if (ea.STP_TEMPO_SEM_PARTIR.HasValue) _values_[11] = ea.STP_TEMPO_SEM_PARTIR.Value;
      if (ea.STP_VEL_SOPRADORES.HasValue) _values_[12] = ea.STP_VEL_SOPRADORES.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_E_PARAMETROS(System.Boolean HAB_SOPRADORES, bool ignore_HAB_SOPRADORES, System.Single STP_NIVEL_MIN_TQ, bool ignore_STP_NIVEL_MIN_TQ, System.Single STP_NIVEL_RETOMA_TQ, bool ignore_STP_NIVEL_RETOMA_TQ, System.Single STP_VAZAO_AD1, bool ignore_STP_VAZAO_AD1, System.Single STP_VAZAO_AD2, bool ignore_STP_VAZAO_AD2, System.Single STP_VAZAO_AD3, bool ignore_STP_VAZAO_AD3, System.Single STP_VEL_INICIAL, bool ignore_STP_VEL_INICIAL, System.Single STP_NIVEL_SUSPENDE, bool ignore_STP_NIVEL_SUSPENDE, System.Single STP_NIVEL_RETOMA, bool ignore_STP_NIVEL_RETOMA, System.Int16 STP_TEMPO_VALVULAS, bool ignore_STP_TEMPO_VALVULAS, System.Int16 STP_DIF_HORAS_BO, bool ignore_STP_DIF_HORAS_BO, System.Int16 STP_TEMPO_SEM_PARTIR, bool ignore_STP_TEMPO_SEM_PARTIR, System.Single STP_VEL_SOPRADORES, bool ignore_STP_VEL_SOPRADORES)
    {
      object[] _values_ = new object[13];
      if (!ignore_HAB_SOPRADORES) _values_[0] = HAB_SOPRADORES;
      if (!ignore_STP_NIVEL_MIN_TQ) _values_[1] = STP_NIVEL_MIN_TQ;
      if (!ignore_STP_NIVEL_RETOMA_TQ) _values_[2] = STP_NIVEL_RETOMA_TQ;
      if (!ignore_STP_VAZAO_AD1) _values_[3] = STP_VAZAO_AD1;
      if (!ignore_STP_VAZAO_AD2) _values_[4] = STP_VAZAO_AD2;
      if (!ignore_STP_VAZAO_AD3) _values_[5] = STP_VAZAO_AD3;
      if (!ignore_STP_VEL_INICIAL) _values_[6] = STP_VEL_INICIAL;
      if (!ignore_STP_NIVEL_SUSPENDE) _values_[7] = STP_NIVEL_SUSPENDE;
      if (!ignore_STP_NIVEL_RETOMA) _values_[8] = STP_NIVEL_RETOMA;
      if (!ignore_STP_TEMPO_VALVULAS) _values_[9] = STP_TEMPO_VALVULAS;
      if (!ignore_STP_DIF_HORAS_BO) _values_[10] = STP_DIF_HORAS_BO;
      if (!ignore_STP_TEMPO_SEM_PARTIR) _values_[11] = STP_TEMPO_SEM_PARTIR;
      if (!ignore_STP_VEL_SOPRADORES) _values_[12] = STP_VEL_SOPRADORES;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_E_COMANDO(System.Boolean CMD_AD1, System.Boolean CMD_AD2, System.Boolean CMD_AD3)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {CMD_AD1, CMD_AD2, CMD_AD3});
    }
    public bool FireEvent_E_COMANDO(Hidryco.HidrycoLib.Symbols.DesidratacaoLodo.E_COMANDOEventArgs ea)
    {
      object[] _values_ = new object[3];
      if (ea.CMD_AD1.HasValue) _values_[0] = ea.CMD_AD1.Value;
      if (ea.CMD_AD2.HasValue) _values_[1] = ea.CMD_AD2.Value;
      if (ea.CMD_AD3.HasValue) _values_[2] = ea.CMD_AD3.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_E_COMANDO(System.Boolean CMD_AD1, bool ignore_CMD_AD1, System.Boolean CMD_AD2, bool ignore_CMD_AD2, System.Boolean CMD_AD3, bool ignore_CMD_AD3)
    {
      object[] _values_ = new object[3];
      if (!ignore_CMD_AD1) _values_[0] = CMD_AD1;
      if (!ignore_CMD_AD2) _values_[1] = CMD_AD2;
      if (!ignore_CMD_AD3) _values_[2] = CMD_AD3;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_E_SV(System.Boolean CMD_SV01, System.Boolean CMD_SV02, System.Boolean CMD_SV03, System.Boolean CMD_SV04, System.Boolean CMD_SV06, System.Boolean CMD_SV08)
    {
      return ((IHMIAccessorOutput)this).FireEvent(2, new object[] {CMD_SV01, CMD_SV02, CMD_SV03, CMD_SV04, CMD_SV06, CMD_SV08});
    }
    public bool FireEvent_E_SV(Hidryco.HidrycoLib.Symbols.DesidratacaoLodo.E_SVEventArgs ea)
    {
      object[] _values_ = new object[6];
      if (ea.CMD_SV01.HasValue) _values_[0] = ea.CMD_SV01.Value;
      if (ea.CMD_SV02.HasValue) _values_[1] = ea.CMD_SV02.Value;
      if (ea.CMD_SV03.HasValue) _values_[2] = ea.CMD_SV03.Value;
      if (ea.CMD_SV04.HasValue) _values_[3] = ea.CMD_SV04.Value;
      if (ea.CMD_SV06.HasValue) _values_[4] = ea.CMD_SV06.Value;
      if (ea.CMD_SV08.HasValue) _values_[5] = ea.CMD_SV08.Value;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_E_SV(System.Boolean CMD_SV01, bool ignore_CMD_SV01, System.Boolean CMD_SV02, bool ignore_CMD_SV02, System.Boolean CMD_SV03, bool ignore_CMD_SV03, System.Boolean CMD_SV04, bool ignore_CMD_SV04, System.Boolean CMD_SV06, bool ignore_CMD_SV06, System.Boolean CMD_SV08, bool ignore_CMD_SV08)
    {
      object[] _values_ = new object[6];
      if (!ignore_CMD_SV01) _values_[0] = CMD_SV01;
      if (!ignore_CMD_SV02) _values_[1] = CMD_SV02;
      if (!ignore_CMD_SV03) _values_[2] = CMD_SV03;
      if (!ignore_CMD_SV04) _values_[3] = CMD_SV04;
      if (!ignore_CMD_SV06) _values_[4] = CMD_SV06;
      if (!ignore_CMD_SV08) _values_[5] = CMD_SV08;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_E_RESET(System.Boolean CMD_RESET)
    {
      return ((IHMIAccessorOutput)this).FireEvent(3, new object[] {CMD_RESET});
    }
    public bool FireEvent_E_RESET(Hidryco.HidrycoLib.Symbols.DesidratacaoLodo.E_RESETEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.CMD_RESET.HasValue) _values_[0] = ea.CMD_RESET.Value;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_E_RESET(System.Boolean CMD_RESET, bool ignore_CMD_RESET)
    {
      object[] _values_ = new object[1];
      if (!ignore_CMD_RESET) _values_[0] = CMD_RESET;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }

  }
}

namespace Hidryco.HidrycoLib.Faceplates.DesidratacaoLodo
{
  partial class fpDefault
  {

    private event EventHandler<Hidryco.HidrycoLib.Symbols.DesidratacaoLodo.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    private event EventHandler<Hidryco.HidrycoLib.Symbols.DesidratacaoLodo.REQEventArgs> REQ_Fired;

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
              LOAD_PERS_DATA_Fired(this, new Hidryco.HidrycoLib.Symbols.DesidratacaoLodo.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
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
              REQ_Fired(this, new Hidryco.HidrycoLib.Symbols.DesidratacaoLodo.REQEventArgs(channelId, cookie, eventIndex));
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
    public bool FireEvent_E_PARAMETROS(System.Boolean HAB_SOPRADORES, System.Single STP_NIVEL_MIN_TQ, System.Single STP_NIVEL_RETOMA_TQ, System.Single STP_VAZAO_AD1, System.Single STP_VAZAO_AD2, System.Single STP_VAZAO_AD3, System.Single STP_VEL_INICIAL, System.Single STP_NIVEL_SUSPENDE, System.Single STP_NIVEL_RETOMA, System.Int16 STP_TEMPO_VALVULAS, System.Int16 STP_DIF_HORAS_BO, System.Int16 STP_TEMPO_SEM_PARTIR, System.Single STP_VEL_SOPRADORES)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {HAB_SOPRADORES, STP_NIVEL_MIN_TQ, STP_NIVEL_RETOMA_TQ, STP_VAZAO_AD1, STP_VAZAO_AD2, STP_VAZAO_AD3, STP_VEL_INICIAL, STP_NIVEL_SUSPENDE, STP_NIVEL_RETOMA, STP_TEMPO_VALVULAS, STP_DIF_HORAS_BO, STP_TEMPO_SEM_PARTIR, STP_VEL_SOPRADORES});
    }
    public bool FireEvent_E_PARAMETROS(Hidryco.HidrycoLib.Symbols.DesidratacaoLodo.E_PARAMETROSEventArgs ea)
    {
      object[] _values_ = new object[13];
      if (ea.HAB_SOPRADORES.HasValue) _values_[0] = ea.HAB_SOPRADORES.Value;
      if (ea.STP_NIVEL_MIN_TQ.HasValue) _values_[1] = ea.STP_NIVEL_MIN_TQ.Value;
      if (ea.STP_NIVEL_RETOMA_TQ.HasValue) _values_[2] = ea.STP_NIVEL_RETOMA_TQ.Value;
      if (ea.STP_VAZAO_AD1.HasValue) _values_[3] = ea.STP_VAZAO_AD1.Value;
      if (ea.STP_VAZAO_AD2.HasValue) _values_[4] = ea.STP_VAZAO_AD2.Value;
      if (ea.STP_VAZAO_AD3.HasValue) _values_[5] = ea.STP_VAZAO_AD3.Value;
      if (ea.STP_VEL_INICIAL.HasValue) _values_[6] = ea.STP_VEL_INICIAL.Value;
      if (ea.STP_NIVEL_SUSPENDE.HasValue) _values_[7] = ea.STP_NIVEL_SUSPENDE.Value;
      if (ea.STP_NIVEL_RETOMA.HasValue) _values_[8] = ea.STP_NIVEL_RETOMA.Value;
      if (ea.STP_TEMPO_VALVULAS.HasValue) _values_[9] = ea.STP_TEMPO_VALVULAS.Value;
      if (ea.STP_DIF_HORAS_BO.HasValue) _values_[10] = ea.STP_DIF_HORAS_BO.Value;
      if (ea.STP_TEMPO_SEM_PARTIR.HasValue) _values_[11] = ea.STP_TEMPO_SEM_PARTIR.Value;
      if (ea.STP_VEL_SOPRADORES.HasValue) _values_[12] = ea.STP_VEL_SOPRADORES.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_E_PARAMETROS(System.Boolean HAB_SOPRADORES, bool ignore_HAB_SOPRADORES, System.Single STP_NIVEL_MIN_TQ, bool ignore_STP_NIVEL_MIN_TQ, System.Single STP_NIVEL_RETOMA_TQ, bool ignore_STP_NIVEL_RETOMA_TQ, System.Single STP_VAZAO_AD1, bool ignore_STP_VAZAO_AD1, System.Single STP_VAZAO_AD2, bool ignore_STP_VAZAO_AD2, System.Single STP_VAZAO_AD3, bool ignore_STP_VAZAO_AD3, System.Single STP_VEL_INICIAL, bool ignore_STP_VEL_INICIAL, System.Single STP_NIVEL_SUSPENDE, bool ignore_STP_NIVEL_SUSPENDE, System.Single STP_NIVEL_RETOMA, bool ignore_STP_NIVEL_RETOMA, System.Int16 STP_TEMPO_VALVULAS, bool ignore_STP_TEMPO_VALVULAS, System.Int16 STP_DIF_HORAS_BO, bool ignore_STP_DIF_HORAS_BO, System.Int16 STP_TEMPO_SEM_PARTIR, bool ignore_STP_TEMPO_SEM_PARTIR, System.Single STP_VEL_SOPRADORES, bool ignore_STP_VEL_SOPRADORES)
    {
      object[] _values_ = new object[13];
      if (!ignore_HAB_SOPRADORES) _values_[0] = HAB_SOPRADORES;
      if (!ignore_STP_NIVEL_MIN_TQ) _values_[1] = STP_NIVEL_MIN_TQ;
      if (!ignore_STP_NIVEL_RETOMA_TQ) _values_[2] = STP_NIVEL_RETOMA_TQ;
      if (!ignore_STP_VAZAO_AD1) _values_[3] = STP_VAZAO_AD1;
      if (!ignore_STP_VAZAO_AD2) _values_[4] = STP_VAZAO_AD2;
      if (!ignore_STP_VAZAO_AD3) _values_[5] = STP_VAZAO_AD3;
      if (!ignore_STP_VEL_INICIAL) _values_[6] = STP_VEL_INICIAL;
      if (!ignore_STP_NIVEL_SUSPENDE) _values_[7] = STP_NIVEL_SUSPENDE;
      if (!ignore_STP_NIVEL_RETOMA) _values_[8] = STP_NIVEL_RETOMA;
      if (!ignore_STP_TEMPO_VALVULAS) _values_[9] = STP_TEMPO_VALVULAS;
      if (!ignore_STP_DIF_HORAS_BO) _values_[10] = STP_DIF_HORAS_BO;
      if (!ignore_STP_TEMPO_SEM_PARTIR) _values_[11] = STP_TEMPO_SEM_PARTIR;
      if (!ignore_STP_VEL_SOPRADORES) _values_[12] = STP_VEL_SOPRADORES;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_E_COMANDO(System.Boolean CMD_AD1, System.Boolean CMD_AD2, System.Boolean CMD_AD3)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {CMD_AD1, CMD_AD2, CMD_AD3});
    }
    public bool FireEvent_E_COMANDO(Hidryco.HidrycoLib.Symbols.DesidratacaoLodo.E_COMANDOEventArgs ea)
    {
      object[] _values_ = new object[3];
      if (ea.CMD_AD1.HasValue) _values_[0] = ea.CMD_AD1.Value;
      if (ea.CMD_AD2.HasValue) _values_[1] = ea.CMD_AD2.Value;
      if (ea.CMD_AD3.HasValue) _values_[2] = ea.CMD_AD3.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_E_COMANDO(System.Boolean CMD_AD1, bool ignore_CMD_AD1, System.Boolean CMD_AD2, bool ignore_CMD_AD2, System.Boolean CMD_AD3, bool ignore_CMD_AD3)
    {
      object[] _values_ = new object[3];
      if (!ignore_CMD_AD1) _values_[0] = CMD_AD1;
      if (!ignore_CMD_AD2) _values_[1] = CMD_AD2;
      if (!ignore_CMD_AD3) _values_[2] = CMD_AD3;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_E_SV(System.Boolean CMD_SV01, System.Boolean CMD_SV02, System.Boolean CMD_SV03, System.Boolean CMD_SV04, System.Boolean CMD_SV06, System.Boolean CMD_SV08)
    {
      return ((IHMIAccessorOutput)this).FireEvent(2, new object[] {CMD_SV01, CMD_SV02, CMD_SV03, CMD_SV04, CMD_SV06, CMD_SV08});
    }
    public bool FireEvent_E_SV(Hidryco.HidrycoLib.Symbols.DesidratacaoLodo.E_SVEventArgs ea)
    {
      object[] _values_ = new object[6];
      if (ea.CMD_SV01.HasValue) _values_[0] = ea.CMD_SV01.Value;
      if (ea.CMD_SV02.HasValue) _values_[1] = ea.CMD_SV02.Value;
      if (ea.CMD_SV03.HasValue) _values_[2] = ea.CMD_SV03.Value;
      if (ea.CMD_SV04.HasValue) _values_[3] = ea.CMD_SV04.Value;
      if (ea.CMD_SV06.HasValue) _values_[4] = ea.CMD_SV06.Value;
      if (ea.CMD_SV08.HasValue) _values_[5] = ea.CMD_SV08.Value;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_E_SV(System.Boolean CMD_SV01, bool ignore_CMD_SV01, System.Boolean CMD_SV02, bool ignore_CMD_SV02, System.Boolean CMD_SV03, bool ignore_CMD_SV03, System.Boolean CMD_SV04, bool ignore_CMD_SV04, System.Boolean CMD_SV06, bool ignore_CMD_SV06, System.Boolean CMD_SV08, bool ignore_CMD_SV08)
    {
      object[] _values_ = new object[6];
      if (!ignore_CMD_SV01) _values_[0] = CMD_SV01;
      if (!ignore_CMD_SV02) _values_[1] = CMD_SV02;
      if (!ignore_CMD_SV03) _values_[2] = CMD_SV03;
      if (!ignore_CMD_SV04) _values_[3] = CMD_SV04;
      if (!ignore_CMD_SV06) _values_[4] = CMD_SV06;
      if (!ignore_CMD_SV08) _values_[5] = CMD_SV08;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_E_RESET(System.Boolean CMD_RESET)
    {
      return ((IHMIAccessorOutput)this).FireEvent(3, new object[] {CMD_RESET});
    }
    public bool FireEvent_E_RESET(Hidryco.HidrycoLib.Symbols.DesidratacaoLodo.E_RESETEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.CMD_RESET.HasValue) _values_[0] = ea.CMD_RESET.Value;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_E_RESET(System.Boolean CMD_RESET, bool ignore_CMD_RESET)
    {
      object[] _values_ = new object[1];
      if (!ignore_CMD_RESET) _values_[0] = CMD_RESET;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }

  }
}

namespace Hidryco.HidrycoLib.Faceplates.DesidratacaoLodo
{
  partial class fpParametros
  {

    private event EventHandler<Hidryco.HidrycoLib.Symbols.DesidratacaoLodo.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    private event EventHandler<Hidryco.HidrycoLib.Symbols.DesidratacaoLodo.REQEventArgs> REQ_Fired;

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
              LOAD_PERS_DATA_Fired(this, new Hidryco.HidrycoLib.Symbols.DesidratacaoLodo.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
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
              REQ_Fired(this, new Hidryco.HidrycoLib.Symbols.DesidratacaoLodo.REQEventArgs(channelId, cookie, eventIndex));
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
    public bool FireEvent_E_PARAMETROS(System.Boolean HAB_SOPRADORES, System.Single STP_NIVEL_MIN_TQ, System.Single STP_NIVEL_RETOMA_TQ, System.Single STP_VAZAO_AD1, System.Single STP_VAZAO_AD2, System.Single STP_VAZAO_AD3, System.Single STP_VEL_INICIAL, System.Single STP_NIVEL_SUSPENDE, System.Single STP_NIVEL_RETOMA, System.Int16 STP_TEMPO_VALVULAS, System.Int16 STP_DIF_HORAS_BO, System.Int16 STP_TEMPO_SEM_PARTIR, System.Single STP_VEL_SOPRADORES)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {HAB_SOPRADORES, STP_NIVEL_MIN_TQ, STP_NIVEL_RETOMA_TQ, STP_VAZAO_AD1, STP_VAZAO_AD2, STP_VAZAO_AD3, STP_VEL_INICIAL, STP_NIVEL_SUSPENDE, STP_NIVEL_RETOMA, STP_TEMPO_VALVULAS, STP_DIF_HORAS_BO, STP_TEMPO_SEM_PARTIR, STP_VEL_SOPRADORES});
    }
    public bool FireEvent_E_PARAMETROS(Hidryco.HidrycoLib.Symbols.DesidratacaoLodo.E_PARAMETROSEventArgs ea)
    {
      object[] _values_ = new object[13];
      if (ea.HAB_SOPRADORES.HasValue) _values_[0] = ea.HAB_SOPRADORES.Value;
      if (ea.STP_NIVEL_MIN_TQ.HasValue) _values_[1] = ea.STP_NIVEL_MIN_TQ.Value;
      if (ea.STP_NIVEL_RETOMA_TQ.HasValue) _values_[2] = ea.STP_NIVEL_RETOMA_TQ.Value;
      if (ea.STP_VAZAO_AD1.HasValue) _values_[3] = ea.STP_VAZAO_AD1.Value;
      if (ea.STP_VAZAO_AD2.HasValue) _values_[4] = ea.STP_VAZAO_AD2.Value;
      if (ea.STP_VAZAO_AD3.HasValue) _values_[5] = ea.STP_VAZAO_AD3.Value;
      if (ea.STP_VEL_INICIAL.HasValue) _values_[6] = ea.STP_VEL_INICIAL.Value;
      if (ea.STP_NIVEL_SUSPENDE.HasValue) _values_[7] = ea.STP_NIVEL_SUSPENDE.Value;
      if (ea.STP_NIVEL_RETOMA.HasValue) _values_[8] = ea.STP_NIVEL_RETOMA.Value;
      if (ea.STP_TEMPO_VALVULAS.HasValue) _values_[9] = ea.STP_TEMPO_VALVULAS.Value;
      if (ea.STP_DIF_HORAS_BO.HasValue) _values_[10] = ea.STP_DIF_HORAS_BO.Value;
      if (ea.STP_TEMPO_SEM_PARTIR.HasValue) _values_[11] = ea.STP_TEMPO_SEM_PARTIR.Value;
      if (ea.STP_VEL_SOPRADORES.HasValue) _values_[12] = ea.STP_VEL_SOPRADORES.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_E_PARAMETROS(System.Boolean HAB_SOPRADORES, bool ignore_HAB_SOPRADORES, System.Single STP_NIVEL_MIN_TQ, bool ignore_STP_NIVEL_MIN_TQ, System.Single STP_NIVEL_RETOMA_TQ, bool ignore_STP_NIVEL_RETOMA_TQ, System.Single STP_VAZAO_AD1, bool ignore_STP_VAZAO_AD1, System.Single STP_VAZAO_AD2, bool ignore_STP_VAZAO_AD2, System.Single STP_VAZAO_AD3, bool ignore_STP_VAZAO_AD3, System.Single STP_VEL_INICIAL, bool ignore_STP_VEL_INICIAL, System.Single STP_NIVEL_SUSPENDE, bool ignore_STP_NIVEL_SUSPENDE, System.Single STP_NIVEL_RETOMA, bool ignore_STP_NIVEL_RETOMA, System.Int16 STP_TEMPO_VALVULAS, bool ignore_STP_TEMPO_VALVULAS, System.Int16 STP_DIF_HORAS_BO, bool ignore_STP_DIF_HORAS_BO, System.Int16 STP_TEMPO_SEM_PARTIR, bool ignore_STP_TEMPO_SEM_PARTIR, System.Single STP_VEL_SOPRADORES, bool ignore_STP_VEL_SOPRADORES)
    {
      object[] _values_ = new object[13];
      if (!ignore_HAB_SOPRADORES) _values_[0] = HAB_SOPRADORES;
      if (!ignore_STP_NIVEL_MIN_TQ) _values_[1] = STP_NIVEL_MIN_TQ;
      if (!ignore_STP_NIVEL_RETOMA_TQ) _values_[2] = STP_NIVEL_RETOMA_TQ;
      if (!ignore_STP_VAZAO_AD1) _values_[3] = STP_VAZAO_AD1;
      if (!ignore_STP_VAZAO_AD2) _values_[4] = STP_VAZAO_AD2;
      if (!ignore_STP_VAZAO_AD3) _values_[5] = STP_VAZAO_AD3;
      if (!ignore_STP_VEL_INICIAL) _values_[6] = STP_VEL_INICIAL;
      if (!ignore_STP_NIVEL_SUSPENDE) _values_[7] = STP_NIVEL_SUSPENDE;
      if (!ignore_STP_NIVEL_RETOMA) _values_[8] = STP_NIVEL_RETOMA;
      if (!ignore_STP_TEMPO_VALVULAS) _values_[9] = STP_TEMPO_VALVULAS;
      if (!ignore_STP_DIF_HORAS_BO) _values_[10] = STP_DIF_HORAS_BO;
      if (!ignore_STP_TEMPO_SEM_PARTIR) _values_[11] = STP_TEMPO_SEM_PARTIR;
      if (!ignore_STP_VEL_SOPRADORES) _values_[12] = STP_VEL_SOPRADORES;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_E_COMANDO(System.Boolean CMD_AD1, System.Boolean CMD_AD2, System.Boolean CMD_AD3)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {CMD_AD1, CMD_AD2, CMD_AD3});
    }
    public bool FireEvent_E_COMANDO(Hidryco.HidrycoLib.Symbols.DesidratacaoLodo.E_COMANDOEventArgs ea)
    {
      object[] _values_ = new object[3];
      if (ea.CMD_AD1.HasValue) _values_[0] = ea.CMD_AD1.Value;
      if (ea.CMD_AD2.HasValue) _values_[1] = ea.CMD_AD2.Value;
      if (ea.CMD_AD3.HasValue) _values_[2] = ea.CMD_AD3.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_E_COMANDO(System.Boolean CMD_AD1, bool ignore_CMD_AD1, System.Boolean CMD_AD2, bool ignore_CMD_AD2, System.Boolean CMD_AD3, bool ignore_CMD_AD3)
    {
      object[] _values_ = new object[3];
      if (!ignore_CMD_AD1) _values_[0] = CMD_AD1;
      if (!ignore_CMD_AD2) _values_[1] = CMD_AD2;
      if (!ignore_CMD_AD3) _values_[2] = CMD_AD3;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_E_SV(System.Boolean CMD_SV01, System.Boolean CMD_SV02, System.Boolean CMD_SV03, System.Boolean CMD_SV04, System.Boolean CMD_SV06, System.Boolean CMD_SV08)
    {
      return ((IHMIAccessorOutput)this).FireEvent(2, new object[] {CMD_SV01, CMD_SV02, CMD_SV03, CMD_SV04, CMD_SV06, CMD_SV08});
    }
    public bool FireEvent_E_SV(Hidryco.HidrycoLib.Symbols.DesidratacaoLodo.E_SVEventArgs ea)
    {
      object[] _values_ = new object[6];
      if (ea.CMD_SV01.HasValue) _values_[0] = ea.CMD_SV01.Value;
      if (ea.CMD_SV02.HasValue) _values_[1] = ea.CMD_SV02.Value;
      if (ea.CMD_SV03.HasValue) _values_[2] = ea.CMD_SV03.Value;
      if (ea.CMD_SV04.HasValue) _values_[3] = ea.CMD_SV04.Value;
      if (ea.CMD_SV06.HasValue) _values_[4] = ea.CMD_SV06.Value;
      if (ea.CMD_SV08.HasValue) _values_[5] = ea.CMD_SV08.Value;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_E_SV(System.Boolean CMD_SV01, bool ignore_CMD_SV01, System.Boolean CMD_SV02, bool ignore_CMD_SV02, System.Boolean CMD_SV03, bool ignore_CMD_SV03, System.Boolean CMD_SV04, bool ignore_CMD_SV04, System.Boolean CMD_SV06, bool ignore_CMD_SV06, System.Boolean CMD_SV08, bool ignore_CMD_SV08)
    {
      object[] _values_ = new object[6];
      if (!ignore_CMD_SV01) _values_[0] = CMD_SV01;
      if (!ignore_CMD_SV02) _values_[1] = CMD_SV02;
      if (!ignore_CMD_SV03) _values_[2] = CMD_SV03;
      if (!ignore_CMD_SV04) _values_[3] = CMD_SV04;
      if (!ignore_CMD_SV06) _values_[4] = CMD_SV06;
      if (!ignore_CMD_SV08) _values_[5] = CMD_SV08;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_E_RESET(System.Boolean CMD_RESET)
    {
      return ((IHMIAccessorOutput)this).FireEvent(3, new object[] {CMD_RESET});
    }
    public bool FireEvent_E_RESET(Hidryco.HidrycoLib.Symbols.DesidratacaoLodo.E_RESETEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.CMD_RESET.HasValue) _values_[0] = ea.CMD_RESET.Value;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_E_RESET(System.Boolean CMD_RESET, bool ignore_CMD_RESET)
    {
      object[] _values_ = new object[1];
      if (!ignore_CMD_RESET) _values_[0] = CMD_RESET;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }

  }
}

#endregion #DesidratacaoLodo_HMI;

#endregion Definitions;
