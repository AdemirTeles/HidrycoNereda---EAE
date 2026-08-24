using System;
using NxtControl.GuiFramework;
using NxtControl.Services;


#region Definitions;
#region CAerationLogic_HMI;

namespace SE.Nereda.Symbols.CAerationLogic
{
  partial class sGraphBtn
  {

    private SE.Nereda.Faceplates.CAerationLogic.fpSettingsS fpSettingsS
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.CAerationLogic.fpSettingsS faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.CAerationLogic.fpSettingsS)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.CAerationLogic.fpSettingsS));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.CAerationLogic.fpSettingsS();

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

      if ("fpSettingsS" == (string)openFaceplate.FaceplateType)
        hmiFaceplate = fpSettingsS;

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

      if ("fpSettingsS" == openFaceplate)
        hmiFaceplate = fpSettingsS;

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

namespace SE.Nereda.Symbols.CAerationLogic
{
  partial class sSettingsBtn
  {

    private SE.Nereda.Faceplates.CAerationLogic.fpSettingsS fpSettingsS
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.CAerationLogic.fpSettingsS faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.CAerationLogic.fpSettingsS)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.CAerationLogic.fpSettingsS));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.CAerationLogic.fpSettingsS();

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

      if ("fpSettingsS" == (string)openFaceplate.FaceplateType)
        hmiFaceplate = fpSettingsS;

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

      if ("fpSettingsS" == openFaceplate)
        hmiFaceplate = fpSettingsS;

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
#endregion CAerationLogic_HMI;

#endregion Definitions;

