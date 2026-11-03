/*
 * Hidryco - tela UCT_200_01
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
	/// Summary description for UCT_200_01.
	/// </summary>
	partial class UCT_200_01
	{
		#region Component Designer generated code
		private void InitializeComponent()
		{
			this.btnResetGeral = new NxtControl.GuiFramework.DrawnButton();
			this.skid = new Hidryco.HidrycoLib.Symbols.UCT_PreTratamento.sSkid();
			// 
			// skid
			// 
			this.skid.BeginInit();
			this.skid.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 0D, 0D);
			this.skid.Name = "skid";
			this.skid.SecurityToken = ((uint)(4294967295u));
			this.skid.TagName = "8562B7A48F2304C1";
			this.skid.EndInit();
			// 
			// UCT_200_01
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(1366D)), ((float)(698D)));
			this.Brush = new NxtControl.Drawing.Brush("CanvasBrush");
			this.Name = "UCT_200_01";
			// 
			// btnResetGeral
			// 
			this.btnResetGeral.Bounds = new NxtControl.Drawing.RectF(((float)(6D)), ((float)(662D)), ((float)(126D)), ((float)(30D)));
			this.btnResetGeral.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208))));
			this.btnResetGeral.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.btnResetGeral.InnerBorderColor = new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208)));
			this.btnResetGeral.Name = "btnResetGeral";
			this.btnResetGeral.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.btnResetGeral.Radius = 2D;
			this.btnResetGeral.Text = "Reset geral";
			this.btnResetGeral.Use3DEffect = false;
			this.btnResetGeral.Click += new System.EventHandler(this.BtnResetGeralClick);
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.skid,
			this.btnResetGeral});
			this.Size = new System.Drawing.Size(1366, 698);

		}
		private Hidryco.HidrycoLib.Symbols.UCT_PreTratamento.sSkid skid;
		private NxtControl.GuiFramework.DrawnButton btnResetGeral;
		#endregion
	}
}
