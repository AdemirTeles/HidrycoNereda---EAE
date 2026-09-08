/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 6/5/2026
 * Time: 3:20 PM
 * 
 */

using System;
using NxtControl.GuiFramework;
using System.ComponentModel;

namespace SE.Nereda.Symbols.AnalogInput
{
	/// <summary>
	/// Description of sDefault.
	/// </summary>
	public partial class sDisplayPv2 : NxtControl.GuiFramework.HMISymbol
	{
		private string _Unit = "%";
		private string _SensorName = "Name";
		string UnitOut;
		string InUnit;
		public sDisplayPv2()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
		}
		
		[RefreshProperties(RefreshProperties.Repaint)]
		[Category("Tagnames")]
		[DisplayName("Unit")]
		
		public string _iUnit
		{
			get{
				return _Unit;
			}
			set{
				_Unit = value;
				UnitOut = Unit.Text = value.ToString();
				InUnit = value.ToString();
			}
		}
		
		[RefreshProperties(RefreshProperties.Repaint)]
		[Category("Tagnames")]
		[DisplayName("SensorName")]
		
		public string _iSensorName
		{
			get{
				return _SensorName;
			}
			set{
				_SensorName = value;
				SensorName.Text = value.ToString();
			}
		}
	}
}
