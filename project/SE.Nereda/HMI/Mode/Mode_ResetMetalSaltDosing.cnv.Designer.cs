/*
 * Created by EcoStruxure Automation Expert.
 * User: SESA713705
 * Date: 8/30/2024
 * Time: 12:34 PM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.Mode
{
	/// <summary>
	/// Summary description for ResetMetalSaltDosing.
	/// </summary>
	partial class ResetMetalSaltDosing
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.Reset_Command = new System.HMI.Symbols.Base.CheckButton();
			// 
			// Reset_Command
			// 
			this.Reset_Command.BeginInit();
			this.Reset_Command.DesignMatrix = new NxtControl.Drawing.Matrix2D(2.1D, 0D, 0D, 1.3333333333333333D, 16D, 16D);
			this.Reset_Command.FalseBrush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(78)), ((byte)(78)), ((byte)(78))));
			this.Reset_Command.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.Reset_Command.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.Reset_Command.FalseText = "Reset Metal Salt Dosing";
			this.Reset_Command.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.Reset_Command.FontScale = false;
			this.Reset_Command.InnerBorderColor = new NxtControl.Drawing.Color(((byte)(2)), ((byte)(178)), ((byte)(238)));
			this.Reset_Command.Name = "Reset_Command";
			this.Reset_Command.TagName = "ResetMetalSaltDosing";
			this.Reset_Command.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.Reset_Command.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.Reset_Command.TrueText = "Reset Metal Salt Dosing";
			this.Reset_Command.Value = false;
			this.Reset_Command.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.Reset_CommandValueChanged);
			this.Reset_Command.EndInit();
			// 
			// ResetMetalSaltDosing
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.Reset_Command});
			this.SymbolSize = new System.Drawing.Size(272, 200);

		}
		private System.HMI.Symbols.Base.CheckButton Reset_Command;
		#endregion
	}
}
