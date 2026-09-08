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
	public partial class sMotorVs : NxtControl.GuiFramework.HMISymbol
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
		
		// ✅ ComboBox option in PropertyGrid
        public enum StateTextPositionOption
        {
            Vertical,
            Horizontal
        }
		private StateTextPositionOption _stateTextPosition = StateTextPositionOption.Vertical;
		public sMotorVs()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			SpeedPv.FillPercent = 0;
			SpeedInfo.Visible = true;
			this.SPEED_SP_FB_Fired += SPEED_SP_FB_Fired_EventHandler;
		}

		void StateActuatorStatus(short StateValue)
		{
			// TODO: Implement StateActuatorStatus
			// =1: Started ; =0: Stopped ; =255: Error ; =100: Power Off
			SpeedInfo.Visible = true;
			if(StateValue == 0 || StateValue == 254){
				MotBase1.BrushColor = MotBase2.BrushColor = MotBase3.BrushColor = SE.Nereda.ProjectColors.PassiveStatus;
			}
			if(StateValue == 1 || StateValue == 2){
				MotBase1.BrushColor = MotBase2.BrushColor = MotBase3.BrushColor = SE.Nereda.ProjectColors.ActiveStatus;
			}
			if(StateValue == 253){
				MotBase1.BrushColor = MotBase2.BrushColor = MotBase3.BrushColor = new NxtControl.Drawing.BlinkColor("SE.Nereda.Orangwhite");
			}
			if(StateValue == 100){
				MotBase1.BrushColor = MotBase2.BrushColor = MotBase3.BrushColor = SE.Nereda.ProjectColors.PowerOFF;
				SpeedInfo.Visible = false;
			}
			if(StateValue == 10){
				MotBase1.BrushColor = MotBase2.BrushColor = MotBase3.BrushColor = SE.Nereda.ProjectColors.PassiveStatus;
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
			SpeedPv.FillPercent = (float) e.FbSpeed;
		}
		
		[RefreshProperties(RefreshProperties.Repaint)]
        [Category("Appearance")]
        [DisplayName("Motor Direction")]
        public StateTextPositionOption StateTextPosition
        {
            get { return _stateTextPosition; }
            set
            {
                _stateTextPosition = value;
                ApplyStateTextPosition(_stateTextPosition);
            }
        }
		
		// ✅ Central place to apply the chosen state text position
        private void ApplyStateTextPosition(StateTextPositionOption position)
        {
            switch (position)
            {
                case StateTextPositionOption.Horizontal:
                    // Text en haut du symbole
                    VertMot.Visible = true;
                    HoriMot.Visible = false;
                    alarmFrame.Size = new NxtControl.Drawing.SizeF(58,56);
                    State.Location = new NxtControl.Drawing.PointF(76,64);
                    break;

                case StateTextPositionOption.Vertical:
                    // Text à droite du symbole
                    VertMot.Visible = false;
                    HoriMot.Visible = true;  
                    alarmFrame.Size = new NxtControl.Drawing.SizeF(50,64);
                    State.Location = new NxtControl.Drawing.PointF(48,48);
                    break;
            }
        }
	}
}
