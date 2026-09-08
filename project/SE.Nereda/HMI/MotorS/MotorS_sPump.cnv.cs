/*
 * Created by EcoStruxure Automation Expert.
 * User: SESA713705 
 * Date: 6/2/2026
 * Time: 9:20 AM
 * 
 */

using System;
using NxtControl.GuiFramework;
using System.ComponentModel;

namespace SE.Nereda.Symbols.MotorS
{
	/// <summary>
	/// Description of sDefault.
	/// </summary>
	public partial class sPump : NxtControl.GuiFramework.HMISymbol
	{
		private string _MotName = "Motor";
		// ✅ ComboBox option (enum) - new field for symbol name display
		public enum SymbolNameDisplayOption
		{
		    Show,
		    Hide
		}
		private SymbolNameDisplayOption _symbolNameDisplay = SymbolNameDisplayOption.Show;
		
		public sPump()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
		}

		void StateActuatorStatus(short StateValue)
		{
			// TODO: Implement StateActuatorStatus
			// =1: Started ; =0: Stopped ; =255: Error ; =100: Power Off
			if(StateValue == 0 || StateValue == 254){
				MotBase.BrushColor = InLet.BrushColor = OutLet.BrushColor = SE.Nereda.ProjectColors.PassiveStatus;
			}
			if(StateValue == 1){
				MotBase.BrushColor = InLet.BrushColor = OutLet.BrushColor = SE.Nereda.ProjectColors.ActiveStatus;
			}
			if(StateValue == 253){
				MotBase.BrushColor = InLet.BrushColor = OutLet.BrushColor = new NxtControl.Drawing.BlinkColor("SE.Nereda.Orangwhite");
			}
			if(StateValue == 100){
				MotBase.BrushColor = InLet.BrushColor = OutLet.BrushColor = SE.Nereda.ProjectColors.PowerOFF;
			}
			if(StateValue == 10){
				MotBase.BrushColor = InLet.BrushColor = OutLet.BrushColor = SE.Nereda.ProjectColors.PassiveStatus;
			}
		}

		void OpenFpClick(object sender, EventArgs e)
		{
			// TODO: Implement OpenFpClick
			//this.Base.DoOpenFaceplate("fpDefault");
		}
		
		[RefreshProperties(RefreshProperties.Repaint)]
		[Category("Tagnames")]
		[DisplayName("MotName")]
		
		public string _iMotName
		{
			get{
				return _MotName;
			}
			set{
				_MotName = value;
				MotName.Text = value.ToString();
			}
		}
		
		// ✅ ComboBox property in PropertyGrid
		[RefreshProperties(RefreshProperties.Repaint)]
		[Category("Appearance")]
		[DisplayName("Symbol Name Display")]
		public SymbolNameDisplayOption SymbolNameDisplay
		{
		    get { return _symbolNameDisplay; }
		    set
		    {
		        _symbolNameDisplay = value;
		        ApplySymbolNameDisplay(_symbolNameDisplay);
		    }
		}
		
		
		// ✅ Central place to apply the chosen symbol name display
		private void ApplySymbolNameDisplay(SymbolNameDisplayOption display)
		{
		    if (display == SymbolNameDisplayOption.Show)
		    {
		        MotName.Visible = true;
		    }
		    else // Hide
		    {
		        MotName.Visible = false;
		    }
		}
	}
}
