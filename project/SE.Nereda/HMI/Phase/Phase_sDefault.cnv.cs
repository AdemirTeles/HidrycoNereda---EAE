/*
 * Created by EcoStruxure Automation Expert.
 * User: SESA713705
 * Date: 6/4/2026
 * Time: 5:16 PM
 * 
 */

using System;
using System.Drawing;
using NxtControl.GuiFramework;
using System.ComponentModel;

namespace SE.Nereda.Symbols.Phase
{
	/// <summary>
	/// Description of sDefault.
	/// </summary>
	public partial class sDefault : NxtControl.GuiFramework.HMISymbol
	{
		int TimeS;
		int TimeM;
		int TimeH;
		int TimePv;
		private string _ReactorID = "";
		string InDisplayPhaseName;
		string InReactorID;
		bool ShowReactorID;
		// ✅ ComboBox option in PropertyGrid
        public enum ShowReactorName
        {
            ReactorName,
            NoReactorName
        }
        private ShowReactorName _stateTextPosition = ShowReactorName.NoReactorName;
		public sDefault()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			this.CURR_TIME_Fired += CURR_TIME_Fired_EventHandler;
		}
		
		[RefreshProperties(RefreshProperties.Repaint)]
        [Category("Appearance")]
        [DisplayName("Valve Direction")]
        public ShowReactorName StateTextPosition
        {
            get { return _stateTextPosition; }
            set
            {
                _stateTextPosition = value;
                ApplyShowReactorName(_stateTextPosition);
            }
        }

        // ✅ Central place to apply the chosen state text position
        private void ApplyShowReactorName(ShowReactorName position)
        {
            switch (position)
            {
                case ShowReactorName.NoReactorName:
                    // Text en haut du symbole
                    ShowReactorID = false;
                    PhaseName();
                    break;

                case ShowReactorName.ReactorName:
                    // Text à droite du symbole
                    ShowReactorID = true;
                    PhaseName();
                    break;
            }
        }
        
        [RefreshProperties(RefreshProperties.Repaint)]
		[Category("Tagnames")]
		[DisplayName("ReactorID")]
		
		public string _iReactorID
		{
			get{
				return _ReactorID;
			}
			set{
				_ReactorID = value;
				InReactorID = value.ToString();
			}
		}
		
		void PhaseName(){
			if(ShowReactorID == true){
				DisplayPhaseName.Text = InReactorID + ": " + InDisplayPhaseName;
			}
			else{
				DisplayPhaseName.Text = InDisplayPhaseName;
			}
		}

		void PhaseNameValueChanged(object sender, ValueChangedEventArgs e)
		{
			// TODO: Implement PhaseNameValueChanged
			InDisplayPhaseName = (string) e.Value;
			PhaseName();
		}

		void CurrPhaseStateValueChanged(object sender, ValueChangedEventArgs e)
		{
			// TODO: Implement CurrPhaseStateValueChanged
			DisplayPhaseState.Text = (string) e.Value;
		}

		void CurrPhaseTimeValueChanged(object sender, ValueChangedEventArgs e)
		{
			// TODO: Implement CurrPhaseTimeValueChanged
//			TimePv = (int) e.Value;
//			TimeH =  TimePv / 3600;
//			TimeM = (TimePv % 3600) / 60;
//			TimeS = TimePv % 60;
//			
//			DisplayPhaseTime.Text = TimeH.ToString() + "h " + ": " + TimeM.ToString() + "min " + ": " + TimeS.ToString() + "s";
		}

		void READYValueChanged(object sender, ValueChangedEventArgs e)
		{
			// TODO: Implement READYValueChanged
			if((bool)e.Value == true){
				DisplayPhaseState.TextColor = new NxtControl.Drawing.Color(0,0,0);
				DisplayPhaseState.PenColor = new NxtControl.Drawing.Color(210, 210, 210);
				OpCdt.PenColor = new NxtControl.Drawing.Color(0,0,0);
				OpCdt.Pen.Width = 1;
			}
		}

		void STARTINGValueChanged(object sender, ValueChangedEventArgs e)
		{
			// TODO: Implement STARTINGValueChanged
			if((bool)e.Value == true){
				DisplayPhaseState.TextColor = new NxtControl.Drawing.Color(0,0,0);
				DisplayPhaseState.PenColor = new NxtControl.Drawing.Color(0, 0, 255);
				OpCdt.PenColor = new NxtControl.Drawing.Color(0,0,0);
				OpCdt.Pen.Width = 1;
			}
		}

		void RUNValueChanged(object sender, ValueChangedEventArgs e)
		{
			// TODO: Implement RUNValueChanged
			if((bool)e.Value == true){
				DisplayPhaseState.TextColor = new NxtControl.Drawing.Color(0,0,0);
				DisplayPhaseState.PenColor = new NxtControl.Drawing.Color(0,255,0);
				OpCdt.PenColor = new NxtControl.Drawing.Color(0,0,0);
				OpCdt.Pen.Width = 1;
			}
		}

		void STOPPINGValueChanged(object sender, ValueChangedEventArgs e)
		{
			// TODO: Implement STOPPINGValueChanged
			if((bool)e.Value == true){
				DisplayPhaseState.TextColor = new NxtControl.Drawing.Color(0,0,0);
				DisplayPhaseState.PenColor = new NxtControl.Drawing.Color(0, 0, 255);
				OpCdt.PenColor = new NxtControl.Drawing.Color(0,0,0);
				OpCdt.Pen.Width = 1;
			}
		}

		void ABORTINGValueChanged(object sender, ValueChangedEventArgs e)
		{
			// TODO: Implement ABORTINGValueChanged
			if((bool)e.Value == true){
				DisplayPhaseState.TextColor = new NxtControl.Drawing.Color(0,0,0);
				DisplayPhaseState.PenColor = new NxtControl.Drawing.BlinkColor("SE.Nereda.Orangwhite");
				OpCdt.PenColor = new NxtControl.Drawing.BlinkColor("SE.Nereda.DevLEDRedFlash");
				OpCdt.Pen.Width = 2;
			}
		}

		void ABORTEDValueChanged(object sender, ValueChangedEventArgs e)
		{
			// TODO: Implement ABORTEDValueChanged
			if((bool)e.Value == true){
				DisplayPhaseState.TextColor = new NxtControl.Drawing.Color(255,0,0);
				DisplayPhaseState.PenColor = new NxtControl.Drawing.BlinkColor("SE.Nereda.DevLEDRedFlash");
				OpCdt.PenColor = new NxtControl.Drawing.BlinkColor("SE.Nereda.DevLEDRedFlash");
				OpCdt.Pen.Width = 2;
			}
		}

		void INTERLOCKEDValueChanged(object sender, ValueChangedEventArgs e)
		{
			// TODO: Implement INTERLOCKEDValueChanged
			if((bool)e.Value == true){
				DisplayPhaseState.TextColor = new NxtControl.Drawing.Color(255,0,0);
				DisplayPhaseState.PenColor = new NxtControl.Drawing.Color(255,0,0);
				OpCdt.PenColor = new NxtControl.Drawing.BlinkColor("SE.Nereda.DevLEDRedFlash");
				OpCdt.Pen.Width = 2;
			}
		}

		void CURR_TIME_Fired_EventHandler(object sender, CURR_TIMEEventArgs e)
		{
			// TODO: Implement CURR_TIME_Fired_EventHandler
			TimePv = (int) e.CurrPhaseTime;
			TimeH =  TimePv / 3600;
			TimeM = (TimePv % 3600) / 60;
			TimeS = TimePv % 60;
			
			DisplayPhaseTime.Text = TimeH.ToString() + "h " + ": " + TimeM.ToString() + "min " + ": " + TimeS.ToString() + "s";
		}
	}
}
