using System;
using System.Drawing;
using System.ComponentModel;
using NxtControl.GuiFramework;
using SE.App2Base.SupportClasses;
using SE.App2CommonProcess.SupportClasses;
using NxtControl.Services;

namespace HMI.Main.Faceplates.PIDBase
{
	/// <summary>
	/// Description of fpDefault.
	/// </summary>
	public partial class fpDefault : SE.App2Base.Faceplates.SEAppLibHMIFaceplate
	{
		public fpDefault()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
		}
		
		#region SecurityGroup
		
		// Parameter level security
		void FpDefaultSecurityParameterChanged(bool isSecurity)
		{
			fpNavigationPane.SecParameter=SecParameter;
		}
		
		// Setpoint level security
		bool setpointSecurityVal;
		void FpDefaultSecuritySetpointChanged(bool isSecurity)
		{
			setpointSecurityVal = ((NxtControl.Security.ISecuritySetValues) this).IsSetValuesSecure(SecSetpoint);
			txtAutoSp.SecurityLevel = SecSetpoint;
			txtManualSp.SecurityLevel = SecSetpoint;
			fpNavigationPane.SecSetpoint = SecSetpoint;
			ButtonEnable();
		}

		// Owner level Security
		void FpDefaultSecurityOwnerChanged(bool isSecurity)
		{
			ownerSwitch.SecOwner= SecOwner;
			fpNavigationPane.SecOwner=SecOwner;
		}
		
		#endregion SecurityGroup
		
		//Pass title,unitPvSp and decimal count that is entered when symbols are instantiated
		protected override void OnInitializeFaceplate(HMIFaceplate hmiFaceplate)
		{
			HMI.Main.Faceplates.PIDBase.fpParameter fp1 = hmiFaceplate as HMI.Main.Faceplates.PIDBase.fpParameter;
			if (fp1 != null) {
				fp1.UnitPvSp = UnitPvSp;
				fp1.UnitOut = UnitOut;
				fp1.TitleText = TitleText + " " + "Parameter";
				fp1.DecimalPlacesCountPvSp = DecimalPlacesCountPvSp;
				fp1.DecimalPlacesCountOut = DecimalPlacesCountOut;
				fp1.SecParameter = SecParameter;
			}
			base.OnInitializeFaceplate(hmiFaceplate);
			
			HMI.Main.Faceplates.PIDBase.fpTrend fp2 = hmiFaceplate as HMI.Main.Faceplates.PIDBase.fpTrend;
			if (fp2 != null) {
				
				fp2.Title = TitleText + " " + "Trend";
			}
			
			base.OnInitializeFaceplate(hmiFaceplate);
		}

		#region UserProperties
		
		string unitPvSp = "%";
		[Category("Faceplate")]
		public string UnitPvSp {
			get { return unitPvSp; }
			set {
				unitPvSp = value;
				lblCurrentSp.Suffix = unitPvSp;
				lblPv.Suffix = unitPvSp;
				txtAutoSp.Suffix = unitPvSp;
				txtCurrentSp.Suffix = unitPvSp;
			}
		}
		
		string unitOut = "%";
		[Category("Faceplate")]
		public string UnitOut {
			get { return unitOut; }
			set {
				unitOut = value;
				lblCurOut.Suffix = unitOut;
				txtManualSp.Suffix = unitOut;
				txtCurrentOp.Suffix = unitOut;
			}
		}
		
		[Category("Faceplate")]
		public string TitleText {
			get { return Title; }
			set {
				Title = value;
				this.Tooltip = value;
				fpNavigationPane.ParentTitle = value;
			}
		}
		
		uint decimalPlacesCount = 2;
		[Category("Faceplate")]
		public uint DecimalPlacesCountPvSp {
			get { return decimalPlacesCount; }
			set {
				decimalPlacesCount = value;
				lblPv.DecimalPlacesCount = value;
				lblCurrentSp.DecimalPlacesCount = value;
				txtAutoSp.DecimalPlacesCount = value;
				txtCurrentSp.DecimalPlacesCount = value;
				PvSpGroup.DecimalPlacesCount = value;
			}
		}
		
		uint decimalPlacesCountOut = 2;
		[Category("Faceplate")]
		public uint DecimalPlacesCountOut {
			get { return decimalPlacesCountOut; }
			set {
				decimalPlacesCountOut = value;
				lblCurOut.DecimalPlacesCount = value;
				txtManualSp.DecimalPlacesCount = value;
				txtCurrentOp.DecimalPlacesCount = value;
				OpGroup.DecimalPlacesCountOut = value;
			}
		}
		

		
		#endregion UserProperties
		
		#region OwnerStatus
		
		ushort requestOwner;
		void OwnerSwitchOnBasicOwnerChanged(bool BasicSwitchState)
		{
			if (BasicSwitchState)
				requestOwner = (ushort)((requestOwner & (0xE7)) | 0x10);
			else
				requestOwner = (ushort)((requestOwner & ~(1 << 4)) | 0x8);
			
			FireEvent_OWNER(requestOwner);
		}
		
		bool StandardOwnerAvail;
		void StdOwnerConnectedValueChanged(object sender, ValueChangedEventArgs e)
		{
			StandardOwnerAvail = (bool)e.Value;
			ownerSwitch.ExternalAvailable = StandardOwnerAvail;
			ownerStatus.ExternalAvailable = StandardOwnerAvail;
			
			if (StandardOwnerAvail)
			{
				fpNavigationPane.Owner.SymbolType = "SE.App2Base.Symbols.Owner.sOwnerConfig";
				fpNavigationPane.Owner.InstanceName = FindInstanceLayer(InstanceLayer.BaseExt)+".serviceManager.owner";
			}
		}
		
		ushort currOwner;
		bool owner;
		void CurrentOwnerValueChanged(object sender, ValueChangedEventArgs e)
		{
			ownerSwitch.CurrentBasicOwner = ((ushort)e.Value & 0x10) == 0x10;
			ownerStatus.CurrentBasicOwner = ((ushort)e.Value & 0x10) == 0x10;
			
			currOwner = (ushort)e.Value;
			owner = currOwner == 0x10;

			CurrentSpText.Visible = !owner;

			((IHMIPrimitiveInput<float>)txtAutoSp).ValueChanged(currSp);
			((IHMIPrimitiveInput<float>)txtManualSp).ValueChanged(currOutVal);
			PidMode.Checked = currMode;
			
			ButtonEnable();
			UpdateSpManagement();
		}
		
		#endregion OwnerStatus
		
		#region Interlock & Failure status
		
		bool ilckCondVal;
		void IlckCondValueChanged(object sender, ValueChangedEventArgs e)
		{
			ilckCondVal = (bool)e.Value;
			UpdateSpManagement();
		}
		
		#endregion Interlock & Failure status

		#region Main region
		
		void ButtonEnable()
		{
			PidMode.Enabled = slaveReady && owner && setpointSecurityVal;
		}
		
		bool currMode;
		void CurrentModeValueChanged(object sender, ValueChangedEventArgs e)
		{
			currMode = (short)e.Value == 1;
			PidMode.Checked = currMode;
			modeVal =Convert.ToInt16(currMode);
			FireEvent_PID_CFG(0,true,0,true,0,true,Convert.ToInt16(modeVal),false,0,true,0,true,false,true,0,true,false,true,false,true,0,true);
			if (currMode)
				lblPidMode.Text = "$key:SE.App2CommonProcess.TxtAuto";
			else
				lblPidMode.Text = "$key:SE.App2CommonProcess.TxtMan";
			
			((IHMIPrimitiveInput<float>)txtAutoSp).ValueChanged(currSp);
			((IHMIPrimitiveInput<float>)txtManualSp).ValueChanged(currOutVal);

			UpdateSpManagement();
		}
		
		short modeVal = -1;
		void ModeValueChanged(object sender, ValueChangedEventArgs e)
		{
			modeVal = (short)e.Value;
		}
		
		void PidModeCheckedChanged(object sender, EventArgs e)
		{
			if (owner && modeVal >= 0 && currMode != PidMode.Checked)
				FireEvent_PID_CFG(0,true,0,true,0,true,Convert.ToInt16(PidMode.Checked),false,0,true,0,true,false,true,0,true,false,true,false,true,0,true);
		}
		
		bool trackSpInMan;
		void TrackSpInManualValueChanged(object sender, ValueChangedEventArgs e)
		{
			trackSpInMan = (bool)e.Value;
			UpdateSpManagement();
		}
		
		bool trackSpVisible;
		void UpdateSpManagement()
		{
			trackSpVisible = currOwner == 0x10 && trackSpInMan;

			txtAutoSp.Visible = owner && currMode && slaveReady;
			txtCurrentSp.Visible = !txtAutoSp.Visible;
			txtManualSp.Enabled = !ilckCondVal;
			txtManualSp.Visible = owner && !currMode && slaveReady;
			txtCurrentOp.Visible = !txtManualSp.Visible;
			
			
			if (owner && SpOutVal != currSp)
			{
				FireEvent_SP_CMD(currSp);
			}

		}
		
		void TrackSpInManValueChanged(object sender, ValueChangedEventArgs e)
		{
			UpdateSpManagement();
		}
		
		void OutChProhibitedValueChanged(object sender, ValueChangedEventArgs e)
		{
			outProhibited.Visible = (bool)e.Value;
		}
		
		bool slaveReady;
		void TrackOutputValueChanged(object sender, ValueChangedEventArgs e)
		{
			slaveReady = !(bool)e.Value;
			
			ButtonEnable();
			UpdateSpManagement();
			
			((IHMIPrimitiveInput<float>)txtAutoSp).ValueChanged(currSp);
			((IHMIPrimitiveInput<float>)txtManualSp).ValueChanged(currOutVal);
		}
		
		#endregion Main region
		
		#region GraphRangeUpdate

		float barGraphMinPv;
		float barGraphMaxPv;

		float outMinVal;
		void ExecOutMinValueChanged(object sender, ValueChangedEventArgs e)
		{
			outMinVal = (float)e.Value;
			txtManualSp.Minimum = (float)e.Value;
			OpGroup.OpValue(currOutVal, outMinVal, outMaxVal);
		}
		
		float outMaxVal;
		void ExecOutMaxValueChanged(object sender, ValueChangedEventArgs e)
		{
			outMaxVal = (float)e.Value;
			txtManualSp.Maximum = (float)e.Value;
			OpGroup.OpValue(currOutVal, outMinVal, outMaxVal);
		}

		void ExecPvMaxValueChanged(object sender, ValueChangedEventArgs e)
		{
			txtAutoSp.Maximum = (float)e.Value;
			barGraphMaxPv = (float)e.Value;
			PvSpGroup.Value(pvVal, barGraphMinPv, barGraphMaxPv);
		}
		
		void ExecPvMinValueChanged(object sender, ValueChangedEventArgs e)
		{
			txtAutoSp.Minimum = (float)e.Value;
			barGraphMinPv = (float)e.Value;
			PvSpGroup.Value(pvVal, barGraphMinPv, barGraphMaxPv);
		}

		float pvVal;
		void PvValueChanged(object sender, ValueChangedEventArgs e)
		{
			pvVal = (float)e.Value;
			PvSpGroup.Value(pvVal, barGraphMinPv, barGraphMaxPv);
			UpdateSpManagement();
		}
		
		float currSp;
		void CurrentSpValueChanged(object sender, ValueChangedEventArgs e)
		{
			currSp = (float)e.Value;
			((IHMIPrimitiveInput<float>)txtAutoSp).ValueChanged(currSp);
			CurrentSpText.Text = currSp.ToString("N" + DecimalPlacesCountPvSp);
			PvSpGroup.SpValue(currSp, barGraphMinPv, barGraphMaxPv);
		}

		
		float currOutVal;
		void CurrentOpValueChanged(object sender, ValueChangedEventArgs e)
		{
			currOutVal = (float)e.Value;
			((IHMIPrimitiveInput<float>)txtManualSp).ValueChanged(currOutVal);
			OpGroup.OpValue(currOutVal, outMinVal, outMaxVal);
		}
		
		float SpOutVal;
		void SpValueChanged(object sender, ValueChangedEventArgs e)
		{
			SpOutVal = (float)e.Value;
		}
		#endregion GraphRangeUpdate

		#region Subscription of Sub CATs

		void FpDefaultUpdateOptionalService(string instancePath)
		{
			if (StandardOwnerAvail)
			{
				fpNavigationPane.Owner.SymbolType = "SE.App2Base.Symbols.Owner.sOwnerConfig";
				fpNavigationPane.Owner.InstanceName = FindInstanceLayer(InstanceLayer.BaseExt)+".serviceManager.owner";
			}
			
			fpNavigationPane.Interlock.SymbolType = "SE.App2CommonProcess.Symbols.IlckCondSum.sInterlock";
			fpNavigationPane.Interlock.InstanceName = FindInstanceLayer(InstanceLayer.Top)+".interlock";
			
			//fpNavigationPane.SSC.SymbolType = "SE.App2CommonProcess.Symbols.PIDSSCSeqData.sDefault";
			//fpNavigationPane.SSC.InstanceName = FindInstanceLayer(InstanceLayer.Top)+".sc";
			
			if ( FindCATSymbolType(FindInstanceLayer(InstanceLayer.Top)+".sc","sDefault") != null)
			{
				fpNavigationPane.SSC.SymbolType = FindCATSymbolType(FindInstanceLayer(InstanceLayer.Top)+".sc","sDefault");
				fpNavigationPane.SSC.InstanceName = FindInstanceLayer(InstanceLayer.Top)+".sc";
			}
			
			ownerStatus.InstanceName = FindInstanceLayer(InstanceLayer.BaseExt)+".serviceManager.owner";
			ownerSwitch.InstanceName = FindInstanceLayer(InstanceLayer.BaseExt)+".serviceManager.owner";
			
			
		}
		
		#endregion Subscription of Sub CATs

		#region Faceplate Navigation
		
		//Open parameter faceplate
		void FpNavigationPaneOnParameterClick()
		{
			DoOpenFaceplate("fpParameter");
		}
		
		//Open trend faceplate
		void FpNavigationPaneOnTrendClick()
		{
			DoOpenFaceplate("fpTrend");
		}

		#endregion Faceplate Navigation
		
		
		
	}
}



