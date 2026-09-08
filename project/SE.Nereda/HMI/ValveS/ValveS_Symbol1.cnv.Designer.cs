/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 7/10/2026
 * Time: 3:29 PM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.ValveS
{
	/// <summary>
	/// Summary description for Symbol1.
	/// </summary>
	partial class Symbol1
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.State = new SE.Nereda.Symbols.ActState.sDefault();
			this.freeText1 = new NxtControl.GuiFramework.FreeText();
			// 
			// State
			// 
			this.State.BeginInit();
			this.State.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 12D, 32D);
			this.State.Name = "State";
			this.State.SecurityToken = ((uint)(4294967295u));
			this.State.TagName = "State";
			this.State.ActuatorStatus += new SE.Nereda.Symbols.ActState.sDefault.ActState(this.StateActuatorStatus);
			this.State.EndInit();
			// 
			// freeText1
			// 
			this.freeText1.Color = new NxtControl.Drawing.Color("LabelTextColor");
			this.freeText1.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.freeText1.Location = new NxtControl.Drawing.PointF(32D, 56D);
			this.freeText1.Name = "freeText1";
			this.freeText1.Text = "Text";
			// 
			// Symbol1
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.State,
			this.freeText1});
			this.SymbolSize = new System.Drawing.Size(200, 200);

		}
		private SE.Nereda.Symbols.ActState.sDefault State;
		private NxtControl.GuiFramework.FreeText freeText1;
		#endregion
	}
}
