using System;
using NxtControl.GuiFramework;
using NxtControl.Services;


#region Definitions;
#region PreTratamentoPreliminar_HMI;

namespace Hidryco.HidrycoLib.Symbols.PreTratamentoPreliminar
{
  partial class sDefault
  {

    private Hidryco.HidrycoLib.Faceplates.PreTratamentoPreliminar.fpDuvidas fpDuvidas
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        Hidryco.HidrycoLib.Faceplates.PreTratamentoPreliminar.fpDuvidas faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (Hidryco.HidrycoLib.Faceplates.PreTratamentoPreliminar.fpDuvidas)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(Hidryco.HidrycoLib.Faceplates.PreTratamentoPreliminar.fpDuvidas));
        
        if (faceplate == null)
        {
          faceplate = new Hidryco.HidrycoLib.Faceplates.PreTratamentoPreliminar.fpDuvidas();

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

      if ("fpDuvidas" == (string)openFaceplate.FaceplateType)
        hmiFaceplate = fpDuvidas;

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

      if ("fpDuvidas" == openFaceplate)
        hmiFaceplate = fpDuvidas;

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
#endregion PreTratamentoPreliminar_HMI;

#endregion Definitions;

