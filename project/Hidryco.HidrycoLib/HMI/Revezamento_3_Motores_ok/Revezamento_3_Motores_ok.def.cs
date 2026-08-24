/*
 * Criado pelo EcoStruxure Automation Expert.
 * Usuário:  
 * Data: 25/02/2026
 * Tempo: 09:32
 * 
 */
using System;
using NxtControl.GuiFramework;
using NxtControl.Services;

#region Definitions;
#region Revezamento_3_Motores_ok_HMI;

namespace Hidryco.HidrycoLib.Symbols.Revezamento_3_Motores_ok
{
  partial class sDefault
  {

    private Hidryco.HidrycoLib.Faceplates.Revezamento_3_Motores_ok.Faceplate1 Faceplate1
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        Hidryco.HidrycoLib.Faceplates.Revezamento_3_Motores_ok.Faceplate1 faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (Hidryco.HidrycoLib.Faceplates.Revezamento_3_Motores_ok.Faceplate1)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(Hidryco.HidrycoLib.Faceplates.Revezamento_3_Motores_ok.Faceplate1));
        
        if (faceplate == null)
        {
          faceplate = new Hidryco.HidrycoLib.Faceplates.Revezamento_3_Motores_ok.Faceplate1();

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

      if ("Faceplate1" == (string)openFaceplate.FaceplateType)
        hmiFaceplate = Faceplate1;

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

      if ("Faceplate1" == openFaceplate)
        hmiFaceplate = Faceplate1;

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
#endregion Revezamento_3_Motores_ok_HMI;

#endregion Definitions;
