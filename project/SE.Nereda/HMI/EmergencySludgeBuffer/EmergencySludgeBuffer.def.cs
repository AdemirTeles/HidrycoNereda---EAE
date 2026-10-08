using System;
using NxtControl.GuiFramework;
using NxtControl.Services;


#region Definitions;
#region EmergencySludgeBuffer_HMI;

namespace SE.Nereda.Symbols.EmergencySludgeBuffer
{
  partial class Symbol1
  {

    private SE.Nereda.Faceplates.EmergencySludgeBuffer.fpSettings fpSettings
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.EmergencySludgeBuffer.fpSettings faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.EmergencySludgeBuffer.fpSettings)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.EmergencySludgeBuffer.fpSettings));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.EmergencySludgeBuffer.fpSettings();

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
#endregion EmergencySludgeBuffer_HMI;

#endregion Definitions;

