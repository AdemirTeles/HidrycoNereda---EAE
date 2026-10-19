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
#region #Desinfeccao_UV_HMI;

namespace Hidryco.HidrycoLib.Symbols.Desinfeccao_UV
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
    public bool Get_STS_VAZAO(ref System.Single value)
    {
      if (accessorService == null)
        return false;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,0, ref var);
      if (ret) value = (System.Single) var;
      return ret;
    }

    public System.Single? STS_VAZAO
    { get {
      if (accessorService == null)
        return null;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,0, ref var);
      if (!ret) return null;
      return (System.Single) var;
    }  }

    public bool Get_STS_VAZAO_MAX(ref System.Single value)
    {
      if (accessorService == null)
        return false;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,1, ref var);
      if (ret) value = (System.Single) var;
      return ret;
    }

    public System.Single? STS_VAZAO_MAX
    { get {
      if (accessorService == null)
        return null;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,1, ref var);
      if (!ret) return null;
      return (System.Single) var;
    }  }

    public bool Get_STS_TOTAL(ref System.Int32 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,2, ref var);
      if (ret) value = (System.Int32) var;
      return ret;
    }

    public System.Int32? STS_TOTAL
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,2, ref var);
      if (!ret) return null;
      return (System.Int32) var;
    }  }

    public bool Get_STS_CONTROLE_ATIVO(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,3, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_CONTROLE_ATIVO
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,3, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_HABILITADO(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,4, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_HABILITADO
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,4, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_MOTIVO(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,5, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? STS_MOTIVO
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,5, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }

    public bool Get_STS_SAIDA_PID(ref System.Single value)
    {
      if (accessorService == null)
        return false;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,6, ref var);
      if (ret) value = (System.Single) var;
      return ret;
    }

    public System.Single? STS_SAIDA_PID
    { get {
      if (accessorService == null)
        return null;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,6, ref var);
      if (!ret) return null;
      return (System.Single) var;
    }  }

    public bool Get_STS_VC_POSICAO(ref System.Single value)
    {
      if (accessorService == null)
        return false;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,7, ref var);
      if (ret) value = (System.Single) var;
      return ret;
    }

    public System.Single? STS_VC_POSICAO
    { get {
      if (accessorService == null)
        return null;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,7, ref var);
      if (!ret) return null;
      return (System.Single) var;
    }  }

    public bool Get_STS_FT_FALHA(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,8, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_FT_FALHA
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,8, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_UV_COM_OK(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,9, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_UV_COM_OK
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,9, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_UV_CANAL1(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,10, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_UV_CANAL1
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,10, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_UV_CANAL2(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,11, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_UV_CANAL2
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,11, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_DJ_PCE_DESLIGADO(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,12, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_DJ_PCE_DESLIGADO
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,12, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_DJ_PCM_DESLIGADO(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,13, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_DJ_PCM_DESLIGADO
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,13, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_DJ_UV01(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,14, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_DJ_UV01
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,14, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_DJ_UV02(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,15, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_DJ_UV02
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,15, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_DJ_VC01(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,16, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_DJ_VC01
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,16, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_DJ_MO01(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,17, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_DJ_MO01
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,17, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_REMOTA_OK(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,18, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_REMOTA_OK
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,18, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_AVISO_DISJUNTOR(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,19, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_AVISO_DISJUNTOR
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,19, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_ALARME_VAZAO_ALTA(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,20, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_ALARME_VAZAO_ALTA
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,20, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_AVISO_VARIACAO(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,21, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_AVISO_VARIACAO
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,21, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_FALHA_REMOTA(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,22, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_FALHA_REMOTA
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,22, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_ALARME(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,23, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_ALARME
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,23, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_ALM_VAZAO_ALTA_EST(ref System.Byte value)
    {
      if (accessorService == null)
        return false;
      byte var = 0;
      bool ret = accessorService.GetByteValue(channelId, cookie, eventIndex, true,24, ref var);
      if (ret) value = (System.Byte) var;
      return ret;
    }

    public System.Byte? STS_ALM_VAZAO_ALTA_EST
    { get {
      if (accessorService == null)
        return null;
      byte var = 0;
      bool ret = accessorService.GetByteValue(channelId, cookie, eventIndex, true,24, ref var);
      if (!ret) return null;
      return (System.Byte) var;
    }  }

    public bool Get_STS_ALM_VARIACAO_EST(ref System.Byte value)
    {
      if (accessorService == null)
        return false;
      byte var = 0;
      bool ret = accessorService.GetByteValue(channelId, cookie, eventIndex, true,25, ref var);
      if (ret) value = (System.Byte) var;
      return ret;
    }

    public System.Byte? STS_ALM_VARIACAO_EST
    { get {
      if (accessorService == null)
        return null;
      byte var = 0;
      bool ret = accessorService.GetByteValue(channelId, cookie, eventIndex, true,25, ref var);
      if (!ret) return null;
      return (System.Byte) var;
    }  }

    public bool Get_STS_ALM_DISJUNTOR_EST(ref System.Byte value)
    {
      if (accessorService == null)
        return false;
      byte var = 0;
      bool ret = accessorService.GetByteValue(channelId, cookie, eventIndex, true,26, ref var);
      if (ret) value = (System.Byte) var;
      return ret;
    }

    public System.Byte? STS_ALM_DISJUNTOR_EST
    { get {
      if (accessorService == null)
        return null;
      byte var = 0;
      bool ret = accessorService.GetByteValue(channelId, cookie, eventIndex, true,26, ref var);
      if (!ret) return null;
      return (System.Byte) var;
    }  }

    public bool Get_STS_ALM_REMOTA_EST(ref System.Byte value)
    {
      if (accessorService == null)
        return false;
      byte var = 0;
      bool ret = accessorService.GetByteValue(channelId, cookie, eventIndex, true,27, ref var);
      if (ret) value = (System.Byte) var;
      return ret;
    }

    public System.Byte? STS_ALM_REMOTA_EST
    { get {
      if (accessorService == null)
        return null;
      byte var = 0;
      bool ret = accessorService.GetByteValue(channelId, cookie, eventIndex, true,27, ref var);
      if (!ret) return null;
      return (System.Byte) var;
    }  }


  }

}

namespace Hidryco.HidrycoLib.Symbols.Desinfeccao_UV
{

  public class E_PARAMETROSEventArgs : System.EventArgs
  {
    public E_PARAMETROSEventArgs()
    {
    }
    private System.Boolean? PID_CMD_HABILITA_field = null;
    public System.Boolean? PID_CMD_HABILITA
    {
       get { return PID_CMD_HABILITA_field; }
       set { PID_CMD_HABILITA_field = value; }
    }
    private System.Single? STP_VAZAO_MAX_field = null;
    public System.Single? STP_VAZAO_MAX
    {
       get { return STP_VAZAO_MAX_field; }
       set { STP_VAZAO_MAX_field = value; }
    }
    private System.Single? STP_PARAMETRO_KP_field = null;
    public System.Single? STP_PARAMETRO_KP
    {
       get { return STP_PARAMETRO_KP_field; }
       set { STP_PARAMETRO_KP_field = value; }
    }
    private System.Single? STP_PARAMETRO_KI_field = null;
    public System.Single? STP_PARAMETRO_KI
    {
       get { return STP_PARAMETRO_KI_field; }
       set { STP_PARAMETRO_KI_field = value; }
    }
    private System.Single? STP_PARAMETRO_KD_field = null;
    public System.Single? STP_PARAMETRO_KD
    {
       get { return STP_PARAMETRO_KD_field; }
       set { STP_PARAMETRO_KD_field = value; }
    }
    private System.Single? STP_MINIMO_field = null;
    public System.Single? STP_MINIMO
    {
       get { return STP_MINIMO_field; }
       set { STP_MINIMO_field = value; }
    }
    private System.Single? STP_MAXIMO_field = null;
    public System.Single? STP_MAXIMO
    {
       get { return STP_MAXIMO_field; }
       set { STP_MAXIMO_field = value; }
    }
    private System.Single? STP_TOL_VAZAO_field = null;
    public System.Single? STP_TOL_VAZAO
    {
       get { return STP_TOL_VAZAO_field; }
       set { STP_TOL_VAZAO_field = value; }
    }
    private System.Int16? STP_TEMPO_VAZAO_field = null;
    public System.Int16? STP_TEMPO_VAZAO
    {
       get { return STP_TEMPO_VAZAO_field; }
       set { STP_TEMPO_VAZAO_field = value; }
    }
    private System.Single? STP_VARIACAO_MAX_field = null;
    public System.Single? STP_VARIACAO_MAX
    {
       get { return STP_VARIACAO_MAX_field; }
       set { STP_VARIACAO_MAX_field = value; }
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

  public class E_ZERA_TOTALEventArgs : System.EventArgs
  {
    public E_ZERA_TOTALEventArgs()
    {
    }
    private System.Boolean? CMD_ZERA_TOTAL_field = null;
    public System.Boolean? CMD_ZERA_TOTAL
    {
       get { return CMD_ZERA_TOTAL_field; }
       set { CMD_ZERA_TOTAL_field = value; }
    }

  }

}

namespace Hidryco.HidrycoLib.Symbols.Desinfeccao_UV
{
  partial class sDefault
  {

    private event EventHandler<Hidryco.HidrycoLib.Symbols.Desinfeccao_UV.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    private event EventHandler<Hidryco.HidrycoLib.Symbols.Desinfeccao_UV.REQEventArgs> REQ_Fired;

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
              LOAD_PERS_DATA_Fired(this, new Hidryco.HidrycoLib.Symbols.Desinfeccao_UV.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
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
              REQ_Fired(this, new Hidryco.HidrycoLib.Symbols.Desinfeccao_UV.REQEventArgs(channelId, cookie, eventIndex));
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
    public bool FireEvent_E_PARAMETROS(System.Boolean PID_CMD_HABILITA, System.Single STP_VAZAO_MAX, System.Single STP_PARAMETRO_KP, System.Single STP_PARAMETRO_KI, System.Single STP_PARAMETRO_KD, System.Single STP_MINIMO, System.Single STP_MAXIMO, System.Single STP_TOL_VAZAO, System.Int16 STP_TEMPO_VAZAO, System.Single STP_VARIACAO_MAX)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {PID_CMD_HABILITA, STP_VAZAO_MAX, STP_PARAMETRO_KP, STP_PARAMETRO_KI, STP_PARAMETRO_KD, STP_MINIMO, STP_MAXIMO, STP_TOL_VAZAO, STP_TEMPO_VAZAO, STP_VARIACAO_MAX});
    }
    public bool FireEvent_E_PARAMETROS(Hidryco.HidrycoLib.Symbols.Desinfeccao_UV.E_PARAMETROSEventArgs ea)
    {
      object[] _values_ = new object[10];
      if (ea.PID_CMD_HABILITA.HasValue) _values_[0] = ea.PID_CMD_HABILITA.Value;
      if (ea.STP_VAZAO_MAX.HasValue) _values_[1] = ea.STP_VAZAO_MAX.Value;
      if (ea.STP_PARAMETRO_KP.HasValue) _values_[2] = ea.STP_PARAMETRO_KP.Value;
      if (ea.STP_PARAMETRO_KI.HasValue) _values_[3] = ea.STP_PARAMETRO_KI.Value;
      if (ea.STP_PARAMETRO_KD.HasValue) _values_[4] = ea.STP_PARAMETRO_KD.Value;
      if (ea.STP_MINIMO.HasValue) _values_[5] = ea.STP_MINIMO.Value;
      if (ea.STP_MAXIMO.HasValue) _values_[6] = ea.STP_MAXIMO.Value;
      if (ea.STP_TOL_VAZAO.HasValue) _values_[7] = ea.STP_TOL_VAZAO.Value;
      if (ea.STP_TEMPO_VAZAO.HasValue) _values_[8] = ea.STP_TEMPO_VAZAO.Value;
      if (ea.STP_VARIACAO_MAX.HasValue) _values_[9] = ea.STP_VARIACAO_MAX.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_E_PARAMETROS(System.Boolean PID_CMD_HABILITA, bool ignore_PID_CMD_HABILITA, System.Single STP_VAZAO_MAX, bool ignore_STP_VAZAO_MAX, System.Single STP_PARAMETRO_KP, bool ignore_STP_PARAMETRO_KP, System.Single STP_PARAMETRO_KI, bool ignore_STP_PARAMETRO_KI, System.Single STP_PARAMETRO_KD, bool ignore_STP_PARAMETRO_KD, System.Single STP_MINIMO, bool ignore_STP_MINIMO, System.Single STP_MAXIMO, bool ignore_STP_MAXIMO, System.Single STP_TOL_VAZAO, bool ignore_STP_TOL_VAZAO, System.Int16 STP_TEMPO_VAZAO, bool ignore_STP_TEMPO_VAZAO, System.Single STP_VARIACAO_MAX, bool ignore_STP_VARIACAO_MAX)
    {
      object[] _values_ = new object[10];
      if (!ignore_PID_CMD_HABILITA) _values_[0] = PID_CMD_HABILITA;
      if (!ignore_STP_VAZAO_MAX) _values_[1] = STP_VAZAO_MAX;
      if (!ignore_STP_PARAMETRO_KP) _values_[2] = STP_PARAMETRO_KP;
      if (!ignore_STP_PARAMETRO_KI) _values_[3] = STP_PARAMETRO_KI;
      if (!ignore_STP_PARAMETRO_KD) _values_[4] = STP_PARAMETRO_KD;
      if (!ignore_STP_MINIMO) _values_[5] = STP_MINIMO;
      if (!ignore_STP_MAXIMO) _values_[6] = STP_MAXIMO;
      if (!ignore_STP_TOL_VAZAO) _values_[7] = STP_TOL_VAZAO;
      if (!ignore_STP_TEMPO_VAZAO) _values_[8] = STP_TEMPO_VAZAO;
      if (!ignore_STP_VARIACAO_MAX) _values_[9] = STP_VARIACAO_MAX;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_E_RESET(System.Boolean CMD_RESET)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {CMD_RESET});
    }
    public bool FireEvent_E_RESET(Hidryco.HidrycoLib.Symbols.Desinfeccao_UV.E_RESETEventArgs ea)
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
    public bool FireEvent_E_ZERA_TOTAL(System.Boolean CMD_ZERA_TOTAL)
    {
      return ((IHMIAccessorOutput)this).FireEvent(2, new object[] {CMD_ZERA_TOTAL});
    }
    public bool FireEvent_E_ZERA_TOTAL(Hidryco.HidrycoLib.Symbols.Desinfeccao_UV.E_ZERA_TOTALEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.CMD_ZERA_TOTAL.HasValue) _values_[0] = ea.CMD_ZERA_TOTAL.Value;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_E_ZERA_TOTAL(System.Boolean CMD_ZERA_TOTAL, bool ignore_CMD_ZERA_TOTAL)
    {
      object[] _values_ = new object[1];
      if (!ignore_CMD_ZERA_TOTAL) _values_[0] = CMD_ZERA_TOTAL;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }

  }
}

namespace Hidryco.HidrycoLib.Faceplates.Desinfeccao_UV
{
  partial class fpDefault
  {

    private event EventHandler<Hidryco.HidrycoLib.Symbols.Desinfeccao_UV.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    private event EventHandler<Hidryco.HidrycoLib.Symbols.Desinfeccao_UV.REQEventArgs> REQ_Fired;

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
              LOAD_PERS_DATA_Fired(this, new Hidryco.HidrycoLib.Symbols.Desinfeccao_UV.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
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
              REQ_Fired(this, new Hidryco.HidrycoLib.Symbols.Desinfeccao_UV.REQEventArgs(channelId, cookie, eventIndex));
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
    public bool FireEvent_E_PARAMETROS(System.Boolean PID_CMD_HABILITA, System.Single STP_VAZAO_MAX, System.Single STP_PARAMETRO_KP, System.Single STP_PARAMETRO_KI, System.Single STP_PARAMETRO_KD, System.Single STP_MINIMO, System.Single STP_MAXIMO, System.Single STP_TOL_VAZAO, System.Int16 STP_TEMPO_VAZAO, System.Single STP_VARIACAO_MAX)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {PID_CMD_HABILITA, STP_VAZAO_MAX, STP_PARAMETRO_KP, STP_PARAMETRO_KI, STP_PARAMETRO_KD, STP_MINIMO, STP_MAXIMO, STP_TOL_VAZAO, STP_TEMPO_VAZAO, STP_VARIACAO_MAX});
    }
    public bool FireEvent_E_PARAMETROS(Hidryco.HidrycoLib.Symbols.Desinfeccao_UV.E_PARAMETROSEventArgs ea)
    {
      object[] _values_ = new object[10];
      if (ea.PID_CMD_HABILITA.HasValue) _values_[0] = ea.PID_CMD_HABILITA.Value;
      if (ea.STP_VAZAO_MAX.HasValue) _values_[1] = ea.STP_VAZAO_MAX.Value;
      if (ea.STP_PARAMETRO_KP.HasValue) _values_[2] = ea.STP_PARAMETRO_KP.Value;
      if (ea.STP_PARAMETRO_KI.HasValue) _values_[3] = ea.STP_PARAMETRO_KI.Value;
      if (ea.STP_PARAMETRO_KD.HasValue) _values_[4] = ea.STP_PARAMETRO_KD.Value;
      if (ea.STP_MINIMO.HasValue) _values_[5] = ea.STP_MINIMO.Value;
      if (ea.STP_MAXIMO.HasValue) _values_[6] = ea.STP_MAXIMO.Value;
      if (ea.STP_TOL_VAZAO.HasValue) _values_[7] = ea.STP_TOL_VAZAO.Value;
      if (ea.STP_TEMPO_VAZAO.HasValue) _values_[8] = ea.STP_TEMPO_VAZAO.Value;
      if (ea.STP_VARIACAO_MAX.HasValue) _values_[9] = ea.STP_VARIACAO_MAX.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_E_PARAMETROS(System.Boolean PID_CMD_HABILITA, bool ignore_PID_CMD_HABILITA, System.Single STP_VAZAO_MAX, bool ignore_STP_VAZAO_MAX, System.Single STP_PARAMETRO_KP, bool ignore_STP_PARAMETRO_KP, System.Single STP_PARAMETRO_KI, bool ignore_STP_PARAMETRO_KI, System.Single STP_PARAMETRO_KD, bool ignore_STP_PARAMETRO_KD, System.Single STP_MINIMO, bool ignore_STP_MINIMO, System.Single STP_MAXIMO, bool ignore_STP_MAXIMO, System.Single STP_TOL_VAZAO, bool ignore_STP_TOL_VAZAO, System.Int16 STP_TEMPO_VAZAO, bool ignore_STP_TEMPO_VAZAO, System.Single STP_VARIACAO_MAX, bool ignore_STP_VARIACAO_MAX)
    {
      object[] _values_ = new object[10];
      if (!ignore_PID_CMD_HABILITA) _values_[0] = PID_CMD_HABILITA;
      if (!ignore_STP_VAZAO_MAX) _values_[1] = STP_VAZAO_MAX;
      if (!ignore_STP_PARAMETRO_KP) _values_[2] = STP_PARAMETRO_KP;
      if (!ignore_STP_PARAMETRO_KI) _values_[3] = STP_PARAMETRO_KI;
      if (!ignore_STP_PARAMETRO_KD) _values_[4] = STP_PARAMETRO_KD;
      if (!ignore_STP_MINIMO) _values_[5] = STP_MINIMO;
      if (!ignore_STP_MAXIMO) _values_[6] = STP_MAXIMO;
      if (!ignore_STP_TOL_VAZAO) _values_[7] = STP_TOL_VAZAO;
      if (!ignore_STP_TEMPO_VAZAO) _values_[8] = STP_TEMPO_VAZAO;
      if (!ignore_STP_VARIACAO_MAX) _values_[9] = STP_VARIACAO_MAX;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_E_RESET(System.Boolean CMD_RESET)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {CMD_RESET});
    }
    public bool FireEvent_E_RESET(Hidryco.HidrycoLib.Symbols.Desinfeccao_UV.E_RESETEventArgs ea)
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
    public bool FireEvent_E_ZERA_TOTAL(System.Boolean CMD_ZERA_TOTAL)
    {
      return ((IHMIAccessorOutput)this).FireEvent(2, new object[] {CMD_ZERA_TOTAL});
    }
    public bool FireEvent_E_ZERA_TOTAL(Hidryco.HidrycoLib.Symbols.Desinfeccao_UV.E_ZERA_TOTALEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.CMD_ZERA_TOTAL.HasValue) _values_[0] = ea.CMD_ZERA_TOTAL.Value;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_E_ZERA_TOTAL(System.Boolean CMD_ZERA_TOTAL, bool ignore_CMD_ZERA_TOTAL)
    {
      object[] _values_ = new object[1];
      if (!ignore_CMD_ZERA_TOTAL) _values_[0] = CMD_ZERA_TOTAL;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }

  }
}

#endregion #Desinfeccao_UV_HMI;

#endregion Definitions;
