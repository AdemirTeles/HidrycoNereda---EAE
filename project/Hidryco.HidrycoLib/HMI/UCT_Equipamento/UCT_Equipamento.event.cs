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
#region #UCT_Equipamento_HMI;

namespace Hidryco.HidrycoLib.Symbols.UCT_Equipamento
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
    public bool Get_STS_ANIMACAO(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,0, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? STS_ANIMACAO
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,0, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }

    public bool Get_STS_DEFEITO(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,1, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_DEFEITO
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,1, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_HORIMETRO_HORA(ref System.Int32 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,2, ref var);
      if (ret) value = (System.Int32) var;
      return ret;
    }

    public System.Int32? STS_HORIMETRO_HORA
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,2, ref var);
      if (!ret) return null;
      return (System.Int32) var;
    }  }

    public bool Get_STS_AUTOMATICO_SUBSISTEMA(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,3, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? STS_AUTOMATICO_SUBSISTEMA
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,3, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_STS_VELOCIDADE(ref System.Single value)
    {
      if (accessorService == null)
        return false;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,4, ref var);
      if (ret) value = (System.Single) var;
      return ret;
    }

    public System.Single? STS_VELOCIDADE
    { get {
      if (accessorService == null)
        return null;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,4, ref var);
      if (!ret) return null;
      return (System.Single) var;
    }  }

    public bool Get_fbkCmdLigaManual(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,5, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? fbkCmdLigaManual
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,5, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_fbkCmdLigaIntermitente(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,6, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? fbkCmdLigaIntermitente
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,6, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_fbkHabilitaReversao(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,7, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? fbkHabilitaReversao
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,7, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_CFG_VELOCIDADE(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,8, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? CFG_VELOCIDADE
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,8, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_CFG_INTERMITENTE(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,9, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? CFG_INTERMITENTE
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,9, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_CFG_REVERSAO(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,10, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? CFG_REVERSAO
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,10, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }


  }

}

namespace Hidryco.HidrycoLib.Symbols.UCT_Equipamento
{

  public class E_ATUALIZA_COMANDO_LIGA_MANUALEventArgs : System.EventArgs
  {
    public E_ATUALIZA_COMANDO_LIGA_MANUALEventArgs()
    {
    }
    private System.Boolean? cmdLigaManual_field = null;
    public System.Boolean? cmdLigaManual
    {
       get { return cmdLigaManual_field; }
       set { cmdLigaManual_field = value; }
    }

  }

  public class E_ATUALIZA_SETPOINTEventArgs : System.EventArgs
  {
    public E_ATUALIZA_SETPOINTEventArgs()
    {
    }
    private System.Single? stpVelocidade_field = null;
    public System.Single? stpVelocidade
    {
       get { return stpVelocidade_field; }
       set { stpVelocidade_field = value; }
    }

  }

  public class E_ATUALIZA_COMANDO_LIGA_INTERMITENTEEventArgs : System.EventArgs
  {
    public E_ATUALIZA_COMANDO_LIGA_INTERMITENTEEventArgs()
    {
    }
    private System.Boolean? cmdLigaIntermitente_field = null;
    public System.Boolean? cmdLigaIntermitente
    {
       get { return cmdLigaIntermitente_field; }
       set { cmdLigaIntermitente_field = value; }
    }

  }

  public class E_ATUALIZA_HABILITA_REVERSAOEventArgs : System.EventArgs
  {
    public E_ATUALIZA_HABILITA_REVERSAOEventArgs()
    {
    }
    private System.Boolean? habilitaReversao_field = null;
    public System.Boolean? habilitaReversao
    {
       get { return habilitaReversao_field; }
       set { habilitaReversao_field = value; }
    }

  }

}

namespace Hidryco.HidrycoLib.Symbols.UCT_Equipamento
{
  partial class sDefault
  {

    private event EventHandler<Hidryco.HidrycoLib.Symbols.UCT_Equipamento.REQEventArgs> REQ_Fired;

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
              REQ_Fired(this, new Hidryco.HidrycoLib.Symbols.UCT_Equipamento.REQEventArgs(channelId, cookie, eventIndex));
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
    public bool FireEvent_E_ATUALIZA_COMANDO_LIGA_MANUAL(System.Boolean cmdLigaManual)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {cmdLigaManual});
    }
    public bool FireEvent_E_ATUALIZA_COMANDO_LIGA_MANUAL(Hidryco.HidrycoLib.Symbols.UCT_Equipamento.E_ATUALIZA_COMANDO_LIGA_MANUALEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.cmdLigaManual.HasValue) _values_[0] = ea.cmdLigaManual.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_E_ATUALIZA_COMANDO_LIGA_MANUAL(System.Boolean cmdLigaManual, bool ignore_cmdLigaManual)
    {
      object[] _values_ = new object[1];
      if (!ignore_cmdLigaManual) _values_[0] = cmdLigaManual;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_E_ATUALIZA_SETPOINT(System.Single stpVelocidade)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {stpVelocidade});
    }
    public bool FireEvent_E_ATUALIZA_SETPOINT(Hidryco.HidrycoLib.Symbols.UCT_Equipamento.E_ATUALIZA_SETPOINTEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.stpVelocidade.HasValue) _values_[0] = ea.stpVelocidade.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_E_ATUALIZA_SETPOINT(System.Single stpVelocidade, bool ignore_stpVelocidade)
    {
      object[] _values_ = new object[1];
      if (!ignore_stpVelocidade) _values_[0] = stpVelocidade;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_E_ATUALIZA_COMANDO_LIGA_INTERMITENTE(System.Boolean cmdLigaIntermitente)
    {
      return ((IHMIAccessorOutput)this).FireEvent(2, new object[] {cmdLigaIntermitente});
    }
    public bool FireEvent_E_ATUALIZA_COMANDO_LIGA_INTERMITENTE(Hidryco.HidrycoLib.Symbols.UCT_Equipamento.E_ATUALIZA_COMANDO_LIGA_INTERMITENTEEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.cmdLigaIntermitente.HasValue) _values_[0] = ea.cmdLigaIntermitente.Value;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_E_ATUALIZA_COMANDO_LIGA_INTERMITENTE(System.Boolean cmdLigaIntermitente, bool ignore_cmdLigaIntermitente)
    {
      object[] _values_ = new object[1];
      if (!ignore_cmdLigaIntermitente) _values_[0] = cmdLigaIntermitente;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_E_ATUALIZA_HABILITA_REVERSAO(System.Boolean habilitaReversao)
    {
      return ((IHMIAccessorOutput)this).FireEvent(3, new object[] {habilitaReversao});
    }
    public bool FireEvent_E_ATUALIZA_HABILITA_REVERSAO(Hidryco.HidrycoLib.Symbols.UCT_Equipamento.E_ATUALIZA_HABILITA_REVERSAOEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.habilitaReversao.HasValue) _values_[0] = ea.habilitaReversao.Value;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_E_ATUALIZA_HABILITA_REVERSAO(System.Boolean habilitaReversao, bool ignore_habilitaReversao)
    {
      object[] _values_ = new object[1];
      if (!ignore_habilitaReversao) _values_[0] = habilitaReversao;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }

  }
}

namespace Hidryco.HidrycoLib.Faceplates.UCT_Equipamento
{
  partial class fpDefault
  {

    private event EventHandler<Hidryco.HidrycoLib.Symbols.UCT_Equipamento.REQEventArgs> REQ_Fired;

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
              REQ_Fired(this, new Hidryco.HidrycoLib.Symbols.UCT_Equipamento.REQEventArgs(channelId, cookie, eventIndex));
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
    public bool FireEvent_E_ATUALIZA_COMANDO_LIGA_MANUAL(System.Boolean cmdLigaManual)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {cmdLigaManual});
    }
    public bool FireEvent_E_ATUALIZA_COMANDO_LIGA_MANUAL(Hidryco.HidrycoLib.Symbols.UCT_Equipamento.E_ATUALIZA_COMANDO_LIGA_MANUALEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.cmdLigaManual.HasValue) _values_[0] = ea.cmdLigaManual.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_E_ATUALIZA_COMANDO_LIGA_MANUAL(System.Boolean cmdLigaManual, bool ignore_cmdLigaManual)
    {
      object[] _values_ = new object[1];
      if (!ignore_cmdLigaManual) _values_[0] = cmdLigaManual;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_E_ATUALIZA_SETPOINT(System.Single stpVelocidade)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {stpVelocidade});
    }
    public bool FireEvent_E_ATUALIZA_SETPOINT(Hidryco.HidrycoLib.Symbols.UCT_Equipamento.E_ATUALIZA_SETPOINTEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.stpVelocidade.HasValue) _values_[0] = ea.stpVelocidade.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_E_ATUALIZA_SETPOINT(System.Single stpVelocidade, bool ignore_stpVelocidade)
    {
      object[] _values_ = new object[1];
      if (!ignore_stpVelocidade) _values_[0] = stpVelocidade;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_E_ATUALIZA_COMANDO_LIGA_INTERMITENTE(System.Boolean cmdLigaIntermitente)
    {
      return ((IHMIAccessorOutput)this).FireEvent(2, new object[] {cmdLigaIntermitente});
    }
    public bool FireEvent_E_ATUALIZA_COMANDO_LIGA_INTERMITENTE(Hidryco.HidrycoLib.Symbols.UCT_Equipamento.E_ATUALIZA_COMANDO_LIGA_INTERMITENTEEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.cmdLigaIntermitente.HasValue) _values_[0] = ea.cmdLigaIntermitente.Value;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_E_ATUALIZA_COMANDO_LIGA_INTERMITENTE(System.Boolean cmdLigaIntermitente, bool ignore_cmdLigaIntermitente)
    {
      object[] _values_ = new object[1];
      if (!ignore_cmdLigaIntermitente) _values_[0] = cmdLigaIntermitente;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_E_ATUALIZA_HABILITA_REVERSAO(System.Boolean habilitaReversao)
    {
      return ((IHMIAccessorOutput)this).FireEvent(3, new object[] {habilitaReversao});
    }
    public bool FireEvent_E_ATUALIZA_HABILITA_REVERSAO(Hidryco.HidrycoLib.Symbols.UCT_Equipamento.E_ATUALIZA_HABILITA_REVERSAOEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.habilitaReversao.HasValue) _values_[0] = ea.habilitaReversao.Value;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_E_ATUALIZA_HABILITA_REVERSAO(System.Boolean habilitaReversao, bool ignore_habilitaReversao)
    {
      object[] _values_ = new object[1];
      if (!ignore_habilitaReversao) _values_[0] = habilitaReversao;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }

  }
}

namespace Hidryco.HidrycoLib.Symbols.UCT_Equipamento
{
  partial class sPeneira
  {

    private event EventHandler<Hidryco.HidrycoLib.Symbols.UCT_Equipamento.REQEventArgs> REQ_Fired;

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
              REQ_Fired(this, new Hidryco.HidrycoLib.Symbols.UCT_Equipamento.REQEventArgs(channelId, cookie, eventIndex));
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
    public bool FireEvent_E_ATUALIZA_COMANDO_LIGA_MANUAL(System.Boolean cmdLigaManual)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {cmdLigaManual});
    }
    public bool FireEvent_E_ATUALIZA_COMANDO_LIGA_MANUAL(Hidryco.HidrycoLib.Symbols.UCT_Equipamento.E_ATUALIZA_COMANDO_LIGA_MANUALEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.cmdLigaManual.HasValue) _values_[0] = ea.cmdLigaManual.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_E_ATUALIZA_COMANDO_LIGA_MANUAL(System.Boolean cmdLigaManual, bool ignore_cmdLigaManual)
    {
      object[] _values_ = new object[1];
      if (!ignore_cmdLigaManual) _values_[0] = cmdLigaManual;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_E_ATUALIZA_SETPOINT(System.Single stpVelocidade)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {stpVelocidade});
    }
    public bool FireEvent_E_ATUALIZA_SETPOINT(Hidryco.HidrycoLib.Symbols.UCT_Equipamento.E_ATUALIZA_SETPOINTEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.stpVelocidade.HasValue) _values_[0] = ea.stpVelocidade.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_E_ATUALIZA_SETPOINT(System.Single stpVelocidade, bool ignore_stpVelocidade)
    {
      object[] _values_ = new object[1];
      if (!ignore_stpVelocidade) _values_[0] = stpVelocidade;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_E_ATUALIZA_COMANDO_LIGA_INTERMITENTE(System.Boolean cmdLigaIntermitente)
    {
      return ((IHMIAccessorOutput)this).FireEvent(2, new object[] {cmdLigaIntermitente});
    }
    public bool FireEvent_E_ATUALIZA_COMANDO_LIGA_INTERMITENTE(Hidryco.HidrycoLib.Symbols.UCT_Equipamento.E_ATUALIZA_COMANDO_LIGA_INTERMITENTEEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.cmdLigaIntermitente.HasValue) _values_[0] = ea.cmdLigaIntermitente.Value;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_E_ATUALIZA_COMANDO_LIGA_INTERMITENTE(System.Boolean cmdLigaIntermitente, bool ignore_cmdLigaIntermitente)
    {
      object[] _values_ = new object[1];
      if (!ignore_cmdLigaIntermitente) _values_[0] = cmdLigaIntermitente;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_E_ATUALIZA_HABILITA_REVERSAO(System.Boolean habilitaReversao)
    {
      return ((IHMIAccessorOutput)this).FireEvent(3, new object[] {habilitaReversao});
    }
    public bool FireEvent_E_ATUALIZA_HABILITA_REVERSAO(Hidryco.HidrycoLib.Symbols.UCT_Equipamento.E_ATUALIZA_HABILITA_REVERSAOEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.habilitaReversao.HasValue) _values_[0] = ea.habilitaReversao.Value;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_E_ATUALIZA_HABILITA_REVERSAO(System.Boolean habilitaReversao, bool ignore_habilitaReversao)
    {
      object[] _values_ = new object[1];
      if (!ignore_habilitaReversao) _values_[0] = habilitaReversao;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }

  }
}

namespace Hidryco.HidrycoLib.Symbols.UCT_Equipamento
{
  partial class sBomba
  {

    private event EventHandler<Hidryco.HidrycoLib.Symbols.UCT_Equipamento.REQEventArgs> REQ_Fired;

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
              REQ_Fired(this, new Hidryco.HidrycoLib.Symbols.UCT_Equipamento.REQEventArgs(channelId, cookie, eventIndex));
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
    public bool FireEvent_E_ATUALIZA_COMANDO_LIGA_MANUAL(System.Boolean cmdLigaManual)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {cmdLigaManual});
    }
    public bool FireEvent_E_ATUALIZA_COMANDO_LIGA_MANUAL(Hidryco.HidrycoLib.Symbols.UCT_Equipamento.E_ATUALIZA_COMANDO_LIGA_MANUALEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.cmdLigaManual.HasValue) _values_[0] = ea.cmdLigaManual.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_E_ATUALIZA_COMANDO_LIGA_MANUAL(System.Boolean cmdLigaManual, bool ignore_cmdLigaManual)
    {
      object[] _values_ = new object[1];
      if (!ignore_cmdLigaManual) _values_[0] = cmdLigaManual;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_E_ATUALIZA_SETPOINT(System.Single stpVelocidade)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {stpVelocidade});
    }
    public bool FireEvent_E_ATUALIZA_SETPOINT(Hidryco.HidrycoLib.Symbols.UCT_Equipamento.E_ATUALIZA_SETPOINTEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.stpVelocidade.HasValue) _values_[0] = ea.stpVelocidade.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_E_ATUALIZA_SETPOINT(System.Single stpVelocidade, bool ignore_stpVelocidade)
    {
      object[] _values_ = new object[1];
      if (!ignore_stpVelocidade) _values_[0] = stpVelocidade;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_E_ATUALIZA_COMANDO_LIGA_INTERMITENTE(System.Boolean cmdLigaIntermitente)
    {
      return ((IHMIAccessorOutput)this).FireEvent(2, new object[] {cmdLigaIntermitente});
    }
    public bool FireEvent_E_ATUALIZA_COMANDO_LIGA_INTERMITENTE(Hidryco.HidrycoLib.Symbols.UCT_Equipamento.E_ATUALIZA_COMANDO_LIGA_INTERMITENTEEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.cmdLigaIntermitente.HasValue) _values_[0] = ea.cmdLigaIntermitente.Value;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_E_ATUALIZA_COMANDO_LIGA_INTERMITENTE(System.Boolean cmdLigaIntermitente, bool ignore_cmdLigaIntermitente)
    {
      object[] _values_ = new object[1];
      if (!ignore_cmdLigaIntermitente) _values_[0] = cmdLigaIntermitente;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_E_ATUALIZA_HABILITA_REVERSAO(System.Boolean habilitaReversao)
    {
      return ((IHMIAccessorOutput)this).FireEvent(3, new object[] {habilitaReversao});
    }
    public bool FireEvent_E_ATUALIZA_HABILITA_REVERSAO(Hidryco.HidrycoLib.Symbols.UCT_Equipamento.E_ATUALIZA_HABILITA_REVERSAOEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.habilitaReversao.HasValue) _values_[0] = ea.habilitaReversao.Value;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_E_ATUALIZA_HABILITA_REVERSAO(System.Boolean habilitaReversao, bool ignore_habilitaReversao)
    {
      object[] _values_ = new object[1];
      if (!ignore_habilitaReversao) _values_[0] = habilitaReversao;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }

  }
}

namespace Hidryco.HidrycoLib.Symbols.UCT_Equipamento
{
  partial class sValvula
  {

    private event EventHandler<Hidryco.HidrycoLib.Symbols.UCT_Equipamento.REQEventArgs> REQ_Fired;

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
              REQ_Fired(this, new Hidryco.HidrycoLib.Symbols.UCT_Equipamento.REQEventArgs(channelId, cookie, eventIndex));
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
    public bool FireEvent_E_ATUALIZA_COMANDO_LIGA_MANUAL(System.Boolean cmdLigaManual)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {cmdLigaManual});
    }
    public bool FireEvent_E_ATUALIZA_COMANDO_LIGA_MANUAL(Hidryco.HidrycoLib.Symbols.UCT_Equipamento.E_ATUALIZA_COMANDO_LIGA_MANUALEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.cmdLigaManual.HasValue) _values_[0] = ea.cmdLigaManual.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_E_ATUALIZA_COMANDO_LIGA_MANUAL(System.Boolean cmdLigaManual, bool ignore_cmdLigaManual)
    {
      object[] _values_ = new object[1];
      if (!ignore_cmdLigaManual) _values_[0] = cmdLigaManual;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_E_ATUALIZA_SETPOINT(System.Single stpVelocidade)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {stpVelocidade});
    }
    public bool FireEvent_E_ATUALIZA_SETPOINT(Hidryco.HidrycoLib.Symbols.UCT_Equipamento.E_ATUALIZA_SETPOINTEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.stpVelocidade.HasValue) _values_[0] = ea.stpVelocidade.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_E_ATUALIZA_SETPOINT(System.Single stpVelocidade, bool ignore_stpVelocidade)
    {
      object[] _values_ = new object[1];
      if (!ignore_stpVelocidade) _values_[0] = stpVelocidade;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_E_ATUALIZA_COMANDO_LIGA_INTERMITENTE(System.Boolean cmdLigaIntermitente)
    {
      return ((IHMIAccessorOutput)this).FireEvent(2, new object[] {cmdLigaIntermitente});
    }
    public bool FireEvent_E_ATUALIZA_COMANDO_LIGA_INTERMITENTE(Hidryco.HidrycoLib.Symbols.UCT_Equipamento.E_ATUALIZA_COMANDO_LIGA_INTERMITENTEEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.cmdLigaIntermitente.HasValue) _values_[0] = ea.cmdLigaIntermitente.Value;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_E_ATUALIZA_COMANDO_LIGA_INTERMITENTE(System.Boolean cmdLigaIntermitente, bool ignore_cmdLigaIntermitente)
    {
      object[] _values_ = new object[1];
      if (!ignore_cmdLigaIntermitente) _values_[0] = cmdLigaIntermitente;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_E_ATUALIZA_HABILITA_REVERSAO(System.Boolean habilitaReversao)
    {
      return ((IHMIAccessorOutput)this).FireEvent(3, new object[] {habilitaReversao});
    }
    public bool FireEvent_E_ATUALIZA_HABILITA_REVERSAO(Hidryco.HidrycoLib.Symbols.UCT_Equipamento.E_ATUALIZA_HABILITA_REVERSAOEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.habilitaReversao.HasValue) _values_[0] = ea.habilitaReversao.Value;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_E_ATUALIZA_HABILITA_REVERSAO(System.Boolean habilitaReversao, bool ignore_habilitaReversao)
    {
      object[] _values_ = new object[1];
      if (!ignore_habilitaReversao) _values_[0] = habilitaReversao;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }

  }
}

namespace Hidryco.HidrycoLib.Symbols.UCT_Equipamento
{
  partial class sRosca
  {

    private event EventHandler<Hidryco.HidrycoLib.Symbols.UCT_Equipamento.REQEventArgs> REQ_Fired;

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
              REQ_Fired(this, new Hidryco.HidrycoLib.Symbols.UCT_Equipamento.REQEventArgs(channelId, cookie, eventIndex));
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
    public bool FireEvent_E_ATUALIZA_COMANDO_LIGA_MANUAL(System.Boolean cmdLigaManual)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {cmdLigaManual});
    }
    public bool FireEvent_E_ATUALIZA_COMANDO_LIGA_MANUAL(Hidryco.HidrycoLib.Symbols.UCT_Equipamento.E_ATUALIZA_COMANDO_LIGA_MANUALEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.cmdLigaManual.HasValue) _values_[0] = ea.cmdLigaManual.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_E_ATUALIZA_COMANDO_LIGA_MANUAL(System.Boolean cmdLigaManual, bool ignore_cmdLigaManual)
    {
      object[] _values_ = new object[1];
      if (!ignore_cmdLigaManual) _values_[0] = cmdLigaManual;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_E_ATUALIZA_SETPOINT(System.Single stpVelocidade)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {stpVelocidade});
    }
    public bool FireEvent_E_ATUALIZA_SETPOINT(Hidryco.HidrycoLib.Symbols.UCT_Equipamento.E_ATUALIZA_SETPOINTEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.stpVelocidade.HasValue) _values_[0] = ea.stpVelocidade.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_E_ATUALIZA_SETPOINT(System.Single stpVelocidade, bool ignore_stpVelocidade)
    {
      object[] _values_ = new object[1];
      if (!ignore_stpVelocidade) _values_[0] = stpVelocidade;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_E_ATUALIZA_COMANDO_LIGA_INTERMITENTE(System.Boolean cmdLigaIntermitente)
    {
      return ((IHMIAccessorOutput)this).FireEvent(2, new object[] {cmdLigaIntermitente});
    }
    public bool FireEvent_E_ATUALIZA_COMANDO_LIGA_INTERMITENTE(Hidryco.HidrycoLib.Symbols.UCT_Equipamento.E_ATUALIZA_COMANDO_LIGA_INTERMITENTEEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.cmdLigaIntermitente.HasValue) _values_[0] = ea.cmdLigaIntermitente.Value;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_E_ATUALIZA_COMANDO_LIGA_INTERMITENTE(System.Boolean cmdLigaIntermitente, bool ignore_cmdLigaIntermitente)
    {
      object[] _values_ = new object[1];
      if (!ignore_cmdLigaIntermitente) _values_[0] = cmdLigaIntermitente;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_E_ATUALIZA_HABILITA_REVERSAO(System.Boolean habilitaReversao)
    {
      return ((IHMIAccessorOutput)this).FireEvent(3, new object[] {habilitaReversao});
    }
    public bool FireEvent_E_ATUALIZA_HABILITA_REVERSAO(Hidryco.HidrycoLib.Symbols.UCT_Equipamento.E_ATUALIZA_HABILITA_REVERSAOEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.habilitaReversao.HasValue) _values_[0] = ea.habilitaReversao.Value;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_E_ATUALIZA_HABILITA_REVERSAO(System.Boolean habilitaReversao, bool ignore_habilitaReversao)
    {
      object[] _values_ = new object[1];
      if (!ignore_habilitaReversao) _values_[0] = habilitaReversao;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }

  }
}

namespace Hidryco.HidrycoLib.Symbols.UCT_Equipamento
{
  partial class sRoscaInclinada
  {

    private event EventHandler<Hidryco.HidrycoLib.Symbols.UCT_Equipamento.REQEventArgs> REQ_Fired;

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
              REQ_Fired(this, new Hidryco.HidrycoLib.Symbols.UCT_Equipamento.REQEventArgs(channelId, cookie, eventIndex));
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
    public bool FireEvent_E_ATUALIZA_COMANDO_LIGA_MANUAL(System.Boolean cmdLigaManual)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {cmdLigaManual});
    }
    public bool FireEvent_E_ATUALIZA_COMANDO_LIGA_MANUAL(Hidryco.HidrycoLib.Symbols.UCT_Equipamento.E_ATUALIZA_COMANDO_LIGA_MANUALEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.cmdLigaManual.HasValue) _values_[0] = ea.cmdLigaManual.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_E_ATUALIZA_COMANDO_LIGA_MANUAL(System.Boolean cmdLigaManual, bool ignore_cmdLigaManual)
    {
      object[] _values_ = new object[1];
      if (!ignore_cmdLigaManual) _values_[0] = cmdLigaManual;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_E_ATUALIZA_SETPOINT(System.Single stpVelocidade)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {stpVelocidade});
    }
    public bool FireEvent_E_ATUALIZA_SETPOINT(Hidryco.HidrycoLib.Symbols.UCT_Equipamento.E_ATUALIZA_SETPOINTEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.stpVelocidade.HasValue) _values_[0] = ea.stpVelocidade.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_E_ATUALIZA_SETPOINT(System.Single stpVelocidade, bool ignore_stpVelocidade)
    {
      object[] _values_ = new object[1];
      if (!ignore_stpVelocidade) _values_[0] = stpVelocidade;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_E_ATUALIZA_COMANDO_LIGA_INTERMITENTE(System.Boolean cmdLigaIntermitente)
    {
      return ((IHMIAccessorOutput)this).FireEvent(2, new object[] {cmdLigaIntermitente});
    }
    public bool FireEvent_E_ATUALIZA_COMANDO_LIGA_INTERMITENTE(Hidryco.HidrycoLib.Symbols.UCT_Equipamento.E_ATUALIZA_COMANDO_LIGA_INTERMITENTEEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.cmdLigaIntermitente.HasValue) _values_[0] = ea.cmdLigaIntermitente.Value;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_E_ATUALIZA_COMANDO_LIGA_INTERMITENTE(System.Boolean cmdLigaIntermitente, bool ignore_cmdLigaIntermitente)
    {
      object[] _values_ = new object[1];
      if (!ignore_cmdLigaIntermitente) _values_[0] = cmdLigaIntermitente;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_E_ATUALIZA_HABILITA_REVERSAO(System.Boolean habilitaReversao)
    {
      return ((IHMIAccessorOutput)this).FireEvent(3, new object[] {habilitaReversao});
    }
    public bool FireEvent_E_ATUALIZA_HABILITA_REVERSAO(Hidryco.HidrycoLib.Symbols.UCT_Equipamento.E_ATUALIZA_HABILITA_REVERSAOEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.habilitaReversao.HasValue) _values_[0] = ea.habilitaReversao.Value;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_E_ATUALIZA_HABILITA_REVERSAO(System.Boolean habilitaReversao, bool ignore_habilitaReversao)
    {
      object[] _values_ = new object[1];
      if (!ignore_habilitaReversao) _values_[0] = habilitaReversao;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }

  }
}

namespace Hidryco.HidrycoLib.Symbols.UCT_Equipamento
{
  partial class sCompressor
  {

    private event EventHandler<Hidryco.HidrycoLib.Symbols.UCT_Equipamento.REQEventArgs> REQ_Fired;

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
              REQ_Fired(this, new Hidryco.HidrycoLib.Symbols.UCT_Equipamento.REQEventArgs(channelId, cookie, eventIndex));
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
    public bool FireEvent_E_ATUALIZA_COMANDO_LIGA_MANUAL(System.Boolean cmdLigaManual)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {cmdLigaManual});
    }
    public bool FireEvent_E_ATUALIZA_COMANDO_LIGA_MANUAL(Hidryco.HidrycoLib.Symbols.UCT_Equipamento.E_ATUALIZA_COMANDO_LIGA_MANUALEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.cmdLigaManual.HasValue) _values_[0] = ea.cmdLigaManual.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_E_ATUALIZA_COMANDO_LIGA_MANUAL(System.Boolean cmdLigaManual, bool ignore_cmdLigaManual)
    {
      object[] _values_ = new object[1];
      if (!ignore_cmdLigaManual) _values_[0] = cmdLigaManual;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_E_ATUALIZA_SETPOINT(System.Single stpVelocidade)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {stpVelocidade});
    }
    public bool FireEvent_E_ATUALIZA_SETPOINT(Hidryco.HidrycoLib.Symbols.UCT_Equipamento.E_ATUALIZA_SETPOINTEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.stpVelocidade.HasValue) _values_[0] = ea.stpVelocidade.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_E_ATUALIZA_SETPOINT(System.Single stpVelocidade, bool ignore_stpVelocidade)
    {
      object[] _values_ = new object[1];
      if (!ignore_stpVelocidade) _values_[0] = stpVelocidade;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_E_ATUALIZA_COMANDO_LIGA_INTERMITENTE(System.Boolean cmdLigaIntermitente)
    {
      return ((IHMIAccessorOutput)this).FireEvent(2, new object[] {cmdLigaIntermitente});
    }
    public bool FireEvent_E_ATUALIZA_COMANDO_LIGA_INTERMITENTE(Hidryco.HidrycoLib.Symbols.UCT_Equipamento.E_ATUALIZA_COMANDO_LIGA_INTERMITENTEEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.cmdLigaIntermitente.HasValue) _values_[0] = ea.cmdLigaIntermitente.Value;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_E_ATUALIZA_COMANDO_LIGA_INTERMITENTE(System.Boolean cmdLigaIntermitente, bool ignore_cmdLigaIntermitente)
    {
      object[] _values_ = new object[1];
      if (!ignore_cmdLigaIntermitente) _values_[0] = cmdLigaIntermitente;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_E_ATUALIZA_HABILITA_REVERSAO(System.Boolean habilitaReversao)
    {
      return ((IHMIAccessorOutput)this).FireEvent(3, new object[] {habilitaReversao});
    }
    public bool FireEvent_E_ATUALIZA_HABILITA_REVERSAO(Hidryco.HidrycoLib.Symbols.UCT_Equipamento.E_ATUALIZA_HABILITA_REVERSAOEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.habilitaReversao.HasValue) _values_[0] = ea.habilitaReversao.Value;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_E_ATUALIZA_HABILITA_REVERSAO(System.Boolean habilitaReversao, bool ignore_habilitaReversao)
    {
      object[] _values_ = new object[1];
      if (!ignore_habilitaReversao) _values_[0] = habilitaReversao;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }

  }
}

namespace Hidryco.HidrycoLib.Symbols.UCT_Equipamento
{
  partial class sRaspador
  {

    private event EventHandler<Hidryco.HidrycoLib.Symbols.UCT_Equipamento.REQEventArgs> REQ_Fired;

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
              REQ_Fired(this, new Hidryco.HidrycoLib.Symbols.UCT_Equipamento.REQEventArgs(channelId, cookie, eventIndex));
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
    public bool FireEvent_E_ATUALIZA_COMANDO_LIGA_MANUAL(System.Boolean cmdLigaManual)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {cmdLigaManual});
    }
    public bool FireEvent_E_ATUALIZA_COMANDO_LIGA_MANUAL(Hidryco.HidrycoLib.Symbols.UCT_Equipamento.E_ATUALIZA_COMANDO_LIGA_MANUALEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.cmdLigaManual.HasValue) _values_[0] = ea.cmdLigaManual.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_E_ATUALIZA_COMANDO_LIGA_MANUAL(System.Boolean cmdLigaManual, bool ignore_cmdLigaManual)
    {
      object[] _values_ = new object[1];
      if (!ignore_cmdLigaManual) _values_[0] = cmdLigaManual;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_E_ATUALIZA_SETPOINT(System.Single stpVelocidade)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {stpVelocidade});
    }
    public bool FireEvent_E_ATUALIZA_SETPOINT(Hidryco.HidrycoLib.Symbols.UCT_Equipamento.E_ATUALIZA_SETPOINTEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.stpVelocidade.HasValue) _values_[0] = ea.stpVelocidade.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_E_ATUALIZA_SETPOINT(System.Single stpVelocidade, bool ignore_stpVelocidade)
    {
      object[] _values_ = new object[1];
      if (!ignore_stpVelocidade) _values_[0] = stpVelocidade;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_E_ATUALIZA_COMANDO_LIGA_INTERMITENTE(System.Boolean cmdLigaIntermitente)
    {
      return ((IHMIAccessorOutput)this).FireEvent(2, new object[] {cmdLigaIntermitente});
    }
    public bool FireEvent_E_ATUALIZA_COMANDO_LIGA_INTERMITENTE(Hidryco.HidrycoLib.Symbols.UCT_Equipamento.E_ATUALIZA_COMANDO_LIGA_INTERMITENTEEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.cmdLigaIntermitente.HasValue) _values_[0] = ea.cmdLigaIntermitente.Value;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_E_ATUALIZA_COMANDO_LIGA_INTERMITENTE(System.Boolean cmdLigaIntermitente, bool ignore_cmdLigaIntermitente)
    {
      object[] _values_ = new object[1];
      if (!ignore_cmdLigaIntermitente) _values_[0] = cmdLigaIntermitente;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_E_ATUALIZA_HABILITA_REVERSAO(System.Boolean habilitaReversao)
    {
      return ((IHMIAccessorOutput)this).FireEvent(3, new object[] {habilitaReversao});
    }
    public bool FireEvent_E_ATUALIZA_HABILITA_REVERSAO(Hidryco.HidrycoLib.Symbols.UCT_Equipamento.E_ATUALIZA_HABILITA_REVERSAOEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.habilitaReversao.HasValue) _values_[0] = ea.habilitaReversao.Value;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_E_ATUALIZA_HABILITA_REVERSAO(System.Boolean habilitaReversao, bool ignore_habilitaReversao)
    {
      object[] _values_ = new object[1];
      if (!ignore_habilitaReversao) _values_[0] = habilitaReversao;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }

  }
}
#endregion #UCT_Equipamento_HMI;

#endregion Definitions;
