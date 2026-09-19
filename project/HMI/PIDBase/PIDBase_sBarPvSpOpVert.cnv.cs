using System;
using System.Drawing;
using NxtControl.GuiFramework;
using System.ComponentModel;
using SE.App2Base.SupportClasses;
using SE.App2CommonProcess.SupportClasses;
using NxtControl.Services;
using NxtControl.ComponentModel;

namespace HMI.Main.Symbols.PIDBase
{
	/// <summary>
	/// Description of sBarPvSpOpVert.
	/// </summary>
	public partial class sBarPvSpOpVert : SE.App2Base.Symbols.SEAppLibHMISymbol,SE.App2CommonProcess.SupportClasses.IPropertiesNotifyChange
	{
		PIDUnit unit;
		PIDDecimalPlacesCount decimalPlacesCount;
		public sBarPvSpOpVert()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			InstanceName.Text = "PID";
			unit = new PIDUnit(this);
			decimalPlacesCount = new PIDDecimalPlacesCount(this);
		}
		
		public override void EndInit()
		{
			base.EndInit();
			
			var hmiManagementService = (IHMIManagementService)ServiceProvider.GetService(typeof(IHMIManagementService));
			if (hmiManagementService == null)
				return;
			AbnornalIndication(interlockBypass,ownerAbnormal,interlockActReq);
		}
		
		#region Abnormality

		/*whenever there is a abnormality detected on interlock,permissive,failure,owner respective events are triggered and this data is passed as a argument to
 			the Abnormal Indication Function
		
		 * when ever there is a Action required detected on Interlock this will be notified through the event and these data are passed
			to the AbnormalIndication Function*/

		//Interlock  Abnormal Detected Event
		/*when ever there is a bypass of interlock conditon it is notified through Abnormal argument of the below event
		 *When ever there is a Rearm Required for the Interlock condition it is notified through the Action Required argument from the below event*/
		bool interlockBypass = false;
		bool interlockActReq = false;
		void InterlockOnAbnormalDetected(bool Abnormal, bool ActionReq)
		{
			interlockBypass = Abnormal;
			interlockActReq = ActionReq;
			AbnornalIndication(interlockBypass,ownerAbnormal,interlockActReq);
		}
		
		//Owner Abnormal Detected Event
		/* when a respective owner is unchecked as Normal Owner from the faceplate and if the current Owner is unchecked normal owner then the abnormality is notified
		 *through the below event */
		bool ownerAbnormal = false;
		void OwnerOnAbnormalDetected(bool Abnormal, bool ActionReq)
		{
			ownerAbnormal = Abnormal;
			AbnornalIndication(interlockBypass,ownerAbnormal,interlockActReq);
		}

		//Abnormality function
		//when ever there is a abnormality this function passes the value to the  function Abnormality derived in base symbol
		bool AbnormalVal;
		bool ActionReqVal;
		void AbnornalIndication(bool ilckAbnormal, bool OwnerAbnormal, bool ilckActionReq)
		{
			AbnormalVal = ilckAbnormal|| OwnerAbnormal ;
			ActionReqVal = ilckActionReq;
			PvSpGroup.Abnormal(AbnormalVal,ActionReqVal);
			OpGroup.Abnormal(AbnormalVal,ActionReqVal);
		}
		
		#endregion Abnormality
		
		#region Security Group
		
		/* The below code exposes a property of Security group when ever a symbol is instantiated on the canvas
		 * code is overriding the defined values in Base class(SE.App2Base.Symbols.SEAppLibHMISymbol)
		 * Security group contains 4 categorised Parameters with default values as Mode=6, Parameter = 12, Owner = 3, Setpoint = 3
		 * Objects can be enabled/disabled based on the security parameter provided to it compared with respective to the Login credentials*/
		
		// Hide default SecurityLevel
		[Browsable(false)]
		public override int SecurityLevel{get{return base.SecurityLevel;} set{base.SecurityLevel = value;}}
		
		// Owner level Security
		[DefaultValue(3),Browsable(true)]
		public override int SecOwner{ get {return base.SecOwner;} set {base.SecOwner = value;} }
		
		// Parameter level Security
		[DefaultValue(12),Browsable(true)]
		public override int SecParameter{ get {return base.SecParameter;} set {base.SecParameter = value;} }

		// Setpoint level Security
		[DefaultValue(3),Browsable(true)]
		public override int SecSetpoint{ get {return base.SecSetpoint;} set {base.SecSetpoint = value;} }
		
		#endregion  Security Group

		#region Instance name
		
		//Hide Instance Name
	
		[DefaultValue(false), Browsable (true)]
		public override bool HideTagDisplayName {
			get {
				return base.HideTagDisplayName;
			}
			set {
				base.HideTagDisplayName = value;
				InstanceName.Visible = !HideTagDisplayName;
			}
		}

		public override void UpdateTagDisplayName()
		{
			base.UpdateTagDisplayName();
			InstanceName.CustomInstanceName = TagDisplayName;
		}
		
		#endregion Instance name
		
		protected override void OnInitializeFaceplate(HMIFaceplate hmiFaceplate)
		{
			HMI.Main.Faceplates.PIDBase.fpDefault fp = hmiFaceplate as HMI.Main.Faceplates.PIDBase.fpDefault;
			if (fp != null)
			{
				fp.TitleText = MyTagDisplayName;
				fp.Tooltip = this.Tooltip;
				fp.UnitPvSp = Unit.PvSpValue;
				fp.UnitOut = Unit.OutValue;
				fp.DecimalPlacesCountPvSp = (uint)DecimalPlacesCount.PvSpValue;
				fp.DecimalPlacesCountOut = (uint)DecimalPlacesCount.OutValue;
				fp.SecParameter = SecParameter;
				fp.SecSetpoint = SecSetpoint;
				fp.SecOwner = SecOwner;
			}
			
			base.OnInitializeFaceplate(hmiFaceplate);
		}
		
		#region UserProperties

		[Category("Configuration")]
		[DisplayName("Unit")]
		[LRDescriptionAttribute("$key:SE.App2CommonProcess.Unit")]
		[Browsable(true)]
		[RefreshProperties(RefreshProperties.All)]
		[TypeConverter(typeof(ExpandableObjectConverter))]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		public PIDUnit Unit {
			get { return unit; }
			set { unit = value; }
		}
		
		[Category("Configuration")]
		[DisplayName("Decimal Places")]
		[LRDescriptionAttribute("$key:SE.App2CommonProcess.DecimalPlacesCount")]
		[Browsable(true)]
		[RefreshProperties(RefreshProperties.All)]
		[TypeConverter(typeof(ExpandableObjectConverter))]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		public PIDDecimalPlacesCount DecimalPlacesCount  {
			get { return decimalPlacesCount; }
			set { decimalPlacesCount = value; }
		}		
		
		
		PidDisplayType iDisplayType = PidDisplayType.PvSpOp;
		[Category("Configuration")]
		[DefaultValue("")]
		[DisplayName("Display Type")]
		[LRDescriptionAttribute("$key:SE.App2CommonProcess.DisplayType")]
		[Browsable(true)]
		public PidDisplayType DisplayType
		{
			get { return iDisplayType;}
			set
			{
				iDisplayType = value;
				SetView();
			}
		}

		public void UpdateIProperties()
		{
			PvSpGroup.Unit = Unit.PvSpValue;
			OpGroup.Unit = Unit.OutValue;
			PvSpGroup.DecimalPlacesCount =  (uint)DecimalPlacesCount.PvSpValue;
			OpGroup.DecimalPlacesCountOut = (uint)DecimalPlacesCount.OutValue;
		}
		
		#endregion UserProperties

		#region DisplayTypeSelection

		NxtControl.Drawing.PointF PvSpIlckGrpLocation=  new NxtControl.Drawing.PointF(48,32);
		NxtControl.Drawing.PointF PvSpInstGrpLocation =  new NxtControl.Drawing.PointF(24,8);
		NxtControl.Drawing.PointF PvSpOPInstGrpLocation =  new NxtControl.Drawing.PointF(33,8);
		NxtControl.Drawing.PointF OpIlckGrpLocation=  new NxtControl.Drawing.PointF(138,32);
		NxtControl.Drawing.PointF OpInstGrpLocation =  new NxtControl.Drawing.PointF(76,8);
		
		public void SetView()
		{
			switch (DisplayType) {
				case PidDisplayType.PvSpOp:
					PvSpGroup.Visible = true;
					OpGroup.Visible = true;
					OpGroup.AbnormalVisible = false;
					interlock.Location = PvSpIlckGrpLocation;
					owner.Location = new NxtControl.Drawing.PointF(PvSpIlckGrpLocation.X,PvSpIlckGrpLocation.Y+17);
					InstanceName.Location = PvSpOPInstGrpLocation;
					clickFrame.Location = PvSpGroup.Location;
					clickFrame.Size = new NxtControl.Drawing.SizeF(PvSpGroup.Size.Width,PvSpGroup.Size.Height);
					break;
				case  PidDisplayType.PvSp:
					PvSpGroup.Visible = true;
					OpGroup.Visible = false;
					OpGroup.AbnormalVisible = false;
					interlock.Location = PvSpIlckGrpLocation;
					owner.Location = new NxtControl.Drawing.PointF(PvSpIlckGrpLocation.X,PvSpIlckGrpLocation.Y+17);
					InstanceName.Location = PvSpInstGrpLocation;
					clickFrame.Location = PvSpGroup.Location;
					clickFrame.Size = PvSpGroup.Size;
					break;
				default:
					PvSpGroup.Visible = false;
					OpGroup.Visible = true;
					OpGroup.AbnormalVisible = true;
					interlock.Location = OpIlckGrpLocation;
					owner.Location = new NxtControl.Drawing.PointF(OpIlckGrpLocation.X,OpIlckGrpLocation.Y+17);
					InstanceName.Location = OpInstGrpLocation;
					clickFrame.Location = OpGroup.Location;
					clickFrame.Size = OpGroup.Size;
					break;
			}
		}
		
		#endregion DisplayTypeSelection
		
		#region GraphRangeUpdate
		
		float outMinVal;
		void OutMinValueChanged(object sender, ValueChangedEventArgs e)
		{
			outMinVal = (float)e.Value;
			OpGroup.OpValue(currOut, outMinVal, outMaxVal);
		}
		
		float outMaxVal;
		void OutMaxValueChanged(object sender, ValueChangedEventArgs e)
		{
			outMaxVal = (float)e.Value;
			OpGroup.OpValue(currOut, outMinVal, outMaxVal);
		}
		
		float barGraphMinPv;
		float barGraphMaxPv;
		void PvMaxValueChanged(object sender, ValueChangedEventArgs e)
		{
			barGraphMaxPv = (float)e.Value;
			PvSpGroup.Value(pvValue, barGraphMinPv, barGraphMaxPv);
		}
		
		void PvMinValueChanged(object sender, ValueChangedEventArgs e)
		{
			barGraphMinPv = (float)e.Value;
			PvSpGroup.Value(pvValue, barGraphMinPv, barGraphMaxPv);
		}
		
		float pvValue;
		void PvValueChanged(object sender, ValueChangedEventArgs e)
		{
			pvValue = (float)e.Value;
			PvSpGroup.Value(pvValue, barGraphMinPv, barGraphMaxPv);
		}
		
		float currSp;
		void CurrentSpValueChanged(object sender, ValueChangedEventArgs e)
		{
			currSp = (float)e.Value;
			PvSpGroup.SpValue(currSp, barGraphMinPv, barGraphMaxPv);
		}
		
		float currOut;
		void CurrentOpValueChanged(object sender, ValueChangedEventArgs e)
		{
			currOut = (float)e.Value;
			OpGroup.OpValue(currOut, outMinVal, outMaxVal);
		}
		
		#endregion GraphRangeUpdate
		
		#region Subscription
		
		void SBarPvSpOpVertUpdateOptionalService(string instancePath)
		{
			owner.InstanceName = FindInstanceLayer(InstanceLayer.BaseExt) + ".serviceManager.owner";
			interlock.InstanceName = FindInstanceLayer(InstanceLayer.Top) + ".interlock";
		}
		
		#endregion Subscription
		
		#region Interlock, Owner Signal Update
		
		void IlckCondValueChanged(object sender, ValueChangedEventArgs e)
		{
			interlock.InterlockSignal = (bool)e.Value;
		}
		
		bool stdOwner;
		void StdOwnerConnectedValueChanged(object sender, ValueChangedEventArgs e)
		{
			stdOwner = (bool)e.Value;
			owner.ExternalAvailable = stdOwner;
		}
		void CurrentOwnerValueChanged(object sender, ValueChangedEventArgs e)
		{
			owner.BasicOwner = (ushort)e.Value;
		}

		#endregion Interlock, Owner Signal Update
		
	}
}



