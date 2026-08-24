using System;
using NxtControl.GuiFramework;
using NxtControl.Services;


#region Definitions;
#region FlushSelector_HMI;

namespace SE.Nereda.Symbols.FlushSelector
{
  partial class sDefault
  {

    private SE.Nereda.Faceplates.FlushSelector.fpFlushDiagram fpFlushDiagram
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.FlushSelector.fpFlushDiagram faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.FlushSelector.fpFlushDiagram)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.FlushSelector.fpFlushDiagram));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.FlushSelector.fpFlushDiagram();

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

      if ("fpFlushDiagram" == (string)openFaceplate.FaceplateType)
        hmiFaceplate = fpFlushDiagram;

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

      if ("fpFlushDiagram" == openFaceplate)
        hmiFaceplate = fpFlushDiagram;

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

namespace SE.Nereda.Symbols.FlushSelector
{
  partial class sFlushDiagram
  {

    private SE.Nereda.Faceplates.FlushSelector.fpFlushDiagram fpFlushDiagram
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.FlushSelector.fpFlushDiagram faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.FlushSelector.fpFlushDiagram)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.FlushSelector.fpFlushDiagram));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.FlushSelector.fpFlushDiagram();

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

      if ("fpFlushDiagram" == (string)openFaceplate.FaceplateType)
        hmiFaceplate = fpFlushDiagram;

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

      if ("fpFlushDiagram" == openFaceplate)
        hmiFaceplate = fpFlushDiagram;

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
#endregion FlushSelector_HMI;

#endregion Definitions;

