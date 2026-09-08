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
		private string _LT001 = "NVPP 001 lt 004";
		private string _QT002 = "MOD NVPP 001 41QT1002";
		private string _QT003 = "MOD NVPP 001 41QT1003";
		private string _QT010 = "MOD NVPP 001 41QT1010";
		public sSensors()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
		}
		
		[RefreshProperties(RefreshProperties.Repaint)]
		[Category("Tagnames")]
		[DisplayName("LT001 Code")]
		
		public string _iLT001
		{
			get{
				return _LT001;
			}
			set{
				_LT001 = value;
				sLT001._iSensorName = value.ToString();
			}
		}
		
		[RefreshProperties(RefreshProperties.Repaint)]
		[Category("Tagnames")]
		[DisplayName("QT002 Code")]
		
		public string _iQT002
		{
			get{
				return _QT002;
			}
			set{
				_QT002 = value;
				sQT002._iSensorName = value.ToString();
			}
		}
		
		[RefreshProperties(RefreshProperties.Repaint)]
		[Category("Tagnames")]
		[DisplayName("QT003 Code")]
		
		public string _iQT003
		{
			get{
				return _QT003;
			}
			set{
				_QT003 = value;
				sQT003._iSensorName = value.ToString();
			}
		}
		
		[RefreshProperties(RefreshProperties.Repaint)]
		[Category("Tagnames")]
		[DisplayName("QT010 Code")]
		
		public string _iQT010
		{
			get{
				return _QT010;
			}
			set{
				_QT010 = value;
				sQT010._iSensorName = value.ToString();
			}
		}
	}
}
