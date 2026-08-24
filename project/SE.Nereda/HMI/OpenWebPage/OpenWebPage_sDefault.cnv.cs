/*
 * Created by EcoStruxure Automation Expert.
 * User: SESA685388
 * Date: 6/26/2024
 * Time: 10:11 AM
 * 
 */

using System;
using NxtControl.GuiFramework;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace SE.Nereda.Symbols.OpenWebPage
{
	/// <summary>
	/// Description of sDefault.
	/// </summary>
	public partial class sDefault : NxtControl.GuiFramework.HMISymbol
	{
		public sDefault()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
		}

		void DrawnButton1Click(object sender, EventArgs e)
		{
			// TODO: Implement DrawnButton1Click
						
			string url = URL.Value.ToString();
			OpenWebPage(url);
		}
		

		
		void OpenWebPage(string url)
		{
			
			// For Linux
			if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux)) {
				try {
					// \/\/ Créer un nouveau processus avec la commande \"xdg-open\" (utilisée par défaut dans de nombreux environnements Linux pour ouvrir des URLs)
					Process.Start("xdg-open", url);
				} catch (Exception ex) {
					//ErrorText.Text = ex.Message;
				}
			}
			
			
			// For Windows
			if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows)) {
				try {
					Process.Start(url);
				} catch (Exception ex) {
					//ErrorText.Text = ex.Message;
				}
			}
       
        
		}
	}
}
