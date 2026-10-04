/*
 * Criado pelo EcoStruxure Automation Expert.
 * Usuário:  
 * Data: 25/02/2026
 * Tempo: 16:49
 * 
 */
using System;
using NxtControl.GuiFramework;
using NxtControl.Services;

#region Definitions;
#region #Necessidade_2_Equipamentos_HMI;

namespace Hidryco.HidrycoLib.Symbols.Necessidade_2_Equipamentos
{

  public class E_ATUALIZA_NECESSIDADEEventArgs : System.EventArgs
  {
    IHMIAccessorService accessorService;
    int channelId;
    int cookie; 
    int eventIndex;

    public E_ATUALIZA_NECESSIDADEEventArgs(int channelId, int cookie, int eventIndex)
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


  }

}

namespace Hidryco.HidrycoLib.Symbols.Necessidade_2_Equipamentos
{

  public class E_ATUALIZA_SETPOINTEventArgs : System.EventArgs
  {
    public E_ATUALIZA_SETPOINTEventArgs()
    {
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
    private System.Boolean? CMD_HABILITA_field = null;
    public System.Boolean? CMD_HABILITA
    {
       get { return CMD_HABILITA_field; }
       set { CMD_HABILITA_field = value; }
    }

  }

}

namespace Hidryco.HidrycoLib.Symbols.Necessidade_2_Equipamentos
{
  partial class sDefault
  {

    private event EventHandler<Hidryco.HidrycoLib.Symbols.Necessidade_2_Equipamentos.E_ATUALIZA_NECESSIDADEEventArgs> E_ATUALIZA_NECESSIDADE_Fired;

    protected override void OnEndInit()
    {
      if (E_ATUALIZA_NECESSIDADE_Fired != null)
        AttachEventInput(0);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (E_ATUALIZA_NECESSIDADE_Fired != null)
          {
            try
            {
              E_ATUALIZA_NECESSIDADE_Fired(this, new Hidryco.HidrycoLib.Symbols.Necessidade_2_Equipamentos.E_ATUALIZA_NECESSIDADEEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","E_ATUALIZA_NECESSIDADE_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_E_ATUALIZA_SETPOINT(System.Single STP_LIMITE_FAIXA_1, System.Single STP_LIMITE_FAIXA_2, System.Single STP_LIMITE_FAIXA_3, System.Single STP_LIMITE_FAIXA_4, System.Boolean CMD_HABILITA)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {STP_LIMITE_FAIXA_1, STP_LIMITE_FAIXA_2, STP_LIMITE_FAIXA_3, STP_LIMITE_FAIXA_4, CMD_HABILITA});
    }
    public bool FireEvent_E_ATUALIZA_SETPOINT(Hidryco.HidrycoLib.Symbols.Necessidade_2_Equipamentos.E_ATUALIZA_SETPOINTEventArgs ea)
    {
      object[] _values_ = new object[5];
      if (ea.STP_LIMITE_FAIXA_1.HasValue) _values_[0] = ea.STP_LIMITE_FAIXA_1.Value;
      if (ea.STP_LIMITE_FAIXA_2.HasValue) _values_[1] = ea.STP_LIMITE_FAIXA_2.Value;
      if (ea.STP_LIMITE_FAIXA_3.HasValue) _values_[2] = ea.STP_LIMITE_FAIXA_3.Value;
      if (ea.STP_LIMITE_FAIXA_4.HasValue) _values_[3] = ea.STP_LIMITE_FAIXA_4.Value;
      if (ea.CMD_HABILITA.HasValue) _values_[4] = ea.CMD_HABILITA.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_E_ATUALIZA_SETPOINT(System.Single STP_LIMITE_FAIXA_1, bool ignore_STP_LIMITE_FAIXA_1, System.Single STP_LIMITE_FAIXA_2, bool ignore_STP_LIMITE_FAIXA_2, System.Single STP_LIMITE_FAIXA_3, bool ignore_STP_LIMITE_FAIXA_3, System.Single STP_LIMITE_FAIXA_4, bool ignore_STP_LIMITE_FAIXA_4, System.Boolean CMD_HABILITA, bool ignore_CMD_HABILITA)
    {
      object[] _values_ = new object[5];
      if (!ignore_STP_LIMITE_FAIXA_1) _values_[0] = STP_LIMITE_FAIXA_1;
      if (!ignore_STP_LIMITE_FAIXA_2) _values_[1] = STP_LIMITE_FAIXA_2;
      if (!ignore_STP_LIMITE_FAIXA_3) _values_[2] = STP_LIMITE_FAIXA_3;
      if (!ignore_STP_LIMITE_FAIXA_4) _values_[3] = STP_LIMITE_FAIXA_4;
      if (!ignore_CMD_HABILITA) _values_[4] = CMD_HABILITA;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }

  }
}

namespace Hidryco.HidrycoLib.Faceplates.Necessidade_2_Equipamentos
{
  partial class Faceplate1
  {

    private event EventHandler<Hidryco.HidrycoLib.Symbols.Necessidade_2_Equipamentos.E_ATUALIZA_NECESSIDADEEventArgs> E_ATUALIZA_NECESSIDADE_Fired;

    protected override void OnEndInit()
    {
      if (E_ATUALIZA_NECESSIDADE_Fired != null)
        AttachEventInput(0);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (E_ATUALIZA_NECESSIDADE_Fired != null)
          {
            try
            {
              E_ATUALIZA_NECESSIDADE_Fired(this, new Hidryco.HidrycoLib.Symbols.Necessidade_2_Equipamentos.E_ATUALIZA_NECESSIDADEEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","E_ATUALIZA_NECESSIDADE_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_E_ATUALIZA_SETPOINT(System.Single STP_LIMITE_FAIXA_1, System.Single STP_LIMITE_FAIXA_2, System.Single STP_LIMITE_FAIXA_3, System.Single STP_LIMITE_FAIXA_4, System.Boolean CMD_HABILITA)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {STP_LIMITE_FAIXA_1, STP_LIMITE_FAIXA_2, STP_LIMITE_FAIXA_3, STP_LIMITE_FAIXA_4, CMD_HABILITA});
    }
    public bool FireEvent_E_ATUALIZA_SETPOINT(Hidryco.HidrycoLib.Symbols.Necessidade_2_Equipamentos.E_ATUALIZA_SETPOINTEventArgs ea)
    {
      object[] _values_ = new object[5];
      if (ea.STP_LIMITE_FAIXA_1.HasValue) _values_[0] = ea.STP_LIMITE_FAIXA_1.Value;
      if (ea.STP_LIMITE_FAIXA_2.HasValue) _values_[1] = ea.STP_LIMITE_FAIXA_2.Value;
      if (ea.STP_LIMITE_FAIXA_3.HasValue) _values_[2] = ea.STP_LIMITE_FAIXA_3.Value;
      if (ea.STP_LIMITE_FAIXA_4.HasValue) _values_[3] = ea.STP_LIMITE_FAIXA_4.Value;
      if (ea.CMD_HABILITA.HasValue) _values_[4] = ea.CMD_HABILITA.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_E_ATUALIZA_SETPOINT(System.Single STP_LIMITE_FAIXA_1, bool ignore_STP_LIMITE_FAIXA_1, System.Single STP_LIMITE_FAIXA_2, bool ignore_STP_LIMITE_FAIXA_2, System.Single STP_LIMITE_FAIXA_3, bool ignore_STP_LIMITE_FAIXA_3, System.Single STP_LIMITE_FAIXA_4, bool ignore_STP_LIMITE_FAIXA_4, System.Boolean CMD_HABILITA, bool ignore_CMD_HABILITA)
    {
      object[] _values_ = new object[5];
      if (!ignore_STP_LIMITE_FAIXA_1) _values_[0] = STP_LIMITE_FAIXA_1;
      if (!ignore_STP_LIMITE_FAIXA_2) _values_[1] = STP_LIMITE_FAIXA_2;
      if (!ignore_STP_LIMITE_FAIXA_3) _values_[2] = STP_LIMITE_FAIXA_3;
      if (!ignore_STP_LIMITE_FAIXA_4) _values_[3] = STP_LIMITE_FAIXA_4;
      if (!ignore_CMD_HABILITA) _values_[4] = CMD_HABILITA;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }

  }
}
#endregion #Necessidade_2_Equipamentos_HMI;

#endregion Definitions;
