/*
 * Criado pelo EcoStruxure Automation Expert.
 * Usuário:  
 * Data: 02/03/2026
 * Tempo: 15:58
 * 
 */
using System;
using NxtControl.GuiFramework;
using NxtControl.Services;

#region Definitions;
#region BloqueioAtivaDesativa_HMI;

namespace Hidryco.HidrycoLib.Symbols.BloqueioAtivaDesativa
{
  partial class sDefault
  {

    private Hidryco.HidrycoLib.Faceplates.BloqueioAtivaDesativa.fpAjuste fpAjuste
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        Hidryco.HidrycoLib.Faceplates.BloqueioAtivaDesativa.fpAjuste faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (Hidryco.HidrycoLib.Faceplates.BloqueioAtivaDesativa.fpAjuste)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(Hidryco.HidrycoLib.Faceplates.BloqueioAtivaDesativa.fpAjuste));
        
        if (faceplate == null)
        {
          faceplate = new Hidryco.HidrycoLib.Faceplates.BloqueioAtivaDesativa.fpAjuste();

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

      if ("fpAjuste" == (string)openFaceplate.FaceplateType)
        hmiFaceplate = fpAjuste;

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

      if ("fpAjuste" == openFaceplate)
        hmiFaceplate = fpAjuste;

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
#endregion BloqueioAtivaDesativa_HMI;

#endregion Definitions;
