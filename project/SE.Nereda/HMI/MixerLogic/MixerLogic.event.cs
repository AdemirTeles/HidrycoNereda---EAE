/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 6/15/2026
 * Time: 3:55 PM
 * 
 */
using System;
using NxtControl.GuiFramework;
using NxtControl.Services;

#region Definitions;
#region #MixerLogic_HMI;

namespace SE.Nereda.Symbols.MixerLogic
{

  public class LOAD_PERS_DATAEventArgs : System.EventArgs
  {
    IHMIAccessorService accessorService;
    int channelId;
    int cookie; 
    int eventIndex;

    public LOAD_PERS_DATAEventArgs(int channelId, int cookie, int eventIndex)
    {
      this.accessorService = (IHMIAccessorService)ServiceProvider.GetService(typeof(IHMIAccessorService));
      this.channelId = channelId;
      this.cookie = cookie;
      this.eventIndex = eventIndex;
    }

  }

  public class MIXEREventArgs : System.EventArgs
  {
    IHMIAccessorService accessorService;
    int channelId;
    int cookie; 
    int eventIndex;

    public MIXEREventArgs(int channelId, int cookie, int eventIndex)
    {
      this.accessorService = (IHMIAccessorService)ServiceProvider.GetService(typeof(IHMIAccessorService));
      this.channelId = channelId;
      this.cookie = cookie;
      this.eventIndex = eventIndex;
    }
    public bool Get_FbMixerRun(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,0, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? FbMixerRun
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,0, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }


  }

}

namespace SE.Nereda.Symbols.MixerLogic
{

  public class CNF_SPEEDEventArgs : System.EventArgs
  {
    public CNF_SPEEDEventArgs()
    {
    }
    private System.Single? SpeedSp_field = null;
    public System.Single? SpeedSp
    {
       get { return SpeedSp_field; }
       set { SpeedSp_field = value; }
    }

  }

}

namespace SE.Nereda.Symbols.MixerLogic
{
  partial class sDefault
  {

    private event EventHandler<SE.Nereda.Symbols.MixerLogic.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    private event EventHandler<SE.Nereda.Symbols.MixerLogic.MIXEREventArgs> MIXER_Fired;

    protected override void OnEndInit()
    {
      if (LOAD_PERS_DATA_Fired != null)
        AttachEventInput(0);
      if (MIXER_Fired != null)
        AttachEventInput(1);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (LOAD_PERS_DATA_Fired != null)
          {
            try
            {
              LOAD_PERS_DATA_Fired(this, new SE.Nereda.Symbols.MixerLogic.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","LOAD_PERS_DATA_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 1:
          if (MIXER_Fired != null)
          {
            try
            {
              MIXER_Fired(this, new SE.Nereda.Symbols.MixerLogic.MIXEREventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","MIXER_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_CNF_SPEED(System.Single SpeedSp)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {SpeedSp});
    }
    public bool FireEvent_CNF_SPEED(SE.Nereda.Symbols.MixerLogic.CNF_SPEEDEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.SpeedSp.HasValue) _values_[0] = ea.SpeedSp.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_CNF_SPEED(System.Single SpeedSp, bool ignore_SpeedSp)
    {
      object[] _values_ = new object[1];
      if (!ignore_SpeedSp) _values_[0] = SpeedSp;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }

  }
}

namespace SE.Nereda.Symbols.MixerLogic
{
  partial class sMixer
  {

    private event EventHandler<SE.Nereda.Symbols.MixerLogic.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    private event EventHandler<SE.Nereda.Symbols.MixerLogic.MIXEREventArgs> MIXER_Fired;

    protected override void OnEndInit()
    {
      if (LOAD_PERS_DATA_Fired != null)
        AttachEventInput(0);
      if (MIXER_Fired != null)
        AttachEventInput(1);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (LOAD_PERS_DATA_Fired != null)
          {
            try
            {
              LOAD_PERS_DATA_Fired(this, new SE.Nereda.Symbols.MixerLogic.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","LOAD_PERS_DATA_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 1:
          if (MIXER_Fired != null)
          {
            try
            {
              MIXER_Fired(this, new SE.Nereda.Symbols.MixerLogic.MIXEREventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","MIXER_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_CNF_SPEED(System.Single SpeedSp)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {SpeedSp});
    }
    public bool FireEvent_CNF_SPEED(SE.Nereda.Symbols.MixerLogic.CNF_SPEEDEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.SpeedSp.HasValue) _values_[0] = ea.SpeedSp.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_CNF_SPEED(System.Single SpeedSp, bool ignore_SpeedSp)
    {
      object[] _values_ = new object[1];
      if (!ignore_SpeedSp) _values_[0] = SpeedSp;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }

  }
}
#endregion #MixerLogic_HMI;

#endregion Definitions;
