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
#region #Dosagem_Alcalinizante_HMI;

namespace Hidryco.HidrycoLib.Symbols.Dosagem_Alcalinizante
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

}

namespace Hidryco.HidrycoLib.Symbols.Dosagem_Alcalinizante
{

}

#endregion #Dosagem_Alcalinizante_HMI;

#endregion Definitions;
