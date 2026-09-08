/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 6/17/2026
 * Time: 2:55 PM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.NeredaEffluent
{
	/// <summary>
	/// Summary description for sFlushValve002.
	/// </summary>
	partial class sFlushValve002
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.sDefault2 = new SE.Nereda.Symbols.FlushGritScreenInstallation.sDefault();
			// 
			// sDefault2
			// 
			this.sDefault2.BeginInit();
			this.sDefault2.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.75D, 0D, 0D, 0.75D, 48D, 40D);
			this.sDefault2.Name = "sDefault2";
			this.sDefault2.SecurityToken = ((uint)(4294967295u));
			this.sDefault2.TagName = "EffluentLogic.FlushGritScreenInstallation";
			this.sDefault2.EndInit();
			// 
			// sFlushValve002
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.sDefault2});
			this.SymbolSize = new System.Drawing.Size(200, 200);

		}
		private SE.Nereda.Symbols.FlushGritScreenInstallation.sDefault sDefault2;
		#endregion
	}
}
