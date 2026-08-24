using System;
using NxtControl.GuiFramework;
using NxtControl.Services;


#region Definitions;
#region MemoOC_D_HMI;

namespace SE.Nereda.Symbols.MemoOC_D
{
  partial class sDefault
  {

    private SE.Nereda.Faceplates.MemoOC_D.fpMemoOC fpMemoOC
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.MemoOC_D.fpMemoOC faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.MemoOC_D.fpMemoOC)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.MemoOC_D.fpMemoOC));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.MemoOC_D.fpMemoOC();

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

      if ("fpMemoOC" == (string)openFaceplate.FaceplateType)
        hmiFaceplate = fpMemoOC;

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

      if ("fpMemoOC" == openFaceplate)
        hmiFaceplate = fpMemoOC;

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

namespace SE.Nereda.Symbols.MemoOC_D
{
  partial class sMOCBtn
  {

    private SE.Nereda.Faceplates.MemoOC_D.fpMemoOC fpMemoOC
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.MemoOC_D.fpMemoOC faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.MemoOC_D.fpMemoOC)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.MemoOC_D.fpMemoOC));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.MemoOC_D.fpMemoOC();

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

      if ("fpMemoOC" == (string)openFaceplate.FaceplateType)
        hmiFaceplate = fpMemoOC;

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

      if ("fpMemoOC" == openFaceplate)
        hmiFaceplate = fpMemoOC;

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
#endregion MemoOC_D_HMI;

#endregion Definitions;

