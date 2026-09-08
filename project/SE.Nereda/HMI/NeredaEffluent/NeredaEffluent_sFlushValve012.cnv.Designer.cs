/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 6/17/2026
 * Time: 3:28 PM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.NeredaEffluent
{
	/// <summary>
	/// Summary description for sFlushValve012.
	/// </summary>
	partial class sFlushValve012
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.sDefault2 = new SE.Nereda.Symbols.FlushGritScreens.sDefault();
			// 
			// sDefault2
			// 
			this.sDefault2.BeginInit();
			this.sDefault2.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.75D, 0D, 0D, 0.75D, 32D, 16D);
			this.sDefault2.Name = "sDefault2";
			this.sDefault2.SecurityToken = ((uint)(4294967295u));
			this.sDefault2.TagName = "EffluentLogic.FlushGritScreens";
			this.sDefault2.EndInit();
			// 
			// sFlushValve012
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.sDefault2});
			this.SymbolSize = new System.Drawing.Size(200, 200);

		}
		private SE.Nereda.Symbols.FlushGritScreens.sDefault sDefault2;
		#endregion
	}
}
