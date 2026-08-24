/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 8/3/2026
 * Time: 2:47 PM
 * 
 */
using System;
using NxtControl.GuiFramework;
using NxtControl.Services;

#region Definitions;
#region #AutoResetCdt_HMI;

namespace SE.Nereda.Symbols.AutoResetCdt
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

  public class CURR_R_NBREventArgs : System.EventArgs
  {
    IHMIAccessorService accessorService;
    int channelId;
    int cookie; 
    int eventIndex;

    public CURR_R_NBREventArgs(int channelId, int cookie, int eventIndex)
    {
      this.accessorService = (IHMIAccessorService)ServiceProvider.GetService(typeof(IHMIAccessorService));
      this.channelId = channelId;
      this.cookie = cookie;
      this.eventIndex = eventIndex;
    }
    public bool Get_CurrResetNbr(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,0, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? CurrResetNbr
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,0, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }


  }

}

namespace SE.Nereda.Symbols.AutoResetCdt
{

  public class PAREventArgs : System.EventArgs
  {
    public PAREventArgs()
    {
    }
    private NxtControl.GuiFramework.Time? TimeOut_field = null;
    public NxtControl.GuiFramework.Time? TimeOut
    {
       get { return TimeOut_field; }
       set { TimeOut_field = value; }
    }
    private System.Int16? ResetNbr_field = null;
    public System.Int16? ResetNbr
    {
       get { return ResetNbr_field; }
       set { ResetNbr_field = value; }
    }

  }

}

namespace SE.Nereda.Symbols.AutoResetCdt
{
  partial class sDefault
  {

    private event EventHandler<SE.Nereda.Symbols.AutoResetCdt.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    private event EventHandler<SE.Nereda.Symbols.AutoResetCdt.CURR_R_NBREventArgs> CURR_R_NBR_Fired;

    protected override void OnEndInit()
    {
      if (LOAD_PERS_DATA_Fired != null)
        AttachEventInput(0);
      if (CURR_R_NBR_Fired != null)
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
              LOAD_PERS_DATA_Fired(this, new SE.Nereda.Symbols.AutoResetCdt.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
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
          if (CURR_R_NBR_Fired != null)
          {
            try
            {
              CURR_R_NBR_Fired(this, new SE.Nereda.Symbols.AutoResetCdt.CURR_R_NBREventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","CURR_R_NBR_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_PAR(NxtControl.GuiFramework.Time TimeOut, System.Int16 ResetNbr)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {TimeOut, ResetNbr});
    }
    public bool FireEvent_PAR(SE.Nereda.Symbols.AutoResetCdt.PAREventArgs ea)
    {
      object[] _values_ = new object[2];
      if (ea.TimeOut.HasValue) _values_[0] = ea.TimeOut.Value;
      if (ea.ResetNbr.HasValue) _values_[1] = ea.ResetNbr.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_PAR(NxtControl.GuiFramework.Time TimeOut, bool ignore_TimeOut, System.Int16 ResetNbr, bool ignore_ResetNbr)
    {
      object[] _values_ = new object[2];
      if (!ignore_TimeOut) _values_[0] = TimeOut;
      if (!ignore_ResetNbr) _values_[1] = ResetNbr;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }

  }
}

namespace SE.Nereda.Faceplates.AutoResetCdt
{
  partial class fpReset
  {

    private event EventHandler<SE.Nereda.Symbols.AutoResetCdt.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    private event EventHandler<SE.Nereda.Symbols.AutoResetCdt.CURR_R_NBREventArgs> CURR_R_NBR_Fired;

    protected override void OnEndInit()
    {
      if (LOAD_PERS_DATA_Fired != null)
        AttachEventInput(0);
      if (CURR_R_NBR_Fired != null)
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
              LOAD_PERS_DATA_Fired(this, new SE.Nereda.Symbols.AutoResetCdt.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
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
          if (CURR_R_NBR_Fired != null)
          {
            try
            {
              CURR_R_NBR_Fired(this, new SE.Nereda.Symbols.AutoResetCdt.CURR_R_NBREventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","CURR_R_NBR_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_PAR(NxtControl.GuiFramework.Time TimeOut, System.Int16 ResetNbr)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {TimeOut, ResetNbr});
    }
    public bool FireEvent_PAR(SE.Nereda.Symbols.AutoResetCdt.PAREventArgs ea)
    {
      object[] _values_ = new object[2];
      if (ea.TimeOut.HasValue) _values_[0] = ea.TimeOut.Value;
      if (ea.ResetNbr.HasValue) _values_[1] = ea.ResetNbr.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_PAR(NxtControl.GuiFramework.Time TimeOut, bool ignore_TimeOut, System.Int16 ResetNbr, bool ignore_ResetNbr)
    {
      object[] _values_ = new object[2];
      if (!ignore_TimeOut) _values_[0] = TimeOut;
      if (!ignore_ResetNbr) _values_[1] = ResetNbr;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }

  }
}
#endregion #AutoResetCdt_HMI;

#endregion Definitions;
