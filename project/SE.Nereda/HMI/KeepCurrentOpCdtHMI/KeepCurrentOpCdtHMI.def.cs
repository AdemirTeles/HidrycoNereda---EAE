using System;
using NxtControl.GuiFramework;
using NxtControl.Services;


#region Definitions;
#region KeepCurrentOpCdtHMI_HMI;

namespace SE.Nereda.Symbols.KeepCurrentOpCdtHMI
{
  partial class sDefault
  {

    private SE.Nereda.Faceplates.KeepCurrentOpCdtHMI.fpSetting fpSetting
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.KeepCurrentOpCdtHMI.fpSetting faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.KeepCurrentOpCdtHMI.fpSetting)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.KeepCurrentOpCdtHMI.fpSetting));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.KeepCurrentOpCdtHMI.fpSetting();

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

      if ("fpSetting" == (string)openFaceplate.FaceplateType)
        hmiFaceplate = fpSetting;

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

      if ("fpSetting" == openFaceplate)
        hmiFaceplate = fpSetting;

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
#endregion KeepCurrentOpCdtHMI_HMI;

#endregion Definitions;

