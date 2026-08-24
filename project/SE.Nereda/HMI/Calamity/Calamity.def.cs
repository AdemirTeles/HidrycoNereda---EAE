using System;
using NxtControl.GuiFramework;
using NxtControl.Services;


#region Definitions;
#region Calamity_HMI;

namespace SE.Nereda.Symbols.Calamity
{
  partial class sDefault
  {

    private SE.Nereda.Faceplates.Calamity.fpSettings fpSettings
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.Calamity.fpSettings faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.Calamity.fpSettings)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.Calamity.fpSettings));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.Calamity.fpSettings();

          faceplate.SetConnectionInfo(this.TagName, this.SymbolPath, this.ChannelId, GetType());

          if (hmiManagementService != null)
            hmiManagementService.RegisterHMIFaceplate(faceplate);
        }
        return faceplate;
      }
    }
     
    private SE.Nereda.Faceplates.Calamity.fpHiHiActions fpHiHiActions
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.Calamity.fpHiHiActions faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.Calamity.fpHiHiActions)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.Calamity.fpHiHiActions));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.Calamity.fpHiHiActions();

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

      if ("fpHiHiActions" == (string)openFaceplate.FaceplateType)
        hmiFaceplate = fpHiHiActions;

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

      if ("fpHiHiActions" == openFaceplate)
        hmiFaceplate = fpHiHiActions;

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

namespace SE.Nereda.Symbols.Calamity
{
  partial class sSettings
  {

    private SE.Nereda.Faceplates.Calamity.fpSettings fpSettings
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.Calamity.fpSettings faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.Calamity.fpSettings)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.Calamity.fpSettings));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.Calamity.fpSettings();

          faceplate.SetConnectionInfo(this.TagName, this.SymbolPath, this.ChannelId, GetType());

          if (hmiManagementService != null)
            hmiManagementService.RegisterHMIFaceplate(faceplate);
        }
        return faceplate;
      }
    }
     
    private SE.Nereda.Faceplates.Calamity.fpHiHiActions fpHiHiActions
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.Calamity.fpHiHiActions faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.Calamity.fpHiHiActions)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.Calamity.fpHiHiActions));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.Calamity.fpHiHiActions();

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

      if ("fpHiHiActions" == (string)openFaceplate.FaceplateType)
        hmiFaceplate = fpHiHiActions;

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

      if ("fpHiHiActions" == openFaceplate)
        hmiFaceplate = fpHiHiActions;

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

namespace SE.Nereda.Faceplates.Calamity
{
  partial class fpSettings
  {

    private SE.Nereda.Faceplates.Calamity.fpHiHiActions fpHiHiActions
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.Calamity.fpHiHiActions faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.Calamity.fpHiHiActions)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.Calamity.fpHiHiActions));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.Calamity.fpHiHiActions();

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

      if ("fpHiHiActions" == (string)openFaceplate.FaceplateType)
        hmiFaceplate = fpHiHiActions;

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

      if ("fpHiHiActions" == openFaceplate)
        hmiFaceplate = fpHiHiActions;

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

namespace SE.Nereda.Symbols.Calamity
{
  partial class sDurations
  {

    private SE.Nereda.Faceplates.Calamity.fpSettings fpSettings
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.Calamity.fpSettings faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.Calamity.fpSettings)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.Calamity.fpSettings));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.Calamity.fpSettings();

          faceplate.SetConnectionInfo(this.TagName, this.SymbolPath, this.ChannelId, GetType());

          if (hmiManagementService != null)
            hmiManagementService.RegisterHMIFaceplate(faceplate);
        }
        return faceplate;
      }
    }
     
    private SE.Nereda.Faceplates.Calamity.fpHiHiActions fpHiHiActions
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.Calamity.fpHiHiActions faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.Calamity.fpHiHiActions)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.Calamity.fpHiHiActions));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.Calamity.fpHiHiActions();

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

      if ("fpHiHiActions" == (string)openFaceplate.FaceplateType)
        hmiFaceplate = fpHiHiActions;

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

      if ("fpHiHiActions" == openFaceplate)
        hmiFaceplate = fpHiHiActions;

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

namespace SE.Nereda.Symbols.Calamity
{
  partial class sHiHiLevelCalamity
  {

    private SE.Nereda.Faceplates.Calamity.fpSettings fpSettings
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.Calamity.fpSettings faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.Calamity.fpSettings)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.Calamity.fpSettings));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.Calamity.fpSettings();

          faceplate.SetConnectionInfo(this.TagName, this.SymbolPath, this.ChannelId, GetType());

          if (hmiManagementService != null)
            hmiManagementService.RegisterHMIFaceplate(faceplate);
        }
        return faceplate;
      }
    }
     
    private SE.Nereda.Faceplates.Calamity.fpHiHiActions fpHiHiActions
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.Calamity.fpHiHiActions faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.Calamity.fpHiHiActions)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.Calamity.fpHiHiActions));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.Calamity.fpHiHiActions();

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

      if ("fpHiHiActions" == (string)openFaceplate.FaceplateType)
        hmiFaceplate = fpHiHiActions;

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

      if ("fpHiHiActions" == openFaceplate)
        hmiFaceplate = fpHiHiActions;

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

namespace SE.Nereda.Faceplates.Calamity
{
  partial class fpHiHiActions
  {

    private SE.Nereda.Faceplates.Calamity.fpSettings fpSettings
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.Calamity.fpSettings faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.Calamity.fpSettings)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.Calamity.fpSettings));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.Calamity.fpSettings();

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

namespace SE.Nereda.Symbols.Calamity
{
  partial class sForceClose
  {

    private SE.Nereda.Faceplates.Calamity.fpSettings fpSettings
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.Calamity.fpSettings faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.Calamity.fpSettings)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.Calamity.fpSettings));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.Calamity.fpSettings();

          faceplate.SetConnectionInfo(this.TagName, this.SymbolPath, this.ChannelId, GetType());

          if (hmiManagementService != null)
            hmiManagementService.RegisterHMIFaceplate(faceplate);
        }
        return faceplate;
      }
    }
     
    private SE.Nereda.Faceplates.Calamity.fpHiHiActions fpHiHiActions
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.Calamity.fpHiHiActions faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.Calamity.fpHiHiActions)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.Calamity.fpHiHiActions));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.Calamity.fpHiHiActions();

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

      if ("fpHiHiActions" == (string)openFaceplate.FaceplateType)
        hmiFaceplate = fpHiHiActions;

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

      if ("fpHiHiActions" == openFaceplate)
        hmiFaceplate = fpHiHiActions;

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
#endregion Calamity_HMI;

#endregion Definitions;

