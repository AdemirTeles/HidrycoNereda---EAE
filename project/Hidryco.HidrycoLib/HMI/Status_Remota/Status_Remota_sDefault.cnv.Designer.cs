/*
 * Hidryco - Status_Remota - sDefault
 * Estado da comunicacao da remota: verde comunicando, amarelo sem comunicacao, cinza aguardando.
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Symbols.Status_Remota
{
	/// <summary>
	/// Summary description for sDefault.
	/// </summary>
	partial class sDefault
	{

		#region Component Designer generated code
		private void InitializeComponent()
		{
			this.fundo = new NxtControl.GuiFramework.Rectangle();
			this.tEst = new NxtControl.GuiFramework.FreeText();
			this.xEST = new System.HMI.Symbols.Base.Execute<short>();
			// 
			// fundo
			// 
			this.fundo.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(150D)), ((float)(24D)));
			this.fundo.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(190)), ((byte)(190)), ((byte)(190))));
			this.fundo.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.fundo.Name = "fundo";
			this.fundo.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(96)), ((byte)(96)), ((byte)(96))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// tEst
			// 
			this.tEst.Color = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.tEst.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.tEst.Location = new NxtControl.Drawing.PointF(6D, 4D);
			this.tEst.Name = "tEst";
			this.tEst.Text = "AGUARDANDO";
			// 
			// xEST
			// 
			this.xEST.BeginInit();
			this.xEST.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xEST.IsOnlyInput = true;
			this.xEST.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xEST.Name = "xEST";
			this.xEST.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xEST.TagName = "STS_ESTADO";
			this.xEST.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XESTValueChanged);
			this.xEST.EndInit();
			// 
			// sDefault
			// 
			this.Name = "sDefault";
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.fundo,
			this.tEst,
			this.xEST});
			this.SymbolSize = new System.Drawing.Size(150, 24);

		}
		private NxtControl.GuiFramework.Rectangle fundo;
		private NxtControl.GuiFramework.FreeText tEst;
		private System.HMI.Symbols.Base.Execute<short> xEST;
		#endregion
	}
}
