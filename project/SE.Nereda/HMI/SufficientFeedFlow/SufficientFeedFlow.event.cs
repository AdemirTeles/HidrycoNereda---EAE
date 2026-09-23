/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 9/23/2026
 * Time: 3:20 PM
 * 
 */
using System;
using NxtControl.GuiFramework;
using NxtControl.Services;

#region Definitions;
#region #SufficientFeedFlow_HMI;

namespace SE.Nereda.Symbols.SufficientFeedFlow
{

  public class CNFEventArgs : System.EventArgs
  {
    public CNFEventArgs()
    {
    }
    private System.Int32? LevelCheckTimeSp_field = null;
    public System.Int32? LevelCheckTimeSp
    {
       get { return LevelCheckTimeSp_field; }
       set { LevelCheckTimeSp_field = value; }
    }
    private System.Single? MinLevelRiseSp_field = null;
    public System.Single? MinLevelRiseSp
    {
       get { return MinLevelRiseSp_field; }
       set { MinLevelRiseSp_field = value; }
    }

  }

}

namespace SE.Nereda.Symbols.SufficientFeedFlow
{
  partial class sDefault
  {
    public bool FireEvent_CNF(System.Int32 LevelCheckTimeSp, System.Single MinLevelRiseSp)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {LevelCheckTimeSp, MinLevelRiseSp});
    }
    public bool FireEvent_CNF(SE.Nereda.Symbols.SufficientFeedFlow.CNFEventArgs ea)
    {
      object[] _values_ = new object[2];
      if (ea.LevelCheckTimeSp.HasValue) _values_[0] = ea.LevelCheckTimeSp.Value;
      if (ea.MinLevelRiseSp.HasValue) _values_[1] = ea.MinLevelRiseSp.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_CNF(System.Int32 LevelCheckTimeSp, bool ignore_LevelCheckTimeSp, System.Single MinLevelRiseSp, bool ignore_MinLevelRiseSp)
    {
      object[] _values_ = new object[2];
      if (!ignore_LevelCheckTimeSp) _values_[0] = LevelCheckTimeSp;
      if (!ignore_MinLevelRiseSp) _values_[1] = MinLevelRiseSp;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }

  }
}

namespace SE.Nereda.Faceplates.SufficientFeedFlow
{
  partial class fpSettings
  {
    public bool FireEvent_CNF(System.Int32 LevelCheckTimeSp, System.Single MinLevelRiseSp)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {LevelCheckTimeSp, MinLevelRiseSp});
    }
    public bool FireEvent_CNF(SE.Nereda.Symbols.SufficientFeedFlow.CNFEventArgs ea)
    {
      object[] _values_ = new object[2];
      if (ea.LevelCheckTimeSp.HasValue) _values_[0] = ea.LevelCheckTimeSp.Value;
      if (ea.MinLevelRiseSp.HasValue) _values_[1] = ea.MinLevelRiseSp.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_CNF(System.Int32 LevelCheckTimeSp, bool ignore_LevelCheckTimeSp, System.Single MinLevelRiseSp, bool ignore_MinLevelRiseSp)
    {
      object[] _values_ = new object[2];
      if (!ignore_LevelCheckTimeSp) _values_[0] = LevelCheckTimeSp;
      if (!ignore_MinLevelRiseSp) _values_[1] = MinLevelRiseSp;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }

  }
}
#endregion #SufficientFeedFlow_HMI;

#endregion Definitions;
