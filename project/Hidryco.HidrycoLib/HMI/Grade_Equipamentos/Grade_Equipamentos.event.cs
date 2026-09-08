/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 2/24/2026
 * Time: 10:06 AM
 * 
 */
using System;
using NxtControl.GuiFramework;
using NxtControl.Services;

#region Definitions;
#region #Grade_Equipamentos_HMI;

namespace Hidryco.HidrycoLib.Symbols.Grade_Equipamentos
{

  public class Grade_Mecanica1_INITOEventArgs : System.EventArgs
  {
    IHMIAccessorService accessorService;
    int channelId;
    int cookie; 
    int eventIndex;

    public Grade_Mecanica1_INITOEventArgs(int channelId, int cookie, int eventIndex)
    {
      this.accessorService = (IHMIAccessorService)ServiceProvider.GetService(typeof(IHMIAccessorService));
      this.channelId = channelId;
      this.cookie = cookie;
      this.eventIndex = eventIndex;
    }

  }

}

namespace Hidryco.HidrycoLib.Symbols.Grade_Equipamentos
{
  partial class sDefault
  {

    private event EventHandler<Hidryco.HidrycoLib.Symbols.Grade_Equipamentos.Grade_Mecanica1_INITOEventArgs> Grade_Mecanica1_INITO_Fired;

    protected override void OnEndInit()
    {
      if (Grade_Mecanica1_INITO_Fired != null)
        AttachEventInput(0);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (Grade_Mecanica1_INITO_Fired != null)
          {
            try
            {
              Grade_Mecanica1_INITO_Fired(this, new Hidryco.HidrycoLib.Symbols.Grade_Equipamentos.Grade_Mecanica1_INITOEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","Grade_Mecanica1_INITO_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }

  }
}
#endregion #Grade_Equipamentos_HMI;

#endregion Definitions;
