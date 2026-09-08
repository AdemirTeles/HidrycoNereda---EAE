/*
 * Criado pelo EcoStruxure Automation Expert.
 * Usuário:  
 * Data: 23/08/2026
 * Tempo: 17:03
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.SludgeBufferLogic_2
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
			this.Wait = new SE.Nereda.Symbols.Phase.sDefault();
			this.SludgeDischarge = new SE.Nereda.Symbols.Phase.sDefault();
			this.WaterDischarge = new SE.Nereda.Symbols.Phase.sDefault();
			// 
			// Feed
			// 
			this.Feed.BeginInit();
			this.Feed._iReactorID = "";
			this.Feed.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 8D, 8D);
			this.Feed.Name = "Feed";
			this.Feed.SecurityToken = ((uint)(4294967295u));
			this.Feed.StateTextPosition = SE.Nereda.Symbols.Phase.sDefault.ShowReactorName.NoReactorName;
			this.Feed.TagName = "Feed";
			this.Feed.EndInit();
			// 
			// Wait
			// 
			this.Wait.BeginInit();
			this.Wait._iReactorID = "";
			this.Wait.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 8D, 40D);
			this.Wait.Name = "Wait";
			this.Wait.SecurityToken = ((uint)(4294967295u));
			this.Wait.StateTextPosition = SE.Nereda.Symbols.Phase.sDefault.ShowReactorName.NoReactorName;
			this.Wait.TagName = "Wait";
			this.Wait.EndInit();
			// 
			// SludgeDischarge
			// 
			this.SludgeDischarge.BeginInit();
			this.SludgeDischarge._iReactorID = "";
			this.SludgeDischarge.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 8D, 72D);
			this.SludgeDischarge.Name = "SludgeDischarge";
			this.SludgeDischarge.SecurityToken = ((uint)(4294967295u));
			this.SludgeDischarge.StateTextPosition = SE.Nereda.Symbols.Phase.sDefault.ShowReactorName.NoReactorName;
			this.SludgeDischarge.TagName = "SludgeDischarge";
			this.SludgeDischarge.EndInit();
			// 
			// WaterDischarge
			// 
			this.WaterDischarge.BeginInit();
			this.WaterDischarge._iReactorID = "";
			this.WaterDischarge.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 8D, 101D);
			this.WaterDischarge.Name = "WaterDischarge";
			this.WaterDischarge.SecurityToken = ((uint)(4294967295u));
			this.WaterDischarge.StateTextPosition = SE.Nereda.Symbols.Phase.sDefault.ShowReactorName.NoReactorName;
			this.WaterDischarge.TagName = "WaterDischarge";
			this.WaterDischarge.EndInit();
			// 
			// sDefault
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.Feed,
			this.Wait,
			this.SludgeDischarge,
			this.WaterDischarge});
			this.SymbolSize = new System.Drawing.Size(480, 200);

		}
		private SE.Nereda.Symbols.Phase.sDefault Feed;
		private SE.Nereda.Symbols.Phase.sDefault Wait;
		private SE.Nereda.Symbols.Phase.sDefault SludgeDischarge;
		private SE.Nereda.Symbols.Phase.sDefault WaterDischarge;
		#endregion
	}
}
