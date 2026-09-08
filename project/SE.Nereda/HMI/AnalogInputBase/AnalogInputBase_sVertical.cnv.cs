using System;
using System.Drawing;
using System.ComponentModel;
using NxtControl.GuiFramework;
using SE.App2CommonProcess.API.CustomSymbols;
using SE.App2Base.SupportClasses;
using System.Collections.Generic;
using SE.App2CommonProcess.SupportClasses;
using NxtControl.ComponentModel;

namespace SE.Nereda.Symbols.AnalogInputBase
{
	/// <summary>
	/// Description of sVertical.
	/// </summary>
	public partial class sVertical : SE.App2Base.Symbols.SEAppLibHMISymbol,SE.App2CommonProcess.SupportClasses.IPropertiesNotifyChange
	{
		AnalogInputUnit unit;
		public sVertical()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			lblInstanceName.Text = "";
			unit = new AnalogInputUnit(this);
		}
#region Abnormal
		//Override mode
		bool over;
		void OverValueChanged(object sender, ValueChangedEventArgs e)
		{
			over = (bool)e.Value;
			AbnornalIndication(over,chfailst);
		}
		//channel fail alarm
		bool chfailst;
		void ChFailureAlarmOnAbnormalDetected(bool Abnormal = false, bool ActionReq = false)
		{
			chfailst = Abnormal;
			AbnornalIndication(over,chfailst);
		}
		//Generic function to calculate abnormality
		bool AbnormalCond;
		void AbnornalIndication(bool overr,bool chfail)
		{
			AbnormalCond = overr || chfail ;
			SMeters1.Abnormal(AbnormalCond);
		}
#endregion
#region Security Group
		//***********************************************************Security Group********************************************************

		// Hide default SecurityLevel
		[Browsable(false)]
		public override int SecurityLevel{get{return base.SecurityLevel;} set{base.SecurityLevel = value;}}
		
		// Owner level Security
		[Browsable(true)]
		public override int SecOwner{ get {return base.SecOwner;} set {base.SecOwner = value;} }
		
		// Parameter level Security
		[Browsable(true)]
		public override int SecParameter{ get {return base.SecParameter;} set {base.SecParameter = value;} }

		// Setpoint level Security
		[Browsable(true)]
		public override int SecSetpoint{ get {return base.SecSetpoint;} set {base.SecSetpoint = value;} }
		
		//***********************************************************End of security Group*****************************************************
#endregion
#region Tagname

		//Hide Instance Name
	
		[DefaultValue(false), Browsable (true)]
		public override bool HideTagDisplayName {
			get {
				return base.HideTagDisplayName;
			}
			set {
				base.HideTagDisplayName = value;
				lblInstanceName.Visible = !HideTagDisplayName;
			}
		}
		
		public override void UpdateTagDisplayName()
		{
			base.UpdateTagDisplayName();
			lblInstanceName.CustomInstanceName = TagDisplayName;
			alarmFrame1.Visible = (Instancelayer != InstanceLayer.Top);
			lblInstanceName.Y = alarmFrame1.Location.Y-18;
		}
		
		
#endregion
		//Move the required data from symbol to faceplate on initialize
		protected override void OnInitializeFaceplate(HMIFaceplate hmiFaceplate)
		{
			SE.Nereda.Faceplates.AnalogInputBase.fpDefault fp = hmiFaceplate as SE.Nereda.Faceplates.AnalogInputBase.fpDefault;
			if (fp != null)
			{
				fp.TitleText = MyTagDisplayName;
				fp.Unit = Unit.EngineeringValue;
				fp.Tooltip = Tooltip;
				fp.DecimalPlacesCount = DecimalPlacesCount;
				fp.SecMode = SecMode;
				fp.SecParameter = SecParameter;
				fp.SecSetpoint = SecSetpoint;
				fp.RawUnit = Unit.RawValue;
			}
			base.OnInitializeFaceplate(hmiFaceplate);
		}
		
#region UserProperties
		// User property creation for unit, rawunit and decimal point
		[Category("Configuration")]
		[DisplayName("Unit")]
		[LRDescriptionAttribute("$key:SE.App2CommonProcess.Unit")]
		[Browsable(true)]
		[RefreshProperties(RefreshProperties.All)]
		[TypeConverter(typeof(ExpandableObjectConverter))]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		public AnalogInputUnit Unit {
			get { return unit; }
			set { unit = value; }
		}
		
		public void UpdateIProperties()
		{
			SMeters1.Unit = Unit.EngineeringValue;
		}

		
		private uint decimalPlaces=1;
		[DefaultValue(typeof(uint), "1"), RefreshProperties(RefreshProperties.All),DisplayName("Decimal places"), Category("Configuration")]
		[LRDescriptionAttribute("$key:SE.App2CommonProcess.DecimalPlacesCount")]
		public uint DecimalPlacesCount
		{
			get { return decimalPlaces; }
			set
			{
				SMeters1.DecimalPlacesCount = value;
				decimalPlaces = value;
			}
		}
		
#endregion UserProperties
		
#region Dynamics
#region PvBarGraph
		// code for SMeters bargraph function
		float barGraphMinPv = 0.0f;
		float barGraphMaxPv = 100.0f;
		float barGraphPv = 0.0f;
		
		void ExecPvValueChanged(object sender, ValueChangedEventArgs e)
		{
			barGraphPv = (float)e.Value;
			SMeters1.Value(barGraphPv, barGraphMinPv, barGraphMaxPv);
		}
		
		void ExecPvMaxValueChanged(object sender, ValueChangedEventArgs e)
		{
			barGraphMaxPv = (float)e.Value;
			SMeters1.Value(barGraphPv, barGraphMinPv, barGraphMaxPv);
		}
		
		void ExecPvMinValueChanged(object sender, ValueChangedEventArgs e)
		{
			barGraphMinPv = (float)e.Value;
			SMeters1.Value(barGraphPv, barGraphMinPv, barGraphMaxPv);
			
		}

#endregion PvBarGraph

#endregion Dynamics

		

	}
}



