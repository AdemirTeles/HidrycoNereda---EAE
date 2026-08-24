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

namespace SE.Nereda.Symbols.MotorS
{
	/// <summary>
	/// Description of sDefault.
	/// </summary>
	public partial class sMotor : NxtControl.GuiFramework.HMISymbol
	{
		private string _MotName = "Motor";
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
		public sMotor()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			VertMot.Visible = false;
            HoriMot.Visible = true;  
            alarmFrame.Size = new NxtControl.Drawing.SizeF(50,64);
            State.Location = new NxtControl.Drawing.PointF(48,48);
            ManuelMode.Location = new NxtControl.Drawing.PointF(28,48);
		}

		void StateActuatorStatus(short StateValue)
		{
			// TODO: Implement StateActuatorStatus
			// =1: Started ; =0: Stopped ; =255: Error ; =100: Power Off
			if(StateValue == 0 || StateValue == 254){
				MotBase1.BrushColor = MotBase2.BrushColor = MotBase3.BrushColor = MotBase4.BrushColor = MotBase5.BrushColor = MotBase6.BrushColor = SE.Nereda.ProjectColors.PassiveStatus;
			}
			if(StateValue == 1){
				MotBase1.BrushColor = MotBase2.BrushColor = MotBase3.BrushColor = MotBase4.BrushColor = MotBase5.BrushColor = MotBase6.BrushColor = SE.Nereda.ProjectColors.ActiveStatus;
			}
			if(StateValue == 253){
				MotBase1.BrushColor = MotBase2.BrushColor = MotBase3.BrushColor = MotBase4.BrushColor = MotBase5.BrushColor = MotBase6.BrushColor = new NxtControl.Drawing.BlinkColor("SE.Nereda.Orangwhite");
			}
			if(StateValue == 100){
				MotBase1.BrushColor = MotBase2.BrushColor = MotBase3.BrushColor = MotBase4.BrushColor = MotBase5.BrushColor = MotBase6.BrushColor = SE.Nereda.ProjectColors.PowerOFF;
			}
			if(StateValue == 10){
				MotBase1.BrushColor = MotBase2.BrushColor = MotBase3.BrushColor = MotBase4.BrushColor = MotBase5.BrushColor = MotBase6.BrushColor = SE.Nereda.ProjectColors.PassiveStatus;
			}
		}

		void OpenFpClick(object sender, EventArgs e)
		{
			// TODO: Implement OpenFpClick
			//this.Base.DoOpenFaceplate("fpDefault");
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

		void StateActManModeStatus(bool ManValue)
		{
			// TODO: Implement StateActManModeStatus
			ManuelMode.Visible = ManValue;
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
                    ManuelMode.Location = new NxtControl.Drawing.PointF(76,48);
                    break;

                case StateTextPositionOption.Vertical:
                    // Text à droite du symbole
                    VertMot.Visible = false;
                    HoriMot.Visible = true;  
                    alarmFrame.Size = new NxtControl.Drawing.SizeF(50,64);
                    State.Location = new NxtControl.Drawing.PointF(48,48);
                    ManuelMode.Location = new NxtControl.Drawing.PointF(28,48);
                    break;
            }
        }
	}
}
