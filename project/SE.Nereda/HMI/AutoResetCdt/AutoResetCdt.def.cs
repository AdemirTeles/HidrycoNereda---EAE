/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 8/3/2026
 * Time: 2:47 PM
 * 
 */
using System;
using NxtControl.GuiFramework;
using NxtControl.Services;

#region Definitions;
#region AutoResetCdt_HMI;

namespace SE.Nereda.Symbols.AutoResetCdt
{
  partial class sDefault
  {

    private SE.Nereda.Faceplates.AutoResetCdt.fpReset fpReset
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        SE.Nereda.Faceplates.AutoResetCdt.fpReset faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (SE.Nereda.Faceplates.AutoResetCdt.fpReset)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(SE.Nereda.Faceplates.AutoResetCdt.fpReset));
        
        if (faceplate == null)
        {
          faceplate = new SE.Nereda.Faceplates.AutoResetCdt.fpReset();

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

      if ("fpReset" == (string)openFaceplate.FaceplateType)
        hmiFaceplate = fpReset;

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

      if ("fpReset" == openFaceplate)
        hmiFaceplate = fpReset;

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
#endregion AutoResetCdt_HMI;

#endregion Definitions;
