/*
 * Created by EcoStruxure Automation Expert.
 * User: SESA713705
 * Date: 8/20/2024
 * Time: 11:59 AM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.KeepCurrentOpCdtLogic
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
			this.NeedUpdate = new System.HMI.Symbols.Base.Execute<bool>();
			// 
			// NeedUpdate
			// 
			this.NeedUpdate.BeginInit();
			this.NeedUpdate.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 132D, 222D);
			this.NeedUpdate.IsOnlyInput = true;
			this.NeedUpdate.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.NeedUpdate.Name = "NeedUpdate";
			this.NeedUpdate.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.NeedUpdate.TagName = "";
			this.NeedUpdate.Value = false;
			this.NeedUpdate.EndInit();
			// 
			// sDefault
			// 
			this.Name = "sDefault";
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.NeedUpdate});
			this.SymbolSize = new System.Drawing.Size(600, 400);

		}
		private System.HMI.Symbols.Base.Execute<bool> NeedUpdate;
		#endregion
	}
}
