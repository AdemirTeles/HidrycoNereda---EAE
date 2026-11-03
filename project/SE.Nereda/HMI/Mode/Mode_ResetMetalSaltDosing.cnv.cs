/*
 * Created by EcoStruxure Automation Expert.
 * User: SESA713705
 * Date: 8/30/2024
 * Time: 12:34 PM
 * 
 */

using System;
using NxtControl.GuiFramework;
using System.Threading.Tasks;


namespace SE.Nereda.Symbols.Mode
{
	/// <summary>
	/// Description of ResetMetalSaltDosing.
	/// </summary>
	public partial class ResetMetalSaltDosing : NxtControl.GuiFramework.HMISymbol
	{
		public ResetMetalSaltDosing()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
		}

		void Reset_CommandValueChanged(object sender, ValueChangedEventArgs e)
		{
			// So no clique (TRUE). Devolve o botao a FALSE em 1 s na thread da IHM: antes o Checked era mudado
			// fora dela (ContinueWith roda num thread do pool).
			if (!(e.Value is bool) || !(bool)e.Value) return;
			System.Threading.SynchronizationContext ui = System.Threading.SynchronizationContext.Current;
			Task.Delay(1000).ContinueWith(u =>
			{
				if (ui != null) ui.Post(s => Reset_Command.Checked = false, null);
				else Reset_Command.Checked = false;
			});
		}


	}
}
