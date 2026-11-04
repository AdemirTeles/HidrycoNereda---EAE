/*
 * Created by ApplicationLibDevTeam
 * 
 */

using System;
using System.Drawing;
using NxtControl.GuiFramework;
using System.ComponentModel;
using System.Resources;
using System.Runtime.InteropServices;
using SE.App2Base.SupportClasses;
using SE.App2CommonProcess.SupportClasses;

namespace SE.Nereda.Faceplates.MotorBaseNer
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

			this.AutoScroll = false;
			
		}
		
		#region Abnormal

		//The below code call the the  Abnormality function which is in base level of fpNavigationpane
		// when ever there is change in value of simulation,override and maintenance it passes the respective arguments to the function

		bool simulationVal;
		void SimValueChanged(object sender, ValueChangedEventArgs e)
		{
			simulationVal = (bool)e.Value;
			AbnormalIndication( simulationVal|| (overrideVal && isOverrideEnabled)||maintenanceVal||oosVal,false);
			
		}
		
		public bool isOverrideEnabled= true;
		bool overrideVal;
		void OverValueChanged(object sender, ValueChangedEventArgs e)
		{
			overrideVal = (bool)e.Value;
			AbnormalIndication( simulationVal|| (overrideVal && isOverrideEnabled)||maintenanceVal||oosVal,false);
		}

		bool maintenanceVal;
		void MaintValueChanged(object sender, ValueChangedEventArgs e)
		{
			maintenanceVal = (bool)e.Value;
			AbnormalIndication( simulationVal|| (overrideVal && isOverrideEnabled)||maintenanceVal||oosVal,false);
		}
		
		bool oosVal;
		void OosValueChanged(object sender, ValueChangedEventArgs e)
		{
			oosVal = (bool)e.Value;
			AbnormalIndication( simulationVal|| (overrideVal && isOverrideEnabled)||maintenanceVal||oosVal,false);
			ButtonEnablement(Owner ,CSpValve, IsSecuritySetpoint,Req_Reset,oosVal);
		}
		
		void AbnormalIndication(bool AbnornormalCond, bool ActionReqCond)
		{
			fpNavigationPane.Abnormality("Parameter",AbnornormalCond,ActionReqCond);
		}

		#endregion Abnormal

		#region Security Group
		void FpDefaultSecurityOwnerChanged(bool isSecurity)
		{
			ownerSwitch.SecOwner = SecOwner;
			fpNavigationPane.SecOwner = SecOwner;
		}

		void FpDefaultSecurityParameterChanged(bool isSecurity)
		{
			
			fpNavigationPane.SecParameter = SecParameter;
		}

		void FpDefaultSecuritySetpointChanged(bool isSecurity)
		{
			ButtonEnablement(Owner ,CSpValve, IsSecuritySetpoint,Req_Reset,oosVal);
			fpNavigationPane.SecSetpoint = SecSetpoint;
		}
		

		#endregion Security Group


		
		protected override void OnInitializeFaceplate(HMIFaceplate hmiFaceplate)
		{
			SE.Nereda.Faceplates.MotorBaseNer.fpParameter fp = hmiFaceplate as SE.Nereda.Faceplates.MotorBaseNer.fpParameter;
			if (fp != null)
			{
				fp.Title = Title+" "+"Parameter";
				fp.SecOwner = SecOwner;
				fp.SecParameter = SecParameter;
				fp.SecMode = SecMode;
				fp.SecSetpoint = SecSetpoint;
				fp.isOverrideEnabled = isOverrideEnabled;
			}
			base.OnInitializeFaceplate(hmiFaceplate);
			
			SE.Nereda.Faceplates.MotorBaseNer.fpTrend fp1 = hmiFaceplate as SE.Nereda.Faceplates.MotorBaseNer.fpTrend;
			if (fp1 != null)
			{
				fp1.Title = Title+" "+"Trend";
				
			}
			base.OnInitializeFaceplate(hmiFaceplate);
			
		}
		
		#region UserProperties

		[DefaultValue(""), RefreshProperties(RefreshProperties.All), Category("Faceplate")]
		public string TitleText
		{
			get { return Title; }
			set
			{
				Title = value;
				fpNavigationPane.ParentTitle = value;
			}
		}

		#endregion UserProperties

		
		private bool Req_Reset;
		void NeedResetValueChanged(object sender, ValueChangedEventArgs e)
		{
			Req_Reset=(bool)e.Value;
			ButtonEnablement(Owner ,CSpValve , IsSecuritySetpoint ,Req_Reset, oosVal);
		}
		
		void BtnResetClick(object sender, EventArgs e)
		{
			FireEvent_RESET_CMD(true,false);
		}

		void BtnManOnClick(object sender, EventArgs e)
		{
			FireEvent_SP_CMD(1);
		}

		void BtnManOffClick(object sender, EventArgs e)
		{
			FireEvent_SP_CMD(0);
		}
		
		
		private short FbStatusVal;
		void FbValueChanged(object sender, ValueChangedEventArgs e)
		{
			FbStatusVal = (short)e.Value;
			if (FbStatusVal == 1)
				lblIsPv.Text = "$key:SE.App2CommonProcess.TxtRunning";
			else
				lblIsPv.Text = "$key:SE.App2CommonProcess.TxtStopped";
			
		}
		
		private short OpValue;
		void CurrentOpValueChanged(object sender, ValueChangedEventArgs e)
		{
			OpValue = (short)e.Value;
			
			if (OpValue == 1)
				lblReqOp.Text = "$key:SE.App2CommonProcess.TxtON";
			else
				lblReqOp.Text = "$key:SE.App2CommonProcess.TxtOFF";
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

		private short CSpValve;
		void CurrentSpValueChanged(object sender, ValueChangedEventArgs e)
		{	
			CSpValve = (short)e.Value;
			ButtonEnablement( Owner ,CSpValve, IsSecuritySetpoint, Req_Reset,oosVal);
			if ((short)e.Value == 1)
				lblAutoSp.Text = "$key:SE.App2CommonProcess.TxtON";
			else
				lblAutoSp.Text = "$key:SE.App2CommonProcess.TxtOFF";
		}
		
		private short TransFbVal;
		void TransFbStatusValueChanged(object sender, ValueChangedEventArgs e)
		{
			TransFbVal = (short)e.Value;
			if ((short)e.Value == 5)
			{
				lblIsPv.Text = "$key:SE.App2CommonProcess.TxtTransStop";
				
			}
			if ((short)e.Value == 6)
			{
				lblIsPv.Text = "$key:SE.App2CommonProcess.TxtTransStart";
			}
			if (((short)e.Value != 6) && ((short)e.Value != 5))
			{
				if (FbStatusVal == 1)
					
					lblIsPv.Text = "$key:SE.App2CommonProcess.TxtRunning";
				else
					lblIsPv.Text = "$key:SE.App2CommonProcess.TxtStopped";
			}
		}
		
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
		
		ushort icurrentowner;
		bool Owner;	
		void CurrentOwnerBasicValueChanged(object sender, ValueChangedEventArgs e)
		{
			ownerSwitch.CurrentBasicOwner = ((ushort)e.Value & 0x10) == 0x10;
			ownerStatus.CurrentBasicOwner = ((ushort)e.Value & 0x10) == 0x10;
			
			icurrentowner = (ushort)e.Value;
			Owner = ((icurrentowner == 0x10)) ;  // Commented CurrentOwner --On button enabling in prog mode if interlock comes
			ButtonEnablement( Owner ,CSpValve , IsSecuritySetpoint, Req_Reset,oosVal);
		}
		
		#endregion
		
		#region Command buttons Enablement
		
		public void ButtonEnablement( bool Owner ,short CSpVal , bool SecurityVal , bool Req_Reset , bool Oos)
		{
			if (Owner && SecurityVal && !Oos)
			{
				if (CSpVal == 1)
				{
					btnManOff.Enabled = true;
					btnManOn.Enabled = false;
				}
				
				if ((CSpVal == 0) && (!Req_Reset))
				{
					btnManOn.Enabled = true;
					btnManOff.Enabled = false;
				}
				else
					if ((Req_Reset) && (CSpVal == 0))
				{ btnManOn.Enabled = false;
					btnManOff.Enabled=false;}
			}
			
			else
				btnManOn.Enabled = btnManOff.Enabled = false;
			
			btnReset.Enabled = Req_Reset & SecurityVal;
		}
		#endregion
		
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
			
			fpNavigationPane.Permissive.SymbolType = "SE.App2CommonProcess.Symbols.PermCondSum.sPermissive";
			fpNavigationPane.Permissive.InstanceName =  FindInstanceLayer(InstanceLayer.Top)+".permissive";
			
			fpNavigationPane.Failure.SymbolType = "SE.App2CommonProcess.Symbols.FailCondSum.sFailure";
			fpNavigationPane.Failure.InstanceName = FindInstanceLayer(InstanceLayer.Top)+".failure";
			
			fpNavigationPane.LocalPanel.SymbolType = "SE.App2CommonProcess.Symbols.MotorLp.sDefault";
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

		#endregion  Faceplate navigation

	}
	
}



