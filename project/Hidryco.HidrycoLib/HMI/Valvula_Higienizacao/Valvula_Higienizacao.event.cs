/*
 * Criado pelo EcoStruxure Automation Expert.
 * Usuário:  
 * Data: 04/03/2026
 * Tempo: 12:01
 * 
 */
using System;
using NxtControl.GuiFramework;
using NxtControl.Services;

#region Definitions;
#region #Valvula_Higienizacao_HMI;

namespace Hidryco.HidrycoLib.Symbols.Valvula_Higienizacao
{

  public class E_ATUALIZAEventArgs : System.EventArgs
  {
    IHMIAccessorService accessorService;
    int channelId;
    int cookie; 
    int eventIndex;

    public E_ATUALIZAEventArgs(int channelId, int cookie, int eventIndex)
    {
      this.accessorService = (IHMIAccessorService)ServiceProvider.GetService(typeof(IHMIAccessorService));
      this.channelId = channelId;
      this.cookie = cookie;
      this.eventIndex = eventIndex;
    }
    public bool Get_stsDefeito(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,0, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? stsDefeito
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,0, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_stsAnimacao(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,1, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? stsAnimacao
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,1, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }

    public bool Get_stsHorimetroHora(ref System.Int32 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,2, ref var);
      if (ret) value = (System.Int32) var;
      return ret;
    }

    public System.Int32? stsHorimetroHora
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,2, ref var);
      if (!ret) return null;
      return (System.Int32) var;
    }  }

    public bool Get_stsAutomaticoSubsistema(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,3, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? stsAutomaticoSubsistema
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,3, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }


  }

  public class E_ATUALIZA_FEEDBACKEventArgs : System.EventArgs
  {
    IHMIAccessorService accessorService;
    int channelId;
    int cookie; 
    int eventIndex;

    public E_ATUALIZA_FEEDBACKEventArgs(int channelId, int cookie, int eventIndex)
    {
      this.accessorService = (IHMIAccessorService)ServiceProvider.GetService(typeof(IHMIAccessorService));
      this.channelId = channelId;
      this.cookie = cookie;
      this.eventIndex = eventIndex;
    }
    public bool Get_fbkCmdLigaManual(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,0, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? fbkCmdLigaManual
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,0, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }


  }

}

namespace Hidryco.HidrycoLib.Symbols.Valvula_Higienizacao
{

  public class E_ATUALIZA_COMANDOEventArgs : System.EventArgs
  {
    public E_ATUALIZA_COMANDOEventArgs()
    {
    }
    private System.Boolean? cmdLigaManual_field = null;
    public System.Boolean? cmdLigaManual
    {
       get { return cmdLigaManual_field; }
       set { cmdLigaManual_field = value; }
    }

  }

}

namespace Hidryco.HidrycoLib.Symbols.Valvula_Higienizacao
{
  partial class sDefault
  {

    private event EventHandler<Hidryco.HidrycoLib.Symbols.Valvula_Higienizacao.E_ATUALIZAEventArgs> E_ATUALIZA_Fired;

    private event EventHandler<Hidryco.HidrycoLib.Symbols.Valvula_Higienizacao.E_ATUALIZA_FEEDBACKEventArgs> E_ATUALIZA_FEEDBACK_Fired;

    protected override void OnEndInit()
    {
      if (E_ATUALIZA_Fired != null)
        AttachEventInput(0);
      if (E_ATUALIZA_FEEDBACK_Fired != null)
        AttachEventInput(1);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (E_ATUALIZA_Fired != null)
          {
            try
            {
              E_ATUALIZA_Fired(this, new Hidryco.HidrycoLib.Symbols.Valvula_Higienizacao.E_ATUALIZAEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","E_ATUALIZA_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 1:
          if (E_ATUALIZA_FEEDBACK_Fired != null)
          {
            try
            {
              E_ATUALIZA_FEEDBACK_Fired(this, new Hidryco.HidrycoLib.Symbols.Valvula_Higienizacao.E_ATUALIZA_FEEDBACKEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","E_ATUALIZA_FEEDBACK_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_E_ATUALIZA_COMANDO(System.Boolean cmdLigaManual)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {cmdLigaManual});
    }
    public bool FireEvent_E_ATUALIZA_COMANDO(Hidryco.HidrycoLib.Symbols.Valvula_Higienizacao.E_ATUALIZA_COMANDOEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.cmdLigaManual.HasValue) _values_[0] = ea.cmdLigaManual.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_E_ATUALIZA_COMANDO(System.Boolean cmdLigaManual, bool ignore_cmdLigaManual)
    {
      object[] _values_ = new object[1];
      if (!ignore_cmdLigaManual) _values_[0] = cmdLigaManual;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }

  }
}

namespace Hidryco.HidrycoLib.Faceplates.Valvula_Higienizacao
{
  partial class Faceplate1
  {

    private event EventHandler<Hidryco.HidrycoLib.Symbols.Valvula_Higienizacao.E_ATUALIZAEventArgs> E_ATUALIZA_Fired;

    private event EventHandler<Hidryco.HidrycoLib.Symbols.Valvula_Higienizacao.E_ATUALIZA_FEEDBACKEventArgs> E_ATUALIZA_FEEDBACK_Fired;

    protected override void OnEndInit()
    {
      if (E_ATUALIZA_Fired != null)
        AttachEventInput(0);
      if (E_ATUALIZA_FEEDBACK_Fired != null)
        AttachEventInput(1);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (E_ATUALIZA_Fired != null)
          {
            try
            {
              E_ATUALIZA_Fired(this, new Hidryco.HidrycoLib.Symbols.Valvula_Higienizacao.E_ATUALIZAEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","E_ATUALIZA_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 1:
          if (E_ATUALIZA_FEEDBACK_Fired != null)
          {
            try
            {
              E_ATUALIZA_FEEDBACK_Fired(this, new Hidryco.HidrycoLib.Symbols.Valvula_Higienizacao.E_ATUALIZA_FEEDBACKEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","E_ATUALIZA_FEEDBACK_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_E_ATUALIZA_COMANDO(System.Boolean cmdLigaManual)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {cmdLigaManual});
    }
    public bool FireEvent_E_ATUALIZA_COMANDO(Hidryco.HidrycoLib.Symbols.Valvula_Higienizacao.E_ATUALIZA_COMANDOEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.cmdLigaManual.HasValue) _values_[0] = ea.cmdLigaManual.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_E_ATUALIZA_COMANDO(System.Boolean cmdLigaManual, bool ignore_cmdLigaManual)
    {
      object[] _values_ = new object[1];
      if (!ignore_cmdLigaManual) _values_[0] = cmdLigaManual;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }

  }
}
#endregion #Valvula_Higienizacao_HMI;

#endregion Definitions;
