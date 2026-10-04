/*
 * Criado pelo EcoStruxure Automation Expert.
 * Usuário:  
 * Data: 13/09/2026
 * Tempo: 10:57
 * 
 */
using System;
using NxtControl.GuiFramework;
using NxtControl.Services;

#region Definitions;
#region #InfluentFeed_HMI;

namespace Hidryco.HidrycoLib.Symbols.InfluentFeed
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
    public bool Get_stsTempoEsperaRestante(ref NxtControl.GuiFramework.Time value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,0, ref var);
      if (ret) value = (NxtControl.GuiFramework.Time) var;
      return ret;
    }

    public NxtControl.GuiFramework.Time? stsTempoEsperaRestante
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,0, ref var);
      if (!ret) return null;
      return (NxtControl.GuiFramework.Time) var;
    }  }

    public bool Get_stsBombaPrincipal(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,1, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? stsBombaPrincipal
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,1, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }

    public bool Get_stsNumeroBombasOperando(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,2, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? stsNumeroBombasOperando
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,2, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }


  }

}

namespace Hidryco.HidrycoLib.Symbols.InfluentFeed
{

  public class CNFEventArgs : System.EventArgs
  {
    public CNFEventArgs()
    {
    }
    private System.Single? stpC1_field = null;
    public System.Single? stpC1
    {
       get { return stpC1_field; }
       set { stpC1_field = value; }
    }
    private System.Single? stpC2_field = null;
    public System.Single? stpC2
    {
       get { return stpC2_field; }
       set { stpC2_field = value; }
    }
    private System.Single? stpC3_field = null;
    public System.Single? stpC3
    {
       get { return stpC3_field; }
       set { stpC3_field = value; }
    }
    private System.Int16? cmdSelecaoBomba_field = null;
    public System.Int16? cmdSelecaoBomba
    {
       get { return cmdSelecaoBomba_field; }
       set { cmdSelecaoBomba_field = value; }
    }
    private System.Boolean? cmdResetAlarmes_field = null;
    public System.Boolean? cmdResetAlarmes
    {
       get { return cmdResetAlarmes_field; }
       set { cmdResetAlarmes_field = value; }
    }
    private NxtControl.GuiFramework.Time? stpTempoAceleracao_field = null;
    public NxtControl.GuiFramework.Time? stpTempoAceleracao
    {
       get { return stpTempoAceleracao_field; }
       set { stpTempoAceleracao_field = value; }
    }
    private NxtControl.GuiFramework.Time? stpTempoEsperaQuimicos_field = null;
    public NxtControl.GuiFramework.Time? stpTempoEsperaQuimicos
    {
       get { return stpTempoEsperaQuimicos_field; }
       set { stpTempoEsperaQuimicos_field = value; }
    }
    private System.Single? stpCapacidadeTeorica_field = null;
    public System.Single? stpCapacidadeTeorica
    {
       get { return stpCapacidadeTeorica_field; }
       set { stpCapacidadeTeorica_field = value; }
    }
    private System.Single? stpNivelBaixoMisturador_field = null;
    public System.Single? stpNivelBaixoMisturador
    {
       get { return stpNivelBaixoMisturador_field; }
       set { stpNivelBaixoMisturador_field = value; }
    }

  }

}

namespace Hidryco.HidrycoLib.Symbols.InfluentFeed
{
  partial class sDefault
  {

    private event EventHandler<Hidryco.HidrycoLib.Symbols.InfluentFeed.REQEventArgs> REQ_Fired;

    protected override void OnEndInit()
    {
      if (REQ_Fired != null)
        AttachEventInput(0);

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
              REQ_Fired(this, new Hidryco.HidrycoLib.Symbols.InfluentFeed.REQEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REQ_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_CNF(System.Single stpC1, System.Single stpC2, System.Single stpC3, System.Int16 cmdSelecaoBomba, System.Boolean cmdResetAlarmes, NxtControl.GuiFramework.Time stpTempoAceleracao, NxtControl.GuiFramework.Time stpTempoEsperaQuimicos, System.Single stpCapacidadeTeorica, System.Single stpNivelBaixoMisturador)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {stpC1, stpC2, stpC3, cmdSelecaoBomba, cmdResetAlarmes, stpTempoAceleracao, stpTempoEsperaQuimicos, stpCapacidadeTeorica, stpNivelBaixoMisturador});
    }
    public bool FireEvent_CNF(Hidryco.HidrycoLib.Symbols.InfluentFeed.CNFEventArgs ea)
    {
      object[] _values_ = new object[9];
      if (ea.stpC1.HasValue) _values_[0] = ea.stpC1.Value;
      if (ea.stpC2.HasValue) _values_[1] = ea.stpC2.Value;
      if (ea.stpC3.HasValue) _values_[2] = ea.stpC3.Value;
      if (ea.cmdSelecaoBomba.HasValue) _values_[3] = ea.cmdSelecaoBomba.Value;
      if (ea.cmdResetAlarmes.HasValue) _values_[4] = ea.cmdResetAlarmes.Value;
      if (ea.stpTempoAceleracao.HasValue) _values_[5] = ea.stpTempoAceleracao.Value;
      if (ea.stpTempoEsperaQuimicos.HasValue) _values_[6] = ea.stpTempoEsperaQuimicos.Value;
      if (ea.stpCapacidadeTeorica.HasValue) _values_[7] = ea.stpCapacidadeTeorica.Value;
      if (ea.stpNivelBaixoMisturador.HasValue) _values_[8] = ea.stpNivelBaixoMisturador.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_CNF(System.Single stpC1, bool ignore_stpC1, System.Single stpC2, bool ignore_stpC2, System.Single stpC3, bool ignore_stpC3, System.Int16 cmdSelecaoBomba, bool ignore_cmdSelecaoBomba, System.Boolean cmdResetAlarmes, bool ignore_cmdResetAlarmes, NxtControl.GuiFramework.Time stpTempoAceleracao, bool ignore_stpTempoAceleracao, NxtControl.GuiFramework.Time stpTempoEsperaQuimicos, bool ignore_stpTempoEsperaQuimicos, System.Single stpCapacidadeTeorica, bool ignore_stpCapacidadeTeorica, System.Single stpNivelBaixoMisturador, bool ignore_stpNivelBaixoMisturador)
    {
      object[] _values_ = new object[9];
      if (!ignore_stpC1) _values_[0] = stpC1;
      if (!ignore_stpC2) _values_[1] = stpC2;
      if (!ignore_stpC3) _values_[2] = stpC3;
      if (!ignore_cmdSelecaoBomba) _values_[3] = cmdSelecaoBomba;
      if (!ignore_cmdResetAlarmes) _values_[4] = cmdResetAlarmes;
      if (!ignore_stpTempoAceleracao) _values_[5] = stpTempoAceleracao;
      if (!ignore_stpTempoEsperaQuimicos) _values_[6] = stpTempoEsperaQuimicos;
      if (!ignore_stpCapacidadeTeorica) _values_[7] = stpCapacidadeTeorica;
      if (!ignore_stpNivelBaixoMisturador) _values_[8] = stpNivelBaixoMisturador;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }

  }
}
#endregion #InfluentFeed_HMI;

#endregion Definitions;
