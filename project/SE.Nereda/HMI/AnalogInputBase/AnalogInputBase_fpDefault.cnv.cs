using System;
using System.Drawing;
using NxtControl.GuiFramework;
using System.Runtime.InteropServices;
using System.ComponentModel;
using SE.App2Base.SupportClasses;

namespace SE.Nereda.Faceplates.AnalogInputBase
{
	/// <summary>
	/// Description of fpDefault.
	/// </summary>
	public partial class fpDefault : SE.App2Base.Faceplates.SEAppLibHMIFaceplate
	{
		public fpDefault()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			
			this.AutoScroll = false;
			
			
		}
#region Abnormal
		//Override mode
		void OverValueChanged(object sender, ValueChangedEventArgs e)
		{
			bool Abnormal = (bool)e.Value;
			fpNavigationPane.Abnormality("Parameter",Abnormal:Abnormal);
		}

#endregion
		//***********************************************************Security Group************************************************************
		
		// Parameter level security
		void FpDefaultSecurityParameterChanged(bool isSecurity)
		{
			
			HiButton.BasicParameters.SecParameter = SecParameter;
			HiHiButton.BasicParameters.SecParameter = SecParameter;
			LoButton.BasicParameters.SecParameter = SecParameter;
			LoLoButton.BasicParameters.SecParameter = SecParameter;
			RocButton.ROCAlarmParameters.SecParameter = SecParameter;
			DevButton.BasicParameters.SecParameter = SecParameter;
			fpNavigationPane.SecParameter = SecParameter;
		}
		
		// Mode level  security
		void FpDefaultSecurityModeChanged(bool isSecurity)
		{
			HiButton.BasicParameters.SecMode = SecMode;
			HiHiButton.BasicParameters.SecMode = SecMode;
			LoButton.BasicParameters.SecMode = SecMode;
			LoLoButton.BasicParameters.SecMode = SecMode;
			RocButton.ROCAlarmParameters.SecMode = SecMode;
			DevButton.BasicParameters.SecMode = SecMode;
			fpNavigationPane.SecMode = SecMode;
		}
		
		//SetPoint level Security
		void FpDefaultSecuritySetpointChanged(bool isSecurity)
		{
			HiButton.BasicParameters.SecSetpoint = SecSetpoint;
			HiHiButton.BasicParameters.SecSetpoint = SecSetpoint;
			LoButton.BasicParameters.SecSetpoint = SecSetpoint;
			LoLoButton.BasicParameters.SecSetpoint = SecSetpoint;
			RocButton.ROCAlarmParameters.SecSetpoint = SecSetpoint;
			DevButton.BasicParameters.SecSetpoint = SecSetpoint;
			HiIndicator.IgnoreMouseEvents = !((NxtControl.Security.ISecuritySetValues) this).IsSetValuesSecure(SecSetpoint);
			HiHiIndicator.IgnoreMouseEvents = !((NxtControl.Security.ISecuritySetValues) this).IsSetValuesSecure(SecSetpoint);
			LoIndicator.IgnoreMouseEvents = !((NxtControl.Security.ISecuritySetValues) this).IsSetValuesSecure(SecSetpoint);
			LoLoIndicator.IgnoreMouseEvents = !((NxtControl.Security.ISecuritySetValues) this).IsSetValuesSecure(SecSetpoint);
			RocIndicator.IgnoreMouseEvents = !((NxtControl.Security.ISecuritySetValues) this).IsSetValuesSecure(SecSetpoint);
			DevIndicator.IgnoreMouseEvents = !((NxtControl.Security.ISecuritySetValues) this).IsSetValuesSecure(SecSetpoint);
			fpNavigationPane.SecSetpoint = SecSetpoint;
		}

		//***********************************************************End of security Group*****************************************************
		//Move the required data from symbol to faceplate on initialize
		protected override void OnInitializeFaceplate(HMIFaceplate hmiFaceplate)
		{
			SE.Nereda.Faceplates.AnalogInputBase.fpParameter fp = hmiFaceplate as SE.Nereda.Faceplates.AnalogInputBase.fpParameter;
			if (fp != null)
			{
				fp.Title = Title+" "+"Parameter";
				fp.DecimalPlacesCount = DecimalPlacesCount;
				fp.Unit = Unit;
				fp.SecMode = SecMode;
				fp.SecParameter = SecParameter;
				fp.SecSetpoint = SecSetpoint;
				fp.RawUnit = RawUnit;
			}
			base.OnInitializeFaceplate(hmiFaceplate);
			
			SE.Nereda.Faceplates.AnalogInputBase.fpTrend fp1 = hmiFaceplate as SE.Nereda.Faceplates.AnalogInputBase.fpTrend;
			if (fp1 != null)
			{
				fp1.Title = Title+" "+"Trend";
				
			}
			base.OnInitializeFaceplate(hmiFaceplate);
		}
		

#region UserProperties
		// user property creation code for unit, decimal point,title text
		private string unit = "";
		[DefaultValue(""), RefreshProperties(RefreshProperties.All), Category("Faceplate")]
		public string Unit
		{
			get { return unit; }
			set
			{
				unit = value;
				HiButton.BasicParameters.Unit = UnitLength(unit);
				HiHiButton.BasicParameters.Unit = UnitLength(unit);
				LoButton.BasicParameters.Unit = UnitLength(unit);
				LoLoButton.BasicParameters.Unit = UnitLength(unit);
				RocButton.ROCAlarmParameters.Unit = UnitLength(unit);
				DevButton.BasicParameters.Unit = UnitLength(unit);
				HiIndicator.BasicParameters.Unit =UnitLength(unit);
				HiHiIndicator.BasicParameters.Unit = UnitLength(unit);
				LoIndicator.BasicParameters.Unit = UnitLength(unit);
				LoLoIndicator.BasicParameters.Unit = UnitLength(unit);
				RocIndicator.BasicParameters.Unit = UnitLength(unit);
				DevIndicator.BasicParameters.Unit = UnitLength(unit);
				lblPv.Tooltip = ConvertText(unit);
				lblPv.Suffix = UnitLength(unit);
				lblPvMin.Suffix = UnitLength(unit);
				lblPvMax.Suffix = UnitLength(unit);
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
			}
		}
		
		//Title of the faceplate
		[DefaultValue(""), RefreshProperties(RefreshProperties.All), Category("Faceplate")]
		public string TitleText
		{
			get { return Title; }
			set
			{
				Title = value;
				fpNavigationPane.ParentTitle = value;
				UpdateChildHMISymbolsParentTagName(value);
			}
		}
		// parameters decimal place count
		uint decimalPlacesCount;
		[DefaultValue("2"), RefreshProperties(RefreshProperties.All), Category("Faceplate")]
		public uint DecimalPlacesCount
		{
			get { return decimalPlacesCount; }
			set
			{
				decimalPlacesCount = value;
				lblPv.DecimalPlacesCount = value;
				HiButton.BasicParameters.DecimalPlacesCount = decimalPlacesCount;
				HiHiButton.BasicParameters.DecimalPlacesCount = decimalPlacesCount;
				LoButton.BasicParameters.DecimalPlacesCount = decimalPlacesCount;
				LoLoButton.BasicParameters.DecimalPlacesCount = decimalPlacesCount;
				RocButton.ROCAlarmParameters.DecimalPlacesCount = decimalPlacesCount;
				DevButton.BasicParameters.DecimalPlacesCount = decimalPlacesCount;
				HiIndicator.BasicParameters.DecimalPlacesCount =decimalPlacesCount;
				HiHiIndicator.BasicParameters.DecimalPlacesCount = decimalPlacesCount;
				LoIndicator.BasicParameters.DecimalPlacesCount = decimalPlacesCount;
				LoLoIndicator.BasicParameters.DecimalPlacesCount = decimalPlacesCount;
				RocIndicator.ROCIndicatorParameters.DecimalPlacesCount = decimalPlacesCount;
				
				DevIndicator.BasicParameters.DecimalPlacesCount = decimalPlacesCount;

			}
		}
		
		
#endregion UserProperties


#region Methods
		private void UpdateChildHMISymbolsParentTagName(string tagName)
		{
			foreach (var shape in Shapes)
			{
				HMISymbol symbol = shape as HMISymbol;
				if (symbol != null)
				{
					System.Reflection.PropertyInfo pi = symbol.GetType().GetProperty("ParentTagDisplayName", typeof(string));
					if (pi != null)
					{
						pi.SetValue(symbol, tagName);
					}
				}
			}
			
		}
#endregion Methods

#region PvBarGraph
		//code for smeter bargarph function
		float barGraphMin = 0.0f;
		float barGraphMax = 100.0f;
		float barGraphPct = 0.0f;
		
		void ExecPvValueChanged(object sender, ValueChangedEventArgs e)
		{
			barGraphPct = (float)e.Value;
			SMeters1.Value(barGraphPct, barGraphMin, barGraphMax);
		}
		
		void ExecPvMaxValueChanged(object sender, ValueChangedEventArgs e)
		{
			barGraphMax = (float)e.Value;
			lblPvMax.Text = barGraphMax.ToString("F" + decimalPlacesCount.ToString());
			SMeters1.Value(barGraphPct, barGraphMin, barGraphMax);
			HiButton.IndicatorParameters.MaxLimitValue = barGraphMax;
			HiHiButton.IndicatorParameters.MaxLimitValue = barGraphMax;
			LoButton.IndicatorParameters.MaxLimitValue = barGraphMax;
			LoLoButton.IndicatorParameters.MaxLimitValue = barGraphMax;
			RocButton.ROCAlarmParameters.MaxLimitValue = barGraphMax;
			DevButton.IndicatorParameters.MaxLimitValue = barGraphMax;
			HiIndicator.IndicatorParameters.MaxLimitValue = barGraphMax;
			HiHiIndicator.IndicatorParameters.MaxLimitValue = barGraphMax;
			LoIndicator.IndicatorParameters.MaxLimitValue = barGraphMax;
			LoLoIndicator.IndicatorParameters.MaxLimitValue = barGraphMax;
			RocIndicator.ROCIndicatorParameters.MaxLimitValue = barGraphMax;
			DevIndicator.IndicatorParameters.MaxLimitValue = barGraphMax;
		}
		
		void ExecPvMinValueChanged(object sender, ValueChangedEventArgs e)
		{
			barGraphMin = (float)e.Value;
			lblPvMin.Text = barGraphMin.ToString("F" + decimalPlacesCount.ToString());
			SMeters1.Value(barGraphPct, barGraphMin, barGraphMax);
			HiButton.IndicatorParameters.MinLimitValue = barGraphMin;
			HiHiButton.IndicatorParameters.MinLimitValue = barGraphMin;
			LoButton.IndicatorParameters.MinLimitValue = barGraphMin;
			LoLoButton.IndicatorParameters.MinLimitValue = barGraphMin;
			RocButton.ROCAlarmParameters.MinLimitValue = barGraphMin;
			DevButton.IndicatorParameters.MinLimitValue = barGraphMin;
			HiIndicator.IndicatorParameters.MinLimitValue = barGraphMin;
			HiHiIndicator.IndicatorParameters.MinLimitValue = barGraphMin;
			LoIndicator.IndicatorParameters.MinLimitValue = barGraphMin;
			LoLoIndicator.IndicatorParameters.MinLimitValue = barGraphMin;
			RocIndicator.ROCIndicatorParameters.MinLimitValue = barGraphMin;
			DevIndicator.IndicatorParameters.MinLimitValue = barGraphMin;
		}

		
#endregion PvBarGraph
		
		void ScaleValueChanged(object sender, ValueChangedEventArgs e)
		{
			bool Scale = (bool)e.Value;
			
			SMeters1.Value(barGraphPct, barGraphMin, barGraphMax);
		}
		
#region Faceplate Navigation
		//Open parameter faceplate
		void FpNavigationPaneOnParameterClick()
		{

			DoOpenFaceplate("fpParameter");
		}
		//Open trend faceplate
		void FpNavigationPaneOnTrendClick()
		{
			DoOpenFaceplate("fpTrend");
		}

#endregion

#region Subscription of Sub CATs
		// Sub CAT Subscription
		void FpDefaultUpdateOptionalService(string instancePath)
		{
			//Instance Name
			HiButton.InstanceName = FindInstanceLayer(InstanceLayer.Top)+".high";
			HiHiButton.InstanceName = FindInstanceLayer(InstanceLayer.Top)+".highHigh";
			LoButton.InstanceName = FindInstanceLayer(InstanceLayer.Top)+".low";
			LoLoButton.InstanceName = FindInstanceLayer(InstanceLayer.Top)+".lowLow";
			RocButton.InstanceName = FindInstanceLayer(InstanceLayer.Top)+".rateOfChange";
			DevButton.InstanceName = FindInstanceLayer(InstanceLayer.Top)+".deviation";
			HiIndicator.InstanceName = FindInstanceLayer(InstanceLayer.Top)+".high";
			HiHiIndicator.InstanceName = FindInstanceLayer(InstanceLayer.Top)+".highHigh";
			LoIndicator.InstanceName = FindInstanceLayer(InstanceLayer.Top)+".low";
			LoLoIndicator.InstanceName = FindInstanceLayer(InstanceLayer.Top)+".lowLow";
			RocIndicator.InstanceName = FindInstanceLayer(InstanceLayer.Top)+".rateOfChange";
			DevIndicator.InstanceName = FindInstanceLayer(InstanceLayer.Top)+".deviation";

			
			//Symbol Type
			
			HiButton.SymbolType = "SE.App2Base.Symbols.LimitAlarm.sButton";
			HiHiButton.SymbolType = "SE.App2Base.Symbols.LimitAlarm.sButton";
			LoButton.SymbolType = "SE.App2Base.Symbols.LimitAlarm.sButton";
			LoLoButton.SymbolType = "SE.App2Base.Symbols.LimitAlarm.sButton";
			RocButton.SymbolType = "SE.App2Base.Symbols.ROCAlarm.sButton";
			DevButton.SymbolType = "SE.App2Base.Symbols.DeviationAlarm.sButton";
			HiIndicator.SymbolType ="SE.App2Base.Symbols.LimitAlarm.sIndicator";
			HiHiIndicator.SymbolType = "SE.App2Base.Symbols.LimitAlarm.sIndicator";
			LoIndicator.SymbolType = "SE.App2Base.Symbols.LimitAlarm.sIndicator";
			LoLoIndicator.SymbolType = "SE.App2Base.Symbols.LimitAlarm.sIndicator";
			RocIndicator.SymbolType = "SE.App2Base.Symbols.ROCAlarm.sIndicator";
			DevIndicator.SymbolType = "SE.App2Base.Symbols.DeviationAlarm.sIndicator";
			
			
		}
		
		static double btnLocY = 141;
		static double btnLocX = 181;
		static double btnOffset = 29;

		void LimitLocation(double locY, double offset)
		{
			if(hiHiAvailable)
			{
				HiHiButton.Location = new NxtControl.Drawing.PointF(btnLocX,locY);
				locY = HiHiButton.Location.Y+ offset;
			}

			if(hiAvailable)
			{
				HiButton.Location = new NxtControl.Drawing.PointF(btnLocX,locY);
				locY = HiButton.Location.Y+ offset;
			}

			if(rocAvailable)
			{
				RocButton.Location = new NxtControl.Drawing.PointF(btnLocX,locY);
				locY = RocButton.Location.Y+ offset;
			}

			if(devAvailable)
			{
				DevButton.Location = new NxtControl.Drawing.PointF(btnLocX,locY);
				locY = DevButton.Location.Y+ offset;
			}

			if(loAvailable)
			{
				LoButton.Location = new NxtControl.Drawing.PointF(btnLocX,locY);
				locY = LoButton.Location.Y+ offset;
			}

			if(loLoAvailable)
			{
				LoLoButton.Location = new NxtControl.Drawing.PointF(btnLocX,locY);
			}
			
			if (hiHiAvailable || hiAvailable || rocAvailable || devAvailable || loAvailable || loLoAvailable)
			{
				SMeters1.Location = new NxtControl.Drawing.PointF(84,142);
				lblPvMin.Location = new NxtControl.Drawing.PointF(7,310);
				lblPvMax.Location = new NxtControl.Drawing.PointF(7,120);
			}

		}
		
		bool devAvailable;
		void DevButtonAvailableChanged(bool available)
		{
			devAvailable = available;
			LimitLocation(btnLocY,btnOffset);
		}

		bool hiAvailable;
		void HiButtonAvailableChanged(bool available)
		{
			hiAvailable = available;
			LimitLocation(btnLocY,btnOffset);
		}

		bool hiHiAvailable;
		void HiHiButtonAvailableChanged(bool available)
		{
			hiHiAvailable = available;
			LimitLocation(btnLocY,btnOffset);
		}

		bool rocAvailable;
		void RocButtonAvailableChanged(bool available)
		{
			rocAvailable = available;
			LimitLocation(btnLocY,btnOffset);
		}

		bool loAvailable;
		void LoButtonAvailableChanged(bool available)
		{
			loAvailable = available;
			LimitLocation(btnLocY,btnOffset);
		}

		bool loLoAvailable;
		void LoLoButtonAvailableChanged(bool available)
		{
			loLoAvailable = available;
			LimitLocation(btnLocY,btnOffset);
		}
#endregion
	}
}



