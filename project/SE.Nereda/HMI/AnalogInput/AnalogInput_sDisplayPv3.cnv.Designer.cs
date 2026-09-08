/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 6/6/2026
 * Time: 4:58 PM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.AnalogInput
{
	/// <summary>
	/// Summary description for sDisplayPv3.
	/// </summary>
	partial class sDisplayPv3
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.AnalogInput = new SE.Nereda.Symbols.AnalogInputBase.sDisplayPv();
			// 
			// AnalogInput
			// 
			this.AnalogInput.BeginInit();
			this.AnalogInput.DefaultInstanceName = null;
			this.AnalogInput.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 8D, 8D);
			this.AnalogInput.Instancelayer = SE.App2Base.SupportClasses.InstanceLayer.Base;
			this.AnalogInput.MyTagDisplayName = null;
			this.AnalogInput.Name = "AnalogInput";
			this.AnalogInput.SecurityToken = ((uint)(4294967175u));
			this.AnalogInput.TagName = "AnalogInput";
			this.AnalogInput.EndInit();
			// 
			// sDisplayPv3
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.AnalogInput});
			this.SymbolSize = new System.Drawing.Size(152, 104);

		}
		private SE.Nereda.Symbols.AnalogInputBase.sDisplayPv AnalogInput;
		#endregion
	}
}
