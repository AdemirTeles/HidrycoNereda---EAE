/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 6/10/2026
 * Time: 3:37 PM
 * 
 */

using System;
using NxtControl.GuiFramework;
using System.ComponentModel;

namespace SE.Nereda.Symbols.NeredaReactor
{
	/// <summary>
	/// Description of sSensor.
	/// </summary>
	public partial class sSensors : NxtControl.GuiFramework.HMISymbol
	{


		public sSensors()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
		}

		private string _Reator = "41";

		// Codigo do reator no P&ID (41 ou 42): monta o tag de cada sensor (ex. 41LT1005) + o que mede
		[RefreshProperties(RefreshProperties.Repaint)]
		[Category("Tagnames")]
		[DisplayName("Reactor Code")]
		public string _iReator
		{
			get { return _Reator; }
			set
			{
				_Reator = value ?? "";
				sDisplayPv21._iSensorName = _Reator + "LT1005 " + "N\u00edvel";
				sDisplayPv22._iSensorName = "Vaz\u00e3o de ar";
				sDisplayPv23._iSensorName = _Reator + "QT1001 " + "S\u00f3lidos";
				sDisplayPv24._iSensorName = _Reator + "QT1002 " + "Oxig\u00eanio";
				sDisplayPv25._iSensorName = _Reator + "QT1006 " + "pH";
				sDisplayPv26._iSensorName = _Reator + "QT1004 " + "Redox";
				sDisplayPv27._iSensorName = _Reator + "QT1003 " + "Temp.";
				sDisplayPv28._iSensorName = "Turbidez";
				sDisplayPv29._iSensorName = _Reator + "QT1007 " + "Am\u00f4nia";
				sDisplayPv210._iSensorName = _Reator + "QT1008 " + "Nitrato";
				sDisplayPv211._iSensorName = _Reator + "QT1009 " + "Fosfato";
			}
		}
		

	}
}
