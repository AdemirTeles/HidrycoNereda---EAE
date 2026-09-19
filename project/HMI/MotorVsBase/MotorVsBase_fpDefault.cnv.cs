using System;
using NxtControl.GuiFramework;
using System.ComponentModel;
using SE.App2CommonProcess.SupportClasses;
using SE.App2Base.SupportClasses;
using NxtControl.Services;

namespace HMI.Main.Faceplates.MotorVsBase
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
		
		#region Abnormal

		//The below code calls the   Abnormality function which is in base level of fpNavigationpane
		// when ever there is change in value of simulation,override and maintenance it passes the respective arguments to the function
		bool simulationVal;
		void SimulationValueChanged(object sender, ValueChangedEventArgs e)
		{
			simulationVal = (bool)e.Value;
			AbnormalIndication(simulationVal ||(overrideVal && isOverrideEnabled) || maintenanceVal || oosVal, false);
		}
		public bool isOverrideEnabled= true;
		bool overrideVal;
		void FbOverrideValueChanged(object sender, ValueChangedEventArgs e)
		{
			overrideVal = (bool)e.Value;
			AbnormalIndication(simulationVal || (overrideVal && isOverrideEnabled) || maintenanceVal || oosVal, false);
		}
		
		//Oos Value change Event
		bool oosVal;
		void OutOfServiceValueChanged(object sender, ValueChangedEventArgs e)
		{
			oosVal = (bool)e.Value;
			AbnormalIndication(simulationVal || (overrideVal && isOverrideEnabled) || maintenanceVal || oosVal, false);
			ButtonEnable();
		}

		bool maintenanceVal;
		void MaintenanceValueChanged(object sender, ValueChangedEventArgs e)
		{
			maintenanceVal = (bool)e.Value;
			AbnormalIndication(simulationVal || (overrideVal && isOverrideEnabled) || maintenanceVal || oosVal, false);
		}
		
		void AbnormalIndication(bool AbnornormalCond, bool ActionReqCond)
		{
			fpNavigationPane.Abnormality("Parameter", AbnornormalCond, ActionReqCond);
		}
		
		#endregion Abnormal

		#region SecurityGroup

		bool ownerSecVal;
		void FpDefaultSecurityOwnerChanged(bool isSecurity)
		{
			ownerSwitch.SecOwner = SecOwner;
			fpNavigationPane.SecOwner = SecOwner;
			ownerSecVal = ((NxtControl.Security.ISecuritySetValues)this).IsSetValuesSecure(SecOwner);
			ButtonEnable();
		}

		void FpDefaultSecurityParameterChanged(bool isSecurity)
		{
			fpNavigationPane.SecParameter = SecParameter;
		}
		
		bool setpointSecVal;
		void FpDefaultSecuritySetpointChanged(bool isSecurity)
		{
			fpNavigationPane.SecSetpoint = SecSetpoint;
			setpointSecVal = ((NxtControl.Security.ISecuritySetValues)this).IsSetValuesSecure(SecSetpoint);
			ButtonEnable();
		}

		#endregion SecurityGroup
		
		//Pass title,unit and decimal count that is entered when symbols are instantiated
		protected override void OnInitializeFaceplate(HMIFaceplate hmiFaceplate)
		{
			HMI.Main.Faceplates.MotorVsBase.fpParameter fp = hmiFaceplate as HMI.Main.Faceplates.MotorVsBase.fpParameter;
			if (fp != null) {
				fp.Title = Title + " " + "Parameter";
				fp.Unit = unit;
				fp.DecimalPlacesCount = decimalPlacesCount;
				fp.SecOwner = SecOwner;
				fp.SecParameter = SecParameter;
				fp.SecMode = SecMode;
				fp.SecSetpoint = SecSetpoint;
			}
			base.OnInitializeFaceplate(hmiFaceplate);
			
			HMI.Main.Faceplates.MotorVsBase.fpTrend fp1 = hmiFaceplate as HMI.Main.Faceplates.MotorVsBase.fpTrend;
			if (fp1 != null) {
				fp1.Title = Title + " " + "Trend";
			}
			
			base.OnInitializeFaceplate(hmiFaceplate);
		}
		
		//Created properties for unit,title and decimal places
		#region UserProperties
		
		string unit = "%";
		[Category("Faceplate")]
		public string Unit {
			get { return unit; }
			set {
				unit = value;
				SpeedPvValue.Tooltip = SpeedSpValue.Tooltip = SpeedOpValue.Tooltip = ConvertText(unit);
				txtSp.Tooltip = ConvertText(unit);
				SpeedPvValue.Suffix = SpeedSpValue.Suffix = SpeedOpValue.Suffix = ConvertText(unit);
				txtSp.Suffix = ConvertText(unit);
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

		uint decimalPlacesCount;
		[Category("Faceplate")]
		public uint DecimalPlacesCount {
			get { return decimalPlacesCount; }
			set {
				decimalPlacesCount = value;
				txtSp.DecimalPlacesCount = value;
				SpeedPvValue.DecimalPlacesCount = SpeedSpValue.DecimalPlacesCount = SpeedOpValue.DecimalPlacesCount = decimalPlacesCount;
				SMeters1.DecimalPlacesCount=SMeters2.DecimalPlacesCountOut=decimalPlacesCount;
				
			}
		}
		
		#endregion UserProperties

		#region Main region
		
		void ButtonEnable()
		{
			btnManualOff.Enabled = owner && setpointSecVal && spValue != 0 && !oosVal;
			btnManualReverse.Enabled = owner && setpointSecVal && spValue != 2 && !oosVal;
			btnManualForward.Enabled = owner && setpointSecVal && spValue != 1 && !oosVal;
			txtSp.Enabled = (owner && !enSpdOwner || speedOwner && enSpdOwner) && setpointSecVal && !oosVal;
			btnSpeedOwner.Enabled = ownerSecVal && enSpdOwner;
			btnReset.Enabled = needReset && setpointSecVal;
			Ownersync();
		}
		
		void Ownersync()
		{			
			if(!enSpdOwner)
				btnSpeedOwner.Checked=owner;
		}
		
		
		//Code execute to pass label as per the pv value and Direction of the motor
		string KeyFb0, KeyFb1, KeyFb2, KeyFb5, KeyFb6, KeyFb7, KeyFb253, KeySpOp0, KeySpOp1, KeySpOp2;
		void TextKeyUpdate(string Type)
		{
			if (!uniDirection) {
				
				switch (Type) {
					case "Fb":
						KeyFb0 = "$key:SE.App2CommonProcess.TxtStopped";
						KeyFb1 = "$key:SE.App2CommonProcess.TxtForward";
						KeyFb2 = "$key:SE.App2CommonProcess.TxtReverse";
						KeyFb5 = "$key:SE.App2CommonProcess.TxtTransStop";
						KeyFb6 = "$key:SE.App2CommonProcess.TxtTransForward";
						KeyFb7 = "$key:SE.App2CommonProcess.TxtTransReverse";
						KeyFb253 = "$key:SE.App2CommonProcess.TxtUnknown";
						break;
						
					case "SpOp":
						KeySpOp0 = "$key:SE.App2CommonProcess.TxtOFF";
						KeySpOp1 = "$key:SE.App2CommonProcess.TxtForward";
						KeySpOp2 = "$key:SE.App2CommonProcess.TxtReverse";
						break;
					default:
						break;
				}
			} else {
				switch (Type) {
					case "Fb":
						KeyFb0 = "$key:SE.App2CommonProcess.TxtStopped";
						KeyFb1 = "$key:SE.App2CommonProcess.TxtRunning";
						KeyFb5 = "$key:SE.App2CommonProcess.TxtTransStop";
						KeyFb6 = "$key:SE.App2CommonProcess.TxtTransStart";
						KeyFb253 = "$key:SE.App2CommonProcess.TxtUnknown";
						break;
					case "SpOp":
						KeySpOp0 = "$key:SE.App2CommonProcess.TxtOFF";
						KeySpOp1 = "$key:SE.App2CommonProcess.TxtON";
						break;
					default:
						break;
				}
			}
		}
		
		bool uniDirection;
		void DisReverseValueChanged(object sender, ValueChangedEventArgs e)
		{
			uniDirection = (bool)e.Value;
			
			if (uniDirection) {
				btnManualReverse.Visible = false;
				btnManualForward.Location = new NxtControl.Drawing.PointF(144,450);
				btnManualOff.Location = new NxtControl.Drawing.PointF(10,450);
				btnManualForward.TextKey = "SE.App2CommonProcess.BtnManActive";
				btnManualForward.Size = new NxtControl.Drawing.SizeF(114,30);
				btnManualOff.Size = new NxtControl.Drawing.SizeF(114,30);
				btnReset.Location = new NxtControl.Drawing.PointF (77,500);
				btnReset.Size = new NxtControl.Drawing.SizeF(114,30);
				fpNavigationPane.Failure.LabelPassive = CondPassiveLabelText.Off;
				fpNavigationPane.Failure.LabelActive1 = CondActive1LabelText.On;
				fpNavigationPane.Interlock.LabelPassive = CondPassiveLabelText.Off;
				fpNavigationPane.Interlock.LabelActive1 = CondActive1LabelText.On;
				fpNavigationPane.Permissive.LabelPassive = CondPassiveLabelText.Off;
				fpNavigationPane.Permissive.LabelActive1 = CondActive1LabelText.On;
				fpNavigationPane.LocalPanel.LabelPassive = CondPassiveLabelText.Off;
				fpNavigationPane.LocalPanel.LabelActive1 = CondActive1LabelText.On;
				fpNavigationPane.LocalPanel.ApplicableConditions = ApplicableInputConditions.PassiveActive;
				fpNavigationPane.Interlock.ApplicableConditions = ApplicableInputConditions.PassiveActive;
				fpNavigationPane.Permissive.ApplicableConditions = ApplicableInputConditions.PassiveActive;
			} else {
				fpNavigationPane.Failure.LabelPassive = CondPassiveLabelText.Stop;
				fpNavigationPane.Failure.LabelActive1 = CondActive1LabelText.Forward;
				fpNavigationPane.Interlock.LabelPassive = CondPassiveLabelText.Stop;
				fpNavigationPane.Interlock.LabelActive1 = CondActive1LabelText.Forward;
				fpNavigationPane.Permissive.LabelPassive = CondPassiveLabelText.Stop;
				fpNavigationPane.Permissive.LabelActive1 = CondActive1LabelText.Forward;
				fpNavigationPane.LocalPanel.LabelPassive = CondPassiveLabelText.Stop;
				fpNavigationPane.LocalPanel.LabelActive1 = CondActive1LabelText.Forward;
				fpNavigationPane.LocalPanel.ApplicableConditions = ApplicableInputConditions.PassiveActive1Active2;
				fpNavigationPane.Interlock.ApplicableConditions = ApplicableInputConditions.PassiveActive1Active2;
				fpNavigationPane.Permissive.ApplicableConditions = ApplicableInputConditions.PassiveActive1Active2;
			}
			
			labelS4.Visible = PassiveRemainTime.Visible = !uniDirection;
			lblFbStatus.Text = KeyFbStatus();
			lblCurrSp.Text = KeySpValue();
			lblReqOp.Text = KeyOpValue();
		}
		
		//Enables the rearm button to reset alarm
		bool needReset;
		void NeedResetValueChanged(object sender, ValueChangedEventArgs e)
		{
			needReset = (bool)e.Value;
			ButtonEnable();
		}
		
		string KeyFb = "KeyFb";
		string KeySp = "KeySp";
		string KeyOp = "Keyop";
		string KeyFbStatus()
		{
			TextKeyUpdate("Fb");
			
			string keyFb = "";
			
			if (((fbStatus != 1 && fbStatus != 2) && (transFbStatus == 6 || transFbStatus == 7)) || transFbStatus == 5)
				KeyFb = "KeyFb" + transFbStatus;
			else
				KeyFb = "KeyFb" + fbStatus;
			
			switch (KeyFb) {
				case "KeyFb0":
					keyFb = KeyFb0;
					break;
				case "KeyFb1":
					keyFb = KeyFb1;
					break;
				case "KeyFb2":
					keyFb = KeyFb2;
					break;
				case "KeyFb5":
					keyFb = KeyFb5;
					break;
				case "KeyFb6":
					keyFb = KeyFb6;
					break;
				case "KeyFb7":
					keyFb = KeyFb7;
					break;
				case "KeyFb253":
					keyFb = KeyFb253;
					break;
				default:
					keyFb = KeyFb0;
					break;
			}
			return 	keyFb;
		}
		
		//Read the fb Status and decide on the label keys on the faceplate and enables/dosables the manual buttons
		short fbStatus;
		void FbStatusValueChanged(object sender, ValueChangedEventArgs e)
		{
			fbStatus = (short)e.Value;
			lblFbStatus.Text = KeyFbStatus();
		}
		
		//Code execute to pass label as per the sp value
		string KeySpValue()
		{
			TextKeyUpdate("SpOp");
			
			string keySp = "";
			
			switch (KeySp) {
				case "KeySpOp0":
					keySp = KeySpOp0;
					break;
				case "KeySpOp1":
					keySp = KeySpOp1;
					break;
				case "KeySpOp2":
					keySp = KeySpOp2;
					break;
			}
			return keySp;
		}

		//Read the sp value and decide on the label keys on the faceplate
		short spValue, oldSpValue;
		void CurrentSpValueChanged(object sender, ValueChangedEventArgs e)
		{
			spValue = (short)e.Value;
			
			if (uniDirection && spValue == (short)SpOpFbState.Active2)
				KeySp = "KeySpOp" + oldSpValue;
			else {
				ButtonEnable();
				KeySp = "KeySpOp" + spValue;
				lblCurrSp.Text = KeySpValue();
				oldSpValue = spValue;
			}
		}
		
		//Code execute to pass label as per the op value
		string KeyOpValue()
		{
			TextKeyUpdate("SpOp");
			
			string keyOp = "";
			
			switch (KeyOp) {
				case "KeySpOp0":
					keyOp = KeySpOp0;
					break;
				case "KeySpOp1":
					keyOp = KeySpOp1;
					break;
				case "KeySpOp2":
					keyOp = KeySpOp2;
					break;
			}
			return keyOp;
		}
		
		//Read the output value and decide on the label keys on the faceplate
		short outValue;
		void CurrentOpValueChanged(object sender, ValueChangedEventArgs e)
		{
			outValue = (short)e.Value;
			KeyOp = "KeySpOp" + outValue;
			lblReqOp.Text = KeyOpValue();
		}
		
		bool externControlled;
		void ExternalControlledValueChanged(object sender, ValueChangedEventArgs e)
		{
			externControlled = (bool)e.Value;
			
			if (externControlled)
				lblReqOp.SuffixKey = "$key:SE.App2CommonProcess.TxtExternalControl";
			else
				lblReqOp.SuffixKey = "";
		}

		//Read the transpv value and decide on the label keys on the faceplate
		short transFbStatus;
		void TransFbStatusValueChanged(object sender, ValueChangedEventArgs e)
		{
			transFbStatus = (short)e.Value;
			lblFbStatus.Text = KeyFbStatus();
		}
		
		// Read the separate owner status for speed command
		bool enSpdOwner;
		void EnSpeedOwnerValueChanged(object sender, ValueChangedEventArgs e)
		{
			enSpdOwner = (bool)e.Value;
			ButtonEnable();
		}
		
		//Motor forward command from button in manual mode
		void BtnManualForwardClick(object sender, EventArgs e)
		{
			FireEvent_SP_CMD((short)SpOpFbState.Active1);
		}
		
		//Motor reverse command from button in manual mode
		void BtnManualReverseClick(object sender, EventArgs e)
		{
			FireEvent_SP_CMD((short)SpOpFbState.Active2);
		}
		
		//Motor stop command from button in manual mode
		void BtnManualOffClick(object sender, EventArgs e)
		{
			FireEvent_SP_CMD((short)SpOpFbState.Passive);
		}
		
		//Alarmr reset command from button
		void BtnResetClick(object sender, EventArgs e)
		{
			FireEvent_RESET_CMD(true,false);
		}
		
		float currSpeedSp = 0.0f;
		void CurrentSpeedSpValueChanged(object sender, ValueChangedEventArgs e)
		{
			currSpeedSp = (float)e.Value;
			((IHMIPrimitiveInput<float>)txtSp).ValueChanged(currSpeedSp);
			SMeters1.SpValue(currSpeedSp, barGraphMinPv, barGraphMaxPv);
		}
		
		#endregion Main region
		
		#region BarGraph
		
		float barGraphMinPv;
		float barGraphMaxPv;
		float barGraphPv = 0.0f;
		float OutMin;
		float OutMax;
		
		void SpeedSpMinValueChanged(object sender, ValueChangedEventArgs e)
		{
			txtSp.Minimum = (float)e.Value;
			barGraphMinPv = (float)e.Value;
			
			SMeters1.SpValue(currSpeedSp, barGraphMinPv, barGraphMaxPv);
			SMeters1.Value(barGraphPv, barGraphMinPv, barGraphMaxPv);
		}

		void SpeedSpMaxValueChanged(object sender, ValueChangedEventArgs e)
		{
			txtSp.Maximum = (float)e.Value;
			barGraphMaxPv = (float)e.Value;
			
			SMeters1.SpValue(currSpeedSp, barGraphMinPv, barGraphMaxPv);
			SMeters1.Value(barGraphPv, barGraphMinPv, barGraphMaxPv);
		}

		void SpeedFbStatusValueChanged(object sender, ValueChangedEventArgs e)
		{
			barGraphPv = (float)e.Value;
			SMeters1.Value(barGraphPv, barGraphMinPv, barGraphMaxPv);
		}
		
		float currSpeedOut;
		void CurrentSpeedOpValueChanged(object sender, ValueChangedEventArgs e)
		{
			currSpeedOut = (float)e.Value;
			SMeters2.OpValue(currSpeedOut, OutMin, OutMax);
		}

		void SpeedSpValueChanged(object sender, ValueChangedEventArgs e)
		{
			((IHMIPrimitiveInput<float>)txtSp).ValueChanged(currSpeedSp);
		}
		
		#endregion BarGraph

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
		
		//Read the speed owner value operator/program
		ushort currSpeedOwner;
		bool speedOwner;
		void CurrentSpeedOwnerValueChanged(object sender, ValueChangedEventArgs e)
		{
			currSpeedOwner = (ushort)e.Value;
			speedOwner = (currSpeedOwner == 0x10);
			
			switch (currSpeedOwner) {
				case 0x10:
					lblCurrSpeedOwner.Text = "$key:SE.App2CommonProcess.LabelOperator";
					break;
				case 0x40:
					lblCurrSpeedOwner.Text = "$key:SE.App2CommonProcess.LabelOperLocal";
					break;
				case 0x4:
					lblCurrSpeedOwner.Text = "$key:SE.App2CommonProcess.LabelProgLocal";
					break;
				case 0x8:
					if (stdOwnerAvail)
						lblCurrSpeedOwner.Text = "$key:SE.App2CommonProcess.LabelProgRemote";
					else
						lblCurrSpeedOwner.Text = "$key:SE.App2CommonProcess.LabelProgram";
					break;
			}
			
			FireEvent_SPEEDSP_CMD(currSpeedSp);
			
			ButtonEnable();
		}
		
		bool stdOwnerAvail;
		void StdOwnerConnectedValueChanged(object sender, ValueChangedEventArgs e)
		{
			stdOwnerAvail = (bool)e.Value;
			ownerSwitch.ExternalAvailable = stdOwnerAvail;
			ownerStatus.ExternalAvailable = stdOwnerAvail;
			
			if (currSpeedOwner == 0x8)
			{
				if (stdOwnerAvail)
					lblCurrSpeedOwner.Text = "$key:SE.App2CommonProcess.LabelProgRemote";
				else
					lblCurrSpeedOwner.Text = "$key:SE.App2CommonProcess.LabelProgram";
			}
			
			if (stdOwnerAvail)
			{
				fpNavigationPane.Owner.SymbolType = "SE.App2Base.Symbols.Owner.sOwnerConfig";
				fpNavigationPane.Owner.InstanceName = FindInstanceLayer(InstanceLayer.BaseExt)+".serviceManager.owner";
			}
		}
		
		ushort icurrentowner;
		bool owner;
		void CurrentOwnerValueChanged(object sender, ValueChangedEventArgs e)
		{
			ownerSwitch.CurrentBasicOwner = ((ushort)e.Value & 0x10) == 0x10;
			ownerStatus.CurrentBasicOwner = ((ushort)e.Value & 0x10) == 0x10;
			
			icurrentowner = (ushort)e.Value;
			owner = ((icurrentowner == 0x10)) ;
			txtSp.Value = currSpeedSp;
			
			if(!enSpdOwner)
//				((IHMIPrimitiveInput<bool>)btnSpeedOwner).ValueChanged(owner);
				btnSpeedOwner.Checked=owner;
			
			ButtonEnable();
		}
		
		#endregion

		#region Subscription of Sub CATs

		void FpDefaultUpdateOptionalService(string instancePath)
		{
			if (stdOwnerAvail)
			{
				fpNavigationPane.Owner.SymbolType = "SE.App2Base.Symbols.Owner.sOwnerConfig";
				fpNavigationPane.Owner.InstanceName = FindInstanceLayer(InstanceLayer.BaseExt)+".serviceManager.owner";
			}
			
			fpNavigationPane.Interlock.SymbolType = "SE.App2CommonProcess.Symbols.IlckCondSum.sInterlock";
			fpNavigationPane.Interlock.InstanceName = FindInstanceLayer(InstanceLayer.Top)+".interlock";
			
			fpNavigationPane.Permissive.SymbolType = "SE.App2CommonProcess.Symbols.PermCondSum.sPermissive";
			fpNavigationPane.Permissive.InstanceName =  FindInstanceLayer(InstanceLayer.Top)+".permissive";
			
			fpNavigationPane.Failure.SymbolType = "SE.App2CommonProcess.Symbols.FailCondSum.sFailure";
			fpNavigationPane.Failure.InstanceName = FindInstanceLayer(InstanceLayer.Top)+".failure";
			
			fpNavigationPane.LocalPanel.SymbolType = "SE.App2CommonProcess.Symbols.MotorVsLp.sDefault";
			fpNavigationPane.LocalPanel.InstanceName = FindInstanceLayer(InstanceLayer.Top)+".localPanel";
			
			fpNavigationPane.Maintenance.SymbolType = "SE.App2CommonProcess.Symbols.DevMnt.sDefault";
			fpNavigationPane.Maintenance.InstanceName = FindInstanceLayer(InstanceLayer.Top)+".maintenance";
			
			ownerStatus.InstanceName = FindInstanceLayer(InstanceLayer.BaseExt)+".serviceManager.owner";
			ownerSwitch.InstanceName = FindInstanceLayer(InstanceLayer.BaseExt)+".serviceManager.owner";
		}

		#endregion Subscription of Sub CATs

		#region Faceplate navigation

		//The below  code is used to open a faceplate or trend when we click on the respective symbol icons
		void FpNavigationPaneOnParameterClick()
		{
			DoOpenFaceplate("fpParameter");
		}

		void FpNavigationPaneOnTrendClick()
		{
			DoOpenFaceplate("fpTrend");
		}

		void BtnSpeedOwnerCheckedChanged(object sender, EventArgs e)
		{
			if (btnSpeedOwner.Checked)
				FireEvent_SPEED_OWNER(false,true,true,false);
			else
				FireEvent_SPEED_OWNER(false,true,false,false);
		}

		void SpeedOutMinValueChanged(object sender, ValueChangedEventArgs e)
		{
			OutMin = (float)e.Value;
			SMeters2.OpValue(currSpeedOut, OutMin, OutMax);
		}

		void SpeedOutMaxValueChanged(object sender, ValueChangedEventArgs e)
		{
			OutMax = (float)e.Value;
			SMeters2.OpValue(currSpeedOut, OutMin, OutMax);
		}
		
		

		#endregion  Faceplate navigation

		
	}
}



