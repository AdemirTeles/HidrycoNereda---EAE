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
	public partial class sDisplayPv1 : NxtControl.GuiFramework.HMISymbol
	{
		private string _Unit = "%";
		private string _SensorName = "Name";
		string UnitOut;
		public sDisplayPv1()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			this.REQ_UNIT_Fired += REQ_UNIT_Fired_EventHandler;
		}

		// Com a propriedade Unit vazia, mostra a unidade configurada no CLP (iUnit); com Unit preenchida, mantem o texto fixo
		void REQ_UNIT_Fired_EventHandler(object sender, REQ_UNITEventArgs e)
		{
			if (string.IsNullOrEmpty(_Unit) && e.iUnit != null)
				Unit.Text = e.iUnit;
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
