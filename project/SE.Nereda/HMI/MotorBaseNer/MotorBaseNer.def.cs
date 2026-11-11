using System;
using NxtControl.GuiFramework;
using NxtControl.Services;


#region Definitions;
#region MotorBaseNer_HMI;

namespace SE.Nereda.Symbols.MotorBaseNer
{
  partial class sDefault
  {

    private SE.Nereda.Faceplates.MotorBaseNer.fpDefault fpDefault
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.MotorBaseNer.fpDefault faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.MotorBaseNer.fpDefault)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.MotorBaseNer.fpDefault));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.MotorBaseNer.fpDefault();

          faceplate.SetConnectionInfo(this.TagName, this.SymbolPath, this.ChannelId, GetType());

          if (hmiManagementService != null)
            hmiManagementService.RegisterHMIFaceplate(faceplate);
        }
        return faceplate;
      }
    }
     
    private SE.Nereda.Faceplates.MotorBaseNer.fpParameter fpParameter
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.MotorBaseNer.fpParameter faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.MotorBaseNer.fpParameter)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.MotorBaseNer.fpParameter));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.MotorBaseNer.fpParameter();

          faceplate.SetConnectionInfo(this.TagName, this.SymbolPath, this.ChannelId, GetType());

          if (hmiManagementService != null)
            hmiManagementService.RegisterHMIFaceplate(faceplate);
        }
        return faceplate;
      }
    }
     
    private SE.Nereda.Faceplates.MotorBaseNer.fpTrend fpTrend
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.MotorBaseNer.fpTrend faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.MotorBaseNer.fpTrend)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.MotorBaseNer.fpTrend));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.MotorBaseNer.fpTrend();

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

namespace SE.Nereda.Faceplates.MotorBaseNer
{
  partial class fpDefault
  {

    private SE.Nereda.Faceplates.MotorBaseNer.fpParameter fpParameter
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.MotorBaseNer.fpParameter faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.MotorBaseNer.fpParameter)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.MotorBaseNer.fpParameter));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.MotorBaseNer.fpParameter();

          faceplate.SetConnectionInfo(this.TagName, this.ConnectionSymbolPath, this.ChannelId, this.ParentType);

          if (hmiManagementService != null)
            hmiManagementService.RegisterHMIFaceplate(faceplate);
        }
        return faceplate;
      }
    }
     
    private SE.Nereda.Faceplates.MotorBaseNer.fpTrend fpTrend
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.MotorBaseNer.fpTrend faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.MotorBaseNer.fpTrend)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.MotorBaseNer.fpTrend));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.MotorBaseNer.fpTrend();

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

namespace SE.Nereda.Faceplates.MotorBaseNer
{
  partial class fpParameter
  {

    private SE.Nereda.Faceplates.MotorBaseNer.fpDefault fpDefault
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.MotorBaseNer.fpDefault faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.MotorBaseNer.fpDefault)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.MotorBaseNer.fpDefault));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.MotorBaseNer.fpDefault();

          faceplate.SetConnectionInfo(this.TagName, this.ConnectionSymbolPath, this.ChannelId, this.ParentType);

          if (hmiManagementService != null)
            hmiManagementService.RegisterHMIFaceplate(faceplate);
        }
        return faceplate;
      }
    }
     
    private SE.Nereda.Faceplates.MotorBaseNer.fpTrend fpTrend
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.MotorBaseNer.fpTrend faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.MotorBaseNer.fpTrend)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.MotorBaseNer.fpTrend));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.MotorBaseNer.fpTrend();

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

namespace SE.Nereda.Symbols.MotorBaseNer
{
  partial class sMotor
  {

    private SE.Nereda.Faceplates.MotorBaseNer.fpDefault fpDefault
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.MotorBaseNer.fpDefault faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.MotorBaseNer.fpDefault)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.MotorBaseNer.fpDefault));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.MotorBaseNer.fpDefault();

          faceplate.SetConnectionInfo(this.TagName, this.SymbolPath, this.ChannelId, GetType());

          if (hmiManagementService != null)
            hmiManagementService.RegisterHMIFaceplate(faceplate);
        }
        return faceplate;
      }
    }
     
    private SE.Nereda.Faceplates.MotorBaseNer.fpParameter fpParameter
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.MotorBaseNer.fpParameter faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.MotorBaseNer.fpParameter)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.MotorBaseNer.fpParameter));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.MotorBaseNer.fpParameter();

          faceplate.SetConnectionInfo(this.TagName, this.SymbolPath, this.ChannelId, GetType());

          if (hmiManagementService != null)
            hmiManagementService.RegisterHMIFaceplate(faceplate);
        }
        return faceplate;
      }
    }
     
    private SE.Nereda.Faceplates.MotorBaseNer.fpTrend fpTrend
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.MotorBaseNer.fpTrend faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.MotorBaseNer.fpTrend)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.MotorBaseNer.fpTrend));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.MotorBaseNer.fpTrend();

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

namespace SE.Nereda.Symbols.MotorBaseNer
{
  partial class sDiagnostico
  {

    private SE.Nereda.Faceplates.MotorBaseNer.fpDefault fpDefault
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.MotorBaseNer.fpDefault faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.MotorBaseNer.fpDefault)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.MotorBaseNer.fpDefault));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.MotorBaseNer.fpDefault();

          faceplate.SetConnectionInfo(this.TagName, this.SymbolPath, this.ChannelId, GetType());

          if (hmiManagementService != null)
            hmiManagementService.RegisterHMIFaceplate(faceplate);
        }
        return faceplate;
      }
    }
     
    private SE.Nereda.Faceplates.MotorBaseNer.fpParameter fpParameter
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.MotorBaseNer.fpParameter faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.MotorBaseNer.fpParameter)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.MotorBaseNer.fpParameter));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.MotorBaseNer.fpParameter();

          faceplate.SetConnectionInfo(this.TagName, this.SymbolPath, this.ChannelId, GetType());

          if (hmiManagementService != null)
            hmiManagementService.RegisterHMIFaceplate(faceplate);
        }
        return faceplate;
      }
    }
     
    private SE.Nereda.Faceplates.MotorBaseNer.fpTrend fpTrend
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.MotorBaseNer.fpTrend faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.MotorBaseNer.fpTrend)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.MotorBaseNer.fpTrend));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.MotorBaseNer.fpTrend();

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

namespace SE.Nereda.Symbols.MotorBaseNer
{
  partial class sPump
  {

    private SE.Nereda.Faceplates.MotorBaseNer.fpDefault fpDefault
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.MotorBaseNer.fpDefault faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.MotorBaseNer.fpDefault)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.MotorBaseNer.fpDefault));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.MotorBaseNer.fpDefault();

          faceplate.SetConnectionInfo(this.TagName, this.SymbolPath, this.ChannelId, GetType());

          if (hmiManagementService != null)
            hmiManagementService.RegisterHMIFaceplate(faceplate);
        }
        return faceplate;
      }
    }
     
    private SE.Nereda.Faceplates.MotorBaseNer.fpParameter fpParameter
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.MotorBaseNer.fpParameter faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.MotorBaseNer.fpParameter)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.MotorBaseNer.fpParameter));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.MotorBaseNer.fpParameter();

          faceplate.SetConnectionInfo(this.TagName, this.SymbolPath, this.ChannelId, GetType());

          if (hmiManagementService != null)
            hmiManagementService.RegisterHMIFaceplate(faceplate);
        }
        return faceplate;
      }
    }
     
    private SE.Nereda.Faceplates.MotorBaseNer.fpTrend fpTrend
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.MotorBaseNer.fpTrend faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.MotorBaseNer.fpTrend)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.MotorBaseNer.fpTrend));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.MotorBaseNer.fpTrend();

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

namespace SE.Nereda.Symbols.MotorBaseNer
{
  partial class sFan
  {

    private SE.Nereda.Faceplates.MotorBaseNer.fpDefault fpDefault
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.MotorBaseNer.fpDefault faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.MotorBaseNer.fpDefault)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.MotorBaseNer.fpDefault));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.MotorBaseNer.fpDefault();

          faceplate.SetConnectionInfo(this.TagName, this.SymbolPath, this.ChannelId, GetType());

          if (hmiManagementService != null)
            hmiManagementService.RegisterHMIFaceplate(faceplate);
        }
        return faceplate;
      }
    }
     
    private SE.Nereda.Faceplates.MotorBaseNer.fpParameter fpParameter
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.MotorBaseNer.fpParameter faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.MotorBaseNer.fpParameter)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.MotorBaseNer.fpParameter));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.MotorBaseNer.fpParameter();

          faceplate.SetConnectionInfo(this.TagName, this.SymbolPath, this.ChannelId, GetType());

          if (hmiManagementService != null)
            hmiManagementService.RegisterHMIFaceplate(faceplate);
        }
        return faceplate;
      }
    }
     
    private SE.Nereda.Faceplates.MotorBaseNer.fpTrend fpTrend
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.MotorBaseNer.fpTrend faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.MotorBaseNer.fpTrend)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.MotorBaseNer.fpTrend));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.MotorBaseNer.fpTrend();

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

namespace SE.Nereda.Symbols.MotorBaseNer
{
  partial class sBlower
  {

    private SE.Nereda.Faceplates.MotorBaseNer.fpDefault fpDefault
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.MotorBaseNer.fpDefault faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.MotorBaseNer.fpDefault)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.MotorBaseNer.fpDefault));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.MotorBaseNer.fpDefault();

          faceplate.SetConnectionInfo(this.TagName, this.SymbolPath, this.ChannelId, GetType());

          if (hmiManagementService != null)
            hmiManagementService.RegisterHMIFaceplate(faceplate);
        }
        return faceplate;
      }
    }
     
    private SE.Nereda.Faceplates.MotorBaseNer.fpParameter fpParameter
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.MotorBaseNer.fpParameter faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.MotorBaseNer.fpParameter)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.MotorBaseNer.fpParameter));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.MotorBaseNer.fpParameter();

          faceplate.SetConnectionInfo(this.TagName, this.SymbolPath, this.ChannelId, GetType());

          if (hmiManagementService != null)
            hmiManagementService.RegisterHMIFaceplate(faceplate);
        }
        return faceplate;
      }
    }
     
    private SE.Nereda.Faceplates.MotorBaseNer.fpTrend fpTrend
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.MotorBaseNer.fpTrend faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.MotorBaseNer.fpTrend)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.MotorBaseNer.fpTrend));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.MotorBaseNer.fpTrend();

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

namespace SE.Nereda.Faceplates.MotorBaseNer
{
  partial class fpTrend
  {

    private SE.Nereda.Faceplates.MotorBaseNer.fpDefault fpDefault
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.MotorBaseNer.fpDefault faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.MotorBaseNer.fpDefault)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.MotorBaseNer.fpDefault));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.MotorBaseNer.fpDefault();

          faceplate.SetConnectionInfo(this.TagName, this.ConnectionSymbolPath, this.ChannelId, this.ParentType);

          if (hmiManagementService != null)
            hmiManagementService.RegisterHMIFaceplate(faceplate);
        }
        return faceplate;
      }
    }
     
    private SE.Nereda.Faceplates.MotorBaseNer.fpParameter fpParameter
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.MotorBaseNer.fpParameter faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.MotorBaseNer.fpParameter)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.MotorBaseNer.fpParameter));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.MotorBaseNer.fpParameter();

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

namespace SE.Nereda.Symbols.MotorBaseNer
{
  partial class sConveyor
  {

    private SE.Nereda.Faceplates.MotorBaseNer.fpDefault fpDefault
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.MotorBaseNer.fpDefault faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.MotorBaseNer.fpDefault)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.MotorBaseNer.fpDefault));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.MotorBaseNer.fpDefault();

          faceplate.SetConnectionInfo(this.TagName, this.SymbolPath, this.ChannelId, GetType());

          if (hmiManagementService != null)
            hmiManagementService.RegisterHMIFaceplate(faceplate);
        }
        return faceplate;
      }
    }
     
    private SE.Nereda.Faceplates.MotorBaseNer.fpParameter fpParameter
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.MotorBaseNer.fpParameter faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.MotorBaseNer.fpParameter)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.MotorBaseNer.fpParameter));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.MotorBaseNer.fpParameter();

          faceplate.SetConnectionInfo(this.TagName, this.SymbolPath, this.ChannelId, GetType());

          if (hmiManagementService != null)
            hmiManagementService.RegisterHMIFaceplate(faceplate);
        }
        return faceplate;
      }
    }
     
    private SE.Nereda.Faceplates.MotorBaseNer.fpTrend fpTrend
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.MotorBaseNer.fpTrend faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.MotorBaseNer.fpTrend)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.MotorBaseNer.fpTrend));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.MotorBaseNer.fpTrend();

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

namespace SE.Nereda.Symbols.MotorBaseNer
{
  partial class sArrows
  {

    private SE.Nereda.Faceplates.MotorBaseNer.fpDefault fpDefault
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.MotorBaseNer.fpDefault faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.MotorBaseNer.fpDefault)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.MotorBaseNer.fpDefault));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.MotorBaseNer.fpDefault();

          faceplate.SetConnectionInfo(this.TagName, this.SymbolPath, this.ChannelId, GetType());

          if (hmiManagementService != null)
            hmiManagementService.RegisterHMIFaceplate(faceplate);
        }
        return faceplate;
      }
    }
     
    private SE.Nereda.Faceplates.MotorBaseNer.fpParameter fpParameter
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.MotorBaseNer.fpParameter faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.MotorBaseNer.fpParameter)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.MotorBaseNer.fpParameter));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.MotorBaseNer.fpParameter();

          faceplate.SetConnectionInfo(this.TagName, this.SymbolPath, this.ChannelId, GetType());

          if (hmiManagementService != null)
            hmiManagementService.RegisterHMIFaceplate(faceplate);
        }
        return faceplate;
      }
    }
     
    private SE.Nereda.Faceplates.MotorBaseNer.fpTrend fpTrend
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.MotorBaseNer.fpTrend faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.MotorBaseNer.fpTrend)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.MotorBaseNer.fpTrend));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.MotorBaseNer.fpTrend();

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

namespace SE.Nereda.Symbols.MotorBaseNer
{
  partial class sInstanceName
  {

    private SE.Nereda.Faceplates.MotorBaseNer.fpDefault fpDefault
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.MotorBaseNer.fpDefault faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.MotorBaseNer.fpDefault)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.MotorBaseNer.fpDefault));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.MotorBaseNer.fpDefault();

          faceplate.SetConnectionInfo(this.TagName, this.SymbolPath, this.ChannelId, GetType());

          if (hmiManagementService != null)
            hmiManagementService.RegisterHMIFaceplate(faceplate);
        }
        return faceplate;
      }
    }
     
    private SE.Nereda.Faceplates.MotorBaseNer.fpParameter fpParameter
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.MotorBaseNer.fpParameter faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.MotorBaseNer.fpParameter)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.MotorBaseNer.fpParameter));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.MotorBaseNer.fpParameter();

          faceplate.SetConnectionInfo(this.TagName, this.SymbolPath, this.ChannelId, GetType());

          if (hmiManagementService != null)
            hmiManagementService.RegisterHMIFaceplate(faceplate);
        }
        return faceplate;
      }
    }
     
    private SE.Nereda.Faceplates.MotorBaseNer.fpTrend fpTrend
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.MotorBaseNer.fpTrend faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.MotorBaseNer.fpTrend)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.MotorBaseNer.fpTrend));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.MotorBaseNer.fpTrend();

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
#endregion MotorBaseNer_HMI;

#endregion Definitions;

