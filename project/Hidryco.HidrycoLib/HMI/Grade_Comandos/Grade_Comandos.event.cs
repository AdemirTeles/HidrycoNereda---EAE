/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 2/24/2026
 * Time: 10:59 AM
 * 
 */
using System;
using NxtControl.GuiFramework;
using NxtControl.Services;

#region Definitions;
#region #Grade_Comandos_HMI;

namespace Hidryco.HidrycoLib.Symbols.Grade_Comandos
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

namespace Hidryco.HidrycoLib.Symbols.Grade_Comandos
{

  public class E_ATUALIZA_SETPOINTEventArgs : System.EventArgs
  {
    public E_ATUALIZA_SETPOINTEventArgs()
    {
    }
    private System.Boolean? CMD_LIGA_CICLO_REMOTO_field = null;
    public System.Boolean? CMD_LIGA_CICLO_REMOTO
    {
       get { return CMD_LIGA_CICLO_REMOTO_field; }
       set { CMD_LIGA_CICLO_REMOTO_field = value; }
    }
    private System.Int16? STP_DIFERENCIAL_NIVEL_GRADE1_field = null;
    public System.Int16? STP_DIFERENCIAL_NIVEL_GRADE1
    {
       get { return STP_DIFERENCIAL_NIVEL_GRADE1_field; }
       set { STP_DIFERENCIAL_NIVEL_GRADE1_field = value; }
    }
    private System.Int16? STP_DIFERENCIAL_NIVEL_GRADE2_field = null;
    public System.Int16? STP_DIFERENCIAL_NIVEL_GRADE2
    {
       get { return STP_DIFERENCIAL_NIVEL_GRADE2_field; }
       set { STP_DIFERENCIAL_NIVEL_GRADE2_field = value; }
    }

  }

}

namespace Hidryco.HidrycoLib.Symbols.Grade_Comandos
{
  partial class sDefault
  {

    private event EventHandler<Hidryco.HidrycoLib.Symbols.Grade_Comandos.LOAD_PERS_DATAEventArgs> LOAD_PERS_DATA_Fired;

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
              LOAD_PERS_DATA_Fired(this, new Hidryco.HidrycoLib.Symbols.Grade_Comandos.LOAD_PERS_DATAEventArgs(channelId, cookie, eventIndex));
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
    public bool FireEvent_E_ATUALIZA_SETPOINT(System.Boolean CMD_LIGA_CICLO_REMOTO, System.Int16 STP_DIFERENCIAL_NIVEL_GRADE1, System.Int16 STP_DIFERENCIAL_NIVEL_GRADE2)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {CMD_LIGA_CICLO_REMOTO, STP_DIFERENCIAL_NIVEL_GRADE1, STP_DIFERENCIAL_NIVEL_GRADE2});
    }
    public bool FireEvent_E_ATUALIZA_SETPOINT(Hidryco.HidrycoLib.Symbols.Grade_Comandos.E_ATUALIZA_SETPOINTEventArgs ea)
    {
      object[] _values_ = new object[3];
      if (ea.CMD_LIGA_CICLO_REMOTO.HasValue) _values_[0] = ea.CMD_LIGA_CICLO_REMOTO.Value;
      if (ea.STP_DIFERENCIAL_NIVEL_GRADE1.HasValue) _values_[1] = ea.STP_DIFERENCIAL_NIVEL_GRADE1.Value;
      if (ea.STP_DIFERENCIAL_NIVEL_GRADE2.HasValue) _values_[2] = ea.STP_DIFERENCIAL_NIVEL_GRADE2.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_E_ATUALIZA_SETPOINT(System.Boolean CMD_LIGA_CICLO_REMOTO, bool ignore_CMD_LIGA_CICLO_REMOTO, System.Int16 STP_DIFERENCIAL_NIVEL_GRADE1, bool ignore_STP_DIFERENCIAL_NIVEL_GRADE1, System.Int16 STP_DIFERENCIAL_NIVEL_GRADE2, bool ignore_STP_DIFERENCIAL_NIVEL_GRADE2)
    {
      object[] _values_ = new object[3];
      if (!ignore_CMD_LIGA_CICLO_REMOTO) _values_[0] = CMD_LIGA_CICLO_REMOTO;
      if (!ignore_STP_DIFERENCIAL_NIVEL_GRADE1) _values_[1] = STP_DIFERENCIAL_NIVEL_GRADE1;
      if (!ignore_STP_DIFERENCIAL_NIVEL_GRADE2) _values_[2] = STP_DIFERENCIAL_NIVEL_GRADE2;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }

  }
}
#endregion #Grade_Comandos_HMI;

#endregion Definitions;
