using System;
using System.Drawing;
using NxtControl.GuiFramework;
using System.ComponentModel;
using SE.App2CommonProcess.SupportClasses;

namespace HMI.Main.Faceplates.MotorVsBase
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
			labelS6.Abnormal = (bool)e.Value;
			ModeEnablement();
		}
		
		public bool isOverrideEnabled= true;
		bool ovrrideVal;
		void FbOverrideValueChanged(object sender, ValueChangedEventArgs e)
		{
			ovrrideVal = (bool)e.Value;
			labelS7.Abnormal = (bool)e.Value && isOverrideEnabled;
			ModeEnablement();
		}
		
		void MaintenanceValueChanged(object sender, ValueChangedEventArgs e)
		{
			labelS8.Abnormal = (bool)e.Value;
		}
		
		void OutOfServiceValueChanged(object sender, ValueChangedEventArgs e)
		{
			LabelOos.Abnormal = (bool)e.Value;
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
				this.Size = new System.Drawing.Size(this.Size.Width, 416);
				labelS3.Visible = PassiveTime.Visible = false;
				disReverseAllocGroup.Location = new NxtControl.Drawing.PointF(4, 68);
			} else {
				this.Size = new System.Drawing.Size(this.Size.Width, 446);
				labelS3.Visible = PassiveTime.Visible = true;
				disReverseAllocGroup.Location = new NxtControl.Drawing.PointF(4, 98);
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
		
		
	}
}



