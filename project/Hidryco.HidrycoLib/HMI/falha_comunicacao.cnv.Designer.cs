/*
 * Criado pelo EcoStruxure Automation Expert.
 * Usuário:  
 * Data: 11/03/2026
 * Tempo: 14:50
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Graphics
{
	/// <summary>
	/// Summary description for falha_comunicacao.
	/// </summary>
	partial class falha_comunicacao
	{
		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(falha_comunicacao));
			this.ellipse1 = new NxtControl.GuiFramework.Ellipse();
			this.line1 = new NxtControl.GuiFramework.Line();
			this.rectangle2 = new NxtControl.GuiFramework.Rectangle();
			// 
			// ellipse1
			// 
			this.ellipse1.Bounds = new NxtControl.Drawing.RectF(((float)(80D)), ((float)(40D)), ((float)(24D)), ((float)(24D)));
			this.ellipse1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("Transparent"));
			this.ellipse1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.ellipse1.Name = "ellipse1";
			this.ellipse1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(234)), ((byte)(22)), ((byte)(30))), 2F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// line1
			// 
			this.line1.EndPoint = new NxtControl.Drawing.PointF(84D, 60D);
			this.line1.Name = "line1";
			this.line1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(234)), ((byte)(22)), ((byte)(30))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.line1.StartPoint = new NxtControl.Drawing.PointF(100D, 44D);
			// 
			// rectangle2
			// 
			this.rectangle2.Bounds = new NxtControl.Drawing.RectF(((float)(84D)), ((float)(44D)), ((float)(16D)), ((float)(16D)));
			this.rectangle2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("Transparent"));
			this.rectangle2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle2.ImageBytes = resources.GetString("rectangle2.ImageBytes");
			this.rectangle2.Name = "rectangle2";
			this.rectangle2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// falha_comunicacao
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.rectangle2,
			this.ellipse1,
			this.line1});
			this.SymbolSize = new System.Drawing.Size(200, 148);

		}
		private NxtControl.GuiFramework.Ellipse ellipse1;
		private NxtControl.GuiFramework.Line line1;
		private NxtControl.GuiFramework.Rectangle rectangle2;
		#endregion
	}
}
