/*
 * Created by ApplicationLibDevTeam
 * 
 */

using System;
using NxtControl.GuiFramework;
using System.ComponentModel;
using SE.App2CommonProcess.SupportClasses;
using SE.App2Base.SupportClasses;
using NxtControl.ComponentModel;
using System.Collections.Generic;

namespace SE.Nereda.Symbols.MotorBaseNer
{
	/// <summary>
	/// Description of sPump.
	/// </summary>
	/// 
	
	[TypeConverter(typeof(PumpHostPropertyOrderConverter))]
	public partial class sPump : SE.App2Base.Symbols.SEAppLibHMISymbol
	{
		public sPump()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			InstanceName.Text = "Motor";
			
			SymbolGroup = new NxtControl.GuiFramework.Group();
			SymbolGroup.BeginInit();SymbolGroup.Visible = false;
			SymbolGroup.Shapes.AddRange(getSymbolsGroup(false));
			this.shapes.AddRange(new System.ComponentModel.IComponent[] {SymbolGroup});
			SymbolGroup.EndInit();
			
			
			FrameGroup = new NxtControl.GuiFramework.Group();
			FrameGroup.BeginInit();FrameGroup.Visible = false;
			FrameGroup.Shapes.AddRange(getSymbolsGroup(true));
			this.shapes.AddRange(new System.ComponentModel.IComponent[] {FrameGroup});
			FrameGroup.EndInit();
		}
		
		private IComponent[] getSymbolsGroup(bool GetAll)
		{
			var requiredCollection = new List<IComponent>();
			var shapeCollect = this.Shapes;
			if (!GetAll)
			{
				foreach (IComponent element in shapeCollect) {
					if(element.GetType().FullName.StartsWith("System.HMI.Symbols.Base.Execute<",StringComparison.OrdinalIgnoreCase) || element is NxtControl.GuiFramework.AlarmFrame || element is NxtControl.GuiFramework.AliasDisplayLabel)
					{continue;}
					else	{requiredCollection.Add(element);}
				}
			}
			else
			{
				foreach (IComponent element in shapeCollect) {
					if(element.GetType().FullName.StartsWith("System.HMI.Symbols.Base.Execute<",StringComparison.OrdinalIgnoreCase))
					{continue;}
					else	{requiredCollection.Add(element);}
				}
			}
			return requiredCollection.ToArray();
		}
		
		NxtControl.GuiFramework.Group FrameGroup;
		NxtControl.GuiFramework.Group SymbolGroup;
		
		bool initProperties;
		public override void EndInit()
		{
			if (!initProperties)
				//Setting the View
				SetView();
			base.EndInit();
			FrameView();
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
		void SimValueChanged(object sender, ValueChangedEventArgs e)
		{
			simVal =(bool)e.Value;
			AbnormalIndication(simVal,overVal,maintVal,oos,interlockBypass,permissiveBypass,failureBypass,OwnerAbn,needRst,interlockActReq,permissiveActReq,failureActReq);
			
		}
		
		//Override Value change Event
		bool overVal;
		void OverValueChanged(object sender, ValueChangedEventArgs e)
		{
			overVal = (bool)e.Value;
			AbnormalIndication(simVal,overVal,maintVal,oos,interlockBypass,permissiveBypass,failureBypass,OwnerAbn,needRst,interlockActReq,permissiveActReq,failureActReq);
			
		}

		//Maintenance Value change Event
		bool maintVal;
		void MaintValueChanged(object sender, ValueChangedEventArgs e)
		{
			maintVal = (bool)e.Value;
			AbnormalIndication(simVal,overVal,maintVal,oos,interlockBypass,permissiveBypass,failureBypass,OwnerAbn,needRst,interlockActReq,permissiveActReq,failureActReq);
			
		}
		
		//Oos Value change Event
		bool oos;
		void OosValueChanged(object sender, ValueChangedEventArgs e)
		{
			oos = (bool)e.Value;
			AbnormalIndication(simVal,overVal,maintVal,oos,interlockBypass,permissiveBypass,failureBypass,OwnerAbn,needRst,interlockActReq,permissiveActReq,failureActReq);
		}
		
		//Need Reset Value change Event
		/*When ever there is a Rearm Required  it is notified through the Action Required argument from the below event*/
		bool needRst;
		void NeedResetValueChanged(object sender, ValueChangedEventArgs e)
		{
			needRst = (bool)e.Value;
			AbnormalIndication(simVal,overVal,maintVal,oos,interlockBypass,permissiveBypass,failureBypass,OwnerAbn,needRst,interlockActReq,permissiveActReq,failureActReq);
			
		}
		
		//Interlock  Abnormal Detected Event
		/*when ever there is a bypass of interlock conditon it is notified through Abnormal argument of the below event
		 *When ever there is a Rearm Required for the Interlock condition it is notified through the Action Required argument from the below event*/
		bool interlockBypass;
		bool interlockActReq;
		
		void InterlockHOnAbnormalDetected(bool Abnormal = false, bool ActionReq = false)
		{
			interlockBypass = Abnormal;
			interlockActReq = ActionReq;
			AbnormalIndication(simVal,overVal,maintVal,oos,interlockBypass,permissiveBypass,failureBypass,OwnerAbn,needRst,interlockActReq,permissiveActReq,failureActReq);
		}
		
		//Owner Abnormal Detected Event
		/* when a respective owner is unchecked as Normal Owner from the faceplate and if the current Owner is unchecked normal owner then the abnormality is notified
		 *through the below event */
		
		bool OwnerAbn;
		void OwnerOnAbnormalDetected(bool Abnormal = false, bool ActionReq = false)
		{
			OwnerAbn = Abnormal;
			AbnormalIndication(simVal,overVal,maintVal,oos,interlockBypass,permissiveBypass,failureBypass,OwnerAbn,needRst,interlockActReq,permissiveActReq,failureActReq);
		}
		
		//Permissive Abnormal Detected Event
		/*when ever there is a bypass of permissive conditon it is notified through Abnormal argument of the below event
		 *When ever there is a Rearm Required for the permissive condition it is notified through the Action Required argument from the below event*/
		bool permissiveBypass;
		bool permissiveActReq;
		void PermissiveHOnAbnormalDetected(bool Abnormal = false, bool ActionReq = false)
		{
			permissiveBypass = Abnormal;
			permissiveActReq = ActionReq;
			AbnormalIndication(simVal,overVal,maintVal,oos,interlockBypass,permissiveBypass,failureBypass,OwnerAbn,needRst,interlockActReq,permissiveActReq,failureActReq);
		}
		
		//Failure Abnormal Detected Event
		/*when ever there is a bypass of failure conditon it is notified through Abnormal argument of the below event
		 *When ever there is a Rearm Required for the failure condition it is notified through the Action Required argument from the below event*/
		bool failureBypass;
		bool failureActReq;
		void FailureHOnAbnormalDetected(bool Abnormal = false, bool ActionReq = false)
		{
			failureBypass = Abnormal;
			failureActReq = ActionReq;
			AbnormalIndication(simVal,overVal,maintVal,oos,interlockBypass,permissiveBypass,failureBypass,OwnerAbn,needRst,interlockActReq,permissiveActReq,failureActReq);
		}
		
		//Abnormality function
		//when ever there is a abnormality this function passes the value to the  function Abnormality derived in base symbol
		bool AbnormalVal;
		bool ActionReqVal;
		public bool isOverAbnormalEnabled = true;
		void AbnormalIndication(bool sim, bool overr,bool maint,bool oos, bool ilckAbnormal,bool permAbnormal, bool failAbnormal,bool OwnerAbnormal,bool needReset, bool ilckActionReq, bool permActionReq, bool failActionReq)
		{
			AbnormalVal = sim || (overr && isOverAbnormalEnabled) || maint || oos || ilckAbnormal || permAbnormal||failAbnormal || OwnerAbnormal ;
			ActionReqVal = needReset || ilckActionReq||permActionReq||failActionReq;
			abnormal.Abnormality(AbnormalVal,ActionReqVal);
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

		// Mode level Security
		[DefaultValue(6),Browsable(true)]
		public override int SecMode{ get {return base.SecMode;} set {base.SecMode = value;} }
		#endregion Security Group

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
		
		string instanceNameText = "Motor";
		[DefaultValue("Motor"), Browsable (false)]
		public string InstanceNameText{
			get{return instanceNameText;}
			set{
				instanceNameText = value;
				InstanceName.Text = value;
			}
		}
		
		public override void UpdateTagDisplayName()
		{
			base.UpdateTagDisplayName();
			InstanceName.CustomInstanceName = TagDisplayName;
			alarmFrame.Visible = (Instancelayer != InstanceLayer.Top);
		}
		
		protected override void OnInitializeFaceplate(HMIFaceplate hmiFaceplate)
		{
			SE.Nereda.Faceplates.MotorBaseNer.fpDefault fp = hmiFaceplate as SE.Nereda.Faceplates.MotorBaseNer.fpDefault;
			if (fp != null)
			{
				fp.TitleText = MyTagDisplayName;
				fp.Tooltip = this.tooltip;
				fp.SecOwner = SecOwner;
				fp.SecParameter = SecParameter;
				fp.SecMode = SecMode;
				fp.SecSetpoint = SecSetpoint;
				fp.isOverrideEnabled = isOverAbnormalEnabled;
			}
			base.OnInitializeFaceplate(hmiFaceplate);
		}
		
		PumpSymbol pumpSymbol = PumpSymbol.Type1;
		[Category("Configuration")]
		[DisplayName("Pump Symbol")]
		[LRDescriptionAttribute("$key:SE.App2CommonProcess.PumpSymbol")]
		[DefaultValue(PumpSymbol.Type1)]
		[RefreshProperties(RefreshProperties.All)]
		[Browsable(true)]
		public PumpSymbol PumpSymbol
		{
			get { return this.pumpSymbol; }
			set
			{
				this.pumpSymbol = value;
				if (this.pumpSymbol == PumpSymbol.Type1 &&
				    (this.iServoOrientation == MotorOrientation.Up || this.iServoOrientation == MotorOrientation.Down))
					this.iServoOrientation = MotorOrientation.Left;
				
				if (this.pumpSymbol == PumpSymbol.Type2 &&
				    (this.iServoOrientation == MotorOrientation.LeftUp || this.iServoOrientation == MotorOrientation.RightUp))
					this.iServoOrientation = MotorOrientation.Left;
				
				UpdateIProperties();
			}
		}
		
		MotorOrientation iServoOrientation = MotorOrientation.Left;
		[Category("Configuration")]
		[DisplayName("Motor Orientation")]
		[LRDescriptionAttribute("$key:SE.App2CommonProcess.Orientation")]
		[DefaultValue(MotorOrientation.Left)]
		[RefreshProperties(RefreshProperties.All)]
		[Browsable(true)]
		[TypeConverter(typeof(MotorOrientationConverter))]
		public MotorOrientation ServoOrientation
		{
			get { return this.iServoOrientation; }
			set
			{
				this.iServoOrientation = value;
				UpdateIProperties();
			}
		}
		
		public void UpdateIProperties()
		{
			initProperties = true;
			SetView();
			System.ComponentModel.TypeDescriptor.Refresh(this);
		}
		
		short CurrOpValue;
		void CurrentOutputValueChanged(object sender, ValueChangedEventArgs e)
		{
			CurrOpValue = (short)e.Value;
			state.EquipmentStatus(CurrOpValue,TransFbValue);
		}
		
		private short FbStatusVal;
		void FbStatusValueChanged(object sender, ValueChangedEventArgs e)
		{
			FbStatusVal = (short)e.Value;
			SetColors(FbStatusVal,fbFail.Value,deviceFail.Value);
		}
		
		short TransFbValue;
		void TransFbValueChanged(object sender, ValueChangedEventArgs e)
		{
			TransFbValue = (short)e.Value;
			state.EquipmentStatus(CurrOpValue,TransFbValue);
			
		}
		void CurrentOwnerValueChanged(object sender, ValueChangedEventArgs e)
		{
			owner.BasicOwner = (ushort)e.Value;
		}
		
		void ExternalControlledValueChanged(object sender, ValueChangedEventArgs e)
		{
			state.ExternalControlled = (bool)e.Value;
		}
		
		#region SetView

		private void SetView()
		{
			initProperties = true;
			
			// helpers
			Action centerName = () =>
			{
				InstanceName.X = (MotBase.Location.X + (MotBase.Size.Width / 2)) - (InstanceName.Size.Width / 2);
				InstanceName.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			};
			
			Action leftName = () =>
			{
				InstanceName.X = Outlet.X + Outlet.Width;
				InstanceName.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			};
			
			// To allign the inlet outlet in type 1 pump
			Action<NxtControl.Drawing.PointF, NxtControl.Drawing.SizeF, NxtControl.Drawing.PointF> setInletOutlet = (outletloc, outletsz, inletloc) =>
			{
				Outlet.Location = outletloc;
				Outlet.Size = outletsz;
				Inlet.Location = inletloc;
			};
			
			// setIOBar -> To allign all interlock permissive failure and owner based on orientation
			Action<NxtControl.Drawing.PointF, NxtControl.Drawing.PointF, NxtControl.Drawing.PointF, NxtControl.Drawing.PointF> setIOBar = (inter, perm, fail, ownr) =>
			{
				interlock.Location = inter;
				permissive.Location = perm;
				failure.Location = fail;
				owner.Location = ownr;
			};
			
			// setTopBar -> To allign all interlocks permissive and owner for left right symbols
			Action setTopBar = () =>
			{
				failure.Location = new NxtControl.Drawing.PointF(84, 29);
				interlock.Location = new NxtControl.Drawing.PointF(51, 29);
				permissive.Location = new NxtControl.Drawing.PointF(68, 29);
				owner.Location = new NxtControl.Drawing.PointF(84, 80);
				state.Location = new NxtControl.Drawing.PointF(67, 80);
				centerName();
			};
			
			
			if (PumpSymbol == PumpSymbol.Type1)
			{
				Base.Visible = Outlet.Visible = Inlet.Visible = true;
				line1.Visible = line2.Visible = line3.Visible = line4.Visible = false;
				abnormal.Location = state.Location = owner.Location = new NxtControl.Drawing.PointF(67, 80);
				
				switch (iServoOrientation)
				{
					case MotorOrientation.Left:
						setInletOutlet(new NxtControl.Drawing.PointF(76, 48), new NxtControl.Drawing.SizeF(13, 6),new NxtControl.Drawing.PointF(62, 62));
						setIOBar(new NxtControl.Drawing.PointF(51, 28), new NxtControl.Drawing.PointF(68, 28), new NxtControl.Drawing.PointF(84, 28),new NxtControl.Drawing.PointF(84, 80));
						abnormal.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 80D, 60D);
						centerName();
						break;
						
					case MotorOrientation.Right:
						setInletOutlet(new NxtControl.Drawing.PointF(62, 48), new NxtControl.Drawing.SizeF(13, 6),new NxtControl.Drawing.PointF(76, 62));
						setIOBar(new NxtControl.Drawing.PointF(51, 28), new NxtControl.Drawing.PointF(68, 28), new NxtControl.Drawing.PointF(84, 28),new NxtControl.Drawing.PointF(84, 80));
						abnormal.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 60D, 60D);
						centerName();
						break;
						
					case MotorOrientation.LeftUp:
						setInletOutlet(new NxtControl.Drawing.PointF(64.5F, 45), new NxtControl.Drawing.SizeF(6, 13),new NxtControl.Drawing.PointF(76, 62));
						setIOBar(new NxtControl.Drawing.PointF(39, 44), new NxtControl.Drawing.PointF(39, 62), new NxtControl.Drawing.PointF(39, 80),new NxtControl.Drawing.PointF(84, 80));
						abnormal.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 60D, 60D);
						leftName();
						break;
						
					case MotorOrientation.RightUp:
						setInletOutlet(new NxtControl.Drawing.PointF(80, 45), new NxtControl.Drawing.SizeF(6, 13),new NxtControl.Drawing.PointF(62, 62));
						setIOBar(new NxtControl.Drawing.PointF(102, 44), new NxtControl.Drawing.PointF(102, 62), new NxtControl.Drawing.PointF(102, 80),new NxtControl.Drawing.PointF(84, 80));
						abnormal.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 80D, 60D);
						leftName();
						break;
				}
			}
			
			else
			{
				Base.Visible = Outlet.Visible = Inlet.Visible = false;
				failure.Location = new NxtControl.Drawing.PointF(45, 40);
				permissive.Location = new NxtControl.Drawing.PointF(45, 55);
				interlock.Location = new NxtControl.Drawing.PointF(45, 70);
				owner.Location = new NxtControl.Drawing.PointF(84, 72);
				abnormal.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 80D, 60D);
				line1.Visible = line2.Visible = line3.Visible = line4.Visible = false;

				switch (iServoOrientation)
				{
					case MotorOrientation.Left:
						setTopBar();
						line1.Visible = true;
						line3.Visible = true;
						break;
						
					case MotorOrientation.Right:
						setTopBar();
						line2.Visible = true;
						line4.Visible = true;
						abnormal.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 60D, 60D);
						break;
						
					case MotorOrientation.Up:
						line1.Visible = true;
						line2.Visible = true;
						state.Location = new NxtControl.Drawing.PointF(97, 52);
						setIOBar(new NxtControl.Drawing.PointF(44, 34), new NxtControl.Drawing.PointF(44, 52), new NxtControl.Drawing.PointF(44, 70),new NxtControl.Drawing.PointF(97, 70));
						leftName();
						break;
						
					case MotorOrientation.Down:
						line3.Visible = true;
						line4.Visible = true;
						state.Location = new NxtControl.Drawing.PointF(97, 52);
						setIOBar(new NxtControl.Drawing.PointF(44, 34), new NxtControl.Drawing.PointF(44, 52), new NxtControl.Drawing.PointF(44, 70),new NxtControl.Drawing.PointF(97, 70));
						leftName();
						break;
				}
			}
			FrameView();
		}
		
		void FrameView()
		{
			const int gap = 5;
			NxtControl.Drawing.PointF LOC = SymbolGroup.Location;
			NxtControl.Drawing.SizeF SIZE = SymbolGroup.Size;
			alarmFrame.Location = new NxtControl.Drawing.PointF(LOC.X-gap, LOC.Y-gap);
			alarmFrame.Size =new NxtControl.Drawing.SizeF(SIZE.Width+(2*gap),SIZE.Height+(2*gap));
			InstanceName.Y = alarmFrame.Y-18;
			OptionalServicesActive();
		}
		
		#endregion SetView

		#region Interlock Permissive Failure Signal Update
		
		/* Move Corresponding signal to L3 base graphic DynamicShapes symbols*/
		
		
		void FailValueChanged(object sender, ValueChangedEventArgs e)
		{
			failure.FailSignal = (bool)e.Value;
			FrameView();
		}

		void IlckValueChanged(object sender, ValueChangedEventArgs e)
		{
			interlock.InterlockSignal = (bool)e.Value;
			FrameView();
		}
		bool permstop;
		void PermStopValueChanged(object sender, ValueChangedEventArgs e)
		{
			permissive.PermissivePassiveSignal = permstop = (bool)e.Value;
			permissive.PermissiveActive2Signal = true;
			FrameView();
		}
		bool permrun;
		void PermRunValueChanged(object sender, ValueChangedEventArgs e)
		{
			permissive.PermissiveActive1Signal = permrun=  (bool)e.Value;
			FrameView();
		}
		#endregion
		
		#region Subscription

		void SPumpUpdateOptionalService(string instancePath)
		{
			owner.InstanceName = FindInstanceLayer(InstanceLayer.BaseExt)+".serviceManager.owner";
			failure.InstanceName = FindInstanceLayer(InstanceLayer.Top)+".failure";
			interlock.InstanceName = FindInstanceLayer(InstanceLayer.Top)+".interlock";
			permissive.InstanceName = FindInstanceLayer(InstanceLayer.Top)+".permissive";
		}
		
		bool standardOwner;
		void StdOwnerConnectedValueChanged(object sender, ValueChangedEventArgs e)
		{
			standardOwner = (bool)e.Value;
			owner.ExternalAvailable = standardOwner;
		}

		#endregion Subscription
		
		#region Optional Services Availability
		
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
		
		#endregion Optional Services Availability
		public delegate void OptionalServicesAvailable( NxtControl.Drawing.SizeF frameSize, NxtControl.Drawing.PointF frameLoc , NxtControl.Drawing.PointF instnameLoc);
		public event OptionalServicesAvailable OnOptionalServicesAvailable;
		
		void OptionalServicesActive()
		{

			if (this.OnOptionalServicesAvailable != null)
			{
				this.OnOptionalServicesAvailable(alarmFrame.Size,alarmFrame.Location,FrameGroup.Location);
			}
			
		}
		
		void SetColors(short fb, bool fbfail , bool devfail)
		{
			if (fbfail || devfail)
				MotBase.BrushColor = Base.BrushColor = Inlet.BrushColor = Outlet.BrushColor =  NxtControl.Drawing.Color.FromName("SE.App2Base.aaLibSymBodyAlarm");
			else{
				if (fb == 1)
					MotBase.BrushColor = Base.BrushColor = Inlet.BrushColor = Outlet.BrushColor =  NxtControl.Drawing.Color.FromName("SE.App2Base.aaLibSymBodyActive");
				else
					MotBase.BrushColor = Base.BrushColor = Inlet.BrushColor = Outlet.BrushColor =  NxtControl.Drawing.Color.FromName("SE.App2Base.aaLibSymBodyPassive");
			}
		}
		
		VTQ<bool> fbFail;
		void FbFailValueChanged(object sender, ValueChangedEventArgs e)
		{
			fbFail = (VTQ<bool>)e.Value;
			SetColors(FbStatusVal,fbFail.Value,deviceFail.Value);
		}
		VTQ<bool> deviceFail;
		void DeviceFailValueChanged(object sender, ValueChangedEventArgs e)
		{
			deviceFail = (VTQ<bool>)e.Value;
			SetColors(FbStatusVal,fbFail.Value,deviceFail.Value);
		}
	}
}



