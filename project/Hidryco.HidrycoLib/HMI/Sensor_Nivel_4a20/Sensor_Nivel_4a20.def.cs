using System;
using NxtControl.GuiFramework;
using NxtControl.Services;


#region Definitions;
#region Sensor_Nivel_4a20_HMI;

namespace Hidryco.HidrycoLib.Symbols.Sensor_Nivel_4a20
{
  partial class sDefault
  {

    private Hidryco.HidrycoLib.Faceplates.Sensor_Nivel_4a20.fpAjustes fpAjustes
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        Hidryco.HidrycoLib.Faceplates.Sensor_Nivel_4a20.fpAjustes faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (Hidryco.HidrycoLib.Faceplates.Sensor_Nivel_4a20.fpAjustes)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(Hidryco.HidrycoLib.Faceplates.Sensor_Nivel_4a20.fpAjustes));
        
        if (faceplate == null)
        {
          faceplate = new Hidryco.HidrycoLib.Faceplates.Sensor_Nivel_4a20.fpAjustes();

          faceplate.SetConnectionInfo(this.TagName, this.SymbolPath, this.ChannelId, GetType());

          if (hmiManagementService != null)
            hmiManagementService.RegisterHMIFaceplate(faceplate);
        }
        return faceplate;
      }
    }
     
    private Hidryco.HidrycoLib.Faceplates.Sensor_Nivel_4a20.fpAlarmes fpAlarmes
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        Hidryco.HidrycoLib.Faceplates.Sensor_Nivel_4a20.fpAlarmes faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (Hidryco.HidrycoLib.Faceplates.Sensor_Nivel_4a20.fpAlarmes)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(Hidryco.HidrycoLib.Faceplates.Sensor_Nivel_4a20.fpAlarmes));
        
        if (faceplate == null)
        {
          faceplate = new Hidryco.HidrycoLib.Faceplates.Sensor_Nivel_4a20.fpAlarmes();

          faceplate.SetConnectionInfo(this.TagName, this.SymbolPath, this.ChannelId, GetType());

          if (hmiManagementService != null)
            hmiManagementService.RegisterHMIFaceplate(faceplate);
        }
        return faceplate;
      }
    }
     
    private Hidryco.HidrycoLib.Faceplates.Sensor_Nivel_4a20.fpGrafico fpGrafico
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        Hidryco.HidrycoLib.Faceplates.Sensor_Nivel_4a20.fpGrafico faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (Hidryco.HidrycoLib.Faceplates.Sensor_Nivel_4a20.fpGrafico)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(Hidryco.HidrycoLib.Faceplates.Sensor_Nivel_4a20.fpGrafico));
        
        if (faceplate == null)
        {
          faceplate = new Hidryco.HidrycoLib.Faceplates.Sensor_Nivel_4a20.fpGrafico();

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

      if ("fpAjustes" == (string)openFaceplate.FaceplateType)
        hmiFaceplate = fpAjustes;

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

      if ("fpAjustes" == openFaceplate)
        hmiFaceplate = fpAjustes;

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

namespace Hidryco.HidrycoLib.Faceplates.Sensor_Nivel_4a20
{
  partial class fpAjustes
  {

    private Hidryco.HidrycoLib.Faceplates.Sensor_Nivel_4a20.fpAlarmes fpAlarmes
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        Hidryco.HidrycoLib.Faceplates.Sensor_Nivel_4a20.fpAlarmes faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (Hidryco.HidrycoLib.Faceplates.Sensor_Nivel_4a20.fpAlarmes)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(Hidryco.HidrycoLib.Faceplates.Sensor_Nivel_4a20.fpAlarmes));
        
        if (faceplate == null)
        {
          faceplate = new Hidryco.HidrycoLib.Faceplates.Sensor_Nivel_4a20.fpAlarmes();

          faceplate.SetConnectionInfo(this.TagName, this.ConnectionSymbolPath, this.ChannelId, this.ParentType);

          if (hmiManagementService != null)
            hmiManagementService.RegisterHMIFaceplate(faceplate);
        }
        return faceplate;
      }
    }
     
    private Hidryco.HidrycoLib.Faceplates.Sensor_Nivel_4a20.fpGrafico fpGrafico
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        Hidryco.HidrycoLib.Faceplates.Sensor_Nivel_4a20.fpGrafico faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (Hidryco.HidrycoLib.Faceplates.Sensor_Nivel_4a20.fpGrafico)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(Hidryco.HidrycoLib.Faceplates.Sensor_Nivel_4a20.fpGrafico));
        
        if (faceplate == null)
        {
          faceplate = new Hidryco.HidrycoLib.Faceplates.Sensor_Nivel_4a20.fpGrafico();

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

namespace Hidryco.HidrycoLib.Faceplates.Sensor_Nivel_4a20
{
  partial class fpAlarmes
  {

    private Hidryco.HidrycoLib.Faceplates.Sensor_Nivel_4a20.fpAjustes fpAjustes
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        Hidryco.HidrycoLib.Faceplates.Sensor_Nivel_4a20.fpAjustes faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (Hidryco.HidrycoLib.Faceplates.Sensor_Nivel_4a20.fpAjustes)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(Hidryco.HidrycoLib.Faceplates.Sensor_Nivel_4a20.fpAjustes));
        
        if (faceplate == null)
        {
          faceplate = new Hidryco.HidrycoLib.Faceplates.Sensor_Nivel_4a20.fpAjustes();

          faceplate.SetConnectionInfo(this.TagName, this.ConnectionSymbolPath, this.ChannelId, this.ParentType);

          if (hmiManagementService != null)
            hmiManagementService.RegisterHMIFaceplate(faceplate);
        }
        return faceplate;
      }
    }
     
    private Hidryco.HidrycoLib.Faceplates.Sensor_Nivel_4a20.fpGrafico fpGrafico
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        Hidryco.HidrycoLib.Faceplates.Sensor_Nivel_4a20.fpGrafico faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (Hidryco.HidrycoLib.Faceplates.Sensor_Nivel_4a20.fpGrafico)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(Hidryco.HidrycoLib.Faceplates.Sensor_Nivel_4a20.fpGrafico));
        
        if (faceplate == null)
        {
          faceplate = new Hidryco.HidrycoLib.Faceplates.Sensor_Nivel_4a20.fpGrafico();

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

      if ("fpAjustes" == (string)openFaceplate.FaceplateType)
        hmiFaceplate = fpAjustes;

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

      if ("fpAjustes" == openFaceplate)
        hmiFaceplate = fpAjustes;

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

namespace Hidryco.HidrycoLib.Faceplates.Sensor_Nivel_4a20
{
  partial class fpGrafico
  {

    private Hidryco.HidrycoLib.Faceplates.Sensor_Nivel_4a20.fpAjustes fpAjustes
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        Hidryco.HidrycoLib.Faceplates.Sensor_Nivel_4a20.fpAjustes faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (Hidryco.HidrycoLib.Faceplates.Sensor_Nivel_4a20.fpAjustes)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(Hidryco.HidrycoLib.Faceplates.Sensor_Nivel_4a20.fpAjustes));
        
        if (faceplate == null)
        {
          faceplate = new Hidryco.HidrycoLib.Faceplates.Sensor_Nivel_4a20.fpAjustes();

          faceplate.SetConnectionInfo(this.TagName, this.ConnectionSymbolPath, this.ChannelId, this.ParentType);

          if (hmiManagementService != null)
            hmiManagementService.RegisterHMIFaceplate(faceplate);
        }
        return faceplate;
      }
    }
     
    private Hidryco.HidrycoLib.Faceplates.Sensor_Nivel_4a20.fpAlarmes fpAlarmes
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        Hidryco.HidrycoLib.Faceplates.Sensor_Nivel_4a20.fpAlarmes faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (Hidryco.HidrycoLib.Faceplates.Sensor_Nivel_4a20.fpAlarmes)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(Hidryco.HidrycoLib.Faceplates.Sensor_Nivel_4a20.fpAlarmes));
        
        if (faceplate == null)
        {
          faceplate = new Hidryco.HidrycoLib.Faceplates.Sensor_Nivel_4a20.fpAlarmes();

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

      if ("fpAjustes" == (string)openFaceplate.FaceplateType)
        hmiFaceplate = fpAjustes;

      if ("fpAlarmes" == (string)openFaceplate.FaceplateType)
        hmiFaceplate = fpAlarmes;

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

      if ("fpAjustes" == openFaceplate)
        hmiFaceplate = fpAjustes;

      if ("fpAlarmes" == openFaceplate)
        hmiFaceplate = fpAlarmes;

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
#endregion Sensor_Nivel_4a20_HMI;

#endregion Definitions;

