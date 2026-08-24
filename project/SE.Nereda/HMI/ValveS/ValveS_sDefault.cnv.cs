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

namespace SE.Nereda.Symbols.ValveS
{
	/// <summary>
	/// Description of sDefault.
	/// </summary>
	public partial class sDefault : NxtControl.GuiFramework.HMISymbol
	{
		private string _VlvName = "Valve";
		// ✅ ComboBox option in PropertyGrid
        public enum StateTextPositionOption
        {
            Vertical,
            Horizontal
        }

        private StateTextPositionOption _stateTextPosition = StateTextPositionOption.Vertical;
        
		// ✅ ComboBox option (enum) - new field for symbol name display
		public enum SymbolNameDisplayOption
		{
		    Show,
		    Hide
		}
		
		private SymbolNameDisplayOption _symbolNameDisplay = SymbolNameDisplayOption.Show;
		public sDefault()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			ManuelMode.Visible = false;
			Vertical.Visible = true;
            Horizontal.Visible = false;
            interlock.Location = new NxtControl.Drawing.PointF(49,32);
            permissive.Location = new NxtControl.Drawing.PointF(65,32);
            VlvName.Location = new NxtControl.Drawing.PointF(16,106);
            Base.Location = new NxtControl.Drawing.PointF(58,52);
            alarmFrame.Location = new NxtControl.Drawing.PointF(47,46);
            alarmFrame.Size = new NxtControl.Drawing.SizeF(34,58);
		}

		void StateActuatorStatus(short StateValue)
		{
			// TODO: Implement StateActuatorStatus
			// =1: Started ; =0: Stopped ; =255: Error ; =100: Power Off
			if(StateValue == 0 || StateValue == 254){
				VlvBase1.BrushColor = VlvBase2.BrushColor = VlvBase3.BrushColor = VlvBase4.BrushColor = SE.Nereda.ProjectColors.PassiveStatus;
			}
			if(StateValue == 1){
				VlvBase1.BrushColor = VlvBase2.BrushColor = VlvBase3.BrushColor = VlvBase4.BrushColor = SE.Nereda.ProjectColors.ActiveStatus;
			}
			if(StateValue == 253){
				VlvBase1.BrushColor = VlvBase2.BrushColor = VlvBase3.BrushColor = VlvBase4.BrushColor = new NxtControl.Drawing.BlinkColor("SE.Nereda.Orangwhite");
			}
			if(StateValue == 100){
				VlvBase1.BrushColor = VlvBase2.BrushColor = VlvBase3.BrushColor = VlvBase4.BrushColor = SE.Nereda.ProjectColors.PowerOFF;
			}
			if(StateValue == 10){
				VlvBase1.BrushColor = VlvBase2.BrushColor = VlvBase3.BrushColor = VlvBase4.BrushColor = SE.Nereda.ProjectColors.PassiveStatus;
			}
		}

		void OpenFpClick(object sender, EventArgs e)
		{
			// TODO: Implement OpenFpClick
			//this.Base.DoOpenFaceplate("fpDefault");
		}
		
		[RefreshProperties(RefreshProperties.Repaint)]
		[Category("Tagnames")]
		[DisplayName("VlvName")]
		
		public string _iVlvName
		{
			get{
				return _VlvName;
			}
			set{
				_VlvName = value;
				VlvName.Text = value.ToString();
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
		        VlvName.Visible = true;
		    }
		    else // Hide
		    {
		        VlvName.Visible = false;
		    }
		}

		void StateActManModeStatus(bool ManValue)
		{
			// TODO: Implement StateActManModeStatus
			ManuelMode.Visible = ManValue;
		}
		
		[RefreshProperties(RefreshProperties.Repaint)]
        [Category("Appearance")]
        [DisplayName("Valve Direction")]
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
                case StateTextPositionOption.Vertical:
                    // Text en haut du symbole
                    Vertical.Visible = true;
                    Horizontal.Visible = false;
                    interlock.Location = new NxtControl.Drawing.PointF(49,32);
                    permissive.Location = new NxtControl.Drawing.PointF(65,32);
                    VlvName.Location = new NxtControl.Drawing.PointF(16,106);
                    Base.Location = new NxtControl.Drawing.PointF(58,52);
                    
                    
                    alarmFrame.Location = new NxtControl.Drawing.PointF(47,46);
                    alarmFrame.Size = new NxtControl.Drawing.SizeF(34,58);
                    break;

                case StateTextPositionOption.Horizontal:
                    // Text à droite du symbole
                    Vertical.Visible = false;
                    Horizontal.Visible = true;
                    interlock.Location = new NxtControl.Drawing.PointF(16,72);
                    permissive.Location = new NxtControl.Drawing.PointF(16,88);
                    VlvName.Location = new NxtControl.Drawing.PointF(84,80);
                    Base.Location = new NxtControl.Drawing.PointF(35,83);
                    
                    alarmFrame.Location = new NxtControl.Drawing.PointF(31,67);
                    alarmFrame.Size = new NxtControl.Drawing.SizeF(57,34);
                    break;
            }
        }
	}
}
