using System;
using NxtControl.GuiFramework;
using NxtControl.Services;


#region Definitions;
#region Sensor_Comunicacao_HMI;

namespace Hidryco.HidrycoLib.Symbols.Sensor_Comunicacao
{
  partial class sDefault
  {

    private Hidryco.HidrycoLib.Faceplates.Sensor_Comunicacao.fpAlarmes fpAlarmes
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        Hidryco.HidrycoLib.Faceplates.Sensor_Comunicacao.fpAlarmes faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (Hidryco.HidrycoLib.Faceplates.Sensor_Comunicacao.fpAlarmes)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(Hidryco.HidrycoLib.Faceplates.Sensor_Comunicacao.fpAlarmes));
        
        if (faceplate == null)
        {
          faceplate = new Hidryco.HidrycoLib.Faceplates.Sensor_Comunicacao.fpAlarmes();

          faceplate.SetConnectionInfo(this.TagName, this.SymbolPath, this.ChannelId, GetType());

          if (hmiManagementService != null)
            hmiManagementService.RegisterHMIFaceplate(faceplate);
        }
        return faceplate;
      }
    }
     
    private Hidryco.HidrycoLib.Faceplates.Sensor_Comunicacao.fpGrafico fpGrafico
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        Hidryco.HidrycoLib.Faceplates.Sensor_Comunicacao.fpGrafico faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (Hidryco.HidrycoLib.Faceplates.Sensor_Comunicacao.fpGrafico)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(Hidryco.HidrycoLib.Faceplates.Sensor_Comunicacao.fpGrafico));
        
        if (faceplate == null)
        {
          faceplate = new Hidryco.HidrycoLib.Faceplates.Sensor_Comunicacao.fpGrafico();

          faceplate.SetConnectionInfo(this.TagName, this.SymbolPath, this.ChannelId, GetType());

          if (hmiManagementService != null)
            hmiManagementService.RegisterHMIFaceplate(faceplate);
        }
        return faceplate;
      }
    }
     
    private Hidryco.HidrycoLib.Faceplates.Sensor_Comunicacao.fpAjustes fpAjustes
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        Hidryco.HidrycoLib.Faceplates.Sensor_Comunicacao.fpAjustes faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (Hidryco.HidrycoLib.Faceplates.Sensor_Comunicacao.fpAjustes)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(Hidryco.HidrycoLib.Faceplates.Sensor_Comunicacao.fpAjustes));
        
        if (faceplate == null)
        {
          faceplate = new Hidryco.HidrycoLib.Faceplates.Sensor_Comunicacao.fpAjustes();

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

      if ("fpAlarmes" == (string)openFaceplate.FaceplateType)
        hmiFaceplate = fpAlarmes;

      if ("fpGrafico" == (string)openFaceplate.FaceplateType)
        hmiFaceplate = fpGrafico;

      if ("fpAjustes" == (string)openFaceplate.FaceplateType)
        hmiFaceplate = fpAjustes;

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

      if ("fpAlarmes" == openFaceplate)
        hmiFaceplate = fpAlarmes;

      if ("fpGrafico" == openFaceplate)
        hmiFaceplate = fpGrafico;

      if ("fpAjustes" == openFaceplate)
        hmiFaceplate = fpAjustes;

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

namespace Hidryco.HidrycoLib.Faceplates.Sensor_Comunicacao
{
  partial class fpAlarmes
  {

    private Hidryco.HidrycoLib.Faceplates.Sensor_Comunicacao.fpGrafico fpGrafico
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        Hidryco.HidrycoLib.Faceplates.Sensor_Comunicacao.fpGrafico faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (Hidryco.HidrycoLib.Faceplates.Sensor_Comunicacao.fpGrafico)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(Hidryco.HidrycoLib.Faceplates.Sensor_Comunicacao.fpGrafico));
        
        if (faceplate == null)
        {
          faceplate = new Hidryco.HidrycoLib.Faceplates.Sensor_Comunicacao.fpGrafico();

          faceplate.SetConnectionInfo(this.TagName, this.ConnectionSymbolPath, this.ChannelId, this.ParentType);

          if (hmiManagementService != null)
            hmiManagementService.RegisterHMIFaceplate(faceplate);
        }
        return faceplate;
      }
    }
     
    private Hidryco.HidrycoLib.Faceplates.Sensor_Comunicacao.fpAjustes fpAjustes
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        Hidryco.HidrycoLib.Faceplates.Sensor_Comunicacao.fpAjustes faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (Hidryco.HidrycoLib.Faceplates.Sensor_Comunicacao.fpAjustes)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(Hidryco.HidrycoLib.Faceplates.Sensor_Comunicacao.fpAjustes));
        
        if (faceplate == null)
        {
          faceplate = new Hidryco.HidrycoLib.Faceplates.Sensor_Comunicacao.fpAjustes();

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

      if ("fpGrafico" == (string)openFaceplate.FaceplateType)
        hmiFaceplate = fpGrafico;

      if ("fpAjustes" == (string)openFaceplate.FaceplateType)
        hmiFaceplate = fpAjustes;

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

      if ("fpGrafico" == openFaceplate)
        hmiFaceplate = fpGrafico;

      if ("fpAjustes" == openFaceplate)
        hmiFaceplate = fpAjustes;

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

namespace Hidryco.HidrycoLib.Faceplates.Sensor_Comunicacao
{
  partial class fpGrafico
  {

    private Hidryco.HidrycoLib.Faceplates.Sensor_Comunicacao.fpAlarmes fpAlarmes
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        Hidryco.HidrycoLib.Faceplates.Sensor_Comunicacao.fpAlarmes faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (Hidryco.HidrycoLib.Faceplates.Sensor_Comunicacao.fpAlarmes)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(Hidryco.HidrycoLib.Faceplates.Sensor_Comunicacao.fpAlarmes));
        
        if (faceplate == null)
        {
          faceplate = new Hidryco.HidrycoLib.Faceplates.Sensor_Comunicacao.fpAlarmes();

          faceplate.SetConnectionInfo(this.TagName, this.ConnectionSymbolPath, this.ChannelId, this.ParentType);

          if (hmiManagementService != null)
            hmiManagementService.RegisterHMIFaceplate(faceplate);
        }
        return faceplate;
      }
    }
     
    private Hidryco.HidrycoLib.Faceplates.Sensor_Comunicacao.fpAjustes fpAjustes
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        Hidryco.HidrycoLib.Faceplates.Sensor_Comunicacao.fpAjustes faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (Hidryco.HidrycoLib.Faceplates.Sensor_Comunicacao.fpAjustes)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(Hidryco.HidrycoLib.Faceplates.Sensor_Comunicacao.fpAjustes));
        
        if (faceplate == null)
        {
          faceplate = new Hidryco.HidrycoLib.Faceplates.Sensor_Comunicacao.fpAjustes();

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

      if ("fpAlarmes" == (string)openFaceplate.FaceplateType)
        hmiFaceplate = fpAlarmes;

      if ("fpAjustes" == (string)openFaceplate.FaceplateType)
        hmiFaceplate = fpAjustes;

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

      if ("fpAlarmes" == openFaceplate)
        hmiFaceplate = fpAlarmes;

      if ("fpAjustes" == openFaceplate)
        hmiFaceplate = fpAjustes;

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

namespace Hidryco.HidrycoLib.Faceplates.Sensor_Comunicacao
{
  partial class fpAjustes
  {

    private Hidryco.HidrycoLib.Faceplates.Sensor_Comunicacao.fpAlarmes fpAlarmes
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        Hidryco.HidrycoLib.Faceplates.Sensor_Comunicacao.fpAlarmes faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (Hidryco.HidrycoLib.Faceplates.Sensor_Comunicacao.fpAlarmes)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(Hidryco.HidrycoLib.Faceplates.Sensor_Comunicacao.fpAlarmes));
        
        if (faceplate == null)
        {
          faceplate = new Hidryco.HidrycoLib.Faceplates.Sensor_Comunicacao.fpAlarmes();

          faceplate.SetConnectionInfo(this.TagName, this.ConnectionSymbolPath, this.ChannelId, this.ParentType);

          if (hmiManagementService != null)
            hmiManagementService.RegisterHMIFaceplate(faceplate);
        }
        return faceplate;
      }
    }
     
    private Hidryco.HidrycoLib.Faceplates.Sensor_Comunicacao.fpGrafico fpGrafico
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        Hidryco.HidrycoLib.Faceplates.Sensor_Comunicacao.fpGrafico faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (Hidryco.HidrycoLib.Faceplates.Sensor_Comunicacao.fpGrafico)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(Hidryco.HidrycoLib.Faceplates.Sensor_Comunicacao.fpGrafico));
        
        if (faceplate == null)
        {
          faceplate = new Hidryco.HidrycoLib.Faceplates.Sensor_Comunicacao.fpGrafico();

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

      if ("fpAlarmes" == (string)openFaceplate.FaceplateType)
        hmiFaceplate = fpAlarmes;

      if ("fpGrafico" == (string)openFaceplate.FaceplateType)
        hmiFaceplate = fpGrafico;

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

      if ("fpAlarmes" == openFaceplate)
        hmiFaceplate = fpAlarmes;

      if ("fpGrafico" == openFaceplate)
        hmiFaceplate = fpGrafico;

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
#endregion Sensor_Comunicacao_HMI;

#endregion Definitions;

