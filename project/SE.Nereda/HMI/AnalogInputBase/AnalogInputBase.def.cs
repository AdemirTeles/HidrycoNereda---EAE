using System;
using NxtControl.GuiFramework;
using NxtControl.Services;


#region Definitions;
#region AnalogInputBase_HMI;

namespace SE.Nereda.Faceplates.AnalogInputBase
{
  partial class fpDefault
  {

    private SE.Nereda.Faceplates.AnalogInputBase.fpParameter fpParameter
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.AnalogInputBase.fpParameter faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.AnalogInputBase.fpParameter)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.AnalogInputBase.fpParameter));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.AnalogInputBase.fpParameter();

          faceplate.SetConnectionInfo(this.TagName, this.ConnectionSymbolPath, this.ChannelId, this.ParentType);

          if (hmiManagementService != null)
            hmiManagementService.RegisterHMIFaceplate(faceplate);
        }
        return faceplate;
      }
    }
     
    private SE.Nereda.Faceplates.AnalogInputBase.fpTrend fpTrend
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.AnalogInputBase.fpTrend faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.AnalogInputBase.fpTrend)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.AnalogInputBase.fpTrend));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.AnalogInputBase.fpTrend();

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

      if ("fpParameter" == (string)openFaceplate.FaceplateType)
        hmiFaceplate = fpParameter;

      if ("fpTrend" == (string)openFaceplate.FaceplateType)
        hmiFaceplate = fpTrend;

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

      if ("fpParameter" == openFaceplate)
        hmiFaceplate = fpParameter;

      if ("fpTrend" == openFaceplate)
        hmiFaceplate = fpTrend;

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

namespace SE.Nereda.Faceplates.AnalogInputBase
{
  partial class fpParameter
  {

    private SE.Nereda.Faceplates.AnalogInputBase.fpDefault fpDefault
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.AnalogInputBase.fpDefault faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.AnalogInputBase.fpDefault)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.AnalogInputBase.fpDefault));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.AnalogInputBase.fpDefault();

          faceplate.SetConnectionInfo(this.TagName, this.ConnectionSymbolPath, this.ChannelId, this.ParentType);

          if (hmiManagementService != null)
            hmiManagementService.RegisterHMIFaceplate(faceplate);
        }
        return faceplate;
      }
    }
     
    private SE.Nereda.Faceplates.AnalogInputBase.fpTrend fpTrend
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.AnalogInputBase.fpTrend faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.AnalogInputBase.fpTrend)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.AnalogInputBase.fpTrend));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.AnalogInputBase.fpTrend();

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

      if ("fpDefault" == (string)openFaceplate.FaceplateType)
        hmiFaceplate = fpDefault;

      if ("fpTrend" == (string)openFaceplate.FaceplateType)
        hmiFaceplate = fpTrend;

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

      if ("fpDefault" == openFaceplate)
        hmiFaceplate = fpDefault;

      if ("fpTrend" == openFaceplate)
        hmiFaceplate = fpTrend;

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

namespace SE.Nereda.Symbols.AnalogInputBase
{
  partial class sDefault
  {

    private SE.Nereda.Faceplates.AnalogInputBase.fpDefault fpDefault
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.AnalogInputBase.fpDefault faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.AnalogInputBase.fpDefault)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.AnalogInputBase.fpDefault));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.AnalogInputBase.fpDefault();

          faceplate.SetConnectionInfo(this.TagName, this.SymbolPath, this.ChannelId, GetType());

          if (hmiManagementService != null)
            hmiManagementService.RegisterHMIFaceplate(faceplate);
        }
        return faceplate;
      }
    }
     
    private SE.Nereda.Faceplates.AnalogInputBase.fpParameter fpParameter
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.AnalogInputBase.fpParameter faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.AnalogInputBase.fpParameter)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.AnalogInputBase.fpParameter));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.AnalogInputBase.fpParameter();

          faceplate.SetConnectionInfo(this.TagName, this.SymbolPath, this.ChannelId, GetType());

          if (hmiManagementService != null)
            hmiManagementService.RegisterHMIFaceplate(faceplate);
        }
        return faceplate;
      }
    }
     
    private SE.Nereda.Faceplates.AnalogInputBase.fpTrend fpTrend
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.AnalogInputBase.fpTrend faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.AnalogInputBase.fpTrend)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.AnalogInputBase.fpTrend));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.AnalogInputBase.fpTrend();

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

      if ("fpDefault" == (string)openFaceplate.FaceplateType)
        hmiFaceplate = fpDefault;

      if ("fpParameter" == (string)openFaceplate.FaceplateType)
        hmiFaceplate = fpParameter;

      if ("fpTrend" == (string)openFaceplate.FaceplateType)
        hmiFaceplate = fpTrend;

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

      if ("fpDefault" == openFaceplate)
        hmiFaceplate = fpDefault;

      if ("fpParameter" == openFaceplate)
        hmiFaceplate = fpParameter;

      if ("fpTrend" == openFaceplate)
        hmiFaceplate = fpTrend;

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

namespace SE.Nereda.Symbols.AnalogInputBase
{
  partial class sVertical
  {

    private SE.Nereda.Faceplates.AnalogInputBase.fpDefault fpDefault
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.AnalogInputBase.fpDefault faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.AnalogInputBase.fpDefault)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.AnalogInputBase.fpDefault));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.AnalogInputBase.fpDefault();

          faceplate.SetConnectionInfo(this.TagName, this.SymbolPath, this.ChannelId, GetType());

          if (hmiManagementService != null)
            hmiManagementService.RegisterHMIFaceplate(faceplate);
        }
        return faceplate;
      }
    }
     
    private SE.Nereda.Faceplates.AnalogInputBase.fpParameter fpParameter
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.AnalogInputBase.fpParameter faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.AnalogInputBase.fpParameter)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.AnalogInputBase.fpParameter));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.AnalogInputBase.fpParameter();

          faceplate.SetConnectionInfo(this.TagName, this.SymbolPath, this.ChannelId, GetType());

          if (hmiManagementService != null)
            hmiManagementService.RegisterHMIFaceplate(faceplate);
        }
        return faceplate;
      }
    }
     
    private SE.Nereda.Faceplates.AnalogInputBase.fpTrend fpTrend
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.AnalogInputBase.fpTrend faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.AnalogInputBase.fpTrend)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.AnalogInputBase.fpTrend));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.AnalogInputBase.fpTrend();

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

      if ("fpDefault" == (string)openFaceplate.FaceplateType)
        hmiFaceplate = fpDefault;

      if ("fpParameter" == (string)openFaceplate.FaceplateType)
        hmiFaceplate = fpParameter;

      if ("fpTrend" == (string)openFaceplate.FaceplateType)
        hmiFaceplate = fpTrend;

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

      if ("fpDefault" == openFaceplate)
        hmiFaceplate = fpDefault;

      if ("fpParameter" == openFaceplate)
        hmiFaceplate = fpParameter;

      if ("fpTrend" == openFaceplate)
        hmiFaceplate = fpTrend;

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

namespace SE.Nereda.Faceplates.AnalogInputBase
{
  partial class fpTrend
  {

    private SE.Nereda.Faceplates.AnalogInputBase.fpDefault fpDefault
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.AnalogInputBase.fpDefault faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.AnalogInputBase.fpDefault)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.AnalogInputBase.fpDefault));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.AnalogInputBase.fpDefault();

          faceplate.SetConnectionInfo(this.TagName, this.ConnectionSymbolPath, this.ChannelId, this.ParentType);

          if (hmiManagementService != null)
            hmiManagementService.RegisterHMIFaceplate(faceplate);
        }
        return faceplate;
      }
    }
     
    private SE.Nereda.Faceplates.AnalogInputBase.fpParameter fpParameter
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.AnalogInputBase.fpParameter faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.AnalogInputBase.fpParameter)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.AnalogInputBase.fpParameter));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.AnalogInputBase.fpParameter();

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

      if ("fpDefault" == (string)openFaceplate.FaceplateType)
        hmiFaceplate = fpDefault;

      if ("fpParameter" == (string)openFaceplate.FaceplateType)
        hmiFaceplate = fpParameter;

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

      if ("fpDefault" == openFaceplate)
        hmiFaceplate = fpDefault;

      if ("fpParameter" == openFaceplate)
        hmiFaceplate = fpParameter;

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

namespace SE.Nereda.Symbols.AnalogInputBase
{
  partial class sDisplayPv
  {

    private SE.Nereda.Faceplates.AnalogInputBase.fpDefault fpDefault
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.AnalogInputBase.fpDefault faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.AnalogInputBase.fpDefault)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.AnalogInputBase.fpDefault));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.AnalogInputBase.fpDefault();

          faceplate.SetConnectionInfo(this.TagName, this.SymbolPath, this.ChannelId, GetType());

          if (hmiManagementService != null)
            hmiManagementService.RegisterHMIFaceplate(faceplate);
        }
        return faceplate;
      }
    }
     
    private SE.Nereda.Faceplates.AnalogInputBase.fpParameter fpParameter
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.AnalogInputBase.fpParameter faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.AnalogInputBase.fpParameter)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.AnalogInputBase.fpParameter));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.AnalogInputBase.fpParameter();

          faceplate.SetConnectionInfo(this.TagName, this.SymbolPath, this.ChannelId, GetType());

          if (hmiManagementService != null)
            hmiManagementService.RegisterHMIFaceplate(faceplate);
        }
        return faceplate;
      }
    }
     
    private SE.Nereda.Faceplates.AnalogInputBase.fpTrend fpTrend
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.AnalogInputBase.fpTrend faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.AnalogInputBase.fpTrend)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.AnalogInputBase.fpTrend));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.AnalogInputBase.fpTrend();

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

      if ("fpDefault" == (string)openFaceplate.FaceplateType)
        hmiFaceplate = fpDefault;

      if ("fpParameter" == (string)openFaceplate.FaceplateType)
        hmiFaceplate = fpParameter;

      if ("fpTrend" == (string)openFaceplate.FaceplateType)
        hmiFaceplate = fpTrend;

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

      if ("fpDefault" == openFaceplate)
        hmiFaceplate = fpDefault;

      if ("fpParameter" == openFaceplate)
        hmiFaceplate = fpParameter;

      if ("fpTrend" == openFaceplate)
        hmiFaceplate = fpTrend;

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

namespace SE.Nereda.Symbols.AnalogInputBase
{
  partial class sInstanceName
  {

    private SE.Nereda.Faceplates.AnalogInputBase.fpDefault fpDefault
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.AnalogInputBase.fpDefault faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.AnalogInputBase.fpDefault)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.AnalogInputBase.fpDefault));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.AnalogInputBase.fpDefault();

          faceplate.SetConnectionInfo(this.TagName, this.SymbolPath, this.ChannelId, GetType());

          if (hmiManagementService != null)
            hmiManagementService.RegisterHMIFaceplate(faceplate);
        }
        return faceplate;
      }
    }
     
    private SE.Nereda.Faceplates.AnalogInputBase.fpParameter fpParameter
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.AnalogInputBase.fpParameter faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.AnalogInputBase.fpParameter)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.AnalogInputBase.fpParameter));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.AnalogInputBase.fpParameter();

          faceplate.SetConnectionInfo(this.TagName, this.SymbolPath, this.ChannelId, GetType());

          if (hmiManagementService != null)
            hmiManagementService.RegisterHMIFaceplate(faceplate);
        }
        return faceplate;
      }
    }
     
    private SE.Nereda.Faceplates.AnalogInputBase.fpTrend fpTrend
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.AnalogInputBase.fpTrend faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.AnalogInputBase.fpTrend)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.AnalogInputBase.fpTrend));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.AnalogInputBase.fpTrend();

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

      if ("fpDefault" == (string)openFaceplate.FaceplateType)
        hmiFaceplate = fpDefault;

      if ("fpParameter" == (string)openFaceplate.FaceplateType)
        hmiFaceplate = fpParameter;

      if ("fpTrend" == (string)openFaceplate.FaceplateType)
        hmiFaceplate = fpTrend;

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

      if ("fpDefault" == openFaceplate)
        hmiFaceplate = fpDefault;

      if ("fpParameter" == openFaceplate)
        hmiFaceplate = fpParameter;

      if ("fpTrend" == openFaceplate)
        hmiFaceplate = fpTrend;

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
#endregion AnalogInputBase_HMI;

#endregion Definitions;

