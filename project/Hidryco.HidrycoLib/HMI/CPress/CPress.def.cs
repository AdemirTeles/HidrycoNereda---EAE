/*
 * Criado pelo EcoStruxure Automation Expert.
 * Usuário:  
 * Data: 30/03/2026
 * Tempo: 10:13
 * 
 */
using System;
using NxtControl.GuiFramework;
using NxtControl.Services;

#region Definitions;
#region CPress_HMI;

namespace Hidryco.HidrycoLib.Symbols.CPress
{
  partial class sDefault
  {

    private Hidryco.HidrycoLib.Faceplates.CPress.fpFluxograma fpFluxograma
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        Hidryco.HidrycoLib.Faceplates.CPress.fpFluxograma faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (Hidryco.HidrycoLib.Faceplates.CPress.fpFluxograma)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(Hidryco.HidrycoLib.Faceplates.CPress.fpFluxograma));
        
        if (faceplate == null)
        {
          faceplate = new Hidryco.HidrycoLib.Faceplates.CPress.fpFluxograma();

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

      if ("fpFluxograma" == (string)openFaceplate.FaceplateType)
        hmiFaceplate = fpFluxograma;

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

      if ("fpFluxograma" == openFaceplate)
        hmiFaceplate = fpFluxograma;

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
#endregion CPress_HMI;

#endregion Definitions;
