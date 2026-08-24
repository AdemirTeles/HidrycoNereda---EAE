using System;
using NxtControl.GuiFramework;
using NxtControl.Services;


#region Definitions;
#region HeartBeat_HMI;

namespace SE.Nereda.Symbols.HeartBeat
{
  partial class sDefault
  {

    private SE.Nereda.Faceplates.HeartBeat.WatchdogConfiguration WatchdogConfiguration
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.HeartBeat.WatchdogConfiguration faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.HeartBeat.WatchdogConfiguration)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.HeartBeat.WatchdogConfiguration));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.HeartBeat.WatchdogConfiguration();

          faceplate.SetConnectionInfo(this.TagName, this.SymbolPath, this.ChannelId, GetType());

          if (hmiManagementService != null)
            hmiManagementService.RegisterHMIFaceplate(faceplate);
        }
        return faceplate;
      }
    }
     
    protected override void DoOpenFaceplate(OpenFaceplate openFaceplate)
    {
      NxtControl.GuiFramework.HMIFaceplate hmiFaceplate = null;

      if ("WatchdogConfiguration" == (string)openFaceplate.FaceplateType)
        hmiFaceplate = WatchdogConfiguration;

      if (hmiFaceplate != null)
      {
        if (hmiFaceplate.Initialized == true)
          hmiFaceplate.Activate();
        else
        {
          OnInitializeFaceplate(hmiFaceplate);
          hmiFaceplate.Show(this);
        }
      }
    }

    public override void DoOpenFaceplate(string openFaceplate)
    {
      NxtControl.GuiFramework.HMIFaceplate hmiFaceplate = null;

      if ("WatchdogConfiguration" == openFaceplate)
        hmiFaceplate = WatchdogConfiguration;

      if (hmiFaceplate != null)
      {
        if (hmiFaceplate.Initialized == true)
          hmiFaceplate.Activate();
        else
        {
          OnInitializeFaceplate(hmiFaceplate);
          hmiFaceplate.Show(this);
        }
      }
    }

  }
}
#endregion HeartBeat_HMI;

#endregion Definitions;

