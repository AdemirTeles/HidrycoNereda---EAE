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
	public partial class sBlower : NxtControl.GuiFramework.HMISymbol
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
		public sBlower()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			SpeedInfo.Visible = true;
			this.SPEED_SP_FB_Fired += SPEED_SP_FB_Fired_EventHandler;
			SpeedPv.SweepAngle = 0;
		}

		void StateActuatorStatus(short StateValue)
		{
			// TODO: Implement StateActuatorStatus
			// =1: Started ; =0: Stopped ; =255: Error ; =100: Power Off
			SpeedInfo.Visible = true;
			if(StateValue == 0 || StateValue == 254){
				PipeIn.BrushColor = PipeOut.BrushColor = Base1.BrushColor = SE.Nereda.ProjectColors.PassiveStatus;
			}
			if(StateValue == 1 || StateValue == 2){
				PipeIn.BrushColor = PipeOut.BrushColor = Base1.BrushColor = SE.Nereda.ProjectColors.ActiveStatus;
			}
			if(StateValue == 253){
				PipeIn.BrushColor = PipeOut.BrushColor = Base1.BrushColor = new NxtControl.Drawing.BlinkColor("SE.Nereda.Orangwhite");
			}
			if(StateValue == 100){
				PipeIn.BrushColor = PipeOut.BrushColor = Base1.BrushColor = SE.Nereda.ProjectColors.PowerOFF;
				SpeedInfo.Visible = false;
			}
			if(StateValue == 10){
				PipeIn.BrushColor = PipeOut.BrushColor = Base1.BrushColor = SE.Nereda.ProjectColors.PassiveStatus;
				SpeedInfo.Visible = false;
			}
		}

		void OpenFpClick(object sender, EventArgs e)
		{
			// TODO: Implement OpenFpClick
			//this.BaseVs.DoOpenFaceplate("fpDefault");
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
	}
}
