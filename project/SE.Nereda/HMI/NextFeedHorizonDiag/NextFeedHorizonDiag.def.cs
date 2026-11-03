using System;
using NxtControl.GuiFramework;
using NxtControl.Services;


#region Definitions;
#region NextFeedHorizonDiag_HMI;

namespace SE.Nereda.Symbols.NextFeedHorizonDiag
{
  partial class sDefault
  {

    private SE.Nereda.Faceplates.NextFeedHorizonDiag.fpDiag fpDiag
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.NextFeedHorizonDiag.fpDiag faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.NextFeedHorizonDiag.fpDiag)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.NextFeedHorizonDiag.fpDiag));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.NextFeedHorizonDiag.fpDiag();

          faceplate.SetConnectionInfo(this.TagName, this.SymbolPath, this.ChannelId, GetType());

          if (hmiManagementService != null)
            hmiManagementService.RegisterHMIFaceplate(faceplate);
        }
        return faceplate;
      }
    }
     
    private SE.Nereda.Faceplates.NextFeedHorizonDiag.fpDiag2 fpDiag2
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.NextFeedHorizonDiag.fpDiag2 faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.NextFeedHorizonDiag.fpDiag2)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.NextFeedHorizonDiag.fpDiag2));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.NextFeedHorizonDiag.fpDiag2();

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

      if ("fpDiag" == (string)openFaceplate.FaceplateType)
        hmiFaceplate = fpDiag;

      if ("fpDiag2" == (string)openFaceplate.FaceplateType)
        hmiFaceplate = fpDiag2;

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

      if ("fpDiag" == openFaceplate)
        hmiFaceplate = fpDiag;

      if ("fpDiag2" == openFaceplate)
        hmiFaceplate = fpDiag2;

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

namespace SE.Nereda.Faceplates.NextFeedHorizonDiag
{
  partial class fpDiag
  {

    private SE.Nereda.Faceplates.NextFeedHorizonDiag.fpDiag2 fpDiag2
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.NextFeedHorizonDiag.fpDiag2 faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.NextFeedHorizonDiag.fpDiag2)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.NextFeedHorizonDiag.fpDiag2));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.NextFeedHorizonDiag.fpDiag2();

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

      if ("fpDiag2" == (string)openFaceplate.FaceplateType)
        hmiFaceplate = fpDiag2;

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

      if ("fpDiag2" == openFaceplate)
        hmiFaceplate = fpDiag2;

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

namespace SE.Nereda.Symbols.NextFeedHorizonDiag
{
  partial class sCurrCalc
  {

    private SE.Nereda.Faceplates.NextFeedHorizonDiag.fpDiag fpDiag
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.NextFeedHorizonDiag.fpDiag faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.NextFeedHorizonDiag.fpDiag)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.NextFeedHorizonDiag.fpDiag));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.NextFeedHorizonDiag.fpDiag();

          faceplate.SetConnectionInfo(this.TagName, this.SymbolPath, this.ChannelId, GetType());

          if (hmiManagementService != null)
            hmiManagementService.RegisterHMIFaceplate(faceplate);
        }
        return faceplate;
      }
    }
     
    private SE.Nereda.Faceplates.NextFeedHorizonDiag.fpDiag2 fpDiag2
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.NextFeedHorizonDiag.fpDiag2 faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.NextFeedHorizonDiag.fpDiag2)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.NextFeedHorizonDiag.fpDiag2));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.NextFeedHorizonDiag.fpDiag2();

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

      if ("fpDiag" == (string)openFaceplate.FaceplateType)
        hmiFaceplate = fpDiag;

      if ("fpDiag2" == (string)openFaceplate.FaceplateType)
        hmiFaceplate = fpDiag2;

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

      if ("fpDiag" == openFaceplate)
        hmiFaceplate = fpDiag;

      if ("fpDiag2" == openFaceplate)
        hmiFaceplate = fpDiag2;

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

namespace SE.Nereda.Faceplates.NextFeedHorizonDiag
{
  partial class fpDiag2
  {

    private SE.Nereda.Faceplates.NextFeedHorizonDiag.fpDiag fpDiag
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.NextFeedHorizonDiag.fpDiag faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.NextFeedHorizonDiag.fpDiag)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.NextFeedHorizonDiag.fpDiag));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.NextFeedHorizonDiag.fpDiag();

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

      if ("fpDiag" == (string)openFaceplate.FaceplateType)
        hmiFaceplate = fpDiag;

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

      if ("fpDiag" == openFaceplate)
        hmiFaceplate = fpDiag;

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
#endregion NextFeedHorizonDiag_HMI;

#endregion Definitions;

