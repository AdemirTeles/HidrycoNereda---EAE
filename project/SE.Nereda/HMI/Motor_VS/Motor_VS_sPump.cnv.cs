/*
 * Created by EcoStruxure Automation Expert.
 * User: SESA713705 
 * Date: 6/2/2026
 * Time: 9:20 AM
 * 
 */

using System;
using NxtControl.GuiFramework;
using System.ComponentModel;

namespace SE.Nereda.Symbols.Motor_VS
{
	/// <summary>
	/// Description of sDefault.
	/// </summary>
	public partial class sPump : NxtControl.GuiFramework.HMISymbol
	{
		private string _MotName = "Motor";
		private string _Unit = "%";
		// ✅ ComboBox option (enum) - new field for symbol name display
		public enum SymbolNameDisplayOption
		{
		    Show,
		    Hide
		}
		
		private SymbolNameDisplayOption _symbolNameDisplay = SymbolNameDisplayOption.Show;
		public sPump()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			this.FB_FWD_Fired += FB_FWD_RaioGerador;
			this.FB_FWD_Fired += FB_FWD_Comunicacao;
			SpeedPv.SweepAngle = 0;
			SpeedInfo.Visible = true;
			this.SPEED_SP_FB_Fired += SPEED_SP_FB_Fired_EventHandler;
		}

		void StateActuatorStatus(short StateValue)
		{
			// TODO: Implement StateActuatorStatus
			// =1: Started ; =0: Stopped ; =255: Error ; =100: Power Off
			SpeedInfo.Visible = true;
			if(StateValue == 0 || StateValue == 254){
				PipeIn.BrushColor = PipeOut.BrushColor = Pump.BrushColor = SE.Nereda.ProjectColors.PassiveStatus;
			}
			if(StateValue == 1 || StateValue == 2){
				PipeIn.BrushColor = PipeOut.BrushColor = Pump.BrushColor = SE.Nereda.ProjectColors.ActiveStatus;
			}
			if(StateValue == 253){
				PipeIn.BrushColor = PipeOut.BrushColor = Pump.BrushColor = new NxtControl.Drawing.BlinkColor("SE.Nereda.Orangwhite");
			}
			if(StateValue == 100){
				PipeIn.BrushColor = PipeOut.BrushColor = Pump.BrushColor = SE.Nereda.ProjectColors.PowerOFF;
				SpeedInfo.Visible = false;
			}
			if(StateValue == 10){
				PipeIn.BrushColor = PipeOut.BrushColor = Pump.BrushColor = SE.Nereda.ProjectColors.PassiveStatus;
				SpeedInfo.Visible = false;
			}
		}

		void OpenFpClick(object sender, EventArgs e)
		{
			// TODO: Implement OpenFpClick
			// abre direto o faceplate principal (antes abria o menu fpOptions)
			this.BaseVs.DoOpenFaceplate("fpDefault");
		}
		
		[RefreshProperties(RefreshProperties.Repaint)]
		[Category("Tagnames")]
		[DisplayName("MotName")]
		
		public string _iMotName
		{
			get{
				return _MotName;
			}
			set{
				_MotName = value;
				MotName.Text = value.ToString();
			}
		}
		
		[RefreshProperties(RefreshProperties.Repaint)]
		[Category("Tagnames")]
		[DisplayName("Unit")]
		
		public string _iUnit
		{
			get{
				return _Unit;
			}
			set{
				_Unit = value;
				Unit.Text = value.ToString();
			}
		}
		
		// ✅ ComboBox property in PropertyGrid
		[RefreshProperties(RefreshProperties.Repaint)]
		[Category("Appearance")]
		[DisplayName("Symbol Name Display")]
		public SymbolNameDisplayOption SymbolNameDisplay
		{
		    get { return _symbolNameDisplay; }
		    set
		    {
		        _symbolNameDisplay = value;
		        ApplySymbolNameDisplay(_symbolNameDisplay);
		    }
		}
		
		
		// ✅ Central place to apply the chosen symbol name display
		private void ApplySymbolNameDisplay(SymbolNameDisplayOption display)
		{
		    if (display == SymbolNameDisplayOption.Show)
		    {
		        MotName.Visible = true;
		    }
		    else // Hide
		    {
		        MotName.Visible = false;
		    }
		}

		void SPEED_SP_FB_Fired_EventHandler(object sender, SPEED_SP_FBEventArgs e)
		{
			// TODO: Implement SPEED_SP_FB_Fired_EventHandler
			SpeedPv.SweepAngle = 0 + ((float)e.FbSpeed / 100f) * 306;
		}

		// raio do gerador (Hidryco): 0 invisivel, 1 so contorno (nao liberado), 2 cinza (liberado), 3 vermelho (liberado e funcionando nos geradores)
		// Falha de comunicacao com o inversor (padrao do Motor_Generico da HidrycoLib): o icone pisca (500 ms)
		// enquanto o alarme nao foi reconhecido; reconhecido e ainda ativo = icone fixo
		bool fCom, fase = true;
		byte eCom;
		System.Timers.Timer tPisca;
		void FB_FWD_Comunicacao(object sender, FB_FWDEventArgs e)
		{
			bool? f = e.STS_FALHA_COMUNICACAO;
			byte? est = e.STS_ALM_COMUNICACAO_EST;
			fCom = f.HasValue && f.Value;
			eCom = est.HasValue ? est.Value : (byte)0;
			IconeCom();
		}
		void IconeCom()
		{
			bool pisca = fCom && eCom >= 2 && eCom <= 4;
			Pisca(pisca);
			bool v = fCom && (!pisca || fase);
			comImg.Visible = v;
			comCirc.Visible = v;
			comRisco.Visible = v;
		}
		void Pisca(bool precisa)
		{
			if (precisa && tPisca == null)
			{
				tPisca = new System.Timers.Timer();
				tPisca.Interval = 500D;
				tPisca.Elapsed += new System.Timers.ElapsedEventHandler(TPiscaElapsed);
				tPisca.Start();
			}
			else if (!precisa && tPisca != null)
			{
				tPisca.Stop();
				tPisca.Dispose();
				tPisca = null;
				fase = true;
			}
		}
		// O temporizador roda em outra thread: a troca de fase vai para a thread da IHM
		void TPiscaElapsed(object sender, System.Timers.ElapsedEventArgs e)
		{
			NxtControl.Services.IHMIMainThreadService svc = NxtControl.Services.ServiceProvider.GetService(typeof(NxtControl.Services.IHMIMainThreadService)) as NxtControl.Services.IHMIMainThreadService;
			if (svc != null) svc.SafeThreadAsyncCall(new Action(AlternaFase));
		}
		void AlternaFase()
		{
			if (tPisca == null) return;
			fase = !fase;
			IconeCom();
		}
		protected override void Dispose(bool disposing)
		{
			if (disposing && tPisca != null)
			{
				tPisca.Stop();
				tPisca.Dispose();
				tPisca = null;
			}
			base.Dispose(disposing);
		}

		void FB_FWD_RaioGerador(object sender, FB_FWDEventArgs e)
		{
			short? a = e.STS_ANIMACAO_GERADOR;
			int an = a.HasValue ? a.Value : 0;
			raioCirc.Visible = an > 0;
			raioRaio.Visible = an > 0;
			if (an == 3) raioRaio.BrushColor = System.Drawing.Color.Red;
			else if (an == 2) raioRaio.BrushColor = System.Drawing.Color.LightGray;
			else raioRaio.BrushColor = System.Drawing.Color.Transparent;
		}
	}
}
