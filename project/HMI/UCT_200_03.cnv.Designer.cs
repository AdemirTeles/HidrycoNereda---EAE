/*
 * Hidryco - tela UCT_200_03
 * ISA-101: estados e alarmes vem dos simbolos dos CATs.
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;

using NxtControl.GuiFramework;

namespace HMI.Main.Canvases
{
	/// <summary>
	/// Summary description for UCT_200_03.
	/// </summary>
	partial class UCT_200_03
	{
		#region Component Designer generated code
		private void InitializeComponent()
		{
			this.skid = new Hidryco.HidrycoLib.Symbols.UCT_PreTratamento.sSkid();
			// 
			// skid
			// 
			this.skid.BeginInit();
			this.skid.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 0D, 0D);
			this.skid.Name = "skid";
			this.skid.SecurityToken = ((uint)(4294967295u));
			this.skid.TagName = "EB77BC463289AB0B";
			this.skid.EndInit();
			// 
			// UCT_200_03
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(1366D)), ((float)(698D)));
			this.Brush = new NxtControl.Drawing.Brush("CanvasBrush");
			this.Name = "UCT_200_03";
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.skid});
			this.Size = new System.Drawing.Size(1366, 698);

		}
		private Hidryco.HidrycoLib.Symbols.UCT_PreTratamento.sSkid skid;
		#endregion
	}
}
