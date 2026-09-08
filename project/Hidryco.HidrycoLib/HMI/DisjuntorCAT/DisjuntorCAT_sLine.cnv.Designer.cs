/*
 * Criado pelo EcoStruxure Automation Expert.
 * Usuário:  
 * Data: 08/06/2026
 * Tempo: 16:17
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Symbols.DisjuntorCAT
{
	/// <summary>
	/// Summary description for sLine.
	/// </summary>
	partial class sLine
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.line1 = new NxtControl.GuiFramework.Line();
			this.stsDisjuntorLigado = new System.HMI.Symbols.Base.Execute<bool>();
			// 
			// line1
			// 
			this.line1.EndPoint = new NxtControl.Drawing.PointF(160D, 128D);
			this.line1.Name = "line1";
			this.line1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1.5F, NxtControl.Drawing.DashStyle.Solid);
			this.line1.StartPoint = new NxtControl.Drawing.PointF(16D, 128D);
			// 
			// stsDisjuntorLigado
			// 
			this.stsDisjuntorLigado.BeginInit();
			this.stsDisjuntorLigado.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.stsDisjuntorLigado.IsOnlyInput = true;
			this.stsDisjuntorLigado.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.stsDisjuntorLigado.Name = "stsDisjuntorLigado";
			this.stsDisjuntorLigado.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.stsDisjuntorLigado.TagName = "stsDisjuntorLigado";
			this.stsDisjuntorLigado.Value = false;
			this.stsDisjuntorLigado.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.StsDisjuntorLigadoValueChanged);
			this.stsDisjuntorLigado.EndInit();
			// 
			// sLine
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.line1,
			this.stsDisjuntorLigado});
			this.SymbolSize = new System.Drawing.Size(200, 200);

		}
		private NxtControl.GuiFramework.Line line1;
		private System.HMI.Symbols.Base.Execute<bool> stsDisjuntorLigado;
		#endregion
	}
}
