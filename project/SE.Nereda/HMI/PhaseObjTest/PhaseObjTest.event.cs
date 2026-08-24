/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 6/5/2026
 * Time: 10:12 AM
 * 
 */
using System;
using NxtControl.GuiFramework;
using NxtControl.Services;

#region Definitions;
#region #PhaseObjTest_HMI;

namespace SE.Nereda.Symbols.PhaseObjTest
{

  public class OP_CDTEventArgs : System.EventArgs
  {
    public OP_CDTEventArgs()
    {
    }
    private System.Boolean? OpCdt_field = null;
    public System.Boolean? OpCdt
    {
       get { return OpCdt_field; }
       set { OpCdt_field = value; }
    }

  }

  public class CNF_MODEEventArgs : System.EventArgs
  {
    public CNF_MODEEventArgs()
    {
    }
    private System.Int16? Mode_field = null;
    public System.Int16? Mode
    {
       get { return Mode_field; }
       set { Mode_field = value; }
    }

  }

}

namespace SE.Nereda.Symbols.PhaseObjTest
{
  partial class sDefault
  {
    public bool FireEvent_OP_CDT(System.Boolean OpCdt)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {OpCdt});
    }
    public bool FireEvent_OP_CDT(SE.Nereda.Symbols.PhaseObjTest.OP_CDTEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.OpCdt.HasValue) _values_[0] = ea.OpCdt.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_OP_CDT(System.Boolean OpCdt, bool ignore_OpCdt)
    {
      object[] _values_ = new object[1];
      if (!ignore_OpCdt) _values_[0] = OpCdt;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_CNF_MODE(System.Int16 Mode)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {Mode});
    }
    public bool FireEvent_CNF_MODE(SE.Nereda.Symbols.PhaseObjTest.CNF_MODEEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.Mode.HasValue) _values_[0] = ea.Mode.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_CNF_MODE(System.Int16 Mode, bool ignore_Mode)
    {
      object[] _values_ = new object[1];
      if (!ignore_Mode) _values_[0] = Mode;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }

  }
}
#endregion #PhaseObjTest_HMI;

#endregion Definitions;
