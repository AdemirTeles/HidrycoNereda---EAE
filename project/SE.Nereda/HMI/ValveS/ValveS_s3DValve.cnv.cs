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
	public partial class s3DValve : NxtControl.GuiFramework.HMISymbol
	{
		private string _MotName = "Valve";
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
		public s3DValve()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			ManuelMode.Visible = false;
			Vertical.Visible = false;
            Horizontal.Visible = true;
            VlvName.Location = new NxtControl.Drawing.PointF(12,106);
            Base.Location = new NxtControl.Drawing.PointF(56,88);
		}

		void StateActuatorStatus(short StateValue)
		{
			// TODO: Implement StateActuatorStatus
			// =1: Started ; =0: Stopped ; =255: Error ; =100: Power Off
			if(StateValue == 0){
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
		}

		void OpenFpClick(object sender, EventArgs e)
		{
			// TODO: Implement OpenFpClick
			//this.Base.DoOpenFaceplate("fpDefault");
		}
		
		[RefreshProperties(RefreshProperties.Repaint)]
		[Category("Tagnames")]
		[DisplayName("VlvName")]
		
		public string _iMotName
		{
			get{
				return _MotName;
			}
			set{
				_MotName = value;
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
                    VlvName.Location = new NxtControl.Drawing.PointF(74,82);
                    Base.Location = new NxtControl.Drawing.PointF(56,88);
                    alarmFrame.Location = new NxtControl.Drawing.PointF(6,56);
                    alarmFrame.Size = new NxtControl.Drawing.SizeF(68,64);
                    break;

                case StateTextPositionOption.Horizontal:
                    // Text à droite du symbole
                    Vertical.Visible = false;
                    Horizontal.Visible = true;
                    VlvName.Location = new NxtControl.Drawing.PointF(12,106);
                    Base.Location = new NxtControl.Drawing.PointF(56,88);
                    alarmFrame.Location = new NxtControl.Drawing.PointF(30,38);
                    alarmFrame.Size = new NxtControl.Drawing.SizeF(60,66);
                    break;
            }
        }
	}
}
