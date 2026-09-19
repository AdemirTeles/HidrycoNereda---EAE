using System;
using System.Drawing;
using NxtControl.GuiFramework;
using System.ComponentModel;
using SE.App2Base.SupportClasses;
using SE.App2CommonProcess.SupportClasses;
using NxtControl.Services;
using NxtControl.ComponentModel;

namespace HMI.Main.Symbols.PID
{
	/// <summary>
	/// Description of sBanner.
	/// </summary>
	public partial class sBanner : SE.App2Base.Symbols.SEAppLibHMISymbol
	{
		public sBanner()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			InstanceName.Text = "Instance";
		}
		
		
		#region Security Group
		
		/* The below code exposes a property of Security group when ever a symbol is instantiated on the canvas
		 * code is overriding the defined values in Base class(SE.App2Base.Symbols.SEAppLibHMISymbol)
		 * Security group contains 4 categorised Parameters with default values as Mode=6, Parameter = 12, Owner = 3, Setpoint = 3
		 * Objects can be enabled/disabled based on the security parameter provided to it compared with respective to the Login credentials*/
		
		// Hide default SecurityLevel
		[Browsable(false)]
		public override int SecurityLevel{get{return base.SecurityLevel;} set{base.SecurityLevel = value;}}
		
		// Parameter level Security
		[DefaultValue(12),Browsable(true)]
		public override int SecParameter{ get {return base.SecParameter;} set {base.SecParameter = value;} }

		// Setpoint level Security
		[DefaultValue(3),Browsable(true)]
		public override int SecSetpoint{ get {return base.SecSetpoint;} set {base.SecSetpoint = value;} }
		
		#endregion Security Group
		
		#region User Properties
		
		public override void UpdateTagDisplayName()
		{
			base.UpdateTagDisplayName();
			InstanceName.Text = TagDisplayName;
			if (String.IsNullOrEmpty(TagDisplayName))
			    InstanceName.Text = "Instance";
			else
				InstanceName.Text = TagDisplayName;
		}
		
		
		
		string pvUnit = "%";
		[RefreshProperties(RefreshProperties.All)]
		[Category("Configuration")]
		[DefaultValue("%")]
		[DisplayName("Unit")]
		[LRDescriptionAttribute("$key:SE.App2CommonProcess.Unit")]
		[Browsable(true)]
		public string PvUnit {
			get { return pvUnit;}
			set {
				pvUnit = UnitLength(value);
				CurrentSpOp.Suffix = pvUnit;
				SpOp.Suffix = pvUnit;
			}
		}
	
		bool hideTitle= false;
		[RefreshProperties(RefreshProperties.All)]
		[Category("Configuration")]
		[DisplayName("Hide Title")]
		[LRDescriptionAttribute("$key:SE.App2CommonProcess.TxtHideTitle")]
		[DefaultValue(false)]
		public bool HideTitle
		{
			get {
				return hideTitle;
			}
			set { hideTitle = value;
				lblConfig.Visible= !hideTitle;
				lblCurrSpOp.Visible= !hideTitle;
				lblEnableSSC.Visible= !hideTitle;
				lblSource.Visible= !hideTitle;
				lblSSCSpOp.Visible= !hideTitle;
				lblStatus.Visible= !hideTitle;
				lblController.Visible= !hideTitle;
				group1.Visible=!hideTitle;
			}
		}
		
		#endregion User Properties
		
		#region Subscription of SSC Banner 
		
		string symbolType1 = "SE.App2CommonProcess.Symbols.PIDSSCSeqData.sBanner";
		NxtControl.Drawing.PointF SymbolLoc3 = new NxtControl.Drawing.PointF(32 , 44);
		NxtControl.GuiFramework.GroupShape Status;
		

		IDynamicCatLoaderService dynamicCatloaderService = ServiceProvider.GetService<IDynamicCatLoaderService>();
		
		void SubscriptionSSC()
		{
			string instanceName1 = FindInstanceLayer(InstanceLayer.Base) + ".sc";
			
			if (string.IsNullOrEmpty(instanceName1))
				return;
			
			Status = dynamicCatloaderService.CreateDynamicElement(this, symbolType1, instanceName1, "SSCBanner", SymbolLoc3, true);
			group1.Visible=false;
			group2.Visible=false;
			lblConfig.Visible= false;
				lblCurrSpOp.Visible= false;
				lblEnableSSC.Visible= false;
				lblSource.Visible= false;
				lblSSCSpOp.Visible= false;
				lblStatus.Visible= false;
				lblController.Visible= false;
			(Status as SE.App2CommonProcess.Symbols.PIDSSCSeqData.sBanner).HideTitle= hideTitle;
			(Status as SE.App2CommonProcess.Symbols.PIDSSCSeqData.sBanner).PvUnit= pvUnit;
			(Status as SE.App2CommonProcess.Symbols.PIDSSCSeqData.sBanner).SecSetpointEn= ((NxtControl.Security.ISecuritySetValues)this).IsSetValuesSecure(SecSetpoint);;
			(Status as SE.App2CommonProcess.Symbols.PIDSSCSeqData.sBanner).SecSetpoint= SecSetpoint;
			(Status as SE.App2CommonProcess.Symbols.PIDSSCSeqData.sBanner).SecParmeterEn= ((NxtControl.Security.ISecuritySetValues)this).IsSetValuesSecure(SecParameter);;
			(Status as SE.App2CommonProcess.Symbols.PIDSSCSeqData.sBanner).SecParameter= SecParameter;
			
		}
		
		#endregion Subscription of SSC Banner 
		
		void SBannerUpdateOptionalService(string instancePath)
		{
			SubscriptionSSC();
		}

		

		
}
}