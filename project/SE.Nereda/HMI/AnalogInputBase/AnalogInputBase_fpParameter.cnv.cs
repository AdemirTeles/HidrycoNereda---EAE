using System;
using System.Drawing;
using System.ComponentModel;
using NxtControl.GuiFramework;

namespace SE.Nereda.Faceplates.AnalogInputBase
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
			DDBoxPopulate(); //Drop down box function calling
			STBoxPopulate();
			
			this.AutoScroll = false;
		}
		
		
		
		// For Drop Down Box Text Populating
		public void DDBoxPopulate()
		{
			SelectBad.Enabled = true;
			SelectBad.DropDownItems.Clear();
			this.SelectBad.DropDownItems.AddRange(new System.HMI.Symbols.Base.DropDownItem[]
			                                      {
			                                      	new System.HMI.Symbols.Base.DropDownItem("$key:SE.App2CommonProcess.LabelInputValue", ((int)(0))),
			                                      	new System.HMI.Symbols.Base.DropDownItem("$key:SE.App2CommonProcess.LabelBadPv", ((int)(1))),
			                                      	new System.HMI.Symbols.Base.DropDownItem("$key:SE.App2CommonProcess.LabelLastGoodPv", ((int)(2)))});
			
			
		}
		
		public void STBoxPopulate()
		{
			SmoothType.Items.Clear();
			SmoothType.Items.AddRange(new string[] {
			                          	"$key:SE.App2CommonProcess.TxtNone",
			                          	"$key:SE.App2CommonProcess.TxtOldNew",
			                          	"$key:SE.App2CommonProcess.TxtValueDiff",
			                          	"$key:SE.App2CommonProcess.TxtTimeDiff",
			                          	"$key:SE.App2CommonProcess.TxtValueOrTime",
			                          	"$key:SE.App2CommonProcess.TxtValueAndTime"});
		}
		// End of DropDown Box Populating
#region Security Group
		//*****************************************Security Group***********************************************************
		
		// Parameter level security
		private bool SecurityVal ;
		void FpParameterSecurityParameterChanged(bool isSecurity)
		{
			EnScaleBtn.SecurityLevel = SecParameter;
			SecurityVal = ((NxtControl.Security.ISecuritySetValues) this).IsSetValuesSecure(SecParameter);
			txtMinRaw.SecurityLevel = SecParameter;
			txtMaxRaw.SecurityLevel = SecParameter;
			txtMinPv.SecurityLevel = SecParameter;
			txtMaxPv.SecurityLevel = SecParameter;
			txtPvCutOff.SecurityLevel = SecParameter;
			txtPvOffset.SecurityLevel = SecParameter;
			txtFilterTime.SecurityLevel = SecParameter;
			txtPt1CycleTime.SecurityLevel = SecParameter;
			SelectBad.SecurityLevel = SecParameter;
			txtPvBad.SecurityLevel = SecParameter;
			UseLimitsBtn.SecurityLevel = SecParameter;
			SmoothType.Enabled = isSecurity;
			ValDiff.SecurityLevel = SecParameter;
			TimeDiff.SecurityLevel = SecParameter;
			DDBoxPopulate();
		}

		// Mode level  security
		void FpParameterSecurityModeChanged(bool isSecurity)
		{
			Override.SecurityLevel = SecMode;
			txtoverridevalue.SecurityLevel = SecMode;
		}

		
		//*******************************************************************End of Instance Level Security********************************************
#endregion

#region UserProperties
		
		[DefaultValue(""), RefreshProperties(RefreshProperties.All), Category("Faceplate")]
		public string TitleText {
			get { return Title; }
			set {
				Title = value;
			}
		}
		
		uint decimalPlacesCount;
		[DefaultValue("2"), RefreshProperties(RefreshProperties.All), Category("Faceplate")]
		public uint DecimalPlacesCount {
			get { return decimalPlacesCount; }
			set {
				decimalPlacesCount = value;
				txtMaxPv.DecimalPlacesCount = value;
				txtMinPv.DecimalPlacesCount = value;
				txtMaxRaw.DecimalPlacesCount = value;
				txtMinRaw.DecimalPlacesCount = value;
				txtPvOffset.DecimalPlacesCount = value;
				txtPvCutOff.DecimalPlacesCount = value;
				txtPvBad.DecimalPlacesCount = value;
				txtoverridevalue.DecimalPlacesCount = value;
				lblPvField.DecimalPlacesCount = value;
			}
		}
		private string unit = "";
		[DefaultValue(""), RefreshProperties(RefreshProperties.All), Category("Faceplate")]
		public string Unit {
			get { return unit; }
			set {
				unit = value;
				txtMaxPv.Tooltip = ConvertText(unit);
				txtMinPv.Tooltip = ConvertText(unit);
				txtPvBad.Tooltip = ConvertText(unit);
				txtoverridevalue.Tooltip = ConvertText(unit);
				txtPvCutOff.Tooltip = ConvertText(unit);
				txtPvOffset.Tooltip = ConvertText(unit);
				lblPvField.Tooltip = ConvertText(unit);
				txtMaxPv.Suffix = UnitLength(unit);
				txtMinPv.Suffix = UnitLength(unit);
				txtPvBad.Suffix = UnitLength(unit);
				txtoverridevalue.Suffix = UnitLength(unit);
				txtPvCutOff.Suffix = UnitLength(unit);
				txtPvOffset.Suffix = UnitLength(unit);
				lblPvField.Suffix = UnitLength(unit);
				ValDiff.Suffix = UnitLength(unit);
			}
		}
		
		private string rawunit="";
		[DefaultValue(""),RefreshProperties(RefreshProperties.All), Category("Faceplate")]
		public string RawUnit
		{
			get { return rawunit; }
			set
			{
				
				rawunit = value;
				txtMaxRaw.Tooltip = ConvertText(rawunit);
				txtMinRaw.Tooltip = ConvertText(rawunit);
				
				txtMaxRaw.Suffix = UnitLength(rawunit);
				txtMinRaw.Suffix = UnitLength(rawunit);
			}
		}

		// pv bad selection
		short SelectionBad;
		void BadPvSelValueChanged(object sender, ValueChangedEventArgs e)
		{
			SelectionBad = (short)e.Value;
			if (SelectionBad == 1)
			{
				txtPvBad.Enabled = true;
			}
			else
			{
				txtPvBad.Enabled = false;
			}
		}

		float PvToSim;
		void PvValueChanged(object sender, ValueChangedEventArgs e)
		{
			PvToSim = (float)e.Value;
			if (!OverrideEnable)
			{
				FireEvent_IND_MODE(false,true,PvToSim,false);
			}
		}
		//Override mode
		bool OverrideEnable;
		void ExecOverValueChanged(object sender, ValueChangedEventArgs e)
		{
			OverrideEnable = (bool)e.Value;
			labelS17.Abnormal = (bool) e.Value;
			if (OverrideEnable)
			{
				FireEvent_IND_MODE(false,true,PvToSim,false);
				
				txtoverridevalue.Enabled = true;
			}
			else
			{
				txtoverridevalue.Enabled = false;
			}
		}
		

		float PvMaxvalue;
		void PvMaxValueChanged(object sender, ValueChangedEventArgs e)
		{
			PvMaxvalue =(float)e.Value;
			txtoverridevalue.Maximum = PvMaxvalue;
			if (overval>PvMaxvalue)
			{
				overval = PvMaxvalue;	
				FireEvent_IND_MODE(false,true,overval,false);
			}
		}
		float PvMinvalue;
		void PvMinValueChanged(object sender, ValueChangedEventArgs e)
		{
			PvMinvalue = (float)e.Value;
			txtoverridevalue.Minimum = PvMinvalue;
			if (overval< PvMinvalue)
			{
				overval = PvMinvalue;	
			FireEvent_IND_MODE(false,true,overval,false);
			}
		}
		
		float overval;
		void PvOverrideValValueChanged(object sender, ValueChangedEventArgs e)
		{
			overval = (float)e.Value;
		}


		// smooth type selection
		void SmoothTypeSelectedIndexChanged(object sender, EventArgs e)
		{
			byte newSmoothType = 0;
			
			newSmoothType = (byte)((NxtControl.GuiFramework.DrawnComboBox)sender).SelectedIndex;
			FireEvent_CFG(0,true,0,true,0,true,0,true,false,true,false,true,0,true,0,true,0,true,0,true,0,true,0,true,newSmoothType,false,0,true,0,true,0,true);
		}

		void SmoothValueChanged(object sender, ValueChangedEventArgs e)
		{
			byte SmoothTypeSel = (byte)e.Value;
			switch (SmoothTypeSel)
			{
				case 0:
					TimeDiff.Enabled = false;
					ValDiff.Enabled = false;
					break;
				case 1:
					TimeDiff.Enabled = false;
					ValDiff.Enabled = false;
					break;
				case 2:
					TimeDiff.Enabled = false;
					ValDiff.Enabled = true;
					break;
				case 3:
					TimeDiff.Enabled = true;
					ValDiff.Enabled = false;
					break;
				case 4:
					TimeDiff.Enabled = true;
					ValDiff.Enabled = true;
					break;
				case 5:
					TimeDiff.Enabled = true;
					ValDiff.Enabled = true;
					break;
			}
			
			SmoothType.SelectedIndex = SmoothTypeSel;
		}
		
#endregion UserProperties

		
	}
}



