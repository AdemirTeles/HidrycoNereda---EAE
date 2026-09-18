using System;
using NxtControl.GuiFramework;
using NxtControl.Services;


#region Definitions;
#region ValveBase_HMI;

namespace HMI.Main.Symbols.ValveBase
{
  partial class sDefault
  {

    private HMI.Main.Faceplates.ValveBase.fpDefault fpDefault
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        HMI.Main.Faceplates.ValveBase.fpDefault faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (HMI.Main.Faceplates.ValveBase.fpDefault)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(HMI.Main.Faceplates.ValveBase.fpDefault));
        
        if (faceplate == null)
        {
          faceplate = new HMI.Main.Faceplates.ValveBase.fpDefault();

          faceplate.SetConnectionInfo(this.TagName, this.SymbolPath, this.ChannelId, GetType());

          if (hmiManagementService != null)
            hmiManagementService.RegisterHMIFaceplate(faceplate);
        }
        return faceplate;
      }
    }
     
    private HMI.Main.Faceplates.ValveBase.fpParameter fpParameter
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        HMI.Main.Faceplates.ValveBase.fpParameter faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (HMI.Main.Faceplates.ValveBase.fpParameter)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(HMI.Main.Faceplates.ValveBase.fpParameter));
        
        if (faceplate == null)
        {
          faceplate = new HMI.Main.Faceplates.ValveBase.fpParameter();

          faceplate.SetConnectionInfo(this.TagName, this.SymbolPath, this.ChannelId, GetType());

          if (hmiManagementService != null)
            hmiManagementService.RegisterHMIFaceplate(faceplate);
        }
        return faceplate;
      }
    }
     
    private HMI.Main.Faceplates.ValveBase.fpTrend fpTrend
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        HMI.Main.Faceplates.ValveBase.fpTrend faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (HMI.Main.Faceplates.ValveBase.fpTrend)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(HMI.Main.Faceplates.ValveBase.fpTrend));
        
        if (faceplate == null)
        {
          faceplate = new HMI.Main.Faceplates.ValveBase.fpTrend();

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

namespace HMI.Main.Faceplates.ValveBase
{
  partial class fpDefault
  {

    private HMI.Main.Faceplates.ValveBase.fpParameter fpParameter
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        HMI.Main.Faceplates.ValveBase.fpParameter faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (HMI.Main.Faceplates.ValveBase.fpParameter)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(HMI.Main.Faceplates.ValveBase.fpParameter));
        
        if (faceplate == null)
        {
          faceplate = new HMI.Main.Faceplates.ValveBase.fpParameter();

          faceplate.SetConnectionInfo(this.TagName, this.ConnectionSymbolPath, this.ChannelId, this.ParentType);

          if (hmiManagementService != null)
            hmiManagementService.RegisterHMIFaceplate(faceplate);
        }
        return faceplate;
      }
    }
     
    private HMI.Main.Faceplates.ValveBase.fpTrend fpTrend
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        HMI.Main.Faceplates.ValveBase.fpTrend faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (HMI.Main.Faceplates.ValveBase.fpTrend)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(HMI.Main.Faceplates.ValveBase.fpTrend));
        
        if (faceplate == null)
        {
          faceplate = new HMI.Main.Faceplates.ValveBase.fpTrend();

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

namespace HMI.Main.Faceplates.ValveBase
{
  partial class fpParameter
  {

    private HMI.Main.Faceplates.ValveBase.fpDefault fpDefault
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        HMI.Main.Faceplates.ValveBase.fpDefault faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (HMI.Main.Faceplates.ValveBase.fpDefault)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(HMI.Main.Faceplates.ValveBase.fpDefault));
        
        if (faceplate == null)
        {
          faceplate = new HMI.Main.Faceplates.ValveBase.fpDefault();

          faceplate.SetConnectionInfo(this.TagName, this.ConnectionSymbolPath, this.ChannelId, this.ParentType);

          if (hmiManagementService != null)
            hmiManagementService.RegisterHMIFaceplate(faceplate);
        }
        return faceplate;
      }
    }
     
    private HMI.Main.Faceplates.ValveBase.fpTrend fpTrend
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        HMI.Main.Faceplates.ValveBase.fpTrend faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (HMI.Main.Faceplates.ValveBase.fpTrend)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(HMI.Main.Faceplates.ValveBase.fpTrend));
        
        if (faceplate == null)
        {
          faceplate = new HMI.Main.Faceplates.ValveBase.fpTrend();

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

namespace HMI.Main.Symbols.ValveBase
{
  partial class sLflValve
  {

    private HMI.Main.Faceplates.ValveBase.fpDefault fpDefault
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        HMI.Main.Faceplates.ValveBase.fpDefault faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (HMI.Main.Faceplates.ValveBase.fpDefault)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(HMI.Main.Faceplates.ValveBase.fpDefault));
        
        if (faceplate == null)
        {
          faceplate = new HMI.Main.Faceplates.ValveBase.fpDefault();

          faceplate.SetConnectionInfo(this.TagName, this.SymbolPath, this.ChannelId, GetType());

          if (hmiManagementService != null)
            hmiManagementService.RegisterHMIFaceplate(faceplate);
        }
        return faceplate;
      }
    }
     
    private HMI.Main.Faceplates.ValveBase.fpParameter fpParameter
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        HMI.Main.Faceplates.ValveBase.fpParameter faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (HMI.Main.Faceplates.ValveBase.fpParameter)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(HMI.Main.Faceplates.ValveBase.fpParameter));
        
        if (faceplate == null)
        {
          faceplate = new HMI.Main.Faceplates.ValveBase.fpParameter();

          faceplate.SetConnectionInfo(this.TagName, this.SymbolPath, this.ChannelId, GetType());

          if (hmiManagementService != null)
            hmiManagementService.RegisterHMIFaceplate(faceplate);
        }
        return faceplate;
      }
    }
     
    private HMI.Main.Faceplates.ValveBase.fpTrend fpTrend
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        HMI.Main.Faceplates.ValveBase.fpTrend faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (HMI.Main.Faceplates.ValveBase.fpTrend)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(HMI.Main.Faceplates.ValveBase.fpTrend));
        
        if (faceplate == null)
        {
          faceplate = new HMI.Main.Faceplates.ValveBase.fpTrend();

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

namespace HMI.Main.Faceplates.ValveBase
{
  partial class fpTrend
  {

    private HMI.Main.Faceplates.ValveBase.fpDefault fpDefault
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        HMI.Main.Faceplates.ValveBase.fpDefault faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (HMI.Main.Faceplates.ValveBase.fpDefault)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(HMI.Main.Faceplates.ValveBase.fpDefault));
        
        if (faceplate == null)
        {
          faceplate = new HMI.Main.Faceplates.ValveBase.fpDefault();

          faceplate.SetConnectionInfo(this.TagName, this.ConnectionSymbolPath, this.ChannelId, this.ParentType);

          if (hmiManagementService != null)
            hmiManagementService.RegisterHMIFaceplate(faceplate);
        }
        return faceplate;
      }
    }
     
    private HMI.Main.Faceplates.ValveBase.fpParameter fpParameter
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        HMI.Main.Faceplates.ValveBase.fpParameter faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (HMI.Main.Faceplates.ValveBase.fpParameter)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(HMI.Main.Faceplates.ValveBase.fpParameter));
        
        if (faceplate == null)
        {
          faceplate = new HMI.Main.Faceplates.ValveBase.fpParameter();

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

namespace HMI.Main.Symbols.ValveBase
{
  partial class sLflVert
  {

    private HMI.Main.Faceplates.ValveBase.fpDefault fpDefault
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        HMI.Main.Faceplates.ValveBase.fpDefault faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (HMI.Main.Faceplates.ValveBase.fpDefault)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(HMI.Main.Faceplates.ValveBase.fpDefault));
        
        if (faceplate == null)
        {
          faceplate = new HMI.Main.Faceplates.ValveBase.fpDefault();

          faceplate.SetConnectionInfo(this.TagName, this.SymbolPath, this.ChannelId, GetType());

          if (hmiManagementService != null)
            hmiManagementService.RegisterHMIFaceplate(faceplate);
        }
        return faceplate;
      }
    }
     
    private HMI.Main.Faceplates.ValveBase.fpParameter fpParameter
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        HMI.Main.Faceplates.ValveBase.fpParameter faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (HMI.Main.Faceplates.ValveBase.fpParameter)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(HMI.Main.Faceplates.ValveBase.fpParameter));
        
        if (faceplate == null)
        {
          faceplate = new HMI.Main.Faceplates.ValveBase.fpParameter();

          faceplate.SetConnectionInfo(this.TagName, this.SymbolPath, this.ChannelId, GetType());

          if (hmiManagementService != null)
            hmiManagementService.RegisterHMIFaceplate(faceplate);
        }
        return faceplate;
      }
    }
     
    private HMI.Main.Faceplates.ValveBase.fpTrend fpTrend
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        HMI.Main.Faceplates.ValveBase.fpTrend faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (HMI.Main.Faceplates.ValveBase.fpTrend)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(HMI.Main.Faceplates.ValveBase.fpTrend));
        
        if (faceplate == null)
        {
          faceplate = new HMI.Main.Faceplates.ValveBase.fpTrend();

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

namespace HMI.Main.Symbols.ValveBase
{
  partial class sLflHorz
  {

    private HMI.Main.Faceplates.ValveBase.fpDefault fpDefault
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        HMI.Main.Faceplates.ValveBase.fpDefault faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (HMI.Main.Faceplates.ValveBase.fpDefault)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(HMI.Main.Faceplates.ValveBase.fpDefault));
        
        if (faceplate == null)
        {
          faceplate = new HMI.Main.Faceplates.ValveBase.fpDefault();

          faceplate.SetConnectionInfo(this.TagName, this.SymbolPath, this.ChannelId, GetType());

          if (hmiManagementService != null)
            hmiManagementService.RegisterHMIFaceplate(faceplate);
        }
        return faceplate;
      }
    }
     
    private HMI.Main.Faceplates.ValveBase.fpParameter fpParameter
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        HMI.Main.Faceplates.ValveBase.fpParameter faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (HMI.Main.Faceplates.ValveBase.fpParameter)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(HMI.Main.Faceplates.ValveBase.fpParameter));
        
        if (faceplate == null)
        {
          faceplate = new HMI.Main.Faceplates.ValveBase.fpParameter();

          faceplate.SetConnectionInfo(this.TagName, this.SymbolPath, this.ChannelId, GetType());

          if (hmiManagementService != null)
            hmiManagementService.RegisterHMIFaceplate(faceplate);
        }
        return faceplate;
      }
    }
     
    private HMI.Main.Faceplates.ValveBase.fpTrend fpTrend
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        HMI.Main.Faceplates.ValveBase.fpTrend faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (HMI.Main.Faceplates.ValveBase.fpTrend)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(HMI.Main.Faceplates.ValveBase.fpTrend));
        
        if (faceplate == null)
        {
          faceplate = new HMI.Main.Faceplates.ValveBase.fpTrend();

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

namespace HMI.Main.Symbols.ValveBase
{
  partial class sDamper
  {

    private HMI.Main.Faceplates.ValveBase.fpDefault fpDefault
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        HMI.Main.Faceplates.ValveBase.fpDefault faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (HMI.Main.Faceplates.ValveBase.fpDefault)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(HMI.Main.Faceplates.ValveBase.fpDefault));
        
        if (faceplate == null)
        {
          faceplate = new HMI.Main.Faceplates.ValveBase.fpDefault();

          faceplate.SetConnectionInfo(this.TagName, this.SymbolPath, this.ChannelId, GetType());

          if (hmiManagementService != null)
            hmiManagementService.RegisterHMIFaceplate(faceplate);
        }
        return faceplate;
      }
    }
     
    private HMI.Main.Faceplates.ValveBase.fpParameter fpParameter
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        HMI.Main.Faceplates.ValveBase.fpParameter faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (HMI.Main.Faceplates.ValveBase.fpParameter)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(HMI.Main.Faceplates.ValveBase.fpParameter));
        
        if (faceplate == null)
        {
          faceplate = new HMI.Main.Faceplates.ValveBase.fpParameter();

          faceplate.SetConnectionInfo(this.TagName, this.SymbolPath, this.ChannelId, GetType());

          if (hmiManagementService != null)
            hmiManagementService.RegisterHMIFaceplate(faceplate);
        }
        return faceplate;
      }
    }
     
    private HMI.Main.Faceplates.ValveBase.fpTrend fpTrend
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        HMI.Main.Faceplates.ValveBase.fpTrend faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (HMI.Main.Faceplates.ValveBase.fpTrend)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(HMI.Main.Faceplates.ValveBase.fpTrend));
        
        if (faceplate == null)
        {
          faceplate = new HMI.Main.Faceplates.ValveBase.fpTrend();

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

namespace HMI.Main.Symbols.ValveBase
{
  partial class sDiverter
  {

    private HMI.Main.Faceplates.ValveBase.fpDefault fpDefault
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        HMI.Main.Faceplates.ValveBase.fpDefault faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (HMI.Main.Faceplates.ValveBase.fpDefault)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(HMI.Main.Faceplates.ValveBase.fpDefault));
        
        if (faceplate == null)
        {
          faceplate = new HMI.Main.Faceplates.ValveBase.fpDefault();

          faceplate.SetConnectionInfo(this.TagName, this.SymbolPath, this.ChannelId, GetType());

          if (hmiManagementService != null)
            hmiManagementService.RegisterHMIFaceplate(faceplate);
        }
        return faceplate;
      }
    }
     
    private HMI.Main.Faceplates.ValveBase.fpParameter fpParameter
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        HMI.Main.Faceplates.ValveBase.fpParameter faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (HMI.Main.Faceplates.ValveBase.fpParameter)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(HMI.Main.Faceplates.ValveBase.fpParameter));
        
        if (faceplate == null)
        {
          faceplate = new HMI.Main.Faceplates.ValveBase.fpParameter();

          faceplate.SetConnectionInfo(this.TagName, this.SymbolPath, this.ChannelId, GetType());

          if (hmiManagementService != null)
            hmiManagementService.RegisterHMIFaceplate(faceplate);
        }
        return faceplate;
      }
    }
     
    private HMI.Main.Faceplates.ValveBase.fpTrend fpTrend
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        HMI.Main.Faceplates.ValveBase.fpTrend faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (HMI.Main.Faceplates.ValveBase.fpTrend)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(HMI.Main.Faceplates.ValveBase.fpTrend));
        
        if (faceplate == null)
        {
          faceplate = new HMI.Main.Faceplates.ValveBase.fpTrend();

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

namespace HMI.Main.Symbols.ValveBase
{
  partial class sInstanceName
  {

    private HMI.Main.Faceplates.ValveBase.fpDefault fpDefault
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        HMI.Main.Faceplates.ValveBase.fpDefault faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (HMI.Main.Faceplates.ValveBase.fpDefault)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(HMI.Main.Faceplates.ValveBase.fpDefault));
        
        if (faceplate == null)
        {
          faceplate = new HMI.Main.Faceplates.ValveBase.fpDefault();

          faceplate.SetConnectionInfo(this.TagName, this.SymbolPath, this.ChannelId, GetType());

          if (hmiManagementService != null)
            hmiManagementService.RegisterHMIFaceplate(faceplate);
        }
        return faceplate;
      }
    }
     
    private HMI.Main.Faceplates.ValveBase.fpParameter fpParameter
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        HMI.Main.Faceplates.ValveBase.fpParameter faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (HMI.Main.Faceplates.ValveBase.fpParameter)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(HMI.Main.Faceplates.ValveBase.fpParameter));
        
        if (faceplate == null)
        {
          faceplate = new HMI.Main.Faceplates.ValveBase.fpParameter();

          faceplate.SetConnectionInfo(this.TagName, this.SymbolPath, this.ChannelId, GetType());

          if (hmiManagementService != null)
            hmiManagementService.RegisterHMIFaceplate(faceplate);
        }
        return faceplate;
      }
    }
     
    private HMI.Main.Faceplates.ValveBase.fpTrend fpTrend
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        HMI.Main.Faceplates.ValveBase.fpTrend faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (HMI.Main.Faceplates.ValveBase.fpTrend)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(HMI.Main.Faceplates.ValveBase.fpTrend));
        
        if (faceplate == null)
        {
          faceplate = new HMI.Main.Faceplates.ValveBase.fpTrend();

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
#endregion ValveBase_HMI;

#endregion Definitions;

