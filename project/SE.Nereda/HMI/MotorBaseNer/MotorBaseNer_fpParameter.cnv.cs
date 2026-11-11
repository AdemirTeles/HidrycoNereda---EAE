/*
 * Created by ApplicationLibDevTeam
 * 
 */

using System;
using NxtControl.GuiFramework;


namespace SE.Nereda.Faceplates.MotorBaseNer
{
	/// <summary>
	/// Description of fpParamater.
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
			ConfResetReq.SecurityLevel = SecParameter;
			FailResetReq.SecurityLevel = SecParameter;
		}
		
		#endregion Security Group
		
		
		bool simulValue;
		void SimValueChanged(object sender, ValueChangedEventArgs e)
		{
			simulValue = (bool) e.Value;
			Destaque(lSim, (bool) e.Value);
			ModeEnablement();
		}
		
		public bool isOverrideEnabled= true;
		bool ovrrideVal;
		void OverValueChanged(object sender, ValueChangedEventArgs e)
		{
			ovrrideVal = (bool) e.Value;
			Destaque(lOver, (bool) e.Value && isOverrideEnabled);
			ModeEnablement();
		}

		short fbckVal;
		void PvValueChanged(object sender, ValueChangedEventArgs e)
		{
			fbckVal = (short) e.Value;
			ModeEnablement();
		}
		
		void MaintValueChanged(object sender, ValueChangedEventArgs e)
		{
			Destaque(lMaint, (bool)e.Value);
		}
		
		void OutOfServiceValueChanged(object sender, ValueChangedEventArgs e)
		{
			Destaque(lOos, (bool)e.Value);
		}

		#region Mode Buttons Enablement with Security and Conditions
		void ModeEnablement()
		{
			if (fbckVal == 1)
				 Sim.Enabled = Maint.Enabled = SwOos.Enabled = false;
			else
			{
				Over.Enabled = !simulValue && ((NxtControl.Security.ISecuritySetValues) this).IsSetValuesSecure(SecMode);
				Sim.Enabled = !ovrrideVal && ((NxtControl.Security.ISecuritySetValues) this).IsSetValuesSecure(SecMode) && ModeEn;
				Maint.Enabled = ((NxtControl.Security.ISecuritySetValues) this).IsSetValuesSecure(SecMode) && ModeEn;
				SwOos.Enabled = ((NxtControl.Security.ISecuritySetValues) this).IsSetValuesSecure(SecMode) && ModeEn;
			}
			
		}

		short fbckTransVal;
		bool ModeEn;
		void TransFbStatusValueChanged(object sender, ValueChangedEventArgs e)
		{
			fbckTransVal = (short) e.Value;
			if(fbckTransVal == 5 ||fbckTransVal ==6 ||fbckTransVal ==1)
			{
				ModeEn = false;
			}
			else
			{
				ModeEn = true;
			}
			ModeEnablement();
		}

		#endregion
	
		static void Destaque(FreeText f, bool ativo)
		{
			f.Color = ativo ? new NxtControl.Drawing.Color(((byte)(200)), ((byte)(90)), ((byte)(0))) : new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			f.Font = new NxtControl.Drawing.Font("Arial", 10F, ativo ? System.Drawing.FontStyle.Bold : System.Drawing.FontStyle.Regular);
		}
	}
}



