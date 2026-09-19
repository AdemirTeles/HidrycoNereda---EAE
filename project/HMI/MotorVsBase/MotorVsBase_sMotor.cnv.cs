using System;
using NxtControl.GuiFramework;
using System.ComponentModel;
using SE.App2CommonProcess.SupportClasses;
using SE.App2Base.SupportClasses;
using System.Reflection;
using NxtControl.Services;
using NxtControl.ComponentModel;
using System.Collections.Generic;

namespace HMI.Main.Symbols.MotorVsBase
{
	/// <summary>
	/// Description of sMotor.
	/// </summary>
	public partial class sMotor : SE.App2Base.Symbols.SEAppLibHMISymbol, IPropertiesNotifyChange
	{
		MotorAppearance motorAppearance;
		public sMotor()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			InstanceName.Text = "MotorVs";
			motorAppearance = new MotorAppearance(this);
			SymbolGroup = new NxtControl.GuiFramework.Group();
			SymbolGroup.BeginInit();
			SymbolGroup.Visible = false;
			SymbolGroup.Shapes.AddRange(getSymbolsGroup(false));
			this.shapes.AddRange(new System.ComponentModel.IComponent[] { SymbolGroup });
			SymbolGroup.EndInit();
			
			
			FrameGroup = new NxtControl.GuiFramework.Group();
			FrameGroup.BeginInit();
			FrameGroup.Visible = false;
			FrameGroup.Shapes.AddRange(getSymbolsGroup(true));
			this.shapes.AddRange(new System.ComponentModel.IComponent[] { FrameGroup });
			FrameGroup.EndInit();
		}
		private IComponent[] getSymbolsGroup(bool GetAll)
		{
			var requiredCollection = new List<IComponent>();
			var shapeCollect = this.Shapes;
			if (!GetAll) {
				foreach (IComponent element in shapeCollect) {
					if (element.GetType().FullName.StartsWith("System.HMI.Symbols.Base.Execute<", StringComparison.OrdinalIgnoreCase) || element is NxtControl.GuiFramework.AlarmFrame || element is NxtControl.GuiFramework.AliasDisplayLabel) {
						continue;
					} else {
						requiredCollection.Add(element);
					}
				}
			} else {
				foreach (IComponent element in shapeCollect) {
					if (element.GetType().FullName.StartsWith("System.HMI.Symbols.Base.Execute<", StringComparison.OrdinalIgnoreCase)) {
						continue;
					} else {
						requiredCollection.Add(element);
					}
				}
			}
			return requiredCollection.ToArray();
		}
		
		
		NxtControl.GuiFramework.Group FrameGroup;
		NxtControl.GuiFramework.Group SymbolGroup;
		
		public override void EndInit()
		{
			SetView();
			base.EndInit();
		}
		
		#region Abnormality

		/*whenever there is a abnormality detected on counterthreshold,DurationThreshold,feedbackFailure,interlock,permissive,failure,owner
		respective events are triggered and this data is passed as a argument to the Abnormal Indication Function
		
		 * if there is change in simulation value,override value and Maintenance value this will be notified through the event and these data are passed
 		to the AbnormalIndication Function
		
		 * when ever there is a Action required detected on Interlock,permissive,failure,Need Reset this will be notified through the event and these data are passed
		 to the AbnormalIndication Function*/
		
		//Simulation Value change Event
		bool simVal;
		void SimulationValueChanged(object sender, ValueChangedEventArgs e)
		{
			simVal = (bool)e.Value;
			AbnormalIndication(simVal, overVal, maintVal, oosVal, interlockBypass, permissiveBypass, failureBypass, OwnerAbn, needRst, interlockActReq, permissiveActReq, failureActReq);
		}
		
		//Override Value change Event
		bool overVal;
		void FbOverrideValueChanged(object sender, ValueChangedEventArgs e)
		{
			overVal = (bool)e.Value;
			AbnormalIndication(simVal, overVal, maintVal, oosVal, interlockBypass, permissiveBypass, failureBypass, OwnerAbn, needRst, interlockActReq, permissiveActReq, failureActReq);
		}

		//Maintenance Value change Event
		bool maintVal;
		void MaintenanceValueChanged(object sender, ValueChangedEventArgs e)
		{
			maintVal = (bool)e.Value;
			AbnormalIndication(simVal, overVal, maintVal, oosVal, interlockBypass, permissiveBypass, failureBypass, OwnerAbn, needRst, interlockActReq, permissiveActReq, failureActReq);
		}
		
		//Oos Value change Event
		bool oosVal;
		void OutOfServiceValueChanged(object sender, ValueChangedEventArgs e)
		{
			oosVal = (bool)e.Value;
			AbnormalIndication(simVal, overVal, maintVal, oosVal, interlockBypass, permissiveBypass, failureBypass, OwnerAbn, needRst, interlockActReq, permissiveActReq, failureActReq);
		}
		
		//Need Reset Value change Event
		/*When ever there is a Rearm Required  it is notified through the Action Required argument from the below event*/
		bool needRst;
		void NeedResetValueChanged(object sender, ValueChangedEventArgs e)
		{
			needRst = (bool)e.Value;
			AbnormalIndication(simVal, overVal, maintVal, oosVal, interlockBypass, permissiveBypass, failureBypass, OwnerAbn, needRst, interlockActReq, permissiveActReq, failureActReq);
		}
		
		//Interlock  Abnormal Detected Event
		/*when ever there is a bypass of interlock conditon it is notified through Abnormal argument of the below event
		 *When ever there is a Rearm Required for the Interlock condition it is notified through the Action Required argument from the below event*/
		bool interlockBypass;
		bool interlockActReq;
		void InterlockOnAbnormalDetected(bool Abnormal = false, bool ActionReq = false)
		{
			interlockBypass = Abnormal;
			interlockActReq = ActionReq;
			AbnormalIndication(simVal, overVal, maintVal, oosVal, interlockBypass, permissiveBypass, failureBypass, OwnerAbn, needRst, interlockActReq, permissiveActReq, failureActReq);
		}
		
		//Owner Abnormal Detected Event
		/* when a respective owner is unchecked as Normal Owner from the faceplate and if the current Owner is unchecked normal owner then the abnormality is notified
		 *through the below event */
		bool OwnerAbn;
		void OwnerOnAbnormalDetected(bool Abnormal = false, bool ActionReq = false)
		{
			OwnerAbn = Abnormal;
			AbnormalIndication(simVal, overVal, maintVal, oosVal, interlockBypass, permissiveBypass, failureBypass, OwnerAbn, needRst, interlockActReq, permissiveActReq, failureActReq);
		}
		
		//Permissive Abnormal Detected Event
		/*when ever there is a bypass of permissive conditon it is notified through Abnormal argument of the below event
		 *When ever there is a Rearm Required for the permissive condition it is notified through the Action Required argument from the below event*/
		bool permissiveBypass;
		bool permissiveActReq;
		void PermissiveOnAbnormalDetected(bool Abnormal = false, bool ActionReq = false)
		{
			permissiveBypass = Abnormal;
			permissiveActReq = ActionReq;
			AbnormalIndication(simVal, overVal, maintVal, oosVal, interlockBypass, permissiveBypass, failureBypass, OwnerAbn, needRst, interlockActReq, permissiveActReq, failureActReq);
		}
		
		//Failure Abnormal Detected Event
		/*when ever there is a bypass of failure conditon it is notified through Abnormal argument of the below event
		 *When ever there is a Rearm Required for the failure condition it is notified through the Action Required argument from the below event*/
		bool failureBypass;
		bool failureActReq;
		void FailureOnAbnormalDetected(bool Abnormal = false, bool ActionReq = false)
		{
			failureBypass = Abnormal;
			failureActReq = ActionReq;
			AbnormalIndication(simVal, overVal, maintVal, oosVal, interlockBypass, permissiveBypass, failureBypass, OwnerAbn, needRst, interlockActReq, permissiveActReq, failureActReq);
		}
		
		//Abnormality function
		//when ever there is a abnormality this function passes the value to the  function Abnormality derived in base symbol
		bool AbnormalVal;
		bool ActionReqVal;
		void AbnormalIndication(bool sim, bool overr, bool maint, bool oos, bool ilckAbnormal, bool permAbnormal, bool failAbnormal, bool OwnerAbnormal, bool needReset, bool ilckActionReq, bool permActionReq, bool failActionReq)
		{
			AbnormalVal = sim || overr || maint || oos || ilckAbnormal || permAbnormal || failAbnormal || OwnerAbnormal;
			ActionReqVal = needReset || ilckActionReq || permActionReq || failActionReq;
			abnormal.Abnormality(AbnormalVal, ActionReqVal);
		}
		
		#endregion Abnormality

		#region Security Group
		
		/* The below code exposes a property of Security group when ever a symbol is instantiated on the canvas
		 * code is overriding the defined values in Base class(SE.App2Base.Symbols.SEAppLibHMISymbol)
		 * Security group contains 4 categorised Parameters with default values as Mode=6, Parameter = 12, Owner = 3, Setpoint = 3
		 * Objects can be enabled/disabled based on the security parameter provided to it compared with respective to the Login credentials*/
		
		// Hide default SecurityLevel
		[Browsable(false)]
		public override int SecurityLevel{ get { return base.SecurityLevel; } set { base.SecurityLevel = value; } }
		
		// Owner level Security
		[DefaultValue(3),Browsable(true)]
		public override int SecOwner{ get { return base.SecOwner; } set { base.SecOwner = value; } }
		
		// Parameter level Security
		[DefaultValue(12),Browsable(true)]
		public override int SecParameter{ get { return base.SecParameter; } set { base.SecParameter = value; } }

		// Setpoint level Security
		[DefaultValue(3),Browsable(true)]
		public override int SecSetpoint{ get { return base.SecSetpoint; } set { base.SecSetpoint = value; } }

		// Mode level Security
		[DefaultValue(6),Browsable(true)]
		public override int SecMode{ get { return base.SecMode; } set { base.SecMode = value; } }
		
		#endregion Security Group
		
		#region Instance name
		
		//Hide Instance Name
		
		[DefaultValue(false), Browsable(true)]
		public override bool HideTagDisplayName {
			get {
				return base.HideTagDisplayName;
			}
			set {
				base.HideTagDisplayName = value;
				InstanceName.Visible = !HideTagDisplayName;
			}
		}
		
		[DefaultValue("MotorVs")]
		public override string DefaultInstanceName {
			get {
				return base.DefaultInstanceName;
			}
			set {
				base.DefaultInstanceName = value;
				InstanceName.Text = value;
			}
		}

		public override void UpdateTagDisplayName()
		{
			base.UpdateTagDisplayName();
			InstanceName.CustomInstanceName = TagDisplayName;
			alarmFrame.Visible = (Instancelayer != InstanceLayer.Top);
		}
		
		#endregion Instance name

		//Pass title , unit and decimalplaces to faceplate
		protected override void OnInitializeFaceplate(HMIFaceplate hmiFaceplate)
		{
			HMI.Main.Faceplates.MotorVsBase.fpDefault fp = hmiFaceplate as HMI.Main.Faceplates.MotorVsBase.fpDefault;
			if (fp != null) {
				
				fp.TitleText = MyTagDisplayName;
				fp.Unit = PvUnit;
				fp.Tooltip = this.Tooltip;
				fp.DecimalPlacesCount = (uint)DecimalPlacesCount;
				fp.SecOwner = SecOwner;
				fp.SecParameter = SecParameter;
				fp.SecMode = SecMode;
				fp.SecSetpoint = SecSetpoint;
			}
			base.OnInitializeFaceplate(hmiFaceplate);
		}

		
		#region User properties
		
		string sUnit = "%";
		[RefreshProperties(RefreshProperties.All)]
		[Category("Configuration")]
		[DefaultValue("%")]
		[DisplayName("Unit")]
		[LRDescriptionAttribute("$key:SE.App2CommonProcess.Unit")]
		[Browsable(true)]
		public string PvUnit {
			get { return sUnit; }
			set {
				sUnit = UnitLength(value);
				SMeters.Unit = sUnit;
			}
		}
		
		Int32 decimalPlaces = 1;
		[RefreshProperties(RefreshProperties.All)]
		[Category("Configuration")]
		[DefaultValue((Int32)1)]
		[DisplayName("Decimal Places Count")]
		[LRDescriptionAttribute("$key:SE.App2CommonProcess.DecimalPlacesCount")]
		[Browsable(true)]
		public Int32 DecimalPlacesCount {
			get { return decimalPlaces; }
			set {
				var capped = Math.Min(6, value);
		        decimalPlaces = capped;
		        SMeters.DecimalPlacesCount = (uint)capped;
			}
		}
		
		[RefreshProperties(RefreshProperties.All)]
		[Category("Configuration")]
		[DisplayName("Appearence")]
		[LRDescriptionAttribute("$key:SE.App2CommonProcess.Appearance")]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		public MotorAppearance MotorAppearance {
			get { return motorAppearance; }
			set { motorAppearance = value; }
		}
		
		[RefreshProperties(RefreshProperties.All)]
		[Category("Configuration")]
		[DefaultValue(SE.App2Base.Graphics.SMeters.Display.BarGraph)]
		[DisplayName("Display")]
		[LRDescriptionAttribute("$key:SE.App2CommonProcess.DisplayType")]
		[Browsable(true)]
		public SE.App2Base.Graphics.SMeters.Display display
		{
			get{return SMeters.display;}
			set
			{
				SMeters.display = value;
			}
		}
		
		public void UpdateIProperties()
		{
			//Setting the View
			SetView();
		}
		
		#endregion User properties
		
		#region Main region
		
		//Read fb value and animate the symbol with different colors
		short fbStatus;
		void FbStatusValueChanged(object sender, ValueChangedEventArgs e)
		{
			fbStatus = (short)e.Value;
			DirectionView();
		}
		
		void DirectionView()
		{
			DirectSpeedVisible(false, false, false, false, 0);
			roundedRectangle1.BrushColor = Base1L.BrushColor = Base2L.BrushColor = Base3L.BrushColor = NxtControl.Drawing.Color.FromName("SE.App2Base.aaLibSymBodyPassive");
			roundedRectangle4.BrushColor = roundedRectangle2.BrushColor = Base1R.BrushColor = Base2R.BrushColor = Base3R.BrushColor = NxtControl.Drawing.Color.FromName("SE.App2Base.aaLibSymBodyPassive");
			roundedRectangle3.BrushColor = Base1U.BrushColor = Base2U.BrushColor = Base3U.BrushColor = NxtControl.Drawing.Color.FromName("SE.App2Base.aaLibSymBodyPassive");
			Base1D.BrushColor = Base2D.BrushColor = Base3D.BrushColor = NxtControl.Drawing.Color.FromName("SE.App2Base.aaLibSymBodyPassive");
			
			switch (fbStatus) {
				case (short)SpOpFbState.Active1:
					if ((MotorAppearance.Rotation == ServoRotation.Horizontal) && MotorAppearance.HOrientation == ServoOrientation.Right)
						DirectSpeedVisible(true, false, false, false, fbStatus);
					if ((MotorAppearance.Rotation == ServoRotation.Horizontal) && MotorAppearance.HOrientation == ServoOrientation.Left)
						DirectSpeedVisible(false, true, false, false, fbStatus);
					if ((MotorAppearance.Rotation == ServoRotation.Vertical) && MotorAppearance.VOrientation == VServoOrientation.Up)
						DirectSpeedVisible(false, false, true, false, fbStatus);
					if ((MotorAppearance.Rotation == ServoRotation.Vertical) && MotorAppearance.VOrientation == VServoOrientation.Down)
						DirectSpeedVisible(false, false, false, true, fbStatus);
					roundedRectangle1.BrushColor = Base1L.BrushColor = Base2L.BrushColor = Base3L.BrushColor = NxtControl.Drawing.Color.FromName("SE.App2Base.aaLibSymBodyActive");
					roundedRectangle4.BrushColor = roundedRectangle2.BrushColor = Base1R.BrushColor = Base2R.BrushColor = Base3R.BrushColor = NxtControl.Drawing.Color.FromName("SE.App2Base.aaLibSymBodyActive");
					roundedRectangle3.BrushColor = Base1U.BrushColor = Base2U.BrushColor = Base3U.BrushColor = NxtControl.Drawing.Color.FromName("SE.App2Base.aaLibSymBodyActive");
					Base1D.BrushColor = Base2D.BrushColor = Base3D.BrushColor = NxtControl.Drawing.Color.FromName("SE.App2Base.aaLibSymBodyActive");
					break;
				case (short)SpOpFbState.Active2:
					if ((MotorAppearance.Rotation == ServoRotation.Horizontal) && MotorAppearance.HOrientation == ServoOrientation.Right)
						DirectSpeedVisible(true, false, false, false, fbStatus);
					if ((MotorAppearance.Rotation == ServoRotation.Horizontal) && MotorAppearance.HOrientation == ServoOrientation.Left)
						DirectSpeedVisible(false, true, false, false, fbStatus);
					if ((MotorAppearance.Rotation == ServoRotation.Vertical) && MotorAppearance.VOrientation == VServoOrientation.Up)
						DirectSpeedVisible(false, false, true, false, fbStatus);
					if ((MotorAppearance.Rotation == ServoRotation.Vertical) && MotorAppearance.VOrientation == VServoOrientation.Down)
						DirectSpeedVisible(false, false, false, true, fbStatus);
					roundedRectangle1.BrushColor = Base1L.BrushColor = Base2L.BrushColor = Base3L.BrushColor = NxtControl.Drawing.Color.FromName("SE.App2Base.aaLibSymBodyActive");
					roundedRectangle4.BrushColor = roundedRectangle2.BrushColor = Base1R.BrushColor = Base2R.BrushColor = Base3R.BrushColor = NxtControl.Drawing.Color.FromName("SE.App2Base.aaLibSymBodyActive");
					roundedRectangle3.BrushColor = Base1U.BrushColor = Base2U.BrushColor = Base3U.BrushColor = NxtControl.Drawing.Color.FromName("SE.App2Base.aaLibSymBodyActive");
					Base1D.BrushColor = Base2D.BrushColor = Base3D.BrushColor = NxtControl.Drawing.Color.FromName("SE.App2Base.aaLibSymBodyActive");
					break;
				default:
					break;
			}
			CheckAlarm(fbFail.Value, deviceFail.Value);
		}
		
		//Read transfb value and animate the symbol with different colors
		short transFbValue;
		void TransFbStatusValueChanged(object sender, ValueChangedEventArgs e)
		{
			transFbValue = (short)e.Value;
			state.EquipmentStatus(currOpValue, transFbValue);
		}
		
		bool uniDirection;
		void DisReverseValueChanged(object sender, ValueChangedEventArgs e)
		{
			uniDirection = ((bool)e.Value);
			DirectionView();
		}
		
		short currOpValue;
		void CurrentOpValueChanged(object sender, ValueChangedEventArgs e)
		{
			currOpValue = (short)e.Value;
			state.EquipmentStatus(currOpValue, transFbValue);
		}
		
		void ExternalControlledValueChanged(object sender, ValueChangedEventArgs e)
		{
			state.ExternalControlled = (bool)e.Value;
		}

		#endregion Main region

		#region Direction/Speed Symbol

		void DirectSpeedVisible(bool Left, bool Right, bool Up, bool Down, short Pv)
		{
			ForwardL.Visible = ForwardR.Visible = ForwardU.Visible = ForwardD.Visible = false;
			ReverseL.Visible = ReverseR.Visible = ReverseU.Visible = ReverseD.Visible = false;
			
			switch (fbStatus) {
				case 1:
					ForwardL.Visible = Left && !uniDirection;
					ForwardR.Visible = Right && !uniDirection;
					ForwardU.Visible = Up && !uniDirection;
					ForwardD.Visible = Down && !uniDirection;
					ReverseL.Visible = ReverseR.Visible = ReverseU.Visible = ReverseD.Visible = false;
					break;
				case 2:
					ReverseL.Visible = Left;
					ReverseR.Visible = Right;
					ReverseU.Visible = Up;
					ReverseD.Visible = Down;
					ForwardL.Visible = ForwardR.Visible = ForwardU.Visible = ForwardD.Visible = false;
					break;
				default:
					break;
			}
		}
		
		#endregion Direction/Speed Symbol

		#region Symbol wizard setting
		

		void SetView()
		{
			MotBaseL.Visible = false;
			MotBaseR.Visible = false;
			MotbaseU.Visible = false;
			MotbaseD.Visible = false;
			
			ForwardD.Visible = ForwardU.Visible = ForwardL.Visible = ForwardR.Visible = false;
			ReverseD.Visible = ReverseU.Visible = ReverseL.Visible = ReverseR.Visible = false;
			
			if (MotorAppearance.Rotation == ServoRotation.Horizontal) {
				if (MotorAppearance.HOrientation == ServoOrientation.Right) {

					MotBaseL.Visible = true;
					interlock.Location = new NxtControl.Drawing.PointF(66, 23);
					permissive.Location = new NxtControl.Drawing.PointF(66, 40);
					failure.Location = new NxtControl.Drawing.PointF(66, 57);
					MotBaseL.Location = new NxtControl.Drawing.PointF(85, 29);
					state.Location = new NxtControl.Drawing.PointF(85, 56);
					owner.Location = new NxtControl.Drawing.PointF(102, 56);
					abnormal.Location = new NxtControl.Drawing.PointF(108, 44);
					SMeters.Location = new NxtControl.Drawing.PointF(20, 77);
					ForwardL.Location = new NxtControl.Drawing.PointF(90, 31);
					ReverseL.Location = new NxtControl.Drawing.PointF(90, 31);
					InstanceName.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
					InstanceName.X = (MotBaseL.Location.X + (MotBaseL.Size.Width / 2)) - (InstanceName.Size.Width / 2);
				}
				
				if (MotorAppearance.HOrientation == ServoOrientation.Left) {

					MotBaseR.Visible = true;
					interlock.Location = new NxtControl.Drawing.PointF(57, 23);
					permissive.Location = new NxtControl.Drawing.PointF(57, 40);
					failure.Location = new NxtControl.Drawing.PointF(57, 57);
					MotBaseR.Location = new NxtControl.Drawing.PointF(20, 29);
					state.Location = new NxtControl.Drawing.PointF(38, 56);
					owner.Location = new NxtControl.Drawing.PointF(19, 56);
					abnormal.Location = new NxtControl.Drawing.PointF(45, 43);
					SMeters.Location = new NxtControl.Drawing.PointF(20, 77);
					ForwardR.Location = new NxtControl.Drawing.PointF(32, 31);
					ReverseR.Location = new NxtControl.Drawing.PointF(32, 31);
					InstanceName.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
					InstanceName.X = (MotBaseR.Location.X + (MotBaseR.Size.Width / 2)) - (InstanceName.Size.Width / 2);
				}
			}
			
			if (MotorAppearance.Rotation == ServoRotation.Vertical) {
				if (MotorAppearance.VOrientation == VServoOrientation.Up) {

					MotbaseU.Visible = true;
					interlock.Location = new NxtControl.Drawing.PointF(53, 66);
					permissive.Location = new NxtControl.Drawing.PointF(70, 66);
					failure.Location = new NxtControl.Drawing.PointF(87, 66);
					MotbaseU.Location = new NxtControl.Drawing.PointF(61, 30);
					state.Location = new NxtControl.Drawing.PointF(87, 45);
					owner.Location = new NxtControl.Drawing.PointF(87, 27);
					abnormal.Location = new NxtControl.Drawing.PointF(75, 54);
					SMeters.Location = new NxtControl.Drawing.PointF(110, 25);
					ForwardU.Location = new NxtControl.Drawing.PointF(63, 42);
					ReverseU.Location = new NxtControl.Drawing.PointF(63, 42);

					InstanceName.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
					InstanceName.X = (SMeters.Location.X + (SMeters.Size.Width / 2)) - (InstanceName.Size.Width / 2);
				}
				if (MotorAppearance.VOrientation == VServoOrientation.Down) {
					MotbaseD.Visible = true;
					interlock.Location = new NxtControl.Drawing.PointF(53, 25);
					permissive.Location = new NxtControl.Drawing.PointF(70, 25);
					failure.Location = new NxtControl.Drawing.PointF(87, 25);
					abnormal.Location = new NxtControl.Drawing.PointF(75, 60);
					owner.Location = new NxtControl.Drawing.PointF(87, 61);
					state.Location = new NxtControl.Drawing.PointF(87, 45);
					MotbaseD.Location = new NxtControl.Drawing.PointF(61, 45);
					SMeters.Location = new NxtControl.Drawing.PointF(110, 25);
					ForwardD.Location = new NxtControl.Drawing.PointF(63.5, 48);
					ReverseD.Location = new NxtControl.Drawing.PointF(63.5, 48);
					
					InstanceName.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
					InstanceName.X = (MotbaseD.Location.X + (MotbaseD.Size.Width / 2)) - (InstanceName.Size.Width / 2);
				}
			}
			
			FrameView();
		}
		
		void FrameView()
		{
			const int gap = 5;
			InstanceName.Y = 2;
			NxtControl.Drawing.PointF LOC = SymbolGroup.Location;
			NxtControl.Drawing.SizeF SIZE = SymbolGroup.Size;
			alarmFrame.Location = new NxtControl.Drawing.PointF(LOC.X - gap, LOC.Y - gap);
			alarmFrame.Size = new NxtControl.Drawing.SizeF(SIZE.Width + (2 * gap), SIZE.Height + (2 * gap));
			InstanceName.Y = alarmFrame.Y - 18;
			OptionalServicesActive();
		}
		
		#endregion
		
		#region BarGraph
		
		float barGraphMinPv;
		float barGraphMaxPv;
		float barGraphPv = 0.0f;

		void SpeedSpMinValueChanged(object sender, ValueChangedEventArgs e)
		{
			barGraphMinPv = (float)e.Value;
			SMeters.SpValue(curSpeedSp, barGraphMinPv, barGraphMaxPv);
			SMeters.Value(barGraphPv, barGraphMinPv, barGraphMaxPv);
		}

		void SpeedSpMaxValueChanged(object sender, ValueChangedEventArgs e)
		{
			barGraphMaxPv = (float)e.Value;
			SMeters.SpValue(curSpeedSp, barGraphMinPv, barGraphMaxPv);
			SMeters.Value(barGraphPv, barGraphMinPv, barGraphMaxPv);
		}

		void SpeedFbStatusValueChanged(object sender, ValueChangedEventArgs e)
		{
			barGraphPv = (float)e.Value;
			SMeters.Value(barGraphPv, barGraphMinPv, barGraphMaxPv);
		}
		
		float curSpeedSp = 0.0f;
		void CurrentSpeedSpValueChanged(object sender, ValueChangedEventArgs e)
		{
			curSpeedSp = (float)e.Value;
			SMeters.SpValue(curSpeedSp, barGraphMinPv, barGraphMaxPv);
		}
		
		void CurrentOwnerValueChanged(object sender, ValueChangedEventArgs e)
		{
			owner.BasicOwner = (ushort)e.Value;
		}
		
		#endregion

		#region Subscription

		void SMotorUpdateOptionalService(string instancePath)
		{
			owner.InstanceName = FindInstanceLayer(InstanceLayer.BaseExt) + ".serviceManager.owner";
			failure.InstanceName = FindInstanceLayer(InstanceLayer.Top) + ".failure";
			interlock.InstanceName = FindInstanceLayer(InstanceLayer.Top) + ".interlock";
			permissive.InstanceName = FindInstanceLayer(InstanceLayer.Top) + ".permissive";
		}

		#endregion Subscription
		
		#region Interlock Permissive Failure Owner Signal Update & Alarm Frame control
		
		
		void FailValueChanged(object sender, ValueChangedEventArgs e)
		{
			failure.FailSignal = (bool)e.Value;
		}
		bool permstop;
		void PermStopValueChanged(object sender, ValueChangedEventArgs e)
		{
			permissive.PermissivePassiveSignal = permstop = (bool)e.Value;

			FrameView();
		}
		bool permfwd;
		void PermFwdValueChanged(object sender, ValueChangedEventArgs e)
		{
			permissive.PermissiveActive1Signal = permfwd = (bool)e.Value;

			FrameView();
		}
		bool permrev;
		void PermRevValueChanged(object sender, ValueChangedEventArgs e)
		{
			permissive.PermissiveActive2Signal = permrev = (bool)e.Value;

			FrameView();
			
		}

		void IlckCondValueChanged(object sender, ValueChangedEventArgs e)
		{
			interlock.InterlockSignal = (bool)e.Value;
		}
		
		/* Ilck, Perm and fail condition status to update the alaramframe size and location */
		bool interolockAvail;
		void InterlockOnAvailablityChanged(bool Available)
		{
			interolockAvail = Available;
			FrameView();
		}
		bool permissiveAvail;
		void PermissiveOnAvailablityChanged(bool Available)
		{
			permissiveAvail = Available;
			FrameView();
		}
		
		bool failureAvail;
		void FailureOnAvailablityChanged(bool Available)
		{
			failureAvail = Available;
			FrameView();
		}
		
		bool stdOwner;
		void StdOwnerConnectedValueChanged(object sender, ValueChangedEventArgs e)
		{
			stdOwner = (bool)e.Value;
			owner.ExternalAvailable = stdOwner;
		}
		
		public delegate void OptionalServicesAvailable(NxtControl.Drawing.SizeF frameSize, NxtControl.Drawing.PointF frameLoc, NxtControl.Drawing.PointF instnameLoc);
		public event OptionalServicesAvailable OnOptionalServicesAvailable;
		void OptionalServicesActive()
		{
			if (this.OnOptionalServicesAvailable != null) {
				this.OnOptionalServicesAvailable(alarmFrame.Size, alarmFrame.Location, FrameGroup.Location);
			}
		}

		VTQ<bool> fbFail;
		void FbFailValueChanged(object sender, ValueChangedEventArgs e)
		{
			fbFail = (VTQ<bool>)e.Value;
			DirectionView();
		}
		VTQ<bool> deviceFail;
		void DeviceFailValueChanged(object sender, ValueChangedEventArgs e)
		{
			deviceFail = (VTQ<bool>)e.Value;
			DirectionView();
		}
		void CheckAlarm(bool fbfail, bool devfail)
		{
			if (fbfail || devfail) {
				roundedRectangle1.BrushColor = Base1L.BrushColor = Base2L.BrushColor = Base3L.BrushColor = NxtControl.Drawing.Color.FromName("SE.App2Base.aaLibSymBodyAlarm");
				roundedRectangle2.BrushColor = Base1R.BrushColor = Base2R.BrushColor = Base3R.BrushColor = NxtControl.Drawing.Color.FromName("SE.App2Base.aaLibSymBodyAlarm");
				roundedRectangle3.BrushColor = Base1U.BrushColor = Base2U.BrushColor = Base3U.BrushColor = NxtControl.Drawing.Color.FromName("SE.App2Base.aaLibSymBodyAlarm");
				roundedRectangle4.BrushColor = Base1U.BrushColor = Base2U.BrushColor = Base3U.BrushColor = NxtControl.Drawing.Color.FromName("SE.App2Base.aaLibSymBodyAlarm");
				Base1D.BrushColor = Base2D.BrushColor = Base3D.BrushColor = NxtControl.Drawing.Color.FromName("SE.App2Base.aaLibSymBodyAlarm");
			}
		}
		
		#endregion Interlock Permissive Failure Owner Signal Update & Alarm Frame control

	}
}



