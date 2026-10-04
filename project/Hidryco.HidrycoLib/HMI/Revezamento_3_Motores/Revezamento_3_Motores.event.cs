/*
 * Criado pelo EcoStruxure Automation Expert.
 * Usuário:  
 * Data: 25/02/2026
 * Tempo: 09:32
 * 
 */
using System;
using NxtControl.GuiFramework;
using NxtControl.Services;

#region Definitions;
#region #Revezamento_3_Motores_HMI;

namespace Hidryco.HidrycoLib.Symbols.Revezamento_3_Motores
{

  public class E_ATUALIZA_TEMPO_RESTANTEEventArgs : System.EventArgs
  {
    IHMIAccessorService accessorService;
    int channelId;
    int cookie; 
    int eventIndex;

    public E_ATUALIZA_TEMPO_RESTANTEEventArgs(int channelId, int cookie, int eventIndex)
    {
      this.accessorService = (IHMIAccessorService)ServiceProvider.GetService(typeof(IHMIAccessorService));
      this.channelId = channelId;
      this.cookie = cookie;
      this.eventIndex = eventIndex;
    }
    public bool Get_STS_RESTANTE_HOR(ref System.UInt16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,0, ref var);
      if (ret) value = (System.UInt16) var;
      return ret;
    }

    public System.UInt16? STS_RESTANTE_HOR
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,0, ref var);
      if (!ret) return null;
      return (System.UInt16) var;
    }  }

    public bool Get_STS_RESTANTE_MIN(ref System.UInt16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,1, ref var);
      if (ret) value = (System.UInt16) var;
      return ret;
    }

    public System.UInt16? STS_RESTANTE_MIN
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,1, ref var);
      if (!ret) return null;
      return (System.UInt16) var;
    }  }

    public bool Get_STS_RESTANTE_SEG(ref System.UInt16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,2, ref var);
      if (ret) value = (System.UInt16) var;
      return ret;
    }

    public System.UInt16? STS_RESTANTE_SEG
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,2, ref var);
      if (!ret) return null;
      return (System.UInt16) var;
    }  }


  }

}

namespace Hidryco.HidrycoLib.Symbols.Revezamento_3_Motores
{

  public class E_ATUALIZA_SETPOINTEventArgs : System.EventArgs
  {
    public E_ATUALIZA_SETPOINTEventArgs()
    {
    }
    private System.Boolean? CMD_HABILITA_field = null;
    public System.Boolean? CMD_HABILITA
    {
       get { return CMD_HABILITA_field; }
       set { CMD_HABILITA_field = value; }
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

  }

  public class E_CMD_SELECAO_BOMBAEventArgs : System.EventArgs
  {
    public E_CMD_SELECAO_BOMBAEventArgs()
    {
    }
    private System.Int16? CMD_SELECAO_BOMBA_field = null;
    public System.Int16? CMD_SELECAO_BOMBA
    {
       get { return CMD_SELECAO_BOMBA_field; }
       set { CMD_SELECAO_BOMBA_field = value; }
    }

  }

}

namespace Hidryco.HidrycoLib.Symbols.Revezamento_3_Motores
{
  partial class sDefault
  {

    private event EventHandler<Hidryco.HidrycoLib.Symbols.Revezamento_3_Motores.E_ATUALIZA_TEMPO_RESTANTEEventArgs> E_ATUALIZA_TEMPO_RESTANTE_Fired;

    protected override void OnEndInit()
    {
      if (E_ATUALIZA_TEMPO_RESTANTE_Fired != null)
        AttachEventInput(0);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (E_ATUALIZA_TEMPO_RESTANTE_Fired != null)
          {
            try
            {
              E_ATUALIZA_TEMPO_RESTANTE_Fired(this, new Hidryco.HidrycoLib.Symbols.Revezamento_3_Motores.E_ATUALIZA_TEMPO_RESTANTEEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","E_ATUALIZA_TEMPO_RESTANTE_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_E_ATUALIZA_SETPOINT(System.Boolean CMD_HABILITA, System.UInt16 STP_TEMPO_B1, System.UInt16 STP_TEMPO_B2, System.UInt16 STP_TEMPO_B3)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {CMD_HABILITA, STP_TEMPO_B1, STP_TEMPO_B2, STP_TEMPO_B3});
    }
    public bool FireEvent_E_ATUALIZA_SETPOINT(Hidryco.HidrycoLib.Symbols.Revezamento_3_Motores.E_ATUALIZA_SETPOINTEventArgs ea)
    {
      object[] _values_ = new object[4];
      if (ea.CMD_HABILITA.HasValue) _values_[0] = ea.CMD_HABILITA.Value;
      if (ea.STP_TEMPO_B1.HasValue) _values_[1] = ea.STP_TEMPO_B1.Value;
      if (ea.STP_TEMPO_B2.HasValue) _values_[2] = ea.STP_TEMPO_B2.Value;
      if (ea.STP_TEMPO_B3.HasValue) _values_[3] = ea.STP_TEMPO_B3.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_E_ATUALIZA_SETPOINT(System.Boolean CMD_HABILITA, bool ignore_CMD_HABILITA, System.UInt16 STP_TEMPO_B1, bool ignore_STP_TEMPO_B1, System.UInt16 STP_TEMPO_B2, bool ignore_STP_TEMPO_B2, System.UInt16 STP_TEMPO_B3, bool ignore_STP_TEMPO_B3)
    {
      object[] _values_ = new object[4];
      if (!ignore_CMD_HABILITA) _values_[0] = CMD_HABILITA;
      if (!ignore_STP_TEMPO_B1) _values_[1] = STP_TEMPO_B1;
      if (!ignore_STP_TEMPO_B2) _values_[2] = STP_TEMPO_B2;
      if (!ignore_STP_TEMPO_B3) _values_[3] = STP_TEMPO_B3;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_E_CMD_SELECAO_BOMBA(System.Int16 CMD_SELECAO_BOMBA)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {CMD_SELECAO_BOMBA});
    }
    public bool FireEvent_E_CMD_SELECAO_BOMBA(Hidryco.HidrycoLib.Symbols.Revezamento_3_Motores.E_CMD_SELECAO_BOMBAEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.CMD_SELECAO_BOMBA.HasValue) _values_[0] = ea.CMD_SELECAO_BOMBA.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_E_CMD_SELECAO_BOMBA(System.Int16 CMD_SELECAO_BOMBA, bool ignore_CMD_SELECAO_BOMBA)
    {
      object[] _values_ = new object[1];
      if (!ignore_CMD_SELECAO_BOMBA) _values_[0] = CMD_SELECAO_BOMBA;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }

  }
}

namespace Hidryco.HidrycoLib.Faceplates.Revezamento_3_Motores
{
  partial class Faceplate1
  {

    private event EventHandler<Hidryco.HidrycoLib.Symbols.Revezamento_3_Motores.E_ATUALIZA_TEMPO_RESTANTEEventArgs> E_ATUALIZA_TEMPO_RESTANTE_Fired;

    protected override void OnEndInit()
    {
      if (E_ATUALIZA_TEMPO_RESTANTE_Fired != null)
        AttachEventInput(0);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (E_ATUALIZA_TEMPO_RESTANTE_Fired != null)
          {
            try
            {
              E_ATUALIZA_TEMPO_RESTANTE_Fired(this, new Hidryco.HidrycoLib.Symbols.Revezamento_3_Motores.E_ATUALIZA_TEMPO_RESTANTEEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","E_ATUALIZA_TEMPO_RESTANTE_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_E_ATUALIZA_SETPOINT(System.Boolean CMD_HABILITA, System.UInt16 STP_TEMPO_B1, System.UInt16 STP_TEMPO_B2, System.UInt16 STP_TEMPO_B3)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {CMD_HABILITA, STP_TEMPO_B1, STP_TEMPO_B2, STP_TEMPO_B3});
    }
    public bool FireEvent_E_ATUALIZA_SETPOINT(Hidryco.HidrycoLib.Symbols.Revezamento_3_Motores.E_ATUALIZA_SETPOINTEventArgs ea)
    {
      object[] _values_ = new object[4];
      if (ea.CMD_HABILITA.HasValue) _values_[0] = ea.CMD_HABILITA.Value;
      if (ea.STP_TEMPO_B1.HasValue) _values_[1] = ea.STP_TEMPO_B1.Value;
      if (ea.STP_TEMPO_B2.HasValue) _values_[2] = ea.STP_TEMPO_B2.Value;
      if (ea.STP_TEMPO_B3.HasValue) _values_[3] = ea.STP_TEMPO_B3.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_E_ATUALIZA_SETPOINT(System.Boolean CMD_HABILITA, bool ignore_CMD_HABILITA, System.UInt16 STP_TEMPO_B1, bool ignore_STP_TEMPO_B1, System.UInt16 STP_TEMPO_B2, bool ignore_STP_TEMPO_B2, System.UInt16 STP_TEMPO_B3, bool ignore_STP_TEMPO_B3)
    {
      object[] _values_ = new object[4];
      if (!ignore_CMD_HABILITA) _values_[0] = CMD_HABILITA;
      if (!ignore_STP_TEMPO_B1) _values_[1] = STP_TEMPO_B1;
      if (!ignore_STP_TEMPO_B2) _values_[2] = STP_TEMPO_B2;
      if (!ignore_STP_TEMPO_B3) _values_[3] = STP_TEMPO_B3;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_E_CMD_SELECAO_BOMBA(System.Int16 CMD_SELECAO_BOMBA)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {CMD_SELECAO_BOMBA});
    }
    public bool FireEvent_E_CMD_SELECAO_BOMBA(Hidryco.HidrycoLib.Symbols.Revezamento_3_Motores.E_CMD_SELECAO_BOMBAEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.CMD_SELECAO_BOMBA.HasValue) _values_[0] = ea.CMD_SELECAO_BOMBA.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_E_CMD_SELECAO_BOMBA(System.Int16 CMD_SELECAO_BOMBA, bool ignore_CMD_SELECAO_BOMBA)
    {
      object[] _values_ = new object[1];
      if (!ignore_CMD_SELECAO_BOMBA) _values_[0] = CMD_SELECAO_BOMBA;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }

  }
}
#endregion #Revezamento_3_Motores_HMI;

#endregion Definitions;
