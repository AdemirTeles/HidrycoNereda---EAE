/*
 * Created by ApplicationLibDevTeam
 * 
 */

using System;
using System.Drawing;
using NxtControl.GuiFramework;
using System.ComponentModel;
using SE.App2CommonProcess.SupportClasses;

namespace SE.Nereda.Faceplates.MotorVsBaseNer
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
		
		#region Security Group
		
		void FpParameterSecurityModeChanged(bool isSecurity)
		{
			ModeEnablement();
		}

		void FpParameterSecurityOwnerChanged(bool isSecurity)
		{
			ModeEnablement();
		}

		void FpParameterSecurityParameterChanged(bool isSecurity)
		{
			txtMonTime.SecurityLevel = SecParameter;
			txtTripTime.SecurityLevel = SecParameter;
			PassiveTime.SecurityLevel = SecParameter;
			txtMinSp.SecurityLevel = SecParameter;
			txtMaxSp.SecurityLevel = SecParameter;
			txtMaxOut.SecurityLevel = SecParameter;
			txtMinOut.SecurityLevel = SecParameter;
			ConfResetReq.SecurityLevel = SecParameter;
			FailResetReq.SecurityLevel = SecParameter;
			btnEnSpeedOwner.SecurityLevel = SecParameter;
		}
		
		#endregion Security Group
		
		#region UserProperties
		
		private string unit = "";
		[Category("Faceplate")]
		public string Unit {
			get { return unit; }
			set {
				unit = value;
				txtMaxSp.Suffix = ConvertText(unit);
				txtMinSp.Suffix = ConvertText(unit);
				txtMinOut.Suffix = ConvertText(unit);
				txtMaxOut.Suffix = ConvertText(unit);
				txtMaxSp.Suffix = ConvertText(unit);
				txtMinSp.Suffix = ConvertText(unit);
				txtMinOut.Suffix = ConvertText(unit);
				txtMaxOut.Suffix = ConvertText(unit);
			}
		}
		
		uint decimalPlacesCount;
		[Category("Faceplate")]
		public uint DecimalPlacesCount {
			get { return decimalPlacesCount; }
			set {
				decimalPlacesCount = value;
				txtMaxSp.DecimalPlacesCount = value;
				txtMinSp.DecimalPlacesCount = value;
			}
		}
		
		#endregion UserProperties

		#region Main region
		
		bool simulValue;
		void SimulationValueChanged(object sender, ValueChangedEventArgs e)
		{
			simulValue = (bool)e.Value;
			Destaque(lSim, (bool)e.Value);
			ModeEnablement();
		}
		
		public bool isOverrideEnabled= true;
		bool ovrrideVal;
		void FbOverrideValueChanged(object sender, ValueChangedEventArgs e)
		{
			ovrrideVal = (bool)e.Value;
			Destaque(lOver, (bool)e.Value && isOverrideEnabled);
			ModeEnablement();
		}
		
		void MaintenanceValueChanged(object sender, ValueChangedEventArgs e)
		{
			Destaque(lMaint, (bool)e.Value);
		}
		
		void OutOfServiceValueChanged(object sender, ValueChangedEventArgs e)
		{
			Destaque(lOos, (bool)e.Value);
		}
		
		void SpeedSpRangeSelValueChanged(object sender, ValueChangedEventArgs e)
		{
			txtMaxSp.Enabled = txtMinSp.Enabled = !(bool)e.Value;
		}

		short fbStatus;
		void FbStatusValueChanged(object sender, ValueChangedEventArgs e)
		{
			fbStatus = (short)e.Value;
			
		}
		
		void ModeEnablement()
		{
				Over.Enabled = !simulValue && ((NxtControl.Security.ISecuritySetValues)this).IsSetValuesSecure(SecMode);
				Sim.Enabled = !ovrrideVal && ((NxtControl.Security.ISecuritySetValues)this).IsSetValuesSecure(SecMode) && ModeEn;
				Maint.Enabled = ((NxtControl.Security.ISecuritySetValues)this).IsSetValuesSecure(SecMode) && ModeEn;
				btnOutOfService.Enabled = ((NxtControl.Security.ISecuritySetValues)this).IsSetValuesSecure(SecMode) && ModeEn;
		}
		
		//Hiding and showing Passive time parameter with respect to Direction of motor.
		bool uniDirection;
		void DisReverseValueChanged(object sender, ValueChangedEventArgs e)
		{
			uniDirection = (bool)e.Value;
			
			if (uniDirection) {
				lPassivo.Visible = PassiveTime.Visible = false;
			} else {
				lPassivo.Visible = PassiveTime.Visible = true;
			}
		}
		
		#endregion Main region
		
		#region Speed Owner Config
		
		bool spdOwner;
		void SpeedOwnerValueChanged(object sender, ValueChangedEventArgs e)
		{
			spdOwner = (bool)e.Value;
		}

		bool owner;
		void CurrentOwnerValueChanged(object sender, ValueChangedEventArgs e)
		{
			owner = ((ushort)e.Value & 0x10) == 0x10;
		}

		void BtnEnSpeedOwnerOutputValueChanged(object sender, ValueChangedEventArgs e)
		{
			FireEvent_SPEED_OWNER((bool)e.Value, false, owner, false);
		}
		
		
        short fbckTransVal;
		bool ModeEn;
		void TransFbStatusValueChanged(object sender, ValueChangedEventArgs e)
		{
			fbckTransVal = (short) e.Value;
			if(fbckTransVal == 1 ||fbckTransVal ==2||fbckTransVal ==5||fbckTransVal ==6||fbckTransVal ==7)
			{
				ModeEn = false;
			}
			else
			{
				ModeEn = true;
			}
			ModeEnablement();
		}
		
		#endregion Speed Owner Config
		
		
	
		static void Destaque(FreeText f, bool ativo)
		{
			f.Color = ativo ? new NxtControl.Drawing.Color(((byte)(200)), ((byte)(90)), ((byte)(0))) : new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			f.Font = new NxtControl.Drawing.Font("Arial", 10F, ativo ? System.Drawing.FontStyle.Bold : System.Drawing.FontStyle.Regular);
		}
	}
}



