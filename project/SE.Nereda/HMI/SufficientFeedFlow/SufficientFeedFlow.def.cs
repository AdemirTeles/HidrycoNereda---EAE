using System;
using NxtControl.GuiFramework;
using NxtControl.Services;


#region Definitions;
#region SufficientFeedFlow_HMI;

namespace SE.Nereda.Symbols.SufficientFeedFlow
{
  partial class sDefault
  {

    private SE.Nereda.Faceplates.SufficientFeedFlow.fpSettings fpSettings
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.SufficientFeedFlow.fpSettings faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.SufficientFeedFlow.fpSettings)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.SufficientFeedFlow.fpSettings));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.SufficientFeedFlow.fpSettings();

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

      if ("fpSettings" == (string)openFaceplate.FaceplateType)
        hmiFaceplate = fpSettings;

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

      if ("fpSettings" == openFaceplate)
        hmiFaceplate = fpSettings;

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
#endregion SufficientFeedFlow_HMI;

#endregion Definitions;

