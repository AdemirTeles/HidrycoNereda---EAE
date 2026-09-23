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
	partial class sPhases
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
			this.LowerLevel = new SE.Nereda.Symbols.Phase.sDefault();
			this.MetalDosing = new SE.Nereda.Symbols.Phase.sDefault();
			this.VentAerationGrid = new SE.Nereda.Symbols.Phase.sDefault();
			this.VentSludgeGrid = new SE.Nereda.Symbols.Phase.sDefault();
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
			// Aerate
			// 
			this.Aerate.BeginInit();
			this.Aerate._iReactorID = "";
			this.Aerate.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 8D, 72D);
			this.Aerate.Name = "Aerate";
			this.Aerate.SecurityToken = ((uint)(4294967295u));
			this.Aerate.StateTextPosition = SE.Nereda.Symbols.Phase.sDefault.ShowReactorName.NoReactorName;
			this.Aerate.TagName = "Aerate";
			this.Aerate.EndInit();
			// 
			// Wait
			// 
			this.Wait.BeginInit();
			this.Wait._iReactorID = "";
			this.Wait.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 8D, 136D);
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
			this.SludgeDischarge.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 8D, 168D);
			this.SludgeDischarge.Name = "SludgeDischarge";
			this.SludgeDischarge.SecurityToken = ((uint)(4294967295u));
			this.SludgeDischarge.StateTextPosition = SE.Nereda.Symbols.Phase.sDefault.ShowReactorName.NoReactorName;
			this.SludgeDischarge.TagName = "SludgeDischarge";
			this.SludgeDischarge.EndInit();
			// 
			// LowerLevel
			// 
			this.LowerLevel.BeginInit();
			this.LowerLevel._iReactorID = "";
			this.LowerLevel.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 8D, 40D);
			this.LowerLevel.Name = "LowerLevel";
			this.LowerLevel.SecurityToken = ((uint)(4294967295u));
			this.LowerLevel.StateTextPosition = SE.Nereda.Symbols.Phase.sDefault.ShowReactorName.NoReactorName;
			this.LowerLevel.TagName = "LowerLevel";
			this.LowerLevel.EndInit();
			// 
			// MetalDosing
			// 
			this.MetalDosing.BeginInit();
			this.MetalDosing._iReactorID = "";
			this.MetalDosing.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 8D, 104D);
			this.MetalDosing.Name = "MetalDosing";
			this.MetalDosing.SecurityToken = ((uint)(4294967295u));
			this.MetalDosing.StateTextPosition = SE.Nereda.Symbols.Phase.sDefault.ShowReactorName.NoReactorName;
			this.MetalDosing.TagName = "MetalDosing";
			this.MetalDosing.EndInit();
			// 
			// VentAerationGrid
			// 
			this.VentAerationGrid.BeginInit();
			this.VentAerationGrid._iReactorID = "";
			this.VentAerationGrid.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 8D, 200D);
			this.VentAerationGrid.Name = "VentAerationGrid";
			this.VentAerationGrid.SecurityToken = ((uint)(4294967295u));
			this.VentAerationGrid.StateTextPosition = SE.Nereda.Symbols.Phase.sDefault.ShowReactorName.NoReactorName;
			this.VentAerationGrid.TagName = "VentAerationGrid";
			this.VentAerationGrid.EndInit();
			// 
			// VentSludgeGrid
			// 
			this.VentSludgeGrid.BeginInit();
			this.VentSludgeGrid._iReactorID = "";
			this.VentSludgeGrid.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 8D, 232D);
			this.VentSludgeGrid.Name = "VentSludgeGrid";
			this.VentSludgeGrid.SecurityToken = ((uint)(4294967295u));
			this.VentSludgeGrid.StateTextPosition = SE.Nereda.Symbols.Phase.sDefault.ShowReactorName.NoReactorName;
			this.VentSludgeGrid.TagName = "VentSludgeGrid";
			this.VentSludgeGrid.EndInit();
			// 
			// sPhases
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.Feed,
			this.Aerate,
			this.Wait,
			this.SludgeDischarge,
			this.LowerLevel,
			this.MetalDosing,
			this.VentAerationGrid,
			this.VentSludgeGrid});
			this.SymbolSize = new System.Drawing.Size(488, 288);

		}
		private SE.Nereda.Symbols.Phase.sDefault Feed;
		private SE.Nereda.Symbols.Phase.sDefault Aerate;
		private SE.Nereda.Symbols.Phase.sDefault Wait;
		private SE.Nereda.Symbols.Phase.sDefault SludgeDischarge;
		private SE.Nereda.Symbols.Phase.sDefault LowerLevel;
		private SE.Nereda.Symbols.Phase.sDefault MetalDosing;
		private SE.Nereda.Symbols.Phase.sDefault VentAerationGrid;
		private SE.Nereda.Symbols.Phase.sDefault VentSludgeGrid;
		#endregion
	}
}
