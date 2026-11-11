using System;
using NxtControl.GuiFramework;
using NxtControl.Services;


#region Definitions;
#region MotorVsBaseNer_HMI;

namespace SE.Nereda.Symbols.MotorVsBaseNer
{
  partial class sDefault
  {

    private SE.Nereda.Faceplates.MotorVsBaseNer.fpDefault fpDefault
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.MotorVsBaseNer.fpDefault faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.MotorVsBaseNer.fpDefault)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.MotorVsBaseNer.fpDefault));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.MotorVsBaseNer.fpDefault();

          faceplate.SetConnectionInfo(this.TagName, this.SymbolPath, this.ChannelId, GetType());

          if (hmiManagementService != null)
            hmiManagementService.RegisterHMIFaceplate(faceplate);
        }
        return faceplate;
      }
    }
     
    private SE.Nereda.Faceplates.MotorVsBaseNer.fpParameter fpParameter
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.MotorVsBaseNer.fpParameter faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.MotorVsBaseNer.fpParameter)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.MotorVsBaseNer.fpParameter));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.MotorVsBaseNer.fpParameter();

          faceplate.SetConnectionInfo(this.TagName, this.SymbolPath, this.ChannelId, GetType());

          if (hmiManagementService != null)
            hmiManagementService.RegisterHMIFaceplate(faceplate);
        }
        return faceplate;
      }
    }
     
    private SE.Nereda.Faceplates.MotorVsBaseNer.fpTrend fpTrend
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.MotorVsBaseNer.fpTrend faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.MotorVsBaseNer.fpTrend)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.MotorVsBaseNer.fpTrend));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.MotorVsBaseNer.fpTrend();

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

namespace SE.Nereda.Faceplates.MotorVsBaseNer
{
  partial class fpDefault
  {

    private SE.Nereda.Faceplates.MotorVsBaseNer.fpParameter fpParameter
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.MotorVsBaseNer.fpParameter faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.MotorVsBaseNer.fpParameter)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.MotorVsBaseNer.fpParameter));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.MotorVsBaseNer.fpParameter();

          faceplate.SetConnectionInfo(this.TagName, this.ConnectionSymbolPath, this.ChannelId, this.ParentType);

          if (hmiManagementService != null)
            hmiManagementService.RegisterHMIFaceplate(faceplate);
        }
        return faceplate;
      }
    }
     
    private SE.Nereda.Faceplates.MotorVsBaseNer.fpTrend fpTrend
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.MotorVsBaseNer.fpTrend faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.MotorVsBaseNer.fpTrend)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.MotorVsBaseNer.fpTrend));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.MotorVsBaseNer.fpTrend();

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

namespace SE.Nereda.Faceplates.MotorVsBaseNer
{
  partial class fpParameter
  {

    private SE.Nereda.Faceplates.MotorVsBaseNer.fpDefault fpDefault
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.MotorVsBaseNer.fpDefault faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.MotorVsBaseNer.fpDefault)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.MotorVsBaseNer.fpDefault));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.MotorVsBaseNer.fpDefault();

          faceplate.SetConnectionInfo(this.TagName, this.ConnectionSymbolPath, this.ChannelId, this.ParentType);

          if (hmiManagementService != null)
            hmiManagementService.RegisterHMIFaceplate(faceplate);
        }
        return faceplate;
      }
    }
     
    private SE.Nereda.Faceplates.MotorVsBaseNer.fpTrend fpTrend
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.MotorVsBaseNer.fpTrend faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.MotorVsBaseNer.fpTrend)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.MotorVsBaseNer.fpTrend));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.MotorVsBaseNer.fpTrend();

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

namespace SE.Nereda.Symbols.MotorVsBaseNer
{
  partial class sMotor
  {

    private SE.Nereda.Faceplates.MotorVsBaseNer.fpDefault fpDefault
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.MotorVsBaseNer.fpDefault faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.MotorVsBaseNer.fpDefault)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.MotorVsBaseNer.fpDefault));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.MotorVsBaseNer.fpDefault();

          faceplate.SetConnectionInfo(this.TagName, this.SymbolPath, this.ChannelId, GetType());

          if (hmiManagementService != null)
            hmiManagementService.RegisterHMIFaceplate(faceplate);
        }
        return faceplate;
      }
    }
     
    private SE.Nereda.Faceplates.MotorVsBaseNer.fpParameter fpParameter
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.MotorVsBaseNer.fpParameter faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.MotorVsBaseNer.fpParameter)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.MotorVsBaseNer.fpParameter));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.MotorVsBaseNer.fpParameter();

          faceplate.SetConnectionInfo(this.TagName, this.SymbolPath, this.ChannelId, GetType());

          if (hmiManagementService != null)
            hmiManagementService.RegisterHMIFaceplate(faceplate);
        }
        return faceplate;
      }
    }
     
    private SE.Nereda.Faceplates.MotorVsBaseNer.fpTrend fpTrend
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.MotorVsBaseNer.fpTrend faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.MotorVsBaseNer.fpTrend)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.MotorVsBaseNer.fpTrend));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.MotorVsBaseNer.fpTrend();

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

namespace SE.Nereda.Symbols.MotorVsBaseNer
{
  partial class sDiagnostico
  {

    private SE.Nereda.Faceplates.MotorVsBaseNer.fpDefault fpDefault
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.MotorVsBaseNer.fpDefault faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.MotorVsBaseNer.fpDefault)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.MotorVsBaseNer.fpDefault));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.MotorVsBaseNer.fpDefault();

          faceplate.SetConnectionInfo(this.TagName, this.SymbolPath, this.ChannelId, GetType());

          if (hmiManagementService != null)
            hmiManagementService.RegisterHMIFaceplate(faceplate);
        }
        return faceplate;
      }
    }
     
    private SE.Nereda.Faceplates.MotorVsBaseNer.fpParameter fpParameter
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.MotorVsBaseNer.fpParameter faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.MotorVsBaseNer.fpParameter)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.MotorVsBaseNer.fpParameter));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.MotorVsBaseNer.fpParameter();

          faceplate.SetConnectionInfo(this.TagName, this.SymbolPath, this.ChannelId, GetType());

          if (hmiManagementService != null)
            hmiManagementService.RegisterHMIFaceplate(faceplate);
        }
        return faceplate;
      }
    }
     
    private SE.Nereda.Faceplates.MotorVsBaseNer.fpTrend fpTrend
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.MotorVsBaseNer.fpTrend faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.MotorVsBaseNer.fpTrend)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.MotorVsBaseNer.fpTrend));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.MotorVsBaseNer.fpTrend();

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

namespace SE.Nereda.Symbols.MotorVsBaseNer
{
  partial class sPump
  {

    private SE.Nereda.Faceplates.MotorVsBaseNer.fpDefault fpDefault
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.MotorVsBaseNer.fpDefault faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.MotorVsBaseNer.fpDefault)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.MotorVsBaseNer.fpDefault));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.MotorVsBaseNer.fpDefault();

          faceplate.SetConnectionInfo(this.TagName, this.SymbolPath, this.ChannelId, GetType());

          if (hmiManagementService != null)
            hmiManagementService.RegisterHMIFaceplate(faceplate);
        }
        return faceplate;
      }
    }
     
    private SE.Nereda.Faceplates.MotorVsBaseNer.fpParameter fpParameter
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.MotorVsBaseNer.fpParameter faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.MotorVsBaseNer.fpParameter)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.MotorVsBaseNer.fpParameter));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.MotorVsBaseNer.fpParameter();

          faceplate.SetConnectionInfo(this.TagName, this.SymbolPath, this.ChannelId, GetType());

          if (hmiManagementService != null)
            hmiManagementService.RegisterHMIFaceplate(faceplate);
        }
        return faceplate;
      }
    }
     
    private SE.Nereda.Faceplates.MotorVsBaseNer.fpTrend fpTrend
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.MotorVsBaseNer.fpTrend faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.MotorVsBaseNer.fpTrend)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.MotorVsBaseNer.fpTrend));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.MotorVsBaseNer.fpTrend();

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

namespace SE.Nereda.Faceplates.MotorVsBaseNer
{
  partial class fpTrend
  {

    private SE.Nereda.Faceplates.MotorVsBaseNer.fpDefault fpDefault
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.MotorVsBaseNer.fpDefault faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.MotorVsBaseNer.fpDefault)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.MotorVsBaseNer.fpDefault));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.MotorVsBaseNer.fpDefault();

          faceplate.SetConnectionInfo(this.TagName, this.ConnectionSymbolPath, this.ChannelId, this.ParentType);

          if (hmiManagementService != null)
            hmiManagementService.RegisterHMIFaceplate(faceplate);
        }
        return faceplate;
      }
    }
     
    private SE.Nereda.Faceplates.MotorVsBaseNer.fpParameter fpParameter
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.MotorVsBaseNer.fpParameter faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.MotorVsBaseNer.fpParameter)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.MotorVsBaseNer.fpParameter));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.MotorVsBaseNer.fpParameter();

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

namespace SE.Nereda.Symbols.MotorVsBaseNer
{
  partial class sArrows
  {

    private SE.Nereda.Faceplates.MotorVsBaseNer.fpDefault fpDefault
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.MotorVsBaseNer.fpDefault faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.MotorVsBaseNer.fpDefault)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.MotorVsBaseNer.fpDefault));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.MotorVsBaseNer.fpDefault();

          faceplate.SetConnectionInfo(this.TagName, this.SymbolPath, this.ChannelId, GetType());

          if (hmiManagementService != null)
            hmiManagementService.RegisterHMIFaceplate(faceplate);
        }
        return faceplate;
      }
    }
     
    private SE.Nereda.Faceplates.MotorVsBaseNer.fpParameter fpParameter
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.MotorVsBaseNer.fpParameter faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.MotorVsBaseNer.fpParameter)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.MotorVsBaseNer.fpParameter));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.MotorVsBaseNer.fpParameter();

          faceplate.SetConnectionInfo(this.TagName, this.SymbolPath, this.ChannelId, GetType());

          if (hmiManagementService != null)
            hmiManagementService.RegisterHMIFaceplate(faceplate);
        }
        return faceplate;
      }
    }
     
    private SE.Nereda.Faceplates.MotorVsBaseNer.fpTrend fpTrend
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.MotorVsBaseNer.fpTrend faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.MotorVsBaseNer.fpTrend)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.MotorVsBaseNer.fpTrend));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.MotorVsBaseNer.fpTrend();

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

namespace SE.Nereda.Symbols.MotorVsBaseNer
{
  partial class sConveyor
  {

    private SE.Nereda.Faceplates.MotorVsBaseNer.fpDefault fpDefault
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.MotorVsBaseNer.fpDefault faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.MotorVsBaseNer.fpDefault)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.MotorVsBaseNer.fpDefault));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.MotorVsBaseNer.fpDefault();

          faceplate.SetConnectionInfo(this.TagName, this.SymbolPath, this.ChannelId, GetType());

          if (hmiManagementService != null)
            hmiManagementService.RegisterHMIFaceplate(faceplate);
        }
        return faceplate;
      }
    }
     
    private SE.Nereda.Faceplates.MotorVsBaseNer.fpParameter fpParameter
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.MotorVsBaseNer.fpParameter faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.MotorVsBaseNer.fpParameter)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.MotorVsBaseNer.fpParameter));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.MotorVsBaseNer.fpParameter();

          faceplate.SetConnectionInfo(this.TagName, this.SymbolPath, this.ChannelId, GetType());

          if (hmiManagementService != null)
            hmiManagementService.RegisterHMIFaceplate(faceplate);
        }
        return faceplate;
      }
    }
     
    private SE.Nereda.Faceplates.MotorVsBaseNer.fpTrend fpTrend
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.MotorVsBaseNer.fpTrend faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.MotorVsBaseNer.fpTrend)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.MotorVsBaseNer.fpTrend));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.MotorVsBaseNer.fpTrend();

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

namespace SE.Nereda.Symbols.MotorVsBaseNer
{
  partial class sInstanceName
  {

    private SE.Nereda.Faceplates.MotorVsBaseNer.fpDefault fpDefault
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.MotorVsBaseNer.fpDefault faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.MotorVsBaseNer.fpDefault)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.MotorVsBaseNer.fpDefault));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.MotorVsBaseNer.fpDefault();

          faceplate.SetConnectionInfo(this.TagName, this.SymbolPath, this.ChannelId, GetType());

          if (hmiManagementService != null)
            hmiManagementService.RegisterHMIFaceplate(faceplate);
        }
        return faceplate;
      }
    }
     
    private SE.Nereda.Faceplates.MotorVsBaseNer.fpParameter fpParameter
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.MotorVsBaseNer.fpParameter faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.MotorVsBaseNer.fpParameter)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.MotorVsBaseNer.fpParameter));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.MotorVsBaseNer.fpParameter();

          faceplate.SetConnectionInfo(this.TagName, this.SymbolPath, this.ChannelId, GetType());

          if (hmiManagementService != null)
            hmiManagementService.RegisterHMIFaceplate(faceplate);
        }
        return faceplate;
      }
    }
     
    private SE.Nereda.Faceplates.MotorVsBaseNer.fpTrend fpTrend
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.MotorVsBaseNer.fpTrend faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.MotorVsBaseNer.fpTrend)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.MotorVsBaseNer.fpTrend));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.MotorVsBaseNer.fpTrend();

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

namespace SE.Nereda.Symbols.MotorVsBaseNer
{
  partial class sFan
  {

    private SE.Nereda.Faceplates.MotorVsBaseNer.fpDefault fpDefault
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.MotorVsBaseNer.fpDefault faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.MotorVsBaseNer.fpDefault)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.MotorVsBaseNer.fpDefault));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.MotorVsBaseNer.fpDefault();

          faceplate.SetConnectionInfo(this.TagName, this.SymbolPath, this.ChannelId, GetType());

          if (hmiManagementService != null)
            hmiManagementService.RegisterHMIFaceplate(faceplate);
        }
        return faceplate;
      }
    }
     
    private SE.Nereda.Faceplates.MotorVsBaseNer.fpParameter fpParameter
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.MotorVsBaseNer.fpParameter faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.MotorVsBaseNer.fpParameter)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.MotorVsBaseNer.fpParameter));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.MotorVsBaseNer.fpParameter();

          faceplate.SetConnectionInfo(this.TagName, this.SymbolPath, this.ChannelId, GetType());

          if (hmiManagementService != null)
            hmiManagementService.RegisterHMIFaceplate(faceplate);
        }
        return faceplate;
      }
    }
     
    private SE.Nereda.Faceplates.MotorVsBaseNer.fpTrend fpTrend
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.MotorVsBaseNer.fpTrend faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.MotorVsBaseNer.fpTrend)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.MotorVsBaseNer.fpTrend));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.MotorVsBaseNer.fpTrend();

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
#endregion MotorVsBaseNer_HMI;

#endregion Definitions;

