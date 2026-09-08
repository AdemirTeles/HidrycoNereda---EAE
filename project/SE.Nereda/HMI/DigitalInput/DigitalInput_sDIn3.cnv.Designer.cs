/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 6/15/2026
 * Time: 10:36 PM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.DigitalInput
{
	/// <summary>
	/// Summary description for sDIn3.
	/// </summary>
	partial class sDIn3
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.DigitalInput = new SE.App2CommonProcess.Symbols.DigitalInputBase.sRoundIndicator();
			// 
			// DigitalInput
			// 
			this.DigitalInput.BeginInit();
			this.DigitalInput.DefaultInstanceName = null;
			this.DigitalInput.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 8D, 8D);
			this.DigitalInput.FalseColor = new NxtControl.Drawing.Color("SE.App2Base.aaLibSymBodyPassive");
			this.DigitalInput.FalseText = "TxtOFF";
			this.DigitalInput.Instancelayer = SE.App2Base.SupportClasses.InstanceLayer.Base;
			this.DigitalInput.MyTagDisplayName = null;
			this.DigitalInput.Name = "DigitalInput";
			this.DigitalInput.SecurityToken = ((uint)(4294967175u));
			this.DigitalInput.TagName = "DigitalInput";
			this.DigitalInput.TrueColor = new NxtControl.Drawing.Color("SE.App2Base.aaLibSymBodyActive");
			this.DigitalInput.TrueText = "TxtON";
			this.DigitalInput.EndInit();
			// 
			// sDIn3
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.DigitalInput});
			this.SymbolSize = new System.Drawing.Size(200, 200);

		}
		private SE.App2CommonProcess.Symbols.DigitalInputBase.sRoundIndicator DigitalInput;
		#endregion
	}
}
