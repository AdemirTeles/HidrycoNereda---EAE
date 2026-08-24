/*
 * Criado pelo EcoStruxure Automation Expert.
 * Usuário:  
 * Data: 02/03/2026
 * Tempo: 19:51
 * 
 */
using System;
using NxtControl.GuiFramework;
using NxtControl.Services;

#region Definitions;
#region #Bank_HMI;

namespace Hidryco.HidrycoLib.Symbols.Bank
{

  public class E_ATUALIZA_ANIMACAOEventArgs : System.EventArgs
  {
    IHMIAccessorService accessorService;
    int channelId;
    int cookie; 
    int eventIndex;

    public E_ATUALIZA_ANIMACAOEventArgs(int channelId, int cookie, int eventIndex)
    {
      this.accessorService = (IHMIAccessorService)ServiceProvider.GetService(typeof(IHMIAccessorService));
      this.channelId = channelId;
      this.cookie = cookie;
      this.eventIndex = eventIndex;
    }
    public bool Get_stsAnimacao(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,0, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? stsAnimacao
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,0, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }


  }

}

namespace Hidryco.HidrycoLib.Symbols.Bank
{
  partial class sDefault
  {

    private event EventHandler<Hidryco.HidrycoLib.Symbols.Bank.E_ATUALIZA_ANIMACAOEventArgs> E_ATUALIZA_ANIMACAO_Fired;

    protected override void OnEndInit()
    {
      if (E_ATUALIZA_ANIMACAO_Fired != null)
        AttachEventInput(0);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (E_ATUALIZA_ANIMACAO_Fired != null)
          {
            try
            {
              E_ATUALIZA_ANIMACAO_Fired(this, new Hidryco.HidrycoLib.Symbols.Bank.E_ATUALIZA_ANIMACAOEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","E_ATUALIZA_ANIMACAO_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }

  }
}
#endregion #Bank_HMI;

#endregion Definitions;
