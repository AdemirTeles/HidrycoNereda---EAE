using System;
using NxtControl.GuiFramework;
using NxtControl.Services;


#region Definitions;
#region OpeningValveDurLogic_HMI;

namespace SE.Nereda.Symbols.OpeningValveDurLogic
{
  partial class sDefault
  {

    private SE.Nereda.Faceplates.OpeningValveDurLogic.fpDiagram fpDiagram
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.OpeningValveDurLogic.fpDiagram faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.OpeningValveDurLogic.fpDiagram)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.OpeningValveDurLogic.fpDiagram));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.OpeningValveDurLogic.fpDiagram();

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

      if ("fpDiagram" == (string)openFaceplate.FaceplateType)
        hmiFaceplate = fpDiagram;

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

      if ("fpDiagram" == openFaceplate)
        hmiFaceplate = fpDiagram;

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

namespace SE.Nereda.Symbols.OpeningValveDurLogic
{
  partial class sSettings
  {

    private SE.Nereda.Faceplates.OpeningValveDurLogic.fpDiagram fpDiagram
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.OpeningValveDurLogic.fpDiagram faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.OpeningValveDurLogic.fpDiagram)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.OpeningValveDurLogic.fpDiagram));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.OpeningValveDurLogic.fpDiagram();

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

      if ("fpDiagram" == (string)openFaceplate.FaceplateType)
        hmiFaceplate = fpDiagram;

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

      if ("fpDiagram" == openFaceplate)
        hmiFaceplate = fpDiagram;

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

namespace SE.Nereda.Symbols.OpeningValveDurLogic
{
  partial class sDuration
  {

    private SE.Nereda.Faceplates.OpeningValveDurLogic.fpDiagram fpDiagram
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.OpeningValveDurLogic.fpDiagram faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.OpeningValveDurLogic.fpDiagram)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.OpeningValveDurLogic.fpDiagram));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.OpeningValveDurLogic.fpDiagram();

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

      if ("fpDiagram" == (string)openFaceplate.FaceplateType)
        hmiFaceplate = fpDiagram;

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

      if ("fpDiagram" == openFaceplate)
        hmiFaceplate = fpDiagram;

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

namespace SE.Nereda.Symbols.OpeningValveDurLogic
{
  partial class sForceClose
  {

    private SE.Nereda.Faceplates.OpeningValveDurLogic.fpDiagram fpDiagram
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.OpeningValveDurLogic.fpDiagram faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.OpeningValveDurLogic.fpDiagram)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.OpeningValveDurLogic.fpDiagram));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.OpeningValveDurLogic.fpDiagram();

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

      if ("fpDiagram" == (string)openFaceplate.FaceplateType)
        hmiFaceplate = fpDiagram;

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

      if ("fpDiagram" == openFaceplate)
        hmiFaceplate = fpDiagram;

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

namespace SE.Nereda.Symbols.OpeningValveDurLogic
{
  partial class sDurSetPoint
  {

    private SE.Nereda.Faceplates.OpeningValveDurLogic.fpDiagram fpDiagram
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.OpeningValveDurLogic.fpDiagram faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.OpeningValveDurLogic.fpDiagram)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.OpeningValveDurLogic.fpDiagram));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.OpeningValveDurLogic.fpDiagram();

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

      if ("fpDiagram" == (string)openFaceplate.FaceplateType)
        hmiFaceplate = fpDiagram;

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

      if ("fpDiagram" == openFaceplate)
        hmiFaceplate = fpDiagram;

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
#endregion OpeningValveDurLogic_HMI;

#endregion Definitions;

