/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 6/7/2026
 * Time: 3:25 PM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.ReactorLogic
{
	/// <summary>
	/// Summary description for sDefault.
	/// </summary>
	partial class sDefault
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.Feed = new SE.Nereda.Symbols.Phase.sDefault();
			this.Aerate = new SE.Nereda.Symbols.Phase.sDefault();
			this.Wait = new SE.Nereda.Symbols.Phase.sDefault();
			this.SludgeDischarge = new SE.Nereda.Symbols.Phase.sDefault();
			this.Vent = new SE.Nereda.Symbols.Phase.sDefault();
			// 
			// Feed
			// 
			this.Feed.BeginInit();
			this.Feed.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 8D, 8D);
			this.Feed.Name = "Feed";
			this.Feed.SecurityToken = ((uint)(4294967295u));
			this.Feed.TagName = "Feed";
			this.Feed.EndInit();
			// 
			// Aerate
			// 
			this.Aerate.BeginInit();
			this.Aerate.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 8D, 40D);
			this.Aerate.Name = "Aerate";
			this.Aerate.SecurityToken = ((uint)(4294967295u));
			this.Aerate.TagName = "Aerate";
			this.Aerate.EndInit();
			// 
			// Wait
			// 
			this.Wait.BeginInit();
			this.Wait.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 8D, 72D);
			this.Wait.Name = "Wait";
			this.Wait.SecurityToken = ((uint)(4294967295u));
			this.Wait.TagName = "Wait";
			this.Wait.EndInit();
			// 
			// SludgeDischarge
			// 
			this.SludgeDischarge.BeginInit();
			this.SludgeDischarge.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 8D, 104D);
			this.SludgeDischarge.Name = "SludgeDischarge";
			this.SludgeDischarge.SecurityToken = ((uint)(4294967295u));
			this.SludgeDischarge.TagName = "SludgeDischarge";
			this.SludgeDischarge.EndInit();
			// 
			// Vent
			// 
			this.Vent.BeginInit();
			this.Vent.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 8D, 136D);
			this.Vent.Name = "Vent";
			this.Vent.SecurityToken = ((uint)(4294967295u));
			this.Vent.TagName = "VentAeration";
			this.Vent.EndInit();
			// 
			// sDefault
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.Feed,
			this.Aerate,
			this.Wait,
			this.SludgeDischarge,
			this.Vent});
			this.SymbolSize = new System.Drawing.Size(488, 192);

		}
		private SE.Nereda.Symbols.Phase.sDefault Feed;
		private SE.Nereda.Symbols.Phase.sDefault Aerate;
		private SE.Nereda.Symbols.Phase.sDefault Wait;
		private SE.Nereda.Symbols.Phase.sDefault SludgeDischarge;
		private SE.Nereda.Symbols.Phase.sDefault Vent;
		#endregion
	}
}
