using System;
using NxtControl.GuiFramework;
using NxtControl.Services;


#region Definitions;
#region NeredaReactor_HMI;

namespace SE.Nereda.Symbols.NeredaReactor
{
  partial class sStatus
  {

    private SE.Nereda.Faceplates.NeredaReactor.fpSettings fpSettings
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.NeredaReactor.fpSettings faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.NeredaReactor.fpSettings)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.NeredaReactor.fpSettings));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.NeredaReactor.fpSettings();

          faceplate.SetConnectionInfo(this.TagName, this.SymbolPath, this.ChannelId, GetType());

          if (hmiManagementService != null)
            hmiManagementService.RegisterHMIFaceplate(faceplate);
        }
        return faceplate;
      }
    }
     
    private SE.Nereda.Faceplates.NeredaReactor.fpPhases fpPhases
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.NeredaReactor.fpPhases faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.NeredaReactor.fpPhases)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.NeredaReactor.fpPhases));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.NeredaReactor.fpPhases();

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

      if ("fpPhases" == (string)openFaceplate.FaceplateType)
        hmiFaceplate = fpPhases;

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

      if ("fpPhases" == openFaceplate)
        hmiFaceplate = fpPhases;

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

namespace SE.Nereda.Symbols.NeredaReactor
{
  partial class sReactor1
  {

    private SE.Nereda.Faceplates.NeredaReactor.fpSettings fpSettings
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.NeredaReactor.fpSettings faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.NeredaReactor.fpSettings)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.NeredaReactor.fpSettings));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.NeredaReactor.fpSettings();

          faceplate.SetConnectionInfo(this.TagName, this.SymbolPath, this.ChannelId, GetType());

          if (hmiManagementService != null)
            hmiManagementService.RegisterHMIFaceplate(faceplate);
        }
        return faceplate;
      }
    }
     
    private SE.Nereda.Faceplates.NeredaReactor.fpPhases fpPhases
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.NeredaReactor.fpPhases faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.NeredaReactor.fpPhases)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.NeredaReactor.fpPhases));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.NeredaReactor.fpPhases();

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

      if ("fpPhases" == (string)openFaceplate.FaceplateType)
        hmiFaceplate = fpPhases;

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

      if ("fpPhases" == openFaceplate)
        hmiFaceplate = fpPhases;

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

namespace SE.Nereda.Symbols.NeredaReactor
{
  partial class sPhases
  {

    private SE.Nereda.Faceplates.NeredaReactor.fpSettings fpSettings
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.NeredaReactor.fpSettings faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.NeredaReactor.fpSettings)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.NeredaReactor.fpSettings));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.NeredaReactor.fpSettings();

          faceplate.SetConnectionInfo(this.TagName, this.SymbolPath, this.ChannelId, GetType());

          if (hmiManagementService != null)
            hmiManagementService.RegisterHMIFaceplate(faceplate);
        }
        return faceplate;
      }
    }
     
    private SE.Nereda.Faceplates.NeredaReactor.fpPhases fpPhases
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.NeredaReactor.fpPhases faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.NeredaReactor.fpPhases)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.NeredaReactor.fpPhases));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.NeredaReactor.fpPhases();

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

      if ("fpPhases" == (string)openFaceplate.FaceplateType)
        hmiFaceplate = fpPhases;

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

      if ("fpPhases" == openFaceplate)
        hmiFaceplate = fpPhases;

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

namespace SE.Nereda.Symbols.NeredaReactor
{
  partial class sReactor2
  {

    private SE.Nereda.Faceplates.NeredaReactor.fpSettings fpSettings
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.NeredaReactor.fpSettings faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.NeredaReactor.fpSettings)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.NeredaReactor.fpSettings));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.NeredaReactor.fpSettings();

          faceplate.SetConnectionInfo(this.TagName, this.SymbolPath, this.ChannelId, GetType());

          if (hmiManagementService != null)
            hmiManagementService.RegisterHMIFaceplate(faceplate);
        }
        return faceplate;
      }
    }
     
    private SE.Nereda.Faceplates.NeredaReactor.fpPhases fpPhases
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.NeredaReactor.fpPhases faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.NeredaReactor.fpPhases)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.NeredaReactor.fpPhases));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.NeredaReactor.fpPhases();

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

      if ("fpPhases" == (string)openFaceplate.FaceplateType)
        hmiFaceplate = fpPhases;

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

      if ("fpPhases" == openFaceplate)
        hmiFaceplate = fpPhases;

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

namespace SE.Nereda.Symbols.NeredaReactor
{
  partial class sSensors
  {

    private SE.Nereda.Faceplates.NeredaReactor.fpSettings fpSettings
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.NeredaReactor.fpSettings faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.NeredaReactor.fpSettings)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.NeredaReactor.fpSettings));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.NeredaReactor.fpSettings();

          faceplate.SetConnectionInfo(this.TagName, this.SymbolPath, this.ChannelId, GetType());

          if (hmiManagementService != null)
            hmiManagementService.RegisterHMIFaceplate(faceplate);
        }
        return faceplate;
      }
    }
     
    private SE.Nereda.Faceplates.NeredaReactor.fpPhases fpPhases
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.NeredaReactor.fpPhases faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.NeredaReactor.fpPhases)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.NeredaReactor.fpPhases));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.NeredaReactor.fpPhases();

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

      if ("fpPhases" == (string)openFaceplate.FaceplateType)
        hmiFaceplate = fpPhases;

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

      if ("fpPhases" == openFaceplate)
        hmiFaceplate = fpPhases;

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

namespace SE.Nereda.Faceplates.NeredaReactor
{
  partial class fpSettings
  {

    private SE.Nereda.Faceplates.NeredaReactor.fpPhases fpPhases
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.NeredaReactor.fpPhases faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.NeredaReactor.fpPhases)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.NeredaReactor.fpPhases));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.NeredaReactor.fpPhases();

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

      if ("fpPhases" == (string)openFaceplate.FaceplateType)
        hmiFaceplate = fpPhases;

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

      if ("fpPhases" == openFaceplate)
        hmiFaceplate = fpPhases;

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

namespace SE.Nereda.Symbols.NeredaReactor
{
  partial class sSettingsBtn
  {

    private SE.Nereda.Faceplates.NeredaReactor.fpSettings fpSettings
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.NeredaReactor.fpSettings faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.NeredaReactor.fpSettings)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.NeredaReactor.fpSettings));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.NeredaReactor.fpSettings();

          faceplate.SetConnectionInfo(this.TagName, this.SymbolPath, this.ChannelId, GetType());

          if (hmiManagementService != null)
            hmiManagementService.RegisterHMIFaceplate(faceplate);
        }
        return faceplate;
      }
    }
     
    private SE.Nereda.Faceplates.NeredaReactor.fpPhases fpPhases
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.NeredaReactor.fpPhases faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.NeredaReactor.fpPhases)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.NeredaReactor.fpPhases));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.NeredaReactor.fpPhases();

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

      if ("fpPhases" == (string)openFaceplate.FaceplateType)
        hmiFaceplate = fpPhases;

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

      if ("fpPhases" == openFaceplate)
        hmiFaceplate = fpPhases;

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

namespace SE.Nereda.Symbols.NeredaReactor
{
  partial class sReactor3
  {

    private SE.Nereda.Faceplates.NeredaReactor.fpSettings fpSettings
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.NeredaReactor.fpSettings faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.NeredaReactor.fpSettings)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.NeredaReactor.fpSettings));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.NeredaReactor.fpSettings();

          faceplate.SetConnectionInfo(this.TagName, this.SymbolPath, this.ChannelId, GetType());

          if (hmiManagementService != null)
            hmiManagementService.RegisterHMIFaceplate(faceplate);
        }
        return faceplate;
      }
    }
     
    private SE.Nereda.Faceplates.NeredaReactor.fpPhases fpPhases
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.NeredaReactor.fpPhases faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.NeredaReactor.fpPhases)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.NeredaReactor.fpPhases));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.NeredaReactor.fpPhases();

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

      if ("fpPhases" == (string)openFaceplate.FaceplateType)
        hmiFaceplate = fpPhases;

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

      if ("fpPhases" == openFaceplate)
        hmiFaceplate = fpPhases;

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

namespace SE.Nereda.Faceplates.NeredaReactor
{
  partial class fpPhases
  {

    private SE.Nereda.Faceplates.NeredaReactor.fpSettings fpSettings
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.NeredaReactor.fpSettings faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.NeredaReactor.fpSettings)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.NeredaReactor.fpSettings));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.NeredaReactor.fpSettings();

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

namespace SE.Nereda.Symbols.NeredaReactor
{
  partial class sReactor4
  {

    private SE.Nereda.Faceplates.NeredaReactor.fpSettings fpSettings
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.NeredaReactor.fpSettings faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.NeredaReactor.fpSettings)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.NeredaReactor.fpSettings));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.NeredaReactor.fpSettings();

          faceplate.SetConnectionInfo(this.TagName, this.SymbolPath, this.ChannelId, GetType());

          if (hmiManagementService != null)
            hmiManagementService.RegisterHMIFaceplate(faceplate);
        }
        return faceplate;
      }
    }
     
    private SE.Nereda.Faceplates.NeredaReactor.fpPhases fpPhases
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.NeredaReactor.fpPhases faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.NeredaReactor.fpPhases)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.NeredaReactor.fpPhases));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.NeredaReactor.fpPhases();

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

      if ("fpPhases" == (string)openFaceplate.FaceplateType)
        hmiFaceplate = fpPhases;

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

      if ("fpPhases" == openFaceplate)
        hmiFaceplate = fpPhases;

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
#endregion NeredaReactor_HMI;

#endregion Definitions;

