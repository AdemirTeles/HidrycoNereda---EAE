using System;
using System.Drawing;
using System.ComponentModel;
using NxtControl.GuiFramework;
using System.Runtime.InteropServices;

namespace HMI.Main.Faceplates.PIDBase
{
	/// <summary>
	/// Description of fpParameter.
	/// </summary>
	public partial class fpParameter : SE.App2Base.Faceplates.SEAppLibHMIFaceplate
	{
		public fpParameter()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
		}
		
		#region SecurityGroup
		
		// Parameter level security
		void FpParameterSecurityParameterChanged(bool isSecurity)
		{
			txtCycleTime.SecurityLevel = SecParameter;
			txtSpRateUp.SecurityLevel = SecParameter;
			txtSpRateDn.SecurityLevel = SecParameter;
			txtOutMin.SecurityLevel = SecParameter;
			txtOutMax.SecurityLevel = SecParameter;
			btnTrackSpInMan.SecurityLevel = SecParameter;
			txtIntegralTime.SecurityLevel = SecParameter;
			txtDerivativeTime.SecurityLevel = SecParameter;
			txtLagTime.SecurityLevel = SecParameter;
			txtGain.SecurityLevel = SecParameter;
			txtDeadband.SecurityLevel = SecParameter;
			btnDWorkOnError.SecurityLevel = SecParameter;
			btnDirection.SecurityLevel = SecParameter;
			txtFeedFwdGain.SecurityLevel = SecParameter;
			btnFeedFwdOn.SecurityLevel = SecParameter;
			btnBump.SecurityLevel = SecParameter;
			txtOutputBias.SecurityLevel = SecParameter;
			OutRate.SecurityLevel = SecParameter;
			Gain_kp.SecurityLevel = SecParameter;
			Ovs_att.SecurityLevel = SecParameter;
		}

		#endregion SecurityGroup
		
		#region UserProperties
		
		string unitPvSp = "%";
		[Category("Faceplate")]
		public string UnitPvSp {
			get { return unitPvSp; }
			set {
				unitPvSp = value;
				txtDeadband.Suffix = unitPvSp;
				CurrentDeadBand.Suffix = unitPvSp;
			}
		}
		
		string unitOut = "%";
		[Category("Faceplate")]
		public string UnitOut {
			get { return unitOut; }
			set {
				unitOut = value;
				txtOutMin.Suffix = unitOut;
				txtOutMax.Suffix = unitOut;
				CurrentOutMin.Suffix = unitOut;
				CurrentOutMax.Suffix = unitOut;
				OutRate.Suffix = unitOut + "/s";
			}
		}
		
		[Category("Faceplate")]
		public string TitleText {
			get { return Title; }
			set {
				Title = value;
				this.Tooltip = value;
			}
		}
		
		uint decimalPlacesCountPvSp = 2;
		[Category("Faceplate")]
		public uint DecimalPlacesCountPvSp {
			get { return decimalPlacesCountPvSp; }
			set {
				decimalPlacesCountPvSp = value;
				txtDeadband.DecimalPlacesCount = value;
				CurrentDeadBand.DecimalPlacesCount = value;
			}
		}
		
		uint decimalPlacesCountOut = 2;
		[Category("Faceplate")]
		public uint DecimalPlacesCountOut {
			get { return decimalPlacesCountPvSp; }
			set {
				decimalPlacesCountOut = value;
				txtOutMin.DecimalPlacesCount = value;
				txtOutMax.DecimalPlacesCount = value;
				CurrentOutMin.DecimalPlacesCount = value;
				CurrentOutMax.DecimalPlacesCount = value;
			}
		}
		
		
		#endregion UserProperties
		
		#region Main region
		
		// External PID parameters selected
		bool externalParaSel;
		void ExtParaSelValueChanged(object sender, ValueChangedEventArgs e)
		{
			externalParaSel = (bool)e.Value;

			txtGain.Visible = txtIntegralTime.Visible = txtDerivativeTime.Visible = txtLagTime.Visible = txtDeadband.Visible = btnDWorkOnError.Visible = btnDirection.Visible = txtOutMin.Visible = txtOutMax.Visible = !externalParaSel;
			CurrentGain.Visible = CurrentIntegralTime.Visible = CurrentDerivativeTime.Visible = CurrentLagTime.Visible = CurrentDeadBand.Visible = CurrentDWorkOnError.Visible = CurrentDirection.Visible = CurrentOutMin.Visible = CurrentOutMax.Visible = externalParaSel;
		}
		
		// Manual Mode disable the Outbias Text box
		short currMode;
		void CurrentModeValueChanged(object sender, ValueChangedEventArgs e)
		{
			currMode = (short)e.Value;
			txtOutputBias.Enabled = currMode == 1;
		}

		void CurrentOutbiasValueChanged(object sender, ValueChangedEventArgs e)
		{
			((IHMIPrimitiveInput<float>)txtOutputBias).ValueChanged((float)e.Value);
		}
		float currdertime;
		void CurrentDerivativeTime_1ValueChanged(object sender, ValueChangedEventArgs e)
		{
			currdertime = (float)e.Value;
			if (currdertime != dertime) {
				((IHMIPrimitiveInput<float>)txtDerivativeTime).ValueChanged(dertime);
				FireEvent_PID_CFG(currgain, true, currdertime, false, currinttime, true, 1, true, 0, true, 0, true, false, true, 0, true, false, true, false, true, 0, true);
			}
		}

		float currinttime;
		void CurrentIntegralTime_1ValueChanged(object sender, ValueChangedEventArgs e)
		{
			currinttime = (float)e.Value;
			if (currinttime != inttimeop) {
				((IHMIPrimitiveInput<float>)txtIntegralTime).ValueChanged(inttimeop);
				FireEvent_PID_CFG(currgain, true, currdertime, true, currinttime, false, 1, true, 0, true, 0, true, false, true, 0, true, false, true, false, true, 0, true);
				//txtIntegralTime.Value = currinttime;
			}
		}
		float currgain;
		void CurrentGain_1ValueChanged(object sender, ValueChangedEventArgs e)
		{
			currgain = (float)e.Value;
			if (currgain != gainop) {
				FireEvent_PID_CFG(currgain, false, currdertime, true, currinttime, true, 1, true, 0, true, 0, true, false, true, 0, true, false, true, false, true, 0, true);
				((IHMIPrimitiveInput<float>)txtGain).ValueChanged(gainop);
				//txtGain.Value = currgain;
			}
			
		
		}
		
		float gainop;
		void GainOutputValueChanged(object sender, ValueChangedEventArgs e)
		{
			gainop = (float)e.Value;
//			((IHMIPrimitiveInput<float>)txtGain).ValueChanged(gainop);
		}
		float inttimeop;
		void IntegralTimeOutputValueChanged(object sender, ValueChangedEventArgs e)
		{
			
			inttimeop = (float)e.Value;
//			((IHMIPrimitiveInput<float>)txtIntegralTime).ValueChanged(inttimeop);
		}
		float dertime;
		void DerivativeTimeOutputValueChanged(object sender, ValueChangedEventArgs e)
		{
			dertime = (float)e.Value;
//			((IHMIPrimitiveInput<float>)txtDerivativeTime).ValueChanged(dertime);
		}

		

	
		
		
		
		
		
		#endregion Main region

	}
}



