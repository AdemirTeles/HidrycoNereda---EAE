/*
 * Hidryco - Agua_Reuso - sBoiaL
 * Boia 1000-LSL-01 (nivel baixo): sobe/desce com a boia; verde levantada, vermelha abaixada (perigo); cinza sem comunicacao.
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Symbols.Agua_Reuso
{
	/// <summary>
	/// Summary description for sBoiaL.
	/// </summary>
	partial class sBoiaL
	{

		#region Component Designer generated code
		private void InitializeComponent()
		{
			this.fundo = new NxtControl.GuiFramework.Rectangle();
			this.boia = new NxtControl.GuiFramework.Ellipse();
			this.xPos = new System.HMI.Symbols.Base.Execute<bool>();
			this.xSemCom = new System.HMI.Symbols.Base.Execute<bool>();
			this.abrir = new NxtControl.GuiFramework.DrawnButton();
			// 
			// fundo
			// 
			this.fundo.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(32D)), ((float)(46D)));
			this.fundo.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("Transparent"));
			this.fundo.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.fundo.Name = "fundo";
			this.fundo.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// boia
			// 
			this.boia.Bounds = new NxtControl.Drawing.RectF(((float)(8D)), ((float)(28D)), ((float)(16D)), ((float)(16D)));
			this.boia.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(180)), ((byte)(180)), ((byte)(180))));
			this.boia.Name = "boia";
			this.boia.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60))), 1.5F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// xPos
			// 
			this.xPos.BeginInit();
			this.xPos.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xPos.IsOnlyInput = true;
			this.xPos.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xPos.Name = "xPos";
			this.xPos.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xPos.TagName = "STS_BOIA_NORMAL";
			this.xPos.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.PosValueChanged);
			this.xPos.EndInit();
			// 
			// xSemCom
			// 
			this.xSemCom.BeginInit();
			this.xSemCom.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xSemCom.IsOnlyInput = true;
			this.xSemCom.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xSemCom.Name = "xSemCom";
			this.xSemCom.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xSemCom.TagName = "STS_FALHA_REMOTA1";
			this.xSemCom.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.SemComValueChanged);
			this.xSemCom.EndInit();
			// 
			// abrir
			// 
			this.abrir.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(32D)), ((float)(46D)));
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
			// sBoiaL
			// 
			this.Name = "sBoiaL";
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.fundo,
			this.boia,
			this.xPos,
			this.xSemCom,
			this.abrir});
			this.SymbolSize = new System.Drawing.Size(32, 46);

		}
		private NxtControl.GuiFramework.Rectangle fundo;
		private NxtControl.GuiFramework.Ellipse boia;
		private System.HMI.Symbols.Base.Execute<bool> xPos;
		private System.HMI.Symbols.Base.Execute<bool> xSemCom;
		private NxtControl.GuiFramework.DrawnButton abrir;
		#endregion
	}
}
