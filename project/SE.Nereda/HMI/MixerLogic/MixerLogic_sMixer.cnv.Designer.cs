/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 6/16/2026
 * Time: 3:42 PM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.MixerLogic
{
	/// <summary>
	/// Summary description for sMixer.
	/// </summary>
	partial class sMixer
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sMixer));
			this.MixerOFF = new NxtControl.GuiFramework.Rectangle();
			this.MixerON = new NxtControl.GuiFramework.Rectangle();
			// 
			// MixerOFF
			// 
			this.MixerOFF.Bounds = new NxtControl.Drawing.RectF(((float)(72D)), ((float)(72D)), ((float)(52D)), ((float)(60D)));
			this.MixerOFF.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("transparent"));
			this.MixerOFF.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.MixerOFF.ImageBytes = resources.GetString("MixerOFF.ImageBytes");
			this.MixerOFF.Name = "MixerOFF";
			this.MixerOFF.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// MixerON
			// 
			this.MixerON.Bounds = new NxtControl.Drawing.RectF(((float)(72D)), ((float)(72D)), ((float)(52D)), ((float)(60D)));
			this.MixerON.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("transparent"));
			this.MixerON.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.MixerON.ImageBytes = resources.GetString("MixerON.ImageBytes");
			this.MixerON.Name = "MixerON";
			this.MixerON.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// sMixer
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.MixerOFF,
			this.MixerON});
			this.SymbolSize = new System.Drawing.Size(200, 192);

		}
		private NxtControl.GuiFramework.Rectangle MixerOFF;
		private NxtControl.GuiFramework.Rectangle MixerON;
		#endregion
	}
}
