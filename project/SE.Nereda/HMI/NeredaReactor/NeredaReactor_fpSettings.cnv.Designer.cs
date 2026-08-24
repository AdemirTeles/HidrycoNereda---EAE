/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 6/12/2026
 * Time: 9:39 AM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using NxtControl.GuiFramework;

namespace SE.Nereda.Faceplates.NeredaReactor
{
	/// <summary>
	/// Summary description for fpSettings.
	/// </summary>
	partial class fpSettings
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.sDefault1 = new SE.Nereda.Symbols.CmdFeed.sDefault();
			this.sDefault2 = new SE.Nereda.Symbols.CmdAerate.sDefault();
			this.sDefault3 = new SE.Nereda.Symbols.CmdSludgeDischarge.sDefault();
			// 
			// sDefault1
			// 
			this.sDefault1.BeginInit();
			this.sDefault1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 8D, 8D);
			this.sDefault1.Name = "sDefault1";
			this.sDefault1.SecurityToken = ((uint)(4294967295u));
			this.sDefault1.TagName = "ReactorLogic.LogicFeed";
			this.sDefault1.EndInit();
			// 
			// sDefault2
			// 
			this.sDefault2.BeginInit();
			this.sDefault2.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 8D, 72D);
			this.sDefault2.Name = "sDefault2";
			this.sDefault2.SecurityToken = ((uint)(4294967295u));
			this.sDefault2.TagName = "ReactorLogic.LogicAerate";
			this.sDefault2.EndInit();
			// 
			// sDefault3
			// 
			this.sDefault3.BeginInit();
			this.sDefault3.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 8D, 264D);
			this.sDefault3.Name = "sDefault3";
			this.sDefault3.SecurityToken = ((uint)(4294967295u));
			this.sDefault3.TagName = "ReactorLogic.LogicSludgeDischarge";
			this.sDefault3.EndInit();
			// 
			// fpSettings
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(384D)), ((float)(448D)));
			this.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(154)), ((byte)(154)), ((byte)(154))));
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.sDefault1,
			this.sDefault2,
			this.sDefault3});
			this.Size = new System.Drawing.Size(384, 448);
			this.Title = "Reactor Settings";

		}
		private SE.Nereda.Symbols.CmdFeed.sDefault sDefault1;
		private SE.Nereda.Symbols.CmdAerate.sDefault sDefault2;
		private SE.Nereda.Symbols.CmdSludgeDischarge.sDefault sDefault3;
		#endregion
	}
}
