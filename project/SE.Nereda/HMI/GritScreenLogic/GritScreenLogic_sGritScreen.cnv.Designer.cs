/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 6/16/2026
 * Time: 2:42 PM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.GritScreenLogic
{
	/// <summary>
	/// Summary description for sGritScreen.
	/// </summary>
	partial class sGritScreen
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sGritScreen));
			this.GSRunning = new NxtControl.GuiFramework.Rectangle();
			this.GSStopped = new NxtControl.GuiFramework.Rectangle();
			// 
			// GSRunning
			// 
			this.GSRunning.Bounds = new NxtControl.Drawing.RectF(((float)(104D)), ((float)(72D)), ((float)(78D)), ((float)(34.285713195800781D)));
			this.GSRunning.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.GSRunning.ImageBytes = resources.GetString("GSRunning.ImageBytes");
			this.GSRunning.Name = "GSRunning";
			// 
			// GSStopped
			// 
			this.GSStopped.Bounds = new NxtControl.Drawing.RectF(((float)(104D)), ((float)(72D)), ((float)(78D)), ((float)(34D)));
			this.GSStopped.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.GSStopped.ImageBytes = resources.GetString("GSStopped.ImageBytes");
			this.GSStopped.Name = "GSStopped";
			// 
			// sGritScreen
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.GSRunning,
			this.GSStopped});
			this.SymbolSize = new System.Drawing.Size(272, 200);

		}
		private NxtControl.GuiFramework.Rectangle GSRunning;
		private NxtControl.GuiFramework.Rectangle GSStopped;
		#endregion
	}
}
