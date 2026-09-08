/*
 * Created by EcoStruxure Automation Expert.
 * User: SESA685388
 * Date: 10/24/2023
 * Time: 10:47 PM
 * 
 */
using System;
using NxtControl.GuiFramework;
using NxtControl.Services;

#region Definitions;
#region #CAerationLogic_HMI;

namespace SE.Nereda.Symbols.CAerationLogic
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

}

namespace SE.Nereda.Symbols.CAerationLogic
{

  public class AERATION_PAREventArgs : System.EventArgs
  {
    public AERATION_PAREventArgs()
    {
    }
    private System.Single? C2_IN_field = null;
    public System.Single? C2_IN
    {
       get { return C2_IN_field; }
       set { C2_IN_field = value; }
    }
    private System.Single? C3_IN_field = null;
    public System.Single? C3_IN
    {
       get { return C3_IN_field; }
       set { C3_IN_field = value; }
    }

  }

}

namespace SE.Nereda.Symbols.CAerationLogic
{}

namespace SE.Nereda.Symbols.CAerationLogic
{}

namespace SE.Nereda.Faceplates.CAerationLogic
{}

namespace SE.Nereda.Symbols.CAerationLogic
{
  partial class sGraph
  {

    private event EventHandler<SE.Nereda.Symbols.CAerationLogic.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    public bool FireEvent_AERATION_PAR(System.Single C2_IN, System.Single C3_IN)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {C2_IN, C3_IN});
    }
    public bool FireEvent_AERATION_PAR(SE.Nereda.Symbols.CAerationLogic.AERATION_PAREventArgs ea)
    {
      object[] _values_ = new object[2];
      if (ea.C2_IN.HasValue) _values_[0] = ea.C2_IN.Value;
      if (ea.C3_IN.HasValue) _values_[1] = ea.C3_IN.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_AERATION_PAR(System.Single C2_IN, bool ignore_C2_IN, System.Single C3_IN, bool ignore_C3_IN)
    {
      object[] _values_ = new object[2];
      if (!ignore_C2_IN) _values_[0] = C2_IN;
      if (!ignore_C3_IN) _values_[1] = C3_IN;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }

  }
}

namespace SE.Nereda.Symbols.CAerationLogic
{
  partial class sSettingsBtn
  {

    private event EventHandler<SE.Nereda.Symbols.CAerationLogic.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    protected override void OnEndInit()
    {
      if (LOAD_PERS_DATA_Fired != null)
        AttachEventInput(0);

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
              LOAD_PERS_DATA_Fired(this, new SE.Nereda.Symbols.CAerationLogic.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","LOAD_PERS_DATA_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_AERATION_PAR(System.Single C2_IN, System.Single C3_IN)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {C2_IN, C3_IN});
    }
    public bool FireEvent_AERATION_PAR(SE.Nereda.Symbols.CAerationLogic.AERATION_PAREventArgs ea)
    {
      object[] _values_ = new object[2];
      if (ea.C2_IN.HasValue) _values_[0] = ea.C2_IN.Value;
      if (ea.C3_IN.HasValue) _values_[1] = ea.C3_IN.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_AERATION_PAR(System.Single C2_IN, bool ignore_C2_IN, System.Single C3_IN, bool ignore_C3_IN)
    {
      object[] _values_ = new object[2];
      if (!ignore_C2_IN) _values_[0] = C2_IN;
      if (!ignore_C3_IN) _values_[1] = C3_IN;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }

  }
}

namespace SE.Nereda.Faceplates.CAerationLogic
{
  partial class fpSettingsS
  {

    private event EventHandler<SE.Nereda.Symbols.CAerationLogic.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

    protected override void OnEndInit()
    {
      if (LOAD_PERS_DATA_Fired != null)
        AttachEventInput(0);

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
              LOAD_PERS_DATA_Fired(this, new SE.Nereda.Symbols.CAerationLogic.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","LOAD_PERS_DATA_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_AERATION_PAR(System.Single C2_IN, System.Single C3_IN)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {C2_IN, C3_IN});
    }
    public bool FireEvent_AERATION_PAR(SE.Nereda.Symbols.CAerationLogic.AERATION_PAREventArgs ea)
    {
      object[] _values_ = new object[2];
      if (ea.C2_IN.HasValue) _values_[0] = ea.C2_IN.Value;
      if (ea.C3_IN.HasValue) _values_[1] = ea.C3_IN.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_AERATION_PAR(System.Single C2_IN, bool ignore_C2_IN, System.Single C3_IN, bool ignore_C3_IN)
    {
      object[] _values_ = new object[2];
      if (!ignore_C2_IN) _values_[0] = C2_IN;
      if (!ignore_C3_IN) _values_[1] = C3_IN;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }

  }
}

namespace SE.Nereda.Symbols.CAerationLogic
{}
#endregion #CAerationLogic_HMI;

#endregion Definitions;
