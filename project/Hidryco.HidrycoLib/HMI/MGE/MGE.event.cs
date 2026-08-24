/*
 * Criado pelo EcoStruxure Automation Expert.
 * Usuário:  
 * Data: 17/03/2026
 * Tempo: 08:12
 * 
 */
using System;
using NxtControl.GuiFramework;
using NxtControl.Services;

#region Definitions;
#region #MGE_HMI;

namespace Hidryco.HidrycoLib.Symbols.MGE
{

  public class REQEventArgs : System.EventArgs
  {
    IHMIAccessorService accessorService;
    int channelId;
    int cookie; 
    int eventIndex;

    public REQEventArgs(int channelId, int cookie, int eventIndex)
    {
      this.accessorService = (IHMIAccessorService)ServiceProvider.GetService(typeof(IHMIAccessorService));
      this.channelId = channelId;
      this.cookie = cookie;
      this.eventIndex = eventIndex;
    }
    public bool Get_TensaoAB(ref System.Single value)
    {
      if (accessorService == null)
        return false;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,0, ref var);
      if (ret) value = (System.Single) var;
      return ret;
    }

    public System.Single? TensaoAB
    { get {
      if (accessorService == null)
        return null;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,0, ref var);
      if (!ret) return null;
      return (System.Single) var;
    }  }

    public bool Get_TensaoBC(ref System.Single value)
    {
      if (accessorService == null)
        return false;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,1, ref var);
      if (ret) value = (System.Single) var;
      return ret;
    }

    public System.Single? TensaoBC
    { get {
      if (accessorService == null)
        return null;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,1, ref var);
      if (!ret) return null;
      return (System.Single) var;
    }  }

    public bool Get_TensaoCA(ref System.Single value)
    {
      if (accessorService == null)
        return false;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,2, ref var);
      if (ret) value = (System.Single) var;
      return ret;
    }

    public System.Single? TensaoCA
    { get {
      if (accessorService == null)
        return null;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,2, ref var);
      if (!ret) return null;
      return (System.Single) var;
    }  }

    public bool Get_TensaoAN(ref System.Single value)
    {
      if (accessorService == null)
        return false;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,3, ref var);
      if (ret) value = (System.Single) var;
      return ret;
    }

    public System.Single? TensaoAN
    { get {
      if (accessorService == null)
        return null;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,3, ref var);
      if (!ret) return null;
      return (System.Single) var;
    }  }

    public bool Get_TensaoBN(ref System.Single value)
    {
      if (accessorService == null)
        return false;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,4, ref var);
      if (ret) value = (System.Single) var;
      return ret;
    }

    public System.Single? TensaoBN
    { get {
      if (accessorService == null)
        return null;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,4, ref var);
      if (!ret) return null;
      return (System.Single) var;
    }  }

    public bool Get_TensaoCN(ref System.Single value)
    {
      if (accessorService == null)
        return false;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,5, ref var);
      if (ret) value = (System.Single) var;
      return ret;
    }

    public System.Single? TensaoCN
    { get {
      if (accessorService == null)
        return null;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,5, ref var);
      if (!ret) return null;
      return (System.Single) var;
    }  }

    public bool Get_CorrenteA(ref System.Single value)
    {
      if (accessorService == null)
        return false;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,6, ref var);
      if (ret) value = (System.Single) var;
      return ret;
    }

    public System.Single? CorrenteA
    { get {
      if (accessorService == null)
        return null;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,6, ref var);
      if (!ret) return null;
      return (System.Single) var;
    }  }

    public bool Get_CorrenteB(ref System.Single value)
    {
      if (accessorService == null)
        return false;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,7, ref var);
      if (ret) value = (System.Single) var;
      return ret;
    }

    public System.Single? CorrenteB
    { get {
      if (accessorService == null)
        return null;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,7, ref var);
      if (!ret) return null;
      return (System.Single) var;
    }  }

    public bool Get_CorrenteC(ref System.Single value)
    {
      if (accessorService == null)
        return false;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,8, ref var);
      if (ret) value = (System.Single) var;
      return ret;
    }

    public System.Single? CorrenteC
    { get {
      if (accessorService == null)
        return null;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,8, ref var);
      if (!ret) return null;
      return (System.Single) var;
    }  }

    public bool Get_PotenciaAtivaA(ref System.Single value)
    {
      if (accessorService == null)
        return false;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,9, ref var);
      if (ret) value = (System.Single) var;
      return ret;
    }

    public System.Single? PotenciaAtivaA
    { get {
      if (accessorService == null)
        return null;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,9, ref var);
      if (!ret) return null;
      return (System.Single) var;
    }  }

    public bool Get_PotenciaAtivaB(ref System.Single value)
    {
      if (accessorService == null)
        return false;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,10, ref var);
      if (ret) value = (System.Single) var;
      return ret;
    }

    public System.Single? PotenciaAtivaB
    { get {
      if (accessorService == null)
        return null;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,10, ref var);
      if (!ret) return null;
      return (System.Single) var;
    }  }

    public bool Get_PotenciaAtivaC(ref System.Single value)
    {
      if (accessorService == null)
        return false;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,11, ref var);
      if (ret) value = (System.Single) var;
      return ret;
    }

    public System.Single? PotenciaAtivaC
    { get {
      if (accessorService == null)
        return null;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,11, ref var);
      if (!ret) return null;
      return (System.Single) var;
    }  }

    public bool Get_PotenciaAtivaTotal(ref System.Single value)
    {
      if (accessorService == null)
        return false;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,12, ref var);
      if (ret) value = (System.Single) var;
      return ret;
    }

    public System.Single? PotenciaAtivaTotal
    { get {
      if (accessorService == null)
        return null;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,12, ref var);
      if (!ret) return null;
      return (System.Single) var;
    }  }

    public bool Get_PotenciaReativaA(ref System.Single value)
    {
      if (accessorService == null)
        return false;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,13, ref var);
      if (ret) value = (System.Single) var;
      return ret;
    }

    public System.Single? PotenciaReativaA
    { get {
      if (accessorService == null)
        return null;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,13, ref var);
      if (!ret) return null;
      return (System.Single) var;
    }  }

    public bool Get_PotenciaReativaB(ref System.Single value)
    {
      if (accessorService == null)
        return false;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,14, ref var);
      if (ret) value = (System.Single) var;
      return ret;
    }

    public System.Single? PotenciaReativaB
    { get {
      if (accessorService == null)
        return null;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,14, ref var);
      if (!ret) return null;
      return (System.Single) var;
    }  }

    public bool Get_PotenciaReativaC(ref System.Single value)
    {
      if (accessorService == null)
        return false;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,15, ref var);
      if (ret) value = (System.Single) var;
      return ret;
    }

    public System.Single? PotenciaReativaC
    { get {
      if (accessorService == null)
        return null;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,15, ref var);
      if (!ret) return null;
      return (System.Single) var;
    }  }

    public bool Get_PotenciaReativaTotal(ref System.Single value)
    {
      if (accessorService == null)
        return false;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,16, ref var);
      if (ret) value = (System.Single) var;
      return ret;
    }

    public System.Single? PotenciaReativaTotal
    { get {
      if (accessorService == null)
        return null;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,16, ref var);
      if (!ret) return null;
      return (System.Single) var;
    }  }

    public bool Get_Frequencia(ref System.Single value)
    {
      if (accessorService == null)
        return false;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,17, ref var);
      if (ret) value = (System.Single) var;
      return ret;
    }

    public System.Single? Frequencia
    { get {
      if (accessorService == null)
        return null;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,17, ref var);
      if (!ret) return null;
      return (System.Single) var;
    }  }

    public bool Get_FatorPotenciaTotal(ref System.Single value)
    {
      if (accessorService == null)
        return false;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,18, ref var);
      if (ret) value = (System.Single) var;
      return ret;
    }

    public System.Single? FatorPotenciaTotal
    { get {
      if (accessorService == null)
        return null;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,18, ref var);
      if (!ret) return null;
      return (System.Single) var;
    }  }

    public bool Get_PotenciaAparenteTotal(ref System.Single value)
    {
      if (accessorService == null)
        return false;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,19, ref var);
      if (ret) value = (System.Single) var;
      return ret;
    }

    public System.Single? PotenciaAparenteTotal
    { get {
      if (accessorService == null)
        return null;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,19, ref var);
      if (!ret) return null;
      return (System.Single) var;
    }  }


  }

}

namespace Hidryco.HidrycoLib.Symbols.MGE
{
  partial class sDefault
  {

    private event EventHandler<Hidryco.HidrycoLib.Symbols.MGE.REQEventArgs> REQ_Fired;

    protected override void OnEndInit()
    {
      if (REQ_Fired != null)
        AttachEventInput(0);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (REQ_Fired != null)
          {
            try
            {
              REQ_Fired(this, new Hidryco.HidrycoLib.Symbols.MGE.REQEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REQ_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }

  }
}

namespace Hidryco.HidrycoLib.Faceplates.MGE
{
  partial class Faceplate1
  {

    private event EventHandler<Hidryco.HidrycoLib.Symbols.MGE.REQEventArgs> REQ_Fired;

    protected override void OnEndInit()
    {
      if (REQ_Fired != null)
        AttachEventInput(0);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (REQ_Fired != null)
          {
            try
            {
              REQ_Fired(this, new Hidryco.HidrycoLib.Symbols.MGE.REQEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REQ_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }

  }
}
#endregion #MGE_HMI;

#endregion Definitions;
