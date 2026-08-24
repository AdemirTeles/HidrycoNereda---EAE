/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 7/10/2026
 * Time: 4:53 PM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.OC_DONE
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
			this.OC_Done = new System.HMI.Symbols.Base.Execute<bool>();
			// 
			// OC_Done
			// 
			this.OC_Done.BeginInit();
			this.OC_Done.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 404D, 520D);
			this.OC_Done.IsOnlyInput = true;
			this.OC_Done.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.OC_Done.Name = "OC_Done";
			this.OC_Done.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.OC_Done.TagName = "";
			this.OC_Done.Value = false;
			this.OC_Done.OutputValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.OC_DoneOutputValueChanged);
			this.OC_Done.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.OC_DoneValueChanged);
			this.OC_Done.EndInit();
			// 
			// sDefault
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.OC_Done});
			this.SymbolSize = new System.Drawing.Size(600, 400);

		}
		private System.HMI.Symbols.Base.Execute<bool> OC_Done;
		#endregion
	}
}
