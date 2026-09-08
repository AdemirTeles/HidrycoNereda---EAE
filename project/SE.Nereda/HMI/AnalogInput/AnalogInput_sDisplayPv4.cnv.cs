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
	public partial class sDisplayPv4 : NxtControl.GuiFramework.HMISymbol
	{
		private string _Unit = "%";
		string UnitOut;
		string InUnit;
		public sDisplayPv4()
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
			get
			{
				return _Unit;
			}
			set
			{
				_Unit = value ?? "";
				UnitOut = _Unit;

				if (Unit != null){
					Unit.Text = _Unit;
					InUnit = _Unit;
				}
				/*
				 * À activer seulement si l'événement doit être envoyé
				 * lorsque la propriété Unit est modifiée.
				 */
				// FireEvent_CNF_UNIT(UnitOut);
			}
		}

		void ChFailValueChanged(object sender, ValueChangedEventArgs e)
		{
			// TODO: Implement ChFailValueChanged
			IOChannelFail.Visible = (bool)e.Value;
		}
	}
}
