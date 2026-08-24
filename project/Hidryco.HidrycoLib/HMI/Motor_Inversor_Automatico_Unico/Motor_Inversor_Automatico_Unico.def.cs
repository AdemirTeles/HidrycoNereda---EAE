using System;
using NxtControl.GuiFramework;
using NxtControl.Services;


#region Definitions;
#region Motor_Inversor_Automatico_Unico_HMI;

namespace Hidryco.HidrycoLib.Symbols.Motor_Inversor_Automatico_Unico
{
  partial class sBomba
  {

    private Hidryco.HidrycoLib.Faceplates.Motor_Inversor_Automatico_Unico.Faceplate1 Faceplate1
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        Hidryco.HidrycoLib.Faceplates.Motor_Inversor_Automatico_Unico.Faceplate1 faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (Hidryco.HidrycoLib.Faceplates.Motor_Inversor_Automatico_Unico.Faceplate1)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(Hidryco.HidrycoLib.Faceplates.Motor_Inversor_Automatico_Unico.Faceplate1));
        
        if (faceplate == null)
        {
          faceplate = new Hidryco.HidrycoLib.Faceplates.Motor_Inversor_Automatico_Unico.Faceplate1();

          faceplate.SetConnectionInfo(this.TagName, this.SymbolPath, this.ChannelId, GetType());

          if (hmiManagementService != null)
            hmiManagementService.RegisterHMIFaceplate(faceplate);
        }
        return faceplate;
      }
    }
     
    private Hidryco.HidrycoLib.Faceplates.Motor_Inversor_Automatico_Unico.Faceplate2 Faceplate2
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        Hidryco.HidrycoLib.Faceplates.Motor_Inversor_Automatico_Unico.Faceplate2 faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (Hidryco.HidrycoLib.Faceplates.Motor_Inversor_Automatico_Unico.Faceplate2)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(Hidryco.HidrycoLib.Faceplates.Motor_Inversor_Automatico_Unico.Faceplate2));
        
        if (faceplate == null)
        {
          faceplate = new Hidryco.HidrycoLib.Faceplates.Motor_Inversor_Automatico_Unico.Faceplate2();

          faceplate.SetConnectionInfo(this.TagName, this.SymbolPath, this.ChannelId, GetType());

          if (hmiManagementService != null)
            hmiManagementService.RegisterHMIFaceplate(faceplate);
        }
        return faceplate;
      }
    }
     
    private Hidryco.HidrycoLib.Faceplates.Motor_Inversor_Automatico_Unico.Faceplate3 Faceplate3
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        Hidryco.HidrycoLib.Faceplates.Motor_Inversor_Automatico_Unico.Faceplate3 faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (Hidryco.HidrycoLib.Faceplates.Motor_Inversor_Automatico_Unico.Faceplate3)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(Hidryco.HidrycoLib.Faceplates.Motor_Inversor_Automatico_Unico.Faceplate3));
        
        if (faceplate == null)
        {
          faceplate = new Hidryco.HidrycoLib.Faceplates.Motor_Inversor_Automatico_Unico.Faceplate3();

          faceplate.SetConnectionInfo(this.TagName, this.SymbolPath, this.ChannelId, GetType());

          if (hmiManagementService != null)
            hmiManagementService.RegisterHMIFaceplate(faceplate);
        }
        return faceplate;
      }
    }
     
    private Hidryco.HidrycoLib.Faceplates.Motor_Inversor_Automatico_Unico.Faceplate4 Faceplate4
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        Hidryco.HidrycoLib.Faceplates.Motor_Inversor_Automatico_Unico.Faceplate4 faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (Hidryco.HidrycoLib.Faceplates.Motor_Inversor_Automatico_Unico.Faceplate4)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(Hidryco.HidrycoLib.Faceplates.Motor_Inversor_Automatico_Unico.Faceplate4));
        
        if (faceplate == null)
        {
          faceplate = new Hidryco.HidrycoLib.Faceplates.Motor_Inversor_Automatico_Unico.Faceplate4();

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

      if ("Faceplate2" == (string)openFaceplate.FaceplateType)
        hmiFaceplate = Faceplate2;

      if ("Faceplate3" == (string)openFaceplate.FaceplateType)
        hmiFaceplate = Faceplate3;

      if ("Faceplate4" == (string)openFaceplate.FaceplateType)
        hmiFaceplate = Faceplate4;

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

      if ("Faceplate2" == openFaceplate)
        hmiFaceplate = Faceplate2;

      if ("Faceplate3" == openFaceplate)
        hmiFaceplate = Faceplate3;

      if ("Faceplate4" == openFaceplate)
        hmiFaceplate = Faceplate4;

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

namespace Hidryco.HidrycoLib.Faceplates.Motor_Inversor_Automatico_Unico
{
  partial class Faceplate1
  {

    private Hidryco.HidrycoLib.Faceplates.Motor_Inversor_Automatico_Unico.Faceplate2 Faceplate2
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        Hidryco.HidrycoLib.Faceplates.Motor_Inversor_Automatico_Unico.Faceplate2 faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (Hidryco.HidrycoLib.Faceplates.Motor_Inversor_Automatico_Unico.Faceplate2)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(Hidryco.HidrycoLib.Faceplates.Motor_Inversor_Automatico_Unico.Faceplate2));
        
        if (faceplate == null)
        {
          faceplate = new Hidryco.HidrycoLib.Faceplates.Motor_Inversor_Automatico_Unico.Faceplate2();

          faceplate.SetConnectionInfo(this.TagName, this.ConnectionSymbolPath, this.ChannelId, this.ParentType);

          if (hmiManagementService != null)
            hmiManagementService.RegisterHMIFaceplate(faceplate);
        }
        return faceplate;
      }
    }
     
    private Hidryco.HidrycoLib.Faceplates.Motor_Inversor_Automatico_Unico.Faceplate3 Faceplate3
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        Hidryco.HidrycoLib.Faceplates.Motor_Inversor_Automatico_Unico.Faceplate3 faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (Hidryco.HidrycoLib.Faceplates.Motor_Inversor_Automatico_Unico.Faceplate3)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(Hidryco.HidrycoLib.Faceplates.Motor_Inversor_Automatico_Unico.Faceplate3));
        
        if (faceplate == null)
        {
          faceplate = new Hidryco.HidrycoLib.Faceplates.Motor_Inversor_Automatico_Unico.Faceplate3();

          faceplate.SetConnectionInfo(this.TagName, this.ConnectionSymbolPath, this.ChannelId, this.ParentType);

          if (hmiManagementService != null)
            hmiManagementService.RegisterHMIFaceplate(faceplate);
        }
        return faceplate;
      }
    }
     
    private Hidryco.HidrycoLib.Faceplates.Motor_Inversor_Automatico_Unico.Faceplate4 Faceplate4
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        Hidryco.HidrycoLib.Faceplates.Motor_Inversor_Automatico_Unico.Faceplate4 faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (Hidryco.HidrycoLib.Faceplates.Motor_Inversor_Automatico_Unico.Faceplate4)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(Hidryco.HidrycoLib.Faceplates.Motor_Inversor_Automatico_Unico.Faceplate4));
        
        if (faceplate == null)
        {
          faceplate = new Hidryco.HidrycoLib.Faceplates.Motor_Inversor_Automatico_Unico.Faceplate4();

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

      if ("Faceplate2" == (string)openFaceplate.FaceplateType)
        hmiFaceplate = Faceplate2;

      if ("Faceplate3" == (string)openFaceplate.FaceplateType)
        hmiFaceplate = Faceplate3;

      if ("Faceplate4" == (string)openFaceplate.FaceplateType)
        hmiFaceplate = Faceplate4;

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

      if ("Faceplate2" == openFaceplate)
        hmiFaceplate = Faceplate2;

      if ("Faceplate3" == openFaceplate)
        hmiFaceplate = Faceplate3;

      if ("Faceplate4" == openFaceplate)
        hmiFaceplate = Faceplate4;

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

namespace Hidryco.HidrycoLib.Faceplates.Motor_Inversor_Automatico_Unico
{
  partial class Faceplate2
  {

    private Hidryco.HidrycoLib.Faceplates.Motor_Inversor_Automatico_Unico.Faceplate1 Faceplate1
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        Hidryco.HidrycoLib.Faceplates.Motor_Inversor_Automatico_Unico.Faceplate1 faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (Hidryco.HidrycoLib.Faceplates.Motor_Inversor_Automatico_Unico.Faceplate1)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(Hidryco.HidrycoLib.Faceplates.Motor_Inversor_Automatico_Unico.Faceplate1));
        
        if (faceplate == null)
        {
          faceplate = new Hidryco.HidrycoLib.Faceplates.Motor_Inversor_Automatico_Unico.Faceplate1();

          faceplate.SetConnectionInfo(this.TagName, this.ConnectionSymbolPath, this.ChannelId, this.ParentType);

          if (hmiManagementService != null)
            hmiManagementService.RegisterHMIFaceplate(faceplate);
        }
        return faceplate;
      }
    }
     
    private Hidryco.HidrycoLib.Faceplates.Motor_Inversor_Automatico_Unico.Faceplate3 Faceplate3
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        Hidryco.HidrycoLib.Faceplates.Motor_Inversor_Automatico_Unico.Faceplate3 faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (Hidryco.HidrycoLib.Faceplates.Motor_Inversor_Automatico_Unico.Faceplate3)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(Hidryco.HidrycoLib.Faceplates.Motor_Inversor_Automatico_Unico.Faceplate3));
        
        if (faceplate == null)
        {
          faceplate = new Hidryco.HidrycoLib.Faceplates.Motor_Inversor_Automatico_Unico.Faceplate3();

          faceplate.SetConnectionInfo(this.TagName, this.ConnectionSymbolPath, this.ChannelId, this.ParentType);

          if (hmiManagementService != null)
            hmiManagementService.RegisterHMIFaceplate(faceplate);
        }
        return faceplate;
      }
    }
     
    private Hidryco.HidrycoLib.Faceplates.Motor_Inversor_Automatico_Unico.Faceplate4 Faceplate4
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        Hidryco.HidrycoLib.Faceplates.Motor_Inversor_Automatico_Unico.Faceplate4 faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (Hidryco.HidrycoLib.Faceplates.Motor_Inversor_Automatico_Unico.Faceplate4)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(Hidryco.HidrycoLib.Faceplates.Motor_Inversor_Automatico_Unico.Faceplate4));
        
        if (faceplate == null)
        {
          faceplate = new Hidryco.HidrycoLib.Faceplates.Motor_Inversor_Automatico_Unico.Faceplate4();

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

      if ("Faceplate1" == (string)openFaceplate.FaceplateType)
        hmiFaceplate = Faceplate1;

      if ("Faceplate3" == (string)openFaceplate.FaceplateType)
        hmiFaceplate = Faceplate3;

      if ("Faceplate4" == (string)openFaceplate.FaceplateType)
        hmiFaceplate = Faceplate4;

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

      if ("Faceplate3" == openFaceplate)
        hmiFaceplate = Faceplate3;

      if ("Faceplate4" == openFaceplate)
        hmiFaceplate = Faceplate4;

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

namespace Hidryco.HidrycoLib.Faceplates.Motor_Inversor_Automatico_Unico
{
  partial class Faceplate3
  {

    private Hidryco.HidrycoLib.Faceplates.Motor_Inversor_Automatico_Unico.Faceplate1 Faceplate1
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        Hidryco.HidrycoLib.Faceplates.Motor_Inversor_Automatico_Unico.Faceplate1 faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (Hidryco.HidrycoLib.Faceplates.Motor_Inversor_Automatico_Unico.Faceplate1)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(Hidryco.HidrycoLib.Faceplates.Motor_Inversor_Automatico_Unico.Faceplate1));
        
        if (faceplate == null)
        {
          faceplate = new Hidryco.HidrycoLib.Faceplates.Motor_Inversor_Automatico_Unico.Faceplate1();

          faceplate.SetConnectionInfo(this.TagName, this.ConnectionSymbolPath, this.ChannelId, this.ParentType);

          if (hmiManagementService != null)
            hmiManagementService.RegisterHMIFaceplate(faceplate);
        }
        return faceplate;
      }
    }
     
    private Hidryco.HidrycoLib.Faceplates.Motor_Inversor_Automatico_Unico.Faceplate2 Faceplate2
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        Hidryco.HidrycoLib.Faceplates.Motor_Inversor_Automatico_Unico.Faceplate2 faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (Hidryco.HidrycoLib.Faceplates.Motor_Inversor_Automatico_Unico.Faceplate2)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(Hidryco.HidrycoLib.Faceplates.Motor_Inversor_Automatico_Unico.Faceplate2));
        
        if (faceplate == null)
        {
          faceplate = new Hidryco.HidrycoLib.Faceplates.Motor_Inversor_Automatico_Unico.Faceplate2();

          faceplate.SetConnectionInfo(this.TagName, this.ConnectionSymbolPath, this.ChannelId, this.ParentType);

          if (hmiManagementService != null)
            hmiManagementService.RegisterHMIFaceplate(faceplate);
        }
        return faceplate;
      }
    }
     
    private Hidryco.HidrycoLib.Faceplates.Motor_Inversor_Automatico_Unico.Faceplate4 Faceplate4
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        Hidryco.HidrycoLib.Faceplates.Motor_Inversor_Automatico_Unico.Faceplate4 faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (Hidryco.HidrycoLib.Faceplates.Motor_Inversor_Automatico_Unico.Faceplate4)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(Hidryco.HidrycoLib.Faceplates.Motor_Inversor_Automatico_Unico.Faceplate4));
        
        if (faceplate == null)
        {
          faceplate = new Hidryco.HidrycoLib.Faceplates.Motor_Inversor_Automatico_Unico.Faceplate4();

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

      if ("Faceplate1" == (string)openFaceplate.FaceplateType)
        hmiFaceplate = Faceplate1;

      if ("Faceplate2" == (string)openFaceplate.FaceplateType)
        hmiFaceplate = Faceplate2;

      if ("Faceplate4" == (string)openFaceplate.FaceplateType)
        hmiFaceplate = Faceplate4;

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

      if ("Faceplate2" == openFaceplate)
        hmiFaceplate = Faceplate2;

      if ("Faceplate4" == openFaceplate)
        hmiFaceplate = Faceplate4;

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

namespace Hidryco.HidrycoLib.Faceplates.Motor_Inversor_Automatico_Unico
{
  partial class Faceplate4
  {

    private Hidryco.HidrycoLib.Faceplates.Motor_Inversor_Automatico_Unico.Faceplate1 Faceplate1
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        Hidryco.HidrycoLib.Faceplates.Motor_Inversor_Automatico_Unico.Faceplate1 faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (Hidryco.HidrycoLib.Faceplates.Motor_Inversor_Automatico_Unico.Faceplate1)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(Hidryco.HidrycoLib.Faceplates.Motor_Inversor_Automatico_Unico.Faceplate1));
        
        if (faceplate == null)
        {
          faceplate = new Hidryco.HidrycoLib.Faceplates.Motor_Inversor_Automatico_Unico.Faceplate1();

          faceplate.SetConnectionInfo(this.TagName, this.ConnectionSymbolPath, this.ChannelId, this.ParentType);

          if (hmiManagementService != null)
            hmiManagementService.RegisterHMIFaceplate(faceplate);
        }
        return faceplate;
      }
    }
     
    private Hidryco.HidrycoLib.Faceplates.Motor_Inversor_Automatico_Unico.Faceplate2 Faceplate2
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        Hidryco.HidrycoLib.Faceplates.Motor_Inversor_Automatico_Unico.Faceplate2 faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (Hidryco.HidrycoLib.Faceplates.Motor_Inversor_Automatico_Unico.Faceplate2)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(Hidryco.HidrycoLib.Faceplates.Motor_Inversor_Automatico_Unico.Faceplate2));
        
        if (faceplate == null)
        {
          faceplate = new Hidryco.HidrycoLib.Faceplates.Motor_Inversor_Automatico_Unico.Faceplate2();

          faceplate.SetConnectionInfo(this.TagName, this.ConnectionSymbolPath, this.ChannelId, this.ParentType);

          if (hmiManagementService != null)
            hmiManagementService.RegisterHMIFaceplate(faceplate);
        }
        return faceplate;
      }
    }
     
    private Hidryco.HidrycoLib.Faceplates.Motor_Inversor_Automatico_Unico.Faceplate3 Faceplate3
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        Hidryco.HidrycoLib.Faceplates.Motor_Inversor_Automatico_Unico.Faceplate3 faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (Hidryco.HidrycoLib.Faceplates.Motor_Inversor_Automatico_Unico.Faceplate3)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(Hidryco.HidrycoLib.Faceplates.Motor_Inversor_Automatico_Unico.Faceplate3));
        
        if (faceplate == null)
        {
          faceplate = new Hidryco.HidrycoLib.Faceplates.Motor_Inversor_Automatico_Unico.Faceplate3();

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

      if ("Faceplate1" == (string)openFaceplate.FaceplateType)
        hmiFaceplate = Faceplate1;

      if ("Faceplate2" == (string)openFaceplate.FaceplateType)
        hmiFaceplate = Faceplate2;

      if ("Faceplate3" == (string)openFaceplate.FaceplateType)
        hmiFaceplate = Faceplate3;

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

      if ("Faceplate2" == openFaceplate)
        hmiFaceplate = Faceplate2;

      if ("Faceplate3" == openFaceplate)
        hmiFaceplate = Faceplate3;

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

namespace Hidryco.HidrycoLib.Symbols.Motor_Inversor_Automatico_Unico
{
  partial class sMotor
  {

    private Hidryco.HidrycoLib.Faceplates.Motor_Inversor_Automatico_Unico.Faceplate1 Faceplate1
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        Hidryco.HidrycoLib.Faceplates.Motor_Inversor_Automatico_Unico.Faceplate1 faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (Hidryco.HidrycoLib.Faceplates.Motor_Inversor_Automatico_Unico.Faceplate1)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(Hidryco.HidrycoLib.Faceplates.Motor_Inversor_Automatico_Unico.Faceplate1));
        
        if (faceplate == null)
        {
          faceplate = new Hidryco.HidrycoLib.Faceplates.Motor_Inversor_Automatico_Unico.Faceplate1();

          faceplate.SetConnectionInfo(this.TagName, this.SymbolPath, this.ChannelId, GetType());

          if (hmiManagementService != null)
            hmiManagementService.RegisterHMIFaceplate(faceplate);
        }
        return faceplate;
      }
    }
     
    private Hidryco.HidrycoLib.Faceplates.Motor_Inversor_Automatico_Unico.Faceplate2 Faceplate2
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        Hidryco.HidrycoLib.Faceplates.Motor_Inversor_Automatico_Unico.Faceplate2 faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (Hidryco.HidrycoLib.Faceplates.Motor_Inversor_Automatico_Unico.Faceplate2)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(Hidryco.HidrycoLib.Faceplates.Motor_Inversor_Automatico_Unico.Faceplate2));
        
        if (faceplate == null)
        {
          faceplate = new Hidryco.HidrycoLib.Faceplates.Motor_Inversor_Automatico_Unico.Faceplate2();

          faceplate.SetConnectionInfo(this.TagName, this.SymbolPath, this.ChannelId, GetType());

          if (hmiManagementService != null)
            hmiManagementService.RegisterHMIFaceplate(faceplate);
        }
        return faceplate;
      }
    }
     
    private Hidryco.HidrycoLib.Faceplates.Motor_Inversor_Automatico_Unico.Faceplate3 Faceplate3
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        Hidryco.HidrycoLib.Faceplates.Motor_Inversor_Automatico_Unico.Faceplate3 faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (Hidryco.HidrycoLib.Faceplates.Motor_Inversor_Automatico_Unico.Faceplate3)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(Hidryco.HidrycoLib.Faceplates.Motor_Inversor_Automatico_Unico.Faceplate3));
        
        if (faceplate == null)
        {
          faceplate = new Hidryco.HidrycoLib.Faceplates.Motor_Inversor_Automatico_Unico.Faceplate3();

          faceplate.SetConnectionInfo(this.TagName, this.SymbolPath, this.ChannelId, GetType());

          if (hmiManagementService != null)
            hmiManagementService.RegisterHMIFaceplate(faceplate);
        }
        return faceplate;
      }
    }
     
    private Hidryco.HidrycoLib.Faceplates.Motor_Inversor_Automatico_Unico.Faceplate4 Faceplate4
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        Hidryco.HidrycoLib.Faceplates.Motor_Inversor_Automatico_Unico.Faceplate4 faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (Hidryco.HidrycoLib.Faceplates.Motor_Inversor_Automatico_Unico.Faceplate4)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(Hidryco.HidrycoLib.Faceplates.Motor_Inversor_Automatico_Unico.Faceplate4));
        
        if (faceplate == null)
        {
          faceplate = new Hidryco.HidrycoLib.Faceplates.Motor_Inversor_Automatico_Unico.Faceplate4();

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

      if ("Faceplate2" == (string)openFaceplate.FaceplateType)
        hmiFaceplate = Faceplate2;

      if ("Faceplate3" == (string)openFaceplate.FaceplateType)
        hmiFaceplate = Faceplate3;

      if ("Faceplate4" == (string)openFaceplate.FaceplateType)
        hmiFaceplate = Faceplate4;

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

      if ("Faceplate2" == openFaceplate)
        hmiFaceplate = Faceplate2;

      if ("Faceplate3" == openFaceplate)
        hmiFaceplate = Faceplate3;

      if ("Faceplate4" == openFaceplate)
        hmiFaceplate = Faceplate4;

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

namespace Hidryco.HidrycoLib.Symbols.Motor_Inversor_Automatico_Unico
{
  partial class sSoprador
  {

    private Hidryco.HidrycoLib.Faceplates.Motor_Inversor_Automatico_Unico.Faceplate1 Faceplate1
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        Hidryco.HidrycoLib.Faceplates.Motor_Inversor_Automatico_Unico.Faceplate1 faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (Hidryco.HidrycoLib.Faceplates.Motor_Inversor_Automatico_Unico.Faceplate1)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(Hidryco.HidrycoLib.Faceplates.Motor_Inversor_Automatico_Unico.Faceplate1));
        
        if (faceplate == null)
        {
          faceplate = new Hidryco.HidrycoLib.Faceplates.Motor_Inversor_Automatico_Unico.Faceplate1();

          faceplate.SetConnectionInfo(this.TagName, this.SymbolPath, this.ChannelId, GetType());

          if (hmiManagementService != null)
            hmiManagementService.RegisterHMIFaceplate(faceplate);
        }
        return faceplate;
      }
    }
     
    private Hidryco.HidrycoLib.Faceplates.Motor_Inversor_Automatico_Unico.Faceplate2 Faceplate2
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        Hidryco.HidrycoLib.Faceplates.Motor_Inversor_Automatico_Unico.Faceplate2 faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (Hidryco.HidrycoLib.Faceplates.Motor_Inversor_Automatico_Unico.Faceplate2)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(Hidryco.HidrycoLib.Faceplates.Motor_Inversor_Automatico_Unico.Faceplate2));
        
        if (faceplate == null)
        {
          faceplate = new Hidryco.HidrycoLib.Faceplates.Motor_Inversor_Automatico_Unico.Faceplate2();

          faceplate.SetConnectionInfo(this.TagName, this.SymbolPath, this.ChannelId, GetType());

          if (hmiManagementService != null)
            hmiManagementService.RegisterHMIFaceplate(faceplate);
        }
        return faceplate;
      }
    }
     
    private Hidryco.HidrycoLib.Faceplates.Motor_Inversor_Automatico_Unico.Faceplate3 Faceplate3
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        Hidryco.HidrycoLib.Faceplates.Motor_Inversor_Automatico_Unico.Faceplate3 faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (Hidryco.HidrycoLib.Faceplates.Motor_Inversor_Automatico_Unico.Faceplate3)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(Hidryco.HidrycoLib.Faceplates.Motor_Inversor_Automatico_Unico.Faceplate3));
        
        if (faceplate == null)
        {
          faceplate = new Hidryco.HidrycoLib.Faceplates.Motor_Inversor_Automatico_Unico.Faceplate3();

          faceplate.SetConnectionInfo(this.TagName, this.SymbolPath, this.ChannelId, GetType());

          if (hmiManagementService != null)
            hmiManagementService.RegisterHMIFaceplate(faceplate);
        }
        return faceplate;
      }
    }
     
    private Hidryco.HidrycoLib.Faceplates.Motor_Inversor_Automatico_Unico.Faceplate4 Faceplate4
    {
      get
      { 
        if (IsOpenFaceplateSecure() == false)
          return null;

        Hidryco.HidrycoLib.Faceplates.Motor_Inversor_Automatico_Unico.Faceplate4 faceplate = null;
        
        IHMIManagementService hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
        if (hmiManagementService != null)
          faceplate = (Hidryco.HidrycoLib.Faceplates.Motor_Inversor_Automatico_Unico.Faceplate4)hmiManagementService.GetRegisteredHMIFaceplate(MapPath, typeof(Hidryco.HidrycoLib.Faceplates.Motor_Inversor_Automatico_Unico.Faceplate4));
        
        if (faceplate == null)
        {
          faceplate = new Hidryco.HidrycoLib.Faceplates.Motor_Inversor_Automatico_Unico.Faceplate4();

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

      if ("Faceplate2" == (string)openFaceplate.FaceplateType)
        hmiFaceplate = Faceplate2;

      if ("Faceplate3" == (string)openFaceplate.FaceplateType)
        hmiFaceplate = Faceplate3;

      if ("Faceplate4" == (string)openFaceplate.FaceplateType)
        hmiFaceplate = Faceplate4;

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

      if ("Faceplate2" == openFaceplate)
        hmiFaceplate = Faceplate2;

      if ("Faceplate3" == openFaceplate)
        hmiFaceplate = Faceplate3;

      if ("Faceplate4" == openFaceplate)
        hmiFaceplate = Faceplate4;

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
#endregion Motor_Inversor_Automatico_Unico_HMI;

#endregion Definitions;

