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
#region #MSDCmd_HMI;

namespace SE.Nereda.Symbols.MSDCmd
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

namespace SE.Nereda.Symbols.MSDCmd
{

  public class CNF_AIR_GRIDEventArgs : System.EventArgs
  {
    public CNF_AIR_GRIDEventArgs()
    {
    }
    private System.Boolean? VentAirGrid_field = null;
    public System.Boolean? VentAirGrid
    {
       get { return VentAirGrid_field; }
       set { VentAirGrid_field = value; }
    }

  }

  public class CNF_INF_GRIDEventArgs : System.EventArgs
  {
    public CNF_INF_GRIDEventArgs()
    {
    }
    private System.Boolean? VentInfluentGrid_field = null;
    public System.Boolean? VentInfluentGrid
    {
       get { return VentInfluentGrid_field; }
       set { VentInfluentGrid_field = value; }
    }

  }

  public class CNF_AIR_GRID_MANEventArgs : System.EventArgs
  {
    public CNF_AIR_GRID_MANEventArgs()
    {
    }
    private System.Boolean? VentAirGridMan_field = null;
    public System.Boolean? VentAirGridMan
    {
       get { return VentAirGridMan_field; }
       set { VentAirGridMan_field = value; }
    }

  }

  public class CNF_INF_GRID_MANEventArgs : System.EventArgs
  {
    public CNF_INF_GRID_MANEventArgs()
    {
    }
    private System.Boolean? VentInfluentMan_field = null;
    public System.Boolean? VentInfluentMan
    {
       get { return VentInfluentMan_field; }
       set { VentInfluentMan_field = value; }
    }

  }

}

namespace SE.Nereda.Symbols.MSDCmd
{
  partial class sDefault
  {

    private event EventHandler<SE.Nereda.Symbols.MSDCmd.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

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
              LOAD_PERS_DATA_Fired(this, new SE.Nereda.Symbols.MSDCmd.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
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
    public bool FireEvent_CNF_AIR_GRID(System.Boolean VentAirGrid)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {VentAirGrid});
    }
    public bool FireEvent_CNF_AIR_GRID(SE.Nereda.Symbols.MSDCmd.CNF_AIR_GRIDEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.VentAirGrid.HasValue) _values_[0] = ea.VentAirGrid.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_CNF_AIR_GRID(System.Boolean VentAirGrid, bool ignore_VentAirGrid)
    {
      object[] _values_ = new object[1];
      if (!ignore_VentAirGrid) _values_[0] = VentAirGrid;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_CNF_INF_GRID(System.Boolean VentInfluentGrid)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {VentInfluentGrid});
    }
    public bool FireEvent_CNF_INF_GRID(SE.Nereda.Symbols.MSDCmd.CNF_INF_GRIDEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.VentInfluentGrid.HasValue) _values_[0] = ea.VentInfluentGrid.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_CNF_INF_GRID(System.Boolean VentInfluentGrid, bool ignore_VentInfluentGrid)
    {
      object[] _values_ = new object[1];
      if (!ignore_VentInfluentGrid) _values_[0] = VentInfluentGrid;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_CNF_AIR_GRID_MAN(System.Boolean VentAirGridMan)
    {
      return ((IHMIAccessorOutput)this).FireEvent(2, new object[] {VentAirGridMan});
    }
    public bool FireEvent_CNF_AIR_GRID_MAN(SE.Nereda.Symbols.MSDCmd.CNF_AIR_GRID_MANEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.VentAirGridMan.HasValue) _values_[0] = ea.VentAirGridMan.Value;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_CNF_AIR_GRID_MAN(System.Boolean VentAirGridMan, bool ignore_VentAirGridMan)
    {
      object[] _values_ = new object[1];
      if (!ignore_VentAirGridMan) _values_[0] = VentAirGridMan;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_CNF_INF_GRID_MAN(System.Boolean VentInfluentMan)
    {
      return ((IHMIAccessorOutput)this).FireEvent(3, new object[] {VentInfluentMan});
    }
    public bool FireEvent_CNF_INF_GRID_MAN(SE.Nereda.Symbols.MSDCmd.CNF_INF_GRID_MANEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.VentInfluentMan.HasValue) _values_[0] = ea.VentInfluentMan.Value;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_CNF_INF_GRID_MAN(System.Boolean VentInfluentMan, bool ignore_VentInfluentMan)
    {
      object[] _values_ = new object[1];
      if (!ignore_VentInfluentMan) _values_[0] = VentInfluentMan;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }

  }
}
#endregion #MSDCmd_HMI;

#endregion Definitions;
