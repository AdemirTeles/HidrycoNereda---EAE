using System;
using NxtControl.GuiFramework;
using NxtControl.Services;


#region Definitions;
#region PIDBase_HMI;

namespace HMI.Main.Symbols.PIDBase
{
  partial class sBarPvSpOpHoriz
  {

    private HMI.Main.Faceplates.PIDBase.fpDefault fpDefault
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        HMI.Main.Faceplates.PIDBase.fpDefault faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (HMI.Main.Faceplates.PIDBase.fpDefault)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(HMI.Main.Faceplates.PIDBase.fpDefault));
        
        if (faceplate == null)
        {
          faceplate = new HMI.Main.Faceplates.PIDBase.fpDefault();

          faceplate.SetConnectionInfo(this.TagName, this.SymbolPath, this.ChannelId, GetType());

          if (hmiManagementService != null)
            hmiManagementService.RegisterHMIFaceplate(faceplate);
        }
        return faceplate;
      }
    }
     
    private HMI.Main.Faceplates.PIDBase.fpParameter fpParameter
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        HMI.Main.Faceplates.PIDBase.fpParameter faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (HMI.Main.Faceplates.PIDBase.fpParameter)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(HMI.Main.Faceplates.PIDBase.fpParameter));
        
        if (faceplate == null)
        {
          faceplate = new HMI.Main.Faceplates.PIDBase.fpParameter();

          faceplate.SetConnectionInfo(this.TagName, this.SymbolPath, this.ChannelId, GetType());

          if (hmiManagementService != null)
            hmiManagementService.RegisterHMIFaceplate(faceplate);
        }
        return faceplate;
      }
    }
     
    private HMI.Main.Faceplates.PIDBase.fpTrend fpTrend
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        HMI.Main.Faceplates.PIDBase.fpTrend faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (HMI.Main.Faceplates.PIDBase.fpTrend)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(HMI.Main.Faceplates.PIDBase.fpTrend));
        
        if (faceplate == null)
        {
          faceplate = new HMI.Main.Faceplates.PIDBase.fpTrend();

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

namespace HMI.Main.Symbols.PIDBase
{
  partial class sBarPvSpOpVert
  {

    private HMI.Main.Faceplates.PIDBase.fpDefault fpDefault
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        HMI.Main.Faceplates.PIDBase.fpDefault faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (HMI.Main.Faceplates.PIDBase.fpDefault)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(HMI.Main.Faceplates.PIDBase.fpDefault));
        
        if (faceplate == null)
        {
          faceplate = new HMI.Main.Faceplates.PIDBase.fpDefault();

          faceplate.SetConnectionInfo(this.TagName, this.SymbolPath, this.ChannelId, GetType());

          if (hmiManagementService != null)
            hmiManagementService.RegisterHMIFaceplate(faceplate);
        }
        return faceplate;
      }
    }
     
    private HMI.Main.Faceplates.PIDBase.fpParameter fpParameter
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        HMI.Main.Faceplates.PIDBase.fpParameter faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (HMI.Main.Faceplates.PIDBase.fpParameter)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(HMI.Main.Faceplates.PIDBase.fpParameter));
        
        if (faceplate == null)
        {
          faceplate = new HMI.Main.Faceplates.PIDBase.fpParameter();

          faceplate.SetConnectionInfo(this.TagName, this.SymbolPath, this.ChannelId, GetType());

          if (hmiManagementService != null)
            hmiManagementService.RegisterHMIFaceplate(faceplate);
        }
        return faceplate;
      }
    }
     
    private HMI.Main.Faceplates.PIDBase.fpTrend fpTrend
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        HMI.Main.Faceplates.PIDBase.fpTrend faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (HMI.Main.Faceplates.PIDBase.fpTrend)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(HMI.Main.Faceplates.PIDBase.fpTrend));
        
        if (faceplate == null)
        {
          faceplate = new HMI.Main.Faceplates.PIDBase.fpTrend();

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

namespace HMI.Main.Symbols.PIDBase
{
  partial class sDisplayPvSpOp
  {

    private HMI.Main.Faceplates.PIDBase.fpDefault fpDefault
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        HMI.Main.Faceplates.PIDBase.fpDefault faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (HMI.Main.Faceplates.PIDBase.fpDefault)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(HMI.Main.Faceplates.PIDBase.fpDefault));
        
        if (faceplate == null)
        {
          faceplate = new HMI.Main.Faceplates.PIDBase.fpDefault();

          faceplate.SetConnectionInfo(this.TagName, this.SymbolPath, this.ChannelId, GetType());

          if (hmiManagementService != null)
            hmiManagementService.RegisterHMIFaceplate(faceplate);
        }
        return faceplate;
      }
    }
     
    private HMI.Main.Faceplates.PIDBase.fpParameter fpParameter
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        HMI.Main.Faceplates.PIDBase.fpParameter faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (HMI.Main.Faceplates.PIDBase.fpParameter)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(HMI.Main.Faceplates.PIDBase.fpParameter));
        
        if (faceplate == null)
        {
          faceplate = new HMI.Main.Faceplates.PIDBase.fpParameter();

          faceplate.SetConnectionInfo(this.TagName, this.SymbolPath, this.ChannelId, GetType());

          if (hmiManagementService != null)
            hmiManagementService.RegisterHMIFaceplate(faceplate);
        }
        return faceplate;
      }
    }
     
    private HMI.Main.Faceplates.PIDBase.fpTrend fpTrend
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        HMI.Main.Faceplates.PIDBase.fpTrend faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (HMI.Main.Faceplates.PIDBase.fpTrend)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(HMI.Main.Faceplates.PIDBase.fpTrend));
        
        if (faceplate == null)
        {
          faceplate = new HMI.Main.Faceplates.PIDBase.fpTrend();

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

namespace HMI.Main.Faceplates.PIDBase
{
  partial class fpDefault
  {

    private HMI.Main.Faceplates.PIDBase.fpParameter fpParameter
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        HMI.Main.Faceplates.PIDBase.fpParameter faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (HMI.Main.Faceplates.PIDBase.fpParameter)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(HMI.Main.Faceplates.PIDBase.fpParameter));
        
        if (faceplate == null)
        {
          faceplate = new HMI.Main.Faceplates.PIDBase.fpParameter();

          faceplate.SetConnectionInfo(this.TagName, this.ConnectionSymbolPath, this.ChannelId, this.ParentType);

          if (hmiManagementService != null)
            hmiManagementService.RegisterHMIFaceplate(faceplate);
        }
        return faceplate;
      }
    }
     
    private HMI.Main.Faceplates.PIDBase.fpTrend fpTrend
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        HMI.Main.Faceplates.PIDBase.fpTrend faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (HMI.Main.Faceplates.PIDBase.fpTrend)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(HMI.Main.Faceplates.PIDBase.fpTrend));
        
        if (faceplate == null)
        {
          faceplate = new HMI.Main.Faceplates.PIDBase.fpTrend();

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

namespace HMI.Main.Faceplates.PIDBase
{
  partial class fpParameter
  {

    private HMI.Main.Faceplates.PIDBase.fpDefault fpDefault
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        HMI.Main.Faceplates.PIDBase.fpDefault faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (HMI.Main.Faceplates.PIDBase.fpDefault)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(HMI.Main.Faceplates.PIDBase.fpDefault));
        
        if (faceplate == null)
        {
          faceplate = new HMI.Main.Faceplates.PIDBase.fpDefault();

          faceplate.SetConnectionInfo(this.TagName, this.ConnectionSymbolPath, this.ChannelId, this.ParentType);

          if (hmiManagementService != null)
            hmiManagementService.RegisterHMIFaceplate(faceplate);
        }
        return faceplate;
      }
    }
     
    private HMI.Main.Faceplates.PIDBase.fpTrend fpTrend
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        HMI.Main.Faceplates.PIDBase.fpTrend faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (HMI.Main.Faceplates.PIDBase.fpTrend)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(HMI.Main.Faceplates.PIDBase.fpTrend));
        
        if (faceplate == null)
        {
          faceplate = new HMI.Main.Faceplates.PIDBase.fpTrend();

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

namespace HMI.Main.Faceplates.PIDBase
{
  partial class fpTrend
  {

    private HMI.Main.Faceplates.PIDBase.fpDefault fpDefault
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        HMI.Main.Faceplates.PIDBase.fpDefault faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (HMI.Main.Faceplates.PIDBase.fpDefault)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(HMI.Main.Faceplates.PIDBase.fpDefault));
        
        if (faceplate == null)
        {
          faceplate = new HMI.Main.Faceplates.PIDBase.fpDefault();

          faceplate.SetConnectionInfo(this.TagName, this.ConnectionSymbolPath, this.ChannelId, this.ParentType);

          if (hmiManagementService != null)
            hmiManagementService.RegisterHMIFaceplate(faceplate);
        }
        return faceplate;
      }
    }
     
    private HMI.Main.Faceplates.PIDBase.fpParameter fpParameter
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        HMI.Main.Faceplates.PIDBase.fpParameter faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (HMI.Main.Faceplates.PIDBase.fpParameter)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(HMI.Main.Faceplates.PIDBase.fpParameter));
        
        if (faceplate == null)
        {
          faceplate = new HMI.Main.Faceplates.PIDBase.fpParameter();

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

namespace HMI.Main.Symbols.PIDBase
{
  partial class sInstanceName
  {

    private HMI.Main.Faceplates.PIDBase.fpDefault fpDefault
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        HMI.Main.Faceplates.PIDBase.fpDefault faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (HMI.Main.Faceplates.PIDBase.fpDefault)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(HMI.Main.Faceplates.PIDBase.fpDefault));
        
        if (faceplate == null)
        {
          faceplate = new HMI.Main.Faceplates.PIDBase.fpDefault();

          faceplate.SetConnectionInfo(this.TagName, this.SymbolPath, this.ChannelId, GetType());

          if (hmiManagementService != null)
            hmiManagementService.RegisterHMIFaceplate(faceplate);
        }
        return faceplate;
      }
    }
     
    private HMI.Main.Faceplates.PIDBase.fpParameter fpParameter
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        HMI.Main.Faceplates.PIDBase.fpParameter faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (HMI.Main.Faceplates.PIDBase.fpParameter)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(HMI.Main.Faceplates.PIDBase.fpParameter));
        
        if (faceplate == null)
        {
          faceplate = new HMI.Main.Faceplates.PIDBase.fpParameter();

          faceplate.SetConnectionInfo(this.TagName, this.SymbolPath, this.ChannelId, GetType());

          if (hmiManagementService != null)
            hmiManagementService.RegisterHMIFaceplate(faceplate);
        }
        return faceplate;
      }
    }
     
    private HMI.Main.Faceplates.PIDBase.fpTrend fpTrend
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        HMI.Main.Faceplates.PIDBase.fpTrend faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (HMI.Main.Faceplates.PIDBase.fpTrend)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(HMI.Main.Faceplates.PIDBase.fpTrend));
        
        if (faceplate == null)
        {
          faceplate = new HMI.Main.Faceplates.PIDBase.fpTrend();

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
#endregion PIDBase_HMI;

#endregion Definitions;

