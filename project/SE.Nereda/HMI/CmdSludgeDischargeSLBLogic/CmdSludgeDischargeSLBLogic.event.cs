/*
 * Criado pelo EcoStruxure Automation Expert.
 * Usuário:  
 * Data: 22/08/2026
 * Tempo: 14:12
 * 
 */
using System;
using NxtControl.GuiFramework;
using NxtControl.Services;

#region Definitions;
#region #CmdSludgeDischargeSLBLogic_HMI;

namespace SE.Nereda.Symbols.CmdSludgeDischargeSLBLogic
{

  public class GRAPHEventArgs : System.EventArgs
  {
    IHMIAccessorService accessorService;
    int channelId;
    int cookie; 
    int eventIndex;

    public GRAPHEventArgs(int channelId, int cookie, int eventIndex)
    {
      this.accessorService = (IHMIAccessorService)ServiceProvider.GetService(typeof(IHMIAccessorService));
      this.channelId = channelId;
      this.cookie = cookie;
      this.eventIndex = eventIndex;
    }
    public bool Get_Grafcet(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,0, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? Grafcet
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

namespace SE.Nereda.Symbols.CmdSludgeDischargeSLBLogic
{
  partial class sDefault
  {

    private event EventHandler<SE.Nereda.Symbols.CmdSludgeDischargeSLBLogic.GRAPHEventArgs> GRAPH_Fired;

    protected override void OnEndInit()
    {
      if (GRAPH_Fired != null)
        AttachEventInput(0);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (GRAPH_Fired != null)
          {
            try
            {
              GRAPH_Fired(this, new SE.Nereda.Symbols.CmdSludgeDischargeSLBLogic.GRAPHEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","GRAPH_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }

  }
}
#endregion #CmdSludgeDischargeSLBLogic_HMI;

#endregion Definitions;
