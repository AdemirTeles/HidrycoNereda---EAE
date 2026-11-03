/*
 * Created by EcoStruxure Automation Expert.
 * User: SESA583220
 * Date: 10/4/2022
 * Time: 8:49 AM
 * 
 */

using System;
using NxtControl.GuiFramework;
using System.Threading.Tasks;

namespace SE.Nereda.Symbols.Mode
{
	/// <summary>
	/// Description of ResetCommand.
	/// </summary>
	public partial class ResetReactor3 : NxtControl.GuiFramework.HMISymbol
	{
		public ResetReactor3()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
		}

		void Reset_CommandOutputValueChanged(object sender, ValueChangedEventArgs e)
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
