using System;
using NxtControl.GuiFramework;
using NxtControl.Services;


#region Definitions;
#region InfluentFeedLogic_HMI;

namespace SE.Nereda.Symbols.InfluentFeedLogic
{
  partial class sFeedSettings
  {

    private SE.Nereda.Faceplates.InfluentFeedLogic.fpFeedSettings fpFeedSettings
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.InfluentFeedLogic.fpFeedSettings faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.InfluentFeedLogic.fpFeedSettings)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.InfluentFeedLogic.fpFeedSettings));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.InfluentFeedLogic.fpFeedSettings();

          faceplate.SetConnectionInfo(this.TagName, this.SymbolPath, this.ChannelId, GetType());

          if (hmiManagementService != null)
            hmiManagementService.RegisterHMIFaceplate(faceplate);
        }
        return faceplate;
      }
    }
     
    private SE.Nereda.Faceplates.InfluentFeedLogic.fpDrainSettings fpDrainSettings
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.InfluentFeedLogic.fpDrainSettings faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.InfluentFeedLogic.fpDrainSettings)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.InfluentFeedLogic.fpDrainSettings));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.InfluentFeedLogic.fpDrainSettings();

          faceplate.SetConnectionInfo(this.TagName, this.SymbolPath, this.ChannelId, GetType());

          if (hmiManagementService != null)
            hmiManagementService.RegisterHMIFaceplate(faceplate);
        }
        return faceplate;
      }
    }
     
    private SE.Nereda.Faceplates.InfluentFeedLogic.fpFeedDiagram fpFeedDiagram
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.InfluentFeedLogic.fpFeedDiagram faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.InfluentFeedLogic.fpFeedDiagram)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.InfluentFeedLogic.fpFeedDiagram));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.InfluentFeedLogic.fpFeedDiagram();

          faceplate.SetConnectionInfo(this.TagName, this.SymbolPath, this.ChannelId, GetType());

          if (hmiManagementService != null)
            hmiManagementService.RegisterHMIFaceplate(faceplate);
        }
        return faceplate;
      }
    }
     
    private SE.Nereda.Faceplates.InfluentFeedLogic.fpDrainDiagram fpDrainDiagram
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.InfluentFeedLogic.fpDrainDiagram faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.InfluentFeedLogic.fpDrainDiagram)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.InfluentFeedLogic.fpDrainDiagram));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.InfluentFeedLogic.fpDrainDiagram();

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

      if ("fpFeedSettings" == (string)openFaceplate.FaceplateType)
        hmiFaceplate = fpFeedSettings;

      if ("fpDrainSettings" == (string)openFaceplate.FaceplateType)
        hmiFaceplate = fpDrainSettings;

      if ("fpFeedDiagram" == (string)openFaceplate.FaceplateType)
        hmiFaceplate = fpFeedDiagram;

      if ("fpDrainDiagram" == (string)openFaceplate.FaceplateType)
        hmiFaceplate = fpDrainDiagram;

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

      if ("fpFeedSettings" == openFaceplate)
        hmiFaceplate = fpFeedSettings;

      if ("fpDrainSettings" == openFaceplate)
        hmiFaceplate = fpDrainSettings;

      if ("fpFeedDiagram" == openFaceplate)
        hmiFaceplate = fpFeedDiagram;

      if ("fpDrainDiagram" == openFaceplate)
        hmiFaceplate = fpDrainDiagram;

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

namespace SE.Nereda.Faceplates.InfluentFeedLogic
{
  partial class fpFeedSettings
  {

    private SE.Nereda.Faceplates.InfluentFeedLogic.fpDrainSettings fpDrainSettings
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.InfluentFeedLogic.fpDrainSettings faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.InfluentFeedLogic.fpDrainSettings)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.InfluentFeedLogic.fpDrainSettings));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.InfluentFeedLogic.fpDrainSettings();

          faceplate.SetConnectionInfo(this.TagName, this.ConnectionSymbolPath, this.ChannelId, this.ParentType);

          if (hmiManagementService != null)
            hmiManagementService.RegisterHMIFaceplate(faceplate);
        }
        return faceplate;
      }
    }
     
    private SE.Nereda.Faceplates.InfluentFeedLogic.fpFeedDiagram fpFeedDiagram
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.InfluentFeedLogic.fpFeedDiagram faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.InfluentFeedLogic.fpFeedDiagram)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.InfluentFeedLogic.fpFeedDiagram));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.InfluentFeedLogic.fpFeedDiagram();

          faceplate.SetConnectionInfo(this.TagName, this.ConnectionSymbolPath, this.ChannelId, this.ParentType);

          if (hmiManagementService != null)
            hmiManagementService.RegisterHMIFaceplate(faceplate);
        }
        return faceplate;
      }
    }
     
    private SE.Nereda.Faceplates.InfluentFeedLogic.fpDrainDiagram fpDrainDiagram
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.InfluentFeedLogic.fpDrainDiagram faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.InfluentFeedLogic.fpDrainDiagram)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.InfluentFeedLogic.fpDrainDiagram));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.InfluentFeedLogic.fpDrainDiagram();

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

      if ("fpDrainSettings" == (string)openFaceplate.FaceplateType)
        hmiFaceplate = fpDrainSettings;

      if ("fpFeedDiagram" == (string)openFaceplate.FaceplateType)
        hmiFaceplate = fpFeedDiagram;

      if ("fpDrainDiagram" == (string)openFaceplate.FaceplateType)
        hmiFaceplate = fpDrainDiagram;

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

      if ("fpDrainSettings" == openFaceplate)
        hmiFaceplate = fpDrainSettings;

      if ("fpFeedDiagram" == openFaceplate)
        hmiFaceplate = fpFeedDiagram;

      if ("fpDrainDiagram" == openFaceplate)
        hmiFaceplate = fpDrainDiagram;

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

namespace SE.Nereda.Symbols.InfluentFeedLogic
{
  partial class sDrainSettings
  {

    private SE.Nereda.Faceplates.InfluentFeedLogic.fpFeedSettings fpFeedSettings
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.InfluentFeedLogic.fpFeedSettings faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.InfluentFeedLogic.fpFeedSettings)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.InfluentFeedLogic.fpFeedSettings));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.InfluentFeedLogic.fpFeedSettings();

          faceplate.SetConnectionInfo(this.TagName, this.SymbolPath, this.ChannelId, GetType());

          if (hmiManagementService != null)
            hmiManagementService.RegisterHMIFaceplate(faceplate);
        }
        return faceplate;
      }
    }
     
    private SE.Nereda.Faceplates.InfluentFeedLogic.fpDrainSettings fpDrainSettings
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.InfluentFeedLogic.fpDrainSettings faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.InfluentFeedLogic.fpDrainSettings)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.InfluentFeedLogic.fpDrainSettings));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.InfluentFeedLogic.fpDrainSettings();

          faceplate.SetConnectionInfo(this.TagName, this.SymbolPath, this.ChannelId, GetType());

          if (hmiManagementService != null)
            hmiManagementService.RegisterHMIFaceplate(faceplate);
        }
        return faceplate;
      }
    }
     
    private SE.Nereda.Faceplates.InfluentFeedLogic.fpFeedDiagram fpFeedDiagram
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.InfluentFeedLogic.fpFeedDiagram faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.InfluentFeedLogic.fpFeedDiagram)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.InfluentFeedLogic.fpFeedDiagram));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.InfluentFeedLogic.fpFeedDiagram();

          faceplate.SetConnectionInfo(this.TagName, this.SymbolPath, this.ChannelId, GetType());

          if (hmiManagementService != null)
            hmiManagementService.RegisterHMIFaceplate(faceplate);
        }
        return faceplate;
      }
    }
     
    private SE.Nereda.Faceplates.InfluentFeedLogic.fpDrainDiagram fpDrainDiagram
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.InfluentFeedLogic.fpDrainDiagram faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.InfluentFeedLogic.fpDrainDiagram)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.InfluentFeedLogic.fpDrainDiagram));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.InfluentFeedLogic.fpDrainDiagram();

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

      if ("fpFeedSettings" == (string)openFaceplate.FaceplateType)
        hmiFaceplate = fpFeedSettings;

      if ("fpDrainSettings" == (string)openFaceplate.FaceplateType)
        hmiFaceplate = fpDrainSettings;

      if ("fpFeedDiagram" == (string)openFaceplate.FaceplateType)
        hmiFaceplate = fpFeedDiagram;

      if ("fpDrainDiagram" == (string)openFaceplate.FaceplateType)
        hmiFaceplate = fpDrainDiagram;

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

      if ("fpFeedSettings" == openFaceplate)
        hmiFaceplate = fpFeedSettings;

      if ("fpDrainSettings" == openFaceplate)
        hmiFaceplate = fpDrainSettings;

      if ("fpFeedDiagram" == openFaceplate)
        hmiFaceplate = fpFeedDiagram;

      if ("fpDrainDiagram" == openFaceplate)
        hmiFaceplate = fpDrainDiagram;

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

namespace SE.Nereda.Faceplates.InfluentFeedLogic
{
  partial class fpDrainSettings
  {

    private SE.Nereda.Faceplates.InfluentFeedLogic.fpFeedSettings fpFeedSettings
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.InfluentFeedLogic.fpFeedSettings faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.InfluentFeedLogic.fpFeedSettings)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.InfluentFeedLogic.fpFeedSettings));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.InfluentFeedLogic.fpFeedSettings();

          faceplate.SetConnectionInfo(this.TagName, this.ConnectionSymbolPath, this.ChannelId, this.ParentType);

          if (hmiManagementService != null)
            hmiManagementService.RegisterHMIFaceplate(faceplate);
        }
        return faceplate;
      }
    }
     
    private SE.Nereda.Faceplates.InfluentFeedLogic.fpFeedDiagram fpFeedDiagram
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.InfluentFeedLogic.fpFeedDiagram faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.InfluentFeedLogic.fpFeedDiagram)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.InfluentFeedLogic.fpFeedDiagram));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.InfluentFeedLogic.fpFeedDiagram();

          faceplate.SetConnectionInfo(this.TagName, this.ConnectionSymbolPath, this.ChannelId, this.ParentType);

          if (hmiManagementService != null)
            hmiManagementService.RegisterHMIFaceplate(faceplate);
        }
        return faceplate;
      }
    }
     
    private SE.Nereda.Faceplates.InfluentFeedLogic.fpDrainDiagram fpDrainDiagram
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.InfluentFeedLogic.fpDrainDiagram faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.InfluentFeedLogic.fpDrainDiagram)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.InfluentFeedLogic.fpDrainDiagram));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.InfluentFeedLogic.fpDrainDiagram();

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

      if ("fpFeedSettings" == (string)openFaceplate.FaceplateType)
        hmiFaceplate = fpFeedSettings;

      if ("fpFeedDiagram" == (string)openFaceplate.FaceplateType)
        hmiFaceplate = fpFeedDiagram;

      if ("fpDrainDiagram" == (string)openFaceplate.FaceplateType)
        hmiFaceplate = fpDrainDiagram;

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

      if ("fpFeedSettings" == openFaceplate)
        hmiFaceplate = fpFeedSettings;

      if ("fpFeedDiagram" == openFaceplate)
        hmiFaceplate = fpFeedDiagram;

      if ("fpDrainDiagram" == openFaceplate)
        hmiFaceplate = fpDrainDiagram;

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

namespace SE.Nereda.Faceplates.InfluentFeedLogic
{
  partial class fpFeedDiagram
  {

    private SE.Nereda.Faceplates.InfluentFeedLogic.fpFeedSettings fpFeedSettings
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.InfluentFeedLogic.fpFeedSettings faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.InfluentFeedLogic.fpFeedSettings)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.InfluentFeedLogic.fpFeedSettings));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.InfluentFeedLogic.fpFeedSettings();

          faceplate.SetConnectionInfo(this.TagName, this.ConnectionSymbolPath, this.ChannelId, this.ParentType);

          if (hmiManagementService != null)
            hmiManagementService.RegisterHMIFaceplate(faceplate);
        }
        return faceplate;
      }
    }
     
    private SE.Nereda.Faceplates.InfluentFeedLogic.fpDrainSettings fpDrainSettings
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.InfluentFeedLogic.fpDrainSettings faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.InfluentFeedLogic.fpDrainSettings)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.InfluentFeedLogic.fpDrainSettings));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.InfluentFeedLogic.fpDrainSettings();

          faceplate.SetConnectionInfo(this.TagName, this.ConnectionSymbolPath, this.ChannelId, this.ParentType);

          if (hmiManagementService != null)
            hmiManagementService.RegisterHMIFaceplate(faceplate);
        }
        return faceplate;
      }
    }
     
    private SE.Nereda.Faceplates.InfluentFeedLogic.fpDrainDiagram fpDrainDiagram
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.InfluentFeedLogic.fpDrainDiagram faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.InfluentFeedLogic.fpDrainDiagram)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.InfluentFeedLogic.fpDrainDiagram));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.InfluentFeedLogic.fpDrainDiagram();

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

      if ("fpFeedSettings" == (string)openFaceplate.FaceplateType)
        hmiFaceplate = fpFeedSettings;

      if ("fpDrainSettings" == (string)openFaceplate.FaceplateType)
        hmiFaceplate = fpDrainSettings;

      if ("fpDrainDiagram" == (string)openFaceplate.FaceplateType)
        hmiFaceplate = fpDrainDiagram;

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

      if ("fpFeedSettings" == openFaceplate)
        hmiFaceplate = fpFeedSettings;

      if ("fpDrainSettings" == openFaceplate)
        hmiFaceplate = fpDrainSettings;

      if ("fpDrainDiagram" == openFaceplate)
        hmiFaceplate = fpDrainDiagram;

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

namespace SE.Nereda.Faceplates.InfluentFeedLogic
{
  partial class fpDrainDiagram
  {

    private SE.Nereda.Faceplates.InfluentFeedLogic.fpFeedSettings fpFeedSettings
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.InfluentFeedLogic.fpFeedSettings faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.InfluentFeedLogic.fpFeedSettings)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.InfluentFeedLogic.fpFeedSettings));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.InfluentFeedLogic.fpFeedSettings();

          faceplate.SetConnectionInfo(this.TagName, this.ConnectionSymbolPath, this.ChannelId, this.ParentType);

          if (hmiManagementService != null)
            hmiManagementService.RegisterHMIFaceplate(faceplate);
        }
        return faceplate;
      }
    }
     
    private SE.Nereda.Faceplates.InfluentFeedLogic.fpDrainSettings fpDrainSettings
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.InfluentFeedLogic.fpDrainSettings faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.InfluentFeedLogic.fpDrainSettings)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.InfluentFeedLogic.fpDrainSettings));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.InfluentFeedLogic.fpDrainSettings();

          faceplate.SetConnectionInfo(this.TagName, this.ConnectionSymbolPath, this.ChannelId, this.ParentType);

          if (hmiManagementService != null)
            hmiManagementService.RegisterHMIFaceplate(faceplate);
        }
        return faceplate;
      }
    }
     
    private SE.Nereda.Faceplates.InfluentFeedLogic.fpFeedDiagram fpFeedDiagram
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.InfluentFeedLogic.fpFeedDiagram faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.InfluentFeedLogic.fpFeedDiagram)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.InfluentFeedLogic.fpFeedDiagram));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.InfluentFeedLogic.fpFeedDiagram();

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

      if ("fpFeedSettings" == (string)openFaceplate.FaceplateType)
        hmiFaceplate = fpFeedSettings;

      if ("fpDrainSettings" == (string)openFaceplate.FaceplateType)
        hmiFaceplate = fpDrainSettings;

      if ("fpFeedDiagram" == (string)openFaceplate.FaceplateType)
        hmiFaceplate = fpFeedDiagram;

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

      if ("fpFeedSettings" == openFaceplate)
        hmiFaceplate = fpFeedSettings;

      if ("fpDrainSettings" == openFaceplate)
        hmiFaceplate = fpDrainSettings;

      if ("fpFeedDiagram" == openFaceplate)
        hmiFaceplate = fpFeedDiagram;

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
#endregion InfluentFeedLogic_HMI;

#endregion Definitions;

