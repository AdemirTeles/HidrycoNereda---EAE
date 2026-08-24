/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 7/15/2026
 * Time: 2:26 PM
 * 
 */
using System;
using NxtControl.GuiFramework;
using NxtControl.Services;

#region Definitions;
#region #ReactorAvCtrl_HMI;

namespace SE.Nereda.Symbols.ReactorAvCtrl
{

  public class FB_R_AVEventArgs : System.EventArgs
  {
    IHMIAccessorService accessorService;
    int channelId;
    int cookie; 
    int eventIndex;

    public FB_R_AVEventArgs(int channelId, int cookie, int eventIndex)
    {
      this.accessorService = (IHMIAccessorService)ServiceProvider.GetService(typeof(IHMIAccessorService));
      this.channelId = channelId;
      this.cookie = cookie;
      this.eventIndex = eventIndex;
    }
    public bool Get_FbAvR1(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,0, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? FbAvR1
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,0, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_FbAvR2(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,1, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? FbAvR2
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,1, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_FbAvR3(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,2, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? FbAvR3
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,2, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_FbAvR4(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,3, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? FbAvR4
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,3, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_FbAvR5(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,4, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? FbAvR5
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,4, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_FbAvR6(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,5, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? FbAvR6
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,5, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }


  }

}

namespace SE.Nereda.Symbols.ReactorAvCtrl
{

  public class FORCE_AVEventArgs : System.EventArgs
  {
    public FORCE_AVEventArgs()
    {
    }
    private System.Boolean? ForceNotAvR1_field = null;
    public System.Boolean? ForceNotAvR1
    {
       get { return ForceNotAvR1_field; }
       set { ForceNotAvR1_field = value; }
    }
    private System.Boolean? ForceNotAvR2_field = null;
    public System.Boolean? ForceNotAvR2
    {
       get { return ForceNotAvR2_field; }
       set { ForceNotAvR2_field = value; }
    }
    private System.Boolean? ForceNotAvR3_field = null;
    public System.Boolean? ForceNotAvR3
    {
       get { return ForceNotAvR3_field; }
       set { ForceNotAvR3_field = value; }
    }
    private System.Boolean? ForceNotAvR4_field = null;
    public System.Boolean? ForceNotAvR4
    {
       get { return ForceNotAvR4_field; }
       set { ForceNotAvR4_field = value; }
    }
    private System.Boolean? ForceNotAvR5_field = null;
    public System.Boolean? ForceNotAvR5
    {
       get { return ForceNotAvR5_field; }
       set { ForceNotAvR5_field = value; }
    }
    private System.Boolean? ForceNotAvR6_field = null;
    public System.Boolean? ForceNotAvR6
    {
       get { return ForceNotAvR6_field; }
       set { ForceNotAvR6_field = value; }
    }

  }

}

namespace SE.Nereda.Symbols.ReactorAvCtrl
{
  partial class sDefault
  {

    private event EventHandler<SE.Nereda.Symbols.ReactorAvCtrl.FB_R_AVEventArgs> FB_R_AV_Fired;

    protected override void OnEndInit()
    {
      if (FB_R_AV_Fired != null)
        AttachEventInput(0);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (FB_R_AV_Fired != null)
          {
            try
            {
              FB_R_AV_Fired(this, new SE.Nereda.Symbols.ReactorAvCtrl.FB_R_AVEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","FB_R_AV_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_FORCE_AV(System.Boolean ForceNotAvR1, System.Boolean ForceNotAvR2, System.Boolean ForceNotAvR3, System.Boolean ForceNotAvR4, System.Boolean ForceNotAvR5, System.Boolean ForceNotAvR6)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {ForceNotAvR1, ForceNotAvR2, ForceNotAvR3, ForceNotAvR4, ForceNotAvR5, ForceNotAvR6});
    }
    public bool FireEvent_FORCE_AV(SE.Nereda.Symbols.ReactorAvCtrl.FORCE_AVEventArgs ea)
    {
      object[] _values_ = new object[6];
      if (ea.ForceNotAvR1.HasValue) _values_[0] = ea.ForceNotAvR1.Value;
      if (ea.ForceNotAvR2.HasValue) _values_[1] = ea.ForceNotAvR2.Value;
      if (ea.ForceNotAvR3.HasValue) _values_[2] = ea.ForceNotAvR3.Value;
      if (ea.ForceNotAvR4.HasValue) _values_[3] = ea.ForceNotAvR4.Value;
      if (ea.ForceNotAvR5.HasValue) _values_[4] = ea.ForceNotAvR5.Value;
      if (ea.ForceNotAvR6.HasValue) _values_[5] = ea.ForceNotAvR6.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_FORCE_AV(System.Boolean ForceNotAvR1, bool ignore_ForceNotAvR1, System.Boolean ForceNotAvR2, bool ignore_ForceNotAvR2, System.Boolean ForceNotAvR3, bool ignore_ForceNotAvR3, System.Boolean ForceNotAvR4, bool ignore_ForceNotAvR4, System.Boolean ForceNotAvR5, bool ignore_ForceNotAvR5, System.Boolean ForceNotAvR6, bool ignore_ForceNotAvR6)
    {
      object[] _values_ = new object[6];
      if (!ignore_ForceNotAvR1) _values_[0] = ForceNotAvR1;
      if (!ignore_ForceNotAvR2) _values_[1] = ForceNotAvR2;
      if (!ignore_ForceNotAvR3) _values_[2] = ForceNotAvR3;
      if (!ignore_ForceNotAvR4) _values_[3] = ForceNotAvR4;
      if (!ignore_ForceNotAvR5) _values_[4] = ForceNotAvR5;
      if (!ignore_ForceNotAvR6) _values_[5] = ForceNotAvR6;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }

  }
}
#endregion #ReactorAvCtrl_HMI;

#endregion Definitions;
