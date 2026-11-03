/*
 * Hidryco - EEE_Bruto - sBoiaH
 * Boia LSH-05 (nivel alto): a boia sobe/desce no cabo; verde = normal, vermelha = perigo (levantada), cinza = sem leitura.
 * O estado aparece escrito ao lado (levantada / abaixada).
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Symbols.EEE_Bruto
{
	/// <summary>
	/// Summary description for sBoiaH.
	/// </summary>
	partial class sBoiaH
	{

		#region Component Designer generated code
		private void InitializeComponent()
		{
			this.fundo = new NxtControl.GuiFramework.Rectangle();
			this.cabo = new NxtControl.GuiFramework.Line();
			this.boia = new NxtControl.GuiFramework.Ellipse();
			this.estado = new NxtControl.GuiFramework.FreeText();
			this.xPos = new System.HMI.Symbols.Base.Execute<bool>();
			this.abrir = new NxtControl.GuiFramework.DrawnButton();
			//
			// fundo
			//
			this.fundo.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(112D)), ((float)(50D)));
			this.fundo.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("Transparent"));
			this.fundo.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.fundo.Name = "fundo";
			this.fundo.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			//
			// cabo
			//
			this.cabo.EndPoint = new NxtControl.Drawing.PointF(18D, 25D);
			this.cabo.Name = "cabo";
			this.cabo.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.cabo.StartPoint = new NxtControl.Drawing.PointF(18D, 0D);
			//
			// boia
			//
			this.boia.Bounds = new NxtControl.Drawing.RectF(((float)(2D)), ((float)(25D)), ((float)(32D)), ((float)(22D)));
			this.boia.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(180)), ((byte)(180)), ((byte)(180))));
			this.boia.Name = "boia";
			this.boia.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(30)), ((byte)(30)), ((byte)(30))), 2.5F, NxtControl.Drawing.DashStyle.Solid);
			//
			// estado
			//
			this.estado.Color = new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110)));
			this.estado.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.estado.Location = new NxtControl.Drawing.PointF(40D, 28D);
			this.estado.Name = "estado";
			this.estado.Text = "sem leitura";
			//
			// xPos
			//
			this.xPos.BeginInit();
			this.xPos.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xPos.IsOnlyInput = true;
			this.xPos.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xPos.Name = "xPos";
			this.xPos.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xPos.TagName = "STS_BOIA_H";
			this.xPos.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.PosValueChanged);
			this.xPos.EndInit();
			//
			// abrir
			//
			this.abrir.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(112D)), ((float)(50D)));
			this.abrir.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("Transparent"));
			this.abrir.ButtonPushedBrush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("Transparent"));
			this.abrir.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.abrir.Name = "abrir";
			this.abrir.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("fpDefault", NxtControl.GuiFramework.MouseButtonType.Click));
			this.abrir.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.abrir.Radius = 2D;
			this.abrir.Text = "";
			this.abrir.TextColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.abrir.TextColorMouseDown = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.abrir.Use3DEffect = false;
			//
			// sBoiaH
			//
			this.Name = "sBoiaH";
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.fundo,
			this.cabo,
			this.boia,
			this.estado,
			this.xPos,
			this.abrir});
			this.SymbolSize = new System.Drawing.Size(112, 50);

		}
		private NxtControl.GuiFramework.Rectangle fundo;
		private NxtControl.GuiFramework.Line cabo;
		private NxtControl.GuiFramework.Ellipse boia;
		private NxtControl.GuiFramework.FreeText estado;
		private System.HMI.Symbols.Base.Execute<bool> xPos;
		private NxtControl.GuiFramework.DrawnButton abrir;
		#endregion
	}
}
