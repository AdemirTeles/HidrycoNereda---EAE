using System;
using NxtControl.GuiFramework;
using System.ComponentModel;
using SE.App2CommonProcess.SupportClasses;
using SE.App2Base.SupportClasses;
using NxtControl.ComponentModel;

namespace HMI.Main.Symbols.PID
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
			
			//Update Main layer availablity in Base symbol
			sBarPvSpOpVert1.Instancelayer = InstanceLayer.Top;
			
			unit = new PIDUnit(this);
			decimalPlacesCount = new PIDDecimalPlacesCount(this);
		}

		
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
		
		void SBarPvSpOpVertSecurityOwnerChanged(bool isSecurity)
		{
			sBarPvSpOpVert1.SecOwner = SecOwner;
		}

		void SBarPvSpOpVertSecurityParameterChanged(bool isSecurity)
		{
			sBarPvSpOpVert1.SecParameter = SecParameter;
		}

		void SBarPvSpOpVertSecuritySetpointChanged(bool isSecurity)
		{
			sBarPvSpOpVert1.SecSetpoint = SecSetpoint;
		}
		
		#endregion  Security Group
		
		#region UserProperties
		
		[Browsable(true)]
		public override bool HideTagDisplayName {
			get {
				return base.HideTagDisplayName;
			}
			set {
				base.HideTagDisplayName = value;
			}
		}

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
		
		
		[Category("Configuration")]
		[DefaultValue("")]
		[DisplayName("Display Type")]
		[LRDescriptionAttribute("$key:SE.App2CommonProcess.DisplayType")]
		[Browsable(true)]
		public PidDisplayType DisplayType
		{
			get { return sBarPvSpOpVert1.DisplayType;}
			set { sBarPvSpOpVert1.DisplayType = value; }
		}

		public void UpdateIProperties()
		{
			sBarPvSpOpVert1.Unit.PvSpValue = Unit.PvSpValue;
			sBarPvSpOpVert1.Unit.OutValue = Unit.OutValue;
			sBarPvSpOpVert1.DecimalPlacesCount.PvSpValue =  DecimalPlacesCount.PvSpValue;
			sBarPvSpOpVert1.DecimalPlacesCount.OutValue =  DecimalPlacesCount.OutValue;
		}
		
		#endregion UserProperties
		
	}
}



