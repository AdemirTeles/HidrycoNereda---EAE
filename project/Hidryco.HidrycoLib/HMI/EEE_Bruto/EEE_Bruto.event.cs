/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 10/14/2026
 * Time: 11:00 AM
 * 
 */
using System;
using NxtControl.GuiFramework;
using NxtControl.Services;

#region Definitions;
#region #EEE_Bruto_HMI;

namespace Hidryco.HidrycoLib.Symbols.EEE_Bruto
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
    public bool Get_STS_NECESSIDADE_EQUIPAMENTO(ref System.UInt16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,0, ref var);
      if (ret) value = (System.UInt16) var;
      return ret;
    }

    public System.UInt16? STS_NECESSIDADE_EQUIPAMENTO
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,0, ref var);
      if (!ret) return null;
      return (System.UInt16) var;
    }  }

    public bool Get_STS_RESTANTE_HOR(ref System.UInt16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,1, ref var);
      if (ret) value = (System.UInt16) var;
      return ret;
    }

    public System.UInt16? STS_RESTANTE_HOR
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,1, ref var);
      if (!ret) return null;
      return (System.UInt16) var;
    }  }

    public bool Get_STS_RESTANTE_MIN(ref System.UInt16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,2, ref var);
      if (ret) value = (System.UInt16) var;
      return ret;
    }

    public System.UInt16? STS_RESTANTE_MIN
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,2, ref var);
      if (!ret) return null;
      return (System.UInt16) var;
    }  }

    public bool Get_STS_RESTANTE_SEG(ref System.UInt16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,3, ref var);
      if (ret) value = (System.UInt16) var;
      return ret;
    }

    public System.UInt16? STS_RESTANTE_SEG
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,3, ref var);
      if (!ret) return null;
      return (System.UInt16) var;
    }  }

    public bool Get_stsSaidaPID(ref System.Single value)
    {
      if (accessorService == null)
        return false;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,4, ref var);
      if (ret) value = (System.Single) var;
      return ret;
    }

    public System.Single? stsSaidaPID
    { get {
      if (accessorService == null)
        return null;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,4, ref var);
      if (!ret) return null;
      return (System.Single) var;
    }  }

    public bool Get_STS_PRINCIPAL(ref System.UInt16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,5, ref var);
      if (ret) value = (System.UInt16) var;
      return ret;
    }

    public System.UInt16? STS_PRINCIPAL
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,5, ref var);
      if (!ret) return null;
      return (System.UInt16) var;
    }  }

    public bool Get_STS_SEGUNDA(ref System.UInt16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,6, ref var);
      if (ret) value = (System.UInt16) var;
      return ret;
    }

    public System.UInt16? STS_SEGUNDA
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,6, ref var);
      if (!ret) return null;
      return (System.UInt16) var;
    }  }

    public bool Get_STS_BOMBAS_LIGADAS(ref System.UInt16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,7, ref var);
      if (ret) value = (System.UInt16) var;
      return ret;
    }

    public System.UInt16? STS_BOMBAS_LIGADAS
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,7, ref var);
      if (!ret) return null;
      return (System.UInt16) var;
    }  }

    public bool Get_STS_VELOCIDADE(ref System.Single value)
    {
      if (accessorService == null)
        return false;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,8, ref var);
      if (ret) value = (System.Single) var;
      return ret;
    }

    public System.Single? STS_VELOCIDADE
    { get {
      if (accessorService == null)
        return null;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,8, ref var);
      if (!ret) return null;
      return (System.Single) var;
    }  }

    public bool Get_STS_NIVEL(ref System.Single value)
    {
      if (accessorService == null)
        return false;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,9, ref var);
      if (ret) value = (System.Single) var;
      return ret;
    }

    public System.Single? STS_NIVEL
    { get {
      if (accessorService == null)
        return null;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,9, ref var);
      if (!ret) return null;
      return (System.Single) var;
    }  }

    public bool Get_STS_ESTADO(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,10, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? STS_ESTADO
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,10, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }

    public bool Get_STS_MODO_BOIAS(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,11, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_MODO_BOIAS
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,11, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_SEGURANDO_BUFFER(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,12, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_SEGURANDO_BUFFER
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,12, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_FALHA_RECALQUE(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,13, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_FALHA_RECALQUE
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,13, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_FALHA_BOIA_L(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,14, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_FALHA_BOIA_L
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,14, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_NIVEL_BAIXO(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,15, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_NIVEL_BAIXO
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,15, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_BOIA_L(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,16, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_BOIA_L
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,16, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_BOIA_H(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,17, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_BOIA_H
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,17, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_BUFFER_HH(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,18, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_BUFFER_HH
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,18, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_ALARME(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,19, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_ALARME
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,19, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_ALM_RECALQUE_EST(ref System.Byte value)
    {
      if (accessorService == null)
        return false;
      byte var = 0;
      bool ret = accessorService.GetByteValue(channelId, cookie, eventIndex, true,20, ref var);
      if (ret) value = (System.Byte) var;
      return ret;
    }

    public System.Byte? STS_ALM_RECALQUE_EST
    { get {
      if (accessorService == null)
        return null;
      byte var = 0;
      bool ret = accessorService.GetByteValue(channelId, cookie, eventIndex, true,20, ref var);
      if (!ret) return null;
      return (System.Byte) var;
    }  }

    public bool Get_STS_ALM_NIVEL_ALTO_EST(ref System.Byte value)
    {
      if (accessorService == null)
        return false;
      byte var = 0;
      bool ret = accessorService.GetByteValue(channelId, cookie, eventIndex, true,21, ref var);
      if (ret) value = (System.Byte) var;
      return ret;
    }

    public System.Byte? STS_ALM_NIVEL_ALTO_EST
    { get {
      if (accessorService == null)
        return null;
      byte var = 0;
      bool ret = accessorService.GetByteValue(channelId, cookie, eventIndex, true,21, ref var);
      if (!ret) return null;
      return (System.Byte) var;
    }  }

    public bool Get_STS_ALM_FALHA_BOIA_EST(ref System.Byte value)
    {
      if (accessorService == null)
        return false;
      byte var = 0;
      bool ret = accessorService.GetByteValue(channelId, cookie, eventIndex, true,22, ref var);
      if (ret) value = (System.Byte) var;
      return ret;
    }

    public System.Byte? STS_ALM_FALHA_BOIA_EST
    { get {
      if (accessorService == null)
        return null;
      byte var = 0;
      bool ret = accessorService.GetByteValue(channelId, cookie, eventIndex, true,22, ref var);
      if (!ret) return null;
      return (System.Byte) var;
    }  }


  }

}

namespace Hidryco.HidrycoLib.Symbols.EEE_Bruto
{

  public class E_PARAMETROSEventArgs : System.EventArgs
  {
    public E_PARAMETROSEventArgs()
    {
    }
    private System.Boolean? NEC_CMD_HABILITA_field = null;
    public System.Boolean? NEC_CMD_HABILITA
    {
       get { return NEC_CMD_HABILITA_field; }
       set { NEC_CMD_HABILITA_field = value; }
    }
    private System.Single? STP_LIMITE_FAIXA_1_field = null;
    public System.Single? STP_LIMITE_FAIXA_1
    {
       get { return STP_LIMITE_FAIXA_1_field; }
       set { STP_LIMITE_FAIXA_1_field = value; }
    }
    private System.Single? STP_LIMITE_FAIXA_2_field = null;
    public System.Single? STP_LIMITE_FAIXA_2
    {
       get { return STP_LIMITE_FAIXA_2_field; }
       set { STP_LIMITE_FAIXA_2_field = value; }
    }
    private System.Single? STP_LIMITE_FAIXA_3_field = null;
    public System.Single? STP_LIMITE_FAIXA_3
    {
       get { return STP_LIMITE_FAIXA_3_field; }
       set { STP_LIMITE_FAIXA_3_field = value; }
    }
    private System.Single? STP_LIMITE_FAIXA_4_field = null;
    public System.Single? STP_LIMITE_FAIXA_4
    {
       get { return STP_LIMITE_FAIXA_4_field; }
       set { STP_LIMITE_FAIXA_4_field = value; }
    }
    private System.Boolean? REV_CMD_HABILITA_field = null;
    public System.Boolean? REV_CMD_HABILITA
    {
       get { return REV_CMD_HABILITA_field; }
       set { REV_CMD_HABILITA_field = value; }
    }
    private System.UInt16? STP_TEMPO_B1_field = null;
    public System.UInt16? STP_TEMPO_B1
    {
       get { return STP_TEMPO_B1_field; }
       set { STP_TEMPO_B1_field = value; }
    }
    private System.UInt16? STP_TEMPO_B2_field = null;
    public System.UInt16? STP_TEMPO_B2
    {
       get { return STP_TEMPO_B2_field; }
       set { STP_TEMPO_B2_field = value; }
    }
    private System.UInt16? STP_TEMPO_B3_field = null;
    public System.UInt16? STP_TEMPO_B3
    {
       get { return STP_TEMPO_B3_field; }
       set { STP_TEMPO_B3_field = value; }
    }
    private System.Int16? CMD_SELECAO_BOMBA_field = null;
    public System.Int16? CMD_SELECAO_BOMBA
    {
       get { return CMD_SELECAO_BOMBA_field; }
       set { CMD_SELECAO_BOMBA_field = value; }
    }
    private System.Boolean? PID_CMD_HABILITA_field = null;
    public System.Boolean? PID_CMD_HABILITA
    {
       get { return PID_CMD_HABILITA_field; }
       set { PID_CMD_HABILITA_field = value; }
    }
    private System.Single? STP_DESEJADO_field = null;
    public System.Single? STP_DESEJADO
    {
       get { return STP_DESEJADO_field; }
       set { STP_DESEJADO_field = value; }
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

namespace Hidryco.HidrycoLib.Symbols.EEE_Bruto
{
  partial class sDefault
  {

    private event EventHandler<Hidryco.HidrycoLib.Symbols.EEE_Bruto.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    private event EventHandler<Hidryco.HidrycoLib.Symbols.EEE_Bruto.REQEventArgs> REQ_Fired;

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
              LOAD_PERS_DATA_Fired(this, new Hidryco.HidrycoLib.Symbols.EEE_Bruto.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
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
              REQ_Fired(this, new Hidryco.HidrycoLib.Symbols.EEE_Bruto.REQEventArgs(channelId, cookie, eventIndex));
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
    public bool FireEvent_E_PARAMETROS(System.Boolean NEC_CMD_HABILITA, System.Single STP_LIMITE_FAIXA_1, System.Single STP_LIMITE_FAIXA_2, System.Single STP_LIMITE_FAIXA_3, System.Single STP_LIMITE_FAIXA_4, System.Boolean REV_CMD_HABILITA, System.UInt16 STP_TEMPO_B1, System.UInt16 STP_TEMPO_B2, System.UInt16 STP_TEMPO_B3, System.Int16 CMD_SELECAO_BOMBA, System.Boolean PID_CMD_HABILITA, System.Single STP_DESEJADO, System.Single STP_PARAMETRO_KP, System.Single STP_PARAMETRO_KI, System.Single STP_PARAMETRO_KD, System.Single STP_MINIMO, System.Single STP_MAXIMO)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {NEC_CMD_HABILITA, STP_LIMITE_FAIXA_1, STP_LIMITE_FAIXA_2, STP_LIMITE_FAIXA_3, STP_LIMITE_FAIXA_4, REV_CMD_HABILITA, STP_TEMPO_B1, STP_TEMPO_B2, STP_TEMPO_B3, CMD_SELECAO_BOMBA, PID_CMD_HABILITA, STP_DESEJADO, STP_PARAMETRO_KP, STP_PARAMETRO_KI, STP_PARAMETRO_KD, STP_MINIMO, STP_MAXIMO});
    }
    public bool FireEvent_E_PARAMETROS(Hidryco.HidrycoLib.Symbols.EEE_Bruto.E_PARAMETROSEventArgs ea)
    {
      object[] _values_ = new object[17];
      if (ea.NEC_CMD_HABILITA.HasValue) _values_[0] = ea.NEC_CMD_HABILITA.Value;
      if (ea.STP_LIMITE_FAIXA_1.HasValue) _values_[1] = ea.STP_LIMITE_FAIXA_1.Value;
      if (ea.STP_LIMITE_FAIXA_2.HasValue) _values_[2] = ea.STP_LIMITE_FAIXA_2.Value;
      if (ea.STP_LIMITE_FAIXA_3.HasValue) _values_[3] = ea.STP_LIMITE_FAIXA_3.Value;
      if (ea.STP_LIMITE_FAIXA_4.HasValue) _values_[4] = ea.STP_LIMITE_FAIXA_4.Value;
      if (ea.REV_CMD_HABILITA.HasValue) _values_[5] = ea.REV_CMD_HABILITA.Value;
      if (ea.STP_TEMPO_B1.HasValue) _values_[6] = ea.STP_TEMPO_B1.Value;
      if (ea.STP_TEMPO_B2.HasValue) _values_[7] = ea.STP_TEMPO_B2.Value;
      if (ea.STP_TEMPO_B3.HasValue) _values_[8] = ea.STP_TEMPO_B3.Value;
      if (ea.CMD_SELECAO_BOMBA.HasValue) _values_[9] = ea.CMD_SELECAO_BOMBA.Value;
      if (ea.PID_CMD_HABILITA.HasValue) _values_[10] = ea.PID_CMD_HABILITA.Value;
      if (ea.STP_DESEJADO.HasValue) _values_[11] = ea.STP_DESEJADO.Value;
      if (ea.STP_PARAMETRO_KP.HasValue) _values_[12] = ea.STP_PARAMETRO_KP.Value;
      if (ea.STP_PARAMETRO_KI.HasValue) _values_[13] = ea.STP_PARAMETRO_KI.Value;
      if (ea.STP_PARAMETRO_KD.HasValue) _values_[14] = ea.STP_PARAMETRO_KD.Value;
      if (ea.STP_MINIMO.HasValue) _values_[15] = ea.STP_MINIMO.Value;
      if (ea.STP_MAXIMO.HasValue) _values_[16] = ea.STP_MAXIMO.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_E_PARAMETROS(System.Boolean NEC_CMD_HABILITA, bool ignore_NEC_CMD_HABILITA, System.Single STP_LIMITE_FAIXA_1, bool ignore_STP_LIMITE_FAIXA_1, System.Single STP_LIMITE_FAIXA_2, bool ignore_STP_LIMITE_FAIXA_2, System.Single STP_LIMITE_FAIXA_3, bool ignore_STP_LIMITE_FAIXA_3, System.Single STP_LIMITE_FAIXA_4, bool ignore_STP_LIMITE_FAIXA_4, System.Boolean REV_CMD_HABILITA, bool ignore_REV_CMD_HABILITA, System.UInt16 STP_TEMPO_B1, bool ignore_STP_TEMPO_B1, System.UInt16 STP_TEMPO_B2, bool ignore_STP_TEMPO_B2, System.UInt16 STP_TEMPO_B3, bool ignore_STP_TEMPO_B3, System.Int16 CMD_SELECAO_BOMBA, bool ignore_CMD_SELECAO_BOMBA, System.Boolean PID_CMD_HABILITA, bool ignore_PID_CMD_HABILITA, System.Single STP_DESEJADO, bool ignore_STP_DESEJADO, System.Single STP_PARAMETRO_KP, bool ignore_STP_PARAMETRO_KP, System.Single STP_PARAMETRO_KI, bool ignore_STP_PARAMETRO_KI, System.Single STP_PARAMETRO_KD, bool ignore_STP_PARAMETRO_KD, System.Single STP_MINIMO, bool ignore_STP_MINIMO, System.Single STP_MAXIMO, bool ignore_STP_MAXIMO)
    {
      object[] _values_ = new object[17];
      if (!ignore_NEC_CMD_HABILITA) _values_[0] = NEC_CMD_HABILITA;
      if (!ignore_STP_LIMITE_FAIXA_1) _values_[1] = STP_LIMITE_FAIXA_1;
      if (!ignore_STP_LIMITE_FAIXA_2) _values_[2] = STP_LIMITE_FAIXA_2;
      if (!ignore_STP_LIMITE_FAIXA_3) _values_[3] = STP_LIMITE_FAIXA_3;
      if (!ignore_STP_LIMITE_FAIXA_4) _values_[4] = STP_LIMITE_FAIXA_4;
      if (!ignore_REV_CMD_HABILITA) _values_[5] = REV_CMD_HABILITA;
      if (!ignore_STP_TEMPO_B1) _values_[6] = STP_TEMPO_B1;
      if (!ignore_STP_TEMPO_B2) _values_[7] = STP_TEMPO_B2;
      if (!ignore_STP_TEMPO_B3) _values_[8] = STP_TEMPO_B3;
      if (!ignore_CMD_SELECAO_BOMBA) _values_[9] = CMD_SELECAO_BOMBA;
      if (!ignore_PID_CMD_HABILITA) _values_[10] = PID_CMD_HABILITA;
      if (!ignore_STP_DESEJADO) _values_[11] = STP_DESEJADO;
      if (!ignore_STP_PARAMETRO_KP) _values_[12] = STP_PARAMETRO_KP;
      if (!ignore_STP_PARAMETRO_KI) _values_[13] = STP_PARAMETRO_KI;
      if (!ignore_STP_PARAMETRO_KD) _values_[14] = STP_PARAMETRO_KD;
      if (!ignore_STP_MINIMO) _values_[15] = STP_MINIMO;
      if (!ignore_STP_MAXIMO) _values_[16] = STP_MAXIMO;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_E_RESET(System.Boolean CMD_RESET)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {CMD_RESET});
    }
    public bool FireEvent_E_RESET(Hidryco.HidrycoLib.Symbols.EEE_Bruto.E_RESETEventArgs ea)
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

namespace Hidryco.HidrycoLib.Faceplates.EEE_Bruto
{
  partial class fpDefault
  {

    private event EventHandler<Hidryco.HidrycoLib.Symbols.EEE_Bruto.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    private event EventHandler<Hidryco.HidrycoLib.Symbols.EEE_Bruto.REQEventArgs> REQ_Fired;

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
              LOAD_PERS_DATA_Fired(this, new Hidryco.HidrycoLib.Symbols.EEE_Bruto.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
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
              REQ_Fired(this, new Hidryco.HidrycoLib.Symbols.EEE_Bruto.REQEventArgs(channelId, cookie, eventIndex));
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
    public bool FireEvent_E_PARAMETROS(System.Boolean NEC_CMD_HABILITA, System.Single STP_LIMITE_FAIXA_1, System.Single STP_LIMITE_FAIXA_2, System.Single STP_LIMITE_FAIXA_3, System.Single STP_LIMITE_FAIXA_4, System.Boolean REV_CMD_HABILITA, System.UInt16 STP_TEMPO_B1, System.UInt16 STP_TEMPO_B2, System.UInt16 STP_TEMPO_B3, System.Int16 CMD_SELECAO_BOMBA, System.Boolean PID_CMD_HABILITA, System.Single STP_DESEJADO, System.Single STP_PARAMETRO_KP, System.Single STP_PARAMETRO_KI, System.Single STP_PARAMETRO_KD, System.Single STP_MINIMO, System.Single STP_MAXIMO)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {NEC_CMD_HABILITA, STP_LIMITE_FAIXA_1, STP_LIMITE_FAIXA_2, STP_LIMITE_FAIXA_3, STP_LIMITE_FAIXA_4, REV_CMD_HABILITA, STP_TEMPO_B1, STP_TEMPO_B2, STP_TEMPO_B3, CMD_SELECAO_BOMBA, PID_CMD_HABILITA, STP_DESEJADO, STP_PARAMETRO_KP, STP_PARAMETRO_KI, STP_PARAMETRO_KD, STP_MINIMO, STP_MAXIMO});
    }
    public bool FireEvent_E_PARAMETROS(Hidryco.HidrycoLib.Symbols.EEE_Bruto.E_PARAMETROSEventArgs ea)
    {
      object[] _values_ = new object[17];
      if (ea.NEC_CMD_HABILITA.HasValue) _values_[0] = ea.NEC_CMD_HABILITA.Value;
      if (ea.STP_LIMITE_FAIXA_1.HasValue) _values_[1] = ea.STP_LIMITE_FAIXA_1.Value;
      if (ea.STP_LIMITE_FAIXA_2.HasValue) _values_[2] = ea.STP_LIMITE_FAIXA_2.Value;
      if (ea.STP_LIMITE_FAIXA_3.HasValue) _values_[3] = ea.STP_LIMITE_FAIXA_3.Value;
      if (ea.STP_LIMITE_FAIXA_4.HasValue) _values_[4] = ea.STP_LIMITE_FAIXA_4.Value;
      if (ea.REV_CMD_HABILITA.HasValue) _values_[5] = ea.REV_CMD_HABILITA.Value;
      if (ea.STP_TEMPO_B1.HasValue) _values_[6] = ea.STP_TEMPO_B1.Value;
      if (ea.STP_TEMPO_B2.HasValue) _values_[7] = ea.STP_TEMPO_B2.Value;
      if (ea.STP_TEMPO_B3.HasValue) _values_[8] = ea.STP_TEMPO_B3.Value;
      if (ea.CMD_SELECAO_BOMBA.HasValue) _values_[9] = ea.CMD_SELECAO_BOMBA.Value;
      if (ea.PID_CMD_HABILITA.HasValue) _values_[10] = ea.PID_CMD_HABILITA.Value;
      if (ea.STP_DESEJADO.HasValue) _values_[11] = ea.STP_DESEJADO.Value;
      if (ea.STP_PARAMETRO_KP.HasValue) _values_[12] = ea.STP_PARAMETRO_KP.Value;
      if (ea.STP_PARAMETRO_KI.HasValue) _values_[13] = ea.STP_PARAMETRO_KI.Value;
      if (ea.STP_PARAMETRO_KD.HasValue) _values_[14] = ea.STP_PARAMETRO_KD.Value;
      if (ea.STP_MINIMO.HasValue) _values_[15] = ea.STP_MINIMO.Value;
      if (ea.STP_MAXIMO.HasValue) _values_[16] = ea.STP_MAXIMO.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_E_PARAMETROS(System.Boolean NEC_CMD_HABILITA, bool ignore_NEC_CMD_HABILITA, System.Single STP_LIMITE_FAIXA_1, bool ignore_STP_LIMITE_FAIXA_1, System.Single STP_LIMITE_FAIXA_2, bool ignore_STP_LIMITE_FAIXA_2, System.Single STP_LIMITE_FAIXA_3, bool ignore_STP_LIMITE_FAIXA_3, System.Single STP_LIMITE_FAIXA_4, bool ignore_STP_LIMITE_FAIXA_4, System.Boolean REV_CMD_HABILITA, bool ignore_REV_CMD_HABILITA, System.UInt16 STP_TEMPO_B1, bool ignore_STP_TEMPO_B1, System.UInt16 STP_TEMPO_B2, bool ignore_STP_TEMPO_B2, System.UInt16 STP_TEMPO_B3, bool ignore_STP_TEMPO_B3, System.Int16 CMD_SELECAO_BOMBA, bool ignore_CMD_SELECAO_BOMBA, System.Boolean PID_CMD_HABILITA, bool ignore_PID_CMD_HABILITA, System.Single STP_DESEJADO, bool ignore_STP_DESEJADO, System.Single STP_PARAMETRO_KP, bool ignore_STP_PARAMETRO_KP, System.Single STP_PARAMETRO_KI, bool ignore_STP_PARAMETRO_KI, System.Single STP_PARAMETRO_KD, bool ignore_STP_PARAMETRO_KD, System.Single STP_MINIMO, bool ignore_STP_MINIMO, System.Single STP_MAXIMO, bool ignore_STP_MAXIMO)
    {
      object[] _values_ = new object[17];
      if (!ignore_NEC_CMD_HABILITA) _values_[0] = NEC_CMD_HABILITA;
      if (!ignore_STP_LIMITE_FAIXA_1) _values_[1] = STP_LIMITE_FAIXA_1;
      if (!ignore_STP_LIMITE_FAIXA_2) _values_[2] = STP_LIMITE_FAIXA_2;
      if (!ignore_STP_LIMITE_FAIXA_3) _values_[3] = STP_LIMITE_FAIXA_3;
      if (!ignore_STP_LIMITE_FAIXA_4) _values_[4] = STP_LIMITE_FAIXA_4;
      if (!ignore_REV_CMD_HABILITA) _values_[5] = REV_CMD_HABILITA;
      if (!ignore_STP_TEMPO_B1) _values_[6] = STP_TEMPO_B1;
      if (!ignore_STP_TEMPO_B2) _values_[7] = STP_TEMPO_B2;
      if (!ignore_STP_TEMPO_B3) _values_[8] = STP_TEMPO_B3;
      if (!ignore_CMD_SELECAO_BOMBA) _values_[9] = CMD_SELECAO_BOMBA;
      if (!ignore_PID_CMD_HABILITA) _values_[10] = PID_CMD_HABILITA;
      if (!ignore_STP_DESEJADO) _values_[11] = STP_DESEJADO;
      if (!ignore_STP_PARAMETRO_KP) _values_[12] = STP_PARAMETRO_KP;
      if (!ignore_STP_PARAMETRO_KI) _values_[13] = STP_PARAMETRO_KI;
      if (!ignore_STP_PARAMETRO_KD) _values_[14] = STP_PARAMETRO_KD;
      if (!ignore_STP_MINIMO) _values_[15] = STP_MINIMO;
      if (!ignore_STP_MAXIMO) _values_[16] = STP_MAXIMO;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_E_RESET(System.Boolean CMD_RESET)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {CMD_RESET});
    }
    public bool FireEvent_E_RESET(Hidryco.HidrycoLib.Symbols.EEE_Bruto.E_RESETEventArgs ea)
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

namespace Hidryco.HidrycoLib.Faceplates.EEE_Bruto
{
  partial class fpParameter
  {

    private event EventHandler<Hidryco.HidrycoLib.Symbols.EEE_Bruto.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    private event EventHandler<Hidryco.HidrycoLib.Symbols.EEE_Bruto.REQEventArgs> REQ_Fired;

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
              LOAD_PERS_DATA_Fired(this, new Hidryco.HidrycoLib.Symbols.EEE_Bruto.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
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
              REQ_Fired(this, new Hidryco.HidrycoLib.Symbols.EEE_Bruto.REQEventArgs(channelId, cookie, eventIndex));
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
    public bool FireEvent_E_PARAMETROS(System.Boolean NEC_CMD_HABILITA, System.Single STP_LIMITE_FAIXA_1, System.Single STP_LIMITE_FAIXA_2, System.Single STP_LIMITE_FAIXA_3, System.Single STP_LIMITE_FAIXA_4, System.Boolean REV_CMD_HABILITA, System.UInt16 STP_TEMPO_B1, System.UInt16 STP_TEMPO_B2, System.UInt16 STP_TEMPO_B3, System.Int16 CMD_SELECAO_BOMBA, System.Boolean PID_CMD_HABILITA, System.Single STP_DESEJADO, System.Single STP_PARAMETRO_KP, System.Single STP_PARAMETRO_KI, System.Single STP_PARAMETRO_KD, System.Single STP_MINIMO, System.Single STP_MAXIMO)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {NEC_CMD_HABILITA, STP_LIMITE_FAIXA_1, STP_LIMITE_FAIXA_2, STP_LIMITE_FAIXA_3, STP_LIMITE_FAIXA_4, REV_CMD_HABILITA, STP_TEMPO_B1, STP_TEMPO_B2, STP_TEMPO_B3, CMD_SELECAO_BOMBA, PID_CMD_HABILITA, STP_DESEJADO, STP_PARAMETRO_KP, STP_PARAMETRO_KI, STP_PARAMETRO_KD, STP_MINIMO, STP_MAXIMO});
    }
    public bool FireEvent_E_PARAMETROS(Hidryco.HidrycoLib.Symbols.EEE_Bruto.E_PARAMETROSEventArgs ea)
    {
      object[] _values_ = new object[17];
      if (ea.NEC_CMD_HABILITA.HasValue) _values_[0] = ea.NEC_CMD_HABILITA.Value;
      if (ea.STP_LIMITE_FAIXA_1.HasValue) _values_[1] = ea.STP_LIMITE_FAIXA_1.Value;
      if (ea.STP_LIMITE_FAIXA_2.HasValue) _values_[2] = ea.STP_LIMITE_FAIXA_2.Value;
      if (ea.STP_LIMITE_FAIXA_3.HasValue) _values_[3] = ea.STP_LIMITE_FAIXA_3.Value;
      if (ea.STP_LIMITE_FAIXA_4.HasValue) _values_[4] = ea.STP_LIMITE_FAIXA_4.Value;
      if (ea.REV_CMD_HABILITA.HasValue) _values_[5] = ea.REV_CMD_HABILITA.Value;
      if (ea.STP_TEMPO_B1.HasValue) _values_[6] = ea.STP_TEMPO_B1.Value;
      if (ea.STP_TEMPO_B2.HasValue) _values_[7] = ea.STP_TEMPO_B2.Value;
      if (ea.STP_TEMPO_B3.HasValue) _values_[8] = ea.STP_TEMPO_B3.Value;
      if (ea.CMD_SELECAO_BOMBA.HasValue) _values_[9] = ea.CMD_SELECAO_BOMBA.Value;
      if (ea.PID_CMD_HABILITA.HasValue) _values_[10] = ea.PID_CMD_HABILITA.Value;
      if (ea.STP_DESEJADO.HasValue) _values_[11] = ea.STP_DESEJADO.Value;
      if (ea.STP_PARAMETRO_KP.HasValue) _values_[12] = ea.STP_PARAMETRO_KP.Value;
      if (ea.STP_PARAMETRO_KI.HasValue) _values_[13] = ea.STP_PARAMETRO_KI.Value;
      if (ea.STP_PARAMETRO_KD.HasValue) _values_[14] = ea.STP_PARAMETRO_KD.Value;
      if (ea.STP_MINIMO.HasValue) _values_[15] = ea.STP_MINIMO.Value;
      if (ea.STP_MAXIMO.HasValue) _values_[16] = ea.STP_MAXIMO.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_E_PARAMETROS(System.Boolean NEC_CMD_HABILITA, bool ignore_NEC_CMD_HABILITA, System.Single STP_LIMITE_FAIXA_1, bool ignore_STP_LIMITE_FAIXA_1, System.Single STP_LIMITE_FAIXA_2, bool ignore_STP_LIMITE_FAIXA_2, System.Single STP_LIMITE_FAIXA_3, bool ignore_STP_LIMITE_FAIXA_3, System.Single STP_LIMITE_FAIXA_4, bool ignore_STP_LIMITE_FAIXA_4, System.Boolean REV_CMD_HABILITA, bool ignore_REV_CMD_HABILITA, System.UInt16 STP_TEMPO_B1, bool ignore_STP_TEMPO_B1, System.UInt16 STP_TEMPO_B2, bool ignore_STP_TEMPO_B2, System.UInt16 STP_TEMPO_B3, bool ignore_STP_TEMPO_B3, System.Int16 CMD_SELECAO_BOMBA, bool ignore_CMD_SELECAO_BOMBA, System.Boolean PID_CMD_HABILITA, bool ignore_PID_CMD_HABILITA, System.Single STP_DESEJADO, bool ignore_STP_DESEJADO, System.Single STP_PARAMETRO_KP, bool ignore_STP_PARAMETRO_KP, System.Single STP_PARAMETRO_KI, bool ignore_STP_PARAMETRO_KI, System.Single STP_PARAMETRO_KD, bool ignore_STP_PARAMETRO_KD, System.Single STP_MINIMO, bool ignore_STP_MINIMO, System.Single STP_MAXIMO, bool ignore_STP_MAXIMO)
    {
      object[] _values_ = new object[17];
      if (!ignore_NEC_CMD_HABILITA) _values_[0] = NEC_CMD_HABILITA;
      if (!ignore_STP_LIMITE_FAIXA_1) _values_[1] = STP_LIMITE_FAIXA_1;
      if (!ignore_STP_LIMITE_FAIXA_2) _values_[2] = STP_LIMITE_FAIXA_2;
      if (!ignore_STP_LIMITE_FAIXA_3) _values_[3] = STP_LIMITE_FAIXA_3;
      if (!ignore_STP_LIMITE_FAIXA_4) _values_[4] = STP_LIMITE_FAIXA_4;
      if (!ignore_REV_CMD_HABILITA) _values_[5] = REV_CMD_HABILITA;
      if (!ignore_STP_TEMPO_B1) _values_[6] = STP_TEMPO_B1;
      if (!ignore_STP_TEMPO_B2) _values_[7] = STP_TEMPO_B2;
      if (!ignore_STP_TEMPO_B3) _values_[8] = STP_TEMPO_B3;
      if (!ignore_CMD_SELECAO_BOMBA) _values_[9] = CMD_SELECAO_BOMBA;
      if (!ignore_PID_CMD_HABILITA) _values_[10] = PID_CMD_HABILITA;
      if (!ignore_STP_DESEJADO) _values_[11] = STP_DESEJADO;
      if (!ignore_STP_PARAMETRO_KP) _values_[12] = STP_PARAMETRO_KP;
      if (!ignore_STP_PARAMETRO_KI) _values_[13] = STP_PARAMETRO_KI;
      if (!ignore_STP_PARAMETRO_KD) _values_[14] = STP_PARAMETRO_KD;
      if (!ignore_STP_MINIMO) _values_[15] = STP_MINIMO;
      if (!ignore_STP_MAXIMO) _values_[16] = STP_MAXIMO;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_E_RESET(System.Boolean CMD_RESET)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {CMD_RESET});
    }
    public bool FireEvent_E_RESET(Hidryco.HidrycoLib.Symbols.EEE_Bruto.E_RESETEventArgs ea)
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
#endregion #EEE_Bruto_HMI;

#endregion Definitions;
