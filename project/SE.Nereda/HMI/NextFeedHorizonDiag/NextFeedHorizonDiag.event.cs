/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 10/6/2026
 * Time: 3:33 PM
 * 
 */
using System;
using NxtControl.GuiFramework;
using NxtControl.Services;

#region Definitions;
#region #NextFeedHorizonDiag_HMI;

namespace SE.Nereda.Symbols.NextFeedHorizonDiag
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
    public bool Get_NextFeedHorizon(ref System.Single value)
    {
      if (accessorService == null)
        return false;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,0, ref var);
      if (ret) value = (System.Single) var;
      return ret;
    }

    public System.Single? NextFeedHorizon
    { get {
      if (accessorService == null)
        return null;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,0, ref var);
      if (!ret) return null;
      return (System.Single) var;
    }  }

    public bool Get_StartFeedInterval(ref System.Single value)
    {
      if (accessorService == null)
        return false;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,1, ref var);
      if (ret) value = (System.Single) var;
      return ret;
    }

    public System.Single? StartFeedInterval
    { get {
      if (accessorService == null)
        return null;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,1, ref var);
      if (!ret) return null;
      return (System.Single) var;
    }  }

    public bool Get_FallBackElapsedTime(ref System.Single value)
    {
      if (accessorService == null)
        return false;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,2, ref var);
      if (ret) value = (System.Single) var;
      return ret;
    }

    public System.Single? FallBackElapsedTime
    { get {
      if (accessorService == null)
        return null;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,2, ref var);
      if (!ret) return null;
      return (System.Single) var;
    }  }

    public bool Get_i_R(ref System.Single value)
    {
      if (accessorService == null)
        return false;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,3, ref var);
      if (ret) value = (System.Single) var;
      return ret;
    }

    public System.Single? i_R
    { get {
      if (accessorService == null)
        return null;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,3, ref var);
      if (!ret) return null;
      return (System.Single) var;
    }  }

    public bool Get_SettleTime(ref System.Single value)
    {
      if (accessorService == null)
        return false;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,4, ref var);
      if (ret) value = (System.Single) var;
      return ret;
    }

    public System.Single? SettleTime
    { get {
      if (accessorService == null)
        return null;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,4, ref var);
      if (!ret) return null;
      return (System.Single) var;
    }  }

    public bool Get_i(ref System.Int32 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,5, ref var);
      if (ret) value = (System.Int32) var;
      return ret;
    }

    public System.Int32? i
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,5, ref var);
      if (!ret) return null;
      return (System.Int32) var;
    }  }

    public bool Get_NbrRAv(ref System.Single value)
    {
      if (accessorService == null)
        return false;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,6, ref var);
      if (ret) value = (System.Single) var;
      return ret;
    }

    public System.Single? NbrRAv
    { get {
      if (accessorService == null)
        return null;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,6, ref var);
      if (!ret) return null;
      return (System.Single) var;
    }  }

    public bool Get_TimesFed(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,7, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? TimesFed
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,7, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }

    public bool Get_RecipeElapsedTime(ref System.Single value)
    {
      if (accessorService == null)
        return false;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,8, ref var);
      if (ret) value = (System.Single) var;
      return ret;
    }

    public System.Single? RecipeElapsedTime
    { get {
      if (accessorService == null)
        return null;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,8, ref var);
      if (!ret) return null;
      return (System.Single) var;
    }  }

    public bool Get_NextFeedHorizonPlant(ref System.Single value)
    {
      if (accessorService == null)
        return false;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,9, ref var);
      if (ret) value = (System.Single) var;
      return ret;
    }

    public System.Single? NextFeedHorizonPlant
    { get {
      if (accessorService == null)
        return null;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,9, ref var);
      if (!ret) return null;
      return (System.Single) var;
    }  }


  }

  public class RESET_BTNsEventArgs : System.EventArgs
  {
    IHMIAccessorService accessorService;
    int channelId;
    int cookie; 
    int eventIndex;

    public RESET_BTNsEventArgs(int channelId, int cookie, int eventIndex)
    {
      this.accessorService = (IHMIAccessorService)ServiceProvider.GetService(typeof(IHMIAccessorService));
      this.channelId = channelId;
      this.cookie = cookie;
      this.eventIndex = eventIndex;
    }

  }

  public class CURREventArgs : System.EventArgs
  {
    IHMIAccessorService accessorService;
    int channelId;
    int cookie; 
    int eventIndex;

    public CURREventArgs(int channelId, int cookie, int eventIndex)
    {
      this.accessorService = (IHMIAccessorService)ServiceProvider.GetService(typeof(IHMIAccessorService));
      this.channelId = channelId;
      this.cookie = cookie;
      this.eventIndex = eventIndex;
    }
    public bool Get_CurrNextFeedHorizon(ref System.Single value)
    {
      if (accessorService == null)
        return false;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,0, ref var);
      if (ret) value = (System.Single) var;
      return ret;
    }

    public System.Single? CurrNextFeedHorizon
    { get {
      if (accessorService == null)
        return null;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,0, ref var);
      if (!ret) return null;
      return (System.Single) var;
    }  }

    public bool Get_CurrStartFeedInterval(ref System.Single value)
    {
      if (accessorService == null)
        return false;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,1, ref var);
      if (ret) value = (System.Single) var;
      return ret;
    }

    public System.Single? CurrStartFeedInterval
    { get {
      if (accessorService == null)
        return null;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,1, ref var);
      if (!ret) return null;
      return (System.Single) var;
    }  }

    public bool Get_CurrFallBackElapsedTime(ref System.Single value)
    {
      if (accessorService == null)
        return false;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,2, ref var);
      if (ret) value = (System.Single) var;
      return ret;
    }

    public System.Single? CurrFallBackElapsedTime
    { get {
      if (accessorService == null)
        return null;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,2, ref var);
      if (!ret) return null;
      return (System.Single) var;
    }  }

    public bool Get_CurrI_R(ref System.Single value)
    {
      if (accessorService == null)
        return false;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,3, ref var);
      if (ret) value = (System.Single) var;
      return ret;
    }

    public System.Single? CurrI_R
    { get {
      if (accessorService == null)
        return null;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,3, ref var);
      if (!ret) return null;
      return (System.Single) var;
    }  }

    public bool Get_CurrSettleTime(ref System.Single value)
    {
      if (accessorService == null)
        return false;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,4, ref var);
      if (ret) value = (System.Single) var;
      return ret;
    }

    public System.Single? CurrSettleTime
    { get {
      if (accessorService == null)
        return null;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,4, ref var);
      if (!ret) return null;
      return (System.Single) var;
    }  }

    public bool Get_CurrNbrRAv(ref System.Single value)
    {
      if (accessorService == null)
        return false;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,5, ref var);
      if (ret) value = (System.Single) var;
      return ret;
    }

    public System.Single? CurrNbrRAv
    { get {
      if (accessorService == null)
        return null;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,5, ref var);
      if (!ret) return null;
      return (System.Single) var;
    }  }

    public bool Get_CurrTimesFed(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,6, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? CurrTimesFed
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,6, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }

    public bool Get_CurrRecipeElapsedTime(ref System.Single value)
    {
      if (accessorService == null)
        return false;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,7, ref var);
      if (ret) value = (System.Single) var;
      return ret;
    }

    public System.Single? CurrRecipeElapsedTime
    { get {
      if (accessorService == null)
        return null;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,7, ref var);
      if (!ret) return null;
      return (System.Single) var;
    }  }

    public bool Get_CurrNextFeedHorizonPlant(ref System.Single value)
    {
      if (accessorService == null)
        return false;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,8, ref var);
      if (ret) value = (System.Single) var;
      return ret;
    }

    public System.Single? CurrNextFeedHorizonPlant
    { get {
      if (accessorService == null)
        return null;
      float var = 0;
      bool ret = accessorService.GetFloatValue(channelId, cookie, eventIndex, true,8, ref var);
      if (!ret) return null;
      return (System.Single) var;
    }  }


  }

}

namespace SE.Nereda.Symbols.NextFeedHorizonDiag
{

  public class CTRLEventArgs : System.EventArgs
  {
    public CTRLEventArgs()
    {
    }
    private System.Boolean? Record_field = null;
    public System.Boolean? Record
    {
       get { return Record_field; }
       set { Record_field = value; }
    }

  }

  public class UP_EOEventArgs : System.EventArgs
  {
    public UP_EOEventArgs()
    {
    }
    private System.Boolean? Up_field = null;
    public System.Boolean? Up
    {
       get { return Up_field; }
       set { Up_field = value; }
    }

  }

  public class DOWN_EOEventArgs : System.EventArgs
  {
    public DOWN_EOEventArgs()
    {
    }
    private System.Boolean? Down_field = null;
    public System.Boolean? Down
    {
       get { return Down_field; }
       set { Down_field = value; }
    }

  }

  public class SUPRESSEventArgs : System.EventArgs
  {
    public SUPRESSEventArgs()
    {
    }
    private System.Boolean? Supress_field = null;
    public System.Boolean? Supress
    {
       get { return Supress_field; }
       set { Supress_field = value; }
    }

  }

}

namespace SE.Nereda.Symbols.NextFeedHorizonDiag
{
  partial class sDefault
  {

    private event EventHandler<SE.Nereda.Symbols.NextFeedHorizonDiag.REQEventArgs> REQ_Fired;

    private event EventHandler<SE.Nereda.Symbols.NextFeedHorizonDiag.RESET_BTNsEventArgs> RESET_BTNs_Fired;

    private event EventHandler<SE.Nereda.Symbols.NextFeedHorizonDiag.CURREventArgs> CURR_Fired;

    protected override void OnEndInit()
    {
      if (REQ_Fired != null)
        AttachEventInput(0);
      if (RESET_BTNs_Fired != null)
        AttachEventInput(1);
      if (CURR_Fired != null)
        AttachEventInput(2);

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
              REQ_Fired(this, new SE.Nereda.Symbols.NextFeedHorizonDiag.REQEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REQ_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 1:
          if (RESET_BTNs_Fired != null)
          {
            try
            {
              RESET_BTNs_Fired(this, new SE.Nereda.Symbols.NextFeedHorizonDiag.RESET_BTNsEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","RESET_BTNs_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 2:
          if (CURR_Fired != null)
          {
            try
            {
              CURR_Fired(this, new SE.Nereda.Symbols.NextFeedHorizonDiag.CURREventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","CURR_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_CTRL(System.Boolean Record)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {Record});
    }
    public bool FireEvent_CTRL(SE.Nereda.Symbols.NextFeedHorizonDiag.CTRLEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.Record.HasValue) _values_[0] = ea.Record.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_CTRL(System.Boolean Record, bool ignore_Record)
    {
      object[] _values_ = new object[1];
      if (!ignore_Record) _values_[0] = Record;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_UP_EO(System.Boolean Up)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {Up});
    }
    public bool FireEvent_UP_EO(SE.Nereda.Symbols.NextFeedHorizonDiag.UP_EOEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.Up.HasValue) _values_[0] = ea.Up.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_UP_EO(System.Boolean Up, bool ignore_Up)
    {
      object[] _values_ = new object[1];
      if (!ignore_Up) _values_[0] = Up;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_DOWN_EO(System.Boolean Down)
    {
      return ((IHMIAccessorOutput)this).FireEvent(2, new object[] {Down});
    }
    public bool FireEvent_DOWN_EO(SE.Nereda.Symbols.NextFeedHorizonDiag.DOWN_EOEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.Down.HasValue) _values_[0] = ea.Down.Value;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_DOWN_EO(System.Boolean Down, bool ignore_Down)
    {
      object[] _values_ = new object[1];
      if (!ignore_Down) _values_[0] = Down;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_SUPRESS(System.Boolean Supress)
    {
      return ((IHMIAccessorOutput)this).FireEvent(3, new object[] {Supress});
    }
    public bool FireEvent_SUPRESS(SE.Nereda.Symbols.NextFeedHorizonDiag.SUPRESSEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.Supress.HasValue) _values_[0] = ea.Supress.Value;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_SUPRESS(System.Boolean Supress, bool ignore_Supress)
    {
      object[] _values_ = new object[1];
      if (!ignore_Supress) _values_[0] = Supress;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }

  }
}

namespace SE.Nereda.Faceplates.NextFeedHorizonDiag
{
  partial class fpDiag
  {

    private event EventHandler<SE.Nereda.Symbols.NextFeedHorizonDiag.REQEventArgs> REQ_Fired;

    private event EventHandler<SE.Nereda.Symbols.NextFeedHorizonDiag.RESET_BTNsEventArgs> RESET_BTNs_Fired;

    private event EventHandler<SE.Nereda.Symbols.NextFeedHorizonDiag.CURREventArgs> CURR_Fired;

    protected override void OnEndInit()
    {
      if (REQ_Fired != null)
        AttachEventInput(0);
      if (RESET_BTNs_Fired != null)
        AttachEventInput(1);
      if (CURR_Fired != null)
        AttachEventInput(2);

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
              REQ_Fired(this, new SE.Nereda.Symbols.NextFeedHorizonDiag.REQEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REQ_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 1:
          if (RESET_BTNs_Fired != null)
          {
            try
            {
              RESET_BTNs_Fired(this, new SE.Nereda.Symbols.NextFeedHorizonDiag.RESET_BTNsEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","RESET_BTNs_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 2:
          if (CURR_Fired != null)
          {
            try
            {
              CURR_Fired(this, new SE.Nereda.Symbols.NextFeedHorizonDiag.CURREventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","CURR_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_CTRL(System.Boolean Record)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {Record});
    }
    public bool FireEvent_CTRL(SE.Nereda.Symbols.NextFeedHorizonDiag.CTRLEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.Record.HasValue) _values_[0] = ea.Record.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_CTRL(System.Boolean Record, bool ignore_Record)
    {
      object[] _values_ = new object[1];
      if (!ignore_Record) _values_[0] = Record;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_UP_EO(System.Boolean Up)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {Up});
    }
    public bool FireEvent_UP_EO(SE.Nereda.Symbols.NextFeedHorizonDiag.UP_EOEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.Up.HasValue) _values_[0] = ea.Up.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_UP_EO(System.Boolean Up, bool ignore_Up)
    {
      object[] _values_ = new object[1];
      if (!ignore_Up) _values_[0] = Up;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_DOWN_EO(System.Boolean Down)
    {
      return ((IHMIAccessorOutput)this).FireEvent(2, new object[] {Down});
    }
    public bool FireEvent_DOWN_EO(SE.Nereda.Symbols.NextFeedHorizonDiag.DOWN_EOEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.Down.HasValue) _values_[0] = ea.Down.Value;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_DOWN_EO(System.Boolean Down, bool ignore_Down)
    {
      object[] _values_ = new object[1];
      if (!ignore_Down) _values_[0] = Down;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_SUPRESS(System.Boolean Supress)
    {
      return ((IHMIAccessorOutput)this).FireEvent(3, new object[] {Supress});
    }
    public bool FireEvent_SUPRESS(SE.Nereda.Symbols.NextFeedHorizonDiag.SUPRESSEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.Supress.HasValue) _values_[0] = ea.Supress.Value;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_SUPRESS(System.Boolean Supress, bool ignore_Supress)
    {
      object[] _values_ = new object[1];
      if (!ignore_Supress) _values_[0] = Supress;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }

  }
}

namespace SE.Nereda.Symbols.NextFeedHorizonDiag
{
  partial class sCurrCalc
  {

    private event EventHandler<SE.Nereda.Symbols.NextFeedHorizonDiag.REQEventArgs> REQ_Fired;

    private event EventHandler<SE.Nereda.Symbols.NextFeedHorizonDiag.RESET_BTNsEventArgs> RESET_BTNs_Fired;

    private event EventHandler<SE.Nereda.Symbols.NextFeedHorizonDiag.CURREventArgs> CURR_Fired;

    protected override void OnEndInit()
    {
      if (REQ_Fired != null)
        AttachEventInput(0);
      if (RESET_BTNs_Fired != null)
        AttachEventInput(1);
      if (CURR_Fired != null)
        AttachEventInput(2);

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
              REQ_Fired(this, new SE.Nereda.Symbols.NextFeedHorizonDiag.REQEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REQ_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 1:
          if (RESET_BTNs_Fired != null)
          {
            try
            {
              RESET_BTNs_Fired(this, new SE.Nereda.Symbols.NextFeedHorizonDiag.RESET_BTNsEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","RESET_BTNs_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 2:
          if (CURR_Fired != null)
          {
            try
            {
              CURR_Fired(this, new SE.Nereda.Symbols.NextFeedHorizonDiag.CURREventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","CURR_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_CTRL(System.Boolean Record)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {Record});
    }
    public bool FireEvent_CTRL(SE.Nereda.Symbols.NextFeedHorizonDiag.CTRLEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.Record.HasValue) _values_[0] = ea.Record.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_CTRL(System.Boolean Record, bool ignore_Record)
    {
      object[] _values_ = new object[1];
      if (!ignore_Record) _values_[0] = Record;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_UP_EO(System.Boolean Up)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {Up});
    }
    public bool FireEvent_UP_EO(SE.Nereda.Symbols.NextFeedHorizonDiag.UP_EOEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.Up.HasValue) _values_[0] = ea.Up.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_UP_EO(System.Boolean Up, bool ignore_Up)
    {
      object[] _values_ = new object[1];
      if (!ignore_Up) _values_[0] = Up;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_DOWN_EO(System.Boolean Down)
    {
      return ((IHMIAccessorOutput)this).FireEvent(2, new object[] {Down});
    }
    public bool FireEvent_DOWN_EO(SE.Nereda.Symbols.NextFeedHorizonDiag.DOWN_EOEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.Down.HasValue) _values_[0] = ea.Down.Value;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_DOWN_EO(System.Boolean Down, bool ignore_Down)
    {
      object[] _values_ = new object[1];
      if (!ignore_Down) _values_[0] = Down;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_SUPRESS(System.Boolean Supress)
    {
      return ((IHMIAccessorOutput)this).FireEvent(3, new object[] {Supress});
    }
    public bool FireEvent_SUPRESS(SE.Nereda.Symbols.NextFeedHorizonDiag.SUPRESSEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.Supress.HasValue) _values_[0] = ea.Supress.Value;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_SUPRESS(System.Boolean Supress, bool ignore_Supress)
    {
      object[] _values_ = new object[1];
      if (!ignore_Supress) _values_[0] = Supress;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }

  }
}

namespace SE.Nereda.Faceplates.NextFeedHorizonDiag
{
  partial class fpDiag2
  {

    private event EventHandler<SE.Nereda.Symbols.NextFeedHorizonDiag.REQEventArgs> REQ_Fired;

    private event EventHandler<SE.Nereda.Symbols.NextFeedHorizonDiag.RESET_BTNsEventArgs> RESET_BTNs_Fired;

    private event EventHandler<SE.Nereda.Symbols.NextFeedHorizonDiag.CURREventArgs> CURR_Fired;

    protected override void OnEndInit()
    {
      if (REQ_Fired != null)
        AttachEventInput(0);
      if (RESET_BTNs_Fired != null)
        AttachEventInput(1);
      if (CURR_Fired != null)
        AttachEventInput(2);

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
              REQ_Fired(this, new SE.Nereda.Symbols.NextFeedHorizonDiag.REQEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REQ_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 1:
          if (RESET_BTNs_Fired != null)
          {
            try
            {
              RESET_BTNs_Fired(this, new SE.Nereda.Symbols.NextFeedHorizonDiag.RESET_BTNsEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","RESET_BTNs_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 2:
          if (CURR_Fired != null)
          {
            try
            {
              CURR_Fired(this, new SE.Nereda.Symbols.NextFeedHorizonDiag.CURREventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","CURR_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_CTRL(System.Boolean Record)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {Record});
    }
    public bool FireEvent_CTRL(SE.Nereda.Symbols.NextFeedHorizonDiag.CTRLEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.Record.HasValue) _values_[0] = ea.Record.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_CTRL(System.Boolean Record, bool ignore_Record)
    {
      object[] _values_ = new object[1];
      if (!ignore_Record) _values_[0] = Record;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_UP_EO(System.Boolean Up)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {Up});
    }
    public bool FireEvent_UP_EO(SE.Nereda.Symbols.NextFeedHorizonDiag.UP_EOEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.Up.HasValue) _values_[0] = ea.Up.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_UP_EO(System.Boolean Up, bool ignore_Up)
    {
      object[] _values_ = new object[1];
      if (!ignore_Up) _values_[0] = Up;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_DOWN_EO(System.Boolean Down)
    {
      return ((IHMIAccessorOutput)this).FireEvent(2, new object[] {Down});
    }
    public bool FireEvent_DOWN_EO(SE.Nereda.Symbols.NextFeedHorizonDiag.DOWN_EOEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.Down.HasValue) _values_[0] = ea.Down.Value;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_DOWN_EO(System.Boolean Down, bool ignore_Down)
    {
      object[] _values_ = new object[1];
      if (!ignore_Down) _values_[0] = Down;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_SUPRESS(System.Boolean Supress)
    {
      return ((IHMIAccessorOutput)this).FireEvent(3, new object[] {Supress});
    }
    public bool FireEvent_SUPRESS(SE.Nereda.Symbols.NextFeedHorizonDiag.SUPRESSEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.Supress.HasValue) _values_[0] = ea.Supress.Value;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }
    public bool FireEvent_SUPRESS(System.Boolean Supress, bool ignore_Supress)
    {
      object[] _values_ = new object[1];
      if (!ignore_Supress) _values_[0] = Supress;
      return ((IHMIAccessorOutput)this).FireEvent(3, _values_);
    }

  }
}
#endregion #NextFeedHorizonDiag_HMI;

#endregion Definitions;
