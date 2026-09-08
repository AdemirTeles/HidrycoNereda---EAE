/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 6/7/2026
 * Time: 4:40 PM
 * 
 */
using System;
using NxtControl.GuiFramework;
using NxtControl.Services;

#region Definitions;
#region #CmdAerate_HMI;

namespace SE.Nereda.Symbols.CmdAerate
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

namespace SE.Nereda.Symbols.CmdAerate
{

  public class AUTO_CAP_BLWREventArgs : System.EventArgs
  {
    public AUTO_CAP_BLWREventArgs()
    {
    }
    private System.Single? RunCapacity_Blower_field = null;
    public System.Single? RunCapacity_Blower
    {
       get { return RunCapacity_Blower_field; }
       set { RunCapacity_Blower_field = value; }
    }

  }

  public class AIR_VLV_AER_GRIDEventArgs : System.EventArgs
  {
    public AIR_VLV_AER_GRIDEventArgs()
    {
    }
    private System.Boolean? AirValveAerationGrid_field = null;
    public System.Boolean? AirValveAerationGrid
    {
       get { return AirValveAerationGrid_field; }
       set { AirValveAerationGrid_field = value; }
    }

  }

  public class AIR_VLV_INF_GRIDEventArgs : System.EventArgs
  {
    public AIR_VLV_INF_GRIDEventArgs()
    {
    }
    private System.Boolean? AirValveInfluentGrid_field = null;
    public System.Boolean? AirValveInfluentGrid
    {
       get { return AirValveInfluentGrid_field; }
       set { AirValveInfluentGrid_field = value; }
    }

  }

  public class MAN_CAP_BLWREventArgs : System.EventArgs
  {
    public MAN_CAP_BLWREventArgs()
    {
    }
    private System.Single? ManCapacity_Blower_field = null;
    public System.Single? ManCapacity_Blower
    {
       get { return ManCapacity_Blower_field; }
       set { ManCapacity_Blower_field = value; }
    }

  }

  public class AIR_VLV_AER_GRID_MANEventArgs : System.EventArgs
  {
    public AIR_VLV_AER_GRID_MANEventArgs()
    {
    }
    private System.Boolean? AirValveAerationGridMan_field = null;
    public System.Boolean? AirValveAerationGridMan
    {
       get { return AirValveAerationGridMan_field; }
       set { AirValveAerationGridMan_field = value; }
    }

  }

  public class AIR_VLV_INF_GRID_MANEventArgs : System.EventArgs
  {
    public AIR_VLV_INF_GRID_MANEventArgs()
    {
    }
    private System.Boolean? AirValveInfluentGridMan_field = null;
    public System.Boolean? AirValveInfluentGridMan
    {
       get { return AirValveInfluentGridMan_field; }
       set { AirValveInfluentGridMan_field = value; }
    }

  }

  public class D_C_SELECTOREventArgs : System.EventArgs
  {
    public D_C_SELECTOREventArgs()
    {
    }
    private System.Boolean? D_C_Sel_field = null;
    public System.Boolean? D_C_Sel
    {
       get { return D_C_Sel_field; }
       set { D_C_Sel_field = value; }
    }

  }

}

namespace SE.Nereda.Symbols.CmdAerate
{
  partial class sDefault
  {

    private event EventHandler<SE.Nereda.Symbols.CmdAerate.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

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
              LOAD_PERS_DATA_Fired(this, new SE.Nereda.Symbols.CmdAerate.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
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
    public bool FireEvent_AUTO_CAP_BLWR(System.Single RunCapacity_Blower)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {RunCapacity_Blower});
    }
    public bool FireEvent_AUTO_CAP_BLWR(SE.Nereda.Symbols.CmdAerate.AUTO_CAP_BLWREventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.RunCapacity_Blower.HasValue) _values_[0] = ea.RunCapacity_Blower.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_AUTO_CAP_BLWR(System.Single RunCapacity_Blower, bool ignore_RunCapacity_Blower)
    {
      object[] _values_ = new object[1];
      if (!ignore_RunCapacity_Blower) _values_[0] = RunCapacity_Blower;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_AIR_VLV_AER_GRID(System.Boolean AirValveAerationGrid)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {AirValveAerationGrid});
    }
    public bool FireEvent_AIR_VLV_AER_GRID(SE.Nereda.Symbols.CmdAerate.AIR_VLV_AER_GRIDEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.AirValveAerationGrid.HasValue) _values_[0] = ea.AirValveAerationGrid.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_AIR_VLV_AER_GRID(System.Boolean AirValveAerationGrid, bool ignore_AirValveAerationGrid)
    {
      object[] _values_ = new object[1];
      if (!ignore_AirValveAerationGrid) _values_[0] = AirValveAerationGrid;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_AIR_VLV_INF_GRID(System.Boolean AirValveInfluentGrid)
    {
      return ((IHMIAccessorOutput)this).FireEvent(2, new object[] {AirValveInfluentGrid});
    }
    public bool FireEvent_AIR_VLV_INF_GRID(SE.Nereda.Symbols.CmdAerate.AIR_VLV_INF_GRIDEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.AirValveInfluentGrid.HasValue) _values_[0] = ea.AirValveInfluentGrid.Value;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_AIR_VLV_INF_GRID(System.Boolean AirValveInfluentGrid, bool ignore_AirValveInfluentGrid)
    {
      object[] _values_ = new object[1];
      if (!ignore_AirValveInfluentGrid) _values_[0] = AirValveInfluentGrid;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_MAN_CAP_BLWR(System.Single ManCapacity_Blower)
    {
      return ((IHMIAccessorOutput)this).FireEvent(3, new object[] {ManCapacity_Blower});
    }
    public bool FireEvent_MAN_CAP_BLWR(SE.Nereda.Symbols.CmdAerate.MAN_CAP_BLWREventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.ManCapacity_Blower.HasValue) _values_[0] = ea.ManCapacity_Blower.Value;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_MAN_CAP_BLWR(System.Single ManCapacity_Blower, bool ignore_ManCapacity_Blower)
    {
      object[] _values_ = new object[1];
      if (!ignore_ManCapacity_Blower) _values_[0] = ManCapacity_Blower;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_AIR_VLV_AER_GRID_MAN(System.Boolean AirValveAerationGridMan)
    {
      return ((IHMIAccessorOutput)this).FireEvent(4, new object[] {AirValveAerationGridMan});
    }
    public bool FireEvent_AIR_VLV_AER_GRID_MAN(SE.Nereda.Symbols.CmdAerate.AIR_VLV_AER_GRID_MANEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.AirValveAerationGridMan.HasValue) _values_[0] = ea.AirValveAerationGridMan.Value;
      return ((IHMIAccessorOutput)this).FireEvent(4, _values_);
    }
    public bool FireEvent_AIR_VLV_AER_GRID_MAN(System.Boolean AirValveAerationGridMan, bool ignore_AirValveAerationGridMan)
    {
      object[] _values_ = new object[1];
      if (!ignore_AirValveAerationGridMan) _values_[0] = AirValveAerationGridMan;
      return ((IHMIAccessorOutput)this).FireEvent(4, _values_);
    }
    public bool FireEvent_AIR_VLV_INF_GRID_MAN(System.Boolean AirValveInfluentGridMan)
    {
      return ((IHMIAccessorOutput)this).FireEvent(5, new object[] {AirValveInfluentGridMan});
    }
    public bool FireEvent_AIR_VLV_INF_GRID_MAN(SE.Nereda.Symbols.CmdAerate.AIR_VLV_INF_GRID_MANEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.AirValveInfluentGridMan.HasValue) _values_[0] = ea.AirValveInfluentGridMan.Value;
      return ((IHMIAccessorOutput)this).FireEvent(5, _values_);
    }
    public bool FireEvent_AIR_VLV_INF_GRID_MAN(System.Boolean AirValveInfluentGridMan, bool ignore_AirValveInfluentGridMan)
    {
      object[] _values_ = new object[1];
      if (!ignore_AirValveInfluentGridMan) _values_[0] = AirValveInfluentGridMan;
      return ((IHMIAccessorOutput)this).FireEvent(5, _values_);
    }
    public bool FireEvent_D_C_SELECTOR(System.Boolean D_C_Sel)
    {
      return ((IHMIAccessorOutput)this).FireEvent(6, new object[] {D_C_Sel});
    }
    public bool FireEvent_D_C_SELECTOR(SE.Nereda.Symbols.CmdAerate.D_C_SELECTOREventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.D_C_Sel.HasValue) _values_[0] = ea.D_C_Sel.Value;
      return ((IHMIAccessorOutput)this).FireEvent(6, _values_);
    }
    public bool FireEvent_D_C_SELECTOR(System.Boolean D_C_Sel, bool ignore_D_C_Sel)
    {
      object[] _values_ = new object[1];
      if (!ignore_D_C_Sel) _values_[0] = D_C_Sel;
      return ((IHMIAccessorOutput)this).FireEvent(6, _values_);
    }

  }
}
#endregion #CmdAerate_HMI;

#endregion Definitions;
