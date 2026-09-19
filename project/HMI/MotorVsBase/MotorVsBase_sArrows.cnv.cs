using System;
using NxtControl.GuiFramework;
using System.ComponentModel;
using SE.App2CommonProcess.SupportClasses;

namespace HMI.Main.Symbols.MotorVsBase
{
	/// <summary>
	/// Description of sArrows.
	/// </summary>
	public partial class sArrows : SE.App2Base.Symbols.SEAppLibHMISymbol
	{
		public sArrows()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
		}
		bool initProperties;
		public override void EndInit()
		{
			if (!initProperties)
				SetView();
			base.EndInit();
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

		// Mode level Security
		[DefaultValue(6),Browsable(true)]
		public override int SecMode{ get {return base.SecMode;} set {base.SecMode = value;} }
		
		#endregion Security Group
		
		// Hiding Instancename visiblity
		[Browsable(false)]
		public override bool HideTagDisplayName {
			get {
				return base.HideTagDisplayName;
			}
			set {
				base.HideTagDisplayName = value;
			}
		}
		
		private BeltFwdDirection iBeltOrientation = BeltFwdDirection.Right;
		[RefreshProperties(RefreshProperties.All)]
		[Category("Configuration")]
		[DisplayName("Belt Orientation")]
		[DefaultValue(BeltFwdDirection.Right)]
		[Browsable(true)]
		public BeltFwdDirection BeltOrientation
		{
			get { return this.iBeltOrientation; }
			set
			{
				this.iBeltOrientation = value;
				
				//Setting the View
				SetView();
			}
		}
		void SetView()
		{
			initProperties = true;
			leftArrow.Visible = rightArrow.Visible = false;
			leftArrow.BrushColor = rightArrow.BrushColor = NxtControl.Drawing.Color.FromName("SE.App2Base.aaLibSymBodyActive");
			if (iBeltOrientation == BeltFwdDirection.Left)
			{
				leftArrow.Visible = true;
			}
			else{
				rightArrow.Visible = true;
			}
		}
		
		VTQ<bool> fbFail;
		void FbFailValueChanged(object sender, ValueChangedEventArgs e)
		{
			fbFail = (VTQ<bool>)e.Value;
			SetColors(FbStatusVal, fbFail.Value, deviceFail.Value);
		}
		VTQ<bool> deviceFail;
		void DeviceFailValueChanged(object sender, ValueChangedEventArgs e)
		{
			deviceFail = (VTQ<bool>)e.Value;
			SetColors(FbStatusVal, fbFail.Value, deviceFail.Value);
		}

		private short FbStatusVal;
		void FbStatusValueChanged(object sender, ValueChangedEventArgs e)
		{
			FbStatusVal = (short)e.Value;
			SetColors(FbStatusVal, fbFail.Value, deviceFail.Value);
		}

		void SetColors(short fb, bool fbfail , bool devfail)
		{
			if (fbfail || devfail)
			{leftArrow.BrushColor = rightArrow.BrushColor =  NxtControl.Drawing.Color.FromName("SE.App2Base.aaLibSymBodyAlarm");}
			else {
				
				if (fb == 1)
				{
					if (iBeltOrientation == BeltFwdDirection.Left)
					{
						leftArrow.Visible = true;
						rightArrow.Visible = false;
					}
					else
					{
						leftArrow.Visible = false;
						rightArrow.Visible = true;
					}
					leftArrow.BrushColor = rightArrow.BrushColor = NxtControl.Drawing.Color.FromName("SE.App2Base.aaLibSymBodyActive");
				}
				else if (fb == 2)
				{
					if (iBeltOrientation == BeltFwdDirection.Left)
					{
						leftArrow.Visible = false;
						rightArrow.Visible = true;
					}
					else
					{
						leftArrow.Visible = true;
						rightArrow.Visible = false;
					}
					leftArrow.BrushColor = rightArrow.BrushColor = NxtControl.Drawing.Color.FromName("SE.App2Base.aaLibSymBodyActive");
				}
				else if (fb == 0)
				{
					if (iBeltOrientation == BeltFwdDirection.Left)
					{
						leftArrow.Visible = true;
						rightArrow.Visible = false;
					}
					else
					{
						leftArrow.Visible = false;
						rightArrow.Visible = true;
					}
					leftArrow.BrushColor = rightArrow.BrushColor = NxtControl.Drawing.Color.FromName("SE.App2Base.aaLibSymBodyPassive");
				}
			}
			
		}
		

	}
}

