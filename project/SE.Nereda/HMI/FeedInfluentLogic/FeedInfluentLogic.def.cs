using System;
using NxtControl.GuiFramework;
using NxtControl.Services;


#region Definitions;
#region FeedInfluentLogic_HMI;

namespace SE.Nereda.Symbols.FeedInfluentLogic
{
  partial class sDefault
  {

    private SE.Nereda.Faceplates.FeedInfluentLogic.fpPID fpPID
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.FeedInfluentLogic.fpPID faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.FeedInfluentLogic.fpPID)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.FeedInfluentLogic.fpPID));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.FeedInfluentLogic.fpPID();

          faceplate.SetConnectionInfo(this.TagName, this.SymbolPath, this.ChannelId, GetType());

          if (hmiManagementService != null)
            hmiManagementService.RegisterHMIFaceplate(faceplate);
        }
        return faceplate;
      }
    }
     
    private SE.Nereda.Faceplates.FeedInfluentLogic.fpFreezWDur fpFreezWDur
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.FeedInfluentLogic.fpFreezWDur faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.FeedInfluentLogic.fpFreezWDur)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.FeedInfluentLogic.fpFreezWDur));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.FeedInfluentLogic.fpFreezWDur();

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

      if ("fpPID" == (string)openFaceplate.FaceplateType)
        hmiFaceplate = fpPID;

      if ("fpFreezWDur" == (string)openFaceplate.FaceplateType)
        hmiFaceplate = fpFreezWDur;

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

      if ("fpPID" == openFaceplate)
        hmiFaceplate = fpPID;

      if ("fpFreezWDur" == openFaceplate)
        hmiFaceplate = fpFreezWDur;

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

namespace SE.Nereda.Symbols.FeedInfluentLogic
{
  partial class sGraph
  {

    private SE.Nereda.Faceplates.FeedInfluentLogic.fpPID fpPID
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.FeedInfluentLogic.fpPID faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.FeedInfluentLogic.fpPID)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.FeedInfluentLogic.fpPID));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.FeedInfluentLogic.fpPID();

          faceplate.SetConnectionInfo(this.TagName, this.SymbolPath, this.ChannelId, GetType());

          if (hmiManagementService != null)
            hmiManagementService.RegisterHMIFaceplate(faceplate);
        }
        return faceplate;
      }
    }
     
    private SE.Nereda.Faceplates.FeedInfluentLogic.fpFreezWDur fpFreezWDur
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.FeedInfluentLogic.fpFreezWDur faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.FeedInfluentLogic.fpFreezWDur)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.FeedInfluentLogic.fpFreezWDur));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.FeedInfluentLogic.fpFreezWDur();

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

      if ("fpPID" == (string)openFaceplate.FaceplateType)
        hmiFaceplate = fpPID;

      if ("fpFreezWDur" == (string)openFaceplate.FaceplateType)
        hmiFaceplate = fpFreezWDur;

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

      if ("fpPID" == openFaceplate)
        hmiFaceplate = fpPID;

      if ("fpFreezWDur" == openFaceplate)
        hmiFaceplate = fpFreezWDur;

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

namespace SE.Nereda.Symbols.FeedInfluentLogic
{
  partial class sHiHiAlarms
  {

    private SE.Nereda.Faceplates.FeedInfluentLogic.fpPID fpPID
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.FeedInfluentLogic.fpPID faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.FeedInfluentLogic.fpPID)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.FeedInfluentLogic.fpPID));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.FeedInfluentLogic.fpPID();

          faceplate.SetConnectionInfo(this.TagName, this.SymbolPath, this.ChannelId, GetType());

          if (hmiManagementService != null)
            hmiManagementService.RegisterHMIFaceplate(faceplate);
        }
        return faceplate;
      }
    }
     
    private SE.Nereda.Faceplates.FeedInfluentLogic.fpFreezWDur fpFreezWDur
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.FeedInfluentLogic.fpFreezWDur faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.FeedInfluentLogic.fpFreezWDur)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.FeedInfluentLogic.fpFreezWDur));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.FeedInfluentLogic.fpFreezWDur();

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

      if ("fpPID" == (string)openFaceplate.FaceplateType)
        hmiFaceplate = fpPID;

      if ("fpFreezWDur" == (string)openFaceplate.FaceplateType)
        hmiFaceplate = fpFreezWDur;

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

      if ("fpPID" == openFaceplate)
        hmiFaceplate = fpPID;

      if ("fpFreezWDur" == openFaceplate)
        hmiFaceplate = fpFreezWDur;

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

namespace SE.Nereda.Symbols.FeedInfluentLogic
{
  partial class sFreezeMode
  {

    private SE.Nereda.Faceplates.FeedInfluentLogic.fpPID fpPID
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.FeedInfluentLogic.fpPID faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.FeedInfluentLogic.fpPID)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.FeedInfluentLogic.fpPID));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.FeedInfluentLogic.fpPID();

          faceplate.SetConnectionInfo(this.TagName, this.SymbolPath, this.ChannelId, GetType());

          if (hmiManagementService != null)
            hmiManagementService.RegisterHMIFaceplate(faceplate);
        }
        return faceplate;
      }
    }
     
    private SE.Nereda.Faceplates.FeedInfluentLogic.fpFreezWDur fpFreezWDur
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.FeedInfluentLogic.fpFreezWDur faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.FeedInfluentLogic.fpFreezWDur)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.FeedInfluentLogic.fpFreezWDur));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.FeedInfluentLogic.fpFreezWDur();

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

      if ("fpPID" == (string)openFaceplate.FaceplateType)
        hmiFaceplate = fpPID;

      if ("fpFreezWDur" == (string)openFaceplate.FaceplateType)
        hmiFaceplate = fpFreezWDur;

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

      if ("fpPID" == openFaceplate)
        hmiFaceplate = fpPID;

      if ("fpFreezWDur" == openFaceplate)
        hmiFaceplate = fpFreezWDur;

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

namespace SE.Nereda.Symbols.FeedInfluentLogic
{
  partial class sPID
  {

    private SE.Nereda.Faceplates.FeedInfluentLogic.fpPID fpPID
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.FeedInfluentLogic.fpPID faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.FeedInfluentLogic.fpPID)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.FeedInfluentLogic.fpPID));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.FeedInfluentLogic.fpPID();

          faceplate.SetConnectionInfo(this.TagName, this.SymbolPath, this.ChannelId, GetType());

          if (hmiManagementService != null)
            hmiManagementService.RegisterHMIFaceplate(faceplate);
        }
        return faceplate;
      }
    }
     
    private SE.Nereda.Faceplates.FeedInfluentLogic.fpFreezWDur fpFreezWDur
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.FeedInfluentLogic.fpFreezWDur faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.FeedInfluentLogic.fpFreezWDur)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.FeedInfluentLogic.fpFreezWDur));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.FeedInfluentLogic.fpFreezWDur();

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

      if ("fpPID" == (string)openFaceplate.FaceplateType)
        hmiFaceplate = fpPID;

      if ("fpFreezWDur" == (string)openFaceplate.FaceplateType)
        hmiFaceplate = fpFreezWDur;

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

      if ("fpPID" == openFaceplate)
        hmiFaceplate = fpPID;

      if ("fpFreezWDur" == openFaceplate)
        hmiFaceplate = fpFreezWDur;

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

namespace SE.Nereda.Faceplates.FeedInfluentLogic
{
  partial class fpPID
  {

    private SE.Nereda.Faceplates.FeedInfluentLogic.fpFreezWDur fpFreezWDur
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.FeedInfluentLogic.fpFreezWDur faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.FeedInfluentLogic.fpFreezWDur)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.FeedInfluentLogic.fpFreezWDur));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.FeedInfluentLogic.fpFreezWDur();

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

      if ("fpFreezWDur" == (string)openFaceplate.FaceplateType)
        hmiFaceplate = fpFreezWDur;

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

      if ("fpFreezWDur" == openFaceplate)
        hmiFaceplate = fpFreezWDur;

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

namespace SE.Nereda.Symbols.FeedInfluentLogic
{
  partial class sReset
  {

    private SE.Nereda.Faceplates.FeedInfluentLogic.fpPID fpPID
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.FeedInfluentLogic.fpPID faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.FeedInfluentLogic.fpPID)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.FeedInfluentLogic.fpPID));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.FeedInfluentLogic.fpPID();

          faceplate.SetConnectionInfo(this.TagName, this.SymbolPath, this.ChannelId, GetType());

          if (hmiManagementService != null)
            hmiManagementService.RegisterHMIFaceplate(faceplate);
        }
        return faceplate;
      }
    }
     
    private SE.Nereda.Faceplates.FeedInfluentLogic.fpFreezWDur fpFreezWDur
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.FeedInfluentLogic.fpFreezWDur faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.FeedInfluentLogic.fpFreezWDur)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.FeedInfluentLogic.fpFreezWDur));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.FeedInfluentLogic.fpFreezWDur();

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

      if ("fpPID" == (string)openFaceplate.FaceplateType)
        hmiFaceplate = fpPID;

      if ("fpFreezWDur" == (string)openFaceplate.FaceplateType)
        hmiFaceplate = fpFreezWDur;

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

      if ("fpPID" == openFaceplate)
        hmiFaceplate = fpPID;

      if ("fpFreezWDur" == openFaceplate)
        hmiFaceplate = fpFreezWDur;

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

namespace SE.Nereda.Symbols.FeedInfluentLogic
{
  partial class sGrafcet
  {

    private SE.Nereda.Faceplates.FeedInfluentLogic.fpPID fpPID
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.FeedInfluentLogic.fpPID faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.FeedInfluentLogic.fpPID)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.FeedInfluentLogic.fpPID));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.FeedInfluentLogic.fpPID();

          faceplate.SetConnectionInfo(this.TagName, this.SymbolPath, this.ChannelId, GetType());

          if (hmiManagementService != null)
            hmiManagementService.RegisterHMIFaceplate(faceplate);
        }
        return faceplate;
      }
    }
     
    private SE.Nereda.Faceplates.FeedInfluentLogic.fpFreezWDur fpFreezWDur
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.FeedInfluentLogic.fpFreezWDur faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.FeedInfluentLogic.fpFreezWDur)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.FeedInfluentLogic.fpFreezWDur));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.FeedInfluentLogic.fpFreezWDur();

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

      if ("fpPID" == (string)openFaceplate.FaceplateType)
        hmiFaceplate = fpPID;

      if ("fpFreezWDur" == (string)openFaceplate.FaceplateType)
        hmiFaceplate = fpFreezWDur;

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

      if ("fpPID" == openFaceplate)
        hmiFaceplate = fpPID;

      if ("fpFreezWDur" == openFaceplate)
        hmiFaceplate = fpFreezWDur;

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

namespace SE.Nereda.Symbols.FeedInfluentLogic
{
  partial class sFreezWDuration
  {

    private SE.Nereda.Faceplates.FeedInfluentLogic.fpPID fpPID
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.FeedInfluentLogic.fpPID faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.FeedInfluentLogic.fpPID)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.FeedInfluentLogic.fpPID));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.FeedInfluentLogic.fpPID();

          faceplate.SetConnectionInfo(this.TagName, this.SymbolPath, this.ChannelId, GetType());

          if (hmiManagementService != null)
            hmiManagementService.RegisterHMIFaceplate(faceplate);
        }
        return faceplate;
      }
    }
     
    private SE.Nereda.Faceplates.FeedInfluentLogic.fpFreezWDur fpFreezWDur
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.FeedInfluentLogic.fpFreezWDur faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.FeedInfluentLogic.fpFreezWDur)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.FeedInfluentLogic.fpFreezWDur));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.FeedInfluentLogic.fpFreezWDur();

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

      if ("fpPID" == (string)openFaceplate.FaceplateType)
        hmiFaceplate = fpPID;

      if ("fpFreezWDur" == (string)openFaceplate.FaceplateType)
        hmiFaceplate = fpFreezWDur;

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

      if ("fpPID" == openFaceplate)
        hmiFaceplate = fpPID;

      if ("fpFreezWDur" == openFaceplate)
        hmiFaceplate = fpFreezWDur;

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

namespace SE.Nereda.Faceplates.FeedInfluentLogic
{
  partial class fpFreezWDur
  {

    private SE.Nereda.Faceplates.FeedInfluentLogic.fpPID fpPID
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.FeedInfluentLogic.fpPID faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.FeedInfluentLogic.fpPID)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.FeedInfluentLogic.fpPID));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.FeedInfluentLogic.fpPID();

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

      if ("fpPID" == (string)openFaceplate.FaceplateType)
        hmiFaceplate = fpPID;

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

      if ("fpPID" == openFaceplate)
        hmiFaceplate = fpPID;

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
#endregion FeedInfluentLogic_HMI;

#endregion Definitions;

