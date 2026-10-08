/*
 * Criado pelo EcoStruxure Automation Expert.
 * Usuário:  
 * Data: 27/08/2026
 * Tempo: 15:48
 * 
 */
using System;
using NxtControl.GuiFramework;
using NxtControl.Services;

#region Definitions;
#region #SludgeHoldingTank_HMI;

namespace HMI.Main.Symbols.SludgeHoldingTank
{

  public class LEVELEventArgs : System.EventArgs
  {
    IHMIAccessorService accessorService;
    int channelId;
    int cookie; 
    int eventIndex;

    public LEVELEventArgs(int channelId, int cookie, int eventIndex)
    {
      this.accessorService = (IHMIAccessorService)ServiceProvider.GetService(typeof(IHMIAccessorService));
      this.channelId = channelId;
      this.cookie = cookie;
      this.eventIndex = eventIndex;
    }
    public bool Get_LevelPv(ref System.Single value)
    {
      if (accessorService == null)
        return false;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,0, ref var);
      if (ret) value = (System.Single) var;
      return ret;
    }

    public System.Single? LevelPv
    { get {
      if (accessorService == null)
        return null;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,0, ref var);
      if (!ret) return null;
      return (System.Single) var;
    }  }


  }

}

namespace HMI.Main.Symbols.SludgeHoldingTank
{
  partial class sDefault
  {

    private event EventHandler<HMI.Main.Symbols.SludgeHoldingTank.LEVELEventArgs> LEVEL_Fired;

    protected override void OnEndInit()
    {
      if (LEVEL_Fired != null)
        AttachEventInput(0);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (LEVEL_Fired != null)
          {
            try
            {
              LEVEL_Fired(this, new HMI.Main.Symbols.SludgeHoldingTank.LEVELEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","LEVEL_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }

  }
}
#endregion #SludgeHoldingTank_HMI;

#endregion Definitions;
