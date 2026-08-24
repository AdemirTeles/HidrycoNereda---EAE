using System;
using NxtControl.GuiFramework;
using NxtControl.Services;


#region Definitions;
#region EmergencyReactor_HMI;

namespace SE.Nereda.Symbols.EmergencyReactor
{
  partial class sDefault
  {

    private SE.Nereda.Faceplates.EmergencyReactor.fpSettings fpSettings
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.EmergencyReactor.fpSettings faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.EmergencyReactor.fpSettings)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.EmergencyReactor.fpSettings));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.EmergencyReactor.fpSettings();

          faceplate.SetConnectionInfo(this.TagName, this.SymbolPath, this.ChannelId, GetType());

          if (hmiManagementService != null)
            hmiManagementService.RegisterHMIFaceplate(faceplate);
        }
        return faceplate;
      }
    }
     
    private SE.Nereda.Faceplates.EmergencyReactor.fpCurrAerateTime fpCurrAerateTime
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.EmergencyReactor.fpCurrAerateTime faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.EmergencyReactor.fpCurrAerateTime)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.EmergencyReactor.fpCurrAerateTime));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.EmergencyReactor.fpCurrAerateTime();

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

      if ("fpCurrAerateTime" == (string)openFaceplate.FaceplateType)
        hmiFaceplate = fpCurrAerateTime;

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

      if ("fpCurrAerateTime" == openFaceplate)
        hmiFaceplate = fpCurrAerateTime;

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

namespace SE.Nereda.Faceplates.EmergencyReactor
{
  partial class fpSettings
  {

    private SE.Nereda.Faceplates.EmergencyReactor.fpCurrAerateTime fpCurrAerateTime
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.EmergencyReactor.fpCurrAerateTime faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.EmergencyReactor.fpCurrAerateTime)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.EmergencyReactor.fpCurrAerateTime));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.EmergencyReactor.fpCurrAerateTime();

          faceplate.SetConnectionInfo(this.TagName, this.ConnectionSymbolPath, this.ChannelId, this.ParentType);

          if (hmiManagementService != null)
            hmiManagementService.RegisterHMIFaceplate(faceplate);
        }
        return faceplate;
      }
    }
     
    protected override void DoOpenFaceplate(OpenFaceplate openFaceplate)
    {
      NxtControl.GuiFramework.HMIFaceplate hmiFaceplate = null;

      if ("fpCurrAerateTime" == (string)openFaceplate.FaceplateType)
        hmiFaceplate = fpCurrAerateTime;

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

      if ("fpCurrAerateTime" == openFaceplate)
        hmiFaceplate = fpCurrAerateTime;

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

namespace SE.Nereda.Symbols.EmergencyReactor
{
  partial class sDelayAfterCycle
  {

    private SE.Nereda.Faceplates.EmergencyReactor.fpSettings fpSettings
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.EmergencyReactor.fpSettings faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.EmergencyReactor.fpSettings)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.EmergencyReactor.fpSettings));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.EmergencyReactor.fpSettings();

          faceplate.SetConnectionInfo(this.TagName, this.SymbolPath, this.ChannelId, GetType());

          if (hmiManagementService != null)
            hmiManagementService.RegisterHMIFaceplate(faceplate);
        }
        return faceplate;
      }
    }
     
    private SE.Nereda.Faceplates.EmergencyReactor.fpCurrAerateTime fpCurrAerateTime
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.EmergencyReactor.fpCurrAerateTime faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.EmergencyReactor.fpCurrAerateTime)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.EmergencyReactor.fpCurrAerateTime));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.EmergencyReactor.fpCurrAerateTime();

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

      if ("fpCurrAerateTime" == (string)openFaceplate.FaceplateType)
        hmiFaceplate = fpCurrAerateTime;

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

      if ("fpCurrAerateTime" == openFaceplate)
        hmiFaceplate = fpCurrAerateTime;

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

namespace SE.Nereda.Symbols.EmergencyReactor
{
  partial class sWarning
  {

    private SE.Nereda.Faceplates.EmergencyReactor.fpSettings fpSettings
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.EmergencyReactor.fpSettings faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.EmergencyReactor.fpSettings)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.EmergencyReactor.fpSettings));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.EmergencyReactor.fpSettings();

          faceplate.SetConnectionInfo(this.TagName, this.SymbolPath, this.ChannelId, GetType());

          if (hmiManagementService != null)
            hmiManagementService.RegisterHMIFaceplate(faceplate);
        }
        return faceplate;
      }
    }
     
    private SE.Nereda.Faceplates.EmergencyReactor.fpCurrAerateTime fpCurrAerateTime
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.EmergencyReactor.fpCurrAerateTime faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.EmergencyReactor.fpCurrAerateTime)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.EmergencyReactor.fpCurrAerateTime));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.EmergencyReactor.fpCurrAerateTime();

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

      if ("fpCurrAerateTime" == (string)openFaceplate.FaceplateType)
        hmiFaceplate = fpCurrAerateTime;

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

      if ("fpCurrAerateTime" == openFaceplate)
        hmiFaceplate = fpCurrAerateTime;

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

namespace SE.Nereda.Faceplates.EmergencyReactor
{
  partial class fpCurrAerateTime
  {

    private SE.Nereda.Faceplates.EmergencyReactor.fpSettings fpSettings
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.EmergencyReactor.fpSettings faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.EmergencyReactor.fpSettings)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.EmergencyReactor.fpSettings));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.EmergencyReactor.fpSettings();

          faceplate.SetConnectionInfo(this.TagName, this.ConnectionSymbolPath, this.ChannelId, this.ParentType);

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
#endregion EmergencyReactor_HMI;

#endregion Definitions;

